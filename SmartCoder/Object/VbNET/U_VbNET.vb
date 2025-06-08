Imports System.IO
Imports System.Windows.Forms

Public Class U_VbNET
    Public Temp_Project As VbNET.Project
    Private Sub ButtonItem2_Click(sender As Object, e As EventArgs) Handles ButtonItem2.Click
        Dim Ofd As New OpenFileDialog
        If Ofd.ShowDialog = DialogResult.OK Then
            Temp_Project = New VbNET.Project(New Fichier(Ofd.FileName))
            Project_Tree.Nodes.Add(Temp_Project.MainNode)
        End If
    End Sub

    Private Sub U_VbNET_Load(sender As Object, e As EventArgs) Handles Me.Load
        Temp_Project = New VbNET.Project
        AdvPropertyGrid1.SelectedObject = Temp_Project

        'Temp_Project.Index()

    End Sub
End Class
