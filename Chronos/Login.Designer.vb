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
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.ProgressBarX1 = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.Btn_Open = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.U_DataBase1 = New SmartCoder.U_DataBase()
        Me.BW = New System.ComponentModel.BackgroundWorker()
        Me.Memorized = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.ButtonX1)
        Me.PanelEx1.Controls.Add(Me.Memorized)
        Me.PanelEx1.Controls.Add(Me.ProgressBarX1)
        Me.PanelEx1.Controls.Add(Me.Btn_Open)
        Me.PanelEx1.Controls.Add(Me.LabelX2)
        Me.PanelEx1.Controls.Add(Me.U_DataBase1)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(514, 283)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        Me.PanelEx1.Text = " "
        '
        'ProgressBarX1
        '
        '
        '
        '
        Me.ProgressBarX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ProgressBarX1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBarX1.Location = New System.Drawing.Point(0, 260)
        Me.ProgressBarX1.Name = "ProgressBarX1"
        Me.ProgressBarX1.Size = New System.Drawing.Size(514, 23)
        Me.ProgressBarX1.TabIndex = 5
        Me.ProgressBarX1.Text = "ProgressBarX1"
        '
        'Btn_Open
        '
        Me.Btn_Open.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_Open.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Btn_Open.Location = New System.Drawing.Point(364, 214)
        Me.Btn_Open.Name = "Btn_Open"
        Me.Btn_Open.Size = New System.Drawing.Size(130, 44)
        Me.Btn_Open.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_Open.TabIndex = 4
        Me.Btn_Open.Text = "Ouvrir"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(27, 12)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(554, 23)
        Me.LabelX2.TabIndex = 3
        Me.LabelX2.Text = "Chargement de la Base de Donnée"
        '
        'U_DataBase1
        '
        Me.U_DataBase1.ActiveDatabase = Nothing
        Me.U_DataBase1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.U_DataBase1.Location = New System.Drawing.Point(27, 42)
        Me.U_DataBase1.Margin = New System.Windows.Forms.Padding(4)
        Me.U_DataBase1.Name = "U_DataBase1"
        Me.U_DataBase1.PasswordInput = Nothing
        Me.U_DataBase1.Size = New System.Drawing.Size(468, 155)
        Me.U_DataBase1.TabIndex = 2
        Me.U_DataBase1.Target = Nothing
        '
        'BW
        '
        Me.BW.WorkerReportsProgress = True
        Me.BW.WorkerSupportsCancellation = True
        '
        'Memorized
        '
        '
        '
        '
        Me.Memorized.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Memorized.Checked = True
        Me.Memorized.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Memorized.CheckValue = "Y"
        Me.Memorized.Location = New System.Drawing.Point(3, 231)
        Me.Memorized.Name = "Memorized"
        Me.Memorized.Size = New System.Drawing.Size(256, 23)
        Me.Memorized.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Memorized.TabIndex = 6
        Me.Memorized.Text = "Mémoriser cette base de donnée"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.ButtonX1.Location = New System.Drawing.Point(27, 204)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(75, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 7
        Me.ButtonX1.Text = "Reset"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 283)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.PanelEx1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents U_DataBase1 As SmartCoder.U_DataBase
    Friend WithEvents Btn_Open As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ProgressBarX1 As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents BW As System.ComponentModel.BackgroundWorker
    Friend WithEvents Memorized As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
End Class
