Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        CheckForIllegalCrossThreadCalls = False

        If My.Settings.LoadDirectly = True Then
            If My.Settings.Stored_FilePath <> "" Then
                My.Settings.Db_TimeSheet_FilePath = My.Settings.Stored_FilePath
                My.Settings.Db_TimeSheet_Password = My.Settings.Stored_Password
                My.Settings.Db_TimeSheet_Line = New SmartCoder.LineInfo(My.Settings.Stored_FilePath, My.Settings.Stored_Password).Line
                My.Settings.Save()
                Dim O As New Menu
                O.Show()
                Me.Hide()
            End If
        End If
        If My.Settings.Enable_Reset = True Then
            ButtonX1.Visible = True
        Else
            ButtonX1.Visible = False
        End If
        List_Sociétés = New List(Of Sociétés)
        List_Sociétés = Current_Société.List
        'ComboBoxEx1.DataSource = List_Sociétés
        U_DataBase1.Target = My.Settings.Db_TimeSheet_FilePath

    End Sub

    Private Sub Btn_Open_Click(sender As Object, e As EventArgs) Handles Btn_Open.Click
        My.Settings.Db_TimeSheet_FilePath = U_DataBase1.ActiveDatabase.Target
        My.Settings.Db_TimeSheet_Password = U_DataBase1.ActiveDatabase.Password
        My.Settings.Db_TimeSheet_Line = U_DataBase1.ActiveDatabase.Line.Line
        My.Settings.Save()
        If Memorized.Checked = True Then
            My.Settings.Stored_FilePath = My.Settings.Db_TimeSheet_FilePath
            My.Settings.Stored_Password = My.Settings.Db_TimeSheet_Password
            My.Settings.Db_TimeSheet_Line = My.Settings.Db_TimeSheet_Line
            My.Settings.LoadDirectly = True
            My.Settings.Save()
        Else
            My.Settings.LoadDirectly = False
            My.Settings.Save()
        End If
        BW.RunWorkerAsync()
    End Sub

    Private Sub BW_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW.DoWork
        ProgressBarX1.Value = 0
        List_Clients = New List(Of Clients)
        Current_Client = New Clients

        List_Clients = Current_Client.List()
        ProgressBarX1.Value += 10

        List_Collaborateur = New List(Of Collaborateur)
        Current_Collaborateur = New Collaborateur
        List_Collaborateur = Current_Collaborateur.List
        ProgressBarX1.Value += 10

        List_Factures = New List(Of Factures)
        Current_Factures = New Factures
        List_Factures = Current_Factures.List
        ProgressBarX1.Value += 10

        List_Factures_Entries = New List(Of Factures_Entries)
        Current_Factures_Entries = New Factures_Entries
        List_Factures_Entries = Current_Factures_Entries.List
        ProgressBarX1.Value += 10

        List_Prestations = New List(Of Prestations)
        Current_Prestations = New Prestations
        List_Prestations = Current_Prestations.List
        ProgressBarX1.Value += 10

        List_Services = New List(Of Services)
        Current_Services = New Services
        List_Services = Current_Services.List
        ProgressBarX1.Value += 10

        List_Tarif = New List(Of Tarif)
        Current_Tarif = New Tarif
        List_Tarif = Current_Tarif.List
        ProgressBarX1.Value += 10

        List_TimeSheet = New List(Of TimeSheet)
        Current_TimeSheet = New TimeSheet
        List_TimeSheet = Current_TimeSheet.List
        ProgressBarX1.Value += 10

        List_Sociétés = New List(Of Sociétés)
        Current_Société = New Sociétés
        List_Sociétés = Current_Société.List
        ProgressBarX1.Value += 10

    End Sub

    Private Sub BW_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW.RunWorkerCompleted
        ProgressBarX1.Value = 0
        SmartCoder.Jarvis.Speak("Loading Completed")
        Dim O As New Menu
        O.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        If My.Settings.Stored_FilePath <> "" And My.Settings.Enable_Reset = True Then
            U_DataBase1.Target = My.Settings.Stored_FilePath
            U_DataBase1.PasswordInput = My.Settings.Stored_Password
            U_DataBase1.Password.Text = My.Settings.Stored_Password
            My.Settings.Db_TimeSheet_FilePath = My.Settings.Stored_FilePath
            My.Settings.Db_TimeSheet_Password = My.Settings.Stored_Password
            My.Settings.Db_TimeSheet_Line = New SmartCoder.LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password).Line
            My.Settings.Save()
            SmartCoder.Jarvis.Speak("Settings have been restored.")
            ButtonX1.Visible = False
            My.Settings.Enable_Reset = False
            My.Settings.Save()
            U_DataBase1.Btn_Load.PerformClick()
        End If
    End Sub
End Class