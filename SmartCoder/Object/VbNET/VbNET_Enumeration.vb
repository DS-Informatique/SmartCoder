Imports System.Windows.Forms
Imports DevComponents.DotNetBar.Controls

Public Class VbNET_Enumeration


#Region "Runtime"
    Public Temp_Enumeration As New VbNET.Enumeration
    Private _ActiveParent As Object
    Public Property ActiveParent() As Object
        Get
            Return _ActiveParent
        End Get
        Set(ByVal value As Object)
            If Not IsNothing(value) Then
                If IsNothing(Temp_Enumeration) Then
                    Temp_Enumeration = New VbNET.Enumeration
                End If

                If TypeOf value Is VbNET.Class Then
                    Enumeration_Parent.Text = value.Name
                    Temp_Enumeration.ParentClass = value
                    Dim T As VbNET.Class
                    T = value
                    BS_Enumeration.DataSource = T.Enumeration
                    Bind_Enumerations.BindingSource = BS_Enumeration
                ElseIf TypeOf value Is VbNET.Structure Then
                    Enumeration_Parent.Text = value.Name
                    Temp_Enumeration.ParentStructure = value
                    Dim T As VbNET.Structure
                    T = value
                    BS_Enumeration.DataSource = T.Enumeration
                    Bind_Enumerations.BindingSource = BS_Enumeration
                ElseIf TypeOf value Is VbNET.Module Then
                    Enumeration_Parent.Text = value.name
                    Temp_Enumeration.ParentModule = value
                    Dim T As VbNET.Module
                    T = value
                    BS_Enumeration.DataSource = T.Enumeration
                    Bind_Enumerations.BindingSource = BS_Enumeration
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
        RefreshParents(Enumeration_Parent)

        '  Enumeration_Parent.SelectedIndex = 0
    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Initializor()
    End Sub

    Public Sub OpenStatement(ByVal Statement As VbNET.Enumeration)

        ' This call is required by the designer.
        '  InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Initializor()
        Temp_Enumeration = Statement
        Read_Enumeration(Statement)
    End Sub
    Public Sub Read_Enumeration(ByRef Statement As VbNET.Enumeration)
        If Not IsNothing(Statement) Then
            With Statement

                Enumeration_AccessModifier.Text = VbNET.AccessModifiers_ToString(.AccessModifier)
                ' Enumeration_AttributeList_Browsable.Value = .Browsable
                ' Enumeration_Attribute_Category.Text = .Category
                ' Enumeration_Attribute_DefaultValue.Text = .DefaultValue
                ' Enumeration_Attribute_Deserializable.Value = .Deserializable
                ' Enumeration_Attribute_Editor.Text = .Editor
                ' Enumeration_Attribute_NonSerialized.Value = .NonSerialized
                ' Enumeration_Attribute_RelatedImageList.Text = .RelatedImageList
                ' Enumeration_Attribute_Serializable.Value = .Serializable
                ' Enumeration_Attribute_XmlIgnore.Value = .XmlIgnore
                ' Enumeration_Attribute_XmlInclude.Value = .XmlInclude
                ' Enumeration_Attribute_XmlRoot.Text = .XmlRoot
                Enumeration_CategoryID.Value = .RegionCategory
                ' Enumeration_Default.Value = .Default
                Enumeration_Description.Text = .Description
                Enumeration_Enable.Value = .Enable
                ' Enumeration_GetStatement.Text = .GetStatement
                Enumeration_ID.Value = .ID
                Enumeration_Name.Text = .Name
                '  Read_Parameters(Enumeration_ParamList, .ParameterList)
                Read_Members(Enumeration_Members, .Members)
                If Not IsNothing(.ParentClass) Then
                    Enumeration_Parent.Text = .ParentClass.ClassName
                ElseIf Not IsNothing(.ParentModule) Then
                    Enumeration_Parent.Text = .ParentModule.Name
                ElseIf Not IsNothing(.ParentStructure) Then
                    Enumeration_Parent.Text = .ParentStructure.Name
                Else
                    Enumeration_Parent.Text = VirtualClass.ClassName
                End If
                Enumeration_Print_C.Text = .C
                Enumeration_Print_F.Text = .F
                Enumeration_Print_JS.Text = .JavaScript
                Enumeration_Print_Python.Text = .Python
                Enumeration_Print_VB.Text = .VB
                Property_Enumeration.SelectedObject = Statement
                ' Enumeration_PropertyModifier.Text = VbNET.PropertyModifiers_ToString(.PropertyModifier)
                'Enumeration_ReadOnly.Value = .ReadOnly
                'Enumeration_Required.Value = .Required
                'Enumeration_ReturnType.Text = .ReturnType
                '   Enumeration_Statement.Text = .Statement
                Enumeration_Shadows.Value = .Shadows
                ' Enumeration_Shared.Value = .Shared
                Enumeration_Summary_AuthorEmail.Text = .AuthorEmail
                Enumeration_Summary_AuthorName.Text = .AuthorName
                Enumeration_Summary_AuthorUrl.Text = .AuthorUri
                Enumeration_Summary_ContributorEmail.Text = .ContributorEmail
                Enumeration_Summary_ContributorName.Text = .ContributorName
                Enumeration_Summary_ContributorUrl.Text = .ContributorUri
                Enumeration_Summary_Example.Text = .Example
                Enumeration_Summary_Note.Text = .Note
                Enumeration_Summary_Remark.Text = .Remarks
                Enumeration_Summary_Rights.Text = .Rights
                Enumeration_Summary_Rules.Text = .Rules
                Enumeration_Summary_Syntax.Text = .Syntax
                Enumeration_Summary_Usage.Text = .Usage
                '   Enumeration_Variable_AccessModifier.Text = VbNET.AccessModifiers_ToString(.Variable_AccessModifier)
                '  Enumeration_Variable_Name.Text = .Variable_Name
                ' Enumeration_Variable_ReturnType.Text = .Variable_ReturnType
                'Enumeration_WriteOnly.Value = .WriteOnly

            End With

        End If
    End Sub
    Public Sub Read_Members(ByRef List As ListViewEx, ByRef Param As List(Of VbNET.Enumeration.Member))
        If Not IsNothing(List) Then
            If Not IsNothing(Param) Then
                List.Items.Clear()
                If Param.Count - 1 >= 0 Then
                    For i = 0 To Param.Count - 1
                        Dim P As VbNET.Enumeration.Member = Param(i)
                        Dim Item As New ListViewItem(i)
                        Item.SubItems.Add(P.MemberName)
                        Item.SubItems.Add(P.Description)
                        Item.SubItems.Add(P.MemberValue)
                        List.Items.Add(Item)
                    Next
                End If
            End If
        End If


    End Sub
#Region "|ON |2|02| [Enumeration]{30}"
#Region "|ON | |02.00| <Enumeration> [FileManager]{5}"
#Region "|ON | |02.00.00| <Enumeration> <FileManager> [Add]"
    Private Sub Enumeration_Btn_Add_Click(sender As Object, e As EventArgs) Handles Enumeration_Btn_Add.Click
        Temp_Enumeration.VB = Enumeration_Print_VB.Text
        Temp_Enumeration.C = Enumeration_Print_C.Text
        Temp_Enumeration.F = Enumeration_Print_F.Text
        Temp_Enumeration.Python = Enumeration_Print_Python.Text
        Temp_Enumeration.JavaScript = Enumeration_Print_JS.Text
        For Each str As String In Temp_Enumeration.VB
            Temp_Enumeration.Print_VB.Add(str)
        Next
        For Each str As String In Temp_Enumeration.C
            Temp_Enumeration.Print_C.Add(str)
        Next
        For Each str As String In Temp_Enumeration.F
            Temp_Enumeration.Print_F.Add(str)
        Next
        For Each str As String In Temp_Enumeration.Python
            Temp_Enumeration.Print_Python.Add(str)
        Next
        For Each str As String In Temp_Enumeration.JavaScript
            Temp_Enumeration.Print_JavaScript.Add(str)
        Next
        Dim D = Enumeration_Parent.SelectedItem.tag
        If TypeOf D Is VbNET.Class Then
            Temp_Enumeration.ParentClass = D
            Temp_Enumeration.ParentName = D.name
            Temp_Enumeration.ParentClass.Add_Enumeration(Temp_Enumeration)
            BS_Enumeration.DataSource = Temp_Enumeration.ParentClass.Enumeration
            Bind_Enumerations.BindingSource = BS_Enumeration
            Bind_Enumerations.Visible = True
        ElseIf TypeOf D Is VbNET.Module Then
            Temp_Enumeration.ParentModule = D
            Temp_Enumeration.ParentName = D.name
            Temp_Enumeration.ParentModule.Add_Enumeration(Temp_Enumeration)
            BS_Enumeration.DataSource = Temp_Enumeration.ParentModule.Enumeration
            Bind_Enumerations.BindingSource = BS_Enumeration
            Bind_Enumerations.Visible = True
        ElseIf TypeOf D Is VbNET.Structure Then
            Temp_Enumeration.ParentStructure = D
            Temp_Enumeration.ParentName = D.name
            Temp_Enumeration.ParentStructure.Add_Enumeration(Temp_Enumeration)
            BS_Enumeration.DataSource = Temp_Enumeration.ParentStructure.Enumeration
            Bind_Enumerations.BindingSource = BS_Enumeration
            Bind_Enumerations.Visible = True
        End If
        Enumeration_Btn_New.RaiseClick()
    End Sub
#End Region
#Region "|ON | |02.00.01| <Enumeration> <FileManager> [Preview]"
    Private Sub Enumeration_Btn_Preview_Click(sender As Object, e As EventArgs) Handles Enumeration_Btn_Preview.Click
        Dim TempMember As New List(Of VbNET.Enumeration.Member)
        TempMember = Temp_Enumeration.Members
        Temp_Enumeration = New VbNET.Enumeration(Enumeration_Name.Text, TempMember,, VbNET.String_ToAccessModifiers(Enumeration_AccessModifier.Text),
Enumeration_Shadows.Value,, Enumeration_ID.Value,,,)
        Temp_Enumeration.PrintStatement(Enumeration_Print_VB,
                                        Enumeration_Print_C,
                                        Enumeration_Print_F,
                                        Enumeration_Print_Python,
                                        Enumeration_Print_JS,
                                        Enumeration_Enable.Value)
        Property_Enumeration.SelectedObject = Temp_Enumeration
    End Sub
#End Region
#Region "|ON | |02.00.02| <Enumeration> <FileManager> [New]"
    Private Sub Enumeration_Btn_New_Click(sender As Object, e As EventArgs) Handles Enumeration_Btn_New.Click
        Temp_Enumeration = New VbNET.Enumeration
        Enumeration_AccessModifier.Text = "Public"
        Enumeration_CategoryID.Value = 0
        Enumeration_DataType.Text = ""
        Enumeration_Description.Text = ""
        Enumeration_Enable.Value = True
        Enumeration_Members.Items.Clear()
        Enumeration_Member_Name.Text = ""
        Enumeration_Member_Summary.Text = ""
        Enumeration_Name.Text = ""
        Enumeration_Shadows.Value = False
        Enumeration_Summary_AuthorEmail.Text = My.Settings.AuthorEmail
        Enumeration_Summary_AuthorName.Text = My.Settings.AuthorName
        Enumeration_Summary_AuthorUrl.Text = My.Settings.AuthorUrl
        Enumeration_Summary_ContributorEmail.Text = ""
        Enumeration_Summary_ContributorName.Text = ""
        Enumeration_Summary_ContributorUrl.Text = ""
        Enumeration_Summary_Example.Text = ""
        Enumeration_Summary_Note.Text = ""
        Enumeration_Summary_Remark.Text = ""
        Enumeration_Summary_Rights.Text = ""
        Enumeration_Summary_Rights.Text = My.Settings.SummaryRights
        Enumeration_Summary_Rules.Text = ""
        Enumeration_Summary_Syntax.Text = ""
        Enumeration_Summary_Usage.Text = ""
    End Sub
#End Region
#Region "|ON | |02.00.03| <Enumeration> <FileManager> [Open]"
    Private Sub Enumeration_Btn_Open_Click(sender As Object, e As EventArgs) Handles Enumeration_Btn_Open.Click
        Dim Ofd As New OpenFileDialog
        With Ofd
            .Filter = "Enumeration Statement (*.Enumeration)|*.Enumeration|All Files (*.*)|*.*"
            If .ShowDialog = DialogResult.OK Then
                Try
                    Temp_Enumeration.Open(.FileName)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End With
        Property_Enumeration.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |02.00.04| <Enumeration> <FileManager> [Save]"
    Private Sub Enumeration_Btn_Save_Click(sender As Object, e As EventArgs) Handles Enumeration_Btn_Save.Click
        If Not IsNothing(Temp_Enumeration) Then
            If Temp_Enumeration.Name <> "" Then
                Dim F = Temp_Enumeration.Save().Output
                Temp_Enumeration.XmlFile = F.Target
            End If
        End If
        Property_Enumeration.RefreshPropertyValues()
    End Sub
#End Region
#End Region
#Region "|ON |1|02.01| <Enumeration> [Constructor]{25}"
#Region "|ON |1|02.01.00| <Enumeration> <Constructor> [Statement]{4}"
#Region "|ON | |02.01.00.00| <Enumeration> <Constructor> <Statement> [Enable|Boolean]"
    Private Sub Enumeration_Enable_ValueChanged(sender As Object, e As EventArgs) Handles Enumeration_Enable.ValueChanged
        If Not IsNothing(Temp_Enumeration) Then
            Temp_Enumeration.Enable = Enumeration_Enable.Value
        End If
        Property_Enumeration.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |02.01.00.01| <Enumeration> <Constructor> <Statement> [ID|Integer]"
    Private Sub Enumeration_ID_ValueChanged(sender As Object, e As EventArgs) Handles Enumeration_ID.ValueChanged
        If Not IsNothing(Temp_Enumeration) Then
            Temp_Enumeration.ID = Enumeration_ID.Value
        End If
        Property_Enumeration.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |02.01.00.02| <Enumeration> <Constructor> <Statement> [CategoryID|Integer]"
    Private Sub Enumeration_CategoryID_ValueChanged(sender As Object, e As EventArgs) Handles Enumeration_CategoryID.ValueChanged
        If Not IsNothing(Temp_Enumeration) Then
            Temp_Enumeration.RegionCategory = Enumeration_CategoryID.Value
        End If
        Property_Enumeration.RefreshPropertyValues()
    End Sub
#End Region
#Region "|OFF|X|02.01.00.03| <Enumeration> <Constructor> <Statement> [Parent]"
    Private Sub Enumeration_Parent_TextChanged(sender As Object, e As EventArgs) Handles Enumeration_Parent.TextChanged

    End Sub
#End Region
#End Region
#Region "|ON | |02.01.01| <Enumeration> <Constructor> [Enumeration]{4}"
#Region "|ON | |02.01.01.00| <Enumeration> <Constructor> <Enumeration> [AccessModifier]"
    Private Sub Enumeration_AccessModifier_TextChanged(sender As Object, e As EventArgs) Handles Enumeration_AccessModifier.TextChanged
        If Not IsNothing(Temp_Enumeration) Then
            Temp_Enumeration.AccessModifier = VbNET.String_ToAccessModifiers(Enumeration_AccessModifier.Text)
        End If
        Property_Enumeration.RefreshPropertyValues()
    End Sub

#End Region
#Region "|ON | |02.01.01.01| <Enumeration> <Constructor> <Enumeration> [Name]"
    Private Sub Enumeration_Name_TextChanged(sender As Object, e As EventArgs) Handles Enumeration_Name.TextChanged
        If Not IsNothing(Temp_Enumeration) Then
            Temp_Enumeration.Name = Enumeration_Name.Text
        End If
        Property_Enumeration.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |02.01.01.02| <Enumeration> <Constructor> <Enumeration> [DataType]"
    Private Sub Enumeration_DataType_TextChanged(sender As Object, e As EventArgs) Handles Enumeration_DataType.TextChanged
        If Not IsNothing(Temp_Enumeration) Then
            Temp_Enumeration.DataType = Enumeration_DataType.Text
        End If
        Property_Enumeration.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |02.01.01.03| <Enumeration> <Constructor> <Enumeration> [Shadows]"
    Private Sub Enumeration_Shadows_ValueChanged(sender As Object, e As EventArgs) Handles Enumeration_Shadows.ValueChanged
        If Not IsNothing(Temp_Enumeration) Then
            Temp_Enumeration.Shadows = Enumeration_Shadows.Value
        End If
        Property_Enumeration.RefreshPropertyValues()
    End Sub
#End Region
#End Region
#Region "|ON | |02.01.02| <Enumeration> <Constructor> [Summary]{14}"
#Region "|ON | |02.01.02.00| <Enumeration> <Constructor> <Summary> [Description]"
    Private Sub Enumeration_Description_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Enumeration_Description.TextChanged
        If Not IsNothing(Temp_Enumeration) Then
            Temp_Enumeration.Description = Enumeration_Description.Text
        End If
        Property_Enumeration.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |02.01.02.01| <Enumeration> <Constructor> <Summary> [Usage]"
    Private Sub Enumeration_Summary_Usage_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Enumeration_Summary_Usage.TextChanged
        If Not IsNothing(Temp_Enumeration) Then
            Temp_Enumeration.Usage = Enumeration_Summary_Usage.Text
        End If
        Property_Enumeration.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |02.01.02.02| <Enumeration> <Constructor> <Summary> [Remark]"
    Private Sub Enumeration_Summary_Remark_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Enumeration_Summary_Remark.TextChanged
        If Not IsNothing(Temp_Enumeration) Then
            Temp_Enumeration.Remarks = Enumeration_Summary_Remark.Text
        End If
        Property_Enumeration.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |02.01.02.03| <Enumeration> <Constructor> <Summary> [Example]"
    Private Sub Enumeration_Summary_Example_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Enumeration_Summary_Example.TextChanged
        If Not IsNothing(Temp_Enumeration) Then
            Temp_Enumeration.Example = Enumeration_Summary_Example.Text
        End If
        Property_Enumeration.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |02.01.02.04| <Enumeration> <Constructor> <Summary> [Note]"
    Private Sub Enumeration_Summary_Note_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Enumeration_Summary_Note.TextChanged
        If Not IsNothing(Temp_Enumeration) Then
            Temp_Enumeration.Note = Enumeration_Summary_Note.Text
        End If
        Property_Enumeration.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |02.01.02.05| <Enumeration> <Constructor> <Summary> [Rules]"
    Private Sub Enumeration_Summary_Rules_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Enumeration_Summary_Rules.TextChanged
        If Not IsNothing(Temp_Enumeration) Then
            Temp_Enumeration.Rules = Enumeration_Summary_Rules.Text
        End If
        Property_Enumeration.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |02.01.02.06| <Enumeration> <Constructor> <Summary> [Syntax]"
    Private Sub Enumeration_Summary_Syntax_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Enumeration_Summary_Syntax.TextChanged
        If Not IsNothing(Temp_Enumeration) Then
            Temp_Enumeration.Syntax = Enumeration_Summary_Syntax.Text
        End If
        Property_Enumeration.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |02.01.02.07| <Enumeration> <Constructor> <Summary> [Rights]"
    Private Sub Enumeration_Summary_Rights_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Enumeration_Summary_Rights.TextChanged
        If Not IsNothing(Temp_Enumeration) Then
            Temp_Enumeration.Rights = Enumeration_Summary_Rights.Text
        End If
        Property_Enumeration.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |02.01.02.08| <Enumeration> <Constructor> <Summary> [AuthorName]"
    Private Sub Enumeration_Summary_AuthorName_TextChanged(sender As Object, e As EventArgs) Handles Enumeration_Summary_AuthorName.TextChanged
        If Not IsNothing(Temp_Enumeration) Then
            Temp_Enumeration.AuthorName = Enumeration_Summary_AuthorName.Text
        End If
        Property_Enumeration.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |02.01.02.09| <Enumeration> <Constructor> <Summary> [AuthorEmail]"
    Private Sub Enumeration_Summary_AuthorEmail_TextChanged(sender As Object, e As EventArgs) Handles Enumeration_Summary_AuthorEmail.TextChanged
        If Not IsNothing(Temp_Enumeration) Then
            Temp_Enumeration.AuthorEmail = Enumeration_Summary_AuthorEmail.Text
        End If
        Property_Enumeration.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |02.01.02.10| <Enumeration> <Constructor> <Summary> [AuthorUrl]"
    Private Sub Enumeration_Summary_AuthorUrl_TextChanged(sender As Object, e As EventArgs) Handles Enumeration_Summary_AuthorUrl.TextChanged
        If Not IsNothing(Temp_Enumeration) Then
            Temp_Enumeration.AuthorUri = Enumeration_Summary_AuthorUrl.Text
        End If
        Property_Enumeration.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |02.01.02.11] <Enumeration> <Constructor> <Summary> [ContributorName]"
    Private Sub Enumeration_Summary_ContributorName_TextChanged(sender As Object, e As EventArgs) Handles Enumeration_Summary_ContributorName.TextChanged
        If Not IsNothing(Temp_Enumeration) Then
            Temp_Enumeration.ContributorName = Enumeration_Summary_ContributorName.Text
        End If
        Property_Enumeration.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |02.01.02.12] <Enumeration> <Constructor> <Summary> [ContributorEmail]"
    Private Sub Enumeration_Summary_ContributorEmail_TextChanged(sender As Object, e As EventArgs) Handles Enumeration_Summary_ContributorEmail.TextChanged
        If Not IsNothing(Temp_Enumeration) Then
            Temp_Enumeration.ContributorEmail = Enumeration_Summary_ContributorEmail.Text
        End If
        Property_Enumeration.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |02.01.02.13] <Enumeration> <Constructor> <Summary> [ContributorUrl]"
    Private Sub Enumeration_Summary_ContributorUrl_TextChanged(sender As Object, e As EventArgs) Handles Enumeration_Summary_ContributorUrl.TextChanged
        If Not IsNothing(Temp_Enumeration) Then
            Temp_Enumeration.ContributorUri = Enumeration_Summary_ContributorUrl.Text
        End If
        Property_Enumeration.RefreshPropertyValues()
    End Sub
#End Region
#End Region
#Region "|ON |1|02.01.03| <Enumeration> <Constructor> [Members]{2}"
#Region "|ON | |02.01.03.00| <Enumeration> <Constructor> <Members> [Add]"
    Private Sub Enumeration_Btn_Add_Member_Click(sender As Object, e As EventArgs) Handles Enumeration_Btn_Add_Member.Click
        Dim Mem As New VbNET.Enumeration.Member(Enumeration_Member_Name.Text, Enumeration_Member_DefaultValue.Text, Enumeration_Member_Summary.Text)
        Enumeration_Members.Items.Add(AddMember(Temp_Enumeration.Members, Mem))
        'Quantity_Member.Value += 1
        Property_Enumeration.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |02.01.03.01| <Enumeration> <Constructor> <Members> [Remove]"
    Private Sub Enumeration_Btn_Remove_Member_Click(sender As Object, e As EventArgs) Handles Enumeration_Btn_Remove_Member.Click
        Dim Mem As New VbNET.Enumeration.Member(Enumeration_Member_Name.Text, Enumeration_Member_DefaultValue.Text, Enumeration_Member_Summary.Text)
        Enumeration_Members.Items.Remove(RemoveMember(Temp_Enumeration.Members, Mem))
        ' If Quantity_Member.Value - 1 < 0 Then
        ' Quantity_Member.Value = 0
        ' Else
        '  Quantity_Member.Value -= 1
        ' End If
        Property_Enumeration.RefreshPropertyValues()
    End Sub
#End Region
#Region "|OFF|X|02.01.03.02| <Enumeration> <Constructor> <Members> [SelectedIndexChanged]"
    Private Sub Enumeration_Members_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Enumeration_Members.SelectedIndexChanged

    End Sub


#End Region
#End Region
#End Region
#End Region
    Private Sub BS_CurrentChanged(sender As Object, e As EventArgs) Handles BS_Enumeration.CurrentChanged
        Read_Enumeration(BS_Enumeration.Current)

    End Sub


End Class
