Imports System.Text
Imports System.Threading
Imports DevComponents.DotNetBar.SuperGrid

Public Class Form1

    Private _Current As Tarif
    Public Property Current() As Tarif
        Get
            Return _Current
        End Get
        Set(ByVal value As Tarif)
            _Current = value
            If Not IsNothing(value) Then
                Try
                    Input_Code.Text = value.Code
                    Input_Collaborateur.Text = value.Collaborateur
                    Input_DateIn.Text = value.DateIN
                    Input_Price.Text = value.Price
                    PropCurrent.SelectedObject = value
                Catch ex As Exception

                End Try

            End If
        End Set
    End Property
    Dim List As New List(Of Tarif)
    Dim _DataSet As DataSet
    Dim _Loading As Boolean
    Private _LoadThread As Thread

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        'BW.RunWorkerAsync()
        RefreshData()
    End Sub

    Public Sub RefreshData()
        List = New List(Of Tarif)
        Dim I As New Tarif
        List = I.List
        '   Current = List(0)
        PropTarif.SelectedObject = I.Table
        InitializeGrid()
        Dim dataSource As Object = Nothing
        Dim dataMember As String = Nothing
        Dim context As Object = Nothing
        '  List = Tarif.List
        dataSource = List
        context = dataSource
        ' Set the SuperGrid DataSource and DataMember, and
        ' set our BindingManager for later data traversal

        SGC.PrimaryGrid.DataSource = dataSource
        SGC.PrimaryGrid.DataMember = dataMember
        If dataSource Is Nothing Then Bm = Nothing Else Bm = SGC.BindingContext(context)
        ' Make sure our UI reflects the current state of affairs

    End Sub
    Private Sub UpdateBindings(ByVal Context As Object)
        Input_Code.DataBindings.Clear()
        Input_Collaborateur.DataBindings.Clear()
        Input_DateIn.DataBindings.Clear()
        Input_Price.DataBindings.Clear()
        If Not IsNothing(Context) Then

            Input_Code.DataBindings.Add(New Binding("Text", Context, "Code"))
            Input_Collaborateur.DataBindings.Add(New Binding("Text", Context, "Collaborateur"))
            Input_DateIn.DataBindings.Add(New Binding("DateTime", Context, "DateIN"))
            Input_Price.DataBindings.Add(New Binding("Double", Context, "Price"))

        Else
            Input_Code.Text = ""
            Input_Collaborateur.Text = ""
            Input_DateIn.Text = ""
            Input_Price.Text = ""
        End If
    End Sub

    Private Sub BtnInsertRow_Click(sender As Object, e As EventArgs)
        If Bm IsNot Nothing Then
            Dim index As Integer = Math.Max(0, Bm.Position)

            Dim ilist As IList = TryCast(SGC.PrimaryGrid.DataSource, IList)

            If ilist IsNot Nothing Then


                ilist.Insert(index, Current)

                SGC.PrimaryGrid.InvalidateLayout()
            End If

            If Bm.Count > 0 Then
                '   btnDeleteRow.Enabled = True
            End If

        End If
    End Sub

    Private Sub BtnDeleteRow_Click(sender As Object, e As EventArgs)
        If Bm IsNot Nothing Then
            If Bm.Position >= 0 Then
                Bm.RemoveAt(Bm.Position)

                If Bm.Count = 0 Then
                    ' btnDeleteRow.Enabled = False
                End If

                ' For those interfaces that don't support automatic
                ' notification, lets refresh the display ourselves

                '  If cboDataSource.SelectedIndex = 0 OrElse cboDataSource.SelectedIndex = 1 Then
                '  SGC.PrimaryGrid.InvalidateLayout()
                '  End If

            End If
        End If
    End Sub

    Private Sub BtnAccept_Click(sender As Object, e As EventArgs)
        If _DataSet IsNot Nothing Then
            _DataSet.AcceptChanges()
        End If
    End Sub

    Private Sub BtnReject_Click(sender As Object, e As EventArgs)
        If _DataSet IsNot Nothing Then
            Dim table As DataTable = _DataSet.Tables("Tarif").GetChanges()

            If table IsNot Nothing Then
                SGC.PrimaryGrid.BeginDataUpdate()
                table.BeginLoadData()

                _DataSet.RejectChanges()

                table.EndLoadData()
                SGC.PrimaryGrid.EndDataUpdate()
            End If
        End If
    End Sub

    Private Sub BtnGetChanges_Click(sender As Object, e As EventArgs)
        If _DataSet IsNot Nothing Then
            Dim table As DataTable = _DataSet.Tables("Tarif").GetChanges()

            If table IsNot Nothing Then
                Dim deletedCount As Integer = 0

                Dim sb As New StringBuilder()

                For i As Integer = 0 To table.Rows.Count - 1
                    Dim row As DataRow = table.Rows(i)

                    If row.RowState <> DataRowState.Deleted Then
                        sb.Append(row.RowState.ToString() & vbTab & "[")

                        For Each o As Object In row.ItemArray
                            sb.Append(o.ToString())
                            sb.Append(", ")
                        Next

                        sb.Length -= 2

                        sb.Append("]")
                        sb.AppendLine()
                    Else
                        deletedCount += 1
                    End If
                Next

                If deletedCount > 0 Then
                    sb.Append(vbLf & deletedCount & " Row(s) Deleted")
                End If

                MessageBox.Show(sb.ToString())
            Else
                MessageBox.Show("No changes.")
            End If
        End If
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
                Current = New Tarif
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
#Region "GetNewDataRow"

    Private Function GetNewDataRow(ByVal dataTable As DataTable) As DataRow
        Dim row As DataRow = dataTable.NewRow()

        Dim emp As Tarif '= Employee.GetNewEmployee()
        row(0) = emp.Code
        row(1) = emp.Collaborateur
        row(2) = emp.DateIN
        row(3) = emp.Price

        Return (row)
    End Function

#End Region

#Region "GetTableRowIndex"

    Private Function GetTableRowIndex(ByVal table As DataTable) As Integer
        Dim index As Integer = Bm.Position

        Dim drv As DataRowView = DirectCast(Bm.Current, DataRowView)

        If drv IsNot Nothing Then
            index = table.Rows.IndexOf(drv.Row)
        End If

        Return (index)
    End Function
    Dim SmallLog As New StringBuilder
    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        SmallLog = New StringBuilder
        For Each Element As Tarif In SGC.PrimaryGrid.DataSource
            Dim Search As Tarif = Nothing
            Search = Tarif.SearchByID(Element.ID)(0)

            If Not IsNothing(Search) Then
                SmallLog.Append("Element (" & Search.ID & ") -> Found")

                'The element has been found
                Dim Modify As Boolean = False
                If Search.Code <> Element.Code Then
                    Modify = True
                    SmallLog.Append("Modification needed Code is different. Old[" & Search.Code & "] <> New[" & Element.Code & "].")

                End If
                If Search.Collaborateur <> Element.Collaborateur Then
                    Modify = True
                    SmallLog.Append("Modification needed Collaborateur is different. Old[" & Search.Collaborateur & "] <> New[" & Element.Collaborateur & "].")

                End If
                If Search.DateIN <> Element.DateIN Then
                    Modify = True
                    SmallLog.Append("Modification needed DateIN is different. Old[" & Search.DateIN & "] <> New[" & Element.DateIN & "].")

                End If
                If Search.Price <> Element.Price Then
                    Modify = True
                    SmallLog.Append("Modification needed Price is different. Old[" & Search.Price & "] <> New[" & Element.Price & "].")

                End If
                If Modify = True Then
                    Search.Save()
                    SmallLog.Append("Element (" & Search.ID & ") has been modified.")
                Else
                    SmallLog.Append("Element (" & Search.ID & ")")

                End If

            Else
                'The element does not exist so it must be added

                Element.Add()
                SmallLog.Append("Element Added (" & Element.ID & ")")
                SmallLog.Append("Element.Code = (" & Element.Code & ")")
                SmallLog.Append("Element.Collaborateur = (" & Element.Collaborateur & ")")
                SmallLog.Append("Element.DateIN = (" & Element.DateIN & ")")
                SmallLog.Append("Element.Price = (" & Element.Price & ")")

            End If
        Next
        Dim M As New DevComponents.DotNetBar.Office2007Form
        Dim R As New DevComponents.DotNetBar.Controls.RichTextBoxEx

        R.Text = SmallLog.ToString
        R.Dock = DockStyle.Fill
        M.Controls.Add(R)
        M.Show()
    End Sub
    Dim AddNew As Boolean = False
    Dim IsReady As Boolean = False
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Input_Code.Text = ""
        Input_Collaborateur.Text = ""
        Input_DateIn.Text = ""
        Input_Price.Text = ""
        Current = New Tarif
        AddNew = True
        IsReady = False
        Timer1.Start()
    End Sub

    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click
        Timer1.Stop()
        Btn_Add.Enabled = False
        ButtonX1.Enabled = True
        ButtonX2.Enabled = True
        MsgBox(_Bm.Count + 1)

        Try
            Current = New Tarif(_Bm.Count + 1,
                                                 Input_Code.Text,
                                                 Input_Collaborateur.Text,
                                                 Input_DateIn.Value,
                                                 Input_Price.Value)

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
        Btn_Add.Enabled = False
        If Input_Code.Text <> "" Then
            If Input_Collaborateur.Text <> "" Then
                If Input_DateIn.Text <> "" Then
                    If Input_Price.Text <> "" Then
                        Btn_Add.Enabled = True
                    Else
                        Btn_Add.Enabled = False

                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        With Current
            .ID = Bm.Position + 1
            .Code = Input_Code.Text
            .Collaborateur = Input_Collaborateur.Text
            .DateIN = Input_DateIn.Value
            .Price = Input_Price.Value
        End With
        Current.Save()
        ButtonX4.PerformClick()
        AddNew = False
    End Sub

    Private Sub Input_Code_TextChanged(sender As Object, e As EventArgs) Handles Input_Code.TextChanged
        Current.Code = Input_Code.Text
        PropCurrent.RefreshPropertyValues()
    End Sub

    Private Sub Input_Collaborateur_TextChanged(sender As Object, e As EventArgs) Handles Input_Collaborateur.TextChanged
        Current.Collaborateur = Input_Collaborateur.Text
        PropCurrent.RefreshPropertyValues()
    End Sub



    Private Sub Input_Price_ValueChanged(sender As Object, e As EventArgs) Handles Input_Price.ValueChanged
        Current.Price = Input_Price.Value
        PropCurrent.RefreshPropertyValues()

    End Sub

    Private Sub Input_DateIn_ValueChanged(sender As Object, e As EventArgs) Handles Input_DateIn.ValueChanged
        Current.DateIN = Input_DateIn.Value
        PropCurrent.RefreshPropertyValues()

    End Sub

    Private Sub BW_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW.DoWork
        RefreshData()

    End Sub

    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles ButtonX3.Click
        ' Current.ID = Bm.Position + 1
        Current.Delete()
        ButtonX4.PerformClick()

    End Sub

    Private Sub ButtonX4_Click(sender As Object, e As EventArgs) Handles ButtonX4.Click
        RefreshData()
    End Sub

#End Region
End Class
