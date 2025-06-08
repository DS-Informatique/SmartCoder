Imports System.Threading
Imports DevComponents.DotNetBar.SuperGrid

Public Class ServiceViewer
#Region "[Code]"
#Region "|1| [Property]{2}"
#Region "|01.00| <Property> [Current|Services]"
    Private _Current As Services
    Public Property Current() As Services
        Get
            Return _Current
        End Get
        Set(ByVal value As Services)
            _Current = value
            If Not IsNothing(value) Then
                Input_Service.Text = value.Service
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
        If IsNothing(List_Services) Then
            List_Services = New List(Of Services)
            Current_Services = New Services
            Current_Services.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password))
            List_Services = Current_Services.List
        Else
            If List_Services.Count - 1 < 1 Then
                Current_Services.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password))
                List_Services = Current_Services.List
            End If
        End If
        InitializeGrid()
        Dim dataSource As Object = Nothing
        Dim dataMember As String = Nothing
        Dim context As Object = Nothing
        dataSource = List_Services
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
                Current = New Services
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
            Current = List_Services(_Bm.Count)
        ElseIf _Bm.Position < 0 Then
            Current = List_Services(0)
        Else
            Current = List_Services(_Bm.Position)
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

                Vcr1.Label.Text = "First of " & _Bm.Count & " records " & "|" & Current.Service & "|"
            ElseIf _Bm.Position = _Bm.Count - 1 Then
                Vcr1.LastButton.Enabled = False
                Vcr1.NextButton.Enabled = False

                Vcr1.FirstButton.Enabled = InlineAssignHelper(Vcr1.PreviousButton.Enabled, (_Bm.Count > 1))

                Vcr1.Label.Text = "Last of " & _Bm.Count & " records" & "|" & Current.Service & "|"
            Else
                Vcr1.FirstButton.Enabled = True
                Vcr1.PreviousButton.Enabled = True
                Vcr1.NextButton.Enabled = True
                Vcr1.LastButton.Enabled = True

                Vcr1.Label.Text = "Record " & (_Bm.Position + 1) & " of " & _Bm.Count & " " & "|" & Current.Service & "|"
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
#Region "|05.01| <Function> [RefreshServices|Boolean]"
    Public Function RefreshServices() As Boolean
        Dim Result As Boolean = False
        Dim LServices As New List(Of Services)
        LServices = Current.List
        Dim Msg As String = ""
        If Input_Service.Text = "" Then
            Msg += "La ligne est vide" & vbNewLine
        Else
            Dim Isvalid As Boolean = True
            Dim CRef As String = ""

        End If
        If Msg.Length > 0 Then
            Result = False
        Else
            Result = True
        End If
        Return Result
        Log += Msg
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
#Region "|7| [Loader]{1}"
#Region "|07.00| <Loader> [Load]"
    Private Sub CollaborateurViewer_Load(sender As Object, e As EventArgs) Handles Me.Load
        CheckForIllegalCrossThreadCalls = False
        RefreshData()
    End Sub
#End Region
#End Region
#Region "|10| [Event]{13}"
#Region "|10.00| <Event> [ButtonX1_Click]"
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Current = New Services
        AddNew = True
        IsReady = False
        Btn_Add.Enabled = True
        ButtonX1.Enabled = False
        ButtonX2.Enabled = False

    End Sub
#End Region
#Region "|10.01| <Event> [Btn_Add_Click]"
    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click
        Btn_Add.Enabled = False
        ButtonX1.Enabled = True
        ButtonX2.Enabled = True
        Try
            Current = New Services(Input_Service.Text)

            Current.Add()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        List_Services = Current.List
        Try
            Current = List_Services(0)

        Catch ex As Exception

        End Try
        InitializeGrid()
        RefreshData()
        AddNew = False

    End Sub
#End Region

#Region "|10.03| <Event> [ButtonX2_Click]"
    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        RefreshServices()
        Current.Save()
        ButtonX4.RaiseClick()
        AddNew = False
        SmartCoder.Jarvis.Speak("Element saved")
    End Sub
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

    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles ButtonX3.Click
        ' Timer1.Stop()

        If AddNew = True Then
            AddNew = False
            Btn_Add.Enabled = False
            ButtonX1.Enabled = True
            ButtonX2.Enabled = True
            'Current = New TimeSheet
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
#End Region


#End Region
#End Region
End Class
