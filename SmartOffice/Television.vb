Public Class Television
    Private Sub Television_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim F As New DevComponents.DotNetBar.Office2007Form
        Dim M As New SmartCoder.YoutubePlayer
        M.Dock = DockStyle.Fill
        F.Controls.Add(M)
        F.Show()
    End Sub
End Class