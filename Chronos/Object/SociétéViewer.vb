Imports System.Threading
Imports DevComponents.DotNetBar.SuperGrid

Public Class SociétéViewer


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
    Dim AddNew As Boolean = False
    Dim IsReady As Boolean = False
#Region "<Property>"
    Private _Current As Sociétés
    Public Property Current() As Sociétés
        Get
            Return _Current
        End Get
        Set(ByVal value As Sociétés)
            _Current = value
            If Not IsNothing(value) Then
                Input_RaisonSocial.Text = value.RaisonSocial
                Input_Index.Value = value.Index
                Input_NuméroTVA.Text = value.NuméroTVA
                Input_Ref.Text = value.Ref
                AdvPropertyGrid1.SelectedObject = value
            End If
        End Set
    End Property


#End Region
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Btn_Verify.PerformClick()

        Current = New Sociétés
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
            Current = New Sociétés(Input_Ref.Text, Input_RaisonSocial.Text, Input_NuméroTVA.Text, Input_Index.Value)
            Current.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password))
            Current.Add()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        List_Sociétés = Current.List
        Try
            Current = List_Sociétés(0)

        Catch ex As Exception

        End Try
        InitializeGrid()
        RefreshData()
        AddNew = False

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ButtonX1.Enabled = False
        ButtonX2.Enabled = False
        Btn_Add.Enabled = RefreshCollaborateur()
        AdvPropertyGrid1.SelectedObject = Current

    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        RefreshCollaborateur()
        Current.Save()
        ButtonX4.RaiseClick()
        AddNew = False
        SmartCoder.Jarvis.Speak(Current.Ref & " has been saved.")
    End Sub
    Private Sub CollaborateurViewer_Load(sender As Object, e As EventArgs) Handles Me.Load
        CheckForIllegalCrossThreadCalls = False
        RefreshData()
    End Sub
    Public Sub RefreshData()
        If IsNothing(List_Sociétés) Then
            List_Sociétés = New List(Of Sociétés)
            Current_Société = New Sociétés

            Current_Société.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password))
            List_Sociétés = Current_Société.List
        Else
            If List_Sociétés.Count - 1 < 1 Then

                Current_Société.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password))
                List_Sociétés = Current_Société.List
            End If
        End If

        InitializeGrid()
        Dim dataSource As Object = Nothing
        Dim dataMember As String = Nothing
        Dim context As Object = Nothing

        dataSource = List_Sociétés
        context = dataSource
        ' Set the SuperGrid DataSource and DataMember, and
        ' set our BindingManager for later data traversal

        SGC.PrimaryGrid.DataSource = dataSource
        SGC.PrimaryGrid.DataMember = dataMember
        If dataSource Is Nothing Then Bm = Nothing Else Bm = SGC.BindingContext(context)

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

        _LoadThread = New Thread(AddressOf LoadThread)
        _LoadThread.Start()
    End Sub

#Region "LoadThread"

    Private Sub LoadThread()
        Try


            If IsNothing(Current) Then
                Current = New Sociétés
            End If
            If IsNothing(Current.Table) Then
                Current.Table = New SmartCoder.M_FileManager.Table(Current.TableName, Current.FilePath, Current.Password, False)
            End If
            table = Current.Table.DataTable

            _DataSet = New DataSet("MyDataSet")
            _DataSet.Tables.Add(table.Clone)
            table.TableName = Current.TableName
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
        If _Bm.Position > _Bm.Count Then
            Current = List_Sociétés(_Bm.Count)
        ElseIf _Bm.Position < 0 Then
            Current = List_Sociétés(0)
        Else
            Current = List_Sociétés(_Bm.Position)
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

                Vcr1.Label.Text = "First of " & _Bm.Count & " records " & "|" & Current.Ref & "|" & Current.RaisonSocial & "|" & Current.NuméroTVA
            ElseIf _Bm.Position = _Bm.Count - 1 Then
                Vcr1.LastButton.Enabled = False
                Vcr1.NextButton.Enabled = False

                Vcr1.FirstButton.Enabled = InlineAssignHelper(Vcr1.PreviousButton.Enabled, (_Bm.Count > 1))

                Vcr1.Label.Text = "Last of " & _Bm.Count & " records" & "|" & Current.Ref & "|" & Current.RaisonSocial & "|" & Current.NuméroTVA
            Else
                Vcr1.FirstButton.Enabled = True
                Vcr1.PreviousButton.Enabled = True
                Vcr1.NextButton.Enabled = True
                Vcr1.LastButton.Enabled = True

                Vcr1.Label.Text = "Record " & (_Bm.Position + 1) & " of " & _Bm.Count & " " & "|" & Current.Ref & "|" & Current.RaisonSocial & "|" & Current.NuméroTVA
            End If
        End If
    End Sub

#End Region
    Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, ByVal value As T) As T
        target = value
        Return value
    End Function


#End Region

#End Region
    Private Sub Btn_Verify_Click(sender As Object, e As EventArgs) Handles Btn_Verify.Click
        RefreshCollaborateur()
    End Sub
    Public Function RefreshCollaborateur() As Boolean
        Dim Result As Boolean = False
        Dim LCollaborateur As New List(Of Sociétés)
        LCollaborateur = Current.List
        Dim Msg As String = ""
        If Input_Ref.Text = "" Then
            Msg += "Le numéro de référence [Ref] est vide." & vbNewLine
        Else
            Dim Isvalid As Boolean = True
            Dim CRef As String = ""
            For I = 0 To LCollaborateur.Count - 1
                If LCollaborateur(I).Ref = Input_Ref.Text Then
                    CRef = LCollaborateur(I).RaisonSocial & vbNewLine
                    Isvalid = False
                    Exit For
                End If
            Next
            If Isvalid = False Then
                Msg += "le numéro de référence est déjà utilisé par " & CRef & "." & vbNewLine
            Else
                Current.Ref = Input_Ref.Text
                If Input_RaisonSocial.Text.Length < 1 Then
                    Msg += "Vous n'avez pas rentrez de Raison Sociale." & vbNewLine
                Else
                    Current.RaisonSocial = Input_RaisonSocial.Text
                End If
                Current.NuméroTVA = Input_NuméroTVA.Text
            End If


        End If
        If Msg.Length > 0 Then
            Result = False
        Else
            Result = True
        End If
        Return Result

    End Function

    Private Sub Btn_SendToExcel_Click(sender As Object, e As EventArgs) Handles Btn_SendToExcel.Click
        Dim Msg As String = Nothing
        Try
            SmartCoder.ExcelDocument.Export_DataTable(SGC, "Sociétés.xlsx", Msg) 'My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\

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

    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles ButtonX3.Click
        ' Timer1.Stop()

        If AddNew = True Then
            AddNew = False
            Btn_Add.Enabled = False
            ButtonX1.Enabled = True
            ButtonX2.Enabled = True
            '   Current = New TimeSheet
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

    Private Sub ButtonX4_Click(sender As Object, e As EventArgs) Handles ButtonX4.Click
        List_Sociétés = New List(Of Sociétés)
        RefreshData()

    End Sub
End Class
