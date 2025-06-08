Public Class TV

    Private _Channel As MyVideoList
    Public Property Channel() As MyVideoList
        Get
            Return _Channel
        End Get
        Set(ByVal value As MyVideoList)
            If IsNothing(value) Then
            Else

            End If
            _Channel = value
        End Set
    End Property
    Private _Active_Channel As Youtube
    Public Property Active_Channel() As Youtube
        Get
            Return _Active_Channel
        End Get
        Set(ByVal value As Youtube)
            If Not IsNothing(value) Then
                GroupPanel1.Text = value.Name
                MediaPanel1.Channel = value
                TextBoxItem1.Text = value.Url
            End If
            _Active_Channel = value
        End Set
    End Property
    Dim Index As Integer = 0
    Private Sub Btn_Channel_Next_Click(sender As Object, e As EventArgs) Handles Btn_Channel_Next.Click
        MediaPanel1.VLC1.playlist.stop()
        If IsNothing(MyVideos) Then
            MyVideos = New List(Of Youtube)
        End If
        If MyVideos.Count - 1 < 1 Then
            Grab_Videos()
        End If

        If Index + 1 > MyVideos.Count - 1 Then
            Index = 0
        Else
            Index += 1
        End If
        Active_Channel = MyVideos(Index)

    End Sub

    Private Sub Btn_Mute_Click(sender As Object, e As EventArgs) Handles Btn_Mute.Click
        MediaPanel1.VLC1.volume = 0

    End Sub

    Private Sub Btn_DecreaseVolume_Click(sender As Object, e As EventArgs) Handles Btn_DecreaseVolume.Click
        If MediaPanel1.VLC1.volume - 5 <= 0 Then
            S_Volume.Value = 0
        Else
            S_Volume.Value -= 5

        End If

    End Sub

    Private Sub Btn_IncreaseVolume_Click(sender As Object, e As EventArgs) Handles Btn_IncreaseVolume.Click
        If MediaPanel1.VLC1.volume + 5 >= 100 Then
            S_Volume.Value = 100
        Else
            S_Volume.Value += 5

        End If
    End Sub

    Private Sub ButtonItem1_Click(sender As Object, e As EventArgs) Handles ButtonItem1.Click
        MediaPanel1.VLC1.playlist.stop()
    End Sub

    Private Sub S_Volume_ValueChanged(sender As Object, e As EventArgs) Handles S_Volume.ValueChanged
        Try
            MediaPanel1.VLC1.volume = S_Volume.Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MediaPanel1.VLC1.volume = S_Volume.Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBoxItem1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxItem1.TextChanged
        If Not IsNothing(Active_Channel) Then

            If TextBoxItem1.Text = Active_Channel.Url Then

            Else
                Dim Y As New Youtube(TextBoxItem1.Text)
                MyVideos.Add(Y)
                Active_Channel = Y
            End If
        End If

    End Sub
End Class
