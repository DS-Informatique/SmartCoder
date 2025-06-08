Imports System.Net
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Module M_Referencing


    Public Class WebSite
        Dim Webmachine As WebBrowser
#Region "<0> [Property]"
#Region "<00.00> <Property> [Reference]"
#Region "<00.00.00> <Property> <Reference> [Input | String]"
        Private _Input As String
        Public Property Input() As String
            Get
                Return _Input
            End Get
            Set(ByVal value As String)
                _Input = value
            End Set
        End Property
#End Region
#Region "<00.00.01> <Property> <Reference> [Article_Title | String]"
        Private _Article_Title As String
        Public Property Article_Title() As String
            Get
                Return _Article_Title
            End Get
            Set(ByVal value As String)
                _Article_Title = value
            End Set
        End Property
#End Region
#Region "<00.00.02> <Property> <Reference> [WebSite_Title | String]"
        Private _WebSite_Title As String
        Public Property WebSite_Title() As String
            Get
                Return _WebSite_Title
            End Get
            Set(ByVal value As String)
                _WebSite_Title = value
            End Set
        End Property
#End Region
#Region "<00.00.03> <Property> <Reference> [URL | String]"
        Private _URL As String
        Public Property URL() As String
            Get
                Return _URL
            End Get
            Set(ByVal value As String)
                _URL = value
            End Set
        End Property
#End Region
#Region "<00.00.04> <Property> <Reference> [Authors | String]"
        Private _Authors As String
        Public Property Authors() As String
            Get
                Return _Authors
            End Get
            Set(ByVal value As String)
                _Authors = value
            End Set
        End Property
#End Region
#Region "<00.00.05> <Property> <Reference> [Publisher | String]"
        Private _Publisher As String
        Public Property Publisher() As String
            Get
                Return _Publisher
            End Get
            Set(ByVal value As String)
                _Publisher = value
            End Set
        End Property
#End Region
#Region "<00.00.06> <Property> <Reference> [Publication_Date | DateTime]"
        Private _Publication_Date As DateTime
        Public Property Publication_Date() As DateTime
            Get
                Return _Publication_Date
            End Get
            Set(ByVal value As DateTime)
                _Publication_Date = value
            End Set
        End Property
#End Region
#Region "<00.00.07> <Property> <Reference> [Rapport | TestItem]"
        Private _Rapport As TestItem
        Public Property Rapport() As TestItem
            Get
                Return _Rapport
            End Get
            Set(ByVal value As TestItem)
                _Rapport = value
            End Set
        End Property
#End Region
#End Region
#End Region
#Region "<5> [New]"
#Region "<05.00> <New> [Empty]"
        Public Sub New()

        End Sub
#End Region
#Region "<05.01> <New> [Input]"
        Public Sub New(ByVal weburl As String)
            Input = weburl
            URL = weburl

        End Sub

#End Region

#End Region
#Region "<4> [Functions]"
#Region "<04.00> <Functions> [Grab]"
#Region "<04.00.00> <Functions> <Grab> [GrabTitle() as String]"
        ''' <summary>
        ''' GrabTitle of webSite
        ''' </summary>
        ''' <returns></returns>
        Public Function GrabTitel() As String
            If URL = "" Then
                Return Nothing
                Exit Function
            End If
            Dim x As New WebClient()
            Try
                Dim source As String = x.DownloadString(URL)
                WebSite_Title = Regex.Match(source, "\<title\b[^>]*\>\s*(?<Title>[\s\S]*?)\</title\>", RegexOptions.IgnoreCase).Groups("Title").Value
                Return WebSite_Title
            Catch ex As Exception
                Return ex.Message
            End Try
        End Function
#End Region
#Region "<04.00.01> <Functions> <Grab> [GrabContent() as String]"
        ''' <summary>
        ''' GrabTitle of webSite
        ''' </summary>
        ''' <returns></returns>
        Public Function GrabContent() As String
            If URL = "" Then
                Return Nothing
                Exit Function
            End If
            Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create(URL)
            Dim response As System.Net.HttpWebResponse = request.GetResponse()

            Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())

            Dim sourcecode As String = sr.ReadToEnd()
            Return sourcecode
        End Function
#End Region
#Region "<04.00.02> <Functions> <Grab> [GrabAuthor() as String]"
        ''' <summary>
        ''' GrabTitle of Author
        ''' </summary>
        ''' <returns></returns>
        Public Function GrabAuthor() As String
            If URL = "" Then
                Return Nothing
                Exit Function
            End If
            Dim x As New WebClient()
            Try
                Dim source As String = x.DownloadString(URL)
                Authors = Regex.Match(source, "\<title\b[^>]*\>\s*(?<Author>[\s\S]*?)\</title\>", RegexOptions.IgnoreCase).Groups("Author").Value
                Return Authors
            Catch ex As Exception
                Return ex.Message
            End Try
        End Function
#End Region
#Region "<04.00.03> <Functions> <Grab> [GrabPublisher() as String]"
        ''' <summary>
        ''' GrabTitle of Publisher
        ''' </summary>
        ''' <returns></returns>
        Public Function GrabPublisher() As String
            If URL = "" Then
                Return Nothing
                Exit Function
            End If
            Dim x As New WebClient()
            Try
                Dim source As String = x.DownloadString(URL)
                Publisher = Regex.Match(source, "\<title\b[^>]*\>\s*(?<Publisher>[\s\S]*?)\</title\>", RegexOptions.IgnoreCase).Groups("Publisher").Value
                Return Publisher
            Catch ex As Exception
                Return ex.Message
            End Try
        End Function
#End Region

#End Region

#End Region
    End Class
End Module
