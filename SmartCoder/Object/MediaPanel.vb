Public Class MediaPanel

    Private _AutoPlay As Boolean
    Public Property AutoPlay() As Boolean
        Get
            Return _AutoPlay
        End Get
        Set(ByVal value As Boolean)
            If IsNothing(value) Then
            Else
                If value = True Then
                    If IsNothing(VLC1.playlist.currentItem) Then
                    Else
                        Try
                            VLC1.playlist.play()
                        Catch ex As Exception

                        End Try
                    End If
                End If
            End If
            _AutoPlay = value
        End Set
    End Property
    Public Property Title As String = ""
    Private _Channel As Youtube
    Public Property Channel() As Youtube
        Get
            Return _Channel
        End Get
        Set(ByVal value As Youtube)
            If IsNothing(value) Then
            Else
                Me.Title = value.Name
                Me.AutoPlay = True
                Me.URL = value.Url
                Try
                    VLC1.playlist.add(URL)
                    VLC1.playlist.play()

                Catch ex As Exception

                End Try

            End If
            _Channel = value
        End Set
    End Property

    Private _URL As String
    Public Property URL() As String
        Get
            Return _URL
        End Get
        Set(ByVal value As String)
            If IsNothing(value) Then

            Else
                If value = "" Then
                Else
                    If AutoPlay = True Then
                        If VLC1.playlist.items.count - 1 >= 0 Then
                            VLC1.playlist.items.clear()
                        End If
                        VLC1.playlist.add(value)
                        VLC1.playlist.play()
                    Else
                        If VLC1.playlist.items.count - 1 >= 0 Then
                            VLC1.playlist.items.clear()
                        End If
                        VLC1.playlist.add(value)
                    End If
                End If

            End If
            _URL = value

        End Set
    End Property

    Private _Video As String
    Public Property Video() As String
        Get
            Return _Video
        End Get
        Set(ByVal value As String)
            If IsNothing(value) Then

            Else
                If value = "" Then
                Else
                    If AutoPlay = True Then
                        VLC1.playlist.playItem(value)
                    Else
                        VLC1.playlist.add(value)
                    End If
                End If

            End If
            _Video = value
        End Set
    End Property

    Private Sub MediaPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VLC1.volume = SliderItem1.Value

    End Sub

    Private Sub ButtonItem2_Click(sender As Object, e As EventArgs) Handles ButtonItem2.Click
        VLC1.playlist.pause()
    End Sub

    Private Sub SliderItem1_ValueChanged(sender As Object, e As EventArgs) Handles SliderItem1.ValueChanged
        Try
            VLC1.volume = SliderItem1.Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonItem3_Click(sender As Object, e As EventArgs) Handles ButtonItem3.Click
        Try
            VLC1.playlist.play()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonItem4_Click(sender As Object, e As EventArgs) Handles ButtonItem4.Click
        If SliderItem1.Value + 5 >= 100 Then
            SliderItem1.Value = 100
        Else
            SliderItem1.Value += 5
        End If
    End Sub

    Private Sub ButtonItem5_Click(sender As Object, e As EventArgs) Handles ButtonItem5.Click
        If SliderItem1.Value - 5 <= 0 Then
            SliderItem1.Value = 0
        Else
            SliderItem1.Value -= 5
        End If
    End Sub

    Private Sub ButtonItem6_Click(sender As Object, e As EventArgs) Handles ButtonItem6.Click
        SliderItem1.Value = 0
    End Sub
End Class
