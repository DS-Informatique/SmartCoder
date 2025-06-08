<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashBoard
    Inherits DevComponents.DotNetBar.RibbonForm

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashBoard))
        Me.RibbonControl1 = New DevComponents.DotNetBar.RibbonControl()
        Me.RibbonPanel1 = New DevComponents.DotNetBar.RibbonPanel()
        Me.RibbonBar1 = New DevComponents.DotNetBar.RibbonBar()
        Me.RibbonPanel2 = New DevComponents.DotNetBar.RibbonPanel()
        Me.RibbonTabItem1 = New DevComponents.DotNetBar.RibbonTabItem()
        Me.RibbonTabItem2 = New DevComponents.DotNetBar.RibbonTabItem()
        Me.ApplicationButton1 = New DevComponents.DotNetBar.ApplicationButton()
        Me.ItemContainer1 = New DevComponents.DotNetBar.ItemContainer()
        Me.ItemContainer2 = New DevComponents.DotNetBar.ItemContainer()
        Me.ItemContainer3 = New DevComponents.DotNetBar.ItemContainer()
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem3 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem4 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem5 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem6 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem7 = New DevComponents.DotNetBar.ButtonItem()
        Me.GalleryContainer1 = New DevComponents.DotNetBar.GalleryContainer()
        Me.labelItem8 = New DevComponents.DotNetBar.LabelItem()
        Me.ButtonItem8 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem9 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem10 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem11 = New DevComponents.DotNetBar.ButtonItem()
        Me.ItemContainer4 = New DevComponents.DotNetBar.ItemContainer()
        Me.ButtonItem12 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem13 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.QatCustomizeItem1 = New DevComponents.DotNetBar.QatCustomizeItem()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.DotNetBarManager1 = New DevComponents.DotNetBar.DotNetBarManager(Me.components)
        Me.DockSite4 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite9 = New DevComponents.DotNetBar.DockSite()
        Me.Bar1 = New DevComponents.DotNetBar.Bar()
        Me.PanelDockContainer1 = New DevComponents.DotNetBar.PanelDockContainer()
        Me.Panel_Clients = New DevComponents.DotNetBar.PanelEx()
        Me.DockContainerItem1 = New DevComponents.DotNetBar.DockContainerItem()
        Me.DockSite1 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite2 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite8 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite5 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite6 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite7 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite3 = New DevComponents.DotNetBar.DockSite()
        Me.Clients1 = New Tempus.Clients()
        Me.RibbonControl1.SuspendLayout()
        Me.RibbonPanel1.SuspendLayout()
        Me.DockSite9.SuspendLayout()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bar1.SuspendLayout()
        Me.PanelDockContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonControl1
        '
        '
        '
        '
        Me.RibbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonControl1.CaptionVisible = True
        Me.RibbonControl1.Controls.Add(Me.RibbonPanel1)
        Me.RibbonControl1.Controls.Add(Me.RibbonPanel2)
        Me.RibbonControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RibbonControl1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.RibbonTabItem1, Me.RibbonTabItem2})
        Me.RibbonControl1.KeyTipsFont = New System.Drawing.Font("Tahoma", 7.0!)
        Me.RibbonControl1.Location = New System.Drawing.Point(5, 1)
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.RibbonControl1.QuickToolbarItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ApplicationButton1, Me.ButtonItem1, Me.QatCustomizeItem1})
        Me.RibbonControl1.Size = New System.Drawing.Size(843, 154)
        Me.RibbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon"
        Me.RibbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon"
        Me.RibbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar"
        Me.RibbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>"
        Me.RibbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar..."
        Me.RibbonControl1.SystemText.QatDialogAddButton = "&Add >>"
        Me.RibbonControl1.SystemText.QatDialogCancelButton = "Cancel"
        Me.RibbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar"
        Me.RibbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:"
        Me.RibbonControl1.SystemText.QatDialogOkButton = "OK"
        Me.RibbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon"
        Me.RibbonControl1.SystemText.QatDialogRemoveButton = "&Remove"
        Me.RibbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon"
        Me.RibbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon"
        Me.RibbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar"
        Me.RibbonControl1.TabGroupHeight = 14
        Me.RibbonControl1.TabIndex = 0
        Me.RibbonControl1.Text = "RibbonControl1"
        '
        'RibbonPanel1
        '
        Me.RibbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel1.Controls.Add(Me.RibbonBar1)
        Me.RibbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel1.Location = New System.Drawing.Point(0, 57)
        Me.RibbonPanel1.Name = "RibbonPanel1"
        Me.RibbonPanel1.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RibbonPanel1.Size = New System.Drawing.Size(843, 94)
        '
        '
        '
        Me.RibbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel1.TabIndex = 1
        '
        'RibbonBar1
        '
        Me.RibbonBar1.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar1.ContainerControlProcessDialogKey = True
        Me.RibbonBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar1.DragDropSupport = True
        Me.RibbonBar1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.RibbonBar1.Location = New System.Drawing.Point(3, 0)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Size = New System.Drawing.Size(100, 91)
        Me.RibbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar1.TabIndex = 0
        Me.RibbonBar1.Text = "RibbonBar1"
        '
        '
        '
        Me.RibbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'RibbonPanel2
        '
        Me.RibbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel2.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanel2.Name = "RibbonPanel2"
        Me.RibbonPanel2.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RibbonPanel2.Size = New System.Drawing.Size(8, 5)
        '
        '
        '
        Me.RibbonPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel2.TabIndex = 2
        '
        'RibbonTabItem1
        '
        Me.RibbonTabItem1.Checked = True
        Me.RibbonTabItem1.Name = "RibbonTabItem1"
        Me.RibbonTabItem1.Panel = Me.RibbonPanel1
        Me.RibbonTabItem1.Text = "RibbonTabItem1"
        '
        'RibbonTabItem2
        '
        Me.RibbonTabItem2.Name = "RibbonTabItem2"
        Me.RibbonTabItem2.Panel = Me.RibbonPanel2
        Me.RibbonTabItem2.Text = "RibbonTabItem2"
        '
        'ApplicationButton1
        '
        Me.ApplicationButton1.AutoExpandOnClick = True
        Me.ApplicationButton1.CanCustomize = False
        Me.ApplicationButton1.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image
        Me.ApplicationButton1.Image = CType(resources.GetObject("ApplicationButton1.Image"), System.Drawing.Image)
        Me.ApplicationButton1.ImagePaddingHorizontal = 2
        Me.ApplicationButton1.ImagePaddingVertical = 2
        Me.ApplicationButton1.Name = "ApplicationButton1"
        Me.ApplicationButton1.ShowSubItems = False
        Me.ApplicationButton1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer1})
        Me.ApplicationButton1.Text = "&File"
        '
        'ItemContainer1
        '
        '
        '
        '
        Me.ItemContainer1.BackgroundStyle.Class = "RibbonFileMenuContainer"
        Me.ItemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer1.Name = "ItemContainer1"
        Me.ItemContainer1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer2, Me.ItemContainer4})
        '
        '
        '
        Me.ItemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ItemContainer2
        '
        '
        '
        '
        Me.ItemContainer2.BackgroundStyle.Class = "RibbonFileMenuTwoColumnContainer"
        Me.ItemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer2.ItemSpacing = 0
        Me.ItemContainer2.Name = "ItemContainer2"
        Me.ItemContainer2.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer3, Me.GalleryContainer1})
        '
        '
        '
        Me.ItemContainer2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ItemContainer3
        '
        '
        '
        '
        Me.ItemContainer3.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer"
        Me.ItemContainer3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer3.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer3.MinimumSize = New System.Drawing.Size(120, 0)
        Me.ItemContainer3.Name = "ItemContainer3"
        Me.ItemContainer3.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem2, Me.ButtonItem3, Me.ButtonItem4, Me.ButtonItem5, Me.ButtonItem6, Me.ButtonItem7})
        '
        '
        '
        Me.ItemContainer3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonItem2
        '
        Me.ButtonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem2.Image = CType(resources.GetObject("ButtonItem2.Image"), System.Drawing.Image)
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.SubItemsExpandWidth = 24
        Me.ButtonItem2.Text = "&New"
        '
        'ButtonItem3
        '
        Me.ButtonItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem3.Image = CType(resources.GetObject("ButtonItem3.Image"), System.Drawing.Image)
        Me.ButtonItem3.Name = "ButtonItem3"
        Me.ButtonItem3.SubItemsExpandWidth = 24
        Me.ButtonItem3.Text = "&Open..."
        '
        'ButtonItem4
        '
        Me.ButtonItem4.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem4.Image = CType(resources.GetObject("ButtonItem4.Image"), System.Drawing.Image)
        Me.ButtonItem4.Name = "ButtonItem4"
        Me.ButtonItem4.SubItemsExpandWidth = 24
        Me.ButtonItem4.Text = "&Save..."
        '
        'ButtonItem5
        '
        Me.ButtonItem5.BeginGroup = True
        Me.ButtonItem5.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem5.Image = CType(resources.GetObject("ButtonItem5.Image"), System.Drawing.Image)
        Me.ButtonItem5.Name = "ButtonItem5"
        Me.ButtonItem5.SubItemsExpandWidth = 24
        Me.ButtonItem5.Text = "S&hare..."
        '
        'ButtonItem6
        '
        Me.ButtonItem6.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem6.Image = CType(resources.GetObject("ButtonItem6.Image"), System.Drawing.Image)
        Me.ButtonItem6.Name = "ButtonItem6"
        Me.ButtonItem6.SubItemsExpandWidth = 24
        Me.ButtonItem6.Text = "&Print..."
        '
        'ButtonItem7
        '
        Me.ButtonItem7.BeginGroup = True
        Me.ButtonItem7.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem7.Image = CType(resources.GetObject("ButtonItem7.Image"), System.Drawing.Image)
        Me.ButtonItem7.Name = "ButtonItem7"
        Me.ButtonItem7.SubItemsExpandWidth = 24
        Me.ButtonItem7.Text = "&Close"
        '
        'GalleryContainer1
        '
        '
        '
        '
        Me.GalleryContainer1.BackgroundStyle.Class = "RibbonFileMenuColumnTwoContainer"
        Me.GalleryContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GalleryContainer1.EnableGalleryPopup = False
        Me.GalleryContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.GalleryContainer1.MinimumSize = New System.Drawing.Size(180, 240)
        Me.GalleryContainer1.MultiLine = False
        Me.GalleryContainer1.Name = "GalleryContainer1"
        Me.GalleryContainer1.PopupUsesStandardScrollbars = False
        Me.GalleryContainer1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.labelItem8, Me.ButtonItem8, Me.ButtonItem9, Me.ButtonItem10, Me.ButtonItem11})
        '
        '
        '
        Me.GalleryContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'labelItem8
        '
        Me.labelItem8.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.labelItem8.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.labelItem8.CanCustomize = False
        Me.labelItem8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.labelItem8.Name = "labelItem8"
        Me.labelItem8.PaddingBottom = 2
        Me.labelItem8.PaddingTop = 2
        Me.labelItem8.Stretch = True
        Me.labelItem8.Text = "Recent Documents"
        '
        'ButtonItem8
        '
        Me.ButtonItem8.Name = "ButtonItem8"
        Me.ButtonItem8.Text = "&1. Short News 5-7.rtf"
        '
        'ButtonItem9
        '
        Me.ButtonItem9.Name = "ButtonItem9"
        Me.ButtonItem9.Text = "&2. Prospect Email.rtf"
        '
        'ButtonItem10
        '
        Me.ButtonItem10.Name = "ButtonItem10"
        Me.ButtonItem10.Text = "&3. Customer Email.rtf"
        '
        'ButtonItem11
        '
        Me.ButtonItem11.Name = "ButtonItem11"
        Me.ButtonItem11.Text = "&4. example.rtf"
        '
        'ItemContainer4
        '
        '
        '
        '
        Me.ItemContainer4.BackgroundStyle.Class = "RibbonFileMenuBottomContainer"
        Me.ItemContainer4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer4.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right
        Me.ItemContainer4.Name = "ItemContainer4"
        Me.ItemContainer4.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem12, Me.ButtonItem13})
        '
        '
        '
        Me.ItemContainer4.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonItem12
        '
        Me.ButtonItem12.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem12.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonItem12.Image = CType(resources.GetObject("ButtonItem12.Image"), System.Drawing.Image)
        Me.ButtonItem12.Name = "ButtonItem12"
        Me.ButtonItem12.SubItemsExpandWidth = 24
        Me.ButtonItem12.Text = "Opt&ions"
        '
        'ButtonItem13
        '
        Me.ButtonItem13.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem13.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonItem13.Image = CType(resources.GetObject("ButtonItem13.Image"), System.Drawing.Image)
        Me.ButtonItem13.Name = "ButtonItem13"
        Me.ButtonItem13.SubItemsExpandWidth = 24
        Me.ButtonItem13.Text = "E&xit"
        '
        'ButtonItem1
        '
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.Text = "Reset"
        '
        'QatCustomizeItem1
        '
        Me.QatCustomizeItem1.Name = "QatCustomizeItem1"
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(154, Byte), Integer)))
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
        Me.DotNetBarManager1.ParentForm = Me
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
        Me.DockSite4.Location = New System.Drawing.Point(5, 470)
        Me.DockSite4.Name = "DockSite4"
        Me.DockSite4.Size = New System.Drawing.Size(843, 0)
        Me.DockSite4.TabIndex = 4
        Me.DockSite4.TabStop = False
        '
        'DockSite9
        '
        Me.DockSite9.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite9.Controls.Add(Me.Bar1)
        Me.DockSite9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DockSite9.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer(New DevComponents.DotNetBar.DocumentBaseContainer() {CType(New DevComponents.DotNetBar.DocumentBarContainer(Me.Bar1, 843, 315), DevComponents.DotNetBar.DocumentBaseContainer)}, DevComponents.DotNetBar.eOrientation.Horizontal)
        Me.DockSite9.Location = New System.Drawing.Point(5, 155)
        Me.DockSite9.Name = "DockSite9"
        Me.DockSite9.Size = New System.Drawing.Size(843, 315)
        Me.DockSite9.TabIndex = 9
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
        Me.Bar1.Controls.Add(Me.PanelDockContainer1)
        Me.Bar1.DockTabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top
        Me.Bar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bar1.IsMaximized = False
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.DockContainerItem1})
        Me.Bar1.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer
        Me.Bar1.Location = New System.Drawing.Point(0, 0)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.SelectedDockTab = 0
        Me.Bar1.Size = New System.Drawing.Size(843, 315)
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar1.TabIndex = 0
        Me.Bar1.TabNavigation = True
        Me.Bar1.TabStop = False
        '
        'PanelDockContainer1
        '
        Me.PanelDockContainer1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelDockContainer1.Controls.Add(Me.Panel_Clients)
        Me.PanelDockContainer1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelDockContainer1.Location = New System.Drawing.Point(3, 28)
        Me.PanelDockContainer1.Name = "PanelDockContainer1"
        Me.PanelDockContainer1.Size = New System.Drawing.Size(837, 284)
        Me.PanelDockContainer1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelDockContainer1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelDockContainer1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.PanelDockContainer1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelDockContainer1.Style.GradientAngle = 90
        Me.PanelDockContainer1.TabIndex = 0
        '
        'Panel_Clients
        '
        Me.Panel_Clients.CanvasColor = System.Drawing.SystemColors.Control
        Me.Panel_Clients.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Panel_Clients.DisabledBackColor = System.Drawing.Color.Empty
        Me.Panel_Clients.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Clients.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Clients.Name = "Panel_Clients"
        Me.Panel_Clients.Size = New System.Drawing.Size(837, 284)
        Me.Panel_Clients.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Panel_Clients.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Panel_Clients.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Panel_Clients.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Panel_Clients.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Panel_Clients.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Panel_Clients.Style.GradientAngle = 90
        Me.Panel_Clients.TabIndex = 0
        Me.Panel_Clients.Text = "Panel_Clients"
        '
        'DockContainerItem1
        '
        Me.DockContainerItem1.Control = Me.PanelDockContainer1
        Me.DockContainerItem1.Name = "DockContainerItem1"
        Me.DockContainerItem1.Text = "Clients"
        '
        'DockSite1
        '
        Me.DockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite1.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite1.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite1.Location = New System.Drawing.Point(5, 155)
        Me.DockSite1.Name = "DockSite1"
        Me.DockSite1.Size = New System.Drawing.Size(0, 315)
        Me.DockSite1.TabIndex = 1
        Me.DockSite1.TabStop = False
        '
        'DockSite2
        '
        Me.DockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite2.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite2.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite2.Location = New System.Drawing.Point(848, 155)
        Me.DockSite2.Name = "DockSite2"
        Me.DockSite2.Size = New System.Drawing.Size(0, 315)
        Me.DockSite2.TabIndex = 2
        Me.DockSite2.TabStop = False
        '
        'DockSite8
        '
        Me.DockSite8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DockSite8.Location = New System.Drawing.Point(5, 470)
        Me.DockSite8.Name = "DockSite8"
        Me.DockSite8.Size = New System.Drawing.Size(843, 0)
        Me.DockSite8.TabIndex = 8
        Me.DockSite8.TabStop = False
        '
        'DockSite5
        '
        Me.DockSite5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite5.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite5.Location = New System.Drawing.Point(5, 1)
        Me.DockSite5.Name = "DockSite5"
        Me.DockSite5.Size = New System.Drawing.Size(0, 469)
        Me.DockSite5.TabIndex = 5
        Me.DockSite5.TabStop = False
        '
        'DockSite6
        '
        Me.DockSite6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite6.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite6.Location = New System.Drawing.Point(848, 1)
        Me.DockSite6.Name = "DockSite6"
        Me.DockSite6.Size = New System.Drawing.Size(0, 469)
        Me.DockSite6.TabIndex = 6
        Me.DockSite6.TabStop = False
        '
        'DockSite7
        '
        Me.DockSite7.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite7.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite7.Location = New System.Drawing.Point(5, 1)
        Me.DockSite7.Name = "DockSite7"
        Me.DockSite7.Size = New System.Drawing.Size(843, 0)
        Me.DockSite7.TabIndex = 7
        Me.DockSite7.TabStop = False
        '
        'DockSite3
        '
        Me.DockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite3.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite3.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite3.Location = New System.Drawing.Point(5, 1)
        Me.DockSite3.Name = "DockSite3"
        Me.DockSite3.Size = New System.Drawing.Size(843, 0)
        Me.DockSite3.TabIndex = 3
        Me.DockSite3.TabStop = False
        '
        'Clients1
        '
        Me.Clients1.Current = Nothing
        Me.Clients1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clients1.Location = New System.Drawing.Point(0, 0)
        Me.Clients1.Margin = New System.Windows.Forms.Padding(4)
        Me.Clients1.Name = "Clients1"
        Me.Clients1.Size = New System.Drawing.Size(884, 536)
        Me.Clients1.TabIndex = 0
        '
        'DashBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 472)
        Me.Controls.Add(Me.DockSite9)
        Me.Controls.Add(Me.DockSite2)
        Me.Controls.Add(Me.DockSite1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(Me.DockSite3)
        Me.Controls.Add(Me.DockSite4)
        Me.Controls.Add(Me.DockSite5)
        Me.Controls.Add(Me.DockSite6)
        Me.Controls.Add(Me.DockSite7)
        Me.Controls.Add(Me.DockSite8)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "DashBoard"
        Me.Text = "DashBoard"
        Me.RibbonControl1.ResumeLayout(False)
        Me.RibbonControl1.PerformLayout()
        Me.RibbonPanel1.ResumeLayout(False)
        Me.DockSite9.ResumeLayout(False)
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bar1.ResumeLayout(False)
        Me.PanelDockContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RibbonControl1 As DevComponents.DotNetBar.RibbonControl
    Friend WithEvents RibbonPanel1 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents RibbonBar1 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents RibbonPanel2 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents ApplicationButton1 As DevComponents.DotNetBar.ApplicationButton
    Friend WithEvents ItemContainer1 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ItemContainer2 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ItemContainer3 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem4 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem5 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem6 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem7 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents GalleryContainer1 As DevComponents.DotNetBar.GalleryContainer
    Friend WithEvents labelItem8 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents ButtonItem8 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem9 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem10 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem11 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ItemContainer4 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ButtonItem12 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem13 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonTabItem1 As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents RibbonTabItem2 As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents QatCustomizeItem1 As DevComponents.DotNetBar.QatCustomizeItem
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents DotNetBarManager1 As DevComponents.DotNetBar.DotNetBarManager
    Friend WithEvents DockSite4 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite9 As DevComponents.DotNetBar.DockSite
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents PanelDockContainer1 As DevComponents.DotNetBar.PanelDockContainer
    Friend WithEvents Panel_Clients As DevComponents.DotNetBar.PanelEx
    Friend WithEvents DockContainerItem1 As DevComponents.DotNetBar.DockContainerItem
    Friend WithEvents DockSite1 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite2 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite3 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite5 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite6 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite7 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite8 As DevComponents.DotNetBar.DockSite
    Friend WithEvents Clients1 As Clients
End Class
