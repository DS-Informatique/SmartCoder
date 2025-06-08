Imports System.Windows.Forms



''' <summary>
''' User Class to play music from a Folder
''' <author>Saadry Dunkel Consultant | 12.09.2018 Status : Finished and Operational</author>
''' </summary>
Public Class U_MusicPlayer




    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click
        For i = 0 To LV_Dir.Items.Count - 1
            If LV_Dir.Items(i).Checked = True Then
                LV_Playlist.Items.Add(LV_Dir.Items(i).Clone)
                ' LV_Dir.Items(i).Remove()
            End If
        Next
    End Sub

    Private Sub Btn_AddAll_Click(sender As Object, e As EventArgs) Handles Btn_AddAll.Click
        For i = 0 To LV_Dir.Items.Count - 1
            LV_Playlist.Items.Add(LV_Dir.Items(i).Clone)
            ' LV_Dir.Items(i).Remove()
        Next
    End Sub

    Private Sub Btn_Remove_Click(sender As Object, e As EventArgs) Handles Btn_Remove.Click
        For i = 0 To LV_Playlist.Items.Count - 1
            If LV_Playlist.Items(i).Checked = True Then
                LV_Playlist.Items(i).Remove()
            End If
        Next
    End Sub
    Dim CurrentItem As Integer
    Dim CurrentStr As String
    Public Addone As Boolean = True
    Private Sub Btn_Play_Click(sender As Object, e As EventArgs) Handles Btn_PlayMusic.Click, Btn_Play.Click
        If Addone = True Then

            If CurrentItem + 1 > LV_Playlist.Items.Count - 1 Then
                CurrentItem = 0
            Else
                CurrentItem += 1

            End If
        Else
            Addone = True
        End If
        Try
            ' MP3PLayer.URL = LV_Playlist.Items(CurrentItem).Path
            CurrentStr = LV_Playlist.Items(CurrentItem).Path
            L_SongName.Text = LV_Playlist.Items(CurrentItem).SongName
            '      MP3PLayer.URL = LV_Playlist.Items(CurrentItem).SubItems(3).Text
            '  CurrentStr = LV_Playlist.Items(CurrentItem).SubItems(3).Text
            ' L_SongName.Text = LV_Playlist.Items(CurrentItem).SubItems(2).Text
            'MP3PLayer.Ctlcontrols.play()
            ' U_Timer1.Btn_Start.RaiseClick()
            Timer1.Start()
        Catch ex As Exception

        End Try

        'L_Timer.Text = U_Timer1.L_Time.Text
        ' U_Timer1.Btn_Reset.RaiseClick()
    End Sub
    Private Sub Btn_Stop_Click(sender As Object, e As EventArgs) Handles Btn_Stop.Click
        Timer1.Stop()
        '  MP3PLayer.Ctlcontrols.pause()
        ' U_Timer1.Btn_Stop.RaiseClick()
    End Sub

    Private Sub Btn_PauseMusic_Click(sender As Object, e As EventArgs) Handles Btn_PauseMusic.Click
        'MP3PLayer.Ctlcontrols.pause()
    End Sub

    Private Sub Btn_StopMusic_Click(sender As Object, e As EventArgs) Handles Btn_StopMusic.Click
        ' MP3PLayer.Ctlcontrols.pause()

    End Sub

    Private Sub Btn_PreviousMusic_Click(sender As Object, e As EventArgs) Handles Btn_PreviousMusic.Click
        If CurrentItem - 1 <= 0 Then
            CurrentItem = 0
        Else
            CurrentItem -= 1
        End If
        Addone = False
        Btn_PlayMusic.RaiseClick()

    End Sub

    Private Sub Btn_NextMusic_Click(sender As Object, e As EventArgs) Handles Btn_NextMusic.Click
        Addone = True
        Btn_Play.PerformClick()
    End Sub

    Private Sub Muic_Volume_ValueChanged(sender As Object, e As EventArgs) Handles Music_Volume.ValueChanged
        Try
            ' MP3PLayer.settings.volume = Music_Volume.Value
            PbarVolume.Value = Music_Volume.Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Btn_Mute_Click(sender As Object, e As EventArgs) Handles Btn_Mute.Click
        Music_Volume.Value = 0

    End Sub

    Private Sub Btn_DecreaseVolume_Click(sender As Object, e As EventArgs) Handles Btn_DecreaseVolume.Click
        If Music_Volume.Value - 5 <= 0 Then
            Music_Volume.Value = 0
        Else
            Music_Volume.Value -= 5
        End If
    End Sub

    Private Sub Btn_IncreaseVolume_Click(sender As Object, e As EventArgs) Handles Btn_IncreaseVolume.Click
        If Music_Volume.Value + 5 >= Music_Volume.Maximum Then
            Music_Volume.Value = Music_Volume.Maximum
        Else
            Music_Volume.Value += 5
        End If
    End Sub



    Private Sub Btn_Normal_Click(sender As Object, e As EventArgs) Handles Btn_Normal.Click
    End Sub

    Private Sub Btn_Small_Click(sender As Object, e As EventArgs) Handles Btn_Small.Click
    End Sub
    Public Enum SizeModeFormat
        Small
        Normal
    End Enum
    Private _SizeMode As SizeModeFormat
    Public Property SizeMode() As SizeModeFormat
        Get
            Return _SizeMode
        End Get
        Set(ByVal value As SizeModeFormat)
            If IsNothing(value) Then
                If IsNothing(Me.ParentForm) Then
                Else
                    Me.ParentForm.Size = New Drawing.Size(450, 65)
                End If
                Me.Size = New Drawing.Size(448, 63)
                value = SizeModeFormat.Small
                Btn_Small.Enabled = False
                Btn_Normal.Enabled = True
            Else
                If value = SizeModeFormat.Normal Then
                    Btn_Small.Enabled = True
                    Btn_Normal.Enabled = False
                    If IsNothing(Me.ParentForm) Then
                    Else
                        Me.ParentForm.Size = New Drawing.Size(930, 400)
                    End If
                    Me.Size = New Drawing.Size(917, 380)
                ElseIf value = SizeModeFormat.Small Then
                    Btn_Small.Enabled = False
                    Btn_Normal.Enabled = True
                    If IsNothing(Me.ParentForm) Then
                    Else
                        Me.ParentForm.Size = New Drawing.Size(450, 65)

                    End If
                    Me.Size = New Drawing.Size(448, 63)

                End If
            End If


            _SizeMode = value
        End Set
    End Property

    Private Sub U_MusicPlayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Txt_Music.Text = My.Settings.MusicFolder
        PbarVolume.Value = Music_Volume.Value
        If SizeMode = SizeModeFormat.Normal Then

        ElseIf SizeMode = SizeModeFormat.Small Then

        Else
            SizeMode = SizeModeFormat.Normal
        End If
    End Sub

    Private Sub Btn_Change_MusicFolder_Click(sender As Object, e As EventArgs) Handles Btn_Change_MusicFolder.Click
        Dim FDB As New FolderBrowserDialog
        If FDB.ShowDialog = DialogResult.OK Then
            My.Settings.MusicFolder = FDB.SelectedPath
            My.Settings.Save()
            Txt_Music.Text = My.Settings.MusicFolder
        End If
    End Sub

    Public Property AutoPlay() As Boolean = True
    Public Property Shuffle As Boolean = True
    Private Sub Txt_Music_TextChanged(sender As Object, e As EventArgs) Handles Txt_Music.TextChanged
        If LV_Dir.Items.Count - 1 > 0 Then
            LV_Dir.Items.Clear()
        End If
        Dim Lt = List_Music_FromFolder(My.Settings.MusicFolder, IO.SearchOption.AllDirectories)
        For i = 0 To Lt.Count - 1
            Dim VirtualMusic As MusicInfo = Lt(i)
            '  Dim item As New ListViewItem("<" & i & "> " & VirtualMusic.Artist & " | " & VirtualMusic.SongName)
            ' item.SubItems.Add(VirtualMusic.Artist)
            'item.SubItems.Add(VirtualMusic.SongName)
            'item.SubItems.Add(VirtualMusic.Path)
            'LV_Dir.Items.Add(item)
            LV_Dir.Items.Add(VirtualMusic)
            If AutoPlay = True Then
                LV_Playlist.Items.Add(VirtualMusic)
                Try
                    ' MP3PLayer.newMedia(VirtualMusic.Path)

                Catch ex As Exception

                End Try
            End If
        Next
        If Shuffle = True Then
            Btn_Suffle.RaiseClick()
        End If
    End Sub

    Private Sub Btn_Suffle_Click(sender As Object, e As EventArgs) Handles Btn_Suffle.Click
        If LV_Playlist.Items.Count - 1 <= 1 Then
            Exit Sub
        ElseIf LV_Playlist.Items.Count - 1 >= 2 Then


        End If


        Dim ClipperBag As New List(Of Object)
        For i = 0 To LV_Playlist.Items.Count - 1
            ClipperBag.Add(LV_Playlist.Items(i))
            Try
                '  MP3PLayer.playlistCollection.remove(LV_Playlist.Items(i).Path)
            Catch ex As Exception

            End Try
        Next
        LV_Playlist.Items.Clear()

        ' First round
        Dim Basket As New List(Of Object)
        Do Until ClipperBag.Count - 1 <= 0
            Dim Pick_1 As Integer = GetRandom(0, ClipperBag.Count - 1)
            Basket.Add(ClipperBag(Pick_1))
            ClipperBag.Remove(ClipperBag(Pick_1))
        Loop
        For i = 0 To Basket.Count - 1
            LV_Playlist.Items.Add(Basket(i))
            'MP3PLayer.newMedia(Basket(i).SubItems(3).Text)
        Next
        If AutoPlay = True Then
            Btn_Play.PerformClick()

        End If
    End Sub
End Class
