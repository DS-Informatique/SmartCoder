Imports System.Windows.Forms

Public Class VbNET_Structure

    Dim T_Property As VbNET_Property
    Dim T_Enumeration As VbNET_Enumeration
    Dim T_Sub As VbNET_Sub
    Dim T_Function As VbNET_Function
    Dim T_Runtime As VbNET_Runtime

#Region "Runtime"
    Public Temp_Runtime As New VbNET.Runtime
    Private _ActiveParent As Object
    Public Property ActiveParent() As Object
        Get
            Return _ActiveParent
        End Get
        Set(ByVal value As Object)
            If Not IsNothing(value) Then
                If IsNothing(Temp_Structure) Then
                    Temp_Structure = New VbNET.Structure
                End If

                If TypeOf value Is VbNET.Class Then
                    Structure_Parent.Text = value.Name
                    Temp_Structure.ParentClass = value


                ElseIf TypeOf value Is VbNET.Module Then
                    Structure_Parent.Text = value.name
                    Temp_Structure.ParentModule = value
                    Dim T As VbNET.Module
                    T = value
                    BS_Structure.DataSource = T.Structure
                    Bind_Structure.BindingSource = BS_Structure
                End If
            End If
            _ActiveParent = value
        End Set
    End Property
#End Region
    Private Sub Btn_Refresh_Click(sender As Object, e As EventArgs) Handles Btn_Refresh.Click
        RefreshParents(Structure_Parent)
    End Sub
    Public Sub Initializor()
        If IsNothing(VirtualClass) Then
            VirtualClass = New VbNET.Class("VirtualClass")
        End If

        'Structure_Parent.SelectedIndex = 0
    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Initializor()
        RefreshParents(Structure_Parent)

    End Sub
    Public Sub OpenStatement(ByVal Statement As VbNET.Structure)

        ' This call is required by the designer.
        'InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Initializor()
        Temp_Structure = Statement
        Read_Structure(Statement)
    End Sub
    Public Sub Read_Structure(ByRef Statement As VbNET.Structure)
        If Not IsNothing(Statement) Then
            With Statement

                Structure_AccessModifier.Text = VbNET.AccessModifiers_ToString(.AccessModifier)
                ' Structure_AttributeList_Browsable.Value = .Browsable
                'Structure_Attribute_Category.Text = .Category
                'Structure_Attribute_DefaultValue.Text = .DefaultValue
                'Structure_Attribute_Deserializable.Value = .Deserializable
                'Structure_Attribute_Editor.Text = .Editor
                'Structure_Attribute_NonSerialized.Value = .NonSerialized
                'Structure_Attribute_RelatedImageList.Text = .RelatedImageList
                'Structure_Attribute_Serializable.Value = .Serializable
                'Structure_Attribute_XmlIgnore.Value = .XmlIgnore
                'Structure_Attribute_XmlInclude.Value = .XmlInclude
                'Structure_Attribute_XmlRoot.Text = .XmlRoot
                Structure_CategoryID.Value = .RegionCategory
                'Structure_Default.Value = .Default
                Structure_Description.Text = .Description
                Structure_Enable.Value = .Enable
                'Structure_GetStatement.Text = .GetStatement
                Structure_ID.Value = .ID
                Structure_Name.Text = .Name
                'Read_Parameters(Structure_ParamList, .ParameterList)
                'Read_Members(Structure_Members, .Members)
                If Not IsNothing(.ParentClass) Then
                    Structure_Parent.Text = .ParentClass.ClassName
                ElseIf Not IsNothing(.ParentModule) Then
                    Structure_Parent.Text = .ParentModule.Name
                    ' ElseIf Not IsNothing(.ParentStructure) Then
                    '    Structure_Parent.Text = .ParentStructure.Name
                Else
                    Structure_Parent.Text = VirtualClass.ClassName
                End If
                Structure_Print_C.Text = .C
                Structure_Print_F.Text = .F
                Structure_Print_JS.Text = .JavaScript
                Structure_Print_Python.Text = .Python
                Structure_Print_VB.Text = .VB
                Property_Structure.SelectedObject = Statement
                'Structure_PropertyModifier.Text = VbNET.PropertyModifiers_ToString(.PropertyModifier)
                'Structure_ReadOnly.Value = .ReadOnly
                'Structure_Required.Value = .Required
                'Structure_ReturnType.Text = .ReturnType
                'Structure_Statement.Text = .Statement
                Structure_Shadows.Value = .Shadows
                'Structure_Shared.Value = .Shared
                Structure_Summary_AuthorEmail.Text = .AuthorEmail
                Structure_Summary_AuthorName.Text = .AuthorName
                Structure_Summary_AuthorUrl.Text = .AuthorUri
                Structure_Summary_ContributorEmail.Text = .ContributorEmail
                Structure_Summary_ContributorName.Text = .ContributorName
                Structure_Summary_ContributorUrl.Text = .ContributorUri
                Structure_Summary_Example.Text = .Example
                Structure_Summary_Note.Text = .Note
                Structure_Summary_Remark.Text = .Remarks
                Structure_Summary_Rights.Text = .Rights
                Structure_Summary_Rules.Text = .Rules
                ' Structure_Summary_Syntax.Text = .Syntax
                Structure_Summary_Usage.Text = .Usage
                ' Structure_Variable_AccessModifier.Text = VbNET.AccessModifiers_ToString(.Variable_AccessModifier)
                ' Structure_Variable_Name.Text = .Variable_Name
                'Structure_Variable_ReturnType.Text = .Variable_ReturnType
                'Structure_WriteOnly.Value = .WriteOnly

            End With

        End If
    End Sub
    Private Sub VbNET_Structure_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshParents(Structure_Parent, False, True)
        Structure_Parent.SelectedIndex = 0
        T_Property = New VbNET_Property
        T_Property.Dock = DockStyle.Fill
        Panel_Property.Controls.Add(T_Property)
        T_Enumeration = New VbNET_Enumeration
        T_Enumeration.Dock = DockStyle.Fill
        Panel_Enumeration.Controls.Add(T_Enumeration)
        T_Sub = New VbNET_Sub
        T_Sub.Dock = DockStyle.Fill
        Panel_Sub.Controls.Add(T_Sub)
        T_Function = New VbNET_Function
        T_Function.Dock = DockStyle.Fill
        Panel_Function.Controls.Add(T_Function)
        T_Runtime = New VbNET_Runtime
        T_Runtime.Dock = DockStyle.Fill
        Panel_Runtime.Controls.Add(T_Runtime)

        T_Property.Property_Parent.Text = Temp_Structure.Name
        T_Property.ActiveParent = Temp_Structure

        T_Enumeration.Enumeration_Parent.Text = Temp_Structure.Name
        T_Enumeration.ActiveParent = Temp_Structure

        T_Sub.Sub_Parent.Text = Temp_Structure.Name
        T_Sub.ActiveParent = Temp_Structure

        T_Function.Function_Parent.Text = Temp_Structure.Name
        T_Function.ActiveParent = Temp_Structure

        T_Runtime.Runtime_Parent.Text = Temp_Structure.Name
        T_Runtime.ActiveParent = Temp_Structure
    End Sub

#Region "|ON |3|03| [Structure]{95}"
#Region "|ON | |03.00| <Structure> [FileManager]{5}"
#Region "|ON | |03.00.00| <Structure> <FileManager> [Add]"
    Private Sub Structure_Btn_Add_Click(sender As Object, e As EventArgs) Handles Structure_Btn_Add.Click
        Structure_ID.Value += 1
        Dim D = ActiveParent 'Property_Parent.SelectedItem(0).tag
        If TypeOf D Is VbNET.Class Then
            Temp_Structure.ParentClass = D
            Temp_Structure.ParentName = D.name
            Temp_Structure.ParentClass.Add_Structure(Temp_Structure)
            BS_Structure.DataSource = Temp_Structure.ParentClass.Structure
            Bind_Structure.BindingSource = BS_Structure
            Bind_Structure.Visible = True

        ElseIf TypeOf D Is VbNET.Module Then
            Temp_Structure.ParentModule = D
            Temp_Structure.ParentName = D.name
            Temp_Structure.ParentModule.Add_Structure(Temp_Structure)
            BS_Structure.DataSource = Temp_Structure.ParentModule.Structure
            Bind_Structure.BindingSource = BS_Structure
            Bind_Structure.Visible = True
        End If

        ListParent.Add(Temp_Structure)
        RefreshParents(Structure_Parent, False, True)

        Structure_Btn_New.RaiseClick()
    End Sub
#End Region
#Region "|ON | |03.00.01| <Structure> <FileManager> [Preview]"
    Private Sub Structure_Btn_Preview_Click(sender As Object, e As EventArgs) Handles Structure_Btn_Preview.Click
        If Not IsNothing(Temp_Structure) Then
            If Not IsNothing(ActiveParent) Then
                If TypeOf ActiveParent Is VbNET.Class Then
                    Temp_Structure.ParentClass = ActiveParent
                ElseIf TypeOf ActiveParent Is vbnet.Module Then
                    Temp_Structure.ParentModule = ActiveParent
                End If
            End If
            Temp_Structure.PrintStatement(Structure_Print_VB,
                                         Structure_Print_C,
                                         Structure_Print_F,
                                         Structure_Print_Python,
                                         Structure_Print_JS,
                                         Structure_Enable.Value)

        End If
    End Sub
#End Region
#Region "|ON | |03.00.02| <Structure> <FileManager> [New]"
    Private Sub Structure_Btn_New_Click(sender As Object, e As EventArgs) Handles Structure_Btn_New.Click
        Temp_Structure = New VbNET.Structure
        Dim P = InputBox("Enter a valid name witout spaces", "Please enter the name of the structure.", "TempStructure")
        Structure_AccessModifier.Text = "Public"
        Structure_CategoryID.Value = 0
        Structure_Enable.Value = True
        Structure_Implements.Text = ""
        Structure_Name.Text = Structure_Parent.Text & "." & P
        Structure_Shadows.Value = False
        Temp_Structure.Name = Structure_Name.Text
        ListParent.Add(Temp_Structure)
    End Sub
#End Region
#Region "|ON | |03.00.03| <Structure> <FileManager> [Open]"
    Private Sub Structure_Btn_Open_Click(sender As Object, e As EventArgs) Handles Structure_Btn_Open.Click
        Dim Ofd As New OpenFileDialog
        With Ofd
            .Filter = "VbNet Structure Statement (*.Structure)|*.Structure|All Files (*.*)|*.*"
            If .ShowDialog = DialogResult.OK Then
                Try
                    Temp_Structure.Open(.FileName)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End With
        Property_Structure.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |03.00.04| <Structure> <FileManager> [Save]"
    Private Sub Structure_Btn_Save_Click(sender As Object, e As EventArgs) Handles Structure_Btn_Save.Click
        If Not IsNothing(Temp_Structure) Then
            If Temp_Structure.Name <> "" Then
                Dim F = Temp_Structure.Save().Output
                Temp_Structure.XmlFile = F.Target
            End If
        End If
        Property_Structure.RefreshPropertyValues()
    End Sub
#End Region
#End Region
#Region "|ON |7|03.01| <Structure> [Constructor]{251}"
#Region "|ON |1|03.01.00| <Structure> <Constructor> [Statement]{4}"
#Region "|ON | |03.01.00.00| <Structure> <Constructor> <Statement> [Enable|Boolean]"
    Private Sub Structure_Enable_ValueChanged(sender As Object, e As EventArgs) Handles Structure_Enable.ValueChanged
        If Not IsNothing(Temp_Structure) Then
            Temp_Structure.Enable = Structure_Enable.Value
        End If
    End Sub
#End Region
#Region "|ON | |03.01.00.01| <Structure> <Constructor> <Statement> [ID]"
    Private Sub Structure_ID_ValueChanged(sender As Object, e As EventArgs) Handles Structure_ID.ValueChanged
        If Not IsNothing(Temp_Structure) Then
            Temp_Structure.ID = Structure_ID.Value
        End If
        Property_Structure.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |03.01.00.02| <Structure> <Constructor> <Statement> [CategoryID]"
    Private Sub Structure_CategoryID_ValueChanged(sender As Object, e As EventArgs) Handles Structure_CategoryID.ValueChanged
        If Not IsNothing(Temp_Structure) Then
            Temp_Structure.RegionCategory = Structure_CategoryID.Value
        End If
        Property_Structure.RefreshPropertyValues()
    End Sub
#End Region
#Region "|OFF|X|03.01.00.03| <Structure> <Constructor> <Statement> [Parent]"
    Private Sub Structure_Parent_TextChanged(sender As Object, e As EventArgs) Handles Structure_Parent.TextChanged
    End Sub
#End Region
#End Region
#Region "|ON | |03.01.01| <Structure> <Constructor> [Structure]{5}"
#Region "|ON | |03.01.01.00| <Structure> <Constructor> <Structure> [AccessModifier]"
    Private Sub Structure_AccessModifier_TextChanged(sender As Object, e As EventArgs) Handles Structure_AccessModifier.TextChanged
        If Not IsNothing(Temp_Structure) Then
            Temp_Structure.AccessModifier = VbNET.String_ToAccessModifiers(Structure_AccessModifier.Text)
        End If
    End Sub

#End Region
#Region "|ON | |03.01.01.01| <Structure> <Constructor> <Structure> [Name]"
    Private Sub Structure_Name_TextChanged(sender As Object, e As EventArgs) Handles Structure_Name.TextChanged
        If Not IsNothing(Temp_Structure) Then
            Temp_Structure.Name = Structure_Name.Text
        Else
            Temp_Structure = New VbNET.Structure(Structure_Name.Text)
        End If
    End Sub
#End Region
#Region "|ON | |03.01.01.02| <Structure> <Constructor> <Structure> [Implements]"
    Private Sub Structure_Implements_TextChanged(sender As Object, e As EventArgs) Handles Structure_Implements.TextChanged
        If Not IsNothing(Temp_Structure) Then
            Temp_Structure.Implements = Structure_Implements.Text
        End If
    End Sub
#End Region
#Region "|ON | |03.01.01.03| <Structure> <Constructor> <Structure> [Shadows]"
    Private Sub Structure_Shadows_ValueChanged(sender As Object, e As EventArgs) Handles Structure_Shadows.ValueChanged
        If Not IsNothing(Temp_Structure) Then
            Temp_Structure.Shadows = Structure_Shadows.Value
        End If
    End Sub
#End Region
#Region "|ON | |03.01.01.04| <Structure> <Constructor> <Structure> [Partial]"
    Private Sub Structure_Partial_ValueChanged(sender As Object, e As EventArgs) Handles Structure_Partial.ValueChanged
        If Not IsNothing(Temp_Structure) Then
            Temp_Structure.Partial = Structure_Partial.Value
        End If
    End Sub
#End Region
#End Region
#Region "|ON | |03.02.08| <Structure> <Constructor> [Summary]{14}"
#Region "|ON | |03.02.08.00| <Structure> <Constructor> <Summary> [Description]"
    Private Sub Structure_Description_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Structure_Description.TextChanged
        If Not IsNothing(Temp_Structure) Then
            Temp_Structure.Description = Structure_Description.Text
        End If
        Property_Structure.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |03.02.08.01| <Structure> <Constructor> <Summary> [Usage]"
    Private Sub Structure_Summary_Usage_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Structure_Summary_Usage.TextChanged
        If Not IsNothing(Temp_Structure) Then
            Temp_Structure.Usage = Structure_Summary_Usage.Text
        End If
        Property_Structure.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |03.02.08.02| <Structure> <Constructor> <Summary> [Remark]"
    Private Sub Structure_Summary_Remark_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Structure_Summary_Remark.TextChanged
        If Not IsNothing(Temp_Structure) Then
            Temp_Structure.Remarks = Structure_Summary_Remark.Text
        End If
        Property_Structure.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |03.02.08.03| <Structure> <Constructor> <Summary> [Example]"
    Private Sub Structure_Summary_Example_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Structure_Summary_Example.TextChanged
        If Not IsNothing(Temp_Structure) Then
            Temp_Structure.Example = Structure_Summary_Example.Text
        End If
        Property_Structure.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |03.02.08.04| <Structure> <Constructor> <Summary> [Note]"
    Private Sub Structure_Summary_Note_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Structure_Summary_Note.TextChanged
        If Not IsNothing(Temp_Structure) Then
            Temp_Structure.Note = Structure_Summary_Note.Text
        End If
        Property_Structure.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |03.02.08.05| <Structure> <Constructor> <Summary> [Rules]"
    Private Sub Structure_Summary_Rules_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Structure_Summary_Rules.TextChanged
        If Not IsNothing(Temp_Structure) Then
            Temp_Structure.Rules = Structure_Summary_Rules.Text
        End If
        Property_Structure.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |03.02.08.06| <Structure> <Constructor> <Summary> [Syntax]"
    Private Sub FastColoredTextBox13_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles FastColoredTextBox13.TextChanged
        If Not IsNothing(Temp_Structure) Then
            Temp_Structure.Syntax = FastColoredTextBox13.Text
        End If
        Property_Structure.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |03.02.08.07| <Structure> <Constructor> <Summary> [Rights]"
    Private Sub Structure_Summary_Rights_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Structure_Summary_Rights.TextChanged
        If Not IsNothing(Temp_Structure) Then
            Temp_Structure.Rights = Structure_Summary_Rights.Text
        End If
        Property_Structure.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |03.02.08.08| <Structure> <Constructor> <Summary> [AuthorName]"
    Private Sub Structure_Summary_AuthorName_TextChanged(sender As Object, e As EventArgs) Handles Structure_Summary_AuthorName.TextChanged
        If Not IsNothing(Temp_Structure) Then
            Temp_Structure.AuthorName = Structure_Summary_AuthorName.Text
        End If
        Property_Structure.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |03.02.08.09| <Structure> <Constructor> <Summary> [AuthorEmail]"
    Private Sub Structure_Summary_AuthorEmail_TextChanged(sender As Object, e As EventArgs) Handles Structure_Summary_AuthorEmail.TextChanged
        If Not IsNothing(Temp_Structure) Then
            Temp_Structure.AuthorEmail = Structure_Summary_AuthorEmail.Text
        End If
        Property_Structure.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |03.02.08.10| <Structure> <Constructor> <Summary> [AuthorUrl]"
    Private Sub Structure_Summary_AuthorUrl_TextChanged(sender As Object, e As EventArgs) Handles Structure_Summary_AuthorUrl.TextChanged
        If Not IsNothing(Temp_Structure) Then
            Temp_Structure.AuthorUri = Structure_Summary_AuthorUrl.Text
        End If
        Property_Structure.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |03.02.08.11| <Structure> <Constructor> <Summary> [ContributorName]"
    Private Sub Structure_Summary_ContributorName_TextChanged(sender As Object, e As EventArgs) Handles Structure_Summary_ContributorName.TextChanged
        If Not IsNothing(Temp_Structure) Then
            Temp_Structure.ContributorName = Structure_Summary_ContributorName.Text
        End If
        Property_Structure.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |03.02.08.12| <Structure> <Constructor> <Summary> [ContributorEmail]"
    Private Sub Structure_Summary_ContributorEmail_TextChanged(sender As Object, e As EventArgs) Handles Structure_Summary_ContributorEmail.TextChanged
        If Not IsNothing(Temp_Structure) Then
            Temp_Structure.ContributorEmail = Structure_Summary_ContributorEmail.Text
        End If
        Property_Structure.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |03.02.08.13| <Structure> <Constructor> <Summary> [ContributorName]"
    Private Sub Structure_Summary_ContributorUrl_TextChanged(sender As Object, e As EventArgs) Handles Structure_Summary_ContributorUrl.TextChanged
        If Not IsNothing(Temp_Structure) Then
            Temp_Structure.ContributorUri = Structure_Summary_ContributorUrl.Text
        End If
        Property_Structure.RefreshPropertyValues()
    End Sub


#End Region
#End Region
#End Region
#End Region
    Private Sub SchemaTree_Btn_Refresh_Click(sender As Object, e As EventArgs) Handles SchemaTree_Btn_Refresh.Click
        SchemaTree.Nodes.Clear()

        If IsNothing(Temp_Structure) Then
            Temp_Structure = New VbNET.Structure

        End If
        'Printing the nodes
        Dim NSub As New DevComponents.AdvTree.Node
        With NSub
            .Text = "<4> [Sub] {" & Temp_Structure.Sub.Count & "}"
            .ImageIndex = 4
        End With
        Dim NFunction As New DevComponents.AdvTree.Node
        With NFunction
            .Text = "<5> [Function] {" & Temp_Structure.Function.Count & "}"
            .ImageIndex = 5
        End With
        Dim NProperty As New DevComponents.AdvTree.Node
        With NProperty
            .Text = "<1> [Property] {" & Temp_Structure.Property.Count & "}"
            .ImageIndex = 1
        End With
        Dim NRuntime As New DevComponents.AdvTree.Node
        With NRuntime
            .Text = "<6> [Runtime] {" & Temp_Structure.Runtime.Count & "}"
            .ImageIndex = 6
        End With
        Dim NEnumeration As New DevComponents.AdvTree.Node
        With NEnumeration
            .Text = "<2> [Enumeration] {" & Temp_Structure.Enumeration.Count & "}"
            .ImageIndex = 2
        End With
        Dim NEvent As New DevComponents.AdvTree.Node
        With NEvent
            .Text = "Event"
            .ImageIndex = 10
        End With

        For Each Prop As VbNET.Property In Temp_Structure.Property
            Dim P As New DevComponents.AdvTree.Node
            With P
                .Name = Prop.Name
                .Tooltip = Prop.Description
                .Tag = Prop
                .ImageIndex = 1
            End With
            NProperty.Nodes.Add(P)
        Next
        For Each Prop As VbNET.Sub In Temp_Structure.Sub
            Dim P As New DevComponents.AdvTree.Node
            With P
                .Name = Prop.Name
                .Tooltip = Prop.Description
                .Tag = Prop
                .ImageIndex = 4
            End With
            NSub.Nodes.Add(P)
        Next
        For Each Prop As VbNET.Function In Temp_Structure.Function
            Dim P As New DevComponents.AdvTree.Node
            With P
                .Name = Prop.Name
                .Tooltip = Prop.Description
                .Tag = Prop
                .ImageIndex = 5
            End With
            NFunction.Nodes.Add(P)
        Next
        For Each Prop As VbNET.Runtime In Temp_Structure.Runtime
            Dim P As New DevComponents.AdvTree.Node
            With P
                .Name = Prop.Name
                .Tooltip = Prop.Description
                .Tag = Prop
                .ImageIndex = 6
            End With
            NRuntime.Nodes.Add(P)
        Next
        For Each Prop As VbNET.Enumeration In Temp_Structure.Enumeration
            Dim P As New DevComponents.AdvTree.Node
            With P
                .Name = Prop.Name
                .Tooltip = Prop.Description
                .Tag = Prop
                .ImageIndex = 2
            End With
            NEnumeration.Nodes.Add(P)
        Next
        For Each Prop As VbNET.Event In Temp_Structure.Event
            Dim P As New DevComponents.AdvTree.Node
            With P
                .Name = Prop.Name
                .Tooltip = Prop.Description
                .Tag = Prop
                .ImageIndex = 10
            End With
            NEvent.Nodes.Add(P)
        Next
        Dim NStr As New DevComponents.AdvTree.Node
        With NStr
            .Text = Temp_Structure.Name & " {" & Temp_Structure.Sub.Count + Temp_Structure.Function.Count + Temp_Structure.Runtime.Count + Temp_Structure.Event.Count + Temp_Structure.Property.Count & "}"
            .Name = Temp_Structure.Name
            .ImageIndex = 3
            .Tag = Temp_Structure
        End With
        NStr.Nodes.Add(NProperty)
        NStr.Nodes.Add(NEnumeration)
        NStr.Nodes.Add(NSub)
        NStr.Nodes.Add(NFunction)
        NStr.Nodes.Add(NRuntime)
        NStr.Nodes.Add(NEvent)

        SchemaTree.Nodes.Add(NStr)
        SchemaTree.ExpandAll()
    End Sub
End Class
