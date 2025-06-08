Public Class Manager
    Private Sub Manager_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Dim M As New ManageBackup
            M.Dock = DockStyle.Fill
            PanelEx1.Controls.Add(M)
        Catch ex As Exception

        End Try

    End Sub
End Class