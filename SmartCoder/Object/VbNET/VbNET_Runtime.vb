Imports System.Windows.Forms

Public Class VbNET_Runtime


#Region "Runtime"
    Public Temp_Runtime As New VbNET.Runtime
    Private _ActiveParent As Object
    Public Property ActiveParent() As Object
        Get
            Return _ActiveParent
        End Get
        Set(ByVal value As Object)
            If Not IsNothing(value) Then
                If IsNothing(Temp_Runtime) Then
                    Temp_Runtime = New VbNET.Runtime
                End If

                If TypeOf value Is VbNET.Class Then
                    Runtime_Parent.Text = value.Name
                    Temp_Runtime.ParentClass = value

                ElseIf TypeOf value Is VbNET.Structure Then
                    Runtime_Parent.Text = value.Name
                    Temp_Runtime.ParentStructure = value
                    Dim T As VbNET.Structure
                    T = value
                    BS_Runtime.DataSource = T.Runtime
                    Bind_Runtime.BindingSource = BS_Runtime
                ElseIf TypeOf value Is VbNET.Module Then
                    Runtime_Parent.Text = value.name
                    Temp_Runtime.ParentModule = value
                    Dim T As VbNET.Module
                    T = value
                    BS_Runtime.DataSource = T.Runtime
                    Bind_Runtime.BindingSource = BS_Runtime
                End If
            End If
            _ActiveParent = value
        End Set
    End Property
#End Region
    Private Sub Btn_Refresh_Click(sender As Object, e As EventArgs) Handles Btn_Refresh.Click
        RefreshParents(Runtime_Parent)
    End Sub
    Public Sub Initializor()
        If IsNothing(VirtualClass) Then
            VirtualClass = New VbNET.Class("VirtualClass")
        End If
        Runtime_Parent.SelectedIndex = 0
    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Initializor()
        RefreshParents(Runtime_Parent)

    End Sub
    Public Sub OpenStatement(ByVal Statement As VbNET.Runtime)

        ' This call is required by the designer.
        ' InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Initializor()
        Temp_Runtime = Statement
        Read_Runtime(Statement)
    End Sub
    Public Sub Read_Runtime(ByRef Statement As VbNET.Runtime)
        If Not IsNothing(Statement) Then
            With Statement

                Runtime_AccessModifier.Text = VbNET.AccessModifiers_ToString(.AccessModifier)
                '  Runtime_AttributeList_Browsable.Value = .Browsable
                Runtime_Attribute_Category.Text = .Category
                ' Runtime_Attribute_DefaultValue.Text = .DefaultValue
                ' Runtime_Attribute_Deserializable.Value = .Deserializable
                ' Runtime_Attribute_Editor.Text = .Editor
                ' Runtime_Attribute_NonSerialized.Value = .NonSerialized
                ' Runtime_Attribute_RelatedImageList.Text = .RelatedImageList
                'Runtime_Attribute_Serializable.Value = .Serializable
                ' Runtime_Attribute_XmlIgnore.Value = .XmlIgnore
                '' Runtime_Attribute_XmlInclude.Value = .XmlInclude
                'Runtime_Attribute_XmlRoot.Text = .XmlRoot
                'Runtime_CategoryID.Value = .RegionCategory
                '  Runtime_Default.Value = .Default
                Runtime_Description.Text = .Description
                Runtime_Enable.Value = .Enable
                'Runtime_GetStatement.Text = .GetStatement
                Runtime_ID.Value = .ID
                Runtime_Name.Text = .Name
                '  Read_Parameters(Runtime_ParameterList, .ParameterList)
                'Read_Members(Runtime_Members, .Members)
                If Not IsNothing(.ParentClass) Then
                    Runtime_Parent.Text = .ParentClass.ClassName
                ElseIf Not IsNothing(.ParentModule) Then
                    Runtime_Parent.Text = .ParentModule.Name
                ElseIf Not IsNothing(.ParentStructure) Then
                    Runtime_Parent.Text = .ParentStructure.Name
                Else
                    Runtime_Parent.Text = VirtualClass.ClassName
                End If
                Runtime_Print_C.Text = .C
                Runtime_Print_F.Text = .F
                Runtime_Print_JS.Text = .JavaScript
                Runtime_Print_Python.Text = .Python
                Runtime_Print_VB.Text = .VB
                Property_Runtime.SelectedObject = Statement
                'Runtime_PropertyModifier.Text = VbNET.PropertyModifiers_ToString(.PropertyModifier)
                'Runtime_ReadOnly.Value = .ReadOnly
                'Runtime_Required.Value = .Required
                Runtime_ReturnType.Text = .ReturnType
                ' Runtime_Statement.Text = .Statement
                Runtime_Shadows.Value = .Shadows
                Runtime_Shared.Value = .Shared
                Runtime_Summary_AuthorEmail.Text = .AuthorEmail
                Runtime_Summary_AuthorName.Text = .AuthorName
                Runtime_Summary_AuthorUrl.Text = .AuthorUri
                Runtime_Summary_ContributorEmail.Text = .ContributorEmail
                Runtime_Summary_ContributorName.Text = .ContributorName
                Runtime_Summary_ContributorUrl.Text = .ContributorUri
                Runtime_Summary_Example.Text = .Example
                Runtime_Summary_Note.Text = .Note
                Runtime_Summary_Remark.Text = .Remarks
                Runtime_Summary_Rights.Text = .Rights
                Runtime_Summary_Rules.Text = .Rules
                Runtime_Summary_Syntax.Text = .Syntax
                Runtime_Summary_Usage.Text = .Usage
                'Runtime_Variable_AccessModifier.Text = VbNET.AccessModifiers_ToString(.Variable_AccessModifier)
                'Runtime_Variable_Name.Text = .Variable_Name
                'Runtime_Variable_ReturnType.Text = .Variable_ReturnType
                'Runtime_WriteOnly.Value = .WriteOnly

            End With

        End If
    End Sub
#Region "|ON |1|06| [Runtime]{31}"
#Region "|ON | |06.00| <Runtime> [FileManager]{4}"
#Region "|ON | |06.00.00| <Runtime> <FileManager> [New]"
    Private Sub Runtime_Btn_New_Click(sender As Object, e As EventArgs) Handles Runtime_Btn_New.Click
        Temp_Runtime = New VbNET.Runtime
        Runtime_AccessModifier.Text = "Public"
        Runtime_AttributeList_DefaultValue.Text = ""
        Runtime_CategoryID.Value = 0
        Runtime_Description.Text = ""
        Runtime_Dim.Value = False
        Runtime_Enable.Value = True
        Runtime_Name.Text = ""
        Runtime_ProcedureModifier.Text = ""
        Runtime_ReturnType.Text = "String"
        Runtime_Shadows.Value = False
        Runtime_Shared.Value = False
        Runtime_Summary_AuthorEmail.Text = My.Settings.AuthorEmail
        Runtime_Summary_AuthorName.Text = My.Settings.AuthorName
        Runtime_Summary_AuthorUrl.Text = My.Settings.AuthorUrl
        Runtime_Summary_ContributorEmail.Text = ""
        Runtime_Summary_ContributorName.Text = ""
        Runtime_Summary_ContributorUrl.Text = ""
        Runtime_Summary_Example.Text = ""
        Runtime_Summary_Note.Text = ""
        Runtime_Summary_Remark.Text = ""
        Runtime_Summary_Rights.Text = ""
        Runtime_Summary_Rules.Text = ""
        Runtime_Summary_Syntax.Text = ""
        Runtime_Summary_Usage.Text = ""
        Property_Runtime.SelectedObject = Temp_Runtime

    End Sub
#End Region
#Region "|ON | |06.00.01| <Runtime> <FileManager> [Open]"
    Private Sub Runtime_Btn_Open_Click(sender As Object, e As EventArgs) Handles Runtime_Btn_Open.Click
        Dim Ofd As New OpenFileDialog
        With Ofd
            .Filter = "Runtime Statement (*.Runtime)|*.Runtime|All Files (*.*)|*.*"
            If .ShowDialog = DialogResult.OK Then
                Try
                    Temp_Runtime.Open(.FileName)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End With
        Property_Runtime.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |06.00.02| <Runtime> <FileManager> [Save]"
    Private Sub Runtime_Btn_Save_Click(sender As Object, e As EventArgs) Handles Runtime_Btn_Save.Click
        If Not IsNothing(Temp_Runtime) Then
            If Temp_Runtime.Name <> "" Then
                Dim F = Temp_Runtime.Save().Output
                Temp_Runtime.XmlFile = F.Target
            End If
        End If
        Property_Runtime.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |06.00.03| <Runtime> <FileManager> [Preview]"
    Private Sub Runtime_Btn_Preview_Click(sender As Object, e As EventArgs) Handles Runtime_Btn_Preview.Click
        Temp_Runtime = New VbNET.Runtime(Runtime_Name.Text,
                                       Runtime_ReturnType.Text,,
                                       VbNET.String_ToAccessModifiers(Runtime_AccessModifier.Text),
                                       VbNET.String_ToProcedureModifiers(Runtime_ProcedureModifier.Text),
                                       Runtime_Shadows.Value,
                                       Runtime_Shared.Value,
                                       Runtime_Enable.Value,
                                       Runtime_Description.Text,
                                        New VbNET.Attributelist(Runtime_Attribute_Category.Text,
                                                               Runtime_Description.Text,
                                                               Runtime_AttributeList_DefaultValue.Text,
                                                               True),
                                       Runtime_Summary_AuthorName.Text,
                                       Runtime_Summary_AuthorEmail.Text,
                                       Runtime_Summary_AuthorUrl.Text,
                                       Runtime_Summary_ContributorName.Text,
                                       Runtime_Summary_ContributorEmail.Text,
                                       Runtime_Summary_ContributorUrl.Text,
                                       Runtime_Summary_Usage.Text,
                                       Runtime_Summary_Remark.Text,
                                       Runtime_Summary_Example.Text,
                                       Runtime_Summary_Note.Text,,
                                       Runtime_Summary_Rights.Text)
        Temp_Runtime.PrintStatement(Runtime_Print_VB, Runtime_Print_C, Runtime_Print_F, Runtime_Print_Python, Runtime_Print_JS, Runtime_Enable.Value)
        Property_Runtime.RefreshPropertyValues()

    End Sub
#End Region
#Region "|ON | |06.00.04| <Runtime> <FileManager> [Add]"
    Private Sub Runtime_Btn_Add_Click(sender As Object, e As EventArgs) Handles Runtime_Btn_Add.Click
        If Not IsNothing(VirtualClass) Then
            If IsNothing(Temp_Runtime) Then
                Temp_Runtime = New VbNET.Runtime(Runtime_Name.Text,
                                       Runtime_ReturnType.Text,
                                       ,
                                       VbNET.String_ToAccessModifiers(Runtime_AccessModifier.Text),
                                       VbNET.String_ToProcedureModifiers(Runtime_ProcedureModifier.Text),
                                       Runtime_Shadows.Value,
                                       Runtime_Enable.Value,
                                       Runtime_Description.Text,
                                       , New VbNET.Attributelist(Runtime_Attribute_Category.Text,
                                                               Runtime_Description.Text,
                                                               Runtime_AttributeList_DefaultValue.Text,
                                                               True),
                                       Runtime_Summary_AuthorName.Text,
                                       Runtime_Summary_AuthorEmail.Text,
                                       Runtime_Summary_AuthorUrl.Text,
                                       Runtime_Summary_ContributorName.Text,
                                       Runtime_Summary_ContributorEmail.Text,
                                       Runtime_Summary_ContributorUrl.Text,
                                       Runtime_Summary_Usage.Text,
                                       Runtime_Summary_Remark.Text,
                                       Runtime_Summary_Example.Text,
                                       Runtime_Summary_Note.Text,,
                                       Runtime_Summary_Rights.Text)
            End If
            Dim D = Runtime_Parent.SelectedItem.tag
            If TypeOf D Is VbNET.Class Then
                Temp_Runtime.ParentClass = D
                Temp_Runtime.ParentName = D.name
                Temp_Runtime.ParentClass.Add_Runtime(Temp_Runtime)
                BS_Runtime.DataSource = Temp_Runtime.ParentClass.Runtime
                Bind_Runtime.BindingSource = BS_Runtime
                Bind_Runtime.Visible = True
            ElseIf TypeOf D Is VbNET.Module Then
                Temp_Runtime.ParentModule = D
                Temp_Runtime.ParentName = D.name
                Temp_Runtime.ParentModule.Add_Runtime(Temp_Runtime)
                BS_Runtime.DataSource = Temp_Runtime.ParentModule.Runtime
                Bind_Runtime.BindingSource = BS_Runtime
                Bind_Runtime.Visible = True
            ElseIf TypeOf D Is VbNET.Structure Then
                Temp_Runtime.ParentStructure = D
                Temp_Runtime.ParentName = D.name
                Temp_Runtime.ParentStructure.Add_Runtime(Temp_Runtime)
                BS_Runtime.DataSource = Temp_Runtime.ParentStructure.Runtime
                Bind_Runtime.BindingSource = BS_Runtime
                Bind_Runtime.Visible = True
            End If
            ' Quantity_Runtime.Value += 1
            Runtime_ID.Value += 1
            '  RefreshReturnType()
        End If
        Property_Runtime.RefreshPropertyValues()
    End Sub
#End Region
#End Region
#Region "|ON | |06.01| <Runtime> [Constructor]{7}"
#Region "|ON | |06.01.00| <Runtime> <Constructor> [AccessModifier]"
    Private Sub Runtime_AccessModifier_TextChanged(sender As Object, e As EventArgs) Handles Runtime_AccessModifier.TextChanged
        If Not IsNothing(Temp_Runtime) Then
            If Runtime_Dim.Value = False Then
                Temp_Runtime.AccessModifier = VbNET.String_ToAccessModifiers(Runtime_AccessModifier.Text)
            End If
        End If
        Property_Runtime.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |06.01.01| <Runtime> <Constructor> [ProcedureModifier]"
    Private Sub Runtime_ProcedureModifier_TextChanged(sender As Object, e As EventArgs) Handles Runtime_ProcedureModifier.TextChanged
        If Not IsNothing(Temp_Runtime) Then
            If Runtime_Dim.Value = False Then
                Temp_Runtime.ProcedureModifier = VbNET.String_ToProcedureModifiers(Runtime_ProcedureModifier.Text)
            End If
        End If
        Property_Runtime.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |06.01.02| <Runtime> <Constructor> [ReturnType]"
    Private Sub Runtime_ReturnType_TextChanged(sender As Object, e As EventArgs) Handles Runtime_ReturnType.TextChanged
        If Not IsNothing(Temp_Runtime) Then
            Temp_Runtime.ReturnType = Runtime_ReturnType.Text
        End If
        Property_Runtime.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |06.01.03| <Runtime> <Constructor> [Name]"
    Private Sub Runtime_Name_TextChanged(sender As Object, e As EventArgs) Handles Runtime_Name.TextChanged
        If Not IsNothing(Temp_Runtime) Then
            Temp_Runtime.Name = Runtime_Name.Text
        End If
        Property_Runtime.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |06.01.04| <Runtime> <Constructor> [Dim]"
    Private Sub Runtime_Dim_ValueChanged(sender As Object, e As EventArgs) Handles Runtime_Dim.ValueChanged
        If Not IsNothing(Temp_Runtime) Then
            Temp_Runtime.Dim = Runtime_Dim.Value
        End If
        Property_Runtime.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |06.01.05| <Runtime> <Constructor> [Shadows]"
    Private Sub Runtime_Shadows_ValueChanged(sender As Object, e As EventArgs) Handles Runtime_Shadows.ValueChanged
        If Not IsNothing(Temp_Runtime) Then
            If Runtime_Dim.Value = False Then
                Temp_Runtime.Shadows = Runtime_Shadows.Value
            End If
        End If
        Property_Runtime.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |06.01.06| <Runtime> <Constructor> [Shared]"
    Private Sub Runtime_Shared_ValueChanged(sender As Object, e As EventArgs) Handles Runtime_Shared.ValueChanged
        If Not IsNothing(Temp_Runtime) Then
            If Runtime_Dim.Value = False Then
                Temp_Runtime.Shared = Runtime_Shared.Value
            End If
        End If
        Property_Runtime.RefreshPropertyValues()
    End Sub
#End Region
#End Region
#Region "|ON | |06.02| <Runtime> [Summary]{13}"
#Region "|ON | |06.02.00| <Runtime> <Summary> [Usage]"
    Private Sub Runtime_Summary_Usage_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Runtime_Summary_Usage.TextChanged
        If Not IsNothing(Temp_Runtime) Then
            Temp_Runtime.Usage = Runtime_Summary_Usage.Text
        End If
        Property_Runtime.RefreshPropertyValues()
    End Sub

#End Region
#Region "|ON | |06.02.01| <Runtime> <Summary> [Remark]"
    Private Sub Runtime_Summary_Remark_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Runtime_Summary_Remark.TextChanged
        If Not IsNothing(Temp_Runtime) Then
            Temp_Runtime.Remarks = Runtime_Summary_Remark.Text
        End If
        Property_Runtime.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |06.02.02| <Runtime> <Summary> [Example]"
    Private Sub Runtime_Summary_Example_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Runtime_Summary_Example.TextChanged
        If Not IsNothing(Temp_Runtime) Then
            Temp_Runtime.Example = Runtime_Summary_Example.Text
        End If
        Property_Runtime.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |06.02.03| <Runtime> <Summary> [Note]"
    Private Sub Runtime_Summary_Note_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Runtime_Summary_Note.TextChanged
        If Not IsNothing(Temp_Runtime) Then
            Temp_Runtime.Note = Runtime_Summary_Note.Text
        End If
        Property_Runtime.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |06.02.04| <Runtime> <Summary> [Rules]"
    Private Sub Runtime_Summary_Rules_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Runtime_Summary_Rules.TextChanged
        If Not IsNothing(Temp_Runtime) Then
            Temp_Runtime.Rules = Runtime_Summary_Rules.Text
        End If
        Property_Runtime.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |06.02.05| <Runtime> <Summary> [Syntax]"
    Private Sub Runtime_Summary_Syntax_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Runtime_Summary_Syntax.TextChanged
        If Not IsNothing(Temp_Runtime) Then
            Temp_Runtime.Syntax = Runtime_Summary_Syntax.Text
        End If
        Property_Runtime.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |06.02.06| <Runtime> <Summary> [Rights]"
    Private Sub Runtime_Summary_Rights_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Runtime_Summary_Rights.TextChanged
        If Not IsNothing(Temp_Runtime) Then
            Temp_Runtime.Rights = Runtime_Summary_Rights.Text
        End If
        Property_Runtime.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |06.02.07| <Runtime> <Summary> [AuthorName]"
    Private Sub Runtime_Summary_AuthorName_TextChanged(sender As Object, e As EventArgs) Handles Runtime_Summary_AuthorName.TextChanged
        If Not IsNothing(Temp_Runtime) Then
            Temp_Runtime.AuthorName = Runtime_Summary_AuthorName.Text
        End If
        Property_Runtime.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |06.02.08| <Runtime> <Summary> [AuthorEmail]"
    Private Sub Runtime_Summary_AuthorEmail_TextChanged(sender As Object, e As EventArgs) Handles Runtime_Summary_AuthorEmail.TextChanged
        If Not IsNothing(Temp_Runtime) Then
            Temp_Runtime.AuthorEmail = Runtime_Summary_AuthorEmail.Text
        End If
        Property_Runtime.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |06.02.09| <Runtime> <Summary> [AuthorUrl]"
    Private Sub Runtime_Summary_AuthorUrl_TextChanged(sender As Object, e As EventArgs) Handles Runtime_Summary_AuthorUrl.TextChanged
        If Not IsNothing(Temp_Runtime) Then
            Temp_Runtime.AuthorUri = Runtime_Summary_AuthorUrl.Text
        End If
        Property_Runtime.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |06.02.10| <Runtime> <Summary> [ContributorName]"
    Private Sub Runtime_Summary_ContributorName_TextChanged(sender As Object, e As EventArgs) Handles Runtime_Summary_ContributorName.TextChanged
        If Not IsNothing(Temp_Runtime) Then
            Temp_Runtime.ContributorName = Runtime_Summary_ContributorName.Text
        End If
        Property_Runtime.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |06.02.11| <Runtime> <Summary> [ContributorEmail]"
    Private Sub Runtime_Summary_ContributorEmail_TextChanged(sender As Object, e As EventArgs) Handles Runtime_Summary_ContributorEmail.TextChanged
        If Not IsNothing(Temp_Runtime) Then
            Temp_Runtime.ContributorEmail = Runtime_Summary_ContributorEmail.Text
        End If
        Property_Runtime.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |06.02.12| <Runtime> <Summary> [ContributorUrl]"
    Private Sub Runtime_Summary_ContributorUrl_TextChanged(sender As Object, e As EventArgs) Handles Runtime_Summary_ContributorUrl.TextChanged
        If Not IsNothing(Temp_Runtime) Then
            Temp_Runtime.ContributorUri = Runtime_Summary_ContributorUrl.Text
        End If
        Property_Runtime.RefreshPropertyValues()
    End Sub
#End Region
#End Region
#Region "|ON | |06.03| <Runtime> [AttributeList]{3}"
#Region "|ON | |06.03.00| <Runtime> <AttributeList> [DefaultValue]"
    Private Sub Runtime_AttributeList_DefaultValue_TextChanged(sender As Object, e As EventArgs) Handles Runtime_AttributeList_DefaultValue.TextChanged
        If Not IsNothing(Temp_Runtime) Then
            Temp_Runtime.DefaultValue = Runtime_AttributeList_DefaultValue.Text
        End If
        Property_Runtime.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |06.03.01| <Runtime> <AttributeList> [Description]"
    Private Sub Runtime_Description_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Runtime_Description.TextChanged
        If Not IsNothing(Temp_Runtime) Then
            Temp_Runtime.Description = Runtime_Description.Text
        End If
        Property_Runtime.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |06.03.02| <Runtime> <AttributeList> [Category]"
    Private Sub Runtime_Attribute_Category_TextChanged(sender As Object, e As EventArgs) Handles Runtime_Attribute_Category.TextChanged
        If Not IsNothing(Temp_Runtime) Then
            Temp_Runtime.Category = Runtime_Attribute_Category.Text
        End If
        Property_Runtime.RefreshPropertyValues()
    End Sub
#End Region
#End Region
#Region "|ON |1|06.04| <Runtime> [Statement]{4}"
#Region "|ON | |06.04.00| <Runtime> <Statement> [CategoryID]"
    Private Sub Runtime_CategoryID_ValueChanged(sender As Object, e As EventArgs) Handles Runtime_CategoryID.ValueChanged
        If Not IsNothing(Temp_Runtime) Then
            Temp_Runtime.RegionCategory = Runtime_CategoryID.Value
        End If
        Property_Runtime.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |06.04.01| <Runtime> <Statement> [ID]"
    Private Sub Runtime_ID_ValueChanged(sender As Object, e As EventArgs) Handles Runtime_ID.ValueChanged
        If Not IsNothing(Temp_Runtime) Then
            Temp_Runtime.ID = Runtime_ID.Value
        End If
        Property_Runtime.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |06.04.02| <Runtime> <Statement> [Enable]"
    Private Sub Runtime_Enable_ValueChanged(sender As Object, e As EventArgs) Handles Runtime_Enable.ValueChanged
        If Not IsNothing(Temp_Runtime) Then
            Temp_Runtime.Enable = Runtime_Enable.Value
        End If
        Property_Runtime.RefreshPropertyValues()
    End Sub
#End Region
#Region "|OFF|X|06.04.03| <Runtime> <Statement> [Parent]"
    Private Sub Runtime_Parent_TextChanged(sender As Object, e As EventArgs) Handles Runtime_Parent.TextChanged

    End Sub
#End Region
#End Region
#End Region
End Class
