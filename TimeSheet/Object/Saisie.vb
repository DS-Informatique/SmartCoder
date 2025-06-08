Imports System.Threading
Imports DevComponents.DotNetBar.SuperGrid
Public Class Saisie
    Public Function RefreshTimeSheet() As Boolean
        Dim Result As Boolean = False
        Dim LTimeSheet As New List(Of M_TimeSheet.TimeSheet)
        Dim X As New M_TimeSheet.TimeSheet
        LTimeSheet = X.List
        Dim Msg As String = ""
        If Input_Collaborateur.Text = "" Then
            Msg += "Aucun Collaborateur défini." & vbNewLine
        Else
            Current.Collaborateur = Input_Collaborateur.Text
        End If
        If Input_Mandat.Text = "" Then
            Msg += "Aucun Mandat défini." & vbNewLine
        Else
            Current.Mandat = Input_Mandat.Text
        End If
        If Input_Quantity.Text = "" Then
            Msg += "Aucun quantité défini." & vbNewLine
        Else
            Current.Quantity = Input_Quantity.Text
        End If
        If Input_UnitPrice.Text = "" Then
            Msg += "Aucun prix défini." & vbNewLine
        Else
            Current.UnitPrice = Double.Parse(Input_UnitPrice.Text)
        End If
        If Input_TimeIn.Text = "" Then
            Msg += "Aucune date défini." & vbNewLine
        Else
            Current.TimeIn = Input_TimeIn.Value
        End If
        If Body.Text = "" Then
            Msg += "Aucune Description défini." & vbNewLine
        Else
            Current.Description = Body.Text
        End If
        Current.Facturable = Input_Facturable.Value
        If Msg.Length > 0 Then
            '  MsgBox(Msg)
            Result = False
        Else
            Result = True
        End If
        Return Result
    End Function
    Private Sub Btn_Verify_Click(sender As Object, e As EventArgs) 'Handles Btn_Verify.Click
        RefreshTimeSheet()
    End Sub

    Private Sub MesTimeSheet_Load(sender As Object, e As EventArgs) Handles Me.Load
        CheckForIllegalCrossThreadCalls = False

        Import()

    End Sub
    Dim ListCollaborateur As New List(Of Collaborateur)
    Dim ListMandat As New List(Of Clients)
    Dim ListMandat_Actif As New List(Of Clients)
    Dim ListServices As New List(Of Services)
    Dim ListPrestations As New List(Of Prestation_Category)
    Public Sub Import()
        Dim TCol As New Collaborateur
        Dim TCli As New Clients
        Dim TSer As New Services
        Dim TPre As New Prestation_Category
        ListCollaborateur = New List(Of Collaborateur)
        ListCollaborateur = TCol.List
        Input_Collaborateur.DataSource = ListCollaborateur
        ListMandat = New List(Of Clients)
        ListMandat = TCli.List
        ListMandat_Actif = New List(Of Clients)
        For Each Client As Clients In ListMandat
            If Client.Active = True Then
                ListMandat_Actif.Add(Client)
            End If
        Next
        ListServices = New List(Of Services)
        ListServices = TSer.List
        CB_Service.DataSource = ListServices
        ListPrestations = New List(Of Prestation_Category)
        ListPrestations = TPre.List
        CB_Type.DataSource = ListPrestations

        Input_Mandat.DataSource = ListMandat_Actif
        RefreshData()
    End Sub
    Private _Current As TimeSheet
    Public Property Current() As TimeSheet
        Get
            Return _Current
        End Get
        Set(ByVal value As TimeSheet)
            _Current = value
            If Not IsNothing(value) Then
                With value
                    Input_Collaborateur.Text = .Collaborateur
                    Body.Text = .Description
                    Input_Facturable.Value = .Facturable
                    Input_Mandat.Text = .Mandat
                    Input_Quantity.Text = .Quantity
                    Input_TimeIn.Value = .TimeIn
                    Input_Total.Text = .Total
                    Input_TotalHTVA.Text = .TotalHTVA
                    Input_UnitPrice.Text = .UnitPrice
                End With

            End If
        End Set
    End Property

    Dim List As New List(Of TimeSheet)
    Dim _DataSet As DataSet
    Dim _Loading As Boolean
    Private _LoadThread As Thread

    Public Sub RefreshData()
        List = New List(Of TimeSheet)
        Dim I As New TimeSheet
        I.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.DataBase))
        List = I.List

        Dim T0 As New Prestation_Category
        T0.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.DataBase))
        CB_Type.DataSource = T0.List
        Dim T1 As New Clients
        Input_Mandat.DataSource = T1.List
        Dim T2 As New Collaborateur
        Input_Collaborateur.DataSource = T2.List

        '   Current = List(0)
        ' PropTarif.SelectedObject = I.Table
        InitializeGrid()
        Dim dataSource As Object = Nothing
        Dim dataMember As String = Nothing
        Dim context As Object = Nothing
        '  List = .Tarif.List
        dataSource = List
        context = dataSource
        ' Set the SuperGrid DataSource and DataMember, and
        ' set our BindingManager for later data traversal

        SGC.PrimaryGrid.DataSource = dataSource
        SGC.PrimaryGrid.DataMember = dataMember
        If dataSource Is Nothing Then Bm = Nothing Else Bm = SGC.BindingContext(context)
        ' Make sure our UI reflects the current state of affairs

    End Sub

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

        _LoadThread = New Thread(AddressOf LoadThread)
        _LoadThread.Start()
    End Sub

#Region "LoadThread"

    Private Sub LoadThread()
        Try


            Dim table As New DataTable
            If IsNothing(Current) Then
                Current = New TimeSheet
            End If
            If IsNothing(Current.Table) Then
                Current.Table = New SmartCoder.M_FileManager.Table(Current.TableName, Current.FilePath, Current.Password, False)
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
    Private Sub VcrFirstClick(ByVal sender As Object, ByVal e As EventArgs) Handles vcr1.FirstClick
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
    Private Sub VcrPreviousClick(ByVal sender As Object, ByVal e As EventArgs) Handles vcr1.PreviousClick
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
    Private Sub VcrNextClick(ByVal sender As Object, ByVal e As EventArgs) Handles vcr1.NextClick
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
    Private Sub VcrLastClick(ByVal sender As Object, ByVal e As EventArgs) Handles vcr1.LastClick
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
        If _Bm.Position > _Bm.Count Then
            Current = List(_Bm.Count)
        ElseIf _Bm.Position < 0 Then
            Current = List(0)
        Else
            Current = List(_Bm.Position)
        End If
        If _Bm Is Nothing OrElse _Bm.Count <= 1 Then
            vcr1.FirstButton.Enabled = False
            vcr1.PreviousButton.Enabled = False
            vcr1.NextButton.Enabled = False
            vcr1.LastButton.Enabled = False
            vcr1.Label.Text = IIf(_Bm Is Nothing OrElse _Bm.Count = 0, "No records", "Only Record")
        Else
            If _Bm.Position = 0 Then
                vcr1.FirstButton.Enabled = InlineAssignHelper(vcr1.PreviousButton.Enabled, False)

                vcr1.LastButton.Enabled = InlineAssignHelper(vcr1.NextButton.Enabled, (_Bm.Count > 1))

                vcr1.Label.Text = "First of " & _Bm.Count & " records"
            ElseIf _Bm.Position = _Bm.Count - 1 Then
                vcr1.LastButton.Enabled = False
                vcr1.NextButton.Enabled = False

                vcr1.FirstButton.Enabled = InlineAssignHelper(vcr1.PreviousButton.Enabled, (_Bm.Count > 1))

                vcr1.Label.Text = "Last of " & _Bm.Count & " records"
            Else
                vcr1.FirstButton.Enabled = True
                vcr1.PreviousButton.Enabled = True
                vcr1.NextButton.Enabled = True
                vcr1.LastButton.Enabled = True

                vcr1.Label.Text = "Record " & (_Bm.Position + 1) & " of " & _Bm.Count
            End If
        End If
    End Sub

#End Region
    Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, ByVal value As T) As T
        target = value
        Return value
    End Function
#End Region

    Dim AddNew As Boolean = False
    Dim IsReady As Boolean = False
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        ' Btn_Verify.PerformClick()

        Current = New TimeSheet
        AddNew = True
        IsReady = False
        Timer1.Start()
    End Sub

    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click
        Timer1.Stop()
        Btn_Add.Enabled = False
        ButtonX1.Enabled = True
        ButtonX2.Enabled = True
        Try

            Current.Add()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        List = Current.List

        Current = List(0)
        InitializeGrid()
        RefreshData()
        AddNew = False

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ButtonX1.Enabled = False
        ButtonX2.Enabled = False
        Btn_Add.Enabled = RefreshTimeSheet()


    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        RefreshTimeSheet()
        Current.Save()
        ButtonX4.RaiseClick()
        AddNew = False
        SmartCoder.Jarvis.Speak("Element saved")
    End Sub

    Private Sub CB_Type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Type.SelectedIndexChanged
        If CB_Type.Text <> "" Then
            CB_Prestation.DataSource = Nothing
            CB_Prestation.DataSource = Prestations.SearchByName(CB_Type.Text)
        End If
    End Sub
    Dim ActivePrice As New Tarif

    Public Sub CalculateUnitCost()
        Dim Cb As String = Input_Collaborateur.Text
        Dim Code As String = Input_Mandat.Text
        ActivePrice = New Tarif
        '   ActivePrice = Tarif.GetunitPrice(Cb, Code)
        Input_UnitPrice.Text = ActivePrice.Price
        Input_TotalHTVA.Text = Math.Round(ActivePrice.Price * Val(Me.Input_Quantity.Text), 2) & " CHF"
        Input_Total.Text = Math.Round((1 + My.Settings.TVA) * Math.Round(ActivePrice.Price * Val(Me.Input_Quantity.Text), 2), 2) & " CHF"
        'Dim S As New ShowProperty(ActivePrice)
        'S.Show()
        'Dim S2 As New ShowProperty(Tarif.List)
        'S2.Show()
        'Dim M As New DevComponents.DotNetBar.Office2007Form
        'Dim Tb As New M_Fichier.Table("Tarif", )
        'Dim LV As New ListViewEx
        'LV.View = System.Windows.Forms.View.Details
        'LV.Columns.AddRange(Tb.Columns.ToArray)
        'LV.Items.AddRange(Tb.Data.ToArray)
        'LV.Dock = DockStyle.Fill
        'LV.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        'M.Controls.Add(LV)
        ' M.Show()
    End Sub

    Private Sub Btn_InsertLine_Click(sender As Object, e As EventArgs) Handles Btn_InsertLine.Click
        If CB_Prestation.Text <> "" Then
            Body.Text += CB_Prestation.Text & vbNewLine
        End If
    End Sub

    Private Sub Btn_CalculateCost_Click(sender As Object, e As EventArgs) Handles Btn_CalculateCost.Click

    End Sub

    Private Sub CB_Service_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Service.SelectedIndexChanged, CB_Service.TextUpdate
        Dim T As New Prestation_Category
        Dim List As New List(Of Prestation_Category)
        Dim Ser As Services
        Ser = CB_Service.SelectedItem
        If Not IsNothing(Ser) Then
            List = Prestation_Category.SearchByName(Ser.Service)
            CB_Type.DataSource = List

        End If
    End Sub

    Private Sub ButtonX4_Click(sender As Object, e As EventArgs) Handles ButtonX4.Click
        RefreshData()
    End Sub
End Class
