Public Class DashBoard
    Private Sub DashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim C As New Clients
        C.Dock = DockStyle.Fill
        Panel_Clients.Controls.Add(C)
    End Sub

    Private Sub ButtonItem1_Click(sender As Object, e As EventArgs) Handles ButtonItem1.Click
        Dim B As New DataBase
        B.Show()
    End Sub
End Class