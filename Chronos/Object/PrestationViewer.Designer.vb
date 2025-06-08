<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PrestationViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrestationViewer))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelEx4 = New DevComponents.DotNetBar.PanelEx()
        Me.Vcr1 = New SmartCoder.SuperGridDemo.VcrControl()
        Me.IL_ = New System.Windows.Forms.ImageList(Me.components)
        Me.IL_Client = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.IL_32 = New System.Windows.Forms.ImageList(Me.components)
        Me.BW = New System.ComponentModel.BackgroundWorker()
        Me.DotNetBarManager1 = New DevComponents.DotNetBar.DotNetBarManager(Me.components)
        Me.DockSite4 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite9 = New DevComponents.DotNetBar.DockSite()
        Me.Bar2 = New DevComponents.DotNetBar.Bar()
        Me.PanelDockContainer3 = New DevComponents.DotNetBar.PanelDockContainer()
        Me.PanelEx9 = New DevComponents.DotNetBar.PanelEx()
        Me.SuperTabControl1 = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.PanelEx10 = New DevComponents.DotNetBar.PanelEx()
        Me.ButtonX6 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX5 = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Input_Adresse = New DevComponents.DotNetBar.Controls.RichTextBoxEx()
        Me.Btn_Verify = New DevComponents.DotNetBar.ButtonX()
        Me.Input_Code = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.Btn_Print_Simple = New DevComponents.DotNetBar.ButtonX()
        Me.Btn_Print_Empty = New DevComponents.DotNetBar.ButtonX()
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
        Me.SuperTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.PanelEx11 = New DevComponents.DotNetBar.PanelEx()
        Me.SGC2 = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.SuperTabItem2 = New DevComponents.DotNetBar.SuperTabItem()
        Me.PanelDockContainer2 = New DevComponents.DotNetBar.PanelDockContainer()
        Me.PanelEx8 = New DevComponents.DotNetBar.PanelEx()
        Me.CB_Client = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX21 = New DevComponents.DotNetBar.LabelX()
        Me.Btn_Validate = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx12 = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx14 = New DevComponents.DotNetBar.PanelEx()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PanelEx15 = New DevComponents.DotNetBar.PanelEx()
        Me.Input_Description = New DevComponents.DotNetBar.Controls.RichTextBoxEx()
        Me.ExpandablePanel1 = New DevComponents.DotNetBar.ExpandablePanel()
        Me.PanelEx13 = New DevComponents.DotNetBar.PanelEx()
        Me.CB_Prestation = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX()
        Me.CB_Type = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Btn_InsertLine = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX16 = New DevComponents.DotNetBar.LabelX()
        Me.CB_Service = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX20 = New DevComponents.DotNetBar.LabelX()
        Me.Input_GrandTOTAL = New DevComponents.Editors.DoubleInput()
        Me.LabelX18 = New DevComponents.DotNetBar.LabelX()
        Me.Input_TotalHTVA = New DevComponents.Editors.DoubleInput()
        Me.LabelX17 = New DevComponents.DotNetBar.LabelX()
        Me.Input_Quantity = New DevComponents.Editors.DoubleInput()
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.Input_Facturable = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.Input_UnitPrice = New DevComponents.Editors.DoubleInput()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.Input_TimeIn = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Input_Collaborateur = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.PanelDockContainer1 = New DevComponents.DotNetBar.PanelDockContainer()
        Me.PanelEx7 = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx16 = New DevComponents.DotNetBar.PanelEx()
        Me.SGC = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.PanelEx5 = New DevComponents.DotNetBar.PanelEx()
        Me.LabelX24 = New DevComponents.DotNetBar.LabelX()
        Me.SW_Limit = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.Forfais_Value = New DevComponents.Editors.DoubleInput()
        Me.LabelX22 = New DevComponents.DotNetBar.LabelX()
        Me.Btn_Select_All = New DevComponents.DotNetBar.ButtonX()
        Me.Btn_Deselect_All = New DevComponents.DotNetBar.ButtonItem()
        Me.Input_Société = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.Invoice_Filter = New DevComponents.DotNetBar.ButtonX()
        Me.Input_DateEnd = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.Input_DateStart = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.Input_Mandat = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.Btn_CalculateTotal = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx6 = New DevComponents.DotNetBar.PanelEx()
        Me.TVA = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.Input_Total = New DevComponents.Editors.DoubleInput()
        Me.Input_Total_TVA = New DevComponents.Editors.DoubleInput()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
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
        Me.DockContainerItem1 = New DevComponents.DotNetBar.DockContainerItem()
        Me.DockContainerItem3 = New DevComponents.DotNetBar.DockContainerItem()
        Me.DockContainerItem2 = New DevComponents.DotNetBar.DockContainerItem()
        Me.DockSite1 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite2 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite8 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite5 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite6 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite7 = New DevComponents.DotNetBar.DockSite()
        Me.Bar1 = New DevComponents.DotNetBar.Bar()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonItem()
        Me.Btn_Add = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonX4 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.Btn_SendToExcel = New DevComponents.DotNetBar.ButtonItem()
        Me.DockSite3 = New DevComponents.DotNetBar.DockSite()
        Me.PanelEx1.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx4.SuspendLayout()
        Me.DockSite9.SuspendLayout()
        CType(Me.Bar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bar2.SuspendLayout()
        Me.PanelDockContainer3.SuspendLayout()
        Me.PanelEx9.SuspendLayout()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControl1.SuspendLayout()
        Me.SuperTabControlPanel1.SuspendLayout()
        Me.PanelEx10.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.Input_N, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControlPanel2.SuspendLayout()
        Me.PanelEx11.SuspendLayout()
        Me.PanelDockContainer2.SuspendLayout()
        Me.PanelEx8.SuspendLayout()
        Me.PanelEx12.SuspendLayout()
        Me.PanelEx14.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.PanelEx15.SuspendLayout()
        Me.ExpandablePanel1.SuspendLayout()
        Me.PanelEx13.SuspendLayout()
        CType(Me.Input_GrandTOTAL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Input_TotalHTVA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Input_Quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Input_UnitPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Input_TimeIn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDockContainer1.SuspendLayout()
        Me.PanelEx7.SuspendLayout()
        Me.PanelEx16.SuspendLayout()
        Me.PanelEx5.SuspendLayout()
        CType(Me.Forfais_Value, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Input_DateEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Input_DateStart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx6.SuspendLayout()
        CType(Me.Input_Total, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Input_Total_TVA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Input_Total_HTVA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Input_Total_Frais, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Input_Total_Prestation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockSite7.SuspendLayout()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelEx1.Size = New System.Drawing.Size(1151, 48)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 4
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
        Me.PanelEx3.Size = New System.Drawing.Size(1088, 48)
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
        Me.ReflectionLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReflectionLabel1.Location = New System.Drawing.Point(0, 0)
        Me.ReflectionLabel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(1088, 48)
        Me.ReflectionLabel1.TabIndex = 0
        Me.ReflectionLabel1.Text = "<font color=""#8066A0""><b>Prestations</b></font>"
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
        Me.PictureBox1.Image = Global.Chronos.My.Resources.Resources.clock
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(63, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelEx4
        '
        Me.PanelEx4.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx4.Controls.Add(Me.Vcr1)
        Me.PanelEx4.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelEx4.Location = New System.Drawing.Point(0, 640)
        Me.PanelEx4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelEx4.Name = "PanelEx4"
        Me.PanelEx4.Size = New System.Drawing.Size(1151, 48)
        Me.PanelEx4.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx4.Style.BackColor1.Color = System.Drawing.Color.White
        Me.PanelEx4.Style.BackColor2.Color = System.Drawing.Color.White
        Me.PanelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx4.Style.GradientAngle = 90
        Me.PanelEx4.TabIndex = 11
        Me.PanelEx4.Text = " "
        '
        'Vcr1
        '
        Me.Vcr1.BackColor = System.Drawing.Color.Transparent
        Me.Vcr1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Vcr1.Location = New System.Drawing.Point(0, 0)
        Me.Vcr1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Vcr1.Name = "Vcr1"
        Me.Vcr1.Size = New System.Drawing.Size(1151, 48)
        Me.Vcr1.TabIndex = 15
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
        'BW
        '
        Me.BW.WorkerReportsProgress = True
        Me.BW.WorkerSupportsCancellation = True
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
        Me.DockSite4.Location = New System.Drawing.Point(0, 688)
        Me.DockSite4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DockSite4.Name = "DockSite4"
        Me.DockSite4.Size = New System.Drawing.Size(1151, 0)
        Me.DockSite4.TabIndex = 45
        Me.DockSite4.TabStop = False
        '
        'DockSite9
        '
        Me.DockSite9.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite9.Controls.Add(Me.Bar2)
        Me.DockSite9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DockSite9.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer(New DevComponents.DotNetBar.DocumentBaseContainer() {CType(New DevComponents.DotNetBar.DocumentBarContainer(Me.Bar2, 1151, 535), DevComponents.DotNetBar.DocumentBaseContainer)}, DevComponents.DotNetBar.eOrientation.Horizontal)
        Me.DockSite9.Location = New System.Drawing.Point(0, 105)
        Me.DockSite9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DockSite9.Name = "DockSite9"
        Me.DockSite9.Size = New System.Drawing.Size(1151, 535)
        Me.DockSite9.TabIndex = 50
        Me.DockSite9.TabStop = False
        '
        'Bar2
        '
        Me.Bar2.AccessibleDescription = "DotNetBar Bar (Bar2)"
        Me.Bar2.AccessibleName = "DotNetBar Bar"
        Me.Bar2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.Bar2.AlwaysDisplayDockTab = True
        Me.Bar2.CanCustomize = False
        Me.Bar2.CanDockBottom = False
        Me.Bar2.CanDockDocument = True
        Me.Bar2.CanDockLeft = False
        Me.Bar2.CanDockRight = False
        Me.Bar2.CanDockTop = False
        Me.Bar2.CanHide = True
        Me.Bar2.CanUndock = False
        Me.Bar2.Controls.Add(Me.PanelDockContainer3)
        Me.Bar2.Controls.Add(Me.PanelDockContainer2)
        Me.Bar2.Controls.Add(Me.PanelDockContainer1)
        Me.Bar2.DockTabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top
        Me.Bar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bar2.IsMaximized = False
        Me.Bar2.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.DockContainerItem1, Me.DockContainerItem3, Me.DockContainerItem2})
        Me.Bar2.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer
        Me.Bar2.Location = New System.Drawing.Point(0, 0)
        Me.Bar2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Bar2.Name = "Bar2"
        Me.Bar2.SelectedDockTab = 1
        Me.Bar2.Size = New System.Drawing.Size(1151, 535)
        Me.Bar2.Stretch = True
        Me.Bar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar2.TabIndex = 0
        Me.Bar2.TabNavigation = True
        Me.Bar2.TabStop = False
        '
        'PanelDockContainer3
        '
        Me.PanelDockContainer3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelDockContainer3.Controls.Add(Me.PanelEx9)
        Me.PanelDockContainer3.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelDockContainer3.Location = New System.Drawing.Point(3, 28)
        Me.PanelDockContainer3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelDockContainer3.Name = "PanelDockContainer3"
        Me.PanelDockContainer3.Size = New System.Drawing.Size(1145, 504)
        Me.PanelDockContainer3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelDockContainer3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelDockContainer3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.PanelDockContainer3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelDockContainer3.Style.GradientAngle = 90
        Me.PanelDockContainer3.TabIndex = 9
        '
        'PanelEx9
        '
        Me.PanelEx9.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx9.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx9.Controls.Add(Me.SuperTabControl1)
        Me.PanelEx9.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx9.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelEx9.Name = "PanelEx9"
        Me.PanelEx9.Size = New System.Drawing.Size(1145, 504)
        Me.PanelEx9.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx9.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx9.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx9.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx9.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx9.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx9.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx9.Style.GradientAngle = 90
        Me.PanelEx9.TabIndex = 8
        Me.PanelEx9.Text = " "
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
        Me.SuperTabControl1.Size = New System.Drawing.Size(1145, 504)
        Me.SuperTabControl1.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Left
        Me.SuperTabControl1.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabControl1.TabIndex = 0
        Me.SuperTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabItem1, Me.SuperTabItem2})
        Me.SuperTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue
        Me.SuperTabControl1.Text = "SuperTabControl1"
        '
        'SuperTabControlPanel1
        '
        Me.SuperTabControlPanel1.Controls.Add(Me.PanelEx10)
        Me.SuperTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel1.Location = New System.Drawing.Point(90, 0)
        Me.SuperTabControlPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SuperTabControlPanel1.Name = "SuperTabControlPanel1"
        Me.SuperTabControlPanel1.Size = New System.Drawing.Size(1055, 504)
        Me.SuperTabControlPanel1.TabIndex = 1
        Me.SuperTabControlPanel1.TabItem = Me.SuperTabItem1
        '
        'PanelEx10
        '
        Me.PanelEx10.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx10.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx10.Controls.Add(Me.ButtonX6)
        Me.PanelEx10.Controls.Add(Me.ButtonX5)
        Me.PanelEx10.Controls.Add(Me.GroupPanel1)
        Me.PanelEx10.Controls.Add(Me.Btn_Verify)
        Me.PanelEx10.Controls.Add(Me.Input_Code)
        Me.PanelEx10.Controls.Add(Me.LabelX9)
        Me.PanelEx10.Controls.Add(Me.Btn_Print_Simple)
        Me.PanelEx10.Controls.Add(Me.Btn_Print_Empty)
        Me.PanelEx10.Controls.Add(Me.Input_Libellé)
        Me.PanelEx10.Controls.Add(Me.LabelX33)
        Me.PanelEx10.Controls.Add(Me.Input_Concerne)
        Me.PanelEx10.Controls.Add(Me.LabelX27)
        Me.PanelEx10.Controls.Add(Me.LabelX23)
        Me.PanelEx10.Controls.Add(Me.Input_N)
        Me.PanelEx10.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx10.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelEx10.Name = "PanelEx10"
        Me.PanelEx10.Size = New System.Drawing.Size(1055, 504)
        Me.PanelEx10.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx10.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx10.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx10.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx10.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx10.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx10.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx10.Style.GradientAngle = 90
        Me.PanelEx10.TabIndex = 8
        Me.PanelEx10.Text = " "
        '
        'ButtonX6
        '
        Me.ButtonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.ButtonX6.Location = New System.Drawing.Point(32, 336)
        Me.ButtonX6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonX6.Name = "ButtonX6"
        Me.ButtonX6.Size = New System.Drawing.Size(190, 50)
        Me.ButtonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX6.TabIndex = 58
        Me.ButtonX6.Text = "Imprimer Prestation sans Totaux"
        '
        'ButtonX5
        '
        Me.ButtonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.ButtonX5.Location = New System.Drawing.Point(305, 220)
        Me.ButtonX5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonX5.Name = "ButtonX5"
        Me.ButtonX5.Size = New System.Drawing.Size(190, 166)
        Me.ButtonX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX5.TabIndex = 57
        Me.ButtonX5.Text = "Créer la Facture"
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
        Me.GroupPanel1.Location = New System.Drawing.Point(511, 101)
        Me.GroupPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(523, 384)
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
        Me.GroupPanel1.TabIndex = 56
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
        Me.Input_Adresse.Rtf = "{\rtf1\ansi\deff0\nouicompat{\fonttbl{\f0\fnil\fcharset0 Arial;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "{\*\generator " &
    "Riched20 10.0.14393}\viewkind4\uc1 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\pard\fs24\lang4108  \par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Input_Adresse.Size = New System.Drawing.Size(517, 357)
        Me.Input_Adresse.TabIndex = 2
        Me.Input_Adresse.Text = " "
        '
        'Btn_Verify
        '
        Me.Btn_Verify.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_Verify.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Btn_Verify.Location = New System.Drawing.Point(569, 64)
        Me.Btn_Verify.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btn_Verify.Name = "Btn_Verify"
        Me.Btn_Verify.Size = New System.Drawing.Size(122, 29)
        Me.Btn_Verify.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_Verify.TabIndex = 55
        Me.Btn_Verify.Text = "Verifer"
        '
        'Input_Code
        '
        '
        '
        '
        Me.Input_Code.Border.Class = "TextBoxBorder"
        Me.Input_Code.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_Code.Location = New System.Drawing.Point(569, 28)
        Me.Input_Code.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Input_Code.Name = "Input_Code"
        Me.Input_Code.PreventEnterBeep = True
        Me.Input_Code.Size = New System.Drawing.Size(453, 26)
        Me.Input_Code.TabIndex = 41
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Location = New System.Drawing.Point(506, 26)
        Me.LabelX9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(56, 29)
        Me.LabelX9.TabIndex = 40
        Me.LabelX9.Text = "Ref"
        '
        'Btn_Print_Simple
        '
        Me.Btn_Print_Simple.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_Print_Simple.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.Btn_Print_Simple.Location = New System.Drawing.Point(30, 278)
        Me.Btn_Print_Simple.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btn_Print_Simple.Name = "Btn_Print_Simple"
        Me.Btn_Print_Simple.Size = New System.Drawing.Size(190, 50)
        Me.Btn_Print_Simple.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_Print_Simple.TabIndex = 36
        Me.Btn_Print_Simple.Text = "Imprimer Prestation avec Totaux"
        '
        'Btn_Print_Empty
        '
        Me.Btn_Print_Empty.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_Print_Empty.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.Btn_Print_Empty.Location = New System.Drawing.Point(30, 220)
        Me.Btn_Print_Empty.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btn_Print_Empty.Name = "Btn_Print_Empty"
        Me.Btn_Print_Empty.Size = New System.Drawing.Size(190, 39)
        Me.Btn_Print_Empty.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_Print_Empty.TabIndex = 35
        Me.Btn_Print_Empty.Text = "Imprimer Sans Prestation"
        '
        'Input_Libellé
        '
        '
        '
        '
        Me.Input_Libellé.Border.Class = "TextBoxBorder"
        Me.Input_Libellé.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_Libellé.Location = New System.Drawing.Point(30, 171)
        Me.Input_Libellé.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Input_Libellé.Name = "Input_Libellé"
        Me.Input_Libellé.PreventEnterBeep = True
        Me.Input_Libellé.Size = New System.Drawing.Size(472, 26)
        Me.Input_Libellé.TabIndex = 34
        '
        'LabelX33
        '
        '
        '
        '
        Me.LabelX33.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX33.Location = New System.Drawing.Point(30, 135)
        Me.LabelX33.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX33.Name = "LabelX33"
        Me.LabelX33.Size = New System.Drawing.Size(472, 29)
        Me.LabelX33.TabIndex = 33
        Me.LabelX33.Text = "Libellé"
        '
        'Input_Concerne
        '
        Me.Input_Concerne.DisplayMember = "Text"
        Me.Input_Concerne.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Input_Concerne.FormattingEnabled = True
        Me.Input_Concerne.ItemHeight = 21
        Me.Input_Concerne.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3, Me.ComboItem4, Me.ComboItem5, Me.ComboItem6, Me.ComboItem7, Me.ComboItem8, Me.ComboItem9, Me.ComboItem10, Me.ComboItem11, Me.ComboItem12})
        Me.Input_Concerne.Location = New System.Drawing.Point(32, 99)
        Me.Input_Concerne.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Input_Concerne.Name = "Input_Concerne"
        Me.Input_Concerne.Size = New System.Drawing.Size(472, 27)
        Me.Input_Concerne.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Input_Concerne.TabIndex = 28
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
        Me.LabelX27.Location = New System.Drawing.Point(30, 62)
        Me.LabelX27.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX27.Name = "LabelX27"
        Me.LabelX27.Size = New System.Drawing.Size(474, 29)
        Me.LabelX27.TabIndex = 27
        Me.LabelX27.Text = "Concerne : "
        '
        'LabelX23
        '
        '
        '
        '
        Me.LabelX23.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX23.Location = New System.Drawing.Point(30, 26)
        Me.LabelX23.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX23.Name = "LabelX23"
        Me.LabelX23.Size = New System.Drawing.Size(100, 29)
        Me.LabelX23.TabIndex = 26
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
        Me.Input_N.Location = New System.Drawing.Point(137, 28)
        Me.Input_N.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Input_N.Name = "Input_N"
        Me.Input_N.ShowUpDown = True
        Me.Input_N.Size = New System.Drawing.Size(83, 26)
        Me.Input_N.TabIndex = 25
        '
        'SuperTabItem1
        '
        Me.SuperTabItem1.AttachedControl = Me.SuperTabControlPanel1
        Me.SuperTabItem1.GlobalItem = False
        Me.SuperTabItem1.Name = "SuperTabItem1"
        Me.SuperTabItem1.Text = "Info"
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.Controls.Add(Me.PanelEx11)
        Me.SuperTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel2.Location = New System.Drawing.Point(101, 0)
        Me.SuperTabControlPanel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SuperTabControlPanel2.Name = "SuperTabControlPanel2"
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(1043, 492)
        Me.SuperTabControlPanel2.TabIndex = 0
        Me.SuperTabControlPanel2.TabItem = Me.SuperTabItem2
        '
        'PanelEx11
        '
        Me.PanelEx11.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx11.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx11.Controls.Add(Me.SGC2)
        Me.PanelEx11.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx11.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx11.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelEx11.Name = "PanelEx11"
        Me.PanelEx11.Size = New System.Drawing.Size(1043, 492)
        Me.PanelEx11.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx11.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx11.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx11.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx11.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx11.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx11.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx11.Style.GradientAngle = 90
        Me.PanelEx11.TabIndex = 8
        Me.PanelEx11.Text = " "
        '
        'SGC2
        '
        Me.SGC2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SGC2.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.SGC2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SGC2.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.SGC2.Location = New System.Drawing.Point(0, 0)
        Me.SGC2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SGC2.Name = "SGC2"
        '
        '
        '
        Me.SGC2.PrimaryGrid.AllowRowDelete = True
        Me.SGC2.PrimaryGrid.AllowRowInsert = True
        Me.SGC2.PrimaryGrid.AllowRowResize = True
        Me.SGC2.PrimaryGrid.AutoHideDeletedRows = False
        '
        '
        '
        Me.SGC2.PrimaryGrid.ColumnHeader.RowHeight = 30
        Me.SGC2.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SGC2.PrimaryGrid.DefaultVisualStyles.RowStyles.Default.RowHeaderStyle.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SGC2.PrimaryGrid.EnableCellExpressions = True
        Me.SGC2.PrimaryGrid.EnableColumnFiltering = True
        Me.SGC2.PrimaryGrid.EnableFiltering = True
        Me.SGC2.PrimaryGrid.EnableRowFiltering = True
        '
        '
        '
        Me.SGC2.PrimaryGrid.Filter.ShowPanelFilterExpr = True
        Me.SGC2.PrimaryGrid.Filter.Visible = True
        Me.SGC2.PrimaryGrid.NoRowsText = "Select a DataSource from the list to the right to populate the grid."
        Me.SGC2.PrimaryGrid.ShowRowGridIndex = True
        '
        '
        '
        Me.SGC2.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled
        Me.SGC2.Size = New System.Drawing.Size(1043, 492)
        Me.SGC2.TabIndex = 32
        Me.SGC2.Text = "superGridControl1"
        '
        'SuperTabItem2
        '
        Me.SuperTabItem2.AttachedControl = Me.SuperTabControlPanel2
        Me.SuperTabItem2.GlobalItem = False
        Me.SuperTabItem2.Name = "SuperTabItem2"
        Me.SuperTabItem2.Text = "Prestations"
        '
        'PanelDockContainer2
        '
        Me.PanelDockContainer2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelDockContainer2.Controls.Add(Me.PanelEx8)
        Me.PanelDockContainer2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelDockContainer2.Location = New System.Drawing.Point(3, 28)
        Me.PanelDockContainer2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelDockContainer2.Name = "PanelDockContainer2"
        Me.PanelDockContainer2.Size = New System.Drawing.Size(1145, 504)
        Me.PanelDockContainer2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelDockContainer2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelDockContainer2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.PanelDockContainer2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelDockContainer2.Style.GradientAngle = 90
        Me.PanelDockContainer2.TabIndex = 5
        '
        'PanelEx8
        '
        Me.PanelEx8.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx8.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx8.Controls.Add(Me.CB_Client)
        Me.PanelEx8.Controls.Add(Me.LabelX21)
        Me.PanelEx8.Controls.Add(Me.Btn_Validate)
        Me.PanelEx8.Controls.Add(Me.PanelEx12)
        Me.PanelEx8.Controls.Add(Me.Input_GrandTOTAL)
        Me.PanelEx8.Controls.Add(Me.LabelX18)
        Me.PanelEx8.Controls.Add(Me.Input_TotalHTVA)
        Me.PanelEx8.Controls.Add(Me.LabelX17)
        Me.PanelEx8.Controls.Add(Me.Input_Quantity)
        Me.PanelEx8.Controls.Add(Me.LabelX14)
        Me.PanelEx8.Controls.Add(Me.LabelX12)
        Me.PanelEx8.Controls.Add(Me.Input_Facturable)
        Me.PanelEx8.Controls.Add(Me.Input_UnitPrice)
        Me.PanelEx8.Controls.Add(Me.LabelX11)
        Me.PanelEx8.Controls.Add(Me.LabelX10)
        Me.PanelEx8.Controls.Add(Me.Input_TimeIn)
        Me.PanelEx8.Controls.Add(Me.Input_Collaborateur)
        Me.PanelEx8.Controls.Add(Me.LabelX8)
        Me.PanelEx8.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx8.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelEx8.Name = "PanelEx8"
        Me.PanelEx8.Size = New System.Drawing.Size(1145, 504)
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
        'CB_Client
        '
        Me.CB_Client.DisplayMember = "Text"
        Me.CB_Client.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CB_Client.FormattingEnabled = True
        Me.CB_Client.ItemHeight = 21
        Me.CB_Client.Location = New System.Drawing.Point(16, 49)
        Me.CB_Client.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CB_Client.Name = "CB_Client"
        Me.CB_Client.Size = New System.Drawing.Size(111, 27)
        Me.CB_Client.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CB_Client.TabIndex = 34
        '
        'LabelX21
        '
        '
        '
        '
        Me.LabelX21.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX21.Location = New System.Drawing.Point(18, 15)
        Me.LabelX21.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX21.Name = "LabelX21"
        Me.LabelX21.Size = New System.Drawing.Size(109, 29)
        Me.LabelX21.TabIndex = 33
        Me.LabelX21.Text = "Client"
        '
        'Btn_Validate
        '
        Me.Btn_Validate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_Validate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Btn_Validate.Location = New System.Drawing.Point(1006, 6)
        Me.Btn_Validate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btn_Validate.Name = "Btn_Validate"
        Me.Btn_Validate.Size = New System.Drawing.Size(84, 29)
        Me.Btn_Validate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_Validate.TabIndex = 32
        Me.Btn_Validate.Text = "Vérifier"
        '
        'PanelEx12
        '
        Me.PanelEx12.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelEx12.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx12.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx12.Controls.Add(Me.PanelEx14)
        Me.PanelEx12.Controls.Add(Me.ExpandablePanel1)
        Me.PanelEx12.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx12.Location = New System.Drawing.Point(0, 105)
        Me.PanelEx12.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelEx12.Name = "PanelEx12"
        Me.PanelEx12.Size = New System.Drawing.Size(1144, 398)
        Me.PanelEx12.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx12.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx12.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx12.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx12.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx12.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx12.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx12.Style.GradientAngle = 90
        Me.PanelEx12.TabIndex = 28
        Me.PanelEx12.Text = " "
        '
        'PanelEx14
        '
        Me.PanelEx14.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx14.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx14.Controls.Add(Me.GroupBox1)
        Me.PanelEx14.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx14.Location = New System.Drawing.Point(536, 0)
        Me.PanelEx14.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelEx14.Name = "PanelEx14"
        Me.PanelEx14.Size = New System.Drawing.Size(608, 398)
        Me.PanelEx14.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx14.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx14.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx14.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx14.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx14.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx14.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx14.Style.GradientAngle = 90
        Me.PanelEx14.TabIndex = 4
        Me.PanelEx14.Text = " "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PanelEx15)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(608, 398)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Description"
        '
        'PanelEx15
        '
        Me.PanelEx15.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx15.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx15.Controls.Add(Me.Input_Description)
        Me.PanelEx15.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx15.Location = New System.Drawing.Point(3, 23)
        Me.PanelEx15.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelEx15.Name = "PanelEx15"
        Me.PanelEx15.Size = New System.Drawing.Size(602, 371)
        Me.PanelEx15.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx15.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx15.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx15.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx15.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx15.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx15.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx15.Style.GradientAngle = 90
        Me.PanelEx15.TabIndex = 36
        Me.PanelEx15.Text = " "
        '
        'Input_Description
        '
        '
        '
        '
        Me.Input_Description.BackgroundStyle.Class = "RichTextBoxBorder"
        Me.Input_Description.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_Description.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Input_Description.Location = New System.Drawing.Point(0, 0)
        Me.Input_Description.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Input_Description.Name = "Input_Description"
        Me.Input_Description.Rtf = "{\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang4108{\fonttbl{\f0\fnil\fcharset0 " &
    "Microsoft Sans Serif;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "{\*\generator Riched20 10.0.14393}\viewkind4\uc1 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\par" &
    "d\f0\fs24\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Input_Description.Size = New System.Drawing.Size(602, 371)
        Me.Input_Description.TabIndex = 1
        '
        'ExpandablePanel1
        '
        Me.ExpandablePanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.ExpandablePanel1.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft
        Me.ExpandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ExpandablePanel1.Controls.Add(Me.PanelEx13)
        Me.ExpandablePanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.ExpandablePanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ExpandablePanel1.HideControlsWhenCollapsed = True
        Me.ExpandablePanel1.Location = New System.Drawing.Point(0, 0)
        Me.ExpandablePanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ExpandablePanel1.Name = "ExpandablePanel1"
        Me.ExpandablePanel1.Size = New System.Drawing.Size(536, 398)
        Me.ExpandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ExpandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.ExpandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.ExpandablePanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.ExpandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandablePanel1.Style.GradientAngle = 90
        Me.ExpandablePanel1.TabIndex = 0
        Me.ExpandablePanel1.TitleHeight = 32
        Me.ExpandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ExpandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.ExpandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.ExpandablePanel1.TitleStyle.GradientAngle = 90
        Me.ExpandablePanel1.TitleText = "Entrée automatiser"
        '
        'PanelEx13
        '
        Me.PanelEx13.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx13.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx13.Controls.Add(Me.CB_Prestation)
        Me.PanelEx13.Controls.Add(Me.LabelX15)
        Me.PanelEx13.Controls.Add(Me.CB_Type)
        Me.PanelEx13.Controls.Add(Me.Btn_InsertLine)
        Me.PanelEx13.Controls.Add(Me.LabelX16)
        Me.PanelEx13.Controls.Add(Me.CB_Service)
        Me.PanelEx13.Controls.Add(Me.LabelX20)
        Me.PanelEx13.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx13.Location = New System.Drawing.Point(0, 32)
        Me.PanelEx13.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelEx13.Name = "PanelEx13"
        Me.PanelEx13.Size = New System.Drawing.Size(536, 366)
        Me.PanelEx13.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx13.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx13.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx13.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx13.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx13.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx13.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx13.Style.GradientAngle = 90
        Me.PanelEx13.TabIndex = 43
        Me.PanelEx13.Text = " "
        '
        'CB_Prestation
        '
        Me.CB_Prestation.DisplayMember = "Text"
        Me.CB_Prestation.Dock = System.Windows.Forms.DockStyle.Top
        Me.CB_Prestation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CB_Prestation.FormattingEnabled = True
        Me.CB_Prestation.ItemHeight = 21
        Me.CB_Prestation.Location = New System.Drawing.Point(0, 141)
        Me.CB_Prestation.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CB_Prestation.Name = "CB_Prestation"
        Me.CB_Prestation.Size = New System.Drawing.Size(536, 27)
        Me.CB_Prestation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CB_Prestation.TabIndex = 29
        '
        'LabelX15
        '
        '
        '
        '
        Me.LabelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX15.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelX15.Location = New System.Drawing.Point(0, 112)
        Me.LabelX15.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.Size = New System.Drawing.Size(536, 29)
        Me.LabelX15.TabIndex = 28
        Me.LabelX15.Text = "   Description : "
        '
        'CB_Type
        '
        Me.CB_Type.DisplayMember = "Text"
        Me.CB_Type.Dock = System.Windows.Forms.DockStyle.Top
        Me.CB_Type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CB_Type.FormattingEnabled = True
        Me.CB_Type.ItemHeight = 21
        Me.CB_Type.Location = New System.Drawing.Point(0, 85)
        Me.CB_Type.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CB_Type.Name = "CB_Type"
        Me.CB_Type.Size = New System.Drawing.Size(536, 27)
        Me.CB_Type.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CB_Type.TabIndex = 22
        '
        'Btn_InsertLine
        '
        Me.Btn_InsertLine.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_InsertLine.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Btn_InsertLine.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Btn_InsertLine.Location = New System.Drawing.Point(0, 337)
        Me.Btn_InsertLine.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btn_InsertLine.Name = "Btn_InsertLine"
        Me.Btn_InsertLine.Size = New System.Drawing.Size(536, 29)
        Me.Btn_InsertLine.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_InsertLine.TabIndex = 30
        Me.Btn_InsertLine.Text = "Insérer"
        '
        'LabelX16
        '
        '
        '
        '
        Me.LabelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX16.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelX16.Location = New System.Drawing.Point(0, 56)
        Me.LabelX16.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX16.Name = "LabelX16"
        Me.LabelX16.Size = New System.Drawing.Size(536, 29)
        Me.LabelX16.TabIndex = 21
        Me.LabelX16.Text = "   Catégories"
        '
        'CB_Service
        '
        Me.CB_Service.DisplayMember = "Text"
        Me.CB_Service.Dock = System.Windows.Forms.DockStyle.Top
        Me.CB_Service.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CB_Service.FormattingEnabled = True
        Me.CB_Service.ItemHeight = 21
        Me.CB_Service.Location = New System.Drawing.Point(0, 29)
        Me.CB_Service.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CB_Service.Name = "CB_Service"
        Me.CB_Service.Size = New System.Drawing.Size(536, 27)
        Me.CB_Service.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CB_Service.TabIndex = 16
        '
        'LabelX20
        '
        '
        '
        '
        Me.LabelX20.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX20.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelX20.Location = New System.Drawing.Point(0, 0)
        Me.LabelX20.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX20.Name = "LabelX20"
        Me.LabelX20.Size = New System.Drawing.Size(536, 29)
        Me.LabelX20.TabIndex = 15
        Me.LabelX20.Text = "   Type de Service"
        '
        'Input_GrandTOTAL
        '
        '
        '
        '
        Me.Input_GrandTOTAL.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Input_GrandTOTAL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_GrandTOTAL.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.Input_GrandTOTAL.Increment = 1.0R
        Me.Input_GrandTOTAL.Location = New System.Drawing.Point(997, 70)
        Me.Input_GrandTOTAL.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Input_GrandTOTAL.Name = "Input_GrandTOTAL"
        Me.Input_GrandTOTAL.ShowUpDown = True
        Me.Input_GrandTOTAL.Size = New System.Drawing.Size(93, 26)
        Me.Input_GrandTOTAL.TabIndex = 27
        '
        'LabelX18
        '
        '
        '
        '
        Me.LabelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX18.Location = New System.Drawing.Point(844, 69)
        Me.LabelX18.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX18.Name = "LabelX18"
        Me.LabelX18.Size = New System.Drawing.Size(140, 29)
        Me.LabelX18.TabIndex = 26
        Me.LabelX18.Text = "Total avec TVA"
        '
        'Input_TotalHTVA
        '
        '
        '
        '
        Me.Input_TotalHTVA.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Input_TotalHTVA.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_TotalHTVA.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.Input_TotalHTVA.Increment = 1.0R
        Me.Input_TotalHTVA.Location = New System.Drawing.Point(997, 38)
        Me.Input_TotalHTVA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Input_TotalHTVA.Name = "Input_TotalHTVA"
        Me.Input_TotalHTVA.ShowUpDown = True
        Me.Input_TotalHTVA.Size = New System.Drawing.Size(93, 26)
        Me.Input_TotalHTVA.TabIndex = 25
        '
        'LabelX17
        '
        '
        '
        '
        Me.LabelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX17.Location = New System.Drawing.Point(844, 36)
        Me.LabelX17.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX17.Name = "LabelX17"
        Me.LabelX17.Size = New System.Drawing.Size(140, 29)
        Me.LabelX17.TabIndex = 24
        Me.LabelX17.Text = "Total sans TVA"
        '
        'Input_Quantity
        '
        '
        '
        '
        Me.Input_Quantity.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Input_Quantity.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_Quantity.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.Input_Quantity.Increment = 1.0R
        Me.Input_Quantity.Location = New System.Drawing.Point(577, 49)
        Me.Input_Quantity.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Input_Quantity.Name = "Input_Quantity"
        Me.Input_Quantity.ShowUpDown = True
        Me.Input_Quantity.Size = New System.Drawing.Size(140, 26)
        Me.Input_Quantity.TabIndex = 23
        '
        'LabelX14
        '
        '
        '
        '
        Me.LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX14.Location = New System.Drawing.Point(579, 19)
        Me.LabelX14.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(140, 29)
        Me.LabelX14.TabIndex = 22
        Me.LabelX14.Text = "Temps"
        '
        'LabelX12
        '
        '
        '
        '
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.Location = New System.Drawing.Point(726, 18)
        Me.LabelX12.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(108, 32)
        Me.LabelX12.TabIndex = 20
        Me.LabelX12.Text = "Facturable ?"
        '
        'Input_Facturable
        '
        '
        '
        '
        Me.Input_Facturable.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_Facturable.Location = New System.Drawing.Point(723, 49)
        Me.Input_Facturable.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Input_Facturable.Name = "Input_Facturable"
        Me.Input_Facturable.OffText = "Non"
        Me.Input_Facturable.OnText = "Oui"
        Me.Input_Facturable.Size = New System.Drawing.Size(93, 28)
        Me.Input_Facturable.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Input_Facturable.TabIndex = 21
        Me.Input_Facturable.Value = True
        Me.Input_Facturable.ValueObject = "Y"
        '
        'Input_UnitPrice
        '
        '
        '
        '
        Me.Input_UnitPrice.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Input_UnitPrice.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_UnitPrice.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.Input_UnitPrice.Increment = 1.0R
        Me.Input_UnitPrice.Location = New System.Drawing.Point(465, 51)
        Me.Input_UnitPrice.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Input_UnitPrice.Name = "Input_UnitPrice"
        Me.Input_UnitPrice.ShowUpDown = True
        Me.Input_UnitPrice.Size = New System.Drawing.Size(93, 26)
        Me.Input_UnitPrice.TabIndex = 19
        '
        'LabelX11
        '
        '
        '
        '
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.Location = New System.Drawing.Point(465, 15)
        Me.LabelX11.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(108, 32)
        Me.LabelX11.TabIndex = 18
        Me.LabelX11.Text = "Tariff horaire"
        '
        'LabelX10
        '
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Location = New System.Drawing.Point(312, 12)
        Me.LabelX10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(140, 29)
        Me.LabelX10.TabIndex = 15
        Me.LabelX10.Text = "Date : "
        '
        'Input_TimeIn
        '
        '
        '
        '
        Me.Input_TimeIn.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Input_TimeIn.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_TimeIn.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.Input_TimeIn.ButtonDropDown.Visible = True
        Me.Input_TimeIn.IsPopupCalendarOpen = False
        Me.Input_TimeIn.Location = New System.Drawing.Point(312, 50)
        Me.Input_TimeIn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        '
        '
        '
        '
        '
        '
        Me.Input_TimeIn.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_TimeIn.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.Input_TimeIn.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.Input_TimeIn.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.Input_TimeIn.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.Input_TimeIn.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.Input_TimeIn.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Input_TimeIn.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.Input_TimeIn.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.Input_TimeIn.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_TimeIn.MonthCalendar.DisplayMonth = New Date(2019, 5, 1, 0, 0, 0, 0)
        Me.Input_TimeIn.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.Input_TimeIn.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Input_TimeIn.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.Input_TimeIn.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Input_TimeIn.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_TimeIn.MonthCalendar.TodayButtonVisible = True
        Me.Input_TimeIn.Name = "Input_TimeIn"
        Me.Input_TimeIn.Size = New System.Drawing.Size(140, 26)
        Me.Input_TimeIn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Input_TimeIn.TabIndex = 16
        '
        'Input_Collaborateur
        '
        Me.Input_Collaborateur.DisplayMember = "Text"
        Me.Input_Collaborateur.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Input_Collaborateur.FormattingEnabled = True
        Me.Input_Collaborateur.ItemHeight = 21
        Me.Input_Collaborateur.Location = New System.Drawing.Point(145, 49)
        Me.Input_Collaborateur.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Input_Collaborateur.Name = "Input_Collaborateur"
        Me.Input_Collaborateur.Size = New System.Drawing.Size(139, 27)
        Me.Input_Collaborateur.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Input_Collaborateur.TabIndex = 6
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Location = New System.Drawing.Point(145, 12)
        Me.LabelX8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(140, 29)
        Me.LabelX8.TabIndex = 5
        Me.LabelX8.Text = "Collaborateur"
        '
        'PanelDockContainer1
        '
        Me.PanelDockContainer1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelDockContainer1.Controls.Add(Me.PanelEx7)
        Me.PanelDockContainer1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelDockContainer1.Location = New System.Drawing.Point(3, 28)
        Me.PanelDockContainer1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelDockContainer1.Name = "PanelDockContainer1"
        Me.PanelDockContainer1.Size = New System.Drawing.Size(1145, 504)
        Me.PanelDockContainer1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelDockContainer1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelDockContainer1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.PanelDockContainer1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelDockContainer1.Style.GradientAngle = 90
        Me.PanelDockContainer1.TabIndex = 0
        '
        'PanelEx7
        '
        Me.PanelEx7.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx7.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx7.Controls.Add(Me.PanelEx16)
        Me.PanelEx7.Controls.Add(Me.PanelEx5)
        Me.PanelEx7.Controls.Add(Me.PanelEx6)
        Me.PanelEx7.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx7.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelEx7.Name = "PanelEx7"
        Me.PanelEx7.Size = New System.Drawing.Size(1145, 504)
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
        'PanelEx16
        '
        Me.PanelEx16.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx16.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx16.Controls.Add(Me.SGC)
        Me.PanelEx16.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx16.Location = New System.Drawing.Point(0, 75)
        Me.PanelEx16.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelEx16.Name = "PanelEx16"
        Me.PanelEx16.Size = New System.Drawing.Size(1145, 351)
        Me.PanelEx16.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx16.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx16.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx16.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx16.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx16.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx16.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx16.Style.GradientAngle = 90
        Me.PanelEx16.TabIndex = 50
        Me.PanelEx16.Text = "PanelEx16"
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
        Me.SGC.Size = New System.Drawing.Size(1145, 351)
        Me.SGC.TabIndex = 32
        Me.SGC.Text = "superGridControl1"
        '
        'PanelEx5
        '
        Me.PanelEx5.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx5.Controls.Add(Me.LabelX24)
        Me.PanelEx5.Controls.Add(Me.SW_Limit)
        Me.PanelEx5.Controls.Add(Me.Forfais_Value)
        Me.PanelEx5.Controls.Add(Me.LabelX22)
        Me.PanelEx5.Controls.Add(Me.Btn_Select_All)
        Me.PanelEx5.Controls.Add(Me.Input_Société)
        Me.PanelEx5.Controls.Add(Me.LabelX7)
        Me.PanelEx5.Controls.Add(Me.Invoice_Filter)
        Me.PanelEx5.Controls.Add(Me.Input_DateEnd)
        Me.PanelEx5.Controls.Add(Me.LabelX3)
        Me.PanelEx5.Controls.Add(Me.Input_DateStart)
        Me.PanelEx5.Controls.Add(Me.LabelX2)
        Me.PanelEx5.Controls.Add(Me.Input_Mandat)
        Me.PanelEx5.Controls.Add(Me.LabelX1)
        Me.PanelEx5.Controls.Add(Me.Btn_CalculateTotal)
        Me.PanelEx5.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx5.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx5.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelEx5.Name = "PanelEx5"
        Me.PanelEx5.Size = New System.Drawing.Size(1145, 75)
        Me.PanelEx5.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx5.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionInactiveBackground
        Me.PanelEx5.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx5.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx5.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx5.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx5.Style.GradientAngle = 90
        Me.PanelEx5.TabIndex = 49
        Me.PanelEx5.Text = " "
        '
        'LabelX24
        '
        '
        '
        '
        Me.LabelX24.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX24.Location = New System.Drawing.Point(880, 4)
        Me.LabelX24.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX24.Name = "LabelX24"
        Me.LabelX24.Size = New System.Drawing.Size(137, 29)
        Me.LabelX24.TabIndex = 58
        Me.LabelX24.Text = "Limité au Forfais"
        '
        'SW_Limit
        '
        '
        '
        '
        Me.SW_Limit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SW_Limit.Location = New System.Drawing.Point(900, 40)
        Me.SW_Limit.Name = "SW_Limit"
        Me.SW_Limit.Size = New System.Drawing.Size(66, 22)
        Me.SW_Limit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SW_Limit.TabIndex = 57
        '
        'Forfais_Value
        '
        '
        '
        '
        Me.Forfais_Value.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Forfais_Value.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Forfais_Value.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.Forfais_Value.Increment = 1.0R
        Me.Forfais_Value.Location = New System.Drawing.Point(756, 38)
        Me.Forfais_Value.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Forfais_Value.Name = "Forfais_Value"
        Me.Forfais_Value.ShowUpDown = True
        Me.Forfais_Value.Size = New System.Drawing.Size(126, 26)
        Me.Forfais_Value.TabIndex = 56
        '
        'LabelX22
        '
        '
        '
        '
        Me.LabelX22.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX22.Location = New System.Drawing.Point(756, 5)
        Me.LabelX22.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX22.Name = "LabelX22"
        Me.LabelX22.Size = New System.Drawing.Size(118, 29)
        Me.LabelX22.TabIndex = 55
        Me.LabelX22.Text = "Forfais"
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
        'Invoice_Filter
        '
        Me.Invoice_Filter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Invoice_Filter.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.Invoice_Filter.Location = New System.Drawing.Point(592, 9)
        Me.Invoice_Filter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Invoice_Filter.Name = "Invoice_Filter"
        Me.Invoice_Filter.Size = New System.Drawing.Size(158, 32)
        Me.Invoice_Filter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Invoice_Filter.TabIndex = 6
        Me.Invoice_Filter.Text = "Rechercher"
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
        'Btn_CalculateTotal
        '
        Me.Btn_CalculateTotal.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_CalculateTotal.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.Btn_CalculateTotal.Dock = System.Windows.Forms.DockStyle.Right
        Me.Btn_CalculateTotal.Location = New System.Drawing.Point(1023, 0)
        Me.Btn_CalculateTotal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btn_CalculateTotal.Name = "Btn_CalculateTotal"
        Me.Btn_CalculateTotal.Size = New System.Drawing.Size(122, 75)
        Me.Btn_CalculateTotal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_CalculateTotal.TabIndex = 25
        Me.Btn_CalculateTotal.Text = "Calculer Total"
        '
        'PanelEx6
        '
        Me.PanelEx6.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx6.Controls.Add(Me.TVA)
        Me.PanelEx6.Controls.Add(Me.LabelX4)
        Me.PanelEx6.Controls.Add(Me.Input_Total)
        Me.PanelEx6.Controls.Add(Me.Input_Total_TVA)
        Me.PanelEx6.Controls.Add(Me.LabelX6)
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
        Me.PanelEx6.Location = New System.Drawing.Point(0, 426)
        Me.PanelEx6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelEx6.Name = "PanelEx6"
        Me.PanelEx6.Size = New System.Drawing.Size(1145, 78)
        Me.PanelEx6.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx6.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx6.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx6.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx6.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx6.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx6.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx6.Style.GradientAngle = 90
        Me.PanelEx6.TabIndex = 45
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
        'Input_Total
        '
        '
        '
        '
        Me.Input_Total.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Input_Total.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Input_Total.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.Input_Total.Increment = 1.0R
        Me.Input_Total.Location = New System.Drawing.Point(986, 40)
        Me.Input_Total.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Input_Total.Name = "Input_Total"
        Me.Input_Total.ShowUpDown = True
        Me.Input_Total.Size = New System.Drawing.Size(126, 26)
        Me.Input_Total.TabIndex = 52
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
        Me.Input_Total_TVA.Location = New System.Drawing.Point(821, 41)
        Me.Input_Total_TVA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Input_Total_TVA.Name = "Input_Total_TVA"
        Me.Input_Total_TVA.ShowUpDown = True
        Me.Input_Total_TVA.Size = New System.Drawing.Size(126, 26)
        Me.Input_Total_TVA.TabIndex = 50
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(986, 7)
        Me.LabelX6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(118, 29)
        Me.LabelX6.TabIndex = 51
        Me.LabelX6.Text = "Total "
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(689, 40)
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
        Me.Input_Total_HTVA.Location = New System.Drawing.Point(821, 7)
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
        Me.LabelX30.Location = New System.Drawing.Point(689, 5)
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
        'DockContainerItem1
        '
        Me.DockContainerItem1.Control = Me.PanelDockContainer1
        Me.DockContainerItem1.Image = Global.Chronos.My.Resources.Resources.book1
        Me.DockContainerItem1.Name = "DockContainerItem1"
        Me.DockContainerItem1.PredefinedTabColor = DevComponents.DotNetBar.eTabItemColor.Teal
        Me.DockContainerItem1.Text = "Liste"
        '
        'DockContainerItem3
        '
        Me.DockContainerItem3.Control = Me.PanelDockContainer3
        Me.DockContainerItem3.Image = Global.Chronos.My.Resources.Resources.clip
        Me.DockContainerItem3.Name = "DockContainerItem3"
        Me.DockContainerItem3.PredefinedTabColor = DevComponents.DotNetBar.eTabItemColor.Red
        Me.DockContainerItem3.Text = "Facture"
        '
        'DockContainerItem2
        '
        Me.DockContainerItem2.Control = Me.PanelDockContainer2
        Me.DockContainerItem2.Image = Global.Chronos.My.Resources.Resources.pen
        Me.DockContainerItem2.Name = "DockContainerItem2"
        Me.DockContainerItem2.PredefinedTabColor = DevComponents.DotNetBar.eTabItemColor.Blue
        Me.DockContainerItem2.Text = "Modifier"
        '
        'DockSite1
        '
        Me.DockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite1.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite1.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite1.Location = New System.Drawing.Point(0, 105)
        Me.DockSite1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DockSite1.Name = "DockSite1"
        Me.DockSite1.Size = New System.Drawing.Size(0, 535)
        Me.DockSite1.TabIndex = 42
        Me.DockSite1.TabStop = False
        '
        'DockSite2
        '
        Me.DockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite2.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite2.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite2.Location = New System.Drawing.Point(1151, 105)
        Me.DockSite2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DockSite2.Name = "DockSite2"
        Me.DockSite2.Size = New System.Drawing.Size(0, 535)
        Me.DockSite2.TabIndex = 43
        Me.DockSite2.TabStop = False
        '
        'DockSite8
        '
        Me.DockSite8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DockSite8.Location = New System.Drawing.Point(0, 688)
        Me.DockSite8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DockSite8.Name = "DockSite8"
        Me.DockSite8.Size = New System.Drawing.Size(1151, 0)
        Me.DockSite8.TabIndex = 49
        Me.DockSite8.TabStop = False
        '
        'DockSite5
        '
        Me.DockSite5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite5.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite5.Location = New System.Drawing.Point(0, 105)
        Me.DockSite5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DockSite5.Name = "DockSite5"
        Me.DockSite5.Size = New System.Drawing.Size(0, 583)
        Me.DockSite5.TabIndex = 46
        Me.DockSite5.TabStop = False
        '
        'DockSite6
        '
        Me.DockSite6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite6.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite6.Location = New System.Drawing.Point(1151, 105)
        Me.DockSite6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DockSite6.Name = "DockSite6"
        Me.DockSite6.Size = New System.Drawing.Size(0, 583)
        Me.DockSite6.TabIndex = 47
        Me.DockSite6.TabStop = False
        '
        'DockSite7
        '
        Me.DockSite7.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite7.Controls.Add(Me.Bar1)
        Me.DockSite7.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite7.Location = New System.Drawing.Point(0, 48)
        Me.DockSite7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DockSite7.Name = "DockSite7"
        Me.DockSite7.Size = New System.Drawing.Size(1151, 57)
        Me.DockSite7.TabIndex = 48
        Me.DockSite7.TabStop = False
        '
        'Bar1
        '
        Me.Bar1.AccessibleDescription = "DotNetBar Bar (Bar1)"
        Me.Bar1.AccessibleName = "DotNetBar Bar"
        Me.Bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.Bar1.DockSide = DevComponents.DotNetBar.eDockSide.Top
        Me.Bar1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Bar1.Images = Me.IL_32
        Me.Bar1.IsMaximized = False
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonX1, Me.Btn_Add, Me.ButtonX2, Me.ButtonX3, Me.ButtonX4, Me.ButtonItem2})
        Me.Bar1.Location = New System.Drawing.Point(0, 0)
        Me.Bar1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Bar1.MenuBar = True
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Size = New System.Drawing.Size(1151, 56)
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar1.TabIndex = 0
        Me.Bar1.TabStop = False
        Me.Bar1.Text = "Bar1"
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
        Me.ButtonX3.ImageIndex = 75
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
        Me.DockSite3.Size = New System.Drawing.Size(1151, 0)
        Me.DockSite3.TabIndex = 44
        Me.DockSite3.TabStop = False
        '
        'PrestationViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DockSite9)
        Me.Controls.Add(Me.DockSite2)
        Me.Controls.Add(Me.DockSite1)
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
        Me.Name = "PrestationViewer"
        Me.Size = New System.Drawing.Size(1151, 688)
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx3.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx4.ResumeLayout(False)
        Me.DockSite9.ResumeLayout(False)
        CType(Me.Bar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bar2.ResumeLayout(False)
        Me.PanelDockContainer3.ResumeLayout(False)
        Me.PanelEx9.ResumeLayout(False)
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControl1.ResumeLayout(False)
        Me.SuperTabControlPanel1.ResumeLayout(False)
        Me.PanelEx10.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.Input_N, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControlPanel2.ResumeLayout(False)
        Me.PanelEx11.ResumeLayout(False)
        Me.PanelDockContainer2.ResumeLayout(False)
        Me.PanelEx8.ResumeLayout(False)
        Me.PanelEx12.ResumeLayout(False)
        Me.PanelEx14.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.PanelEx15.ResumeLayout(False)
        Me.ExpandablePanel1.ResumeLayout(False)
        Me.PanelEx13.ResumeLayout(False)
        CType(Me.Input_GrandTOTAL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Input_TotalHTVA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Input_Quantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Input_UnitPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Input_TimeIn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDockContainer1.ResumeLayout(False)
        Me.PanelEx7.ResumeLayout(False)
        Me.PanelEx16.ResumeLayout(False)
        Me.PanelEx5.ResumeLayout(False)
        CType(Me.Forfais_Value, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Input_DateEnd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Input_DateStart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx6.ResumeLayout(False)
        CType(Me.Input_Total, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Input_Total_TVA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Input_Total_HTVA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Input_Total_Frais, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Input_Total_Prestation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockSite7.ResumeLayout(False)
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelEx4 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Vcr1 As SmartCoder.SuperGridDemo.VcrControl
    Friend WithEvents IL_ As ImageList
    Friend WithEvents IL_Client As ImageList
    Friend WithEvents Timer1 As Timer
    Friend WithEvents IL_32 As ImageList
    Friend WithEvents BW As System.ComponentModel.BackgroundWorker
    Friend WithEvents DotNetBarManager1 As DevComponents.DotNetBar.DotNetBarManager
    Friend WithEvents DockSite4 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite1 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite2 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite3 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite5 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite6 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite7 As DevComponents.DotNetBar.DockSite
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents DockSite8 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite9 As DevComponents.DotNetBar.DockSite
    Friend WithEvents Bar2 As DevComponents.DotNetBar.Bar
    Friend WithEvents PanelDockContainer1 As DevComponents.DotNetBar.PanelDockContainer
    Friend WithEvents PanelEx7 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelDockContainer2 As DevComponents.DotNetBar.PanelDockContainer
    Friend WithEvents PanelEx8 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents DockContainerItem1 As DevComponents.DotNetBar.DockContainerItem
    Friend WithEvents DockContainerItem2 As DevComponents.DotNetBar.DockContainerItem
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Btn_Add As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonX4 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Btn_SendToExcel As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents PanelDockContainer3 As DevComponents.DotNetBar.PanelDockContainer
    Friend WithEvents PanelEx9 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents DockContainerItem3 As DevComponents.DotNetBar.DockContainerItem
    Friend WithEvents SuperTabControl1 As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents SuperTabControlPanel1 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents PanelEx10 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents SuperTabItem1 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents PanelEx11 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents SuperTabItem2 As DevComponents.DotNetBar.SuperTabItem
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
    Friend WithEvents Btn_Print_Empty As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Btn_Print_Simple As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Input_Code As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Btn_Verify As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Input_Adresse As DevComponents.DotNetBar.Controls.RichTextBoxEx
    Friend WithEvents Input_Collaborateur As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Input_TimeIn As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Input_UnitPrice As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Input_Facturable As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents Input_Quantity As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Input_TotalHTVA As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX17 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanelEx12 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ExpandablePanel1 As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents Input_GrandTOTAL As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX18 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanelEx14 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx13 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents CB_Prestation As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents CB_Type As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Btn_InsertLine As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX16 As DevComponents.DotNetBar.LabelX
    Friend WithEvents CB_Service As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX20 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PanelEx15 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Input_Description As DevComponents.DotNetBar.Controls.RichTextBoxEx
    Friend WithEvents PanelEx5 As DevComponents.DotNetBar.PanelEx
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
    Friend WithEvents PanelEx16 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ButtonX5 As DevComponents.DotNetBar.ButtonX
    Private WithEvents SGC2 As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Public WithEvents SGC As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents Btn_Validate As DevComponents.DotNetBar.ButtonX
    Friend WithEvents CB_Client As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX21 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX24 As DevComponents.DotNetBar.LabelX
    Friend WithEvents SW_Limit As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents Forfais_Value As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX22 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ButtonX6 As DevComponents.DotNetBar.ButtonX
End Class
