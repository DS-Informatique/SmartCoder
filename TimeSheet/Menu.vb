Public Class Menu
    Private Sub ButtonItem1_Click(sender As Object, e As EventArgs) Handles ButtonItem1.Click
        If My.Settings.DataBase = "" Then
            My.Settings.DataBase = "Z:\Factures émises\TimeSheet.accdb"
            My.Settings.Save()
        End If
        If My.Settings.DataBaseLine = "" Then
            Dim L As New SmartCoder.LineInfo(My.Settings.DataBase, My.Settings.DataBasePassword)
            My.Settings.DataBaseLine = L.Line
            My.Settings.Save()
        End If
        ' Dim T As Db_TimeSheet = Nothing
        'AdvPropertyGrid1.SelectedObject = T
        '    T = New SmartCoder.M_TimeSheet.Db_TimeSheet(My.Settings.DataBase)
        '   AdvPropertyGrid1.RefreshPropertyValues()
    End Sub
End Class