Imports System.Net.Mail
Imports System.Windows.Forms
Public Module EmailSender
    Public Class EmailInfo

        Public Structure EmailServer
            Public Host As Hosts_Providers
            Public Host_Out As String
            Public Port_Out As String
            Public Use_SSL_Out As Boolean
            Public Host_In As String
            Public Port_In As String
            Public Use_SSL_In As Boolean
            Public Email As String
            Public Pass As String
        End Structure
        Public Account As New EmailServer
        Public Enum Hosts_Providers
            Gmail = 0
            Yahoo = 1
            Hotmail = 2
            Outlook = 3
            Exchange = 4
            Infomaniak = 5
        End Enum
        Private _Email As MailMessage
        Public Property Email() As MailMessage
            Get
                Return _Email
            End Get
            Set(ByVal value As MailMessage)
                _Email = value
            End Set
        End Property
        Private _Client As SmtpClient
        Public Property Client() As SmtpClient
            Get
                Return _Client
            End Get
            Set(ByVal value As SmtpClient)
                _Client = value
            End Set
        End Property
        Public Sub New()

            ' This call is required by the designer.

            ' Add any initialization after the InitializeComponent() call.
            Client = New SmtpClient()
            Email = New MailMessage
            Account.Email = "saadry.dunkel@gmail.com"
        End Sub
#Region "<Functions>"


        Public Shared Function Retrieve_Config(ByVal Email As String,
                                           Optional ByVal Pass As String = "",
                                       Optional ByVal Host As String = "",
                                       Optional ByVal InPort As Integer = 587) As SmtpClient
            Dim Result As New SmtpClient
            'If IsNothing(Account) Then
            'L_Status.Text = "Warning Account is not set : Creating a new account"
            Dim Account As New EmailServer
            Account.Email = Email
            If Pass = "" Then
                Pass = "Dunke92606!"
            End If
            Account.Pass = Pass
            If Email.ToLower.Contains("yahoo") Then
                Account.Host_Out = "smtp.yahoo.com"
                Account.Port_In = "587"
                Account.Use_SSL_Out = True
                Account.Host_In = "pop.yahoo.com"
                Account.Port_Out = "997"
                Account.Use_SSL_Out = True
            ElseIf Email.Contains("gmail") Then
                Account.Host_Out = "smtp.gmail.com"
                Account.Port_In = "587"
                Account.Use_SSL_Out = True
                Account.Host_In = "pop.gmail.com"
                Account.Port_Out = "997"
                Account.Use_SSL_Out = True
            ElseIf Email.Contains("outlook") Then
                Account.Host_Out = "smtp-mail.outlook.com"
                Account.Port_In = "587"
                Account.Use_SSL_Out = True
                Account.Host_In = "pop-mail.outlook.com"
                Account.Port_Out = "995"
                Account.Use_SSL_Out = True
            ElseIf Email.Contains("hotmail") Then
                Account.Host_Out = "smtp-mail.outlook.com"
                Account.Port_In = "587"
                Account.Use_SSL_Out = True
                Account.Host_In = "pop-mail.outlook.com"
                Account.Port_Out = "995"
                Account.Use_SSL_Out = True
            ElseIf Email.Contains("infomaniak") Then
                Account.Host_Out = "mail.infomaniak.ch"
                Account.Port_Out = "587"
                Account.Use_SSL_Out = True
                Account.Host_In = "mail.infomaniak.ch"
                Account.Port_Out = "995"
                Account.Use_SSL_Out = True
            End If

            With Result
                .Credentials = New Net.NetworkCredential(Email, Pass)
                .Host = Account.Host_Out
                .Port = Val(Account.Port_Out)
                .EnableSsl = True
            End With
            '   L_Status.Text = "Finish setting sending configuration."

            Return Result
        End Function
#End Region
        Public Shared Function SendReport(ByVal Content As String, ByVal Subjects As String,
                                        Optional ByVal ListofRecipients As List(Of String) = Nothing,
                                        Optional ByVal Attachementstring As String = "") As Boolean
            Dim iClient As New SmtpClient
            Dim iEmail As New MailMessage
            With iEmail
                .From = New MailAddress("saadry.dunkel@gmail.com")
                If IsNothing(ListofRecipients) Then
                Else
                    If ListofRecipients.Count - 1 > 0 Then
                        For i = 0 To ListofRecipients.Count - 1
                            .To.Add(ListofRecipients(i).ToString)
                        Next
                    End If
                End If
                .IsBodyHtml = True
                .To.Add("saadry.dunkel@outlook.com")
                .Subject = Subjects
                .Body = Content
                If Attachementstring = "" Then
                Else
                    Dim iattach As New Attachment(Attachementstring)
                    .Attachments.Add(iattach)
                End If
            End With
            Dim Result As Boolean = False
            Try
                Retrieve_Config(iEmail.From.ToString).Send(iEmail)
                Result = True
                ' MsgBox("Report Sent")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
            Return Result
        End Function
    End Class

End Module
