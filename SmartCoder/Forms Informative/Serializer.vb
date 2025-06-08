Imports System.ComponentModel
Imports System.IO
Imports System.Xml.Serialization

Public Class Serializer
#Region "|2019/04/17 13h29:468| <01.00.00> <Property> <Tool> [Call=XmlTool|Xml.Serialization.XmlSerializer]"'(Set|Get) the XmlTool as Xml.Serialization.XmlSerializer
    Private _XmlTool As Xml.Serialization.XmlSerializer
    ''' <Summary>
    ''' (Set|Get) the XmlTool as Xml.Serialization.XmlSerializer
    ''' </Summary>
    ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
    ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
    ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
    ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/17 13h29:468 </Published>
    ''' <Updated>[Created=2019/04/17 13h29:467][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

    <CategoryAttribute("Tool"),
Description("(Set|Get) the XmlTool as Xml.Serialization.XmlSerializer"),
Browsable(True)>
    Public Property XmlTool() As Xml.Serialization.XmlSerializer
        Get
            Return _XmlTool
        End Get
        Set(ByVal Value As Xml.Serialization.XmlSerializer)
            _XmlTool = Value
        End Set
    End Property
#End Region ' (Set|Get) the XmlTool as Xml.Serialization.XmlSerializer
    Dim Text2 As IO.TextWriter
    Dim Path As String = ""
    Public Sub New(ByVal Obj As Object)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If Not IsNothing(Obj) Then
            XmlTool = New Xml.Serialization.XmlSerializer(Obj.GetType)
            AdvProperty.SelectedObject = XmlTool
            Path = My.Application.Info.DirectoryPath & "\" & Obj.Name & ".xml"
            Text2 = New StreamWriter(Path)
            XmlTool.Serialize(Text2, Obj)
            Statement.OpenFile(Path)



        End If
    End Sub
    ''' <summary>
    ''' Serialize an object statement accroding to project name
    ''' </summary>
    ''' <param name="Obj"></param>
    ''' <returns></returns>
    Public Shared Function Serialize(ByVal Obj As Object) As TestItem
        Dim Result As New TestItem("Builder.Serialize", "Serialize a Statement")
        Dim Path As String = My.Application.Info.DirectoryPath & "\Serialized object\"

        If Not IsNothing(Obj) Then
            ' Result.AddParam("Obj", Obj, Obj.Name)
        End If

        If Not IsNothing(VirtualClass) Then
            If VirtualClass.ClassName <> "" Then
                Path += VirtualClass.ClassName & "\"
            End If
        End If
#Region "<Possibilities>"
        Dim Obj_Importation As New VbNET.Import
        Dim Obj_Property As New VbNET.Property
        Dim Obj_Enumeration As New VbNET.Enumeration
        Dim Obj_Structure As New VbNET.Structure
        Dim Obj_Sub As New VbNET.Sub
        Dim Obj_Function As New VbNET.Function
        Dim Obj_Runtime As New VbNET.Runtime
        Dim Obj_Loader As New VbNET.Loader
        Dim Obj_Class As New VbNET.Class
        Dim Obj_Module As New VbNET.Module
        Dim Obj_Constante As New VbNET.Constante
        Dim Obj_Event As New VbNET.Event
        Dim Obj_Declare As New VbNET.Declare
        Dim Obj_Delegate As New VbNET.Delegate
#End Region
        If TypeOf Obj Is VbNET.Import Then
            Obj_Importation = Obj
            Path += "\Importation\" & Obj_Importation.Name & ".Import "
            If IO.Directory.Exists(IO.Path.GetDirectoryName(Path)) = False Then
                IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(Path))
            End If
            ' Result.AddParam("Path", Path, Path)
            ' Result.AddParam("Obj_Importation", Obj_Importation, Obj_Importation.Name)
        ElseIf TypeOf Obj Is VbNET.Property Then
            Obj_Property = Obj
            Path += "\Property\" & Obj_Property.Name & ".Property "
            If IO.Directory.Exists(IO.Path.GetDirectoryName(Path)) = False Then
                IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(Path))
            End If
            ' Result.AddParam("Path", Path, Path)
            ' Result.AddParam("Obj_Property", Obj_Property, Obj_Property.Name)
        ElseIf TypeOf Obj Is VbNET.Enumeration Then
            Obj_Enumeration = Obj
            Path += "\Enumeration\" & Obj_Enumeration.Name & ".Enumeration"
            If IO.Directory.Exists(IO.Path.GetDirectoryName(Path)) = False Then
                IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(Path))
            End If
            ' Result.AddParam("Path", Path, Path)
            ' Result.AddParam("Obj_Enumeration", Obj_Enumeration, Obj_Enumeration.Name)
        ElseIf TypeOf Obj Is VbNET.Structure Then
            Obj_Structure = Obj
            Path += "\Structure\" & Obj_Structure.Name & ".Structure "
            If IO.Directory.Exists(IO.Path.GetDirectoryName(Path)) = False Then
                IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(Path))
            End If
            ' Result.AddParam("Path", Path, Path)
            '' Result.AddParam("Obj_Structure", Obj_Structure, Obj_Structure.Name)
        ElseIf TypeOf Obj Is VbNET.Sub Then
            Obj_Sub = Obj
            Path += "\Sub\" & Obj_Sub.Name & ".Sub "
            If IO.Directory.Exists(IO.Path.GetDirectoryName(Path)) = False Then
                IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(Path))
            End If
            '  Result.AddParam("Path", Path, Path)
            ' Result.AddParam("Obj_Sub", Obj_Sub, Obj_Sub.Name)

        ElseIf TypeOf Obj Is VbNET.Function Then
            Obj_Function = Obj
            Path += "\Function\" & Obj_Function.Name & ".Function "
            If IO.Directory.Exists(IO.Path.GetDirectoryName(Path)) = False Then
                IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(Path))
            End If
            ' Result.AddParam("Path", Path, Path)
            ' Result.AddParam("Obj_Function", Obj_Function, Obj_Function.Name)
        ElseIf TypeOf Obj Is VbNET.Runtime Then
            Obj_Runtime = Obj
            Path += "\Runtime\" & Obj_Runtime.Name & ".Runtime "
            If IO.Directory.Exists(IO.Path.GetDirectoryName(Path)) = False Then
                IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(Path))
            End If
            ' Result.AddParam("Path", Path, Path)
            ' Result.AddParam("Obj_Runtime", Obj_Runtime, Obj_Runtime.Name)
        ElseIf TypeOf Obj Is VbNET.Loader Then
            Obj_Loader = Obj
            Path += "\Loader\" & Obj_Loader.Name & ".Loader "
            If IO.Directory.Exists(IO.Path.GetDirectoryName(Path)) = False Then
                IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(Path))
            End If
            ' Result.AddParam("Path", Path, Path)
            ' Result.AddParam("Obj_Loader", Obj_Loader, Obj_Loader.Name)
        ElseIf TypeOf Obj Is VbNET.Class Then
            Obj_Class = Obj
            Path += "\Class\" & Obj_Class.Name & ".Class "
            If IO.Directory.Exists(IO.Path.GetDirectoryName(Path)) = False Then
                IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(Path))
            End If
            ' Result.AddParam("Path", Path, Path)
            ' Result.AddParam("Obj_Class", Obj_Class, Obj_Class.Name)
        ElseIf TypeOf Obj Is VbNET.Module Then
            Obj_Module = Obj
            Path += "\Module\" & Obj_Module.Name & ".Module "
            If IO.Directory.Exists(IO.Path.GetDirectoryName(Path)) = False Then
                IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(Path))
            End If
            ' Result.AddParam("Path", Path, Path)
            '  Result.AddParam("Obj_Module", Obj_Module, Obj_Module.Name)
        ElseIf TypeOf Obj Is VbNET.Constante Then
            Obj_Constante = Obj
            Path += "\Constante\" & Obj_Constante.Name & ".Constante "
            If IO.Directory.Exists(IO.Path.GetDirectoryName(Path)) = False Then
                IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(Path))
            End If
            'Result.AddParam("Path", Path, Path)
            ' Result.AddParam("Obj_Constante", Obj_Constante, Obj_Constante.Name)
        ElseIf TypeOf Obj Is VbNET.Event Then
            Obj_Event = Obj
            Path += "\Event\" & Obj_Event.Name & ".Event "
            If IO.Directory.Exists(IO.Path.GetDirectoryName(Path)) = False Then
                IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(Path))
            End If
            ' Result.AddParam("Path", Path, Path)
            ' Result.AddParam("Obj_Event", Obj_Event, Obj_Event.Name)
        ElseIf TypeOf Obj Is VbNET.Declare Then
            Obj_Declare = Obj
            Path += "\Declare\" & Obj_Declare.Name & ".Declare "
            If IO.Directory.Exists(IO.Path.GetDirectoryName(Path)) = False Then
                IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(Path))
            End If
            ' Result.AddParam("Path", Path, Path)
            ' Result.AddParam("Obj_Declare", Obj_Declare, Obj_Declare.Name)
        ElseIf TypeOf Obj Is VbNET.Delegate Then
            Obj_Delegate = Obj
            Path += "\Delegate\" & Obj_Delegate.Name & ".Delegate "
            If IO.Directory.Exists(IO.Path.GetDirectoryName(Path)) = False Then
                IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(Path))
            End If
            ' Result.AddParam("Path", Path, Path)
            ' Result.AddParam("Obj_Delegate", Obj_Delegate, Obj_Delegate.Name)
        End If
        Try
            Dim XmlTool = New Xml.Serialization.XmlSerializer(Obj.GetType)
            Dim StrWriter As New StreamWriter(Path)
            XmlTool.Serialize(StrWriter, Obj)
            Result.Status = Status.Online
        Catch ex As Exception
            Result.Status = Status.Broken
            Result.AddBug(ex, "Serialization", "Seralize")
        End Try

        Dim Fi As New IO.FileInfo(Path)
        Result.Output = Fi
        Result.OutputString = Fi.FullName
        Return Result
    End Function
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        '    AdvProperty.SelectedObject = VbNET.Import.Deserialize(Statement.Text)
    End Sub
End Class