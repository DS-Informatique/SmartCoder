
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevComponents.DotNetBar.Controls
Public Module M_Langue
#Region "[Langue]"
#Region "<< GENERAL >> [Languages]"
#Region "<Languages> <Property>"
    Public Property Langue As New S_Langue
    Public Property MyLang As New List(Of Langue_Item)
#End Region
#Region "<Languages> <Structure>"
    ''' <summary>
    ''' Structure of Langue for indexation and Display Name
    ''' </summary>
    Public Structure S_Langue
        Public Index As Enum_Langue
        Public Display As String
    End Structure

#End Region
#Region "<Test>"
    ' Liste la liste des langues disponibles
    ' Le nom de la Table est :  < List_Lang > 
    ' Object TypeListViewEx
    Public Property List_Lang As New ListViewEx
    ' Using a Temporary ImageList Item To Store Flags
    ' Name of the ImageList for Flags is :   < Portfolio_Language_Flags > 
    Public Property Portfolio_Language_Flags As New ImageList

    ' Populate Language Name
    ' Name of the Function :   < Index_Langue > 
    Public Sub Index_Langue(Optional ByVal Show As Boolean = False)
        List_Lang = New ListViewEx
        MyLang = New List(Of Langue_Item)
        With List_Lang
            .Columns.Clear()
            .Items.Clear()
            .Columns.Add("ID")
            .Columns.Add("Langue")
            .Columns.Add("ISO 639-3")
            .Columns.Add("ISO 639-2")
            .Columns.Add("ISO 639-1")
            .Columns.Add("Nom Français")
            .Columns.Add("Nom Original")
            .Columns.Add("Name in English")
        End With

        'Format ImageList
        Portfolio_Language_Flags = New ImageList
        With Portfolio_Language_Flags
            .ColorDepth = ColorDepth.Depth32Bit
            .ImageSize = New Size(32, 32)
        End With
        List_Lang.LargeImageList = Portfolio_Language_Flags
        List_Lang.SmallImageList = Portfolio_Language_Flags

        List_Lang.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

        'Populate the ListviewEx
#Region "<Populate Information>"
        Dim item As New ListViewItem("0")
        item.SubItems.Add("Arabic")
        item.SubItems.Add("ARA")
        item.SubItems.Add("ARA")
        item.SubItems.Add("AR")
        item.SubItems.Add("Arabe")
        item.SubItems.Add("العربية")
        item.SubItems.Add("Arabic")
        item.ImageIndex = 0
        With Arabic
            .ID = Val(item.Text)
            .Name = item.SubItems(1).Text
            .Iso_693_3 = item.SubItems(2).Text
            .Iso_693_2 = item.SubItems(3).Text
            .Iso_693_1 = item.SubItems(4).Text
            .FrenchName = item.SubItems(5).Text
            .OriginalName = item.SubItems(6).Text
            .EnglishName = item.SubItems(7).Text
        End With
        MyLang.Add(Arabic)
        List_Lang.Items.Add(item)

        item = New ListViewItem("1")
        item.SubItems.Add("English")
        item.SubItems.Add("ENG")
        item.SubItems.Add("ENG")
        item.SubItems.Add("EN")
        item.SubItems.Add("Anglais")
        item.SubItems.Add("English")
        item.SubItems.Add("English")
        item.ImageIndex = 1
        With English
            .ID = Val(item.Text)
            .Name = item.SubItems(1).Text
            .Iso_693_3 = item.SubItems(2).Text
            .Iso_693_2 = item.SubItems(3).Text
            .Iso_693_1 = item.SubItems(4).Text
            .FrenchName = item.SubItems(5).Text
            .OriginalName = item.SubItems(6).Text
            .EnglishName = item.SubItems(7).Text
        End With
        MyLang.Add(English)
        List_Lang.Items.Add(item)
        item = New ListViewItem("2")
        item.SubItems.Add("Français")
        item.SubItems.Add("FRE/FRA")
        item.SubItems.Add("FRE/FRA")
        item.SubItems.Add("FR")
        item.SubItems.Add("Français")
        item.SubItems.Add("Français")
        item.SubItems.Add("French")
        item.ImageIndex = 2
        With French
            .ID = Val(item.Text)
            .Name = item.SubItems(1).Text
            .Iso_693_3 = item.SubItems(2).Text
            .Iso_693_2 = item.SubItems(3).Text
            .Iso_693_1 = item.SubItems(4).Text
            .FrenchName = item.SubItems(5).Text
            .OriginalName = item.SubItems(6).Text
            .EnglishName = item.SubItems(7).Text
        End With
        MyLang.Add(French)
        List_Lang.Items.Add(item)
        item = New ListViewItem("3")
        item.SubItems.Add("German")
        item.SubItems.Add("GER/DEU")
        item.SubItems.Add("GER/DEU")
        item.SubItems.Add("DE")
        item.SubItems.Add("Allemand")
        item.SubItems.Add("Deutsch")
        item.SubItems.Add("German")
        item.ImageIndex = 3
        With German
            .ID = Val(item.Text)
            .Name = item.SubItems(1).Text
            .Iso_693_3 = item.SubItems(2).Text
            .Iso_693_2 = item.SubItems(3).Text
            .Iso_693_1 = item.SubItems(4).Text
            .FrenchName = item.SubItems(5).Text
            .OriginalName = item.SubItems(6).Text
            .EnglishName = item.SubItems(7).Text
        End With
        MyLang.Add(German)
        List_Lang.Items.Add(item)
        item = New ListViewItem("4")
        item.SubItems.Add("Hebrew")
        item.SubItems.Add("HEB")
        item.SubItems.Add("HEB")
        item.SubItems.Add("HE")
        item.SubItems.Add("Hébreu")
        item.SubItems.Add("עִבְרִית, עברית")
        item.SubItems.Add("Hebrew")
        item.ImageIndex = 4
        With Hebrew
            .ID = Val(item.Text)
            .Name = item.SubItems(1).Text
            .Iso_693_3 = item.SubItems(2).Text
            .Iso_693_2 = item.SubItems(3).Text
            .Iso_693_1 = item.SubItems(4).Text
            .FrenchName = item.SubItems(5).Text
            .OriginalName = item.SubItems(6).Text
            .EnglishName = item.SubItems(7).Text
        End With
        MyLang.Add(Hebrew)
        List_Lang.Items.Add(item)
        item = New ListViewItem("5")
        item.SubItems.Add("Italian")
        item.SubItems.Add("ITA")
        item.SubItems.Add("ITA")
        item.SubItems.Add("IT")
        item.SubItems.Add("Italien")
        item.SubItems.Add("Italiano")
        item.SubItems.Add("Italian")
        item.ImageIndex = 5
        With Italian
            .ID = Val(item.Text)
            .Name = item.SubItems(1).Text
            .Iso_693_3 = item.SubItems(2).Text
            .Iso_693_2 = item.SubItems(3).Text
            .Iso_693_1 = item.SubItems(4).Text
            .FrenchName = item.SubItems(5).Text
            .OriginalName = item.SubItems(6).Text
            .EnglishName = item.SubItems(7).Text
        End With
        MyLang.Add(Italian)
        List_Lang.Items.Add(item)
        item = New ListViewItem("6")
        item.SubItems.Add("Portuguese")
        item.SubItems.Add("POR")
        item.SubItems.Add("POR")
        item.SubItems.Add("PT")
        item.SubItems.Add("Portugais")
        item.SubItems.Add("Português")
        item.SubItems.Add("Portuguese")
        item.ImageIndex = 6
        With Portuguese
            .ID = Val(item.Text)
            .Name = item.SubItems(1).Text
            .Iso_693_3 = item.SubItems(2).Text
            .Iso_693_2 = item.SubItems(3).Text
            .Iso_693_1 = item.SubItems(4).Text
            .FrenchName = item.SubItems(5).Text
            .OriginalName = item.SubItems(6).Text
            .EnglishName = item.SubItems(7).Text
        End With
        MyLang.Add(Portuguese)
        List_Lang.Items.Add(item)
        item = New ListViewItem("7")
        item.SubItems.Add("Russian")
        item.SubItems.Add("RUS")
        item.SubItems.Add("RUS")
        item.SubItems.Add("RU")
        item.SubItems.Add("Russe")
        item.SubItems.Add("русский язык")
        item.SubItems.Add("Russian")
        item.ImageIndex = 7
        With Russian
            .ID = Val(item.Text)
            .Name = item.SubItems(1).Text
            .Iso_693_3 = item.SubItems(2).Text
            .Iso_693_2 = item.SubItems(3).Text
            .Iso_693_1 = item.SubItems(4).Text
            .FrenchName = item.SubItems(5).Text
            .OriginalName = item.SubItems(6).Text
            .EnglishName = item.SubItems(7).Text
        End With
        MyLang.Add(Russian)
        List_Lang.Items.Add(item)
        item = New ListViewItem("8")
        item.SubItems.Add("Spanish")
        item.SubItems.Add("SPA")
        item.SubItems.Add("SPA")
        item.SubItems.Add("ES")
        item.SubItems.Add("Espagnol")
        item.SubItems.Add("Español")
        item.SubItems.Add("Spanish")
        item.ImageIndex = 8
        With Spanish
            .ID = Val(item.Text)
            .Name = item.SubItems(1).Text
            .Iso_693_3 = item.SubItems(2).Text
            .Iso_693_2 = item.SubItems(3).Text
            .Iso_693_1 = item.SubItems(4).Text
            .FrenchName = item.SubItems(5).Text
            .OriginalName = item.SubItems(6).Text
            .EnglishName = item.SubItems(7).Text
        End With
        MyLang.Add(Spanish)
        List_Lang.Items.Add(item)
        item = New ListViewItem("9")
        item.SubItems.Add("Chinese")
        item.SubItems.Add("CK")
        item.SubItems.Add("CK")
        item.SubItems.Add("CK")
        item.SubItems.Add("Chinise")
        item.SubItems.Add("Chinese")
        item.SubItems.Add("Chinese")
        item.ImageIndex = 9
        With Chinese
            .ID = Val(item.Text)
            .Name = item.SubItems(1).Text
            .Iso_693_3 = item.SubItems(2).Text
            .Iso_693_2 = item.SubItems(3).Text
            .Iso_693_1 = item.SubItems(4).Text
            .FrenchName = item.SubItems(5).Text
            .OriginalName = item.SubItems(6).Text
            .EnglishName = item.SubItems(7).Text
        End With
        MyLang.Add(Chinese)
        List_Lang.Items.Add(item)


        List_Lang.Items.Add(item)
        item = New ListViewItem("10")
        item.SubItems.Add("Japanese")
        item.SubItems.Add("JP")
        item.SubItems.Add("JP")
        item.SubItems.Add("JP")
        item.SubItems.Add("Japanese")
        item.SubItems.Add("Japanese")
        item.SubItems.Add("Japanese")
        item.ImageIndex = 10
        With Japanese
            .ID = Val(item.Text)
            .Name = item.SubItems(1).Text
            .Iso_693_3 = item.SubItems(2).Text
            .Iso_693_2 = item.SubItems(3).Text
            .Iso_693_1 = item.SubItems(4).Text
            .FrenchName = item.SubItems(5).Text
            .OriginalName = item.SubItems(6).Text
            .EnglishName = item.SubItems(7).Text
        End With
        MyLang.Add(Japanese)

        List_Lang.Items.Add(item)
        item = New ListViewItem("11")
        item.SubItems.Add("Greek")
        item.SubItems.Add("GK")
        item.SubItems.Add("GK")
        item.SubItems.Add("GK")
        item.SubItems.Add("Greek")
        item.SubItems.Add("Greek")
        item.SubItems.Add("Greek")
        item.ImageIndex = 11
        With Greek
            .ID = Val(item.Text)
            .Name = item.SubItems(1).Text
            .Iso_693_3 = item.SubItems(2).Text
            .Iso_693_2 = item.SubItems(3).Text
            .Iso_693_1 = item.SubItems(4).Text
            .FrenchName = item.SubItems(5).Text
            .OriginalName = item.SubItems(6).Text
            .EnglishName = item.SubItems(7).Text
        End With
        MyLang.Add(Greek)

        List_Lang.Items.Add(item)
        item = New ListViewItem("12")
        item.SubItems.Add("Latin")
        item.SubItems.Add("Lt")
        item.SubItems.Add("Lt")
        item.SubItems.Add("Lt")
        item.SubItems.Add("Latin")
        item.SubItems.Add("Latin")
        item.SubItems.Add("Latin")
        item.ImageIndex = 12
        With Latin
            .ID = Val(item.Text)
            .Name = item.SubItems(1).Text
            .Iso_693_3 = item.SubItems(2).Text
            .Iso_693_2 = item.SubItems(3).Text
            .Iso_693_1 = item.SubItems(4).Text
            .FrenchName = item.SubItems(5).Text
            .OriginalName = item.SubItems(6).Text
            .EnglishName = item.SubItems(7).Text
        End With
        MyLang.Add(Latin)

        List_Lang.Items.Add(item)
        item = New ListViewItem("13")
        item.SubItems.Add("Thai")
        item.SubItems.Add("Ti")
        item.SubItems.Add("Ti")
        item.SubItems.Add("Ti")
        item.SubItems.Add("Thai")
        item.SubItems.Add("Thai")
        item.SubItems.Add("Thai")
        item.ImageIndex = 13
        With Thai
            .ID = Val(item.Text)
            .Name = item.SubItems(1).Text
            .Iso_693_3 = item.SubItems(2).Text
            .Iso_693_2 = item.SubItems(3).Text
            .Iso_693_1 = item.SubItems(4).Text
            .FrenchName = item.SubItems(5).Text
            .OriginalName = item.SubItems(6).Text
            .EnglishName = item.SubItems(7).Text
        End With
        MyLang.Add(Thai)

        List_Lang.Items.Add(item)
        item = New ListViewItem("14")
        item.SubItems.Add("Th")
        item.SubItems.Add("Th")
        item.SubItems.Add("Th")
        item.SubItems.Add("Th")
        item.SubItems.Add("Turkish")
        item.SubItems.Add("Turkish")
        item.SubItems.Add("Turkish")
        item.ImageIndex = 14
        With Turkish
            .ID = Val(item.Text)
            .Name = item.SubItems(1).Text
            .Iso_693_3 = item.SubItems(2).Text
            .Iso_693_2 = item.SubItems(3).Text
            .Iso_693_1 = item.SubItems(4).Text
            .FrenchName = item.SubItems(5).Text
            .OriginalName = item.SubItems(6).Text
            .EnglishName = item.SubItems(7).Text
        End With
        MyLang.Add(Turkish)
        List_Lang.Items.Add(item)
        List_Lang.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

#End Region

#Region "<Show>"
        If Show = True Then
            Dim F As New Form
            F.Text = "Liste des Langues"
            F.AutoSize = True
            List_Lang.Dock = DockStyle.Fill
            List_Lang.View = View.Details

            F.Controls.Add(List_Lang)
            F.Show()
        End If
#End Region
    End Sub
    Public Spanish As New Langue_Item
    Public Russian As New Langue_Item
    Public Portuguese As New Langue_Item
    Public Italian As New Langue_Item
    Public Hebrew As New Langue_Item
    Public German As New Langue_Item
    Public French As New Langue_Item
    Public English As New Langue_Item
    Public Arabic As New Langue_Item
    Public Chinese As New Langue_Item
    Public Japanese As New Langue_Item
    Public Turkish As New Langue_Item
    Public Thai As New Langue_Item
    Public Latin As New Langue_Item
    Public Greek As New Langue_Item


#End Region

    Public Class Langue_Item
#Region "<00.00.00> <Properties> <Information> [ID   | Int32]"
        Private _ID As Int32
        '''<summary> 
        '''(Set|Get) ID
        '''</summary>
        <CategoryAttribute("Information"),
Description("(Set|Get) ID"),
Browsable(True)>
        Public Property ID As Int32
            Get
                Return _ID
            End Get
            Set(ByVal value As Int32)
                _ID = value
            End Set
        End Property
#End Region
#Region "<00.00.01> <Properties> <Information> [Name   | String]"
        Private _Name As String
        '''<summary> 
        '''(Set|Get) Name
        '''</summary>
        <CategoryAttribute("Information"),
Description("(Set|Get) Name"),
Browsable(True)>
        Public Property Name As String
            Get
                Return _Name
            End Get
            Set(ByVal value As String)
                _Name = value
            End Set
        End Property
#End Region
#Region "<00.00.02> <Properties> <Information> [Iso_693_1   | String]"
        Private _Iso_693_1 As String
        '''<summary> 
        '''(Set|Get) Iso_693_1
        '''</summary>
        <CategoryAttribute("Information"),
Description("(Set|Get) Iso_693_1"),
Browsable(True)>
        Public Property Iso_693_1 As String
            Get
                Return _Iso_693_1
            End Get
            Set(ByVal value As String)
                _Iso_693_1 = value
            End Set
        End Property
#End Region
#Region "<00.00.03> <Properties> <Information> [Iso_693_2   | String]"
        Private _Iso_693_2 As String
        '''<summary> 
        '''(Set|Get) Iso_693_2
        '''</summary>
        <CategoryAttribute("Information"),
Description("(Set|Get) Iso_693_2"),
Browsable(True)>
        Public Property Iso_693_2 As String
            Get
                Return _Iso_693_2
            End Get
            Set(ByVal value As String)
                _Iso_693_2 = value
            End Set
        End Property
#End Region
#Region "<00.00.04> <Properties> <Information> [Iso_693_3   | String]"
        Private _Iso_693_3 As String
        '''<summary> 
        '''(Set|Get) Iso_693_3
        '''</summary>
        <CategoryAttribute("Information"),
Description("(Set|Get) Iso_693_3"),
Browsable(True)>
        Public Property Iso_693_3 As String
            Get
                Return _Iso_693_3
            End Get
            Set(ByVal value As String)
                _Iso_693_3 = value
            End Set
        End Property
#End Region
#Region "<00.00.05> <Properties> <Information> [FrenchName   | String]"
        Private _FrenchName As String
        '''<summary> 
        '''(Set|Get) FrenchName
        '''</summary>
        <CategoryAttribute("Information"),
Description("(Set|Get) FrenchName"),
Browsable(True)>
        Public Property FrenchName As String
            Get
                Return _FrenchName
            End Get
            Set(ByVal value As String)
                _FrenchName = value
            End Set
        End Property
#End Region
#Region "<00.00.06> <Properties> <Information> [OriginalName   | String]"
        Private _OriginalName As String
        '''<summary> 
        '''(Set|Get) OriginalName
        '''</summary>
        <CategoryAttribute("Information"),
Description("(Set|Get) OriginalName"),
Browsable(True)>
        Public Property OriginalName As String
            Get
                Return _OriginalName
            End Get
            Set(ByVal value As String)
                _OriginalName = value
            End Set
        End Property
#End Region
#Region "<00.00.07> <Properties> <Information> [EnglishName   | String]"
        Private _EnglishName As String
        '''<summary> 
        '''(Set|Get) EnglishName
        '''</summary>
        <CategoryAttribute("Information"),
Description("(Set|Get) EnglishName"),
Browsable(True)>
        Public Property EnglishName As String
            Get
                Return _EnglishName
            End Get
            Set(ByVal value As String)
                _EnglishName = value
            End Set
        End Property
#End Region
        Public Overrides Function ToString() As String
            Return "<" & ID & "> " & EnglishName & " [" & OriginalName & "]"
        End Function
        Public Shared Function GetAllLanguages() As List(Of Langue_Item)
            Dim Result As New List(Of Langue_Item)
#Region "<Populate Information>"
            Dim item As New ListViewItem("0")
            item.SubItems.Add("Arabic")
            item.SubItems.Add("ARA")
            item.SubItems.Add("ARA")
            item.SubItems.Add("AR")
            item.SubItems.Add("Arabe")
            item.SubItems.Add("العربية")
            item.SubItems.Add("Arabic")
            item.ImageIndex = 0
            With Arabic
                .ID = Val(item.Text)
                .Name = item.SubItems(1).Text
                .Iso_693_3 = item.SubItems(2).Text
                .Iso_693_2 = item.SubItems(3).Text
                .Iso_693_1 = item.SubItems(4).Text
                .FrenchName = item.SubItems(5).Text
                .OriginalName = item.SubItems(6).Text
                .EnglishName = item.SubItems(7).Text
            End With
            MyLang.Add(Arabic)
            List_Lang.Items.Add(item)

            item = New ListViewItem("1")
            item.SubItems.Add("English")
            item.SubItems.Add("ENG")
            item.SubItems.Add("ENG")
            item.SubItems.Add("EN")
            item.SubItems.Add("Anglais")
            item.SubItems.Add("English")
            item.SubItems.Add("English")
            item.ImageIndex = 1
            With English
                .ID = Val(item.Text)
                .Name = item.SubItems(1).Text
                .Iso_693_3 = item.SubItems(2).Text
                .Iso_693_2 = item.SubItems(3).Text
                .Iso_693_1 = item.SubItems(4).Text
                .FrenchName = item.SubItems(5).Text
                .OriginalName = item.SubItems(6).Text
                .EnglishName = item.SubItems(7).Text
            End With
            MyLang.Add(English)
            List_Lang.Items.Add(item)
            item = New ListViewItem("2")
            item.SubItems.Add("Français")
            item.SubItems.Add("FRE/FRA")
            item.SubItems.Add("FRE/FRA")
            item.SubItems.Add("FR")
            item.SubItems.Add("Français")
            item.SubItems.Add("Français")
            item.SubItems.Add("French")
            item.ImageIndex = 2
            With French
                .ID = Val(item.Text)
                .Name = item.SubItems(1).Text
                .Iso_693_3 = item.SubItems(2).Text
                .Iso_693_2 = item.SubItems(3).Text
                .Iso_693_1 = item.SubItems(4).Text
                .FrenchName = item.SubItems(5).Text
                .OriginalName = item.SubItems(6).Text
                .EnglishName = item.SubItems(7).Text
            End With
            MyLang.Add(French)
            List_Lang.Items.Add(item)
            item = New ListViewItem("3")
            item.SubItems.Add("German")
            item.SubItems.Add("GER/DEU")
            item.SubItems.Add("GER/DEU")
            item.SubItems.Add("DE")
            item.SubItems.Add("Allemand")
            item.SubItems.Add("Deutsch")
            item.SubItems.Add("German")
            item.ImageIndex = 3
            With German
                .ID = Val(item.Text)
                .Name = item.SubItems(1).Text
                .Iso_693_3 = item.SubItems(2).Text
                .Iso_693_2 = item.SubItems(3).Text
                .Iso_693_1 = item.SubItems(4).Text
                .FrenchName = item.SubItems(5).Text
                .OriginalName = item.SubItems(6).Text
                .EnglishName = item.SubItems(7).Text
            End With
            MyLang.Add(German)
            List_Lang.Items.Add(item)
            item = New ListViewItem("4")
            item.SubItems.Add("Hebrew")
            item.SubItems.Add("HEB")
            item.SubItems.Add("HEB")
            item.SubItems.Add("HE")
            item.SubItems.Add("Hébreu")
            item.SubItems.Add("עִבְרִית, עברית")
            item.SubItems.Add("Hebrew")
            item.ImageIndex = 4
            With Hebrew
                .ID = Val(item.Text)
                .Name = item.SubItems(1).Text
                .Iso_693_3 = item.SubItems(2).Text
                .Iso_693_2 = item.SubItems(3).Text
                .Iso_693_1 = item.SubItems(4).Text
                .FrenchName = item.SubItems(5).Text
                .OriginalName = item.SubItems(6).Text
                .EnglishName = item.SubItems(7).Text
            End With
            MyLang.Add(Hebrew)
            List_Lang.Items.Add(item)
            item = New ListViewItem("5")
            item.SubItems.Add("Italian")
            item.SubItems.Add("ITA")
            item.SubItems.Add("ITA")
            item.SubItems.Add("IT")
            item.SubItems.Add("Italien")
            item.SubItems.Add("Italiano")
            item.SubItems.Add("Italian")
            item.ImageIndex = 5
            With Italian
                .ID = Val(item.Text)
                .Name = item.SubItems(1).Text
                .Iso_693_3 = item.SubItems(2).Text
                .Iso_693_2 = item.SubItems(3).Text
                .Iso_693_1 = item.SubItems(4).Text
                .FrenchName = item.SubItems(5).Text
                .OriginalName = item.SubItems(6).Text
                .EnglishName = item.SubItems(7).Text
            End With
            MyLang.Add(Italian)
            List_Lang.Items.Add(item)
            item = New ListViewItem("6")
            item.SubItems.Add("Portuguese")
            item.SubItems.Add("POR")
            item.SubItems.Add("POR")
            item.SubItems.Add("PT")
            item.SubItems.Add("Portugais")
            item.SubItems.Add("Português")
            item.SubItems.Add("Portuguese")
            item.ImageIndex = 6
            With Portuguese
                .ID = Val(item.Text)
                .Name = item.SubItems(1).Text
                .Iso_693_3 = item.SubItems(2).Text
                .Iso_693_2 = item.SubItems(3).Text
                .Iso_693_1 = item.SubItems(4).Text
                .FrenchName = item.SubItems(5).Text
                .OriginalName = item.SubItems(6).Text
                .EnglishName = item.SubItems(7).Text
            End With
            MyLang.Add(Portuguese)
            List_Lang.Items.Add(item)
            item = New ListViewItem("7")
            item.SubItems.Add("Russian")
            item.SubItems.Add("RUS")
            item.SubItems.Add("RUS")
            item.SubItems.Add("RU")
            item.SubItems.Add("Russe")
            item.SubItems.Add("русский язык")
            item.SubItems.Add("Russian")
            item.ImageIndex = 7
            With Russian
                .ID = Val(item.Text)
                .Name = item.SubItems(1).Text
                .Iso_693_3 = item.SubItems(2).Text
                .Iso_693_2 = item.SubItems(3).Text
                .Iso_693_1 = item.SubItems(4).Text
                .FrenchName = item.SubItems(5).Text
                .OriginalName = item.SubItems(6).Text
                .EnglishName = item.SubItems(7).Text
            End With
            MyLang.Add(Russian)
            List_Lang.Items.Add(item)
            item = New ListViewItem("8")
            item.SubItems.Add("Spanish")
            item.SubItems.Add("SPA")
            item.SubItems.Add("SPA")
            item.SubItems.Add("ES")
            item.SubItems.Add("Espagnol")
            item.SubItems.Add("Español")
            item.SubItems.Add("Spanish")
            item.ImageIndex = 8
            With Spanish
                .ID = Val(item.Text)
                .Name = item.SubItems(1).Text
                .Iso_693_3 = item.SubItems(2).Text
                .Iso_693_2 = item.SubItems(3).Text
                .Iso_693_1 = item.SubItems(4).Text
                .FrenchName = item.SubItems(5).Text
                .OriginalName = item.SubItems(6).Text
                .EnglishName = item.SubItems(7).Text
            End With
            MyLang.Add(Spanish)
            List_Lang.Items.Add(item)
            item = New ListViewItem("9")
            item.SubItems.Add("Chinese")
            item.SubItems.Add("CK")
            item.SubItems.Add("CK")
            item.SubItems.Add("CK")
            item.SubItems.Add("Chinise")
            item.SubItems.Add("Chinese")
            item.SubItems.Add("Chinese")
            item.ImageIndex = 9
            With Chinese
                .ID = Val(item.Text)
                .Name = item.SubItems(1).Text
                .Iso_693_3 = item.SubItems(2).Text
                .Iso_693_2 = item.SubItems(3).Text
                .Iso_693_1 = item.SubItems(4).Text
                .FrenchName = item.SubItems(5).Text
                .OriginalName = item.SubItems(6).Text
                .EnglishName = item.SubItems(7).Text
            End With
            MyLang.Add(Chinese)

            List_Lang.Items.Add(item)
            item = New ListViewItem("10")
            item.SubItems.Add("Japanese")
            item.SubItems.Add("JP")
            item.SubItems.Add("JP")
            item.SubItems.Add("JP")
            item.SubItems.Add("Japanese")
            item.SubItems.Add("Japanese")
            item.SubItems.Add("Japanese")
            item.ImageIndex = 10
            With Japanese
                .ID = Val(item.Text)
                .Name = item.SubItems(1).Text
                .Iso_693_3 = item.SubItems(2).Text
                .Iso_693_2 = item.SubItems(3).Text
                .Iso_693_1 = item.SubItems(4).Text
                .FrenchName = item.SubItems(5).Text
                .OriginalName = item.SubItems(6).Text
                .EnglishName = item.SubItems(7).Text
            End With
            MyLang.Add(Japanese)

            List_Lang.Items.Add(item)
            item = New ListViewItem("11")
            item.SubItems.Add("Greek")
            item.SubItems.Add("GK")
            item.SubItems.Add("GK")
            item.SubItems.Add("GK")
            item.SubItems.Add("Greek")
            item.SubItems.Add("Greek")
            item.SubItems.Add("Greek")
            item.ImageIndex = 11
            With Greek
                .ID = Val(item.Text)
                .Name = item.SubItems(1).Text
                .Iso_693_3 = item.SubItems(2).Text
                .Iso_693_2 = item.SubItems(3).Text
                .Iso_693_1 = item.SubItems(4).Text
                .FrenchName = item.SubItems(5).Text
                .OriginalName = item.SubItems(6).Text
                .EnglishName = item.SubItems(7).Text
            End With
            MyLang.Add(Greek)

            List_Lang.Items.Add(item)
            item = New ListViewItem("12")
            item.SubItems.Add("Latin")
            item.SubItems.Add("Lt")
            item.SubItems.Add("Lt")
            item.SubItems.Add("Lt")
            item.SubItems.Add("Latin")
            item.SubItems.Add("Latin")
            item.SubItems.Add("Latin")
            item.ImageIndex = 12
            With Latin
                .ID = Val(item.Text)
                .Name = item.SubItems(1).Text
                .Iso_693_3 = item.SubItems(2).Text
                .Iso_693_2 = item.SubItems(3).Text
                .Iso_693_1 = item.SubItems(4).Text
                .FrenchName = item.SubItems(5).Text
                .OriginalName = item.SubItems(6).Text
                .EnglishName = item.SubItems(7).Text
            End With
            MyLang.Add(Latin)

            List_Lang.Items.Add(item)
            item = New ListViewItem("13")
            item.SubItems.Add("Thai")
            item.SubItems.Add("Ti")
            item.SubItems.Add("Ti")
            item.SubItems.Add("Ti")
            item.SubItems.Add("Thai")
            item.SubItems.Add("Thai")
            item.SubItems.Add("Thai")
            item.ImageIndex = 13
            With Thai
                .ID = Val(item.Text)
                .Name = item.SubItems(1).Text
                .Iso_693_3 = item.SubItems(2).Text
                .Iso_693_2 = item.SubItems(3).Text
                .Iso_693_1 = item.SubItems(4).Text
                .FrenchName = item.SubItems(5).Text
                .OriginalName = item.SubItems(6).Text
                .EnglishName = item.SubItems(7).Text
            End With
            MyLang.Add(Thai)

            List_Lang.Items.Add(item)
            item = New ListViewItem("14")
            item.SubItems.Add("Th")
            item.SubItems.Add("Th")
            item.SubItems.Add("Th")
            item.SubItems.Add("Th")
            item.SubItems.Add("Turkish")
            item.SubItems.Add("Turkish")
            item.SubItems.Add("Turkish")
            item.ImageIndex = 14
            With Turkish
                .ID = Val(item.Text)
                .Name = item.SubItems(1).Text
                .Iso_693_3 = item.SubItems(2).Text
                .Iso_693_2 = item.SubItems(3).Text
                .Iso_693_1 = item.SubItems(4).Text
                .FrenchName = item.SubItems(5).Text
                .OriginalName = item.SubItems(6).Text
                .EnglishName = item.SubItems(7).Text
            End With
            MyLang.Add(Turkish)
            List_Lang.Items.Add(item)
            List_Lang.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

#End Region
            Result = MyLang
            Return Result
        End Function
    End Class



    Public Function ConvertLangue_ToInt(ByVal LangueName As String) As Enum_Langue
        Dim Result As Enum_Langue = Enum_Langue.Inconnu
        If LangueName = String.Empty Then
            MsgBox("langue vide")
            Result = Enum_Langue.Inconnu
        ElseIf LangueName = "Inconnu" Then
            Result = Enum_Langue.Arabic
        ElseIf LangueName = "Arabic" Then
            Result = Enum_Langue.Arabic
        ElseIf LangueName = "English" Then
            Result = Enum_Langue.English
        ElseIf LangueName = "Français" Then
            Result = Enum_Langue.Français
        ElseIf LangueName = "German" Then
            Result = Enum_Langue.German
        ElseIf LangueName = "Hebrew" Then
            Result = Enum_Langue.Hebrew
        ElseIf LangueName = "Italian" Then
            Result = Enum_Langue.Italian
        ElseIf LangueName = "Portuguese" Then
            Result = Enum_Langue.Portuguese
        ElseIf LangueName = "Russian" Then
            Result = Enum_Langue.Russian
        ElseIf LangueName = "Spanish" Then
            Result = Enum_Langue.Spanish
        ElseIf LangueName = "Chinese" Then
            Result = Enum_Langue.Chinese
        ElseIf LangueName = "Japanese" Then
            Result = Enum_Langue.Japanese
        ElseIf LangueName = "Greek" Then
            Result = Enum_Langue.Greek
        ElseIf LangueName = "Latin" Then
            Result = Enum_Langue.Latin
        ElseIf LangueName = "Thai" Then
            Result = Enum_Langue.Thai
        ElseIf LangueName = "Turkish" Then
            Result = Enum_Langue.Turkish
        End If
        Return Result
    End Function


    Public Function Display_ActiveLanguage() As S_Langue
        Dim Result As New S_Langue
        Result.Display = "Not tested"
        Result.Index = -1
        If My.Settings.Langue = Nothing Then
            My.Settings.Langue = "Français"
            My.Settings.Save()
            Result.Display = My.Settings.Langue
        Else
            Dim Index As Int32 = -1
            Dim Col As Integer = -1
            If List_Lang.Items.Count - 1 < 0 Then
                Index_Langue()
            End If
            For i = 0 To List_Lang.Items.Count - 1

                If My.Settings.Langue = List_Lang.Items(i).Text Then
                    Index = i
                    Col = 0
                Else
                    For it = 0 To List_Lang.Items(i).SubItems.Count - 1
                        If My.Settings.Langue = List_Lang.Items(i).SubItems(it).Text Then
                            Index = i
                            Col = it
                        End If
                    Next
                End If

            Next
            If Index = -1 Then
                Result.Display = List_Lang.Items(2).SubItems(5).Text
                My.Settings.Langue = Result.Display
                My.Settings.Save()
                Result.Index = 2
                Index = 2
            Else
                Result.Display = List_Lang.Items(Index).SubItems(5).Text
                My.Settings.Langue = Result.Display
                My.Settings.Save()
                Result.Index = Index
            End If
        End If
        Return Result
    End Function
    Public Sub Langue_Set(ByVal Langue As S_Langue)
        If Langue.Index = Enum_Langue.Arabic Then
            Langue.Display = "Arabic"
            My.Settings.Langue = Langue.Display
        ElseIf Langue.Index = Enum_Langue.English Then
            Langue.Display = "English"
            My.Settings.Langue = Langue.Display
        ElseIf Langue.Index = Enum_Langue.Français Then
            Langue.Display = "Français"
            My.Settings.Langue = Langue.Display
        ElseIf Langue.Index = Enum_Langue.German Then
            Langue.Display = "German"
            My.Settings.Langue = Langue.Display
        ElseIf Langue.Index = Enum_Langue.Hebrew Then
            Langue.Display = "Hebrew"
            My.Settings.Langue = Langue.Display
        ElseIf Langue.Index = Enum_Langue.Italian Then
            Langue.Display = "Italian"
            My.Settings.Langue = Langue.Display
        ElseIf Langue.Index = Enum_Langue.Portuguese Then
            Langue.Display = "Portuguese"
            My.Settings.Langue = Langue.Display
        ElseIf Langue.Index = Enum_Langue.Russian Then
            Langue.Display = "Russian"
            My.Settings.Langue = Langue.Display
        ElseIf Langue.Index = Enum_Langue.Spanish Then
            Langue.Display = "Spanish"
            My.Settings.Langue = Langue.Display
        ElseIf Langue.Index = Enum_Langue.Chinese Then
            Langue.Display = "Chinese"
            My.Settings.Langue = Langue.Display
        ElseIf Langue.Index = Enum_Langue.Japanese Then
            Langue.Display = "Japanese"
            My.Settings.Langue = Langue.Display
        ElseIf Langue.Index = Enum_Langue.Greek Then
            Langue.Display = "Greek"
            My.Settings.Langue = Langue.Display
        ElseIf Langue.Index = Enum_Langue.Latin Then
            Langue.Display = "Latin"
            My.Settings.Langue = Langue.Display
        ElseIf Langue.Index = Enum_Langue.Thai Then
            Langue.Display = "Thai"
            My.Settings.Langue = Langue.Display
        ElseIf Langue.Index = Enum_Langue.Turkish Then
            Langue.Display = "Turkish"
            My.Settings.Langue = Langue.Display
        End If
        My.Settings.Save()
    End Sub


    Public Sub Langue_Set(ByVal LangueX As Enum_Langue)
        Dim Result As New S_Langue
        If LangueX = Enum_Langue.Arabic Then
            Result.Display = "Arabic"
            My.Settings.Langue = Result.Display
        ElseIf LangueX = Enum_Langue.English Then
            Result.Display = "English"
            My.Settings.Langue = Result.Display
        ElseIf LangueX = Enum_Langue.Français Then
            Result.Display = "Français"
            My.Settings.Langue = Result.Display
        ElseIf LangueX = Enum_Langue.German Then
            Result.Display = "German"
            My.Settings.Langue = Result.Display
        ElseIf LangueX = Enum_Langue.Italian Then
            Result.Display = "Italian"
            My.Settings.Langue = Result.Display
        ElseIf LangueX = Enum_Langue.Russian Then
            Result.Display = "Russian"
            My.Settings.Langue = Result.Display
        ElseIf LangueX = Enum_Langue.Spanish Then
            Result.Display = "Spanish"
            My.Settings.Langue = Result.Display

        ElseIf LangueX = Enum_Langue.Hebrew Then
            Result.Display = "Hebrew"
            My.Settings.Langue = Result.Display
        ElseIf LangueX = Enum_Langue.Portuguese Then
            Result.Display = "Portuguese"
            My.Settings.Langue = Result.Display
        ElseIf LangueX = Enum_Langue.Chinese Then
            Result.Display = "Chinese"
            My.Settings.Langue = Result.Display
        ElseIf LangueX = Enum_Langue.Japanese Then
            Result.Display = "Japanese"
            My.Settings.Langue = Result.Display
        ElseIf LangueX = Enum_Langue.Greek Then
            Result.Display = "Greek"
            My.Settings.Langue = Result.Display
        ElseIf LangueX = Enum_Langue.Latin Then
            Result.Display = "Latin"
            My.Settings.Langue = Result.Display
        ElseIf LangueX = Enum_Langue.Thai Then
            Result.Display = "Thai"
            My.Settings.Langue = Result.Display
        ElseIf LangueX = Enum_Langue.Thai Then
            Result.Display = "Turkish"
            My.Settings.Langue = Result.Display
        End If
        Result.Index = LangueX
        Langue = Result
        My.Settings.Save()

    End Sub

    Public Function Langue_Set(ByVal Langueitem As String) As S_Langue
        Dim Result As New S_Langue
        Dim Index As Int32 = -1
        Dim Col As Integer = -1
        If List_Lang.Items.Count - 1 < 0 Then
            Index_Langue()
        End If
        For i = 0 To List_Lang.Items.Count - 1
            If Langueitem = List_Lang.Items(i).SubItems(5).Text Then
                Index = i
                Col = 5
            ElseIf Langueitem = List_Lang.Items(i).SubItems(6).Text Then
                Index = i
                Col = 6

            ElseIf Langueitem = List_Lang.Items(i).SubItems(7).Text Then
                Index = i
                Col = 7
            End If
        Next
        If Index = -1 Then
            'MsgBox("Item not found!")
        Else
            Result.Display = List_Lang.Items(Index).SubItems(Col).Text
            My.Settings.Langue = Result.Display
            My.Settings.Save()
            Result.Index = Index
        End If

        Langue = Result
        Return Result
    End Function
    Public Enum Enum_Langue
        Arabic
        English
        Français
        German
        Hebrew
        Italian
        Portuguese
        Russian
        Spanish
        Inconnu
        Chinese
        Japanese
        Greek
        Latin
        Thai
        Turkish
    End Enum
#End Region

#End Region
End Module
