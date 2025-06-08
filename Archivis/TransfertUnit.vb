Imports System.ComponentModel

Public Class TransfertUnit
    Private Sub TransfertUnit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        RefreshData()



    End Sub

    Private _Current As Archives.Profile
    Public Property Current() As Archives.Profile
        Get
            Return _Current
        End Get
        Set(ByVal value As Archives.Profile)
            If Not IsNothing(value) Then
                Input_Profile.SelectedItem = value
                Input_Source.Text = value.Source
                Input_Direction.Text = value.Destination
                List_Files()

            End If
            _Current = value
        End Set
    End Property
    Public Property ListFiles As New List(Of Archives.Transfert)
    Dim Y As Double = Now.Year
    Dim M As String = If(Now.Month < 10, "0" & Now.Month, Now.Month)
    Dim D As String = If(Now.Day < 10, "0" & Now.Day, Now.Day)
    Dim StrDay As String = "\" & Y & "\" & M & "\" & D & "\"
    Dim PackageSize As Double = 0
    Public Property ReadyToFire As Boolean = False
    Public Sub List_Files()
        ListFiles = New List(Of Archives.Transfert)
        Y = Now.Year
        M = If(Now.Month < 10, "0" & Now.Month, Now.Month)
        D = If(Now.Day < 10, "0" & Now.Day, Now.Day)
        StrDay = "\" & Y & "\" & M & "\" & D & "\"
        If Input_Direction.Value = False Then
            ' On mode saving
            Input_TotalItems.Value = 0

            If Not IsNothing(Current) Then
                Dim Code As String = Y & "_" & M & "_" & D & "_" & Current.Name
                StrDay += Code
                'I:\Test\2019\07\14\2019_07_14_SmartOffice\SmartOffice.sln
                If IO.Directory.Exists(Current.Source) Then
                    Dim Dir As New SmartCoder.Folder(Current.Source)
                    Dim i As Integer = 0
                    Input_Destination.Text = Current.Destination & StrDay
                    For Each Fi As SmartCoder.Fichier In Dir.GetFichiers("*.*", IO.SearchOption.AllDirectories)
                        Dim NewPath As String = Current.Destination & StrDay & SmartCoder.RemoveCharacter(Fi.Target, Current.Source)
                        Dim T As New Archives.Transfert(i, Current.Name, Fi.Target, NewPath, Fi.FileSize.Raw, "StandBye")
                        T.Tag = Fi
                        PackageSize += Fi.FileSize.Raw
                        ListFiles.Add(T)
                        '  T.Add()
                        i += 1
                        Input_TotalItems.Value += 1
                    Next
                End If
            End If

        ElseIf Input_Direction.Value = True Then

            If Not IsNothing(Current) Then
                Dim Code As String = Y & "_" & M & "_" & D & "_" & Current.Name
                StrDay += Code '& "\"
                'I:\Test
                'I:\Test\Y\M\D\Y_M_D_Name\...
                Input_TotalItems.Value = 0
                If IO.Directory.Exists(Current.Destination & StrDay) Then
                    Dim Dir As New SmartCoder.Folder(Current.Destination & StrDay)
                    Input_Destination.Text = Current.Destination & StrDay
                    Dim i As Integer = 0
                    For Each Fi As SmartCoder.Fichier In Dir.GetFichiers("*.*", IO.SearchOption.AllDirectories)
                        Dim OldPath As String = Current.Source & SmartCoder.RemoveCharacter(Fi.Target, Current.Destination & StrDay)
                        Dim T As New Archives.Transfert(i, Current.Name, Fi.Target, OldPath, Fi.FileSize.Raw, "StandBye for restauration")
                        PackageSize += Fi.FileSize.Raw
                        T.Tag = Fi
                        '  T.Add()
                        ListFiles.Add(T)
                        i += 1
                        Input_TotalItems.Value += 1
                    Next
                End If
            End If

        End If
        Input_Size.Text = New SmartCoder.SizeInfo(PackageSize, SmartCoder.M_FileManager.SizeInfo.Scales.Gigabyte).Display
        SGC.PrimaryGrid.DataSource = ListFiles
        ReadyToFire = True
    End Sub
    Public Sub RefreshData()
        If IsNothing(Current_Profiles) Then
            Current_Profiles = New Archives.Profile
        End If
        If IsNothing(ListProfiles) Then
            ListProfiles = New List(Of Archives.Profile)
        End If
        ListProfiles = Current_Profiles.List
        Input_Profile.DataSource = ListProfiles
        'Current = ListProfiles(0)

    End Sub

    Private Sub Btn_Direction_Click(sender As Object, e As EventArgs) Handles Btn_Direction.Click
        If Input_Direction.Value = False Then
            'Sauvegarde
            Btn_Direction.Image = My.Resources._next
            List_Files()
        Else
            Btn_Direction.Image = My.Resources.back
            List_Files()
        End If
    End Sub

    Private Sub Input_Direction_ValueChanged(sender As Object, e As EventArgs) Handles Input_Direction.ValueChanged
        If Input_Direction.Value = False Then
            Btn_Direction.Image = My.Resources._next
        Else
            Btn_Direction.Image = My.Resources.back
        End If
    End Sub

    Private Sub Input_Profile_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Input_Profile.SelectedIndexChanged
        If Input_Profile.SelectedIndex > -1 Then
            '    Current = ListProfiles(Input_Profile.SelectedIndex)
            ' Input_Destination.Text = Current.Destination
        End If
    End Sub
    Public Success As Double = 0
    Public Failure As Double = 0
    Public Success_Percentage As Double = 0
    Public Class Bugs
        Public Property Message As String
        Public Property Ex As Exception
        Public Property Origine As String
        Public Property Destination As String
        Public Property Time As DateTime
        Public Sub New()

        End Sub
        Public Sub New(ByRef Ex As Exception, Optional ByVal Msg As String = "", Optional ByVal Origine As String = "", Optional ByVal Destination As String = "")
            With Me
                .Ex = Ex
                .Message = Msg
                .Origine = Origine
                .Destination = Destination
                .Time = Now
            End With
        End Sub
        Public Function PrintReport() As String
            If IsNothing(Ex) Then
                Return "Exception captured " & vbNewLine &
                      "Problem has arisen during transfert : " & vbNewLine &
                      "<Origine> " & Origine & " </Origine>" & vbNewLine &
                      "<Destination> " & Destination & " </Destination>" & vbNewLine &
                      "-------------------------------------------------------------------------" & vbNewLine
            Else
                Return "Exception captured " & vbNewLine &
                Ex.Message & vbNewLine &
                "Problem has arisen during transfert : " & vbNewLine &
                "<Origine> " & Origine & " </Origine>" & vbNewLine &
                "<Destination> " & Destination & " </Destination>" & vbNewLine &
                "-------------------------------------------------------------------------" & vbNewLine
            End If

        End Function
    End Class
    Public List_Errors As New List(Of Bugs)
    Dim Unit As Double = 0
    Dim SpeedTotal As Double = 0
    Public Actual As Archives.Save_Entry
    Private Sub BW_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW.DoWork
        ReadyToFire = False

        BW.WorkerSupportsCancellation = True
        Unit = 1
        SpeedTotal = 0
        Success = 0
        Failure = 0
        Success_Percentage = 0

        Input_Report.Text = ""
        Input_Report.Text += "______________________________________________________________________________" & vbNewLine &
                          "Date : " & Now.ToShortDateString & " / " & Now.ToLongTimeString & "   <Report> " & Current.Name & " <Report> " & vbNewLine &
                          ">                                                                            <" & vbNewLine &
                          "Taille : " & New SmartCoder.SizeInfo(PackageSize, SmartCoder.M_FileManager.SizeInfo.Scales.Gigabyte).Display & vbNewLine &
                          "Nombre de Fichier : " & Input_TotalItems.Value & vbNewLine &
                          ">                                                                            <" & vbNewLine &
                          "|Procédure:|" & vbNewLine &
                          " 1| Chaque transfert sera enregistré dans la base de donnée en rubrique Transfert." & vbNewLine &
                          " 2| Durant la copie des éléments, chaque copie valider sera transformé en " & vbNewLine &
                          "    Archive_Data alors que les éléments invalidé enregistrerons l'erreur et " & vbNewLine &
                          "    resterons en attente dans la base de donnée." & vbNewLine &
                          " 3| Une analyse de l'espace disponible sera lancer. Si l'espace diminue en dessous de " & vbNewLine &
                          "    20 % de marge, le système devrait prendre en compte l'effacement des plus vieille" & vbNewLine &
                          "    sauvegardes." & vbNewLine &
                          " 4| Une fois l'opération terminée, cet email pour informer l'administrateur." & vbNewLine &
                          "|Fin de Procédure:|" & vbNewLine &
                          "     Etape 1: OK" & vbNewLine &
                          "     Etape 2: En Cours ..." & vbNewLine

        Dim LtFiles_OK As String = ""
        Dim LtFiles_PB As String = ""
        Dim Code As String = Y & "_" & M & "_" & D & "_" & Current.Name

        List_Errors = New List(Of Bugs)
        If Not IsNothing(Actual) Then
            Actual.Add()

        End If
        L_Operation.Text = "Copie du fichier : "
        For Each T As Archives.Transfert In ListFiles
            Output_Speed.Value = Math.Round((Pbar.Maximum - Pbar.Value) / (ElapsedTime2.Seconds), 2)
            SpeedTotal += (Pbar.Maximum - Pbar.Value) / IIf(ElapsedTime2.Seconds = 0, 1, ElapsedTime2.Seconds)
            Unit += 1
            Average_Speed.Text = Math.Round(SpeedTotal / Unit, 2)
            If Math.Round(Output_Speed.Value, 0) < 100 Then
                Threading.Thread.Sleep(100)

            ElseIf Math.Round(Output_Speed.Value, 0) < 50 Then

                Threading.Thread.Sleep(150)
            ElseIf Math.Round(Output_Speed.Value, 0) < 25 Then

                Threading.Thread.Sleep(200)
            ElseIf Math.Round(Output_Speed.Value, 0) < 10 Then

                Threading.Thread.Sleep(250)
            End If
            Dim Origine As String = T.Source
            Dim Destination As String = T.Destination
            L_Percentage.Text = "( " & Math.Round((Pbar.Value / Pbar.Maximum) * 100, 2) & " % )"
            If Not IO.Directory.Exists(IO.Path.GetDirectoryName(Destination)) Then
                IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(Destination))
            End If

            Try
                L_FileName.Text = IO.Path.GetFileName(Origine)

            Catch ex As Exception

            End Try
            'Shell("Cmd.exe /C Copy Xcopy " & Origine & "\*.* " & Destination & " /E /V /J /Q /Y")
            Try
                IO.File.Copy(Origine, Destination, True)
            Catch ex As Exception

            End Try
            Pbar.Value += 1
            If BW.CancellationPending Then
                e.Cancel = True
                Pbar.Value = 0
                ReadyToFire = False
                Exit For
            End If

        Next
        Pbar.Value = 0
        L_Operation.Text = "Vérification du fichier : "

        For Each T As Archives.Transfert In ListFiles
            Dim Origine As String = T.Source
            Dim Destination As String = T.Destination
            If IO.File.Exists(Destination) Then
                Success += 1
                Success_Percentage = (Success / Input_TotalItems.Value) * 100
                LtFiles_OK += " |OK| <Origine> " & Origine & " | <Destination> " & Destination & vbNewLine
            Else
                LtFiles_PB += "|PB|  <Origine> " & Origine & " | <Destination> " & Destination & vbNewLine
                Failure += 1
            End If
            Pbar.Value += 1
            L_Percentage.Text = "( " & Math.Round((Pbar.Value / Pbar.Maximum) * 100, 2) & " % )"
            If BW.CancellationPending Then
                e.Cancel = True
                Pbar.Value = 0
                ReadyToFire = False
                Exit For
            End If
            L_FileName.Text = Destination
            SuccessRate.Value = Success_Percentage
            ErrorCounter.Value = Failure
            FileTransfertCount.Value = Pbar.Value
        Next
        'LtFiles &
        Input_Report.Text += "     Etape 2: OK" & vbNewLine &
                            "       <Success> " & Success & " <Failures> " & Failure & " <Overall Success> " & Math.Round(Success_Percentage, 2) & " %" & vbNewLine &
                            "     " & vbNewLine &
                            "     Rapport d'avari:" & vbNewLine &
                            "    <<Erreur de Transfert>> " & vbNewLine &
                            LtFiles_PB & vbNewLine &
                            "    |Transfert Normal | " & vbNewLine &
                            LtFiles_OK & vbNewLine &
                            " End of Report. At " & Now.ToShortDateString & "\" & Now.ToLongTimeString & vbNewLine



        LtFiles_OK = ""
        LtFiles_PB = ""
    End Sub
    Dim ElapsedTime As TimeSpan
    Dim StartTime As DateTime
    Dim EndTime As DateTime
    Private Sub Input_TotalItems_ValueChanged(sender As Object, e As EventArgs) Handles Input_TotalItems.ValueChanged
        Pbar.Maximum = Input_TotalItems.Value
    End Sub

    Private Sub Btn_Play_Click(sender As Object, e As EventArgs) Handles Btn_Play.Click
        If BW.IsBusy Then
            Btn_Stop.PerformClick()
        Else
            H.Value = 0
            Mn.Value = 0
            SS.Value = 0
            MS.Value = 0
            Timer1.Start()
            StartTime = Now
            BW.RunWorkerAsync()

        End If
    End Sub

    Private Sub BW_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BW.RunWorkerCompleted
        EndTime = Now
        ElapsedTime = EndTime.Subtract(StartTime)
        Timer1.Stop()
        Input_Report.Text += " Sauvegarde effectuée en " & ElapsedTime.Hours & " Heure et " & ElapsedTime.Minutes & "Minutes |Ss " & ElapsedTime.Seconds & " |ms" & ElapsedTime.Milliseconds & vbNewLine &
            "Avec une vitesse moyenne de " & Average_Speed.Text & " Fichier par secondes."

        Dim S As New Archives.Save_Entry(Y & "_" & M & "_" & D & "_" & Current.Name, Current.Name, Now, Current.Destination, Current.Source, 0, New SmartCoder.SizeInfo(PackageSize, SmartCoder.M_FileManager.SizeInfo.Scales.Gigabyte).Value, False)
        SmartCoder.ShowPropertyOf(S)

        S.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.Db_Backup_FilePath, My.Settings.Db_Backup_Password))
        S.Add()

        If Not IsNothing(Actual) Then
            If Not IsNothing(Actual.ListArchives) Then
                If Actual.ListArchives.Count - 1 > 1 Then


                End If
            End If
        End If
        If List_Errors.Count - 1 > 1 Or ListFiles.Count - 1 < 1 Then
            EmailInfo.SendReport(Input_Report.Text, "[PB] Report of backup of " & My.Computer.Name)
        Else
            EmailInfo.SendReport(Input_Report.Text, "[OK] Report of backup of " & My.Computer.Name)

        End If
        GC.Collect()
        H.Value = 0
        Mn.Value = 0
        SS.Value = 0
        MS.Value = 0
        ' Input_Report.Text = ""
        Input_Source.Text = ""
        Input_Direction.Text = ""
        Input_Profile.Text = ""
        Pbar.Value = 0
        L_Percentage.Text = "( 0.00 %)"
        L_FileName.Text = ""
        Success = 0
        SuccessRate.Value = 0
        Success_Percentage = 0
        Output_Speed.Value = 0
        List_Errors = New List(Of Bugs)
        ErrorCounter.Value = 0
        Input_TotalItems.Value = 0
        FileTransfertCount.Value = 0
        ListFiles = New List(Of Archives.Transfert)
    End Sub

    Private Sub Btn_Stop_Click(sender As Object, e As EventArgs) Handles Btn_Stop.Click
        Timer1.Stop()
        BW.CancelAsync()
        Pbar.Value = 0
    End Sub
    Dim ElapsedTime2 As TimeSpan
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim D As DateTime = Now
        ElapsedTime2 = D.Subtract(StartTime)

        H.Value = ElapsedTime2.Hours
        Mn.Value = ElapsedTime2.Minutes
        SS.Value = ElapsedTime2.Seconds
        MS.Value = ElapsedTime2.Milliseconds
        L_Speed.Text = " Fichiers par secondes"
        Output_Speed.Value = Math.Round((Pbar.Maximum - Pbar.Value) / (ElapsedTime2.Seconds), 2)
    End Sub

    Private Sub Btn_Index_Click(sender As Object, e As EventArgs) Handles Btn_Index.Click
        If Not IsNothing(Input_Profile.SelectedItem) Then
            Current = Input_Profile.SelectedItem
            Input_Source.Text = Current.Source
            Input_Destination.Text = Current.Destination

            If BW_Index.IsBusy Then
            Else
                Btn_Play.Enabled = False
                Btn_Index.Enabled = False
                BW_Index.RunWorkerAsync()
            End If
        End If
    End Sub

    Private Sub BW_Index_DoWork(sender As Object, e As DoWorkEventArgs) Handles BW_Index.DoWork
        ListFiles = New List(Of Archives.Transfert)
        Y = Now.Year
        M = If(Now.Month < 10, "0" & Now.Month, Now.Month)
        D = If(Now.Day < 10, "0" & Now.Day, Now.Day)
        StrDay = "\" & Y & "\" & M & "\" & D & "\"
        If Input_Direction.Value = False Then
            ' On mode saving
            Input_TotalItems.Value = 0

            If Not IsNothing(Current) Then
                Dim Code As String = Y & "_" & M & "_" & D & "_" & Current.Name
                StrDay += Code
                'I:\Test\2019\07\14\2019_07_14_SmartOffice\SmartOffice.sln
                If IO.Directory.Exists(Current.Source) Then
                    Dim Dir As New SmartCoder.Folder(Current.Source)
                    Dim i As Integer = 0
                    Input_Destination.Text = Current.Destination & StrDay
                    For Each Fi As SmartCoder.Fichier In Dir.GetFichiers("*.*", IO.SearchOption.AllDirectories)
                        Dim NewPath As String = Current.Destination & StrDay & SmartCoder.RemoveCharacter(Fi.Target, Current.Source)
                        Dim T As New Archives.Transfert(i, Current.Name, Fi.Target, NewPath, Fi.FileSize.Raw, "StandBye")
                        T.Tag = Fi
                        PackageSize += Fi.FileSize.Raw
                        ListFiles.Add(T)
                        '  T.Add()
                        i += 1
                        Input_TotalItems.Value += 1
                    Next
                End If
            End If

        ElseIf Input_Direction.Value = True Then

            If Not IsNothing(Current) Then
                Dim Code As String = Y & "_" & M & "_" & D & "_" & Current.Name
                StrDay += Code '& "\"
                'I:\Test
                'I:\Test\Y\M\D\Y_M_D_Name\...
                Input_TotalItems.Value = 0
                If IO.Directory.Exists(Current.Destination & StrDay) Then
                    Dim Dir As New SmartCoder.Folder(Current.Destination & StrDay)
                    Input_Destination.Text = Current.Destination & StrDay
                    Dim i As Integer = 0
                    For Each Fi As SmartCoder.Fichier In Dir.GetFichiers("*.*", IO.SearchOption.AllDirectories)
                        Dim OldPath As String = Current.Source & SmartCoder.RemoveCharacter(Fi.Target, Current.Destination & StrDay)
                        Dim T As New Archives.Transfert(i, Current.Name, Fi.Target, OldPath, Fi.FileSize.Raw, "StandBye for restauration")
                        PackageSize += Fi.FileSize.Raw
                        T.Tag = Fi
                        '  T.Add()
                        ListFiles.Add(T)
                        i += 1
                        Input_TotalItems.Value += 1
                    Next
                End If
            End If

        End If
        Input_Size.Text = New SmartCoder.SizeInfo(PackageSize, SmartCoder.M_FileManager.SizeInfo.Scales.Gigabyte).Display
    End Sub
    Public Property Autorun As Boolean = False
    Private Sub BW_Index_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BW_Index.RunWorkerCompleted
        Try
            SGC.PrimaryGrid.DataSource = ListFiles

        Catch ex As Exception

        End Try
        Btn_Index.Enabled = True

        Btn_Play.Enabled = True
        ReadyToFire = True
        If Autorun = True Then
            Btn_Play.PerformClick()
        End If
    End Sub


End Class
