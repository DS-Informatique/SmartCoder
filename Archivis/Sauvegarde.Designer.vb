<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sauvegarde
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
        Me.Btn_Refresh = New DevComponents.DotNetBar.ButtonX()
        Me.Input_Profile = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.Input_Status = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.Output_Percentage = New DevComponents.DotNetBar.LabelX()
        Me.Btn_Stop = New DevComponents.DotNetBar.ButtonX()
        Me.Btn_Start = New DevComponents.DotNetBar.ButtonX()
        Me.Pbar = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.DotNetBarManager1 = New DevComponents.DotNetBar.DotNetBarManager(Me.components)
        Me.DockSite4 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite9 = New DevComponents.DotNetBar.DockSite()
        Me.Bar1 = New DevComponents.DotNetBar.Bar()
        Me.PanelDockContainer1 = New DevComponents.DotNetBar.PanelDockContainer()
        Me.Input_Source = New Archivis.TreeExplorer()
        Me.DockContainerItem1 = New DevComponents.DotNetBar.DockContainerItem()
        Me.Bar2 = New DevComponents.DotNetBar.Bar()
        Me.PanelDockContainer3 = New DevComponents.DotNetBar.PanelDockContainer()
        Me.Output_Console = New DevComponents.DotNetBar.Controls.RichTextBoxEx()
        Me.DockContainerItem3 = New DevComponents.DotNetBar.DockContainerItem()
        Me.Bar3 = New DevComponents.DotNetBar.Bar()
        Me.PanelDockContainer2 = New DevComponents.DotNetBar.PanelDockContainer()
        Me.Input_Destination = New Archivis.TreeExplorer()
        Me.DockContainerItem2 = New DevComponents.DotNetBar.DockContainerItem()
        Me.DockSite1 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite2 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite8 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite5 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite6 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite7 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite3 = New DevComponents.DotNetBar.DockSite()
        Me.BW = New System.ComponentModel.BackgroundWorker()
        Me.BW2 = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelEx1.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        Me.DockSite9.SuspendLayout()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bar1.SuspendLayout()
        Me.PanelDockContainer1.SuspendLayout()
        CType(Me.Bar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bar2.SuspendLayout()
        Me.PanelDockContainer3.SuspendLayout()
        CType(Me.Bar3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bar3.SuspendLayout()
        Me.PanelDockContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.Btn_Refresh)
        Me.PanelEx1.Controls.Add(Me.Input_Profile)
        Me.PanelEx1.Controls.Add(Me.LabelX1)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(954, 37)
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
        'Btn_Refresh
        '
        Me.Btn_Refresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_Refresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Btn_Refresh.Location = New System.Drawing.Point(378, 8)
        Me.Btn_Refresh.Name = "Btn_Refresh"
        Me.Btn_Refresh.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Refresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_Refresh.TabIndex = 2
        Me.Btn_Refresh.Text = "Rafraichir"
        '
        'Input_Profile
        '
        Me.Input_Profile.DisplayMember = "Text"
        Me.Input_Profile.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Input_Profile.FormattingEnabled = True
        Me.Input_Profile.ItemHeight = 19
        Me.Input_Profile.Location = New System.Drawing.Point(89, 6)
        Me.Input_Profile.Name = "Input_Profile"
        Me.Input_Profile.Size = New System.Drawing.Size(279, 25)
        Me.Input_Profile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Input_Profile.TabIndex = 1
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(8, 6)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Profile"
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.LabelX3)
        Me.PanelEx2.Controls.Add(Me.Input_Status)
        Me.PanelEx2.Controls.Add(Me.LabelX4)
        Me.PanelEx2.Controls.Add(Me.Output_Percentage)
        Me.PanelEx2.Controls.Add(Me.Btn_Stop)
        Me.PanelEx2.Controls.Add(Me.Btn_Start)
        Me.PanelEx2.Controls.Add(Me.Pbar)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelEx2.Location = New System.Drawing.Point(0, 541)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(954, 31)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 7
        Me.PanelEx2.Text = " "
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Dock = System.Windows.Forms.DockStyle.Right
        Me.LabelX3.Location = New System.Drawing.Point(159, 0)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(75, 31)
        Me.LabelX3.TabIndex = 0
        Me.LabelX3.Text = "Status : "
        '
        'Input_Status
        '
        Me.Input_Status.DisplayMember = "Text"
        Me.Input_Status.Dock = System.Windows.Forms.DockStyle.Right
        Me.Input_Status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Input_Status.FormattingEnabled = True
        Me.Input_Status.ItemHeight = 19
        Me.Input_Status.Location = New System.Drawing.Point(234, 0)
        Me.Input_Status.Name = "Input_Status"
        Me.Input_Status.Size = New System.Drawing.Size(121, 25)
        Me.Input_Status.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Input_Status.TabIndex = 1
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Dock = System.Windows.Forms.DockStyle.Right
        Me.LabelX4.Location = New System.Drawing.Point(355, 0)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(107, 31)
        Me.LabelX4.TabIndex = 2
        Me.LabelX4.Text = "Progression : "
        '
        'Output_Percentage
        '
        '
        '
        '
        Me.Output_Percentage.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Output_Percentage.Dock = System.Windows.Forms.DockStyle.Right
        Me.Output_Percentage.Location = New System.Drawing.Point(462, 0)
        Me.Output_Percentage.Name = "Output_Percentage"
        Me.Output_Percentage.Size = New System.Drawing.Size(100, 31)
        Me.Output_Percentage.TabIndex = 3
        Me.Output_Percentage.Text = "(0 %)"
        '
        'Btn_Stop
        '
        Me.Btn_Stop.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_Stop.Dock = System.Windows.Forms.DockStyle.Left
        Me.Btn_Stop.Location = New System.Drawing.Point(75, 0)
        Me.Btn_Stop.Name = "Btn_Stop"
        Me.Btn_Stop.Size = New System.Drawing.Size(75, 31)
        Me.Btn_Stop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_Stop.Symbol = "57415"
        Me.Btn_Stop.SymbolColor = System.Drawing.Color.Orange
        Me.Btn_Stop.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.Btn_Stop.TabIndex = 6
        Me.Btn_Stop.Text = "Stop"
        '
        'Btn_Start
        '
        Me.Btn_Start.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_Start.Dock = System.Windows.Forms.DockStyle.Left
        Me.Btn_Start.Location = New System.Drawing.Point(0, 0)
        Me.Btn_Start.Name = "Btn_Start"
        Me.Btn_Start.Size = New System.Drawing.Size(75, 31)
        Me.Btn_Start.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_Start.Symbol = "57401"
        Me.Btn_Start.SymbolColor = System.Drawing.Color.Green
        Me.Btn_Start.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.Btn_Start.TabIndex = 5
        Me.Btn_Start.Text = "Start"
        '
        'Pbar
        '
        '
        '
        '
        Me.Pbar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Pbar.Dock = System.Windows.Forms.DockStyle.Right
        Me.Pbar.Location = New System.Drawing.Point(562, 0)
        Me.Pbar.Name = "Pbar"
        Me.Pbar.Size = New System.Drawing.Size(392, 31)
        Me.Pbar.TabIndex = 4
        Me.Pbar.Text = "ProgressBarX1"
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
        Me.DockSite4.Location = New System.Drawing.Point(0, 572)
        Me.DockSite4.Name = "DockSite4"
        Me.DockSite4.Size = New System.Drawing.Size(954, 0)
        Me.DockSite4.TabIndex = 11
        Me.DockSite4.TabStop = False
        '
        'DockSite9
        '
        Me.DockSite9.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite9.Controls.Add(Me.Bar1)
        Me.DockSite9.Controls.Add(Me.Bar2)
        Me.DockSite9.Controls.Add(Me.Bar3)
        Me.DockSite9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DockSite9.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer(New DevComponents.DotNetBar.DocumentBaseContainer() {CType(New DevComponents.DotNetBar.DocumentDockContainer(New DevComponents.DotNetBar.DocumentBaseContainer() {CType(New DevComponents.DotNetBar.DocumentBarContainer(Me.Bar1, 475, 365), DevComponents.DotNetBar.DocumentBaseContainer), CType(New DevComponents.DotNetBar.DocumentBarContainer(Me.Bar3, 476, 365), DevComponents.DotNetBar.DocumentBaseContainer)}, DevComponents.DotNetBar.eOrientation.Horizontal), DevComponents.DotNetBar.DocumentBaseContainer), CType(New DevComponents.DotNetBar.DocumentBarContainer(Me.Bar2, 954, 92), DevComponents.DotNetBar.DocumentBaseContainer)}, DevComponents.DotNetBar.eOrientation.Vertical)
        Me.DockSite9.Location = New System.Drawing.Point(0, 37)
        Me.DockSite9.Name = "DockSite9"
        Me.DockSite9.Size = New System.Drawing.Size(954, 504)
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
        Me.Bar1.Controls.Add(Me.PanelDockContainer1)
        Me.Bar1.DockTabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top
        Me.Bar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bar1.IsMaximized = False
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.DockContainerItem1})
        Me.Bar1.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer
        Me.Bar1.Location = New System.Drawing.Point(0, 0)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.SelectedDockTab = 0
        Me.Bar1.Size = New System.Drawing.Size(475, 365)
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar1.TabIndex = 0
        Me.Bar1.TabNavigation = True
        Me.Bar1.TabStop = False
        '
        'PanelDockContainer1
        '
        Me.PanelDockContainer1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelDockContainer1.Controls.Add(Me.Input_Source)
        Me.PanelDockContainer1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelDockContainer1.Location = New System.Drawing.Point(3, 28)
        Me.PanelDockContainer1.Name = "PanelDockContainer1"
        Me.PanelDockContainer1.Size = New System.Drawing.Size(469, 334)
        Me.PanelDockContainer1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelDockContainer1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelDockContainer1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.PanelDockContainer1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelDockContainer1.Style.GradientAngle = 90
        Me.PanelDockContainer1.TabIndex = 0
        '
        'Input_Source
        '
        Me.Input_Source.ActiveDir = Nothing
        Me.Input_Source.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Input_Source.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Input_Source.Location = New System.Drawing.Point(0, 0)
        Me.Input_Source.Margin = New System.Windows.Forms.Padding(4)
        Me.Input_Source.Name = "Input_Source"
        Me.Input_Source.Size = New System.Drawing.Size(469, 334)
        Me.Input_Source.TabIndex = 0
        '
        'DockContainerItem1
        '
        Me.DockContainerItem1.Control = Me.PanelDockContainer1
        Me.DockContainerItem1.Name = "DockContainerItem1"
        Me.DockContainerItem1.Text = "Source"
        '
        'Bar2
        '
        Me.Bar2.AccessibleDescription = "DotNetBar Bar (Bar2)"
        Me.Bar2.AccessibleName = "DotNetBar Bar"
        Me.Bar2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.Bar2.AlwaysDisplayDockTab = True
        Me.Bar2.CanDockBottom = False
        Me.Bar2.CanDockDocument = True
        Me.Bar2.CanDockLeft = False
        Me.Bar2.CanDockRight = False
        Me.Bar2.CanDockTop = False
        Me.Bar2.CanHide = True
        Me.Bar2.CanUndock = False
        Me.Bar2.Controls.Add(Me.PanelDockContainer3)
        Me.Bar2.DockTabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top
        Me.Bar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bar2.IsMaximized = False
        Me.Bar2.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.DockContainerItem3})
        Me.Bar2.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer
        Me.Bar2.Location = New System.Drawing.Point(0, 368)
        Me.Bar2.Name = "Bar2"
        Me.Bar2.SelectedDockTab = 0
        Me.Bar2.Size = New System.Drawing.Size(954, 136)
        Me.Bar2.Stretch = True
        Me.Bar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar2.TabIndex = 1
        Me.Bar2.TabNavigation = True
        Me.Bar2.TabStop = False
        '
        'PanelDockContainer3
        '
        Me.PanelDockContainer3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelDockContainer3.Controls.Add(Me.Output_Console)
        Me.PanelDockContainer3.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelDockContainer3.Location = New System.Drawing.Point(3, 28)
        Me.PanelDockContainer3.Name = "PanelDockContainer3"
        Me.PanelDockContainer3.Size = New System.Drawing.Size(948, 105)
        Me.PanelDockContainer3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelDockContainer3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelDockContainer3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.PanelDockContainer3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelDockContainer3.Style.GradientAngle = 90
        Me.PanelDockContainer3.TabIndex = 9
        '
        'Output_Console
        '
        '
        '
        '
        Me.Output_Console.BackgroundStyle.Class = "RichTextBoxBorder"
        Me.Output_Console.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Output_Console.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Output_Console.Location = New System.Drawing.Point(0, 0)
        Me.Output_Console.Name = "Output_Console"
        Me.Output_Console.Rtf = "{\rtf1\ansi\deff0\nouicompat{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "{\*\generator Riched20 10.0.14393}\viewkind4\uc1 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\pard\f0\fs23\lang4108  \par" &
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Output_Console.Size = New System.Drawing.Size(948, 105)
        Me.Output_Console.TabIndex = 0
        Me.Output_Console.Text = " "
        '
        'DockContainerItem3
        '
        Me.DockContainerItem3.Control = Me.PanelDockContainer3
        Me.DockContainerItem3.Name = "DockContainerItem3"
        Me.DockContainerItem3.Text = "Opération"
        '
        'Bar3
        '
        Me.Bar3.AccessibleDescription = "DotNetBar Bar (Bar3)"
        Me.Bar3.AccessibleName = "DotNetBar Bar"
        Me.Bar3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.Bar3.AlwaysDisplayDockTab = True
        Me.Bar3.CanDockBottom = False
        Me.Bar3.CanDockDocument = True
        Me.Bar3.CanDockLeft = False
        Me.Bar3.CanDockRight = False
        Me.Bar3.CanDockTop = False
        Me.Bar3.CanHide = True
        Me.Bar3.CanUndock = False
        Me.Bar3.Controls.Add(Me.PanelDockContainer2)
        Me.Bar3.DockTabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top
        Me.Bar3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bar3.IsMaximized = False
        Me.Bar3.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.DockContainerItem2})
        Me.Bar3.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer
        Me.Bar3.Location = New System.Drawing.Point(478, 0)
        Me.Bar3.Name = "Bar3"
        Me.Bar3.SelectedDockTab = 0
        Me.Bar3.Size = New System.Drawing.Size(476, 365)
        Me.Bar3.Stretch = True
        Me.Bar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar3.TabIndex = 2
        Me.Bar3.TabNavigation = True
        Me.Bar3.TabStop = False
        '
        'PanelDockContainer2
        '
        Me.PanelDockContainer2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelDockContainer2.Controls.Add(Me.Input_Destination)
        Me.PanelDockContainer2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelDockContainer2.Location = New System.Drawing.Point(3, 28)
        Me.PanelDockContainer2.Name = "PanelDockContainer2"
        Me.PanelDockContainer2.Size = New System.Drawing.Size(470, 334)
        Me.PanelDockContainer2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelDockContainer2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelDockContainer2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.PanelDockContainer2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelDockContainer2.Style.GradientAngle = 90
        Me.PanelDockContainer2.TabIndex = 5
        '
        'Input_Destination
        '
        Me.Input_Destination.ActiveDir = Nothing
        Me.Input_Destination.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Input_Destination.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Input_Destination.Location = New System.Drawing.Point(0, 0)
        Me.Input_Destination.Margin = New System.Windows.Forms.Padding(4)
        Me.Input_Destination.Name = "Input_Destination"
        Me.Input_Destination.Size = New System.Drawing.Size(470, 334)
        Me.Input_Destination.TabIndex = 0
        '
        'DockContainerItem2
        '
        Me.DockContainerItem2.Control = Me.PanelDockContainer2
        Me.DockContainerItem2.Name = "DockContainerItem2"
        Me.DockContainerItem2.Text = "Destination"
        '
        'DockSite1
        '
        Me.DockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite1.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite1.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite1.Location = New System.Drawing.Point(0, 37)
        Me.DockSite1.Name = "DockSite1"
        Me.DockSite1.Size = New System.Drawing.Size(0, 504)
        Me.DockSite1.TabIndex = 8
        Me.DockSite1.TabStop = False
        '
        'DockSite2
        '
        Me.DockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite2.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite2.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite2.Location = New System.Drawing.Point(954, 37)
        Me.DockSite2.Name = "DockSite2"
        Me.DockSite2.Size = New System.Drawing.Size(0, 504)
        Me.DockSite2.TabIndex = 9
        Me.DockSite2.TabStop = False
        '
        'DockSite8
        '
        Me.DockSite8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DockSite8.Location = New System.Drawing.Point(0, 572)
        Me.DockSite8.Name = "DockSite8"
        Me.DockSite8.Size = New System.Drawing.Size(954, 0)
        Me.DockSite8.TabIndex = 15
        Me.DockSite8.TabStop = False
        '
        'DockSite5
        '
        Me.DockSite5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite5.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite5.Location = New System.Drawing.Point(0, 0)
        Me.DockSite5.Name = "DockSite5"
        Me.DockSite5.Size = New System.Drawing.Size(0, 572)
        Me.DockSite5.TabIndex = 12
        Me.DockSite5.TabStop = False
        '
        'DockSite6
        '
        Me.DockSite6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite6.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite6.Location = New System.Drawing.Point(954, 0)
        Me.DockSite6.Name = "DockSite6"
        Me.DockSite6.Size = New System.Drawing.Size(0, 572)
        Me.DockSite6.TabIndex = 13
        Me.DockSite6.TabStop = False
        '
        'DockSite7
        '
        Me.DockSite7.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite7.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite7.Location = New System.Drawing.Point(0, 0)
        Me.DockSite7.Name = "DockSite7"
        Me.DockSite7.Size = New System.Drawing.Size(954, 0)
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
        Me.DockSite3.Size = New System.Drawing.Size(954, 0)
        Me.DockSite3.TabIndex = 10
        Me.DockSite3.TabStop = False
        '
        'BW
        '
        Me.BW.WorkerReportsProgress = True
        Me.BW.WorkerSupportsCancellation = True
        '
        'BW2
        '
        Me.BW2.WorkerReportsProgress = True
        Me.BW2.WorkerSupportsCancellation = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Sauvegarde
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
        Me.Name = "Sauvegarde"
        Me.Size = New System.Drawing.Size(954, 572)
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        Me.DockSite9.ResumeLayout(False)
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bar1.ResumeLayout(False)
        Me.PanelDockContainer1.ResumeLayout(False)
        CType(Me.Bar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bar2.ResumeLayout(False)
        Me.PanelDockContainer3.ResumeLayout(False)
        CType(Me.Bar3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bar3.ResumeLayout(False)
        Me.PanelDockContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Input_Profile As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Public WithEvents Btn_Stop As DevComponents.DotNetBar.ButtonX
    Public WithEvents Btn_Start As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Pbar As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents Output_Percentage As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Input_Status As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DotNetBarManager1 As DevComponents.DotNetBar.DotNetBarManager
    Friend WithEvents DockSite4 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite9 As DevComponents.DotNetBar.DockSite
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents PanelDockContainer1 As DevComponents.DotNetBar.PanelDockContainer
    Friend WithEvents DockContainerItem1 As DevComponents.DotNetBar.DockContainerItem
    Friend WithEvents Bar2 As DevComponents.DotNetBar.Bar
    Friend WithEvents PanelDockContainer3 As DevComponents.DotNetBar.PanelDockContainer
    Friend WithEvents Output_Console As DevComponents.DotNetBar.Controls.RichTextBoxEx
    Friend WithEvents DockContainerItem3 As DevComponents.DotNetBar.DockContainerItem
    Friend WithEvents Bar3 As DevComponents.DotNetBar.Bar
    Friend WithEvents PanelDockContainer2 As DevComponents.DotNetBar.PanelDockContainer
    Friend WithEvents DockContainerItem2 As DevComponents.DotNetBar.DockContainerItem
    Friend WithEvents DockSite1 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite2 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite3 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite5 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite6 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite7 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite8 As DevComponents.DotNetBar.DockSite
    Friend WithEvents Btn_Refresh As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Input_Source As TreeExplorer
    Friend WithEvents Input_Destination As TreeExplorer
    Friend WithEvents BW As System.ComponentModel.BackgroundWorker
    Friend WithEvents BW2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As Timer
End Class
