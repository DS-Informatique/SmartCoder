<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShowProperty
    Inherits DevComponents.DotNetBar.OfficeForm

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
        Me.AdvPropertyGrid1 = New DevComponents.DotNetBar.AdvPropertyGrid()
        CType(Me.AdvPropertyGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AdvPropertyGrid1
        '
        Me.AdvPropertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AdvPropertyGrid1.GridLinesColor = System.Drawing.Color.WhiteSmoke
        Me.AdvPropertyGrid1.Location = New System.Drawing.Point(0, 0)
        Me.AdvPropertyGrid1.Name = "AdvPropertyGrid1"
        Me.AdvPropertyGrid1.Size = New System.Drawing.Size(516, 403)
        Me.AdvPropertyGrid1.TabIndex = 1
        Me.AdvPropertyGrid1.Text = "AdvPropertyGrid1"
        '
        'ShowProperty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 403)
        Me.Controls.Add(Me.AdvPropertyGrid1)
        Me.DoubleBuffered = True
        Me.Name = "ShowProperty"
        Me.Text = "ShowProperty"
        CType(Me.AdvPropertyGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents AdvPropertyGrid1 As DevComponents.DotNetBar.AdvPropertyGrid
End Class
