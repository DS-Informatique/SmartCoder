Imports DevComponents.DotNetBar.Controls
Imports SmartCoder.M_Microsoft

Public Class PrestationViewer

    Property ActiveClient As Clients
    Public Shared ListPrestations As New List(Of TimeSheet)
    Public ActiveFacture As New Factures
    Private Sub PrestationViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TVA.Text = My.Settings.TVA
        DateStart.Value = New DateTime(Now.Year, Now.Month - 1, 1)
        DateEnd.Value = New DateTime(Now.Year, Now.Month - 1, System.DateTime.DaysInMonth(Now.Year, Now.Month - 1))
        PrepareInterface()
    End Sub

    Private Sub TVA_ValueChanged(sender As Object, e As EventArgs) Handles TVA.TextChanged
        My.Settings.TVA = Double.Parse(TVA.Text)
        My.Settings.Save()
    End Sub

    Public Sub PrepareInterface(Optional ByVal Client As Clients = Nothing,
                                Optional ByVal D0 As DateTime = Nothing,
                                Optional ByVal D1 As DateTime = Nothing)
        If Not IsNothing(Client) Then
            ActiveClient = Client
        Else
            ActiveClient = Mandat.SelectedItem
        End If
        Mandat.Text = ActiveClient.ToString
        If Not IsNothing(D0) Then
            If Not IsNothing(D1) Then
                DateStart.Value = D0
                DateEnd.Value = D1
            Else
                DateStart.Value = New DateTime(Now.Year, Now.Month - 1, 1)
                DateEnd.Value = New DateTime(Now.Year, Now.Month - 1, System.DateTime.DaysInMonth(Now.Year, Now.Month - 1))
            End If
        Else
            DateStart.Value = New DateTime(Now.Year, Now.Month - 1, 1)
            DateEnd.Value = New DateTime(Now.Year, Now.Month - 1, System.DateTime.DaysInMonth(Now.Year, Now.Month - 1))
        End If

        'Mandat.Items.Clear()
        Mandat.DataSource = ActiveClient.List
        ListPrestations = New List(Of TimeSheet)
        Dim C As New TimeSheet
        ListPrestations = C.List(DateStart.Value, DateEnd.Value, ActiveClient.Ref)
        ' Liste_Prestation.Items.Clear()
        ' Liste_Prestation.Columns.Clear()
        ' Dim C0 As New ColumnHeader
        ' With C0
        '    .Text = "Inclure"
        '        .Width = 70
        '    End With
        ' Dim C1 As New ColumnHeader
        '  With C1
        '     .Text = "Date"
        '         .Width = 100
        '     End With
        '  Dim C2 As New ColumnHeader
        '   With C2
        '      .Text = "Temps"
        '      .Width = 100
        '      End With
        '   Dim C3 As New ColumnHeader
        '   With C3
        '     .Text = "Total HTva"
        '         .Width = 150
        '    End With
        '   Dim C4 As New ColumnHeader
        '    '   With C4
        '    .Text = "Description"
        '        .Width = 255
        '    End With
        '    '   Dim C5 As New ColumnHeader
        '   With C5
        '   .Text = "Collaborateur"
        '       .Width = 150
        '   End With
        '   Liste_Prestation.Columns.Add(C0)
        '   Liste_Prestation.Columns.Add(C1)
        '   Liste_Prestation.Columns.Add(C2)
        '   Liste_Prestation.Columns.Add(C3)
        '   Liste_Prestation.Columns.Add(C4)
        '   Liste_Prestation.Columns.Add(C5)
        '   For i = 0 To ListPrestations.Count - 1
        '   Dim It As New ListViewItem("")
        '   It.SubItems.Add(ListPrestations(i).TimeIn)
        '   It.SubItems.Add(ListPrestations(i).Quantity)
        '   It.SubItems.Add(ListPrestations(i).TotalHTVA)
        '   It.SubItems.Add(ListPrestations(i).Description)
        ''   It.SubItems.Add(ListPrestations(i).Collaborateur)
        '   It.ImageIndex = 15
        '   Liste_Prestation.Items.Add(It)
        '   Next
        SGC.PrimaryGrid.DataSource = ListPrestations
        Dim TS As New Sociétés
        Cb_Société.DataSource = TS.List

        Threading.Thread.Sleep(100)

    End Sub
    Private Sub Btn_CalculateTotal_Click(sender As Object, e As EventArgs) Handles Btn_CalculateTotal.Click
        Dim Total As Double = 0
        Dim TQ As Double = 0
        Dim TotalFrai As Double = 0
        Dim TQF As Double = 0
        '   For Each Row As DataRow In SGC.PrimaryGrid.DataSource

        'Next
        For Each Row As DevComponents.DotNetBar.SuperGrid.GridRow In SGC.PrimaryGrid.Rows
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


        '   For Each Item As TimeSheet In SGC.PrimaryGrid.DataSource
        'If Item.Checked = True Then
        ' If Item.SubItems(5).Text = "@FRAIS" Then
        ' TotalFrai += Val(Item.SubItems(3).Text)
        ' TQF += Val(Item.SubItems(2).Text)
        ' Else
        ' Total += Val(Item.SubItems(3).Text)
        ' TQ += Val(Item.SubItems(2).Text)
        ' End If
        '            End If

        '  Next
        Total_Prestation.Text = Math.Round(Total, 2)
        Total_Frais.Text = Math.Round(TotalFrai, 2)
        Quantity_Frais.Text = Math.Round(TQF, 2)
        Quantity_Prestation.Text = Math.Round(TQ, 2)

        Total_HTVA.Text = Math.Round((Total + TotalFrai), 2)


        Total_TVA.Text = Math.Round((Total + TotalFrai) * My.Settings.TVA, 2)
        Me.Total.Value = Math.Round((1 + My.Settings.TVA) * ((Total + TotalFrai)), 2)
    End Sub
    Private Sub Btn_Select_All_Click(sender As Object, e As EventArgs) Handles Btn_Select_All.Click
        For Each Row As DevComponents.DotNetBar.SuperGrid.GridRow In SGC.PrimaryGrid.Rows
            Row.Item(1).Value = True
            'For Each Cell As DevComponents.DotNetBar.SuperGrid.GridCell In Row.Cells
            'Next
        Next
    End Sub
    Private Sub Btn_Deselect_All_Click(sender As Object, e As EventArgs) Handles Btn_Deselect_All.Click
        For Each Row As DevComponents.DotNetBar.SuperGrid.GridRow In SGC.PrimaryGrid.Rows
            Row.Item(1).Value = False
            'For Each Cell As DevComponents.DotNetBar.SuperGrid.GridCell In Row.Cells
            'Next
        Next
    End Sub
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
        If ActiveClient.RaisonSociale <> "" Then
            Address.Text += ActiveClient.RaisonSociale & vbNewLine
        End If
        If ActiveClient.NomClient <> "" Then
            Address.Text += ActiveClient.NomClient & vbNewLine
        End If
        If ActiveClient.Address1 <> "" Then
            Address.Text += ActiveClient.Address1 & vbNewLine
        End If
        If ActiveClient.Address2 <> "" Then
            Address.Text += ActiveClient.Address2 & vbNewLine
        End If
        Address.Text += ActiveClient.PostalCode & " "
        If ActiveClient.Region <> "" Then
            Address.Text += ActiveClient.Region & vbNewLine
            If ActiveClient.City <> "" Then
                Address.Text += ActiveClient.City & vbNewLine
            Else
                If ActiveClient.Country <> "" Then
                    Address.Text += ActiveClient.Country & vbNewLine
                End If
            End If
        Else
            If ActiveClient.City <> "" Then
                Address.Text += ActiveClient.City & vbNewLine
            Else
                If ActiveClient.Country <> "" Then
                    Address.Text += ActiveClient.Country & vbNewLine
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
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "Contribuable Tva : N° " & ActiveClient.CHE & "                Genève " & Now.ToShortDateString & vbNewLine & vbNewLine, 0, 0)
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "", 0, L0)
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), Me.NewInvoice_Libellé.Text, 0, 0)
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "", 0, 0)
        Result.Insert_Paragraph(New Drawing.Font("Arial", 12), "Concerne : " & Me.NewInvoice_Concerne.Text, 0, L0)
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

        Result.WordTable.Cell(1, 2).Range.Text = "(" & String.Format("{0:n2}", Val(Quantity_Prestation.Text)) & ")" & vbTab & vbTab & String.Format("{0:n2}", Val(Total_Prestation.Text))
        Result.WordTable.Cell(1, 2).Range.Font.Name = F.Name
        Result.WordTable.Cell(1, 2).Range.Font.Size = F.Size
        Result.WordTable.Cell(1, 2).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight
        ' Dim S As New ShowProperty(M.WordTable)

        Result.WordTable.Cell(2, 1).Range.Text = "Total des frais"
        Result.WordTable.Cell(2, 1).Range.Font.Name = F.Name
        Result.WordTable.Cell(2, 1).Range.Font.Size = F.Size

        Result.WordTable.Cell(2, 2).Range.Text = String.Format("{0:n2}", Double.Parse(Total_Frais.Text))
        Result.WordTable.Cell(2, 2).Range.Font.Name = F.Name
        Result.WordTable.Cell(2, 2).Range.Font.Size = F.Size
        Result.WordTable.Cell(2, 2).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight
        Result.WordTable.Cell(2, 2).Range.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle

        Result.WordTable.Cell(3, 2).Range.Text = String.Format("{0:n2}", Double.Parse(Total_HTVA.Text))
        Result.WordTable.Cell(3, 2).Range.Font.Name = F.Name
        Result.WordTable.Cell(3, 2).Range.Font.Size = F.Size
        Result.WordTable.Cell(3, 2).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight


        Result.WordTable.Cell(5, 1).Range.Text = "TVA " & My.Settings.TVA * 100
        Result.WordTable.Cell(5, 1).Range.Font.Name = F.Name
        Result.WordTable.Cell(5, 1).Range.Font.Size = F.Size

        Result.WordTable.Cell(5, 2).Range.Text = String.Format("{0:n2}", Double.Parse(Total_TVA.Text))
        Result.WordTable.Cell(5, 2).Range.Font.Name = F.Name
        Result.WordTable.Cell(5, 2).Range.Font.Size = F.Size
        Result.WordTable.Cell(5, 2).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight
        Result.WordTable.Cell(5, 2).Range.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle

        Result.WordTable.Cell(7, 1).Range.Text = "Total payable au "
        Result.WordTable.Cell(7, 1).Range.Font.Name = F.Name
        Result.WordTable.Cell(7, 1).Range.Font.Size = F.Size

        Result.WordTable.Cell(7, 2).Range.Text = String.Format("{0:n2}", Double.Parse(Total.Text))
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
    Public Function Print_InvoiceDetails() As WordDocument

        Dim ListPres As New List(Of Factures_Entries)

        Dim Index As Integer = 0
        For Each Row As DevComponents.DotNetBar.SuperGrid.GridRow In SGC.PrimaryGrid.Rows
            If Row.Item(1).Value = True Then
                Dim Fs As New Factures_Entries(Index,
                                                         ActiveFacture.Code,
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

        'Word.Document.Range(Start:=0, End:=0)
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

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        Dim Code As String = ActiveClient.Ref & "_" & DateStart.Value.Year & "_" & DateStart.Value.Month
        ActiveFacture = New Factures(Code,
                                         Cb_Société.Text,
                                         DateStart.Value.Year,
                                         DateStart.Value.Month,
                                         NewInvoice_N.Value,
                                         ActiveClient.Ref,
                                         NewInvoice_Adresse.Text,
                                         Now,
                                         DateStart.Value,
                                         DateEnd.Value,
                                         NewInvoice_Concerne.Text,
                                         Double.Parse(Quantity_Frais.Text),
                                         Total_HTVA.Value,
                                         Total_Frais.Value,
                                         Total_TVA.Value,
                                         Total.Value,
                                         NewInvoice_Libellé.Text,
                                         "",
                                         "",
                                         "Z:\Factures émises\" & Now.Year & "\" & Code & ".docx",
                                         ActiveClient.Répertoire & Code & ".docx",
                                         ActiveClient.Répertoire & "\Factures\" & Code & ".docx")
        Try
            ActiveFacture.Add()

        Catch ex As Exception
            SmartCoder.Jarvis.Speak(ex.Message)
        End Try

    End Sub

    Private Sub Invoice_Filter_Click(sender As Object, e As EventArgs) Handles Invoice_Filter.Click
        PrepareInterface(Mandat.SelectedItem, DateStart.Value, DateEnd.Value)
    End Sub

    Private Sub SGC_VisibleChanged(sender As Object, e As EventArgs) Handles SGC.VisibleChanged

        Dim Total As Double = 0
        Dim TQ As Double = 0
        Dim TotalFrai As Double = 0
        Dim TQF As Double = 0
        '   For Each Row As DataRow In SGC.PrimaryGrid.DataSource

        'Next
        For Each Row As DevComponents.DotNetBar.SuperGrid.GridRow In SGC.PrimaryGrid.Rows
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
        Total_Prestation.Text = Math.Round(Total, 2)
        Total_Frais.Text = Math.Round(TotalFrai, 2)
        Quantity_Frais.Text = Math.Round(TQF, 2)
        Quantity_Prestation.Text = Math.Round(TQ, 2)

        Total_HTVA.Text = Math.Round((Total + TotalFrai), 2)


        Total_TVA.Text = Math.Round((Total + TotalFrai) * My.Settings.TVA, 2)
        Me.Total.Value = Math.Round((1 + My.Settings.TVA) * ((Total + TotalFrai)), 2)
    End Sub

    Private Sub Btn_Print_Empty_Click(sender As Object, e As EventArgs) Handles Btn_Print_Empty.Click
        Create_Invoice()
    End Sub

    Private Sub Btn_Print_Simple_Click(sender As Object, e As EventArgs) Handles Btn_Print_Simple.Click
        Print_InvoiceDetails()
    End Sub


End Class
