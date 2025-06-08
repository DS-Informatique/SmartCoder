Imports System.Windows.Forms

Public Class WebPage


    Private _AutoInitialise As Boolean
    Public Property AutoInitialise() As Boolean
        Get
            Return _AutoInitialise
        End Get
        Set(ByVal value As Boolean)
            _AutoInitialise = value
        End Set
    End Property

    Private _URL As String
    Public Property URL() As String
        Get
            Return _URL
        End Get
        Set(ByVal value As String)
            If IsNothing(value) Then
                value = "http://www.saadry-dunkel.com/"
            Else

            End If
            CB_URL.Text = value
            If AutoInitialise = True Then

            Else

            End If
            _URL = value
        End Set
    End Property


    Private Sub Btn_Back_Click(sender As Object, e As EventArgs) Handles Btn_Back.Click
        If WebEngine = WebInstrument.WebBrowser Then
            Try
                WebBrowser1.GoBack()
            Catch ex As Exception
                Note_Web.Text += Format_Error(ex) & vbNewLine
            End Try
        Else
            Try
                AxWebBrowser1.GoBack()
            Catch ex As Exception
                Note_Microsoft.Text += Format_Error(ex) & vbNewLine
            End Try
        End If
    End Sub

    Private Sub Btn_Home_Click(sender As Object, e As EventArgs) Handles Btn_Home.Click
        If WebEngine = WebInstrument.WebBrowser Then
            Try
                WebBrowser1.GoHome()
            Catch ex As Exception
                Note_Web.Text += Format_Error(ex) & vbNewLine
            End Try
        Else
            Try
                AxWebBrowser1.GoHome()
            Catch ex As Exception
                Note_Microsoft.Text += Format_Error(ex) & vbNewLine
            End Try
        End If
    End Sub

    Private Sub Btn_Next_Click(sender As Object, e As EventArgs) Handles Btn_Next.Click
        If WebEngine = WebInstrument.WebBrowser Then
            Try
                WebBrowser1.GoForward()
            Catch ex As Exception
                Note_Web.Text += Format_Error(ex) & vbNewLine
            End Try
        Else
            Try
                AxWebBrowser1.GoForward()
            Catch ex As Exception
                Note_Microsoft.Text += Format_Error(ex) & vbNewLine
            End Try
        End If
    End Sub

    Private Sub Btn_Go_Click(sender As Object, e As EventArgs) Handles Btn_Go.Click
        Dim addit As Boolean = True
        If CB_URL.Items.Count - 1 > 0 Then
            For i = 0 To CB_URL.Items.Count - 1
                If CB_URL.Items(i).ToString = URL Then
                    addit = False
                End If
            Next
        End If
        If addit = True Then
            CB_URL.Items.Add(URL)
        End If
        If WebEngine = WebInstrument.WebBrowser Then
            Try
                WebBrowser1.Navigate(CB_URL.Text)
            Catch ex As Exception
                Note_Web.Text += Format_Error(ex) & vbNewLine
            End Try
        Else
            Try
                AxWebBrowser1.Navigate(CB_URL.Text)
            Catch ex As Exception
                Note_Microsoft.Text += Format_Error(ex) & vbNewLine
            End Try
        End If
    End Sub

    Private Sub Cmd_Navigate_Executed(sender As Object, e As EventArgs) Handles Cmd_Navigate.Executed
        ' Status.Text = "En chargement"
        ' WebBrowser1.Navigate(URL)
        ' AxWebBrowser1.Navigate(URL)
        If WebEngine = WebInstrument.Miscrosoft_WebBrowser Then
            AxWebBrowser1.Navigate(URL)
        Else
            WebBrowser1.Navigate(URL)

        End If

        Dim addit As Boolean = True
        If CB_URL.Items.Count - 1 > 0 Then
            For i = 0 To CB_URL.Items.Count - 1
                If CB_URL.Items(i).ToString = URL Then
                    addit = False
                End If
            Next
        End If
        If addit = True Then
            CB_URL.Items.Add(URL)
        End If
        ' Status.Text = "Chargement terminer"
        IProp_AxWebBrowser1.SelectedObject = AxWebBrowser1
        IProp_WebBrowser1.SelectedObject = WebBrowser1
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As Windows.Forms.WebBrowserDocumentCompletedEventArgs)
        Web_Url.Text = WebBrowser1.Url.ToString
    End Sub

    Private Sub AxWebBrowser1_DocumentComplete(sender As Object, e As AxSHDocVw.DWebBrowserEvents2_DocumentCompleteEvent)
        MS_URL.Text = AxWebBrowser1.LocationURL
    End Sub

    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        If CB_Search.Text = "" Then
        Else
            ' If ST_Window.SelectedTabIndex = 0 Then
            URL = M_Web.iGoogle.SearchUrl & CB_Search.Text
            Cmd_Navigate.Execute()
            '  End If
        End If
    End Sub

    Private Sub Btn_SearchGoogle_Click(sender As Object, e As EventArgs) Handles Btn_SearchGoogle.Click
        Btn_Search.RaiseClick()
    End Sub

    Private Sub Btn_SearchDirectories_Click(sender As Object, e As EventArgs) Handles Btn_SearchYahoo.Click
        If CB_Search.Text = "" Then
        Else
            'I 'f ST_Window.SelectedTabIndex = 0 Then
            URL = M_Web.iYahoo.SearchUrl & CB_Search.Text
                Cmd_Navigate.Execute()
            'End If
        End If
    End Sub

    Private Sub Btn_SearchYoutube_Click(sender As Object, e As EventArgs) Handles Btn_SearchYoutube.Click
        If CB_Search.Text = "" Then
        Else
            ' If ST_Window.SelectedTabIndex = 0 Then
            URL = M_Web.iYoutube.SearchUrl & CB_Search.Text
                Cmd_Navigate.Execute()
            'End If
        End If
    End Sub

    Private Sub Btn_Search_RC_Click(sender As Object, e As EventArgs) Handles Btn_Search_RC.Click
        If CB_Search.Text = "" Then
        Else
            URL = M_Web.iRC.SearchUrl & CB_Search.Text
            Cmd_Navigate.Execute()
        End If
    End Sub

    Private Sub Btn_Change_MusicFolder_Click(sender As Object, e As EventArgs) Handles Btn_Change_MusicFolder.Click
        Dim FDB As New FolderBrowserDialog
        If FDB.ShowDialog = DialogResult.OK Then
            My.Settings.MusicFolder = FDB.SelectedPath
            My.Settings.Save()
            Txt_MusicFolder.Text = My.Settings.MusicFolder
        End If
        If LV_Dir.Items.Count - 1 > 0 Then
            LV_Dir.Items.Clear()
        End If
        Dim Lt = List_Music_FromFolder(My.Settings.MusicFolder, IO.SearchOption.AllDirectories)
        For i = 0 To Lt.Count - 1
            Dim VirtualMusic As MusicInfo = Lt(i)
            Dim item As New ListViewItem(i)
            item.SubItems.Add(VirtualMusic.Artist)
            item.SubItems.Add(VirtualMusic.Path)
            item.SubItems.Add(VirtualMusic.SongName)
            LV_Dir.Items.Add(item)
        Next
    End Sub


    Private Sub WebPage_Load(sender As Object, e As EventArgs) Handles Me.Load
        Txt_MusicFolder.Text = My.Settings.MusicFolder

    End Sub

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

        MP3PLayer.URL = LV_Playlist.Items(CurrentItem).SubItems(2).Text
        CurrentStr = LV_Playlist.Items(CurrentItem).SubItems(2).Text
        L_SongName.Text = LV_Playlist.Items(CurrentItem).SubItems(3).Text
        'MP3PLayer.Ctlcontrols.play()
        ' U_Timer1.Btn_Start.RaiseClick()
        Timer1.Start()
        'L_Timer.Text = U_Timer1.L_Time.Text
        ' U_Timer1.Btn_Reset.RaiseClick()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        '   If MP3PLayer.playState = WMPLib.WMPPlayState.wmppsStopped Then
        '  Btn_Play.PerformClick()
        ' End If
    End Sub

    Private Sub Btn_Stop_Click(sender As Object, e As EventArgs)
        Timer1.Stop()
        'MP3PLayer.Ctlcontrols.pause()
        ' U_Timer1.Btn_Stop.RaiseClick()
    End Sub

    Private Sub Btn_PauseMusic_Click(sender As Object, e As EventArgs) Handles Btn_PauseMusic.Click
        'MP3PLayer.Ctlcontrols.pause()
    End Sub

    Private Sub Btn_StopMusic_Click(sender As Object, e As EventArgs) Handles Btn_StopMusic.Click, Btn_Stop.Click
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
            '  MP3PLayer.settings.volume = Music_Volume.Value
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

    Private Sub Txt_MusicFolder_TextChanged(sender As Object, e As EventArgs) Handles Txt_MusicFolder.TextChanged
        If LV_Dir.Items.Count - 1 > 0 Then
            LV_Dir.Items.Clear()
        End If
        Dim Lt = List_Music_FromFolder(My.Settings.MusicFolder, IO.SearchOption.AllDirectories)
        For i = 0 To Lt.Count - 1
            Dim VirtualMusic As MusicInfo = Lt(i)
            Dim item As New ListViewItem(i)
            item.SubItems.Add(VirtualMusic.Artist)
            item.SubItems.Add(VirtualMusic.Path)
            item.SubItems.Add(VirtualMusic.SongName)
            LV_Dir.Items.Add(item)
        Next
    End Sub
    ' Public Property WebEngine As WebInstrument = WebInstrument.Miscrosoft_WebBrowser

    Private _WebEngine As WebInstrument
    Public Property WebEngine() As WebInstrument
        Get
            Return _WebEngine
        End Get
        Set(ByVal value As WebInstrument)
            If IsNothing(value) Then
                value = WebInstrument.Miscrosoft_WebBrowser
                Btn_WebBrowser.Enabled = True
                Btn_MSWeb.Enabled = False
            Else
                If value = WebInstrument.Miscrosoft_WebBrowser Then
                    Btn_MSWeb.Enabled = False
                    Btn_WebBrowser.Enabled = True
                Else
                    Btn_MSWeb.Enabled = True
                    Btn_WebBrowser.Enabled = False
                End If

            End If
            _WebEngine = value
        End Set
    End Property
    Public Enum WebInstrument
        WebBrowser
        Miscrosoft_WebBrowser
    End Enum
    Private Sub Btn_WebBrowser_Click(sender As Object, e As EventArgs) Handles Btn_WebBrowser.Click
        ' If WebEngine = WebInstrument.Miscrosoft_WebBrowser Then
        WebEngine = WebInstrument.WebBrowser
        'ElseIf WebEngine = WebInstrument.WebBrowser Then
        'WebEngine = WebInstrument.Miscrosoft_WebBrowser
        'End If

        If WebEngine = WebInstrument.Miscrosoft_WebBrowser Then
            Dock_WebBrowser.Visible = False
            Dock_MSWeb.Visible = True
        ElseIf WebEngine = WebInstrument.WebBrowser Then
            Dock_WebBrowser.Visible = True
            Dock_MSWeb.Visible = False

        End If
    End Sub

    Private Sub Btn_MSWeb_Click(sender As Object, e As EventArgs) Handles Btn_MSWeb.Click
        ' If WebEngine = WebInstrument.Miscrosoft_WebBrowser Then
        'WebEngine = WebInstrument.WebBrowser
        'ElseIf WebEngine = WebInstrument.WebBrowser Then
        WebEngine = WebInstrument.Miscrosoft_WebBrowser
        'End If

        If WebEngine = WebInstrument.Miscrosoft_WebBrowser Then
            Dock_WebBrowser.Visible = False
            Dock_MSWeb.Visible = True
        ElseIf WebEngine = WebInstrument.WebBrowser Then
            Dock_WebBrowser.Visible = True
            Dock_MSWeb.Visible = False

        End If
    End Sub

    Private Sub Btn_Random_Click(sender As Object, e As EventArgs) Handles Btn_Random.Click

    End Sub
End Class
