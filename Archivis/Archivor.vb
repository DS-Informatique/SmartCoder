Imports System.ComponentModel
Imports System.IO
Imports SmartCoder

Public Module Archivor

#Region "[On] |2019/07/11 16h54:255| <08.00.00> <Class> <> |.Archives|Class|{4} |Production Cost : 302.6|Selling Price : 756.5|"' 
    '''    <Summary>
    '''     '''    Object Name :             Public  Class Archives
    '''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
    '''    Contributor Information : ||
    '''    Creation Date :           2019/07/11 23h25:910
    '''    |Schema|
    '''    |ID| |ObjectType |{Quantity}||UnitPrice||Total
    '''    |00| |Importation|{0}||1| |0
    '''    |01| |Properties |{88}||0.8| |70.4
    '''    |02| |Enumeration|{5}||0.4| |2
    '''    |03| |Structure  |{0}||0.4| |0
    '''    |04| |Sub        |{26}||1.2| |31.2
    '''    |05| |Function   |{38}||1.6| |60.8
    '''    |06| |Runtime    |{64}||0.4| |25.6
    '''    |07| |Loader     |{12}||0.8| |9.6
    '''    |08| |Class      |{6}||2| |12
    '''    |09| |Constante  |{0}||0.4| |0
    '''    |10| |Event      |{0}||1.2| |0
    '''    |11| |Members    |{76}||0.5| |38
    '''    |12| |Parameter  |{106}||0.5| |53
    '''    |Production Cost             |302.6
    '''    |Selling Price without VAT   |756.5
    '''    |Total TVA                   |58.25
    '''    |Grand Total                 |814.75
    '''    |/Schema|
    '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
    '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
    '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
    '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:802 </Published>
    '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
    '''    </Summary>
    Public Class Archives
#Region "[On] |2019/07/11 23h25:910| <08.00.00> <Class> <> |.VirtualClass|Class|"' 
#Region "[On] |2019/07/11 23h30:274| <08.00.00> <Class> <> |.Archives_Data|Class|{33} |Production Cost : 37.3|Selling Price : 93.25|"' Class created automatically by SmartOffice (c)Copyright 2019.
        '''    <Summary>
        '''     Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Archives_Data
        '''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
        '''    Contributor Information : ||
        '''    Creation Date :           2019/07/11 23h30:274
        '''    |Schema|
        '''    |ID| |ObjectType |{Quantity}||UnitPrice||Total
        '''    |00| |Importation|{0}||1| |0
        '''    |01| |Properties |{6}||0.8| |4.8
        '''    |02| |Enumeration|{1}||0.4| |0.4
        '''    |03| |Structure  |{0}||0.4| |0
        '''    |04| |Sub        |{5}||1.2| |6
        '''    |05| |Function   |{7}||1.6| |11.2
        '''    |06| |Runtime    |{12}||0.4| |4.8
        '''    |07| |Loader     |{2}||0.8| |1.6
        '''    |08| |Class      |{0}||2| |0
        '''    |09| |Constante  |{0}||0.4| |0
        '''    |10| |Event      |{0}||1.2| |0
        '''    |11| |Members    |{6}||0.5| |3
        '''    |12| |Parameter  |{11}||0.5| |5.5
        '''    |Production Cost             |37.3
        '''    |Selling Price without VAT   |93.25
        '''    |Total TVA                   |7.18
        '''    |Grand Total                 |100.43
        '''    |/Schema|
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:802 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        Public Class Archives_Data
#Region "<1> [Property]{6}"
#Region "[On] |2019/07/11 23h30:277| <01.00.00> <Property> <Columns> |.ID()|Integer|"' (Set|Get) The ID as Integer.
            Private _ID As Integer
            '''    <Summary>
            '''     (Set|Get) The ID as Integer.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:802 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The ID as Integer.")>
            Public Property ID() As Integer
                Get
                    Return _ID
                End Get
                Set(ByVal Value As Integer)
                    _ID = Value
                End Set
            End Property
#End Region '(Set|Get) The ID as Integer.

#Region "[On] |2019/07/11 23h30:411| <01.00.01> <Property> <Columns> |.Save_Entry()|String|"' (Set|Get) The Save_Entry as String.
            Private _Save_Entry As String
            '''    <Summary>
            '''     (Set|Get) The Save_Entry as String.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:804 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Save_Entry as String.")>
            Public Property Save_Entry() As String
                Get
                    Return _Save_Entry
                End Get
                Set(ByVal Value As String)
                    _Save_Entry = Value
                End Set
            End Property
#End Region '(Set|Get) The Save_Entry as String.

#Region "[On] |2019/07/11 23h30:419| <01.00.02> <Property> <Columns> |.Root()|String|"' (Set|Get) The Root as String.
            Private _Root As String
            '''    <Summary>
            '''     (Set|Get) The Root as String.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:804 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Root as String.")>
            Public Property Root() As String
                Get
                    Return _Root
                End Get
                Set(ByVal Value As String)
                    _Root = Value
                End Set
            End Property
#End Region '(Set|Get) The Root as String.

#Region "[On] |2019/07/11 23h30:427| <01.00.03> <Property> <Columns> |.Origine()|String|"' (Set|Get) The Origine as String.
            Private _Origine As String
            '''    <Summary>
            '''     (Set|Get) The Origine as String.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:804 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Origine as String.")>
            Public Property Origine() As String
                Get
                    Return _Origine
                End Get
                Set(ByVal Value As String)
                    _Origine = Value
                End Set
            End Property
#End Region '(Set|Get) The Origine as String.

#Region "[On] |2019/07/11 23h30:433| <01.00.04> <Property> <Columns> |.Size()|Double|"' (Set|Get) The Size as Double.
            Private _Size As Double
            '''    <Summary>
            '''     (Set|Get) The Size as Double.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:805 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Size as Integer.")>
            Public Property Size() As Double
                Get
                    Return _Size
                End Get
                Set(ByVal Value As Double)
                    _Size = Value
                End Set
            End Property
#End Region '(Set|Get) The Size as Double.

#Region "[On] |2019/07/11 23h30:439| <01.00.05> <Property> <Columns> |.Etat()|String|"' (Set|Get) The Etat as String.
            Private _Etat As String
            '''    <Summary>
            '''     (Set|Get) The Etat as String.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:805 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Etat as String.")>
            Public Property Etat() As String
                Get
                    Return _Etat
                End Get
                Set(ByVal Value As String)
                    _Etat = Value
                End Set
            End Property
#End Region '(Set|Get) The Etat as String.

#End Region
#Region "<2> [Enumeration]{1}"
#Region "[On] |2019/07/11 23h30:446| <02.00.00> <Enumeration> <> |.Schema()|Enumeration{5}|"' (Set|Get) The enumeration of Schema.
            '''    <Summary>
            '''     (Set|Get) The enumeration of Schema.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:805 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The enumeration of Schema.")>
            Enum Schema
                ''' <summary>(Set|Get) The ID as Integer.</summary>
                [ID] = 0
                ''' <summary>(Set|Get) The Save_Entry as String.</summary>
                [Save_Entry] = 1
                ''' <summary>(Set|Get) The Root as String.</summary>
                [Root] = 2
                ''' <summary>(Set|Get) The Origine as String.</summary>
                [Origine] = 3
                ''' <summary>(Set|Get) The Size as Integer.</summary>
                [Size] = 4
                ''' <summary>(Set|Get) The Etat as String.</summary>
                [Etat] = 5
            End Enum
#End Region '(Set|Get) The enumeration of Schema.

#End Region
#Region "<4> [Sub]{5}"
#Region "[On] |2019/07/11 23h30:570| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
            '''    <Summary>
            '''     (Set|Get) This will reinitialize the class element.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:805 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) This will reinitialize the class element.")>
            Public Sub Clear()
                With Me
                    .ID = 0
                    .Save_Entry = ""
                    .Root = Nothing
                    .Origine = Nothing
                    .Size = 0
                    .Etat = Nothing
                End With
            End Sub
#End Region '(Set|Get) This will reinitialize the class element.

#Region "[On] |2019/07/11 23h30:692| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
            '''    <Summary>
            '''     (Set|Get) This will reinitialize the variables of this class.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:805 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) This will reinitialize the variables of this class.")>
            Public Sub Reset(Optional ByVal Connector As LineInfo = Nothing)
                If Not IsNothing(Connector) Then
                    Me.Connector = Connector
                    Me.FilePath = ""
                    Me.Password = ""
                    Me.Line = ""
                    If Connector.Status <> Status.Broken Then
                        FilePath = Connector.FilePath
                        Password = Connector.Password
                        Me.Connector = Connector
                        TableName = "Archives_Data"
                        Line = Connector.Line
                        UseSQL = False
                    Else
                        FilePath = My.Settings.Db_Backup_FilePath
                        Password = My.Settings.Db_Backup_Password
                        Me.Line = My.Settings.Db_Backup_Line
                        TableName = "Archives_Data"
                        UseSQL = False
                    End If
                Else
                    If IsNothing(FilePath) Then
                        FilePath = My.Settings.Db_Backup_FilePath
                    End If
                    If FilePath.Length < 1 Then
                        FilePath = My.Settings.Db_Backup_FilePath
                    End If
                    FilePath = My.Settings.Db_Backup_FilePath
                    Password = My.Settings.Db_Backup_Password
                    Me.Line = My.Settings.Db_Backup_Line
                    TableName = "Archives_Data"
                    UseSQL = False
                End If

            End Sub
#End Region '(Set|Get) This will reinitialize the variables of this class.

#Region "[On] |2019/07/11 23h30:709| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
            '''    <Summary>
            '''     (Set|Get) This will add a new row in the table.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:805 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) This will add a new row in the table.")>
            Public Sub Add()
                Try
                    Dim Str As String = Nothing
                    Str = "Insert Into [Archives_Data] (
`ID`, 
`Save_Entry`, 
`Root`, 
`Origine`, 
`Size`, 
`Etat`) Values (@0, @1, @2, @3, @4, @5)"
                    Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                    Cmd = New OleDb.OleDbCommand(Str, Con)
                    Con.Open()
                    Cmd.Parameters.AddWithValue("@0", Me.ID)
                    Cmd.Parameters.AddWithValue("@1", Me.Save_Entry)
                    Cmd.Parameters.AddWithValue("@2", Me.Root)
                    Cmd.Parameters.AddWithValue("@3", Me.Origine)
                    Cmd.Parameters.AddWithValue("@4", Me.Size)
                    Cmd.Parameters.AddWithValue("@5", Me.Etat)
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

#Region "[On] |2019/07/11 23h30:715| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
            '''    <Summary>
            '''     (Set|Get) This will update a row in the table.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:805 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) This will update a row in the table.")>
            Public Sub Save()
                Try
                    Dim Str As String = Nothing
                    Str = "UPDATE [Archives_Data] SET Save_Entry = @Save_Entry, Root = @Root, Origine = @Origine, Size = @Size, Etat = @Etat WHERE ID = @ID"
                    Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                    Cmd = New OleDb.OleDbCommand(Str, Con)
                    Con.Open()
                    Cmd.Parameters.AddWithValue("@Save_Entry", Save_Entry)
                    Cmd.Parameters.AddWithValue("@Root", Root)
                    Cmd.Parameters.AddWithValue("@Origine", Origine)
                    Cmd.Parameters.AddWithValue("@Size", Size)
                    Cmd.Parameters.AddWithValue("@Etat", Etat)
                    Cmd.Parameters.AddWithValue("@ID", ID)
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

#Region "[On] |2019/07/11 23h30:723| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
            '''    <Summary>
            '''     (Set|Get) This will Delete a row in the table.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:806 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) This will Delete a row in the table.")>
            Public Sub Delete()
                Try
                    Dim Str As String = Nothing
                    Str = "Delete From [Archives_Data] WHERE ID =@ID"
                    Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                    Cmd = New OleDb.OleDbCommand(Str, Con)
                    Con.Open()
                    Cmd.Parameters.AddWithValue("@ID", ID)
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
#Region "[On] |2019/07/11 23h30:731| <05.00.00> <Function> <> |.Open()|TestItem}|"' (Set|Get) This will initialise the connection and import the data.
            '''    <Summary>
            '''     (Set|Get) This will initialise the connection and import the data.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:806 </Published>
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

#Region "[On] |2019/07/11 23h30:888| <05.00.01> <Function> <> |.Close()|TestItem}|"' (Set|Get) This willClosing the connection
            '''    <Summary>
            '''     (Set|Get) This willClosing the connection
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:806 </Published>
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

#Region "[On] |2019/07/11 23h30:905| <05.00.02> <Function> <> |.List()|List(Of Archives_Data)}|"' (Set|Get) Return the entire table listed
            '''    <Summary>
            '''     (Set|Get) Return the entire table listed
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:806 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) Return the entire table listed")>
            Public Function List() As List(Of Archives_Data)
                Dim Result As New List(Of Archives_Data)
                Me.Table = New Table(Me.TableName, Me.FilePath, Me.Password, False)
                For Each Row As DataRow In Me.Table.DataTable.Rows
                    Dim Element As New Archives_Data(IIf(IsDBNull(Row.Item(0)), 0, Row.Item(0)),
IIf(IsDBNull(Row.Item(1)), 0, Row.Item(1)),
IIf(IsDBNull(Row.Item(2)), "", Row.Item(2)),
IIf(IsDBNull(Row.Item(3)), "", Row.Item(3)),
IIf(IsDBNull(Row.Item(4)), 0, Row.Item(4)),
      IIf(IsDBNull(Row.Item(5)), "", Row.Item(5)))
                    Element.Reset(Table.Line)
                    Result.Add(Element)
                Next
                Return Result
            End Function
#End Region '(Set|Get) Return the entire table listed

#Region "[On] |2019/07/11 23h30:915| <05.00.03> <Function> <> |.SearchByName()|List(Of Archives_Data)}|"' (Set|Get) Search for each property that match the Search String.
            '''    <Summary>
            '''     (Set|Get) Search for each property that match the Search String.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:806 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) Search for each property that match the Search String.")>
            Public Shared Function SearchByName(ByVal Search As String) As List(Of Archives_Data)
                Dim Result As New List(Of Archives_Data)
                Dim C As New Archives_Data
                For Each Element As Archives_Data In C.List
                    If Element.Root.ToLower() = Search.ToLower() Or Element.Origine.ToLower() = Search.ToLower() Or Element.Etat.ToLower() = Search.ToLower() Then
                        Result.Add(Element)
                    End If
                Next
                Return Result
            End Function
#End Region '(Set|Get) Search for each property that match the Search String.

#Region "[On] |2019/07/11 23h30:924| <05.00.04> <Function> <> |.SearchByID()|List(Of Archives_Data)}|"' (Set|Get) Search for each property that match the Search Id.
            '''    <Summary>
            '''     (Set|Get) Search for each property that match the Search Id.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:806 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) Search for each property that match the Search Id.")>
            Public Shared Function SearchByID(ByVal Search As Double) As List(Of Archives_Data)
                Dim Result As New List(Of Archives_Data)
                Dim C As New Archives_Data
                For Each Element As Archives_Data In C.List
                    If Val(Element.ID) = Search Or Val(Element.Size) = Search Then
                        Result.Add(Element)
                    End If
                Next
                Return Result
            End Function
#End Region '(Set|Get) Search for each property that match the Search Id.

#Region "[On] |2019/07/11 23h30:934| <05.00.05> <Function> <> |.ToString()|String}|"' (Set|Get) The function ToString.
            '''    <Summary>
            '''     (Set|Get) The function ToString.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:806 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The function ToString.")>
            Public Overrides Function ToString() As String
                Return Me.ID
            End Function
#End Region '(Set|Get) The function ToString.

#Region "[On] |2019/07/11 23h30:943| <05.00.06> <Function> <> |.CheckConnection()|Boolean}|"' (Set|Get) Evaluate the connection to the DataBase
            '''    <Summary>
            '''     (Set|Get) Evaluate the connection to the DataBase
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:806 </Published>
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
#Region "[On] |2019/07/11 23h30:955| <15.00.00> <Runtime> <> |.Table()|Table"' (Set|Get) The Table.
            '''    <Summary>
            '''     (Set|Get) The Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:807 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Table.")>
            Public Table As Table
#End Region '(Set|Get) The Table.

#Region "[On] |2019/07/11 23h30:102| <15.00.01> <Runtime> <> |.Line()|String"' (Set|Get) The Connection String To the Table.
            '''    <Summary>
            '''     (Set|Get) The Connection String To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:807 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Connection String To the Table.")>
            Public Line As String
#End Region '(Set|Get) The Connection String To the Table.

#Region "[On] |2019/07/11 23h30:112| <15.00.02> <Runtime> <> |.FilePath()|String"' (Set|Get) The FilePath To the Table.
            '''    <Summary>
            '''     (Set|Get) The FilePath To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:807 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The FilePath To the Table.")>
            Public FilePath As String
#End Region '(Set|Get) The FilePath To the Table.

#Region "[On] |2019/07/11 23h30:122| <15.00.03> <Runtime> <> |.Password()|String"' (Set|Get) The Password To the Table.
            '''    <Summary>
            '''     (Set|Get) The Password To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:807 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Password To the Table.")>
            Public Password As String
#End Region '(Set|Get) The Password To the Table.

#Region "[On] |2019/07/11 23h30:131| <15.00.04> <Runtime> <> |.UseSQL()|Boolean"' (Set|Get) Determines if the Database Connection is of type SQL.
            '''    <Summary>
            '''     (Set|Get) Determines if the Database Connection is of type SQL.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:807 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) Determines if the Database Connection is of type SQL.")>
            Public UseSQL As Boolean
#End Region '(Set|Get) Determines if the Database Connection is of type SQL.

#Region "[On] |2019/07/11 23h30:141| <15.00.05> <Runtime> <> |.TableName()|String"' (Set|Get) The name of the Table.
            '''    <Summary>
            '''     (Set|Get) The name of the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:807 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The name of the Table.")>
            Public TableName As String
#End Region '(Set|Get) The name of the Table.

#Region "[On] |2019/07/11 23h30:152| <15.00.06> <Runtime> <> |.Con()|OleDb.OleDbConnection"' (Set|Get) The Con To the Table.
            '''    <Summary>
            '''     (Set|Get) The Con To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:807 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Con To the Table.")>
            Public Con As OleDb.OleDbConnection
#End Region '(Set|Get) The Con To the Table.

#Region "[On] |2019/07/11 23h30:174| <15.00.07> <Runtime> <> |.Cmd()|OleDb.OleDbCommand"' (Set|Get) The Cmd To the Table.
            '''    <Summary>
            '''     (Set|Get) The Cmd To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:807 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Cmd To the Table.")>
            Public Cmd As OleDb.OleDbCommand
#End Region '(Set|Get) The Cmd To the Table.

#Region "[On] |2019/07/11 23h30:184| <15.00.08> <Runtime> <> |.DataReader()|OleDb.OleDbDataReader"' (Set|Get) The DataReader To the Table.
            '''    <Summary>
            '''     (Set|Get) The DataReader To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:808 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The DataReader To the Table.")>
            Public DataReader As OleDb.OleDbDataReader
#End Region '(Set|Get) The DataReader To the Table.

#Region "[On] |2019/07/11 23h30:194| <15.00.09> <Runtime> <> |.DataAdapter()|OleDb.OleDbDataAdapter"' (Set|Get) The DataAdapter To the Table.
            '''    <Summary>
            '''     (Set|Get) The DataAdapter To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:808 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The DataAdapter To the Table.")>
            Public DataAdapter As OleDb.OleDbDataAdapter
#End Region '(Set|Get) The DataAdapter To the Table.

#Region "[On] |2019/07/11 23h30:204| <15.00.10> <Runtime> <> |.Connector()|LineInfo"' (Set|Get) The Connector To the Table.
            '''    <Summary>
            '''     (Set|Get) The Connector To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:808 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Connector To the Table.")>
            Public Connector As LineInfo
#End Region '(Set|Get) The Connector To the Table.

#Region "[On] |2019/07/11 23h30:214| <15.00.11> <Runtime> <> |.Log()|String"' (Set|Get) The Log To the Table.
            '''    <Summary>
            '''     (Set|Get) The Log To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:808 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Log To the Table.")>
            Public Log As String
#End Region '(Set|Get) The Log To the Table.

#End Region
#Region "<7> [Loader]{2}"
#Region "[On] |2019/07/11 23h30:225| <06.00.00> <Loader> <> |.Empty()|Function}|"' (Set|Get) The sub Empty.
            '''    <Summary>
            '''     (Set|Get) The sub Empty.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:808 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The sub Empty.")>
            Public Sub New()
                Reset()
            End Sub
#End Region '(Set|Get) The sub Empty.

#Region "[On] |2019/07/11 23h30:240| <06.00.01> <Loader> <> |.Filled()|Function}|"' (Set|Get) The sub Filled.
            '''    <Summary>
            '''     (Set|Get) The sub Filled.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:812 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>    ''' <param name="ID">(Set|Get) The ID as Integer.</param>
            ''' <param name="Save_Entry">(Set|Get) The Save_Entry as String.</param>
            ''' <param name="Root">(Set|Get) The Root as String.</param>
            ''' <param name="Origine">(Set|Get) The Origine as String.</param>
            ''' <param name="Size">(Set|Get) The Size as Integer.</param>
            ''' <param name="Etat">(Set|Get) The Etat as String.</param>

            <Browsable(True), Description("(Set|Get) The sub Filled.")>
            Public Sub New(ByVal ID As Integer,
ByVal Save_Entry As String,
ByVal Root As String,
ByVal Origine As String,
ByVal Size As Integer,
ByVal Etat As String)
                With Me
                    Clear()
                    Reset()
                    .ID = ID
                    .Save_Entry = Save_Entry
                    .Root = Root
                    .Origine = Origine
                    .Size = Size
                    .Etat = Etat
                End With

            End Sub
#End Region '(Set|Get) The sub Filled.

#End Region
        End Class
#End Region

#Region "[On] |2019/07/11 23h30:440| <08.00.00> <Class> <> |.Backup|Class|{33} |Production Cost : 37.3|Selling Price : 93.25|"' Class created automatically by SmartOffice (c)Copyright 2019.
        '''    <Summary>
        '''     Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Backup
        '''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
        '''    Contributor Information : ||
        '''    Creation Date :           2019/07/11 23h30:440
        '''    |Schema|
        '''    |ID| |ObjectType |{Quantity}||UnitPrice||Total
        '''    |00| |Importation|{0}||1| |0
        '''    |01| |Properties |{6}||0.8| |4.8
        '''    |02| |Enumeration|{1}||0.4| |0.4
        '''    |03| |Structure  |{0}||0.4| |0
        '''    |04| |Sub        |{5}||1.2| |6
        '''    |05| |Function   |{7}||1.6| |11.2
        '''    |06| |Runtime    |{12}||0.4| |4.8
        '''    |07| |Loader     |{2}||0.8| |1.6
        '''    |08| |Class      |{0}||2| |0
        '''    |09| |Constante  |{0}||0.4| |0
        '''    |10| |Event      |{0}||1.2| |0
        '''    |11| |Members    |{6}||0.5| |3
        '''    |12| |Parameter  |{11}||0.5| |5.5
        '''    |Production Cost             |37.3
        '''    |Selling Price without VAT   |93.25
        '''    |Total TVA                   |7.18
        '''    |Grand Total                 |100.43
        '''    |/Schema|
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:816 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        Public Class Backup
#Region "<1> [Property]{6}"
#Region "[On] |2019/07/11 23h30:441| <01.00.00> <Property> <Columns> |.ID()|Integer|"' (Set|Get) The ID as Integer.
            Private _ID As Integer
            '''    <Summary>
            '''     (Set|Get) The ID as Integer.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:816 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The ID as Integer.")>
            Public Property ID() As Integer
                Get
                    Return _ID
                End Get
                Set(ByVal Value As Integer)
                    _ID = Value
                End Set
            End Property
#End Region '(Set|Get) The ID as Integer.

#Region "[On] |2019/07/11 23h30:450| <01.00.01> <Property> <Columns> |.File()|String|"' (Set|Get) The File as String.
            Private _File As String
            '''    <Summary>
            '''     (Set|Get) The File as String.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:816 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The File as String.")>
            Public Property File() As String
                Get
                    Return _File
                End Get
                Set(ByVal Value As String)
                    _File = Value
                End Set
            End Property
#End Region '(Set|Get) The File as String.

#Region "[On] |2019/07/11 23h30:458| <01.00.02> <Property> <Columns> |.DateSaved()|DateTime|"' (Set|Get) The DateSaved as DateTime.
            Private _DateSaved As DateTime
            '''    <Summary>
            '''     (Set|Get) The DateSaved as DateTime.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:816 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The DateSaved as DateTime.")>
            Public Property DateSaved() As DateTime
                Get
                    Return _DateSaved
                End Get
                Set(ByVal Value As DateTime)
                    _DateSaved = Value
                End Set
            End Property
#End Region '(Set|Get) The DateSaved as DateTime.

#Region "[On] |2019/07/11 23h30:467| <01.00.03> <Property> <Columns> |.Size()|Double|"' (Set|Get) The Size as Double.
            Private _Size As Double
            '''    <Summary>
            '''     (Set|Get) The Size as Double.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:816 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Size as Double.")>
            Public Property Size() As Double
                Get
                    Return _Size
                End Get
                Set(ByVal Value As Double)
                    _Size = Value
                End Set
            End Property
#End Region '(Set|Get) The Size as Double.

#Region "[On] |2019/07/11 23h30:476| <01.00.04> <Property> <Columns> |.Compressed()|Boolean|"' (Set|Get) The Compressed as Boolean.
            Private _Compressed As Boolean
            '''    <Summary>
            '''     (Set|Get) The Compressed as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:818 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Compressed as Boolean.")>
            Public Property Compressed() As Boolean
                Get
                    Return _Compressed
                End Get
                Set(ByVal Value As Boolean)
                    _Compressed = Value
                End Set
            End Property
#End Region '(Set|Get) The Compressed as Boolean.

#Region "[On] |2019/07/11 23h30:485| <01.00.05> <Property> <Columns> |.Profile()|String|"' (Set|Get) The Profile as String.
            Private _Profile As String
            '''    <Summary>
            '''     (Set|Get) The Profile as String.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:819 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Profile as String.")>
            Public Property Profile() As String
                Get
                    Return _Profile
                End Get
                Set(ByVal Value As String)
                    _Profile = Value
                End Set
            End Property
#End Region '(Set|Get) The Profile as String.

#End Region
#Region "<2> [Enumeration]{1}"
#Region "[On] |2019/07/11 23h30:495| <02.00.00> <Enumeration> <> |.Schema()|Enumeration{5}|"' (Set|Get) The enumeration of Schema.
            '''    <Summary>
            '''     (Set|Get) The enumeration of Schema.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:819 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The enumeration of Schema.")>
            Enum Schema
                ''' <summary>(Set|Get) The ID as Integer.</summary>
                [ID] = 0
                ''' <summary>(Set|Get) The File as String.</summary>
                [File] = 1
                ''' <summary>(Set|Get) The DateSaved as DateTime.</summary>
                [DateSaved] = 2
                ''' <summary>(Set|Get) The Size as Double.</summary>
                [Size] = 3
                ''' <summary>(Set|Get) The Compressed as Boolean.</summary>
                [Compressed] = 4
                ''' <summary>(Set|Get) The Profile as String.</summary>
                [Profile] = 5
            End Enum
#End Region '(Set|Get) The enumeration of Schema.

#End Region
#Region "<4> [Sub]{5}"
#Region "[On] |2019/07/11 23h30:504| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
            '''    <Summary>
            '''     (Set|Get) This will reinitialize the class element.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:819 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) This will reinitialize the class element.")>
            Public Sub Clear()
                With Me
                    .ID = 0
                    .File = Nothing
                    .DateSaved = New DateTime
                    .Size = 0
                    .Compressed = False
                    .Profile = Nothing
                End With
            End Sub
#End Region '(Set|Get) This will reinitialize the class element.

#Region "[On] |2019/07/11 23h30:514| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
            '''    <Summary>
            '''     (Set|Get) This will reinitialize the variables of this class.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:819 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) This will reinitialize the variables of this class.")>
            Public Sub Reset(Optional ByVal Connector As LineInfo = Nothing)
                If Not IsNothing(Connector) Then
                    Me.Connector = Connector
                    Me.FilePath = ""
                    Me.Password = ""
                    Me.Line = ""
                    If Connector.Status <> Status.Broken Then
                        FilePath = Connector.FilePath
                        Password = Connector.Password
                        Me.Connector = Connector
                        TableName = "Backup"
                        Line = Connector.Line
                        UseSQL = False
                    Else
                        FilePath = My.Settings.Db_Backup_FilePath
                        Password = My.Settings.Db_Backup_Password
                        Me.Line = My.Settings.Db_Backup_Line
                        TableName = "Backup"
                        UseSQL = False
                    End If
                Else
                    If IsNothing(FilePath) Then
                        FilePath = My.Settings.Db_Backup_FilePath
                    End If
                    If FilePath.Length < 1 Then
                        FilePath = My.Settings.Db_Backup_FilePath
                    End If
                    FilePath = My.Settings.Db_Backup_FilePath
                    Password = My.Settings.Db_Backup_Password
                    Me.Line = My.Settings.Db_Backup_Line
                    TableName = "Backup"
                    UseSQL = False
                End If

            End Sub
#End Region '(Set|Get) This will reinitialize the variables of this class.

#Region "[On] |2019/07/11 23h30:528| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
            '''    <Summary>
            '''     (Set|Get) This will add a new row in the table.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:819 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) This will add a new row in the table.")>
            Public Sub Add()
                Try
                    Dim Str As String = Nothing
                    Str = "Insert Into [Backup] (
`ID`, 
`File`, 
`DateSaved`, 
`Size`, 
`Compressed`, 
`Profile`) Values (@0, @1, @2, @3, @4, @5)"
                    Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                    Cmd = New OleDb.OleDbCommand(Str, Con)
                    Con.Open()
                    Cmd.Parameters.AddWithValue("@0", Me.ID)
                    Cmd.Parameters.AddWithValue("@1", Me.File)
                    Cmd.Parameters.AddWithValue("@2", Me.DateSaved)
                    Cmd.Parameters.AddWithValue("@3", Me.Size)
                    Cmd.Parameters.AddWithValue("@4", Me.Compressed)
                    Cmd.Parameters.AddWithValue("@5", Me.Profile)
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

#Region "[On] |2019/07/11 23h30:536| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
            '''    <Summary>
            '''     (Set|Get) This will update a row in the table.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:819 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) This will update a row in the table.")>
            Public Sub Save()
                Try
                    Dim Str As String = Nothing
                    Str = "UPDATE [Backup] SET File = @File, DateSaved = @DateSaved, Size = @Size, Compressed = @Compressed, Profile = @Profile WHERE ID = @ID"
                    Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                    Cmd = New OleDb.OleDbCommand(Str, Con)
                    Con.Open()
                    Cmd.Parameters.AddWithValue("@File", File)
                    Cmd.Parameters.AddWithValue("@DateSaved", DateSaved)
                    Cmd.Parameters.AddWithValue("@Size", Size)
                    Cmd.Parameters.AddWithValue("@Compressed", Compressed)
                    Cmd.Parameters.AddWithValue("@Profile", Profile)
                    Cmd.Parameters.AddWithValue("@ID", ID)
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

#Region "[On] |2019/07/11 23h30:544| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
            '''    <Summary>
            '''     (Set|Get) This will Delete a row in the table.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:819 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) This will Delete a row in the table.")>
            Public Sub Delete()
                Try
                    Dim Str As String = Nothing
                    Str = "Delete From [Backup] WHERE ID =@ID"
                    Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                    Cmd = New OleDb.OleDbCommand(Str, Con)
                    Con.Open()
                    Cmd.Parameters.AddWithValue("@ID", ID)
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
#Region "[On] |2019/07/11 23h30:552| <05.00.00> <Function> <> |.Open()|TestItem}|"' (Set|Get) This will initialise the connection and import the data.
            '''    <Summary>
            '''     (Set|Get) This will initialise the connection and import the data.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:820 </Published>
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

#Region "[On] |2019/07/11 23h30:561| <05.00.01> <Function> <> |.Close()|TestItem}|"' (Set|Get) This willClosing the connection
            '''    <Summary>
            '''     (Set|Get) This willClosing the connection
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:820 </Published>
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

#Region "[On] |2019/07/11 23h30:571| <05.00.02> <Function> <> |.List()|List(Of Backup)}|"' (Set|Get) Return the entire table listed
            '''    <Summary>
            '''     (Set|Get) Return the entire table listed
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:820 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) Return the entire table listed")>
            Public Function List() As List(Of Backup)
                Dim Result As New List(Of Backup)
                Me.Table = New Table(Me.TableName, Me.FilePath, Me.Password, False)
                For Each Row As DataRow In Me.Table.DataTable.Rows
                    Dim Element As New Backup(IIf(IsDBNull(Row.Item(0)), 0, Row.Item(0)),
IIf(IsDBNull(Row.Item(1)), "", Row.Item(1)),
IIf(IsDBNull(Row.Item(2)), New DateTime(1970, 1, 1), Row.Item(2)),
IIf(IsDBNull(Row.Item(3)), 0, Row.Item(3)),
IIf(IsDBNull(Row.Item(4)), False, Row.Item(4)),
      IIf(IsDBNull(Row.Item(5)), "", Row.Item(5)))
                    Element.Reset(Table.Line)
                    Result.Add(Element)
                Next
                Return Result
            End Function
#End Region '(Set|Get) Return the entire table listed

#Region "[On] |2019/07/11 23h30:580| <05.00.03> <Function> <> |.SearchByName()|List(Of Backup)}|"' (Set|Get) Search for each property that match the Search String.
            '''    <Summary>
            '''     (Set|Get) Search for each property that match the Search String.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:820 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) Search for each property that match the Search String.")>
            Public Shared Function SearchByName(ByVal Search As String) As List(Of Backup)
                Dim Result As New List(Of Backup)
                Dim C As New Backup
                For Each Element As Backup In C.List
                    If Element.File.ToLower() = Search.ToLower() Or Element.Profile.ToLower() = Search.ToLower() Then
                        Result.Add(Element)
                    End If
                Next
                Return Result
            End Function
#End Region '(Set|Get) Search for each property that match the Search String.

#Region "[On] |2019/07/11 23h30:591| <05.00.04> <Function> <> |.SearchByID()|List(Of Backup)}|"' (Set|Get) Search for each property that match the Search Id.
            '''    <Summary>
            '''     (Set|Get) Search for each property that match the Search Id.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:820 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) Search for each property that match the Search Id.")>
            Public Shared Function SearchByID(ByVal Search As Double) As List(Of Backup)
                Dim Result As New List(Of Backup)
                Dim C As New Backup
                For Each Element As Backup In C.List
                    If Val(Element.ID) = Search Or Val(Element.Size) = Search Then
                        Result.Add(Element)
                    End If
                Next
                Return Result
            End Function
#End Region '(Set|Get) Search for each property that match the Search Id.

#Region "[On] |2019/07/11 23h30:598| <05.00.05> <Function> <> |.ToString()|String}|"' (Set|Get) The function ToString.
            '''    <Summary>
            '''     (Set|Get) The function ToString.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:820 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The function ToString.")>
            Public Overrides Function ToString() As String
                Return Me.ID
            End Function
#End Region '(Set|Get) The function ToString.

#Region "[On] |2019/07/11 23h30:611| <05.00.06> <Function> <> |.CheckConnection()|Boolean}|"' (Set|Get) Evaluate the connection to the DataBase
            '''    <Summary>
            '''     (Set|Get) Evaluate the connection to the DataBase
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:820 </Published>
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
#Region "[On] |2019/07/11 23h30:619| <15.00.00> <Runtime> <> |.Table()|Table"' (Set|Get) The Table.
            '''    <Summary>
            '''     (Set|Get) The Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:821 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Table.")>
            Public Table As Table
#End Region '(Set|Get) The Table.

#Region "[On] |2019/07/11 23h30:626| <15.00.01> <Runtime> <> |.Line()|String"' (Set|Get) The Connection String To the Table.
            '''    <Summary>
            '''     (Set|Get) The Connection String To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:821 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Connection String To the Table.")>
            Public Line As String
#End Region '(Set|Get) The Connection String To the Table.

#Region "[On] |2019/07/11 23h30:633| <15.00.02> <Runtime> <> |.FilePath()|String"' (Set|Get) The FilePath To the Table.
            '''    <Summary>
            '''     (Set|Get) The FilePath To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:821 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The FilePath To the Table.")>
            Public FilePath As String
#End Region '(Set|Get) The FilePath To the Table.

#Region "[On] |2019/07/11 23h30:640| <15.00.03> <Runtime> <> |.Password()|String"' (Set|Get) The Password To the Table.
            '''    <Summary>
            '''     (Set|Get) The Password To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:821 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Password To the Table.")>
            Public Password As String
#End Region '(Set|Get) The Password To the Table.

#Region "[On] |2019/07/11 23h30:649| <15.00.04> <Runtime> <> |.UseSQL()|Boolean"' (Set|Get) Determines if the Database Connection is of type SQL.
            '''    <Summary>
            '''     (Set|Get) Determines if the Database Connection is of type SQL.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:821 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) Determines if the Database Connection is of type SQL.")>
            Public UseSQL As Boolean
#End Region '(Set|Get) Determines if the Database Connection is of type SQL.

#Region "[On] |2019/07/11 23h30:658| <15.00.05> <Runtime> <> |.TableName()|String"' (Set|Get) The name of the Table.
            '''    <Summary>
            '''     (Set|Get) The name of the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:821 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The name of the Table.")>
            Public TableName As String
#End Region '(Set|Get) The name of the Table.

#Region "[On] |2019/07/11 23h30:667| <15.00.06> <Runtime> <> |.Con()|OleDb.OleDbConnection"' (Set|Get) The Con To the Table.
            '''    <Summary>
            '''     (Set|Get) The Con To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:821 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Con To the Table.")>
            Public Con As OleDb.OleDbConnection
#End Region '(Set|Get) The Con To the Table.

#Region "[On] |2019/07/11 23h30:670| <15.00.07> <Runtime> <> |.Cmd()|OleDb.OleDbCommand"' (Set|Get) The Cmd To the Table.
            '''    <Summary>
            '''     (Set|Get) The Cmd To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:821 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Cmd To the Table.")>
            Public Cmd As OleDb.OleDbCommand
#End Region '(Set|Get) The Cmd To the Table.

#Region "[On] |2019/07/11 23h30:678| <15.00.08> <Runtime> <> |.DataReader()|OleDb.OleDbDataReader"' (Set|Get) The DataReader To the Table.
            '''    <Summary>
            '''     (Set|Get) The DataReader To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:821 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The DataReader To the Table.")>
            Public DataReader As OleDb.OleDbDataReader
#End Region '(Set|Get) The DataReader To the Table.

#Region "[On] |2019/07/11 23h30:686| <15.00.09> <Runtime> <> |.DataAdapter()|OleDb.OleDbDataAdapter"' (Set|Get) The DataAdapter To the Table.
            '''    <Summary>
            '''     (Set|Get) The DataAdapter To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:822 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The DataAdapter To the Table.")>
            Public DataAdapter As OleDb.OleDbDataAdapter
#End Region '(Set|Get) The DataAdapter To the Table.

#Region "[On] |2019/07/11 23h30:693| <15.00.10> <Runtime> <> |.Connector()|LineInfo"' (Set|Get) The Connector To the Table.
            '''    <Summary>
            '''     (Set|Get) The Connector To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:822 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Connector To the Table.")>
            Public Connector As LineInfo
#End Region '(Set|Get) The Connector To the Table.

#Region "[On] |2019/07/11 23h30:701| <15.00.11> <Runtime> <> |.Log()|String"' (Set|Get) The Log To the Table.
            '''    <Summary>
            '''     (Set|Get) The Log To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:822 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Log To the Table.")>
            Public Log As String
#End Region '(Set|Get) The Log To the Table.

#End Region
#Region "<7> [Loader]{2}"
#Region "[On] |2019/07/11 23h30:708| <06.00.00> <Loader> <> |.Empty()|Function}|"' (Set|Get) The sub Empty.
            '''    <Summary>
            '''     (Set|Get) The sub Empty.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:823 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The sub Empty.")>
            Public Sub New()
                Reset()
            End Sub
#End Region '(Set|Get) The sub Empty.

#Region "[On] |2019/07/11 23h30:709| <06.00.01> <Loader> <> |.Filled()|Function}|"' (Set|Get) The sub Filled.
            '''    <Summary>
            '''     (Set|Get) The sub Filled.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:823 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>    ''' <param name="ID">(Set|Get) The ID as Integer.</param>
            ''' <param name="File">(Set|Get) The File as String.</param>
            ''' <param name="DateSaved">(Set|Get) The DateSaved as DateTime.</param>
            ''' <param name="Size">(Set|Get) The Size as Double.</param>
            ''' <param name="Compressed">(Set|Get) The Compressed as Boolean.</param>
            ''' <param name="Profile">(Set|Get) The Profile as String.</param>

            <Browsable(True), Description("(Set|Get) The sub Filled.")>
            Public Sub New(ByVal ID As Integer,
ByVal File As String,
ByVal DateSaved As DateTime,
ByVal Size As Double,
ByVal Compressed As Boolean,
ByVal Profile As String)
                With Me
                    Clear()
                    Reset()
                    .ID = ID
                    .File = File
                    .DateSaved = DateSaved
                    .Size = Size
                    .Compressed = Compressed
                    .Profile = Profile
                End With

            End Sub
#End Region '(Set|Get) The sub Filled.

#End Region
        End Class
#End Region

#Region "[On] |2019/07/11 23h30:802| <08.00.00> <Class> <> |.Profile|Class|{76} |Production Cost : 114.7|Selling Price : 286.75|"' Class created automatically by SmartOffice (c)Copyright 2019.
        '''    <Summary>
        '''     Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Profile
        '''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
        '''    Contributor Information : ||
        '''    Creation Date :           2019/07/11 23h30:802
        '''    |Schema|
        '''    |ID| |ObjectType |{Quantity}||UnitPrice||Total
        '''    |00| |Importation|{0}||1| |0
        '''    |01| |Properties |{49}||0.8| |39.2
        '''    |02| |Enumeration|{1}||0.4| |0.4
        '''    |03| |Structure  |{0}||0.4| |0
        '''    |04| |Sub        |{5}||1.2| |6
        '''    |05| |Function   |{7}||1.6| |11.2
        '''    |06| |Runtime    |{12}||0.4| |4.8
        '''    |07| |Loader     |{2}||0.8| |1.6
        '''    |08| |Class      |{0}||2| |0
        '''    |09| |Constante  |{0}||0.4| |0
        '''    |10| |Event      |{0}||1.2| |0
        '''    |11| |Members    |{49}||0.5| |24.5
        '''    |12| |Parameter  |{54}||0.5| |27
        '''    |Production Cost             |114.7
        '''    |Selling Price without VAT   |286.75
        '''    |Total TVA                   |22.08
        '''    |Grand Total                 |308.83
        '''    |/Schema|
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:828 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        Public Class Profile
#Region "<1> [Property]{49}"
#Region "[On] |2019/07/11 23h30:803| <01.00.00> <Property> <Columns> |.Name()|String|"' (Set|Get) The Name as String.
            Private _Name As String
            '''    <Summary>
            '''     (Set|Get) The Name as String.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:828 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Name as String.")>
            Public Property Name() As String
                Get
                    Return _Name
                End Get
                Set(ByVal Value As String)
                    _Name = Value
                End Set
            End Property
#End Region '(Set|Get) The Name as String.

#Region "[On] |2019/07/11 23h30:810| <01.00.01> <Property> <Columns> |.Source()|String|"' (Set|Get) The Source as String.
            Private _Source As String
            '''    <Summary>
            '''     (Set|Get) The Source as String.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:829 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Source as String.")>
            Public Property Source() As String
                Get
                    Return _Source
                End Get
                Set(ByVal Value As String)
                    _Source = Value
                End Set
            End Property
#End Region '(Set|Get) The Source as String.

#Region "[On] |2019/07/11 23h30:815| <01.00.02> <Property> <Columns> |.Destination()|String|"' (Set|Get) The Destination as String.
            Private _Destination As String
            '''    <Summary>
            '''     (Set|Get) The Destination as String.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:829 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Destination as String.")>
            Public Property Destination() As String
                Get
                    Return _Destination
                End Get
                Set(ByVal Value As String)
                    _Destination = Value
                End Set
            End Property
#End Region '(Set|Get) The Destination as String.

#Region "[On] |2019/07/11 23h30:821| <01.00.03> <Property> <Columns> |.Hours()|Integer|"' (Set|Get) The Hours as Integer.
            Private _Hours As Integer
            '''    <Summary>
            '''     (Set|Get) The Hours as Integer.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:829 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Hours as Integer.")>
            Public Property Hours() As Integer
                Get
                    Return _Hours
                End Get
                Set(ByVal Value As Integer)
                    _Hours = Value
                End Set
            End Property
#End Region '(Set|Get) The Hours as Integer.

#Region "[On] |2019/07/11 23h30:827| <01.00.04> <Property> <Columns> |.Minutes()|Integer|"' (Set|Get) The Minutes as Integer.
            Private _Minutes As Integer
            '''    <Summary>
            '''     (Set|Get) The Minutes as Integer.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:829 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Minutes as Integer.")>
            Public Property Minutes() As Integer
                Get
                    Return _Minutes
                End Get
                Set(ByVal Value As Integer)
                    _Minutes = Value
                End Set
            End Property
#End Region '(Set|Get) The Minutes as Integer.

#Region "[On] |2019/07/11 23h30:833| <01.00.05> <Property> <Columns> |.Monday()|Boolean|"' (Set|Get) The Monday as Boolean.
            Private _Monday As Boolean
            '''    <Summary>
            '''     (Set|Get) The Monday as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:829 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Monday as Boolean.")>
            Public Property Monday() As Boolean
                Get
                    Return _Monday
                End Get
                Set(ByVal Value As Boolean)
                    _Monday = Value
                End Set
            End Property
#End Region '(Set|Get) The Monday as Boolean.

#Region "[On] |2019/07/11 23h30:839| <01.00.06> <Property> <Columns> |.Tuesday()|Boolean|"' (Set|Get) The Tuesday as Boolean.
            Private _Tuesday As Boolean
            '''    <Summary>
            '''     (Set|Get) The Tuesday as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:830 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Tuesday as Boolean.")>
            Public Property Tuesday() As Boolean
                Get
                    Return _Tuesday
                End Get
                Set(ByVal Value As Boolean)
                    _Tuesday = Value
                End Set
            End Property
#End Region '(Set|Get) The Tuesday as Boolean.

#Region "[On] |2019/07/11 23h30:845| <01.00.07> <Property> <Columns> |.Wednesday()|Boolean|"' (Set|Get) The Wednesday as Boolean.
            Private _Wednesday As Boolean
            '''    <Summary>
            '''     (Set|Get) The Wednesday as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:830 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Wednesday as Boolean.")>
            Public Property Wednesday() As Boolean
                Get
                    Return _Wednesday
                End Get
                Set(ByVal Value As Boolean)
                    _Wednesday = Value
                End Set
            End Property
#End Region '(Set|Get) The Wednesday as Boolean.

#Region "[On] |2019/07/11 23h30:851| <01.00.08> <Property> <Columns> |.Thursday()|Boolean|"' (Set|Get) The Thursday as Boolean.
            Private _Thursday As Boolean
            '''    <Summary>
            '''     (Set|Get) The Thursday as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:830 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Thursday as Boolean.")>
            Public Property Thursday() As Boolean
                Get
                    Return _Thursday
                End Get
                Set(ByVal Value As Boolean)
                    _Thursday = Value
                End Set
            End Property
#End Region '(Set|Get) The Thursday as Boolean.

#Region "[On] |2019/07/11 23h30:857| <01.00.09> <Property> <Columns> |.Friday()|Boolean|"' (Set|Get) The Friday as Boolean.
            Private _Friday As Boolean
            '''    <Summary>
            '''     (Set|Get) The Friday as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:830 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Friday as Boolean.")>
            Public Property Friday() As Boolean
                Get
                    Return _Friday
                End Get
                Set(ByVal Value As Boolean)
                    _Friday = Value
                End Set
            End Property
#End Region '(Set|Get) The Friday as Boolean.

#Region "[On] |2019/07/11 23h30:863| <01.00.10> <Property> <Columns> |.Saturday()|Boolean|"' (Set|Get) The Saturday as Boolean.
            Private _Saturday As Boolean
            '''    <Summary>
            '''     (Set|Get) The Saturday as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:830 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Saturday as Boolean.")>
            Public Property Saturday() As Boolean
                Get
                    Return _Saturday
                End Get
                Set(ByVal Value As Boolean)
                    _Saturday = Value
                End Set
            End Property
#End Region '(Set|Get) The Saturday as Boolean.

#Region "[On] |2019/07/11 23h30:869| <01.00.11> <Property> <Columns> |.Sunday()|Boolean|"' (Set|Get) The Sunday as Boolean.
            Private _Sunday As Boolean
            '''    <Summary>
            '''     (Set|Get) The Sunday as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:831 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Sunday as Boolean.")>
            Public Property Sunday() As Boolean
                Get
                    Return _Sunday
                End Get
                Set(ByVal Value As Boolean)
                    _Sunday = Value
                End Set
            End Property
#End Region '(Set|Get) The Sunday as Boolean.

#Region "[On] |2019/07/11 23h30:877| <01.00.12> <Property> <Columns> |.EveryDay()|Boolean|"' (Set|Get) The EveryDay as Boolean.
            Private _EveryDay As Boolean
            '''    <Summary>
            '''     (Set|Get) The EveryDay as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:831 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The EveryDay as Boolean.")>
            Public Property EveryDay() As Boolean
                Get
                    Return _EveryDay
                End Get
                Set(ByVal Value As Boolean)
                    _EveryDay = Value
                End Set
            End Property
#End Region '(Set|Get) The EveryDay as Boolean.

#Region "[On] |2019/07/11 23h30:883| <01.00.13> <Property> <Columns> |.EveryWeek()|Boolean|"' (Set|Get) The EveryWeek as Boolean.
            Private _EveryWeek As Boolean
            '''    <Summary>
            '''     (Set|Get) The EveryWeek as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:831 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The EveryWeek as Boolean.")>
            Public Property EveryWeek() As Boolean
                Get
                    Return _EveryWeek
                End Get
                Set(ByVal Value As Boolean)
                    _EveryWeek = Value
                End Set
            End Property
#End Region '(Set|Get) The EveryWeek as Boolean.

#Region "[On] |2019/07/11 23h30:890| <01.00.14> <Property> <Columns> |.EveryMonth()|Boolean|"' (Set|Get) The EveryMonth as Boolean.
            Private _EveryMonth As Boolean
            '''    <Summary>
            '''     (Set|Get) The EveryMonth as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:831 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The EveryMonth as Boolean.")>
            Public Property EveryMonth() As Boolean
                Get
                    Return _EveryMonth
                End Get
                Set(ByVal Value As Boolean)
                    _EveryMonth = Value
                End Set
            End Property
#End Region '(Set|Get) The EveryMonth as Boolean.

#Region "[On] |2019/07/11 23h30:897| <01.00.15> <Property> <Columns> |.Day_01()|Boolean|"' (Set|Get) The Day_01 as Boolean.
            Private _Day_01 As Boolean
            '''    <Summary>
            '''     (Set|Get) The Day_01 as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:831 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Day_01 as Boolean.")>
            Public Property Day_01() As Boolean
                Get
                    Return _Day_01
                End Get
                Set(ByVal Value As Boolean)
                    _Day_01 = Value
                End Set
            End Property
#End Region '(Set|Get) The Day_01 as Boolean.

#Region "[On] |2019/07/11 23h30:903| <01.00.16> <Property> <Columns> |.Day_02()|Boolean|"' (Set|Get) The Day_02 as Boolean.
            Private _Day_02 As Boolean
            '''    <Summary>
            '''     (Set|Get) The Day_02 as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:832 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Day_02 as Boolean.")>
            Public Property Day_02() As Boolean
                Get
                    Return _Day_02
                End Get
                Set(ByVal Value As Boolean)
                    _Day_02 = Value
                End Set
            End Property
#End Region '(Set|Get) The Day_02 as Boolean.

#Region "[On] |2019/07/11 23h30:912| <01.00.17> <Property> <Columns> |.Day_03()|Boolean|"' (Set|Get) The Day_03 as Boolean.
            Private _Day_03 As Boolean
            '''    <Summary>
            '''     (Set|Get) The Day_03 as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:832 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Day_03 as Boolean.")>
            Public Property Day_03() As Boolean
                Get
                    Return _Day_03
                End Get
                Set(ByVal Value As Boolean)
                    _Day_03 = Value
                End Set
            End Property
#End Region '(Set|Get) The Day_03 as Boolean.

#Region "[On] |2019/07/11 23h30:920| <01.00.18> <Property> <Columns> |.Day_04()|Boolean|"' (Set|Get) The Day_04 as Boolean.
            Private _Day_04 As Boolean
            '''    <Summary>
            '''     (Set|Get) The Day_04 as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:832 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Day_04 as Boolean.")>
            Public Property Day_04() As Boolean
                Get
                    Return _Day_04
                End Get
                Set(ByVal Value As Boolean)
                    _Day_04 = Value
                End Set
            End Property
#End Region '(Set|Get) The Day_04 as Boolean.

#Region "[On] |2019/07/11 23h30:932| <01.00.19> <Property> <Columns> |.Day_05()|Boolean|"' (Set|Get) The Day_05 as Boolean.
            Private _Day_05 As Boolean
            '''    <Summary>
            '''     (Set|Get) The Day_05 as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:832 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Day_05 as Boolean.")>
            Public Property Day_05() As Boolean
                Get
                    Return _Day_05
                End Get
                Set(ByVal Value As Boolean)
                    _Day_05 = Value
                End Set
            End Property
#End Region '(Set|Get) The Day_05 as Boolean.

#Region "[On] |2019/07/11 23h30:938| <01.00.20> <Property> <Columns> |.Day_06()|Boolean|"' (Set|Get) The Day_06 as Boolean.
            Private _Day_06 As Boolean
            '''    <Summary>
            '''     (Set|Get) The Day_06 as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:832 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Day_06 as Boolean.")>
            Public Property Day_06() As Boolean
                Get
                    Return _Day_06
                End Get
                Set(ByVal Value As Boolean)
                    _Day_06 = Value
                End Set
            End Property
#End Region '(Set|Get) The Day_06 as Boolean.

#Region "[On] |2019/07/11 23h30:945| <01.00.21> <Property> <Columns> |.Day_07()|Boolean|"' (Set|Get) The Day_07 as Boolean.
            Private _Day_07 As Boolean
            '''    <Summary>
            '''     (Set|Get) The Day_07 as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:833 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Day_07 as Boolean.")>
            Public Property Day_07() As Boolean
                Get
                    Return _Day_07
                End Get
                Set(ByVal Value As Boolean)
                    _Day_07 = Value
                End Set
            End Property
#End Region '(Set|Get) The Day_07 as Boolean.

#Region "[On] |2019/07/11 23h30:952| <01.00.22> <Property> <Columns> |.Day_08()|Boolean|"' (Set|Get) The Day_08 as Boolean.
            Private _Day_08 As Boolean
            '''    <Summary>
            '''     (Set|Get) The Day_08 as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:833 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Day_08 as Boolean.")>
            Public Property Day_08() As Boolean
                Get
                    Return _Day_08
                End Get
                Set(ByVal Value As Boolean)
                    _Day_08 = Value
                End Set
            End Property
#End Region '(Set|Get) The Day_08 as Boolean.

#Region "[On] |2019/07/11 23h30:958| <01.00.23> <Property> <Columns> |.Day_09()|Boolean|"' (Set|Get) The Day_09 as Boolean.
            Private _Day_09 As Boolean
            '''    <Summary>
            '''     (Set|Get) The Day_09 as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:833 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Day_09 as Boolean.")>
            Public Property Day_09() As Boolean
                Get
                    Return _Day_09
                End Get
                Set(ByVal Value As Boolean)
                    _Day_09 = Value
                End Set
            End Property
#End Region '(Set|Get) The Day_09 as Boolean.

#Region "[On] |2019/07/11 23h30:965| <01.00.24> <Property> <Columns> |.Day_10()|Boolean|"' (Set|Get) The Day_10 as Boolean.
            Private _Day_10 As Boolean
            '''    <Summary>
            '''     (Set|Get) The Day_10 as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:833 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Day_10 as Boolean.")>
            Public Property Day_10() As Boolean
                Get
                    Return _Day_10
                End Get
                Set(ByVal Value As Boolean)
                    _Day_10 = Value
                End Set
            End Property
#End Region '(Set|Get) The Day_10 as Boolean.

#Region "[On] |2019/07/11 23h30:971| <01.00.25> <Property> <Columns> |.Day_11()|Boolean|"' (Set|Get) The Day_11 as Boolean.
            Private _Day_11 As Boolean
            '''    <Summary>
            '''     (Set|Get) The Day_11 as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:833 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Day_11 as Boolean.")>
            Public Property Day_11() As Boolean
                Get
                    Return _Day_11
                End Get
                Set(ByVal Value As Boolean)
                    _Day_11 = Value
                End Set
            End Property
#End Region '(Set|Get) The Day_11 as Boolean.

#Region "[On] |2019/07/11 23h30:978| <01.00.26> <Property> <Columns> |.Day_12()|Boolean|"' (Set|Get) The Day_12 as Boolean.
            Private _Day_12 As Boolean
            '''    <Summary>
            '''     (Set|Get) The Day_12 as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:834 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Day_12 as Boolean.")>
            Public Property Day_12() As Boolean
                Get
                    Return _Day_12
                End Get
                Set(ByVal Value As Boolean)
                    _Day_12 = Value
                End Set
            End Property
#End Region '(Set|Get) The Day_12 as Boolean.

#Region "[On] |2019/07/11 23h30:986| <01.00.27> <Property> <Columns> |.Day_13()|Boolean|"' (Set|Get) The Day_13 as Boolean.
            Private _Day_13 As Boolean
            '''    <Summary>
            '''     (Set|Get) The Day_13 as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:834 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Day_13 as Boolean.")>
            Public Property Day_13() As Boolean
                Get
                    Return _Day_13
                End Get
                Set(ByVal Value As Boolean)
                    _Day_13 = Value
                End Set
            End Property
#End Region '(Set|Get) The Day_13 as Boolean.

#Region "[On] |2019/07/11 23h30:993| <01.00.28> <Property> <Columns> |.Day_14()|Boolean|"' (Set|Get) The Day_14 as Boolean.
            Private _Day_14 As Boolean
            '''    <Summary>
            '''     (Set|Get) The Day_14 as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:834 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Day_14 as Boolean.")>
            Public Property Day_14() As Boolean
                Get
                    Return _Day_14
                End Get
                Set(ByVal Value As Boolean)
                    _Day_14 = Value
                End Set
            End Property
#End Region '(Set|Get) The Day_14 as Boolean.

#Region "[On] |2019/07/11 23h30:000| <01.00.29> <Property> <Columns> |.Day_15()|Boolean|"' (Set|Get) The Day_15 as Boolean.
            Private _Day_15 As Boolean
            '''    <Summary>
            '''     (Set|Get) The Day_15 as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:834 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Day_15 as Boolean.")>
            Public Property Day_15() As Boolean
                Get
                    Return _Day_15
                End Get
                Set(ByVal Value As Boolean)
                    _Day_15 = Value
                End Set
            End Property
#End Region '(Set|Get) The Day_15 as Boolean.

#Region "[On] |2019/07/11 23h30:008| <01.00.30> <Property> <Columns> |.Day_16()|Boolean|"' (Set|Get) The Day_16 as Boolean.
            Private _Day_16 As Boolean
            '''    <Summary>
            '''     (Set|Get) The Day_16 as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:835 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Day_16 as Boolean.")>
            Public Property Day_16() As Boolean
                Get
                    Return _Day_16
                End Get
                Set(ByVal Value As Boolean)
                    _Day_16 = Value
                End Set
            End Property
#End Region '(Set|Get) The Day_16 as Boolean.

#Region "[On] |2019/07/11 23h30:016| <01.00.31> <Property> <Columns> |.Day_17()|Boolean|"' (Set|Get) The Day_17 as Boolean.
            Private _Day_17 As Boolean
            '''    <Summary>
            '''     (Set|Get) The Day_17 as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:835 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Day_17 as Boolean.")>
            Public Property Day_17() As Boolean
                Get
                    Return _Day_17
                End Get
                Set(ByVal Value As Boolean)
                    _Day_17 = Value
                End Set
            End Property
#End Region '(Set|Get) The Day_17 as Boolean.

#Region "[On] |2019/07/11 23h30:023| <01.00.32> <Property> <Columns> |.Day_18()|Boolean|"' (Set|Get) The Day_18 as Boolean.
            Private _Day_18 As Boolean
            '''    <Summary>
            '''     (Set|Get) The Day_18 as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:835 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Day_18 as Boolean.")>
            Public Property Day_18() As Boolean
                Get
                    Return _Day_18
                End Get
                Set(ByVal Value As Boolean)
                    _Day_18 = Value
                End Set
            End Property
#End Region '(Set|Get) The Day_18 as Boolean.

#Region "[On] |2019/07/11 23h30:030| <01.00.33> <Property> <Columns> |.Day_19()|Boolean|"' (Set|Get) The Day_19 as Boolean.
            Private _Day_19 As Boolean
            '''    <Summary>
            '''     (Set|Get) The Day_19 as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:835 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Day_19 as Boolean.")>
            Public Property Day_19() As Boolean
                Get
                    Return _Day_19
                End Get
                Set(ByVal Value As Boolean)
                    _Day_19 = Value
                End Set
            End Property
#End Region '(Set|Get) The Day_19 as Boolean.

#Region "[On] |2019/07/11 23h30:038| <01.00.34> <Property> <Columns> |.Day_20()|Boolean|"' (Set|Get) The Day_20 as Boolean.
            Private _Day_20 As Boolean
            '''    <Summary>
            '''     (Set|Get) The Day_20 as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:835 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Day_20 as Boolean.")>
            Public Property Day_20() As Boolean
                Get
                    Return _Day_20
                End Get
                Set(ByVal Value As Boolean)
                    _Day_20 = Value
                End Set
            End Property
#End Region '(Set|Get) The Day_20 as Boolean.

#Region "[On] |2019/07/11 23h30:045| <01.00.35> <Property> <Columns> |.Day_21()|Boolean|"' (Set|Get) The Day_21 as Boolean.
            Private _Day_21 As Boolean
            '''    <Summary>
            '''     (Set|Get) The Day_21 as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:836 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Day_21 as Boolean.")>
            Public Property Day_21() As Boolean
                Get
                    Return _Day_21
                End Get
                Set(ByVal Value As Boolean)
                    _Day_21 = Value
                End Set
            End Property
#End Region '(Set|Get) The Day_21 as Boolean.

#Region "[On] |2019/07/11 23h30:054| <01.00.36> <Property> <Columns> |.Day_22()|Boolean|"' (Set|Get) The Day_22 as Boolean.
            Private _Day_22 As Boolean
            '''    <Summary>
            '''     (Set|Get) The Day_22 as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:837 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Day_22 as Boolean.")>
            Public Property Day_22() As Boolean
                Get
                    Return _Day_22
                End Get
                Set(ByVal Value As Boolean)
                    _Day_22 = Value
                End Set
            End Property
#End Region '(Set|Get) The Day_22 as Boolean.

#Region "[On] |2019/07/11 23h30:061| <01.00.37> <Property> <Columns> |.Day_23()|Boolean|"' (Set|Get) The Day_23 as Boolean.
            Private _Day_23 As Boolean
            '''    <Summary>
            '''     (Set|Get) The Day_23 as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:837 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Day_23 as Boolean.")>
            Public Property Day_23() As Boolean
                Get
                    Return _Day_23
                End Get
                Set(ByVal Value As Boolean)
                    _Day_23 = Value
                End Set
            End Property
#End Region '(Set|Get) The Day_23 as Boolean.

#Region "[On] |2019/07/11 23h30:069| <01.00.38> <Property> <Columns> |.Day_24()|Boolean|"' (Set|Get) The Day_24 as Boolean.
            Private _Day_24 As Boolean
            '''    <Summary>
            '''     (Set|Get) The Day_24 as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:837 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Day_24 as Boolean.")>
            Public Property Day_24() As Boolean
                Get
                    Return _Day_24
                End Get
                Set(ByVal Value As Boolean)
                    _Day_24 = Value
                End Set
            End Property
#End Region '(Set|Get) The Day_24 as Boolean.

#Region "[On] |2019/07/11 23h30:087| <01.00.39> <Property> <Columns> |.Day_25()|Boolean|"' (Set|Get) The Day_25 as Boolean.
            Private _Day_25 As Boolean
            '''    <Summary>
            '''     (Set|Get) The Day_25 as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:837 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Day_25 as Boolean.")>
            Public Property Day_25() As Boolean
                Get
                    Return _Day_25
                End Get
                Set(ByVal Value As Boolean)
                    _Day_25 = Value
                End Set
            End Property
#End Region '(Set|Get) The Day_25 as Boolean.

#Region "[On] |2019/07/11 23h30:094| <01.00.40> <Property> <Columns> |.Day_26()|Boolean|"' (Set|Get) The Day_26 as Boolean.
            Private _Day_26 As Boolean
            '''    <Summary>
            '''     (Set|Get) The Day_26 as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:838 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Day_26 as Boolean.")>
            Public Property Day_26() As Boolean
                Get
                    Return _Day_26
                End Get
                Set(ByVal Value As Boolean)
                    _Day_26 = Value
                End Set
            End Property
#End Region '(Set|Get) The Day_26 as Boolean.

#Region "[On] |2019/07/11 23h30:102| <01.00.41> <Property> <Columns> |.Day_27()|Boolean|"' (Set|Get) The Day_27 as Boolean.
            Private _Day_27 As Boolean
            '''    <Summary>
            '''     (Set|Get) The Day_27 as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:838 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Day_27 as Boolean.")>
            Public Property Day_27() As Boolean
                Get
                    Return _Day_27
                End Get
                Set(ByVal Value As Boolean)
                    _Day_27 = Value
                End Set
            End Property
#End Region '(Set|Get) The Day_27 as Boolean.

#Region "[On] |2019/07/11 23h30:110| <01.00.42> <Property> <Columns> |.Day_28()|Boolean|"' (Set|Get) The Day_28 as Boolean.
            Private _Day_28 As Boolean
            '''    <Summary>
            '''     (Set|Get) The Day_28 as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:838 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Day_28 as Boolean.")>
            Public Property Day_28() As Boolean
                Get
                    Return _Day_28
                End Get
                Set(ByVal Value As Boolean)
                    _Day_28 = Value
                End Set
            End Property
#End Region '(Set|Get) The Day_28 as Boolean.

#Region "[On] |2019/07/11 23h30:117| <01.00.43> <Property> <Columns> |.Day_29()|Boolean|"' (Set|Get) The Day_29 as Boolean.
            Private _Day_29 As Boolean
            '''    <Summary>
            '''     (Set|Get) The Day_29 as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:838 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Day_29 as Boolean.")>
            Public Property Day_29() As Boolean
                Get
                    Return _Day_29
                End Get
                Set(ByVal Value As Boolean)
                    _Day_29 = Value
                End Set
            End Property
#End Region '(Set|Get) The Day_29 as Boolean.

#Region "[On] |2019/07/11 23h30:125| <01.00.44> <Property> <Columns> |.Day_30()|Boolean|"' (Set|Get) The Day_30 as Boolean.
            Private _Day_30 As Boolean
            '''    <Summary>
            '''     (Set|Get) The Day_30 as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:839 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Day_30 as Boolean.")>
            Public Property Day_30() As Boolean
                Get
                    Return _Day_30
                End Get
                Set(ByVal Value As Boolean)
                    _Day_30 = Value
                End Set
            End Property
#End Region '(Set|Get) The Day_30 as Boolean.

#Region "[On] |2019/07/11 23h30:133| <01.00.45> <Property> <Columns> |.Day_31()|Boolean|"' (Set|Get) The Day_31 as Boolean.
            Private _Day_31 As Boolean
            '''    <Summary>
            '''     (Set|Get) The Day_31 as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:839 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Day_31 as Boolean.")>
            Public Property Day_31() As Boolean
                Get
                    Return _Day_31
                End Get
                Set(ByVal Value As Boolean)
                    _Day_31 = Value
                End Set
            End Property
#End Region '(Set|Get) The Day_31 as Boolean.

#Region "[On] |2019/07/11 23h30:142| <01.00.46> <Property> <Columns> |.Encrypt()|Boolean|"' (Set|Get) The Encrypt as Boolean.
            Private _Encrypt As Boolean
            '''    <Summary>
            '''     (Set|Get) The Encrypt as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:839 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Encrypt as Boolean.")>
            Public Property Encrypt() As Boolean
                Get
                    Return _Encrypt
                End Get
                Set(ByVal Value As Boolean)
                    _Encrypt = Value
                End Set
            End Property
#End Region '(Set|Get) The Encrypt as Boolean.

#Region "[On] |2019/07/11 23h30:150| <01.00.47> <Property> <Columns> |.Compress()|Boolean|"' (Set|Get) The Compress as Boolean.
            Private _Compress As Boolean
            '''    <Summary>
            '''     (Set|Get) The Compress as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:839 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Compress as Boolean.")>
            Public Property Compress() As Boolean
                Get
                    Return _Compress
                End Get
                Set(ByVal Value As Boolean)
                    _Compress = Value
                End Set
            End Property
#End Region '(Set|Get) The Compress as Boolean.

#Region "[On] |2019/07/11 23h30:158| <01.00.48> <Property> <Columns> |.NumberofOccurences()|Integer|"' (Set|Get) The NumberofOccurences as Integer.
            Private _NumberofOccurences As Integer
            '''    <Summary>
            '''     (Set|Get) The NumberofOccurences as Integer.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:839 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The NumberofOccurences as Integer.")>
            Public Property NumberofOccurences() As Integer
                Get
                    Return _NumberofOccurences
                End Get
                Set(ByVal Value As Integer)
                    _NumberofOccurences = Value
                End Set
            End Property
#End Region '(Set|Get) The NumberofOccurences as Integer.

#End Region
#Region "<2> [Enumeration]{1}"
#Region "[On] |2019/07/11 23h30:167| <02.00.00> <Enumeration> <> |.Schema()|Enumeration{48}|"' (Set|Get) The enumeration of Schema.
            '''    <Summary>
            '''     (Set|Get) The enumeration of Schema.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:840 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The enumeration of Schema.")>
            Enum Schema
                ''' <summary>(Set|Get) The Name as String.</summary>
                [Name] = 0
                ''' <summary>(Set|Get) The Source as String.</summary>
                [Source] = 1
                ''' <summary>(Set|Get) The Destination as String.</summary>
                [Destination] = 2
                ''' <summary>(Set|Get) The Hours as Integer.</summary>
                [Hours] = 3
                ''' <summary>(Set|Get) The Minutes as Integer.</summary>
                [Minutes] = 4
                ''' <summary>(Set|Get) The Monday as Boolean.</summary>
                [Monday] = 5
                ''' <summary>(Set|Get) The Tuesday as Boolean.</summary>
                [Tuesday] = 6
                ''' <summary>(Set|Get) The Wednesday as Boolean.</summary>
                [Wednesday] = 7
                ''' <summary>(Set|Get) The Thursday as Boolean.</summary>
                [Thursday] = 8
                ''' <summary>(Set|Get) The Friday as Boolean.</summary>
                [Friday] = 9
                ''' <summary>(Set|Get) The Saturday as Boolean.</summary>
                [Saturday] = 10
                ''' <summary>(Set|Get) The Sunday as Boolean.</summary>
                [Sunday] = 11
                ''' <summary>(Set|Get) The EveryDay as Boolean.</summary>
                [EveryDay] = 12
                ''' <summary>(Set|Get) The EveryWeek as Boolean.</summary>
                [EveryWeek] = 13
                ''' <summary>(Set|Get) The EveryMonth as Boolean.</summary>
                [EveryMonth] = 14
                ''' <summary>(Set|Get) The Day_01 as Boolean.</summary>
                [Day_01] = 15
                ''' <summary>(Set|Get) The Day_02 as Boolean.</summary>
                [Day_02] = 16
                ''' <summary>(Set|Get) The Day_03 as Boolean.</summary>
                [Day_03] = 17
                ''' <summary>(Set|Get) The Day_04 as Boolean.</summary>
                [Day_04] = 18
                ''' <summary>(Set|Get) The Day_05 as Boolean.</summary>
                [Day_05] = 19
                ''' <summary>(Set|Get) The Day_06 as Boolean.</summary>
                [Day_06] = 20
                ''' <summary>(Set|Get) The Day_07 as Boolean.</summary>
                [Day_07] = 21
                ''' <summary>(Set|Get) The Day_08 as Boolean.</summary>
                [Day_08] = 22
                ''' <summary>(Set|Get) The Day_09 as Boolean.</summary>
                [Day_09] = 23
                ''' <summary>(Set|Get) The Day_10 as Boolean.</summary>
                [Day_10] = 24
                ''' <summary>(Set|Get) The Day_11 as Boolean.</summary>
                [Day_11] = 25
                ''' <summary>(Set|Get) The Day_12 as Boolean.</summary>
                [Day_12] = 26
                ''' <summary>(Set|Get) The Day_13 as Boolean.</summary>
                [Day_13] = 27
                ''' <summary>(Set|Get) The Day_14 as Boolean.</summary>
                [Day_14] = 28
                ''' <summary>(Set|Get) The Day_15 as Boolean.</summary>
                [Day_15] = 29
                ''' <summary>(Set|Get) The Day_16 as Boolean.</summary>
                [Day_16] = 30
                ''' <summary>(Set|Get) The Day_17 as Boolean.</summary>
                [Day_17] = 31
                ''' <summary>(Set|Get) The Day_18 as Boolean.</summary>
                [Day_18] = 32
                ''' <summary>(Set|Get) The Day_19 as Boolean.</summary>
                [Day_19] = 33
                ''' <summary>(Set|Get) The Day_20 as Boolean.</summary>
                [Day_20] = 34
                ''' <summary>(Set|Get) The Day_21 as Boolean.</summary>
                [Day_21] = 35
                ''' <summary>(Set|Get) The Day_22 as Boolean.</summary>
                [Day_22] = 36
                ''' <summary>(Set|Get) The Day_23 as Boolean.</summary>
                [Day_23] = 37
                ''' <summary>(Set|Get) The Day_24 as Boolean.</summary>
                [Day_24] = 38
                ''' <summary>(Set|Get) The Day_25 as Boolean.</summary>
                [Day_25] = 39
                ''' <summary>(Set|Get) The Day_26 as Boolean.</summary>
                [Day_26] = 40
                ''' <summary>(Set|Get) The Day_27 as Boolean.</summary>
                [Day_27] = 41
                ''' <summary>(Set|Get) The Day_28 as Boolean.</summary>
                [Day_28] = 42
                ''' <summary>(Set|Get) The Day_29 as Boolean.</summary>
                [Day_29] = 43
                ''' <summary>(Set|Get) The Day_30 as Boolean.</summary>
                [Day_30] = 44
                ''' <summary>(Set|Get) The Day_31 as Boolean.</summary>
                [Day_31] = 45
                ''' <summary>(Set|Get) The Encrypt as Boolean.</summary>
                [Encrypt] = 46
                ''' <summary>(Set|Get) The Compress as Boolean.</summary>
                [Compress] = 47
                ''' <summary>(Set|Get) The NumberofOccurences as Integer.</summary>
                [NumberofOccurences] = 48
            End Enum
#End Region '(Set|Get) The enumeration of Schema.

#End Region
#Region "<4> [Sub]{5}"
#Region "[On] |2019/07/11 23h30:180| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
            '''    <Summary>
            '''     (Set|Get) This will reinitialize the class element.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:840 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) This will reinitialize the class element.")>
            Public Sub Clear()
                With Me
                    .Name = Nothing
                    .Source = Nothing
                    .Destination = Nothing
                    .Hours = 0
                    .Minutes = 0
                    .Monday = False
                    .Tuesday = False
                    .Wednesday = False
                    .Thursday = False
                    .Friday = False
                    .Saturday = False
                    .Sunday = False
                    .EveryDay = False
                    .EveryWeek = False
                    .EveryMonth = False
                    .Day_01 = False
                    .Day_02 = False
                    .Day_03 = False
                    .Day_04 = False
                    .Day_05 = False
                    .Day_06 = False
                    .Day_07 = False
                    .Day_08 = False
                    .Day_09 = False
                    .Day_10 = False
                    .Day_11 = False
                    .Day_12 = False
                    .Day_13 = False
                    .Day_14 = False
                    .Day_15 = False
                    .Day_16 = False
                    .Day_17 = False
                    .Day_18 = False
                    .Day_19 = False
                    .Day_20 = False
                    .Day_21 = False
                    .Day_22 = False
                    .Day_23 = False
                    .Day_24 = False
                    .Day_25 = False
                    .Day_26 = False
                    .Day_27 = False
                    .Day_28 = False
                    .Day_29 = False
                    .Day_30 = False
                    .Day_31 = False
                    .Encrypt = False
                    .Compress = False
                    .NumberofOccurences = 0
                End With
            End Sub
#End Region '(Set|Get) This will reinitialize the class element.

#Region "[On] |2019/07/11 23h30:198| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
            '''    <Summary>
            '''     (Set|Get) This will reinitialize the variables of this class.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:841 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) This will reinitialize the variables of this class.")>
            Public Sub Reset(Optional ByVal Connector As LineInfo = Nothing)
                If Not IsNothing(Connector) Then
                    Me.Connector = Connector
                    Me.FilePath = ""
                    Me.Password = ""
                    Me.Line = ""
                    If Connector.Status <> Status.Broken Then
                        FilePath = Connector.FilePath
                        Password = Connector.Password
                        Me.Connector = Connector
                        TableName = "Profile"
                        Line = Connector.Line
                        UseSQL = False
                    Else
                        FilePath = My.Settings.Db_Backup_FilePath
                        Password = My.Settings.Db_Backup_Password
                        Me.Line = My.Settings.Db_Backup_Line
                        TableName = "Profile"
                        UseSQL = False
                    End If
                Else
                    If IsNothing(FilePath) Then
                        FilePath = My.Settings.Db_Backup_FilePath
                    End If
                    If FilePath.Length < 1 Then
                        FilePath = My.Settings.Db_Backup_FilePath
                    End If
                    FilePath = My.Settings.Db_Backup_FilePath
                    Password = My.Settings.Db_Backup_Password
                    Me.Line = My.Settings.Db_Backup_Line
                    TableName = "Profile"
                    UseSQL = False
                End If

            End Sub
#End Region '(Set|Get) This will reinitialize the variables of this class.

#Region "[On] |2019/07/11 23h30:208| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
            '''    <Summary>
            '''     (Set|Get) This will add a new row in the table.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:843 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) This will add a new row in the table.")>
            Public Sub Add()
                Try
                    Dim Str As String = Nothing
                    Str = "Insert Into [Profile] (
`Name`, 
`Source`, 
`Destination`, 
`Hours`, 
`Minutes`, 
`Monday`, 
`Tuesday`, 
`Wednesday`, 
`Thursday`, 
`Friday`, 
`Saturday`, 
`Sunday`, 
`EveryDay`, 
`EveryWeek`, 
`EveryMonth`, 
`Day_01`, 
`Day_02`, 
`Day_03`, 
`Day_04`, 
`Day_05`, 
`Day_06`, 
`Day_07`, 
`Day_08`, 
`Day_09`, 
`Day_10`, 
`Day_11`, 
`Day_12`, 
`Day_13`, 
`Day_14`, 
`Day_15`, 
`Day_16`, 
`Day_17`, 
`Day_18`, 
`Day_19`, 
`Day_20`, 
`Day_21`, 
`Day_22`, 
`Day_23`, 
`Day_24`, 
`Day_25`, 
`Day_26`, 
`Day_27`, 
`Day_28`, 
`Day_29`, 
`Day_30`, 
`Day_31`, 
`Encrypt`, 
`Compress`, 
`NumberofOccurences`) Values (@0, @1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18, @19, @20, @21, @22, @23, @24, @25, @26, @27, @28, @29, @30, @31, @32, @33, @34, @35, @36, @37, @38, @39, @40, @41, @42, @43, @44, @45, @46, @47, @48)"
                    Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                    Cmd = New OleDb.OleDbCommand(Str, Con)
                    Con.Open()
                    Cmd.Parameters.AddWithValue("@0", Me.Name)
                    Cmd.Parameters.AddWithValue("@1", Me.Source)
                    Cmd.Parameters.AddWithValue("@2", Me.Destination)
                    Cmd.Parameters.AddWithValue("@3", Me.Hours)
                    Cmd.Parameters.AddWithValue("@4", Me.Minutes)
                    Cmd.Parameters.AddWithValue("@5", Me.Monday)
                    Cmd.Parameters.AddWithValue("@6", Me.Tuesday)
                    Cmd.Parameters.AddWithValue("@7", Me.Wednesday)
                    Cmd.Parameters.AddWithValue("@8", Me.Thursday)
                    Cmd.Parameters.AddWithValue("@9", Me.Friday)
                    Cmd.Parameters.AddWithValue("@10", Me.Saturday)
                    Cmd.Parameters.AddWithValue("@11", Me.Sunday)
                    Cmd.Parameters.AddWithValue("@12", Me.EveryDay)
                    Cmd.Parameters.AddWithValue("@13", Me.EveryWeek)
                    Cmd.Parameters.AddWithValue("@14", Me.EveryMonth)
                    Cmd.Parameters.AddWithValue("@15", Me.Day_01)
                    Cmd.Parameters.AddWithValue("@16", Me.Day_02)
                    Cmd.Parameters.AddWithValue("@17", Me.Day_03)
                    Cmd.Parameters.AddWithValue("@18", Me.Day_04)
                    Cmd.Parameters.AddWithValue("@19", Me.Day_05)
                    Cmd.Parameters.AddWithValue("@20", Me.Day_06)
                    Cmd.Parameters.AddWithValue("@21", Me.Day_07)
                    Cmd.Parameters.AddWithValue("@22", Me.Day_08)
                    Cmd.Parameters.AddWithValue("@23", Me.Day_09)
                    Cmd.Parameters.AddWithValue("@24", Me.Day_10)
                    Cmd.Parameters.AddWithValue("@25", Me.Day_11)
                    Cmd.Parameters.AddWithValue("@26", Me.Day_12)
                    Cmd.Parameters.AddWithValue("@27", Me.Day_13)
                    Cmd.Parameters.AddWithValue("@28", Me.Day_14)
                    Cmd.Parameters.AddWithValue("@29", Me.Day_15)
                    Cmd.Parameters.AddWithValue("@30", Me.Day_16)
                    Cmd.Parameters.AddWithValue("@31", Me.Day_17)
                    Cmd.Parameters.AddWithValue("@32", Me.Day_18)
                    Cmd.Parameters.AddWithValue("@33", Me.Day_19)
                    Cmd.Parameters.AddWithValue("@34", Me.Day_20)
                    Cmd.Parameters.AddWithValue("@35", Me.Day_21)
                    Cmd.Parameters.AddWithValue("@36", Me.Day_22)
                    Cmd.Parameters.AddWithValue("@37", Me.Day_23)
                    Cmd.Parameters.AddWithValue("@38", Me.Day_24)
                    Cmd.Parameters.AddWithValue("@39", Me.Day_25)
                    Cmd.Parameters.AddWithValue("@40", Me.Day_26)
                    Cmd.Parameters.AddWithValue("@41", Me.Day_27)
                    Cmd.Parameters.AddWithValue("@42", Me.Day_28)
                    Cmd.Parameters.AddWithValue("@43", Me.Day_29)
                    Cmd.Parameters.AddWithValue("@44", Me.Day_30)
                    Cmd.Parameters.AddWithValue("@45", Me.Day_31)
                    Cmd.Parameters.AddWithValue("@46", Me.Encrypt)
                    Cmd.Parameters.AddWithValue("@47", Me.Compress)
                    Cmd.Parameters.AddWithValue("@48", Me.NumberofOccurences)
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

#Region "[On] |2019/07/11 23h30:217| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
            '''    <Summary>
            '''     (Set|Get) This will update a row in the table.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:843 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) This will update a row in the table.")>
            Public Sub Save()
                Try
                    Dim Str As String = Nothing
                    Str = "UPDATE [Profile] SET Source = @Source, Destination = @Destination, Hours = @Hours, Minutes = @Minutes, Monday = @Monday, Tuesday = @Tuesday, Wednesday = @Wednesday, Thursday = @Thursday, Friday = @Friday, Saturday = @Saturday, Sunday = @Sunday, EveryDay = @EveryDay, EveryWeek = @EveryWeek, EveryMonth = @EveryMonth, Day_01 = @Day_01, Day_02 = @Day_02, Day_03 = @Day_03, Day_04 = @Day_04, Day_05 = @Day_05, Day_06 = @Day_06, Day_07 = @Day_07, Day_08 = @Day_08, Day_09 = @Day_09, Day_10 = @Day_10, Day_11 = @Day_11, Day_12 = @Day_12, Day_13 = @Day_13, Day_14 = @Day_14, Day_15 = @Day_15, Day_16 = @Day_16, Day_17 = @Day_17, Day_18 = @Day_18, Day_19 = @Day_19, Day_20 = @Day_20, Day_21 = @Day_21, Day_22 = @Day_22, Day_23 = @Day_23, Day_24 = @Day_24, Day_25 = @Day_25, Day_26 = @Day_26, Day_27 = @Day_27, Day_28 = @Day_28, Day_29 = @Day_29, Day_30 = @Day_30, Day_31 = @Day_31, Encrypt = @Encrypt, Compress = @Compress, NumberofOccurences = @NumberofOccurences WHERE Name = @Name"
                    Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                    Cmd = New OleDb.OleDbCommand(Str, Con)
                    Con.Open()
                    Cmd.Parameters.AddWithValue("@Source", Source)
                    Cmd.Parameters.AddWithValue("@Destination", Destination)
                    Cmd.Parameters.AddWithValue("@Hours", Hours)
                    Cmd.Parameters.AddWithValue("@Minutes", Minutes)
                    Cmd.Parameters.AddWithValue("@Monday", Monday)
                    Cmd.Parameters.AddWithValue("@Tuesday", Tuesday)
                    Cmd.Parameters.AddWithValue("@Wednesday", Wednesday)
                    Cmd.Parameters.AddWithValue("@Thursday", Thursday)
                    Cmd.Parameters.AddWithValue("@Friday", Friday)
                    Cmd.Parameters.AddWithValue("@Saturday", Saturday)
                    Cmd.Parameters.AddWithValue("@Sunday", Sunday)
                    Cmd.Parameters.AddWithValue("@EveryDay", EveryDay)
                    Cmd.Parameters.AddWithValue("@EveryWeek", EveryWeek)
                    Cmd.Parameters.AddWithValue("@EveryMonth", EveryMonth)
                    Cmd.Parameters.AddWithValue("@Day_01", Day_01)
                    Cmd.Parameters.AddWithValue("@Day_02", Day_02)
                    Cmd.Parameters.AddWithValue("@Day_03", Day_03)
                    Cmd.Parameters.AddWithValue("@Day_04", Day_04)
                    Cmd.Parameters.AddWithValue("@Day_05", Day_05)
                    Cmd.Parameters.AddWithValue("@Day_06", Day_06)
                    Cmd.Parameters.AddWithValue("@Day_07", Day_07)
                    Cmd.Parameters.AddWithValue("@Day_08", Day_08)
                    Cmd.Parameters.AddWithValue("@Day_09", Day_09)
                    Cmd.Parameters.AddWithValue("@Day_10", Day_10)
                    Cmd.Parameters.AddWithValue("@Day_11", Day_11)
                    Cmd.Parameters.AddWithValue("@Day_12", Day_12)
                    Cmd.Parameters.AddWithValue("@Day_13", Day_13)
                    Cmd.Parameters.AddWithValue("@Day_14", Day_14)
                    Cmd.Parameters.AddWithValue("@Day_15", Day_15)
                    Cmd.Parameters.AddWithValue("@Day_16", Day_16)
                    Cmd.Parameters.AddWithValue("@Day_17", Day_17)
                    Cmd.Parameters.AddWithValue("@Day_18", Day_18)
                    Cmd.Parameters.AddWithValue("@Day_19", Day_19)
                    Cmd.Parameters.AddWithValue("@Day_20", Day_20)
                    Cmd.Parameters.AddWithValue("@Day_21", Day_21)
                    Cmd.Parameters.AddWithValue("@Day_22", Day_22)
                    Cmd.Parameters.AddWithValue("@Day_23", Day_23)
                    Cmd.Parameters.AddWithValue("@Day_24", Day_24)
                    Cmd.Parameters.AddWithValue("@Day_25", Day_25)
                    Cmd.Parameters.AddWithValue("@Day_26", Day_26)
                    Cmd.Parameters.AddWithValue("@Day_27", Day_27)
                    Cmd.Parameters.AddWithValue("@Day_28", Day_28)
                    Cmd.Parameters.AddWithValue("@Day_29", Day_29)
                    Cmd.Parameters.AddWithValue("@Day_30", Day_30)
                    Cmd.Parameters.AddWithValue("@Day_31", Day_31)
                    Cmd.Parameters.AddWithValue("@Encrypt", Encrypt)
                    Cmd.Parameters.AddWithValue("@Compress", Compress)
                    Cmd.Parameters.AddWithValue("@NumberofOccurences", NumberofOccurences)
                    Cmd.Parameters.AddWithValue("@Name", Name)
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

#Region "[On] |2019/07/11 23h30:225| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
            '''    <Summary>
            '''     (Set|Get) This will Delete a row in the table.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:844 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) This will Delete a row in the table.")>
            Public Sub Delete()
                Try
                    Dim Str As String = Nothing
                    Str = "Delete From [Profile] WHERE Name =@Name"
                    Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                    Cmd = New OleDb.OleDbCommand(Str, Con)
                    Con.Open()
                    Cmd.Parameters.AddWithValue("@Name", Name)
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
#Region "[On] |2019/07/11 23h30:234| <05.00.00> <Function> <> |.Open()|TestItem}|"' (Set|Get) This will initialise the connection and import the data.
            '''    <Summary>
            '''     (Set|Get) This will initialise the connection and import the data.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:844 </Published>
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

#Region "[On] |2019/07/11 23h30:242| <05.00.01> <Function> <> |.Close()|TestItem}|"' (Set|Get) This willClosing the connection
            '''    <Summary>
            '''     (Set|Get) This willClosing the connection
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:844 </Published>
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

#Region "[On] |2019/07/11 23h30:251| <05.00.02> <Function> <> |.List()|List(Of Profile)}|"' (Set|Get) Return the entire table listed
            '''    <Summary>
            '''     (Set|Get) Return the entire table listed
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:844 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) Return the entire table listed")>
            Public Function List() As List(Of Profile)
                Dim Result As New List(Of Profile)
                Me.Table = New Table(Me.TableName, Me.FilePath, Me.Password, False)
                For Each Row As DataRow In Me.Table.DataTable.Rows
                    Dim Element As New Profile(IIf(IsDBNull(Row.Item(0)), "", Row.Item(0)),
IIf(IsDBNull(Row.Item(1)), "", Row.Item(1)),
IIf(IsDBNull(Row.Item(2)), "", Row.Item(2)),
IIf(IsDBNull(Row.Item(3)), 0, Row.Item(3)),
IIf(IsDBNull(Row.Item(4)), 0, Row.Item(4)),
IIf(IsDBNull(Row.Item(5)), False, Row.Item(5)),
IIf(IsDBNull(Row.Item(6)), False, Row.Item(6)),
IIf(IsDBNull(Row.Item(7)), False, Row.Item(7)),
IIf(IsDBNull(Row.Item(8)), False, Row.Item(8)),
IIf(IsDBNull(Row.Item(9)), False, Row.Item(9)),
IIf(IsDBNull(Row.Item(10)), False, Row.Item(10)),
IIf(IsDBNull(Row.Item(11)), False, Row.Item(11)),
IIf(IsDBNull(Row.Item(12)), False, Row.Item(12)),
IIf(IsDBNull(Row.Item(13)), False, Row.Item(13)),
IIf(IsDBNull(Row.Item(14)), False, Row.Item(14)),
IIf(IsDBNull(Row.Item(15)), False, Row.Item(15)),
IIf(IsDBNull(Row.Item(16)), False, Row.Item(16)),
IIf(IsDBNull(Row.Item(17)), False, Row.Item(17)),
IIf(IsDBNull(Row.Item(18)), False, Row.Item(18)),
IIf(IsDBNull(Row.Item(19)), False, Row.Item(19)),
IIf(IsDBNull(Row.Item(20)), False, Row.Item(20)),
IIf(IsDBNull(Row.Item(21)), False, Row.Item(21)),
IIf(IsDBNull(Row.Item(22)), False, Row.Item(22)),
IIf(IsDBNull(Row.Item(23)), False, Row.Item(23)),
IIf(IsDBNull(Row.Item(24)), False, Row.Item(24)),
IIf(IsDBNull(Row.Item(25)), False, Row.Item(25)),
IIf(IsDBNull(Row.Item(26)), False, Row.Item(26)),
IIf(IsDBNull(Row.Item(27)), False, Row.Item(27)),
IIf(IsDBNull(Row.Item(28)), False, Row.Item(28)),
IIf(IsDBNull(Row.Item(29)), False, Row.Item(29)),
IIf(IsDBNull(Row.Item(30)), False, Row.Item(30)),
IIf(IsDBNull(Row.Item(31)), False, Row.Item(31)),
IIf(IsDBNull(Row.Item(32)), False, Row.Item(32)),
IIf(IsDBNull(Row.Item(33)), False, Row.Item(33)),
IIf(IsDBNull(Row.Item(34)), False, Row.Item(34)),
IIf(IsDBNull(Row.Item(35)), False, Row.Item(35)),
IIf(IsDBNull(Row.Item(36)), False, Row.Item(36)),
IIf(IsDBNull(Row.Item(37)), False, Row.Item(37)),
IIf(IsDBNull(Row.Item(38)), False, Row.Item(38)),
IIf(IsDBNull(Row.Item(39)), False, Row.Item(39)),
IIf(IsDBNull(Row.Item(40)), False, Row.Item(40)),
IIf(IsDBNull(Row.Item(41)), False, Row.Item(41)),
IIf(IsDBNull(Row.Item(42)), False, Row.Item(42)),
IIf(IsDBNull(Row.Item(43)), False, Row.Item(43)),
IIf(IsDBNull(Row.Item(44)), False, Row.Item(44)),
IIf(IsDBNull(Row.Item(45)), False, Row.Item(45)),
IIf(IsDBNull(Row.Item(46)), False, Row.Item(46)),
IIf(IsDBNull(Row.Item(47)), False, Row.Item(47)),
      IIf(IsDBNull(Row.Item(48)), 0, Row.Item(48)))
                    Element.Reset(Table.Line)
                    Result.Add(Element)
                Next
                Return Result
            End Function
#End Region '(Set|Get) Return the entire table listed

#Region "[On] |2019/07/11 23h30:260| <05.00.03> <Function> <> |.SearchByName()|List(Of Profile)}|"' (Set|Get) Search for each property that match the Search String.
            '''    <Summary>
            '''     (Set|Get) Search for each property that match the Search String.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:845 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) Search for each property that match the Search String.")>
            Public Shared Function SearchByName(ByVal Search As String) As List(Of Profile)
                Dim Result As New List(Of Profile)
                Dim C As New Profile
                For Each Element As Profile In C.List
                    If Element.Name.ToLower() = Search.ToLower() Or Element.Source.ToLower() = Search.ToLower() Or Element.Destination.ToLower() = Search.ToLower() Then
                        Result.Add(Element)
                    End If
                Next
                Return Result
            End Function
#End Region '(Set|Get) Search for each property that match the Search String.

#Region "[On] |2019/07/11 23h30:269| <05.00.04> <Function> <> |.SearchByID()|List(Of Profile)}|"' (Set|Get) Search for each property that match the Search Id.
            '''    <Summary>
            '''     (Set|Get) Search for each property that match the Search Id.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:845 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) Search for each property that match the Search Id.")>
            Public Shared Function SearchByID(ByVal Search As Double) As List(Of Profile)
                Dim Result As New List(Of Profile)
                Dim C As New Profile
                For Each Element As Profile In C.List
                    If Val(Element.Hours) = Search Or Val(Element.Minutes) = Search Or Val(Element.NumberofOccurences) = Search Then
                        Result.Add(Element)
                    End If
                Next
                Return Result
            End Function
#End Region '(Set|Get) Search for each property that match the Search Id.

#Region "[On] |2019/07/11 23h30:282| <05.00.05> <Function> <> |.ToString()|String}|"' (Set|Get) The function ToString.
            '''    <Summary>
            '''     (Set|Get) The function ToString.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:845 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The function ToString.")>
            Public Overrides Function ToString() As String
                Return Me.Name
            End Function
#End Region '(Set|Get) The function ToString.

#Region "[On] |2019/07/11 23h30:292| <05.00.06> <Function> <> |.CheckConnection()|Boolean}|"' (Set|Get) Evaluate the connection to the DataBase
            '''    <Summary>
            '''     (Set|Get) Evaluate the connection to the DataBase
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:848 </Published>
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
#Region "[On] |2019/07/11 23h30:302| <15.00.00> <Runtime> <> |.Table()|Table"' (Set|Get) The Table.
            '''    <Summary>
            '''     (Set|Get) The Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:848 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Table.")>
            Public Table As Table
#End Region '(Set|Get) The Table.

#Region "[On] |2019/07/11 23h30:314| <15.00.01> <Runtime> <> |.Line()|String"' (Set|Get) The Connection String To the Table.
            '''    <Summary>
            '''     (Set|Get) The Connection String To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:848 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Connection String To the Table.")>
            Public Line As String
#End Region '(Set|Get) The Connection String To the Table.

#Region "[On] |2019/07/11 23h30:325| <15.00.02> <Runtime> <> |.FilePath()|String"' (Set|Get) The FilePath To the Table.
            '''    <Summary>
            '''     (Set|Get) The FilePath To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:849 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The FilePath To the Table.")>
            Public FilePath As String
#End Region '(Set|Get) The FilePath To the Table.

#Region "[On] |2019/07/11 23h30:335| <15.00.03> <Runtime> <> |.Password()|String"' (Set|Get) The Password To the Table.
            '''    <Summary>
            '''     (Set|Get) The Password To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:849 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Password To the Table.")>
            Public Password As String
#End Region '(Set|Get) The Password To the Table.

#Region "[On] |2019/07/11 23h30:346| <15.00.04> <Runtime> <> |.UseSQL()|Boolean"' (Set|Get) Determines if the Database Connection is of type SQL.
            '''    <Summary>
            '''     (Set|Get) Determines if the Database Connection is of type SQL.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:851 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) Determines if the Database Connection is of type SQL.")>
            Public UseSQL As Boolean
#End Region '(Set|Get) Determines if the Database Connection is of type SQL.

#Region "[On] |2019/07/11 23h30:355| <15.00.05> <Runtime> <> |.TableName()|String"' (Set|Get) The name of the Table.
            '''    <Summary>
            '''     (Set|Get) The name of the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:852 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The name of the Table.")>
            Public TableName As String
#End Region '(Set|Get) The name of the Table.

#Region "[On] |2019/07/11 23h30:367| <15.00.06> <Runtime> <> |.Con()|OleDb.OleDbConnection"' (Set|Get) The Con To the Table.
            '''    <Summary>
            '''     (Set|Get) The Con To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:852 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Con To the Table.")>
            Public Con As OleDb.OleDbConnection
#End Region '(Set|Get) The Con To the Table.

#Region "[On] |2019/07/11 23h30:374| <15.00.07> <Runtime> <> |.Cmd()|OleDb.OleDbCommand"' (Set|Get) The Cmd To the Table.
            '''    <Summary>
            '''     (Set|Get) The Cmd To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:852 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Cmd To the Table.")>
            Public Cmd As OleDb.OleDbCommand
#End Region '(Set|Get) The Cmd To the Table.

#Region "[On] |2019/07/11 23h30:386| <15.00.08> <Runtime> <> |.DataReader()|OleDb.OleDbDataReader"' (Set|Get) The DataReader To the Table.
            '''    <Summary>
            '''     (Set|Get) The DataReader To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:852 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The DataReader To the Table.")>
            Public DataReader As OleDb.OleDbDataReader
#End Region '(Set|Get) The DataReader To the Table.

#Region "[On] |2019/07/11 23h30:396| <15.00.09> <Runtime> <> |.DataAdapter()|OleDb.OleDbDataAdapter"' (Set|Get) The DataAdapter To the Table.
            '''    <Summary>
            '''     (Set|Get) The DataAdapter To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:853 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The DataAdapter To the Table.")>
            Public DataAdapter As OleDb.OleDbDataAdapter
#End Region '(Set|Get) The DataAdapter To the Table.

#Region "[On] |2019/07/11 23h30:421| <15.00.10> <Runtime> <> |.Connector()|LineInfo"' (Set|Get) The Connector To the Table.
            '''    <Summary>
            '''     (Set|Get) The Connector To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:853 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Connector To the Table.")>
            Public Connector As LineInfo
#End Region '(Set|Get) The Connector To the Table.

#Region "[On] |2019/07/11 23h30:431| <15.00.11> <Runtime> <> |.Log()|String"' (Set|Get) The Log To the Table.
            '''    <Summary>
            '''     (Set|Get) The Log To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:853 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Log To the Table.")>
            Public Log As String
#End Region '(Set|Get) The Log To the Table.

#End Region
#Region "<7> [Loader]{2}"
#Region "[On] |2019/07/11 23h30:442| <06.00.00> <Loader> <> |.Empty()|Function}|"' (Set|Get) The sub Empty.
            '''    <Summary>
            '''     (Set|Get) The sub Empty.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:854 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The sub Empty.")>
            Public Sub New()
                Reset()
            End Sub
#End Region '(Set|Get) The sub Empty.

#Region "[On] |2019/07/11 23h30:446| <06.00.01> <Loader> <> |.Filled()|Function}|"' (Set|Get) The sub Filled.
            '''    <Summary>
            '''     (Set|Get) The sub Filled.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:854 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>    ''' <param name="Name">(Set|Get) The Name as String.</param>
            ''' <param name="Source">(Set|Get) The Source as String.</param>
            ''' <param name="Destination">(Set|Get) The Destination as String.</param>
            ''' <param name="Hours">(Set|Get) The Hours as Integer.</param>
            ''' <param name="Minutes">(Set|Get) The Minutes as Integer.</param>
            ''' <param name="Monday">(Set|Get) The Monday as Boolean.</param>
            ''' <param name="Tuesday">(Set|Get) The Tuesday as Boolean.</param>
            ''' <param name="Wednesday">(Set|Get) The Wednesday as Boolean.</param>
            ''' <param name="Thursday">(Set|Get) The Thursday as Boolean.</param>
            ''' <param name="Friday">(Set|Get) The Friday as Boolean.</param>
            ''' <param name="Saturday">(Set|Get) The Saturday as Boolean.</param>
            ''' <param name="Sunday">(Set|Get) The Sunday as Boolean.</param>
            ''' <param name="EveryDay">(Set|Get) The EveryDay as Boolean.</param>
            ''' <param name="EveryWeek">(Set|Get) The EveryWeek as Boolean.</param>
            ''' <param name="EveryMonth">(Set|Get) The EveryMonth as Boolean.</param>
            ''' <param name="Day_01">(Set|Get) The Day_01 as Boolean.</param>
            ''' <param name="Day_02">(Set|Get) The Day_02 as Boolean.</param>
            ''' <param name="Day_03">(Set|Get) The Day_03 as Boolean.</param>
            ''' <param name="Day_04">(Set|Get) The Day_04 as Boolean.</param>
            ''' <param name="Day_05">(Set|Get) The Day_05 as Boolean.</param>
            ''' <param name="Day_06">(Set|Get) The Day_06 as Boolean.</param>
            ''' <param name="Day_07">(Set|Get) The Day_07 as Boolean.</param>
            ''' <param name="Day_08">(Set|Get) The Day_08 as Boolean.</param>
            ''' <param name="Day_09">(Set|Get) The Day_09 as Boolean.</param>
            ''' <param name="Day_10">(Set|Get) The Day_10 as Boolean.</param>
            ''' <param name="Day_11">(Set|Get) The Day_11 as Boolean.</param>
            ''' <param name="Day_12">(Set|Get) The Day_12 as Boolean.</param>
            ''' <param name="Day_13">(Set|Get) The Day_13 as Boolean.</param>
            ''' <param name="Day_14">(Set|Get) The Day_14 as Boolean.</param>
            ''' <param name="Day_15">(Set|Get) The Day_15 as Boolean.</param>
            ''' <param name="Day_16">(Set|Get) The Day_16 as Boolean.</param>
            ''' <param name="Day_17">(Set|Get) The Day_17 as Boolean.</param>
            ''' <param name="Day_18">(Set|Get) The Day_18 as Boolean.</param>
            ''' <param name="Day_19">(Set|Get) The Day_19 as Boolean.</param>
            ''' <param name="Day_20">(Set|Get) The Day_20 as Boolean.</param>
            ''' <param name="Day_21">(Set|Get) The Day_21 as Boolean.</param>
            ''' <param name="Day_22">(Set|Get) The Day_22 as Boolean.</param>
            ''' <param name="Day_23">(Set|Get) The Day_23 as Boolean.</param>
            ''' <param name="Day_24">(Set|Get) The Day_24 as Boolean.</param>
            ''' <param name="Day_25">(Set|Get) The Day_25 as Boolean.</param>
            ''' <param name="Day_26">(Set|Get) The Day_26 as Boolean.</param>
            ''' <param name="Day_27">(Set|Get) The Day_27 as Boolean.</param>
            ''' <param name="Day_28">(Set|Get) The Day_28 as Boolean.</param>
            ''' <param name="Day_29">(Set|Get) The Day_29 as Boolean.</param>
            ''' <param name="Day_30">(Set|Get) The Day_30 as Boolean.</param>
            ''' <param name="Day_31">(Set|Get) The Day_31 as Boolean.</param>
            ''' <param name="Encrypt">(Set|Get) The Encrypt as Boolean.</param>
            ''' <param name="Compress">(Set|Get) The Compress as Boolean.</param>
            ''' <param name="NumberofOccurences">(Set|Get) The NumberofOccurences as Integer.</param>

            <Browsable(True), Description("(Set|Get) The sub Filled.")>
            Public Sub New(ByVal Name As String,
ByVal Source As String,
ByVal Destination As String,
ByVal Hours As Integer,
ByVal Minutes As Integer,
ByVal Monday As Boolean,
ByVal Tuesday As Boolean,
ByVal Wednesday As Boolean,
ByVal Thursday As Boolean,
ByVal Friday As Boolean,
ByVal Saturday As Boolean,
ByVal Sunday As Boolean,
ByVal EveryDay As Boolean,
ByVal EveryWeek As Boolean,
ByVal EveryMonth As Boolean,
ByVal Day_01 As Boolean,
ByVal Day_02 As Boolean,
ByVal Day_03 As Boolean,
ByVal Day_04 As Boolean,
ByVal Day_05 As Boolean,
ByVal Day_06 As Boolean,
ByVal Day_07 As Boolean,
ByVal Day_08 As Boolean,
ByVal Day_09 As Boolean,
ByVal Day_10 As Boolean,
ByVal Day_11 As Boolean,
ByVal Day_12 As Boolean,
ByVal Day_13 As Boolean,
ByVal Day_14 As Boolean,
ByVal Day_15 As Boolean,
ByVal Day_16 As Boolean,
ByVal Day_17 As Boolean,
ByVal Day_18 As Boolean,
ByVal Day_19 As Boolean,
ByVal Day_20 As Boolean,
ByVal Day_21 As Boolean,
ByVal Day_22 As Boolean,
ByVal Day_23 As Boolean,
ByVal Day_24 As Boolean,
ByVal Day_25 As Boolean,
ByVal Day_26 As Boolean,
ByVal Day_27 As Boolean,
ByVal Day_28 As Boolean,
ByVal Day_29 As Boolean,
ByVal Day_30 As Boolean,
ByVal Day_31 As Boolean,
ByVal Encrypt As Boolean,
ByVal Compress As Boolean,
ByVal NumberofOccurences As Integer)
                With Me
                    Clear()
                    Reset()
                    .Name = Name
                    .Source = Source
                    .Destination = Destination
                    .Hours = Hours
                    .Minutes = Minutes
                    .Monday = Monday
                    .Tuesday = Tuesday
                    .Wednesday = Wednesday
                    .Thursday = Thursday
                    .Friday = Friday
                    .Saturday = Saturday
                    .Sunday = Sunday
                    .EveryDay = EveryDay
                    .EveryWeek = EveryWeek
                    .EveryMonth = EveryMonth
                    .Day_01 = Day_01
                    .Day_02 = Day_02
                    .Day_03 = Day_03
                    .Day_04 = Day_04
                    .Day_05 = Day_05
                    .Day_06 = Day_06
                    .Day_07 = Day_07
                    .Day_08 = Day_08
                    .Day_09 = Day_09
                    .Day_10 = Day_10
                    .Day_11 = Day_11
                    .Day_12 = Day_12
                    .Day_13 = Day_13
                    .Day_14 = Day_14
                    .Day_15 = Day_15
                    .Day_16 = Day_16
                    .Day_17 = Day_17
                    .Day_18 = Day_18
                    .Day_19 = Day_19
                    .Day_20 = Day_20
                    .Day_21 = Day_21
                    .Day_22 = Day_22
                    .Day_23 = Day_23
                    .Day_24 = Day_24
                    .Day_25 = Day_25
                    .Day_26 = Day_26
                    .Day_27 = Day_27
                    .Day_28 = Day_28
                    .Day_29 = Day_29
                    .Day_30 = Day_30
                    .Day_31 = Day_31
                    .Encrypt = Encrypt
                    .Compress = Compress
                    .NumberofOccurences = NumberofOccurences
                End With

            End Sub
#End Region '(Set|Get) The sub Filled.

#End Region
        End Class
#End Region

#Region "[On] |2019/07/16 14h48:788| <08.00.00> <Class> <> |.Save_Entry|Class|{35} |Production Cost : 40.9|Selling Price : 102.25|"' Class created automatically by SmartOffice (c)Copyright 2019.
        '''    <Summary>
        '''     Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Save_Entry
        '''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
        '''    Contributor Information : ||
        '''    Creation Date :           2019/07/16 14h48:788
        '''    |Schema|
        '''    |ID| |ObjectType |{Quantity}||UnitPrice||Total
        '''    |00| |Importation|{0}||1| |0
        '''    |01| |Properties |{8}||0.8| |6.4
        '''    |02| |Enumeration|{1}||0.4| |0.4
        '''    |03| |Structure  |{0}||0.4| |0
        '''    |04| |Sub        |{5}||1.2| |6
        '''    |05| |Function   |{7}||1.6| |11.2
        '''    |06| |Runtime    |{12}||0.4| |4.8
        '''    |07| |Loader     |{2}||0.8| |1.6
        '''    |08| |Class      |{0}||2| |0
        '''    |09| |Constante  |{0}||0.4| |0
        '''    |10| |Event      |{0}||1.2| |0
        '''    |11| |Members    |{8}||0.5| |4
        '''    |12| |Parameter  |{13}||0.5| |6.5
        '''    |Production Cost             |40.9
        '''    |Selling Price without VAT   |102.25
        '''    |Total TVA                   |7.87
        '''    |Grand Total                 |110.12
        '''    |/Schema|
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/16 14h48:872 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        Public Class Save_Entry
#Region "<1> [Property]{8}"
#Region "[On] |2019/07/16 14h48:791| <01.00.00> <Property> <Columns> |.Name()|String|"' (Set|Get) The Name as String.
            Private _Name As String
            '''    <Summary>
            '''     (Set|Get) The Name as String.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/16 14h48:872 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Name as String.")>
            Public Property Name() As String
                Get
                    Return _Name
                End Get
                Set(ByVal Value As String)
                    _Name = Value
                End Set
            End Property
#End Region '(Set|Get) The Name as String.

#Region "[On] |2019/07/16 14h48:013| <01.00.01> <Property> <Columns> |.Profile()|String|"' (Set|Get) The Profile as String.
            Private _Profile As String
            '''    <Summary>
            '''     (Set|Get) The Profile as String.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/16 14h48:873 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Profile as String.")>
            Public Property Profile() As String
                Get
                    Return _Profile
                End Get
                Set(ByVal Value As String)
                    _Profile = Value
                End Set
            End Property
#End Region '(Set|Get) The Profile as String.

#Region "[On] |2019/07/16 14h48:020| <01.00.02> <Property> <Columns> |.DateSaved()|DateTime|"' (Set|Get) The DateSaved as DateTime.
            Private _DateSaved As DateTime
            '''    <Summary>
            '''     (Set|Get) The DateSaved as DateTime.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/16 14h48:873 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The DateSaved as DateTime.")>
            Public Property DateSaved() As DateTime
                Get
                    Return _DateSaved
                End Get
                Set(ByVal Value As DateTime)
                    _DateSaved = Value
                End Set
            End Property
#End Region '(Set|Get) The DateSaved as DateTime.

#Region "[On] |2019/07/16 14h48:026| <01.00.03> <Property> <Columns> |.Root()|String|"' (Set|Get) The Root as String.
            Private _Root As String
            '''    <Summary>
            '''     (Set|Get) The Root as String.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/16 14h48:873 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Root as String.")>
            Public Property Root() As String
                Get
                    Return _Root
                End Get
                Set(ByVal Value As String)
                    _Root = Value
                End Set
            End Property
#End Region '(Set|Get) The Root as String.

#Region "[On] |2019/07/16 14h48:033| <01.00.04> <Property> <Columns> |.Origine()|String|"' (Set|Get) The Origine as String.
            Private _Origine As String
            '''    <Summary>
            '''     (Set|Get) The Origine as String.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/16 14h48:874 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Origine as String.")>
            Public Property Origine() As String
                Get
                    Return _Origine
                End Get
                Set(ByVal Value As String)
                    _Origine = Value
                End Set
            End Property
#End Region '(Set|Get) The Origine as String.

#Region "[On] |2019/07/16 14h48:044| <01.00.05> <Property> <Columns> |.ProfileIndex()|Double|"' (Set|Get) The ProfileIndex as Double.
            Private _ProfileIndex As Double
            '''    <Summary>
            '''     (Set|Get) The ProfileIndex as Double.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/16 14h48:874 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The ProfileIndex as Double.")>
            Public Property ProfileIndex() As Double
                Get
                    Return _ProfileIndex
                End Get
                Set(ByVal Value As Double)
                    _ProfileIndex = Value
                End Set
            End Property
#End Region '(Set|Get) The ProfileIndex as Double.

#Region "[On] |2019/07/16 14h48:053| <01.00.06> <Property> <Columns> |.Size()|Double|"' (Set|Get) The Size as Double.
            Private _Size As Double
            '''    <Summary>
            '''     (Set|Get) The Size as Double.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/16 14h48:874 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Size as Double.")>
            Public Property Size() As Double
                Get
                    Return _Size
                End Get
                Set(ByVal Value As Double)
                    _Size = Value
                End Set
            End Property
#End Region '(Set|Get) The Size as Double.

#Region "[On] |2019/07/16 14h48:062| <01.00.07> <Property> <Columns> |.CandidateForDelete()|Boolean|"' (Set|Get) The CandidateForDelete as Boolean.
            Private _CandidateForDelete As Boolean
            '''    <Summary>
            '''     (Set|Get) The CandidateForDelete as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/16 14h48:874 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The CandidateForDelete as Boolean.")>
            Public Property CandidateForDelete() As Boolean
                Get
                    Return _CandidateForDelete
                End Get
                Set(ByVal Value As Boolean)
                    _CandidateForDelete = Value
                End Set
            End Property
#End Region '(Set|Get) The CandidateForDelete as Boolean.
            Public ListArchives As List(Of Archives_Data)
#End Region
#Region "<2> [Enumeration]{1}"
#Region "[On] |2019/07/16 14h48:071| <02.00.00> <Enumeration> <> |.Schema()|Enumeration{7}|"' (Set|Get) The enumeration of Schema.
            '''    <Summary>
            '''     (Set|Get) The enumeration of Schema.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/16 14h48:875 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The enumeration of Schema.")>
            Enum Schema
                ''' <summary>(Set|Get) The Name as String.</summary>
                [Name] = 0
                ''' <summary>(Set|Get) The Profile as String.</summary>
                [Profile] = 1
                ''' <summary>(Set|Get) The DateSaved as DateTime.</summary>
                [DateSaved] = 2
                ''' <summary>(Set|Get) The Root as String.</summary>
                [Root] = 3
                ''' <summary>(Set|Get) The Origine as String.</summary>
                [Origine] = 4
                ''' <summary>(Set|Get) The ProfileIndex as Integer.</summary>
                [ProfileIndex] = 5
                ''' <summary>(Set|Get) The Size as Double.</summary>
                [Size] = 6
                ''' <summary>(Set|Get) The CandidateForDelete as Boolean.</summary>
                [CandidateForDelete] = 7
            End Enum
#End Region '(Set|Get) The enumeration of Schema.

#End Region
#Region "<4> [Sub]{5}"
#Region "[On] |2019/07/16 14h48:201| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
            '''    <Summary>
            '''     (Set|Get) This will reinitialize the class element.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/16 14h48:875 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) This will reinitialize the class element.")>
            Public Sub Clear()
                With Me
                    .Name = Nothing
                    .Profile = Nothing
                    .DateSaved = New DateTime
                    .Root = Nothing
                    .Origine = Nothing
                    .ProfileIndex = 0
                    .Size = 0
                    .CandidateForDelete = False
                End With
            End Sub
#End Region '(Set|Get) This will reinitialize the class element.

#Region "[On] |2019/07/16 14h48:343| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
            '''    <Summary>
            '''     (Set|Get) This will reinitialize the variables of this class.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/16 14h48:875 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) This will reinitialize the variables of this class.")>
            Public Sub Reset(Optional ByVal Connector As LineInfo = Nothing)
                If Not IsNothing(Connector) Then
                    Me.Connector = Connector
                    Me.FilePath = ""
                    Me.Password = ""
                    Me.Line = ""
                    If Connector.Status <> Status.Broken Then
                        FilePath = Connector.FilePath
                        Password = Connector.Password
                        Me.Connector = Connector
                        TableName = "Save_Entry"
                        Line = Connector.Line
                        UseSQL = False
                    Else
                        FilePath = My.Settings.Db_Backup_FilePath
                        Password = My.Settings.Db_Backup_Password
                        Me.Line = My.Settings.Db_Backup_Line
                        TableName = "Save_Entry"
                        UseSQL = False
                    End If
                Else
                    If IsNothing(FilePath) Then
                        FilePath = My.Settings.Db_Backup_FilePath
                    End If
                    If FilePath.Length < 1 Then
                        FilePath = My.Settings.Db_Backup_FilePath
                    End If
                    FilePath = My.Settings.Db_Backup_FilePath
                    Password = My.Settings.Db_Backup_Password
                    Me.Line = My.Settings.Db_Backup_Line
                    TableName = "Save_Entry"
                    UseSQL = False
                End If

            End Sub
#End Region '(Set|Get) This will reinitialize the variables of this class.

#Region "[On] |2019/07/16 14h48:372| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
            '''    <Summary>
            '''     (Set|Get) This will add a new row in the table.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/16 14h48:875 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) This will add a new row in the table.")>
            Public Sub Add()
                Try
                    Dim Str As String = Nothing
                    Str = "Insert Into [Save_Entry] (
`Name`, 
`Profile`, 
`DateSaved`, 
`Root`, 
`Origine`, 
`ProfileIndex`, 
`Size`, 
`CandidateForDelete`) Values (@0, @1, @2, @3, @4, @5, @6, @7)"
                    Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                    Cmd = New OleDb.OleDbCommand(Str, Con)
                    Con.Open()
                    Cmd.Parameters.AddWithValue("@0", Me.Name)
                    Cmd.Parameters.AddWithValue("@1", Me.Profile)
                    Cmd.Parameters.AddWithValue("@2", Me.DateSaved)
                    Cmd.Parameters.AddWithValue("@3", Me.Root)
                    Cmd.Parameters.AddWithValue("@4", Me.Origine)
                    Cmd.Parameters.AddWithValue("@5", Me.ProfileIndex)
                    Cmd.Parameters.AddWithValue("@6", Me.Size)
                    Cmd.Parameters.AddWithValue("@7", Me.CandidateForDelete)
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

#Region "[On] |2019/07/16 14h48:381| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
            '''    <Summary>
            '''     (Set|Get) This will update a row in the table.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/16 14h48:875 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) This will update a row in the table.")>
            Public Sub Save()
                Try
                    Dim Str As String = Nothing
                    Str = "UPDATE [Save_Entry] SET Profile = @Profile, DateSaved = @DateSaved, Root = @Root, Origine = @Origine, ProfileIndex = @ProfileIndex, Size = @Size, CandidateForDelete = @CandidateForDelete WHERE Name = @Name"
                    Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                    Cmd = New OleDb.OleDbCommand(Str, Con)
                    Con.Open()
                    Cmd.Parameters.AddWithValue("@Profile", Profile)
                    Cmd.Parameters.AddWithValue("@DateSaved", DateSaved)
                    Cmd.Parameters.AddWithValue("@Root", Root)
                    Cmd.Parameters.AddWithValue("@Origine", Origine)
                    Cmd.Parameters.AddWithValue("@ProfileIndex", ProfileIndex)
                    Cmd.Parameters.AddWithValue("@Size", Size)
                    Cmd.Parameters.AddWithValue("@CandidateForDelete", CandidateForDelete)
                    Cmd.Parameters.AddWithValue("@Name", Name)
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

#Region "[On] |2019/07/16 14h48:390| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
            '''    <Summary>
            '''     (Set|Get) This will Delete a row in the table.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/16 14h48:875 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) This will Delete a row in the table.")>
            Public Sub Delete()
                Try
                    Dim Str As String = Nothing
                    Str = "Delete From [Save_Entry] WHERE Name =@Name"
                    Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                    Cmd = New OleDb.OleDbCommand(Str, Con)
                    Con.Open()
                    Cmd.Parameters.AddWithValue("@Name", Name)
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
#Region "[On] |2019/07/16 14h48:404| <05.00.00> <Function> <> |.Open()|TestItem}|"' (Set|Get) This will initialise the connection and import the data.
            '''    <Summary>
            '''     (Set|Get) This will initialise the connection and import the data.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/16 14h48:875 </Published>
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

#Region "[On] |2019/07/16 14h48:544| <05.00.01> <Function> <> |.Close()|TestItem}|"' (Set|Get) This willClosing the connection
            '''    <Summary>
            '''     (Set|Get) This willClosing the connection
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/16 14h48:875 </Published>
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

#Region "[On] |2019/07/16 14h48:553| <05.00.02> <Function> <> |.List()|List(Of Save_Entry)}|"' (Set|Get) Return the entire table listed
            '''    <Summary>
            '''     (Set|Get) Return the entire table listed
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/16 14h48:876 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) Return the entire table listed")>
            Public Function List() As List(Of Save_Entry)
                Dim Result As New List(Of Save_Entry)
                Me.Table = New Table(Me.TableName, Me.FilePath, Me.Password, False)
                For Each Row As DataRow In Me.Table.DataTable.Rows
                    Dim Element As New Save_Entry(IIf(IsDBNull(Row.Item(0)), "", Row.Item(0)),
IIf(IsDBNull(Row.Item(1)), "", Row.Item(1)),
IIf(IsDBNull(Row.Item(2)), New DateTime(1970, 1, 1), Row.Item(2)),
IIf(IsDBNull(Row.Item(3)), "", Row.Item(3)),
IIf(IsDBNull(Row.Item(4)), "", Row.Item(4)),
IIf(IsDBNull(Row.Item(5)), 0, Row.Item(5)),
IIf(IsDBNull(Row.Item(6)), 0, Row.Item(6)),
      IIf(IsDBNull(Row.Item(7)), False, Row.Item(7)))
                    Element.Reset(Table.Line)
                    Result.Add(Element)
                Next
                Return Result
            End Function
#End Region '(Set|Get) Return the entire table listed

#Region "[On] |2019/07/16 14h48:563| <05.00.03> <Function> <> |.SearchByName()|List(Of Save_Entry)}|"' (Set|Get) Search for each property that match the Search String.
            '''    <Summary>
            '''     (Set|Get) Search for each property that match the Search String.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/16 14h48:876 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) Search for each property that match the Search String.")>
            Public Shared Function SearchByName(ByVal Search As String) As List(Of Save_Entry)
                Dim Result As New List(Of Save_Entry)
                Dim C As New Save_Entry
                For Each Element As Save_Entry In C.List
                    If Element.Name.ToLower() = Search.ToLower() Or Element.Profile.ToLower() = Search.ToLower() Or Element.Root.ToLower() = Search.ToLower() Or Element.Origine.ToLower() = Search.ToLower() Then
                        Result.Add(Element)
                    End If
                Next
                Return Result
            End Function
#End Region '(Set|Get) Search for each property that match the Search String.

#Region "[On] |2019/07/16 14h48:575| <05.00.04> <Function> <> |.SearchByID()|List(Of Save_Entry)}|"' (Set|Get) Search for each property that match the Search Id.
            '''    <Summary>
            '''     (Set|Get) Search for each property that match the Search Id.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/16 14h48:876 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) Search for each property that match the Search Id.")>
            Public Shared Function SearchByID(ByVal Search As Double) As List(Of Save_Entry)
                Dim Result As New List(Of Save_Entry)
                Dim C As New Save_Entry
                For Each Element As Save_Entry In C.List
                    If Val(Element.ProfileIndex) = Search Or Val(Element.Size) = Search Then
                        Result.Add(Element)
                    End If
                Next
                Return Result
            End Function
#End Region '(Set|Get) Search for each property that match the Search Id.

#Region "[On] |2019/07/16 14h48:582| <05.00.05> <Function> <> |.ToString()|String}|"' (Set|Get) The function ToString.
            '''    <Summary>
            '''     (Set|Get) The function ToString.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/16 14h48:876 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The function ToString.")>
            Public Overrides Function ToString() As String
                Return Me.Name
            End Function
#End Region '(Set|Get) The function ToString.

#Region "[On] |2019/07/16 14h48:590| <05.00.06> <Function> <> |.CheckConnection()|Boolean}|"' (Set|Get) Evaluate the connection to the DataBase
            '''    <Summary>
            '''     (Set|Get) Evaluate the connection to the DataBase
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/16 14h48:876 </Published>
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
#Region "[On] |2019/07/16 14h48:602| <15.00.00> <Runtime> <> |.Table()|Table"' (Set|Get) The Table.
            '''    <Summary>
            '''     (Set|Get) The Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/16 14h48:877 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Table.")>
            Public Table As Table
#End Region '(Set|Get) The Table.

#Region "[On] |2019/07/16 14h48:755| <15.00.01> <Runtime> <> |.Line()|String"' (Set|Get) The Connection String To the Table.
            '''    <Summary>
            '''     (Set|Get) The Connection String To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/16 14h48:877 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Connection String To the Table.")>
            Public Line As String
#End Region '(Set|Get) The Connection String To the Table.

#Region "[On] |2019/07/16 14h48:763| <15.00.02> <Runtime> <> |.FilePath()|String"' (Set|Get) The FilePath To the Table.
            '''    <Summary>
            '''     (Set|Get) The FilePath To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/16 14h48:877 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The FilePath To the Table.")>
            Public FilePath As String
#End Region '(Set|Get) The FilePath To the Table.

#Region "[On] |2019/07/16 14h48:772| <15.00.03> <Runtime> <> |.Password()|String"' (Set|Get) The Password To the Table.
            '''    <Summary>
            '''     (Set|Get) The Password To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/16 14h48:877 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Password To the Table.")>
            Public Password As String
#End Region '(Set|Get) The Password To the Table.

#Region "[On] |2019/07/16 14h48:781| <15.00.04> <Runtime> <> |.UseSQL()|Boolean"' (Set|Get) Determines if the Database Connection is of type SQL.
            '''    <Summary>
            '''     (Set|Get) Determines if the Database Connection is of type SQL.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/16 14h48:878 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) Determines if the Database Connection is of type SQL.")>
            Public UseSQL As Boolean
#End Region '(Set|Get) Determines if the Database Connection is of type SQL.

#Region "[On] |2019/07/16 14h48:790| <15.00.05> <Runtime> <> |.TableName()|String"' (Set|Get) The name of the Table.
            '''    <Summary>
            '''     (Set|Get) The name of the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/16 14h48:878 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The name of the Table.")>
            Public TableName As String
#End Region '(Set|Get) The name of the Table.

#Region "[On] |2019/07/16 14h48:798| <15.00.06> <Runtime> <> |.Con()|OleDb.OleDbConnection"' (Set|Get) The Con To the Table.
            '''    <Summary>
            '''     (Set|Get) The Con To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/16 14h48:878 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Con To the Table.")>
            Public Con As OleDb.OleDbConnection
#End Region '(Set|Get) The Con To the Table.

#Region "[On] |2019/07/16 14h48:844| <15.00.07> <Runtime> <> |.Cmd()|OleDb.OleDbCommand"' (Set|Get) The Cmd To the Table.
            '''    <Summary>
            '''     (Set|Get) The Cmd To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/16 14h48:878 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Cmd To the Table.")>
            Public Cmd As OleDb.OleDbCommand
#End Region '(Set|Get) The Cmd To the Table.

#Region "[On] |2019/07/16 14h48:856| <15.00.08> <Runtime> <> |.DataReader()|OleDb.OleDbDataReader"' (Set|Get) The DataReader To the Table.
            '''    <Summary>
            '''     (Set|Get) The DataReader To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/16 14h48:897 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The DataReader To the Table.")>
            Public DataReader As OleDb.OleDbDataReader
#End Region '(Set|Get) The DataReader To the Table.

#Region "[On] |2019/07/16 14h48:863| <15.00.09> <Runtime> <> |.DataAdapter()|OleDb.OleDbDataAdapter"' (Set|Get) The DataAdapter To the Table.
            '''    <Summary>
            '''     (Set|Get) The DataAdapter To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/16 14h48:897 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The DataAdapter To the Table.")>
            Public DataAdapter As OleDb.OleDbDataAdapter
#End Region '(Set|Get) The DataAdapter To the Table.

#Region "[On] |2019/07/16 14h48:871| <15.00.10> <Runtime> <> |.Connector()|LineInfo"' (Set|Get) The Connector To the Table.
            '''    <Summary>
            '''     (Set|Get) The Connector To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/16 14h48:898 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Connector To the Table.")>
            Public Connector As LineInfo
#End Region '(Set|Get) The Connector To the Table.

#Region "[On] |2019/07/16 14h48:878| <15.00.11> <Runtime> <> |.Log()|String"' (Set|Get) The Log To the Table.
            '''    <Summary>
            '''     (Set|Get) The Log To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/16 14h48:898 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Log To the Table.")>
            Public Log As String
#End Region '(Set|Get) The Log To the Table.

#End Region
#Region "<7> [Loader]{2}"
#Region "[On] |2019/07/16 14h48:886| <06.00.00> <Loader> <> |.Empty()|Function}|"' (Set|Get) The sub Empty.
            '''    <Summary>
            '''     (Set|Get) The sub Empty.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/16 14h48:898 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The sub Empty.")>
            Public Sub New()
                Reset()
            End Sub
#End Region '(Set|Get) The sub Empty.

#Region "[On] |2019/07/16 14h48:895| <06.00.01> <Loader> <> |.Filled()|Function}|"' (Set|Get) The sub Filled.
            '''    <Summary>
            '''     (Set|Get) The sub Filled.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/16 14h48:898 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>    ''' <param name="Name">(Set|Get) The Name as String.</param>
            ''' <param name="Profile">(Set|Get) The Profile as String.</param>
            ''' <param name="DateSaved">(Set|Get) The DateSaved as DateTime.</param>
            ''' <param name="Root">(Set|Get) The Root as String.</param>
            ''' <param name="Origine">(Set|Get) The Origine as String.</param>
            ''' <param name="ProfileIndex">(Set|Get) The ProfileIndex as Integer.</param>
            ''' <param name="Size">(Set|Get) The Size as Double.</param>
            ''' <param name="CandidateForDelete">(Set|Get) The CandidateForDelete as Boolean.</param>

            <Browsable(True), Description("(Set|Get) The sub Filled.")>
            Public Sub New(ByVal Name As String,
ByVal Profile As String,
ByVal DateSaved As DateTime,
ByVal Root As String,
ByVal Origine As String,
ByVal ProfileIndex As Integer,
ByVal Size As Double,
ByVal CandidateForDelete As Boolean)
                With Me
                    Clear()
                    Reset()
                    .Name = Name
                    .Profile = Profile
                    .DateSaved = DateSaved
                    .Root = Root
                    .Origine = Origine
                    .ProfileIndex = ProfileIndex
                    .Size = Size
                    .CandidateForDelete = CandidateForDelete
                End With

            End Sub
#End Region '(Set|Get) The sub Filled.

#End Region
        End Class
#End Region

#Region "[On] |2019/07/11 23h30:193| <08.00.00> <Class> <> |.Transfert|Class|{33} |Production Cost : 37.3|Selling Price : 93.25|"' Class created automatically by SmartOffice (c)Copyright 2019.
        '''    <Summary>
        '''     Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Transfert
        '''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
        '''    Contributor Information : ||
        '''    Creation Date :           2019/07/11 23h30:193
        '''    |Schema|
        '''    |ID| |ObjectType |{Quantity}||UnitPrice||Total
        '''    |00| |Importation|{0}||1| |0
        '''    |01| |Properties |{6}||0.8| |4.8
        '''    |02| |Enumeration|{1}||0.4| |0.4
        '''    |03| |Structure  |{0}||0.4| |0
        '''    |04| |Sub        |{5}||1.2| |6
        '''    |05| |Function   |{7}||1.6| |11.2
        '''    |06| |Runtime    |{12}||0.4| |4.8
        '''    |07| |Loader     |{2}||0.8| |1.6
        '''    |08| |Class      |{0}||2| |0
        '''    |09| |Constante  |{0}||0.4| |0
        '''    |10| |Event      |{0}||1.2| |0
        '''    |11| |Members    |{6}||0.5| |3
        '''    |12| |Parameter  |{11}||0.5| |5.5
        '''    |Production Cost             |37.3
        '''    |Selling Price without VAT   |93.25
        '''    |Total TVA                   |7.18
        '''    |Grand Total                 |100.43
        '''    |/Schema|
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:905 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        Public Class Transfert
#Region "<1> [Property]{6}"
#Region "[On] |2019/07/11 23h30:194| <01.00.00> <Property> <Columns> |.ID()|Integer|"' (Set|Get) The ID as Integer.
            Private _ID As Integer
            '''    <Summary>
            '''     (Set|Get) The ID as Integer.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:905 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The ID as Integer.")>
            Public Property ID() As Integer
                Get
                    Return _ID
                End Get
                Set(ByVal Value As Integer)
                    _ID = Value
                End Set
            End Property
#End Region '(Set|Get) The ID as Integer.

#Region "[On] |2019/07/11 23h30:201| <01.00.01> <Property> <Columns> |.Profile()|String|"' (Set|Get) The Profile as String.
            Private _Profile As String
            '''    <Summary>
            '''     (Set|Get) The Profile as String.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:905 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Profile as String.")>
            Public Property Profile() As String
                Get
                    Return _Profile
                End Get
                Set(ByVal Value As String)
                    _Profile = Value
                End Set
            End Property
#End Region '(Set|Get) The Profile as String.

#Region "[On] |2019/07/11 23h30:207| <01.00.02> <Property> <Columns> |.Source()|String|"' (Set|Get) The Source as String.
            Private _Source As String
            '''    <Summary>
            '''     (Set|Get) The Source as String.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:905 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Source as String.")>
            Public Property Source() As String
                Get
                    Return _Source
                End Get
                Set(ByVal Value As String)
                    _Source = Value
                End Set
            End Property
#End Region '(Set|Get) The Source as String.

#Region "[On] |2019/07/11 23h30:214| <01.00.03> <Property> <Columns> |.Destination()|String|"' (Set|Get) The Destination as String.
            Private _Destination As String
            '''    <Summary>
            '''     (Set|Get) The Destination as String.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:905 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Destination as String.")>
            Public Property Destination() As String
                Get
                    Return _Destination
                End Get
                Set(ByVal Value As String)
                    _Destination = Value
                End Set
            End Property
#End Region '(Set|Get) The Destination as String.

#Region "[On] |2019/07/11 23h30:220| <01.00.04> <Property> <Columns> |.Size()|Double|"' (Set|Get) The Size as Double.
            Private _Size As Double
            '''    <Summary>
            '''     (Set|Get) The Size as Double.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:906 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Size as Double.")>
            Public Property Size() As Double
                Get
                    Return _Size
                End Get
                Set(ByVal Value As Double)
                    _Size = Value
                End Set
            End Property
#End Region '(Set|Get) The Size as Double.

#Region "[On] |2019/07/11 23h30:233| <01.00.05> <Property> <Columns> |.Etat()|String|"' (Set|Get) The Etat as String.
            Private _Etat As String
            '''    <Summary>
            '''     (Set|Get) The Etat as String.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:906 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Etat as String.")>
            Public Property Etat() As String
                Get
                    Return _Etat
                End Get
                Set(ByVal Value As String)
                    _Etat = Value
                End Set
            End Property
#End Region '(Set|Get) The Etat as String.

#End Region
#Region "<2> [Enumeration]{1}"
#Region "[On] |2019/07/11 23h30:239| <02.00.00> <Enumeration> <> |.Schema()|Enumeration{5}|"' (Set|Get) The enumeration of Schema.
            '''    <Summary>
            '''     (Set|Get) The enumeration of Schema.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:906 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The enumeration of Schema.")>
            Enum Schema
                ''' <summary>(Set|Get) The ID as Integer.</summary>
                [ID] = 0
                ''' <summary>(Set|Get) The Profile as String.</summary>
                [Profile] = 1
                ''' <summary>(Set|Get) The Source as String.</summary>
                [Source] = 2
                ''' <summary>(Set|Get) The Destination as String.</summary>
                [Destination] = 3
                ''' <summary>(Set|Get) The Size as Double.</summary>
                [Size] = 4
                ''' <summary>(Set|Get) The Etat as String.</summary>
                [Etat] = 5
            End Enum
#End Region '(Set|Get) The enumeration of Schema.

#End Region
#Region "<4> [Sub]{5}"
#Region "[On] |2019/07/11 23h30:245| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
            '''    <Summary>
            '''     (Set|Get) This will reinitialize the class element.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:906 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) This will reinitialize the class element.")>
            Public Sub Clear()
                With Me
                    .ID = 0
                    .Profile = Nothing
                    .Source = Nothing
                    .Destination = Nothing
                    .Size = 0
                    .Etat = Nothing
                End With
            End Sub
#End Region '(Set|Get) This will reinitialize the class element.

#Region "[On] |2019/07/11 23h30:252| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
            '''    <Summary>
            '''     (Set|Get) This will reinitialize the variables of this class.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:906 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) This will reinitialize the variables of this class.")>
            Public Sub Reset(Optional ByVal Connector As LineInfo = Nothing)
                If Not IsNothing(Connector) Then
                    Me.Connector = Connector
                    Me.FilePath = ""
                    Me.Password = ""
                    Me.Line = ""
                    If Connector.Status <> Status.Broken Then
                        FilePath = Connector.FilePath
                        Password = Connector.Password
                        Me.Connector = Connector
                        TableName = "Transfert"
                        Line = Connector.Line
                        UseSQL = False
                    Else
                        FilePath = My.Settings.Db_Backup_FilePath
                        Password = My.Settings.Db_Backup_Password
                        Me.Line = My.Settings.Db_Backup_Line
                        TableName = "Transfert"
                        UseSQL = False
                    End If
                Else
                    If IsNothing(FilePath) Then
                        FilePath = My.Settings.Db_Backup_FilePath
                    End If
                    If FilePath.Length < 1 Then
                        FilePath = My.Settings.Db_Backup_FilePath
                    End If
                    FilePath = My.Settings.Db_Backup_FilePath
                    Password = My.Settings.Db_Backup_Password
                    Me.Line = My.Settings.Db_Backup_Line
                    TableName = "Transfert"
                    UseSQL = False
                End If

            End Sub
#End Region '(Set|Get) This will reinitialize the variables of this class.

#Region "[On] |2019/07/11 23h30:259| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
            '''    <Summary>
            '''     (Set|Get) This will add a new row in the table.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:906 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) This will add a new row in the table.")>
            Public Sub Add()
                Try
                    Dim Str As String = Nothing
                    Str = "Insert Into [Transfert] (
`ID`, 
`Profile`, 
`Source`, 
`Destination`, 
`Size`, 
`Etat`) Values (@0, @1, @2, @3, @4, @5)"
                    Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                    Cmd = New OleDb.OleDbCommand(Str, Con)
                    Con.Open()
                    Cmd.Parameters.AddWithValue("@0", Me.ID)
                    Cmd.Parameters.AddWithValue("@1", Me.Profile)
                    Cmd.Parameters.AddWithValue("@2", Me.Source)
                    Cmd.Parameters.AddWithValue("@3", Me.Destination)
                    Cmd.Parameters.AddWithValue("@4", Me.Size)
                    Cmd.Parameters.AddWithValue("@5", Me.Etat)
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

#Region "[On] |2019/07/11 23h30:265| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
            '''    <Summary>
            '''     (Set|Get) This will update a row in the table.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:907 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) This will update a row in the table.")>
            Public Sub Save()
                Try
                    Dim Str As String = Nothing
                    Str = "UPDATE [Transfert] SET Profile = @Profile, Source = @Source, Destination = @Destination, Size = @Size, Etat = @Etat WHERE ID = @ID"
                    Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                    Cmd = New OleDb.OleDbCommand(Str, Con)
                    Con.Open()
                    Cmd.Parameters.AddWithValue("@Profile", Profile)
                    Cmd.Parameters.AddWithValue("@Source", Source)
                    Cmd.Parameters.AddWithValue("@Destination", Destination)
                    Cmd.Parameters.AddWithValue("@Size", Size)
                    Cmd.Parameters.AddWithValue("@Etat", Etat)
                    Cmd.Parameters.AddWithValue("@ID", ID)
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

#Region "[On] |2019/07/11 23h30:272| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
            '''    <Summary>
            '''     (Set|Get) This will Delete a row in the table.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:907 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) This will Delete a row in the table.")>
            Public Sub Delete()
                Try
                    Dim Str As String = Nothing
                    Str = "Delete From [Transfert] WHERE ID =@ID"
                    Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                    Cmd = New OleDb.OleDbCommand(Str, Con)
                    Con.Open()
                    Cmd.Parameters.AddWithValue("@ID", ID)
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
#Region "[On] |2019/07/11 23h30:279| <05.00.00> <Function> <> |.Open()|TestItem}|"' (Set|Get) This will initialise the connection and import the data.
            '''    <Summary>
            '''     (Set|Get) This will initialise the connection and import the data.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:907 </Published>
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

#Region "[On] |2019/07/11 23h30:286| <05.00.01> <Function> <> |.Close()|TestItem}|"' (Set|Get) This willClosing the connection
            '''    <Summary>
            '''     (Set|Get) This willClosing the connection
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:907 </Published>
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

#Region "[On] |2019/07/11 23h30:293| <05.00.02> <Function> <> |.List()|List(Of Transfert)}|"' (Set|Get) Return the entire table listed
            '''    <Summary>
            '''     (Set|Get) Return the entire table listed
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:907 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) Return the entire table listed")>
            Public Function List() As List(Of Transfert)
                Dim Result As New List(Of Transfert)
                Me.Table = New Table(Me.TableName, Me.FilePath, Me.Password, False)
                For Each Row As DataRow In Me.Table.DataTable.Rows
                    Dim Element As New Transfert(IIf(IsDBNull(Row.Item(0)), 0, Row.Item(0)),
IIf(IsDBNull(Row.Item(1)), "", Row.Item(1)),
IIf(IsDBNull(Row.Item(2)), "", Row.Item(2)),
IIf(IsDBNull(Row.Item(3)), "", Row.Item(3)),
IIf(IsDBNull(Row.Item(4)), 0, Row.Item(4)),
      IIf(IsDBNull(Row.Item(5)), "", Row.Item(5)))
                    Element.Reset(Table.Line)
                    Result.Add(Element)
                Next
                Return Result
            End Function
#End Region '(Set|Get) Return the entire table listed

#Region "[On] |2019/07/11 23h30:300| <05.00.03> <Function> <> |.SearchByName()|List(Of Transfert)}|"' (Set|Get) Search for each property that match the Search String.
            '''    <Summary>
            '''     (Set|Get) Search for each property that match the Search String.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:907 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) Search for each property that match the Search String.")>
            Public Shared Function SearchByName(ByVal Search As String) As List(Of Transfert)
                Dim Result As New List(Of Transfert)
                Dim C As New Transfert
                For Each Element As Transfert In C.List
                    If Element.Profile.ToLower() = Search.ToLower() Or Element.Source.ToLower() = Search.ToLower() Or Element.Destination.ToLower() = Search.ToLower() Or Element.Etat.ToLower() = Search.ToLower() Then
                        Result.Add(Element)
                    End If
                Next
                Return Result
            End Function
#End Region '(Set|Get) Search for each property that match the Search String.

#Region "[On] |2019/07/11 23h30:307| <05.00.04> <Function> <> |.SearchByID()|List(Of Transfert)}|"' (Set|Get) Search for each property that match the Search Id.
            '''    <Summary>
            '''     (Set|Get) Search for each property that match the Search Id.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:908 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) Search for each property that match the Search Id.")>
            Public Shared Function SearchByID(ByVal Search As Double) As List(Of Transfert)
                Dim Result As New List(Of Transfert)
                Dim C As New Transfert
                For Each Element As Transfert In C.List
                    If Val(Element.ID) = Search Or Val(Element.Size) = Search Then
                        Result.Add(Element)
                    End If
                Next
                Return Result
            End Function
#End Region '(Set|Get) Search for each property that match the Search Id.

#Region "[On] |2019/07/11 23h30:314| <05.00.05> <Function> <> |.ToString()|String}|"' (Set|Get) The function ToString.
            '''    <Summary>
            '''     (Set|Get) The function ToString.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:908 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The function ToString.")>
            Public Overrides Function ToString() As String
                Return Me.ID
            End Function
#End Region '(Set|Get) The function ToString.

#Region "[On] |2019/07/11 23h30:321| <05.00.06> <Function> <> |.CheckConnection()|Boolean}|"' (Set|Get) Evaluate the connection to the DataBase
            '''    <Summary>
            '''     (Set|Get) Evaluate the connection to the DataBase
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:909 </Published>
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
            Public Tag As Object
#Region "[On] |2019/07/11 23h30:333| <15.00.00> <Runtime> <> |.Table()|Table"' (Set|Get) The Table.
            '''    <Summary>
            '''     (Set|Get) The Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:909 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Table.")>
            Public Table As Table
#End Region '(Set|Get) The Table.

#Region "[On] |2019/07/11 23h30:341| <15.00.01> <Runtime> <> |.Line()|String"' (Set|Get) The Connection String To the Table.
            '''    <Summary>
            '''     (Set|Get) The Connection String To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:909 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Connection String To the Table.")>
            Public Line As String
#End Region '(Set|Get) The Connection String To the Table.

#Region "[On] |2019/07/11 23h30:349| <15.00.02> <Runtime> <> |.FilePath()|String"' (Set|Get) The FilePath To the Table.
            '''    <Summary>
            '''     (Set|Get) The FilePath To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:909 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The FilePath To the Table.")>
            Public FilePath As String
#End Region '(Set|Get) The FilePath To the Table.

#Region "[On] |2019/07/11 23h30:355| <15.00.03> <Runtime> <> |.Password()|String"' (Set|Get) The Password To the Table.
            '''    <Summary>
            '''     (Set|Get) The Password To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:909 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Password To the Table.")>
            Public Password As String
#End Region '(Set|Get) The Password To the Table.

#Region "[On] |2019/07/11 23h30:363| <15.00.04> <Runtime> <> |.UseSQL()|Boolean"' (Set|Get) Determines if the Database Connection is of type SQL.
            '''    <Summary>
            '''     (Set|Get) Determines if the Database Connection is of type SQL.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:910 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) Determines if the Database Connection is of type SQL.")>
            Public UseSQL As Boolean
#End Region '(Set|Get) Determines if the Database Connection is of type SQL.

#Region "[On] |2019/07/11 23h30:370| <15.00.05> <Runtime> <> |.TableName()|String"' (Set|Get) The name of the Table.
            '''    <Summary>
            '''     (Set|Get) The name of the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:910 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The name of the Table.")>
            Public TableName As String
#End Region '(Set|Get) The name of the Table.

#Region "[On] |2019/07/11 23h30:377| <15.00.06> <Runtime> <> |.Con()|OleDb.OleDbConnection"' (Set|Get) The Con To the Table.
            '''    <Summary>
            '''     (Set|Get) The Con To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:910 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Con To the Table.")>
            Public Con As OleDb.OleDbConnection
#End Region '(Set|Get) The Con To the Table.

#Region "[On] |2019/07/11 23h30:380| <15.00.07> <Runtime> <> |.Cmd()|OleDb.OleDbCommand"' (Set|Get) The Cmd To the Table.
            '''    <Summary>
            '''     (Set|Get) The Cmd To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:910 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Cmd To the Table.")>
            Public Cmd As OleDb.OleDbCommand
#End Region '(Set|Get) The Cmd To the Table.

#Region "[On] |2019/07/11 23h30:387| <15.00.08> <Runtime> <> |.DataReader()|OleDb.OleDbDataReader"' (Set|Get) The DataReader To the Table.
            '''    <Summary>
            '''     (Set|Get) The DataReader To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:910 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The DataReader To the Table.")>
            Public DataReader As OleDb.OleDbDataReader
#End Region '(Set|Get) The DataReader To the Table.

#Region "[On] |2019/07/11 23h30:394| <15.00.09> <Runtime> <> |.DataAdapter()|OleDb.OleDbDataAdapter"' (Set|Get) The DataAdapter To the Table.
            '''    <Summary>
            '''     (Set|Get) The DataAdapter To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:910 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The DataAdapter To the Table.")>
            Public DataAdapter As OleDb.OleDbDataAdapter
#End Region '(Set|Get) The DataAdapter To the Table.

#Region "[On] |2019/07/11 23h30:401| <15.00.10> <Runtime> <> |.Connector()|LineInfo"' (Set|Get) The Connector To the Table.
            '''    <Summary>
            '''     (Set|Get) The Connector To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:910 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Connector To the Table.")>
            Public Connector As LineInfo
#End Region '(Set|Get) The Connector To the Table.

#Region "[On] |2019/07/11 23h30:409| <15.00.11> <Runtime> <> |.Log()|String"' (Set|Get) The Log To the Table.
            '''    <Summary>
            '''     (Set|Get) The Log To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:910 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Log To the Table.")>
            Public Log As String
#End Region '(Set|Get) The Log To the Table.

#End Region
#Region "<7> [Loader]{2}"
#Region "[On] |2019/07/11 23h30:417| <06.00.00> <Loader> <> |.Empty()|Function}|"' (Set|Get) The sub Empty.
            '''    <Summary>
            '''     (Set|Get) The sub Empty.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:911 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The sub Empty.")>
            Public Sub New()
                Reset()
            End Sub
#End Region '(Set|Get) The sub Empty.

#Region "[On] |2019/07/11 23h30:419| <06.00.01> <Loader> <> |.Filled()|Function}|"' (Set|Get) The sub Filled.
            '''    <Summary>
            '''     (Set|Get) The sub Filled.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:911 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>    ''' <param name="ID">(Set|Get) The ID as Integer.</param>
            ''' <param name="Profile">(Set|Get) The Profile as String.</param>
            ''' <param name="Source">(Set|Get) The Source as String.</param>
            ''' <param name="Destination">(Set|Get) The Destination as String.</param>
            ''' <param name="Size">(Set|Get) The Size as Double.</param>
            ''' <param name="Etat">(Set|Get) The Etat as String.</param>

            <Browsable(True), Description("(Set|Get) The sub Filled.")>
            Public Sub New(ByVal ID As Integer,
ByVal Profile As String,
ByVal Source As String,
ByVal Destination As String,
ByVal Size As Double,
ByVal Etat As String)
                With Me
                    Clear()
                    Reset()
                    .ID = ID
                    .Profile = Profile
                    .Source = Source
                    .Destination = Destination
                    .Size = Size
                    .Etat = Etat
                    .Tag = Nothing
                End With

            End Sub
#End Region '(Set|Get) The sub Filled.

#End Region
        End Class
#End Region

#Region "[On] |2019/07/11 23h30:528| <08.00.00> <Class> <> |.Initializor_Backup|Class|{20} |Production Cost : 16.6|Selling Price : 41.5|"' 
        '''    <Summary>
        '''     '''    Object Name :             Public  Class Initializor_Backup
        '''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
        '''    Contributor Information : ||
        '''    Creation Date :           2019/07/11 23h30:528
        '''    |Schema|
        '''    |ID| |ObjectType |{Quantity}||UnitPrice||Total
        '''    |00| |Importation|{0}||1| |0
        '''    |01| |Properties |{12}||0.8| |9.6
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
        '''    |Production Cost             |16.6
        '''    |Selling Price without VAT   |41.5
        '''    |Total TVA                   |3.2
        '''    |Grand Total                 |44.7
        '''    |/Schema|
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:918 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        Public Class Initializor_Backup
#Region "<1> [Property]{12}"
#Region "[On] |2019/07/11 23h30:529| <01.00.00> <Property> <Virtualized Properties> |.Archives_Data()|Archives_Data|"' (Set|Get) 
            Private _Archives_Data As Archives_Data
            '''    <Summary>
            '''     (Set|Get) 
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:919 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Virtualized Properties"), Description("(Set|Get) ")>
            Public Property Archives_Data() As Archives_Data
                Get
                    Return _Archives_Data
                End Get
                Set(ByVal Value As Archives_Data)
                    _Archives_Data = Value
                End Set
            End Property
#End Region '(Set|Get) 

#Region "[On] |2019/07/11 23h30:535| <01.00.01> <Property> <List> |.List_Archives_Data()|List(Of Archives_Data)|"' (Set|Get) 
            Private _List_Archives_Data As List(Of Archives_Data)
            '''    <Summary>
            '''     (Set|Get) 
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:919 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("List"), Description("(Set|Get) ")>
            Public Property List_Archives_Data() As List(Of Archives_Data)
                Get
                    Return _List_Archives_Data
                End Get
                Set(ByVal Value As List(Of Archives_Data))
                    _List_Archives_Data = Value
                End Set
            End Property
#End Region '(Set|Get) 

#Region "[On] |2019/07/11 23h30:541| <01.00.02> <Property> <Virtualized Properties> |.Backup()|Backup|"' (Set|Get) 
            Private _Backup As Backup
            '''    <Summary>
            '''     (Set|Get) 
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:919 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Virtualized Properties"), Description("(Set|Get) ")>
            Public Property Backup() As Backup
                Get
                    Return _Backup
                End Get
                Set(ByVal Value As Backup)
                    _Backup = Value
                End Set
            End Property
#End Region '(Set|Get) 

#Region "[On] |2019/07/11 23h30:548| <01.00.03> <Property> <List> |.List_Backup()|List(Of Backup)|"' (Set|Get) 
            Private _List_Backup As List(Of Backup)
            '''    <Summary>
            '''     (Set|Get) 
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:919 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("List"), Description("(Set|Get) ")>
            Public Property List_Backup() As List(Of Backup)
                Get
                    Return _List_Backup
                End Get
                Set(ByVal Value As List(Of Backup))
                    _List_Backup = Value
                End Set
            End Property
#End Region '(Set|Get) 

#Region "[On] |2019/07/11 23h30:554| <01.00.04> <Property> <Virtualized Properties> |.Profile()|Profile|"' (Set|Get) 
            Private _Profile As Profile
            '''    <Summary>
            '''     (Set|Get) 
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:919 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Virtualized Properties"), Description("(Set|Get) ")>
            Public Property Profile() As Profile
                Get
                    Return _Profile
                End Get
                Set(ByVal Value As Profile)
                    _Profile = Value
                End Set
            End Property
#End Region '(Set|Get) 

#Region "[On] |2019/07/11 23h30:560| <01.00.05> <Property> <List> |.List_Profile()|List(Of Profile)|"' (Set|Get) 
            Private _List_Profile As List(Of Profile)
            '''    <Summary>
            '''     (Set|Get) 
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:920 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("List"), Description("(Set|Get) ")>
            Public Property List_Profile() As List(Of Profile)
                Get
                    Return _List_Profile
                End Get
                Set(ByVal Value As List(Of Profile))
                    _List_Profile = Value
                End Set
            End Property
#End Region '(Set|Get) 

#Region "[On] |2019/07/11 23h30:566| <01.00.06> <Property> <Virtualized Properties> |.Save_Entry()|Save_Entry|"' (Set|Get) 
            Private _Save_Entry As Save_Entry
            '''    <Summary>
            '''     (Set|Get) 
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:920 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Virtualized Properties"), Description("(Set|Get) ")>
            Public Property Save_Entry() As Save_Entry
                Get
                    Return _Save_Entry
                End Get
                Set(ByVal Value As Save_Entry)
                    _Save_Entry = Value
                End Set
            End Property
#End Region '(Set|Get) 

#Region "[On] |2019/07/11 23h30:573| <01.00.07> <Property> <List> |.List_Save_Entry()|List(Of Save_Entry)|"' (Set|Get) 
            Private _List_Save_Entry As List(Of Save_Entry)
            '''    <Summary>
            '''     (Set|Get) 
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:920 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("List"), Description("(Set|Get) ")>
            Public Property List_Save_Entry() As List(Of Save_Entry)
                Get
                    Return _List_Save_Entry
                End Get
                Set(ByVal Value As List(Of Save_Entry))
                    _List_Save_Entry = Value
                End Set
            End Property
#End Region '(Set|Get) 

#Region "[On] |2019/07/11 23h30:580| <01.00.08> <Property> <Virtualized Properties> |.Transfert()|Transfert|"' (Set|Get) 
            Private _Transfert As Transfert
            '''    <Summary>
            '''     (Set|Get) 
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:920 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("Virtualized Properties"), Description("(Set|Get) ")>
            Public Property Transfert() As Transfert
                Get
                    Return _Transfert
                End Get
                Set(ByVal Value As Transfert)
                    _Transfert = Value
                End Set
            End Property
#End Region '(Set|Get) 

#Region "[On] |2019/07/11 23h30:588| <01.00.09> <Property> <List> |.List_Transfert()|List(Of Transfert)|"' (Set|Get) 
            Private _List_Transfert As List(Of Transfert)
            '''    <Summary>
            '''     (Set|Get) 
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:920 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), CategoryAttribute("List"), Description("(Set|Get) ")>
            Public Property List_Transfert() As List(Of Transfert)
                Get
                    Return _List_Transfert
                End Get
                Set(ByVal Value As List(Of Transfert))
                    _List_Transfert = Value
                End Set
            End Property
#End Region '(Set|Get) 

#Region "[On] |2019/07/11 23h30:595| <01.00.10> <Property> <Portfolio> |.Portfolio()|List(Of Object)|"' (Set|Get) 
            Private Shared _Portfolio As List(Of Object)
            '''    <Summary>
            '''     (Set|Get) 
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:921 </Published>
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

#Region "[On] |2019/07/11 23h30:601| <01.00.11> <Property> <DataBase> |.DataBase()|SmartCoder.M_FileManager.DataBase|"' (Set|Get) 
            Private Shared _DataBase As SmartCoder.M_FileManager.DataBase
            '''    <Summary>
            '''     (Set|Get) 
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:921 </Published>
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
#Region "[On] |2019/07/11 23h30:608| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class properties element.
            '''    <Summary>
            '''     (Set|Get) This will reinitialize the class properties element.
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:921 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) This will reinitialize the class properties element.")>
            Public Sub Clear()
                With Me
                    .Archives_Data = New Archives_Data
                    .List_Archives_Data = New List(Of Archives_Data)
                    .Backup = New Backup
                    .List_Backup = New List(Of Backup)
                    .Profile = New Profile
                    .List_Profile = New List(Of Profile)
                    .Save_Entry = New Save_Entry
                    .List_Save_Entry = New List(Of Save_Entry)
                    .Transfert = New Transfert
                    .List_Transfert = New List(Of Transfert)
                    Portfolio = New List(Of Object)
                    DataBase = New SmartCoder.M_FileManager.DataBase
                End With
            End Sub
#End Region '(Set|Get) This will reinitialize the class properties element.

#End Region
#Region "<5> [Function]{1}"
#Region "[On] |2019/07/11 23h30:618| <05.00.00> <Function> <> |.CheckConnection()|Boolean}|"' (Set|Get) Evaluate the connection to the DataBase
            '''    <Summary>
            '''     (Set|Get) Evaluate the connection to the DataBase
            '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
            '''    <AuthorName>Saadry Dunkel</AuthorName>
            '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:921 </Published>
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
#Region "[On] |2019/07/11 23h30:627| <15.00.00> <Runtime> <> |.Line()|String"' (Set|Get) The Connection String To the Table.
            '''    <Summary>
            '''     (Set|Get) The Connection String To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:921 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Connection String To the Table.")>
            Public Line As String
#End Region '(Set|Get) The Connection String To the Table.

#Region "[On] |2019/07/11 23h30:635| <15.00.01> <Runtime> <> |.FilePath()|String"' (Set|Get) The FilePath To the Table.
            '''    <Summary>
            '''     (Set|Get) The FilePath To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:921 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The FilePath To the Table.")>
            Public FilePath As String
#End Region '(Set|Get) The FilePath To the Table.

#Region "[On] |2019/07/11 23h30:642| <15.00.02> <Runtime> <> |.Password()|String"' (Set|Get) The Password To the Table.
            '''    <Summary>
            '''     (Set|Get) The Password To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:922 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Password To the Table.")>
            Public Password As String
#End Region '(Set|Get) The Password To the Table.

#Region "[On] |2019/07/11 23h30:649| <15.00.03> <Runtime> <> |.Connector()|LineInfo"' (Set|Get) The Connector To the Table.
            '''    <Summary>
            '''     (Set|Get) The Connector To the Table.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:922 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The Connector To the Table.")>
            Public Connector As LineInfo
#End Region '(Set|Get) The Connector To the Table.

#End Region
#Region "<7> [Loader]{2}"
#Region "[On] |2019/07/11 23h30:659| <06.00.00> <Loader> <> |.Empty()|Function}|"' (Set|Get) The sub Empty.
            '''    <Summary>
            '''     (Set|Get) The sub Empty.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:922 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>
            <Browsable(True), Description("(Set|Get) The sub Empty.")>
            Public Sub New()
                Clear()
            End Sub
#End Region '(Set|Get) The sub Empty.

#Region "[On] |2019/07/11 23h30:663| <06.00.01> <Loader> <> |.Filled()|Function}|"' (Set|Get) The sub Filled.
            '''    <Summary>
            '''     (Set|Get) The sub Filled.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/11 23h31:922 </Published>
            '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>    ''' <param name="FilePath">The initial File Path</param>
            ''' <param name="Password">The password</param>

            <Browsable(True), Description("(Set|Get) The sub Filled.")>
            Public Sub New(ByVal FilePath As String,
Optional ByVal Password As String = """")
                With Me
                    Clear()
                    .Archives_Data = New Archives_Data
                    .List_Archives_Data = New List(Of Archives_Data)
                    .Backup = New Backup
                    .List_Backup = New List(Of Backup)
                    .Profile = New Profile
                    .List_Profile = New List(Of Profile)
                    .Save_Entry = New Save_Entry
                    .List_Save_Entry = New List(Of Save_Entry)
                    .Transfert = New Transfert
                    .List_Transfert = New List(Of Transfert)
                    Portfolio = New List(Of Object)
                    DataBase = New SmartCoder.M_FileManager.DataBase
                End With
                Portfolio = New List(Of Object)
                FilePath = FilePath
                Password = Password
                Line = Line
                Dim M As New LineInfo(FilePath, Password)
                My.Settings.Db_Backup_FilePath = FilePath
                My.Settings.Db_Backup_Password = Password
                My.Settings.Db_Backup_Line = Line
                My.Settings.Save()

                With Archives_Data
                    .Reset(M)
                End With
                List_Archives_Data = New List(Of Archives_Data)
                List_Archives_Data = Archives_Data.List()
                With Backup
                    .Reset(M)
                End With
                List_Backup = New List(Of Backup)
                List_Backup = Backup.List()
                With Profile
                    .Reset(M)
                End With
                List_Profile = New List(Of Profile)
                List_Profile = Profile.List()
                With Save_Entry
                    .Reset(M)
                End With
                List_Save_Entry = New List(Of Save_Entry)
                List_Save_Entry = Save_Entry.List()
                With Transfert
                    .Reset(M)
                End With
                List_Transfert = New List(Of Transfert)
                List_Transfert = Transfert.List()

            End Sub
#End Region '(Set|Get) The sub Filled.

#End Region
        End Class
#End Region

#End Region
    End Class
#End Region


End Module
