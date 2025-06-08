<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.Input_Price = New DevComponents.Editors.DoubleInput()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.Input_DateIn = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Btn_Add = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.labelX5 = New DevComponents.DotNetBar.LabelX()
        Me.labelX4 = New DevComponents.DotNetBar.LabelX()
        Me.labelX3 = New DevComponents.DotNetBar.LabelX()
        Me.labelX2 = New DevComponents.DotNetBar.LabelX()
        Me.Input_Collaborateur = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Input_Code = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.SGC = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.Btn_Save = New DevComponents.DotNetBar.ButtonX()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuperTabControl1 = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.SuperTabItem1 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel3 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.PropTarif = New DevComponents.DotNetBar.AdvPropertyGrid()
        Me.SuperTabItem3 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.PropCurrent = New DevComponents.DotNetBar.AdvPropertyGrid()
        Me.SuperTabItem2 = New DevComponents.DotNetBar.SuperTabItem()
        Me.BW = New System.ComponentModel.BackgroundWorker()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX4 = New DevComponents.DotNetBar.ButtonX()
        Me.vcr1 = New SuperGridDemo.VcrControl '.DevComponents.SuperGridDemo.VcrControl()
        Me.groupBox2.SuspendLayout()
        CType(Me.Input_Price, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Input_DateIn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControl1.SuspendLayout()
        Me.SuperTabControlPanel1.SuspendLayout()
        Me.SuperTabControlPanel3.SuspendLayout()
        CType(Me.PropTarif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControlPanel2.SuspendLayout()
        CType(Me.PropCurrent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBox2
        '
        Me.groupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBox2.Controls.Add(Me.ButtonX3)
        Me.groupBox2.Controls.Add(Me.Input_Price)
        Me.groupBox2.Controls.Add(Me.ButtonX2)
        Me.groupBox2.Controls.Add(Me.Input_DateIn)
        Me.groupBox2.Controls.Add(Me.Btn_Add)
        Me.groupBox2.Controls.Add(Me.ButtonX1)
        Me.groupBox2.Controls.Add(Me.vcr1)
        Me.groupBox2.Controls.Add(Me.labelX5)
        Me.groupBox2.Controls.Add(Me.labelX4)
        Me.groupBox2.Controls.Add(Me.labelX3)
        Me.groupBox2.Controls.Add(Me.labelX2)
        Me.groupBox2.Controls.Add(Me.Input_Collaborateur)
        Me.groupBox2.Controls.Add(Me.Input_Code)
        Me.groupBox2.Location = New System.Drawing.Point(696, 72)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(332, 353)
        Me.groupBox2.TabIndex = 29
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Row Data"
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
        Me.Input_Price.Location = New System.Drawing.Point(175, 158)
        Me.Input_Price.Name = "Input_Price"
        Me.Input_Price.ShowUpDown = True
        Me.Input_Price.Size = New System.Drawing.Size(141, 20)
        Me.Input_Price.TabIndex = 2
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(192, 19)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(63, 23)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 38
        Me.ButtonX2.Text = "Save"
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
        Me.Input_DateIn.Location = New System.Drawing.Point(39, 209)
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
        Me.Input_DateIn.Size = New System.Drawing.Size(100, 20)
        Me.Input_DateIn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Input_DateIn.TabIndex = 3
        '
        'Btn_Add
        '
        Me.Btn_Add.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_Add.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Add.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Btn_Add.Enabled = False
        Me.Btn_Add.Location = New System.Drawing.Point(123, 19)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Size = New System.Drawing.Size(63, 23)
        Me.Btn_Add.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_Add.TabIndex = 36
        Me.Btn_Add.Text = "Add"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(16, 19)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(63, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 35
        Me.ButtonX1.Text = "New"
        '
        'labelX5
        '
        Me.labelX5.AutoSize = True
        '
        '
        '
        Me.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX5.Location = New System.Drawing.Point(155, 137)
        Me.labelX5.Name = "labelX5"
        Me.labelX5.Size = New System.Drawing.Size(22, 15)
        Me.labelX5.TabIndex = 26
        Me.labelX5.Text = "Prix"
        '
        'labelX4
        '
        Me.labelX4.AutoSize = True
        '
        '
        '
        Me.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX4.Location = New System.Drawing.Point(20, 188)
        Me.labelX4.Name = "labelX4"
        Me.labelX4.Size = New System.Drawing.Size(38, 15)
        Me.labelX4.TabIndex = 25
        Me.labelX4.Text = "Date In"
        '
        'labelX3
        '
        Me.labelX3.AutoSize = True
        '
        '
        '
        Me.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX3.Location = New System.Drawing.Point(20, 137)
        Me.labelX3.Name = "labelX3"
        Me.labelX3.Size = New System.Drawing.Size(69, 15)
        Me.labelX3.TabIndex = 24
        Me.labelX3.Text = "Collaborateur"
        '
        'labelX2
        '
        Me.labelX2.AutoSize = True
        '
        '
        '
        Me.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX2.Location = New System.Drawing.Point(20, 90)
        Me.labelX2.Name = "labelX2"
        Me.labelX2.Size = New System.Drawing.Size(29, 15)
        Me.labelX2.TabIndex = 23
        Me.labelX2.Text = "Code"
        '
        'Input_Collaborateur
        '
        Me.Input_Collaborateur.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.Input_Collaborateur.Border.Class = "TextBoxBorder"
        Me.Input_Collaborateur.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_Collaborateur.Location = New System.Drawing.Point(39, 158)
        Me.Input_Collaborateur.Name = "Input_Collaborateur"
        Me.Input_Collaborateur.Size = New System.Drawing.Size(100, 20)
        Me.Input_Collaborateur.TabIndex = 1
        '
        'Input_Code
        '
        Me.Input_Code.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.Input_Code.Border.Class = "TextBoxBorder"
        Me.Input_Code.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_Code.Location = New System.Drawing.Point(39, 111)
        Me.Input_Code.Name = "Input_Code"
        Me.Input_Code.Size = New System.Drawing.Size(100, 20)
        Me.Input_Code.TabIndex = 0
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
        Me.SGC.PrimaryGrid.AllowRowDelete = True
        Me.SGC.PrimaryGrid.AllowRowInsert = True
        Me.SGC.PrimaryGrid.AutoHideDeletedRows = False
        '
        '
        '
        Me.SGC.PrimaryGrid.ColumnHeader.RowHeight = 30
        Me.SGC.PrimaryGrid.NoRowsText = "Select a DataSource from the list to the right to populate the grid."
        Me.SGC.PrimaryGrid.ShowRowGridIndex = True
        '
        '
        '
        Me.SGC.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled
        Me.SGC.Size = New System.Drawing.Size(672, 460)
        Me.SGC.TabIndex = 30
        Me.SGC.Text = "superGridControl1"
        '
        'Btn_Save
        '
        Me.Btn_Save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_Save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Btn_Save.Location = New System.Drawing.Point(12, 21)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Size = New System.Drawing.Size(70, 23)
        Me.Btn_Save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_Save.TabIndex = 34
        Me.Btn_Save.Text = "Save"
        '
        'Timer1
        '
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
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel3)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel2)
        Me.SuperTabControl1.Location = New System.Drawing.Point(16, 72)
        Me.SuperTabControl1.Name = "SuperTabControl1"
        Me.SuperTabControl1.ReorderTabsEnabled = True
        Me.SuperTabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SuperTabControl1.SelectedTabIndex = 2
        Me.SuperTabControl1.Size = New System.Drawing.Size(672, 485)
        Me.SuperTabControl1.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabControl1.TabIndex = 35
        Me.SuperTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabItem1, Me.SuperTabItem2, Me.SuperTabItem3})
        Me.SuperTabControl1.Text = "SuperTabControl1"
        '
        'SuperTabControlPanel1
        '
        Me.SuperTabControlPanel1.Controls.Add(Me.SGC)
        Me.SuperTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel1.Location = New System.Drawing.Point(0, 25)
        Me.SuperTabControlPanel1.Name = "SuperTabControlPanel1"
        Me.SuperTabControlPanel1.Size = New System.Drawing.Size(672, 460)
        Me.SuperTabControlPanel1.TabIndex = 1
        Me.SuperTabControlPanel1.TabItem = Me.SuperTabItem1
        '
        'SuperTabItem1
        '
        Me.SuperTabItem1.AttachedControl = Me.SuperTabControlPanel1
        Me.SuperTabItem1.GlobalItem = False
        Me.SuperTabItem1.Name = "SuperTabItem1"
        Me.SuperTabItem1.Text = "List"
        '
        'SuperTabControlPanel3
        '
        Me.SuperTabControlPanel3.Controls.Add(Me.PropTarif)
        Me.SuperTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel3.Location = New System.Drawing.Point(0, 25)
        Me.SuperTabControlPanel3.Name = "SuperTabControlPanel3"
        Me.SuperTabControlPanel3.Size = New System.Drawing.Size(672, 460)
        Me.SuperTabControlPanel3.TabIndex = 0
        Me.SuperTabControlPanel3.TabItem = Me.SuperTabItem3
        '
        'PropTarif
        '
        Me.PropTarif.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PropTarif.GridLinesColor = System.Drawing.Color.WhiteSmoke
        Me.PropTarif.Location = New System.Drawing.Point(0, 0)
        Me.PropTarif.Name = "PropTarif"
        Me.PropTarif.Size = New System.Drawing.Size(672, 460)
        Me.PropTarif.TabIndex = 0
        Me.PropTarif.Text = "AdvPropertyGrid1"
        '
        'SuperTabItem3
        '
        Me.SuperTabItem3.AttachedControl = Me.SuperTabControlPanel3
        Me.SuperTabItem3.GlobalItem = False
        Me.SuperTabItem3.Name = "SuperTabItem3"
        Me.SuperTabItem3.Text = "Tarif"
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.Controls.Add(Me.PropCurrent)
        Me.SuperTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel2.Location = New System.Drawing.Point(0, 25)
        Me.SuperTabControlPanel2.Name = "SuperTabControlPanel2"
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(672, 460)
        Me.SuperTabControlPanel2.TabIndex = 0
        Me.SuperTabControlPanel2.TabItem = Me.SuperTabItem2
        '
        'PropCurrent
        '
        Me.PropCurrent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PropCurrent.GridLinesColor = System.Drawing.Color.WhiteSmoke
        Me.PropCurrent.Location = New System.Drawing.Point(0, 0)
        Me.PropCurrent.Name = "PropCurrent"
        Me.PropCurrent.Size = New System.Drawing.Size(672, 460)
        Me.PropCurrent.TabIndex = 0
        Me.PropCurrent.Text = "AdvPropertyGrid1"
        '
        'SuperTabItem2
        '
        Me.SuperTabItem2.AttachedControl = Me.SuperTabControlPanel2
        Me.SuperTabItem2.GlobalItem = False
        Me.SuperTabItem2.Name = "SuperTabItem2"
        Me.SuperTabItem2.Text = "Current"
        '
        'BW
        '
        Me.BW.WorkerReportsProgress = True
        Me.BW.WorkerSupportsCancellation = True
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Location = New System.Drawing.Point(269, 19)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(63, 23)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.TabIndex = 41
        Me.ButtonX3.Text = "Delete"
        '
        'ButtonX4
        '
        Me.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX4.Location = New System.Drawing.Point(101, 21)
        Me.ButtonX4.Name = "ButtonX4"
        Me.ButtonX4.Size = New System.Drawing.Size(70, 23)
        Me.ButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX4.TabIndex = 36
        Me.ButtonX4.Text = "Refresh"
        '
        'vcr1
        '
        Me.vcr1.BackColor = System.Drawing.Color.Transparent
        Me.vcr1.Location = New System.Drawing.Point(16, 235)
        Me.vcr1.Name = "vcr1"
        Me.vcr1.Size = New System.Drawing.Size(310, 36)
        Me.vcr1.TabIndex = 34
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1057, 598)
        Me.Controls.Add(Me.ButtonX4)
        Me.Controls.Add(Me.SuperTabControl1)
        Me.Controls.Add(Me.Btn_Save)
        Me.Controls.Add(Me.groupBox2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        CType(Me.Input_Price, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Input_DateIn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControl1.ResumeLayout(False)
        Me.SuperTabControlPanel1.ResumeLayout(False)
        Me.SuperTabControlPanel3.ResumeLayout(False)
        CType(Me.PropTarif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControlPanel2.ResumeLayout(False)
        CType(Me.PropCurrent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents groupBox2 As GroupBox
    Private WithEvents labelX5 As DevComponents.DotNetBar.LabelX
    Private WithEvents labelX4 As DevComponents.DotNetBar.LabelX
    Private WithEvents labelX3 As DevComponents.DotNetBar.LabelX
    Private WithEvents labelX2 As DevComponents.DotNetBar.LabelX
    Private WithEvents Input_Collaborateur As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents Input_Code As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents SGC As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents vcr1 As SuperGridDemo.VcrControl
    Private WithEvents Btn_Save As DevComponents.DotNetBar.ButtonX
    Private WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Private WithEvents Btn_Add As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SuperTabControl1 As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents SuperTabControlPanel1 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItem1 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel3 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents PropTarif As DevComponents.DotNetBar.AdvPropertyGrid
    Friend WithEvents SuperTabItem3 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents PropCurrent As DevComponents.DotNetBar.AdvPropertyGrid
    Friend WithEvents SuperTabItem2 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents Input_DateIn As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Private WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Input_Price As DevComponents.Editors.DoubleInput
    Friend WithEvents BW As System.ComponentModel.BackgroundWorker
    Private WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Private WithEvents ButtonX4 As DevComponents.DotNetBar.ButtonX
End Class
