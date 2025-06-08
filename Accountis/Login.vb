Public Class Login








    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        Start()

        ComboBoxEx1.DataSource = Active_User.List
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        If My.Settings.Db_Accountis_FilePath.Length < 1 Then
            My.Settings.Db_Accountis_FilePath = "C:\Users\Saadry\Documents\Laboratoire\Accountis.accdb"
            My.Settings.Save()

        End If
        Dim C As New Comptabilité
        C.FilePath = My.Settings.Db_Accountis_FilePath
        C.Reset()
        Dim F As New DevComponents.DotNetBar.Office2007Form
        Dim A As New DevComponents.DotNetBar.AdvPropertyGrid
        A.Dock = DockStyle.Fill
        F.Controls.Add(A)
        F.Show()
        A.SelectedObject = C
    End Sub
End Class