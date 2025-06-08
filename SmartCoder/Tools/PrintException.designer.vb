<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintException
    Inherits DevComponents.DotNetBar.OfficeForm

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
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.Txt_Name = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.SuperTabControl1 = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabControlPanel5 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.Prop_Exception = New DevComponents.DotNetBar.AdvPropertyGrid()
        Me.SuperTabItem5 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel4 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.CollapsibleSplitContainer3 = New DevComponents.DotNetBar.Controls.CollapsibleSplitContainer()
        Me.Prop_TargetSite = New DevComponents.DotNetBar.AdvPropertyGrid()
        Me.TargetSite = New DevComponents.DotNetBar.Controls.RichTextBoxEx()
        Me.SuperTabItem4 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel3 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.CollapsibleSplitContainer1 = New DevComponents.DotNetBar.Controls.CollapsibleSplitContainer()
        Me.Prop_StackTrace = New DevComponents.DotNetBar.AdvPropertyGrid()
        Me.Stacktrace = New DevComponents.DotNetBar.Controls.RichTextBoxEx()
        Me.SuperTabItem3 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.CollapsibleSplitContainer2 = New DevComponents.DotNetBar.Controls.CollapsibleSplitContainer()
        Me.Prop_HelpLink = New DevComponents.DotNetBar.AdvPropertyGrid()
        Me.HelpLink = New DevComponents.DotNetBar.Controls.RichTextBoxEx()
        Me.SuperTabItem2 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.Message = New DevComponents.DotNetBar.Controls.RichTextBoxEx()
        Me.SuperTabItem1 = New DevComponents.DotNetBar.SuperTabItem()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControl1.SuspendLayout()
        Me.SuperTabControlPanel5.SuspendLayout()
        CType(Me.Prop_Exception, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControlPanel4.SuspendLayout()
        CType(Me.CollapsibleSplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CollapsibleSplitContainer3.Panel1.SuspendLayout()
        Me.CollapsibleSplitContainer3.Panel2.SuspendLayout()
        Me.CollapsibleSplitContainer3.SuspendLayout()
        CType(Me.Prop_TargetSite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControlPanel3.SuspendLayout()
        CType(Me.CollapsibleSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CollapsibleSplitContainer1.Panel1.SuspendLayout()
        Me.CollapsibleSplitContainer1.Panel2.SuspendLayout()
        Me.CollapsibleSplitContainer1.SuspendLayout()
        CType(Me.Prop_StackTrace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControlPanel2.SuspendLayout()
        CType(Me.CollapsibleSplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CollapsibleSplitContainer2.Panel1.SuspendLayout()
        Me.CollapsibleSplitContainer2.Panel2.SuspendLayout()
        Me.CollapsibleSplitContainer2.SuspendLayout()
        CType(Me.Prop_HelpLink, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControlPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(36, 34)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(112, 34)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Name"
        '
        'Txt_Name
        '
        '
        '
        '
        Me.Txt_Name.Border.Class = "TextBoxBorder"
        Me.Txt_Name.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Txt_Name.Location = New System.Drawing.Point(158, 38)
        Me.Txt_Name.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_Name.Name = "Txt_Name"
        Me.Txt_Name.PreventEnterBeep = True
        Me.Txt_Name.Size = New System.Drawing.Size(330, 23)
        Me.Txt_Name.TabIndex = 1
        '
        'SuperTabControl1
        '
        Me.SuperTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel5)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel4)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel3)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel2)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel1)
        Me.SuperTabControl1.Location = New System.Drawing.Point(0, 94)
        Me.SuperTabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.SuperTabControl1.Name = "SuperTabControl1"
        Me.SuperTabControl1.ReorderTabsEnabled = True
        Me.SuperTabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SuperTabControl1.SelectedTabIndex = 4
        Me.SuperTabControl1.Size = New System.Drawing.Size(974, 484)
        Me.SuperTabControl1.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabControl1.TabIndex = 2
        Me.SuperTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabItem1, Me.SuperTabItem2, Me.SuperTabItem3, Me.SuperTabItem4, Me.SuperTabItem5})
        Me.SuperTabControl1.Text = "SuperTabControl1"
        '
        'SuperTabControlPanel5
        '
        Me.SuperTabControlPanel5.Controls.Add(Me.Prop_Exception)
        Me.SuperTabControlPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel5.Location = New System.Drawing.Point(0, 25)
        Me.SuperTabControlPanel5.Margin = New System.Windows.Forms.Padding(4)
        Me.SuperTabControlPanel5.Name = "SuperTabControlPanel5"
        Me.SuperTabControlPanel5.Size = New System.Drawing.Size(974, 459)
        Me.SuperTabControlPanel5.TabIndex = 0
        Me.SuperTabControlPanel5.TabItem = Me.SuperTabItem5
        '
        'Prop_Exception
        '
        Me.Prop_Exception.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Prop_Exception.GridLinesColor = System.Drawing.Color.WhiteSmoke
        Me.Prop_Exception.Location = New System.Drawing.Point(0, 0)
        Me.Prop_Exception.Margin = New System.Windows.Forms.Padding(4)
        Me.Prop_Exception.Name = "Prop_Exception"
        Me.Prop_Exception.Size = New System.Drawing.Size(974, 459)
        Me.Prop_Exception.TabIndex = 0
        Me.Prop_Exception.Text = "AdvPropertyGrid3"
        '
        'SuperTabItem5
        '
        Me.SuperTabItem5.AttachedControl = Me.SuperTabControlPanel5
        Me.SuperTabItem5.GlobalItem = False
        Me.SuperTabItem5.Name = "SuperTabItem5"
        Me.SuperTabItem5.Text = "Property"
        '
        'SuperTabControlPanel4
        '
        Me.SuperTabControlPanel4.Controls.Add(Me.CollapsibleSplitContainer3)
        Me.SuperTabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel4.Location = New System.Drawing.Point(0, 25)
        Me.SuperTabControlPanel4.Margin = New System.Windows.Forms.Padding(4)
        Me.SuperTabControlPanel4.Name = "SuperTabControlPanel4"
        Me.SuperTabControlPanel4.Size = New System.Drawing.Size(974, 459)
        Me.SuperTabControlPanel4.TabIndex = 0
        Me.SuperTabControlPanel4.TabItem = Me.SuperTabItem4
        '
        'CollapsibleSplitContainer3
        '
        Me.CollapsibleSplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CollapsibleSplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.CollapsibleSplitContainer3.Margin = New System.Windows.Forms.Padding(4)
        Me.CollapsibleSplitContainer3.Name = "CollapsibleSplitContainer3"
        '
        'CollapsibleSplitContainer3.Panel1
        '
        Me.CollapsibleSplitContainer3.Panel1.Controls.Add(Me.Prop_TargetSite)
        '
        'CollapsibleSplitContainer3.Panel2
        '
        Me.CollapsibleSplitContainer3.Panel2.Controls.Add(Me.TargetSite)
        Me.CollapsibleSplitContainer3.Size = New System.Drawing.Size(974, 459)
        Me.CollapsibleSplitContainer3.SplitterDistance = 324
        Me.CollapsibleSplitContainer3.SplitterWidth = 30
        Me.CollapsibleSplitContainer3.TabIndex = 1
        '
        'Prop_TargetSite
        '
        Me.Prop_TargetSite.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Prop_TargetSite.GridLinesColor = System.Drawing.Color.WhiteSmoke
        Me.Prop_TargetSite.Location = New System.Drawing.Point(0, 0)
        Me.Prop_TargetSite.Margin = New System.Windows.Forms.Padding(4)
        Me.Prop_TargetSite.Name = "Prop_TargetSite"
        Me.Prop_TargetSite.Size = New System.Drawing.Size(324, 459)
        Me.Prop_TargetSite.TabIndex = 0
        Me.Prop_TargetSite.Text = "AdvPropertyGrid1"
        '
        'TargetSite
        '
        '
        '
        '
        Me.TargetSite.BackgroundStyle.Class = "RichTextBoxBorder"
        Me.TargetSite.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TargetSite.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TargetSite.Location = New System.Drawing.Point(0, 0)
        Me.TargetSite.Margin = New System.Windows.Forms.Padding(4)
        Me.TargetSite.Name = "TargetSite"
        Me.TargetSite.Rtf = "{\rtf1\ansi\deff0{\fonttbl{\f0\fnil\fcharset0 Century Gothic;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\viewkind4\uc1\p" &
    "ard\lang1033\f0\fs20 RichTextBoxEx2\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TargetSite.Size = New System.Drawing.Size(620, 459)
        Me.TargetSite.TabIndex = 2
        Me.TargetSite.Text = "RichTextBoxEx2"
        '
        'SuperTabItem4
        '
        Me.SuperTabItem4.AttachedControl = Me.SuperTabControlPanel4
        Me.SuperTabItem4.GlobalItem = False
        Me.SuperTabItem4.Name = "SuperTabItem4"
        Me.SuperTabItem4.Text = "TargetSite"
        '
        'SuperTabControlPanel3
        '
        Me.SuperTabControlPanel3.Controls.Add(Me.CollapsibleSplitContainer1)
        Me.SuperTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel3.Location = New System.Drawing.Point(0, 25)
        Me.SuperTabControlPanel3.Margin = New System.Windows.Forms.Padding(4)
        Me.SuperTabControlPanel3.Name = "SuperTabControlPanel3"
        Me.SuperTabControlPanel3.Size = New System.Drawing.Size(974, 459)
        Me.SuperTabControlPanel3.TabIndex = 0
        Me.SuperTabControlPanel3.TabItem = Me.SuperTabItem3
        '
        'CollapsibleSplitContainer1
        '
        Me.CollapsibleSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CollapsibleSplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.CollapsibleSplitContainer1.Margin = New System.Windows.Forms.Padding(4)
        Me.CollapsibleSplitContainer1.Name = "CollapsibleSplitContainer1"
        '
        'CollapsibleSplitContainer1.Panel1
        '
        Me.CollapsibleSplitContainer1.Panel1.Controls.Add(Me.Prop_StackTrace)
        '
        'CollapsibleSplitContainer1.Panel2
        '
        Me.CollapsibleSplitContainer1.Panel2.Controls.Add(Me.Stacktrace)
        Me.CollapsibleSplitContainer1.Size = New System.Drawing.Size(974, 459)
        Me.CollapsibleSplitContainer1.SplitterDistance = 324
        Me.CollapsibleSplitContainer1.SplitterWidth = 30
        Me.CollapsibleSplitContainer1.TabIndex = 0
        '
        'Prop_StackTrace
        '
        Me.Prop_StackTrace.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Prop_StackTrace.GridLinesColor = System.Drawing.Color.WhiteSmoke
        Me.Prop_StackTrace.Location = New System.Drawing.Point(0, 0)
        Me.Prop_StackTrace.Margin = New System.Windows.Forms.Padding(4)
        Me.Prop_StackTrace.Name = "Prop_StackTrace"
        Me.Prop_StackTrace.Size = New System.Drawing.Size(324, 459)
        Me.Prop_StackTrace.TabIndex = 0
        Me.Prop_StackTrace.Text = "AdvPropertyGrid1"
        '
        'Stacktrace
        '
        '
        '
        '
        Me.Stacktrace.BackgroundStyle.Class = "RichTextBoxBorder"
        Me.Stacktrace.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Stacktrace.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Stacktrace.Location = New System.Drawing.Point(0, 0)
        Me.Stacktrace.Margin = New System.Windows.Forms.Padding(4)
        Me.Stacktrace.Name = "Stacktrace"
        Me.Stacktrace.Rtf = "{\rtf1\ansi\deff0{\fonttbl{\f0\fnil\fcharset0 Century Gothic;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\viewkind4\uc1\p" &
    "ard\lang1033\f0\fs20 RichTextBoxEx1\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Stacktrace.Size = New System.Drawing.Size(620, 459)
        Me.Stacktrace.TabIndex = 2
        Me.Stacktrace.Text = "RichTextBoxEx1"
        '
        'SuperTabItem3
        '
        Me.SuperTabItem3.AttachedControl = Me.SuperTabControlPanel3
        Me.SuperTabItem3.GlobalItem = False
        Me.SuperTabItem3.Name = "SuperTabItem3"
        Me.SuperTabItem3.Text = "StackTrace"
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.Controls.Add(Me.CollapsibleSplitContainer2)
        Me.SuperTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel2.Location = New System.Drawing.Point(0, 25)
        Me.SuperTabControlPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.SuperTabControlPanel2.Name = "SuperTabControlPanel2"
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(974, 459)
        Me.SuperTabControlPanel2.TabIndex = 0
        Me.SuperTabControlPanel2.TabItem = Me.SuperTabItem2
        '
        'CollapsibleSplitContainer2
        '
        Me.CollapsibleSplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CollapsibleSplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.CollapsibleSplitContainer2.Margin = New System.Windows.Forms.Padding(4)
        Me.CollapsibleSplitContainer2.Name = "CollapsibleSplitContainer2"
        '
        'CollapsibleSplitContainer2.Panel1
        '
        Me.CollapsibleSplitContainer2.Panel1.Controls.Add(Me.Prop_HelpLink)
        '
        'CollapsibleSplitContainer2.Panel2
        '
        Me.CollapsibleSplitContainer2.Panel2.Controls.Add(Me.HelpLink)
        Me.CollapsibleSplitContainer2.Size = New System.Drawing.Size(974, 459)
        Me.CollapsibleSplitContainer2.SplitterDistance = 324
        Me.CollapsibleSplitContainer2.SplitterWidth = 30
        Me.CollapsibleSplitContainer2.TabIndex = 1
        '
        'Prop_HelpLink
        '
        Me.Prop_HelpLink.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Prop_HelpLink.GridLinesColor = System.Drawing.Color.WhiteSmoke
        Me.Prop_HelpLink.Location = New System.Drawing.Point(0, 0)
        Me.Prop_HelpLink.Margin = New System.Windows.Forms.Padding(4)
        Me.Prop_HelpLink.Name = "Prop_HelpLink"
        Me.Prop_HelpLink.Size = New System.Drawing.Size(324, 459)
        Me.Prop_HelpLink.TabIndex = 0
        Me.Prop_HelpLink.Text = "AdvPropertyGrid1"
        '
        'HelpLink
        '
        '
        '
        '
        Me.HelpLink.BackgroundStyle.Class = "RichTextBoxBorder"
        Me.HelpLink.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.HelpLink.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpLink.Location = New System.Drawing.Point(0, 0)
        Me.HelpLink.Margin = New System.Windows.Forms.Padding(4)
        Me.HelpLink.Name = "HelpLink"
        Me.HelpLink.Rtf = "{\rtf1\ansi\deff0{\fonttbl{\f0\fnil\fcharset0 Century Gothic;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\viewkind4\uc1\p" &
    "ard\lang1033\f0\fs20 RichTextBoxEx2\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.HelpLink.Size = New System.Drawing.Size(620, 459)
        Me.HelpLink.TabIndex = 2
        Me.HelpLink.Text = "RichTextBoxEx2"
        '
        'SuperTabItem2
        '
        Me.SuperTabItem2.AttachedControl = Me.SuperTabControlPanel2
        Me.SuperTabItem2.GlobalItem = False
        Me.SuperTabItem2.Name = "SuperTabItem2"
        Me.SuperTabItem2.Text = "HelpLink"
        '
        'SuperTabControlPanel1
        '
        Me.SuperTabControlPanel1.Controls.Add(Me.Message)
        Me.SuperTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel1.Location = New System.Drawing.Point(0, 25)
        Me.SuperTabControlPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.SuperTabControlPanel1.Name = "SuperTabControlPanel1"
        Me.SuperTabControlPanel1.Size = New System.Drawing.Size(974, 459)
        Me.SuperTabControlPanel1.TabIndex = 1
        Me.SuperTabControlPanel1.TabItem = Me.SuperTabItem1
        '
        'Message
        '
        '
        '
        '
        Me.Message.BackgroundStyle.Class = "RichTextBoxBorder"
        Me.Message.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Message.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Message.Location = New System.Drawing.Point(0, 0)
        Me.Message.Margin = New System.Windows.Forms.Padding(4)
        Me.Message.Name = "Message"
        Me.Message.Rtf = "{\rtf1\ansi\deff0{\fonttbl{\f0\fnil\fcharset0 Century Gothic;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\viewkind4\uc1\p" &
    "ard\lang1033\f0\fs20 RichTextBoxEx1\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Message.Size = New System.Drawing.Size(974, 459)
        Me.Message.TabIndex = 0
        Me.Message.Text = "RichTextBoxEx1"
        '
        'SuperTabItem1
        '
        Me.SuperTabItem1.AttachedControl = Me.SuperTabControlPanel1
        Me.SuperTabItem1.GlobalItem = False
        Me.SuperTabItem1.Name = "SuperTabItem1"
        Me.SuperTabItem1.Text = "Message"
        '
        'PrintException
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 577)
        Me.Controls.Add(Me.SuperTabControl1)
        Me.Controls.Add(Me.Txt_Name)
        Me.Controls.Add(Me.LabelX1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Font", My.MySettings.Default, "Font", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DoubleBuffered = True
        Me.Font = My.MySettings.Default.Font
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PrintException"
        Me.Text = "PrintException"
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControl1.ResumeLayout(False)
        Me.SuperTabControlPanel5.ResumeLayout(False)
        CType(Me.Prop_Exception, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControlPanel4.ResumeLayout(False)
        Me.CollapsibleSplitContainer3.Panel1.ResumeLayout(False)
        Me.CollapsibleSplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.CollapsibleSplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CollapsibleSplitContainer3.ResumeLayout(False)
        CType(Me.Prop_TargetSite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControlPanel3.ResumeLayout(False)
        Me.CollapsibleSplitContainer1.Panel1.ResumeLayout(False)
        Me.CollapsibleSplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.CollapsibleSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CollapsibleSplitContainer1.ResumeLayout(False)
        CType(Me.Prop_StackTrace, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControlPanel2.ResumeLayout(False)
        Me.CollapsibleSplitContainer2.Panel1.ResumeLayout(False)
        Me.CollapsibleSplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.CollapsibleSplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CollapsibleSplitContainer2.ResumeLayout(False)
        CType(Me.Prop_HelpLink, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControlPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Txt_Name As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents SuperTabControl1 As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents SuperTabControlPanel1 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItem1 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel5 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents Prop_Exception As DevComponents.DotNetBar.AdvPropertyGrid
    Friend WithEvents SuperTabItem5 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel4 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents CollapsibleSplitContainer3 As DevComponents.DotNetBar.Controls.CollapsibleSplitContainer
    Friend WithEvents Prop_TargetSite As DevComponents.DotNetBar.AdvPropertyGrid
    Friend WithEvents TargetSite As DevComponents.DotNetBar.Controls.RichTextBoxEx
    Friend WithEvents SuperTabItem4 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel3 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents CollapsibleSplitContainer1 As DevComponents.DotNetBar.Controls.CollapsibleSplitContainer
    Friend WithEvents Prop_StackTrace As DevComponents.DotNetBar.AdvPropertyGrid
    Friend WithEvents Stacktrace As DevComponents.DotNetBar.Controls.RichTextBoxEx
    Friend WithEvents SuperTabItem3 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents CollapsibleSplitContainer2 As DevComponents.DotNetBar.Controls.CollapsibleSplitContainer
    Friend WithEvents Prop_HelpLink As DevComponents.DotNetBar.AdvPropertyGrid
    Friend WithEvents HelpLink As DevComponents.DotNetBar.Controls.RichTextBoxEx
    Friend WithEvents SuperTabItem2 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents Message As DevComponents.DotNetBar.Controls.RichTextBoxEx
End Class
