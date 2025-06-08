Imports System.Threading
Imports DevComponents.DotNetBar.Controls
Imports DevComponents.DotNetBar.SuperGrid
Imports SmartCoder.M_Microsoft

Public Class PrestationViewer

#Region "[Code]"

#Region "|1| [Property]"
#Region "|01.00| <Property> []"

#End Region
#End Region
#Region "|4| [Sub]"
#Region "|04.00| <Sub> []"

#End Region

#End Region
#Region "|5| [Function]"
#Region "|05.00| <Function> []"

#End Region

#End Region
#Region "|6| [Runtime]"
#Region "|06.00| <Runtime> []"

#End Region
#End Region
#Region "|7| [Loader]"
#Region "|07.00| <Loader> [Load]"

#End Region
#End Region
#Region "|10| [Event]"
#Region "|10.00| <Event> []"

#End Region
#End Region
#End Region
    Private Sub PrestationViewer_Load(sender As Object, e As EventArgs) Handles Me.Load
        CheckForIllegalCrossThreadCalls = False
        Input_DateStart.Value = New DateTime(Now.Year, Now.Month, 1)
        Input_DateEnd.Value = New DateTime(Now.Year, Now.Month, System.DateTime.DaysInMonth(Now.Year, Now.Month))
        RefreshData()
    End Sub

    Dim AddNew As Boolean = False
    Dim IsReady As Boolean = False
#Region "<Property>"
    Private _Current As TimeSheet
    Public Property Current() As TimeSheet
        Get
            Return _Current
        End Get
        Set(ByVal value As TimeSheet)
            _Current = value
            If Not IsNothing(value) Then
                Input_Facturable.Value = value.Facturable
                Input_Quantity.Value = value.Quantity
                Input_Total.Value = value.Total
                Input_TotalHTVA.Value = value.TotalHTVA
                Input_UnitPrice.Value = value.UnitPrice
                Input_Mandat.Text = value.Mandat
                Input_Collaborateur.Text = value.Collaborateur
                Input_Description.Text = value.Description

            End If
        End Set
    End Property


#End Region
    Public Sub PrepareInterface(Optional ByVal Client As Clients = Nothing,
                                Optional ByVal D0 As DateTime = Nothing,
                                Optional ByVal D1 As DateTime = Nothing)

        If IsNothing(Client) Then
            If IsNothing(Current_Client) Then
                Current_Client = New Clients
                Client = Current_Client.List(0)
            Else
                Client = Current_Client
            End If
        ElseIf Not IsNothing(Client) Then
            Current_Client = Client
        End If
        Input_Mandat.Text = Client.Ref
        Input_DateStart.Value = D0
        Input_DateEnd.Value = D1

        'Current_Client = Client
        'Current = Client
        '  Input_Mandat.Text = Current_Client.ToString


        'Mandat.Items.Clear()
        ' Input_Mandat.DataSource = Current_Client.List
        List_TimeSheet = New List(Of TimeSheet)

        List_TimeSheet = Current.List(D0, D1, Current_Client.Ref)


        InitializeGrid()
        Dim dataSource As Object = Nothing
        Dim dataMember As String = Nothing
        Dim context As Object = Nothing

        dataSource = List_TimeSheet
        context = dataSource
        ' Set the SuperGrid DataSource and DataMember, and
        ' set our BindingManager for later data traversal

        SGC.PrimaryGrid.DataSource = dataSource
        SGC.PrimaryGrid.DataMember = dataMember
        If dataSource Is Nothing Then Bm = Nothing Else Bm = SGC.BindingContext(context)
        Threading.Thread.Sleep(100)
        Btn_CalculateTotal.PerformClick()
    End Sub
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        'Btn_Verify.PerformClick()

        Current = New TimeSheet
        AddNew = True
        IsReady = False
        Btn_Add.Enabled = True
        ButtonX1.Enabled = False
        ButtonX2.Enabled = False
        ButtonX3.Enabled = True
        Input_Facturable.Value = True
    End Sub
    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles ButtonX3.Click
        Timer1.Stop()

        If AddNew = True Then
            AddNew = False
            Btn_Add.Enabled = False
            ButtonX1.Enabled = True
            ButtonX2.Enabled = True
            Current = New TimeSheet
        Else
            If Not IsNothing(Current) Then
                Try
                    Current.Delete()
                    SmartCoder.Jarvis.Speak("Element Deleted")
                Catch ex As Exception
                    SmartCoder.Jarvis.Speak("Problem while deleting this element.")
                End Try
            End If
            AddNew = False
        End If
    End Sub
    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click
        ' Timer1.Stop()
        Btn_Add.Enabled = False
        ButtonX1.Enabled = True
        ButtonX2.Enabled = True
        Try
            Current = New TimeSheet(List_TimeSheet.Count + 1, True, Input_TimeIn.Value, Input_Collaborateur.Text, Input_Mandat.Text, Input_Quantity.Value, Input_UnitPrice.Value, Input_Description.Text, Input_Facturable.Value, Input_TotalHTVA.Value, Input_Total.Value)

            Current.Add()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        List_TimeSheet = Current_TimeSheet.List

        Current = List_TimeSheet(0)
        InitializeGrid()
        RefreshData()
        AddNew = False

    End Sub
    Public Sub RefreshData()

        '   If BW.IsBusy Then
        '   Else
        '   BW.RunWorkerAsync()
        '   End If
#Region "Work"
        If IsNothing(List_TimeSheet) Then
            List_TimeSheet = New List(Of TimeSheet)
            Current_TimeSheet = New TimeSheet
            Current_TimeSheet.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password))
            List_TimeSheet = Current_TimeSheet.List
        Else
            If List_TimeSheet.Count - 1 < 1 Then

                If IsNothing(Current_TimeSheet) Then
                    Current_TimeSheet = New TimeSheet
                End If
                Current_TimeSheet.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password))
                List_TimeSheet = Current_TimeSheet.List
            End If
        End If

        If IsNothing(List_Collaborateur) Then
            List_Collaborateur = New List(Of Collaborateur)
            If IsNothing(Current_Collaborateur) Then
                Current_Collaborateur = New Collaborateur
            End If
            Current_Collaborateur.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password))
            List_Collaborateur = Current_Collaborateur.List
        Else
            If List_Collaborateur.Count - 1 < 1 Then

                If IsNothing(Current_Collaborateur) Then
                    Current_Collaborateur = New Collaborateur
                End If
                Current_Collaborateur.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password))
                List_Collaborateur = Current_Collaborateur.List
            End If
        End If
        Dim LtC As New List(Of Collaborateur)
        For Each Col As Collaborateur In List_Collaborateur
            If Col.Active = True Then
                LtC.Add(Col)
            End If
        Next
        Input_Collaborateur.DataSource = LtC
        If IsNothing(List_Sociétés) Then
            List_Sociétés = New List(Of Sociétés)
        End If
        If List_Sociétés.Count - 1 < 1 Then
            If IsNothing(Current_Société) Then
                Current_Société = New Sociétés
            End If
            List_Sociétés = Current_Société.List
        End If
        Input_Société.DataSource = List_Sociétés
        If IsNothing(List_Clients) Then
            List_Clients = New List(Of Clients)
            If IsNothing(Current_Client) Then
                Current_Client = New Clients
            End If
            Current_Client.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password))
            List_Clients = Current_Client.List
        Else
            If List_Clients.Count - 1 < 1 Then

                If IsNothing(Current_Client) Then
                    Current_Client = New Clients
                End If
                Current_Client.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password))
                List_Clients = Current_Client.List
            End If
        End If
        Dim LtCl As New List(Of Clients)
        For Each Cl As Clients In List_Clients
            If Cl.Active = True Then
                LtCl.Add(Cl)
            End If
        Next
        Input_Mandat.DataSource = LtCl
        CB_Client.DataSource = LtCl


        'Filling the blanks
        If IsNothing(List_Services) Then
            List_Services = New List(Of Services)
        End If
        If List_Services.Count - 1 < 1 Then
            If IsNothing(Current_Services) Then
                Current_Services = New Services
                Current_Services.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password))
            End If
            List_Services = Current_Services.List
        End If

        CB_Service.DataSource = List_Services

#End Region


        InitializeGrid()
        Dim dataSource As Object = Nothing
        Dim dataMember As String = Nothing
        Dim context As Object = Nothing

        dataSource = List_TimeSheet
        context = dataSource
        ' Set the SuperGrid DataSource and DataMember, and
        ' set our BindingManager for later data traversal

        SGC.PrimaryGrid.DataSource = dataSource
        SGC.PrimaryGrid.DataMember = dataMember
        If dataSource Is Nothing Then Bm = Nothing Else Bm = SGC.BindingContext(context)

    End Sub
    Private Sub Btn_CalculateTotal_Click(sender As Object, e As EventArgs) Handles Btn_CalculateTotal.Click
        Dim Total As Double = 0
        Dim TQ As Double = 0
        Dim TotalFrai As Double = 0
        Dim TQF As Double = 0
        '   For Each Row As DataRow In SGC.PrimaryGrid.DataSource

        'Next
        For Each Row As DevComponents.DotNetBar.SuperGrid.GridRow In SGC.PrimaryGrid.Rows
            If Row.Item(1).Value = True Then
                If Row.Item(3).Value = "@FRAIS" Then
                    TotalFrai += Row.Item(9).Value
                    TQF += Row.Item(5).Value
                Else
                    Total += Row.Item(9).Value
                    TQ += Row.Item(5).Value
                End If
            End If

        Next
        If SW_Limit.Value = True Then
            '  If Total > Forfais_Value.Value Then
            Total = Forfais_Value.Value
            '  End If
        End If

        Input_Total_Prestation.Text = Math.Round(Total, 2)
        Input_Total_Frais.Text = Math.Round(TotalFrai, 2)
        Input_Quantity_Frais.Text = Math.Round(TQF, 2)
        Input_Quantity_Prestation.Text = Math.Round(TQ, 2)

        Input_Total_HTVA.Text = Math.Round((Total + TotalFrai), 2)


        Input_Total_TVA.Text = Math.Round((Total + TotalFrai) * My.Settings.TVA, 2)
        Input_Total.Value = Math.Round((1 + My.Settings.TVA) * ((Total + TotalFrai)), 2)
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ButtonX1.Enabled = False
        ButtonX2.Enabled = False
        Btn_Add.Enabled = RefreshTimeSheet()


    End Sub
    Private _Active_Service As Services
    Public Property Active_Service() As Services
        Get
            Return _Active_Service
        End Get
        Set(ByVal value As Services)
            _Active_Service = value
            If Not IsNothing(value) Then
                If IsNothing(List_Prestation_Category) Then
                    List_Prestation_Category = New List(Of Prestation_Category)
                End If

                If IsNothing(Current_Prestation_Category) Then
                    Current_Prestation_Category = New Prestation_Category
                End If

                Current_Prestation_Category.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password))
                CB_Type.DataSource = List_Prestation_Category

            End If
        End Set
    End Property

    Public Function RefreshTimeSheet() As Boolean
        Dim Result As Boolean = False
        '    Dim LCollaborateur As New List(Of TimeSheet)
        '   LCollaborateur = Current.List
        Dim Msg As String = ""
        If Input_Collaborateur.Text.Length < 1 Then
            Msg += "Aucun Collaborateur défini." & vbNewLine
        End If
        If Input_Mandat.Text.Length < 1 Then
            Msg += "Aucun mandat n'a été défini." & vbNewLine
        End If
        If Input_TimeIn.Text.Length < 1 Then
            Msg += "Aucune date définie." & vbNewLine
        End If
        If Msg.Length > 0 Then
            Result = False
        Else
            Result = True
        End If

        Return Result

    End Function
    Private Sub ButtonX2_Click(sender As Object, e As EventArgs)

    End Sub
#Region "Parameters of SGC and VCR"
    Dim _DataSet As DataSet
    Dim _Loading As Boolean
    Private _LoadThread As Thread
    Dim table As New DataTable

#Region "InitializeGrid"

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

        AddHandler SGC.RowDeleted, AddressOf SuperGridControl1RowDeleted
        AddHandler SGC.RowRestored, AddressOf SuperGridControl1RowRestored
        AddHandler SGC.RowsPurged, AddressOf SuperGridControl1RowsPurged

        ' When new rows are added via the grid, let's
        ' see that they have something imaginative in them

        AddHandler SGC.RowSetDefaultValues, AddressOf SuperGridControl1RowSetDefaultValues

        ' NestedListScanTypes property is used to inform the grid how to handle
        ' scanning of IList field/property items. 
        '
        ' If NestedListScanTypes is set to NestedListScanTypes.Fields (the default) then only
        ' fields defined as IList elements will be scanned for by the grid and used to create
        ' nested sub-panels to the parent IList row (same logic holds for NestedListScanTypes.Properties).

        panel.NestedListScanTypes = (NestedListScanTypes.Properties Or NestedListScanTypes.Fields)

        LoadDataSet()
    End Sub

#Region "LoadDataSet"

    Private Sub LoadDataSet()
        _Loading = True
        If IsNothing(Current) Then
            Current = New TimeSheet()
            Current.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.DataBase, My.Settings.DataBasePassword))
            Current.Table = New SmartCoder.M_FileManager.Table(Current.TableName, Current.FilePath, Current.Password, True)
        End If
        _LoadThread = New Thread(AddressOf LoadThread)
        _LoadThread.Start()
    End Sub

#Region "LoadThread"

    Private Sub LoadThread()
        Try




            Try
                table = Current.Table.DataTable
                _DataSet = New DataSet("MyDataSet")
                _DataSet.Tables.Add(table.Clone)

                table.BeginLoadData()
                For Each Row As DataRow In table.Rows
                    Row.AcceptChanges()
                Next


                table.EndLoadData()
            Catch ex As Exception

            End Try




        Finally
            _Loading = False
        End Try
    End Sub

#End Region

#End Region
#Region "SuperGridControl1RowsPurged"

    ''' <summary>
    ''' This event is sent when deleted rows have been purged.
    ''' We will use it to disable the "purge" button after a
    ''' purge has been performed by the user.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SuperGridControl1RowsPurged(ByVal sender As Object, ByVal e As GridRowEventArgs)
        '  btnPurge.Enabled = False
    End Sub

#End Region

#Region "SuperGridControl1RowRestored"

    ''' <summary>
    ''' This event is sent when user deleted rows are
    ''' restored or 'undeleted'.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SuperGridControl1RowRestored(ByVal sender As Object, ByVal e As GridRowRestoredEventArgs)
        '   btnPurge.Enabled = (SGC.PrimaryGrid.DeletedRowCount > 0)
    End Sub

#End Region

#Region "SuperGridControl1RowDeleted"

    ''' <summary>
    ''' This event is sent after
    ''' rows have been deleted by the user.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SuperGridControl1RowDeleted(ByVal sender As Object, ByVal e As GridRowDeletedEventArgs)
        ' btnPurge.Enabled = (SGC.PrimaryGrid.DeletedRowCount > 0)
    End Sub

#End Region

#Region "SuperGridControl1RowSetDefaultValues"

    ''' <summary>
    ''' This event is sent when a new row is added.  It gives
    ''' our application the opportunity to establish a new
    ''' set of default values for the added row.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SuperGridControl1RowSetDefaultValues(ByVal sender As Object, ByVal e As GridRowSetDefaultValuesEventArgs)
        If e.GridRow.Cells.Count = 0 Then
            e.GridRow.Cells.Add(New GridCell("John*"))
            e.GridRow.Cells.Add(New GridCell("Doe"))
            e.GridRow.Cells.Add(New GridCell(20))
            e.GridRow.Cells.Add(New GridCell(20001))
            e.GridRow.Cells.Add(New GridCell(DateTime.Now))
        Else
            e.GridRow.Cells(0).Value = "John*"
            e.GridRow.Cells(1).Value = "Doe"
            e.GridRow.Cells(2).Value = 20
            e.GridRow.Cells(3).Value = 20001
            e.GridRow.Cells(4).Value = DateTime.Now
        End If
    End Sub

#End Region
#End Region

#Region "Internal properties"
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

#Region "Vcr Control support"

#Region "BmPositionChanged"

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

#Region "VcrFirstClick"

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

#Region "VcrPreviousClick"

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

#Region "VcrNextClick"

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

#Region "VcrLastClick"

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

#End Region

#Region "UpdateVcr"

    ''' <summary>
    ''' Updates our VCR states
    ''' </summary>
    Private Sub UpdateVcr()
        Try
            If Not IsNothing(_Bm) Then

                If _Bm.Position > _Bm.Count Then
                    Current = List_TimeSheet(_Bm.Count)
                ElseIf _Bm.Position < 0 Then
                    Current = List_TimeSheet(0)
                ElseIf IsNothing(List_TimeSheet(_Bm.Position)) Then
                    If _Bm.Position > List_TimeSheet.Count Then
                        _Bm.Position = List_TimeSheet.Count - 1
                    ElseIf _Bm.Position < 0 Then
                        _Bm.Position = 0
                    End If
                    Current = List_TimeSheet(_Bm.Position)
                Else
                    Current = List_TimeSheet(_Bm.Position)

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

                        Vcr1.Label.Text = "First of " & _Bm.Count & " records " & "|" & Current.Mandat & "|" & Current.Collaborateur & "|" & Current.Total
                    ElseIf _Bm.Position = _Bm.Count - 1 Then
                        Vcr1.LastButton.Enabled = False
                        Vcr1.NextButton.Enabled = False

                        Vcr1.FirstButton.Enabled = InlineAssignHelper(Vcr1.PreviousButton.Enabled, (_Bm.Count > 1))

                        Vcr1.Label.Text = "Last of " & _Bm.Count & " records" & "|" & Current.Mandat & "|" & Current.Collaborateur & "|" & Current.Total
                    Else
                        Vcr1.FirstButton.Enabled = True
                        Vcr1.PreviousButton.Enabled = True
                        Vcr1.NextButton.Enabled = True
                        Vcr1.LastButton.Enabled = True

                        Vcr1.Label.Text = "Record " & (_Bm.Position + 1) & " of " & _Bm.Count & " " & "|" & Current.Mandat & "|" & Current.Collaborateur & "|" & Current.Total
                    End If
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

#End Region
    Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, ByVal value As T) As T
        target = value
        Return value
    End Function

    Private Sub CB_Type_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim Lt As New List(Of Prestations)
        If IsNothing(List_Prestations) Then
            List_Prestations = New List(Of Prestations)
        End If
        If List_Prestations.Count - 1 < 1 Then
            If IsNothing(Current_Prestations) Then
                Current_Prestations = New Prestations
            End If

            Current_Prestations.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password))
            List_Prestations = Current_Prestations.List
        End If
        If Not IsNothing(Active_Service) Then

            For Each P As Prestations In List_Prestations
                If P.Service = Active_Service.Service Then
                    Lt.Add(P)
                End If
            Next
        Else
            Lt = List_Prestations
        End If
        CB_Prestation.DataSource = Lt

    End Sub

    Private Sub ButtonX4_Click(sender As Object, e As EventArgs)
        RefreshData()
    End Sub

    Private Sub BW_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW.DoWork
        If IsNothing(List_TimeSheet) Then
            List_TimeSheet = New List(Of TimeSheet)
            Current_TimeSheet = New TimeSheet

            Current_TimeSheet.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password))
            List_TimeSheet = Current_TimeSheet.List
        Else
            If List_TimeSheet.Count - 1 < 1 Then

                If IsNothing(Current_TimeSheet) Then
                    Current_TimeSheet = New TimeSheet
                End If
                Current_TimeSheet.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password))
                List_TimeSheet = Current_TimeSheet.List
            End If
        End If

        If IsNothing(List_Collaborateur) Then
            List_Collaborateur = New List(Of Collaborateur)
            If IsNothing(Current_Collaborateur) Then
                Current_Collaborateur = New Collaborateur
            End If

            Current_Collaborateur.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password))
            List_Collaborateur = Current_Collaborateur.List
        Else
            If List_Collaborateur.Count - 1 < 1 Then
                If IsNothing(Current_Collaborateur) Then
                    Current_Collaborateur = New Collaborateur
                End If
                Current_Collaborateur.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password))
                List_Collaborateur = Current_Collaborateur.List
            End If
        End If
        Dim LtC As New List(Of Collaborateur)
        For Each Col As Collaborateur In List_Collaborateur
            If Col.Active = True Then
                LtC.Add(Col)
            End If
        Next
        Input_Collaborateur.DataSource = LtC


        If IsNothing(List_Clients) Then
            List_Clients = New List(Of Clients)
            If IsNothing(Current_Client) Then
                Current_Client = New Clients
            End If
            Current_Client.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password))
            List_Clients = Current_Client.List
        Else
            If List_Clients.Count - 1 < 1 Then

                If IsNothing(Current_Client) Then
                    Current_Client = New Clients
                End If
                Current_Client.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password))
                List_Clients = Current_Client.List
            End If
        End If
        Input_Mandat.DataSource = List_Clients
        Dim LtCl As New List(Of Clients)
        For Each Cl As Clients In List_Clients
            If Cl.Active = True Then
                LtCl.Add(Cl)
            End If
        Next
        Input_Mandat.DataSource = LtCl

        If IsNothing(List_Services) Then
            List_Services = New List(Of Services)
            If IsNothing(Current_Services) Then
                Current_Services = New Services
            End If

            Current_Services.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password))
            List_Services = Current_Services.List
        Else
            If List_Clients.Count - 1 < 1 Then

                If IsNothing(Current_Services) Then
                    Current_Services = New Services
                End If
                Current_Services.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password))
                List_Services = Current_Services.List
            End If
        End If
    End Sub

    Private Sub Input_DateStart_Leave(sender As Object, e As EventArgs)
        Input_DateEnd.Value = New Date(Year(Input_DateStart.Value), Month(Input_DateStart.Value), DateTime.DaysInMonth(Input_DateStart.Value.Year, Input_DateStart.Value.Month))
    End Sub

    Private Sub Invoice_Filter_Click(sender As Object, e As EventArgs) Handles Invoice_Filter.Click
        PrepareInterface(Input_Mandat.SelectedItem, Input_DateStart.Value, Input_DateEnd.Value)
    End Sub

    Public Function Create_Invoice() As Factures
        Dim Result As New Factures
        ' If Not IsNothing(Client) Then

#Region "<Creation of App>"
        Dim WordApplication As Microsoft.Office.Interop.Word.Application
        Dim WordDocument As Microsoft.Office.Interop.Word.Document
        Dim Paragraph_Address As Microsoft.Office.Interop.Word.Paragraph
#End Region
#Region "<Formatting>"
        'Initialize Instruments
        WordApplication = CreateObject("Word.Application")
        WordApplication.Visible = True
        WordDocument = WordApplication.Documents.Add
        'Formating page
        With WordDocument.PageSetup
            .LeftMargin = Math.Round((1.8) * 37.795275591, 2)
            .RightMargin = Math.Round(1.5 * 37.795275591, 2)
            .TopMargin = Math.Round(1.9 * 37.795275591, 2)
            .BottomMargin = Math.Round(3.17 * 37.795275591, 2)
        End With
#End Region
        Dim F As New System.Drawing.Font("Arial", 12)
#Region "Null row"

        Dim Pn1 As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
        With Pn1
            .Range.Font.Name = F.Name
            .Range.Font.Size = F.Size
            .Range.Font.Bold = True
            .Range.Text = ""
            .IndentCharWidth(24)
            .Range.InsertParagraphAfter()
            .Format.SpaceAfter = 0
        End With
        Dim Pn2 As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
        With Pn2
            .Range.Font.Name = F.Name
            .Range.Font.Size = F.Size
            .Range.Font.Bold = True
            .Range.Text = ""
            .IndentCharWidth(0)
            .Range.InsertParagraphAfter()
            .Format.SpaceAfter = 0
        End With
        Dim Pn3 As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
        With Pn3
            .Range.Font.Name = F.Name
            .Range.Font.Size = F.Size
            .Range.Font.Bold = True
            .Range.Text = ""
            .IndentCharWidth(0)
            .Range.InsertParagraphAfter()
            .Format.SpaceAfter = 0
        End With
        Dim Pn4 As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
        With Pn4
            .Range.Font.Name = F.Name
            .Range.Font.Size = F.Size
            .Range.Font.Bold = True
            .Range.Text = ""
            .IndentCharWidth(0)
            .Range.InsertParagraphAfter()
            .Format.SpaceAfter = 0
        End With
#End Region
        Dim P As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
        With P
            .Range.Font.Name = F.Name
            .Range.Font.Size = F.Size
            .Range.Font.Bold = True
            .Range.Text = Input_Adresse.Text
            .IndentCharWidth(0)
            .Range.InsertParagraphAfter()
            .Format.SpaceAfter = 0
        End With
#Region "Null Row"

        Dim Pn6 As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
        With Pn6
            .Range.Font.Name = F.Name
            .Range.Font.Size = F.Size
            .Range.Font.Bold = False
            .Range.Text = ""
            .IndentCharWidth(-24)
            .Range.InsertParagraphAfter()
            .Format.SpaceAfter = 0
        End With
#End Region


        Dim P1 As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
        With P1
            .Range.Font.Name = F.Name
            .Range.Font.Size = F.Size
            .Range.Font.Bold = False
            .Range.Text = "Contribuable Tva : N° " & Current_Société.NuméroTVA & vbTab & "     Genève le " & Now.ToLongDateString
            .IndentCharWidth(0)
            .Range.InsertParagraphAfter()
            .Format.SpaceAfter = 0
        End With

        If Me.Input_Libellé.Text.Length > 1 Then
#Region "Null Row"
            Dim Pn7 As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
            With Pn7
                .Range.Font.Name = F.Name
                .Range.Font.Size = F.Size
                .Range.Font.Bold = False
                .Range.Text = ""
                .IndentCharWidth(0)
                .Range.InsertParagraphAfter()
                .Format.SpaceAfter = 0
            End With

#End Region
            Dim P2 As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
            With P2
                .Range.Font.Name = F.Name
                .Range.Font.Size = F.Size
                .Range.Font.Bold = False
                .Range.Text = Me.Input_Libellé.Text
                .IndentCharWidth(0)
                .Range.InsertParagraphAfter()
                .Format.SpaceAfter = 0
            End With
        End If

#Region "Null Row"
        Dim Pn8 As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
        With Pn8
            .Range.Font.Name = F.Name
            .Range.Font.Size = F.Size
            .Range.Font.Bold = False
            .Range.Text = ""
            .IndentCharWidth(0)
            .Range.InsertParagraphAfter()
            .Format.SpaceAfter = 0
        End With
#End Region

        Dim P3 As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
        With P3
            .Range.Font.Name = F.Name
            .Range.Font.Size = F.Size
            .Range.Font.Bold = False
            .Range.Text = "Facture N° : " & Mid(Now.Year, 3) & "-" & Input_N.Text & "/" & Current_Client.Ref & "/ du " & Input_DateStart.Value.ToShortDateString & " au " & Input_DateEnd.Value.ToShortDateString
            .IndentCharWidth(0)
            .Range.InsertParagraphAfter()
            .Format.SpaceAfter = 0
        End With

#Region "Null Row"
        Dim Pn8x As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
        With Pn8x
            .Range.Font.Name = F.Name
            .Range.Font.Size = F.Size
            .Range.Font.Bold = False
            .Range.Text = ""
            .IndentCharWidth(0)
            .Range.InsertParagraphAfter()
            .Format.SpaceAfter = 0
        End With

#End Region
        Dim P4 As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
        With P4
            .Range.Font.Name = F.Name
            .Range.Font.Size = F.Size
            .Range.Font.Bold = False
            .Range.Text = "Concerne : " & Me.Input_Concerne.Text
            .IndentCharWidth(0)
            .Range.InsertParagraphAfter()
            .Format.SpaceAfter = 0
        End With
#Region "Null Row"
        Dim Pn9 As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
        With Pn9
            .Range.Font.Name = F.Name
            .Range.Font.Size = F.Size
            .Range.Font.Bold = False
            .Range.Text = ""
            .IndentCharWidth(0)
            .Range.InsertParagraphAfter()
            .Format.SpaceAfter = 0
        End With
        Dim Pn10 As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
        With Pn10
            .Range.Font.Name = F.Name
            .Range.Font.Size = F.Size
            .Range.Font.Bold = False
            .Range.Text = ""
            .IndentCharWidth(0)
            .Range.InsertParagraphAfter()
            .Format.SpaceAfter = 0
        End With
        Dim Pn11 As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
        With Pn11
            .Range.Font.Name = F.Name
            .Range.Font.Size = F.Size
            .Range.Font.Bold = False
            .Range.Text = ""
            .IndentCharWidth(0)
            .Range.InsertParagraphAfter()
            .Format.SpaceAfter = 0
        End With
#End Region
        Dim PTable As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
        Dim WordTable = WordDocument.Tables.Add(Range:=PTable.Range, NumRows:=9, NumColumns:=2)
        WordTable.Range.InsertParagraphAfter()
        With WordTable
            .Cell(1, 1).Range.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle
            .Cell(1, 1).Range.Text = "Total des prestations"
            .Cell(1, 1).Range.Font.Name = F.Name
            .Cell(1, 1).Range.Font.Size = F.Size

            .Cell(1, 2).Range.Text = "(" & String.Format("{0:n2}", Val(Me.Input_Quantity_Prestation.Text)) & ")" & vbTab & "   " & String.Format("{0:n2}", Input_Total_Prestation.Value)
            .Cell(1, 2).Range.Font.Name = F.Name
            .Cell(1, 2).Range.Font.Size = F.Size
            .Cell(1, 2).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight

            .Cell(2, 1).Range.Text = "Total des frais"
            .Cell(2, 1).Range.Font.Name = F.Name
            .Cell(2, 1).Range.Font.Size = F.Size

            .Cell(2, 2).Range.Text = String.Format("{0:n2}", Input_Total_Frais.Value) & vbNewLine & "__________"
            .Cell(2, 2).Range.Font.Name = F.Name
            .Cell(2, 2).Range.Font.Size = F.Size
            .Cell(2, 2).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight
            .Cell(2, 2).Range.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle

            .Cell(3, 2).Range.Text = String.Format("{0:n2}", Double.Parse(Input_Total_HTVA.Text))
            .Cell(3, 2).Range.Font.Name = F.Name
            .Cell(3, 2).Range.Font.Size = F.Size
            .Cell(3, 2).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight


            .Cell(4, 1).Range.Text = "TVA " & My.Settings.TVA * 100 & " %"
            .Cell(4, 1).Range.Font.Name = F.Name
            .Cell(4, 1).Range.Font.Size = F.Size

            .Cell(4, 2).Range.Text = String.Format("{0:n2}", Double.Parse(Input_Total_TVA.Text))
            .Cell(4, 2).Range.Font.Name = F.Name
            .Cell(4, 2).Range.Font.Size = F.Size
            .Cell(4, 2).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight
            .Cell(4, 2).Range.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle

            .Cell(5, 2).Range.Text = "__________"
            .Cell(5, 2).Range.Font.Name = F.Name
            .Cell(5, 2).Range.Font.Size = F.Size
            .Cell(5, 2).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight
            .Cell(5, 2).Range.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle

            .Cell(6, 1).Range.Text = "Total payable au "
            .Cell(6, 1).Range.Font.Name = F.Name
            .Cell(6, 1).Range.Font.Size = F.Size

            .Cell(6, 2).Range.Text = String.Format("{0:n2}", Double.Parse(Input_Total.Text))
            .Cell(6, 2).Range.Font.Name = F.Name
            .Cell(6, 2).Range.Font.Size = F.Size
            .Cell(6, 2).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight
            .Cell(6, 2).Range.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble
            P.Range.InsertParagraphAfter()
        End With
#Region "Null Row"
        Dim Pn12 As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
        With Pn12
            .Range.Font.Name = F.Name
            .Range.Font.Size = F.Size
            .Range.Font.Bold = False
            .Range.Text = ""
            .IndentCharWidth(0)
            .Range.InsertParagraphAfter()
            .Format.SpaceAfter = 0
        End With
        Dim Pn13 As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
        With Pn13
            .Range.Font.Name = F.Name
            .Range.Font.Size = F.Size
            .Range.Font.Bold = False
            .Range.Text = ""
            .IndentCharWidth(0)
            .Range.InsertParagraphAfter()
            .Format.SpaceAfter = 0
        End With
        Dim Pn14 As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
        With Pn14
            .Range.Font.Name = F.Name
            .Range.Font.Size = F.Size
            .Range.Font.Bold = False
            .Range.Text = ""
            .IndentCharWidth(0)
            .Range.InsertParagraphAfter()
            .Format.SpaceAfter = 0
        End With
        Dim Pn15 As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
        With Pn15
            .Range.Font.Name = F.Name
            .Range.Font.Size = F.Size
            .Range.Font.Bold = False
            .Range.Text = ""
            .IndentCharWidth(0)
            .Range.InsertParagraphAfter()
            .Format.SpaceAfter = 0
        End With
#End Region
        Dim P5 As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
        With P5
            .Range.Font.Name = F.Name
            .Range.Font.Size = F.Size
            .Range.Font.Bold = False
            .Range.Text = "Avec nos remerciements "
            .IndentCharWidth(0)
            .Range.InsertParagraphAfter()
            .Format.SpaceAfter = 0
        End With




        '  End If

        releaseObject(WordDocument)
        releaseObject(WordApplication)
        Return Result
    End Function
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
    Public Function Create_InvoiceR() As WordDocument

        Dim Result As New WordDocument
        With Result.WordDocument.PageSetup
            .LeftMargin = Math.Round((2) * 37.795275591, 2)
            .RightMargin = Math.Round(1.5 * 37.795275591, 2)
            .TopMargin = Math.Round(1.9 * 37.795275591, 2)
            .BottomMargin = Math.Round(3.17 * 37.795275591, 2)
        End With



        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "1  ", 0, 0)
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "1 ", 0, 0)
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "1  ", 0, 0)
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "1  ", 0, 0)
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "1  ", 0, 0)
        Try
            For i = 0 To Input_Adresse.Lines.Count - 1
                Dim Str As String = Input_Adresse.Lines(i)
                If Str.Length > 1 Then

                    If i = 0 Then
                        Result.Insert_Paragraph(New Drawing.Font("Arial", 12, FontStyle.Bold), IIf(Str.Length < 1, "1 ", Str), 0, 24)
                    ElseIf i = Input_Adresse.Lines.Count - 1 Then
                        Result.Insert_Paragraph(New Drawing.Font("Arial", 12, FontStyle.Bold), IIf(Str.Length < 1, "1 ", Str), 6, 24)
                    Else
                        Result.Insert_Paragraph(New Drawing.Font("Arial", 12, FontStyle.Bold), IIf(Str.Length < 1, "1 ", Str), 0, 24)
                    End If
                End If

            Next
        Catch ex As Exception

        End Try


        Dim L0 As Integer = 0
        Dim L1 As Integer = 24
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "1 ", 0, -24)
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "1 ", 0, L0)
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "Contribuable Tva : N° " & Current_Client.CHE & "                Genève " & Now.ToShortDateString & vbNewLine & vbNewLine, 0, 0)
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "1 ", 0, L0)
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), Me.Input_Libellé.Text, 0, 0)
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "1 ", 0, 0)
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "Concerne : " & Me.Input_Concerne.Text, 0, L0)
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "1 ", 0, 0)
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "1 ", 0, 0)
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "1 ", 0, L1)

        Dim P As Microsoft.Office.Interop.Word.Paragraph = Result.WordDocument.Paragraphs.Add

        'Word.Document.Range(Start:=0, End:=0)
        Dim F As New System.Drawing.Font("Arial", 12)
        Result.Insert_Table(P.Range, 9, 2)
        Result.WordTable.Cell(1, 1).Range.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle
        Result.WordTable.Cell(1, 1).Range.Text = "Total des prestations"
        Result.WordTable.Cell(1, 1).Range.Font.Name = F.Name
        Result.WordTable.Cell(1, 1).Range.Font.Size = F.Size

        Result.WordTable.Cell(1, 2).Range.Text = "(" & String.Format("{0:n2}", Val(Input_Quantity_Prestation.Text)) & ")" & vbTab & vbTab & String.Format("{0:n2}", Val(Input_Total_Prestation.Text))
        Result.WordTable.Cell(1, 2).Range.Font.Name = F.Name
        Result.WordTable.Cell(1, 2).Range.Font.Size = F.Size
        Result.WordTable.Cell(1, 2).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight
        ' Dim S As New ShowProperty(M.WordTable)

        Result.WordTable.Cell(2, 1).Range.Text = "Total des frais"
        Result.WordTable.Cell(2, 1).Range.Font.Name = F.Name
        Result.WordTable.Cell(2, 1).Range.Font.Size = F.Size

        Result.WordTable.Cell(2, 2).Range.Text = String.Format("{0:n2}", Double.Parse(Input_Total_Frais.Text))
        Result.WordTable.Cell(2, 2).Range.Font.Name = F.Name
        Result.WordTable.Cell(2, 2).Range.Font.Size = F.Size
        Result.WordTable.Cell(2, 2).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight
        Result.WordTable.Cell(2, 2).Range.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle

        Result.WordTable.Cell(3, 2).Range.Text = String.Format("{0:n2}", Double.Parse(Input_Total_HTVA.Text))
        Result.WordTable.Cell(3, 2).Range.Font.Name = F.Name
        Result.WordTable.Cell(3, 2).Range.Font.Size = F.Size
        Result.WordTable.Cell(3, 2).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight


        Result.WordTable.Cell(5, 1).Range.Text = "TVA " & My.Settings.TVA * 100
        Result.WordTable.Cell(5, 1).Range.Font.Name = F.Name
        Result.WordTable.Cell(5, 1).Range.Font.Size = F.Size

        Result.WordTable.Cell(5, 2).Range.Text = String.Format("{0:n2}", Double.Parse(Input_Total_TVA.Text))
        Result.WordTable.Cell(5, 2).Range.Font.Name = F.Name
        Result.WordTable.Cell(5, 2).Range.Font.Size = F.Size
        Result.WordTable.Cell(5, 2).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight
        Result.WordTable.Cell(5, 2).Range.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle

        Result.WordTable.Cell(6, 2).Range.Text = "__________"
        Result.WordTable.Cell(6, 2).Range.Font.Name = F.Name
        Result.WordTable.Cell(6, 2).Range.Font.Size = F.Size
        Result.WordTable.Cell(6, 2).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight
        Result.WordTable.Cell(6, 2).Range.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle

        Result.WordTable.Cell(7, 1).Range.Text = "Total payable au "
        Result.WordTable.Cell(7, 1).Range.Font.Name = F.Name
        Result.WordTable.Cell(7, 1).Range.Font.Size = F.Size

        Result.WordTable.Cell(7, 2).Range.Text = String.Format("{0:n2}", Double.Parse(Input_Total.Text))
        Result.WordTable.Cell(7, 2).Range.Font.Name = F.Name
        Result.WordTable.Cell(7, 2).Range.Font.Size = F.Size
        Result.WordTable.Cell(7, 2).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight
        Result.WordTable.Cell(7, 2).Range.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble
        P.Range.InsertParagraphAfter()
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "1  ", 0, 0)
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "1  ", 0, 0)
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "1  ", 0, 0)
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "1  ", 0, 0)
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "Avec nos remerciements ", 0, 0)

        ' Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "__________", 0, 0)
        ' Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "", 0, -L1)
        ' Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "", 0, L0)

        'Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "Total des prestations                                                         " & Quantity_Prestation.Text & "      " & String.Format("{0:n2}", Math.Round(Val(TotalPrestation.Text)), 2), 0, 0)
        'Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "", 0, L0)
        'Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "Total des frais                                                                                                  " & String.Format("{0:n2}", Math.Round(Val(TotalFrais.Text), 2)), 0, 0)
        'Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "", 0, L1)
        'Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "__________", 0, 0)
        'Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "                                                                                                                           " & String.Format("{0:n2}", Math.Round(Val(TotalHorsTva.Text), 2)), 0, 0)
        'Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "", 0, -L1 - 3)
        'Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "", 0, L0)
        'Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "TVA " & Math.Round(My.Settings.TVA * 100, 2) & "                                 	  		                                       " & String.Format("{0:n2}", Math.Round(Val(MontantTVa.Text), 2)), 0, 0)
        'Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "", 0, L1)
        'Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "__________", 0, 0)
        'Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "", 0, -L1)
        'Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "", 0, L0)
        'Result.Insert_Paragraph(New Drawing.Font("Arial", 12, FontStyle.Bold), "Total payable au                                                                             " & String.Format("{0:n2}", Math.Round(Val(GrandTotal.Text), 2)), 0, 0)
        'Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "", 0, L1)
        'Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "__________", 0, 0)
        'Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "", 0, -L1)
        Result.Release()
        Return Result
    End Function
    Public Function Print_InvoiceDetails(Optional ByVal WithTotals As Boolean = True) As WordDocument

        Dim ListPres As New List(Of Factures_Entries)
        Dim Code As String = Input_Société.Text & "_" & Year(Now) & "_" & Month(Now) & "_" & Input_N.Value & "_" & Input_Mandat.Text
        Dim Index As Integer = 0
        For Each Row As DevComponents.DotNetBar.SuperGrid.GridRow In SGC.PrimaryGrid.Rows
            If Row.Item(1).Value = True Then
                Dim Fs As New Factures_Entries(Index,
                                                         Code,
                                                         True,
                                                         Row.Item(2).Value,
                                                         Row.Item(3).Value,
                                                         Row.Item(4).Value,
                                                         Row.Item(6).Value,
                                                         Row.Item(7).Value,
                                                         Row.Item(8).Value,
                                                         Row.Item(9).Value,
                                                         Row.Item(5).Value)
                'Fs.Add()
                ListPres.Add(Fs)
                Try
                    Fs.Add()
                Catch ex As Exception

                End Try
                Index += 1
            End If
        Next



        Dim Result As New WordDocument
        With Result.WordDocument.PageSetup
            .LeftMargin = Math.Round((1.8) * 37.795275591, 2)
            .RightMargin = Math.Round(1.5 * 37.795275591, 2)
            .TopMargin = Math.Round(1.9 * 37.795275591, 2)
            .BottomMargin = Math.Round(3.17 * 37.795275591, 2)
        End With



        Dim P As Microsoft.Office.Interop.Word.Paragraph = Result.WordDocument.Paragraphs.Add
        Try

            'Word.Document.Range(Start:=0, End:=0)
            Dim F As New System.Drawing.Font("Arial", 12)
            For Each Fx As Factures_Entries In ListPres
                Dim PC As Microsoft.Office.Interop.Word.Paragraph = Result.WordDocument.Paragraphs.Add
                Dim Tb = Result.Insert_Table(PC.Range, 1, 2)
                Result.WordTable.Cell(1, 1).SetWidth(Result.WordApp.InchesToPoints(4.5), RulerStyle:=Microsoft.Office.Interop.Word.WdRulerStyle.wdAdjustNone) '255 ' * 37.795275591
                Result.WordTable.Cell(1, 2).SetWidth(Result.WordApp.InchesToPoints(1.5), RulerStyle:=Microsoft.Office.Interop.Word.WdRulerStyle.wdAdjustNone) '* 37.795275591

                With Result.WordTable.Cell(1, 2).Range
                    .ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight
                    .Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle
                    .Text = Fx.Quantity & IIf(WithTotals = True, vbTab & Fx.TotalHTVA, "")
                    .Font.Name = F.Name
                    .Font.Size = F.Size
                End With
                With Result.WordTable.Cell(1, 1).Range
                    .Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle
                    .Text = Fx.Description
                    .Font.Name = F.Name
                    .Font.Size = F.Size
                End With
                PC.Range.InsertParagraphAfter()


            Next
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Result.Release()
        Return Result
    End Function
#End Region

#End Region
    Private Sub Btn_Print_Empty_Click(sender As Object, e As EventArgs) Handles Btn_Print_Empty.Click
        Current_Société = Input_Société.SelectedItem
        Create_Invoice()
    End Sub

    Private Sub Btn_Print_Simple_Click(sender As Object, e As EventArgs) Handles Btn_Print_Simple.Click
        Print_InvoiceDetails()
    End Sub

    Private Sub Btn_Verify_Click(sender As Object, e As EventArgs) Handles Btn_Verify.Click
        If Input_Code.Text = "" Then
            Input_Code.Text = Input_Société.Text & "_" & Year(Now) & "_" & Month(Now) & "_" & Input_N.Value & "_" & Input_Mandat.Text
        End If

    End Sub

    Private Sub ButtonX5_Click(sender As Object, e As EventArgs) Handles ButtonX5.Click
        Dim TempList As New List(Of Factures_Entries)
        If List_TimeSheet.Count - 1 > 1 Then
            If IsNothing(List_Factures) Then
                List_Factures = New List(Of Factures)
            End If
            If List_Factures.Count - 1 < 1 Then
                If IsNothing(Current_Factures) Then
                    Current_Factures = New Factures
                End If
                List_Factures = Current_Factures.List
            End If
            Dim Index As Integer = List_Factures.Count + 1
            For Each T As TimeSheet In List_TimeSheet
                If T.Active = True Then
                    Dim F As New Factures_Entries(Index,
                                                  Input_Code.Text, T.Active, T.TimeIn, T.Collaborateur, T.Mandat, T.UnitPrice, T.Description, T.Facturable, T.TotalHTVA, T.Quantity)
                    F.Add()
                    TempList.Add(F)
                End If
                T.Active = False
                T.Save()
                Index += 1
            Next

            SmartCoder.Jarvis.Speak("Invoices entries recorded")
            SGC2.PrimaryGrid.DataSource = TempList

            Dim Facture As New Factures(Input_Code.Text, Input_Société.Text, Year(Now), Month(Now), Input_N.Value, Input_Mandat.Text, Input_Adresse.Text, Now, Input_DateStart.Value, Input_DateEnd.Value, Input_Concerne.Text, Double.Parse(Input_Quantity_Frais.Text) + Double.Parse(Input_Quantity_Prestation.Text), Input_Total_HTVA.Value, Input_Total_Frais.Value, Input_Total_HTVA.Value, Input_Total.Value, Input_Libellé.Text)
            '   "Z:\Factures émises\" & Input_Société.Text & "\" & Year(Now) & "\Facture avec Prestation " & Input_Code.Text & ".xlsx",
            '  "Z:\Factures émises\" & Input_Société.Text & "\" & Year(Now) & "\Facture sans Prestation " & Input_Code.Text & ".xlsx",
            'Current_Client.Répertoire & "\Factures à Payer\" & Year(Now) & "\" & Input_Code.Text & ".xlsx")
            Facture.Add()
            SmartCoder.Jarvis.Speak("Invoice Saved!")

        End If
    End Sub

    Private Sub ButtonX4_Click_1(sender As Object, e As EventArgs) Handles ButtonX4.Click
        RefreshData()
        SmartCoder.Jarvis.Speak("The list has been refreshed.")
    End Sub

    Private Sub ButtonX2_Click_1(sender As Object, e As EventArgs) Handles ButtonX2.Click
        RefreshTimeSheet()
        Current.Save()
        ButtonX4.RaiseClick()
        AddNew = False
        SmartCoder.Jarvis.Speak("Element saved")
    End Sub

    Private Sub Input_TotalHTVA_ValueChanged(sender As Object, e As EventArgs) Handles Input_TotalHTVA.ValueChanged
        Input_GrandTOTAL.Value = Input_TotalHTVA.Value * (1 + My.Settings.TVA)
    End Sub

    Private Sub Input_Quantity_ValueChanged(sender As Object, e As EventArgs) Handles Input_Quantity.ValueChanged
        Input_TotalHTVA.Value = Input_Quantity.Value * Input_UnitPrice.Value
    End Sub

    Private Sub Input_Collaborateur_Leave(sender As Object, e As EventArgs) Handles Input_Collaborateur.Leave
        Dim A As Tarif = Tarif.GetunitPrice(Input_Collaborateur.Text, CB_Client.Text)
        Input_UnitPrice.Value = A.Price
    End Sub

    Private Sub CB_Service_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Service.SelectedIndexChanged
        If IsNothing(Current_Prestation_Category) Then
            Current_Prestation_Category = New Prestation_Category
            Current_Prestation_Category.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password))
        End If
        CB_Type.DataSource = Current_Prestation_Category.List

    End Sub

    Private Sub CB_Type_Leave(sender As Object, e As EventArgs) Handles CB_Type.Leave
        If IsNothing(Current_Prestations) Then
            Current_Prestations = New Prestations
            Current_Prestations.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password))
        End If
        Dim Lt As New List(Of Prestations)
        For Each P As Prestations In Current_Prestations.List
            If P.Service = CB_Service.Text Then
                Lt.Add(P)
            End If
        Next
        CB_Prestation.DataSource = Lt
    End Sub

    Private Sub Btn_InsertLine_Click(sender As Object, e As EventArgs) Handles Btn_InsertLine.Click
        If CB_Prestation.Text.Length > 1 Then
            Input_Description.Text += CB_Prestation.Text & vbNewLine
        End If
    End Sub

    Private Sub Input_Mandat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Input_Mandat.SelectedIndexChanged
        Input_Adresse.Text = ""
        If Not IsNothing(Input_Mandat.SelectedItem) Then
            Try
                Dim I As Clients = Input_Mandat.SelectedItem
                If I.RaisonSociale.Length > 1 Then
                    Input_Adresse.Text += I.RaisonSociale & vbNewLine
                End If

                If I.NomClient.Length > 1 Then
                    Input_Adresse.Text += I.NomClient & vbNewLine
                End If
                Input_Adresse.Text += I.Address1 & vbNewLine
                If I.Address2.Length > 1 Then
                    Input_Adresse.Text += I.Address2 & vbNewLine
                End If
                If I.Region.Length > 1 Then
                    Input_Adresse.Text += I.PostalCode & " " & I.Region & vbNewLine &
                        I.City & " " & I.Country
                Else
                    If I.City.Length > 1 Then
                        Input_Adresse.Text += I.PostalCode & " " & I.City & vbNewLine &
                            I.Country
                    End If
                End If
                SW_Limit.Value = I.Forfait
                If SW_Limit.Value = True Then
                    Forfais_Value.Value = I.ForfaitValue

                End If


            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Input_Libellé_Leave(sender As Object, e As EventArgs) Handles Input_Libellé.Leave
        Btn_Verify.PerformClick()
    End Sub

    Private Sub Btn_SendToExcel_Click(sender As Object, e As EventArgs) Handles Btn_SendToExcel.Click
        Dim Msg As String = Nothing
        Try
            SmartCoder.ExcelDocument.Export_DataTable(SGC, "TimeSheet.xlsx", Msg) 'My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\

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

    Private Sub Btn_Select_All_Click(sender As Object, e As EventArgs) Handles Btn_Select_All.Click
        For Each Row As DevComponents.DotNetBar.SuperGrid.GridRow In SGC.PrimaryGrid.Rows
            Row.Item(1).Value = True
        Next
    End Sub

    Private Sub Btn_Deselect_All_Click(sender As Object, e As EventArgs) Handles Btn_Deselect_All.Click
        For Each Row As DevComponents.DotNetBar.SuperGrid.GridRow In SGC.PrimaryGrid.Rows
            Row.Item(1).Value = False
        Next
    End Sub

    Private Sub ButtonX6_Click(sender As Object, e As EventArgs) Handles ButtonX6.Click
        Print_InvoiceDetails(False)
    End Sub
End Class
