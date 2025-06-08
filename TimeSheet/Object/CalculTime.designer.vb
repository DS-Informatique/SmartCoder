<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalculTime
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
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.D0_H = New DevComponents.Editors.IntegerInput()
        Me.D0_M = New DevComponents.Editors.IntegerInput()
        Me.D1_H = New DevComponents.Editors.IntegerInput()
        Me.D1_M = New DevComponents.Editors.IntegerInput()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.DF_M = New DevComponents.Editors.IntegerInput()
        Me.DF_H = New DevComponents.Editors.IntegerInput()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.Total100 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx1.SuspendLayout()
        CType(Me.D0_H, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.D0_M, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.D1_H, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.D1_M, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DF_M, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DF_H, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(43, 56)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(69, 22)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Début"
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.ButtonX1)
        Me.PanelEx1.Controls.Add(Me.Total100)
        Me.PanelEx1.Controls.Add(Me.LabelX8)
        Me.PanelEx1.Controls.Add(Me.DF_M)
        Me.PanelEx1.Controls.Add(Me.DF_H)
        Me.PanelEx1.Controls.Add(Me.LabelX7)
        Me.PanelEx1.Controls.Add(Me.D1_M)
        Me.PanelEx1.Controls.Add(Me.D1_H)
        Me.PanelEx1.Controls.Add(Me.D0_M)
        Me.PanelEx1.Controls.Add(Me.D0_H)
        Me.PanelEx1.Controls.Add(Me.LabelX5)
        Me.PanelEx1.Controls.Add(Me.LabelX6)
        Me.PanelEx1.Controls.Add(Me.LabelX4)
        Me.PanelEx1.Controls.Add(Me.LabelX3)
        Me.PanelEx1.Controls.Add(Me.LabelX2)
        Me.PanelEx1.Controls.Add(Me.LabelX1)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(320, 255)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 1
        Me.PanelEx1.Text = " "
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(43, 114)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(69, 22)
        Me.LabelX2.TabIndex = 1
        Me.LabelX2.Text = "Fin"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(118, 28)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(69, 22)
        Me.LabelX3.TabIndex = 2
        Me.LabelX3.Text = "Heure"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(205, 28)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(69, 22)
        Me.LabelX4.TabIndex = 3
        Me.LabelX4.Text = "Minutes"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(205, 87)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(69, 22)
        Me.LabelX5.TabIndex = 5
        Me.LabelX5.Text = "Minutes"
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(118, 87)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(69, 22)
        Me.LabelX6.TabIndex = 4
        Me.LabelX6.Text = "Heure"
        '
        'D0_H
        '
        '
        '
        '
        Me.D0_H.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.D0_H.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.D0_H.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.D0_H.Location = New System.Drawing.Point(118, 56)
        Me.D0_H.MaxValue = 23
        Me.D0_H.MinValue = 0
        Me.D0_H.Name = "D0_H"
        Me.D0_H.ShowUpDown = True
        Me.D0_H.Size = New System.Drawing.Size(69, 22)
        Me.D0_H.TabIndex = 11
        '
        'D0_M
        '
        '
        '
        '
        Me.D0_M.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.D0_M.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.D0_M.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.D0_M.Location = New System.Drawing.Point(205, 56)
        Me.D0_M.MaxValue = 59
        Me.D0_M.MinValue = 0
        Me.D0_M.Name = "D0_M"
        Me.D0_M.ShowUpDown = True
        Me.D0_M.Size = New System.Drawing.Size(80, 22)
        Me.D0_M.TabIndex = 14
        '
        'D1_H
        '
        '
        '
        '
        Me.D1_H.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.D1_H.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.D1_H.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.D1_H.Location = New System.Drawing.Point(118, 114)
        Me.D1_H.MaxValue = 23
        Me.D1_H.MinValue = 0
        Me.D1_H.Name = "D1_H"
        Me.D1_H.ShowUpDown = True
        Me.D1_H.Size = New System.Drawing.Size(69, 22)
        Me.D1_H.TabIndex = 15
        '
        'D1_M
        '
        '
        '
        '
        Me.D1_M.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.D1_M.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.D1_M.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.D1_M.Location = New System.Drawing.Point(205, 114)
        Me.D1_M.MaxValue = 59
        Me.D1_M.MinValue = 0
        Me.D1_M.Name = "D1_M"
        Me.D1_M.ShowUpDown = True
        Me.D1_M.Size = New System.Drawing.Size(80, 22)
        Me.D1_M.TabIndex = 16
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(43, 171)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(69, 22)
        Me.LabelX7.TabIndex = 17
        Me.LabelX7.Text = "Total"
        '
        'DF_M
        '
        '
        '
        '
        Me.DF_M.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DF_M.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DF_M.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.DF_M.Location = New System.Drawing.Point(205, 171)
        Me.DF_M.MaxValue = 59
        Me.DF_M.MinValue = 0
        Me.DF_M.Name = "DF_M"
        Me.DF_M.ShowUpDown = True
        Me.DF_M.Size = New System.Drawing.Size(80, 22)
        Me.DF_M.TabIndex = 19
        '
        'DF_H
        '
        '
        '
        '
        Me.DF_H.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DF_H.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DF_H.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.DF_H.Location = New System.Drawing.Point(118, 171)
        Me.DF_H.MaxValue = 23
        Me.DF_H.MinValue = 0
        Me.DF_H.Name = "DF_H"
        Me.DF_H.ShowUpDown = True
        Me.DF_H.Size = New System.Drawing.Size(69, 22)
        Me.DF_H.TabIndex = 18
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Location = New System.Drawing.Point(43, 211)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(144, 22)
        Me.LabelX8.TabIndex = 20
        Me.LabelX8.Text = "Total Base 100"
        '
        'Total100
        '
        Me.Total100.BackColor = System.Drawing.Color.DimGray
        '
        '
        '
        Me.Total100.Border.Class = "TextBoxBorder"
        Me.Total100.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Total100.ForeColor = System.Drawing.Color.White
        Me.Total100.Location = New System.Drawing.Point(205, 211)
        Me.Total100.Name = "Total100"
        Me.Total100.PreventEnterBeep = True
        Me.Total100.Size = New System.Drawing.Size(80, 22)
        Me.Total100.TabIndex = 21
        Me.Total100.Text = "0"
        Me.Total100.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(23, 15)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(75, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 22
        Me.ButtonX1.Text = "Effacer"
        '
        'CalculTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 255)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "CalculTime"
        Me.Text = "CalculTime"
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.D0_H, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.D0_M, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.D1_H, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.D1_M, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DF_M, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DF_H, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents D0_H As DevComponents.Editors.IntegerInput
    Friend WithEvents D0_M As DevComponents.Editors.IntegerInput
    Friend WithEvents D1_H As DevComponents.Editors.IntegerInput
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents D1_M As DevComponents.Editors.IntegerInput
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Total100 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DF_M As DevComponents.Editors.IntegerInput
    Friend WithEvents DF_H As DevComponents.Editors.IntegerInput
End Class
