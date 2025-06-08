Public Module M_Runtime

#Region "<Element>"
    Public Property Active_User As Accounts.Users
    Public Property Active_Compta As Accountis.Comptabilité
#End Region
    Public Sub Start()
        If My.Settings.Db_Accountis_FilePath.Length < 1 Then
            My.Settings.Db_Accountis_FilePath = "C:\Users\Saadry\Documents\Laboratoire\Accountis.accdb"
            My.Settings.Save()
        End If
        If My.Settings.Db_Users_FilePath.Length < 1 Then
            My.Settings.Db_Users_FilePath = "C:\Users\Saadry\Documents\Laboratoire\Users.accdb"
            My.Settings.Save()
        End If
        If IO.File.Exists(My.Settings.Db_Accountis_FilePath) Then
            Active_Compta = New Comptabilité
            With Active_Compta
                .Password = My.Settings.Db_Accountis_Password
                .FilePath = My.Settings.Db_Accountis_FilePath
                .Reset()
            End With
        End If
        If IO.File.Exists(My.Settings.Db_Users_FilePath) Then
            Active_User = New Accounts.Users
            With Active_User
                .Password = My.Settings.Db_Users_Password
                .FilePath = My.Settings.Db_Users_FilePath
                .Reset()
            End With
        End If

    End Sub
    Public Sub [Stop]()
    End Sub
End Module
