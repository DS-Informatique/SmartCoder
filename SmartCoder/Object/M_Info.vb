Imports System.ComponentModel
Imports System.IO
Imports System.Reflection
Imports System.Windows.Forms
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Public Module M_Info
#Region "<Schema>"
#Region "|1| [Property]"

#End Region
#Region "|2| [Enumeration]{2}"
#Region "|2019/04/20 16h51:921| <02.00.00> <Enumeration> <Status> [Call=Status|Enumeration]"'Enumeration which capture the Status of an object or procedure.
    ''' <Summary>
    ''' (Set|Get) Enumeration which capture the Status of an object or procedure.
    ''' </Summary>
    ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
    ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
    ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
    ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/20 16h51:917 </Published>
    ''' <Updated>[Created=2019/04/20 16h51:910][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
    <DefaultValue(Status.Nothing)>
    Public Enum Status
        ''' <summary> The object is nothing or has not been initialized. </summary>
        [Nothing] = 0
        ''' <summary> The object is in use or the procedure is working. </summary>
        Online = 1
        ''' <summary> The object is unreachable or offline. </summary>
        Offline = 2
        ''' <summary>The object of procedure has entered a critical state due to some error. </summary>
        Broken = 3
        ''' <summary>The Object has been initialized and the input parameters have been verified but the process has not yet been performed. </summary>
        StandBye = 4
        ''' <summary>The Object has encountered some errors during the process but has successfully solve them. </summary>
        Warning = 5
        ''' <summary>The Object or process is engage. The process is running. </summary>
        Running = 6
        ''' <summary>The object or process has received the command but did not complete or initialize the process. </summary>
        NotTested = 7
        ''' <summary>The object or process has capture a null object or the process or object has failed to complete the task. </summary>
        IsNothing = 8
        ''' <summary>The object or process has finished the evaluation sucessfully. </summary>
        Finished = 9
    End Enum
#End Region ' Enumeration which capture the Status of an object or procedure.
#Region "|2019/04/23 12h28:450| <02.00.01> <Enumeration> <CodeLanguage> [Call=CodeLanguage|Enumeration]"'The enumeration of CodeLanguage.
    ''' <Summary>
    ''' (Set|Get) The enumeration of CodeLanguage.
    ''' </Summary>
    ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
    ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
    ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
    ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/23 12h28:450 </Published>
    ''' <Updated>[Created=2019/04/23 12h28:450][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
    Public Enum CodeLanguage
        ''' <summary> Vb.NET Format. </summary>
        Vb = 0
        ''' <summary> C# Format. </summary>
        C# = 1
        ''' <summary>F# Format. </summary>
        F# = 2
        ''' <summary>JavaScript Format. </summary>
        JavaScript = 3
        ''' <summary>Python Format. </summary>
        Python = 4
    End Enum
#End Region ' The enumeration of CodeLanguage.
#End Region
#Region "|3| [Structure]"

#End Region
#Region "|4| [Sub]"

#End Region
#Region "|5| [Function]{9}"
#Region "|05.00| <Function> [TestItem]{6}"
#Region "|05.00.00| <Function> <TestItem> [GetClasses()|TestItem]"
    Public Function GetAllClasses() As TestItem
        Dim L As New List(Of Object)
        If IsNothing(All_Classes) Then
            All_Classes = New TestItem("Assembly", "Chargement de toute les classes non visuel du programme", Status.Running, "M_TestItem.GetAllClasses", L)
        Else
            Return All_Classes
            Exit Function
        End If

#Region "Process"

        Dim thisAsm As Assembly = Assembly.GetExecutingAssembly()
        All_Classes.AddParam("thisAsm", thisAsm, thisAsm.ToString)


        Dim types As List(Of Type) = thisAsm.GetTypes().Where(Function(t) t.IsClass AndAlso Not t.IsAbstract).ToList()
        Dim i As Integer = 0
        For Each t As Type In types
            All_Classes.DataSource.Add(t)
            Dim TC As New TestItem("[Class=" & t.Name & "]", "Idenditification de la class", Status.Online, "M.TestItem.GetAllClasses", t)
            TC.ID = i
            i += 1
            TC.Input = t.StructLayoutAttribute

            'TC.Add(AnalyserClass.GrabClassCode(t.Name))
            TC.Write("Analyse de la class " & t.Namespace & " et des fonctions")
            ' TC.Add(a.MesProperties)
            All_Classes.Add(TC)
        Next
        Return All_Classes

#End Region
    End Function
#End Region
#Region "|05.00.01| <Function> <TestItem> [CollectProperties(SelectedObject|Object)|TestItem]"
    Public Function CollectProperties(ByRef SelectedObject As Object) As TestItem

        Dim MesProperties = New TestItem("CollectProperties of " & SelectedObject.ToString, "Recherche des propriétés de ") ' & If(IsNothing(SelectedObject.Name), SelectedObject.ToString, SelectedObject.Name) & " ")
        With MesProperties
            .Text = .Name
            .Status = Status.Running
        End With

        Dim _type As Type = SelectedObject.GetType()
        Dim properties() As PropertyInfo = _type.GetProperties()
        ' MesProperties.Write("Recherche des propriétés ", "AnalyserClass| CollectProperties()| Dim properties() As PropertyInfo = _type.GetProperties()", Status.Online)
        MesProperties.AddEvent(Status.Online, "Enregistrement des propriétés", "<00.04.00>", properties)
        ' MesProperties.Input = SelectedObject
        MesProperties.Input = properties
        ' MesProperties.Write("[Online] Capture des résultats", "AnalyserClass| CollectProperties()| MesProperties.Object_Analysed = properties", Status.Online)
        If IsNothing(SelectedObject) Then
            ' MesProperties.Write("[Nul] SelectedObject is nothing!", "AnalyserClass| CollectProperties()| If IsNothing(SelectedObject) Then", Status.IsNothing)
            MesProperties.AddEvent(Status.IsNothing, "Valeur nul de SelectedObject", "<CollectProperties>", SelectedObject)
        Else
            '   MesProperties.Write("[Online] SelectedObject is Online!", "AnalyserClass| CollectProperties()| If IsNothing(SelectedObject)=false Then", Status.IsNothing)
            Dim i As Integer = 0
            Dim b As Integer = properties.Count
            MesProperties.Hypothesis += "We have found { " & b & " } properties for the class [ " & SelectedObject.ToString & " ]" & vbNewLine
            ' MesProperties.Write("#Region " & """" & " Analyse des propriétés de " & SelectedObject.ToString & """")

            For Each Prop As PropertyInfo In properties
                i += 1
                Dim It As New TestItem(SelectedObject.ToString & " | " & Prop.ToString & "= " & (SelectedObject.ToString), "Analysis of " & Prop.ToString & "", Status.Running,) '
                Dim VirtualValue As String = ""
                If IsNothing(Prop) Then
                Else
                    Try
                        If IsNothing(Prop.GetValue(SelectedObject, Nothing)) Then
                        Else
                            If IsDBNull(Prop.GetValue(SelectedObject, Nothing)) Then
                            Else
                                VirtualValue = Prop.GetValue(SelectedObject, Nothing).ToString
                            End If
                        End If
                    Catch ex As Exception
                        MesProperties.AddBug(ex, Prop.Name & " value is Broken", "[CollectProperties]")
                    End Try

                End If

                With It
                    .Input = Prop
                    .ParentTestItem = MesProperties
                    '  .Name = Prop.Name
                    .Hypothesis = "Analysis of " & Prop.ToString & ""
                    .Tag = Prop
                    With Prop
                        ' i 't.Body += "     <" & i & ">  " & Prop.Name & " | " & Analyse_Nothing(.GetValue(SelectedObject, Nothing)) & " Property out of [ " & b & " ]                                             " & vbNewLine & vbNewLine
                        'It.Body += "     [Name]                     [Value]                                             " & vbNewLine
                        ' It.Body += "-----------------------------------------------------------------------------" & vbNewLine
                        Try
                            Dim TAttributes As New TestItem(Prop.ToString & "|Attributes",
                                                       "Get the attributes of this property",
                                                       Status.Online,
                                                       "Value = " & .Attributes.ToString,
                                                       Prop.Attributes)
                            It.Add(TAttributes, "Prop.Attributes")
                        Catch ex As Exception

                        End Try

                        '  It.Write("     Attributes" & "                     " & .Attributes.ToString)
                        Try
                            Dim TCanRead As New TestItem(Prop.ToString & "|CanRead",
                                                      "Gets a value indicating whether the property can be read.",
                                                      Status.Online,
                                                      "Value = " & .CanRead.ToString,
                                                      Prop.CanRead)
                            '  It.Write("     CanRead" & "                        " & .CanRead.ToString)
                            It.Add(TCanRead, "Prop.CanRead")
                        Catch ex As Exception

                        End Try
                        Try
                            Dim TCanWrite As New TestItem(Prop.ToString & "|CanWrite",
                                                      "Gets a value indicating whether the property can be written to.",
                                                      Status.Online,
                                                      "Value = " & .CanWrite.ToString,
                                                      Prop.CanWrite)
                            'It.Write("     CanWrite" & "                       " & .CanWrite.ToString)
                            It.Add(TCanWrite, "Prop.CanWrite")
                        Catch ex As Exception

                        End Try
                        Try
                            Dim TCustomAttributes As New TestItem(Prop.ToString & "|CustomAttributes",
                                                       "Gets a collection that contains this member's custome attributes.",
                                                       Status.Online,
                                                       "Value = " & .CustomAttributes.ToString,
                                                       Prop.CustomAttributes)

                            '  It.Write("     CustomAttributes" & "               " & .CustomAttributes.ToString)
                            It.Add(TCustomAttributes, "Prop.CustomAttributes")
                        Catch ex As Exception

                        End Try
                        Try
                            Dim TDeclaringType As New TestItem(Prop.ToString & "|DeclaringType",
                                                      "Gets the class that declares this member.",
                                                      Status.Online,
                                                      "Value = " & .DeclaringType.ToString,
                                                      Prop.DeclaringType)
                            '  It.Write("     DeclaringType" & "                  " & .DeclaringType.ToString)
                            It.Add(TDeclaringType, "Prop.DeclaringType")
                        Catch ex As Exception

                        End Try
                        Try
                            Dim TGetMethod As New TestItem(Prop.ToString & "|GetMethod",
                                                      "Gets the get accessor for this property.",
                                                      Status.Online,
                                                      "Value = " & .GetMethod.ToString,
                                                      Prop.GetMethod)
                            'It.Write("     GetMethod" & "                      " & .GetMethod.ToString)
                            It.Add(TGetMethod, "Prop.GetMethod")
                        Catch ex As Exception

                        End Try
                        Try
                            Dim TIsSpecialName As New TestItem(Prop.ToString & "|IsSpecialName",
                                                      "Gets a value indicating whether the property is the special name.",
                                                      Status.Online,
                                                      "Value = " & .IsSpecialName.ToString,
                                                      Prop.IsSpecialName)
                            'It.Write("     IsSpecialName" & "                  " & .IsSpecialName.ToString)
                            It.Add(TIsSpecialName, "Prop.IsSpecialName")
                        Catch ex As Exception

                        End Try
                        Try
                            Dim TMetadataToken As New TestItem(Prop.ToString & "|MetadataToken",
                                                        "Gets a value that identifies a metadata element.",
                                                        Status.Online,
                                                        "Value = " & .MetadataToken.ToString,
                                                        Prop.MetadataToken)
                            ' It.Write("     MetadataToken" & "                  " & .MetadataToken.ToString)
                            It.Add(TMetadataToken, "Prop.MetadataToken")
                        Catch ex As Exception

                        End Try
                        Try
                            Dim TModule As New TestItem(Prop.ToString & "|Module",
                                                        "Gets the module in which the types declares the member represented by the current MemberInfo is defined.",
                                                        Status.Online,
                                                        "Value = " & .Module.ToString,
                                                        Prop.Module)
                            ' It.Write("     Module" & "                         " & .Module.ToString)
                            It.Add(TModule, "Prop.Module")
                        Catch ex As Exception

                        End Try
                        Try
                            Dim TName As New TestItem(Prop.ToString & "|Module",
                                                       "Gets the name of the current member.",
                                                       Status.Online,
                                                       "Value = " & .Name.ToString,
                                                       Prop.Name)
                            ' It.Write("     Name" & "                           " & .Name.ToString)
                            It.Add(TName, "Prop.Name")
                        Catch ex As Exception

                        End Try
                        Try
                            Dim TPropertyType As New TestItem(Prop.ToString & "|PropertyType",
                                                       "Gets the type of his property.",
                                                       Status.Online,
                                                       "Value = " & .PropertyType.ToString,
                                                       Prop.PropertyType)
                            ' It.Write("     PropertyType" & "                   " & .PropertyType.ToString)
                            It.Add(TPropertyType, "Prop.PropertyType")
                        Catch ex As Exception

                        End Try
                        Try
                            Dim TReflectedType As New TestItem(Prop.ToString & "|ReflectedType",
                                                       "Gets the class object that was used to obtain this instance of MemberInfo.",
                                                       Status.Online,
                                                       "Value = " & .PropertyType.ToString,
                                                       Prop.ReflectedType)
                            ' It.Write("     ReflectedType" & "                  " & .ReflectedType.ToString)
                            It.Add(TReflectedType, "Prop.ReflectedType")
                        Catch ex As Exception

                        End Try

                        Try

                            ' It.Write("     SetMethod" & "                     " & Analyse_Nothing(.SetMethod))
                            Dim TSetMethod As New TestItem(Prop.ToString & "|ReflectedType",
                                                        "Gets the set accessor of this property.",
                                                        Status.Online,
                                                        "Value = " & .SetMethod.ToString,
                                                        Prop.SetMethod)
                            It.Add(TSetMethod, "Prop.SetMethod")
                        Catch ex As Exception
                            MesProperties.AddBug(ex, Prop.ToString & " value is Broken", "[CollectProperties]")
                            Dim TSetMethod As New TestItem(Prop.Name & "|ReflectedType",
                                                        "Gets the set accessor of this property.",
                                                        Status.Broken,
                                                        "Value = " & Analyse_Nothing(Prop.SetMethod).ToString,
                                                       Analyse_Nothing(Prop.SetMethod))
                            It.Add(TSetMethod, "Prop.SetMethod")
                        End Try
                        ' It.Write("     ToString" & "                     " & .ToString)
                        Dim TToString As New TestItem(Prop.ToString & "|ToString",
                                                        "Returns a String that represents the current object.",
                                                        Status.Online,
                                                        "Value = " & .ToString,
                                                        Prop.ToString)
                        It.Add(TToString, "Prop.ToString")
                        Try
                            It.Write("     Value                        " & Analyse_Nothing(.GetValue(SelectedObject, Nothing)))
                            Dim TValue As New TestItem(Prop.ToString & "|Value",
                                                        "Returns a String that represents the current object.",
                                                        Status.Online,
                                                        "Value = " & Analyse_Nothing(.GetValue(SelectedObject, Nothing)),
                                                        Analyse_Nothing(.GetValue(SelectedObject, Nothing)))
                            It.Status = Status.Online
                            It.Add(TValue, "Prop.Value")
                        Catch ex As Exception
                            It.Write("     Value                        " & Format_Error(ex, ".GetValue(SelectedObject, Nothing).ToString)"))
                            Dim TValue As New TestItem(Prop.ToString & "|Value",
                                                        "Returns a String that represents the current object.",
                                                        Status.Broken, "Value is Nothing") 'Analyse_Nothing(.GetValue(SelectedObject, Nothing)
                            TValue.AddBug(ex, Prop.Name & " value is Broken", "[Value]")
                            It.AddBug(ex, Prop.Name & " value is Broken", "[Value]")
                            It.Add(TValue, "Prop.Value")

                            It.Status = Status.Broken
                        End Try
                        ' It.Write("#End Region ")

                    End With
                End With
                '   MesProperties.Write("#End Region '" & Prop.Name)

                MesProperties.Add(It, "AnalyserClass| CollectProperties()| " & Prop.Name)
            Next
        End If

        Return MesProperties
    End Function
#End Region
#Region "|05.00.02| <Function> <TestItem> [StatusToString(Stat|Status)|String]"
    Public Function StatusToString(Stat As Status) As String
        Dim Lng_0 As String = ""
        Dim Lng_1 As String = ""
        Dim Lng_2 As String = ""
        Dim Lng_3 As String = ""
        Dim Lng_4 As String = ""
        Dim Lng_5 As String = ""
        Dim Lng_6 As String = ""
        Dim Lng_7 As String = ""
        Dim Lng_8 As String = ""
        If My.Settings.Langue = "" Then
            My.Settings.Langue = "English"
            My.Settings.Save()
        End If
        If ConvertLangue_ToInt(My.Settings.Langue) = Enum_Langue.Arabic Then
            Lng_0 = "عبر الانترنت"
            Lng_1 = "كسر"
            Lng_2 = "جاهز"
            Lng_3 = "تحذير"
            Lng_4 = "عملية"
            Lng_5 = "لم تختبر"
            Lng_6 = "لا شيئ"
            Lng_7 = "تم الانتهاء من"
            Lng_8 = "غير متصل على الانترنت"


        ElseIf ConvertLangue_ToInt(My.Settings.Langue) = Enum_Langue.Chinese Then
            Lng_0 = "線上"
            Lng_1 = "破碎"
            Lng_2 = "準備"
            Lng_3 = "警告"
            Lng_4 = "手術"
            Lng_5 = "未經測試"
            Lng_6 = "沒有"
            Lng_7 = "成品"
            Lng_8 = "離線"

        ElseIf ConvertLangue_ToInt(My.Settings.Langue) = Enum_Langue.English Then
            Lng_0 = "Online"
            Lng_1 = "Broken"
            Lng_2 = "Ready"
            Lng_3 = "Warning"
            Lng_4 = "Operation"
            Lng_5 = "Not tested"
            Lng_6 = "Nothing"
            Lng_7 = "Finished"
            Lng_8 = "Offline"

        ElseIf ConvertLangue_ToInt(My.Settings.Langue) = Enum_Langue.Français Then
            Lng_0 = "En ligne"
            Lng_1 = "Cassé"
            Lng_2 = "Prêt"
            Lng_3 = "Attention"
            Lng_4 = "Fonctionnement"
            Lng_5 = "Pas testé"
            Lng_6 = "Nul"
            Lng_7 = "Fini"
            Lng_8 = "Hors ligne"

        ElseIf ConvertLangue_ToInt(My.Settings.Langue) = Enum_Langue.German Then
            Lng_0 = "Online"
            Lng_1 = "Gebrochen"
            Lng_2 = "Bereit"
            Lng_3 = "Warnung"
            Lng_4 = "Betrieb"
            Lng_5 = "Nicht getestet"
            Lng_6 = "Nichts"
            Lng_7 = "Fertig"
            Lng_8 = "Offline"

        ElseIf ConvertLangue_ToInt(My.Settings.Langue) = Enum_Langue.Greek Then
            Lng_0 = "Online"
            Lng_1 = "Σπασμένος"
            Lng_2 = "Ετοιμος"
            Lng_3 = "Προειδοποίηση"
            Lng_4 = "Λειτουργία"
            Lng_5 = "Μη δοκιμασμένο"
            Lng_6 = "Τίποτα"
            Lng_7 = "Πεπερασμένος"
            Lng_8 = "Offline"

        ElseIf ConvertLangue_ToInt(My.Settings.Langue) = Enum_Langue.Hebrew Then
            Lng_0 = "באינטרנט"
            Lng_1 = "שָׁבוּר"
            Lng_2 = "מוּכָן"
            Lng_3 = "אַזהָרָה"
            Lng_4 = "מבצע"
            Lng_5 = "לא נבחן"
            Lng_6 = "שום דבר"
            Lng_7 = "גָמוּר"
            Lng_8 = "לא מקוון"

        ElseIf ConvertLangue_ToInt(My.Settings.Langue) = Enum_Langue.Italian Then
            Lng_0 = "in linea"
            Lng_1 = "Rotto"
            Lng_2 = "Pronto"
            Lng_3 = "avvertimento"
            Lng_4 = "operazione"
            Lng_5 = "Non testato"
            Lng_6 = "Niente"
            Lng_7 = "Finito"
            Lng_8 = "disconnesso"

        ElseIf ConvertLangue_ToInt(My.Settings.Langue) = Enum_Langue.Japanese Then
            Lng_0 = "オンライン"
            Lng_1 = "壊れた"
            Lng_2 = "準備完了"
            Lng_3 = "警告"
            Lng_4 = "操作"
            Lng_5 = "未検証"
            Lng_6 = "何も"
            Lng_7 = "完成した"
            Lng_8 = "オフライン"

        ElseIf ConvertLangue_ToInt(My.Settings.Langue) = Enum_Langue.Latin Then
            Lng_0 = "Online"
            Lng_1 = "rumpitur"
            Lng_2 = "promptus"
            Lng_3 = "monitum"
            Lng_4 = "operatio"
            Lng_5 = "non tested"
            Lng_6 = "nihil"
            Lng_7 = "consummavi"
            Lng_8 = "Online"

        ElseIf ConvertLangue_ToInt(My.Settings.Langue) = Enum_Langue.Portuguese Then
            Lng_0 = "Conectados"
            Lng_1 = "Partido"
            Lng_2 = "pronto"
            Lng_3 = "Atenção"
            Lng_4 = "Operação"
            Lng_5 = "Não testado"
            Lng_6 = "Nada"
            Lng_7 = "Acabado"
            Lng_8 = "desligada"

        ElseIf ConvertLangue_ToInt(My.Settings.Langue) = Enum_Langue.Russian Then
            Lng_0 = "В сети"
            Lng_1 = "Сломанный"
            Lng_2 = "готов"
            Lng_3 = "Предупреждение"
            Lng_4 = "операция"
            Lng_5 = "Не испытано"
            Lng_6 = "Ничего"
            Lng_7 = "Законченный"
            Lng_8 = "Не в сети"

        ElseIf ConvertLangue_ToInt(My.Settings.Langue) = Enum_Langue.Spanish Then
            Lng_0 = "En línea"
            Lng_1 = "Roto"
            Lng_2 = "Listo"
            Lng_3 = "Advertencia"
            Lng_4 = "Operación"
            Lng_5 = "No probado"
            Lng_6 = "Nada"
            Lng_7 = "Terminado"
            Lng_8 = "Desconectado"
        ElseIf ConvertLangue_ToInt(My.Settings.Langue) = Enum_Langue.Thai Then
            Lng_0 = "ออนไลน์"
            Lng_1 = "เสีย"
            Lng_2 = "พร้อมแล้ว"
            Lng_3 = "การเตือน"
            Lng_4 = "การทำงาน"
            Lng_5 = "ไม่ผ่านการทดสอบ"
            Lng_6 = "ไม่มีอะไร"
            Lng_7 = "เสร็จ"
            Lng_8 = "ออฟไลน์"

        ElseIf ConvertLangue_ToInt(My.Settings.Langue) = Enum_Langue.Turkish Then
            Lng_0 = "İnternet üzerinden"
            Lng_1 = "Kırık"
            Lng_2 = "hazır"
            Lng_3 = "Uyarı"
            Lng_4 = "Operasyon"
            Lng_5 = "Test edilmedi"
            Lng_6 = "Hiçbir şey değil"
            Lng_7 = "bitirdi"
            Lng_8 = "Çevrimdışı"

        End If
        Dim Result As String = ""
        If Stat = Status.Online Then
            Result = Lng_0
        ElseIf Stat = Status.Broken Then
            Result = Lng_1
        ElseIf Stat = Status.StandBye Then
            Result = Lng_2
        ElseIf Stat = Status.Warning Then
            Result = Lng_3
        ElseIf Stat = Status.Running Then
            Result = Lng_4
        ElseIf Stat = Status.NotTested Then
            Result = Lng_5
        ElseIf Stat = Status.IsNothing Then
            Result = Lng_6
        ElseIf Stat = Status.Finished Then
            Result = Lng_7
        ElseIf Stat = Status.Offline Then
            Result = Lng_8
        End If
        Return Result
    End Function
#End Region
#Region "|05.00.03| <Function> <TestItem> [Analyse_Nothing(Obj|Object)|String]"
    Public Function Analyse_Nothing(ByVal obj As Object) As String
        Dim Result As String = ""
        If IsNothing(obj) Then

        Else
            If obj.ToString = "" Then
            Else
                Result = obj.ToString
            End If
        End If
        Return Result
    End Function
#End Region
#Region "|05.00.04| <Function> <TestItem> [Format_Error(Ex|Exception,[Ref]|String)|String]"
    ''' <summary>
    ''' Capture an error and format it correctly in a single string
    ''' </summary>
    ''' <param name="ex"></param>
    ''' <returns></returns>
    Public Function Format_Error(ByVal ex As Exception, Optional ByVal Ref As String = "") As String
        Dim Result As String = ""
        Dim Source As String = ""
        Dim Message As String = ex.Message
        Dim HelpLink As String = ""
        Dim StackTrace As String = ""
        Dim TargetSite As String = ""

        If IsNothing(ex.Source) = False Then
            Source = ex.Source
        End If
        If IsNothing(ex.HelpLink) = False Then
            HelpLink = ex.HelpLink
        End If
        If IsNothing(ex.StackTrace) = False Then
            StackTrace = ex.StackTrace
        End If
        If IsNothing(ex.TargetSite) = False Then
            TargetSite = ex.TargetSite.Name.ToString
        End If
        Result = "Exception captured |" & ex.HResult.ToString & " ]" & vbNewLine &
                     "___________________________________________________________________________________________" & vbNewLine &
                     "      <Source> " & vbNewLine &
                     "       " & Source & vbNewLine &
                     "      </Source>" & vbNewLine &
                     "___________________________________________________________________________________________" & vbNewLine &
                     "      <Message> " & vbNewLine &
                     "       " & Message & vbNewLine &
                     "       </Message>" & vbNewLine &
                      "___________________________________________________________________________________________" & vbNewLine &
                     "      <TargetSite> " & vbNewLine &
                     "       " & TargetSite & vbNewLine &
                     "      </TargetSite>" & vbNewLine &
                      "___________________________________________________________________________________________" & vbNewLine &
                     "      <StackTrace> " & vbNewLine &
                     "       " & StackTrace & vbNewLine &
                     "      </StackTrace>" & vbNewLine &
                      "___________________________________________________________________________________________" & vbNewLine &
                     "      <HelpLink> " & vbNewLine &
                     "       " & HelpLink & vbNewLine &
                     "      </HelpLink>" & vbNewLine &
                      "___________________________________________________________________________________________" & vbNewLine &
                     "      <Source> " & vbNewLine &
                     "       " & Source & vbNewLine &
                     "      </Source>" & vbNewLine &
                     "___________________________________________________________________________________________" & vbNewLine &
                     "[End Erreur]" & vbNewLine


        'Write(Result, Status.Broken, False)
        'Record("Format Erreur", "<04.01.00>", Status.Finished)

        Return Result
    End Function

#End Region
#Region "|05.00.05| <Function> <TestItem> [StartRegion(Description|String,RegionCode|String,RegionRef|String)|String]"
    Public Function StartRegion(ByVal RegionDescription As String,
                                 Optional ByVal RegionCode As String = "",
                                 Optional ByVal RegionRef As String = "") As String
        Dim Result As String = ""
        Dim Descr As String = RegionDescription
        Dim RCode As String = RegionCode
        Dim RRef As String = RegionRef

        Result = "#Region " & """" & " " & Descr & " " & RCode & " " & RRef & """"
        Return Result
    End Function
#End Region
#End Region
#Region "|05.01| <Function> [ShowPropertyOf(Obj|Object)|Office2007Form]"
    Public Function ShowPropertyOf(ByVal Obj As Object) As DevComponents.DotNetBar.Office2007Form
        Dim Result As New DevComponents.DotNetBar.Office2007Form

        Dim Prop As New DevComponents.DotNetBar.AdvPropertyGrid
        Prop.Dock = DockStyle.Fill
        Prop.SelectedObject = Obj
        Result.Controls.Add(Prop)
        If Not IsNothing(Obj) Then
            Result.TitleText = Obj.ToString
            Result.Text = Obj.ToString
        End If
        Result.WindowState = FormWindowState.Normal
        Result.Show()
        Return Result
    End Function
#End Region
#Region "|05.02| <Function> [Time]{2}"
#Region "|05.02.00| <Function> <Time> [PrintTime()|String]"
    ''' <summary>
    ''' Print Time to Format :YYYY/MM/DD HHhMM:xxx)
    ''' </summary>
    ''' <returns></returns>
    Public Function PrintTime() As String
        Return Date.Now.Year & "/" &
        IIf(Date.Now.Month < 10, "0" & Date.Now.Month, Date.Now.Month) & "/" &
        IIf(Date.Now.Day < 10, "0" & Date.Now.Day, Date.Now.Day) & " " &
        IIf(Date.Now.Hour < 10, "0" & Date.Now.Hour, Date.Now.Hour) & "h" &
        IIf(Date.Now.Minute < 10, "0" & Date.Now.Minute, Date.Now.Minute) & ":" &
        IIf(Date.Now.Millisecond < 100, IIf(Date.Now.Millisecond < 10, "00" & Date.Now.Millisecond, "0" & Date.Now.Millisecond), Date.Now.Millisecond)
    End Function
#End Region
#Region "|05.02.01| <Function> <Time> [PrintTime(T|DateTime)|String]"
    ''' <summary>
    '''  Print Time to Format :YYYY/MM/DD HHhMM:xxx)
    ''' </summary>
    ''' <param name="T">A given time</param>
    ''' <returns></returns>
    Public Function PrintTime(ByVal T As DateTime) As String
        Return T.Year.ToString & "/" &
            IIf(T.Month < 10, "0" & T.Month.ToString, T.Month.ToString) & "/" &
        IIf(T.Day < 10, "0" & T.Day.ToString, T.Day.ToString) & " " &
        IIf(T.Hour < 10, "0" & T.Hour.ToString, T.Hour.ToString) & "h" &
        IIf(T.Minute < 10, "0" & T.Minute.ToString, T.Minute.ToString) & ":" &
        IIf(T.Millisecond < 100, IIf(T.Millisecond < 10, "00" & T.Millisecond.ToString, "0" & T.Millisecond.ToString), T.Millisecond.ToString)
    End Function
#End Region

#Region "[Functions] <Conversion> [Milliseconds] {Convert_Seconds_ToMilliseconds}"
    ''' <summary>
    ''' Convert Seconds To Milliseconds
    ''' </summary>
    ''' <param name="Seconds"></param>
    ''' <returns>As Integer</returns>
    ''' <authors>Saadry Dunkel Consultant</authors>
    Public Function Convert_Seconds_ToMilliseconds(ByVal Seconds As Integer) As Integer
        Dim Result As Integer = 0
        Result = Seconds * 60
        Return Result
    End Function 'OK
#End Region
#Region "[Functions] <Conversion> [Seconds] {Convert_Milliseconds_ToSeconds,Convert_Minutes_ToSeconds}"
    ''' <summary>
    ''' Convert Milliseconds to Seconds
    ''' LOCATION > M_Info [Time and Dates] Increasing
    ''' </summary>
    ''' <param name="Milliseconds">Must be greater than 0</param>
    ''' <returns>As Integer</returns>
    ''' <authors>Saadry Dunkel Consultant</authors>
    Public Function Convert_Milliseconds_ToSeconds(ByVal Milliseconds As Integer) As Integer
        Dim Result As Integer
        If Milliseconds > 0 Then
            Result = Milliseconds / 60
        Else
            Result = 0
        End If
        Return Result
    End Function
    ''' <summary>
    ''' Convert Minutes to Seconds
    ''' </summary>
    ''' <param name="Minutes"></param>
    ''' <returns>As Integer</returns>
    ''' <authors>Saadry Dunkel Consultant</authors>
    Public Function Convert_Minutes_ToSeconds(ByVal Minutes As Integer) As Integer
        Dim Result As Integer = 0
        Result = Minutes * 60
        Return Result
    End Function 'OK
#End Region
#Region "[Functions] <Conversion> [Minutes] {Convert_Seconds_ToMinutes,Convert_Hours_ToMinutes}"
    ''' <summary>
    ''' Convert Seconds to Minutes
    ''' </summary>
    ''' <param name="Seconds">Must be greater than 0</param>
    ''' <returns>As Integer</returns>
    ''' <authors>Saadry Dunkel Consultant</authors>
    Public Function Convert_Seconds_ToMinutes(ByVal Seconds As Integer) As Integer
        Dim Result As Integer
        If Seconds > 0 Then
            Result = Seconds / 60
        Else
            Result = 0
        End If
        Return Result
    End Function
    ''' <summary>
    ''' Convert Hours to Minutes
    ''' </summary>
    ''' <param name="Hours"></param>
    ''' <returns>As Integer</returns>
    ''' <authors>Saadry Dunkel Consultant</authors>
    Public Function Convert_Hours_ToMinutes(ByVal Hours As Integer) As Integer
        Dim Result As Integer = 0
        Result = Hours * 60
        Return Result
    End Function 'OK
#End Region
#Region "[Functions] <Conversion> [Hours] {Convert_Minutes_ToHours,Convert_Days_ToHours}"
    ''' <summary>
    ''' Convert Minutes to Hours
    ''' </summary>
    ''' <param name="Minutes">Must be greater than 0</param>
    ''' <returns>As Integer</returns>
    ''' <authors>Saadry Dunkel Consultant</authors>
    Public Function Convert_Minutes_ToHours(ByVal Minutes As Integer) As Integer
        Dim Result As Integer
        If Minutes > 0 Then
            Result = Minutes / 60
        Else
            Result = 0
        End If
        Return Result
    End Function
    ''' <summary>
    ''' Convert Days to Hours
    ''' </summary>
    ''' <param name="Days"></param>
    ''' <returns>As Integer</returns>
    ''' <authors>Saadry Dunkel Consultant</authors>
    Public Function Convert_Days_ToHours(ByVal Days As Integer) As Integer
        Dim Result As Integer = 0
        Result = Days * 24
        Return Result
    End Function 'OK
#End Region
#Region "[Functions] <Conversion> [Days] {Convert_Hours_ToDays,Convert_Months_ToDays,Convert_Weeks_ToDays}"
    ''' <summary>
    ''' Convert Hours to Days
    ''' </summary>
    ''' <param name="Hours">Must be greater than 0</param>
    ''' <returns>As Integer</returns>
    ''' <authors>Saadry Dunkel Consultant</authors>
    Public Function Convert_Hours_ToDays(ByVal Hours As Integer) As Integer
        Dim Result As Integer
        If Hours > 0 Then
            Result = Hours / 24
        Else
            Result = 0
        End If
        Return Result
    End Function
    ''' <summary>
    ''' Convert Months to Days
    ''' </summary>
    ''' <param name="Month"></param>
    ''' <returns>As Integer</returns>
    ''' <authors>Saadry Dunkel Consultant</authors>
    Public Function Convert_Months_ToDays(ByVal Month As Integer) As Integer
        Dim Result As Integer
        Result = Month * 30.436875
        Return Result
    End Function
    ''' <summary>
    ''' Convert Weeks to Days   
    ''' </summary>
    ''' <param name="Weeks"> </param>
    ''' <returns>As Integer</returns>
    ''' <authors>Saadry Dunkel Consultant</authors>
    Public Function Convert_Weeks_ToDays(ByVal Weeks As Integer) As Integer
        Dim Result As Integer
        Result = Weeks * 7
        Return Result
    End Function
#End Region
#Region "[Functions] <Conversion> [Weeks] {Convert_Days_ToWeeks,Convert_Months_ToWeeks}"
    ''' <summary>
    ''' Convert Days to Week
    ''' </summary>
    ''' <param name="Days">Must be greater than 0</param>
    ''' <returns>As Integer</returns>
    ''' <authors>Saadry Dunkel Consultant</authors>
    Public Function Convert_Days_ToWeeks(ByVal Days As Integer) As Integer
        Dim Result As Integer
        If Days > 0 Then
            Result = Days / 0.142857
        Else
            Result = 0
        End If
        Return Result
    End Function
    ''' <summary>
    ''' Convert Months to Weeks  
    ''' </summary>
    ''' <param name="Months"> </param>
    ''' <returns>As Integer</returns>
    ''' <authors>Saadry Dunkel Consultant</authors>
    Public Function Convert_Months_ToWeeks(ByVal Months As Integer) As Integer
        Dim Result As Integer
        Result = Months * 4.348125
        Return Result
    End Function
#End Region
#Region "[Functions] <Conversion> [Months] {Convert_Days_ToMonths,Convert_Weeks_ToMonths,Convert_Years_ToMonths}"
    ''' <summary>
    ''' Convert Days to Months
    ''' </summary>
    ''' <param name="Days">Must be greater than 0</param>
    ''' <returns>As Integer</returns>
    ''' <authors>Saadry Dunkel Consultant</authors>
    Public Function Convert_Days_ToMonths(ByVal Days As Integer) As Integer
        Dim Result As Integer
        If Days > 0 Then
            Result = Days / 30.436875
        Else
            Result = 0
        End If
        Return Result
    End Function
    ''' <summary>
    ''' Convert Weeks to Months
    ''' </summary>
    ''' <param name="Weeks">Must be greater than 0</param>
    ''' <returns>As Integer</returns>
    ''' <authors>Saadry Dunkel Consultant</authors>
    Public Function Convert_Weeks_ToMonths(ByVal Weeks As Integer) As Integer
        Dim Result As Integer
        If Weeks > 0 Then
            Result = Weeks / 0.22998418858703
        Else
            Result = 0
        End If
        Return Result
    End Function
    ''' <summary>
    ''' Convert Years to Months
    ''' </summary>
    ''' <param name="Years"></param>
    ''' <returns>As Integer</returns>
    ''' <authors>Saadry Dunkel Consultant</authors>
    Public Function Convert_Years_ToMonths(ByVal Years As Integer) As Integer
        Dim Result As Integer
        Result = Years * 12
        Return Result
    End Function
#End Region
#Region "[Functions] <Conversion> [Years] {Convert_Months_ToYears}"
    ''' <summary>
    ''' Convert Months to Years
    ''' </summary>
    ''' <param name="Months">Must be greater than 0</param>
    ''' <returns>As Integer</returns>
    ''' <authors>Saadry Dunkel Consultant</authors>
    Public Function Convert_Months_ToYears(ByVal Months As Integer) As Integer
        Dim Result As Integer
        If Months > 0 Then
            Result = Months / 12
        Else
            Result = 0
        End If
        Return Result
    End Function
#End Region
#Region "[Functions] <Calculation> [Age]"
    ''' <summary>
    ''' Given a Define date it will retrive Age of the Date
    ''' </summary>
    ''' <param name="iDate"></param>
    ''' <returns></returns>
    Public Function Calculate_Age(ByVal iDate As Date) As TimeInfo
        Dim Result As New TimeInfo(iDate)
        With Result.Age
            .Year = Result.Now.Year - Result.Year
            .Month = Result.Now.Month - Result.Month
            .Day = Result.Now.Day - Result.Day
            .Week = Result.Now.Week - Result.Week
            .Hour = Result.Now.Hour - Result.Hour
            .Minutes = Result.Now.Minutes - Result.Minutes
            .Seconds = Result.Now.Seconds - Result.Seconds
            .Milliseconds = Result.Now.Milliseconds - Result.Milliseconds
        End With
        Return Result
    End Function
#End Region
#Region "[Time and Dates] To Timer"
    ''' <summary>
    ''' Convert Time to Milliseconds
    ''' </summary>
    ''' <param name="Years"></param>
    ''' <param name="Months"></param>
    ''' <param name="Weeks"></param>
    ''' <param name="Days"></param>
    ''' <param name="Hours"></param>
    ''' <param name="Minutes"></param>
    ''' <param name="Seconds"></param>
    ''' <returns>As Integer</returns>
    ''' <authors>Saadry Dunkel Consultant</authors>
    Public Function Convert_Time_ToTimer(Optional ByVal Years As Integer = 0,
                                           Optional ByVal Months As Integer = 0,
                                           Optional ByVal Weeks As Integer = 0,
                                           Optional ByVal Days As Integer = 0,
                                           Optional ByVal Hours As Integer = 0,
                                           Optional ByVal Minutes As Integer = 0,
                                           Optional ByVal Seconds As Integer = 0,
                                           Optional ByVal Milliseconds As Integer = 0) As TimeInfo
        Dim Result As New TimeInfo
        With Result
            .Year = Years
            .Month = Convert_Years_ToMonths(Years) + Months
            .Week = Convert_Months_ToWeeks(.Month) + Weeks
            .Day = Convert_Weeks_ToDays(.Week) + Days
            .Hour = Convert_Days_ToHours(.Day) + Hours
            .Minutes = Convert_Hours_ToMinutes(.Hour) + Minutes
            .Seconds = Convert_Minutes_ToSeconds(.Minutes) + Seconds
            .Milliseconds = Convert_Seconds_ToMilliseconds(.Seconds) + Milliseconds
        End With
        Return Result
    End Function 'OK
    Public Function Convert_Timer_ToTime(Optional ByVal Milliseconds As Integer = 0) As TimeInfo
        Dim Result As New TimeInfo
        Dim ts As TimeSpan = TimeSpan.FromMilliseconds(Milliseconds)
        Result.Year = Math.Round(ts.Days / 365, 0)
        Result.Month = Math.Round(ts.Days / 30.436875, 0)
        Result.Day = ts.Days
        Result.Hour = ts.Hours
        Result.Minutes = ts.Minutes

        Result.Seconds = ts.Seconds
        Result.Milliseconds = ts.Milliseconds
        Return Result
    End Function 'OK
    Public Function Convert_DateTime_ToMilliseconds(ByVal iDate As DateTime) As ULong
        Dim Result As ULong = 0
        If iDate.Year = 0 Then
        Else
            Result += (iDate.Year * YearToMs)
        End If
        If iDate.Month = 0 Then
        Else
            Result += (iDate.Month * MonthToMs)
        End If
        If iDate.DayOfYear = 0 Then
        Else
            Result += (iDate.Day * DayToMs)
        End If
        If iDate.Hour = 0 Then
        Else
            Result += (iDate.Hour * HourToMs)
        End If
        If iDate.Minute = 0 Then
        Else
            Result += (iDate.Minute * MinuteToMs)
        End If
        If iDate.Second = 0 Then
        Else
            Result += (iDate.Second * SeconsToMs)
        End If
        Return Result
    End Function
    Public Function Convert_Ms_ToDateTime(ByVal Ms As ULong) As TimeInfo
        Dim Result As New TimeInfo
        'RULE
        'year example 1.00 year = 12 months = 52,1775 Weeks = 365.2425 days = 8765.82 hours = 52949.2 Minutes = 31556952 Seconds = 31556952000 Milliseconds
        '
        Dim leftyear As Double
        Dim leftmonths As Double
        Dim leftweeks As Double
        Dim leftdays As Double
        Dim lefthours As Double
        Dim leftminutes As Double
        Dim leftseconds As Double
        Dim leftmilliseconds As Double

        If Ms >= YearToMs Then
#Region "<Method with year>"
            Result.Year = Math.Round(Ms / YearToMs, 0)
            leftyear = Int(Ms / YearToMs)

            Result.Month = Int(leftyear * 12)
            leftmonths = (leftyear * 12) - Result.Month

            Result.Week = Int(leftyear * 52.1775)

            Result.Day = Int(leftyear / 365.2425)
            leftdays = (leftyear / 365.2425) - Result.Day

            Result.Hour = Int(leftdays * 24)
            lefthours = (leftdays * 24) - Result.Hour

            Result.Minutes = Int(lefthours * 60)
            leftminutes = (lefthours * 60) - Result.Minutes

            Result.Seconds = Int(leftminutes * 60)
            leftseconds = (leftminutes * 60) - Result.Seconds

            Result.Milliseconds = Int(leftseconds * 60)
            leftmilliseconds = (leftseconds * 60) - Result.Milliseconds

            Result.NanoSeconds = Int(leftmilliseconds * 60)
#End Region

        Else
            If Ms >= MonthToMs And Ms < YearToMs Then
#Region "<Method with Months>"
                Result.Year = 0

                Result.Month = Int(Ms / MonthToMs)
                leftmonths = (Ms / MonthToMs) - Result.Month

                Result.Week = Int(Ms / WeekToMs)
                leftweeks = (Ms / WeekToMs) - Result.Week

                Result.Day = Int(leftweeks * 7)
                leftdays = (leftweeks * 7) - Result.Day

                Result.Hour = Int(leftdays * 24)
                lefthours = (leftdays * 24) - Result.Hour

                Result.Minutes = Int(lefthours * 60)
                leftminutes = (lefthours * 60) - Result.Minutes

                Result.Seconds = Int(leftminutes * 60)
                leftseconds = (leftminutes * 60) - Result.Seconds

                Result.Milliseconds = Int(leftseconds * 60)
                leftmilliseconds = (leftseconds * 60) - Result.Milliseconds
#End Region
            Else
                If Ms >= WeekToMs And Ms < MonthToMs Then
#Region "<Method with weeks>"
                    Result.Year = 0

                    Result.Month = Int(Ms / MonthToMs)
                    leftmonths = (Ms / MonthToMs) - Result.Month

                    Result.Week = Int(Ms / WeekToMs)
                    leftweeks = (Ms / WeekToMs) - Result.Week

                    Result.Day = Int(leftweeks * 7)
                    leftdays = (leftweeks * 7) - Result.Day

                    Result.Hour = Int(leftdays * 24)
                    lefthours = (leftdays * 24) - Result.Hour

                    Result.Minutes = Int(lefthours * 60)
                    leftminutes = (lefthours * 60) - Result.Minutes

                    Result.Seconds = Int(leftminutes * 60)
                    leftseconds = (leftminutes * 60) - Result.Seconds

                    Result.Milliseconds = Int(leftseconds * 60)
                    leftmilliseconds = (leftseconds * 60) - Result.Milliseconds
                    Result.NanoSeconds = Int(leftmilliseconds * 60)
#End Region
                Else
                    If Ms >= DayToMs And Ms < WeekToMs Then
#Region "<Method with Days>"
                        Result.Year = 0
                        Result.Month = 0
                        Result.Week = 0

                        Result.Day = Int(Ms / DayToMs)
                        leftdays = (Ms / DayToMs) - Result.Day

                        Result.Hour = Int(leftdays * 24)
                        lefthours = (leftdays * 24) - Result.Hour

                        Result.Minutes = Int(lefthours * 60)
                        leftminutes = (lefthours * 60) - Result.Minutes

                        Result.Seconds = Int(leftminutes * 60)
                        leftseconds = (leftminutes * 60) - Result.Seconds

                        Result.Milliseconds = Int(leftseconds * 60)
                        leftmilliseconds = (leftseconds * 60) - Result.Milliseconds
#End Region
                    Else
                        If Ms >= HourToMs And Ms < DayToMs Then
#Region "<Method with Hours>"
                            Result.Year = 0
                            Result.Month = 0
                            Result.Week = 0
                            Result.Day = 0

                            Result.Hour = Int(Ms / HourToMs)
                            lefthours = (Ms / HourToMs) - Result.Hour

                            Result.Minutes = Int(lefthours * 60)
                            leftminutes = (lefthours * 60) - Result.Minutes

                            Result.Seconds = Int(leftminutes * 60)
                            leftseconds = (leftminutes * 60) - Result.Seconds

                            Result.Milliseconds = Int(leftseconds * 60)
                            leftmilliseconds = (leftseconds * 60) - Result.Milliseconds

                            Result.NanoSeconds = Int(leftmilliseconds * 60)
#End Region
                        Else
                            If Ms >= MinuteToMs And Ms < HourToMs Then
#Region "<Method with Minutes>"
                                Result.Year = 0
                                Result.Month = 0
                                Result.Week = 0
                                Result.Day = 0
                                Result.Hour = 0

                                Result.Minutes = Int(Ms / MinuteToMs)
                                leftminutes = (Ms / MinuteToMs) - Result.Minutes
                                If Int(leftminutes * 60 / MinuteToMs) = 60 Then
                                    Result.Minutes += 1
                                    Result.Seconds = 0
                                End If
                                Result.Seconds = Int(leftminutes * 60 / MinuteToMs) ' If(Int(leftminutes * 60 / MinuteToMs) > 60, Int(leftminutes * 60 / MinuteToMs) - 60, Int(leftminutes * 60 / MinuteToMs))
                                leftseconds = (leftminutes * 60) - Result.Seconds

                                Result.Milliseconds = Int(leftseconds * 60)
                                leftmilliseconds = (leftseconds * 60) - Result.Milliseconds
#End Region
                            Else
                                If Ms >= SeconsToMs And Ms < MinuteToMs Then
#Region "<Method with Seconds>"
                                    Result.Year = 0
                                    Result.Month = 0
                                    Result.Week = 0
                                    Result.Day = 0
                                    Result.Hour = 0
                                    Result.Minutes = 0

                                    Result.Seconds = Int(Ms / SeconsToMs)
                                    leftseconds = (Ms / SeconsToMs) - Result.Seconds

                                    Result.Milliseconds = Int(leftseconds * 60)
                                    leftmilliseconds = (leftseconds * 60) - Result.Milliseconds
#End Region
                                Else
                                    If Ms < SeconsToMs Then
#Region "<Method with Miliseconds>"
                                        Result.Year = 0
                                        Result.Month = 0
                                        Result.Week = 0
                                        Result.Day = 0
                                        Result.Hour = 0
                                        Result.Minutes = 0
                                        Result.Seconds = 0

                                        Result.Milliseconds = Int(Ms)
                                        leftmilliseconds = Ms - Result.Milliseconds

                                        Result.NanoSeconds = Int(leftmilliseconds * 60)
#End Region

                                    End If

                                End If
                            End If

                        End If
                    End If
                End If

            End If
        End If


        Return Result
    End Function
    Public Sub Extract()

    End Sub
#End Region
#Region "[Date] Find Last Day"
    Public Function Find_LastDayOfMonth(intMonth, intYear) As Date
        Find_LastDayOfMonth = DateSerial(intYear, intMonth + 1, 0)
    End Function

#End Region
#Region "[Set Date/Time String Path]"
    '  Public Function ActiveTime() As String
    ' Return Date.Now.Year.ToString & "-" & Date.Now.Month.ToString & "-" & Date.Now.Day.ToString & " " & Date.Now.Hour.ToString & "h" & Date.Now.Minute.ToString
    'End Function
#End Region
#End Region
#Region "|05.03| <Function> [Remove_Character_FromString(Str|String,Expression|String)|String]"
    ''' <summary>
    ''' This simple function find the given expression and removes it
    ''' </summary>
    ''' <param name="Str"></param>
    ''' <param name="Expression"></param>
    ''' <returns>As String</returns>
    Public Function Remove_Character_FromString(ByVal Str As String,
                                                 ByVal Expression As String) As String
        Dim Result As String = Str
        If Str.Contains(Expression) Then
            Result = Replace(Str, Expression, "")
        End If
        Return Result
    End Function
#End Region
#End Region
#Region "|6| [Runtime]"
    Public MyComputer As String = My.Computer.Name
    Public MyUser As String = My.User.Name
    Public All_Classes As TestItem
    Public iGoogle As New SearchEngine("Google", "http://www.google.com", "https://www.google.com/search?ei=fpv6WoerGI7UgQaniZaACw&q=")
    Public iYahoo As New SearchEngine("Yahoo", "http://www.yahoo.com", "https://search.yahoo.com/search?p=")
    Public iMicrosoft As New SearchEngine("Microsoft", "http://www.msdn.microsoft.com", "https://msdn.microsoft.com/en-us/library/")
    Public iRC As New SearchEngine("Registre du Commerce", "https://www.zefix.ch/en/search/entity/welcome", "https://www.zefix.ch/en/search/entity/list?name=")
    Public iSaadryDunkel As New SearchEngine("SaadryDunkel", "https://www.saadry-dunkel.com")
    Public iYoutube As New SearchEngine("Youtube", "https://www.youtube.com/", "https://www.youtube.com/watch?v=", "https://www.youtube.com/watch/v/")
#End Region
#Region "|7| [Loader]"

#End Region
#Region "|8| [Class]"
#Region "|08.00| <Class> [TestItem]"
    ''' <summary>
    ''' The scientific method is an empirical method of acquiring knowledge that has characterized the development of science since at least the 17th century. It involves careful observation, applying rigorous skepticism about what is observed, given that cognitive assumptions can distort how one interprets the observation. It involves formulating hypotheses, via induction, based on such observations; experimental and measurement-based testing of deductions drawn from the hypotheses; and refinement (or elimination) of the hypotheses based on the experimental findings. These are principles of the scientific method, as distinguished from a definitive series of steps applicable to all scientific enterprises.
    ''' Though diverse models for the scientific method are available, there is in general a continuous process that includes observations about the natural world. People are naturally inquisitive, so they often come up with questions about things they see or hear, and they often develop ideas or hypotheses about why things are the way they are. The best hypotheses lead to predictions that can be tested in various ways. The most conclusive testing of hypotheses comes from reasoning based on carefully controlled experimental data. Depending on how well additional tests match the predictions, the original hypothesis may require refinement, alteration, expansion or even rejection. If a particular hypothesis becomes very well supported, a general theory may be developed.[4]
    ''' 
    ''' Although procedures vary from one field Of inquiry To another, they are frequently the same from one To another. The process Of the scientific method involves making conjectures (hypotheses), deriving predictions from them As logical consequences, And Then carrying out experiments Or empirical observations based On those predictions.[5][6] A hypothesis Is a conjecture, based On knowledge obtained While seeking answers To the question. The hypothesis might be very specific, Or it might be broad. Scientists Then test hypotheses by conducting experiments Or studies. A scientific hypothesis must be falsifiable, implying that it Is possible To identify a possible outcome Of an experiment Or observation that conflicts With predictions deduced from the hypothesis; otherwise, the hypothesis cannot be meaningfully tested.[7]
    ''' 
    ''' The purpose Of an experiment Is To determine whether observations agree With Or conflict With the predictions derived from a hypothesis.[8] Experiments can take place anywhere from a garage To CERN's Large Hadron Collider. There are difficulties in a formulaic statement of method, however. Though the scientific method is often presented as a fixed sequence of steps, it represents rather a set of general principles.[9] Not all steps take place in every scientific inquiry (nor to the same degree), and they are not always in the same order.[10][11] Some philosophers and scientists have argued that there is no scientific method; they include physicist Lee Smolin[12] and philosopher Paul Feyerabend (in his Against Method). Robert Nola and Howard Sankey remark that "For some, the whole idea of a theory of scientific method is yester-year's debate, the continuation of which can be summed up as yet more of the proverbial deceased equine castigation. We beg to differ.
    ''' </summary>
    Public Class TestItem

#Region "<0> [Property]{...}"
#Region "<00.00> <Property> [Info]{...}"
#Region "[2019/03/24 14h08:629]<00.00.00> <Property> [ID|Integer]"
        Private _ID As Integer
        ''' <summary>
        ''' (Set|Get) The ID of the Test
        ''' </summary>
        ''' <returns></returns>
        ''' <author>Saadry Dunkel Consultant 24.03.2019 14:08</author>
        <CategoryAttribute("Info"),
       Description("(Set|Get) The ID of the Test"),
       Browsable(True)>
        Public Property ID() As Integer
            Get
                Return _ID
            End Get
            Set(ByVal value As Integer)
                _ID = value
            End Set
        End Property
#End Region 'The ID of the Test
#Region "[2019/03/24 14h08:685]<00.00.01> <Property> [Name|String]"
        Private _Name As String
        ''' <summary>
        ''' (Set|Get) The name of the Test
        ''' </summary>
        ''' <returns></returns>
        ''' <author>Saadry Dunkel Consultant 24.03.2019 14:08</author>
        <CategoryAttribute("Info"),
       Description("(Set|Get) The name of the Test"),
       Browsable(True)>
        Public Property Name() As String
            Get
                Return _Name
            End Get
            Set(ByVal value As String)
                _Name = value
            End Set
        End Property
#End Region 'The name of the Test
#Region "[2019/03/24 14h12:453]<00.00.02> <Property> [Hypothesis|String]"
        Private _Hypothesis As String
        ''' <summary>
        ''' (Set|Get) A hypothesis is a conjecture, based on knowledge obtained while formulating the question, that may explain any given behavaior.
        ''' </summary>
        ''' <returns></returns>
        ''' <author>Saadry Dunkel Consultant 24.03.2019 14:12</author>
        <CategoryAttribute("Info"),
       Description("(Set|Get) A hypothesis is a conjecture, based on knowledge obtained while formulating the question, that may explain any given behavior."),
       Browsable(True)>
        Public Property Hypothesis() As String
            Get
                Return _Hypothesis
            End Get
            Set(ByVal value As String)
                _Hypothesis = value
            End Set
        End Property
#End Region 'A hypothesis is a conjecture, based on knowledge obtained while formulating the question, that may explain any given behavior.
#Region "[2019/03/24 14h15:817]<00.00.03> <Property> [Prediction|String]"
        Private _Prediction As String
        ''' <summary>
        ''' (Set|Get) This step involves determining the logical consequences of the hypothesis. One or more predictions are then selected for further testing. The more unlikely that a prediction would be correct simply by coincidence, then the more convincing it would be if the prediction were fulfilled; evidence is also stronger if the answer to the prediction is not already known, due to the effects of hindsight bias (see also postdiction). Ideally, the prediction must also distinguish the hypothesis from likely alternatives; if two hypotheses make the same prediction, observing the prediction to be correct is not evidence for either one over the other. (These statements about the relative strength of evidence can be mathematically derived using Bayes' Theorem).
        ''' </summary>
        ''' <returns></returns>
        ''' <author>Saadry Dunkel Consultant 24.03.2019 14:15</author>
        <CategoryAttribute("Info"),
       Description("(Set|Get) This step involves determining the logical consequences of the hypothesis. One or more predictions are then selected for further testing. The more unlikely that a prediction would be correct simply by coincidence, then the more convincing it would be if the prediction were fulfilled; evidence is also stronger if the answer to the prediction is not already known, due to the effects of hindsight bias (see also postdiction). Ideally, the prediction must also distinguish the hypothesis from likely alternatives; if two hypotheses make the same prediction, observing the prediction to be correct is not evidence for either one over the other. (These statements about the relative strength of evidence can be mathematically derived using Bayes' Theorem)."),
       Browsable(True)>
        Public Property Prediction() As String
            Get
                Return _Prediction
            End Get
            Set(ByVal value As String)
                _Prediction = value
            End Set
        End Property
#End Region 'This step involves determining the logical consequences of the hypothesis. One or more predictions are then selected for further testing. The more unlikely that a prediction would be correct simply by coincidence, then the more convincing it would be if the prediction were fulfilled; evidence is also stronger if the answer to the prediction is not already known, due to the effects of hindsight bias (see also postdiction). Ideally, the prediction must also distinguish the hypothesis from likely alternatives; if two hypotheses make the same prediction, observing the prediction to be correct is not evidence for either one over the other. (These statements about the relative strength of evidence can be mathematically derived using Bayes' Theorem).
#Region "[2019/03/24 14h24:721]<00.00.04> <Property> [Time|DateTime]"
        Private _Time As DateTime
        ''' <summary>
        ''' (Set|Get) Record when the test has been created
        ''' </summary>
        ''' <returns></returns>
        ''' <author>Saadry Dunkel Consultant 24.03.2019 14:24</author>
        <CategoryAttribute("Info"),
       Description("(Set|Get) Record when the test has been created"),
       Browsable(True)>
        Public Property Time() As DateTime
            Get
                Return _Time
            End Get
            Set(ByVal value As DateTime)
                _Time = value
            End Set
        End Property
#End Region 'Record when the test has been created
#Region "[2019/03/24 14h26:005]<00.00.05> <Property> [Email|String]"
        Private _Email As String
        ''' <summary>
        ''' (Set|Get) The email to send report to
        ''' </summary>
        ''' <returns></returns>
        ''' <author>Saadry Dunkel Consultant 24.03.2019 14:26</author>
        <CategoryAttribute("Info"),
       Description("(Set|Get) The email to send report to"),
       Browsable(True)>
        Public Property Email() As String
            Get
                Return _Email
            End Get
            Set(ByVal value As String)
                _Email = value
            End Set
        End Property
#End Region 'The email to send report to
#Region "[2019/03/24 14h31:566]<00.00.06> <Property> [MyProperty|DevComponents.DotNetBar.AdvPropertyGrid]"
        Private _MyProperty As DevComponents.DotNetBar.AdvPropertyGrid
        ''' <summary>
        ''' (Set|Get) An DevComponents.DotNetBar.AdvPropertyGrid Object to display properties of the class.
        ''' </summary>
        ''' <returns></returns>
        ''' <author>Saadry Dunkel Consultant 24.03.2019 14:31</author>
        <CategoryAttribute("Info"),
       Description("(Set|Get) An DevComponents.DotNetBar.AdvPropertyGrid Object to display properties of the class."),
       Browsable(True)>
        Public Property MyProperty() As DevComponents.DotNetBar.AdvPropertyGrid
            Get
                Return _MyProperty
            End Get
            Set(ByVal value As DevComponents.DotNetBar.AdvPropertyGrid)
                _MyProperty = value
            End Set
        End Property
#End Region 'An DevComponents.DotNetBar.AdvPropertyGrid Object to display properties of the class.
#End Region
#Region "<00.01> <Property> [Explication]{...}"
#Region "[2019/03/24 14h23:190]<00.01.00> <Property> [Why|String]"
        Private _Why As String
        ''' <summary>
        ''' (Set|Get) Retrieve why the test has failed.
        ''' </summary>
        ''' <returns></returns>
        ''' <author>Saadry Dunkel Consultant 24.03.2019 14:23</author>
        <CategoryAttribute("Explication"),
       Description("(Set|Get) Retrieve why the test has failed."),
       Browsable(True)>
        Public Property Why() As String
            Get
                Return _Why
            End Get
            Set(ByVal value As String)
                _Why = value
            End Set
        End Property
#End Region 'Retrieve why the test has failed.
#End Region
#Region "<00.02> <Property> [Value]{...}"
#Region "[2019/03/24 14h34:678]<00.02.00> <Property> [Text|String]"
        Private _Text As String
        ''' <summary>
        ''' (Set|Get) The text of the test.
        ''' </summary>
        ''' <returns></returns>
        ''' <author>Saadry Dunkel Consultant 24.03.2019 14:34</author>
        <CategoryAttribute("Value"),
       Description("(Set|Get) The text of the test."),
       Browsable(True)>
        Public Property Text() As String
            Get
                Return _Text
            End Get
            Set(ByVal value As String)
                _Text = value
            End Set
        End Property
#End Region 'The text of the test.
#Region "[2019/03/24 14h34:709]<00.02.01> <Property> [Tag|Object]"
        Private _Tag As Object
        ''' <summary>
        ''' (Set|Get) Use to record an object
        ''' </summary>
        ''' <returns></returns>
        ''' <author>Saadry Dunkel Consultant 24.03.2019 14:34</author>
        <CategoryAttribute("Value"),
       Description("(Set|Get) Use to record an object"),
       Browsable(True)>
        Public Property Tag() As Object
            Get
                Return _Tag
            End Get
            Set(ByVal value As Object)
                _Tag = value
            End Set
        End Property
#End Region 'Use to record an object
#Region "[2019/03/24 14h35:354]<00.02.02> <Property> [ImageIndex|Integer]"
        Private _ImageIndex As Integer
        ''' <summary>
        ''' (Set|Get) The ImagIndex of the Test
        ''' </summary>
        ''' <returns></returns>
        ''' <author>Saadry Dunkel Consultant 24.03.2019 14:35</author>
        <CategoryAttribute("Value"),
       Description("(Set|Get) The ImagIndex of the Test"),
       Browsable(True)>
        Public Property ImageIndex() As Integer
            Get
                Return _ImageIndex
            End Get
            Set(ByVal value As Integer)
                _ImageIndex = value
            End Set
        End Property
#End Region 'The ImagIndex of the Test
#Region "[2019/03/24 14h36:026]<00.02.03> <Property> [ToolTip|String]"
        Private _ToolTip As String
        ''' <summary>
        ''' (Set|Get) The description of the Test 
        ''' </summary>
        ''' <returns></returns>
        ''' <author>Saadry Dunkel Consultant 24.03.2019 14:36</author>
        <CategoryAttribute("Value"),
       Description("(Set|Get) The description of the Test "),
       Browsable(True)>
        Public Property ToolTip() As String
            Get
                Return _ToolTip
            End Get
            Set(ByVal value As String)
                _ToolTip = value
            End Set
        End Property
#End Region 'The description of the Test 
#Region "[2019/03/24 14h37:694]<00.02.04> <Property> [Status|Status]"
        Private _Status As Status
        ''' <summary>
        ''' (Set|Get) The State of the Test
        ''' </summary>
        ''' <returns></returns>
        ''' <author>Saadry Dunkel Consultant 24.03.2019 14:37</author>
        <CategoryAttribute("Value"),
       Description("(Set|Get) The State of the Test"),
       Browsable(True)>
        Public Property Status() As Status
            Get
                Return _Status
            End Get
            Set(ByVal value As Status)
                _Status = value
            End Set
        End Property
#End Region 'The State of the Test
#End Region
#Region "<00.03> <Property> [Output]{...}"
#Region "[2019/03/24 14h38:248]<00.03.00> <Property> [OutputString|String]"
        Private _OutputString As String
        ''' <summary>
        ''' (Set|Get) Returns the Output Results as String.
        ''' </summary>
        ''' <returns></returns>
        ''' <author>Saadry Dunkel Consultant 24.03.2019 14:38</author>
        <CategoryAttribute("Output"),
       Description("(Set|Get) Returns the Output Results as String."),
       Browsable(True)>
        Public Property OutputString() As String
            Get
                Return _OutputString
            End Get
            Set(ByVal value As String)
                _OutputString = value
            End Set
        End Property
#End Region 'Returns the Output Results as String.
#Region "[2019/03/24 14h39:546]<00.03.01> <Property> [Output|Object]"
        Private _Output As Object
        ''' <summary>
        ''' (Set|Get) Returns the Output Results as Object.
        ''' </summary>
        ''' <returns></returns>
        ''' <author>Saadry Dunkel Consultant 24.03.2019 14:39</author>
        <CategoryAttribute("Output"),
       Description("(Set|Get) Returns the Output Results as Object."),
       Browsable(True)>
        Public Property Output() As Object
            Get
                Return _Output
            End Get
            Set(ByVal value As Object)
                _Output = value
            End Set
        End Property
#End Region 'Returns the Output Results as Object.
#Region "[2019/03/24 14h42:490]<00.03.02> <Property> [OutputParams|List(Of Input_Parameters)]"
        Private _OutputParams As List(Of Input_Parameters)
        ''' <summary>
        ''' (Set|Get) List of Input_Parameters recored for a Method use Test.
        ''' </summary>
        ''' <returns></returns>
        ''' <author>Saadry Dunkel Consultant 24.03.2019 14:42</author>
        <CategoryAttribute("Output"),
       Description("(Set|Get) List of Input_Parameters recored for a Method use Test."),
       Browsable(True)>
        Public Property OutputParams() As List(Of Input_Parameters)
            Get
                Return _OutputParams
            End Get
            Set(ByVal value As List(Of Input_Parameters))
                _OutputParams = value
            End Set
        End Property
#End Region 'List of Input_Parameters recored for a Method use Test.
#End Region
#Region "<00.04> <Property> [Controls]{...}"
#Region "[2019/03/25 12h39:976]<00.04.00> <Property> [Walkthrough|List(Of Steps)]"
        Private _Walkthrough As List(Of Steps)
        ''' <summary>
        ''' (Set|Get) Records of the steps.
        ''' </summary>
        ''' <returns></returns>
        ''' <author>Saadry Dunkel Consultant 25.03.2019 12:39</author>
        <CategoryAttribute("Controls"),
       Description("(Set|Get) Records of the steps."),
       Browsable(True)>
        Public Property Walkthrough() As List(Of Steps)
            Get
                Return _Walkthrough
            End Get
            Set(ByVal value As List(Of Steps))
                _Walkthrough = value
            End Set
        End Property
#End Region 'Records of the steps.
#Region "[2019/03/25 13h19:915]<00.04.01> <Property> [Bugs|List(Of Bug)]"
        Private _Bugs As List(Of Bug)
        ''' <summary>
        ''' (Set|Get) List all exceptions as Bug.
        ''' </summary>
        ''' <returns></returns>
        ''' <author>Saadry Dunkel Consultant 25.03.2019 13:19</author>
        <CategoryAttribute("Controls"),
       Description("(Set|Get) List all exceptions as Bug."),
       Browsable(True)>
        Public Property Bugs() As List(Of Bug)
            Get
                Return _Bugs
            End Get
            Set(ByVal value As List(Of Bug))
                _Bugs = value
            End Set
        End Property
#End Region 'List all exceptions as Bug.
#End Region
#Region "<00.05> <Property> [Input]{...}"
#Region "[2019/03/25 13h21:600]<00.05.00> <Property> [InputString|String]"
        Private _InputString As String
        ''' <summary>
        ''' (Set|Get) Returns the Input as String.
        ''' </summary>
        ''' <returns></returns>
        ''' <author>Saadry Dunkel Consultant 25.03.2019 13:21</author>
        <CategoryAttribute("Input"),
       Description("(Set|Get) Returns the Input as String."),
       Browsable(True)>
        Public Property InputString() As String
            Get
                Return _InputString
            End Get
            Set(ByVal value As String)
                _InputString = value
            End Set
        End Property
#End Region 'Returns the Input as String.
#Region "[2019/03/25 13h22:019]<00.05.01> <Property> [Input|Object]"
        Private _Input As Object
        ''' <summary>
        ''' (Set|Get) Returns the Input variable as Object.
        ''' </summary>
        ''' <returns></returns>
        ''' <author>Saadry Dunkel Consultant 25.03.2019 13:22</author>
        <CategoryAttribute("Input"),
       Description("(Set|Get) Returns the Input variable as Object."),
       Browsable(True)>
        Public Property Input() As Object
            Get
                Return _Input
            End Get
            Set(ByVal value As Object)
                _Input = value
            End Set
        End Property
#End Region 'Returns the Input variable as Object.
#Region "[2019/03/25 13h24:599]<00.05.02> <Property> [InputParams|List(Of Input_Parameters)]"
        Private _InputParams As List(Of Input_Parameters)
        ''' <summary>
        ''' (Set|Get) List of variables as List(Of Input_Parameters) recored for a Method use Test.
        ''' </summary>
        ''' <returns></returns>
        ''' <author>Saadry Dunkel Consultant 25.03.2019 13:24</author>
        <CategoryAttribute("Input"),
       Description("(Set|Get) List of variables as List(Of Input_Parameters) recored for a Method use Test."),
       Browsable(True)>
        Public Property InputParams() As List(Of Input_Parameters)
            Get
                Return _InputParams
            End Get
            Set(ByVal value As List(Of Input_Parameters))
                _InputParams = value
            End Set
        End Property
#End Region 'List of variables as List(Of Input_Parameters) recored for a Method use Test.
#End Region
        Public Property DataSource As List(Of Object)
        Property ParentTestItem As TestItem




#Region "TestItem| <00.01> <Property> [Controls]"
        'Records of all controls tuggled
        'Records of all exceptions captured
#Region "TestItem| <00.01.02> <Property> <Controls> [Node | DevComponents.AdvTree.Node]"
        Private _Node As DevComponents.AdvTree.Node
        ''' <summary>
        ''' (Set|Get) Map the tests in a TreeNode 
        ''' Adapted for a DevComponents.AdvTree.AdvTree
        ''' </summary>
        ''' <returns></returns>
        <CategoryAttribute("TestItem| Controls"),
    Browsable(True),
    Description("(Set|Get) Map the tests in a TreeNode")>
        Public Property Node() As DevComponents.AdvTree.Node
            Get
                Return _Node
            End Get
            Set(ByVal value As DevComponents.AdvTree.Node)
                _Node = value
            End Set
        End Property
#End Region
#Region "TestItem| <00.01.03> <Property> <Controls> [Item | ListViewItem]"
        Private _Item As ListViewItem
        ''' <summary>
        ''' (Set|Get) A ListViewItem which records the tests results 
        ''' Adapted for a ListView or List(Of ListViewItem) or SmartListView
        ''' </summary>
        ''' <returns></returns>
        <CategoryAttribute("TestItem| Controls"),
    Browsable(True),
    Description("(Set|Get) A ListViewItem which records the tests results")>
        Public Property Item() As ListViewItem
            Get
                Return _Item
            End Get
            Set(ByVal value As ListViewItem)
                _Item = value
            End Set
        End Property
#End Region
#Region "TestItem| <00.01.04> <Property> <Controls> [Body | String]"
        Private _Body As String
        ''' <summary>
        ''' (Set|Get) A records of the tests results 
        ''' </summary>
        ''' <returns></returns>
        <CategoryAttribute("TestItem| Controls"),
    Browsable(True),
    Description("(Set|Get) A records of the tests results ")>
        Public Property Body() As String
            Get
                Return _Body
            End Get
            Set(ByVal value As String)
                _Body = value
            End Set
        End Property
#End Region
#Region "TestItem| <00.01.05> <Property> <Controls> [Events | List(Of Evenement)]"
        Private _Events As List(Of Evenement)
        ''' <summary>
        ''' (Set|Get) Records of the steps
        ''' </summary>
        ''' <returns></returns>
        <CategoryAttribute("TestItem| Controls"),
    Browsable(True),
    Description("(Set|Get) Records of the steps")>
        Public Property Events() As List(Of Evenement)
            Get
                Return _Events
            End Get
            Set(ByVal value As List(Of Evenement))
                _Events = value
            End Set
        End Property
        Public Class Evenement
#Region "Evenement| <00.00.00> <Property> <Info> [ID | Integer]"
            Private _ID As Integer
            ''' <summary>
            ''' (Set|Get) The ID of the Test
            ''' </summary>
            ''' <returns></returns>
            <CategoryAttribute("Evenement| Info"),
    Browsable(True),
    Description("(Set|Get) The ID of the Test")>
            Public Property ID() As Integer
                Get
                    Return _ID
                End Get
                Set(ByVal value As Integer)
                    _ID = value
                End Set
            End Property
#End Region
#Region "Evenement| <00.00.01> <Property> <Info> [Name | String]"
            Private _Name As String
            ''' <summary>
            ''' (Set|Get) The Name of the Test
            ''' </summary>
            ''' <returns></returns>
            <CategoryAttribute("Evenement| Info"),
    Browsable(True),
    Description("(Set|Get) The Name of the Test")>
            Public Property Name() As String
                Get
                    Return _Name
                End Get
                Set(ByVal value As String)
                    _Name = value
                End Set
            End Property
#End Region
#Region "Evenement| <00.00.03> <Property> <Info> [Time | DateTime]"
            Private _Time As DateTime
            ''' <summary>
            ''' (Set|Get) Define the Time
            ''' </summary>
            ''' <returns></returns>
            <CategoryAttribute("Evenement| Info"),
    Browsable(True),
    Description("(Set|Get) Define the Time")>
            Public Property Time() As DateTime
                Get
                    Return _Time
                End Get
                Set(ByVal value As DateTime)
                    _Time = value
                End Set
            End Property
#End Region
#Region "Evenement| <00.00.04> <Property> <Info> [Status | Status]"
            Private _Status As Status
            ''' <summary>
            ''' (Set|Get) The State of the Test
            ''' </summary>
            ''' <returns></returns>
            <CategoryAttribute("Evenement| Info"),
    Browsable(True),
    Description("(Set|Get) The State of the Test")>
            Public Property Status() As Status
                Get
                    Return _Status
                End Get
                Set(ByVal value As Status)
                    _Status = value
                End Set
            End Property
#End Region
#Region "Evenement| <00.00.05> <Property> <Info> [Description | String]"
            Private _Description As Status
            ''' <summary>
            ''' (Set|Get) Returns the command Description
            ''' </summary>
            ''' <returns></returns>
            <CategoryAttribute("Evenement| Info"),
    Browsable(True),
    Description("(Set|Get) Returns the command Description")>
            Public Property Description() As String
                Get
                    Return _Description
                End Get
                Set(ByVal value As String)

                    '_Description = value
                End Set
            End Property
#End Region
#Region "Evenement| <00.00.06> <Property> <Info> [Hypothesis | String]"
            Private _Hypothesis As String
            ''' <summary>
            ''' (Set|Get) The Hypothesis of the Test
            ''' </summary>
            ''' <returns></returns>
            <CategoryAttribute("Evenement| Info"),
    Browsable(True),
    Description("(Set|Get) The Hypothesis of the Test")>
            Public Property Hypothesis() As String
                Get
                    Return _Hypothesis
                End Get
                Set(ByVal value As String)
                    _Hypothesis = value
                End Set
            End Property
#End Region
#Region "Evenement| <00.00.07> <Property> <Info> [Ref | String]"
            Private _Ref As String
            ''' <summary>
            ''' (Set|Get) Returns the code of the Region
            ''' </summary>
            ''' <returns></returns>
            <CategoryAttribute("Evenement| Info"),
    Browsable(True),
    Description("(Set|Get) Returns the code of the Region")>
            Public Property Ref() As String
                Get
                    Return _Ref
                End Get
                Set(ByVal value As String)
                    _Ref = value
                End Set
            End Property
#End Region
#Region "Evenement| <00.00.08> <Property> <Info> [Tag | Object]"
            Private _Tag As Object
            ''' <summary>
            ''' (Set|Get) Returns the element analysed
            ''' </summary>
            ''' <returns></returns>
            <CategoryAttribute("Evenement| Info"),
        Browsable(True),
        Description("(Set|Get) Returns the element analysed")>
            Public Property Tag() As Object
                Get
                    Return _Tag
                End Get
                Set(ByVal value As Object)
                    _Tag = value
                End Set
            End Property
#End Region
            Public Sub New(ByVal _ID As Integer,
                           ByVal _Name As String,
                           ByVal _Status As Status,
                           ByVal _Hypothesis As String,
                           ByVal _Ref As String,
                           ByVal _Description As String,
                           Optional ByVal _Tag As Object = Nothing)
                With Me
                    .ID = _ID
                    .Name = _Name
                    .Status = _Status
                    .Hypothesis = _Hypothesis
                    .Ref = _Ref
                    .Description = _Description
                    .Time = Now
                    If IsNothing(_Tag) Then
                    Else
                        .Tag = _Tag
                    End If
                End With
            End Sub

            Public Function Print_ToString() As String
                Dim Result As String = "#Region " & """" & "[Suivi " & ID & " ] " & Me.Name & " Ref " & Ref & " " & """" & vbNewLine
                Result += "<ID>          " & "          " & ID & "      </ID>" & vbNewLine &
                          "<Name>        " & "          " & ID & "      </Name>" & vbNewLine &
                          "<Time>        " & "          " & FormatDateTime(Time) & "      </Time>" & vbNewLine &
                          "<Status>      " & "          " & StatusToString(Status) & "      </Status>" & vbNewLine &
                          "<Description> " & "          " & Description & "      </Description>" & vbNewLine &
                          "<Hypothèse>   " & "          " & Hypothesis & "      </Hypothèse>" & vbNewLine &
                          "<Ref>         " & "          " & Ref & "      </Ref>" & vbNewLine &
                          "<Tag>         " & "          " & If(IsNothing(Tag), "Indéfini", Tag.ToString) & "      </Tag>" & vbNewLine
                Result += "#End Region" & vbNewLine
                Return Result
            End Function
        End Class
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="LV"></param>
        Public Sub Events_ToListView(ByRef LV As ListViewEx)
            If IsNothing(Walkthrough) Then
            Else
                If IsNothing(LV) Then
                Else
                    If LV.Columns.Count - 1 > 0 Then
                        LV.Columns.Clear()
                    End If
                    Dim C_ID As New ColumnHeader
                    With C_ID
                        .Text = "ID"
                        .Width = 100
                    End With
                    Dim C_Name As New ColumnHeader
                    With C_Name
                        .Text = "Name"
                        .Width = 150
                    End With
                    Dim C_Time As New ColumnHeader
                    With C_Time
                        .Text = "Time"
                        .Width = 150
                    End With
                    Dim C_Status As New ColumnHeader
                    With C_Status
                        .Text = "Status"
                        .Width = 100
                    End With
                    Dim C_Description As New ColumnHeader
                    With C_Description
                        .Text = "Description"
                        .Width = 200
                    End With
                    Dim C_Hypothesis As New ColumnHeader
                    With C_Hypothesis
                        .Text = "Hypothesis"
                        .Width = 150
                    End With
                    Dim C_Ref As New ColumnHeader
                    With C_Ref
                        .Text = "Ref"
                        .Width = 150
                    End With
                    LV.Columns.Add(C_ID)
                    LV.Columns.Add(C_Name)
                    LV.Columns.Add(C_Time)
                    LV.Columns.Add(C_Status)
                    LV.Columns.Add(C_Description)
                    LV.Columns.Add(C_Hypothesis)
                    LV.Columns.Add(C_Ref)

                    If Walkthrough.Count - 1 > 0 Then
                        LV.Items.Clear()

                        For i = 0 To Events.Count - 1
                            Dim it As New ListViewItem(Events(i).ID)
                            it.Name = (Events(i).ID) & Events(i).Name
                            it.SubItems.Add(Events(i).Name)
                            it.SubItems.Add(FormatDateTime(Events(i).Time))
                            it.SubItems.Add(StatusToString(Events(i).Status))
                            it.SubItems.Add(Events(i).Description)
                            it.SubItems.Add(Events(i).Hypothesis)
                            it.SubItems.Add(Events(i).Ref)
                            it.ImageIndex = Events(i).Status
                            it.ToolTipText = Events(i).ID & " | hypothèse : " & Events(i).Hypothesis & " | Status " & StatusToString(Events(i).Status)
                            it.Tag = Events(i)
                            LV.Items.Add(it)
                        Next
                    End If
                End If
            End If
        End Sub
        Public Sub Events_ToListViewEx(ByRef LV As ListViewEx)
            If IsNothing(Walkthrough) Then
            Else
                If IsNothing(LV) Then
                Else
                    If LV.Columns.Count - 1 > 0 Then
                        LV.Columns.Clear()
                    End If
                    Dim C_ID As New ColumnHeader
                    With C_ID
                        .Text = "ID"
                        .Width = 100
                    End With
                    Dim C_Name As New ColumnHeader
                    With C_Name
                        .Text = "Name"
                        .Width = 150
                    End With
                    Dim C_Time As New ColumnHeader
                    With C_Time
                        .Text = "Time"
                        .Width = 150
                    End With
                    Dim C_Status As New ColumnHeader
                    With C_Status
                        .Text = "Status"
                        .Width = 100
                    End With
                    Dim C_Description As New ColumnHeader
                    With C_Description
                        .Text = "Description"
                        .Width = 200
                    End With
                    Dim C_Hypothesis As New ColumnHeader
                    With C_Hypothesis
                        .Text = "Hypothesis"
                        .Width = 150
                    End With
                    Dim C_Ref As New ColumnHeader
                    With C_Ref
                        .Text = "Ref"
                        .Width = 150
                    End With
                    LV.Columns.Add(C_ID)
                    LV.Columns.Add(C_Name)
                    LV.Columns.Add(C_Time)
                    LV.Columns.Add(C_Status)
                    LV.Columns.Add(C_Description)
                    LV.Columns.Add(C_Hypothesis)
                    LV.Columns.Add(C_Ref)

                    If Walkthrough.Count - 1 > 0 Then
                        LV.Items.Clear()

                        For i = 0 To Events.Count - 1
                            Dim it As New ListViewItem(Events(i).ID)
                            it.Name = (Events(i).ID) & Events(i).Name
                            it.SubItems.Add(Events(i).Name)
                            it.SubItems.Add(FormatDateTime(Events(i).Time))
                            it.SubItems.Add(StatusToString(Events(i).Status))
                            it.SubItems.Add(Events(i).Description)
                            it.SubItems.Add(Events(i).Hypothesis)
                            it.SubItems.Add(Events(i).Ref)
                            it.ImageIndex = Events(i).Status
                            it.ToolTipText = Events(i).ID & " | hypothèse : " & Events(i).Hypothesis & " | Status " & StatusToString(Events(i).Status)
                            it.Tag = Events(i)
                            LV.Items.Add(it)
                        Next
                    End If
                End If
            End If
        End Sub
        Public Sub Events_ToNode(ByRef ParentNode As TreeNode)
            If IsNothing(Walkthrough) Then
            Else
                If IsNothing(ParentNode) Then
                Else
                    If Events.Count - 1 > 0 Then
                        For i = 0 To Events.Count - 1
                            Dim it As New TreeNode
                            it.Text = (Events(i).ID) & Events(i).Name
                            it.ImageIndex = Events(i).Status
                            it.ToolTipText = Events(i).ID & " | hypothèse : " & Events(i).Hypothesis & " | Status " & StatusToString(Events(i).Status)
                            it.Tag = Events(i)
                            ParentNode.Nodes.Add(it)
                        Next
                    End If
                End If
            End If
        End Sub
        Public Sub Events_ToNodeX(ByRef ParentNode As DevComponents.AdvTree.Node)
            If IsNothing(Walkthrough) Then
            Else
                If IsNothing(ParentNode) Then
                Else
                    If Events.Count - 1 > 0 Then
                        For i = 0 To Events.Count - 1
                            Dim it As New DevComponents.AdvTree.Node
                            it.Text = (Events(i).ID) & Events(i).Name
                            it.ImageIndex = Events(i).Status
                            it.Tooltip = Events(i).ID & " | hypothèse : " & Events(i).Hypothesis & " | Status " & StatusToString(Events(i).Status)
                            it.Tag = Events(i)
                            ParentNode.Nodes.Add(it)
                        Next
                    End If
                End If
            End If
        End Sub
        Public Sub Events_ToNodeG(ByRef ParentNode As DevComponents.Tree.Node)
            If IsNothing(Walkthrough) Then
            Else
                If IsNothing(ParentNode) Then
                Else
                    If Events.Count - 1 > 0 Then
                        For i = 0 To Events.Count - 1
                            Dim it As New DevComponents.Tree.Node
                            it.Text = "Event " & (Events(i).ID) & Events(i).Name
                            it.ImageIndex = Events(i).Status
                            ' it.Tooltip = Events(i).ID & " | hypothèse : " & Events(i).Hypothesis & " | Status " & Events(i).Status)
                            it.Tag = Events(i)
                            ParentNode.Nodes.Add(it)
                        Next
                    End If
                End If
            End If
        End Sub
#End Region
#Region "TestItem| <00.01.06> <Property> <Controls> [Nod | TreeNode]"
        Private _Nod As TreeNode
        ''' <summary>
        ''' (Set|Get) Map the tests in a TreeNode 
        ''' Adapted for a TreeView
        ''' </summary>
        ''' <returns></returns>
        <CategoryAttribute("TestItem| Controls"),
    Browsable(True),
    Description("(Set|Get) Map the tests in a TreeNode")>
        Public Property Nod() As TreeNode
            Get
                Return _Nod
            End Get
            Set(ByVal value As TreeNode)
                _Nod = value
            End Set
        End Property
#End Region
#Region "TestItem| <00.01.07> <Property> <Controls> [NodeG | DevComponents.Tree.Node]"
        Private _NodeG As DevComponents.Tree.Node
        ''' <summary>
        ''' (Set|Get) Map the tests in a DevComponents.Tree.Node 
        ''' Adapted for a DevComponents.Tree.Tree
        ''' </summary>
        ''' <returns></returns>
        <CategoryAttribute("TestItem| Controls"),
        Browsable(True),
        Description("(Set|Get) Map the tests in a DevComponents.Tree.Node")>
        Public Property NodeG() As DevComponents.Tree.Node
            Get
                Return _NodeG
            End Get
            Set(ByVal value As DevComponents.Tree.Node)
                _NodeG = value
            End Set
        End Property
#End Region
#End Region
#Region "TestItem| <00.03> <Property> [Result]"
#Region "TestItem| <00.03.00> <Property> <Result> [Results | List(Of TestItem)]"
        Private _Results As List(Of TestItem)
        ''' <summary>
        ''' (Set|Get) List of Results 
        ''' Adapted for a TestView
        ''' </summary>
        ''' <returns></returns>
        <CategoryAttribute("TestItem| Result"),
    Browsable(True),
    Description("(Set|Get) Map the tests in a TreeNode")>
        Public Property Results() As List(Of TestItem)
            Get
                Return _Results
            End Get
            Set(ByVal value As List(Of TestItem))
                _Results = value
            End Set
        End Property
#End Region
#Region "TestItem| <00.03.01> <Property> <Result> [List_Pass | List(Of TestItem)]"
        Private _List_Pass As List(Of TestItem)
        ''' <summary>
        ''' (Set|Get) Results which are either Online or Finished
        ''' </summary>
        ''' <returns></returns>
        <CategoryAttribute("TestItem| Result"),
    Browsable(True),
    Description("(Set|Get) Results which are either Online or Finished")>
        Public Property List_Pass() As List(Of TestItem)
            Get
                Return _List_Pass
            End Get
            Set(ByVal value As List(Of TestItem))
                If IsNothing(value) Then
                Else
                End If

                _List_Pass = value

            End Set
        End Property
#End Region
#Region "TestItem| <00.03.02> <Property> <Result> [List_Fails | List(Of TestItem)]"
        Private _List_Fails As List(Of TestItem)
        ''' <summary>
        ''' (Set|Get) Results which are either Broken or Offline
        ''' </summary>
        ''' <returns></returns>
        <CategoryAttribute("TestItem| Result"),
    Browsable(True),
    Description("(Set|Get) Results which are either Broken or Offline")>
        Public Property List_Fails() As List(Of TestItem)
            Get
                Return _List_Fails
            End Get
            Set(ByVal value As List(Of TestItem))
                If IsNothing(value) Then
                Else
                End If
                _List_Fails = value
            End Set
        End Property
#End Region
#Region "TestItem| <00.03.03> <Property> <Result> [List_Warning | List(Of TestItem)]"
        Private _List_Warning As List(Of TestItem)
        ''' <summary>
        ''' (Set|Get) Results with errors
        ''' </summary>
        ''' <returns></returns>
        <CategoryAttribute("TestItem| Result"),
    Browsable(True),
    Description("(Set|Get) Results with errors")>
        Public Property List_Warning() As List(Of TestItem)
            Get
                Return _List_Warning
            End Get
            Set(ByVal value As List(Of TestItem))
                If IsNothing(value) Then
                Else
                End If

                _List_Warning = value
            End Set
        End Property
#End Region
#Region "TestItem| <00.03.04> <Property> <Result> [List_Nul | List(Of TestItem)]"
        Private _List_Nul As List(Of TestItem)
        ''' <summary>
        ''' (Set|Get) Results which are either NotTested, StandBye, Running or IsNothing
        ''' </summary>
        ''' <returns></returns>
        <CategoryAttribute("TestItem| Result"),
    Browsable(True),
    Description("(Set|Get) Results which are either NotTested, StandBye, Running or IsNothing")>
        Public Property List_Nul() As List(Of TestItem)
            Get
                Return _List_Nul
            End Get
            Set(ByVal value As List(Of TestItem))
                If IsNothing(value) Then
                Else
                End If
                _List_Nul = value

            End Set
        End Property
#End Region
#End Region
#Region "TestItem| <00.04> <Property> [Records]"
#Region "TestItem| <00.04.00> <Property> <Records> [Count | Integer]"
        Private _Count As Integer
        ''' <summary>
        ''' (Set|Get) Count the number of results 
        ''' </summary>
        ''' <returns></returns>
        <CategoryAttribute("TestItem| Records"),
    Browsable(True),
    Description("(Set|Get) Count the number of results")>
        Public Property Count() As Integer
            Get
                Return _Count
            End Get
            Set(ByVal value As Integer)
                If IsNothing(value) Then
                Else
                    If value > 0 Then
                        Percentage_Fail = Math.Round((Count_Fail / Count) * 100, 2)
                        Percentage_Pass = Math.Round((Count_Pass / Count) * 100, 2)
                        Percentage_Nul = Math.Round((Count_Nul / Count) * 100, 2)
                        Percentage_Warning = Math.Round((Count_Warning / Count) * 100, 2)


                    End If
                End If
                _Count = value
            End Set
        End Property
#End Region
#Region "TestItem| <00.04.01> <Property> <Records> [Count_Pass | Integer]"
        Private _Count_Pass As Integer
        ''' <summary>
        ''' (Set|Get) Count the number of results successful
        ''' </summary>
        ''' <returns></returns>
        <CategoryAttribute("TestItem| Records"),
    Browsable(True),
    Description("(Set|Get) Count the number of results successful")>
        Public Property Count_Pass() As Integer
            Get
                Return _Count_Pass
            End Get
            Set(ByVal value As Integer)
                If IsNothing(value) Then
                Else
                End If
                Percentage_Pass = Math.Round((value / Count) * 100, 2)
                _Count_Pass = value
            End Set
        End Property
#End Region
#Region "TestItem| <00.04.02> <Property> <Records> [Count_Fail | Integer]"
        Private _Count_Fail As Integer
        ''' <summary>
        ''' (Set|Get) Count the number of results failed
        ''' </summary>
        ''' <returns></returns>
        <CategoryAttribute("TestItem| Records"),
    Browsable(True),
    Description("(Set|Get) Count the number of results failed")>
        Public Property Count_Fail() As Integer
            Get
                Return _Count_Fail
            End Get
            Set(ByVal value As Integer)
                If IsNothing(value) Then
                Else
                End If
                Percentage_Fail = Math.Round((value / Count) * 100, 2)
                _Count_Fail = value
            End Set
        End Property
#End Region
#Region "TestItem| <00.04.03> <Property> <Records> [Count_Warning | Integer]"
        Private _Count_Warning As Integer
        ''' <summary>
        ''' (Set|Get) Count the number of results with errors
        ''' </summary>
        ''' <returns></returns>
        <CategoryAttribute("TestItem| Records"),
    Browsable(True),
    Description("(Set|Get) Count the number of results with errors")>
        Public Property Count_Warning() As Integer
            Get
                Return _Count_Warning
            End Get
            Set(ByVal value As Integer)
                If IsNothing(value) Then
                Else
                End If
                Percentage_Warning = Math.Round((value / Count) * 100, 2)
                _Count_Warning = value
            End Set
        End Property
#End Region
#Region "TestItem| <00.04.04> <Property> <Records> [Count_Nul | Integer]"
        Private _Count_Nul As Integer
        ''' <summary>
        ''' (Set|Get) Count the number of results without results
        ''' </summary>
        ''' <returns></returns>
        <CategoryAttribute("TestItem| Records"),
    Browsable(True),
    Description("(Set|Get) Count the number of results without results")>
        Public Property Count_Nul() As Integer
            Get
                Return _Count_Nul
            End Get
            Set(ByVal value As Integer)
                If IsNothing(value) Then
                Else
                End If
                Percentage_Nul = Math.Round((value / Count) * 100, 2)
                _Count_Nul = value
            End Set
        End Property
#End Region
#End Region
#Region "TestItem| <00.05> <Property> [Percentage]"
#Region "TestItem| <00.05.00> <Property> <Percentage> [Percentage_Pass | Double]"
        Private _Percentage_Pass As Double
        ''' <summary>
        ''' (Set|Get) Percentage of Results Successful
        ''' </summary>
        ''' <returns></returns>
        <CategoryAttribute("TestItem| Percentage"),
    Browsable(True),
    Description("(Set|Get) Percentage of Results Successful")>
        Public Property Percentage_Pass() As Double
            Get
                Return _Percentage_Pass
            End Get
            Set(ByVal value As Double)
                If IsNothing(value) Then
                Else

                End If
                _Percentage_Pass = value
            End Set
        End Property
#End Region
#Region "TestItem| <00.05.01> <Property> <Percentage> [Percentage_Fail | Double]"
        Private _Percentage_Fail As Double
        ''' <summary>
        ''' (Set|Get) Percentage of Results Failed
        ''' </summary>
        ''' <returns></returns>
        <CategoryAttribute("TestItem| Percentage"),
    Browsable(True),
    Description("(Set|Get) Percentage of Results Failed")>
        Public Property Percentage_Fail() As Double
            Get
                Return _Percentage_Fail
            End Get
            Set(ByVal value As Double)
                If IsNothing(value) Then
                Else

                End If
                _Percentage_Fail = value
            End Set
        End Property
#End Region
#Region "TestItem| <00.05.02> <Property> <Percentage> [Percentage_Warning | Double]"
        Private _Percentage_Warning As Double
        ''' <summary>
        ''' (Set|Get) Percentage of Results Warning
        ''' </summary>
        ''' <returns></returns>
        <CategoryAttribute("TestItem| Percentage"),
    Browsable(True),
    Description("(Set|Get) Percentage of Results Warning")>
        Public Property Percentage_Warning() As Double
            Get
                Return _Percentage_Warning
            End Get
            Set(ByVal value As Double)
                If IsNothing(value) Then
                Else

                End If
                _Percentage_Warning = value
            End Set
        End Property
#End Region
#Region "TestItem| <00.05.03> <Property> <Percentage> [Percentage_Nul | Double]"
        Private _Percentage_Nul As Double
        ''' <summary>
        ''' (Set|Get) Percentage of Results no Results
        ''' </summary>
        ''' <returns></returns>
        <CategoryAttribute("TestItem| Percentage"),
    Browsable(True),
    Description("(Set|Get) Percentage of Results no Results")>
        Public Property Percentage_Nul() As Double
            Get
                Return _Percentage_Nul
            End Get
            Set(ByVal value As Double)
                If IsNothing(value) Then
                Else

                End If
                _Percentage_Nul = value
            End Set
        End Property
#End Region
#End Region
#End Region
#Region "TestItem| <3> [Subs]"
#Region "TestItem| <03.00> <Subs> [Add]"
#Region "TestItem| <03.00.00> <Subs> <Add> [Add(Element|TestItem,Ref|String)]"
        ''' <summary>
        ''' Insert a new Result into Results
        ''' </summary>
        ''' <param name="Element"></param>
        ''' <param name="Ref"></param>
        Public Sub Add(ByVal Element As TestItem, Optional ByVal Ref As String = "")
            If Ref = "" Then
                Ref = "Nul"
            End If

            If IsNothing(Element) Then
                AddEvent(Status.IsNothing, "Element is Nothing", "<03.00.00>", Element)
            Else
                ' AddEvent(Status.Finished, "Element is Nothing", "<03.00.00>", Element)
                ' Element.Prepare_Report()
                'HasReported = False
                If IsNothing(Results) Then
                    '    AddEvent(Status.IsNothing, "Results is Nothing", "<03.00.00>", Results)
                    Results = New List(Of TestItem)
                    '  AddEvent(Status.Finished, "Results has been restored", "<03.00.00>", Results)
                Else
                    '   AddEvent(Status.Online, "Results already exists", "<03.00.00>", Results)
                End If
                With Element
                    Try
                        .ParentTestItem = Me
                        'AddEvent(Status.Finished, "ParentTestItem has been attributed ", "<03.00.00>", .ParentTestItem)
                    Catch ex As Exception
                        AddEvent(Status.Broken, Format_Error(ex, Me.Name), "<03.00.00>|ParentTestItem")
                        AddBug(ex, Me.Name, Format_Error(ex, Me.Name))
                        'AddEvent(Status.Broken, "Impossible to attribute ParentTestItem " & vbNewLine & Element.Format_Error(ex, "TestItem| <03.00> <Subs> [Add(Element|Testitem,Ref|String)]"), "<03.00.00>", Me)
                    End Try
                    .ID = Count
                    If IsNothing(Element.Tag) Then
                        '  AddEvent(Status.IsNothing, "Element is Nothing", "<03.00.00>", Element.Tag)
                        Element.Tag = Element
                        .Tag = Element
                        'AddEvent(Status.Finished, "Element Tag has been restored", "<03.00.00>", Element.Tag)
                    Else
                        .Tag = Element.Tag
                        ' AddEvent(Status.Finished, "Element Tag has been set properly", "<03.00.00>", Element.Tag)
                    End If
                End With
                Count += 1
                Results.Add(Element)
                If Me.Name <> "ToolBoxDLL" Then
                    '   If My.Settings.Debug = True Then
                    '    ApplicationDLL.Add(Element)
                    '     ApplicationDLL.Write(StartRegion(Element.Name))
                    '    ApplicationDLL.Write(Element.Body)
                    '    ApplicationDLL.Write(EndRegion)
                End If


            End If
            Element.ImageIndex = Element.Status

            Element.ID = Me.ID & "." & Count

            'Adding the element
            If Element.Status = Status.Broken Then
                List_Fails.Add(Element)
                Count_Fail += 1
                Me.AddEvent(Element.Status, "     Adding to Fails <" & Element.Name & "> | <Status=" & StatusToString(Element.Status) & ">", Ref, Element)
                Me.AddHypothesis(Element.Name & " has Failed.", Element.Status, True)
            ElseIf Element.Status = Status.Finished Then
                List_Pass.Add(Element)
                Count_Pass += 1
                Me.AddEvent(Element.Status, "     Adding to Pass <" & Element.Name & "> | <Status=" & StatusToString(Element.Status) & ">", Ref, Element)
                Me.AddHypothesis(Element.Name & " has Pass.", Element.Status, True)

            ElseIf Element.Status = Status.IsNothing Then
                List_Nul.Add(Element)
                Count_Nul += 1
                Me.AddEvent(Element.Status, "     Adding to Nul <" & Element.Name & "> | <Status=" & StatusToString(Element.Status) & ">", Ref, Element)
                Me.AddHypothesis(Element.Name & " is Nul.", Element.Status, True)

            ElseIf Element.Status = Status.NotTested Then
                List_Nul.Add(Element)
                Count_Nul += 1
                Me.AddEvent(Element.Status, "     Adding to Nul <" & Element.Name & "> | <Status=" & StatusToString(Element.Status) & ">", Ref, Element)
                Me.AddHypothesis(Element.Name & " is Nul.", Element.Status, True)

            ElseIf Element.Status = Status.Offline Then
                List_Fails.Add(Element)
                Count_Fail += 1
                Me.AddEvent(Element.Status, "     Adding to Fail <" & Element.Name & "> | <Status=" & StatusToString(Element.Status) & ">", Ref, Element)
                Me.AddHypothesis(Element.Name & " has Failed.", Element.Status, True)

            ElseIf Element.Status = Status.Online Then
                List_Pass.Add(Element)
                Count_Pass += 1
                Me.AddEvent(Element.Status, "     Adding to Pass <" & Element.Name & "> | <Status=" & StatusToString(Element.Status) & ">", Ref, Element)
                Me.AddHypothesis(Element.Name & " has Pass.", Element.Status, True)

            ElseIf Element.Status = Status.Running Then
                List_Nul.Add(Element)
                Count_Nul += 1
                Me.AddEvent(Element.Status, "     Adding to Nul <" & Element.Name & "> | <Status=" & StatusToString(Element.Status) & ">", Ref, Element)
                Me.AddHypothesis(Element.Name & " is Nul.", Element.Status, True)

            ElseIf Element.Status = Status.StandBye Then
                List_Nul.Add(Element)
                Count_Nul += 1
                Me.AddEvent(Element.Status, "     Adding to Nul <" & Element.Name & "> | <Status=" & StatusToString(Element.Status) & ">", Ref, Element)
                Me.AddHypothesis(Element.Name & " is Nul.", Element.Status, True)

            End If
            'testing if element result is not nothing
            If IsNothing(Element.Results) Then
            Else
#Region "<Set 1> Sous Testitme de Element"
                For Each SousTest As TestItem In Element.Results

                    'Action
                    'Question Report it to me or to element? 
                    'Réponse vu, qu'il est déjà inscrit sous Results. il faut rient faire
                Next
#End Region


            End If

            Nod.Nodes.Add(Element.Nod.Clone)
            Node.Nodes.Add(Element.Node.DeepCopy)
            NodeG.Nodes.Add(Element.NodeG.DeepCopy)
            If Me.Name <> "ToolBoxDLL" Then
                '   ApplicationDLL.Nod.Nodes.Add(Element.Nod.Clone)
                '  ApplicationDLL.Node.Nodes.Add(Element.Node.DeepCopy)
                '  ApplicationDLL.NodeG.Nodes.Add(Element.NodeG.DeepCopy)
                'ApplicationDLL.AddEvent(Element.Status, Element.Name, Element.Ref, Element)
            End If

            If Count_Pass = Count Then
                Me.Status = Status.Finished
            Else
                If Percentage_Pass = 100 Or Percentage_Pass > 50 Then
                    Me.Status = Status.Online
                ElseIf Percentage_Pass < 50 Or Percentage_Pass > 35 Then
                    Me.Status = Status.Warning
                Else
                    Me.Status = Status.Broken
                End If
            End If


            'End If
            Me.Nod.ImageIndex = Me.Status
            Me.Node.ImageIndex = Me.Status
            Me.NodeG.ImageIndex = Me.Status
        End Sub
#End Region
#Region "TestItem| <03.00.01> <Subs> <Add> [AddEvent(status|Status,Command|String,Ref|String,[Tag]|Object)]"
        ''' <summary>
        ''' Add information of returns
        ''' </summary>
        ''' <param name="status"></param>
        ''' <param name="Command"></param>
        ''' <param name="Ref">Only Add Region Number</param>
        ''' <param name="_TagX">The value object analysed</param>
        Public Sub AddEvent(ByVal status As Status, ByVal Command As String, ByVal Ref As String, Optional ByVal _TagX As Object = Nothing, Optional ByVal ClassName As String = "")
            If IsNothing(Events) Then
                Events = New List(Of Evenement)
            End If

            If IsNothing(_TagX) Then
            Else
                If ClassName = "" Then
                    If TypeOf _TagX Is TestItem Then
                        Dim it As New Evenement(Events.Count, "< ClassName | " & Command & " >", status, _TagX.Hypothesis, Ref, Command, _TagX)
                        Events.Add(it)
                    Else
                        Dim it As New Evenement(Events.Count, "< ClassName | " & Command & " >", status, Me.Hypothesis, Ref, Command, _TagX)
                        Events.Add(it)
                    End If
                Else

                    If TypeOf _TagX Is TestItem Then
                        Dim it As New Evenement(Events.Count, "<" & ClassName & "| " & Command & " >", status, _TagX.Hypothesis, Ref, Command, _TagX)
                        Events.Add(it)
                    Else
                        Dim it As New Evenement(Events.Count, "<" & ClassName & "| " & Command & " >", status, Me.Hypothesis, Ref, Command, _TagX)
                        Events.Add(it)
                    End If
                End If
            End If

        End Sub
#End Region
#Region "TestItem| <03.00.02> <Subs> <Add> [AddHypothesis(Content|String,status|Status,IsResult|Boolean)]"
        ''' <summary>
        ''' Add information to Hypothesis 
        ''' </summary>
        ''' <param name="Content"></param>
        ''' <param name="status"></param>
        ''' <param name="IsResult"></param>
        Public Sub AddHypothesis(ByVal Content As String, ByVal status As Status, ByVal IsResult As Boolean)
            If IsResult = True Then
                Hypothesis += "Return     <" & FormatDateTime(Now) & ">|Status : " & StatusToString(status) & vbNewLine &
                              "           [" & Content & " ]" & vbNewLine & vbNewLine
            Else
                Hypothesis += "Test     <" & FormatDateTime(Now) & ">|Status : " & StatusToString(status) & vbNewLine &
                              "         [" & Content & " ]" & vbNewLine & vbNewLine
            End If

        End Sub
#End Region
#Region "TestItem| <03.00.03> <Subs> <Add> [AddBug(ex|Exception,Name|String,Ref|String)]"
        ''' <summary>
        ''' Add Exception non handled into bugs
        ''' </summary>
        ''' <param name="ex"></param>
        ''' <param name="Name"></param>
        ''' <param name="Ref"></param>
        Public Sub AddBug(ByVal ex As Exception, ByVal Name As String, ByVal Ref As String)
            If IsNothing(Bugs) Then
                Bugs = New List(Of Bug)
            End If
            Dim B As New Bug(ex, Name, Ref, Bugs.Count)
            ' ApplicationDLL.Bugs.Add(B)
            Bugs.Add(B)
        End Sub
#End Region
#Region "TestItem| <03.00.04> <Subs> <Add> [AddSteps]"
        ''' <summary>
        ''' Add Step into the Walkthrough
        ''' </summary>
        ''' <param name="ClassString"></param>
        ''' <param name="Description"></param>
        ''' <param name="Status"></param>
        ''' <param name="Ref"></param>
        ''' <param name="Name"></param>
        ''' <param name="Result"></param>
        Public Sub AddStep(ByVal ClassString As String,
                           ByVal Description As String,
                           ByVal Status As Status,
                           ByVal Ref As String,
                           ByVal Name As String,
                           ByVal Result As String)
            If IsNothing(Walkthrough) Then
                Walkthrough = New List(Of Steps)
            End If
            Dim iSuivi As New Steps(Walkthrough.Count, Name, Status, ClassString, Ref, Description, Result)
            ' ApplicationDLL.Walkthrough.Add(iSuivi)
            Walkthrough.Add(iSuivi)
        End Sub
#End Region
#Region "TestItem| <03.00.05> <Subs> <Add> [AddParam(ObjectName|String,_Object|Object,_Value|Object)]"
        Public Sub AddParam(ByVal ObjectName As String, ByVal _Object As Object, ByVal _Value As Object, Optional ByVal AddToResult As Boolean = False)
            If IsNothing(Me.InputParams) Then
                InputParams = New List(Of Input_Parameters)
            End If
            If IsNothing(Results) Then
                Results = New List(Of TestItem)
            End If
            Dim P As New Input_Parameters(Analyse_Nothing(ObjectName), Analyse_Nothing(_Object), Analyse_Nothing(_Value))
            InputParams.Add(P)
            If IsNothing(Me.Input) Then
                '   Me.Input = P.Log
            End If
            If AddToResult = True Then
                '  If IsNothing(P.Log) Then
            Else
                '        Results.Add(P.Log)

            End If
            'End If
            Me.InputString += "Paramètre : Name=[" & P.Name & "]  Value=[" & P.Value & "] " & vbNewLine
            If Me.Name <> "ToolBoxDLL" Then
                'ApplicationDLL.InputParams.Add(P)
                ' ApplicationDLL.InputString += "Paramètre : Name=[" & P.Name & "]  Value=[" & P.Value & "] " & vbNewLine
            End If
        End Sub

#End Region
#Region "TestItem| <03.00.06> <Subs> <Add> [AddOutputParam(ObjectName|String,_Object|Object,_Value|Object)]"
        Public Sub AddOutputParam(ByVal ObjectName As String, ByVal _Object As Object, ByVal _Value As Object)
            If IsNothing(Me.OutputParams) Then
                OutputParams = New List(Of Input_Parameters)
            End If
            Dim P As New Input_Parameters(ObjectName, _Object, _Value)
            OutputParams.Add(P)
            If IsNothing(Me.Input) Then
                'Me.Input = P.Log
            End If
            Me.OutputString += "Paramètre : Name=[" & P.Name & "]  Value=[" & P.Value & "] " & vbNewLine
            If Me.Name <> "ToolBoxDLL" Then
                ' If IsNothing(ApplicationDLL.OutputParams) Then
                '  ApplicationDLL.OutputParams = New List(Of Input_Parameters)
            End If
            '  ApplicationDLL.OutputParams.Add(P)
            'ApplicationDLL.OutputString += "Paramètre : Name=[" & P.Name & "]  Value=[" & P.ParameterValue & "] " & vbNewLine
            'End If
        End Sub

#End Region

#End Region
#Region "TestItem| <03.01> <Subs> [Report]"
#Region "TestItem| <03.00.01> <Subs> <Report> [Report([ShortbyResultType]|Boolean=True]"
        ''' <summary>
        ''' This Functions prepare the testitem for displaying the results
        ''' </summary>
        ''' <param name="ShortbyResultType"></param>
        Public Sub Report(Optional ByVal ShortbyResultType As Boolean = False)
            '  If HasReported = True Then
            '   Else
            'HasReported = True
            If IsNothing(Me.Nod) Then
                Me.Nod = New TreeNode
                With Me.Nod
                    .Text = Me.Name
                    .ToolTipText = Me.Body
                    .Tag = Me
                End With
            End If
            If Me.Nod.Nodes.Count - 1 > 0 Then
                Me.Nod.Nodes.Clear()
            End If

            If IsNothing(Me.Node) Then
                Me.Node = New DevComponents.AdvTree.Node
                With Node
                    .Text = Me.Name
                    If ToolTip = Nothing Then
                        .Tooltip = Hypothesis
                    Else
                        .Tooltip = ToolTip
                    End If
                End With
            End If
            If Node.Nodes.Count - 1 > 0 Then
                Node.Nodes.Clear()
            End If

            If IsNothing(Me.Item) Then
                Me.Item = New ListViewItem
                With Item
                    .Text = Me.Name
                    .ToolTipText = Me.ToolTip
                    .ImageIndex = Me.Status
                    .Tag = Me
                End With
            End If

            Dim iPass As New TreeNode
            With iPass
                .Text = "Results Successful"
                .ImageIndex = Status.Online
                If IsNothing(List_Pass) Then
                Else
                    .Tag = List_Pass
                End If
                .ToolTipText = "Number of results = " & Count_Pass & " Percentage : " & Percentage_Pass & " %"
            End With
            Dim iPassX As New DevComponents.AdvTree.Node
            With iPassX
                .Text = "Results Successful"
                .ImageIndex = Status.Online
                If IsNothing(List_Pass) Then
                Else
                    .Tag = List_Pass
                End If
                .Tooltip = "Number of results = " & Count_Pass & " Percentage : " & Percentage_Pass & " %"
            End With

            Dim iFail As New TreeNode
            With iFail
                .Text = "Results Fail"
                .ImageIndex = Status.Offline
                If IsNothing(List_Fails) Then
                Else
                    .Tag = List_Fails
                End If
                .ToolTipText = "Number of results = " & Count_Fail & " Percentage : " & Percentage_Fail & " %"
            End With
            Dim iFailX As New DevComponents.AdvTree.Node
            With iFailX
                .Text = "Results Fail"
                .ImageIndex = Status.Offline

                If IsNothing(List_Fails) Then
                Else
                    .Tag = List_Fails
                End If
                .Tooltip = "Number of results = " & Count_Fail & " Percentage : " & Percentage_Fail & " %"
            End With

            Dim iWarning As New TreeNode
            With iWarning
                .Text = "Results Warning"
                .ImageIndex = Status.Warning

                If IsNothing(List_Warning) Then
                Else
                    .Tag = List_Warning
                End If
                .ToolTipText = "Number of results = " & Count_Warning & " Percentage : " & Percentage_Warning & " %"
            End With
            Dim iWarningX As New DevComponents.AdvTree.Node
            With iWarningX
                .Text = "Results Warning"
                .ImageIndex = Status.Warning

                If IsNothing(List_Warning) Then
                Else
                    .Tag = List_Warning
                End If
                .Tooltip = "Number of results = " & Count_Warning & " Percentage : " & Percentage_Warning & " %"
            End With

            Dim iNul As New TreeNode
            With iNul
                .Text = "Results Nul"
                .ImageIndex = Status.IsNothing

                If IsNothing(List_Nul) Then
                Else
                    .Tag = List_Nul
                End If
                .ToolTipText = "Number of results = " & Count_Nul & " Percentage : " & Percentage_Nul & " %"
            End With
            Dim iNulX As New DevComponents.AdvTree.Node
            With iNulX
                .Text = "Results Nul"
                .ImageIndex = Status.IsNothing

                If IsNothing(List_Nul) Then
                Else
                    .Tag = List_Nul
                End If
                .Tooltip = "Number of results = " & Count_Nul & " Percentage : " & Percentage_Nul & " %"
            End With

            Dim iResultat As New TreeNode
            With iResultat
                .Text = "Results of " & Me.Name
                .Tag = Me
            End With
            Dim iResultatX As New DevComponents.AdvTree.Node
            With iResultatX
                .Text = "Results of " & Me.Name
                .Tag = Me
            End With

            If IsNothing(Results) Then
                Me.Status = Status.Finished
                Dim NodeX As New DevComponents.AdvTree.Node
                With NodeX
                    .Text = Me.Text
                    .Tooltip = Me.Body
                    .Tag = Me
                    .TagString = StatusToString(Me.Status)
                    .ImageIndex = Me.Status
                End With
                Dim NodX As New TreeNode
                With NodX
                    .Text = Me.Text
                    .ToolTipText = Me.Body
                    .Tag = Me
                    .ImageIndex = Me.Status
                End With
                iResultatX.Nodes.Add(NodeX)
                iResultat.Nodes.Add(NodX)
            Else
                If Results.Count - 1 < 0 Then
                    Me.Status = Status.Finished
                    Dim NodeX As New DevComponents.AdvTree.Node
                    With NodeX
                        .Text = Me.Text
                        .Tooltip = Me.Body
                        .Tag = Me
                        .TagString = StatusToString(Me.Status)
                        .ImageIndex = Me.Status
                    End With
                    Dim NodX As New TreeNode
                    With NodX
                        .Text = Me.Text
                        .ToolTipText = Me.Body
                        .Tag = Me
                        .ImageIndex = Me.Status
                    End With
                    iResultatX.Nodes.Add(NodeX)
                    iResultat.Nodes.Add(NodX)
                Else



                    For i = 0 To Results.Count - 1
                        Results(i).Report()
                        Results(i).Prepare_Report()

                        If Results(i).Status = Status.Broken Then
                            With Results(i).Node
                                .Name = Results(i).Name
                                .Text = Results(i).Text
                                .Tooltip = Results(i).ToolTip
                                .ImageIndex = Status.Broken
                                .Tag = Results(i)
                            End With
                            With Results(i).Nod
                                .Name = Results(i).Name
                                .Text = Results(i).Text
                                .ToolTipText = Results(i).ToolTip
                                .ImageIndex = Status.Broken
                                .Tag = Results(i)
                            End With
                            With Results(i).NodeG
                                .Name = Results(i).Name
                                .Text = Results(i).Text
                                .TagString = Results(i).ToolTip
                                .ImageIndex = Status.Broken
                                .Tag = Results(i)
                            End With
                            If ShortbyResultType = True Then
                                iFailX.Nodes.Add(Results(i).Node.DeepCopy)
                                iFail.Nodes.Add(Results(i).Nod.Clone)
                                'iFailG.Nodes.Add(Results(i).NodeG.DeepCopy)

                            Else
                                ' iResultatX.Nodes.Add(Results(i).Node.DeepCopy)
                                'iResultat.Nodes.Add(Results(i).Nod.Clone)
                                'iResultatG.Nodes.Add(Results(i).NodeG.DeepCopy)
                                Me.Nod.Nodes.Add(Results(i).Nod.Clone)
                                Me.Node.Nodes.Add(Results(i).Node.DeepCopy)
                                Me.NodeG.Nodes.Add(Results(i).NodeG.DeepCopy)
                            End If
                        ElseIf Results(i).Status = Status.Finished Then
                            With Results(i).Node
                                .Name = Results(i).Name
                                .Text = Results(i).Text
                                .Tooltip = Results(i).ToolTip
                                .ImageIndex = Status.Finished
                                .Tag = Results(i)
                            End With
                            With Results(i).Nod
                                .Name = Results(i).Name
                                .Text = Results(i).Text
                                .ToolTipText = Results(i).ToolTip
                                .ImageIndex = Status.Finished
                                .Tag = Results(i)
                            End With
                            With Results(i).NodeG
                                .Name = Results(i).Name
                                .Text = Results(i).Text
                                .TagString = Results(i).ToolTip
                                .ImageIndex = Status.Finished
                                .Tag = Results(i)
                            End With
                            If ShortbyResultType = True Then
                                iPassX.Nodes.Add(Results(i).Node.DeepCopy)
                                iPass.Nodes.Add(Results(i).Nod.Clone)
                                'iPassG.Nodes.Add(Results(i).NodeG.DeepCopy)

                            Else
                                ' iResultatX.Nodes.Add(Results(i).Node.DeepCopy)
                                'iResultat.Nodes.Add(Results(i).Nod.Clone)
                                'iResultatG.Nodes.Add(Results(i).NodeG.DeepCopy)
                                Me.Nod.Nodes.Add(Results(i).Nod.Clone)
                                Me.Node.Nodes.Add(Results(i).Node.DeepCopy)
                                Me.NodeG.Nodes.Add(Results(i).NodeG.DeepCopy)

                            End If
                        ElseIf Results(i).Status = Status.IsNothing Then
                            With Results(i).Node
                                .Name = Results(i).Name
                                .Text = Results(i).Text
                                .Tooltip = Results(i).ToolTip
                                .ImageIndex = Status.IsNothing
                                .Tag = Results(i)
                            End With
                            With Results(i).Nod
                                .Name = Results(i).Name
                                .Text = Results(i).Text
                                .ToolTipText = Results(i).ToolTip
                                .ImageIndex = Status.IsNothing
                                .Tag = Results(i)
                            End With
                            With Results(i).NodeG
                                .Name = Results(i).Name
                                .Text = Results(i).Text
                                .TagString = Results(i).ToolTip
                                .ImageIndex = Status.IsNothing
                                .Tag = Results(i)
                            End With
                            If ShortbyResultType = True Then
                                iNulX.Nodes.Add(Results(i).Node.DeepCopy)
                                iNul.Nodes.Add(Results(i).Nod.Clone)
                                'iNulG.Nodes.Add(Results(i).NodeG.DeepCopy)
                            Else
                                ' iResultatX.Nodes.Add(Results(i).Node.DeepCopy)
                                'iResultat.Nodes.Add(Results(i).Nod.Clone)
                                'iResultatG.Nodes.Add(Results(i).NodeG.DeepCopy)
                                Me.Nod.Nodes.Add(Results(i).Nod.Clone)
                                Me.Node.Nodes.Add(Results(i).Node.DeepCopy)
                                Me.NodeG.Nodes.Add(Results(i).NodeG.DeepCopy)
                            End If
                        ElseIf Results(i).Status = Status.NotTested Then
                            With Results(i).Node
                                .Name = Results(i).Name
                                .Text = Results(i).Text
                                .Tooltip = Results(i).ToolTip
                                .ImageIndex = Status.NotTested
                                .Tag = Results(i)
                            End With
                            With Results(i).Nod
                                .Name = Results(i).Name
                                .Text = Results(i).Text
                                .ToolTipText = Results(i).ToolTip
                                .ImageIndex = Status.NotTested
                                .Tag = Results(i)
                            End With
                            With Results(i).NodeG
                                .Name = Results(i).Name
                                .Text = Results(i).Text
                                .TagString = Results(i).ToolTip
                                .ImageIndex = Status.NotTested
                                .Tag = Results(i)
                            End With

                            If ShortbyResultType = True Then
                                iNulX.Nodes.Add(Results(i).Node.DeepCopy)
                                iNul.Nodes.Add(Results(i).Nod.Clone)
                                'iNulG.Nodes.Add(Results(i).NodeG.DeepCopy)
                            Else
                                ' iResultatX.Nodes.Add(Results(i).Node.DeepCopy)
                                'iResultat.Nodes.Add(Results(i).Nod.Clone)
                                'iResultatG.Nodes.Add(Results(i).NodeG.DeepCopy)
                                Me.Nod.Nodes.Add(Results(i).Nod.Clone)
                                Me.Node.Nodes.Add(Results(i).Node.DeepCopy)
                                Me.NodeG.Nodes.Add(Results(i).NodeG.DeepCopy)
                            End If
                        ElseIf Results(i).Status = Status.Offline Then
                            With Results(i).Node
                                .Name = Results(i).Name
                                .Text = Results(i).Text
                                .Tooltip = Results(i).ToolTip
                                .ImageIndex = Status.Offline
                                .Tag = Results(i)
                            End With
                            With Results(i).Nod
                                .Name = Results(i).Name
                                .Text = Results(i).Text
                                .ToolTipText = Results(i).ToolTip
                                .ImageIndex = Status.Offline
                                .Tag = Results(i)
                            End With
                            With Results(i).NodeG
                                .Name = Results(i).Name
                                .Text = Results(i).Text
                                .TagString = Results(i).ToolTip
                                .ImageIndex = Status.Offline
                                .Tag = Results(i)
                            End With

                            If ShortbyResultType = True Then
                                iFailX.Nodes.Add(Results(i).Node.DeepCopy)
                                iFail.Nodes.Add(Results(i).Nod.Clone)
                                'iFailG.Nodes.Add(Results(i).NodeG.DeepCopy)
                            Else
                                ' iResultatX.Nodes.Add(Results(i).Node.DeepCopy)
                                'iResultat.Nodes.Add(Results(i).Nod.Clone)
                                'iResultatG.Nodes.Add(Results(i).NodeG.DeepCopy)
                                Me.Nod.Nodes.Add(Results(i).Nod.Clone)
                                Me.Node.Nodes.Add(Results(i).Node.DeepCopy)
                                Me.NodeG.Nodes.Add(Results(i).NodeG.DeepCopy)
                            End If
                        ElseIf Results(i).Status = Status.Online Then
                            With Results(i).Node
                                .Name = Results(i).Name
                                .Text = Results(i).Text
                                .Tooltip = Results(i).ToolTip
                                .ImageIndex = Status.Online
                                .Tag = Results(i)
                            End With
                            With Results(i).Nod
                                .Name = Results(i).Name
                                .Text = Results(i).Text
                                .ToolTipText = Results(i).ToolTip
                                .ImageIndex = Status.Online
                                .Tag = Results(i)
                            End With
                            With Results(i).NodeG
                                .Name = Results(i).Name
                                .Text = Results(i).Text
                                .TagString = Results(i).ToolTip
                                .ImageIndex = Status.Online
                                .Tag = Results(i)
                            End With
                            If ShortbyResultType = True Then
                                iPassX.Nodes.Add(Results(i).Node.DeepCopy)
                                iPass.Nodes.Add(Results(i).Nod.Clone)
                                'iPassG.Nodes.Add(Results(i).NodeG.DeepCopy)
                            Else
                                ' iResultatX.Nodes.Add(Results(i).Node.DeepCopy)
                                'iResultat.Nodes.Add(Results(i).Nod.Clone)
                                'iResultatG.Nodes.Add(Results(i).NodeG.DeepCopy)
                                Me.Nod.Nodes.Add(Results(i).Nod.Clone)
                                Me.Node.Nodes.Add(Results(i).Node.DeepCopy)
                                Me.NodeG.Nodes.Add(Results(i).NodeG.DeepCopy)
                            End If
                        ElseIf Results(i).Status = Status.Running Then
                            With Results(i).Node
                                .Name = Results(i).Name
                                .Text = Results(i).Text
                                .Tooltip = Results(i).ToolTip
                                .ImageIndex = Status.Running
                                .Tag = Results(i)
                            End With
                            With Results(i).Nod
                                .Name = Results(i).Name
                                .Text = Results(i).Text
                                .ToolTipText = Results(i).ToolTip
                                .ImageIndex = Status.Running
                                .Tag = Results(i)
                            End With
                            With Results(i).NodeG
                                .Name = Results(i).Name
                                .Text = Results(i).Text
                                .TagString = Results(i).ToolTip
                                .ImageIndex = Status.Running
                                .Tag = Results(i)
                            End With

                            If ShortbyResultType = True Then
                                iNulX.Nodes.Add(Results(i).Node.DeepCopy)
                                iNul.Nodes.Add(Results(i).Nod.Clone)
                                ''iNulG.Nodes.Add(Results(i).NodeG.DeepCopy)
                            Else
                                ' iResultatX.Nodes.Add(Results(i).Node.DeepCopy)
                                'iResultat.Nodes.Add(Results(i).Nod.Clone)
                                'iResultatG.Nodes.Add(Results(i).NodeG.DeepCopy)
                                Me.Nod.Nodes.Add(Results(i).Nod.Clone)
                                Me.Node.Nodes.Add(Results(i).Node.DeepCopy)
                                Me.NodeG.Nodes.Add(Results(i).NodeG.DeepCopy)
                            End If
                        ElseIf Results(i).Status = Status.StandBye Then
                            With Results(i).Node
                                .Name = Results(i).Name
                                .Text = Results(i).Text
                                .Tooltip = Results(i).ToolTip
                                .ImageIndex = Status.StandBye
                                .Tag = Results(i)
                            End With
                            With Results(i).Nod
                                .Name = Results(i).Name
                                .Text = Results(i).Text
                                .ToolTipText = Results(i).ToolTip
                                .ImageIndex = Status.StandBye
                                .Tag = Results(i)
                            End With
                            With Results(i).NodeG
                                .Name = Results(i).Name
                                .Text = Results(i).Text
                                .TagString = Results(i).ToolTip
                                .ImageIndex = Status.StandBye
                                .Tag = Results(i)
                            End With

                            If ShortbyResultType = True Then
                                iNulX.Nodes.Add(Results(i).Node.DeepCopy)
                                iNul.Nodes.Add(Results(i).Nod.Clone)
                                'iNulG.Nodes.Add(Results(i).NodeG.DeepCopy)
                            Else
                                ' iResultatX.Nodes.Add(Results(i).Node.DeepCopy)
                                'iResultat.Nodes.Add(Results(i).Nod.Clone)
                                'iResultatG.Nodes.Add(Results(i).NodeG.DeepCopy)
                                Me.Nod.Nodes.Add(Results(i).Nod.Clone)
                                Me.Node.Nodes.Add(Results(i).Node.DeepCopy)
                                Me.NodeG.Nodes.Add(Results(i).NodeG.DeepCopy)
                            End If
                        ElseIf Results(i).Status = Status.Warning Then
                            With Results(i).Node
                                .Name = Results(i).Name
                                .Text = Results(i).Text
                                .Tooltip = Results(i).ToolTip
                                .ImageIndex = Status.Warning
                                .Tag = Results(i)
                            End With
                            With Results(i).Nod
                                .Name = Results(i).Name
                                .Text = Results(i).Text
                                .ToolTipText = Results(i).ToolTip
                                .ImageIndex = Status.Warning
                                .Tag = Results(i)
                            End With
                            With Results(i).NodeG
                                .Name = Results(i).Name
                                .Text = Results(i).Text
                                .TagString = Results(i).ToolTip
                                .ImageIndex = Status.Warning
                                .Tag = Results(i)
                            End With

                            If ShortbyResultType = True Then
                                iWarningX.Nodes.Add(Results(i).Node.DeepCopy)
                                iWarning.Nodes.Add(Results(i).Nod.Clone)
                                'iWarningG.Nodes.Add(Results(i).NodeG.DeepCopy)

                            Else
                                ' iResultatX.Nodes.Add(Results(i).Node.DeepCopy)
                                'iResultat.Nodes.Add(Results(i).Nod.Clone)
                                'iResultatG.Nodes.Add(Results(i).NodeG.DeepCopy)
                                Me.Nod.Nodes.Add(Results(i).Nod.Clone)
                                Me.Node.Nodes.Add(Results(i).Node.DeepCopy)
                                Me.NodeG.Nodes.Add(Results(i).NodeG.DeepCopy)
                            End If
                        End If

                    Next
                End If
            End If
            If ShortbyResultType = True Then
                '     If iPassX.Nodes.Count - 1 > 0 Then
                iResultatX.Nodes.Add(iPassX.DeepCopy)
                '    End If
                '   If iPass.Nodes.Count - 1 > 0 Then
                iResultat.Nodes.Add(iPass)
                '  End If

                'If iFailX.Nodes.Count - 1 > 0 Then
                iResultatX.Nodes.Add(iFailX.DeepCopy)
                'End If
                'If iFail.Nodes.Count - 1 > 0 Then
                iResultat.Nodes.Add(iFail)
                ' End If
                'If iWarningX.Nodes.Count - 1 > 0 Then
                iResultatX.Nodes.Add(iWarningX.DeepCopy)
                'End If
                'If iWarning.Nodes.Count - 1 > 0 Then
                iResultat.Nodes.Add(iWarning)
                'End If
                'If iNulX.Nodes.Count - 1 > 0 Then
                iResultatX.Nodes.Add(iNulX.DeepCopy)
                'End If
                'If iNul.Nodes.Count - 1 > 0 Then
                iResultat.Nodes.Add(iNul)
                'End If
                Me.Nod.Nodes.Add(iResultat)
                Me.Node.Nodes.Add(iResultatX)
                '    Me.NodeG.Nodes.Add(iResultatG)
            End If
            ToolTip = Body


            'End If
            ' Record("Preparing for report", "<03.00.01>", Status.Finished)
            Prepare_Report()
        End Sub
#End Region
#Region "TestItem| <03.00.02> <Subs> <Report> [Prepare_Report()]"
        ''' <summary>
        ''' Collect information to write in the body.
        ''' </summary>
        Public Sub Prepare_Report()
            '  If Is_LogReady = True Then
            'Else
            '     Is_LogReady = True
            Write(StartRegion("Prepare_Report" & "TestItem|<03.00.02> " & Me.Hypothesis))

            Write("  Nom du rapport : " & Me.Name)
            Write("  Hypothèse      : " & Me.Hypothesis)
            Write("  Status         : " & StatusToString(Me.Status))
            Write("  Why            : " & Me.Why)
            Write("  Objet Analysé  : " & If(IsNothing(Input), "Indéfini", Input.ToString))

            ' Write(DrawLine)
            Write(StartRegion("<Résumer> "))
            Write("  Nombre de Tests    : " & Me.Count)
            Write("  Résultat réussi    : " & Me.Count_Pass & "     | Avec ( " & Me.Percentage_Pass & " %)")
            Write("  Résultat échec     : " & Me.Count_Fail & "     | Avec ( " & Me.Percentage_Fail & " %)")
            Write("  Résultat nul       : " & Me.Count_Nul & "      | Avec ( " & Me.Percentage_Nul & " %)")
            Write("  Résultat anomalies : " & Me.Count_Warning & "  | Avec ( " & Me.Percentage_Warning & " %)")
            ' Write(DrawPointedLine)
            Write("  Nombres d'exceptions collectées : " & Me.Bugs.Count)
            Write("  Nombres d'évènements collectés  : " & Me.Events.Count)
            Write("  Nombres d'étapes                : " & Me.Walkthrough.Count)
            ' Write(DrawPointedLine)
            Write(EndRegion)
            Write(EndRegion)

            'End If

        End Sub
#End Region
#Region "TestItem| <03.00.03> <Subs> <Report> [Prepare_ReportFull()] Not Finished"
        ''' <summary>
        ''' Collect information to write in the body.
        ''' </summary>
        Public Function Prepare_ReportFull() As String
            Dim Email_Content As String = ""
            Email_Content += (StartRegion(Me.Hypothesis, "TestItem|<03.00.03>", "Préparation du rapport complet")) & vbNewLine

            Email_Content += ("  Nom du rapport : " & Me.Name) & vbNewLine
            Email_Content += ("  Hypothèse      : " & Me.Hypothesis) & vbNewLine
            Email_Content += ("  Status         : " & StatusToString(Me.Status)) & vbNewLine
            Email_Content += ("  Why            : " & Me.Why) & vbNewLine
            ' Email_Content += ("  Objet Analysé  : " & If(IsNothing(Object_Analysed), "Indéfini", Object_Analysed.ToString)) & vbNewLine


            Email_Content += (StartRegion("<Résumer> ")) & vbNewLine
            Email_Content += ("  Nombre de Tests    : " & Me.Count) & vbNewLine
            Email_Content += ("  Résultat réussi    : " & Me.Count_Pass & "  | Avec ( " & Me.Percentage_Pass & " %)") & vbNewLine
            Email_Content += ("  Résultat échec     : " & Me.Count_Pass & "  | Avec ( " & Me.Percentage_Pass & " %)") & vbNewLine
            Email_Content += ("  Résultat nul       : " & Me.Count_Pass & "  | Avec ( " & Me.Percentage_Pass & " %)") & vbNewLine
            Email_Content += ("  Résultat anomalies : " & Me.Count_Pass & "  | Avec ( " & Me.Percentage_Pass & " %)") & vbNewLine
            Email_Content += ("  Nombres d'exceptions collectées : " & Me.Bugs.Count - 1) & vbNewLine
            Email_Content += ("  Nombres d'évènements collectés  : " & Me.Events.Count - 1) & vbNewLine
            Email_Content += ("  Nombres d'étapes                : " & Me.Walkthrough.Count - 1) & vbNewLine
            Email_Content += (EndRegion) & vbNewLine

#Region "<Analyses>"
            Email_Content += (StartRegion("<Analyses>")) & vbNewLine
            If Walkthrough.Count - 1 >= 0 Then
#Region "Analyses| <Walkthrough>"
                Email_Content += (StartRegion("Analyses| <Walkthrough>")) & vbNewLine
                For i = 0 To Walkthrough.Count - 1
#Region "Analyses| <Walkthrough>"
                    Email_Content += (StartRegion("Analyses| <Walkthrough> <(" & i & ") sur " & Walkthrough.Count - 1 & "> " & Walkthrough(i).Name)) & vbNewLine
                    Email_Content += (Walkthrough(i).Text) & vbNewLine
                    Email_Content += (EndRegion) & vbNewLine
#End Region

                Next
                Email_Content += (EndRegion) & vbNewLine
#End Region
            End If

            If Events.Count - 1 >= 0 Then
#Region "Analyses| <Events>"
                Email_Content += (StartRegion("Analyses| <Events>")) & vbNewLine
                For i = 0 To Events.Count - 1
#Region "Analyses| <Events>"
                    Email_Content += (StartRegion("Analyses| <Events> <(" & i & ") sur " & Events.Count - 1 & "> " & Events(i).Name)) & vbNewLine
                    Email_Content += (Events(i).Print_ToString) & vbNewLine
                    Email_Content += (EndRegion) & vbNewLine

#End Region
                Next
                Email_Content += (EndRegion) & vbNewLine
#End Region
            End If
            If Bugs.Count - 1 >= 0 Then
#Region "Analyses| <Bugs>"
                Email_Content += (StartRegion("Analyses| <Bugs>")) & vbNewLine
                For i = 0 To Bugs.Count - 1
#Region "Analyses| <Bugs>"
                    Email_Content += (StartRegion("<Bugs> <(" & i & ") sur " & Bugs.Count - 1 & "> " & Bugs(i).Message)) & vbNewLine
                    '  Email_Content += (Bugs(i).Print_ToString) & vbNewLine
                    Email_Content += (EndRegion) & vbNewLine
#End Region
                Next
                Email_Content += (EndRegion) & vbNewLine
#End Region
            End If
            Email_Content += (EndRegion) & vbNewLine
#End Region

            Email_Content += (Hypothesis) & vbNewLine
            Email_Content += (Body) & vbNewLine


            Return Email_Content
        End Function
#End Region
        Public Sub Email_Saadry()
            '  If Email_View.SendReport(Prepare_ReportFull, "Rapport du test " & Me.Name & " From PC " & My.Computer.Name & " From User " & Environment.UserName) Then
            ' MsgBox("Email Envoyer")
            'End If

        End Sub
#Region "TestItem| <03.00.04> <Subs> <Report> [Display()]"
        Public Sub Display()
            '   Dim B As New iReport(Me)
            'B.TitleText = Me.Name
            ' B.Show()
        End Sub
#End Region
#End Region
#Region "TestItem| <03.02> <Subs> [Write]"
        Public Sub Write(ByVal Content As String)
            Body += Content & vbNewLine
            'LOG_NOTE += FormatDateTime(Now) & "  " & Content & vbNewLine
        End Sub
        Public Sub WriteToHypothesis(ByVal Content As String)
            Hypothesis += Content & vbNewLine
            'LOG_NOTE += FormatDateTime(Now) & "  " & Content & vbNewLine

        End Sub
#End Region
#End Region

#Region "<5> [Loader]"
#Region "<05.00> <Loader> [New]"
        Public Sub New()
            With Me
                .List_Fails = New List(Of TestItem)
                .List_Nul = New List(Of TestItem)
                .List_Pass = New List(Of TestItem)
                .List_Warning = New List(Of TestItem)
                .Walkthrough = New List(Of Steps)
                .Bugs = New List(Of Bug)
                .Events = New List(Of Evenement)
                .Nod = New TreeNode
                .Node = New DevComponents.AdvTree.Node
                .NodeG = New DevComponents.Tree.Node
                .Body = ""
                .DataSource = New List(Of Object)
                .Hypothesis = ""
                .ID = 0
                .InputParams = New List(Of Input_Parameters)
                .Item = New ListViewItem
                .OutputParams = New List(Of Input_Parameters)
                .Results = New List(Of TestItem)
                .Why = ""

            End With
        End Sub
#End Region
#Region "<05.01> <Loader> [Simple]"
        Public Sub New(ByVal Name As String,
                       ByVal Hypothesis As String)
            With Me

                .List_Fails = New List(Of TestItem)
                .List_Nul = New List(Of TestItem)
                .List_Pass = New List(Of TestItem)
                .List_Warning = New List(Of TestItem)
                .Walkthrough = New List(Of Steps)
                .Bugs = New List(Of Bug)
                .Events = New List(Of Evenement)
                .Nod = New TreeNode
                .Node = New DevComponents.AdvTree.Node
                .NodeG = New DevComponents.Tree.Node
                .Body = ""
                .DataSource = New List(Of Object)
                .Hypothesis = ""
                .ID = 0
                .InputParams = New List(Of Input_Parameters)
                .Item = New ListViewItem
                .OutputParams = New List(Of Input_Parameters)
                .Results = New List(Of TestItem)
                .Why = ""
                .Name = Name
                .Hypothesis = Hypothesis
            End With

        End Sub

#End Region
        Public Sub New(ByVal _Name As String,
                       ByVal _Hypothesis As String,
                       Optional ByVal _Status As Status = Status.Running,
                       Optional ByVal _Ref As String = "",
                       Optional ByVal _SelectedObject As Object = Nothing,
                       Optional ByVal ClassName As String = "")
            With Me
#Region "<Initialise>"

                .List_Fails = New List(Of TestItem)
                .List_Nul = New List(Of TestItem)
                .List_Pass = New List(Of TestItem)
                .List_Warning = New List(Of TestItem)
                .Walkthrough = New List(Of Steps)
                .Bugs = New List(Of Bug)
                .Events = New List(Of Evenement)
                .Nod = New TreeNode
                .Node = New DevComponents.AdvTree.Node
                .NodeG = New DevComponents.Tree.Node
                .Body = ""
                .DataSource = New List(Of Object)
                .Hypothesis = ""
                .ID = 0
                .InputParams = New List(Of Input_Parameters)
                .Item = New ListViewItem
                .OutputParams = New List(Of Input_Parameters)
                .Results = New List(Of TestItem)
                .Why = ""
#End Region
                ' .InputParams = New List(Of Input_Parameters)
                'peut-etre ici on peux ajouter le chargement de la liste des paramètres du test
                If IsNothing(_SelectedObject) Then

                End If
                '   .Class_Name = ClassName
                .Name = _Name
                .ID = 0
                .Status = Status.StandBye
                .Hypothesis = _Hypothesis & vbNewLine
                .Time = Now
                ' .Ref = _Ref
                .Text = _Name
                .Status = _Status
                .Count = 0
                .Count_Fail = 0
                .Count_Nul = 0
                .Count_Pass = 0
                .Count_Warning = 0
                If IsNothing(_SelectedObject) Then
                Else
                    .Input = _SelectedObject
                End If
            End With
            Write(StartRegion(Me.Hypothesis, _Name, _Ref))
#Region "<Prepare Language>"
            Dim Lng_0 As String = ""
            Dim Lng_1 As String = ""
            Dim Lng_2 As String = ""
            Dim Lng_3 As String = ""
            Dim Lng_4 As String = ""
            Dim Lng_5 As String = ""

            If ConvertLangue_ToInt(My.Settings.Langue) = Enum_Langue.Arabic Then
#Region "<Arabic>"
                Lng_0 = "تقرير اسم"
                Lng_1 = "فرضية"
                Lng_2 = "الحالة"
                Lng_3 = "لماذا ا"
                Lng_4 = "كائن محلل"
                Lng_5 = "نهاية الاختبار"

#End Region
            ElseIf ConvertLangue_ToInt(My.Settings.Langue) = Enum_Langue.English Then
#Region "<English>"
                Lng_0 = "Report name"
                Lng_1 = "Hypothesis"
                Lng_2 = "Status"
                Lng_3 = "Why"
                Lng_4 = "Analyzed Object"
                Lng_5 = "End of the test"

#End Region
            ElseIf ConvertLangue_ToInt(My.Settings.Langue) = Enum_Langue.Français Then
#Region "<Français>"
                Lng_0 = "Nom du rapport"
                Lng_1 = "Hypothèse"
                Lng_2 = "Statut"
                Lng_3 = "Pourquoi"
                Lng_4 = "Objet analysé"
                Lng_5 = "Fin du test"

#End Region
            ElseIf ConvertLangue_ToInt(My.Settings.Langue) = Enum_Langue.Italian Then
#Region "<Italian>"
                Lng_0 = "Segnala nome"
                Lng_1 = "Ipotesi"
                Lng_2 = "Stato"
                Lng_3 = "Perché"
                Lng_4 = "Oggetto analizzato"
                Lng_5 = "Fine del test"

#End Region
            ElseIf ConvertLangue_ToInt(My.Settings.Langue) = Enum_Langue.German Then
#Region "<German>"
                Lng_0 = "Berichtsname"
                Lng_1 = "Hypothese"
                Lng_2 = "Status"
                Lng_3 = "Warum"
                Lng_4 = "Analysiertes Objekt"
                Lng_5 = "Ende des Tests"

#End Region
            ElseIf ConvertLangue_ToInt(My.Settings.Langue) = Enum_Langue.Spanish Then
#Region "<Spanish>"
                Lng_0 = "Reportar nombre"
                Lng_1 = "Hipótesis"
                Lng_2 = "Estado"
                Lng_3 = "Por qué"
                Lng_4 = "Objeto analizado"
                Lng_5 = "Fin de la prueba"

#End Region
            ElseIf ConvertLangue_ToInt(My.Settings.Langue) = Enum_Langue.Hebrew Then
#Region "<Hebrew>"
                Lng_0 = "שם דוח"
                Lng_1 = "הַשׁעָרָה"
                Lng_2 = "סטָטוּס"
                Lng_3 = "למה"
                Lng_4 = "אובייקט נתח"
                Lng_5 = "סוף המבחן"

#End Region
            ElseIf ConvertLangue_ToInt(My.Settings.Langue) = Enum_Langue.Portuguese Then
#Region "<Portuguese>"
                Lng_0 = "Nome do relatório"
                Lng_1 = "Hipótese"
                Lng_2 = "Status"
                Lng_3 = "Por quê"
                Lng_4 = "Objeto analisado"
                Lng_5 = "Fim do teste"

#End Region
            ElseIf ConvertLangue_ToInt(My.Settings.Langue) = Enum_Langue.Russian Then
#Region "<Russian>"
                Lng_0 = "Название отчета"
                Lng_1 = "гипотеза"
                Lng_2 = "Положение дел"
                Lng_3 = "Зачем"
                Lng_4 = "Анализируемый объект"
                Lng_5 = "Конец испытания"

#End Region
            ElseIf ConvertLangue_ToInt(My.Settings.Langue) = Enum_Langue.Chinese Then
#Region "<Chinese>"
                Lng_0 = "報告名稱"
                Lng_1 = "假設"
                Lng_2 = "狀態"
                Lng_3 = "為什麼"
                Lng_4 = "分析對象"
                Lng_5 = "測試結束"

#End Region
            ElseIf ConvertLangue_ToInt(My.Settings.Langue) = Enum_Langue.Greek Then
#Region "<Greek>"
                Lng_0 = "Αναφορά ονόματος"
                Lng_1 = "Υπόθεση"
                Lng_2 = "Κατάσταση"
                Lng_3 = "Γιατί"
                Lng_4 = "Ανάλυση αντικειμένου"
                Lng_5 = "Τέλος της δοκιμής"

#End Region
            ElseIf ConvertLangue_ToInt(My.Settings.Langue) = Enum_Langue.Japanese Then
#Region "<Japanese>"
                Lng_0 = "レポート名"
                Lng_1 = "仮説"
                Lng_2 = "状態"
                Lng_3 = "なぜ"
                Lng_4 = "分析対象"
                Lng_5 = "テストの終了"

#End Region
            ElseIf ConvertLangue_ToInt(My.Settings.Langue) = Enum_Langue.Latin Then
#Region "<Latin>"
                Lng_0 = "Fama nominis"
                Lng_1 = "Hypothesi"
                Lng_2 = "Status"
                Lng_3 = "Quid"
                Lng_4 = "Lunaris examinetur Object"
                Lng_5 = "Ultimum test"

#End Region
            ElseIf ConvertLangue_ToInt(My.Settings.Langue) = Enum_Langue.Thai Then
#Region "<Thai>"
                Lng_0 = "ชื่อรายงาน"
                Lng_1 = "สมมติฐาน"
                Lng_2 = "สถานะ"
                Lng_3 = "ทำไม"
                Lng_4 = "วิเคราะห์วัตถุ"
                Lng_5 = "สิ้นสุดการทดสอบ"

#End Region
            ElseIf ConvertLangue_ToInt(My.Settings.Langue) = Enum_Langue.Turkish Then
#Region "<Turkish>"
                Lng_0 = "Rapor Adı"
                Lng_1 = "Hipotez"
                Lng_2 = "Durum"
                Lng_3 = "Niye ya"
                Lng_4 = "Analiz Edilen Nesne"
                Lng_5 = "Testin sonu"

#End Region
            End If
#End Region

            Write("  " & Lng_0 & " : " & Me.Name)
            Write("  " & Lng_1 & "  : " & Me.Hypothesis)
            Write("  " & Lng_2 & "  : " & StatusToString(Me.Status))
            Write("  " & Lng_3 & "  : " & Me.Why)
            Write("  " & Lng_4 & "  : " & If(IsNothing(Input), "Nothing", Input.ToString))

            ' Write(DrawLine)
            Write(EndRegion)
        End Sub
#End Region

        Public Class Bug
#Region "<Exception Information>"
            Private _Source As String
            Public Property Source() As String
                Get
                    Return _Source
                End Get
                Set(ByVal value As String)
                    _Source = value
                End Set
            End Property
            Private _Message As String
            Public Property Message() As String
                Get
                    Return _Message
                End Get
                Set(ByVal value As String)
                    _Message = value
                End Set
            End Property
            Private _HelpLink As String
            Public Property HelpLink() As String
                Get
                    Return _HelpLink
                End Get
                Set(ByVal value As String)
                    _HelpLink = value
                End Set
            End Property
            Private _StackTrace As String
            Public Property StackTrace() As String
                Get
                    Return _StackTrace
                End Get
                Set(ByVal value As String)
                    _StackTrace = value
                End Set
            End Property
            Private _TargetSite As String
            Public Property TargetSite() As String
                Get
                    Return _TargetSite
                End Get
                Set(ByVal value As String)
                    _TargetSite = value
                End Set
            End Property
            Private _SelectedException As Exception
            Public Property SelectedException() As Exception
                Get
                    Return _SelectedException
                End Get
                Set(ByVal value As Exception)
                    _SelectedException = value
                End Set
            End Property
#End Region
#Region "Bug| <00.00.00> <Property> <Info> [ID | Integer]"
            Private _ID As Integer
            ''' <summary>
            ''' (Set|Get) The ID of the Test
            ''' </summary>
            ''' <returns></returns>
            <CategoryAttribute("Bug| Info"),
    Browsable(True),
    Description("(Set|Get) The ID of the Test")>
            Public Property ID() As Integer
                Get
                    Return _ID
                End Get
                Set(ByVal value As Integer)
                    _ID = value
                End Set
            End Property
#End Region
#Region "Bug| <00.00.01> <Property> <Info> [Name | String]"
            Private _Name As String
            ''' <summary>
            ''' (Set|Get) The Name of the Test
            ''' </summary>
            ''' <returns></returns>
            <CategoryAttribute("Bug| Info"),
    Browsable(True),
    Description("(Set|Get) The Name of the Test")>
            Public Property Name() As String
                Get
                    Return _Name
                End Get
                Set(ByVal value As String)
                    _Name = value
                End Set
            End Property
#End Region
#Region "Bug| <00.00.03> <Property> <Info> [Time | DateTime]"
            Private _Time As DateTime
            ''' <summary>
            ''' (Set|Get) Define the Time
            ''' </summary>
            ''' <returns></returns>
            <CategoryAttribute("Bug| Info"),
    Browsable(True),
    Description("(Set|Get) Define the Time")>
            Public Property Time() As DateTime
                Get
                    Return _Time
                End Get
                Set(ByVal value As DateTime)
                    _Time = value
                End Set
            End Property
#End Region
#Region "Bug| <00.00.07> <Property> <Info> [Ref | String]"
            Private _Ref As String
            ''' <summary>
            ''' (Set|Get) Returns the code of the Region
            ''' </summary>
            ''' <returns></returns>
            <CategoryAttribute("Bug| Info"),
    Browsable(True),
    Description("(Set|Get) Returns the code of the Region")>
            Public Property Ref() As String
                Get
                    Return _Ref
                End Get
                Set(ByVal value As String)
                    _Ref = value
                End Set
            End Property
#End Region
            Public Sub New(ByVal ex As Exception,
                       ByVal _Name As String,
                       ByVal _Ref As String,
                       ByVal _ID As Integer)
                SelectedException = New Exception
                SelectedException = ex
                If IsNothing(ex.Source) = False Then
                    Source = ex.Source
                End If
                If IsNothing(ex.HelpLink) = False Then
                    HelpLink = ex.HelpLink
                End If
                If IsNothing(ex.StackTrace) = False Then
                    StackTrace = ex.StackTrace
                End If
                If IsNothing(ex.TargetSite) = False Then
                    TargetSite = ex.TargetSite.Name.ToString
                End If
                Message = ex.Message
                If _Name = "" Then
                    Me.Name = "Bug1"
                Else
                    Me.Name = _Name
                End If
                Ref = _Ref
                ID = _ID
                Time = Now
            End Sub

            Public Function Print_ToString() As String
                Dim Result As String = "#Region " & """" & "[Erreur " & ID & " ] " & Me.Name & " Ref " & Ref & " " & """" & vbNewLine
                Result += "      <Source> " & vbNewLine &
                     "          " & Source & vbNewLine &
                     "      </Source>" & vbNewLine &
                     "___________________________________________________________________________________________" & vbNewLine &
                     "      <Message> " & vbNewLine &
                     "          " & Message & vbNewLine &
                     "       </Message>" & vbNewLine &
                      "___________________________________________________________________________________________" & vbNewLine &
                     "      <TargetSite> " & vbNewLine &
                     "          " & TargetSite & vbNewLine &
                     "      </TargetSite>" & vbNewLine &
                      "___________________________________________________________________________________________" & vbNewLine &
                     "      <StackTrace> " & vbNewLine &
                     "          " & StackTrace & vbNewLine &
                     "      </StackTrace>" & vbNewLine &
                      "___________________________________________________________________________________________" & vbNewLine &
                     "      <HelpLink> " & vbNewLine &
                     "          " & HelpLink & vbNewLine &
                     "      </HelpLink>" & vbNewLine &
                      "___________________________________________________________________________________________" & vbNewLine &
                     "      <Source> " & vbNewLine &
                     "          " & Source & vbNewLine &
                     "      </Source>" & vbNewLine &
                     "___________________________________________________________________________________________" & vbNewLine
                Result += "#End Region" & vbNewLine
                Return Result
            End Function
        End Class



    End Class
#End Region
#Region "|08.01| <Class> [Suivi]"
    Public Class Suivi
#Region "Suivi| <00.00.00> <Property> <Info> [ID | Integer]"
        Private _ID As Integer
        ''' <summary>
        ''' (Set|Get) The ID of the Test
        ''' </summary>
        ''' <returns></returns>
        <CategoryAttribute("Suivi| Info"),
    Browsable(True),
    Description("(Set|Get) The ID of the Test")>
        Public Property ID() As Integer
            Get
                Return _ID
            End Get
            Set(ByVal value As Integer)
                _ID = value
            End Set
        End Property
#End Region
#Region "Suivi| <00.00.01> <Property> <Info> [Name | String]"
        Private _Name As String
        ''' <summary>
        ''' (Set|Get) The Name of the Test
        ''' </summary>
        ''' <returns></returns>
        <CategoryAttribute("Suivi| Info"),
    Browsable(True),
    Description("(Set|Get) The Name of the Test")>
        Public Property Name() As String
            Get
                Return _Name
            End Get
            Set(ByVal value As String)
                _Name = value
            End Set
        End Property
#End Region
#Region "Suivi| <00.00.03> <Property> <Info> [Time | DateTime]"
        Private _Time As DateTime
        ''' <summary>
        ''' (Set|Get) Define the Time
        ''' </summary>
        ''' <returns></returns>
        <CategoryAttribute("Suivi| Info"),
    Browsable(True),
    Description("(Set|Get) Define the Time")>
        Public Property Time() As DateTime
            Get
                Return _Time
            End Get
            Set(ByVal value As DateTime)
                _Time = value
            End Set
        End Property
#End Region
#Region "Suivi| <00.00.04> <Property> <Info> [Status | Status]"
        Private _Status As Status
        ''' <summary>
        ''' (Set|Get) The State of the Test
        ''' </summary>
        ''' <returns></returns>
        <CategoryAttribute("Suivi| Info"),
    Browsable(True),
    Description("(Set|Get) The State of the Test")>
        Public Property Status() As Status
            Get
                Return _Status
            End Get
            Set(ByVal value As Status)
                _Status = value
            End Set
        End Property
#End Region
#Region "Suivi| <00.00.05> <Property> <Info> [Description | String]"
        Private _Description As String
        ''' <summary>
        ''' (Set|Get) Returns the command Description
        ''' </summary>
        ''' <returns></returns>
        <CategoryAttribute("Suivi| Info"),
        Browsable(True),
        Description("(Set|Get) Returns the command Description")>
        Public Property Description() As String
            Get
                Return _Description
            End Get
            Set(ByVal value As String)

                _Description = value
            End Set
        End Property
#End Region
#Region "Suivi| <00.00.06> <Property> <Info> [ClassString | String]"
        Private _ClassString As String
        ''' <summary>
        ''' (Set|Get) Returns the ClassString
        ''' </summary>
        ''' <returns></returns>
        <CategoryAttribute("Suivi| Info"),
    Browsable(True),
    Description("(Set|Get) Returns the ClassString")>
        Public Property ClassString() As String
            Get
                Return _ClassString
            End Get
            Set(ByVal value As String)
                _ClassString = value
            End Set
        End Property
#End Region
#Region "Suivi| <00.00.07> <Property> <Info> [Ref | String]"
        Private _Ref As String
        ''' <summary>
        ''' (Set|Get) Returns the code of the Region
        ''' </summary>
        ''' <returns></returns>
        <CategoryAttribute("Suivi| Info"),
    Browsable(True),
    Description("(Set|Get) Returns the code of the Region")>
        Public Property Ref() As String
            Get
                Return _Ref
            End Get
            Set(ByVal value As String)
                _Ref = value
            End Set
        End Property
#End Region
#Region "Suivi| <00.00.08> <Property> <Info> [Resultat | String]"
        Private _Resultat As String
        ''' <summary>
        ''' (Set|Get) Returns the value
        ''' </summary>
        ''' <returns></returns>
        <CategoryAttribute("Suivi| Info"),
    Browsable(True),
    Description("(Set|Get) Returns the value")>
        Public Property Resultat() As String
            Get
                Return _Resultat
            End Get
            Set(ByVal value As String)
                _Resultat = value
            End Set
        End Property
#End Region
        Public Sub New(ByVal _ID As Integer,
                       ByVal _Name As String,
                       ByVal _Status As Status,
                       ByVal _ClassString As String,
                       ByVal _Ref As String,
                       ByVal _Description As String,
                       ByVal _Resultat As String)
            With Me
                .ID = _ID
                .Name = _Name
                .Status = _Status
                .ClassString = _ClassString
                .Ref = _Ref
                .Description = _Description
                .Time = Now
                .Resultat = _Resultat
            End With
        End Sub
        Public Function Print_ToString() As String
            Dim Result As String = "#Region " & """" & "[Suivi " & ID & " ] " & Me.Name & " Ref " & Ref & " " & """" & vbNewLine
            Result += "<ID>          " & "          " & ID & "      </ID>" & vbNewLine &
                      "<Name>        " & "          " & ID & "      </Name>" & vbNewLine &
                      "<Status>      " & "          " & StatusToString(Status) & "      </Status>" & vbNewLine &
                      "<ClassString> " & "          " & ClassString & "      </ClassString>" & vbNewLine &
                      "<Ref>         " & "          " & Ref & "      </Ref>" & vbNewLine &
                      "<Description> " & "          " & Description & "      </Description>" & vbNewLine &
                      "<Time>        " & "          " & FormatDateTime(Time) & "      </Time>" & vbNewLine &
                      "<Resultat>    " & "          " & Resultat & "      </Resultat>" & vbNewLine
            Result += "#End Region" & vbNewLine
            Return Result
        End Function
        Public Overrides Function ToString() As String
            Return MyBase.ToString()
        End Function

    End Class
#End Region
#Region "|08.02| <Class> [Input_Parameters]"
    Public Class Input_Parameters
#Region "<0> [Property]"
#Region "<00.00> <Property> [Info]"
#Region "[2019/03/24 14h44:390]<00.00.00> <Property> [Name|String]"
        Private _Name As String
        ''' <summary>
        ''' (Set|Get) The name of the parameter object.
        ''' </summary>
        ''' <returns></returns>
        ''' <author>Saadry Dunkel Consultant 24.03.2019 14:44</author>
        <CategoryAttribute("Info"),
       Description("(Set|Get) The name of the parameter object."),
       Browsable(True)>
        Public Property Name() As String
            Get
                Return _Name
            End Get
            Set(ByVal value As String)
                _Name = value
            End Set
        End Property
#End Region 'The name of the parameter object.
#Region "[2019/03/24 14h45:035]<00.00.01> <Property> [Type|String]"
        Private _Type As String
        ''' <summary>
        ''' (Set|Get) The type of the parameter object.
        ''' </summary>
        ''' <returns></returns>
        ''' <author>Saadry Dunkel Consultant 24.03.2019 14:45</author>
        <CategoryAttribute("Info"),
       Description("(Set|Get) The type of the parameter object."),
       Browsable(True)>
        Public Property Type() As String
            Get
                Return _Type
            End Get
            Set(ByVal value As String)
                _Type = value
            End Set
        End Property
#End Region 'The type of the parameter object.
#Region "[2019/03/24 14h45:314]<00.00.02> <Property> [Value|String]"
        Private _Value As String
        ''' <summary>
        ''' (Set|Get) The value of the parameter object.
        ''' </summary>
        ''' <returns></returns>
        ''' <author>Saadry Dunkel Consultant 24.03.2019 14:45</author>
        <CategoryAttribute("Info"),
       Description("(Set|Get) The value of the parameter object."),
       Browsable(True)>
        Public Property Value() As String
            Get
                Return _Value
            End Get
            Set(ByVal value As String)
                _Value = value
            End Set
        End Property
#End Region 'The value of the parameter object.
#Region "[2019/03/24 14h50:344]<00.00.03> <Property> [Object_Analysed|Object]"
        Private _Object_Analysed As Object
        ''' <summary>
        ''' (Set|Get) The object being analysed.
        ''' </summary>
        ''' <returns></returns>
        ''' <author>Saadry Dunkel Consultant 24.03.2019 14:50</author>
        <CategoryAttribute("Info"),
       Description("(Set|Get) The object being analysed."),
       Browsable(True)>
        Public Property Object_Analysed() As Object
            Get
                Return _Object_Analysed
            End Get
            Set(ByVal value As Object)
                _Object_Analysed = value
            End Set
        End Property
#End Region 'The object being analysed.
#Region "[2019/03/24 14h50:963]<00.00.04> <Property> [Object_Value|Object]"
        Private _Object_Value As Object
        ''' <summary>
        ''' (Set|Get) The value of the object being analysed.
        ''' </summary>
        ''' <returns></returns>
        ''' <author>Saadry Dunkel Consultant 24.03.2019 14:50</author>
        <CategoryAttribute("Info"),
       Description("(Set|Get) The value of the object being analysed."),
       Browsable(True)>
        Public Property Object_Value() As Object
            Get
                Return _Object_Value
            End Get
            Set(ByVal value As Object)
                _Object_Value = value
            End Set
        End Property
#End Region 'The value of the object being analysed.
#Region "[2019/03/24 17h31:676]<00.00.05> <Property> [Definition|String]"
        Private _Definition As String
        ''' <summary>
        ''' (Set|Get) The definition of the property.
        ''' </summary>
        ''' <returns></returns>
        ''' <author>Saadry Dunkel Consultant 24.03.2019 17:31</author>
        <CategoryAttribute("Info"),
       Description("(Set|Get) The definition of the property."),
       Browsable(True)>
        Public Property Definition() As String
            Get
                Return _Definition
            End Get
            Set(ByVal value As String)
                _Definition = value
            End Set
        End Property
#End Region 'The definition of the property.
#End Region
#End Region
#Region "<5> [Loader]"
#Region "<05.00> <Loader> [Empty]"
        Public Sub New()

        End Sub

#End Region
#Region "<05.01> <Loader> [Filled]"
        Public Sub New(ByVal Name As String,
                       ByVal Type As String,
                       ByVal Value As String,
                       Optional ByVal Object_Analysed As Object = Nothing,
                       Optional ByVal Object_Value As Object = Nothing,
                       Optional ByVal Definition As String = "")
            With Me
                .Name = Name
                .Type = Type
                .Value = Value
                If Not IsNothing(Object_Analysed) Then
                    .Object_Analysed = Object_Analysed
                End If
                If Not IsNothing(Object_Value) Then
                    .Object_Value = Object_Value
                End If
                .Definition = Definition
            End With

        End Sub

#End Region
#End Region
        Public Overrides Function ToString() As String
            Return Me.Name
        End Function
    End Class
#End Region
#Region "|08.03| <Class> [Steps]"
    Public Class Steps
#Region "|1| [Property]"
#Region "|01.00| <Property> [Info]"
#Region "[2019/03/25 13h50:141]<00.00.00> <Property> [ID|Integer]"
        Private _ID As Integer
        ''' <summary>
        ''' (Set|Get) The index step number.
        ''' </summary>
        ''' <returns></returns>
        ''' <author>Saadry Dunkel Consultant 25.03.2019 13:50</author>
        <CategoryAttribute("Info"),
   Description("(Set|Get) The index step number."),
   Browsable(True)>
        Public Property ID() As Integer
            Get
                Return _ID
            End Get
            Set(ByVal value As Integer)
                _ID = value
            End Set
        End Property
#End Region 'The index step number.
#Region "[2019/03/25 13h51:557]<00.00.01> <Property> [Name|String]"
        Private _Name As String
        ''' <summary>
        ''' (Set|Get) The name or keyword of the Step.
        ''' </summary>
        ''' <returns></returns>
        ''' <author>Saadry Dunkel Consultant 25.03.2019 13:51</author>
        <CategoryAttribute("Info"),
   Description("(Set|Get) The name or keyword of the Step."),
   Browsable(True)>
        Public Property Name() As String
            Get
                Return _Name
            End Get
            Set(ByVal value As String)
                _Name = value
            End Set
        End Property
#End Region 'The name or keyword of the Step.
#Region "[2019/03/25 13h52:218]<00.00.02> <Property> [Time|DateTime]"
        Private _Time As DateTime
        ''' <summary>
        ''' (Set|Get) The time of the step.
        ''' </summary>
        ''' <returns></returns>
        ''' <author>Saadry Dunkel Consultant 25.03.2019 13:52</author>
        <CategoryAttribute("Info"),
   Description("(Set|Get) The time of the step."),
   Browsable(True)>
        Public Property Time() As DateTime
            Get
                Return _Time
            End Get
            Set(ByVal value As DateTime)
                _Time = value
            End Set
        End Property
#End Region 'The time of the step.
#Region "[2019/03/25 13h53:454]<00.00.03> <Property> [Status|Status]"
        Private _Status As Status
        ''' <summary>
        ''' (Set|Get) The Status of the step.
        ''' </summary>
        ''' <returns></returns>
        ''' <author>Saadry Dunkel Consultant 25.03.2019 13:53</author>
        <CategoryAttribute("Info"),
   Description("(Set|Get) The Status of the step."),
   Browsable(True)>
        Public Property Status() As Status
            Get
                Return _Status
            End Get
            Set(ByVal value As Status)
                _Status = value
            End Set
        End Property
#End Region 'The Status of the step.
#Region "[2019/03/25 13h53:645]<00.00.04> <Property> [Description|String]"
        Private _Description As String
        ''' <summary>
        ''' (Set|Get) The statement of the step.
        ''' </summary>
        ''' <returns></returns>
        ''' <author>Saadry Dunkel Consultant 25.03.2019 13:53</author>
        <CategoryAttribute("Info"),
   Description("(Set|Get) The statement of the step."),
   Browsable(True)>
        Public Property Description() As String
            Get
                Return _Description
            End Get
            Set(ByVal value As String)
                _Description = value
            End Set
        End Property
#End Region 'The statement of the step.
#Region "[2019/03/25 13h55:099]<00.00.05> <Property> [Tag|Object]"
        Private _Tag As Object
        ''' <summary>
        ''' (Set|Get) The variable analysed.
        ''' </summary>
        ''' <returns></returns>
        ''' <author>Saadry Dunkel Consultant 25.03.2019 13:55</author>
        <CategoryAttribute("Info"),
   Description("(Set|Get) The variable analysed."),
   Browsable(True)>
        Public Property Tag() As Object
            Get
                Return _Tag
            End Get
            Set(ByVal value As Object)
                _Tag = value
            End Set
        End Property
#End Region 'The variable analysed.
#Region "[2019/03/25 13h56:505]<00.00.06> <Property> [ToolTip|String]"
        Private _ToolTip As String
        ''' <summary>
        ''' (Set|Get) The tooltip of the step.
        ''' </summary>
        ''' <returns></returns>
        ''' <author>Saadry Dunkel Consultant 25.03.2019 13:56</author>
        <CategoryAttribute("Info"),
   Description("(Set|Get) The tooltip of the step."),
   Browsable(True)>
        Public Property ToolTip() As String
            Get
                Return _ToolTip
            End Get
            Set(ByVal value As String)
                _ToolTip = value
            End Set
        End Property
#End Region 'The tooltip of the step.
#Region "[2019/03/25 13h59:502]<00.00.07> <Property> [Text|String]"
        Private _Text As String
        ''' <summary>
        ''' (Set|Get) The text of the steps.
        ''' </summary>
        ''' <returns></returns>
        ''' <author>Saadry Dunkel Consultant 25.03.2019 13:59</author>
        <CategoryAttribute("Info"),
   Description("(Set|Get) The text of the steps."),
   Browsable(True)>
        Public Property Text() As String
            Get
                Return _Text
            End Get
            Set(ByVal value As String)
                _Text = value
            End Set
        End Property
#End Region 'The text of the steps.

#End Region
#End Region
#Region "<5> [Loader]"
#Region "<05.00> <Loader> [Empty]"
        Public Sub New()

        End Sub
#End Region
#Region "<05.00> <Loader> [Filled]"
        Public Sub New(ByVal Id As Integer,
                       ByVal Name As String,
                       ByVal Status As Status,
                       ByVal ClassString As String,
                       ByVal Ref As String,
                       ByVal Description As String,
                       Optional ByVal Tag As Object = Nothing,
                       Optional ByVal Statement As String = "")
            With Me
                .ID = Id
                .Name = Name
                .Status = Status
                .Tag = Tag
                .Text = .Name
                .ToolTip = Statement
                .Time = Now
            End With

        End Sub
#End Region
#End Region
    End Class
#End Region
#Region "|08.04| <Class> [SearchEngine]"
    Public Class SearchEngine
#Region "<1> [Property]"
#Region "|2019/04/20 14h34:818| <01.00.00> <Property> <Info> [Call=Name|String]"'(Set|Get) SearchEngine Name
        Private _Name As String
        ''' <Summary>
        ''' SearchEngine Name
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/20 14h34:817 </Published>
        ''' <Updated>[Created=2019/04/20 14h34:811][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Info"), Description("SearchEngine Name"), Browsable(True)>
        Public Property Name() As String
            Get
                Return _Name
            End Get
            Set(ByVal Value As String)
                _Name = Value
            End Set
        End Property
#End Region ' (Set|Get) SearchEngine Name
#Region "|2019/04/20 14h35:730| <01.00.01> <Property> <Info> [Call=Url|String]"'(Set|Get) SearchEngine Url
        Private _Url As String
        ''' <Summary>
        ''' SearchEngine Url
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/20 14h35:730 </Published>
        ''' <Updated>[Created=2019/04/20 14h35:730][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Info"), Description("SearchEngine Url"), Browsable(True)>
        Public Property Url() As String
            Get
                Return _Url
            End Get
            Set(ByVal Value As String)
                _Url = Value
            End Set
        End Property
#End Region ' (Set|Get) SearchEngine Url
#Region "|2019/04/20 14h37:325| <01.00.02> <Property> <Info> [Call=SearchUrl|String]"'(Set|Get) SearchEngine SearchUrl
        Private _SearchUrl As String
        ''' <Summary>
        ''' SearchEngine SearchUrl
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/20 14h37:325 </Published>
        ''' <Updated>[Created=2019/04/20 14h37:325][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Info"), Description("SearchEngine SearchUrl"), Browsable(True)>
        Public Property SearchUrl() As String
            Get
                Return _SearchUrl
            End Get
            Set(ByVal Value As String)
                _SearchUrl = Value
            End Set
        End Property
#End Region ' (Set|Get) SearchEngine SearchUrl
#Region "|2019/04/20 14h38:080| <01.00.03> <Property> <Info> [Call=FormattedUrl|String]"'(Set|Get) SearchEngine FormattedUrl
        Private _FormattedUrl As String
        ''' <Summary>
        ''' SearchEngine FormattedUrl
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/20 14h38:080 </Published>
        ''' <Updated>[Created=2019/04/20 14h38:079][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Info"), Description("SearchEngine FormattedUrl"), Browsable(True)>
        Public Property FormattedUrl() As String
            Get
                Return _FormattedUrl
            End Get
            Set(ByVal Value As String)
                _FormattedUrl = Value
            End Set
        End Property
#End Region ' (Set|Get) SearchEngine FormattedUrl
#Region "|2019/04/20 14h39:260| <01.00.04> <Property> <Info> [Call=Item|ComboBoxItem]"'(Set|Get) the Item as ComboBoxItem
        Private _Item As ComboBoxItem
        ''' <Summary>
        ''' (Set|Get) the Item as ComboBoxItem
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/20 14h39:260 </Published>
        ''' <Updated>[Created=2019/04/20 14h39:260][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Info"), Description("(Set|Get) the Item as ComboBoxItem"), Browsable(True)>
        Public Property Item() As ComboBoxItem
            Get
                Return _Item
            End Get
            Set(ByVal Value As ComboBoxItem)
                _Item = Value
            End Set
        End Property
#End Region ' (Set|Get) the Item as ComboBoxItem

#End Region
#Region "<2> [Enumeration]"

#End Region
#Region "<3> [Structures]"

#End Region
#Region "<4> [Sub]"

#End Region
#Region "<5> [Function]"
#Region "|2019/04/20 14h42:316| <04.00.00> <Function> <Function> [Call=ConvertYoutubeUrl_To_VLC|String]"'Convert youtube url to vlc formated string.
        ''' <Summary>
        ''' (Set|Get) Convert youtube url to vlc formated string.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/20 14h42:316 </Published>
        ''' <Updated>[Created=2019/04/20 14h42:316][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Function"), Description("Convert youtube url to vlc formated string."), Browsable(True)>
        Public Function ConvertYoutubeUrl_To_VLC(ByVal Url As String) As String
            Dim Result As String = iYoutube.FormattedUrl
            Dim youtubeCoordinate As String = Remove_Character_FromString(Url, "https://www.youtube.com/watch?v=")
            Result &= youtubeCoordinate
            Return Result
        End Function
#End Region ' Convert youtube url to vlc formated string.
#Region "|2019/04/20 14h43:823| <04.00.01> <Function> <Function> [Call=GetYoutubeThumbnail|String]"'Convert youtube url to vlc formated string.
        ''' <Summary>
        ''' (Set|Get) Convert youtube url to vlc formated string.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/20 14h43:823 </Published>
        ''' <Updated>[Created=2019/04/20 14h43:823][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Function"), Description("Convert youtube url to vlc formated string."), Browsable(True)>
        Public Shared Function GetYoutubeThumbnail(ByVal Url As String) As String
            Dim RString As String = "http://img.youtube.com/vi/"
            Dim youtubeCoordinate As String = Remove_Character_FromString(Url, "https://www.youtube.com/watch?v=")
            RString &= youtubeCoordinate & "/default.jpg"
            Return RString
        End Function
#End Region ' Convert youtube url to vlc formated string.
#Region "|2019/04/20 14h45:798| <04.00.02> <Function> <Function> [Call=DownloadYoutubeVideo|IO.FileInfo]"'Download the youtube video as Io.Fileinfo.
        ''' <Summary>
        ''' (Set|Get) Download the youtube video as Io.Fileinfo.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/20 14h45:798 </Published>
        ''' <Updated>[Created=2019/04/20 14h45:798][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Function"), Description("Download the youtube video as Io.Fileinfo."), Browsable(True)>
        Public Function DownloadYoutubeVideo(ByVal Url As String) As IO.FileInfo
            Dim Fi As String = My.Application.Info.DirectoryPath & "\Tempfiles\" & GetFileNameFrom_Url(Url)
            If IO.Directory.Exists(My.Application.Info.DirectoryPath & "\Tempfiles") = False Then
                IO.Directory.CreateDirectory(My.Application.Info.DirectoryPath & "\Tempfiles")
            End If
            If IO.File.Exists(Fi) Then
                IO.File.Delete(Fi)
            End If
            Fi &= ".mp3"
            Dim Fil As IO.FileInfo = Nothing
            Try
                My.Computer.Network.DownloadFile(Url, Fi)
            Catch ex As Exception

            End Try
            'Fil = New Fichier(Fi)
            ' Dim videoID As String = Remove_Character_FromString(url, "https://www.youtube.com/watch?v=")
            'Dim wc As WebClient = New WebClient
            'Dim file As String = wc.DownloadString(String.Format("http://www.youtube.com/watch?v={0}", videoID))
            'Dim t As String = New Regex("(?<=&t=)[^&]*").Match(file).Value
            'wc.DownloadFile(String.Format("http://www.youtube.com/get_video?t={0}=&video_id={1}", t, videoID), newFilePath)
            'Dim Result As New Fichier(newFilePath)
            Return Fil
        End Function
#End Region ' Download the youtube video as Io.Fileinfo.
#Region "|2019/04/20 14h46:865| <04.00.03> <Function> <Function> [Call=DownloadYoutubeThumbnail|IO.FileInfo]"'Download the youtube thumbnail video as Io.Fileinfo.
        ''' <Summary>
        ''' (Set|Get) Download the youtube thumbnail video as Io.Fileinfo.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/20 14h46:865 </Published>
        ''' <Updated>[Created=2019/04/20 14h46:865][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Function"), Description("Download the youtube thumbnail video as Io.Fileinfo."), Browsable(True)>
        Public Function DownloadYoutubeThumbnail(ByVal Url As String) As IO.FileInfo
            Dim Result As String = GetYoutubeThumbnail(Url)

            If My.Settings.DownloadDir = "" Then
                My.Settings.DownloadDir = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Tempfiles"
                My.Settings.Save()

            End If
            If IO.Directory.Exists(My.Settings.DownloadDir) = False Then
                IO.Directory.CreateDirectory(My.Settings.DownloadDir)
            End If
            Dim ResultFile As IO.FileInfo = Nothing
            Try
                Dim uri As New Uri(Url)
                Dim fileName As String = IO.Path.GetFileName(uri.LocalPath)
                My.Computer.Network.DownloadFile(Result, My.Settings.DownloadDir & "\" & fileName)
                ' ResultFile = New Fichier(My.Settings.DownloadDir & "\" & fileName)
            Catch ex As Exception

            End Try
            Return ResultFile
        End Function
#End Region ' Download the youtube thumbnail video as Io.Fileinfo.
#Region "|2019/04/20 14h46:162| <04.00.04> <Function> <Function> [Call=GetFileNameFrom_Url|String]"' Get file name from string.
        ''' <Summary>
        ''' (Set|Get)  Get file name from string.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/20 14h46:161 </Published>
        ''' <Updated>[Created=2019/04/20 14h46:161][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Function"), Description(" Get file name from string."), Browsable(True)>
        Public Function GetFileNameFrom_Url(ByVal Url As String) As String
            Dim uri As New Uri(Url)
            Dim fileName As String = IO.Path.GetFileName(uri.LocalPath)
            Return fileName
        End Function
#End Region '  Get file name from string.
        ''' <summary>
        ''' This simple function find the given expression and removes it
        ''' </summary>
        ''' <param name="Str"></param>
        ''' <param name="Expression"></param>
        ''' <returns>As String</returns>
        Public Shared Function Remove_Character_FromString(ByVal Str As String,
                                                 ByVal Expression As String) As String
            Dim Result As String = Str
            If Str.Contains(Expression) Then
                Result = Replace(Str, Expression, "")
            End If
            Return Result
        End Function
#End Region
#Region "<6> [Loader]"
#Region "<06.00> <Loader> [Empty]"
        Public Sub New()

        End Sub
#End Region
#Region "<06.01> <Loader> [Filled]"
        Public Sub New(ByVal Name As String,
                       ByVal Url As String,
                       Optional ByVal SearchUrl As String = "",
                       Optional ByVal FormattedUrl As String = "")
            Me.Name = Name
            Me.Url = Url
            Me.Item = New ComboBoxItem(Name)
            Me.Item.Tag = Url
            If SearchUrl = "" Then
            Else
                Me.SearchUrl = SearchUrl
                Me.Item.Tag = SearchUrl
            End If
            If FormattedUrl = "" Then
            Else
                Me.FormattedUrl = FormattedUrl
            End If
        End Sub
#End Region
#End Region
#Region "<7> [Runtime]"


#End Region
#Region "<8> [Class]"

#End Region
    End Class 'SearchEngine

#End Region
#Region "|08.05| <Class> [TimeInfo]"
    Public Class TimeInfo
#Region "<0> [Properties]"
#Region "<00.01> <Date Information>"
        ' - Year            : (Set|Get) Year
        ' - Month           : (Set|Get) Month
        ' - Week            : (Set|Get) Week
        ' - Day             : (Set|Get) Day
        ' - Hour            : (Set|Get) Hour
        ' - Minutes         : (Set|Get) Minutes
        ' - Seconds         : (Set|Get) Seconds
        ' - Milliseconds    : (Set|Get) Milliseconds
        ' - Age             : (Set|Get) Age
        ' - Now             : (Set|Get) Actual Date of the call
        ' - Display         : (Set|Get) Display Formated view as String
#Region "<00.01.01> <Date Information> [Year|Integer]"
        Private _Year As Integer
        ''' <summary>
        ''' (Set|Get) Year
        ''' </summary>
        ''' <returns></returns>
        <CategoryAttribute("Date Information"),
       Description("(Set|Get) Year"),
       Browsable(True)>
        Public Property Year() As Integer
            Get
                Return _Year
            End Get
            Set(ByVal value As Integer)
                _Year = value
            End Set
        End Property
#End Region
#Region "<00.01.02> <Date Information> [Month|Integer]"
        Private _Month As Integer
        ''' <summary>
        ''' (Set|Get) Month
        ''' </summary>
        ''' <returns></returns>
        <CategoryAttribute("Date Information"),
       Description("(Set|Get) Month"),
       Browsable(True)>
        Public Property Month() As Integer
            Get
                Return _Month
            End Get
            Set(ByVal value As Integer)
                _Month = value
            End Set
        End Property
#End Region
#Region "<00.01.03> <Date Information> [Week|Integer]"
        Private _Week As Integer
        ''' <summary>
        ''' (Set|Get) Week
        ''' </summary>
        ''' <returns></returns>
        <CategoryAttribute("Date Information"),
       Description("(Set|Get) Week"),
       Browsable(True)>
        Public Property Week() As Integer
            Get
                Return _Week
            End Get
            Set(ByVal value As Integer)
                _Week = value
            End Set
        End Property
#End Region
#Region "<00.01.04> <Date Information> [Day|Integer]"
        Private _Day As Integer
        ''' <summary>
        ''' (Set|Get) Day
        ''' </summary>
        ''' <returns></returns>
        <CategoryAttribute("Date Information"),
       Description("(Set|Get) Day"),
       Browsable(True)>
        Public Property Day() As Integer
            Get
                Return _Day
            End Get
            Set(ByVal value As Integer)
                _Day = value
            End Set
        End Property
#End Region
#Region "<00.01.05> <Date Information> [Hour|Integer]"
        Private _Hour As Integer
        ''' <summary>
        ''' (Set|Get) Hour
        ''' </summary>
        ''' <returns></returns>
        <CategoryAttribute("Date Information"),
       Description("(Set|Get) Hour"),
       Browsable(True)>
        Public Property Hour() As Integer
            Get
                Return _Hour
            End Get
            Set(ByVal value As Integer)
                _Hour = value
            End Set
        End Property
#End Region
#Region "<00.01.06> <Date Information> [Minutes|Integer]"
        Private _Minutes As Integer
        ''' <summary>
        ''' (Set|Get) Minutes
        ''' </summary>
        ''' <returns></returns>
        <CategoryAttribute("Date Information"),
       Description("(Set|Get) Minutes"),
       Browsable(True)>
        Public Property Minutes() As Integer
            Get
                Return _Minutes
            End Get
            Set(ByVal value As Integer)
                _Minutes = value
            End Set
        End Property
#End Region
#Region "<00.01.07> <Date Information> [Seconds|Integer]"
        Private _Seconds As Integer
        ''' <summary>
        ''' (Set|Get) Seconds
        ''' </summary>
        ''' <returns></returns>
        <CategoryAttribute("Date Information"),
       Description("(Set|Get) Seconds"),
       Browsable(True)>
        Public Property Seconds() As Integer
            Get
                Return _Seconds
            End Get
            Set(ByVal value As Integer)
                _Seconds = value
            End Set
        End Property
#End Region
#Region "<00.01.08> <Date Information> [Milliseconds|Integer]"
        Private _Milliseconds As Integer
        ''' <summary>
        ''' (Set|Get) Milliseconds
        ''' </summary>
        ''' <returns></returns>
        <CategoryAttribute("Date Information"),
       Description("(Set|Get) Milliseconds"),
       Browsable(True)>
        Public Property Milliseconds() As Integer
            Get
                Return _Milliseconds
            End Get
            Set(ByVal value As Integer)
                _Milliseconds = value
            End Set
        End Property
#End Region
        Private _NanoSeconds As Integer
        ''' <summary>
        ''' (Set|Get) NanoSeconds
        ''' </summary>
        ''' <returns></returns>
        <CategoryAttribute("Date Information"),
       Description("(Set|Get) NanoSeconds"),
       Browsable(True)>
        Public Property NanoSeconds() As Integer
            Get
                Return _NanoSeconds
            End Get
            Set(ByVal value As Integer)
                _NanoSeconds = value
            End Set
        End Property
#Region "<00.01.09> <Date Information> [Age|TimeInfo]"
        Private _Age As TimeInfo
        ''' <summary>
        ''' (Set|Get) Age
        ''' </summary>
        ''' <returns></returns>
        <CategoryAttribute("Date Information"),
       Description("(Set|Get) Age"),
       Browsable(True)>
        Public Property Age() As TimeInfo
            Get
                Return _Age
            End Get
            Set(ByVal value As TimeInfo)
                _Age = value
            End Set
        End Property
#End Region
#Region "<00.01.10> <Date Information> [Now|TimeInfo]"
        Private _Now As TimeInfo
        ''' <summary>
        ''' (Set|Get) Actual Date of the call
        ''' </summary>
        ''' <returns></returns>
        <CategoryAttribute("Date Information"),
       Description("(Set|Get) Actual Date of the call"),
       Browsable(True)>
        Public Property Now() As TimeInfo
            Get
                Return _Now
            End Get
            Set(ByVal value As TimeInfo)
                _Now = value
            End Set
        End Property
#End Region
#Region "<00.01.11> <Date Information> [Display|String]"
        Private _Display As String
        ''' <summary>
        ''' (Set|Get) Display Formated view as String
        ''' </summary>
        ''' <returns></returns>
        <CategoryAttribute("Date Information"),
       Description("(Set|Get) Display Formated view as String"),
       Browsable(True)>
        Public Property Display() As String
            Get
                Return _Display
            End Get
            Set(ByVal value As String)
                _Display = value
            End Set
        End Property
#End Region
#End Region
#Region "<00.02> <Object Information>"
        ' - SchemaNode            : (Set|Get) Schema code Node
#Region "<00.02.01> <Object> [SchemaNode()|DevComponents.AdvTree.Node]"
        Private _SchemaNode As DevComponents.AdvTree.Node
        ''' <summary>
        ''' (Set|Get) Schema code Node
        ''' </summary>
        ''' <returns></returns>
        <CategoryAttribute("<Coder>"),
       Description("(Set|Get) Schema code Node"),
       Browsable(True)>
        Public Property SchemaNode() As DevComponents.AdvTree.Node
            Get
                Return _SchemaNode
            End Get
            Set(ByVal value As DevComponents.AdvTree.Node)
                _SchemaNode = value
            End Set
        End Property
#End Region
#End Region
#End Region
#Region "<1> [Enumeration]"
#Region "<01.01> <Enumeration> [Display_As]"
        ''' <summary>
        ''' Display Information as
        ''' </summary>
        Public Enum Display_As
            Short_TimeToString = 9
            Short_DateToString = 8
            Short_DateTimeToString = 7
            Long_TimeToString = 6
            Long_DateToString = 5
            Long_DateTimeToString = 4
            Short_Date_Long_Time = 3
            Long_Time_Short_Date = 2
            Archive_Format = 1
            NotTested = 0
        End Enum
#End Region
#End Region
#Region "<2> [Structures]"

#End Region
#Region "<3> [Subs]"

#End Region
#Region "<4> [Functions]"
#Region "<04.01> [DisplayMe(Format,Seperator)|As String]"
        ''' <summary>
        ''' Return a Date format as 
        ''' </summary>
        ''' <returns></returns>
        Public Function DisplayMe(Optional ByVal Format As Display_As = Display_As.Short_Date_Long_Time,
                               Optional ByVal Seperator As String = "/") As String
            Dim Result As String = Nothing
            If Format = Display_As.Archive_Format Then
                Result = Year & "_" & Month & "_" & Day & "_" & If(Hour < 10, 0 & Hour, Hour) & "h" & If(Minutes < 10, 0 & Minutes, Minutes)
            ElseIf Format = Display_As.Long_DateTimeToString Then
                Dim T1 As String = "Undefined"
                If Month = 1 Then
                    T1 = "January"
                ElseIf Month = 2 Then
                    T1 = "February"
                ElseIf Month = 3 Then
                    T1 = "March"
                ElseIf Month = 4 Then
                    T1 = "April"
                ElseIf Month = 5 Then
                    T1 = "May"
                ElseIf Month = 6 Then
                    T1 = "June"
                ElseIf Month = 7 Then
                    T1 = "July"
                ElseIf Month = 8 Then
                    T1 = "August"
                ElseIf Month = 9 Then
                    T1 = "September"
                ElseIf Month = 10 Then
                    T1 = "October"
                ElseIf Month = 11 Then
                    T1 = "November"
                ElseIf Month = 12 Then
                    T1 = "December"
                End If
                Result = Day & " " & T1 & " " & Year & " " & If(Hour < 10, 0 & Hour, Hour) & "h" & If(Minutes < 10, 0 & Minutes, Minutes) & ":" & If(Seconds < 10, 0 & Seconds, Seconds) & ":" & If(Milliseconds < 10, 0 & Milliseconds, Milliseconds)
            ElseIf Format = Display_As.Long_DateToString Then
                Dim T1 As String = "Undefined"
                If Month = 1 Then
                    T1 = "January"
                ElseIf Month = 2 Then
                    T1 = "February"
                ElseIf Month = 3 Then
                    T1 = "March"
                ElseIf Month = 4 Then
                    T1 = "April"
                ElseIf Month = 5 Then
                    T1 = "May"
                ElseIf Month = 6 Then
                    T1 = "June"
                ElseIf Month = 7 Then
                    T1 = "July"
                ElseIf Month = 8 Then
                    T1 = "August"
                ElseIf Month = 9 Then
                    T1 = "September"
                ElseIf Month = 10 Then
                    T1 = "October"
                ElseIf Month = 11 Then
                    T1 = "November"
                ElseIf Month = 12 Then
                    T1 = "December"
                End If
                Result = Day & " " & T1 & " " & Year
            ElseIf Format = Display_As.Long_TimeToString Then
                Result = If(Hour < 10, 0 & Hour, Hour) & "h" & If(Minutes < 10, 0 & Minutes, Minutes) & ":" & If(Seconds < 10, 0 & Seconds, Seconds) & ":" & If(Milliseconds < 10, 0 & Milliseconds, Milliseconds)
            ElseIf Format = Display_As.Long_Time_Short_Date Then
                Dim T1 As String = "Undefined"
                If Month = 1 Then
                    T1 = "January"
                ElseIf Month = 2 Then
                    T1 = "February"
                ElseIf Month = 3 Then
                    T1 = "March"
                ElseIf Month = 4 Then
                    T1 = "April"
                ElseIf Month = 5 Then
                    T1 = "May"
                ElseIf Month = 6 Then
                    T1 = "June"
                ElseIf Month = 7 Then
                    T1 = "July"
                ElseIf Month = 8 Then
                    T1 = "August"
                ElseIf Month = 9 Then
                    T1 = "September"
                ElseIf Month = 10 Then
                    T1 = "October"
                ElseIf Month = 11 Then
                    T1 = "November"
                ElseIf Month = 12 Then
                    T1 = "December"
                End If
                Result = Day & " " & T1 & " " & Year & " " & If(Hour < 10, 0 & Hour, Hour) & "h" & If(Minutes < 10, 0 & Minutes, Minutes)
            ElseIf Format = Display_As.Short_DateTimeToString Then
                Result = Day & Seperator & Month & Seperator & Year & " " & If(Hour < 10, 0 & Hour, Hour) & "h" & If(Minutes < 10, 0 & Minutes, Minutes)
            ElseIf Format = Display_As.Short_DateToString Then
                Result = Day & Seperator & Month & Seperator & Year
            ElseIf Format = Display_As.Short_Date_Long_Time Then
                Result = Day & Seperator & Month & Seperator & Year & " " & If(Hour < 10, 0 & Hour, Hour) & "h" & If(Minutes < 10, 0 & Minutes, Minutes) & ":" & If(Seconds < 10, 0 & Seconds, Seconds) & ":" & If(Milliseconds < 10, 0 & Milliseconds, Milliseconds)
            ElseIf Format = Display_As.Short_TimeToString Then
                Result = If(Hour < 10, 0 & Hour, Hour) & "h" & If(Minutes < 10, 0 & Minutes, Minutes)
            End If
            Return Result
        End Function
#End Region
#Region "<04.02> [MyAge()|As TimeInfo]"
        ''' <summary>
        ''' Return a Date format as 
        ''' </summary>
        ''' <returns></returns>
        Public Function MyAge() As TimeInfo
            Dim Result As New TimeInfo
            Result.Year = Now.Year - Year
            Result.Month = Now.Month - Month
            Result.Week = Now.Week - Week
            Result.Day = Now.Day - Day
            Result.Hour = Now.Hour - Hour
            Result.Minutes = Now.Minutes - Minutes
            Result.Seconds = Now.Seconds - Seconds
            Result.Milliseconds = Now.Milliseconds - Milliseconds
            If Result.Year > 0 Then
                Result.Display = Result.Year & If(Result.Year > 1, " Years old", " Year old")
            Else
                If Result.Month > 0 Then
                    Result.Display = Result.Month & If(Result.Month > 1, " Months old", " Month old")
                Else
                    If Result.Week > 0 Then
                        Result.Display = Result.Week & If(Result.Week > 1, " Weeks old", " Week old")
                    Else
                        If Result.Day > 0 Then
                            Result.Display = Result.Day & If(Result.Day > 1, " Days old", " Day old")
                        Else
                            If Result.Hour > 0 Then
                                Result.Display = Result.Hour & If(Result.Hour > 1, " Hours old", " Hour old")
                            Else
                                If Result.Minutes > 0 Then
                                    Result.Display = Result.Minutes & If(Result.Minutes > 1, " Minutes old", " Minute old")
                                Else
                                    If Result.Seconds > 0 Then
                                        Result.Display = Result.Seconds & If(Result.Seconds > 1, " Seconds old", " Second old")
                                    Else
                                        If Result.Milliseconds > 0 Then
                                            Result.Display = Result.Milliseconds & If(Result.Milliseconds > 1, " Milliseconds old", " Millisecond old")
                                        Else
                                            Result.Display = 0
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            Return Result
        End Function
#End Region
#Region "<04.03> [GetSchemaNode|DevComponents.AdvTree.Node]"
        Public Function GetSchemaNode() As DevComponents.AdvTree.Node
            SchemaNode = New DevComponents.AdvTree.Node("[Time_Info]")
            Dim N_Properties As New DevComponents.AdvTree.Node("<00> [Properties] | ")
            Dim N_Properties_Date As New DevComponents.AdvTree.Node("<00.01> Date | {Parent,Line,Type}")
            Dim N_Properties_Date_Year As New DevComponents.AdvTree.Node("<00.01.01> Year | (Set|Get) The parent Table Class Reference")
            Dim N_Properties_Date_Month As New DevComponents.AdvTree.Node("<00.01.02> Month | (Set|Get) Determines the Line Connection String")
            Dim N_Properties_Date_Week As New DevComponents.AdvTree.Node("<00.01.03> Week | (Set|Get) Retreive the Column Type")
            Dim N_Properties_Date_Day As New DevComponents.AdvTree.Node("<00.01.04> Day | (Set|Get) Day")
            Dim N_Properties_Date_Hour As New DevComponents.AdvTree.Node("<00.01.05> Hour | (Set|Get) Hour")
            Dim N_Properties_Date_Minutes As New DevComponents.AdvTree.Node("<00.01.06> Minutes | (Set|Get) Minutes")
            Dim N_Properties_Date_Seconds As New DevComponents.AdvTree.Node("<00.01.07> Seconds | (Set|Get) Seconds")
            Dim N_Properties_Date_Milliseconds As New DevComponents.AdvTree.Node("<00.01.08> Milliseconds | (Set|Get) Milliseconds")
            Dim N_Properties_Date_Age As New DevComponents.AdvTree.Node("<00.01.09> Age | (Set|Get) Age")
            Dim N_Properties_Date_Now As New DevComponents.AdvTree.Node("<00.01.10> Now | (Set|Get) Actual Date of the call")
            Dim N_Properties_Date_Display As New DevComponents.AdvTree.Node("<00.01.11> Display | (Set|Get) Display Formated view as String")
            Dim N_Properties_Object As New DevComponents.AdvTree.Node("<00.02> Object | ")
            Dim N_Properties_Object_SchemaNode As New DevComponents.AdvTree.Node("<00.02.01> SchemaNode | (Set|Get) Schema code Node")
            Dim N_Enumeration As New DevComponents.AdvTree.Node("<01> [Enumerations] | ")
            Dim N_Enumeration_Display_As As New DevComponents.AdvTree.Node("<01.01> Display_As | ")
            Dim N_Enumeration_Display_As_Short_TimeToString As New DevComponents.AdvTree.Node("<01.01.01> Short_TimeToString | ")
            Dim N_Enumeration_Display_As_Short_DateToString As New DevComponents.AdvTree.Node("<01.01.02> Short_DateToString | ")
            Dim N_Enumeration_Display_As_Short_DateTimeToString As New DevComponents.AdvTree.Node("<01.01.03> Short_DateTimeToString | ")
            Dim N_Enumeration_Display_As_Long_TimeToString As New DevComponents.AdvTree.Node("<01.01.04> Long_TimeToString | ")
            Dim N_Enumeration_Display_As_Long_DateToString As New DevComponents.AdvTree.Node("<01.01.05> Long_DateToString | ")
            Dim N_Enumeration_Display_As_Long_DateTimeToString As New DevComponents.AdvTree.Node("<01.01.06> Long_DateTimeToString | ")
            Dim N_Enumeration_Display_As_Short_Date_Long_Time As New DevComponents.AdvTree.Node("<01.01.07> Short_Date_Long_Time | ")
            Dim N_Enumeration_Display_As_Long_Time_Short_Date As New DevComponents.AdvTree.Node("<01.01.08> Long_Time_Short_Date | ")
            Dim N_Enumeration_Display_As_Archive_Format As New DevComponents.AdvTree.Node("<01.01.09> Archive_Format | ")
            Dim N_Enumeration_Display_As_NotTested As New DevComponents.AdvTree.Node("<01.01.10> NotTested | ")
            Dim N_Structures As New DevComponents.AdvTree.Node("<02> [Structures] | ")
            Dim N_Subs As New DevComponents.AdvTree.Node("<03> [Subs] | ")
            Dim N_Functions As New DevComponents.AdvTree.Node("<04> [Functions] | ")
            Dim N_Functions_DisplayMe As New DevComponents.AdvTree.Node("<04.01> DisplayMe | Return a Date format as ")
            Dim N_Functions_MyAge As New DevComponents.AdvTree.Node("<04.02> MyAge | Retreive the Age")
            Dim N_Functions_GetSchemaNode As New DevComponents.AdvTree.Node("<04.03> GetSchemaNode | Get Schema of the Class")
            Dim N_New As New DevComponents.AdvTree.Node("<05> [New()] | ")
            Dim N_New_New As New DevComponents.AdvTree.Node("<05.01> New | Public Sub New()")
            Dim N_New_New2 As New DevComponents.AdvTree.Node("<05.02> New2 | Public Sub New(ByVal iDate As DateTime)")
            Dim N_New_New3 As New DevComponents.AdvTree.Node("<05.03> New3 | Public Sub New({…})")
            Dim N_Runtime As New DevComponents.AdvTree.Node("<06> [Runtime] | ")
            Dim N_Classes As New DevComponents.AdvTree.Node("<07> [Classes] | ")
            Dim N_Constantes As New DevComponents.AdvTree.Node("<08> [Constantes] | ")
            SchemaNode.ImageIndex = 7
            N_Properties.ImageIndex = 0
            N_Properties_Date.ImageIndex = 0
            N_Properties_Date_Year.ImageIndex = 0
            N_Properties_Date_Month.ImageIndex = 0
            N_Properties_Date_Week.ImageIndex = 0
            N_Properties_Date_Day.ImageIndex = 0
            N_Properties_Date_Hour.ImageIndex = 0
            N_Properties_Date_Minutes.ImageIndex = 0
            N_Properties_Date_Seconds.ImageIndex = 0
            N_Properties_Date_Milliseconds.ImageIndex = 0
            N_Properties_Date_Age.ImageIndex = 0
            N_Properties_Date_Now.ImageIndex = 0
            N_Properties_Date_Display.ImageIndex = 0
            N_Properties_Object.ImageIndex = 0
            N_Properties_Object_SchemaNode.ImageIndex = 0
            N_Enumeration.ImageIndex = 1
            N_Enumeration_Display_As.ImageIndex = 1
            N_Enumeration_Display_As_Short_TimeToString.ImageIndex = 1
            N_Enumeration_Display_As_Short_DateToString.ImageIndex = 1
            N_Enumeration_Display_As_Short_DateTimeToString.ImageIndex = 1
            N_Enumeration_Display_As_Long_TimeToString.ImageIndex = 1
            N_Enumeration_Display_As_Long_DateToString.ImageIndex = 1
            N_Enumeration_Display_As_Long_DateTimeToString.ImageIndex = 1
            N_Enumeration_Display_As_Short_Date_Long_Time.ImageIndex = 1
            N_Enumeration_Display_As_Long_Time_Short_Date.ImageIndex = 1
            N_Enumeration_Display_As_Archive_Format.ImageIndex = 1
            N_Enumeration_Display_As_NotTested.ImageIndex = 1
            N_Structures.ImageIndex = 2
            N_Subs.ImageIndex = 3
            N_Functions.ImageIndex = 4
            N_Functions_DisplayMe.ImageIndex = 4
            N_Functions_MyAge.ImageIndex = 4
            N_Functions_GetSchemaNode.ImageIndex = 4
            N_New.ImageIndex = 5
            N_New_New.ImageIndex = 5
            N_New_New2.ImageIndex = 5
            N_New_New3.ImageIndex = 5
            N_Runtime.ImageIndex = 6
            N_Classes.ImageIndex = 7
            N_Constantes.ImageIndex = 8
            SchemaNode.Nodes.Add(N_Properties)
            N_Properties.Nodes.Add(N_Properties_Date)
            N_Properties_Date.Nodes.Add(N_Properties_Date_Year)
            N_Properties_Date.Nodes.Add(N_Properties_Date_Month)
            N_Properties_Date.Nodes.Add(N_Properties_Date_Week)
            N_Properties_Date.Nodes.Add(N_Properties_Date_Day)
            N_Properties_Date.Nodes.Add(N_Properties_Date_Hour)
            N_Properties_Date.Nodes.Add(N_Properties_Date_Minutes)
            N_Properties_Date.Nodes.Add(N_Properties_Date_Seconds)
            N_Properties_Date.Nodes.Add(N_Properties_Date_Milliseconds)
            N_Properties_Date.Nodes.Add(N_Properties_Date_Age)
            N_Properties_Date.Nodes.Add(N_Properties_Date_Now)
            N_Properties_Date.Nodes.Add(N_Properties_Date_Display)
            N_Properties.Nodes.Add(N_Properties_Object)
            N_Properties_Object.Nodes.Add(N_Properties_Object_SchemaNode)
            SchemaNode.Nodes.Add(N_Enumeration)
            N_Enumeration.Nodes.Add(N_Enumeration_Display_As)
            N_Enumeration_Display_As.Nodes.Add(N_Enumeration_Display_As_Short_TimeToString)
            N_Enumeration_Display_As.Nodes.Add(N_Enumeration_Display_As_Short_DateToString)
            N_Enumeration_Display_As.Nodes.Add(N_Enumeration_Display_As_Short_DateTimeToString)
            N_Enumeration_Display_As.Nodes.Add(N_Enumeration_Display_As_Long_TimeToString)
            N_Enumeration_Display_As.Nodes.Add(N_Enumeration_Display_As_Long_DateToString)
            N_Enumeration_Display_As.Nodes.Add(N_Enumeration_Display_As_Long_DateTimeToString)
            N_Enumeration_Display_As.Nodes.Add(N_Enumeration_Display_As_Short_Date_Long_Time)
            N_Enumeration_Display_As.Nodes.Add(N_Enumeration_Display_As_Long_Time_Short_Date)
            N_Enumeration_Display_As.Nodes.Add(N_Enumeration_Display_As_Archive_Format)
            N_Enumeration_Display_As.Nodes.Add(N_Enumeration_Display_As_NotTested)
            SchemaNode.Nodes.Add(N_Structures)
            SchemaNode.Nodes.Add(N_Subs)
            SchemaNode.Nodes.Add(N_Functions)
            N_Functions.Nodes.Add(N_Functions_DisplayMe)
            N_Functions.Nodes.Add(N_Functions_MyAge)
            N_Functions.Nodes.Add(N_Functions_GetSchemaNode)
            SchemaNode.Nodes.Add(N_New)
            N_New.Nodes.Add(N_New_New)
            N_New.Nodes.Add(N_New_New2)
            N_New.Nodes.Add(N_New_New3)
            SchemaNode.Nodes.Add(N_Runtime)
            SchemaNode.Nodes.Add(N_Classes)
            SchemaNode.Nodes.Add(N_Constantes)
            Return SchemaNode
        End Function
#End Region

#End Region
#Region "<5> [New()]"
#Region "<05.01> <New()> [Empty]"
        Public Sub New()

        End Sub
#End Region
#Region "<05.02> <New(iDate|DateTime)> [iDate]"
        Public Sub New(ByVal iDate As DateTime)
            Now = New TimeInfo

            Now.Year = Date.Now.Year
            Now.Month = Date.Now.Month
            Now.Week = Convert_Days_ToWeeks(Date.Now.DayOfYear)
            Now.Day = Date.Now.Day
            Now.Hour = Date.Now.Hour
            Now.Minutes = Date.Now.Minute
            Now.Seconds = Date.Now.Second
            Now.Milliseconds = Date.Now.Millisecond
            Year = iDate.Year
            Month = iDate.Month
            Week = Convert_Days_ToWeeks(iDate.DayOfYear)
            Day = iDate.Day
            Hour = iDate.Hour
            Minutes = iDate.Minute
            Seconds = iDate.Second
            Milliseconds = iDate.Millisecond
            NanoSeconds = 0
        End Sub
#End Region
#Region "<05.03> <New()>"
        Public Sub New(Optional ByVal Year As Integer = 0,
                    Optional ByVal Month As Integer = 0,
                    Optional ByVal Day As Integer = 0,
                    Optional ByVal Hour As Integer = 0,
                    Optional ByVal Minutes As Integer = 0,
                    Optional ByVal Seconds As Integer = 0,
                    Optional ByVal Milliseconds As Integer = 0)
            With Me
                .Year = Year
                .Month = Month
                .Day = Day
                .Hour = Hour
                .Minutes = Minutes
                .Seconds = Seconds
                .Milliseconds = Milliseconds
            End With
            Now = New TimeInfo

            Now.Year = Date.Now.Year
            Now.Month = Date.Now.Month
            Now.Week = Convert_Days_ToWeeks(Date.Now.DayOfYear)
            Now.Day = Date.Now.Day
            Now.Hour = Date.Now.Hour
            Now.Minutes = Date.Now.Minute
            Now.Seconds = Date.Now.Second
            Now.Milliseconds = Date.Now.Millisecond
        End Sub
#End Region
#End Region
        Public Sub New(ByVal Intervals As ULong)
            Dim Chronos As New TimeInfo

            'Step 1
            Now = New TimeInfo

            Now.Year = Date.Now.Year
            Now.Month = Date.Now.Month
            Now.Week = Convert_Days_ToWeeks(Date.Now.DayOfYear)
            Now.Day = Date.Now.Day
            Now.Hour = Date.Now.Hour
            Now.Minutes = Date.Now.Minute
            Now.Seconds = Date.Now.Second
            Now.Milliseconds = Date.Now.Millisecond
            'Step 2 Conversion


            If Intervals >= 31556952000 Then
                'is year







            Else
                'smaller than a year
                If Intervals < 31556952000 And Intervals >= 2629746000 Then
                    'it's at least 1 month
                Else
                    'smaller than a month
                    If Intervals < 262974600 And Intervals >= 604800000 Then
                        'its at least 1 week
                    Else
                        'smaller than a week
                        If Intervals < 604800000 And Intervals >= 86400000 Then
                            'it's at least a day
                        Else
                            'smaller than a day
                            If Intervals < 86400000 And Intervals >= 3600000 Then
                                'its at least an hour
                            Else
                                'smaller than an hour
                                If Intervals < 3600000 And Intervals >= 60000 Then
                                    'its at least a minute
                                Else
                                    'smaller than a minute
                                    If Intervals < 60000 And Intervals >= 1000 Then
                                        'its at least a second 
                                    Else
                                        'smaller than a second
                                        If Intervals < 1000 And Intervals > -1 Then
                                            'its at least millisecond
                                        Else
                                            'value is 00:00:00:00:00:00:00
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If

                End If
            End If



            Year = Int(Intervals / 31556952000)
            Month = Int(Intervals / 2629746000)
            Week = Int(Intervals / 604800000)
            Day = Int(Intervals / 86400000)
            Hour = Int(Intervals / 3600000)
            Minutes = Int(Intervals / 60000)
            Seconds = Int(Intervals / 1000)
            Milliseconds = Intervals - (31556952000 + 2629746000 + 604800000 + 86400000 + 3600000 + 60000 + 1000)
        End Sub
        Public Shared Function Convert_Intervals_ToString(ByVal Intervals As ULong) As TimeInfo
            Dim BackupInterval As ULong = Intervals
            Dim LeftYears As ULong = 0
            Dim LeftMonth As ULong = 0
            Dim LeftWeek As ULong = 0
            Dim LeftDay As ULong = 0
            Dim LeftHour As ULong = 0
            Dim LeftMinutes As ULong = 0
            Dim LeftSecond As ULong = 0
            Dim LeftMillisecond As ULong = 0

            Dim YearToMilliSecond As ULong = 31556952000
            Dim MonthToMilliSecond As ULong = 2629746000
            Dim WeekToMilliSecond As ULong = 604800000
            Dim DayToMilliSecond As ULong = 86400000
            Dim HourToMilliSecond As ULong = 3600000
            Dim MinutesToMilliSecond As ULong = 60000
            Dim SecondsToMilliSecond As ULong = 1000
            Dim iYear As Double '= Int(Intervals / 31556952000)
            Dim iMonth As Double ' = Int(Intervals / 2629746000)
            Dim iWeek As Double '= Int(Intervals / 604800000)
            Dim iDay As Double '= Int(Intervals / 86400000)
            Dim iHour As Double ' = Int(Intervals / 3600000)
            Dim iMinutes As Double ' = Int(Intervals / 60000)
            Dim iSeconds As Double '= Int(Intervals / 1000)
            Dim iMilliSeconds As Double
            '  If Intervals >= YearToMilliSecond Then
            'is year

            '>Years
            iYear = Int(Intervals / YearToMilliSecond)
            'Storing left over
            LeftYears = (Intervals / YearToMilliSecond) - iYear
            'Getting new intervals value
            Intervals = (LeftYears * YearToMilliSecond)

            '>Months
            iMonth = Int(Intervals / MonthToMilliSecond)
            'Storing left over
            LeftMonth = (Intervals / MonthToMilliSecond) - iMonth
            'Getting new intervals value
            Intervals = (LeftMonth * MonthToMilliSecond)

            '>Weeks
            iWeek = Int(LeftYears / WeekToMilliSecond)
            'Storing left over
            LeftWeek = (Intervals / WeekToMilliSecond) - iWeek

            '>Days
            iDay = Int(LeftMonth / DayToMilliSecond)
            'Storing left over
            LeftDay = (Intervals / DayToMilliSecond) - iDay
            'Getting new intervals value
            Intervals = (LeftDay * DayToMilliSecond)

            '>Hours
            iHour = Int(Intervals / HourToMilliSecond)
            'Storing left over
            LeftHour = (Intervals / HourToMilliSecond) - iHour
            'Getting new intervals value
            Intervals = (LeftHour * HourToMilliSecond)

            '>Minutes
            iMinutes = Int(Intervals / MinutesToMilliSecond)
            'Storing left over
            LeftMinutes = (Intervals / MinutesToMilliSecond) - iMinutes
            'Getting new intervals value
            Intervals = (LeftMinutes * MinutesToMilliSecond)

            '>Seconds
            iSeconds = Int(Intervals / SecondsToMilliSecond)
            'Storing left over
            LeftSecond = (Intervals / SecondsToMilliSecond) - iSeconds
            'Getting new intervals value
            Intervals = (LeftSecond * SecondsToMilliSecond)
            iMilliSeconds = Intervals

            Dim Result As New TimeInfo()
            Result.Year = iYear
            Result.Month = iMonth
            Result.Week = iWeek
            Result.Day = iDay
            Result.Hour = iHour
            Result.Minutes = iMinutes
            Result.Seconds = iSeconds
            Result.Milliseconds = iMilliSeconds
            Return Result

        End Function
        Public Overrides Function ToString() As String
            '"00d 00h 00mn 00ss 00ms"
            If Year = 0 Then
                If Month = 0 Then
                    If Week = 0 Then
                        If Day = 0 Then
                            If Hour = 0 Then
                                If Minutes = 0 Then
                                    If Seconds = 0 Then
                                        If Milliseconds = 0 Then
                                            Return "00h 00mn 00ss 00ms"
                                        Else
                                            Return "00h 00mn 00ss " & Milliseconds & "ms"

                                        End If
                                    Else
                                        Return "00h 00mn " & Seconds & "ss " & Milliseconds & "ms"

                                    End If

                                Else
                                    Return "00h " & Minutes & "mn " & Seconds & "ss " & Milliseconds & "ms"

                                End If
                            Else
                                Return Hour & "h " & Minutes & "mn " & Seconds & "ss " & Milliseconds & "ms"

                            End If
                        Else
                            Return Day & "d " & Hour & "h " & Minutes & "mn " & Seconds & "ss " & Milliseconds & "ms"

                        End If
                    Else
                        Return Week & "w " & Day & "d " & Hour & "h " & Minutes & "mn " & Seconds & "ss " & Milliseconds & "ms"

                    End If
                Else
                    Return Month & "m " & Week & "w " & Day & "d " & Hour & "h " & Minutes & "mn " & Seconds & "ss " & Milliseconds & "ms"

                End If
            Else
                Return Year & "y " & Month & "m " & Week & "w " & Day & "d " & Hour & "h " & Minutes & "mn " & Seconds & "ss " & Milliseconds & "ms"
            End If
        End Function






    End Class
#End Region
#Region "|08.06| <Class> [MusicInfo]"
    Public Class MusicInfo
        Private _Artist As String
        Public Property Artist() As String
            Get
                Return _Artist
            End Get
            Set(ByVal value As String)
                _Artist = value
            End Set
        End Property
        Private _SongName As String
        Public Property SongName() As String
            Get
                Return _Artist
            End Get
            Set(ByVal value As String)
                _Artist = value
            End Set
        End Property
        Private _Path As String
        Public Property Path() As String
            Get
                Return _Path
            End Get
            Set(ByVal value As String)
                _Path = value
            End Set
        End Property

        Public Sub New(ByVal FilePath As String)
            If FilePath = "" Then
            Else
                Path = FilePath
                Dim fs As FileStream = New FileStream(Path, FileMode.Open)
                'Seek to the Last 128 bytes

                fs.Seek(-128, SeekOrigin.End)
                Dim TagBytes(2) As Byte

                fs.Read(TagBytes, 0, 3)
                'Get the Tag

                Dim tag As String = System.Text.Encoding.Default.GetString(TagBytes)

                If (tag.ToUpper().Equals("TAG")) Then

                    'Get the title of this song.

                    Dim TitleBytes(30) As Byte

                    fs.Read(TitleBytes, 0, 30)

                    Dim Title As String = System.Text.Encoding.Default.GetString(TitleBytes)

                    'Get the Artist of this song.

                    Dim ArtistBytes(30) As Byte

                    fs.Read(ArtistBytes, 0, 30)

                    Dim Artist As String = System.Text.Encoding.Default.GetString(ArtistBytes)



                    'Construct Mp3Song object.



                    With Me
                        .SongName = Title
                        .Artist = Artist
                    End With
                Else

                    ' Throw New FormatException("The Format is not a MP3 Format")
                End If
                fs.Close()
            End If

        End Sub
        Public Overrides Function ToString() As String
            Return "<" & Artist & " | " & SongName & "> "
        End Function
    End Class
    Public Function List_Music_FromFolder(ByVal FolderPath As String, ByVal Search As IO.SearchOption) As List(Of MusicInfo)
        Dim Result As New List(Of MusicInfo)
        Dim Fol As New IO.DirectoryInfo(FolderPath)
        For Each f As IO.FileInfo In Fol.EnumerateFiles("*.mp3", Search)
            Dim Mus1 As New MusicInfo(f.FullName)
            Result.Add(Mus1)
        Next
        Return Result
    End Function
#End Region
#End Region
#Region "|9| [Constante]"
    Public Const EndRegion As String = "#End Region" & vbNewLine
    Public Const DrawLine As String = "___________________________________________________________________________________________"
    Public Const DrawPointedLine As String = ".................................................................................................................."

#End Region
#Region "|10| [Event]"

#End Region
#Region "|11| [Declare]"

#End Region
#Region "|12| [Delegate]"

#End Region
#End Region
End Module
