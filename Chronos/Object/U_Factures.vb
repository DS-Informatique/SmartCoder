Imports System.Threading
Imports DevComponents.DotNetBar.SuperGrid

Public Class U_Factures

#Region "|1| [Property]{2}"
#Region "|01.00| <Property> [Current|Factures]"
    Private _Current As Factures
    Public Property Current() As Factures
        Get
            Return _Current
        End Get
        Set(ByVal value As Factures)
            _Current = value
            If Not IsNothing(value) Then
                With value
                    Active_Client.Text = value.Client
                    Active_Code.Text = value.Code
                    Active_Concerne.Text = value.Concerne
                    Active_DateEnvoi.Value = value.DateEnvoi
                    Active_FactureRéférence.Text = "Facture N° : " & Mid(value.DateEnvoi.Year, 3) & "-" & value.N & "/" & value.Client & "/ du " & value.PériodeIN.ToShortDateString & " au " & value.PériodeFIN.ToShortDateString
                    Active_Libellé.Text = value.Libellé
                    Active_N.Value = value.N
                    Active_PeriodeFIN.Value = value.PériodeFIN
                    Active_PériodeIN.Value = value.PériodeIN
                    Active_Quantité.Value = value.Quantité
                    Active_Société.Text = value.Emise_Par
                    Active_Frais.Value = value.TotalFrais
                    Active_Prestation.Value = value.TotalHTVA - value.TotalFrais
                    Active_TotalBrut.Value = value.TotalHTVA
                    Active_TVA.Value = value.TotalTVA
                    Active_Total.Value = value.Total
                    FactureEntriesViewer1.Input_Facture.Text = value.Code
                    FactureEntriesViewer1.ButtonX1.PerformClick()
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
        List = New List(Of Factures)
        Dim I As New Factures
        I.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password))
        List = I.List

        '  For Each F As Factures In List
        '  F.GetMyEntries()
        ' Next
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
        Btn_Calculate.PerformClick()

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
                Current = New Factures
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

                Vcr1.Label.Text = "First of " & _Bm.Count & " records " & "|" & Current.Code & "|" & Current.Client
            ElseIf _Bm.Position = _Bm.Count - 1 Then
                Vcr1.LastButton.Enabled = False
                Vcr1.NextButton.Enabled = False

                Vcr1.FirstButton.Enabled = InlineAssignHelper(Vcr1.PreviousButton.Enabled, (_Bm.Count > 1))

                Vcr1.Label.Text = "Last of " & _Bm.Count & " records" & "|" & Current.Code & "|" & Current.Client
            Else
                Vcr1.FirstButton.Enabled = True
                Vcr1.PreviousButton.Enabled = True
                Vcr1.NextButton.Enabled = True
                Vcr1.LastButton.Enabled = True

                Vcr1.Label.Text = "Record " & (_Bm.Position + 1) & " of " & _Bm.Count & " " & "|" & Current.Code & "|" & Current.Client
            End If
        End If
    End Sub
#End Region
#End Region
#Region "|5| [Function]{2}"
#Region "|05.00| <Function> [RefreshFacture|Boolean]"
    Public Function RefreshFacture() As Boolean
        Dim Result As Boolean = False
        Dim LFacture As New List(Of Factures)
        Dim X As New Factures
        LFacture = X.List
        Dim Msg As String = ""
        If Active_Code.Text = "" Then
            Msg += "Le numéro de référence [Code] est vide." & vbNewLine
        Else

        End If
        If Active_Client.Text.Length > 1 Then
            Current.Client = Active_Client.Text
        Else
            Msg += "Aucun clients sélectionné." & vbNewLine
        End If
        With Current
            Current_Client = Clients.SearchByName(Active_Client.Text)(0)
            .Adresse = ""
            If Current_Client.RaisonSociale.Length < 1 Then
            Else
                .Adresse += Current_Client.RaisonSociale & vbNewLine
            End If
            If Current_Client.NomClient.Length < 1 Then
            Else
                .Adresse += Current_Client.NomClient & vbNewLine
            End If
            .Adresse += Current_Client.Address1 & vbNewLine
            If Current_Client.Address2.Length > 1 Then
                .Adresse += Current_Client.Address2 & vbNewLine
            End If
            .Adresse += Current_Client.PostalCode & " " & Current_Client.Region & vbNewLine
            .Adresse += Current_Client.City & " " & Current_Client.Country
            .Année = Year(Active_DateEnvoi.Value)
            .Client = Current_Client.Ref
            .Code = Active_Code.Text
            .Concerne = Active_Concerne.Text
            .DateEnvoi = Active_DateEnvoi.Value
            .Emise_Par = Active_Société.Text
            .Libellé = Active_Libellé.Text
            .Mois = Month(Active_DateEnvoi.Value)
            .N = Active_N.Value
            .PériodeFIN = Active_PeriodeFIN.Value
            .PériodeIN = Active_PériodeIN.Value
            .Quantité = Active_Quantité.Value
            .Total = Active_Total.Value
            .TotalFrais = Active_Frais.Value
            .TotalHTVA = Active_TotalBrut.Value
            .TotalTVA = Active_TVA.Value

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
#Region "|06.00| <Runtime> [List|List(Of Factures)]"
    Dim List As New List(Of Factures)
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
        Bar3.Text = "Facture Active"
        If IsNothing(List_Sociétés) Then
            List_Sociétés = New List(Of Sociétés)
        End If
        If List_Sociétés.Count - 1 < 1 Then
            If IsNothing(Current_Société) Then
                Current_Société = New Sociétés
                Current_Société.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password))
            End If
            List_Sociétés = Current_Société.List
        End If
        Output_Société.DataSource = List_Sociétés

        If IsNothing(List_Clients_Active) Then
            List_Clients_Active = New List(Of Clients)
        End If
        If List_Clients_Active.Count - 1 < 1 Then
            If IsNothing(Current_Client) Then
                Current_Client = New Clients
                Current_Client.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password))
            End If
            For Each Client As Clients In Current_Client.List
                If Client.Active = True Then
                    List_Clients_Active.Add(Client)
                End If
            Next
        End If
        Output_Client.DataSource = List_Clients_Active
        Output_PeriodeIN.Value = New DateTime(Now.Year, Now.Month, 1)
        Output_PeriodeFIN.Value = New DateTime(Year(Output_PeriodeIN.Value), Month(Output_PeriodeIN.Value), Date.DaysInMonth(Year(Output_PeriodeIN.Value), Month(Output_PeriodeIN.Value)))
        RefreshData()
    End Sub
#End Region
#End Region
#Region "|10| [Event]{10}"
#Region "|10.00| <Event> [Btn_Verify_Click]"

#End Region
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
        'Btn_Verify.PerformClick()
        Btn_Add.Enabled = True

        Current = New Factures
        AddNew = True
        IsReady = False
        'Timer1.Start()
    End Sub
#End Region
#Region "|10.07| <Event> [Btn_Add_Click]"
    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click
        ' Timer1.Stop()
        Btn_Add.Enabled = False
        ButtonX1.Enabled = True
        ButtonX2.Enabled = True

        Try
            Current = New Factures(Active_Code.Text,
                                   Active_Société.Text,
                                   Year(Active_DateEnvoi.Value),
                                   Month(Active_DateEnvoi.Value),
                                   Active_N.Value,
                                   Active_Client.Text,
                                   Current.Adresse,
                                   Active_DateEnvoi.Value,
                                   Active_PériodeIN.Value,
                                   Active_PeriodeFIN.Value,
                                   Active_Concerne.Text,
                                   Active_Quantité.Value,
                                   Active_TotalBrut.Value,
                                   Active_Frais.Value,
                                   Active_TVA.Value,
                                   Active_Total.Value,
                                   Active_Libellé.Text)

            Current.Add()
            SmartCoder.Jarvis.Speak("Invoice created successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        List = Current.List
        Try
            Current = List(0)

        Catch ex As Exception

        End Try
        InitializeGrid()
        RefreshData()
        AddNew = False

    End Sub
#End Region
    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles ButtonX3.Click
        '  Timer1.Stop()

        If AddNew = True Then
            AddNew = False
            Btn_Add.Enabled = False
            ButtonX1.Enabled = True
            ButtonX2.Enabled = True
        Else
            If Not IsNothing(Current) Then
                Try
                    Current.Delete()
                    SmartCoder.Jarvis.Speak("Element deleted.")
                Catch ex As Exception

                    SmartCoder.Jarvis.Speak("Probleme while deleting the element.")
                End Try
            End If
        End If
    End Sub
#Region "|10.08| <Event> [Timer1_Tick]"

#End Region
#Region "|10.09| <Event> [ButtonX2_Click]"
    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        RefreshFacture()
        Current.Save()
        ButtonX4.RaiseClick()
        AddNew = False
        SmartCoder.Jarvis.Speak("Element saved")
    End Sub

    Private Sub Btn_SendToExcel_Click(sender As Object, e As EventArgs) Handles Btn_SendToExcel.Click
        Dim Msg As String = Nothing
        Try
            SmartCoder.ExcelDocument.Export_DataTable(SGC, "Factures.xlsx", Msg) 'My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\

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

    Private Sub FactureEntriesViewer1_Load(sender As Object, e As EventArgs) Handles FactureEntriesViewer1.Load

    End Sub

    Private Sub Btn_Refresh_Prestations_Click(sender As Object, e As EventArgs) Handles Btn_Refresh_Prestations.Click
        Try
            If Active_Code.Text = "" Then
                Active_Code.Text = Active_Société.Text & "_" & Year(Active_DateEnvoi.Value) & "_" & Month(Active_DateEnvoi.Value) & "_" & Active_N.Value & "_" & Active_Client.Text
            End If
            FactureEntriesViewer1.Input_Facture.Text = Active_Code.Text
            FactureEntriesViewer1.ButtonX1.PerformClick()

            If IsNothing(Current_TimeSheet) Then
                Current_TimeSheet = New TimeSheet
                Current_TimeSheet.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password))
            End If
            SGC_Prestations.PrimaryGrid.DataSource = Current_TimeSheet.List(Active_PériodeIN.Value, Active_PeriodeFIN.Value, Active_Client.Text)
        Catch ex As Exception

        End Try



    End Sub

    Private Sub Btn_Calculate_Prestation_Click(sender As Object, e As EventArgs) Handles Btn_Calculate_Prestation.Click
        Prest_Quantity_Frais.Text = 0
        Prest_Quantity_Prestation.Text = 0
        Prest_Total.Value = 0
        Prest_TotalFrais.Value = 0
        Prest_TotalBrut.Value = 0
        Prest_Total_Prestation.Value = 0
        Prest_TotalTVA.Value = 0
        Dim QD_Frais As Double = 0
        Dim QD_Prest As Double = 0
        For Each row As DevComponents.DotNetBar.SuperGrid.GridRow In SGC_Prestations.PrimaryGrid.Rows
            If row.Item(2).Value = True Then
                If row.Item(4).Value = "@FRAIS" Then
                    QD_Frais += row.Item(6).Value
                    Prest_TotalFrais.Value += row.Item(10).Value
                    Prest_TotalBrut.Value += row.Item(10).Value
                Else
                    QD_Prest += row.Item(6).Value
                    Prest_Total_Prestation.Value += row.Item(10).Value
                    Prest_TotalBrut.Value += row.Item(10).Value
                End If
            End If
        Next

    End Sub

    Private Sub Prest_TotalBrut_ValueChanged(sender As Object, e As EventArgs) Handles Prest_TotalBrut.ValueChanged
        Prest_TotalTVA.Value = Math.Round(Prest_TotalBrut.Value * My.Settings.TVA, 2)
        Prest_Total.Value = Math.Round(Prest_TotalBrut.Value + Prest_TotalTVA.Value, 2)

    End Sub
    Public ListofFacturesEntries As New List(Of Factures_Entries)
    Private Sub Btn_Add_Prestations_Click(sender As Object, e As EventArgs) Handles Btn_Add_Prestations.Click
        Output_Quantity.Text = 0
        Output_Total.Value = 0
        Output_Total_Frais.Value = 0
        Output_Total_HTVA.Value = 0
        Output_Total_Prestation.Value = 0
        Output_Total_TVA.Value = 0
        Dim QD_Frais As Double = 0
        Dim QD_Prest As Double = 0
        ListofFacturesEntries = New List(Of Factures_Entries)
        For Each row As DevComponents.DotNetBar.SuperGrid.GridRow In SGC_Prestations.PrimaryGrid.Rows
            If row.Item(2).Value = True Then
                If row.Item(4).Value = "@FRAIS" Then
                    QD_Frais += row.Item(6).Value
                    Output_Total_Frais.Value += row.Item(10).Value
                    Output_Total_HTVA.Value += row.Item(10).Value
                Else
                    QD_Prest += row.Item(6).Value
                    Output_Total_Prestation.Value += row.Item(10).Value
                    Output_Total_HTVA.Value += row.Item(10).Value
                End If
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

                Dim FE As New Factures_Entries(List_Factures_Entries.Count,
                                               Active_Code.Text,
                                               True,
                                               row.Item(3).Value,
                                               row.Item(4).Value,
                                               row.Item(5).Value,
                                               row.Item(7).Value,
                                               row.Item(8).Value,
                                               row.Item(9).Value,
                                               row.Item(10).Value,
                                               row.Item(6).Value)

                FE.Add()
                ListofFacturesEntries.Add(FE)
            End If
        Next
        SmartCoder.Jarvis.Speak("Invoice Ready to be Saved!")
    End Sub

    Private Sub Cmd_Print_Details_Executed(sender As Object, e As EventArgs) Handles Cmd_Print_Details.Executed
        If IsNothing(Current) Then

            Current = New Factures(Active_Code.Text,
                                      Active_Société.Text,
                                      Year(Active_DateEnvoi.Value),
                                      Month(Active_DateEnvoi.Value),
                                      Active_N.Value,
                                      Active_Client.Text,
                                      Current.Adresse,
                                      Active_DateEnvoi.Value,
                                      Active_PériodeIN.Value,
                                      Active_PeriodeFIN.Value,
                                      Active_Concerne.Text,
                                      Active_Quantité.Value,
                                      Active_TotalBrut.Value,
                                      Active_Frais.Value,
                                      Active_TVA.Value,
                                      Active_Total.Value,
                                      Active_Libellé.Text)
        End If
        Current.Print_InvoiceDetails()
    End Sub

    Private Sub Cmd_Print_Invoice_Executed(sender As Object, e As EventArgs) Handles Cmd_Print_Invoice.Executed
        If IsNothing(Current) Then

            Current = New Factures(Active_Code.Text,
                                      Active_Société.Text,
                                      Year(Active_DateEnvoi.Value),
                                      Month(Active_DateEnvoi.Value),
                                      Active_N.Value,
                                      Active_Client.Text,
                                      Current.Adresse,
                                      Active_DateEnvoi.Value,
                                      Active_PériodeIN.Value,
                                      Active_PeriodeFIN.Value,
                                      Active_Concerne.Text,
                                      Active_Quantité.Value,
                                      Active_TotalBrut.Value,
                                      Active_Frais.Value,
                                      Active_TVA.Value,
                                      Active_Total.Value,
                                      Active_Libellé.Text)
        End If
        Current.Create_Invoice()
    End Sub
    Dim TemList As New List(Of Factures)

    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        'If BW_Search.IsBusy Then
        'Else
        ' BW_Search.RunWorkerAsync()
        ' End If
        If IsNothing(List_Factures) Then
            List_Factures = New List(Of Factures)
        End If
        If List_Factures.Count - 1 < 1 Then
            If IsNothing(Current_Factures) Then
                Current_Factures = New Factures
            End If
            Current_Factures.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password))
            List_Factures = Current_Factures.List()
        End If
        Current = Current_Factures


        If IsNothing(List_Factures_Entries) Then
            List_Factures_Entries = New List(Of Factures_Entries)
        End If
        If List_Factures_Entries.Count - 1 < 1 Then
            If IsNothing(Current_Factures_Entries) Then
                Current_Factures_Entries = New Factures_Entries
            End If
            Current_Factures_Entries.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password))
            List_Factures_Entries = Current_Factures_Entries.List()
        End If

        Output_Quantity.Text = 0
        Output_Total.Value = 0
        Output_Total_Frais.Value = 0
        Output_Total_HTVA.Value = 0
        Output_Total_Prestation.Value = 0
        Output_Total_TVA.Value = 0
        Dim QD As Double = 0
        For Each F As Factures In Current_Factures.List
            If F.Client = Output_Client.Text Then
                If F.PériodeIN >= Output_PeriodeIN.Value And F.PériodeIN <= Output_PeriodeFIN.Value Then
                    With F
                        QD += F.Quantité
                        Output_Total_Frais.Value += F.TotalFrais
                        Output_Total_HTVA.Value += F.TotalHTVA
                        Output_Total_Prestation.Value += (F.TotalHTVA - F.TotalFrais)
                        Output_Total.Text = Math.Round(QD, 2)
                    End With
                    F.Prestations = New List(Of Factures_Entries)
                    F.GetMyEntries()
                    TemList.Add(F)
                End If
            End If
        Next

        Output_Total_TVA.Value = Math.Round(Output_Total_HTVA.Value * My.Settings.TVA, 2)
        Output_Total.Value = Math.Round(Output_Total_HTVA.Value + Output_Total_TVA.Value, 2)
        InitializeGrid()
        Dim dataSource As Object = Nothing
        Dim dataMember As String = Nothing
        Dim context As Object = Nothing
        dataSource = TemList
        context = dataSource
        ' Set the SuperGrid DataSource and DataMember, and
        ' set our BindingManager for later data traversal
        SGC.PrimaryGrid.DataSource = dataSource
        SGC.PrimaryGrid.DataMember = dataMember
        If dataSource Is Nothing Then Bm = Nothing Else Bm = SGC.BindingContext(context)
    End Sub

    Private Sub Output_PeriodeIN_ValueChanged(sender As Object, e As EventArgs) Handles Output_PeriodeIN.ValueChanged, Output_PeriodeIN.TextChanged
        If IsNothing(Output_PeriodeIN.Value) Then
            Output_PeriodeFIN.Value = New DateTime(Year(Output_PeriodeIN.Value), Month(Output_PeriodeIN.Value), Date.DaysInMonth(Year(Output_PeriodeIN.Value), Month(Output_PeriodeIN.Value)))
        End If

    End Sub

    Private Sub Btn_Calculate_Click(sender As Object, e As EventArgs) Handles Btn_Calculate.Click
        Output_Quantity.Text = 0
        Output_Total.Value = 0
        Output_Total_Frais.Value = 0
        Output_Total_HTVA.Value = 0
        Output_Total_Prestation.Value = 0
        Output_Total_TVA.Value = 0
        Dim QD As Double = 0
        For Each Row As DevComponents.DotNetBar.SuperGrid.GridRow In SGC.PrimaryGrid.Rows
            If Row.Visible = True Then

                QD += Row.Item(11).Value
                Output_Total_Frais.Value += Row.Item(13).Value
                Output_Total_HTVA.Value += Row.Item(12).Value
                Output_Total_Prestation.Value += (Row.Item(12).Value - Row.Item(13).Value)
                Output_Total.Text = Math.Round(QD, 2)
            End If
        Next



        '   For Each F As Factures In Current_Factures.List
        '   If F.Client = Output_Client.Text Then
        '   If F.DateEnvoi >= Output_PeriodeIN.Value And F.DateEnvoi <= Output_PeriodeFIN.Value Then
        '   With F
        '   QD += F.Quantité
        '   Output_Total_Frais.Value += F.TotalFrais
        '   Output_Total_HTVA.Value += F.TotalHTVA
        '                   Output_Total_Prestation.Value += (F.TotalHTVA - F.TotalFrais)
        '   Output_Total.Text = Math.Round(QD, 2)
        '    End With
        '   F.Prestations = New List(Of Factures_Entries)
        '  F.GetMyEntries()
        ' TemList.Add(F)
        'End If
        'End If
        'Next
        Output_Quantity.Text = Math.Round(QD, 2)
        Output_Total_TVA.Value = Math.Round(Output_Total_HTVA.Value * My.Settings.TVA, 2)
        Output_Total.Value = Math.Round(Output_Total_HTVA.Value + Output_Total_TVA.Value, 2)
        'SGC.PrimaryGrid.DataSource = TemList
    End Sub

    Private Sub BW_Search_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW_Search.DoWork

    End Sub

    Private Sub ButtonX4_Click(sender As Object, e As EventArgs) Handles ButtonX4.Click
        Output_Quantity.Text = 0
        Output_Total.Value = 0
        Output_Total_Frais.Value = 0
        Output_Total_HTVA.Value = 0
        Output_Total_Prestation.Value = 0
        Output_Total_TVA.Value = 0
        Dim QD As Double = 0




        For Each F As Factures In Current_Factures.List
            If F.Client = Output_Client.Text Then
                If F.DateEnvoi >= Output_PeriodeIN.Value And F.DateEnvoi <= Output_PeriodeFIN.Value Then
                    With F
                        QD += F.Quantité
                        Output_Total_Frais.Value += F.TotalFrais
                        Output_Total_HTVA.Value += F.TotalHTVA
                        Output_Total_Prestation.Value += (F.TotalHTVA - F.TotalFrais)
                        Output_Total.Text = Math.Round(QD, 2)
                    End With
                    F.Prestations = New List(Of Factures_Entries)
                    F.GetMyEntries()
                    TemList.Add(F)
                End If
            End If
        Next

        Output_Total_TVA.Value = Math.Round(Output_Total_HTVA.Value * My.Settings.TVA, 2)
        Output_Total.Value = Math.Round(Output_Total_HTVA.Value + Output_Total_TVA.Value, 2)
        SGC.PrimaryGrid.DataSource = TemList
    End Sub

    Private Sub SGC_RowLoaded(sender As Object, e As GridRowLoadedEventArgs) Handles SGC.RowLoaded
    End Sub

    Private Sub SGC_PrimaryGrid_PropertyChanged(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles SGC.PrimaryGrid.PropertyChanged
        Btn_Calculate.PerformClick()

    End Sub


#End Region
#End Region



End Class
