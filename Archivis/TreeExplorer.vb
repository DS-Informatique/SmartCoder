Imports System.ComponentModel
Imports SmartCoder.M_FileManager

Public Class TreeExplorer
    Public JobDone As Boolean = False
    Private _ActiveDir As Folder
    Public Property ActiveDir() As Folder
        Get
            Return _ActiveDir
        End Get
        Set(ByVal value As Folder)
            If Not IsNothing(value) Then
                If IO.Directory.Exists(value.Target) Then
                    Input_Dir.Text = value.Target
                End If
            End If
            _ActiveDir = value
        End Set
    End Property
    Private Sub Input_Dir_TextUpdate(sender As Object, e As EventArgs) Handles Input_Dir.TextUpdate
        If Input_Dir.Text.Length > 1 Then
            If IO.Directory.Exists(Input_Dir.Text) Then
                Try
                    IO.Directory.CreateDirectory(Input_Dir.Text)
                Catch ex As Exception

                End Try
            End If
            If IsNothing(ActiveDir) Then
                ActiveDir = New Folder(Input_Dir.Text)
            End If
            If LV.Items.Count - 1 > 0 Then
                LV.Items.Clear()
            End If
            IL_LV_Large.Images.Clear()
            IL_LV_Small.Images.Clear()
            LV.Columns.Clear()
            Dim C0 As New ColumnHeader
            With C0
                .Text = "Nom du Fichier"
                .Width = .Text.Length + 1
            End With
            Dim C1 As New ColumnHeader
            With C1
                .Text = "Size"
                .Width = .Text.Length + 1
            End With
            Dim C2 As New ColumnHeader
            With C2
                .Text = "Modifié"
                .Width = .Text.Length + 1
            End With
            LV.Columns.Add(C0)
            LV.Columns.Add(C1)
            LV.Columns.Add(C2)
            'Btn_Refresh.PerformClick()
        End If
        LV.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)

    End Sub

    Public Property DesktopNode As New DevComponents.AdvTree.Node("Mon PC")
    Public Property MyImageList As New ImageList
    Public Sub RefreshTree()
        Tree.Nodes.Clear()
        D = New SmartCoder.M_Computer.MyComputer.Lecteur
        MyImageList.Images.Clear()
        MyImageList.ImageSize = New Size(32, 32)
        MyImageList.ColorDepth = ColorDepth.Depth32Bit
        For Each Img As Image In D.ImageList.Images
            MyImageList.Images.Add(Img.Clone)
        Next
        Tree.ImageList = MyImageList


        DesktopNode.TagString = My.Computer.FileSystem.SpecialDirectories.Desktop
        MyImageList.Images.Add(Retrieve_Icons.GetShellIcon(DesktopNode.TagString))
        DesktopNode.ImageIndex = MyImageList.Images.Count - 1

        'Adding Documents
        Dim Docs As New DevComponents.AdvTree.Node("Document")
        Docs.TagString = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        MyImageList.Images.Add(Retrieve_Icons.GetShellIcon(Docs.TagString))
        Docs.ImageIndex = MyImageList.Images.Count - 1
        DesktopNode.Nodes.Add(Docs)


        'Adding Local Drives
        For Each lDrive As SmartCoder.MyComputer.Drive In D.Local
            Dim Dl As New DevComponents.AdvTree.Node(lDrive.Letter)
            With Dl
                .ImageIndex = lDrive.ImageIndex
                .TagString = lDrive.Letter
                .Tooltip = lDrive.Alert
            End With
            DesktopNode.Nodes.Add(Dl)
        Next

        Tree.Nodes.Add(DesktopNode)
    End Sub

    Private Sub TreeExplorer_Load(sender As Object, e As EventArgs) Handles Me.Load
        CheckForIllegalCrossThreadCalls = False
        RefreshTree()
    End Sub

#Region "<04.03.01> <Tree> [Collect_SubDir(ParentNode|DevComponents.AdvTree.Node)|String]"
    ''' <summary>
    ''' Collect sub directories from DevComponents.AdvTree.Node
    ''' </summary>
    ''' <param name="ParentNode"></param>
    ''' <returns></returns>
    Public Function Collect_SubDir(ByVal ParentNode As DevComponents.AdvTree.Node) As String
        '   e NewInfo.Walkthrough.Add("<04.03.01> Recherche de sous répertoires")
        Dim Result As String = "Not working"
        '  e NewInfo.Record("Indexation du répertoire [" & Input_Dir.Text & "]",, 1085)
        ' Cmd_Status.Execute()
        If Not IO.Directory.Exists(ParentNode.Tag.ToString) Then
            '    e NewAlert.Add("Le répertoire est incorrect [" & Tree.SelectedNode.Tag.ToString & "]", "Répertoire inexistant", 1088,, e NewInfo.Walkthrough)
            '   Cmd_Status.Execute()
            Return "Erreur"
            Exit Function
        Else
            Try
                Dim DirList As String()
                Dim Node As New DevComponents.AdvTree.Node
                DirList = IO.Directory.GetDirectories(ParentNode.Tag.ToString)
                Result = ParentNode.Tag.ToString
                Add_Path(DirList.ToString)
                If Input_Dir.Text = Nothing Or Input_Dir.Text = String.Empty Then
                    'e NewAlert.Add("Le répertoire est incorrect [" & Input_Dir.Text & "]", " If Input_Dir.Text = Nothing Or Input_Dir.Text = String.Empty Then", 1053,, e NewInfo.Walkthrough)
                    'Cmd_Status.Execute()
                    Return "Le répertoire est incorrect"
                    Exit Function
                Else
                    If DirList.Length = ParentNode.Nodes.Count Then
                    Else
                        For i = 0 To DirList.Length - 1
                            Node = New DevComponents.AdvTree.Node
                            Node.Tag = DirList(i)
                            ' Dim Fol As New Folder(DirList(i).ToString)
                            ' Dim Val As String = "[ " & Fol.GetFileSize().ToString & " ]"
                            Node.Text = DirList(i).Substring(DirList(i).LastIndexOf("\") + 1)
                            MyImageList.Images.Add(Retrieve_Icons.GetShellIcon(DirList(i).ToString))
                            Node.ImageIndex = MyImageList.Images.Count - 1
                            ParentNode.Nodes.Add(Node)
                            '                  e NewInfo.Record(DirList(i).ToString & vbNewLine,, 1116)
                        Next
                    End If
                End If
            Catch ex As Exception
                If ex.ToString.Contains("is denied.") Then
                    '         e NewAlert.Add(ex)
                    '        e NewAlert.Add("Le répertoire est vérouillé [" & Tree.SelectedNode.Tag.ToString & "]", "ex.ToString.Contains(is denied)", 1123,, e NewInfo.Walkthrough)
                Else
                    '       e NewError.Add(ex)
                End If
            Finally
                '  Cmd_Status.Execute()
            End Try
        End If
        ' e NewInfo.Add()
        'Cmd_Status.Execute()
        Return Result
    End Function
#End Region
#Region "<3> [Subs]"
    ''' <summary>
    ''' Add a Dir Path without duplicate
    ''' </summary>
    ''' <param name="Path"></param>
    Public Sub Add_Path(ByVal Path As String)
        Dim Addit As Boolean = True
        If Input_Dir.Items.Count - 1 < 0 Then
            If Not Path = String.Empty Then
                If Path = "System.String[]" Then
                Else
                    Input_Dir.Items.Add(Path)
                    Input_Dir.SelectedIndex = Input_Dir.Items.Count - 1
                End If
            End If
        Else
            For n = 0 To Input_Dir.Items.Count - 1
                If Input_Dir.Items(n).ToString = Path Then
                    Addit = False
                End If
            Next
            If Addit = True Then
                If Not Path = String.Empty Then
                    If Path = "System.String[]" Then
                    Else
                        Input_Dir.Items.Add(Path)
                        Input_Dir.SelectedIndex = Input_Dir.Items.Count - 1
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub Tree_Click(sender As Object, e As EventArgs) Handles Tree.Click
        If Not IsNothing(Tree.SelectedNode) Then
            If Tree.SelectedNode.TagString.Length > 1 Then
                Add_Path(Tree.SelectedNode.TagString)
                Input_Dir.Text = Tree.SelectedNode.TagString
                Collect_SubDir(Tree.SelectedNode)
            End If
        End If
    End Sub

    Private Sub CMD_Index_Executed(sender As Object, e As EventArgs) Handles CMD_Index.Executed

    End Sub

    Private Sub Btn_Refresh_Click(sender As Object, e As EventArgs) Handles Btn_Refresh.Click
        ActiveDir = New Folder(Input_Dir.Text)
        ActiveDir.Fichiers = New List(Of Fichier)
        ActiveDir.Fichiers = ActiveDir.EnumerateFichier("*.*", IO.SearchOption.AllDirectories)
        If BW.IsBusy Then
        Else
            BW.RunWorkerAsync()
        End If

    End Sub

    Private Sub BW_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW.DoWork
        IL_LV_Large.Images.Clear()
        IL_LV_Small.Images.Clear()
        LV.Columns.Clear()
        Dim C0 As New ColumnHeader
        With C0
            .Text = "Nom du Fichier"
            .Width = .Text.Length + 1
        End With
        Dim C1 As New ColumnHeader
        With C1
            .Text = "Size"
            .Width = .Text.Length + 1
        End With
        Dim C2 As New ColumnHeader
        With C2
            .Text = "Modifié"
            .Width = .Text.Length + 1
        End With
        LV.Columns.Add(C0)
        LV.Columns.Add(C1)
        LV.Columns.Add(C2)
        LV.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        LV.View = View.Details

        Dim i As Integer = 0
        Dim Max As Integer = ActiveDir.Fichiers.Count

        For Each Fo As Fichier In ActiveDir.Fichiers
            Dim It As New ListViewItem(Fo.FileName)
            It.SubItems.Add(Fo.FileSize.Display)
            It.SubItems.Add(Fo.Modified)
            It.Tag = Fo
            IL_LV_Large.Images.Add(Retrieve_Icons.GetShellIcon(Fo.Target))
            IL_LV_Small.Images.Add(Retrieve_Icons.GetShellIcon(Fo.Target))
            It.ImageIndex = IL_LV_Large.Images.Count - 1
            LV.Items.Add(It)
            i += 1
            Pbar.Value = (i / Max) * 100
            Total.Value += 1
        Next
    End Sub

    Private Sub BW_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BW.RunWorkerCompleted




        Pbar.Value = 0
        Try
            LV.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)

        Catch ex As Exception

        End Try


    End Sub

    Private Sub LV_DrawItem(sender As Object, e As DrawListViewItemEventArgs) Handles LV.DrawItem
        Output_Label.Text = "Nombre d'élément ="
        Total.Value = LV.Items.Count - 1
        If Total.Value = ActiveDir.Fichiers.Count - 1 Then
            JobDone = True
            '  SmartCoder.Jarvis.Speak("Job Done")
        End If
    End Sub
#End Region
End Class
