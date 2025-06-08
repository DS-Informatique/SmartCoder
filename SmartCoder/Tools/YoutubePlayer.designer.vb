<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class YoutubePlayer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(YoutubePlayer))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.DotNetBarManager1 = New DevComponents.DotNetBar.DotNetBarManager(Me.components)
        Me.DockSite4 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite9 = New DevComponents.DotNetBar.DockSite()
        Me.Bar3 = New DevComponents.DotNetBar.Bar()
        Me.PanelDockContainer1 = New DevComponents.DotNetBar.PanelDockContainer()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.VLC = New AxAXVLC.AxVLCPlugin2()
        Me.PanelDockContainer3 = New DevComponents.DotNetBar.PanelDockContainer()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.SuperTabControl1 = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SuperTabItem2 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.AdvPropertyGrid1 = New DevComponents.DotNetBar.AdvPropertyGrid()
        Me.SuperTabItem1 = New DevComponents.DotNetBar.SuperTabItem()
        Me.DockContainerItem1 = New DevComponents.DotNetBar.DockContainerItem()
        Me.DockContainerItem3 = New DevComponents.DotNetBar.DockContainerItem()
        Me.DockSite1 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite2 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite8 = New DevComponents.DotNetBar.DockSite()
        Me.Bar2 = New DevComponents.DotNetBar.Bar()
        Me.LabelItem1 = New DevComponents.DotNetBar.LabelItem()
        Me.ComboBoxItem1 = New DevComponents.DotNetBar.ComboBoxItem()
        Me.L_Percentage = New DevComponents.DotNetBar.LabelItem()
        Me.Btn_Download = New DevComponents.DotNetBar.ButtonItem()
        Me.L_DState = New DevComponents.DotNetBar.LabelItem()
        Me.ProgressBarItem1 = New DevComponents.DotNetBar.ProgressBarItem()
        Me.L_Time = New DevComponents.DotNetBar.LabelItem()
        Me.DockSite5 = New DevComponents.DotNetBar.DockSite()
        Me.Bar5 = New DevComponents.DotNetBar.Bar()
        Me.ButtonItem4 = New DevComponents.DotNetBar.ButtonItem()
        Me.Btn_Show = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem3 = New DevComponents.DotNetBar.ButtonItem()
        Me.DockSite6 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite7 = New DevComponents.DotNetBar.DockSite()
        Me.Bar1 = New DevComponents.DotNetBar.Bar()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.TextBoxItem1 = New DevComponents.DotNetBar.TextBoxItem()
        Me.Btn_Analyse = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem5 = New DevComponents.DotNetBar.ButtonItem()
        Me.DockSite3 = New DevComponents.DotNetBar.DockSite()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.DockSite9.SuspendLayout()
        CType(Me.Bar3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bar3.SuspendLayout()
        Me.PanelDockContainer1.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        CType(Me.VLC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDockContainer3.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControl1.SuspendLayout()
        Me.SuperTabControlPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControlPanel1.SuspendLayout()
        CType(Me.AdvPropertyGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockSite8.SuspendLayout()
        CType(Me.Bar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockSite5.SuspendLayout()
        CType(Me.Bar5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockSite7.SuspendLayout()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(36, 33)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(683, 317)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        Me.PanelEx1.Text = "PanelEx1"
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
        Me.DockSite4.Location = New System.Drawing.Point(36, 350)
        Me.DockSite4.Name = "DockSite4"
        Me.DockSite4.Size = New System.Drawing.Size(683, 0)
        Me.DockSite4.TabIndex = 7
        Me.DockSite4.TabStop = False
        '
        'DockSite9
        '
        Me.DockSite9.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite9.Controls.Add(Me.Bar3)
        Me.DockSite9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DockSite9.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer(New DevComponents.DotNetBar.DocumentBaseContainer() {CType(New DevComponents.DotNetBar.DocumentBarContainer(Me.Bar3, 683, 317), DevComponents.DotNetBar.DocumentBaseContainer)}, DevComponents.DotNetBar.eOrientation.Horizontal)
        Me.DockSite9.Location = New System.Drawing.Point(36, 33)
        Me.DockSite9.Name = "DockSite9"
        Me.DockSite9.Size = New System.Drawing.Size(683, 317)
        Me.DockSite9.TabIndex = 12
        Me.DockSite9.TabStop = False
        '
        'Bar3
        '
        Me.Bar3.AccessibleDescription = "DotNetBar Bar (Bar3)"
        Me.Bar3.AccessibleName = "DotNetBar Bar"
        Me.Bar3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.Bar3.AlwaysDisplayDockTab = True
        Me.Bar3.CanCustomize = False
        Me.Bar3.CanDockBottom = False
        Me.Bar3.CanDockDocument = True
        Me.Bar3.CanDockLeft = False
        Me.Bar3.CanDockRight = False
        Me.Bar3.CanDockTop = False
        Me.Bar3.CanHide = True
        Me.Bar3.CanUndock = False
        Me.Bar3.Controls.Add(Me.PanelDockContainer3)
        Me.Bar3.Controls.Add(Me.PanelDockContainer1)
        Me.Bar3.DockTabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top
        Me.Bar3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bar3.IsMaximized = False
        Me.Bar3.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.DockContainerItem1, Me.DockContainerItem3})
        Me.Bar3.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer
        Me.Bar3.Location = New System.Drawing.Point(0, 0)
        Me.Bar3.Name = "Bar3"
        Me.Bar3.SelectedDockTab = 1
        Me.Bar3.Size = New System.Drawing.Size(683, 317)
        Me.Bar3.Stretch = True
        Me.Bar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar3.TabIndex = 0
        Me.Bar3.TabNavigation = True
        Me.Bar3.TabStop = False
        '
        'PanelDockContainer1
        '
        Me.PanelDockContainer1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelDockContainer1.Controls.Add(Me.PanelEx2)
        Me.PanelDockContainer1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelDockContainer1.Location = New System.Drawing.Point(3, 28)
        Me.PanelDockContainer1.Name = "PanelDockContainer1"
        Me.PanelDockContainer1.Size = New System.Drawing.Size(677, 286)
        Me.PanelDockContainer1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelDockContainer1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelDockContainer1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.PanelDockContainer1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelDockContainer1.Style.GradientAngle = 90
        Me.PanelDockContainer1.TabIndex = 0
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.VLC)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx2.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(677, 286)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 8
        Me.PanelEx2.Text = " "
        '
        'VLC
        '
        Me.VLC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VLC.Enabled = True
        Me.VLC.Location = New System.Drawing.Point(0, 0)
        Me.VLC.Name = "VLC"
        Me.VLC.OcxState = CType(resources.GetObject("VLC.OcxState"), System.Windows.Forms.AxHost.State)
        Me.VLC.Size = New System.Drawing.Size(677, 286)
        Me.VLC.TabIndex = 0
        '
        'PanelDockContainer3
        '
        Me.PanelDockContainer3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelDockContainer3.Controls.Add(Me.PanelEx3)
        Me.PanelDockContainer3.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelDockContainer3.Location = New System.Drawing.Point(3, 28)
        Me.PanelDockContainer3.Name = "PanelDockContainer3"
        Me.PanelDockContainer3.Size = New System.Drawing.Size(677, 286)
        Me.PanelDockContainer3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelDockContainer3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelDockContainer3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.PanelDockContainer3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelDockContainer3.Style.GradientAngle = 90
        Me.PanelDockContainer3.TabIndex = 5
        '
        'PanelEx3
        '
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.Controls.Add(Me.SuperTabControl1)
        Me.PanelEx3.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx3.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(677, 286)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 12
        Me.PanelEx3.Text = " "
        '
        'SuperTabControl1
        '
        '
        '
        '
        '
        '
        '
        Me.SuperTabControl1.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.SuperTabControl1.ControlBox.MenuBox.Name = ""
        Me.SuperTabControl1.ControlBox.Name = ""
        Me.SuperTabControl1.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabControl1.ControlBox.MenuBox, Me.SuperTabControl1.ControlBox.CloseBox})
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel1)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel2)
        Me.SuperTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControl1.Name = "SuperTabControl1"
        Me.SuperTabControl1.ReorderTabsEnabled = True
        Me.SuperTabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SuperTabControl1.SelectedTabIndex = 0
        Me.SuperTabControl1.Size = New System.Drawing.Size(677, 286)
        Me.SuperTabControl1.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabControl1.TabIndex = 0
        Me.SuperTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabItem1, Me.SuperTabItem2})
        Me.SuperTabControl1.Text = "SuperTabControl1"
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.Controls.Add(Me.PictureBox1)
        Me.SuperTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel2.Location = New System.Drawing.Point(0, 25)
        Me.SuperTabControlPanel2.Name = "SuperTabControlPanel2"
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(677, 261)
        Me.SuperTabControlPanel2.TabIndex = 0
        Me.SuperTabControlPanel2.TabItem = Me.SuperTabItem2
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(677, 261)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'SuperTabItem2
        '
        Me.SuperTabItem2.AttachedControl = Me.SuperTabControlPanel2
        Me.SuperTabItem2.GlobalItem = False
        Me.SuperTabItem2.Name = "SuperTabItem2"
        Me.SuperTabItem2.Text = "SuperTabItem2"
        '
        'SuperTabControlPanel1
        '
        Me.SuperTabControlPanel1.Controls.Add(Me.AdvPropertyGrid1)
        Me.SuperTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel1.Location = New System.Drawing.Point(0, 25)
        Me.SuperTabControlPanel1.Name = "SuperTabControlPanel1"
        Me.SuperTabControlPanel1.Size = New System.Drawing.Size(677, 261)
        Me.SuperTabControlPanel1.TabIndex = 1
        Me.SuperTabControlPanel1.TabItem = Me.SuperTabItem1
        '
        'AdvPropertyGrid1
        '
        Me.AdvPropertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AdvPropertyGrid1.GridLinesColor = System.Drawing.Color.WhiteSmoke
        Me.AdvPropertyGrid1.Location = New System.Drawing.Point(0, 0)
        Me.AdvPropertyGrid1.Name = "AdvPropertyGrid1"
        Me.AdvPropertyGrid1.Size = New System.Drawing.Size(677, 261)
        Me.AdvPropertyGrid1.TabIndex = 0
        Me.AdvPropertyGrid1.Text = "AdvPropertyGrid1"
        '
        'SuperTabItem1
        '
        Me.SuperTabItem1.AttachedControl = Me.SuperTabControlPanel1
        Me.SuperTabItem1.GlobalItem = False
        Me.SuperTabItem1.Name = "SuperTabItem1"
        Me.SuperTabItem1.Text = "Property"
        '
        'DockContainerItem1
        '
        Me.DockContainerItem1.Control = Me.PanelDockContainer1
        Me.DockContainerItem1.Name = "DockContainerItem1"
        Me.DockContainerItem1.Text = "Player"
        '
        'DockContainerItem3
        '
        Me.DockContainerItem3.Control = Me.PanelDockContainer3
        Me.DockContainerItem3.Name = "DockContainerItem3"
        Me.DockContainerItem3.Text = "Current"
        '
        'DockSite1
        '
        Me.DockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite1.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite1.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite1.Location = New System.Drawing.Point(36, 33)
        Me.DockSite1.Name = "DockSite1"
        Me.DockSite1.Size = New System.Drawing.Size(0, 317)
        Me.DockSite1.TabIndex = 4
        Me.DockSite1.TabStop = False
        '
        'DockSite2
        '
        Me.DockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite2.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite2.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite2.Location = New System.Drawing.Point(719, 33)
        Me.DockSite2.Name = "DockSite2"
        Me.DockSite2.Size = New System.Drawing.Size(0, 317)
        Me.DockSite2.TabIndex = 5
        Me.DockSite2.TabStop = False
        '
        'DockSite8
        '
        Me.DockSite8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite8.Controls.Add(Me.Bar2)
        Me.DockSite8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DockSite8.Location = New System.Drawing.Point(0, 350)
        Me.DockSite8.Name = "DockSite8"
        Me.DockSite8.Size = New System.Drawing.Size(719, 31)
        Me.DockSite8.TabIndex = 11
        Me.DockSite8.TabStop = False
        '
        'Bar2
        '
        Me.Bar2.AccessibleDescription = "DotNetBar Bar (Bar2)"
        Me.Bar2.AccessibleName = "DotNetBar Bar"
        Me.Bar2.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.Bar2.DockSide = DevComponents.DotNetBar.eDockSide.Bottom
        Me.Bar2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Bar2.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003
        Me.Bar2.IsMaximized = False
        Me.Bar2.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.LabelItem1, Me.ComboBoxItem1, Me.L_Percentage, Me.Btn_Download, Me.L_DState, Me.ProgressBarItem1, Me.L_Time})
        Me.Bar2.Location = New System.Drawing.Point(0, 0)
        Me.Bar2.Name = "Bar2"
        Me.Bar2.Size = New System.Drawing.Size(473, 31)
        Me.Bar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar2.TabIndex = 1
        Me.Bar2.TabStop = False
        Me.Bar2.Text = "Bar2"
        '
        'LabelItem1
        '
        Me.LabelItem1.Name = "LabelItem1"
        Me.LabelItem1.Text = "Format"
        '
        'ComboBoxItem1
        '
        Me.ComboBoxItem1.ComboWidth = 250
        Me.ComboBoxItem1.DropDownHeight = 106
        Me.ComboBoxItem1.ItemHeight = 18
        Me.ComboBoxItem1.Name = "ComboBoxItem1"
        '
        'L_Percentage
        '
        Me.L_Percentage.Name = "L_Percentage"
        Me.L_Percentage.Text = "(0)%"
        '
        'Btn_Download
        '
        Me.Btn_Download.Name = "Btn_Download"
        Me.Btn_Download.Symbol = ""
        Me.Btn_Download.Text = "ButtonItem3"
        '
        'L_DState
        '
        Me.L_DState.Name = "L_DState"
        Me.L_DState.Text = " "
        '
        'ProgressBarItem1
        '
        '
        '
        '
        Me.ProgressBarItem1.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ProgressBarItem1.ChunkGradientAngle = 0!
        Me.ProgressBarItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.ProgressBarItem1.Name = "ProgressBarItem1"
        Me.ProgressBarItem1.RecentlyUsed = False
        '
        'L_Time
        '
        Me.L_Time.Name = "L_Time"
        Me.L_Time.Text = "0"
        '
        'DockSite5
        '
        Me.DockSite5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite5.Controls.Add(Me.Bar5)
        Me.DockSite5.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite5.Location = New System.Drawing.Point(0, 33)
        Me.DockSite5.Name = "DockSite5"
        Me.DockSite5.Size = New System.Drawing.Size(36, 317)
        Me.DockSite5.TabIndex = 8
        Me.DockSite5.TabStop = False
        '
        'Bar5
        '
        Me.Bar5.AccessibleDescription = "DotNetBar Bar (Bar5)"
        Me.Bar5.AccessibleName = "DotNetBar Bar"
        Me.Bar5.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.Bar5.DockOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.Bar5.DockSide = DevComponents.DotNetBar.eDockSide.Left
        Me.Bar5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Bar5.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003
        Me.Bar5.IsMaximized = False
        Me.Bar5.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem4, Me.Btn_Show, Me.ButtonItem2, Me.ButtonItem3})
        Me.Bar5.Location = New System.Drawing.Point(0, 0)
        Me.Bar5.Name = "Bar5"
        Me.Bar5.Size = New System.Drawing.Size(36, 126)
        Me.Bar5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar5.TabIndex = 2
        Me.Bar5.TabStop = False
        Me.Bar5.Text = "Bar5"
        '
        'ButtonItem4
        '
        Me.ButtonItem4.Name = "ButtonItem4"
        Me.ButtonItem4.Symbol = ""
        Me.ButtonItem4.Text = "ButtonItem4"
        '
        'Btn_Show
        '
        Me.Btn_Show.Name = "Btn_Show"
        Me.Btn_Show.Symbol = ""
        Me.Btn_Show.Text = " "
        '
        'ButtonItem2
        '
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.Symbol = "57399"
        Me.ButtonItem2.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.ButtonItem2.Tooltip = "Play"
        '
        'ButtonItem3
        '
        Me.ButtonItem3.Name = "ButtonItem3"
        Me.ButtonItem3.Symbol = "57396"
        Me.ButtonItem3.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.ButtonItem3.Tooltip = "Pause"
        '
        'DockSite6
        '
        Me.DockSite6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite6.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite6.Location = New System.Drawing.Point(719, 33)
        Me.DockSite6.Name = "DockSite6"
        Me.DockSite6.Size = New System.Drawing.Size(0, 317)
        Me.DockSite6.TabIndex = 9
        Me.DockSite6.TabStop = False
        '
        'DockSite7
        '
        Me.DockSite7.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite7.Controls.Add(Me.Bar1)
        Me.DockSite7.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite7.Location = New System.Drawing.Point(0, 0)
        Me.DockSite7.Name = "DockSite7"
        Me.DockSite7.Size = New System.Drawing.Size(719, 33)
        Me.DockSite7.TabIndex = 10
        Me.DockSite7.TabStop = False
        '
        'Bar1
        '
        Me.Bar1.AccessibleDescription = "DotNetBar Bar (Bar1)"
        Me.Bar1.AccessibleName = "DotNetBar Bar"
        Me.Bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.Bar1.DockSide = DevComponents.DotNetBar.eDockSide.Top
        Me.Bar1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Bar1.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003
        Me.Bar1.IsMaximized = False
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem1, Me.TextBoxItem1, Me.Btn_Analyse})
        Me.Bar1.Location = New System.Drawing.Point(0, 0)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Size = New System.Drawing.Size(389, 33)
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar1.TabIndex = 0
        Me.Bar1.TabStop = False
        Me.Bar1.Text = "Bar1"
        '
        'ButtonItem1
        '
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.Text = "Youtube Url : "
        '
        'TextBoxItem1
        '
        Me.TextBoxItem1.Name = "TextBoxItem1"
        Me.TextBoxItem1.TextBoxWidth = 255
        Me.TextBoxItem1.WatermarkColor = System.Drawing.SystemColors.GrayText
        '
        'Btn_Analyse
        '
        Me.Btn_Analyse.Name = "Btn_Analyse"
        Me.Btn_Analyse.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem5})
        Me.Btn_Analyse.Symbol = "57399"
        Me.Btn_Analyse.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.Btn_Analyse.Tooltip = "Play"
        '
        'ButtonItem5
        '
        Me.ButtonItem5.Name = "ButtonItem5"
        Me.ButtonItem5.Text = "VLC Play"
        '
        'DockSite3
        '
        Me.DockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite3.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite3.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite3.Location = New System.Drawing.Point(36, 33)
        Me.DockSite3.Name = "DockSite3"
        Me.DockSite3.Size = New System.Drawing.Size(683, 0)
        Me.DockSite3.TabIndex = 6
        Me.DockSite3.TabStop = False
        '
        'Timer1
        '
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'YoutubePlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DockSite9)
        Me.Controls.Add(Me.DockSite2)
        Me.Controls.Add(Me.DockSite1)
        Me.Controls.Add(Me.PanelEx1)
        Me.Controls.Add(Me.DockSite3)
        Me.Controls.Add(Me.DockSite4)
        Me.Controls.Add(Me.DockSite5)
        Me.Controls.Add(Me.DockSite6)
        Me.Controls.Add(Me.DockSite7)
        Me.Controls.Add(Me.DockSite8)
        Me.Name = "YoutubePlayer"
        Me.Size = New System.Drawing.Size(719, 381)
        Me.DockSite9.ResumeLayout(False)
        CType(Me.Bar3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bar3.ResumeLayout(False)
        Me.PanelDockContainer1.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        CType(Me.VLC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDockContainer3.ResumeLayout(False)
        Me.PanelEx3.ResumeLayout(False)
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControl1.ResumeLayout(False)
        Me.SuperTabControlPanel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControlPanel1.ResumeLayout(False)
        CType(Me.AdvPropertyGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockSite8.ResumeLayout(False)
        CType(Me.Bar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockSite5.ResumeLayout(False)
        CType(Me.Bar5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockSite7.ResumeLayout(False)
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents DotNetBarManager1 As DevComponents.DotNetBar.DotNetBarManager
    Friend WithEvents DockSite4 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite1 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite2 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite3 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite5 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite6 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite7 As DevComponents.DotNetBar.DockSite
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents TextBoxItem1 As DevComponents.DotNetBar.TextBoxItem
    Friend WithEvents Btn_Analyse As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Bar2 As DevComponents.DotNetBar.Bar
    Friend WithEvents LabelItem1 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents ComboBoxItem1 As DevComponents.DotNetBar.ComboBoxItem
    Friend WithEvents Btn_Download As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents L_Percentage As DevComponents.DotNetBar.LabelItem
    Friend WithEvents ProgressBarItem1 As DevComponents.DotNetBar.ProgressBarItem
    Friend WithEvents DockSite8 As DevComponents.DotNetBar.DockSite
    Friend WithEvents L_Time As DevComponents.DotNetBar.LabelItem
    Friend WithEvents Timer1 As Windows.Forms.Timer
    Friend WithEvents DockSite9 As DevComponents.DotNetBar.DockSite
    Friend WithEvents Bar3 As DevComponents.DotNetBar.Bar
    Friend WithEvents PanelDockContainer1 As DevComponents.DotNetBar.PanelDockContainer
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents DockContainerItem1 As DevComponents.DotNetBar.DockContainerItem
    Friend WithEvents Bar5 As DevComponents.DotNetBar.Bar
    Friend WithEvents ButtonItem4 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Btn_Show As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents PanelDockContainer3 As DevComponents.DotNetBar.PanelDockContainer
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents SuperTabControl1 As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents SuperTabControlPanel1 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents AdvPropertyGrid1 As DevComponents.DotNetBar.AdvPropertyGrid
    Friend WithEvents SuperTabItem1 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents DockContainerItem3 As DevComponents.DotNetBar.DockContainerItem
    Friend WithEvents ImageList1 As Windows.Forms.ImageList
    Friend WithEvents VLC As AxAXVLC.AxVLCPlugin2
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents L_DState As DevComponents.DotNetBar.LabelItem
    Friend WithEvents SuperTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
    Friend WithEvents SuperTabItem2 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents ButtonItem5 As DevComponents.DotNetBar.ButtonItem
End Class
