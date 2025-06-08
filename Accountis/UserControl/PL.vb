Imports System.Threading
Imports DevComponents.DotNetBar.SuperGrid

Public Class PL

    Private _Current As Tbl_Plan_Comptable
    Public Property Current() As Tbl_Plan_Comptable
        Get
            Return _Current
        End Get
        Set(ByVal value As Tbl_Plan_Comptable)
            _Current = value
            If Not IsNothing(value) Then
                With Me
                    .Input_N.Value = value.N
                    .Input_Négatif.Text = value.Group_Negatif
                    .Input_Positif.Text = value.Group_Positif
                    .Input_Title.Text = value.Français
                    .Input_Opening.Value = value.Opening
                    .Input_Debit.Value = value.Debit
                    .Input_Credit.Value = value.Credit
                    .Input_Balance.Value = value.Balance
                    .Input_Closing.Value = value.Closing
                End With
            End If
        End Set
    End Property
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

    Private Sub PL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IsNothing(Active_Compta) Then
            Active_Compta = New Comptabilité
        End If
        If IsNothing(Active_Compta.List_Currency) Then
            Active_Compta.List_Currency = New List(Of Tbl_CurrencyRatio)
        End If
        If Active_Compta.List_Currency.Count - 1 < 1 Then
            If IsNothing(Active_Compta.Currency) Then
                Active_Compta.Currency = New Tbl_CurrencyRatio
            End If
            Active_Compta.List_Currency = Active_Compta.Currency.List()
        End If
        Input_Currency.DataSource = Active_Compta.List_Currency

        If IsNothing(Active_Compta.List_Regroupement) Then
            Active_Compta.List_Regroupement = New List(Of Tbl_CodeRegroupement)
        End If
        If Active_Compta.List_Regroupement.Count - 1 < 1 Then
            If IsNothing(Active_Compta.RegroupmentAccount) Then
                Active_Compta.RegroupmentAccount = New Tbl_CodeRegroupement
            End If
            Active_Compta.List_Regroupement = Active_Compta.RegroupmentAccount.List
        End If
        Dim L2 As New List(Of Tbl_CodeRegroupement)
        L2 = Active_Compta.RegroupmentAccount.List
        Input_Négatif.DataSource = Active_Compta.List_Regroupement
        Input_Positif.DataSource = L2

        If IsNothing(Active_Compta.List_PlanComptable) Then
            Active_Compta.List_PlanComptable = New List(Of Tbl_Plan_Comptable)
        End If
        If Active_Compta.List_PlanComptable.Count - 1 < 1 Then
            If IsNothing(Active_Compta.PlanComptable) Then
                Active_Compta.PlanComptable = New Tbl_Plan_Comptable
            End If
            Active_Compta.List_PlanComptable = Active_Compta.PlanComptable.List
        End If



        InitializeGrid()
        Dim dataSource As Object = Nothing
        Dim dataMember As String = Nothing
        Dim context As Object = Nothing
        dataSource = Active_Compta.List_PlanComptable
        context = dataSource
        ' Set the SuperGrid DataSource and DataMember, and
        ' set our BindingManager for later data traversal
        SGC.PrimaryGrid.DataSource = dataSource
        SGC.PrimaryGrid.DataMember = dataMember
        If dataSource Is Nothing Then Bm = Nothing Else Bm = SGC.BindingContext(context)
    End Sub
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
    Private _LoadThread As Thread
    Dim table As New DataTable

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
                Current = New Tbl_Plan_Comptable
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
#End Region
#Region "|04.04| <Sub> [UpdateVcr]"
    ''' <summary>
    ''' Updates our VCR states
    ''' </summary>
    Private Sub UpdateVcr()
        If Not IsNothing(Active_Compta) Then
            If Not IsNothing(Active_Compta.List_PlanComptable) Then
                If _Bm.Position > _Bm.Count Then
                    Current = Active_Compta.List_PlanComptable(_Bm.Count)
                ElseIf _Bm.Position < 0 Then
                    Current = Active_Compta.List_PlanComptable(0)
                Else
                    Current = Active_Compta.List_PlanComptable(_Bm.Position)
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

                        Vcr1.Label.Text = "First of " & _Bm.Count & " records " & "|" & Current.N & "|" & Current.Français & " " & Current.Closing
                    ElseIf _Bm.Position = _Bm.Count - 1 Then
                        Vcr1.LastButton.Enabled = False
                        Vcr1.NextButton.Enabled = False

                        Vcr1.FirstButton.Enabled = InlineAssignHelper(Vcr1.PreviousButton.Enabled, (_Bm.Count > 1))

                        Vcr1.Label.Text = "Last of " & _Bm.Count & " records" & "|" & Current.N & "|" & Current.Français & " " & Current.Closing
                    Else
                        Vcr1.FirstButton.Enabled = True
                        Vcr1.PreviousButton.Enabled = True
                        Vcr1.NextButton.Enabled = True
                        Vcr1.LastButton.Enabled = True

                        Vcr1.Label.Text = "Record " & (_Bm.Position + 1) & " of " & _Bm.Count & " " & "|" & Current.N & "|" & Current.Français & " " & Current.Closing
                    End If
                End If
            End If
        End If

    End Sub
#End Region
#Region "|05.00| <Function> [InlineAssignHelper]"
    Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, ByVal value As T) As T
        target = value
        Return value
    End Function
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

End Class
