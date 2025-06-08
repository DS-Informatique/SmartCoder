Imports System.Speech
Imports System.Drawing
Imports System.Speech.Synthesis
Imports System.ComponentModel
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls

Public Module M_Voice
    Public Class Voice
#Region "<1> [Property]{0}"
#Region "[On] |2019/06/01 14h02:262| <01.00.00> <Property> <Info> |.Voie()|SpeechSynthesizer|"' (Set|Get) The Voie as SpeechSynthesizer.
        Private _Voie As SpeechSynthesizer
        '''    <Summary>
        '''     (Set|Get) The Voie as SpeechSynthesizer.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/01 14h04:379 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.
        '''    All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.
        '''    The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>

        <Browsable(True), CategoryAttribute("Info"), Description("(Set|Get) The Voie as SpeechSynthesizer.")>
        Friend Property Voie() As SpeechSynthesizer
            Get
                Return _Voie
            End Get
            Set(ByVal Value As SpeechSynthesizer)
                _Voie = Value
            End Set
        End Property
#End Region '(Set|Get) The Voie as SpeechSynthesizer.

#End Region
#Region "|4| [Sub]"
#Region "[On] |2019/06/01 13h54:475| <04.00.00> <Sub> <> |.SpeakAsync()|Sub}|"' (Set|Get) The sub SpeakAsync.
        '''    <Summary>
        '''     (Set|Get) The sub SpeakAsync.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/01 14h03:719 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>

        <Browsable(True), Description("(Set|Get) The sub SpeakAsync.")>
        Public Sub SpeakAsync(ByVal Message As String)
            Using Voie As New SpeechSynthesizer
                Voie.Volume = My.Settings.SpeechVolume
                Voie.Rate = My.Settings.SpeechRate
                AddHandler Voie.SpeakCompleted, AddressOf speakCompleted
                Voie.SetOutputToDefaultAudioDevice()
                Voie.SpeakAsync(Message)
            End Using
        End Sub
#End Region '(Set|Get) The sub SpeakAsync.
#Region "[On] |2019/06/01 13h54:475| <04.00.01> <Sub> <> |.Speak()|Sub}|"' (Set|Get) The sub SpeakAsync.
        '''    <Summary>
        '''     (Set|Get) The sub SpeakAsync.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/01 14h08:537 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>

        <Browsable(True), Description("(Set|Get) The sub SpeakAsync.")>
        Public Sub Speak(ByVal Message As String)
            If Trim(Message).Length > 0 Then

                If My.Settings.Speak = False Then
                    MsgBox(Message, vbYesNoCancel, "Information")
                Else
                    Voie.Rate = My.Settings.SpeechRate
                    Voie.Volume = My.Settings.SpeechVolume
                    Voie.SpeakAsync(Message)
                End If
                Dim color As eDesktopAlertColor = CType(eDesktopAlertColor.Default, eDesktopAlertColor)
                Dim position As eAlertPosition = CType(eAlertPosition.BottomRight, eAlertPosition)
                DesktopAlert.Show(Message, color, position)
            End If

        End Sub
#End Region '(Set|Get) The sub SpeakAsync.

#End Region
#Region "|7| [Loader]"
#Region "|07.00| <Loader> [Empty]"
        Public Sub New()
            Voie = New SpeechSynthesizer
            With Voie
                .Volume = My.Settings.SpeechVolume
                .Rate = My.Settings.SpeechRate
            End With
        End Sub
#End Region
#End Region

#Region "|10| [Event]"
#Region "[On] |2019/06/01 13h54:475| <10.00.00> <Event> <> |.speakCompleted()|Event}|"' (Set|Get) The Event SpeakAsync.
        Friend Sub speakCompleted(ByVal sender As Object, ByVal e As SpeakCompletedEventArgs)

        End Sub
#End Region
#End Region
    End Class

    Public Class Listen
        Public WithEvents Recognizer As New Recognition.SpeechRecognitionEngine
        Public Lexic As New Recognition.SrgsGrammar.SrgsDocument

    End Class
End Module
