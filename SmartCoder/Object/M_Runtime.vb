Imports System.ComponentModel
Imports System.Windows.Forms

Public Module M_Runtime

#Region "OpenDatabaseDialog"
    Public Property OpenDatabaseDialogDataBase As DataBase
#End Region
    Public Property Jarvis As New Voice
#Region "|VbNET Instruments|"

#Region "<1> [Property]"
#Region "<01.00> <Property> [Object]"
    Public Property VirtualClass As New VbNET.Class
    Public Property VirtualModule As New VbNET.Module
    Public Property Temp_Structure As New VbNET.Structure
    'Public Property Temp_Importation As New VbNET.Import
    'Public Property Temp_Property As New VbNET.Property
    'Public Property Temp_Enumeration As New VbNET.Enumeration
    'Public Property Temp_Sub As New VbNET.Sub
    'Public Property Temp_Function As New VbNET.Function
    'Public Property Temp_Loader As New VbNET.Loader
    'Public Property Temp_Class As New VbNET.Class
    'Public Property Temp_Runtime As New VbNET.Runtime
    'Public Property Temp_Constante As New VbNET.Constante
    'Public Property Temp_Event As New VbNET.Event
#End Region
#Region "<01.01> <Property> [List]"
    ''' <summary>
    ''' List of Category Attributes
    ''' </summary>
    ''' <returns></returns>
    Public Property ListCategory As New List(Of String)

    ''' <summary>
    ''' List of Return Type
    ''' </summary>
    ''' <returns></returns>
    Public Property ListReturnType As New List(Of String)
    ''' <summary>
    ''' This list stores all the VbNET.Class / VbNET.Structure / VbNET.Module
    ''' This list is then represented in each VbNET Object as Parent
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public Property ListParent As New List(Of Object)
#End Region
#End Region
#Region "<6> [Runtime]"
    Dim RefreshParentCounter As Integer = 0
    Public ApplicationDLL As New TestDLL

#End Region
#Region "<4> [Sub]"
    Public Sub RefreshParents(ByRef ComboBox As DevComponents.DotNetBar.Controls.ComboBoxEx,
                              Optional ByVal Exclude_Module As Boolean = False,
                              Optional ByVal Exclude_Structure As Boolean = False)

        If RefreshParentCounter = 0 Then
            ComboBox.Items.Clear()
            VirtualClass = New VbNET.Class("VirtualClass")
            VirtualModule = New VbNET.Module("VirtualModule")
            Temp_Structure = New VbNET.Structure("Temp_Structure")
            ListParent.Add(VirtualClass)
            ListParent.Add(VirtualModule)
            ListParent.Add(Temp_Structure)
        Else
            If IsNothing(VirtualClass) Then
                VirtualClass = New VbNET.Class("VirtualClass")
                ListParent.Add(VirtualClass)
            End If
            If IsNothing(VirtualModule) Then
                VirtualModule = New VbNET.Module("VirtualModule")
                ListParent.Add(VirtualModule)
            End If
            If IsNothing(Temp_Structure) Then
                Temp_Structure = New VbNET.Structure("Temp_Structure")
                ListParent.Add(Temp_Structure)
            End If
        End If

        If Not IsNothing(ComboBox) Then
            ComboBox.Items.Clear()

            Dim NewList As New List(Of Object)
            For Each Obj As Object In ListParent
                If TypeOf Obj Is VbNET.Class Then
                    For Each Statement As VbNET.Structure In Obj.Structure
                        NewList.Add(Statement)
                    Next
                    For Each Statement As VbNET.Class In Obj.Classes
                        NewList.Add(Statement)
                        If Statement.Structure.Count - 1 > 0 Then
                            For Each St As VbNET.Structure In Statement.Structure
                                NewList.Add(St)
                            Next
                            For Each St As VbNET.Class In Statement.Classes
                                NewList.Add(St)
                            Next
                        End If
                    Next
                    For Each Statement As VbNET.Module In Obj.Modules
                        ListParent.Add(Statement)
                        If Statement.Structure.Count - 1 > 0 Then
                            For Each St As VbNET.Structure In Statement.Structure
                                NewList.Add(St)
                            Next
                            For Each St As VbNET.Class In Statement.Classes
                                NewList.Add(St)
                            Next
                        End If
                    Next
                    NewList.Add(Obj)

                ElseIf TypeOf Obj Is VbNET.Module Then
                    For Each Statement As VbNET.Structure In Obj.Structure
                        NewList.Add(Statement)
                    Next
                    For Each Statement As VbNET.Class In Obj.Classes
                        ListParent.Add(Statement)
                        If Statement.Structure.Count - 1 > 0 Then
                            For Each St As VbNET.Structure In Statement.Structure
                                NewList.Add(St)
                            Next
                            For Each St As VbNET.Class In Statement.Classes
                                NewList.Add(St)
                            Next
                        End If
                    Next
                    For Each Statement As VbNET.Module In Obj.Modules
                        ListParent.Add(Statement)
                        If Statement.Structure.Count - 1 > 0 Then
                            For Each St As VbNET.Structure In Statement.Structure
                                NewList.Add(St)
                            Next
                            For Each St As VbNET.Class In Statement.Classes
                                NewList.Add(St)
                            Next
                        End If
                    Next
                    NewList.Add(Obj)
                ElseIf TypeOf Obj Is VbNET.Structure Then
                    NewList.Add(Obj)
                End If

            Next
            ListParent = New List(Of Object)
            ListParent = NewList
            For Each Obj As Object In ListParent

                If TypeOf Obj Is VbNET.Class Then
                    Dim C As New ListViewItem
                    C.ForeColor = System.Drawing.Color.Black
                    C.Name = Obj.Name
                    C.Text = Obj.Name
                    C.Tag = Obj
                    ComboBox.Items.Add(C)
                ElseIf TypeOf Obj Is VbNET.Module Then
                    If Exclude_Module = False Then
                        Dim C As New ListViewItem
                        C.ForeColor = System.Drawing.Color.Blue
                        C.Name = Obj.Name
                        C.Text = Obj.Name
                        C.Tag = Obj
                        ComboBox.Items.Add(C)
                    End If
                ElseIf TypeOf Obj Is VbNET.Structure Then
                    If Exclude_Structure = False Then
                        Dim C As New ListViewItem
                        C.ForeColor = System.Drawing.Color.Indigo
                        C.Name = Obj.Name
                        C.Text = Obj.Name
                        C.Tag = Obj
                        ComboBox.Items.Add(C)
                    End If
                End If

            Next
            RefreshParentCounter = 1
        End If
    End Sub
#End Region

#Region "<8> [Class]"

#End Region
#End Region





#Region "<Parameters>"
    Public Property Temp_Property_Parameters As New List(Of VbNET.InnerStatement.ParameterList_Statement)
    Public Property Temp_Sub_Parameters As New List(Of VbNET.InnerStatement.ParameterList_Statement)
#End Region
#Region "<Structure>"
    Public Property Temp_Structure_Property As New VbNET.Property
    Public Property Temp_Structure_Enumeration As New VbNET.Enumeration
    Public Property Temp_Structure_Sub As New VbNET.Sub
    Public Property Temp_Structure_Runtime As New VbNET.Runtime
    Public Property Temp_Strcutrue_Event As New VbNET.Event
#End Region
    Public Sub ResetAllTemps()
        'Temp_Class = New VbNET.Class
        'Temp_Constante = New VbNET.Constante
        'Temp_Enumeration = New VbNET.Enumeration
        'Temp_Event = New VbNET.Event
        'Temp_Function = New VbNET.Function
        'Temp_Importation = New VbNET.Import
        'Temp_Loader = New VbNET.Loader
        'Temp_Property = New VbNET.Property
        'Temp_Runtime = New VbNET.Runtime
        'Temp_Structure = New VbNET.Structure
        'Temp_Sub = New VbNET.Sub
        If IsNothing(VirtualClass) Then
            VirtualClass = New VbNET.Class
        End If
        ListCategory = New List(Of String)
        Temp_Property_Parameters = New List(Of VbNET.InnerStatement.ParameterList_Statement)
    End Sub
    Public Sub AddCategory(ByVal Cat As String)
        If IsNothing(ListCategory) Then
            ListCategory = New List(Of String)
        End If
        Dim Addit As Boolean = True
        If Cat <> "" Then
            For i = 0 To ListCategory.Count - 1
                If Cat = ListCategory(i).ToString Then
                    Addit = False
                    Exit For
                End If
            Next
        End If
        If Addit = True Then
            ListCategory.Add(Cat)
        End If
    End Sub
    Public Sub AddReturnType(ByVal Type As String)
        If IsNothing(ListReturnType) Then
            ListReturnType = New List(Of String)
        End If
        Dim Addit As Boolean = True
        If Type <> "" Then
            For i = 0 To ListReturnType.Count - 1
                If Type = ListReturnType(i).ToString Then
                    Addit = False
                    Exit For
                End If
            Next
        End If
        If Addit = True Then
            ListReturnType.Add(Type)
        End If
    End Sub
    Public Function AddParameters(ByVal Target As List(Of VbNET.InnerStatement.ParameterList_Statement), ByVal Element As VbNET.InnerStatement.ParameterList_Statement) As ListViewItem
        Dim Result As ListViewItem = Nothing
        If Not IsNothing(Target) Then
            If Not IsNothing(Element) Then
                Dim addit As Boolean = True
                For i = 0 To Target.Count - 1
                    If Target(i).ParameterName = Element.ParameterName Then
                        addit = False
                        Exit For
                    End If
                Next
                If addit = True Then
                    Target.Add(Element)
                    Result = New ListViewItem(Target.Count - 1)
                    Result.SubItems.Add(Element.Modifier)
                    Result.SubItems.Add(Element.ParameterName)
                    Result.SubItems.Add(Element.ParameterType)
                    Result.SubItems.Add(Element.Definition)
                    Result.SubItems.Add(Element.DefaultValue)
                    Result.ToolTipText = Element.Definition
                    Result.Tag = Element
                Else

                End If
            Else
            End If
        Else
        End If
        Return Result

    End Function
    Public Function AddMember(ByVal Target As List(Of VbNET.Enumeration.Member), ByVal Element As VbNET.Enumeration.Member) As ListViewItem
        Dim Result As ListViewItem = Nothing
        If Not IsNothing(Target) Then
            If Not IsNothing(Element) Then
                Dim addit As Boolean = True
                For i = 0 To Target.Count - 1
                    If Target(i).MemberName = Element.MemberName Then
                        addit = False
                        Exit For
                    End If
                Next
                If addit = True Then
                    Target.Add(Element)
                    Result = New ListViewItem(Target.Count - 1)
                    Result.SubItems.Add(Element.MemberName)
                    Result.SubItems.Add(Element.MemberValue)
                    Result.SubItems.Add(Element.Description)
                    Result.Tag = Element
                Else

                End If
            Else
            End If
        Else
        End If
        Return Result

    End Function
    Public Function RemoveParameters(ByVal Target As List(Of VbNET.InnerStatement.ParameterList_Statement),
                                     ByVal Element As VbNET.InnerStatement.ParameterList_Statement) As ListViewItem
        Dim Result As ListViewItem = Nothing
        Dim ElementToDelete As VbNET.InnerStatement.ParameterList_Statement = Nothing
        Dim i As Integer = 0
        If Not IsNothing(Target) Then
            If Not IsNothing(Element) Then
                For i = 0 To Target.Count - 1
                    If Target(i).ParameterName = Element.ParameterName Then
                        ElementToDelete = Target(i)
                        Exit For
                    End If
                Next
                If Not IsNothing(ElementToDelete) Then
                    Target.Remove(ElementToDelete)
                    Result = New ListViewItem(i)
                    Result.SubItems.Add(ElementToDelete.Modifier)
                    Result.SubItems.Add(ElementToDelete.ParameterName)
                    Result.SubItems.Add(ElementToDelete.ParameterType)
                    Result.SubItems.Add(ElementToDelete.Definition)
                    Result.SubItems.Add(ElementToDelete.DefaultValue)
                    Result.ToolTipText = ElementToDelete.Definition
                    Result.Tag = ElementToDelete
                Else

                End If
            Else
            End If
        Else
        End If

        Return Result
    End Function
    Public Function RemoveMember(ByVal Target As List(Of VbNET.Enumeration.Member),
                                     ByVal Element As VbNET.Enumeration.Member) As ListViewItem
        Dim Result As ListViewItem = Nothing
        Dim ElementToDelete As VbNET.Enumeration.Member = Nothing
        Dim i As Integer = 0
        If Not IsNothing(Target) Then
            If Not IsNothing(Element) Then
                For i = 0 To Target.Count - 1
                    If Target(i).MemberName = Element.MemberName Then
                        ElementToDelete = Target(i)
                        Exit For
                    End If
                Next
                If Not IsNothing(ElementToDelete) Then
                    Target.Remove(ElementToDelete)
                    Result = New ListViewItem(i)
                    Result.SubItems.Add(ElementToDelete.MemberName)
                    Result.SubItems.Add(ElementToDelete.Description)
                    Result.SubItems.Add(ElementToDelete.MemberValue)
                    Result.Tag = ElementToDelete
                Else

                End If
            Else
            End If
        Else
        End If

        Return Result
    End Function
    Public Function ConvertParameterList_ToListOFListviewItem(ByRef Lt As List(Of VbNET.InnerStatement.ParameterList_Statement)) As List(Of ListViewItem)
        Dim Result As New List(Of ListViewItem)
        If Not IsNothing(Lt) Then
            For i = 0 To Lt.Count - 1
                Dim It As New ListViewItem(i)
                It.SubItems.Add(Lt(i).Modifier)
                It.SubItems.Add(Lt(i).ParameterName)
                It.SubItems.Add(Lt(i).ParameterType)
                It.SubItems.Add(Lt(i).Definition)
                It.SubItems.Add(Lt(i).DefaultValue)
                It.ToolTipText = Lt(i).Definition
                It.Tag = Lt(i)
                Result.Add(It)
            Next
        End If
        Return Result
    End Function
    Public Function RetriveCategoryID_FromString(ByVal Str As String) As Integer
        Dim Result As Integer = -1
        If IsNothing(ListCategory) Then
            ListCategory = New List(Of String)
        End If
        For i = 0 To ListCategory.Count - 1
            If ListCategory(i).ToLower.Contains(Str.ToLower) Then
                Result = i
                Exit For
            End If
        Next
        Return Result
    End Function

    Public Class ProgrammingQuotes
#Region "|1|  [Property]"
#Region "|01.00| <Property> [UnitPrice]"
#Region "|2019/05/18 17h46:590| <01.00.00> <Property> <UnitPrice> [Call=Importation_UnitPrice|Double]"'(Set|Get) the Importation_UnitPrice as Double
        Private _Importation_UnitPrice As Double
        ''' <Summary>
        ''' (Set|Get) the Importation_UnitPrice as Double
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 17h46:590 </Published>
        ''' <Updated>[Created=2019/05/18 17h46:590][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("UnitPrice"), Description("(Set|Get) the Importation_UnitPrice as Double"), Browsable(True)>
        Public Property Importation_UnitPrice() As Double
            Get
                Return _Importation_UnitPrice
            End Get
            Set(ByVal Value As Double)
                _Importation_UnitPrice = Value
            End Set
        End Property
#End Region ' (Set|Get) the Importation_UnitPrice as Double
#Region "|2019/05/18 17h47:107| <01.00.01> <Property> <UnitPrice> [Call=Property_UnitPrice|Double]"'(Set|Get) the Property_UnitPrice as Double
        Private _Property_UnitPrice As Double
        ''' <Summary>
        ''' (Set|Get) the Property_UnitPrice as Double
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 17h47:107 </Published>
        ''' <Updated>[Created=2019/05/18 17h47:107][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("UnitPrice"), Description("(Set|Get) the Property_UnitPrice as Double"), Browsable(True)>
        Public Property Property_UnitPrice() As Double
            Get
                Return _Property_UnitPrice
            End Get
            Set(ByVal Value As Double)
                _Property_UnitPrice = Value
            End Set
        End Property
#End Region ' (Set|Get) the Property_UnitPrice as Double
#Region "|2019/05/18 17h47:462| <01.00.02> <Property> <UnitPrice> [Call=Enumeration_UnitPrice|Double]"'(Set|Get) the Enumeration_UnitPrice as Double
        Private _Enumeration_UnitPrice As Double
        ''' <Summary>
        ''' (Set|Get) the Enumeration_UnitPrice as Double
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 17h47:462 </Published>
        ''' <Updated>[Created=2019/05/18 17h47:462][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("UnitPrice"), Description("(Set|Get) the Enumeration_UnitPrice as Double"), Browsable(True)>
        Public Property Enumeration_UnitPrice() As Double
            Get
                Return _Enumeration_UnitPrice
            End Get
            Set(ByVal Value As Double)
                _Enumeration_UnitPrice = Value
            End Set
        End Property
#End Region ' (Set|Get) the Enumeration_UnitPrice as Double
#Region "|2019/05/18 17h47:840| <01.00.03> <Property> <UnitPrice> [Call=Structure_UnitPrice|Double]"'(Set|Get) the Structure_UnitPrice as Double
        Private _Structure_UnitPrice As Double
        ''' <Summary>
        ''' (Set|Get) the Structure_UnitPrice as Double
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 17h47:840 </Published>
        ''' <Updated>[Created=2019/05/18 17h47:840][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("UnitPrice"), Description("(Set|Get) the Structure_UnitPrice as Double"), Browsable(True)>
        Public Property Structure_UnitPrice() As Double
            Get
                Return _Structure_UnitPrice
            End Get
            Set(ByVal Value As Double)
                _Structure_UnitPrice = Value
            End Set
        End Property
#End Region ' (Set|Get) the Structure_UnitPrice as Double
#Region "|2019/05/18 17h48:449| <01.00.04> <Property> <UnitPrice> [Call=Sub_UnitPrice|Double]"'(Set|Get) the Structure_UnitPrice as Double
        Private _Sub_UnitPrice As Double
        ''' <Summary>
        ''' (Set|Get) the Structure_UnitPrice as Double
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 17h48:449 </Published>
        ''' <Updated>[Created=2019/05/18 17h48:449][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("UnitPrice"), Description("(Set|Get) the Structure_UnitPrice as Double"), Browsable(True)>
        Public Property Sub_UnitPrice() As Double
            Get
                Return _Sub_UnitPrice
            End Get
            Set(ByVal Value As Double)
                _Sub_UnitPrice = Value
            End Set
        End Property
#End Region ' (Set|Get) the Structure_UnitPrice as Double
#Region "|2019/05/18 17h48:624| <01.00.05> <Property> <UnitPrice> [Call=Function_UnitPrice|Double]"'(Set|Get) the Function_UnitPrice as Double
        Private _Function_UnitPrice As Double
        ''' <Summary>
        ''' (Set|Get) the Function_UnitPrice as Double
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 17h48:624 </Published>
        ''' <Updated>[Created=2019/05/18 17h48:624][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("UnitPrice"), Description("(Set|Get) the Function_UnitPrice as Double"), Browsable(True)>
        Public Property Function_UnitPrice() As Double
            Get
                Return _Function_UnitPrice
            End Get
            Set(ByVal Value As Double)
                _Function_UnitPrice = Value
            End Set
        End Property
#End Region ' (Set|Get) the Function_UnitPrice as Double
#Region "|2019/05/18 17h49:937| <01.00.06> <Property> <UnitPrice> [Call=Runtime_UnitPrice|Double]"'(Set|Get) the Runtime_UnitPrice as Double
        Private _Runtime_UnitPrice As Double
        ''' <Summary>
        ''' (Set|Get) the Runtime_UnitPrice as Double
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 17h49:937 </Published>
        ''' <Updated>[Created=2019/05/18 17h49:937][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("UnitPrice"), Description("(Set|Get) the Runtime_UnitPrice as Double"), Browsable(True)>
        Public Property Runtime_UnitPrice() As Double
            Get
                Return _Runtime_UnitPrice
            End Get
            Set(ByVal Value As Double)
                _Runtime_UnitPrice = Value
            End Set
        End Property
#End Region ' (Set|Get) the Runtime_UnitPrice as Double
#Region "|2019/05/18 17h49:508| <01.00.07> <Property> <UnitPrice> [Call=Loader_UnitPrice|Double]"'(Set|Get) the Loader_UnitPrice as Double
        Private _Loader_UnitPrice As Double
        ''' <Summary>
        ''' (Set|Get) the Loader_UnitPrice as Double
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 17h49:508 </Published>
        ''' <Updated>[Created=2019/05/18 17h49:508][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("UnitPrice"), Description("(Set|Get) the Loader_UnitPrice as Double"), Browsable(True)>
        Public Property Loader_UnitPrice() As Double
            Get
                Return _Loader_UnitPrice
            End Get
            Set(ByVal Value As Double)
                _Loader_UnitPrice = Value
            End Set
        End Property
#End Region ' (Set|Get) the Loader_UnitPrice as Double
#Region "|2019/05/18 17h49:844| <01.00.08> <Property> <UnitPrice> [Call=Class_UnitPrice|Double]"'(Set|Get) the Class_UnitPrice as Double
        Private _Class_UnitPrice As Double
        ''' <Summary>
        ''' (Set|Get) the Class_UnitPrice as Double
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 17h49:844 </Published>
        ''' <Updated>[Created=2019/05/18 17h49:844][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("UnitPrice"), Description("(Set|Get) the Class_UnitPrice as Double"), Browsable(True)>
        Public Property Class_UnitPrice() As Double
            Get
                Return _Class_UnitPrice
            End Get
            Set(ByVal Value As Double)
                _Class_UnitPrice = Value
            End Set
        End Property
#End Region ' (Set|Get) the Class_UnitPrice as Double
#Region "|2019/05/18 17h50:763| <01.00.09> <Property> <UnitPrice> [Call=Constante_UnitPrice|Double]"'(Set|Get) the Constante_UnitPrice as Double
        Private _Constante_UnitPrice As Double
        ''' <Summary>
        ''' (Set|Get) the Constante_UnitPrice as Double
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 17h50:763 </Published>
        ''' <Updated>[Created=2019/05/18 17h50:763][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("UnitPrice"), Description("(Set|Get) the Constante_UnitPrice as Double"), Browsable(True)>
        Public Property Constante_UnitPrice() As Double
            Get
                Return _Constante_UnitPrice
            End Get
            Set(ByVal Value As Double)
                _Constante_UnitPrice = Value
            End Set
        End Property
#End Region ' (Set|Get) the Constante_UnitPrice as Double
#Region "|2019/05/18 17h50:569| <01.00.10> <Property> <UnitPrice> [Call=Events_UnitPrice|Double]"'(Set|Get) the Events_UnitPrice as Double
        Private _Events_UnitPrice As Double
        ''' <Summary>
        ''' (Set|Get) the Events_UnitPrice as Double
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 17h50:569 </Published>
        ''' <Updated>[Created=2019/05/18 17h50:569][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("UnitPrice"), Description("(Set|Get) the Events_UnitPrice as Double"), Browsable(True)>
        Public Property Events_UnitPrice() As Double
            Get
                Return _Events_UnitPrice
            End Get
            Set(ByVal Value As Double)
                _Events_UnitPrice = Value
            End Set
        End Property
#End Region ' (Set|Get) the Events_UnitPrice as Double
#Region "|2019/05/18 17h51:555| <01.00.11> <Property> <UnitPrice> [Call=DataBase_UnitPrice|Double]"'(Set|Get) the DataBase_UnitPrice as Double
        Private _DataBase_UnitPrice As Double
        ''' <Summary>
        ''' (Set|Get) the DataBase_UnitPrice as Double
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 17h51:555 </Published>
        ''' <Updated>[Created=2019/05/18 17h51:555][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("UnitPrice"), Description("(Set|Get) the DataBase_UnitPrice as Double"), Browsable(True)>
        Public Property DataBase_UnitPrice() As Double
            Get
                Return _DataBase_UnitPrice
            End Get
            Set(ByVal Value As Double)
                _DataBase_UnitPrice = Value
            End Set
        End Property
#End Region ' (Set|Get) the DataBase_UnitPrice as Double
#Region "|2019/05/18 17h51:608| <01.00.12> <Property> <UnitPrice> [Call=Fichier_UnitPrice|Double]"'(Set|Get) the Fichier_UnitPrice as Double
        Private _Fichier_UnitPrice As Double
        ''' <Summary>
        ''' (Set|Get) the Fichier_UnitPrice as Double
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 17h51:608 </Published>
        ''' <Updated>[Created=2019/05/18 17h51:608][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("UnitPrice"), Description("(Set|Get) the Fichier_UnitPrice as Double"), Browsable(True)>
        Public Property Fichier_UnitPrice() As Double
            Get
                Return _Fichier_UnitPrice
            End Get
            Set(ByVal Value As Double)
                _Fichier_UnitPrice = Value
            End Set
        End Property
#End Region ' (Set|Get) the Fichier_UnitPrice as Double
#Region "|2019/05/18 17h51:962| <01.00.13> <Property> <UnitPrice> [Call=Table_UnitPrice|Double]"'(Set|Get) the Table_UnitPrice as Double
        Private _Table_UnitPrice As Double
        ''' <Summary>
        ''' (Set|Get) the Table_UnitPrice as Double
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 17h51:961 </Published>
        ''' <Updated>[Created=2019/05/18 17h51:961][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("UnitPrice"), Description("(Set|Get) the Table_UnitPrice as Double"), Browsable(True)>
        Public Property Table_UnitPrice() As Double
            Get
                Return _Table_UnitPrice
            End Get
            Set(ByVal Value As Double)
                _Table_UnitPrice = Value
            End Set
        End Property
#End Region ' (Set|Get) the Table_UnitPrice as Double
#Region "|2019/05/18 18h00:587| <01.00.14> <Property> <UnitPrice> [Call=Parameter_UnitPrice|Double]"'(Set|Get) the Parameter_UnitPrice as Double
        Private _Parameter_UnitPrice As Double
        ''' <Summary>
        ''' (Set|Get) the Parameter_UnitPrice as Double
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 18h00:587 </Published>
        ''' <Updated>[Created=2019/05/18 18h00:587][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("UnitPrice"), Description("(Set|Get) the Parameter_UnitPrice as Double"), Browsable(True)>
        Public Property Parameter_UnitPrice() As Double
            Get
                Return _Parameter_UnitPrice
            End Get
            Set(ByVal Value As Double)
                _Parameter_UnitPrice = Value
            End Set
        End Property
#End Region ' (Set|Get) the Parameter_UnitPrice as Double
#Region "|2019/05/18 18h00:783| <01.00.15> <Property> <UnitPrice> [Call=Member_UnitPrice|Double]"'(Set|Get) the Member_UnitPrice as Double
        Private _Member_UnitPrice As Double
        ''' <Summary>
        ''' (Set|Get) the Member_UnitPrice as Double
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 18h00:783 </Published>
        ''' <Updated>[Created=2019/05/18 18h00:783][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("UnitPrice"), Description("(Set|Get) the Member_UnitPrice as Double"), Browsable(True)>
        Public Property Member_UnitPrice() As Double
            Get
                Return _Member_UnitPrice
            End Get
            Set(ByVal Value As Double)
                _Member_UnitPrice = Value
            End Set
        End Property
#End Region ' (Set|Get) the Member_UnitPrice as Double
#End Region
#Region "|01.01| <Property> [Quantity]"
#Region "|2019/05/18 17h53:011| <01.01.00> <Property> <Quantity> [Call=Quantity_Importation|Integer]"'(Set|Get) the Quantity_Importation as Integer
        Private _Quantity_Importation As Integer
        ''' <Summary>
        ''' (Set|Get) the Quantity_Importation as Integer
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 17h53:010 </Published>
        ''' <Updated>[Created=2019/05/18 17h53:010][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Quantity"), Description("(Set|Get) the Quantity_Importation as Integer"), Browsable(True)>
        Public Property Quantity_Importation() As Integer
            Get
                Return _Quantity_Importation
            End Get
            Set(ByVal Value As Integer)
                _Quantity_Importation = Value
                If Value > 0 Then
                    Recalculate()
                End If
            End Set
        End Property
#End Region ' (Set|Get) the Quantity_Importation as Integer
#Region "|2019/05/18 17h54:153| <01.01.01> <Property> <Quantity> [Call=Quantity_Property|Integer]"'(Set|Get) the Quantity_Property as Integer
        Private _Quantity_Property As Integer
        ''' <Summary>
        ''' (Set|Get) the Quantity_Property as Integer
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 17h54:153 </Published>
        ''' <Updated>[Created=2019/05/18 17h54:153][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Quantity"), Description("(Set|Get) the Quantity_Property as Integer"), Browsable(True)>
        Public Property Quantity_Property() As Integer
            Get
                Return _Quantity_Property
            End Get
            Set(ByVal Value As Integer)
                _Quantity_Property = Value
                If Value > 0 Then
                    Recalculate()
                End If
            End Set
        End Property
#End Region ' (Set|Get) the Quantity_Property as Integer
#Region "|2019/05/18 17h54:101| <01.01.02> <Property> <Quantity> [Call=Quantity_Enumeration|Integer]"'(Set|Get) the Quantity_Enumeration as Integer
        Private _Quantity_Enumeration As Integer
        ''' <Summary>
        ''' (Set|Get) the Quantity_Enumeration as Integer
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 17h54:101 </Published>
        ''' <Updated>[Created=2019/05/18 17h54:101][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Quantity"), Description("(Set|Get) the Quantity_Enumeration as Integer"), Browsable(True)>
        Public Property Quantity_Enumeration() As Integer
            Get
                Return _Quantity_Enumeration
            End Get
            Set(ByVal Value As Integer)
                _Quantity_Enumeration = Value
                If Value > 0 Then
                    Recalculate()
                End If
            End Set
        End Property
#End Region ' (Set|Get) the Quantity_Enumeration as Integer
#Region "|2019/05/18 17h54:400| <01.01.03> <Property> <Quantity> [Call=Quantity_Structure|Integer]"'(Set|Get) the Quantity_Structure as Integer
        Private _Quantity_Structure As Integer
        ''' <Summary>
        ''' (Set|Get) the Quantity_Structure as Integer
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 17h54:400 </Published>
        ''' <Updated>[Created=2019/05/18 17h54:400][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Quantity"), Description("(Set|Get) the Quantity_Structure as Integer"), Browsable(True)>
        Public Property Quantity_Structure() As Integer
            Get
                Return _Quantity_Structure
            End Get
            Set(ByVal Value As Integer)
                _Quantity_Structure = Value
                If Value > 0 Then
                    Recalculate()
                End If
            End Set
        End Property
#End Region ' (Set|Get) the Quantity_Structure as Integer
#Region "|2019/05/18 17h55:299| <01.01.04> <Property> <Quantity> [Call=Quantity_Sub|Integer]"'(Set|Get) the Quantity_Sub as Integer
        Private _Quantity_Sub As Integer
        ''' <Summary>
        ''' (Set|Get) the Quantity_Sub as Integer
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 17h55:299 </Published>
        ''' <Updated>[Created=2019/05/18 17h55:299][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Quantity"), Description("(Set|Get) the Quantity_Sub as Integer"), Browsable(True)>
        Public Property Quantity_Sub() As Integer
            Get
                Return _Quantity_Sub
            End Get
            Set(ByVal Value As Integer)
                _Quantity_Sub = Value
                If Value > 0 Then
                    Recalculate()
                End If
            End Set
        End Property
#End Region ' (Set|Get) the Quantity_Sub as Integer
#Region "|2019/05/18 17h55:668| <01.01.05> <Property> <Quantity> [Call=Quantity_Function|Integer]"'(Set|Get) the Quantity_Function as Integer
        Private _Quantity_Function As Integer
        ''' <Summary>
        ''' (Set|Get) the Quantity_Function as Integer
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 17h55:668 </Published>
        ''' <Updated>[Created=2019/05/18 17h55:668][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Quantity"), Description("(Set|Get) the Quantity_Function as Integer"), Browsable(True)>
        Public Property Quantity_Function() As Integer
            Get
                Return _Quantity_Function
            End Get
            Set(ByVal Value As Integer)
                _Quantity_Function = Value
                If Value > 0 Then
                    Recalculate()
                End If
            End Set
        End Property
#End Region ' (Set|Get) the Quantity_Function as Integer
#Region "|2019/05/18 17h55:768| <01.01.06> <Property> <Quantity> [Call=Quantity_Runtime|Integer]"'(Set|Get) the Quantity_Runtime as Integer
        Private _Quantity_Runtime As Integer
        ''' <Summary>
        ''' (Set|Get) the Quantity_Runtime as Integer
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 17h55:768 </Published>
        ''' <Updated>[Created=2019/05/18 17h55:768][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Quantity"), Description("(Set|Get) the Quantity_Runtime as Integer"), Browsable(True)>
        Public Property Quantity_Runtime() As Integer
            Get
                Return _Quantity_Runtime
            End Get
            Set(ByVal Value As Integer)
                _Quantity_Runtime = Value
                If Value > 0 Then
                    Recalculate()
                End If
            End Set
        End Property
#End Region ' (Set|Get) the Quantity_Runtime as Integer
#Region "|2019/05/18 17h56:251| <01.01.07> <Property> <Quantity> [Call=Quantity_Loader|Integer]"'(Set|Get) the Quantity_Loader as Integer
        Private _Quantity_Loader As Integer
        ''' <Summary>
        ''' (Set|Get) the Quantity_Loader as Integer
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 17h56:251 </Published>
        ''' <Updated>[Created=2019/05/18 17h56:251][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Quantity"), Description("(Set|Get) the Quantity_Loader as Integer"), Browsable(True)>
        Public Property Quantity_Loader() As Integer
            Get
                Return _Quantity_Loader
            End Get
            Set(ByVal Value As Integer)
                _Quantity_Loader = Value
                If Value > 0 Then
                    Recalculate()
                End If
            End Set
        End Property
#End Region ' (Set|Get) the Quantity_Loader as Integer
#Region "|2019/05/18 17h56:648| <01.01.08> <Property> <Quantity> [Call=Quantity_Class|Integer]"'(Set|Get) the Quantity_Class as Integer
        Private _Quantity_Class As Integer
        ''' <Summary>
        ''' (Set|Get) the Quantity_Class as Integer
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 17h56:648 </Published>
        ''' <Updated>[Created=2019/05/18 17h56:648][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Quantity"), Description("(Set|Get) the Quantity_Class as Integer"), Browsable(True)>
        Public Property Quantity_Class() As Integer
            Get
                Return _Quantity_Class
            End Get
            Set(ByVal Value As Integer)
                _Quantity_Class = Value
                If Value > 0 Then
                    Recalculate()
                End If
            End Set
        End Property
#End Region ' (Set|Get) the Quantity_Class as Integer
#Region "|2019/05/18 17h56:383| <01.01.09> <Property> <Quantity> [Call=Quantity_Constante|Integer]"'(Set|Get) the Quantity_Constante as Integer
        Private _Quantity_Constante As Integer
        ''' <Summary>
        ''' (Set|Get) the Quantity_Constante as Integer
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 17h56:383 </Published>
        ''' <Updated>[Created=2019/05/18 17h56:383][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Quantity"), Description("(Set|Get) the Quantity_Constante as Integer"), Browsable(True)>
        Public Property Quantity_Constante() As Integer
            Get
                Return _Quantity_Constante
            End Get
            Set(ByVal Value As Integer)
                _Quantity_Constante = Value
                If Value > 0 Then
                    Recalculate()
                End If
            End Set
        End Property
#End Region ' (Set|Get) the Quantity_Constante as Integer
#Region "|2019/05/18 17h57:512| <01.01.10> <Property> <Quantity> [Call=Quantity_Events|Integer]"'(Set|Get) the Quantity_Events as Integer
        Private _Quantity_Events As Integer
        ''' <Summary>
        ''' (Set|Get) the Quantity_Events as Integer
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 17h57:512 </Published>
        ''' <Updated>[Created=2019/05/18 17h57:511][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Quantity"), Description("(Set|Get) the Quantity_Events as Integer"), Browsable(True)>
        Public Property Quantity_Events() As Integer
            Get
                Return _Quantity_Events
            End Get
            Set(ByVal Value As Integer)
                _Quantity_Events = Value
                If Value > 0 Then
                    Recalculate()
                End If
            End Set
        End Property
#End Region ' (Set|Get) the Quantity_Events as Integer
#Region "|2019/05/18 17h57:437| <01.01.11> <Property> <Quantity> [Call=Quantity_DataBase|Integer]"'(Set|Get) the Quantity_DataBase as Integer
        Private _Quantity_DataBase As Integer
        ''' <Summary>
        ''' (Set|Get) the Quantity_DataBase as Integer
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 17h57:437 </Published>
        ''' <Updated>[Created=2019/05/18 17h57:437][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Quantity"), Description("(Set|Get) the Quantity_DataBase as Integer"), Browsable(True)>
        Public Property Quantity_DataBase() As Integer
            Get
                Return _Quantity_DataBase
            End Get
            Set(ByVal Value As Integer)
                _Quantity_DataBase = Value
                If Value > 0 Then
                    Recalculate()
                End If
            End Set
        End Property
#End Region ' (Set|Get) the Quantity_DataBase as Integer
#Region "|2019/05/18 17h57:297| <01.01.12> <Property> <Quantity> [Call=Quantity_Table|Integer]"'(Set|Get) the Quantity_Table as Integer
        Private _Quantity_Table As Integer
        ''' <Summary>
        ''' (Set|Get) the Quantity_Table as Integer
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 17h57:297 </Published>
        ''' <Updated>[Created=2019/05/18 17h57:297][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Quantity"), Description("(Set|Get) the Quantity_Table as Integer"), Browsable(True)>
        Public Property Quantity_Table() As Integer
            Get
                Return _Quantity_Table
            End Get
            Set(ByVal Value As Integer)
                _Quantity_Table = Value

                If Value > 0 Then
                    Recalculate()
                End If
            End Set
        End Property
#End Region ' (Set|Get) the Quantity_Table as Integer
#Region "|2019/05/18 17h58:684| <01.01.13> <Property> <Quantity> [Call=Quantity_Fichier|Integer]"'(Set|Get) the Quantity_Fichier as Integer
        Private _Quantity_Fichier As Integer
        ''' <Summary>
        ''' (Set|Get) the Quantity_Fichier as Integer
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 17h58:684 </Published>
        ''' <Updated>[Created=2019/05/18 17h58:684][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Quantity"), Description("(Set|Get) the Quantity_Fichier as Integer"), Browsable(True)>
        Public Property Quantity_Fichier() As Integer
            Get
                Return _Quantity_Fichier
            End Get
            Set(ByVal Value As Integer)
                _Quantity_Fichier = Value
                If Value > 0 Then
                    Recalculate()
                End If
            End Set
        End Property
#End Region ' (Set|Get) the Quantity_Fichier as Integer
#Region "|2019/05/18 17h58:445| <01.01.14> <Property> <Quantity> [Call=Quantity_Parameter|Integer]"'(Set|Get) the Quantity_Parameter as Integer
        Private _Quantity_Parameter As Integer
        ''' <Summary>
        ''' (Set|Get) the Quantity_Parameter as Integer
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 17h58:445 </Published>
        ''' <Updated>[Created=2019/05/18 17h58:445][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Quantity"), Description("(Set|Get) the Quantity_Parameter as Integer"), Browsable(True)>
        Public Property Quantity_Parameter() As Integer
            Get
                Return _Quantity_Parameter
            End Get
            Set(ByVal Value As Integer)
                _Quantity_Parameter = Value
                If Value > 0 Then
                    Recalculate()
                End If
            End Set
        End Property
#End Region ' (Set|Get) the Quantity_Parameter as Integer
#Region "|2019/05/18 17h59:147| <01.01.15> <Property> <Quantity> [Call=Quantity_Member|Integer]"'(Set|Get) the Quantity_Member as Integer
        Private _Quantity_Member As Integer
        ''' <Summary>
        ''' (Set|Get) the Quantity_Member as Integer
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 17h59:147 </Published>
        ''' <Updated>[Created=2019/05/18 17h59:147][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Quantity"), Description("(Set|Get) the Quantity_Member as Integer"), Browsable(True)>
        Public Property Quantity_Member() As Integer
            Get
                Return _Quantity_Member
            End Get
            Set(ByVal Value As Integer)
                _Quantity_Member = Value
                If Value > 0 Then
                    Recalculate()
                End If
            End Set
        End Property
#End Region ' (Set|Get) the Quantity_Member as Integer
#End Region
#Region "|01.02| <Property> [SubTotal]"
#Region "|2019/05/18 18h02:913| <01.02.00> <Property> <SubTotal> [Call=SubTotal_Importation|Double]"'(Set|Get) the SubTotal_Importation as Double
        Private _SubTotal_Importation As Double
        ''' <Summary>
        ''' (Set|Get) the SubTotal_Importation as Double
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 18h02:913 </Published>
        ''' <Updated>[Created=2019/05/18 18h02:913][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("SubTotal"), Description("(Set|Get) the SubTotal_Importation as Double"), Browsable(True)>
        Public Property SubTotal_Importation() As Double
            Get
                Return _SubTotal_Importation
            End Get
            Set(ByVal Value As Double)
                _SubTotal_Importation = Value
            End Set
        End Property
#End Region ' (Set|Get) the SubTotal_Importation as Double
#Region "|2019/05/18 18h02:873| <01.02.01> <Property> <SubTotal> [Call=SubTotal_Property|Double]"'(Set|Get) the SubTotal_Property as Double
        Private _SubTotal_Property As Double
        ''' <Summary>
        ''' (Set|Get) the SubTotal_Property as Double
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 18h02:873 </Published>
        ''' <Updated>[Created=2019/05/18 18h02:873][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("SubTotal"), Description("(Set|Get) the SubTotal_Property as Double"), Browsable(True)>
        Public Property SubTotal_Property() As Double
            Get
                Return _SubTotal_Property
            End Get
            Set(ByVal Value As Double)
                _SubTotal_Property = Value
            End Set
        End Property
#End Region ' (Set|Get) the SubTotal_Property as Double
#Region "|2019/05/18 18h03:063| <01.02.02> <Property> <SubTotal> [Call=SubTotal_Enumeration|Double]"'(Set|Get) the SubTotal_Enumeration as Double
        Private _SubTotal_Enumeration As Double
        ''' <Summary>
        ''' (Set|Get) the SubTotal_Enumeration as Double
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 18h03:063 </Published>
        ''' <Updated>[Created=2019/05/18 18h03:063][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("SubTotal"), Description("(Set|Get) the SubTotal_Enumeration as Double"), Browsable(True)>
        Public Property SubTotal_Enumeration() As Double
            Get
                Return _SubTotal_Enumeration
            End Get
            Set(ByVal Value As Double)
                _SubTotal_Enumeration = Value
            End Set
        End Property
#End Region ' (Set|Get) the SubTotal_Enumeration as Double
#Region "|2019/05/18 18h03:606| <01.02.03> <Property> <SubTotal> [Call=SubTotal_Structure|Double]"'(Set|Get) the SubTotal_Structure as Double
        Private _SubTotal_Structure As Double
        ''' <Summary>
        ''' (Set|Get) the SubTotal_Structure as Double
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 18h03:606 </Published>
        ''' <Updated>[Created=2019/05/18 18h03:606][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("SubTotal"), Description("(Set|Get) the SubTotal_Structure as Double"), Browsable(True)>
        Public Property SubTotal_Structure() As Double
            Get
                Return _SubTotal_Structure
            End Get
            Set(ByVal Value As Double)
                _SubTotal_Structure = Value
            End Set
        End Property
#End Region ' (Set|Get) the SubTotal_Structure as Double
#Region "|2019/05/18 18h03:184| <01.02.04> <Property> <SubTotal> [Call=SubTotal_Sub|Double]"'(Set|Get) the SubTotal_Sub as Double
        Private _SubTotal_Sub As Double
        ''' <Summary>
        ''' (Set|Get) the SubTotal_Sub as Double
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 18h03:184 </Published>
        ''' <Updated>[Created=2019/05/18 18h03:184][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("SubTotal"), Description("(Set|Get) the SubTotal_Sub as Double"), Browsable(True)>
        Public Property SubTotal_Sub() As Double
            Get
                Return _SubTotal_Sub
            End Get
            Set(ByVal Value As Double)
                _SubTotal_Sub = Value
            End Set
        End Property
#End Region ' (Set|Get) the SubTotal_Sub as Double
#Region "|2019/05/18 18h04:907| <01.02.05> <Property> <SubTotal> [Call=SubTotal_Function|Double]"'(Set|Get) the SubTotal_Function as Double
        Private _SubTotal_Function As Double
        ''' <Summary>
        ''' (Set|Get) the SubTotal_Function as Double
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 18h04:907 </Published>
        ''' <Updated>[Created=2019/05/18 18h04:907][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("SubTotal"), Description("(Set|Get) the SubTotal_Function as Double"), Browsable(True)>
        Public Property SubTotal_Function() As Double
            Get
                Return _SubTotal_Function
            End Get
            Set(ByVal Value As Double)
                _SubTotal_Function = Value
            End Set
        End Property
#End Region ' (Set|Get) the SubTotal_Function as Double
#Region "|2019/05/18 18h04:426| <01.02.06> <Property> <SubTotal> [Call=SubTotal_Runtime|Double]"'(Set|Get) the SubTotal_Runtime as Double
        Private _SubTotal_Runtime As Double
        ''' <Summary>
        ''' (Set|Get) the SubTotal_Runtime as Double
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 18h04:426 </Published>
        ''' <Updated>[Created=2019/05/18 18h04:426][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("SubTotal"), Description("(Set|Get) the SubTotal_Runtime as Double"), Browsable(True)>
        Public Property SubTotal_Runtime() As Double
            Get
                Return _SubTotal_Runtime
            End Get
            Set(ByVal Value As Double)
                _SubTotal_Runtime = Value
            End Set
        End Property
#End Region ' (Set|Get) the SubTotal_Runtime as Double
#Region "|2019/05/18 18h04:924| <01.02.07> <Property> <SubTotal> [Call=SubTotal_Loader|Double]"'(Set|Get) the SubTotal_Loader as Double
        Private _SubTotal_Loader As Double
        ''' <Summary>
        ''' (Set|Get) the SubTotal_Loader as Double
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 18h04:924 </Published>
        ''' <Updated>[Created=2019/05/18 18h04:924][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("SubTotal"), Description("(Set|Get) the SubTotal_Loader as Double"), Browsable(True)>
        Public Property SubTotal_Loader() As Double
            Get
                Return _SubTotal_Loader
            End Get
            Set(ByVal Value As Double)
                _SubTotal_Loader = Value
            End Set
        End Property
#End Region ' (Set|Get) the SubTotal_Loader as Double
#Region "|2019/05/18 18h04:675| <01.02.08> <Property> <SubTotal> [Call=SubTotal_Class|Double]"'(Set|Get) the SubTotal_Class as Double
        Private _SubTotal_Class As Double
        ''' <Summary>
        ''' (Set|Get) the SubTotal_Class as Double
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 18h04:675 </Published>
        ''' <Updated>[Created=2019/05/18 18h04:675][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("SubTotal"), Description("(Set|Get) the SubTotal_Class as Double"), Browsable(True)>
        Public Property SubTotal_Class() As Double
            Get
                Return _SubTotal_Class
            End Get
            Set(ByVal Value As Double)
                _SubTotal_Class = Value
            End Set
        End Property
#End Region ' (Set|Get) the SubTotal_Class as Double
#Region "|2019/05/18 18h05:158| <01.02.09> <Property> <SubTotal> [Call=SubTotal_Constante|Double]"'(Set|Get) the SubTotal_Constante as Double
        Private _SubTotal_Constante As Double
        ''' <Summary>
        ''' (Set|Get) the SubTotal_Constante as Double
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 18h05:158 </Published>
        ''' <Updated>[Created=2019/05/18 18h05:158][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("SubTotal"), Description("(Set|Get) the SubTotal_Constante as Double"), Browsable(True)>
        Public Property SubTotal_Constante() As Double
            Get
                Return _SubTotal_Constante
            End Get
            Set(ByVal Value As Double)
                _SubTotal_Constante = Value
            End Set
        End Property
#End Region ' (Set|Get) the SubTotal_Constante as Double
#Region "|2019/05/18 18h05:407| <01.02.10> <Property> <SubTotal> [Call=SubTotal_Events|Double]"'(Set|Get) the SubTotal_Events as Double
        Private _SubTotal_Events As Double
        ''' <Summary>
        ''' (Set|Get) the SubTotal_Events as Double
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 18h05:407 </Published>
        ''' <Updated>[Created=2019/05/18 18h05:407][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("SubTotal"), Description("(Set|Get) the SubTotal_Events as Double"), Browsable(True)>
        Public Property SubTotal_Events() As Double
            Get
                Return _SubTotal_Events
            End Get
            Set(ByVal Value As Double)
                _SubTotal_Events = Value
            End Set
        End Property
#End Region ' (Set|Get) the SubTotal_Events as Double
#Region "|2019/05/18 18h06:460| <01.02.11> <Property> <SubTotal> [Call=SubTotal_DataBase|Double]"'(Set|Get) the SubTotal_DataBase as Double
        Private _SubTotal_DataBase As Double
        ''' <Summary>
        ''' (Set|Get) the SubTotal_DataBase as Double
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 18h06:460 </Published>
        ''' <Updated>[Created=2019/05/18 18h06:460][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("SubTotal"), Description("(Set|Get) the SubTotal_DataBase as Double"), Browsable(True)>
        Public Property SubTotal_DataBase() As Double
            Get
                Return _SubTotal_DataBase
            End Get
            Set(ByVal Value As Double)
                _SubTotal_DataBase = Value
            End Set
        End Property
#End Region ' (Set|Get) the SubTotal_DataBase as Double
#Region "|2019/05/18 18h06:683| <01.02.12> <Property> <SubTotal> [Call=SubTotal_Table|Double]"'(Set|Get) the SubTotal_Table as Double
        Private _SubTotal_Table As Double
        ''' <Summary>
        ''' (Set|Get) the SubTotal_Table as Double
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 18h06:683 </Published>
        ''' <Updated>[Created=2019/05/18 18h06:683][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("SubTotal"), Description("(Set|Get) the SubTotal_Table as Double"), Browsable(True)>
        Public Property SubTotal_Table() As Double
            Get
                Return _SubTotal_Table
            End Get
            Set(ByVal Value As Double)
                _SubTotal_Table = Value
            End Set
        End Property
#End Region ' (Set|Get) the SubTotal_Table as Double
#Region "|2019/05/18 18h07:867| <01.02.13> <Property> <SubTotal> [Call=SubTotal_Fichier|Double]"'(Set|Get) the SubTotal_Table as Double
        Private _SubTotal_Fichier As Double
        ''' <Summary>
        ''' (Set|Get) the SubTotal_Table as Double
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 18h07:867 </Published>
        ''' <Updated>[Created=2019/05/18 18h07:867][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("SubTotal"), Description("(Set|Get) the SubTotal_Table as Double"), Browsable(True)>
        Public Property SubTotal_Fichier() As Double
            Get
                Return _SubTotal_Fichier
            End Get
            Set(ByVal Value As Double)
                _SubTotal_Fichier = Value
            End Set
        End Property
#End Region ' (Set|Get) the SubTotal_Table as Double
#Region "|2019/05/18 18h07:155| <01.02.14> <Property> <SubTotal> [Call=SubTotal_Parameter|Double]"'(Set|Get) the SubTotal_Parameter as Double
        Private _SubTotal_Parameter As Double
        ''' <Summary>
        ''' (Set|Get) the SubTotal_Parameter as Double
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 18h07:155 </Published>
        ''' <Updated>[Created=2019/05/18 18h07:155][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("SubTotal"), Description("(Set|Get) the SubTotal_Parameter as Double"), Browsable(True)>
        Public Property SubTotal_Parameter() As Double
            Get
                Return _SubTotal_Parameter
            End Get
            Set(ByVal Value As Double)
                _SubTotal_Parameter = Value
            End Set
        End Property
#End Region ' (Set|Get) the SubTotal_Parameter as Double
#Region "|2019/05/18 18h07:400| <01.02.15> <Property> <SubTotal> [Call=SubTotal_Member|Double]"'(Set|Get) the SubTotal_Member as Double
        Private _SubTotal_Member As Double
        ''' <Summary>
        ''' (Set|Get) the SubTotal_Member as Double
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 18h07:400 </Published>
        ''' <Updated>[Created=2019/05/18 18h07:400][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("SubTotal"), Description("(Set|Get) the SubTotal_Member as Double"), Browsable(True)>
        Public Property SubTotal_Member() As Double
            Get
                Return _SubTotal_Member
            End Get
            Set(ByVal Value As Double)
                _SubTotal_Member = Value
            End Set
        End Property
#End Region ' (Set|Get) the SubTotal_Member as Double

#End Region

        'String.Format("{0:n2}",


#Region "|01.03| <Property> [Total]"
#Region "|2019/05/18 18h08:283| <01.03.00> <Property> <Total> [Call=Total_BeforeDiscount|Double]"'(Set|Get) the Total_BeforeDiscount as Double
        Private _Total_BeforeDiscount As Double
        ''' <Summary>
        ''' (Set|Get) the Total_BeforeDiscount as Double
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 18h08:283 </Published>
        ''' <Updated>[Created=2019/05/18 18h08:283][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Total"), Description("(Set|Get) the Total_BeforeDiscount as Double"), Browsable(True)>
        Public Property Total_BeforeDiscount() As Double
            Get
                Return _Total_BeforeDiscount
            End Get
            Set(ByVal Value As Double)
                _Total_BeforeDiscount = Math.Round(Value, 2)
            End Set
        End Property
#End Region ' (Set|Get) the Total_BeforeDiscount as Double
#Region "|2019/05/18 18h09:116| <01.03.01> <Property> <Total> [Call=Discount_Percentage|Double]"'(Set|Get) the Discount_Percentage as Double
        Private _Discount_Percentage As Double
        ''' <Summary>
        ''' (Set|Get) the Discount_Percentage as Double
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 18h09:116 </Published>
        ''' <Updated>[Created=2019/05/18 18h09:116][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Total"), Description("(Set|Get) the Discount_Percentage as Double"), Browsable(True)>
        Public Property Discount_Percentage() As Double
            Get
                Return _Discount_Percentage
            End Get
            Set(ByVal Value As Double)
                If Discount_Enable = True Then
                    If Value > 0 And Value < 1 Then
                        Discount = Math.Round(Total_BeforeDiscount * Value, 2)
                        _Discount_Percentage = Math.Round(Value * 100, 2)
                    ElseIf Value > 1 And Value < 100 Then
                        Discount = Math.Round((Total_BeforeDiscount * Value / 100), 2)
                        _Discount_Percentage = Math.Round(Value, 2)
                    End If
                Else
                    _Discount_Percentage = Value
                End If
            End Set
        End Property
#End Region ' (Set|Get) the Discount_Percentage as Double
#Region "|2019/05/18 18h10:983| <01.03.02> <Property> <Total> [Call=Discount|Double]"'(Set|Get) the Discount as Double
        Private _Discount As Double
        ''' <Summary>
        ''' (Set|Get) the Discount as Double
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 18h10:983 </Published>
        ''' <Updated>[Created=2019/05/18 18h10:983][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Total"), Description("(Set|Get) the Discount as Double"), Browsable(True)>
        Public Property Discount() As Double
            Get
                Return _Discount
            End Get
            Set(ByVal Value As Double)
                If Discount_Enable = True Then
                    _Discount = Value
                Else
                    _Discount = 0
                End If
            End Set
        End Property
#End Region ' (Set|Get) the Discount as Double
#Region "|2019/05/18 18h10:303| <01.03.03> <Property> <Total> [Call=Discount_Enable|Boolean]"'(Set|Get) the Discount_Enable as Boolean
        Private _Discount_Enable As Boolean
        ''' <Summary>
        ''' (Set|Get) the Discount_Enable as Boolean
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 18h10:303 </Published>
        ''' <Updated>[Created=2019/05/18 18h10:303][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Total"), Description("(Set|Get) the Discount_Enable as Boolean"), Browsable(True)>
        Public Property Discount_Enable() As Boolean
            Get
                Return _Discount_Enable
            End Get
            Set(ByVal Value As Boolean)
                _Discount_Enable = Value
            End Set
        End Property
#End Region ' (Set|Get) the Discount_Enable as Boolean
#Region "|2019/05/18 18h11:068| <01.03.04> <Property> <Total> [Call=VAT_Enable|Boolean]"'(Set|Get) the VAT_Enable as Boolean
        Private _VAT_Enable As Boolean
        ''' <Summary>
        ''' (Set|Get) the VAT_Enable as Boolean
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 18h11:068 </Published>
        ''' <Updated>[Created=2019/05/18 18h11:068][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Total"), Description("(Set|Get) the VAT_Enable as Boolean"), Browsable(True)>
        Public Property VAT_Enable() As Boolean
            Get
                Return _VAT_Enable
            End Get
            Set(ByVal Value As Boolean)
                _VAT_Enable = Value
            End Set
        End Property
#End Region ' (Set|Get) the VAT_Enable as Boolean
#Region "|2019/05/18 18h12:331| <01.03.05> <Property> <Total> [Call=VAT|Double]"'(Set|Get) the VAT as Double
        Private _VAT As Double
        ''' <Summary>
        ''' (Set|Get) the VAT as Double
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 18h12:331 </Published>
        ''' <Updated>[Created=2019/05/18 18h12:331][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Total"), Description("(Set|Get) the VAT as Double"), Browsable(True)>
        Public Property VAT() As Double
            Get
                Return _VAT
            End Get
            Set(ByVal Value As Double)
                _VAT = Math.Round(Value, 2)
            End Set
        End Property
#End Region ' (Set|Get) the VAT as Double
#Region "|2019/05/18 18h36:119| <01.03.06> <Property> <Total> [Call=Total_HVAT|Double]"'(Set|Get) the Total without VAT as Double.
        Private _Total_HVAT As Double
        ''' <Summary>
        ''' (Set|Get) the Total without VAT as Double.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 18h36:119 </Published>
        ''' <Updated>[Created=2019/05/18 18h36:119][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Total"), Description("(Set|Get) the Total without VAT as Double."), Browsable(True)>
        Public Property Total_HVAT() As Double
            Get
                Return _Total_HVAT
            End Get
            Set(ByVal Value As Double)
                _Total_HVAT = Value
            End Set
        End Property
#End Region ' (Set|Get) the Total without VAT as Double.

#Region "|2019/05/18 18h12:798| <01.03.07> <Property> <Total> [Call=GrandTotal|Double]"'(Set|Get) the GrandTotal as Double
        Private _GrandTotal As Double
        ''' <Summary>
        ''' (Set|Get) the GrandTotal as Double
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/18 18h12:798 </Published>
        ''' <Updated>[Created=2019/05/18 18h12:798][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Total"), Description("(Set|Get) the GrandTotal as Double"), Browsable(True)>
        Public Property GrandTotal() As Double
            Get
                Return _GrandTotal
            End Get
            Set(ByVal Value As Double)
                _GrandTotal = Value
            End Set
        End Property
#End Region ' (Set|Get) the GrandTotal as Double
#End Region
#End Region
        Public Sub ResetPrice()
            Importation_UnitPrice = My.Settings.Price_Import
            Property_UnitPrice = My.Settings.Price_Property
            Enumeration_UnitPrice = My.Settings.Price_Enumeration
            Structure_UnitPrice = My.Settings.Price_Structure
            Sub_UnitPrice = My.Settings.Price_Sub
            Function_UnitPrice = My.Settings.Price_Function
            Runtime_UnitPrice = My.Settings.Price_Runtime
            Loader_UnitPrice = My.Settings.Price_Loader
            Class_UnitPrice = My.Settings.Price_Class
            Constante_UnitPrice = My.Settings.Price_Constante
            Events_UnitPrice = My.Settings.Price_Events
            DataBase_UnitPrice = My.Settings.Price_DataBase
            Table_UnitPrice = My.Settings.Price_Table
            Fichier_UnitPrice = My.Settings.Price_Fichier
            Parameter_UnitPrice = My.Settings.Price_Parameter
            Member_UnitPrice = My.Settings.Price_Member
            Class_UnitPrice = My.Settings.Price_Class
        End Sub
        Public Sub Recalculate(Optional ByVal PercentageDiscount As Double = 0,
                               Optional ByVal WithVAT As Boolean = False)
            SubTotal_Importation = Math.Round(Quantity_Importation * Importation_UnitPrice, 2)
            SubTotal_Property = Math.Round(Quantity_Property * Property_UnitPrice, 2)
            SubTotal_Enumeration = Math.Round(Quantity_Enumeration * Enumeration_UnitPrice, 2)
            SubTotal_Structure = Math.Round(Quantity_Structure * Structure_UnitPrice, 2)
            SubTotal_Sub = Math.Round(Quantity_Sub * Sub_UnitPrice, 2)
            SubTotal_Function = Math.Round(Quantity_Function * Function_UnitPrice, 2)
            SubTotal_Runtime = Math.Round(Quantity_Runtime * Runtime_UnitPrice, 2)
            SubTotal_Loader = Math.Round(Quantity_Loader * Loader_UnitPrice, 2)
            SubTotal_Class = Math.Round(Quantity_Class * Class_UnitPrice, 2)
            SubTotal_Constante = Math.Round(Quantity_Constante * Constante_UnitPrice, 2)
            SubTotal_DataBase = Math.Round(Quantity_DataBase * DataBase_UnitPrice, 2)
            SubTotal_Table = Math.Round(Quantity_Table * Table_UnitPrice, 2)
            SubTotal_Fichier = Math.Round(Quantity_Fichier * Fichier_UnitPrice, 2)
            SubTotal_Parameter = Math.Round(Quantity_Parameter * Parameter_UnitPrice, 2)
            SubTotal_Member = Math.Round(Quantity_Member * Member_UnitPrice, 2)
            SubTotal_Events = Math.Round(Quantity_Events * Events_UnitPrice, 2)
            If PercentageDiscount > 0 Then
                Discount_Enable = True

                Total_BeforeDiscount = Math.Round(SubTotal_Importation +
                                            SubTotal_Property +
                                            SubTotal_Enumeration +
                                            SubTotal_Structure +
                                            SubTotal_Sub +
                                            SubTotal_Function +
                                            SubTotal_Runtime +
                                            SubTotal_Loader +
                                            SubTotal_Class +
                                            SubTotal_Constante +
                                            SubTotal_Events +
                                            SubTotal_DataBase +
                                            SubTotal_Table +
                                            SubTotal_Fichier +
                                            SubTotal_Parameter +
                                            SubTotal_Member, 2)
                Discount_Percentage = PercentageDiscount
                Total_HVAT = Math.Round(Total_BeforeDiscount - Discount)
            Else
                Total_HVAT = Math.Round(SubTotal_Importation +
                                            SubTotal_Property +
                                            SubTotal_Enumeration +
                                            SubTotal_Structure +
                                            SubTotal_Sub +
                                            SubTotal_Function +
                                            SubTotal_Runtime +
                                            SubTotal_Loader +
                                            SubTotal_Class +
                                            SubTotal_Constante +
                                            SubTotal_Events +
                                            SubTotal_DataBase +
                                            SubTotal_Table +
                                            SubTotal_Fichier +
                                            SubTotal_Parameter +
                                            SubTotal_Member, 2)
            End If
            Me.VAT_Enable = True
            If WithVAT = True Then
                VAT = (Total_HVAT * My.Settings.VAT)
                GrandTotal = Math.Round(Total_HVAT + VAT, 2)
            Else
                GrandTotal = Math.Round(Total_HVAT, 2)

            End If
        End Sub

#Region "|7| [Loader]"
        Public Sub New()
            ResetPrice()
        End Sub
#End Region
    End Class
End Module
