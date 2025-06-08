<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tarification
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tarification))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx4 = New DevComponents.DotNetBar.PanelEx()
        Me.SuperTabControl1 = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.PanelEx5 = New DevComponents.DotNetBar.PanelEx()
        Me.SGC = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.SuperTabItem1 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.PanelEx6 = New DevComponents.DotNetBar.PanelEx()
        Me.Input_Mandat = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Input_Collaborateur = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Input_Price = New DevComponents.Editors.DoubleInput()
        Me.Input_DateIn = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.labelX5 = New DevComponents.DotNetBar.LabelX()
        Me.labelX4 = New DevComponents.DotNetBar.LabelX()
        Me.labelX3 = New DevComponents.DotNetBar.LabelX()
        Me.labelX2 = New DevComponents.DotNetBar.LabelX()
        Me.SuperTabItem2 = New DevComponents.DotNetBar.SuperTabItem()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.vcr1 = New SmartCoder.SuperGridDemo.VcrControl()
        Me.Bar1 = New DevComponents.DotNetBar.Bar()
        Me.IL_32 = New System.Windows.Forms.ImageList(Me.components)
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonItem()
        Me.Btn_Add = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonX4 = New DevComponents.DotNetBar.ButtonItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.Btn_SendToExcel = New DevComponents.DotNetBar.ButtonItem()
        Me.PanelEx1.SuspendLayout()
        Me.PanelEx4.SuspendLayout()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControl1.SuspendLayout()
        Me.SuperTabControlPanel1.SuspendLayout()
        Me.PanelEx5.SuspendLayout()
        Me.SuperTabControlPanel2.SuspendLayout()
        Me.PanelEx6.SuspendLayout()
        CType(Me.Input_Price, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Input_DateIn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx3.SuspendLayout()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.PanelEx4)
        Me.PanelEx1.Controls.Add(Me.PanelEx3)
        Me.PanelEx1.Controls.Add(Me.Bar1)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(872, 644)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        Me.PanelEx1.Text = " "
        '
        'PanelEx4
        '
        Me.PanelEx4.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx4.Controls.Add(Me.SuperTabControl1)
        Me.PanelEx4.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx4.Location = New System.Drawing.Point(0, 57)
        Me.PanelEx4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelEx4.Name = "PanelEx4"
        Me.PanelEx4.Size = New System.Drawing.Size(872, 541)
        Me.PanelEx4.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx4.Style.GradientAngle = 90
        Me.PanelEx4.TabIndex = 12
        Me.PanelEx4.Text = " "
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
        Me.SuperTabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SuperTabControl1.Name = "SuperTabControl1"
        Me.SuperTabControl1.ReorderTabsEnabled = True
        Me.SuperTabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.SuperTabControl1.SelectedTabIndex = 0
        Me.SuperTabControl1.Size = New System.Drawing.Size(872, 541)
        Me.SuperTabControl1.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabControl1.TabIndex = 0
        Me.SuperTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabItem1, Me.SuperTabItem2})
        Me.SuperTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.OneNote2007
        Me.SuperTabControl1.Text = "SuperTabControl1"
        '
        'SuperTabControlPanel1
        '
        Me.SuperTabControlPanel1.Controls.Add(Me.PanelEx5)
        Me.SuperTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel1.Location = New System.Drawing.Point(0, 30)
        Me.SuperTabControlPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SuperTabControlPanel1.Name = "SuperTabControlPanel1"
        Me.SuperTabControlPanel1.Size = New System.Drawing.Size(872, 511)
        Me.SuperTabControlPanel1.TabIndex = 1
        Me.SuperTabControlPanel1.TabItem = Me.SuperTabItem1
        '
        'PanelEx5
        '
        Me.PanelEx5.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx5.Controls.Add(Me.SGC)
        Me.PanelEx5.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx5.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelEx5.Name = "PanelEx5"
        Me.PanelEx5.Size = New System.Drawing.Size(872, 511)
        Me.PanelEx5.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx5.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx5.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx5.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx5.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx5.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx5.Style.GradientAngle = 90
        Me.PanelEx5.TabIndex = 16
        Me.PanelEx5.Text = " "
        '
        'SGC
        '
        Me.SGC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SGC.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.SGC.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SGC.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.SGC.Location = New System.Drawing.Point(0, 0)
        Me.SGC.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SGC.Name = "SGC"
        '
        '
        '
        Me.SGC.PrimaryGrid.AllowRowDelete = True
        Me.SGC.PrimaryGrid.AllowRowInsert = True
        Me.SGC.PrimaryGrid.AllowRowResize = True
        Me.SGC.PrimaryGrid.AutoHideDeletedRows = False
        '
        '
        '
        Me.SGC.PrimaryGrid.ColumnHeader.RowHeight = 30
        Me.SGC.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SGC.PrimaryGrid.DefaultVisualStyles.RowStyles.Default.RowHeaderStyle.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SGC.PrimaryGrid.EnableCellExpressions = True
        Me.SGC.PrimaryGrid.EnableColumnFiltering = True
        Me.SGC.PrimaryGrid.EnableFiltering = True
        Me.SGC.PrimaryGrid.EnableRowFiltering = True
        '
        '
        '
        Me.SGC.PrimaryGrid.Filter.ShowPanelFilterExpr = True
        Me.SGC.PrimaryGrid.Filter.Visible = True
        Me.SGC.PrimaryGrid.NoRowsText = "Select a DataSource from the list to the right to populate the grid."
        Me.SGC.PrimaryGrid.ShowRowGridIndex = True
        '
        '
        '
        Me.SGC.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled
        Me.SGC.Size = New System.Drawing.Size(872, 511)
        Me.SGC.TabIndex = 31
        Me.SGC.Text = "superGridControl1"
        '
        'SuperTabItem1
        '
        Me.SuperTabItem1.AttachedControl = Me.SuperTabControlPanel1
        Me.SuperTabItem1.GlobalItem = False
        Me.SuperTabItem1.Image = Global.Chronos.My.Resources.Resources.book1
        Me.SuperTabItem1.ImageIndex = 5
        Me.SuperTabItem1.Name = "SuperTabItem1"
        Me.SuperTabItem1.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Teal
        Me.SuperTabItem1.Text = "Liste"
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.Controls.Add(Me.PanelEx6)
        Me.SuperTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel2.Location = New System.Drawing.Point(0, 38)
        Me.SuperTabControlPanel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SuperTabControlPanel2.Name = "SuperTabControlPanel2"
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(872, 489)
        Me.SuperTabControlPanel2.TabIndex = 0
        Me.SuperTabControlPanel2.TabItem = Me.SuperTabItem2
        '
        'PanelEx6
        '
        Me.PanelEx6.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx6.Controls.Add(Me.Input_Mandat)
        Me.PanelEx6.Controls.Add(Me.Input_Collaborateur)
        Me.PanelEx6.Controls.Add(Me.Input_Price)
        Me.PanelEx6.Controls.Add(Me.Input_DateIn)
        Me.PanelEx6.Controls.Add(Me.labelX5)
        Me.PanelEx6.Controls.Add(Me.labelX4)
        Me.PanelEx6.Controls.Add(Me.labelX3)
        Me.PanelEx6.Controls.Add(Me.labelX2)
        Me.PanelEx6.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx6.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelEx6.Name = "PanelEx6"
        Me.PanelEx6.Size = New System.Drawing.Size(872, 489)
        Me.PanelEx6.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx6.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx6.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx6.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx6.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx6.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx6.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx6.Style.GradientAngle = 90
        Me.PanelEx6.TabIndex = 16
        Me.PanelEx6.Text = " "
        '
        'Input_Mandat
        '
        Me.Input_Mandat.DisplayMember = "Text"
        Me.Input_Mandat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Input_Mandat.FormattingEnabled = True
        Me.Input_Mandat.ItemHeight = 21
        Me.Input_Mandat.Location = New System.Drawing.Point(73, 59)
        Me.Input_Mandat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Input_Mandat.Name = "Input_Mandat"
        Me.Input_Mandat.Size = New System.Drawing.Size(136, 27)
        Me.Input_Mandat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Input_Mandat.TabIndex = 37
        '
        'Input_Collaborateur
        '
        Me.Input_Collaborateur.DisplayMember = "Text"
        Me.Input_Collaborateur.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Input_Collaborateur.FormattingEnabled = True
        Me.Input_Collaborateur.ItemHeight = 21
        Me.Input_Collaborateur.Location = New System.Drawing.Point(73, 146)
        Me.Input_Collaborateur.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Input_Collaborateur.Name = "Input_Collaborateur"
        Me.Input_Collaborateur.Size = New System.Drawing.Size(136, 27)
        Me.Input_Collaborateur.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Input_Collaborateur.TabIndex = 36
        '
        'Input_Price
        '
        '
        '
        '
        Me.Input_Price.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Input_Price.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_Price.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.Input_Price.Increment = 1.0R
        Me.Input_Price.Location = New System.Drawing.Point(71, 305)
        Me.Input_Price.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Input_Price.Name = "Input_Price"
        Me.Input_Price.ShowUpDown = True
        Me.Input_Price.Size = New System.Drawing.Size(236, 26)
        Me.Input_Price.TabIndex = 29
        '
        'Input_DateIn
        '
        '
        '
        '
        Me.Input_DateIn.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Input_DateIn.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_DateIn.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.Input_DateIn.ButtonDropDown.Visible = True
        Me.Input_DateIn.IsPopupCalendarOpen = False
        Me.Input_DateIn.Location = New System.Drawing.Point(71, 225)
        Me.Input_DateIn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        '
        '
        '
        '
        '
        '
        Me.Input_DateIn.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_DateIn.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.Input_DateIn.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.Input_DateIn.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.Input_DateIn.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.Input_DateIn.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.Input_DateIn.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Input_DateIn.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.Input_DateIn.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.Input_DateIn.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_DateIn.MonthCalendar.DisplayMonth = New Date(2019, 6, 1, 0, 0, 0, 0)
        Me.Input_DateIn.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.Input_DateIn.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Input_DateIn.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.Input_DateIn.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Input_DateIn.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_DateIn.MonthCalendar.TodayButtonVisible = True
        Me.Input_DateIn.Name = "Input_DateIn"
        Me.Input_DateIn.Size = New System.Drawing.Size(236, 26)
        Me.Input_DateIn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Input_DateIn.TabIndex = 30
        '
        'labelX5
        '
        Me.labelX5.AutoSize = True
        '
        '
        '
        Me.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX5.Location = New System.Drawing.Point(50, 276)
        Me.labelX5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.labelX5.Name = "labelX5"
        Me.labelX5.Size = New System.Drawing.Size(30, 21)
        Me.labelX5.TabIndex = 34
        Me.labelX5.Text = "Prix"
        '
        'labelX4
        '
        Me.labelX4.AutoSize = True
        '
        '
        '
        Me.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX4.Location = New System.Drawing.Point(50, 196)
        Me.labelX4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.labelX4.Name = "labelX4"
        Me.labelX4.Size = New System.Drawing.Size(54, 21)
        Me.labelX4.TabIndex = 33
        Me.labelX4.Text = "Date In"
        '
        'labelX3
        '
        Me.labelX3.AutoSize = True
        '
        '
        '
        Me.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX3.Location = New System.Drawing.Point(50, 118)
        Me.labelX3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.labelX3.Name = "labelX3"
        Me.labelX3.Size = New System.Drawing.Size(99, 21)
        Me.labelX3.TabIndex = 32
        Me.labelX3.Text = "Collaborateur"
        '
        'labelX2
        '
        Me.labelX2.AutoSize = True
        '
        '
        '
        Me.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX2.Location = New System.Drawing.Point(50, 30)
        Me.labelX2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.labelX2.Name = "labelX2"
        Me.labelX2.Size = New System.Drawing.Size(41, 21)
        Me.labelX2.TabIndex = 31
        Me.labelX2.Text = "Code"
        '
        'SuperTabItem2
        '
        Me.SuperTabItem2.AttachedControl = Me.SuperTabControlPanel2
        Me.SuperTabItem2.GlobalItem = False
        Me.SuperTabItem2.Image = Global.Chronos.My.Resources.Resources.pen
        Me.SuperTabItem2.ImageIndex = 26
        Me.SuperTabItem2.Name = "SuperTabItem2"
        Me.SuperTabItem2.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue
        Me.SuperTabItem2.Text = "Modifier"
        '
        'PanelEx3
        '
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.Controls.Add(Me.vcr1)
        Me.PanelEx3.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelEx3.Location = New System.Drawing.Point(0, 598)
        Me.PanelEx3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(872, 46)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.Color = System.Drawing.Color.White
        Me.PanelEx3.Style.BackColor2.Color = System.Drawing.Color.White
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 8
        Me.PanelEx3.Text = " "
        '
        'vcr1
        '
        Me.vcr1.BackColor = System.Drawing.Color.Transparent
        Me.vcr1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.vcr1.Location = New System.Drawing.Point(0, 0)
        Me.vcr1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.vcr1.Name = "vcr1"
        Me.vcr1.Size = New System.Drawing.Size(872, 46)
        Me.vcr1.TabIndex = 35
        '
        'Bar1
        '
        Me.Bar1.AntiAlias = True
        Me.Bar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Bar1.DockSide = DevComponents.DotNetBar.eDockSide.Document
        Me.Bar1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Bar1.Images = Me.IL_32
        Me.Bar1.IsMaximized = False
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonX1, Me.Btn_Add, Me.ButtonX2, Me.ButtonX3, Me.ButtonX4, Me.ButtonItem2})
        Me.Bar1.Location = New System.Drawing.Point(0, 0)
        Me.Bar1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Size = New System.Drawing.Size(872, 57)
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar1.TabIndex = 22
        Me.Bar1.TabStop = False
        Me.Bar1.Text = "Bar1"
        '
        'IL_32
        '
        Me.IL_32.ImageStream = CType(resources.GetObject("IL_32.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IL_32.TransparentColor = System.Drawing.Color.Transparent
        Me.IL_32.Images.SetKeyName(0, "add.png")
        Me.IL_32.Images.SetKeyName(1, "administrator.png")
        Me.IL_32.Images.SetKeyName(2, "attachment.png")
        Me.IL_32.Images.SetKeyName(3, "back.png")
        Me.IL_32.Images.SetKeyName(4, "binoculars.png")
        Me.IL_32.Images.SetKeyName(5, "book.png")
        Me.IL_32.Images.SetKeyName(6, "briefcase.png")
        Me.IL_32.Images.SetKeyName(7, "brush.png")
        Me.IL_32.Images.SetKeyName(8, "calculator.png")
        Me.IL_32.Images.SetKeyName(9, "calendar.png")
        Me.IL_32.Images.SetKeyName(10, "camera.png")
        Me.IL_32.Images.SetKeyName(11, "cancel.png")
        Me.IL_32.Images.SetKeyName(12, "chat.png")
        Me.IL_32.Images.SetKeyName(13, "check_mark.png")
        Me.IL_32.Images.SetKeyName(14, "clients.png")
        Me.IL_32.Images.SetKeyName(15, "clip.png")
        Me.IL_32.Images.SetKeyName(16, "clipboard.png")
        Me.IL_32.Images.SetKeyName(17, "clock.png")
        Me.IL_32.Images.SetKeyName(18, "close.png")
        Me.IL_32.Images.SetKeyName(19, "close2.png")
        Me.IL_32.Images.SetKeyName(20, "copy.png")
        Me.IL_32.Images.SetKeyName(21, "cross.png")
        Me.IL_32.Images.SetKeyName(22, "delete.png")
        Me.IL_32.Images.SetKeyName(23, "diskette.png")
        Me.IL_32.Images.SetKeyName(24, "document.png")
        Me.IL_32.Images.SetKeyName(25, "door.png")
        Me.IL_32.Images.SetKeyName(26, "down.png")
        Me.IL_32.Images.SetKeyName(27, "edit.png")
        Me.IL_32.Images.SetKeyName(28, "fast_forward.png")
        Me.IL_32.Images.SetKeyName(29, "file.png")
        Me.IL_32.Images.SetKeyName(30, "files.png")
        Me.IL_32.Images.SetKeyName(31, "first.png")
        Me.IL_32.Images.SetKeyName(32, "folder.png")
        Me.IL_32.Images.SetKeyName(33, "forward.png")
        Me.IL_32.Images.SetKeyName(34, "games.png")
        Me.IL_32.Images.SetKeyName(35, "gear.png")
        Me.IL_32.Images.SetKeyName(36, "group.png")
        Me.IL_32.Images.SetKeyName(37, "hand.png")
        Me.IL_32.Images.SetKeyName(38, "help.png")
        Me.IL_32.Images.SetKeyName(39, "home.png")
        Me.IL_32.Images.SetKeyName(40, "hourglass.png")
        Me.IL_32.Images.SetKeyName(41, "info.png")
        Me.IL_32.Images.SetKeyName(42, "last.png")
        Me.IL_32.Images.SetKeyName(43, "light_bulb.png")
        Me.IL_32.Images.SetKeyName(44, "lock.png")
        Me.IL_32.Images.SetKeyName(45, "mail.png")
        Me.IL_32.Images.SetKeyName(46, "mailbox.png")
        Me.IL_32.Images.SetKeyName(47, "microphone.png")
        Me.IL_32.Images.SetKeyName(48, "monitor.png")
        Me.IL_32.Images.SetKeyName(49, "music.png")
        Me.IL_32.Images.SetKeyName(50, "network.png")
        Me.IL_32.Images.SetKeyName(51, "next.png")
        Me.IL_32.Images.SetKeyName(52, "notepad.png")
        Me.IL_32.Images.SetKeyName(53, "paste.png")
        Me.IL_32.Images.SetKeyName(54, "pause.png")
        Me.IL_32.Images.SetKeyName(55, "pen.png")
        Me.IL_32.Images.SetKeyName(56, "phone.png")
        Me.IL_32.Images.SetKeyName(57, "play.png")
        Me.IL_32.Images.SetKeyName(58, "preview.png")
        Me.IL_32.Images.SetKeyName(59, "printer.png")
        Me.IL_32.Images.SetKeyName(60, "pyramid.png")
        Me.IL_32.Images.SetKeyName(61, "recycle_bin.png")
        Me.IL_32.Images.SetKeyName(62, "refresh.png")
        Me.IL_32.Images.SetKeyName(63, "refresh_window.png")
        Me.IL_32.Images.SetKeyName(64, "reload.png")
        Me.IL_32.Images.SetKeyName(65, "rewind.png")
        Me.IL_32.Images.SetKeyName(66, "scissors.png")
        Me.IL_32.Images.SetKeyName(67, "shopping_cart.png")
        Me.IL_32.Images.SetKeyName(68, "speech_balloon.png")
        Me.IL_32.Images.SetKeyName(69, "sphere.png")
        Me.IL_32.Images.SetKeyName(70, "square.png")
        Me.IL_32.Images.SetKeyName(71, "star.png")
        Me.IL_32.Images.SetKeyName(72, "stats.png")
        Me.IL_32.Images.SetKeyName(73, "stop.png")
        Me.IL_32.Images.SetKeyName(74, "system.png")
        Me.IL_32.Images.SetKeyName(75, "trash.png")
        Me.IL_32.Images.SetKeyName(76, "unlock.png")
        Me.IL_32.Images.SetKeyName(77, "up.png")
        Me.IL_32.Images.SetKeyName(78, "user.png")
        Me.IL_32.Images.SetKeyName(79, "warning.png")
        Me.IL_32.Images.SetKeyName(80, "webcam.png")
        Me.IL_32.Images.SetKeyName(81, "window.png")
        Me.IL_32.Images.SetKeyName(82, "windows.png")
        Me.IL_32.Images.SetKeyName(83, "windows_restore.png")
        Me.IL_32.Images.SetKeyName(84, "wizard.png")
        Me.IL_32.Images.SetKeyName(85, "world.png")
        Me.IL_32.Images.SetKeyName(86, "world_upload.png")
        Me.IL_32.Images.SetKeyName(87, "write.png")
        Me.IL_32.Images.SetKeyName(88, "zoom.png")
        '
        'ButtonX1
        '
        Me.ButtonX1.ImageIndex = 24
        Me.ButtonX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Text = "Nouveau"
        '
        'Btn_Add
        '
        Me.Btn_Add.Enabled = False
        Me.Btn_Add.ImageIndex = 0
        Me.Btn_Add.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Text = "Ajouter"
        '
        'ButtonX2
        '
        Me.ButtonX2.ImageIndex = 23
        Me.ButtonX2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Text = "Sauver"
        '
        'ButtonX3
        '
        Me.ButtonX3.ImageIndex = 61
        Me.ButtonX3.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Text = "Effacer"
        '
        'ButtonX4
        '
        Me.ButtonX4.ImageIndex = 62
        Me.ButtonX4.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonX4.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far
        Me.ButtonX4.Name = "ButtonX4"
        Me.ButtonX4.Text = "Rafraichir"
        '
        'Timer1
        '
        '
        'ButtonItem2
        '
        Me.ButtonItem2.ImageIndex = 46
        Me.ButtonItem2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Btn_SendToExcel})
        Me.ButtonItem2.Text = "Send"
        Me.ButtonItem2.Visible = False
        '
        'Btn_SendToExcel
        '
        Me.Btn_SendToExcel.Name = "Btn_SendToExcel"
        Me.Btn_SendToExcel.Text = "To Excel"
        '
        'Tarification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Tarification"
        Me.Size = New System.Drawing.Size(872, 644)
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx4.ResumeLayout(False)
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControl1.ResumeLayout(False)
        Me.SuperTabControlPanel1.ResumeLayout(False)
        Me.PanelEx5.ResumeLayout(False)
        Me.SuperTabControlPanel2.ResumeLayout(False)
        Me.PanelEx6.ResumeLayout(False)
        Me.PanelEx6.PerformLayout()
        CType(Me.Input_Price, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Input_DateIn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx3.ResumeLayout(False)
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx4 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents SuperTabControl1 As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents SuperTabControlPanel1 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents PanelEx5 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents SuperTabItem1 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents PanelEx6 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents SuperTabItem2 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents vcr1 As SmartCoder.SuperGridDemo.VcrControl
    Private WithEvents SGC As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents Input_Price As DevComponents.Editors.DoubleInput
    Friend WithEvents Input_DateIn As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Private WithEvents labelX5 As DevComponents.DotNetBar.LabelX
    Private WithEvents labelX4 As DevComponents.DotNetBar.LabelX
    Private WithEvents labelX3 As DevComponents.DotNetBar.LabelX
    Private WithEvents labelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Input_Collaborateur As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Btn_Add As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonX4 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Input_Mandat As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents IL_32 As ImageList
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Btn_SendToExcel As DevComponents.DotNetBar.ButtonItem
End Class
