Public Class YoutubePlayer
    Public Property Y As Youtube

    Private Sub Btn_Analyse_Click(sender As Object, e As EventArgs) Handles Btn_Analyse.Click
        Y = New Youtube(TextBoxItem1.Text)
        If ComboBoxItem1.Items.Count - 1 > 0 Then
            ComboBoxItem1.Items.Clear()
        End If
        Try
            Y.RequestLinks(TextBoxItem1.Text)

        Catch ex As Exception

        End Try

        For i = 0 To Y.ListExt.Count - 1
            ComboBoxItem1.Items.Add(Y.ListFormat(i).ToString)

        Next
        '   PictureBox1.Load(TextBoxX2.Text)
        Try
            PictureBox1.Load(SearchEngine.GetYoutubeThumbnail(TextBoxItem1.Text))
        Catch ex As Exception

        End Try
        Dim Web2 As New WebSite(TextBoxItem1.Text)
        Y.Url = TextBoxItem1.Text
        Try
            VLC.playlist.add(Y.Url)
            VLC.playlist.play()
        Catch ex As Exception

        End Try
        Y.GrabThumbnail()
        AdvPropertyGrid1.SelectedObject = Y
    End Sub

    Private Sub Btn_Show_Click(sender As Object, e As EventArgs) Handles Btn_Show.Click

    End Sub

    Private Sub Btn_Download_Click(sender As Object, e As EventArgs) Handles Btn_Download.Click
        counter = 0
        Timer1.Start()
        Y.Download(TextBoxItem1.Text, My.Settings.DownloadDir, ComboBoxItem1.SelectedIndex)

    End Sub

    Dim counter As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        counter += 1
        L_Time.Text = Convert_Timer_ToTime(counter).ToString
        ProgressBarItem1.Value = Y.ProgressBar.Value
        L_DState.Text = Y.DownloadStatus
        If IsNothing(Y.DownloadedVideo) Then
            AdvPropertyGrid1.RefreshPropertyValues()
        Else
            Timer1.Stop()
        End If
        L_Percentage.Text = "( " & Y.DownloadPercentage & " )"
        AdvPropertyGrid1.RefreshPropertyValues()


    End Sub

    Private Sub ButtonItem2_Click(sender As Object, e As EventArgs) Handles ButtonItem2.Click
        'Try
        ' Y = New Youtube(TextBoxItem1.Text)
        ' MsgBox("running : {" & Y.VLCUrl & "}")
        VLC.BaseURL = (Y.Url)
        VLC.playlist.play()
        ' Catch ex As Exception
        ' MsgBox(ex.Message)
        '  End Try

        AdvPropertyGrid1.RefreshPropertyValues()

    End Sub

    Private Sub ButtonItem3_Click(sender As Object, e As EventArgs) Handles ButtonItem3.Click
        If IsNothing(Y) Then
        Else
            If IsNothing(Y.VLCUrl) Then
            Else
                If Y.VLCUrl = "" Then
                Else
                    Try
                        VLC.playlist.pause()

                        ButtonItem3.Enabled = False
                        ButtonItem2.Enabled = True
                    Catch ex As Exception
                        ButtonItem3.Enabled = True
                        ButtonItem2.Enabled = False
                        MsgBox(ex.Message)

                    End Try

                End If
            End If
        End If
    End Sub

    Private Sub TextBoxItem1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxItem1.TextChanged

    End Sub

    Private Sub ButtonItem5_Click(sender As Object, e As EventArgs) Handles ButtonItem5.Click
        Try
            VLC.playlist.add(TextBoxItem1.Text)
            VLC.playlist.play()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
End Class
