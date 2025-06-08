Imports System.Windows.Forms

Public Class VbNET_Class
#Region "Runtime"
    Public Temp_Class As New VbNET.Class

    Private _ActiveParent As Object
    Public Property ActiveParent() As Object
        Get
            Return _ActiveParent
        End Get
        Set(ByVal value As Object)
            If Not IsNothing(value) Then
                If IsNothing(Temp_Class) Then
                    Temp_Class = New VbNET.Class
                End If

                If TypeOf value Is VbNET.Class Then
                    Class_Parent.Text = value.Name
                    Temp_Class.ParentClass = value

                ElseIf TypeOf value Is VbNET.Module Then
                    Class_Parent.Text = value.name
                    Temp_Class.ParentModule = value
                End If
            End If
            _ActiveParent = value
        End Set
    End Property
    Dim U_Property As VbNET_Property
    Dim U_Enumeration As VbNET_Enumeration
    Dim U_Structure As VbNET_Structure
    Dim U_Sub As VbNET_Sub
    Dim U_Function As VbNET_Function
    Dim U_Runtime As VbNET_Runtime
    Dim U_Loader As VbNET_Loader
    Dim U_Class As VbNET_Class
    Dim U_Module As VbNET_Module
#End Region
    Private Sub Tables_Console_TextChanged(sender As Object, e As EventArgs) Handles Tables_Console.TextChanged
        Tables_Console.ScrollToCaret()
    End Sub

    Private Sub Tables_SelectNone_Click(sender As Object, e As EventArgs) Handles Tables_SelectNone.Click

    End Sub
    Dim ListDb As New List(Of DataBase)
    Public ActiveDataBase As DataBase
    Private Sub Database_AddNode_Click(sender As Object, e As EventArgs) Handles Database_AddNode.Click
        ActiveDataBase = New DataBase(U_DataBase1.Txt_FilePath.Text, U_DataBase1.Password.Text)
        Dim N As New DevComponents.AdvTree.Node
        N.Name = ActiveDataBase.Name
        N.Text = "[" & Me.Name & "] {" & ActiveDataBase.Tables.Count - 1 & "]"
        N.Tag = ActiveDataBase
        N.TagString = ActiveDataBase.Line.Line
        N.ImageIndex = 0
        For Each t As Table In ActiveDataBase.Tables
            Dim Tn As New DevComponents.AdvTree.Node
            Tn.Name = t.TableName
            Tn.Text = t.TableName & "{" & t.RowsCount & "}"
            Tn.Tag = t
            Tn.ImageIndex = 1
            N.Nodes.Add(Tn)
            Tables_Console.ScrollToCaret()

        Next
        Tree_Db.Nodes.Add(N)

        If IsNothing(ListDb) Then
            ListDb = New List(Of DataBase)
        End If
        ListDb.Add(ActiveDataBase)
    End Sub
    Private Sub Tables_Refresh_Click(sender As Object, e As EventArgs) Handles Tables_Refresh.Click
        If Not IsNothing(ActiveDataBase) Then
            Tables_LV.Items.Clear()
            Tables_LV.Columns.Clear()
            Tables_LV.View = View.Details
            Dim C0 As New ColumnHeader
            With C0
                .Text = "Add"
                .Width = 100
            End With
            Dim C1 As New ColumnHeader
            With C1
                .Text = "TableName"
                .Width = 150
            End With
            Dim C2 As New ColumnHeader
            With C2
                .Text = "Columns"
                .Width = 100
            End With
            Dim C3 As New ColumnHeader
            With C3
                .Text = "Rows"
                .Width = 150
            End With
            Tables_LV.Columns.Add(C0)
            Tables_LV.Columns.Add(C1)
            Tables_LV.Columns.Add(C2)
            Tables_LV.Columns.Add(C3)
            For Each Tab As Table In ActiveDataBase.Tables
                Dim It As New ListViewItem()
                It.SubItems.Add(Tab.TableName)
                It.SubItems.Add(Tab.ColumnsCount)
                It.SubItems.Add(Tab.RowsCount)
                It.ImageIndex = 1
                It.Tag = Tab
                If Tab.ColumnsCount <= 0 Then
                    It.Checked = False
                Else
                    It.Checked = True
                End If
                Tables_LV.Items.Add(It)
            Next
        End If
    End Sub
    Dim ListTablesToProcess As New List(Of Table)

    Private Sub Tables_SelectAll_Click(sender As Object, e As EventArgs) Handles Tables_SelectAll.Click

    End Sub

    Private Sub Tables_StartCreationClass_Click(sender As Object, e As EventArgs) Handles Tables_StartCreationClass.Click
        Jarvis.Speak("Creation starting.")
        Tables_Progress.Value = 0
        Tables_Progress.Maximum = 100
        If IsNothing(VirtualModule) Then
            VirtualModule = New VbNET.Module
        End If
        ListTablesToProcess = New List(Of Table)
        For Each It As ListViewItem In Tables_LV.Items
            If It.Checked = True Then
                Dim T0 As Table = It.Tag
                If Not IsNothing(T0) Then
                    ListTablesToProcess.Add(T0)
                End If
            End If
        Next
        Tables_Progress.Value = 0
        Tables_Console.Text = "Process will start soon... Total of tables to be converted =" & ListTablesToProcess.Count & vbNewLine
        Dim Index As Integer = 0
        For Each T As Table In ListTablesToProcess
            Dim C As VbNET.Class = VbNET.Convert_Table(T)
            If Not IsNothing(Class_Parent.SelectedItem) Then
                If Not IsNothing(Class_Parent.SelectedItem.Tag) Then

                    If TypeOf Class_Parent.SelectedItem.Tag Is VbNET.Class Then
                        C.ParentClass = IIf(IsNothing(Class_Parent.SelectedItem.Tag), VirtualClass, Class_Parent.SelectedItem.Tag)
                    Else
                        C.ParentClass = VirtualClass
                    End If
                End If
            Else
                C.ParentClass = VirtualClass
            End If

            C.PrintStatement(True)
            C.ParentClass.Add_Class(C)
            ListParent.Add(C)

            Tables_Console.Text += "Creating table " & Index + 1 & "| TableName [" & T.TableName & "]" & vbNewLine
            Tables_Console.ScrollToCaret()

            SchemaTree_Btn_Refresh.RaiseClick()
            Index += 1
        Next
        Dim Initializor As New VbNET.Class
        Initializor = VbNET.Prepare_Initializor(U_DataBase1.ActiveDatabase)
        If Not IsNothing(Class_Parent.SelectedItem) Then
            If Not IsNothing(Class_Parent.SelectedItem.Tag) Then

                If TypeOf Class_Parent.SelectedItem.Tag Is VbNET.Class Then
                    Initializor.ParentClass = IIf(IsNothing(Class_Parent.SelectedItem.Tag), VirtualClass, Class_Parent.SelectedItem.Tag)
                Else
                    Initializor.ParentClass = VirtualClass
                End If
            End If
        Else
            Initializor.ParentClass = VirtualClass
        End If
        Initializor.PrintStatement(True)
        Initializor.ParentClass.Add_Class(Initializor)
        ListParent.Add(Initializor)
    End Sub

    Private Sub SchemaTree_Btn_Refresh_Click(sender As Object, e As EventArgs) Handles SchemaTree_Btn_Refresh.Click
        If Not IsNothing(Class_Parent.SelectedItem) Then
            If Not IsNothing(Class_Parent.SelectedItem.Tag) Then
                Dim D = Class_Parent.SelectedItem.Tag
                If TypeOf D Is VbNET.Class Then
                    Temp_Class = D
                    Temp_Class.RefreshMainNode()
                    SchemaTree.Nodes.Clear()
                    SchemaTree.Nodes.Add(Temp_Class.MainNode.DeepCopy)
                    ' ElseIf TypeOf D Is VbNET.Module Then
                    '    Temp_Module = D
                    '   Temp_Module.RefreshMainNode()
                    '  SchemaTree.Nodes.Clear()
                    ' SchemaTree.Nodes.Add(Temp_Module.MainNode.DeepCopy)
                End If

            End If
        End If

        ' Temp_Class.RefreshMainNode()
        ' SchemaTree.Nodes.Clear()
        ' SchemaTree.Nodes.Add(Temp_Class.MainNode.DeepCopy)
    End Sub

#Region "|VirtualClass|"
#Region "<File Management>"

    Private Sub VirtualClass_Btn_New_Click(sender As Object, e As EventArgs) Handles Class_Btn_New.Click
        Dim NewName As String = InputBox("Enter the name of this class", "Input Name required.", "VirtualClass")
        Temp_Class = New VbNET.Class(NewName)
        VirtualClass_AccessModifier.Text = "Public"
        Class_CategoryID.Value = 0
        VirtualClass_Description.Text = ""
        VirtualClass_DirectoryPath.Text = My.Application.Info.DirectoryPath & "\" & Temp_Class.Name
        If Not IO.Directory.Exists(My.Application.Info.DirectoryPath & "\" & Temp_Class.Name) Then
            IO.Directory.CreateDirectory(My.Application.Info.DirectoryPath & "\" & Temp_Class.Name)
        End If
        My.Settings.DefaultOuput = My.Application.Info.DirectoryPath & "\" & Temp_Class.Name
        My.Settings.Save()
        ' U_ListView1.Folder_Target.Text = My.Application.Info.DirectoryPath & "\" & VirtualClass.Name
        Class_Enable.Value = True
        VirtualClass_F_FilePath.Text = My.Application.Info.DirectoryPath & "\" & Temp_Class.Name & "\" & VirtualClass.Name & ".F"
        VirtualClass.FileF = New Fichier(VirtualClass_F_FilePath.Text)
        VirtualClass_F_Status.Text = IIf(Temp_Class.FileF.Exists, "Exist", "Ready")

        VirtualClass_C_FilePath.Text = My.Application.Info.DirectoryPath & "\" & Temp_Class.Name & "\" & VirtualClass.Name & ".C"
        VirtualClass.FileC = New Fichier(VirtualClass_C_FilePath.Text)
        VirtualClass_C_Status.Text = IIf(Temp_Class.FileC.Exists, "Exist", "Ready")

        VirtualClass_F_Process.Value = 0
        VirtualClass_F_Status.Text = ""

        Class_ID.Value = 0
        VirtualClass_JS_FilePath.Text = My.Application.Info.DirectoryPath & "\" & Temp_Class.Name & "\" & VirtualClass.Name & ".Js"
        VirtualClass_JS_Process.Value = 0
        VirtualClass_MustInherite.Value = False
        Class_Name.Text = NewName
        VirtualClass_NotInheritable.Value = False
        VirtualClass_Python_FilePath.Text = My.Application.Info.DirectoryPath & "\" & Temp_Class.Name & "\" & VirtualClass.Name & ".Py"
        VirtualClass_Python_Process.Value = 0
        VirtualClass.FilePython = New Fichier(VirtualClass_Python_FilePath.Text)
        VirtualClass_Python_Status.Text = IIf(Temp_Class.FilePython.Exists, "Exist", "Ready")

        VirtualClass_Shadows.Value = False
        VirtualClass_Summary_AuthorEmail.Text = My.Settings.AuthorEmail
        VirtualClass_Summary_AuthorName.Text = My.Settings.AuthorName
        VirtualClass_Summary_AuthorUrl.Text = My.Settings.AuthorUrl
        VirtualClass_Summary_ContributorEmail.Text = ""
        VirtualClass_Summary_ContributorName.Text = ""
        VirtualClass_Summary_ContributorUrl.Text = ""
        VirtualClass_Summary_Example.Text = ""
        VirtualClass_Summary_Note.Text = ""
        VirtualClass_Summary_Remark.Text = ""
        VirtualClass_Summary_Rights.Text = My.Settings.SummaryRights
        VirtualClass_Summary_Rules.Text = ""
        VirtualClass_Summary_Syntax.Text = ""
        VirtualClass_Summary_Usage.Text = ""
        VirtualClass_VB_FilePath.Text = My.Application.Info.DirectoryPath & "\" & Temp_Class.Name & "\" & VirtualClass.Name & ".Vb"
        VirtualClass.FileVB = New Fichier(VirtualClass_VB_FilePath.Text)
        VirtualClass_VB_Status.Text = IIf(Temp_Class.FileVB.Exists, "Exist", "Ready")

        VirtualClass_Vb_Process.Value = 0
        VirtualClass_VB_Status.Text = ""
        SchemaTree_Btn_Refresh.RaiseClick()
        AdvPropertyGrid1.SelectedObject = Temp_Class
        ListParent.Add(Temp_Class)
        RefreshParents(Class_Parent, True, True)
        '  RefreshParents(Me.Panel_Property.Controls(0).)
        '  RefreshParents(Me.U_Enumeration.Enumeration_Parent)
        '  RefreshParents(Me.U_Structure.Structure_Parent)
        '  RefreshParents(Me.U_Sub.Sub_Parent)
        '  RefreshParents(Me.U_Function.Function_Parent)
        '  RefreshParents(Me.U_Runtime.Runtime_Parent)
        '  RefreshParents(Me.U_Loader.Loader_Parent)
        '  RefreshParents(Me.U_Class.Class_Parent)
        '  RefreshParents(Me.U_Module.VirtualClass_Parent)

    End Sub

    Private Sub VirtualClass_Btn_Open_Click(sender As Object, e As EventArgs) Handles Class_Btn_Open.Click
        Dim Ofd As New OpenFileDialog
        With Ofd
            .Filter = "VbNet Class Statement (*.Vb)|*.Vb|All Files (*.*)|*.*"
            If .ShowDialog = DialogResult.OK Then
                Try
                    VirtualClass.Open(.FileName)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End With
        AdvPropertyGrid1.RefreshPropertyValues()
    End Sub

    Private Sub VirtualClass_Btn_Save_Click(sender As Object, e As EventArgs) Handles Class_Btn_Save.Click
        If Not IsNothing(Temp_Class) Then
            Try
                Temp_Class.Save()
                MsgBox("Element saved.")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        AdvPropertyGrid1.RefreshPropertyValues()

    End Sub

    Private Sub VirtualClass_Btn_Preview_Click(sender As Object, e As EventArgs) Handles Class_Btn_Preview.Click
        Temp_Class.PrintStatement(VirtualClass_Vb,
                                    VirtualClass_C,
                                    VirtualClass_F,
                                    VirtualClass_Python,
                                    VirtualClass_JS,
                                  Class_Enable.Value)

        SchemaTree_Btn_Refresh.RaiseClick()
        SchemaTree.ExpandAll()
        AdvPropertyGrid1.RefreshPropertyValues()

    End Sub

    Private Sub VirtualClass_Btn_Construct_Click(sender As Object, e As EventArgs) Handles Class_Btn_Add.Click
        Try
            Temp_Class.Save()
            Jarvis.Speak("Class Constructed.")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        AdvPropertyGrid1.RefreshPropertyValues()
        If Temp_Class.FileC.Exists Then
            VirtualClass_C_Status.Text = "Exist"
        Else
            VirtualClass_C_Status.Text = "Broken"
        End If
        If Temp_Class.FilePython.Exists Then
            VirtualClass_Python_Status.Text = "Exist"
        Else
            VirtualClass_Python_Status.Text = "Broken"
        End If
        If Temp_Class.FileJavaScript.Exists Then
            VirtualClass_JS_Status.Text = "Exist"
        Else
            VirtualClass_JS_Status.Text = "Broken"
        End If
        If Temp_Class.FileF.Exists Then
            VirtualClass_F_Status.Text = "Exist"
        Else
            VirtualClass_F_Status.Text = "Broken"
        End If
        If Temp_Class.FileVB.Exists Then
            VirtualClass_VB_Status.Text = "Exist"
        Else
            VirtualClass_VB_Status.Text = "Broken"
        End If
    End Sub
#End Region
#Region "<Constructor>"
    Private Sub VirtualClass_Enable_ValueChanged(sender As Object, e As EventArgs) Handles Class_Enable.ValueChanged
        Temp_Class.Enable = Class_Enable.Value
        AdvPropertyGrid1.RefreshPropertyValues()

    End Sub

    Private Sub VirtualClass_ID_ValueChanged(sender As Object, e As EventArgs) Handles Class_ID.ValueChanged
        Temp_Class.ID = Class_ID.Value
        AdvPropertyGrid1.RefreshPropertyValues()
    End Sub

    Private Sub VirtualClass_Name_TextChanged(sender As Object, e As EventArgs) Handles Class_Name.TextChanged
        If Class_Name.Text <> "" Then
            Temp_Class.Name = Class_Name.Text
            Temp_Class.ClassName = Class_Name.Text
            Temp_Class.MainNode.Text = Class_Name.Text
        End If
        AdvPropertyGrid1.RefreshPropertyValues()
    End Sub

    Private Sub VirtualClass_DirectoryPath_TextChanged(sender As Object, e As EventArgs) Handles VirtualClass_DirectoryPath.TextChanged
        If IO.Directory.Exists(VirtualClass_DirectoryPath.Text) Then
            'VirtualClass.p
        End If
    End Sub

    Private Sub VirtualClass_DirectoryPath_DoubleClick(sender As Object, e As EventArgs) Handles VirtualClass_DirectoryPath.DoubleClick

    End Sub

    Private Sub VirtualClass_Shadows_ValueChanged(sender As Object, e As EventArgs) Handles VirtualClass_Shadows.ValueChanged

    End Sub

    Private Sub VirtualClass_MustInherite_ValueChanged(sender As Object, e As EventArgs) Handles VirtualClass_MustInherite.ValueChanged

    End Sub

    Private Sub VirtualClass_NotInheritable_ValueChanged(sender As Object, e As EventArgs) Handles VirtualClass_NotInheritable.ValueChanged

    End Sub

    Private Sub VirtualClass_VB_FilePath_DoubleClick(sender As Object, e As EventArgs) Handles VirtualClass_VB_FilePath.DoubleClick

    End Sub

    Private Sub VirtualClass_C_FilePath_DoubleClick(sender As Object, e As EventArgs) Handles VirtualClass_C_FilePath.DoubleClick

    End Sub

    Private Sub VirtualClass_F_FilePath_TextChanged(sender As Object, e As EventArgs) Handles VirtualClass_F_FilePath.TextChanged

    End Sub

    Private Sub VirtualClass_Python_FilePath_DoubleClick(sender As Object, e As EventArgs) Handles VirtualClass_Python_FilePath.DoubleClick

    End Sub

    Private Sub VirtualClass_F_FilePath_DoubleClick(sender As Object, e As EventArgs) Handles VirtualClass_F_FilePath.DoubleClick

    End Sub

    Private Sub VirtualClass_JS_FilePath_DoubleClick(sender As Object, e As EventArgs) Handles VirtualClass_JS_FilePath.DoubleClick

    End Sub

    Private Sub VirtualClass_Description_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles VirtualClass_Description.TextChanged

    End Sub
#End Region

#End Region

    Private Sub SchemaTree_Edit_Click(sender As Object, e As EventArgs) Handles SchemaTree_Edit.Click
        If Not IsNothing(SchemaTree.SelectedNode) Then
            If Not IsNothing(SchemaTree.SelectedNode.Tag) Then
                Dim TempStatement = SchemaTree.SelectedNode.Tag
                If TypeOf TempStatement Is VbNET.Class Then
                    VirtualClass = TempStatement
                ElseIf TypeOf TempStatement Is VbNET.Property Then
                    U_Property.OpenStatement(TempStatement)
                ElseIf TypeOf TempStatement Is VbNET.Enumeration Then
                    U_Enumeration.OpenStatement(TempStatement)
                ElseIf TypeOf TempStatement Is VbNET.Structure Then
                    U_Structure.Openstatement(TempStatement)
                ElseIf TypeOf TempStatement Is VbNET.Sub Then
                    U_Sub.OpenStatement(TempStatement)
                ElseIf TypeOf TempStatement Is VbNET.Function Then
                    U_Function.OpenStatement(TempStatement)
                ElseIf TypeOf TempStatement Is VbNET.Runtime Then
                    U_Runtime.OpenStatement(TempStatement)
                ElseIf TypeOf TempStatement Is VbNET.Loader Then
                    U_Loader.OpenStatement(TempStatement)
                End If
            End If
        End If
        AdvPropertyGrid1.RefreshPropertyValues()
    End Sub

    Private Sub VbNET_Class_GiveFeedback(sender As Object, e As GiveFeedbackEventArgs) Handles Me.GiveFeedback

    End Sub

    Private Sub VbNET_Class_Load(sender As Object, e As EventArgs) Handles Me.Load
        ContextMenuBar1.SetContextMenuEx(SchemaTree, Btn_Menu_Schema)

        U_Class = New VbNET_Class
        U_Class.Dock = DockStyle.Fill
        Panel_Class.Controls.Add(U_Class)
        U_Class.ActiveParent = Temp_Class
        U_Class.Class_Parent.Text = Temp_Class.Name

        U_Enumeration = New VbNET_Enumeration
        U_Enumeration.Dock = DockStyle.Fill
        Panel_Enumeration.Controls.Add(U_Enumeration)
        U_Enumeration.ActiveParent = Temp_Class
        U_Enumeration.Enumeration_Parent.Text = Temp_Class.Name

        U_Function = New VbNET_Function
        U_Function.Dock = DockStyle.Fill
        Panel_Function.Controls.Add(U_Function)
        U_Function.ActiveParent = Temp_Class
        U_Function.Function_Parent.Text = Temp_Class.Name

        U_Sub = New VbNET_Sub
        U_Sub.Dock = DockStyle.Fill
        Panel_Sub.Controls.Add(U_Sub)
        U_Sub.ActiveParent = Temp_Class
        U_Sub.Sub_Parent.Text = Temp_Class.Name

        U_Loader = New VbNET_Loader
        U_Loader.Dock = DockStyle.Fill
        Panel_Loader.Controls.Add(U_Loader)
        U_Loader.ActiveParent = Temp_Class
        U_Loader.Loader_Parent.Text = Temp_Class.Name

        U_Module = New VbNET_Module
        U_Module.Dock = DockStyle.Fill
        Panel_Module.Controls.Add(U_Module)
        U_Module.ActiveParent = Temp_Class
        U_Module.VirtualClass_Parent.Text = Temp_Class.Name

        U_Property = New VbNET_Property
        U_Property.Dock = DockStyle.Fill
        Panel_Property.Controls.Add(U_Property)
        U_Property.ActiveParent = Temp_Class
        U_Property.Property_Parent.Text = Temp_Class.Name

        U_Runtime = New VbNET_Runtime
        U_Runtime.Dock = DockStyle.Fill
        Panel_Runtime.Controls.Add(U_Runtime)
        U_Runtime.ActiveParent = Temp_Class
        U_Runtime.Runtime_Parent.Text = Temp_Class.Name

        U_Structure = New VbNET_Structure
        U_Structure.Dock = DockStyle.Fill
        Panel_Structure.Controls.Add(U_Structure)
        U_Structure.ActiveParent = Temp_Class
        U_Structure.Structure_Parent.Text = Temp_Class.ClassName

        U_Sub = New VbNET_Sub
        U_Sub.Dock = DockStyle.Fill
        Panel_Sub.Controls.Add(U_Sub)
        U_Sub.ActiveParent = Temp_Class
        U_Sub.Sub_Parent.Text = Temp_Class.ClassName
        RefreshParents(Class_Parent, False, True)
        AdvPropertyGrid1.SelectedObject = Temp_Class

    End Sub

    Private Sub Class_Parent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Class_Parent.SelectedIndexChanged
        If Not IsNothing(Class_Parent.SelectedItem) Then
            If Not IsNothing(Class_Parent.SelectedItem.Tag) Then
                Dim Element = Class_Parent.SelectedItem.Tag
                '   If TypeOf Element Is VbNET.Class Then
                ' RefreshParents(Me.U_Property.Property_Parent)
                ' RefreshParents(Me.U_Enumeration.Enumeration_Parent)
                ' RefreshParents(Me.U_Structure.Structure_Parent)
                ' RefreshParents(Me.U_Sub.Sub_Parent)
                ' RefreshParents(Me.U_Function.Function_Parent)
                ' RefreshParents(Me.U_Runtime.Runtime_Parent)
                ' RefreshParents(Me.U_Loader.Loader_Parent)
                ' RefreshParents(Me.U_Class.Class_Parent)
                ' RefreshParents(Me.U_Module.VirtualClass_Parent)
                '
                '               Me.U_Property.Property_Parent.Text = Element.Name
                '                Me.U_Property.ActiveParent = Element
                '                 Me.U_Property.Temp_Property.ParentClass = Element
                '                  Me.U_Property.Temp_Property.ParentName = Element.name

                '                    Me.U_Enumeration.Enumeration_Parent.Text = Element.Name
                '                   Me.U_Enumeration.ActiveParent = Element
                '                    Me.U_Enumeration.Temp_Enumeration.ParentClass = Element
                '                    Me.U_Enumeration.Temp_Enumeration.ParentName = Element.name

                '                    Me.U_Structure.Structure_Parent.Text = Element.Name
                '                    Me.U_Structure.ActiveParent = Element
                Temp_Structure.ParentClass = Element
                    Temp_Structure.ParentName = Element.name

                '                    Me.U_Sub.Sub_Parent.Text = Element.Name
                '                    Me.U_Sub.ActiveParent = Element
                '                    Me.U_Sub.Temp_Sub.ParentClass = Element
                '                    Me.U_Sub.Temp_Sub.ParentName = Element.name

                'Me.U_Function.Function_Parent.Text = Element.Name
                'Me.U_Function.ActiveParent = Element
                'Me.U_Function.Temp_Function.ParentClass = Element
                'Me.U_Function.Temp_Function.ParentName = Element.name

                '                    Me.U_Runtime.Runtime_Parent.Text = Element.Name
                'Me.U_Runtime.ActiveParent = Element
                'Me.U_Runtime.Temp_Runtime.ParentClass = Element
                'Me.U_Runtime.Temp_Runtime.ParentName = Element.name

                '                    Me.U_Loader.Loader_Parent.Text = Element.Name
                '                    Me.U_Loader.ActiveParent = Element
                '                    Me.U_Loader.Temp_Loader.ParentClass = Element
                '                    Me.U_Loader.Temp_Loader.ParentName = Element.name

                '                   Me.U_Class.Class_Parent.Text = Element.Name
                '                    Me.U_Class.ActiveParent = Element
                '                    Me.U_Class.Temp_Class.ParentClass = Element
                '                    Me.U_Class.Temp_Class.ParentName = Element.name

                '  Me.U_Module.VirtualClass_Parent.Text = Element.Name
                '  Me.U_Module.ActiveParent = Element
                '   Temp_Module.ParentClass = Element
                '  Temp_Module.ParentName = Element.name
                ' End If
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        '  SchemaTree_Btn_Refresh.RaiseClick()
        ' SchemaTree.ExpandAll()
        VirtualClass_Statements.PrimaryGrid.DataSource = Temp_Class.Items
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        RefreshParents(Class_Parent, False, True)

    End Sub
End Class
