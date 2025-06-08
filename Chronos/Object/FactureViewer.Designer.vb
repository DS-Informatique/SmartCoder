<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FactureViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FactureViewer))
        Dim TimeSheet1 As Chronos.M_TimeSheet.TimeSheet = New Chronos.M_TimeSheet.TimeSheet()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelEx5 = New DevComponents.DotNetBar.PanelEx()
        Me.Vcr1 = New SmartCoder.SuperGridDemo.VcrControl()
        Me.PanelEx6 = New DevComponents.DotNetBar.PanelEx()
        Me.TVA = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.Input_Total_TVA = New DevComponents.Editors.DoubleInput()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.Input_Total_HTVA = New DevComponents.Editors.DoubleInput()
        Me.LabelX30 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX31 = New DevComponents.DotNetBar.LabelX()
        Me.Input_Quantity_Frais = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX19 = New DevComponents.DotNetBar.LabelX()
        Me.Input_Quantity_Prestation = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Input_Total_Frais = New DevComponents.Editors.DoubleInput()
        Me.Input_Total_Prestation = New DevComponents.Editors.DoubleInput()
        Me.LabelX28 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
        Me.IL_ = New System.Windows.Forms.ImageList(Me.components)
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.IL_Client = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DotNetBarManager1 = New DevComponents.DotNetBar.DotNetBarManager(Me.components)
        Me.DockSite4 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite9 = New DevComponents.DotNetBar.DockSite()
        Me.Bar1 = New DevComponents.DotNetBar.Bar()
        Me.PanelDockContainer2 = New DevComponents.DotNetBar.PanelDockContainer()
        Me.PanelEx7 = New DevComponents.DotNetBar.PanelEx()
        Me.SuperTabControl1 = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.PanelEx9 = New DevComponents.DotNetBar.PanelEx()
        Me.PrestationViewer1 = New Chronos.PrestationViewer()
        Me.SuperTabItem2 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.PanelEx8 = New DevComponents.DotNetBar.PanelEx()
        Me.Btn_Verify = New DevComponents.DotNetBar.ButtonX()
        Me.Input_Code = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.Input_DateOp = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.Btn_Print_Simple = New DevComponents.DotNetBar.ButtonX()
        Me.Btn_Print_Empty = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Input_Adresse = New DevComponents.DotNetBar.Controls.RichTextBoxEx()
        Me.Input_Libellé = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX33 = New DevComponents.DotNetBar.LabelX()
        Me.Input_Concerne = New DevComponents.DotNetBar.Controls.ComboBoxEx()
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
        Me.Input_N = New DevComponents.Editors.IntegerInput()
        Me.SuperTabItem1 = New DevComponents.DotNetBar.SuperTabItem()
        Me.PanelDockContainer1 = New DevComponents.DotNetBar.PanelDockContainer()
        Me.SGC = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.DockContainerItem1 = New DevComponents.DotNetBar.DockContainerItem()
        Me.DockContainerItem2 = New DevComponents.DotNetBar.DockContainerItem()
        Me.IL_32 = New System.Windows.Forms.ImageList(Me.components)
        Me.DockSite1 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite2 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite8 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite5 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite6 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite7 = New DevComponents.DotNetBar.DockSite()
        Me.Bar2 = New DevComponents.DotNetBar.Bar()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonItem()
        Me.Btn_Add = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonX4 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.Btn_SendToExcel = New DevComponents.DotNetBar.ButtonItem()
        Me.DockSite3 = New DevComponents.DotNetBar.DockSite()
        Me.BW = New System.ComponentModel.BackgroundWorker()
        Me.Btn_CalculateTotal = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.Input_Mandat = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.Input_DateStart = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.Input_DateEnd = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Invoice_Filter = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.Input_Total = New DevComponents.Editors.DoubleInput()
        Me.Input_Société = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Btn_Select_All = New DevComponents.DotNetBar.ButtonX()
        Me.Btn_Deselect_All = New DevComponents.DotNetBar.ButtonItem()
        Me.PanelEx4 = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx1.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx5.SuspendLayout()
        Me.PanelEx6.SuspendLayout()
        CType(Me.Input_Total_TVA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Input_Total_HTVA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Input_Total_Frais, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Input_Total_Prestation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockSite9.SuspendLayout()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bar1.SuspendLayout()
        Me.PanelDockContainer2.SuspendLayout()
        Me.PanelEx7.SuspendLayout()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControl1.SuspendLayout()
        Me.SuperTabControlPanel2.SuspendLayout()
        Me.PanelEx9.SuspendLayout()
        Me.SuperTabControlPanel1.SuspendLayout()
        Me.PanelEx8.SuspendLayout()
        CType(Me.Input_DateOp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.Input_N, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDockContainer1.SuspendLayout()
        Me.DockSite7.SuspendLayout()
        CType(Me.Bar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Input_DateStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Input_DateEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Input_Total, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx4.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.PanelEx3)
        Me.PanelEx1.Controls.Add(Me.PanelEx2)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1161, 48)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 8
        Me.PanelEx1.Text = " "
        '
        'PanelEx3
        '
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.Controls.Add(Me.ReflectionLabel1)
        Me.PanelEx3.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx3.Location = New System.Drawing.Point(63, 0)
        Me.PanelEx3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(1098, 48)
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
        'ReflectionLabel1
        '
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReflectionLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReflectionLabel1.Location = New System.Drawing.Point(0, 0)
        Me.ReflectionLabel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(1098, 48)
        Me.ReflectionLabel1.TabIndex = 0
        Me.ReflectionLabel1.Text = "<font color=""#388194""><b>Facture</b></font>"
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.PictureBox1)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelEx2.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(63, 48)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 4
        Me.PanelEx2.Text = " "
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Chronos.My.Resources.Resources.edit
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(63, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelEx5
        '
        Me.PanelEx5.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx5.Controls.Add(Me.Vcr1)
        Me.PanelEx5.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelEx5.Location = New System.Drawing.Point(0, 623)
        Me.PanelEx5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelEx5.Name = "PanelEx5"
        Me.PanelEx5.Size = New System.Drawing.Size(1161, 48)
        Me.PanelEx5.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx5.Style.BackColor1.Color = System.Drawing.Color.White
        Me.PanelEx5.Style.BackColor2.Color = System.Drawing.Color.White
        Me.PanelEx5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx5.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx5.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx5.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx5.Style.GradientAngle = 90
        Me.PanelEx5.TabIndex = 16
        Me.PanelEx5.Text = " "
        '
        'Vcr1
        '
        Me.Vcr1.BackColor = System.Drawing.Color.Transparent
        Me.Vcr1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Vcr1.Location = New System.Drawing.Point(0, 0)
        Me.Vcr1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Vcr1.Name = "Vcr1"
        Me.Vcr1.Size = New System.Drawing.Size(1161, 48)
        Me.Vcr1.TabIndex = 15
        '
        'PanelEx6
        '
        Me.PanelEx6.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx6.Controls.Add(Me.TVA)
        Me.PanelEx6.Controls.Add(Me.LabelX4)
        Me.PanelEx6.Controls.Add(Me.Input_Total_TVA)
        Me.PanelEx6.Controls.Add(Me.LabelX5)
        Me.PanelEx6.Controls.Add(Me.Input_Total_HTVA)
        Me.PanelEx6.Controls.Add(Me.LabelX30)
        Me.PanelEx6.Controls.Add(Me.LabelX31)
        Me.PanelEx6.Controls.Add(Me.Input_Quantity_Frais)
        Me.PanelEx6.Controls.Add(Me.LabelX19)
        Me.PanelEx6.Controls.Add(Me.Input_Quantity_Prestation)
        Me.PanelEx6.Controls.Add(Me.Input_Total_Frais)
        Me.PanelEx6.Controls.Add(Me.Input_Total_Prestation)
        Me.PanelEx6.Controls.Add(Me.LabelX28)
        Me.PanelEx6.Controls.Add(Me.LabelX13)
        Me.PanelEx6.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelEx6.Location = New System.Drawing.Point(0, 545)
        Me.PanelEx6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelEx6.Name = "PanelEx6"
        Me.PanelEx6.Size = New System.Drawing.Size(1161, 78)
        Me.PanelEx6.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx6.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx6.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx6.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx6.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx6.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx6.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx6.Style.GradientAngle = 90
        Me.PanelEx6.TabIndex = 20
        Me.PanelEx6.Text = " "
        '
        'TVA
        '
        '
        '
        '
        Me.TVA.Border.Class = "TextBoxBorder"
        Me.TVA.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TVA.Location = New System.Drawing.Point(567, 41)
        Me.TVA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TVA.Name = "TVA"
        Me.TVA.PreventEnterBeep = True
        Me.TVA.Size = New System.Drawing.Size(112, 26)
        Me.TVA.TabIndex = 53
        Me.TVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(567, 5)
        Me.LabelX4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(81, 29)
        Me.LabelX4.TabIndex = 49
        Me.LabelX4.Text = "TVA"
        '
        'Input_Total_TVA
        '
        '
        '
        '
        Me.Input_Total_TVA.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Input_Total_TVA.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_Total_TVA.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.Input_Total_TVA.Increment = 1.0R
        Me.Input_Total_TVA.Location = New System.Drawing.Point(1000, 42)
        Me.Input_Total_TVA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Input_Total_TVA.Name = "Input_Total_TVA"
        Me.Input_Total_TVA.ShowUpDown = True
        Me.Input_Total_TVA.Size = New System.Drawing.Size(126, 26)
        Me.Input_Total_TVA.TabIndex = 50
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(868, 41)
        Me.LabelX5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(118, 29)
        Me.LabelX5.TabIndex = 49
        Me.LabelX5.Text = "Total TVA"
        '
        'Input_Total_HTVA
        '
        '
        '
        '
        Me.Input_Total_HTVA.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Input_Total_HTVA.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_Total_HTVA.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.Input_Total_HTVA.Increment = 1.0R
        Me.Input_Total_HTVA.Location = New System.Drawing.Point(1000, 8)
        Me.Input_Total_HTVA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Input_Total_HTVA.Name = "Input_Total_HTVA"
        Me.Input_Total_HTVA.ShowUpDown = True
        Me.Input_Total_HTVA.Size = New System.Drawing.Size(126, 26)
        Me.Input_Total_HTVA.TabIndex = 48
        '
        'LabelX30
        '
        '
        '
        '
        Me.LabelX30.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX30.Location = New System.Drawing.Point(868, 6)
        Me.LabelX30.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX30.Name = "LabelX30"
        Me.LabelX30.Size = New System.Drawing.Size(118, 29)
        Me.LabelX30.TabIndex = 46
        Me.LabelX30.Text = "Total Hors TVA"
        '
        'LabelX31
        '
        '
        '
        '
        Me.LabelX31.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX31.Location = New System.Drawing.Point(302, 41)
        Me.LabelX31.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX31.Name = "LabelX31"
        Me.LabelX31.Size = New System.Drawing.Size(118, 29)
        Me.LabelX31.TabIndex = 44
        Me.LabelX31.Text = "Quantité heure"
        '
        'Input_Quantity_Frais
        '
        '
        '
        '
        Me.Input_Quantity_Frais.Border.Class = "TextBoxBorder"
        Me.Input_Quantity_Frais.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_Quantity_Frais.Location = New System.Drawing.Point(426, 41)
        Me.Input_Quantity_Frais.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Input_Quantity_Frais.Name = "Input_Quantity_Frais"
        Me.Input_Quantity_Frais.PreventEnterBeep = True
        Me.Input_Quantity_Frais.Size = New System.Drawing.Size(112, 26)
        Me.Input_Quantity_Frais.TabIndex = 45
        Me.Input_Quantity_Frais.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX19
        '
        '
        '
        '
        Me.LabelX19.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX19.Location = New System.Drawing.Point(302, 4)
        Me.LabelX19.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX19.Name = "LabelX19"
        Me.LabelX19.Size = New System.Drawing.Size(118, 29)
        Me.LabelX19.TabIndex = 42
        Me.LabelX19.Text = "Quantité heure"
        '
        'Input_Quantity_Prestation
        '
        '
        '
        '
        Me.Input_Quantity_Prestation.Border.Class = "TextBoxBorder"
        Me.Input_Quantity_Prestation.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_Quantity_Prestation.Location = New System.Drawing.Point(426, 4)
        Me.Input_Quantity_Prestation.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Input_Quantity_Prestation.Name = "Input_Quantity_Prestation"
        Me.Input_Quantity_Prestation.PreventEnterBeep = True
        Me.Input_Quantity_Prestation.Size = New System.Drawing.Size(112, 26)
        Me.Input_Quantity_Prestation.TabIndex = 43
        Me.Input_Quantity_Prestation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Input_Total_Frais
        '
        '
        '
        '
        Me.Input_Total_Frais.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Input_Total_Frais.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_Total_Frais.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.Input_Total_Frais.Increment = 1.0R
        Me.Input_Total_Frais.Location = New System.Drawing.Point(159, 41)
        Me.Input_Total_Frais.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Input_Total_Frais.Name = "Input_Total_Frais"
        Me.Input_Total_Frais.ShowUpDown = True
        Me.Input_Total_Frais.Size = New System.Drawing.Size(126, 26)
        Me.Input_Total_Frais.TabIndex = 38
        '
        'Input_Total_Prestation
        '
        '
        '
        '
        Me.Input_Total_Prestation.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Input_Total_Prestation.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_Total_Prestation.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.Input_Total_Prestation.Increment = 1.0R
        Me.Input_Total_Prestation.Location = New System.Drawing.Point(159, 6)
        Me.Input_Total_Prestation.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Input_Total_Prestation.Name = "Input_Total_Prestation"
        Me.Input_Total_Prestation.ShowUpDown = True
        Me.Input_Total_Prestation.Size = New System.Drawing.Size(126, 26)
        Me.Input_Total_Prestation.TabIndex = 37
        '
        'LabelX28
        '
        '
        '
        '
        Me.LabelX28.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX28.Location = New System.Drawing.Point(17, 42)
        Me.LabelX28.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX28.Name = "LabelX28"
        Me.LabelX28.Size = New System.Drawing.Size(118, 29)
        Me.LabelX28.TabIndex = 36
        Me.LabelX28.Text = "Total Frais"
        '
        'LabelX13
        '
        '
        '
        '
        Me.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX13.Location = New System.Drawing.Point(17, 6)
        Me.LabelX13.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(118, 29)
        Me.LabelX13.TabIndex = 35
        Me.LabelX13.Text = "Total Prestation:  "
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
        'Timer1
        '
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
        Me.DotNetBarManager1.Images = Me.IL_32
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
        Me.DockSite4.Location = New System.Drawing.Point(0, 671)
        Me.DockSite4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DockSite4.Name = "DockSite4"
        Me.DockSite4.Size = New System.Drawing.Size(1161, 0)
        Me.DockSite4.TabIndex = 24
        Me.DockSite4.TabStop = False
        '
        'DockSite9
        '
        Me.DockSite9.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite9.Controls.Add(Me.Bar1)
        Me.DockSite9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DockSite9.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer(New DevComponents.DotNetBar.DocumentBaseContainer() {CType(New DevComponents.DotNetBar.DocumentBarContainer(Me.Bar1, 1161, 365), DevComponents.DotNetBar.DocumentBaseContainer)}, DevComponents.DotNetBar.eOrientation.Horizontal)
        Me.DockSite9.Location = New System.Drawing.Point(0, 180)
        Me.DockSite9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DockSite9.Name = "DockSite9"
        Me.DockSite9.Size = New System.Drawing.Size(1161, 365)
        Me.DockSite9.TabIndex = 29
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
        Me.Bar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bar1.IsMaximized = False
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.DockContainerItem1, Me.DockContainerItem2})
        Me.Bar1.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer
        Me.Bar1.Location = New System.Drawing.Point(0, 0)
        Me.Bar1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.SelectedDockTab = 1
        Me.Bar1.Size = New System.Drawing.Size(1161, 365)
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar1.TabIndex = 0
        Me.Bar1.TabNavigation = True
        Me.Bar1.TabStop = False
        '
        'PanelDockContainer2
        '
        Me.PanelDockContainer2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelDockContainer2.Controls.Add(Me.PanelEx7)
        Me.PanelDockContainer2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelDockContainer2.Location = New System.Drawing.Point(3, 28)
        Me.PanelDockContainer2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelDockContainer2.Name = "PanelDockContainer2"
        Me.PanelDockContainer2.Size = New System.Drawing.Size(1155, 334)
        Me.PanelDockContainer2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelDockContainer2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelDockContainer2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.PanelDockContainer2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelDockContainer2.Style.GradientAngle = 90
        Me.PanelDockContainer2.TabIndex = 5
        '
        'PanelEx7
        '
        Me.PanelEx7.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx7.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx7.Controls.Add(Me.SuperTabControl1)
        Me.PanelEx7.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx7.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelEx7.Name = "PanelEx7"
        Me.PanelEx7.Size = New System.Drawing.Size(1155, 334)
        Me.PanelEx7.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx7.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx7.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx7.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx7.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx7.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx7.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx7.Style.GradientAngle = 90
        Me.PanelEx7.TabIndex = 0
        Me.PanelEx7.Text = " "
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
        Me.SuperTabControl1.ImageList = Me.IL_
        Me.SuperTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SuperTabControl1.Name = "SuperTabControl1"
        Me.SuperTabControl1.ReorderTabsEnabled = True
        Me.SuperTabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.SuperTabControl1.SelectedTabIndex = 0
        Me.SuperTabControl1.Size = New System.Drawing.Size(1155, 334)
        Me.SuperTabControl1.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabControl1.TabIndex = 0
        Me.SuperTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabItem1, Me.SuperTabItem2})
        Me.SuperTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.OneNote2007
        Me.SuperTabControl1.Text = "SuperTabControl1"
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.Controls.Add(Me.PanelEx9)
        Me.SuperTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel2.Location = New System.Drawing.Point(0, 46)
        Me.SuperTabControlPanel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SuperTabControlPanel2.Name = "SuperTabControlPanel2"
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(1155, 280)
        Me.SuperTabControlPanel2.TabIndex = 0
        Me.SuperTabControlPanel2.TabItem = Me.SuperTabItem2
        '
        'PanelEx9
        '
        Me.PanelEx9.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx9.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx9.Controls.Add(Me.PrestationViewer1)
        Me.PanelEx9.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx9.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelEx9.Name = "PanelEx9"
        Me.PanelEx9.Size = New System.Drawing.Size(1155, 280)
        Me.PanelEx9.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx9.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx9.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx9.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx9.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx9.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx9.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx9.Style.GradientAngle = 90
        Me.PanelEx9.TabIndex = 4
        Me.PanelEx9.Text = " "
        '
        'PrestationViewer1
        '
        Me.PrestationViewer1.Active_Service = Nothing
        TimeSheet1.Active = False
        TimeSheet1.Collaborateur = Nothing
        TimeSheet1.Description = Nothing
        TimeSheet1.Facturable = False
        TimeSheet1.ID = 0
        TimeSheet1.Mandat = Nothing
        TimeSheet1.Quantity = 0R
        TimeSheet1.TimeIn = New Date(CType(0, Long))
        TimeSheet1.Total = 0R
        TimeSheet1.TotalHTVA = 0R
        TimeSheet1.UnitPrice = 0R
        Me.PrestationViewer1.Current = TimeSheet1
        Me.PrestationViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrestationViewer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrestationViewer1.Location = New System.Drawing.Point(0, 0)
        Me.PrestationViewer1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PrestationViewer1.Name = "PrestationViewer1"
        Me.PrestationViewer1.Size = New System.Drawing.Size(1155, 280)
        Me.PrestationViewer1.TabIndex = 0
        '
        'SuperTabItem2
        '
        Me.SuperTabItem2.AttachedControl = Me.SuperTabControlPanel2
        Me.SuperTabItem2.GlobalItem = False
        Me.SuperTabItem2.ImageIndex = 7
        Me.SuperTabItem2.Name = "SuperTabItem2"
        Me.SuperTabItem2.Text = "Prestations"
        '
        'SuperTabControlPanel1
        '
        Me.SuperTabControlPanel1.Controls.Add(Me.PanelEx8)
        Me.SuperTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel1.Location = New System.Drawing.Point(0, 38)
        Me.SuperTabControlPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SuperTabControlPanel1.Name = "SuperTabControlPanel1"
        Me.SuperTabControlPanel1.Size = New System.Drawing.Size(1155, 296)
        Me.SuperTabControlPanel1.TabIndex = 1
        Me.SuperTabControlPanel1.TabItem = Me.SuperTabItem1
        '
        'PanelEx8
        '
        Me.PanelEx8.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx8.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx8.Controls.Add(Me.Btn_Verify)
        Me.PanelEx8.Controls.Add(Me.Input_Code)
        Me.PanelEx8.Controls.Add(Me.LabelX9)
        Me.PanelEx8.Controls.Add(Me.Input_DateOp)
        Me.PanelEx8.Controls.Add(Me.LabelX8)
        Me.PanelEx8.Controls.Add(Me.Btn_Print_Simple)
        Me.PanelEx8.Controls.Add(Me.Btn_Print_Empty)
        Me.PanelEx8.Controls.Add(Me.GroupPanel1)
        Me.PanelEx8.Controls.Add(Me.Input_Libellé)
        Me.PanelEx8.Controls.Add(Me.LabelX33)
        Me.PanelEx8.Controls.Add(Me.Input_Concerne)
        Me.PanelEx8.Controls.Add(Me.LabelX27)
        Me.PanelEx8.Controls.Add(Me.LabelX23)
        Me.PanelEx8.Controls.Add(Me.Input_N)
        Me.PanelEx8.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx8.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelEx8.Name = "PanelEx8"
        Me.PanelEx8.Size = New System.Drawing.Size(1155, 296)
        Me.PanelEx8.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx8.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx8.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx8.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx8.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx8.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx8.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx8.Style.GradientAngle = 90
        Me.PanelEx8.TabIndex = 4
        Me.PanelEx8.Text = " "
        '
        'Btn_Verify
        '
        Me.Btn_Verify.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_Verify.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.Btn_Verify.Location = New System.Drawing.Point(942, 61)
        Me.Btn_Verify.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btn_Verify.Name = "Btn_Verify"
        Me.Btn_Verify.Size = New System.Drawing.Size(122, 29)
        Me.Btn_Verify.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_Verify.TabIndex = 54
        Me.Btn_Verify.Text = "Verifer"
        '
        'Input_Code
        '
        '
        '
        '
        Me.Input_Code.Border.Class = "TextBoxBorder"
        Me.Input_Code.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_Code.Location = New System.Drawing.Point(588, 21)
        Me.Input_Code.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Input_Code.Name = "Input_Code"
        Me.Input_Code.PreventEnterBeep = True
        Me.Input_Code.Size = New System.Drawing.Size(471, 26)
        Me.Input_Code.TabIndex = 39
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Location = New System.Drawing.Point(525, 20)
        Me.LabelX9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(56, 29)
        Me.LabelX9.TabIndex = 38
        Me.LabelX9.Text = "Ref"
        '
        'Input_DateOp
        '
        '
        '
        '
        Me.Input_DateOp.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Input_DateOp.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_DateOp.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.Input_DateOp.ButtonDropDown.Visible = True
        Me.Input_DateOp.IsPopupCalendarOpen = False
        Me.Input_DateOp.Location = New System.Drawing.Point(333, 20)
        Me.Input_DateOp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        '
        '
        '
        '
        '
        '
        Me.Input_DateOp.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_DateOp.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.Input_DateOp.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.Input_DateOp.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.Input_DateOp.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.Input_DateOp.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.Input_DateOp.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Input_DateOp.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.Input_DateOp.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.Input_DateOp.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_DateOp.MonthCalendar.DisplayMonth = New Date(2019, 6, 1, 0, 0, 0, 0)
        Me.Input_DateOp.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.Input_DateOp.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Input_DateOp.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.Input_DateOp.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Input_DateOp.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_DateOp.MonthCalendar.TodayButtonVisible = True
        Me.Input_DateOp.Name = "Input_DateOp"
        Me.Input_DateOp.Size = New System.Drawing.Size(159, 26)
        Me.Input_DateOp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Input_DateOp.TabIndex = 37
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Location = New System.Drawing.Point(216, 20)
        Me.LabelX8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(100, 29)
        Me.LabelX8.TabIndex = 36
        Me.LabelX8.Text = "Date"
        '
        'Btn_Print_Simple
        '
        Me.Btn_Print_Simple.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_Print_Simple.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.Btn_Print_Simple.Location = New System.Drawing.Point(302, 202)
        Me.Btn_Print_Simple.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btn_Print_Simple.Name = "Btn_Print_Simple"
        Me.Btn_Print_Simple.Size = New System.Drawing.Size(190, 86)
        Me.Btn_Print_Simple.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_Print_Simple.TabIndex = 35
        Me.Btn_Print_Simple.Text = "Imprimer Prestation Simple"
        '
        'Btn_Print_Empty
        '
        Me.Btn_Print_Empty.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_Print_Empty.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.Btn_Print_Empty.Location = New System.Drawing.Point(19, 202)
        Me.Btn_Print_Empty.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btn_Print_Empty.Name = "Btn_Print_Empty"
        Me.Btn_Print_Empty.Size = New System.Drawing.Size(190, 86)
        Me.Btn_Print_Empty.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_Print_Empty.TabIndex = 34
        Me.Btn_Print_Empty.Text = "Imprimer Sans Prestation"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.Input_Adresse)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(511, 98)
        Me.GroupPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(553, 195)
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
        Me.GroupPanel1.TabIndex = 33
        Me.GroupPanel1.Text = "Address"
        '
        'Input_Adresse
        '
        '
        '
        '
        Me.Input_Adresse.BackgroundStyle.Class = "RichTextBoxBorder"
        Me.Input_Adresse.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_Adresse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Input_Adresse.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Input_Adresse.Location = New System.Drawing.Point(0, 0)
        Me.Input_Adresse.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Input_Adresse.Name = "Input_Adresse"
        Me.Input_Adresse.Rtf = "{\rtf1\ansi\deff0{\fonttbl{\f0\fnil\fcharset0 Arial;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\viewkind4\uc1\pard\lang4" &
    "108\fs24  \par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Input_Adresse.Size = New System.Drawing.Size(547, 168)
        Me.Input_Adresse.TabIndex = 2
        Me.Input_Adresse.Text = " "
        '
        'Input_Libellé
        '
        '
        '
        '
        Me.Input_Libellé.Border.Class = "TextBoxBorder"
        Me.Input_Libellé.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_Libellé.Location = New System.Drawing.Point(19, 170)
        Me.Input_Libellé.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Input_Libellé.Name = "Input_Libellé"
        Me.Input_Libellé.PreventEnterBeep = True
        Me.Input_Libellé.Size = New System.Drawing.Size(472, 26)
        Me.Input_Libellé.TabIndex = 32
        '
        'LabelX33
        '
        '
        '
        '
        Me.LabelX33.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX33.Location = New System.Drawing.Point(19, 134)
        Me.LabelX33.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX33.Name = "LabelX33"
        Me.LabelX33.Size = New System.Drawing.Size(472, 29)
        Me.LabelX33.TabIndex = 31
        Me.LabelX33.Text = "Libellé"
        '
        'Input_Concerne
        '
        Me.Input_Concerne.DisplayMember = "Text"
        Me.Input_Concerne.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Input_Concerne.FormattingEnabled = True
        Me.Input_Concerne.ItemHeight = 21
        Me.Input_Concerne.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3, Me.ComboItem4, Me.ComboItem5, Me.ComboItem6, Me.ComboItem7, Me.ComboItem8, Me.ComboItem9, Me.ComboItem10, Me.ComboItem11, Me.ComboItem12})
        Me.Input_Concerne.Location = New System.Drawing.Point(19, 98)
        Me.Input_Concerne.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Input_Concerne.Name = "Input_Concerne"
        Me.Input_Concerne.Size = New System.Drawing.Size(472, 27)
        Me.Input_Concerne.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Input_Concerne.TabIndex = 26
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
        Me.LabelX27.Location = New System.Drawing.Point(18, 61)
        Me.LabelX27.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX27.Name = "LabelX27"
        Me.LabelX27.Size = New System.Drawing.Size(474, 29)
        Me.LabelX27.TabIndex = 25
        Me.LabelX27.Text = "Concerne : "
        '
        'LabelX23
        '
        '
        '
        '
        Me.LabelX23.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX23.Location = New System.Drawing.Point(19, 20)
        Me.LabelX23.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX23.Name = "LabelX23"
        Me.LabelX23.Size = New System.Drawing.Size(100, 29)
        Me.LabelX23.TabIndex = 24
        Me.LabelX23.Text = "N° de Facture"
        '
        'Input_N
        '
        '
        '
        '
        Me.Input_N.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Input_N.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_N.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.Input_N.Location = New System.Drawing.Point(126, 21)
        Me.Input_N.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Input_N.Name = "Input_N"
        Me.Input_N.ShowUpDown = True
        Me.Input_N.Size = New System.Drawing.Size(83, 26)
        Me.Input_N.TabIndex = 23
        '
        'SuperTabItem1
        '
        Me.SuperTabItem1.AttachedControl = Me.SuperTabControlPanel1
        Me.SuperTabItem1.GlobalItem = False
        Me.SuperTabItem1.ImageIndex = 14
        Me.SuperTabItem1.Name = "SuperTabItem1"
        Me.SuperTabItem1.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Red
        Me.SuperTabItem1.Text = "Facture"
        '
        'PanelDockContainer1
        '
        Me.PanelDockContainer1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelDockContainer1.Controls.Add(Me.SGC)
        Me.PanelDockContainer1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelDockContainer1.Location = New System.Drawing.Point(3, 28)
        Me.PanelDockContainer1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelDockContainer1.Name = "PanelDockContainer1"
        Me.PanelDockContainer1.Size = New System.Drawing.Size(1155, 334)
        Me.PanelDockContainer1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelDockContainer1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelDockContainer1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.PanelDockContainer1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelDockContainer1.Style.GradientAngle = 90
        Me.PanelDockContainer1.TabIndex = 0
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
        Me.SGC.Size = New System.Drawing.Size(1155, 334)
        Me.SGC.TabIndex = 32
        Me.SGC.Text = "superGridControl1"
        '
        'DockContainerItem1
        '
        Me.DockContainerItem1.Control = Me.PanelDockContainer1
        Me.DockContainerItem1.Image = Global.Chronos.My.Resources.Resources.book1
        Me.DockContainerItem1.Name = "DockContainerItem1"
        Me.DockContainerItem1.PredefinedTabColor = DevComponents.DotNetBar.eTabItemColor.Teal
        Me.DockContainerItem1.Text = "Liste"
        '
        'DockContainerItem2
        '
        Me.DockContainerItem2.Control = Me.PanelDockContainer2
        Me.DockContainerItem2.Image = Global.Chronos.My.Resources.Resources.pen
        Me.DockContainerItem2.Name = "DockContainerItem2"
        Me.DockContainerItem2.PredefinedTabColor = DevComponents.DotNetBar.eTabItemColor.Blue
        Me.DockContainerItem2.Text = "Modifier"
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
        'DockSite1
        '
        Me.DockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite1.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite1.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite1.Location = New System.Drawing.Point(0, 180)
        Me.DockSite1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DockSite1.Name = "DockSite1"
        Me.DockSite1.Size = New System.Drawing.Size(0, 365)
        Me.DockSite1.TabIndex = 21
        Me.DockSite1.TabStop = False
        '
        'DockSite2
        '
        Me.DockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite2.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite2.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite2.Location = New System.Drawing.Point(1161, 180)
        Me.DockSite2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DockSite2.Name = "DockSite2"
        Me.DockSite2.Size = New System.Drawing.Size(0, 365)
        Me.DockSite2.TabIndex = 22
        Me.DockSite2.TabStop = False
        '
        'DockSite8
        '
        Me.DockSite8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DockSite8.Location = New System.Drawing.Point(0, 671)
        Me.DockSite8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DockSite8.Name = "DockSite8"
        Me.DockSite8.Size = New System.Drawing.Size(1161, 0)
        Me.DockSite8.TabIndex = 28
        Me.DockSite8.TabStop = False
        '
        'DockSite5
        '
        Me.DockSite5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite5.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite5.Location = New System.Drawing.Point(0, 105)
        Me.DockSite5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DockSite5.Name = "DockSite5"
        Me.DockSite5.Size = New System.Drawing.Size(0, 566)
        Me.DockSite5.TabIndex = 25
        Me.DockSite5.TabStop = False
        '
        'DockSite6
        '
        Me.DockSite6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite6.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite6.Location = New System.Drawing.Point(1161, 105)
        Me.DockSite6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DockSite6.Name = "DockSite6"
        Me.DockSite6.Size = New System.Drawing.Size(0, 566)
        Me.DockSite6.TabIndex = 26
        Me.DockSite6.TabStop = False
        '
        'DockSite7
        '
        Me.DockSite7.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite7.Controls.Add(Me.Bar2)
        Me.DockSite7.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite7.Location = New System.Drawing.Point(0, 48)
        Me.DockSite7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DockSite7.Name = "DockSite7"
        Me.DockSite7.Size = New System.Drawing.Size(1161, 57)
        Me.DockSite7.TabIndex = 27
        Me.DockSite7.TabStop = False
        '
        'Bar2
        '
        Me.Bar2.AccessibleDescription = "DotNetBar Bar (Bar2)"
        Me.Bar2.AccessibleName = "DotNetBar Bar"
        Me.Bar2.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.Bar2.DockSide = DevComponents.DotNetBar.eDockSide.Top
        Me.Bar2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Bar2.IsMaximized = False
        Me.Bar2.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonX1, Me.Btn_Add, Me.ButtonX2, Me.ButtonX3, Me.ButtonX4, Me.ButtonItem2})
        Me.Bar2.Location = New System.Drawing.Point(0, 0)
        Me.Bar2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Bar2.MenuBar = True
        Me.Bar2.Name = "Bar2"
        Me.Bar2.Size = New System.Drawing.Size(1161, 56)
        Me.Bar2.Stretch = True
        Me.Bar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar2.TabIndex = 0
        Me.Bar2.TabStop = False
        Me.Bar2.Text = "Bar2"
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
        'ButtonItem2
        '
        Me.ButtonItem2.ImageIndex = 46
        Me.ButtonItem2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Btn_SendToExcel})
        Me.ButtonItem2.Text = "Send"
        '
        'Btn_SendToExcel
        '
        Me.Btn_SendToExcel.Name = "Btn_SendToExcel"
        Me.Btn_SendToExcel.Text = "To Excel"
        '
        'DockSite3
        '
        Me.DockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite3.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite3.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite3.Location = New System.Drawing.Point(0, 105)
        Me.DockSite3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DockSite3.Name = "DockSite3"
        Me.DockSite3.Size = New System.Drawing.Size(1161, 0)
        Me.DockSite3.TabIndex = 23
        Me.DockSite3.TabStop = False
        '
        'BW
        '
        Me.BW.WorkerReportsProgress = True
        Me.BW.WorkerSupportsCancellation = True
        '
        'Btn_CalculateTotal
        '
        Me.Btn_CalculateTotal.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_CalculateTotal.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.Btn_CalculateTotal.Location = New System.Drawing.Point(872, 9)
        Me.Btn_CalculateTotal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btn_CalculateTotal.Name = "Btn_CalculateTotal"
        Me.Btn_CalculateTotal.Size = New System.Drawing.Size(122, 29)
        Me.Btn_CalculateTotal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_CalculateTotal.TabIndex = 25
        Me.Btn_CalculateTotal.Text = "Calculer Total"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(16, 8)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(109, 29)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Choisir Client"
        '
        'Input_Mandat
        '
        Me.Input_Mandat.DisplayMember = "Text"
        Me.Input_Mandat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Input_Mandat.FormattingEnabled = True
        Me.Input_Mandat.ItemHeight = 21
        Me.Input_Mandat.Location = New System.Drawing.Point(134, 8)
        Me.Input_Mandat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Input_Mandat.Name = "Input_Mandat"
        Me.Input_Mandat.Size = New System.Drawing.Size(136, 27)
        Me.Input_Mandat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Input_Mandat.TabIndex = 1
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(323, 8)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(97, 29)
        Me.LabelX2.TabIndex = 2
        Me.LabelX2.Text = "Date Départ : "
        '
        'Input_DateStart
        '
        '
        '
        '
        Me.Input_DateStart.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Input_DateStart.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_DateStart.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.Input_DateStart.ButtonDropDown.Visible = True
        Me.Input_DateStart.IsPopupCalendarOpen = False
        Me.Input_DateStart.Location = New System.Drawing.Point(426, 9)
        Me.Input_DateStart.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        '
        '
        '
        '
        '
        '
        Me.Input_DateStart.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_DateStart.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.Input_DateStart.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.Input_DateStart.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.Input_DateStart.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.Input_DateStart.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.Input_DateStart.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Input_DateStart.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.Input_DateStart.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.Input_DateStart.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_DateStart.MonthCalendar.DisplayMonth = New Date(2019, 6, 1, 0, 0, 0, 0)
        Me.Input_DateStart.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.Input_DateStart.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Input_DateStart.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.Input_DateStart.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Input_DateStart.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_DateStart.MonthCalendar.TodayButtonVisible = True
        Me.Input_DateStart.Name = "Input_DateStart"
        Me.Input_DateStart.Size = New System.Drawing.Size(159, 26)
        Me.Input_DateStart.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Input_DateStart.TabIndex = 3
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(323, 42)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(80, 29)
        Me.LabelX3.TabIndex = 4
        Me.LabelX3.Text = "Date Fin : "
        '
        'Input_DateEnd
        '
        '
        '
        '
        Me.Input_DateEnd.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Input_DateEnd.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_DateEnd.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.Input_DateEnd.ButtonDropDown.Visible = True
        Me.Input_DateEnd.IsPopupCalendarOpen = False
        Me.Input_DateEnd.Location = New System.Drawing.Point(426, 42)
        Me.Input_DateEnd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        '
        '
        '
        '
        '
        '
        Me.Input_DateEnd.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_DateEnd.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.Input_DateEnd.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.Input_DateEnd.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.Input_DateEnd.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.Input_DateEnd.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.Input_DateEnd.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Input_DateEnd.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.Input_DateEnd.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.Input_DateEnd.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_DateEnd.MonthCalendar.DisplayMonth = New Date(2019, 6, 1, 0, 0, 0, 0)
        Me.Input_DateEnd.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.Input_DateEnd.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Input_DateEnd.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.Input_DateEnd.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Input_DateEnd.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_DateEnd.MonthCalendar.TodayButtonVisible = True
        Me.Input_DateEnd.Name = "Input_DateEnd"
        Me.Input_DateEnd.Size = New System.Drawing.Size(159, 26)
        Me.Input_DateEnd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Input_DateEnd.TabIndex = 5
        '
        'Invoice_Filter
        '
        Me.Invoice_Filter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Invoice_Filter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Invoice_Filter.Location = New System.Drawing.Point(592, 9)
        Me.Invoice_Filter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Invoice_Filter.Name = "Invoice_Filter"
        Me.Invoice_Filter.Size = New System.Drawing.Size(216, 32)
        Me.Invoice_Filter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Invoice_Filter.TabIndex = 6
        Me.Invoice_Filter.Text = "Rechercher Factures"
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(1000, 9)
        Me.LabelX6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(118, 29)
        Me.LabelX6.TabIndex = 51
        Me.LabelX6.Text = "Total "
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(16, 42)
        Me.LabelX7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(109, 29)
        Me.LabelX7.TabIndex = 52
        Me.LabelX7.Text = "Prestation Par"
        '
        'Input_Total
        '
        '
        '
        '
        Me.Input_Total.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Input_Total.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_Total.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.Input_Total.Increment = 1.0R
        Me.Input_Total.Location = New System.Drawing.Point(1000, 42)
        Me.Input_Total.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Input_Total.Name = "Input_Total"
        Me.Input_Total.ShowUpDown = True
        Me.Input_Total.Size = New System.Drawing.Size(126, 26)
        Me.Input_Total.TabIndex = 52
        '
        'Input_Société
        '
        Me.Input_Société.DisplayMember = "Text"
        Me.Input_Société.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Input_Société.FormattingEnabled = True
        Me.Input_Société.ItemHeight = 21
        Me.Input_Société.Location = New System.Drawing.Point(134, 42)
        Me.Input_Société.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Input_Société.Name = "Input_Société"
        Me.Input_Société.Size = New System.Drawing.Size(136, 27)
        Me.Input_Société.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Input_Société.TabIndex = 53
        '
        'Btn_Select_All
        '
        Me.Btn_Select_All.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_Select_All.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Btn_Select_All.Location = New System.Drawing.Point(592, 42)
        Me.Btn_Select_All.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btn_Select_All.Name = "Btn_Select_All"
        Me.Btn_Select_All.Size = New System.Drawing.Size(158, 29)
        Me.Btn_Select_All.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_Select_All.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Btn_Deselect_All})
        Me.Btn_Select_All.TabIndex = 54
        Me.Btn_Select_All.Text = "Tous Sélectionner"
        '
        'Btn_Deselect_All
        '
        Me.Btn_Deselect_All.GlobalItem = False
        Me.Btn_Deselect_All.Name = "Btn_Deselect_All"
        Me.Btn_Deselect_All.Text = "Tous Déselectionner"
        '
        'PanelEx4
        '
        Me.PanelEx4.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx4.Controls.Add(Me.Btn_Select_All)
        Me.PanelEx4.Controls.Add(Me.Input_Société)
        Me.PanelEx4.Controls.Add(Me.Input_Total)
        Me.PanelEx4.Controls.Add(Me.LabelX7)
        Me.PanelEx4.Controls.Add(Me.LabelX6)
        Me.PanelEx4.Controls.Add(Me.Invoice_Filter)
        Me.PanelEx4.Controls.Add(Me.Input_DateEnd)
        Me.PanelEx4.Controls.Add(Me.LabelX3)
        Me.PanelEx4.Controls.Add(Me.Input_DateStart)
        Me.PanelEx4.Controls.Add(Me.LabelX2)
        Me.PanelEx4.Controls.Add(Me.Input_Mandat)
        Me.PanelEx4.Controls.Add(Me.LabelX1)
        Me.PanelEx4.Controls.Add(Me.Btn_CalculateTotal)
        Me.PanelEx4.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx4.Location = New System.Drawing.Point(0, 105)
        Me.PanelEx4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelEx4.Name = "PanelEx4"
        Me.PanelEx4.Size = New System.Drawing.Size(1161, 75)
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
        'FactureViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DockSite9)
        Me.Controls.Add(Me.DockSite2)
        Me.Controls.Add(Me.DockSite1)
        Me.Controls.Add(Me.PanelEx6)
        Me.Controls.Add(Me.PanelEx5)
        Me.Controls.Add(Me.PanelEx4)
        Me.Controls.Add(Me.DockSite3)
        Me.Controls.Add(Me.DockSite4)
        Me.Controls.Add(Me.DockSite5)
        Me.Controls.Add(Me.DockSite6)
        Me.Controls.Add(Me.DockSite7)
        Me.Controls.Add(Me.DockSite8)
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FactureViewer"
        Me.Size = New System.Drawing.Size(1161, 671)
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx3.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx5.ResumeLayout(False)
        Me.PanelEx6.ResumeLayout(False)
        CType(Me.Input_Total_TVA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Input_Total_HTVA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Input_Total_Frais, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Input_Total_Prestation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockSite9.ResumeLayout(False)
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bar1.ResumeLayout(False)
        Me.PanelDockContainer2.ResumeLayout(False)
        Me.PanelEx7.ResumeLayout(False)
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControl1.ResumeLayout(False)
        Me.SuperTabControlPanel2.ResumeLayout(False)
        Me.PanelEx9.ResumeLayout(False)
        Me.SuperTabControlPanel1.ResumeLayout(False)
        Me.PanelEx8.ResumeLayout(False)
        CType(Me.Input_DateOp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.Input_N, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDockContainer1.ResumeLayout(False)
        Me.DockSite7.ResumeLayout(False)
        CType(Me.Bar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Input_DateStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Input_DateEnd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Input_Total, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelEx5 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Vcr1 As SmartCoder.SuperGridDemo.VcrControl
    Friend WithEvents PanelEx6 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents TVA As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Input_Total_TVA As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Input_Total_HTVA As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX30 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX31 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Input_Quantity_Frais As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX19 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Input_Quantity_Prestation As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Input_Total_Frais As DevComponents.Editors.DoubleInput
    Friend WithEvents Input_Total_Prestation As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX28 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents IL_ As ImageList
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents IL_Client As ImageList
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DotNetBarManager1 As DevComponents.DotNetBar.DotNetBarManager
    Friend WithEvents DockSite4 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite9 As DevComponents.DotNetBar.DockSite
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents PanelDockContainer1 As DevComponents.DotNetBar.PanelDockContainer
    Friend WithEvents DockContainerItem1 As DevComponents.DotNetBar.DockContainerItem
    Friend WithEvents DockSite1 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite2 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite3 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite5 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite6 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite7 As DevComponents.DotNetBar.DockSite
    Friend WithEvents Bar2 As DevComponents.DotNetBar.Bar
    Friend WithEvents DockSite8 As DevComponents.DotNetBar.DockSite
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Btn_Add As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonX4 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Btn_SendToExcel As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents PanelDockContainer2 As DevComponents.DotNetBar.PanelDockContainer
    Friend WithEvents PanelEx7 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents SuperTabControl1 As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents SuperTabControlPanel1 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents PanelEx8 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents SuperTabItem1 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents PanelEx9 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents SuperTabItem2 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents DockContainerItem2 As DevComponents.DotNetBar.DockContainerItem
    Friend WithEvents LabelX23 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Input_N As DevComponents.Editors.IntegerInput
    Friend WithEvents Input_Concerne As DevComponents.DotNetBar.Controls.ComboBoxEx
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
    Friend WithEvents Input_Libellé As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX33 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Input_Adresse As DevComponents.DotNetBar.Controls.RichTextBoxEx
    Friend WithEvents Btn_Print_Empty As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Btn_Print_Simple As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Input_DateOp As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Input_Code As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Btn_Verify As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BW As System.ComponentModel.BackgroundWorker
    Friend WithEvents PrestationViewer1 As PrestationViewer
    Private WithEvents SGC As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents PanelEx4 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Btn_Select_All As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Btn_Deselect_All As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Input_Société As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Input_Total As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Invoice_Filter As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Input_DateEnd As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Input_DateStart As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Input_Mandat As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Btn_CalculateTotal As DevComponents.DotNetBar.ButtonX
    Friend WithEvents IL_32 As ImageList
End Class
