Imports System.IO
Imports System.Reflection

Public Module M_Reflexion

    Public Class Serializer2

        ''' <summary>
        ''' Serialize an object statement accroding to project name
        ''' </summary>
        ''' <param name="Obj"></param>
        ''' <returns></returns>
        Public Shared Function Serialize(ByVal Obj As Object) As TestItem
            Dim Result As New TestItem("Builder.Serialize", "Serialize a Statement")
            If Not IsNothing(Obj) Then

                If My.Settings.DefaultOuput.Length > 0 Then
                Else
                    Dim Str As String = ""
                    If Not IsNothing(Obj.ParentStructure) Then
                        Str += Obj.ParentStructure.Name
                    Else
                        If Not IsNothing(Obj.ParentModule) Then
                            Str += Obj.ParentModule.Name
                        Else
                            If Not IsNothing(Obj.ParentClass) Then
                                Str += Obj.ParentClass.Name
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
                    My.Settings.DefaultOuput = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Serialized Object\" & Str & "\" & Now.Year & "_" & Now.Month & "_" & Now.Day & "\"
                    My.Settings.Save()
                End If
                Dim DirPath As New DirectoryInfo(My.Settings.DefaultOuput)
                If DirPath.Exists = False Then
                    Try
                        DirPath.Create()
                    Catch ex As Exception

                    End Try
                End If
                Dim Path As String = My.Settings.DefaultOuput

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
                    Path += "\Importation\" & Obj_Importation.Name & ".Import"
                    If IO.Directory.Exists(IO.Path.GetDirectoryName(Path)) = False Then
                        IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(Path))
                    End If
                ElseIf TypeOf Obj Is VbNET.Property Then
                    Obj_Property = Obj
                    Path += "\Property\" & Obj_Property.Name & ".Property"
                    If IO.Directory.Exists(IO.Path.GetDirectoryName(Path)) = False Then
                        IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(Path))
                    End If
                ElseIf TypeOf Obj Is VbNET.Enumeration Then
                    Obj_Enumeration = Obj
                    Path += "\Enumerate\" & Obj_Enumeration.Name & ".Enumerate"
                    If IO.Directory.Exists(IO.Path.GetDirectoryName(Path)) = False Then
                        IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(Path))
                    End If
                ElseIf TypeOf Obj Is VbNET.Structure Then
                    Obj_Structure = Obj
                    Path += "\Structure\" & Obj_Structure.Name & ".Structure"
                    If IO.Directory.Exists(IO.Path.GetDirectoryName(Path)) = False Then
                        IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(Path))
                    End If
                ElseIf TypeOf Obj Is VbNET.Sub Then
                    Obj_Sub = Obj
                    Path += "\Sub\" & Obj_Sub.Name & ".Sub"
                    If IO.Directory.Exists(IO.Path.GetDirectoryName(Path)) = False Then
                        IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(Path))
                    End If
                ElseIf TypeOf Obj Is VbNET.Function Then
                    Obj_Function = Obj
                    Path += "\Function\" & Obj_Function.Name & ".Function"
                    If IO.Directory.Exists(IO.Path.GetDirectoryName(Path)) = False Then
                        IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(Path))
                    End If
                ElseIf TypeOf Obj Is VbNET.Runtime Then
                    Obj_Runtime = Obj
                    Path += "\Runtime\" & Obj_Runtime.Name & ".Runtime"
                    If IO.Directory.Exists(IO.Path.GetDirectoryName(Path)) = False Then
                        IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(Path))
                    End If
                ElseIf TypeOf Obj Is VbNET.Loader Then
                    Obj_Loader = Obj
                    Path += "\Loader\" & Obj_Loader.Name & ".Loader"
                    If IO.Directory.Exists(IO.Path.GetDirectoryName(Path)) = False Then
                        IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(Path))
                    End If
                ElseIf TypeOf Obj Is VbNET.Class Then
                    Obj_Class = Obj
                    Path += "\Class\" & Obj_Class.Name & ".Class"
                    If IO.Directory.Exists(IO.Path.GetDirectoryName(Path)) = False Then
                        IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(Path))
                    End If
                ElseIf TypeOf Obj Is VbNET.Module Then
                    Obj_Module = Obj
                    Path += "\Module\" & Obj_Module.Name & ".Module"
                    If IO.Directory.Exists(IO.Path.GetDirectoryName(Path)) = False Then
                        IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(Path))
                    End If
                ElseIf TypeOf Obj Is VbNET.Constante Then
                    Obj_Constante = Obj
                    Path += "\Constante\" & Obj_Constante.Name & ".Constante"
                    If IO.Directory.Exists(IO.Path.GetDirectoryName(Path)) = False Then
                        IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(Path))
                    End If
                ElseIf TypeOf Obj Is VbNET.Event Then
                    Obj_Event = Obj
                    Path += "\Event\" & Obj_Event.Name & ".Event"
                    If IO.Directory.Exists(IO.Path.GetDirectoryName(Path)) = False Then
                        IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(Path))
                    End If
                ElseIf TypeOf Obj Is VbNET.Declare Then
                    Obj_Declare = Obj
                    Path += "\Declare\" & Obj_Declare.Name & ".Declare"
                    If IO.Directory.Exists(IO.Path.GetDirectoryName(Path)) = False Then
                        IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(Path))
                    End If
                ElseIf TypeOf Obj Is VbNET.Delegate Then
                    Obj_Delegate = Obj
                    Path += "\Delegate\" & Obj_Delegate.Name & ".Delegate"
                    If IO.Directory.Exists(IO.Path.GetDirectoryName(Path)) = False Then
                        IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(Path))
                    End If
                End If
                Try
                    Dim XmlTool = New Xml.Serialization.XmlSerializer(Obj.GetType)
                    Dim StrWriter As New StreamWriter(Path)
                    XmlTool.Serialize(StrWriter, Obj)
                    Result.Status = Status.Online
                Catch ex As Exception
                    Result.Status = Status.Broken
                    Result.AddBug(ex, "Serialization", "Seralize")
                    MsgBox(ex.Message)
                End Try

                Dim Fi As New IO.FileInfo(Path)
                Result.Output = Fi
                Result.OutputString = Fi.FullName
            End If

            Return Result
        End Function
    End Class

End Module
