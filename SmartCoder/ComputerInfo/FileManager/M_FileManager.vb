Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Design
Imports System.IO
Imports System.IO.Compression
Imports System.Management
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Windows.Forms
Imports System.Xml.Serialization

Public Module M_FileManager
#Region "<Schema>"
#Region "|1| [Property]"

#End Region
#Region "|2| [Enumeration]"
#Region "|02.00| <Enumeration> [FileType]"
    Public Enum FileType
        Compression = 1
        DataBase = 2
        Executable = 3
        Folder = 4
        Image = 5
        Movies = 6
        MS_OneNote = 7
        MS_Outlook = 8
        MS_PowerPoint = 9
        MS_Publisher = 10
        MS_Word = 11
        Music = 12
        NotRecognized = 13
        NotTested = 14
        Pcompta = 15
        PDF = 16
        Programmation = 17
        Saadry = 18
        Text = 19
        Web = 20
    End Enum
#End Region
#Region "|02.01| <Enumeration> [DataBaseType]"
    Public Enum DataBaseType
        Accdb
        Dbf
        Excel
        Mdb
        Sql
        Saadry
        [Nothing]
    End Enum
#End Region
#Region "|02.02| <Enumeration> [SchemaPart]"
    Public Enum SchemaPart
        Importation = 0
        Properties = 1
        Enumerations = 2
        Structures = 3
        Subs = 4
        Functions = 5
        Runtimes = 6
        Loaders = 7
        Constantes = 8
        Classes = 9
        Events = 10
        Other = 11
    End Enum
#End Region
#End Region
#Region "|3| [Structure]"
#Region "|03.00| <Structure> [FileHybrid]"
    Public Structure FileHybrid
        Public Target As String
        Public Icon As Bitmap
        Public IsFile As Boolean
        Public IsFolder As Boolean
        Public File As Fichier
        Public Folder As Folder
        Public Password As String
        Public NodeX As DevComponents.AdvTree.Node
    End Structure
#End Region
#End Region
#Region "|4| [Sub]"

#End Region
#Region "|5| [Function]"
    Public Function CalculateDirSize(ByVal d As DirectoryInfo, Optional ByVal Format As SizeInfo.Scales = Nothing) As SizeInfo
        Dim Size As Long = 0
        ' Add file sizes.
        Try
            Dim fis As FileInfo() = d.GetFiles()
            Dim fi As FileInfo
            For Each fi In fis
                Size += fi.Length
            Next fi
            ' Add subdirectory sizes.
            Dim dis As DirectoryInfo() = d.GetDirectories()
            Dim di As DirectoryInfo
            For Each di In dis
                Size += CalculateDirSize(di).Raw
            Next di
        Catch ex As Exception

        End Try

        Dim Result As New SizeInfo(Size, Format)
        Return Result
    End Function 'DirSize
#End Region
#Region "|6| [Runtime]"

#End Region
#Region "|7| [Loader]"

#End Region
#Region "|8| [Class]"
#Region "|08.00| <Class> [Fichier]"
    Public Class Fichier
#Region "<Schema>"
#Region "|1| [Property]"
#Region "|01.00| <Property> [Info]{11}"
#Region "|2019/04/16 13h23:988| <01.00.00> <Property> <Info> [Call=Name|String]"'(Set|Get) The file name without extensions.
        Private _Name As String
        ''' <Summary>
        ''' (Set|Get) The file name without extensions.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/16 13h23:988 </Published>
        ''' <Updated>[Created=2019/04/16 13h23:988][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Info"),
Description("(Set|Get) The file name without extensions."),
Browsable(True)>
        Public Property Name() As String
            Get
                Return _Name
            End Get
            Set(ByVal Value As String)
                _Name = Value
            End Set
        End Property
#End Region ' (Set|Get) The file name without extensions.
#Region "|2019/04/16 13h24:083| <01.00.01> <Property> <Info> [Call=FileName|String]"'(Set|Get) The file name with extensions.
        Private _FileName As String
        ''' <Summary>
        ''' (Set|Get) The file name with extensions.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/16 13h24:083 </Published>
        ''' <Updated>[Created=2019/04/16 13h24:083][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Info"),
Description("(Set|Get) The file name with extensions."),
Browsable(True)>
        Public Property FileName() As String
            Get
                Return _FileName
            End Get
            Set(ByVal Value As String)
                _FileName = Value
            End Set
        End Property
#End Region ' (Set|Get) The file name with extensions.
#Region "|2019/04/16 13h25:462| <01.00.02> <Property> <Info> [Call=FilePath|Folder]"'(Set|Get) The FilePath as Folder.
        Private _FilePath As Folder
        ''' <Summary>
        ''' (Set|Get) The FilePath as Folder.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/16 13h25:462 </Published>
        ''' <Updated>[Created=2019/04/16 13h25:462][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Info"),
Description("(Set|Get) The FilePath as Folder."),
Browsable(True)>
        Public Property FilePath() As Folder
            Get
                Return _FilePath
            End Get
            Set(ByVal Value As Folder)
                _FilePath = Value
            End Set
        End Property
#End Region ' (Set|Get) The FilePath as Folder.
#Region "|2019/04/16 13h27:170| <01.00.03> <Property> <Info> [Call=Extension|String]"'(Set|Get) The Extension as String.
        Private _Extension As String
        ''' <Summary>
        ''' (Set|Get) The Extension as String.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/16 13h27:170 </Published>
        ''' <Updated>[Created=2019/04/16 13h27:170][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Info"),
Description("(Set|Get) The Extension as String."),
Browsable(True)>
        Public Property Extension() As String
            Get
                Return _Extension
            End Get
            Set(ByVal Value As String)
                _Extension = Value
            End Set
        End Property
#End Region ' (Set|Get) The Extension as String.
#Region "|2019/04/16 13h28:244| <01.00.04> <Property> <Info> [Call=FullName|String]"'(Set|Get) Return the full path of the name with Path + FileName + Extension.
        Private _FullName As String
        ''' <Summary>
        ''' Return the full path of the name with Path + FileName + Extension.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/16 13h28:244 </Published>
        ''' <Updated>[Created=2019/04/16 13h28:244][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Info"),
Description("Return the full path of the name with Path + FileName + Extension."),
Browsable(True)>
        Public Property FullName() As String
            Get
                Return _FullName
            End Get
            Set(ByVal Value As String)
                _FullName = Value
            End Set
        End Property
#End Region ' (Set|Get) Return the full path of the name with Path + FileName + Extension.
#Region "|2019/04/16 13h29:674| <01.00.05> <Property> <Info> [Call=Password|String]"'(Set|Get) The password associated with the file in order to open a database, encrypt or encrypt it's components.
        Private _Password As String
        ''' <Summary>
        ''' The password associated with the file in order to open a database, encrypt or encrypt it's components.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/16 13h29:674 </Published>
        ''' <Updated>[Created=2019/04/16 13h29:674][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Info"),
Description("The password associated with the file in order to open a database, encrypt or encrypt it's components."),
Browsable(True)>
        Public Property Password() As String
            Get
                Return _Password
            End Get
            Set(ByVal Value As String)
                _Password = Value
            End Set
        End Property
#End Region ' (Set|Get) The password associated with the file in order to open a database, encrypt or encrypt it's components.
#Region "|2019/04/16 13h29:633| <01.00.06> <Property> <Info> [Call=Icon|Image]"'(Set|Get) the Icon as Image.
        Private _Icon As Image
        ''' <Summary>
        ''' (Set|Get) the Icon as Image.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/16 13h29:633 </Published>
        ''' <Updated>[Created=2019/04/16 13h29:633][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Info"),
Description("(Set|Get) the Icon as Image."),
Browsable(True)>
        Public Property Icon() As Image
            Get
                Return _Icon
            End Get
            Set(ByVal Value As Image)
                _Icon = Value
            End Set
        End Property
#End Region ' (Set|Get) the Icon as Image.
#Region "|2019/04/16 13h35:571| <01.00.07> <Property> <Info> [Call=Description|String]"'(Set|Get) the Description as String.
        Private _Description As String
        ''' <Summary>
        ''' (Set|Get) the Description as String.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/16 13h35:571 </Published>
        ''' <Updated>[Created=2019/04/16 13h35:571][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Info"),
Description("(Set|Get) the Description as String."),
Browsable(True)>
        Public Property Description() As String
            Get
                Return _Description
            End Get
            Set(ByVal Value As String)
                _Description = Value
            End Set
        End Property
#End Region ' (Set|Get) the Description as String.
#Region "|2019/04/17 16h07:415| <01.00.08> <Property> <Info> [Call=Target|String]"'(Set|Get) The location full path.
        Private _Target As String
        ''' <Summary>
        ''' (Set|Get) The location full path.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/17 16h07:415 </Published>
        ''' <Updated>[Created=2019/04/17 16h07:414][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Info"),
Description("(Set|Get) The location full path."),
Browsable(True)>
        <Editor("System.Windows.Forms.Design.SelectedFileEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", GetType(UITypeEditor))>
        Public Property Target() As String
            Get
                Return _Target
            End Get
            Set(ByVal Value As String)
                If Value <> "" Then
                    If IO.File.Exists(Value) Then
                        With Me
                            Dim File As New IO.FileInfo(Value)
                            .FileName = System.IO.Path.GetFileName(Value)
                            .FilePath = New Folder(System.IO.Path.GetDirectoryName(Value))
                            .FullName = Value
                            .Description = ""
                            .Extension = IO.Path.GetExtension(Value)
                            .Name = IO.Path.GetFileNameWithoutExtension(Value)
                            .Access = File.LastAccessTime
                            .Modified = File.LastWriteTime
                            .Created = File.CreationTime
                            .Exists = True
                            .FileSize = New SizeInfo(File.Length)
                            '  .Icon = Retrieve_Icons.GetShellIcon(File.FullName)
                            Value = File.FullName
                        End With

                    End If
                End If
                _Target = Value
            End Set
        End Property
#End Region ' (Set|Get) The location full path.
#Region "|2019/04/17 16h12:373| <01.00.09> <Property> <Info> [Call=Exists|Boolean]"'(Set|Get) Evaluate if the file exist.
        Private _Exists As Boolean
        ''' <Summary>
        ''' (Set|Get) Evaluate if the file exist.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/17 16h12:373 </Published>
        ''' <Updated>[Created=2019/04/17 16h12:373][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Info"),
Description("(Set|Get) Evaluate if the file exist."),
Browsable(True)>
        Public Property Exists() As Boolean
            Get
                Return _Exists
            End Get
            Set(ByVal Value As Boolean)
                _Exists = Value
            End Set
        End Property
#End Region ' (Set|Get) Evaluate if the file exist.
#Region "|2019/05/11 00h10:910| <01.00.10> <Property> <Info> [Call=FileSize|SizeInfo]"'(Set|Get) the FileSize as SizeInfo.
        Private _FileSize As SizeInfo
        ''' <Summary>
        ''' (Set|Get) the FileSize as SizeInfo.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/11 00h10:910 </Published>
        ''' <Updated>[Created=2019/05/11 00h10:910][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Info"), Description("(Set|Get) the FileSize as SizeInfo."), Browsable(True)>
        Public Property FileSize() As SizeInfo
            Get
                Return _FileSize
            End Get
            Set(ByVal Value As SizeInfo)
                _FileSize = Value
            End Set
        End Property
#End Region ' (Set|Get) the FileSize as SizeInfo.
#End Region
#Region "|01.01| <Property> [Date]{3}"
#Region "|2019/04/16 13h32:487| <01.01.00> <Property> <Date> [Call=Acces|DateTime]"'(Set|Get) the last acces DateTime of the file.
        Private _Access As DateTime
        ''' <Summary>
        ''' (Set|Get) the last acces DateTime of the file.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/16 13h32:487 </Published>
        ''' <Updated>[Created=2019/04/16 13h32:487][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Date"),
Description("(Set|Get) the last acces DateTime of the file."),
Browsable(True)>
        Public Property Access() As DateTime
            Get
                Return _Access
            End Get
            Set(ByVal Value As DateTime)
                _Access = Value
            End Set
        End Property
#End Region ' (Set|Get) the last acces DateTime of the file.
#Region "|2019/04/16 13h33:921| <01.01.01> <Property> <Date> [Call=Created|DateTime]"'(Set|Get) The creation DateTime of the file.
        Private _Created As DateTime
        ''' <Summary>
        ''' (Set|Get) The creation DateTime of the file.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/16 13h33:921 </Published>
        ''' <Updated>[Created=2019/04/16 13h33:921][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Date"),
Description("(Set|Get) The creation DateTime of the file."),
Browsable(True)>
        Public Property Created() As DateTime
            Get
                Return _Created
            End Get
            Set(ByVal Value As DateTime)
                _Created = Value
            End Set
        End Property
#End Region ' (Set|Get) The creation DateTime of the file.
#Region "|2019/04/16 13h33:567| <01.01.02> <Property> <Date> [Call=Modified|DateTime]"'(Set|Get) The modified DateTime of the file.
        Private _Modified As DateTime
        ''' <Summary>
        ''' (Set|Get) The modified DateTime of the file.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/16 13h33:567 </Published>
        ''' <Updated>[Created=2019/04/16 13h33:567][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Date"),
Description("(Set|Get) The modified DateTime of the file."),
Browsable(True)>
        Public Property Modified() As DateTime
            Get
                Return _Modified
            End Get
            Set(ByVal Value As DateTime)
                _Modified = Value
            End Set
        End Property
#End Region ' (Set|Get) The modified DateTime of the file.
#End Region
#Region "|01.02| <Property> [Attributes]{5}"
#Region "|2019/04/16 13h37:403| <01.02.00> <Property> <Attributes> [Call=IsCompressed|Boolean]"'(Set|Get) Test if the object is compressed.
        Private _IsCompressed As Boolean
        ''' <Summary>
        ''' (Set|Get) Test if the object is compressed.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/16 13h37:403 </Published>
        ''' <Updated>[Created=2019/04/16 13h37:403][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Attributes"),
Description("(Set|Get) Test if the object is compressed."),
Browsable(True)>
        Public Property IsCompressed() As Boolean
            Get
                Return _IsCompressed
            End Get
            Set(ByVal Value As Boolean)
                _IsCompressed = Value
            End Set
        End Property
#End Region ' (Set|Get) Test if the object is compressed.
#Region "|2019/04/16 13h37:774| <01.02.01> <Property> <Attributes> [Call=IsDataBase|Boolean]"'(Set|Get) Test if the object is database compatible.
        Private _IsDataBase As Boolean
        ''' <Summary>
        ''' (Set|Get) Test if the object is database compatible.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/16 13h37:774 </Published>
        ''' <Updated>[Created=2019/04/16 13h37:774][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Attributes"),
Description("(Set|Get) Test if the object is database compatible."),
Browsable(True)>
        Public Property IsDataBase() As Boolean
            Get
                Return _IsDataBase
            End Get
            Set(ByVal Value As Boolean)
                _IsDataBase = Value
            End Set
        End Property
#End Region ' (Set|Get) Test if the object is database compatible.
#Region "|2019/04/16 13h39:070| <01.02.02> <Property> <Attributes> [Call=IsEncrypted|Boolean]"'(Set|Get) Test if the object is encrypted.
        Private _IsEncrypted As Boolean
        ''' <Summary>
        ''' Test if the object is encrypted.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/16 13h39:070 </Published>
        ''' <Updated>[Created=2019/04/16 13h39:070][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Attributes"),
Description("Test if the object is encrypted."),
Browsable(True)>
        Public Property IsEncrypted() As Boolean
            Get
                Return _IsEncrypted
            End Get
            Set(ByVal Value As Boolean)
                _IsEncrypted = Value
            End Set
        End Property
#End Region ' (Set|Get) Test if the object is encrypted.
#Region "|2019/04/16 13h39:948| <01.02.03> <Property> <Attributes> [Call=IsHidden|Boolean]"'(Set|Get) Test if the object is hidden.
        Private _IsHidden As Boolean
        ''' <Summary>
        ''' Test if the object is hidden.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/16 13h39:948 </Published>
        ''' <Updated>[Created=2019/04/16 13h39:948][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Attributes"),
Description("Test if the object is hidden."),
Browsable(True)>
        Public Property IsHidden() As Boolean
            Get
                Return _IsHidden
            End Get
            Set(ByVal Value As Boolean)
                _IsHidden = Value
            End Set
        End Property
#End Region ' (Set|Get) Test if the object is hidden.
#Region "|2019/04/16 13h40:359| <01.02.04> <Property> <Attributes> [Call=IsReadable|Boolean]"'(Set|Get) Test if the object is readable.
        Private _IsReadable As Boolean
        ''' <Summary>
        ''' Test if the object is readable.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/16 13h40:359 </Published>
        ''' <Updated>[Created=2019/04/16 13h40:359][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Attributes"),
Description("Test if the object is readable."),
Browsable(True)>
        Public Property IsReadable() As Boolean
            Get
                Return _IsReadable
            End Get
            Set(ByVal Value As Boolean)
                _IsReadable = Value
            End Set
        End Property
#End Region ' (Set|Get) Test if the object is readable.
#End Region
#End Region
#Region "|2| [Enumeration]"

#End Region
#Region "|3| [Structure]"

#End Region
#Region "|4| [Sub]"
#Region "|04.00| <Sub> [Clear]"
        Public Sub Clear()
            With Me
                .Access = Nothing
                .Created = Nothing
                .Description = Nothing
                .Exists = False
                .Extension = ""
                .FileName = ""
                .FilePath = New Folder
                .FileSize = New SizeInfo
                .FullName = ""
                .Icon = Nothing
                .IsCompressed = False
                .IsDataBase = False
                .IsEncrypted = False
                .IsHidden = False
                .IsReadable = False
                .Modified = Nothing
                .Name = ""
                .Password = ""
                .Target = ""
            End With
        End Sub
#End Region
#End Region
#Region "|5| [Function]{24}"
#Region "|05.00| <Function> [Shared]{4}"
#Region "<05.00.00> <Function> <Shared> [GetName(FileFullName|String)|String]"
        ''' <summary>
        ''' Retrieve the file name of the given File fullname
        ''' </summary>
        ''' <param name="FileFullName"></param>
        ''' <returns></returns>
        Public Shared Function GetName(ByVal FileFullName As String) As TestItem
            Dim Result As New TestItem("Fichier.GetName", "Retrieve the file name of the given File fullname")
            'Result.AddParam("FileFullName", FileFullName, FileFullName.ToString)
            Result.Body += "Test 1 : Evaluation if the Path is a FileInfo" & Environment.NewLine &
            "     >On Fail> Run Test 2" & Environment.NewLine &
            "Test 2 : Evaluation if the Path is a Directory" & Environment.NewLine
            Result.Body += "[Test 1] ="
            If FileFullName = "" Then
                Result.Body += " <Success>" & Environment.NewLine
                Result.Status = Status.IsNothing
                'Print the output result of this exception
                Result.OutputString = "The given FileFullName value is empty!" & Environment.NewLine
            Else
                Result.Body += " <Failure>" & Environment.NewLine
                Result.Body += "#Region" & Space & "<Error Caught>[" & Space & Environment.NewLine

                Dim Test_FilePath As New TestItem("Is it a File", "Test if it is a file.")
                'Is it a File?
                If IO.File.Exists(FileFullName) Then
                    Test_FilePath.Status = Status.Online
                    Result.AddHypothesis("The file path is recognized", Status.Online, True)
                    Result.OutputString = IO.Path.GetFileNameWithoutExtension(FileFullName) & Environment.NewLine
                    'the test has concluded successfully
                    Result.Status = Status.Finished
                Else
                    'Is it a Directory Info?
                    Dim Test_DirPath As New TestItem("Is it a Dir", "Test if it is a directory or root.")
                    If IO.Directory.Exists(FileFullName) Then
                        'It is a Directory
                        Test_DirPath.OutputString = IO.Path.GetFileNameWithoutExtension(FileFullName) & Environment.NewLine
                        Result.OutputString = IO.Path.GetFileNameWithoutExtension(FileFullName) & Environment.NewLine
                        'the test has concluded successfully
                        Result.Status = Status.Finished
                    Else
                        'It is not a Directory
                        Test_FilePath.Status = Status.Offline
                        Result.AddHypothesis("The path is not recognized as a Directory or FileInfo", Status.Broken, True)
                        'the test has Failed
                        Result.Status = Status.Finished
                        Result.OutputString = "The path is not recognized as a Directory or FileInfo <FilePath=" & (FileFullName) & ">" & Environment.NewLine
                    End If

                End If
                'Is it a Directory Info?
            End If

            Return Result
        End Function
#End Region
#Region "<05.00.01> <Function> <Shared> [GetFilePath(FileFullName|String)|String]"
        ''' <summary>
        ''' Retrieve the file name of the given File Path
        ''' </summary>
        ''' <param name="FileFullName"></param>
        ''' <returns></returns>
        Public Shared Function GetFilePath(ByVal FileFullName As String) As TestItem
            Dim Result As New TestItem("Fichier.GetFilePath", "Retrieve the file path of the given File fullname")
            'Result.AddParam("FileFullName", FileFullName, FileFullName.ToString)
            Result.Body += "Test 1 : Evaluation if the Path is a FileInfo" & Environment.NewLine &
            "     >On Fail> Run Test 2" & Environment.NewLine &
            "Test 2 : Evaluation if the Path is a Directory" & Environment.NewLine
            Result.Body += "[Test 1] ="
            If FileFullName = "" Then
                Result.Body += " <Success>" & Environment.NewLine
                Result.Status = Status.IsNothing
                'Print the output result of this exception
                Result.OutputString = "The given FileFullName value is empty!" & Environment.NewLine
            Else
                Result.Body += " <Failure>" & Environment.NewLine
                Result.Body += "#Region" & Space & "<Error Caught>[" & Space & Environment.NewLine

                Dim Test_FilePath As New TestItem("Is it a File", "Test if it is a file.")
                'Is it a File?
                If IO.File.Exists(FileFullName) Then
                    Test_FilePath.Status = Status.Online
                    Result.AddHypothesis("The file path is recognized", Status.Online, True)
                    Result.OutputString = IO.Path.GetDirectoryName(FileFullName) & Environment.NewLine
                    'the test has concluded successfully
                    Result.Status = Status.Finished
                Else
                    'Is it a Directory Info?
                    Dim Test_DirPath As New TestItem("Is it a Dir", "Test if it is a directory or root.")
                    If IO.Directory.Exists(FileFullName) Then
                        'It is a Directory
                        Test_DirPath.OutputString = IO.Path.GetDirectoryName(FileFullName) & Environment.NewLine
                        Result.OutputString = IO.Path.GetDirectoryName(FileFullName) & Environment.NewLine
                        'the test has concluded successfully
                        Result.Status = Status.Finished
                    Else
                        'It is not a Directory
                        Test_FilePath.Status = Status.Offline
                        Result.AddHypothesis("The path is not recognized as a Directory or FileInfo", Status.Broken, True)
                        'the test has Failed
                        Result.Status = Status.Finished
                        Result.OutputString = "The path is not recognized as a Directory or FileInfo <FilePath=" & (FileFullName) & ">" & Environment.NewLine
                    End If

                End If
                'Is it a Directory Info?
            End If

            Return Result
        End Function
#End Region
#Region "<05.00.02> <Function> <Shared> [GetExtension(FileFullName|String)|String]"
        ''' <summary>
        ''' Retrieve the file extension
        ''' </summary>
        ''' <param name="FileFullName"></param>
        ''' <returns></returns>
        Public Shared Function GetExtension(ByVal FileFullName As String) As TestItem
            Dim Result As New TestItem("Fichier.GetFilePath", "Retrieve the file extensions of the given File fullname")
            'Result.AddParam("FileFullName", FileFullName, FileFullName.ToString)
            Result.Body += "Test 1 : Evaluation if the Path is a FileInfo" & Environment.NewLine &
            "     >On Fail> Run Test 2" & Environment.NewLine &
            "Test 2 : Evaluation if the Path is a Directory" & Environment.NewLine
            Result.Body += "[Test 1] ="
            If FileFullName = "" Then
                Result.Body += " <Success>" & Environment.NewLine
                Result.Status = Status.IsNothing
                'Print the output result of this exception
                Result.OutputString = "The given FileFullName value is empty!" & Environment.NewLine
            Else
                Result.Body += " <Failure>" & Environment.NewLine
                Result.Body += "#Region" & Space & "<Error Caught>[" & Space & Environment.NewLine

                Dim Test_FilePath As New TestItem("Is it a File", "Test if it is a file.")
                'Is it a File?
                If IO.File.Exists(FileFullName) Then
                    Test_FilePath.Status = Status.Online
                    Result.AddHypothesis("The file path is recognized", Status.Online, True)
                    Result.OutputString = IO.Path.GetExtension(FileFullName) & Environment.NewLine
                    'the test has concluded successfully
                    Result.Status = Status.Finished
                Else
                    'Is it a Directory Info?
                    Dim Test_DirPath As New TestItem("Is it a Dir", "Test if it is a directory or root.")
                    If IO.Directory.Exists(FileFullName) Then
                        'It is a Directory
                        Test_DirPath.OutputString = IO.Path.GetExtension(FileFullName) & Environment.NewLine
                        Result.OutputString = IO.Path.GetExtension(FileFullName) & Environment.NewLine
                        'the test has concluded successfully
                        Result.Status = Status.Finished
                    Else
                        'It is not a Directory
                        Test_FilePath.Status = Status.Offline
                        Result.AddHypothesis("The path is not recognized as a Directory or FileInfo", Status.Broken, True)
                        'the test has Failed
                        Result.Status = Status.Finished
                        Result.OutputString = "The path is not recognized as a Directory or FileInfo <FilePath=" & (FileFullName) & ">" & Environment.NewLine
                    End If

                End If
            End If

            Return Result
        End Function
#End Region
#Region "<05.00.03> <Function> <Shared> [GetFileName(FileFullName|String)|String]"
        ''' <summary>
        ''' Retrieve the file name with extensions
        ''' </summary>
        ''' <param name="FileFullName"></param>
        ''' <returns></returns>
        Public Shared Function GetFileName(ByVal FileFullName As String) As TestItem
            Dim Result As New TestItem("Fichier.GetFileName", "Retrieve the file extensions of the given File fullname")
            'Result.AddParam("FileFullName", FileFullName, FileFullName.ToString)
            Result.Body += "Test 1 : Evaluation if the Path is a FileInfo" & Environment.NewLine &
            "     >On Fail> Run Test 2" & Environment.NewLine &
            "Test 2 : Evaluation if the Path is a Directory" & Environment.NewLine
            Result.Body += "[Test 1] ="
            If FileFullName = "" Then
                Result.Body += " <Success>" & Environment.NewLine
                Result.Status = Status.IsNothing
                'Print the output result of this exception
                Result.OutputString = "The given FileFullName value is empty!" & Environment.NewLine
            Else
                Result.Body += " <Failure>" & Environment.NewLine
                Result.Body += "#Region" & Space & "<Error Caught>[" & Space & Environment.NewLine

                Dim Test_FilePath As New TestItem("Is it a File", "Test if it is a file.")
                'Is it a File?
                If IO.File.Exists(FileFullName) Then
                    Test_FilePath.Status = Status.Online
                    Result.AddHypothesis("The file path is recognized", Status.Online, True)
                    Result.OutputString = IO.Path.GetFileName(FileFullName) & Environment.NewLine
                    'the test has concluded successfully
                    Result.Status = Status.Finished
                Else
                    'Is it a Directory Info?
                    Dim Test_DirPath As New TestItem("Is it a Dir", "Test if it is a directory or root.")
                    If IO.Directory.Exists(FileFullName) Then
                        'It is a Directory
                        Test_DirPath.OutputString = IO.Path.GetDirectoryName(FileFullName) & Environment.NewLine
                        Result.OutputString = IO.Path.GetDirectoryName(FileFullName) & Environment.NewLine
                        'the test has concluded successfully
                        Result.Status = Status.Finished
                    Else
                        'It is not a Directory
                        Test_FilePath.Status = Status.Offline
                        Result.AddHypothesis("The path is not recognized as a Directory or FileInfo", Status.Broken, True)
                        'the test has Failed
                        Result.Status = Status.Finished
                        Result.OutputString = "The path is not recognized as a Directory or FileInfo <FilePath=" & (FileFullName) & ">" & Environment.NewLine
                    End If

                End If
            End If

            Return Result
        End Function
#End Region
#End Region
#Region "|05.01| <Function> [Convert]{1}"
#Region "|05.01.00| <Function> <Convert> [Convert_ToListViewItem()|ListViewItem]"
        Public Function Convert_ToListViewItem() As ListViewItem
            Dim Result As New ListViewItem(Me.FileName)
            Result.SubItems.Add(PrintTime(Me.Modified))
            Result.SubItems.Add(Me.Extension)
            Result.SubItems.Add(Me.FileSize.Display)
            Result.SubItems.Add(Me.Target)
            Result.Tag = Me

            Return Result
        End Function
#End Region
#End Region
#Region "|05.02| <Function> [Action]{10}"
#Region "[On] |2019/06/01 13h57:330| <05.02.00> <Function> <Action> |.Delete()|Function}|"' (Set|Get) Delete the file.
        '''    <Summary>
        '''     (Set|Get) Delete the file.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/01 13h57:341 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>

        <Browsable(True), CategoryAttribute("Action"), Description("(Set|Get) Delete the file.")>
        Public Function Delete() As TestItem
            TF_Delete = New TestItem("Delete the file", "Effacement du fichier",,,, "[Fichier]")
            TF_Delete.Status = Status.StandBye
            If IO.File.Exists(Target) Then
                IO.File.Delete(Target)
                TF_Delete.Write("File deleteted" & Target)
            Else
                TF_Delete.Write("File not found " & Target)
                TF_Delete.Why += "File not found >" & Target

            End If
            If IO.File.Exists(Target) Then
                TF_Delete.Status = Status.Broken
                TF_Delete.Write("File has not been deleted >" & Target)
                TF_Delete.Why += "File has not been deleted >" & Target & vbNewLine
            Else
                TF_Delete.Status = Status.Finished
                TF_Delete.Write("File has been deleted >" & Target)
            End If
            Log.Add(TF_Delete)
            Return TF_Delete
        End Function
#End Region '(Set|Get) Delete the file.
#Region "[On] |2019/06/01 14h15:712| <05.02.01> <Function> <Action> |.Change_Extension()|Function}|"' (Set|Get) Change extention the file.
        Public TF_Change_Extension As TestItem
        '''    <Summary>
        '''     (Set|Get) Change extention the file.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/01 14h15:717 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>

        <Browsable(True), CategoryAttribute("Action"), Description("(Set|Get) Change extention the file.")>
        Public Function Change_Extension(ByVal NewExtension As String,
                                     Optional ByVal Speak As Boolean = False,
                                     Optional ByVal Delete As Boolean = True) As TestItem
            TF_Change_Extension = New TestItem("Change_Extension(NewExtension = " & NewExtension & ", [Speak = " & Speak.ToString & " ], [Delete = " & Delete.ToString & " ]",
                                               "Changement de l'extension du fichier de " & Me.Extension & " à " & NewExtension,,,, "[Fichier]")
            Dim NewFile As String = Me.FilePath.Target & "\" & FileName & "." & NewExtension
            TF_Change_Extension.Write("Copy the file path <" & NewFile & ">")
            TF_Change_Extension.Write(Target)
            TF_Change_Extension.InputString = Target
            TF_Change_Extension.Input = Me
            TF_Change_Extension.InputParams = New List(Of Input_Parameters)
            Dim PNewExtension As New Input_Parameters("NewExtension", NewExtension, NewExtension.ToString)
            Dim PSpeak As New Input_Parameters("[Speak]", Speak, Speak.ToString)
            Dim PDelete As New Input_Parameters("[Delete]", Delete, Delete.ToString)
            TF_Change_Extension.InputParams.Add(PNewExtension)
            TF_Change_Extension.InputParams.Add(PSpeak)
            TF_Change_Extension.InputParams.Add(PDelete)
            'TF_Change_Extension.Add(PNewExtension.Log)
            'TF_Change_Extension.Add(PSpeak.Log)
            'TF_Change_Extension.Add(PDelete.Log)
            Try
                IO.File.Copy(Target, NewFile)
                Target = NewFile
                TF_Change_Extension.Status = Status.Online
                TF_Change_Extension.Write("Copy Done Successfully.")
            Catch ex As Exception
                TF_Change_Extension.Write(Format_Error(ex, "Copy(" & Target & "," & NewFile & ")"))
                TF_Change_Extension.AddBug(ex, "Copy()", "Copy(" & Target & "," & NewFile & ")")
                TF_Change_Extension.Status = Status.Broken
                Log.AddBug(ex, "Copy", "Copy(" & Target & "," & NewFile & ")")
            End Try
            If Speak = True Then
                ' Dim SP As New iSpeak()
                ' SP.Speak(Result.Rapport)
            End If
            If Delete = True Then
                TF_Change_Extension.Add(Me.Delete())
            End If
            TF_Change_Extension.Write("Output > " & NewFile)
            TF_Change_Extension.Output = NewFile
            TF_Change_Extension.OutputString = NewFile
            Log.Add(TF_Change_Extension)

            Return TF_Change_Extension

        End Function
#End Region '(Set|Get) Change extention the file.
#Region "[On] |2019/06/01 14h18:495| <05.02.02> <Function> <Action> |.HideFile()|Function}|"' (Set|Get) Hide the file.
        Public TF_HideFile As TestItem
        '''    <Summary>
        '''     (Set|Get) Hide the file.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/01 14h18:500 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>

        <Browsable(True), CategoryAttribute("Action"), Description("(Set|Get) Hide the file.")>
        Public Function HideFile() As TestItem
            TF_HideFile = New TestItem("HideFile", "hide the file",,,, "[Fichier]")

            '  MyEntry.Title = "<Target>" & Target & "</Target>"
            'MyEntry.LineNumber = 5412
            Dim Attributes As FileAttributes

            Try
                Attributes = IO.File.GetAttributes(Attributes)
                If (Attributes And FileAttributes.Normal) = FileAttributes.Normal Then
                    Attributes = FileAttributes.Hidden
                    IO.File.SetAttributes(Target, Attributes)
                    Me.IsHidden = True
                End If
                TF_HideFile.Status = Status.Finished
                TF_HideFile.Write("<File set to Hidden>" & Target & "</File Set to Hidden>")
                ' MyEntry.Save()
            Catch ex As Exception
                'MyEntry.iError = ex
                TF_HideFile.Write(Format_Error(ex, "HideFile"))
                TF_HideFile.AddBug(ex, "HideFile", "HideFile()")
                TF_HideFile.Status = Status.Broken
                Log.AddBug(ex, "HideFile", "HideFile()")
            End Try
            ' MyEntry.Save()
            Log.Add(TF_HideFile)

            Return TF_HideFile

        End Function
#End Region '(Set|Get) Hide the file.
#Region "[On] |2019/06/01 14h20:234| <05.02.03> <Function> <Action> |.UnHide()|Function}|"' (Set|Get) Unhide the file.
        Public TF_Unhide As TestItem
        '''    <Summary>
        '''     (Set|Get) Unhide the file.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/01 14h20:239 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>

        <Browsable(True), CategoryAttribute("Action"), Description("(Set|Get) Unhide the file.")>
        Public Function UnHide() As TestItem
            TF_Unhide = New TestItem("Unhide", "Unhide the selected file",,,, "[Fichier]")
            Dim Attributes As FileAttributes
            'MyEntry.LineNumber = 5440
            Try
                Attributes = IO.File.GetAttributes(Attributes)
                If (Attributes And FileAttributes.Hidden) = FileAttributes.Hidden Then
                    Attributes = RemoveAttribute(Attributes, FileAttributes.Hidden)
                    IO.File.SetAttributes(Target, Attributes)
                    Me.IsHidden = False
                End If
                TF_Unhide.Status = Status.Finished
                TF_Unhide.Write("<File set to Hidden>" & Target & "</File Set to Hidden>")
                'MyEntry.Save()
            Catch ex As Exception
                TF_Unhide.Write(Format_Error(ex, "HideFile"))

                TF_Unhide.AddBug(ex, "HideFile", "HideFile()")
                Log.AddBug(ex, "HideFile", "HideFile()")
                TF_Unhide.Status = Status.Broken
            End Try
            'MyEntry.Save()
            Log.Add(TF_Unhide)

            Return TF_Unhide
        End Function
#End Region '(Set|Get) Unhide the file.
#Region "[On] |2019/06/01 14h23:386| <05.02.04> <Function> <Action> |.Compress()|Function}|"' (Set|Get) Compress the file.
        Public TF_Compress As TestItem
        '''    <Summary>
        '''     (Set|Get) Compress the file.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/01 14h23:392 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        ''' <param name="Delete_File">Do you want to delete the file?</param>
        ''' <param name="Speak">Do you want a the program to respond orally to the command?</param>
        <Browsable(True), CategoryAttribute("Action"), Description("(Set|Get) Compress the file.")>
        Public Function Compress(Optional ByVal Delete_File As Boolean = False,
                             Optional ByVal Speak As Boolean = False) As TestItem
            TF_Compress = New TestItem("Compress", "Compression du fichier",, "[Delete_File]= " & Delete_File.ToString & "|[Speak]= " & Speak.ToString,, "[Fichier]")

            TF_Compress.InputParams = New List(Of Input_Parameters)
            Dim PDelete_File As New Input_Parameters("Delete_File", Delete_File, Delete_File.ToString)
            Dim PSpeak As New Input_Parameters("[Speak]", Speak, Speak.ToString)
            TF_Compress.InputParams.Add(PDelete_File)
            TF_Compress.InputParams.Add(PSpeak)
            TF_Compress.InputParams.Add(PDelete_File)
            ' TF_Compress.Add(PDelete_File.Log)
            ' TF_Compress.Add(PSpeak.Log)
            ' TF_Compress.Add(PDelete_File.Log)
            If Exists = False Then
                TF_Compress.Write("File Is empty")
                '  MyEntry.Save()
            Else
                Dim buffer As Byte() = Nothing
                Dim sourceStream As FileStream = Nothing
                Dim destinationStream As FileStream = Nothing
                Dim compressedStream As GZipStream = Nothing
                Try
                    sourceStream = New FileStream(Target, FileMode.Open, FileAccess.Read, FileShare.Read)
                    buffer = New Byte(sourceStream.Length) {}
                    Dim checkCounter As Integer = sourceStream.Read(buffer, 0, buffer.Length)
                    destinationStream = New FileStream(Change_Extension(".Zip", False, False).OutputString, FileMode.OpenOrCreate, FileAccess.Write)
                    compressedStream = New GZipStream(destinationStream, CompressionMode.Compress, True)
                    compressedStream.Write(buffer, 0, buffer.Length)
                    If Delete_File = True Then
                        Dim To_Delete As New FileInfo(Target)
                        To_Delete.Delete()
                    End If
                    '  Result.Rapport += "<Target>" & Target & "</Target>" & vbNewLine &
                    '  "has been compressed to " & Change_Extension(".Zip", False, False).Output.Text & "."
                    TF_Compress.Status = Status.Finished
                Catch ex As ApplicationException
                    TF_Compress.Write(Format_Error(ex, "Compression"))
                    Log.AddBug(ex, "Compression", "Compression()")

                    TF_Compress.AddBug(ex, "Compression", "Compression()")
                    TF_Compress.Status = Status.Broken
                Finally
                    If Not (sourceStream Is Nothing) Then
                        sourceStream.Close()
                    End If
                    If Not (compressedStream Is Nothing) Then
                        compressedStream.Close()
                    End If
                    If Not (destinationStream Is Nothing) Then
                        destinationStream.Close()
                    End If
                End Try
            End If
            Log.Add(TF_Compress)
            Me.IsCompressed = True
            Return TF_Compress
        End Function
#End Region '(Set|Get) Compress the file.
#Region "[On] |2019/06/01 14h31:687| <05.02.05> <Function> <Action> |.Extract()|Function}|"' (Set|Get) Extract the file.
        Public TF_Extract As TestItem
        '''    <Summary>
        '''     (Set|Get) Extract the file.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/01 14h31:692 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        ''' <param name="Extract_Where">Enter a valid Directory Path</param>
        ''' <param name="Delete_File">Do you want to delete the file?</param>
        ''' <param name="Speak">Do you want a the program to respond orally to the command?</param>
        <Browsable(True), CategoryAttribute("Action"), Description("(Set|Get) Extract the file.")>
        Public Function Extract(ByVal Extract_Where As String,
                            Optional ByVal Delete_File As Boolean = False,
                             Optional ByVal Speak As Boolean = False) As TestItem
            TF_Extract = New TestItem("Extract", "Extraction du fichier",, "Extract_Where= " & Extract_Where & " [Delete_File]= " & Delete_File.ToString & "|[Speak]= " & Speak.ToString)

            TF_Extract.InputParams = New List(Of Input_Parameters)
            Dim PExtract_Where As New Input_Parameters("Extract_Where", Extract_Where, Extract_Where.ToString)
            Dim PDelete_File As New Input_Parameters("Delete_File", Delete_File, Delete_File.ToString)
            Dim PSpeak As New Input_Parameters("[Speak]", Speak, Speak.ToString)
            TF_Extract.InputParams.Add(PDelete_File)
            TF_Extract.InputParams.Add(PSpeak)
            TF_Extract.InputParams.Add(PExtract_Where)

            TF_Extract.InputParams.Add(PDelete_File)
            '   TF_Extract.Add(PDelete_File.Log)
            '  TF_Extract.Add(PExtract_Where.Log)
            'TF_Extract.Add(PSpeak.Log)
            'TF_Extract.Add(PDelete_File.Log)

            If Extract_Where = Nothing Then
                Dim FDB As New FolderBrowserDialog
                If FDB.ShowDialog = DialogResult.OK Then
                    Extract_Where = FDB.SelectedPath
                End If
            End If
            If Exists = False Then
                TF_Extract.Write("File Is empty")
                ' MyEntry.Save()
            Else
                Dim sourceStream As New FileStream(Target, FileMode.Open)
                Dim destinationStream As FileStream = Nothing
                Dim decompressedStream As New GZipStream(sourceStream, CompressionMode.Decompress, True)
                Dim quartetBuffer As Byte() = Nothing
                Dim compressedStream As GZipStream = Nothing
                Try
                    Using decompressedStream
                        quartetBuffer = New Byte(4) {}
                        Dim position As Integer = CType(sourceStream.Length, Integer) - 4
                        sourceStream.Position = position
                        sourceStream.Read(quartetBuffer, 0, 4)
                        sourceStream.Position = 0
                        Dim checkLength As Integer = BitConverter.ToInt32(quartetBuffer, 0)
                        Dim buffer(checkLength + 100) As Byte
                        Dim offset As Integer = 0
                        Dim total As Integer = 0
                        While True
                            Dim bytesRead As Integer = decompressedStream.Read(buffer, offset, 100)
                            If bytesRead = 0 Then
                                Exit While
                            End If
                            offset += bytesRead
                            total += bytesRead
                        End While
                        destinationStream = New FileStream(Extract_Where, FileMode.Create)
                        destinationStream.Write(buffer, 0, total)
                        destinationStream.Flush()
                    End Using
                    '  Result.Rapport += "<Target>" & Target & "</Target>" & vbNewLine &
                    ' "has been extracted to " & Extract_Where & vbNewLine
                    TF_Extract.Status = Status.Finished
                Catch ex As ApplicationException
                    TF_Extract.Write(Format_Error(ex, "Extraction"))
                    Log.AddBug(ex, "Extraction", "Extraction()")

                    TF_Extract.AddBug(ex, "Extraction", "Extraction()")
                    TF_Extract.Status = Status.Broken
                Finally
                    If Not (sourceStream Is Nothing) Then
                        sourceStream.Close()
                    End If
                    If Not (decompressedStream Is Nothing) Then
                        decompressedStream.Close()
                    End If
                    If Not (destinationStream Is Nothing) Then
                        destinationStream.Close()
                    End If
                End Try
                If Delete_File = True Then
                    Dim To_Delete As New FileInfo(Delete_File)
                    To_Delete.Delete()
                End If
                '   If Speak = True Then
                '  Dim SP As New iSpeak()
                '  SP.Speak(Result.Rapport)
                'End If
            End If
            '  MyEntry.Save()
            Log.Add(TF_Extract)

            Return TF_Extract
        End Function
#End Region '(Set|Get) Extract the file.
#Region "[On] |2019/06/01 14h33:209| <05.02.06> <Function> <Action> |.Copy()|Function}|"' (Set|Get) Copy the file.
        Public TF_Copy As TestItem
        '''    <Summary>
        '''     (Set|Get) Copy the file.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/01 14h33:215 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        ''' <param name="Destination">Enter a valid Directory Path</param>
        ''' <param name="Overwrite">If existing file do you want to overwrite it?</param>
        <Browsable(True), CategoryAttribute("Action"), Description("(Set|Get) Copy the file.")>
        Public Function Copy(ByVal Destination As String,
                         Optional ByVal Rename As String = "",
                         Optional ByVal Overwrite As Boolean = False) As TestItem
            TF_Copy = New TestItem("Copy(Destination,Overwrite)|TestItem]", "Copy file to New destination")
            TF_Copy.InputParams = New List(Of Input_Parameters)

            Dim PDestination As New Input_Parameters("Destination", Destination, Destination.ToString)
            TF_Copy.InputParams.Add(PDestination)
            ' TF_Copy.Add(PDestination.Log)

            Dim PRename As New Input_Parameters("[Rename]", Rename, Rename.ToString)
            TF_Copy.InputParams.Add(PRename)
            'TF_Copy.Add(PRename.Log)

            Dim POverwrite As New Input_Parameters("[Overwrite]", Overwrite, Overwrite.ToString)
            TF_Copy.InputParams.Add(POverwrite)
            'TF_Copy.Add(POverwrite.Log)
            TF_Copy.InputString = Me.Target
            TF_Copy.Input = Me
            Try
                If Not IO.Directory.Exists(Destination) Then
                    '    IO.Directory.CreateDirectory(Destination)
                End If
            Catch ex As Exception

            End Try

            Try
                If Rename <> "" Then
                    TF_Copy.OutputString = Destination & "\" & Rename & Extension
                Else
                    TF_Copy.OutputString = Destination & "\" & FileName

                End If
                IO.File.Copy(Target, TF_Copy.OutputString, Overwrite)
                TF_Copy.Write("<File has been copied to > " & TF_Copy.OutputString)
                TF_Copy.Status = Status.Finished
            Catch ex As Exception
                TF_Copy.Write(Format_Error(ex, "Copy"))
                Log.AddBug(ex, "Copy", "Copy()")

                TF_Copy.AddBug(ex, "Copy", "Copy()")
                TF_Copy.Status = Status.Broken
            End Try
            ' MyEntry.Save()
            Log.Add(TF_Copy)

            Return TF_Copy
        End Function
#End Region '(Set|Get) Copy the file.
#Region "[On] |2019/06/01 14h35:825| <05.02.07> <Function> <Action> |.Cut()|Function}|"' (Set|Get) Cut the file.
        Public TF_Cut As TestItem
        '''    <Summary>
        '''     (Set|Get) Cut the file.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/01 14h35:830 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        ''' <param name="Destination">Enter a valid Directory Path</param>
        ''' <param name="Overwrite">If existing file do you want to overwrite it?</param>
        <Browsable(True), CategoryAttribute("Action"), Description("(Set|Get) Cut the file.")>
        Public Function Cut(ByVal Destination As String,
                        Optional ByVal Overwrite As Boolean = False) As TestItem
            TF_Cut = New TestItem("Cut", "[Cut(Destination,Overwrite)|TestItem]")
            TF_Cut.InputParams = New List(Of Input_Parameters)

            Dim PDestination As New Input_Parameters("Destination", Destination, Destination.ToString)
            TF_Cut.InputParams.Add(PDestination)
            'TF_Cut.Add(PDestination.Log)

            Dim POverwrite As New Input_Parameters("[Overwrite]", Overwrite, Overwrite.ToString)
            TF_Cut.InputParams.Add(POverwrite)
            '  TF_Cut.Add(POverwrite.Log)

            TF_Cut.InputString = Me.Target
            TF_Cut.Input = Me

            If Not IO.Directory.Exists(Destination) Then
                IO.Directory.CreateDirectory(Destination)
            End If

            Try
                TF_Cut.OutputString = Destination & "\" & FileName
                IO.File.Copy(Target, TF_Cut.OutputString, Overwrite)
                TF_Cut.Write("<Info>" & vbNewLine & "<File has been copied to > " & TF_Cut.OutputString)
                TF_Cut.Status = Status.Finished
            Catch ex As Exception
                TF_Cut.Write(Format_Error(ex, "Cut"))
                Log.AddBug(ex, "Cut", "Cut()")

                TF_Cut.AddBug(ex, "Cut", "Cut()")
                TF_Cut.Status = Status.Broken
            End Try
            Log.Add(TF_Cut)
            Return TF_Cut
        End Function
#End Region '(Set|Get) Cut the file.
#Region "[On] |2019/06/01 14h38:825| <05.02.08> <Function> <Action> |.RemoveAttribute()|Function}|"' (Set|Get) This function removes the File Attributes.
        '''    <Summary>
        '''     (Set|Get) This function removes the File Attributes.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/01 14h38:830 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>

        <Browsable(True), CategoryAttribute("Action"), Description("(Set|Get) This function removes the File Attributes.")>
        Public Function RemoveAttribute(ByVal attributes As FileAttributes,
                                    ByVal attributesToRemove As FileAttributes) As FileAttributes
            Return attributes And (Not attributesToRemove)
        End Function
#End Region '(Set|Get) This function removes the File Attributes.
#Region "[On] |2019/06/01 14h39:809| <05.02.09> <Function> <Action> |.Create()|Function}|"' (Set|Get) Create the File.
        Public TF_Create As TestItem
        '''    <Summary>
        '''     (Set|Get) Create the File.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/01 14h39:814 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>

        <Browsable(True), CategoryAttribute("Action"), Description("(Set|Get) Create the File.")>
        Public Function Create() As TestItem
            TF_Create = New TestItem("Create", "Creation of the file.")

            If IO.File.Exists(Target) Then
                TF_Create.Status = Status.Finished
            Else
                Try
                    IO.File.Create(Target)
                    TF_Create.Write("File has been created : " & Target)
                Catch ex As Exception
                    TF_Create.Write(Format_Error(ex, "Create"))
                    Log.AddBug(ex, "Create", "Create()")

                    TF_Create.AddBug(ex, "Create", "Create()")
                    TF_Create.Status = Status.Broken

                End Try
            End If
            If IO.File.Exists(Target) Then
                TF_Create.Status = Status.Finished
            Else
                TF_Create.Status = Status.Broken
            End If
            Log.Add(TF_Create)
            Return TF_Create
        End Function
#End Region '(Set|Get) Create the File.
#End Region
#Region "|05.03| <Function> [Encryption]{8}"
        Public TF_Encrypt As TestItem
        Public TF_Decrypt As TestItem
#Region "|05.03.00| <Function> <Encryption> [Encrypt|TestItem]"
        ''' <summary>
        ''' Encrypt Selected file
        ''' </summary>
        ''' <returns></returns>
        Public Function Encrypt() As TestItem
            TF_Encrypt = New TestItem("Encrypt", "Encryption du fichier")
            Try
                TF_Encrypt.Add(F_Encrypt(F_CreateKey_Method1(My.Settings.Key), F_CreateKey_Method2(My.Settings.Key)), "F_Encrypt(F_CreateKey_Method1(My.Setting.Key)=" & F_CreateKey_Method1(My.Settings.Key).ToString &
                           " ,  F_CreateKey_Method2(My.Settings.Key) = " & F_CreateKey_Method2(My.Settings.Key).ToString & " )")
                TF_Encrypt.Status = Status.Online
                TF_Encrypt.Write("File has encrypted ")
            Catch ex As Exception
                TF_Encrypt.Write(Format_Error(ex, "Encrypt"))
                TF_Encrypt.AddBug(ex, "Encrypt", "Encrypt()")
                Log.AddBug(ex, "Encrypt", "Encrypt()")
                TF_Encrypt.Status = Status.Broken
            End Try
            'MyEntry.Save()
            Log.Add(TF_Encrypt)
            Return TF_Encrypt
        End Function
#End Region
#Region "|05.03.01| <Function> <Encryption> [Encrypt(Strong_Password|String)|TestItem]"
        ''' <summary>
        ''' Encrypt File with define Password
        ''' </summary>
        ''' <param name="Strong_Password"></param>
        ''' <returns></returns>
        Public Function Encrypt(ByVal Strong_Password As String) As TestItem
            TF_Encrypt = New TestItem("Encrypt( " & Strong_Password & " )", "Encryption du fichier avec mot de passe")
            TF_Encrypt.InputParams = New List(Of Input_Parameters)
            Dim PStrong_Password As New Input_Parameters("Strong_Password", Strong_Password, Strong_Password.ToString)
            ' TF_Encrypt.Add(PStrong_Password.Log)
            TF_Encrypt.InputParams.Add(PStrong_Password)

            Dim PTarget As New Input_Parameters("Me.Target", Me.Target, Me.Target.ToString)
            '  TF_Encrypt.Add(PTarget.Log)
            TF_Encrypt.InputParams.Add(PTarget)

            TF_Encrypt.Write("Encrypt <" & Target & ">")
            Try
                TF_Encrypt.Add(F_Encrypt(F_CreateKey_Method1(Strong_Password), F_CreateKey_Method2(Strong_Password)), "F_Encrypt(F_CreateKey_Method1(Strong_Password)=" & F_CreateKey_Method1(Strong_Password).ToString &
                           " ,  F_CreateKey_Method2(Strong_Password) = " & F_CreateKey_Method2(Strong_Password).ToString & " )")
                ' Result.Rapport = Target
                TF_Encrypt.Status = Status.Online
                TF_Encrypt.Write("File has encrypted with <Password>" & Strong_Password & "</Password>")
            Catch ex As Exception
                TF_Encrypt.Write(Format_Error(ex, "Encrypt"))
                TF_Encrypt.AddBug(ex, "Encrypt", "Encrypt()")
                Log.AddBug(ex, "Encrypt", "Encrypt()")
                TF_Encrypt.Status = Status.Broken
            End Try
            ' MyEntry.Save()
            Log.Add(TF_Encrypt)
            Return TF_Encrypt
        End Function
#End Region
#Region "|05.03.02| <Function> <Encryption> [Decrypt()|TestItem]"
        ''' <summary>
        ''' Decrypt Selected file
        ''' </summary>
        ''' <returns></returns>
        Public Function Decrypt() As TestItem
            TF_Decrypt = New TestItem("Decrypt()", "Decryption du fichier")
            TF_Decrypt.Write("Public Function Decrypt() As TestItem")
            TF_Decrypt.Write("Decrypt <" & Target & ">")
            Try
                ' F_Decrypt(F_CreateKey_Method1(My.Settings.Key), F_CreateKey_Method2(My.Settings.Key))
                TF_Decrypt.Add(F_Decrypt(F_CreateKey_Method1(My.Settings.Key), F_CreateKey_Method2(My.Settings.Key)), "F_Decrypt(F_CreateKey_Method1(My.Setting.Key)=" & F_CreateKey_Method1(My.Settings.Key).ToString &
                           " ,  F_CreateKey_Method2(My.Settings.Key) = " & F_CreateKey_Method2(My.Settings.Key).ToString & " )")
                TF_Decrypt.Status = Status.Online
                ' Result.Rapport += "File has Decrypted " & vbNewLine
            Catch ex As Exception
                TF_Decrypt.Write(Format_Error(ex, "Decrypt"))
                TF_Decrypt.AddBug(ex, "Decrypt", "Decrypt()")
                Log.AddBug(ex, "Decrypt", "Decrypt()")
                TF_Decrypt.Status = Status.Broken
            End Try
            'MyEntry.Save()
            Return TF_Decrypt
        End Function
#End Region
#Region "|05.03.03| <Function> <Encryption> [Decrypt(Strong_Password|String)|TestItem]"
        ''' <summary>
        ''' Decrypt File with define Password
        ''' </summary>
        ''' <param name="Strong_Password"></param>
        ''' <returns></returns>
        Public Function Decrypt(ByVal Strong_Password As String) As TestItem
            TF_Decrypt = New TestItem("Encrypt( " & Strong_Password & " )", "Decryption du fichier avec mot de passe")
            TF_Decrypt.InputParams = New List(Of Input_Parameters)
            Dim PStrong_Password As New Input_Parameters("Strong_Password", Strong_Password, Strong_Password.ToString)
            'TF_Decrypt.Add(PStrong_Password.Log)
            TF_Decrypt.InputParams.Add(PStrong_Password)

            Dim PTarget As New Input_Parameters("Me.Target", Me.Target, Me.Target.ToString)
            'TF_Decrypt.Add(PTarget.Log)
            TF_Decrypt.InputParams.Add(PTarget)

            TF_Decrypt.Write("Encrypt <" & Target & ">")
            Try
                ' F_Decrypt(F_CreateKey_Method1(Strong_Password), F_CreateKey_Method2(Strong_Password))
                TF_Decrypt.Add(F_Decrypt(F_CreateKey_Method1(Strong_Password), F_CreateKey_Method2(Strong_Password)), "F_Decrypt(F_CreateKey_Method1(Strong_Password)=" & F_CreateKey_Method1(Strong_Password).ToString &
                           " ,  F_CreateKey_Method2(Strong_Password) = " & F_CreateKey_Method2(Strong_Password).ToString & " )")
                ' Result.Rapport = Target
                TF_Decrypt.Status = Status.Online
                TF_Decrypt.Write("File has Decrypted with <Password>" & Strong_Password & "</Password>")
            Catch ex As Exception
                TF_Decrypt.Write(Format_Error(ex, "Decrypt"))
                TF_Decrypt.AddBug(ex, "Decrypt", "Decrypt()")
                TF_Decrypt.Status = Status.Broken
                Log.AddBug(ex, "Decrypt", "Decrypt()")
            End Try
            'MyEntry.Save()

            Return TF_Decrypt
        End Function
#End Region
#Region "|05.03.04| <Function> <Encryption> [F_Encrypt(BytKey(),BytIV())|TestItem]"
        ''' <summary>
        ''' Encrypt the Active File Given a proper Key Encryption
        ''' </summary>
        ''' <param name="BytKey"></param>
        ''' <param name="BytIV"></param>
        ''' <returns></returns>
        Public Function F_Encrypt(ByVal BytKey() As Byte,
                                   ByVal BytIV() As Byte) As TestItem
            Dim Result As New TestItem("F_Encrypt", "Encryption process")
            'Set File Streams
            Dim FileInput As FileStream
            Dim FileOutput As FileStream

            'Create a Temporary File
            Dim Temporary_File As String = Target
            Dim Actual_Extension As String = Extension
            Dim Encrypted_File As String = StringRange.Replace(Target, Extension, ".Temp").Text
            Result.Write("<Temporary_File> " & Target & " </Temporary_File>")
            Result.Write("<Actual_Extension> " & Actual_Extension & " </Actual_Extension>")
            Result.Write("<Encrypted_File> " & Encrypted_File & " </Encrypted_File>")

            'Start the Process
            Try
                'Set FileStreams
                FileInput = New FileStream(Target, FileMode.Open, FileAccess.Read)
                FileOutput = New FileStream(Encrypted_File, FileMode.OpenOrCreate, FileAccess.Write)
                Result.Write("<FileInput> " & Target & " </FileInput>")
                Result.Write("<FileOutput> " & Encrypted_File & " </FileOutput>")


                'Set FileOutput
                FileOutput.SetLength(0) 'Empty the FileOupt Length to 0 bytes

                'Set Buffer
#Region "<Buffer>"
                Dim ByteBuffer(4096) As Byte                    'Set the buffer Size PackAgeView of 4096
                Dim LongBytesProcessed As Long = 0              'Prepare calculation of LongbytesProcessed
                Dim LongFileLength As Long = FileInput.Length   'Prepare total bytes as FileInput.Length representing the size
                Dim IntBytesInCurrentBlock As Integer           'Calculation of bytes in a PackAgeView

                'Preparing CryptoSecurity Process
                Dim CsCryptoStream As CryptoStream              'Creating CryptoStream
                'Must import                                    'Imports System.Security.Cryptography
                Dim CryptoSaadry As New RijndaelManaged         'Special Class for encryption
#End Region
                'Running the process
                CsCryptoStream = New CryptoStream(FileOutput, CryptoSaadry.CreateEncryptor(BytKey, BytIV), CryptoStreamMode.Write)
                While LongBytesProcessed < LongFileLength       'Process until it reads all the fileInput bytes
                    IntBytesInCurrentBlock = FileInput.Read(ByteBuffer, 0, 4096) 'Define the size of the packAgeView
                    CsCryptoStream.Write(ByteBuffer, 0, IntBytesInCurrentBlock)    'Write read bytes into the CryptoStream who converts its to the Fileouput
                    LongBytesProcessed = LongBytesProcessed + CLng(IntBytesInCurrentBlock)
                End While

                CsCryptoStream.Close()
                CsCryptoStream.Dispose()
                FileInput.Close()
                FileOutput.Close()
                Result.Add(Me.Delete)
                'StringRange.Replace(Target, Extension, ".Temp").Text
                IO.File.Copy(Encrypted_File, StringRange.Replace(Encrypted_File, ".Temp", Actual_Extension).Text, True)
                Result.Write("Copy file " & Encrypted_File & "," & StringRange.Replace(Encrypted_File, ".Temp", Actual_Extension).Text)
                IO.File.Delete(Encrypted_File)
                Me.Target = StringRange.Replace(Encrypted_File, ".Temp", Actual_Extension).Text
                Result.Write("New designated file " & Encrypted_File)
            Catch When Err.Number = 53
                Result.Write("Please check to make sure the path And filename" + "are correct And if the file exists." & vbNewLine & Encrypted_File)
                Result.Status = Status.Broken
            Catch
            End Try
            ' Change_Extension(Encrypted_File, Actual_Extension, True)
            Log.Add(Result)

            Return Result
        End Function
#End Region
#Region "|05.03.05| <Function> <Encryption> [F_Decrypt(BytKey(),BytIV())|TestItem]"
        ''' <summary>
        ''' Decrypt the Active File Given a proper Key Encryption
        ''' </summary>
        ''' <param name="BytKey"></param>
        ''' <param name="BytIV"></param>
        ''' <returns></returns>
        Public Function F_Decrypt(ByVal BytKey() As Byte,
                                   ByVal BytIV() As Byte) As TestItem
            Dim Result As New TestItem("F_Decrypt", "Decrypt the Active File Given a proper Key Encryption")
            ' Result.Status = Status.StandBye
            '  Result.Name = "[Fichier=" & Me.Name & "]<04.04.06> [F_Decrypt(BytKey(),BytIV())|TestItem]"
            'Set File Streams
            Dim FileInput As FileStream
            Dim FileOutput As FileStream

            'Create a Temporary File
            Dim Temporary_File As String = Target
            Dim Actual_Extension As String = Extension
            Dim Encrypted_File As String = StringRange.Replace(Target, Extension, ".Temp").Text
            Result.Write("<Temporary_File> " & Target & " </Temporary_File>")
            Result.Write("<Actual_Extension> " & Actual_Extension & " </Actual_Extension>")
            Result.Write("<Encrypted_File> " & Encrypted_File & " </Encrypted_File>")
            'Start the Process
            Try
                'Set FileStreams
                FileInput = New FileStream(Target, FileMode.Open, FileAccess.Read)
                FileOutput = New FileStream(Encrypted_File, FileMode.OpenOrCreate, FileAccess.Write)
                'Remove_Character_FromString(Target, Extension) & ".Temp"
                'Set FileOutput
                FileOutput.SetLength(0) 'Empty the FileOupt Length to 0 bytes

                'Set Buffer
#Region "<Buffer>"
                Dim ByteBuffer(4096) As Byte                    'Set the buffer Size PackAgeView of 4096
                Dim LongBytesProcessed As Long = 0              'Prepare calculation of LongbytesProcessed
                Dim LongFileLength As Long = FileInput.Length   'Prepare total bytes as FileInput.Length representing the size
                Dim IntBytesInCurrentBlock As Integer           'Calculation of bytes in a PackAgeView

                'Preparing CryptoSecurity Process
                Dim CsCryptoStream As CryptoStream              'Creating CryptoStream
                'Must import                                    'Imports System.Security.Cryptography
                Dim CryptoSaadry As New RijndaelManaged         'Special Class for encryption
#End Region
                'Running the process
                CsCryptoStream = New CryptoStream(FileOutput, CryptoSaadry.CreateDecryptor(BytKey, BytIV), CryptoStreamMode.Write)
                While LongBytesProcessed < LongFileLength       'Process until it reads all the fileInput bytes
                    IntBytesInCurrentBlock = FileInput.Read(ByteBuffer, 0, 4096) 'Define the size of the packAgeView
                    CsCryptoStream.Write(ByteBuffer, 0, IntBytesInCurrentBlock)    'Write read bytes into the CryptoStream who converts its to the Fileouput
                    LongBytesProcessed = LongBytesProcessed + CLng(IntBytesInCurrentBlock)
                End While

                CsCryptoStream.Close()
                CsCryptoStream.Dispose()
                FileInput.Close()
                FileOutput.Close()
                Result.Add(Me.Delete)

                IO.File.Copy(Encrypted_File, StringRange.Replace(Encrypted_File, ".Temp", Actual_Extension).Text, True)
                Result.Write("Copy file " & Encrypted_File & "," & StringRange.Replace(Encrypted_File, ".Temp", Actual_Extension).Text)
                IO.File.Delete(Encrypted_File)
                Me.Target = StringRange.Replace(Encrypted_File, ".Temp", Actual_Extension).Text
                Result.Write("New designated file " & Target)

            Catch When Err.Number = 53
                Result.Write("Please check to make sure the path And filename are correct And if the file exists." & vbNewLine & Encrypted_File)
                Result.Status = Status.Broken
            Catch
            End Try
            Log.Add(Result)
            Return Result
        End Function
#End Region
#Region "|05.03.06| <Function> <Encryption> [F_CreateKey_Method1(StrongPassword)|Byte()]"
        ''' <summary>
        ''' Creating a Strong Key with Method 1
        ''' </summary>
        ''' <param name="StrongPassword"></param>
        ''' <returns></returns>
        Public Function F_CreateKey_Method1(ByVal StrongPassword As String) As Byte()
            'Convert strPassword to an array and store in chrData.
            Dim chrData() As Char = StrongPassword.ToCharArray
            'Use intLength to get strPassword size.
            Dim intLength As Integer = chrData.GetUpperBound(0)
            'Declare bytDataToHash and make it the same size as chrData.
            Dim bytDataToHash(intLength) As Byte

            'Use For Next to convert and store chrData into bytDataToHash.
            For i As Integer = 0 To chrData.GetUpperBound(0)
                bytDataToHash(i) = CByte(Asc(chrData(i)))
            Next

            'Declare what hash to use.
            Dim SHA512 As New System.Security.Cryptography.SHA512Managed
            'Declare bytResult, Hash bytDataToHash and store it in bytResult.
            Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
            'Declare bytKey(31).  It will hold 256 bits.
            Dim bytKey(31) As Byte

            'Use For Next to put a specific size (256 bits) of 
            'bytResult into bytKey. The 0 To 31 will put the first 256 bits
            'of 512 bits into bytKey.
            For i As Integer = 0 To 31
                bytKey(i) = bytResult(i)
            Next

            Return bytKey 'Return the key.
        End Function
#End Region
#Region "|05.03.07| <Function> <Encryption> [F_CreateKey_Method2(Strong_Password)|Byte()]"
        ''' <summary>
        ''' Creating a Strong Key with Method 2
        ''' </summary>
        ''' <param name="Strong_Password"></param>
        ''' <returns></returns>
        Public Function F_CreateKey_Method2(ByVal Strong_Password As String) As Byte()
            'Convert strPassword to an array and store in chrData.
            Dim chrData() As Char = Strong_Password.ToCharArray
            'Use intLength to get strPassword size.
            Dim intLength As Integer = chrData.GetUpperBound(0)
            'Declare bytDataToHash and make it the same size as chrData.
            Dim bytDataToHash(intLength) As Byte

            'Use For Next to convert and store chrData into bytDataToHash.
            For i As Integer = 0 To chrData.GetUpperBound(0)
                bytDataToHash(i) = CByte(Asc(chrData(i)))
            Next

            'Declare what hash to use.
            Dim SHA512 As New System.Security.Cryptography.SHA512Managed
            'Declare bytResult, Hash bytDataToHash and store it in bytResult.
            Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
            'Declare bytIV(15).  It will hold 128 bits.
            Dim bytIV(15) As Byte

            'Use For Next to put a specific size (128 bits) of 
            'bytResult into bytIV. The 0 To 30 for bytKey used the first 256 bits.
            'of the hashed password. The 32 To 47 will put the next 128 bits into bytIV.
            For i As Integer = 32 To 47
                bytIV(i - 32) = bytResult(i)
            Next

            Return bytIV 'return the IV
        End Function
#End Region
#End Region
        Public Overrides Function ToString() As String
            Return Target
        End Function
#End Region
#Region "|6| [Runtime]"
        Public TF_Delete As TestItem
        Public Property Log As New TestItem
#End Region
#Region "|7| [Loader]"
#Region "|07.00| <Loader> [Empty]"
        Public Sub New()
            Clear()
        End Sub
#End Region
#Region "|07.01| <Loader> [FilePath|String,[Password]|String]"
        Public Sub New(ByVal FilePath As String,
          Optional ByVal Password As String = Nothing)
            Clear()
            Me.Password = Password
            Me.Target = FilePath
        End Sub
#End Region
#End Region
#Region "|8| [Class]"

#End Region
#Region "|9| [Constante]"

#End Region
#Region "|10| [Event]"

#End Region
#Region "|11| [Declare]"

#End Region
#Region "|12| [Delegate]"

#End Region
#End Region

    End Class
#End Region
#Region "|08.01| <Class> [Folder]"
    <ComVisible(True)>
    <Serializable>
    Public Class Folder
        Public Property Log As New TestItem("Folder", "")
#Region "|1| [Property]{12}"
#Region "|01.00| <Property> [Info]{5}"
#Region "|2019/04/17 14h54:922| <01.00.00> <Property> <Info> [Call=Name|String]"'(Set|Get) The Name of the object.
        Private _Name As String
        ''' <Summary>
        ''' The Name of the object.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/17 14h54:921 </Published>
        ''' <Updated>[Created=2019/04/17 14h54:913][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Info"), Description("The Name of the object."), Browsable(True)>
        Public Property Name() As String
            Get
                Return _Name
            End Get
            Set(ByVal Value As String)
                _Name = Value
            End Set
        End Property
#End Region ' (Set|Get) The Name of the object.
#Region "|2019/04/17 14h54:093| <01.00.01> <Property> <Info> [Call=FolderName|String]"'(Set|Get) The full Name of the Object.
        Private _FolderName As String
        ''' <Summary>
        ''' The full Name of the Object.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/17 14h54:093 </Published>
        ''' <Updated>[Created=2019/04/17 14h54:093][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Info"), Description("The full Name of the Object."), Browsable(True)>
        Public Property FolderName() As String
            Get
                Return _FolderName
            End Get
            Set(ByVal Value As String)
                _FolderName = Value
            End Set
        End Property
#End Region ' (Set|Get) The full Name of the Object.
#Region "|2019/04/17 14h55:975| <01.00.02> <Property> <Info> [Call=Icon|Image]"'(Set|Get) the Icon as Image.
        Private _Icon As Image
        ''' <Summary>
        ''' (Set|Get) the Icon as Image.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/17 14h55:975 </Published>
        ''' <Updated>[Created=2019/04/17 14h55:974][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Info"), Description("(Set|Get) the Icon as Image."), Browsable(True)>
        Public Property Icon() As Image
            Get
                Return _Icon
            End Get
            Set(ByVal Value As Image)
                _Icon = Value
            End Set
        End Property
#End Region ' (Set|Get) the Icon as Image.
#Region "|2019/04/17 14h59:318| <01.00.03> <Property> <Info> [Call=Path|IO.DirectoryInfo]"'(Set|Get) the Path as IO.DirectoryInfo.
        Private _Path As IO.DirectoryInfo
        ''' <Summary>
        ''' (Set|Get) the Path as IO.DirectoryInfo.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/17 14h59:318 </Published>
        ''' <Updated>[Created=2019/04/17 14h59:317][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Info"), Description("(Set|Get) the Path as IO.DirectoryInfo."), Browsable(True)>
        <XmlIgnore()>
        Public Property Path() As IO.DirectoryInfo
            Get
                Return _Path
            End Get
            Set(ByVal Value As IO.DirectoryInfo)
                _Path = Value
            End Set
        End Property
#End Region ' (Set|Get) the Path as IO.DirectoryInfo.
#Region "|2019/04/17 15h00:382| <01.00.04> <Property> <Info> [Call=Exists|Boolean]"'(Set|Get) Define if the folder exist.
        Private _Exists As Boolean
        ''' <Summary>
        ''' (Set|Get) Define if the folder exist.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/17 15h00:382 </Published>
        ''' <Updated>[Created=2019/04/17 15h00:382][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Info"), Description("(Set|Get) Define if the folder exist."), Browsable(True)>
        Public Property Exists() As Boolean
            Get
                Return _Exists
            End Get
            Set(ByVal Value As Boolean)
                _Exists = Value
            End Set
        End Property
#End Region ' (Set|Get) Define if the folder exist.
#End Region
#Region "|01.01| <Property> [Directory]{2}"
#Region "|2019/04/17 15h01:680| <01.01.00> <Property> <Directory> [Call=Fichiers|List(Of Fichier)]"'(Set|Get) the Fichiers as List(Of Fichier).
        Private _Fichiers As List(Of Fichier)
        ''' <Summary>
        ''' (Set|Get) the Fichiers as List(Of Fichier).
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/17 15h01:680 </Published>
        ''' <Updated>[Created=2019/04/17 15h01:680][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Directory"), Description("(Set|Get) the Fichiers as List(Of Fichier)."), Browsable(True)>
        Public Property Fichiers() As List(Of Fichier)
            Get
                Return _Fichiers
            End Get
            Set(ByVal Value As List(Of Fichier))
                _Fichiers = Value
            End Set
        End Property
#End Region ' (Set|Get) the Fichiers as List(Of Fichier).
#Region "|2019/04/17 15h02:160| <01.01.01> <Property> <Directory> [Call=Folders|List(Of Folder)]"'(Set|Get) the Folders as List(Of Folder)
        Private _Folders As List(Of Folder)
        ''' <Summary>
        ''' (Set|Get) the Folders as List(Of Folder)
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/17 15h02:160 </Published>
        ''' <Updated>[Created=2019/04/17 15h02:159][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Directory"), Description("(Set|Get) the Folders as List(Of Folder)"), Browsable(True)>
        Public Property Folders() As List(Of Folder)
            Get
                Return _Folders
            End Get
            Set(ByVal Value As List(Of Folder))
                _Folders = Value
            End Set
        End Property
#End Region ' (Set|Get) the Folders as List(Of Folder)
#End Region
#Region "|01.02| <Property> [Date]{3}"
#Region "|2019/04/17 15h04:291| <01.02.00> <Property> <Date> [Call=Access|DateTime]"'(Set|Get) the last Access Date as DateTime.
        Private _Access As DateTime
        ''' <Summary>
        ''' (Set|Get) the last Access Date as DateTime.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/17 15h04:291 </Published>
        ''' <Updated>[Created=2019/04/17 15h04:291][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Date"), Description("(Set|Get) the last Access Date as DateTime."), Browsable(True)>
        Public Property Access() As DateTime
            Get
                Return _Access
            End Get
            Set(ByVal Value As DateTime)
                _Access = Value
            End Set
        End Property
#End Region ' (Set|Get) the last Access Date as DateTime.
#Region "|2019/04/17 15h04:148| <01.02.01> <Property> <Date> [Call=Modified|DateTime]"'(Set|Get) the last modification Date as DateTime.
        Private _Modified As DateTime
        ''' <Summary>
        ''' (Set|Get) the last modification Date as DateTime.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/17 15h04:148 </Published>
        ''' <Updated>[Created=2019/04/17 15h04:148][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Date"), Description("(Set|Get) the last modification Date as DateTime."), Browsable(True)>
        Public Property Modified() As DateTime
            Get
                Return _Modified
            End Get
            Set(ByVal Value As DateTime)
                _Modified = Value
            End Set
        End Property
#End Region ' (Set|Get) the last modification Date as DateTime.
#Region "|2019/04/17 15h07:970| <01.02.02> <Property> <Date> [Call=Created|DateTime]"'(Set|Get) the creation Date as DateTime.
        Private _Created As DateTime
        ''' <Summary>
        ''' (Set|Get) the creation Date as DateTime.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/17 15h07:970 </Published>
        ''' <Updated>[Created=2019/04/17 15h07:970][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Date"), Description("(Set|Get) the creation Date as DateTime."), Browsable(True)>
        Public Property Created() As DateTime
            Get
                Return _Created
            End Get
            Set(ByVal Value As DateTime)
                _Created = Value
            End Set
        End Property
#End Region ' (Set|Get) the creation Date as DateTime.
#End Region
#Region "|01.03| <Property> [Localisation]{2}"
#Region "|2019/04/17 15h15:126| <01.03.00> <Property> <Localisation> [Call=Target|String]"'(Set|Get) The fullpath of the directory analysed. This is the initial caller.
        Private _Target As String
        ''' <Summary>
        ''' (Set|Get) The fullpath of the directory analysed. This is the initial caller.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/17 15h15:126 </Published>
        ''' <Updated>[Created=2019/04/17 15h15:126][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        <Editor("System.Windows.Forms.Design.SelectedPathEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", GetType(UITypeEditor))>
        <CategoryAttribute("Localisation"), Description("(Set|Get) The fullpath of the directory analysed. This is the initial caller."), Browsable(True)>
        Public Property Target() As String
            Get
                Return _Target
            End Get
            Set(ByVal Value As String)
                If Value <> "" Then
                    If IO.Directory.Exists(Value) Then
                        With Me
                            .Name = IO.Path.GetDirectoryName(Value)
                            .FolderName = IO.Path.GetFileName(Value)
                            .Path = New IO.DirectoryInfo(Value)
                            .Exists = True
                            .Fichiers = New List(Of Fichier)
                            .Folders = New List(Of Folder)
                            .Access = .Path.LastAccessTime
                            .Modified = .Path.LastWriteTime
                            .Created = .Path.CreationTime
                            ' Dim fso = CreateObject("Scripting.FileSystemObject")
                            'Dim fol = fso.GetFolder(Value)
                            'Dim m As New SizeInfo(fol.size) 'My.Computer.FileSystem.GetFileInfo(Value).Length)
                            '.FolderSize = GetFolderSize(Value)
                        End With
                    End If
                End If
                _Target = Value
            End Set
        End Property
#End Region ' (Set|Get) The fullpath of the directory analysed. This is the initial caller.
#Region "|2019/04/17 16h15:934| <01.03.01> <Property> <Localisation> [Call=FolderSize|SizeInfo]"'(Set|Get) the Size as SizeInfo.
        Private _FolderSize As SizeInfo
        ''' <Summary>
        ''' (Set|Get) the FolderSize as SizeInfo.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/17 16h15:934 </Published>
        ''' <Updated>[Created=2019/04/17 16h15:933][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Localisation"),
Description("(Set|Get) the FolderSize as SizeInfo."),
Browsable(True)>
        Public Property FolderSize() As SizeInfo
            Get
                Return _FolderSize
            End Get
            Set(ByVal Value As SizeInfo)
                _FolderSize = Value
            End Set
        End Property
#End Region ' (Set|Get) the FolderSize as SizeInfo.
#End Region
#End Region
#Region "|2| [Enumeration]"

#End Region
#Region "|3| [Structures]"
        Public Structure S_Indexed
            Public List_file As List(Of FileSystemInfo)
            Public List_Fichiers As List(Of Fichier)
            ' Public List_Compta As List(Of Ask.Client.DisplayCompta)
            Public List_Hybrids As List(Of FileHybrid)
            Public List_Folders As List(Of Folder)
            Public List_Image As List(Of Bitmap)
            Public List As List(Of String)
            Public Binding As BindingSource
            Public Size As SizeInfo
        End Structure
#End Region
#Region "|4| [Sub]"

#End Region
#Region "|5| [Function]"
#Region "|05.00| <Function> [Enumerate]{5}"
#Region "|05.00.00| <Function> <Enumerate> [EnumerateFolder([SearchExpression]|String(*),[SearchOption]|IO.SearchOption(IO.SearchOption.TopDirectoryOnly)|List(Of Folder)]"
        Public Function EnumerateFolder(Optional ByVal SearchExpression As String = "*",
                                        Optional ByVal SearchOption As IO.SearchOption = IO.SearchOption.TopDirectoryOnly) As List(Of Folder)
            Me.Folders = New List(Of Folder)
            Dim Stack As New Stack(Of String)
            If IO.Directory.Exists(Me.Target) Then
                Do
                    Try
                        Dim Element = From d In IO.Directory.EnumerateDirectories(Me.Target, SearchExpression, SearchOption)
                                      Select d
                        Array.ForEach(Element.ToArray, Sub(d)
                                                           If IO.File.Exists(d) Then
                                                           Else

                                                               If IO.Directory.Exists(d) Then

                                                                   Dim Fol As New Folder(d)
                                                                   Me.Folders.Add(Fol)
                                                               End If
                                                           End If
                                                       End Sub)

                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Loop Until (Stack.Count = 0)
            End If
            Return Me.Folders
        End Function

#End Region
#Region "|05.00.01| <Function> <Enumerate> [EnumerateFichier([SearchExpression]|String(*.*),[SearchOption]|IO.SearchOption(IO.SearchOption.TopDirectoryOnly)|List(Of Fichier)]"
        Public Function EnumerateFichier(Optional ByVal SearchExpression As String = "*.*",
                                        Optional ByVal SearchOption As IO.SearchOption = IO.SearchOption.TopDirectoryOnly) As List(Of Fichier)
            Me.Fichiers = New List(Of Fichier)
            Dim Stack As New Stack(Of String)
            If IO.Directory.Exists(Me.Target) Then
                Do
                    Try
                        Dim Element = From d In IO.Directory.EnumerateFiles(Me.Target, SearchExpression, SearchOption)
                                      Select d
                        Array.ForEach(Element.ToArray, Sub(d)
                                                           Dim Fol As New Fichier(d)
                                                           Me.Fichiers.Add(Fol)
                                                       End Sub)

                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Loop Until (Stack.Count = 0)
            End If
            Return Me.Fichiers
        End Function

#End Region
#Region "|05.00.02| <Function> <Enumerate> [EnumerateAll([SearchExpression]|String,[SearchOption]|IO.SearchOption(IO.SearchOption.TopDirectoryOnly)|List(Of Fichier)]"
        Public Function EnumerateAll(Optional ByVal SearchExpression As String = "*.*",
                                        Optional ByVal SearchOption As IO.SearchOption = IO.SearchOption.TopDirectoryOnly) As List(Of Fichier)
            Me.Fichiers = New List(Of Fichier)
            Dim Stack As New Stack(Of String)
            If IO.Directory.Exists(Me.Target) Then
                Do
                    Try
                        Dim Element = From d In IO.Directory.EnumerateFileSystemEntries(Me.Target, SearchExpression, SearchOption)
                                      Select d
                        Array.ForEach(Element.ToArray, Sub(d)
                                                           If IO.File.Exists(d) Then
                                                               Dim Fol As New Fichier(d)
                                                               Me.Fichiers.Add(Fol)
                                                           Else
                                                               If IO.Directory.Exists(d) Then
                                                                   Dim Fol As New Folder(d)
                                                                   Me.Folders.Add(Fol)
                                                               End If
                                                           End If

                                                       End Sub)

                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Loop Until (Stack.Count = 0)
            End If
            Return Me.Fichiers
        End Function

#End Region
#Region "|05.00.03| <Function> <Enumerate> [EnumerateDirectories([SearchExpression]|String(*),[SearchOption]|IO.SearchOption(IO.SearchOption.TopDirectoryOnly)|List(Of IO.DirectoryInfo)]"
        Public Function EnumerateDirectories(Optional ByVal SearchExpression As String = "*",
                                        Optional ByVal SearchOption As IO.SearchOption = IO.SearchOption.TopDirectoryOnly) As List(Of IO.DirectoryInfo)
            Dim Result As New List(Of IO.DirectoryInfo)
            Dim Stack As New Stack(Of String)
            If IO.Directory.Exists(Me.Target) Then
                Do
                    Try
                        Dim Element = From d In IO.Directory.EnumerateFileSystemEntries(Me.Target, SearchExpression, SearchOption)
                                      Select d
                        Array.ForEach(Element.ToArray, Sub(d)
                                                           If IO.Directory.Exists(d) Then
                                                               Dim Fol As New IO.DirectoryInfo(d)
                                                               Result.Add(Fol)
                                                           End If
                                                       End Sub)

                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Loop Until (Stack.Count = 0)
            End If
            Return Result
        End Function
#End Region
#Region "|05.00.04| <Function> <Enumerate> [EnumerateDirectories([SearchExpression]|String(*),[SearchOption]|IO.SearchOption(IO.SearchOption.TopDirectoryOnly)|List(Of IO.FileInfo)]"
        Public Function EnumerateFiles(Optional ByVal SearchExpression As String = "*.*",
                                        Optional ByVal SearchOption As IO.SearchOption = IO.SearchOption.TopDirectoryOnly) As List(Of IO.FileInfo)
            Dim Result As New List(Of IO.FileInfo)
            Dim Stack As New Stack(Of String)
            If IO.Directory.Exists(Me.Target) Then
                Do
                    Try
                        Dim Element = From d In IO.Directory.EnumerateFileSystemEntries(Me.Target, SearchExpression, SearchOption)
                                      Select d
                        Array.ForEach(Element.ToArray, Sub(d)
                                                           If IO.File.Exists(d) Then
                                                               Dim Fol As New IO.FileInfo(d)
                                                               Result.Add(Fol)
                                                           End If
                                                       End Sub)

                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Loop Until (Stack.Count = 0)
            End If
            Return Result
        End Function
#End Region
#End Region
#Region "|05.01| <Function> [Get]{6}"
#Region "|05.01.00| <Function> <Get> [GetFoldersize()|TestItem]"
        Public Property TF_GetFolderSize As TestItem
        '''<summary> 
        '''(Set|Get) Size of the Folder
        '''<Author>Saadry Dunkel Consultant</Author>
        '''</summary>
        '''<param name="FilePath"></param>
        '''<returns>SizeInfo</returns>
        Public Function GetFolderSize(ByVal FilePath As String) As SizeInfo
            TF_GetFolderSize = New TestItem("GetFolderSize", "<Functions> <04.02.00> <Functions> <Get> [GetSizeInfo (Byval FilePath As String)  | SizeInfo]", Status.Running)
            Dim Result As New SizeInfo
            Dim PFilePath As New Input_Parameters("FilePath", FilePath, FilePath.ToString)
            TF_GetFolderSize.InputParams.Add(PFilePath)


            Dim TestExist As New TestItem("FilePath is Nothing", "Test si le répertoire est compatible", Status.Running)
            If IsNothing(FilePath) Then
                TestExist.Why += "Echec le répertoire est incompatible." & vbNewLine
                TestExist.Status = Status.Offline
                TF_GetFolderSize.Add(TestExist)
                Log.Add(TF_GetFolderSize)
                Return Result
            Else

                If IO.Directory.Exists(FilePath) Then
                    TestExist.Why += "Succès le répertoire est compatible." & vbNewLine
                    TestExist.Status = Status.Online
                    TF_GetFolderSize.Add(TestExist)
                    Try
                        Dim fso = CreateObject("Scripting.FileSystemObject")
                        Dim fol = fso.GetFolder(FilePath)
                        Result = New SizeInfo(fol.Size)
                        TF_GetFolderSize.Why += "      <Size> " & Result.Display & " </Size>" & vbNewLine
                        TF_GetFolderSize.Status = Status.Online
                    Catch ex As Exception
                        TF_GetFolderSize.Why += Format_Error(ex, "TestSize") & vbNewLine
                        TF_GetFolderSize.Status = Status.Offline
                        Log.AddBug(ex, "GetFolderSize", "GetFolderSize")
                        TF_GetFolderSize.AddBug(ex, "GetFolderSize", "GetFolderSize")
                    End Try
                    If TF_GetFolderSize.Status = Status.Offline Then
                        Dim m As New DirectoryInfo(FilePath)
                        If m.Exists() Then
                            Result = New SizeInfo(CalculateDirSize(m, SizeInfo.Scales.Gigabyte).Value)
                        End If
                    End If
                Else
                    TestExist.Why += "Echec le répertoire est incompatible." & vbNewLine
                    TestExist.Status = Status.Offline
                    TF_GetFolderSize.Add(TestExist)
                    Dim iDrive As New IO.DriveInfo(FilePath)
                    If iDrive.IsReady Then
                        Try
                            Result = New SizeInfo(iDrive.TotalSize)
                            TF_GetFolderSize.Why += "      <Size> " & Result.Display & " </Size>" & vbNewLine
                            TF_GetFolderSize.Status = Status.Online
                        Catch ex As Exception
                            TF_GetFolderSize.Why += Format_Error(ex, "TestSize") & vbNewLine
                            TF_GetFolderSize.Status = Status.Offline
                            Log.AddBug(ex, "GetFolderSize", "GetFolderSize")
                            TF_GetFolderSize.AddBug(ex, "GetFolderSize", "GetFolderSize")
                            Result = New SizeInfo(0)
                        End Try
                        If TF_GetFolderSize.Status = Status.Offline Then
                            Dim m As New DirectoryInfo(FilePath)
                            If m.Exists() Then
                                Result = New SizeInfo(CalculateDirSize(m, SizeInfo.Scales.Gigabyte).Value)
                            End If
                        End If
                    End If
                End If
            End If
            Log.Add(TF_GetFolderSize)
            Return Result
        End Function
#End Region
#Region "|05.01.01| <Function> <Get> [GetFolders([SearchExpression]|String(*),[SearchOption]|IO.SearchOption(IO.SearchOption.TopDirectoryOnly)|List(Of Folder)]"
        Public Function GetFolders(Optional ByVal SearchExpression As String = "*",
                                   Optional ByVal SearchOption As IO.SearchOption = IO.SearchOption.TopDirectoryOnly) As List(Of Folder)
            Me.Folders = New List(Of Folder)
            Dim Stack As New Stack(Of String)
            Do
                Try
                    Dim Element = From d In IO.Directory.GetDirectories(Me.Target, SearchExpression, SearchOption)
                                  Select d
                    Array.ForEach(Element.ToArray(), Sub(d)
                                                         Dim Fol As New Folder(d)
                                                         Me.Folders.Add(Fol)
                                                     End Sub)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Loop Until (Stack.Count = 0)
            Return Me.Folders
        End Function
#End Region
#Region "|05.01.02| <Function> <Get> [GetFichiers([SearchExpression]|String(*.*),[SearchOption]|IO.SearchOption(IO.SearchOption.TopDirectoryOnly)|List(Of Fichier)]"
        Public Function GetFichiers(Optional ByVal SearchExpression As String = "*.*",
                                   Optional ByVal SearchOption As IO.SearchOption = IO.SearchOption.TopDirectoryOnly) As List(Of Fichier)
            Me.Fichiers = New List(Of Fichier)
            Dim Stack As New Stack(Of String)
            Do
                Try
                    Dim Element = From d In IO.Directory.GetFiles(Me.Target, SearchExpression, SearchOption)
                                  Select d
                    Array.ForEach(Element.ToArray(), Sub(d)
                                                         Dim Fol As New Fichier(d)
                                                         Me.Fichiers.Add(Fol)
                                                     End Sub)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Loop Until (Stack.Count = 0)
            Return Me.Fichiers
        End Function
#End Region
#Region "|05.01.03| <Function> <Get> [GetFileSystems([SearchExpression]|String(*.*),[SearchOption]|IO.SearchOption(IO.SearchOption.TopDirectoryOnly)|List(Of FileHybrid)]"
        Public Function GetFileSystemEntries(Optional ByVal SearchExpression As String = "*.*",
                                   Optional ByVal SearchOption As IO.SearchOption = IO.SearchOption.TopDirectoryOnly) As List(Of FileHybrid)
            Dim Result As New List(Of FileHybrid)
            Dim Stack As New Stack(Of String)
            Do
                Try
                    Dim Element = From d In IO.Directory.GetFileSystemEntries(Me.Target, SearchExpression, SearchOption)
                                  Select d
                    Array.ForEach(Element.ToArray(), Sub(d)
                                                         Dim F As New FileHybrid
                                                         With F
                                                             If IO.File.Exists(d) Then
                                                                 .File = New Fichier(d)
                                                                 .IsFile = True
                                                                 .IsFolder = False
                                                                 .Target = d
                                                             Else
                                                                 If IO.Directory.Exists(d) Then
                                                                     .Folder = New Folder(d)
                                                                     .IsFile = False
                                                                     .IsFolder = True
                                                                     .Target = d
                                                                 End If
                                                             End If
                                                         End With
                                                         Result.Add(F)


                                                     End Sub)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Loop Until (Stack.Count = 0)
            Return Result
        End Function
#End Region
#Region "|05.01.04| <Function> <Get> [GetFolders([SearchExpression]|String(*),[SearchOption]|IO.SearchOption(IO.SearchOption.TopDirectoryOnly)|List(Of Folder)]"
        Public Function GetDirectories(Optional ByVal SearchExpression As String = "*",
                                   Optional ByVal SearchOption As IO.SearchOption = IO.SearchOption.TopDirectoryOnly) As List(Of IO.DirectoryInfo)
            Dim Result As New List(Of IO.DirectoryInfo)
            Dim Stack As New Stack(Of String)
            Do
                Try
                    Dim Element = From d In IO.Directory.GetDirectories(Me.Target, SearchExpression, SearchOption)
                                  Select d
                    Array.ForEach(Element.ToArray(), Sub(d)
                                                         If IO.Directory.Exists(d) Then
                                                             Dim Fol As New IO.DirectoryInfo(d)
                                                             Result.Add(Fol)
                                                         End If
                                                     End Sub)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Loop Until (Stack.Count = 0)
            Return Result
        End Function
#End Region
#Region "|05.01.05| <Function> <Get> [GetFiles([SeachExpression]|String(*.*),[SearchOption]|IO.SearchOption(IO.SearchOption.TopDirectoryOnly)|List(Of IO.FileInfo)]"
        Public Function GetFiles(Optional ByVal SearchExpression As String = "*.*",
                                 Optional ByVal SearchOption As IO.SearchOption = IO.SearchOption.TopDirectoryOnly) As List(Of IO.FileInfo)
            Dim Result As New List(Of IO.FileInfo)
            Dim Stack As New Stack(Of String)
            Do
                Try
                    Dim Element = From d In IO.Directory.GetFiles(Me.Target, SearchExpression, SearchOption)
                                  Select d
                    Array.ForEach(Element.ToArray(), Sub(d)
                                                         '  Stack.Push(d)
                                                         Dim Fol As New IO.FileInfo(d)
                                                         Result.Add(Fol)
                                                     End Sub)

                Catch ex As Exception
                    Log.AddBug(ex, "GetFile", "GetFile")
                    MsgBox(ex.Message)
                End Try
            Loop Until (Stack.Count = 0)



            Return Result
        End Function

#End Region
#End Region
#Region "|05.02| <Function> [Share]{6}"
#Region "|05.02.00| <Function> <Share> [Share(ShareName|String),[Secret]|Boolean(False)]|TestItem]"
        Public Property TF_Share As TestItem

        Public Function Share(ByVal ShareName As String,
                    Optional ByVal Secret As Boolean = False) As TestItem
            TF_Share = New TestItem("[ShareFolder=" & ShareName & "]",
                                   "Partager le répertoire", Status.Running)
            Dim PSharedName As New Input_Parameters("SharedName", ShareName, ShareName.ToString)
            Dim PSecret As New Input_Parameters("Secret", Secret, Secret.ToString)
            TF_Share.InputParams = New List(Of Input_Parameters)
            TF_Share.InputParams.Add(PSharedName)
            TF_Share.InputParams.Add(PSecret)
            ' TF_Share.Add(PSharedName.Log)
            ' TF_Share.Add(PSecret.Log)
            TF_Share.Input = Me

#Region "<Exceptions>"
            If Me.Exists = False Then
                TF_Share.Write("Le répertoire n'existe pas")
                TF_Share.Status = Status.Broken
                TF_Share.Why = "Le répertoire n'existe pas " & Target & Environment.NewLine
            End If
            If ShareName = String.Empty Then
                TF_Share.Write("Le nom paratagé est vide")
                TF_Share.Status = Status.Broken
                TF_Share.Why = "Le nom paratagé est vide [SharedName] " & ShareName & Environment.NewLine
            End If
#End Region
            If TF_Share.Status <> Status.Broken Then
                Dim TManamgementClass As New TestItem("ManagementClass[Win32_share]", "Analyse du répertoire")
#Region "<Action>"
                Try
                    Dim ManagementClass As New ManagementClass("win32_share")
                    TManamgementClass.Input = ManagementClass
                    Dim Parametres As ManagementBaseObject = ManagementClass.GetMethodParameters("Create")
                    Parametres("Description") = ""
                    Parametres("Name") = ShareName
                    Parametres("Path") = If(Secret = False, Target, Target & "$")
                    Parametres("Type") = &H0
                    Dim PParameters As New Input_Parameters("Parametres", Parametres.ToString, Parametres.ToString)
                    Dim SP1 As New Input_Parameters("Parametres(Name)", Parametres("Name"), ShareName)
                    Dim SP2 As New Input_Parameters("Parametres(Path)", Parametres("Path"), If(Secret = False, Target, Target & "$"))
                    Dim SP3 As New Input_Parameters("Parametres(Type)", Parametres("Type"), &H0)
                    Dim Out_Params As ManagementBaseObject = ManagementClass.InvokeMethod("Create", Parametres, Nothing)
                    '   Dim OP1 As New Input_Parameters("Out_Params", Out_Params, ManagementClass.InvokeMethod("Create", Parametres, Nothing))
                    TManamgementClass.InputParams = New List(Of Input_Parameters)
                    TManamgementClass.InputParams.Add(PParameters)
                    TManamgementClass.InputParams.Add(SP1)
                    TManamgementClass.InputParams.Add(SP2)
                    TManamgementClass.InputParams.Add(SP3)
                    ' TManamgementClass.InputParams.Add(OP1)
                    ' TManamgementClass.Add(PParameters.Log)
                    ' TManamgementClass.Add(SP1.Log)
                    ' TManamgementClass.Add(SP2.Log)
                    ' TManamgementClass.Add(SP3.Log)
                    ' TManamgementClass.Add(OP1.Log)

                    TF_Share.Add(TManamgementClass)

                    If Convert.ToUInt32(Out_Params.Properties("ReturnValue").Value) <> 0 Then
                        TF_Share.Write("le partage a échouer [Condition] Convert.ToUInt32(Out_Params.Properties(''ReturnValue'').Value) <> 0 [/Condition]")
                        TF_Share.Status = Status.Broken
                    Else
                        TF_Share.Write("<Warning> le partage a réussi")
                        TF_Share.Status = Status.Online
                        TF_Share.AddHypothesis("le partage a réussi", Status.Online, True)
                    End If
                Catch ex As Exception
                    TF_Share.Why += Format_Error(ex, "TF_Share")
                    TF_Share.Status = Status.Broken
                    Log.AddBug(ex, "TF_Share", "TF_Share")
                End Try
#End Region
            End If

#Region "<End Result>"
            With TF_Share
                If TF_Share.Status = Status.Running Then
                    TF_Share.Status = Status.Finished
                End If
            End With
#End Region
            Log.Add(TF_Share)
            Return TF_Share
        End Function
#End Region

#End Region
#Region "|05.03| <Function> [FolderManagement]"
#Region "|05.03.00| <Function> <FolderManagement> [Create]{}"
#Region "|05.03.00.00| <Function> <FolderManagement> <Create> [Create()|Status]"
        ''' <summary>
        ''' Create the directory.
        ''' </summary>
        ''' <returns></returns>
        Public Function Create() As Status
            If Me.Exists = False Then
                If Me.Target <> "" Then
                    Try
                        IO.Directory.CreateDirectory(Me.Target)
                        Return Status.Finished
                    Catch ex As Exception
                        Return Status.Broken
                    End Try
                Else
                    Return Status.Broken
                End If
            Else
                Return Status.Broken
            End If
        End Function
#End Region
#Region "|05.03.00.01| <Function> <FolderManagement> <Create> [Create(FolderPath|String)|Status]"
        ''' <summary>
        ''' Create a directory at given address.
        ''' </summary>
        ''' <returns></returns>
        Public Function Create(ByVal FolderPath As String) As Status
            If IO.Directory.Exists(FolderPath) = False Then
                If FolderPath <> "" Then
                    Try
                        IO.Directory.CreateDirectory(FolderPath)
                        Return Status.Finished
                    Catch ex As Exception
                        Return Status.Broken
                    End Try
                Else
                    Return Status.Broken
                End If
            Else
                Return Status.Broken
            End If
        End Function
#End Region
#Region "|05.03.00.02| <Function> <FolderManagement> <Create> [Create(FolderPath|String,FolderName|String)|Status]"
        ''' <summary>
        ''' Create a directory at given address with a given name
        ''' </summary>
        ''' <returns></returns>
        Public Function Create(ByVal FolderPath As String, ByVal FolderName As String) As Status
            If IO.Directory.Exists(FolderPath & "\" & FolderName) = False Then
                If FolderPath <> "" And FolderName <> "" Then
                    Try
                        IO.Directory.CreateDirectory(FolderPath & "\" & FolderName)
                        Return Status.Finished
                    Catch ex As Exception
                        Return Status.Broken
                    End Try
                Else
                    Return Status.Broken
                End If
            Else
                Return Status.Broken
            End If
        End Function
#End Region
#End Region
#End Region
#Region "|05.04| <Function> [SearchAll([SearchExpression]|String(*.*),[SearchOption]|IO.SearchOption(IO.SearchOption.TopDirectoryOnly)|Status]"
        Public Function Searchall(Optional ByVal SearchExpression As String = "*.*",
                                         Optional ByVal SearchOption As SearchOption = SearchOption.TopDirectoryOnly) As S_Indexed


            'Dim Result As List(Of String) = New List(Of String)
            Dim Result As New S_Indexed
            Result.List_Fichiers = New List(Of Fichier)
            Result.List_Folders = New List(Of Folder)
            Result.List_Image = New List(Of Bitmap)
            Result.List_Hybrids = New List(Of FileHybrid)
            Dim TempSize As Integer = 0
            Result.List = New List(Of String)
            Dim Start As String = Target
            Result.List.Add(Start)
            Dim Stack As Stack(Of String) = New Stack(Of String)
            Do
                Try
                    Debug.WriteLine(Start)
                    Dim dirs = From d In Directory.EnumerateFileSystemEntries(Start, SearchExpression, SearchOption)
                               Select d
                    'Multline Lambda - Strange
                    Array.ForEach(dirs.ToArray(), Sub(d)
                                                      Stack.Push(d)
                                                      Dim M As Bitmap = Retrieve_Icons.GetShellIcon(d)
                                                      Dim FH As New FileHybrid
                                                      If IO.File.Exists(d) = True Then
                                                          Dim F As New Fichier(d)
                                                          Result.List_Fichiers.Add(F)
                                                          With FH
                                                              .File = F
                                                              .Target = d
                                                              .Icon = M
                                                              .IsFile = True
                                                              .NodeX = New DevComponents.AdvTree.Node(F.Name)
                                                              .NodeX.Image = M
                                                              .NodeX.Tag = FH
                                                          End With
                                                          TempSize += F.FileSize.Raw
                                                      Else
                                                          Dim B As New Folder(d)
                                                          With FH
                                                              .Folder = B
                                                              .Target = d
                                                              .Icon = M
                                                              .IsFolder = True
                                                              .NodeX = New DevComponents.AdvTree.Node(B.Name)
                                                              .NodeX.Image = M
                                                              .NodeX.Tag = FH
                                                          End With
                                                          Result.List_Folders.Add(B)
                                                      End If
                                                      Result.List_Hybrids.Add(FH)
                                                      Result.List_Image.Add(M)
                                                  End Sub)
                    Start = Stack.Pop
                    Result.List.Add(Start)
                Catch ex As UnauthorizedAccessException
                    Console.WriteLine(ex.Message)
                    Start = Stack.Pop()
                    Result.List.Add(Start)
                End Try
            Loop Until (Stack.Count = 0)
            For Each d In Result.List
                Console.WriteLine(d)
            Next
            Console.ReadLine()
            Result.Binding = New BindingSource
            Result.Binding.DataSource = Result.List
            Result.Size = New SizeInfo(TempSize)
            'Me.folders = SizeInfo.Convert_Size(TempSize)
            Return Result
        End Function
#End Region
#Region "|05.05| <Function> [ListViewItem]"
#Region "|05.05.00| <Function> <ListViewItem> [Convert_ToListViewItem()|ListviewItem]"
        Public Function Convert_ToListViewItem() As ListViewItem
            Dim Result As New ListViewItem(IO.Path.GetFileNameWithoutExtension(Me.FolderName))
            Result.SubItems.Add(PrintTime(Me.Modified))
            Result.SubItems.Add("Folder")
            Result.SubItems.Add(Me.FolderSize.Value)
            Result.SubItems.Add(Me.Target)
            Result.Tag = Me

            Return Result
        End Function
#End Region
#End Region
#End Region

#Region "|6| [Runtime]"

#End Region
#Region "|7| [Loader]"
        Public Sub New()
            With Me
                .Access = Nothing
                .Created = Nothing
                .Exists = False
                .Fichiers = New List(Of Fichier)
                .FolderSize = Nothing
                .Folders = New List(Of Folder)
                .Icon = Nothing
                .Modified = Nothing
                .Name = Nothing
                .Path = Nothing
                .Target = Nothing
            End With
        End Sub
        Public Sub New(ByVal FolderPath As String)
            If IO.Directory.Exists(FolderPath) Then
                Me.Target = FolderPath
            End If
        End Sub
#End Region
#Region "|8| [Class]"

#End Region
    End Class 'Folder
#End Region
#Region "|08.02| <Class> [SizeInfo]"
    '''<summary> 
    '''(Set|Get) Information about the Size
    '''<Author>Saadry Dunkel Consultant</Author>
    '''   ''' <Production Price>123 CHF</Production>
    ''' <Quantity> 09    Properties  @9 =   45
    '''            01    Enumeration @10 =  10
    '''            02    Functions   @12 =  24
    '''            02    Loader      @10 =  20
    '''            03    Parameters  @2  =   6
    '''            05    Members     @1  =   5
    '''            05    Constantes  @3  =  15
    '''  Total :   27                    = 123.-
    ''' </Quantity>
    '''</summary>
    <CategoryAttribute("Size"),
    Description("(Set|Get) Information about the Size"),
    Browsable(True),
     RefreshProperties(RefreshProperties.All)>
    <Serializable>
    Public Class SizeInfo
#Region "|1| [Property]{5}"
#Region "|01.00| <Property> [Input]"
#Region "|2019/04/16 14h07:578| <01.00.00> <Property> <Input> [Call=Raw|ULong]"'(Set|Get) Required. Original Value in bits.
        Private _Raw As ULong
        ''' <Summary>
        ''' Required. Original Value in bits.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/16 14h07:577 </Published>
        ''' <Updated>[Created=2019/04/16 14h07:571][Status=Working][Tested On]11/06/2019 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Input"),
Description("Required. Original Value in bits."),
Browsable(True)>
        Public Property Raw() As ULong
            Get
                Return _Raw
            End Get
            Set(ByVal Value As ULong)
                _Raw = Value
            End Set
        End Property
#End Region ' (Set|Get) Required. Original Value in bits.
#End Region
#Region "|01.01| <Property> [Output]"
#Region "|2019/04/16 14h08:765| <01.01.00> <Property> <Output> [Call=Display|String]"'(Set|Get) the Display as String
        Private _Display As String
        ''' <Summary>
        ''' (Set|Get) the Display as String
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/16 14h08:765 </Published>
        ''' <Updated>[Created=2019/04/16 14h08:765][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Output"),
Description("(Set|Get) the Display as String"),
Browsable(True)>
        Public Property Display() As String
            Get
                Return _Display
            End Get
            Set(ByVal Value As String)
                _Display = Value
            End Set
        End Property
#End Region ' (Set|Get) the Display as String
#Region "|2019/04/16 14h09:449| <01.01.01> <Property> <Output> [Call=ScaleString|String]"'(Set|Get) the Display as String
        Private _ScaleString As String
        ''' <Summary>
        ''' (Set|Get) the Display as String
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/16 14h09:449 </Published>
        ''' <Updated>[Created=2019/04/16 14h09:449][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Output"),
Description("(Set|Get) the Display as String"),
Browsable(True)>
        Public Property ScaleString() As String
            Get
                Return _ScaleString
            End Get
            Set(ByVal Value As String)
                _ScaleString = Value
            End Set
        End Property
#End Region ' (Set|Get) the Display as String
#Region "|2019/04/16 14h10:994| <01.01.02> <Property> <Output> [Call=ValueString|String]"'(Set|Get) The ValueString of the String.
        Private _ValueString As String
        ''' <Summary>
        ''' (Set|Get) The ValueString of the String.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/16 14h10:994 </Published>
        ''' <Updated>[Created=2019/04/16 14h10:994][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Output"),
Description("(Set|Get) The ValueString of the Size."),
Browsable(True)>
        Public Property ValueString() As String
            Get
                Return _ValueString
            End Get
            Set(ByVal Value As String)
                _ValueString = Value
            End Set
        End Property
#End Region ' (Set|Get) The ValueString of the String.
#Region "|2019/04/16 14h19:526| <01.01.03> <Property> <Output> [Call=Scale|Scales]"'(Set|Get) the Scale as Scales.
        Private _Scale As Scales
        ''' <Summary>
        ''' (Set|Get) the Scale as Scales.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/16 14h19:526 </Published>
        ''' <Updated>[Created=2019/04/16 14h19:526][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Output"),
Description("(Set|Get) the Scale as Scales."),
Browsable(True)>
        Public Property Scale() As Scales
            Get
                Return _Scale
            End Get
            Set(ByVal Value As Scales)
                _Scale = Value
            End Set
        End Property
#End Region ' (Set|Get) the Scale as Scales.
#Region "|2019/04/16 14h10:994| <01.01.02> <Property> <Output> [Call=Value|Double]"'(Set|Get) The Value of the Double.
        Private _Value As Double
        ''' <Summary>
        ''' (Set|Get) The Value of the Double.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/16 14h10:994 </Published>
        ''' <Updated>[Created=2019/04/16 14h10:994][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Output"),
Description("(Set|Get) The Value of the Double."),
Browsable(True)>
        Public Property Value() As Double
            Get
                Return _Value
            End Get
            Set(ByVal Value As Double)
                _Value = Value
            End Set
        End Property
#End Region ' (Set|Get) The Value of the Double.

#End Region
#End Region
#Region "|2| [Enumeration]"
#Region "|2019/04/16 14h15:209| <02.00.00> <Enumeration> <Scales> [Call=Scales|Enumeration]{5}"'The enumeration of Scales.
        ''' <Summary>
        ''' (Set|Get) The enumeration of Scales.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/16 14h15:209 </Published>
        ''' <Updated>[Created=2019/04/16 14h15:209][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        Public Enum Scales

            ''' <summary>Range : x={0:1023} </summary>
            Bytes = 0
            ''' <summary>Range : x={1'024 : 1'048'575} </summary>
            Kilobyte = 1
            ''' <summary>Range : x={1'048'576 : 1'073'741'823} </summary>
            Megabyte = 2
            ''' <summary>Range : x={1'073'741'824 : 1'099'511'627'775} </summary>
            Gigabyte = 3
            ''' <summary>Range : x={1'099'511'627'776 : infinity}  </summary>
            Terabyte = 4
        End Enum
#End Region ' The enumeration of Scales.
#End Region
#Region "|5| [Function]"
#Region "|2019/04/16 22h43:604| <05.00> <Function> [Call=Convert_Size|SizeInfo]"'Calculate the value and Returns Formated Variables
        ''' <Summary>
        ''' (Set|Get) Calculate the value and Returns Formated Variables
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/04/16 22h43:604 </Published>
        ''' <Updated>[Created=2019/04/16 22h43:604][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Function"),
Description("Calculate the value and Returns Formated Variables"),
Browsable(True)>
        Function Convert_Size(ByVal Value As ULong, Optional ByVal Format As Scales = Scales.Megabyte) As SizeInfo
            Dim Result As New SizeInfo
            Result.Raw = Value
            Dim DoublesBytes As Double = -1
            Select Case Value
                Case Is >= Tera_Scale
                    Result.ScaleString = " To"
                    Result.Scale = Scales.Terabyte
                    DoublesBytes = CDbl(Value / Tera_Scale)
                    Result.ValueString = FormatNumber(DoublesBytes, 2)
                    Result.Value = Double.Parse(Math.Round(DoublesBytes, 2))
                    Result.Display = Result.Value & Result.ScaleString
                Case Giga_Scale To Tera_Scale - 1
                    Result.ScaleString = " Go"
                    Result.Scale = Scales.Gigabyte
                    DoublesBytes = CDbl(Value / Giga_Scale)
                    Result.ValueString = FormatNumber(DoublesBytes, 2)
                    Result.Value = Double.Parse(Math.Round(DoublesBytes, 2))
                    Result.Display = Result.Value & Result.ScaleString
                Case Mega_Scale To Giga_Scale - 1
                    Result.ScaleString = " Mo"
                    Result.Scale = Scales.Megabyte
                    DoublesBytes = CDbl(Value / Mega_Scale)
                    Result.ValueString = FormatNumber(DoublesBytes, 2)
                    Result.Value = Double.Parse(Math.Round(DoublesBytes, 2))
                    Result.Display = Result.Value & Result.ScaleString
                Case Kilo_Scale To Mega_Scale - 1
                    Result.ScaleString = " Ko"
                    Result.Scale = Scales.Kilobyte
                    DoublesBytes = CDbl(Value / Kilo_Scale)
                    Result.ValueString = FormatNumber(DoublesBytes, 2)
                    Result.Value = Double.Parse(Math.Round(DoublesBytes, 2))
                    Result.Display = Result.Value & Result.ScaleString
                Case Octa_Scale To Kilo_Scale - 1
                    Result.ScaleString = " O"
                    Result.Scale = Scales.Bytes
                    DoublesBytes = Value
                    Result.ValueString = FormatNumber(DoublesBytes, 2)
                    Result.Value = Double.Parse(Math.Round(DoublesBytes, 2))
                    Result.Display = Result.Value & Result.ScaleString
            End Select
            If Not IsNothing(Format) Then
                If Format = Scales.Bytes Then
                    Result.ScaleString = " O"
                    Result.Scale = Scales.Bytes
                    DoublesBytes = Value
                    Result.ValueString = FormatNumber(DoublesBytes, 2)
                    Result.Value = Double.Parse(Math.Round(DoublesBytes, 2))
                    Result.Display = Result.Value & Result.ScaleString
                ElseIf format = Scales.Kilobyte Then
                    Result.ScaleString = " Ko"
                    Result.Scale = Scales.Kilobyte
                    DoublesBytes = CDbl(Value / Kilo_Scale)
                    Result.ValueString = FormatNumber(DoublesBytes, 2)
                    Result.Value = Double.Parse(Math.Round(DoublesBytes, 2))
                    Result.Display = Result.Value & Result.ScaleString
                ElseIf Format = Scales.Megabyte Then
                    Result.ScaleString = " Mo"
                    Result.Scale = Scales.Megabyte
                    DoublesBytes = CDbl(Value / Mega_Scale)
                    Result.ValueString = FormatNumber(DoublesBytes, 2)
                    Result.Value = Double.Parse(Math.Round(DoublesBytes, 2))
                    Result.Display = Result.Value & Result.ScaleString
                ElseIf Format = Scales.Gigabyte Then
                    Result.ScaleString = " Go"
                    Result.Scale = Scales.Gigabyte
                    DoublesBytes = CDbl(Value / Giga_Scale)
                    Result.ValueString = FormatNumber(DoublesBytes, 2)
                    Result.Value = Double.Parse(Math.Round(DoublesBytes, 2))
                    Result.Display = Result.Value & Result.ScaleString
                ElseIf Format = Scales.Terabyte Then
                    Result.ScaleString = " To"
                    Result.Scale = Scales.Terabyte
                    DoublesBytes = CDbl(Value / Tera_Scale)
                    Result.ValueString = FormatNumber(DoublesBytes, 2)
                    Result.Value = Double.Parse(Math.Round(DoublesBytes, 2))
                    Result.Display = Result.Value & Result.ScaleString
                End If
            End If
            Return Result
        End Function
#End Region ' Calculate the value and Returns Formated Variables
        Public Overrides Function ToString() As String
            Return Me.Display
        End Function
#End Region
#Region "|7| [Loader]"
#Region "|07.00| <Loader> [Empty]"
        Public Sub New()
            With Me
                .Display = ""
                .Raw = 0
                .ScaleString = ""
                .Value = 0
            End With
        End Sub
#End Region
#Region "|07.01| <Loader> [Value|ULong]"
        Public Sub New(ByVal Value As ULong, Optional ByVal Format As Scales = Nothing)

            Dim Run As SizeInfo = Convert_Size(Value, Format)
            With Me
                .Display = Run.Display
                .Raw = Value
                .ScaleString = Run.ScaleString
                .ValueString = Run.ValueString
                .Value = Run.Value
            End With
        End Sub
#End Region

#End Region
#Region "|9| [Constantes]"
        Public Const Tera_Scale As ULong = 1099511627776
        Public Const Giga_Scale As ULong = 1073741824
        Public Const Mega_Scale As ULong = 1048576
        Public Const Kilo_Scale As ULong = 1024
        Public Const Octa_Scale As ULong = 0
#End Region
    End Class

#End Region
#Region "|08.03| <Class> [Retrieve_Icons]"
    Public Class Retrieve_Icons


#Region "<07.02> [Structures]"
#Region "<07.02.00> <Structures> [Icon_Info]"
        <StructLayout(LayoutKind.Sequential)>
        Private Structure SHFILEINFO
            Public hIcon As IntPtr
            Public iIcon As Integer
            Public dwAttributes As Integer
            <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=MAX_PATH)>
            Public szDisplayName As String
            <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=NAMESIZE)>
            Public szTypeName As String
        End Structure
#End Region
#End Region

#Region "<07.04> [Functions]"
#Region "<07.04.00> <Functions> [Shell32.Dll]"
#Region "<07.04.00.00> <Shell32.Dll> [GetFileInfo(FilePath|String,FileAttributes|Integer,Fi|Icon_Info,FileInfo|Integer,uFlags|Integer)|IntPtr]"

        <DllImport("Shell32.dll")>
        Private Shared Function SHGetFileInfo(ByVal pszPath As String,
                                      ByVal dwFileAttributes As Integer,
                                      ByRef psfi As SHFILEINFO,
                                      ByVal cbFileInfo As Integer,
                                      ByVal uFlags As Integer) As IntPtr
        End Function
#End Region
#End Region
#Region "<07.04.01> <Functions> [User32.Dll]"
#Region "<07.04.01.00> <User32.Dll> [DestroyIcon(iIcon|IntPtr)|Boolean]"
        <DllImport("user32.dll", SetLastError:=True)>
        Private Shared Function DestroyIcon(ByVal hIcon As IntPtr) As Boolean
        End Function
#End Region
#End Region
#Region "<07.04.02> <Functions> [Icon]"
#Region "<07.04.02.00> <Icon> [GetShellIcon(Path|String)|Bitmap]"
        ''' <summary>
        ''' Retrieve the Shell Icon from the Designated Path
        ''' </summary>
        ''' <param name="Path"></param>
        ''' <returns></returns>
        Public Shared Function GetShellIcon(ByVal path As String) As Bitmap
            Dim shfi As SHFILEINFO = New SHFILEINFO()
            Dim ret As IntPtr = SHGetFileInfo(path, 0, shfi, Marshal.SizeOf(shfi), SHGFI_ICON)
            If ret <> IntPtr.Zero Then
                Dim bmp As Bitmap = System.Drawing.Icon.FromHandle(shfi.hIcon).ToBitmap
                DestroyIcon(shfi.hIcon)
                Return bmp
            Else
                Return Nothing
            End If
        End Function
#End Region

#End Region
#End Region
#Region "<07.08> [Constantes]"
#Region "<07.08.00> <Constantes> [Design]"
        Private Const MAX_PATH As Integer = 256
        Private Const NAMESIZE As Integer = 80
        Private Const SHGFI_ICON As Int32 = &H100
#End Region
#End Region
    End Class
#End Region
#Region "|08.04| <Class> [DataBase]"
    ''' <summary>
    ''' This class enable one to manage database type object.
    ''' <Production Price>322 CHF</Production>
    ''' <Quantity> 16    Properties @9 =  144
    '''            01    Sub        @8 =    8
    '''            09    Functions  @12 = 108
    '''            03    Loader     @10 =  30
    '''            16    Parameters @2  =  32
    '''  Total :   36                   = 322.-
    ''' </Quantity>
    ''' </summary>
    Public Class DataBase
        Inherits Fichier
#Region "<1> [Property]{16}"
#Region "<01.00> <Property> [ConnectionInfo]{3}"
#Region "|2019/05/01 17h33:444| <01.00.00> <Property> <ConnectionInfo> [Call=Line|LineInfo]"'(Set|Get) the Line as LineInfo.
        Private _Line As LineInfo
        ''' <Summary>
        ''' (Set|Get) the Line as LineInfo.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/01 17h33:444 </Published>
        ''' <Updated>[Created=2019/05/01 17h33:444][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("ConnectionInfo"), Description("(Set|Get) the Line as LineInfo."), Browsable(True)>
        Public Property Line() As LineInfo
            Get
                Return _Line
            End Get
            Set(ByVal Value As LineInfo)
                If Not IsNothing(Value) Then
                    If Not IsNothing(Value.Status) Then
                        ConnectionStatus = Value.Status
                    End If
                    If Value.DataBaseFormat = DataBaseType.Sql Then
                        Me.UseSQL = True
                    Else
                        Me.UseSQL = False
                    End If
                End If

                _Line = Value
            End Set
        End Property
#End Region ' (Set|Get) the Line as LineInfo.
#Region "|2019/05/01 14h07:746| <01.00.01> <Property> <ConnectionInfo> [Call=UseSQL|Boolean]"'(Set|Get) the Enable SQL format.
        Private _UseSQL As Boolean
        ''' <Summary>
        ''' (Set|Get) the Enable SQL format.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/01 14h07:745 </Published>
        ''' <Updated>[Created=2019/05/01 14h07:743][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("ConnectionInfo"), Description("(Set|Get) the Enable SQL format."), Browsable(True)>
        Public Property UseSQL() As Boolean
            Get
                Return _UseSQL
            End Get
            Set(ByVal Value As Boolean)
                _UseSQL = Value
            End Set
        End Property
#End Region ' (Set|Get) the Enable SQL format.
#Region "|2019/05/01 14h12:811| <01.00.02> <Property> <ConnectionInfo> [Call=ConnectionStatus|Status]"'(Set|Get) Returns the Connection Line Status
        Private _ConnectionStatus As Status
        ''' <Summary>
        ''' Returns the Connection Line Status
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/01 14h12:810 </Published>
        ''' <Updated>[Created=2019/05/01 14h12:810][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("ConnectionInfo"), Description("Returns the Connection Line Status"), Browsable(True)>
        Public Property ConnectionStatus() As Status
            Get
                Return _ConnectionStatus
            End Get
            Set(ByVal Value As Status)
                _ConnectionStatus = Value
            End Set
        End Property
#End Region ' (Set|Get) Returns the Connection Line Status
#End Region
#Region "<01.01> <Property> [Index]{2}"
#Region "|2019/05/01 17h44:756| <01.01.00> <Property> <Index> [Call=Tables|List(Of Table)]"'(Set|Get) the Tables as List(Of Table).
        Private _Tables As List(Of Table)
        ''' <Summary>
        ''' (Set|Get) the Tables as List(Of Table).
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/01 17h44:756 </Published>
        ''' <Updated>[Created=2019/05/01 17h44:756][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Index"), Description("(Set|Get) the Tables as List(Of Table)."), DefaultValue("DataBaseType.[Nothing]"), Browsable(True)>
        Public Property Tables() As List(Of Table)
            Get
                Return _Tables
            End Get
            Set(ByVal Value As List(Of Table))
                _Tables = Value
            End Set
        End Property
#End Region ' (Set|Get) the Tables as List(Of Table).
#Region "[On] |2019/06/11 18h07:229| <01.00.01> <Property> <Index> |.TableCount()|Integer|"' (Set|Get) The TableCount as Integer.
        Private _TableCount As Integer
        '''    <Summary>
        '''     (Set|Get) The TableCount as Integer.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/11 18h07:285 </Published>
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

        <Browsable(True), CategoryAttribute("Index"), Description("(Set|Get) The TableCount as Integer.")>
        Property TableCount() As Integer
            Get
                Return _TableCount
            End Get
            Set(ByVal Value As Integer)
                _TableCount = Value
            End Set
        End Property
#End Region '(Set|Get) The TableCount as Integer.

#End Region
#Region "<01.02> <Property> [TableObject]{3}"
#Region "|2019/05/01 14h13:718| <01.03.00> <Property> <TableObject> [Call=DataTable|DataTable]"'(Set|Get) Represents one table of in-memory data.
        Private _DataTable As DataTable
        ''' <Summary>
        ''' Represents one table of in-memory data.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/01 14h13:718 </Published>
        ''' <Updated>[Created=2019/05/01 14h13:718][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("TableObject"), Description("Represents one table of in-memory data."), Browsable(True)>
        Public Property DataTable() As DataTable
            Get
                Return _DataTable
            End Get
            Set(ByVal Value As DataTable)
                If Not IsNothing(Value) Then

                End If
                _DataTable = Value
            End Set
        End Property
#End Region ' (Set|Get) Represents one table of in-memory data.
#Region "|2019/05/01 14h14:947| <01.03.01> <Property> <TableObject> [Call=TableMap|Common.DataTableMapping]"'(Set|Get) Contains a description of a mapped-relationship between a source table and a DataTable. This class is used by a Common.DataAdapter when populating a DataSet.
        Private _TableMap As Common.DataTableMapping
        ''' <Summary>
        ''' Contains a description of a mapped-relationship between a source table and a DataTable. This class is used by a Common.DataAdapter when populating a DataSet.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/01 14h14:946 </Published>
        ''' <Updated>[Created=2019/05/01 14h14:946][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("TableObject"), Description("Contains a description of a mapped-relationship between a source table and a DataTable. This class is used by a Common.DataAdapter when populating a DataSet."), Browsable(True)>
        Public Property TableMap() As Common.DataTableMapping
            Get
                Return _TableMap
            End Get
            Set(ByVal Value As Common.DataTableMapping)
                _TableMap = Value
            End Set
        End Property
#End Region ' (Set|Get) Contains a description of a mapped-relationship between a source table and a DataTable. This class is used by a Common.DataAdapter when populating a DataSet.
#Region "|2019/05/01 14h14:745| <01.03.02> <Property> <TableObject> [Call=DataSet|DataSet]"'(Set|Get) Represents a in-memory cache of data.
        Private _DataSet As DataSet
        ''' <Summary>
        ''' Represents a in-memory cache of data.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/01 14h14:744 </Published>
        ''' <Updated>[Created=2019/05/01 14h14:744][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("TableObject"), Description("Represents a in-memory cache of data."), Browsable(True)>
        Public Property DataSet() As DataSet
            Get
                Return _DataSet
            End Get
            Set(ByVal Value As DataSet)
                _DataSet = Value
            End Set
        End Property
#End Region ' (Set|Get) Represents a in-memory cache of data.
#End Region
#Region "<01.03> <Property> [OleDb]{4}"
#Region "|2019/05/01 14h15:620| <01.03.00> <Property> <OleDb> [Call=Con|OleDb.OleDbConnection]"'(Set|Get) Represents an open connection to the datasource.
        Private _Con As OleDb.OleDbConnection
        ''' <Summary>
        ''' Represents an open connection to the datasource.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/01 14h15:620 </Published>
        ''' <Updated>[Created=2019/05/01 14h15:619][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("OleDb"), Description("Represents an open connection to the datasource."), Browsable(True)>
        Public Property Con() As OleDb.OleDbConnection
            Get
                Return _Con
            End Get
            Set(ByVal Value As OleDb.OleDbConnection)
                _Con = Value
            End Set
        End Property
#End Region ' (Set|Get) Represents an open connection to the datasource.
#Region "|2019/05/01 14h16:116| <01.03.01> <Property> <OleDb> [Call=Cmd|OleDb.OleDbCommand]"'(Set|Get) Represents a SQL statement or stored procedure to execute against a data source.
        Private _Cmd As OleDb.OleDbCommand
        ''' <Summary>
        ''' Represents a SQL statement or stored procedure to execute against a data source.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/01 14h16:116 </Published>
        ''' <Updated>[Created=2019/05/01 14h16:116][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("OleDb"), Description("Represents a SQL statement or stored procedure to execute against a data source."), Browsable(True)>
        Public Property Cmd() As OleDb.OleDbCommand
            Get
                Return _Cmd
            End Get
            Set(ByVal Value As OleDb.OleDbCommand)
                _Cmd = Value
            End Set
        End Property
#End Region ' (Set|Get) Represents a SQL statement or stored procedure to execute against a data source.
#Region "|2019/05/01 14h17:620| <01.03.02> <Property> <OleDb> [Call=OleDbReader|OleDb.OleDbDataReader]"'(Set|Get) Provides a way of reading a forward-only stream of data rows from a datasource. This class cannot be inherited.
        Private _OleDbReader As OleDb.OleDbDataReader
        ''' <Summary>
        ''' Provides a way of reading a forward-only stream of data rows from a datasource. This class cannot be inherited.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/01 14h17:619 </Published>
        ''' <Updated>[Created=2019/05/01 14h17:619][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("OleDb"), Description("Provides a way of reading a forward-only stream of data rows from a datasource. This class cannot be inherited."), Browsable(True)>
        Public Property OleDbReader() As OleDb.OleDbDataReader
            Get
                Return _OleDbReader
            End Get
            Set(ByVal Value As OleDb.OleDbDataReader)
                _OleDbReader = Value
            End Set
        End Property
#End Region ' (Set|Get) Provides a way of reading a forward-only stream of data rows from a datasource. This class cannot be inherited.
#Region "|2019/05/01 14h17:004| <01.03.03> <Property> <OleDb> [Call=OleDbData|OleDb.OleDbDataAdapter]"'(Set|Get) Represents a sets of data commands and a database connection that are used to fill the DataSet and update the datasource.
        Private _OleDbData As OleDb.OleDbDataAdapter
        ''' <Summary>
        ''' Represents a sets of data commands and a database connection that are used to fill the DataSet and update the datasource.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/01 14h17:004 </Published>
        ''' <Updated>[Created=2019/05/01 14h17:004][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("OleDb"), Description("Represents a sets of data commands and a database connection that are used to fill the DataSet and update the datasource."), Browsable(True)>
        Public Property OleDbData() As OleDb.OleDbDataAdapter
            Get
                Return _OleDbData
            End Get
            Set(ByVal Value As OleDb.OleDbDataAdapter)
                _OleDbData = Value
            End Set
        End Property
#End Region ' (Set|Get) Represents a sets of data commands and a database connection that are used to fill the DataSet and update the datasource.
#End Region
#Region "<01.04> <Property> [SQL]{4}"
#Region "|2019/05/01 14h18:675| <01.04.00> <Property> <SQL> [Call=SqlCon|SqlClient.SqlConnection]"'(Set|Get) Represents an open connection to a SQL Server DataBase. This Class cannot be inherited.
        Private _SqlCon As SqlClient.SqlConnection
        ''' <Summary>
        ''' Represents an open connection to a SQL Server DataBase. This Class cannot be inherited.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/01 14h18:675 </Published>
        ''' <Updated>[Created=2019/05/01 14h18:675][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("SQL"), Description("Represents an open connection to a SQL Server DataBase. This Class cannot be inherited."), Browsable(True)>
        Public Property SqlCon() As SqlClient.SqlConnection
            Get
                Return _SqlCon
            End Get
            Set(ByVal Value As SqlClient.SqlConnection)
                _SqlCon = Value
            End Set
        End Property
#End Region ' (Set|Get) Represents an open connection to a SQL Server DataBase. This Class cannot be inherited.
#Region "|2019/05/01 14h18:614| <01.04.01> <Property> <SQL> [Call=SqlCmd|SqlClient.SqlCommand]"'(Set|Get) Represents a Transact-SQL statement or store procedure to execute against a SQL Server dataBase. This class cannot be inherited.
        Private _SqlCmd As SqlClient.SqlCommand
        ''' <Summary>
        ''' Represents a Transact-SQL statement or store procedure to execute against a SQL Server dataBase. This class cannot be inherited.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/01 14h18:614 </Published>
        ''' <Updated>[Created=2019/05/01 14h18:614][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("SQL"), Description("Represents a Transact-SQL statement or store procedure to execute against a SQL Server dataBase. This class cannot be inherited."), Browsable(True)>
        Public Property SqlCmd() As SqlClient.SqlCommand
            Get
                Return _SqlCmd
            End Get
            Set(ByVal Value As SqlClient.SqlCommand)
                _SqlCmd = Value
            End Set
        End Property
#End Region ' (Set|Get) Represents a Transact-SQL statement or store procedure to execute against a SQL Server dataBase. This class cannot be inherited.
#Region "|2019/05/01 14h19:174| <01.04.02> <Property> <SQL> [Call=SqlReader|SqlClient.SqlDataReader]"'(Set|Get) Provides a way of reading a forward-only stream of rows from a SQL Server database. This class cannot be inherited.
        Private _SqlReader As SqlClient.SqlDataReader
        ''' <Summary>
        ''' Provides a way of reading a forward-only stream of rows from a SQL Server database. This class cannot be inherited.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/01 14h19:174 </Published>
        ''' <Updated>[Created=2019/05/01 14h19:174][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("SQL"), Description("Provides a way of reading a forward-only stream of rows from a SQL Server database. This class cannot be inherited."), Browsable(True)>
        Public Property SqlReader() As SqlClient.SqlDataReader
            Get
                Return _SqlReader
            End Get
            Set(ByVal Value As SqlClient.SqlDataReader)
                _SqlReader = Value
            End Set
        End Property
#End Region ' (Set|Get) Provides a way of reading a forward-only stream of rows from a SQL Server database. This class cannot be inherited.
#Region "|2019/05/01 14h19:136| <01.04.03> <Property> <SQL> [Call=SqlData|SqlClient.SqlDataAdapter]"'(Set|Get) Represents a set of data commands and a database connection that are used to fill and update a SQL Server database.This class cannot be inherited.
        Private _SqlData As SqlClient.SqlDataAdapter
        ''' <Summary>
        ''' Represents a set of data commands and a database connection that are used to fill and update a SQL Server database.This class cannot be inherited.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/01 14h19:136 </Published>
        ''' <Updated>[Created=2019/05/01 14h19:136][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("SQL"), Description("Represents a set of data commands and a database connection that are used to fill and update a SQL Server database.This class cannot be inherited."), Browsable(True)>
        Public Property SqlData() As SqlClient.SqlDataAdapter
            Get
                Return _SqlData
            End Get
            Set(ByVal Value As SqlClient.SqlDataAdapter)
                _SqlData = Value
            End Set
        End Property
#End Region ' (Set|Get) Represents a set of data commands and a database connection that are used to fill and update a SQL Server database.This class cannot be inherited.
#End Region
#End Region
#Region "<2> [Enumeration]"

#End Region
#Region "<3> [Sub]{1}"
#Region "<03.00> <Sub> [Clear]"
        ''' <summary>
        ''' Clear Content
        ''' </summary>
        Public Sub Reset()
            With Me
                .Access = Nothing
                .Cmd = New OleDb.OleDbCommand
                .Con = New OleDb.OleDbConnection
                .ConnectionStatus = Status.Broken
                .Created = Now
                .DataSet = New DataSet
                .DataTable = New DataTable
                .Description = ""
                .Exists = False
                .Extension = ""
                .FileName = ""
                .FilePath = New Folder
                .FullName = ""
                .Icon = Nothing
                .IsCompressed = False
                .IsDataBase = True
                .IsEncrypted = False
                .IsHidden = False
                .IsReadable = False
                .Line = New LineInfo
                .Modified = Nothing
                .Name = ""
                .OleDbData = New OleDb.OleDbDataAdapter
                .OleDbReader = Nothing
                .Password = ""
                .SqlCmd = New SqlClient.SqlCommand
                .SqlCon = New SqlClient.SqlConnection
                .SqlData = New SqlClient.SqlDataAdapter
                .SqlReader = Nothing
                .TableMap = New Common.DataTableMapping
                .Tables = New List(Of Table)
                .Target = Nothing
                .UseSQL = False
                .Log = New TestItem
            End With
        End Sub
#End Region
#End Region
#Region "<4> [Function]{9}"
#Region "<04.00> <Function> [DataBase]{3}"
#Region "<04.00.00> <Function> <DataBase> [GetTables()|List(Of Table)]"
        'Small Test
        Public HasFinishImporting As Boolean = False
        Public IndexTableConvert As Integer = 0
        ''' <summary>
        ''' Retreive tables
        ''' </summary>
        ''' <returns></returns>
        Public Function GetTables(Optional ByVal WithImport As Boolean = True) As List(Of Table)
            Me.Tables = New List(Of Table)
            Dim Result As New List(Of Table)
            HasFinishImporting = False
            Me.DataTable = New DataTable
            'Step 0 : Evaluate if the connection has been set
            If Not IsNothing(Me.Line) Then
                If Me.ConnectionStatus <> Status.Broken Then
                    If Me.Line.DataBaseFormat = DataBaseType.Accdb Or Me.Line.DataBaseFormat = DataBaseType.Saadry Then
#Region "|Accdb & Saadry|"
#Region "<Importing Data in Me.DataTable>"
                        Try
                            Open()
                            Me.DataTable = Con.GetOleDbSchemaTable(OleDb.OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, Nothing, "Table"})
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        Finally
                            Close()
                        End Try
#End Region

#Region "<Filling Tables in Me.Tables>"
#Region "<Grabing Tables>"
                        Me.TableCount = Me.DataTable.Rows.Count
                        For i = 0 To Me.DataTable.Rows.Count - 1
                            IndexTableConvert = i
                            Dim Tb As New Table(Me.DataTable.Rows(i)!TABLE_NAME.ToString, Me, WithImport)
                            Result.Add(Tb)
                            Tables.Add(Tb)
                        Next
#End Region
#End Region
#End Region
                    ElseIf Me.Line.DataBaseFormat = DataBaseType.Mdb Then
#Region "|Mdb|"
                        ' Dim restrictions() As String = New String(4) {}
                        'restrictions(3) = "Table"
                        Dim restrictions() As String = New String(3) {}
                        restrictions(3) = "Table"
#Region "<Importing Data in Me.DataTable>"
                        Try
                            Open()
                            Me.DataTable = Con.GetSchema("Tables", restrictions)
                            ' Me.DataTable = Con.GetSchema("Tables", New String() {Nothing, Nothing, "TABLE"})
                        Catch ex As Exception
                        Finally
                            Close()
                        End Try
#End Region
#Region "<Filling Tables in Me.Tables>"

#Region "<Grabing Tables>"
                        Me.TableCount = Me.DataTable.Rows.Count
                        For i = 0 To Me.DataTable.Rows.Count - 1
                            IndexTableConvert = i
                            Dim Tb As New Table(Me.DataTable.Rows(i)!TABLE_NAME.ToString, Me)
                            Result.Add(Tb)
                            Tables.Add(Tb)
                        Next
#End Region

#End Region
#End Region
                    ElseIf Me.Line.DataBaseFormat = DataBaseType.Dbf Then
#Region "|Dbf|"
                        Me.TableCount = 1
                        IndexTableConvert = 1
                        Dim Tb As New Table(Me.Name, Me)
                        Tables.Add(Tb)
                        Result.Add(Tb)
#End Region
                    ElseIf Me.Line.DataBaseFormat = DataBaseType.Excel Then
#Region "|Excel| To finish"

#End Region
                    ElseIf Me.Line.DataBaseFormat = DataBaseType.Sql Then
#Region "|SQL|"
                        Dim Strcommand As String = "SELECT * FROM sys.tables"
                        Try
                            Open()
                            Me.SqlData = New SqlClient.SqlDataAdapter(Strcommand, SqlCon)
                            Me.SqlData.Fill(Me.DataSet)
                        Catch ex As Exception
                        Finally
                            Close()
                        End Try
#Region "<Filling Tables in Me.Tables>"
                        Me.TableCount = Me.DataSet.Tables.Count
                        For Each Tbl As DataTable In Me.DataSet.Tables
                            IndexTableConvert += 1
                            For Each Row As DataRow In Tbl.Rows
                                If Row.ItemArray(3).ToString = "BASE TABLE" Then
                                    For Each Col As DataColumn In Tbl.Columns
                                        If Col.ToString = "TABLE_NAME" Then
                                            Dim Table As New Table(Row(Col).ToString, Me)
                                            Result.Add(Table)
                                            Tables.Add(Table)
                                        End If
                                    Next
                                End If
                            Next
                        Next
#End Region
#End Region
                    End If
                Else
                    MsgBox("ConnectionStatus is not online")
                End If
            Else
                MsgBox("Line is empty")
            End If
            HasFinishImporting = True
            Me.Tables = Result
            Return Result
        End Function
#End Region
#Region "<04.00.01> <Function> <DataBase> [Create(FilePath|String,Format|DataBaseFormat,[Password]|String(""))|DataBase]"
        ''' <summary>
        ''' Create a DataBase.
        ''' </summary>
        ''' <param name="FilePath"></param>
        ''' <param name="Format"></param>
        ''' <param name="Password"></param>
        ''' <param name="Overwrite">If file already exist the function will avoid creation by default.</param>
        ''' <returns></returns>
        Public Overloads Shared Function Create(ByVal FilePath As String,
                                      ByVal Format As DataBaseType,
                           Optional ByVal Password As String = "",
                           Optional ByVal Overwrite As Boolean = False) As DataBase
            Dim Result As New DataBase
            If IO.File.Exists(FilePath) Then
                'Attention file already exist
            Else
                If Format = DataBaseType.Accdb Then
#Region "<Accdb>"

                    Dim Temp As New DataBase(My.Application.Info.DirectoryPath & "\Ressource\Empty DataBase\NewAccessDataBase.accdb", Password)
                    Dim Filename As String = IO.Path.GetFileNameWithoutExtension(FilePath)
                    Dim Path As String = IO.Path.GetDirectoryName(FilePath)
                    Try
                        IO.File.Copy(Temp.Target, Path & "\" & Filename & ".accdb", Overwrite)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    Result = New DataBase(Path & "\" & Filename & ".accdb", "")
                    If Password <> "" Then
                        Try
                            If Result.ChangePassword(Password, "").Status = Status.Online Then
                                Result = New DataBase(Path & "\" & Filename & ".accdb", Password)
                            End If
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    End If
#End Region
                ElseIf Format = DataBaseType.Mdb Then
#Region "<Mdb>"

                    Dim Temp As New DataBase(My.Application.Info.DirectoryPath & "\Ressource\Empty DataBase\EmptyMdb.mdb", Password)
                    Dim Filename As String = IO.Path.GetFileNameWithoutExtension(FilePath)
                    Dim Path As String = IO.Path.GetDirectoryName(FilePath)
                    Try
                        IO.File.Copy(Temp.Target, Path & "\" & Filename & ".mdb", Overwrite)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    Result = New DataBase(Path & "\" & Filename & ".mdb", "")
                    If Password <> "" Then
                        Try
                            If Result.ChangePassword(Password, "").Status = Status.Online Then
                                Result = New DataBase(Path & "\" & Filename & ".mdb", Password)
                            End If
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    End If
#End Region
                ElseIf Format = DataBaseType.Sql Then
#Region "<Sql>"
                    Dim Temp As New DataBase(My.Application.Info.DirectoryPath & "\Ressource\Empty DataBase\NewSQL.mdf", Password)
                    Dim Filename As String = IO.Path.GetFileNameWithoutExtension(FilePath)
                    Dim Path As String = IO.Path.GetDirectoryName(FilePath)
                    Try
                        IO.File.Copy(Temp.Target, Path & "\" & Filename & ".mdf", Overwrite)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    Result = New DataBase(Path & "\" & Filename & ".mdf", "")
                    If Password <> "" Then
                        Try
                            If Result.ChangePassword(Password, "").Status = Status.Online Then
                                Result = New DataBase(Path & "\" & Filename & ".mdfé", Password)
                            End If
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    End If
#End Region
                ElseIf Format = DataBaseType.Saadry Then
#Region "<Saadry>"

                    Dim Temp As New DataBase(My.Application.Info.DirectoryPath & "\Ressource\Empty DataBase\NewAccessDataBase.accdb", Password)
                    Dim Filename As String = IO.Path.GetFileNameWithoutExtension(FilePath)
                    Dim Path As String = IO.Path.GetDirectoryName(FilePath)
                    Try
                        IO.File.Copy(Temp.Target, Path & "\" & Filename & ".Saadry", Overwrite)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    Result = New DataBase(Path & "\" & Filename & ".Saadry", "")
                    If Password <> "" Then
                        Try
                            If Result.ChangePassword(Password, "").Status = Status.Online Then
                                Result = New DataBase(Path & "\" & Filename & ".Saadry", Password)
                            End If
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    End If
#End Region
                End If
            End If

            Return Result
        End Function
#End Region
#Region "<04.00.02> <Function> <DataBase> [ChangePassword(NewPassword|String,OldPassword|String)|TestItem]"
        ''' <summary>
        ''' Modify the password of the DataBase
        ''' </summary>
        ''' <param name="NewPassword"></param>
        ''' <param name="OldPassword"></param>
        ''' <returns></returns>
        Public Function ChangePassword(ByVal NewPassword As String,
                                       ByVal OldPassword As String) As TestItem
            Dim Result As New TestItem("ChangePassword", "Changing the password")
            If Not IsNothing(Me.Line) Then
                If Me.Line.DataBaseFormat = DataBaseType.Accdb Or Me.Line.DataBaseFormat = DataBaseType.Saadry Or Me.Line.DataBaseFormat = DataBaseType.Mdb Then

                    Try
                        Open("ALTER DATABASE PASSWORD [" & NewPassword & "][" & OldPassword & "]")
                        If Cmd.ExecuteNonQuery() > 0 Then
                            Result.Write("The password has been changed sucessfully")
                            Result.Write("Old Password :> {" & OldPassword & "}")
                            Result.Write("The new password is : {" & NewPassword & "}")
                            Result.Status = Status.Online
                        Else
                            Result.Write("Could not change the password.")
                            Result.Status = Status.Broken
                        End If
                    Catch ex As Exception
                        Result.AddBug(ex, "The password could not be changed", "ALTER DATABASE PASSWORD [" & NewPassword & "][" & OldPassword & "]")
                        Result.Status = Status.Broken
                    End Try
                ElseIf Me.Line.DataBaseFormat = DataBaseType.Sql Then
                    Try
                        Open("UPDATE Accounts SET Password='" & NewPassword & "';")
                        Me.SqlData.SelectCommand = SqlCmd
                        Me.SqlData.Fill(Me.DataSet, "0")
                        Result.Status = Status.Online
                    Catch ex As Exception
                        Result.Status = Status.Broken
                        Result.AddBug(ex, "The password could not be changed", "UPDATE Accounts SET Password='" & NewPassword & "';")
                    End Try
                End If

            End If
            Return Result
        End Function
#End Region
#End Region
#Region "<04.01> <Function> [Table]{3}"
#Region "<04.01.00> <Function> <Table> [CreateTable(TableName|String)|Table]"
        ''' <summary>
        ''' Create a table if name is not already in use.
        ''' </summary>
        ''' <param name="TableName"></param>
        ''' <returns></returns>
        Public Function CreateTable(ByVal TableName As String) As Table
            Dim Result As Table = Nothing
            If Not IsNothing(FindTable(TableName)) Then
                If FindTable(Target).TableName = TableName Then
                    'cannot proceed because the table already exist
                Else
                    If Not IsNothing(Me.Line) Then
                        If Me.Line.DataBaseFormat = DataBaseType.Accdb Or
                            Me.Line.DataBaseFormat = DataBaseType.Mdb Or
                            Me.Line.DataBaseFormat = DataBaseType.Saadry Then
                            Dim StrCommand As String = "Create Table " & TableName & " (" & "ID Counter" & ")"
                            Try
                                Open(StrCommand)
                                If Cmd.ExecuteNonQuery > 0 Then
                                    Result = New Table(TableName, Me)
                                End If
                            Catch ex As Exception
                            Finally
                                Close()
                            End Try
                            Me.Tables.Add(Result)
                        ElseIf Me.Line.DataBaseFormat = DataBaseType.Sql Then
                            Dim StrCommand As String = "Create Table " & Me.Name & "." & TableName & "(Id int NOT NULL PRIMARY KEY) IN " & Me.Name
                            Try
                                Open(StrCommand)
                                If SqlCmd.ExecuteNonQuery > 0 Then
                                    Result = New Table(TableName, Me)
                                End If
                            Catch ex As Exception
                            Finally
                                Close()
                            End Try
                        End If
                    End If
                End If
            End If
            Return Result
        End Function
#End Region
#Region "<04.01.01> <Function> <Table> [FindTable(TableName|String)|Table]"
        ''' <summary>
        ''' Find Table
        ''' </summary>
        ''' <param name="TableName"></param>
        ''' <returns></returns>
        Public Function FindTable(ByVal TableName As String) As Table
            Dim Result As New Table
            If Not IsNothing(Me.Tables) Then
                For i = 0 To Me.Tables.Count - 1
                    If Me.Tables(i).TableName = TableName Then
                        Result = Me.Tables(i)
                        Exit For
                    End If
                Next
            End If
            Return Result
        End Function
#End Region
#Region "<04.01.02> <Function> <Table> [DeleteTable(TableName|String)|Table]"
        ''' <summary>
        ''' Delete the selected table
        ''' </summary>
        ''' <param name="TableName"></param>
        ''' <returns></returns>
        Public Function DeleteTable(ByVal TableName As String) As Table
            Dim Result As Table = Nothing
            Result = FindTable(TableName)
            If Not IsNothing(Result) Then
                If Not IsNothing(Me.Line) Then
                    If Me.Line.DataBaseFormat = DataBaseType.Accdb Then
#Region "Accdb"
                        Dim Valid As Boolean = True
                        Try
                            Open("DROP TABLE " & TableName)
                            If Cmd.ExecuteNonQuery >= 0 Then
                                Valid = True
                            Else
                                Valid = False
                            End If
                        Catch ex As Exception
                            Valid = False
                        Finally
                            Close()
                        End Try
                        If Valid = True Then
                            Me.Tables.Remove(Result)
                        End If
#End Region
                    ElseIf Me.Line.DataBaseFormat = DataBaseType.Mdb Then
#Region "Mdb"
                        Dim Valid As Boolean = True
                        Try
                            Open("DROP TABLE " & TableName)
                            If Cmd.ExecuteNonQuery >= 0 Then
                                Valid = True
                            Else
                                Valid = False
                            End If
                        Catch ex As Exception
                            Valid = False
                        Finally
                            Close()
                        End Try
                        If Valid = True Then
                            Me.Tables.Remove(Result)
                        End If
#End Region
                    ElseIf Me.Line.DataBaseFormat = DataBaseType.Saadry Then
#Region "Saadry"
                        Dim Valid As Boolean = True
                        Try
                            Open("DROP TABLE " & TableName)
                            If Cmd.ExecuteNonQuery >= 0 Then
                                Valid = True
                            Else
                                Valid = False
                            End If
                        Catch ex As Exception
                            Valid = False
                        Finally
                            Close()
                        End Try
                        If Valid = True Then
                            Me.Tables.Remove(Result)
                        End If
#End Region
                    ElseIf Me.Line.DataBaseFormat = DataBaseType.Sql Then
#Region "Sql"
                        Dim Valid As Boolean = True
                        Try
                            Open("DROP TABLE " & TableName)
                            If SqlCmd.ExecuteNonQuery >= 0 Then
                                Valid = True
                            Else
                                Valid = False
                            End If
                        Catch ex As Exception
                            Valid = False
                        Finally
                            Close()
                        End Try
                        If Valid = True Then
                            Me.Tables.Remove(Result)
                        End If
#End Region
                    End If
                End If
            End If
            Return Result
        End Function
#End Region
#End Region
#Region "<04.02> <Function> [Operation]{3}"
#Region "<04.02.00> <Function> <Operation> [Open]{2}"
#Region "<04.02.00.00> <Function> <Operation> <Open> [Open()]"
        ''' <summary>
        ''' Opening the Connection
        ''' </summary>
        ''' <returns></returns>
        Public Function Open() As TestItem
            Dim Result As New TestItem("Open", PrintTime() & " Openning the connection ligne to the database.")
            'Result.AddParam("Me.Line", Me.Line, Me.Line.ToString)
            If Not IsNothing(Me.Line) Then
                If Me.Line.ToString <> "" Then
                    If Me.UseSQL = True Then
                        Me.SqlCon = New SqlClient.SqlConnection(Me.Line.ToString)
                        If IsNothing(Me.SqlCmd) Then
                            Me.SqlCmd = New SqlClient.SqlCommand
                        End If
                        Me.SqlCmd.Connection = Me.SqlCon
                        If Me.SqlCon.State = ConnectionState.Open Then
                        Else
                            Try
                                Me.SqlCon.Open()
                                Me.ConnectionStatus = Status.Running
                                Result.Status = Status.Online
                            Catch ex As Exception
                                Result.AddBug(ex, "Error while opening database", "Me.SqlCon.Open()")
                                Me.ConnectionStatus = Status.Broken
                                Result.Status = Status.Broken
                            End Try
                        End If
                    Else
                        Me.Con = New OleDb.OleDbConnection(Me.Line.ToString)
                        If IsNothing(Me.Cmd) Then
                            Me.Cmd = New OleDb.OleDbCommand
                        End If
                        Me.Cmd.Connection = Me.Con
                        If Me.Con.State = ConnectionState.Open Then
                        Else
                            Try
                                Me.Con.Open()
                                Me.ConnectionStatus = Status.Running
                                Result.Status = Status.Online
                            Catch ex As Exception
                                Result.AddBug(ex, "Error while opening database", "Me.Con.Open()")
                                Me.ConnectionStatus = Status.Broken
                                Result.Status = Status.Broken
                            End Try
                        End If
                    End If
                End If
            Else
                Result.Status = Status.Broken
                Result.Why += "The connection line has not been initialized."
            End If
            If IsNothing(Me.Log) Then
                Me.Log = New TestItem("DataBase(" & Me.FileName & ")", "Configuration of the database.")
            End If
            If IsNothing(Me.Log.Results) Then
                Me.Log.Results = New List(Of TestItem)
            End If
            Me.Log.Results.Add(Result)
            Return Result
        End Function
#End Region
#Region "<04.02.00.01> <Function> <Operation> <Open> [Open(SqlCommand|String)]"
        ''' <summary>
        ''' Open the connection String with SqlCommand
        ''' </summary>
        ''' <param name="SqlCommand"></param>
        ''' <returns></returns>
        Public Function Open(ByVal SqlCommand As String) As TestItem
            Dim Result As New TestItem("Open(" & SqlCommand & ")", PrintTime() & " Openning the connection ligne to the database.")
            'Result.AddParam("Me.Line", Me.Line, Me.Line.ToString)
            'Result.AddParam("SqlCommand", SqlCommand, SqlCommand)
            If Not IsNothing(Me.Line) Then
                If Me.Line.ToString <> "" Then
                    If Me.UseSQL = True Then
                        Me.SqlCon = New SqlClient.SqlConnection(Me.Line.ToString)
                        If IsNothing(Me.SqlCmd) Then
                            Me.SqlCmd = New SqlClient.SqlCommand
                        End If
                        Me.SqlCmd.Connection = Me.SqlCon
                        Me.SqlCmd.CommandText = SqlCommand
                        If Me.SqlCon.State = ConnectionState.Open Then
                        Else
                            Try
                                Me.SqlCon.Open()
                                Me.ConnectionStatus = Status.Running
                                Result.Status = Status.Online
                            Catch ex As Exception
                                Result.AddBug(ex, "Error while opening database", "Me.SqlCon.Open()")
                                Me.ConnectionStatus = Status.Broken
                                Result.Status = Status.Broken
                            End Try
                        End If
                    Else
                        Me.Con = New OleDb.OleDbConnection(Me.Line.ToString)
                        If IsNothing(Me.Cmd) Then
                            Me.Cmd = New OleDb.OleDbCommand
                        End If
                        Me.Cmd.Connection = Me.Con
                        Me.Cmd.CommandText = SqlCommand
                        If Me.Con.State = ConnectionState.Open Then
                        Else
                            Try
                                Me.Con.Open()
                                Me.ConnectionStatus = Status.Running
                                Result.Status = Status.Online
                            Catch ex As Exception
                                Result.AddBug(ex, "Error while opening database", "Me.Con.Open()")
                                Me.ConnectionStatus = Status.Broken
                                Result.Status = Status.Broken
                            End Try
                        End If
                    End If
                End If
            Else
                Result.Status = Status.Broken
                Result.Why += "The connection line has not been initialized."
            End If
            If IsNothing(Me.Log) Then
                Me.Log = New TestItem("DataBase(" & Me.FileName & ")", "Configuration of the database.")
            End If
            If IsNothing(Me.Log.Results) Then
                Me.Log.Results = New List(Of TestItem)
            End If
            Me.Log.Results.Add(Result)
            Return Result
        End Function
#End Region
#End Region
#Region "<04.02.01> <Function> <Operation> [Close]{1}"
#Region "<04.02.01.00> <Function> <Operation> <Close> [Close([Dispose]|Boolean(True))|TestItem]"
        ''' <summary>
        ''' Closing the connection
        ''' </summary>
        ''' <param name="Dispose"></param>
        ''' <returns></returns>
        Public Function Close(Optional ByVal Dispose As Boolean = True) As TestItem
            Dim Result As New TestItem("Closing Db", "Closing the Database connection.")
            If Not IsNothing(Me.Line) Then
                Result.Write("The line is configured")
                If Not IsNothing(Me.Con) Then
                    Result.Write("Con Exist")
                    If Me.Con.State = ConnectionState.Closed Then
                        Result.Write("Con is already close. No further action required. Mission accomplished.")
                        Result.Status = Status.Finished
                    ElseIf Me.Con.State = ConnectionState.Broken Then
                        Result.Write("Con is broken.")
                        Result.Why += ("The connection to the data source is broken. This can occur only after the connection") & vbNewLine
                        Result.Why += ("has been opened. A connection in this state may be closed and then re-opened.") & vbNewLine
                        Result.Status = Status.Broken
                    ElseIf Me.Con.State = ConnectionState.Connecting Then
                        Result.Write("The connection object is connecting to the data source.")
                        Result.Write("Sending command to close the connection.")
                        Me.Con.Close()
                        If Dispose = True Then
                            Me.Con.Dispose()
                            Result.Write("Sending command to dispose of the object Con.")
                        End If
                        If Me.Con.State = ConnectionState.Closed Then
                            Result.Status = Status.Finished
                            Result.Write("The connection is closed.")
                        Else
                            Result.Status = Status.Broken
                            Result.Write("The connection will not close.")
                            Result.Why += ("The connection will not close.") & vbNewLine

                        End If
                    ElseIf Me.Con.State = ConnectionState.Executing Then
                        Result.Write("The connection object is executing a command.")
                        Result.Write("Sending command to close the connection.")
                        Me.Con.Close()
                        If Dispose = True Then
                            Me.Con.Dispose()
                            Result.Write("Sending command to dispose of the object Con.")
                        End If
                        If Me.Con.State = ConnectionState.Closed Then
                            Result.Status = Status.Finished
                            Result.Write("The connection is closed.")
                        Else
                            Result.Status = Status.Broken
                            Result.Write("The connection will not close.")
                            Result.Why += ("The connection will not close.") & vbNewLine

                        End If
                    ElseIf Me.Con.State = ConnectionState.Fetching Then
                        Result.Write("The connection object is retrieving data.")
                        Result.Write("Sending command to close the connection.")
                        Me.Con.Close()
                        If Dispose = True Then
                            Me.Con.Dispose()
                            Result.Write("Sending command to dispose of the object Con.")
                        End If
                        If Me.Con.State = ConnectionState.Closed Then
                            Result.Status = Status.Finished
                            Result.Write("The connection is closed.")
                        Else
                            Result.Status = Status.Broken
                            Result.Write("The connection will not close.")
                            Result.Why += ("The connection will not close.") & vbNewLine

                        End If
                    Else
                        Result.Write("Sending command to close the connection.")
                        Me.Con.Close()
                        If Dispose = True Then
                            Me.Con.Dispose()
                            Result.Write("Sending command to dispose of the object Con.")
                        End If
                        If Me.Con.State = ConnectionState.Closed Then
                            Result.Status = Status.Finished
                            Result.Write("The connection is closed.")
                        Else
                            Result.Status = Status.Broken
                            Result.Write("The connection will not close.")
                            Result.Why += ("The connection will not close.") & vbNewLine

                        End If
                    End If
                End If
                If Not IsNothing(Me.SqlCon) Then
                    Result.Write("SqlCon Exist")
                    If Me.SqlCon.State = ConnectionState.Closed Then
                        Result.Write("SqlCon is already close. No further action required. Mission accomplished.")
                        Result.Status = Status.Finished
                    ElseIf Me.SqlCon.State = ConnectionState.Broken Then
                        Result.Write("SqlCon is broken.")
                        Result.Why += ("The connection to the data source is broken. This can occur only after the connection") & vbNewLine
                        Result.Why += ("has been opened. A connection in this state may be closed and then re-opened.") & vbNewLine
                        Result.Status = Status.Broken
                    ElseIf Me.SqlCon.State = ConnectionState.Connecting Then
                        Result.Write("The connection object is connecting to the data source.")
                        Result.Write("Sending command to close the connection.")
                        Me.SqlCon.Close()
                        If Dispose = True Then
                            Me.SqlCon.Dispose()
                            Result.Write("Sending command to dispose of the object SqlCon.")
                        End If
                        If Me.SqlCon.State = ConnectionState.Closed Then
                            Result.Status = Status.Finished
                            Result.Write("The connection is closed.")
                        Else
                            Result.Status = Status.Broken
                            Result.Write("The connection will not close.")
                            Result.Why += ("The connection will not close.") & vbNewLine

                        End If
                    ElseIf Me.SqlCon.State = ConnectionState.Executing Then
                        Result.Write("The connection object is executing a command.")
                        Result.Write("Sending command to close the connection.")
                        Me.SqlCon.Close()
                        If Dispose = True Then
                            Me.SqlCon.Dispose()
                            Result.Write("Sending command to dispose of the object SqlCon.")
                        End If
                        If Me.SqlCon.State = ConnectionState.Closed Then
                            Result.Status = Status.Finished
                            Result.Write("The connection is closed.")
                        Else
                            Result.Status = Status.Broken
                            Result.Write("The connection will not close.")
                            Result.Why += ("The connection will not close.") & vbNewLine

                        End If
                    ElseIf Me.SqlCon.State = ConnectionState.Fetching Then
                        Result.Write("The connection object is retrieving data.")
                        Result.Write("Sending command to close the connection.")
                        Me.SqlCon.Close()
                        If Dispose = True Then
                            Me.SqlCon.Dispose()
                            Result.Write("Sending command to dispose of the object SqlCon.")
                        End If
                        If Me.SqlCon.State = ConnectionState.Closed Then
                            Result.Status = Status.Finished
                            Result.Write("The connection is closed.")
                        Else
                            Result.Status = Status.Broken
                            Result.Write("The connection will not close.")
                            Result.Why += ("The connection will not close.") & vbNewLine

                        End If
                    Else
                        Result.Write("Sending command to close the connection.")
                        Me.SqlCon.Close()
                        If Dispose = True Then
                            Me.SqlCon.Dispose()
                            Result.Write("Sending command to dispose of the object SqlCon.")
                        End If
                        If Me.SqlCon.State = ConnectionState.Closed Then
                            Result.Status = Status.Finished
                            Result.Write("The connection is closed.")
                        Else
                            Result.Status = Status.Broken
                            Result.Write("The connection will not close.")
                            Result.Why += ("The connection will not close.") & vbNewLine

                        End If
                    End If
                End If
            End If
            Return Result
        End Function
#End Region
#End Region
#End Region
#End Region
#Region "<5> [Runtime]"

#End Region
#Region "<7> [Loader]{3}"
#Region "<07.00> <Loader> [Empty]"
        Public Sub New()
            Clear()
        End Sub
#End Region
#Region "<07.01> <Loader> [File|Fichier][1]"
        Public Sub New(ByRef File As Fichier, Optional ByVal LongImport As Boolean = True)
            Clear()
            If Not IsNothing(File) Then
                With Me
                    .Target = File.Target
                End With
            End If
            Me.Line = New LineInfo(File)
            If Me.Line.Line <> "" Then
                Me.ConnectionStatus = Status.Online
            Else
                Me.ConnectionStatus = Status.Broken
            End If
            Me.Log = New TestItem(Me.FileName, "Initializing the DataBase")
            Me.Log.Add(Me.Line.Log)
            Try
                GetTables(LongImport)
            Catch ex As Exception

            End Try

        End Sub
#End Region
#Region "<07.02> <Loader> [FilePath|String,[Password]|String("")][4]"
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="FilePath"></param>
        ''' <param name="Password"></param>
        ''' <param name="Import">Import tables ?</param>
        ''' <param name="FastImport">Import tables without content. Each table will need to initialized later.</param>
        Public Sub New(ByVal FilePath As String, Optional ByVal Password As String = "", Optional ByVal Import As Boolean = True, Optional ByVal FastImport As Boolean = False)
            Clear()
            If IO.File.Exists(FilePath) Then
                With Me
                    .Target = FilePath
                End With
            End If
            Me.Line = New LineInfo(FilePath, Password)
            Me.Log = New TestItem(Me.FileName, "Initializing the DataBase")
            Me.Log.Add(Me.Line.Log)
            If Import = True Then

                Try
                    GetTables(If(FastImport = True, False, True))
                Catch ex As Exception

                End Try
            End If

        End Sub
#End Region
#End Region
    End Class
#End Region
#Region "|08.05| <Class> [Table]"
    Public Class Table
        Public Log As New TestItem
#Region "<1> [Property]"
#Region "<01.00> <Property> [Info]"
#Region "|2019/05/01 14h06:942| <01.00.00> <Property> <Info> [Call=TableName|String]"'(Set|Get) The name of the table.
        Private _TableName As String
        ''' <Summary>
        ''' The name of the table.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/01 14h06:941 </Published>
        ''' <Updated>[Created=2019/05/01 14h06:933][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Info"), Description("The name of the table."), Browsable(True)>
        Public Property TableName() As String
            Get
                Return _TableName
            End Get
            Set(ByVal Value As String)
                _TableName = Value
            End Set
        End Property
#End Region ' (Set|Get) The name of the table.
#Region "|2019/05/01 14h06:598| <01.00.01> <Property> <Info> [Call=FilePath|String]"'(Set|Get) The filepath to the database.
        Private _FilePath As String
        ''' <Summary>
        ''' The filepath to the database.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/01 14h06:598 </Published>
        ''' <Updated>[Created=2019/05/01 14h06:598][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Info"), Description("The filepath to the database."), Browsable(True)>
        Public Property FilePath() As String
            Get
                Return _FilePath
            End Get
            Set(ByVal Value As String)
                If IO.File.Exists(Value) Then
                    Me.Line = New LineInfo(Value)
                End If
                _FilePath = Value
            End Set
        End Property
#End Region ' (Set|Get) The filepath to the database.
#Region "|2019/05/01 14h07:746| <01.00.02> <Property> <Info> [Call=UseSQL|Boolean]"'(Set|Get) the Enable SQL format.
        Private _UseSQL As Boolean
        ''' <Summary>
        ''' (Set|Get) the Enable SQL format.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/01 14h07:745 </Published>
        ''' <Updated>[Created=2019/05/01 14h07:743][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Info"), Description("(Set|Get) the Enable SQL format."), Browsable(True)>
        Public Property UseSQL() As Boolean
            Get
                Return _UseSQL
            End Get
            Set(ByVal Value As Boolean)
                _UseSQL = Value
            End Set
        End Property
#End Region ' (Set|Get) the Enable SQL format.
#End Region
#Region "<01.01> <Property> [Index]"
#Region "|2019/05/01 14h10:884| <01.01.00> <Property> <Index> [Call=Columns|List(Of ColumnHeader)]"'(Set|Get) the ColumnsCount as List(Of DataColumn).
        Private _Columns As List(Of ColumnHeader)
        ''' <Summary>
        ''' (Set|Get) the ColumnsCount as List(Of ColumnHeader).
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/01 14h10:884 </Published>
        ''' <Updated>[Created=2019/05/01 14h10:884][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Index"), Description("(Set|Get) the ColumnsCount as List(Of ColumnHeader)."), Browsable(True)>
        Public Property Columns() As List(Of ColumnHeader)
            Get
                Return _Columns
            End Get
            Set(ByVal Value As List(Of ColumnHeader))
                _Columns = Value
            End Set
        End Property
#End Region ' (Set|Get) the ColumnsCount as List(Of ColumnHeader).
#Region "|2019/05/01 14h09:674| <01.01.01> <Property> <Index> [Call=Data|List(Of ListViewItem)]"'(Set|Get) the RowsCount as List(Of DataRow)
        Private _Data As List(Of ListViewItem)
        ''' <Summary>
        ''' (Set|Get) the RowsCount as List(Of ListViewItem)
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/01 14h09:674 </Published>
        ''' <Updated>[Created=2019/05/01 14h09:674][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Index"), Description("(Set|Get) the RowsCount as List(Of ListViewItem)"), Browsable(True)>
        Public Property Data() As List(Of ListViewItem)
            Get
                Return _Data
            End Get
            Set(ByVal Value As List(Of ListViewItem))
                _Data = Value
            End Set
        End Property
#End Region ' (Set|Get) the Rows as List(Of ListViewItem)
#Region "|2019/05/01 14h10:884| <01.01.02> <Property> <Index> [Call=ColumnsCount|Integer)]"'(Get) the ColumnsCount as Integer.
        Private _ColumnsCount As Integer
        ''' <Summary>
        ''' (Get) the ColumnsCount as Integer.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/01 14h10:884 </Published>
        ''' <Updated>[Created=2019/05/01 14h10:884][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Index"), Description("(Get) the ColumnsCount as Integer."), Browsable(True)>
        Public ReadOnly Property ColumnsCount() As Integer
            Get
                Return _ColumnsCount
            End Get
        End Property
#End Region ' (Get) the ColumnsCount as Integer.
#Region "|2019/05/01 14h10:884| <01.01.02> <Property> <Index> [Call=RowsCount|Integer)]"'(Get) the RowsCount as Integer.
        Private _RowsCount As Integer
        ''' <Summary>
        ''' (Get) the RowsCount as Integer.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/01 14h10:884 </Published>
        ''' <Updated>[Created=2019/05/01 14h10:884][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Index"), Description("(Get) the RowsCount as Integer."), Browsable(True)>
        Public ReadOnly Property RowsCount() As Integer
            Get
                Return _RowsCount
            End Get
        End Property
#End Region ' (Get) the RowsCount as Integer.
#End Region
#Region "<01.02> <Property> [Connection]"
#Region "|2019/05/01 14h11:610| <01.02.00> <Property> <Connection> [Call=Line|LineInfo]"'(Set|Get) Return the Connection String Line.
        Private _Line As LineInfo
        ''' <Summary>
        ''' Return the Connection String Line.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/01 14h11:610 </Published>
        ''' <Updated>[Created=2019/05/01 14h11:610][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Connection"), Description("Return the Connection String Line."), Browsable(True)>
        Public Property Line() As LineInfo
            Get
                Return _Line
            End Get
            Set(ByVal Value As LineInfo)
                _Line = Value
            End Set
        End Property
#End Region ' (Set|Get) Return the Connection String Line.
#Region "|2019/05/01 14h12:811| <01.02.01> <Property> <Connection> [Call=ConnectionStatus|Status]"'(Set|Get) Returns the Connection Line Status
        Private _ConnectionStatus As Status
        ''' <Summary>
        ''' Returns the Connection Line Status
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/01 14h12:810 </Published>
        ''' <Updated>[Created=2019/05/01 14h12:810][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Connection"), Description("Returns the Connection Line Status"), Browsable(True)>
        Public Property ConnectionStatus() As Status
            Get
                Return _ConnectionStatus
            End Get
            Set(ByVal Value As Status)
                _ConnectionStatus = Value
            End Set
        End Property
#End Region ' (Set|Get) Returns the Connection Line Status
#Region "|2019/05/01 14h12:048| <01.02.02> <Property> <Connection> [Call=Password|String]"'(Set|Get) Password needed to access the database.
        Private _Password As String
        ''' <Summary>
        ''' Password needed to access the database.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/01 14h12:048 </Published>
        ''' <Updated>[Created=2019/05/01 14h12:048][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Connection"), Description("Password needed to access the database."), Browsable(True)>
        Public Property Password() As String
            Get
                Return _Password
            End Get
            Set(ByVal Value As String)
                _Password = Value
            End Set
        End Property
#End Region ' (Set|Get) Password needed to access the database.
#End Region
#Region "<01.03> <Property> [TableObject]"
#Region "|2019/05/01 14h13:718| <01.03.00> <Property> <TableObject> [Call=DataTable|DataTable]"'(Set|Get) Represents one table of in-memory data.
        Private _DataTable As DataTable
        ''' <Summary>
        ''' Represents one table of in-memory data.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/01 14h13:718 </Published>
        ''' <Updated>[Created=2019/05/01 14h13:718][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("TableObject"), Description("Represents one table of in-memory data."), Browsable(True)>
        Public Property DataTable() As DataTable
            Get
                Return _DataTable
            End Get
            Set(ByVal Value As DataTable)
                _DataTable = Value
            End Set
        End Property
#End Region ' (Set|Get) Represents one table of in-memory data.
#Region "|2019/05/01 14h14:947| <01.03.01> <Property> <TableObject> [Call=TableMap|Common.DataTableMapping]"'(Set|Get) Contains a description of a mapped-relationship between a source table and a DataTable. This class is used by a Common.DataAdapter when populating a DataSet.
        Private _TableMap As Common.DataTableMapping
        ''' <Summary>
        ''' Contains a description of a mapped-relationship between a source table and a DataTable. This class is used by a Common.DataAdapter when populating a DataSet.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/01 14h14:946 </Published>
        ''' <Updated>[Created=2019/05/01 14h14:946][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("TableObject"), Description("Contains a description of a mapped-relationship between a source table and a DataTable. This class is used by a Common.DataAdapter when populating a DataSet."), Browsable(True)>
        Public Property TableMap() As Common.DataTableMapping
            Get
                Return _TableMap
            End Get
            Set(ByVal Value As Common.DataTableMapping)
                _TableMap = Value
            End Set
        End Property
#End Region ' (Set|Get) Contains a description of a mapped-relationship between a source table and a DataTable. This class is used by a Common.DataAdapter when populating a DataSet.
#Region "|2019/05/01 14h14:745| <01.03.02> <Property> <TableObject> [Call=DataSet|DataSet]"'(Set|Get) Represents a in-memory cache of data.
        Private _DataSet As DataSet
        ''' <Summary>
        ''' Represents a in-memory cache of data.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/01 14h14:744 </Published>
        ''' <Updated>[Created=2019/05/01 14h14:744][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("TableObject"), Description("Represents a in-memory cache of data."), Browsable(True)>
        Public Property DataSet() As DataSet
            Get
                Return _DataSet
            End Get
            Set(ByVal Value As DataSet)
                _DataSet = Value
            End Set
        End Property
#End Region ' (Set|Get) Represents a in-memory cache of data.
#End Region
#Region "<01.04> <Property> [OleDb]"
#Region "|2019/05/01 14h15:620| <01.04.00> <Property> <OleDb> [Call=Con|OleDb.OleDbConnection]"'(Set|Get) Represents an open connection to the datasource.
        Private _Con As OleDb.OleDbConnection
        ''' <Summary>
        ''' Represents an open connection to the datasource.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/01 14h15:620 </Published>
        ''' <Updated>[Created=2019/05/01 14h15:619][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("OleDb"), Description("Represents an open connection to the datasource."), Browsable(True)>
        Public Property Con() As OleDb.OleDbConnection
            Get
                Return _Con
            End Get
            Set(ByVal Value As OleDb.OleDbConnection)
                _Con = Value
            End Set
        End Property
#End Region ' (Set|Get) Represents an open connection to the datasource.
#Region "|2019/05/01 14h16:116| <01.04.01> <Property> <OleDb> [Call=Cmd|OleDb.OleDbCommand]"'(Set|Get) Represents a SQL statement or stored procedure to execute against a data source.
        Private _Cmd As OleDb.OleDbCommand
        ''' <Summary>
        ''' Represents a SQL statement or stored procedure to execute against a data source.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/01 14h16:116 </Published>
        ''' <Updated>[Created=2019/05/01 14h16:116][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("OleDb"), Description("Represents a SQL statement or stored procedure to execute against a data source."), Browsable(True)>
        Public Property Cmd() As OleDb.OleDbCommand
            Get
                Return _Cmd
            End Get
            Set(ByVal Value As OleDb.OleDbCommand)
                _Cmd = Value
            End Set
        End Property
#End Region ' (Set|Get) Represents a SQL statement or stored procedure to execute against a data source.
#Region "|2019/05/01 14h17:620| <01.04.02> <Property> <OleDb> [Call=OleDbReader|OleDb.OleDbDataReader]"'(Set|Get) Provides a way of reading a forward-only stream of data rows from a datasource. This class cannot be inherited.
        Private _OleDbReader As OleDb.OleDbDataReader
        ''' <Summary>
        ''' Provides a way of reading a forward-only stream of data rows from a datasource. This class cannot be inherited.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/01 14h17:619 </Published>
        ''' <Updated>[Created=2019/05/01 14h17:619][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("OleDb"), Description("Provides a way of reading a forward-only stream of data rows from a datasource. This class cannot be inherited."), Browsable(True)>
        Public Property OleDbReader() As OleDb.OleDbDataReader
            Get
                Return _OleDbReader
            End Get
            Set(ByVal Value As OleDb.OleDbDataReader)
                _OleDbReader = Value
            End Set
        End Property
#End Region ' (Set|Get) Provides a way of reading a forward-only stream of data rows from a datasource. This class cannot be inherited.
#Region "|2019/05/01 14h17:004| <01.04.03> <Property> <OleDb> [Call=OleDbData|OleDb.OleDbDataAdapter]"'(Set|Get) Represents a sets of data commands and a database connection that are used to fill the DataSet and update the datasource.
        Private _OleDbData As OleDb.OleDbDataAdapter
        ''' <Summary>
        ''' Represents a sets of data commands and a database connection that are used to fill the DataSet and update the datasource.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/01 14h17:004 </Published>
        ''' <Updated>[Created=2019/05/01 14h17:004][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("OleDb"), Description("Represents a sets of data commands and a database connection that are used to fill the DataSet and update the datasource."), Browsable(True)>
        Public Property OleDbData() As OleDb.OleDbDataAdapter
            Get
                Return _OleDbData
            End Get
            Set(ByVal Value As OleDb.OleDbDataAdapter)
                _OleDbData = Value
            End Set
        End Property
#End Region ' (Set|Get) Represents a sets of data commands and a database connection that are used to fill the DataSet and update the datasource.
#End Region
#Region "<01.05> <Property> [SQL]"
#Region "|2019/05/01 14h18:675| <01.05.00> <Property> <SQL> [Call=SqlCon|SqlClient.SqlConnection]"'(Set|Get) Represents an open connection to a SQL Server DataBase. This Class cannot be inherited.
        Private _SqlCon As SqlClient.SqlConnection
        ''' <Summary>
        ''' Represents an open connection to a SQL Server DataBase. This Class cannot be inherited.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/01 14h18:675 </Published>
        ''' <Updated>[Created=2019/05/01 14h18:675][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("SQL"), Description("Represents an open connection to a SQL Server DataBase. This Class cannot be inherited."), Browsable(True)>
        Public Property SqlCon() As SqlClient.SqlConnection
            Get
                Return _SqlCon
            End Get
            Set(ByVal Value As SqlClient.SqlConnection)
                _SqlCon = Value
            End Set
        End Property
#End Region ' (Set|Get) Represents an open connection to a SQL Server DataBase. This Class cannot be inherited.
#Region "|2019/05/01 14h18:614| <01.05.01> <Property> <SQL> [Call=SqlCmd|SqlClient.SqlCommand]"'(Set|Get) Represents a Transact-SQL statement or store procedure to execute against a SQL Server dataBase. This class cannot be inherited.
        Private _SqlCmd As SqlClient.SqlCommand
        ''' <Summary>
        ''' Represents a Transact-SQL statement or store procedure to execute against a SQL Server dataBase. This class cannot be inherited.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/01 14h18:614 </Published>
        ''' <Updated>[Created=2019/05/01 14h18:614][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("SQL"), Description("Represents a Transact-SQL statement or store procedure to execute against a SQL Server dataBase. This class cannot be inherited."), Browsable(True)>
        Public Property SqlCmd() As SqlClient.SqlCommand
            Get
                Return _SqlCmd
            End Get
            Set(ByVal Value As SqlClient.SqlCommand)
                _SqlCmd = Value
            End Set
        End Property
#End Region ' (Set|Get) Represents a Transact-SQL statement or store procedure to execute against a SQL Server dataBase. This class cannot be inherited.
#Region "|2019/05/01 14h19:174| <01.05.02> <Property> <SQL> [Call=SqlReader|SqlClient.SqlDataReader]"'(Set|Get) Provides a way of reading a forward-only stream of rows from a SQL Server database. This class cannot be inherited.
        Private _SqlReader As SqlClient.SqlDataReader
        ''' <Summary>
        ''' Provides a way of reading a forward-only stream of rows from a SQL Server database. This class cannot be inherited.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/01 14h19:174 </Published>
        ''' <Updated>[Created=2019/05/01 14h19:174][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("SQL"), Description("Provides a way of reading a forward-only stream of rows from a SQL Server database. This class cannot be inherited."), Browsable(True)>
        Public Property SqlReader() As SqlClient.SqlDataReader
            Get
                Return _SqlReader
            End Get
            Set(ByVal Value As SqlClient.SqlDataReader)
                _SqlReader = Value
            End Set
        End Property
#End Region ' (Set|Get) Provides a way of reading a forward-only stream of rows from a SQL Server database. This class cannot be inherited.
#Region "|2019/05/01 14h19:136| <01.05.03> <Property> <SQL> [Call=SqlData|SqlClient.SqlDataAdapter]"'(Set|Get) Represents a set of data commands and a database connection that are used to fill and update a SQL Server database.This class cannot be inherited.
        Private _SqlData As SqlClient.SqlDataAdapter
        ''' <Summary>
        ''' Represents a set of data commands and a database connection that are used to fill and update a SQL Server database.This class cannot be inherited.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/01 14h19:136 </Published>
        ''' <Updated>[Created=2019/05/01 14h19:136][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("SQL"), Description("Represents a set of data commands and a database connection that are used to fill and update a SQL Server database.This class cannot be inherited."), Browsable(True)>
        Public Property SqlData() As SqlClient.SqlDataAdapter
            Get
                Return _SqlData
            End Get
            Set(ByVal Value As SqlClient.SqlDataAdapter)
                _SqlData = Value
            End Set
        End Property
#End Region ' (Set|Get) Represents a set of data commands and a database connection that are used to fill and update a SQL Server database.This class cannot be inherited.
#End Region
#End Region
#Region "<2> [Enumeration]"

#End Region
#Region "<3> [Structures]"

#End Region
#Region "<4> [Sub]"
#Region "<04.00> <Sub> [Initialize]"
#Region "<04.00.00> <Sub> <Initialize> [InitializeConnection(FilePath|String,Password|String)"
        ''' <summary>
        ''' First step to gather connection information and to validate the Line Info.
        ''' </summary>
        ''' <param name="FilePath">The FilePath must be valid.</param>
        ''' <param name="Password">Optional this password will be stored in Me.Password settings provided that the FilePath Parameter is conclusive.</param>
        Public Sub InitializeConnection(ByVal FilePath As String,
                               Optional ByVal Password As String = "", Optional ByVal Import As Boolean = True)
            If IO.File.Exists(FilePath) Then
                Me.FilePath = FilePath
                Me.Password = Password
                Me.Line = New LineInfo(FilePath, Password)
                Me.Import(Import)
            Else
                ' MsgBox("The file does not exist")

            End If
            Me.Line = New LineInfo(FilePath, Password)

        End Sub
#End Region
#End Region
#Region "<04.00> <Sub> [Table]"
#Region "<04.00.00> <Sub> <Table> [Import()]"
        ''' <summary>
        ''' Importation of all the data in the table.
        ''' </summary>
        Public Sub Import(Optional ByVal CreateListViewItem As Boolean = True)
            If Not IsNothing(Me.Line) Then
                With Me
                    .Data = New List(Of ListViewItem)
                    .Columns = New List(Of ColumnHeader)
                End With
                Dim SqlCommand As String = "Select * From [" & Me.TableName & "]"
                If Me.Line.DataBaseFormat = DataBaseType.Dbf Then
                    SqlCommand += IO.Path.GetDirectoryName(Me.FilePath)
                Else
                    SqlCommand += Me.TableName
                End If
                Try
                    Open(SqlCommand)
                    If Me.Line.DataBaseFormat = DataBaseType.Sql Then
                        Me.DataTable.Load(SqlCmd.ExecuteReader)
                        Me.DataSet.Tables.Add(Me.DataTable.Clone)
                    Else
                        Me.DataTable.Load(Cmd.ExecuteReader)
                        Me.DataSet.Tables.Add(Me.DataTable.Clone)
                    End If
                Catch ex As Exception
                    'MsgBox(ex.Message)
                Finally
                    Close()
                End Try
                Me._ColumnsCount = Me.DataTable.Columns.Count
                Me._RowsCount = Me.DataTable.Rows.Count
                If CreateListViewItem = True Then

                    If Me.DataTable.Columns.Count - 1 > 0 Then
                        For C = 0 To Me.DataTable.Columns.Count - 1
                            Dim Col As New ColumnHeader
                            With Col
                                .Text = Me.DataTable.Columns(C).ColumnName
                                .Name = .Text
                                .Width = Me.DataTable.Columns(C).MaxLength
                            End With
                            Me.Columns.Add(Col)
                        Next
                    End If
                    If Me.DataTable.Rows.Count - 1 > 0 Then
                        For Each Row As DataRow In Me.DataTable.Rows
                            Dim Item As New ListViewItem(Row(0).ToString)
                            For i = 1 To Me.DataTable.Columns.Count - 1
                                Item.SubItems.Add(Row(i).ToString)
                                'Item.SubItems.Add(Row(i).ToString)
                                Item.SubItems(Item.SubItems.Count - 1).Name = Row(i).ToString
                            Next
                            Item.Name = Row(0).ToString
                            Me.Data.Add(Item)
                        Next
                    End If
                End If
            End If
        End Sub
#End Region
#End Region
#End Region
#Region "<5> [Function]"
#Region "<05.00> <Function> [Table]"
#Region "<05.00.00> <Function> <Table> []"

#End Region
#End Region
#Region "<05.02> <Function> [Operation]"
#Region "<05.02.00> <Function> <Operation> [Open]"
#Region "<05.02.00.00> <Function> <Operation> <Open> [Open()]"
        ''' <summary>
        ''' Opening the Connection
        ''' </summary>
        ''' <returns></returns>
        Public Function Open() As TestItem
            Dim Result As New TestItem("Open", PrintTime() & " Openning the connection ligne to the Table.")
            'Result.AddParam("Me.Line", Me.Line, Me.Line.ToString)
            If Not IsNothing(Me.Line) Then
                If Me.Line.ToString <> "" Then
                    If Me.UseSQL = True Then
                        Me.SqlCon = New SqlClient.SqlConnection(Me.Line.ToString)
                        If IsNothing(Me.SqlCmd) Then
                            Me.SqlCmd = New SqlClient.SqlCommand
                        End If
                        Me.SqlCmd.Connection = Me.SqlCon
                        If Me.SqlCon.State = ConnectionState.Open Then
                        Else
                            Try
                                Me.SqlCon.Open()
                                Me.ConnectionStatus = Status.Running
                                Result.Status = Status.Online
                            Catch ex As Exception
                                Result.AddBug(ex, "Error while opening Table", "Me.SqlCon.Open()")
                                Me.ConnectionStatus = Status.Broken
                                Result.Status = Status.Broken
                            End Try
                        End If
                    Else
                        Me.Con = New OleDb.OleDbConnection(Me.Line.ToString)
                        If IsNothing(Me.Cmd) Then
                            Me.Cmd = New OleDb.OleDbCommand
                        End If
                        Me.Cmd.Connection = Me.Con
                        If Me.Con.State = ConnectionState.Open Then
                        Else
                            Try
                                Me.Con.Open()
                                Me.ConnectionStatus = Status.Running
                                Result.Status = Status.Online
                            Catch ex As Exception
                                Result.AddBug(ex, "Error while opening database", "Me.Con.Open()")
                                Me.ConnectionStatus = Status.Broken
                                Result.Status = Status.Broken
                            End Try
                        End If
                    End If
                End If
            Else
                Result.Status = Status.Broken
                Result.Why += "The connection line has not been initialized."
            End If
            If IsNothing(Me.Log) Then
                Me.Log = New TestItem("Table(" & Me.TableName & ")", "Configuration of the Table.")
            End If
            If IsNothing(Me.Log.Results) Then
                Me.Log.Results = New List(Of TestItem)
            End If
            Me.Log.Results.Add(Result)
            Return Result
        End Function
#End Region
#Region "<05.02.00.01> <Function> <Operation> <Open> [Open(SqlCommand|String)]"
        ''' <summary>
        ''' Open the connection String with SqlCommand
        ''' </summary>
        ''' <param name="SqlCommand"></param>
        ''' <returns></returns>
        Public Function Open(ByVal SqlCommand As String) As TestItem
            Dim Result As New TestItem("Open(" & SqlCommand & ")", PrintTime() & " Openning the connection ligne to the Table.")
            ' 'Result.AddParam("Me.Line", Me.Line, Me.Line.ToString)
            '  'Result.AddParam("SqlCommand", SqlCommand, SqlCommand)
            If Not IsNothing(Me.Line) Then
                If Me.Line.ToString <> "" Then
                    If Me.UseSQL = True Then
                        Me.SqlCon = New SqlClient.SqlConnection(Me.Line.ToString)
                        If IsNothing(Me.SqlCmd) Then
                            Me.SqlCmd = New SqlClient.SqlCommand
                        End If
                        Me.SqlCmd.Connection = Me.SqlCon
                        Me.SqlCmd.CommandText = SqlCommand
                        If Me.SqlCon.State = ConnectionState.Open Then
                        Else
                            Try
                                Me.SqlCon.Open()
                                Me.ConnectionStatus = Status.Running
                                Result.Status = Status.Online
                            Catch ex As Exception
                                Result.AddBug(ex, "Error while opening database", "Me.SqlCon.Open()")
                                Me.ConnectionStatus = Status.Broken
                                Result.Status = Status.Broken
                            End Try
                        End If
                    Else
                        Me.Con = New OleDb.OleDbConnection(Me.Line.ToString)
                        If IsNothing(Me.Cmd) Then
                            Me.Cmd = New OleDb.OleDbCommand
                        End If
                        Me.Cmd.Connection = Me.Con
                        Me.Cmd.CommandText = SqlCommand
                        If Me.Con.State = ConnectionState.Open Then
                        Else
                            Try
                                Me.Con.Open()
                                Me.ConnectionStatus = Status.Running
                                Result.Status = Status.Online
                            Catch ex As Exception
                                Result.AddBug(ex, "Error while opening Table", "Me.Con.Open()")
                                Me.ConnectionStatus = Status.Broken
                                Result.Status = Status.Broken
                            End Try
                        End If
                    End If
                End If
            Else
                Result.Status = Status.Broken
                Result.Why += "The connection line has not been initialized."
            End If
            If IsNothing(Me.Log) Then
                Me.Log = New TestItem("Table(" & Me.TableName & ")", "Configuration of the Table.")
            End If
            If IsNothing(Me.Log.Results) Then
                Me.Log.Results = New List(Of TestItem)
            End If
            Me.Log.Results.Add(Result)
            Return Result
        End Function
#End Region
#End Region
#Region "<05.02.01> <Function> <Operation> [Close]"
#Region "<05.02.01.00> <Function> <Operation> <Close> [Close([Dispose]|Boolean(True))|TestItem]"
        ''' <summary>
        ''' Closing the connection
        ''' </summary>
        ''' <param name="Dispose"></param>
        ''' <returns></returns>
        Public Function Close(Optional ByVal Dispose As Boolean = True) As TestItem
            Dim Result As New TestItem("Closing Db", "Closing the Table connection.")
            If Not IsNothing(Me.Line) Then
                Result.Write("The line is configured")
                If Not IsNothing(Me.Con) Then
                    Result.Write("Con Exist")
                    If Me.Con.State = ConnectionState.Closed Then
                        Result.Write("Con is already close. No further action required. Mission accomplished.")
                        Result.Status = Status.Finished
                    ElseIf Me.Con.State = ConnectionState.Broken Then
                        Result.Write("Con is broken.")
                        Result.Why += ("The connection to the data source is broken. This can occur only after the connection") & vbNewLine
                        Result.Why += ("has been opened. A connection in this state may be closed and then re-opened.") & vbNewLine
                        Result.Status = Status.Broken
                    ElseIf Me.Con.State = ConnectionState.Connecting Then
                        Result.Write("The connection object is connecting to the data source.")
                        Result.Write("Sending command to close the connection.")
                        Me.Con.Close()
                        If Dispose = True Then
                            Me.Con.Dispose()
                            Result.Write("Sending command to dispose of the object Con.")
                        End If
                        If Me.Con.State = ConnectionState.Closed Then
                            Result.Status = Status.Finished
                            Result.Write("The connection is closed.")
                        Else
                            Result.Status = Status.Broken
                            Result.Write("The connection will not close.")
                            Result.Why += ("The connection will not close.") & vbNewLine

                        End If
                    ElseIf Me.Con.State = ConnectionState.Executing Then
                        Result.Write("The connection object is executing a command.")
                        Result.Write("Sending command to close the connection.")
                        Me.Con.Close()
                        If Dispose = True Then
                            Me.Con.Dispose()
                            Result.Write("Sending command to dispose of the object Con.")
                        End If
                        If Me.Con.State = ConnectionState.Closed Then
                            Result.Status = Status.Finished
                            Result.Write("The connection is closed.")
                        Else
                            Result.Status = Status.Broken
                            Result.Write("The connection will not close.")
                            Result.Why += ("The connection will not close.") & vbNewLine

                        End If
                    ElseIf Me.Con.State = ConnectionState.Fetching Then
                        Result.Write("The connection object is retrieving data.")
                        Result.Write("Sending command to close the connection.")
                        Me.Con.Close()
                        If Dispose = True Then
                            Me.Con.Dispose()
                            Result.Write("Sending command to dispose of the object Con.")
                        End If
                        If Me.Con.State = ConnectionState.Closed Then
                            Result.Status = Status.Finished
                            Result.Write("The connection is closed.")
                        Else
                            Result.Status = Status.Broken
                            Result.Write("The connection will not close.")
                            Result.Why += ("The connection will not close.") & vbNewLine

                        End If
                    Else
                        Result.Write("Sending command to close the connection.")
                        Me.Con.Close()
                        If Dispose = True Then
                            Me.Con.Dispose()
                            Result.Write("Sending command to dispose of the object Con.")
                        End If
                        If Me.Con.State = ConnectionState.Closed Then
                            Result.Status = Status.Finished
                            Result.Write("The connection is closed.")
                        Else
                            Result.Status = Status.Broken
                            Result.Write("The connection will not close.")
                            Result.Why += ("The connection will not close.") & vbNewLine

                        End If
                    End If
                End If
                If Not IsNothing(Me.SqlCon) Then
                    Result.Write("SqlCon Exist")
                    If Me.SqlCon.State = ConnectionState.Closed Then
                        Result.Write("SqlCon is already close. No further action required. Mission accomplished.")
                        Result.Status = Status.Finished
                    ElseIf Me.SqlCon.State = ConnectionState.Broken Then
                        Result.Write("SqlCon is broken.")
                        Result.Why += ("The connection to the data source is broken. This can occur only after the connection") & vbNewLine
                        Result.Why += ("has been opened. A connection in this state may be closed and then re-opened.") & vbNewLine
                        Result.Status = Status.Broken
                    ElseIf Me.SqlCon.State = ConnectionState.Connecting Then
                        Result.Write("The connection object is connecting to the data source.")
                        Result.Write("Sending command to close the connection.")
                        Me.SqlCon.Close()
                        If Dispose = True Then
                            Me.SqlCon.Dispose()
                            Result.Write("Sending command to dispose of the object SqlCon.")
                        End If
                        If Me.SqlCon.State = ConnectionState.Closed Then
                            Result.Status = Status.Finished
                            Result.Write("The connection is closed.")
                        Else
                            Result.Status = Status.Broken
                            Result.Write("The connection will not close.")
                            Result.Why += ("The connection will not close.") & vbNewLine

                        End If
                    ElseIf Me.SqlCon.State = ConnectionState.Executing Then
                        Result.Write("The connection object is executing a command.")
                        Result.Write("Sending command to close the connection.")
                        Me.SqlCon.Close()
                        If Dispose = True Then
                            Me.SqlCon.Dispose()
                            Result.Write("Sending command to dispose of the object SqlCon.")
                        End If
                        If Me.SqlCon.State = ConnectionState.Closed Then
                            Result.Status = Status.Finished
                            Result.Write("The connection is closed.")
                        Else
                            Result.Status = Status.Broken
                            Result.Write("The connection will not close.")
                            Result.Why += ("The connection will not close.") & vbNewLine

                        End If
                    ElseIf Me.SqlCon.State = ConnectionState.Fetching Then
                        Result.Write("The connection object is retrieving data.")
                        Result.Write("Sending command to close the connection.")
                        Me.SqlCon.Close()
                        If Dispose = True Then
                            Me.SqlCon.Dispose()
                            Result.Write("Sending command to dispose of the object SqlCon.")
                        End If
                        If Me.SqlCon.State = ConnectionState.Closed Then
                            Result.Status = Status.Finished
                            Result.Write("The connection is closed.")
                        Else
                            Result.Status = Status.Broken
                            Result.Write("The connection will not close.")
                            Result.Why += ("The connection will not close.") & vbNewLine

                        End If
                    Else
                        Result.Write("Sending command to close the connection.")
                        Me.SqlCon.Close()
                        If Dispose = True Then
                            Me.SqlCon.Dispose()
                            Result.Write("Sending command to dispose of the object SqlCon.")
                        End If
                        If Me.SqlCon.State = ConnectionState.Closed Then
                            Result.Status = Status.Finished
                            Result.Write("The connection is closed.")
                        Else
                            Result.Status = Status.Broken
                            Result.Write("The connection will not close.")
                            Result.Why += ("The connection will not close.") & vbNewLine

                        End If
                    End If
                End If
            End If
            Return Result
        End Function
#End Region
#End Region
#End Region
        Public Overrides Function ToString() As String
            If IsNothing(Me.Line) Then
                Return Me.TableName
            Else
                Return Me.TableName & "[" & Me.ColumnsCount & "|" & Me.RowsCount & "]"
            End If
        End Function
#End Region
#Region "<6> [Loader]"
#Region "<06.00> <Loader> [Empty]"
        ''' <summary>
        ''' Open a new class and clear data.
        ''' </summary>
        Public Sub New()
            With Me
                .Cmd = New OleDb.OleDbCommand
                .Columns = New List(Of ColumnHeader)
                .Con = New OleDb.OleDbConnection
                .ConnectionStatus = Status.IsNothing
                .DataSet = New DataSet
                .DataTable = New DataTable
                .FilePath = ""
                .Line = New LineInfo
                .TableName = "Table1"
                .OleDbData = New OleDb.OleDbDataAdapter
                .Password = ""
                .Data = New List(Of ListViewItem)
                .SqlCmd = New SqlClient.SqlCommand
                .SqlCon = New SqlClient.SqlConnection
                .SqlData = New SqlClient.SqlDataAdapter
                .TableMap = New Common.DataTableMapping
                .UseSQL = False
            End With
        End Sub
#End Region
#Region "<06.01> <Loader> [TableName|String]"
        ''' <summary>
        ''' Opening a new Table without connection
        ''' </summary>
        ''' <param name="TableName"></param>
        Public Sub New(ByVal TableName As String)
            With Me
                .Cmd = New OleDb.OleDbCommand
                .Columns = New List(Of ColumnHeader)
                .Con = New OleDb.OleDbConnection
                .ConnectionStatus = Status.IsNothing
                .DataSet = New DataSet
                .DataTable = New DataTable
                .FilePath = ""
                .Line = New LineInfo
                .TableName = IIf(TableName <> "", TableName, "Table1")
                .OleDbData = New OleDb.OleDbDataAdapter
                .Password = ""
                .Data = New List(Of ListViewItem)
                .SqlCmd = New SqlClient.SqlCommand
                .SqlCon = New SqlClient.SqlConnection
                .SqlData = New SqlClient.SqlDataAdapter
                .TableMap = New Common.DataTableMapping
                .UseSQL = False
            End With
        End Sub
#End Region
#Region "<06.02> <Loader> [TableName|String,DataBase|DataBase]"
        ''' <summary>
        ''' Opening a new Table with DataBase connection
        ''' </summary>
        ''' <param name="TableName"></param>
        Public Sub New(ByVal TableName As String, ByVal DataBase As DataBase, Optional ByVal Import As Boolean = True)
            If Not IsNothing(DataBase) Then
                If DataBase.Exists = True Then
                    With Me
                        .Columns = New List(Of ColumnHeader)
                        .DataSet = New DataSet
                        .DataTable = New DataTable
                        .FilePath = DataBase.Target
                        .Line = New LineInfo(DataBase)
                        If Me.Line.DataBaseFormat = DataBaseType.Sql Then
                            .SqlCon = New SqlClient.SqlConnection(Me.Line.ToString)
                            .SqlCmd = New SqlClient.SqlCommand
                            .SqlData = New SqlClient.SqlDataAdapter
                            .UseSQL = True
                        Else
                            .Con = New OleDb.OleDbConnection(Me.Line.ToString)
                            .Cmd = New OleDb.OleDbCommand
                            .OleDbData = New OleDb.OleDbDataAdapter
                            .UseSQL = False
                        End If
                        .TableName = IIf(TableName <> "", TableName, "Table1")
                        .Password = DataBase.Password
                        .Data = New List(Of ListViewItem)
                        .TableMap = New Common.DataTableMapping
                    End With
                    InitializeConnection(Me.FilePath, Me.Password, Import)
                Else
                    With Me
                        .Columns = New List(Of ColumnHeader)
                        .DataSet = New DataSet
                        .DataTable = New DataTable
                        .FilePath = ""
                        .Line = New LineInfo(DataBase)
                        .TableName = IIf(TableName <> "", TableName, "Table1")
                        .Password = DataBase.Password
                        .Data = New List(Of ListViewItem)
                        If Me.Line.DataBaseFormat = DataBaseType.Sql Then
                            .SqlCon = New SqlClient.SqlConnection(Me.Line.ToString)
                            .SqlCmd = New SqlClient.SqlCommand
                            .SqlData = New SqlClient.SqlDataAdapter
                            .UseSQL = True
                        Else
                            .Con = New OleDb.OleDbConnection(Me.Line.ToString)
                            .Cmd = New OleDb.OleDbCommand
                            .OleDbData = New OleDb.OleDbDataAdapter
                            .UseSQL = False
                        End If
                        .TableMap = New Common.DataTableMapping
                    End With
                End If
            End If
        End Sub
#End Region
#Region "<06.03> <Loader> [TableName|String,FilePath|String,[Password]|String("")]"
        '''  <summary>
        ''' Opening a new Table with DataBase connection
        ''' </summary>
        ''' <param name="TableName">The name of the table</param>
        ''' <param name="FilePath">The File path</param>
        ''' <param name="Password">The password use to set the line connection to the database.</param>
        Public Sub New(ByVal TableName As String, ByVal FilePath As String, Optional ByVal Password As String = "", Optional ByVal Import As Boolean = True)
            If IO.File.Exists(FilePath) Then
                With Me
                    .Columns = New List(Of ColumnHeader)
                    .DataSet = New DataSet
                    .DataTable = New DataTable
                    .FilePath = FilePath
                    .Password = Password
                    .Line = New LineInfo(FilePath, Password)
                    If Me.Line.DataBaseFormat = DataBaseType.Sql Then
                        .SqlCon = New SqlClient.SqlConnection(Me.Line.ToString)
                        .SqlCmd = New SqlClient.SqlCommand
                        .SqlData = New SqlClient.SqlDataAdapter
                        .UseSQL = True
                    Else
                        .Con = New OleDb.OleDbConnection(Me.Line.ToString)
                        .Cmd = New OleDb.OleDbCommand
                        .OleDbData = New OleDb.OleDbDataAdapter
                        .UseSQL = False
                    End If
                    .TableName = IIf(TableName <> "", TableName, "Table1")
                    .Data = New List(Of ListViewItem)
                    .TableMap = New Common.DataTableMapping
                    InitializeConnection(Me.FilePath, Me.Password, Import)

                End With
            Else
                With Me
                    .Columns = New List(Of ColumnHeader)
                    .DataSet = New DataSet
                    .DataTable = New DataTable
                    .FilePath = ""
                    .Line = New LineInfo(FilePath, Password)
                    .TableName = IIf(TableName <> "", TableName, "Table1")
                    .Password = Password
                    .Data = New List(Of ListViewItem)
                    If Me.Line.DataBaseFormat = DataBaseType.Sql Then
                        .SqlCon = New SqlClient.SqlConnection(Me.Line.ToString)
                        .SqlCmd = New SqlClient.SqlCommand
                        .SqlData = New SqlClient.SqlDataAdapter
                        .UseSQL = True
                    ElseIf Me.Line.DataBaseFormat <> DataBaseType.Nothing Then
                        .Con = New OleDb.OleDbConnection(Me.Line.ToString)
                        .Cmd = New OleDb.OleDbCommand
                        .OleDbData = New OleDb.OleDbDataAdapter
                        .UseSQL = False
                    Else

                    End If
                    .TableMap = New Common.DataTableMapping
                End With
            End If
        End Sub
#End Region
#End Region
#Region "<7> [Runtime]"

#End Region
#Region "<8> [Class]"

#End Region
    End Class
#End Region
#Region "|08.06| <Class> [LineInfo]"
    ''' <summary>
    ''' This class enable one to manage database type object.
    ''' <Production Price>131 CHF</Production>
    ''' <Quantity> 07    Properties @9 =   63
    '''            01    Functions  @12 =  12
    '''            03    Loader     @10 =  30
    '''            13    Parameters @2  =  26
    '''  Total :   24                   = 131.-
    ''' </Quantity>
    ''' </summary>
    Public Class LineInfo
#Region "<1> [Property]{7}"
#Region "<01.00> <Property> [Info]{6}"
#Region "|2019/05/01 16h18:524| <01.00.00> <Property> <Info> [Call=FilePath|String]"'(Set|Get) The filePath as string.
        Private _FilePath As String
        ''' <Summary>
        ''' The filePath as string.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/01 16h18:524 </Published>
        ''' <Updated>[Created=2019/05/01 16h18:524][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Info"), Description("The filePath as string."), Browsable(True)>
        Public Property FilePath() As String
            Get
                Return _FilePath
            End Get
            Set(ByVal Value As String)
                _FilePath = Value
            End Set
        End Property
#End Region ' (Set|Get) The filePath as string.
#Region "|2019/05/01 16h19:323| <01.00.01> <Property> <Info> [Call=Password|String]"'(Set|Get) The password for the connection as string.
        Private _Password As String
        ''' <Summary>
        ''' The password for the connection as string.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/01 16h19:323 </Published>
        ''' <Updated>[Created=2019/05/01 16h19:323][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Info"), Description("The password for the connection as string."), Browsable(True)>
        Public Property Password() As String
            Get
                Return _Password
            End Get
            Set(ByVal Value As String)
                _Password = Value
            End Set
        End Property
#End Region ' (Set|Get) The password for the connection as string.
#Region "|2019/05/01 16h20:290| <01.00.02> <Property> <Info> [Call=DataBaseFormat|DataBaseType]"'(Set|Get) the DataBaseFormat as DataBaseType.
        Private _DataBaseFormat As DataBaseType
        ''' <Summary>
        ''' (Set|Get) the DataBaseFormat as DataBaseType.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/01 16h20:290 </Published>
        ''' <Updated>[Created=2019/05/01 16h20:290][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Info"), Description("(Set|Get) the DataBaseFormat as DataBaseType."), DefaultValue("DataBaseType.[Nothing]"), Browsable(True)>
        Public Property DataBaseFormat() As DataBaseType
            Get
                Return _DataBaseFormat
            End Get
            Set(ByVal Value As DataBaseType)
                _DataBaseFormat = Value
            End Set
        End Property
#End Region ' (Set|Get) the DataBaseFormat as DataBaseType.
#Region "|2019/05/01 16h21:344| <01.00.03> <Property> <Info> [Call=Line|String]"'(Set|Get) the Line as String.
        Private _Line As String
        ''' <Summary>
        ''' (Set|Get) the Line as String.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/01 16h21:344 </Published>
        ''' <Updated>[Created=2019/05/01 16h21:344][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Info"), Description("(Set|Get) the Line as String."), Browsable(True)>
        Public Property Line() As String
            Get
                Return _Line
            End Get
            Set(ByVal Value As String)
                _Line = Value
            End Set
        End Property
#End Region ' (Set|Get) the Line as String.
#Region "|2019/05/01 16h27:858| <01.00.04> <Property> <Info> [Call=Status|Status]"'(Set|Get) the Status as Status.
        Private _Status As Status
        ''' <Summary>
        ''' (Set|Get) the Status as Status.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/01 16h27:858 </Published>
        ''' <Updated>[Created=2019/05/01 16h27:858][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Info"), Description("(Set|Get) the Status as Status."), Browsable(True)>
        Public Property Status() As Status
            Get
                Return _Status
            End Get
            Set(ByVal Value As Status)
                _Status = Value
            End Set
        End Property
#End Region ' (Set|Get) the Status as Status.
#Region "|2019/05/01 16h28:066| <01.00.05> <Property> <Info> [Call=Log|TestItem]"'(Set|Get) the Log as TestItem.
        Private _Log As TestItem
        ''' <Summary>
        ''' (Set|Get) the Log as TestItem.
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/01 16h28:066 </Published>
        ''' <Updated>[Created=2019/05/01 16h28:066][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Info"), Description("(Set|Get) the Log as TestItem."), Browsable(True)>
        Public Property Log() As TestItem
            Get
                Return _Log
            End Get
            Set(ByVal Value As TestItem)
                _Log = Value
            End Set
        End Property
#End Region ' (Set|Get) the Log as TestItem.
#End Region
#Region "<01.01> <Property> [Constructor]{1}"
#Region "|2019/05/01 16h50:412| <01.01.00> <Property> <Constructor> [Call=OleDbBuilder|OleDb.OleDbConnectionStringBuilder]"'(Set|Get) the OleDbBuilder as OleDb.OleDbConnectionStringBuilder
        Private _OleDbBuilder As OleDb.OleDbConnectionStringBuilder
        ''' <Summary>
        ''' (Set|Get) the OleDbBuilder as OleDb.OleDbConnectionStringBuilder
        ''' </Summary>
        ''' <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        ''' <AuthorName>Saadry Dunkel Consultant</AuthorName>
        ''' <AuthorUri>http://www.saadry-dunkel.com</AuthorUri>
        ''' <Published>MASTER From MASTER\Saadry | Time : 2019/05/01 16h50:412 </Published>
        ''' <Updated>[Created=2019/05/01 16h50:411][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>

        <CategoryAttribute("Constructor"), Description("(Set|Get) the OleDbBuilder as OleDb.OleDbConnectionStringBuilder"), Browsable(True)>
        Public Property OleDbBuilder() As OleDb.OleDbConnectionStringBuilder
            Get
                Return _OleDbBuilder
            End Get
            Set(ByVal Value As OleDb.OleDbConnectionStringBuilder)
                _OleDbBuilder = Value
            End Set
        End Property
#End Region ' (Set|Get) the OleDbBuilder as OleDb.OleDbConnectionStringBuilder
#End Region
#End Region
#Region "<6> [Function]{1}"
#Region "<06.00> <Function> [ToString]"
        Public Overrides Function ToString() As String
            Return Me.Line
        End Function
#End Region
#End Region
#Region "<7> [Loader]{3}"
#Region "<07.00> <Loader> [Empty]"
        Public Sub New()
            With Me
                .Line = ""
                .Log = New TestItem("NewLineInfo", "[Warning no parametters have been set]")
                .Password = ""
                .DataBaseFormat = DataBaseType.Nothing
                .FilePath = ""
                .Status = Status.IsNothing
            End With
        End Sub
#End Region
#Region "<07.01> <Loader> [File|Fichier]"
        Public Sub New(ByRef File As Fichier)
            With Me
                If Not IsNothing(File) Then
                    If File.Exists = True Then
                        Me.Password = File.Password
                        Me.FilePath = File.Target
                    End If
                End If
                If IO.File.Exists(.FilePath) Then
                    Dim Fi As New Fichier(.FilePath, .Password)
                    .Log = New TestItem(Fi.FileName & ".Line", "New LineInformation.")
                    If Fi.Extension.ToLower.Contains("accdb") Then
#Region "|Microsoft Access 2010+|{Accdb}"
                        .DataBaseFormat = DataBaseType.Accdb
                        .Log.WriteToHypothesis("The format is of type Microsoft Access 2010.")
                        Dim ConnectionSetting As New TestItem("ConnectionSetting", "Evaluate all parameters needed to set the connection.")
                        ConnectionSetting.AddParam("FilePath", Me.FilePath, Me.FilePath)
                        ConnectionSetting.WriteToHypothesis("[FilePath]=" & Me.FilePath)
                        ConnectionSetting.AddParam("DataBaseFormat", Me.DataBaseFormat, Me.DataBaseFormat.ToString)
                        ConnectionSetting.WriteToHypothesis("[DataBaseFormat]=Accdb")
                        If .Password <> "" Then
#Region "Formating Line With Password"
                            ConnectionSetting.AddParam("Password", Me.Password, Me.Password)
                            ConnectionSetting.WriteToHypothesis("[Password]=" & Me.Password)

                            .Log.WriteToHypothesis("Formating Line With Password.")
                            .OleDbBuilder = New OleDb.OleDbConnectionStringBuilder()
                            With .OleDbBuilder
                                .DataSource = FilePath
                                .Provider = My.Settings.Adaptor_Accdb
                                .Add(My.Settings.OleDbSetPassword, Me.Password)
                            End With
                            Me.Line = Me.OleDbBuilder.ConnectionString
                            ConnectionSetting.AddOutputParam("Line", Me.Line, Me.Line.ToString)
                            ConnectionSetting.WriteToHypothesis("[Line]=" & Me.Line)
                            If Me.Line <> "" Then
                                ConnectionSetting.Status = Status.Online
                                Dim Tcon As New OleDb.OleDbConnection(Me.Line)
                                Try
                                    Tcon.Open()
                                    Me.Status = Status.Online
                                    Me.Log.Why += "The connection is online."
                                Catch ex As Exception
                                    Me.Status = Status.Broken
                                    Me.Log.Why += Format_Error(ex)
                                Finally
                                    Tcon.Close()
                                    Tcon.Dispose()
                                End Try

                            Else
                                ConnectionSetting.Status = Status.Broken
                                Me.Log.Why += "The line output is empty: Problem has arised with ConnectionSetting TestItem."
                            End If
#End Region
                        Else
#Region "Formating Line Without Password"
                            .Log.WriteToHypothesis("Formating Line Without Password.")
                            .OleDbBuilder = New OleDb.OleDbConnectionStringBuilder()
                            With .OleDbBuilder
                                .DataSource = FilePath
                                .Provider = My.Settings.Adaptor_Accdb
                            End With

                            Me.Line = Me.OleDbBuilder.ConnectionString
                            ConnectionSetting.AddOutputParam("Line", Me.Line, Me.Line.ToString)
                            ConnectionSetting.WriteToHypothesis("[Line]=" & Me.Line)

                            If Me.Line <> "" Then
                                ConnectionSetting.Status = Status.Online
                                Dim Tcon As New OleDb.OleDbConnection(Me.Line)
                                Try
                                    Tcon.Open()
                                    Me.Status = Status.Online
                                    Me.Log.Why += "The connection is online."
                                Catch ex As Exception
                                    Me.Status = Status.Broken
                                    Me.Log.Why += Format_Error(ex)
                                Finally
                                    Tcon.Close()
                                    Tcon.Dispose()
                                End Try

                            Else
                                ConnectionSetting.Status = Status.Broken
                                Me.Log.Why += "The line output is empty: Problem has arised with ConnectionSetting TestItem."
                            End If
#End Region
                        End If
                        Log.Add(ConnectionSetting)
#End Region
                    ElseIf Fi.Extension.ToLower.Contains("xls") Then
#Region "|Microsoft Excel 2010+|{xls}"
                        .DataBaseFormat = DataBaseType.Excel
                        .Log.WriteToHypothesis("The format is of type Excel.")
                        Dim ConnectionSetting As New TestItem("ConnectionSetting", "Evaluate all parameters needed to set the connection.")
                        ConnectionSetting.AddParam("FilePath", Me.FilePath, Me.FilePath)
                        ConnectionSetting.WriteToHypothesis("[FilePath]=" & Me.FilePath)
                        ConnectionSetting.AddParam("DataBaseFormat", Me.DataBaseFormat, Me.DataBaseFormat.ToString)
                        ConnectionSetting.WriteToHypothesis("[DataBaseFormat]=Excel")
                        If .Password <> "" Then
#Region "Formating Line With Password"
                            ConnectionSetting.AddParam("Password", Me.Password, Me.Password)
                            ConnectionSetting.WriteToHypothesis("[Password]=" & Me.Password)
                            .Log.WriteToHypothesis("Formating Line With Password.")
                            .OleDbBuilder = New OleDb.OleDbConnectionStringBuilder()
                            With .OleDbBuilder
                                .DataSource = FilePath
                                .Provider = My.Settings.Adaptor_Excel
                                .Add(My.Settings.OleDbSetPassword, Me.Password)
                                .Add(My.Settings.Excel_Ext1, My.Settings.Excel_Ext2 & ";" & My.Settings.Excel_Ext3) '"Excel 12.0 Xml;HDR=YES")
                            End With
                            Me.Line = Me.OleDbBuilder.ConnectionString
                            ConnectionSetting.AddOutputParam("Line", Me.Line, Me.Line.ToString)
                            ConnectionSetting.WriteToHypothesis("[Line]=" & Me.Line)
                            If Me.Line <> "" Then
                                ConnectionSetting.Status = Status.Online
                                Dim Tcon As New OleDb.OleDbConnection(Me.Line)
                                Try
                                    Tcon.Open()
                                    Me.Status = Status.Online
                                    Me.Log.Why += "The connection is online."
                                Catch ex As Exception
                                    Me.Status = Status.Broken
                                    Me.Log.Why += Format_Error(ex)
                                Finally
                                    Tcon.Close()
                                    Tcon.Dispose()
                                End Try
                            Else
                                ConnectionSetting.Status = Status.Broken
                                Me.Log.Why += "The line output is empty: Problem has arised with ConnectionSetting TestItem."
                            End If
#End Region
                        Else
#Region "Formating Line Without Password"
                            .Log.WriteToHypothesis("Formating Line Without Password.")
                            .OleDbBuilder = New OleDb.OleDbConnectionStringBuilder()
                            With .OleDbBuilder
                                .DataSource = FilePath
                                .Provider = My.Settings.Adaptor_Excel
                                .Add(My.Settings.Excel_Ext1, My.Settings.Excel_Ext2 & ";" & My.Settings.Excel_Ext3) '"Excel 12.0 Xml;HDR=YES")
                            End With

                            Me.Line = Me.OleDbBuilder.ConnectionString
                            ConnectionSetting.AddOutputParam("Line", Me.Line, Me.Line.ToString)
                            ConnectionSetting.WriteToHypothesis("[Line]=" & Me.Line)

                            If Me.Line <> "" Then
                                ConnectionSetting.Status = Status.Online
                                Dim Tcon As New OleDb.OleDbConnection(Me.Line)
                                Try
                                    Tcon.Open()
                                    Me.Status = Status.Online
                                    Me.Log.Why += "The connection is online."
                                Catch ex As Exception
                                    Me.Status = Status.Broken
                                    Me.Log.Why += Format_Error(ex)
                                Finally
                                    Tcon.Close()
                                    Tcon.Dispose()
                                End Try
                            Else
                                ConnectionSetting.Status = Status.Broken
                                Me.Log.Why += "The line output is empty: Problem has arised with ConnectionSetting TestItem."
                            End If
#End Region
                        End If
                        Log.Add(ConnectionSetting)
#End Region
                    ElseIf Fi.Extension.ToLower.Contains("mdb") Then
#Region "|Microsoft Access 2007-|{Mdb}"
                        .DataBaseFormat = DataBaseType.Mdb
                        .Log.WriteToHypothesis("The format is of type Microsoft Access 2007.")
                        Dim ConnectionSetting As New TestItem("ConnectionSetting", "Evaluate all parameters needed to set the connection.")
                        ConnectionSetting.AddParam("FilePath", Me.FilePath, Me.FilePath)
                        ConnectionSetting.WriteToHypothesis("[FilePath]=" & Me.FilePath)
                        ConnectionSetting.AddParam("DataBaseFormat", Me.DataBaseFormat, Me.DataBaseFormat.ToString)
                        ConnectionSetting.WriteToHypothesis("[DataBaseFormat]=Mdb")
                        If .Password <> "" Then
#Region "Formating Line With Password"
                            ConnectionSetting.AddParam("Password", Me.Password, Me.Password)
                            ConnectionSetting.WriteToHypothesis("[Password]=" & Me.Password)
                            .Log.WriteToHypothesis("Formating Line With Password.")
                            .OleDbBuilder = New OleDb.OleDbConnectionStringBuilder()
                            With .OleDbBuilder
                                .DataSource = FilePath
                                .Provider = My.Settings.Adaptor_Mdb
                                .Add(My.Settings.OleDbSetPassword, Me.Password)
                            End With
                            Me.Line = Me.OleDbBuilder.ConnectionString
                            ConnectionSetting.AddOutputParam("Line", Me.Line, Me.Line.ToString)
                            ConnectionSetting.WriteToHypothesis("[Line]=" & Me.Line)
                            If Me.Line <> "" Then
                                ConnectionSetting.Status = Status.Online
                                Dim Tcon As New OleDb.OleDbConnection(Me.Line)
                                Try
                                    Tcon.Open()
                                    Me.Status = Status.Online
                                    Me.Log.Why += "The connection is online."
                                Catch ex As Exception
                                    Me.Status = Status.Broken
                                    Me.Log.Why += Format_Error(ex)
                                Finally
                                    Tcon.Close()
                                    Tcon.Dispose()
                                End Try
                            Else
                                ConnectionSetting.Status = Status.Broken
                                Me.Log.Why += "The line output is empty: Problem has arised with ConnectionSetting TestItem."
                            End If
#End Region
                        Else
#Region "Formating Line Without Password"
                            .Log.WriteToHypothesis("Formating Line Without Password.")
                            .OleDbBuilder = New OleDb.OleDbConnectionStringBuilder()
                            With .OleDbBuilder
                                .DataSource = FilePath
                                .Provider = My.Settings.Adaptor_Mdb
                            End With

                            Me.Line = Me.OleDbBuilder.ConnectionString
                            ConnectionSetting.AddOutputParam("Line", Me.Line, Me.Line.ToString)
                            ConnectionSetting.WriteToHypothesis("[Line]=" & Me.Line)

                            If Me.Line <> "" Then
                                ConnectionSetting.Status = Status.Online
                                Dim Tcon As New OleDb.OleDbConnection(Me.Line)
                                Try
                                    Tcon.Open()
                                    Me.Status = Status.Online
                                    Me.Log.Why += "The connection is online."
                                Catch ex As Exception
                                    Me.Status = Status.Broken
                                    Me.Log.Why += Format_Error(ex)
                                Finally
                                    Tcon.Close()
                                    Tcon.Dispose()
                                End Try
                            Else
                                ConnectionSetting.Status = Status.Broken
                                Me.Log.Why += "The line output is empty: Problem has arised with ConnectionSetting TestItem."
                            End If
#End Region
                        End If
                        Log.Add(ConnectionSetting)
#End Region
                    ElseIf Fi.Extension.ToLower.Contains("dbf") Then
                        .DataBaseFormat = DataBaseType.Dbf
                        .Log.WriteToHypothesis("The format is of type DataBaseFormat DBF.")
#Region "|DataBaseFormat DBF-|{Dbf}"
                        .DataBaseFormat = DataBaseType.Dbf
                        .Log.WriteToHypothesis("The format is of type Oracle.")
                        Dim ConnectionSetting As New TestItem("ConnectionSetting", "Evaluate all parameters needed to set the connection.")
                        ConnectionSetting.AddParam("FilePath", Me.FilePath, Me.FilePath)
                        ConnectionSetting.WriteToHypothesis("[FilePath]=" & Me.FilePath)
                        ConnectionSetting.AddParam("DataBaseFormat", Me.DataBaseFormat, Me.DataBaseFormat.ToString)
                        ConnectionSetting.WriteToHypothesis("[DataBaseFormat]=Dbf")
                        If .Password <> "" Then
#Region "Formating Line With Password"
                            ConnectionSetting.AddParam("Password", Me.Password, Me.Password)
                            ConnectionSetting.WriteToHypothesis("[Password]=" & Me.Password)
                            .Log.WriteToHypothesis("Formating Line With Password.")
                            .OleDbBuilder = New OleDb.OleDbConnectionStringBuilder()
                            With .OleDbBuilder
                                .DataSource = IO.Path.GetDirectoryName(FilePath)
                                .Provider = My.Settings.Adaptor_Mdb
                                .Add(My.Settings.OleDbSetPassword, Me.Password)
                                .Add(My.Settings.Dbf_ExtendedProperty_0, My.Settings.Dbf_ExtendedProperty_1)

                            End With
                            Me.Line = Me.OleDbBuilder.ConnectionString
                            ConnectionSetting.AddOutputParam("Line", Me.Line, Me.Line.ToString)
                            ConnectionSetting.WriteToHypothesis("[Line]=" & Me.Line)
                            If Me.Line <> "" Then
                                ConnectionSetting.Status = Status.Online
                                Dim Tcon As New OleDb.OleDbConnection(Me.Line)
                                Try
                                    Tcon.Open()
                                    Me.Status = Status.Online
                                    Me.Log.Why += "The connection is online."
                                Catch ex As Exception
                                    Me.Status = Status.Broken
                                    Me.Log.Why += Format_Error(ex)
                                Finally
                                    Tcon.Close()
                                    Tcon.Dispose()
                                End Try
                            Else
                                ConnectionSetting.Status = Status.Broken
                                Me.Log.Why += "The line output is empty: Problem has arised with ConnectionSetting TestItem."
                            End If
#End Region
                        Else
#Region "Formating Line Without Password"
                            .Log.WriteToHypothesis("Formating Line Without Password.")
                            .OleDbBuilder = New OleDb.OleDbConnectionStringBuilder()
                            With .OleDbBuilder
                                .DataSource = IO.Path.GetDirectoryName(FilePath)
                                .Provider = My.Settings.Adaptor_Dbf
                                .Add(My.Settings.Dbf_ExtendedProperty_0, My.Settings.Dbf_ExtendedProperty_1)
                            End With

                            Me.Line = Me.OleDbBuilder.ConnectionString
                            ConnectionSetting.AddOutputParam("Line", Me.Line, Me.Line.ToString)
                            ConnectionSetting.WriteToHypothesis("[Line]=" & Me.Line)

                            If Me.Line <> "" Then
                                ConnectionSetting.Status = Status.Online
                                Dim Tcon As New OleDb.OleDbConnection(Me.Line)
                                Try
                                    Tcon.Open()
                                    Me.Status = Status.Online
                                    Me.Log.Why += "The connection is online."
                                Catch ex As Exception
                                    Me.Status = Status.Broken
                                    Me.Log.Why += Format_Error(ex)
                                Finally
                                    Tcon.Close()
                                    Tcon.Dispose()
                                End Try
                            Else
                                ConnectionSetting.Status = Status.Broken
                                Me.Log.Why += "The line output is empty: Problem has arised with ConnectionSetting TestItem."
                            End If
#End Region
                        End If
                        Log.Add(ConnectionSetting)
#End Region
                    ElseIf Fi.Extension.ToLower.Contains("mdf") Then
#Region "|ServerQueryLine SQL|{Mdf}"
                        .DataBaseFormat = DataBaseType.Sql
                        .Log.WriteToHypothesis("The format is of type Sql.")
                        Dim ConnectionSetting As New TestItem("ConnectionSetting", "Evaluate all parameters needed to set the connection.")
                        ConnectionSetting.AddParam("FilePath", Me.FilePath, Me.FilePath)
                        ConnectionSetting.WriteToHypothesis("[FilePath]=" & Me.FilePath)
                        ConnectionSetting.AddParam("DataBaseFormat", Me.DataBaseFormat, Me.DataBaseFormat.ToString)
                        ConnectionSetting.WriteToHypothesis("[DataBaseFormat]=Excel")
                        If .Password <> "" Then
#Region "Formating Line With Password"
                            ConnectionSetting.AddParam("Password", Me.Password, Me.Password)
                            ConnectionSetting.WriteToHypothesis("[Password]=" & Me.Password)
                            .Log.WriteToHypothesis("Formating Line With Password.")
                            Me.Line = My.Settings.Sql_DataSource & Me.FilePath
                            ConnectionSetting.AddOutputParam("Line", Me.Line, Me.Line.ToString)
                            ConnectionSetting.WriteToHypothesis("[Line]=" & Me.Line)
                            If Me.Line <> "" Then
                                ConnectionSetting.Status = Status.Online
                                Dim Tsqlcon As New SqlClient.SqlConnection(Me.Line)
                                Try
                                    Tsqlcon.Open()
                                    Me.Status = Status.Online
                                    Me.Log.Why += "The connection is online."
                                Catch ex As Exception
                                    Me.Status = Status.Broken
                                    Me.Log.Why += Format_Error(ex)
                                Finally
                                    Tsqlcon.Close()
                                    Tsqlcon.Dispose()
                                End Try
                            Else
                                ConnectionSetting.Status = Status.Broken
                                Me.Log.Why += "The line output is empty: Problem has arised with ConnectionSetting TestItem."
                            End If
#End Region
                        Else
#Region "Formating Line Without Password"
                            .Log.WriteToHypothesis("Formating Line Without Password.")
                            .OleDbBuilder = New OleDb.OleDbConnectionStringBuilder()
                            With .OleDbBuilder
                                .DataSource = FilePath
                                .Provider = My.Settings.Adaptor_Excel
                                .Add(My.Settings.Excel_Ext1, My.Settings.Excel_Ext2 & ";" & My.Settings.Excel_Ext3) '"Excel 12.0 Xml;HDR=YES")
                            End With

                            Me.Line = Me.OleDbBuilder.ConnectionString
                            ConnectionSetting.AddOutputParam("Line", Me.Line, Me.Line.ToString)
                            ConnectionSetting.WriteToHypothesis("[Line]=" & Me.Line)

                            If Me.Line <> "" Then
                                ConnectionSetting.Status = Status.Online
                                Dim Tcon As New OleDb.OleDbConnection(Me.Line)
                                Try
                                    Tcon.Open()
                                    Me.Status = Status.Online
                                    Me.Log.Why += "The connection is online."
                                Catch ex As Exception
                                    Me.Status = Status.Broken
                                    Me.Log.Why += Format_Error(ex)
                                Finally
                                    Tcon.Close()
                                    Tcon.Dispose()
                                End Try
                            Else
                                ConnectionSetting.Status = Status.Broken
                                Me.Log.Why += "The line output is empty: Problem has arised with ConnectionSetting TestItem."
                            End If
#End Region
                        End If
                        Log.Add(ConnectionSetting)
#End Region
                    ElseIf Fi.Extension.ToLower.Contains("saadry") Then
#Region "|Saadry|{Saadry}"
                        .DataBaseFormat = DataBaseType.Saadry
                        .Log.WriteToHypothesis("The format is of type Saadry.")
                        .Password = My.Settings.Key
                        Dim ConnectionSetting As New TestItem("ConnectionSetting", "Evaluate all parameters needed to set the connection.")
                        ConnectionSetting.AddParam("FilePath", Me.FilePath, Me.FilePath)
                        ConnectionSetting.WriteToHypothesis("[FilePath]=" & Me.FilePath)
                        ConnectionSetting.AddParam("DataBaseFormat", Me.DataBaseFormat, Me.DataBaseFormat.ToString)
                        ConnectionSetting.WriteToHypothesis("[DataBaseFormat]=Saadry")
                        If .Password <> "" Then
#Region "Formating Line With Password"
                            ConnectionSetting.AddParam("Password", Me.Password, Me.Password)
                            ConnectionSetting.WriteToHypothesis("[Password]=" & Me.Password)
                            .Log.WriteToHypothesis("Formating Line With Password.")
                            .OleDbBuilder = New OleDb.OleDbConnectionStringBuilder()
                            With .OleDbBuilder
                                .DataSource = FilePath
                                .Provider = My.Settings.Adaptor_Saadry
                                .Add(My.Settings.OleDbSetPassword, Me.Password)
                            End With
                            Me.Line = Me.OleDbBuilder.ConnectionString
                            ConnectionSetting.AddOutputParam("Line", Me.Line, Me.Line.ToString)
                            ConnectionSetting.WriteToHypothesis("[Line]=" & Me.Line)
                            If Me.Line <> "" Then
                                ConnectionSetting.Status = Status.Online
                                Dim Tcon As New OleDb.OleDbConnection(Me.Line)
                                Try
                                    Tcon.Open()
                                    Me.Status = Status.Online
                                    Me.Log.Why += "The connection is online."
                                Catch ex As Exception
                                    Me.Status = Status.Broken
                                    Me.Log.Why += Format_Error(ex)
                                Finally
                                    Tcon.Close()
                                    Tcon.Dispose()
                                End Try

                            Else
                                ConnectionSetting.Status = Status.Broken
                                Me.Log.Why += "The line output is empty: Problem has arised with ConnectionSetting TestItem."
                            End If
#End Region
                        Else
#Region "Formating Line Without Password"
                            .Log.WriteToHypothesis("Formating Line Without Password.")
                            .OleDbBuilder = New OleDb.OleDbConnectionStringBuilder()
                            With .OleDbBuilder
                                .DataSource = FilePath
                                .Provider = My.Settings.Adaptor_Saadry
                            End With
                            Me.Line = Me.OleDbBuilder.ConnectionString
                            ConnectionSetting.AddOutputParam("Line", Me.Line, Me.Line.ToString)
                            ConnectionSetting.WriteToHypothesis("[Line]=" & Me.Line)
                            If Me.Line <> "" Then
                                ConnectionSetting.Status = Status.Online
                                Dim Tcon As New OleDb.OleDbConnection(Me.Line)
                                Try
                                    Tcon.Open()
                                    Me.Status = Status.Online
                                    Me.Log.Why += "The connection is online."
                                Catch ex As Exception
                                    Me.Status = Status.Broken
                                    Me.Log.Why += Format_Error(ex)
                                Finally
                                    Tcon.Close()
                                    Tcon.Dispose()
                                End Try

                            Else
                                ConnectionSetting.Status = Status.Broken
                                Me.Log.Why += "The line output is empty: Problem has arised with ConnectionSetting TestItem."
                            End If
#End Region
                        End If
#End Region

                    Else
                        .Log = New TestItem("LineInfo", "Opening an empty Line, the filePath is not conform.")

                    End If
                Else
                    .Log.Why += "The file path is not conform."
                    .Line = "[Warning no parametters have been set]"
                    .DataBaseFormat = DataBaseType.Nothing
                    .FilePath = ""
                    .Status = Status.IsNothing
                End If
            End With
        End Sub
#End Region
#Region "<07.02> <Loader> [FilePath|String,[Password]|String]"
        Public Sub New(ByVal FilePath As String, Optional ByVal Password As String = "")
            With Me
                If Password <> "" Then
                    .Password = Password
                End If
                If IO.File.Exists(FilePath) Then
                    .FilePath = FilePath
                    Dim Fi As New Fichier(.FilePath, .Password)
                    .Log = New TestItem(Fi.FileName & ".Line", "New LineInformation.")
                    If Fi.Extension.ToLower.Contains("accdb") Then
#Region "|Microsoft Access 2010+|{Accdb}"
                        .DataBaseFormat = DataBaseType.Accdb
                        .Log.WriteToHypothesis("The format is of type Microsoft Access 2010.")
                        Dim ConnectionSetting As New TestItem("ConnectionSetting", "Evaluate all parameters needed to set the connection.")
                        ConnectionSetting.AddParam("FilePath", Me.FilePath, Me.FilePath)
                        ConnectionSetting.WriteToHypothesis("[FilePath]=" & Me.FilePath)
                        ConnectionSetting.AddParam("DataBaseFormat", Me.DataBaseFormat, Me.DataBaseFormat.ToString)
                        ConnectionSetting.WriteToHypothesis("[DataBaseFormat]=Accdb")
                        If .Password <> "" Then
#Region "Formating Line With Password"
                            ConnectionSetting.AddParam("Password", Me.Password, Me.Password)
                            ConnectionSetting.WriteToHypothesis("[Password]=" & Me.Password)

                            .Log.WriteToHypothesis("Formating Line With Password.")
                            .OleDbBuilder = New OleDb.OleDbConnectionStringBuilder()
                            With .OleDbBuilder
                                .DataSource = FilePath
                                .Provider = My.Settings.Adaptor_Accdb
                                .Add(My.Settings.OleDbSetPassword, Me.Password)
                            End With
                            Me.Line = Me.OleDbBuilder.ConnectionString
                            ConnectionSetting.AddOutputParam("Line", Me.Line, Me.Line.ToString)
                            ConnectionSetting.WriteToHypothesis("[Line]=" & Me.Line)
                            If Me.Line <> "" Then
                                ConnectionSetting.Status = Status.Online
                                Dim Tcon As New OleDb.OleDbConnection(Me.Line)
                                Try
                                    Tcon.Open()
                                    Me.Status = Status.Online
                                    Me.Log.Why += "The connection is online."
                                Catch ex As Exception
                                    Me.Status = Status.Broken
                                    Me.Log.Why += Format_Error(ex)
                                Finally
                                    Tcon.Close()
                                    Tcon.Dispose()
                                End Try

                            Else
                                ConnectionSetting.Status = Status.Broken
                                Me.Log.Why += "The line output is empty: Problem has arised with ConnectionSetting TestItem."
                            End If
#End Region
                        Else
#Region "Formating Line Without Password"
                            .Log.WriteToHypothesis("Formating Line Without Password.")
                            .OleDbBuilder = New OleDb.OleDbConnectionStringBuilder()
                            With .OleDbBuilder
                                .DataSource = FilePath
                                .Provider = My.Settings.Adaptor_Accdb
                            End With

                            Me.Line = Me.OleDbBuilder.ConnectionString
                            ConnectionSetting.AddOutputParam("Line", Me.Line, Me.Line.ToString)
                            ConnectionSetting.WriteToHypothesis("[Line]=" & Me.Line)

                            If Me.Line <> "" Then
                                ConnectionSetting.Status = Status.Online
                                Dim Tcon As New OleDb.OleDbConnection(Me.Line)
                                Try
                                    Tcon.Open()
                                    Me.Status = Status.Online
                                    Me.Log.Why += "The connection is online."
                                Catch ex As Exception
                                    Me.Status = Status.Broken
                                    Me.Log.Why += Format_Error(ex)
                                Finally
                                    Tcon.Close()
                                    Tcon.Dispose()
                                End Try

                            Else
                                ConnectionSetting.Status = Status.Broken
                                Me.Log.Why += "The line output is empty: Problem has arised with ConnectionSetting TestItem."
                            End If
#End Region
                        End If
                        Log.Add(ConnectionSetting)
#End Region
                    ElseIf Fi.Extension.ToLower.Contains("xls") Then
#Region "|Microsoft Excel 2010+|{xls}"
                        .DataBaseFormat = DataBaseType.Excel
                        .Log.WriteToHypothesis("The format is of type Excel.")
                        Dim ConnectionSetting As New TestItem("ConnectionSetting", "Evaluate all parameters needed to set the connection.")
                        ConnectionSetting.AddParam("FilePath", Me.FilePath, Me.FilePath)
                        ConnectionSetting.WriteToHypothesis("[FilePath]=" & Me.FilePath)
                        ConnectionSetting.AddParam("DataBaseFormat", Me.DataBaseFormat, Me.DataBaseFormat.ToString)
                        ConnectionSetting.WriteToHypothesis("[DataBaseFormat]=Excel")
                        If .Password <> "" Then
#Region "Formating Line With Password"
                            ConnectionSetting.AddParam("Password", Me.Password, Me.Password)
                            ConnectionSetting.WriteToHypothesis("[Password]=" & Me.Password)
                            .Log.WriteToHypothesis("Formating Line With Password.")
                            .OleDbBuilder = New OleDb.OleDbConnectionStringBuilder()
                            With .OleDbBuilder
                                .DataSource = FilePath
                                .Provider = My.Settings.Adaptor_Excel
                                .Add(My.Settings.OleDbSetPassword, Me.Password)
                                .Add(My.Settings.Excel_Ext1, My.Settings.Excel_Ext2 & ";" & My.Settings.Excel_Ext3) '"Excel 12.0 Xml;HDR=YES")
                            End With
                            Me.Line = Me.OleDbBuilder.ConnectionString
                            ConnectionSetting.AddOutputParam("Line", Me.Line, Me.Line.ToString)
                            ConnectionSetting.WriteToHypothesis("[Line]=" & Me.Line)
                            If Me.Line <> "" Then
                                ConnectionSetting.Status = Status.Online
                                Dim Tcon As New OleDb.OleDbConnection(Me.Line)
                                Try
                                    Tcon.Open()
                                    Me.Status = Status.Online
                                    Me.Log.Why += "The connection is online."
                                Catch ex As Exception
                                    Me.Status = Status.Broken
                                    Me.Log.Why += Format_Error(ex)
                                Finally
                                    Tcon.Close()
                                    Tcon.Dispose()
                                End Try
                            Else
                                ConnectionSetting.Status = Status.Broken
                                Me.Log.Why += "The line output is empty: Problem has arised with ConnectionSetting TestItem."
                            End If
#End Region
                        Else
#Region "Formating Line Without Password"
                            .Log.WriteToHypothesis("Formating Line Without Password.")
                            .OleDbBuilder = New OleDb.OleDbConnectionStringBuilder()
                            With .OleDbBuilder
                                .DataSource = FilePath
                                .Provider = My.Settings.Adaptor_Excel
                                .Add(My.Settings.Excel_Ext1, My.Settings.Excel_Ext2 & ";" & My.Settings.Excel_Ext3) '"Excel 12.0 Xml;HDR=YES")
                            End With

                            Me.Line = Me.OleDbBuilder.ConnectionString
                            ConnectionSetting.AddOutputParam("Line", Me.Line, Me.Line.ToString)
                            ConnectionSetting.WriteToHypothesis("[Line]=" & Me.Line)

                            If Me.Line <> "" Then
                                ConnectionSetting.Status = Status.Online
                                Dim Tcon As New OleDb.OleDbConnection(Me.Line)
                                Try
                                    Tcon.Open()
                                    Me.Status = Status.Online
                                    Me.Log.Why += "The connection is online."
                                Catch ex As Exception
                                    Me.Status = Status.Broken
                                    Me.Log.Why += Format_Error(ex)
                                Finally
                                    Tcon.Close()
                                    Tcon.Dispose()
                                End Try
                            Else
                                ConnectionSetting.Status = Status.Broken
                                Me.Log.Why += "The line output is empty: Problem has arised with ConnectionSetting TestItem."
                            End If
#End Region
                        End If
                        Log.Add(ConnectionSetting)
#End Region
                    ElseIf Fi.Extension.ToLower.Contains("mdb") Then
#Region "|Microsoft Access 2007-|{Mdb}"
                        .DataBaseFormat = DataBaseType.Mdb
                        .Log.WriteToHypothesis("The format is of type Microsoft Access 2007.")
                        Dim ConnectionSetting As New TestItem("ConnectionSetting", "Evaluate all parameters needed to set the connection.")
                        ConnectionSetting.AddParam("FilePath", Me.FilePath, Me.FilePath)
                        ConnectionSetting.WriteToHypothesis("[FilePath]=" & Me.FilePath)
                        ConnectionSetting.AddParam("DataBaseFormat", Me.DataBaseFormat, Me.DataBaseFormat.ToString)
                        ConnectionSetting.WriteToHypothesis("[DataBaseFormat]=Mdb")
                        If .Password <> "" Then
#Region "Formating Line With Password"
                            ConnectionSetting.AddParam("Password", Me.Password, Me.Password)
                            ConnectionSetting.WriteToHypothesis("[Password]=" & Me.Password)
                            .Log.WriteToHypothesis("Formating Line With Password.")
                            .OleDbBuilder = New OleDb.OleDbConnectionStringBuilder()
                            With .OleDbBuilder
                                .DataSource = FilePath
                                .Provider = My.Settings.Adaptor_Mdb
                                .Add(My.Settings.OleDbSetPassword, Me.Password)
                            End With
                            Me.Line = Me.OleDbBuilder.ConnectionString
                            ConnectionSetting.AddOutputParam("Line", Me.Line, Me.Line.ToString)
                            ConnectionSetting.WriteToHypothesis("[Line]=" & Me.Line)
                            If Me.Line <> "" Then
                                ConnectionSetting.Status = Status.Online
                                Dim Tcon As New OleDb.OleDbConnection(Me.Line)
                                Try
                                    Tcon.Open()
                                    Me.Status = Status.Online
                                    Me.Log.Why += "The connection is online."
                                Catch ex As Exception
                                    Me.Status = Status.Broken
                                    Me.Log.Why += Format_Error(ex)
                                Finally
                                    Tcon.Close()
                                    Tcon.Dispose()
                                End Try
                            Else
                                ConnectionSetting.Status = Status.Broken
                                Me.Log.Why += "The line output is empty: Problem has arised with ConnectionSetting TestItem."
                            End If
#End Region
                        Else
#Region "Formating Line Without Password"
                            .Log.WriteToHypothesis("Formating Line Without Password.")
                            .OleDbBuilder = New OleDb.OleDbConnectionStringBuilder()
                            With .OleDbBuilder
                                .DataSource = FilePath
                                .Provider = My.Settings.Adaptor_Mdb
                            End With

                            Me.Line = Me.OleDbBuilder.ConnectionString
                            ConnectionSetting.AddOutputParam("Line", Me.Line, Me.Line.ToString)
                            ConnectionSetting.WriteToHypothesis("[Line]=" & Me.Line)

                            If Me.Line <> "" Then
                                ConnectionSetting.Status = Status.Online
                                Dim Tcon As New OleDb.OleDbConnection(Me.Line)
                                Try
                                    Tcon.Open()
                                    Me.Status = Status.Online
                                    Me.Log.Why += "The connection is online."
                                Catch ex As Exception
                                    Me.Status = Status.Broken
                                    Me.Log.Why += Format_Error(ex)
                                Finally
                                    Tcon.Close()
                                    Tcon.Dispose()
                                End Try
                            Else
                                ConnectionSetting.Status = Status.Broken
                                Me.Log.Why += "The line output is empty: Problem has arised with ConnectionSetting TestItem."
                            End If
#End Region
                        End If
                        Log.Add(ConnectionSetting)
#End Region
                    ElseIf Fi.Extension.ToLower.Contains("dbf") Then
                        .DataBaseFormat = DataBaseType.Dbf
                        .Log.WriteToHypothesis("The format is of type DataBaseFormat DBF.")
#Region "|DataBaseFormat DBF-|{Dbf}"
                        .DataBaseFormat = DataBaseType.Dbf
                        .Log.WriteToHypothesis("The format is of type Oracle.")
                        Dim ConnectionSetting As New TestItem("ConnectionSetting", "Evaluate all parameters needed to set the connection.")
                        ConnectionSetting.AddParam("FilePath", Me.FilePath, Me.FilePath)
                        ConnectionSetting.WriteToHypothesis("[FilePath]=" & Me.FilePath)
                        ConnectionSetting.AddParam("DataBaseFormat", Me.DataBaseFormat, Me.DataBaseFormat.ToString)
                        ConnectionSetting.WriteToHypothesis("[DataBaseFormat]=Dbf")
                        If .Password <> "" Then
#Region "Formating Line With Password"
                            ConnectionSetting.AddParam("Password", Me.Password, Me.Password)
                            ConnectionSetting.WriteToHypothesis("[Password]=" & Me.Password)
                            .Log.WriteToHypothesis("Formating Line With Password.")
                            .OleDbBuilder = New OleDb.OleDbConnectionStringBuilder()
                            With .OleDbBuilder
                                .DataSource = IO.Path.GetDirectoryName(FilePath)
                                .Provider = My.Settings.Adaptor_Mdb
                                .Add(My.Settings.OleDbSetPassword, Me.Password)
                                .Add(My.Settings.Dbf_ExtendedProperty_0, My.Settings.Dbf_ExtendedProperty_1)

                            End With
                            Me.Line = Me.OleDbBuilder.ConnectionString
                            ConnectionSetting.AddOutputParam("Line", Me.Line, Me.Line.ToString)
                            ConnectionSetting.WriteToHypothesis("[Line]=" & Me.Line)
                            If Me.Line <> "" Then
                                ConnectionSetting.Status = Status.Online
                                Dim Tcon As New OleDb.OleDbConnection(Me.Line)
                                Try
                                    Tcon.Open()
                                    Me.Status = Status.Online
                                    Me.Log.Why += "The connection is online."
                                Catch ex As Exception
                                    Me.Status = Status.Broken
                                    Me.Log.Why += Format_Error(ex)
                                Finally
                                    Tcon.Close()
                                    Tcon.Dispose()
                                End Try
                            Else
                                ConnectionSetting.Status = Status.Broken
                                Me.Log.Why += "The line output is empty: Problem has arised with ConnectionSetting TestItem."
                            End If
#End Region
                        Else
#Region "Formating Line Without Password"
                            .Log.WriteToHypothesis("Formating Line Without Password.")
                            .OleDbBuilder = New OleDb.OleDbConnectionStringBuilder()
                            With .OleDbBuilder
                                .DataSource = IO.Path.GetDirectoryName(FilePath)
                                .Provider = My.Settings.Adaptor_Dbf
                                .Add(My.Settings.Dbf_ExtendedProperty_0, My.Settings.Dbf_ExtendedProperty_1)
                            End With

                            Me.Line = Me.OleDbBuilder.ConnectionString
                            ConnectionSetting.AddOutputParam("Line", Me.Line, Me.Line.ToString)
                            ConnectionSetting.WriteToHypothesis("[Line]=" & Me.Line)

                            If Me.Line <> "" Then
                                ConnectionSetting.Status = Status.Online
                                Dim Tcon As New OleDb.OleDbConnection(Me.Line)
                                Try
                                    Tcon.Open()
                                    Me.Status = Status.Online
                                    Me.Log.Why += "The connection is online."
                                Catch ex As Exception
                                    Me.Status = Status.Broken
                                    Me.Log.Why += Format_Error(ex)
                                Finally
                                    Tcon.Close()
                                    Tcon.Dispose()
                                End Try
                            Else
                                ConnectionSetting.Status = Status.Broken
                                Me.Log.Why += "The line output is empty: Problem has arised with ConnectionSetting TestItem."
                            End If
#End Region
                        End If
                        Log.Add(ConnectionSetting)
#End Region
                    ElseIf Fi.Extension.ToLower.Contains("mdf") Then
#Region "|ServerQueryLine SQL|{Mdf}"
                        .DataBaseFormat = DataBaseType.Sql
                        .Log.WriteToHypothesis("The format is of type Sql.")
                        Dim ConnectionSetting As New TestItem("ConnectionSetting", "Evaluate all parameters needed to set the connection.")
                        ConnectionSetting.AddParam("FilePath", Me.FilePath, Me.FilePath)
                        ConnectionSetting.WriteToHypothesis("[FilePath]=" & Me.FilePath)
                        ConnectionSetting.AddParam("DataBaseFormat", Me.DataBaseFormat, Me.DataBaseFormat.ToString)
                        ConnectionSetting.WriteToHypothesis("[DataBaseFormat]=Sql")
                        If .Password <> "" Then
#Region "Formating Line With Password"
                            ConnectionSetting.AddParam("Password", Me.Password, Me.Password)
                            ConnectionSetting.WriteToHypothesis("[Password]=" & Me.Password)
                            .Log.WriteToHypothesis("Formating Line With Password.")
                            Me.Line = My.Settings.Sql_DataSource & Me.FilePath & ";Integrated Security=True;User Instance=True"
                            ConnectionSetting.AddOutputParam("Line", Me.Line, Me.Line.ToString)
                            ConnectionSetting.WriteToHypothesis("[Line]=" & Me.Line)
                            If Me.Line <> "" Then
                                ConnectionSetting.Status = Status.Online
                                Dim Tsqlcon As New SqlClient.SqlConnection(Me.Line)
                                Try
                                    Tsqlcon.Open()
                                    Me.Status = Status.Online
                                    Me.Log.Why += "The connection is online."
                                Catch ex As Exception
                                    Me.Status = Status.Broken
                                    Me.Log.Why += Format_Error(ex)
                                Finally
                                    Tsqlcon.Close()
                                    Tsqlcon.Dispose()
                                End Try
                            Else
                                ConnectionSetting.Status = Status.Broken
                                Me.Log.Why += "The line output is empty: Problem has arised with ConnectionSetting TestItem."
                            End If
#End Region
                        Else
#Region "Formating Line Without Password"
                            .Log.WriteToHypothesis("Formating Line Without Password.")
                            Me.Line = My.Settings.Sql_DataSource & Me.FilePath '& ";Integrated Security=True;User Instance=True"
                            ConnectionSetting.AddOutputParam("Line", Me.Line, Me.Line.ToString)
                            ConnectionSetting.WriteToHypothesis("[Line]=" & Me.Line)

                            If Me.Line <> "" Then
                                ConnectionSetting.Status = Status.Online
                                Dim Tsqlcon As New SqlClient.SqlConnection(Me.Line)
                                Try
                                    Tsqlcon.Open()
                                    Me.Status = Status.Online
                                    Me.Log.Why += "The connection is online."
                                Catch ex As Exception
                                    Me.Status = Status.Broken
                                    Me.Log.Why += Format_Error(ex)
                                Finally
                                    Tsqlcon.Close()
                                    Tsqlcon.Dispose()
                                End Try
                            Else
                                ConnectionSetting.Status = Status.Broken
                                Me.Log.Why += "The line output is empty: Problem has arised with ConnectionSetting TestItem."
                            End If
#End Region
                        End If
                        Log.Add(ConnectionSetting)
#End Region
                    ElseIf Fi.Extension.ToLower.Contains("saadry") Then
#Region "|Saadry|{Saadry}"
                        .DataBaseFormat = DataBaseType.Saadry
                        .Log.WriteToHypothesis("The format is of type Saadry.")
                        .Password = My.Settings.Key
                        Dim ConnectionSetting As New TestItem("ConnectionSetting", "Evaluate all parameters needed to set the connection.")
                        ConnectionSetting.AddParam("FilePath", Me.FilePath, Me.FilePath)
                        ConnectionSetting.WriteToHypothesis("[FilePath]=" & Me.FilePath)
                        ConnectionSetting.AddParam("DataBaseFormat", Me.DataBaseFormat, Me.DataBaseFormat.ToString)
                        ConnectionSetting.WriteToHypothesis("[DataBaseFormat]=Saadry")
                        If .Password <> "" Then
#Region "Formating Line With Password"
                            ConnectionSetting.AddParam("Password", Me.Password, Me.Password)
                            ConnectionSetting.WriteToHypothesis("[Password]=" & Me.Password)
                            .Log.WriteToHypothesis("Formating Line With Password.")
                            .OleDbBuilder = New OleDb.OleDbConnectionStringBuilder()
                            With .OleDbBuilder
                                .DataSource = FilePath
                                .Provider = My.Settings.Adaptor_Saadry
                                .Add(My.Settings.OleDbSetPassword, Me.Password)
                            End With
                            Me.Line = Me.OleDbBuilder.ConnectionString
                            ConnectionSetting.AddOutputParam("Line", Me.Line, Me.Line.ToString)
                            ConnectionSetting.WriteToHypothesis("[Line]=" & Me.Line)
                            If Me.Line <> "" Then
                                ConnectionSetting.Status = Status.Online
                                Dim Tcon As New OleDb.OleDbConnection(Me.Line)
                                Try
                                    Tcon.Open()
                                    Me.Status = Status.Online
                                    Me.Log.Why += "The connection is online."
                                Catch ex As Exception
                                    Me.Status = Status.Broken
                                    Me.Log.Why += Format_Error(ex)
                                Finally
                                    Tcon.Close()
                                    Tcon.Dispose()
                                End Try

                            Else
                                ConnectionSetting.Status = Status.Broken
                                Me.Log.Why += "The line output is empty: Problem has arised with ConnectionSetting TestItem."
                            End If
#End Region
                        Else
#Region "Formating Line Without Password"
                            .Log.WriteToHypothesis("Formating Line Without Password.")
                            .OleDbBuilder = New OleDb.OleDbConnectionStringBuilder()
                            With .OleDbBuilder
                                .DataSource = FilePath
                                .Provider = My.Settings.Adaptor_Saadry
                            End With
                            Me.Line = Me.OleDbBuilder.ConnectionString
                            ConnectionSetting.AddOutputParam("Line", Me.Line, Me.Line.ToString)
                            ConnectionSetting.WriteToHypothesis("[Line]=" & Me.Line)
                            If Me.Line <> "" Then
                                ConnectionSetting.Status = Status.Online
                                Dim Tcon As New OleDb.OleDbConnection(Me.Line)
                                Try
                                    Tcon.Open()
                                    Me.Status = Status.Online
                                    Me.Log.Why += "The connection is online."
                                Catch ex As Exception
                                    Me.Status = Status.Broken
                                    Me.Log.Why += Format_Error(ex)
                                Finally
                                    Tcon.Close()
                                    Tcon.Dispose()
                                End Try

                            Else
                                ConnectionSetting.Status = Status.Broken
                                Me.Log.Why += "The line output is empty: Problem has arised with ConnectionSetting TestItem."
                            End If
#End Region
                        End If
#End Region

                    Else
                        .Log = New TestItem("LineInfo", "Opening an empty Line, the filePath is not conform.")

                    End If
                Else
                    .Log = New TestItem(".Line", "New LineInformation.")
                    .Log.Why += "The file path is not conform."
                    .Line = "[Warning no parametters have been set]"
                    .DataBaseFormat = DataBaseType.Nothing
                    .FilePath = ""
                    .Status = Status.IsNothing
                End If

            End With
        End Sub
#End Region
#End Region
    End Class
#End Region
#Region "|08.07| <Class> [Project]"
    Public Class Project

#Region "|1| [Property]"
#Region "|01.00| <Property> [Info]"
#Region "[On] |2019/05/19 15h28:446| <01.00.00> <Property> <Info> |.Name()|String|"' (Set|Get) The Name of the object as String.
        Private _Name As String
        '''    <Summary>
        '''     (Set|Get) The Name of the object as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From  | Time : 2019/05/19 15h29:420 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>

        <Browsable(True), CategoryAttribute("Info"), Description("(Set|Get) The Name of the object as String.")>
        Public Property Name() As String
            Get
                Return _Name
            End Get
            Set(ByVal Value As String)
                _Name = Value
            End Set
        End Property
#End Region '(Set|Get) The Name of the object as String.
#Region "[On] |2019/05/19 15h28:446| <01.00.01> <Property> <Info> |.File()|Fichier|"' (Set|Get) The File as Fichier.
        Private _File As Fichier
        '''    <Summary>
        '''     (Set|Get) The File as Fichier.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From  | Time : 2019/05/19 15h31:122 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>

        <Browsable(True), CategoryAttribute("Info"), Description("(Set|Get) The File as Fichier.")>
        Public Property File() As Fichier
            Get
                Return _File
            End Get
            Set(ByVal Value As Fichier)
                _File = Value
            End Set
        End Property
#End Region '(Set|Get) The File as Fichier.
#Region "[On] |2019/05/19 15h28:446| <01.00.02> <Property> <Info> |.Directory()|Folder|"' (Set|Get) The Directory as Folder.
        Private _Directory As Folder
        '''    <Summary>
        '''     (Set|Get) The Directory as Folder.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From  | Time : 2019/05/19 15h32:277 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>

        <Browsable(True), CategoryAttribute("Info"), Description("(Set|Get) The Directory as Folder.")>
        Public Property Directory() As Folder
            Get
                Return _Directory
            End Get
            Set(ByVal Value As Folder)
                _Directory = Value
            End Set
        End Property
#End Region '(Set|Get) The Directory as Folder.
#Region "[On] |2019/05/19 15h28:446| <01.00.03> <Property> <Info> |.ProjectFormat()|CodeLanguage|"' (Set|Get) The ProjectFormat as CodeLanguage.
        Private _ProjectFormat As CodeLanguage
        '''    <Summary>
        '''     (Set|Get) The ProjectFormat as CodeLanguage.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From  | Time : 2019/05/19 15h33:111 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>

        <Browsable(True), CategoryAttribute("Info"), Description("(Set|Get) The ProjectFormat as CodeLanguage.")>
        Public Property ProjectFormat() As CodeLanguage
            Get
                Return _ProjectFormat
            End Get
            Set(ByVal Value As CodeLanguage)
                _ProjectFormat = Value
            End Set
        End Property
#End Region '(Set|Get) The ProjectFormat as CodeLanguage.

#End Region

#End Region
    End Class
#End Region
#End Region
#Region "|9| [Constante]"

#End Region
#Region "|10| [Event]"

#End Region
#Region "|11| [Declare]"

#End Region
#Region "|12| [Delegate]"

#End Region
#End Region
End Module
