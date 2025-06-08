Public Class UWeb


    Private _URL As String
    Public Property URL() As String
        Get
            Return _URL
        End Get
        Set(ByVal value As String)
            Try
                AxWebBrowser1.Navigate(value)
            Catch ex As Exception

            End Try
            _URL = value
        End Set
    End Property
End Class
