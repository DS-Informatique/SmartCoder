Imports System.ComponentModel
Imports System.Windows.Forms

Public Class U_DataBase
    Public Property ActiveDatabase As DataBase
    Dim Fi As Fichier = Nothing
    Public JobDone As Boolean = False
#Region "[On] |2019/05/27 17h00:682| <01.00.00> <Property> <Info> |.PasswordInput()| String|"' (Set|Get) The PasswordInput as  String.
    Private _PasswordInput As String
    '''    <Summary>
    '''     (Set|Get) The PasswordInput as  String.
    '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
    '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
    '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
    '''    <Published>MASTER From MASTER\Saadry | Time : 2019/05/27 17h00:691 </Published>
    '''      <Rights>
    '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
    '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
    '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
    '''    taken out of the classroom.
    '''       </Rights>
    ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
    '''    </Summary>

    <Browsable(True), CategoryAttribute("Info"), Description("(Set|Get) The PasswordInput as  String.")>
    Public Property PasswordInput() As String
        Get
            Return _PasswordInput
        End Get
        Set(ByVal Value As String)
            _PasswordInput = Value
        End Set
    End Property
#End Region '(Set|Get) The PasswordInput as  String.
#Region "[On] |2019/05/27 17h02:196| <01.00.01> <Property> <Info> |.Target()| String|"' (Set|Get) The Target as  String.
    Private _Target As String
    '''    <Summary>
    '''     (Set|Get) The Target as  String.
    '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
    '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
    '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
    '''    <Published>MASTER From MASTER\Saadry | Time : 2019/05/27 17h02:205 </Published>
    '''      <Rights>
    '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
    '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
    '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
    '''    taken out of the classroom.
    '''       </Rights>
    ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
    '''    </Summary>

    <Browsable(True), CategoryAttribute("Info"), Description("(Set|Get) The Target as  String.")>
    Public Property Target() As String
        Get
            Return _Target
        End Get
        Set(ByVal Value As String)
            If IO.File.Exists(Value) Then
                Txt_FilePath.Text = Value
                Fi = New Fichier(Value)
                Db_Size.Text = Fi.FileSize.Display
                ActiveDatabase = New DataBase(Fi, False)
                If BW_LoadDb.IsBusy Then
                Else
                    BW_LoadDb.RunWorkerAsync()
                End If
            End If
            _Target = Value
        End Set
    End Property
#End Region '(Set|Get) The Target as  String.
    Private Sub Btn_Define_Click(sender As Object, e As EventArgs) Handles Btn_Define.Click, Txt_FilePath.DoubleClick
        If OFD.ShowDialog = DialogResult.OK Then
            Fi = New Fichier(OFD.FileName)
            Btn_Load.Enabled = True
            AdvPropertyGrid1.SelectedObject = Fi
            Db_Size.Text = Fi.FileSize.Display
            Txt_FilePath.Text = Fi.Target
        End If
    End Sub

    Private Sub Btn_Load_Click(sender As Object, e As EventArgs) Handles Btn_Load.Click
        Fi.Password = Password.Text
        If BW_LoadDb.IsBusy Then
            Jarvis.Speak("Sorry the process is already running.")
        Else
            Pbar.Value = 0
            Pbar.Maximum = 100
            BW_LoadDb.RunWorkerAsync()
        End If

    End Sub

    Private Sub BW_LoadDb_DoWork(sender As Object, e As DoWorkEventArgs) Handles BW_LoadDb.DoWork
        BW_LoadDb.WorkerSupportsCancellation = True
        ActiveDatabase = New DataBase(Fi.Target, Fi.Password, True, True)

        Do Until ActiveDatabase.HasFinishImporting = True
            BW_LoadDb.ReportProgress(ActiveDatabase.IndexTableConvert / ActiveDatabase.TableCount)
            ActiveDatabase.GetTables()
        Loop

    End Sub

    Private Sub BW_LoadDb_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BW_LoadDb.RunWorkerCompleted

        AdvPropertyGrid1.SelectedObject = ActiveDatabase
        If ActiveDatabase.Line.Status = Status.Finished Or ActiveDatabase.Line.Status = Status.Online Then
            PictureBox2.Image = My.Resources.Resources.check_mark
            SuperGridControl1.PrimaryGrid.DataSource = ActiveDatabase.Tables
            JobDone = True
        Else
            MsgBox("Vérifier le mot de passe!")
            PictureBox2.Image = My.Resources.Resources.close
        End If
        Pbar.Value = 0
    End Sub

    Private Sub BW_LoadDb_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BW_LoadDb.ProgressChanged
        Pbar.Value = e.ProgressPercentage
    End Sub
End Class
