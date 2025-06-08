<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Me.TransfertUnit1 = New Archivis.TransfertUnit()
        Me.SuspendLayout()
        '
        'TransfertUnit1
        '
        Me.TransfertUnit1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TransfertUnit1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransfertUnit1.Location = New System.Drawing.Point(0, 0)
        Me.TransfertUnit1.Margin = New System.Windows.Forms.Padding(4)
        Me.TransfertUnit1.Name = "TransfertUnit1"
        Me.TransfertUnit1.Size = New System.Drawing.Size(928, 603)
        Me.TransfertUnit1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 603)
        Me.Controls.Add(Me.TransfertUnit1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TransfertUnit1 As TransfertUnit
End Class
