Public Class FichierView
    Dim Fi As New M_FileManager.Fichier

    Private Sub Input_Target_TextChanged(sender As Object, e As EventArgs) Handles Input_Target.TextChanged
        Fi = New Fichier(Me.Input_Target.Text)
        AdvPropertyGrid1.SelectedObject = Fi
        File_Size.Text = Fi.FileSize.Display
        Accessed.Value = Fi.Access
        Modified.Value = Fi.Modified
        Created.Value = Fi.Created

        If Fi.Exists = False Then
            ReflectionImage2.Image = SmartCoder.My.Resources.Resources.close
        Else
            ReflectionImage2.Image = SmartCoder.My.Resources.Resources.check_mark

        End If
    End Sub

    Private Sub FichierView_Load(sender As Object, e As EventArgs) Handles Me.Load
        Btn_Paste.Enabled = False
    End Sub

    Private Sub Btn_Open_Click(sender As Object, e As EventArgs) Handles Btn_Open.Click, Input_Target.DoubleClick
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            Input_Target.Text = OFD.FileName
        End If
    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Fi.Clear()
        AdvPropertyGrid1.SelectedObject = Fi

    End Sub

    Private Sub Btn_Change_Extension_Click(sender As Object, e As EventArgs) Handles Btn_Change_Extension.Click
        Jarvis.Speak("The actual extension is " & Fi.Extension & ", what new extension would you like to convert.")
        Dim NewExtension = InputBox("Enter the new extension without the dot.", "Change the extension", "Null")
        If NewExtension <> "Null" And NewExtension.Length > 0 Then
            Dim Temp As TestItem = Fi.Change_Extension(NewExtension, True, True)
            Dim S As New ShowProperty(Temp)
            S.Show()
            Input_Target.Text = Temp.OutputString
        End If
    End Sub

    Private Sub Btn_Hide_Click(sender As Object, e As EventArgs) Handles Btn_Hide.Click
        If Not IsNothing(Fi) Then
            If Fi.HideFile.Status <> Status.Broken Then
                Jarvis.Speak("The file has been hidden.")
            Else
                Jarvis.Speak("There has been some problem with the process.")
            End If
        End If
    End Sub

    Private Sub Btn_Unhide_Click(sender As Object, e As EventArgs) Handles Btn_Unhide.Click
        If Not IsNothing(Fi) Then
            If Fi.UnHide.Status <> Status.Broken Then
                Jarvis.Speak("The file has been unhidden.")
            Else
                Jarvis.Speak("There has been some problem with the process.")
            End If
        End If
    End Sub

    Private Sub Btn_Compress_Click(sender As Object, e As EventArgs) Handles Btn_Compress.Click
        If Not IsNothing(Fi) Then
            If Fi.Compress.Status <> Status.Broken Then
                Jarvis.Speak("The file has been Compress.")
            Else
                Jarvis.Speak("There has been some problem with the process.")
            End If
        End If
    End Sub

    Private Sub Btn_Decompress_Click(sender As Object, e As EventArgs) Handles Btn_Decompress.Click
        If Not IsNothing(Fi) Then
            Jarvis.Speak("Where would you like to extract the files?")
            Dim Extract As Folder = Nothing
            If FDB.ShowDialog = Windows.Forms.DialogResult.OK Then
                Extract = New Folder(FDB.SelectedPath)
            End If
            If Not IsNothing(Extract) Then

                If Fi.Extract(Extract.Target).Status <> Status.Broken Then
                    Jarvis.Speak("The file has been Extracted.")
                Else
                    Jarvis.Speak("There has been some problem with the process.")
                End If
            End If
        End If
    End Sub

    Private Sub Btn_Copy_Click(sender As Object, e As EventArgs) Handles Btn_Copy.Click
        If Not IsNothing(Fi) Then
            My.Computer.Clipboard.SetText(Fi.Target)
            Jarvis.Speak("The file has been copied")
            Btn_Paste.Enabled = True
            ClientForCut = False
        End If
    End Sub
    Dim ClientForCut As Boolean = False
    Private Sub Btn_Cut_Click(sender As Object, e As EventArgs) Handles Btn_Cut.Click
        If Not IsNothing(Fi) Then
            My.Computer.Clipboard.SetText(Fi.Target)
            Jarvis.Speak("The file has been cut")
            Btn_Paste.Enabled = True
            ClientForCut = True
        End If
    End Sub

    Private Sub Btn_Paste_Click(sender As Object, e As EventArgs) Handles Btn_Paste.Click
        If Not IsNothing(Fi) Then
            Jarvis.Speak("Where would you like to past the file?")
            Dim PastePath As Folder = Nothing
            If FDB.ShowDialog = Windows.Forms.DialogResult.OK Then
                PastePath = New Folder(FDB.SelectedPath)
            End If
            If Not IsNothing(PastePath) Then
                Try
                    If ClientForCut = True Then
                        Dim Info = Fi.Cut(PastePath.Target, True)
                        If Info.Status <> Status.Broken Then
                            Jarvis.Speak("The file has been cut.")
                        ElseIf Info.Status = Status.Broken Then
                            Jarvis.Speak("There was a problem with the process.")
                            Dim S As New ShowProperty(Info)
                            S.Show()

                        End If
                    End If
                Catch ex As Exception

                End Try
            End If
        End If
    End Sub

    Private Sub Btn_Create_Click(sender As Object, e As EventArgs) Handles Btn_Create.Click
        If IO.File.Exists(Input_Target.Text) Then
        Else
            Dim Cre = Fi.Create()
            If Cre.Status = Status.Broken Then
                Dim S As New ShowProperty(Cre)
                S.Show()
            Else
                Jarvis.Speak("The file has been created successfully.")
            End If
        End If
    End Sub

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        If Not IsNothing(Fi) Then
            Jarvis.Speak("Warning you are about to delete a file, are you sure?")
            Dim Resp = MsgBox("Are you sure you want to delete this file [" & Fi.Target & "] ?", vbYesNo)
            If Resp = vbYes Then
                Dim Info As TestItem = Nothing
                Info = Fi.Delete()
                If Info.Status = Status.Broken Then
                    Jarvis.Speak("The file could not be deleted.")
                    Dim S As New ShowProperty(Info)
                    S.Show()
                Else
                    Jarvis.Speak("The file has been deleted.")
                End If
            End If
        End If
    End Sub

    Private Sub Btn_Set_Key_Click(sender As Object, e As EventArgs) Handles Btn_Set_Key.Click
        Jarvis.Speak("Change your key")
        Dim m = InputBox("Please enter a new Cypher", "Change the Cypher", "Dunke92606!")
        My.Settings.Cypher = m
        My.Settings.Save()
        Jarvis.Speak("The new Cypher has been stored.")
        Input_Decrypt_Cypher.Text = My.Settings.Cypher
        Input_Encrypt_Cypher.Text = My.Settings.Cypher
    End Sub

    Private Sub Btn_View_Key_Click(sender As Object, e As EventArgs) Handles Btn_View_Key.Click
        MsgBox(My.Settings.Cypher,, "The active Cypher.")
    End Sub

    Private Sub Btn_Encrypt_Click(sender As Object, e As EventArgs) Handles Btn_Encrypt.Click
        Dim M As TestItem = Nothing
        If Not IsNothing(Fi) Then
            M = Fi.Encrypt(My.Settings.Cypher)
            If M.Status = Status.Broken Then
                Dim S As New ShowProperty(M)
                S.Show()
            Else
                Btn_Decrypt.Enabled = True
                Btn_Encrypt.Enabled = False
                Jarvis.Speak("The file has been encrypted")
            End If
        End If
    End Sub

    Private Sub Btn_Decrypt_Click(sender As Object, e As EventArgs) Handles Btn_Decrypt.Click
        Dim M As TestItem = Nothing
        If Not IsNothing(Fi) Then
            M = Fi.Decrypt(My.Settings.Cypher)
            If M.Status = Status.Broken Then
                Dim S As New ShowProperty(M)
                S.Show()
            Else
                Btn_Decrypt.Enabled = False
                Btn_Encrypt.Enabled = True
                Jarvis.Speak("The file has been decrypted")
            End If
        End If
    End Sub
End Class
