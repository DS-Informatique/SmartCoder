Imports System.Threading
Imports DevComponents.DotNetBar.SuperGrid

Public Class ClientViewer
#Region "|1| [Property]{2}"
#Region "|01.00| <Property> [Current|Client]"
    Private _Current As Clients
    Public Property Current() As Clients
        Get
            Return _Current
        End Get
        Set(ByVal value As Clients)
            _Current = value
            If Not IsNothing(value) Then
                With value
                    Active.Value = .Active
                    Address1.Text = .Address1
                    Address2.Text = .Address2
                    Cell.Text = .Cell
                    CHE.Text = .CHE
                    City.Text = .City
                    Country.Text = .Country
                    Email.Text = .Email
                    Fax.Text = .Fax
                    Forfait.Text = .ForfaitValue
                    IDE.Text = .IDE
                    Landline.Text = .Landline
                    NomClient.Text = .NomClient
                    Other.Text = .Other
                    Pcompta.Text = .Pcompta
                    PostalCode.Text = .PostalCode
                    RaisonSociale.Text = .RaisonSociale
                    Ref.Text = .Ref
                    Region.Text = .Region
                    Répertoire.Text = .Répertoire
                    Website.Text = .Website
                    If .Zefix = "" Then
                        .Zefix = ("http://ge.ch/hrcintapp/externalCompanyReport.action?companyOfrcId13=" & value.CHE & "&ofrcLanguage=2")
                    End If
                    Zefix.Text = .Zefix
                    PrestationViewer1.PrepareInterface(value, New DateTime(Now.Year, Now.Month, 1), New DateTime(Now.Year, Now.Month, System.DateTime.DaysInMonth(Now.Year, Now.Month)))
                    PrestationViewer1.Btn_CalculateTotal.PerformClick()
                    If Not IsNothing(value.IDE) Then
                        If value.IDE.Length > 1 Then

                        End If

                        AWeb1.URL = ("http://ge.ch/hrcintapp/externalCompanyReport.action?companyOfrcId13=" & value.CHE & "&ofrcLanguage=2")

                    End If
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
        List = New List(Of Clients)
        Dim I As New Clients
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
                Current = New Clients
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

                Vcr1.Label.Text = "First of " & _Bm.Count & " records " & "|" & Current.Ref & "|" & IIf(Current.RaisonSociale.Length > 1, Current.RaisonSociale, IIf(Current.NomClient.Length > 1, Current.NomClient, ""))
            ElseIf _Bm.Position = _Bm.Count - 1 Then
                Vcr1.LastButton.Enabled = False
                Vcr1.NextButton.Enabled = False

                Vcr1.FirstButton.Enabled = InlineAssignHelper(Vcr1.PreviousButton.Enabled, (_Bm.Count > 1))

                Vcr1.Label.Text = "Last of " & _Bm.Count & " records" & "|" & Current.Ref & "|" & IIf(Current.RaisonSociale.Length > 1, Current.RaisonSociale, IIf(Current.NomClient.Length > 1, Current.NomClient, ""))
            Else
                Vcr1.FirstButton.Enabled = True
                Vcr1.PreviousButton.Enabled = True
                Vcr1.NextButton.Enabled = True
                Vcr1.LastButton.Enabled = True

                Vcr1.Label.Text = "Record " & (_Bm.Position + 1) & " of " & _Bm.Count & " " & "|" & Current.Ref & "|" & IIf(Current.RaisonSociale.Length > 1, Current.RaisonSociale, IIf(Current.NomClient.Length > 1, Current.NomClient, ""))
            End If
        End If
    End Sub
#End Region
#End Region
#Region "|5| [Function]{2}"
#Region "|05.00| <Function> [RefreshClient|Boolean]"
    Public Function RefreshClient() As Boolean
        Dim Result As Boolean = False
        Dim LClient As New List(Of Clients)
        Dim X As New Clients
        LClient = X.List
        Dim Msg As String = ""
        If Ref.Text = "" Then
            Msg += "Le numéro de référence [Ref] est vide." & vbNewLine
        Else
            Dim Isvalid As Boolean = True
            Dim CRef As String = ""
            For I = 0 To LClient.Count - 1
                If LClient(I).Ref = Ref.Text Then
                    CRef = IIf(LClient(I).RaisonSociale <> "", LClient(I).RaisonSociale, LClient(I).NomClient)
                    Isvalid = False
                    Exit For
                End If
            Next
            If Isvalid = False Then
                Msg += "le numéro de référence est déjà utilisé par " & CRef & "." & vbNewLine
            Else
                Current.Ref = Me.Ref.Text
            End If
        End If
        If RaisonSociale.Text = "" And NomClient.Text = "" Then
            Msg += "Aucun nom de référence trouvé, veuillez entrer une valeur dans [RaisonSociale] ou [NomClient]" & vbNewLine
        Else
            Current.RaisonSociale = RaisonSociale.Text
            Current.NomClient = NomClient.Text
        End If
        If Address1.Text = "" And Address2.Text = "" Then
            Msg += "Veuillez insérer une adresse valide." & vbNewLine
        Else
            Current.Address1 = Address1.Text
            Current.Address2 = Address2.Text
        End If
        If PostalCode.Text = "" Then
            Msg += "Veuillez entrer un numéro de code postale." & vbNewLine
        Else
            Current.PostalCode = PostalCode.Text
        End If
        If Region.Text = "" Then
            Msg += "Veuillez entrer une région." & vbNewLine
        Else
            Current.Region = Region.Text
        End If
        If Country.Text = "" Then
            Msg += "Veuillez entrer un pays." & vbNewLine
        Else
            Current.Country = Country.Text
        End If
        Current.Active = Active.Value
        Current.Cell = Cell.Text
        Current.Email = Email.Text
        Current.Fax = Fax.Text
        Current.Landline = Landline.Text
        Current.Other = Other.Text
        Current.Pcompta = Pcompta.Text
        Current.Website = Website.Text
        Current.CHE = CHE.Text
        Current.IDE = IDE.Text
        Current.Zefix = Zefix.Text
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
#Region "|06.00| <Runtime> [List|List(Of Clients)]"
    Dim List As New List(Of Clients)
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
        RefreshData()
    End Sub
#End Region
#End Region
#Region "|10| [Event]{10}"
#Region "|10.00| <Event> [Btn_Verify_Click]"
    Private Sub Btn_Verify_Click(sender As Object, e As EventArgs) Handles Btn_Verify.Click
        RefreshClient()
    End Sub
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

        Current = New Clients
        AddNew = True
        IsReady = False
        Timer1.Start()
    End Sub
#End Region
#Region "|10.07| <Event> [Btn_Add_Click]"
    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click
        Timer1.Stop()
        Btn_Add.Enabled = False
        ButtonX1.Enabled = True
        ButtonX2.Enabled = True

        Try
            Current = New Clients(Ref.Text,
                                  Active.Value,
                                  RaisonSociale.Text,
                                  NomClient.Text,
                                  Address1.Text,
                                  Address2.Text,
                                  PostalCode.Text,
                                  Region.Text,
                                  City.Text,
                                  Country.Text,
                                  Landline.Text,
                                  Fax.Text,
                                  Cell.Text,
                                  Email.Text,
                                  Website.Text,
                                  Pcompta.Text,
                                  Other.Text,
                                  Répertoire.Text,
                                  IIf(Forfait.Text <> "", True, False),
                                  Forfait.Text,
                                  CHE.Text,
                                  IDE.Text,
                                  Zefix.Text)

            Current.Add()
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
        Timer1.Stop()

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
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ButtonX1.Enabled = False
        ButtonX2.Enabled = False
        ButtonX3.Enabled = True
        Btn_Add.Enabled = RefreshClient()
    End Sub
#End Region
#Region "|10.09| <Event> [ButtonX2_Click]"
    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        RefreshClient()
        Current.Save()
        ButtonX4.RaiseClick()
        AddNew = False
        SmartCoder.Jarvis.Speak("Element saved")
    End Sub

    Private Sub Btn_SendToExcel_Click(sender As Object, e As EventArgs) Handles Btn_SendToExcel.Click
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

    Private Sub ButtonX4_Click(sender As Object, e As EventArgs) Handles ButtonX4.Click
        RefreshData()
    End Sub


#End Region
#End Region
End Class
