Public Class DataBase
    Private Sub DataBase_Load(sender As Object, e As EventArgs) Handles Me.Load

        With Db_Chronos
            .Target = My.Settings.Db_Chronos_FilePath
            .Password = My.Settings.Db_Chronos_Password
            .Output_Line.Text = My.Settings.Db_Chronos_Line
        End With
        With Db_Ofisa
            .Target = My.Settings.Db_mdtdata_FilePath
            .Password = My.Settings.Db_mdtdata_Password
            .Output_Line.Text = My.Settings.Db_mdtdata_Line
        End With

    End Sub

    Private Sub DataBase_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If Db_Chronos.Target.Length > 1 Then

            My.Settings.Db_Chronos_FilePath = Db_Chronos.Target
            My.Settings.Db_Chronos_Password = Db_Chronos.Password
            My.Settings.Db_Chronos_Line = Db_Chronos.Current.Line.Line
            My.Settings.Save()
        Else
            If My.Computer.Name = "Master" Then
                My.Settings.Db_Chronos_FilePath = "‪C:\Users\Saadry\Documents\Chronos.Saadry"
                My.Settings.Db_Chronos_Password = Db_Chronos.Password
                My.Settings.Db_Chronos_Line = New SmartCoder.LineInfo("‪C:\Users\Saadry\Documents\Chronos.Saadry").Line
                My.Settings.Save()
            ElseIf my.Computer.Name = "HQ" Then
                My.Settings.Db_Chronos_FilePath = "Z:\Factures émises\Chronos.Saadry"
                My.Settings.Db_Chronos_Password = Db_Chronos.Password
                My.Settings.Db_Chronos_Line = New SmartCoder.LineInfo("Z:\Factures émises\Chronos.Saadry").Line
                My.Settings.Save()
            Else
                My.Settings.Db_Chronos_FilePath = "Z:\Factures émises\Chronos.Saadry"
                My.Settings.Db_Chronos_Password = Db_Chronos.Password
                My.Settings.Db_Chronos_Line = New SmartCoder.LineInfo("Z:\Factures émises\Chronos.Saadry").Line
                My.Settings.Save()
            End If
        End If
        If Db_Ofisa.Target.Length > 1 Then

            My.Settings.Db_mdtdata_FilePath = Db_Ofisa.Target
            My.Settings.Db_mdtdata_Password = Db_Ofisa.Password
            My.Settings.Db_mdtdata_Line = Db_Ofisa.Current.Line.Line
            My.Settings.Save()

        Else
            If My.Computer.Name = "Master" Then
                My.Settings.Db_mdtdata_FilePath = "‪I:\Clients\Foract SA\mdtdata.mdb"
                My.Settings.Db_mdtdata_Password = Db_Ofisa.Password
                My.Settings.Db_mdtdata_Line = New SmartCoder.LineInfo("‪I:\Clients\Foract SA\mdtdata.mdb").Line
                My.Settings.Save()
            ElseIf My.Computer.Name = "HQ" Then
                My.Settings.Db_mdtdata_FilePath = "‪X:\OFISA\ofimdtw\ofimdtw_data\mdtdata.mdb"
                My.Settings.Db_mdtdata_Password = Db_Ofisa.Password
                My.Settings.Db_mdtdata_Line = New SmartCoder.LineInfo("‪X:\OFISA\ofimdtw\ofimdtw_data\mdtdata.mdb").Line
                My.Settings.Save()
            Else
                My.Settings.Db_mdtdata_FilePath = "‪X:\OFISA\ofimdtw\ofimdtw_data\mdtdata.mdb"
                My.Settings.Db_mdtdata_Password = Db_Ofisa.Password
                My.Settings.Db_mdtdata_Line = New SmartCoder.LineInfo("‪X:\OFISA\ofimdtw\ofimdtw_data\mdtdata.mdb").Line
                My.Settings.Save()
            End If

        End If
    End Sub
End Class