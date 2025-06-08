Imports System.ComponentModel
Imports System.Drawing
Imports System.Text.RegularExpressions
Imports System.Xml.Serialization
Imports DevComponents.DotNetBar.Controls
Imports System.IO
Imports System.Windows.Forms

Public Module M_StringFormat
#Region "<7> [Runtime]"
    Public Space As String = """"
    Public Const DrawLine As String = "_____________________________________________________________________________________"
    Public Const DrawPointedLine As String = "....................................................................................."
#End Region

#Region "|2019/04/20 16h36:432| <02.00.00> <Enumeration> <TextBoxDataFormat> [Call=TextBoxDataFormat|Enumeration]"'The enumeration of TextBoxDataFormat.
    ''' <Summary>
    ''' (Set|Get) The enumeration of TextBoxDataFormat.
    ''' </Summary>
    ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
    ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
    ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
    ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/20 16h36:432 </Published>
    ''' <Updated>[Created=2019/04/20 16h36:432][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
    Public Enum TextBoxDataFormat

        ''' <summary>Specifies the standard ANSI text format.  </summary>
        Text = 0
        ''' <summary>Specifies the standard Windows Unicode text format. </summary>
        UnicodeText = 1
        ''' <summary>Specifies text consisting of rich text format (RTF) data. </summary>
        Rtf = 2
        ''' <summary>Specifies text consisting of HTML data. </summary>
        Html = 3
        ''' <summary>Specifies a comma-separated value (CSV) format, which is a common interchange format used by spreadsheets. </summary>
        CommaSeparatedValue = 4
        ''' <summary>A VB.NET Framework class. </summary>
        Vb = 5
        ''' <summary>C# Framework Class. </summary>
        C# = 6
        ''' <summary>Xml File. </summary>
        Xml = 7
        ''' <summary>SQL Statements. </summary>
        SQL = 8
    End Enum
#End Region ' The enumeration of TextBoxDataFormat.

    Public Class StringRange



#Region "<1> [Property]"
#Region "|2019/04/20 15h04:031| <01.00.00> <Property> <Info> [Call=Selection|String]"'(Set|Get) The String Selected
        Private _Selection As String
        ''' <Summary>
        ''' The String Selected
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/20 15h04:030 </Published>
        ''' <Updated>[Created=2019/04/20 15h04:023][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Info"), Description("The String Selected"), Browsable(True)>
        Public Property Selection() As String
            Get
                Return _Selection
            End Get
            Set(ByVal Value As String)
                _Selection = Value
            End Set
        End Property
#End Region ' (Set|Get) The String Selected
#Region "|2019/04/20 15h05:157| <01.00.01> <Property> <Info> [Call=Length|Integer]"'(Set|Get) The total length of the string.
        Private _Length As Integer
        ''' <Summary>
        ''' The total length of the string.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/20 15h05:157 </Published>
        ''' <Updated>[Created=2019/04/20 15h05:157][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Info"), Description("The total length of the string."), Browsable(True)>
        Public Property Length() As Integer
            Get
                Return _Length
            End Get
            Set(ByVal Value As Integer)
                _Length = Value
            End Set
        End Property
#End Region ' (Set|Get) The total length of the string.
#Region "|2019/04/20 15h05:735| <01.00.02> <Property> <Info> [Call=WordCount|Integer]"'(Set|Get) The total number of words.
        Private _WordCount As Integer
        ''' <Summary>
        ''' The total number of words.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/20 15h05:735 </Published>
        ''' <Updated>[Created=2019/04/20 15h05:735][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Info"), Description("The total number of words."), Browsable(True)>
        Public Property WordCount() As Integer
            Get
                Return _WordCount
            End Get
            Set(ByVal Value As Integer)
                _WordCount = Value
            End Set
        End Property
#End Region ' (Set|Get) The total number of words.
#Region "|2019/04/20 15h06:222| <01.00.03> <Property> <Info> [Call=Lines|List(Of String)]"'(Set|Get) Enumerate each lines as string.
        Private _Lines As List(Of String)
        ''' <Summary>
        ''' Enumerate each lines as string.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/20 15h06:222 </Published>
        ''' <Updated>[Created=2019/04/20 15h06:222][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Info"), Description("Enumerate each lines as string."), Browsable(True)>
        Public Property Lines() As List(Of String)
            Get
                Return _Lines
            End Get
            Set(ByVal Value As List(Of String))
                _Lines = Value
            End Set
        End Property
#End Region ' (Set|Get) Enumerate each lines as string.
#Region "|2019/04/20 15h07:364| <01.01.00> <Property> <Output> [Call=Text|String]"'(Set|Get) Complete String.
        Private _Text As String
        ''' <Summary>
        ''' Complete String.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/20 15h07:364 </Published>
        ''' <Updated>[Created=2019/04/20 15h07:363][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Output"), Description("Complete String."), Browsable(True)>
        Public Property Text() As String
            Get
                Return _Text
            End Get
            Set(ByVal Value As String)
                _Text = Value
            End Set
        End Property
#End Region ' (Set|Get) Complete String.
#Region "|2019/04/20 15h09:223| <01.01.01> <Property> <Output> [Call=TextBox|RichTextBoxEx]"'(Set|Get) the TextBox as RichTextBoxEx
        Private _TextBox As RichTextBoxEx
        ''' <Summary>
        ''' (Set|Get) the TextBox as RichTextBoxEx
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/20 15h09:223 </Published>
        ''' <Updated>[Created=2019/04/20 15h09:223][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Output"), Description("(Set|Get) the TextBox as RichTextBoxEx"), Browsable(True)>
        Public Property TextBox() As RichTextBoxEx
            Get
                Return _TextBox
            End Get
            Set(ByVal Value As RichTextBoxEx)
                _TextBox = Value
            End Set
        End Property
#End Region ' (Set|Get) the TextBox as RichTextBoxEx
#Region "|2019/04/20 15h12:908| <01.02.00> <Property> <Styles> [Call=Font|Font]"'(Set|Get) Defines the font of the string.
        Private _Font As Font
        ''' <Summary>
        ''' Defines the font of the string.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/20 15h12:908 </Published>
        ''' <Updated>[Created=2019/04/20 15h12:908][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Styles"), Description("Defines the font of the string."), Browsable(True)>
        Public Property Font() As Font
            Get
                Return _Font
            End Get
            Set(ByVal Value As Font)
                _Font = Value
            End Set
        End Property
#End Region ' (Set|Get) Defines the font of the string.
#Region "|2019/04/20 15h13:327| <01.02.01> <Property> <Styles> [Call=Format|TextBoxDataFormat]"'(Set|Get) The format of the String.
        Private _Format As TextBoxDataFormat
        ''' <Summary>
        ''' The format of the String.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/20 15h13:327 </Published>
        ''' <Updated>[Created=2019/04/20 15h13:327][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Styles"), Description("The format of the String."), Browsable(True)>
        Public Property Format() As TextBoxDataFormat
            Get
                Return _Format
            End Get
            Set(ByVal Value As TextBoxDataFormat)
                _Format = Value
            End Set
        End Property
#End Region ' (Set|Get) The format of the String.

#End Region
#Region "<2> [Enumeration]"

#End Region
#Region "<3> [Structures]"

#End Region
#Region "<4> [Sub]"

#End Region
#Region "<5> [Function]"
#Region "|2019/04/20 15h17:955| <05.00.00> <Function> <Function> [Call=GetNumberofWords(Content|String)|List(Of String)]"'Get the number of words in a string selection.
        ''' <Summary>
        ''' (Set|Get) Get the number of words in a string selection.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/20 15h17:955 </Published>
        ''' <Updated>[Created=2019/04/20 15h17:954][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Function"), Description("Get the number of words in a string selection."), Browsable(True)>
        Public Shared Function GetNumberofWords(ByVal Content As String) As List(Of String)
            Dim Result As MatchCollection = Regex.Matches(Content, "\S+")
            Dim Lt As New List(Of String)
            For Each item As String In Result.GetEnumerator.ToString
                Lt.Add(item)
            Next
            Return Lt
        End Function
#End Region ' Get the number of words in a string selection.
#Region "<05.00.01> <Function> <Public> <Shared> [Replace(Content|String,Find|String,[ReplaceBy]|String)|StringRange]"
        ''' <summary>
        ''' Replace 
        ''' </summary>
        ''' <param name="Content"></param>
        ''' <returns></returns>
        ''' <a>https://www.dotnetperls.com/replace-vbnet</a>
        Public Shared Function Replace(ByVal Content As String,
                                       ByVal Find As String,
                                       Optional ByVal ReplaceBy As String = "") As StringRange
            Dim Result As New StringRange(Content.Replace(Find, ReplaceBy))
            Return Result
        End Function
#End Region' Replace
#Region "<04.00.01.01> <Function> <Public> <Shared> [GetStringLength(Content|String)|Integer]"
        ''' <summary>
        ''' Calculate the length of a string selection
        ''' </summary>
        ''' <param name="Content"></param>
        ''' <returns></returns>
        ''' <a>https://www.dotnetperls.com/word-count-vbnet</a>
        Public Shared Function GetStringLength(ByVal Content As String) As Integer
            Dim Result As MatchCollection = Regex.Matches(Content, "\S+")
            Return Result.Count

        End Function
#End Region' Calculate the length of a string selection

#End Region
#Region "<6> [Loader]"
#Region "<06.00> <Loader> [Empty]"
        Public Sub New()

        End Sub
#End Region
#Region "<06.01> <Loader> [Full]"
        Public Sub New(ByVal Str As String,
                       Optional ByVal Format As TextBoxDataFormat = Nothing,
                       Optional ByVal Font As Font = Nothing,
                       Optional ByVal Bold As Boolean = False,
                       Optional ByVal Italic As Boolean = False,
                       Optional ByVal Underline As Boolean = False,
                       Optional ByVal Strike As Boolean = False,
                       Optional ByVal Size As Integer = 11.75)
            Me.Selection = ""
            Me.Text = Str
            Me.TextBox = New RichTextBoxEx
            If IsNothing(Format) Then
                Format = TextBoxDataFormat.Rtf
            End If
            Me.Format = Format
            'Me.TextBox.Text = Str
            My.Computer.Clipboard.SetText(Str, Format)
            Me.TextBox.Paste()
            Me.WordCount = GetNumberofWords(Str).Count - 1
            Me.Length = GetStringLength(Str)
            If IsNothing(Font) Then
                Me.Font = New Font(My.Settings.Font.FontFamily, My.Settings.Font.Size)
            Else
                Me.Font = New Font(Font.FontFamily, Font.Size)
            End If
            If Bold = True Then
                Me.Font = New Font(Me.Font, FontStyle.Bold)
            End If
            If Italic = True Then
                Me.Font = New Font(Me.Font, FontStyle.Italic)
            End If
            If Underline = True Then
                Me.Font = New Font(Me.Font, FontStyle.Underline)
            End If
            If Strike = True Then
                Me.Font = New Font(Me.Font, FontStyle.Strikeout)
            End If
            Me.Font = New Font(Me.Font, Size)
        End Sub
#End Region
#End Region
#Region "<7> [Runtime]"

#End Region
#Region "<8> [Class]"

#End Region
    End Class 'StringRange

    '''<summary> Enumerate Lines From a String</summary>
    '''<Author>Saadry Dunkel</Author>
    '''<param name="Str">The string evaluated</param>
    '''<param name="Length">The width per line.</param>
    Public Function FormatString_ToLines(ByVal Str As String, Optional ByVal Length As Integer = 150) As List(Of String)
        Dim Result As New List(Of String)
        Dim VirtualTextBox As New TextBox

        With VirtualTextBox
            .Multiline = True
            .Width = Length
            .Text = Str
        End With

        For Each Line As String In VirtualTextBox.Lines
            Result.Add(Line)
        Next

        Return Result
    End Function


End Module
