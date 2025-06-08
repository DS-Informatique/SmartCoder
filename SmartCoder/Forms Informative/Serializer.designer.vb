<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Serializer
    Inherits DevComponents.DotNetBar.OfficeForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Serializer))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.AdvProperty = New DevComponents.DotNetBar.AdvPropertyGrid()
        Me.TextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.Statement = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.PanelEx1.SuspendLayout()
        CType(Me.AdvProperty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx2.SuspendLayout()
        CType(Me.Statement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.ButtonX1)
        Me.PanelEx1.Controls.Add(Me.AdvProperty)
        Me.PanelEx1.Controls.Add(Me.TextBoxX1)
        Me.PanelEx1.Controls.Add(Me.LabelX2)
        Me.PanelEx1.Controls.Add(Me.PanelEx2)
        Me.PanelEx1.Controls.Add(Me.LabelX1)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(838, 428)
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
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(370, 372)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(75, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 26
        Me.ButtonX1.Text = "Deserialize"
        '
        'AdvProperty
        '
        Me.AdvProperty.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AdvProperty.GridLinesColor = System.Drawing.Color.WhiteSmoke
        Me.AdvProperty.Location = New System.Drawing.Point(454, 28)
        Me.AdvProperty.Name = "AdvProperty"
        Me.AdvProperty.Size = New System.Drawing.Size(384, 394)
        Me.AdvProperty.TabIndex = 22
        Me.AdvProperty.Text = "AdvPropertyGrid1"
        '
        'TextBoxX1
        '
        '
        '
        '
        Me.TextBoxX1.Border.Class = "TextBoxBorder"
        Me.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX1.Location = New System.Drawing.Point(3, 401)
        Me.TextBoxX1.Name = "TextBoxX1"
        Me.TextBoxX1.PreventEnterBeep = True
        Me.TextBoxX1.Size = New System.Drawing.Size(442, 22)
        Me.TextBoxX1.TabIndex = 21
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(3, 372)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(120, 23)
        Me.LabelX2.TabIndex = 20
        Me.LabelX2.Text = "File Destination : "
        '
        'PanelEx2
        '
        Me.PanelEx2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.Statement)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Location = New System.Drawing.Point(0, 32)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(445, 334)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 16
        Me.PanelEx2.Text = "PanelEx2"
        '
        'Statement
        '
        Me.Statement.AllowSeveralTextStyleDrawing = True
        Me.Statement.AutoCompleteBrackets = True
        Me.Statement.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.Statement.AutoIndentCharsPatterns = ""
        Me.Statement.AutoScrollMinSize = New System.Drawing.Size(0, 18)
        Me.Statement.BackBrush = Nothing
        Me.Statement.BackColor = System.Drawing.Color.Gainsboro
        Me.Statement.CharHeight = 18
        Me.Statement.CharWidth = 9
        Me.Statement.CommentPrefix = Nothing
        Me.Statement.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Statement.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Statement.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Statement.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.Statement.ForeColor = System.Drawing.Color.DimGray
        Me.Statement.IsReplaceMode = False
        Me.Statement.Language = FastColoredTextBoxNS.Language.XML
        Me.Statement.LeftBracket = Global.Microsoft.VisualBasic.ChrW(60)
        Me.Statement.LeftBracket2 = Global.Microsoft.VisualBasic.ChrW(40)
        Me.Statement.LineNumberColor = System.Drawing.Color.DodgerBlue
        Me.Statement.Location = New System.Drawing.Point(0, 0)
        Me.Statement.Name = "Statement"
        Me.Statement.Paddings = New System.Windows.Forms.Padding(0)
        Me.Statement.RightBracket = Global.Microsoft.VisualBasic.ChrW(62)
        Me.Statement.RightBracket2 = Global.Microsoft.VisualBasic.ChrW(41)
        Me.Statement.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Statement.ServiceColors = CType(resources.GetObject("Statement.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
        Me.Statement.ShowFoldingLines = True
        Me.Statement.Size = New System.Drawing.Size(445, 334)
        Me.Statement.TabIndex = 16
        Me.Statement.WordWrap = True
        Me.Statement.Zoom = 100
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(12, 3)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(120, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Xml Serialization"
        '
        'Serializer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 428)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Serializer"
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.AdvProperty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx2.ResumeLayout(False)
        CType(Me.Statement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Public WithEvents Statement As FastColoredTextBoxNS.FastColoredTextBox
    Public WithEvents AdvProperty As DevComponents.DotNetBar.AdvPropertyGrid
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
End Class
