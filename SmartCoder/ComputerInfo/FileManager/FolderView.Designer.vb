<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FolderView
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
        Me.PanelEx18 = New DevComponents.DotNetBar.PanelEx()
        Me.Title = New DevComponents.DotNetBar.LabelX()
        Me.PanelEx19 = New DevComponents.DotNetBar.PanelEx()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btn_Define_Répertoire = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.SuperTabControl1 = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabItem1 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.Input_Dir = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.SuperTabItem2 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.PanelEx4 = New DevComponents.DotNetBar.PanelEx()
        Me.SGC = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.SuperTabItem3 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel3 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.PanelEx5 = New DevComponents.DotNetBar.PanelEx()
        Me.AdvPropertyGrid1 = New DevComponents.DotNetBar.AdvPropertyGrid()
        Me.PanelEx6 = New DevComponents.DotNetBar.PanelEx()
        Me.Pbar = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.L_Percentage = New DevComponents.DotNetBar.LabelX()
        Me.PanelEx7 = New DevComponents.DotNetBar.PanelEx()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.Input_Search = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Btn_Index = New DevComponents.DotNetBar.ButtonX()
        Me.BW = New System.ComponentModel.BackgroundWorker()
        Me.Btn_Search_All = New DevComponents.DotNetBar.ButtonItem()
        Me.LabelItem1 = New DevComponents.DotNetBar.LabelItem()
        Me.Include_Dir = New DevComponents.DotNetBar.SwitchButtonItem()
        Me.PanelEx18.SuspendLayout()
        Me.PanelEx19.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControl1.SuspendLayout()
        Me.SuperTabControlPanel1.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        Me.SuperTabControlPanel2.SuspendLayout()
        Me.PanelEx4.SuspendLayout()
        Me.SuperTabControlPanel3.SuspendLayout()
        Me.PanelEx5.SuspendLayout()
        CType(Me.AdvPropertyGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx6.SuspendLayout()
        Me.PanelEx7.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx18
        '
        Me.PanelEx18.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx18.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx18.Controls.Add(Me.Title)
        Me.PanelEx18.Controls.Add(Me.PanelEx19)
        Me.PanelEx18.Controls.Add(Me.Btn_Define_Répertoire)
        Me.PanelEx18.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx18.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx18.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx18.Name = "PanelEx18"
        Me.PanelEx18.Size = New System.Drawing.Size(393, 33)
        Me.PanelEx18.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx18.Style.BackColor1.Color = System.Drawing.Color.White
        Me.PanelEx18.Style.BackColor2.Color = System.Drawing.Color.White
        Me.PanelEx18.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx18.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx18.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx18.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx18.Style.GradientAngle = 90
        Me.PanelEx18.TabIndex = 19
        Me.PanelEx18.Text = " "
        '
        'Title
        '
        '
        '
        '
        Me.Title.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Title.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Title.FontBold = True
        Me.Title.Location = New System.Drawing.Point(47, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(271, 33)
        Me.Title.TabIndex = 1
        Me.Title.Text = "  Répertoire du Client"
        '
        'PanelEx19
        '
        Me.PanelEx19.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx19.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx19.Controls.Add(Me.PictureBox1)
        Me.PanelEx19.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx19.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelEx19.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx19.Name = "PanelEx19"
        Me.PanelEx19.Size = New System.Drawing.Size(47, 33)
        Me.PanelEx19.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx19.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx19.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx19.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx19.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx19.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx19.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx19.Style.GradientAngle = 90
        Me.PanelEx19.TabIndex = 8
        Me.PanelEx19.Text = " "
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.SmartCoder.My.Resources.Resources.folder1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(47, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Btn_Define_Répertoire
        '
        Me.Btn_Define_Répertoire.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_Define_Répertoire.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.Btn_Define_Répertoire.Dock = System.Windows.Forms.DockStyle.Right
        Me.Btn_Define_Répertoire.Location = New System.Drawing.Point(318, 0)
        Me.Btn_Define_Répertoire.Name = "Btn_Define_Répertoire"
        Me.Btn_Define_Répertoire.Size = New System.Drawing.Size(75, 33)
        Me.Btn_Define_Répertoire.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_Define_Répertoire.TabIndex = 2
        Me.Btn_Define_Répertoire.Text = "Define..."
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.SuperTabControl1)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 33)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(393, 174)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 20
        Me.PanelEx1.Text = " "
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.Pbar)
        Me.PanelEx2.Controls.Add(Me.L_Percentage)
        Me.PanelEx2.Controls.Add(Me.PanelEx6)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelEx2.Location = New System.Drawing.Point(0, 207)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(393, 38)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 27
        Me.PanelEx2.Text = " "
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
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel2)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel3)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel1)
        Me.SuperTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControl1.Name = "SuperTabControl1"
        Me.SuperTabControl1.ReorderTabsEnabled = True
        Me.SuperTabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.SuperTabControl1.SelectedTabIndex = 1
        Me.SuperTabControl1.Size = New System.Drawing.Size(393, 174)
        Me.SuperTabControl1.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabControl1.TabIndex = 12
        Me.SuperTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabItem1, Me.SuperTabItem2, Me.SuperTabItem3})
        Me.SuperTabControl1.Text = "SuperTabControl1"
        '
        'SuperTabItem1
        '
        Me.SuperTabItem1.AttachedControl = Me.SuperTabControlPanel1
        Me.SuperTabItem1.GlobalItem = False
        Me.SuperTabItem1.Name = "SuperTabItem1"
        Me.SuperTabItem1.Text = "Répertoire"
        '
        'SuperTabControlPanel1
        '
        Me.SuperTabControlPanel1.Controls.Add(Me.PanelEx3)
        Me.SuperTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel1.Location = New System.Drawing.Point(0, 29)
        Me.SuperTabControlPanel1.Name = "SuperTabControlPanel1"
        Me.SuperTabControlPanel1.Size = New System.Drawing.Size(393, 145)
        Me.SuperTabControlPanel1.TabIndex = 1
        Me.SuperTabControlPanel1.TabItem = Me.SuperTabItem1
        '
        'PanelEx3
        '
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.Controls.Add(Me.Input_Dir)
        Me.PanelEx3.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx3.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(393, 145)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 24
        Me.PanelEx3.Text = " "
        '
        'Input_Dir
        '
        '
        '
        '
        Me.Input_Dir.Border.Class = "TextBoxBorder"
        Me.Input_Dir.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_Dir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Input_Dir.Location = New System.Drawing.Point(0, 0)
        Me.Input_Dir.Multiline = True
        Me.Input_Dir.Name = "Input_Dir"
        Me.Input_Dir.PreventEnterBeep = True
        Me.Input_Dir.Size = New System.Drawing.Size(393, 145)
        Me.Input_Dir.TabIndex = 0
        '
        'SuperTabItem2
        '
        Me.SuperTabItem2.AttachedControl = Me.SuperTabControlPanel2
        Me.SuperTabItem2.GlobalItem = False
        Me.SuperTabItem2.Name = "SuperTabItem2"
        Me.SuperTabItem2.Text = "Index"
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.Controls.Add(Me.PanelEx4)
        Me.SuperTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel2.Location = New System.Drawing.Point(0, 29)
        Me.SuperTabControlPanel2.Name = "SuperTabControlPanel2"
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(393, 145)
        Me.SuperTabControlPanel2.TabIndex = 0
        Me.SuperTabControlPanel2.TabItem = Me.SuperTabItem2
        '
        'PanelEx4
        '
        Me.PanelEx4.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx4.Controls.Add(Me.SGC)
        Me.PanelEx4.Controls.Add(Me.PanelEx7)
        Me.PanelEx4.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx4.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx4.Name = "PanelEx4"
        Me.PanelEx4.Size = New System.Drawing.Size(393, 145)
        Me.PanelEx4.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx4.Style.GradientAngle = 90
        Me.PanelEx4.TabIndex = 31
        Me.PanelEx4.Text = " "
        '
        'SGC
        '
        Me.SGC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SGC.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.SGC.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SGC.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.SGC.Location = New System.Drawing.Point(0, 32)
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
        Me.SGC.Size = New System.Drawing.Size(393, 113)
        Me.SGC.TabIndex = 36
        Me.SGC.Text = "superGridControl1"
        '
        'SuperTabItem3
        '
        Me.SuperTabItem3.AttachedControl = Me.SuperTabControlPanel3
        Me.SuperTabItem3.GlobalItem = False
        Me.SuperTabItem3.Name = "SuperTabItem3"
        Me.SuperTabItem3.Text = "Info"
        '
        'SuperTabControlPanel3
        '
        Me.SuperTabControlPanel3.Controls.Add(Me.PanelEx5)
        Me.SuperTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel3.Location = New System.Drawing.Point(0, 29)
        Me.SuperTabControlPanel3.Name = "SuperTabControlPanel3"
        Me.SuperTabControlPanel3.Size = New System.Drawing.Size(393, 145)
        Me.SuperTabControlPanel3.TabIndex = 0
        Me.SuperTabControlPanel3.TabItem = Me.SuperTabItem3
        '
        'PanelEx5
        '
        Me.PanelEx5.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx5.Controls.Add(Me.AdvPropertyGrid1)
        Me.PanelEx5.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx5.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx5.Name = "PanelEx5"
        Me.PanelEx5.Size = New System.Drawing.Size(393, 145)
        Me.PanelEx5.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx5.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx5.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx5.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx5.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx5.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx5.Style.GradientAngle = 90
        Me.PanelEx5.TabIndex = 31
        Me.PanelEx5.Text = " "
        '
        'AdvPropertyGrid1
        '
        Me.AdvPropertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AdvPropertyGrid1.GridLinesColor = System.Drawing.Color.WhiteSmoke
        Me.AdvPropertyGrid1.Location = New System.Drawing.Point(0, 0)
        Me.AdvPropertyGrid1.Name = "AdvPropertyGrid1"
        Me.AdvPropertyGrid1.Size = New System.Drawing.Size(393, 145)
        Me.AdvPropertyGrid1.TabIndex = 0
        Me.AdvPropertyGrid1.Text = "AdvPropertyGrid1"
        '
        'PanelEx6
        '
        Me.PanelEx6.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx6.Controls.Add(Me.ButtonX1)
        Me.PanelEx6.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx6.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelEx6.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx6.Name = "PanelEx6"
        Me.PanelEx6.Size = New System.Drawing.Size(47, 38)
        Me.PanelEx6.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx6.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx6.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx6.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx6.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx6.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx6.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx6.Style.GradientAngle = 90
        Me.PanelEx6.TabIndex = 12
        Me.PanelEx6.Text = " "
        '
        'Pbar
        '
        '
        '
        '
        Me.Pbar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Pbar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pbar.Location = New System.Drawing.Point(122, 0)
        Me.Pbar.Name = "Pbar"
        Me.Pbar.Size = New System.Drawing.Size(271, 38)
        Me.Pbar.TabIndex = 13
        Me.Pbar.Text = "ProgressBarX1"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonX1.Image = Global.SmartCoder.My.Resources.Resources.Delete_24x24
        Me.ButtonX1.Location = New System.Drawing.Point(0, 0)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(47, 38)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 0
        Me.ButtonX1.Text = " "
        '
        'L_Percentage
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.L_Percentage.Dock = System.Windows.Forms.DockStyle.Left
        Me.L_Percentage.Location = New System.Drawing.Point(47, 0)
        Me.L_Percentage.Name = "L_Percentage"
        Me.L_Percentage.Size = New System.Drawing.Size(75, 38)
        Me.L_Percentage.TabIndex = 14
        Me.L_Percentage.Text = "( 0.00 %)"
        '
        'PanelEx7
        '
        Me.PanelEx7.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx7.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx7.Controls.Add(Me.Input_Search)
        Me.PanelEx7.Controls.Add(Me.Btn_Index)
        Me.PanelEx7.Controls.Add(Me.LabelX1)
        Me.PanelEx7.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx7.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx7.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx7.Name = "PanelEx7"
        Me.PanelEx7.Size = New System.Drawing.Size(393, 32)
        Me.PanelEx7.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx7.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx7.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx7.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx7.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx7.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx7.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx7.Style.GradientAngle = 90
        Me.PanelEx7.TabIndex = 37
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
        Me.LabelX1.Size = New System.Drawing.Size(61, 32)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "  Search"
        '
        'Input_Search
        '
        '
        '
        '
        Me.Input_Search.Border.Class = "TextBoxBorder"
        Me.Input_Search.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_Search.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Input_Search.Location = New System.Drawing.Point(61, 0)
        Me.Input_Search.Multiline = True
        Me.Input_Search.Name = "Input_Search"
        Me.Input_Search.PreventEnterBeep = True
        Me.Input_Search.Size = New System.Drawing.Size(257, 32)
        Me.Input_Search.TabIndex = 1
        Me.Input_Search.Text = "*.*"
        '
        'Btn_Index
        '
        Me.Btn_Index.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_Index.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.Btn_Index.Dock = System.Windows.Forms.DockStyle.Right
        Me.Btn_Index.Location = New System.Drawing.Point(318, 0)
        Me.Btn_Index.Name = "Btn_Index"
        Me.Btn_Index.Size = New System.Drawing.Size(75, 32)
        Me.Btn_Index.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_Index.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Btn_Search_All, Me.LabelItem1, Me.Include_Dir})
        Me.Btn_Index.TabIndex = 16
        Me.Btn_Index.Text = "Index"
        '
        'BW
        '
        Me.BW.WorkerReportsProgress = True
        Me.BW.WorkerSupportsCancellation = True
        '
        'Btn_Search_All
        '
        Me.Btn_Search_All.GlobalItem = False
        Me.Btn_Search_All.Name = "Btn_Search_All"
        Me.Btn_Search_All.Text = "Search All Directories"
        '
        'LabelItem1
        '
        Me.LabelItem1.GlobalItem = False
        Me.LabelItem1.Name = "LabelItem1"
        Me.LabelItem1.Text = "Option"
        '
        'Include_Dir
        '
        Me.Include_Dir.GlobalItem = False
        Me.Include_Dir.Name = "Include_Dir"
        Me.Include_Dir.Text = "Recherché Repertoires"
        '
        'FolderView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelEx1)
        Me.Controls.Add(Me.PanelEx18)
        Me.Controls.Add(Me.PanelEx2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FolderView"
        Me.Size = New System.Drawing.Size(393, 245)
        Me.PanelEx18.ResumeLayout(False)
        Me.PanelEx19.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControl1.ResumeLayout(False)
        Me.SuperTabControlPanel1.ResumeLayout(False)
        Me.PanelEx3.ResumeLayout(False)
        Me.SuperTabControlPanel2.ResumeLayout(False)
        Me.PanelEx4.ResumeLayout(False)
        Me.SuperTabControlPanel3.ResumeLayout(False)
        Me.PanelEx5.ResumeLayout(False)
        CType(Me.AdvPropertyGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx6.ResumeLayout(False)
        Me.PanelEx7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelEx18 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx19 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
    Friend WithEvents Btn_Define_Répertoire As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents SuperTabControl1 As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents SuperTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItem2 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel1 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Input_Dir As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents SuperTabItem1 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents SuperTabControlPanel3 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents PanelEx5 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents AdvPropertyGrid1 As DevComponents.DotNetBar.AdvPropertyGrid
    Friend WithEvents SuperTabItem3 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents PanelEx4 As DevComponents.DotNetBar.PanelEx
    Private WithEvents SGC As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents Pbar As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents PanelEx6 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PanelEx7 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Input_Search As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Btn_Index As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents L_Percentage As DevComponents.DotNetBar.LabelX
    Friend WithEvents BW As ComponentModel.BackgroundWorker
    Friend WithEvents Btn_Search_All As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents LabelItem1 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents Include_Dir As DevComponents.DotNetBar.SwitchButtonItem
    Public WithEvents Title As DevComponents.DotNetBar.LabelX
End Class
