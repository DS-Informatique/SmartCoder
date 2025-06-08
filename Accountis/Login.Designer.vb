<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.ComboBoxEx1 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.TextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.SuspendLayout()
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(59, 30)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(121, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "UserName"
        '
        'ComboBoxEx1
        '
        Me.ComboBoxEx1.DisplayMember = "Text"
        Me.ComboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxEx1.FormattingEnabled = True
        Me.ComboBoxEx1.ItemHeight = 18
        Me.ComboBoxEx1.Location = New System.Drawing.Point(59, 59)
        Me.ComboBoxEx1.Name = "ComboBoxEx1"
        Me.ComboBoxEx1.Size = New System.Drawing.Size(208, 24)
        Me.ComboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ComboBoxEx1.TabIndex = 1
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(59, 100)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(121, 23)
        Me.LabelX2.TabIndex = 2
        Me.LabelX2.Text = "Password"
        '
        'TextBoxX1
        '
        '
        '
        '
        Me.TextBoxX1.Border.Class = "TextBoxBorder"
        Me.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX1.Location = New System.Drawing.Point(59, 129)
        Me.TextBoxX1.Name = "TextBoxX1"
        Me.TextBoxX1.PreventEnterBeep = True
        Me.TextBoxX1.Size = New System.Drawing.Size(208, 24)
        Me.TextBoxX1.TabIndex = 3
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(283, 128)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(163, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 4
        Me.ButtonX1.Text = "Charger Comptabilité"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 279)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.TextBoxX1)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.ComboBoxEx1)
        Me.Controls.Add(Me.LabelX1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ComboBoxEx1 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
End Class
