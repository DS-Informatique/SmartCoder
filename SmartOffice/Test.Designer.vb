<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Test
    Inherits DevComponents.DotNetBar.Office2007Form

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
        Me.Test_Item1 = New SmartCoder.Test_Item()
        Me.CMD_PrintStackFlow = New DevComponents.DotNetBar.Command(Me.components)
        Me.Cmd_Refresh = New DevComponents.DotNetBar.Command(Me.components)
        Me.SuspendLayout()
        '
        'Test_Item1
        '
        Me.Test_Item1.Analyse = Nothing
        '
        'CMD_PrintStackFlow
        '
        Me.CMD_PrintStackFlow.Name = "CMD_PrintStackFlow"
        Me.Test_Item1.CMD_PrintStackFlow = Me.CMD_PrintStackFlow
        '
        'Cmd_Refresh
        '
        Me.Cmd_Refresh.Name = "Cmd_Refresh"
        Me.Test_Item1.Cmd_Refresh = Me.Cmd_Refresh
        Me.Test_Item1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Test_Item1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Test_Item1.Language = SmartCoder.M_Langue.Enum_Langue.English
        Me.Test_Item1.ListOfTests = Nothing
        Me.Test_Item1.Location = New System.Drawing.Point(0, 0)
        Me.Test_Item1.Margin = New System.Windows.Forms.Padding(4)
        Me.Test_Item1.Name = "Test_Item1"
        Me.Test_Item1.SelectedTest = Nothing
        Me.Test_Item1.Size = New System.Drawing.Size(800, 450)
        Me.Test_Item1.TabIndex = 0
        '
        'Test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Test_Item1)
        Me.DoubleBuffered = True
        Me.Name = "Test"
        Me.Text = "Test"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Test_Item1 As SmartCoder.Test_Item
    Private WithEvents CMD_PrintStackFlow As DevComponents.DotNetBar.Command
    Private WithEvents Cmd_Refresh As DevComponents.DotNetBar.Command
End Class
