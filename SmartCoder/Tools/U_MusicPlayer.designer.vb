<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class U_MusicPlayer
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(U_MusicPlayer))
        Me.DotNetBarManager1 = New DevComponents.DotNetBar.DotNetBarManager(Me.components)
        Me.DockSite4 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite9 = New DevComponents.DotNetBar.DockSite()
        Me.Bar2 = New DevComponents.DotNetBar.Bar()
        Me.PanelDockContainer1 = New DevComponents.DotNetBar.PanelDockContainer()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.TabControl1 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
        Me.PanelEx20 = New DevComponents.DotNetBar.PanelEx()
        Me.LV_Playlist = New DevComponents.DotNetBar.ListBoxAdv()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.Btn_Play = New DevComponents.DotNetBar.ButtonX()
        Me.Btn_Stop = New DevComponents.DotNetBar.ButtonX()
        Me.Btn_Remove = New DevComponents.DotNetBar.ButtonX()
        Me.TabItem2 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.Btn_AddAll = New DevComponents.DotNetBar.ButtonX()
        Me.Btn_Add = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx18 = New DevComponents.DotNetBar.PanelEx()
        Me.LV_Dir = New DevComponents.DotNetBar.ListBoxAdv()
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.Bar6 = New DevComponents.DotNetBar.Bar()
        Me.LabelItem3 = New DevComponents.DotNetBar.LabelItem()
        Me.Btn_Change_MusicFolder = New DevComponents.DotNetBar.ButtonItem()
        Me.Txt_Music = New DevComponents.DotNetBar.LabelItem()
        Me.Bar5 = New DevComponents.DotNetBar.Bar()
        Me.PanelDockContainer2 = New DevComponents.DotNetBar.PanelDockContainer()
        Me.MP3PLayer = New AxWMPLib.AxWindowsMediaPlayer()
        Me.DockContainerItem1 = New DevComponents.DotNetBar.DockContainerItem()
        Me.DockContainerItem2 = New DevComponents.DotNetBar.DockContainerItem()
        Me.DockSite1 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite2 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite8 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite5 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite6 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite7 = New DevComponents.DotNetBar.DockSite()
        Me.Bar1 = New DevComponents.DotNetBar.Bar()
        Me.Btn_PlayMusic = New DevComponents.DotNetBar.ButtonItem()
        Me.Btn_PauseMusic = New DevComponents.DotNetBar.ButtonItem()
        Me.Btn_StopMusic = New DevComponents.DotNetBar.ButtonItem()
        Me.Btn_PreviousMusic = New DevComponents.DotNetBar.ButtonItem()
        Me.Btn_NextMusic = New DevComponents.DotNetBar.ButtonItem()
        Me.Btn_Mute = New DevComponents.DotNetBar.ButtonItem()
        Me.Btn_DecreaseVolume = New DevComponents.DotNetBar.ButtonItem()
        Me.Btn_IncreaseVolume = New DevComponents.DotNetBar.ButtonItem()
        Me.PbarVolume = New DevComponents.DotNetBar.ProgressBarItem()
        Me.Bar4 = New DevComponents.DotNetBar.Bar()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.LabelItem1 = New DevComponents.DotNetBar.LabelItem()
        Me.Btn_Small = New DevComponents.DotNetBar.ButtonItem()
        Me.Btn_Normal = New DevComponents.DotNetBar.ButtonItem()
        Me.Bar3 = New DevComponents.DotNetBar.Bar()
        Me.Music_Volume = New DevComponents.DotNetBar.SliderItem()
        Me.L_SongName = New DevComponents.DotNetBar.LabelItem()
        Me.DockSite3 = New DevComponents.DotNetBar.DockSite()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelItem2 = New DevComponents.DotNetBar.LabelItem()
        Me.Btn_Suffle = New DevComponents.DotNetBar.ButtonItem()
        Me.DockSite9.SuspendLayout()
        CType(Me.Bar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bar2.SuspendLayout()
        Me.PanelDockContainer1.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabControlPanel2.SuspendLayout()
        Me.PanelEx20.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        Me.PanelEx18.SuspendLayout()
        CType(Me.Bar6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bar5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDockContainer2.SuspendLayout()
        CType(Me.MP3PLayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockSite7.SuspendLayout()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bar4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bar3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DotNetBarManager1
        '
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.F1)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlV)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlZ)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlY)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Del)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins)
        Me.DotNetBarManager1.BottomDockSite = Me.DockSite4
        Me.DotNetBarManager1.EnableFullSizeDock = False
        Me.DotNetBarManager1.FillDockSite = Me.DockSite9
        Me.DotNetBarManager1.LeftDockSite = Me.DockSite1
        Me.DotNetBarManager1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.DotNetBarManager1.ParentForm = Nothing
        Me.DotNetBarManager1.ParentUserControl = Me
        Me.DotNetBarManager1.RightDockSite = Me.DockSite2
        Me.DotNetBarManager1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.DotNetBarManager1.ToolbarBottomDockSite = Me.DockSite8
        Me.DotNetBarManager1.ToolbarLeftDockSite = Me.DockSite5
        Me.DotNetBarManager1.ToolbarRightDockSite = Me.DockSite6
        Me.DotNetBarManager1.ToolbarTopDockSite = Me.DockSite7
        Me.DotNetBarManager1.TopDockSite = Me.DockSite3
        '
        'DockSite4
        '
        Me.DockSite4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DockSite4.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite4.Location = New System.Drawing.Point(0, 254)
        Me.DockSite4.Name = "DockSite4"
        Me.DockSite4.Size = New System.Drawing.Size(398, 0)
        Me.DockSite4.TabIndex = 7
        Me.DockSite4.TabStop = False
        '
        'DockSite9
        '
        Me.DockSite9.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite9.Controls.Add(Me.Bar2)
        Me.DockSite9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DockSite9.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer(New DevComponents.DotNetBar.DocumentBaseContainer() {CType(New DevComponents.DotNetBar.DocumentBarContainer(Me.Bar2, 398, 199), DevComponents.DotNetBar.DocumentBaseContainer)}, DevComponents.DotNetBar.eOrientation.Vertical)
        Me.DockSite9.Location = New System.Drawing.Point(0, 55)
        Me.DockSite9.Name = "DockSite9"
        Me.DockSite9.Size = New System.Drawing.Size(398, 199)
        Me.DockSite9.TabIndex = 12
        Me.DockSite9.TabStop = False
        '
        'Bar2
        '
        Me.Bar2.AccessibleDescription = "DotNetBar Bar (Bar2)"
        Me.Bar2.AccessibleName = "DotNetBar Bar"
        Me.Bar2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.Bar2.AlwaysDisplayDockTab = True
        Me.Bar2.CanCustomize = False
        Me.Bar2.CanDockBottom = False
        Me.Bar2.CanDockDocument = True
        Me.Bar2.CanDockLeft = False
        Me.Bar2.CanDockRight = False
        Me.Bar2.CanDockTop = False
        Me.Bar2.CanHide = True
        Me.Bar2.CanUndock = False
        Me.Bar2.Controls.Add(Me.PanelDockContainer1)
        Me.Bar2.Controls.Add(Me.PanelDockContainer2)
        Me.Bar2.DockTabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top
        Me.Bar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bar2.IsMaximized = False
        Me.Bar2.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.DockContainerItem1, Me.DockContainerItem2})
        Me.Bar2.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer
        Me.Bar2.Location = New System.Drawing.Point(0, 0)
        Me.Bar2.Name = "Bar2"
        Me.Bar2.SelectedDockTab = 0
        Me.Bar2.Size = New System.Drawing.Size(398, 199)
        Me.Bar2.Stretch = True
        Me.Bar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar2.TabIndex = 0
        Me.Bar2.TabNavigation = True
        Me.Bar2.TabStop = False
        '
        'PanelDockContainer1
        '
        Me.PanelDockContainer1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelDockContainer1.Controls.Add(Me.PanelEx1)
        Me.PanelDockContainer1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelDockContainer1.Location = New System.Drawing.Point(3, 28)
        Me.PanelDockContainer1.Name = "PanelDockContainer1"
        Me.PanelDockContainer1.Size = New System.Drawing.Size(392, 168)
        Me.PanelDockContainer1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelDockContainer1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelDockContainer1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.PanelDockContainer1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelDockContainer1.Style.GradientAngle = 90
        Me.PanelDockContainer1.TabIndex = 0
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.TabControl1)
        Me.PanelEx1.Controls.Add(Me.Bar6)
        Me.PanelEx1.Controls.Add(Me.Bar5)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(392, 168)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.BackgroundImage = My.Resources.Resources.Wallpaper_Welome
        Me.PanelEx1.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.BottomRight
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 4
        Me.PanelEx1.Text = " "
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.BackColor = System.Drawing.Color.Transparent
        Me.TabControl1.CanReorderTabs = True
        Me.TabControl1.Controls.Add(Me.TabControlPanel1)
        Me.TabControl1.Controls.Add(Me.TabControlPanel2)
        Me.TabControl1.Location = New System.Drawing.Point(3, 36)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.SelectedTabIndex = 1
        Me.TabControl1.Size = New System.Drawing.Size(386, 129)
        Me.TabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.RoundHeader
        Me.TabControl1.TabIndex = 41
        Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl1.Tabs.Add(Me.TabItem1)
        Me.TabControl1.Tabs.Add(Me.TabItem2)
        Me.TabControl1.Text = "TabControl1"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.PanelEx20)
        Me.TabControlPanel2.Controls.Add(Me.PanelEx3)
        Me.TabControlPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 25)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(386, 104)
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.White
        Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.SystemColors.ControlDarkDark
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabIndex = 5
        Me.TabControlPanel2.TabItem = Me.TabItem2
        '
        'PanelEx20
        '
        Me.PanelEx20.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelEx20.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx20.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx20.Controls.Add(Me.LV_Playlist)
        Me.PanelEx20.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx20.Location = New System.Drawing.Point(3, 36)
        Me.PanelEx20.Name = "PanelEx20"
        Me.PanelEx20.Size = New System.Drawing.Size(379, 64)
        Me.PanelEx20.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx20.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx20.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx20.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx20.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx20.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx20.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx20.Style.GradientAngle = 90
        Me.PanelEx20.TabIndex = 12
        Me.PanelEx20.Text = " "
        '
        'LV_Playlist
        '
        Me.LV_Playlist.AutoScroll = True
        '
        '
        '
        Me.LV_Playlist.BackgroundStyle.Class = "ListBoxAdv"
        Me.LV_Playlist.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LV_Playlist.ContainerControlProcessDialogKey = True
        Me.LV_Playlist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LV_Playlist.DragDropSupport = True
        Me.LV_Playlist.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.LV_Playlist.Location = New System.Drawing.Point(0, 0)
        Me.LV_Playlist.Name = "LV_Playlist"
        Me.LV_Playlist.Size = New System.Drawing.Size(379, 64)
        Me.LV_Playlist.TabIndex = 0
        Me.LV_Playlist.Text = "ListBoxAdv1"
        '
        'PanelEx3
        '
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.Controls.Add(Me.Btn_Play)
        Me.PanelEx3.Controls.Add(Me.Btn_Stop)
        Me.PanelEx3.Controls.Add(Me.Btn_Remove)
        Me.PanelEx3.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx3.Location = New System.Drawing.Point(1, 1)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(384, 29)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 40
        Me.PanelEx3.Text = " "
        '
        'Btn_Play
        '
        Me.Btn_Play.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_Play.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Btn_Play.Location = New System.Drawing.Point(10, 3)
        Me.Btn_Play.Name = "Btn_Play"
        Me.Btn_Play.Size = New System.Drawing.Size(40, 23)
        Me.Btn_Play.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_Play.TabIndex = 18
        Me.Btn_Play.Text = "Play"
        '
        'Btn_Stop
        '
        Me.Btn_Stop.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_Stop.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Btn_Stop.Location = New System.Drawing.Point(56, 3)
        Me.Btn_Stop.Name = "Btn_Stop"
        Me.Btn_Stop.Size = New System.Drawing.Size(60, 23)
        Me.Btn_Stop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_Stop.TabIndex = 19
        Me.Btn_Stop.Text = "Stop"
        '
        'Btn_Remove
        '
        Me.Btn_Remove.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_Remove.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Btn_Remove.Location = New System.Drawing.Point(122, 3)
        Me.Btn_Remove.Name = "Btn_Remove"
        Me.Btn_Remove.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Remove.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_Remove.TabIndex = 17
        Me.Btn_Remove.Text = "Remove"
        '
        'TabItem2
        '
        Me.TabItem2.AttachedControl = Me.TabControlPanel2
        Me.TabItem2.Name = "TabItem2"
        Me.TabItem2.Text = "PlayList"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.PanelEx2)
        Me.TabControlPanel1.Controls.Add(Me.PanelEx18)
        Me.TabControlPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 25)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(386, 104)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.White
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.SystemColors.ControlDarkDark
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 1
        Me.TabControlPanel1.TabItem = Me.TabItem1
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.Btn_AddAll)
        Me.PanelEx2.Controls.Add(Me.Btn_Add)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx2.Location = New System.Drawing.Point(1, 1)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(384, 29)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 33
        Me.PanelEx2.Text = " "
        '
        'Btn_AddAll
        '
        Me.Btn_AddAll.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_AddAll.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Btn_AddAll.Dock = System.Windows.Forms.DockStyle.Right
        Me.Btn_AddAll.Location = New System.Drawing.Point(336, 0)
        Me.Btn_AddAll.Name = "Btn_AddAll"
        Me.Btn_AddAll.Size = New System.Drawing.Size(48, 29)
        Me.Btn_AddAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_AddAll.TabIndex = 15
        Me.Btn_AddAll.Text = "Add All"
        '
        'Btn_Add
        '
        Me.Btn_Add.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_Add.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Btn_Add.Dock = System.Windows.Forms.DockStyle.Left
        Me.Btn_Add.Location = New System.Drawing.Point(0, 0)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Size = New System.Drawing.Size(43, 29)
        Me.Btn_Add.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_Add.TabIndex = 14
        Me.Btn_Add.Text = "Add"
        '
        'PanelEx18
        '
        Me.PanelEx18.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelEx18.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx18.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx18.Controls.Add(Me.LV_Dir)
        Me.PanelEx18.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx18.Location = New System.Drawing.Point(4, 28)
        Me.PanelEx18.Name = "PanelEx18"
        Me.PanelEx18.Size = New System.Drawing.Size(382, 72)
        Me.PanelEx18.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx18.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx18.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx18.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx18.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx18.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx18.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx18.Style.GradientAngle = 90
        Me.PanelEx18.TabIndex = 12
        Me.PanelEx18.Text = " "
        '
        'LV_Dir
        '
        Me.LV_Dir.AutoScroll = True
        '
        '
        '
        Me.LV_Dir.BackgroundStyle.Class = "ListBoxAdv"
        Me.LV_Dir.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LV_Dir.ContainerControlProcessDialogKey = True
        Me.LV_Dir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LV_Dir.DragDropSupport = True
        Me.LV_Dir.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.LV_Dir.Location = New System.Drawing.Point(0, 0)
        Me.LV_Dir.Name = "LV_Dir"
        Me.LV_Dir.Size = New System.Drawing.Size(382, 72)
        Me.LV_Dir.TabIndex = 33
        Me.LV_Dir.Text = "ListBoxAdv1"
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabControlPanel1
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "Directory"
        '
        'Bar6
        '
        Me.Bar6.AccessibleDescription = "DotNetBar Bar (Bar6)"
        Me.Bar6.AccessibleName = "DotNetBar Bar"
        Me.Bar6.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.Bar6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Bar6.DockLine = 1
        Me.Bar6.DockSide = DevComponents.DotNetBar.eDockSide.Document
        Me.Bar6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Bar6.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003
        Me.Bar6.IsMaximized = False
        Me.Bar6.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.LabelItem3, Me.Btn_Change_MusicFolder, Me.Txt_Music})
        Me.Bar6.Location = New System.Drawing.Point(0, 2)
        Me.Bar6.Name = "Bar6"
        Me.Bar6.Size = New System.Drawing.Size(392, 31)
        Me.Bar6.Stretch = True
        Me.Bar6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar6.TabIndex = 28
        Me.Bar6.TabStop = False
        Me.Bar6.Text = "Bar6"
        '
        'LabelItem3
        '
        Me.LabelItem3.Name = "LabelItem3"
        Me.LabelItem3.Text = "Choose a Folder"
        '
        'Btn_Change_MusicFolder
        '
        Me.Btn_Change_MusicFolder.Name = "Btn_Change_MusicFolder"
        Me.Btn_Change_MusicFolder.Symbol = ""
        Me.Btn_Change_MusicFolder.Text = " "
        '
        'Txt_Music
        '
        Me.Txt_Music.Name = "Txt_Music"
        Me.Txt_Music.Text = "Path"
        '
        'Bar5
        '
        Me.Bar5.AccessibleDescription = "DotNetBar Bar (Bar5)"
        Me.Bar5.AccessibleName = "DotNetBar Bar"
        Me.Bar5.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.Bar5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Bar5.DockOffset = 333
        Me.Bar5.DockSide = DevComponents.DotNetBar.eDockSide.Document
        Me.Bar5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Bar5.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003
        Me.Bar5.IsMaximized = False
        Me.Bar5.Location = New System.Drawing.Point(0, 0)
        Me.Bar5.Name = "Bar5"
        Me.Bar5.Size = New System.Drawing.Size(392, 2)
        Me.Bar5.Stretch = True
        Me.Bar5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar5.TabIndex = 27
        Me.Bar5.TabStop = False
        Me.Bar5.Text = "Bar5"
        '
        'PanelDockContainer2
        '
        Me.PanelDockContainer2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelDockContainer2.Controls.Add(Me.MP3PLayer)
        Me.PanelDockContainer2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelDockContainer2.Location = New System.Drawing.Point(3, 28)
        Me.PanelDockContainer2.Name = "PanelDockContainer2"
        Me.PanelDockContainer2.Size = New System.Drawing.Size(392, 168)
        Me.PanelDockContainer2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelDockContainer2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelDockContainer2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.PanelDockContainer2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelDockContainer2.Style.GradientAngle = 90
        Me.PanelDockContainer2.TabIndex = 5
        '
        'MP3PLayer
        '
        Me.MP3PLayer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MP3PLayer.Enabled = True
        Me.MP3PLayer.Location = New System.Drawing.Point(0, 0)
        Me.MP3PLayer.Name = "MP3PLayer"
        Me.MP3PLayer.OcxState = CType(resources.GetObject("MP3PLayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MP3PLayer.Size = New System.Drawing.Size(392, 168)
        Me.MP3PLayer.TabIndex = 1
        '
        'DockContainerItem1
        '
        Me.DockContainerItem1.Control = Me.PanelDockContainer1
        Me.DockContainerItem1.Name = "DockContainerItem1"
        Me.DockContainerItem1.Text = "PlayList"
        '
        'DockContainerItem2
        '
        Me.DockContainerItem2.Control = Me.PanelDockContainer2
        Me.DockContainerItem2.Name = "DockContainerItem2"
        Me.DockContainerItem2.Text = "Player"
        Me.DockContainerItem2.Visible = False
        '
        'DockSite1
        '
        Me.DockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite1.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite1.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite1.Location = New System.Drawing.Point(0, 55)
        Me.DockSite1.Name = "DockSite1"
        Me.DockSite1.Size = New System.Drawing.Size(0, 199)
        Me.DockSite1.TabIndex = 4
        Me.DockSite1.TabStop = False
        '
        'DockSite2
        '
        Me.DockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite2.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite2.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite2.Location = New System.Drawing.Point(398, 55)
        Me.DockSite2.Name = "DockSite2"
        Me.DockSite2.Size = New System.Drawing.Size(0, 199)
        Me.DockSite2.TabIndex = 5
        Me.DockSite2.TabStop = False
        '
        'DockSite8
        '
        Me.DockSite8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DockSite8.Location = New System.Drawing.Point(0, 254)
        Me.DockSite8.Name = "DockSite8"
        Me.DockSite8.Size = New System.Drawing.Size(398, 0)
        Me.DockSite8.TabIndex = 11
        Me.DockSite8.TabStop = False
        '
        'DockSite5
        '
        Me.DockSite5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite5.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite5.Location = New System.Drawing.Point(0, 55)
        Me.DockSite5.Name = "DockSite5"
        Me.DockSite5.Size = New System.Drawing.Size(0, 199)
        Me.DockSite5.TabIndex = 8
        Me.DockSite5.TabStop = False
        '
        'DockSite6
        '
        Me.DockSite6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite6.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite6.Location = New System.Drawing.Point(398, 55)
        Me.DockSite6.Name = "DockSite6"
        Me.DockSite6.Size = New System.Drawing.Size(0, 199)
        Me.DockSite6.TabIndex = 9
        Me.DockSite6.TabStop = False
        '
        'DockSite7
        '
        Me.DockSite7.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite7.BackgroundImage = My.Resources.Resources.Wallpaper_Welome
        Me.DockSite7.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.TopRight
        Me.DockSite7.Controls.Add(Me.Bar4)
        Me.DockSite7.Controls.Add(Me.Bar1)
        Me.DockSite7.Controls.Add(Me.Bar3)
        Me.DockSite7.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite7.Location = New System.Drawing.Point(0, 0)
        Me.DockSite7.Name = "DockSite7"
        Me.DockSite7.Size = New System.Drawing.Size(398, 55)
        Me.DockSite7.TabIndex = 10
        Me.DockSite7.TabStop = False
        '
        'Bar1
        '
        Me.Bar1.AccessibleDescription = "Bar1 (Bar1)"
        Me.Bar1.AccessibleName = "Bar1"
        Me.Bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.Bar1.DockSide = DevComponents.DotNetBar.eDockSide.Top
        Me.Bar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bar1.IsMaximized = False
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Btn_PlayMusic, Me.Btn_PauseMusic, Me.Btn_StopMusic, Me.Btn_PreviousMusic, Me.Btn_NextMusic, Me.Btn_Mute, Me.Btn_DecreaseVolume, Me.Btn_IncreaseVolume, Me.PbarVolume})
        Me.Bar1.Location = New System.Drawing.Point(56, 0)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Size = New System.Drawing.Size(332, 33)
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar1.TabIndex = 0
        Me.Bar1.TabStop = False
        Me.Bar1.Text = "Bar1"
        '
        'Btn_PlayMusic
        '
        Me.Btn_PlayMusic.Name = "Btn_PlayMusic"
        Me.Btn_PlayMusic.Symbol = "57399"
        Me.Btn_PlayMusic.SymbolColor = System.Drawing.Color.White
        Me.Btn_PlayMusic.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.Btn_PlayMusic.Text = "ButtonItem1"
        '
        'Btn_PauseMusic
        '
        Me.Btn_PauseMusic.Name = "Btn_PauseMusic"
        Me.Btn_PauseMusic.Symbol = "57396"
        Me.Btn_PauseMusic.SymbolColor = System.Drawing.Color.White
        Me.Btn_PauseMusic.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.Btn_PauseMusic.Text = "ButtonItem2"
        '
        'Btn_StopMusic
        '
        Me.Btn_StopMusic.Name = "Btn_StopMusic"
        Me.Btn_StopMusic.Symbol = "57415"
        Me.Btn_StopMusic.SymbolColor = System.Drawing.Color.White
        Me.Btn_StopMusic.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.Btn_StopMusic.Text = "ButtonItem3"
        '
        'Btn_PreviousMusic
        '
        Me.Btn_PreviousMusic.Name = "Btn_PreviousMusic"
        Me.Btn_PreviousMusic.Symbol = "57413"
        Me.Btn_PreviousMusic.SymbolColor = System.Drawing.Color.White
        Me.Btn_PreviousMusic.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.Btn_PreviousMusic.Text = "ButtonItem4"
        '
        'Btn_NextMusic
        '
        Me.Btn_NextMusic.Name = "Btn_NextMusic"
        Me.Btn_NextMusic.Symbol = "57412"
        Me.Btn_NextMusic.SymbolColor = System.Drawing.Color.White
        Me.Btn_NextMusic.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.Btn_NextMusic.Text = "ButtonItem5"
        '
        'Btn_Mute
        '
        Me.Btn_Mute.Name = "Btn_Mute"
        Me.Btn_Mute.Symbol = ""
        Me.Btn_Mute.SymbolColor = System.Drawing.Color.White
        Me.Btn_Mute.Text = "ButtonItem1"
        '
        'Btn_DecreaseVolume
        '
        Me.Btn_DecreaseVolume.Name = "Btn_DecreaseVolume"
        Me.Btn_DecreaseVolume.Symbol = ""
        Me.Btn_DecreaseVolume.SymbolColor = System.Drawing.Color.White
        Me.Btn_DecreaseVolume.Text = "ButtonItem2"
        '
        'Btn_IncreaseVolume
        '
        Me.Btn_IncreaseVolume.Name = "Btn_IncreaseVolume"
        Me.Btn_IncreaseVolume.Symbol = ""
        Me.Btn_IncreaseVolume.SymbolColor = System.Drawing.Color.White
        Me.Btn_IncreaseVolume.Text = "ButtonItem3"
        '
        'PbarVolume
        '
        '
        '
        '
        Me.PbarVolume.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.PbarVolume.ChunkGradientAngle = 0!
        Me.PbarVolume.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.PbarVolume.Name = "PbarVolume"
        Me.PbarVolume.RecentlyUsed = False
        '
        'Bar4
        '
        Me.Bar4.AccessibleDescription = "DotNetBar Bar (Bar4)"
        Me.Bar4.AccessibleName = "DotNetBar Bar"
        Me.Bar4.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.Bar4.DockSide = DevComponents.DotNetBar.eDockSide.Top
        Me.Bar4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Bar4.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003
        Me.Bar4.IsMaximized = False
        Me.Bar4.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem1})
        Me.Bar4.Location = New System.Drawing.Point(0, 0)
        Me.Bar4.Name = "Bar4"
        Me.Bar4.Size = New System.Drawing.Size(54, 31)
        Me.Bar4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar4.TabIndex = 1
        Me.Bar4.TabStop = False
        Me.Bar4.Text = "Bar4"
        '
        'ButtonItem1
        '
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.LabelItem1, Me.Btn_Small, Me.Btn_Normal, Me.LabelItem2, Me.Btn_Suffle})
        Me.ButtonItem1.Symbol = ""
        Me.ButtonItem1.SymbolColor = System.Drawing.Color.White
        Me.ButtonItem1.Text = "View"
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
        Me.LabelItem1.Text = "Change Format"
        '
        'Btn_Small
        '
        Me.Btn_Small.Name = "Btn_Small"
        Me.Btn_Small.Text = "Small"
        '
        'Btn_Normal
        '
        Me.Btn_Normal.Name = "Btn_Normal"
        Me.Btn_Normal.Text = "Normal"
        '
        'Bar3
        '
        Me.Bar3.AccessibleDescription = "DotNetBar Bar (Bar3)"
        Me.Bar3.AccessibleName = "DotNetBar Bar"
        Me.Bar3.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.Bar3.DockLine = 1
        Me.Bar3.DockSide = DevComponents.DotNetBar.eDockSide.Top
        Me.Bar3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Bar3.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003
        Me.Bar3.IsMaximized = False
        Me.Bar3.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Music_Volume, Me.L_SongName})
        Me.Bar3.Location = New System.Drawing.Point(0, 34)
        Me.Bar3.Name = "Bar3"
        Me.Bar3.Size = New System.Drawing.Size(359, 21)
        Me.Bar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar3.TabIndex = 1
        Me.Bar3.TabStop = False
        Me.Bar3.Text = "Bar3"
        '
        'Music_Volume
        '
        Me.Music_Volume.LabelWidth = 50
        Me.Music_Volume.Name = "Music_Volume"
        Me.Music_Volume.Text = "Volume"
        Me.Music_Volume.Value = 30
        Me.Music_Volume.Width = 200
        '
        'L_SongName
        '
        Me.L_SongName.ForeColor = System.Drawing.Color.White
        Me.L_SongName.Name = "L_SongName"
        Me.L_SongName.Text = "Title                      "
        '
        'DockSite3
        '
        Me.DockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite3.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite3.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite3.Location = New System.Drawing.Point(0, 55)
        Me.DockSite3.Name = "DockSite3"
        Me.DockSite3.Size = New System.Drawing.Size(398, 0)
        Me.DockSite3.TabIndex = 6
        Me.DockSite3.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
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
        Me.LabelItem2.Text = "Properties"
        '
        'Btn_Suffle
        '
        Me.Btn_Suffle.Name = "Btn_Suffle"
        Me.Btn_Suffle.Symbol = ""
        Me.Btn_Suffle.Text = "Shuffle"
        '
        'U_MusicPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DockSite9)
        Me.Controls.Add(Me.DockSite2)
        Me.Controls.Add(Me.DockSite1)
        Me.Controls.Add(Me.DockSite3)
        Me.Controls.Add(Me.DockSite4)
        Me.Controls.Add(Me.DockSite5)
        Me.Controls.Add(Me.DockSite6)
        Me.Controls.Add(Me.DockSite7)
        Me.Controls.Add(Me.DockSite8)
        Me.Name = "U_MusicPlayer"
        Me.Size = New System.Drawing.Size(398, 254)
        Me.DockSite9.ResumeLayout(False)
        CType(Me.Bar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bar2.ResumeLayout(False)
        Me.PanelDockContainer1.ResumeLayout(False)
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabControlPanel2.ResumeLayout(False)
        Me.PanelEx20.ResumeLayout(False)
        Me.PanelEx3.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx18.ResumeLayout(False)
        CType(Me.Bar6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bar5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDockContainer2.ResumeLayout(False)
        CType(Me.MP3PLayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockSite7.ResumeLayout(False)
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bar4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bar3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DotNetBarManager1 As DevComponents.DotNetBar.DotNetBarManager
    Friend WithEvents DockSite4 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite9 As DevComponents.DotNetBar.DockSite
    Friend WithEvents Bar2 As DevComponents.DotNetBar.Bar
    Friend WithEvents PanelDockContainer1 As DevComponents.DotNetBar.PanelDockContainer
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelDockContainer2 As DevComponents.DotNetBar.PanelDockContainer
    Friend WithEvents DockContainerItem1 As DevComponents.DotNetBar.DockContainerItem
    Friend WithEvents DockContainerItem2 As DevComponents.DotNetBar.DockContainerItem
    Friend WithEvents DockSite1 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite2 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite3 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite5 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite6 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite7 As DevComponents.DotNetBar.DockSite
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents DockSite8 As DevComponents.DotNetBar.DockSite
    Friend WithEvents Btn_AddAll As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Btn_Add As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PanelEx18 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Btn_Stop As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Btn_Play As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Btn_Remove As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PanelEx20 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents MP3PLayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Btn_PlayMusic As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Btn_PauseMusic As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Btn_StopMusic As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Btn_PreviousMusic As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Btn_NextMusic As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Btn_Mute As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Btn_DecreaseVolume As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Btn_IncreaseVolume As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents PbarVolume As DevComponents.DotNetBar.ProgressBarItem
    Friend WithEvents Bar3 As DevComponents.DotNetBar.Bar
    Friend WithEvents L_SongName As DevComponents.DotNetBar.LabelItem
    Friend WithEvents Music_Volume As DevComponents.DotNetBar.SliderItem
    Friend WithEvents Timer1 As Windows.Forms.Timer
    Friend WithEvents Bar4 As DevComponents.DotNetBar.Bar
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents LabelItem1 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents Btn_Small As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Btn_Normal As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LV_Dir As DevComponents.DotNetBar.ListBoxAdv
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents LV_Playlist As DevComponents.DotNetBar.ListBoxAdv
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents TabItem2 As DevComponents.DotNetBar.TabItem
    Friend WithEvents Bar6 As DevComponents.DotNetBar.Bar
    Friend WithEvents LabelItem3 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents Btn_Change_MusicFolder As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Txt_Music As DevComponents.DotNetBar.LabelItem
    Friend WithEvents Bar5 As DevComponents.DotNetBar.Bar
    Friend WithEvents LabelItem2 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents Btn_Suffle As DevComponents.DotNetBar.ButtonItem
End Class
