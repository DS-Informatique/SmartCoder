Public Class Form1
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim Vb As New SmartCoder.U_VbNET
        Vb.Dock = DockStyle.Fill
        Me.Controls.Add(Vb)

    End Sub
End Class
