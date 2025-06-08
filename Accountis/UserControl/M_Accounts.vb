Imports System.ComponentModel
Imports System.IO
Imports SmartCoder

Public Module M_Accounts


#Region "[On] |2019/07/08 11h22:495| <08.00.00> <Class> <> |.Accounts|Class|{2} |Production Cost : 47.9|Selling Price : 119.75|"' 
    '''    <Summary>
    '''     '''    Object Name :             Public  Class Accounts
    '''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
    '''    Contributor Information : ||
    '''    Creation Date :           2019/07/08 11h22:495
    '''    |Schema|
    '''    |ID| |ObjectType |{Quantity}||UnitPrice||Total
    '''    |00| |Importation|{0}||1| |0
    '''    |01| |Properties |{8}||0.8| |6.4
    '''    |02| |Enumeration|{1}||0.4| |0.4
    '''    |03| |Structure  |{0}||0.4| |0
    '''    |04| |Sub        |{6}||1.2| |7.2
    '''    |05| |Function   |{8}||1.6| |12.8
    '''    |06| |Runtime    |{16}||0.4| |6.4
    '''    |07| |Loader     |{4}||0.8| |3.2
    '''    |08| |Class      |{2}||2| |4
    '''    |09| |Constante  |{0}||0.4| |0
    '''    |10| |Event      |{0}||1.2| |0
    '''    |11| |Members    |{4}||0.5| |2
    '''    |12| |Parameter  |{11}||0.5| |5.5
    '''    |Production Cost             |47.9
    '''    |Selling Price without VAT   |119.75
    '''    |Total TVA                   |9.22
    '''    |Grand Total                 |128.97
    '''    |/Schema|
    '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
    '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
    '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
    '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:550 </Published>
    '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
    '''    </Summary>
    Public Class Accounts
#Region "[On] |2019/07/08 11h22:495| <08.00.00> <Class> <> |.Accounts|Class|"' 
#Region "[On] |2019/07/08 11h22:472| <08.00.00> <Class> <> |.Users|Class|{31} |Production Cost : 33.7|Selling Price : 84.25|"' Class created automatically by SmartOffice (c)Copyright 2019.
        '''    <Summary>
        '''     Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Users
        '''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
        '''    Contributor Information : ||
        '''    Creation Date :           2019/07/08 11h22:472
        '''    |Schema|
        '''    |ID| |ObjectType |{Quantity}||UnitPrice||Total
        '''    |00| |Importation|{0}||1| |0
        '''    |01| |Properties |{4}||0.8| |3.2
        '''    |02| |Enumeration|{1}||0.4| |0.4
        '''    |03| |Structure  |{0}||0.4| |0
        '''    |04| |Sub        |{5}||1.2| |6
        '''    |05| |Function   |{7}||1.6| |11.2
        '''    |06| |Runtime    |{12}||0.4| |4.8
        '''    |07| |Loader     |{2}||0.8| |1.6
        '''    |08| |Class      |{0}||2| |0
        '''    |09| |Constante  |{0}||0.4| |0
        '''    |10| |Event      |{0}||1.2| |0
        '''    |11| |Members    |{4}||0.5| |2
        '''    |12| |Parameter  |{9}||0.5| |4.5
        '''    |Production Cost             |33.7
        '''    |Selling Price without VAT   |84.25
        '''    |Total TVA                   |6.49
        '''    |Grand Total                 |90.74
        '''    |/Schema|
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:550 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        Public Class Users
#Region "<1> [Property]{4}"
#Region "[On] |2019/07/08 11h22:474| <01.00.00> <Property> <Columns> |.UserName()|String|"' (Set|Get) The UserName as String.
            Private _UserName As String
            '''    <Summary>
            '''     (Set|Get) The UserName as String.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:550 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The UserName as String.")>
            Public Property UserName() As String
                Get
                    Return _UserName
                End Get
                Set(ByVal Value As String)
                    _UserName = Value
                End Set
            End Property
#End Region '(Set|Get) The UserName as String.
#Region "[On] |2019/07/08 11h22:616| <01.00.01> <Property> <Columns> |.Password()|String|"' (Set|Get) The Password as String.
            Private _Password As String
            '''    <Summary>
            '''     (Set|Get) The Password as String.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:550 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Password as String.")>
            Public Property Password() As String
                Get
                    Return _Password
                End Get
                Set(ByVal Value As String)
                    _Password = Value
                End Set
            End Property
#End Region '(Set|Get) The Password as String.
#Region "[On] |2019/07/08 11h22:623| <01.00.02> <Property> <Columns> |.Email()|String|"' (Set|Get) The Email as String.
            Private _Email As String
            '''    <Summary>
            '''     (Set|Get) The Email as String.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:550 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Email as String.")>
            Public Property Email() As String
                Get
                    Return _Email
                End Get
                Set(ByVal Value As String)
                    _Email = Value
                End Set
            End Property
#End Region '(Set|Get) The Email as String.
#Region "[On] |2019/07/08 11h22:629| <01.00.03> <Property> <Columns> |.Active()|Boolean|"' (Set|Get) The Active as Boolean.
            Private _Active As Boolean
            '''    <Summary>
            '''     (Set|Get) The Active as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:551 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Active as Boolean.")>
            Public Property Active() As Boolean
                Get
                    Return _Active
                End Get
                Set(ByVal Value As Boolean)
                    _Active = Value
                End Set
            End Property
#End Region '(Set|Get) The Active as Boolean.
#End Region
#Region "<2> [Enumeration]{1}"
#Region "[On] |2019/07/08 11h22:636| <02.00.00> <Enumeration> <> |.Schema()|Enumeration{3}|"' (Set|Get) The enumeration of Schema.
            '''    <Summary>
            '''     (Set|Get) The enumeration of Schema.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:551 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The enumeration of Schema.")>
            Enum Schema
                ''' <summary>(Set|Get) The UserName as String.</summary>
                [UserName] = 0
                ''' <summary>(Set|Get) The Password as String.</summary>
                [Password] = 1
                ''' <summary>(Set|Get) The Email as String.</summary>
                [Email] = 2
                ''' <summary>(Set|Get) The Active as Boolean.</summary>
                [Active] = 3
            End Enum
#End Region '(Set|Get) The enumeration of Schema.
#End Region
#Region "<4> [Sub]{5}"
#Region "[On] |2019/07/08 11h22:732| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
            '''    <Summary>
            '''     (Set|Get) This will reinitialize the class element.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:551 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) This will reinitialize the class element.")>
            Public Sub Clear()
                With Me
                    .UserName = Nothing
                    .Password = Nothing
                    .Email = Nothing
                    .Active = False
                End With
            End Sub
#End Region '(Set|Get) This will reinitialize the class element.
#Region "[On] |2019/07/08 11h22:837| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
            '''    <Summary>
            '''     (Set|Get) This will reinitialize the variables of this class.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:551 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) This will reinitialize the variables of this class.")>
            Public Sub Reset(Optional ByVal Connector As LineInfo = Nothing)
                If Not IsNothing(Connector) Then
                    Me.Connector = Connector
                    Me.FilePath = ""
                    Me.MyPassword = ""
                    Me.Line = ""
                    If Connector.Status <> Status.Broken Then
                        FilePath = Connector.FilePath
                        MyPassword = Connector.Password
                        Me.Connector = Connector
                        TableName = "Users"
                        Line = Connector.Line
                        UseSQL = False
                    Else
                        FilePath = My.Settings.Db_Users_FilePath
                        MyPassword = My.Settings.Db_Users_Password
                        Me.Line = My.Settings.Db_Users_Line
                        TableName = "Users"
                        UseSQL = False
                    End If
                Else
                    If IsNothing(FilePath) Then
                        FilePath = My.Settings.Db_Users_FilePath
                    End If
                    If FilePath.Length < 1 Then
                        FilePath = My.Settings.Db_Users_FilePath
                    End If
                    FilePath = My.Settings.Db_Users_FilePath
                    MyPassword = My.Settings.Db_Users_Password
                    Me.Line = My.Settings.Db_Users_Line
                    TableName = "Users"
                    UseSQL = False
                End If

            End Sub
#End Region '(Set|Get) This will reinitialize the variables of this class.
#Region "[On] |2019/07/08 11h22:852| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
            '''    <Summary>
            '''     (Set|Get) This will add a new row in the table.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:551 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) This will add a new row in the table.")>
            Public Sub Add()
                Try
                    Dim Str As String = Nothing
                    Str = "Insert Into [Users] (
`UserName`, 
`Password`, 
`Email`, 
`Active`) Values (@0, @1, @2, @3)"
                    Con = New OleDb.OleDbConnection(New LineInfo(FilePath, MyPassword).Line)
                    Cmd = New OleDb.OleDbCommand(Str, Con)
                    Con.Open()
                    Cmd.Parameters.AddWithValue("@0", Me.UserName)
                    Cmd.Parameters.AddWithValue("@1", Me.Password)
                    Cmd.Parameters.AddWithValue("@2", Me.Email)
                    Cmd.Parameters.AddWithValue("@3", Me.Active)
                    If Cmd.ExecuteNonQuery >= 0 Then
                    Else
                        MsgBox("Element not Addd")
                    End If
                Catch ex As Exception
                Finally
                    Close(True)
                End Try

            End Sub
#End Region '(Set|Get) This will add a new row in the table.
#Region "[On] |2019/07/08 11h22:863| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
            '''    <Summary>
            '''     (Set|Get) This will update a row in the table.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:552 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) This will update a row in the table.")>
            Public Sub Save()
                Try
                    Dim Str As String = Nothing
                    Str = "UPDATE [Users] SET Password = @Password, Email = @Email, Active = @Active WHERE UserName = @UserName"
                    Con = New OleDb.OleDbConnection(New LineInfo(FilePath, MyPassword).Line)
                    Cmd = New OleDb.OleDbCommand(Str, Con)
                    Con.Open()
                    Cmd.Parameters.AddWithValue("@Password", Password)
                    Cmd.Parameters.AddWithValue("@Email", Email)
                    Cmd.Parameters.AddWithValue("@Active", Active)
                    Cmd.Parameters.AddWithValue("@UserName", UserName)
                    If Cmd.ExecuteNonQuery >= 0 Then
                    Else
                        MsgBox("Element not Saved")
                    End If
                Catch ex As Exception
                Finally
                    Close(True)
                End Try

            End Sub
#End Region '(Set|Get) This will update a row in the table.
#Region "[On] |2019/07/08 11h22:869| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
            '''    <Summary>
            '''     (Set|Get) This will Delete a row in the table.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:552 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) This will Delete a row in the table.")>
            Public Sub Delete()
                Try
                    Dim Str As String = Nothing
                    Str = "Delete From [Users] WHERE UserName =@UserName"
                    Con = New OleDb.OleDbConnection(New LineInfo(FilePath, MyPassword).Line)
                    Cmd = New OleDb.OleDbCommand(Str, Con)
                    Con.Open()
                    Cmd.Parameters.AddWithValue("@UserName", UserName)
                    If Cmd.ExecuteNonQuery >= 0 Then
                    Else
                        MsgBox("Element not Deleted")
                    End If
                Catch ex As Exception
                Finally
                    Close(True)
                End Try

            End Sub
#End Region '(Set|Get) This will Delete a row in the table.
#End Region
#Region "<5> [Function]{7}"
#Region "[On] |2019/07/08 11h22:880| <05.00.00> <Function> <> |.Open()|TestItem}|"' (Set|Get) This will initialise the connection and import the data.
            '''    <Summary>
            '''     (Set|Get) This will initialise the connection and import the data.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:552 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) This will initialise the connection and import the data.")>
            Public Function Open(ByVal SqlCommand As String) As TestItem
                Dim Result As New TestItem("Open(SqlCommand)", " Openning the connection line to the database.")
                If CheckConnection() = True Then
                    Con = New OleDb.OleDbConnection(Me.Line)
                    Cmd = New OleDb.OleDbCommand(SqlCommand, Con)
                    If Con.State = ConnectionState.Open Then
                        Close(True)
                    Else
                        Try
                            Con.Open()
                            Result.Status = Status.Online
                        Catch ex As Exception
                            Result.AddBug(ex, "Error while opening database", "SqlCon.Open()")
                            Result.Why += ex.Message & vbNewLine
                            Result.Status = Status.Broken
                        End Try
                    End If
                Else
                    Result.Status = Status.Broken
                    Result.Why += Log & vbNewLine
                End If
                Return Result

            End Function
#End Region '(Set|Get) This will initialise the connection and import the data.
#Region "[On] |2019/07/08 11h22:983| <05.00.01> <Function> <> |.Close()|TestItem}|"' (Set|Get) This willClosing the connection
            '''    <Summary>
            '''     (Set|Get) This willClosing the connection
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:552 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) This willClosing the connection")>
            Public Function Close(ByVal Dispose As Boolean) As TestItem
                Dim Result As New TestItem("Close()", " Closing the connection line to the database.")
                If Not IsNothing(Line) Then
                    Result.Write("The line is configured")
                    If Not IsNothing(Con) Then
                        Result.Write("Con Exist.")
                        If Con.State = ConnectionState.Closed Then
                            Result.Write("Con is already close. No further action required. Mission accomplished.")
                            Result.Status = Status.Finished
                        ElseIf Con.State = ConnectionState.Broken Then
                            Result.Write("Con is broken.")
                            Result.Why += "The connection to the data source is broken. This can occur only after the connection has been opened. A connection in this state may be closed and then re-opened." & vbNewLine
                            Result.Status = Status.Broken
                        ElseIf Con.State = ConnectionState.Connecting Then
                            Result.Write("The connection object is connecting to the data source.")
                            Result.Write("Sending command to close the connection.")
                            Con.Close()
                            If Dispose = True Then
                                Con.Dispose()
                                Result.Write("Sending command to dispose of the object.")
                            End If
                            If Con.State = ConnectionState.Closed Then
                                Result.Status = Status.Finished
                                Result.Write("The connection is closed.")
                            Else
                                Result.Status = Status.Broken
                                Result.Write("The connection will not close.")
                                Result.Why += "The connection will not close." & vbNewLine
                            End If
                        ElseIf Con.State = ConnectionState.Executing Then
                            Result.Write("The connection object is executing a command.")
                            Result.Write("Sending command to close the connection.")
                            Con.Close()
                            If Dispose = True Then
                                Con.Dispose()
                                Result.Write("Sending command to dispose of the object.")
                            End If
                            If Con.State = ConnectionState.Closed Then
                                Result.Status = Status.Finished
                                Result.Write("The connection is closed.")
                            Else
                                Result.Status = Status.Broken
                                Result.Write("The connection will not close.")
                                Result.Why += "The connection will not close." & vbNewLine
                            End If
                        ElseIf Con.State = ConnectionState.Fetching Then
                            Result.Write("The connection object is retrieving data.")
                            Result.Write("Sending command to close the connection.")
                            Con.Close()
                            If Dispose = True Then
                                Con.Dispose()
                                Result.Write("Sending command to dispose of the object.")
                            End If
                            If Con.State = ConnectionState.Closed Then
                                Result.Status = Status.Finished
                                Result.Write("The connection is closed.")
                            Else
                                Result.Status = Status.Broken
                                Result.Write("The connection will not close.")
                                Result.Why += "The connection will not close." & vbNewLine
                            End If
                        Else
                            Result.Write("Sending command to close the connection.")
                            Con.Close()
                            If Dispose = True Then
                                Con.Dispose()
                                Result.Write("Sending command to dispose of the object.")
                            End If
                            If Con.State = ConnectionState.Closed Then
                                Result.Status = Status.Finished
                                Result.Write("The connection is closed.")
                            Else
                                Result.Status = Status.Broken
                                Result.Write("The connection will not close.")
                                Result.Why += "The connection will not close." & vbNewLine
                            End If
                        End If
                    End If
                End If
                Return Result

            End Function
#End Region '(Set|Get) This willClosing the connection
#Region "[On] |2019/07/08 11h22:992| <05.00.02> <Function> <> |.List()|List(Of Users)}|"' (Set|Get) Return the entire table listed
            '''    <Summary>
            '''     (Set|Get) Return the entire table listed
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:552 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) Return the entire table listed")>
            Public Function List() As List(Of Users)
                Dim Result As New List(Of Users)
                Me.Table = New Table(Me.TableName, Me.FilePath, Me.Password, False)
                For Each Row As DataRow In Me.Table.DataTable.Rows
                    Dim Element As New Users(IIf(IsDBNull(Row.Item(0)), "", Row.Item(0)),
IIf(IsDBNull(Row.Item(1)), "", Row.Item(1)),
IIf(IsDBNull(Row.Item(2)), "", Row.Item(2)),
      IIf(IsDBNull(Row.Item(3)), False, Row.Item(3)))
                    Element.Reset(Table.Line)
                    Result.Add(Element)
                Next
                Return Result
            End Function
#End Region '(Set|Get) Return the entire table listed
#Region "[On] |2019/07/08 11h22:999| <05.00.03> <Function> <> |.SearchByName()|List(Of Users)}|"' (Set|Get) Search for each property that match the Search String.
            '''    <Summary>
            '''     (Set|Get) Search for each property that match the Search String.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:552 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) Search for each property that match the Search String.")>
            Public Shared Function SearchByName(ByVal Search As String) As List(Of Users)
                Dim Result As New List(Of Users)
                Dim C As New Users
                For Each Element As Users In C.List
                    If Element.UserName.ToLower() = Search.ToLower() Or Element.Password.ToLower() = Search.ToLower() Or Element.Email.ToLower() = Search.ToLower() Then
                        Result.Add(Element)
                    End If
                Next
                Return Result
            End Function
#End Region '(Set|Get) Search for each property that match the Search String.
#Region "[On] |2019/07/08 11h22:006| <05.00.04> <Function> <> |.SearchByID()|List(Of Users)}|"' (Set|Get) Search for each property that match the Search Id.
            '''    <Summary>
            '''     (Set|Get) Search for each property that match the Search Id.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:552 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) Search for each property that match the Search Id.")>
            Public Shared Function SearchByID(ByVal Search As Double) As List(Of Users)
                Dim Result As New List(Of Users)
                Dim C As New Users
                For Each Element As Users In C.List
                Next
                Return Result
            End Function
#End Region '(Set|Get) Search for each property that match the Search Id.
#Region "[On] |2019/07/08 11h22:012| <05.00.05> <Function> <> |.ToString()|String}|"' (Set|Get) The function ToString.
            '''    <Summary>
            '''     (Set|Get) The function ToString.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:553 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The function ToString.")>
            Public Overrides Function ToString() As String
                Return Me.UserName
            End Function
#End Region '(Set|Get) The function ToString.
#Region "[On] |2019/07/08 11h22:019| <05.00.06> <Function> <> |.CheckConnection()|Boolean}|"' (Set|Get) Evaluate the connection to the DataBase
            '''    <Summary>
            '''     (Set|Get) Evaluate the connection to the DataBase
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:553 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) Evaluate the connection to the DataBase")>
            Public Function CheckConnection() As Boolean
                ' Prepare Variables 
#Region "Prepare Variables"
                Dim Test_1 As Boolean = False ' Evaluate if the FilePath is Empty.
                Dim Test_2 As Boolean = False ' Evaluate if the File Exist.
                Dim Test_3 As Boolean = False ' Evaluate if the Directory Exist.
                Dim Test_4 As Boolean = False ' Evaluate if the Drive is Connected.
                Dim Test_5 As Boolean = False ' Evaluate if there is a Password.
                Dim Test_6 As Boolean = False ' Evaluate if Connector is nothing.
                Dim Test_7 As Boolean = False ' Evaluate if Connector Line is not empty.
                Dim Test_8 As Boolean = False ' Evaluate if the Connection is valid.
                Dim General_Status As Boolean = False ' Return the General result.
                Dim Message As String = Nothing ' Stores the process logic.
#End Region
#Region "Test 1 | Evaluate if the FilePath is Empty."
                If Not IsNothing(FilePath) Then
                    Test_1 = True
                    Message += "Test 1 <Result> |OK| The variable FilePath is not nothing."
                Else
                    Test_1 = False
                    Message += "Test 1 <Result> |PB| The variable FilePath is nothing."
                    FilePath = Nothing
                End If
#End Region
#Region "Test 2 | Evaluate if the File Exist."
                If IO.File.Exists(FilePath) Then
                    Test_2 = True
                    Message += "Test 2 <Result> |OK| The FilePath is a recognize as a File."
                Else
                    Test_2 = False
                    Message += "Test 2 <Result> |PB| The FilePath is a recognize as a File."
                End If
#End Region
#Region "Test 3 | Evaluate if the Directory Exist."
                If IO.Directory.Exists(IO.Path.GetDirectoryName(FilePath)) Then
                    Test_3 = True
                    Message += "Test 3 <Result> |OK| The Directory Exist."
                Else
                    Test_3 = False
                    Message += "Test 3 <Result> |PB| The Directory does not Exist."
                End If
#End Region
#Region "Test 4 | Evaluate if the Drive is Connected."
                Dim D As New DriveInfo(IO.Path.GetPathRoot(FilePath))
                If D.IsReady Then
                    Test_4 = True
                    Message += "Test 4 <Result> |OK| The Drive is Online."
                Else
                    Test_4 = False
                    Message += "Test 4 <Result> |PB| The Drive is Offline or Disconnected."
                End If
#End Region
#Region "Test 5 | Evaluate if there is a Password."
                If Not IsDBNull(Password) Then
                    Test_5 = True
                    Message += "Test 5 <Result> |OK| The password has been Recorded."
                Else
                    Test_5 = False
                    Message += "Test 5 <Result> |PB| No password has been stored."
                End If
#End Region
#Region "Test 6 | Evaluate if Connector is nothing."
                If Not IsNothing(Connector) Then
                    Me.Line = Me.Connector.Line
                    Test_6 = True
                    Message += "Test 6 <Result> |OK| The Connector has been initialized before."
                Else
                    Test_6 = False
                    Message += "Test 6 <Result> |PB| The Connector has not been initialized before."
                    If Test_2 = True Then
                        Me.Connector = New LineInfo(FilePath, Password)
                        Me.Line = Me.Connector.Line
                        Message += "Test 6 <Result> |Initialize Connector|"
                    End If
                End If
#End Region
#Region "Test 7 | Evaluate if Connector Line is not empty."
                If Not IsDBNull(Me.Connector.Line) Then
                    Test_7 = True
                Else
                    Test_7 = False
                End If
#End Region
#Region "Test 8 | Evaluate if the Connection is valid."
                If Test_7 = True Then
                    Try
                        Con = New OleDb.OleDbConnection(Me.Line)
                        Con.Open()
                        Test_8 = True
                        Message += "Test 8 <Result> |OK| The Connection is valid."
                    Catch ex As Exception
                        Test_8 = False
                        Message += "Test 8 <Result> |PB| The Connection is not valid. Check Password."
                    Finally
                        Con.Close()
                        Con.Dispose()
                    End Try
                End If
#End Region
                If Test_7 = True And Test_8 = True Then
                    General_Status = True
                Else
                    General_Status = False
                End If
                Log += Message & vbNewLine
                Return General_Status

            End Function
#End Region '(Set|Get) Evaluate the connection to the DataBase
#End Region
#Region "<6> [Runtime]{12}"
#Region "[On] |2019/07/08 11h22:027| <15.00.00> <Runtime> <> |.Table()|Table"' (Set|Get) The Table.
            '''    <Summary>
            '''     (Set|Get) The Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:553 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Table.")>
            Public Table As Table
#End Region '(Set|Get) The Table.
#Region "[On] |2019/07/08 11h22:131| <15.00.01> <Runtime> <> |.Line()|String"' (Set|Get) The Connection String To the Table.
            '''    <Summary>
            '''     (Set|Get) The Connection String To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:553 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Connection String To the Table.")>
            Public Line As String
#End Region '(Set|Get) The Connection String To the Table.
#Region "[On] |2019/07/08 11h22:138| <15.00.02> <Runtime> <> |.FilePath()|String"' (Set|Get) The FilePath To the Table.
            '''    <Summary>
            '''     (Set|Get) The FilePath To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:553 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The FilePath To the Table.")>
            Public FilePath As String
#End Region '(Set|Get) The FilePath To the Table.
#Region "[On] |2019/07/08 11h22:145| <15.00.03> <Runtime> <> |.Password()|String"' (Set|Get) The Password To the Table.
            '''    <Summary>
            '''     (Set|Get) The Password To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:553 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Password To the Table.")>
            Public MyPassword As String
#End Region '(Set|Get) The Password To the Table.
#Region "[On] |2019/07/08 11h22:151| <15.00.04> <Runtime> <> |.UseSQL()|Boolean"' (Set|Get) Determines if the Database Connection is of type SQL.
            '''    <Summary>
            '''     (Set|Get) Determines if the Database Connection is of type SQL.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:553 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) Determines if the Database Connection is of type SQL.")>
            Public UseSQL As Boolean
#End Region '(Set|Get) Determines if the Database Connection is of type SQL.
#Region "[On] |2019/07/08 11h22:159| <15.00.05> <Runtime> <> |.TableName()|String"' (Set|Get) The name of the Table.
            '''    <Summary>
            '''     (Set|Get) The name of the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:554 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The name of the Table.")>
            Public TableName As String
#End Region '(Set|Get) The name of the Table.
#Region "[On] |2019/07/08 11h22:166| <15.00.06> <Runtime> <> |.Con()|OleDb.OleDbConnection"' (Set|Get) The Con To the Table.
            '''    <Summary>
            '''     (Set|Get) The Con To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:554 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Con To the Table.")>
            Public Con As OleDb.OleDbConnection
#End Region '(Set|Get) The Con To the Table.
#Region "[On] |2019/07/08 11h22:179| <15.00.07> <Runtime> <> |.Cmd()|OleDb.OleDbCommand"' (Set|Get) The Cmd To the Table.
            '''    <Summary>
            '''     (Set|Get) The Cmd To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:554 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Cmd To the Table.")>
            Public Cmd As OleDb.OleDbCommand
#End Region '(Set|Get) The Cmd To the Table.
#Region "[On] |2019/07/08 11h22:189| <15.00.08> <Runtime> <> |.DataReader()|OleDb.OleDbDataReader"' (Set|Get) The DataReader To the Table.
            '''    <Summary>
            '''     (Set|Get) The DataReader To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:554 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The DataReader To the Table.")>
            Public DataReader As OleDb.OleDbDataReader
#End Region '(Set|Get) The DataReader To the Table.
#Region "[On] |2019/07/08 11h22:197| <15.00.09> <Runtime> <> |.DataAdapter()|OleDb.OleDbDataAdapter"' (Set|Get) The DataAdapter To the Table.
            '''    <Summary>
            '''     (Set|Get) The DataAdapter To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:554 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The DataAdapter To the Table.")>
            Public DataAdapter As OleDb.OleDbDataAdapter
#End Region '(Set|Get) The DataAdapter To the Table.
#Region "[On] |2019/07/08 11h22:204| <15.00.10> <Runtime> <> |.Connector()|LineInfo"' (Set|Get) The Connector To the Table.
            '''    <Summary>
            '''     (Set|Get) The Connector To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:554 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Connector To the Table.")>
            Public Connector As LineInfo
#End Region '(Set|Get) The Connector To the Table.
#Region "[On] |2019/07/08 11h22:211| <15.00.11> <Runtime> <> |.Log()|String"' (Set|Get) The Log To the Table.
            '''    <Summary>
            '''     (Set|Get) The Log To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:554 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Log To the Table.")>
            Public Log As String
#End Region '(Set|Get) The Log To the Table.
#End Region
#Region "<7> [Loader]{2}"
#Region "[On] |2019/07/08 11h22:219| <06.00.00> <Loader> <> |.Empty()|Function}|"' (Set|Get) The sub Empty.
            '''    <Summary>
            '''     (Set|Get) The sub Empty.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:558 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The sub Empty.")>
            Public Sub New()
                Reset()
            End Sub
#End Region '(Set|Get) The sub Empty.
#Region "[On] |2019/07/08 11h22:228| <06.00.01> <Loader> <> |.Filled()|Function}|"' (Set|Get) The sub Filled.
            '''    <Summary>
            '''     (Set|Get) The sub Filled.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:558 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>    ''' <param name="UserName">(Set|Get) The UserName as String.</param>
            ''' <param name="Password">(Set|Get) The Password as String.</param>
            ''' <param name="Email">(Set|Get) The Email as String.</param>
            ''' <param name="Active">(Set|Get) The Active as Boolean.</param>

            <Browsable(True), Description("(Set|Get) The sub Filled.")>
            Public Sub New(ByVal UserName As String,
ByVal Password As String,
ByVal Email As String,
ByVal Active As Boolean)
                With Me
                    Clear()
                    Reset()
                    .UserName = UserName
                    .Password = Password
                    .Email = Email
                    .Active = Active
                End With

            End Sub
#End Region '(Set|Get) The sub Filled.
#End Region
        End Class
#End Region

#Region "[On] |2019/07/08 11h22:391| <08.00.00> <Class> <> |.Initializor_Users|Class|{12} |Production Cost : 10.2|Selling Price : 25.5|"' 
        '''    <Summary>
        '''     '''    Object Name :             Public  Class Initializor_Users
        '''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
        '''    Contributor Information : ||
        '''    Creation Date :           2019/07/08 11h22:391
        '''    |Schema|
        '''    |ID| |ObjectType |{Quantity}||UnitPrice||Total
        '''    |00| |Importation|{0}||1| |0
        '''    |01| |Properties |{4}||0.8| |3.2
        '''    |02| |Enumeration|{0}||0.4| |0
        '''    |03| |Structure  |{0}||0.4| |0
        '''    |04| |Sub        |{1}||1.2| |1.2
        '''    |05| |Function   |{1}||1.6| |1.6
        '''    |06| |Runtime    |{4}||0.4| |1.6
        '''    |07| |Loader     |{2}||0.8| |1.6
        '''    |08| |Class      |{0}||2| |0
        '''    |09| |Constante  |{0}||0.4| |0
        '''    |10| |Event      |{0}||1.2| |0
        '''    |11| |Members    |{0}||0.5| |0
        '''    |12| |Parameter  |{2}||0.5| |1
        '''    |Production Cost             |10.2
        '''    |Selling Price without VAT   |25.5
        '''    |Total TVA                   |1.96
        '''    |Grand Total                 |27.46
        '''    |/Schema|
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:562 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        Public Class Initializor_Users
#Region "<1> [Property]{4}"
#Region "[On] |2019/07/08 11h22:391| <01.00.00> <Property> <Virtualized Properties> |.Users()|Users|"' (Set|Get) 
            Private _Users As Users
            '''    <Summary>
            '''     (Set|Get) 
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:562 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Virtualized Properties"), Description("(Set|Get) ")>
            Public Property Users() As Users
                Get
                    Return _Users
                End Get
                Set(ByVal Value As Users)
                    _Users = Value
                End Set
            End Property
#End Region '(Set|Get) 
#Region "[On] |2019/07/08 11h22:399| <01.00.01> <Property> <List> |.List_Users()|List(Of Users)|"' (Set|Get) 
            Private _List_Users As List(Of Users)
            '''    <Summary>
            '''     (Set|Get) 
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:562 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("List"), Description("(Set|Get) ")>
            Public Property List_Users() As List(Of Users)
                Get
                    Return _List_Users
                End Get
                Set(ByVal Value As List(Of Users))
                    _List_Users = Value
                End Set
            End Property
#End Region '(Set|Get) 
#Region "[On] |2019/07/08 11h22:408| <01.00.02> <Property> <Portfolio> |.Portfolio()|List(Of Object)|"' (Set|Get) 
            Private Shared _Portfolio As List(Of Object)
            '''    <Summary>
            '''     (Set|Get) 
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:563 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Portfolio"), Description("(Set|Get) ")>
            Public Shared Property Portfolio() As List(Of Object)
                Get
                    Return _Portfolio
                End Get
                Set(ByVal Value As List(Of Object))
                    _Portfolio = Value
                End Set
            End Property
#End Region '(Set|Get) 
#Region "[On] |2019/07/08 11h22:414| <01.00.03> <Property> <DataBase> |.DataBase()|SmartCoder.M_FileManager.DataBase|"' (Set|Get) 
            Private Shared _DataBase As SmartCoder.M_FileManager.DataBase
            '''    <Summary>
            '''     (Set|Get) 
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:563 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("DataBase"), Description("(Set|Get) ")>
            Public Shared Property DataBase() As SmartCoder.M_FileManager.DataBase
                Get
                    Return _DataBase
                End Get
                Set(ByVal Value As SmartCoder.M_FileManager.DataBase)
                    _DataBase = Value
                End Set
            End Property
#End Region '(Set|Get) 
#End Region
#Region "<4> [Sub]{1}"
#Region "[On] |2019/07/08 11h22:420| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class properties element.
            '''    <Summary>
            '''     (Set|Get) This will reinitialize the class properties element.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:563 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) This will reinitialize the class properties element.")>
            Public Sub Clear()
                With Me
                    .Users = New Users
                    .List_Users = New List(Of Users)
                    Portfolio = New List(Of Object)
                    DataBase = New SmartCoder.M_FileManager.DataBase
                End With
            End Sub
#End Region '(Set|Get) This will reinitialize the class properties element.
#End Region
#Region "<5> [Function]{1}"
#Region "[On] |2019/07/08 11h22:426| <05.00.00> <Function> <> |.CheckConnection()|Boolean}|"' (Set|Get) Evaluate the connection to the DataBase
            '''    <Summary>
            '''     (Set|Get) Evaluate the connection to the DataBase
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:563 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) Evaluate the connection to the DataBase")>
            Public Function CheckConnection() As Boolean
                ' Prepare Variables 
#Region "Prepare Variables"
                Dim Test_1 As Boolean = False ' Evaluate if the FilePath is Empty.
                Dim Test_2 As Boolean = False ' Evaluate if the File Exist.
                Dim Test_3 As Boolean = False ' Evaluate if the Directory Exist.
                Dim Test_4 As Boolean = False ' Evaluate if the Drive is Connected.
                Dim Test_5 As Boolean = False ' Evaluate if there is a Password.
                Dim Test_6 As Boolean = False ' Evaluate if Connector is nothing.
                Dim Test_7 As Boolean = False ' Evaluate if Connector Line is not empty.
                Dim Test_8 As Boolean = False ' Evaluate if the Connection is valid.
                Dim General_Status As Boolean = False ' Return the General result.
                Dim Message As String = Nothing ' Stores the process logic.
#End Region
#Region "Test 1 | Evaluate if the FilePath is Empty."
                If Not IsNothing(FilePath) Then
                    Test_1 = True
                    Message += "Test 1 <Result> |OK| The variable FilePath is not nothing."
                Else
                    Test_1 = False
                    Message += "Test 1 <Result> |PB| The variable FilePath is nothing."
                    FilePath = Nothing
                End If
#End Region
#Region "Test 2 | Evaluate if the File Exist."
                If IO.File.Exists(FilePath) Then
                    Test_2 = True
                    Message += "Test 2 <Result> |OK| The FilePath is a recognize as a File."
                Else
                    Test_2 = False
                    Message += "Test 2 <Result> |PB| The FilePath is a recognize as a File."
                End If
#End Region
#Region "Test 3 | Evaluate if the Directory Exist."
                If IO.Directory.Exists(IO.Path.GetDirectoryName(FilePath)) Then
                    Test_3 = True
                    Message += "Test 3 <Result> |OK| The Directory Exist."
                Else
                    Test_3 = False
                    Message += "Test 3 <Result> |PB| The Directory does not Exist."
                End If
#End Region
#Region "Test 4 | Evaluate if the Drive is Connected."
                Dim D As New DriveInfo(IO.Path.GetPathRoot(FilePath))
                If D.IsReady Then
                    Test_4 = True
                    Message += "Test 4 <Result> |OK| The Drive is Online."
                Else
                    Test_4 = False
                    Message += "Test 4 <Result> |PB| The Drive is Offline or Disconnected."
                End If
#End Region
#Region "Test 5 | Evaluate if there is a Password."
                If Not IsDBNull(Password) Then
                    Test_5 = True
                    Message += "Test 5 <Result> |OK| The password has been Recorded."
                Else
                    Test_5 = False
                    Message += "Test 5 <Result> |PB| No password has been stored."
                End If
#End Region
#Region "Test 6 | Evaluate if Connector is nothing."
                If Not IsNothing(Connector) Then
                    Me.Line = Me.Connector.Line
                    Test_6 = True
                    Message += "Test 6 <Result> |OK| The Connector has been initialized before."
                Else
                    Test_6 = False
                    Message += "Test 6 <Result> |PB| The Connector has not been initialized before."
                    If Test_2 = True Then
                        Me.Connector = New LineInfo(FilePath, Password)
                        Me.Line = Me.Connector.Line
                        Message += "Test 6 <Result> |Initialize Connector|"
                    End If
                End If
#End Region
#Region "Test 7 | Evaluate if Connector Line is not empty."
                If Not IsDBNull(Me.Connector.Line) Then
                    Test_7 = True
                Else
                    Test_7 = False
                End If
#End Region
#Region "Test 8 | Evaluate if the Connection is valid."
                If Test_7 = True Then
                    Dim Con As New OleDb.OleDbConnection(Me.Line)
                    Try
                        Con.Open()
                        Test_8 = True
                        Message += "Test 8 <Result> |OK| The Connection is valid."
                    Catch ex As Exception
                        Test_8 = False
                        Message += "Test 8 <Result> |PB| The Connection is not valid. Check Password."
                    Finally
                        Con.Close()
                        Con.Dispose()
                    End Try
                End If
#End Region
                If Test_7 = True And Test_8 = True Then
                    General_Status = True
                Else
                    General_Status = False
                End If
                Return General_Status

            End Function
#End Region '(Set|Get) Evaluate the connection to the DataBase
#End Region
#Region "<6> [Runtime]{4}"
#Region "[On] |2019/07/08 11h22:432| <15.00.00> <Runtime> <> |.Line()|String"' (Set|Get) The Connection String To the Table.
            '''    <Summary>
            '''     (Set|Get) The Connection String To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:563 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Connection String To the Table.")>
            Public Line As String
#End Region '(Set|Get) The Connection String To the Table.
#Region "[On] |2019/07/08 11h22:440| <15.00.01> <Runtime> <> |.FilePath()|String"' (Set|Get) The FilePath To the Table.
            '''    <Summary>
            '''     (Set|Get) The FilePath To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:563 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The FilePath To the Table.")>
            Public FilePath As String
#End Region '(Set|Get) The FilePath To the Table.
#Region "[On] |2019/07/08 11h22:449| <15.00.02> <Runtime> <> |.Password()|String"' (Set|Get) The Password To the Table.
            '''    <Summary>
            '''     (Set|Get) The Password To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:564 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Password To the Table.")>
            Public Password As String
#End Region '(Set|Get) The Password To the Table.
#Region "[On] |2019/07/08 11h22:456| <15.00.03> <Runtime> <> |.Connector()|LineInfo"' (Set|Get) The Connector To the Table.
            '''    <Summary>
            '''     (Set|Get) The Connector To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:564 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Connector To the Table.")>
            Public Connector As LineInfo
#End Region '(Set|Get) The Connector To the Table.
#End Region
#Region "<7> [Loader]{2}"
#Region "[On] |2019/07/08 11h22:470| <06.00.00> <Loader> <> |.Empty()|Function}|"' (Set|Get) The sub Empty.
            '''    <Summary>
            '''     (Set|Get) The sub Empty.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:564 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The sub Empty.")>
            Public Sub New()
                Clear()
            End Sub
#End Region '(Set|Get) The sub Empty.
#Region "[On] |2019/07/08 11h22:471| <06.00.01> <Loader> <> |.Filled()|Function}|"' (Set|Get) The sub Filled.
            '''    <Summary>
            '''     (Set|Get) The sub Filled.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 11h22:564 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>    ''' <param name="FilePath">The initial File Path</param>
            ''' <param name="Password">The password</param>

            <Browsable(True), Description("(Set|Get) The sub Filled.")>
            Public Sub New(ByVal FilePath As String,
Optional ByVal Password As String = """")
                With Me
                    Clear()
                    .Users = New Users
                    .List_Users = New List(Of Users)
                    Portfolio = New List(Of Object)
                    DataBase = New SmartCoder.M_FileManager.DataBase
                End With
                Portfolio = New List(Of Object)
                FilePath = FilePath
                Password = Password
                Line = Line
                Dim M As New LineInfo(FilePath, Password)
                My.Settings.Db_Users_FilePath = FilePath
                My.Settings.Db_Users_Password = Password
                My.Settings.Db_Users_Line = Line
                My.Settings.Save()

                With Users
                    .Reset(M)
                End With
                List_Users = New List(Of Users)
                List_Users = Users.List()

            End Sub
#End Region '(Set|Get) The sub Filled.
#End Region
        End Class
#End Region

#End Region
    End Class
#End Region

End Module
