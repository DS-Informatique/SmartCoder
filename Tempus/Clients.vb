Imports System.Threading
Imports DevComponents.DotNetBar.SuperGrid

Public Class Clients
    Private Sub Cmd_Show_List_Executed(sender As Object, e As EventArgs) Handles Cmd_Show_List.Executed
        If Dock_Liste.Visible = True Then
            Dock_Liste.Visible = False
            Btn_Export.Visible = False
        ElseIf Dock_Liste.Visible = False Then
            Dock_Liste.Visible = True
            Btn_Export.Visible = True
        End If
    End Sub

    Private Sub Cmd_Show_Modifier_Executed(sender As Object, e As EventArgs) Handles Cmd_Show_Modifier.Executed
        If Dock_Modify.Visible = False Then
            Dock_Modify.Visible = True
            Btn_New.Enabled = True
            Btn_Save.Enabled = True
            Btn_Delete.Enabled = True
            ' L_Seperator.Visible = True
        ElseIf Dock_Modify.Visible = True Then
            Dock_Modify.Visible = False
            Btn_New.Enabled = False
            'Btn_Add.Visible = False
            Btn_Save.Enabled = False
            Btn_Delete.Enabled = False
            'L_Seperator.Visible = False
        End If
    End Sub
    Public Property List As New List(Of Chronos.Clients)
#Region "<1> [Property]"
#Region "|01.00| <Property> [Current|Chronos.Clients]"
    Private _Current As Chronos.Clients
    Public Property Current() As Chronos.Clients
        Get
            Return _Current
        End Get
        Set(ByVal value As Chronos.Clients)
            _Current = value
            If Not IsNothing(value) Then
                With value
                    Input_Actif.Value = .Active
                    Input_Address1.Text = .Address1
                    Input_Address2.Text = .Address2
                    Input_Portable.Text = .Cell
                    Input_IDE.Text = .CHE
                    Input_NFederal.Text = .IDE
                    Input_City.Text = .City
                    Input_Country.Text = .Country
                    Input_Email.Text = .Email
                    Input_Fax.Text = .Fax
                    Input_ForfaitValue.Value = .ForfaitValue
                    Input_Tel_Fixe.Text = .Landline
                    Input_NomClient.Text = .NomClient
                    Input_Other.Current = New SmartCoder.M_FileManager.Folder(.Other)
                    Input_Pcompta.Text = .Pcompta
                    Input_PostalCode.Text = .PostalCode
                    Input_RaisonSociale.Text = .RaisonSociale
                    Input_Ref.Text = .Ref
                    Input_Region.Text = .Region
                    Input_Répertoire.Current = New SmartCoder.M_FileManager.Folder(.Répertoire)
                    Input_SiteWeb.Text = .Website
                    Input_Zefix.Text = .Zefix
                End With
            End If
        End Set
    End Property
#End Region
#Region "|01.01| <Property> [Bm|BindingManagerBase]"
    Private _Bm As BindingManagerBase
    ''' <summary>
    ''' Gets and sets the BindingManager we use in this
    ''' sampe to traverse through the set data collection
    ''' </summary>
    Friend Property Bm() As BindingManagerBase
        Get
            Return (_Bm)
        End Get
        Set(ByVal value As BindingManagerBase)
            If _Bm IsNot Nothing Then
                RemoveHandler _Bm.PositionChanged, AddressOf BmPositionChanged
            End If
            _Bm = value
            If _Bm IsNot Nothing Then
                AddHandler _Bm.PositionChanged, AddressOf BmPositionChanged
            End If
        End Set
    End Property
#End Region
#End Region
    Private Sub Btn_New_Click(sender As Object, e As EventArgs) Handles Btn_New.Click
        Input_Ref.Text = ""
        Input_Actif.Value = True
        Input_RaisonSociale.Text = ""
        Input_NomClient.Text = ""
        Input_Address1.Text = ""
        Input_Address2.Text = ""
        Input_PostalCode.Text = ""
        Input_Region.Text = ""
        Input_City.Text = ""
        Input_Country.Text = ""
        Input_Tel_Fixe.Text = ""
        Input_Fax.Text = ""
        Input_Portable.Text = ""
        Input_Email.Text = ""
        Input_SiteWeb.Text = ""
        Input_Pcompta.Text = ""
        Input_Other.Current.Target = ""
        Input_Répertoire.Current.Target = ""
        Input_ForfaitValue.Value = 0
        Input_NFederal.Text = ""
        Input_IDE.Text = ""
        Input_Zefix.Text = ""
    End Sub

    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click
        Timer1.Stop()
        Btn_Add.Enabled = False
        Btn_Save.Enabled = True
        Btn_New.Enabled = True
        Try
            Current = New Chronos.Clients(Input_Ref.Text,
                                          Input_Actif.Value,
                                          Input_RaisonSociale.Text,
                                          Input_NomClient.Text,
                                          Input_Address1.Text,
                                          Input_Address2.Text,
                                          Input_PostalCode.Text,
                                          Input_Region.Text,
                                          Input_City.Text,
                                          Input_Country.Text,
                                          Input_Tel_Fixe.Text,
                                          Input_Fax.Text,
                                          Input_Portable.Text,
                                          Input_Email.Text,
                                          Input_SiteWeb.Text,
                                          Input_Pcompta.Text,
                                          Input_Other.Current.Target,
                                          Input_Répertoire.Current.Target,
                                          IIf(Input_ForfaitValue.Value > 0, True, False),
                                          Input_ForfaitValue.Value,
                                          Input_NFederal.Text,
                                          Input_IDE.Text,
                                          Input_Zefix.Text)

            Current.Add()
            SmartCoder.Jarvis.Speak("Client Saved")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        List = Current.List

        Current = List(0)
        InitializeGrid()
        RefreshData()
        AddNew = False
    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click

    End Sub

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click

    End Sub

    Private Sub ButtonItem1_Click(sender As Object, e As EventArgs)
        RefreshData()
    End Sub

    Private Sub Btn_Export_Click(sender As Object, e As EventArgs) Handles Btn_Export.Click
        Dim Msg As String = Nothing
        Try
            SmartCoder.ExcelDocument.Export_DataTable(SGC, "Clients.xlsx", Msg) 'My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\

        Catch ex As Exception

        End Try
        If Not IsNothing(Msg) Then
            If Msg.Length > 1 Then
                MsgBox(Msg)
            Else
                SmartCoder.Jarvis.Speak("Document Exported")
            End If
        Else
            SmartCoder.Jarvis.Speak("Document Exported")

        End If
    End Sub

#Region "|4| [Sub]{5}"
#Region "|04.00| <Sub> [RefreshData]"
    Public Sub RefreshData(Optional ByVal ONlYACTIF As Boolean = False)
        If IsNothing(List) Then
            List = New List(Of Chronos.Clients)
        End If
        Current = New Chronos.Clients
        Current.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.Db_Chronos_FilePath, My.Settings.Db_Chronos_Password))
        If ONlYACTIF = False Then
            List = Current.List
        Else
            For Each C As Chronos.Clients In Current.List
                If C.Active = True Then
                    List.Add(C)
                End If
            Next
        End If


        InitializeGrid()
        Dim dataSource As Object = Nothing
        Dim dataMember As String = Nothing
        Dim context As Object = Nothing
        dataSource = List
        context = dataSource
        ' Set the SuperGrid DataSource and DataMember, and
        ' set our BindingManager for later data traversal
        SGC.PrimaryGrid.DataSource = dataSource
        SGC.PrimaryGrid.DataMember = dataMember
        If dataSource Is Nothing Then Bm = Nothing Else Bm = SGC.BindingContext(context)
    End Sub
#End Region
    Public Property Import_OnlyActif As Boolean = False
#Region "|04.01| <Sub> [InitializeGrid]"
    ''' <summary>
    ''' Initializes our default sample environment
    ''' </summary>
    Private Sub InitializeGrid()
        Dim panel As GridPanel = SGC.PrimaryGrid

        ' None - is the default

        '    cboDataSource.SelectedIndex = 5

        panel.RowHeaderWidth = 50
        panel.RowHeaderIndexOffset = 1

        ' Hook onto a few of the SuperGrid events in order to
        ' have our UI reflect the current state of the grid

        ' AddHandler SGC.RowDeleted, AddressOf SuperGridControl1RowDeleted
        ' AddHandler SGC.RowRestored, AddressOf SuperGridControl1RowRestored
        ' AddHandler SGC.RowsPurged, AddressOf SuperGridControl1RowsPurged

        ' When new rows are added via the grid, let's
        ' see that they have something imaginative in them

        '        AddHandler SGC.RowSetDefaultValues, AddressOf SuperGridControl1RowSetDefaultValues

        ' NestedListScanTypes property is used to inform the grid how to handle
        ' scanning of IList field/property items. 
        '
        ' If NestedListScanTypes is set to NestedListScanTypes.Fields (the default) then only
        ' fields defined as IList elements will be scanned for by the grid and used to create
        ' nested sub-panels to the parent IList row (same logic holds for NestedListScanTypes.Properties).

        panel.NestedListScanTypes = (NestedListScanTypes.Properties Or NestedListScanTypes.Fields)

        LoadDataSet()
    End Sub
#End Region
#Region "|04.02| <Sub> [LoadDataSet]"
    Private Sub LoadDataSet()
        _Loading = True
        _LoadThread = New Thread(AddressOf LoadThread)
        _LoadThread.Start()
    End Sub
#End Region
#Region "|04.03| <Sub> [LoadThread]"
    Private Sub LoadThread()
        Try
            If IsNothing(Current) Then
                Current = New Chronos.Clients
            End If
            If IsNothing(Current.Table) Then
                Current.Table = New SmartCoder.M_FileManager.Table(Current.TableName, Current.FilePath, Current.Password, False)
            End If
            table = Current.Table.DataTable
            _DataSet = New DataSet("MyDataSet")
            _DataSet.Tables.Add(table.Clone)
            table.BeginLoadData()
            For Each Row As DataRow In table.Rows
                Row.AcceptChanges()
            Next
            table.EndLoadData()
        Finally
            _Loading = False
        End Try
    End Sub
#End Region
#Region "|04.04| <Sub> [UpdateVcr]"
    ''' <summary>
    ''' Updates our VCR states
    ''' </summary>
    Private Sub UpdateVcr()
        If _Bm.Position > _Bm.Count Then
            Current = List(_Bm.Count)
        ElseIf _Bm.Position < 0 Then
            Current = List(0)
        Else
            Current = List(_Bm.Position)
        End If
        If _Bm Is Nothing OrElse _Bm.Count <= 1 Then
            Vcr1.FirstButton.Enabled = False
            Vcr1.PreviousButton.Enabled = False
            Vcr1.NextButton.Enabled = False
            Vcr1.LastButton.Enabled = False
            Vcr1.Label.Text = IIf(_Bm Is Nothing OrElse _Bm.Count = 0, "No records", "Only Record")
        Else
            If _Bm.Position = 0 Then
                Vcr1.FirstButton.Enabled = InlineAssignHelper(Vcr1.PreviousButton.Enabled, False)

                Vcr1.LastButton.Enabled = InlineAssignHelper(Vcr1.NextButton.Enabled, (_Bm.Count > 1))

                Vcr1.Label.Text = "First of " & _Bm.Count & " records " & "|" & Current.Ref & "|" & Current.RaisonSociale & " " & Current.NomClient
            ElseIf _Bm.Position = _Bm.Count - 1 Then
                Vcr1.LastButton.Enabled = False
                Vcr1.NextButton.Enabled = False

                Vcr1.FirstButton.Enabled = InlineAssignHelper(Vcr1.PreviousButton.Enabled, (_Bm.Count > 1))

                Vcr1.Label.Text = "Last of " & _Bm.Count & " records" & "|" & Current.Ref & "|" & Current.RaisonSociale & " " & Current.NomClient
            Else
                Vcr1.FirstButton.Enabled = True
                Vcr1.PreviousButton.Enabled = True
                Vcr1.NextButton.Enabled = True
                Vcr1.LastButton.Enabled = True

                Vcr1.Label.Text = "Record " & (_Bm.Position + 1) & " of " & _Bm.Count & " " & "|" & Current.Ref & "|" & Current.RaisonSociale & " " & Current.NomClient
            End If
        End If
    End Sub
#End Region
#End Region
#Region "|5| [Function]{2}"
#Region "|05.00| <Function> [InlineAssignHelper]"
    Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, ByVal value As T) As T
        target = value
        Return value
    End Function
#End Region
#End Region
#Region "|6| [Runtime]{5}"
#Region "|06.00| <Runtime> [AddNew|Boolean]"
    Dim AddNew As Boolean = False
#End Region
#Region "|06.01| <Runtime> [IsReady|Boolean]"
    Dim IsReady As Boolean = False

#End Region
#Region "|06.02| <Runtime> [_DataSet|DataSet]"
    Dim _DataSet As DataSet
#End Region
#Region "|06.03| <Runtime> [_Loading|Boolean]"
    Dim _Loading As Boolean

#End Region
#Region "|05.04| <Runtime> [Log|String]"
    Public Log As String
#End Region
#End Region


#Region "|10| [Event]{13}"
#Region "|10.00| <Event> [ButtonX1_Click]"
    Private Sub Btn_Search_All_Click(sender As Object, e As EventArgs) Handles Btn_Search_All.Click
        Import_OnlyActif = False
        RefreshData(Import_OnlyActif)
        Current = New Chronos.Clients
        AddNew = True
        IsReady = False
        Timer1.Start()
    End Sub
#End Region
#Region "|10.01| <Event> [Btn_Add_Click]"

#End Region
#Region "|10.02| <Event> [Timer1_Tick]"
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        '  Btn_Add.Enabled = RefreshCollaborateur()
    End Sub
#End Region
#Region "|10.03| <Event> [ButtonX2_Click]"

#End Region
#Region "|10.04| <Event> [_LoadThread|Thread]"
    Private _LoadThread As Thread
#End Region
#Region "|10.05| <Event> [table|DataTable]"
    Dim table As New DataTable
#End Region
#Region "|10.06| <Event> [BmPositionChanged]"
    ''' <summary>
    ''' Updates out VCR control when the user
    ''' moves position in the data collection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BmPositionChanged(ByVal sender As Object, ByVal e As EventArgs)
        UpdateVcr()
    End Sub
#End Region
#Region "|10.07| <Event> [VcrFirstClick]"
    ''' <summary>
    ''' Handles VCR "first record" clicks
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub VcrFirstClick(ByVal sender As Object, ByVal e As EventArgs) Handles Vcr1.FirstClick
        If _Bm IsNot Nothing Then
            _Bm.Position = 0
        End If

        UpdateVcr()
    End Sub
#End Region
#Region "|10.08| <Event> [VcrPreviousClick]"
    ''' <summary>
    ''' Handles user "previous record" clicks
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub VcrPreviousClick(ByVal sender As Object, ByVal e As EventArgs) Handles Vcr1.PreviousClick
        If _Bm IsNot Nothing Then
            _Bm.Position -= 1
        End If

        UpdateVcr()
    End Sub
#End Region
#Region "|10.09| <Event> [VcrNextClick]"
    ''' <summary>
    ''' Handles user "Next record" clicks
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub VcrNextClick(ByVal sender As Object, ByVal e As EventArgs) Handles Vcr1.NextClick
        If _Bm IsNot Nothing Then
            _Bm.Position += 1
        End If

        UpdateVcr()
    End Sub
#End Region
#Region "|10.10| <Event> [VcrLastClick]"
    ''' <summary>
    ''' Handles user "Last record" clicks
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub VcrLastClick(ByVal sender As Object, ByVal e As EventArgs) Handles Vcr1.LastClick
        If _Bm IsNot Nothing Then
            _Bm.Position = _Bm.Count
        End If

        UpdateVcr()
    End Sub

    Private Sub Clients_Load(sender As Object, e As EventArgs) Handles Me.Load
        CheckForIllegalCrossThreadCalls = False
        RefreshData(True)
    End Sub

    Private Sub BW_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW.DoWork

    End Sub

    Private Sub ButtonItem2_Click(sender As Object, e As EventArgs) Handles ButtonItem2.Click
        RefreshData(True)

    End Sub
#End Region
#Region "|10.11| <Event> [Btn_Verify_Click]"

#End Region
#Region "|10.12| <Event> [Btn_SendToExcel_Click]"

#End Region
#End Region
End Class
