Imports System.Windows.Forms

Public Class VbNET_Module

    Dim U_Property As VbNET_Property
    Dim U_Enumeration As VbNET_Enumeration
    Dim U_Structure As VbNET_Structure
    Dim U_Sub As VbNET_Sub
    Dim U_Function As VbNET_Function
    Dim U_Runtime As VbNET_Runtime
    Dim U_Loader As VbNET_Loader
    Dim U_Class As VbNET_Class
    Dim U_Module As VbNET_Module

    Private _ActiveParent As Object
    Public Property ActiveParent() As Object
        Get
            Return _ActiveParent
        End Get
        Set(ByVal value As Object)
            If Not IsNothing(value) Then
                If IsNothing(VirtualModule) Then
                    VirtualModule = New VbNET.Module
                End If

                If TypeOf value Is VbNET.Class Then
                    VirtualClass_Parent.Text = value.Name
                    VirtualModule.ParentClass = value


                ElseIf TypeOf value Is VbNET.Module Then
                    VirtualClass_Parent.Text = value.name
                    VirtualModule.ParentModule = value
                End If
            End If
            _ActiveParent = value
        End Set
    End Property


    Private Sub VbNET_Module_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshParents(VirtualClass_Parent, False, True)
        ContextMenuBar1.SetContextMenuEx(SchemaTree, Btn_Menu_Schema)
        AdvPropertyGrid1.SelectedObject = VirtualModule
        U_Property = New VbNET_Property
        U_Property.Dock = Windows.Forms.DockStyle.Fill
        Panel_Property.Controls.Add(U_Property)
        U_Property.ActiveParent = VirtualModule
        U_Property.Property_Parent.Text = VirtualModule.Name

        U_Enumeration = New VbNET_Enumeration
        U_Enumeration.Dock = Windows.Forms.DockStyle.Fill
        Panel_Enumeration.Controls.Add(U_Enumeration)
        U_Enumeration.ActiveParent = VirtualModule
        U_Enumeration.Enumeration_Parent.Text = VirtualModule.Name

        U_Structure = New VbNET_Structure
        U_Structure.Dock = Windows.Forms.DockStyle.Fill
        Panel_Structure.Controls.Add(U_Structure)
        U_Structure.ActiveParent = VirtualModule
        U_Structure.Structure_Parent.Text = VirtualModule.Name

        U_Sub = New VbNET_Sub
        U_Sub.Dock = Windows.Forms.DockStyle.Fill
        Panel_Sub.Controls.Add(U_Sub)
        U_Sub.ActiveParent = VirtualModule
        U_Sub.Sub_Parent.Text = VirtualModule.Name

        U_Function = New VbNET_Function
        U_Function.Dock = Windows.Forms.DockStyle.Fill
        Panel_Function.Controls.Add(U_Function)
        U_Function.ActiveParent = VirtualModule
        U_Function.Function_Parent.Text = VirtualModule.Name

        U_Runtime = New VbNET_Runtime
        U_Runtime.Dock = Windows.Forms.DockStyle.Fill
        Panel_Runtime.Controls.Add(U_Runtime)
        U_Runtime.ActiveParent = VirtualModule
        U_Runtime.Runtime_Parent.Text = VirtualModule.Name

        U_Loader = New VbNET_Loader
        U_Loader.Dock = Windows.Forms.DockStyle.Fill
        Panel_Loader.Controls.Add(U_Loader)
        U_Loader.ActiveParent = VirtualModule
        U_Loader.Loader_Parent.Text = VirtualModule.Name

        U_Class = New VbNET_Class
        U_Class.Dock = Windows.Forms.DockStyle.Fill
        Panel_Class.Controls.Add(U_Class)
        U_Class.ActiveParent = VirtualModule
        U_Class.Class_Parent.Text = VirtualModule.Name

        U_Module = New VbNET_Module
        U_Module.Dock = DockStyle.Fill
        Panel_Module.Controls.Add(U_Module)
        U_Module.ActiveParent = VirtualModule
        U_Module.VirtualClass_Parent.Text = VirtualModule.Name
    End Sub

    Private Sub SchemaTree_Btn_Refresh_Click(sender As Object, e As EventArgs) Handles SchemaTree_Btn_Refresh.Click
        VirtualModule.RefreshMainNode()
        SchemaTree.Nodes.Clear()
        SchemaTree.Nodes.Add(VirtualModule.MainNode.DeepCopy)
        SchemaTree.ExpandAll()
    End Sub

#Region "<File Management>"

    Private Sub VirtualClass_Btn_New_Click(sender As Object, e As EventArgs) Handles Class_Btn_New.Click
        Dim NewName As String = InputBox("Enter the name of this Module", "Input Name required.", "VirtualModule")
        VirtualClass = New VbNET.Class(NewName)
        VirtualClass_AccessModifier.Text = "Public"
        VirtualClass_CategoryID.Value = 0
        VirtualClass_Description.Text = ""
        VirtualClass_DirectoryPath.Text = My.Application.Info.DirectoryPath & "\" & VirtualClass.Name
        If Not IO.Directory.Exists(My.Application.Info.DirectoryPath & "\" & VirtualClass.Name) Then
            IO.Directory.CreateDirectory(My.Application.Info.DirectoryPath & "\" & VirtualClass.Name)
        End If
        My.Settings.DefaultOuput = My.Application.Info.DirectoryPath & "\" & VirtualClass.Name
        My.Settings.Save()
        '   U_ListView1.Folder_Target.Text = My.Application.Info.DirectoryPath & "\" & VirtualClass.Name
        '  VirtualClass_Enable.Value = True
        VirtualClass_F_FilePath.Text = My.Application.Info.DirectoryPath & "\" & VirtualClass.Name & "\" & VirtualClass.Name & ".F"
        VirtualClass.FileF = New Fichier(VirtualClass_F_FilePath.Text)
        VirtualClass_F_Status.Text = IIf(VirtualClass.FileF.Exists, "Exist", "Ready")

        VirtualClass_C_FilePath.Text = My.Application.Info.DirectoryPath & "\" & VirtualClass.Name & "\" & VirtualClass.Name & ".C"
        VirtualClass.FileC = New Fichier(VirtualClass_C_FilePath.Text)
        VirtualClass_C_Status.Text = IIf(VirtualClass.FileC.Exists, "Exist", "Ready")

        VirtualClass_F_Process.Value = 0
        VirtualClass_F_Status.Text = ""

        VirtualClass_ID.Value = 0
        VirtualClass_JS_FilePath.Text = My.Application.Info.DirectoryPath & "\" & VirtualClass.Name & "\" & VirtualClass.Name & ".Js"
        VirtualClass_JS_Process.Value = 0
        ' VirtualClass_MustInherite.Value = False
        VirtualClass_Name.Text = NewName
        'VirtualClass_NotInheritable.Value = False
        VirtualClass_Python_FilePath.Text = My.Application.Info.DirectoryPath & "\" & VirtualClass.Name & "\" & VirtualClass.Name & ".Py"
        VirtualClass_Python_Process.Value = 0
        VirtualClass.FilePython = New Fichier(VirtualClass_Python_FilePath.Text)
        VirtualClass_Python_Status.Text = IIf(VirtualClass.FilePython.Exists, "Exist", "Ready")

        'VirtualClass_Shadows.Value = False
        VirtualClass_Parent.Text = "Class"
        VirtualClass_Summary_AuthorEmail.Text = My.Settings.AuthorEmail
        VirtualClass_Summary_AuthorName.Text = My.Settings.AuthorName
        VirtualClass_Summary_AuthorUrl.Text = My.Settings.AuthorUrl
        VirtualClass_Summary_ContributorEmail.Text = ""
        VirtualClass_Summary_ContributorName.Text = ""
        VirtualClass_Summary_ContributorUrl.Text = ""
        VirtualClass_Summary_Example.Text = ""
        VirtualClass_Summary_Note.Text = ""
        VirtualClass_Summary_Remark.Text = ""
        VirtualClass_Summary_Rights.Text = My.Settings.SummaryRights
        VirtualClass_Summary_Rules.Text = ""
        VirtualClass_Summary_Syntax.Text = ""
        VirtualClass_Summary_Usage.Text = ""
        VirtualClass_VB_FilePath.Text = My.Application.Info.DirectoryPath & "\" & VirtualClass.Name & "\" & VirtualClass.Name & ".Vb"
        VirtualClass.FileVB = New Fichier(VirtualClass_VB_FilePath.Text)
        VirtualClass_VB_Status.Text = IIf(VirtualClass.FileVB.Exists, "Exist", "Ready")

        VirtualClass_Vb_Process.Value = 0
        VirtualClass_VB_Status.Text = ""
        SchemaTree_Btn_Refresh.RaiseClick()
        AdvPropertyGrid1.SelectedObject = VirtualModule
    End Sub

    Private Sub VirtualClass_Btn_Open_Click(sender As Object, e As EventArgs) Handles Class_Btn_Open.Click
        Dim Ofd As New OpenFileDialog
        With Ofd
            .Filter = "VbNet Module Statement (*.Vb)|*.Vb|All Files (*.*)|*.*"
            If .ShowDialog = DialogResult.OK Then
                Try
                    VirtualModule.Open(.FileName)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End With
        AdvPropertyGrid1.SelectedObject = VirtualModule
    End Sub

    Private Sub VirtualClass_Btn_Save_Click(sender As Object, e As EventArgs) Handles Class_Btn_Save.Click
        If Not IsNothing(VirtualClass) Then
            Try
                VirtualClass.Save()
                MsgBox("Element saved.")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub VirtualClass_Btn_Preview_Click(sender As Object, e As EventArgs) Handles Class_Btn_Preview.Click
        VirtualModule.PrintStatement(VirtualClass_Vb,
                                    VirtualClass_C,
                                    VirtualClass_F,
                                    VirtualClass_Python,
                                    VirtualClass_JS,
                                    Class_Enable.Value)
    End Sub

    Private Sub VirtualClass_Btn_Construct_Click(sender As Object, e As EventArgs) Handles Class_Btn_Save.Click
        Try
            VirtualClass.Save()
            MsgBox("Save")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
End Class
