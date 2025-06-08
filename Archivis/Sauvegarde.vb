Imports System.ComponentModel

Public Class Sauvegarde
    Private Sub Sauvegarde_Load(sender As Object, e As EventArgs) Handles Me.Load
        Btn_Refresh.PerformClick()
        Timer1.Start()
    End Sub


    Private _CurrentProfile As Archives.Profile
    Public Property CurrentProfile() As Archives.Profile
        Get
            Return _CurrentProfile
        End Get
        Set(ByVal value As Archives.Profile)
            _CurrentProfile = value
            If Not IsNothing(value) Then
                If Not IsNothing(value.Source) Then
                    Me.Input_Source.ActiveDir = New SmartCoder.M_FileManager.Folder(value.Source)
                End If
                If Not IsNothing(value.Destination) Then
                    Me.Input_Destination.ActiveDir = New SmartCoder.M_FileManager.Folder(value.Destination)
                End If
            End If
        End Set
    End Property
    Public Property List As List(Of Archives.Profile)
    Private Sub Btn_Refresh_Click(sender As Object, e As EventArgs) Handles Btn_Refresh.Click
        ' CurrentProfile = New Archives.Profile
        Dim C As New Archives.Profile
        List = New List(Of Archives.Profile)
        List = C.List
        Input_Profile.DataSource = List

    End Sub

    Private Sub Input_Profile_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Input_Profile.SelectedIndexChanged
        If Input_Profile.SelectedIndex > -1 Then
            CurrentProfile = List(Input_Profile.SelectedIndex)
        End If
    End Sub

    Private Sub Btn_Start_Click(sender As Object, e As EventArgs) Handles Btn_Start.Click
        Timer1.Stop()
        Pbar.Value = 0
        Output_Console.Text = ""
        PrepareTransfert()
    End Sub
    Dim List_Transfert As New List(Of Archives.Transfert)
    Dim Index As Integer = 0
    Dim CurrentTransfert As New Archives.Transfert

    Public Sub PrepareTransfert()
        CurrentTransfert = New Archives.Transfert
        With CurrentTransfert
            .Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.Db_Backup_FilePath, My.Settings.Db_Backup_Password))
            .ID = Index
            .Profile = CurrentProfile.Name
            .Source = Input_Source.LV.Items(Index).Tag.Target
            .Destination = CurrentProfile.Destination & "\" & Now.Year & "\" & IIf(Now.Month < 10, "0" & Now.Month, Now.Month) & "\" & IIf(Now.Day < 10, "0" & Now.Day, Now.Day) & "\" & CurrentProfile.Name & SmartCoder.RemoveCharacter(.Source, CurrentProfile.Source)
            .Tag = Input_Source.LV.Items(Index).Tag
            .Size = 0
            .Etat = "Not Started"
        End With
        'Verify that Destination is Reachable
        If Not IO.Directory.Exists(IO.Path.GetDirectoryName(CurrentTransfert.Destination)) Then
            Try
                IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(CurrentTransfert.Destination))
            Catch ex As Exception
                ' MsgBox(ex.Message)
            End Try
        End If
        If IO.Directory.Exists(IO.Path.GetDirectoryName(CurrentTransfert.Destination)) Then
            If BW.IsBusy Then
                BW.CancelAsync()
            Else
                BW.RunWorkerAsync()
            End If
        End If
    End Sub

    Private Sub BW_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW.DoWork
        BW.WorkerSupportsCancellation = True
        Input_Status.Text = "En cours"
        If Not IsNothing(CurrentTransfert) Then

            If Not IsNothing(CurrentTransfert.Tag) Then

                '  If TypeOf (CurrentTransfert.Tag) Is SmartCoder.Fichier Then
                Dim Fi As New SmartCoder.Fichier(CurrentTransfert.Tag.Target)
                Try
                    CurrentTransfert.Destination = CurrentProfile.Destination & "\" & Now.Year & "\" & IIf(Now.Month < 10, "0" & Now.Month, Now.Month) & "\" & IIf(Now.Day < 10, "0" & Now.Day, Now.Day) & "\" & CurrentProfile.Name & SmartCoder.RemoveCharacter(CurrentTransfert.Source, CurrentProfile.Source)
                    'MsgBox(IO.Path.GetDirectoryName(CurrentTransfert.Destination))
                    Fi.Copy(IO.Path.GetDirectoryName(CurrentTransfert.Destination),, True)
                    ' IO.File.Copy(Fi.Target, CurrentTransfert.Destination, True)
                    Output_Console.Text += "|" & SmartCoder.PrintTime() & "| |OK| |Fichier| : " & Fi.FileName & "|Source:| " & Fi.Target & " |Destination:| " & CurrentTransfert.Destination & vbNewLine
                    CurrentTransfert.Etat = "OK"
                Catch ex As Exception
                    Output_Console.Text += "|" & SmartCoder.PrintTime() & "| |PB| |Fichier| : " & Fi.FileName & "|Source:| " & Fi.Target & " |Destination:| " & CurrentTransfert.Destination & vbNewLine
                    CurrentTransfert.Etat = ex.Message

                    End Try
                    Output_Console.ScrollToCaret()
                '  ElseIf TypeOf (CurrentTransfert.tag) Is SmartCoder.Folder Then
                ' Dim Fo As New SmartCoder.Folder(CurrentTransfert.Source)
                'Try
                'IO.Directory.CreateDirectory(CurrentTransfert.Destination)
                'Output_Console.Text += "|" & SmartCoder.PrintTime() & "|OK| |Répertoire Copier : " & Fo.FolderName & "|Source:|" & Fo.Target & "|Destination:|" & CurrentTransfert.Destination & vbNewLine
                'CurrentTransfert.Etat = "OK"
                '
                'Catch ex As Exception
                'Output_Console.Text += "|" & SmartCoder.PrintTime() & "|PB| |Répertoire non Copier : " & Fo.FolderName & "|Source:|" & Fo.Target & "|Destination:|" & CurrentTransfert.Destination & vbNewLine
                'CurrentTransfert.Etat = ex.Message
                '
                'End Try
                'Output_Console.ScrollToCaret()
            End If



        End If
    End Sub
    Public JobDone As Boolean = False
    Private Sub BW_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BW.RunWorkerCompleted
        CurrentTransfert.Add()


        ' 
        List_Transfert.Add(CurrentTransfert)
        Output_Percentage.Text = "(" & Math.Round((Index / Input_Source.Total.Value) * 100, 2) & " %)"
        Output_Console.ScrollToCaret()

        If Index + 1 >= Input_Source.Total.Value Then
            Pbar.Value = (Index / Input_Source.Total.Value) * 100
            Input_Destination.Btn_Refresh.PerformClick()
            Input_Status.Text = "Terminé"

            Current_SavingEntry = New Archives.Save_Entry()
            List_SavedEntries = New List(Of Archives.Save_Entry)
            List_SavedEntries = Current_SavingEntry.List

            Dim Lti As New List(Of Archives.Save_Entry)
            For Each Element As Archives.Save_Entry In List_SavedEntries
                If Element.Profile = CurrentProfile.Name Then
                    Lti.Add(Element)
                End If
            Next

            With Current_SavingEntry
                .Name = CurrentProfile.Name & "_" & Now.Year & "_" & Now.Month & "_" & Now.Date
                .Profile = CurrentProfile.Name
                .DateSaved = Now
                .Root = Input_Destination.Input_Dir.Text
                .Origine = Input_Source.Input_Dir.Text
                .ProfileIndex = Lti.Count
                If CurrentProfile.NumberofOccurences >= .ProfileIndex Then
                    If Lti.Count - 1 > 1 Then

                        Lti(0).CandidateForDelete = True
                        Lti(0).Save()
                        Dim Po As New Archives.Archives_Data
                        Dim Ltpo As New List(Of Archives.Archives_Data)
                        For Each Element As Archives.Archives_Data In Po.List
                            If Element.Save_Entry = Lti(0).Name Then
                                Ltpo.Add(Element)
                            End If
                        Next

                        For i = 0 To Ltpo.Count - 1
                            Dim Element As Archives.Archives_Data = Ltpo(i)
                            Try
                                IO.File.Delete(Element.Root)
                                Element.Etat = "Effacer"
                            Catch ex As Exception
                                Element.Etat = ex.Message
                            End Try
                            Element.Delete()
                        Next
                    End If

                End If
                Dim ISize As Double = 0
                Dim LtTransfert As New List(Of Archives.Transfert)
                Dim C As New Archives.Transfert
                Dim NewEntry As New Archives.Archives_Data
                Dim ListEntries As New List(Of Archives.Archives_Data)
                ListEntries = NewEntry.List
                LtTransfert = C.List
                For Each Element As Archives.Transfert In LtTransfert
                    If Element.Profile = CurrentProfile.Name Then
                        With NewEntry
                            .ID = Element.ID
                            .Save_Entry = Current_SavingEntry.Name
                            .Root = Element.Destination
                            .Origine = Element.Source
                            .Size = Element.Size
                            .Etat = "Archivé"
                            ISize += .Size
                        End With
                        NewEntry.Add()
                        Element.Delete()
                    End If
                Next
                .Size = ISize
                .Add()
            End With
            JobDone = True
            Dim Lt As New List(Of String)
            Lt.Add("saadry.dunkel@outlook.com")
            EmailInfo.SendReport(Output_Console.Text, "Backup Job of " & CurrentProfile.Name, Lt)
            SmartCoder.Jarvis.Speak("Saved Performed Successfully")
            Timer1.Start()

        Else
            Pbar.Value = (Index / Input_Source.Total.Value) * 100
            Index += 1
            PrepareTransfert()
        End If
    End Sub

    Private Sub Input_Profile_TextUpdate(sender As Object, e As EventArgs) Handles Input_Profile.TextUpdate

        '  CurrentProfile = List(Input_Profile.SelectedItem)
        'Input_Source.Btn_Refresh.PerformClick()

    End Sub
    Public Sub Run_Saving(ByVal P As Archives.Profile)
        Btn_Refresh.PerformClick()

        If Not IsNothing(P) Then
            CurrentProfile = New Archives.Profile
            CurrentProfile = P
            Input_Profile.Text = P.Name

            Input_Source.Text = P.Source
            Input_Destination.Text = P.Destination
            Index = -1
            Threading.Thread.Sleep(100)
            If BW2.IsBusy Then
            Else
                BW2.RunWorkerAsync()
            End If
        End If
    End Sub
    Private Sub BW2_DoWork(sender As Object, e As DoWorkEventArgs) Handles BW2.DoWork
        BW2.WorkerSupportsCancellation = True

        '  Input_Source.Btn_Refresh.PerformClick()
        Do Until Input_Source.JobDone = True

            Loop
        Index += 1
        Threading.Thread.Sleep(100)

        SmartCoder.Jarvis.Speak("Starting transfert")
        Btn_Start.PerformClick()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Input_Source.JobDone = True And Input_Source.LV.Items.Count - 1 > 1 Then
            Btn_Start.PerformClick()
        End If
    End Sub
End Class
