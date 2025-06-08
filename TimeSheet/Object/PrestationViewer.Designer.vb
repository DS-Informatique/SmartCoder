<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrestationViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrestationViewer))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.Cb_Société = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.Btn_Save = New DevComponents.DotNetBar.ButtonX()
        Me.Invoice_Filter = New DevComponents.DotNetBar.ButtonX()
        Me.DateEnd = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.DateStart = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.Mandat = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx4 = New DevComponents.DotNetBar.PanelEx()
        Me.SuperTabControl1 = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.PanelEx5 = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx7 = New DevComponents.DotNetBar.PanelEx()
        Me.SGC = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.Btn_Select_All = New DevComponents.DotNetBar.ButtonX()
        Me.Btn_Deselect_All = New DevComponents.DotNetBar.ButtonItem()
        Me.SuperTabItem1 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.PanelEx6 = New DevComponents.DotNetBar.PanelEx()
        Me.SuperTabItem2 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel3 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.PanelEx8 = New DevComponents.DotNetBar.PanelEx()
        Me.Btn_Print_Simple = New DevComponents.DotNetBar.ButtonX()
        Me.Btn_Print_Empty = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.NewInvoice_Adresse = New DevComponents.DotNetBar.Controls.RichTextBoxEx()
        Me.NewInvoice_Libellé = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX33 = New DevComponents.DotNetBar.LabelX()
        Me.NewInvoice_Concerne = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.ComboItem6 = New DevComponents.Editors.ComboItem()
        Me.ComboItem7 = New DevComponents.Editors.ComboItem()
        Me.ComboItem8 = New DevComponents.Editors.ComboItem()
        Me.ComboItem9 = New DevComponents.Editors.ComboItem()
        Me.ComboItem10 = New DevComponents.Editors.ComboItem()
        Me.ComboItem11 = New DevComponents.Editors.ComboItem()
        Me.ComboItem12 = New DevComponents.Editors.ComboItem()
        Me.LabelX27 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX23 = New DevComponents.DotNetBar.LabelX()
        Me.NewInvoice_N = New DevComponents.Editors.IntegerInput()
        Me.SuperTabItem3 = New DevComponents.DotNetBar.SuperTabItem()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.TVA = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Total = New DevComponents.Editors.DoubleInput()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.Total_TVA = New DevComponents.Editors.DoubleInput()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.Total_HTVA = New DevComponents.Editors.DoubleInput()
        Me.LabelX30 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX31 = New DevComponents.DotNetBar.LabelX()
        Me.Quantity_Frais = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX19 = New DevComponents.DotNetBar.LabelX()
        Me.Quantity_Prestation = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Total_Frais = New DevComponents.Editors.DoubleInput()
        Me.Total_Prestation = New DevComponents.Editors.DoubleInput()
        Me.LabelX28 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
        Me.Btn_CalculateTotal = New DevComponents.DotNetBar.ButtonX()
        Me.Bar1 = New DevComponents.DotNetBar.Bar()
        Me.IL_32 = New System.Windows.Forms.ImageList(Me.components)
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonItem()
        Me.Btn_Add = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonX4 = New DevComponents.DotNetBar.ButtonItem()
        Me.IL_ = New System.Windows.Forms.ImageList(Me.components)
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.IL_Client = New System.Windows.Forms.ImageList(Me.components)
        Me.PanelEx1.SuspendLayout()
        CType(Me.DateEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateStart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx2.SuspendLayout()
        Me.PanelEx4.SuspendLayout()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControl1.SuspendLayout()
        Me.SuperTabControlPanel1.SuspendLayout()
        Me.PanelEx5.SuspendLayout()
        Me.PanelEx7.SuspendLayout()
        Me.SuperTabControlPanel2.SuspendLayout()
        Me.SuperTabControlPanel3.SuspendLayout()
        Me.PanelEx8.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.NewInvoice_N, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx3.SuspendLayout()
        CType(Me.Total, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Total_TVA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Total_HTVA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Total_Frais, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Total_Prestation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.Cb_Société)
        Me.PanelEx1.Controls.Add(Me.LabelX7)
        Me.PanelEx1.Controls.Add(Me.Btn_Save)
        Me.PanelEx1.Controls.Add(Me.Invoice_Filter)
        Me.PanelEx1.Controls.Add(Me.DateEnd)
        Me.PanelEx1.Controls.Add(Me.LabelX3)
        Me.PanelEx1.Controls.Add(Me.DateStart)
        Me.PanelEx1.Controls.Add(Me.LabelX2)
        Me.PanelEx1.Controls.Add(Me.Mandat)
        Me.PanelEx1.Controls.Add(Me.LabelX1)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx1.Location = New System.Drawing.Point(0, 49)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1004, 86)
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
        'Cb_Société
        '
        Me.Cb_Société.DisplayMember = "Text"
        Me.Cb_Société.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Cb_Société.FormattingEnabled = True
        Me.Cb_Société.ItemHeight = 17
        Me.Cb_Société.Location = New System.Drawing.Point(119, 41)
        Me.Cb_Société.Name = "Cb_Société"
        Me.Cb_Société.Size = New System.Drawing.Size(121, 23)
        Me.Cb_Société.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Cb_Société.TabIndex = 53
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(14, 41)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(97, 23)
        Me.LabelX7.TabIndex = 52
        Me.LabelX7.Text = "Prestation Par"
        '
        'Btn_Save
        '
        Me.Btn_Save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_Save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Btn_Save.Location = New System.Drawing.Point(818, 13)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Size = New System.Drawing.Size(124, 45)
        Me.Btn_Save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_Save.TabIndex = 51
        Me.Btn_Save.Text = "Sauver"
        '
        'Invoice_Filter
        '
        Me.Invoice_Filter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Invoice_Filter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Invoice_Filter.Location = New System.Drawing.Point(526, 14)
        Me.Invoice_Filter.Name = "Invoice_Filter"
        Me.Invoice_Filter.Size = New System.Drawing.Size(192, 26)
        Me.Invoice_Filter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Invoice_Filter.TabIndex = 6
        Me.Invoice_Filter.Text = "Rechercher Prestations"
        '
        'DateEnd
        '
        '
        '
        '
        Me.DateEnd.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DateEnd.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateEnd.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.DateEnd.ButtonDropDown.Visible = True
        Me.DateEnd.IsPopupCalendarOpen = False
        Me.DateEnd.Location = New System.Drawing.Point(379, 41)
        '
        '
        '
        '
        '
        '
        Me.DateEnd.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateEnd.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.DateEnd.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.DateEnd.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.DateEnd.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.DateEnd.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.DateEnd.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.DateEnd.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.DateEnd.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.DateEnd.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateEnd.MonthCalendar.DisplayMonth = New Date(2019, 6, 1, 0, 0, 0, 0)
        Me.DateEnd.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.DateEnd.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.DateEnd.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.DateEnd.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.DateEnd.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateEnd.MonthCalendar.TodayButtonVisible = True
        Me.DateEnd.Name = "DateEnd"
        Me.DateEnd.Size = New System.Drawing.Size(141, 22)
        Me.DateEnd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.DateEnd.TabIndex = 5
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(287, 41)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(71, 23)
        Me.LabelX3.TabIndex = 4
        Me.LabelX3.Text = "Date Fin : "
        '
        'DateStart
        '
        '
        '
        '
        Me.DateStart.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DateStart.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateStart.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.DateStart.ButtonDropDown.Visible = True
        Me.DateStart.IsPopupCalendarOpen = False
        Me.DateStart.Location = New System.Drawing.Point(379, 14)
        '
        '
        '
        '
        '
        '
        Me.DateStart.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateStart.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.DateStart.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.DateStart.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.DateStart.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.DateStart.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.DateStart.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.DateStart.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.DateStart.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.DateStart.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateStart.MonthCalendar.DisplayMonth = New Date(2019, 6, 1, 0, 0, 0, 0)
        Me.DateStart.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.DateStart.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.DateStart.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.DateStart.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.DateStart.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DateStart.MonthCalendar.TodayButtonVisible = True
        Me.DateStart.Name = "DateStart"
        Me.DateStart.Size = New System.Drawing.Size(141, 22)
        Me.DateStart.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.DateStart.TabIndex = 3
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(287, 13)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(86, 23)
        Me.LabelX2.TabIndex = 2
        Me.LabelX2.Text = "Date Départ : "
        '
        'Mandat
        '
        Me.Mandat.DisplayMember = "Text"
        Me.Mandat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Mandat.FormattingEnabled = True
        Me.Mandat.ItemHeight = 17
        Me.Mandat.Location = New System.Drawing.Point(119, 13)
        Me.Mandat.Name = "Mandat"
        Me.Mandat.Size = New System.Drawing.Size(121, 23)
        Me.Mandat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Mandat.TabIndex = 1
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(14, 13)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(97, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Choisir Client"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(647, 18)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(72, 23)
        Me.LabelX4.TabIndex = 49
        Me.LabelX4.Text = "TVA"
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.PanelEx4)
        Me.PanelEx2.Controls.Add(Me.PanelEx3)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx2.Location = New System.Drawing.Point(0, 135)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(1004, 477)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 7
        Me.PanelEx2.Text = " "
        '
        'PanelEx4
        '
        Me.PanelEx4.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx4.Controls.Add(Me.SuperTabControl1)
        Me.PanelEx4.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx4.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx4.Name = "PanelEx4"
        Me.PanelEx4.Size = New System.Drawing.Size(1004, 386)
        Me.PanelEx4.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx4.Style.GradientAngle = 90
        Me.PanelEx4.TabIndex = 15
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
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel3)
        Me.SuperTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControl1.Name = "SuperTabControl1"
        Me.SuperTabControl1.ReorderTabsEnabled = True
        Me.SuperTabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.SuperTabControl1.SelectedTabIndex = 0
        Me.SuperTabControl1.Size = New System.Drawing.Size(1004, 386)
        Me.SuperTabControl1.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabControl1.TabIndex = 0
        Me.SuperTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabItem1, Me.SuperTabItem2, Me.SuperTabItem3})
        Me.SuperTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue
        Me.SuperTabControl1.Text = "SuperTabControl1"
        '
        'SuperTabControlPanel1
        '
        Me.SuperTabControlPanel1.Controls.Add(Me.PanelEx5)
        Me.SuperTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel1.Location = New System.Drawing.Point(0, 25)
        Me.SuperTabControlPanel1.Name = "SuperTabControlPanel1"
        Me.SuperTabControlPanel1.Size = New System.Drawing.Size(1004, 361)
        Me.SuperTabControlPanel1.TabIndex = 1
        Me.SuperTabControlPanel1.TabItem = Me.SuperTabItem1
        '
        'PanelEx5
        '
        Me.PanelEx5.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx5.Controls.Add(Me.PanelEx7)
        Me.PanelEx5.Controls.Add(Me.Btn_Select_All)
        Me.PanelEx5.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx5.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx5.Name = "PanelEx5"
        Me.PanelEx5.Size = New System.Drawing.Size(1004, 361)
        Me.PanelEx5.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx5.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx5.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx5.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx5.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx5.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx5.Style.GradientAngle = 90
        Me.PanelEx5.TabIndex = 15
        Me.PanelEx5.Text = " "
        '
        'PanelEx7
        '
        Me.PanelEx7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelEx7.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx7.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx7.Controls.Add(Me.SGC)
        Me.PanelEx7.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx7.Location = New System.Drawing.Point(2, 48)
        Me.PanelEx7.Name = "PanelEx7"
        Me.PanelEx7.Size = New System.Drawing.Size(1001, 312)
        Me.PanelEx7.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx7.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx7.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx7.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx7.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx7.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx7.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx7.Style.GradientAngle = 90
        Me.PanelEx7.TabIndex = 30
        Me.PanelEx7.Text = " "
        '
        'SGC
        '
        Me.SGC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SGC.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.SGC.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.SGC.Location = New System.Drawing.Point(0, 0)
        Me.SGC.Name = "SGC"
        '
        '
        '
        Me.SGC.PrimaryGrid.CheckBoxes = True
        Me.SGC.PrimaryGrid.EnableColumnFiltering = True
        Me.SGC.PrimaryGrid.EnableFiltering = True
        Me.SGC.PrimaryGrid.EnableRowFiltering = True
        '
        '
        '
        Me.SGC.PrimaryGrid.Filter.ShowPanelFilterExpr = True
        Me.SGC.PrimaryGrid.Filter.Visible = True
        Me.SGC.Size = New System.Drawing.Size(1001, 312)
        Me.SGC.TabIndex = 0
        Me.SGC.Text = "SuperGridControl1"
        '
        'Btn_Select_All
        '
        Me.Btn_Select_All.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_Select_All.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Btn_Select_All.Location = New System.Drawing.Point(14, 12)
        Me.Btn_Select_All.Name = "Btn_Select_All"
        Me.Btn_Select_All.Size = New System.Drawing.Size(140, 23)
        Me.Btn_Select_All.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_Select_All.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Btn_Deselect_All})
        Me.Btn_Select_All.TabIndex = 29
        Me.Btn_Select_All.Text = "Tous Sélectionner"
        '
        'Btn_Deselect_All
        '
        Me.Btn_Deselect_All.GlobalItem = False
        Me.Btn_Deselect_All.Name = "Btn_Deselect_All"
        Me.Btn_Deselect_All.Text = "Tous Déselectionner"
        '
        'SuperTabItem1
        '
        Me.SuperTabItem1.AttachedControl = Me.SuperTabControlPanel1
        Me.SuperTabItem1.GlobalItem = False
        Me.SuperTabItem1.Name = "SuperTabItem1"
        Me.SuperTabItem1.Text = "Liste"
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.Controls.Add(Me.PanelEx6)
        Me.SuperTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel2.Location = New System.Drawing.Point(0, 25)
        Me.SuperTabControlPanel2.Name = "SuperTabControlPanel2"
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(1004, 361)
        Me.SuperTabControlPanel2.TabIndex = 0
        Me.SuperTabControlPanel2.TabItem = Me.SuperTabItem2
        '
        'PanelEx6
        '
        Me.PanelEx6.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx6.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx6.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx6.Name = "PanelEx6"
        Me.PanelEx6.Size = New System.Drawing.Size(1004, 361)
        Me.PanelEx6.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx6.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx6.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx6.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx6.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx6.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx6.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx6.Style.GradientAngle = 90
        Me.PanelEx6.TabIndex = 19
        Me.PanelEx6.Text = " "
        '
        'SuperTabItem2
        '
        Me.SuperTabItem2.AttachedControl = Me.SuperTabControlPanel2
        Me.SuperTabItem2.GlobalItem = False
        Me.SuperTabItem2.Name = "SuperTabItem2"
        Me.SuperTabItem2.Text = "Statistique"
        '
        'SuperTabControlPanel3
        '
        Me.SuperTabControlPanel3.Controls.Add(Me.PanelEx8)
        Me.SuperTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel3.Location = New System.Drawing.Point(0, 25)
        Me.SuperTabControlPanel3.Name = "SuperTabControlPanel3"
        Me.SuperTabControlPanel3.Size = New System.Drawing.Size(1004, 361)
        Me.SuperTabControlPanel3.TabIndex = 0
        Me.SuperTabControlPanel3.TabItem = Me.SuperTabItem3
        '
        'PanelEx8
        '
        Me.PanelEx8.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx8.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx8.Controls.Add(Me.Btn_Print_Simple)
        Me.PanelEx8.Controls.Add(Me.Btn_Print_Empty)
        Me.PanelEx8.Controls.Add(Me.GroupPanel1)
        Me.PanelEx8.Controls.Add(Me.NewInvoice_Libellé)
        Me.PanelEx8.Controls.Add(Me.LabelX33)
        Me.PanelEx8.Controls.Add(Me.NewInvoice_Concerne)
        Me.PanelEx8.Controls.Add(Me.LabelX27)
        Me.PanelEx8.Controls.Add(Me.LabelX23)
        Me.PanelEx8.Controls.Add(Me.NewInvoice_N)
        Me.PanelEx8.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx8.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx8.Name = "PanelEx8"
        Me.PanelEx8.Size = New System.Drawing.Size(1004, 361)
        Me.PanelEx8.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx8.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx8.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx8.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx8.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx8.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx8.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx8.Style.GradientAngle = 90
        Me.PanelEx8.TabIndex = 0
        Me.PanelEx8.Text = " "
        '
        'Btn_Print_Simple
        '
        Me.Btn_Print_Simple.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_Print_Simple.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Btn_Print_Simple.Location = New System.Drawing.Point(275, 188)
        Me.Btn_Print_Simple.Name = "Btn_Print_Simple"
        Me.Btn_Print_Simple.Size = New System.Drawing.Size(169, 69)
        Me.Btn_Print_Simple.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_Print_Simple.TabIndex = 33
        Me.Btn_Print_Simple.Text = "Imprimer Prestation Simple"
        '
        'Btn_Print_Empty
        '
        Me.Btn_Print_Empty.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_Print_Empty.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Btn_Print_Empty.Location = New System.Drawing.Point(25, 188)
        Me.Btn_Print_Empty.Name = "Btn_Print_Empty"
        Me.Btn_Print_Empty.Size = New System.Drawing.Size(169, 69)
        Me.Btn_Print_Empty.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_Print_Empty.TabIndex = 32
        Me.Btn_Print_Empty.Text = "Imprimer Sans Prestation"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.NewInvoice_Adresse)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(479, 11)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(508, 336)
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
        Me.GroupPanel1.TabIndex = 31
        Me.GroupPanel1.Text = "Address"
        '
        'NewInvoice_Adresse
        '
        '
        '
        '
        Me.NewInvoice_Adresse.BackgroundStyle.Class = "RichTextBoxBorder"
        Me.NewInvoice_Adresse.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.NewInvoice_Adresse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NewInvoice_Adresse.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewInvoice_Adresse.Location = New System.Drawing.Point(0, 0)
        Me.NewInvoice_Adresse.Name = "NewInvoice_Adresse"
        Me.NewInvoice_Adresse.Rtf = "{\rtf1\ansi\deff0\nouicompat{\fonttbl{\f0\fnil\fcharset0 Arial;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "{\*\generator " &
    "Riched20 10.0.14393}\viewkind4\uc1 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\pard\fs24\lang4108  \par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.NewInvoice_Adresse.Size = New System.Drawing.Size(502, 313)
        Me.NewInvoice_Adresse.TabIndex = 2
        Me.NewInvoice_Adresse.Text = " "
        '
        'NewInvoice_Libellé
        '
        '
        '
        '
        Me.NewInvoice_Libellé.Border.Class = "TextBoxBorder"
        Me.NewInvoice_Libellé.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.NewInvoice_Libellé.Location = New System.Drawing.Point(24, 152)
        Me.NewInvoice_Libellé.Name = "NewInvoice_Libellé"
        Me.NewInvoice_Libellé.PreventEnterBeep = True
        Me.NewInvoice_Libellé.Size = New System.Drawing.Size(420, 22)
        Me.NewInvoice_Libellé.TabIndex = 30
        '
        'LabelX33
        '
        '
        '
        '
        Me.LabelX33.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX33.Location = New System.Drawing.Point(24, 123)
        Me.LabelX33.Name = "LabelX33"
        Me.LabelX33.Size = New System.Drawing.Size(91, 23)
        Me.LabelX33.TabIndex = 29
        Me.LabelX33.Text = "Libellé"
        '
        'NewInvoice_Concerne
        '
        Me.NewInvoice_Concerne.DisplayMember = "Text"
        Me.NewInvoice_Concerne.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.NewInvoice_Concerne.FormattingEnabled = True
        Me.NewInvoice_Concerne.ItemHeight = 17
        Me.NewInvoice_Concerne.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3, Me.ComboItem4, Me.ComboItem5, Me.ComboItem6, Me.ComboItem7, Me.ComboItem8, Me.ComboItem9, Me.ComboItem10, Me.ComboItem11, Me.ComboItem12})
        Me.NewInvoice_Concerne.Location = New System.Drawing.Point(24, 83)
        Me.NewInvoice_Concerne.Name = "NewInvoice_Concerne"
        Me.NewInvoice_Concerne.Size = New System.Drawing.Size(420, 23)
        Me.NewInvoice_Concerne.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.NewInvoice_Concerne.TabIndex = 24
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Base forfaitaire."
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Fiscal"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "Tva"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "Vente"
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "Diverses Prestations."
        '
        'ComboItem6
        '
        Me.ComboItem6.Text = "Domiciliation de votre société."
        '
        'ComboItem7
        '
        Me.ComboItem7.Text = "Fondation supplétive."
        '
        'ComboItem8
        '
        Me.ComboItem8.Text = "Déclarations sociales."
        '
        'ComboItem9
        '
        Me.ComboItem9.Text = "Mise à disposition d’un répondant."
        '
        'ComboItem10
        '
        Me.ComboItem10.Text = "Mise à disposition d’un Gérant."
        '
        'ComboItem11
        '
        Me.ComboItem11.Text = "Base variable."
        '
        'ComboItem12
        '
        Me.ComboItem12.Text = "Dossier fiscal."
        '
        'LabelX27
        '
        '
        '
        '
        Me.LabelX27.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX27.Location = New System.Drawing.Point(23, 54)
        Me.LabelX27.Name = "LabelX27"
        Me.LabelX27.Size = New System.Drawing.Size(212, 23)
        Me.LabelX27.TabIndex = 23
        Me.LabelX27.Text = "Concerne : "
        '
        'LabelX23
        '
        '
        '
        '
        Me.LabelX23.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX23.Location = New System.Drawing.Point(20, 23)
        Me.LabelX23.Name = "LabelX23"
        Me.LabelX23.Size = New System.Drawing.Size(89, 23)
        Me.LabelX23.TabIndex = 22
        Me.LabelX23.Text = "N° de Facture"
        '
        'NewInvoice_N
        '
        '
        '
        '
        Me.NewInvoice_N.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.NewInvoice_N.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.NewInvoice_N.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.NewInvoice_N.Location = New System.Drawing.Point(115, 24)
        Me.NewInvoice_N.Name = "NewInvoice_N"
        Me.NewInvoice_N.ShowUpDown = True
        Me.NewInvoice_N.Size = New System.Drawing.Size(125, 22)
        Me.NewInvoice_N.TabIndex = 21
        '
        'SuperTabItem3
        '
        Me.SuperTabItem3.AttachedControl = Me.SuperTabControlPanel3
        Me.SuperTabItem3.GlobalItem = False
        Me.SuperTabItem3.Name = "SuperTabItem3"
        Me.SuperTabItem3.Text = "Facture"
        '
        'PanelEx3
        '
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.Controls.Add(Me.TVA)
        Me.PanelEx3.Controls.Add(Me.Total)
        Me.PanelEx3.Controls.Add(Me.LabelX4)
        Me.PanelEx3.Controls.Add(Me.LabelX6)
        Me.PanelEx3.Controls.Add(Me.Total_TVA)
        Me.PanelEx3.Controls.Add(Me.LabelX5)
        Me.PanelEx3.Controls.Add(Me.Total_HTVA)
        Me.PanelEx3.Controls.Add(Me.LabelX30)
        Me.PanelEx3.Controls.Add(Me.LabelX31)
        Me.PanelEx3.Controls.Add(Me.Quantity_Frais)
        Me.PanelEx3.Controls.Add(Me.LabelX19)
        Me.PanelEx3.Controls.Add(Me.Quantity_Prestation)
        Me.PanelEx3.Controls.Add(Me.Total_Frais)
        Me.PanelEx3.Controls.Add(Me.Total_Prestation)
        Me.PanelEx3.Controls.Add(Me.LabelX28)
        Me.PanelEx3.Controls.Add(Me.LabelX13)
        Me.PanelEx3.Controls.Add(Me.Btn_CalculateTotal)
        Me.PanelEx3.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelEx3.Location = New System.Drawing.Point(0, 386)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(1004, 91)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 11
        Me.PanelEx3.Text = " "
        '
        'TVA
        '
        '
        '
        '
        Me.TVA.Border.Class = "TextBoxBorder"
        Me.TVA.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TVA.Location = New System.Drawing.Point(628, 56)
        Me.TVA.Name = "TVA"
        Me.TVA.PreventEnterBeep = True
        Me.TVA.Size = New System.Drawing.Size(100, 22)
        Me.TVA.TabIndex = 53
        Me.TVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Total
        '
        '
        '
        '
        Me.Total.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Total.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Total.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.Total.Increment = 1.0R
        Me.Total.Location = New System.Drawing.Point(889, 62)
        Me.Total.Name = "Total"
        Me.Total.ShowUpDown = True
        Me.Total.Size = New System.Drawing.Size(112, 22)
        Me.Total.TabIndex = 52
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(772, 61)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(105, 23)
        Me.LabelX6.TabIndex = 51
        Me.LabelX6.Text = "Total "
        '
        'Total_TVA
        '
        '
        '
        '
        Me.Total_TVA.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Total_TVA.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Total_TVA.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.Total_TVA.Increment = 1.0R
        Me.Total_TVA.Location = New System.Drawing.Point(889, 34)
        Me.Total_TVA.Name = "Total_TVA"
        Me.Total_TVA.ShowUpDown = True
        Me.Total_TVA.Size = New System.Drawing.Size(112, 22)
        Me.Total_TVA.TabIndex = 50
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(772, 33)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(105, 23)
        Me.LabelX5.TabIndex = 49
        Me.LabelX5.Text = "Total TVA"
        '
        'Total_HTVA
        '
        '
        '
        '
        Me.Total_HTVA.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Total_HTVA.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Total_HTVA.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.Total_HTVA.Increment = 1.0R
        Me.Total_HTVA.Location = New System.Drawing.Point(889, 6)
        Me.Total_HTVA.Name = "Total_HTVA"
        Me.Total_HTVA.ShowUpDown = True
        Me.Total_HTVA.Size = New System.Drawing.Size(112, 22)
        Me.Total_HTVA.TabIndex = 48
        '
        'LabelX30
        '
        '
        '
        '
        Me.LabelX30.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX30.Location = New System.Drawing.Point(772, 5)
        Me.LabelX30.Name = "LabelX30"
        Me.LabelX30.Size = New System.Drawing.Size(105, 23)
        Me.LabelX30.TabIndex = 46
        Me.LabelX30.Text = "Total Hors TVA"
        '
        'LabelX31
        '
        '
        '
        '
        Me.LabelX31.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX31.Location = New System.Drawing.Point(388, 56)
        Me.LabelX31.Name = "LabelX31"
        Me.LabelX31.Size = New System.Drawing.Size(105, 23)
        Me.LabelX31.TabIndex = 44
        Me.LabelX31.Text = "Quantité heure"
        '
        'Quantity_Frais
        '
        '
        '
        '
        Me.Quantity_Frais.Border.Class = "TextBoxBorder"
        Me.Quantity_Frais.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Quantity_Frais.Location = New System.Drawing.Point(499, 56)
        Me.Quantity_Frais.Name = "Quantity_Frais"
        Me.Quantity_Frais.PreventEnterBeep = True
        Me.Quantity_Frais.Size = New System.Drawing.Size(100, 22)
        Me.Quantity_Frais.TabIndex = 45
        Me.Quantity_Frais.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX19
        '
        '
        '
        '
        Me.LabelX19.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX19.Location = New System.Drawing.Point(388, 26)
        Me.LabelX19.Name = "LabelX19"
        Me.LabelX19.Size = New System.Drawing.Size(105, 23)
        Me.LabelX19.TabIndex = 42
        Me.LabelX19.Text = "Quantité heure"
        '
        'Quantity_Prestation
        '
        '
        '
        '
        Me.Quantity_Prestation.Border.Class = "TextBoxBorder"
        Me.Quantity_Prestation.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Quantity_Prestation.Location = New System.Drawing.Point(499, 26)
        Me.Quantity_Prestation.Name = "Quantity_Prestation"
        Me.Quantity_Prestation.PreventEnterBeep = True
        Me.Quantity_Prestation.Size = New System.Drawing.Size(100, 22)
        Me.Quantity_Prestation.TabIndex = 43
        Me.Quantity_Prestation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Total_Frais
        '
        '
        '
        '
        Me.Total_Frais.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Total_Frais.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Total_Frais.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.Total_Frais.Increment = 1.0R
        Me.Total_Frais.Location = New System.Drawing.Point(261, 56)
        Me.Total_Frais.Name = "Total_Frais"
        Me.Total_Frais.ShowUpDown = True
        Me.Total_Frais.Size = New System.Drawing.Size(112, 22)
        Me.Total_Frais.TabIndex = 38
        '
        'Total_Prestation
        '
        '
        '
        '
        Me.Total_Prestation.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Total_Prestation.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Total_Prestation.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.Total_Prestation.Increment = 1.0R
        Me.Total_Prestation.Location = New System.Drawing.Point(261, 28)
        Me.Total_Prestation.Name = "Total_Prestation"
        Me.Total_Prestation.ShowUpDown = True
        Me.Total_Prestation.Size = New System.Drawing.Size(112, 22)
        Me.Total_Prestation.TabIndex = 37
        '
        'LabelX28
        '
        '
        '
        '
        Me.LabelX28.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX28.Location = New System.Drawing.Point(135, 57)
        Me.LabelX28.Name = "LabelX28"
        Me.LabelX28.Size = New System.Drawing.Size(105, 23)
        Me.LabelX28.TabIndex = 36
        Me.LabelX28.Text = "Total Frais"
        '
        'LabelX13
        '
        '
        '
        '
        Me.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX13.Location = New System.Drawing.Point(135, 28)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(105, 23)
        Me.LabelX13.TabIndex = 35
        Me.LabelX13.Text = "Total Prestation:  "
        '
        'Btn_CalculateTotal
        '
        Me.Btn_CalculateTotal.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_CalculateTotal.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Btn_CalculateTotal.Location = New System.Drawing.Point(3, 37)
        Me.Btn_CalculateTotal.Name = "Btn_CalculateTotal"
        Me.Btn_CalculateTotal.Size = New System.Drawing.Size(108, 32)
        Me.Btn_CalculateTotal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_CalculateTotal.TabIndex = 25
        Me.Btn_CalculateTotal.Text = "Calculer Total"
        '
        'Bar1
        '
        Me.Bar1.AntiAlias = True
        Me.Bar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Bar1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Bar1.Images = Me.IL_32
        Me.Bar1.IsMaximized = False
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonX1, Me.Btn_Add, Me.ButtonX2, Me.ButtonItem1, Me.ButtonX4})
        Me.Bar1.Location = New System.Drawing.Point(0, 0)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Size = New System.Drawing.Size(1004, 49)
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar1.TabIndex = 8
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
        Me.IL_32.Images.SetKeyName(19, "copy.png")
        Me.IL_32.Images.SetKeyName(20, "cross.png")
        Me.IL_32.Images.SetKeyName(21, "delete.png")
        Me.IL_32.Images.SetKeyName(22, "diskette.png")
        Me.IL_32.Images.SetKeyName(23, "document.png")
        Me.IL_32.Images.SetKeyName(24, "door.png")
        Me.IL_32.Images.SetKeyName(25, "down.png")
        Me.IL_32.Images.SetKeyName(26, "edit.png")
        Me.IL_32.Images.SetKeyName(27, "fast_forward.png")
        Me.IL_32.Images.SetKeyName(28, "file.png")
        Me.IL_32.Images.SetKeyName(29, "first.png")
        Me.IL_32.Images.SetKeyName(30, "folder.png")
        Me.IL_32.Images.SetKeyName(31, "games.png")
        Me.IL_32.Images.SetKeyName(32, "gear.png")
        Me.IL_32.Images.SetKeyName(33, "group.png")
        Me.IL_32.Images.SetKeyName(34, "hand.png")
        Me.IL_32.Images.SetKeyName(35, "help.png")
        Me.IL_32.Images.SetKeyName(36, "home.png")
        Me.IL_32.Images.SetKeyName(37, "hourglass.png")
        Me.IL_32.Images.SetKeyName(38, "info.png")
        Me.IL_32.Images.SetKeyName(39, "last.png")
        Me.IL_32.Images.SetKeyName(40, "light_bulb.png")
        Me.IL_32.Images.SetKeyName(41, "lock.png")
        Me.IL_32.Images.SetKeyName(42, "mail.png")
        Me.IL_32.Images.SetKeyName(43, "mailbox.png")
        Me.IL_32.Images.SetKeyName(44, "microphone.png")
        Me.IL_32.Images.SetKeyName(45, "monitor.png")
        Me.IL_32.Images.SetKeyName(46, "music.png")
        Me.IL_32.Images.SetKeyName(47, "network.png")
        Me.IL_32.Images.SetKeyName(48, "next.png")
        Me.IL_32.Images.SetKeyName(49, "paste.png")
        Me.IL_32.Images.SetKeyName(50, "pause.png")
        Me.IL_32.Images.SetKeyName(51, "pen.png")
        Me.IL_32.Images.SetKeyName(52, "phone.png")
        Me.IL_32.Images.SetKeyName(53, "play.png")
        Me.IL_32.Images.SetKeyName(54, "preview.png")
        Me.IL_32.Images.SetKeyName(55, "printer.png")
        Me.IL_32.Images.SetKeyName(56, "pyramid.png")
        Me.IL_32.Images.SetKeyName(57, "recycle_bin.png")
        Me.IL_32.Images.SetKeyName(58, "refresh.png")
        Me.IL_32.Images.SetKeyName(59, "reload.png")
        Me.IL_32.Images.SetKeyName(60, "rewind.png")
        Me.IL_32.Images.SetKeyName(61, "scissors.png")
        Me.IL_32.Images.SetKeyName(62, "shopping_cart.png")
        Me.IL_32.Images.SetKeyName(63, "speech_balloon.png")
        Me.IL_32.Images.SetKeyName(64, "sphere.png")
        Me.IL_32.Images.SetKeyName(65, "square.png")
        Me.IL_32.Images.SetKeyName(66, "star.png")
        Me.IL_32.Images.SetKeyName(67, "stats.png")
        Me.IL_32.Images.SetKeyName(68, "stop.png")
        Me.IL_32.Images.SetKeyName(69, "system.png")
        Me.IL_32.Images.SetKeyName(70, "unlock.png")
        Me.IL_32.Images.SetKeyName(71, "up.png")
        Me.IL_32.Images.SetKeyName(72, "user.png")
        Me.IL_32.Images.SetKeyName(73, "warning.png")
        Me.IL_32.Images.SetKeyName(74, "webcam.png")
        Me.IL_32.Images.SetKeyName(75, "window.png")
        Me.IL_32.Images.SetKeyName(76, "windows.png")
        Me.IL_32.Images.SetKeyName(77, "windows_restore.png")
        Me.IL_32.Images.SetKeyName(78, "wizard.png")
        Me.IL_32.Images.SetKeyName(79, "world.png")
        Me.IL_32.Images.SetKeyName(80, "world_upload.png")
        Me.IL_32.Images.SetKeyName(81, "zoom.png")
        '
        'ButtonX1
        '
        Me.ButtonX1.ImageIndex = 23
        Me.ButtonX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Text = "Nouveau"
        '
        'Btn_Add
        '
        Me.Btn_Add.ImageIndex = 0
        Me.Btn_Add.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Text = "Ajouter"
        '
        'ButtonX2
        '
        Me.ButtonX2.ImageIndex = 22
        Me.ButtonX2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Text = "Sauver"
        '
        'ButtonItem1
        '
        Me.ButtonItem1.ImageIndex = 57
        Me.ButtonItem1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.Text = "Effacer"
        '
        'ButtonX4
        '
        Me.ButtonX4.ImageIndex = 58
        Me.ButtonX4.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonX4.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far
        Me.ButtonX4.Name = "ButtonX4"
        Me.ButtonX4.Text = "Rafraichir"
        '
        'IL_
        '
        Me.IL_.ImageStream = CType(resources.GetObject("IL_.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IL_.TransparentColor = System.Drawing.Color.Transparent
        Me.IL_.Images.SetKeyName(0, "add.png")
        Me.IL_.Images.SetKeyName(1, "administrator.png")
        Me.IL_.Images.SetKeyName(2, "attachment.png")
        Me.IL_.Images.SetKeyName(3, "binoculars.png")
        Me.IL_.Images.SetKeyName(4, "book.png")
        Me.IL_.Images.SetKeyName(5, "briefcase.png")
        Me.IL_.Images.SetKeyName(6, "brush.png")
        Me.IL_.Images.SetKeyName(7, "calculator.png")
        Me.IL_.Images.SetKeyName(8, "calendar.png")
        Me.IL_.Images.SetKeyName(9, "camera.png")
        Me.IL_.Images.SetKeyName(10, "cancel.png")
        Me.IL_.Images.SetKeyName(11, "chat.png")
        Me.IL_.Images.SetKeyName(12, "check_mark.png")
        Me.IL_.Images.SetKeyName(13, "clients.png")
        Me.IL_.Images.SetKeyName(14, "clip.png")
        Me.IL_.Images.SetKeyName(15, "clipboard.png")
        Me.IL_.Images.SetKeyName(16, "clock.png")
        Me.IL_.Images.SetKeyName(17, "close.png")
        Me.IL_.Images.SetKeyName(18, "copy.png")
        Me.IL_.Images.SetKeyName(19, "cross.png")
        Me.IL_.Images.SetKeyName(20, "delete.png")
        Me.IL_.Images.SetKeyName(21, "diskette.png")
        Me.IL_.Images.SetKeyName(22, "document.png")
        Me.IL_.Images.SetKeyName(23, "door.png")
        Me.IL_.Images.SetKeyName(24, "edit.png")
        Me.IL_.Images.SetKeyName(25, "fast_forward.png")
        Me.IL_.Images.SetKeyName(26, "file.png")
        Me.IL_.Images.SetKeyName(27, "first.png")
        Me.IL_.Images.SetKeyName(28, "folder.png")
        Me.IL_.Images.SetKeyName(29, "games.png")
        Me.IL_.Images.SetKeyName(30, "gear.png")
        Me.IL_.Images.SetKeyName(31, "group.png")
        Me.IL_.Images.SetKeyName(32, "hand.png")
        Me.IL_.Images.SetKeyName(33, "help.png")
        Me.IL_.Images.SetKeyName(34, "home.png")
        Me.IL_.Images.SetKeyName(35, "hourglass.png")
        Me.IL_.Images.SetKeyName(36, "info.png")
        Me.IL_.Images.SetKeyName(37, "last.png")
        Me.IL_.Images.SetKeyName(38, "light_bulb.png")
        Me.IL_.Images.SetKeyName(39, "lock.png")
        Me.IL_.Images.SetKeyName(40, "mail.png")
        Me.IL_.Images.SetKeyName(41, "mailbox.png")
        Me.IL_.Images.SetKeyName(42, "microphone.png")
        Me.IL_.Images.SetKeyName(43, "monitor.png")
        Me.IL_.Images.SetKeyName(44, "music.png")
        Me.IL_.Images.SetKeyName(45, "network.png")
        Me.IL_.Images.SetKeyName(46, "next.png")
        Me.IL_.Images.SetKeyName(47, "paste.png")
        Me.IL_.Images.SetKeyName(48, "pause.png")
        Me.IL_.Images.SetKeyName(49, "pencil.png")
        Me.IL_.Images.SetKeyName(50, "phone.png")
        Me.IL_.Images.SetKeyName(51, "play.png")
        Me.IL_.Images.SetKeyName(52, "preview.png")
        Me.IL_.Images.SetKeyName(53, "printer.png")
        Me.IL_.Images.SetKeyName(54, "pyramid.png")
        Me.IL_.Images.SetKeyName(55, "recycle_bin.png")
        Me.IL_.Images.SetKeyName(56, "refresh.png")
        Me.IL_.Images.SetKeyName(57, "reload.png")
        Me.IL_.Images.SetKeyName(58, "rewinding.png")
        Me.IL_.Images.SetKeyName(59, "scissors.png")
        Me.IL_.Images.SetKeyName(60, "shopping_cart.png")
        Me.IL_.Images.SetKeyName(61, "speech_balloon.png")
        Me.IL_.Images.SetKeyName(62, "sphere.png")
        Me.IL_.Images.SetKeyName(63, "square.png")
        Me.IL_.Images.SetKeyName(64, "star.png")
        Me.IL_.Images.SetKeyName(65, "stats.png")
        Me.IL_.Images.SetKeyName(66, "stop.png")
        Me.IL_.Images.SetKeyName(67, "system.png")
        Me.IL_.Images.SetKeyName(68, "unlock.png")
        Me.IL_.Images.SetKeyName(69, "user.png")
        Me.IL_.Images.SetKeyName(70, "warning.png")
        Me.IL_.Images.SetKeyName(71, "webcam.png")
        Me.IL_.Images.SetKeyName(72, "window.png")
        Me.IL_.Images.SetKeyName(73, "windows.png")
        Me.IL_.Images.SetKeyName(74, "windows_restore.png")
        Me.IL_.Images.SetKeyName(75, "wizard.png")
        Me.IL_.Images.SetKeyName(76, "world.png")
        Me.IL_.Images.SetKeyName(77, "world_upload.png")
        Me.IL_.Images.SetKeyName(78, "zoom.png")
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerColorTint = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Black
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer)))
        '
        'IL_Client
        '
        Me.IL_Client.ImageStream = CType(resources.GetObject("IL_Client.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IL_Client.TransparentColor = System.Drawing.Color.Transparent
        Me.IL_Client.Images.SetKeyName(0, "add.png")
        Me.IL_Client.Images.SetKeyName(1, "administrator.png")
        Me.IL_Client.Images.SetKeyName(2, "attachment.png")
        Me.IL_Client.Images.SetKeyName(3, "back.png")
        Me.IL_Client.Images.SetKeyName(4, "binoculars.png")
        Me.IL_Client.Images.SetKeyName(5, "book.png")
        Me.IL_Client.Images.SetKeyName(6, "briefcase.png")
        Me.IL_Client.Images.SetKeyName(7, "brush.png")
        Me.IL_Client.Images.SetKeyName(8, "calculator.png")
        Me.IL_Client.Images.SetKeyName(9, "calendar.png")
        Me.IL_Client.Images.SetKeyName(10, "camera.png")
        Me.IL_Client.Images.SetKeyName(11, "cancel.png")
        Me.IL_Client.Images.SetKeyName(12, "chat.png")
        Me.IL_Client.Images.SetKeyName(13, "check_mark.png")
        Me.IL_Client.Images.SetKeyName(14, "clients.png")
        Me.IL_Client.Images.SetKeyName(15, "clip.png")
        Me.IL_Client.Images.SetKeyName(16, "clipboard.png")
        Me.IL_Client.Images.SetKeyName(17, "clock.png")
        Me.IL_Client.Images.SetKeyName(18, "close.png")
        Me.IL_Client.Images.SetKeyName(19, "copy.png")
        Me.IL_Client.Images.SetKeyName(20, "cross.png")
        Me.IL_Client.Images.SetKeyName(21, "delete.png")
        Me.IL_Client.Images.SetKeyName(22, "diskette.png")
        Me.IL_Client.Images.SetKeyName(23, "document.png")
        Me.IL_Client.Images.SetKeyName(24, "door.png")
        Me.IL_Client.Images.SetKeyName(25, "down.png")
        Me.IL_Client.Images.SetKeyName(26, "edit.png")
        Me.IL_Client.Images.SetKeyName(27, "fast_forward.png")
        Me.IL_Client.Images.SetKeyName(28, "file.png")
        Me.IL_Client.Images.SetKeyName(29, "first.png")
        Me.IL_Client.Images.SetKeyName(30, "folder.png")
        Me.IL_Client.Images.SetKeyName(31, "games.png")
        Me.IL_Client.Images.SetKeyName(32, "gear.png")
        Me.IL_Client.Images.SetKeyName(33, "group.png")
        Me.IL_Client.Images.SetKeyName(34, "hand.png")
        Me.IL_Client.Images.SetKeyName(35, "help.png")
        Me.IL_Client.Images.SetKeyName(36, "home.png")
        Me.IL_Client.Images.SetKeyName(37, "hourglass.png")
        Me.IL_Client.Images.SetKeyName(38, "info.png")
        Me.IL_Client.Images.SetKeyName(39, "last.png")
        Me.IL_Client.Images.SetKeyName(40, "light_bulb.png")
        Me.IL_Client.Images.SetKeyName(41, "lock.png")
        Me.IL_Client.Images.SetKeyName(42, "mail.png")
        Me.IL_Client.Images.SetKeyName(43, "mailbox.png")
        Me.IL_Client.Images.SetKeyName(44, "microphone.png")
        Me.IL_Client.Images.SetKeyName(45, "monitor.png")
        Me.IL_Client.Images.SetKeyName(46, "music.png")
        Me.IL_Client.Images.SetKeyName(47, "network.png")
        Me.IL_Client.Images.SetKeyName(48, "next.png")
        Me.IL_Client.Images.SetKeyName(49, "paste.png")
        Me.IL_Client.Images.SetKeyName(50, "pause.png")
        Me.IL_Client.Images.SetKeyName(51, "pen.png")
        Me.IL_Client.Images.SetKeyName(52, "phone.png")
        Me.IL_Client.Images.SetKeyName(53, "play.png")
        Me.IL_Client.Images.SetKeyName(54, "preview.png")
        Me.IL_Client.Images.SetKeyName(55, "printer.png")
        Me.IL_Client.Images.SetKeyName(56, "pyramid.png")
        Me.IL_Client.Images.SetKeyName(57, "recycle_bin.png")
        Me.IL_Client.Images.SetKeyName(58, "refresh.png")
        Me.IL_Client.Images.SetKeyName(59, "reload.png")
        Me.IL_Client.Images.SetKeyName(60, "rewind.png")
        Me.IL_Client.Images.SetKeyName(61, "scissors.png")
        Me.IL_Client.Images.SetKeyName(62, "shopping_cart.png")
        Me.IL_Client.Images.SetKeyName(63, "speech_balloon.png")
        Me.IL_Client.Images.SetKeyName(64, "sphere.png")
        Me.IL_Client.Images.SetKeyName(65, "square.png")
        Me.IL_Client.Images.SetKeyName(66, "star.png")
        Me.IL_Client.Images.SetKeyName(67, "stats.png")
        Me.IL_Client.Images.SetKeyName(68, "stop.png")
        Me.IL_Client.Images.SetKeyName(69, "system.png")
        Me.IL_Client.Images.SetKeyName(70, "unlock.png")
        Me.IL_Client.Images.SetKeyName(71, "up.png")
        Me.IL_Client.Images.SetKeyName(72, "user.png")
        Me.IL_Client.Images.SetKeyName(73, "warning.png")
        Me.IL_Client.Images.SetKeyName(74, "webcam.png")
        Me.IL_Client.Images.SetKeyName(75, "window.png")
        Me.IL_Client.Images.SetKeyName(76, "windows.png")
        Me.IL_Client.Images.SetKeyName(77, "windows_restore.png")
        Me.IL_Client.Images.SetKeyName(78, "wizard.png")
        Me.IL_Client.Images.SetKeyName(79, "world.png")
        Me.IL_Client.Images.SetKeyName(80, "world_upload.png")
        Me.IL_Client.Images.SetKeyName(81, "zoom.png")
        '
        'PrestationViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelEx2)
        Me.Controls.Add(Me.PanelEx1)
        Me.Controls.Add(Me.Bar1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PrestationViewer"
        Me.Size = New System.Drawing.Size(1004, 612)
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.DateEnd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateStart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx4.ResumeLayout(False)
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControl1.ResumeLayout(False)
        Me.SuperTabControlPanel1.ResumeLayout(False)
        Me.PanelEx5.ResumeLayout(False)
        Me.PanelEx7.ResumeLayout(False)
        Me.SuperTabControlPanel2.ResumeLayout(False)
        Me.SuperTabControlPanel3.ResumeLayout(False)
        Me.PanelEx8.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.NewInvoice_N, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx3.ResumeLayout(False)
        CType(Me.Total, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Total_TVA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Total_HTVA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Total_Frais, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Total_Prestation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents DateEnd As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DateStart As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Mandat As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx4 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents SuperTabControl1 As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents SuperTabControlPanel1 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents PanelEx5 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents SuperTabItem1 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents PanelEx6 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents SuperTabItem2 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Btn_Save As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Invoice_Filter As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PanelEx7 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Btn_Select_All As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Btn_Deselect_All As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Total As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Total_TVA As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Total_HTVA As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX30 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX31 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Quantity_Frais As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX19 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Quantity_Prestation As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Total_Frais As DevComponents.Editors.DoubleInput
    Friend WithEvents Total_Prestation As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX28 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Btn_CalculateTotal As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents IL_ As ImageList
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Btn_Add As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonX4 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents IL_32 As ImageList
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents IL_Client As ImageList
    Friend WithEvents SuperTabControlPanel3 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents PanelEx8 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents NewInvoice_Adresse As DevComponents.DotNetBar.Controls.RichTextBoxEx
    Friend WithEvents NewInvoice_Libellé As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX33 As DevComponents.DotNetBar.LabelX
    Friend WithEvents NewInvoice_Concerne As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem7 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem8 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem9 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem10 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem11 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem12 As DevComponents.Editors.ComboItem
    Friend WithEvents LabelX27 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX23 As DevComponents.DotNetBar.LabelX
    Friend WithEvents NewInvoice_N As DevComponents.Editors.IntegerInput
    Friend WithEvents SuperTabItem3 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents Cb_Société As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents SGC As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents TVA As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Btn_Print_Empty As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Btn_Print_Simple As DevComponents.DotNetBar.ButtonX
End Class
