Imports System.ComponentModel
Imports System.IO
Imports System.Windows.Forms
Imports SmartCoder.M_FileManager
Imports SmartCoder.M_Info
Imports SmartCoder.M_Microsoft

Public Module M_TimeSheet

#Region "[On] |2019/06/25 22h50:924| <08.00.00> <Class> <> |.VirtualClass|Class|{11} |Production Cost : 467.5|Selling Price : 701.25|"' 
    '    Object Name : Public  Class VirtualClass
    '         Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
    '         Contributor Information : ||
    '         Creation Date :           2019/06/25 22h50:924
    '         |Schema|
    '         |ID| |ObjectType |{Quantity}||UnitPrice||Total
    '         |00| |Importation|{0}||1| |0
    '         |01| |Properties |{106}||0.8| |84.8
    '         |02| |Enumeration|{10}||0.4| |4
    '         |03| |Structure  |{0}||0.4| |0
    '         |04| |Sub        |{51}||1.2| |61.2
    '         |05| |Function   |{73}||1.6| |116.8
    '         |06| |Runtime    |{124}||0.4| |49.6
    '         |07| |Loader     |{22}||0.8| |17.6
    '         |08| |Class      |{11}||2| |22
    '         |09| |Constante  |{0}||0.4| |0
    '         |10| |Event      |{0}||1.2| |0
    '         |11| |Members    |{84}||0.5| |42
    '         |12| |Parameter  |{139}||0.5| |69.5
    '         |Production Cost             |467.5
    '         |Selling Price without VAT   |701.25
    '         |Total TVA                   |54
    '         |Grand Total                 |755.25
    '         |/Schema|
    '         <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
    '         <AuthorName>David Shaw Informatique Sàrl</AuthorName>
    '         <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
    '         <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:253 </Published>
    '         <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
#Region "[On] |2019/06/25 22h50:924| <08.00.00> <Class> <> |.VirtualClass|Class|"' 
#Region "[On] |2019/06/25 22h51:704| <08.00.00> <Class> <> |.Clients|Class|{51} |Production Cost : 69.7|Selling Price : 104.55|"' Class created automatically by SmartOffice (c)Copyright 2019.
    '''    <Summary>
    '''     Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Clients
    '''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
    '''    Contributor Information : ||
    '''    Creation Date :           2019/06/25 22h51:704
    '''    |Schema|
    '''    |ID| |ObjectType |{Quantity}||UnitPrice||Total
    '''    |00| |Importation|{0}||1| |0
    '''    |01| |Properties |{24}||0.8| |19.2
    '''    |02| |Enumeration|{1}||0.4| |0.4
    '''    |03| |Structure  |{0}||0.4| |0
    '''    |04| |Sub        |{5}||1.2| |6
    '''    |05| |Function   |{7}||1.6| |11.2
    '''    |06| |Runtime    |{12}||0.4| |4.8
    '''    |07| |Loader     |{2}||0.8| |1.6
    '''    |08| |Class      |{0}||2| |0
    '''    |09| |Constante  |{0}||0.4| |0
    '''    |10| |Event      |{0}||1.2| |0
    '''    |11| |Members    |{24}||0.5| |12
    '''    |12| |Parameter  |{29}||0.5| |14.5
    '''    |Production Cost             |69.7
    '''    |Selling Price without VAT   |104.55
    '''    |Total TVA                   |8.05
    '''    |Grand Total                 |112.6
    '''    |/Schema|
    '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
    '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
    '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
    '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:253 </Published>
    '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
    '''    </Summary>
    Public Class Clients
#Region "<1> [Property]{23}"
#Region "[On] |2019/06/26 00h16:488| <01.00.00> <Property> <Columns> |.Ref()|String|"' (Set|Get) The Ref as String.
        Private _Ref As String
        '''    <Summary>
        '''     (Set|Get) The Ref as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:599 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Ref as String.")>
        Public Property Ref() As String
            Get
                Return _Ref
            End Get
            Set(ByVal Value As String)
                _Ref = Value
            End Set
        End Property
#End Region '(Set|Get) The Ref as String.

#Region "[On] |2019/06/26 00h16:743| <01.00.01> <Property> <Columns> |.Active()|Boolean|"' (Set|Get) The Active as Boolean.
        Private _Active As Boolean
        '''    <Summary>
        '''     (Set|Get) The Active as Boolean.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:599 </Published>
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

#Region "[On] |2019/06/26 00h16:758| <01.00.02> <Property> <Columns> |.RaisonSociale()|String|"' (Set|Get) The RaisonSociale as String.
        Private _RaisonSociale As String
        '''    <Summary>
        '''     (Set|Get) The RaisonSociale as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:599 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The RaisonSociale as String.")>
        Public Property RaisonSociale() As String
            Get
                Return _RaisonSociale
            End Get
            Set(ByVal Value As String)
                _RaisonSociale = Value
            End Set
        End Property
#End Region '(Set|Get) The RaisonSociale as String.

#Region "[On] |2019/06/26 00h16:770| <01.00.03> <Property> <Columns> |.NomClient()|String|"' (Set|Get) The NomClient as String.
        Private _NomClient As String
        '''    <Summary>
        '''     (Set|Get) The NomClient as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:600 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The NomClient as String.")>
        Public Property NomClient() As String
            Get
                Return _NomClient
            End Get
            Set(ByVal Value As String)
                _NomClient = Value
            End Set
        End Property
#End Region '(Set|Get) The NomClient as String.

#Region "[On] |2019/06/26 00h16:781| <01.00.04> <Property> <Columns> |.Address1()|String|"' (Set|Get) The Address1 as String.
        Private _Address1 As String
        '''    <Summary>
        '''     (Set|Get) The Address1 as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:600 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Address1 as String.")>
        Public Property Address1() As String
            Get
                Return _Address1
            End Get
            Set(ByVal Value As String)
                _Address1 = Value
            End Set
        End Property
#End Region '(Set|Get) The Address1 as String.

#Region "[On] |2019/06/26 00h16:794| <01.00.05> <Property> <Columns> |.Address2()|String|"' (Set|Get) The Address2 as String.
        Private _Address2 As String
        '''    <Summary>
        '''     (Set|Get) The Address2 as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:600 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Address2 as String.")>
        Public Property Address2() As String
            Get
                Return _Address2
            End Get
            Set(ByVal Value As String)
                _Address2 = Value
            End Set
        End Property
#End Region '(Set|Get) The Address2 as String.

#Region "[On] |2019/06/26 00h16:805| <01.00.06> <Property> <Columns> |.PostalCode()|String|"' (Set|Get) The PostalCode as String.
        Private _PostalCode As String
        '''    <Summary>
        '''     (Set|Get) The PostalCode as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:600 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The PostalCode as String.")>
        Public Property PostalCode() As String
            Get
                Return _PostalCode
            End Get
            Set(ByVal Value As String)
                _PostalCode = Value
            End Set
        End Property
#End Region '(Set|Get) The PostalCode as String.

#Region "[On] |2019/06/26 00h16:817| <01.00.07> <Property> <Columns> |.Region()|String|"' (Set|Get) The Region as String.
        Private _Region As String
        '''    <Summary>
        '''     (Set|Get) The Region as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:601 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Region as String.")>
        Public Property Region() As String
            Get
                Return _Region
            End Get
            Set(ByVal Value As String)
                _Region = Value
            End Set
        End Property
#End Region '(Set|Get) The Region as String.

#Region "[On] |2019/06/26 00h16:829| <01.00.08> <Property> <Columns> |.City()|String|"' (Set|Get) The City as String.
        Private _City As String
        '''    <Summary>
        '''     (Set|Get) The City as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:601 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The City as String.")>
        Public Property City() As String
            Get
                Return _City
            End Get
            Set(ByVal Value As String)
                _City = Value
            End Set
        End Property
#End Region '(Set|Get) The City as String.

#Region "[On] |2019/06/26 00h16:840| <01.00.09> <Property> <Columns> |.Country()|String|"' (Set|Get) The Country as String.
        Private _Country As String
        '''    <Summary>
        '''     (Set|Get) The Country as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:601 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Country as String.")>
        Public Property Country() As String
            Get
                Return _Country
            End Get
            Set(ByVal Value As String)
                _Country = Value
            End Set
        End Property
#End Region '(Set|Get) The Country as String.

#Region "[On] |2019/06/26 00h16:852| <01.00.10> <Property> <Columns> |.Landline()|String|"' (Set|Get) The Landline as String.
        Private _Landline As String
        '''    <Summary>
        '''     (Set|Get) The Landline as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:601 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Landline as String.")>
        Public Property Landline() As String
            Get
                Return _Landline
            End Get
            Set(ByVal Value As String)
                _Landline = Value
            End Set
        End Property
#End Region '(Set|Get) The Landline as String.

#Region "[On] |2019/06/26 00h16:864| <01.00.11> <Property> <Columns> |.Fax()|String|"' (Set|Get) The Fax as String.
        Private _Fax As String
        '''    <Summary>
        '''     (Set|Get) The Fax as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:601 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Fax as String.")>
        Public Property Fax() As String
            Get
                Return _Fax
            End Get
            Set(ByVal Value As String)
                _Fax = Value
            End Set
        End Property
#End Region '(Set|Get) The Fax as String.

#Region "[On] |2019/06/26 00h16:876| <01.00.12> <Property> <Columns> |.Cell()|String|"' (Set|Get) The Cell as String.
        Private _Cell As String
        '''    <Summary>
        '''     (Set|Get) The Cell as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:602 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Cell as String.")>
        Public Property Cell() As String
            Get
                Return _Cell
            End Get
            Set(ByVal Value As String)
                _Cell = Value
            End Set
        End Property
#End Region '(Set|Get) The Cell as String.

#Region "[On] |2019/06/26 00h16:888| <01.00.13> <Property> <Columns> |.Email()|String|"' (Set|Get) The Email as String.
        Private _Email As String
        '''    <Summary>
        '''     (Set|Get) The Email as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:602 </Published>
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

#Region "[On] |2019/06/26 00h16:900| <01.00.14> <Property> <Columns> |.Website()|String|"' (Set|Get) The Website as String.
        Private _Website As String
        '''    <Summary>
        '''     (Set|Get) The Website as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:602 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Website as String.")>
        Public Property Website() As String
            Get
                Return _Website
            End Get
            Set(ByVal Value As String)
                _Website = Value
            End Set
        End Property
#End Region '(Set|Get) The Website as String.

#Region "[On] |2019/06/26 00h16:912| <01.00.15> <Property> <Columns> |.Pcompta()|String|"' (Set|Get) The Pcompta as String.
        Private _Pcompta As String
        '''    <Summary>
        '''     (Set|Get) The Pcompta as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:602 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Pcompta as String.")>
        Public Property Pcompta() As String
            Get
                Return _Pcompta
            End Get
            Set(ByVal Value As String)
                _Pcompta = Value
            End Set
        End Property
#End Region '(Set|Get) The Pcompta as String.

#Region "[On] |2019/06/26 00h16:924| <01.00.16> <Property> <Columns> |.Other()|String|"' (Set|Get) The Other as String.
        Private _Other As String
        '''    <Summary>
        '''     (Set|Get) The Other as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:602 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Other as String.")>
        Public Property Other() As String
            Get
                Return _Other
            End Get
            Set(ByVal Value As String)
                _Other = Value
            End Set
        End Property
#End Region '(Set|Get) The Other as String.

#Region "[On] |2019/06/26 00h16:938| <01.00.17> <Property> <Columns> |.Répertoire()|String|"' (Set|Get) The Répertoire as String.
        Private _Répertoire As String
        '''    <Summary>
        '''     (Set|Get) The Répertoire as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:603 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Répertoire as String.")>
        Public Property Répertoire() As String
            Get
                Return _Répertoire
            End Get
            Set(ByVal Value As String)
                _Répertoire = Value
            End Set
        End Property
#End Region '(Set|Get) The Répertoire as String.

#Region "[On] |2019/06/26 00h16:951| <01.00.18> <Property> <Columns> |.Forfait()|Boolean|"' (Set|Get) The Forfait as Boolean.
        Private _Forfait As Boolean
        '''    <Summary>
        '''     (Set|Get) The Forfait as Boolean.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:603 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Forfait as Boolean.")>
        Public Property Forfait() As Boolean
            Get
                Return _Forfait
            End Get
            Set(ByVal Value As Boolean)
                _Forfait = Value
            End Set
        End Property
#End Region '(Set|Get) The Forfait as Boolean.

#Region "[On] |2019/06/26 00h16:963| <01.00.19> <Property> <Columns> |.ForfaitValue()|Double|"' (Set|Get) The ForfaitValue as Double.
        Private _ForfaitValue As Double
        '''    <Summary>
        '''     (Set|Get) The ForfaitValue as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:603 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The ForfaitValue as Double.")>
        Public Property ForfaitValue() As Double
            Get
                Return _ForfaitValue
            End Get
            Set(ByVal Value As Double)
                _ForfaitValue = Value
            End Set
        End Property
#End Region '(Set|Get) The ForfaitValue as Double.

#Region "[On] |2019/06/26 00h16:975| <01.00.20> <Property> <Columns> |.CHE()|String|"' (Set|Get) The CHE as String.
        Private _CHE As String
        '''    <Summary>
        '''     (Set|Get) The CHE as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:605 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The CHE as String.")>
        Public Property CHE() As String
            Get
                Return _CHE
            End Get
            Set(ByVal Value As String)
                _CHE = Value
            End Set
        End Property
#End Region '(Set|Get) The CHE as String.

#Region "[On] |2019/06/26 00h16:988| <01.00.21> <Property> <Columns> |.IDE()|String|"' (Set|Get) The IDE as String.
        Private _IDE As String
        '''    <Summary>
        '''     (Set|Get) The IDE as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:605 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The IDE as String.")>
        Public Property IDE() As String
            Get
                Return _IDE
            End Get
            Set(ByVal Value As String)
                _IDE = Value
            End Set
        End Property
#End Region '(Set|Get) The IDE as String.

#Region "[On] |2019/06/26 00h16:000| <01.00.22> <Property> <Columns> |.Zefix()|String|"' (Set|Get) The Zefix as String.
        Private _Zefix As String
        '''    <Summary>
        '''     (Set|Get) The Zefix as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:605 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Zefix as String.")>
        Public Property Zefix() As String
            Get
                Return _Zefix
            End Get
            Set(ByVal Value As String)
                _Zefix = Value
            End Set
        End Property
#End Region '(Set|Get) The Zefix as String.

#End Region
#Region "<2> [Enumeration]{1}"
#Region "[On] |2019/06/26 00h16:020| <02.00.00> <Enumeration> <> |.Schema()|Enumeration{22}|"' (Set|Get) The enumeration of Schema.
        '''    <Summary>
        '''     (Set|Get) The enumeration of Schema.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:605 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The enumeration of Schema.")>
        Enum Schema
            ''' <summary>(Set|Get) The Ref as String.</summary>
            [Ref] = 0
            ''' <summary>(Set|Get) The Active as Boolean.</summary>
            [Active] = 1
            ''' <summary>(Set|Get) The RaisonSociale as String.</summary>
            [RaisonSociale] = 2
            ''' <summary>(Set|Get) The NomClient as String.</summary>
            [NomClient] = 3
            ''' <summary>(Set|Get) The Address1 as String.</summary>
            [Address1] = 4
            ''' <summary>(Set|Get) The Address2 as String.</summary>
            [Address2] = 5
            ''' <summary>(Set|Get) The PostalCode as String.</summary>
            [PostalCode] = 6
            ''' <summary>(Set|Get) The Region as String.</summary>
            [Region] = 7
            ''' <summary>(Set|Get) The City as String.</summary>
            [City] = 8
            ''' <summary>(Set|Get) The Country as String.</summary>
            [Country] = 9
            ''' <summary>(Set|Get) The Landline as String.</summary>
            [Landline] = 10
            ''' <summary>(Set|Get) The Fax as String.</summary>
            [Fax] = 11
            ''' <summary>(Set|Get) The Cell as String.</summary>
            [Cell] = 12
            ''' <summary>(Set|Get) The Email as String.</summary>
            [Email] = 13
            ''' <summary>(Set|Get) The Website as String.</summary>
            [Website] = 14
            ''' <summary>(Set|Get) The Pcompta as String.</summary>
            [Pcompta] = 15
            ''' <summary>(Set|Get) The Other as String.</summary>
            [Other] = 16
            ''' <summary>(Set|Get) The Répertoire as String.</summary>
            [Répertoire] = 17
            ''' <summary>(Set|Get) The Forfait as Boolean.</summary>
            [Forfait] = 18
            ''' <summary>(Set|Get) The ForfaitValue as Double.</summary>
            [ForfaitValue] = 19
            ''' <summary>(Set|Get) The CHE as String.</summary>
            [CHE] = 20
            ''' <summary>(Set|Get) The IDE as String.</summary>
            [IDE] = 21
            ''' <summary>(Set|Get) The Zefix as String.</summary>
            [Zefix] = 22
        End Enum
#End Region '(Set|Get) The enumeration of Schema.

#End Region
#Region "<4> [Sub]{5}"
#Region "[On] |2019/06/26 00h16:172| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
        '''    <Summary>
        '''     (Set|Get) This will reinitialize the class element.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:606 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will reinitialize the class element.")>
        Public Sub Clear()
            With Me
                .Ref = Nothing
                .Active = False
                .RaisonSociale = Nothing
                .NomClient = Nothing
                .Address1 = Nothing
                .Address2 = Nothing
                .PostalCode = Nothing
                .Region = Nothing
                .City = Nothing
                .Country = Nothing
                .Landline = Nothing
                .Fax = Nothing
                .Cell = Nothing
                .Email = Nothing
                .Website = Nothing
                .Pcompta = Nothing
                .Other = Nothing
                .Répertoire = Nothing
                .Forfait = False
                .ForfaitValue = 0
                .CHE = Nothing
                .IDE = Nothing
                .Zefix = Nothing
            End With
        End Sub
#End Region '(Set|Get) This will reinitialize the class element.

#Region "[On] |2019/06/26 00h16:318| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
        '''    <Summary>
        '''     (Set|Get) This will reinitialize the variables of this class.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:606 </Published>
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
                    TableName = "Clients"
                    Line = Connector.Line
                    UseSQL = False
                Else
                    FilePath = My.Settings.Db_TimeSheet_FilePath
                    Password = My.Settings.Db_TimeSheet_Password
                    Me.Line = My.Settings.Db_TimeSheet_Line
                    TableName = "Clients"
                    UseSQL = False
                End If
            Else
                If IsNothing(FilePath) Then
                    FilePath = My.Settings.Db_TimeSheet_FilePath
                End If
                If FilePath.Length < 1 Then
                    FilePath = My.Settings.Db_TimeSheet_FilePath
                End If
                FilePath = My.Settings.Db_TimeSheet_FilePath
                Password = My.Settings.Db_TimeSheet_Password
                Me.Line = My.Settings.Db_TimeSheet_Line
                TableName = "Clients"
                UseSQL = False
            End If

        End Sub
#End Region '(Set|Get) This will reinitialize the variables of this class.

#Region "[On] |2019/06/26 00h16:339| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
        '''    <Summary>
        '''     (Set|Get) This will add a new row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:606 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will add a new row in the table.")>
        Public Sub Add()
            Try
                Dim Str As String = Nothing
                Str = "Insert Into [Clients] (
`Ref`, 
`Active`, 
`RaisonSociale`, 
`NomClient`, 
`Address1`, 
`Address2`, 
`PostalCode`, 
`Region`, 
`City`, 
`Country`, 
`Landline`, 
`Fax`, 
`Cell`, 
`Email`, 
`Website`, 
`Pcompta`, 
`Other`, 
`Répertoire`, 
`Forfait`, 
`ForfaitValue`, 
`CHE`, 
`IDE`, 
`Zefix`) Values (@0, @1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18, @19, @20, @21, @22)"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@0", Me.Ref)
                Cmd.Parameters.AddWithValue("@1", Me.Active)
                Cmd.Parameters.AddWithValue("@2", Me.RaisonSociale)
                Cmd.Parameters.AddWithValue("@3", Me.NomClient)
                Cmd.Parameters.AddWithValue("@4", Me.Address1)
                Cmd.Parameters.AddWithValue("@5", Me.Address2)
                Cmd.Parameters.AddWithValue("@6", Me.PostalCode)
                Cmd.Parameters.AddWithValue("@7", Me.Region)
                Cmd.Parameters.AddWithValue("@8", Me.City)
                Cmd.Parameters.AddWithValue("@9", Me.Country)
                Cmd.Parameters.AddWithValue("@10", Me.Landline)
                Cmd.Parameters.AddWithValue("@11", Me.Fax)
                Cmd.Parameters.AddWithValue("@12", Me.Cell)
                Cmd.Parameters.AddWithValue("@13", Me.Email)
                Cmd.Parameters.AddWithValue("@14", Me.Website)
                Cmd.Parameters.AddWithValue("@15", Me.Pcompta)
                Cmd.Parameters.AddWithValue("@16", Me.Other)
                Cmd.Parameters.AddWithValue("@17", Me.Répertoire)
                Cmd.Parameters.AddWithValue("@18", Me.Forfait)
                Cmd.Parameters.AddWithValue("@19", Me.ForfaitValue)
                Cmd.Parameters.AddWithValue("@20", Me.CHE)
                Cmd.Parameters.AddWithValue("@21", Me.IDE)
                Cmd.Parameters.AddWithValue("@22", Me.Zefix)
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

#Region "[On] |2019/06/26 00h16:354| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
        '''    <Summary>
        '''     (Set|Get) This will update a row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:606 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will update a row in the table.")>
        Public Sub Save()
            Try
                Dim Str As String = Nothing
                Str = "UPDATE [Clients] SET Active = @Active, RaisonSociale = @RaisonSociale, NomClient = @NomClient, Address1 = @Address1, Address2 = @Address2, PostalCode = @PostalCode, Region = @Region, City = @City, Country = @Country, Landline = @Landline, Fax = @Fax, Cell = @Cell, Email = @Email, Website = @Website, Pcompta = @Pcompta, Other = @Other, Répertoire = @Répertoire, Forfait = @Forfait, ForfaitValue = @ForfaitValue, CHE = @CHE, IDE = @IDE, Zefix = @Zefix WHERE Ref = @Ref"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@Active", Active)
                Cmd.Parameters.AddWithValue("@RaisonSociale", RaisonSociale)
                Cmd.Parameters.AddWithValue("@NomClient", NomClient)
                Cmd.Parameters.AddWithValue("@Address1", Address1)
                Cmd.Parameters.AddWithValue("@Address2", Address2)
                Cmd.Parameters.AddWithValue("@PostalCode", PostalCode)
                Cmd.Parameters.AddWithValue("@Region", Region)
                Cmd.Parameters.AddWithValue("@City", City)
                Cmd.Parameters.AddWithValue("@Country", Country)
                Cmd.Parameters.AddWithValue("@Landline", Landline)
                Cmd.Parameters.AddWithValue("@Fax", Fax)
                Cmd.Parameters.AddWithValue("@Cell", Cell)
                Cmd.Parameters.AddWithValue("@Email", Email)
                Cmd.Parameters.AddWithValue("@Website", Website)
                Cmd.Parameters.AddWithValue("@Pcompta", Pcompta)
                Cmd.Parameters.AddWithValue("@Other", Other)
                Cmd.Parameters.AddWithValue("@Répertoire", Répertoire)
                Cmd.Parameters.AddWithValue("@Forfait", Forfait)
                Cmd.Parameters.AddWithValue("@ForfaitValue", ForfaitValue)
                Cmd.Parameters.AddWithValue("@CHE", CHE)
                Cmd.Parameters.AddWithValue("@IDE", IDE)
                Cmd.Parameters.AddWithValue("@Zefix", Zefix)
                Cmd.Parameters.AddWithValue("@Ref", Ref)
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

#Region "[On] |2019/06/26 00h16:375| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
        '''    <Summary>
        '''     (Set|Get) This will Delete a row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:606 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will Delete a row in the table.")>
        Public Sub Delete()
            Try
                Dim Str As String = Nothing
                Str = "Delete From [Clients] WHERE Ref =@Ref"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@Ref", Ref)
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
#Region "[On] |2019/06/26 00h16:389| <05.00.00> <Function> <> |.Open()|TestItem}|"' (Set|Get) This will initialise the connection and import the data.
        '''    <Summary>
        '''     (Set|Get) This will initialise the connection and import the data.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:606 </Published>
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

#Region "[On] |2019/06/26 00h16:527| <05.00.01> <Function> <> |.Close()|TestItem}|"' (Set|Get) This willClosing the connection
        '''    <Summary>
        '''     (Set|Get) This willClosing the connection
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:606 </Published>
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

#Region "[On] |2019/06/26 00h16:542| <05.00.02> <Function> <> |.List()|List(Of Clients)}|"' (Set|Get) Return the entire table listed
        '''    <Summary>
        '''     (Set|Get) Return the entire table listed
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:607 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Return the entire table listed")>
        Public Function List() As List(Of Clients)
            Dim Result As New List(Of Clients)
            Me.Table = New Table(Me.TableName, Me.FilePath, Me.Password, False)
            For Each Row As DataRow In Me.Table.DataTable.Rows
                Dim Element As New Clients(IIf(IsDBNull(Row.Item(0)), "", Row.Item(0)),
IIf(IsDBNull(Row.Item(1)), False, Row.Item(1)),
IIf(IsDBNull(Row.Item(2)), "", Row.Item(2)),
IIf(IsDBNull(Row.Item(3)), "", Row.Item(3)),
IIf(IsDBNull(Row.Item(4)), "", Row.Item(4)),
IIf(IsDBNull(Row.Item(5)), "", Row.Item(5)),
IIf(IsDBNull(Row.Item(6)), "", Row.Item(6)),
IIf(IsDBNull(Row.Item(7)), "", Row.Item(7)),
IIf(IsDBNull(Row.Item(8)), "", Row.Item(8)),
IIf(IsDBNull(Row.Item(9)), "", Row.Item(9)),
IIf(IsDBNull(Row.Item(10)), "", Row.Item(10)),
IIf(IsDBNull(Row.Item(11)), "", Row.Item(11)),
IIf(IsDBNull(Row.Item(12)), "", Row.Item(12)),
IIf(IsDBNull(Row.Item(13)), "", Row.Item(13)),
IIf(IsDBNull(Row.Item(14)), "", Row.Item(14)),
IIf(IsDBNull(Row.Item(15)), "", Row.Item(15)),
IIf(IsDBNull(Row.Item(16)), "", Row.Item(16)),
IIf(IsDBNull(Row.Item(17)), "", Row.Item(17)),
IIf(IsDBNull(Row.Item(18)), False, Row.Item(18)),
IIf(IsDBNull(Row.Item(19)), 0, Row.Item(19)),
IIf(IsDBNull(Row.Item(20)), "", Row.Item(20)),
IIf(IsDBNull(Row.Item(21)), "", Row.Item(21)),
      IIf(IsDBNull(Row.Item(22)), "", Row.Item(22)))
                Element.Reset(Table.Line)
                Result.Add(Element)
            Next
            Return Result
        End Function
#End Region '(Set|Get) Return the entire table listed

#Region "[On] |2019/06/26 00h16:559| <05.00.03> <Function> <> |.SearchByName()|List(Of Clients)}|"' (Set|Get) Search for each property that match the Search String.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search String.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:607 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Search for each property that match the Search String.")>
        Public Shared Function SearchByName(ByVal Search As String) As List(Of Clients)
            Dim Result As New List(Of Clients)
            Dim C As New Clients
            For Each Element As Clients In C.List
                If Element.Ref.ToLower() = Search.ToLower() Or Element.RaisonSociale.ToLower() = Search.ToLower() Or Element.NomClient.ToLower() = Search.ToLower() Or Element.Address1.ToLower() = Search.ToLower() Or Element.Address2.ToLower() = Search.ToLower() Or Element.PostalCode.ToLower() = Search.ToLower() Or Element.Region.ToLower() = Search.ToLower() Or Element.City.ToLower() = Search.ToLower() Or Element.Country.ToLower() = Search.ToLower() Or Element.Landline.ToLower() = Search.ToLower() Or Element.Fax.ToLower() = Search.ToLower() Or Element.Cell.ToLower() = Search.ToLower() Or Element.Email.ToLower() = Search.ToLower() Or Element.Website.ToLower() = Search.ToLower() Or Element.Pcompta.ToLower() = Search.ToLower() Or Element.Other.ToLower() = Search.ToLower() Or Element.Répertoire.ToLower() = Search.ToLower() Or Element.CHE.ToLower() = Search.ToLower() Or Element.IDE.ToLower() = Search.ToLower() Or Element.Zefix.ToLower() = Search.ToLower() Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search String.

#Region "[On] |2019/06/26 00h16:575| <05.00.04> <Function> <> |.SearchByID()|List(Of Clients)}|"' (Set|Get) Search for each property that match the Search Id.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search Id.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:607 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Search for each property that match the Search Id.")>
        Public Shared Function SearchByID(ByVal Search As Double) As List(Of Clients)
            Dim Result As New List(Of Clients)
            Dim C As New Clients
            For Each Element As Clients In C.List
                If Val(Element.Ref) = Search Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search Id.

#Region "[On] |2019/06/26 00h16:590| <05.00.05> <Function> <> |.ToString()|String}|"' (Set|Get) The function ToString.
        '''    <Summary>
        '''     (Set|Get) The function ToString.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:607 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The function ToString.")>
        Public Overrides Function ToString() As String
            Return Me.Ref
        End Function
#End Region '(Set|Get) The function ToString.

#Region "[On] |2019/06/26 00h16:609| <05.00.06> <Function> <> |.CheckConnection()|Boolean}|"' (Set|Get) Evaluate the connection to the DataBase
        '''    <Summary>
        '''     (Set|Get) Evaluate the connection to the DataBase
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:607 </Published>
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
#Region "[On] |2019/06/26 00h16:625| <15.00.00> <Runtime> <> |.Table()|Table"' (Set|Get) The Table.
        '''    <Summary>
        '''     (Set|Get) The Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:608 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Table.")>
        Public Table As Table
#End Region '(Set|Get) The Table.

#Region "[On] |2019/06/26 00h16:967| <15.00.01> <Runtime> <> |.Line()|String"' (Set|Get) The Connection String To the Table.
        '''    <Summary>
        '''     (Set|Get) The Connection String To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:608 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Connection String To the Table.")>
        Public Line As String
#End Region '(Set|Get) The Connection String To the Table.

#Region "[On] |2019/06/26 00h16:189| <15.00.02> <Runtime> <> |.FilePath()|String"' (Set|Get) The FilePath To the Table.
        '''    <Summary>
        '''     (Set|Get) The FilePath To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:608 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The FilePath To the Table.")>
        Public FilePath As String
#End Region '(Set|Get) The FilePath To the Table.

#Region "[On] |2019/06/26 00h16:426| <15.00.03> <Runtime> <> |.Password()|String"' (Set|Get) The Password To the Table.
        '''    <Summary>
        '''     (Set|Get) The Password To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:608 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Password To the Table.")>
        Public Password As String
#End Region '(Set|Get) The Password To the Table.

#Region "[On] |2019/06/26 00h16:647| <15.00.04> <Runtime> <> |.UseSQL()|Boolean"' (Set|Get) Determines if the Database Connection is of type SQL.
        '''    <Summary>
        '''     (Set|Get) Determines if the Database Connection is of type SQL.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:608 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Determines if the Database Connection is of type SQL.")>
        Public UseSQL As Boolean
#End Region '(Set|Get) Determines if the Database Connection is of type SQL.

#Region "[On] |2019/06/26 00h16:905| <15.00.05> <Runtime> <> |.TableName()|String"' (Set|Get) The name of the Table.
        '''    <Summary>
        '''     (Set|Get) The name of the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:609 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The name of the Table.")>
        Public TableName As String
#End Region '(Set|Get) The name of the Table.

#Region "[On] |2019/06/26 00h16:939| <15.00.06> <Runtime> <> |.Con()|OleDb.OleDbConnection"' (Set|Get) The Con To the Table.
        '''    <Summary>
        '''     (Set|Get) The Con To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:611 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Con To the Table.")>
        Public Con As OleDb.OleDbConnection
#End Region '(Set|Get) The Con To the Table.

#Region "[On] |2019/06/26 00h16:014| <15.00.07> <Runtime> <> |.Cmd()|OleDb.OleDbCommand"' (Set|Get) The Cmd To the Table.
        '''    <Summary>
        '''     (Set|Get) The Cmd To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:611 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Cmd To the Table.")>
        Public Cmd As OleDb.OleDbCommand
#End Region '(Set|Get) The Cmd To the Table.

#Region "[On] |2019/06/26 00h16:048| <15.00.08> <Runtime> <> |.DataReader()|OleDb.OleDbDataReader"' (Set|Get) The DataReader To the Table.
        '''    <Summary>
        '''     (Set|Get) The DataReader To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:611 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The DataReader To the Table.")>
        Public DataReader As OleDb.OleDbDataReader
#End Region '(Set|Get) The DataReader To the Table.

#Region "[On] |2019/06/26 00h16:082| <15.00.09> <Runtime> <> |.DataAdapter()|OleDb.OleDbDataAdapter"' (Set|Get) The DataAdapter To the Table.
        '''    <Summary>
        '''     (Set|Get) The DataAdapter To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:612 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The DataAdapter To the Table.")>
        Public DataAdapter As OleDb.OleDbDataAdapter
#End Region '(Set|Get) The DataAdapter To the Table.

#Region "[On] |2019/06/26 00h16:117| <15.00.10> <Runtime> <> |.Connector()|LineInfo"' (Set|Get) The Connector To the Table.
        '''    <Summary>
        '''     (Set|Get) The Connector To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:612 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Connector To the Table.")>
        Public Connector As LineInfo
#End Region '(Set|Get) The Connector To the Table.

#Region "[On] |2019/06/26 00h16:153| <15.00.11> <Runtime> <> |.Log()|String"' (Set|Get) The Log To the Table.
        '''    <Summary>
        '''     (Set|Get) The Log To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:612 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Log To the Table.")>
        Public Log As String
#End Region '(Set|Get) The Log To the Table.

#End Region
#Region "<7> [Loader]{2}"
#Region "[On] |2019/06/26 00h16:187| <06.00.00> <Loader> <> |.Empty()|Function}|"' (Set|Get) The sub Empty.
        '''    <Summary>
        '''     (Set|Get) The sub Empty.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:612 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The sub Empty.")>
        Public Sub New()
            Reset()
        End Sub
#End Region '(Set|Get) The sub Empty.

#Region "[On] |2019/06/26 00h16:199| <06.00.01> <Loader> <> |.Filled()|Function}|"' (Set|Get) The sub Filled.
        '''    <Summary>
        '''     (Set|Get) The sub Filled.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/26 00h16:613 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>    ''' <param name="Ref">(Set|Get) The Ref as String.</param>
        ''' <param name="Active">(Set|Get) The Active as Boolean.</param>
        ''' <param name="RaisonSociale">(Set|Get) The RaisonSociale as String.</param>
        ''' <param name="NomClient">(Set|Get) The NomClient as String.</param>
        ''' <param name="Address1">(Set|Get) The Address1 as String.</param>
        ''' <param name="Address2">(Set|Get) The Address2 as String.</param>
        ''' <param name="PostalCode">(Set|Get) The PostalCode as String.</param>
        ''' <param name="Region">(Set|Get) The Region as String.</param>
        ''' <param name="City">(Set|Get) The City as String.</param>
        ''' <param name="Country">(Set|Get) The Country as String.</param>
        ''' <param name="Landline">(Set|Get) The Landline as String.</param>
        ''' <param name="Fax">(Set|Get) The Fax as String.</param>
        ''' <param name="Cell">(Set|Get) The Cell as String.</param>
        ''' <param name="Email">(Set|Get) The Email as String.</param>
        ''' <param name="Website">(Set|Get) The Website as String.</param>
        ''' <param name="Pcompta">(Set|Get) The Pcompta as String.</param>
        ''' <param name="Other">(Set|Get) The Other as String.</param>
        ''' <param name="Répertoire">(Set|Get) The Répertoire as String.</param>
        ''' <param name="Forfait">(Set|Get) The Forfait as Boolean.</param>
        ''' <param name="ForfaitValue">(Set|Get) The ForfaitValue as Double.</param>
        ''' <param name="CHE">(Set|Get) The CHE as String.</param>
        ''' <param name="IDE">(Set|Get) The IDE as String.</param>
        ''' <param name="Zefix">(Set|Get) The Zefix as String.</param>

        <Browsable(True), Description("(Set|Get) The sub Filled.")>
        Public Sub New(ByVal Ref As String,
ByVal Active As Boolean,
ByVal RaisonSociale As String,
ByVal NomClient As String,
ByVal Address1 As String,
ByVal Address2 As String,
ByVal PostalCode As String,
ByVal Region As String,
ByVal City As String,
ByVal Country As String,
ByVal Landline As String,
ByVal Fax As String,
ByVal Cell As String,
ByVal Email As String,
ByVal Website As String,
ByVal Pcompta As String,
ByVal Other As String,
ByVal Répertoire As String,
ByVal Forfait As Boolean,
ByVal ForfaitValue As Double,
ByVal CHE As String,
ByVal IDE As String,
ByVal Zefix As String)
            With Me
                Clear()
                Reset()
                .Ref = Ref
                .Active = Active
                .RaisonSociale = RaisonSociale
                .NomClient = NomClient
                .Address1 = Address1
                .Address2 = Address2
                .PostalCode = PostalCode
                .Region = Region
                .City = City
                .Country = Country
                .Landline = Landline
                .Fax = Fax
                .Cell = Cell
                .Email = Email
                .Website = Website
                .Pcompta = Pcompta
                .Other = Other
                .Répertoire = Répertoire
                .Forfait = Forfait
                .ForfaitValue = ForfaitValue
                .CHE = CHE
                .IDE = IDE
                .Zefix = Zefix
            End With

        End Sub
#End Region '(Set|Get) The sub Filled.

#End Region
    End Class
#End Region
#Region "[On] |2019/06/25 22h51:802| <08.00.00> <Class> <> |.Collaborateur|Class|{33} |Production Cost : 37.3|Selling Price : 55.95|"' Class created automatically by SmartOffice (c)Copyright 2019.
    '''    <Summary>
    '''     Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Collaborateur
    '''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
    '''    Contributor Information : ||
    '''    Creation Date :           2019/06/25 22h51:802
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
    '''    |Selling Price without VAT   |55.95
    '''    |Total TVA                   |4.31
    '''    |Grand Total                 |60.26
    '''    |/Schema|
    '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
    '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
    '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
    '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:281 </Published>
    '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
    '''    </Summary>
    Public Class Collaborateur
#Region "<1> [Property]{6}"
#Region "[On] |2019/06/25 22h51:803| <01.00.00> <Property> <Columns> |.Ref()|String|"' (Set|Get) The Ref as String.
        Private _Ref As String
        '''    <Summary>
        '''     (Set|Get) The Ref as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:282 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Ref as String.")>
        Public Property Ref() As String
            Get
                Return _Ref
            End Get
            Set(ByVal Value As String)
                _Ref = Value
            End Set
        End Property
#End Region '(Set|Get) The Ref as String.

#Region "[On] |2019/06/25 22h51:816| <01.00.01> <Property> <Columns> |.FirstName()|String|"' (Set|Get) The FirstName as String.
        Private _FirstName As String
        '''    <Summary>
        '''     (Set|Get) The FirstName as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:282 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The FirstName as String.")>
        Public Property FirstName() As String
            Get
                Return _FirstName
            End Get
            Set(ByVal Value As String)
                _FirstName = Value
            End Set
        End Property
#End Region '(Set|Get) The FirstName as String.

#Region "[On] |2019/06/25 22h51:828| <01.00.02> <Property> <Columns> |.LastName()|String|"' (Set|Get) The LastName as String.
        Private _LastName As String
        '''    <Summary>
        '''     (Set|Get) The LastName as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:283 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The LastName as String.")>
        Public Property LastName() As String
            Get
                Return _LastName
            End Get
            Set(ByVal Value As String)
                _LastName = Value
            End Set
        End Property
#End Region '(Set|Get) The LastName as String.

#Region "[On] |2019/06/25 22h51:840| <01.00.03> <Property> <Columns> |.Active()|Boolean|"' (Set|Get) The Active as Boolean.
        Private _Active As Boolean
        '''    <Summary>
        '''     (Set|Get) The Active as Boolean.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:284 </Published>
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

#Region "[On] |2019/06/25 22h51:853| <01.00.04> <Property> <Columns> |.Tarif_Min()|Double|"' (Set|Get) The Tarif_Min as Double.
        Private _Tarif_Min As Double
        '''    <Summary>
        '''     (Set|Get) The Tarif_Min as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:284 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Tarif_Min as Double.")>
        Public Property Tarif_Min() As Double
            Get
                Return _Tarif_Min
            End Get
            Set(ByVal Value As Double)
                _Tarif_Min = Value
            End Set
        End Property
#End Region '(Set|Get) The Tarif_Min as Double.

#Region "[On] |2019/06/25 22h51:865| <01.00.05> <Property> <Columns> |.Tarif_Max()|Double|"' (Set|Get) The Tarif_Max as Double.
        Private _Tarif_Max As Double
        '''    <Summary>
        '''     (Set|Get) The Tarif_Max as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:284 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Tarif_Max as Double.")>
        Public Property Tarif_Max() As Double
            Get
                Return _Tarif_Max
            End Get
            Set(ByVal Value As Double)
                _Tarif_Max = Value
            End Set
        End Property
#End Region '(Set|Get) The Tarif_Max as Double.

#End Region
#Region "<2> [Enumeration]{1}"
#Region "[On] |2019/06/25 22h51:878| <02.00.00> <Enumeration> <> |.Schema()|Enumeration{5}|"' (Set|Get) The enumeration of Schema.
        '''    <Summary>
        '''     (Set|Get) The enumeration of Schema.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:284 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The enumeration of Schema.")>
        Enum Schema
            ''' <summary>(Set|Get) The Ref as String.</summary>
            [Ref] = 0
            ''' <summary>(Set|Get) The FirstName as String.</summary>
            [FirstName] = 1
            ''' <summary>(Set|Get) The LastName as String.</summary>
            [LastName] = 2
            ''' <summary>(Set|Get) The Active as Boolean.</summary>
            [Active] = 3
            ''' <summary>(Set|Get) The Tarif_Min as Double.</summary>
            [Tarif_Min] = 4
            ''' <summary>(Set|Get) The Tarif_Max as Double.</summary>
            [Tarif_Max] = 5
        End Enum
#End Region '(Set|Get) The enumeration of Schema.

#End Region
#Region "<4> [Sub]{5}"
#Region "[On] |2019/06/25 22h51:892| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
        '''    <Summary>
        '''     (Set|Get) This will reinitialize the class element.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:285 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will reinitialize the class element.")>
        Public Sub Clear()
            With Me
                .Ref = Nothing
                .FirstName = Nothing
                .LastName = Nothing
                .Active = False
                .Tarif_Min = 0
                .Tarif_Max = 0
            End With
        End Sub
#End Region '(Set|Get) This will reinitialize the class element.

#Region "[On] |2019/06/25 22h51:905| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
        '''    <Summary>
        '''     (Set|Get) This will reinitialize the variables of this class.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:285 </Published>
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
                    TableName = "Collaborateur"
                    Line = Connector.Line
                    UseSQL = False
                Else
                    FilePath = My.Settings.Db_TimeSheet_FilePath
                    Password = My.Settings.Db_TimeSheet_Password
                    Me.Line = My.Settings.Db_TimeSheet_Line
                    TableName = "Collaborateur"
                    UseSQL = False
                End If
            Else
                If IsNothing(FilePath) Then
                    FilePath = My.Settings.Db_TimeSheet_FilePath
                End If
                If FilePath.Length < 1 Then
                    FilePath = My.Settings.Db_TimeSheet_FilePath
                End If
                FilePath = My.Settings.Db_TimeSheet_FilePath
                Password = My.Settings.Db_TimeSheet_Password
                Me.Line = My.Settings.Db_TimeSheet_Line
                TableName = "Collaborateur"
                UseSQL = False
            End If

        End Sub
#End Region '(Set|Get) This will reinitialize the variables of this class.

#Region "[On] |2019/06/25 23h39:639| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
        '''    <Summary>
        '''     (Set|Get) This will add a new row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 23h39:032 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will add a new row in the table.")>
        Public Sub Add()
            Try
                Dim Str As String = Nothing
                Str = "Insert Into [Collaborateur] (
`Ref`, 
`FirstName`, 
`LastName`, 
`Active`, 
`Tarif_Min`, 
`Tarif_Max`) Values (@0, @1, @2, @3, @4, @5)"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@0", Me.Ref)
                Cmd.Parameters.AddWithValue("@1", Me.FirstName)
                Cmd.Parameters.AddWithValue("@2", Me.LastName)
                Cmd.Parameters.AddWithValue("@3", Me.Active)
                Cmd.Parameters.AddWithValue("@4", Me.Tarif_Min)
                Cmd.Parameters.AddWithValue("@5", Me.Tarif_Max)
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

#Region "[On] |2019/06/25 22h51:935| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
        '''    <Summary>
        '''     (Set|Get) This will update a row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:285 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will update a row in the table.")>
        Public Sub Save()
            Try
                Dim Str As String = Nothing
                Str = "UPDATE [Collaborateur] SET FirstName = @FirstName, LastName = @LastName, Active = @Active, Tarif_Min = @Tarif_Min, Tarif_Max = @Tarif_Max WHERE Ref = @Ref"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@FirstName", FirstName)
                Cmd.Parameters.AddWithValue("@LastName", LastName)
                Cmd.Parameters.AddWithValue("@Active", Active)
                Cmd.Parameters.AddWithValue("@Tarif_Min", Tarif_Min)
                Cmd.Parameters.AddWithValue("@Tarif_Max", Tarif_Max)
                Cmd.Parameters.AddWithValue("@Ref", Ref)
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

#Region "[On] |2019/06/25 22h51:949| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
        '''    <Summary>
        '''     (Set|Get) This will Delete a row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:285 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will Delete a row in the table.")>
        Public Sub Delete()
            Try
                Dim Str As String = Nothing
                Str = "Delete From [Collaborateur] WHERE Ref =@Ref"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@Ref", Ref)
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
#Region "[On] |2019/06/25 22h51:967| <05.00.00> <Function> <> |.Open()|TestItem}|"' (Set|Get) This will initialise the connection and import the data.
        '''    <Summary>
        '''     (Set|Get) This will initialise the connection and import the data.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:285 </Published>
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

#Region "[On] |2019/06/25 22h51:982| <05.00.01> <Function> <> |.Close()|TestItem}|"' (Set|Get) This willClosing the connection
        '''    <Summary>
        '''     (Set|Get) This willClosing the connection
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:285 </Published>
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

#Region "[On] |2019/06/25 22h51:996| <05.00.02> <Function> <> |.List()|List(Of Collaborateur)}|"' (Set|Get) Return the entire table listed
        '''    <Summary>
        '''     (Set|Get) Return the entire table listed
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:286 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Return the entire table listed")>
        Public Function List() As List(Of Collaborateur)
            Dim Result As New List(Of Collaborateur)
            Me.Table = New Table(Me.TableName, Me.FilePath, Me.Password, False)
            For Each Row As DataRow In Me.Table.DataTable.Rows
                Dim Element As New Collaborateur(IIf(IsDBNull(Row.Item(0)), "", Row.Item(0)),
IIf(IsDBNull(Row.Item(1)), "", Row.Item(1)),
IIf(IsDBNull(Row.Item(2)), "", Row.Item(2)),
IIf(IsDBNull(Row.Item(3)), False, Row.Item(3)),
IIf(IsDBNull(Row.Item(4)), 0, Row.Item(4)),
  IIf(IsDBNull(Row.Item(5)), 0, Row.Item(5)))
                Element.Reset(Table.Line)
                Result.Add(Element)
            Next
            Return Result
        End Function
#End Region '(Set|Get) Return the entire table listed

#Region "[On] |2019/06/25 22h51:012| <05.00.03> <Function> <> |.SearchByName()|List(Of Collaborateur)}|"' (Set|Get) Search for each property that match the Search String.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search String.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:286 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Search for each property that match the Search String.")>
        Public Shared Function SearchByName(ByVal Search As String) As List(Of Collaborateur)
            Dim Result As New List(Of Collaborateur)
            Dim C As New Collaborateur
            For Each Element As Collaborateur In C.List
                If Element.Ref.ToLower() = Search.ToLower() Or Element.FirstName.ToLower() = Search.ToLower() Or Element.LastName.ToLower() = Search.ToLower() Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search String.

#Region "[On] |2019/06/25 22h51:025| <05.00.04> <Function> <> |.SearchByID()|List(Of Collaborateur)}|"' (Set|Get) Search for each property that match the Search Id.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search Id.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:286 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Search for each property that match the Search Id.")>
        Public Shared Function SearchByID(ByVal Search As Double) As List(Of Collaborateur)
            Dim Result As New List(Of Collaborateur)
            Dim C As New Collaborateur
            For Each Element As Collaborateur In C.List
                If Val(Element.Tarif_Min) = Search Or Val(Element.Tarif_Max) = Search Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search Id.

#Region "[On] |2019/06/25 22h51:039| <05.00.05> <Function> <> |.ToString()|String}|"' (Set|Get) The function ToString.
        '''    <Summary>
        '''     (Set|Get) The function ToString.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:286 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The function ToString.")>
        Public Overrides Function ToString() As String
            Return Me.Ref
        End Function
#End Region '(Set|Get) The function ToString.

#Region "[On] |2019/06/25 22h51:056| <05.00.06> <Function> <> |.CheckConnection()|Boolean}|"' (Set|Get) Evaluate the connection to the DataBase
        '''    <Summary>
        '''     (Set|Get) Evaluate the connection to the DataBase
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:286 </Published>
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
#Region "[On] |2019/06/25 22h51:072| <15.00.00> <Runtime> <> |.Table()|Table"' (Set|Get) The Table.
        '''    <Summary>
        '''     (Set|Get) The Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:287 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Table.")>
        Public Table As Table
#End Region '(Set|Get) The Table.

#Region "[On] |2019/06/25 22h51:104| <15.00.01> <Runtime> <> |.Line()|String"' (Set|Get) The Connection String To the Table.
        '''    <Summary>
        '''     (Set|Get) The Connection String To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:287 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Connection String To the Table.")>
        Public Line As String
#End Region '(Set|Get) The Connection String To the Table.

#Region "[On] |2019/06/25 22h51:139| <15.00.02> <Runtime> <> |.FilePath()|String"' (Set|Get) The FilePath To the Table.
        '''    <Summary>
        '''     (Set|Get) The FilePath To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:287 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The FilePath To the Table.")>
        Public FilePath As String
#End Region '(Set|Get) The FilePath To the Table.

#Region "[On] |2019/06/25 22h51:168| <15.00.03> <Runtime> <> |.Password()|String"' (Set|Get) The Password To the Table.
        '''    <Summary>
        '''     (Set|Get) The Password To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:287 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Password To the Table.")>
        Public Password As String
#End Region '(Set|Get) The Password To the Table.

#Region "[On] |2019/06/25 22h51:225| <15.00.04> <Runtime> <> |.UseSQL()|Boolean"' (Set|Get) Determines if the Database Connection is of type SQL.
        '''    <Summary>
        '''     (Set|Get) Determines if the Database Connection is of type SQL.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:287 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Determines if the Database Connection is of type SQL.")>
        Public UseSQL As Boolean
#End Region '(Set|Get) Determines if the Database Connection is of type SQL.

#Region "[On] |2019/06/25 22h51:256| <15.00.05> <Runtime> <> |.TableName()|String"' (Set|Get) The name of the Table.
        '''    <Summary>
        '''     (Set|Get) The name of the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:287 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The name of the Table.")>
        Public TableName As String
#End Region '(Set|Get) The name of the Table.

#Region "[On] |2019/06/25 22h51:287| <15.00.06> <Runtime> <> |.Con()|OleDb.OleDbConnection"' (Set|Get) The Con To the Table.
        '''    <Summary>
        '''     (Set|Get) The Con To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:288 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Con To the Table.")>
        Public Con As OleDb.OleDbConnection
#End Region '(Set|Get) The Con To the Table.

#Region "[On] |2019/06/25 22h51:334| <15.00.07> <Runtime> <> |.Cmd()|OleDb.OleDbCommand"' (Set|Get) The Cmd To the Table.
        '''    <Summary>
        '''     (Set|Get) The Cmd To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:288 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Cmd To the Table.")>
        Public Cmd As OleDb.OleDbCommand
#End Region '(Set|Get) The Cmd To the Table.

#Region "[On] |2019/06/25 22h51:366| <15.00.08> <Runtime> <> |.DataReader()|OleDb.OleDbDataReader"' (Set|Get) The DataReader To the Table.
        '''    <Summary>
        '''     (Set|Get) The DataReader To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:288 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The DataReader To the Table.")>
        Public DataReader As OleDb.OleDbDataReader
#End Region '(Set|Get) The DataReader To the Table.

#Region "[On] |2019/06/25 22h51:397| <15.00.09> <Runtime> <> |.DataAdapter()|OleDb.OleDbDataAdapter"' (Set|Get) The DataAdapter To the Table.
        '''    <Summary>
        '''     (Set|Get) The DataAdapter To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:288 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The DataAdapter To the Table.")>
        Public DataAdapter As OleDb.OleDbDataAdapter
#End Region '(Set|Get) The DataAdapter To the Table.

#Region "[On] |2019/06/25 22h51:429| <15.00.10> <Runtime> <> |.Connector()|LineInfo"' (Set|Get) The Connector To the Table.
        '''    <Summary>
        '''     (Set|Get) The Connector To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:288 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Connector To the Table.")>
        Public Connector As LineInfo
#End Region '(Set|Get) The Connector To the Table.

#Region "[On] |2019/06/25 22h51:460| <15.00.11> <Runtime> <> |.Log()|String"' (Set|Get) The Log To the Table.
        '''    <Summary>
        '''     (Set|Get) The Log To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:290 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Log To the Table.")>
        Public Log As String
#End Region '(Set|Get) The Log To the Table.

#End Region
#Region "<7> [Loader]{2}"
#Region "[On] |2019/06/25 22h51:493| <06.00.00> <Loader> <> |.Empty()|Function}|"' (Set|Get) The sub Empty.
        '''    <Summary>
        '''     (Set|Get) The sub Empty.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:290 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The sub Empty.")>
        Public Sub New()
            Reset
        End Sub
#End Region '(Set|Get) The sub Empty.

#Region "[On] |2019/06/25 22h51:496| <06.00.01> <Loader> <> |.Filled()|Function}|"' (Set|Get) The sub Filled.
        '''    <Summary>
        '''     (Set|Get) The sub Filled.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:291 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>    ''' <param name="Ref">(Set|Get) The Ref as String.</param>
        ''' <param name="FirstName">(Set|Get) The FirstName as String.</param>
        ''' <param name="LastName">(Set|Get) The LastName as String.</param>
        ''' <param name="Active">(Set|Get) The Active as Boolean.</param>
        ''' <param name="Tarif_Min">(Set|Get) The Tarif_Min as Double.</param>
        ''' <param name="Tarif_Max">(Set|Get) The Tarif_Max as Double.</param>

        <Browsable(True), Description("(Set|Get) The sub Filled.")>
        Public Sub New(ByVal Ref As String,
ByVal FirstName As String,
ByVal LastName As String,
ByVal Active As Boolean,
ByVal Tarif_Min As Double,
ByVal Tarif_Max As Double)
            With Me
                Clear()
                Reset()
                .Ref = Ref
                .FirstName = FirstName
                .LastName = LastName
                .Active = Active
                .Tarif_Min = Tarif_Min
                .Tarif_Max = Tarif_Max
            End With

        End Sub
#End Region '(Set|Get) The sub Filled.

#End Region
    End Class
#End Region
#Region "[On] |2019/06/25 22h51:622| <08.00.00> <Class> <> |.Factures|Class|{46} |Production Cost : 61.8|Selling Price : 92.7|"' Class created automatically by SmartOffice (c)Copyright 2019.
    '''    <Summary>
    '''     Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Factures
    '''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
    '''    Contributor Information : ||
    '''    Creation Date :           2019/06/25 22h51:622
    '''    |Schema|
    '''    |ID| |ObjectType |{Quantity}||UnitPrice||Total
    '''    |00| |Importation|{0}||1| |0
    '''    |01| |Properties |{17}||0.8| |13.6
    '''    |02| |Enumeration|{1}||0.4| |0.4
    '''    |03| |Structure  |{0}||0.4| |0
    '''    |04| |Sub        |{5}||1.2| |6
    '''    |05| |Function   |{9}||1.6| |14.4
    '''    |06| |Runtime    |{12}||0.4| |4.8
    '''    |07| |Loader     |{2}||0.8| |1.6
    '''    |08| |Class      |{0}||2| |0
    '''    |09| |Constante  |{0}||0.4| |0
    '''    |10| |Event      |{0}||1.2| |0
    '''    |11| |Members    |{17}||0.5| |8.5
    '''    |12| |Parameter  |{25}||0.5| |12.5
    '''    |Production Cost             |61.8
    '''    |Selling Price without VAT   |92.7
    '''    |Total TVA                   |7.14
    '''    |Grand Total                 |99.84
    '''    |/Schema|
    '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
    '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
    '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
    '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:295 </Published>
    '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
    '''    </Summary>
    Public Class Factures
#Region "<1> [Property]{17}"
#Region "[On] |2019/06/25 22h51:623| <01.00.00> <Property> <Columns> |.Code()|String|"' (Set|Get) The Code as String.
        Private _Code As String
        '''    <Summary>
        '''     (Set|Get) The Code as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:295 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Code as String.")>
        Public Property Code() As String
            Get
                Return _Code
            End Get
            Set(ByVal Value As String)
                _Code = Value
            End Set
        End Property
#End Region '(Set|Get) The Code as String.

#Region "[On] |2019/06/25 22h51:636| <01.00.01> <Property> <Columns> |.Emise_Par()|String|"' (Set|Get) The Emise_Par as String.
        Private _Emise_Par As String
        '''    <Summary>
        '''     (Set|Get) The Emise_Par as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:295 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Emise_Par as String.")>
        Public Property Emise_Par() As String
            Get
                Return _Emise_Par
            End Get
            Set(ByVal Value As String)
                _Emise_Par = Value
            End Set
        End Property
#End Region '(Set|Get) The Emise_Par as String.

#Region "[On] |2019/06/25 22h51:648| <01.00.02> <Property> <Columns> |.Année()|Integer|"' (Set|Get) The Année as Integer.
        Private _Année As Integer
        '''    <Summary>
        '''     (Set|Get) The Année as Integer.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:297 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Année as Integer.")>
        Public Property Année() As Integer
            Get
                Return _Année
            End Get
            Set(ByVal Value As Integer)
                _Année = Value
            End Set
        End Property
#End Region '(Set|Get) The Année as Integer.

#Region "[On] |2019/06/25 22h51:659| <01.00.03> <Property> <Columns> |.Mois()|Integer|"' (Set|Get) The Mois as Integer.
        Private _Mois As Integer
        '''    <Summary>
        '''     (Set|Get) The Mois as Integer.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:297 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Mois as Integer.")>
        Public Property Mois() As Integer
            Get
                Return _Mois
            End Get
            Set(ByVal Value As Integer)
                _Mois = Value
            End Set
        End Property
#End Region '(Set|Get) The Mois as Integer.

#Region "[On] |2019/06/25 22h51:670| <01.00.04> <Property> <Columns> |.N()|Integer|"' (Set|Get) The N as Integer.
        Private _N As Integer
        '''    <Summary>
        '''     (Set|Get) The N as Integer.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:297 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The N as Integer.")>
        Public Property N() As Integer
            Get
                Return _N
            End Get
            Set(ByVal Value As Integer)
                _N = Value
            End Set
        End Property
#End Region '(Set|Get) The N as Integer.

#Region "[On] |2019/06/25 22h51:683| <01.00.05> <Property> <Columns> |.Client()|String|"' (Set|Get) The Client as String.
        Private _Client As String
        '''    <Summary>
        '''     (Set|Get) The Client as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:298 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Client as String.")>
        Public Property Client() As String
            Get
                Return _Client
            End Get
            Set(ByVal Value As String)
                _Client = Value
            End Set
        End Property
#End Region '(Set|Get) The Client as String.

#Region "[On] |2019/06/25 22h51:694| <01.00.06> <Property> <Columns> |.Adresse()|String|"' (Set|Get) The Adresse as String.
        Private _Adresse As String
        '''    <Summary>
        '''     (Set|Get) The Adresse as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:298 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Adresse as String.")>
        Public Property Adresse() As String
            Get
                Return _Adresse
            End Get
            Set(ByVal Value As String)
                _Adresse = Value
            End Set
        End Property
#End Region '(Set|Get) The Adresse as String.

#Region "[On] |2019/06/25 22h51:705| <01.00.07> <Property> <Columns> |.DateEnvoi()|DateTime|"' (Set|Get) The DateEnvoi as DateTime.
        Private _DateEnvoi As DateTime
        '''    <Summary>
        '''     (Set|Get) The DateEnvoi as DateTime.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:298 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The DateEnvoi as DateTime.")>
        Public Property DateEnvoi() As DateTime
            Get
                Return _DateEnvoi
            End Get
            Set(ByVal Value As DateTime)
                _DateEnvoi = Value
            End Set
        End Property
#End Region '(Set|Get) The DateEnvoi as DateTime.

#Region "[On] |2019/06/25 22h51:717| <01.00.08> <Property> <Columns> |.PériodeIN()|DateTime|"' (Set|Get) The PériodeIN as DateTime.
        Private _PériodeIN As DateTime
        '''    <Summary>
        '''     (Set|Get) The PériodeIN as DateTime.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:298 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The PériodeIN as DateTime.")>
        Public Property PériodeIN() As DateTime
            Get
                Return _PériodeIN
            End Get
            Set(ByVal Value As DateTime)
                _PériodeIN = Value
            End Set
        End Property
#End Region '(Set|Get) The PériodeIN as DateTime.

#Region "[On] |2019/06/25 22h51:729| <01.00.09> <Property> <Columns> |.PériodeFIN()|DateTime|"' (Set|Get) The PériodeFIN as DateTime.
        Private _PériodeFIN As DateTime
        '''    <Summary>
        '''     (Set|Get) The PériodeFIN as DateTime.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:299 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The PériodeFIN as DateTime.")>
        Public Property PériodeFIN() As DateTime
            Get
                Return _PériodeFIN
            End Get
            Set(ByVal Value As DateTime)
                _PériodeFIN = Value
            End Set
        End Property
#End Region '(Set|Get) The PériodeFIN as DateTime.

#Region "[On] |2019/06/25 22h51:740| <01.00.10> <Property> <Columns> |.Concerne()|String|"' (Set|Get) The Concerne as String.
        Private _Concerne As String
        '''    <Summary>
        '''     (Set|Get) The Concerne as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:299 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Concerne as String.")>
        Public Property Concerne() As String
            Get
                Return _Concerne
            End Get
            Set(ByVal Value As String)
                _Concerne = Value
            End Set
        End Property
#End Region '(Set|Get) The Concerne as String.

#Region "[On] |2019/06/25 22h51:753| <01.00.11> <Property> <Columns> |.Quantité()|Double|"' (Set|Get) The Quantité as Double.
        Private _Quantité As Double
        '''    <Summary>
        '''     (Set|Get) The Quantité as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:299 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Quantité as Double.")>
        Public Property Quantité() As Double
            Get
                Return _Quantité
            End Get
            Set(ByVal Value As Double)
                _Quantité = Value
            End Set
        End Property
#End Region '(Set|Get) The Quantité as Double.

#Region "[On] |2019/06/25 22h51:768| <01.00.12> <Property> <Columns> |.TotalHTVA()|Double|"' (Set|Get) The TotalHTVA as Double.
        Private _TotalHTVA As Double
        '''    <Summary>
        '''     (Set|Get) The TotalHTVA as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:299 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The TotalHTVA as Double.")>
        Public Property TotalHTVA() As Double
            Get
                Return _TotalHTVA
            End Get
            Set(ByVal Value As Double)
                _TotalHTVA = Value
            End Set
        End Property
#End Region '(Set|Get) The TotalHTVA as Double.

#Region "[On] |2019/06/25 22h51:782| <01.00.13> <Property> <Columns> |.TotalFrais()|Double|"' (Set|Get) The TotalFrais as Double.
        Private _TotalFrais As Double
        '''    <Summary>
        '''     (Set|Get) The TotalFrais as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:299 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The TotalFrais as Double.")>
        Public Property TotalFrais() As Double
            Get
                Return _TotalFrais
            End Get
            Set(ByVal Value As Double)
                _TotalFrais = Value
            End Set
        End Property
#End Region '(Set|Get) The TotalFrais as Double.

#Region "[On] |2019/06/25 22h51:796| <01.00.14> <Property> <Columns> |.TotalTVA()|Double|"' (Set|Get) The TotalTVA as Double.
        Private _TotalTVA As Double
        '''    <Summary>
        '''     (Set|Get) The TotalTVA as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:300 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The TotalTVA as Double.")>
        Public Property TotalTVA() As Double
            Get
                Return _TotalTVA
            End Get
            Set(ByVal Value As Double)
                _TotalTVA = Value
            End Set
        End Property
#End Region '(Set|Get) The TotalTVA as Double.

#Region "[On] |2019/06/25 22h51:813| <01.00.15> <Property> <Columns> |.Total()|Double|"' (Set|Get) The Total as Double.
        Private _Total As Double
        '''    <Summary>
        '''     (Set|Get) The Total as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:300 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Total as Double.")>
        Public Property Total() As Double
            Get
                Return _Total
            End Get
            Set(ByVal Value As Double)
                _Total = Value
            End Set
        End Property
#End Region '(Set|Get) The Total as Double.

#Region "[On] |2019/06/25 22h51:824| <01.00.16> <Property> <Columns> |.Libellé()|String|"' (Set|Get) The Libellé as String.
        Private _Libellé As String
        '''    <Summary>
        '''     (Set|Get) The Libellé as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:300 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Libellé as String.")>
        Public Property Libellé() As String
            Get
                Return _Libellé
            End Get
            Set(ByVal Value As String)
                _Libellé = Value
            End Set
        End Property
#End Region '(Set|Get) The Libellé as String.

#End Region
#Region "<2> [Enumeration]{1}"
#Region "[On] |2019/06/25 22h51:837| <02.00.00> <Enumeration> <> |.Schema()|Enumeration{16}|"' (Set|Get) The enumeration of Schema.
        '''    <Summary>
        '''     (Set|Get) The enumeration of Schema.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:300 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The enumeration of Schema.")>
        Enum Schema
            ''' <summary>(Set|Get) The Code as String.</summary>
            [Code] = 0
            ''' <summary>(Set|Get) The Emise_Par as String.</summary>
            [Emise_Par] = 1
            ''' <summary>(Set|Get) The Année as Integer.</summary>
            [Année] = 2
            ''' <summary>(Set|Get) The Mois as Integer.</summary>
            [Mois] = 3
            ''' <summary>(Set|Get) The N as Integer.</summary>
            [N] = 4
            ''' <summary>(Set|Get) The Client as String.</summary>
            [Client] = 5
            ''' <summary>(Set|Get) The Adresse as String.</summary>
            [Adresse] = 6
            ''' <summary>(Set|Get) The DateEnvoi as DateTime.</summary>
            [DateEnvoi] = 7
            ''' <summary>(Set|Get) The PériodeIN as DateTime.</summary>
            [PériodeIN] = 8
            ''' <summary>(Set|Get) The PériodeFIN as DateTime.</summary>
            [PériodeFIN] = 9
            ''' <summary>(Set|Get) The Concerne as String.</summary>
            [Concerne] = 10
            ''' <summary>(Set|Get) The Quantité as Double.</summary>
            [Quantité] = 11
            ''' <summary>(Set|Get) The TotalHTVA as Double.</summary>
            [TotalHTVA] = 12
            ''' <summary>(Set|Get) The TotalFrais as Double.</summary>
            [TotalFrais] = 13
            ''' <summary>(Set|Get) The TotalTVA as Double.</summary>
            [TotalTVA] = 14
            ''' <summary>(Set|Get) The Total as Double.</summary>
            [Total] = 15
            ''' <summary>(Set|Get) The Libellé as String.</summary>
            [Libellé] = 16
        End Enum
#End Region '(Set|Get) The enumeration of Schema.

#End Region
#Region "<4> [Sub]{5}"
#Region "[On] |2019/06/25 22h51:850| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
        '''    <Summary>
        '''     (Set|Get) This will reinitialize the class element.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:300 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will reinitialize the class element.")>
        Public Sub Clear()
            With Me
                .Code = Nothing
                .Emise_Par = Nothing
                .Année = 0
                .Mois = 0
                .N = 0
                .Client = Nothing
                .Adresse = Nothing
                .DateEnvoi = New DateTime
                .PériodeIN = New DateTime
                .PériodeFIN = New DateTime
                .Concerne = Nothing
                .Quantité = 0
                .TotalHTVA = 0
                .TotalFrais = 0
                .TotalTVA = 0
                .Total = 0
                .Libellé = Nothing
            End With
        End Sub
#End Region '(Set|Get) This will reinitialize the class element.

#Region "[On] |2019/06/25 22h51:863| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
        '''    <Summary>
        '''     (Set|Get) This will reinitialize the variables of this class.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:301 </Published>
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
                    TableName = "Factures"
                    Line = Connector.Line
                    UseSQL = False
                Else
                    FilePath = My.Settings.Db_TimeSheet_FilePath
                    Password = My.Settings.Db_TimeSheet_Password
                    Me.Line = My.Settings.Db_TimeSheet_Line
                    TableName = "Factures"
                    UseSQL = False
                End If
            Else
                If IsNothing(FilePath) Then
                    FilePath = My.Settings.Db_TimeSheet_FilePath
                End If
                If FilePath.Length < 1 Then
                    FilePath = My.Settings.Db_TimeSheet_FilePath
                End If
                FilePath = My.Settings.Db_TimeSheet_FilePath
                Password = My.Settings.Db_TimeSheet_Password
                Me.Line = My.Settings.Db_TimeSheet_Line
                TableName = "Factures"
                UseSQL = False
            End If

        End Sub
#End Region '(Set|Get) This will reinitialize the variables of this class.

#Region "[On] |2019/06/25 23h39:584| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
        '''    <Summary>
        '''     (Set|Get) This will add a new row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 23h39:050 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will add a new row in the table.")>
        Public Sub Add()
            Try
                Dim Str As String = Nothing
                Str = "Insert Into [Factures] (
`Code`, 
`Emise_Par`, 
`Année`, 
`Mois`, 
`N`, 
`Client`, 
`Adresse`, 
`DateEnvoi`, 
`PériodeIN`, 
`PériodeFIN`, 
`Concerne`, 
`Quantité`, 
`TotalHTVA`, 
`TotalFrais`, 
`TotalTVA`, 
`Total`, 
`Libellé`) Values (@0, @1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16)"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@0", Me.Code)
                Cmd.Parameters.AddWithValue("@1", Me.Emise_Par)
                Cmd.Parameters.AddWithValue("@2", Me.Année)
                Cmd.Parameters.AddWithValue("@3", Me.Mois)
                Cmd.Parameters.AddWithValue("@4", Me.N)
                Cmd.Parameters.AddWithValue("@5", Me.Client)
                Cmd.Parameters.AddWithValue("@6", Me.Adresse)
                Cmd.Parameters.AddWithValue("@7", Me.DateEnvoi)
                Cmd.Parameters.AddWithValue("@8", Me.PériodeIN)
                Cmd.Parameters.AddWithValue("@9", Me.PériodeFIN)
                Cmd.Parameters.AddWithValue("@10", Me.Concerne)
                Cmd.Parameters.AddWithValue("@11", Me.Quantité)
                Cmd.Parameters.AddWithValue("@12", Me.TotalHTVA)
                Cmd.Parameters.AddWithValue("@13", Me.TotalFrais)
                Cmd.Parameters.AddWithValue("@14", Me.TotalTVA)
                Cmd.Parameters.AddWithValue("@15", Me.Total)
                Cmd.Parameters.AddWithValue("@16", Me.Libellé)
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

#Region "[On] |2019/06/25 22h51:897| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
        '''    <Summary>
        '''     (Set|Get) This will update a row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:301 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will update a row in the table.")>
        Public Sub Save()
            Try
                Dim Str As String = Nothing
                Str = "UPDATE [Factures] SET Emise_Par = @Emise_Par, Année = @Année, Mois = @Mois, N = @N, Client = @Client, Adresse = @Adresse, DateEnvoi = @DateEnvoi, PériodeIN = @PériodeIN, PériodeFIN = @PériodeFIN, Concerne = @Concerne, Quantité = @Quantité, TotalHTVA = @TotalHTVA, TotalFrais = @TotalFrais, TotalTVA = @TotalTVA, Total = @Total, Libellé = @Libellé WHERE Code = @Code"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@Emise_Par", Emise_Par)
                Cmd.Parameters.AddWithValue("@Année", Année)
                Cmd.Parameters.AddWithValue("@Mois", Mois)
                Cmd.Parameters.AddWithValue("@N", N)
                Cmd.Parameters.AddWithValue("@Client", Client)
                Cmd.Parameters.AddWithValue("@Adresse", Adresse)
                Cmd.Parameters.AddWithValue("@DateEnvoi", DateEnvoi)
                Cmd.Parameters.AddWithValue("@PériodeIN", PériodeIN)
                Cmd.Parameters.AddWithValue("@PériodeFIN", PériodeFIN)
                Cmd.Parameters.AddWithValue("@Concerne", Concerne)
                Cmd.Parameters.AddWithValue("@Quantité", Quantité)
                Cmd.Parameters.AddWithValue("@TotalHTVA", TotalHTVA)
                Cmd.Parameters.AddWithValue("@TotalFrais", TotalFrais)
                Cmd.Parameters.AddWithValue("@TotalTVA", TotalTVA)
                Cmd.Parameters.AddWithValue("@Total", Total)
                Cmd.Parameters.AddWithValue("@Libellé", Libellé)
                Cmd.Parameters.AddWithValue("@Code", Code)
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

#Region "[On] |2019/06/25 22h51:914| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
        '''    <Summary>
        '''     (Set|Get) This will Delete a row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:301 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will Delete a row in the table.")>
        Public Sub Delete()
            Try
                Dim Str As String = Nothing
                Str = "Delete From [Factures] WHERE Code =@Code"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@Code", Code)
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
#Region "<5> [Function]{9}"
#Region "[On] |2019/06/25 22h51:929| <05.00.00> <Function> <> |.Open()|TestItem}|"' (Set|Get) This will initialise the connection and import the data.
        '''    <Summary>
        '''     (Set|Get) This will initialise the connection and import the data.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:301 </Published>
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

#Region "[On] |2019/06/25 22h51:943| <05.00.01> <Function> <> |.Close()|TestItem}|"' (Set|Get) This willClosing the connection
        '''    <Summary>
        '''     (Set|Get) This willClosing the connection
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:301 </Published>
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

#Region "[On] |2019/06/25 22h51:957| <05.00.02> <Function> <> |.List()|List(Of Factures)}|"' (Set|Get) Return the entire table listed
        '''    <Summary>
        '''     (Set|Get) Return the entire table listed
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:302 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Return the entire table listed")>
        Public Function List() As List(Of Factures)
            Dim Result As New List(Of Factures)
            Me.Table = New Table(Me.TableName, Me.FilePath, Me.Password, False)
            For Each Row As DataRow In Me.Table.DataTable.Rows
                Dim Element As New Factures(IIf(IsDBNull(Row.Item(0)), "", Row.Item(0)),
IIf(IsDBNull(Row.Item(1)), "", Row.Item(1)),
IIf(IsDBNull(Row.Item(2)), 0, Row.Item(2)),
IIf(IsDBNull(Row.Item(3)), 0, Row.Item(3)),
IIf(IsDBNull(Row.Item(4)), 0, Row.Item(4)),
IIf(IsDBNull(Row.Item(5)), "", Row.Item(5)),
IIf(IsDBNull(Row.Item(6)), "", Row.Item(6)),
IIf(IsDBNull(Row.Item(7)), New DateTime(1970, 1, 1), Row.Item(7)),
IIf(IsDBNull(Row.Item(8)), New DateTime(1970, 1, 1), Row.Item(8)),
IIf(IsDBNull(Row.Item(9)), New DateTime(1970, 1, 1), Row.Item(9)),
IIf(IsDBNull(Row.Item(10)), "", Row.Item(10)),
IIf(IsDBNull(Row.Item(11)), 0, Row.Item(11)),
IIf(IsDBNull(Row.Item(12)), 0, Row.Item(12)),
IIf(IsDBNull(Row.Item(13)), 0, Row.Item(13)),
IIf(IsDBNull(Row.Item(14)), 0, Row.Item(14)),
IIf(IsDBNull(Row.Item(15)), 0, Row.Item(15)),
  IIf(IsDBNull(Row.Item(16)), "", Row.Item(16)))
                Element.Reset(Table.Line)
                Result.Add(Element)
            Next
            Return Result
        End Function
#End Region '(Set|Get) Return the entire table listed

#Region "[On] |2019/06/25 22h51:972| <05.00.03> <Function> <> |.SearchByName()|List(Of Factures)}|"' (Set|Get) Search for each property that match the Search String.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search String.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:303 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Search for each property that match the Search String.")>
        Public Shared Function SearchByName(ByVal Search As String) As List(Of Factures)
            Dim Result As New List(Of Factures)
            Dim C As New Factures
            For Each Element As Factures In C.List
                If Element.Code.ToLower() = Search.ToLower() Or Element.Emise_Par.ToLower() = Search.ToLower() Or Element.Client.ToLower() = Search.ToLower() Or Element.Adresse.ToLower() = Search.ToLower() Or Element.Concerne.ToLower() = Search.ToLower() Or Element.Libellé.ToLower() = Search.ToLower() Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search String.

#Region "[On] |2019/06/25 22h51:990| <05.00.04> <Function> <> |.SearchByID()|List(Of Factures)}|"' (Set|Get) Search for each property that match the Search Id.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search Id.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:303 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Search for each property that match the Search Id.")>
        Public Shared Function SearchByID(ByVal Search As Double) As List(Of Factures)
            Dim Result As New List(Of Factures)
            Dim C As New Factures
            For Each Element As Factures In C.List
                If Val(Element.Année) = Search Or Val(Element.Mois) = Search Or Val(Element.N) = Search Or Val(Element.Quantité) = Search Or Val(Element.TotalHTVA) = Search Or Val(Element.TotalFrais) = Search Or Val(Element.TotalTVA) = Search Or Val(Element.Total) = Search Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search Id.

#Region "[On] |2019/06/25 22h51:010| <05.00.05> <Function> <> |.SearchByDate()|List(Of Factures)}|"' (Set|Get) Search for each property that match the Search Id.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search Id.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:303 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Search for each property that match the Search Id.")>
        Public Shared Function SearchByDate(ByVal Search As DateTime) As List(Of Factures)
            Dim Result As New List(Of Factures)
            Dim C As New Factures
            For Each Element As Factures In C.List
                If Element.DateEnvoi = Search Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search Id.

#Region "[On] |2019/06/25 22h51:025| <05.00.06> <Function> <> |.SearchByDateRange()|List(Of Factures)}|"' (Set|Get) Search for each property that match the Search Id.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search Id.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:303 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>    ''' <param name="From_Date">All element from this date and this date included.</param>
        ''' <param name="Until_Date">All element before and including this date.</param>

        <Browsable(True), Description("(Set|Get) Search for each property that match the Search Id.")>
        Public Shared Function SearchByDateRange(ByVal From_Date As DateTime,
ByVal Until_Date As DateTime) As List(Of Factures)
            Dim Result As New List(Of Factures)
            Dim C As New Factures
            For Each Element As Factures In C.List
                If (Element.DateEnvoi) >= From_Date And (Element.DateEnvoi) <= Until_Date Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search Id.

#Region "[On] |2019/06/25 22h51:040| <05.00.07> <Function> <> |.ToString()|String}|"' (Set|Get) The function ToString.
        '''    <Summary>
        '''     (Set|Get) The function ToString.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:303 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The function ToString.")>
        Public Overrides Function ToString() As String
            Return Me.Code
        End Function
#End Region '(Set|Get) The function ToString.

#Region "[On] |2019/06/25 22h51:056| <05.00.08> <Function> <> |.CheckConnection()|Boolean}|"' (Set|Get) Evaluate the connection to the DataBase
        '''    <Summary>
        '''     (Set|Get) Evaluate the connection to the DataBase
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:303 </Published>
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


        Public Function Create_Invoice() As Microsoft.Office.Interop.Word.Application

            'Catch Exceptions
            If Me.Code <> "" Then
                If Me.Prestations.Count - 1 < 1 Then
                    If IsNothing(List_Factures_Entries) Then
                        List_Factures_Entries = New List(Of Factures_Entries)
                    End If
                    If List_Factures_Entries.Count - 1 < 1 Then
                        If IsNothing(Current_Factures_Entries) Then
                            Current_Factures_Entries = New Factures_Entries
                            Current_Factures_Entries.Reset(New LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password))
                        End If
                        List_Factures_Entries = Current_Factures_Entries.List
                    End If
                    For Each Entry As Factures_Entries In List_Factures_Entries
                        If Entry.Facture = Me.Code Then
                            Prestations.Add(Entry)
                        End If
                    Next
                End If


#Region "<Creation of App>"
                Dim WordApplication As Microsoft.Office.Interop.Word.Application
                Dim WordDocument As Microsoft.Office.Interop.Word.Document
                '    Dim Paragraph_Address As Microsoft.Office.Interop.Word.Paragraph
#End Region
#Region "<Formatting>"
                'Initialize Instruments
                WordApplication = CreateObject("Word.Application")
                WordApplication.Visible = True
                WordDocument = WordApplication.Documents.Add
                'Formating page
                With WordDocument.PageSetup
                    .LeftMargin = Math.Round((2) * 37.795275591, 2)
                    .RightMargin = Math.Round(1.5 * 37.795275591, 2)
                    .TopMargin = Math.Round(1.9 * 37.795275591, 2)
                    .BottomMargin = Math.Round(3.17 * 37.795275591, 2)
                End With
#End Region
                Dim F As New System.Drawing.Font("Arial", 12)
#Region "Null row"
                Dim Pn As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
                With Pn
                    .Range.Font.Name = F.Name
                    .Range.Font.Size = F.Size
                    .Range.Font.Bold = True
                    .Range.Text = ""
                    .IndentCharWidth(24)
                    .Range.InsertParagraphAfter()
                    .Format.SpaceAfter = 0
                End With
                Dim Pn1 As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
                With Pn1
                    .Range.Font.Name = F.Name
                    .Range.Font.Size = F.Size
                    .Range.Font.Bold = True
                    .Range.Text = ""
                    .IndentCharWidth(0)
                    .Range.InsertParagraphAfter()
                    .Format.SpaceAfter = 0
                End With
                Dim Pn2 As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
                With Pn2
                    .Range.Font.Name = F.Name
                    .Range.Font.Size = F.Size
                    .Range.Font.Bold = True
                    .Range.Text = ""
                    .IndentCharWidth(0)
                    .Range.InsertParagraphAfter()
                    .Format.SpaceAfter = 0
                End With
                Dim Pn3 As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
                With Pn3
                    .Range.Font.Name = F.Name
                    .Range.Font.Size = F.Size
                    .Range.Font.Bold = True
                    .Range.Text = ""
                    .IndentCharWidth(0)
                    .Range.InsertParagraphAfter()
                    .Format.SpaceAfter = 0
                End With
                Dim Pn4 As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
                With Pn4
                    .Range.Font.Name = F.Name
                    .Range.Font.Size = F.Size
                    .Range.Font.Bold = True
                    .Range.Text = ""
                    .IndentCharWidth(0)
                    .Range.InsertParagraphAfter()
                    .Format.SpaceAfter = 0
                End With
#End Region
                Dim P As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
                With P
                    .Range.Font.Name = F.Name
                    .Range.Font.Size = F.Size
                    .Range.Font.Bold = True
                    Dim C As Clients = Clients.SearchByName(Me.Client)(0)
                    Dim Address As String = ""
                    If C.RaisonSociale.Length > 1 Then
                        Address += C.RaisonSociale & vbNewLine
                    End If
                    If C.NomClient.Length > 1 Then
                        Address += C.NomClient & vbNewLine
                    End If
                    Address += C.Address1
                    If C.Address2.Length > 1 Then
                        Address += C.Address2 & vbNewLine
                    End If
                    Address += C.PostalCode & " "
                    If C.Region.Length > 1 Then
                        Address += C.Region & vbNewLine &
                            C.City & " " & C.Country
                    Else
                        If C.City.Length > 1 Then
                            Address += C.City & vbNewLine &
                                C.Country
                        End If
                    End If
                    .Range.Text = Address
                    .IndentCharWidth(0)
                    .Range.InsertParagraphAfter()
                    .Format.SpaceAfter = 0
                End With
#Region "Null Row"
                Dim Pn5 As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
                With Pn5
                    .Range.Font.Name = F.Name
                    .Range.Font.Size = F.Size
                    .Range.Font.Bold = False
                    .Range.Text = ""
                    .IndentCharWidth(-24)
                    .Range.InsertParagraphAfter()
                    .Format.SpaceAfter = 0
                End With
                Dim Pn6 As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
                With Pn6
                    .Range.Font.Name = F.Name
                    .Range.Font.Size = F.Size
                    .Range.Font.Bold = False
                    .Range.Text = ""
                    .IndentCharWidth(0)
                    .Range.InsertParagraphAfter()
                    .Format.SpaceAfter = 0
                End With
#End Region
                Current_Société = Sociétés.SearchByName(Me.Emise_Par)(0)

                Dim P1 As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
                With P1
                    .Range.Font.Name = F.Name
                    .Range.Font.Size = F.Size
                    .Range.Font.Bold = False
                    .Range.Text = "Contribuable Tva : N° " & Current_Société.NuméroTVA & vbTab & " Genève le " & Now.Date.ToShortDateString
                    .IndentCharWidth(0)
                    .Range.InsertParagraphAfter()
                    .Format.SpaceAfter = 0
                End With
#Region "Null Row"
                Dim Pn7 As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
                With Pn7
                    .Range.Font.Name = F.Name
                    .Range.Font.Size = F.Size
                    .Range.Font.Bold = False
                    .Range.Text = ""
                    .IndentCharWidth(0)
                    .Range.InsertParagraphAfter()
                    .Format.SpaceAfter = 0
                End With

#End Region
                Dim P2 As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
                With P2
                    .Range.Font.Name = F.Name
                    .Range.Font.Size = F.Size
                    .Range.Font.Bold = False
                    .Range.Text = Libellé
                    .IndentCharWidth(0)
                    .Range.InsertParagraphAfter()
                    .Format.SpaceAfter = 0
                End With
#Region "Null Row"
                Dim Pn8 As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
                With Pn8
                    .Range.Font.Name = F.Name
                    .Range.Font.Size = F.Size
                    .Range.Font.Bold = False
                    .Range.Text = ""
                    .IndentCharWidth(0)
                    .Range.InsertParagraphAfter()
                    .Format.SpaceAfter = 0
                End With
                Dim Pn80 As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
                With Pn80
                    .Range.Font.Name = F.Name
                    .Range.Font.Size = F.Size
                    .Range.Font.Bold = False
                    .Range.Text = ""
                    .IndentCharWidth(0)
                    .Range.InsertParagraphAfter()
                    .Format.SpaceAfter = 0
                End With
#End Region

                Dim P3 As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
                With P3
                    .Range.Font.Name = F.Name
                    .Range.Font.Size = F.Size
                    .Range.Font.Bold = False
                    .Range.Text = "Facture N° : " & Mid(Now.Year, 2) & "-" & N & "/" & Client & "/ du " & Me.PériodeIN.ToShortDateString & " au " & Me.PériodeFIN.ToShortDateString
                    .IndentCharWidth(0)
                    .Range.InsertParagraphAfter()
                    .Format.SpaceAfter = 0
                End With

#Region "Null Row"
                Dim Pn8x As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
                With Pn8x
                    .Range.Font.Name = F.Name
                    .Range.Font.Size = F.Size
                    .Range.Font.Bold = False
                    .Range.Text = ""
                    .IndentCharWidth(0)
                    .Range.InsertParagraphAfter()
                    .Format.SpaceAfter = 0
                End With
                Dim Pn80x As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
                With Pn80x
                    .Range.Font.Name = F.Name
                    .Range.Font.Size = F.Size
                    .Range.Font.Bold = False
                    .Range.Text = ""
                    .IndentCharWidth(0)
                    .Range.InsertParagraphAfter()
                    .Format.SpaceAfter = 0
                End With
#End Region
                Dim P4 As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
                With P4
                    .Range.Font.Name = F.Name
                    .Range.Font.Size = F.Size
                    .Range.Font.Bold = False
                    .Range.Text = "Concerne : " & Me.Concerne
                    .IndentCharWidth(0)
                    .Range.InsertParagraphAfter()
                    .Format.SpaceAfter = 0
                End With
#Region "Null Row"
                Dim Pn9 As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
                With Pn9
                    .Range.Font.Name = F.Name
                    .Range.Font.Size = F.Size
                    .Range.Font.Bold = False
                    .Range.Text = ""
                    .IndentCharWidth(0)
                    .Range.InsertParagraphAfter()
                    .Format.SpaceAfter = 0
                End With
                Dim Pn10 As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
                With Pn10
                    .Range.Font.Name = F.Name
                    .Range.Font.Size = F.Size
                    .Range.Font.Bold = False
                    .Range.Text = ""
                    .IndentCharWidth(0)
                    .Range.InsertParagraphAfter()
                    .Format.SpaceAfter = 0
                End With
                Dim Pn11 As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
                With Pn11
                    .Range.Font.Name = F.Name
                    .Range.Font.Size = F.Size
                    .Range.Font.Bold = False
                    .Range.Text = ""
                    .IndentCharWidth(0)
                    .Range.InsertParagraphAfter()
                    .Format.SpaceAfter = 0
                End With
#End Region
                Dim PTable As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
                Dim WordTable = WordDocument.Tables.Add(Range:=PTable.Range, NumRows:=9, NumColumns:=2)
                WordTable.Range.InsertParagraphAfter()
                With WordTable
                    .Cell(1, 1).Range.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle
                    .Cell(1, 1).Range.Text = "Total des prestations"
                    .Cell(1, 1).Range.Font.Name = F.Name
                    .Cell(1, 1).Range.Font.Size = F.Size

                    .Cell(1, 2).Range.Text = "(" & String.Format("{0:n2}", Quantité & ")" & vbTab & vbTab & String.Format("{0:n2}", TotalHTVA))
                    .Cell(1, 2).Range.Font.Name = F.Name
                    .Cell(1, 2).Range.Font.Size = F.Size
                    .Cell(1, 2).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight

                    .Cell(2, 1).Range.Text = "Total des frais"
                    .Cell(2, 1).Range.Font.Name = F.Name
                    .Cell(2, 1).Range.Font.Size = F.Size

                    .Cell(2, 2).Range.Text = String.Format("{0:n2}", Double.Parse(TotalFrais))
                    .Cell(2, 2).Range.Font.Name = F.Name
                    .Cell(2, 2).Range.Font.Size = F.Size
                    .Cell(2, 2).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight
                    .Cell(2, 2).Range.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle

                    .Cell(3, 2).Range.Text = "__________"
                    .Cell(3, 2).Range.Font.Name = F.Name
                    .Cell(3, 2).Range.Font.Size = F.Size
                    .Cell(3, 2).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight
                    .Cell(3, 2).Range.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle

                    .Cell(4, 2).Range.Text = String.Format("{0:n2}", Double.Parse(TotalHTVA))
                    .Cell(4, 2).Range.Font.Name = F.Name
                    .Cell(4, 2).Range.Font.Size = F.Size
                    .Cell(4, 2).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight



                    .Cell(5, 1).Range.Text = "TVA " & My.Settings.TVA * 100 & " %"
                    .Cell(5, 1).Range.Font.Name = F.Name
                    .Cell(5, 1).Range.Font.Size = F.Size

                    .Cell(5, 2).Range.Text = String.Format("{0:n2}", Double.Parse(TotalTVA))
                    .Cell(5, 2).Range.Font.Name = F.Name
                    .Cell(5, 2).Range.Font.Size = F.Size
                    .Cell(5, 2).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight
                    .Cell(5, 2).Range.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle

                    .Cell(6, 2).Range.Text = "__________"
                    .Cell(6, 2).Range.Font.Name = F.Name
                    .Cell(6, 2).Range.Font.Size = F.Size
                    .Cell(6, 2).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight
                    .Cell(6, 2).Range.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle

                    .Cell(7, 1).Range.Text = "Total payable au "
                    .Cell(7, 1).Range.Font.Name = F.Name
                    .Cell(7, 1).Range.Font.Size = F.Size

                    .Cell(7, 2).Range.Text = String.Format("{0:n2}", Double.Parse((Total)))
                    .Cell(7, 2).Range.Font.Name = F.Name
                    .Cell(7, 2).Range.Font.Size = F.Size
                    .Cell(7, 2).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight
                    .Cell(7, 2).Range.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble
                    P.Range.InsertParagraphAfter()
                End With
#Region "Null Row"
                Dim Pn12 As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
                With Pn12
                    .Range.Font.Name = F.Name
                    .Range.Font.Size = F.Size
                    .Range.Font.Bold = False
                    .Range.Text = ""
                    .IndentCharWidth(0)
                    .Range.InsertParagraphAfter()
                    .Format.SpaceAfter = 0
                End With
                Dim Pn13 As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
                With Pn13
                    .Range.Font.Name = F.Name
                    .Range.Font.Size = F.Size
                    .Range.Font.Bold = False
                    .Range.Text = ""
                    .IndentCharWidth(0)
                    .Range.InsertParagraphAfter()
                    .Format.SpaceAfter = 0
                End With
                Dim Pn14 As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
                With Pn14
                    .Range.Font.Name = F.Name
                    .Range.Font.Size = F.Size
                    .Range.Font.Bold = False
                    .Range.Text = ""
                    .IndentCharWidth(0)
                    .Range.InsertParagraphAfter()
                    .Format.SpaceAfter = 0
                End With
                Dim Pn15 As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
                With Pn15
                    .Range.Font.Name = F.Name
                    .Range.Font.Size = F.Size
                    .Range.Font.Bold = False
                    .Range.Text = ""
                    .IndentCharWidth(0)
                    .Range.InsertParagraphAfter()
                    .Format.SpaceAfter = 0
                End With
#End Region
                Dim P5 As Microsoft.Office.Interop.Word.Paragraph = WordDocument.Paragraphs.Add
                With P5
                    .Range.Font.Name = F.Name
                    .Range.Font.Size = F.Size
                    .Range.Font.Bold = False
                    .Range.Text = "Avec nos remerciements "
                    .IndentCharWidth(0)
                    .Range.InsertParagraphAfter()
                    .Format.SpaceAfter = 0
                End With




                '  End If

                releaseObject(WordDocument)
                releaseObject(WordApplication)
                Return WordApplication
            End If
            Return Nothing
        End Function
        Public Function Print_InvoiceDetails() As WordDocument
            If Me.Prestations.Count - 1 < 1 Then
                If IsNothing(List_Factures_Entries) Then
                    List_Factures_Entries = New List(Of Factures_Entries)
                End If
                If List_Factures_Entries.Count - 1 < 1 Then
                    If IsNothing(Current_Factures_Entries) Then
                        Current_Factures_Entries = New Factures_Entries
                        Current_Factures_Entries.Reset(New LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password))
                    End If
                    List_Factures_Entries = Current_Factures_Entries.List
                End If
                For Each Entry As Factures_Entries In List_Factures_Entries
                    If Entry.Facture = Me.Code Then
                        Prestations.Add(Entry)
                    End If
                Next

                Dim Result As New WordDocument
                With Result.WordDocument.PageSetup
                    .LeftMargin = Math.Round((2) * 37.795275591, 2)
                    .RightMargin = Math.Round(1.5 * 37.795275591, 2)
                    .TopMargin = Math.Round(1.9 * 37.795275591, 2)
                    .BottomMargin = Math.Round(3.17 * 37.795275591, 2)
                End With



                Dim P As Microsoft.Office.Interop.Word.Paragraph = Result.WordDocument.Paragraphs.Add
                Try

                    'Word.Document.Range(Start:=0, End:=0)
                    Dim F As New System.Drawing.Font("Arial", 12)
                    For Each Fx As Factures_Entries In Prestations
                        Dim PC As Microsoft.Office.Interop.Word.Paragraph = Result.WordDocument.Paragraphs.Add
                        Dim Tb = Result.Insert_Table(PC.Range, 1, 2)
                        Result.WordTable.Cell(1, 1).SetWidth(Result.WordApp.InchesToPoints(4), RulerStyle:=Microsoft.Office.Interop.Word.WdRulerStyle.wdAdjustNone) '255 ' * 37.795275591
                        Result.WordTable.Cell(1, 2).SetWidth(Result.WordApp.InchesToPoints(2), RulerStyle:=Microsoft.Office.Interop.Word.WdRulerStyle.wdAdjustNone) '* 37.795275591

                        With Result.WordTable.Cell(1, 2).Range
                            .ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight
                            .Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle
                            .Text = Fx.Quantity & vbTab & Fx.TotalHTVA
                            .Font.Name = F.Name
                            .Font.Size = F.Size
                        End With
                        With Result.WordTable.Cell(1, 1).Range
                            .Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle
                            .Text = Fx.Description
                            .Font.Name = F.Name
                            .Font.Size = F.Size
                        End With
                        PC.Range.InsertParagraphAfter()


                    Next
                Catch ex As Exception
                    MsgBox(ex.Message)

                End Try
                Result.Release()
                Return Result
            End If
            Return Nothing
        End Function

        Public Function GetMyEntries() As List(Of Factures_Entries)
            Prestations = New List(Of Factures_Entries)
            '  If IsNothing(List_Factures_Entries) Then
            List_Factures_Entries = New List(Of Factures_Entries)
            '  End If
            If List_Factures_Entries.Count - 1 < 1 Then
                If IsNothing(Current_Factures_Entries) Then
                    Current_Factures_Entries = New Factures_Entries
                    Current_Factures_Entries.Reset(New LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password))
                End If
                List_Factures_Entries = Current_Factures_Entries.List
            End If
            For Each F As Factures_Entries In List_Factures_Entries
                If F.Facture = Me.Code Then
                    Prestations.Add(F)
                End If
            Next
            Return Prestations
        End Function
#End Region

#Region "<6> [Runtime]{12}"
        Public Prestations As New List(Of Factures_Entries)
#Region "[On] |2019/06/25 22h51:071| <15.00.00> <Runtime> <> |.Table()|Table"' (Set|Get) The Table.
        '''    <Summary>
        '''     (Set|Get) The Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:304 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Table.")>
        Public Table As Table
#End Region '(Set|Get) The Table.

#Region "[On] |2019/06/25 22h51:106| <15.00.01> <Runtime> <> |.Line()|String"' (Set|Get) The Connection String To the Table.
        '''    <Summary>
        '''     (Set|Get) The Connection String To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:304 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Connection String To the Table.")>
        Public Line As String
#End Region '(Set|Get) The Connection String To the Table.

#Region "[On] |2019/06/25 22h51:139| <15.00.02> <Runtime> <> |.FilePath()|String"' (Set|Get) The FilePath To the Table.
        '''    <Summary>
        '''     (Set|Get) The FilePath To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:304 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The FilePath To the Table.")>
        Public FilePath As String
#End Region '(Set|Get) The FilePath To the Table.

#Region "[On] |2019/06/25 22h51:171| <15.00.03> <Runtime> <> |.Password()|String"' (Set|Get) The Password To the Table.
        '''    <Summary>
        '''     (Set|Get) The Password To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:304 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Password To the Table.")>
        Public Password As String
#End Region '(Set|Get) The Password To the Table.

#Region "[On] |2019/06/25 22h51:203| <15.00.04> <Runtime> <> |.UseSQL()|Boolean"' (Set|Get) Determines if the Database Connection is of type SQL.
        '''    <Summary>
        '''     (Set|Get) Determines if the Database Connection is of type SQL.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:305 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Determines if the Database Connection is of type SQL.")>
        Public UseSQL As Boolean
#End Region '(Set|Get) Determines if the Database Connection is of type SQL.

#Region "[On] |2019/06/25 22h51:237| <15.00.05> <Runtime> <> |.TableName()|String"' (Set|Get) The name of the Table.
        '''    <Summary>
        '''     (Set|Get) The name of the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:305 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The name of the Table.")>
        Public TableName As String
#End Region '(Set|Get) The name of the Table.

#Region "[On] |2019/06/25 22h51:270| <15.00.06> <Runtime> <> |.Con()|OleDb.OleDbConnection"' (Set|Get) The Con To the Table.
        '''    <Summary>
        '''     (Set|Get) The Con To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:305 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Con To the Table.")>
        Public Con As OleDb.OleDbConnection
#End Region '(Set|Get) The Con To the Table.

#Region "[On] |2019/06/25 22h51:313| <15.00.07> <Runtime> <> |.Cmd()|OleDb.OleDbCommand"' (Set|Get) The Cmd To the Table.
        '''    <Summary>
        '''     (Set|Get) The Cmd To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:305 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Cmd To the Table.")>
        Public Cmd As OleDb.OleDbCommand
#End Region '(Set|Get) The Cmd To the Table.

#Region "[On] |2019/06/25 22h51:347| <15.00.08> <Runtime> <> |.DataReader()|OleDb.OleDbDataReader"' (Set|Get) The DataReader To the Table.
        '''    <Summary>
        '''     (Set|Get) The DataReader To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:305 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The DataReader To the Table.")>
        Public DataReader As OleDb.OleDbDataReader
#End Region '(Set|Get) The DataReader To the Table.

#Region "[On] |2019/06/25 22h51:391| <15.00.09> <Runtime> <> |.DataAdapter()|OleDb.OleDbDataAdapter"' (Set|Get) The DataAdapter To the Table.
        '''    <Summary>
        '''     (Set|Get) The DataAdapter To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:306 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The DataAdapter To the Table.")>
        Public DataAdapter As OleDb.OleDbDataAdapter
#End Region '(Set|Get) The DataAdapter To the Table.

#Region "[On] |2019/06/25 22h51:426| <15.00.10> <Runtime> <> |.Connector()|LineInfo"' (Set|Get) The Connector To the Table.
        '''    <Summary>
        '''     (Set|Get) The Connector To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:306 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Connector To the Table.")>
        Public Connector As LineInfo
#End Region '(Set|Get) The Connector To the Table.

#Region "[On] |2019/06/25 22h51:459| <15.00.11> <Runtime> <> |.Log()|String"' (Set|Get) The Log To the Table.
        '''    <Summary>
        '''     (Set|Get) The Log To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:306 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Log To the Table.")>
        Public Log As String
#End Region '(Set|Get) The Log To the Table.

#End Region
#Region "<7> [Loader]{2}"
#Region "[On] |2019/06/25 22h51:493| <06.00.00> <Loader> <> |.Empty()|Function}|"' (Set|Get) The sub Empty.
        '''    <Summary>
        '''     (Set|Get) The sub Empty.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:306 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The sub Empty.")>
        Public Sub New()
            Reset
        End Sub
#End Region '(Set|Get) The sub Empty.

#Region "[On] |2019/06/25 22h51:497| <06.00.01> <Loader> <> |.Filled()|Function}|"' (Set|Get) The sub Filled.
        '''    <Summary>
        '''     (Set|Get) The sub Filled.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:306 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>    ''' <param name="Code">(Set|Get) The Code as String.</param>
        ''' <param name="Emise_Par">(Set|Get) The Emise_Par as String.</param>
        ''' <param name="Année">(Set|Get) The Année as Integer.</param>
        ''' <param name="Mois">(Set|Get) The Mois as Integer.</param>
        ''' <param name="N">(Set|Get) The N as Integer.</param>
        ''' <param name="Client">(Set|Get) The Client as String.</param>
        ''' <param name="Adresse">(Set|Get) The Adresse as String.</param>
        ''' <param name="DateEnvoi">(Set|Get) The DateEnvoi as DateTime.</param>
        ''' <param name="PériodeIN">(Set|Get) The PériodeIN as DateTime.</param>
        ''' <param name="PériodeFIN">(Set|Get) The PériodeFIN as DateTime.</param>
        ''' <param name="Concerne">(Set|Get) The Concerne as String.</param>
        ''' <param name="Quantité">(Set|Get) The Quantité as Double.</param>
        ''' <param name="TotalHTVA">(Set|Get) The TotalHTVA as Double.</param>
        ''' <param name="TotalFrais">(Set|Get) The TotalFrais as Double.</param>
        ''' <param name="TotalTVA">(Set|Get) The TotalTVA as Double.</param>
        ''' <param name="Total">(Set|Get) The Total as Double.</param>
        ''' <param name="Libellé">(Set|Get) The Libellé as String.</param>

        <Browsable(True), Description("(Set|Get) The sub Filled.")>
        Public Sub New(ByVal Code As String,
ByVal Emise_Par As String,
ByVal Année As Integer,
ByVal Mois As Integer,
ByVal N As Integer,
ByVal Client As String,
ByVal Adresse As String,
ByVal DateEnvoi As DateTime,
ByVal PériodeIN As DateTime,
ByVal PériodeFIN As DateTime,
ByVal Concerne As String,
ByVal Quantité As Double,
ByVal TotalHTVA As Double,
ByVal TotalFrais As Double,
ByVal TotalTVA As Double,
ByVal Total As Double,
ByVal Libellé As String)
            With Me
                Clear()
                Reset()
                .Code = Code
                .Emise_Par = Emise_Par
                .Année = Année
                .Mois = Mois
                .N = N
                .Client = Client
                .Adresse = Adresse
                .DateEnvoi = DateEnvoi
                .PériodeIN = PériodeIN
                .PériodeFIN = PériodeFIN
                .Concerne = Concerne
                .Quantité = Quantité
                .TotalHTVA = TotalHTVA
                .TotalFrais = TotalFrais
                .TotalTVA = TotalTVA
                .Total = Total
                .Libellé = Libellé
            End With

        End Sub
#End Region '(Set|Get) The sub Filled.

#End Region
    End Class
#End Region
#Region "[On] |2019/06/25 22h51:732| <08.00.00> <Class> <> |.Factures_Entries|Class|{38} |Production Cost : 46.3|Selling Price : 69.45|"' Class created automatically by SmartOffice (c)Copyright 2019.
    '''    <Summary>
    '''     Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Factures_Entries
    '''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
    '''    Contributor Information : ||
    '''    Creation Date :           2019/06/25 22h51:732
    '''    |Schema|
    '''    |ID| |ObjectType |{Quantity}||UnitPrice||Total
    '''    |00| |Importation|{0}||1| |0
    '''    |01| |Properties |{11}||0.8| |8.8
    '''    |02| |Enumeration|{1}||0.4| |0.4
    '''    |03| |Structure  |{0}||0.4| |0
    '''    |04| |Sub        |{5}||1.2| |6
    '''    |05| |Function   |{7}||1.6| |11.2
    '''    |06| |Runtime    |{12}||0.4| |4.8
    '''    |07| |Loader     |{2}||0.8| |1.6
    '''    |08| |Class      |{0}||2| |0
    '''    |09| |Constante  |{0}||0.4| |0
    '''    |10| |Event      |{0}||1.2| |0
    '''    |11| |Members    |{11}||0.5| |5.5
    '''    |12| |Parameter  |{16}||0.5| |8
    '''    |Production Cost             |46.3
    '''    |Selling Price without VAT   |69.45
    '''    |Total TVA                   |5.35
    '''    |Grand Total                 |74.8
    '''    |/Schema|
    '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
    '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
    '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
    '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:325 </Published>
    '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
    '''    </Summary>
    Public Class Factures_Entries
#Region "<1> [Property]{11}"
#Region "[On] |2019/06/25 22h51:733| <01.00.00> <Property> <Columns> |.ID()|Integer|"' (Set|Get) The ID as Integer.
        Private _ID As Integer
        '''    <Summary>
        '''     (Set|Get) The ID as Integer.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:325 </Published>
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

#Region "[On] |2019/06/25 22h51:744| <01.00.01> <Property> <Columns> |.Facture()|String|"' (Set|Get) The Facture as String.
        Private _Facture As String
        '''    <Summary>
        '''     (Set|Get) The Facture as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:328 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Facture as String.")>
        Public Property Facture() As String
            Get
                Return _Facture
            End Get
            Set(ByVal Value As String)
                _Facture = Value
            End Set
        End Property
#End Region '(Set|Get) The Facture as String.

#Region "[On] |2019/06/25 22h51:756| <01.00.02> <Property> <Columns> |.Active()|Boolean|"' (Set|Get) The Active as Boolean.
        Private _Active As Boolean
        '''    <Summary>
        '''     (Set|Get) The Active as Boolean.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:328 </Published>
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

#Region "[On] |2019/06/25 22h51:768| <01.00.03> <Property> <Columns> |.DateEntry()|DateTime|"' (Set|Get) The DateEntry as DateTime.
        Private _DateEntry As DateTime
        '''    <Summary>
        '''     (Set|Get) The DateEntry as DateTime.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:328 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The DateEntry as DateTime.")>
        Public Property DateEntry() As DateTime
            Get
                Return _DateEntry
            End Get
            Set(ByVal Value As DateTime)
                _DateEntry = Value
            End Set
        End Property
#End Region '(Set|Get) The DateEntry as DateTime.

#Region "[On] |2019/06/25 22h51:780| <01.00.04> <Property> <Columns> |.Collaborateur()|String|"' (Set|Get) The Collaborateur as String.
        Private _Collaborateur As String
        '''    <Summary>
        '''     (Set|Get) The Collaborateur as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:329 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Collaborateur as String.")>
        Public Property Collaborateur() As String
            Get
                Return _Collaborateur
            End Get
            Set(ByVal Value As String)
                _Collaborateur = Value
            End Set
        End Property
#End Region '(Set|Get) The Collaborateur as String.

#Region "[On] |2019/06/25 22h51:793| <01.00.05> <Property> <Columns> |.Mandat()|String|"' (Set|Get) The Mandat as String.
        Private _Mandat As String
        '''    <Summary>
        '''     (Set|Get) The Mandat as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:329 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Mandat as String.")>
        Public Property Mandat() As String
            Get
                Return _Mandat
            End Get
            Set(ByVal Value As String)
                _Mandat = Value
            End Set
        End Property
#End Region '(Set|Get) The Mandat as String.

#Region "[On] |2019/06/25 22h51:805| <01.00.06> <Property> <Columns> |.UnitPrice()|Double|"' (Set|Get) The UnitPrice as Double.
        Private _UnitPrice As Double
        '''    <Summary>
        '''     (Set|Get) The UnitPrice as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:329 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The UnitPrice as Double.")>
        Public Property UnitPrice() As Double
            Get
                Return _UnitPrice
            End Get
            Set(ByVal Value As Double)
                _UnitPrice = Value
            End Set
        End Property
#End Region '(Set|Get) The UnitPrice as Double.

#Region "[On] |2019/06/25 22h51:817| <01.00.07> <Property> <Columns> |.Description()|String|"' (Set|Get) The Description as String.
        Private _Description As String
        '''    <Summary>
        '''     (Set|Get) The Description as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:330 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Description as String.")>
        Public Property Description() As String
            Get
                Return _Description
            End Get
            Set(ByVal Value As String)
                _Description = Value
            End Set
        End Property
#End Region '(Set|Get) The Description as String.

#Region "[On] |2019/06/25 22h51:831| <01.00.08> <Property> <Columns> |.Facturable()|Boolean|"' (Set|Get) The Facturable as Boolean.
        Private _Facturable As Boolean
        '''    <Summary>
        '''     (Set|Get) The Facturable as Boolean.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:330 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Facturable as Boolean.")>
        Public Property Facturable() As Boolean
            Get
                Return _Facturable
            End Get
            Set(ByVal Value As Boolean)
                _Facturable = Value
            End Set
        End Property
#End Region '(Set|Get) The Facturable as Boolean.

#Region "[On] |2019/06/25 22h51:844| <01.00.09> <Property> <Columns> |.TotalHTVA()|Double|"' (Set|Get) The TotalHTVA as Double.
        Private _TotalHTVA As Double
        '''    <Summary>
        '''     (Set|Get) The TotalHTVA as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:333 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The TotalHTVA as Double.")>
        Public Property TotalHTVA() As Double
            Get
                Return _TotalHTVA
            End Get
            Set(ByVal Value As Double)
                _TotalHTVA = Value
            End Set
        End Property
#End Region '(Set|Get) The TotalHTVA as Double.

#Region "[On] |2019/06/25 22h51:858| <01.00.10> <Property> <Columns> |.Quantity()|Double|"' (Set|Get) The Quantity as Double.
        Private _Quantity As Double
        '''    <Summary>
        '''     (Set|Get) The Quantity as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:333 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Quantity as Double.")>
        Public Property Quantity() As Double
            Get
                Return _Quantity
            End Get
            Set(ByVal Value As Double)
                _Quantity = Value
            End Set
        End Property
#End Region '(Set|Get) The Quantity as Double.

#End Region
#Region "<2> [Enumeration]{1}"
#Region "[On] |2019/06/25 22h51:871| <02.00.00> <Enumeration> <> |.Schema()|Enumeration{10}|"' (Set|Get) The enumeration of Schema.
        '''    <Summary>
        '''     (Set|Get) The enumeration of Schema.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:333 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The enumeration of Schema.")>
        Enum Schema
            ''' <summary>(Set|Get) The ID as Integer.</summary>
            [ID] = 0
            ''' <summary>(Set|Get) The Facture as String.</summary>
            [Facture] = 1
            ''' <summary>(Set|Get) The Active as Boolean.</summary>
            [Active] = 2
            ''' <summary>(Set|Get) The DateEntry as DateTime.</summary>
            [DateEntry] = 3
            ''' <summary>(Set|Get) The Collaborateur as String.</summary>
            [Collaborateur] = 4
            ''' <summary>(Set|Get) The Mandat as String.</summary>
            [Mandat] = 5
            ''' <summary>(Set|Get) The UnitPrice as Double.</summary>
            [UnitPrice] = 6
            ''' <summary>(Set|Get) The Description as String.</summary>
            [Description] = 7
            ''' <summary>(Set|Get) The Facturable as Boolean.</summary>
            [Facturable] = 8
            ''' <summary>(Set|Get) The TotalHTVA as Double.</summary>
            [TotalHTVA] = 9
            ''' <summary>(Set|Get) The Quantity as Double.</summary>
            [Quantity] = 10
        End Enum
#End Region '(Set|Get) The enumeration of Schema.

#End Region
#Region "<4> [Sub]{5}"
#Region "[On] |2019/06/25 22h51:889| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
        '''    <Summary>
        '''     (Set|Get) This will reinitialize the class element.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:333 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will reinitialize the class element.")>
        Public Sub Clear()
            With Me
                .ID = 0
                .Facture = Nothing
                .Active = False
                .DateEntry = New DateTime
                .Collaborateur = Nothing
                .Mandat = Nothing
                .UnitPrice = 0
                .Description = Nothing
                .Facturable = False
                .TotalHTVA = 0
                .Quantity = 0
            End With
        End Sub
#End Region '(Set|Get) This will reinitialize the class element.

#Region "[On] |2019/06/25 22h51:901| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
        '''    <Summary>
        '''     (Set|Get) This will reinitialize the variables of this class.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:334 </Published>
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
                    TableName = "Factures_Entries"
                    Line = Connector.Line
                    UseSQL = False
                Else
                    FilePath = My.Settings.Db_TimeSheet_FilePath
                    Password = My.Settings.Db_TimeSheet_Password
                    Me.Line = My.Settings.Db_TimeSheet_Line
                    TableName = "Factures_Entries"
                    UseSQL = False
                End If
            Else
                If IsNothing(FilePath) Then
                    FilePath = My.Settings.Db_TimeSheet_FilePath
                End If
                If FilePath.Length < 1 Then
                    FilePath = My.Settings.Db_TimeSheet_FilePath
                End If
                FilePath = My.Settings.Db_TimeSheet_FilePath
                Password = My.Settings.Db_TimeSheet_Password
                Me.Line = My.Settings.Db_TimeSheet_Line
                TableName = "Factures_Entries"
                UseSQL = False
            End If

        End Sub
#End Region '(Set|Get) This will reinitialize the variables of this class.

#Region "[On] |2019/06/25 23h39:490| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
        '''    <Summary>
        '''     (Set|Get) This will add a new row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 23h39:084 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will add a new row in the table.")>
        Public Sub Add()
            Try
                Dim Str As String = Nothing
                Str = "Insert Into [Factures_Entries] (
`ID`, 
`Facture`, 
`Active`, 
`DateEntry`, 
`Collaborateur`, 
`Mandat`, 
`UnitPrice`, 
`Description`, 
`Facturable`, 
`TotalHTVA`, 
`Quantity`) Values (@0, @1, @2, @3, @4, @5, @6, @7, @8, @9, @10)"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@0", Me.ID)
                Cmd.Parameters.AddWithValue("@1", Me.Facture)
                Cmd.Parameters.AddWithValue("@2", Me.Active)
                Cmd.Parameters.AddWithValue("@3", Me.DateEntry)
                Cmd.Parameters.AddWithValue("@4", Me.Collaborateur)
                Cmd.Parameters.AddWithValue("@5", Me.Mandat)
                Cmd.Parameters.AddWithValue("@6", Me.UnitPrice)
                Cmd.Parameters.AddWithValue("@7", Me.Description)
                Cmd.Parameters.AddWithValue("@8", Me.Facturable)
                Cmd.Parameters.AddWithValue("@9", Me.TotalHTVA)
                Cmd.Parameters.AddWithValue("@10", Me.Quantity)
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

#Region "[On] |2019/06/25 22h51:927| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
        '''    <Summary>
        '''     (Set|Get) This will update a row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:334 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will update a row in the table.")>
        Public Sub Save()
            Try
                Dim Str As String = Nothing
                Str = "UPDATE [Factures_Entries] SET Facture = @Facture, Active = @Active, DateEntry = @DateEntry, Collaborateur = @Collaborateur, Mandat = @Mandat, UnitPrice = @UnitPrice, Description = @Description, Facturable = @Facturable, TotalHTVA = @TotalHTVA, Quantity = @Quantity WHERE ID = @ID"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@Facture", Facture)
                Cmd.Parameters.AddWithValue("@Active", Active)
                Cmd.Parameters.AddWithValue("@DateEntry", DateEntry)
                Cmd.Parameters.AddWithValue("@Collaborateur", Collaborateur)
                Cmd.Parameters.AddWithValue("@Mandat", Mandat)
                Cmd.Parameters.AddWithValue("@UnitPrice", UnitPrice)
                Cmd.Parameters.AddWithValue("@Description", Description)
                Cmd.Parameters.AddWithValue("@Facturable", Facturable)
                Cmd.Parameters.AddWithValue("@TotalHTVA", TotalHTVA)
                Cmd.Parameters.AddWithValue("@Quantity", Quantity)
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

#Region "[On] |2019/06/25 22h51:940| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
        '''    <Summary>
        '''     (Set|Get) This will Delete a row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:334 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will Delete a row in the table.")>
        Public Sub Delete()
            Try
                Dim Str As String = Nothing
                Str = "Delete From [Factures_Entries] WHERE ID =@ID"
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
#Region "[On] |2019/06/25 22h51:954| <05.00.00> <Function> <> |.Open()|TestItem}|"' (Set|Get) This will initialise the connection and import the data.
        '''    <Summary>
        '''     (Set|Get) This will initialise the connection and import the data.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:337 </Published>
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

#Region "[On] |2019/06/25 22h51:967| <05.00.01> <Function> <> |.Close()|TestItem}|"' (Set|Get) This willClosing the connection
        '''    <Summary>
        '''     (Set|Get) This willClosing the connection
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:337 </Published>
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

#Region "[On] |2019/06/25 22h51:982| <05.00.02> <Function> <> |.List()|List(Of Factures_Entries)}|"' (Set|Get) Return the entire table listed
        '''    <Summary>
        '''     (Set|Get) Return the entire table listed
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:337 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Return the entire table listed")>
        Public Function List() As List(Of Factures_Entries)
            Dim Result As New List(Of Factures_Entries)
            Me.Table = New Table(Me.TableName, Me.FilePath, Me.Password, False)
            For Each Row As DataRow In Me.Table.DataTable.Rows
                Dim Element As New Factures_Entries(IIf(IsDBNull(Row.Item(0)), 0, Row.Item(0)),
IIf(IsDBNull(Row.Item(1)), "", Row.Item(1)),
IIf(IsDBNull(Row.Item(2)), False, Row.Item(2)),
IIf(IsDBNull(Row.Item(3)), New DateTime(1970, 1, 1), Row.Item(3)),
IIf(IsDBNull(Row.Item(4)), "", Row.Item(4)),
IIf(IsDBNull(Row.Item(5)), "", Row.Item(5)),
IIf(IsDBNull(Row.Item(6)), 0, Row.Item(6)),
IIf(IsDBNull(Row.Item(7)), "", Row.Item(7)),
IIf(IsDBNull(Row.Item(8)), False, Row.Item(8)),
IIf(IsDBNull(Row.Item(9)), 0, Row.Item(9)),
  IIf(IsDBNull(Row.Item(10)), 0, Row.Item(10)))
                Element.Reset(Table.Line)
                Result.Add(Element)
            Next
            Return Result
        End Function
#End Region '(Set|Get) Return the entire table listed

#Region "[On] |2019/06/25 22h51:998| <05.00.03> <Function> <> |.SearchByName()|List(Of Factures_Entries)}|"' (Set|Get) Search for each property that match the Search String.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search String.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:337 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Search for each property that match the Search String.")>
        Public Shared Function SearchByName(ByVal Search As String) As List(Of Factures_Entries)
            Dim Result As New List(Of Factures_Entries)
            Dim C As New Factures_Entries
            For Each Element As Factures_Entries In C.List
                If Element.Facture.ToLower() = Search.ToLower() Or Element.Collaborateur.ToLower() = Search.ToLower() Or Element.Mandat.ToLower() = Search.ToLower() Or Element.Description.ToLower() = Search.ToLower() Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search String.

#Region "[On] |2019/06/25 22h51:013| <05.00.04> <Function> <> |.SearchByID()|List(Of Factures_Entries)}|"' (Set|Get) Search for each property that match the Search Id.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search Id.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:338 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Search for each property that match the Search Id.")>
        Public Shared Function SearchByID(ByVal Search As Double) As List(Of Factures_Entries)
            Dim Result As New List(Of Factures_Entries)
            Dim C As New Factures_Entries
            For Each Element As Factures_Entries In C.List
                If Val(Element.ID) = Search Or Val(Element.UnitPrice) = Search Or Val(Element.TotalHTVA) = Search Or Val(Element.Quantity) = Search Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search Id.

#Region "[On] |2019/06/25 22h51:029| <05.00.05> <Function> <> |.ToString()|String}|"' (Set|Get) The function ToString.
        '''    <Summary>
        '''     (Set|Get) The function ToString.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:340 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The function ToString.")>
        Public Overrides Function ToString() As String
            Return Me.ID
        End Function
#End Region '(Set|Get) The function ToString.

#Region "[On] |2019/06/25 22h51:045| <05.00.06> <Function> <> |.CheckConnection()|Boolean}|"' (Set|Get) Evaluate the connection to the DataBase
        '''    <Summary>
        '''     (Set|Get) Evaluate the connection to the DataBase
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:340 </Published>
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
#Region "[On] |2019/06/25 22h51:059| <15.00.00> <Runtime> <> |.Table()|Table"' (Set|Get) The Table.
        '''    <Summary>
        '''     (Set|Get) The Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:340 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Table.")>
        Public Table As Table
#End Region '(Set|Get) The Table.

#Region "[On] |2019/06/25 22h51:100| <15.00.01> <Runtime> <> |.Line()|String"' (Set|Get) The Connection String To the Table.
        '''    <Summary>
        '''     (Set|Get) The Connection String To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:341 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Connection String To the Table.")>
        Public Line As String
#End Region '(Set|Get) The Connection String To the Table.

#Region "[On] |2019/06/25 22h51:132| <15.00.02> <Runtime> <> |.FilePath()|String"' (Set|Get) The FilePath To the Table.
        '''    <Summary>
        '''     (Set|Get) The FilePath To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:341 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The FilePath To the Table.")>
        Public FilePath As String
#End Region '(Set|Get) The FilePath To the Table.

#Region "[On] |2019/06/25 22h51:162| <15.00.03> <Runtime> <> |.Password()|String"' (Set|Get) The Password To the Table.
        '''    <Summary>
        '''     (Set|Get) The Password To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:344 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Password To the Table.")>
        Public Password As String
#End Region '(Set|Get) The Password To the Table.

#Region "[On] |2019/06/25 22h51:194| <15.00.04> <Runtime> <> |.UseSQL()|Boolean"' (Set|Get) Determines if the Database Connection is of type SQL.
        '''    <Summary>
        '''     (Set|Get) Determines if the Database Connection is of type SQL.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:345 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Determines if the Database Connection is of type SQL.")>
        Public UseSQL As Boolean
#End Region '(Set|Get) Determines if the Database Connection is of type SQL.

#Region "[On] |2019/06/25 22h51:226| <15.00.05> <Runtime> <> |.TableName()|String"' (Set|Get) The name of the Table.
        '''    <Summary>
        '''     (Set|Get) The name of the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:345 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The name of the Table.")>
        Public TableName As String
#End Region '(Set|Get) The name of the Table.

#Region "[On] |2019/06/25 22h51:257| <15.00.06> <Runtime> <> |.Con()|OleDb.OleDbConnection"' (Set|Get) The Con To the Table.
        '''    <Summary>
        '''     (Set|Get) The Con To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:345 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Con To the Table.")>
        Public Con As OleDb.OleDbConnection
#End Region '(Set|Get) The Con To the Table.

#Region "[On] |2019/06/25 22h51:301| <15.00.07> <Runtime> <> |.Cmd()|OleDb.OleDbCommand"' (Set|Get) The Cmd To the Table.
        '''    <Summary>
        '''     (Set|Get) The Cmd To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:345 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Cmd To the Table.")>
        Public Cmd As OleDb.OleDbCommand
#End Region '(Set|Get) The Cmd To the Table.

#Region "[On] |2019/06/25 22h51:330| <15.00.08> <Runtime> <> |.DataReader()|OleDb.OleDbDataReader"' (Set|Get) The DataReader To the Table.
        '''    <Summary>
        '''     (Set|Get) The DataReader To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:345 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The DataReader To the Table.")>
        Public DataReader As OleDb.OleDbDataReader
#End Region '(Set|Get) The DataReader To the Table.

#Region "[On] |2019/06/25 22h51:363| <15.00.09> <Runtime> <> |.DataAdapter()|OleDb.OleDbDataAdapter"' (Set|Get) The DataAdapter To the Table.
        '''    <Summary>
        '''     (Set|Get) The DataAdapter To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:346 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The DataAdapter To the Table.")>
        Public DataAdapter As OleDb.OleDbDataAdapter
#End Region '(Set|Get) The DataAdapter To the Table.

#Region "[On] |2019/06/25 22h51:395| <15.00.10> <Runtime> <> |.Connector()|LineInfo"' (Set|Get) The Connector To the Table.
        '''    <Summary>
        '''     (Set|Get) The Connector To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:346 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Connector To the Table.")>
        Public Connector As LineInfo
#End Region '(Set|Get) The Connector To the Table.

#Region "[On] |2019/06/25 22h51:426| <15.00.11> <Runtime> <> |.Log()|String"' (Set|Get) The Log To the Table.
        '''    <Summary>
        '''     (Set|Get) The Log To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:346 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Log To the Table.")>
        Public Log As String
#End Region '(Set|Get) The Log To the Table.

#End Region
#Region "<7> [Loader]{2}"
#Region "[On] |2019/06/25 22h51:460| <06.00.00> <Loader> <> |.Empty()|Function}|"' (Set|Get) The sub Empty.
        '''    <Summary>
        '''     (Set|Get) The sub Empty.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:346 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The sub Empty.")>
        Public Sub New()
            Reset
        End Sub
#End Region '(Set|Get) The sub Empty.

#Region "[On] |2019/06/25 22h51:461| <06.00.01> <Loader> <> |.Filled()|Function}|"' (Set|Get) The sub Filled.
        '''    <Summary>
        '''     (Set|Get) The sub Filled.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:347 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>    ''' <param name="ID">(Set|Get) The ID as Integer.</param>
        ''' <param name="Facture">(Set|Get) The Facture as String.</param>
        ''' <param name="Active">(Set|Get) The Active as Boolean.</param>
        ''' <param name="DateEntry">(Set|Get) The DateEntry as DateTime.</param>
        ''' <param name="Collaborateur">(Set|Get) The Collaborateur as String.</param>
        ''' <param name="Mandat">(Set|Get) The Mandat as String.</param>
        ''' <param name="UnitPrice">(Set|Get) The UnitPrice as Double.</param>
        ''' <param name="Description">(Set|Get) The Description as String.</param>
        ''' <param name="Facturable">(Set|Get) The Facturable as Boolean.</param>
        ''' <param name="TotalHTVA">(Set|Get) The TotalHTVA as Double.</param>
        ''' <param name="Quantity">(Set|Get) The Quantity as Double.</param>

        <Browsable(True), Description("(Set|Get) The sub Filled.")>
        Public Sub New(ByVal ID As Integer,
ByVal Facture As String,
ByVal Active As Boolean,
ByVal DateEntry As DateTime,
ByVal Collaborateur As String,
ByVal Mandat As String,
ByVal UnitPrice As Double,
ByVal Description As String,
ByVal Facturable As Boolean,
ByVal TotalHTVA As Double,
ByVal Quantity As Double)
            With Me
                Clear()
                Reset()
                .ID = ID
                .Facture = Facture
                .Active = Active
                .DateEntry = DateEntry
                .Collaborateur = Collaborateur
                .Mandat = Mandat
                .UnitPrice = UnitPrice
                .Description = Description
                .Facturable = Facturable
                .TotalHTVA = TotalHTVA
                .Quantity = Quantity
            End With

        End Sub
#End Region '(Set|Get) The sub Filled.

#End Region
    End Class
#End Region
#Region "[On] |2019/06/25 22h51:617| <08.00.00> <Class> <> |.Prestation_Category|Class|{28} |Production Cost : 28.3|Selling Price : 42.45|"' Class created automatically by SmartOffice (c)Copyright 2019.
    '''    <Summary>
    '''     Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Prestation_Category
    '''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
    '''    Contributor Information : ||
    '''    Creation Date :           2019/06/25 22h51:617
    '''    |Schema|
    '''    |ID| |ObjectType |{Quantity}||UnitPrice||Total
    '''    |00| |Importation|{0}||1| |0
    '''    |01| |Properties |{1}||0.8| |0.8
    '''    |02| |Enumeration|{1}||0.4| |0.4
    '''    |03| |Structure  |{0}||0.4| |0
    '''    |04| |Sub        |{5}||1.2| |6
    '''    |05| |Function   |{7}||1.6| |11.2
    '''    |06| |Runtime    |{12}||0.4| |4.8
    '''    |07| |Loader     |{2}||0.8| |1.6
    '''    |08| |Class      |{0}||2| |0
    '''    |09| |Constante  |{0}||0.4| |0
    '''    |10| |Event      |{0}||1.2| |0
    '''    |11| |Members    |{1}||0.5| |0.5
    '''    |12| |Parameter  |{6}||0.5| |3
    '''    |Production Cost             |28.3
    '''    |Selling Price without VAT   |42.45
    '''    |Total TVA                   |3.27
    '''    |Grand Total                 |45.72
    '''    |/Schema|
    '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
    '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
    '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
    '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:362 </Published>
    '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
    '''    </Summary>
    Public Class Prestation_Category
#Region "<1> [Property]{1}"
#Region "[On] |2019/06/25 22h51:623| <01.00.00> <Property> <Columns> |.Ref()|String|"' (Set|Get) The Ref as String.
        Private _Ref As String
        '''    <Summary>
        '''     (Set|Get) The Ref as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:362 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Ref as String.")>
        Public Property Ref() As String
            Get
                Return _Ref
            End Get
            Set(ByVal Value As String)
                _Ref = Value
            End Set
        End Property
#End Region '(Set|Get) The Ref as String.

#End Region
#Region "<2> [Enumeration]{1}"
#Region "[On] |2019/06/25 22h51:636| <02.00.00> <Enumeration> <> |.Schema()|Enumeration{0}|"' (Set|Get) The enumeration of Schema.
        '''    <Summary>
        '''     (Set|Get) The enumeration of Schema.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:362 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The enumeration of Schema.")>
        Enum Schema
            ''' <summary>(Set|Get) The Ref as String.</summary>
            [Ref] = 0
        End Enum
#End Region '(Set|Get) The enumeration of Schema.

#End Region
#Region "<4> [Sub]{5}"
#Region "[On] |2019/06/25 22h51:647| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
        '''    <Summary>
        '''     (Set|Get) This will reinitialize the class element.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:363 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will reinitialize the class element.")>
        Public Sub Clear()
            With Me
                .Ref = Nothing
            End With
        End Sub
#End Region '(Set|Get) This will reinitialize the class element.

#Region "[On] |2019/06/25 22h51:659| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
        '''    <Summary>
        '''     (Set|Get) This will reinitialize the variables of this class.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:363 </Published>
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
                    TableName = "Prestation_Category"
                    Line = Connector.Line
                    UseSQL = False
                Else
                    FilePath = My.Settings.Db_TimeSheet_FilePath
                    Password = My.Settings.Db_TimeSheet_Password
                    Me.Line = My.Settings.Db_TimeSheet_Line
                    TableName = "Prestation_Category"
                    UseSQL = False
                End If
            Else
                If IsNothing(FilePath) Then
                    FilePath = My.Settings.Db_TimeSheet_FilePath
                End If
                If FilePath.Length < 1 Then
                    FilePath = My.Settings.Db_TimeSheet_FilePath
                End If
                FilePath = My.Settings.Db_TimeSheet_FilePath
                Password = My.Settings.Db_TimeSheet_Password
                Me.Line = My.Settings.Db_TimeSheet_Line
                TableName = "Prestation_Category"
                UseSQL = False
            End If

        End Sub
#End Region '(Set|Get) This will reinitialize the variables of this class.

#Region "[On] |2019/06/25 23h39:275| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
        '''    <Summary>
        '''     (Set|Get) This will add a new row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 23h39:116 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will add a new row in the table.")>
        Public Sub Add()
            Try
                Dim Str As String = Nothing
                Str = "Insert Into [Prestation_Category] (
`Ref`) Values (@0)"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@0", Me.Ref)
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
#Region "[On] |2019/06/25 22h51:684| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
        '''    <Summary>
        '''     (Set|Get) This will update a row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:363 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will update a row in the table.")>
        Public Sub Save()
            Try
                Dim Str As String = Nothing
                Str = "UPDATE [Prestation_Category] SET Ref = @Ref WHERE Ref = @Ref"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@Ref", Ref)
                Cmd.Parameters.AddWithValue("@Ref", Ref)
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

#Region "[On] |2019/06/25 22h51:696| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
        '''    <Summary>
        '''     (Set|Get) This will Delete a row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:363 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will Delete a row in the table.")>
        Public Sub Delete()
            Try
                Dim Str As String = Nothing
                Str = "Delete From [Prestation_Category] WHERE Ref =@Ref"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@Ref", Ref)
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
#Region "[On] |2019/06/25 22h51:708| <05.00.00> <Function> <> |.Open()|TestItem}|"' (Set|Get) This will initialise the connection and import the data.
        '''    <Summary>
        '''     (Set|Get) This will initialise the connection and import the data.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:366 </Published>
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

#Region "[On] |2019/06/25 22h51:721| <05.00.01> <Function> <> |.Close()|TestItem}|"' (Set|Get) This willClosing the connection
        '''    <Summary>
        '''     (Set|Get) This willClosing the connection
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:366 </Published>
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

#Region "[On] |2019/06/25 22h51:736| <05.00.02> <Function> <> |.List()|List(Of Prestation_Category)}|"' (Set|Get) Return the entire table listed
        '''    <Summary>
        '''     (Set|Get) Return the entire table listed
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:366 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Return the entire table listed")>
        Public Function List() As List(Of Prestation_Category)
            Dim Result As New List(Of Prestation_Category)
            Me.Table = New Table(Me.TableName, Me.FilePath, Me.Password, False)
            For Each Row As DataRow In Me.Table.DataTable.Rows
                Dim Element As New Prestation_Category(IIf(IsDBNull(Row.Item(0)), "", Row.Item(0)))
                Element.Reset(Table.Line)
                Result.Add(Element)
            Next
            Return Result
        End Function
#End Region '(Set|Get) Return the entire table listed

#Region "[On] |2019/06/25 22h51:749| <05.00.03> <Function> <> |.SearchByName()|List(Of Prestation_Category)}|"' (Set|Get) Search for each property that match the Search String.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search String.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:366 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Search for each property that match the Search String.")>
        Public Shared Function SearchByName(ByVal Search As String) As List(Of Prestation_Category)
            Dim Result As New List(Of Prestation_Category)
            Dim C As New Prestation_Category
            For Each Element As Prestation_Category In C.List
                If Element.Ref.ToLower() = Search.ToLower() Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search String.

#Region "[On] |2019/06/25 22h51:765| <05.00.04> <Function> <> |.SearchByID()|List(Of Prestation_Category)}|"' (Set|Get) Search for each property that match the Search Id.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search Id.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:366 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Search for each property that match the Search Id.")>
        Public Shared Function SearchByID(ByVal Search As Double) As List(Of Prestation_Category)
            Dim Result As New List(Of Prestation_Category)
            Dim C As New Prestation_Category
            For Each Element As Prestation_Category In C.List
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search Id.

#Region "[On] |2019/06/25 22h51:779| <05.00.05> <Function> <> |.ToString()|String}|"' (Set|Get) The function ToString.
        '''    <Summary>
        '''     (Set|Get) The function ToString.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:367 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The function ToString.")>
        Public Overrides Function ToString() As String
            Return Me.Ref
        End Function
#End Region '(Set|Get) The function ToString.

#Region "[On] |2019/06/25 22h51:794| <05.00.06> <Function> <> |.CheckConnection()|Boolean}|"' (Set|Get) Evaluate the connection to the DataBase
        '''    <Summary>
        '''     (Set|Get) Evaluate the connection to the DataBase
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:367 </Published>
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
#Region "[On] |2019/06/25 22h51:810| <15.00.00> <Runtime> <> |.Table()|Table"' (Set|Get) The Table.
        '''    <Summary>
        '''     (Set|Get) The Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:367 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Table.")>
        Public Table As Table
#End Region '(Set|Get) The Table.

#Region "[On] |2019/06/25 22h51:839| <15.00.01> <Runtime> <> |.Line()|String"' (Set|Get) The Connection String To the Table.
        '''    <Summary>
        '''     (Set|Get) The Connection String To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:367 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Connection String To the Table.")>
        Public Line As String
#End Region '(Set|Get) The Connection String To the Table.

#Region "[On] |2019/06/25 22h51:875| <15.00.02> <Runtime> <> |.FilePath()|String"' (Set|Get) The FilePath To the Table.
        '''    <Summary>
        '''     (Set|Get) The FilePath To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:368 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The FilePath To the Table.")>
        Public FilePath As String
#End Region '(Set|Get) The FilePath To the Table.

#Region "[On] |2019/06/25 22h51:907| <15.00.03> <Runtime> <> |.Password()|String"' (Set|Get) The Password To the Table.
        '''    <Summary>
        '''     (Set|Get) The Password To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:368 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Password To the Table.")>
        Public Password As String
#End Region '(Set|Get) The Password To the Table.

#Region "[On] |2019/06/25 22h51:938| <15.00.04> <Runtime> <> |.UseSQL()|Boolean"' (Set|Get) Determines if the Database Connection is of type SQL.
        '''    <Summary>
        '''     (Set|Get) Determines if the Database Connection is of type SQL.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:368 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Determines if the Database Connection is of type SQL.")>
        Public UseSQL As Boolean
#End Region '(Set|Get) Determines if the Database Connection is of type SQL.

#Region "[On] |2019/06/25 22h51:971| <15.00.05> <Runtime> <> |.TableName()|String"' (Set|Get) The name of the Table.
        '''    <Summary>
        '''     (Set|Get) The name of the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:371 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The name of the Table.")>
        Public TableName As String
#End Region '(Set|Get) The name of the Table.

#Region "[On] |2019/06/25 22h51:004| <15.00.06> <Runtime> <> |.Con()|OleDb.OleDbConnection"' (Set|Get) The Con To the Table.
        '''    <Summary>
        '''     (Set|Get) The Con To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:371 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Con To the Table.")>
        Public Con As OleDb.OleDbConnection
#End Region '(Set|Get) The Con To the Table.

#Region "[On] |2019/06/25 22h51:044| <15.00.07> <Runtime> <> |.Cmd()|OleDb.OleDbCommand"' (Set|Get) The Cmd To the Table.
        '''    <Summary>
        '''     (Set|Get) The Cmd To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:371 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Cmd To the Table.")>
        Public Cmd As OleDb.OleDbCommand
#End Region '(Set|Get) The Cmd To the Table.

#Region "[On] |2019/06/25 22h51:096| <15.00.08> <Runtime> <> |.DataReader()|OleDb.OleDbDataReader"' (Set|Get) The DataReader To the Table.
        '''    <Summary>
        '''     (Set|Get) The DataReader To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:375 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The DataReader To the Table.")>
        Public DataReader As OleDb.OleDbDataReader
#End Region '(Set|Get) The DataReader To the Table.

#Region "[On] |2019/06/25 22h51:127| <15.00.09> <Runtime> <> |.DataAdapter()|OleDb.OleDbDataAdapter"' (Set|Get) The DataAdapter To the Table.
        '''    <Summary>
        '''     (Set|Get) The DataAdapter To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:375 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The DataAdapter To the Table.")>
        Public DataAdapter As OleDb.OleDbDataAdapter
#End Region '(Set|Get) The DataAdapter To the Table.

#Region "[On] |2019/06/25 22h51:158| <15.00.10> <Runtime> <> |.Connector()|LineInfo"' (Set|Get) The Connector To the Table.
        '''    <Summary>
        '''     (Set|Get) The Connector To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:376 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Connector To the Table.")>
        Public Connector As LineInfo
#End Region '(Set|Get) The Connector To the Table.

#Region "[On] |2019/06/25 22h51:193| <15.00.11> <Runtime> <> |.Log()|String"' (Set|Get) The Log To the Table.
        '''    <Summary>
        '''     (Set|Get) The Log To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:376 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Log To the Table.")>
        Public Log As String
#End Region '(Set|Get) The Log To the Table.

#End Region
#Region "<7> [Loader]{2}"
#Region "[On] |2019/06/25 22h51:223| <06.00.00> <Loader> <> |.Empty()|Function}|"' (Set|Get) The sub Empty.
        '''    <Summary>
        '''     (Set|Get) The sub Empty.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:376 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The sub Empty.")>
        Public Sub New()
            Reset
        End Sub
#End Region '(Set|Get) The sub Empty.

#Region "[On] |2019/06/25 22h51:224| <06.00.01> <Loader> <> |.Filled()|Function}|"' (Set|Get) The sub Filled.
        '''    <Summary>
        '''     (Set|Get) The sub Filled.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:376 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The sub Filled.")>
        Public Sub New(ByVal Ref As String)
            With Me
                Clear()
                Reset()
                .Ref = Ref
            End With

        End Sub
#End Region '(Set|Get) The sub Filled.

#End Region
    End Class
#End Region
#Region "[On] |2019/06/25 22h51:359| <08.00.00> <Class> <> |.Prestations|Class|{31} |Production Cost : 33.7|Selling Price : 50.55|"' Class created automatically by SmartOffice (c)Copyright 2019.
    '''    <Summary>
    '''     Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Prestations
    '''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
    '''    Contributor Information : ||
    '''    Creation Date :           2019/06/25 22h51:359
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
    '''    |Selling Price without VAT   |50.55
    '''    |Total TVA                   |3.89
    '''    |Grand Total                 |54.44
    '''    |/Schema|
    '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
    '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
    '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
    '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:385 </Published>
    '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
    '''    </Summary>
    Public Class Prestations
#Region "<1> [Property]{4}"
#Region "[On] |2019/06/25 22h51:360| <01.00.00> <Property> <Columns> |.ID()|Integer|"' (Set|Get) The ID as Integer.
        Private _ID As Integer
        '''    <Summary>
        '''     (Set|Get) The ID as Integer.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:385 </Published>
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

#Region "[On] |2019/06/25 22h51:372| <01.00.01> <Property> <Columns> |.Description()|String|"' (Set|Get) The Description as String.
        Private _Description As String
        '''    <Summary>
        '''     (Set|Get) The Description as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:386 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Description as String.")>
        Public Property Description() As String
            Get
                Return _Description
            End Get
            Set(ByVal Value As String)
                _Description = Value
            End Set
        End Property
#End Region '(Set|Get) The Description as String.

#Region "[On] |2019/06/25 22h51:383| <01.00.02> <Property> <Columns> |.Service()|String|"' (Set|Get) The Service as String.
        Private _Service As String
        '''    <Summary>
        '''     (Set|Get) The Service as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:386 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Service as String.")>
        Public Property Service() As String
            Get
                Return _Service
            End Get
            Set(ByVal Value As String)
                _Service = Value
            End Set
        End Property
#End Region '(Set|Get) The Service as String.

#Region "[On] |2019/06/25 22h51:396| <01.00.03> <Property> <Columns> |.Type()|String|"' (Set|Get) The Type as String.
        Private _Type As String
        '''    <Summary>
        '''     (Set|Get) The Type as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:386 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Type as String.")>
        Public Property Type() As String
            Get
                Return _Type
            End Get
            Set(ByVal Value As String)
                _Type = Value
            End Set
        End Property
#End Region '(Set|Get) The Type as String.

#End Region
#Region "<2> [Enumeration]{1}"
#Region "[On] |2019/06/25 22h51:408| <02.00.00> <Enumeration> <> |.Schema()|Enumeration{3}|"' (Set|Get) The enumeration of Schema.
        '''    <Summary>
        '''     (Set|Get) The enumeration of Schema.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:386 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The enumeration of Schema.")>
        Enum Schema
            ''' <summary>(Set|Get) The ID as Integer.</summary>
            [ID] = 0
            ''' <summary>(Set|Get) The Description as String.</summary>
            [Description] = 1
            ''' <summary>(Set|Get) The Service as String.</summary>
            [Service] = 2
            ''' <summary>(Set|Get) The Type as String.</summary>
            [Type] = 3
        End Enum
#End Region '(Set|Get) The enumeration of Schema.

#End Region
#Region "<4> [Sub]{5}"
#Region "[On] |2019/06/25 22h51:420| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
        '''    <Summary>
        '''     (Set|Get) This will reinitialize the class element.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:387 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will reinitialize the class element.")>
        Public Sub Clear()
            With Me
                .ID = 0
                .Description = Nothing
                .Service = Nothing
                .Type = Nothing
            End With
        End Sub
#End Region '(Set|Get) This will reinitialize the class element.

#Region "[On] |2019/06/25 22h51:436| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
        '''    <Summary>
        '''     (Set|Get) This will reinitialize the variables of this class.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:387 </Published>
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
                    TableName = "Prestations"
                    Line = Connector.Line
                    UseSQL = False
                Else
                    FilePath = My.Settings.Db_TimeSheet_FilePath
                    Password = My.Settings.Db_TimeSheet_Password
                    Me.Line = My.Settings.Db_TimeSheet_Line
                    TableName = "Prestations"
                    UseSQL = False
                End If
            Else
                If IsNothing(FilePath) Then
                    FilePath = My.Settings.Db_TimeSheet_FilePath
                End If
                If FilePath.Length < 1 Then
                    FilePath = My.Settings.Db_TimeSheet_FilePath
                End If
                FilePath = My.Settings.Db_TimeSheet_FilePath
                Password = My.Settings.Db_TimeSheet_Password
                Me.Line = My.Settings.Db_TimeSheet_Line
                TableName = "Prestations"
                UseSQL = False
            End If

        End Sub
#End Region '(Set|Get) This will reinitialize the variables of this class.

#Region "[On] |2019/06/25 23h39:044| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
        '''    <Summary>
        '''     (Set|Get) This will add a new row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 23h39:131 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will add a new row in the table.")>
        Public Sub Add()
            Try
                Dim Str As String = Nothing
                Str = "Insert Into [Prestations] (
`ID`, 
`Description`, 
`Service`, 
`Type`) Values (@0, @1, @2, @3)"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@0", Me.ID)
                Cmd.Parameters.AddWithValue("@1", Me.Description)
                Cmd.Parameters.AddWithValue("@2", Me.Service)
                Cmd.Parameters.AddWithValue("@3", Me.Type)
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

#Region "[On] |2019/06/25 22h51:469| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
        '''    <Summary>
        '''     (Set|Get) This will update a row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:390 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will update a row in the table.")>
        Public Sub Save()
            Try
                Dim Str As String = Nothing
                Str = "UPDATE [Prestations] SET Description = @Description, Service = @Service, Type = @Type WHERE ID = @ID"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@Description", Description)
                Cmd.Parameters.AddWithValue("@Service", Service)
                Cmd.Parameters.AddWithValue("@Type", Type)
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

#Region "[On] |2019/06/25 22h51:484| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
        '''    <Summary>
        '''     (Set|Get) This will Delete a row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:390 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will Delete a row in the table.")>
        Public Sub Delete()
            Try
                Dim Str As String = Nothing
                Str = "Delete From [Prestations] WHERE ID =@ID"
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
#Region "[On] |2019/06/25 22h51:501| <05.00.00> <Function> <> |.Open()|TestItem}|"' (Set|Get) This will initialise the connection and import the data.
        '''    <Summary>
        '''     (Set|Get) This will initialise the connection and import the data.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:390 </Published>
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

#Region "[On] |2019/06/25 22h51:513| <05.00.01> <Function> <> |.Close()|TestItem}|"' (Set|Get) This willClosing the connection
        '''    <Summary>
        '''     (Set|Get) This willClosing the connection
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:390 </Published>
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

#Region "[On] |2019/06/25 22h51:527| <05.00.02> <Function> <> |.List()|List(Of Prestations)}|"' (Set|Get) Return the entire table listed
        '''    <Summary>
        '''     (Set|Get) Return the entire table listed
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:390 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Return the entire table listed")>
        Public Function List() As List(Of Prestations)
            Dim Result As New List(Of Prestations)
            Me.Table = New Table(Me.TableName, Me.FilePath, Me.Password, False)
            For Each Row As DataRow In Me.Table.DataTable.Rows
                Dim Element As New Prestations(IIf(IsDBNull(Row.Item(0)), 0, Row.Item(0)),
IIf(IsDBNull(Row.Item(1)), "", Row.Item(1)),
IIf(IsDBNull(Row.Item(2)), "", Row.Item(2)),
  IIf(IsDBNull(Row.Item(3)), "", Row.Item(3)))
                Element.Reset(Table.Line)
                Result.Add(Element)
            Next
            Return Result
        End Function
#End Region '(Set|Get) Return the entire table listed

#Region "[On] |2019/06/25 22h51:539| <05.00.03> <Function> <> |.SearchByName()|List(Of Prestations)}|"' (Set|Get) Search for each property that match the Search String.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search String.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:390 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Search for each property that match the Search String.")>
        Public Shared Function SearchByName(ByVal Search As String) As List(Of Prestations)
            Dim Result As New List(Of Prestations)
            Dim C As New Prestations
            For Each Element As Prestations In C.List
                If Element.Description.ToLower() = Search.ToLower() Or Element.Service.ToLower() = Search.ToLower() Or Element.Type.ToLower() = Search.ToLower() Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search String.

#Region "[On] |2019/06/25 22h51:552| <05.00.04> <Function> <> |.SearchByID()|List(Of Prestations)}|"' (Set|Get) Search for each property that match the Search Id.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search Id.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:391 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Search for each property that match the Search Id.")>
        Public Shared Function SearchByID(ByVal Search As Double) As List(Of Prestations)
            Dim Result As New List(Of Prestations)
            Dim C As New Prestations
            For Each Element As Prestations In C.List
                If Val(Element.Description) = Search Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search Id.

#Region "[On] |2019/06/25 22h51:565| <05.00.05> <Function> <> |.ToString()|String}|"' (Set|Get) The function ToString.
        '''    <Summary>
        '''     (Set|Get) The function ToString.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:391 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The function ToString.")>
        Public Overrides Function ToString() As String
            Return Me.Description
        End Function
#End Region '(Set|Get) The function ToString.

#Region "[On] |2019/06/25 22h51:580| <05.00.06> <Function> <> |.CheckConnection()|Boolean}|"' (Set|Get) Evaluate the connection to the DataBase
        '''    <Summary>
        '''     (Set|Get) Evaluate the connection to the DataBase
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:391 </Published>
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
#Region "[On] |2019/06/25 22h51:595| <15.00.00> <Runtime> <> |.Table()|Table"' (Set|Get) The Table.
        '''    <Summary>
        '''     (Set|Get) The Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:393 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Table.")>
        Public Table As Table
#End Region '(Set|Get) The Table.

#Region "[On] |2019/06/25 22h51:629| <15.00.01> <Runtime> <> |.Line()|String"' (Set|Get) The Connection String To the Table.
        '''    <Summary>
        '''     (Set|Get) The Connection String To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:393 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Connection String To the Table.")>
        Public Line As String
#End Region '(Set|Get) The Connection String To the Table.

#Region "[On] |2019/06/25 22h51:662| <15.00.02> <Runtime> <> |.FilePath()|String"' (Set|Get) The FilePath To the Table.
        '''    <Summary>
        '''     (Set|Get) The FilePath To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:394 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The FilePath To the Table.")>
        Public FilePath As String
#End Region '(Set|Get) The FilePath To the Table.

#Region "[On] |2019/06/25 22h51:693| <15.00.03> <Runtime> <> |.Password()|String"' (Set|Get) The Password To the Table.
        '''    <Summary>
        '''     (Set|Get) The Password To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:394 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Password To the Table.")>
        Public Password As String
#End Region '(Set|Get) The Password To the Table.

#Region "[On] |2019/06/25 22h51:724| <15.00.04> <Runtime> <> |.UseSQL()|Boolean"' (Set|Get) Determines if the Database Connection is of type SQL.
        '''    <Summary>
        '''     (Set|Get) Determines if the Database Connection is of type SQL.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:394 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Determines if the Database Connection is of type SQL.")>
        Public UseSQL As Boolean
#End Region '(Set|Get) Determines if the Database Connection is of type SQL.

#Region "[On] |2019/06/25 22h51:761| <15.00.05> <Runtime> <> |.TableName()|String"' (Set|Get) The name of the Table.
        '''    <Summary>
        '''     (Set|Get) The name of the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:394 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The name of the Table.")>
        Public TableName As String
#End Region '(Set|Get) The name of the Table.

#Region "[On] |2019/06/25 22h51:791| <15.00.06> <Runtime> <> |.Con()|OleDb.OleDbConnection"' (Set|Get) The Con To the Table.
        '''    <Summary>
        '''     (Set|Get) The Con To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:394 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Con To the Table.")>
        Public Con As OleDb.OleDbConnection
#End Region '(Set|Get) The Con To the Table.

#Region "[On] |2019/06/25 22h51:828| <15.00.07> <Runtime> <> |.Cmd()|OleDb.OleDbCommand"' (Set|Get) The Cmd To the Table.
        '''    <Summary>
        '''     (Set|Get) The Cmd To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:394 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Cmd To the Table.")>
        Public Cmd As OleDb.OleDbCommand
#End Region '(Set|Get) The Cmd To the Table.

#Region "[On] |2019/06/25 22h51:859| <15.00.08> <Runtime> <> |.DataReader()|OleDb.OleDbDataReader"' (Set|Get) The DataReader To the Table.
        '''    <Summary>
        '''     (Set|Get) The DataReader To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:394 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The DataReader To the Table.")>
        Public DataReader As OleDb.OleDbDataReader
#End Region '(Set|Get) The DataReader To the Table.

#Region "[On] |2019/06/25 22h51:889| <15.00.09> <Runtime> <> |.DataAdapter()|OleDb.OleDbDataAdapter"' (Set|Get) The DataAdapter To the Table.
        '''    <Summary>
        '''     (Set|Get) The DataAdapter To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:394 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The DataAdapter To the Table.")>
        Public DataAdapter As OleDb.OleDbDataAdapter
#End Region '(Set|Get) The DataAdapter To the Table.

#Region "[On] |2019/06/25 22h51:920| <15.00.10> <Runtime> <> |.Connector()|LineInfo"' (Set|Get) The Connector To the Table.
        '''    <Summary>
        '''     (Set|Get) The Connector To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:395 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Connector To the Table.")>
        Public Connector As LineInfo
#End Region '(Set|Get) The Connector To the Table.

#Region "[On] |2019/06/25 22h51:951| <15.00.11> <Runtime> <> |.Log()|String"' (Set|Get) The Log To the Table.
        '''    <Summary>
        '''     (Set|Get) The Log To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:395 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Log To the Table.")>
        Public Log As String
#End Region '(Set|Get) The Log To the Table.

#End Region
#Region "<7> [Loader]{2}"
#Region "[On] |2019/06/25 22h51:984| <06.00.00> <Loader> <> |.Empty()|Function}|"' (Set|Get) The sub Empty.
        '''    <Summary>
        '''     (Set|Get) The sub Empty.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:395 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The sub Empty.")>
        Public Sub New()
            Reset
        End Sub
#End Region '(Set|Get) The sub Empty.

#Region "[On] |2019/06/25 22h51:986| <06.00.01> <Loader> <> |.Filled()|Function}|"' (Set|Get) The sub Filled.
        '''    <Summary>
        '''     (Set|Get) The sub Filled.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:395 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>    ''' <param name="ID">(Set|Get) The ID as Integer.</param>
        ''' <param name="Description">(Set|Get) The Description as String.</param>
        ''' <param name="Service">(Set|Get) The Service as String.</param>
        ''' <param name="Type">(Set|Get) The Type as String.</param>

        <Browsable(True), Description("(Set|Get) The sub Filled.")>
        Public Sub New(ByVal ID As Integer,
ByVal Description As String,
ByVal Service As String,
ByVal Type As String)
            With Me
                Clear()
                Reset()
                .ID = ID
                .Description = Description
                .Service = Service
                .Type = Type
            End With

        End Sub
#End Region '(Set|Get) The sub Filled.

#End Region
    End Class
#End Region
#Region "[On] |2019/06/25 22h51:139| <08.00.00> <Class> <> |.Services|Class|{28} |Production Cost : 28.3|Selling Price : 42.45|"' Class created automatically by SmartOffice (c)Copyright 2019.
    '''    <Summary>
    '''     Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Services
    '''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
    '''    Contributor Information : ||
    '''    Creation Date :           2019/06/25 22h51:139
    '''    |Schema|
    '''    |ID| |ObjectType |{Quantity}||UnitPrice||Total
    '''    |00| |Importation|{0}||1| |0
    '''    |01| |Properties |{1}||0.8| |0.8
    '''    |02| |Enumeration|{1}||0.4| |0.4
    '''    |03| |Structure  |{0}||0.4| |0
    '''    |04| |Sub        |{5}||1.2| |6
    '''    |05| |Function   |{7}||1.6| |11.2
    '''    |06| |Runtime    |{12}||0.4| |4.8
    '''    |07| |Loader     |{2}||0.8| |1.6
    '''    |08| |Class      |{0}||2| |0
    '''    |09| |Constante  |{0}||0.4| |0
    '''    |10| |Event      |{0}||1.2| |0
    '''    |11| |Members    |{1}||0.5| |0.5
    '''    |12| |Parameter  |{6}||0.5| |3
    '''    |Production Cost             |28.3
    '''    |Selling Price without VAT   |42.45
    '''    |Total TVA                   |3.27
    '''    |Grand Total                 |45.72
    '''    |/Schema|
    '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
    '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
    '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
    '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:398 </Published>
    '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
    '''    </Summary>
    Public Class Services
#Region "<1> [Property]{1}"
#Region "[On] |2019/06/25 22h51:140| <01.00.00> <Property> <Columns> |.Service()|String|"' (Set|Get) The Service as String.
        Private _Service As String
        '''    <Summary>
        '''     (Set|Get) The Service as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:399 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Service as String.")>
        Public Property Service() As String
            Get
                Return _Service
            End Get
            Set(ByVal Value As String)
                _Service = Value
            End Set
        End Property
#End Region '(Set|Get) The Service as String.

#End Region
#Region "<2> [Enumeration]{1}"
#Region "[On] |2019/06/25 22h51:150| <02.00.00> <Enumeration> <> |.Schema()|Enumeration{0}|"' (Set|Get) The enumeration of Schema.
        '''    <Summary>
        '''     (Set|Get) The enumeration of Schema.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:400 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The enumeration of Schema.")>
        Enum Schema
            ''' <summary>(Set|Get) The Service as String.</summary>
            [Service] = 0
        End Enum
#End Region '(Set|Get) The enumeration of Schema.

#End Region
#Region "<4> [Sub]{5}"
#Region "[On] |2019/06/25 22h51:163| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
        '''    <Summary>
        '''     (Set|Get) This will reinitialize the class element.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:400 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will reinitialize the class element.")>
        Public Sub Clear()
            With Me
                .Service = Nothing
            End With
        End Sub
#End Region '(Set|Get) This will reinitialize the class element.

#Region "[On] |2019/06/25 22h51:175| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
        '''    <Summary>
        '''     (Set|Get) This will reinitialize the variables of this class.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:400 </Published>
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
                    TableName = "Services"
                    Line = Connector.Line
                    UseSQL = False
                Else
                    FilePath = My.Settings.Db_TimeSheet_FilePath
                    Password = My.Settings.Db_TimeSheet_Password
                    Me.Line = My.Settings.Db_TimeSheet_Line
                    TableName = "Services"
                    UseSQL = False
                End If
            Else
                If IsNothing(FilePath) Then
                    FilePath = My.Settings.Db_TimeSheet_FilePath
                End If
                If FilePath.Length < 1 Then
                    FilePath = My.Settings.Db_TimeSheet_FilePath
                End If
                FilePath = My.Settings.Db_TimeSheet_FilePath
                Password = My.Settings.Db_TimeSheet_Password
                Me.Line = My.Settings.Db_TimeSheet_Line
                TableName = "Services"
                UseSQL = False
            End If

        End Sub
#End Region '(Set|Get) This will reinitialize the variables of this class.

#Region "[On] |2019/06/25 23h39:826| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
        '''    <Summary>
        '''     (Set|Get) This will add a new row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 23h39:142 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will add a new row in the table.")>
        Public Sub Add()
            Try
                Dim Str As String = Nothing
                Str = "Insert Into [Services] (
`Service`) Values (@0)"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@0", Me.Service)
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


#Region "[On] |2019/06/25 22h51:207| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
        '''    <Summary>
        '''     (Set|Get) This will update a row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:400 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will update a row in the table.")>
        Public Sub Save()
            Try
                Dim Str As String = Nothing
                Str = "UPDATE [Services] SET Service = @Service WHERE Service = @Service"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@Service", Service)
                Cmd.Parameters.AddWithValue("@Service", Service)
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

#Region "[On] |2019/06/25 22h51:219| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
        '''    <Summary>
        '''     (Set|Get) This will Delete a row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:400 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will Delete a row in the table.")>
        Public Sub Delete()
            Try
                Dim Str As String = Nothing
                Str = "Delete From [Services] WHERE Service =@Service"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@Service", Service)
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
#Region "[On] |2019/06/25 22h51:232| <05.00.00> <Function> <> |.Open()|TestItem}|"' (Set|Get) This will initialise the connection and import the data.
        '''    <Summary>
        '''     (Set|Get) This will initialise the connection and import the data.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:400 </Published>
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

#Region "[On] |2019/06/25 22h51:249| <05.00.01> <Function> <> |.Close()|TestItem}|"' (Set|Get) This willClosing the connection
        '''    <Summary>
        '''     (Set|Get) This willClosing the connection
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:400 </Published>
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

#Region "[On] |2019/06/25 22h51:265| <05.00.02> <Function> <> |.List()|List(Of Services)}|"' (Set|Get) Return the entire table listed
        '''    <Summary>
        '''     (Set|Get) Return the entire table listed
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:401 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Return the entire table listed")>
        Public Function List() As List(Of Services)
            Dim Result As New List(Of Services)
            Me.Table = New Table(Me.TableName, Me.FilePath, Me.Password, False)
            For Each Row As DataRow In Me.Table.DataTable.Rows
                Dim Element As New Services(IIf(IsDBNull(Row.Item(0)), "", Row.Item(0)))
                Element.Reset(Table.Line)
                Result.Add(Element)
            Next
            Return Result
        End Function
#End Region '(Set|Get) Return the entire table listed

#Region "[On] |2019/06/25 22h51:280| <05.00.03> <Function> <> |.SearchByName()|List(Of Services)}|"' (Set|Get) Search for each property that match the Search String.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search String.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:401 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Search for each property that match the Search String.")>
        Public Shared Function SearchByName(ByVal Search As String) As List(Of Services)
            Dim Result As New List(Of Services)
            Dim C As New Services
            For Each Element As Services In C.List
                If Element.Service.ToLower() = Search.ToLower() Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search String.

#Region "[On] |2019/06/25 22h51:294| <05.00.04> <Function> <> |.SearchByID()|List(Of Services)}|"' (Set|Get) Search for each property that match the Search Id.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search Id.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:401 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Search for each property that match the Search Id.")>
        Public Shared Function SearchByID(ByVal Search As Double) As List(Of Services)
            Dim Result As New List(Of Services)
            Dim C As New Services
            For Each Element As Services In C.List
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search Id.

#Region "[On] |2019/06/25 22h51:308| <05.00.05> <Function> <> |.ToString()|String}|"' (Set|Get) The function ToString.
        '''    <Summary>
        '''     (Set|Get) The function ToString.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:401 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The function ToString.")>
        Public Overrides Function ToString() As String
            Return Me.Service
        End Function
#End Region '(Set|Get) The function ToString.

#Region "[On] |2019/06/25 22h51:321| <05.00.06> <Function> <> |.CheckConnection()|Boolean}|"' (Set|Get) Evaluate the connection to the DataBase
        '''    <Summary>
        '''     (Set|Get) Evaluate the connection to the DataBase
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:401 </Published>
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
#Region "[On] |2019/06/25 22h51:335| <15.00.00> <Runtime> <> |.Table()|Table"' (Set|Get) The Table.
        '''    <Summary>
        '''     (Set|Get) The Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:401 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Table.")>
        Public Table As Table
#End Region '(Set|Get) The Table.

#Region "[On] |2019/06/25 22h51:367| <15.00.01> <Runtime> <> |.Line()|String"' (Set|Get) The Connection String To the Table.
        '''    <Summary>
        '''     (Set|Get) The Connection String To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:402 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Connection String To the Table.")>
        Public Line As String
#End Region '(Set|Get) The Connection String To the Table.

#Region "[On] |2019/06/25 22h51:401| <15.00.02> <Runtime> <> |.FilePath()|String"' (Set|Get) The FilePath To the Table.
        '''    <Summary>
        '''     (Set|Get) The FilePath To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:402 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The FilePath To the Table.")>
        Public FilePath As String
#End Region '(Set|Get) The FilePath To the Table.

#Region "[On] |2019/06/25 22h51:432| <15.00.03> <Runtime> <> |.Password()|String"' (Set|Get) The Password To the Table.
        '''    <Summary>
        '''     (Set|Get) The Password To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:402 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Password To the Table.")>
        Public Password As String
#End Region '(Set|Get) The Password To the Table.

#Region "[On] |2019/06/25 22h51:468| <15.00.04> <Runtime> <> |.UseSQL()|Boolean"' (Set|Get) Determines if the Database Connection is of type SQL.
        '''    <Summary>
        '''     (Set|Get) Determines if the Database Connection is of type SQL.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:402 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Determines if the Database Connection is of type SQL.")>
        Public UseSQL As Boolean
#End Region '(Set|Get) Determines if the Database Connection is of type SQL.

#Region "[On] |2019/06/25 22h51:523| <15.00.05> <Runtime> <> |.TableName()|String"' (Set|Get) The name of the Table.
        '''    <Summary>
        '''     (Set|Get) The name of the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:402 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The name of the Table.")>
        Public TableName As String
#End Region '(Set|Get) The name of the Table.

#Region "[On] |2019/06/25 22h51:554| <15.00.06> <Runtime> <> |.Con()|OleDb.OleDbConnection"' (Set|Get) The Con To the Table.
        '''    <Summary>
        '''     (Set|Get) The Con To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:402 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Con To the Table.")>
        Public Con As OleDb.OleDbConnection
#End Region '(Set|Get) The Con To the Table.

#Region "[On] |2019/06/25 22h51:594| <15.00.07> <Runtime> <> |.Cmd()|OleDb.OleDbCommand"' (Set|Get) The Cmd To the Table.
        '''    <Summary>
        '''     (Set|Get) The Cmd To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:402 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Cmd To the Table.")>
        Public Cmd As OleDb.OleDbCommand
#End Region '(Set|Get) The Cmd To the Table.

#Region "[On] |2019/06/25 22h51:624| <15.00.08> <Runtime> <> |.DataReader()|OleDb.OleDbDataReader"' (Set|Get) The DataReader To the Table.
        '''    <Summary>
        '''     (Set|Get) The DataReader To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:402 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The DataReader To the Table.")>
        Public DataReader As OleDb.OleDbDataReader
#End Region '(Set|Get) The DataReader To the Table.

#Region "[On] |2019/06/25 22h51:654| <15.00.09> <Runtime> <> |.DataAdapter()|OleDb.OleDbDataAdapter"' (Set|Get) The DataAdapter To the Table.
        '''    <Summary>
        '''     (Set|Get) The DataAdapter To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:403 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The DataAdapter To the Table.")>
        Public DataAdapter As OleDb.OleDbDataAdapter
#End Region '(Set|Get) The DataAdapter To the Table.

#Region "[On] |2019/06/25 22h51:687| <15.00.10> <Runtime> <> |.Connector()|LineInfo"' (Set|Get) The Connector To the Table.
        '''    <Summary>
        '''     (Set|Get) The Connector To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:403 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Connector To the Table.")>
        Public Connector As LineInfo
#End Region '(Set|Get) The Connector To the Table.

#Region "[On] |2019/06/25 22h51:719| <15.00.11> <Runtime> <> |.Log()|String"' (Set|Get) The Log To the Table.
        '''    <Summary>
        '''     (Set|Get) The Log To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:403 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Log To the Table.")>
        Public Log As String
#End Region '(Set|Get) The Log To the Table.

#End Region
#Region "<7> [Loader]{2}"
#Region "[On] |2019/06/25 22h51:750| <06.00.00> <Loader> <> |.Empty()|Function}|"' (Set|Get) The sub Empty.
        '''    <Summary>
        '''     (Set|Get) The sub Empty.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:403 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The sub Empty.")>
        Public Sub New()
            Reset
        End Sub
#End Region '(Set|Get) The sub Empty.

#Region "[On] |2019/06/25 22h51:751| <06.00.01> <Loader> <> |.Filled()|Function}|"' (Set|Get) The sub Filled.
        '''    <Summary>
        '''     (Set|Get) The sub Filled.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:403 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The sub Filled.")>
        Public Sub New(ByVal Service As String)
            With Me
                Clear()
                Reset()
                .Service = Service
            End With

        End Sub
#End Region '(Set|Get) The sub Filled.

#End Region
    End Class
#End Region
#Region "[On] |2019/06/25 22h51:892| <08.00.00> <Class> <> |.Sociétés|Class|{31} |Production Cost : 33.7|Selling Price : 50.55|"' Class created automatically by SmartOffice (c)Copyright 2019.
    '''    <Summary>
    '''     Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Sociétés
    '''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
    '''    Contributor Information : ||
    '''    Creation Date :           2019/06/25 22h51:892
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
    '''    |Selling Price without VAT   |50.55
    '''    |Total TVA                   |3.89
    '''    |Grand Total                 |54.44
    '''    |/Schema|
    '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
    '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
    '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
    '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:408 </Published>
    '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
    '''    </Summary>
    Public Class Sociétés
#Region "<1> [Property]{4}"
#Region "[On] |2019/06/25 22h51:893| <01.00.00> <Property> <Columns> |.Ref()|String|"' (Set|Get) The Ref as String.
        Private _Ref As String
        '''    <Summary>
        '''     (Set|Get) The Ref as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:409 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Ref as String.")>
        Public Property Ref() As String
            Get
                Return _Ref
            End Get
            Set(ByVal Value As String)
                _Ref = Value
            End Set
        End Property
#End Region '(Set|Get) The Ref as String.

#Region "[On] |2019/06/25 22h51:905| <01.00.01> <Property> <Columns> |.RaisonSocial()|String|"' (Set|Get) The RaisonSocial as String.
        Private _RaisonSocial As String
        '''    <Summary>
        '''     (Set|Get) The RaisonSocial as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:409 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The RaisonSocial as String.")>
        Public Property RaisonSocial() As String
            Get
                Return _RaisonSocial
            End Get
            Set(ByVal Value As String)
                _RaisonSocial = Value
            End Set
        End Property
#End Region '(Set|Get) The RaisonSocial as String.

#Region "[On] |2019/06/25 22h51:916| <01.00.02> <Property> <Columns> |.NuméroTVA()|String|"' (Set|Get) The NuméroTVA as String.
        Private _NuméroTVA As String
        '''    <Summary>
        '''     (Set|Get) The NuméroTVA as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:409 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The NuméroTVA as String.")>
        Public Property NuméroTVA() As String
            Get
                Return _NuméroTVA
            End Get
            Set(ByVal Value As String)
                _NuméroTVA = Value
            End Set
        End Property
#End Region '(Set|Get) The NuméroTVA as String.

#Region "[On] |2019/06/25 22h51:928| <01.00.03> <Property> <Columns> |.Index()|Integer|"' (Set|Get) The Index as Integer.
        Private _Index As Integer
        '''    <Summary>
        '''     (Set|Get) The Index as Integer.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:409 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Index as Integer.")>
        Public Property Index() As Integer
            Get
                Return _Index
            End Get
            Set(ByVal Value As Integer)
                _Index = Value
            End Set
        End Property
#End Region '(Set|Get) The Index as Integer.

#End Region
#Region "<2> [Enumeration]{1}"
#Region "[On] |2019/06/25 22h51:940| <02.00.00> <Enumeration> <> |.Schema()|Enumeration{3}|"' (Set|Get) The enumeration of Schema.
        '''    <Summary>
        '''     (Set|Get) The enumeration of Schema.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:409 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The enumeration of Schema.")>
        Enum Schema
            ''' <summary>(Set|Get) The Ref as String.</summary>
            [Ref] = 0
            ''' <summary>(Set|Get) The RaisonSocial as String.</summary>
            [RaisonSocial] = 1
            ''' <summary>(Set|Get) The NuméroTVA as String.</summary>
            [NuméroTVA] = 2
            ''' <summary>(Set|Get) The Index as Integer.</summary>
            [Index] = 3
        End Enum
#End Region '(Set|Get) The enumeration of Schema.

#End Region
#Region "<4> [Sub]{5}"
#Region "[On] |2019/06/25 22h51:952| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
        '''    <Summary>
        '''     (Set|Get) This will reinitialize the class element.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:410 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will reinitialize the class element.")>
        Public Sub Clear()
            With Me
                .Ref = Nothing
                .RaisonSocial = Nothing
                .NuméroTVA = Nothing
                .Index = 0
            End With
        End Sub
#End Region '(Set|Get) This will reinitialize the class element.

#Region "[On] |2019/06/25 22h51:963| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
        '''    <Summary>
        '''     (Set|Get) This will reinitialize the variables of this class.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:410 </Published>
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
                    TableName = "Sociétés"
                    Line = Connector.Line
                    UseSQL = False
                Else
                    FilePath = My.Settings.Db_TimeSheet_FilePath
                    Password = My.Settings.Db_TimeSheet_Password
                    Me.Line = My.Settings.Db_TimeSheet_Line
                    TableName = "Sociétés"
                    UseSQL = False
                End If
            Else
                If IsNothing(FilePath) Then
                    FilePath = My.Settings.Db_TimeSheet_FilePath
                End If
                If FilePath.Length < 1 Then
                    FilePath = My.Settings.Db_TimeSheet_FilePath
                End If
                FilePath = My.Settings.Db_TimeSheet_FilePath
                Password = My.Settings.Db_TimeSheet_Password
                Me.Line = My.Settings.Db_TimeSheet_Line
                TableName = "Sociétés"
                UseSQL = False
            End If

        End Sub
#End Region '(Set|Get) This will reinitialize the variables of this class.

#Region "[On] |2019/06/25 23h39:584| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
        '''    <Summary>
        '''     (Set|Get) This will add a new row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 23h39:151 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will add a new row in the table.")>
        Public Sub Add()
            Try
                Dim Str As String = Nothing
                Str = "Insert Into [Sociétés] (
`Ref`, 
`RaisonSocial`, 
`NuméroTVA`, 
`Index`) Values (@0, @1, @2, @3)"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@0", Me.Ref)
                Cmd.Parameters.AddWithValue("@1", Me.RaisonSocial)
                Cmd.Parameters.AddWithValue("@2", Me.NuméroTVA)
                Cmd.Parameters.AddWithValue("@3", Me.Index)
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

#Region "[On] |2019/06/25 22h51:992| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
        '''    <Summary>
        '''     (Set|Get) This will update a row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:410 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will update a row in the table.")>
        Public Sub Save()
            Try
                Dim Str As String = Nothing
                Str = "UPDATE [Sociétés] SET RaisonSocial = @RaisonSocial, NuméroTVA = @NuméroTVA, Index = @Index WHERE Ref = @Ref"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@RaisonSocial", RaisonSocial)
                Cmd.Parameters.AddWithValue("@NuméroTVA", NuméroTVA)
                Cmd.Parameters.AddWithValue("@Index", Index)
                Cmd.Parameters.AddWithValue("@Ref", Ref)
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

#Region "[On] |2019/06/25 22h51:005| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
        '''    <Summary>
        '''     (Set|Get) This will Delete a row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:410 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will Delete a row in the table.")>
        Public Sub Delete()
            Try
                Dim Str As String = Nothing
                Str = "Delete From [Sociétés] WHERE Ref =@Ref"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@Ref", Ref)
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
#Region "[On] |2019/06/25 22h51:018| <05.00.00> <Function> <> |.Open()|TestItem}|"' (Set|Get) This will initialise the connection and import the data.
        '''    <Summary>
        '''     (Set|Get) This will initialise the connection and import the data.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:410 </Published>
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

#Region "[On] |2019/06/25 22h51:031| <05.00.01> <Function> <> |.Close()|TestItem}|"' (Set|Get) This willClosing the connection
        '''    <Summary>
        '''     (Set|Get) This willClosing the connection
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:410 </Published>
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

#Region "[On] |2019/06/25 22h51:044| <05.00.02> <Function> <> |.List()|List(Of Sociétés)}|"' (Set|Get) Return the entire table listed
        '''    <Summary>
        '''     (Set|Get) Return the entire table listed
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:410 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Return the entire table listed")>
        Public Function List() As List(Of Sociétés)
            Dim Result As New List(Of Sociétés)
            Me.Table = New Table(Me.TableName, Me.FilePath, Me.Password, False)
            For Each Row As DataRow In Me.Table.DataTable.Rows
                Dim Element As New Sociétés(IIf(IsDBNull(Row.Item(0)), "", Row.Item(0)),
IIf(IsDBNull(Row.Item(1)), "", Row.Item(1)),
IIf(IsDBNull(Row.Item(2)), "", Row.Item(2)),
  IIf(IsDBNull(Row.Item(3)), 0, Row.Item(3)))
                Element.Reset(Table.Line)
                Result.Add(Element)
            Next
            Return Result
        End Function
#End Region '(Set|Get) Return the entire table listed

#Region "[On] |2019/06/25 22h51:059| <05.00.03> <Function> <> |.SearchByName()|List(Of Sociétés)}|"' (Set|Get) Search for each property that match the Search String.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search String.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:411 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Search for each property that match the Search String.")>
        Public Shared Function SearchByName(ByVal Search As String) As List(Of Sociétés)
            Dim Result As New List(Of Sociétés)
            Dim C As New Sociétés
            For Each Element As Sociétés In C.List
                If Element.Ref.ToLower() = Search.ToLower() Or Element.RaisonSocial.ToLower() = Search.ToLower() Or Element.NuméroTVA.ToLower() = Search.ToLower() Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search String.

#Region "[On] |2019/06/25 22h51:072| <05.00.04> <Function> <> |.SearchByID()|List(Of Sociétés)}|"' (Set|Get) Search for each property that match the Search Id.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search Id.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:411 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Search for each property that match the Search Id.")>
        Public Shared Function SearchByID(ByVal Search As Double) As List(Of Sociétés)
            Dim Result As New List(Of Sociétés)
            Dim C As New Sociétés
            For Each Element As Sociétés In C.List
                If Val(Element.Ref) = Search Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search Id.

#Region "[On] |2019/06/25 22h51:084| <05.00.05> <Function> <> |.ToString()|String}|"' (Set|Get) The function ToString.
        '''    <Summary>
        '''     (Set|Get) The function ToString.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:411 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The function ToString.")>
        Public Overrides Function ToString() As String
            Return Me.Ref
        End Function
#End Region '(Set|Get) The function ToString.

#Region "[On] |2019/06/25 22h51:102| <05.00.06> <Function> <> |.CheckConnection()|Boolean}|"' (Set|Get) Evaluate the connection to the DataBase
        '''    <Summary>
        '''     (Set|Get) Evaluate the connection to the DataBase
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:411 </Published>
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
#Region "[On] |2019/06/25 22h51:120| <15.00.00> <Runtime> <> |.Table()|Table"' (Set|Get) The Table.
        '''    <Summary>
        '''     (Set|Get) The Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:411 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Table.")>
        Public Table As Table
#End Region '(Set|Get) The Table.

#Region "[On] |2019/06/25 22h51:173| <15.00.01> <Runtime> <> |.Line()|String"' (Set|Get) The Connection String To the Table.
        '''    <Summary>
        '''     (Set|Get) The Connection String To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:411 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Connection String To the Table.")>
        Public Line As String
#End Region '(Set|Get) The Connection String To the Table.

#Region "[On] |2019/06/25 22h51:209| <15.00.02> <Runtime> <> |.FilePath()|String"' (Set|Get) The FilePath To the Table.
        '''    <Summary>
        '''     (Set|Get) The FilePath To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:412 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The FilePath To the Table.")>
        Public FilePath As String
#End Region '(Set|Get) The FilePath To the Table.

#Region "[On] |2019/06/25 22h51:239| <15.00.03> <Runtime> <> |.Password()|String"' (Set|Get) The Password To the Table.
        '''    <Summary>
        '''     (Set|Get) The Password To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:412 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Password To the Table.")>
        Public Password As String
#End Region '(Set|Get) The Password To the Table.

#Region "[On] |2019/06/25 22h51:289| <15.00.04> <Runtime> <> |.UseSQL()|Boolean"' (Set|Get) Determines if the Database Connection is of type SQL.
        '''    <Summary>
        '''     (Set|Get) Determines if the Database Connection is of type SQL.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:412 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Determines if the Database Connection is of type SQL.")>
        Public UseSQL As Boolean
#End Region '(Set|Get) Determines if the Database Connection is of type SQL.

#Region "[On] |2019/06/25 22h51:324| <15.00.05> <Runtime> <> |.TableName()|String"' (Set|Get) The name of the Table.
        '''    <Summary>
        '''     (Set|Get) The name of the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:412 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The name of the Table.")>
        Public TableName As String
#End Region '(Set|Get) The name of the Table.

#Region "[On] |2019/06/25 22h51:366| <15.00.06> <Runtime> <> |.Con()|OleDb.OleDbConnection"' (Set|Get) The Con To the Table.
        '''    <Summary>
        '''     (Set|Get) The Con To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:412 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Con To the Table.")>
        Public Con As OleDb.OleDbConnection
#End Region '(Set|Get) The Con To the Table.

#Region "[On] |2019/06/25 22h51:406| <15.00.07> <Runtime> <> |.Cmd()|OleDb.OleDbCommand"' (Set|Get) The Cmd To the Table.
        '''    <Summary>
        '''     (Set|Get) The Cmd To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:412 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Cmd To the Table.")>
        Public Cmd As OleDb.OleDbCommand
#End Region '(Set|Get) The Cmd To the Table.

#Region "[On] |2019/06/25 22h51:437| <15.00.08> <Runtime> <> |.DataReader()|OleDb.OleDbDataReader"' (Set|Get) The DataReader To the Table.
        '''    <Summary>
        '''     (Set|Get) The DataReader To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:412 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The DataReader To the Table.")>
        Public DataReader As OleDb.OleDbDataReader
#End Region '(Set|Get) The DataReader To the Table.

#Region "[On] |2019/06/25 22h51:467| <15.00.09> <Runtime> <> |.DataAdapter()|OleDb.OleDbDataAdapter"' (Set|Get) The DataAdapter To the Table.
        '''    <Summary>
        '''     (Set|Get) The DataAdapter To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:413 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The DataAdapter To the Table.")>
        Public DataAdapter As OleDb.OleDbDataAdapter
#End Region '(Set|Get) The DataAdapter To the Table.

#Region "[On] |2019/06/25 22h51:499| <15.00.10> <Runtime> <> |.Connector()|LineInfo"' (Set|Get) The Connector To the Table.
        '''    <Summary>
        '''     (Set|Get) The Connector To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:413 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Connector To the Table.")>
        Public Connector As LineInfo
#End Region '(Set|Get) The Connector To the Table.

#Region "[On] |2019/06/25 22h51:532| <15.00.11> <Runtime> <> |.Log()|String"' (Set|Get) The Log To the Table.
        '''    <Summary>
        '''     (Set|Get) The Log To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:413 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Log To the Table.")>
        Public Log As String
#End Region '(Set|Get) The Log To the Table.

#End Region
#Region "<7> [Loader]{2}"
#Region "[On] |2019/06/25 22h51:562| <06.00.00> <Loader> <> |.Empty()|Function}|"' (Set|Get) The sub Empty.
        '''    <Summary>
        '''     (Set|Get) The sub Empty.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:413 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The sub Empty.")>
        Public Sub New()
            Reset
        End Sub
#End Region '(Set|Get) The sub Empty.

#Region "[On] |2019/06/25 22h51:563| <06.00.01> <Loader> <> |.Filled()|Function}|"' (Set|Get) The sub Filled.
        '''    <Summary>
        '''     (Set|Get) The sub Filled.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:415 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>    ''' <param name="Ref">(Set|Get) The Ref as String.</param>
        ''' <param name="RaisonSocial">(Set|Get) The RaisonSocial as String.</param>
        ''' <param name="NuméroTVA">(Set|Get) The NuméroTVA as String.</param>
        ''' <param name="Index">(Set|Get) The Index as Integer.</param>

        <Browsable(True), Description("(Set|Get) The sub Filled.")>
        Public Sub New(ByVal Ref As String,
ByVal RaisonSocial As String,
ByVal NuméroTVA As String,
ByVal Index As Integer)
            With Me
                Clear()
                Reset()
                .Ref = Ref
                .RaisonSocial = RaisonSocial
                .NuméroTVA = NuméroTVA
                .Index = Index
            End With

        End Sub
#End Region '(Set|Get) The sub Filled.

#End Region
    End Class
#End Region

#Region "[On] |2019/06/25 22h51:701| <08.00.00> <Class> <> |.Tarif|Class|{32} |Production Cost : 35.5|Selling Price : 53.25|"' Class created automatically by SmartOffice (c)Copyright 2019.
    '''    <Summary>
    '''     Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Tarif
    '''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
    '''    Contributor Information : ||
    '''    Creation Date :           2019/06/25 22h51:701
    '''    |Schema|
    '''    |ID| |ObjectType |{Quantity}||UnitPrice||Total
    '''    |00| |Importation|{0}||1| |0
    '''    |01| |Properties |{5}||0.8| |4
    '''    |02| |Enumeration|{1}||0.4| |0.4
    '''    |03| |Structure  |{0}||0.4| |0
    '''    |04| |Sub        |{5}||1.2| |6
    '''    |05| |Function   |{7}||1.6| |11.2
    '''    |06| |Runtime    |{12}||0.4| |4.8
    '''    |07| |Loader     |{2}||0.8| |1.6
    '''    |08| |Class      |{0}||2| |0
    '''    |09| |Constante  |{0}||0.4| |0
    '''    |10| |Event      |{0}||1.2| |0
    '''    |11| |Members    |{5}||0.5| |2.5
    '''    |12| |Parameter  |{10}||0.5| |5
    '''    |Production Cost             |35.5
    '''    |Selling Price without VAT   |53.25
    '''    |Total TVA                   |4.1
    '''    |Grand Total                 |57.35
    '''    |/Schema|
    '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
    '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
    '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
    '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:421 </Published>
    '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
    '''    </Summary>
    Public Class Tarif
#Region "<1> [Property]{5}"
#Region "[On] |2019/06/25 22h51:702| <01.00.00> <Property> <Columns> |.ID()|Integer|"' (Set|Get) The ID as Integer.
        Private _ID As Integer
        '''    <Summary>
        '''     (Set|Get) The ID as Integer.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:421 </Published>
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

#Region "[On] |2019/06/25 22h51:713| <01.00.01> <Property> <Columns> |.Code()|String|"' (Set|Get) The Code as String.
        Private _Code As String
        '''    <Summary>
        '''     (Set|Get) The Code as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:421 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Code as String.")>
        Public Property Code() As String
            Get
                Return _Code
            End Get
            Set(ByVal Value As String)
                _Code = Value
            End Set
        End Property
#End Region '(Set|Get) The Code as String.

#Region "[On] |2019/06/25 22h51:726| <01.00.02> <Property> <Columns> |.Collaborateur()|String|"' (Set|Get) The Collaborateur as String.
        Private _Collaborateur As String
        '''    <Summary>
        '''     (Set|Get) The Collaborateur as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:421 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Collaborateur as String.")>
        Public Property Collaborateur() As String
            Get
                Return _Collaborateur
            End Get
            Set(ByVal Value As String)
                _Collaborateur = Value
            End Set
        End Property
#End Region '(Set|Get) The Collaborateur as String.

#Region "[On] |2019/06/25 22h51:739| <01.00.03> <Property> <Columns> |.DateIN()|DateTime|"' (Set|Get) The DateIN as DateTime.
        Private _DateIN As DateTime
        '''    <Summary>
        '''     (Set|Get) The DateIN as DateTime.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:421 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The DateIN as DateTime.")>
        Public Property DateIN() As DateTime
            Get
                Return _DateIN
            End Get
            Set(ByVal Value As DateTime)
                _DateIN = Value
            End Set
        End Property
#End Region '(Set|Get) The DateIN as DateTime.

#Region "[On] |2019/06/25 22h51:756| <01.00.04> <Property> <Columns> |.Price()|Double|"' (Set|Get) The Price as Double.
        Private _Price As Double
        '''    <Summary>
        '''     (Set|Get) The Price as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:422 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Price as Double.")>
        Public Property Price() As Double
            Get
                Return _Price
            End Get
            Set(ByVal Value As Double)
                _Price = Value
            End Set
        End Property
#End Region '(Set|Get) The Price as Double.

#End Region
#Region "<2> [Enumeration]{1}"
#Region "[On] |2019/06/25 22h51:768| <02.00.00> <Enumeration> <> |.Schema()|Enumeration{4}|"' (Set|Get) The enumeration of Schema.
        '''    <Summary>
        '''     (Set|Get) The enumeration of Schema.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:422 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The enumeration of Schema.")>
        Enum Schema
            ''' <summary>(Set|Get) The ID as Integer.</summary>
            [ID] = 0
            ''' <summary>(Set|Get) The Code as String.</summary>
            [Code] = 1
            ''' <summary>(Set|Get) The Collaborateur as String.</summary>
            [Collaborateur] = 2
            ''' <summary>(Set|Get) The DateIN as DateTime.</summary>
            [DateIN] = 3
            ''' <summary>(Set|Get) The Price as Double.</summary>
            [Price] = 4
        End Enum
#End Region '(Set|Get) The enumeration of Schema.

#End Region
#Region "<4> [Sub]{5}"
#Region "[On] |2019/06/25 22h51:780| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
        '''    <Summary>
        '''     (Set|Get) This will reinitialize the class element.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:422 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will reinitialize the class element.")>
        Public Sub Clear()
            With Me
                .ID = 0
                .Code = Nothing
                .Collaborateur = Nothing
                .DateIN = New DateTime
                .Price = 0
            End With
        End Sub
#End Region '(Set|Get) This will reinitialize the class element.

#Region "[On] |2019/06/25 22h51:793| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
        '''    <Summary>
        '''     (Set|Get) This will reinitialize the variables of this class.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:422 </Published>
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
                    TableName = "Tarif"
                    Line = Connector.Line
                    UseSQL = False
                Else
                    FilePath = My.Settings.Db_TimeSheet_FilePath
                    Password = My.Settings.Db_TimeSheet_Password
                    Me.Line = My.Settings.Db_TimeSheet_Line
                    TableName = "Tarif"
                    UseSQL = False
                End If
            Else
                If IsNothing(FilePath) Then
                    FilePath = My.Settings.Db_TimeSheet_FilePath
                End If
                If FilePath.Length < 1 Then
                    FilePath = My.Settings.Db_TimeSheet_FilePath
                End If
                FilePath = My.Settings.Db_TimeSheet_FilePath
                Password = My.Settings.Db_TimeSheet_Password
                Me.Line = My.Settings.Db_TimeSheet_Line
                TableName = "Tarif"
                UseSQL = False
            End If

        End Sub
#End Region '(Set|Get) This will reinitialize the variables of this class.

#Region "[On] |2019/06/25 23h39:409| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
        '''    <Summary>
        '''     (Set|Get) This will add a new row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 23h39:164 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will add a new row in the table.")>
        Public Sub Add()
            Try
                Dim Str As String = Nothing
                Str = "Insert Into [Tarif] (
`ID`, 
`Code`, 
`Collaborateur`, 
`DateIN`, 
`Price`) Values (@0, @1, @2, @3, @4)"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@0", Me.ID)
                Cmd.Parameters.AddWithValue("@1", Me.Code)
                Cmd.Parameters.AddWithValue("@2", Me.Collaborateur)
                Cmd.Parameters.AddWithValue("@3", Me.DateIN)
                Cmd.Parameters.AddWithValue("@4", Me.Price)
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

#Region "[On] |2019/06/25 22h51:817| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
        '''    <Summary>
        '''     (Set|Get) This will update a row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:422 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will update a row in the table.")>
        Public Sub Save()
            Try
                Dim Str As String = Nothing
                Str = "UPDATE [Tarif] SET Code = @Code, Collaborateur = @Collaborateur, DateIN = @DateIN, Price = @Price WHERE ID = @ID"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@Code", Code)
                Cmd.Parameters.AddWithValue("@Collaborateur", Collaborateur)
                Cmd.Parameters.AddWithValue("@DateIN", DateIN)
                Cmd.Parameters.AddWithValue("@Price", Price)
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

#Region "[On] |2019/06/25 22h51:831| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
        '''    <Summary>
        '''     (Set|Get) This will Delete a row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:422 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will Delete a row in the table.")>
        Public Sub Delete()
            Try
                Dim Str As String = Nothing
                Str = "Delete From [Tarif] WHERE ID =@ID"
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
#Region "<5> [Function]{8}"
#Region "[On] |2019/06/25 22h51:845| <05.00.00> <Function> <> |.Open()|TestItem}|"' (Set|Get) This will initialise the connection and import the data.
        '''    <Summary>
        '''     (Set|Get) This will initialise the connection and import the data.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:423 </Published>
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

#Region "[On] |2019/06/25 22h51:857| <05.00.01> <Function> <> |.Close()|TestItem}|"' (Set|Get) This willClosing the connection
        '''    <Summary>
        '''     (Set|Get) This willClosing the connection
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:423 </Published>
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

#Region "[On] |2019/06/25 22h51:871| <05.00.02> <Function> <> |.List()|List(Of Tarif)}|"' (Set|Get) Return the entire table listed
        '''    <Summary>
        '''     (Set|Get) Return the entire table listed
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:423 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Return the entire table listed")>
        Public Function List() As List(Of Tarif)
            Dim Result As New List(Of Tarif)
            Me.Table = New Table(Me.TableName, Me.FilePath, Me.Password, False)
            For Each Row As DataRow In Me.Table.DataTable.Rows
                Dim Element As New Tarif(IIf(IsDBNull(Row.Item(0)), 0, Row.Item(0)),
IIf(IsDBNull(Row.Item(1)), "", Row.Item(1)),
IIf(IsDBNull(Row.Item(2)), "", Row.Item(2)),
IIf(IsDBNull(Row.Item(3)), New DateTime(1970, 1, 1), Row.Item(3)),
  IIf(IsDBNull(Row.Item(4)), 0, Row.Item(4)))
                Element.Reset(Table.Line)
                Result.Add(Element)
            Next
            Return Result
        End Function
#End Region '(Set|Get) Return the entire table listed

#Region "[On] |2019/06/25 22h51:884| <05.00.03> <Function> <> |.SearchByName()|List(Of Tarif)}|"' (Set|Get) Search for each property that match the Search String.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search String.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:424 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Search for each property that match the Search String.")>
        Public Shared Function SearchByName(ByVal Search As String) As List(Of Tarif)
            Dim Result As New List(Of Tarif)
            Dim C As New Tarif
            For Each Element As Tarif In C.List
                If Element.Code.ToLower() = Search.ToLower() Or Element.Collaborateur.ToLower() = Search.ToLower() Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search String.

#Region "[On] |2019/06/25 22h51:897| <05.00.04> <Function> <> |.SearchByID()|List(Of Tarif)}|"' (Set|Get) Search for each property that match the Search Id.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search Id.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:424 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Search for each property that match the Search Id.")>
        Public Shared Function SearchByID(ByVal Search As Double) As List(Of Tarif)
            Dim Result As New List(Of Tarif)
            Dim C As New Tarif
            For Each Element As Tarif In C.List
                If Val(Element.ID) = Search Or Val(Element.Price) = Search Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search Id.

#Region "[On] |2019/06/25 22h51:910| <05.00.05> <Function> <> |.ToString()|String}|"' (Set|Get) The function ToString.
        '''    <Summary>
        '''     (Set|Get) The function ToString.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:424 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The function ToString.")>
        Public Overrides Function ToString() As String
            Return Me.ID
        End Function
#End Region '(Set|Get) The function ToString.

#Region "[On] |2019/06/25 22h51:924| <05.00.06> <Function> <> |.CheckConnection()|Boolean}|"' (Set|Get) Evaluate the connection to the DataBase
        '''    <Summary>
        '''     (Set|Get) Evaluate the connection to the DataBase
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:424 </Published>
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
#Region "[On] |2019/06/07 20h20:282| <05.00.07> <Function> <> |.GetunitPrice(Collaborateur|String,CodeClient|String)|Tarif|"' (Set|Get) The function ToString.
        Public Shared Function GetunitPrice(ByVal Collaborateur As String,
                                        ByVal codeclient As String) As Tarif
            Dim Result As New Tarif
            Dim Lt As New List(Of Tarif)
            Lt = Result.List()
            If Collaborateur <> "" And codeclient <> "" Then
                For Each t As Tarif In Lt
                    If t.Code = codeclient Then
                        If t.Collaborateur = Collaborateur Then
                            Result = t
                            Exit For
                        End If
                    End If

                Next
            End If
            Return Result
        End Function
#End Region

#End Region
#Region "<6> [Runtime]{12}"
#Region "[On] |2019/06/25 22h51:939| <15.00.00> <Runtime> <> |.Table()|Table"' (Set|Get) The Table.
        '''    <Summary>
        '''     (Set|Get) The Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:425 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Table.")>
        Public Table As Table
#End Region '(Set|Get) The Table.

#Region "[On] |2019/06/25 22h51:999| <15.00.01> <Runtime> <> |.Line()|String"' (Set|Get) The Connection String To the Table.
        '''    <Summary>
        '''     (Set|Get) The Connection String To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:425 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Connection String To the Table.")>
        Public Line As String
#End Region '(Set|Get) The Connection String To the Table.

#Region "[On] |2019/06/25 22h51:033| <15.00.02> <Runtime> <> |.FilePath()|String"' (Set|Get) The FilePath To the Table.
        '''    <Summary>
        '''     (Set|Get) The FilePath To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:425 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The FilePath To the Table.")>
        Public FilePath As String
#End Region '(Set|Get) The FilePath To the Table.

#Region "[On] |2019/06/25 22h51:067| <15.00.03> <Runtime> <> |.Password()|String"' (Set|Get) The Password To the Table.
        '''    <Summary>
        '''     (Set|Get) The Password To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:425 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Password To the Table.")>
        Public Password As String
#End Region '(Set|Get) The Password To the Table.

#Region "[On] |2019/06/25 22h51:100| <15.00.04> <Runtime> <> |.UseSQL()|Boolean"' (Set|Get) Determines if the Database Connection is of type SQL.
        '''    <Summary>
        '''     (Set|Get) Determines if the Database Connection is of type SQL.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:425 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Determines if the Database Connection is of type SQL.")>
        Public UseSQL As Boolean
#End Region '(Set|Get) Determines if the Database Connection is of type SQL.

#Region "[On] |2019/06/25 22h51:140| <15.00.05> <Runtime> <> |.TableName()|String"' (Set|Get) The name of the Table.
        '''    <Summary>
        '''     (Set|Get) The name of the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:425 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The name of the Table.")>
        Public TableName As String
#End Region '(Set|Get) The name of the Table.

#Region "[On] |2019/06/25 22h51:172| <15.00.06> <Runtime> <> |.Con()|OleDb.OleDbConnection"' (Set|Get) The Con To the Table.
        '''    <Summary>
        '''     (Set|Get) The Con To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:425 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Con To the Table.")>
        Public Con As OleDb.OleDbConnection
#End Region '(Set|Get) The Con To the Table.

#Region "[On] |2019/06/25 22h51:213| <15.00.07> <Runtime> <> |.Cmd()|OleDb.OleDbCommand"' (Set|Get) The Cmd To the Table.
        '''    <Summary>
        '''     (Set|Get) The Cmd To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:425 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Cmd To the Table.")>
        Public Cmd As OleDb.OleDbCommand
#End Region '(Set|Get) The Cmd To the Table.

#Region "[On] |2019/06/25 22h51:243| <15.00.08> <Runtime> <> |.DataReader()|OleDb.OleDbDataReader"' (Set|Get) The DataReader To the Table.
        '''    <Summary>
        '''     (Set|Get) The DataReader To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:425 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The DataReader To the Table.")>
        Public DataReader As OleDb.OleDbDataReader
#End Region '(Set|Get) The DataReader To the Table.

#Region "[On] |2019/06/25 22h51:275| <15.00.09> <Runtime> <> |.DataAdapter()|OleDb.OleDbDataAdapter"' (Set|Get) The DataAdapter To the Table.
        '''    <Summary>
        '''     (Set|Get) The DataAdapter To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:426 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The DataAdapter To the Table.")>
        Public DataAdapter As OleDb.OleDbDataAdapter
#End Region '(Set|Get) The DataAdapter To the Table.

#Region "[On] |2019/06/25 22h51:305| <15.00.10> <Runtime> <> |.Connector()|LineInfo"' (Set|Get) The Connector To the Table.
        '''    <Summary>
        '''     (Set|Get) The Connector To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:426 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Connector To the Table.")>
        Public Connector As LineInfo
#End Region '(Set|Get) The Connector To the Table.

#Region "[On] |2019/06/25 22h51:337| <15.00.11> <Runtime> <> |.Log()|String"' (Set|Get) The Log To the Table.
        '''    <Summary>
        '''     (Set|Get) The Log To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:426 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Log To the Table.")>
        Public Log As String
#End Region '(Set|Get) The Log To the Table.

#End Region
#Region "<7> [Loader]{2}"
#Region "[On] |2019/06/25 22h51:371| <06.00.00> <Loader> <> |.Empty()|Function}|"' (Set|Get) The sub Empty.
        '''    <Summary>
        '''     (Set|Get) The sub Empty.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:426 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The sub Empty.")>
        Public Sub New()
            Reset
        End Sub
#End Region '(Set|Get) The sub Empty.

#Region "[On] |2019/06/25 22h51:373| <06.00.01> <Loader> <> |.Filled()|Function}|"' (Set|Get) The sub Filled.
        '''    <Summary>
        '''     (Set|Get) The sub Filled.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:426 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>    ''' <param name="ID">(Set|Get) The ID as Integer.</param>
        ''' <param name="Code">(Set|Get) The Code as String.</param>
        ''' <param name="Collaborateur">(Set|Get) The Collaborateur as String.</param>
        ''' <param name="DateIN">(Set|Get) The DateIN as DateTime.</param>
        ''' <param name="Price">(Set|Get) The Price as Double.</param>

        <Browsable(True), Description("(Set|Get) The sub Filled.")>
        Public Sub New(ByVal ID As Integer,
ByVal Code As String,
ByVal Collaborateur As String,
ByVal DateIN As DateTime,
ByVal Price As Double)
            With Me
                Clear()
                Reset()
                .ID = ID
                .Code = Code
                .Collaborateur = Collaborateur
                .DateIN = DateIN
                .Price = Price
            End With

        End Sub
#End Region '(Set|Get) The sub Filled.

#End Region
    End Class
#End Region

#Region "[On] |2019/06/25 22h51:532| <08.00.00> <Class> <> |.TimeSheet|Class|{38} |Production Cost : 46.3|Selling Price : 69.45|"' Class created automatically by SmartOffice (c)Copyright 2019.
    '''    <Summary>
    '''     Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class TimeSheet
    '''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
    '''    Contributor Information : ||
    '''    Creation Date :           2019/06/25 22h51:532
    '''    |Schema|
    '''    |ID| |ObjectType |{Quantity}||UnitPrice||Total
    '''    |00| |Importation|{0}||1| |0
    '''    |01| |Properties |{11}||0.8| |8.8
    '''    |02| |Enumeration|{1}||0.4| |0.4
    '''    |03| |Structure  |{0}||0.4| |0
    '''    |04| |Sub        |{5}||1.2| |6
    '''    |05| |Function   |{7}||1.6| |11.2
    '''    |06| |Runtime    |{12}||0.4| |4.8
    '''    |07| |Loader     |{2}||0.8| |1.6
    '''    |08| |Class      |{0}||2| |0
    '''    |09| |Constante  |{0}||0.4| |0
    '''    |10| |Event      |{0}||1.2| |0
    '''    |11| |Members    |{11}||0.5| |5.5
    '''    |12| |Parameter  |{16}||0.5| |8
    '''    |Production Cost             |46.3
    '''    |Selling Price without VAT   |69.45
    '''    |Total TVA                   |5.35
    '''    |Grand Total                 |74.8
    '''    |/Schema|
    '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
    '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
    '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
    '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:431 </Published>
    '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
    '''    </Summary>
    Public Class TimeSheet
#Region "<1> [Property]{11}"
#Region "[On] |2019/06/25 22h51:533| <01.00.00> <Property> <Columns> |.ID()|Integer|"' (Set|Get) The ID as Integer.
        Private _ID As Integer
        '''    <Summary>
        '''     (Set|Get) The ID as Integer.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:431 </Published>
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

#Region "[On] |2019/06/25 22h51:544| <01.00.01> <Property> <Columns> |.Active()|Boolean|"' (Set|Get) The Active as Boolean.
        Private _Active As Boolean
        '''    <Summary>
        '''     (Set|Get) The Active as Boolean.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:431 </Published>
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

#Region "[On] |2019/06/25 22h51:555| <01.00.02> <Property> <Columns> |.TimeIn()|DateTime|"' (Set|Get) The TimeIn as DateTime.
        Private _TimeIn As DateTime
        '''    <Summary>
        '''     (Set|Get) The TimeIn as DateTime.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:432 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The TimeIn as DateTime.")>
        Public Property TimeIn() As DateTime
            Get
                Return _TimeIn
            End Get
            Set(ByVal Value As DateTime)
                _TimeIn = Value
            End Set
        End Property
#End Region '(Set|Get) The TimeIn as DateTime.

#Region "[On] |2019/06/25 22h51:567| <01.00.03> <Property> <Columns> |.Collaborateur()|String|"' (Set|Get) The Collaborateur as String.
        Private _Collaborateur As String
        '''    <Summary>
        '''     (Set|Get) The Collaborateur as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:432 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Collaborateur as String.")>
        Public Property Collaborateur() As String
            Get
                Return _Collaborateur
            End Get
            Set(ByVal Value As String)
                _Collaborateur = Value
            End Set
        End Property
#End Region '(Set|Get) The Collaborateur as String.

#Region "[On] |2019/06/25 22h51:579| <01.00.04> <Property> <Columns> |.Mandat()|String|"' (Set|Get) The Mandat as String.
        Private _Mandat As String
        '''    <Summary>
        '''     (Set|Get) The Mandat as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:432 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Mandat as String.")>
        Public Property Mandat() As String
            Get
                Return _Mandat
            End Get
            Set(ByVal Value As String)
                _Mandat = Value
            End Set
        End Property
#End Region '(Set|Get) The Mandat as String.

#Region "[On] |2019/06/25 22h51:591| <01.00.05> <Property> <Columns> |.Quantity()|Double|"' (Set|Get) The Quantity as Double.
        Private _Quantity As Double
        '''    <Summary>
        '''     (Set|Get) The Quantity as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:432 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Quantity as Double.")>
        Public Property Quantity() As Double
            Get
                Return _Quantity
            End Get
            Set(ByVal Value As Double)
                _Quantity = Value
            End Set
        End Property
#End Region '(Set|Get) The Quantity as Double.

#Region "[On] |2019/06/25 22h51:603| <01.00.06> <Property> <Columns> |.UnitPrice()|Double|"' (Set|Get) The UnitPrice as Double.
        Private _UnitPrice As Double
        '''    <Summary>
        '''     (Set|Get) The UnitPrice as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:433 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The UnitPrice as Double.")>
        Public Property UnitPrice() As Double
            Get
                Return _UnitPrice
            End Get
            Set(ByVal Value As Double)
                _UnitPrice = Value
            End Set
        End Property
#End Region '(Set|Get) The UnitPrice as Double.

#Region "[On] |2019/06/25 22h51:616| <01.00.07> <Property> <Columns> |.Description()|String|"' (Set|Get) The Description as String.
        Private _Description As String
        '''    <Summary>
        '''     (Set|Get) The Description as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:433 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Description as String.")>
        Public Property Description() As String
            Get
                Return _Description
            End Get
            Set(ByVal Value As String)
                _Description = Value
            End Set
        End Property
#End Region '(Set|Get) The Description as String.

#Region "[On] |2019/06/25 22h51:628| <01.00.08> <Property> <Columns> |.Facturable()|Boolean|"' (Set|Get) The Facturable as Boolean.
        Private _Facturable As Boolean
        '''    <Summary>
        '''     (Set|Get) The Facturable as Boolean.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:433 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Facturable as Boolean.")>
        Public Property Facturable() As Boolean
            Get
                Return _Facturable
            End Get
            Set(ByVal Value As Boolean)
                _Facturable = Value
            End Set
        End Property
#End Region '(Set|Get) The Facturable as Boolean.

#Region "[On] |2019/06/25 22h51:640| <01.00.09> <Property> <Columns> |.TotalHTVA()|Double|"' (Set|Get) The TotalHTVA as Double.
        Private _TotalHTVA As Double
        '''    <Summary>
        '''     (Set|Get) The TotalHTVA as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:433 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The TotalHTVA as Double.")>
        Public Property TotalHTVA() As Double
            Get
                Return _TotalHTVA
            End Get
            Set(ByVal Value As Double)
                _TotalHTVA = Value
            End Set
        End Property
#End Region '(Set|Get) The TotalHTVA as Double.

#Region "[On] |2019/06/25 22h51:651| <01.00.10> <Property> <Columns> |.Total()|Double|"' (Set|Get) The Total as Double.
        Private _Total As Double
        '''    <Summary>
        '''     (Set|Get) The Total as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:433 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Total as Double.")>
        Public Property Total() As Double
            Get
                Return _Total
            End Get
            Set(ByVal Value As Double)
                _Total = Value
            End Set
        End Property
#End Region '(Set|Get) The Total as Double.

#End Region
#Region "<2> [Enumeration]{1}"
#Region "[On] |2019/06/25 22h51:664| <02.00.00> <Enumeration> <> |.Schema()|Enumeration{10}|"' (Set|Get) The enumeration of Schema.
        '''    <Summary>
        '''     (Set|Get) The enumeration of Schema.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:434 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The enumeration of Schema.")>
        Enum Schema
            ''' <summary>(Set|Get) The ID as Integer.</summary>
            [ID] = 0
            ''' <summary>(Set|Get) The Active as Boolean.</summary>
            [Active] = 1
            ''' <summary>(Set|Get) The TimeIn as DateTime.</summary>
            [TimeIn] = 2
            ''' <summary>(Set|Get) The Collaborateur as String.</summary>
            [Collaborateur] = 3
            ''' <summary>(Set|Get) The Mandat as String.</summary>
            [Mandat] = 4
            ''' <summary>(Set|Get) The Quantity as Double.</summary>
            [Quantity] = 5
            ''' <summary>(Set|Get) The UnitPrice as Double.</summary>
            [UnitPrice] = 6
            ''' <summary>(Set|Get) The Description as String.</summary>
            [Description] = 7
            ''' <summary>(Set|Get) The Facturable as Boolean.</summary>
            [Facturable] = 8
            ''' <summary>(Set|Get) The TotalHTVA as Double.</summary>
            [TotalHTVA] = 9
            ''' <summary>(Set|Get) The Total as Double.</summary>
            [Total] = 10
        End Enum
#End Region '(Set|Get) The enumeration of Schema.

#End Region
#Region "<4> [Sub]{5}"
#Region "[On] |2019/06/25 22h51:676| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
        '''    <Summary>
        '''     (Set|Get) This will reinitialize the class element.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:434 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will reinitialize the class element.")>
        Public Sub Clear()
            With Me
                .ID = 0
                .Active = False
                .TimeIn = New DateTime
                .Collaborateur = Nothing
                .Mandat = Nothing
                .Quantity = 0
                .UnitPrice = 0
                .Description = Nothing
                .Facturable = False
                .TotalHTVA = 0
                .Total = 0
            End With
        End Sub
#End Region '(Set|Get) This will reinitialize the class element.

#Region "[On] |2019/06/25 22h51:690| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
        '''    <Summary>
        '''     (Set|Get) This will reinitialize the variables of this class.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:434 </Published>
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
                    TableName = "TimeSheet"
                    Line = Connector.Line
                    UseSQL = False
                Else
                    FilePath = My.Settings.Db_TimeSheet_FilePath
                    Password = My.Settings.Db_TimeSheet_Password
                    Me.Line = My.Settings.Db_TimeSheet_Line
                    TableName = "TimeSheet"
                    UseSQL = False
                End If
            Else
                If IsNothing(FilePath) Then
                    FilePath = My.Settings.Db_TimeSheet_FilePath
                End If
                If FilePath.Length < 1 Then
                    FilePath = My.Settings.Db_TimeSheet_FilePath
                End If
                FilePath = My.Settings.Db_TimeSheet_FilePath
                Password = My.Settings.Db_TimeSheet_Password
                Me.Line = My.Settings.Db_TimeSheet_Line
                TableName = "TimeSheet"
                UseSQL = False
            End If

        End Sub
#End Region '(Set|Get) This will reinitialize the variables of this class.

#Region "[On] |2019/06/25 23h39:297| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
        '''    <Summary>
        '''     (Set|Get) This will add a new row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 23h39:177 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will add a new row in the table.")>
        Public Sub Add()
            Try
                Dim Str As String = Nothing
                Str = "Insert Into [TimeSheet] (
`ID`, 
`Active`, 
`TimeIn`, 
`Collaborateur`, 
`Mandat`, 
`Quantity`, 
`UnitPrice`, 
`Description`, 
`Facturable`, 
`TotalHTVA`, 
`Total`) Values (@0, @1, @2, @3, @4, @5, @6, @7, @8, @9, @10)"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@0", Me.ID)
                Cmd.Parameters.AddWithValue("@1", Me.Active)
                Cmd.Parameters.AddWithValue("@2", Me.TimeIn)
                Cmd.Parameters.AddWithValue("@3", Me.Collaborateur)
                Cmd.Parameters.AddWithValue("@4", Me.Mandat)
                Cmd.Parameters.AddWithValue("@5", Me.Quantity)
                Cmd.Parameters.AddWithValue("@6", Me.UnitPrice)
                Cmd.Parameters.AddWithValue("@7", Me.Description)
                Cmd.Parameters.AddWithValue("@8", Me.Facturable)
                Cmd.Parameters.AddWithValue("@9", Me.TotalHTVA)
                Cmd.Parameters.AddWithValue("@10", Me.Total)
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

#Region "[On] |2019/06/25 22h51:722| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
        '''    <Summary>
        '''     (Set|Get) This will update a row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:434 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will update a row in the table.")>
        Public Sub Save()
            Try
                Dim Str As String = Nothing
                Str = "UPDATE [TimeSheet] SET Active = @Active, TimeIn = @TimeIn, Collaborateur = @Collaborateur, Mandat = @Mandat, Quantity = @Quantity, UnitPrice = @UnitPrice, Description = @Description, Facturable = @Facturable, TotalHTVA = @TotalHTVA, Total = @Total WHERE ID = @ID"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@Active", Active)
                Cmd.Parameters.AddWithValue("@TimeIn", TimeIn)
                Cmd.Parameters.AddWithValue("@Collaborateur", Collaborateur)
                Cmd.Parameters.AddWithValue("@Mandat", Mandat)
                Cmd.Parameters.AddWithValue("@Quantity", Quantity)
                Cmd.Parameters.AddWithValue("@UnitPrice", UnitPrice)
                Cmd.Parameters.AddWithValue("@Description", Description)
                Cmd.Parameters.AddWithValue("@Facturable", Facturable)
                Cmd.Parameters.AddWithValue("@TotalHTVA", TotalHTVA)
                Cmd.Parameters.AddWithValue("@Total", Total)
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

#Region "[On] |2019/06/25 22h51:737| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
        '''    <Summary>
        '''     (Set|Get) This will Delete a row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:434 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will Delete a row in the table.")>
        Public Sub Delete()
            Try
                Dim Str As String = Nothing
                Str = "Delete From [TimeSheet] WHERE ID =@ID"
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
#Region "[On] |2019/06/25 22h51:751| <05.00.00> <Function> <> |.Open()|TestItem}|"' (Set|Get) This will initialise the connection and import the data.
        '''    <Summary>
        '''     (Set|Get) This will initialise the connection and import the data.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:434 </Published>
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

#Region "[On] |2019/06/25 22h51:764| <05.00.01> <Function> <> |.Close()|TestItem}|"' (Set|Get) This willClosing the connection
        '''    <Summary>
        '''     (Set|Get) This willClosing the connection
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:435 </Published>
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

#Region "[On] |2019/06/25 22h51:780| <05.00.02> <Function> <> |.List()|List(Of TimeSheet)}|"' (Set|Get) Return the entire table listed
        '''    <Summary>
        '''     (Set|Get) Return the entire table listed
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:435 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Return the entire table listed")>
        Public Function List() As List(Of TimeSheet)
            Dim Result As New List(Of TimeSheet)
            Me.Table = New Table(Me.TableName, Me.FilePath, Me.Password, False)
            For Each Row As DataRow In Me.Table.DataTable.Rows
                Dim Element As New TimeSheet(IIf(IsDBNull(Row.Item(0)), 0, Row.Item(0)),
IIf(IsDBNull(Row.Item(1)), False, Row.Item(1)),
IIf(IsDBNull(Row.Item(2)), New DateTime(1970, 1, 1), Row.Item(2)),
IIf(IsDBNull(Row.Item(3)), "", Row.Item(3)),
IIf(IsDBNull(Row.Item(4)), "", Row.Item(4)),
IIf(IsDBNull(Row.Item(5)), 0, Row.Item(5)),
IIf(IsDBNull(Row.Item(6)), 0, Row.Item(6)),
IIf(IsDBNull(Row.Item(7)), "", Row.Item(7)),
IIf(IsDBNull(Row.Item(8)), False, Row.Item(8)),
IIf(IsDBNull(Row.Item(9)), 0, Row.Item(9)),
  IIf(IsDBNull(Row.Item(10)), 0, Row.Item(10)))
                Element.Reset(Table.Line)
                Result.Add(Element)
            Next
            Return Result
        End Function
#End Region '(Set|Get) Return the entire table listed

#Region "[On] |2019/06/25 22h51:796| <05.00.03> <Function> <> |.SearchByName()|List(Of TimeSheet)}|"' (Set|Get) Search for each property that match the Search String.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search String.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:435 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Search for each property that match the Search String.")>
        Public Shared Function SearchByName(ByVal Search As String) As List(Of TimeSheet)
            Dim Result As New List(Of TimeSheet)
            Dim C As New TimeSheet
            For Each Element As TimeSheet In C.List
                If Element.Collaborateur.ToLower() = Search.ToLower() Or Element.Mandat.ToLower() = Search.ToLower() Or Element.Description.ToLower() = Search.ToLower() Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search String.

#Region "[On] |2019/06/25 22h51:811| <05.00.04> <Function> <> |.SearchByID()|List(Of TimeSheet)}|"' (Set|Get) Search for each property that match the Search Id.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search Id.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:435 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Search for each property that match the Search Id.")>
        Public Shared Function SearchByID(ByVal Search As Double) As List(Of TimeSheet)
            Dim Result As New List(Of TimeSheet)
            Dim C As New TimeSheet
            For Each Element As TimeSheet In C.List
                If Val(Element.ID) = Search Or Val(Element.Quantity) = Search Or Val(Element.UnitPrice) = Search Or Val(Element.TotalHTVA) = Search Or Val(Element.Total) = Search Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search Id.

#Region "[On] |2019/06/25 22h51:825| <05.00.05> <Function> <> |.ToString()|String}|"' (Set|Get) The function ToString.
        '''    <Summary>
        '''     (Set|Get) The function ToString.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:435 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The function ToString.")>
        Public Overrides Function ToString() As String
            Return Me.ID
        End Function
#End Region '(Set|Get) The function ToString.

#Region "[On] |2019/06/25 22h51:841| <05.00.06> <Function> <> |.CheckConnection()|Boolean}|"' (Set|Get) Evaluate the connection to the DataBase
        '''    <Summary>
        '''     (Set|Get) Evaluate the connection to the DataBase
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:435 </Published>
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
#Region "[On] |2019/06/07 20h20:654| <05.00.07> <Function> <> |.List(From|Date,EndDate|Date|Mandat|String)|List(Of TimeSheet)}|"' (Set|Get) List by Date and Mandat..
        '''    <Summary>
        '''      (Set|Get) List by Date and Mandat.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/07 20h21:547 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>

        <Browsable(True), Description("(Set|Get) List by Date and Mandat.")>
        Public Function List(ByVal From As Date, ByVal EndDate As Date, ByVal Mandat As String) As List(Of TimeSheet)
            Dim Result As New List(Of TimeSheet)
            Dim I As New TimeSheet
            I.Reset(New SmartCoder.M_FileManager.LineInfo(My.Settings.Db_TimeSheet_FilePath, My.Settings.Db_TimeSheet_Password))
            For Each T As TimeSheet In I.List()
                If T.TimeIn > From And T.TimeIn <= EndDate Then
                    If T.Mandat = Mandat Then
                        Result.Add(T)

                    End If
                End If
            Next

            Return Result
        End Function
#End Region '(Set|Get) List by Date and Mandat.

#End Region
#Region "<6> [Runtime]{12}"
#Region "[On] |2019/06/25 22h51:856| <15.00.00> <Runtime> <> |.Table()|Table"' (Set|Get) The Table.
        '''    <Summary>
        '''     (Set|Get) The Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:435 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Table.")>
        Public Table As Table
#End Region '(Set|Get) The Table.

#Region "[On] |2019/06/25 22h51:891| <15.00.01> <Runtime> <> |.Line()|String"' (Set|Get) The Connection String To the Table.
        '''    <Summary>
        '''     (Set|Get) The Connection String To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:436 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Connection String To the Table.")>
        Public Line As String
#End Region '(Set|Get) The Connection String To the Table.

#Region "[On] |2019/06/25 22h51:923| <15.00.02> <Runtime> <> |.FilePath()|String"' (Set|Get) The FilePath To the Table.
        '''    <Summary>
        '''     (Set|Get) The FilePath To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:436 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The FilePath To the Table.")>
        Public FilePath As String
#End Region '(Set|Get) The FilePath To the Table.

#Region "[On] |2019/06/25 22h51:954| <15.00.03> <Runtime> <> |.Password()|String"' (Set|Get) The Password To the Table.
        '''    <Summary>
        '''     (Set|Get) The Password To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:436 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Password To the Table.")>
        Public Password As String
#End Region '(Set|Get) The Password To the Table.

#Region "[On] |2019/06/25 22h51:991| <15.00.04> <Runtime> <> |.UseSQL()|Boolean"' (Set|Get) Determines if the Database Connection is of type SQL.
        '''    <Summary>
        '''     (Set|Get) Determines if the Database Connection is of type SQL.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:436 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Determines if the Database Connection is of type SQL.")>
        Public UseSQL As Boolean
#End Region '(Set|Get) Determines if the Database Connection is of type SQL.

#Region "[On] |2019/06/25 22h51:051| <15.00.05> <Runtime> <> |.TableName()|String"' (Set|Get) The name of the Table.
        '''    <Summary>
        '''     (Set|Get) The name of the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:436 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The name of the Table.")>
        Public TableName As String
#End Region '(Set|Get) The name of the Table.

#Region "[On] |2019/06/25 22h51:085| <15.00.06> <Runtime> <> |.Con()|OleDb.OleDbConnection"' (Set|Get) The Con To the Table.
        '''    <Summary>
        '''     (Set|Get) The Con To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:436 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Con To the Table.")>
        Public Con As OleDb.OleDbConnection
#End Region '(Set|Get) The Con To the Table.

#Region "[On] |2019/06/25 22h51:129| <15.00.07> <Runtime> <> |.Cmd()|OleDb.OleDbCommand"' (Set|Get) The Cmd To the Table.
        '''    <Summary>
        '''     (Set|Get) The Cmd To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:436 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Cmd To the Table.")>
        Public Cmd As OleDb.OleDbCommand
#End Region '(Set|Get) The Cmd To the Table.

#Region "[On] |2019/06/25 22h51:162| <15.00.08> <Runtime> <> |.DataReader()|OleDb.OleDbDataReader"' (Set|Get) The DataReader To the Table.
        '''    <Summary>
        '''     (Set|Get) The DataReader To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:437 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The DataReader To the Table.")>
        Public DataReader As OleDb.OleDbDataReader
#End Region '(Set|Get) The DataReader To the Table.

#Region "[On] |2019/06/25 22h51:193| <15.00.09> <Runtime> <> |.DataAdapter()|OleDb.OleDbDataAdapter"' (Set|Get) The DataAdapter To the Table.
        '''    <Summary>
        '''     (Set|Get) The DataAdapter To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:437 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The DataAdapter To the Table.")>
        Public DataAdapter As OleDb.OleDbDataAdapter
#End Region '(Set|Get) The DataAdapter To the Table.

#Region "[On] |2019/06/25 22h51:266| <15.00.10> <Runtime> <> |.Connector()|LineInfo"' (Set|Get) The Connector To the Table.
        '''    <Summary>
        '''     (Set|Get) The Connector To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:437 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Connector To the Table.")>
        Public Connector As LineInfo
#End Region '(Set|Get) The Connector To the Table.

#Region "[On] |2019/06/25 22h51:297| <15.00.11> <Runtime> <> |.Log()|String"' (Set|Get) The Log To the Table.
        '''    <Summary>
        '''     (Set|Get) The Log To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:437 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Log To the Table.")>
        Public Log As String
#End Region '(Set|Get) The Log To the Table.

#End Region
#Region "<7> [Loader]{2}"
#Region "[On] |2019/06/25 22h51:326| <06.00.00> <Loader> <> |.Empty()|Function}|"' (Set|Get) The sub Empty.
        '''    <Summary>
        '''     (Set|Get) The sub Empty.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:437 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The sub Empty.")>
        Public Sub New()
            Reset
        End Sub
#End Region '(Set|Get) The sub Empty.

#Region "[On] |2019/06/25 22h51:328| <06.00.01> <Loader> <> |.Filled()|Function}|"' (Set|Get) The sub Filled.
        '''    <Summary>
        '''     (Set|Get) The sub Filled.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:437 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>    ''' <param name="ID">(Set|Get) The ID as Integer.</param>
        ''' <param name="Active">(Set|Get) The Active as Boolean.</param>
        ''' <param name="TimeIn">(Set|Get) The TimeIn as DateTime.</param>
        ''' <param name="Collaborateur">(Set|Get) The Collaborateur as String.</param>
        ''' <param name="Mandat">(Set|Get) The Mandat as String.</param>
        ''' <param name="Quantity">(Set|Get) The Quantity as Double.</param>
        ''' <param name="UnitPrice">(Set|Get) The UnitPrice as Double.</param>
        ''' <param name="Description">(Set|Get) The Description as String.</param>
        ''' <param name="Facturable">(Set|Get) The Facturable as Boolean.</param>
        ''' <param name="TotalHTVA">(Set|Get) The TotalHTVA as Double.</param>
        ''' <param name="Total">(Set|Get) The Total as Double.</param>

        <Browsable(True), Description("(Set|Get) The sub Filled.")>
        Public Sub New(ByVal ID As Integer,
ByVal Active As Boolean,
ByVal TimeIn As DateTime,
ByVal Collaborateur As String,
ByVal Mandat As String,
ByVal Quantity As Double,
ByVal UnitPrice As Double,
ByVal Description As String,
ByVal Facturable As Boolean,
ByVal TotalHTVA As Double,
ByVal Total As Double)
            With Me
                Clear()
                Reset()
                .ID = ID
                .Active = Active
                .TimeIn = TimeIn
                .Collaborateur = Collaborateur
                .Mandat = Mandat
                .Quantity = Quantity
                .UnitPrice = UnitPrice
                .Description = Description
                .Facturable = Facturable
                .TotalHTVA = TotalHTVA
                .Total = Total
            End With

        End Sub
#End Region '(Set|Get) The sub Filled.

#End Region
    End Class
#End Region

#Region "[On] |2019/06/25 22h51:516| <08.00.00> <Class> <> |.Initializor_TimeSheet|Class|{30} |Production Cost : 24.6|Selling Price : 36.9|"' 
    '''    <Summary>
    '''     '''    Object Name :             Public  Class Initializor_TimeSheet
    '''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
    '''    Contributor Information : ||
    '''    Creation Date :           2019/06/25 22h51:516
    '''    |Schema|
    '''    |ID| |ObjectType |{Quantity}||UnitPrice||Total
    '''    |00| |Importation|{0}||1| |0
    '''    |01| |Properties |{22}||0.8| |17.6
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
    '''    |Production Cost             |24.6
    '''    |Selling Price without VAT   |36.9
    '''    |Total TVA                   |2.84
    '''    |Grand Total                 |39.74
    '''    |/Schema|
    '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
    '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
    '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
    '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:448 </Published>
    '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
    '''    </Summary>
    Public Class Initializor_TimeSheet
#Region "<1> [Property]{22}"
#Region "[On] |2019/06/25 22h51:517| <01.00.00> <Property> <Virtualized Properties> |.Clients()|Clients|"' (Set|Get) 
        Private _Clients As Clients
        '''    <Summary>
        '''     (Set|Get) 
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:448 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Virtualized Properties"), Description("(Set|Get) ")>
        Public Property Clients() As Clients
            Get
                Return _Clients
            End Get
            Set(ByVal Value As Clients)
                _Clients = Value
            End Set
        End Property
#End Region '(Set|Get) 

#Region "[On] |2019/06/25 22h51:528| <01.00.01> <Property> <List> |.List_Clients()|List(Of Clients)|"' (Set|Get) 
        Private _List_Clients As List(Of Clients)
        '''    <Summary>
        '''     (Set|Get) 
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:448 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("List"), Description("(Set|Get) ")>
        Public Property List_Clients() As List(Of Clients)
            Get
                Return _List_Clients
            End Get
            Set(ByVal Value As List(Of Clients))
                _List_Clients = Value
            End Set
        End Property
#End Region '(Set|Get) 

#Region "[On] |2019/06/25 22h51:540| <01.00.02> <Property> <Virtualized Properties> |.Collaborateur()|Collaborateur|"' (Set|Get) 
        Private _Collaborateur As Collaborateur
        '''    <Summary>
        '''     (Set|Get) 
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:448 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Virtualized Properties"), Description("(Set|Get) ")>
        Public Property Collaborateur() As Collaborateur
            Get
                Return _Collaborateur
            End Get
            Set(ByVal Value As Collaborateur)
                _Collaborateur = Value
            End Set
        End Property
#End Region '(Set|Get) 

#Region "[On] |2019/06/25 22h51:552| <01.00.03> <Property> <List> |.List_Collaborateur()|List(Of Collaborateur)|"' (Set|Get) 
        Private _List_Collaborateur As List(Of Collaborateur)
        '''    <Summary>
        '''     (Set|Get) 
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:448 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("List"), Description("(Set|Get) ")>
        Public Property List_Collaborateur() As List(Of Collaborateur)
            Get
                Return _List_Collaborateur
            End Get
            Set(ByVal Value As List(Of Collaborateur))
                _List_Collaborateur = Value
            End Set
        End Property
#End Region '(Set|Get) 

#Region "[On] |2019/06/25 22h51:563| <01.00.04> <Property> <Virtualized Properties> |.Factures()|Factures|"' (Set|Get) 
        Private _Factures As Factures
        '''    <Summary>
        '''     (Set|Get) 
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:449 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Virtualized Properties"), Description("(Set|Get) ")>
        Public Property Factures() As Factures
            Get
                Return _Factures
            End Get
            Set(ByVal Value As Factures)
                _Factures = Value
            End Set
        End Property
#End Region '(Set|Get) 

#Region "[On] |2019/06/25 22h51:575| <01.00.05> <Property> <List> |.List_Factures()|List(Of Factures)|"' (Set|Get) 
        Private _List_Factures As List(Of Factures)
        '''    <Summary>
        '''     (Set|Get) 
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:449 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("List"), Description("(Set|Get) ")>
        Public Property List_Factures() As List(Of Factures)
            Get
                Return _List_Factures
            End Get
            Set(ByVal Value As List(Of Factures))
                _List_Factures = Value
            End Set
        End Property
#End Region '(Set|Get) 

#Region "[On] |2019/06/25 22h51:586| <01.00.06> <Property> <Virtualized Properties> |.Factures_Entries()|Factures_Entries|"' (Set|Get) 
        Private _Factures_Entries As Factures_Entries
        '''    <Summary>
        '''     (Set|Get) 
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:449 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Virtualized Properties"), Description("(Set|Get) ")>
        Public Property Factures_Entries() As Factures_Entries
            Get
                Return _Factures_Entries
            End Get
            Set(ByVal Value As Factures_Entries)
                _Factures_Entries = Value
            End Set
        End Property
#End Region '(Set|Get) 

#Region "[On] |2019/06/25 22h51:597| <01.00.07> <Property> <List> |.List_Factures_Entries()|List(Of Factures_Entries)|"' (Set|Get) 
        Private _List_Factures_Entries As List(Of Factures_Entries)
        '''    <Summary>
        '''     (Set|Get) 
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:449 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("List"), Description("(Set|Get) ")>
        Public Property List_Factures_Entries() As List(Of Factures_Entries)
            Get
                Return _List_Factures_Entries
            End Get
            Set(ByVal Value As List(Of Factures_Entries))
                _List_Factures_Entries = Value
            End Set
        End Property
#End Region '(Set|Get) 

#Region "[On] |2019/06/25 22h51:609| <01.00.08> <Property> <Virtualized Properties> |.Prestation_Category()|Prestation_Category|"' (Set|Get) 
        Private _Prestation_Category As Prestation_Category
        '''    <Summary>
        '''     (Set|Get) 
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:449 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Virtualized Properties"), Description("(Set|Get) ")>
        Public Property Prestation_Category() As Prestation_Category
            Get
                Return _Prestation_Category
            End Get
            Set(ByVal Value As Prestation_Category)
                _Prestation_Category = Value
            End Set
        End Property
#End Region '(Set|Get) 

#Region "[On] |2019/06/25 22h51:621| <01.00.09> <Property> <List> |.List_Prestation_Category()|List(Of Prestation_Category)|"' (Set|Get) 
        Private _List_Prestation_Category As List(Of Prestation_Category)
        '''    <Summary>
        '''     (Set|Get) 
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:450 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("List"), Description("(Set|Get) ")>
        Public Property List_Prestation_Category() As List(Of Prestation_Category)
            Get
                Return _List_Prestation_Category
            End Get
            Set(ByVal Value As List(Of Prestation_Category))
                _List_Prestation_Category = Value
            End Set
        End Property
#End Region '(Set|Get) 

#Region "[On] |2019/06/25 22h51:634| <01.00.10> <Property> <Virtualized Properties> |.Prestations()|Prestations|"' (Set|Get) 
        Private _Prestations As Prestations
        '''    <Summary>
        '''     (Set|Get) 
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:450 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Virtualized Properties"), Description("(Set|Get) ")>
        Public Property Prestations() As Prestations
            Get
                Return _Prestations
            End Get
            Set(ByVal Value As Prestations)
                _Prestations = Value
            End Set
        End Property
#End Region '(Set|Get) 

#Region "[On] |2019/06/25 22h51:647| <01.00.11> <Property> <List> |.List_Prestations()|List(Of Prestations)|"' (Set|Get) 
        Private _List_Prestations As List(Of Prestations)
        '''    <Summary>
        '''     (Set|Get) 
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:450 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("List"), Description("(Set|Get) ")>
        Public Property List_Prestations() As List(Of Prestations)
            Get
                Return _List_Prestations
            End Get
            Set(ByVal Value As List(Of Prestations))
                _List_Prestations = Value
            End Set
        End Property
#End Region '(Set|Get) 

#Region "[On] |2019/06/25 22h51:660| <01.00.12> <Property> <Virtualized Properties> |.Services()|Services|"' (Set|Get) 
        Private _Services As Services
        '''    <Summary>
        '''     (Set|Get) 
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:450 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Virtualized Properties"), Description("(Set|Get) ")>
        Public Property Services() As Services
            Get
                Return _Services
            End Get
            Set(ByVal Value As Services)
                _Services = Value
            End Set
        End Property
#End Region '(Set|Get) 

#Region "[On] |2019/06/25 22h51:671| <01.00.13> <Property> <List> |.List_Services()|List(Of Services)|"' (Set|Get) 
        Private _List_Services As List(Of Services)
        '''    <Summary>
        '''     (Set|Get) 
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:450 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("List"), Description("(Set|Get) ")>
        Public Property List_Services() As List(Of Services)
            Get
                Return _List_Services
            End Get
            Set(ByVal Value As List(Of Services))
                _List_Services = Value
            End Set
        End Property
#End Region '(Set|Get) 

#Region "[On] |2019/06/25 22h51:688| <01.00.14> <Property> <Virtualized Properties> |.Sociétés()|Sociétés|"' (Set|Get) 
        Private _Sociétés As Sociétés
        '''    <Summary>
        '''     (Set|Get) 
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:451 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Virtualized Properties"), Description("(Set|Get) ")>
        Public Property Sociétés() As Sociétés
            Get
                Return _Sociétés
            End Get
            Set(ByVal Value As Sociétés)
                _Sociétés = Value
            End Set
        End Property
#End Region '(Set|Get) 

#Region "[On] |2019/06/25 22h51:700| <01.00.15> <Property> <List> |.List_Sociétés()|List(Of Sociétés)|"' (Set|Get) 
        Private _List_Sociétés As List(Of Sociétés)
        '''    <Summary>
        '''     (Set|Get) 
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:451 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("List"), Description("(Set|Get) ")>
        Public Property List_Sociétés() As List(Of Sociétés)
            Get
                Return _List_Sociétés
            End Get
            Set(ByVal Value As List(Of Sociétés))
                _List_Sociétés = Value
            End Set
        End Property
#End Region '(Set|Get) 

#Region "[On] |2019/06/25 22h51:714| <01.00.16> <Property> <Virtualized Properties> |.Tarif()|Tarif|"' (Set|Get) 
        Private _Tarif As Tarif
        '''    <Summary>
        '''     (Set|Get) 
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:451 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Virtualized Properties"), Description("(Set|Get) ")>
        Public Property Tarif() As Tarif
            Get
                Return _Tarif
            End Get
            Set(ByVal Value As Tarif)
                _Tarif = Value
            End Set
        End Property
#End Region '(Set|Get) 

#Region "[On] |2019/06/25 22h51:726| <01.00.17> <Property> <List> |.List_Tarif()|List(Of Tarif)|"' (Set|Get) 
        Private _List_Tarif As List(Of Tarif)
        '''    <Summary>
        '''     (Set|Get) 
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:451 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("List"), Description("(Set|Get) ")>
        Public Property List_Tarif() As List(Of Tarif)
            Get
                Return _List_Tarif
            End Get
            Set(ByVal Value As List(Of Tarif))
                _List_Tarif = Value
            End Set
        End Property
#End Region '(Set|Get) 

#Region "[On] |2019/06/25 22h51:739| <01.00.18> <Property> <Virtualized Properties> |.TimeSheet()|TimeSheet|"' (Set|Get) 
        Private _TimeSheet As TimeSheet
        '''    <Summary>
        '''     (Set|Get) 
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:452 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Virtualized Properties"), Description("(Set|Get) ")>
        Public Property TimeSheet() As TimeSheet
            Get
                Return _TimeSheet
            End Get
            Set(ByVal Value As TimeSheet)
                _TimeSheet = Value
            End Set
        End Property
#End Region '(Set|Get) 

#Region "[On] |2019/06/25 22h51:753| <01.00.19> <Property> <List> |.List_TimeSheet()|List(Of TimeSheet)|"' (Set|Get) 
        Private _List_TimeSheet As List(Of TimeSheet)
        '''    <Summary>
        '''     (Set|Get) 
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:452 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("List"), Description("(Set|Get) ")>
        Public Property List_TimeSheet() As List(Of TimeSheet)
            Get
                Return _List_TimeSheet
            End Get
            Set(ByVal Value As List(Of TimeSheet))
                _List_TimeSheet = Value
            End Set
        End Property
#End Region '(Set|Get) 

#Region "[On] |2019/06/25 22h51:767| <01.00.20> <Property> <Portfolio> |.Portfolio()|List(Of Object)|"' (Set|Get) 
        Private Shared _Portfolio As List(Of Object)
        '''    <Summary>
        '''     (Set|Get) 
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:452 </Published>
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

#Region "[On] |2019/06/25 22h51:779| <01.00.21> <Property> <DataBase> |.DataBase()|SmartCoder.M_FileManager.DataBase|"' (Set|Get) 
        Private Shared _DataBase As SmartCoder.M_FileManager.DataBase
        '''    <Summary>
        '''     (Set|Get) 
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:452 </Published>
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
#Region "[On] |2019/06/25 22h51:792| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class properties element.
        '''    <Summary>
        '''     (Set|Get) This will reinitialize the class properties element.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:454 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will reinitialize the class properties element.")>
        Public Sub Clear()
            With Me
                .Clients = New Clients
                .List_Clients = New List(Of Clients)
                .Collaborateur = New Collaborateur
                .List_Collaborateur = New List(Of Collaborateur)
                .Factures = New Factures
                .List_Factures = New List(Of Factures)
                .Factures_Entries = New Factures_Entries
                .List_Factures_Entries = New List(Of Factures_Entries)
                .Prestation_Category = New Prestation_Category
                .List_Prestation_Category = New List(Of Prestation_Category)
                .Prestations = New Prestations
                .List_Prestations = New List(Of Prestations)
                .Services = New Services
                .List_Services = New List(Of Services)
                .Sociétés = New Sociétés
                .List_Sociétés = New List(Of Sociétés)
                .Tarif = New Tarif
                .List_Tarif = New List(Of Tarif)
                .TimeSheet = New TimeSheet
                .List_TimeSheet = New List(Of TimeSheet)
                Portfolio = New List(Of Object)
                DataBase = New SmartCoder.M_FileManager.DataBase
            End With
        End Sub
#End Region '(Set|Get) This will reinitialize the class properties element.

#End Region
#Region "<5> [Function]{1}"
#Region "[On] |2019/06/25 22h51:806| <05.00.00> <Function> <> |.CheckConnection()|Boolean}|"' (Set|Get) Evaluate the connection to the DataBase
        '''    <Summary>
        '''     (Set|Get) Evaluate the connection to the DataBase
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:455 </Published>
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
#Region "[On] |2019/06/25 22h51:822| <15.00.00> <Runtime> <> |.Line()|String"' (Set|Get) The Connection String To the Table.
        '''    <Summary>
        '''     (Set|Get) The Connection String To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:455 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Connection String To the Table.")>
        Public Line As String
#End Region '(Set|Get) The Connection String To the Table.

#Region "[On] |2019/06/25 22h51:865| <15.00.01> <Runtime> <> |.FilePath()|String"' (Set|Get) The FilePath To the Table.
        '''    <Summary>
        '''     (Set|Get) The FilePath To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:455 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The FilePath To the Table.")>
        Public FilePath As String
#End Region '(Set|Get) The FilePath To the Table.

#Region "[On] |2019/06/25 22h51:896| <15.00.02> <Runtime> <> |.Password()|String"' (Set|Get) The Password To the Table.
        '''    <Summary>
        '''     (Set|Get) The Password To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:455 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Password To the Table.")>
        Public Password As String
#End Region '(Set|Get) The Password To the Table.

#Region "[On] |2019/06/25 22h51:925| <15.00.03> <Runtime> <> |.Connector()|LineInfo"' (Set|Get) The Connector To the Table.
        '''    <Summary>
        '''     (Set|Get) The Connector To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:455 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Connector To the Table.")>
        Public Connector As LineInfo
#End Region '(Set|Get) The Connector To the Table.

#End Region
#Region "<7> [Loader]{2}"
#Region "[On] |2019/06/25 22h51:954| <06.00.00> <Loader> <> |.Empty()|Function}|"' (Set|Get) The sub Empty.
        '''    <Summary>
        '''     (Set|Get) The sub Empty.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:455 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The sub Empty.")>
        Public Sub New()
            Clear
        End Sub
#End Region '(Set|Get) The sub Empty.

#Region "[On] |2019/06/25 22h51:957| <06.00.01> <Loader> <> |.Filled()|Function}|"' (Set|Get) The sub Filled.
        '''    <Summary>
        '''     (Set|Get) The sub Filled.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/06/25 22h52:455 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>    ''' <param name="FilePath">The initial File Path</param>
        ''' <param name="Password">The password</param>

        <Browsable(True), Description("(Set|Get) The sub Filled.")>
        Public Sub New(ByVal FilePath As String,
Optional ByVal Password As String = """")
            With Me
                Clear()
                .Clients = New Clients
                .List_Clients = New List(Of Clients)
                .Collaborateur = New Collaborateur
                .List_Collaborateur = New List(Of Collaborateur)
                .Factures = New Factures
                .List_Factures = New List(Of Factures)
                .Factures_Entries = New Factures_Entries
                .List_Factures_Entries = New List(Of Factures_Entries)
                .Prestation_Category = New Prestation_Category
                .List_Prestation_Category = New List(Of Prestation_Category)
                .Prestations = New Prestations
                .List_Prestations = New List(Of Prestations)
                .Services = New Services
                .List_Services = New List(Of Services)
                .Sociétés = New Sociétés
                .List_Sociétés = New List(Of Sociétés)
                .Tarif = New Tarif
                .List_Tarif = New List(Of Tarif)
                .TimeSheet = New TimeSheet
                .List_TimeSheet = New List(Of TimeSheet)
                Portfolio = New List(Of Object)
                DataBase = New SmartCoder.M_FileManager.DataBase
            End With
            Portfolio = New List(Of Object)
            FilePath = FilePath
            Password = Password
            Line = Line
            Dim M As New LineInfo(FilePath, Password)
            My.Settings.Db_TimeSheet_FilePath = FilePath
            My.Settings.Db_TimeSheet_Password = Password
            My.Settings.Db_TimeSheet_Line = Line
            My.Settings.Save
            With Clients
                .Reset(M)
            End With
            List_Clients = New List(Of Clients)
            List_Clients = Clients.List()
            With Collaborateur
                .Reset(M)
            End With
            List_Collaborateur = New List(Of Collaborateur)
            List_Collaborateur = Collaborateur.List()
            With Factures
                .Reset(M)
            End With
            List_Factures = New List(Of Factures)
            List_Factures = Factures.List()
            With Factures_Entries
                .Reset(M)
            End With
            List_Factures_Entries = New List(Of Factures_Entries)
            List_Factures_Entries = Factures_Entries.List()
            With Prestation_Category
                .Reset(M)
            End With
            List_Prestation_Category = New List(Of Prestation_Category)
            List_Prestation_Category = Prestation_Category.List()
            With Prestations
                .Reset(M)
            End With
            List_Prestations = New List(Of Prestations)
            List_Prestations = Prestations.List()
            With Services
                .Reset(M)
            End With
            List_Services = New List(Of Services)
            List_Services = Services.List()
            With Sociétés
                .Reset(M)
            End With
            List_Sociétés = New List(Of Sociétés)
            List_Sociétés = Sociétés.List()
            With Tarif
                .Reset(M)
            End With
            List_Tarif = New List(Of Tarif)
            List_Tarif = Tarif.List()
            With TimeSheet
                .Reset(M)
            End With
            List_TimeSheet = New List(Of TimeSheet)
            List_TimeSheet = TimeSheet.List()

        End Sub
#End Region '(Set|Get) The sub Filled.

#End Region
    End Class
#End Region

#End Region
#End Region


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

End Module
