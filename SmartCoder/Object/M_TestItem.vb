Imports System.ComponentModel
Imports System.Windows.Forms

Public Module M_TestItem



    Public Class CategoryPortfolio

#Region "|01| [Property]"
#Region "|01.00| <Property> [Info]()"
#Region "[On] |2020/06/16 17h14:661| <01.00.00> <Property> <Info> |.Name()| String|"' (Set|Get) The Name as  String.
        Private _Name As String
        '''    <Summary>
        '''     (Set|Get) The Name as  String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>TOWER1 From TOWER1\Saadry | Time : 2020/06/16 17h14:673 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Info"), Description("(Set|Get) The Name as  String.")>
        Public Property [Name]() As String
            Get
                Return _Name
            End Get
            Set(ByVal Value As String)
                _Name = Value
            End Set
        End Property
#End Region '(Set|Get) The Name as  String.
#Region "[On] |2020/06/16 17h14:105| <01.00.01> <Property> <Info> |.ID()|Integer|"' (Set|Get) The ID as Integer.
        Private _ID As Integer
        '''    <Summary>
        '''     (Set|Get) The ID as Integer.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>TOWER1 From TOWER1\Saadry | Time : 2020/06/16 17h14:109 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Info"), Description("(Set|Get) The ID as Integer.")>
        Public Property [ID]() As Integer
            Get
                Return _ID
            End Get
            Set(ByVal Value As Integer)
                _ID = Value
            End Set
        End Property
#End Region '(Set|Get) The ID as Integer.
#Region "[On] |2020/06/16 17h15:359| <01.00.02> <Property> <Info> |.Properties()|List(Of VbNET.Property)|"' (Set|Get) The Properties as List(Of VbNET.Property).
        Private _Properties As List(Of VbNET.Property)
        '''    <Summary>
        '''     (Set|Get) The Properties as List(Of VbNET.Property).
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>TOWER1 From TOWER1\Saadry | Time : 2020/06/16 17h15:363 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Info"), Description("(Set|Get) The Properties as List(Of VbNET.Property).")>
        Public Property [Properties]() As List(Of VbNET.Property)
            Get
                Return _Properties
            End Get
            Set(ByVal Value As List(Of VbNET.Property))
                _Properties = Value
            End Set
        End Property
#End Region '(Set|Get) The Properties as List(Of VbNET.Property).
#End Region
#End Region

        Public Sub New()
            With Me
                .Name = ""
                .ID = 0
                .Properties = New List(Of VbNET.Property)
            End With
        End Sub

    End Class












    Public Class TestDLL
        Inherits TestItem
#Region "<0> [Properties]"
#Region "<00.00> <Properties> [Assembly]"
#Region "<00.00.00> <Properties> <Assembly> [Classes | DevComponent.AdvTree.Node ]"


#End Region


#End Region

#End Region
        Public Sub New(_Name As String, _Hypothesis As String, Optional _Status As Status = Status.Running, Optional _Ref As String = "", Optional _SelectedObject As Object = Nothing)
            MyBase.New(_Name, _Hypothesis, _Status, _Ref, _SelectedObject)
        End Sub
        Public Sub New()
            MyBase.New("ToolBoxDLL", "Suivi des outils utilisés pendant l'utilisation du programme.", Status.Online, "New", My.Settings)
#Region "<Initialise>"
            Walkthrough = New List(Of Steps)
            Bugs = New List(Of Bug)
            Events = New List(Of Evenement)
            If IsNothing(List_Fails) Then
                List_Fails = New List(Of TestItem)
            End If
            If IsNothing(List_Pass) Then
                List_Pass = New List(Of TestItem)
            End If
            If IsNothing(List_Nul) Then
                List_Nul = New List(Of TestItem)
            End If
            If IsNothing(List_Warning) Then
                List_Warning = New List(Of TestItem)
            End If
            Me.Node = New DevComponents.AdvTree.Node
            Me.Nod = New TreeNode
            Me.NodeG = New DevComponents.Tree.Node
            Me.DataSource = New List(Of Object)
            OutputParams = New List(Of Input_Parameters)
#End Region
            ' Me.Body += LOG_NOTE & vbNewLine
            With Me
                .InputParams = New List(Of Input_Parameters)
                .ID = 0
                .Status = Status.StandBye
                .Time = Now
                .Text = Hypothesis
                .Count = 0
                .Count_Fail = 0
                .Count_Nul = 0
                .Count_Pass = 0
                .Count_Warning = 0
            End With
#Region "<Classes>"

#End Region
        End Sub
    End Class
End Module
