<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class U_DataBase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(U_DataBase))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.SuperTabControl1 = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.PanelEx4 = New DevComponents.DotNetBar.PanelEx()
        Me.Pbar = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.Btn_Load = New DevComponents.DotNetBar.ButtonX()
        Me.Password = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.Btn_Define = New DevComponents.DotNetBar.ButtonX()
        Me.Txt_FilePath = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.SuperTabItem1 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel4 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.PanelEx6 = New DevComponents.DotNetBar.PanelEx()
        Me.SuperGridControl1 = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.ST_Tables = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel3 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.AdvPropertyGrid1 = New DevComponents.DotNetBar.AdvPropertyGrid()
        Me.SuperTabItem3 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.PanelEx5 = New DevComponents.DotNetBar.PanelEx()
        Me.Db_Size = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.CB_Type = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.ComboItem6 = New DevComponents.Editors.ComboItem()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.SuperTabItem2 = New DevComponents.DotNetBar.SuperTabItem()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.ReflectionImage1 = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.BW_LoadDb = New System.ComponentModel.BackgroundWorker()
        Me.PanelEx1.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControl1.SuspendLayout()
        Me.SuperTabControlPanel1.SuspendLayout()
        Me.PanelEx4.SuspendLayout()
        Me.SuperTabControlPanel4.SuspendLayout()
        Me.PanelEx6.SuspendLayout()
        Me.SuperTabControlPanel3.SuspendLayout()
        CType(Me.AdvPropertyGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControlPanel2.SuspendLayout()
        Me.PanelEx5.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.PanelEx3)
        Me.PanelEx1.Controls.Add(Me.PanelEx2)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(468, 155)
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
        'PanelEx3
        '
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.Controls.Add(Me.SuperTabControl1)
        Me.PanelEx3.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx3.Location = New System.Drawing.Point(72, 0)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(396, 155)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 5
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
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel4)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel3)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel2)
        Me.SuperTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControl1.Name = "SuperTabControl1"
        Me.SuperTabControl1.ReorderTabsEnabled = True
        Me.SuperTabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.SuperTabControl1.SelectedTabIndex = 0
        Me.SuperTabControl1.Size = New System.Drawing.Size(396, 155)
        Me.SuperTabControl1.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabControl1.TabIndex = 0
        Me.SuperTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabItem1, Me.SuperTabItem2, Me.SuperTabItem3, Me.ST_Tables})
        Me.SuperTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue
        Me.SuperTabControl1.Text = "SuperTabControl1"
        '
        'SuperTabControlPanel1
        '
        Me.SuperTabControlPanel1.Controls.Add(Me.PanelEx4)
        Me.SuperTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel1.Location = New System.Drawing.Point(0, 25)
        Me.SuperTabControlPanel1.Name = "SuperTabControlPanel1"
        Me.SuperTabControlPanel1.Size = New System.Drawing.Size(396, 130)
        Me.SuperTabControlPanel1.TabIndex = 1
        Me.SuperTabControlPanel1.TabItem = Me.SuperTabItem1
        '
        'PanelEx4
        '
        Me.PanelEx4.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx4.Controls.Add(Me.Pbar)
        Me.PanelEx4.Controls.Add(Me.Btn_Load)
        Me.PanelEx4.Controls.Add(Me.Password)
        Me.PanelEx4.Controls.Add(Me.LabelX2)
        Me.PanelEx4.Controls.Add(Me.Btn_Define)
        Me.PanelEx4.Controls.Add(Me.Txt_FilePath)
        Me.PanelEx4.Controls.Add(Me.LabelX1)
        Me.PanelEx4.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx4.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx4.Name = "PanelEx4"
        Me.PanelEx4.Size = New System.Drawing.Size(396, 130)
        Me.PanelEx4.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx4.Style.GradientAngle = 90
        Me.PanelEx4.TabIndex = 0
        Me.PanelEx4.ThemeAware = True
        '
        'Pbar
        '
        '
        '
        '
        Me.Pbar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Pbar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Pbar.Location = New System.Drawing.Point(0, 120)
        Me.Pbar.Name = "Pbar"
        Me.Pbar.Size = New System.Drawing.Size(396, 10)
        Me.Pbar.TabIndex = 6
        Me.Pbar.Text = "ProgressBarX1"
        '
        'Btn_Load
        '
        Me.Btn_Load.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_Load.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.Btn_Load.Enabled = False
        Me.Btn_Load.Location = New System.Drawing.Point(314, 88)
        Me.Btn_Load.Name = "Btn_Load"
        Me.Btn_Load.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Load.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_Load.TabIndex = 5
        Me.Btn_Load.Text = "Load"
        '
        'Password
        '
        '
        '
        '
        Me.Password.Border.Class = "TextBoxBorder"
        Me.Password.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Password.Location = New System.Drawing.Point(6, 89)
        Me.Password.Name = "Password"
        Me.Password.PreventEnterBeep = True
        Me.Password.Size = New System.Drawing.Size(302, 22)
        Me.Password.TabIndex = 4
        Me.Password.WatermarkText = "Input the password of the database"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(6, 60)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(79, 23)
        Me.LabelX2.TabIndex = 3
        Me.LabelX2.Text = "Password : "
        '
        'Btn_Define
        '
        Me.Btn_Define.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_Define.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.Btn_Define.Location = New System.Drawing.Point(314, 32)
        Me.Btn_Define.Name = "Btn_Define"
        Me.Btn_Define.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Define.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_Define.TabIndex = 2
        Me.Btn_Define.Text = "Define"
        '
        'Txt_FilePath
        '
        '
        '
        '
        Me.Txt_FilePath.Border.Class = "TextBoxBorder"
        Me.Txt_FilePath.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Txt_FilePath.Location = New System.Drawing.Point(6, 32)
        Me.Txt_FilePath.Name = "Txt_FilePath"
        Me.Txt_FilePath.PreventEnterBeep = True
        Me.Txt_FilePath.Size = New System.Drawing.Size(302, 22)
        Me.Txt_FilePath.TabIndex = 1
        Me.Txt_FilePath.WatermarkText = "Double click to define."
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(6, 3)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(168, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Location of the data file"
        '
        'SuperTabItem1
        '
        Me.SuperTabItem1.AttachedControl = Me.SuperTabControlPanel1
        Me.SuperTabItem1.GlobalItem = False
        Me.SuperTabItem1.Name = "SuperTabItem1"
        Me.SuperTabItem1.Text = "Connection"
        '
        'SuperTabControlPanel4
        '
        Me.SuperTabControlPanel4.Controls.Add(Me.PanelEx6)
        Me.SuperTabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel4.Location = New System.Drawing.Point(0, 25)
        Me.SuperTabControlPanel4.Name = "SuperTabControlPanel4"
        Me.SuperTabControlPanel4.Size = New System.Drawing.Size(396, 120)
        Me.SuperTabControlPanel4.TabIndex = 0
        Me.SuperTabControlPanel4.TabItem = Me.ST_Tables
        '
        'PanelEx6
        '
        Me.PanelEx6.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx6.Controls.Add(Me.SuperGridControl1)
        Me.PanelEx6.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx6.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx6.Name = "PanelEx6"
        Me.PanelEx6.Size = New System.Drawing.Size(396, 120)
        Me.PanelEx6.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx6.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx6.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx6.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx6.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx6.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx6.Style.GradientAngle = 90
        Me.PanelEx6.TabIndex = 0
        Me.PanelEx6.Text = " "
        '
        'SuperGridControl1
        '
        Me.SuperGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperGridControl1.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.SuperGridControl1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.SuperGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.SuperGridControl1.Name = "SuperGridControl1"
        Me.SuperGridControl1.Size = New System.Drawing.Size(396, 120)
        Me.SuperGridControl1.TabIndex = 0
        Me.SuperGridControl1.Text = "SuperGridControl1"
        '
        'ST_Tables
        '
        Me.ST_Tables.AttachedControl = Me.SuperTabControlPanel4
        Me.ST_Tables.GlobalItem = False
        Me.ST_Tables.Name = "ST_Tables"
        Me.ST_Tables.Text = "Tables"
        '
        'SuperTabControlPanel3
        '
        Me.SuperTabControlPanel3.Controls.Add(Me.AdvPropertyGrid1)
        Me.SuperTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel3.Location = New System.Drawing.Point(0, 25)
        Me.SuperTabControlPanel3.Name = "SuperTabControlPanel3"
        Me.SuperTabControlPanel3.Size = New System.Drawing.Size(396, 120)
        Me.SuperTabControlPanel3.TabIndex = 0
        Me.SuperTabControlPanel3.TabItem = Me.SuperTabItem3
        '
        'AdvPropertyGrid1
        '
        Me.AdvPropertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AdvPropertyGrid1.GridLinesColor = System.Drawing.Color.WhiteSmoke
        Me.AdvPropertyGrid1.Location = New System.Drawing.Point(0, 0)
        Me.AdvPropertyGrid1.Name = "AdvPropertyGrid1"
        Me.AdvPropertyGrid1.Size = New System.Drawing.Size(396, 120)
        Me.AdvPropertyGrid1.TabIndex = 0
        Me.AdvPropertyGrid1.Text = "AdvPropertyGrid1"
        '
        'SuperTabItem3
        '
        Me.SuperTabItem3.AttachedControl = Me.SuperTabControlPanel3
        Me.SuperTabItem3.GlobalItem = False
        Me.SuperTabItem3.Name = "SuperTabItem3"
        Me.SuperTabItem3.Text = "Property"
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.Controls.Add(Me.PanelEx5)
        Me.SuperTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel2.Location = New System.Drawing.Point(0, 25)
        Me.SuperTabControlPanel2.Name = "SuperTabControlPanel2"
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(396, 120)
        Me.SuperTabControlPanel2.TabIndex = 0
        Me.SuperTabControlPanel2.TabItem = Me.SuperTabItem2
        '
        'PanelEx5
        '
        Me.PanelEx5.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx5.Controls.Add(Me.Db_Size)
        Me.PanelEx5.Controls.Add(Me.LabelX4)
        Me.PanelEx5.Controls.Add(Me.CB_Type)
        Me.PanelEx5.Controls.Add(Me.LabelX3)
        Me.PanelEx5.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx5.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx5.Name = "PanelEx5"
        Me.PanelEx5.Size = New System.Drawing.Size(396, 120)
        Me.PanelEx5.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx5.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx5.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx5.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx5.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx5.Style.GradientAngle = 90
        Me.PanelEx5.TabIndex = 0
        Me.PanelEx5.Text = " "
        '
        'Db_Size
        '
        '
        '
        '
        Me.Db_Size.Border.Class = "TextBoxBorder"
        Me.Db_Size.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Db_Size.Location = New System.Drawing.Point(145, 53)
        Me.Db_Size.Name = "Db_Size"
        Me.Db_Size.PreventEnterBeep = True
        Me.Db_Size.Size = New System.Drawing.Size(113, 22)
        Me.Db_Size.TabIndex = 3
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(16, 52)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(123, 23)
        Me.LabelX4.TabIndex = 2
        Me.LabelX4.Text = "Size of DataBase"
        '
        'CB_Type
        '
        Me.CB_Type.DisplayMember = "Text"
        Me.CB_Type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CB_Type.FormattingEnabled = True
        Me.CB_Type.ItemHeight = 17
        Me.CB_Type.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3, Me.ComboItem4, Me.ComboItem5, Me.ComboItem6})
        Me.CB_Type.Location = New System.Drawing.Point(145, 15)
        Me.CB_Type.Name = "CB_Type"
        Me.CB_Type.Size = New System.Drawing.Size(224, 23)
        Me.CB_Type.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CB_Type.TabIndex = 1
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Microsoft Access 2003"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Microsoft Access 2019"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "Microsoft Excel 2019"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "SQL"
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "Saadry"
        '
        'ComboItem6
        '
        Me.ComboItem6.Text = "Dbf"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(16, 14)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(123, 23)
        Me.LabelX3.TabIndex = 0
        Me.LabelX3.Text = "Type of DataBase : "
        '
        'SuperTabItem2
        '
        Me.SuperTabItem2.AttachedControl = Me.SuperTabControlPanel2
        Me.SuperTabItem2.GlobalItem = False
        Me.SuperTabItem2.Name = "SuperTabItem2"
        Me.SuperTabItem2.Text = "Info"
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.ReflectionImage1)
        Me.PanelEx2.Controls.Add(Me.PictureBox2)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelEx2.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(72, 155)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 4
        Me.PanelEx2.Text = " "
        '
        'ReflectionImage1
        '
        '
        '
        '
        Me.ReflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.ReflectionImage1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReflectionImage1.Image = Global.SmartCoder.My.Resources.Resources.database
        Me.ReflectionImage1.Location = New System.Drawing.Point(0, 0)
        Me.ReflectionImage1.Name = "ReflectionImage1"
        Me.ReflectionImage1.Size = New System.Drawing.Size(72, 93)
        Me.ReflectionImage1.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox2.Image = Global.SmartCoder.My.Resources.Resources.close
        Me.PictureBox2.Location = New System.Drawing.Point(0, 93)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(72, 62)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "add.png")
        Me.ImageList1.Images.SetKeyName(1, "check_mark.png")
        Me.ImageList1.Images.SetKeyName(2, "close.png")
        Me.ImageList1.Images.SetKeyName(3, "delete.png")
        Me.ImageList1.Images.SetKeyName(4, "help.png")
        '
        'OFD
        '
        Me.OFD.FileName = "OpenFileDialog1"
        '
        'BW_LoadDb
        '
        Me.BW_LoadDb.WorkerReportsProgress = True
        Me.BW_LoadDb.WorkerSupportsCancellation = True
        '
        'U_DataBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "U_DataBase"
        Me.Size = New System.Drawing.Size(468, 155)
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx3.ResumeLayout(False)
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControl1.ResumeLayout(False)
        Me.SuperTabControlPanel1.ResumeLayout(False)
        Me.PanelEx4.ResumeLayout(False)
        Me.SuperTabControlPanel4.ResumeLayout(False)
        Me.PanelEx6.ResumeLayout(False)
        Me.SuperTabControlPanel3.ResumeLayout(False)
        CType(Me.AdvPropertyGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControlPanel2.ResumeLayout(False)
        Me.PanelEx5.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ReflectionImage1 As DevComponents.DotNetBar.Controls.ReflectionImage
    Friend WithEvents PictureBox2 As Windows.Forms.PictureBox
    Friend WithEvents ImageList1 As Windows.Forms.ImageList
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents SuperTabControl1 As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents SuperTabControlPanel1 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents PanelEx4 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Btn_Define As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents SuperTabItem1 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents PanelEx5 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Db_Size As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents CB_Type As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents SuperTabItem2 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel3 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents AdvPropertyGrid1 As DevComponents.DotNetBar.AdvPropertyGrid
    Friend WithEvents SuperTabItem3 As DevComponents.DotNetBar.SuperTabItem
    Public WithEvents OFD As Windows.Forms.OpenFileDialog
    Friend WithEvents SuperTabControlPanel4 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents PanelEx6 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ST_Tables As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperGridControl1 As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Public WithEvents Password As DevComponents.DotNetBar.Controls.TextBoxX
    Public WithEvents Txt_FilePath As DevComponents.DotNetBar.Controls.TextBoxX
    Public WithEvents Btn_Load As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Pbar As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents BW_LoadDb As ComponentModel.BackgroundWorker
End Class
