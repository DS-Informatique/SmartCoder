Imports AXVLC
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MediaPanel
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MediaPanel))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.Panel_Container = New DevComponents.DotNetBar.PanelEx()
        Me.ContextMenuBar1 = New DevComponents.DotNetBar.ContextMenuBar()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.LabelItem3 = New DevComponents.DotNetBar.LabelItem()
        Me.ButtonItem7 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem8 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem9 = New DevComponents.DotNetBar.ButtonItem()
        Me.LabelItem2 = New DevComponents.DotNetBar.LabelItem()
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem3 = New DevComponents.DotNetBar.ButtonItem()
        Me.LabelItem1 = New DevComponents.DotNetBar.LabelItem()
        Me.ButtonItem4 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem5 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem6 = New DevComponents.DotNetBar.ButtonItem()
        Me.SliderItem1 = New DevComponents.DotNetBar.SliderItem()
        Me.LabelItem5 = New DevComponents.DotNetBar.LabelItem()
        Me.GalleryContainer1 = New DevComponents.DotNetBar.GalleryContainer()
        Me.ButtonItem10 = New DevComponents.DotNetBar.ButtonItem()
        Me.VLC1 = New AxAXVLC.AxVLCPlugin2()
        Me.SuperTooltip1 = New DevComponents.DotNetBar.SuperTooltip()
        Me.PanelEx1.SuspendLayout()
        Me.Panel_Container.SuspendLayout()
        CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VLC1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.Panel_Container)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(880, 444)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.Color = System.Drawing.Color.Transparent
        Me.PanelEx1.Style.BackColor2.Color = System.Drawing.Color.Transparent
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        Me.PanelEx1.Text = " "
        '
        'Panel_Container
        '
        Me.Panel_Container.CanvasColor = System.Drawing.SystemColors.Control
        Me.Panel_Container.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Panel_Container.Controls.Add(Me.ContextMenuBar1)
        Me.Panel_Container.Controls.Add(Me.VLC1)
        Me.Panel_Container.DisabledBackColor = System.Drawing.Color.Empty
        Me.Panel_Container.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Container.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Container.Name = "Panel_Container"
        Me.Panel_Container.Size = New System.Drawing.Size(880, 444)
        Me.Panel_Container.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Panel_Container.Style.BackColor1.Color = System.Drawing.Color.Transparent
        Me.Panel_Container.Style.BackColor2.Color = System.Drawing.Color.Transparent
        Me.Panel_Container.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Panel_Container.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Panel_Container.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.Panel_Container.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Panel_Container.Style.GradientAngle = 90
        Me.Panel_Container.TabIndex = 1
        Me.Panel_Container.Text = " "
        '
        'ContextMenuBar1
        '
        Me.ContextMenuBar1.AntiAlias = True
        Me.ContextMenuBar1.DockSide = DevComponents.DotNetBar.eDockSide.Document
        Me.ContextMenuBar1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ContextMenuBar1.IsMaximized = False
        Me.ContextMenuBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem1})
        Me.ContextMenuBar1.Location = New System.Drawing.Point(630, 59)
        Me.ContextMenuBar1.Name = "ContextMenuBar1"
        Me.ContextMenuBar1.Size = New System.Drawing.Size(75, 25)
        Me.ContextMenuBar1.Stretch = True
        Me.ContextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ContextMenuBar1.TabIndex = 0
        Me.ContextMenuBar1.TabStop = False
        Me.ContextMenuBar1.Text = "ContextMenuBar1"
        '
        'ButtonItem1
        '
        Me.ButtonItem1.AutoExpandOnClick = True
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.LabelItem3, Me.ButtonItem7, Me.LabelItem2, Me.ButtonItem2, Me.ButtonItem3, Me.LabelItem1, Me.ButtonItem4, Me.ButtonItem5, Me.ButtonItem6, Me.SliderItem1, Me.LabelItem5, Me.GalleryContainer1})
        Me.ButtonItem1.Text = "Option"
        '
        'LabelItem3
        '
        Me.LabelItem3.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.LabelItem3.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.LabelItem3.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.LabelItem3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.LabelItem3.Name = "LabelItem3"
        Me.LabelItem3.PaddingBottom = 1
        Me.LabelItem3.PaddingLeft = 10
        Me.LabelItem3.PaddingTop = 1
        Me.LabelItem3.SingleLineColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.LabelItem3.Text = "Main"
        '
        'ButtonItem7
        '
        Me.ButtonItem7.Name = "ButtonItem7"
        Me.ButtonItem7.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem8, Me.ButtonItem9})
        Me.ButtonItem7.Text = "Ajouter"
        '
        'ButtonItem8
        '
        Me.ButtonItem8.Name = "ButtonItem8"
        Me.ButtonItem8.Text = "Youtube"
        '
        'ButtonItem9
        '
        Me.ButtonItem9.Name = "ButtonItem9"
        Me.ButtonItem9.Text = "FilePath or URL"
        '
        'LabelItem2
        '
        Me.LabelItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.LabelItem2.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.LabelItem2.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.LabelItem2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.LabelItem2.Name = "LabelItem2"
        Me.LabelItem2.PaddingBottom = 1
        Me.LabelItem2.PaddingLeft = 10
        Me.LabelItem2.PaddingTop = 1
        Me.LabelItem2.SingleLineColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.LabelItem2.Text = "Current"
        '
        'ButtonItem2
        '
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.Text = "Pause"
        '
        'ButtonItem3
        '
        Me.ButtonItem3.Name = "ButtonItem3"
        Me.ButtonItem3.Text = "Play"
        '
        'LabelItem1
        '
        Me.LabelItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.LabelItem1.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.LabelItem1.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.LabelItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.LabelItem1.Name = "LabelItem1"
        Me.LabelItem1.PaddingBottom = 1
        Me.LabelItem1.PaddingLeft = 10
        Me.LabelItem1.PaddingTop = 1
        Me.LabelItem1.SingleLineColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.LabelItem1.Text = "Volume"
        '
        'ButtonItem4
        '
        Me.ButtonItem4.Name = "ButtonItem4"
        Me.ButtonItem4.Text = "Increase"
        '
        'ButtonItem5
        '
        Me.ButtonItem5.Name = "ButtonItem5"
        Me.ButtonItem5.Text = "Decrease"
        '
        'ButtonItem6
        '
        Me.ButtonItem6.Name = "ButtonItem6"
        Me.ButtonItem6.Text = "Mute"
        '
        'SliderItem1
        '
        Me.SliderItem1.LabelWidth = 50
        Me.SliderItem1.Name = "SliderItem1"
        Me.SliderItem1.Text = "Volume"
        Me.SliderItem1.Value = 0
        '
        'LabelItem5
        '
        Me.LabelItem5.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.LabelItem5.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.LabelItem5.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.LabelItem5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.LabelItem5.Name = "LabelItem5"
        Me.LabelItem5.PaddingBottom = 1
        Me.LabelItem5.PaddingLeft = 10
        Me.LabelItem5.PaddingTop = 1
        Me.LabelItem5.SingleLineColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.LabelItem5.Text = "Proposition"
        '
        'GalleryContainer1
        '
        '
        '
        '
        Me.GalleryContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GalleryContainer1.EnableGalleryPopup = False
        Me.GalleryContainer1.MinimumSize = New System.Drawing.Size(150, 200)
        Me.GalleryContainer1.Name = "GalleryContainer1"
        Me.GalleryContainer1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem10})
        Me.GalleryContainer1.Text = "GalleryContainer1"
        '
        '
        '
        Me.GalleryContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonItem10
        '
        Me.ButtonItem10.Name = "ButtonItem10"
        Me.ButtonItem10.Text = "ButtonItem10"
        '
        'VLC1
        '
        Me.ContextMenuBar1.SetContextMenuEx(Me.VLC1, Me.ButtonItem1)
        Me.VLC1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VLC1.Enabled = True
        Me.VLC1.Location = New System.Drawing.Point(0, 0)
        Me.VLC1.Name = "VLC1"
        Me.VLC1.OcxState = CType(resources.GetObject("VLC1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.VLC1.Size = New System.Drawing.Size(880, 444)
        Me.VLC1.TabIndex = 0
        '
        'SuperTooltip1
        '
        Me.SuperTooltip1.DefaultTooltipSettings = New DevComponents.DotNetBar.SuperTooltipInfo("", "", "", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray)
        Me.SuperTooltip1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        '
        'MediaPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MediaPanel"
        Me.Size = New System.Drawing.Size(880, 444)
        Me.PanelEx1.ResumeLayout(False)
        Me.Panel_Container.ResumeLayout(False)
        CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VLC1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ContextMenuBar1 As DevComponents.DotNetBar.ContextMenuBar
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents LabelItem3 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents ButtonItem7 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem8 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem9 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents LabelItem2 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents LabelItem1 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents ButtonItem4 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem5 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem6 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents SliderItem1 As DevComponents.DotNetBar.SliderItem
    Friend WithEvents LabelItem5 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents GalleryContainer1 As DevComponents.DotNetBar.GalleryContainer
    Friend WithEvents ButtonItem10 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Panel_Container As DevComponents.DotNetBar.PanelEx
    Friend WithEvents SuperTooltip1 As DevComponents.DotNetBar.SuperTooltip
    Friend WithEvents VLC1 As AxAXVLC.AxVLCPlugin2
End Class
