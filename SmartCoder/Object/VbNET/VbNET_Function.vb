Imports System.Windows.Forms
Imports DevComponents.DotNetBar.Controls

Public Class VbNET_Function


#Region "Runtime"
    Public Temp_Function As New VbNET.Function
    Private _ActiveParent As Object
    Public Property ActiveParent() As Object
        Get
            Return _ActiveParent
        End Get
        Set(ByVal value As Object)
            If Not IsNothing(value) Then
                If IsNothing(Temp_Function) Then
                    Temp_Function = New VbNET.Function
                End If

                If TypeOf value Is VbNET.Class Then
                    Function_Parent.Text = value.Name
                    Temp_Function.ParentClass = value
                    Dim T As VbNET.Class
                    T = value
                    BS_Function.DataSource = T.Function
                    Bind_Function.BindingSource = BS_Function
                ElseIf TypeOf value Is VbNET.Structure Then
                    Function_Parent.Text = value.Name
                    Temp_Function.ParentStructure = value
                    Dim T As VbNET.Structure
                    T = value
                    BS_Function.DataSource = T.Function
                    Bind_Function.BindingSource = BS_Function
                ElseIf TypeOf value Is VbNET.Module Then
                    Function_Parent.Text = value.name
                    Temp_Function.ParentModule = value
                    Dim T As VbNET.Module
                    T = value
                    BS_Function.DataSource = T.Function
                    Bind_Function.BindingSource = BS_Function
                End If
            End If
            _ActiveParent = value
        End Set
    End Property
#End Region
    Private Sub Btn_Refresh_Click(sender As Object, e As EventArgs) Handles Btn_Refresh.Click
        RefreshParents(Function_Parent)
    End Sub
    Public Sub Initializor()
        If IsNothing(VirtualClass) Then
            VirtualClass = New VbNET.Class("VirtualClass")
        End If
        RefreshParents(Function_Parent)

        Function_Parent.SelectedIndex = 0
    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Initializor()
    End Sub
    Public Sub OpenStatement(ByVal Statement As VbNET.Function)

        ' This call is required by the designer.
        'InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Initializor()
        Temp_Function = Statement
        Read_Function(Statement)
    End Sub
    Public Sub Read_Function(ByRef Statement As VbNET.Function)
        If Not IsNothing(Statement) Then
            With Statement

                Function_AccessModifier.Text = VbNET.AccessModifiers_ToString(.AccessModifier)
                '  Function_AttributeList_Browsable.Value = .Browsable
                Function_Attribute_Category.Text = .Category
                ' Function_Attribute_DefaultValue.Text = .DefaultValue
                Function_Attribute_Deserializable.Value = .Deserializable
                Function_Attribute_Editor.Text = .Editor
                Function_Attribute_NonSerialized.Value = .NonSerialized
                Function_Attribute_RelatedImageList.Text = .RelatedImageList
                Function_Attribute_Serializable.Value = .Serializable
                Function_Attribute_XmlIgnore.Value = .XmlIgnore
                Function_Attribute_XmlInclude.Value = .XmlInclude
                Function_Attribute_XmlRoot.Text = .XmlRoot
                Function_CategoryID.Value = .RegionCategory
                'Function_Default.Value = .Default
                Function_Description.Text = .Description
                Function_Enable.Value = .Enable
                'Function_GetStatement.Text = .GetStatement
                Function_ID.Value = .ID
                Function_Name.Text = .Name
                Read_Parameters(Function_ParameterList, .ParameterList)
                'Read_Members(Function_Members, .Members)
                If Not IsNothing(.ParentClass) Then
                    Function_Parent.Text = .ParentClass.ClassName
                ElseIf Not IsNothing(.ParentModule) Then
                    Function_Parent.Text = .ParentModule.Name
                ElseIf Not IsNothing(.ParentStructure) Then
                    Function_Parent.Text = .ParentStructure.Name
                Else
                    Function_Parent.Text = VirtualClass.ClassName
                End If
                Function_Print_C.Text = .C
                Function_Print_F.Text = .F
                Function_Print_JS.Text = .JavaScript
                Function_Print_Python.Text = .Python
                Function_Print_VB.Text = .VB
                Property_Function.SelectedObject = Statement
                'Function_PropertyModifier.Text = VbNET.PropertyModifiers_ToString(.PropertyModifier)
                'Function_ReadOnly.Value = .ReadOnly
                'Function_Required.Value = .Required
                Function_ReturnType.Text = .ReturnType
                Function_Statement.Text = .Statement
                Function_Shadows.Value = .Shadows
                Function_Shared.Value = .Shared
                Function_Summary_AuthorEmail.Text = .AuthorEmail
                Function_Summary_AuthorName.Text = .AuthorName
                Function_Summary_AuthorUrl.Text = .AuthorUri
                Function_Summary_ContributorEmail.Text = .ContributorEmail
                Function_Summary_ContributorName.Text = .ContributorName
                Function_Summary_ContributorUrl.Text = .ContributorUri
                Function_Summary_Example.Text = .Example
                Function_Summary_Note.Text = .Note
                Function_Summary_Remark.Text = .Remarks
                Function_Summary_Rights.Text = .Rights
                Function_Summary_Rules.Text = .Rules
                Function_Summary_Syntax.Text = .Syntax
                Function_Summary_Usage.Text = .Usage
                'Function_Variable_AccessModifier.Text = VbNET.AccessModifiers_ToString(.Variable_AccessModifier)
                'Function_Variable_Name.Text = .Variable_Name
                'Function_Variable_ReturnType.Text = .Variable_ReturnType
                'Function_WriteOnly.Value = .WriteOnly

            End With

        End If
    End Sub
    Public Sub Read_Parameters(ByRef List As ListViewEx, ByRef Param As List(Of VbNET.InnerStatement.ParameterList_Statement))
        If Not IsNothing(List) Then
            If Not IsNothing(Param) Then
                List.Items.Clear()
                If Param.Count - 1 >= 0 Then
                    For i = 0 To Param.Count - 1
                        Dim P As VbNET.InnerStatement.ParameterList_Statement = Param(i)
                        Dim Item As New ListViewItem(i)
                        Item.SubItems.Add(P.Modifier)
                        Item.SubItems.Add(P.ParameterName)
                        Item.SubItems.Add(P.ParameterType)
                        Item.SubItems.Add(P.Definition)
                        Item.SubItems.Add(P.DefaultValue)
                        List.Items.Add(Item)
                    Next
                End If
            End If
        End If


    End Sub
#Region "|ON |3|05| [Function]{74}"
#Region "|ON | |05.00| <Function> [FileManager]{5}"
#Region "|ON | |05.00.00| <Function> <FileManager> [Add]"
    Private Sub Function_Btn_Add_Click(sender As Object, e As EventArgs) Handles Function_Btn_Add.Click
        If Not IsNothing(VirtualClass) Then
            If IsNothing(Temp_Function) Then
                Temp_Function = New VbNET.Function(Function_Name.Text, Function_Statement.Text,
                                       Function_Description.Text,
                                       Function_ID.Value,
                                       VbNET.String_ToAccessModifiers(Function_AccessModifier.Text),
                                       VbNET.String_ToProcedureModifiers(Function_ProcedureModifier.Text),
                                       Function_Shadows.Value,
                                       Function_Shared.Value,
                                       Function_Async.Value, Function_Partial.Value, Function_ReturnType.Text,
                                       IIf(Function_Handle.Text = "Handle", Function_HandleValue.Text, ""),
                                       IIf(Function_Handle.Text = "Implements", Function_HandleValue.Text, ""),
                                       New VbNET.Attributelist(Function_Attribute_Category.Text,
                                                               Function_Description.Text,
                                                               ,
                                                               False, Function_Attribute_Deserializable.Value,
                                                               Function_Attribute_Editor.Text,
                                                               Function_Attribute_Serializable.Value,
                                                               Function_Attribute_NonSerialized.Value,
                                                               Function_Attribute_RelatedImageList.Text,
                                                               Function_Attribute_XmlRoot.Text,
                                                               Function_Attribute_XmlIgnore.Value,
                                                               Function_Attribute_XmlInclude.Value,,),
                                       Function_Summary_AuthorEmail.Text,
                                       Function_Summary_AuthorName.Text,
                                       Function_Summary_AuthorUrl.Text,
                                       True,
                                       Function_Attribute_Category.Text,
                                       Function_Summary_ContributorEmail.Text,
                                       Function_Summary_ContributorName.Text,
                                       Function_Summary_ContributorUrl.Text,
                                       Function_Attribute_Custom.Text,
                                       ,, Function_Summary_Example.Text, Function_Summary_Note.Text,
                                        , Function_CategoryID.Value, Function_Enable.Value)
            End If
            Dim D = Function_Parent.SelectedItem.tag
            If TypeOf D Is VbNET.Class Then
                Temp_Function.ParentClass = D
                Temp_Function.ParentName = D.name
                Temp_Function.ParentClass.Add_Function(Temp_Function)
                BS_Function.DataSource = Temp_Function.ParentClass.Function
                Bind_Function.BindingSource = BS_Function
                Bind_Function.Visible = True
            ElseIf TypeOf D Is VbNET.Module Then
                Temp_Function.ParentModule = D
                Temp_Function.ParentName = D.name
                Temp_Function.ParentModule.Add_Function(Temp_Function)
                BS_Function.DataSource = Temp_Function.ParentModule.Function
                Bind_Function.BindingSource = BS_Function
                Bind_Function.Visible = True
            ElseIf TypeOf D Is VbNET.Structure Then
                Temp_Function.ParentStructure = D
                Temp_Function.ParentName = D.name
                Temp_Function.ParentStructure.Add_Function(Temp_Function)
                BS_Function.DataSource = Temp_Function.ParentStructure.Function
                Bind_Function.BindingSource = BS_Function
                Bind_Function.Visible = True
            End If
            ' Quantity_Function.Value += 1
            Function_ID.Value += 1
            'RefreshReturnType()
        End If
        Property_Function.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |05.00.01| <Function> <FileManager> [Preview]"
    Private Sub Function_Btn_Preview_Click(sender As Object, e As EventArgs) Handles Function_Btn_Preview.Click
        Temp_Function = New VbNET.Function(Function_Name.Text, Function_Statement.Text,
                                       Function_Description.Text,
                                       Function_ID.Value,
                                       VbNET.String_ToAccessModifiers(Function_AccessModifier.Text),
                                       VbNET.String_ToProcedureModifiers(Function_ProcedureModifier.Text),
                                       Function_Shadows.Value,
                                       Function_Shared.Value,
                                       Function_Async.Value, Function_Partial.Value, Function_ReturnType.Text,
                                       IIf(Function_Handle.Text = "Handle", Function_HandleValue.Text, ""),
                                       IIf(Function_Handle.Text = "Implements", Function_HandleValue.Text, ""),
                                       New VbNET.Attributelist(Function_Attribute_Category.Text,
                                                               Function_Description.Text,
                                                               ,
                                                               False, Function_Attribute_Deserializable.Value,
                                                               Function_Attribute_Editor.Text,
                                                               Function_Attribute_Serializable.Value,
                                                               Function_Attribute_NonSerialized.Value,
                                                               Function_Attribute_RelatedImageList.Text,
                                                               Function_Attribute_XmlRoot.Text,
                                                               Function_Attribute_XmlIgnore.Value,
                                                               Function_Attribute_XmlInclude.Value,,),
                                       Function_Summary_AuthorEmail.Text,
                                       Function_Summary_AuthorName.Text,
                                       Function_Summary_AuthorUrl.Text,
                                       True,
                                       Function_Attribute_Category.Text,
                                       Function_Summary_ContributorEmail.Text,
                                       Function_Summary_ContributorName.Text,
                                       Function_Summary_ContributorUrl.Text,
                                       Function_Attribute_Custom.Text,
                                       ,, Function_Summary_Example.Text, Function_Summary_Note.Text,
                                        , Function_CategoryID.Value, Function_Enable.Value)
        Temp_Function.PrintStatement(Function_Print_VB,
                                                   Function_Print_C,
                                                   Function_Print_F,
                                                   Function_Print_Python,
                                                   Function_Print_JS,
                                                   Function_Enable.Value)
        Property_Function.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |05.00.02| <Function> <FileManager> [New]"
    Private Sub Function_Btn_New_Click(sender As Object, e As EventArgs) Handles Function_Btn_New.Click
        Temp_Function = New VbNET.Function
        Function_AccessModifier.Text = "Public"
        Function_Async.Value = False
        Function_CategoryID.Value = 0
        Function_Description.Text = ""
        Function_Enable.Value = True
        Function_Handle.Text = "(None)"
        Function_HandleValue.Text = ""
        Function_Name.Text = ""
        Function_ParameterList.Items.Clear()
        Function_Partial.Value = False
        Function_ProcedureModifier.Text = ""
        Function_ReturnType.Text = "String"
        Function_Shadows.Value = False
        Function_Shared.Value = False
        Function_Statement.Text = ""
        Function_Summary_AuthorEmail.Text = My.Settings.AuthorEmail
        Function_Summary_AuthorName.Text = My.Settings.AuthorName
        Function_Summary_AuthorUrl.Text = My.Settings.AuthorUrl
        Function_Summary_ContributorEmail.Text = ""
        Function_Summary_ContributorName.Text = ""
        Function_Summary_ContributorUrl.Text = ""
        Function_Summary_Example.Text = ""
        Function_Summary_Note.Text = ""
        Function_Summary_Remark.Text = ""
        Function_Summary_Rights.Text = My.Settings.SummaryRights
        Function_Summary_Rules.Text = ""
        Function_Summary_Syntax.Text = ""
        Function_Summary_Usage.Text = ""
        Property_Function.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |05.00.03| <Function> <FileManager> [Open]"
    Private Sub Function_Btn_Open_Click(sender As Object, e As EventArgs) Handles Function_Btn_Open.Click
        Dim Ofd As New OpenFileDialog
        With Ofd
            .Filter = "Function Statement (*.Function)|*.Function|All Files (*.*)|*.*"
            If .ShowDialog = DialogResult.OK Then
                Try
                    Temp_Function.Open(.FileName)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End With
        Property_Function.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |05.00.04| <Function> <FileManager> [Save]"
    Private Sub Function_Btn_Save_Click(sender As Object, e As EventArgs) Handles Function_Btn_Save.Click
        If Not IsNothing(Temp_Function) Then
            If Temp_Function.Name <> "" Then
                Dim F = Temp_Function.Save().Output
                Temp_Function.XmlFile = F.Target
            End If
        End If
        Property_Function.RefreshPropertyValues()
    End Sub
#End Region
#End Region
#Region "|ON |1|05.01| <Function> [Constructor]{41}"
#Region "|ON |1|05.01.00| <Function> <Constructor> [Statement]{13}"
#Region "|ON | |05.01.00.00| <Function> <Constructor> <Statement> [Enable]"
    Private Sub Function_Enable_ValueChanged(sender As Object, e As EventArgs) Handles Function_Enable.ValueChanged
        If Not IsNothing(Temp_Function) Then
            Temp_Function.Enable = Function_Enable.Value
        End If
        Property_Function.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |05.01.00.01| <Function> <Constructor> <Statement> [ID]"
    Private Sub Function_ID_ValueChanged(sender As Object, e As EventArgs) Handles Function_ID.ValueChanged
        If Not IsNothing(Temp_Function) Then
            Temp_Function.ID = Function_ID.Value
        End If
        Property_Function.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |05.01.00.02| <Function> <Constructor> <Statement> [CategoryID]"
    Private Sub Function_CategoryID_ValueChanged(sender As Object, e As EventArgs) Handles Function_CategoryID.ValueChanged
        If Not IsNothing(Temp_Function) Then
            Temp_Function.RegionCategory = Function_CategoryID.Value
        End If
        Property_Function.RefreshPropertyValues()
    End Sub
#End Region
#Region "|OFF|X|05.01.00.03| <Function> <Constructor> <Statement> [Parent]"

#End Region
#Region "|ON | |05.01.00.04| <Function> <Constructor> <Statement> [Statement]"
    Private Sub Function_Statement_TextChanging(sender As Object, e As FastColoredTextBoxNS.TextChangingEventArgs) Handles Function_Statement.TextChanging
        If Not IsNothing(Temp_Function) Then
            Temp_Function.Statement = Function_Statement.Text
        End If
        Property_Function.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |05.01.00.05| <Function> <Constructor> <Statement> [Shadows]"
    Private Sub Function_Shadows_ValueChanged(sender As Object, e As EventArgs) Handles Function_Shadows.ValueChanged
        If Not IsNothing(Temp_Function) Then
            Temp_Function.Shadows = Function_Shadows.Value
        End If
        Property_Function.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |05.01.00.06| <Function> <Constructor> <Statement> [Shared]"
    Private Sub Function_Shared_ValueChanged(sender As Object, e As EventArgs) Handles Function_Shared.ValueChanged
        If Not IsNothing(Temp_Function) Then
            Temp_Function.Shared = Function_Shared.Value
        End If
        Property_Function.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |05.01.00.07| <Function> <Constructor> <Statement> [Async]"
    Private Sub Function_Async_ValueChanged(sender As Object, e As EventArgs) Handles Function_Async.ValueChanged
        If Not IsNothing(Temp_Function) Then
            Temp_Function.Async = Function_Async.Value
        End If
        Property_Function.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |05.01.00.08| <Function> <Constructor> <Statement> [Partial]"
    Private Sub Function_Partial_ValueChanged(sender As Object, e As EventArgs) Handles Function_Partial.ValueChanged
        If Not IsNothing(Temp_Function) Then
            Temp_Function.Partial = Function_Partial.Value
        End If
        Property_Function.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |05.01.00.09| <Function> <Constructor> <Statement> [AccessModifier]"
    Private Sub Function_AccessModifier_TextChanged(sender As Object, e As EventArgs) Handles Function_AccessModifier.TextChanged
        If Not IsNothing(Temp_Function) Then
            Temp_Function.AccessModifier = VbNET.String_ToAccessModifiers(Function_AccessModifier.Text)
        End If
        Property_Function.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |05.01.00.10| <Function> <Constructor> <Statement> [ProcedureModifier]"
    Private Sub Function_ProcedureModifier_TextChanged(sender As Object, e As EventArgs) Handles Function_ProcedureModifier.TextChanged
        If Not IsNothing(Temp_Function) Then
            Temp_Function.ProcedureModifier = VbNET.String_ToProcedureModifiers(Function_ProcedureModifier.Text)
        End If
        Property_Function.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |05.01.00.11| <Function> <Constructor> <Statement> [Name]"
    Private Sub Function_Name_TextChanged(sender As Object, e As EventArgs) Handles Function_Name.TextChanged
        If Not IsNothing(Temp_Function) Then
            Temp_Function.Name = Function_Name.Text
        End If
        Property_Function.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |05.01.00.12| <Function> <Constructor> <Statement> [ReturnType]"
    Private Sub Function_ReturnType_TextChanged(sender As Object, e As EventArgs) Handles Function_ReturnType.TextChanged
        If Function_ReturnType.Text <> "" Then
            If IsNothing(Temp_Function) Then
                Temp_Function = New VbNET.Function
                Temp_Function.Name = Function_Name.Text
                Temp_Function.ReturnType = Function_ReturnType.Text
            Else
                Temp_Function.ReturnType = Function_ReturnType.Text
            End If
            Function_Description.Text = "The " & Function_Name.Text & " as " & Function_ReturnType.Text & "."
        End If
        Property_Function.SelectedObject = Temp_Function
    End Sub
#End Region
#Region "|ON | |05.01.00.13| <Function> <Constructor> <Statement> [HandleValue]"
    Private Sub Function_HandleValue_TextChanged(sender As Object, e As EventArgs) Handles Function_HandleValue.TextChanged
        If Not IsNothing(Temp_Function) Then
            If Function_Handle.Text <> "(None)" And Function_HandleValue.Text <> "" Then
                Temp_Function.Handle = Function_Handle.Text & " " & Function_HandleValue.Text
            End If
        End If
        Property_Function.RefreshPropertyValues()
    End Sub
#End Region
#End Region
#End Region
#Region "|ON |2|05.02| <Function> [Attribute]{13}"
#Region "|ON | |05.02.00| <Function> <Attribute> [Category]"
    Private Sub Function_Attribute_Category_Leave(sender As Object, e As EventArgs) Handles Function_Attribute_Category.Leave
        AddCategory(Function_Attribute_Category.Text)
        ' RefreshCategory()
        Function_CategoryID.Value = RetriveCategoryID_FromString(Function_Attribute_Category.Text)
        Property_Function.RefreshPropertyValues()
    End Sub
    Private Sub Function_Attribute_Category_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Function_Attribute_Category.SelectedIndexChanged
        If Function_Attribute_Category.Text <> "" Then
            If Not IsNothing(Temp_Function) Then
                Temp_Function.Category = Function_Attribute_Category.Text
            End If
        End If
        Property_Function.RefreshPropertyValues()
    End Sub
#End Region
#Region "|OFF|X|05.02.01| <Function> <Attribute> [DefaultValue]"

#End Region
#Region "|OFF|X|05.02.02| <Function> <Attribute> [Browsable]"

#End Region
#Region "|ON | |05.02.03| <Function> <Attribute> [Definition]"
    Private Sub Function_Description_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Function_Description.TextChanged
        If Not IsNothing(Temp_Function) Then
            Temp_Function.Description = Function_Description.Text
        End If
        Property_Function.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |05.02.04| <Function> <Attribute> [Editor]"
    Private Sub Function_Attribute_Editor_TextChanged(sender As Object, e As EventArgs) Handles Function_Attribute_Editor.TextChanged
        If Not IsNothing(Temp_Function) Then
            Temp_Function.Editor = Function_Attribute_Editor.Text
        End If
        Property_Function.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |05.02.05| <Function> <Attribute> [RelatedImageList]"
    Private Sub Function_Attribute_RelatedImageList_TextChanged(sender As Object, e As EventArgs) Handles Function_Attribute_RelatedImageList.TextChanged
        If Not IsNothing(Temp_Function) Then
            Temp_Function.RelatedImageList = Function_Attribute_RelatedImageList.Text
        End If
        Property_Function.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |05.02.06| <Function> <Attribute> [Custom]"
    Private Sub Function_Attribute_Customs_TextChanged(sender As Object, e As EventArgs) Handles Function_Attribute_Custom.TextChanged
        If Not IsNothing(Temp_Function) Then
            Temp_Function.CustomProperty = Function_Attribute_Custom.Text
        End If
        Property_Function.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |05.02.07| <Function> <Attribute> [Deserializable]"
    Private Sub Function_Attribute_Deserializable_ValueChanged(sender As Object, e As EventArgs) Handles Function_Attribute_Deserializable.ValueChanged
        If Not IsNothing(Temp_Function) Then
            Temp_Function.Deserializable = Function_Attribute_Deserializable.Value
        End If
        Property_Function.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |05.02.08| <Function> <Attribute> [NonSerialized]"
    Private Sub Function_Attribute_NonSerialized_ValueChanged(sender As Object, e As EventArgs) Handles Function_Attribute_NonSerialized.ValueChanged
        If Not IsNothing(Temp_Function) Then
            Temp_Function.NonSerialized = Function_Attribute_NonSerialized.Value
        End If
        Property_Function.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |05.02.09| <Function> <Attribute> [Serializable]"
    Private Sub Function_Attribute_Serializable_ValueChanged(sender As Object, e As EventArgs) Handles Function_Attribute_Serializable.ValueChanged
        If Not IsNothing(Temp_Function) Then
            Temp_Function.Serializable = Function_Attribute_Serializable.Value
        End If
        Property_Function.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |05.02.10| <Function> <Attribute> [XmlRoot]"
    Private Sub Function_Attribute_XmlRoot_TextChanged(sender As Object, e As EventArgs) Handles Function_Attribute_XmlRoot.TextChanged
        If Not IsNothing(Temp_Function) Then
            Temp_Function.XmlRoot = Function_Attribute_XmlRoot.Text
        End If
        Property_Function.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |05.02.11| <Function> <Attribute> [XmlIgnore]"
    Private Sub Function_Attribute_XmlIgnore_ValueChanged(sender As Object, e As EventArgs) Handles Function_Attribute_XmlIgnore.ValueChanged
        If Not IsNothing(Temp_Function) Then
            Temp_Function.XmlIgnore = Function_Attribute_XmlIgnore.Value
        End If
        Property_Function.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |05.02.12| <Function> <Attribute> [XmlInclude]"
    Private Sub Function_Attribute_XmlInclude_ValueChanged(sender As Object, e As EventArgs) Handles Function_Attribute_XmlInclude.ValueChanged
        If Not IsNothing(Temp_Function) Then
            Temp_Function.XmlInclude = Function_Attribute_XmlInclude.Value
        End If
        Property_Function.RefreshPropertyValues()
    End Sub
#End Region
#End Region
#Region "|ON | |05.03| <Function> [Summary]{13}"
#Region "|ON | |05.03.00| <Function> <Summary> [Usage]"
    Private Sub Function_Summary_Usage_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Function_Summary_Usage.TextChanged
        If Not IsNothing(Temp_Function) Then
            Temp_Function.Usage = Function_Summary_Usage.Text
        End If
        Property_Function.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |05.03.01| <Function> <Summary> [Remark]"
    Private Sub Function_Summary_Remark_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Function_Summary_Remark.TextChanged
        If Not IsNothing(Temp_Function) Then
            Temp_Function.Remarks = Function_Summary_Remark.Text
        End If
        Property_Function.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |05.03.02| <Function> <Summary> [Example]"
    Private Sub Function_Summary_Example_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Function_Summary_Example.TextChanged
        If Not IsNothing(Temp_Function) Then
            Temp_Function.Example = Function_Summary_Example.Text
        End If
        Property_Function.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |05.03.03| <Function> <Summary> [Note]"
    Private Sub Function_Summary_Note_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Function_Summary_Note.TextChanged
        If Not IsNothing(Temp_Function) Then
            Temp_Function.Note = Function_Summary_Note.Text
        End If
        Property_Function.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |05.03.05| <Function> <Summary> [Rules]"
    Private Sub Function_Summary_Rules_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Function_Summary_Rules.TextChanged
        If Not IsNothing(Temp_Function) Then
            Temp_Function.Rules = Function_Summary_Rules.Text
        End If
        Property_Function.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |05.03.05| <Function> <Summary> [Syntax]"
    Private Sub Function_Summary_Syntax_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Function_Summary_Syntax.TextChanged
        If Not IsNothing(Temp_Function) Then
            Temp_Function.Syntax = Function_Summary_Syntax.Text
        End If
        Property_Function.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |05.03.06| <Function> <Summary> [Rights]"
    Private Sub Function_Summary_Rights_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Function_Summary_Rights.TextChanged
        If Not IsNothing(Temp_Function) Then
            Temp_Function.Rights = Function_Summary_Rights.Text
        End If
        Property_Function.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |05.03.07| <Function> <Summary> [AuthorName]"
    Private Sub Function_Summary_AuthorName_TextChanged(sender As Object, e As EventArgs) Handles Function_Summary_AuthorName.TextChanged
        If Not IsNothing(Temp_Function) Then
            Temp_Function.AuthorName = Function_Summary_AuthorName.Text
        End If

        Property_Function.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |05.03.08| <Function> <Summary> [AuthorEmail]"
    Private Sub Function_Summary_AuthorEmail_TextChanged(sender As Object, e As EventArgs) Handles Function_Summary_AuthorEmail.TextChanged
        If Not IsNothing(Temp_Function) Then
            Temp_Function.AuthorEmail = Function_Summary_AuthorEmail.Text
        End If
        Property_Function.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |05.03.09| <Function> <Summary> [AuthorUrl]"
    Private Sub Function_Summary_AuthorUrl_TextChanged(sender As Object, e As EventArgs) Handles Function_Summary_AuthorUrl.TextChanged
        If Not IsNothing(Temp_Function) Then
            Temp_Function.AuthorUri = Function_Summary_AuthorUrl.Text
        End If
        Property_Function.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |05.03.10| <Function> <Summary> [ContributorName]"
    Private Sub Function_Summary_ContributorName_TextChanged(sender As Object, e As EventArgs) Handles Function_Summary_ContributorName.TextChanged
        If Not IsNothing(Temp_Function) Then
            Temp_Function.ContributorName = Function_Summary_ContributorName.Text
        End If
        Property_Function.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |05.03.11| <Function> <Summary> [ContributorEmail]"
    Private Sub Function_Summary_ContributorEmail_TextChanged(sender As Object, e As EventArgs) Handles Function_Summary_ContributorEmail.TextChanged
        If Not IsNothing(Temp_Function) Then
            Temp_Function.ContributorEmail = Function_Summary_ContributorEmail.Text
        End If
        Property_Function.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |05.03.12| <Function> <Summary> [ContributorUrl]"
    Private Sub Function_Summary_ContributorUrl_TextChanged(sender As Object, e As EventArgs) Handles Function_Summary_ContributorUrl.TextChanged
        If Not IsNothing(Temp_Function) Then
            Temp_Function.ContributorUri = Function_Summary_ContributorUrl.Text
        End If
        Property_Function.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |05.03.13| <Function> <Summary> [Custom]"
    Private Sub Function_Attribute_Custom_TextChanged(sender As Object, e As EventArgs) Handles Function_Attribute_Custom.TextChanged
        If Not IsNothing(Temp_Function) Then
            Temp_Function.CustomProperty = Function_Attribute_Custom.Text
        End If
        Property_Function.RefreshPropertyValues()
    End Sub
#End Region
#End Region
#Region "|ON | |05.05| <Function> [ParameterList]{2}"
#Region "|ON | |05.05.00| <Function> <ParameterList> [Add]"
    Private Sub Function_Add_InputParam_Click(sender As Object, e As EventArgs) Handles Function_Add_InputParam.Click
        If Not IsNothing(Temp_Function) Then
            Dim P As VbNET.InnerStatement.ParameterList_Statement = Nothing
            P = Temp_Function.AddParameter(Function_Param_Name.Text, Function_Param_ReturnType.Text, Function_Param_DefaultValue.Text, Function_Param_AccessModifier.Text, Function_Param_Summary.Text)
            If Not IsNothing(P) Then
                Dim Lt As New ListViewItem(Function_ParameterList.Items.Count)
                Lt.SubItems.Add(P.Modifier)
                Lt.SubItems.Add(P.ParameterName)
                Lt.SubItems.Add(P.ParameterType)
                Lt.SubItems.Add(P.Definition)
                Lt.SubItems.Add(P.DefaultValue)
                Lt.ToolTipText = P.Definition
                Lt.Tag = P
                Function_ParameterList.Items.Add(Lt)
            End If

        End If
        Property_Function.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |05.05.01| <Function> <ParameterList> [Remove]"
    Private Sub Function_Remove_InputParam_Click(sender As Object, e As EventArgs) Handles Function_Remove_InputParam.Click
        If Not IsNothing(Temp_Function) Then
            Dim P As VbNET.InnerStatement.ParameterList_Statement = Nothing
            P = Temp_Function.RemoveParameter(Function_Param_Name.Text)
            If Not IsNothing(P) Then
                Dim Lt As New ListViewItem(Function_ParameterList.Items.Count)
                Lt.SubItems.Add(P.Modifier)
                Lt.SubItems.Add(P.ParameterName)
                Lt.SubItems.Add(P.ParameterType)
                Lt.SubItems.Add(P.Definition)
                Lt.SubItems.Add(P.DefaultValue)
                Lt.ToolTipText = P.Definition
                Lt.Tag = P
                Function_ParameterList.Items.Remove(Lt)
            End If

        End If
        Property_Function.RefreshPropertyValues()
    End Sub
#End Region
#End Region
#End Region
End Class
