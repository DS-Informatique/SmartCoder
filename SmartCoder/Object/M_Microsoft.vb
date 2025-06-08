Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports Microsoft.Office.Interop

Public Module M_Microsoft

#Region "[On] |2019/06/02 23h55:603| <08.00.00> <Class> <> |.WordDocument|Class|"' 
    ''' <summary>
    ''' Create a Word Document 
    ''' </summary>
    Public Class WordDocument
#Region "<1> [Property]{3}"
#Region "[On] |2019/06/03 13h51:203| <01.00.00> <Property> <Info> |.WordApp()|Word.Application|"' (Set|Get) The WordApp as Word.Application.
        Private _WordApp As Word.Application
        '''    <Summary>
        '''     (Set|Get) The WordApp as Word.Application.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/03 13h54:154 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.
        '''    All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.
        '''    The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>

        <Browsable(True), CategoryAttribute("Info"), Description("(Set|Get) The WordApp as Word.Application.")>
        Property WordApp() As Word.Application
            Get
                Return _WordApp
            End Get
            Set(ByVal Value As Word.Application)
                _WordApp = Value
            End Set
        End Property
#End Region '(Set|Get) The WordApp as Word.Application.
#Region "[On] |2019/06/03 13h51:652| <01.00.01> <Property> <Info> |.WordDocument()|Word.Document|"' (Set|Get) The WordDocument as Word.Document.
        Private _WordDocument As Word.Document
        '''    <Summary>
        '''     (Set|Get) The WordDocument as Word.Document.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/03 13h54:154 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>

        <Browsable(True), CategoryAttribute("Info"), Description("(Set|Get) The WordDocument as Word.Document.")>
        Public Property WordDocument() As Word.Document
            Get
                Return _WordDocument
            End Get
            Set(ByVal Value As Word.Document)
                _WordDocument = Value
            End Set
        End Property
#End Region '(Set|Get) The WordDocument as Word.Document.
#Region "[On] |2019/06/03 13h52:467| <01.00.02> <Property> <Info> |.WordTable()|Word.Table|"' (Set|Get) The WordTable as Word.Table.
        Private _WordTable As Word.Table
        '''    <Summary>
        '''     (Set|Get) The WordTable as Word.Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/03 13h54:155 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>

        <Browsable(True), CategoryAttribute("Info"), Description("(Set|Get) The WordTable as Word.Table.")>
        Public Property WordTable() As Word.Table
            Get
                Return _WordTable
            End Get
            Set(ByVal Value As Word.Table)
                _WordTable = Value
            End Set
        End Property
#End Region '(Set|Get) The WordTable as Word.Table.
#Region "[On] |2019/06/03 13h53:868| <01.00.03> <Property> <Info> |.WordParagraph()|Word.Paragraph|"' (Set|Get) The WordParagraph as Word.Paragraph.
        Private _WordParagraph As Word.Paragraph
        '''    <Summary>
        '''     (Set|Get) The WordParagraph as Word.Paragraph.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/03 13h54:155 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>

        <Browsable(True), CategoryAttribute("Info"), Description("(Set|Get) The WordParagraph as Word.Paragraph.")>
        Public Property WordParagraph() As Word.Paragraph
            Get
                Return _WordParagraph
            End Get
            Set(ByVal Value As Word.Paragraph)
                _WordParagraph = Value
            End Set
        End Property


#End Region '(Set|Get) The WordParagraph as Word.Paragraph.
#End Region

#Region "|4| [Sub]"
#Region "|04.00| <Sub> [Clear]"
        Public Sub Clear()
            With Me
                .WordApp = CreateObject("Word.Application")
                .WordApp.Visible = True
                .WordDocument = WordDocument
                .WordDocument = .WordApp.Documents.Add
                With .WordDocument
                    .PageSetup.LeftMargin = 2.0
                    .PageSetup.TopMargin = 1.9
                    .PageSetup.RightMargin = 1.5
                    .PageSetup.BottomMargin = 3.17
                End With
            End With
        End Sub
#End Region
#Region "|04.01| <Sub> [Insert]"
#Region "|04.01.00| <Sub> <Insert> [Paragraph]"
        Public Sub Insert_Paragraph(ByVal Font As System.Drawing.Font, ByVal Content As String, ByVal SpaceAfter As Integer,
                                    ByVal RightIndent As Integer)
            If Not IsNothing(Me.WordDocument) Then
                Me.WordParagraph = Me.WordDocument.Paragraphs.Add
                If Not IsNothing(Font) Then
                    Me.WordParagraph.Range.Font.Name = Font.Name
                    Me.WordParagraph.Range.Font.Bold = Font.Bold
                    Me.WordParagraph.Range.Font.Italic = Font.Italic
                    Me.WordParagraph.Range.Font.Size = Font.Size
                    Me.WordParagraph.Range.Font.Underline = Font.Underline
                    Me.WordParagraph.Range.Text = Content
                    Me.WordParagraph.Format.SpaceAfter = SpaceAfter
                    Me.WordParagraph.Range.InsertParagraphAfter()
                    Me.WordParagraph.Range.Style = WordDocument.Styles("No Spacing")
                    Me.WordParagraph.IndentCharWidth(RightIndent)
                    With WordDocument.Paragraphs(1)
                        '.IndentCharWidth(RightIndent)
                    End With
                End If
            End If
        End Sub

#End Region
#Region "|04.02| <Sub> [Release]"
        Public Sub Release()
            Me.releaseObject(WordTable)
            releaseObject(WordParagraph)
            releaseObject(WordDocument)
            releaseObject(WordApp)

        End Sub
        Private Sub releaseObject(ByVal obj As Object)
            Try
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
                obj = Nothing
            Catch ex As Exception
                obj = Nothing
            Finally
                GC.Collect()
            End Try
        End Sub
#End Region
#End Region

#Region "|5| [Function]"
#Region "|05.00| <Function> [Insert_Table(Range,Rows,Columns)]"
        ''' <summary>
        ''' Insert a Table
        ''' </summary>
        ''' <param name="Range">Example : Dim tableLocation As Word.Range = Me.Range(Start:=0, End:=0)</param>
        ''' <param name="rows"></param>
        ''' <param name="Columns"></param>
        ''' <returns></returns>
        Public Function Insert_Table(ByRef Range As Word.Range,
                                     ByVal rows As Integer,
                                     ByVal Columns As Integer) As Word.Table
            '  
            Me.WordTable = Me.WordDocument.Tables.Add(Range:=Range, NumRows:=rows, NumColumns:=Columns)
            Me.WordTable.Range.InsertParagraphAfter()
            '  Dim S As New ShowProperty(Me.WordDocument.Tables.Item(0))
            ' S.Show()
            ' Dim Result As Word.Table = Me.WordDocument.Tables(0)
            Return WordTable
        End Function
#End Region
#End Region
#End Region
#Region "|7| [Loader]"
#Region "|07.00| <Loader> [Empty]"
        Public Sub New()
            Clear()
        End Sub
#End Region
#End Region
#Region "|9| [Constante]"
#End Region
    End Class
#End Region
#Region "[On] |2019/06/23 18h33:664| <08.00.00> <Class> <> |.ExcelDocument|Class|{6}"' 

    Public Class ExcelDocument
#Region "<1> [Property]{5}"
#Region "[On] |2019/06/23 18h33:385| <01.00.00> <Property> <Info> |.Application()|Microsoft.Office.Interop.Excel.Application|"' (Set|Get) The Application as Microsoft.Office.Interop.Excel.Application.
        Private _Application As Microsoft.Office.Interop.Excel.Application
        '''    <Summary>
        '''     (Set|Get) The Application as Microsoft.Office.Interop.Excel.Application.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/23 18h41:294 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.
        '''    All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.
        '''    The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>

        <Browsable(True), CategoryAttribute("Info"), Description("(Set|Get) The Application as Microsoft.Office.Interop.Excel.Application.")>
        Property Application() As Microsoft.Office.Interop.Excel.Application
            Get
                Return _Application
            End Get
            Set(ByVal Value As Microsoft.Office.Interop.Excel.Application)
                _Application = Value
            End Set
        End Property
#End Region '(Set|Get) The Application as Microsoft.Office.Interop.Excel.Application.

#Region "[On] |2019/06/23 18h35:925| <01.00.01> <Property> <Info> |.WorkBooks()|List(Of Microsoft.Office.Interop.Excel.Workbook)|"' (Set|Get) The WorkBooks as List(Of Microsoft.Office.Interop.Excel.Workbook).
        Private _WorkBooks As List(Of Microsoft.Office.Interop.Excel.Workbook)
        '''    <Summary>
        '''     (Set|Get) The WorkBooks as List(Of Microsoft.Office.Interop.Excel.Workbook).
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/23 18h41:295 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>

        <Browsable(True), CategoryAttribute("Info"), Description("(Set|Get) The WorkBooks as List(Of Microsoft.Office.Interop.Excel.Workbook).")>
        Public Property WorkBooks() As List(Of Microsoft.Office.Interop.Excel.Workbook)
            Get
                Return _WorkBooks
            End Get
            Set(ByVal Value As List(Of Microsoft.Office.Interop.Excel.Workbook))
                _WorkBooks = Value
            End Set
        End Property
#End Region '(Set|Get) The WorkBooks as List(Of Microsoft.Office.Interop.Excel.Workbook).

#Region "[On] |2019/06/23 18h37:817| <01.00.02> <Property> <Info> |.Current_WorkBook()|Microsoft.Office.Interop.Excel.Workbook|"' (Set|Get) The Current_WorkBook as Microsoft.Office.Interop.Excel.Workbook.
        Private _Current_WorkBook As Microsoft.Office.Interop.Excel.Workbook
        '''    <Summary>
        '''     (Set|Get) The Current_WorkBook as Microsoft.Office.Interop.Excel.Workbook.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/23 18h41:295 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>

        <Browsable(True), CategoryAttribute("Info"), Description("(Set|Get) The Current_WorkBook as Microsoft.Office.Interop.Excel.Workbook.")>
        Public Property Current_WorkBook() As Microsoft.Office.Interop.Excel.Workbook
            Get
                Return _Current_WorkBook
            End Get
            Set(ByVal Value As Microsoft.Office.Interop.Excel.Workbook)
                _Current_WorkBook = Value
            End Set
        End Property
#End Region '(Set|Get) The Current_WorkBook as Microsoft.Office.Interop.Excel.Workbook.

#Region "[On] |2019/06/23 18h37:357| <01.00.03> <Property> <Info> |.List_WorkSheet()|List(Of Microsoft.Office.Interop.Excel.Worksheet)|"' (Set|Get) The List_WorkSheet as List(Of Microsoft.Office.Interop.Excel.Worksheet).
        Private _List_WorkSheet As List(Of Microsoft.Office.Interop.Excel.Worksheet)
        '''    <Summary>
        '''     (Set|Get) The List_WorkSheet as List(Of Microsoft.Office.Interop.Excel.Worksheet).
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/23 18h41:295 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>

        <Browsable(True), CategoryAttribute("Info"), Description("(Set|Get) The List_WorkSheet as List(Of Microsoft.Office.Interop.Excel.Worksheet).")>
        Public Property List_WorkSheet() As List(Of Microsoft.Office.Interop.Excel.Worksheet)
            Get
                Return _List_WorkSheet
            End Get
            Set(ByVal Value As List(Of Microsoft.Office.Interop.Excel.Worksheet))
                _List_WorkSheet = Value
            End Set
        End Property
#End Region '(Set|Get) The List_WorkSheet as List(Of Microsoft.Office.Interop.Excel.Worksheet).

#Region "[On] |2019/06/23 18h37:657| <01.00.04> <Property> <Info> |.Current_WorkSheet()|Microsoft.Office.Interop.Excel.Worksheet|"' (Set|Get) The Current_WorkSheet as Microsoft.Office.Interop.Excel.Worksheet.
        Private _Current_WorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        '''    <Summary>
        '''     (Set|Get) The Current_WorkSheet as Microsoft.Office.Interop.Excel.Worksheet.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/23 18h41:296 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>

        <Browsable(True), CategoryAttribute("Info"), Description("(Set|Get) The Current_WorkSheet as Microsoft.Office.Interop.Excel.Worksheet.")>
        Public Property Current_WorkSheet() As Microsoft.Office.Interop.Excel.Worksheet
            Get
                Return _Current_WorkSheet
            End Get
            Set(ByVal Value As Microsoft.Office.Interop.Excel.Worksheet)
                _Current_WorkSheet = Value
            End Set
        End Property
#End Region '(Set|Get) The Current_WorkSheet as Microsoft.Office.Interop.Excel.Worksheet.

#End Region
#Region "<4> [Sub]{1}"
#Region "[On] |2019/06/23 18h32:933| <04.00.00> <Sub> <> |.Send_DataTable()|Sub}|"' (Set|Get) The sub Send_DataTable.
        '''    <Summary>
        '''     (Set|Get) The sub Send_DataTable.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <ContributorName>ANKUR</ContributorName>
        '''    <ContributorUri>http://www.authorcode.com/export-datatable-to-excel-in-vb-net/</ContributorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/23 18h41:296 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.
        '''    All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.
        '''    The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>

        <Browsable(True), Description("(Set|Get) The sub Send_DataTable.")>
        Public Sub Send_DataTable(ByVal DTable As DataTable)
            Dim _excel As New Microsoft.Office.Interop.Excel.Application
            Dim wBook As Microsoft.Office.Interop.Excel.Workbook
            Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet

            wBook = _excel.Workbooks.Add()
            wSheet = wBook.ActiveSheet()

            Dim dt As System.Data.DataTable = DTable
            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            For Each dc In dt.Columns
                colIndex = colIndex + 1
                _excel.Cells(1, colIndex) = dc.ColumnName
            Next
            For Each dr In dt.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In dt.Columns
                    colIndex = colIndex + 1
                    _excel.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next
            wSheet.Columns.AutoFit()
            Dim strFileName As String = "C:\" & IIf(dt.TableName.Length < 1, "Table1", dt.TableName) & ".xlsx"
            If System.IO.File.Exists(strFileName) Then
                System.IO.File.Delete(strFileName)
            End If

            ' wBook.SaveAs(strFileName)
            'wBook.Close()
            '_excel.Quit()
        End Sub
#End Region '(Set|Get) The sub Send_DataTable.

#End Region
        Public Shared Function Export_DataTable(ByRef SGC As DevComponents.DotNetBar.SuperGrid.SuperGridControl, ByVal FileName As String, ByRef OutputMessage As String) As Boolean
            Dim Result As Boolean = True
            If IsNothing(SGC) Then
                Result = False
                Return Result
                Exit Function
            End If
            Try
                'Can't continue if DataTable is Nothing.
                '(1) Creating Excel Application and document
                Dim Excel_Application As Excel.Application = Nothing
                Dim Excel_WorkBook As Excel.Workbook = Nothing
                Dim Excel_WorkSheet As Excel.Worksheet = Nothing
                '(2) Adding object 
                Try
                    Excel_Application = New Excel.Application()

                    With Excel_Application
                        'Mutting the fellow
                        .AlertBeforeOverwriting = False
                        .DisplayAlerts = False
                        .Visible = True
                    End With

                    Excel_WorkBook = Excel_Application.Workbooks.Add(Type.Missing)
                    Excel_WorkBook.SaveAs(FileName, 56,,,,, Excel.XlSaveAsAccessMode.xlNoChange,,,,)
                    Excel_WorkSheet = DirectCast(Excel_Application.ActiveWorkbook.ActiveSheet, Excel.Worksheet)

                    For C = 0 To SGC.PrimaryGrid.Columns.Count - 1
                        ' Copy each Columns Starting From A1
                        Excel_WorkSheet.Cells(1, C + 1) = SGC.PrimaryGrid.Columns(C).Name

                    Next
                    Dim R As Integer = 1
                    For Each Row As DevComponents.DotNetBar.SuperGrid.GridRow In SGC.PrimaryGrid.Rows
                        For C = 0 To SGC.PrimaryGrid.Columns.Count - 1
                            Excel_WorkSheet.Cells(R + 1, C + 1) = Row.Item(C).Value
                        Next
                        R += 1
                    Next
                    Excel_WorkSheet.Columns.AutoFit()
                    Excel_WorkBook.Save()
                    Result = True
                Catch ex As System.Runtime.InteropServices.COMException
                    If ex.ErrorCode = -2147221164 Then
                        OutputMessage = "Error in export: Please install Microsoft Office (Excel) to use the Export to Excel feature."
                    ElseIf ex.ErrorCode = -2146827284 Then
                        OutputMessage = "Error in export: Excel allows only 65,536 maximum rows in a sheet."
                    Else
                        OutputMessage = (("Error in export: " & ex.Message) + Environment.NewLine & " Error: ") + ex.ErrorCode
                    End If
                Catch ex As Exception
                    OutputMessage = "Error in export: " & ex.Message
                Finally
                    Try
                        '   If Excel_WorkBook IsNot Nothing Then
                        '  Excel_WorkBook.Close(Nothing, Nothing, Nothing)
                        ' End If
                        '    Excel_Application.Workbooks.Close()
                        '   Excel_Application.Quit()
                        '  If rg IsNot Nothing Then
                        '  Marshal.ReleaseComObject(rg)
                        '  End If
                        If Excel_WorkSheet IsNot Nothing Then
                            Marshal.ReleaseComObject(Excel_WorkSheet)
                        End If
                        If Excel_WorkBook IsNot Nothing Then
                            Marshal.ReleaseComObject(Excel_WorkBook)
                        End If
                        If Excel_Application IsNot Nothing Then
                            Marshal.ReleaseComObject(Excel_Application)
                        End If

                    Catch
                    End Try
                    Excel_WorkSheet = Nothing
                    Excel_WorkBook = Nothing
                    Excel_Application = Nothing
                    ' force final cleanup!
                    GC.Collect()
                    GC.WaitForPendingFinalizers()
                End Try
            Catch ex As Exception
                OutputMessage = "Error in export: " & ex.Message
            End Try

            Return Result
        End Function
        Public Shared Function Export_DataTable(ByRef DataTable As DataTable, ByVal FileName As String, ByRef OutputMessage As String) As Boolean
            Dim Result As Boolean = True
            If IsNothing(DataTable) Then
                Result = False
                Return Result
                Exit Function
            End If
            Try
                'Can't continue if DataTable is Nothing.
                '(1) Creating Excel Application and document
                Dim Excel_Application As Excel.Application = Nothing
                Dim Excel_WorkBook As Excel.Workbook = Nothing
                Dim Excel_WorkSheet As Excel.Worksheet = Nothing
                '(2) Adding object 
                Try
                    Excel_Application = New Excel.Application()
                    With Excel_Application
                        'Mutting the fellow
                        .AlertBeforeOverwriting = False
                        .DisplayAlerts = False
                    End With

                    Excel_WorkBook = Excel_Application.Workbooks.Add(Type.Missing)
                    Excel_WorkBook.SaveAs(FileName, 56,,,,, Excel.XlSaveAsAccessMode.xlNoChange,,,,)
                    Excel_WorkSheet = DirectCast(Excel_Application.ActiveWorkbook.ActiveSheet, Excel.Worksheet)

                    For C = 0 To DataTable.Columns.Count - 1
                        ' Copy each Columns Starting From A1
                        Excel_WorkSheet.Cells(1, C + 1) = DataTable.Columns(C).ToString

                    Next
                    For R = 1 To DataTable.Columns.Count
                        For C = 0 To DataTable.Columns.Count - 1
                            Excel_WorkSheet.Cells(R + 1, C + 1) = DataTable.Rows(R - 1)(C).ToString()

                        Next
                    Next
                    Excel_WorkSheet.Columns.AutoFit()
                    Excel_WorkBook.Save()
                    Result = True
                Catch ex As System.Runtime.InteropServices.COMException
                    If ex.ErrorCode = -2147221164 Then
                        OutputMessage = "Error in export: Please install Microsoft Office (Excel) to use the Export to Excel feature."
                    ElseIf ex.ErrorCode = -2146827284 Then
                        OutputMessage = "Error in export: Excel allows only 65,536 maximum rows in a sheet."
                    Else
                        OutputMessage = (("Error in export: " & ex.Message) + Environment.NewLine & " Error: ") + ex.ErrorCode
                    End If
                Catch ex As Exception
                    OutputMessage = "Error in export: " & ex.Message
                Finally
                    Try
                        If Excel_WorkBook IsNot Nothing Then
                            Excel_WorkBook.Close(Nothing, Nothing, Nothing)
                        End If
                        Excel_Application.Workbooks.Close()
                        Excel_Application.Quit()
                        '  If rg IsNot Nothing Then
                        '  Marshal.ReleaseComObject(rg)
                        '  End If
                        If Excel_WorkSheet IsNot Nothing Then
                            Marshal.ReleaseComObject(Excel_WorkSheet)
                        End If
                        If Excel_WorkBook IsNot Nothing Then
                            Marshal.ReleaseComObject(Excel_WorkBook)
                        End If
                        If Excel_Application IsNot Nothing Then
                            Marshal.ReleaseComObject(Excel_Application)
                        End If

                    Catch
                    End Try
                    Excel_WorkSheet = Nothing
                    Excel_WorkBook = Nothing
                    Excel_Application = Nothing
                    ' force final cleanup!
                    GC.Collect()
                    GC.WaitForPendingFinalizers()
                End Try
            Catch ex As Exception
                OutputMessage = "Error in export: " & ex.Message
            End Try

            Return Result
        End Function
    End Class
#End Region

End Module
