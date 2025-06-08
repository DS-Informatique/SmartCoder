<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ClientViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClientViewer))
        Dim Tarif1 As Chronos.M_TimeSheet.Tarif = New Chronos.M_TimeSheet.Tarif()
        Dim TimeSheet1 As Chronos.M_TimeSheet.TimeSheet = New Chronos.M_TimeSheet.TimeSheet()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.IL_Client = New System.Windows.Forms.ImageList(Me.components)
        Me.IL_ = New System.Windows.Forms.ImageList(Me.components)
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelEx5 = New DevComponents.DotNetBar.PanelEx()
        Me.Vcr1 = New SmartCoder.SuperGridDemo.VcrControl()
        Me.DotNetBarManager1 = New DevComponents.DotNetBar.DotNetBarManager(Me.components)
        Me.DockSite4 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite9 = New DevComponents.DotNetBar.DockSite()
        Me.Bar2 = New DevComponents.DotNetBar.Bar()
        Me.PanelDockContainer2 = New DevComponents.DotNetBar.PanelDockContainer()
        Me.PanelEx4 = New DevComponents.DotNetBar.PanelEx()
        Me.SuperTabControl1 = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.PanelEx6 = New DevComponents.DotNetBar.PanelEx()
        Me.SuperTabControl2 = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.PanelEx7 = New DevComponents.DotNetBar.PanelEx()
        Me.LabelX41 = New DevComponents.DotNetBar.LabelX()
        Me.Forfait = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Btn_Verify = New DevComponents.DotNetBar.ButtonX()
        Me.Active = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.NomClient = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.RaisonSociale = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.Ref = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.SuperTabItem2 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel7 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.Tarification1 = New Chronos.Tarification()
        Me.SuperTabItem7 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel4 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.PanelEx8 = New DevComponents.DotNetBar.PanelEx()
        Me.Website = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX16 = New DevComponents.DotNetBar.LabelX()
        Me.Email = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.Landline = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.Fax = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Cell = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
        Me.SuperTabItem4 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel5 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.PanelEx9 = New DevComponents.DotNetBar.PanelEx()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.Address1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.Address2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.PostalCode = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX19 = New DevComponents.DotNetBar.LabelX()
        Me.Region = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX20 = New DevComponents.DotNetBar.LabelX()
        Me.City = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Country = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX21 = New DevComponents.DotNetBar.LabelX()
        Me.SuperTabItem5 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel6 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.Other = New DevComponents.DotNetBar.Controls.RichTextBoxEx()
        Me.SuperTabItem6 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel3 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.PanelEx10 = New DevComponents.DotNetBar.PanelEx()
        Me.Zefix = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.CHE = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.IDE = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.RépertoireFactures = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX18 = New DevComponents.DotNetBar.LabelX()
        Me.Répertoire = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX()
        Me.Pcompta = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX17 = New DevComponents.DotNetBar.LabelX()
        Me.SuperTabItem3 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabItem1 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel9 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.AWeb1 = New Chronos.UWeb()
        Me.SuperTabItem9 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel8 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.PrestationViewer1 = New Chronos.PrestationViewer()
        Me.SuperTabItem8 = New DevComponents.DotNetBar.SuperTabItem()
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
        Me.PanelEx5.SuspendLayout()
        Me.DockSite9.SuspendLayout()
        CType(Me.Bar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bar2.SuspendLayout()
        Me.PanelDockContainer2.SuspendLayout()
        Me.PanelEx4.SuspendLayout()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControl1.SuspendLayout()
        Me.SuperTabControlPanel1.SuspendLayout()
        Me.PanelEx6.SuspendLayout()
        CType(Me.SuperTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControl2.SuspendLayout()
        Me.SuperTabControlPanel2.SuspendLayout()
        Me.PanelEx7.SuspendLayout()
        Me.SuperTabControlPanel7.SuspendLayout()
        Me.SuperTabControlPanel4.SuspendLayout()
        Me.PanelEx8.SuspendLayout()
        Me.SuperTabControlPanel5.SuspendLayout()
        Me.PanelEx9.SuspendLayout()
        Me.SuperTabControlPanel6.SuspendLayout()
        Me.SuperTabControlPanel3.SuspendLayout()
        Me.PanelEx10.SuspendLayout()
        Me.SuperTabControlPanel9.SuspendLayout()
        Me.SuperTabControlPanel8.SuspendLayout()
        Me.PanelDockContainer1.SuspendLayout()
        Me.DockSite7.SuspendLayout()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
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
        Me.PanelEx1.Size = New System.Drawing.Size(1142, 48)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 12
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
        Me.PanelEx3.Size = New System.Drawing.Size(1079, 48)
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
        Me.ReflectionLabel1.Size = New System.Drawing.Size(1079, 48)
        Me.ReflectionLabel1.TabIndex = 0
        Me.ReflectionLabel1.Text = "<font color=""#602826""><b>Clients</b></font>"
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
        Me.PictureBox1.Image = Global.Chronos.My.Resources.Resources.user
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
        Me.PanelEx5.Location = New System.Drawing.Point(0, 647)
        Me.PanelEx5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelEx5.Name = "PanelEx5"
        Me.PanelEx5.Size = New System.Drawing.Size(1142, 48)
        Me.PanelEx5.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx5.Style.BackColor1.Color = System.Drawing.Color.White
        Me.PanelEx5.Style.BackColor2.Color = System.Drawing.Color.White
        Me.PanelEx5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx5.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx5.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx5.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx5.Style.GradientAngle = 90
        Me.PanelEx5.TabIndex = 20
        Me.PanelEx5.Text = " "
        '
        'Vcr1
        '
        Me.Vcr1.BackColor = System.Drawing.Color.Transparent
        Me.Vcr1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Vcr1.Location = New System.Drawing.Point(0, 0)
        Me.Vcr1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Vcr1.Name = "Vcr1"
        Me.Vcr1.Size = New System.Drawing.Size(1142, 48)
        Me.Vcr1.TabIndex = 15
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
        Me.DockSite4.Location = New System.Drawing.Point(0, 695)
        Me.DockSite4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DockSite4.Name = "DockSite4"
        Me.DockSite4.Size = New System.Drawing.Size(1142, 0)
        Me.DockSite4.TabIndex = 24
        Me.DockSite4.TabStop = False
        '
        'DockSite9
        '
        Me.DockSite9.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite9.Controls.Add(Me.Bar2)
        Me.DockSite9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DockSite9.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer(New DevComponents.DotNetBar.DocumentBaseContainer() {CType(New DevComponents.DotNetBar.DocumentBarContainer(Me.Bar2, 1142, 542), DevComponents.DotNetBar.DocumentBaseContainer)}, DevComponents.DotNetBar.eOrientation.Horizontal)
        Me.DockSite9.Location = New System.Drawing.Point(0, 105)
        Me.DockSite9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DockSite9.Name = "DockSite9"
        Me.DockSite9.Size = New System.Drawing.Size(1142, 542)
        Me.DockSite9.TabIndex = 29
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
        Me.Bar2.Controls.Add(Me.PanelDockContainer2)
        Me.Bar2.Controls.Add(Me.PanelDockContainer1)
        Me.Bar2.DockTabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top
        Me.Bar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bar2.IsMaximized = False
        Me.Bar2.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.DockContainerItem1, Me.DockContainerItem2})
        Me.Bar2.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer
        Me.Bar2.Location = New System.Drawing.Point(0, 0)
        Me.Bar2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Bar2.Name = "Bar2"
        Me.Bar2.SelectedDockTab = 1
        Me.Bar2.Size = New System.Drawing.Size(1142, 542)
        Me.Bar2.Stretch = True
        Me.Bar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar2.TabIndex = 0
        Me.Bar2.TabNavigation = True
        Me.Bar2.TabStop = False
        '
        'PanelDockContainer2
        '
        Me.PanelDockContainer2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelDockContainer2.Controls.Add(Me.PanelEx4)
        Me.PanelDockContainer2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelDockContainer2.Location = New System.Drawing.Point(3, 28)
        Me.PanelDockContainer2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelDockContainer2.Name = "PanelDockContainer2"
        Me.PanelDockContainer2.Size = New System.Drawing.Size(1136, 511)
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
        Me.PanelEx4.Controls.Add(Me.SuperTabControl1)
        Me.PanelEx4.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx4.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelEx4.Name = "PanelEx4"
        Me.PanelEx4.Size = New System.Drawing.Size(1136, 511)
        Me.PanelEx4.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx4.Style.GradientAngle = 90
        Me.PanelEx4.TabIndex = 4
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
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel9)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel8)
        Me.SuperTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControl1.ImageList = Me.IL_
        Me.SuperTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SuperTabControl1.Name = "SuperTabControl1"
        Me.SuperTabControl1.ReorderTabsEnabled = True
        Me.SuperTabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.SuperTabControl1.SelectedTabIndex = 0
        Me.SuperTabControl1.Size = New System.Drawing.Size(1136, 511)
        Me.SuperTabControl1.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabControl1.TabIndex = 0
        Me.SuperTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabItem1, Me.SuperTabItem8, Me.SuperTabItem9})
        Me.SuperTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.OneNote2007
        Me.SuperTabControl1.Text = "SuperTabControl1"
        '
        'SuperTabControlPanel1
        '
        Me.SuperTabControlPanel1.Controls.Add(Me.PanelEx6)
        Me.SuperTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel1.Location = New System.Drawing.Point(0, 38)
        Me.SuperTabControlPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SuperTabControlPanel1.Name = "SuperTabControlPanel1"
        Me.SuperTabControlPanel1.Size = New System.Drawing.Size(1136, 473)
        Me.SuperTabControlPanel1.TabIndex = 1
        Me.SuperTabControlPanel1.TabItem = Me.SuperTabItem1
        '
        'PanelEx6
        '
        Me.PanelEx6.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx6.Controls.Add(Me.SuperTabControl2)
        Me.PanelEx6.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx6.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelEx6.Name = "PanelEx6"
        Me.PanelEx6.Size = New System.Drawing.Size(1136, 473)
        Me.PanelEx6.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx6.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx6.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx6.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx6.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx6.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PanelEx6.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx6.Style.GradientAngle = 90
        Me.PanelEx6.TabIndex = 4
        Me.PanelEx6.Text = " "
        '
        'SuperTabControl2
        '
        '
        '
        '
        '
        '
        '
        Me.SuperTabControl2.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.SuperTabControl2.ControlBox.MenuBox.Name = ""
        Me.SuperTabControl2.ControlBox.Name = ""
        Me.SuperTabControl2.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabControl2.ControlBox.MenuBox, Me.SuperTabControl2.ControlBox.CloseBox})
        Me.SuperTabControl2.Controls.Add(Me.SuperTabControlPanel2)
        Me.SuperTabControl2.Controls.Add(Me.SuperTabControlPanel7)
        Me.SuperTabControl2.Controls.Add(Me.SuperTabControlPanel4)
        Me.SuperTabControl2.Controls.Add(Me.SuperTabControlPanel5)
        Me.SuperTabControl2.Controls.Add(Me.SuperTabControlPanel6)
        Me.SuperTabControl2.Controls.Add(Me.SuperTabControlPanel3)
        Me.SuperTabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControl2.ImageList = Me.IL_
        Me.SuperTabControl2.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SuperTabControl2.Name = "SuperTabControl2"
        Me.SuperTabControl2.ReorderTabsEnabled = True
        Me.SuperTabControl2.SelectedTabFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.SuperTabControl2.SelectedTabIndex = 0
        Me.SuperTabControl2.Size = New System.Drawing.Size(1136, 473)
        Me.SuperTabControl2.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Left
        Me.SuperTabControl2.TabFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabControl2.TabIndex = 1
        Me.SuperTabControl2.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabItem2, Me.SuperTabItem3, Me.SuperTabItem4, Me.SuperTabItem5, Me.SuperTabItem7, Me.SuperTabItem6})
        Me.SuperTabControl2.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue
        Me.SuperTabControl2.Text = "SuperTabControl2"
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.Controls.Add(Me.PanelEx7)
        Me.SuperTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel2.Location = New System.Drawing.Point(118, 0)
        Me.SuperTabControlPanel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SuperTabControlPanel2.Name = "SuperTabControlPanel2"
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(1018, 473)
        Me.SuperTabControlPanel2.TabIndex = 1
        Me.SuperTabControlPanel2.TabItem = Me.SuperTabItem2
        '
        'PanelEx7
        '
        Me.PanelEx7.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx7.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx7.Controls.Add(Me.LabelX41)
        Me.PanelEx7.Controls.Add(Me.Forfait)
        Me.PanelEx7.Controls.Add(Me.Btn_Verify)
        Me.PanelEx7.Controls.Add(Me.Active)
        Me.PanelEx7.Controls.Add(Me.LabelX2)
        Me.PanelEx7.Controls.Add(Me.NomClient)
        Me.PanelEx7.Controls.Add(Me.LabelX4)
        Me.PanelEx7.Controls.Add(Me.LabelX3)
        Me.PanelEx7.Controls.Add(Me.RaisonSociale)
        Me.PanelEx7.Controls.Add(Me.LabelX1)
        Me.PanelEx7.Controls.Add(Me.Ref)
        Me.PanelEx7.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx7.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelEx7.Name = "PanelEx7"
        Me.PanelEx7.Size = New System.Drawing.Size(1018, 473)
        Me.PanelEx7.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx7.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx7.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx7.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx7.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx7.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx7.Style.GradientAngle = 90
        Me.PanelEx7.TabIndex = 0
        Me.PanelEx7.Text = " "
        '
        'LabelX41
        '
        '
        '
        '
        Me.LabelX41.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX41.Location = New System.Drawing.Point(450, 96)
        Me.LabelX41.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX41.Name = "LabelX41"
        Me.LabelX41.Size = New System.Drawing.Size(130, 32)
        Me.LabelX41.TabIndex = 34
        Me.LabelX41.Text = "Forfait :"
        '
        'Forfait
        '
        '
        '
        '
        Me.Forfait.Border.Class = "TextBoxBorder"
        Me.Forfait.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Forfait.Location = New System.Drawing.Point(450, 136)
        Me.Forfait.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Forfait.Name = "Forfait"
        Me.Forfait.PreventEnterBeep = True
        Me.Forfait.Size = New System.Drawing.Size(130, 26)
        Me.Forfait.TabIndex = 35
        '
        'Btn_Verify
        '
        Me.Btn_Verify.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_Verify.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Btn_Verify.Location = New System.Drawing.Point(153, 59)
        Me.Btn_Verify.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btn_Verify.Name = "Btn_Verify"
        Me.Btn_Verify.Size = New System.Drawing.Size(84, 29)
        Me.Btn_Verify.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_Verify.TabIndex = 33
        Me.Btn_Verify.Text = "Vérifier"
        '
        'Active
        '
        '
        '
        '
        Me.Active.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Active.Location = New System.Drawing.Point(369, 60)
        Me.Active.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Active.Name = "Active"
        Me.Active.Size = New System.Drawing.Size(74, 28)
        Me.Active.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Active.TabIndex = 11
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(369, 20)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(52, 32)
        Me.LabelX2.TabIndex = 10
        Me.LabelX2.Text = "Actif"
        '
        'NomClient
        '
        '
        '
        '
        Me.NomClient.Border.Class = "TextBoxBorder"
        Me.NomClient.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.NomClient.Location = New System.Drawing.Point(16, 229)
        Me.NomClient.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NomClient.Name = "NomClient"
        Me.NomClient.PreventEnterBeep = True
        Me.NomClient.Size = New System.Drawing.Size(428, 26)
        Me.NomClient.TabIndex = 9
        Me.NomClient.WatermarkText = "Example: Mr Prénom NOM"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(16, 189)
        Me.LabelX4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(428, 32)
        Me.LabelX4.TabIndex = 8
        Me.LabelX4.Text = "Nom du Client"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(16, 96)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(428, 32)
        Me.LabelX3.TabIndex = 6
        Me.LabelX3.Text = "Raison Sociale"
        '
        'RaisonSociale
        '
        '
        '
        '
        Me.RaisonSociale.Border.Class = "TextBoxBorder"
        Me.RaisonSociale.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RaisonSociale.Location = New System.Drawing.Point(16, 136)
        Me.RaisonSociale.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RaisonSociale.Name = "RaisonSociale"
        Me.RaisonSociale.PreventEnterBeep = True
        Me.RaisonSociale.Size = New System.Drawing.Size(428, 26)
        Me.RaisonSociale.TabIndex = 7
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(16, 20)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(130, 32)
        Me.LabelX1.TabIndex = 2
        Me.LabelX1.Text = "Numéro de Client"
        '
        'Ref
        '
        '
        '
        '
        Me.Ref.Border.Class = "TextBoxBorder"
        Me.Ref.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Ref.Location = New System.Drawing.Point(16, 60)
        Me.Ref.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Ref.Name = "Ref"
        Me.Ref.PreventEnterBeep = True
        Me.Ref.Size = New System.Drawing.Size(130, 26)
        Me.Ref.TabIndex = 3
        '
        'SuperTabItem2
        '
        Me.SuperTabItem2.AttachedControl = Me.SuperTabControlPanel2
        Me.SuperTabItem2.GlobalItem = False
        Me.SuperTabItem2.ImageIndex = 36
        Me.SuperTabItem2.Name = "SuperTabItem2"
        Me.SuperTabItem2.Text = "Index"
        '
        'SuperTabControlPanel7
        '
        Me.SuperTabControlPanel7.Controls.Add(Me.Tarification1)
        Me.SuperTabControlPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel7.Location = New System.Drawing.Point(118, 0)
        Me.SuperTabControlPanel7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SuperTabControlPanel7.Name = "SuperTabControlPanel7"
        Me.SuperTabControlPanel7.Size = New System.Drawing.Size(1018, 473)
        Me.SuperTabControlPanel7.TabIndex = 0
        Me.SuperTabControlPanel7.TabItem = Me.SuperTabItem7
        '
        'Tarification1
        '
        Tarif1.Code = Nothing
        Tarif1.Collaborateur = Nothing
        Tarif1.DateIN = New Date(2019, 6, 26, 0, 0, 0, 0)
        Tarif1.ID = 0
        Tarif1.Price = 0R
        Me.Tarification1.Current = Tarif1
        Me.Tarification1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tarification1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tarification1.Location = New System.Drawing.Point(0, 0)
        Me.Tarification1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Tarification1.Name = "Tarification1"
        Me.Tarification1.Size = New System.Drawing.Size(1018, 473)
        Me.Tarification1.TabIndex = 0
        '
        'SuperTabItem7
        '
        Me.SuperTabItem7.AttachedControl = Me.SuperTabControlPanel7
        Me.SuperTabItem7.GlobalItem = False
        Me.SuperTabItem7.ImageIndex = 24
        Me.SuperTabItem7.Name = "SuperTabItem7"
        Me.SuperTabItem7.Text = "Tarif"
        '
        'SuperTabControlPanel4
        '
        Me.SuperTabControlPanel4.Controls.Add(Me.PanelEx8)
        Me.SuperTabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel4.Location = New System.Drawing.Point(133, 0)
        Me.SuperTabControlPanel4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SuperTabControlPanel4.Name = "SuperTabControlPanel4"
        Me.SuperTabControlPanel4.Size = New System.Drawing.Size(590, 491)
        Me.SuperTabControlPanel4.TabIndex = 0
        Me.SuperTabControlPanel4.TabItem = Me.SuperTabItem4
        '
        'PanelEx8
        '
        Me.PanelEx8.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx8.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx8.Controls.Add(Me.Website)
        Me.PanelEx8.Controls.Add(Me.LabelX16)
        Me.PanelEx8.Controls.Add(Me.Email)
        Me.PanelEx8.Controls.Add(Me.LabelX11)
        Me.PanelEx8.Controls.Add(Me.Landline)
        Me.PanelEx8.Controls.Add(Me.LabelX14)
        Me.PanelEx8.Controls.Add(Me.LabelX12)
        Me.PanelEx8.Controls.Add(Me.Fax)
        Me.PanelEx8.Controls.Add(Me.Cell)
        Me.PanelEx8.Controls.Add(Me.LabelX13)
        Me.PanelEx8.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx8.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelEx8.Name = "PanelEx8"
        Me.PanelEx8.Size = New System.Drawing.Size(590, 491)
        Me.PanelEx8.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx8.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx8.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx8.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx8.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx8.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx8.Style.GradientAngle = 90
        Me.PanelEx8.TabIndex = 0
        Me.PanelEx8.Text = " "
        '
        'Website
        '
        '
        '
        '
        Me.Website.Border.Class = "TextBoxBorder"
        Me.Website.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Website.Location = New System.Drawing.Point(26, 235)
        Me.Website.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Website.Name = "Website"
        Me.Website.PreventEnterBeep = True
        Me.Website.Size = New System.Drawing.Size(452, 26)
        Me.Website.TabIndex = 39
        Me.Website.WatermarkText = "Exemple : http://www.google.com"
        '
        'LabelX16
        '
        '
        '
        '
        Me.LabelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX16.Location = New System.Drawing.Point(26, 195)
        Me.LabelX16.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX16.Name = "LabelX16"
        Me.LabelX16.Size = New System.Drawing.Size(452, 32)
        Me.LabelX16.TabIndex = 38
        Me.LabelX16.Text = "Site Web"
        '
        'Email
        '
        '
        '
        '
        Me.Email.Border.Class = "TextBoxBorder"
        Me.Email.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Email.Location = New System.Drawing.Point(255, 65)
        Me.Email.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Email.Name = "Email"
        Me.Email.PreventEnterBeep = True
        Me.Email.Size = New System.Drawing.Size(223, 26)
        Me.Email.TabIndex = 37
        Me.Email.WatermarkText = "Exemple : exemple@world.com"
        '
        'LabelX11
        '
        '
        '
        '
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.Location = New System.Drawing.Point(26, 25)
        Me.LabelX11.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(223, 32)
        Me.LabelX11.TabIndex = 30
        Me.LabelX11.Text = "Téléphone Fixe"
        '
        'Landline
        '
        '
        '
        '
        Me.Landline.Border.Class = "TextBoxBorder"
        Me.Landline.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Landline.Location = New System.Drawing.Point(26, 65)
        Me.Landline.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Landline.Name = "Landline"
        Me.Landline.PreventEnterBeep = True
        Me.Landline.Size = New System.Drawing.Size(223, 26)
        Me.Landline.TabIndex = 31
        Me.Landline.WatermarkText = "Exemple : +41(0) 22 000.00.00"
        '
        'LabelX14
        '
        '
        '
        '
        Me.LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX14.Location = New System.Drawing.Point(255, 25)
        Me.LabelX14.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(223, 32)
        Me.LabelX14.TabIndex = 36
        Me.LabelX14.Text = "Email"
        '
        'LabelX12
        '
        '
        '
        '
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.Location = New System.Drawing.Point(26, 101)
        Me.LabelX12.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(223, 32)
        Me.LabelX12.TabIndex = 32
        Me.LabelX12.Text = "Téléphone Portable"
        '
        'Fax
        '
        '
        '
        '
        Me.Fax.Border.Class = "TextBoxBorder"
        Me.Fax.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Fax.Location = New System.Drawing.Point(255, 141)
        Me.Fax.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Fax.Name = "Fax"
        Me.Fax.PreventEnterBeep = True
        Me.Fax.Size = New System.Drawing.Size(223, 26)
        Me.Fax.TabIndex = 35
        Me.Fax.WatermarkText = "Exemple : +41(0) 22 000.00.00"
        '
        'Cell
        '
        '
        '
        '
        Me.Cell.Border.Class = "TextBoxBorder"
        Me.Cell.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Cell.Location = New System.Drawing.Point(26, 141)
        Me.Cell.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Cell.Name = "Cell"
        Me.Cell.PreventEnterBeep = True
        Me.Cell.Size = New System.Drawing.Size(223, 26)
        Me.Cell.TabIndex = 33
        Me.Cell.WatermarkText = "Exemple : +41(0) 79 000.00.00"
        '
        'LabelX13
        '
        '
        '
        '
        Me.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX13.Location = New System.Drawing.Point(255, 101)
        Me.LabelX13.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(223, 32)
        Me.LabelX13.TabIndex = 34
        Me.LabelX13.Text = "Fax"
        '
        'SuperTabItem4
        '
        Me.SuperTabItem4.AttachedControl = Me.SuperTabControlPanel4
        Me.SuperTabItem4.GlobalItem = False
        Me.SuperTabItem4.ImageIndex = 13
        Me.SuperTabItem4.Name = "SuperTabItem4"
        Me.SuperTabItem4.Text = "Contact"
        '
        'SuperTabControlPanel5
        '
        Me.SuperTabControlPanel5.Controls.Add(Me.PanelEx9)
        Me.SuperTabControlPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel5.Location = New System.Drawing.Point(133, 0)
        Me.SuperTabControlPanel5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SuperTabControlPanel5.Name = "SuperTabControlPanel5"
        Me.SuperTabControlPanel5.Size = New System.Drawing.Size(590, 491)
        Me.SuperTabControlPanel5.TabIndex = 0
        Me.SuperTabControlPanel5.TabItem = Me.SuperTabItem5
        '
        'PanelEx9
        '
        Me.PanelEx9.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx9.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx9.Controls.Add(Me.LabelX8)
        Me.PanelEx9.Controls.Add(Me.Address1)
        Me.PanelEx9.Controls.Add(Me.LabelX9)
        Me.PanelEx9.Controls.Add(Me.Address2)
        Me.PanelEx9.Controls.Add(Me.LabelX10)
        Me.PanelEx9.Controls.Add(Me.PostalCode)
        Me.PanelEx9.Controls.Add(Me.LabelX19)
        Me.PanelEx9.Controls.Add(Me.Region)
        Me.PanelEx9.Controls.Add(Me.LabelX20)
        Me.PanelEx9.Controls.Add(Me.City)
        Me.PanelEx9.Controls.Add(Me.Country)
        Me.PanelEx9.Controls.Add(Me.LabelX21)
        Me.PanelEx9.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx9.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelEx9.Name = "PanelEx9"
        Me.PanelEx9.Size = New System.Drawing.Size(590, 491)
        Me.PanelEx9.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx9.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx9.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx9.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx9.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx9.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx9.Style.GradientAngle = 90
        Me.PanelEx9.TabIndex = 0
        Me.PanelEx9.Text = " "
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Location = New System.Drawing.Point(15, 16)
        Me.LabelX8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(428, 32)
        Me.LabelX8.TabIndex = 20
        Me.LabelX8.Text = "Adresse Ligne 1"
        '
        'Address1
        '
        '
        '
        '
        Me.Address1.Border.Class = "TextBoxBorder"
        Me.Address1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Address1.Location = New System.Drawing.Point(15, 56)
        Me.Address1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Address1.Name = "Address1"
        Me.Address1.PreventEnterBeep = True
        Me.Address1.Size = New System.Drawing.Size(428, 26)
        Me.Address1.TabIndex = 21
        Me.Address1.WatermarkText = "C/O ou Première ligne"
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Location = New System.Drawing.Point(15, 89)
        Me.LabelX9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(428, 32)
        Me.LabelX9.TabIndex = 22
        Me.LabelX9.Text = "Adresse Ligne 2"
        '
        'Address2
        '
        '
        '
        '
        Me.Address2.Border.Class = "TextBoxBorder"
        Me.Address2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Address2.Location = New System.Drawing.Point(15, 129)
        Me.Address2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Address2.Name = "Address2"
        Me.Address2.PreventEnterBeep = True
        Me.Address2.Size = New System.Drawing.Size(428, 26)
        Me.Address2.TabIndex = 23
        Me.Address2.WatermarkText = "Numéro, Nom de la rue"
        '
        'LabelX10
        '
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Location = New System.Drawing.Point(15, 170)
        Me.LabelX10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(168, 32)
        Me.LabelX10.TabIndex = 24
        Me.LabelX10.Text = "Code Postale"
        '
        'PostalCode
        '
        '
        '
        '
        Me.PostalCode.Border.Class = "TextBoxBorder"
        Me.PostalCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.PostalCode.Location = New System.Drawing.Point(15, 210)
        Me.PostalCode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PostalCode.Name = "PostalCode"
        Me.PostalCode.PreventEnterBeep = True
        Me.PostalCode.Size = New System.Drawing.Size(168, 26)
        Me.PostalCode.TabIndex = 25
        Me.PostalCode.WatermarkText = "Numéro seulement"
        '
        'LabelX19
        '
        '
        '
        '
        Me.LabelX19.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX19.Location = New System.Drawing.Point(197, 170)
        Me.LabelX19.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX19.Name = "LabelX19"
        Me.LabelX19.Size = New System.Drawing.Size(245, 32)
        Me.LabelX19.TabIndex = 26
        Me.LabelX19.Text = "Région"
        '
        'Region
        '
        '
        '
        '
        Me.Region.Border.Class = "TextBoxBorder"
        Me.Region.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Region.Location = New System.Drawing.Point(197, 210)
        Me.Region.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Region.Name = "Region"
        Me.Region.PreventEnterBeep = True
        Me.Region.Size = New System.Drawing.Size(245, 26)
        Me.Region.TabIndex = 27
        Me.Region.WatermarkText = "Exemple : Genève"
        '
        'LabelX20
        '
        '
        '
        '
        Me.LabelX20.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX20.Location = New System.Drawing.Point(15, 249)
        Me.LabelX20.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX20.Name = "LabelX20"
        Me.LabelX20.Size = New System.Drawing.Size(205, 32)
        Me.LabelX20.TabIndex = 28
        Me.LabelX20.Text = "Ville"
        '
        'City
        '
        '
        '
        '
        Me.City.Border.Class = "TextBoxBorder"
        Me.City.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.City.Location = New System.Drawing.Point(15, 289)
        Me.City.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.City.Name = "City"
        Me.City.PreventEnterBeep = True
        Me.City.Size = New System.Drawing.Size(205, 26)
        Me.City.TabIndex = 29
        Me.City.WatermarkText = "Exemple : Genève"
        '
        'Country
        '
        '
        '
        '
        Me.Country.Border.Class = "TextBoxBorder"
        Me.Country.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Country.Location = New System.Drawing.Point(226, 289)
        Me.Country.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Country.Name = "Country"
        Me.Country.PreventEnterBeep = True
        Me.Country.Size = New System.Drawing.Size(216, 26)
        Me.Country.TabIndex = 31
        Me.Country.WatermarkText = "Exemple : Suisse"
        '
        'LabelX21
        '
        '
        '
        '
        Me.LabelX21.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX21.Location = New System.Drawing.Point(226, 249)
        Me.LabelX21.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX21.Name = "LabelX21"
        Me.LabelX21.Size = New System.Drawing.Size(216, 32)
        Me.LabelX21.TabIndex = 30
        Me.LabelX21.Text = "Pays"
        '
        'SuperTabItem5
        '
        Me.SuperTabItem5.AttachedControl = Me.SuperTabControlPanel5
        Me.SuperTabItem5.GlobalItem = False
        Me.SuperTabItem5.ImageIndex = 34
        Me.SuperTabItem5.Name = "SuperTabItem5"
        Me.SuperTabItem5.Text = "Adresse"
        '
        'SuperTabControlPanel6
        '
        Me.SuperTabControlPanel6.Controls.Add(Me.Other)
        Me.SuperTabControlPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel6.Location = New System.Drawing.Point(133, 0)
        Me.SuperTabControlPanel6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SuperTabControlPanel6.Name = "SuperTabControlPanel6"
        Me.SuperTabControlPanel6.Size = New System.Drawing.Size(590, 491)
        Me.SuperTabControlPanel6.TabIndex = 0
        Me.SuperTabControlPanel6.TabItem = Me.SuperTabItem6
        '
        'Other
        '
        '
        '
        '
        Me.Other.BackgroundStyle.Class = "RichTextBoxBorder"
        Me.Other.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Other.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Other.Location = New System.Drawing.Point(0, 0)
        Me.Other.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Other.Name = "Other"
        Me.Other.Rtf = "{\rtf1\ansi\deff0{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\viewkind4" &
    "\uc1\pard\lang4108\f0\fs24  \par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Other.Size = New System.Drawing.Size(590, 491)
        Me.Other.TabIndex = 1
        Me.Other.Text = " "
        '
        'SuperTabItem6
        '
        Me.SuperTabItem6.AttachedControl = Me.SuperTabControlPanel6
        Me.SuperTabItem6.GlobalItem = False
        Me.SuperTabItem6.ImageIndex = 14
        Me.SuperTabItem6.Name = "SuperTabItem6"
        Me.SuperTabItem6.Text = "Note"
        '
        'SuperTabControlPanel3
        '
        Me.SuperTabControlPanel3.Controls.Add(Me.PanelEx10)
        Me.SuperTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel3.Location = New System.Drawing.Point(133, 0)
        Me.SuperTabControlPanel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SuperTabControlPanel3.Name = "SuperTabControlPanel3"
        Me.SuperTabControlPanel3.Size = New System.Drawing.Size(590, 505)
        Me.SuperTabControlPanel3.TabIndex = 0
        Me.SuperTabControlPanel3.TabItem = Me.SuperTabItem3
        '
        'PanelEx10
        '
        Me.PanelEx10.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx10.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx10.Controls.Add(Me.Zefix)
        Me.PanelEx10.Controls.Add(Me.LabelX7)
        Me.PanelEx10.Controls.Add(Me.CHE)
        Me.PanelEx10.Controls.Add(Me.LabelX6)
        Me.PanelEx10.Controls.Add(Me.IDE)
        Me.PanelEx10.Controls.Add(Me.LabelX5)
        Me.PanelEx10.Controls.Add(Me.RépertoireFactures)
        Me.PanelEx10.Controls.Add(Me.LabelX18)
        Me.PanelEx10.Controls.Add(Me.Répertoire)
        Me.PanelEx10.Controls.Add(Me.LabelX15)
        Me.PanelEx10.Controls.Add(Me.Pcompta)
        Me.PanelEx10.Controls.Add(Me.LabelX17)
        Me.PanelEx10.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx10.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelEx10.Name = "PanelEx10"
        Me.PanelEx10.Size = New System.Drawing.Size(590, 505)
        Me.PanelEx10.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx10.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx10.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx10.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx10.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx10.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx10.Style.GradientAngle = 90
        Me.PanelEx10.TabIndex = 0
        Me.PanelEx10.Text = " "
        '
        'Zefix
        '
        '
        '
        '
        Me.Zefix.Border.Class = "TextBoxBorder"
        Me.Zefix.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Zefix.Location = New System.Drawing.Point(19, 312)
        Me.Zefix.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Zefix.Name = "Zefix"
        Me.Zefix.PreventEnterBeep = True
        Me.Zefix.Size = New System.Drawing.Size(495, 26)
        Me.Zefix.TabIndex = 43
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(19, 274)
        Me.LabelX7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(495, 32)
        Me.LabelX7.TabIndex = 42
        Me.LabelX7.Text = "Zefix"
        '
        'CHE
        '
        '
        '
        '
        Me.CHE.Border.Class = "TextBoxBorder"
        Me.CHE.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CHE.Location = New System.Drawing.Point(353, 70)
        Me.CHE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CHE.Name = "CHE"
        Me.CHE.PreventEnterBeep = True
        Me.CHE.Size = New System.Drawing.Size(141, 26)
        Me.CHE.TabIndex = 41
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(353, 30)
        Me.LabelX6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(141, 32)
        Me.LabelX6.TabIndex = 40
        Me.LabelX6.Text = "N° Fédéral"
        '
        'IDE
        '
        '
        '
        '
        Me.IDE.Border.Class = "TextBoxBorder"
        Me.IDE.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.IDE.Location = New System.Drawing.Point(194, 70)
        Me.IDE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.IDE.Name = "IDE"
        Me.IDE.PreventEnterBeep = True
        Me.IDE.Size = New System.Drawing.Size(141, 26)
        Me.IDE.TabIndex = 39
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(194, 30)
        Me.LabelX5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(141, 32)
        Me.LabelX5.TabIndex = 38
        Me.LabelX5.Text = "IDE"
        '
        'RépertoireFactures
        '
        '
        '
        '
        Me.RépertoireFactures.Border.Class = "TextBoxBorder"
        Me.RépertoireFactures.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RépertoireFactures.Location = New System.Drawing.Point(19, 238)
        Me.RépertoireFactures.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RépertoireFactures.Name = "RépertoireFactures"
        Me.RépertoireFactures.PreventEnterBeep = True
        Me.RépertoireFactures.Size = New System.Drawing.Size(495, 26)
        Me.RépertoireFactures.TabIndex = 37
        '
        'LabelX18
        '
        '
        '
        '
        Me.LabelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX18.Location = New System.Drawing.Point(19, 199)
        Me.LabelX18.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX18.Name = "LabelX18"
        Me.LabelX18.Size = New System.Drawing.Size(495, 32)
        Me.LabelX18.TabIndex = 36
        Me.LabelX18.Text = "Répertoire de facture reçu"
        '
        'Répertoire
        '
        '
        '
        '
        Me.Répertoire.Border.Class = "TextBoxBorder"
        Me.Répertoire.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Répertoire.Location = New System.Drawing.Point(19, 161)
        Me.Répertoire.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Répertoire.Name = "Répertoire"
        Me.Répertoire.PreventEnterBeep = True
        Me.Répertoire.Size = New System.Drawing.Size(495, 26)
        Me.Répertoire.TabIndex = 35
        '
        'LabelX15
        '
        '
        '
        '
        Me.LabelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX15.Location = New System.Drawing.Point(19, 122)
        Me.LabelX15.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.Size = New System.Drawing.Size(495, 32)
        Me.LabelX15.TabIndex = 34
        Me.LabelX15.Text = "Répertoire du Client"
        '
        'Pcompta
        '
        '
        '
        '
        Me.Pcompta.Border.Class = "TextBoxBorder"
        Me.Pcompta.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Pcompta.Location = New System.Drawing.Point(19, 70)
        Me.Pcompta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Pcompta.Name = "Pcompta"
        Me.Pcompta.PreventEnterBeep = True
        Me.Pcompta.Size = New System.Drawing.Size(141, 26)
        Me.Pcompta.TabIndex = 33
        '
        'LabelX17
        '
        '
        '
        '
        Me.LabelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX17.Location = New System.Drawing.Point(19, 30)
        Me.LabelX17.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX17.Name = "LabelX17"
        Me.LabelX17.Size = New System.Drawing.Size(141, 32)
        Me.LabelX17.TabIndex = 32
        Me.LabelX17.Text = "Numéro Pcompta"
        '
        'SuperTabItem3
        '
        Me.SuperTabItem3.AttachedControl = Me.SuperTabControlPanel3
        Me.SuperTabItem3.GlobalItem = False
        Me.SuperTabItem3.ImageIndex = 4
        Me.SuperTabItem3.Name = "SuperTabItem3"
        Me.SuperTabItem3.Text = "Référence"
        '
        'SuperTabItem1
        '
        Me.SuperTabItem1.AttachedControl = Me.SuperTabControlPanel1
        Me.SuperTabItem1.GlobalItem = False
        Me.SuperTabItem1.ImageIndex = 5
        Me.SuperTabItem1.Name = "SuperTabItem1"
        Me.SuperTabItem1.Text = "Info"
        '
        'SuperTabControlPanel9
        '
        Me.SuperTabControlPanel9.Controls.Add(Me.AWeb1)
        Me.SuperTabControlPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel9.Location = New System.Drawing.Point(0, 38)
        Me.SuperTabControlPanel9.Name = "SuperTabControlPanel9"
        Me.SuperTabControlPanel9.Size = New System.Drawing.Size(1136, 473)
        Me.SuperTabControlPanel9.TabIndex = 0
        Me.SuperTabControlPanel9.TabItem = Me.SuperTabItem9
        '
        'AWeb1
        '
        Me.AWeb1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AWeb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AWeb1.Location = New System.Drawing.Point(0, 0)
        Me.AWeb1.Margin = New System.Windows.Forms.Padding(4)
        Me.AWeb1.Name = "AWeb1"
        Me.AWeb1.Size = New System.Drawing.Size(1136, 473)
        Me.AWeb1.TabIndex = 0
        Me.AWeb1.URL = Nothing
        '
        'SuperTabItem9
        '
        Me.SuperTabItem9.AttachedControl = Me.SuperTabControlPanel9
        Me.SuperTabItem9.GlobalItem = False
        Me.SuperTabItem9.ImageIndex = 52
        Me.SuperTabItem9.Name = "SuperTabItem9"
        Me.SuperTabItem9.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.BlueMist
        Me.SuperTabItem9.Text = "Zefix"
        '
        'SuperTabControlPanel8
        '
        Me.SuperTabControlPanel8.Controls.Add(Me.PrestationViewer1)
        Me.SuperTabControlPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel8.Location = New System.Drawing.Point(0, 38)
        Me.SuperTabControlPanel8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SuperTabControlPanel8.Name = "SuperTabControlPanel8"
        Me.SuperTabControlPanel8.Size = New System.Drawing.Size(1136, 473)
        Me.SuperTabControlPanel8.TabIndex = 0
        Me.SuperTabControlPanel8.TabItem = Me.SuperTabItem8
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
        Me.PrestationViewer1.Size = New System.Drawing.Size(1136, 473)
        Me.PrestationViewer1.TabIndex = 0
        '
        'SuperTabItem8
        '
        Me.SuperTabItem8.AttachedControl = Me.SuperTabControlPanel8
        Me.SuperTabItem8.GlobalItem = False
        Me.SuperTabItem8.ImageIndex = 15
        Me.SuperTabItem8.Name = "SuperTabItem8"
        Me.SuperTabItem8.Text = "Prestations"
        '
        'PanelDockContainer1
        '
        Me.PanelDockContainer1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelDockContainer1.Controls.Add(Me.SGC)
        Me.PanelDockContainer1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelDockContainer1.Location = New System.Drawing.Point(3, 28)
        Me.PanelDockContainer1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelDockContainer1.Name = "PanelDockContainer1"
        Me.PanelDockContainer1.Size = New System.Drawing.Size(1136, 511)
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
        Me.SGC.Size = New System.Drawing.Size(1136, 511)
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
        Me.DockSite1.Location = New System.Drawing.Point(0, 105)
        Me.DockSite1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DockSite1.Name = "DockSite1"
        Me.DockSite1.Size = New System.Drawing.Size(0, 542)
        Me.DockSite1.TabIndex = 21
        Me.DockSite1.TabStop = False
        '
        'DockSite2
        '
        Me.DockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite2.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite2.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite2.Location = New System.Drawing.Point(1142, 105)
        Me.DockSite2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DockSite2.Name = "DockSite2"
        Me.DockSite2.Size = New System.Drawing.Size(0, 542)
        Me.DockSite2.TabIndex = 22
        Me.DockSite2.TabStop = False
        '
        'DockSite8
        '
        Me.DockSite8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DockSite8.Location = New System.Drawing.Point(0, 695)
        Me.DockSite8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DockSite8.Name = "DockSite8"
        Me.DockSite8.Size = New System.Drawing.Size(1142, 0)
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
        Me.DockSite5.Size = New System.Drawing.Size(0, 590)
        Me.DockSite5.TabIndex = 25
        Me.DockSite5.TabStop = False
        '
        'DockSite6
        '
        Me.DockSite6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite6.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite6.Location = New System.Drawing.Point(1142, 105)
        Me.DockSite6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DockSite6.Name = "DockSite6"
        Me.DockSite6.Size = New System.Drawing.Size(0, 590)
        Me.DockSite6.TabIndex = 26
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
        Me.DockSite7.Size = New System.Drawing.Size(1142, 57)
        Me.DockSite7.TabIndex = 27
        Me.DockSite7.TabStop = False
        '
        'Bar1
        '
        Me.Bar1.AccessibleDescription = "DotNetBar Bar (Bar1)"
        Me.Bar1.AccessibleName = "DotNetBar Bar"
        Me.Bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.Bar1.DockSide = DevComponents.DotNetBar.eDockSide.Top
        Me.Bar1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Bar1.IsMaximized = False
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonX1, Me.Btn_Add, Me.ButtonX2, Me.ButtonX3, Me.ButtonX4, Me.ButtonItem2})
        Me.Bar1.Location = New System.Drawing.Point(0, 0)
        Me.Bar1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Bar1.MenuBar = True
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Size = New System.Drawing.Size(1142, 56)
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
        Me.ButtonX1.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlN)
        Me.ButtonX1.Text = "Nouveau"
        Me.ButtonX1.Tooltip = "Use Ctrl + N"
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
        Me.DockSite3.Size = New System.Drawing.Size(1142, 0)
        Me.DockSite3.TabIndex = 23
        Me.DockSite3.TabStop = False
        '
        'ClientViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DockSite9)
        Me.Controls.Add(Me.DockSite2)
        Me.Controls.Add(Me.DockSite1)
        Me.Controls.Add(Me.PanelEx5)
        Me.Controls.Add(Me.DockSite3)
        Me.Controls.Add(Me.DockSite4)
        Me.Controls.Add(Me.DockSite5)
        Me.Controls.Add(Me.DockSite6)
        Me.Controls.Add(Me.DockSite7)
        Me.Controls.Add(Me.DockSite8)
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ClientViewer"
        Me.Size = New System.Drawing.Size(1142, 695)
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx3.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx5.ResumeLayout(False)
        Me.DockSite9.ResumeLayout(False)
        CType(Me.Bar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bar2.ResumeLayout(False)
        Me.PanelDockContainer2.ResumeLayout(False)
        Me.PanelEx4.ResumeLayout(False)
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControl1.ResumeLayout(False)
        Me.SuperTabControlPanel1.ResumeLayout(False)
        Me.PanelEx6.ResumeLayout(False)
        CType(Me.SuperTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControl2.ResumeLayout(False)
        Me.SuperTabControlPanel2.ResumeLayout(False)
        Me.PanelEx7.ResumeLayout(False)
        Me.SuperTabControlPanel7.ResumeLayout(False)
        Me.SuperTabControlPanel4.ResumeLayout(False)
        Me.PanelEx8.ResumeLayout(False)
        Me.SuperTabControlPanel5.ResumeLayout(False)
        Me.PanelEx9.ResumeLayout(False)
        Me.SuperTabControlPanel6.ResumeLayout(False)
        Me.SuperTabControlPanel3.ResumeLayout(False)
        Me.PanelEx10.ResumeLayout(False)
        Me.SuperTabControlPanel9.ResumeLayout(False)
        Me.SuperTabControlPanel8.ResumeLayout(False)
        Me.PanelDockContainer1.ResumeLayout(False)
        Me.DockSite7.ResumeLayout(False)
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents IL_Client As ImageList
    Friend WithEvents IL_ As ImageList
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelEx5 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Vcr1 As SmartCoder.SuperGridDemo.VcrControl
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
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Btn_Add As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonX4 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Btn_SendToExcel As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents DockSite9 As DevComponents.DotNetBar.DockSite
    Friend WithEvents Bar2 As DevComponents.DotNetBar.Bar
    Friend WithEvents PanelDockContainer2 As DevComponents.DotNetBar.PanelDockContainer
    Friend WithEvents PanelDockContainer1 As DevComponents.DotNetBar.PanelDockContainer
    Friend WithEvents DockContainerItem1 As DevComponents.DotNetBar.DockContainerItem
    Friend WithEvents DockContainerItem2 As DevComponents.DotNetBar.DockContainerItem
    Friend WithEvents PanelEx4 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents SuperTabControl1 As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents SuperTabControlPanel1 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents PanelEx6 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents SuperTabControl2 As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents SuperTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents PanelEx7 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LabelX41 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Forfait As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Btn_Verify As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Active As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents NomClient As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents RaisonSociale As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Ref As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents SuperTabItem2 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel4 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents PanelEx8 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Website As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX16 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Email As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Landline As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Fax As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Cell As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents SuperTabItem4 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel5 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents PanelEx9 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Address1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Address2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PostalCode As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX19 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Region As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX20 As DevComponents.DotNetBar.LabelX
    Friend WithEvents City As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Country As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX21 As DevComponents.DotNetBar.LabelX
    Friend WithEvents SuperTabItem5 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel6 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents Other As DevComponents.DotNetBar.Controls.RichTextBoxEx
    Friend WithEvents SuperTabItem6 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel7 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItem7 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel3 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents PanelEx10 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Zefix As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents CHE As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents IDE As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents RépertoireFactures As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX18 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Répertoire As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Pcompta As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX17 As DevComponents.DotNetBar.LabelX
    Friend WithEvents SuperTabItem3 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabItem1 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel8 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents PrestationViewer1 As PrestationViewer
    Friend WithEvents SuperTabItem8 As DevComponents.DotNetBar.SuperTabItem
    Private WithEvents SGC As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents IL_32 As ImageList
    Friend WithEvents Tarification1 As Tarification
    Friend WithEvents SuperTabControlPanel9 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItem9 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents AWeb1 As UWeb
End Class
