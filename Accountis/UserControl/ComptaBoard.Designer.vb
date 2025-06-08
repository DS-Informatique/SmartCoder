<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComptaBoard
    Inherits DevComponents.DotNetBar.Office2007Form 'System.Windows.Forms.Form

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
        Dim Tbl_Plan_Comptable1 As Accountis.M_Accountis.Tbl_Plan_Comptable = New Accountis.M_Accountis.Tbl_Plan_Comptable()
        Me.Pl1 = New Accountis.PL()
        Me.SuspendLayout()
        '
        'Pl1
        '
        Tbl_Plan_Comptable1.Balance = 0R
        Tbl_Plan_Comptable1.Closing = 0
        Tbl_Plan_Comptable1.Credit = 0R
        Tbl_Plan_Comptable1.Currency = Nothing
        Tbl_Plan_Comptable1.Debit = 0R
        Tbl_Plan_Comptable1.English = Nothing
        Tbl_Plan_Comptable1.Français = Nothing
        Tbl_Plan_Comptable1.German = Nothing
        Tbl_Plan_Comptable1.Group_Negatif = 0
        Tbl_Plan_Comptable1.Group_Positif = 0
        Tbl_Plan_Comptable1.ID = 0
        Tbl_Plan_Comptable1.Italian = Nothing
        Tbl_Plan_Comptable1.N = 0
        Tbl_Plan_Comptable1.Opening = 0R
        Tbl_Plan_Comptable1.Portuguese = Nothing
        Tbl_Plan_Comptable1.Russian = Nothing
        Tbl_Plan_Comptable1.Spanish = Nothing
        Tbl_Plan_Comptable1.Variation = 0R
        Me.Pl1.Current = Tbl_Plan_Comptable1
        Me.Pl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pl1.Location = New System.Drawing.Point(0, 0)
        Me.Pl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Pl1.Name = "Pl1"
        Me.Pl1.Size = New System.Drawing.Size(1219, 564)
        Me.Pl1.TabIndex = 0
        '
        'ComptaBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1219, 564)
        Me.Controls.Add(Me.Pl1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ComptaBoard"
        Me.Text = "ComptaBoard"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pl1 As PL
End Class
