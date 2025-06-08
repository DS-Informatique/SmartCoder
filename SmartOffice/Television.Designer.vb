<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Television
    Inherits DevComponents.DotNetBar.Office2007Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Tv1 = New SmartCoder.TV()
        Me.SuspendLayout
        '
        'Tv1
        '
        Me.Tv1.Active_Channel = Nothing
        Me.Tv1.Channel = SmartCoder.M_Web.MyVideoList.Empty
        Me.Tv1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tv1.Location = New System.Drawing.Point(0, 0)
        Me.Tv1.Name = "Tv1"
        Me.Tv1.Size = New System.Drawing.Size(800, 450)
        Me.Tv1.TabIndex = 0
        '
        'Television
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Tv1)
        Me.DoubleBuffered = True
        Me.Name = "Television"
        Me.Text = "Television"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tv1 As SmartCoder.TV
End Class
