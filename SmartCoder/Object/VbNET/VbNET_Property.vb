Imports System.IO
Imports System.Windows.Forms

Public Class VbNET_Property

#Region "Runtime"
    Public Temp_Property As New VbNET.Property
    Private _ActiveParent As Object
    Public Property ActiveParent() As Object
        Get
            Return _ActiveParent
        End Get
        Set(ByVal value As Object)
            If Not IsNothing(value) Then
                If IsNothing(Temp_Property) Then
                    Temp_Property = New VbNET.Property
                End If
                If TypeOf value Is VbNET.Class Then
                    Property_Parent.Text = value.Name
                    Temp_Property.ParentClass = value
                    Dim T As VbNET.Class
                    T = value
                    BS_Property.DataSource = T.Properties
                    Bind_Property.BindingSource = BS_Property
                ElseIf TypeOf value Is VbNET.Structure Then
                    Property_Parent.Text = value.Name
                    Temp_Property.ParentStructure = value
                    Dim T As VbNET.Structure
                    T = value
                    BS_Property.DataSource = T.Property
                    Bind_Property.BindingSource = BS_Property
                ElseIf TypeOf value Is VbNET.Module Then
                    Property_Parent.Text = value.name
                    Temp_Property.ParentModule = value
                    Dim T As VbNET.Module
                    T = value
                    BS_Property.DataSource = T.Properties
                    Bind_Property.BindingSource = BS_Property
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
        'Property_Parent.SelectedIndex = 0
    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        RefreshParents(Property_Parent)
        Initializor()
    End Sub
    Public Sub OpenStatement(ByVal Prop As VbNET.Property)

        ' This call is required by the designer.
        ' InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        RefreshParents(Property_Parent)
        Initializor()
        Temp_Property = Prop
        ReadProperty(Prop)
    End Sub
    Public Sub RefreshData()
        Temp_Property = New VbNET.Property
        If Not IsNothing(VirtualClass) Then
            Temp_Property.ParentClass = VirtualClass
            Property_Parent.Text = VirtualClass.Text
        End If
        ReadProperty(Temp_Property)
        Me.Property_Property.SelectedObject = Temp_Property
    End Sub

#Region "|ON |1|01| [Property]{51}"
#Region "|ON | |01.00| <Property> [FileManager]{5}"
#Region "|ON | |01.00.00| <Property> <FileManager> [Add]"
    Private Sub Property_Btn_Add_Click(sender As Object, e As EventArgs) Handles Property_Btn_Add.Click
        'Quantity_Property.Value += 1
        Property_ID.Value += 1

        Temp_Property.VB = Property_Print_VB.Text
        Temp_Property.C = Property_Print_C.Text
        Temp_Property.F = Property_Print_F.Text
        Temp_Property.Python = Property_Print_Python.Text
        Temp_Property.JavaScript = Property_Print_JS.Text
        Temp_Property.Print_VB = New List(Of String)
        Temp_Property.Print_C = New List(Of String)
        Temp_Property.Print_F = New List(Of String)
        Temp_Property.Print_Python = New List(Of String)
        Temp_Property.Print_JavaScript = New List(Of String)
        For Each Line As String In Property_Print_VB.Lines
            Temp_Property.Print_VB.Add(Line)
        Next
        For Each Line As String In Property_Print_C.Lines
            Temp_Property.Print_C.Add(Line)
        Next
        For Each Line As String In Property_Print_F.Lines
            Temp_Property.Print_F.Add(Line)
        Next
        For Each Line As String In Property_Print_Python.Lines
            Temp_Property.Print_Python.Add(Line)
        Next
        For Each Line As String In Property_Print_JS.Lines
            Temp_Property.Print_JavaScript.Add(Line)
        Next
        Temp_Property.Name = Property_Name.Text
        Dim D = ActiveParent 'Property_Parent.SelectedItem(0).tag
        If TypeOf D Is VbNET.Class Then
            Temp_Property.ParentClass = D
            Temp_Property.ParentName = D.name
            Temp_Property.ParentClass.Add_Property(Temp_Property)
            BS_Property.DataSource = Temp_Property.ParentClass.Properties
            Bind_Property.BindingSource = BS_Property
            Bind_Property.Visible = True

        ElseIf TypeOf D Is VbNET.Module Then
            Temp_Property.ParentModule = D
            Temp_Property.ParentName = D.name
            Temp_Property.ParentModule.Add_Property(Temp_Property)
            BS_Property.DataSource = Temp_Property.ParentModule.Properties
            Bind_Property.BindingSource = BS_Property
            Bind_Property.Visible = True
        ElseIf TypeOf D Is VbNET.Structure Then
            Temp_Property.ParentStructure = D
            Temp_Property.ParentName = D.name
            Temp_Property.ParentStructure.Add_Property(Temp_Property)
            BS_Property.DataSource = Temp_Property.ParentStructure.Property
            Bind_Property.BindingSource = BS_Property
            Bind_Property.Visible = True
        End If
        AddReturnType(Temp_Property.ReturnType)
        If IsNothing(Temp_Property_Parameters) Then
            Temp_Property_Parameters = New List(Of VbNET.InnerStatement.ParameterList_Statement)
        End If
        For Each P As VbNET.InnerStatement.ParameterList_Statement In Temp_Property_Parameters
            AddReturnType(P.ParameterType)
        Next
        ' RefreshReturnType()
        Property_Property.RefreshPropertyValues()
        ' SchemaTree_Btn_Refresh.RaiseClick()
        Property_Btn_New.RaiseClick()
        BS_Property.DataSource = ActiveParent.Properties
        Bind_Property.BindingSource = BS_Property
    End Sub
#End Region
#Region "|ON | |01.00.01| <Property> <FileManager> [Preview]"
    Private Sub Property_Btn_Preview_Click(sender As Object, e As EventArgs) Handles Property_Btn_Preview.Click

        Dim Lt As New List(Of VbNET.InnerStatement.ParameterList_Statement)
        Lt = Temp_Property_Parameters
        Dim Ts As String = Property_ReturnType.Text
        If Not IsNothing(Property_Parent.SelectedItem) Then
            If Not IsNothing(Property_Parent.SelectedItem.tag) Then
                Dim D = Property_Parent.SelectedItem.tag
                If TypeOf D Is VbNET.Class Then
                    Temp_Property.ParentClass = D
                    Temp_Property.ParentName = D.name
                    'MsgBox("Class")

                ElseIf TypeOf D Is VbNET.Module Then
                    Temp_Property.ParentModule = D
                    Temp_Property.ParentName = D.name
                    ' MsgBox("Module")
                ElseIf TypeOf D Is VbNET.Structure Then
                    Temp_Property.ParentStructure = D
                    Temp_Property.ParentName = D.name
                    ' MsgBox("Structure")
                End If
            End If
        End If
        Temp_Property.ParentName = Property_Parent.Text
        Property_ReturnType.Text = ""
        Property_ReturnType.Text = Ts
        If Property_Attribute_Category.Text = "" Then
            Property_Attribute_Category.Text = "Info"
        Else
            Dim TC As String = Property_Attribute_Category.Text
            Property_Attribute_Category.Text = ""
            Property_Attribute_Category.Text = TC
        End If
        Temp_Property = New VbNET.Property(Property_Name.Text,
                                           Property_ReturnType.Text,
                                           Property_Attribute_Category.Text,
                                           Property_Required.Value,
                                           Property_ID.Value,
                                           Property_Attribute_DefaultValue.Text,
                                           Property_Shared.Value,
                                           Property_Shadows.Value,
                                           Property_WriteOnly.Value,
                                           Property_ReadOnly.Value,
                                           Property_Default.Value,
                                           VbNET.String_ToAccessModifiers(Property_AccessModifier.Text),
                                           VbNET.String_ToPropertyModifiers(Property_PropertyModifier.Text),
                                           Property_Variable_Name.Text,
                                           Property_Variable_ReturnType.Text,
                                           VbNET.String_ToAccessModifiers(Property_Variable_AccessModifier.Text),
                                           Property_GetStatement.Text,
                                           Property_SetStatement.Text,
                                           Property_AttributeList_Browsable.Value,
                                           Property_ReturnType.Text,
                                           Lt,
                                           Property_Enable.Value,
                                           Property_Description.Text,
                                           New VbNET.Attributelist(Property_Attribute_Category.Text,
                                                                   Property_Description.Text,
                                                                   Property_Attribute_DefaultValue.Text,
                                                                   Property_AttributeList_Browsable.Value,
                                                                   Property_Attribute_Deserializable.Value,
                                                                   Property_Attribute_Editor.Text,
                                                                   Property_Attribute_Serializable.Value,
                                                                   Property_Attribute_NonSerialized.Value,
                                                                   Property_Attribute_RelatedImageList.Text,
                                                                   Property_Attribute_XmlRoot.Text,
                                                                   Property_Attribute_XmlIgnore.Value,
                                                                   Property_Attribute_XmlInclude.Value),
                                           Property_Summary_AuthorName.Text,
                                           Property_Summary_AuthorEmail.Text,
                                           Property_Summary_AuthorUrl.Text,
                                           Property_Summary_ContributorName.Text,
                                           Property_Summary_ContributorEmail.Text,
                                           Property_Summary_ContributorUrl.Text,
                                           Property_Summary_Usage.Text,
                                           Property_Summary_Usage.Text,
                                           Property_Summary_Example.Text,
                                           Property_Summary_Note.Text,
                                           ,
                                           Property_Summary_Rights.Text)
        Temp_Property.Name = Property_Name.Text
        Temp_Property.StatementFormat = VbNET.Statement.Format.Property

        Temp_Property.PrintStatement(Property_Print_VB,
                                     Property_Print_C,
                                     Property_Print_F,
                                     Property_Print_Python,
                                     Property_Print_JS,
                                     Property_Enable.Value)
        Property_Property.SelectedObject = Temp_Property
    End Sub
#End Region
#Region "|ON | |01.00.02| <Property> <FileManager> [New]"
    Private Sub Property_Btn_New_Click(sender As Object, e As EventArgs) Handles Property_Btn_New.Click
        Temp_Property = New VbNET.Property
        Property_AccessModifier.Text = "Public"
        Property_AttributeList_Browsable.Value = True
        Property_Attribute_DefaultValue.Text = ""
        Property_Attribute_Deserializable.Value = False
        Property_Attribute_Editor.Text = ""
        Property_Attribute_NonSerialized.Value = False
        Property_Attribute_RelatedImageList.Text = ""
        Property_Attribute_Serializable.Value = False
        Property_Attribute_XmlIgnore.Value = False
        Property_Attribute_XmlInclude.Value = False
        Property_Attribute_XmlRoot.Text = ""
        Property_Default.Value = False
        Property_Description.Text = ""
        Property_Enable.Value = True
        Property_GetStatement.Text = ""
        Property_SetStatement.Text = ""
        Property_Name.Text = ""
        Property_ParamList.Items.Clear()
        Temp_Property_Parameters = New List(Of VbNET.InnerStatement.ParameterList_Statement)
        Property_Param_DefaultValue.Text = ""
        Property_Param_Modifier.Text = "ByVal"
        Property_Param_Name.Text = ""
        Property_Param_ReturnType.Text = "String"
        Property_Param_Summary.Text = ""
        Property_PropertyModifier.Text = ""
        Property_ReadOnly.Value = False
        Property_Required.Value = True
        Property_ReturnType.Text = "String"
        Property_Summary_Remark.Text = ""
        Property_Summary_Rights.Text = My.Settings.SummaryRights
        Property_Summary_Rules.Text = ""
        Property_Summary_Syntax.Text = "[ <attributelist> ] [ Default ] [ accessmodifier ]   
[ propertymodifiers ] [ Shared ] [ Shadows ] [ ReadOnly | WriteOnly ] [ Iterator ]  
Property name ( [ parameterlist ] ) [ As returntype ] [ Implements implementslist ]  
    [ <attributelist> ] [ accessmodifier ] Get  
        [ statements ]  
    End Get  
    [ <attributelist> ] [ accessmodifier ] Set ( ByVal value As returntype [, parameterlist ] )  
        [ statements ]  
    End Set  
End Property  
- or -  
[ <attributelist> ] [ Default ] [ accessmodifier ]   
[ propertymodifiers ] [ Shared ] [ Shadows ] [ ReadOnly | WriteOnly ]   
Property name ( [ parameterlist ] ) [ As returntype ] [ Implements implementslist ]"
        Property_Summary_Usage.Text = ""
        Property_Variable_AccessModifier.Text = "Private"
        Property_Variable_Name.Text = ""
        Property_Variable_ReturnType.Text = ""
        Property_WriteOnly.Value = False
        Property_Property.RefreshPropertyValues()
    End Sub

#End Region
#Region "|ON | |01.00.03| <Property> <FileManager> [Open]"
    Private Sub Property_Btn_Open_Click(sender As Object, e As EventArgs) Handles Property_Btn_Open.Click
        Dim Ofd As New OpenFileDialog
        With Ofd
            .Filter = "Property Statement (*.Property)|*.Property|All Files (*.*)|*.*"
            If .ShowDialog = DialogResult.OK Then
                Try
                    Temp_Property.Open(.FileName)
                    ReadProperty(Temp_Property)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End With
        Property_Property.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |01.00.04| <Property> <FileManager> [Save]"
    Private Sub Property_Btn_Save_Click(sender As Object, e As EventArgs) Handles Property_Btn_Save.Click
        Dim Test As New TestItem("Saving the property", "Loading the parameters")
        If Not IsNothing(Temp_Property) Then
            If Temp_Property.Name <> "" Then
                'Dim F = (Serializer.Serialize(Temp_Property).OutputString)
                'Temp_Property.XmlFile = F
                My.Settings.DefaultOuput = ""
                My.Settings.Save()

                If My.Settings.DefaultOuput.Length > 0 Then
                Else
                    Dim Str As String = ""
                    If Not IsNothing(Temp_Property.ParentStructure) Then
                        Str += Temp_Property.ParentStructure.Name
                    Else
                        If Not IsNothing(Temp_Property.ParentModule) Then
                            Str += Temp_Property.ParentModule.Name
                        Else
                            If Not IsNothing(Temp_Property.ParentClass) Then
                                Str += Temp_Property.ParentClass.Name
                            Else
                                If Not IsNothing(VirtualClass) Then
                                    Str += VirtualClass.Name
                                Else
                                    VirtualClass = New VbNET.[Class]("VirtualClass")
                                    Str += VirtualClass.Name
                                End If
                            End If
                        End If
                    End If
                    If Str = "" Then
                        Str = "VirtualClass"
                    End If
                    My.Settings.DefaultOuput = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Serialized Object\" & Str & "\" & Now.Year & "_" & Now.Month & "_" & Now.Day & "\"
                    My.Settings.Save()
                End If
                Test.Write("My.Settings.DefaultOutput = " & My.Settings.DefaultOuput)
                Dim DirPath As New DirectoryInfo(My.Settings.DefaultOuput)
                If DirPath.Exists = False Then
                    Try
                        DirPath.Create()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        Test.AddBug(ex, "Adding dir", "DirPath.Create()")

                        Test.Write("Error creating the dir : " & My.Settings.DefaultOuput)
                        Test.Write(Format_Error(ex))
                    End Try
                End If
                Try
                    Dim XmlTool As New Xml.Serialization.XmlSerializer(Temp_Property.GetType)
                    Test.AddParam("XmlTool", "Xml.Serialization.XmlSerializer", XmlTool)
                    Test.Write("XmlTool Serialize : " & My.Settings.DefaultOuput)
                Catch ex As Exception
                    Test.Status = Status.Broken
                    MsgBox(ex.Message)
                    Test.AddBug(ex, "Serializing", "XmlTool")
                    Test.Write(Format_Error(ex))
                End Try
                Try
                    Dim XmlTool As New Xml.Serialization.XmlSerializer(Temp_Property.GetType)

                    Dim Path As String = My.Settings.DefaultOuput & Temp_Property.Name & ".Property"
                    Dim StrWriter As New StreamWriter(Path)
                    XmlTool.Serialize(StrWriter, Temp_Property)
                    Dim Fi As New IO.FileInfo(Path)
                    Temp_Property.XmlFile = Fi.FullName
                    Property_Property.RefreshPropertyValues()
                    Test.Write("XmlTool Serialize To Path: " & Path)
                Catch ex As Exception
                    Test.Status = Status.Broken
                    MsgBox(ex.Message)
                    Test.AddBug(ex, "XmlTool Serialize To Path", "XmlTool")
                End Try


            End If
        End If
            ' Dim S As New ShowProperty(Test)
            ' S.Show()
            Property_Property.RefreshPropertyValues()
    End Sub
#End Region 'Modified 10/06/2019
#End Region
#Region "|ON |1|01.01| <Property> [Constructor]{19}"
#Region "|ON |1|01.01.00| <Property> <Constructor> [Statement]{6}"
#Region "|ON | |01.01.00.00| <Property> <Constructor> <Statement> [Enable|Boolean]"
    Private Sub Property_Enable_ValueChanged(sender As Object, e As EventArgs) Handles Property_Enable.ValueChanged
        If Not IsNothing(Temp_Property) Then
            Temp_Property.Enable = Property_Enable.Value
        End If
        Property_Property.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |01.01.00.01| <Property> <Constructor> <Statement> [ID]"
    Private Sub Property_ID_ValueChanged(sender As Object, e As EventArgs) Handles Property_ID.ValueChanged
        If Not IsNothing(Temp_Property) Then
            Temp_Property.ID = Property_ID.Value
        End If
        Property_Property.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |01.01.00.02| <Property> <Constructor> <Statement> [CategoryID]"
    Private Sub Property_CategoryID_ValueChanged(sender As Object, e As EventArgs) Handles Property_CategoryID.ValueChanged
        If Not IsNothing(Temp_Property) Then
            Temp_Property.RegionCategory = Property_CategoryID.Value
        End If
        Property_Property.RefreshPropertyValues()
    End Sub
#End Region
#Region "|OFF|X|01.01.00.03| <Property> <Constructor> <Statement> [Parent]"
    Private Sub Property_Parent_TextChanged(sender As Object, e As EventArgs) Handles Property_Parent.TextChanged

    End Sub
#End Region
#Region "|ON | |01.01.00.04| <Property> <Constructor> <Statement> [SetStatement]"
    Private Sub Property_SetStatement_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Property_SetStatement.TextChanged
        If Not IsNothing(Temp_Property) Then
            If Property_ReadOnly.Value = True Then
            Else
                Temp_Property.SetStatement = Property_SetStatement.Text
            End If
        End If
        Property_Property.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |01.01.00.05| <Property> <Constructor> <Statement> [GetStatement]"
    Private Sub Property_GetStatement_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Property_GetStatement.TextChanged
        If Not IsNothing(Temp_Property) Then
            If Property_WriteOnly.Value = True Then
            Else
                Temp_Property.GetStatement = Property_GetStatement.Text
            End If
        End If
        Property_Property.RefreshPropertyValues()
    End Sub
#End Region
#End Region
#Region "|ON | |01.01.01| <Property> <Constructor> [Property]{10}"
#Region "|ON | |01.01.01.00| <Property> <Constructor> <Property> [AccessModifier]"
    Private Sub Property_AccessModifier_TextChanged(sender As Object, e As EventArgs) Handles Property_AccessModifier.TextChanged
        If Not IsNothing(Temp_Property) Then
            Temp_Property.AccessModifier = VbNET.String_ToAccessModifiers(Property_AccessModifier.Text)
        End If
        Property_Property.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |01.01.01.01| <Property> <Constructor> <Property> [PropertyModifier]"
    Private Sub Property_PropertyModifier_TextChanged(sender As Object, e As EventArgs) Handles Property_PropertyModifier.TextChanged
        If Not IsNothing(Temp_Property) Then
            Temp_Property.AccessModifier = VbNET.String_ToPropertyModifiers(Property_PropertyModifier.Text)
        End If
        Property_Property.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |01.01.01.02| <Property> <Constructor> <Property> [ReturnType]"
    Private Sub Property_ReturnType_TextChanged(sender As Object, e As EventArgs) Handles Property_ReturnType.TextChanged
        If Property_ReturnType.Text <> "" Then
            If IsNothing(Temp_Property) Then
                Temp_Property = New VbNET.Property(Property_Name.Text, Property_ReturnType.Text, Property_Attribute_Category.Text)
            Else
                Temp_Property.ReturnType = Property_ReturnType.Text
            End If
            Property_Description.Text = "The " & Property_Name.Text & " as " & Property_ReturnType.Text & "."
            Property_Variable_ReturnType.Text = Property_ReturnType.Text

        End If
        Property_Property.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |01.01.01.03| <Property> <Constructor> <Property> [Name]"
    Private Sub Property_Name_TextChanged(sender As Object, e As EventArgs) Handles Property_Name.TextChanged
        If Property_Name.Text <> "" Then
            If IsNothing(Temp_Property) Then
                Temp_Property = New VbNET.Property(Property_Name.Text, Property_ReturnType.Text, Property_Attribute_Category.Text)
            Else
                Temp_Property.Name = Property_Name.Text
            End If
            Property_Variable_Name.Text = "_" & Property_Name.Text
        End If

        Property_Property.RefreshPropertyValues()

    End Sub
#End Region
#Region "|ON | |01.01.01.04| <Property> <Constructor> <Property> [Default]"
    Private Sub Property_Default_ValueChanged(sender As Object, e As EventArgs) Handles Property_Default.ValueChanged
        If Not IsNothing(Temp_Property) Then
            Temp_Property.Default = Property_Default.Text
        End If
        Property_Property.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |01.01.01.05| <Property> <Constructor> <Property> [Shared]"
    Private Sub Property_Shared_ValueChanged(sender As Object, e As EventArgs) Handles Property_Shared.ValueChanged
        If Not IsNothing(Temp_Property) Then
            Temp_Property.Shared = Property_Shared.Value
        End If
        Property_Property.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |01.01.01.06| <Property> <Constructor> <Property> [Shadows]"
    Private Sub Property_Shadows_ValueChanged(sender As Object, e As EventArgs) Handles Property_Shadows.ValueChanged
        If Not IsNothing(Temp_Property) Then
            Temp_Property.Shadows = Property_Shadows.Value
        End If
        Property_Property.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |01.01.01.07| <Property> <Constructor> <Property> [ReadOnly]"
    Private Sub Property_ReadOnly_ValueChanged(sender As Object, e As EventArgs) Handles Property_ReadOnly.ValueChanged
        If Not IsNothing(Temp_Property) Then
            Temp_Property.ReadOnly = Property_ReadOnly.Value
        End If
        If Property_ReadOnly.Value = True Then
            Property_WriteOnly.Value = False
            Property_SetStatement.Visible = False
        Else
            Property_SetStatement.Visible = True
        End If
        Property_Property.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |01.01.01.08| <Property> <Constructor> <Property> [WriteOnly]"
    Private Sub Property_WriteOnly_ValueChanged(sender As Object, e As EventArgs) Handles Property_WriteOnly.ValueChanged
        If Not IsNothing(Temp_Property) Then
            Temp_Property.WriteOnly = Property_WriteOnly.Value
        End If
        If Property_WriteOnly.Value = True Then
            Property_ReadOnly.Value = False
            Property_GetStatement.Visible = False
        Else
            Property_GetStatement.Visible = True
        End If
        Property_Property.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |01.01.01.09| <Property> <Constructor> <Property> [Required]"
    Private Sub Property_Required_ValueChanged(sender As Object, e As EventArgs) Handles Property_Required.ValueChanged
        If Not IsNothing(Temp_Property) Then
            Temp_Property.Required = Property_Required.Value
        End If
        Property_Property.RefreshPropertyValues()
    End Sub
#End Region
#End Region
#Region "|ON | |01.01.02| <Property> <Constructor> [Variable]{3}"
#Region "|ON | |01.01.02.00| <Property> <Constructor> <Variable> [AccessModifier]"
    Private Sub Property_Variable_AccessModifier_TextChanged(sender As Object, e As EventArgs) Handles Property_Variable_AccessModifier.TextChanged
        If Not IsNothing(Temp_Property) Then
            Temp_Property.Variable_AccessModifier = VbNET.String_ToAccessModifiers(Property_Variable_AccessModifier.Text)
        End If
        Property_Property.RefreshPropertyValues()
    End Sub

#End Region
#Region "|ON | |01.01.02.01| <Property> <Constructor> <Variable> [Name]"
    Private Sub Property_Variable_Name_TextChanged(sender As Object, e As EventArgs) Handles Property_Variable_Name.TextChanged
        If Not IsNothing(Temp_Property) Then
            Temp_Property.Variable_Name = Property_Variable_Name.Text
        End If
        Property_Property.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |01.01.02.02| <Property> <Constructor> <Variable> [ReturnType]"
    Private Sub Property_Variable_ReturnType_TextChanged(sender As Object, e As EventArgs) Handles Property_Variable_ReturnType.TextChanged
        If Not IsNothing(Temp_Property) Then
            Temp_Property.Variable_ReturnType = Property_Variable_ReturnType.Text
        End If
        Property_Property.RefreshPropertyValues()
    End Sub
#End Region
#End Region
#End Region
#Region "|ON | |01.02| <Property> [Attribute]{12}"
#Region "|ON | |01.02.00| <Property> <Attribute> [Category]"
    Private Sub Property_Attribute_Category_Leave(sender As Object, e As EventArgs) Handles Property_Attribute_Category.Leave
        AddCategory(Property_Attribute_Category.Text)
        '  RefreshCategory()
        Property_CategoryID.Value = RetriveCategoryID_FromString(Property_Attribute_Category.Text)
        Property_Property.RefreshPropertyValues()
    End Sub
    Private Sub Property_Attribute_Category_TextChanged(sender As Object, e As EventArgs) Handles Property_Attribute_Category.TextChanged
        If Property_Attribute_Category.Text <> "" Then
            If Not IsNothing(Temp_Property) Then
                Temp_Property.Category = Property_Attribute_Category.Text
            End If
        End If
        Property_Property.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |01.02.01| <Property> <Attribute> [DefaultValue]"

    Private Sub Property_Attribute_DefaultValue_TextChanged(sender As Object, e As EventArgs) Handles Property_Attribute_DefaultValue.TextChanged
        If Property_Attribute_DefaultValue.Text <> "" Then
            Temp_Property.DefaultValue = Property_Attribute_DefaultValue.Text
        End If
        Property_Property.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |01.02.02| <Property> <Attribute> [Browsable]"
    Private Sub Property_AttributeList_Browsable_ValueChanged(sender As Object, e As EventArgs) Handles Property_AttributeList_Browsable.ValueChanged
        If Not IsNothing(Temp_Property) Then
            Temp_Property.Browsable = Property_AttributeList_Browsable.Value
        End If
        Property_Property.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |01.02.03| <Property> <Attribute> [Definition]"
    Private Sub Property_Description_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Property_Description.TextChanged
        If Not IsNothing(Temp_Property) Then
            Temp_Property.Description = Property_Description.Text
        End If
        Property_Property.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |01.02.04| <Property> <Attribute> [Editor]"
    Private Sub Property_Attribute_Editor_TextChanged(sender As Object, e As EventArgs) Handles Property_Attribute_Editor.TextChanged
        If Not IsNothing(Temp_Property) Then
            Temp_Property.Editor = Property_Attribute_Editor.Text
        End If
        Property_Property.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |01.02.05| <Property> <Attribute> [RelatedImageList]"
    Private Sub Property_Attribute_RelatedImageList_TextChanged(sender As Object, e As EventArgs) Handles Property_Attribute_RelatedImageList.TextChanged
        If Not IsNothing(Temp_Property) Then
            Temp_Property.RelatedImageList = Property_Attribute_RelatedImageList.Text
        End If
        Property_Property.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |01.02.06| <Property> <Attribute> [Deserializable]"
    Private Sub Property_Attribute_Deserializable_ValueChanged(sender As Object, e As EventArgs) Handles Property_Attribute_Deserializable.ValueChanged
        If Not IsNothing(Temp_Property) Then
            Temp_Property.Deserializable = Property_Attribute_Deserializable.Value
        End If
        Property_Property.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |01.02.07| <Property> <Attribute> [NonSerialized]"
    Private Sub Property_Attribute_NonSerialized_ValueChanged(sender As Object, e As EventArgs) Handles Property_Attribute_NonSerialized.ValueChanged
        If Not IsNothing(Temp_Property) Then
            Temp_Property.NonSerialized = Property_Attribute_NonSerialized.Value
        End If
        Property_Property.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |01.02.08| <Property> <Attribute> [Serializable]"
    Private Sub Property_Attribute_Serializable_ValueChanged(sender As Object, e As EventArgs) Handles Property_Attribute_Serializable.ValueChanged
        If Not IsNothing(Temp_Property) Then
            Temp_Property.Serializable = Property_Attribute_Serializable.Value
        End If
        Property_Property.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |01.02.09| <Property> <Attribute> [XmlRoot]"
    Private Sub Property_Attribute_XmlRoot_TextChanged(sender As Object, e As EventArgs) Handles Property_Attribute_XmlRoot.TextChanged
        If Not IsNothing(Temp_Property) Then
            Temp_Property.XmlRoot = Property_Attribute_XmlRoot.Text
        End If
        Property_Property.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |01.02.10| <Property> <Attribute> [XmlIgnore]"
    Private Sub Property_Attribute_XmlIgnore_ValueChanged(sender As Object, e As EventArgs) Handles Property_Attribute_XmlIgnore.ValueChanged
        If Not IsNothing(Temp_Property) Then
            Temp_Property.XmlIgnore = Property_Attribute_XmlIgnore.Value
        End If
        Property_Property.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |01.02.11| <Property> <Attribute> [XmlInclude]"
    Private Sub Property_Attribute_XmlInclude_ValueChanged(sender As Object, e As EventArgs) Handles Property_Attribute_XmlInclude.ValueChanged
        If Not IsNothing(Temp_Property) Then
            Temp_Property.XmlInclude = Property_Attribute_XmlInclude.Value
        End If
        Property_Property.RefreshPropertyValues()
    End Sub
#End Region
#End Region
#Region "|ON | |01.03| <Property> [Summary]{13}"
#Region "|ON | |01.03.00| <Property> <Summary> [Usage]"
    Private Sub Property_Summary_Usage_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Property_Summary_Usage.TextChanged
        If Not IsNothing(Temp_Property) Then
            Temp_Property.Usage = Property_Summary_Usage.Text
        End If
        Property_Property.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |01.03.01| <Property> <Summary> [Remark]"
    Private Sub Property_Summary_Remark_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Property_Summary_Remark.TextChanged
        If Not IsNothing(Temp_Property) Then
            Temp_Property.Remarks = Property_Summary_Remark.Text
        End If
        Property_Property.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |01.03.02| <Property> <Summary> [Example]"
    Private Sub Property_Summary_Example_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Property_Summary_Example.TextChanged
        If Not IsNothing(Temp_Property) Then
            Temp_Property.Example = Property_Summary_Example.Text
        End If
        Property_Property.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |01.03.03| <Property> <Summary> [Note]"
    Private Sub Property_Summary_Note_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Property_Summary_Note.TextChanged
        If Not IsNothing(Temp_Property) Then
            Temp_Property.Note = Property_Summary_Note.Text
        End If
        Property_Property.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |01.03.04| <Property> <Summary> [Rules]"
    Private Sub Property_Summary_Rules_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Property_Summary_Rules.TextChanged
        If Not IsNothing(Temp_Property) Then
            Temp_Property.Rules = Property_Summary_Rules.Text
        End If
        Property_Property.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |01.03.05| <Property> <Summary> [Syntax]"
    Private Sub Property_Summary_Syntax_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Property_Summary_Syntax.TextChanged
        If Not IsNothing(Temp_Property) Then
            Temp_Property.Syntax = Property_Summary_Syntax.Text
        End If
        Property_Property.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |01.03.06| <Property> <Summary> [Rights]"
    Private Sub Property_Summary_Rights_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles Property_Summary_Rights.TextChanged
        If Not IsNothing(Temp_Property) Then
            Temp_Property.Rights = Property_Summary_Rights.Text
        End If
        Property_Property.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |01.03.07| <Property> <Summary> [AuthorName]"
    Private Sub Property_Summary_AuthorName_TextChanged(sender As Object, e As EventArgs) Handles Property_Summary_AuthorName.TextChanged
        If Not IsNothing(Temp_Property) Then
            Temp_Property.AuthorName = Property_Summary_AuthorName.Text
        End If
        Property_Property.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |01.03.08| <Property> <Summary> [AuthorEmail]"
    Private Sub Property_Summary_AuthorEmail_TextChanged(sender As Object, e As EventArgs) Handles Property_Summary_AuthorEmail.TextChanged
        If Not IsNothing(Temp_Property) Then
            Temp_Property.AuthorEmail = Property_Summary_AuthorEmail.Text
        End If
        Property_Property.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |01.03.09| <Property> <Summary> [AuthorUrl]"
    Private Sub Property_Summary_AuthorUrl_TextChanged(sender As Object, e As EventArgs) Handles Property_Summary_AuthorUrl.TextChanged
        If Not IsNothing(Temp_Property) Then
            Temp_Property.AuthorUri = Property_Summary_AuthorUrl.Text
        End If
        Property_Property.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |01.03.10| <Property> <Summary> [ContributorName]"
    Private Sub Property_Summary_ContributorName_TextChanged(sender As Object, e As EventArgs) Handles Property_Summary_ContributorName.TextChanged
        If Not IsNothing(Temp_Property) Then
            Temp_Property.ContributorName = Property_Summary_ContributorName.Text
        End If
        Property_Property.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |01.03.11| <Property> <Summary> [ContributorEmail]"
    Private Sub Property_Summary_ContributorEmail_TextChanged(sender As Object, e As EventArgs) Handles Property_Summary_ContributorEmail.TextChanged
        If Not IsNothing(Temp_Property) Then
            Temp_Property.ContributorEmail = Property_Summary_ContributorEmail.Text
        End If
        Property_Property.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |01.03.12| <Property> <Summary> [ContributorUrl]"
    Private Sub Property_Summary_ContributorUrl_TextChanged(sender As Object, e As EventArgs) Handles Property_Summary_ContributorUrl.TextChanged
        If Not IsNothing(Temp_Property) Then
            Temp_Property.ContributorUri = Property_Summary_ContributorUrl.Text
        End If
        Property_Property.RefreshPropertyValues()
    End Sub
#End Region
#End Region
#Region "|ON | |01.04| <Property> [ParameterList]{2}"
#Region "|ON | |01.04.00| <Property> <ParameterList> [Add]"
    Private Sub Property_Add_InputParam_Click(sender As Object, e As EventArgs) Handles Property_Add_InputParam.Click
        If IsNothing(Temp_Property_Parameters) Then
            Temp_Property_Parameters = New List(Of VbNET.InnerStatement.ParameterList_Statement)
        End If
        Dim P As New VbNET.InnerStatement.ParameterList_Statement(Property_Param_Name.Text, Property_Param_ReturnType.Text, Property_Param_Modifier.Text, Property_Param_DefaultValue.Text, Property_Description.Text)
        P.Definition = Property_Param_Summary.Text
        Dim Item As ListViewItem = AddParameters(Temp_Property_Parameters, P)
        If Not IsNothing(Item) Then
            Property_ParamList.Items.Add(Item)
        End If
        '   Quantity_Parameter.Value += 1
        Property_Property.RefreshPropertyValues()
    End Sub
#End Region
#Region "|ON | |01.04.01| <Property> <ParameterList> [Remove]"
    Private Sub Property_Remove_InputParam_Click(sender As Object, e As EventArgs) Handles Property_Remove_InputParam.Click
        If IsNothing(Temp_Property_Parameters) Then
            Temp_Property_Parameters = New List(Of VbNET.InnerStatement.ParameterList_Statement)
        End If
        Dim P As New VbNET.InnerStatement.ParameterList_Statement(Property_Param_Name.Text, Property_Param_ReturnType.Text, Property_Param_Modifier.Text, Property_Param_DefaultValue.Text, Property_Description.Text)
        Dim Item As ListViewItem = RemoveParameters(Temp_Property_Parameters, P)
        If Not IsNothing(Item) Then
            Try
                Property_ParamList.Items.Remove(Item)
            Catch ex As Exception
            End Try
        End If
        '     If Quantity_Parameter.Value - 1 < 0 Then
        '   Quantity_Parameter.Value = 0
        '   Else
        '   Quantity_Parameter.Value -= 1
        '   End If
        '   CalculateTotal()
        Property_Property.RefreshPropertyValues()
    End Sub
#End Region
#End Region
#End Region

    Public Sub ReadProperty(ByVal Prop As VbNET.Property)
        If Not IsNothing(Prop) Then
            With Prop
                Me.Property_AccessModifier.Text = VbNET.AccessModifiers_ToString(.AccessModifier)
                Me.Property_AttributeList_Browsable.Value = .Browsable
                Me.Property_Attribute_Category.Text = .Category
                Me.Property_Attribute_DefaultValue.Text = .DefaultValue
                Me.Property_Attribute_Deserializable.Value = .Deserializable
                Me.Property_Attribute_Editor.Text = .Editor
                Me.Property_Attribute_NonSerialized.Value = .NonSerialized
                Me.Property_Attribute_RelatedImageList.Text = .RelatedImageList
                Me.Property_Attribute_Serializable.Value = .Serializable
                Me.Property_Attribute_XmlIgnore.Value = .XmlIgnore
                Me.Property_Attribute_XmlInclude.Value = .XmlInclude
                Me.Property_Attribute_XmlRoot.Text = .XmlRoot
                Me.Property_CategoryID.Value = .RegionCategory
                Me.Property_Default.Value = .Default
                Me.Property_Description.Text = .Description
                Me.Property_Enable.Value = .Enable
                Me.Property_GetStatement.Text = .GetStatement
                Me.Property_ID.Value = .ID
                Me.Property_Name.Text = .Name
                Me.Property_ParamList.Items.Clear()
                Temp_Property_Parameters = New List(Of VbNET.InnerStatement.ParameterList_Statement)
                Temp_Property_Parameters = .ParameterList
                If Not IsNothing(Temp_Property.ParentStructure) Then
                    '     Me.Property_Parent.Text = Temp_Property.ParentStructure.Name
                Else
                    If Not IsNothing(Temp_Property.ParentModule) Then
                        '     Me.Property_Parent.Text = Temp_Property.ParentModule.ModuleName
                    Else
                        If Not IsNothing(Temp_Property.ParentClass) Then
                            '   Me.Property_Parent.Text = Temp_Property.ParentClass.Name
                        Else
                            If Not IsNothing(VirtualClass) Then
                                Me.Property_Parent.Text = VirtualClass.Name
                                '  Me.Temp_Property.ParentClass = VirtualClass
                            Else
                                VirtualClass = New VbNET.Class("VirtualClass")
                                VirtualClass.ClassName = "VirtualClass"
                                Me.Temp_Property.ParentClass = VirtualClass
                                ' Me.Property_Parent.Text = VirtualClass.Name
                            End If
                        End If



                    End If
                End If
                If Not IsNothing(Temp_Property_Parameters) Then
                    For Each Item As ListViewItem In ConvertParameterList_ToListOFListviewItem(Temp_Property_Parameters)
                        Me.Property_ParamList.Items.Add(Item)
                    Next
                End If
                Me.Property_PropertyModifier.Text = VbNET.PropertyModifiers_ToString(.PropertyModifier)
                Me.Property_ReadOnly.Value = .ReadOnly
                Me.Property_Required.Value = .Required
                Me.Property_ReturnType.Text = .ReturnType
                Me.Property_SetStatement.Text = .SetStatement
                Me.Property_Shadows.Value = .Shadows
                Me.Property_Shared.Value = .Shared
                Me.Property_Summary_AuthorEmail.Text = .AuthorEmail
                Me.Property_Summary_AuthorName.Text = .AuthorName
                Me.Property_Summary_AuthorUrl.Text = .AuthorUri
                Me.Property_Summary_ContributorEmail.Text = .ContributorEmail
                Me.Property_Summary_ContributorName.Text = .ContributorName
                Me.Property_Summary_ContributorUrl.Text = .ContributorUri
                Me.Property_Summary_Example.Text = .Example
                Me.Property_Summary_Note.Text = .Note
                Me.Property_Summary_Remark.Text = .Remarks
                Me.Property_Summary_Rights.Text = .Rights
                Me.Property_Summary_Rules.Text = .Rules
                Me.Property_Summary_Syntax.Text = .Syntax
                Me.Property_Summary_Usage.Text = .Usage
                Me.Property_Variable_AccessModifier.Text = VbNET.AccessModifiers_ToString(.Variable_AccessModifier)
                Me.Property_Variable_Name.Text = .Variable_Name
                Me.Property_Variable_ReturnType.Text = .Variable_ReturnType
                Me.Property_WriteOnly.Value = .WriteOnly
            End With
        End If
        Property_Property.RefreshPropertyValues()
    End Sub

    Private Sub VbNet_Property_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Property_Parent.SelectedIndex = 0
        If IsNothing(VirtualClass) Then
            VirtualClass = New VbNET.Class("VirtualClass")
        End If
        RefreshParents(Property_Parent)
    End Sub

    Private Sub Property_Parent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Property_Parent.SelectedIndexChanged
        If Property_Parent.Items.Count - 1 > 0 Then
            If Not IsNothing(Property_Parent.SelectedItem) Then
                If Not IsNothing(Property_Parent.SelectedItem.Tag) Then
                    ActiveParent = Property_Parent.SelectedItem.Tag

                End If
            End If
        Else
            RefreshParents(Property_Parent)
        End If
    End Sub

    Private Sub Property_Parent_TextUpdate(sender As Object, e As EventArgs) Handles Property_Parent.TextUpdate
        If Not IsNothing(Temp_Property) Then
            Dim Lt As New List(Of VbNET.InnerStatement.ParameterList_Statement)
            Lt = Temp_Property_Parameters
        Else
            Dim Lt As New List(Of VbNET.InnerStatement.ParameterList_Statement)
            Lt = Temp_Property_Parameters
            Temp_Property = New VbNET.Property(Property_Name.Text,
                                          Property_ReturnType.Text,
                                          Property_Attribute_Category.Text,
                                          Property_Required.Value,
                                          Property_ID.Value,
                                          Property_Attribute_DefaultValue.Text,
                                          Property_Shared.Value,
                                          Property_Shadows.Value,
                                          Property_WriteOnly.Value,
                                          Property_ReadOnly.Value,
                                          Property_Default.Value,
                                          VbNET.String_ToAccessModifiers(Property_AccessModifier.Text),
                                          VbNET.String_ToPropertyModifiers(Property_PropertyModifier.Text),
                                          Property_Variable_Name.Text,
                                          Property_Variable_ReturnType.Text,
                                          VbNET.String_ToAccessModifiers(Property_Variable_AccessModifier.Text),
                                          Property_GetStatement.Text,
                                          Property_SetStatement.Text,
                                          Property_AttributeList_Browsable.Value,
                                          Property_ReturnType.Text,
                                          Lt,
                                          Property_Enable.Value,
                                          Property_Description.Text,
                                          New VbNET.Attributelist(Property_Attribute_Category.Text,
                                                                  Property_Description.Text,
                                                                  Property_Attribute_DefaultValue.Text,
                                                                  Property_AttributeList_Browsable.Value,
                                                                  Property_Attribute_Deserializable.Value,
                                                                  Property_Attribute_Editor.Text,
                                                                  Property_Attribute_Serializable.Value,
                                                                  Property_Attribute_NonSerialized.Value,
                                                                  Property_Attribute_RelatedImageList.Text,
                                                                  Property_Attribute_XmlRoot.Text,
                                                                  Property_Attribute_XmlIgnore.Value,
                                                                  Property_Attribute_XmlInclude.Value),
                                          Property_Summary_AuthorName.Text,
                                          Property_Summary_AuthorEmail.Text,
                                          Property_Summary_AuthorUrl.Text,
                                          Property_Summary_ContributorName.Text,
                                          Property_Summary_ContributorEmail.Text,
                                          Property_Summary_ContributorUrl.Text,
                                          Property_Summary_Usage.Text,
                                          Property_Summary_Usage.Text,
                                          Property_Summary_Example.Text,
                                          Property_Summary_Note.Text,
                                           ,
                                          Property_Summary_Rights.Text)
        End If

        Dim D = Property_Parent.SelectedItem.Tag
        If Not IsNothing(D) Then
            If TypeOf (D) Is VbNET.Class Then
                Temp_Property.ParentClass = New VbNET.Class
                Temp_Property.ParentClass = D
            ElseIf TypeOf (D) Is VbNET.Module Then
                Temp_Property.ParentModule = New VbNET.Module
                Temp_Property.ParentModule = D
            ElseIf TypeOf (D) Is VbNET.Structure Then
                Temp_Property.ParentStructure = New VbNET.Structure
                Temp_Property.ParentStructure = D
            End If
        End If
        Temp_Property.ParentName = Property_Parent.Text

        Property_Property.RefreshPropertyValues()
    End Sub

    Private Sub BindingNavigatorPositionItem_TextChanged(sender As Object, e As EventArgs) Handles BindingNavigatorPositionItem.TextChanged
        If Not IsNothing(Me.BS_Property.Current) Then
            ReadProperty(Me.BS_Property.Current)
        End If
    End Sub

    Private Sub BS_Property_CurrentChanged(sender As Object, e As EventArgs) Handles BS_Property.CurrentChanged
        ReadProperty(BS_Property.Current)
    End Sub

    Private Sub Btn_Refresh_Click(sender As Object, e As EventArgs) Handles Btn_Refresh.Click
        RefreshParents(Property_Parent)

    End Sub
End Class
