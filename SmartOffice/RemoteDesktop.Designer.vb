<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RemoteDesktop
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
        Me.RemoteDesktopConnection1 = New SmartCoder.RemoteDesktopConnection()
        Me.SuspendLayout()
        '
        'RemoteDesktopConnection1
        '
        Me.RemoteDesktopConnection1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RemoteDesktopConnection1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoteDesktopConnection1.Location = New System.Drawing.Point(0, 0)
        Me.RemoteDesktopConnection1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RemoteDesktopConnection1.Name = "RemoteDesktopConnection1"
        Me.RemoteDesktopConnection1.Password = Nothing
        Me.RemoteDesktopConnection1.Size = New System.Drawing.Size(618, 511)
        Me.RemoteDesktopConnection1.Station = Nothing
        Me.RemoteDesktopConnection1.TabIndex = 0
        Me.RemoteDesktopConnection1.UserName = Nothing
        '
        'RemoteDesktop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 511)
        Me.Controls.Add(Me.RemoteDesktopConnection1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "RemoteDesktop"
        Me.Text = "RemoteDesktop"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RemoteDesktopConnection1 As SmartCoder.RemoteDesktopConnection
End Class
