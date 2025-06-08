
#Region "[On] |2019/07/04 23h12:824| <08.00.00> <Class> <> |.RemoteDesktopConnection|Class|{3} |Production Cost : 7.2|Selling Price : 10.8|"' 
Imports System.ComponentModel
Imports System.Windows.Forms
'''    <Summary>
'''     '''    Object Name :             Public  Class RemoteDesktopConnection
'''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
'''    Contributor Information : ||
'''    Creation Date :           2019/07/04 23h12:824
'''    |Schema|
'''    |ID| |ObjectType |{Quantity}||UnitPrice||Total
'''    |00| |Importation|{0}||1| |0
'''    |01| |Properties |{3}||0.8| |2.4
'''    |02| |Enumeration|{0}||0.4| |0
'''    |03| |Structure  |{0}||0.4| |0
'''    |04| |Sub        |{0}||1.2| |0
'''    |05| |Function   |{0}||1.6| |0
'''    |06| |Runtime    |{0}||0.4| |0
'''    |07| |Loader     |{0}||0.8| |0
'''    |08| |Class      |{0}||2| |0
'''    |09| |Constante  |{0}||0.4| |0
'''    |10| |Event      |{4}||1.2| |4.8
'''    |11| |Members    |{0}||0.5| |0
'''    |12| |Parameter  |{0}||0.5| |0
'''    |Production Cost             |7.2
'''    |Selling Price without VAT   |10.8
'''    |Total TVA                   |0.83
'''    |Grand Total                 |11.63
'''    |/Schema|
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/04 23h21:886 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary
Public Class RemoteDesktopConnection
#Region "<1> [Property]{3}"
#Region "[On] |2019/07/04 23h14:532| <01.00.00> <Property> <Info> |.Station()| String|"' (Set|Get) The Station as  String.
    Private _Station As String
    '''    <Summary>
    '''     (Set|Get) The Station as  String.
    '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
    '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
    '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
    '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/04 23h18:375 </Published>
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
    <Browsable(True), CategoryAttribute("Info"), Description("(Set|Get) The Station as  String.")>
    Property Station() As String
        Get
            Return _Station
        End Get
        Set(ByVal Value As String)
            _Station = Value
        End Set
    End Property
#End Region '(Set|Get) The Station as  String.
#Region "[On] |2019/07/04 23h15:251| <01.00.01> <Property> <Info> |.UserName()|String|"' (Set|Get) The UserName as String.
    Private _UserName As String
    '''    <Summary>
    '''     (Set|Get) The UserName as String.
    '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
    '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
    '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
    '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/04 23h18:376 </Published>
    '''      <Rights>
    '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
    '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
    '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
    '''    taken out of the classroom.
    '''       </Rights>
    ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
    '''    </Summary>
    <Browsable(True), CategoryAttribute("Info"), Description("(Set|Get) The UserName as String.")>
    Public Property UserName() As String
        Get
            Return _UserName
        End Get
        Set(ByVal Value As String)
            _UserName = Value
        End Set
    End Property
#End Region '(Set|Get) The UserName as String.
#Region "[On] |2019/07/04 23h16:024| <01.00.02> <Property> <Info> |.Password()|String|"' (Set|Get) The Password as String.
    Private _Password As String
    '''    <Summary>
    '''     (Set|Get) The Password as String.
    '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
    '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
    '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
    '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/04 23h18:376 </Published>
    '''      <Rights>
    '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
    '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
    '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
    '''    taken out of the classroom.
    '''       </Rights>
    ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
    '''    </Summary>
    <Browsable(True), CategoryAttribute("Info"), Description("(Set|Get) The Password as String.")>
    Public Property Password() As String
        Get
            Return _Password
        End Get
        Set(ByVal Value As String)
            _Password = Value
        End Set
    End Property
#End Region '(Set|Get) The Password as String.
#End Region
#Region "<10> [Events]{4}"
    Private Sub RDV_OnConnected(sender As Object, e As EventArgs)
        SwitchButtonItem1.Value = True
    End Sub

    Private Sub RDV_OnDisconnected(sender As Object, e As AxMSTSCLib.IMsTscAxEvents_OnDisconnectedEvent)
        SwitchButtonItem1.Value = False
    End Sub

    Public Sub Btn_Connect_Click(sender As Object, e As EventArgs) Handles Btn_Connect.Click

        Try
            RDV.Server = Input_Station.Text
            RDV.UserName = Input_UserName.Text
            RDV.AdvancedSettings2.ClearTextPassword = Input_Password.Text
            '  Dim PassCard As IMsTscNonScriptable =
            ' DirectCast(RDV.GetOcx(), IMsTscNonScriptable)
            'PassCard.ClearTextPassword = Input_Password.Text
            RDV.Connect()
        Catch ex As Exception
            MessageBox.Show("Cannot Connect", "Cannot Connect to: " _
            + Input_Station.Text + " Reason:  " + ex.Message,
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        AdvPropertyGrid1.SelectedObject = RDV
    End Sub

    Private Sub Btn_Disconnect_Click(sender As Object, e As EventArgs) Handles Btn_Disconnect.Click

        Try
            If RDV.Connected.ToString = "1" Then
                RDV.Disconnect()
            End If
        Catch ex As Exception
            MessageBox.Show("Cannot Disconnect",
            "Cannot Disconnect from: " _
            + Input_Station.Text + " Reason: " + ex.Message,
            MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        AdvPropertyGrid1.SelectedObject = RDV

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        AdvPropertyGrid1.SelectedObject = RDV

    End Sub

    Private Sub RDV_OnConnected_1(sender As Object, e As EventArgs) Handles RDV.OnConnected
        SwitchButtonItem1.Value = True

    End Sub
#End Region
End Class
#End Region
