Imports System.Windows.Forms
Imports DevComponents.DotNetBar.Controls

Public Class VbNET_Loader


#Region "Runtime"
    Public Temp_Loader As New VbNET.Loader
    Private _ActiveParent As Object
    Public Property ActiveParent() As Object
        Get
            Return _ActiveParent
        End Get
        Set(ByVal value As Object)
            If Not IsNothing(value) Then
                If IsNothing(Temp_Loader) Then
                    Temp_Loader = New VbNET.Loader
                End If

                If TypeOf value Is VbNET.Class Then
                    Loader_Parent.Text = value.Name
                    Temp_Loader.ParentClass = value
                    Dim T As VbNET.Class
                    T = value
                    BS_Loader.DataSource = T.Sub
                    Bind_Loader.BindingSource = BS_Loader
                End If

            End If
            _ActiveParent = value
        End Set
    End Property
#End Region
    Public Sub Initializor()
        If IsNothing(VirtualClass) Then
            VirtualClass = New VbNET.Class("VirtualClass")
        End If
        RefreshParents(Loader_Parent, True, True)
        Loader_Parent.SelectedIndex = 0
    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Initializor()
    End Sub
    Public Sub OpenStatement(ByVal Statement As VbNET.Loader)

        ' This call is required by the designer.
        'InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Initializor()
        Temp_Loader = Statement
        Read_Loader(Statement)
    End Sub
    Public Sub Read_Loader(ByRef Statement As VbNET.Loader)
        If Not IsNothing(Statement) Then
            With Statement

                Loader_AccessModifier.Text = VbNET.AccessModifiers_ToString(.AccessModifier)
                '  Loader_AttributeList_Browsable.Value = .Browsable
                Loader_Attribute_Category.Text = .Category
                ' Loader_Attribute_DefaultValue.Text = .DefaultValue
                ' Loader_Attribute_Deserializable.Value = .Deserializable
                ' Loader_Attribute_Editor.Text = .Editor
                ' Loader_Attribute_NonSerialized.Value = .NonSerialized
                ' Loader_Attribute_RelatedImageList.Text = .RelatedImageList
                'Loader_Attribute_Serializable.Value = .Serializable
                ' Loader_Attribute_XmlIgnore.Value = .XmlIgnore
                '' Loader_Attribute_XmlInclude.Value = .XmlInclude
                'Loader_Attribute_XmlRoot.Text = .XmlRoot
                Loader_CategoryID.Value = .RegionCategory
                '  Loader_Default.Value = .Default
                Loader_Description.Text = .Description
                Loader_Enable.Value = .Enable
                'Loader_GetStatement.Text = .GetStatement
                Loader_ID.Value = .ID
                Loader_Name.Text = .Name
                Read_Parameters(Loader_ParameterList, .ParameterList)
                'Read_Members(Loader_Members, .Members)
                '          If Not IsNothing(.ParentClass) Then
                Loader_Parent.Text = .ParentClass.ClassName
                '          ElseIf Not IsNothing(.ParentModule) Then
                '          Loader_Parent.Text = .ParentModule.Name
                '           ElseIf Not IsNothing(.ParentStructure) Then
                '           Loader_Parent.Text = .ParentStructure.Name
                '           Else
                '           Loader_Parent.Text = VirtualClass.ClassName
                '   End If
                Loader_Print_C.Text = .C
                Loader_Print_F.Text = .F
                Loader_Print_JS.Text = .JavaScript
                Loader_Print_Python.Text = .Python
                Loader_Print_VB.Text = .VB
                Property_Loader.SelectedObject = Statement
                ' Loader_PropertyModifier.Text = VbNET.PropertyModifiers_ToString(.PropertyModifier)
                'Loader_ReadOnly.Value = .ReadOnly
                'Loader_Required.Value = .Required
                'Loader_ReturnType.Text = .ReturnType
                Loader_Statement.Text = .Statement
                Loader_Shadows.Value = .Shadows
                Loader_Shared.Value = .Shared
                Loader_Summary_AuthorEmail.Text = .AuthorEmail
                Loader_Summary_AuthorName.Text = .AuthorName
                Loader_Summary_AuthorUrl.Text = .AuthorUri
                Loader_Summary_ContributorEmail.Text = .ContributorEmail
                Loader_Summary_ContributorName.Text = .ContributorName
                Loader_Summary_ContributorUrl.Text = .ContributorUri
                Loader_Summary_Example.Text = .Example
                Loader_Summary_Note.Text = .Note
                Loader_Summary_Remark.Text = .Remarks
                Loader_Summary_Rights.Text = .Rights
                Loader_Summary_Rules.Text = .Rules
                Loader_Summary_Syntax.Text = .Syntax
                Loader_Summary_Usage.Text = .Usage
                'Loader_Variable_AccessModifier.Text = VbNET.AccessModifiers_ToString(.Variable_AccessModifier)
                'Loader_Variable_Name.Text = .Variable_Name
                'Loader_Variable_ReturnType.Text = .Variable_ReturnType
                'Loader_WriteOnly.Value = .WriteOnly

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
#Region "|ON |4|07| [Loader]{46}"
#Region "|ON | |07.00| <Loader> [FileManager]{5}"
#Region "|ON | |07.00.00| <Loader> <FileManager> [Add]"
    Private Sub Loader_Btn_Add_Click(sender As Object, e As EventArgs) Handles Loader_Btn_Add.Click
        If Not IsNothing(VirtualClass) Then
            If IsNothing(Temp_Loader) Then
                Temp_Loader = New VbNET.Loader(VirtualClass)
            End If
            Dim D = Loader_Parent.SelectedItem.tag
            If TypeOf D Is VbNET.Class Then
                Temp_Loader.ParentClass = D
                Temp_Loader.ParentName = D.name
                Temp_Loader.ParentClass.Add_Loader(Temp_Loader)
                BS_Loader.DataSource = Temp_Loader.ParentClass.Loader
                Bind_Loader.BindingSource = BS_Loader
                Bind_Loader.Visible = True
            End If

            ' Quantity_Loader.Value += 1
            Loader_ID.Value += 1
            '   RefreshReturnType()
        End If
        Property_Loader.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |04.00.01| <Sub> <FileManager> [Preview]"
    Private Sub Loader_Btn_Preview_Click(sender As Object, e As EventArgs) Handles Loader_Btn_Preview.Click
        If Not IsNothing(Temp_Loader) Then
            If Loader_Statement.Text = "" Then
                If Loader_Parent.Text <> "" Then
                    ActiveParent = Loader_Parent.SelectedItem.Tag
                    If TypeOf ActiveParent Is VbNET.Class Then
                        Temp_Loader.ParentClass = ActiveParent
                        Temp_Loader.ParentName = ActiveParent.Name
                    End If
                    Dim T As New VbNET.Class
                    T = ActiveParent
                    Loader_Statement.Text = "With Me" & vbNewLine

                    For Each P As VbNET.Property In T.Properties
                        If P.Required = True Then
                            Loader_Statement.Text += "    If Not IsNothing(" & P.Name & ") Then" & vbNewLine
                            Loader_Statement.Text += "      ." & P.Name & "=" & P.Name & vbNewLine
                            Loader_Statement.Text += "    End If" & vbNewLine
                            Dim Pp As New VbNET.InnerStatement.ParameterList_Statement(P.Name,
                                                                                        P.ReturnType, "ByVal",, P.Description, P.Enable)

                            Temp_Loader.ParameterList.Add(Pp)
                        ElseIf P.Required = False Then
                            Loader_Statement.Text += "    If Not IsNothing(" & P.Name & ") Then" & vbNewLine

                            Loader_Statement.Text += "      ." & P.Name & "=" & P.Name & vbNewLine
                            Loader_Statement.Text += "    End If" & vbNewLine
                            Dim Pp As New VbNET.InnerStatement.ParameterList_Statement(P.Name,
                                                                                       P.ReturnType, "Optional ByVal", P.DefaultValue, P.Description, P.Enable)

                            Temp_Loader.ParameterList.Add(Pp)
                        End If
                    Next
                    Loader_Statement.Text += "End With"


                End If
            End If
            Temp_Loader.Statement = Loader_Statement.Text
            Temp_Loader.PrintStatement(Loader_Print_VB,
                                                   Loader_Print_C,
                                                   Loader_Print_F,
                                                   Loader_Print_Python,
                                                   Loader_Print_JS,
                                                   Loader_Enable.Value)
        End If
        Property_Loader.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |04.00.02| <Sub> <FileManager> [New]"
    Private Sub Loader_Btn_New_Click(sender As Object, e As EventArgs) Handles Loader_Btn_New.Click
        Temp_Loader = New VbNET.Loader
        Loader_AccessModifier.Text = "Public"
        Loader_Async.Value = False
        Loader_Attribute_Category.Text = ""
        Loader_CategoryID.Value = 0
        Loader_Description.Text = ""
        Loader_Enable.Value = True
        Loader_Name.Text = ""
        Loader_ParameterList.Items.Clear()
        Loader_Partial.Value = False
        Loader_ProcedureModifier.Text = ""
        Loader_Shadows.Value = False
        Loader_Shared.Value = False
        Loader_Statement.Text = ""
        Loader_Summary_AuthorEmail.Text = My.Settings.AuthorEmail
        Loader_Summary_AuthorName.Text = My.Settings.AuthorName
        Loader_Summary_AuthorUrl.Text = My.Settings.AuthorUrl
        Loader_Summary_ContributorEmail.Text = ""
        Loader_Summary_ContributorName.Text = ""
        Loader_Summary_ContributorUrl.Text = ""
        Loader_Summary_Example.Text = ""
        Loader_Summary_Note.Text = ""
        Loader_Summary_Remark.Text = ""
        Loader_Summary_Rights.Text = ""
        Loader_Summary_Rules.Text = ""
        Loader_Summary_Syntax.Text = ""
        Loader_Summary_Usage.Text = ""
        Property_Loader.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |04.00.03| <Sub> <FileManager> [Open]"
    Private Sub Loader_Btn_Open_Click(sender As Object, e As EventArgs) Handles Loader_Btn_Open.Click
        Dim Ofd As New OpenFileDialog
        With Ofd
            .Filter = "Loader Statement (*.Loader)|*.Loader|All Files (*.*)|*.*"
            If .ShowDialog = DialogResult.OK Then
                Try
                    Temp_Loader.Open(.FileName)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End With
        Property_Loader.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |04.00.04| <Sub> <FileManager> [Save]"
    Private Sub Loader_Btn_Save_Click(sender As Object, e As EventArgs) Handles Loader_Btn_Save.Click
        If Not IsNothing(Temp_Loader) Then
            If Temp_Loader.Name <> "" Then
                Dim F = Temp_Loader.Save().Output
                Temp_Loader.XmlFile = F.Target
            End If
        End If
        Property_Loader.RefreshPropertyValues()
    End Sub
#End Region
#End Region
#Region "|ON |1|07.01| <Loader> [Constructor]{5}"
#Region "|ON |1|07.01.00| <Loader> <Constructor> [Statement]{5}"
#Region "|ON | |07.01.00.00| <Loader> <Constructor> <Statement> [Enable]"
    Private Sub Loader_Enable_ValueChanged(sender As Object, e As EventArgs) Handles Loader_Enable.ValueChanged
        If Not IsNothing(Temp_Loader) Then
            Temp_Loader.Enable = Loader_Enable.Value
        End If
        Property_Loader.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |07.01.00.01| <Loader> <Constructor> <Statement> [ID]"
    Private Sub Loader_ID_ValueChanged(sender As Object, e As EventArgs) Handles Loader_ID.ValueChanged
        If Not IsNothing(Temp_Loader) Then
            Temp_Loader.ID = Loader_ID.Value
        End If
        Property_Loader.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |07.01.00.02| <Loader> <Constructor> <Statement> [CategoryID]"
    Private Sub Loader_CategoryID_ValueChanged(sender As Object, e As EventArgs) Handles Loader_CategoryID.ValueChanged
        If Not IsNothing(Temp_Loader) Then
            Temp_Loader.RegionCategory = Loader_CategoryID.Value
        End If
        Property_Loader.RefreshPropertyValues()
    End Sub
#End Region
#Region "|OFF|X|07.01.00.03| <Loader> <Constructor> <Statement> [Parent]"

#End Region
#Region "|ON | |07.01.00.04| <Loader> <Constructor> <Statement> [Statement]"
    Private Sub Loader_Statement_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Loader_Statement.TextChanged
        If Not IsNothing(Temp_Loader) Then
            Temp_Loader.Statement = Loader_Statement.Text
        End If
        Property_Loader.RefreshPropertyValues()
    End Sub
#End Region
#End Region
#End Region
#Region "|ON | |07.02| <Loader> [Constructor]{8}"
#Region "|ON | |07.02.00| <Loader> <Constructor> [AccessModifier]"
    Private Sub Loader_AccessModifier_TextChanged(sender As Object, e As EventArgs) Handles Loader_AccessModifier.TextChanged
        If Not IsNothing(Temp_Loader) Then
            Temp_Loader.AccessModifier = VbNET.String_ToAccessModifiers(Loader_AccessModifier.Text)
        End If
        Property_Loader.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |07.02.01| <Loader> <Constructor> [ProcedureModifier]"
    Private Sub Loader_ProcedureModifier_TextChanged(sender As Object, e As EventArgs) Handles Loader_ProcedureModifier.TextChanged
        If Not IsNothing(Temp_Loader) Then
            Temp_Loader.ProcedureModifier = VbNET.String_ToProcedureModifiers(Loader_ProcedureModifier.Text)
        End If
        Property_Loader.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |07.02.02| <Loader> <Constructor> [Name]"
    Private Sub Loader_Name_TextChanged(sender As Object, e As EventArgs) Handles Loader_Name.TextChanged
        If Loader_Name.Text <> "" Then
            If IsNothing(Temp_Loader) Then
                Temp_Loader = New VbNET.Loader(Loader_Name.Text)
            End If
            Temp_Loader.Name = Loader_Name.Text
        End If

        Property_Loader.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |07.02.03| <Loader> <Constructor> [HandleValue]"

#End Region
#Region "|ON | |07.02.04| <Loader> <Constructor> [Async]"
    Private Sub Loader_Async_ValueChanged(sender As Object, e As EventArgs) Handles Loader_Async.ValueChanged
        If Not IsNothing(Temp_Loader) Then
            Temp_Loader.Async = Loader_Async.Value
        End If
        Property_Loader.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |07.02.05| <Loader> <Constructor> [Partial]"
    Private Sub Loader_Partial_ValueChanged(sender As Object, e As EventArgs) Handles Loader_Partial.ValueChanged
        If Not IsNothing(Temp_Loader) Then
            Temp_Loader.Partial = Loader_Partial.Value
        End If
        Property_Loader.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |07.02.06| <Loader> <Constructor> [Shadows]"
    Private Sub Loader_Shadows_ValueChanged(sender As Object, e As EventArgs) Handles Loader_Shadows.ValueChanged
        If Not IsNothing(Temp_Loader) Then
            Temp_Loader.Shadows = Loader_Shadows.Value
        End If
        Property_Loader.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |07.02.07| <Loader> <Constructor> [Shared]"
    Private Sub Loader_Shared_ValueChanged(sender As Object, e As EventArgs) Handles Loader_Shared.ValueChanged
        If Not IsNothing(Temp_Loader) Then
            Temp_Loader.Shared = Loader_Shared.Value
        End If
        Property_Loader.RefreshPropertyValues()
    End Sub
#End Region
#End Region
#Region "|ON | |07.03| <Loader> [Attribute]{12}"
#Region "|ON | |07.02.00| <Loader> <Attribute> [Category]"
    Private Sub Loader_Attribute_Category_Leave(sender As Object, e As EventArgs) Handles Loader_Attribute_Category.Leave
        AddCategory(Loader_Attribute_Category.Text)
        ' RefreshCategory()
        Loader_CategoryID.Value = RetriveCategoryID_FromString(Loader_Attribute_Category.Text)
        Property_Loader.RefreshPropertyValues()
    End Sub
    Private Sub Loader_Attribute_Category_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Loader_Attribute_Category.SelectedIndexChanged
        If Loader_Attribute_Category.Text <> "" Then
            If Not IsNothing(Temp_Loader) Then
                Temp_Loader.Category = Loader_Attribute_Category.Text
            End If
        End If
        Property_Loader.RefreshPropertyValues()
    End Sub
#End Region
#Region "|OFF|X|07.02.01| <Loader> <Attribute> [DefaultValue]"

#End Region
#Region "|OFF|X|07.02.02| <Loader> <Attribute> [Browsable]"

#End Region
#Region "|ON | |07.02.03| <Loader> <Attribute> [Definition]"
    Private Sub Loader_Description_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Loader_Description.TextChanged
        If Not IsNothing(Temp_Loader) Then
            Temp_Loader.Description = Loader_Description.Text
        End If
        Property_Loader.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |07.02.04| <Loader> <Attribute> [Editor]"
    Private Sub Loader_Attribute_Editor_TextChanged(sender As Object, e As EventArgs) Handles Loader_Attribute_Editor.TextChanged
        If Not IsNothing(Temp_Loader) Then
            Temp_Loader.Editor = Loader_Attribute_Editor.Text
        End If
        Property_Loader.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |07.02.04| <Loader> <Attribute> [RelatedImageList]"
    Private Sub Loader_Attribute_RelatedImageList_TextChanged(sender As Object, e As EventArgs) Handles Loader_Attribute_RelatedImageList.TextChanged
        If Not IsNothing(Temp_Loader) Then
            Temp_Loader.RelatedImageList = Loader_Attribute_RelatedImageList.Text
        End If
        Property_Loader.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |07.02.06| <Loader> <Attribute> [Custom]"
    Private Sub Loader_Attribute_Customs_TextChanged(sender As Object, e As EventArgs) Handles Loader_Attribute_Custom.TextChanged
        If Not IsNothing(Temp_Loader) Then
            Temp_Loader.CustomProperty = Loader_Attribute_Custom.Text
        End If
        Property_Loader.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |07.02.07| <Loader> <Attribute> [Deserializable]"
    Private Sub Loader_Attribute_Deserializable_ValueChanged(sender As Object, e As EventArgs) Handles Loader_Attribute_Deserializable.ValueChanged
        If Not IsNothing(Temp_Loader) Then
            Temp_Loader.Deserializable = Loader_Attribute_Deserializable.Value
        End If
        Property_Loader.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |07.02.08| <Loader> <Attribute> [NonSerialized]"
    Private Sub Loader_Attribute_NonSerialized_ValueChanged(sender As Object, e As EventArgs) Handles Loader_Attribute_NonSerialized.ValueChanged
        If Not IsNothing(Temp_Loader) Then
            Temp_Loader.NonSerialized = Loader_Attribute_NonSerialized.Value
        End If
        Property_Loader.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |07.02.09| <Loader> <Attribute> [Serializable]"
    Private Sub Loader_Attribute_Serializable_ValueChanged(sender As Object, e As EventArgs) Handles Loader_Attribute_Serializable.ValueChanged
        If Not IsNothing(Temp_Loader) Then
            Temp_Loader.Serializable = Loader_Attribute_Serializable.Value
        End If
        Property_Loader.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |07.02.10| <Loader> <Attribute> [XmlRoot]"
    Private Sub Loader_Attribute_XmlRoot_TextChanged(sender As Object, e As EventArgs) Handles Loader_Attribute_XmlRoot.TextChanged
        If Not IsNothing(Temp_Loader) Then
            Temp_Loader.XmlRoot = Loader_Attribute_XmlRoot.Text
        End If
        Property_Loader.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |07.02.11| <Loader> <Attribute> [XmlIgnore]"
    Private Sub Loader_Attribute_XmlIgnore_ValueChanged(sender As Object, e As EventArgs) Handles Loader_Attribute_XmlIgnore.ValueChanged
        If Not IsNothing(Temp_Loader) Then
            Temp_Loader.XmlIgnore = Loader_Attribute_XmlIgnore.Value
        End If
        Property_Loader.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |07.02.12| <Loader> <Attribute> [XmlInclude]"
    Private Sub Loader_Attribute_XmlInclude_ValueChanged(sender As Object, e As EventArgs) Handles Loader_Attribute_XmlInclude.ValueChanged
        If Not IsNothing(Temp_Loader) Then
            Temp_Loader.XmlInclude = Loader_Attribute_XmlInclude.Value
        End If
        Property_Loader.RefreshPropertyValues()
    End Sub
#End Region
#End Region
#Region "|ON | |07.03| <Loader> [Summary]{14}"
#Region "|ON | |07.03.00| <Loader> <Summary> [Usage]"
    Private Sub Loader_Summary_Usage_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Loader_Summary_Usage.TextChanged
        If Not IsNothing(Temp_Loader) Then
            Temp_Loader.Usage = Loader_Summary_Usage.Text
        End If
        Property_Loader.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |07.03.01| <Loader> <Summary> [Remark]"
    Private Sub Loader_Summary_Remark_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Loader_Summary_Remark.TextChanged
        If Not IsNothing(Temp_Loader) Then
            Temp_Loader.Remarks = Loader_Summary_Remark.Text
        End If
        Property_Loader.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |07.03.02| <Loader> <Summary> [Example]"
    Private Sub Loader_Summary_Example_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Loader_Summary_Example.TextChanged
        If Not IsNothing(Temp_Loader) Then
            Temp_Loader.Example = Loader_Summary_Example.Text
        End If
        Property_Loader.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |07.03.03| <Loader> <Summary> [Note]"
    Private Sub Loader_Summary_Note_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Loader_Summary_Note.TextChanged
        If Not IsNothing(Temp_Loader) Then
            Temp_Loader.Note = Loader_Summary_Note.Text
        End If
        Property_Loader.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |07.03.04| <Loader> <Summary> [Rules]"
    Private Sub Loader_Summary_Rules_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Loader_Summary_Rules.TextChanged
        If Not IsNothing(Temp_Loader) Then
            Temp_Loader.Rules = Loader_Summary_Rules.Text
        End If
        Property_Loader.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |07.03.05| <Loader> <Summary> [Syntax]"
    Private Sub Loader_Summary_Syntax_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Loader_Summary_Syntax.TextChanged
        If Not IsNothing(Temp_Loader) Then
            Temp_Loader.Syntax = Loader_Summary_Syntax.Text
        End If
        Property_Loader.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |07.03.06| <Loader> <Summary> [Rights]"
    Private Sub Loader_Summary_Rights_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Loader_Summary_Rights.TextChanged
        If Not IsNothing(Temp_Loader) Then
            Temp_Loader.Rights = Loader_Summary_Rights.Text
        End If
        Property_Loader.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |07.03.07| <Loader> <Summary> [AuthorName]"
    Private Sub Loader_Summary_AuthorName_TextChanged(sender As Object, e As EventArgs) Handles Loader_Summary_AuthorName.TextChanged
        If Not IsNothing(Temp_Loader) Then
            Temp_Loader.AuthorName = Loader_Summary_AuthorName.Text
        End If

        Property_Loader.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |07.03.08| <Loader> <Summary> [AuthorEmail]"
    Private Sub Loader_Summary_AuthorEmail_TextChanged(sender As Object, e As EventArgs) Handles Loader_Summary_AuthorEmail.TextChanged
        If Not IsNothing(Temp_Loader) Then
            Temp_Loader.AuthorEmail = Loader_Summary_AuthorEmail.Text
        End If
        Property_Loader.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |07.03.09| <Loader> <Summary> [AuthorUrl]"
    Private Sub Loader_Summary_AuthorUrl_TextChanged(sender As Object, e As EventArgs) Handles Loader_Summary_AuthorUrl.TextChanged
        If Not IsNothing(Temp_Loader) Then
            Temp_Loader.AuthorUri = Loader_Summary_AuthorUrl.Text
        End If
        Property_Loader.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |07.03.10| <Loader> <Summary> [ContributorName]"
    Private Sub Loader_Summary_ContributorName_TextChanged(sender As Object, e As EventArgs) Handles Loader_Summary_ContributorName.TextChanged
        If Not IsNothing(Temp_Loader) Then
            Temp_Loader.ContributorName = Loader_Summary_ContributorName.Text
        End If
        Property_Loader.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |07.03.11| <Loader> <Summary> [ContributorEmail]"
    Private Sub Loader_Summary_ContributorEmail_TextChanged(sender As Object, e As EventArgs) Handles Loader_Summary_ContributorEmail.TextChanged
        If Not IsNothing(Temp_Loader) Then
            Temp_Loader.ContributorEmail = Loader_Summary_ContributorEmail.Text
        End If
        Property_Loader.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |07.03.12| <Loader> <Summary> [ContributorUrl]"
    Private Sub Loader_Summary_ContributorUrl_TextChanged(sender As Object, e As EventArgs) Handles Loader_Summary_ContributorUrl.TextChanged
        If Not IsNothing(Temp_Loader) Then
            Temp_Loader.ContributorUri = Loader_Summary_ContributorUrl.Text
        End If
        Property_Loader.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |07.03.13| <Loader> <Summary> [Custom]"
    Private Sub Loader_Attribute_Custom_TextChanged(sender As Object, e As EventArgs) Handles Loader_Attribute_Custom.TextChanged
        If Not IsNothing(Temp_Loader) Then
            Temp_Loader.CustomProperty = Loader_Attribute_Custom.Text
        End If
        Property_Loader.RefreshPropertyValues()
    End Sub
#End Region
#End Region
#Region "|ON | |07.04| <Loader> [ParameterList]{2}"
#Region "|ON | |07.04.00| <Loader> <ParameterList> [Add]"
    Private Sub Loader_Add_InputParam_Click(sender As Object, e As EventArgs) Handles Loader_Add_InputParam.Click
        If Not IsNothing(Temp_Loader) Then
            Dim P As VbNET.InnerStatement.ParameterList_Statement = Nothing
            P = Temp_Loader.AddParameter(Loader_Param_Name.Text, Loader_Param_ReturnType.Text, Loader_Param_DefaultValue.Text, Loader_Param_Modifier.Text, Loader_Param_Summary.Text)
            If Not IsNothing(P) Then
                Dim Lt As New ListViewItem(Loader_ParameterList.Items.Count)
                Lt.SubItems.Add(P.Modifier)
                Lt.SubItems.Add(P.ParameterName)
                Lt.SubItems.Add(P.ParameterType)
                Lt.SubItems.Add(P.Definition)
                Lt.SubItems.Add(P.DefaultValue)
                Lt.ToolTipText = P.Definition
                Lt.Tag = P
                Loader_ParameterList.Items.Add(Lt)
            End If

        End If
        Property_Loader.RefreshPropertyValues()
    End Sub

#End Region
#Region "|ON | |07.04.01| <Loader> <ParameterList> [Remove]"
    Private Sub Loader_Remove_InputParam_Click(sender As Object, e As EventArgs) Handles Loader_Remove_InputParam.Click
        If Not IsNothing(Temp_Loader) Then
            Dim P As VbNET.InnerStatement.ParameterList_Statement = Nothing
            P = Temp_Loader.RemoveParameter(Loader_Param_Name.Text)
            If Not IsNothing(P) Then
                Dim Lt As New ListViewItem(Loader_ParameterList.Items.Count)
                Lt.SubItems.Add(P.Modifier)
                Lt.SubItems.Add(P.ParameterName)
                Lt.SubItems.Add(P.ParameterType)
                Lt.SubItems.Add(P.Definition)
                Lt.SubItems.Add(P.DefaultValue)
                Lt.ToolTipText = P.Definition
                Lt.Tag = P
                Loader_ParameterList.Items.Remove(Lt)
            End If

        End If
        Property_Loader.RefreshPropertyValues()
    End Sub

    Private Sub Btn_Refresh_Click(sender As Object, e As EventArgs) Handles Btn_Refresh.Click
        RefreshParents(Loader_Parent)
    End Sub
#End Region
#End Region
#End Region
End Class
