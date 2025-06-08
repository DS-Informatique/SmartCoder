Public Class Menu
    Dim A As New CollaborateurViewer
    Dim B As New ClientViewer
    Dim C As New U_Factures
    Dim D As New PrestationViewer
    Dim F As New SociétéViewer
    Dim G As New Tarification

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Set_FilePath.Text = My.Settings.Db_TimeSheet_FilePath

        Set_Password.Text = My.Settings.Db_TimeSheet_Password

        Me.Set_TVA.Text = My.Settings.TVA

        A.Dock = DockStyle.Fill
        Panel_Collaborateur.Controls.Add(A)

        B.Dock = DockStyle.Fill
        Panel_Client.Controls.Add(B)

        C.Dock = DockStyle.Fill
        Panel_Factures.Controls.Add(C)

        D.Dock = DockStyle.Fill
        Panel_Saisie.Controls.Add(D)

        F.Dock = DockStyle.Fill
        Panel_Société.Controls.Add(F)

        G.Dock = DockStyle.Fill
        Panel_Tarification.Controls.Add(G)
    End Sub

    Private Sub Btn_Clients_Click(sender As Object, e As EventArgs) Handles Btn_Clients.Click
        If Dock_Client.Visible = False Then
            Dock_Client.Visible = True
            Dock_Société.Visible = False
            Dock_Facture.Visible = False
            Dock_Collaborateur.Visible = False
            Dock_Saisie.Visible = False
            Dock_Tarification.Visible = False
            Dock_Parameter.Visible = False
            Dock_Info.Visible = False
        Else
            Dock_Client.Visible = False
        End If
    End Sub

    Private Sub Btn_Saisie_Click(sender As Object, e As EventArgs) Handles Btn_Saisie.Click
        If Dock_Saisie.Visible = False Then
            Dock_Saisie.Visible = True
            Dock_Client.Visible = False
            Dock_Société.Visible = False
            Dock_Facture.Visible = False
            Dock_Collaborateur.Visible = False
            Dock_Tarification.Visible = False
            Dock_Parameter.Visible = False
            Dock_Info.Visible = False
        Else
            Dock_Saisie.Visible = False
        End If
    End Sub

    Private Sub ButtonItem1_Click(sender As Object, e As EventArgs) Handles ButtonItem1.Click
        If Dock_Collaborateur.Visible = False Then
            Dock_Collaborateur.Visible = True
            Dock_Client.Visible = False
            Dock_Société.Visible = False
            Dock_Facture.Visible = False
            Dock_Saisie.Visible = False
            Dock_Tarification.Visible = False
            Dock_Parameter.Visible = False
            Dock_Info.Visible = False
        Else
            Dock_Collaborateur.Visible = False
        End If
    End Sub

    Private Sub ButtonItem2_Click(sender As Object, e As EventArgs) Handles ButtonItem2.Click
        If Dock_Société.Visible = False Then
            Dock_Société.Visible = True
            Dock_Client.Visible = False
            Dock_Collaborateur.Visible = False
            Dock_Facture.Visible = False
            Dock_Saisie.Visible = False
            Dock_Tarification.Visible = False
            Dock_Parameter.Visible = False
            Dock_Info.Visible = False
        Else
            Dock_Société.Visible = False
        End If
    End Sub

    Private Sub ButtonItem3_Click(sender As Object, e As EventArgs) Handles ButtonItem3.Click
        If Dock_Tarification.Visible = False Then
            Dock_Société.Visible = False
            Dock_Client.Visible = False
            Dock_Collaborateur.Visible = False
            Dock_Facture.Visible = False
            Dock_Saisie.Visible = False
            Dock_Parameter.Visible = False
            Dock_Tarification.Visible = True
            Dock_Info.Visible = False
        Else
            Dock_Tarification.Visible = False

        End If
    End Sub
    Private Sub Btn_Parameter_Click(sender As Object, e As EventArgs) Handles Btn_Parameter.Click
        If Dock_Parameter.Visible = False Then
            Dock_Société.Visible = False
            Dock_Client.Visible = False
            Dock_Collaborateur.Visible = False
            Dock_Facture.Visible = False
            Dock_Saisie.Visible = False
            Dock_Parameter.Visible = True
            Dock_Tarification.Visible = False
            Dock_Info.Visible = False
        Else
            Dock_Parameter.Visible = False

        End If
    End Sub
    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        My.Settings.Db_TimeSheet_FilePath = Set_FilePath.Text
        My.Settings.Db_TimeSheet_Password = Set_Password.Text
        My.Settings.TVA = Double.Parse(Me.Set_TVA.Text)
        My.Settings.DataBase = Set_FilePath.Text
        My.Settings.DataBasePassword = Set_Password.Text
        My.Settings.Db_TimeSheet_Line = New SmartCoder.LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password).Line
        My.Settings.DataBaseLine = My.Settings.Db_TimeSheet_Line

        My.Settings.Save()
        SmartCoder.Jarvis.Speak("Save applied.")

    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Set_FilePath.Text = ""
        Set_Password.Text = ""
        Set_TVA.Text = ""
        Set_FilePath.Text = My.Settings.Db_TimeSheet_FilePath

        Set_Password.Text = My.Settings.Db_TimeSheet_Password
        Me.Set_TVA.Text = My.Settings.TVA
    End Sub

    Private Sub ButtonItem4_Click(sender As Object, e As EventArgs) Handles ButtonItem4.Click
        If Dock_Facture.Visible = False Then
            Dock_Société.Visible = False
            Dock_Client.Visible = False
            Dock_Collaborateur.Visible = False
            Dock_Saisie.Visible = False
            Dock_Facture.Visible = True
            Dock_Tarification.Visible = False
            Dock_Parameter.Visible = False
            Dock_Info.Visible = False
        Else
            Dock_Facture.Visible = False

        End If
    End Sub

    Private Sub Menu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        GC.Collect()

        Application.Exit()

    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        My.Settings.LoadDirectly = False
        My.Settings.Save()
        Dim M As New Login
        Me.Hide()
        M.Show()
    End Sub

    Private Sub ButtonItem5_Click(sender As Object, e As EventArgs) Handles ButtonItem5.Click
        If Dock_Info.Visible = False Then
            Dock_Société.Visible = False
            Dock_Client.Visible = False
            Dock_Collaborateur.Visible = False
            Dock_Saisie.Visible = False
            Dock_Info.Visible = True
            Dock_Tarification.Visible = False
            Dock_Parameter.Visible = False
            Dock_Facture.Visible = False

        Else
            Dock_Info.Visible = False
        End If
    End Sub
End Class