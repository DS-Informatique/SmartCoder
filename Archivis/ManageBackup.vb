Imports System.ComponentModel

Public Class ManageBackup
    Private Sub ManageBackup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        Dim D As New NewBackup
        D.Dock = DockStyle.Fill
        D.Btn_Refresh.RaiseClick()
        Panel_Gestion.Controls.Add(D)
        Savior = New TransfertUnit
        Savior.Dock = DockStyle.Fill
        PanelEx4.Controls.Add(Savior)
        If My.Settings.Db_Backup_FilePath.Length > 1 Then
            U_DataBase1.Txt_FilePath.Text = My.Settings.Db_Backup_FilePath
            U_DataBase1.Password.Text = My.Settings.Db_Backup_Password
            RefreshWork()
        End If
    End Sub
    Public Save As New TransfertUnit
    Public Savior As TransfertUnit
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        AnalogClockControl1.Value = Now
        If Now.DayOfWeek = DayOfWeek.Monday Then
            Current_DayOfWeek.Text = "Lundi"
        ElseIf Now.DayOfWeek = DayOfWeek.Tuesday Then
            Current_DayOfWeek.Text = "Mardi"
        ElseIf Now.DayOfWeek = DayOfWeek.Wednesday Then
            Current_DayOfWeek.Text = "Mercredi"
        ElseIf Now.DayOfWeek = DayOfWeek.Thursday Then
            Current_DayOfWeek.Text = "Jeudi"
        ElseIf Now.DayOfWeek = DayOfWeek.Friday Then
            Current_DayOfWeek.Text = "Vendredi"
        ElseIf Now.DayOfWeek = DayOfWeek.Saturday Then
            Current_DayOfWeek.Text = "Samedi"
        ElseIf Now.DayOfWeek = DayOfWeek.Sunday Then
            Current_DayOfWeek.Text = "Dimanche"
        End If
        Current_Day.Value = Now.Day
        Current_Hour.Value = Now.Hour
        Current_Minutes.Value = Now.Minute
        Current_Month.Value = Now.Month
        Current_Second.Value = Now.Second
        Current_Year.Value = Now.Year
        If Current_Hour.Value = 0 And Current_Minutes.Value = 1 Then

            If BW_Refresh.IsBusy Then
            Else
                BW_Refresh.RunWorkerAsync()
            End If
        End If

        For i = 0 To LV.Items.Count - 1
            Dim H As Double = Val(LV.Items(i).SubItems(2).Text)
            Dim M As Double = Val(LV.Items(i).SubItems(3).Text)

            If H = Now.Hour And M - 5 = Now.Minute Then
                Savior.Autorun = True
                Savior.Current = LV.Items(i).Tag
                Savior.Btn_Index.PerformClick()
            End If


            If H = Now.Hour And M = Now.Minute Then


                ' Timer_Saved.Start()


                '   Dim St As New DevComponents.DotNetBar.SuperTabItem
                '   Dim P As New DevComponents.DotNetBar.SuperTabControlPanel
                '   St.ContainerControl = P
                '   Dim S As New Sauvegarde
                '  S.Dock = DockStyle.Fill
                '  Dim Panel As New DevComponents.DotNetBar.PanelEx
                '  Panel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
                ' Panel.Dock = DockStyle.Fill
                '  P.Controls.Add(Panel)
                '  Panel.Controls.Add(S)
                '  Current = LV.Items(i).Tag
                'S.Run_Saving(Current)
                Index = i
                If BW2.IsBusy Then
                Else
                    BW2.RunWorkerAsync()
                    '     Timer1.Stop()
                End If
                'MySauvegarde.Btn_Refresh.PerformClick()
                ' MySauvegarde.Input_Profile.SelectedIndex = i
                'MySauvegarde.Run_Saving(Current)
                'STC_Jobs.Tabs.Add(St)
            End If
        Next


    End Sub
    Private Sub Timer_Saved_Tick(sender As Object, e As EventArgs) Handles Timer_Saved.Tick

    End Sub
    Public ListOfWork As New List(Of Archives.Profile)
    Public Current As Archives.Profile
    Dim Index As Integer = 0
    Public Sub RefreshWork()
        ListOfWork = New List(Of Archives.Profile)
        Current = New Archives.Profile
        For Each P As Archives.Profile In Current.List
            If P.EveryDay = True Then
                ListOfWork.Add(P)
            Else
                If P.EveryWeek = True Then
                    If Now.DayOfWeek = DayOfWeek.Monday Then
                        If P.Monday = True Then
                            ListOfWork.Add(P)
                        End If
                    ElseIf Now.DayOfWeek = DayOfWeek.Tuesday Then
                        If P.Tuesday = True Then
                            ListOfWork.Add(P)
                        End If
                    ElseIf Now.DayOfWeek = DayOfWeek.Wednesday Then
                        If P.Wednesday = True Then
                            ListOfWork.Add(P)
                        End If
                    ElseIf Now.DayOfWeek = DayOfWeek.Thursday Then
                        If P.Thursday = True Then
                            ListOfWork.Add(P)
                        End If
                    ElseIf Now.DayOfWeek = DayOfWeek.Friday Then
                        If P.Friday = True Then
                            ListOfWork.Add(P)
                        End If
                    ElseIf Now.DayOfWeek = DayOfWeek.Saturday Then
                        If P.Saturday = True Then
                            ListOfWork.Add(P)
                        End If
                    ElseIf Now.DayOfWeek = DayOfWeek.Sunday Then
                        If P.Sunday = True Then
                            ListOfWork.Add(P)
                        End If
                    End If
                Else
                    If P.EveryMonth = True Then
                        If Now.Day = 1 Then
                            If P.Day_01 = True Then
                                ListOfWork.Add(P)
                            End If
                        ElseIf Now.Day = 2 Then
                            If P.Day_02 = True Then
                                ListOfWork.Add(P)
                            End If
                        ElseIf Now.Day = 3 Then
                            If P.Day_03 = True Then
                                ListOfWork.Add(P)
                            End If
                        ElseIf Now.Day = 4 Then
                            If P.Day_04 = True Then
                                ListOfWork.Add(P)
                            End If
                        ElseIf Now.Day = 5 Then
                            If P.Day_05 = True Then
                                ListOfWork.Add(P)
                            End If
                        ElseIf Now.Day = 6 Then
                            If P.Day_06 = True Then
                                ListOfWork.Add(P)
                            End If
                        ElseIf Now.Day = 7 Then
                            If P.Day_07 = True Then
                                ListOfWork.Add(P)
                            End If
                        ElseIf Now.Day = 8 Then
                            If P.Day_08 = True Then
                                ListOfWork.Add(P)
                            End If
                        ElseIf Now.Day = 9 Then
                            If P.Day_09 = True Then
                                ListOfWork.Add(P)
                            End If

                        ElseIf Now.Day = 10 Then
                            If P.Day_10 = True Then
                                ListOfWork.Add(P)
                            End If
                        ElseIf Now.Day = 11 Then
                            If P.Day_11 = True Then
                                ListOfWork.Add(P)
                            End If
                        ElseIf Now.Day = 12 Then
                            If P.Day_12 = True Then
                                ListOfWork.Add(P)
                            End If
                        ElseIf Now.Day = 13 Then
                            If P.Day_13 = True Then
                                ListOfWork.Add(P)
                            End If
                        ElseIf Now.Day = 14 Then
                            If P.Day_14 = True Then
                                ListOfWork.Add(P)
                            End If
                        ElseIf Now.Day = 15 Then
                            If P.Day_15 = True Then
                                ListOfWork.Add(P)
                            End If
                        ElseIf Now.Day = 16 Then
                            If P.Day_16 = True Then
                                ListOfWork.Add(P)
                            End If
                        ElseIf Now.Day = 17 Then
                            If P.Day_17 = True Then
                                ListOfWork.Add(P)
                            End If
                        ElseIf Now.Day = 18 Then
                            If P.Day_18 = True Then
                                ListOfWork.Add(P)
                            End If
                        ElseIf Now.Day = 19 Then
                            If P.Day_19 = True Then
                                ListOfWork.Add(P)
                            End If

                        ElseIf Now.Day = 20 Then
                            If P.Day_20 = True Then
                                ListOfWork.Add(P)
                            End If
                        ElseIf Now.Day = 21 Then
                            If P.Day_21 = True Then
                                ListOfWork.Add(P)
                            End If
                        ElseIf Now.Day = 22 Then
                            If P.Day_22 = True Then
                                ListOfWork.Add(P)
                            End If
                        ElseIf Now.Day = 23 Then
                            If P.Day_23 = True Then
                                ListOfWork.Add(P)
                            End If
                        ElseIf Now.Day = 24 Then
                            If P.Day_24 = True Then
                                ListOfWork.Add(P)
                            End If
                        ElseIf Now.Day = 25 Then
                            If P.Day_25 = True Then
                                ListOfWork.Add(P)
                            End If
                        ElseIf Now.Day = 26 Then
                            If P.Day_26 = True Then
                                ListOfWork.Add(P)
                            End If
                        ElseIf Now.Day = 27 Then
                            If P.Day_27 = True Then
                                ListOfWork.Add(P)
                            End If
                        ElseIf Now.Day = 28 Then
                            If P.Day_28 = True Then
                                ListOfWork.Add(P)
                            End If
                        ElseIf Now.Day = 29 Then
                            If P.Day_29 = True Then
                                ListOfWork.Add(P)
                            End If

                        ElseIf Now.Day = 30 Then
                            If P.Day_30 = True Then
                                ListOfWork.Add(P)
                            End If
                        ElseIf Now.Day = 31 Then
                            If P.Day_31 = True Then
                                ListOfWork.Add(P)
                            End If
                        End If

                    Else

                    End If
                End If

            End If
        Next
        LV.Items.Clear()

        For Each L As Archives.Profile In ListOfWork
            Dim Item As New ListViewItem(L.Name)
            Item.SubItems.Add(SmartCoder.CalculateDirSize(New IO.DirectoryInfo(L.Source), SmartCoder.M_FileManager.SizeInfo.Scales.Gigabyte).Display)
            Item.SubItems.Add(L.Hours)
            Item.SubItems.Add(L.Minutes)
            Item.SubItems.Add("Standbye")
            Item.Tag = L
            LV.Items.Add(Item)
        Next

    End Sub

    Private Sub ButtonItem1_Click(sender As Object, e As EventArgs) Handles ButtonItem1.Click
        Dim St As New DevComponents.DotNetBar.SuperTabItem
        Dim P As New DevComponents.DotNetBar.SuperTabControlPanel
        St.ContainerControl = P
        Dim S As New Sauvegarde
        S.Dock = DockStyle.Fill
        Dim Panel As New DevComponents.DotNetBar.PanelEx
        Panel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Panel.Dock = DockStyle.Fill
        P.Controls.Add(Panel)
        Panel.Controls.Add(S)
        Current = New Archives.Profile
        S.Run_Saving(Current)
        'STC_Jobs.Tabs.Add(St)
    End Sub

    Private Sub Btn_Refresh_Click(sender As Object, e As EventArgs) Handles Btn_Refresh.Click
        RefreshWork()
    End Sub

    ' Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
    ' If MySauvegarde.Input_Source.JobDone = True Then
    '         Threading.Thread.Sleep(100)
    ' If BW.IsBusy Then
    ' Else
    '             BW.RunWorkerAsync()
    'End If
    '      End If
    ' End Sub

    'Private Sub BW_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW.DoWork
    '    Timer2.Stop()
    '    MySauvegarde.Btn_Start.PerformClick()

    '    End Sub

    Private Sub BW_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BW.RunWorkerCompleted
        Timer3.Start()

    End Sub

    'Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
    ' If MySauvegarde.JobDone = True Then
    '         MySauvegarde.Input_Source.JobDone = False
    '         MySauvegarde.JobDone = False
    '         Timer3.Stop()
    '         Timer1.Start()
    ' End If
    ' End Sub

    Private Sub BW2_DoWork(sender As Object, e As DoWorkEventArgs) Handles BW2.DoWork
        '  Dim Form As New DevComponents.DotNetBar.Office2007Form
        ' Form.Show()
        'Form.Size = New Size(930, 585)
        'Save.Dock = DockStyle.Fill
        'Form.Controls.Add(Save)
        Current = New Archives.Profile
        Current = LV.Items(Index).Tag
        Savior.Current = LV.Items(Index).Tag
        Savior.Input_Profile.SelectedItem = Current
        ' Savior.Input_Profile.SelectedIndex = Index
        Savior.Input_Profile.Text = Current.ToString
        Savior.Input_Source.Text = Current.Source
        Savior.Input_Direction.Text = Current.Destination
        Do Until Savior.ReadyToFire = True

        Loop
        Savior.Timer1.Start()
        Savior.Btn_Play.PerformClick()
        '    MySauvegarde.CurrentProfile = Current
        '  MySauvegarde.Input_Source.ActiveDir = New SmartCoder.M_FileManager.Folder(Current.Source)
        '  MySauvegarde.Input_Destination.ActiveDir = New SmartCoder.M_FileManager.Folder(Current.Destination)


    End Sub

    Private Sub BW2_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BW2.RunWorkerCompleted
        'MySauvegarde.Input_Source.Btn_Refresh.PerformClick()

        Timer2.Start()
    End Sub

    Private Sub BW_Refresh_DoWork(sender As Object, e As DoWorkEventArgs) Handles BW_Refresh.DoWork
        Btn_Refresh.RaiseClick()
    End Sub

    Private Sub BW_Refresh_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BW_Refresh.RunWorkerCompleted
        My.Settings.HasRefresh = True
        My.Settings.Save()
    End Sub

    Private Sub U_DataBase1_Load(sender As Object, e As EventArgs) Handles U_DataBase1.Load
        ' If My.Settings.Db_Backup_FilePath.Length > 1 Then
        U_DataBase1.ActiveDatabase = New SmartCoder.M_FileManager.DataBase(My.Settings.Db_Backup_FilePath, My.Settings.Db_Backup_Password)
            U_DataBase1.Txt_FilePath.Text = My.Settings.Db_Backup_FilePath
            U_DataBase1.Password.Text = My.Settings.Db_Backup_Password
        ' Else

        ' End If
        Timer4.Start()
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If U_DataBase1.JobDone = True Then
            If Not IsNothing(U_DataBase1.ActiveDatabase) Then

                If BW_G.IsBusy Then
                Else
                    BW_G.RunWorkerAsync()
                End If
            End If
        End If
    End Sub

    Private Sub BW_G_DoWork(sender As Object, e As DoWorkEventArgs) Handles BW_G.DoWork
        Timer4.Stop()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.Db_Backup_FilePath = U_DataBase1.ActiveDatabase.Target
        My.Settings.Db_Backup_Password = U_DataBase1.ActiveDatabase.Password
        My.Settings.Db_Backup_Line = U_DataBase1.ActiveDatabase.Line.Line
        My.Settings.Save()

        RefreshWork()
        If My.Settings.HasRefresh = False Then
            BW_Refresh.RunWorkerAsync()
        End If
    End Sub


End Class
