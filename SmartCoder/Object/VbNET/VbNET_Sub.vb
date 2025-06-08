Imports System.Windows.Forms
Imports DevComponents.DotNetBar.Controls

Public Class VbNET_Sub


#Region "Runtime"
    Public Temp_Sub As New VbNET.Sub
    Private _ActiveParent As Object
    Public Property ActiveParent() As Object
        Get
            Return _ActiveParent
        End Get
        Set(ByVal value As Object)
            If Not IsNothing(value) Then
                If IsNothing(Temp_Sub) Then
                    Temp_Sub = New VbNET.Sub
                End If

                If TypeOf value Is VbNET.Class Then
                    Sub_Parent.Text = value.Name
                    Temp_Sub.ParentClass = value
                    Dim T As VbNET.Class
                    T = value
                    BS_Sub.DataSource = T.Sub
                    Bind_Sub.BindingSource = BS_Sub
                ElseIf TypeOf value Is VbNET.Structure Then
                    Sub_Parent.Text = value.Name
                    Temp_Sub.ParentStructure = value
                    Dim T As VbNET.Structure
                    T = value
                    BS_Sub.DataSource = T.Sub
                    Bind_Sub.BindingSource = BS_Sub
                ElseIf TypeOf value Is VbNET.Module Then
                    Sub_Parent.Text = value.name
                    Temp_Sub.ParentModule = value
                    Dim T As VbNET.Module
                    T = value
                    BS_Sub.DataSource = T.Sub
                    Bind_Sub.BindingSource = BS_Sub
                End If
            End If
            _ActiveParent = value
        End Set
    End Property
#End Region
    Private Sub Btn_Refresh_Click(sender As Object, e As EventArgs) Handles Btn_Refresh.Click
        RefreshParents(Sub_Parent)
    End Sub
    Public Sub Initializor()
        If IsNothing(VirtualClass) Then
            VirtualClass = New VbNET.Class("VirtualClass")
        End If
        RefreshParents(Sub_Parent)
        Sub_Parent.SelectedIndex = 0
    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Initializor()
    End Sub
    Public Sub OpenStatement(ByVal Statement As VbNET.Sub)

        ' This call is required by the designer.
        ' InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Initializor()
        Temp_Sub = Statement
        Read_Sub(Statement)
    End Sub
#Region "|ON |4|04| [Sub]{46}"
#Region "|ON | |04.00| <Sub> [FileManager]{5}"
#Region "|ON | |04.00.00| <Sub> <FileManager> [Add]"
    Private Sub Sub_Btn_Add_Click(sender As Object, e As EventArgs) Handles Sub_Btn_Add.Click
        If Not IsNothing(VirtualClass) Then
            If IsNothing(Temp_Sub) Then
                Temp_Sub = New VbNET.Sub(Sub_Name.Text, Sub_Statement.Text,
                                       Sub_Description.Text,
                                       Sub_ID.Value,
                                       VbNET.String_ToAccessModifiers(Sub_AccessModifier.Text),
                                       VbNET.String_ToProcedureModifiers(Sub_ProcedureModifier.Text),
                                       Sub_Shadows.Value,
                                       Sub_Shared.Value,
                                       Sub_Async.Value, Sub_Partial.Value,
                                       New VbNET.Attributelist(Sub_Attribute_Category.Text,
                                                               Sub_Description.Text,
                                                               ,
                                                               False, Sub_Attribute_Deserializable.Value,
                                                               Sub_Attribute_Editor.Text,
                                                               Sub_Attribute_Serializable.Value,
                                                               Sub_Attribute_NonSerialized.Value,
                                                               Sub_Attribute_RelatedImageList.Text,
                                                               Sub_Attribute_XmlRoot.Text,
                                                               Sub_Attribute_XmlIgnore.Value,
                                                               Sub_Attribute_XmlInclude.Value),
                                       Sub_Summary_AuthorEmail.Text,
                                       Sub_Summary_AuthorName.Text,
                                       Sub_Summary_AuthorUrl.Text,
                                       True,
                                       Sub_Attribute_Category.Text,
                                       Sub_Summary_ContributorEmail.Text,
                                       Sub_Summary_ContributorName.Text,
                                       Sub_Summary_ContributorUrl.Text,
                                       Sub_Attribute_Custom.Text,
                                       ,, Sub_Summary_Example.Text, Sub_Summary_Note.Text,
                                        , Sub_CategoryID.Value, Sub_Enable.Value)
            End If
            Dim D = Sub_Parent.SelectedItem.tag
            If TypeOf D Is VbNET.Class Then
                Temp_Sub.ParentClass = D
                Temp_Sub.ParentName = D.name
                Temp_Sub.ParentClass.Add_Sub(Temp_Sub)
                BS_Sub.DataSource = Temp_Sub.ParentClass.Sub
                Bind_Sub.BindingSource = BS_Sub
                Bind_Sub.Visible = True
            ElseIf TypeOf D Is VbNET.Module Then
                Temp_Sub.ParentModule = D
                Temp_Sub.ParentName = D.name
                Temp_Sub.ParentModule.Add_Sub(Temp_Sub)
                BS_Sub.DataSource = Temp_Sub.ParentModule.Sub
                Bind_Sub.BindingSource = BS_Sub
                Bind_Sub.Visible = True
            ElseIf TypeOf D Is VbNET.Structure Then
                Temp_Sub.ParentStructure = D
                Temp_Sub.ParentName = D.name
                Temp_Sub.ParentStructure.Add_Sub(Temp_Sub)
                BS_Sub.DataSource = Temp_Sub.ParentStructure.Sub
                Bind_Sub.BindingSource = BS_Sub
                Bind_Sub.Visible = True
            End If
            Sub_Btn_New.RaiseClick()
            '    End Sub
            '  Quantity_Sub.Value += 1
            Sub_ID.Value += 1
            ' RefreshReturnType()
        End If
        Property_Sub.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |04.00.01| <Sub> <FileManager> [Preview]"
    Private Sub Sub_Btn_Preview_Click(sender As Object, e As EventArgs) Handles Sub_Btn_Preview.Click
        If Not IsNothing(Temp_Sub) Then
            Temp_Sub.PrintStatement(Sub_Print_VB,
                                                   Sub_Print_C,
                                                   Sub_Print_F,
                                                   Sub_Print_Python,
                                                   Sub_Print_JS,
                                                   Sub_Enable.Value)
        End If
        Property_Sub.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |04.00.02| <Sub> <FileManager> [New]"
    Private Sub Sub_Btn_New_Click(sender As Object, e As EventArgs) Handles Sub_Btn_New.Click
        Temp_Sub = New VbNET.Sub
        Sub_AccessModifier.Text = "Public"
        Sub_Async.Value = False
        Sub_Attribute_Category.Text = ""
        Sub_CategoryID.Value = 0
        Sub_Description.Text = ""
        Sub_Enable.Value = True
        Sub_HandleValue.Text = ""
        Sub_Name.Text = ""
        Sub_ParameterList.Items.Clear()
        Sub_Partial.Value = False
        Sub_ProcedureModifier.Text = ""
        Sub_Shadows.Value = False
        Sub_Shared.Value = False
        Sub_Statement.Text = ""
        Sub_Summary_AuthorEmail.Text = My.Settings.AuthorEmail
        Sub_Summary_AuthorName.Text = My.Settings.AuthorName
        Sub_Summary_AuthorUrl.Text = My.Settings.AuthorUrl
        Sub_Summary_ContributorEmail.Text = ""
        Sub_Summary_ContributorName.Text = ""
        Sub_Summary_ContributorUrl.Text = ""
        Sub_Summary_Example.Text = ""
        Sub_Summary_Note.Text = ""
        Sub_Summary_Remark.Text = ""
        Sub_Summary_Rights.Text = ""
        Sub_Summary_Rules.Text = ""
        Sub_Summary_Syntax.Text = ""
        Sub_Summary_Usage.Text = ""
        Property_Sub.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |04.00.03| <Sub> <FileManager> [Open]"
    Private Sub Sub_Btn_Open_Click(sender As Object, e As EventArgs) Handles Sub_Btn_Open.Click
        Dim Ofd As New OpenFileDialog
        With Ofd
            .Filter = "Sub Statement (*.Sub)|*.Sub|All Files (*.*)|*.*"
            If .ShowDialog = DialogResult.OK Then
                Try
                    Temp_Sub.Open(.FileName)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End With
        Property_Sub.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |04.00.04| <Sub> <FileManager> [Save]"
    Private Sub Sub_Btn_Save_Click(sender As Object, e As EventArgs) Handles Sub_Btn_Save.Click
        If Not IsNothing(Temp_Sub) Then
            If Temp_Sub.Name <> "" Then
                Dim F = Temp_Sub.Save().Output
                Temp_Sub.XmlFile = F.Target
            End If
        End If
        Property_Sub.RefreshPropertyValues()
    End Sub
#End Region
#End Region
#Region "|ON |1|04.01| <Sub> [Constructor]{5}"
#Region "|ON |1|04.01.00| <Sub> <Constructor> [Statement]{5}"
#Region "|ON | |04.01.00.00| <Sub> <Constructor> <Statement> [Enable]"
    Private Sub Sub_Enable_ValueChanged(sender As Object, e As EventArgs) Handles Sub_Enable.ValueChanged
        If Not IsNothing(Temp_Sub) Then
            Temp_Sub.Enable = Sub_Enable.Value
        End If
        Property_Sub.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |04.01.00.01| <Sub> <Constructor> <Statement> [ID]"
    Private Sub Sub_ID_ValueChanged(sender As Object, e As EventArgs) Handles Sub_ID.ValueChanged
        If Not IsNothing(Temp_Sub) Then
            Temp_Sub.ID = Sub_ID.Value
        End If
        Property_Sub.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |04.01.00.02| <Sub> <Constructor> <Statement> [CategoryID]"
    Private Sub Sub_CategoryID_ValueChanged(sender As Object, e As EventArgs) Handles Sub_CategoryID.ValueChanged
        If Not IsNothing(Temp_Sub) Then
            Temp_Sub.RegionCategory = Sub_CategoryID.Value
        End If
        Property_Sub.RefreshPropertyValues()
    End Sub
#End Region
#Region "|OFF|X|04.01.00.03| <Sub> <Constructor> <Statement> [Parent]"

#End Region
#Region "|ON | |04.01.00.04| <Sub> <Constructor> <Statement> [Statement]"
    Private Sub Sub_Statement_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Sub_Statement.TextChanged
        If Not IsNothing(Temp_Sub) Then
            Temp_Sub.Statement = Sub_Statement.Text
        End If
        Property_Sub.RefreshPropertyValues()
    End Sub
#End Region
#End Region
#End Region
#Region "|ON | |04.02| <Sub> [Sub]{8}"
#Region "|ON | |04.02.00| <Sub> <Sub> [AccessModifier]"
    Private Sub Sub_AccessModifier_TextChanged(sender As Object, e As EventArgs) Handles Sub_AccessModifier.TextChanged
        If Not IsNothing(Temp_Sub) Then
            Temp_Sub.AccessModifier = VbNET.String_ToAccessModifiers(Sub_AccessModifier.Text)
        End If
        Property_Sub.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |04.02.01| <Sub> <Sub> [ProcedureModifier]"
    Private Sub Sub_ProcedureModifier_TextChanged(sender As Object, e As EventArgs) Handles Sub_ProcedureModifier.TextChanged
        If Not IsNothing(Temp_Sub) Then
            Temp_Sub.ProcedureModifier = VbNET.String_ToProcedureModifiers(Sub_ProcedureModifier.Text)
        End If
        Property_Sub.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |04.02.02| <Sub> <Sub> [Name]"
    Private Sub Sub_Name_TextChanged(sender As Object, e As EventArgs) Handles Sub_Name.TextChanged
        If Sub_Name.Text <> "" Then
            If IsNothing(Temp_Sub) Then
                Temp_Sub = New VbNET.Sub(Sub_Name.Text)
            End If
            Temp_Sub.Name = Sub_Name.Text
        End If

        Property_Sub.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |04.02.03| <Sub> <Sub> [HandleValue]"
    Private Sub Sub_HandleValue_TextChanged(sender As Object, e As EventArgs) Handles Sub_HandleValue.TextChanged
        If Not IsNothing(Temp_Sub) Then
            If Sub_Handle.Text = "Handles" Then
                Temp_Sub.Handles = Sub_HandleValue.Text
            Else
                If Sub_Handle.Text = "Implements" Then
                    Temp_Sub.Implements = Sub_HandleValue.Text
                End If
            End If
        End If
        Property_Sub.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |04.02.04| <Sub> <Sub> [Async]"
    Private Sub Sub_Async_ValueChanged(sender As Object, e As EventArgs) Handles Sub_Async.ValueChanged
        If Not IsNothing(Temp_Sub) Then
            Temp_Sub.Async = Sub_Async.Value
        End If
        Property_Sub.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |04.02.05| <Sub> <Sub> [Partial]"
    Private Sub Sub_Partial_ValueChanged(sender As Object, e As EventArgs) Handles Sub_Partial.ValueChanged
        If Not IsNothing(Temp_Sub) Then
            Temp_Sub.Partial = Sub_Partial.Value
        End If
        Property_Sub.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |04.02.06| <Sub> <Sub> [Shadows]"
    Private Sub Sub_Shadows_ValueChanged(sender As Object, e As EventArgs) Handles Sub_Shadows.ValueChanged
        If Not IsNothing(Temp_Sub) Then
            Temp_Sub.Shadows = Sub_Shadows.Value
        End If
        Property_Sub.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |04.02.07| <Sub> <Sub> [Shared]"
    Private Sub Sub_Shared_ValueChanged(sender As Object, e As EventArgs) Handles Sub_Shared.ValueChanged
        If Not IsNothing(Temp_Sub) Then
            Temp_Sub.Shared = Sub_Shared.Value
        End If
        Property_Sub.RefreshPropertyValues()
    End Sub
#End Region
#End Region
#Region "|ON | |04.03| <Sub> [Attribute]{12}"
#Region "|ON | |04.02.00| <Sub> <Attribute> [Category]"
    Private Sub Sub_Attribute_Category_Leave(sender As Object, e As EventArgs) Handles Sub_Attribute_Category.Leave
        AddCategory(Sub_Attribute_Category.Text)
        ' RefreshCategory()
        Sub_CategoryID.Value = RetriveCategoryID_FromString(Sub_Attribute_Category.Text)
        Property_Sub.RefreshPropertyValues()
    End Sub
    Private Sub Sub_Attribute_Category_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Sub_Attribute_Category.SelectedIndexChanged
        If Sub_Attribute_Category.Text <> "" Then
            If Not IsNothing(Temp_Sub) Then
                Temp_Sub.Category = Sub_Attribute_Category.Text
            End If
        End If
        Property_Sub.RefreshPropertyValues()
    End Sub
#End Region
#Region "|OFF|X|04.02.01| <Sub> <Attribute> [DefaultValue]"

#End Region
#Region "|OFF|X|04.02.02| <Sub> <Attribute> [Browsable]"

#End Region
#Region "|ON | |04.02.03| <Sub> <Attribute> [Definition]"
    Private Sub Sub_Description_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Sub_Description.TextChanged
        If Not IsNothing(Temp_Sub) Then
            Temp_Sub.Description = Sub_Description.Text
        End If
        Property_Sub.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |04.02.04| <Sub> <Attribute> [Editor]"
    Private Sub Sub_Attribute_Editor_TextChanged(sender As Object, e As EventArgs) Handles Sub_Attribute_Editor.TextChanged
        If Not IsNothing(Temp_Sub) Then
            Temp_Sub.Editor = Sub_Attribute_Editor.Text
        End If
        Property_Sub.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |04.02.04| <Sub> <Attribute> [RelatedImageList]"
    Private Sub Sub_Attribute_RelatedImageList_TextChanged(sender As Object, e As EventArgs) Handles Sub_Attribute_RelatedImageList.TextChanged
        If Not IsNothing(Temp_Sub) Then
            Temp_Sub.RelatedImageList = Sub_Attribute_RelatedImageList.Text
        End If
        Property_Sub.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |04.02.06| <Sub> <Attribute> [Custom]"
    Private Sub Sub_Attribute_Customs_TextChanged(sender As Object, e As EventArgs) Handles Sub_Attribute_Custom.TextChanged
        If Not IsNothing(Temp_Sub) Then
            Temp_Sub.CustomProperty = Sub_Attribute_Custom.Text
        End If
        Property_Sub.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |04.02.07| <Sub> <Attribute> [Deserializable]"
    Private Sub Sub_Attribute_Deserializable_ValueChanged(sender As Object, e As EventArgs) Handles Sub_Attribute_Deserializable.ValueChanged
        If Not IsNothing(Temp_Sub) Then
            Temp_Sub.Deserializable = Sub_Attribute_Deserializable.Value
        End If
        Property_Sub.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |04.02.08| <Sub> <Attribute> [NonSerialized]"
    Private Sub Sub_Attribute_NonSerialized_ValueChanged(sender As Object, e As EventArgs) Handles Sub_Attribute_NonSerialized.ValueChanged
        If Not IsNothing(Temp_Sub) Then
            Temp_Sub.NonSerialized = Sub_Attribute_NonSerialized.Value
        End If
        Property_Sub.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |04.02.09| <Sub> <Attribute> [Serializable]"
    Private Sub Sub_Attribute_Serializable_ValueChanged(sender As Object, e As EventArgs) Handles Sub_Attribute_Serializable.ValueChanged
        If Not IsNothing(Temp_Sub) Then
            Temp_Sub.Serializable = Sub_Attribute_Serializable.Value
        End If
        Property_Sub.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |04.02.10| <Sub> <Attribute> [XmlRoot]"
    Private Sub Sub_Attribute_XmlRoot_TextChanged(sender As Object, e As EventArgs) Handles Sub_Attribute_XmlRoot.TextChanged
        If Not IsNothing(Temp_Sub) Then
            Temp_Sub.XmlRoot = Sub_Attribute_XmlRoot.Text
        End If
        Property_Sub.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |04.02.11| <Sub> <Attribute> [XmlIgnore]"
    Private Sub Sub_Attribute_XmlIgnore_ValueChanged(sender As Object, e As EventArgs) Handles Sub_Attribute_XmlIgnore.ValueChanged
        If Not IsNothing(Temp_Sub) Then
            Temp_Sub.XmlIgnore = Sub_Attribute_XmlIgnore.Value
        End If
        Property_Sub.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |04.02.12| <Sub> <Attribute> [XmlInclude]"
    Private Sub Sub_Attribute_XmlInclude_ValueChanged(sender As Object, e As EventArgs) Handles Sub_Attribute_XmlInclude.ValueChanged
        If Not IsNothing(Temp_Sub) Then
            Temp_Sub.XmlInclude = Sub_Attribute_XmlInclude.Value
        End If
        Property_Sub.RefreshPropertyValues()
    End Sub
#End Region
#End Region
#Region "|ON | |04.03| <Sub> [Summary]{14}"
#Region "|ON | |04.03.00| <Sub> <Summary> [Usage]"
    Private Sub Sub_Summary_Usage_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Sub_Summary_Usage.TextChanged
        If Not IsNothing(Temp_Sub) Then
            Temp_Sub.Usage = Sub_Summary_Usage.Text
        End If
        Property_Sub.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |04.03.01| <Sub> <Summary> [Remark]"
    Private Sub Sub_Summary_Remark_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Sub_Summary_Remark.TextChanged
        If Not IsNothing(Temp_Sub) Then
            Temp_Sub.Remarks = Sub_Summary_Remark.Text
        End If
        Property_Sub.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |04.03.02| <Sub> <Summary> [Example]"
    Private Sub Sub_Summary_Example_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Sub_Summary_Example.TextChanged
        If Not IsNothing(Temp_Sub) Then
            Temp_Sub.Example = Sub_Summary_Example.Text
        End If
        Property_Sub.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |04.03.03| <Sub> <Summary> [Note]"
    Private Sub Sub_Summary_Note_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Sub_Summary_Note.TextChanged
        If Not IsNothing(Temp_Sub) Then
            Temp_Sub.Note = Sub_Summary_Note.Text
        End If
        Property_Sub.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |04.03.04| <Sub> <Summary> [Rules]"
    Private Sub Sub_Summary_Rules_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Sub_Summary_Rules.TextChanged
        If Not IsNothing(Temp_Sub) Then
            Temp_Sub.Rules = Sub_Summary_Rules.Text
        End If
        Property_Sub.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |04.03.05| <Sub> <Summary> [Syntax]"
    Private Sub Sub_Summary_Syntax_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Sub_Summary_Syntax.TextChanged
        If Not IsNothing(Temp_Sub) Then
            Temp_Sub.Syntax = Sub_Summary_Syntax.Text
        End If
        Property_Sub.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |04.03.06| <Sub> <Summary> [Rights]"
    Private Sub Sub_Summary_Rights_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Sub_Summary_Rights.TextChanged
        If Not IsNothing(Temp_Sub) Then
            Temp_Sub.Rights = Sub_Summary_Rights.Text
        End If
        Property_Sub.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |04.03.07| <Sub> <Summary> [AuthorName]"
    Private Sub Sub_Summary_AuthorName_TextChanged(sender As Object, e As EventArgs) Handles Sub_Summary_AuthorName.TextChanged
        If Not IsNothing(Temp_Sub) Then
            Temp_Sub.AuthorName = Sub_Summary_AuthorName.Text
        End If

        Property_Sub.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |04.03.08| <Sub> <Summary> [AuthorEmail]"
    Private Sub Sub_Summary_AuthorEmail_TextChanged(sender As Object, e As EventArgs) Handles Sub_Summary_AuthorEmail.TextChanged
        If Not IsNothing(Temp_Sub) Then
            Temp_Sub.AuthorEmail = Sub_Summary_AuthorEmail.Text
        End If
        Property_Sub.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |04.03.09| <Sub> <Summary> [AuthorUrl]"
    Private Sub Sub_Summary_AuthorUrl_TextChanged(sender As Object, e As EventArgs) Handles Sub_Summary_AuthorUrl.TextChanged
        If Not IsNothing(Temp_Sub) Then
            Temp_Sub.AuthorUri = Sub_Summary_AuthorUrl.Text
        End If
        Property_Sub.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |04.03.10| <Sub> <Summary> [ContributorName]"
    Private Sub Sub_Summary_ContributorName_TextChanged(sender As Object, e As EventArgs) Handles Sub_Summary_ContributorName.TextChanged
        If Not IsNothing(Temp_Sub) Then
            Temp_Sub.ContributorName = Sub_Summary_ContributorName.Text
        End If
        Property_Sub.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |04.03.11| <Sub> <Summary> [ContributorEmail]"
    Private Sub Sub_Summary_ContributorEmail_TextChanged(sender As Object, e As EventArgs) Handles Sub_Summary_ContributorEmail.TextChanged
        If Not IsNothing(Temp_Sub) Then
            Temp_Sub.ContributorEmail = Sub_Summary_ContributorEmail.Text
        End If
        Property_Sub.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |04.03.12| <Sub> <Summary> [ContributorUrl]"
    Private Sub Sub_Summary_ContributorUrl_TextChanged(sender As Object, e As EventArgs) Handles Sub_Summary_ContributorUrl.TextChanged
        If Not IsNothing(Temp_Sub) Then
            Temp_Sub.ContributorUri = Sub_Summary_ContributorUrl.Text
        End If
        Property_Sub.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |04.03.13| <Sub> <Summary> [Custom]"
    Private Sub Sub_Attribute_Custom_TextChanged(sender As Object, e As EventArgs) Handles Sub_Attribute_Custom.TextChanged
        If Not IsNothing(Temp_Sub) Then
            Temp_Sub.CustomProperty = Sub_Attribute_Custom.Text
        End If
        Property_Sub.RefreshPropertyValues()
    End Sub
#End Region
#End Region
#Region "|ON | |04.04| <Sub> [ParameterList]{2}"
#Region "|ON | |04.04.00| <Sub> <ParameterList> [Add]"
    Private Sub Sub_Add_InputParam_Click(sender As Object, e As EventArgs) Handles Sub_Add_InputParam.Click
        If Not IsNothing(Temp_Sub) Then
            Dim P As VbNET.InnerStatement.ParameterList_Statement = Nothing
            P = Temp_Sub.AddParameter(Sub_Param_Name.Text, Sub_Param_ReturnType.Text, Sub_Param_DefaultValue.Text, Sub_Param_Modifier.Text, Sub_Param_Summary.Text)
            If Not IsNothing(P) Then
                Dim Lt As New ListViewItem(Sub_ParameterList.Items.Count)
                Lt.SubItems.Add(P.Modifier)
                Lt.SubItems.Add(P.ParameterName)
                Lt.SubItems.Add(P.ParameterType)
                Lt.SubItems.Add(P.Definition)
                Lt.SubItems.Add(P.DefaultValue)
                Lt.ToolTipText = P.Definition
                Lt.Tag = P
                Sub_ParameterList.Items.Add(Lt)
            End If

        End If
        Property_Sub.RefreshPropertyValues()
    End Sub

#End Region
#Region "|ON | |04.04.01| <Sub> <ParameterList> [Remove]"
    Private Sub Sub_Remove_InputParam_Click(sender As Object, e As EventArgs) Handles Sub_Remove_InputParam.Click
        If Not IsNothing(Temp_Sub) Then
            Dim P As VbNET.InnerStatement.ParameterList_Statement = Nothing
            P = Temp_Sub.RemoveParameter(Sub_Param_Name.Text)
            If Not IsNothing(P) Then
                Dim Lt As New ListViewItem(Sub_ParameterList.Items.Count)
                Lt.SubItems.Add(P.Modifier)
                Lt.SubItems.Add(P.ParameterName)
                Lt.SubItems.Add(P.ParameterType)
                Lt.SubItems.Add(P.Definition)
                Lt.SubItems.Add(P.DefaultValue)
                Lt.ToolTipText = P.Definition
                Lt.Tag = P
                Sub_ParameterList.Items.Remove(Lt)
            End If

        End If
        Property_Sub.RefreshPropertyValues()
    End Sub
#End Region
#End Region
#End Region

    Public Sub Read_Sub(ByRef Statement As VbNET.Sub)
        If Not IsNothing(Statement) Then
            With Statement

                Sub_AccessModifier.Text = VbNET.AccessModifiers_ToString(.AccessModifier)
                '  Sub_AttributeList_Browsable.Value = .Browsable
                Sub_Attribute_Category.Text = .Category
                ' Sub_Attribute_DefaultValue.Text = .DefaultValue
                Sub_Attribute_Deserializable.Value = .Deserializable
                Sub_Attribute_Editor.Text = .Editor
                Sub_Attribute_NonSerialized.Value = .NonSerialized
                Sub_Attribute_RelatedImageList.Text = .RelatedImageList
                Sub_Attribute_Serializable.Value = .Serializable
                Sub_Attribute_XmlIgnore.Value = .XmlIgnore
                Sub_Attribute_XmlInclude.Value = .XmlInclude
                Sub_Attribute_XmlRoot.Text = .XmlRoot
                Sub_CategoryID.Value = .RegionCategory
                'Sub_Default.Value = .Default
                Sub_Description.Text = .Description
                Sub_Enable.Value = .Enable
                'Sub_GetStatement.Text = .GetStatement
                Sub_ID.Value = .ID
                Sub_Name.Text = .Name
                Read_Parameters(Sub_ParameterList, .ParameterList)
                'Read_Members(Sub_Members, .Members)
                If Not IsNothing(.ParentClass) Then
                    Sub_Parent.Text = .ParentClass.ClassName
                ElseIf Not IsNothing(.ParentModule) Then
                    Sub_Parent.Text = .ParentModule.Name
                ElseIf Not IsNothing(.ParentStructure) Then
                    Sub_Parent.Text = .ParentStructure.Name
                Else
                    Sub_Parent.Text = VirtualClass.ClassName
                End If
                Sub_Print_C.Text = .C
                Sub_Print_F.Text = .F
                Sub_Print_JS.Text = .JavaScript
                Sub_Print_Python.Text = .Python
                Sub_Print_VB.Text = .VB
                Property_Sub.SelectedObject = Statement
                'Sub_PropertyModifier.Text = VbNET.PropertyModifiers_ToString(.PropertyModifier)
                'Sub_ReadOnly.Value = .ReadOnly
                'Sub_Required.Value = .Required
                'Sub_ReturnType.Text = .ReturnType
                Sub_Statement.Text = .Statement
                Sub_Shadows.Value = .Shadows
                Sub_Shared.Value = .Shared
                Sub_Summary_AuthorEmail.Text = .AuthorEmail
                Sub_Summary_AuthorName.Text = .AuthorName
                Sub_Summary_AuthorUrl.Text = .AuthorUri
                Sub_Summary_ContributorEmail.Text = .ContributorEmail
                Sub_Summary_ContributorName.Text = .ContributorName
                Sub_Summary_ContributorUrl.Text = .ContributorUri
                Sub_Summary_Example.Text = .Example
                Sub_Summary_Note.Text = .Note
                Sub_Summary_Remark.Text = .Remarks
                Sub_Summary_Rights.Text = .Rights
                Sub_Summary_Rules.Text = .Rules
                Sub_Summary_Syntax.Text = .Syntax
                Sub_Summary_Usage.Text = .Usage
                'Sub_Variable_AccessModifier.Text = VbNET.AccessModifiers_ToString(.Variable_AccessModifier)
                'Sub_Variable_Name.Text = .Variable_Name
                'Sub_Variable_ReturnType.Text = .Variable_ReturnType
                'Sub_WriteOnly.Value = .WriteOnly

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
End Class
