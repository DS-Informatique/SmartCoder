Imports System.Threading
Imports DevComponents.DotNetBar.SuperGrid

Public Class FactureEntriesViewer
#Region "|1| [Property]{2}"
#Region "|01.00| <Property> [Current|Factures_Entries]"
    Private _Current As Factures_Entries
    Public Property Current() As Factures_Entries
        Get
            Return _Current
        End Get
        Set(ByVal value As Factures_Entries)
            _Current = value
            If Not IsNothing(value) Then
                With value
                    Input_Active.Value = value.Active
                    Input_Collaborateur.Text = value.Collaborateur
                    Input_Description.Text = value.Description
                    Input_ID.Value = value.ID
                    Input_Mandat.Text = value.Mandat
                    Input_Quantity.Value = value.Quantity
                    Input_TotalHTVA.Value = value.TotalHTVA
                    Input_UnitPrice.Value = value.UnitPrice
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
#Region "|4| [Sub]{5}"
#Region "|04.00| <Sub> [RefreshData]"
    Public Sub RefreshData()
        List = New List(Of Factures_Entries)
        Dim I As New Factures_Entries
        I.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password))
        List = I.List
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
#Region "|04.01| <Sub> [InitializeGrid]"
    ''' <summary>
    ''' Initializes our default sample environment
    ''' </summary>
    Private Sub InitializeGrid()
        Dim panel As GridPanel = SGC.PrimaryGrid

        ' None - is the default
        panel.RowHeaderWidth = 50
        panel.RowHeaderIndexOffset = 1

        ' Hook onto a few of the SuperGrid events in order to
        ' have our UI reflect the current state of the grid

        ' AddHandler SGC.RowDeleted, AddressOf SuperGridControl1RowDeleted
        ' AddHandler SGC.RowRestored, AddressOf SuperGridControl1RowRestored
        ' AddHandler SGC.RowsPurged, AddressOf SuperGridControl1RowsPurged

        ' When new rows are added via the grid, let's
        ' see that they have something imaginative in them

        'AddHandler SGC.RowSetDefaultValues, AddressOf SuperGridControl1RowSetDefaultValues

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


            Dim table As New DataTable
            If IsNothing(Current) Then
                Current = New Factures_Entries
            End If
            If IsNothing(Current.Table) Then
                Current.Table = New SmartCoder.M_FileManager.Table(Current.TableName, Current.FilePath, Current.Password, True)
            End If

            table = Current.Table.DataTable
            '  Dim col As New DataColumn()
            '  col.ColumnName = "FirstName"
            '  col.DataType = Type.[GetType]("System.String")
            '  table.Columns.Add(col)

            'col = New DataColumn()
            'col.ColumnName = "LastName"
            'col.DataType = Type.[GetType]("System.String")
            'table.Columns.Add(col)

            'col = New DataColumn()
            'col.ColumnName = "Age"
            'col.DataType = Type.[GetType]("System.Int32")
            'table.Columns.Add(col)

            'col = New DataColumn()
            'col.ColumnName = "Id"
            'col.DataType = Type.[GetType]("System.Int32")
            'table.Columns.Add(col)

            'col = New DataColumn()
            'col.ColumnName = "HireDate"
            'col.DataType = Type.[GetType]("System.DateTime")
            'table.Columns.Add(col)

            _DataSet = New DataSet("MyDataSet")
            _DataSet.Tables.Add(table.Clone)

            table.BeginLoadData()
            For Each Row As DataRow In table.Rows
                Row.AcceptChanges()
            Next
            ' Add 10000 rows to fiddle with

            '  For i As Integer = 0 To 9999
            '  Dim row As DataRow = table.NewRow()

            '            Dim emp As Employee = Employee.GetNewEmployee()

            '            row(0) = emp.FirstName
            '            row(1) = emp.LastName
            '            row(2) = emp.Age
            '            row(3) = emp.Id
            '            row(4) = emp.HireDate

            '            table.Rows.Add(row)

            '            row.AcceptChanges()
            '            Next

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

                Vcr1.Label.Text = "First of " & _Bm.Count & " records " & "|" & Current.ID & "|" & Current.Mandat & "|" & Current.TotalHTVA
            ElseIf _Bm.Position = _Bm.Count - 1 Then
                Vcr1.LastButton.Enabled = False
                Vcr1.NextButton.Enabled = False

                Vcr1.FirstButton.Enabled = InlineAssignHelper(Vcr1.PreviousButton.Enabled, (_Bm.Count > 1))

                Vcr1.Label.Text = "Last of " & _Bm.Count & " records" & "|" & Current.ID & "|" & Current.Mandat & "|" & Current.TotalHTVA
            Else
                Vcr1.FirstButton.Enabled = True
                Vcr1.PreviousButton.Enabled = True
                Vcr1.NextButton.Enabled = True
                Vcr1.LastButton.Enabled = True

                Vcr1.Label.Text = "Record " & (_Bm.Position + 1) & " of " & _Bm.Count & " " & "|" & Current.ID & "|" & Current.Mandat & "|" & Current.TotalHTVA
            End If
        End If
    End Sub
#End Region
#End Region
#Region "|5| [Function]{2}"
#Region "|05.00| <Function> [RefreshClient|Boolean]"
    Public Function RefreshFactures_Entries() As Boolean
        Dim Result As Boolean = False
        Dim LFactures_Entries As New List(Of Factures_Entries)
        Dim X As New Factures_Entries
        LFactures_Entries = X.List
        Dim Msg As String = ""
        If Not IsNothing(Current) Then
            Current = New Factures_Entries
        End If
        With Current
            .Active = Input_Active.Value
            .Collaborateur = Input_Collaborateur.Text
            .DateEntry = Input_DateEntry.Value
            .Description = Input_Description.Text
            .Facturable = Input_Facturable.Value
            .Facture = Input_Facture.Text
            .ID = Input_ID.Value
            .Mandat = Input_Mandat.Text
            .Quantity = Input_Quantity.Value
            .TotalHTVA = Input_TotalHTVA.Value
            .UnitPrice = Input_UnitPrice.Value
        End With
        If Msg.Length > 0 Then
            Result = False
        Else
            Result = True

        End If
        Log += Msg & vbNewLine
        Return Result
    End Function
#End Region
#Region "|05.01| <Function> [InlineAssignHelper(Of T)(Target|T,Value|T)|T]"
    Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, ByVal value As T) As T
        target = value
        Return value
    End Function
#End Region
#End Region
#Region "|6| [Runtime]{7}"
#Region "|06.00| <Runtime> [List|List(Of Factures_Entries)]"
    Dim List As New List(Of Factures_Entries)
#End Region
#Region "|06.01| <Runtime> [_DataSet|DataSet]"
    Dim _DataSet As DataSet

#End Region
#Region "|06.02| <Runtime> [_Loading|Boolean]"
    Dim _Loading As Boolean
#End Region
#Region "|06.03| <Runtime> [_LoadThread|Thread]"
    Private _LoadThread As Thread
#End Region
#Region "|06.04| <Runtime> [AddNew|Boolean]"
    Dim AddNew As Boolean = False
#End Region
#Region "|06.05| <Runtime> [IsReady|Boolean]"
    Dim IsReady As Boolean = False
#End Region
#Region "|05.06| <Runtime> [Log|String]"
    Public Log As String
#End Region
#End Region
#Region "|7| [Loader]{1}"
#Region "|07.00| <Loader> [Load]"
    Private Sub MesClients_Load(sender As Object, e As EventArgs) Handles Me.Load
        CheckForIllegalCrossThreadCalls = False
        If IsNothing(List_Collaborateur) Then
            List_Collaborateur = New List(Of Collaborateur)
        End If
        If IsNothing(Current_Collaborateur) Then
            Current_Collaborateur = New Collaborateur
            Current_Collaborateur.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password))
        End If
        For Each C As Collaborateur In Current_Collaborateur.List
            If C.Active = True Then
                List_Collaborateur.Add(C)
            End If
        Next
        Input_Collaborateur.DataSource = List_Collaborateur

        If IsNothing(List_Clients_Active) Then
            List_Clients_Active = New List(Of Clients)
        End If
        If List_Clients_Active.Count - 1 < 1 Then
            If IsNothing(Current_Client) Then
                Current_Client = New Clients
                Current_Client.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password))
            End If
            For Each Cl As Clients In Current_Client.List
                If Cl.Active = True Then
                    List_Clients_Active.Add(Cl)
                End If
            Next
        End If
        Input_Mandat.DataSource = List_Clients_Active

        If IsNothing(List_Factures) Then
            List_Factures = New List(Of Factures)
        End If
        If List_Factures.Count - 1 < 1 Then
            If IsNothing(Current_Factures) Then
                Current_Factures = New Factures
                Current_Factures.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password))
            End If
            List_Factures = Current_Factures.List
        End If
        Input_Facture.DataSource = List_Factures
        RefreshData()
    End Sub
#End Region
#End Region
#Region "|10| [Event]{10}"
#Region "|10.01| <Event> [BmPositionChanged]"
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
#Region "|10.02| <Event> [VcrFirstClick]"
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
#Region "|10.03| <Event> [VcrPreviousClick]"
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
#Region "|10.04| <Event> [VcrNextClick]"
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
#Region "|10.05| <Event> [VcrLastClick]"
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
#Region "|10.06| <Event> [ButtonX1_Click]"
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        If Not IsNothing(Input_Facture.SelectedItem) Then
            Current_Factures = Input_Facture.SelectedItem
            If IsNothing(List_Factures_Entries) Then
                List_Factures_Entries = New List(Of Factures_Entries)
            End If
            If List_Factures_Entries.Count - 1 < 1 Then
                If IsNothing(Current_Factures_Entries) Then
                    Current_Factures_Entries = New Factures_Entries
                    Current_Factures_Entries.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password))
                End If
                List_Factures_Entries = Current_Factures_Entries.List
            End If
            List = New List(Of Factures_Entries)
            Output_GrandTotal.Value = 0
            Output_Quantity_Prestation.Text = 0
            Output_Total.Value = 0
            Output_Total_HTVA.Value = 0
            Output_Total_TVA.Value = 0
            Output_TVA.Value = 0
            Dim QDP As Double = 0
            For Each F As Factures_Entries In List_Factures_Entries
                If F.Facture = Input_Facture.Text Then
                    If F.Collaborateur = "@FRAIS" Then
                    Else
                        QDP += F.Quantity
                        Output_Total_HTVA.Value += F.TotalHTVA
                    End If

                    List.Add(F)
                End If
            Next
            SGC.PrimaryGrid.DataSource = List
            Dim Context As Object = Nothing
            Dim dataSource As Object = List
            Context = dataSource
            If dataSource Is Nothing Then Bm = Nothing Else Bm = SGC.BindingContext(context)

            InitializeGrid()

            Output_Quantity_Prestation.Text = Math.Round(QDP, 2)
            Output_Total_TVA.Value = Math.Round(Output_Total_HTVA.Value * My.Settings.TVA, 2)
            Output_GrandTotal.Value = Math.Round(Output_Total_HTVA.Value + Output_Total_TVA.Value, 2)
        End If
    End Sub
#End Region

    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles ButtonX3.Click

        If Not IsNothing(Current) Then
            Try
                Current.Delete()
                SmartCoder.Jarvis.Speak("Element deleted.")
            Catch ex As Exception

                SmartCoder.Jarvis.Speak("Probleme while deleting the element.")
            End Try
        End If
    End Sub
#Region "|10.09| <Event> [ButtonX2_Click]"
    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        RefreshFactures_Entries()
        Current.Save()
        ButtonX4.RaiseClick()
        AddNew = False
        SmartCoder.Jarvis.Speak("Element saved")
    End Sub

    Private Sub Btn_SendToExcel_Click(sender As Object, e As EventArgs) Handles Btn_SendToExcel.Click
        Dim Msg As String = Nothing
        Try
            SmartCoder.ExcelDocument.Export_DataTable(SGC, "FacturesEntries.xlsx", Msg) 'My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\

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

    Private Sub Input_Facture_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Input_Facture.SelectedIndexChanged
        If Input_Facture.Text <> "" Then
            ButtonX1.PerformClick()
        End If
    End Sub

    Private Sub ButtonX6_Click(sender As Object, e As EventArgs) Handles ButtonX6.Click
        Output_GrandTotal.Value = 0
        Output_Quantity_Prestation.Text = 0
        Output_Total.Value = 0
        Output_Total_HTVA.Value = 0
        Output_Total_TVA.Value = 0
        Output_TVA.Value = 0
        Dim QDP As Double = 0
        If Not IsNothing(List) Then

            For Each F As Factures_Entries In List
                If F.Facture = Input_Facture.Text Then
                    If F.Collaborateur = "@FRAIS" Then
                    Else
                        QDP += F.Quantity
                        Output_Total_HTVA.Value += F.TotalHTVA
                    End If

                    List.Add(F)
                End If
            Next
            Output_Quantity_Prestation.Text = Math.Round(QDP, 2)
            Output_Total_TVA.Value = Math.Round(Output_Total_HTVA.Value * My.Settings.TVA, 2)
            Output_GrandTotal.Value = Math.Round(Output_Total_HTVA.Value + Output_Total_TVA.Value, 2)
        End If
    End Sub

    Private Sub ButtonX4_Click(sender As Object, e As EventArgs) Handles ButtonX4.Click
        If IsNothing(List_Collaborateur) Then
            List_Collaborateur = New List(Of Collaborateur)
        End If
        If IsNothing(Current_Collaborateur) Then
            Current_Collaborateur = New Collaborateur
            Current_Collaborateur.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password))
        End If
        For Each C As Collaborateur In Current_Collaborateur.List
            If C.Active = True Then
                List_Collaborateur.Add(C)
            End If
        Next
        Input_Collaborateur.DataSource = List_Collaborateur

        If IsNothing(List_Clients_Active) Then
            List_Clients_Active = New List(Of Clients)
        End If
        If List_Clients_Active.Count - 1 < 1 Then
            If IsNothing(Current_Client) Then
                Current_Client = New Clients
                Current_Client.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password))
            End If
            For Each Cl As Clients In Current_Client.List
                If Cl.Active = True Then
                    List_Clients_Active.Add(Cl)
                End If
            Next
        End If
        Input_Mandat.DataSource = List_Clients_Active

        If IsNothing(List_Factures) Then
            List_Factures = New List(Of Factures)
        End If
        If List_Factures.Count - 1 < 1 Then
            If IsNothing(Current_Factures) Then
                Current_Factures = New Factures
                Current_Factures.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password))
            End If
            List_Factures = Current_Factures.List
        End If
        Input_Facture.DataSource = List_Factures

    End Sub


#End Region
#End Region
End Class
