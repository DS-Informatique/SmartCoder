Imports System.ComponentModel
Imports System.Drawing
Imports System.IO
Imports System.Net
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports DevComponents.DotNetBar
Imports YoutubeExtractor

Public Module M_Web
#Region "<0> [Properties]"
#Region "<00.01> <Properties> [MySearchEngine_Web|List(Of SearchEngine_Web)]"
    Private _MySearchEngine_Web As List(Of SearchEngine)
    '''<summary>
    '''(Set|Get) List of SearchEngine
    '''</summary>
    <CategoryAttribute("Properties"), Description("(Set|Get) List of SearchEngine"), Browsable(True)>
    Public Property MySearchEngine_Web() As List(Of SearchEngine)
        Get
            Return _MySearchEngine_Web
        End Get
        Set(ByVal value As List(Of SearchEngine))
            _MySearchEngine_Web = value

        End Set
    End Property
#End Region
#End Region
#Region "<1> [Enumeration]"
    Public Enum SearchEngine_Web
        iGoogle
        iYahoo
        iMicrosoft
        iRC
        iSaadryDunkel
        iYoutube
    End Enum
    Public iGoogle As New SearchEngine("Google", "http://www.google.com", "https://www.google.com/search?ei=fpv6WoerGI7UgQaniZaACw&q=")
    Public iYahoo As New SearchEngine("Yahoo", "http://www.yahoo.com", "https://search.yahoo.com/search?p=")
    Public iMicrosoft As New SearchEngine("Microsoft", "http://www.msdn.microsoft.com", "https://msdn.microsoft.com/en-us/library/")
    Public iRC As New SearchEngine("Registre du Commerce", "https://www.zefix.ch/en/search/entity/welcome", "https://www.zefix.ch/en/search/entity/list?name=")
    Public iSaadryDunkel As New SearchEngine("SaadryDunkel", "https://www.saadry-dunkel.com")
    Public iYoutube As New SearchEngine("Youtube", "https://www.youtube.com/", "https://www.youtube.com/watch?v=", "https://www.youtube.com/watch/v/")

#End Region
#Region "<4> [Functions]"
#Region "<04.01> <Functions> [List_SearchEngine]"
    Public Function List_SearchEngine() As List(Of SearchEngine)
        MySearchEngine_Web = New List(Of SearchEngine)
        MySearchEngine_Web.Add(iGoogle)
        MySearchEngine_Web.Add(iYahoo)
        MySearchEngine_Web.Add(iMicrosoft)
        MySearchEngine_Web.Add(iRC)
        MySearchEngine_Web.Add(iSaadryDunkel)
        MySearchEngine_Web.Add(iYoutube)
        Return MySearchEngine_Web
    End Function
#End Region
#End Region
#Region "<7> [Classes]"

#End Region
    Public Function GetFileNameFrom_Url(ByVal Url As String) As String
        Dim uri As New Uri(Url)
        Dim fileName As String = IO.Path.GetFileName(uri.LocalPath)
        Return fileName
    End Function

    Public Function DownloadYTVideo(ByVal url As String) As String
        Dim Y As New Youtube(url)
        If My.Settings.DownloadDir = "" Then
            My.Settings.DownloadDir = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Tempfiles"
            My.Settings.Save()

        End If
        If IO.Directory.Exists(My.Settings.DownloadDir) = False Then
            IO.Directory.CreateDirectory(My.Settings.DownloadDir)
        End If
        Try
            Y.Download(url, My.Settings.DownloadDir, 0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Do Until IsNothing(Y.DownloadedVideo) = False

        Loop
        Return Y.DownloadedVideo.Target
    End Function

    Public Class Youtube

        Dim wc As WebClient
        Public StrArrayLinks(), strArrayExts(), StrDefTitle, StrFullPath As String
        Public Property Title As String
        Public Property Url As String
        Public Property Thumbnail As PictureBox
        Public Property ProgressBar As ProgressBar
        Public Property ListFormat As New List(Of Object)
        Public Property ListDL As New List(Of String)
        Public Property ListExt As New List(Of String)
        Public Property DownloadPercentage As String
        Public Property DownloadStatus As String
        Public Property DownloadedVideo As Fichier
        Public Property VLCUrl As String
        Public Property Name As String
        Public Sub RequestLinks(ByVal url As String)
            Dim VInfos As IEnumerable(Of VideoInfo)
            VInfos = DownloadUrlResolver.GetDownloadUrls(url, False)
            ListFormat = New List(Of Object)
            ListDL = New List(Of String)
            ListExt = New List(Of String)


            Dim blnFlag As Boolean = True
            For Each vi As VideoInfo In VInfos
                If blnFlag = True Then
                    StrDefTitle = vi.Title
                    blnFlag = False
                End If
                Dim StrQuality As String
                StrQuality = "Resolution : " & vi.Resolution & " Format: " & vi.VideoExtension
                ListFormat.Add(StrQuality)

                If vi.RequiresDecryption Then
                    DownloadUrlResolver.DecryptDownloadUrl(vi)
                End If
                ListDL.Add(vi.DownloadUrl)
                ListExt.Add(vi.VideoExtension)
            Next
            StrArrayLinks = ListDL.ToArray
            strArrayExts = ListExt.ToArray
        End Sub
        Public Property SelectedIndex As Integer = -1
        Public Sub New()
            Thumbnail = New PictureBox
            ProgressBar = New ProgressBar
            ListFormat = New List(Of Object)
            ListDL = New List(Of String)
            ListExt = New List(Of String)
        End Sub
        Public Overrides Function ToString() As String
            Return Title
        End Function
        Public Sub New(ByVal Url As String, Optional ByVal Name As String = "")
            Me.Url = Url
            Me.Name = Name
#Region "<Initialise>"
            Thumbnail = New PictureBox
            ProgressBar = New ProgressBar
            Try
                '     RequestLinks(Url)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
#End Region
            Try
                Thumbnail.Load(GrabThumbnail)
            Catch ex As Exception
                '     MsgBox(ex.Message)
            End Try
            Try
                Dim Result As String = iYoutube.FormattedUrl
                Dim youtubeCoordinate As String = Remove_Character_FromString(Url, "https://www.youtube.com/watch?v=")
                Result &= youtubeCoordinate
                VLCUrl = Result
            Catch ex As Exception

            End Try
        End Sub
        Public Sub Downloadnew(ByVal url As String, ByVal Where As String, Optional ByVal extension As String = ".mp4")
            wc = New WebClient()
            AddHandler wc.DownloadProgressChanged, AddressOf DownloadPC
            AddHandler wc.DownloadFileCompleted, AddressOf DownloadComp

            For i = 0 To strArrayExts.Count - 1
                If strArrayExts(i).Contains(extension) Then
                    SelectedIndex = i
                End If
            Next
            If SelectedIndex = -1 Then
                SelectedIndex = 0
            End If

            If Title = "" Then
                StrFullPath = Where & "\" & StrDefTitle & extension
                wc.DownloadFileAsync(New Uri(StrArrayLinks(SelectedIndex)), StrFullPath)
            Else
                StrFullPath = Where & "\" & Title & extension
                wc.DownloadFileAsync(New Uri(StrArrayLinks(SelectedIndex)), StrFullPath)
            End If
        End Sub
        Public Sub Download(ByVal url As String, ByVal Where As String, ByVal Index As Integer)
            wc = New WebClient()
            AddHandler wc.DownloadProgressChanged, AddressOf DownloadPC
            AddHandler wc.DownloadFileCompleted, AddressOf DownloadComp

            If Title = "" Then
                StrFullPath = Where & "\" & StrDefTitle & strArrayExts(Index)
                wc.DownloadFileAsync(New Uri(StrArrayLinks(Index)), StrFullPath)
            Else
                StrFullPath = Where & "\" & Title & strArrayExts(Index)
                wc.DownloadFileAsync(New Uri(StrArrayLinks(Index)), StrFullPath)
            End If
        End Sub
        Public Sub DownloadPC(sender As Object, e As DownloadProgressChangedEventArgs)
            ProgressBar.Value = e.ProgressPercentage
            DownloadPercentage = e.ProgressPercentage.ToString() & "%"
            DownloadStatus = String.Format("{0} MB's / {1} MB's", (e.BytesReceived / 1024D / 1024D).ToString("0.00"), (e.TotalBytesToReceive / 1024D / 1024D).ToString("0.00"))
        End Sub
        Public Sub DownloadComp(Sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs)
            MessageBox.Show("Your download is completed", "System.Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DownloadedVideo = New Fichier(StrFullPath)
        End Sub
        ''' <summary>
        ''' This functions returns the ImageLocation of the video.
        ''' Example: PictureBox1.Load([Youtube].GrabThumbnail)
        ''' </summary>
        ''' <returns></returns>
        Public Function GrabThumbnail() As String
            Dim RString As String = "http://img.youtube.com/vi/"
            Dim youtubeCoordinate As String = Remove_Character_FromString(Url, "https://www.youtube.com/watch?v=")
            RString &= youtubeCoordinate & "/default.jpg"
            Return RString
        End Function
    End Class

    Public MyVideos As New List(Of Youtube)
    Public Function Grab_Videos() As List(Of Youtube)
        MyVideos = New List(Of Youtube)
        MyVideos.Add(Video_Hubble)
        MyVideos.Add(Video_Ocean)
        MyVideos.Add(Video_NewYork)
        MyVideos.Add(Video_London)
        MyVideos.Add(Video_California)
        MyVideos.Add(Video_ISS)
        MyVideos.Add(Video_SkyNew)
        MyVideos.Add(Video_Nasa)
        MyVideos.Add(Video_Bloomberg)
        MyVideos.Add(Video_FoxNews)
        MyVideos.Add(Video_Russia24)
        MyVideos.Add(Video_France24)
        MyVideos.Add(Video_RTFrance)
        MyVideos.Add(Video_FranceInfo)
        MyVideos.Add(Video_CNN)
        MyVideos.Add(Video_CNBC)
        MyVideos.Add(Video_FashionTv)
        MyVideos.Add(Video_VocalTranceRadio)
        MyVideos.Add(Video_ChillYourMind)
        MyVideos.Add(Video_TheGoodLife)
        MyVideos.Add(Video_DeepHouse)
        Return MyVideos
    End Function

    Public Enum MyVideoList
        Empty
        Hubble
        Ocean
        NewYork
        London
        California
        ISS
        SkyNew
        Nasa
        Bloomberg
        FoxNews
        Russia24
        France24
        RTFrance
        FranceInfo
        CNN
        CNBC
        SpaceX
        FashionTV
        Kygo
    End Enum
    Public Property Video_Hubble As New Youtube("https://www.youtube.com/watch?v=RY4uivIh-ik&t=2461s", "Hubble")
    Public Property Video_Ocean As New Youtube("https://www.youtube.com/watch?v=zJ7hUvU-d2Q&t=976s", "Ocean")
    Public Property Video_NewYork As New Youtube("https://www.youtube.com/watch?v=TmDKbUrSYxQ", "New York")
    Public Property Video_London As New Youtube("https://www.youtube.com/watch?v=X8zLJlU_-60", "London")
    Public Property Video_California As New Youtube("https://www.youtube.com/watch?v=iYrRlnnTSjA", "California")
    Public Property Video_ISS As New Youtube("https://www.youtube.com/watch?v=QwvBDC13Iqg", "ISS Station")
    Public Property Video_SkyNew As New Youtube("https://www.youtube.com/watch?v=siyW0GOBtbo", "Sky News Live")
    Public Property Video_Nasa As New Youtube("https://www.youtube.com/watch?v=21X5lGlDOfg", "Nasa Live")
    Public Property Video_Bloomberg As New Youtube("https://www.youtube.com/watch?v=dp8PhLsUcFE", "Bloomberg")
    Public Property Video_FoxNews As New Youtube("https://www.youtube.com/watch?v=Mieu57c0Fc0", "FoxNews")
    Public Property Video_Russia24 As New Youtube("https://www.youtube.com/watch?v=8T9SFZDP60Q", "Russia 24")
    Public Property Video_France24 As New Youtube("https://www.youtube.com/watch?v=wwNZKfBLAsc", "France 24")
    Public Property Video_RTFrance As New Youtube("https://www.youtube.com/watch?v=J6JieD7pZZc", "RTFrance")
    Public Property Video_FranceInfo As New Youtube("https://www.youtube.com/watch?v=wwNZKfBLAsc", "FranceInfo")
    Public Property Video_CNN As New Youtube("https://www.youtube.com/watch?v=2sfjPpqdSZQ", "CNN Live")
    Public Property Video_CNBC As New Youtube("https://www.youtube.com/channel/UCrp_UI8XtuYfpiqluWLD7Lw", "CNBC Live")
    'SpaceX Launch: Falcon 9 Telstar 18V -
    Public Property Video_FashionTv As New Youtube("https://www.youtube.com/watch?v=7URik9HUd1E", "FashionTV Live")
    'New 2019
    Public Property Video_VocalTranceRadio As New Youtube("https://www.youtube.com/watch?v=C6_ql03n-vQ", "VocalTranceRadio")
    Public Property Video_ChillYourMind As New Youtube("https://www.youtube.com/watch?v=sPeGGyAfVo0", "ChillYourMind")

    Public Property Video_TheGoodLife As New Youtube("https://www.youtube.com/watch?v=taD9hqwCb1o", "TheGoodLife")
    Public Property Video_DeepHouse As New Youtube("https://www.youtube.com/watch?v=WsDyRAPFBC8", "Deep House 24/7: Relaxing Music • Chill Study Music")

End Module
