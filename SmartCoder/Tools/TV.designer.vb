<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TV
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.MediaPanel1 = New SmartCoder.MediaPanel()
        Me.Bar1 = New DevComponents.DotNetBar.Bar()
        Me.LabelItem1 = New DevComponents.DotNetBar.LabelItem()
        Me.Btn_Mute = New DevComponents.DotNetBar.ButtonItem()
        Me.Btn_DecreaseVolume = New DevComponents.DotNetBar.ButtonItem()
        Me.Btn_IncreaseVolume = New DevComponents.DotNetBar.ButtonItem()
        Me.LabelItem2 = New DevComponents.DotNetBar.LabelItem()
        Me.Btn_Channel_Next = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.S_Volume = New DevComponents.DotNetBar.SliderItem()
        Me.TextBoxItem1 = New DevComponents.DotNetBar.TextBoxItem()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupPanel1
        '
        Me.GroupPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.MediaPanel1)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 39)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(849, 434)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 4
        Me.GroupPanel1.Text = "GroupPanel1"
        '
        'MediaPanel1
        '
        Me.MediaPanel1.AutoPlay = False
        Me.MediaPanel1.Channel = Nothing
        Me.MediaPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MediaPanel1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.MediaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.MediaPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.MediaPanel1.Name = "MediaPanel1"
        Me.MediaPanel1.Size = New System.Drawing.Size(843, 413)
        Me.MediaPanel1.TabIndex = 0
        Me.MediaPanel1.Title = "Empty"
        Me.MediaPanel1.URL = Nothing
        Me.MediaPanel1.Video = Nothing
        '
        'Bar1
        '
        Me.Bar1.AntiAlias = True
        Me.Bar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Bar1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Bar1.IsMaximized = False
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.LabelItem1, Me.Btn_Mute, Me.Btn_DecreaseVolume, Me.Btn_IncreaseVolume, Me.LabelItem2, Me.Btn_Channel_Next, Me.ButtonItem1, Me.S_Volume, Me.TextBoxItem1})
        Me.Bar1.Location = New System.Drawing.Point(0, 0)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Size = New System.Drawing.Size(849, 33)
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar1.TabIndex = 1
        Me.Bar1.TabStop = False
        Me.Bar1.Text = "Bar1"
        '
        'LabelItem1
        '
        Me.LabelItem1.Name = "LabelItem1"
        Me.LabelItem1.Text = "Volume"
        '
        'Btn_Mute
        '
        Me.Btn_Mute.Name = "Btn_Mute"
        Me.Btn_Mute.Symbol = ""
        Me.Btn_Mute.Text = "ButtonItem1"
        '
        'Btn_DecreaseVolume
        '
        Me.Btn_DecreaseVolume.Name = "Btn_DecreaseVolume"
        Me.Btn_DecreaseVolume.Symbol = ""
        Me.Btn_DecreaseVolume.Text = "ButtonItem2"
        '
        'Btn_IncreaseVolume
        '
        Me.Btn_IncreaseVolume.Name = "Btn_IncreaseVolume"
        Me.Btn_IncreaseVolume.Symbol = ""
        Me.Btn_IncreaseVolume.Text = "ButtonItem3"
        '
        'LabelItem2
        '
        Me.LabelItem2.Name = "LabelItem2"
        Me.LabelItem2.Text = "Channel"
        '
        'Btn_Channel_Next
        '
        Me.Btn_Channel_Next.Name = "Btn_Channel_Next"
        Me.Btn_Channel_Next.Symbol = "57672"
        Me.Btn_Channel_Next.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.Btn_Channel_Next.Text = "ButtonItem1"
        '
        'ButtonItem1
        '
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.Text = "Stop"
        '
        'S_Volume
        '
        Me.S_Volume.LabelWidth = 50
        Me.S_Volume.Name = "S_Volume"
        Me.S_Volume.Step = 5
        Me.S_Volume.Text = "Volume"
        Me.S_Volume.Value = 0
        '
        'TextBoxItem1
        '
        Me.TextBoxItem1.Name = "TextBoxItem1"
        Me.TextBoxItem1.TextBoxWidth = 255
        Me.TextBoxItem1.WatermarkColor = System.Drawing.SystemColors.GrayText
        '
        'TV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Bar1)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Name = "TV"
        Me.Size = New System.Drawing.Size(849, 473)
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents MediaPanel1 As MediaPanel
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents LabelItem1 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents Btn_Mute As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Btn_DecreaseVolume As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Btn_IncreaseVolume As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents LabelItem2 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents Btn_Channel_Next As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents S_Volume As DevComponents.DotNetBar.SliderItem
    Friend WithEvents TextBoxItem1 As DevComponents.DotNetBar.TextBoxItem
End Class
