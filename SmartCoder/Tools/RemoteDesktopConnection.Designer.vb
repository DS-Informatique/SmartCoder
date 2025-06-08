<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RemoteDesktopConnection
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RemoteDesktopConnection))
        Me.DotNetBarManager1 = New DevComponents.DotNetBar.DotNetBarManager(Me.components)
        Me.DockSite4 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite9 = New DevComponents.DotNetBar.DockSite()
        Me.Bar1 = New DevComponents.DotNetBar.Bar()
        Me.PanelDockContainer2 = New DevComponents.DotNetBar.PanelDockContainer()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.RDV = New AxMSTSCLib.AxMsRdpClient7NotSafeForScripting()
        Me.DockContainerItem2 = New DevComponents.DotNetBar.DockContainerItem()
        Me.DockSite1 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite2 = New DevComponents.DotNetBar.DockSite()
        Me.Bar5 = New DevComponents.DotNetBar.Bar()
        Me.PanelDockContainer1 = New DevComponents.DotNetBar.PanelDockContainer()
        Me.AdvPropertyGrid1 = New DevComponents.DotNetBar.AdvPropertyGrid()
        Me.DockContainerItem1 = New DevComponents.DotNetBar.DockContainerItem()
        Me.Bar6 = New DevComponents.DotNetBar.Bar()
        Me.PanelDockContainer3 = New DevComponents.DotNetBar.PanelDockContainer()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.Input_Station = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Input_Password = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.Input_UserName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.DockContainerItem3 = New DevComponents.DotNetBar.DockContainerItem()
        Me.DockSite8 = New DevComponents.DotNetBar.DockSite()
        Me.Bar3 = New DevComponents.DotNetBar.Bar()
        Me.LabelItem1 = New DevComponents.DotNetBar.LabelItem()
        Me.SwitchButtonItem1 = New DevComponents.DotNetBar.SwitchButtonItem()
        Me.DockSite5 = New DevComponents.DotNetBar.DockSite()
        Me.Bar4 = New DevComponents.DotNetBar.Bar()
        Me.Btn_Connect = New DevComponents.DotNetBar.ButtonItem()
        Me.Btn_Disconnect = New DevComponents.DotNetBar.ButtonItem()
        Me.DockSite6 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite7 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite3 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite9.SuspendLayout()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bar1.SuspendLayout()
        Me.PanelDockContainer2.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        CType(Me.RDV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockSite2.SuspendLayout()
        CType(Me.Bar5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bar5.SuspendLayout()
        Me.PanelDockContainer1.SuspendLayout()
        CType(Me.AdvPropertyGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bar6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bar6.SuspendLayout()
        Me.PanelDockContainer3.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        Me.DockSite8.SuspendLayout()
        CType(Me.Bar3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockSite5.SuspendLayout()
        CType(Me.Bar4, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DockSite4.Location = New System.Drawing.Point(36, 623)
        Me.DockSite4.Name = "DockSite4"
        Me.DockSite4.Size = New System.Drawing.Size(991, 0)
        Me.DockSite4.TabIndex = 3
        Me.DockSite4.TabStop = False
        '
        'DockSite9
        '
        Me.DockSite9.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite9.Controls.Add(Me.Bar1)
        Me.DockSite9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DockSite9.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer(New DevComponents.DotNetBar.DocumentBaseContainer() {CType(New DevComponents.DotNetBar.DocumentBarContainer(Me.Bar1, 712, 623), DevComponents.DotNetBar.DocumentBaseContainer)}, DevComponents.DotNetBar.eOrientation.Vertical)
        Me.DockSite9.Location = New System.Drawing.Point(36, 0)
        Me.DockSite9.Name = "DockSite9"
        Me.DockSite9.Size = New System.Drawing.Size(712, 623)
        Me.DockSite9.TabIndex = 8
        Me.DockSite9.TabStop = False
        '
        'Bar1
        '
        Me.Bar1.AccessibleDescription = "DotNetBar Bar (Bar1)"
        Me.Bar1.AccessibleName = "DotNetBar Bar"
        Me.Bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.Bar1.AlwaysDisplayDockTab = True
        Me.Bar1.CanCustomize = False
        Me.Bar1.CanDockBottom = False
        Me.Bar1.CanDockDocument = True
        Me.Bar1.CanDockLeft = False
        Me.Bar1.CanDockRight = False
        Me.Bar1.CanDockTop = False
        Me.Bar1.CanHide = True
        Me.Bar1.CanUndock = False
        Me.Bar1.Controls.Add(Me.PanelDockContainer2)
        Me.Bar1.DockTabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top
        Me.Bar1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bar1.IsMaximized = False
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.DockContainerItem2})
        Me.Bar1.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer
        Me.Bar1.Location = New System.Drawing.Point(0, 0)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.SelectedDockTab = 0
        Me.Bar1.Size = New System.Drawing.Size(712, 623)
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar1.TabIndex = 0
        Me.Bar1.TabNavigation = True
        Me.Bar1.TabStop = False
        '
        'PanelDockContainer2
        '
        Me.PanelDockContainer2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelDockContainer2.Controls.Add(Me.PanelEx2)
        Me.PanelDockContainer2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelDockContainer2.Location = New System.Drawing.Point(3, 28)
        Me.PanelDockContainer2.Name = "PanelDockContainer2"
        Me.PanelDockContainer2.Size = New System.Drawing.Size(706, 592)
        Me.PanelDockContainer2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelDockContainer2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelDockContainer2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.PanelDockContainer2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelDockContainer2.Style.GradientAngle = 90
        Me.PanelDockContainer2.TabIndex = 5
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.RDV)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx2.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(706, 592)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 0
        Me.PanelEx2.Text = " "
        '
        'RDV
        '
        Me.RDV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RDV.Enabled = True
        Me.RDV.Location = New System.Drawing.Point(0, 0)
        Me.RDV.Name = "RDV"
        Me.RDV.OcxState = CType(resources.GetObject("RDV.OcxState"), System.Windows.Forms.AxHost.State)
        Me.RDV.Size = New System.Drawing.Size(706, 592)
        Me.RDV.TabIndex = 0
        '
        'DockContainerItem2
        '
        Me.DockContainerItem2.Control = Me.PanelDockContainer2
        Me.DockContainerItem2.Name = "DockContainerItem2"
        Me.DockContainerItem2.Text = "Visualiseur"
        '
        'DockSite1
        '
        Me.DockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite1.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite1.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite1.Location = New System.Drawing.Point(36, 0)
        Me.DockSite1.Name = "DockSite1"
        Me.DockSite1.Size = New System.Drawing.Size(0, 623)
        Me.DockSite1.TabIndex = 0
        Me.DockSite1.TabStop = False
        '
        'DockSite2
        '
        Me.DockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite2.Controls.Add(Me.Bar5)
        Me.DockSite2.Controls.Add(Me.Bar6)
        Me.DockSite2.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite2.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer(New DevComponents.DotNetBar.DocumentBaseContainer() {CType(New DevComponents.DotNetBar.DocumentBarContainer(Me.Bar6, 276, 301), DevComponents.DotNetBar.DocumentBaseContainer), CType(New DevComponents.DotNetBar.DocumentBarContainer(Me.Bar5, 276, 319), DevComponents.DotNetBar.DocumentBaseContainer)}, DevComponents.DotNetBar.eOrientation.Vertical)
        Me.DockSite2.Location = New System.Drawing.Point(748, 0)
        Me.DockSite2.Name = "DockSite2"
        Me.DockSite2.Size = New System.Drawing.Size(279, 623)
        Me.DockSite2.TabIndex = 1
        Me.DockSite2.TabStop = False
        '
        'Bar5
        '
        Me.Bar5.AccessibleDescription = "DotNetBar Bar (Bar5)"
        Me.Bar5.AccessibleName = "DotNetBar Bar"
        Me.Bar5.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.Bar5.AutoSyncBarCaption = True
        Me.Bar5.CloseSingleTab = True
        Me.Bar5.Controls.Add(Me.PanelDockContainer1)
        Me.Bar5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bar5.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Caption
        Me.Bar5.IsMaximized = False
        Me.Bar5.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.DockContainerItem1})
        Me.Bar5.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer
        Me.Bar5.Location = New System.Drawing.Point(3, 304)
        Me.Bar5.Name = "Bar5"
        Me.Bar5.Size = New System.Drawing.Size(276, 319)
        Me.Bar5.Stretch = True
        Me.Bar5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar5.TabIndex = 0
        Me.Bar5.TabStop = False
        Me.Bar5.Text = "DockContainerItem1"
        '
        'PanelDockContainer1
        '
        Me.PanelDockContainer1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelDockContainer1.Controls.Add(Me.AdvPropertyGrid1)
        Me.PanelDockContainer1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelDockContainer1.Location = New System.Drawing.Point(3, 24)
        Me.PanelDockContainer1.Name = "PanelDockContainer1"
        Me.PanelDockContainer1.Size = New System.Drawing.Size(270, 292)
        Me.PanelDockContainer1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelDockContainer1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelDockContainer1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.PanelDockContainer1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelDockContainer1.Style.GradientAngle = 90
        Me.PanelDockContainer1.TabIndex = 5
        '
        'AdvPropertyGrid1
        '
        Me.AdvPropertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AdvPropertyGrid1.GridLinesColor = System.Drawing.Color.WhiteSmoke
        Me.AdvPropertyGrid1.Location = New System.Drawing.Point(0, 0)
        Me.AdvPropertyGrid1.Name = "AdvPropertyGrid1"
        Me.AdvPropertyGrid1.Size = New System.Drawing.Size(270, 292)
        Me.AdvPropertyGrid1.TabIndex = 0
        Me.AdvPropertyGrid1.Text = "AdvPropertyGrid1"
        '
        'DockContainerItem1
        '
        Me.DockContainerItem1.Control = Me.PanelDockContainer1
        Me.DockContainerItem1.Name = "DockContainerItem1"
        Me.DockContainerItem1.Text = "DockContainerItem1"
        '
        'Bar6
        '
        Me.Bar6.AccessibleDescription = "DotNetBar Bar (Bar6)"
        Me.Bar6.AccessibleName = "DotNetBar Bar"
        Me.Bar6.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.Bar6.AutoSyncBarCaption = True
        Me.Bar6.CloseSingleTab = True
        Me.Bar6.Controls.Add(Me.PanelDockContainer3)
        Me.Bar6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bar6.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Caption
        Me.Bar6.IsMaximized = False
        Me.Bar6.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.DockContainerItem3})
        Me.Bar6.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer
        Me.Bar6.Location = New System.Drawing.Point(3, 0)
        Me.Bar6.Name = "Bar6"
        Me.Bar6.Size = New System.Drawing.Size(276, 301)
        Me.Bar6.Stretch = True
        Me.Bar6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar6.TabIndex = 1
        Me.Bar6.TabStop = False
        Me.Bar6.Text = "DockContainerItem3"
        '
        'PanelDockContainer3
        '
        Me.PanelDockContainer3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelDockContainer3.Controls.Add(Me.PanelEx1)
        Me.PanelDockContainer3.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelDockContainer3.Location = New System.Drawing.Point(3, 24)
        Me.PanelDockContainer3.Name = "PanelDockContainer3"
        Me.PanelDockContainer3.Size = New System.Drawing.Size(270, 274)
        Me.PanelDockContainer3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelDockContainer3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelDockContainer3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.PanelDockContainer3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelDockContainer3.Style.GradientAngle = 90
        Me.PanelDockContainer3.TabIndex = 0
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.Input_Station)
        Me.PanelEx1.Controls.Add(Me.Input_Password)
        Me.PanelEx1.Controls.Add(Me.LabelX3)
        Me.PanelEx1.Controls.Add(Me.Input_UserName)
        Me.PanelEx1.Controls.Add(Me.LabelX2)
        Me.PanelEx1.Controls.Add(Me.LabelX1)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(270, 274)
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
        'Input_Station
        '
        Me.Input_Station.DisplayMember = "Text"
        Me.Input_Station.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Input_Station.FormattingEnabled = True
        Me.Input_Station.ItemHeight = 21
        Me.Input_Station.Location = New System.Drawing.Point(13, 30)
        Me.Input_Station.Name = "Input_Station"
        Me.Input_Station.Size = New System.Drawing.Size(188, 27)
        Me.Input_Station.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Input_Station.TabIndex = 14
        '
        'Input_Password
        '
        '
        '
        '
        Me.Input_Password.Border.Class = "TextBoxBorder"
        Me.Input_Password.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_Password.Location = New System.Drawing.Point(13, 159)
        Me.Input_Password.Name = "Input_Password"
        Me.Input_Password.PreventEnterBeep = True
        Me.Input_Password.Size = New System.Drawing.Size(188, 26)
        Me.Input_Password.TabIndex = 13
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(13, 128)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(188, 23)
        Me.LabelX3.TabIndex = 12
        Me.LabelX3.Text = "Password"
        '
        'Input_UserName
        '
        '
        '
        '
        Me.Input_UserName.Border.Class = "TextBoxBorder"
        Me.Input_UserName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_UserName.Location = New System.Drawing.Point(13, 99)
        Me.Input_UserName.Name = "Input_UserName"
        Me.Input_UserName.PreventEnterBeep = True
        Me.Input_UserName.Size = New System.Drawing.Size(188, 26)
        Me.Input_UserName.TabIndex = 11
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(13, 68)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(188, 23)
        Me.LabelX2.TabIndex = 10
        Me.LabelX2.Text = "UserName"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(13, 1)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(188, 23)
        Me.LabelX1.TabIndex = 9
        Me.LabelX1.Text = "PC or Server"
        '
        'DockContainerItem3
        '
        Me.DockContainerItem3.Control = Me.PanelDockContainer3
        Me.DockContainerItem3.Name = "DockContainerItem3"
        Me.DockContainerItem3.Text = "DockContainerItem3"
        '
        'DockSite8
        '
        Me.DockSite8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite8.Controls.Add(Me.Bar3)
        Me.DockSite8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DockSite8.Location = New System.Drawing.Point(0, 623)
        Me.DockSite8.Name = "DockSite8"
        Me.DockSite8.Size = New System.Drawing.Size(1027, 25)
        Me.DockSite8.TabIndex = 7
        Me.DockSite8.TabStop = False
        '
        'Bar3
        '
        Me.Bar3.AccessibleDescription = "DotNetBar Bar (Bar3)"
        Me.Bar3.AccessibleName = "DotNetBar Bar"
        Me.Bar3.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.Bar3.DockSide = DevComponents.DotNetBar.eDockSide.Bottom
        Me.Bar3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Bar3.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003
        Me.Bar3.IsMaximized = False
        Me.Bar3.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.LabelItem1, Me.SwitchButtonItem1})
        Me.Bar3.Location = New System.Drawing.Point(0, 0)
        Me.Bar3.Name = "Bar3"
        Me.Bar3.Size = New System.Drawing.Size(174, 25)
        Me.Bar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar3.TabIndex = 1
        Me.Bar3.TabStop = False
        Me.Bar3.Text = "Bar3"
        '
        'LabelItem1
        '
        Me.LabelItem1.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far
        Me.LabelItem1.Name = "LabelItem1"
        Me.LabelItem1.Text = "Connection Status"
        '
        'SwitchButtonItem1
        '
        Me.SwitchButtonItem1.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far
        Me.SwitchButtonItem1.Name = "SwitchButtonItem1"
        Me.SwitchButtonItem1.OffText = "Ofline"
        Me.SwitchButtonItem1.OnText = "Online"
        '
        'DockSite5
        '
        Me.DockSite5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite5.Controls.Add(Me.Bar4)
        Me.DockSite5.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite5.Location = New System.Drawing.Point(0, 0)
        Me.DockSite5.Name = "DockSite5"
        Me.DockSite5.Size = New System.Drawing.Size(36, 623)
        Me.DockSite5.TabIndex = 4
        Me.DockSite5.TabStop = False
        '
        'Bar4
        '
        Me.Bar4.AccessibleDescription = "DotNetBar Bar (Bar4)"
        Me.Bar4.AccessibleName = "DotNetBar Bar"
        Me.Bar4.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.Bar4.DockOffset = 28
        Me.Bar4.DockOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.Bar4.DockSide = DevComponents.DotNetBar.eDockSide.Left
        Me.Bar4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Bar4.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003
        Me.Bar4.IsMaximized = False
        Me.Bar4.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Btn_Connect, Me.Btn_Disconnect})
        Me.Bar4.Location = New System.Drawing.Point(0, 28)
        Me.Bar4.Name = "Bar4"
        Me.Bar4.Size = New System.Drawing.Size(36, 70)
        Me.Bar4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar4.TabIndex = 2
        Me.Bar4.TabStop = False
        Me.Bar4.Text = "Bar4"
        '
        'Btn_Connect
        '
        Me.Btn_Connect.Image = Global.SmartCoder.My.Resources.Resources.Play_24x24
        Me.Btn_Connect.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Btn_Connect.Name = "Btn_Connect"
        Me.Btn_Connect.Text = "Connect"
        '
        'Btn_Disconnect
        '
        Me.Btn_Disconnect.Image = Global.SmartCoder.My.Resources.Resources.Remove_24x24
        Me.Btn_Disconnect.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Btn_Disconnect.Name = "Btn_Disconnect"
        Me.Btn_Disconnect.Text = "Disconnect"
        '
        'DockSite6
        '
        Me.DockSite6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite6.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite6.Location = New System.Drawing.Point(1027, 0)
        Me.DockSite6.Name = "DockSite6"
        Me.DockSite6.Size = New System.Drawing.Size(0, 623)
        Me.DockSite6.TabIndex = 5
        Me.DockSite6.TabStop = False
        '
        'DockSite7
        '
        Me.DockSite7.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite7.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite7.Location = New System.Drawing.Point(0, 0)
        Me.DockSite7.Name = "DockSite7"
        Me.DockSite7.Size = New System.Drawing.Size(1027, 0)
        Me.DockSite7.TabIndex = 6
        Me.DockSite7.TabStop = False
        '
        'DockSite3
        '
        Me.DockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite3.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite3.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite3.Location = New System.Drawing.Point(36, 0)
        Me.DockSite3.Name = "DockSite3"
        Me.DockSite3.Size = New System.Drawing.Size(991, 0)
        Me.DockSite3.TabIndex = 2
        Me.DockSite3.TabStop = False
        '
        'RemoteDesktopConnection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
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
        Me.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "RemoteDesktopConnection"
        Me.Size = New System.Drawing.Size(1027, 648)
        Me.DockSite9.ResumeLayout(False)
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bar1.ResumeLayout(False)
        Me.PanelDockContainer2.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        CType(Me.RDV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockSite2.ResumeLayout(False)
        CType(Me.Bar5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bar5.ResumeLayout(False)
        Me.PanelDockContainer1.ResumeLayout(False)
        CType(Me.AdvPropertyGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bar6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bar6.ResumeLayout(False)
        Me.PanelDockContainer3.ResumeLayout(False)
        Me.PanelEx1.ResumeLayout(False)
        Me.DockSite8.ResumeLayout(False)
        CType(Me.Bar3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockSite5.ResumeLayout(False)
        CType(Me.Bar4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DotNetBarManager1 As DevComponents.DotNetBar.DotNetBarManager
    Friend WithEvents DockSite4 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite9 As DevComponents.DotNetBar.DockSite
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents PanelDockContainer2 As DevComponents.DotNetBar.PanelDockContainer
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents RDV As AxMSTSCLib.AxMsRdpClient7NotSafeForScripting
    Friend WithEvents DockContainerItem2 As DevComponents.DotNetBar.DockContainerItem
    Friend WithEvents DockSite1 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite2 As DevComponents.DotNetBar.DockSite
    Friend WithEvents Bar5 As DevComponents.DotNetBar.Bar
    Friend WithEvents PanelDockContainer1 As DevComponents.DotNetBar.PanelDockContainer
    Friend WithEvents AdvPropertyGrid1 As DevComponents.DotNetBar.AdvPropertyGrid
    Friend WithEvents DockContainerItem1 As DevComponents.DotNetBar.DockContainerItem
    Friend WithEvents Bar6 As DevComponents.DotNetBar.Bar
    Friend WithEvents PanelDockContainer3 As DevComponents.DotNetBar.PanelDockContainer
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Public WithEvents Input_Station As DevComponents.DotNetBar.Controls.ComboBoxEx
    Public WithEvents Input_Password As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Public WithEvents Input_UserName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DockContainerItem3 As DevComponents.DotNetBar.DockContainerItem
    Friend WithEvents DockSite3 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite5 As DevComponents.DotNetBar.DockSite
    Friend WithEvents Bar4 As DevComponents.DotNetBar.Bar
    Friend WithEvents Btn_Connect As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Btn_Disconnect As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents DockSite6 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite7 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite8 As DevComponents.DotNetBar.DockSite
    Friend WithEvents Bar3 As DevComponents.DotNetBar.Bar
    Friend WithEvents LabelItem1 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents SwitchButtonItem1 As DevComponents.DotNetBar.SwitchButtonItem
End Class
