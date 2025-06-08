<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TreeExplorer
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
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.Input_Dir = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.Btn_Refresh = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.DotNetBarManager1 = New DevComponents.DotNetBar.DotNetBarManager(Me.components)
        Me.DockSite4 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite9 = New DevComponents.DotNetBar.DockSite()
        Me.Bar1 = New DevComponents.DotNetBar.Bar()
        Me.PanelDockContainer2 = New DevComponents.DotNetBar.PanelDockContainer()
        Me.PanelEx4 = New DevComponents.DotNetBar.PanelEx()
        Me.LV = New DevComponents.DotNetBar.Controls.ListViewEx()
        Me.IL_LV_Large = New System.Windows.Forms.ImageList(Me.components)
        Me.IL_LV_Small = New System.Windows.Forms.ImageList(Me.components)
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.Total = New DevComponents.Editors.IntegerInput()
        Me.Output_Label = New DevComponents.DotNetBar.LabelX()
        Me.Pbar = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.Bar3 = New DevComponents.DotNetBar.Bar()
        Me.PanelDockContainer1 = New DevComponents.DotNetBar.PanelDockContainer()
        Me.Tree = New DevComponents.AdvTree.AdvTree()
        Me.Node1 = New DevComponents.AdvTree.Node()
        Me.NodeConnector1 = New DevComponents.AdvTree.NodeConnector()
        Me.ElementStyle1 = New DevComponents.DotNetBar.ElementStyle()
        Me.DockContainerItem1 = New DevComponents.DotNetBar.DockContainerItem()
        Me.DockContainerItem2 = New DevComponents.DotNetBar.DockContainerItem()
        Me.DockSite1 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite2 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite8 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite5 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite6 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite7 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite3 = New DevComponents.DotNetBar.DockSite()
        Me.CMD_Index = New DevComponents.DotNetBar.Command(Me.components)
        Me.BW = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelEx1.SuspendLayout()
        Me.DockSite9.SuspendLayout()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bar1.SuspendLayout()
        Me.PanelDockContainer2.SuspendLayout()
        Me.PanelEx4.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        CType(Me.Total, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bar3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDockContainer1.SuspendLayout()
        CType(Me.Tree, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.Input_Dir)
        Me.PanelEx1.Controls.Add(Me.LabelX1)
        Me.PanelEx1.Controls.Add(Me.Btn_Refresh)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(470, 26)
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
        'Input_Dir
        '
        Me.Input_Dir.DisplayMember = "Text"
        Me.Input_Dir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Input_Dir.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Input_Dir.FormattingEnabled = True
        Me.Input_Dir.ItemHeight = 19
        Me.Input_Dir.Location = New System.Drawing.Point(75, 0)
        Me.Input_Dir.Name = "Input_Dir"
        Me.Input_Dir.Size = New System.Drawing.Size(320, 25)
        Me.Input_Dir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Input_Dir.TabIndex = 1
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelX1.Location = New System.Drawing.Point(0, 0)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 26)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Répertoire"
        '
        'Btn_Refresh
        '
        Me.Btn_Refresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_Refresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Btn_Refresh.Dock = System.Windows.Forms.DockStyle.Right
        Me.Btn_Refresh.Location = New System.Drawing.Point(395, 0)
        Me.Btn_Refresh.Name = "Btn_Refresh"
        Me.Btn_Refresh.Size = New System.Drawing.Size(75, 26)
        Me.Btn_Refresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_Refresh.TabIndex = 2
        Me.Btn_Refresh.Text = "Refresh"
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx2.Location = New System.Drawing.Point(0, 26)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(470, 462)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 4
        Me.PanelEx2.Text = " "
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
        Me.DockSite4.Location = New System.Drawing.Point(0, 488)
        Me.DockSite4.Name = "DockSite4"
        Me.DockSite4.Size = New System.Drawing.Size(470, 0)
        Me.DockSite4.TabIndex = 11
        Me.DockSite4.TabStop = False
        '
        'DockSite9
        '
        Me.DockSite9.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite9.Controls.Add(Me.Bar1)
        Me.DockSite9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DockSite9.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer(New DevComponents.DotNetBar.DocumentBaseContainer() {CType(New DevComponents.DotNetBar.DocumentBarContainer(Me.Bar1, 470, 462), DevComponents.DotNetBar.DocumentBaseContainer)}, DevComponents.DotNetBar.eOrientation.Vertical)
        Me.DockSite9.Location = New System.Drawing.Point(0, 26)
        Me.DockSite9.Name = "DockSite9"
        Me.DockSite9.Size = New System.Drawing.Size(470, 462)
        Me.DockSite9.TabIndex = 16
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
        Me.Bar1.Controls.Add(Me.PanelDockContainer1)
        Me.Bar1.DockTabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top
        Me.Bar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bar1.IsMaximized = False
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.DockContainerItem1, Me.DockContainerItem2})
        Me.Bar1.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer
        Me.Bar1.Location = New System.Drawing.Point(0, 0)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.SelectedDockTab = 1
        Me.Bar1.Size = New System.Drawing.Size(470, 462)
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar1.TabIndex = 0
        Me.Bar1.TabNavigation = True
        Me.Bar1.TabStop = False
        '
        'PanelDockContainer2
        '
        Me.PanelDockContainer2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelDockContainer2.Controls.Add(Me.PanelEx4)
        Me.PanelDockContainer2.Controls.Add(Me.PanelEx3)
        Me.PanelDockContainer2.Controls.Add(Me.Bar3)
        Me.PanelDockContainer2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelDockContainer2.Location = New System.Drawing.Point(3, 28)
        Me.PanelDockContainer2.Name = "PanelDockContainer2"
        Me.PanelDockContainer2.Size = New System.Drawing.Size(464, 431)
        Me.PanelDockContainer2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelDockContainer2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelDockContainer2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.PanelDockContainer2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelDockContainer2.Style.GradientAngle = 90
        Me.PanelDockContainer2.TabIndex = 5
        '
        'PanelEx4
        '
        Me.PanelEx4.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx4.Controls.Add(Me.LV)
        Me.PanelEx4.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx4.Location = New System.Drawing.Point(0, 25)
        Me.PanelEx4.Name = "PanelEx4"
        Me.PanelEx4.Size = New System.Drawing.Size(464, 359)
        Me.PanelEx4.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx4.Style.GradientAngle = 90
        Me.PanelEx4.TabIndex = 5
        Me.PanelEx4.Text = " "
        '
        'LV
        '
        '
        '
        '
        Me.LV.Border.Class = "ListViewBorder"
        Me.LV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LV.DisabledBackColor = System.Drawing.Color.Empty
        Me.LV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LV.LargeImageList = Me.IL_LV_Large
        Me.LV.Location = New System.Drawing.Point(0, 0)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(464, 359)
        Me.LV.SmallImageList = Me.IL_LV_Small
        Me.LV.TabIndex = 0
        Me.LV.UseCompatibleStateImageBehavior = False
        Me.LV.View = System.Windows.Forms.View.Details
        '
        'IL_LV_Large
        '
        Me.IL_LV_Large.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.IL_LV_Large.ImageSize = New System.Drawing.Size(32, 32)
        Me.IL_LV_Large.TransparentColor = System.Drawing.Color.Transparent
        '
        'IL_LV_Small
        '
        Me.IL_LV_Small.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.IL_LV_Small.ImageSize = New System.Drawing.Size(24, 24)
        Me.IL_LV_Small.TransparentColor = System.Drawing.Color.Transparent
        '
        'PanelEx3
        '
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.Controls.Add(Me.Total)
        Me.PanelEx3.Controls.Add(Me.Output_Label)
        Me.PanelEx3.Controls.Add(Me.Pbar)
        Me.PanelEx3.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelEx3.Location = New System.Drawing.Point(0, 384)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(464, 47)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 1
        Me.PanelEx3.Text = " "
        '
        'Total
        '
        '
        '
        '
        Me.Total.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Total.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Total.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.Total.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Total.Location = New System.Drawing.Point(372, 0)
        Me.Total.Name = "Total"
        Me.Total.ShowUpDown = True
        Me.Total.Size = New System.Drawing.Size(92, 24)
        Me.Total.TabIndex = 2
        '
        'Output_Label
        '
        '
        '
        '
        Me.Output_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Output_Label.Dock = System.Windows.Forms.DockStyle.Left
        Me.Output_Label.Location = New System.Drawing.Point(0, 0)
        Me.Output_Label.Name = "Output_Label"
        Me.Output_Label.Size = New System.Drawing.Size(372, 24)
        Me.Output_Label.TabIndex = 1
        Me.Output_Label.Text = " "
        '
        'Pbar
        '
        '
        '
        '
        Me.Pbar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Pbar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Pbar.Location = New System.Drawing.Point(0, 24)
        Me.Pbar.Name = "Pbar"
        Me.Pbar.Size = New System.Drawing.Size(464, 23)
        Me.Pbar.TabIndex = 0
        Me.Pbar.Text = "ProgressBarX1"
        '
        'Bar3
        '
        Me.Bar3.AntiAlias = True
        Me.Bar3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Bar3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Bar3.IsMaximized = False
        Me.Bar3.Location = New System.Drawing.Point(0, 0)
        Me.Bar3.Name = "Bar3"
        Me.Bar3.Size = New System.Drawing.Size(464, 25)
        Me.Bar3.Stretch = True
        Me.Bar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar3.TabIndex = 0
        Me.Bar3.TabStop = False
        Me.Bar3.Text = "Bar3"
        '
        'PanelDockContainer1
        '
        Me.PanelDockContainer1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelDockContainer1.Controls.Add(Me.Tree)
        Me.PanelDockContainer1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelDockContainer1.Location = New System.Drawing.Point(3, 28)
        Me.PanelDockContainer1.Name = "PanelDockContainer1"
        Me.PanelDockContainer1.Size = New System.Drawing.Size(464, 431)
        Me.PanelDockContainer1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelDockContainer1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelDockContainer1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.PanelDockContainer1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelDockContainer1.Style.GradientAngle = 90
        Me.PanelDockContainer1.TabIndex = 0
        '
        'Tree
        '
        Me.Tree.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
        Me.Tree.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.Tree.BackgroundStyle.Class = "TreeBorderKey"
        Me.Tree.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tree.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.Tree.Location = New System.Drawing.Point(0, 0)
        Me.Tree.Name = "Tree"
        Me.Tree.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.Node1})
        Me.Tree.NodesConnector = Me.NodeConnector1
        Me.Tree.NodeStyle = Me.ElementStyle1
        Me.Tree.PathSeparator = ";"
        Me.Tree.Size = New System.Drawing.Size(464, 431)
        Me.Tree.Styles.Add(Me.ElementStyle1)
        Me.Tree.TabIndex = 0
        Me.Tree.Text = "AdvTree1"
        '
        'Node1
        '
        Me.Node1.Expanded = True
        Me.Node1.Name = "Node1"
        Me.Node1.Text = "Node1"
        '
        'NodeConnector1
        '
        Me.NodeConnector1.LineColor = System.Drawing.SystemColors.ControlText
        '
        'ElementStyle1
        '
        Me.ElementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ElementStyle1.Name = "ElementStyle1"
        Me.ElementStyle1.TextColor = System.Drawing.SystemColors.ControlText
        '
        'DockContainerItem1
        '
        Me.DockContainerItem1.Control = Me.PanelDockContainer1
        Me.DockContainerItem1.Name = "DockContainerItem1"
        Me.DockContainerItem1.Text = "Arborescence"
        '
        'DockContainerItem2
        '
        Me.DockContainerItem2.Control = Me.PanelDockContainer2
        Me.DockContainerItem2.Name = "DockContainerItem2"
        Me.DockContainerItem2.Text = "Détail"
        '
        'DockSite1
        '
        Me.DockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite1.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite1.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite1.Location = New System.Drawing.Point(0, 26)
        Me.DockSite1.Name = "DockSite1"
        Me.DockSite1.Size = New System.Drawing.Size(0, 462)
        Me.DockSite1.TabIndex = 8
        Me.DockSite1.TabStop = False
        '
        'DockSite2
        '
        Me.DockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite2.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite2.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite2.Location = New System.Drawing.Point(470, 26)
        Me.DockSite2.Name = "DockSite2"
        Me.DockSite2.Size = New System.Drawing.Size(0, 462)
        Me.DockSite2.TabIndex = 9
        Me.DockSite2.TabStop = False
        '
        'DockSite8
        '
        Me.DockSite8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DockSite8.Location = New System.Drawing.Point(0, 488)
        Me.DockSite8.Name = "DockSite8"
        Me.DockSite8.Size = New System.Drawing.Size(470, 0)
        Me.DockSite8.TabIndex = 15
        Me.DockSite8.TabStop = False
        '
        'DockSite5
        '
        Me.DockSite5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite5.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite5.Location = New System.Drawing.Point(0, 0)
        Me.DockSite5.Name = "DockSite5"
        Me.DockSite5.Size = New System.Drawing.Size(0, 488)
        Me.DockSite5.TabIndex = 12
        Me.DockSite5.TabStop = False
        '
        'DockSite6
        '
        Me.DockSite6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite6.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite6.Location = New System.Drawing.Point(470, 0)
        Me.DockSite6.Name = "DockSite6"
        Me.DockSite6.Size = New System.Drawing.Size(0, 488)
        Me.DockSite6.TabIndex = 13
        Me.DockSite6.TabStop = False
        '
        'DockSite7
        '
        Me.DockSite7.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite7.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite7.Location = New System.Drawing.Point(0, 0)
        Me.DockSite7.Name = "DockSite7"
        Me.DockSite7.Size = New System.Drawing.Size(470, 0)
        Me.DockSite7.TabIndex = 14
        Me.DockSite7.TabStop = False
        '
        'DockSite3
        '
        Me.DockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite3.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite3.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite3.Location = New System.Drawing.Point(0, 0)
        Me.DockSite3.Name = "DockSite3"
        Me.DockSite3.Size = New System.Drawing.Size(470, 0)
        Me.DockSite3.TabIndex = 10
        Me.DockSite3.TabStop = False
        '
        'CMD_Index
        '
        Me.CMD_Index.Name = "CMD_Index"
        '
        'BW
        '
        Me.BW.WorkerReportsProgress = True
        Me.BW.WorkerSupportsCancellation = True
        '
        'TreeExplorer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DockSite9)
        Me.Controls.Add(Me.DockSite2)
        Me.Controls.Add(Me.DockSite1)
        Me.Controls.Add(Me.PanelEx2)
        Me.Controls.Add(Me.PanelEx1)
        Me.Controls.Add(Me.DockSite3)
        Me.Controls.Add(Me.DockSite4)
        Me.Controls.Add(Me.DockSite5)
        Me.Controls.Add(Me.DockSite6)
        Me.Controls.Add(Me.DockSite7)
        Me.Controls.Add(Me.DockSite8)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "TreeExplorer"
        Me.Size = New System.Drawing.Size(470, 488)
        Me.PanelEx1.ResumeLayout(False)
        Me.DockSite9.ResumeLayout(False)
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bar1.ResumeLayout(False)
        Me.PanelDockContainer2.ResumeLayout(False)
        Me.PanelEx4.ResumeLayout(False)
        Me.PanelEx3.ResumeLayout(False)
        CType(Me.Total, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bar3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDockContainer1.ResumeLayout(False)
        CType(Me.Tree, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Input_Dir As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents DotNetBarManager1 As DevComponents.DotNetBar.DotNetBarManager
    Friend WithEvents DockSite4 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite9 As DevComponents.DotNetBar.DockSite
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents PanelDockContainer1 As DevComponents.DotNetBar.PanelDockContainer
    Friend WithEvents Node1 As DevComponents.AdvTree.Node
    Friend WithEvents NodeConnector1 As DevComponents.AdvTree.NodeConnector
    Friend WithEvents ElementStyle1 As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents DockContainerItem1 As DevComponents.DotNetBar.DockContainerItem
    Friend WithEvents PanelDockContainer2 As DevComponents.DotNetBar.PanelDockContainer
    Friend WithEvents PanelEx4 As DevComponents.DotNetBar.PanelEx
    Public WithEvents LV As DevComponents.DotNetBar.Controls.ListViewEx
    Friend WithEvents IL_LV_Large As ImageList
    Friend WithEvents IL_LV_Small As ImageList
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Bar3 As DevComponents.DotNetBar.Bar
    Friend WithEvents DockContainerItem2 As DevComponents.DotNetBar.DockContainerItem
    Friend WithEvents DockSite1 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite2 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite3 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite5 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite6 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite7 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite8 As DevComponents.DotNetBar.DockSite
    Public WithEvents Tree As DevComponents.AdvTree.AdvTree
    Friend WithEvents CMD_Index As DevComponents.DotNetBar.Command
    Friend WithEvents Btn_Refresh As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Pbar As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents BW As System.ComponentModel.BackgroundWorker
    Friend WithEvents Output_Label As DevComponents.DotNetBar.LabelX
    Public WithEvents Total As DevComponents.Editors.IntegerInput
    Friend WithEvents Timer1 As Timer
End Class
