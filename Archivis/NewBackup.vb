Imports System.Threading
Imports DevComponents.DotNetBar.SuperGrid
Imports SmartCoder.M_FileManager

Public Class NewBackup
    Private Sub Input_EveryDay_CheckedChanged(sender As Object, e As EventArgs) Handles Input_EveryDay.CheckedChanged
        Try


            If Input_EveryDay.Checked = True Then
                Group_Jour.Visible = True
                Group_Week.Visible = False
            Else
                Group_Jour.Visible = False
            End If
        Catch ex As Exception

        End Try
        Input_Day_01.Checked = Input_EveryDay.Checked
        Input_Day_02.Checked = Input_EveryDay.Checked
        Input_Day_03.Checked = Input_EveryDay.Checked
        Input_Day_04.Checked = Input_EveryDay.Checked
        Input_Day_05.Checked = Input_EveryDay.Checked
        Input_Day_06.Checked = Input_EveryDay.Checked
        Input_Day_07.Checked = Input_EveryDay.Checked
        Input_Day_08.Checked = Input_EveryDay.Checked
        Input_Day_09.Checked = Input_EveryDay.Checked

        Input_Day_10.Checked = Input_EveryDay.Checked
        Input_Day_11.Checked = Input_EveryDay.Checked
        Input_Day_12.Checked = Input_EveryDay.Checked
        Input_Day_13.Checked = Input_EveryDay.Checked
        Input_Day_14.Checked = Input_EveryDay.Checked
        Input_Day_15.Checked = Input_EveryDay.Checked
        Input_Day_16.Checked = Input_EveryDay.Checked
        Input_Day_17.Checked = Input_EveryDay.Checked
        Input_Day_18.Checked = Input_EveryDay.Checked
        Input_Day_19.Checked = Input_EveryDay.Checked

        Input_Day_20.Checked = Input_EveryDay.Checked
        Input_Day_21.Checked = Input_EveryDay.Checked
        Input_Day_22.Checked = Input_EveryDay.Checked
        Input_Day_23.Checked = Input_EveryDay.Checked
        Input_Day_24.Checked = Input_EveryDay.Checked
        Input_Day_25.Checked = Input_EveryDay.Checked
        Input_Day_26.Checked = Input_EveryDay.Checked
        Input_Day_27.Checked = Input_EveryDay.Checked
        Input_Day_28.Checked = Input_EveryDay.Checked
        Input_Day_29.Checked = Input_EveryDay.Checked

        Input_Day_30.Checked = Input_EveryDay.Checked
        Input_Day_31.Checked = Input_EveryDay.Checked

    End Sub
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
    Private Sub Input_EveryWeek_CheckedChanged(sender As Object, e As EventArgs) Handles Input_EveryWeek.CheckedChanged
        If Input_EveryWeek.Checked = True Then
            Group_Week.Visible = True
            Group_Jour.Visible = False
        Else
            Group_Week.Visible = False

        End If
    End Sub

    Private Sub Input_EveryMonth_CheckedChanged(sender As Object, e As EventArgs) Handles Input_EveryMonth.CheckedChanged
        If Input_EveryMonth.Checked = True Then
            Group_Jour.Visible = True
            Group_Week.Visible = False
        Else
            Group_Jour.Visible = False
        End If
    End Sub

    Private _Source As Folder
    Public Property Source() As Folder
        Get
            Return _Source
        End Get
        Set(ByVal value As Folder)
            _Source = value
            If Not IsNothing(value) Then
                Input_Source.Text = value.Target
                Try
                    Output_Source_Size.Text = CalculateDirSize(New IO.DirectoryInfo(value.Target), SizeInfo.Scales.Gigabyte).Display

                Catch ex As Exception

                End Try
            End If
        End Set
    End Property
    Private _Destination As Folder
    Public Property Destination() As Folder
        Get
            Return _Destination
        End Get
        Set(ByVal value As Folder)
            If Not IsNothing(value) Then
                If Not IsNothing(value.Target) Then
                    If value.Target.Length > 1 Then

                        Input_Destination.Text = value.Target
                        ActiveDrive = New SmartCoder.M_Computer.MyComputer.Drive(IO.Path.GetPathRoot(Input_Destination.Text))
                        Output_Destination_Size.Text = ActiveDrive.AvailableFreeSpace.Display
                        ' Dim M As New DevComponents.DotNetBar.Office2007Form
                        ' M.Text = "Analyse du drive de destination"
                        '  Dim A As New DevComponents.DotNetBar.AdvPropertyGrid
                        '  A.Dock = DockStyle.Fill
                        '  A.SelectedObject = ActiveDrive
                        '  M.Controls.Add(A)
                        '  M.Show()
                    End If
                End If
                End If
                _Destination = value
        End Set
    End Property
    Private _ActiveDrive As SmartCoder.MyComputer.Drive
    Public Property ActiveDrive() As SmartCoder.MyComputer.Drive
        Get
            Return _ActiveDrive
        End Get
        Set(ByVal value As SmartCoder.MyComputer.Drive)
            _ActiveDrive = value
        End Set
    End Property
    Private Sub Input_Source_TextChanged(sender As Object, e As EventArgs) Handles Input_Source.TextChanged
        If Input_Source.Text.Length > 1 Then
            '    If Not IsNothing(Source) Then
            '  If Source.Target <> Input_Source.Text Then

            '  Output_Source_Size.Text = CalculateDirSize(New IO.DirectoryInfo(Input_Source.Text)).Display
            'end If
            '  End If
        End If
    End Sub
    Dim S As Double
    Dim D As Double
    Private Sub Input_Destination_TextChanged(sender As Object, e As EventArgs) Handles Input_Destination.TextChanged
        If Input_Destination.Text.Length > 1 Then
            '   If Not IsNothing(Destination) Then
            '  If Destination.Target <> Input_Destination.Text Then
            Destination = New Folder(Input_Destination.Text)
            ' Output_Destination_Size.Text = CalculateDirSize(New IO.DirectoryInfo(Input_Destination.Text)).Display


            'End If
            '   End If
        End If
    End Sub
    Public Property List As List(Of Archives.Profile)
    Private Sub Btn_Refresh_Click(sender As Object, e As EventArgs) Handles Btn_Refresh.Click
        List = New List(Of Archives.Profile)
        If IsNothing(Current) Then
            Current = New Archives.Profile
        End If
        List = Current.List
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


    Private _Current As Archives.Profile
    Public Property Current() As Archives.Profile
        Get
            Return _Current
        End Get
        Set(ByVal value As Archives.Profile)
            _Current = value
            If Not IsNothing(value) Then
                With value
                    Input_Compress.Checked = .Compress
                    Input_Day_01.Checked = .Day_01
                    Input_Day_02.Checked = .Day_02
                    Input_Day_03.Checked = .Day_03
                    Input_Day_04.Checked = .Day_04
                    Input_Day_05.Checked = .Day_05
                    Input_Day_06.Checked = .Day_06
                    Input_Day_07.Checked = .Day_07
                    Input_Day_08.Checked = .Day_08
                    Input_Day_09.Checked = .Day_09

                    Input_Day_10.Checked = .Day_10
                    Input_Day_11.Checked = .Day_11
                    Input_Day_12.Checked = .Day_12
                    Input_Day_13.Checked = .Day_13
                    Input_Day_14.Checked = .Day_14
                    Input_Day_15.Checked = .Day_15
                    Input_Day_16.Checked = .Day_16
                    Input_Day_17.Checked = .Day_17
                    Input_Day_18.Checked = .Day_18
                    Input_Day_19.Checked = .Day_19

                    Input_Day_20.Checked = .Day_20
                    Input_Day_21.Checked = .Day_21
                    Input_Day_22.Checked = .Day_22
                    Input_Day_23.Checked = .Day_23
                    Input_Day_24.Checked = .Day_24
                    Input_Day_25.Checked = .Day_25
                    Input_Day_26.Checked = .Day_26
                    Input_Day_27.Checked = .Day_27
                    Input_Day_28.Checked = .Day_28
                    Input_Day_29.Checked = .Day_29

                    Input_Day_30.Checked = .Day_30
                    Input_Day_31.Checked = .Day_31

                    Input_Destination.Text = .Destination
                    .Encrypt = False
                    Input_EveryDay.Checked = .EveryDay
                    Input_EveryMonth.Checked = .EveryMonth
                    Input_EveryWeek.Checked = .EveryWeek
                    Input_Name.Text = .Name
                    Input_Monday.Checked = .Monday
                    Input_Tuesday.Checked = .Tuesday
                    Input_Wednesday.Checked = .Wednesday
                    Input_Thursday.Checked = .Thursday
                    Input_Friday.Checked = .Friday
                    Input_Saturday.Checked = .Saturday
                    Input_Sunday.Checked = .Sunday
                    Input_Source.Text = .Source
                    Input_Hours.Value = .Hours
                    Input_Minutes.Value = .Minutes
                    '   Source = New Folder(Input_Source.Text)
                    '  Destination = New Folder(Input_Destination.Text)


                End With
            End If
        End Set
    End Property



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
    Public _Loading As Boolean
    Public _DataSet As DataSet
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
                Current = New Archives.Profile
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

                Vcr1.Label.Text = "First of " & _Bm.Count & " records " & "|" & Current.Name & "|"
            ElseIf _Bm.Position = _Bm.Count - 1 Then
                Vcr1.LastButton.Enabled = False
                Vcr1.NextButton.Enabled = False

                Vcr1.FirstButton.Enabled = InlineAssignHelper(Vcr1.PreviousButton.Enabled, (_Bm.Count > 1))

                Vcr1.Label.Text = "Last of " & _Bm.Count & " records" & "|" & Current.Name & "|"
            Else
                Vcr1.FirstButton.Enabled = True
                Vcr1.PreviousButton.Enabled = True
                Vcr1.NextButton.Enabled = True
                Vcr1.LastButton.Enabled = True

                Vcr1.Label.Text = "Record " & (_Bm.Position + 1) & " of " & _Bm.Count & " " & "|" & Current.Name & "|"
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
    Private _AddNew As Boolean
    Public Property AddNew() As Boolean
        Get
            Return _AddNew
        End Get
        Set(ByVal value As Boolean)
            _AddNew = value
            If Not IsNothing(value) Then
                If value = True Then
                    Vcr1.Enabled = False
                    Btn_Add.Enabled = True
                    Btn_Save.Enabled = False
                Else
                    Vcr1.Enabled = True
                    Btn_Add.Enabled = False
                    Btn_Save.Enabled = True
                End If
            End If
        End Set
    End Property
    Private Sub Btn_New_Click(sender As Object, e As EventArgs) Handles Btn_New.Click
        AddNew = True
        Input_Compress.Checked = False
        Input_Day_01.Checked = False
        Input_Day_02.Checked = False
        Input_Day_03.Checked = False
        Input_Day_04.Checked = False
        Input_Day_05.Checked = False
        Input_Day_06.Checked = False
        Input_Day_07.Checked = False
        Input_Day_08.Checked = False
        Input_Day_09.Checked = False
        Input_Day_10.Checked = False
        Input_Day_11.Checked = False
        Input_Day_12.Checked = False
        Input_Day_13.Checked = False
        Input_Day_14.Checked = False
        Input_Day_15.Checked = False
        Input_Day_16.Checked = False
        Input_Day_17.Checked = False
        Input_Day_18.Checked = False
        Input_Day_19.Checked = False
        Input_Day_20.Checked = False
        Input_Day_21.Checked = False
        Input_Day_22.Checked = False
        Input_Day_23.Checked = False
        Input_Day_24.Checked = False
        Input_Day_25.Checked = False
        Input_Day_26.Checked = False
        Input_Day_27.Checked = False
        Input_Day_28.Checked = False
        Input_Day_29.Checked = False
        Input_Day_30.Checked = False
        Input_Day_31.Checked = False
        Input_Destination.Text = ""
        Input_EveryDay.Checked = False
        Input_EveryMonth.Checked = False
        Input_EveryWeek.Checked = False
        Input_FirstOfMonth.Checked = False
        Input_Friday.Checked = False
        Input_Hours.Value = Now.Hour
        Input_Minutes.Value = Now.Minute
        Input_Monday.Checked = False
        Input_Name.Text = ""
        Input_Saturday.Checked = False
        Input_Source.Text = ""
        Input_Sunday.Checked = False
        Input_Thursday.Checked = False
        Input_Tuesday.Checked = False
        Input_Wednesday.Checked = False


    End Sub

    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click
        Current = New Archives.Profile
        Source = New Folder(Input_Source.Text)
        Destination = New Folder(Input_Destination.Text)
        If Not IsNothing(Source) Then
            If Not IsNothing(Destination) Then

                With Current
                    .Compress = Input_Compress.Checked
                    .Day_01 = Input_Day_01.Checked
                    .Day_02 = Input_Day_02.Checked
                    .Day_03 = Input_Day_03.Checked
                    .Day_04 = Input_Day_04.Checked
                    .Day_05 = Input_Day_05.Checked
                    .Day_06 = Input_Day_06.Checked
                    .Day_07 = Input_Day_07.Checked
                    .Day_08 = Input_Day_08.Checked
                    .Day_09 = Input_Day_09.Checked

                    .Day_10 = Input_Day_10.Checked
                    .Day_11 = Input_Day_11.Checked
                    .Day_12 = Input_Day_12.Checked
                    .Day_13 = Input_Day_13.Checked
                    .Day_14 = Input_Day_14.Checked
                    .Day_15 = Input_Day_15.Checked
                    .Day_16 = Input_Day_16.Checked
                    .Day_17 = Input_Day_17.Checked
                    .Day_18 = Input_Day_18.Checked
                    .Day_19 = Input_Day_19.Checked

                    .Day_20 = Input_Day_20.Checked
                    .Day_21 = Input_Day_21.Checked
                    .Day_22 = Input_Day_22.Checked
                    .Day_23 = Input_Day_23.Checked
                    .Day_24 = Input_Day_24.Checked
                    .Day_25 = Input_Day_25.Checked
                    .Day_26 = Input_Day_26.Checked
                    .Day_27 = Input_Day_27.Checked
                    .Day_28 = Input_Day_28.Checked
                    .Day_29 = Input_Day_29.Checked

                    .Day_30 = Input_Day_30.Checked
                    .Day_31 = Input_Day_31.Checked
                    .Destination = Input_Destination.Text
                    .Encrypt = False
                    .EveryDay = Input_EveryDay.Checked
                    .EveryMonth = Input_EveryMonth.Checked
                    .EveryWeek = Input_EveryWeek.Checked
                    .Friday = Input_Friday.Checked
                    .Hours = Input_Hours.Value
                    .Minutes = Input_Minutes.Value
                    .Monday = Input_Monday.Checked
                    .Name = Input_Name.Text
                    .Saturday = Input_Saturday.Checked
                    .Source = Input_Source.Text
                    .Sunday = Input_Sunday.Checked
                    .Thursday = Input_Thursday.Checked
                    .Tuesday = Input_Tuesday.Checked
                    .Wednesday = Input_Wednesday.Checked
                    Try
                        .Add()
                        SmartCoder.Jarvis.Speak("Profile " & .Name & " added successfully")
                    Catch ex As Exception

                    End Try
                    AddNew = False
                    Btn_Refresh.RaiseClick()
                End With

            End If
        End If
    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        If Not IsNothing(Current) Then
            With Current
                .Compress = Input_Compress.Checked
                .Day_01 = Input_Day_01.Checked
                .Day_02 = Input_Day_02.Checked
                .Day_03 = Input_Day_03.Checked
                .Day_04 = Input_Day_04.Checked
                .Day_05 = Input_Day_05.Checked
                .Day_06 = Input_Day_06.Checked
                .Day_07 = Input_Day_07.Checked
                .Day_08 = Input_Day_08.Checked
                .Day_09 = Input_Day_09.Checked

                .Day_10 = Input_Day_10.Checked
                .Day_11 = Input_Day_11.Checked
                .Day_12 = Input_Day_12.Checked
                .Day_13 = Input_Day_13.Checked
                .Day_14 = Input_Day_14.Checked
                .Day_15 = Input_Day_15.Checked
                .Day_16 = Input_Day_16.Checked
                .Day_17 = Input_Day_17.Checked
                .Day_18 = Input_Day_18.Checked
                .Day_19 = Input_Day_19.Checked

                .Day_20 = Input_Day_20.Checked
                .Day_21 = Input_Day_21.Checked
                .Day_22 = Input_Day_22.Checked
                .Day_23 = Input_Day_23.Checked
                .Day_24 = Input_Day_24.Checked
                .Day_25 = Input_Day_25.Checked
                .Day_26 = Input_Day_26.Checked
                .Day_27 = Input_Day_27.Checked
                .Day_28 = Input_Day_28.Checked
                .Day_29 = Input_Day_29.Checked

                .Day_30 = Input_Day_30.Checked
                .Day_31 = Input_Day_31.Checked
                .Destination = Input_Destination.Text
                .Encrypt = False
                .EveryDay = Input_EveryDay.Checked
                .EveryMonth = Input_EveryMonth.Checked
                .EveryWeek = Input_EveryWeek.Checked
                .Friday = Input_Friday.Checked
                .Hours = Input_Hours.Value
                .Minutes = Input_Minutes.Value
                .Monday = Input_Monday.Checked
                .Name = Input_Name.Text
                .Saturday = Input_Saturday.Checked

                .Source = Input_Source.Text
                .Sunday = Input_Sunday.Checked
                .Thursday = Input_Thursday.Checked
                .Tuesday = Input_Tuesday.Checked
                .Wednesday = Input_Wednesday.Checked
                .NumberofOccurences = Input_Cycles.Value
                Try
                    .Save()
                    SmartCoder.Jarvis.Speak("Profile " & .Name & " has been saved successfully")
                Catch ex As Exception

                End Try
                Btn_Refresh.RaiseClick()
            End With
        End If
    End Sub

    Private Sub Btn_Define_Source_Click(sender As Object, e As EventArgs) Handles Btn_Define_Source.Click
        If FDB_Source.ShowDialog = DialogResult.OK Then
            Source = New Folder(FDB_Source.SelectedPath)
        End If
    End Sub

    Private Sub Btn_Define_Destination_Click(sender As Object, e As EventArgs) Handles Btn_Define_Destination.Click
        If FDB_Destination.ShowDialog = DialogResult.OK Then
            Destination = New Folder(FDB_Destination.SelectedPath)
        End If
    End Sub

    Private Sub Input_Minutes_ValueChanged(sender As Object, e As EventArgs) Handles Input_Minutes.ValueChanged

    End Sub

    Private Sub Input_Hours_ValueChanged(sender As Object, e As EventArgs) Handles Input_Hours.ValueChanged
        Try
            If Not IsNothing(Current) Then

                Dim St As New Folder(Current.Source)
                Dim Ft As New Folder(Current.Destination)
                D = New SizeInfo((ActiveDrive.AvailableFreeSpace.Raw * (1 - 0.2)) / 4).Raw
                S = St.FolderSize.Raw
                Input_Cycles.Value = Math.Round(D / S, 0)
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
