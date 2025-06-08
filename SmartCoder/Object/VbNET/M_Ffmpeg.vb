Imports System.IO
Imports System.Runtime.CompilerServices

Public Module M_Ffmpeg
    Function RemoveCharacter(ByVal stringToCleanUp As String, ByVal characterToRemove As String) As String
        ' replace the target with nothing
        ' Replace() returns a new String and does not modify the current one
        If Not IsNothing(characterToRemove) Then

            If characterToRemove.Length > 1 Then
                Return stringToCleanUp.Replace(characterToRemove, "")
            Else
                Return stringToCleanUp

            End If
        Else
            Return stringToCleanUp

        End If
    End Function
    Public Enum E_FfmpegFormat
        Mp4
        Avi
        Flv
        Mp3
        Mkv
    End Enum
    Const Mp4 As String = "Mp4"
    Const Avi As String = "Avi"
    Const Flv As String = "Flv"
    Const Mp3 As String = "Mp3"
    Const Mkv As String = "Mkv"
    Public Enum E_FfmpegCategory
        Mobile
        PS3
        TV
        Others
        Audio
    End Enum
    Const Mobile As String = "Mobile"
    Const PS3 As String = "PlayStation 3"
    Const TV As String = "TV"
    Const Others As String = "Other Formats"
    Const Audio As String = "Audio"
    Public Enum E_FfmpegKbs
        kbs_128
        kbs_192
        kbs_320
        kbs_Nul
    End Enum
    Public Const kbs_128 As String = "128kbs"
    Public Const kbs_192 As String = "192kbs"
    Public Const kbs_320 As String = "320kbs"
    Public Const kbs_Nul As String = "Nul"

    ''' <summary>
    ''' Extension method to run string as CMD command.
    ''' </summary>
    ''' <param name="command">[String] Command to run.</param>
    ''' <param name="ShowWindow">[Boolean](Default:False) Option to show CMD window.</param>
    ''' <param name="WaitForProcessComplete">[Boolean](Default:False) Option to wait for CMD process to complete before exiting sub.</param>
    ''' <param name="permanent">[Boolean](Default:False) Option to keep window visible after command has finished. Ignored if ShowWindow is False.</param>
    <Extension>
    Public Sub RunCMD(command As String, Optional ShowWindow As Boolean = False, Optional WaitForProcessComplete As Boolean = False, Optional permanent As Boolean = False)
        Dim p As Process = New Process()
        Dim pi As ProcessStartInfo = New ProcessStartInfo()
        pi.Arguments = " " + If(ShowWindow AndAlso permanent, "/K", "/C") + " " + command
        pi.FileName = "cmd.exe"
        pi.CreateNoWindow = Not ShowWindow
        If ShowWindow Then
            pi.WindowStyle = ProcessWindowStyle.Normal
        Else
            pi.WindowStyle = ProcessWindowStyle.Hidden
        End If
        p.StartInfo = pi
        p.Start()
        If WaitForProcessComplete Then Do Until p.HasExited : Loop
    End Sub
End Module
