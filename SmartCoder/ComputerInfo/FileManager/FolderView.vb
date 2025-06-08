Imports System.IO
Imports System.Windows.Forms
Public Class FolderView

    Private _Current As Folder
    Public Property Current() As Folder
        Get
            Return _Current
        End Get
        Set(ByVal value As Folder)
            _Current = value
            If Not IsNothing(value) Then
                Input_Dir.Text = value.Target
                If value.Exists = True Then
                    Me.ButtonX1.Image = My.Resources.Check_24x24
                Else
                    Me.ButtonX1.Image = My.Resources.Delete_24x24
                End If
            End If
        End Set
    End Property
    Private Sub Btn_Define_Répertoire_Click(sender As Object, e As EventArgs) Handles Btn_Define_Répertoire.Click
        Dim FDB As New FolderBrowserDialog
        If FDB.ShowDialog = DialogResult.OK Then
            Current = New Folder(FDB.SelectedPath)
        End If
    End Sub

    Public Property SearchOption As IO.SearchOption
    Public Property List As New List(Of Object)
    Private Sub BW_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW.DoWork
        BW.WorkerSupportsCancellation = True
        Pbar.Value = 0

        If Not IsNothing(Current) Then

            If Input_Search.Text.Length < 1 Then
                Input_Search.Text = "*.*"
            End If
            If Include_Dir.Value = True Then
                Dim Lt As New List(Of Folder)
                Lt = Current.EnumerateFolder(Input_Search.Text, SearchOption)
                Pbar.Maximum = Lt.Count
                For i = 0 To Lt.Count - 1
                    Dim A As Folder = Lt(i)
                    If IO.Directory.Exists(A.Target) Then
                        Try
                            A.Icon = Retrieve_Icons.GetShellIcon(A.Target)
                        Catch ex As Exception

                        End Try
                        List.Add(A)
                    End If
                    Pbar.Value += 1
                    If BW.CancellationPending Then
                        e.Cancel = True
                        Pbar.Value = 0
                        Exit For
                    End If
                    L_Percentage.Text = "( " & Math.Round((Pbar.Value / Pbar.Maximum) * 100, 2) & " %)"
                Next


            End If
            Dim LtF As New List(Of Fichier)
            LtF = Current.EnumerateFichier(Input_Search.Text, SearchOption)
            Pbar.Value = 0
            Pbar.Maximum = LtF.Count
            For i = 0 To LtF.Count - 1
                Dim A As Fichier = LtF(i)
                If IO.File.Exists(A.Target) Then
                    Try
                        A.Icon = Retrieve_Icons.GetShellIcon(A.Target)
                    Catch ex As Exception

                    End Try
                    List.Add(A)
                End If
                Pbar.Value += 1
                If BW.CancellationPending Then
                    e.Cancel = True
                    Pbar.Value = 0
                    Exit For
                End If
                L_Percentage.Text = "( " & Math.Round((Pbar.Value / Pbar.Maximum) * 100, 2) & " %)"

            Next

        End If

    End Sub

    Private Sub Btn_Index_Click(sender As Object, e As EventArgs) Handles Btn_Index.Click
        SearchOption = SearchOption.TopDirectoryOnly
        If BW.IsBusy = True Then
            BW.CancelAsync()
        Else
            BW.RunWorkerAsync()
        End If
    End Sub
    Private Class ElementFile
        Public Property Icon As System.Drawing.Image
        Public Property FilePath As String
        Public Property IsFile As Boolean
        Public Property Size As Double
        Public Sub Clear()
            Icon = Nothing
            FilePath = ""
            IsFile = False
            Size = 0
        End Sub
        Public Sub New(ByVal File As Fichier)
            With Me
                .Icon = Retrieve_Icons.GetShellIcon(File.Target)
                .FilePath = File.Target
                .IsFile = True
                .Size = File.FileSize.Value
            End With
        End Sub
        Public Sub New(ByVal Dir As Folder)
            With Me
                .Icon = Retrieve_Icons.GetShellIcon(Dir.Target)
                .FilePath = Dir.Target
                .IsFile = True
                .Size = CalculateDirSize(New DirectoryInfo(Dir.Target), SizeInfo.Scales.Gigabyte).Value
            End With
        End Sub
        Public Overrides Function ToString() As String
            Return FilePath
        End Function
    End Class
    Private Sub Btn_Search_All_Click(sender As Object, e As EventArgs) Handles Btn_Search_All.Click
        SearchOption = SearchOption.AllDirectories
        If BW.IsBusy = True Then
            BW.CancelAsync()
        Else
            BW.RunWorkerAsync()
        End If
    End Sub

    Private Sub FolderView_Load(sender As Object, e As EventArgs) Handles Me.Load
        SuperTabControl1.SelectedTab = SuperTabItem1
    End Sub
End Class
