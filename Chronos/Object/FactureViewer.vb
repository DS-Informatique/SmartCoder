Imports System.Threading
Imports DevComponents.DotNetBar.Controls
Imports DevComponents.DotNetBar.SuperGrid
Imports SmartCoder.M_Microsoft


Public Class FactureViewer

#Region "[Code]"

#Region "|1| [Property]{3}"
#Region "|01.00| <Property> [Current|Factures]"
    Private _Current As Factures
    Public Property Current() As Factures
        Get
            Return _Current
        End Get
        Set(ByVal value As Factures)
            _Current = value
            If Not IsNothing(value) Then
                Input_Adresse.Text = value.Adresse
                Input_Concerne.Text = value.Concerne
                Input_Libellé.Text = value.Libellé
                Input_N.Text = value.N
                Input_DateOp.Value = value.DateEnvoi
                Input_DateStart.Value = value.PériodeIN
                Input_DateEnd.Value = value.PériodeFIN
                Input_Mandat.Text = value.Client
                Invoice_Filter.PerformClick()
                List = value.Prestations
            End If
        End Set
    End Property
#End Region
#Region "|01.01| <Property> [List|List(Of Factures_Entries)]"
    Private _List As List(Of Factures_Entries)
    Public Property List() As List(Of Factures_Entries)
        Get
            Return _List
        End Get
        Set(ByVal value As List(Of Factures_Entries))
            _List = value
        End Set
    End Property
#End Region
#Region "|01.02| <Property> [Bm|BindingManagerBase]"
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
#Region "|4| [Sub]{6}"
#Region "|04.00| <Sub> [RefreshData]"
    Public Sub RefreshData()
        InitializeGrid()
        Dim dataSource As Object = Nothing
        Dim dataMember As String = Nothing
        Dim context As Object = Nothing

        dataSource = List_Factures
        context = dataSource
        ' Set the SuperGrid DataSource and DataMember, and
        ' set our BindingManager for later data traversal

        SGC.PrimaryGrid.DataSource = dataSource
        SGC.PrimaryGrid.DataMember = dataMember
        If dataSource Is Nothing Then Bm = Nothing Else Bm = SGC.BindingContext(context)

    End Sub
#End Region
#Region "|04.01| <Sub> [PrepareInterface(Client|Clients,D0|DateTime,D1|DateTime)]"
    Public Sub PrepareInterface(Optional ByVal Client As Clients = Nothing,
                                Optional ByVal D0 As DateTime = Nothing,
                                Optional ByVal D1 As DateTime = Nothing)
        Current_Client = Client
        If Not IsNothing(D0) Then
            If Not IsNothing(D1) Then
                Input_DateStart.Value = D0
                Input_DateEnd.Value = D1
            Else
                Input_DateStart.Value = New DateTime(Now.Year, Now.Month - 1, 1)
                Input_DateEnd.Value = New DateTime(Now.Year, Now.Month - 1, System.DateTime.DaysInMonth(Now.Year, Now.Month - 1))
            End If
        Else
            Input_DateStart.Value = New DateTime(Now.Year, Now.Month - 1, 1)
            Input_DateEnd.Value = New DateTime(Now.Year, Now.Month - 1, System.DateTime.DaysInMonth(Now.Year, Now.Month - 1))
        End If
        If BW.IsBusy Then
        Else
            BW.RunWorkerAsync()
        End If
        Threading.Thread.Sleep(100)
    End Sub
#End Region
#Region "|04.02| <Sub> [InitializeGrid]"
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
        '  AddHandler SGC.RowsPurged, AddressOf SuperGridControl1RowsPurged
        '
        ' When new rows are added via the grid, let's
        ' see that they have something imaginative in them

        ' AddHandler SGC.RowSetDefaultValues, AddressOf SuperGridControl1RowSetDefaultValues

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
#Region "|04.03| <Sub> [LoadDataSet]"
    Private Sub LoadDataSet()
        _Loading = True
        _LoadThread = New Thread(AddressOf LoadThread)
        _LoadThread.Start()
    End Sub
#End Region
#Region "|04.04| <Sub> [LoadThread]"
    Private Sub LoadThread()
        Try
            If IsNothing(Current) Then
                Current = New Factures
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
#Region "|04.05| <Sub> [UpdateVcr]"
    ''' <summary>
    ''' Updates our VCR states
    ''' </summary>
    Private Sub UpdateVcr()
        If _Bm.Position > _Bm.Count Then
            Current = List_Factures(_Bm.Count)
        ElseIf _Bm.Position < 0 Then
            Current = List_Factures(0)
        Else
            Current = List_Factures(_Bm.Position)
        End If
        RefreshFacture()

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
#Region "|5| [Function]{4}"
#Region "|05.00| <Function> [RefreshFacture|Boolean]"
    Public Function RefreshFacture() As Boolean
        Dim Result As Boolean = False
        Dim LCollaborateur As New List(Of Factures)
        LCollaborateur = Current.List
        Dim Msg As String = ""
        If Input_Code.Text = "" Then
            Msg += "Le numéro de référence est vide." & vbNewLine
        Else
            With Current
                .Adresse = Input_Adresse.Text
                .Année = Year(Input_DateOp.Value)
                .Mois = Month(Input_DateOp.Value)
                .N = Input_N.Value
                ' .Prestation = ""
                '  For Each F As Factures_Entries In List
                '     .Prestation += "|" & F.ID & "| " & F.Collaborateur & "|" & F.UnitPrice & "|" & F.Quantity & "|" & F.TotalHTVA & "|" & vbNewLine &
                '  F.Description & vbNewLine
                '    Next
                .PériodeFIN = Input_DateEnd.Value
                .PériodeIN = Input_DateStart.Value
                .Quantité = Val(Input_Quantity_Frais.Text) + Val(Input_Quantity_Prestation.Text)
                .Total = Input_Total.Value
                .TotalFrais = Input_Total_Frais.Value
                .TotalHTVA = Input_Total_HTVA.Value
                .TotalTVA = Input_Total_TVA.Value
                .Concerne = Input_Concerne.Text
                '               .Content = ""
                .DateEnvoi = Input_DateOp.Value
                .Emise_Par = Input_Société.Text
                '               .FilePath_Client = Current_Client.Répertoire & "\Factures\" & .Année & "\" & .Mois & "\" & .Code & ".xls"
                '                If IO.Directory.Exists(Current_Client.Répertoire & "\Factures\" & .Année & "\" & .Mois) Then
                '                    Try
                '                        IO.Directory.CreateDirectory(Current_Client.Répertoire & "\Factures\" & .Année & "\" & .Mois)
                '                    Catch ex As Exception
                '
                '                   End Try
                '               End If
                '  .FilePath_Empty = "Z:\Factures émises\" & .Année & "\" & .Mois & "\" & .Code & ".xls"
                '                If IO.Directory.Exists("Z:\Factures émises\" & .Année & "\" & .Mois) Then
                '                    Try
                '                        IO.Directory.CreateDirectory("Z:\Factures émises\" & .Année & "\" & .Mois)
                '                    Catch ex As Exception
                '
                '     End Try
                ' End If
                '.Filepath_Prestation = "Z:\Factures émises\" & .Année & "\" & .Mois & "\Prestations_" & .Code & ".xls"
                '    .Prestations = Factures.FindEntries(Current)
                '   SGC2.PrimaryGrid.DataSource = .Prestations
            End With
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
#Region "|05.01| <Function> [Create_Invoice|WordDocument]"
    Public Function Create_Invoice() As WordDocument

        Dim Result As New WordDocument
        With Result.WordDocument.PageSetup
            .LeftMargin = Math.Round((2) * 37.795275591, 2)
            .RightMargin = Math.Round(1.5 * 37.795275591, 2)
            .TopMargin = Math.Round(1.9 * 37.795275591, 2)
            .BottomMargin = Math.Round(3.17 * 37.795275591, 2)
        End With

        Dim Address As New RichTextBoxEx
        Address.Text += "" & vbNewLine
        If Current_Client.RaisonSociale <> "" Then
            Address.Text += Current_Client.RaisonSociale & vbNewLine
        End If
        If Current_Client.NomClient <> "" Then
            Address.Text += Current_Client.NomClient & vbNewLine
        End If
        If Current_Client.Address1 <> "" Then
            Address.Text += Current_Client.Address1 & vbNewLine
        End If
        If Current_Client.Address2 <> "" Then
            Address.Text += Current_Client.Address2 & vbNewLine
        End If
        Address.Text += Current_Client.PostalCode & " "
        If Current_Client.Region <> "" Then
            Address.Text += Current_Client.Region & vbNewLine
            If Current_Client.City <> "" Then
                Address.Text += Current_Client.City & vbNewLine
            Else
                If Current_Client.Country <> "" Then
                    Address.Text += Current_Client.Country & vbNewLine
                End If
            End If
        Else
            If Current_Client.City <> "" Then
                Address.Text += Current_Client.City & vbNewLine
            Else
                If Current_Client.Country <> "" Then
                    Address.Text += Current_Client.Country & vbNewLine
                End If
            End If
        End If
        Address.Text += vbNewLine & vbNewLine
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "", 0, 0)
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "", 0, 0)
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "", 0, 0)
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "", 0, 0)
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "", 0, 0)
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "", 0, 0)

        For i = 0 To Address.Lines.Count - 1
            Dim Str As String = Address.Lines(i)
            If i = 0 Then
                Result.Insert_Paragraph(New Drawing.Font("Arial", 12, FontStyle.Bold), Str, 0, 24)
            ElseIf i = Address.Lines.Count - 1 Then
                Result.Insert_Paragraph(New Drawing.Font("Arial", 12, FontStyle.Bold), Str, 6, 24)
            Else
                Result.Insert_Paragraph(New Drawing.Font("Arial", 12, FontStyle.Bold), Str, 0, 24)

            End If
        Next

        Dim L0 As Integer = 0
        Dim L1 As Integer = 24
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "", 0, -24)
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "", 0, L0)
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "Contribuable Tva : N° " & Current_Client.CHE & "                Genève " & Now.ToShortDateString & vbNewLine & vbNewLine, 0, 0)
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "", 0, L0)
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), Me.Input_Libellé.Text, 0, 0)
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "", 0, 0)
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "Concerne : " & Me.Input_Concerne.Text, 0, L0)
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "", 0, 0)
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "", 0, 0)
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "", 0, L1)

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

        Result.WordTable.Cell(7, 1).Range.Text = "Total payable au "
        Result.WordTable.Cell(7, 1).Range.Font.Name = F.Name
        Result.WordTable.Cell(7, 1).Range.Font.Size = F.Size

        Result.WordTable.Cell(7, 2).Range.Text = String.Format("{0:n2}", Double.Parse(Input_Total.Text))
        Result.WordTable.Cell(7, 2).Range.Font.Name = F.Name
        Result.WordTable.Cell(7, 2).Range.Font.Size = F.Size
        Result.WordTable.Cell(7, 2).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight
        Result.WordTable.Cell(7, 2).Range.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble
        P.Range.InsertParagraphAfter()
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "", 0, 0)
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "", 0, 0)
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "", 0, 0)
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "", 0, 0)
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
#End Region
#Region "|05.02| <Function> [Print_InvoiceDetails|WordDocument]"
    Public Function Print_InvoiceDetails() As WordDocument

        Dim ListPres As New List(Of Factures_Entries)
        Dim Index As Integer = 0
        For Each Row As DevComponents.DotNetBar.SuperGrid.GridRow In SGC.PrimaryGrid.Rows
            If Row.Item(1).Value = True Then
                Dim Fs As New Factures_Entries(Index,
                                                         Current.Code,
                                                         True,
                                                         Row.Item(2).Value,
                                                         Row.Item(3).Value,
                                                         Row.Item(4).Value,
                                                         Row.Item(6).Value,
                                                         Row.Item(7).Value,
                                                         Row.Item(8).Value,
                                                         Row.Item(9).Value,
                                                         Row.Item(5).Value)
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
            .LeftMargin = Math.Round((2) * 37.795275591, 2)
            .RightMargin = Math.Round(1.5 * 37.795275591, 2)
            .TopMargin = Math.Round(1.9 * 37.795275591, 2)
            .BottomMargin = Math.Round(3.17 * 37.795275591, 2)
        End With
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "", 0, 0)
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "", 0, 0)
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "", 0, 0)
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "", 0, 0)
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "", 0, 0)
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "", 0, 0)
        Dim P As Microsoft.Office.Interop.Word.Paragraph = Result.WordDocument.Paragraphs.Add
        Dim F As New System.Drawing.Font("Arial", 12)
        For Each Fx As Factures_Entries In ListPres
            Dim PC As Microsoft.Office.Interop.Word.Paragraph = Result.WordDocument.Paragraphs.Add
            Result.Insert_Table(PC.Range, 2, 2)
            With Result.WordTable.Cell(1, 1).Range
                .Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle
                .Text = ""
                .Font.Name = F.Name
                .Font.Size = F.Size
            End With
            With Result.WordTable.Cell(1, 2).Range
                .Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle
                .Text = Fx.Quantity & vbTab & Fx.TotalHTVA
                .Font.Name = F.Name
                .Font.Size = F.Size
            End With
            With Result.WordTable.Cell(2, 1).Range
                .Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle
                .Text = Fx.Description
                .Font.Name = F.Name
                .Font.Size = F.Size
            End With
            PC.Range.InsertParagraphAfter()
        Next
        Result.Release()
        Return Result
    End Function
#End Region
#Region "|05.03| <Function> [InlineAssignHelper(Target|T,Value|T)|T]"
    Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, ByVal value As T) As T
        target = value
        Return value
    End Function
#End Region
#End Region
#Region "|6| [Runtime]{7}"
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
#Region "|06.05| <Runtime> [_LoadThread|Thread]"
    Private _LoadThread As Thread
#End Region
#Region "|06.06| <Runtime> [table|DataTable]"
    Private table As DataTable
#End Region
#End Region
#Region "|7| [Loader]{1}"
#Region "|07.00| <Loader> [Load]"
    Private Sub FactureViewer_Load(sender As Object, e As EventArgs) Handles Me.Load
        CheckForIllegalCrossThreadCalls = False
        Input_DateStart.Value = New DateTime(Now.Year, Now.Month - 1, 1)
        Input_DateEnd.Value = New DateTime(Now.Year, Now.Month - 1, System.DateTime.DaysInMonth(Now.Year, Now.Month - 1))
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
        Dim LtO As New List(Of Clients)
        If IsNothing(List_Clients) Then
            List_Clients = New List(Of Clients)

        End If
        If List_Clients.Count - 1 < 1 Then
            If IsNothing(Current_Client) Then
                Current_Client = New Clients
            End If
            List_Clients = Current_Client.List
        End If
        For Each cl As Clients In List_Clients
            If cl.Active = True Then
                LtO.Add(cl)
            End If
        Next
        Input_Mandat.DataSource = LtO
        If IsNothing(List_Factures) Then
            List_Factures = New List(Of Factures)
            Current_Factures = New Factures

            Current_Société.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password))
            List_Factures = Current_Factures.List
        Else
            If List_Factures.Count - 1 < 1 Then

                Current_Factures.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password))
                List_Factures = Current_Factures.List
            End If
        End If
        Input_Société.DataSource = List_Sociétés
        TVA.Text = My.Settings.TVA
    End Sub
#End Region
#End Region
#Region "|10| [Event]{22}"
#Region "|10.00| <Event> [Mandat_SelectedIndexChanged]"
    Private Sub Mandat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Input_Mandat.SelectedIndexChanged
        Try
            Current_Client = New Clients
            Current_Client = Input_Mandat.SelectedItem
            Dim Address As String = ""
            If Current_Client.RaisonSociale <> "" Then
                Address += Current_Client.RaisonSociale & vbNewLine
            End If
            If Current_Client.NomClient <> "" Then
                Address += Current_Client.NomClient & vbNewLine
            End If
            If Current_Client.Address1 <> "" Then
                Address += Current_Client.Address1 & vbNewLine
            End If
            If Current_Client.Address2 <> "" Then
                Address += Current_Client.Address2 & vbNewLine
            End If
            Address += Current_Client.PostalCode & " "
            If Current_Client.Region <> "" Then
                Address += Current_Client.Region & vbNewLine
            Else
                Address += Current_Client.City & vbNewLine
            End If
            Address += Current_Client.Country & vbNewLine
            Input_Adresse.Text = Address
        Catch ex As Exception
        End Try
    End Sub
#End Region
#Region "|10.01| <Event> [ButtonX1_Click]"
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Btn_Verify.PerformClick()

        Current = New Factures
        AddNew = True
        IsReady = False
        Timer1.Start()
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
#Region "|10.02| <Event> [Btn_Add_Click]"
    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click
        Timer1.Stop()
        Btn_Add.Enabled = False
        ButtonX1.Enabled = True
        ButtonX2.Enabled = True
        Try
            Current = New Factures(Input_Code.Text,
                                   Input_Société.Text,
                                   Year(Input_DateOp.Value),
                                   Month(Input_DateOp.Value),
                                   Input_N.Value,
                                   Input_Mandat.Text,
                                   Input_Adresse.Text,
                                   Input_DateOp.Value,
                                   Input_DateStart.Value,
                                   Input_DateEnd.Value,
                                   Input_Concerne.Text,
                                   Val(Input_Quantity_Frais.Text) + Val(Input_Quantity_Prestation.Text),
                                   Input_Total_HTVA.Value,
                                   Input_Total_Frais.Value,
                                   Input_Total_TVA.Value,
                                   Input_Total.Value,
                                   Input_Libellé.Text)
            Current.Add()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        List_Factures = Current.List
        Current = List_Factures(0)
        InitializeGrid()
        RefreshData()
        AddNew = False

    End Sub
#End Region
#Region "|10.03| <Event> [Timer1_Tick]"
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ButtonX1.Enabled = False
        ButtonX2.Enabled = False
        Btn_Add.Enabled = RefreshFacture()
    End Sub
#End Region
#Region "|10.04| <Event> [ButtonX2_Click]"
    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        RefreshFacture()
        Current.Save()
        ButtonX4.RaiseClick()
        AddNew = False
        SmartCoder.Jarvis.Speak("Element saved")
    End Sub
#End Region
#Region "|10.05| <Event> [Btn_Verify_Click]"
    Private Sub Btn_Verify_Click(sender As Object, e As EventArgs) Handles Btn_Verify.Click
        RefreshFacture()
    End Sub
#End Region
#Region "|10.06| <Event> [Btn_SendToExcel_Click]"
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
#End Region
#Region "|10.07| <Event> [TVA_TextChanged]"
    Private Sub TVA_TextChanged(sender As Object, e As EventArgs) Handles TVA.TextChanged
        My.Settings.TVA = Double.Parse(TVA.Text)
        My.Settings.Save()
        'SmartCoder.Jarvis.Speak("The Vat percentage has been updated.")
    End Sub
#End Region
#Region "|10.08| <Event> [Btn_Select_All_Click]"
    Private Sub Btn_Select_All_Click(sender As Object, e As EventArgs) Handles Btn_Select_All.Click
        For Each Row As DevComponents.DotNetBar.SuperGrid.GridRow In SGC.PrimaryGrid.Rows
            Row.Item(1).Value = True
            'For Each Cell As DevComponents.DotNetBar.SuperGrid.GridCell In Row.Cells
            'Next
        Next
    End Sub
#End Region
#Region "|10.09| <Event> [Btn_Deselect_All_Click]"
    Private Sub Btn_Deselect_All_Click(sender As Object, e As EventArgs) Handles Btn_Deselect_All.Click
        For Each Row As DevComponents.DotNetBar.SuperGrid.GridRow In SGC.PrimaryGrid.Rows
            Row.Item(1).Value = False
            'For Each Cell As DevComponents.DotNetBar.SuperGrid.GridCell In Row.Cells
            'Next
        Next
    End Sub
#End Region
#Region "|10.10| <Event> [Btn_CalculateTotal_Click]"
    Private Sub Btn_CalculateTotal_Click(sender As Object, e As EventArgs) Handles Btn_CalculateTotal.Click
        Dim Total As Double = 0
        Dim TQ As Double = 0
        Dim TotalFrai As Double = 0
        Dim TQF As Double = 0

        For Each Row As DevComponents.DotNetBar.SuperGrid.GridRow In PrestationViewer1.SGC.PrimaryGrid.Rows
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
        Input_Total_Prestation.Text = Math.Round(Total, 2)
        Input_Total_Frais.Text = Math.Round(TotalFrai, 2)
        Input_Quantity_Frais.Text = Math.Round(TQF, 2)
        Input_Quantity_Prestation.Text = Math.Round(TQ, 2)

        Input_Total_HTVA.Text = Math.Round((Total + TotalFrai), 2)


        Input_Total_TVA.Text = Math.Round((Total + TotalFrai) * My.Settings.TVA, 2)
        Input_Total.Value = Math.Round((1 + My.Settings.TVA) * ((Total + TotalFrai)), 2)
    End Sub
#End Region
#Region "|10.11| <Event> [Btn_Print_Empty_Click]"
    Private Sub Btn_Print_Empty_Click(sender As Object, e As EventArgs) Handles Btn_Print_Empty.Click
        Create_Invoice()
    End Sub
#End Region
#Region "|10.12| <Event> [Btn_Print_Empty_Click]"
    Private Sub Btn_Print_Simple_Click(sender As Object, e As EventArgs) Handles Btn_Print_Simple.Click
        Print_InvoiceDetails()
    End Sub
#End Region
#Region "|10.13| <Event> [ButtonX4_Click]"
    Private Sub ButtonX4_Click(sender As Object, e As EventArgs) Handles ButtonX4.Click
        RefreshData()
    End Sub
#End Region
#Region "|10.14| <Event> [BW_DoWork]"
    Private Sub BW_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW.DoWork
        If IsNothing(Current_Client) Then
            Current_Client = New Clients
        Else
            Current_Client = Input_Mandat.SelectedItem
        End If
        Input_Mandat.Text = Current_Client.ToString


        'Mandat.Items.Clear()
        Input_Mandat.DataSource = Current_Client.List
        List_TimeSheet = New List(Of TimeSheet)
        Dim C As New TimeSheet
        List_TimeSheet = C.List(Input_DateStart.Value, Input_DateEnd.Value, Current_Client.Ref)
    End Sub
#End Region
#Region "|10.15| <Event> [Invoice_Filter_Click]"
    Private Sub Invoice_Filter_Click(sender As Object, e As EventArgs) Handles Invoice_Filter.Click
        If Not IsNothing(Current_Client) Then
            PrestationViewer1.PrepareInterface(Current_Client, Input_DateStart.Value, Input_DateEnd.Value)

            If IsNothing(List_Factures) Then
                List_Factures = New List(Of Factures)
            End If
            'If List_Factures.Count - 1 < 1 Then
            If IsNothing(Current_Factures) Then
                    Current_Factures = New Factures
                End If
                List_Factures = Current_Factures.List
            'End If
            Dim NewList As New List(Of Factures)
            For Each F As Factures In List_Factures
                If F.Client = Current_Client.Ref Then
                    If Input_DateStart.Value >= F.PériodeIN And Input_DateStart.Value <= F.PériodeFIN And Input_DateEnd.Value <= F.PériodeFIN Then
                        NewList.Add(F)
                    End If
                End If
            Next
            List_Factures = NewList
            RefreshData()
        End If
    End Sub
#End Region
#Region "|10.16| <Event> [BW_RunWorkerCompleted]"
    Private Sub BW_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW.RunWorkerCompleted
        PrestationViewer1.SGC.PrimaryGrid.DataSource = List_TimeSheet
    End Sub
#End Region
#Region "|10.17| <Event> [BmPositionChanged]"
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
#Region "|10.18| <Event> [VcrFirstClick]"
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
#Region "|10.19| <Event> [VcrPreviousClick]"
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
#Region "|10.20| <Event> [VcrNextClick]"
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
#Region "|10.21| <Event> [VcrLastClick]"
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
#End Region
#End Region

End Class
