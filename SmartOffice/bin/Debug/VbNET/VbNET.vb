#Region"[On] |2019/07/06 00h51:124| <08.00.00> <Class> <> |.VbNET|Class|{7} |Production Cost : 875.2|Selling Price : 2188|"' 
'''    <Summary>
'''     '''    Object Name :             Public  Class VbNET
'''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
'''    Contributor Information : ||
'''    Creation Date :           2019/07/06 00h51:124
'''    |Schema|
'''    |ID| |ObjectType |{Quantity}||UnitPrice||Total
'''    |00| |Importation|{0}||1| |0
'''    |01| |Properties |{394}||0.8| |315.2
'''    |02| |Enumeration|{6}||0.4| |2.4
'''    |03| |Structure  |{0}||0.4| |0
'''    |04| |Sub        |{31}||1.2| |37.2
'''    |05| |Function   |{43}||1.6| |68.8
'''    |06| |Runtime    |{76}||0.4| |30.4
'''    |07| |Loader     |{14}||0.8| |11.2
'''    |08| |Class      |{7}||2| |14
'''    |09| |Constante  |{0}||0.4| |0
'''    |10| |Event      |{0}||1.2| |0
'''    |11| |Members    |{380}||0.5| |190
'''    |12| |Parameter  |{412}||0.5| |206
'''    |Production Cost             |875.2
'''    |Selling Price without VAT   |2188
'''    |Total TVA                   |168.48
'''    |Grand Total                 |2356.48
'''    |/Schema|
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:799 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
Public  Class VbNET
#Region"[On] |2019/07/06 00h51:124| <08.00.00> <Class> <> |.VbNET|Class|"' 
#Region"[On] |2019/07/06 00h51:736| <08.00.00> <Class> <> |.Enumeration|Class|{87} |Production Cost : 134.5|Selling Price : 336.25|"' Class created automatically by SmartOffice (c)Copyright 2019.
'''    <Summary>
'''     Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Enumeration
'''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
'''    Contributor Information : ||
'''    Creation Date :           2019/07/06 00h51:736
'''    |Schema|
'''    |ID| |ObjectType |{Quantity}||UnitPrice||Total
'''    |00| |Importation|{0}||1| |0
'''    |01| |Properties |{60}||0.8| |48
'''    |02| |Enumeration|{1}||0.4| |0.4
'''    |03| |Structure  |{0}||0.4| |0
'''    |04| |Sub        |{5}||1.2| |6
'''    |05| |Function   |{7}||1.6| |11.2
'''    |06| |Runtime    |{12}||0.4| |4.8
'''    |07| |Loader     |{2}||0.8| |1.6
'''    |08| |Class      |{0}||2| |0
'''    |09| |Constante  |{0}||0.4| |0
'''    |10| |Event      |{0}||1.2| |0
'''    |11| |Members    |{60}||0.5| |30
'''    |12| |Parameter  |{65}||0.5| |32.5
'''    |Production Cost             |134.5
'''    |Selling Price without VAT   |336.25
'''    |Total TVA                   |25.89
'''    |Grand Total                 |362.14
'''    |/Schema|
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:799 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
Public  Class Enumeration
#Region "<1> [Property]{60}"
#Region"[On] |2019/07/06 00h51:738| <01.00.00> <Property> <Columns> |.ID()|Integer|"' (Set|Get) The ID as Integer.
   Private _ID As Integer
    '''    <Summary>
'''     (Set|Get) The ID as Integer.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:799 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ID as Integer.") >
   Public Property ID()As Integer
       Get
       Return _ID
       End Get
       Set(ByVal Value As Integer)
       _ID = Value
       End Set
   End Property
#End Region '(Set|Get) The ID as Integer.

#Region"[On] |2019/07/06 00h51:860| <01.00.01> <Property> <Columns> |.Name()|String|"' (Set|Get) The Name as String.
   Private _Name As String
    '''    <Summary>
'''     (Set|Get) The Name as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:799 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Name as String.") >
   Public Property Name()As String
       Get
       Return _Name
       End Get
       Set(ByVal Value As String)
       _Name = Value
       End Set
   End Property
#End Region '(Set|Get) The Name as String.

#Region"[On] |2019/07/06 00h51:875| <01.00.02> <Property> <Columns> |.ImageIndex()|Integer|"' (Set|Get) The ImageIndex as Integer.
   Private _ImageIndex As Integer
    '''    <Summary>
'''     (Set|Get) The ImageIndex as Integer.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:800 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ImageIndex as Integer.") >
   Public Property ImageIndex()As Integer
       Get
       Return _ImageIndex
       End Get
       Set(ByVal Value As Integer)
       _ImageIndex = Value
       End Set
   End Property
#End Region '(Set|Get) The ImageIndex as Integer.

#Region"[On] |2019/07/06 00h51:885| <01.00.03> <Property> <Columns> |.Text()|String|"' (Set|Get) The Text as String.
   Private _Text As String
    '''    <Summary>
'''     (Set|Get) The Text as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:800 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Text as String.") >
   Public Property Text()As String
       Get
       Return _Text
       End Get
       Set(ByVal Value As String)
       _Text = Value
       End Set
   End Property
#End Region '(Set|Get) The Text as String.

#Region"[On] |2019/07/06 00h51:895| <01.00.04> <Property> <Columns> |.ToolTip()|String|"' (Set|Get) The ToolTip as String.
   Private _ToolTip As String
    '''    <Summary>
'''     (Set|Get) The ToolTip as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:800 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ToolTip as String.") >
   Public Property ToolTip()As String
       Get
       Return _ToolTip
       End Get
       Set(ByVal Value As String)
       _ToolTip = Value
       End Set
   End Property
#End Region '(Set|Get) The ToolTip as String.

#Region"[On] |2019/07/06 00h51:906| <01.00.05> <Property> <Columns> |.Enable()|Boolean|"' (Set|Get) The Enable as Boolean.
   Private _Enable As Boolean
    '''    <Summary>
'''     (Set|Get) The Enable as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:800 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Enable as Boolean.") >
   Public Property Enable()As Boolean
       Get
       Return _Enable
       End Get
       Set(ByVal Value As Boolean)
       _Enable = Value
       End Set
   End Property
#End Region '(Set|Get) The Enable as Boolean.

#Region"[On] |2019/07/06 00h51:917| <01.00.06> <Property> <Columns> |.Status()|String|"' (Set|Get) The Status as String.
   Private _Status As String
    '''    <Summary>
'''     (Set|Get) The Status as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:800 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Status as String.") >
   Public Property Status()As String
       Get
       Return _Status
       End Get
       Set(ByVal Value As String)
       _Status = Value
       End Set
   End Property
#End Region '(Set|Get) The Status as String.

#Region"[On] |2019/07/06 00h51:928| <01.00.07> <Property> <Columns> |.Statement()|String|"' (Set|Get) The Statement as String.
   Private _Statement As String
    '''    <Summary>
'''     (Set|Get) The Statement as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:800 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Statement as String.") >
   Public Property Statement()As String
       Get
       Return _Statement
       End Get
       Set(ByVal Value As String)
       _Statement = Value
       End Set
   End Property
#End Region '(Set|Get) The Statement as String.

#Region"[On] |2019/07/06 00h51:938| <01.00.08> <Property> <Columns> |.XMLFile()|String|"' (Set|Get) The XMLFile as String.
   Private _XMLFile As String
    '''    <Summary>
'''     (Set|Get) The XMLFile as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:801 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XMLFile as String.") >
   Public Property XMLFile()As String
       Get
       Return _XMLFile
       End Get
       Set(ByVal Value As String)
       _XMLFile = Value
       End Set
   End Property
#End Region '(Set|Get) The XMLFile as String.

#Region"[On] |2019/07/06 00h51:950| <01.00.09> <Property> <Columns> |.Attributes()|String|"' (Set|Get) The Attributes as String.
   Private _Attributes As String
    '''    <Summary>
'''     (Set|Get) The Attributes as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:801 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Attributes as String.") >
   Public Property Attributes()As String
       Get
       Return _Attributes
       End Get
       Set(ByVal Value As String)
       _Attributes = Value
       End Set
   End Property
#End Region '(Set|Get) The Attributes as String.

#Region"[On] |2019/07/06 00h51:960| <01.00.10> <Property> <Columns> |.Browsable()|Boolean|"' (Set|Get) The Browsable as Boolean.
   Private _Browsable As Boolean
    '''    <Summary>
'''     (Set|Get) The Browsable as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:801 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Browsable as Boolean.") >
   Public Property Browsable()As Boolean
       Get
       Return _Browsable
       End Get
       Set(ByVal Value As Boolean)
       _Browsable = Value
       End Set
   End Property
#End Region '(Set|Get) The Browsable as Boolean.

#Region"[On] |2019/07/06 00h51:970| <01.00.11> <Property> <Columns> |.Category()|String|"' (Set|Get) The Category as String.
   Private _Category As String
    '''    <Summary>
'''     (Set|Get) The Category as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:801 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Category as String.") >
   Public Property Category()As String
       Get
       Return _Category
       End Get
       Set(ByVal Value As String)
       _Category = Value
       End Set
   End Property
#End Region '(Set|Get) The Category as String.

#Region"[On] |2019/07/06 00h51:984| <01.00.12> <Property> <Columns> |.Description()|String|"' (Set|Get) The Description as String.
   Private _Description As String
    '''    <Summary>
'''     (Set|Get) The Description as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:801 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Description as String.") >
   Public Property Description()As String
       Get
       Return _Description
       End Get
       Set(ByVal Value As String)
       _Description = Value
       End Set
   End Property
#End Region '(Set|Get) The Description as String.

#Region"[On] |2019/07/06 00h51:995| <01.00.13> <Property> <Columns> |.DefaultValue()|String|"' (Set|Get) The DefaultValue as String.
   Private _DefaultValue As String
    '''    <Summary>
'''     (Set|Get) The DefaultValue as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:802 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The DefaultValue as String.") >
   Public Property DefaultValue()As String
       Get
       Return _DefaultValue
       End Get
       Set(ByVal Value As String)
       _DefaultValue = Value
       End Set
   End Property
#End Region '(Set|Get) The DefaultValue as String.

#Region"[On] |2019/07/06 00h51:006| <01.00.14> <Property> <Columns> |.Editor()|String|"' (Set|Get) The Editor as String.
   Private _Editor As String
    '''    <Summary>
'''     (Set|Get) The Editor as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:802 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Editor as String.") >
   Public Property Editor()As String
       Get
       Return _Editor
       End Get
       Set(ByVal Value As String)
       _Editor = Value
       End Set
   End Property
#End Region '(Set|Get) The Editor as String.

#Region"[On] |2019/07/06 00h51:017| <01.00.15> <Property> <Columns> |.DllImport()|String|"' (Set|Get) The DllImport as String.
   Private _DllImport As String
    '''    <Summary>
'''     (Set|Get) The DllImport as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:802 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The DllImport as String.") >
   Public Property DllImport()As String
       Get
       Return _DllImport
       End Get
       Set(ByVal Value As String)
       _DllImport = Value
       End Set
   End Property
#End Region '(Set|Get) The DllImport as String.

#Region"[On] |2019/07/06 00h51:028| <01.00.16> <Property> <Columns> |.Deserializable()|Boolean|"' (Set|Get) The Deserializable as Boolean.
   Private _Deserializable As Boolean
    '''    <Summary>
'''     (Set|Get) The Deserializable as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:804 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Deserializable as Boolean.") >
   Public Property Deserializable()As Boolean
       Get
       Return _Deserializable
       End Get
       Set(ByVal Value As Boolean)
       _Deserializable = Value
       End Set
   End Property
#End Region '(Set|Get) The Deserializable as Boolean.

#Region"[On] |2019/07/06 00h51:040| <01.00.17> <Property> <Columns> |.NonSerialized()|Boolean|"' (Set|Get) The NonSerialized as Boolean.
   Private _NonSerialized As Boolean
    '''    <Summary>
'''     (Set|Get) The NonSerialized as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:804 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The NonSerialized as Boolean.") >
   Public Property NonSerialized()As Boolean
       Get
       Return _NonSerialized
       End Get
       Set(ByVal Value As Boolean)
       _NonSerialized = Value
       End Set
   End Property
#End Region '(Set|Get) The NonSerialized as Boolean.

#Region"[On] |2019/07/06 00h51:051| <01.00.18> <Property> <Columns> |.Serializable()|Boolean|"' (Set|Get) The Serializable as Boolean.
   Private _Serializable As Boolean
    '''    <Summary>
'''     (Set|Get) The Serializable as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:804 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Serializable as Boolean.") >
   Public Property Serializable()As Boolean
       Get
       Return _Serializable
       End Get
       Set(ByVal Value As Boolean)
       _Serializable = Value
       End Set
   End Property
#End Region '(Set|Get) The Serializable as Boolean.

#Region"[On] |2019/07/06 00h51:063| <01.00.19> <Property> <Columns> |.XmlRoot()|String|"' (Set|Get) The XmlRoot as String.
   Private _XmlRoot As String
    '''    <Summary>
'''     (Set|Get) The XmlRoot as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:804 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XmlRoot as String.") >
   Public Property XmlRoot()As String
       Get
       Return _XmlRoot
       End Get
       Set(ByVal Value As String)
       _XmlRoot = Value
       End Set
   End Property
#End Region '(Set|Get) The XmlRoot as String.

#Region"[On] |2019/07/06 00h51:074| <01.00.20> <Property> <Columns> |.XmlIgnore()|Boolean|"' (Set|Get) The XmlIgnore as Boolean.
   Private _XmlIgnore As Boolean
    '''    <Summary>
'''     (Set|Get) The XmlIgnore as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:805 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XmlIgnore as Boolean.") >
   Public Property XmlIgnore()As Boolean
       Get
       Return _XmlIgnore
       End Get
       Set(ByVal Value As Boolean)
       _XmlIgnore = Value
       End Set
   End Property
#End Region '(Set|Get) The XmlIgnore as Boolean.

#Region"[On] |2019/07/06 00h51:085| <01.00.21> <Property> <Columns> |.XmlInclude()|Boolean|"' (Set|Get) The XmlInclude as Boolean.
   Private _XmlInclude As Boolean
    '''    <Summary>
'''     (Set|Get) The XmlInclude as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:805 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XmlInclude as Boolean.") >
   Public Property XmlInclude()As Boolean
       Get
       Return _XmlInclude
       End Get
       Set(ByVal Value As Boolean)
       _XmlInclude = Value
       End Set
   End Property
#End Region '(Set|Get) The XmlInclude as Boolean.

#Region"[On] |2019/07/06 00h51:097| <01.00.22> <Property> <Columns> |.RelatedImageList()|String|"' (Set|Get) The RelatedImageList as String.
   Private _RelatedImageList As String
    '''    <Summary>
'''     (Set|Get) The RelatedImageList as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:805 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The RelatedImageList as String.") >
   Public Property RelatedImageList()As String
       Get
       Return _RelatedImageList
       End Get
       Set(ByVal Value As String)
       _RelatedImageList = Value
       End Set
   End Property
#End Region '(Set|Get) The RelatedImageList as String.

#Region"[On] |2019/07/06 00h51:109| <01.00.23> <Property> <Columns> |.Print_VB()|String|"' (Set|Get) The Print_VB as String.
   Private _Print_VB As String
    '''    <Summary>
'''     (Set|Get) The Print_VB as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:805 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_VB as String.") >
   Public Property Print_VB()As String
       Get
       Return _Print_VB
       End Get
       Set(ByVal Value As String)
       _Print_VB = Value
       End Set
   End Property
#End Region '(Set|Get) The Print_VB as String.

#Region"[On] |2019/07/06 00h51:126| <01.00.24> <Property> <Columns> |.VB()|String|"' (Set|Get) The VB as String.
   Private _VB As String
    '''    <Summary>
'''     (Set|Get) The VB as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:805 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The VB as String.") >
   Public Property VB()As String
       Get
       Return _VB
       End Get
       Set(ByVal Value As String)
       _VB = Value
       End Set
   End Property
#End Region '(Set|Get) The VB as String.

#Region"[On] |2019/07/06 00h51:137| <01.00.25> <Property> <Columns> |.Print_C()|String|"' (Set|Get) The Print_C as String.
   Private _Print_C As String
    '''    <Summary>
'''     (Set|Get) The Print_C as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:806 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_C as String.") >
   Public Property Print_C()As String
       Get
       Return _Print_C
       End Get
       Set(ByVal Value As String)
       _Print_C = Value
       End Set
   End Property
#End Region '(Set|Get) The Print_C as String.

#Region"[On] |2019/07/06 00h51:149| <01.00.26> <Property> <Columns> |.C()|String|"' (Set|Get) The C as String.
   Private _C As String
    '''    <Summary>
'''     (Set|Get) The C as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:806 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The C as String.") >
   Public Property C()As String
       Get
       Return _C
       End Get
       Set(ByVal Value As String)
       _C = Value
       End Set
   End Property
#End Region '(Set|Get) The C as String.

#Region"[On] |2019/07/06 00h51:160| <01.00.27> <Property> <Columns> |.Print_F()|String|"' (Set|Get) The Print_F as String.
   Private _Print_F As String
    '''    <Summary>
'''     (Set|Get) The Print_F as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:806 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_F as String.") >
   Public Property Print_F()As String
       Get
       Return _Print_F
       End Get
       Set(ByVal Value As String)
       _Print_F = Value
       End Set
   End Property
#End Region '(Set|Get) The Print_F as String.

#Region"[On] |2019/07/06 00h51:171| <01.00.28> <Property> <Columns> |.F()|String|"' (Set|Get) The F as String.
   Private _F As String
    '''    <Summary>
'''     (Set|Get) The F as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:806 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The F as String.") >
   Public Property F()As String
       Get
       Return _F
       End Get
       Set(ByVal Value As String)
       _F = Value
       End Set
   End Property
#End Region '(Set|Get) The F as String.

#Region"[On] |2019/07/06 00h51:183| <01.00.29> <Property> <Columns> |.Print_Python()|String|"' (Set|Get) The Print_Python as String.
   Private _Print_Python As String
    '''    <Summary>
'''     (Set|Get) The Print_Python as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:806 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_Python as String.") >
   Public Property Print_Python()As String
       Get
       Return _Print_Python
       End Get
       Set(ByVal Value As String)
       _Print_Python = Value
       End Set
   End Property
#End Region '(Set|Get) The Print_Python as String.

#Region"[On] |2019/07/06 00h51:195| <01.00.30> <Property> <Columns> |.Python()|String|"' (Set|Get) The Python as String.
   Private _Python As String
    '''    <Summary>
'''     (Set|Get) The Python as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:807 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Python as String.") >
   Public Property Python()As String
       Get
       Return _Python
       End Get
       Set(ByVal Value As String)
       _Python = Value
       End Set
   End Property
#End Region '(Set|Get) The Python as String.

#Region"[On] |2019/07/06 00h51:207| <01.00.31> <Property> <Columns> |.Print_JavaScript()|String|"' (Set|Get) The Print_JavaScript as String.
   Private _Print_JavaScript As String
    '''    <Summary>
'''     (Set|Get) The Print_JavaScript as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:807 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_JavaScript as String.") >
   Public Property Print_JavaScript()As String
       Get
       Return _Print_JavaScript
       End Get
       Set(ByVal Value As String)
       _Print_JavaScript = Value
       End Set
   End Property
#End Region '(Set|Get) The Print_JavaScript as String.

#Region"[On] |2019/07/06 00h51:220| <01.00.32> <Property> <Columns> |.JavaScript()|String|"' (Set|Get) The JavaScript as String.
   Private _JavaScript As String
    '''    <Summary>
'''     (Set|Get) The JavaScript as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:807 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The JavaScript as String.") >
   Public Property JavaScript()As String
       Get
       Return _JavaScript
       End Get
       Set(ByVal Value As String)
       _JavaScript = Value
       End Set
   End Property
#End Region '(Set|Get) The JavaScript as String.

#Region"[On] |2019/07/06 00h51:232| <01.00.33> <Property> <Columns> |.RegionCategory()|Integer|"' (Set|Get) The RegionCategory as Integer.
   Private _RegionCategory As Integer
    '''    <Summary>
'''     (Set|Get) The RegionCategory as Integer.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:807 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The RegionCategory as Integer.") >
   Public Property RegionCategory()As Integer
       Get
       Return _RegionCategory
       End Get
       Set(ByVal Value As Integer)
       _RegionCategory = Value
       End Set
   End Property
#End Region '(Set|Get) The RegionCategory as Integer.

#Region"[On] |2019/07/06 00h51:244| <01.00.34> <Property> <Columns> |.RegionCode()|String|"' (Set|Get) The RegionCode as String.
   Private _RegionCode As String
    '''    <Summary>
'''     (Set|Get) The RegionCode as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:807 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The RegionCode as String.") >
   Public Property RegionCode()As String
       Get
       Return _RegionCode
       End Get
       Set(ByVal Value As String)
       _RegionCode = Value
       End Set
   End Property
#End Region '(Set|Get) The RegionCode as String.

#Region"[On] |2019/07/06 00h51:255| <01.00.35> <Property> <Columns> |.AuthorEmail()|String|"' (Set|Get) The AuthorEmail as String.
   Private _AuthorEmail As String
    '''    <Summary>
'''     (Set|Get) The AuthorEmail as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:808 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AuthorEmail as String.") >
   Public Property AuthorEmail()As String
       Get
       Return _AuthorEmail
       End Get
       Set(ByVal Value As String)
       _AuthorEmail = Value
       End Set
   End Property
#End Region '(Set|Get) The AuthorEmail as String.

#Region"[On] |2019/07/06 00h51:267| <01.00.36> <Property> <Columns> |.AuthorName()|String|"' (Set|Get) The AuthorName as String.
   Private _AuthorName As String
    '''    <Summary>
'''     (Set|Get) The AuthorName as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:808 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AuthorName as String.") >
   Public Property AuthorName()As String
       Get
       Return _AuthorName
       End Get
       Set(ByVal Value As String)
       _AuthorName = Value
       End Set
   End Property
#End Region '(Set|Get) The AuthorName as String.

#Region"[On] |2019/07/06 00h51:279| <01.00.37> <Property> <Columns> |.AuthorUri()|String|"' (Set|Get) The AuthorUri as String.
   Private _AuthorUri As String
    '''    <Summary>
'''     (Set|Get) The AuthorUri as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:808 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AuthorUri as String.") >
   Public Property AuthorUri()As String
       Get
       Return _AuthorUri
       End Get
       Set(ByVal Value As String)
       _AuthorUri = Value
       End Set
   End Property
#End Region '(Set|Get) The AuthorUri as String.

#Region"[On] |2019/07/06 00h51:303| <01.00.38> <Property> <Columns> |.ContributorEmail()|String|"' (Set|Get) The ContributorEmail as String.
   Private _ContributorEmail As String
    '''    <Summary>
'''     (Set|Get) The ContributorEmail as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:808 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ContributorEmail as String.") >
   Public Property ContributorEmail()As String
       Get
       Return _ContributorEmail
       End Get
       Set(ByVal Value As String)
       _ContributorEmail = Value
       End Set
   End Property
#End Region '(Set|Get) The ContributorEmail as String.

#Region"[On] |2019/07/06 00h51:315| <01.00.39> <Property> <Columns> |.ContributorName()|String|"' (Set|Get) The ContributorName as String.
   Private _ContributorName As String
    '''    <Summary>
'''     (Set|Get) The ContributorName as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:808 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ContributorName as String.") >
   Public Property ContributorName()As String
       Get
       Return _ContributorName
       End Get
       Set(ByVal Value As String)
       _ContributorName = Value
       End Set
   End Property
#End Region '(Set|Get) The ContributorName as String.

#Region"[On] |2019/07/06 00h51:327| <01.00.40> <Property> <Columns> |.ContributorUri()|String|"' (Set|Get) The ContributorUri as String.
   Private _ContributorUri As String
    '''    <Summary>
'''     (Set|Get) The ContributorUri as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:809 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ContributorUri as String.") >
   Public Property ContributorUri()As String
       Get
       Return _ContributorUri
       End Get
       Set(ByVal Value As String)
       _ContributorUri = Value
       End Set
   End Property
#End Region '(Set|Get) The ContributorUri as String.

#Region"[On] |2019/07/06 00h51:340| <01.00.41> <Property> <Columns> |.CustomProperty()|String|"' (Set|Get) The CustomProperty as String.
   Private _CustomProperty As String
    '''    <Summary>
'''     (Set|Get) The CustomProperty as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:809 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The CustomProperty as String.") >
   Public Property CustomProperty()As String
       Get
       Return _CustomProperty
       End Get
       Set(ByVal Value As String)
       _CustomProperty = Value
       End Set
   End Property
#End Region '(Set|Get) The CustomProperty as String.

#Region"[On] |2019/07/06 00h51:353| <01.00.42> <Property> <Columns> |.Published()|String|"' (Set|Get) The Published as String.
   Private _Published As String
    '''    <Summary>
'''     (Set|Get) The Published as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:809 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Published as String.") >
   Public Property Published()As String
       Get
       Return _Published
       End Get
       Set(ByVal Value As String)
       _Published = Value
       End Set
   End Property
#End Region '(Set|Get) The Published as String.

#Region"[On] |2019/07/06 00h51:366| <01.00.43> <Property> <Columns> |.Rights()|String|"' (Set|Get) The Rights as String.
   Private _Rights As String
    '''    <Summary>
'''     (Set|Get) The Rights as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:810 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Rights as String.") >
   Public Property Rights()As String
       Get
       Return _Rights
       End Get
       Set(ByVal Value As String)
       _Rights = Value
       End Set
   End Property
#End Region '(Set|Get) The Rights as String.

#Region"[On] |2019/07/06 00h51:378| <01.00.44> <Property> <Columns> |.Summary()|String|"' (Set|Get) The Summary as String.
   Private _Summary As String
    '''    <Summary>
'''     (Set|Get) The Summary as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:810 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Summary as String.") >
   Public Property Summary()As String
       Get
       Return _Summary
       End Get
       Set(ByVal Value As String)
       _Summary = Value
       End Set
   End Property
#End Region '(Set|Get) The Summary as String.

#Region"[On] |2019/07/06 00h51:391| <01.00.45> <Property> <Columns> |.Title()|String|"' (Set|Get) The Title as String.
   Private _Title As String
    '''    <Summary>
'''     (Set|Get) The Title as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:810 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Title as String.") >
   Public Property Title()As String
       Get
       Return _Title
       End Get
       Set(ByVal Value As String)
       _Title = Value
       End Set
   End Property
#End Region '(Set|Get) The Title as String.

#Region"[On] |2019/07/06 00h51:404| <01.00.46> <Property> <Columns> |.Updated()|String|"' (Set|Get) The Updated as String.
   Private _Updated As String
    '''    <Summary>
'''     (Set|Get) The Updated as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:810 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Updated as String.") >
   Public Property Updated()As String
       Get
       Return _Updated
       End Get
       Set(ByVal Value As String)
       _Updated = Value
       End Set
   End Property
#End Region '(Set|Get) The Updated as String.

#Region"[On] |2019/07/06 00h51:417| <01.00.47> <Property> <Columns> |.Usage()|String|"' (Set|Get) The Usage as String.
   Private _Usage As String
    '''    <Summary>
'''     (Set|Get) The Usage as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:811 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Usage as String.") >
   Public Property Usage()As String
       Get
       Return _Usage
       End Get
       Set(ByVal Value As String)
       _Usage = Value
       End Set
   End Property
#End Region '(Set|Get) The Usage as String.

#Region"[On] |2019/07/06 00h51:430| <01.00.48> <Property> <Columns> |.Remarks()|String|"' (Set|Get) The Remarks as String.
   Private _Remarks As String
    '''    <Summary>
'''     (Set|Get) The Remarks as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:811 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Remarks as String.") >
   Public Property Remarks()As String
       Get
       Return _Remarks
       End Get
       Set(ByVal Value As String)
       _Remarks = Value
       End Set
   End Property
#End Region '(Set|Get) The Remarks as String.

#Region"[On] |2019/07/06 00h51:444| <01.00.49> <Property> <Columns> |.Example()|String|"' (Set|Get) The Example as String.
   Private _Example As String
    '''    <Summary>
'''     (Set|Get) The Example as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:811 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Example as String.") >
   Public Property Example()As String
       Get
       Return _Example
       End Get
       Set(ByVal Value As String)
       _Example = Value
       End Set
   End Property
#End Region '(Set|Get) The Example as String.

#Region"[On] |2019/07/06 00h51:461| <01.00.50> <Property> <Columns> |.Note()|String|"' (Set|Get) The Note as String.
   Private _Note As String
    '''    <Summary>
'''     (Set|Get) The Note as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:812 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Note as String.") >
   Public Property Note()As String
       Get
       Return _Note
       End Get
       Set(ByVal Value As String)
       _Note = Value
       End Set
   End Property
#End Region '(Set|Get) The Note as String.

#Region"[On] |2019/07/06 00h51:476| <01.00.51> <Property> <Columns> |.CreationDate()|String|"' (Set|Get) The CreationDate as String.
   Private _CreationDate As String
    '''    <Summary>
'''     (Set|Get) The CreationDate as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:812 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The CreationDate as String.") >
   Public Property CreationDate()As String
       Get
       Return _CreationDate
       End Get
       Set(ByVal Value As String)
       _CreationDate = Value
       End Set
   End Property
#End Region '(Set|Get) The CreationDate as String.

#Region"[On] |2019/07/06 00h51:489| <01.00.52> <Property> <Columns> |.See()|String|"' (Set|Get) The See as String.
   Private _See As String
    '''    <Summary>
'''     (Set|Get) The See as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:812 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The See as String.") >
   Public Property See()As String
       Get
       Return _See
       End Get
       Set(ByVal Value As String)
       _See = Value
       End Set
   End Property
#End Region '(Set|Get) The See as String.

#Region"[On] |2019/07/06 00h51:502| <01.00.53> <Property> <Columns> |.SeeAlso()|String|"' (Set|Get) The SeeAlso as String.
   Private _SeeAlso As String
    '''    <Summary>
'''     (Set|Get) The SeeAlso as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:812 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The SeeAlso as String.") >
   Public Property SeeAlso()As String
       Get
       Return _SeeAlso
       End Get
       Set(ByVal Value As String)
       _SeeAlso = Value
       End Set
   End Property
#End Region '(Set|Get) The SeeAlso as String.

#Region"[On] |2019/07/06 00h51:516| <01.00.54> <Property> <Columns> |.Rules()|String|"' (Set|Get) The Rules as String.
   Private _Rules As String
    '''    <Summary>
'''     (Set|Get) The Rules as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:815 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Rules as String.") >
   Public Property Rules()As String
       Get
       Return _Rules
       End Get
       Set(ByVal Value As String)
       _Rules = Value
       End Set
   End Property
#End Region '(Set|Get) The Rules as String.

#Region"[On] |2019/07/06 00h51:528| <01.00.55> <Property> <Columns> |.Syntax()|String|"' (Set|Get) The Syntax as String.
   Private _Syntax As String
    '''    <Summary>
'''     (Set|Get) The Syntax as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:816 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Syntax as String.") >
   Public Property Syntax()As String
       Get
       Return _Syntax
       End Get
       Set(ByVal Value As String)
       _Syntax = Value
       End Set
   End Property
#End Region '(Set|Get) The Syntax as String.

#Region"[On] |2019/07/06 00h51:541| <01.00.56> <Property> <Columns> |.AccessModifier()|String|"' (Set|Get) The AccessModifier as String.
   Private _AccessModifier As String
    '''    <Summary>
'''     (Set|Get) The AccessModifier as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:816 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AccessModifier as String.") >
   Public Property AccessModifier()As String
       Get
       Return _AccessModifier
       End Get
       Set(ByVal Value As String)
       _AccessModifier = Value
       End Set
   End Property
#End Region '(Set|Get) The AccessModifier as String.

#Region"[On] |2019/07/06 00h51:555| <01.00.57> <Property> <Columns> |.Shadows()|Boolean|"' (Set|Get) The Shadows as Boolean.
   Private _Shadows As Boolean
    '''    <Summary>
'''     (Set|Get) The Shadows as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:816 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Shadows as Boolean.") >
   Public Property Shadows()As Boolean
       Get
       Return _Shadows
       End Get
       Set(ByVal Value As Boolean)
       _Shadows = Value
       End Set
   End Property
#End Region '(Set|Get) The Shadows as Boolean.

#Region"[On] |2019/07/06 00h51:568| <01.00.58> <Property> <Columns> |.DataType()|String|"' (Set|Get) The DataType as String.
   Private _DataType As String
    '''    <Summary>
'''     (Set|Get) The DataType as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:816 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The DataType as String.") >
   Public Property DataType()As String
       Get
       Return _DataType
       End Get
       Set(ByVal Value As String)
       _DataType = Value
       End Set
   End Property
#End Region '(Set|Get) The DataType as String.

#Region"[On] |2019/07/06 00h51:581| <01.00.59> <Property> <Columns> |.EnumerationName()|String|"' (Set|Get) The EnumerationName as String.
   Private _EnumerationName As String
    '''    <Summary>
'''     (Set|Get) The EnumerationName as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:817 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The EnumerationName as String.") >
   Public Property EnumerationName()As String
       Get
       Return _EnumerationName
       End Get
       Set(ByVal Value As String)
       _EnumerationName = Value
       End Set
   End Property
#End Region '(Set|Get) The EnumerationName as String.

#End Region 
#Region"<2> [Enumeration]{1}"
#Region"[On] |2019/07/06 00h51:595| <02.00.00> <Enumeration> <> |.Schema()|Enumeration{59}|"' (Set|Get) The enumeration of Schema.
    '''    <Summary>
'''     (Set|Get) The enumeration of Schema.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:817 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The enumeration of Schema.") >
   Enum Schema
''' <summary>(Set|Get) The ID as Integer.</summary>
   [ID] = 0
''' <summary>(Set|Get) The Name as String.</summary>
   [Name] = 1
''' <summary>(Set|Get) The ImageIndex as Integer.</summary>
   [ImageIndex] = 2
''' <summary>(Set|Get) The Text as String.</summary>
   [Text] = 3
''' <summary>(Set|Get) The ToolTip as String.</summary>
   [ToolTip] = 4
''' <summary>(Set|Get) The Enable as Boolean.</summary>
   [Enable] = 5
''' <summary>(Set|Get) The Status as String.</summary>
   [Status] = 6
''' <summary>(Set|Get) The Statement as String.</summary>
   [Statement] = 7
''' <summary>(Set|Get) The XMLFile as String.</summary>
   [XMLFile] = 8
''' <summary>(Set|Get) The Attributes as String.</summary>
   [Attributes] = 9
''' <summary>(Set|Get) The Browsable as Boolean.</summary>
   [Browsable] = 10
''' <summary>(Set|Get) The Category as String.</summary>
   [Category] = 11
''' <summary>(Set|Get) The Description as String.</summary>
   [Description] = 12
''' <summary>(Set|Get) The DefaultValue as String.</summary>
   [DefaultValue] = 13
''' <summary>(Set|Get) The Editor as String.</summary>
   [Editor] = 14
''' <summary>(Set|Get) The DllImport as String.</summary>
   [DllImport] = 15
''' <summary>(Set|Get) The Deserializable as Boolean.</summary>
   [Deserializable] = 16
''' <summary>(Set|Get) The NonSerialized as Boolean.</summary>
   [NonSerialized] = 17
''' <summary>(Set|Get) The Serializable as Boolean.</summary>
   [Serializable] = 18
''' <summary>(Set|Get) The XmlRoot as String.</summary>
   [XmlRoot] = 19
''' <summary>(Set|Get) The XmlIgnore as Boolean.</summary>
   [XmlIgnore] = 20
''' <summary>(Set|Get) The XmlInclude as Boolean.</summary>
   [XmlInclude] = 21
''' <summary>(Set|Get) The RelatedImageList as String.</summary>
   [RelatedImageList] = 22
''' <summary>(Set|Get) The Print_VB as String.</summary>
   [Print_VB] = 23
''' <summary>(Set|Get) The VB as String.</summary>
   [VB] = 24
''' <summary>(Set|Get) The Print_C as String.</summary>
   [Print_C] = 25
''' <summary>(Set|Get) The C as String.</summary>
   [C] = 26
''' <summary>(Set|Get) The Print_F as String.</summary>
   [Print_F] = 27
''' <summary>(Set|Get) The F as String.</summary>
   [F] = 28
''' <summary>(Set|Get) The Print_Python as String.</summary>
   [Print_Python] = 29
''' <summary>(Set|Get) The Python as String.</summary>
   [Python] = 30
''' <summary>(Set|Get) The Print_JavaScript as String.</summary>
   [Print_JavaScript] = 31
''' <summary>(Set|Get) The JavaScript as String.</summary>
   [JavaScript] = 32
''' <summary>(Set|Get) The RegionCategory as Integer.</summary>
   [RegionCategory] = 33
''' <summary>(Set|Get) The RegionCode as String.</summary>
   [RegionCode] = 34
''' <summary>(Set|Get) The AuthorEmail as String.</summary>
   [AuthorEmail] = 35
''' <summary>(Set|Get) The AuthorName as String.</summary>
   [AuthorName] = 36
''' <summary>(Set|Get) The AuthorUri as String.</summary>
   [AuthorUri] = 37
''' <summary>(Set|Get) The ContributorEmail as String.</summary>
   [ContributorEmail] = 38
''' <summary>(Set|Get) The ContributorName as String.</summary>
   [ContributorName] = 39
''' <summary>(Set|Get) The ContributorUri as String.</summary>
   [ContributorUri] = 40
''' <summary>(Set|Get) The CustomProperty as String.</summary>
   [CustomProperty] = 41
''' <summary>(Set|Get) The Published as String.</summary>
   [Published] = 42
''' <summary>(Set|Get) The Rights as String.</summary>
   [Rights] = 43
''' <summary>(Set|Get) The Summary as String.</summary>
   [Summary] = 44
''' <summary>(Set|Get) The Title as String.</summary>
   [Title] = 45
''' <summary>(Set|Get) The Updated as String.</summary>
   [Updated] = 46
''' <summary>(Set|Get) The Usage as String.</summary>
   [Usage] = 47
''' <summary>(Set|Get) The Remarks as String.</summary>
   [Remarks] = 48
''' <summary>(Set|Get) The Example as String.</summary>
   [Example] = 49
''' <summary>(Set|Get) The Note as String.</summary>
   [Note] = 50
''' <summary>(Set|Get) The CreationDate as String.</summary>
   [CreationDate] = 51
''' <summary>(Set|Get) The See as String.</summary>
   [See] = 52
''' <summary>(Set|Get) The SeeAlso as String.</summary>
   [SeeAlso] = 53
''' <summary>(Set|Get) The Rules as String.</summary>
   [Rules] = 54
''' <summary>(Set|Get) The Syntax as String.</summary>
   [Syntax] = 55
''' <summary>(Set|Get) The AccessModifier as String.</summary>
   [AccessModifier] = 56
''' <summary>(Set|Get) The Shadows as Boolean.</summary>
   [Shadows] = 57
''' <summary>(Set|Get) The DataType as String.</summary>
   [DataType] = 58
''' <summary>(Set|Get) The EnumerationName as String.</summary>
   [EnumerationName] = 59
   End Enum
#End Region '(Set|Get) The enumeration of Schema.

#End Region 
#Region "<4> [Sub]{5}"
#Region"[On] |2019/07/06 00h51:736| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
    '''    <Summary>
'''     (Set|Get) This will reinitialize the class element.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:818 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) This will reinitialize the class element.") >
   Public Sub Clear()
  With Me
        .ID = 0
        .Name = Nothing
        .ImageIndex = 0
        .Text = Nothing
        .ToolTip = Nothing
        .Enable = False
        .Status = Nothing
        .Statement = Nothing
        .XMLFile = Nothing
        .Attributes = Nothing
        .Browsable = False
        .Category = Nothing
        .Description = Nothing
        .DefaultValue = Nothing
        .Editor = Nothing
        .DllImport = Nothing
        .Deserializable = False
        .NonSerialized = False
        .Serializable = False
        .XmlRoot = Nothing
        .XmlIgnore = False
        .XmlInclude = False
        .RelatedImageList = Nothing
        .Print_VB = Nothing
        .VB = Nothing
        .Print_C = Nothing
        .C = Nothing
        .Print_F = Nothing
        .F = Nothing
        .Print_Python = Nothing
        .Python = Nothing
        .Print_JavaScript = Nothing
        .JavaScript = Nothing
        .RegionCategory = 0
        .RegionCode = Nothing
        .AuthorEmail = Nothing
        .AuthorName = Nothing
        .AuthorUri = Nothing
        .ContributorEmail = Nothing
        .ContributorName = Nothing
        .ContributorUri = Nothing
        .CustomProperty = Nothing
        .Published = Nothing
        .Rights = Nothing
        .Summary = Nothing
        .Title = Nothing
        .Updated = Nothing
        .Usage = Nothing
        .Remarks = Nothing
        .Example = Nothing
        .Note = Nothing
        .CreationDate = Nothing
        .See = Nothing
        .SeeAlso = Nothing
        .Rules = Nothing
        .Syntax = Nothing
        .AccessModifier = Nothing
        .Shadows = False
        .DataType = Nothing
        .EnumerationName = Nothing
 End With
   End Sub
#End Region '(Set|Get) This will reinitialize the class element.

#Region"[On] |2019/07/06 00h51:858| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
    '''    <Summary>
'''     (Set|Get) This will reinitialize the variables of this class.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:818 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) This will reinitialize the variables of this class.") >
   Public Sub Reset(Optional ByVal Connector As LineInfo = Nothing)
If Not IsNothing(Connector) Then
   Me.Connector=Connector
   Me.FilePath=""
   Me.Password=""
   Me.Line=""
   If Connector.Status<>Status.Broken Then 
        FilePath = Connector.FilePath
        Password = Connector.Password
        Me.Connector=Connector
        TableName = "Enumeration"
        Line = Connector.Line
        UseSQL = False
   Else
        FilePath = My.Settings.Db_ProjectDatabase_FilePath
        Password = My.Settings.Db_ProjectDatabase_Password
        Me.Line = My.Settings.Db_ProjectDatabase_Line
        TableName = "Enumeration"
        UseSQL = False
   End If
Else
        If IsNothing(FilePath) Then 
             FilePath = My.Settings.Db_ProjectDatabase_FilePath
        End If 
        If FilePath.Length<1 Then 
             FilePath = My.Settings.Db_ProjectDatabase_FilePath
        End If 
        FilePath = My.Settings.Db_ProjectDatabase_FilePath
        Password = My.Settings.Db_ProjectDatabase_Password
        Me.Line = My.Settings.Db_ProjectDatabase_Line
        TableName = "Enumeration"
        UseSQL = False
End If

   End Sub
#End Region '(Set|Get) This will reinitialize the variables of this class.

#Region"[On] |2019/07/06 00h51:880| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
    '''    <Summary>
'''     (Set|Get) This will add a new row in the table.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:818 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) This will add a new row in the table.") >
   Public Sub Add()
 Try
   Dim Str As String = Nothing
   Str = "Insert Into [Enumeration] (
`ID`, 
`Name`, 
`ImageIndex`, 
`Text`, 
`ToolTip`, 
`Enable`, 
`Status`, 
`Statement`, 
`XMLFile`, 
`Attributes`, 
`Browsable`, 
`Category`, 
`Description`, 
`DefaultValue`, 
`Editor`, 
`DllImport`, 
`Deserializable`, 
`NonSerialized`, 
`Serializable`, 
`XmlRoot`, 
`XmlIgnore`, 
`XmlInclude`, 
`RelatedImageList`, 
`Print_VB`, 
`VB`, 
`Print_C`, 
`C`, 
`Print_F`, 
`F`, 
`Print_Python`, 
`Python`, 
`Print_JavaScript`, 
`JavaScript`, 
`RegionCategory`, 
`RegionCode`, 
`AuthorEmail`, 
`AuthorName`, 
`AuthorUri`, 
`ContributorEmail`, 
`ContributorName`, 
`ContributorUri`, 
`CustomProperty`, 
`Published`, 
`Rights`, 
`Summary`, 
`Title`, 
`Updated`, 
`Usage`, 
`Remarks`, 
`Example`, 
`Note`, 
`CreationDate`, 
`See`, 
`SeeAlso`, 
`Rules`, 
`Syntax`, 
`AccessModifier`, 
`Shadows`, 
`DataType`, 
`EnumerationName`) Values (@0, @1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18, @19, @20, @21, @22, @23, @24, @25, @26, @27, @28, @29, @30, @31, @32, @33, @34, @35, @36, @37, @38, @39, @40, @41, @42, @43, @44, @45, @46, @47, @48, @49, @50, @51, @52, @53, @54, @55, @56, @57, @58, @59)"
Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
Cmd = New OleDb.OleDbCommand(Str,Con)
Con.Open()
            Cmd.Parameters.AddWithValue("@0", Me.ID)
            Cmd.Parameters.AddWithValue("@1", Me.Name)
            Cmd.Parameters.AddWithValue("@2", Me.ImageIndex)
            Cmd.Parameters.AddWithValue("@3", Me.Text)
            Cmd.Parameters.AddWithValue("@4", Me.ToolTip)
            Cmd.Parameters.AddWithValue("@5", Me.Enable)
            Cmd.Parameters.AddWithValue("@6", Me.Status)
            Cmd.Parameters.AddWithValue("@7", Me.Statement)
            Cmd.Parameters.AddWithValue("@8", Me.XMLFile)
            Cmd.Parameters.AddWithValue("@9", Me.Attributes)
            Cmd.Parameters.AddWithValue("@10", Me.Browsable)
            Cmd.Parameters.AddWithValue("@11", Me.Category)
            Cmd.Parameters.AddWithValue("@12", Me.Description)
            Cmd.Parameters.AddWithValue("@13", Me.DefaultValue)
            Cmd.Parameters.AddWithValue("@14", Me.Editor)
            Cmd.Parameters.AddWithValue("@15", Me.DllImport)
            Cmd.Parameters.AddWithValue("@16", Me.Deserializable)
            Cmd.Parameters.AddWithValue("@17", Me.NonSerialized)
            Cmd.Parameters.AddWithValue("@18", Me.Serializable)
            Cmd.Parameters.AddWithValue("@19", Me.XmlRoot)
            Cmd.Parameters.AddWithValue("@20", Me.XmlIgnore)
            Cmd.Parameters.AddWithValue("@21", Me.XmlInclude)
            Cmd.Parameters.AddWithValue("@22", Me.RelatedImageList)
            Cmd.Parameters.AddWithValue("@23", Me.Print_VB)
            Cmd.Parameters.AddWithValue("@24", Me.VB)
            Cmd.Parameters.AddWithValue("@25", Me.Print_C)
            Cmd.Parameters.AddWithValue("@26", Me.C)
            Cmd.Parameters.AddWithValue("@27", Me.Print_F)
            Cmd.Parameters.AddWithValue("@28", Me.F)
            Cmd.Parameters.AddWithValue("@29", Me.Print_Python)
            Cmd.Parameters.AddWithValue("@30", Me.Python)
            Cmd.Parameters.AddWithValue("@31", Me.Print_JavaScript)
            Cmd.Parameters.AddWithValue("@32", Me.JavaScript)
            Cmd.Parameters.AddWithValue("@33", Me.RegionCategory)
            Cmd.Parameters.AddWithValue("@34", Me.RegionCode)
            Cmd.Parameters.AddWithValue("@35", Me.AuthorEmail)
            Cmd.Parameters.AddWithValue("@36", Me.AuthorName)
            Cmd.Parameters.AddWithValue("@37", Me.AuthorUri)
            Cmd.Parameters.AddWithValue("@38", Me.ContributorEmail)
            Cmd.Parameters.AddWithValue("@39", Me.ContributorName)
            Cmd.Parameters.AddWithValue("@40", Me.ContributorUri)
            Cmd.Parameters.AddWithValue("@41", Me.CustomProperty)
            Cmd.Parameters.AddWithValue("@42", Me.Published)
            Cmd.Parameters.AddWithValue("@43", Me.Rights)
            Cmd.Parameters.AddWithValue("@44", Me.Summary)
            Cmd.Parameters.AddWithValue("@45", Me.Title)
            Cmd.Parameters.AddWithValue("@46", Me.Updated)
            Cmd.Parameters.AddWithValue("@47", Me.Usage)
            Cmd.Parameters.AddWithValue("@48", Me.Remarks)
            Cmd.Parameters.AddWithValue("@49", Me.Example)
            Cmd.Parameters.AddWithValue("@50", Me.Note)
            Cmd.Parameters.AddWithValue("@51", Me.CreationDate)
            Cmd.Parameters.AddWithValue("@52", Me.See)
            Cmd.Parameters.AddWithValue("@53", Me.SeeAlso)
            Cmd.Parameters.AddWithValue("@54", Me.Rules)
            Cmd.Parameters.AddWithValue("@55", Me.Syntax)
            Cmd.Parameters.AddWithValue("@56", Me.AccessModifier)
            Cmd.Parameters.AddWithValue("@57", Me.Shadows)
            Cmd.Parameters.AddWithValue("@58", Me.DataType)
            Cmd.Parameters.AddWithValue("@59", Me.EnumerationName)
          If Cmd.ExecuteNonQuery>=0 Then
          Else
              Msgbox("Element not Addd")
          End If
 Catch ex As Exception 
 Finally 
   Close(True) 
 End Try 

   End Sub
#End Region '(Set|Get) This will add a new row in the table.

#Region"[On] |2019/07/06 00h51:899| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
    '''    <Summary>
'''     (Set|Get) This will update a row in the table.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:819 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) This will update a row in the table.") >
   Public Sub Save()
 Try
   Dim Str As String = Nothing
   Str = "UPDATE [Enumeration] SET Name = @Name, ImageIndex = @ImageIndex, Text = @Text, ToolTip = @ToolTip, Enable = @Enable, Status = @Status, Statement = @Statement, XMLFile = @XMLFile, Attributes = @Attributes, Browsable = @Browsable, Category = @Category, Description = @Description, DefaultValue = @DefaultValue, Editor = @Editor, DllImport = @DllImport, Deserializable = @Deserializable, NonSerialized = @NonSerialized, Serializable = @Serializable, XmlRoot = @XmlRoot, XmlIgnore = @XmlIgnore, XmlInclude = @XmlInclude, RelatedImageList = @RelatedImageList, Print_VB = @Print_VB, VB = @VB, Print_C = @Print_C, C = @C, Print_F = @Print_F, F = @F, Print_Python = @Print_Python, Python = @Python, Print_JavaScript = @Print_JavaScript, JavaScript = @JavaScript, RegionCategory = @RegionCategory, RegionCode = @RegionCode, AuthorEmail = @AuthorEmail, AuthorName = @AuthorName, AuthorUri = @AuthorUri, ContributorEmail = @ContributorEmail, ContributorName = @ContributorName, ContributorUri = @ContributorUri, CustomProperty = @CustomProperty, Published = @Published, Rights = @Rights, Summary = @Summary, Title = @Title, Updated = @Updated, Usage = @Usage, Remarks = @Remarks, Example = @Example, Note = @Note, CreationDate = @CreationDate, See = @See, SeeAlso = @SeeAlso, Rules = @Rules, Syntax = @Syntax, AccessModifier = @AccessModifier, Shadows = @Shadows, DataType = @DataType, EnumerationName = @EnumerationName WHERE ID = @ID"
Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
Cmd = New OleDb.OleDbCommand(Str,Con)
Con.Open()
      Cmd.Parameters.AddWithValue("@Name",Name)
      Cmd.Parameters.AddWithValue("@ImageIndex",ImageIndex)
      Cmd.Parameters.AddWithValue("@Text",Text)
      Cmd.Parameters.AddWithValue("@ToolTip",ToolTip)
      Cmd.Parameters.AddWithValue("@Enable",Enable)
      Cmd.Parameters.AddWithValue("@Status",Status)
      Cmd.Parameters.AddWithValue("@Statement",Statement)
      Cmd.Parameters.AddWithValue("@XMLFile",XMLFile)
      Cmd.Parameters.AddWithValue("@Attributes",Attributes)
      Cmd.Parameters.AddWithValue("@Browsable",Browsable)
      Cmd.Parameters.AddWithValue("@Category",Category)
      Cmd.Parameters.AddWithValue("@Description",Description)
      Cmd.Parameters.AddWithValue("@DefaultValue",DefaultValue)
      Cmd.Parameters.AddWithValue("@Editor",Editor)
      Cmd.Parameters.AddWithValue("@DllImport",DllImport)
      Cmd.Parameters.AddWithValue("@Deserializable",Deserializable)
      Cmd.Parameters.AddWithValue("@NonSerialized",NonSerialized)
      Cmd.Parameters.AddWithValue("@Serializable",Serializable)
      Cmd.Parameters.AddWithValue("@XmlRoot",XmlRoot)
      Cmd.Parameters.AddWithValue("@XmlIgnore",XmlIgnore)
      Cmd.Parameters.AddWithValue("@XmlInclude",XmlInclude)
      Cmd.Parameters.AddWithValue("@RelatedImageList",RelatedImageList)
      Cmd.Parameters.AddWithValue("@Print_VB",Print_VB)
      Cmd.Parameters.AddWithValue("@VB",VB)
      Cmd.Parameters.AddWithValue("@Print_C",Print_C)
      Cmd.Parameters.AddWithValue("@C",C)
      Cmd.Parameters.AddWithValue("@Print_F",Print_F)
      Cmd.Parameters.AddWithValue("@F",F)
      Cmd.Parameters.AddWithValue("@Print_Python",Print_Python)
      Cmd.Parameters.AddWithValue("@Python",Python)
      Cmd.Parameters.AddWithValue("@Print_JavaScript",Print_JavaScript)
      Cmd.Parameters.AddWithValue("@JavaScript",JavaScript)
      Cmd.Parameters.AddWithValue("@RegionCategory",RegionCategory)
      Cmd.Parameters.AddWithValue("@RegionCode",RegionCode)
      Cmd.Parameters.AddWithValue("@AuthorEmail",AuthorEmail)
      Cmd.Parameters.AddWithValue("@AuthorName",AuthorName)
      Cmd.Parameters.AddWithValue("@AuthorUri",AuthorUri)
      Cmd.Parameters.AddWithValue("@ContributorEmail",ContributorEmail)
      Cmd.Parameters.AddWithValue("@ContributorName",ContributorName)
      Cmd.Parameters.AddWithValue("@ContributorUri",ContributorUri)
      Cmd.Parameters.AddWithValue("@CustomProperty",CustomProperty)
      Cmd.Parameters.AddWithValue("@Published",Published)
      Cmd.Parameters.AddWithValue("@Rights",Rights)
      Cmd.Parameters.AddWithValue("@Summary",Summary)
      Cmd.Parameters.AddWithValue("@Title",Title)
      Cmd.Parameters.AddWithValue("@Updated",Updated)
      Cmd.Parameters.AddWithValue("@Usage",Usage)
      Cmd.Parameters.AddWithValue("@Remarks",Remarks)
      Cmd.Parameters.AddWithValue("@Example",Example)
      Cmd.Parameters.AddWithValue("@Note",Note)
      Cmd.Parameters.AddWithValue("@CreationDate",CreationDate)
      Cmd.Parameters.AddWithValue("@See",See)
      Cmd.Parameters.AddWithValue("@SeeAlso",SeeAlso)
      Cmd.Parameters.AddWithValue("@Rules",Rules)
      Cmd.Parameters.AddWithValue("@Syntax",Syntax)
      Cmd.Parameters.AddWithValue("@AccessModifier",AccessModifier)
      Cmd.Parameters.AddWithValue("@Shadows",Shadows)
      Cmd.Parameters.AddWithValue("@DataType",DataType)
      Cmd.Parameters.AddWithValue("@EnumerationName",EnumerationName)
      Cmd.Parameters.AddWithValue("@ID",ID)
          If Cmd.ExecuteNonQuery>=0 Then
          Else
              Msgbox("Element not Saved")
          End If
 Catch ex As Exception 
 Finally 
   Close(True) 
 End Try 

   End Sub
#End Region '(Set|Get) This will update a row in the table.

#Region"[On] |2019/07/06 00h51:915| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
    '''    <Summary>
'''     (Set|Get) This will Delete a row in the table.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:819 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) This will Delete a row in the table.") >
   Public Sub Delete()
 Try
   Dim Str As String = Nothing
   Str = "Delete From [Enumeration] WHERE ID =@ID"
Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
Cmd = New OleDb.OleDbCommand(Str,Con)
Con.Open()
Cmd.Parameters.AddWithValue("@ID", ID)
          If Cmd.ExecuteNonQuery>=0 Then
          Else
              Msgbox("Element not Deleted")
          End If
 Catch ex As Exception 
 Finally 
   Close(True) 
 End Try 

   End Sub
#End Region '(Set|Get) This will Delete a row in the table.

#End Region 
#Region "<5> [Function]{7}"
#Region"[On] |2019/07/06 00h51:930| <05.00.00> <Function> <> |.Open()|TestItem}|"' (Set|Get) This will initialise the connection and import the data.
    '''    <Summary>
'''     (Set|Get) This will initialise the connection and import the data.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:819 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) This will initialise the connection and import the data.") >
   Public Function Open(ByVal SqlCommand As String) As TestItem
 Dim Result As New TestItem("Open(SqlCommand)", " Openning the connection line to the database.")
 If CheckConnection()=True Then
                     Con = New OleDb.OleDbConnection(Me.Line)
                     Cmd = New OleDb.OleDbCommand(SqlCommand,Con)
                         If Con.State = ConnectionState.Open Then
                             Close(True)
                         Else
                             Try
                                 Con.Open()
                                 Result.Status = Status.Online
                             Catch ex As Exception
                                 Result.AddBug(ex,"Error while opening database","SqlCon.Open()")
                                 Result.Why+= ex.Message & vbNewLine
                                 Result.Status = Status.Broken
                             End Try
                         End If
     Else
         Result.Status = Status.Broken
         Result.Why += Log & VbNewLine 
     End If
 Return Result

   End Function
#End Region '(Set|Get) This will initialise the connection and import the data.

#Region"[On] |2019/07/06 00h51:062| <05.00.01> <Function> <> |.Close()|TestItem}|"' (Set|Get) This willClosing the connection
    '''    <Summary>
'''     (Set|Get) This willClosing the connection
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:819 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) This willClosing the connection") >
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
                                 Result.Why +="The connection will not close." & vbNewLine
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
                                 Result.Why +="The connection will not close." & vbNewLine
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
                                 Result.Why +="The connection will not close." & vbNewLine
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
                                 Result.Why +="The connection will not close." & vbNewLine
                             End If
                     End If
             End If
         End If
 Return Result

   End Function
#End Region '(Set|Get) This willClosing the connection

#Region"[On] |2019/07/06 00h51:080| <05.00.02> <Function> <> |.List()|List(Of Enumeration)}|"' (Set|Get) Return the entire table listed
    '''    <Summary>
'''     (Set|Get) Return the entire table listed
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:820 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) Return the entire table listed") >
   Public Function List() As List(Of Enumeration)
Dim Result As New List(Of Enumeration)
Me.Table = New Table(Me.TableName , Me.FilePath , Me.Password,False)
   For each Row As DataRow In Me.Table.DataTable.Rows
      Dim Element As New Enumeration(IIf(IsDBNull(Row.Item(0)),0,Row.Item(0)),
IIf(IsDBNull(Row.Item(1)),"",Row.Item(1)),
IIf(IsDBNull(Row.Item(2)),0,Row.Item(2)),
IIf(IsDBNull(Row.Item(3)),"",Row.Item(3)),
IIf(IsDBNull(Row.Item(4)),"",Row.Item(4)),
IIf(IsDBNull(Row.Item(5)),False,Row.Item(5)),
IIf(IsDBNull(Row.Item(6)),"",Row.Item(6)),
IIf(IsDBNull(Row.Item(7)),"",Row.Item(7)),
IIf(IsDBNull(Row.Item(8)),"",Row.Item(8)),
IIf(IsDBNull(Row.Item(9)),"",Row.Item(9)),
IIf(IsDBNull(Row.Item(10)),False,Row.Item(10)),
IIf(IsDBNull(Row.Item(11)),"",Row.Item(11)),
IIf(IsDBNull(Row.Item(12)),"",Row.Item(12)),
IIf(IsDBNull(Row.Item(13)),"",Row.Item(13)),
IIf(IsDBNull(Row.Item(14)),"",Row.Item(14)),
IIf(IsDBNull(Row.Item(15)),"",Row.Item(15)),
IIf(IsDBNull(Row.Item(16)),False,Row.Item(16)),
IIf(IsDBNull(Row.Item(17)),False,Row.Item(17)),
IIf(IsDBNull(Row.Item(18)),False,Row.Item(18)),
IIf(IsDBNull(Row.Item(19)),"",Row.Item(19)),
IIf(IsDBNull(Row.Item(20)),False,Row.Item(20)),
IIf(IsDBNull(Row.Item(21)),False,Row.Item(21)),
IIf(IsDBNull(Row.Item(22)),"",Row.Item(22)),
IIf(IsDBNull(Row.Item(23)),"",Row.Item(23)),
IIf(IsDBNull(Row.Item(24)),"",Row.Item(24)),
IIf(IsDBNull(Row.Item(25)),"",Row.Item(25)),
IIf(IsDBNull(Row.Item(26)),"",Row.Item(26)),
IIf(IsDBNull(Row.Item(27)),"",Row.Item(27)),
IIf(IsDBNull(Row.Item(28)),"",Row.Item(28)),
IIf(IsDBNull(Row.Item(29)),"",Row.Item(29)),
IIf(IsDBNull(Row.Item(30)),"",Row.Item(30)),
IIf(IsDBNull(Row.Item(31)),"",Row.Item(31)),
IIf(IsDBNull(Row.Item(32)),"",Row.Item(32)),
IIf(IsDBNull(Row.Item(33)),0,Row.Item(33)),
IIf(IsDBNull(Row.Item(34)),"",Row.Item(34)),
IIf(IsDBNull(Row.Item(35)),"",Row.Item(35)),
IIf(IsDBNull(Row.Item(36)),"",Row.Item(36)),
IIf(IsDBNull(Row.Item(37)),"",Row.Item(37)),
IIf(IsDBNull(Row.Item(38)),"",Row.Item(38)),
IIf(IsDBNull(Row.Item(39)),"",Row.Item(39)),
IIf(IsDBNull(Row.Item(40)),"",Row.Item(40)),
IIf(IsDBNull(Row.Item(41)),"",Row.Item(41)),
IIf(IsDBNull(Row.Item(42)),"",Row.Item(42)),
IIf(IsDBNull(Row.Item(43)),"",Row.Item(43)),
IIf(IsDBNull(Row.Item(44)),"",Row.Item(44)),
IIf(IsDBNull(Row.Item(45)),"",Row.Item(45)),
IIf(IsDBNull(Row.Item(46)),"",Row.Item(46)),
IIf(IsDBNull(Row.Item(47)),"",Row.Item(47)),
IIf(IsDBNull(Row.Item(48)),"",Row.Item(48)),
IIf(IsDBNull(Row.Item(49)),"",Row.Item(49)),
IIf(IsDBNull(Row.Item(50)),"",Row.Item(50)),
IIf(IsDBNull(Row.Item(51)),"",Row.Item(51)),
IIf(IsDBNull(Row.Item(52)),"",Row.Item(52)),
IIf(IsDBNull(Row.Item(53)),"",Row.Item(53)),
IIf(IsDBNull(Row.Item(54)),"",Row.Item(54)),
IIf(IsDBNull(Row.Item(55)),"",Row.Item(55)),
IIf(IsDBNull(Row.Item(56)),"",Row.Item(56)),
IIf(IsDBNull(Row.Item(57)),False,Row.Item(57)),
IIf(IsDBNull(Row.Item(58)),"",Row.Item(58)),
      IIf(IsDBNull(Row.Item(59)),"",Row.Item(59)))
      Element.Reset(Table.Line)
 Result.Add(Element)
 Next
 Return Result
   End Function
#End Region '(Set|Get) Return the entire table listed

#Region"[On] |2019/07/06 00h51:094| <05.00.03> <Function> <> |.SearchByName()|List(Of Enumeration)}|"' (Set|Get) Search for each property that match the Search String.
    '''    <Summary>
'''     (Set|Get) Search for each property that match the Search String.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:820 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) Search for each property that match the Search String.") >
   Public Shared Function SearchByName(ByVal Search As String) As List(Of Enumeration)
Dim Result As New List(Of Enumeration)
 Dim C As New Enumeration
 For Each Element As Enumeration In C.List
 If Element.Name.Tolower() = Search.Tolower() Or Element.Text.Tolower() = Search.Tolower()  Or Element.ToolTip.Tolower() = Search.Tolower()  Or Element.Status.Tolower() = Search.Tolower()  Or Element.Statement.Tolower() = Search.Tolower()  Or Element.XMLFile.Tolower() = Search.Tolower()  Or Element.Attributes.Tolower() = Search.Tolower()  Or Element.Category.Tolower() = Search.Tolower()  Or Element.Description.Tolower() = Search.Tolower()  Or Element.DefaultValue.Tolower() = Search.Tolower()  Or Element.Editor.Tolower() = Search.Tolower()  Or Element.DllImport.Tolower() = Search.Tolower()  Or Element.XmlRoot.Tolower() = Search.Tolower()  Or Element.RelatedImageList.Tolower() = Search.Tolower()  Or Element.Print_VB.Tolower() = Search.Tolower()  Or Element.VB.Tolower() = Search.Tolower()  Or Element.Print_C.Tolower() = Search.Tolower()  Or Element.C.Tolower() = Search.Tolower()  Or Element.Print_F.Tolower() = Search.Tolower()  Or Element.F.Tolower() = Search.Tolower()  Or Element.Print_Python.Tolower() = Search.Tolower()  Or Element.Python.Tolower() = Search.Tolower()  Or Element.Print_JavaScript.Tolower() = Search.Tolower()  Or Element.JavaScript.Tolower() = Search.Tolower()  Or Element.RegionCode.Tolower() = Search.Tolower()  Or Element.AuthorEmail.Tolower() = Search.Tolower()  Or Element.AuthorName.Tolower() = Search.Tolower()  Or Element.AuthorUri.Tolower() = Search.Tolower()  Or Element.ContributorEmail.Tolower() = Search.Tolower()  Or Element.ContributorName.Tolower() = Search.Tolower()  Or Element.ContributorUri.Tolower() = Search.Tolower()  Or Element.CustomProperty.Tolower() = Search.Tolower()  Or Element.Published.Tolower() = Search.Tolower()  Or Element.Rights.Tolower() = Search.Tolower()  Or Element.Summary.Tolower() = Search.Tolower()  Or Element.Title.Tolower() = Search.Tolower()  Or Element.Updated.Tolower() = Search.Tolower()  Or Element.Usage.Tolower() = Search.Tolower()  Or Element.Remarks.Tolower() = Search.Tolower()  Or Element.Example.Tolower() = Search.Tolower()  Or Element.Note.Tolower() = Search.Tolower()  Or Element.CreationDate.Tolower() = Search.Tolower()  Or Element.See.Tolower() = Search.Tolower()  Or Element.SeeAlso.Tolower() = Search.Tolower()  Or Element.Rules.Tolower() = Search.Tolower()  Or Element.Syntax.Tolower() = Search.Tolower()  Or Element.AccessModifier.Tolower() = Search.Tolower()  Or Element.DataType.Tolower() = Search.Tolower()  Or Element.EnumerationName.Tolower() = Search.Tolower() Then
      Result.Add(Element)
 End If
 Next
 Return Result
   End Function
#End Region '(Set|Get) Search for each property that match the Search String.

#Region"[On] |2019/07/06 00h51:111| <05.00.04> <Function> <> |.SearchByID()|List(Of Enumeration)}|"' (Set|Get) Search for each property that match the Search Id.
    '''    <Summary>
'''     (Set|Get) Search for each property that match the Search Id.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:820 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) Search for each property that match the Search Id.") >
   Public Shared Function SearchByID(ByVal Search As Double) As List(Of Enumeration)
Dim Result As New List(Of Enumeration)
 Dim C As New Enumeration
 For Each Element As Enumeration In C.List
 If Val(Element.ID) = Search Or Val(Element.ImageIndex) = Search  Or Val(Element.RegionCategory) = Search Then
      Result.Add(Element)
 End If
 Next
 Return Result
   End Function
#End Region '(Set|Get) Search for each property that match the Search Id.

#Region"[On] |2019/07/06 00h51:127| <05.00.05> <Function> <> |.ToString()|String}|"' (Set|Get) The function ToString.
    '''    <Summary>
'''     (Set|Get) The function ToString.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:820 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The function ToString.") >
   Public Overrides Function ToString() As String
    Return Me.ID
   End Function
#End Region '(Set|Get) The function ToString.

#Region"[On] |2019/07/06 00h51:144| <05.00.06> <Function> <> |.CheckConnection()|Boolean}|"' (Set|Get) Evaluate the connection to the DataBase
    '''    <Summary>
'''     (Set|Get) Evaluate the connection to the DataBase
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:820 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) Evaluate the connection to the DataBase") >
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
    Dim Message As String = Nothing' Stores the process logic.
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
        If D.IsReady  Then
            Test_4 = True
        Message += "Test 4 <Result> |OK| The Drive is Online."
        Else
            Test_4 = False
        Message += "Test 4 <Result> |PB| The Drive is Offline or Disconnected."
        End If
 #End Region 
 #Region "Test 5 | Evaluate if there is a Password."
        If Not IsDbNull(Password) Then
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
                    Me.Connector = New LineInfo(FilePath,Password)
                    Me.Line = Me.Connector.Line
        Message += "Test 6 <Result> |Initialize Connector|"
                End If
        End If
 #End Region 
 #Region "Test 7 | Evaluate if Connector Line is not empty."
        If Not IsDbNull(Me.Connector.Line) Then
            Test_7 = True
        Else 
            Test_7 = False
        End If
 #End Region 
 #Region "Test 8 | Evaluate if the Connection is valid."
        If Test_7 =True Then
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
 If Test_7=True And Test_8 = True Then
    General_Status=True
 Else 
    General_Status=False
 End If
 Log+=Message & VbNewLine
 Return General_Status

   End Function
#End Region '(Set|Get) Evaluate the connection to the DataBase

#End Region 
#Region "<6> [Runtime]{12}"
#Region"[On] |2019/07/06 00h51:160| <15.00.00> <Runtime> <> |.Table()|Table"' (Set|Get) The Table.
    '''    <Summary>
'''     (Set|Get) The Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:821 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The Table.") >
   Public  Table As Table
#End Region '(Set|Get) The Table.

#Region"[On] |2019/07/06 00h51:275| <15.00.01> <Runtime> <> |.Line()|String"' (Set|Get) The Connection String To the Table.
    '''    <Summary>
'''     (Set|Get) The Connection String To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:821 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The Connection String To the Table.") >
   Public  Line As String
#End Region '(Set|Get) The Connection String To the Table.

#Region"[On] |2019/07/06 00h51:290| <15.00.02> <Runtime> <> |.FilePath()|String"' (Set|Get) The FilePath To the Table.
    '''    <Summary>
'''     (Set|Get) The FilePath To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:821 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The FilePath To the Table.") >
   Public  FilePath As String
#End Region '(Set|Get) The FilePath To the Table.

#Region"[On] |2019/07/06 00h51:304| <15.00.03> <Runtime> <> |.Password()|String"' (Set|Get) The Password To the Table.
    '''    <Summary>
'''     (Set|Get) The Password To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:822 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The Password To the Table.") >
   Public  Password As String
#End Region '(Set|Get) The Password To the Table.

#Region"[On] |2019/07/06 00h51:318| <15.00.04> <Runtime> <> |.UseSQL()|Boolean"' (Set|Get) Determines if the Database Connection is of type SQL.
    '''    <Summary>
'''     (Set|Get) Determines if the Database Connection is of type SQL.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:822 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) Determines if the Database Connection is of type SQL.") >
   Public  UseSQL As Boolean
#End Region '(Set|Get) Determines if the Database Connection is of type SQL.

#Region"[On] |2019/07/06 00h51:333| <15.00.05> <Runtime> <> |.TableName()|String"' (Set|Get) The name of the Table.
    '''    <Summary>
'''     (Set|Get) The name of the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:822 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The name of the Table.") >
   Public  TableName As String
#End Region '(Set|Get) The name of the Table.

#Region"[On] |2019/07/06 00h51:349| <15.00.06> <Runtime> <> |.Con()|OleDb.OleDbConnection"' (Set|Get) The Con To the Table.
    '''    <Summary>
'''     (Set|Get) The Con To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:822 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The Con To the Table.") >
   Public  Con As OleDb.OleDbConnection
#End Region '(Set|Get) The Con To the Table.

#Region"[On] |2019/07/06 00h51:368| <15.00.07> <Runtime> <> |.Cmd()|OleDb.OleDbCommand"' (Set|Get) The Cmd To the Table.
    '''    <Summary>
'''     (Set|Get) The Cmd To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:822 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The Cmd To the Table.") >
   Public  Cmd As OleDb.OleDbCommand
#End Region '(Set|Get) The Cmd To the Table.

#Region"[On] |2019/07/06 00h51:383| <15.00.08> <Runtime> <> |.DataReader()|OleDb.OleDbDataReader"' (Set|Get) The DataReader To the Table.
    '''    <Summary>
'''     (Set|Get) The DataReader To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:825 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The DataReader To the Table.") >
   Public  DataReader As OleDb.OleDbDataReader
#End Region '(Set|Get) The DataReader To the Table.

#Region"[On] |2019/07/06 00h51:397| <15.00.09> <Runtime> <> |.DataAdapter()|OleDb.OleDbDataAdapter"' (Set|Get) The DataAdapter To the Table.
    '''    <Summary>
'''     (Set|Get) The DataAdapter To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:825 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The DataAdapter To the Table.") >
   Public  DataAdapter As OleDb.OleDbDataAdapter
#End Region '(Set|Get) The DataAdapter To the Table.

#Region"[On] |2019/07/06 00h51:412| <15.00.10> <Runtime> <> |.Connector()|LineInfo"' (Set|Get) The Connector To the Table.
    '''    <Summary>
'''     (Set|Get) The Connector To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:825 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The Connector To the Table.") >
   Public  Connector As LineInfo
#End Region '(Set|Get) The Connector To the Table.

#Region"[On] |2019/07/06 00h51:428| <15.00.11> <Runtime> <> |.Log()|String"' (Set|Get) The Log To the Table.
    '''    <Summary>
'''     (Set|Get) The Log To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:825 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The Log To the Table.") >
   Public  Log As String
#End Region '(Set|Get) The Log To the Table.

#End Region 
#Region "<7> [Loader]{2}"
#Region"[On] |2019/07/06 00h51:451| <06.00.00> <Loader> <> |.Empty()|Function}|"' (Set|Get) The sub Empty.
    '''    <Summary>
'''     (Set|Get) The sub Empty.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:826 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The sub Empty.") >
   Public Sub New ()
Reset
   End Sub
#End Region '(Set|Get) The sub Empty.

#Region"[On] |2019/07/06 00h51:462| <06.00.01> <Loader> <> |.Filled()|Function}|"' (Set|Get) The sub Filled.
    '''    <Summary>
'''     (Set|Get) The sub Filled.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:826 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>    ''' <param name="ID">(Set|Get) The ID as Integer.</param>
    ''' <param name="Name">(Set|Get) The Name as String.</param>
    ''' <param name="ImageIndex">(Set|Get) The ImageIndex as Integer.</param>
    ''' <param name="Text">(Set|Get) The Text as String.</param>
    ''' <param name="ToolTip">(Set|Get) The ToolTip as String.</param>
    ''' <param name="Enable">(Set|Get) The Enable as Boolean.</param>
    ''' <param name="Status">(Set|Get) The Status as String.</param>
    ''' <param name="Statement">(Set|Get) The Statement as String.</param>
    ''' <param name="XMLFile">(Set|Get) The XMLFile as String.</param>
    ''' <param name="Attributes">(Set|Get) The Attributes as String.</param>
    ''' <param name="Browsable">(Set|Get) The Browsable as Boolean.</param>
    ''' <param name="Category">(Set|Get) The Category as String.</param>
    ''' <param name="Description">(Set|Get) The Description as String.</param>
    ''' <param name="DefaultValue">(Set|Get) The DefaultValue as String.</param>
    ''' <param name="Editor">(Set|Get) The Editor as String.</param>
    ''' <param name="DllImport">(Set|Get) The DllImport as String.</param>
    ''' <param name="Deserializable">(Set|Get) The Deserializable as Boolean.</param>
    ''' <param name="NonSerialized">(Set|Get) The NonSerialized as Boolean.</param>
    ''' <param name="Serializable">(Set|Get) The Serializable as Boolean.</param>
    ''' <param name="XmlRoot">(Set|Get) The XmlRoot as String.</param>
    ''' <param name="XmlIgnore">(Set|Get) The XmlIgnore as Boolean.</param>
    ''' <param name="XmlInclude">(Set|Get) The XmlInclude as Boolean.</param>
    ''' <param name="RelatedImageList">(Set|Get) The RelatedImageList as String.</param>
    ''' <param name="Print_VB">(Set|Get) The Print_VB as String.</param>
    ''' <param name="VB">(Set|Get) The VB as String.</param>
    ''' <param name="Print_C">(Set|Get) The Print_C as String.</param>
    ''' <param name="C">(Set|Get) The C as String.</param>
    ''' <param name="Print_F">(Set|Get) The Print_F as String.</param>
    ''' <param name="F">(Set|Get) The F as String.</param>
    ''' <param name="Print_Python">(Set|Get) The Print_Python as String.</param>
    ''' <param name="Python">(Set|Get) The Python as String.</param>
    ''' <param name="Print_JavaScript">(Set|Get) The Print_JavaScript as String.</param>
    ''' <param name="JavaScript">(Set|Get) The JavaScript as String.</param>
    ''' <param name="RegionCategory">(Set|Get) The RegionCategory as Integer.</param>
    ''' <param name="RegionCode">(Set|Get) The RegionCode as String.</param>
    ''' <param name="AuthorEmail">(Set|Get) The AuthorEmail as String.</param>
    ''' <param name="AuthorName">(Set|Get) The AuthorName as String.</param>
    ''' <param name="AuthorUri">(Set|Get) The AuthorUri as String.</param>
    ''' <param name="ContributorEmail">(Set|Get) The ContributorEmail as String.</param>
    ''' <param name="ContributorName">(Set|Get) The ContributorName as String.</param>
    ''' <param name="ContributorUri">(Set|Get) The ContributorUri as String.</param>
    ''' <param name="CustomProperty">(Set|Get) The CustomProperty as String.</param>
    ''' <param name="Published">(Set|Get) The Published as String.</param>
    ''' <param name="Rights">(Set|Get) The Rights as String.</param>
    ''' <param name="Summary">(Set|Get) The Summary as String.</param>
    ''' <param name="Title">(Set|Get) The Title as String.</param>
    ''' <param name="Updated">(Set|Get) The Updated as String.</param>
    ''' <param name="Usage">(Set|Get) The Usage as String.</param>
    ''' <param name="Remarks">(Set|Get) The Remarks as String.</param>
    ''' <param name="Example">(Set|Get) The Example as String.</param>
    ''' <param name="Note">(Set|Get) The Note as String.</param>
    ''' <param name="CreationDate">(Set|Get) The CreationDate as String.</param>
    ''' <param name="See">(Set|Get) The See as String.</param>
    ''' <param name="SeeAlso">(Set|Get) The SeeAlso as String.</param>
    ''' <param name="Rules">(Set|Get) The Rules as String.</param>
    ''' <param name="Syntax">(Set|Get) The Syntax as String.</param>
    ''' <param name="AccessModifier">(Set|Get) The AccessModifier as String.</param>
    ''' <param name="Shadows">(Set|Get) The Shadows as Boolean.</param>
    ''' <param name="DataType">(Set|Get) The DataType as String.</param>
    ''' <param name="EnumerationName">(Set|Get) The EnumerationName as String.</param>

    <Browsable(True) , Description("(Set|Get) The sub Filled.") >
   Public Sub New (ByVal ID As Integer, 
ByVal Name As String, 
ByVal ImageIndex As Integer, 
ByVal Text As String, 
ByVal ToolTip As String, 
ByVal Enable As Boolean, 
ByVal Status As String, 
ByVal Statement As String, 
ByVal XMLFile As String, 
ByVal Attributes As String, 
ByVal Browsable As Boolean, 
ByVal Category As String, 
ByVal Description As String, 
ByVal DefaultValue As String, 
ByVal Editor As String, 
ByVal DllImport As String, 
ByVal Deserializable As Boolean, 
ByVal NonSerialized As Boolean, 
ByVal Serializable As Boolean, 
ByVal XmlRoot As String, 
ByVal XmlIgnore As Boolean, 
ByVal XmlInclude As Boolean, 
ByVal RelatedImageList As String, 
ByVal Print_VB As String, 
ByVal VB As String, 
ByVal Print_C As String, 
ByVal C As String, 
ByVal Print_F As String, 
ByVal F As String, 
ByVal Print_Python As String, 
ByVal Python As String, 
ByVal Print_JavaScript As String, 
ByVal JavaScript As String, 
ByVal RegionCategory As Integer, 
ByVal RegionCode As String, 
ByVal AuthorEmail As String, 
ByVal AuthorName As String, 
ByVal AuthorUri As String, 
ByVal ContributorEmail As String, 
ByVal ContributorName As String, 
ByVal ContributorUri As String, 
ByVal CustomProperty As String, 
ByVal Published As String, 
ByVal Rights As String, 
ByVal Summary As String, 
ByVal Title As String, 
ByVal Updated As String, 
ByVal Usage As String, 
ByVal Remarks As String, 
ByVal Example As String, 
ByVal Note As String, 
ByVal CreationDate As String, 
ByVal See As String, 
ByVal SeeAlso As String, 
ByVal Rules As String, 
ByVal Syntax As String, 
ByVal AccessModifier As String, 
ByVal Shadows As Boolean, 
ByVal DataType As String, 
ByVal EnumerationName As String)
 With Me
 Clear()
 Reset()
     .ID = ID
     .Name = Name
     .ImageIndex = ImageIndex
     .Text = Text
     .ToolTip = ToolTip
     .Enable = Enable
     .Status = Status
     .Statement = Statement
     .XMLFile = XMLFile
     .Attributes = Attributes
     .Browsable = Browsable
     .Category = Category
     .Description = Description
     .DefaultValue = DefaultValue
     .Editor = Editor
     .DllImport = DllImport
     .Deserializable = Deserializable
     .NonSerialized = NonSerialized
     .Serializable = Serializable
     .XmlRoot = XmlRoot
     .XmlIgnore = XmlIgnore
     .XmlInclude = XmlInclude
     .RelatedImageList = RelatedImageList
     .Print_VB = Print_VB
     .VB = VB
     .Print_C = Print_C
     .C = C
     .Print_F = Print_F
     .F = F
     .Print_Python = Print_Python
     .Python = Python
     .Print_JavaScript = Print_JavaScript
     .JavaScript = JavaScript
     .RegionCategory = RegionCategory
     .RegionCode = RegionCode
     .AuthorEmail = AuthorEmail
     .AuthorName = AuthorName
     .AuthorUri = AuthorUri
     .ContributorEmail = ContributorEmail
     .ContributorName = ContributorName
     .ContributorUri = ContributorUri
     .CustomProperty = CustomProperty
     .Published = Published
     .Rights = Rights
     .Summary = Summary
     .Title = Title
     .Updated = Updated
     .Usage = Usage
     .Remarks = Remarks
     .Example = Example
     .Note = Note
     .CreationDate = CreationDate
     .See = See
     .SeeAlso = SeeAlso
     .Rules = Rules
     .Syntax = Syntax
     .AccessModifier = AccessModifier
     .Shadows = Shadows
     .DataType = DataType
     .EnumerationName = EnumerationName
 End With

   End Sub
#End Region '(Set|Get) The sub Filled.

#End Region 
 End Class
#End Region

#Region"[On] |2019/07/06 00h51:676| <08.00.00> <Class> <> |.Function|Class|{93} |Production Cost : 145.3|Selling Price : 363.25|"' Class created automatically by SmartOffice (c)Copyright 2019.
'''    <Summary>
'''     Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Function
'''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
'''    Contributor Information : ||
'''    Creation Date :           2019/07/06 00h51:676
'''    |Schema|
'''    |ID| |ObjectType |{Quantity}||UnitPrice||Total
'''    |00| |Importation|{0}||1| |0
'''    |01| |Properties |{66}||0.8| |52.8
'''    |02| |Enumeration|{1}||0.4| |0.4
'''    |03| |Structure  |{0}||0.4| |0
'''    |04| |Sub        |{5}||1.2| |6
'''    |05| |Function   |{7}||1.6| |11.2
'''    |06| |Runtime    |{12}||0.4| |4.8
'''    |07| |Loader     |{2}||0.8| |1.6
'''    |08| |Class      |{0}||2| |0
'''    |09| |Constante  |{0}||0.4| |0
'''    |10| |Event      |{0}||1.2| |0
'''    |11| |Members    |{66}||0.5| |33
'''    |12| |Parameter  |{71}||0.5| |35.5
'''    |Production Cost             |145.3
'''    |Selling Price without VAT   |363.25
'''    |Total TVA                   |27.97
'''    |Grand Total                 |391.22
'''    |/Schema|
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:861 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
Public  Class Function
#Region "<1> [Property]{66}"
#Region"[On] |2019/07/06 00h51:677| <01.00.00> <Property> <Columns> |.ID()|Integer|"' (Set|Get) The ID as Integer.
   Private _ID As Integer
    '''    <Summary>
'''     (Set|Get) The ID as Integer.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:861 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ID as Integer.") >
   Public Property ID()As Integer
       Get
       Return _ID
       End Get
       Set(ByVal Value As Integer)
       _ID = Value
       End Set
   End Property
#End Region '(Set|Get) The ID as Integer.

#Region"[On] |2019/07/06 00h51:689| <01.00.01> <Property> <Columns> |.Name()|String|"' (Set|Get) The Name as String.
   Private _Name As String
    '''    <Summary>
'''     (Set|Get) The Name as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:861 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Name as String.") >
   Public Property Name()As String
       Get
       Return _Name
       End Get
       Set(ByVal Value As String)
       _Name = Value
       End Set
   End Property
#End Region '(Set|Get) The Name as String.

#Region"[On] |2019/07/06 00h51:700| <01.00.02> <Property> <Columns> |.ImageIndex()|Integer|"' (Set|Get) The ImageIndex as Integer.
   Private _ImageIndex As Integer
    '''    <Summary>
'''     (Set|Get) The ImageIndex as Integer.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:864 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ImageIndex as Integer.") >
   Public Property ImageIndex()As Integer
       Get
       Return _ImageIndex
       End Get
       Set(ByVal Value As Integer)
       _ImageIndex = Value
       End Set
   End Property
#End Region '(Set|Get) The ImageIndex as Integer.

#Region"[On] |2019/07/06 00h51:711| <01.00.03> <Property> <Columns> |.Text()|String|"' (Set|Get) The Text as String.
   Private _Text As String
    '''    <Summary>
'''     (Set|Get) The Text as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:864 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Text as String.") >
   Public Property Text()As String
       Get
       Return _Text
       End Get
       Set(ByVal Value As String)
       _Text = Value
       End Set
   End Property
#End Region '(Set|Get) The Text as String.

#Region"[On] |2019/07/06 00h51:721| <01.00.04> <Property> <Columns> |.ToolTip()|String|"' (Set|Get) The ToolTip as String.
   Private _ToolTip As String
    '''    <Summary>
'''     (Set|Get) The ToolTip as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:864 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ToolTip as String.") >
   Public Property ToolTip()As String
       Get
       Return _ToolTip
       End Get
       Set(ByVal Value As String)
       _ToolTip = Value
       End Set
   End Property
#End Region '(Set|Get) The ToolTip as String.

#Region"[On] |2019/07/06 00h51:732| <01.00.05> <Property> <Columns> |.Enable()|Boolean|"' (Set|Get) The Enable as Boolean.
   Private _Enable As Boolean
    '''    <Summary>
'''     (Set|Get) The Enable as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:864 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Enable as Boolean.") >
   Public Property Enable()As Boolean
       Get
       Return _Enable
       End Get
       Set(ByVal Value As Boolean)
       _Enable = Value
       End Set
   End Property
#End Region '(Set|Get) The Enable as Boolean.

#Region"[On] |2019/07/06 00h51:743| <01.00.06> <Property> <Columns> |.Status()|String|"' (Set|Get) The Status as String.
   Private _Status As String
    '''    <Summary>
'''     (Set|Get) The Status as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:865 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Status as String.") >
   Public Property Status()As String
       Get
       Return _Status
       End Get
       Set(ByVal Value As String)
       _Status = Value
       End Set
   End Property
#End Region '(Set|Get) The Status as String.

#Region"[On] |2019/07/06 00h51:754| <01.00.07> <Property> <Columns> |.Statement()|String|"' (Set|Get) The Statement as String.
   Private _Statement As String
    '''    <Summary>
'''     (Set|Get) The Statement as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:865 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Statement as String.") >
   Public Property Statement()As String
       Get
       Return _Statement
       End Get
       Set(ByVal Value As String)
       _Statement = Value
       End Set
   End Property
#End Region '(Set|Get) The Statement as String.

#Region"[On] |2019/07/06 00h51:765| <01.00.08> <Property> <Columns> |.XMLFile()|String|"' (Set|Get) The XMLFile as String.
   Private _XMLFile As String
    '''    <Summary>
'''     (Set|Get) The XMLFile as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:865 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XMLFile as String.") >
   Public Property XMLFile()As String
       Get
       Return _XMLFile
       End Get
       Set(ByVal Value As String)
       _XMLFile = Value
       End Set
   End Property
#End Region '(Set|Get) The XMLFile as String.

#Region"[On] |2019/07/06 00h51:776| <01.00.09> <Property> <Columns> |.Attributes()|String|"' (Set|Get) The Attributes as String.
   Private _Attributes As String
    '''    <Summary>
'''     (Set|Get) The Attributes as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:865 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Attributes as String.") >
   Public Property Attributes()As String
       Get
       Return _Attributes
       End Get
       Set(ByVal Value As String)
       _Attributes = Value
       End Set
   End Property
#End Region '(Set|Get) The Attributes as String.

#Region"[On] |2019/07/06 00h51:790| <01.00.10> <Property> <Columns> |.Browsable()|Boolean|"' (Set|Get) The Browsable as Boolean.
   Private _Browsable As Boolean
    '''    <Summary>
'''     (Set|Get) The Browsable as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:868 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Browsable as Boolean.") >
   Public Property Browsable()As Boolean
       Get
       Return _Browsable
       End Get
       Set(ByVal Value As Boolean)
       _Browsable = Value
       End Set
   End Property
#End Region '(Set|Get) The Browsable as Boolean.

#Region"[On] |2019/07/06 00h51:801| <01.00.11> <Property> <Columns> |.Category()|String|"' (Set|Get) The Category as String.
   Private _Category As String
    '''    <Summary>
'''     (Set|Get) The Category as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:870 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Category as String.") >
   Public Property Category()As String
       Get
       Return _Category
       End Get
       Set(ByVal Value As String)
       _Category = Value
       End Set
   End Property
#End Region '(Set|Get) The Category as String.

#Region"[On] |2019/07/06 00h51:811| <01.00.12> <Property> <Columns> |.Description()|String|"' (Set|Get) The Description as String.
   Private _Description As String
    '''    <Summary>
'''     (Set|Get) The Description as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:870 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Description as String.") >
   Public Property Description()As String
       Get
       Return _Description
       End Get
       Set(ByVal Value As String)
       _Description = Value
       End Set
   End Property
#End Region '(Set|Get) The Description as String.

#Region"[On] |2019/07/06 00h51:823| <01.00.13> <Property> <Columns> |.DefaultValue()|String|"' (Set|Get) The DefaultValue as String.
   Private _DefaultValue As String
    '''    <Summary>
'''     (Set|Get) The DefaultValue as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:870 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The DefaultValue as String.") >
   Public Property DefaultValue()As String
       Get
       Return _DefaultValue
       End Get
       Set(ByVal Value As String)
       _DefaultValue = Value
       End Set
   End Property
#End Region '(Set|Get) The DefaultValue as String.

#Region"[On] |2019/07/06 00h51:834| <01.00.14> <Property> <Columns> |.Editor()|String|"' (Set|Get) The Editor as String.
   Private _Editor As String
    '''    <Summary>
'''     (Set|Get) The Editor as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:871 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Editor as String.") >
   Public Property Editor()As String
       Get
       Return _Editor
       End Get
       Set(ByVal Value As String)
       _Editor = Value
       End Set
   End Property
#End Region '(Set|Get) The Editor as String.

#Region"[On] |2019/07/06 00h51:845| <01.00.15> <Property> <Columns> |.DllImport()|String|"' (Set|Get) The DllImport as String.
   Private _DllImport As String
    '''    <Summary>
'''     (Set|Get) The DllImport as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:871 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The DllImport as String.") >
   Public Property DllImport()As String
       Get
       Return _DllImport
       End Get
       Set(ByVal Value As String)
       _DllImport = Value
       End Set
   End Property
#End Region '(Set|Get) The DllImport as String.

#Region"[On] |2019/07/06 00h51:857| <01.00.16> <Property> <Columns> |.Deserializable()|Boolean|"' (Set|Get) The Deserializable as Boolean.
   Private _Deserializable As Boolean
    '''    <Summary>
'''     (Set|Get) The Deserializable as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:871 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Deserializable as Boolean.") >
   Public Property Deserializable()As Boolean
       Get
       Return _Deserializable
       End Get
       Set(ByVal Value As Boolean)
       _Deserializable = Value
       End Set
   End Property
#End Region '(Set|Get) The Deserializable as Boolean.

#Region"[On] |2019/07/06 00h51:868| <01.00.17> <Property> <Columns> |.NonSerialized()|Boolean|"' (Set|Get) The NonSerialized as Boolean.
   Private _NonSerialized As Boolean
    '''    <Summary>
'''     (Set|Get) The NonSerialized as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:874 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The NonSerialized as Boolean.") >
   Public Property NonSerialized()As Boolean
       Get
       Return _NonSerialized
       End Get
       Set(ByVal Value As Boolean)
       _NonSerialized = Value
       End Set
   End Property
#End Region '(Set|Get) The NonSerialized as Boolean.

#Region"[On] |2019/07/06 00h51:879| <01.00.18> <Property> <Columns> |.Serializable()|Boolean|"' (Set|Get) The Serializable as Boolean.
   Private _Serializable As Boolean
    '''    <Summary>
'''     (Set|Get) The Serializable as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:874 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Serializable as Boolean.") >
   Public Property Serializable()As Boolean
       Get
       Return _Serializable
       End Get
       Set(ByVal Value As Boolean)
       _Serializable = Value
       End Set
   End Property
#End Region '(Set|Get) The Serializable as Boolean.

#Region"[On] |2019/07/06 00h51:893| <01.00.19> <Property> <Columns> |.XmlRoot()|String|"' (Set|Get) The XmlRoot as String.
   Private _XmlRoot As String
    '''    <Summary>
'''     (Set|Get) The XmlRoot as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:874 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XmlRoot as String.") >
   Public Property XmlRoot()As String
       Get
       Return _XmlRoot
       End Get
       Set(ByVal Value As String)
       _XmlRoot = Value
       End Set
   End Property
#End Region '(Set|Get) The XmlRoot as String.

#Region"[On] |2019/07/06 00h51:904| <01.00.20> <Property> <Columns> |.XmlIgnore()|Boolean|"' (Set|Get) The XmlIgnore as Boolean.
   Private _XmlIgnore As Boolean
    '''    <Summary>
'''     (Set|Get) The XmlIgnore as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:874 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XmlIgnore as Boolean.") >
   Public Property XmlIgnore()As Boolean
       Get
       Return _XmlIgnore
       End Get
       Set(ByVal Value As Boolean)
       _XmlIgnore = Value
       End Set
   End Property
#End Region '(Set|Get) The XmlIgnore as Boolean.

#Region"[On] |2019/07/06 00h51:915| <01.00.21> <Property> <Columns> |.XmlInclude()|Boolean|"' (Set|Get) The XmlInclude as Boolean.
   Private _XmlInclude As Boolean
    '''    <Summary>
'''     (Set|Get) The XmlInclude as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:874 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XmlInclude as Boolean.") >
   Public Property XmlInclude()As Boolean
       Get
       Return _XmlInclude
       End Get
       Set(ByVal Value As Boolean)
       _XmlInclude = Value
       End Set
   End Property
#End Region '(Set|Get) The XmlInclude as Boolean.

#Region"[On] |2019/07/06 00h51:926| <01.00.22> <Property> <Columns> |.RelatedImageList()|String|"' (Set|Get) The RelatedImageList as String.
   Private _RelatedImageList As String
    '''    <Summary>
'''     (Set|Get) The RelatedImageList as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:875 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The RelatedImageList as String.") >
   Public Property RelatedImageList()As String
       Get
       Return _RelatedImageList
       End Get
       Set(ByVal Value As String)
       _RelatedImageList = Value
       End Set
   End Property
#End Region '(Set|Get) The RelatedImageList as String.

#Region"[On] |2019/07/06 00h51:937| <01.00.23> <Property> <Columns> |.Print_VB()|String|"' (Set|Get) The Print_VB as String.
   Private _Print_VB As String
    '''    <Summary>
'''     (Set|Get) The Print_VB as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:876 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_VB as String.") >
   Public Property Print_VB()As String
       Get
       Return _Print_VB
       End Get
       Set(ByVal Value As String)
       _Print_VB = Value
       End Set
   End Property
#End Region '(Set|Get) The Print_VB as String.

#Region"[On] |2019/07/06 00h51:948| <01.00.24> <Property> <Columns> |.VB()|String|"' (Set|Get) The VB as String.
   Private _VB As String
    '''    <Summary>
'''     (Set|Get) The VB as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:877 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The VB as String.") >
   Public Property VB()As String
       Get
       Return _VB
       End Get
       Set(ByVal Value As String)
       _VB = Value
       End Set
   End Property
#End Region '(Set|Get) The VB as String.

#Region"[On] |2019/07/06 00h51:960| <01.00.25> <Property> <Columns> |.Print_C()|String|"' (Set|Get) The Print_C as String.
   Private _Print_C As String
    '''    <Summary>
'''     (Set|Get) The Print_C as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:877 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_C as String.") >
   Public Property Print_C()As String
       Get
       Return _Print_C
       End Get
       Set(ByVal Value As String)
       _Print_C = Value
       End Set
   End Property
#End Region '(Set|Get) The Print_C as String.

#Region"[On] |2019/07/06 00h51:971| <01.00.26> <Property> <Columns> |.C()|String|"' (Set|Get) The C as String.
   Private _C As String
    '''    <Summary>
'''     (Set|Get) The C as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:880 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The C as String.") >
   Public Property C()As String
       Get
       Return _C
       End Get
       Set(ByVal Value As String)
       _C = Value
       End Set
   End Property
#End Region '(Set|Get) The C as String.

#Region"[On] |2019/07/06 00h51:984| <01.00.27> <Property> <Columns> |.Print_F()|String|"' (Set|Get) The Print_F as String.
   Private _Print_F As String
    '''    <Summary>
'''     (Set|Get) The Print_F as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:880 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_F as String.") >
   Public Property Print_F()As String
       Get
       Return _Print_F
       End Get
       Set(ByVal Value As String)
       _Print_F = Value
       End Set
   End Property
#End Region '(Set|Get) The Print_F as String.

#Region"[On] |2019/07/06 00h51:996| <01.00.28> <Property> <Columns> |.F()|String|"' (Set|Get) The F as String.
   Private _F As String
    '''    <Summary>
'''     (Set|Get) The F as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:880 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The F as String.") >
   Public Property F()As String
       Get
       Return _F
       End Get
       Set(ByVal Value As String)
       _F = Value
       End Set
   End Property
#End Region '(Set|Get) The F as String.

#Region"[On] |2019/07/06 00h51:007| <01.00.29> <Property> <Columns> |.Print_Python()|String|"' (Set|Get) The Print_Python as String.
   Private _Print_Python As String
    '''    <Summary>
'''     (Set|Get) The Print_Python as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:880 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_Python as String.") >
   Public Property Print_Python()As String
       Get
       Return _Print_Python
       End Get
       Set(ByVal Value As String)
       _Print_Python = Value
       End Set
   End Property
#End Region '(Set|Get) The Print_Python as String.

#Region"[On] |2019/07/06 00h51:019| <01.00.30> <Property> <Columns> |.Python()|String|"' (Set|Get) The Python as String.
   Private _Python As String
    '''    <Summary>
'''     (Set|Get) The Python as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:881 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Python as String.") >
   Public Property Python()As String
       Get
       Return _Python
       End Get
       Set(ByVal Value As String)
       _Python = Value
       End Set
   End Property
#End Region '(Set|Get) The Python as String.

#Region"[On] |2019/07/06 00h51:040| <01.00.31> <Property> <Columns> |.Print_JavaScript()|String|"' (Set|Get) The Print_JavaScript as String.
   Private _Print_JavaScript As String
    '''    <Summary>
'''     (Set|Get) The Print_JavaScript as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:881 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_JavaScript as String.") >
   Public Property Print_JavaScript()As String
       Get
       Return _Print_JavaScript
       End Get
       Set(ByVal Value As String)
       _Print_JavaScript = Value
       End Set
   End Property
#End Region '(Set|Get) The Print_JavaScript as String.

#Region"[On] |2019/07/06 00h51:053| <01.00.32> <Property> <Columns> |.JavaScript()|String|"' (Set|Get) The JavaScript as String.
   Private _JavaScript As String
    '''    <Summary>
'''     (Set|Get) The JavaScript as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:881 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The JavaScript as String.") >
   Public Property JavaScript()As String
       Get
       Return _JavaScript
       End Get
       Set(ByVal Value As String)
       _JavaScript = Value
       End Set
   End Property
#End Region '(Set|Get) The JavaScript as String.

#Region"[On] |2019/07/06 00h51:065| <01.00.33> <Property> <Columns> |.RegionCategory()|Integer|"' (Set|Get) The RegionCategory as Integer.
   Private _RegionCategory As Integer
    '''    <Summary>
'''     (Set|Get) The RegionCategory as Integer.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:881 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The RegionCategory as Integer.") >
   Public Property RegionCategory()As Integer
       Get
       Return _RegionCategory
       End Get
       Set(ByVal Value As Integer)
       _RegionCategory = Value
       End Set
   End Property
#End Region '(Set|Get) The RegionCategory as Integer.

#Region"[On] |2019/07/06 00h51:078| <01.00.34> <Property> <Columns> |.RegionCode()|String|"' (Set|Get) The RegionCode as String.
   Private _RegionCode As String
    '''    <Summary>
'''     (Set|Get) The RegionCode as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:884 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The RegionCode as String.") >
   Public Property RegionCode()As String
       Get
       Return _RegionCode
       End Get
       Set(ByVal Value As String)
       _RegionCode = Value
       End Set
   End Property
#End Region '(Set|Get) The RegionCode as String.

#Region"[On] |2019/07/06 00h51:090| <01.00.35> <Property> <Columns> |.AuthorEmail()|String|"' (Set|Get) The AuthorEmail as String.
   Private _AuthorEmail As String
    '''    <Summary>
'''     (Set|Get) The AuthorEmail as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:884 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AuthorEmail as String.") >
   Public Property AuthorEmail()As String
       Get
       Return _AuthorEmail
       End Get
       Set(ByVal Value As String)
       _AuthorEmail = Value
       End Set
   End Property
#End Region '(Set|Get) The AuthorEmail as String.

#Region"[On] |2019/07/06 00h51:101| <01.00.36> <Property> <Columns> |.AuthorName()|String|"' (Set|Get) The AuthorName as String.
   Private _AuthorName As String
    '''    <Summary>
'''     (Set|Get) The AuthorName as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:884 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AuthorName as String.") >
   Public Property AuthorName()As String
       Get
       Return _AuthorName
       End Get
       Set(ByVal Value As String)
       _AuthorName = Value
       End Set
   End Property
#End Region '(Set|Get) The AuthorName as String.

#Region"[On] |2019/07/06 00h51:114| <01.00.37> <Property> <Columns> |.AuthorUri()|String|"' (Set|Get) The AuthorUri as String.
   Private _AuthorUri As String
    '''    <Summary>
'''     (Set|Get) The AuthorUri as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:884 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AuthorUri as String.") >
   Public Property AuthorUri()As String
       Get
       Return _AuthorUri
       End Get
       Set(ByVal Value As String)
       _AuthorUri = Value
       End Set
   End Property
#End Region '(Set|Get) The AuthorUri as String.

#Region"[On] |2019/07/06 00h51:126| <01.00.38> <Property> <Columns> |.ContributorEmail()|String|"' (Set|Get) The ContributorEmail as String.
   Private _ContributorEmail As String
    '''    <Summary>
'''     (Set|Get) The ContributorEmail as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:885 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ContributorEmail as String.") >
   Public Property ContributorEmail()As String
       Get
       Return _ContributorEmail
       End Get
       Set(ByVal Value As String)
       _ContributorEmail = Value
       End Set
   End Property
#End Region '(Set|Get) The ContributorEmail as String.

#Region"[On] |2019/07/06 00h51:138| <01.00.39> <Property> <Columns> |.ContributorName()|String|"' (Set|Get) The ContributorName as String.
   Private _ContributorName As String
    '''    <Summary>
'''     (Set|Get) The ContributorName as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:885 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ContributorName as String.") >
   Public Property ContributorName()As String
       Get
       Return _ContributorName
       End Get
       Set(ByVal Value As String)
       _ContributorName = Value
       End Set
   End Property
#End Region '(Set|Get) The ContributorName as String.

#Region"[On] |2019/07/06 00h51:150| <01.00.40> <Property> <Columns> |.ContributorUri()|String|"' (Set|Get) The ContributorUri as String.
   Private _ContributorUri As String
    '''    <Summary>
'''     (Set|Get) The ContributorUri as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:885 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ContributorUri as String.") >
   Public Property ContributorUri()As String
       Get
       Return _ContributorUri
       End Get
       Set(ByVal Value As String)
       _ContributorUri = Value
       End Set
   End Property
#End Region '(Set|Get) The ContributorUri as String.

#Region"[On] |2019/07/06 00h51:163| <01.00.41> <Property> <Columns> |.CustomProperty()|String|"' (Set|Get) The CustomProperty as String.
   Private _CustomProperty As String
    '''    <Summary>
'''     (Set|Get) The CustomProperty as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:885 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The CustomProperty as String.") >
   Public Property CustomProperty()As String
       Get
       Return _CustomProperty
       End Get
       Set(ByVal Value As String)
       _CustomProperty = Value
       End Set
   End Property
#End Region '(Set|Get) The CustomProperty as String.

#Region"[On] |2019/07/06 00h51:177| <01.00.42> <Property> <Columns> |.Published()|String|"' (Set|Get) The Published as String.
   Private _Published As String
    '''    <Summary>
'''     (Set|Get) The Published as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:885 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Published as String.") >
   Public Property Published()As String
       Get
       Return _Published
       End Get
       Set(ByVal Value As String)
       _Published = Value
       End Set
   End Property
#End Region '(Set|Get) The Published as String.

#Region"[On] |2019/07/06 00h51:188| <01.00.43> <Property> <Columns> |.Rights()|String|"' (Set|Get) The Rights as String.
   Private _Rights As String
    '''    <Summary>
'''     (Set|Get) The Rights as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:888 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Rights as String.") >
   Public Property Rights()As String
       Get
       Return _Rights
       End Get
       Set(ByVal Value As String)
       _Rights = Value
       End Set
   End Property
#End Region '(Set|Get) The Rights as String.

#Region"[On] |2019/07/06 00h51:200| <01.00.44> <Property> <Columns> |.Summary()|String|"' (Set|Get) The Summary as String.
   Private _Summary As String
    '''    <Summary>
'''     (Set|Get) The Summary as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:888 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Summary as String.") >
   Public Property Summary()As String
       Get
       Return _Summary
       End Get
       Set(ByVal Value As String)
       _Summary = Value
       End Set
   End Property
#End Region '(Set|Get) The Summary as String.

#Region"[On] |2019/07/06 00h51:214| <01.00.45> <Property> <Columns> |.Title()|String|"' (Set|Get) The Title as String.
   Private _Title As String
    '''    <Summary>
'''     (Set|Get) The Title as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:888 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Title as String.") >
   Public Property Title()As String
       Get
       Return _Title
       End Get
       Set(ByVal Value As String)
       _Title = Value
       End Set
   End Property
#End Region '(Set|Get) The Title as String.

#Region"[On] |2019/07/06 00h51:226| <01.00.46> <Property> <Columns> |.Updated()|String|"' (Set|Get) The Updated as String.
   Private _Updated As String
    '''    <Summary>
'''     (Set|Get) The Updated as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:889 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Updated as String.") >
   Public Property Updated()As String
       Get
       Return _Updated
       End Get
       Set(ByVal Value As String)
       _Updated = Value
       End Set
   End Property
#End Region '(Set|Get) The Updated as String.

#Region"[On] |2019/07/06 00h51:238| <01.00.47> <Property> <Columns> |.Usage()|String|"' (Set|Get) The Usage as String.
   Private _Usage As String
    '''    <Summary>
'''     (Set|Get) The Usage as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:889 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Usage as String.") >
   Public Property Usage()As String
       Get
       Return _Usage
       End Get
       Set(ByVal Value As String)
       _Usage = Value
       End Set
   End Property
#End Region '(Set|Get) The Usage as String.

#Region"[On] |2019/07/06 00h51:251| <01.00.48> <Property> <Columns> |.Remarks()|String|"' (Set|Get) The Remarks as String.
   Private _Remarks As String
    '''    <Summary>
'''     (Set|Get) The Remarks as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:889 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Remarks as String.") >
   Public Property Remarks()As String
       Get
       Return _Remarks
       End Get
       Set(ByVal Value As String)
       _Remarks = Value
       End Set
   End Property
#End Region '(Set|Get) The Remarks as String.

#Region"[On] |2019/07/06 00h51:265| <01.00.49> <Property> <Columns> |.Example()|String|"' (Set|Get) The Example as String.
   Private _Example As String
    '''    <Summary>
'''     (Set|Get) The Example as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:889 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Example as String.") >
   Public Property Example()As String
       Get
       Return _Example
       End Get
       Set(ByVal Value As String)
       _Example = Value
       End Set
   End Property
#End Region '(Set|Get) The Example as String.

#Region"[On] |2019/07/06 00h51:279| <01.00.50> <Property> <Columns> |.Note()|String|"' (Set|Get) The Note as String.
   Private _Note As String
    '''    <Summary>
'''     (Set|Get) The Note as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:890 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Note as String.") >
   Public Property Note()As String
       Get
       Return _Note
       End Get
       Set(ByVal Value As String)
       _Note = Value
       End Set
   End Property
#End Region '(Set|Get) The Note as String.

#Region"[On] |2019/07/06 00h51:301| <01.00.51> <Property> <Columns> |.CreationDate()|String|"' (Set|Get) The CreationDate as String.
   Private _CreationDate As String
    '''    <Summary>
'''     (Set|Get) The CreationDate as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:890 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The CreationDate as String.") >
   Public Property CreationDate()As String
       Get
       Return _CreationDate
       End Get
       Set(ByVal Value As String)
       _CreationDate = Value
       End Set
   End Property
#End Region '(Set|Get) The CreationDate as String.

#Region"[On] |2019/07/06 00h51:315| <01.00.52> <Property> <Columns> |.See()|String|"' (Set|Get) The See as String.
   Private _See As String
    '''    <Summary>
'''     (Set|Get) The See as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:893 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The See as String.") >
   Public Property See()As String
       Get
       Return _See
       End Get
       Set(ByVal Value As String)
       _See = Value
       End Set
   End Property
#End Region '(Set|Get) The See as String.

#Region"[On] |2019/07/06 00h51:327| <01.00.53> <Property> <Columns> |.SeeAlso()|String|"' (Set|Get) The SeeAlso as String.
   Private _SeeAlso As String
    '''    <Summary>
'''     (Set|Get) The SeeAlso as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:893 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The SeeAlso as String.") >
   Public Property SeeAlso()As String
       Get
       Return _SeeAlso
       End Get
       Set(ByVal Value As String)
       _SeeAlso = Value
       End Set
   End Property
#End Region '(Set|Get) The SeeAlso as String.

#Region"[On] |2019/07/06 00h51:340| <01.00.54> <Property> <Columns> |.Rules()|String|"' (Set|Get) The Rules as String.
   Private _Rules As String
    '''    <Summary>
'''     (Set|Get) The Rules as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:893 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Rules as String.") >
   Public Property Rules()As String
       Get
       Return _Rules
       End Get
       Set(ByVal Value As String)
       _Rules = Value
       End Set
   End Property
#End Region '(Set|Get) The Rules as String.

#Region"[On] |2019/07/06 00h51:353| <01.00.55> <Property> <Columns> |.Syntax()|String|"' (Set|Get) The Syntax as String.
   Private _Syntax As String
    '''    <Summary>
'''     (Set|Get) The Syntax as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:894 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Syntax as String.") >
   Public Property Syntax()As String
       Get
       Return _Syntax
       End Get
       Set(ByVal Value As String)
       _Syntax = Value
       End Set
   End Property
#End Region '(Set|Get) The Syntax as String.

#Region"[On] |2019/07/06 00h51:365| <01.00.56> <Property> <Columns> |.AccessModifier()|String|"' (Set|Get) The AccessModifier as String.
   Private _AccessModifier As String
    '''    <Summary>
'''     (Set|Get) The AccessModifier as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:894 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AccessModifier as String.") >
   Public Property AccessModifier()As String
       Get
       Return _AccessModifier
       End Get
       Set(ByVal Value As String)
       _AccessModifier = Value
       End Set
   End Property
#End Region '(Set|Get) The AccessModifier as String.

#Region"[On] |2019/07/06 00h51:378| <01.00.57> <Property> <Columns> |.ProcedureModifier()|String|"' (Set|Get) The ProcedureModifier as String.
   Private _ProcedureModifier As String
    '''    <Summary>
'''     (Set|Get) The ProcedureModifier as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:894 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ProcedureModifier as String.") >
   Public Property ProcedureModifier()As String
       Get
       Return _ProcedureModifier
       End Get
       Set(ByVal Value As String)
       _ProcedureModifier = Value
       End Set
   End Property
#End Region '(Set|Get) The ProcedureModifier as String.

#Region"[On] |2019/07/06 00h51:391| <01.00.58> <Property> <Columns> |.Partial()|Boolean|"' (Set|Get) The Partial as Boolean.
   Private _Partial As Boolean
    '''    <Summary>
'''     (Set|Get) The Partial as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:894 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Partial as Boolean.") >
   Public Property Partial()As Boolean
       Get
       Return _Partial
       End Get
       Set(ByVal Value As Boolean)
       _Partial = Value
       End Set
   End Property
#End Region '(Set|Get) The Partial as Boolean.

#Region"[On] |2019/07/06 00h51:406| <01.00.59> <Property> <Columns> |.Shared()|Boolean|"' (Set|Get) The Shared as Boolean.
   Private _Shared As Boolean
    '''    <Summary>
'''     (Set|Get) The Shared as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:895 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Shared as Boolean.") >
   Public Property Shared()As Boolean
       Get
       Return _Shared
       End Get
       Set(ByVal Value As Boolean)
       _Shared = Value
       End Set
   End Property
#End Region '(Set|Get) The Shared as Boolean.

#Region"[On] |2019/07/06 00h51:419| <01.00.60> <Property> <Columns> |.Shadows()|Boolean|"' (Set|Get) The Shadows as Boolean.
   Private _Shadows As Boolean
    '''    <Summary>
'''     (Set|Get) The Shadows as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:895 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Shadows as Boolean.") >
   Public Property Shadows()As Boolean
       Get
       Return _Shadows
       End Get
       Set(ByVal Value As Boolean)
       _Shadows = Value
       End Set
   End Property
#End Region '(Set|Get) The Shadows as Boolean.

#Region"[On] |2019/07/06 00h51:432| <01.00.61> <Property> <Columns> |.Async()|Boolean|"' (Set|Get) The Async as Boolean.
   Private _Async As Boolean
    '''    <Summary>
'''     (Set|Get) The Async as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:898 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Async as Boolean.") >
   Public Property Async()As Boolean
       Get
       Return _Async
       End Get
       Set(ByVal Value As Boolean)
       _Async = Value
       End Set
   End Property
#End Region '(Set|Get) The Async as Boolean.

#Region"[On] |2019/07/06 00h51:446| <01.00.62> <Property> <Columns> |.FunctionName()|String|"' (Set|Get) The FunctionName as String.
   Private _FunctionName As String
    '''    <Summary>
'''     (Set|Get) The FunctionName as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:898 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The FunctionName as String.") >
   Public Property FunctionName()As String
       Get
       Return _FunctionName
       End Get
       Set(ByVal Value As String)
       _FunctionName = Value
       End Set
   End Property
#End Region '(Set|Get) The FunctionName as String.

#Region"[On] |2019/07/06 00h51:460| <01.00.63> <Property> <Columns> |.Handles()|String|"' (Set|Get) The Handles as String.
   Private _Handles As String
    '''    <Summary>
'''     (Set|Get) The Handles as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:898 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Handles as String.") >
   Public Property Handles()As String
       Get
       Return _Handles
       End Get
       Set(ByVal Value As String)
       _Handles = Value
       End Set
   End Property
#End Region '(Set|Get) The Handles as String.

#Region"[On] |2019/07/06 00h51:475| <01.00.64> <Property> <Columns> |.Implements()|String|"' (Set|Get) The Implements as String.
   Private _Implements As String
    '''    <Summary>
'''     (Set|Get) The Implements as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:900 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Implements as String.") >
   Public Property Implements()As String
       Get
       Return _Implements
       End Get
       Set(ByVal Value As String)
       _Implements = Value
       End Set
   End Property
#End Region '(Set|Get) The Implements as String.

#Region"[On] |2019/07/06 00h51:489| <01.00.65> <Property> <Columns> |.ReturnType()|String|"' (Set|Get) The ReturnType as String.
   Private _ReturnType As String
    '''    <Summary>
'''     (Set|Get) The ReturnType as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:901 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ReturnType as String.") >
   Public Property ReturnType()As String
       Get
       Return _ReturnType
       End Get
       Set(ByVal Value As String)
       _ReturnType = Value
       End Set
   End Property
#End Region '(Set|Get) The ReturnType as String.

#End Region 
#Region"<2> [Enumeration]{1}"
#Region"[On] |2019/07/06 00h51:502| <02.00.00> <Enumeration> <> |.Schema()|Enumeration{65}|"' (Set|Get) The enumeration of Schema.
    '''    <Summary>
'''     (Set|Get) The enumeration of Schema.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:901 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The enumeration of Schema.") >
   Enum Schema
''' <summary>(Set|Get) The ID as Integer.</summary>
   [ID] = 0
''' <summary>(Set|Get) The Name as String.</summary>
   [Name] = 1
''' <summary>(Set|Get) The ImageIndex as Integer.</summary>
   [ImageIndex] = 2
''' <summary>(Set|Get) The Text as String.</summary>
   [Text] = 3
''' <summary>(Set|Get) The ToolTip as String.</summary>
   [ToolTip] = 4
''' <summary>(Set|Get) The Enable as Boolean.</summary>
   [Enable] = 5
''' <summary>(Set|Get) The Status as String.</summary>
   [Status] = 6
''' <summary>(Set|Get) The Statement as String.</summary>
   [Statement] = 7
''' <summary>(Set|Get) The XMLFile as String.</summary>
   [XMLFile] = 8
''' <summary>(Set|Get) The Attributes as String.</summary>
   [Attributes] = 9
''' <summary>(Set|Get) The Browsable as Boolean.</summary>
   [Browsable] = 10
''' <summary>(Set|Get) The Category as String.</summary>
   [Category] = 11
''' <summary>(Set|Get) The Description as String.</summary>
   [Description] = 12
''' <summary>(Set|Get) The DefaultValue as String.</summary>
   [DefaultValue] = 13
''' <summary>(Set|Get) The Editor as String.</summary>
   [Editor] = 14
''' <summary>(Set|Get) The DllImport as String.</summary>
   [DllImport] = 15
''' <summary>(Set|Get) The Deserializable as Boolean.</summary>
   [Deserializable] = 16
''' <summary>(Set|Get) The NonSerialized as Boolean.</summary>
   [NonSerialized] = 17
''' <summary>(Set|Get) The Serializable as Boolean.</summary>
   [Serializable] = 18
''' <summary>(Set|Get) The XmlRoot as String.</summary>
   [XmlRoot] = 19
''' <summary>(Set|Get) The XmlIgnore as Boolean.</summary>
   [XmlIgnore] = 20
''' <summary>(Set|Get) The XmlInclude as Boolean.</summary>
   [XmlInclude] = 21
''' <summary>(Set|Get) The RelatedImageList as String.</summary>
   [RelatedImageList] = 22
''' <summary>(Set|Get) The Print_VB as String.</summary>
   [Print_VB] = 23
''' <summary>(Set|Get) The VB as String.</summary>
   [VB] = 24
''' <summary>(Set|Get) The Print_C as String.</summary>
   [Print_C] = 25
''' <summary>(Set|Get) The C as String.</summary>
   [C] = 26
''' <summary>(Set|Get) The Print_F as String.</summary>
   [Print_F] = 27
''' <summary>(Set|Get) The F as String.</summary>
   [F] = 28
''' <summary>(Set|Get) The Print_Python as String.</summary>
   [Print_Python] = 29
''' <summary>(Set|Get) The Python as String.</summary>
   [Python] = 30
''' <summary>(Set|Get) The Print_JavaScript as String.</summary>
   [Print_JavaScript] = 31
''' <summary>(Set|Get) The JavaScript as String.</summary>
   [JavaScript] = 32
''' <summary>(Set|Get) The RegionCategory as Integer.</summary>
   [RegionCategory] = 33
''' <summary>(Set|Get) The RegionCode as String.</summary>
   [RegionCode] = 34
''' <summary>(Set|Get) The AuthorEmail as String.</summary>
   [AuthorEmail] = 35
''' <summary>(Set|Get) The AuthorName as String.</summary>
   [AuthorName] = 36
''' <summary>(Set|Get) The AuthorUri as String.</summary>
   [AuthorUri] = 37
''' <summary>(Set|Get) The ContributorEmail as String.</summary>
   [ContributorEmail] = 38
''' <summary>(Set|Get) The ContributorName as String.</summary>
   [ContributorName] = 39
''' <summary>(Set|Get) The ContributorUri as String.</summary>
   [ContributorUri] = 40
''' <summary>(Set|Get) The CustomProperty as String.</summary>
   [CustomProperty] = 41
''' <summary>(Set|Get) The Published as String.</summary>
   [Published] = 42
''' <summary>(Set|Get) The Rights as String.</summary>
   [Rights] = 43
''' <summary>(Set|Get) The Summary as String.</summary>
   [Summary] = 44
''' <summary>(Set|Get) The Title as String.</summary>
   [Title] = 45
''' <summary>(Set|Get) The Updated as String.</summary>
   [Updated] = 46
''' <summary>(Set|Get) The Usage as String.</summary>
   [Usage] = 47
''' <summary>(Set|Get) The Remarks as String.</summary>
   [Remarks] = 48
''' <summary>(Set|Get) The Example as String.</summary>
   [Example] = 49
''' <summary>(Set|Get) The Note as String.</summary>
   [Note] = 50
''' <summary>(Set|Get) The CreationDate as String.</summary>
   [CreationDate] = 51
''' <summary>(Set|Get) The See as String.</summary>
   [See] = 52
''' <summary>(Set|Get) The SeeAlso as String.</summary>
   [SeeAlso] = 53
''' <summary>(Set|Get) The Rules as String.</summary>
   [Rules] = 54
''' <summary>(Set|Get) The Syntax as String.</summary>
   [Syntax] = 55
''' <summary>(Set|Get) The AccessModifier as String.</summary>
   [AccessModifier] = 56
''' <summary>(Set|Get) The ProcedureModifier as String.</summary>
   [ProcedureModifier] = 57
''' <summary>(Set|Get) The Partial as Boolean.</summary>
   [Partial] = 58
''' <summary>(Set|Get) The Shared as Boolean.</summary>
   [Shared] = 59
''' <summary>(Set|Get) The Shadows as Boolean.</summary>
   [Shadows] = 60
''' <summary>(Set|Get) The Async as Boolean.</summary>
   [Async] = 61
''' <summary>(Set|Get) The FunctionName as String.</summary>
   [FunctionName] = 62
''' <summary>(Set|Get) The Handles as String.</summary>
   [Handles] = 63
''' <summary>(Set|Get) The Implements as String.</summary>
   [Implements] = 64
''' <summary>(Set|Get) The ReturnType as String.</summary>
   [ReturnType] = 65
   End Enum
#End Region '(Set|Get) The enumeration of Schema.

#End Region 
#Region "<4> [Sub]{5}"
#Region"[On] |2019/07/06 00h51:531| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
    '''    <Summary>
'''     (Set|Get) This will reinitialize the class element.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:902 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) This will reinitialize the class element.") >
   Public Sub Clear()
  With Me
        .ID = 0
        .Name = Nothing
        .ImageIndex = 0
        .Text = Nothing
        .ToolTip = Nothing
        .Enable = False
        .Status = Nothing
        .Statement = Nothing
        .XMLFile = Nothing
        .Attributes = Nothing
        .Browsable = False
        .Category = Nothing
        .Description = Nothing
        .DefaultValue = Nothing
        .Editor = Nothing
        .DllImport = Nothing
        .Deserializable = False
        .NonSerialized = False
        .Serializable = False
        .XmlRoot = Nothing
        .XmlIgnore = False
        .XmlInclude = False
        .RelatedImageList = Nothing
        .Print_VB = Nothing
        .VB = Nothing
        .Print_C = Nothing
        .C = Nothing
        .Print_F = Nothing
        .F = Nothing
        .Print_Python = Nothing
        .Python = Nothing
        .Print_JavaScript = Nothing
        .JavaScript = Nothing
        .RegionCategory = 0
        .RegionCode = Nothing
        .AuthorEmail = Nothing
        .AuthorName = Nothing
        .AuthorUri = Nothing
        .ContributorEmail = Nothing
        .ContributorName = Nothing
        .ContributorUri = Nothing
        .CustomProperty = Nothing
        .Published = Nothing
        .Rights = Nothing
        .Summary = Nothing
        .Title = Nothing
        .Updated = Nothing
        .Usage = Nothing
        .Remarks = Nothing
        .Example = Nothing
        .Note = Nothing
        .CreationDate = Nothing
        .See = Nothing
        .SeeAlso = Nothing
        .Rules = Nothing
        .Syntax = Nothing
        .AccessModifier = Nothing
        .ProcedureModifier = Nothing
        .Partial = False
        .Shared = False
        .Shadows = False
        .Async = False
        .FunctionName = Nothing
        .Handles = Nothing
        .Implements = Nothing
        .ReturnType = Nothing
 End With
   End Sub
#End Region '(Set|Get) This will reinitialize the class element.

#Region"[On] |2019/07/06 00h51:548| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
    '''    <Summary>
'''     (Set|Get) This will reinitialize the variables of this class.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:902 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) This will reinitialize the variables of this class.") >
   Public Sub Reset(Optional ByVal Connector As LineInfo = Nothing)
If Not IsNothing(Connector) Then
   Me.Connector=Connector
   Me.FilePath=""
   Me.Password=""
   Me.Line=""
   If Connector.Status<>Status.Broken Then 
        FilePath = Connector.FilePath
        Password = Connector.Password
        Me.Connector=Connector
        TableName = "Function"
        Line = Connector.Line
        UseSQL = False
   Else
        FilePath = My.Settings.Db_ProjectDatabase_FilePath
        Password = My.Settings.Db_ProjectDatabase_Password
        Me.Line = My.Settings.Db_ProjectDatabase_Line
        TableName = "Function"
        UseSQL = False
   End If
Else
        If IsNothing(FilePath) Then 
             FilePath = My.Settings.Db_ProjectDatabase_FilePath
        End If 
        If FilePath.Length<1 Then 
             FilePath = My.Settings.Db_ProjectDatabase_FilePath
        End If 
        FilePath = My.Settings.Db_ProjectDatabase_FilePath
        Password = My.Settings.Db_ProjectDatabase_Password
        Me.Line = My.Settings.Db_ProjectDatabase_Line
        TableName = "Function"
        UseSQL = False
End If

   End Sub
#End Region '(Set|Get) This will reinitialize the variables of this class.

#Region"[On] |2019/07/06 00h51:562| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
    '''    <Summary>
'''     (Set|Get) This will add a new row in the table.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:902 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) This will add a new row in the table.") >
   Public Sub Add()
 Try
   Dim Str As String = Nothing
   Str = "Insert Into [Function] (
`ID`, 
`Name`, 
`ImageIndex`, 
`Text`, 
`ToolTip`, 
`Enable`, 
`Status`, 
`Statement`, 
`XMLFile`, 
`Attributes`, 
`Browsable`, 
`Category`, 
`Description`, 
`DefaultValue`, 
`Editor`, 
`DllImport`, 
`Deserializable`, 
`NonSerialized`, 
`Serializable`, 
`XmlRoot`, 
`XmlIgnore`, 
`XmlInclude`, 
`RelatedImageList`, 
`Print_VB`, 
`VB`, 
`Print_C`, 
`C`, 
`Print_F`, 
`F`, 
`Print_Python`, 
`Python`, 
`Print_JavaScript`, 
`JavaScript`, 
`RegionCategory`, 
`RegionCode`, 
`AuthorEmail`, 
`AuthorName`, 
`AuthorUri`, 
`ContributorEmail`, 
`ContributorName`, 
`ContributorUri`, 
`CustomProperty`, 
`Published`, 
`Rights`, 
`Summary`, 
`Title`, 
`Updated`, 
`Usage`, 
`Remarks`, 
`Example`, 
`Note`, 
`CreationDate`, 
`See`, 
`SeeAlso`, 
`Rules`, 
`Syntax`, 
`AccessModifier`, 
`ProcedureModifier`, 
`Partial`, 
`Shared`, 
`Shadows`, 
`Async`, 
`FunctionName`, 
`Handles`, 
`Implements`, 
`ReturnType`) Values (@0, @1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18, @19, @20, @21, @22, @23, @24, @25, @26, @27, @28, @29, @30, @31, @32, @33, @34, @35, @36, @37, @38, @39, @40, @41, @42, @43, @44, @45, @46, @47, @48, @49, @50, @51, @52, @53, @54, @55, @56, @57, @58, @59, @60, @61, @62, @63, @64, @65)"
Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
Cmd = New OleDb.OleDbCommand(Str,Con)
Con.Open()
            Cmd.Parameters.AddWithValue("@0", Me.ID)
            Cmd.Parameters.AddWithValue("@1", Me.Name)
            Cmd.Parameters.AddWithValue("@2", Me.ImageIndex)
            Cmd.Parameters.AddWithValue("@3", Me.Text)
            Cmd.Parameters.AddWithValue("@4", Me.ToolTip)
            Cmd.Parameters.AddWithValue("@5", Me.Enable)
            Cmd.Parameters.AddWithValue("@6", Me.Status)
            Cmd.Parameters.AddWithValue("@7", Me.Statement)
            Cmd.Parameters.AddWithValue("@8", Me.XMLFile)
            Cmd.Parameters.AddWithValue("@9", Me.Attributes)
            Cmd.Parameters.AddWithValue("@10", Me.Browsable)
            Cmd.Parameters.AddWithValue("@11", Me.Category)
            Cmd.Parameters.AddWithValue("@12", Me.Description)
            Cmd.Parameters.AddWithValue("@13", Me.DefaultValue)
            Cmd.Parameters.AddWithValue("@14", Me.Editor)
            Cmd.Parameters.AddWithValue("@15", Me.DllImport)
            Cmd.Parameters.AddWithValue("@16", Me.Deserializable)
            Cmd.Parameters.AddWithValue("@17", Me.NonSerialized)
            Cmd.Parameters.AddWithValue("@18", Me.Serializable)
            Cmd.Parameters.AddWithValue("@19", Me.XmlRoot)
            Cmd.Parameters.AddWithValue("@20", Me.XmlIgnore)
            Cmd.Parameters.AddWithValue("@21", Me.XmlInclude)
            Cmd.Parameters.AddWithValue("@22", Me.RelatedImageList)
            Cmd.Parameters.AddWithValue("@23", Me.Print_VB)
            Cmd.Parameters.AddWithValue("@24", Me.VB)
            Cmd.Parameters.AddWithValue("@25", Me.Print_C)
            Cmd.Parameters.AddWithValue("@26", Me.C)
            Cmd.Parameters.AddWithValue("@27", Me.Print_F)
            Cmd.Parameters.AddWithValue("@28", Me.F)
            Cmd.Parameters.AddWithValue("@29", Me.Print_Python)
            Cmd.Parameters.AddWithValue("@30", Me.Python)
            Cmd.Parameters.AddWithValue("@31", Me.Print_JavaScript)
            Cmd.Parameters.AddWithValue("@32", Me.JavaScript)
            Cmd.Parameters.AddWithValue("@33", Me.RegionCategory)
            Cmd.Parameters.AddWithValue("@34", Me.RegionCode)
            Cmd.Parameters.AddWithValue("@35", Me.AuthorEmail)
            Cmd.Parameters.AddWithValue("@36", Me.AuthorName)
            Cmd.Parameters.AddWithValue("@37", Me.AuthorUri)
            Cmd.Parameters.AddWithValue("@38", Me.ContributorEmail)
            Cmd.Parameters.AddWithValue("@39", Me.ContributorName)
            Cmd.Parameters.AddWithValue("@40", Me.ContributorUri)
            Cmd.Parameters.AddWithValue("@41", Me.CustomProperty)
            Cmd.Parameters.AddWithValue("@42", Me.Published)
            Cmd.Parameters.AddWithValue("@43", Me.Rights)
            Cmd.Parameters.AddWithValue("@44", Me.Summary)
            Cmd.Parameters.AddWithValue("@45", Me.Title)
            Cmd.Parameters.AddWithValue("@46", Me.Updated)
            Cmd.Parameters.AddWithValue("@47", Me.Usage)
            Cmd.Parameters.AddWithValue("@48", Me.Remarks)
            Cmd.Parameters.AddWithValue("@49", Me.Example)
            Cmd.Parameters.AddWithValue("@50", Me.Note)
            Cmd.Parameters.AddWithValue("@51", Me.CreationDate)
            Cmd.Parameters.AddWithValue("@52", Me.See)
            Cmd.Parameters.AddWithValue("@53", Me.SeeAlso)
            Cmd.Parameters.AddWithValue("@54", Me.Rules)
            Cmd.Parameters.AddWithValue("@55", Me.Syntax)
            Cmd.Parameters.AddWithValue("@56", Me.AccessModifier)
            Cmd.Parameters.AddWithValue("@57", Me.ProcedureModifier)
            Cmd.Parameters.AddWithValue("@58", Me.Partial)
            Cmd.Parameters.AddWithValue("@59", Me.Shared)
            Cmd.Parameters.AddWithValue("@60", Me.Shadows)
            Cmd.Parameters.AddWithValue("@61", Me.Async)
            Cmd.Parameters.AddWithValue("@62", Me.FunctionName)
            Cmd.Parameters.AddWithValue("@63", Me.Handles)
            Cmd.Parameters.AddWithValue("@64", Me.Implements)
            Cmd.Parameters.AddWithValue("@65", Me.ReturnType)
          If Cmd.ExecuteNonQuery>=0 Then
          Else
              Msgbox("Element not Addd")
          End If
 Catch ex As Exception 
 Finally 
   Close(True) 
 End Try 

   End Sub
#End Region '(Set|Get) This will add a new row in the table.

#Region"[On] |2019/07/06 00h51:584| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
    '''    <Summary>
'''     (Set|Get) This will update a row in the table.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:903 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) This will update a row in the table.") >
   Public Sub Save()
 Try
   Dim Str As String = Nothing
   Str = "UPDATE [Function] SET Name = @Name, ImageIndex = @ImageIndex, Text = @Text, ToolTip = @ToolTip, Enable = @Enable, Status = @Status, Statement = @Statement, XMLFile = @XMLFile, Attributes = @Attributes, Browsable = @Browsable, Category = @Category, Description = @Description, DefaultValue = @DefaultValue, Editor = @Editor, DllImport = @DllImport, Deserializable = @Deserializable, NonSerialized = @NonSerialized, Serializable = @Serializable, XmlRoot = @XmlRoot, XmlIgnore = @XmlIgnore, XmlInclude = @XmlInclude, RelatedImageList = @RelatedImageList, Print_VB = @Print_VB, VB = @VB, Print_C = @Print_C, C = @C, Print_F = @Print_F, F = @F, Print_Python = @Print_Python, Python = @Python, Print_JavaScript = @Print_JavaScript, JavaScript = @JavaScript, RegionCategory = @RegionCategory, RegionCode = @RegionCode, AuthorEmail = @AuthorEmail, AuthorName = @AuthorName, AuthorUri = @AuthorUri, ContributorEmail = @ContributorEmail, ContributorName = @ContributorName, ContributorUri = @ContributorUri, CustomProperty = @CustomProperty, Published = @Published, Rights = @Rights, Summary = @Summary, Title = @Title, Updated = @Updated, Usage = @Usage, Remarks = @Remarks, Example = @Example, Note = @Note, CreationDate = @CreationDate, See = @See, SeeAlso = @SeeAlso, Rules = @Rules, Syntax = @Syntax, AccessModifier = @AccessModifier, ProcedureModifier = @ProcedureModifier, Partial = @Partial, Shared = @Shared, Shadows = @Shadows, Async = @Async, FunctionName = @FunctionName, Handles = @Handles, Implements = @Implements, ReturnType = @ReturnType WHERE ID = @ID"
Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
Cmd = New OleDb.OleDbCommand(Str,Con)
Con.Open()
      Cmd.Parameters.AddWithValue("@Name",Name)
      Cmd.Parameters.AddWithValue("@ImageIndex",ImageIndex)
      Cmd.Parameters.AddWithValue("@Text",Text)
      Cmd.Parameters.AddWithValue("@ToolTip",ToolTip)
      Cmd.Parameters.AddWithValue("@Enable",Enable)
      Cmd.Parameters.AddWithValue("@Status",Status)
      Cmd.Parameters.AddWithValue("@Statement",Statement)
      Cmd.Parameters.AddWithValue("@XMLFile",XMLFile)
      Cmd.Parameters.AddWithValue("@Attributes",Attributes)
      Cmd.Parameters.AddWithValue("@Browsable",Browsable)
      Cmd.Parameters.AddWithValue("@Category",Category)
      Cmd.Parameters.AddWithValue("@Description",Description)
      Cmd.Parameters.AddWithValue("@DefaultValue",DefaultValue)
      Cmd.Parameters.AddWithValue("@Editor",Editor)
      Cmd.Parameters.AddWithValue("@DllImport",DllImport)
      Cmd.Parameters.AddWithValue("@Deserializable",Deserializable)
      Cmd.Parameters.AddWithValue("@NonSerialized",NonSerialized)
      Cmd.Parameters.AddWithValue("@Serializable",Serializable)
      Cmd.Parameters.AddWithValue("@XmlRoot",XmlRoot)
      Cmd.Parameters.AddWithValue("@XmlIgnore",XmlIgnore)
      Cmd.Parameters.AddWithValue("@XmlInclude",XmlInclude)
      Cmd.Parameters.AddWithValue("@RelatedImageList",RelatedImageList)
      Cmd.Parameters.AddWithValue("@Print_VB",Print_VB)
      Cmd.Parameters.AddWithValue("@VB",VB)
      Cmd.Parameters.AddWithValue("@Print_C",Print_C)
      Cmd.Parameters.AddWithValue("@C",C)
      Cmd.Parameters.AddWithValue("@Print_F",Print_F)
      Cmd.Parameters.AddWithValue("@F",F)
      Cmd.Parameters.AddWithValue("@Print_Python",Print_Python)
      Cmd.Parameters.AddWithValue("@Python",Python)
      Cmd.Parameters.AddWithValue("@Print_JavaScript",Print_JavaScript)
      Cmd.Parameters.AddWithValue("@JavaScript",JavaScript)
      Cmd.Parameters.AddWithValue("@RegionCategory",RegionCategory)
      Cmd.Parameters.AddWithValue("@RegionCode",RegionCode)
      Cmd.Parameters.AddWithValue("@AuthorEmail",AuthorEmail)
      Cmd.Parameters.AddWithValue("@AuthorName",AuthorName)
      Cmd.Parameters.AddWithValue("@AuthorUri",AuthorUri)
      Cmd.Parameters.AddWithValue("@ContributorEmail",ContributorEmail)
      Cmd.Parameters.AddWithValue("@ContributorName",ContributorName)
      Cmd.Parameters.AddWithValue("@ContributorUri",ContributorUri)
      Cmd.Parameters.AddWithValue("@CustomProperty",CustomProperty)
      Cmd.Parameters.AddWithValue("@Published",Published)
      Cmd.Parameters.AddWithValue("@Rights",Rights)
      Cmd.Parameters.AddWithValue("@Summary",Summary)
      Cmd.Parameters.AddWithValue("@Title",Title)
      Cmd.Parameters.AddWithValue("@Updated",Updated)
      Cmd.Parameters.AddWithValue("@Usage",Usage)
      Cmd.Parameters.AddWithValue("@Remarks",Remarks)
      Cmd.Parameters.AddWithValue("@Example",Example)
      Cmd.Parameters.AddWithValue("@Note",Note)
      Cmd.Parameters.AddWithValue("@CreationDate",CreationDate)
      Cmd.Parameters.AddWithValue("@See",See)
      Cmd.Parameters.AddWithValue("@SeeAlso",SeeAlso)
      Cmd.Parameters.AddWithValue("@Rules",Rules)
      Cmd.Parameters.AddWithValue("@Syntax",Syntax)
      Cmd.Parameters.AddWithValue("@AccessModifier",AccessModifier)
      Cmd.Parameters.AddWithValue("@ProcedureModifier",ProcedureModifier)
      Cmd.Parameters.AddWithValue("@Partial",Partial)
      Cmd.Parameters.AddWithValue("@Shared",Shared)
      Cmd.Parameters.AddWithValue("@Shadows",Shadows)
      Cmd.Parameters.AddWithValue("@Async",Async)
      Cmd.Parameters.AddWithValue("@FunctionName",FunctionName)
      Cmd.Parameters.AddWithValue("@Handles",Handles)
      Cmd.Parameters.AddWithValue("@Implements",Implements)
      Cmd.Parameters.AddWithValue("@ReturnType",ReturnType)
      Cmd.Parameters.AddWithValue("@ID",ID)
          If Cmd.ExecuteNonQuery>=0 Then
          Else
              Msgbox("Element not Saved")
          End If
 Catch ex As Exception 
 Finally 
   Close(True) 
 End Try 

   End Sub
#End Region '(Set|Get) This will update a row in the table.

#Region"[On] |2019/07/06 00h51:599| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
    '''    <Summary>
'''     (Set|Get) This will Delete a row in the table.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:903 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) This will Delete a row in the table.") >
   Public Sub Delete()
 Try
   Dim Str As String = Nothing
   Str = "Delete From [Function] WHERE ID =@ID"
Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
Cmd = New OleDb.OleDbCommand(Str,Con)
Con.Open()
Cmd.Parameters.AddWithValue("@ID", ID)
          If Cmd.ExecuteNonQuery>=0 Then
          Else
              Msgbox("Element not Deleted")
          End If
 Catch ex As Exception 
 Finally 
   Close(True) 
 End Try 

   End Sub
#End Region '(Set|Get) This will Delete a row in the table.

#End Region 
#Region "<5> [Function]{7}"
#Region"[On] |2019/07/06 00h51:614| <05.00.00> <Function> <> |.Open()|TestItem}|"' (Set|Get) This will initialise the connection and import the data.
    '''    <Summary>
'''     (Set|Get) This will initialise the connection and import the data.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:903 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) This will initialise the connection and import the data.") >
   Public Function Open(ByVal SqlCommand As String) As TestItem
 Dim Result As New TestItem("Open(SqlCommand)", " Openning the connection line to the database.")
 If CheckConnection()=True Then
                     Con = New OleDb.OleDbConnection(Me.Line)
                     Cmd = New OleDb.OleDbCommand(SqlCommand,Con)
                         If Con.State = ConnectionState.Open Then
                             Close(True)
                         Else
                             Try
                                 Con.Open()
                                 Result.Status = Status.Online
                             Catch ex As Exception
                                 Result.AddBug(ex,"Error while opening database","SqlCon.Open()")
                                 Result.Why+= ex.Message & vbNewLine
                                 Result.Status = Status.Broken
                             End Try
                         End If
     Else
         Result.Status = Status.Broken
         Result.Why += Log & VbNewLine 
     End If
 Return Result

   End Function
#End Region '(Set|Get) This will initialise the connection and import the data.

#Region"[On] |2019/07/06 00h51:629| <05.00.01> <Function> <> |.Close()|TestItem}|"' (Set|Get) This willClosing the connection
    '''    <Summary>
'''     (Set|Get) This willClosing the connection
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:903 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) This willClosing the connection") >
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
                                 Result.Why +="The connection will not close." & vbNewLine
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
                                 Result.Why +="The connection will not close." & vbNewLine
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
                                 Result.Why +="The connection will not close." & vbNewLine
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
                                 Result.Why +="The connection will not close." & vbNewLine
                             End If
                     End If
             End If
         End If
 Return Result

   End Function
#End Region '(Set|Get) This willClosing the connection

#Region"[On] |2019/07/06 00h51:644| <05.00.02> <Function> <> |.List()|List(Of Function)}|"' (Set|Get) Return the entire table listed
    '''    <Summary>
'''     (Set|Get) Return the entire table listed
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:904 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) Return the entire table listed") >
   Public Function List() As List(Of Function)
Dim Result As New List(Of Function)
Me.Table = New Table(Me.TableName , Me.FilePath , Me.Password,False)
   For each Row As DataRow In Me.Table.DataTable.Rows
      Dim Element As New Function(IIf(IsDBNull(Row.Item(0)),0,Row.Item(0)),
IIf(IsDBNull(Row.Item(1)),"",Row.Item(1)),
IIf(IsDBNull(Row.Item(2)),0,Row.Item(2)),
IIf(IsDBNull(Row.Item(3)),"",Row.Item(3)),
IIf(IsDBNull(Row.Item(4)),"",Row.Item(4)),
IIf(IsDBNull(Row.Item(5)),False,Row.Item(5)),
IIf(IsDBNull(Row.Item(6)),"",Row.Item(6)),
IIf(IsDBNull(Row.Item(7)),"",Row.Item(7)),
IIf(IsDBNull(Row.Item(8)),"",Row.Item(8)),
IIf(IsDBNull(Row.Item(9)),"",Row.Item(9)),
IIf(IsDBNull(Row.Item(10)),False,Row.Item(10)),
IIf(IsDBNull(Row.Item(11)),"",Row.Item(11)),
IIf(IsDBNull(Row.Item(12)),"",Row.Item(12)),
IIf(IsDBNull(Row.Item(13)),"",Row.Item(13)),
IIf(IsDBNull(Row.Item(14)),"",Row.Item(14)),
IIf(IsDBNull(Row.Item(15)),"",Row.Item(15)),
IIf(IsDBNull(Row.Item(16)),False,Row.Item(16)),
IIf(IsDBNull(Row.Item(17)),False,Row.Item(17)),
IIf(IsDBNull(Row.Item(18)),False,Row.Item(18)),
IIf(IsDBNull(Row.Item(19)),"",Row.Item(19)),
IIf(IsDBNull(Row.Item(20)),False,Row.Item(20)),
IIf(IsDBNull(Row.Item(21)),False,Row.Item(21)),
IIf(IsDBNull(Row.Item(22)),"",Row.Item(22)),
IIf(IsDBNull(Row.Item(23)),"",Row.Item(23)),
IIf(IsDBNull(Row.Item(24)),"",Row.Item(24)),
IIf(IsDBNull(Row.Item(25)),"",Row.Item(25)),
IIf(IsDBNull(Row.Item(26)),"",Row.Item(26)),
IIf(IsDBNull(Row.Item(27)),"",Row.Item(27)),
IIf(IsDBNull(Row.Item(28)),"",Row.Item(28)),
IIf(IsDBNull(Row.Item(29)),"",Row.Item(29)),
IIf(IsDBNull(Row.Item(30)),"",Row.Item(30)),
IIf(IsDBNull(Row.Item(31)),"",Row.Item(31)),
IIf(IsDBNull(Row.Item(32)),"",Row.Item(32)),
IIf(IsDBNull(Row.Item(33)),0,Row.Item(33)),
IIf(IsDBNull(Row.Item(34)),"",Row.Item(34)),
IIf(IsDBNull(Row.Item(35)),"",Row.Item(35)),
IIf(IsDBNull(Row.Item(36)),"",Row.Item(36)),
IIf(IsDBNull(Row.Item(37)),"",Row.Item(37)),
IIf(IsDBNull(Row.Item(38)),"",Row.Item(38)),
IIf(IsDBNull(Row.Item(39)),"",Row.Item(39)),
IIf(IsDBNull(Row.Item(40)),"",Row.Item(40)),
IIf(IsDBNull(Row.Item(41)),"",Row.Item(41)),
IIf(IsDBNull(Row.Item(42)),"",Row.Item(42)),
IIf(IsDBNull(Row.Item(43)),"",Row.Item(43)),
IIf(IsDBNull(Row.Item(44)),"",Row.Item(44)),
IIf(IsDBNull(Row.Item(45)),"",Row.Item(45)),
IIf(IsDBNull(Row.Item(46)),"",Row.Item(46)),
IIf(IsDBNull(Row.Item(47)),"",Row.Item(47)),
IIf(IsDBNull(Row.Item(48)),"",Row.Item(48)),
IIf(IsDBNull(Row.Item(49)),"",Row.Item(49)),
IIf(IsDBNull(Row.Item(50)),"",Row.Item(50)),
IIf(IsDBNull(Row.Item(51)),"",Row.Item(51)),
IIf(IsDBNull(Row.Item(52)),"",Row.Item(52)),
IIf(IsDBNull(Row.Item(53)),"",Row.Item(53)),
IIf(IsDBNull(Row.Item(54)),"",Row.Item(54)),
IIf(IsDBNull(Row.Item(55)),"",Row.Item(55)),
IIf(IsDBNull(Row.Item(56)),"",Row.Item(56)),
IIf(IsDBNull(Row.Item(57)),"",Row.Item(57)),
IIf(IsDBNull(Row.Item(58)),False,Row.Item(58)),
IIf(IsDBNull(Row.Item(59)),False,Row.Item(59)),
IIf(IsDBNull(Row.Item(60)),False,Row.Item(60)),
IIf(IsDBNull(Row.Item(61)),False,Row.Item(61)),
IIf(IsDBNull(Row.Item(62)),"",Row.Item(62)),
IIf(IsDBNull(Row.Item(63)),"",Row.Item(63)),
IIf(IsDBNull(Row.Item(64)),"",Row.Item(64)),
      IIf(IsDBNull(Row.Item(65)),"",Row.Item(65)))
      Element.Reset(Table.Line)
 Result.Add(Element)
 Next
 Return Result
   End Function
#End Region '(Set|Get) Return the entire table listed

#Region"[On] |2019/07/06 00h51:660| <05.00.03> <Function> <> |.SearchByName()|List(Of Function)}|"' (Set|Get) Search for each property that match the Search String.
    '''    <Summary>
'''     (Set|Get) Search for each property that match the Search String.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:904 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) Search for each property that match the Search String.") >
   Public Shared Function SearchByName(ByVal Search As String) As List(Of Function)
Dim Result As New List(Of Function)
 Dim C As New Function
 For Each Element As Function In C.List
 If Element.Name.Tolower() = Search.Tolower() Or Element.Text.Tolower() = Search.Tolower()  Or Element.ToolTip.Tolower() = Search.Tolower()  Or Element.Status.Tolower() = Search.Tolower()  Or Element.Statement.Tolower() = Search.Tolower()  Or Element.XMLFile.Tolower() = Search.Tolower()  Or Element.Attributes.Tolower() = Search.Tolower()  Or Element.Category.Tolower() = Search.Tolower()  Or Element.Description.Tolower() = Search.Tolower()  Or Element.DefaultValue.Tolower() = Search.Tolower()  Or Element.Editor.Tolower() = Search.Tolower()  Or Element.DllImport.Tolower() = Search.Tolower()  Or Element.XmlRoot.Tolower() = Search.Tolower()  Or Element.RelatedImageList.Tolower() = Search.Tolower()  Or Element.Print_VB.Tolower() = Search.Tolower()  Or Element.VB.Tolower() = Search.Tolower()  Or Element.Print_C.Tolower() = Search.Tolower()  Or Element.C.Tolower() = Search.Tolower()  Or Element.Print_F.Tolower() = Search.Tolower()  Or Element.F.Tolower() = Search.Tolower()  Or Element.Print_Python.Tolower() = Search.Tolower()  Or Element.Python.Tolower() = Search.Tolower()  Or Element.Print_JavaScript.Tolower() = Search.Tolower()  Or Element.JavaScript.Tolower() = Search.Tolower()  Or Element.RegionCode.Tolower() = Search.Tolower()  Or Element.AuthorEmail.Tolower() = Search.Tolower()  Or Element.AuthorName.Tolower() = Search.Tolower()  Or Element.AuthorUri.Tolower() = Search.Tolower()  Or Element.ContributorEmail.Tolower() = Search.Tolower()  Or Element.ContributorName.Tolower() = Search.Tolower()  Or Element.ContributorUri.Tolower() = Search.Tolower()  Or Element.CustomProperty.Tolower() = Search.Tolower()  Or Element.Published.Tolower() = Search.Tolower()  Or Element.Rights.Tolower() = Search.Tolower()  Or Element.Summary.Tolower() = Search.Tolower()  Or Element.Title.Tolower() = Search.Tolower()  Or Element.Updated.Tolower() = Search.Tolower()  Or Element.Usage.Tolower() = Search.Tolower()  Or Element.Remarks.Tolower() = Search.Tolower()  Or Element.Example.Tolower() = Search.Tolower()  Or Element.Note.Tolower() = Search.Tolower()  Or Element.CreationDate.Tolower() = Search.Tolower()  Or Element.See.Tolower() = Search.Tolower()  Or Element.SeeAlso.Tolower() = Search.Tolower()  Or Element.Rules.Tolower() = Search.Tolower()  Or Element.Syntax.Tolower() = Search.Tolower()  Or Element.AccessModifier.Tolower() = Search.Tolower()  Or Element.ProcedureModifier.Tolower() = Search.Tolower()  Or Element.FunctionName.Tolower() = Search.Tolower()  Or Element.Handles.Tolower() = Search.Tolower()  Or Element.Implements.Tolower() = Search.Tolower()  Or Element.ReturnType.Tolower() = Search.Tolower() Then
      Result.Add(Element)
 End If
 Next
 Return Result
   End Function
#End Region '(Set|Get) Search for each property that match the Search String.

#Region"[On] |2019/07/06 00h51:677| <05.00.04> <Function> <> |.SearchByID()|List(Of Function)}|"' (Set|Get) Search for each property that match the Search Id.
    '''    <Summary>
'''     (Set|Get) Search for each property that match the Search Id.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:904 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) Search for each property that match the Search Id.") >
   Public Shared Function SearchByID(ByVal Search As Double) As List(Of Function)
Dim Result As New List(Of Function)
 Dim C As New Function
 For Each Element As Function In C.List
 If Val(Element.ID) = Search Or Val(Element.ImageIndex) = Search  Or Val(Element.RegionCategory) = Search Then
      Result.Add(Element)
 End If
 Next
 Return Result
   End Function
#End Region '(Set|Get) Search for each property that match the Search Id.

#Region"[On] |2019/07/06 00h51:692| <05.00.05> <Function> <> |.ToString()|String}|"' (Set|Get) The function ToString.
    '''    <Summary>
'''     (Set|Get) The function ToString.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:904 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The function ToString.") >
   Public Overrides Function ToString() As String
    Return Me.ID
   End Function
#End Region '(Set|Get) The function ToString.

#Region"[On] |2019/07/06 00h51:708| <05.00.06> <Function> <> |.CheckConnection()|Boolean}|"' (Set|Get) Evaluate the connection to the DataBase
    '''    <Summary>
'''     (Set|Get) Evaluate the connection to the DataBase
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:904 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) Evaluate the connection to the DataBase") >
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
    Dim Message As String = Nothing' Stores the process logic.
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
        If D.IsReady  Then
            Test_4 = True
        Message += "Test 4 <Result> |OK| The Drive is Online."
        Else
            Test_4 = False
        Message += "Test 4 <Result> |PB| The Drive is Offline or Disconnected."
        End If
 #End Region 
 #Region "Test 5 | Evaluate if there is a Password."
        If Not IsDbNull(Password) Then
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
                    Me.Connector = New LineInfo(FilePath,Password)
                    Me.Line = Me.Connector.Line
        Message += "Test 6 <Result> |Initialize Connector|"
                End If
        End If
 #End Region 
 #Region "Test 7 | Evaluate if Connector Line is not empty."
        If Not IsDbNull(Me.Connector.Line) Then
            Test_7 = True
        Else 
            Test_7 = False
        End If
 #End Region 
 #Region "Test 8 | Evaluate if the Connection is valid."
        If Test_7 =True Then
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
 If Test_7=True And Test_8 = True Then
    General_Status=True
 Else 
    General_Status=False
 End If
 Log+=Message & VbNewLine
 Return General_Status

   End Function
#End Region '(Set|Get) Evaluate the connection to the DataBase

#End Region 
#Region "<6> [Runtime]{12}"
#Region"[On] |2019/07/06 00h51:728| <15.00.00> <Runtime> <> |.Table()|Table"' (Set|Get) The Table.
    '''    <Summary>
'''     (Set|Get) The Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:905 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The Table.") >
   Public  Table As Table
#End Region '(Set|Get) The Table.

#Region"[On] |2019/07/06 00h51:743| <15.00.01> <Runtime> <> |.Line()|String"' (Set|Get) The Connection String To the Table.
    '''    <Summary>
'''     (Set|Get) The Connection String To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:905 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The Connection String To the Table.") >
   Public  Line As String
#End Region '(Set|Get) The Connection String To the Table.

#Region"[On] |2019/07/06 00h51:757| <15.00.02> <Runtime> <> |.FilePath()|String"' (Set|Get) The FilePath To the Table.
    '''    <Summary>
'''     (Set|Get) The FilePath To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:905 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The FilePath To the Table.") >
   Public  FilePath As String
#End Region '(Set|Get) The FilePath To the Table.

#Region"[On] |2019/07/06 00h51:772| <15.00.03> <Runtime> <> |.Password()|String"' (Set|Get) The Password To the Table.
    '''    <Summary>
'''     (Set|Get) The Password To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:906 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The Password To the Table.") >
   Public  Password As String
#End Region '(Set|Get) The Password To the Table.

#Region"[On] |2019/07/06 00h51:787| <15.00.04> <Runtime> <> |.UseSQL()|Boolean"' (Set|Get) Determines if the Database Connection is of type SQL.
    '''    <Summary>
'''     (Set|Get) Determines if the Database Connection is of type SQL.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:906 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) Determines if the Database Connection is of type SQL.") >
   Public  UseSQL As Boolean
#End Region '(Set|Get) Determines if the Database Connection is of type SQL.

#Region"[On] |2019/07/06 00h51:802| <15.00.05> <Runtime> <> |.TableName()|String"' (Set|Get) The name of the Table.
    '''    <Summary>
'''     (Set|Get) The name of the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:908 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The name of the Table.") >
   Public  TableName As String
#End Region '(Set|Get) The name of the Table.

#Region"[On] |2019/07/06 00h51:817| <15.00.06> <Runtime> <> |.Con()|OleDb.OleDbConnection"' (Set|Get) The Con To the Table.
    '''    <Summary>
'''     (Set|Get) The Con To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:908 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The Con To the Table.") >
   Public  Con As OleDb.OleDbConnection
#End Region '(Set|Get) The Con To the Table.

#Region"[On] |2019/07/06 00h51:823| <15.00.07> <Runtime> <> |.Cmd()|OleDb.OleDbCommand"' (Set|Get) The Cmd To the Table.
    '''    <Summary>
'''     (Set|Get) The Cmd To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:908 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The Cmd To the Table.") >
   Public  Cmd As OleDb.OleDbCommand
#End Region '(Set|Get) The Cmd To the Table.

#Region"[On] |2019/07/06 00h51:838| <15.00.08> <Runtime> <> |.DataReader()|OleDb.OleDbDataReader"' (Set|Get) The DataReader To the Table.
    '''    <Summary>
'''     (Set|Get) The DataReader To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:909 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The DataReader To the Table.") >
   Public  DataReader As OleDb.OleDbDataReader
#End Region '(Set|Get) The DataReader To the Table.

#Region"[On] |2019/07/06 00h51:852| <15.00.09> <Runtime> <> |.DataAdapter()|OleDb.OleDbDataAdapter"' (Set|Get) The DataAdapter To the Table.
    '''    <Summary>
'''     (Set|Get) The DataAdapter To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:909 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The DataAdapter To the Table.") >
   Public  DataAdapter As OleDb.OleDbDataAdapter
#End Region '(Set|Get) The DataAdapter To the Table.

#Region"[On] |2019/07/06 00h51:877| <15.00.10> <Runtime> <> |.Connector()|LineInfo"' (Set|Get) The Connector To the Table.
    '''    <Summary>
'''     (Set|Get) The Connector To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:909 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The Connector To the Table.") >
   Public  Connector As LineInfo
#End Region '(Set|Get) The Connector To the Table.

#Region"[On] |2019/07/06 00h51:892| <15.00.11> <Runtime> <> |.Log()|String"' (Set|Get) The Log To the Table.
    '''    <Summary>
'''     (Set|Get) The Log To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:909 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The Log To the Table.") >
   Public  Log As String
#End Region '(Set|Get) The Log To the Table.

#End Region 
#Region "<7> [Loader]{2}"
#Region"[On] |2019/07/06 00h51:907| <06.00.00> <Loader> <> |.Empty()|Function}|"' (Set|Get) The sub Empty.
    '''    <Summary>
'''     (Set|Get) The sub Empty.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:910 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The sub Empty.") >
   Public Sub New ()
Reset
   End Sub
#End Region '(Set|Get) The sub Empty.

#Region"[On] |2019/07/06 00h51:911| <06.00.01> <Loader> <> |.Filled()|Function}|"' (Set|Get) The sub Filled.
    '''    <Summary>
'''     (Set|Get) The sub Filled.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:910 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>    ''' <param name="ID">(Set|Get) The ID as Integer.</param>
    ''' <param name="Name">(Set|Get) The Name as String.</param>
    ''' <param name="ImageIndex">(Set|Get) The ImageIndex as Integer.</param>
    ''' <param name="Text">(Set|Get) The Text as String.</param>
    ''' <param name="ToolTip">(Set|Get) The ToolTip as String.</param>
    ''' <param name="Enable">(Set|Get) The Enable as Boolean.</param>
    ''' <param name="Status">(Set|Get) The Status as String.</param>
    ''' <param name="Statement">(Set|Get) The Statement as String.</param>
    ''' <param name="XMLFile">(Set|Get) The XMLFile as String.</param>
    ''' <param name="Attributes">(Set|Get) The Attributes as String.</param>
    ''' <param name="Browsable">(Set|Get) The Browsable as Boolean.</param>
    ''' <param name="Category">(Set|Get) The Category as String.</param>
    ''' <param name="Description">(Set|Get) The Description as String.</param>
    ''' <param name="DefaultValue">(Set|Get) The DefaultValue as String.</param>
    ''' <param name="Editor">(Set|Get) The Editor as String.</param>
    ''' <param name="DllImport">(Set|Get) The DllImport as String.</param>
    ''' <param name="Deserializable">(Set|Get) The Deserializable as Boolean.</param>
    ''' <param name="NonSerialized">(Set|Get) The NonSerialized as Boolean.</param>
    ''' <param name="Serializable">(Set|Get) The Serializable as Boolean.</param>
    ''' <param name="XmlRoot">(Set|Get) The XmlRoot as String.</param>
    ''' <param name="XmlIgnore">(Set|Get) The XmlIgnore as Boolean.</param>
    ''' <param name="XmlInclude">(Set|Get) The XmlInclude as Boolean.</param>
    ''' <param name="RelatedImageList">(Set|Get) The RelatedImageList as String.</param>
    ''' <param name="Print_VB">(Set|Get) The Print_VB as String.</param>
    ''' <param name="VB">(Set|Get) The VB as String.</param>
    ''' <param name="Print_C">(Set|Get) The Print_C as String.</param>
    ''' <param name="C">(Set|Get) The C as String.</param>
    ''' <param name="Print_F">(Set|Get) The Print_F as String.</param>
    ''' <param name="F">(Set|Get) The F as String.</param>
    ''' <param name="Print_Python">(Set|Get) The Print_Python as String.</param>
    ''' <param name="Python">(Set|Get) The Python as String.</param>
    ''' <param name="Print_JavaScript">(Set|Get) The Print_JavaScript as String.</param>
    ''' <param name="JavaScript">(Set|Get) The JavaScript as String.</param>
    ''' <param name="RegionCategory">(Set|Get) The RegionCategory as Integer.</param>
    ''' <param name="RegionCode">(Set|Get) The RegionCode as String.</param>
    ''' <param name="AuthorEmail">(Set|Get) The AuthorEmail as String.</param>
    ''' <param name="AuthorName">(Set|Get) The AuthorName as String.</param>
    ''' <param name="AuthorUri">(Set|Get) The AuthorUri as String.</param>
    ''' <param name="ContributorEmail">(Set|Get) The ContributorEmail as String.</param>
    ''' <param name="ContributorName">(Set|Get) The ContributorName as String.</param>
    ''' <param name="ContributorUri">(Set|Get) The ContributorUri as String.</param>
    ''' <param name="CustomProperty">(Set|Get) The CustomProperty as String.</param>
    ''' <param name="Published">(Set|Get) The Published as String.</param>
    ''' <param name="Rights">(Set|Get) The Rights as String.</param>
    ''' <param name="Summary">(Set|Get) The Summary as String.</param>
    ''' <param name="Title">(Set|Get) The Title as String.</param>
    ''' <param name="Updated">(Set|Get) The Updated as String.</param>
    ''' <param name="Usage">(Set|Get) The Usage as String.</param>
    ''' <param name="Remarks">(Set|Get) The Remarks as String.</param>
    ''' <param name="Example">(Set|Get) The Example as String.</param>
    ''' <param name="Note">(Set|Get) The Note as String.</param>
    ''' <param name="CreationDate">(Set|Get) The CreationDate as String.</param>
    ''' <param name="See">(Set|Get) The See as String.</param>
    ''' <param name="SeeAlso">(Set|Get) The SeeAlso as String.</param>
    ''' <param name="Rules">(Set|Get) The Rules as String.</param>
    ''' <param name="Syntax">(Set|Get) The Syntax as String.</param>
    ''' <param name="AccessModifier">(Set|Get) The AccessModifier as String.</param>
    ''' <param name="ProcedureModifier">(Set|Get) The ProcedureModifier as String.</param>
    ''' <param name="Partial">(Set|Get) The Partial as Boolean.</param>
    ''' <param name="Shared">(Set|Get) The Shared as Boolean.</param>
    ''' <param name="Shadows">(Set|Get) The Shadows as Boolean.</param>
    ''' <param name="Async">(Set|Get) The Async as Boolean.</param>
    ''' <param name="FunctionName">(Set|Get) The FunctionName as String.</param>
    ''' <param name="Handles">(Set|Get) The Handles as String.</param>
    ''' <param name="Implements">(Set|Get) The Implements as String.</param>
    ''' <param name="ReturnType">(Set|Get) The ReturnType as String.</param>

    <Browsable(True) , Description("(Set|Get) The sub Filled.") >
   Public Sub New (ByVal ID As Integer, 
ByVal Name As String, 
ByVal ImageIndex As Integer, 
ByVal Text As String, 
ByVal ToolTip As String, 
ByVal Enable As Boolean, 
ByVal Status As String, 
ByVal Statement As String, 
ByVal XMLFile As String, 
ByVal Attributes As String, 
ByVal Browsable As Boolean, 
ByVal Category As String, 
ByVal Description As String, 
ByVal DefaultValue As String, 
ByVal Editor As String, 
ByVal DllImport As String, 
ByVal Deserializable As Boolean, 
ByVal NonSerialized As Boolean, 
ByVal Serializable As Boolean, 
ByVal XmlRoot As String, 
ByVal XmlIgnore As Boolean, 
ByVal XmlInclude As Boolean, 
ByVal RelatedImageList As String, 
ByVal Print_VB As String, 
ByVal VB As String, 
ByVal Print_C As String, 
ByVal C As String, 
ByVal Print_F As String, 
ByVal F As String, 
ByVal Print_Python As String, 
ByVal Python As String, 
ByVal Print_JavaScript As String, 
ByVal JavaScript As String, 
ByVal RegionCategory As Integer, 
ByVal RegionCode As String, 
ByVal AuthorEmail As String, 
ByVal AuthorName As String, 
ByVal AuthorUri As String, 
ByVal ContributorEmail As String, 
ByVal ContributorName As String, 
ByVal ContributorUri As String, 
ByVal CustomProperty As String, 
ByVal Published As String, 
ByVal Rights As String, 
ByVal Summary As String, 
ByVal Title As String, 
ByVal Updated As String, 
ByVal Usage As String, 
ByVal Remarks As String, 
ByVal Example As String, 
ByVal Note As String, 
ByVal CreationDate As String, 
ByVal See As String, 
ByVal SeeAlso As String, 
ByVal Rules As String, 
ByVal Syntax As String, 
ByVal AccessModifier As String, 
ByVal ProcedureModifier As String, 
ByVal Partial As Boolean, 
ByVal Shared As Boolean, 
ByVal Shadows As Boolean, 
ByVal Async As Boolean, 
ByVal FunctionName As String, 
ByVal Handles As String, 
ByVal Implements As String, 
ByVal ReturnType As String)
 With Me
 Clear()
 Reset()
     .ID = ID
     .Name = Name
     .ImageIndex = ImageIndex
     .Text = Text
     .ToolTip = ToolTip
     .Enable = Enable
     .Status = Status
     .Statement = Statement
     .XMLFile = XMLFile
     .Attributes = Attributes
     .Browsable = Browsable
     .Category = Category
     .Description = Description
     .DefaultValue = DefaultValue
     .Editor = Editor
     .DllImport = DllImport
     .Deserializable = Deserializable
     .NonSerialized = NonSerialized
     .Serializable = Serializable
     .XmlRoot = XmlRoot
     .XmlIgnore = XmlIgnore
     .XmlInclude = XmlInclude
     .RelatedImageList = RelatedImageList
     .Print_VB = Print_VB
     .VB = VB
     .Print_C = Print_C
     .C = C
     .Print_F = Print_F
     .F = F
     .Print_Python = Print_Python
     .Python = Python
     .Print_JavaScript = Print_JavaScript
     .JavaScript = JavaScript
     .RegionCategory = RegionCategory
     .RegionCode = RegionCode
     .AuthorEmail = AuthorEmail
     .AuthorName = AuthorName
     .AuthorUri = AuthorUri
     .ContributorEmail = ContributorEmail
     .ContributorName = ContributorName
     .ContributorUri = ContributorUri
     .CustomProperty = CustomProperty
     .Published = Published
     .Rights = Rights
     .Summary = Summary
     .Title = Title
     .Updated = Updated
     .Usage = Usage
     .Remarks = Remarks
     .Example = Example
     .Note = Note
     .CreationDate = CreationDate
     .See = See
     .SeeAlso = SeeAlso
     .Rules = Rules
     .Syntax = Syntax
     .AccessModifier = AccessModifier
     .ProcedureModifier = ProcedureModifier
     .Partial = Partial
     .Shared = Shared
     .Shadows = Shadows
     .Async = Async
     .FunctionName = FunctionName
     .Handles = Handles
     .Implements = Implements
     .ReturnType = ReturnType
 End With

   End Sub
#End Region '(Set|Get) The sub Filled.

#End Region 
 End Class
#End Region

#Region"[On] |2019/07/06 00h51:067| <08.00.00> <Class> <> |.Property|Class|{98} |Production Cost : 154.3|Selling Price : 385.75|"' Class created automatically by SmartOffice (c)Copyright 2019.
'''    <Summary>
'''     Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Property
'''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
'''    Contributor Information : ||
'''    Creation Date :           2019/07/06 00h51:067
'''    |Schema|
'''    |ID| |ObjectType |{Quantity}||UnitPrice||Total
'''    |00| |Importation|{0}||1| |0
'''    |01| |Properties |{71}||0.8| |56.8
'''    |02| |Enumeration|{1}||0.4| |0.4
'''    |03| |Structure  |{0}||0.4| |0
'''    |04| |Sub        |{5}||1.2| |6
'''    |05| |Function   |{7}||1.6| |11.2
'''    |06| |Runtime    |{12}||0.4| |4.8
'''    |07| |Loader     |{2}||0.8| |1.6
'''    |08| |Class      |{0}||2| |0
'''    |09| |Constante  |{0}||0.4| |0
'''    |10| |Event      |{0}||1.2| |0
'''    |11| |Members    |{71}||0.5| |35.5
'''    |12| |Parameter  |{76}||0.5| |38
'''    |Production Cost             |154.3
'''    |Selling Price without VAT   |385.75
'''    |Total TVA                   |29.7
'''    |Grand Total                 |415.45
'''    |/Schema|
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:956 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
Public  Class Property
#Region "<1> [Property]{71}"
#Region"[On] |2019/07/06 00h51:068| <01.00.00> <Property> <Columns> |.ID()|Integer|"' (Set|Get) The ID as Integer.
   Private _ID As Integer
    '''    <Summary>
'''     (Set|Get) The ID as Integer.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:956 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ID as Integer.") >
   Public Property ID()As Integer
       Get
       Return _ID
       End Get
       Set(ByVal Value As Integer)
       _ID = Value
       End Set
   End Property
#End Region '(Set|Get) The ID as Integer.

#Region"[On] |2019/07/06 00h51:077| <01.00.01> <Property> <Columns> |.Name()|String|"' (Set|Get) The Name as String.
   Private _Name As String
    '''    <Summary>
'''     (Set|Get) The Name as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:956 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Name as String.") >
   Public Property Name()As String
       Get
       Return _Name
       End Get
       Set(ByVal Value As String)
       _Name = Value
       End Set
   End Property
#End Region '(Set|Get) The Name as String.

#Region"[On] |2019/07/06 00h51:092| <01.00.02> <Property> <Columns> |.ImageIndex()|Integer|"' (Set|Get) The ImageIndex as Integer.
   Private _ImageIndex As Integer
    '''    <Summary>
'''     (Set|Get) The ImageIndex as Integer.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:956 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ImageIndex as Integer.") >
   Public Property ImageIndex()As Integer
       Get
       Return _ImageIndex
       End Get
       Set(ByVal Value As Integer)
       _ImageIndex = Value
       End Set
   End Property
#End Region '(Set|Get) The ImageIndex as Integer.

#Region"[On] |2019/07/06 00h51:105| <01.00.03> <Property> <Columns> |.Text()|String|"' (Set|Get) The Text as String.
   Private _Text As String
    '''    <Summary>
'''     (Set|Get) The Text as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:957 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Text as String.") >
   Public Property Text()As String
       Get
       Return _Text
       End Get
       Set(ByVal Value As String)
       _Text = Value
       End Set
   End Property
#End Region '(Set|Get) The Text as String.

#Region"[On] |2019/07/06 00h51:120| <01.00.04> <Property> <Columns> |.ToolTip()|String|"' (Set|Get) The ToolTip as String.
   Private _ToolTip As String
    '''    <Summary>
'''     (Set|Get) The ToolTip as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:957 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ToolTip as String.") >
   Public Property ToolTip()As String
       Get
       Return _ToolTip
       End Get
       Set(ByVal Value As String)
       _ToolTip = Value
       End Set
   End Property
#End Region '(Set|Get) The ToolTip as String.

#Region"[On] |2019/07/06 00h51:131| <01.00.05> <Property> <Columns> |.Enable()|Boolean|"' (Set|Get) The Enable as Boolean.
   Private _Enable As Boolean
    '''    <Summary>
'''     (Set|Get) The Enable as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:960 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Enable as Boolean.") >
   Public Property Enable()As Boolean
       Get
       Return _Enable
       End Get
       Set(ByVal Value As Boolean)
       _Enable = Value
       End Set
   End Property
#End Region '(Set|Get) The Enable as Boolean.

#Region"[On] |2019/07/06 00h51:143| <01.00.06> <Property> <Columns> |.Status()|String|"' (Set|Get) The Status as String.
   Private _Status As String
    '''    <Summary>
'''     (Set|Get) The Status as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:960 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Status as String.") >
   Public Property Status()As String
       Get
       Return _Status
       End Get
       Set(ByVal Value As String)
       _Status = Value
       End Set
   End Property
#End Region '(Set|Get) The Status as String.

#Region"[On] |2019/07/06 00h51:150| <01.00.07> <Property> <Columns> |.Statement()|String|"' (Set|Get) The Statement as String.
   Private _Statement As String
    '''    <Summary>
'''     (Set|Get) The Statement as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:960 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Statement as String.") >
   Public Property Statement()As String
       Get
       Return _Statement
       End Get
       Set(ByVal Value As String)
       _Statement = Value
       End Set
   End Property
#End Region '(Set|Get) The Statement as String.

#Region"[On] |2019/07/06 00h51:161| <01.00.08> <Property> <Columns> |.XMLFile()|String|"' (Set|Get) The XMLFile as String.
   Private _XMLFile As String
    '''    <Summary>
'''     (Set|Get) The XMLFile as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:960 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XMLFile as String.") >
   Public Property XMLFile()As String
       Get
       Return _XMLFile
       End Get
       Set(ByVal Value As String)
       _XMLFile = Value
       End Set
   End Property
#End Region '(Set|Get) The XMLFile as String.

#Region"[On] |2019/07/06 00h51:173| <01.00.09> <Property> <Columns> |.Attributes()|String|"' (Set|Get) The Attributes as String.
   Private _Attributes As String
    '''    <Summary>
'''     (Set|Get) The Attributes as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:961 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Attributes as String.") >
   Public Property Attributes()As String
       Get
       Return _Attributes
       End Get
       Set(ByVal Value As String)
       _Attributes = Value
       End Set
   End Property
#End Region '(Set|Get) The Attributes as String.

#Region"[On] |2019/07/06 00h51:184| <01.00.10> <Property> <Columns> |.Browsable()|Boolean|"' (Set|Get) The Browsable as Boolean.
   Private _Browsable As Boolean
    '''    <Summary>
'''     (Set|Get) The Browsable as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:961 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Browsable as Boolean.") >
   Public Property Browsable()As Boolean
       Get
       Return _Browsable
       End Get
       Set(ByVal Value As Boolean)
       _Browsable = Value
       End Set
   End Property
#End Region '(Set|Get) The Browsable as Boolean.

#Region"[On] |2019/07/06 00h51:195| <01.00.11> <Property> <Columns> |.Category()|String|"' (Set|Get) The Category as String.
   Private _Category As String
    '''    <Summary>
'''     (Set|Get) The Category as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:961 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Category as String.") >
   Public Property Category()As String
       Get
       Return _Category
       End Get
       Set(ByVal Value As String)
       _Category = Value
       End Set
   End Property
#End Region '(Set|Get) The Category as String.

#Region"[On] |2019/07/06 00h51:207| <01.00.12> <Property> <Columns> |.Description()|String|"' (Set|Get) The Description as String.
   Private _Description As String
    '''    <Summary>
'''     (Set|Get) The Description as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:961 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Description as String.") >
   Public Property Description()As String
       Get
       Return _Description
       End Get
       Set(ByVal Value As String)
       _Description = Value
       End Set
   End Property
#End Region '(Set|Get) The Description as String.

#Region"[On] |2019/07/06 00h51:218| <01.00.13> <Property> <Columns> |.DefaultValue()|String|"' (Set|Get) The DefaultValue as String.
   Private _DefaultValue As String
    '''    <Summary>
'''     (Set|Get) The DefaultValue as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:964 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The DefaultValue as String.") >
   Public Property DefaultValue()As String
       Get
       Return _DefaultValue
       End Get
       Set(ByVal Value As String)
       _DefaultValue = Value
       End Set
   End Property
#End Region '(Set|Get) The DefaultValue as String.

#Region"[On] |2019/07/06 00h51:231| <01.00.14> <Property> <Columns> |.Editor()|String|"' (Set|Get) The Editor as String.
   Private _Editor As String
    '''    <Summary>
'''     (Set|Get) The Editor as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:964 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Editor as String.") >
   Public Property Editor()As String
       Get
       Return _Editor
       End Get
       Set(ByVal Value As String)
       _Editor = Value
       End Set
   End Property
#End Region '(Set|Get) The Editor as String.

#Region"[On] |2019/07/06 00h51:247| <01.00.15> <Property> <Columns> |.DllImport()|String|"' (Set|Get) The DllImport as String.
   Private _DllImport As String
    '''    <Summary>
'''     (Set|Get) The DllImport as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:964 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The DllImport as String.") >
   Public Property DllImport()As String
       Get
       Return _DllImport
       End Get
       Set(ByVal Value As String)
       _DllImport = Value
       End Set
   End Property
#End Region '(Set|Get) The DllImport as String.

#Region"[On] |2019/07/06 00h51:260| <01.00.16> <Property> <Columns> |.Deserializable()|Boolean|"' (Set|Get) The Deserializable as Boolean.
   Private _Deserializable As Boolean
    '''    <Summary>
'''     (Set|Get) The Deserializable as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:964 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Deserializable as Boolean.") >
   Public Property Deserializable()As Boolean
       Get
       Return _Deserializable
       End Get
       Set(ByVal Value As Boolean)
       _Deserializable = Value
       End Set
   End Property
#End Region '(Set|Get) The Deserializable as Boolean.

#Region"[On] |2019/07/06 00h51:272| <01.00.17> <Property> <Columns> |.NonSerialized()|Boolean|"' (Set|Get) The NonSerialized as Boolean.
   Private _NonSerialized As Boolean
    '''    <Summary>
'''     (Set|Get) The NonSerialized as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:965 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The NonSerialized as Boolean.") >
   Public Property NonSerialized()As Boolean
       Get
       Return _NonSerialized
       End Get
       Set(ByVal Value As Boolean)
       _NonSerialized = Value
       End Set
   End Property
#End Region '(Set|Get) The NonSerialized as Boolean.

#Region"[On] |2019/07/06 00h51:284| <01.00.18> <Property> <Columns> |.Serializable()|Boolean|"' (Set|Get) The Serializable as Boolean.
   Private _Serializable As Boolean
    '''    <Summary>
'''     (Set|Get) The Serializable as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:965 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Serializable as Boolean.") >
   Public Property Serializable()As Boolean
       Get
       Return _Serializable
       End Get
       Set(ByVal Value As Boolean)
       _Serializable = Value
       End Set
   End Property
#End Region '(Set|Get) The Serializable as Boolean.

#Region"[On] |2019/07/06 00h51:296| <01.00.19> <Property> <Columns> |.XmlRoot()|String|"' (Set|Get) The XmlRoot as String.
   Private _XmlRoot As String
    '''    <Summary>
'''     (Set|Get) The XmlRoot as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:965 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XmlRoot as String.") >
   Public Property XmlRoot()As String
       Get
       Return _XmlRoot
       End Get
       Set(ByVal Value As String)
       _XmlRoot = Value
       End Set
   End Property
#End Region '(Set|Get) The XmlRoot as String.

#Region"[On] |2019/07/06 00h51:308| <01.00.20> <Property> <Columns> |.XmlIgnore()|Boolean|"' (Set|Get) The XmlIgnore as Boolean.
   Private _XmlIgnore As Boolean
    '''    <Summary>
'''     (Set|Get) The XmlIgnore as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:965 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XmlIgnore as Boolean.") >
   Public Property XmlIgnore()As Boolean
       Get
       Return _XmlIgnore
       End Get
       Set(ByVal Value As Boolean)
       _XmlIgnore = Value
       End Set
   End Property
#End Region '(Set|Get) The XmlIgnore as Boolean.

#Region"[On] |2019/07/06 00h51:320| <01.00.21> <Property> <Columns> |.XmlInclude()|Boolean|"' (Set|Get) The XmlInclude as Boolean.
   Private _XmlInclude As Boolean
    '''    <Summary>
'''     (Set|Get) The XmlInclude as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:965 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XmlInclude as Boolean.") >
   Public Property XmlInclude()As Boolean
       Get
       Return _XmlInclude
       End Get
       Set(ByVal Value As Boolean)
       _XmlInclude = Value
       End Set
   End Property
#End Region '(Set|Get) The XmlInclude as Boolean.

#Region"[On] |2019/07/06 00h51:331| <01.00.22> <Property> <Columns> |.RelatedImageList()|String|"' (Set|Get) The RelatedImageList as String.
   Private _RelatedImageList As String
    '''    <Summary>
'''     (Set|Get) The RelatedImageList as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:967 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The RelatedImageList as String.") >
   Public Property RelatedImageList()As String
       Get
       Return _RelatedImageList
       End Get
       Set(ByVal Value As String)
       _RelatedImageList = Value
       End Set
   End Property
#End Region '(Set|Get) The RelatedImageList as String.

#Region"[On] |2019/07/06 00h51:343| <01.00.23> <Property> <Columns> |.Print_VB()|String|"' (Set|Get) The Print_VB as String.
   Private _Print_VB As String
    '''    <Summary>
'''     (Set|Get) The Print_VB as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:967 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_VB as String.") >
   Public Property Print_VB()As String
       Get
       Return _Print_VB
       End Get
       Set(ByVal Value As String)
       _Print_VB = Value
       End Set
   End Property
#End Region '(Set|Get) The Print_VB as String.

#Region"[On] |2019/07/06 00h51:355| <01.00.24> <Property> <Columns> |.VB()|String|"' (Set|Get) The VB as String.
   Private _VB As String
    '''    <Summary>
'''     (Set|Get) The VB as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:967 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The VB as String.") >
   Public Property VB()As String
       Get
       Return _VB
       End Get
       Set(ByVal Value As String)
       _VB = Value
       End Set
   End Property
#End Region '(Set|Get) The VB as String.

#Region"[On] |2019/07/06 00h51:366| <01.00.25> <Property> <Columns> |.Print_C()|String|"' (Set|Get) The Print_C as String.
   Private _Print_C As String
    '''    <Summary>
'''     (Set|Get) The Print_C as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:967 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_C as String.") >
   Public Property Print_C()As String
       Get
       Return _Print_C
       End Get
       Set(ByVal Value As String)
       _Print_C = Value
       End Set
   End Property
#End Region '(Set|Get) The Print_C as String.

#Region"[On] |2019/07/06 00h51:379| <01.00.26> <Property> <Columns> |.C()|String|"' (Set|Get) The C as String.
   Private _C As String
    '''    <Summary>
'''     (Set|Get) The C as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:967 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The C as String.") >
   Public Property C()As String
       Get
       Return _C
       End Get
       Set(ByVal Value As String)
       _C = Value
       End Set
   End Property
#End Region '(Set|Get) The C as String.

#Region"[On] |2019/07/06 00h51:390| <01.00.27> <Property> <Columns> |.Print_F()|String|"' (Set|Get) The Print_F as String.
   Private _Print_F As String
    '''    <Summary>
'''     (Set|Get) The Print_F as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:968 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_F as String.") >
   Public Property Print_F()As String
       Get
       Return _Print_F
       End Get
       Set(ByVal Value As String)
       _Print_F = Value
       End Set
   End Property
#End Region '(Set|Get) The Print_F as String.

#Region"[On] |2019/07/06 00h51:401| <01.00.28> <Property> <Columns> |.F()|String|"' (Set|Get) The F as String.
   Private _F As String
    '''    <Summary>
'''     (Set|Get) The F as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:968 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The F as String.") >
   Public Property F()As String
       Get
       Return _F
       End Get
       Set(ByVal Value As String)
       _F = Value
       End Set
   End Property
#End Region '(Set|Get) The F as String.

#Region"[On] |2019/07/06 00h51:413| <01.00.29> <Property> <Columns> |.Print_Python()|String|"' (Set|Get) The Print_Python as String.
   Private _Print_Python As String
    '''    <Summary>
'''     (Set|Get) The Print_Python as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:968 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_Python as String.") >
   Public Property Print_Python()As String
       Get
       Return _Print_Python
       End Get
       Set(ByVal Value As String)
       _Print_Python = Value
       End Set
   End Property
#End Region '(Set|Get) The Print_Python as String.

#Region"[On] |2019/07/06 00h51:425| <01.00.30> <Property> <Columns> |.Python()|String|"' (Set|Get) The Python as String.
   Private _Python As String
    '''    <Summary>
'''     (Set|Get) The Python as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:968 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Python as String.") >
   Public Property Python()As String
       Get
       Return _Python
       End Get
       Set(ByVal Value As String)
       _Python = Value
       End Set
   End Property
#End Region '(Set|Get) The Python as String.

#Region"[On] |2019/07/06 00h51:437| <01.00.31> <Property> <Columns> |.Print_JavaScript()|String|"' (Set|Get) The Print_JavaScript as String.
   Private _Print_JavaScript As String
    '''    <Summary>
'''     (Set|Get) The Print_JavaScript as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:969 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_JavaScript as String.") >
   Public Property Print_JavaScript()As String
       Get
       Return _Print_JavaScript
       End Get
       Set(ByVal Value As String)
       _Print_JavaScript = Value
       End Set
   End Property
#End Region '(Set|Get) The Print_JavaScript as String.

#Region"[On] |2019/07/06 00h51:449| <01.00.32> <Property> <Columns> |.JavaScript()|String|"' (Set|Get) The JavaScript as String.
   Private _JavaScript As String
    '''    <Summary>
'''     (Set|Get) The JavaScript as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:969 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The JavaScript as String.") >
   Public Property JavaScript()As String
       Get
       Return _JavaScript
       End Get
       Set(ByVal Value As String)
       _JavaScript = Value
       End Set
   End Property
#End Region '(Set|Get) The JavaScript as String.

#Region"[On] |2019/07/06 00h51:461| <01.00.33> <Property> <Columns> |.RegionCategory()|Integer|"' (Set|Get) The RegionCategory as Integer.
   Private _RegionCategory As Integer
    '''    <Summary>
'''     (Set|Get) The RegionCategory as Integer.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:969 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The RegionCategory as Integer.") >
   Public Property RegionCategory()As Integer
       Get
       Return _RegionCategory
       End Get
       Set(ByVal Value As Integer)
       _RegionCategory = Value
       End Set
   End Property
#End Region '(Set|Get) The RegionCategory as Integer.

#Region"[On] |2019/07/06 00h51:474| <01.00.34> <Property> <Columns> |.RegionCode()|String|"' (Set|Get) The RegionCode as String.
   Private _RegionCode As String
    '''    <Summary>
'''     (Set|Get) The RegionCode as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:969 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The RegionCode as String.") >
   Public Property RegionCode()As String
       Get
       Return _RegionCode
       End Get
       Set(ByVal Value As String)
       _RegionCode = Value
       End Set
   End Property
#End Region '(Set|Get) The RegionCode as String.

#Region"[On] |2019/07/06 00h51:493| <01.00.35> <Property> <Columns> |.AuthorEmail()|String|"' (Set|Get) The AuthorEmail as String.
   Private _AuthorEmail As String
    '''    <Summary>
'''     (Set|Get) The AuthorEmail as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:969 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AuthorEmail as String.") >
   Public Property AuthorEmail()As String
       Get
       Return _AuthorEmail
       End Get
       Set(ByVal Value As String)
       _AuthorEmail = Value
       End Set
   End Property
#End Region '(Set|Get) The AuthorEmail as String.

#Region"[On] |2019/07/06 00h51:505| <01.00.36> <Property> <Columns> |.AuthorName()|String|"' (Set|Get) The AuthorName as String.
   Private _AuthorName As String
    '''    <Summary>
'''     (Set|Get) The AuthorName as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:970 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AuthorName as String.") >
   Public Property AuthorName()As String
       Get
       Return _AuthorName
       End Get
       Set(ByVal Value As String)
       _AuthorName = Value
       End Set
   End Property
#End Region '(Set|Get) The AuthorName as String.

#Region"[On] |2019/07/06 00h51:517| <01.00.37> <Property> <Columns> |.AuthorUri()|String|"' (Set|Get) The AuthorUri as String.
   Private _AuthorUri As String
    '''    <Summary>
'''     (Set|Get) The AuthorUri as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:970 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AuthorUri as String.") >
   Public Property AuthorUri()As String
       Get
       Return _AuthorUri
       End Get
       Set(ByVal Value As String)
       _AuthorUri = Value
       End Set
   End Property
#End Region '(Set|Get) The AuthorUri as String.

#Region"[On] |2019/07/06 00h51:528| <01.00.38> <Property> <Columns> |.ContributorEmail()|String|"' (Set|Get) The ContributorEmail as String.
   Private _ContributorEmail As String
    '''    <Summary>
'''     (Set|Get) The ContributorEmail as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:970 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ContributorEmail as String.") >
   Public Property ContributorEmail()As String
       Get
       Return _ContributorEmail
       End Get
       Set(ByVal Value As String)
       _ContributorEmail = Value
       End Set
   End Property
#End Region '(Set|Get) The ContributorEmail as String.

#Region"[On] |2019/07/06 00h51:540| <01.00.39> <Property> <Columns> |.ContributorName()|String|"' (Set|Get) The ContributorName as String.
   Private _ContributorName As String
    '''    <Summary>
'''     (Set|Get) The ContributorName as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:970 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ContributorName as String.") >
   Public Property ContributorName()As String
       Get
       Return _ContributorName
       End Get
       Set(ByVal Value As String)
       _ContributorName = Value
       End Set
   End Property
#End Region '(Set|Get) The ContributorName as String.

#Region"[On] |2019/07/06 00h51:552| <01.00.40> <Property> <Columns> |.ContributorUri()|String|"' (Set|Get) The ContributorUri as String.
   Private _ContributorUri As String
    '''    <Summary>
'''     (Set|Get) The ContributorUri as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:970 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ContributorUri as String.") >
   Public Property ContributorUri()As String
       Get
       Return _ContributorUri
       End Get
       Set(ByVal Value As String)
       _ContributorUri = Value
       End Set
   End Property
#End Region '(Set|Get) The ContributorUri as String.

#Region"[On] |2019/07/06 00h51:565| <01.00.41> <Property> <Columns> |.CustomProperty()|String|"' (Set|Get) The CustomProperty as String.
   Private _CustomProperty As String
    '''    <Summary>
'''     (Set|Get) The CustomProperty as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:971 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The CustomProperty as String.") >
   Public Property CustomProperty()As String
       Get
       Return _CustomProperty
       End Get
       Set(ByVal Value As String)
       _CustomProperty = Value
       End Set
   End Property
#End Region '(Set|Get) The CustomProperty as String.

#Region"[On] |2019/07/06 00h51:577| <01.00.42> <Property> <Columns> |.Published()|String|"' (Set|Get) The Published as String.
   Private _Published As String
    '''    <Summary>
'''     (Set|Get) The Published as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:971 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Published as String.") >
   Public Property Published()As String
       Get
       Return _Published
       End Get
       Set(ByVal Value As String)
       _Published = Value
       End Set
   End Property
#End Region '(Set|Get) The Published as String.

#Region"[On] |2019/07/06 00h51:589| <01.00.43> <Property> <Columns> |.Rights()|String|"' (Set|Get) The Rights as String.
   Private _Rights As String
    '''    <Summary>
'''     (Set|Get) The Rights as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:971 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Rights as String.") >
   Public Property Rights()As String
       Get
       Return _Rights
       End Get
       Set(ByVal Value As String)
       _Rights = Value
       End Set
   End Property
#End Region '(Set|Get) The Rights as String.

#Region"[On] |2019/07/06 00h51:601| <01.00.44> <Property> <Columns> |.Summary()|String|"' (Set|Get) The Summary as String.
   Private _Summary As String
    '''    <Summary>
'''     (Set|Get) The Summary as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:971 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Summary as String.") >
   Public Property Summary()As String
       Get
       Return _Summary
       End Get
       Set(ByVal Value As String)
       _Summary = Value
       End Set
   End Property
#End Region '(Set|Get) The Summary as String.

#Region"[On] |2019/07/06 00h51:614| <01.00.45> <Property> <Columns> |.Title()|String|"' (Set|Get) The Title as String.
   Private _Title As String
    '''    <Summary>
'''     (Set|Get) The Title as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:971 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Title as String.") >
   Public Property Title()As String
       Get
       Return _Title
       End Get
       Set(ByVal Value As String)
       _Title = Value
       End Set
   End Property
#End Region '(Set|Get) The Title as String.

#Region"[On] |2019/07/06 00h51:626| <01.00.46> <Property> <Columns> |.Updated()|String|"' (Set|Get) The Updated as String.
   Private _Updated As String
    '''    <Summary>
'''     (Set|Get) The Updated as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:972 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Updated as String.") >
   Public Property Updated()As String
       Get
       Return _Updated
       End Get
       Set(ByVal Value As String)
       _Updated = Value
       End Set
   End Property
#End Region '(Set|Get) The Updated as String.

#Region"[On] |2019/07/06 00h51:638| <01.00.47> <Property> <Columns> |.Usage()|String|"' (Set|Get) The Usage as String.
   Private _Usage As String
    '''    <Summary>
'''     (Set|Get) The Usage as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:972 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Usage as String.") >
   Public Property Usage()As String
       Get
       Return _Usage
       End Get
       Set(ByVal Value As String)
       _Usage = Value
       End Set
   End Property
#End Region '(Set|Get) The Usage as String.

#Region"[On] |2019/07/06 00h51:650| <01.00.48> <Property> <Columns> |.Remarks()|String|"' (Set|Get) The Remarks as String.
   Private _Remarks As String
    '''    <Summary>
'''     (Set|Get) The Remarks as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:972 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Remarks as String.") >
   Public Property Remarks()As String
       Get
       Return _Remarks
       End Get
       Set(ByVal Value As String)
       _Remarks = Value
       End Set
   End Property
#End Region '(Set|Get) The Remarks as String.

#Region"[On] |2019/07/06 00h51:663| <01.00.49> <Property> <Columns> |.Example()|String|"' (Set|Get) The Example as String.
   Private _Example As String
    '''    <Summary>
'''     (Set|Get) The Example as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:973 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Example as String.") >
   Public Property Example()As String
       Get
       Return _Example
       End Get
       Set(ByVal Value As String)
       _Example = Value
       End Set
   End Property
#End Region '(Set|Get) The Example as String.

#Region"[On] |2019/07/06 00h51:677| <01.00.50> <Property> <Columns> |.Note()|String|"' (Set|Get) The Note as String.
   Private _Note As String
    '''    <Summary>
'''     (Set|Get) The Note as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:973 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Note as String.") >
   Public Property Note()As String
       Get
       Return _Note
       End Get
       Set(ByVal Value As String)
       _Note = Value
       End Set
   End Property
#End Region '(Set|Get) The Note as String.

#Region"[On] |2019/07/06 00h51:689| <01.00.51> <Property> <Columns> |.CreationDate()|String|"' (Set|Get) The CreationDate as String.
   Private _CreationDate As String
    '''    <Summary>
'''     (Set|Get) The CreationDate as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:973 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The CreationDate as String.") >
   Public Property CreationDate()As String
       Get
       Return _CreationDate
       End Get
       Set(ByVal Value As String)
       _CreationDate = Value
       End Set
   End Property
#End Region '(Set|Get) The CreationDate as String.

#Region"[On] |2019/07/06 00h51:702| <01.00.52> <Property> <Columns> |.See()|String|"' (Set|Get) The See as String.
   Private _See As String
    '''    <Summary>
'''     (Set|Get) The See as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:973 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The See as String.") >
   Public Property See()As String
       Get
       Return _See
       End Get
       Set(ByVal Value As String)
       _See = Value
       End Set
   End Property
#End Region '(Set|Get) The See as String.

#Region"[On] |2019/07/06 00h51:715| <01.00.53> <Property> <Columns> |.SeeAlso()|String|"' (Set|Get) The SeeAlso as String.
   Private _SeeAlso As String
    '''    <Summary>
'''     (Set|Get) The SeeAlso as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:974 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The SeeAlso as String.") >
   Public Property SeeAlso()As String
       Get
       Return _SeeAlso
       End Get
       Set(ByVal Value As String)
       _SeeAlso = Value
       End Set
   End Property
#End Region '(Set|Get) The SeeAlso as String.

#Region"[On] |2019/07/06 00h51:737| <01.00.54> <Property> <Columns> |.Rules()|String|"' (Set|Get) The Rules as String.
   Private _Rules As String
    '''    <Summary>
'''     (Set|Get) The Rules as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:974 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Rules as String.") >
   Public Property Rules()As String
       Get
       Return _Rules
       End Get
       Set(ByVal Value As String)
       _Rules = Value
       End Set
   End Property
#End Region '(Set|Get) The Rules as String.

#Region"[On] |2019/07/06 00h51:749| <01.00.55> <Property> <Columns> |.Syntax()|String|"' (Set|Get) The Syntax as String.
   Private _Syntax As String
    '''    <Summary>
'''     (Set|Get) The Syntax as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:974 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Syntax as String.") >
   Public Property Syntax()As String
       Get
       Return _Syntax
       End Get
       Set(ByVal Value As String)
       _Syntax = Value
       End Set
   End Property
#End Region '(Set|Get) The Syntax as String.

#Region"[On] |2019/07/06 00h51:763| <01.00.56> <Property> <Columns> |.Default()|Boolean|"' (Set|Get) The Default as Boolean.
   Private _Default As Boolean
    '''    <Summary>
'''     (Set|Get) The Default as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:974 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Default as Boolean.") >
   Public Property Default()As Boolean
       Get
       Return _Default
       End Get
       Set(ByVal Value As Boolean)
       _Default = Value
       End Set
   End Property
#End Region '(Set|Get) The Default as Boolean.

#Region"[On] |2019/07/06 00h51:776| <01.00.57> <Property> <Columns> |.AccessModifier()|String|"' (Set|Get) The AccessModifier as String.
   Private _AccessModifier As String
    '''    <Summary>
'''     (Set|Get) The AccessModifier as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:974 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AccessModifier as String.") >
   Public Property AccessModifier()As String
       Get
       Return _AccessModifier
       End Get
       Set(ByVal Value As String)
       _AccessModifier = Value
       End Set
   End Property
#End Region '(Set|Get) The AccessModifier as String.

#Region"[On] |2019/07/06 00h51:788| <01.00.58> <Property> <Columns> |.Shared()|Boolean|"' (Set|Get) The Shared as Boolean.
   Private _Shared As Boolean
    '''    <Summary>
'''     (Set|Get) The Shared as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:975 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Shared as Boolean.") >
   Public Property Shared()As Boolean
       Get
       Return _Shared
       End Get
       Set(ByVal Value As Boolean)
       _Shared = Value
       End Set
   End Property
#End Region '(Set|Get) The Shared as Boolean.

#Region"[On] |2019/07/06 00h51:800| <01.00.59> <Property> <Columns> |.Shadows()|Boolean|"' (Set|Get) The Shadows as Boolean.
   Private _Shadows As Boolean
    '''    <Summary>
'''     (Set|Get) The Shadows as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:975 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Shadows as Boolean.") >
   Public Property Shadows()As Boolean
       Get
       Return _Shadows
       End Get
       Set(ByVal Value As Boolean)
       _Shadows = Value
       End Set
   End Property
#End Region '(Set|Get) The Shadows as Boolean.

#Region"[On] |2019/07/06 00h51:813| <01.00.60> <Property> <Columns> |.ReadOnly()|Boolean|"' (Set|Get) The ReadOnly as Boolean.
   Private _ReadOnly As Boolean
    '''    <Summary>
'''     (Set|Get) The ReadOnly as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:975 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ReadOnly as Boolean.") >
   Public Property ReadOnly()As Boolean
       Get
       Return _ReadOnly
       End Get
       Set(ByVal Value As Boolean)
       _ReadOnly = Value
       End Set
   End Property
#End Region '(Set|Get) The ReadOnly as Boolean.

#Region"[On] |2019/07/06 00h51:826| <01.00.61> <Property> <Columns> |.WriteOnly()|Boolean|"' (Set|Get) The WriteOnly as Boolean.
   Private _WriteOnly As Boolean
    '''    <Summary>
'''     (Set|Get) The WriteOnly as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:976 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The WriteOnly as Boolean.") >
   Public Property WriteOnly()As Boolean
       Get
       Return _WriteOnly
       End Get
       Set(ByVal Value As Boolean)
       _WriteOnly = Value
       End Set
   End Property
#End Region '(Set|Get) The WriteOnly as Boolean.

#Region"[On] |2019/07/06 00h51:839| <01.00.62> <Property> <Columns> |.PropertyModifier()|String|"' (Set|Get) The PropertyModifier as String.
   Private _PropertyModifier As String
    '''    <Summary>
'''     (Set|Get) The PropertyModifier as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:978 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The PropertyModifier as String.") >
   Public Property PropertyModifier()As String
       Get
       Return _PropertyModifier
       End Get
       Set(ByVal Value As String)
       _PropertyModifier = Value
       End Set
   End Property
#End Region '(Set|Get) The PropertyModifier as String.

#Region"[On] |2019/07/06 00h51:852| <01.00.63> <Property> <Columns> |.ReturnType()|String|"' (Set|Get) The ReturnType as String.
   Private _ReturnType As String
    '''    <Summary>
'''     (Set|Get) The ReturnType as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:978 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ReturnType as String.") >
   Public Property ReturnType()As String
       Get
       Return _ReturnType
       End Get
       Set(ByVal Value As String)
       _ReturnType = Value
       End Set
   End Property
#End Region '(Set|Get) The ReturnType as String.

#Region"[On] |2019/07/06 00h51:866| <01.00.64> <Property> <Columns> |.Required()|Boolean|"' (Set|Get) The Required as Boolean.
   Private _Required As Boolean
    '''    <Summary>
'''     (Set|Get) The Required as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:978 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Required as Boolean.") >
   Public Property Required()As Boolean
       Get
       Return _Required
       End Get
       Set(ByVal Value As Boolean)
       _Required = Value
       End Set
   End Property
#End Region '(Set|Get) The Required as Boolean.

#Region"[On] |2019/07/06 00h51:880| <01.00.65> <Property> <Columns> |.Variable_Name()|String|"' (Set|Get) The Variable_Name as String.
   Private _Variable_Name As String
    '''    <Summary>
'''     (Set|Get) The Variable_Name as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:979 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Variable_Name as String.") >
   Public Property Variable_Name()As String
       Get
       Return _Variable_Name
       End Get
       Set(ByVal Value As String)
       _Variable_Name = Value
       End Set
   End Property
#End Region '(Set|Get) The Variable_Name as String.

#Region"[On] |2019/07/06 00h51:893| <01.00.66> <Property> <Columns> |.Variable_AccessModifier()|String|"' (Set|Get) The Variable_AccessModifier as String.
   Private _Variable_AccessModifier As String
    '''    <Summary>
'''     (Set|Get) The Variable_AccessModifier as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:979 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Variable_AccessModifier as String.") >
   Public Property Variable_AccessModifier()As String
       Get
       Return _Variable_AccessModifier
       End Get
       Set(ByVal Value As String)
       _Variable_AccessModifier = Value
       End Set
   End Property
#End Region '(Set|Get) The Variable_AccessModifier as String.

#Region"[On] |2019/07/06 00h51:906| <01.00.67> <Property> <Columns> |.Variable_ReturnType()|String|"' (Set|Get) The Variable_ReturnType as String.
   Private _Variable_ReturnType As String
    '''    <Summary>
'''     (Set|Get) The Variable_ReturnType as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:979 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Variable_ReturnType as String.") >
   Public Property Variable_ReturnType()As String
       Get
       Return _Variable_ReturnType
       End Get
       Set(ByVal Value As String)
       _Variable_ReturnType = Value
       End Set
   End Property
#End Region '(Set|Get) The Variable_ReturnType as String.

#Region"[On] |2019/07/06 00h51:922| <01.00.68> <Property> <Columns> |.SetStatement()|String|"' (Set|Get) The SetStatement as String.
   Private _SetStatement As String
    '''    <Summary>
'''     (Set|Get) The SetStatement as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:979 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The SetStatement as String.") >
   Public Property SetStatement()As String
       Get
       Return _SetStatement
       End Get
       Set(ByVal Value As String)
       _SetStatement = Value
       End Set
   End Property
#End Region '(Set|Get) The SetStatement as String.

#Region"[On] |2019/07/06 00h51:935| <01.00.69> <Property> <Columns> |.GetStatement()|String|"' (Set|Get) The GetStatement as String.
   Private _GetStatement As String
    '''    <Summary>
'''     (Set|Get) The GetStatement as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:980 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The GetStatement as String.") >
   Public Property GetStatement()As String
       Get
       Return _GetStatement
       End Get
       Set(ByVal Value As String)
       _GetStatement = Value
       End Set
   End Property
#End Region '(Set|Get) The GetStatement as String.

#Region"[On] |2019/07/06 00h51:948| <01.00.70> <Property> <Columns> |.ParentName()|String|"' (Set|Get) The ParentName as String.
   Private _ParentName As String
    '''    <Summary>
'''     (Set|Get) The ParentName as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:980 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ParentName as String.") >
   Public Property ParentName()As String
       Get
       Return _ParentName
       End Get
       Set(ByVal Value As String)
       _ParentName = Value
       End Set
   End Property
#End Region '(Set|Get) The ParentName as String.

#End Region 
#Region"<2> [Enumeration]{1}"
#Region"[On] |2019/07/06 00h51:973| <02.00.00> <Enumeration> <> |.Schema()|Enumeration{70}|"' (Set|Get) The enumeration of Schema.
    '''    <Summary>
'''     (Set|Get) The enumeration of Schema.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:980 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The enumeration of Schema.") >
   Enum Schema
''' <summary>(Set|Get) The ID as Integer.</summary>
   [ID] = 0
''' <summary>(Set|Get) The Name as String.</summary>
   [Name] = 1
''' <summary>(Set|Get) The ImageIndex as Integer.</summary>
   [ImageIndex] = 2
''' <summary>(Set|Get) The Text as String.</summary>
   [Text] = 3
''' <summary>(Set|Get) The ToolTip as String.</summary>
   [ToolTip] = 4
''' <summary>(Set|Get) The Enable as Boolean.</summary>
   [Enable] = 5
''' <summary>(Set|Get) The Status as String.</summary>
   [Status] = 6
''' <summary>(Set|Get) The Statement as String.</summary>
   [Statement] = 7
''' <summary>(Set|Get) The XMLFile as String.</summary>
   [XMLFile] = 8
''' <summary>(Set|Get) The Attributes as String.</summary>
   [Attributes] = 9
''' <summary>(Set|Get) The Browsable as Boolean.</summary>
   [Browsable] = 10
''' <summary>(Set|Get) The Category as String.</summary>
   [Category] = 11
''' <summary>(Set|Get) The Description as String.</summary>
   [Description] = 12
''' <summary>(Set|Get) The DefaultValue as String.</summary>
   [DefaultValue] = 13
''' <summary>(Set|Get) The Editor as String.</summary>
   [Editor] = 14
''' <summary>(Set|Get) The DllImport as String.</summary>
   [DllImport] = 15
''' <summary>(Set|Get) The Deserializable as Boolean.</summary>
   [Deserializable] = 16
''' <summary>(Set|Get) The NonSerialized as Boolean.</summary>
   [NonSerialized] = 17
''' <summary>(Set|Get) The Serializable as Boolean.</summary>
   [Serializable] = 18
''' <summary>(Set|Get) The XmlRoot as String.</summary>
   [XmlRoot] = 19
''' <summary>(Set|Get) The XmlIgnore as Boolean.</summary>
   [XmlIgnore] = 20
''' <summary>(Set|Get) The XmlInclude as Boolean.</summary>
   [XmlInclude] = 21
''' <summary>(Set|Get) The RelatedImageList as String.</summary>
   [RelatedImageList] = 22
''' <summary>(Set|Get) The Print_VB as String.</summary>
   [Print_VB] = 23
''' <summary>(Set|Get) The VB as String.</summary>
   [VB] = 24
''' <summary>(Set|Get) The Print_C as String.</summary>
   [Print_C] = 25
''' <summary>(Set|Get) The C as String.</summary>
   [C] = 26
''' <summary>(Set|Get) The Print_F as String.</summary>
   [Print_F] = 27
''' <summary>(Set|Get) The F as String.</summary>
   [F] = 28
''' <summary>(Set|Get) The Print_Python as String.</summary>
   [Print_Python] = 29
''' <summary>(Set|Get) The Python as String.</summary>
   [Python] = 30
''' <summary>(Set|Get) The Print_JavaScript as String.</summary>
   [Print_JavaScript] = 31
''' <summary>(Set|Get) The JavaScript as String.</summary>
   [JavaScript] = 32
''' <summary>(Set|Get) The RegionCategory as Integer.</summary>
   [RegionCategory] = 33
''' <summary>(Set|Get) The RegionCode as String.</summary>
   [RegionCode] = 34
''' <summary>(Set|Get) The AuthorEmail as String.</summary>
   [AuthorEmail] = 35
''' <summary>(Set|Get) The AuthorName as String.</summary>
   [AuthorName] = 36
''' <summary>(Set|Get) The AuthorUri as String.</summary>
   [AuthorUri] = 37
''' <summary>(Set|Get) The ContributorEmail as String.</summary>
   [ContributorEmail] = 38
''' <summary>(Set|Get) The ContributorName as String.</summary>
   [ContributorName] = 39
''' <summary>(Set|Get) The ContributorUri as String.</summary>
   [ContributorUri] = 40
''' <summary>(Set|Get) The CustomProperty as String.</summary>
   [CustomProperty] = 41
''' <summary>(Set|Get) The Published as String.</summary>
   [Published] = 42
''' <summary>(Set|Get) The Rights as String.</summary>
   [Rights] = 43
''' <summary>(Set|Get) The Summary as String.</summary>
   [Summary] = 44
''' <summary>(Set|Get) The Title as String.</summary>
   [Title] = 45
''' <summary>(Set|Get) The Updated as String.</summary>
   [Updated] = 46
''' <summary>(Set|Get) The Usage as String.</summary>
   [Usage] = 47
''' <summary>(Set|Get) The Remarks as String.</summary>
   [Remarks] = 48
''' <summary>(Set|Get) The Example as String.</summary>
   [Example] = 49
''' <summary>(Set|Get) The Note as String.</summary>
   [Note] = 50
''' <summary>(Set|Get) The CreationDate as String.</summary>
   [CreationDate] = 51
''' <summary>(Set|Get) The See as String.</summary>
   [See] = 52
''' <summary>(Set|Get) The SeeAlso as String.</summary>
   [SeeAlso] = 53
''' <summary>(Set|Get) The Rules as String.</summary>
   [Rules] = 54
''' <summary>(Set|Get) The Syntax as String.</summary>
   [Syntax] = 55
''' <summary>(Set|Get) The Default as Boolean.</summary>
   [Default] = 56
''' <summary>(Set|Get) The AccessModifier as String.</summary>
   [AccessModifier] = 57
''' <summary>(Set|Get) The Shared as Boolean.</summary>
   [Shared] = 58
''' <summary>(Set|Get) The Shadows as Boolean.</summary>
   [Shadows] = 59
''' <summary>(Set|Get) The ReadOnly as Boolean.</summary>
   [ReadOnly] = 60
''' <summary>(Set|Get) The WriteOnly as Boolean.</summary>
   [WriteOnly] = 61
''' <summary>(Set|Get) The PropertyModifier as String.</summary>
   [PropertyModifier] = 62
''' <summary>(Set|Get) The ReturnType as String.</summary>
   [ReturnType] = 63
''' <summary>(Set|Get) The Required as Boolean.</summary>
   [Required] = 64
''' <summary>(Set|Get) The Variable_Name as String.</summary>
   [Variable_Name] = 65
''' <summary>(Set|Get) The Variable_AccessModifier as String.</summary>
   [Variable_AccessModifier] = 66
''' <summary>(Set|Get) The Variable_ReturnType as String.</summary>
   [Variable_ReturnType] = 67
''' <summary>(Set|Get) The SetStatement as String.</summary>
   [SetStatement] = 68
''' <summary>(Set|Get) The GetStatement as String.</summary>
   [GetStatement] = 69
''' <summary>(Set|Get) The ParentName as String.</summary>
   [ParentName] = 70
   End Enum
#End Region '(Set|Get) The enumeration of Schema.

#End Region 
#Region "<4> [Sub]{5}"
#Region"[On] |2019/07/06 00h51:995| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
    '''    <Summary>
'''     (Set|Get) This will reinitialize the class element.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:982 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) This will reinitialize the class element.") >
   Public Sub Clear()
  With Me
        .ID = 0
        .Name = Nothing
        .ImageIndex = 0
        .Text = Nothing
        .ToolTip = Nothing
        .Enable = False
        .Status = Nothing
        .Statement = Nothing
        .XMLFile = Nothing
        .Attributes = Nothing
        .Browsable = False
        .Category = Nothing
        .Description = Nothing
        .DefaultValue = Nothing
        .Editor = Nothing
        .DllImport = Nothing
        .Deserializable = False
        .NonSerialized = False
        .Serializable = False
        .XmlRoot = Nothing
        .XmlIgnore = False
        .XmlInclude = False
        .RelatedImageList = Nothing
        .Print_VB = Nothing
        .VB = Nothing
        .Print_C = Nothing
        .C = Nothing
        .Print_F = Nothing
        .F = Nothing
        .Print_Python = Nothing
        .Python = Nothing
        .Print_JavaScript = Nothing
        .JavaScript = Nothing
        .RegionCategory = 0
        .RegionCode = Nothing
        .AuthorEmail = Nothing
        .AuthorName = Nothing
        .AuthorUri = Nothing
        .ContributorEmail = Nothing
        .ContributorName = Nothing
        .ContributorUri = Nothing
        .CustomProperty = Nothing
        .Published = Nothing
        .Rights = Nothing
        .Summary = Nothing
        .Title = Nothing
        .Updated = Nothing
        .Usage = Nothing
        .Remarks = Nothing
        .Example = Nothing
        .Note = Nothing
        .CreationDate = Nothing
        .See = Nothing
        .SeeAlso = Nothing
        .Rules = Nothing
        .Syntax = Nothing
        .Default = False
        .AccessModifier = Nothing
        .Shared = False
        .Shadows = False
        .ReadOnly = False
        .WriteOnly = False
        .PropertyModifier = Nothing
        .ReturnType = Nothing
        .Required = False
        .Variable_Name = Nothing
        .Variable_AccessModifier = Nothing
        .Variable_ReturnType = Nothing
        .SetStatement = Nothing
        .GetStatement = Nothing
        .ParentName = Nothing
 End With
   End Sub
#End Region '(Set|Get) This will reinitialize the class element.

#Region"[On] |2019/07/06 00h51:010| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
    '''    <Summary>
'''     (Set|Get) This will reinitialize the variables of this class.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:983 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) This will reinitialize the variables of this class.") >
   Public Sub Reset(Optional ByVal Connector As LineInfo = Nothing)
If Not IsNothing(Connector) Then
   Me.Connector=Connector
   Me.FilePath=""
   Me.Password=""
   Me.Line=""
   If Connector.Status<>Status.Broken Then 
        FilePath = Connector.FilePath
        Password = Connector.Password
        Me.Connector=Connector
        TableName = "Property"
        Line = Connector.Line
        UseSQL = False
   Else
        FilePath = My.Settings.Db_ProjectDatabase_FilePath
        Password = My.Settings.Db_ProjectDatabase_Password
        Me.Line = My.Settings.Db_ProjectDatabase_Line
        TableName = "Property"
        UseSQL = False
   End If
Else
        If IsNothing(FilePath) Then 
             FilePath = My.Settings.Db_ProjectDatabase_FilePath
        End If 
        If FilePath.Length<1 Then 
             FilePath = My.Settings.Db_ProjectDatabase_FilePath
        End If 
        FilePath = My.Settings.Db_ProjectDatabase_FilePath
        Password = My.Settings.Db_ProjectDatabase_Password
        Me.Line = My.Settings.Db_ProjectDatabase_Line
        TableName = "Property"
        UseSQL = False
End If

   End Sub
#End Region '(Set|Get) This will reinitialize the variables of this class.

#Region"[On] |2019/07/06 00h51:032| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
    '''    <Summary>
'''     (Set|Get) This will add a new row in the table.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:983 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) This will add a new row in the table.") >
   Public Sub Add()
 Try
   Dim Str As String = Nothing
   Str = "Insert Into [Property] (
`ID`, 
`Name`, 
`ImageIndex`, 
`Text`, 
`ToolTip`, 
`Enable`, 
`Status`, 
`Statement`, 
`XMLFile`, 
`Attributes`, 
`Browsable`, 
`Category`, 
`Description`, 
`DefaultValue`, 
`Editor`, 
`DllImport`, 
`Deserializable`, 
`NonSerialized`, 
`Serializable`, 
`XmlRoot`, 
`XmlIgnore`, 
`XmlInclude`, 
`RelatedImageList`, 
`Print_VB`, 
`VB`, 
`Print_C`, 
`C`, 
`Print_F`, 
`F`, 
`Print_Python`, 
`Python`, 
`Print_JavaScript`, 
`JavaScript`, 
`RegionCategory`, 
`RegionCode`, 
`AuthorEmail`, 
`AuthorName`, 
`AuthorUri`, 
`ContributorEmail`, 
`ContributorName`, 
`ContributorUri`, 
`CustomProperty`, 
`Published`, 
`Rights`, 
`Summary`, 
`Title`, 
`Updated`, 
`Usage`, 
`Remarks`, 
`Example`, 
`Note`, 
`CreationDate`, 
`See`, 
`SeeAlso`, 
`Rules`, 
`Syntax`, 
`Default`, 
`AccessModifier`, 
`Shared`, 
`Shadows`, 
`ReadOnly`, 
`WriteOnly`, 
`PropertyModifier`, 
`ReturnType`, 
`Required`, 
`Variable_Name`, 
`Variable_AccessModifier`, 
`Variable_ReturnType`, 
`SetStatement`, 
`GetStatement`, 
`ParentName`) Values (@0, @1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18, @19, @20, @21, @22, @23, @24, @25, @26, @27, @28, @29, @30, @31, @32, @33, @34, @35, @36, @37, @38, @39, @40, @41, @42, @43, @44, @45, @46, @47, @48, @49, @50, @51, @52, @53, @54, @55, @56, @57, @58, @59, @60, @61, @62, @63, @64, @65, @66, @67, @68, @69, @70)"
Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
Cmd = New OleDb.OleDbCommand(Str,Con)
Con.Open()
            Cmd.Parameters.AddWithValue("@0", Me.ID)
            Cmd.Parameters.AddWithValue("@1", Me.Name)
            Cmd.Parameters.AddWithValue("@2", Me.ImageIndex)
            Cmd.Parameters.AddWithValue("@3", Me.Text)
            Cmd.Parameters.AddWithValue("@4", Me.ToolTip)
            Cmd.Parameters.AddWithValue("@5", Me.Enable)
            Cmd.Parameters.AddWithValue("@6", Me.Status)
            Cmd.Parameters.AddWithValue("@7", Me.Statement)
            Cmd.Parameters.AddWithValue("@8", Me.XMLFile)
            Cmd.Parameters.AddWithValue("@9", Me.Attributes)
            Cmd.Parameters.AddWithValue("@10", Me.Browsable)
            Cmd.Parameters.AddWithValue("@11", Me.Category)
            Cmd.Parameters.AddWithValue("@12", Me.Description)
            Cmd.Parameters.AddWithValue("@13", Me.DefaultValue)
            Cmd.Parameters.AddWithValue("@14", Me.Editor)
            Cmd.Parameters.AddWithValue("@15", Me.DllImport)
            Cmd.Parameters.AddWithValue("@16", Me.Deserializable)
            Cmd.Parameters.AddWithValue("@17", Me.NonSerialized)
            Cmd.Parameters.AddWithValue("@18", Me.Serializable)
            Cmd.Parameters.AddWithValue("@19", Me.XmlRoot)
            Cmd.Parameters.AddWithValue("@20", Me.XmlIgnore)
            Cmd.Parameters.AddWithValue("@21", Me.XmlInclude)
            Cmd.Parameters.AddWithValue("@22", Me.RelatedImageList)
            Cmd.Parameters.AddWithValue("@23", Me.Print_VB)
            Cmd.Parameters.AddWithValue("@24", Me.VB)
            Cmd.Parameters.AddWithValue("@25", Me.Print_C)
            Cmd.Parameters.AddWithValue("@26", Me.C)
            Cmd.Parameters.AddWithValue("@27", Me.Print_F)
            Cmd.Parameters.AddWithValue("@28", Me.F)
            Cmd.Parameters.AddWithValue("@29", Me.Print_Python)
            Cmd.Parameters.AddWithValue("@30", Me.Python)
            Cmd.Parameters.AddWithValue("@31", Me.Print_JavaScript)
            Cmd.Parameters.AddWithValue("@32", Me.JavaScript)
            Cmd.Parameters.AddWithValue("@33", Me.RegionCategory)
            Cmd.Parameters.AddWithValue("@34", Me.RegionCode)
            Cmd.Parameters.AddWithValue("@35", Me.AuthorEmail)
            Cmd.Parameters.AddWithValue("@36", Me.AuthorName)
            Cmd.Parameters.AddWithValue("@37", Me.AuthorUri)
            Cmd.Parameters.AddWithValue("@38", Me.ContributorEmail)
            Cmd.Parameters.AddWithValue("@39", Me.ContributorName)
            Cmd.Parameters.AddWithValue("@40", Me.ContributorUri)
            Cmd.Parameters.AddWithValue("@41", Me.CustomProperty)
            Cmd.Parameters.AddWithValue("@42", Me.Published)
            Cmd.Parameters.AddWithValue("@43", Me.Rights)
            Cmd.Parameters.AddWithValue("@44", Me.Summary)
            Cmd.Parameters.AddWithValue("@45", Me.Title)
            Cmd.Parameters.AddWithValue("@46", Me.Updated)
            Cmd.Parameters.AddWithValue("@47", Me.Usage)
            Cmd.Parameters.AddWithValue("@48", Me.Remarks)
            Cmd.Parameters.AddWithValue("@49", Me.Example)
            Cmd.Parameters.AddWithValue("@50", Me.Note)
            Cmd.Parameters.AddWithValue("@51", Me.CreationDate)
            Cmd.Parameters.AddWithValue("@52", Me.See)
            Cmd.Parameters.AddWithValue("@53", Me.SeeAlso)
            Cmd.Parameters.AddWithValue("@54", Me.Rules)
            Cmd.Parameters.AddWithValue("@55", Me.Syntax)
            Cmd.Parameters.AddWithValue("@56", Me.Default)
            Cmd.Parameters.AddWithValue("@57", Me.AccessModifier)
            Cmd.Parameters.AddWithValue("@58", Me.Shared)
            Cmd.Parameters.AddWithValue("@59", Me.Shadows)
            Cmd.Parameters.AddWithValue("@60", Me.ReadOnly)
            Cmd.Parameters.AddWithValue("@61", Me.WriteOnly)
            Cmd.Parameters.AddWithValue("@62", Me.PropertyModifier)
            Cmd.Parameters.AddWithValue("@63", Me.ReturnType)
            Cmd.Parameters.AddWithValue("@64", Me.Required)
            Cmd.Parameters.AddWithValue("@65", Me.Variable_Name)
            Cmd.Parameters.AddWithValue("@66", Me.Variable_AccessModifier)
            Cmd.Parameters.AddWithValue("@67", Me.Variable_ReturnType)
            Cmd.Parameters.AddWithValue("@68", Me.SetStatement)
            Cmd.Parameters.AddWithValue("@69", Me.GetStatement)
            Cmd.Parameters.AddWithValue("@70", Me.ParentName)
          If Cmd.ExecuteNonQuery>=0 Then
          Else
              Msgbox("Element not Addd")
          End If
 Catch ex As Exception 
 Finally 
   Close(True) 
 End Try 

   End Sub
#End Region '(Set|Get) This will add a new row in the table.

#Region"[On] |2019/07/06 00h51:049| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
    '''    <Summary>
'''     (Set|Get) This will update a row in the table.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:983 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) This will update a row in the table.") >
   Public Sub Save()
 Try
   Dim Str As String = Nothing
   Str = "UPDATE [Property] SET Name = @Name, ImageIndex = @ImageIndex, Text = @Text, ToolTip = @ToolTip, Enable = @Enable, Status = @Status, Statement = @Statement, XMLFile = @XMLFile, Attributes = @Attributes, Browsable = @Browsable, Category = @Category, Description = @Description, DefaultValue = @DefaultValue, Editor = @Editor, DllImport = @DllImport, Deserializable = @Deserializable, NonSerialized = @NonSerialized, Serializable = @Serializable, XmlRoot = @XmlRoot, XmlIgnore = @XmlIgnore, XmlInclude = @XmlInclude, RelatedImageList = @RelatedImageList, Print_VB = @Print_VB, VB = @VB, Print_C = @Print_C, C = @C, Print_F = @Print_F, F = @F, Print_Python = @Print_Python, Python = @Python, Print_JavaScript = @Print_JavaScript, JavaScript = @JavaScript, RegionCategory = @RegionCategory, RegionCode = @RegionCode, AuthorEmail = @AuthorEmail, AuthorName = @AuthorName, AuthorUri = @AuthorUri, ContributorEmail = @ContributorEmail, ContributorName = @ContributorName, ContributorUri = @ContributorUri, CustomProperty = @CustomProperty, Published = @Published, Rights = @Rights, Summary = @Summary, Title = @Title, Updated = @Updated, Usage = @Usage, Remarks = @Remarks, Example = @Example, Note = @Note, CreationDate = @CreationDate, See = @See, SeeAlso = @SeeAlso, Rules = @Rules, Syntax = @Syntax, Default = @Default, AccessModifier = @AccessModifier, Shared = @Shared, Shadows = @Shadows, ReadOnly = @ReadOnly, WriteOnly = @WriteOnly, PropertyModifier = @PropertyModifier, ReturnType = @ReturnType, Required = @Required, Variable_Name = @Variable_Name, Variable_AccessModifier = @Variable_AccessModifier, Variable_ReturnType = @Variable_ReturnType, SetStatement = @SetStatement, GetStatement = @GetStatement, ParentName = @ParentName WHERE ID = @ID"
Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
Cmd = New OleDb.OleDbCommand(Str,Con)
Con.Open()
      Cmd.Parameters.AddWithValue("@Name",Name)
      Cmd.Parameters.AddWithValue("@ImageIndex",ImageIndex)
      Cmd.Parameters.AddWithValue("@Text",Text)
      Cmd.Parameters.AddWithValue("@ToolTip",ToolTip)
      Cmd.Parameters.AddWithValue("@Enable",Enable)
      Cmd.Parameters.AddWithValue("@Status",Status)
      Cmd.Parameters.AddWithValue("@Statement",Statement)
      Cmd.Parameters.AddWithValue("@XMLFile",XMLFile)
      Cmd.Parameters.AddWithValue("@Attributes",Attributes)
      Cmd.Parameters.AddWithValue("@Browsable",Browsable)
      Cmd.Parameters.AddWithValue("@Category",Category)
      Cmd.Parameters.AddWithValue("@Description",Description)
      Cmd.Parameters.AddWithValue("@DefaultValue",DefaultValue)
      Cmd.Parameters.AddWithValue("@Editor",Editor)
      Cmd.Parameters.AddWithValue("@DllImport",DllImport)
      Cmd.Parameters.AddWithValue("@Deserializable",Deserializable)
      Cmd.Parameters.AddWithValue("@NonSerialized",NonSerialized)
      Cmd.Parameters.AddWithValue("@Serializable",Serializable)
      Cmd.Parameters.AddWithValue("@XmlRoot",XmlRoot)
      Cmd.Parameters.AddWithValue("@XmlIgnore",XmlIgnore)
      Cmd.Parameters.AddWithValue("@XmlInclude",XmlInclude)
      Cmd.Parameters.AddWithValue("@RelatedImageList",RelatedImageList)
      Cmd.Parameters.AddWithValue("@Print_VB",Print_VB)
      Cmd.Parameters.AddWithValue("@VB",VB)
      Cmd.Parameters.AddWithValue("@Print_C",Print_C)
      Cmd.Parameters.AddWithValue("@C",C)
      Cmd.Parameters.AddWithValue("@Print_F",Print_F)
      Cmd.Parameters.AddWithValue("@F",F)
      Cmd.Parameters.AddWithValue("@Print_Python",Print_Python)
      Cmd.Parameters.AddWithValue("@Python",Python)
      Cmd.Parameters.AddWithValue("@Print_JavaScript",Print_JavaScript)
      Cmd.Parameters.AddWithValue("@JavaScript",JavaScript)
      Cmd.Parameters.AddWithValue("@RegionCategory",RegionCategory)
      Cmd.Parameters.AddWithValue("@RegionCode",RegionCode)
      Cmd.Parameters.AddWithValue("@AuthorEmail",AuthorEmail)
      Cmd.Parameters.AddWithValue("@AuthorName",AuthorName)
      Cmd.Parameters.AddWithValue("@AuthorUri",AuthorUri)
      Cmd.Parameters.AddWithValue("@ContributorEmail",ContributorEmail)
      Cmd.Parameters.AddWithValue("@ContributorName",ContributorName)
      Cmd.Parameters.AddWithValue("@ContributorUri",ContributorUri)
      Cmd.Parameters.AddWithValue("@CustomProperty",CustomProperty)
      Cmd.Parameters.AddWithValue("@Published",Published)
      Cmd.Parameters.AddWithValue("@Rights",Rights)
      Cmd.Parameters.AddWithValue("@Summary",Summary)
      Cmd.Parameters.AddWithValue("@Title",Title)
      Cmd.Parameters.AddWithValue("@Updated",Updated)
      Cmd.Parameters.AddWithValue("@Usage",Usage)
      Cmd.Parameters.AddWithValue("@Remarks",Remarks)
      Cmd.Parameters.AddWithValue("@Example",Example)
      Cmd.Parameters.AddWithValue("@Note",Note)
      Cmd.Parameters.AddWithValue("@CreationDate",CreationDate)
      Cmd.Parameters.AddWithValue("@See",See)
      Cmd.Parameters.AddWithValue("@SeeAlso",SeeAlso)
      Cmd.Parameters.AddWithValue("@Rules",Rules)
      Cmd.Parameters.AddWithValue("@Syntax",Syntax)
      Cmd.Parameters.AddWithValue("@Default",Default)
      Cmd.Parameters.AddWithValue("@AccessModifier",AccessModifier)
      Cmd.Parameters.AddWithValue("@Shared",Shared)
      Cmd.Parameters.AddWithValue("@Shadows",Shadows)
      Cmd.Parameters.AddWithValue("@ReadOnly",ReadOnly)
      Cmd.Parameters.AddWithValue("@WriteOnly",WriteOnly)
      Cmd.Parameters.AddWithValue("@PropertyModifier",PropertyModifier)
      Cmd.Parameters.AddWithValue("@ReturnType",ReturnType)
      Cmd.Parameters.AddWithValue("@Required",Required)
      Cmd.Parameters.AddWithValue("@Variable_Name",Variable_Name)
      Cmd.Parameters.AddWithValue("@Variable_AccessModifier",Variable_AccessModifier)
      Cmd.Parameters.AddWithValue("@Variable_ReturnType",Variable_ReturnType)
      Cmd.Parameters.AddWithValue("@SetStatement",SetStatement)
      Cmd.Parameters.AddWithValue("@GetStatement",GetStatement)
      Cmd.Parameters.AddWithValue("@ParentName",ParentName)
      Cmd.Parameters.AddWithValue("@ID",ID)
          If Cmd.ExecuteNonQuery>=0 Then
          Else
              Msgbox("Element not Saved")
          End If
 Catch ex As Exception 
 Finally 
   Close(True) 
 End Try 

   End Sub
#End Region '(Set|Get) This will update a row in the table.

#Region"[On] |2019/07/06 00h51:064| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
    '''    <Summary>
'''     (Set|Get) This will Delete a row in the table.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:985 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) This will Delete a row in the table.") >
   Public Sub Delete()
 Try
   Dim Str As String = Nothing
   Str = "Delete From [Property] WHERE ID =@ID"
Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
Cmd = New OleDb.OleDbCommand(Str,Con)
Con.Open()
Cmd.Parameters.AddWithValue("@ID", ID)
          If Cmd.ExecuteNonQuery>=0 Then
          Else
              Msgbox("Element not Deleted")
          End If
 Catch ex As Exception 
 Finally 
   Close(True) 
 End Try 

   End Sub
#End Region '(Set|Get) This will Delete a row in the table.

#End Region 
#Region "<5> [Function]{7}"
#Region"[On] |2019/07/06 00h51:078| <05.00.00> <Function> <> |.Open()|TestItem}|"' (Set|Get) This will initialise the connection and import the data.
    '''    <Summary>
'''     (Set|Get) This will initialise the connection and import the data.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:986 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) This will initialise the connection and import the data.") >
   Public Function Open(ByVal SqlCommand As String) As TestItem
 Dim Result As New TestItem("Open(SqlCommand)", " Openning the connection line to the database.")
 If CheckConnection()=True Then
                     Con = New OleDb.OleDbConnection(Me.Line)
                     Cmd = New OleDb.OleDbCommand(SqlCommand,Con)
                         If Con.State = ConnectionState.Open Then
                             Close(True)
                         Else
                             Try
                                 Con.Open()
                                 Result.Status = Status.Online
                             Catch ex As Exception
                                 Result.AddBug(ex,"Error while opening database","SqlCon.Open()")
                                 Result.Why+= ex.Message & vbNewLine
                                 Result.Status = Status.Broken
                             End Try
                         End If
     Else
         Result.Status = Status.Broken
         Result.Why += Log & VbNewLine 
     End If
 Return Result

   End Function
#End Region '(Set|Get) This will initialise the connection and import the data.

#Region"[On] |2019/07/06 00h51:095| <05.00.01> <Function> <> |.Close()|TestItem}|"' (Set|Get) This willClosing the connection
    '''    <Summary>
'''     (Set|Get) This willClosing the connection
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:986 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) This willClosing the connection") >
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
                                 Result.Why +="The connection will not close." & vbNewLine
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
                                 Result.Why +="The connection will not close." & vbNewLine
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
                                 Result.Why +="The connection will not close." & vbNewLine
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
                                 Result.Why +="The connection will not close." & vbNewLine
                             End If
                     End If
             End If
         End If
 Return Result

   End Function
#End Region '(Set|Get) This willClosing the connection

#Region"[On] |2019/07/06 00h51:111| <05.00.02> <Function> <> |.List()|List(Of Property)}|"' (Set|Get) Return the entire table listed
    '''    <Summary>
'''     (Set|Get) Return the entire table listed
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:986 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) Return the entire table listed") >
   Public Function List() As List(Of Property)
Dim Result As New List(Of Property)
Me.Table = New Table(Me.TableName , Me.FilePath , Me.Password,False)
   For each Row As DataRow In Me.Table.DataTable.Rows
      Dim Element As New Property(IIf(IsDBNull(Row.Item(0)),0,Row.Item(0)),
IIf(IsDBNull(Row.Item(1)),"",Row.Item(1)),
IIf(IsDBNull(Row.Item(2)),0,Row.Item(2)),
IIf(IsDBNull(Row.Item(3)),"",Row.Item(3)),
IIf(IsDBNull(Row.Item(4)),"",Row.Item(4)),
IIf(IsDBNull(Row.Item(5)),False,Row.Item(5)),
IIf(IsDBNull(Row.Item(6)),"",Row.Item(6)),
IIf(IsDBNull(Row.Item(7)),"",Row.Item(7)),
IIf(IsDBNull(Row.Item(8)),"",Row.Item(8)),
IIf(IsDBNull(Row.Item(9)),"",Row.Item(9)),
IIf(IsDBNull(Row.Item(10)),False,Row.Item(10)),
IIf(IsDBNull(Row.Item(11)),"",Row.Item(11)),
IIf(IsDBNull(Row.Item(12)),"",Row.Item(12)),
IIf(IsDBNull(Row.Item(13)),"",Row.Item(13)),
IIf(IsDBNull(Row.Item(14)),"",Row.Item(14)),
IIf(IsDBNull(Row.Item(15)),"",Row.Item(15)),
IIf(IsDBNull(Row.Item(16)),False,Row.Item(16)),
IIf(IsDBNull(Row.Item(17)),False,Row.Item(17)),
IIf(IsDBNull(Row.Item(18)),False,Row.Item(18)),
IIf(IsDBNull(Row.Item(19)),"",Row.Item(19)),
IIf(IsDBNull(Row.Item(20)),False,Row.Item(20)),
IIf(IsDBNull(Row.Item(21)),False,Row.Item(21)),
IIf(IsDBNull(Row.Item(22)),"",Row.Item(22)),
IIf(IsDBNull(Row.Item(23)),"",Row.Item(23)),
IIf(IsDBNull(Row.Item(24)),"",Row.Item(24)),
IIf(IsDBNull(Row.Item(25)),"",Row.Item(25)),
IIf(IsDBNull(Row.Item(26)),"",Row.Item(26)),
IIf(IsDBNull(Row.Item(27)),"",Row.Item(27)),
IIf(IsDBNull(Row.Item(28)),"",Row.Item(28)),
IIf(IsDBNull(Row.Item(29)),"",Row.Item(29)),
IIf(IsDBNull(Row.Item(30)),"",Row.Item(30)),
IIf(IsDBNull(Row.Item(31)),"",Row.Item(31)),
IIf(IsDBNull(Row.Item(32)),"",Row.Item(32)),
IIf(IsDBNull(Row.Item(33)),0,Row.Item(33)),
IIf(IsDBNull(Row.Item(34)),"",Row.Item(34)),
IIf(IsDBNull(Row.Item(35)),"",Row.Item(35)),
IIf(IsDBNull(Row.Item(36)),"",Row.Item(36)),
IIf(IsDBNull(Row.Item(37)),"",Row.Item(37)),
IIf(IsDBNull(Row.Item(38)),"",Row.Item(38)),
IIf(IsDBNull(Row.Item(39)),"",Row.Item(39)),
IIf(IsDBNull(Row.Item(40)),"",Row.Item(40)),
IIf(IsDBNull(Row.Item(41)),"",Row.Item(41)),
IIf(IsDBNull(Row.Item(42)),"",Row.Item(42)),
IIf(IsDBNull(Row.Item(43)),"",Row.Item(43)),
IIf(IsDBNull(Row.Item(44)),"",Row.Item(44)),
IIf(IsDBNull(Row.Item(45)),"",Row.Item(45)),
IIf(IsDBNull(Row.Item(46)),"",Row.Item(46)),
IIf(IsDBNull(Row.Item(47)),"",Row.Item(47)),
IIf(IsDBNull(Row.Item(48)),"",Row.Item(48)),
IIf(IsDBNull(Row.Item(49)),"",Row.Item(49)),
IIf(IsDBNull(Row.Item(50)),"",Row.Item(50)),
IIf(IsDBNull(Row.Item(51)),"",Row.Item(51)),
IIf(IsDBNull(Row.Item(52)),"",Row.Item(52)),
IIf(IsDBNull(Row.Item(53)),"",Row.Item(53)),
IIf(IsDBNull(Row.Item(54)),"",Row.Item(54)),
IIf(IsDBNull(Row.Item(55)),"",Row.Item(55)),
IIf(IsDBNull(Row.Item(56)),False,Row.Item(56)),
IIf(IsDBNull(Row.Item(57)),"",Row.Item(57)),
IIf(IsDBNull(Row.Item(58)),False,Row.Item(58)),
IIf(IsDBNull(Row.Item(59)),False,Row.Item(59)),
IIf(IsDBNull(Row.Item(60)),False,Row.Item(60)),
IIf(IsDBNull(Row.Item(61)),False,Row.Item(61)),
IIf(IsDBNull(Row.Item(62)),"",Row.Item(62)),
IIf(IsDBNull(Row.Item(63)),"",Row.Item(63)),
IIf(IsDBNull(Row.Item(64)),False,Row.Item(64)),
IIf(IsDBNull(Row.Item(65)),"",Row.Item(65)),
IIf(IsDBNull(Row.Item(66)),"",Row.Item(66)),
IIf(IsDBNull(Row.Item(67)),"",Row.Item(67)),
IIf(IsDBNull(Row.Item(68)),"",Row.Item(68)),
IIf(IsDBNull(Row.Item(69)),"",Row.Item(69)),
      IIf(IsDBNull(Row.Item(70)),"",Row.Item(70)))
      Element.Reset(Table.Line)
 Result.Add(Element)
 Next
 Return Result
   End Function
#End Region '(Set|Get) Return the entire table listed

#Region"[On] |2019/07/06 00h51:127| <05.00.03> <Function> <> |.SearchByName()|List(Of Property)}|"' (Set|Get) Search for each property that match the Search String.
    '''    <Summary>
'''     (Set|Get) Search for each property that match the Search String.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:986 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) Search for each property that match the Search String.") >
   Public Shared Function SearchByName(ByVal Search As String) As List(Of Property)
Dim Result As New List(Of Property)
 Dim C As New Property
 For Each Element As Property In C.List
 If Element.Name.Tolower() = Search.Tolower() Or Element.Text.Tolower() = Search.Tolower()  Or Element.ToolTip.Tolower() = Search.Tolower()  Or Element.Status.Tolower() = Search.Tolower()  Or Element.Statement.Tolower() = Search.Tolower()  Or Element.XMLFile.Tolower() = Search.Tolower()  Or Element.Attributes.Tolower() = Search.Tolower()  Or Element.Category.Tolower() = Search.Tolower()  Or Element.Description.Tolower() = Search.Tolower()  Or Element.DefaultValue.Tolower() = Search.Tolower()  Or Element.Editor.Tolower() = Search.Tolower()  Or Element.DllImport.Tolower() = Search.Tolower()  Or Element.XmlRoot.Tolower() = Search.Tolower()  Or Element.RelatedImageList.Tolower() = Search.Tolower()  Or Element.Print_VB.Tolower() = Search.Tolower()  Or Element.VB.Tolower() = Search.Tolower()  Or Element.Print_C.Tolower() = Search.Tolower()  Or Element.C.Tolower() = Search.Tolower()  Or Element.Print_F.Tolower() = Search.Tolower()  Or Element.F.Tolower() = Search.Tolower()  Or Element.Print_Python.Tolower() = Search.Tolower()  Or Element.Python.Tolower() = Search.Tolower()  Or Element.Print_JavaScript.Tolower() = Search.Tolower()  Or Element.JavaScript.Tolower() = Search.Tolower()  Or Element.RegionCode.Tolower() = Search.Tolower()  Or Element.AuthorEmail.Tolower() = Search.Tolower()  Or Element.AuthorName.Tolower() = Search.Tolower()  Or Element.AuthorUri.Tolower() = Search.Tolower()  Or Element.ContributorEmail.Tolower() = Search.Tolower()  Or Element.ContributorName.Tolower() = Search.Tolower()  Or Element.ContributorUri.Tolower() = Search.Tolower()  Or Element.CustomProperty.Tolower() = Search.Tolower()  Or Element.Published.Tolower() = Search.Tolower()  Or Element.Rights.Tolower() = Search.Tolower()  Or Element.Summary.Tolower() = Search.Tolower()  Or Element.Title.Tolower() = Search.Tolower()  Or Element.Updated.Tolower() = Search.Tolower()  Or Element.Usage.Tolower() = Search.Tolower()  Or Element.Remarks.Tolower() = Search.Tolower()  Or Element.Example.Tolower() = Search.Tolower()  Or Element.Note.Tolower() = Search.Tolower()  Or Element.CreationDate.Tolower() = Search.Tolower()  Or Element.See.Tolower() = Search.Tolower()  Or Element.SeeAlso.Tolower() = Search.Tolower()  Or Element.Rules.Tolower() = Search.Tolower()  Or Element.Syntax.Tolower() = Search.Tolower()  Or Element.AccessModifier.Tolower() = Search.Tolower()  Or Element.PropertyModifier.Tolower() = Search.Tolower()  Or Element.ReturnType.Tolower() = Search.Tolower()  Or Element.Variable_Name.Tolower() = Search.Tolower()  Or Element.Variable_AccessModifier.Tolower() = Search.Tolower()  Or Element.Variable_ReturnType.Tolower() = Search.Tolower()  Or Element.SetStatement.Tolower() = Search.Tolower()  Or Element.GetStatement.Tolower() = Search.Tolower()  Or Element.ParentName.Tolower() = Search.Tolower() Then
      Result.Add(Element)
 End If
 Next
 Return Result
   End Function
#End Region '(Set|Get) Search for each property that match the Search String.

#Region"[On] |2019/07/06 00h51:145| <05.00.04> <Function> <> |.SearchByID()|List(Of Property)}|"' (Set|Get) Search for each property that match the Search Id.
    '''    <Summary>
'''     (Set|Get) Search for each property that match the Search Id.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:986 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) Search for each property that match the Search Id.") >
   Public Shared Function SearchByID(ByVal Search As Double) As List(Of Property)
Dim Result As New List(Of Property)
 Dim C As New Property
 For Each Element As Property In C.List
 If Val(Element.ID) = Search Or Val(Element.ImageIndex) = Search  Or Val(Element.RegionCategory) = Search Then
      Result.Add(Element)
 End If
 Next
 Return Result
   End Function
#End Region '(Set|Get) Search for each property that match the Search Id.

#Region"[On] |2019/07/06 00h51:161| <05.00.05> <Function> <> |.ToString()|String}|"' (Set|Get) The function ToString.
    '''    <Summary>
'''     (Set|Get) The function ToString.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:987 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The function ToString.") >
   Public Overrides Function ToString() As String
    Return Me.ID
   End Function
#End Region '(Set|Get) The function ToString.

#Region"[On] |2019/07/06 00h51:177| <05.00.06> <Function> <> |.CheckConnection()|Boolean}|"' (Set|Get) Evaluate the connection to the DataBase
    '''    <Summary>
'''     (Set|Get) Evaluate the connection to the DataBase
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:987 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) Evaluate the connection to the DataBase") >
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
    Dim Message As String = Nothing' Stores the process logic.
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
        If D.IsReady  Then
            Test_4 = True
        Message += "Test 4 <Result> |OK| The Drive is Online."
        Else
            Test_4 = False
        Message += "Test 4 <Result> |PB| The Drive is Offline or Disconnected."
        End If
 #End Region 
 #Region "Test 5 | Evaluate if there is a Password."
        If Not IsDbNull(Password) Then
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
                    Me.Connector = New LineInfo(FilePath,Password)
                    Me.Line = Me.Connector.Line
        Message += "Test 6 <Result> |Initialize Connector|"
                End If
        End If
 #End Region 
 #Region "Test 7 | Evaluate if Connector Line is not empty."
        If Not IsDbNull(Me.Connector.Line) Then
            Test_7 = True
        Else 
            Test_7 = False
        End If
 #End Region 
 #Region "Test 8 | Evaluate if the Connection is valid."
        If Test_7 =True Then
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
 If Test_7=True And Test_8 = True Then
    General_Status=True
 Else 
    General_Status=False
 End If
 Log+=Message & VbNewLine
 Return General_Status

   End Function
#End Region '(Set|Get) Evaluate the connection to the DataBase

#End Region 
#Region "<6> [Runtime]{12}"
#Region"[On] |2019/07/06 00h51:193| <15.00.00> <Runtime> <> |.Table()|Table"' (Set|Get) The Table.
    '''    <Summary>
'''     (Set|Get) The Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:987 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The Table.") >
   Public  Table As Table
#End Region '(Set|Get) The Table.

#Region"[On] |2019/07/06 00h51:207| <15.00.01> <Runtime> <> |.Line()|String"' (Set|Get) The Connection String To the Table.
    '''    <Summary>
'''     (Set|Get) The Connection String To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:988 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The Connection String To the Table.") >
   Public  Line As String
#End Region '(Set|Get) The Connection String To the Table.

#Region"[On] |2019/07/06 00h51:223| <15.00.02> <Runtime> <> |.FilePath()|String"' (Set|Get) The FilePath To the Table.
    '''    <Summary>
'''     (Set|Get) The FilePath To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:988 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The FilePath To the Table.") >
   Public  FilePath As String
#End Region '(Set|Get) The FilePath To the Table.

#Region"[On] |2019/07/06 00h51:238| <15.00.03> <Runtime> <> |.Password()|String"' (Set|Get) The Password To the Table.
    '''    <Summary>
'''     (Set|Get) The Password To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:988 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The Password To the Table.") >
   Public  Password As String
#End Region '(Set|Get) The Password To the Table.

#Region"[On] |2019/07/06 00h51:252| <15.00.04> <Runtime> <> |.UseSQL()|Boolean"' (Set|Get) Determines if the Database Connection is of type SQL.
    '''    <Summary>
'''     (Set|Get) Determines if the Database Connection is of type SQL.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:988 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) Determines if the Database Connection is of type SQL.") >
   Public  UseSQL As Boolean
#End Region '(Set|Get) Determines if the Database Connection is of type SQL.

#Region"[On] |2019/07/06 00h51:267| <15.00.05> <Runtime> <> |.TableName()|String"' (Set|Get) The name of the Table.
    '''    <Summary>
'''     (Set|Get) The name of the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:989 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The name of the Table.") >
   Public  TableName As String
#End Region '(Set|Get) The name of the Table.

#Region"[On] |2019/07/06 00h51:284| <15.00.06> <Runtime> <> |.Con()|OleDb.OleDbConnection"' (Set|Get) The Con To the Table.
    '''    <Summary>
'''     (Set|Get) The Con To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:989 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The Con To the Table.") >
   Public  Con As OleDb.OleDbConnection
#End Region '(Set|Get) The Con To the Table.

#Region"[On] |2019/07/06 00h51:290| <15.00.07> <Runtime> <> |.Cmd()|OleDb.OleDbCommand"' (Set|Get) The Cmd To the Table.
    '''    <Summary>
'''     (Set|Get) The Cmd To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:989 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The Cmd To the Table.") >
   Public  Cmd As OleDb.OleDbCommand
#End Region '(Set|Get) The Cmd To the Table.

#Region"[On] |2019/07/06 00h51:315| <15.00.08> <Runtime> <> |.DataReader()|OleDb.OleDbDataReader"' (Set|Get) The DataReader To the Table.
    '''    <Summary>
'''     (Set|Get) The DataReader To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:989 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The DataReader To the Table.") >
   Public  DataReader As OleDb.OleDbDataReader
#End Region '(Set|Get) The DataReader To the Table.

#Region"[On] |2019/07/06 00h51:330| <15.00.09> <Runtime> <> |.DataAdapter()|OleDb.OleDbDataAdapter"' (Set|Get) The DataAdapter To the Table.
    '''    <Summary>
'''     (Set|Get) The DataAdapter To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:990 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The DataAdapter To the Table.") >
   Public  DataAdapter As OleDb.OleDbDataAdapter
#End Region '(Set|Get) The DataAdapter To the Table.

#Region"[On] |2019/07/06 00h51:345| <15.00.10> <Runtime> <> |.Connector()|LineInfo"' (Set|Get) The Connector To the Table.
    '''    <Summary>
'''     (Set|Get) The Connector To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:990 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The Connector To the Table.") >
   Public  Connector As LineInfo
#End Region '(Set|Get) The Connector To the Table.

#Region"[On] |2019/07/06 00h51:362| <15.00.11> <Runtime> <> |.Log()|String"' (Set|Get) The Log To the Table.
    '''    <Summary>
'''     (Set|Get) The Log To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:990 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The Log To the Table.") >
   Public  Log As String
#End Region '(Set|Get) The Log To the Table.

#End Region 
#Region "<7> [Loader]{2}"
#Region"[On] |2019/07/06 00h51:378| <06.00.00> <Loader> <> |.Empty()|Function}|"' (Set|Get) The sub Empty.
    '''    <Summary>
'''     (Set|Get) The sub Empty.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:991 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The sub Empty.") >
   Public Sub New ()
Reset
   End Sub
#End Region '(Set|Get) The sub Empty.

#Region"[On] |2019/07/06 00h51:382| <06.00.01> <Loader> <> |.Filled()|Function}|"' (Set|Get) The sub Filled.
    '''    <Summary>
'''     (Set|Get) The sub Filled.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:991 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>    ''' <param name="ID">(Set|Get) The ID as Integer.</param>
    ''' <param name="Name">(Set|Get) The Name as String.</param>
    ''' <param name="ImageIndex">(Set|Get) The ImageIndex as Integer.</param>
    ''' <param name="Text">(Set|Get) The Text as String.</param>
    ''' <param name="ToolTip">(Set|Get) The ToolTip as String.</param>
    ''' <param name="Enable">(Set|Get) The Enable as Boolean.</param>
    ''' <param name="Status">(Set|Get) The Status as String.</param>
    ''' <param name="Statement">(Set|Get) The Statement as String.</param>
    ''' <param name="XMLFile">(Set|Get) The XMLFile as String.</param>
    ''' <param name="Attributes">(Set|Get) The Attributes as String.</param>
    ''' <param name="Browsable">(Set|Get) The Browsable as Boolean.</param>
    ''' <param name="Category">(Set|Get) The Category as String.</param>
    ''' <param name="Description">(Set|Get) The Description as String.</param>
    ''' <param name="DefaultValue">(Set|Get) The DefaultValue as String.</param>
    ''' <param name="Editor">(Set|Get) The Editor as String.</param>
    ''' <param name="DllImport">(Set|Get) The DllImport as String.</param>
    ''' <param name="Deserializable">(Set|Get) The Deserializable as Boolean.</param>
    ''' <param name="NonSerialized">(Set|Get) The NonSerialized as Boolean.</param>
    ''' <param name="Serializable">(Set|Get) The Serializable as Boolean.</param>
    ''' <param name="XmlRoot">(Set|Get) The XmlRoot as String.</param>
    ''' <param name="XmlIgnore">(Set|Get) The XmlIgnore as Boolean.</param>
    ''' <param name="XmlInclude">(Set|Get) The XmlInclude as Boolean.</param>
    ''' <param name="RelatedImageList">(Set|Get) The RelatedImageList as String.</param>
    ''' <param name="Print_VB">(Set|Get) The Print_VB as String.</param>
    ''' <param name="VB">(Set|Get) The VB as String.</param>
    ''' <param name="Print_C">(Set|Get) The Print_C as String.</param>
    ''' <param name="C">(Set|Get) The C as String.</param>
    ''' <param name="Print_F">(Set|Get) The Print_F as String.</param>
    ''' <param name="F">(Set|Get) The F as String.</param>
    ''' <param name="Print_Python">(Set|Get) The Print_Python as String.</param>
    ''' <param name="Python">(Set|Get) The Python as String.</param>
    ''' <param name="Print_JavaScript">(Set|Get) The Print_JavaScript as String.</param>
    ''' <param name="JavaScript">(Set|Get) The JavaScript as String.</param>
    ''' <param name="RegionCategory">(Set|Get) The RegionCategory as Integer.</param>
    ''' <param name="RegionCode">(Set|Get) The RegionCode as String.</param>
    ''' <param name="AuthorEmail">(Set|Get) The AuthorEmail as String.</param>
    ''' <param name="AuthorName">(Set|Get) The AuthorName as String.</param>
    ''' <param name="AuthorUri">(Set|Get) The AuthorUri as String.</param>
    ''' <param name="ContributorEmail">(Set|Get) The ContributorEmail as String.</param>
    ''' <param name="ContributorName">(Set|Get) The ContributorName as String.</param>
    ''' <param name="ContributorUri">(Set|Get) The ContributorUri as String.</param>
    ''' <param name="CustomProperty">(Set|Get) The CustomProperty as String.</param>
    ''' <param name="Published">(Set|Get) The Published as String.</param>
    ''' <param name="Rights">(Set|Get) The Rights as String.</param>
    ''' <param name="Summary">(Set|Get) The Summary as String.</param>
    ''' <param name="Title">(Set|Get) The Title as String.</param>
    ''' <param name="Updated">(Set|Get) The Updated as String.</param>
    ''' <param name="Usage">(Set|Get) The Usage as String.</param>
    ''' <param name="Remarks">(Set|Get) The Remarks as String.</param>
    ''' <param name="Example">(Set|Get) The Example as String.</param>
    ''' <param name="Note">(Set|Get) The Note as String.</param>
    ''' <param name="CreationDate">(Set|Get) The CreationDate as String.</param>
    ''' <param name="See">(Set|Get) The See as String.</param>
    ''' <param name="SeeAlso">(Set|Get) The SeeAlso as String.</param>
    ''' <param name="Rules">(Set|Get) The Rules as String.</param>
    ''' <param name="Syntax">(Set|Get) The Syntax as String.</param>
    ''' <param name="Default">(Set|Get) The Default as Boolean.</param>
    ''' <param name="AccessModifier">(Set|Get) The AccessModifier as String.</param>
    ''' <param name="Shared">(Set|Get) The Shared as Boolean.</param>
    ''' <param name="Shadows">(Set|Get) The Shadows as Boolean.</param>
    ''' <param name="ReadOnly">(Set|Get) The ReadOnly as Boolean.</param>
    ''' <param name="WriteOnly">(Set|Get) The WriteOnly as Boolean.</param>
    ''' <param name="PropertyModifier">(Set|Get) The PropertyModifier as String.</param>
    ''' <param name="ReturnType">(Set|Get) The ReturnType as String.</param>
    ''' <param name="Required">(Set|Get) The Required as Boolean.</param>
    ''' <param name="Variable_Name">(Set|Get) The Variable_Name as String.</param>
    ''' <param name="Variable_AccessModifier">(Set|Get) The Variable_AccessModifier as String.</param>
    ''' <param name="Variable_ReturnType">(Set|Get) The Variable_ReturnType as String.</param>
    ''' <param name="SetStatement">(Set|Get) The SetStatement as String.</param>
    ''' <param name="GetStatement">(Set|Get) The GetStatement as String.</param>
    ''' <param name="ParentName">(Set|Get) The ParentName as String.</param>

    <Browsable(True) , Description("(Set|Get) The sub Filled.") >
   Public Sub New (ByVal ID As Integer, 
ByVal Name As String, 
ByVal ImageIndex As Integer, 
ByVal Text As String, 
ByVal ToolTip As String, 
ByVal Enable As Boolean, 
ByVal Status As String, 
ByVal Statement As String, 
ByVal XMLFile As String, 
ByVal Attributes As String, 
ByVal Browsable As Boolean, 
ByVal Category As String, 
ByVal Description As String, 
ByVal DefaultValue As String, 
ByVal Editor As String, 
ByVal DllImport As String, 
ByVal Deserializable As Boolean, 
ByVal NonSerialized As Boolean, 
ByVal Serializable As Boolean, 
ByVal XmlRoot As String, 
ByVal XmlIgnore As Boolean, 
ByVal XmlInclude As Boolean, 
ByVal RelatedImageList As String, 
ByVal Print_VB As String, 
ByVal VB As String, 
ByVal Print_C As String, 
ByVal C As String, 
ByVal Print_F As String, 
ByVal F As String, 
ByVal Print_Python As String, 
ByVal Python As String, 
ByVal Print_JavaScript As String, 
ByVal JavaScript As String, 
ByVal RegionCategory As Integer, 
ByVal RegionCode As String, 
ByVal AuthorEmail As String, 
ByVal AuthorName As String, 
ByVal AuthorUri As String, 
ByVal ContributorEmail As String, 
ByVal ContributorName As String, 
ByVal ContributorUri As String, 
ByVal CustomProperty As String, 
ByVal Published As String, 
ByVal Rights As String, 
ByVal Summary As String, 
ByVal Title As String, 
ByVal Updated As String, 
ByVal Usage As String, 
ByVal Remarks As String, 
ByVal Example As String, 
ByVal Note As String, 
ByVal CreationDate As String, 
ByVal See As String, 
ByVal SeeAlso As String, 
ByVal Rules As String, 
ByVal Syntax As String, 
ByVal Default As Boolean, 
ByVal AccessModifier As String, 
ByVal Shared As Boolean, 
ByVal Shadows As Boolean, 
ByVal ReadOnly As Boolean, 
ByVal WriteOnly As Boolean, 
ByVal PropertyModifier As String, 
ByVal ReturnType As String, 
ByVal Required As Boolean, 
ByVal Variable_Name As String, 
ByVal Variable_AccessModifier As String, 
ByVal Variable_ReturnType As String, 
ByVal SetStatement As String, 
ByVal GetStatement As String, 
ByVal ParentName As String)
 With Me
 Clear()
 Reset()
     .ID = ID
     .Name = Name
     .ImageIndex = ImageIndex
     .Text = Text
     .ToolTip = ToolTip
     .Enable = Enable
     .Status = Status
     .Statement = Statement
     .XMLFile = XMLFile
     .Attributes = Attributes
     .Browsable = Browsable
     .Category = Category
     .Description = Description
     .DefaultValue = DefaultValue
     .Editor = Editor
     .DllImport = DllImport
     .Deserializable = Deserializable
     .NonSerialized = NonSerialized
     .Serializable = Serializable
     .XmlRoot = XmlRoot
     .XmlIgnore = XmlIgnore
     .XmlInclude = XmlInclude
     .RelatedImageList = RelatedImageList
     .Print_VB = Print_VB
     .VB = VB
     .Print_C = Print_C
     .C = C
     .Print_F = Print_F
     .F = F
     .Print_Python = Print_Python
     .Python = Python
     .Print_JavaScript = Print_JavaScript
     .JavaScript = JavaScript
     .RegionCategory = RegionCategory
     .RegionCode = RegionCode
     .AuthorEmail = AuthorEmail
     .AuthorName = AuthorName
     .AuthorUri = AuthorUri
     .ContributorEmail = ContributorEmail
     .ContributorName = ContributorName
     .ContributorUri = ContributorUri
     .CustomProperty = CustomProperty
     .Published = Published
     .Rights = Rights
     .Summary = Summary
     .Title = Title
     .Updated = Updated
     .Usage = Usage
     .Remarks = Remarks
     .Example = Example
     .Note = Note
     .CreationDate = CreationDate
     .See = See
     .SeeAlso = SeeAlso
     .Rules = Rules
     .Syntax = Syntax
     .Default = Default
     .AccessModifier = AccessModifier
     .Shared = Shared
     .Shadows = Shadows
     .ReadOnly = ReadOnly
     .WriteOnly = WriteOnly
     .PropertyModifier = PropertyModifier
     .ReturnType = ReturnType
     .Required = Required
     .Variable_Name = Variable_Name
     .Variable_AccessModifier = Variable_AccessModifier
     .Variable_ReturnType = Variable_ReturnType
     .SetStatement = SetStatement
     .GetStatement = GetStatement
     .ParentName = ParentName
 End With

   End Sub
#End Region '(Set|Get) The sub Filled.

#End Region 
 End Class
#End Region

#Region"[On] |2019/07/06 00h51:566| <08.00.00> <Class> <> |.Statement|Class|{83} |Production Cost : 127.3|Selling Price : 318.25|"' Class created automatically by SmartOffice (c)Copyright 2019.
'''    <Summary>
'''     Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Statement
'''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
'''    Contributor Information : ||
'''    Creation Date :           2019/07/06 00h51:566
'''    |Schema|
'''    |ID| |ObjectType |{Quantity}||UnitPrice||Total
'''    |00| |Importation|{0}||1| |0
'''    |01| |Properties |{56}||0.8| |44.8
'''    |02| |Enumeration|{1}||0.4| |0.4
'''    |03| |Structure  |{0}||0.4| |0
'''    |04| |Sub        |{5}||1.2| |6
'''    |05| |Function   |{7}||1.6| |11.2
'''    |06| |Runtime    |{12}||0.4| |4.8
'''    |07| |Loader     |{2}||0.8| |1.6
'''    |08| |Class      |{0}||2| |0
'''    |09| |Constante  |{0}||0.4| |0
'''    |10| |Event      |{0}||1.2| |0
'''    |11| |Members    |{56}||0.5| |28
'''    |12| |Parameter  |{61}||0.5| |30.5
'''    |Production Cost             |127.3
'''    |Selling Price without VAT   |318.25
'''    |Total TVA                   |24.51
'''    |Grand Total                 |342.76
'''    |/Schema|
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:024 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
Public  Class Statement
#Region "<1> [Property]{56}"
#Region"[On] |2019/07/06 00h51:567| <01.00.00> <Property> <Columns> |.ID()|Integer|"' (Set|Get) The ID as Integer.
   Private _ID As Integer
    '''    <Summary>
'''     (Set|Get) The ID as Integer.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:024 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ID as Integer.") >
   Public Property ID()As Integer
       Get
       Return _ID
       End Get
       Set(ByVal Value As Integer)
       _ID = Value
       End Set
   End Property
#End Region '(Set|Get) The ID as Integer.

#Region"[On] |2019/07/06 00h51:580| <01.00.01> <Property> <Columns> |.Name()|String|"' (Set|Get) The Name as String.
   Private _Name As String
    '''    <Summary>
'''     (Set|Get) The Name as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:024 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Name as String.") >
   Public Property Name()As String
       Get
       Return _Name
       End Get
       Set(ByVal Value As String)
       _Name = Value
       End Set
   End Property
#End Region '(Set|Get) The Name as String.

#Region"[On] |2019/07/06 00h51:592| <01.00.02> <Property> <Columns> |.ImageIndex()|Integer|"' (Set|Get) The ImageIndex as Integer.
   Private _ImageIndex As Integer
    '''    <Summary>
'''     (Set|Get) The ImageIndex as Integer.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:025 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ImageIndex as Integer.") >
   Public Property ImageIndex()As Integer
       Get
       Return _ImageIndex
       End Get
       Set(ByVal Value As Integer)
       _ImageIndex = Value
       End Set
   End Property
#End Region '(Set|Get) The ImageIndex as Integer.

#Region"[On] |2019/07/06 00h51:603| <01.00.03> <Property> <Columns> |.Text()|String|"' (Set|Get) The Text as String.
   Private _Text As String
    '''    <Summary>
'''     (Set|Get) The Text as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:025 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Text as String.") >
   Public Property Text()As String
       Get
       Return _Text
       End Get
       Set(ByVal Value As String)
       _Text = Value
       End Set
   End Property
#End Region '(Set|Get) The Text as String.

#Region"[On] |2019/07/06 00h51:614| <01.00.04> <Property> <Columns> |.ToolTip()|String|"' (Set|Get) The ToolTip as String.
   Private _ToolTip As String
    '''    <Summary>
'''     (Set|Get) The ToolTip as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:025 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ToolTip as String.") >
   Public Property ToolTip()As String
       Get
       Return _ToolTip
       End Get
       Set(ByVal Value As String)
       _ToolTip = Value
       End Set
   End Property
#End Region '(Set|Get) The ToolTip as String.

#Region"[On] |2019/07/06 00h51:626| <01.00.05> <Property> <Columns> |.Enable()|Boolean|"' (Set|Get) The Enable as Boolean.
   Private _Enable As Boolean
    '''    <Summary>
'''     (Set|Get) The Enable as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:025 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Enable as Boolean.") >
   Public Property Enable()As Boolean
       Get
       Return _Enable
       End Get
       Set(ByVal Value As Boolean)
       _Enable = Value
       End Set
   End Property
#End Region '(Set|Get) The Enable as Boolean.

#Region"[On] |2019/07/06 00h51:642| <01.00.06> <Property> <Columns> |.Status()|String|"' (Set|Get) The Status as String.
   Private _Status As String
    '''    <Summary>
'''     (Set|Get) The Status as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:025 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Status as String.") >
   Public Property Status()As String
       Get
       Return _Status
       End Get
       Set(ByVal Value As String)
       _Status = Value
       End Set
   End Property
#End Region '(Set|Get) The Status as String.

#Region"[On] |2019/07/06 00h51:653| <01.00.07> <Property> <Columns> |.Statement()|String|"' (Set|Get) The Statement as String.
   Private _Statement As String
    '''    <Summary>
'''     (Set|Get) The Statement as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:026 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Statement as String.") >
   Public Property Statement()As String
       Get
       Return _Statement
       End Get
       Set(ByVal Value As String)
       _Statement = Value
       End Set
   End Property
#End Region '(Set|Get) The Statement as String.

#Region"[On] |2019/07/06 00h51:665| <01.00.08> <Property> <Columns> |.XMLFile()|String|"' (Set|Get) The XMLFile as String.
   Private _XMLFile As String
    '''    <Summary>
'''     (Set|Get) The XMLFile as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:026 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XMLFile as String.") >
   Public Property XMLFile()As String
       Get
       Return _XMLFile
       End Get
       Set(ByVal Value As String)
       _XMLFile = Value
       End Set
   End Property
#End Region '(Set|Get) The XMLFile as String.

#Region"[On] |2019/07/06 00h51:676| <01.00.09> <Property> <Columns> |.Attributes()|String|"' (Set|Get) The Attributes as String.
   Private _Attributes As String
    '''    <Summary>
'''     (Set|Get) The Attributes as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:026 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Attributes as String.") >
   Public Property Attributes()As String
       Get
       Return _Attributes
       End Get
       Set(ByVal Value As String)
       _Attributes = Value
       End Set
   End Property
#End Region '(Set|Get) The Attributes as String.

#Region"[On] |2019/07/06 00h51:689| <01.00.10> <Property> <Columns> |.Browsable()|Boolean|"' (Set|Get) The Browsable as Boolean.
   Private _Browsable As Boolean
    '''    <Summary>
'''     (Set|Get) The Browsable as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:026 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Browsable as Boolean.") >
   Public Property Browsable()As Boolean
       Get
       Return _Browsable
       End Get
       Set(ByVal Value As Boolean)
       _Browsable = Value
       End Set
   End Property
#End Region '(Set|Get) The Browsable as Boolean.

#Region"[On] |2019/07/06 00h51:700| <01.00.11> <Property> <Columns> |.Category()|String|"' (Set|Get) The Category as String.
   Private _Category As String
    '''    <Summary>
'''     (Set|Get) The Category as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:026 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Category as String.") >
   Public Property Category()As String
       Get
       Return _Category
       End Get
       Set(ByVal Value As String)
       _Category = Value
       End Set
   End Property
#End Region '(Set|Get) The Category as String.

#Region"[On] |2019/07/06 00h51:712| <01.00.12> <Property> <Columns> |.Description()|String|"' (Set|Get) The Description as String.
   Private _Description As String
    '''    <Summary>
'''     (Set|Get) The Description as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:027 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Description as String.") >
   Public Property Description()As String
       Get
       Return _Description
       End Get
       Set(ByVal Value As String)
       _Description = Value
       End Set
   End Property
#End Region '(Set|Get) The Description as String.

#Region"[On] |2019/07/06 00h51:723| <01.00.13> <Property> <Columns> |.DefaultValue()|String|"' (Set|Get) The DefaultValue as String.
   Private _DefaultValue As String
    '''    <Summary>
'''     (Set|Get) The DefaultValue as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:027 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The DefaultValue as String.") >
   Public Property DefaultValue()As String
       Get
       Return _DefaultValue
       End Get
       Set(ByVal Value As String)
       _DefaultValue = Value
       End Set
   End Property
#End Region '(Set|Get) The DefaultValue as String.

#Region"[On] |2019/07/06 00h51:734| <01.00.14> <Property> <Columns> |.Editor()|String|"' (Set|Get) The Editor as String.
   Private _Editor As String
    '''    <Summary>
'''     (Set|Get) The Editor as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:027 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Editor as String.") >
   Public Property Editor()As String
       Get
       Return _Editor
       End Get
       Set(ByVal Value As String)
       _Editor = Value
       End Set
   End Property
#End Region '(Set|Get) The Editor as String.

#Region"[On] |2019/07/06 00h51:746| <01.00.15> <Property> <Columns> |.DllImport()|String|"' (Set|Get) The DllImport as String.
   Private _DllImport As String
    '''    <Summary>
'''     (Set|Get) The DllImport as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:028 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The DllImport as String.") >
   Public Property DllImport()As String
       Get
       Return _DllImport
       End Get
       Set(ByVal Value As String)
       _DllImport = Value
       End Set
   End Property
#End Region '(Set|Get) The DllImport as String.

#Region"[On] |2019/07/06 00h51:757| <01.00.16> <Property> <Columns> |.Deserializable()|Boolean|"' (Set|Get) The Deserializable as Boolean.
   Private _Deserializable As Boolean
    '''    <Summary>
'''     (Set|Get) The Deserializable as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:028 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Deserializable as Boolean.") >
   Public Property Deserializable()As Boolean
       Get
       Return _Deserializable
       End Get
       Set(ByVal Value As Boolean)
       _Deserializable = Value
       End Set
   End Property
#End Region '(Set|Get) The Deserializable as Boolean.

#Region"[On] |2019/07/06 00h51:768| <01.00.17> <Property> <Columns> |.NonSerialized()|Boolean|"' (Set|Get) The NonSerialized as Boolean.
   Private _NonSerialized As Boolean
    '''    <Summary>
'''     (Set|Get) The NonSerialized as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:028 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The NonSerialized as Boolean.") >
   Public Property NonSerialized()As Boolean
       Get
       Return _NonSerialized
       End Get
       Set(ByVal Value As Boolean)
       _NonSerialized = Value
       End Set
   End Property
#End Region '(Set|Get) The NonSerialized as Boolean.

#Region"[On] |2019/07/06 00h51:780| <01.00.18> <Property> <Columns> |.Serializable()|Boolean|"' (Set|Get) The Serializable as Boolean.
   Private _Serializable As Boolean
    '''    <Summary>
'''     (Set|Get) The Serializable as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:028 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Serializable as Boolean.") >
   Public Property Serializable()As Boolean
       Get
       Return _Serializable
       End Get
       Set(ByVal Value As Boolean)
       _Serializable = Value
       End Set
   End Property
#End Region '(Set|Get) The Serializable as Boolean.

#Region"[On] |2019/07/06 00h51:790| <01.00.19> <Property> <Columns> |.XmlRoot()|String|"' (Set|Get) The XmlRoot as String.
   Private _XmlRoot As String
    '''    <Summary>
'''     (Set|Get) The XmlRoot as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:028 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XmlRoot as String.") >
   Public Property XmlRoot()As String
       Get
       Return _XmlRoot
       End Get
       Set(ByVal Value As String)
       _XmlRoot = Value
       End Set
   End Property
#End Region '(Set|Get) The XmlRoot as String.

#Region"[On] |2019/07/06 00h51:801| <01.00.20> <Property> <Columns> |.XmlIgnore()|Boolean|"' (Set|Get) The XmlIgnore as Boolean.
   Private _XmlIgnore As Boolean
    '''    <Summary>
'''     (Set|Get) The XmlIgnore as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:029 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XmlIgnore as Boolean.") >
   Public Property XmlIgnore()As Boolean
       Get
       Return _XmlIgnore
       End Get
       Set(ByVal Value As Boolean)
       _XmlIgnore = Value
       End Set
   End Property
#End Region '(Set|Get) The XmlIgnore as Boolean.

#Region"[On] |2019/07/06 00h51:811| <01.00.21> <Property> <Columns> |.XmlInclude()|Boolean|"' (Set|Get) The XmlInclude as Boolean.
   Private _XmlInclude As Boolean
    '''    <Summary>
'''     (Set|Get) The XmlInclude as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:029 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XmlInclude as Boolean.") >
   Public Property XmlInclude()As Boolean
       Get
       Return _XmlInclude
       End Get
       Set(ByVal Value As Boolean)
       _XmlInclude = Value
       End Set
   End Property
#End Region '(Set|Get) The XmlInclude as Boolean.

#Region"[On] |2019/07/06 00h51:823| <01.00.22> <Property> <Columns> |.RelatedImageList()|String|"' (Set|Get) The RelatedImageList as String.
   Private _RelatedImageList As String
    '''    <Summary>
'''     (Set|Get) The RelatedImageList as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:029 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The RelatedImageList as String.") >
   Public Property RelatedImageList()As String
       Get
       Return _RelatedImageList
       End Get
       Set(ByVal Value As String)
       _RelatedImageList = Value
       End Set
   End Property
#End Region '(Set|Get) The RelatedImageList as String.

#Region"[On] |2019/07/06 00h51:834| <01.00.23> <Property> <Columns> |.Print_VB()|String|"' (Set|Get) The Print_VB as String.
   Private _Print_VB As String
    '''    <Summary>
'''     (Set|Get) The Print_VB as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:029 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_VB as String.") >
   Public Property Print_VB()As String
       Get
       Return _Print_VB
       End Get
       Set(ByVal Value As String)
       _Print_VB = Value
       End Set
   End Property
#End Region '(Set|Get) The Print_VB as String.

#Region"[On] |2019/07/06 00h51:846| <01.00.24> <Property> <Columns> |.VB()|String|"' (Set|Get) The VB as String.
   Private _VB As String
    '''    <Summary>
'''     (Set|Get) The VB as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:029 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The VB as String.") >
   Public Property VB()As String
       Get
       Return _VB
       End Get
       Set(ByVal Value As String)
       _VB = Value
       End Set
   End Property
#End Region '(Set|Get) The VB as String.

#Region"[On] |2019/07/06 00h51:860| <01.00.25> <Property> <Columns> |.Print_C()|String|"' (Set|Get) The Print_C as String.
   Private _Print_C As String
    '''    <Summary>
'''     (Set|Get) The Print_C as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:031 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_C as String.") >
   Public Property Print_C()As String
       Get
       Return _Print_C
       End Get
       Set(ByVal Value As String)
       _Print_C = Value
       End Set
   End Property
#End Region '(Set|Get) The Print_C as String.

#Region"[On] |2019/07/06 00h51:871| <01.00.26> <Property> <Columns> |.C()|String|"' (Set|Get) The C as String.
   Private _C As String
    '''    <Summary>
'''     (Set|Get) The C as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:031 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The C as String.") >
   Public Property C()As String
       Get
       Return _C
       End Get
       Set(ByVal Value As String)
       _C = Value
       End Set
   End Property
#End Region '(Set|Get) The C as String.

#Region"[On] |2019/07/06 00h51:890| <01.00.27> <Property> <Columns> |.Print_F()|String|"' (Set|Get) The Print_F as String.
   Private _Print_F As String
    '''    <Summary>
'''     (Set|Get) The Print_F as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:031 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_F as String.") >
   Public Property Print_F()As String
       Get
       Return _Print_F
       End Get
       Set(ByVal Value As String)
       _Print_F = Value
       End Set
   End Property
#End Region '(Set|Get) The Print_F as String.

#Region"[On] |2019/07/06 00h51:901| <01.00.28> <Property> <Columns> |.F()|String|"' (Set|Get) The F as String.
   Private _F As String
    '''    <Summary>
'''     (Set|Get) The F as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:031 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The F as String.") >
   Public Property F()As String
       Get
       Return _F
       End Get
       Set(ByVal Value As String)
       _F = Value
       End Set
   End Property
#End Region '(Set|Get) The F as String.

#Region"[On] |2019/07/06 00h51:913| <01.00.29> <Property> <Columns> |.Print_Python()|String|"' (Set|Get) The Print_Python as String.
   Private _Print_Python As String
    '''    <Summary>
'''     (Set|Get) The Print_Python as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:031 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_Python as String.") >
   Public Property Print_Python()As String
       Get
       Return _Print_Python
       End Get
       Set(ByVal Value As String)
       _Print_Python = Value
       End Set
   End Property
#End Region '(Set|Get) The Print_Python as String.

#Region"[On] |2019/07/06 00h51:925| <01.00.30> <Property> <Columns> |.Python()|String|"' (Set|Get) The Python as String.
   Private _Python As String
    '''    <Summary>
'''     (Set|Get) The Python as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:032 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Python as String.") >
   Public Property Python()As String
       Get
       Return _Python
       End Get
       Set(ByVal Value As String)
       _Python = Value
       End Set
   End Property
#End Region '(Set|Get) The Python as String.

#Region"[On] |2019/07/06 00h51:936| <01.00.31> <Property> <Columns> |.Print_JavaScript()|String|"' (Set|Get) The Print_JavaScript as String.
   Private _Print_JavaScript As String
    '''    <Summary>
'''     (Set|Get) The Print_JavaScript as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:032 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_JavaScript as String.") >
   Public Property Print_JavaScript()As String
       Get
       Return _Print_JavaScript
       End Get
       Set(ByVal Value As String)
       _Print_JavaScript = Value
       End Set
   End Property
#End Region '(Set|Get) The Print_JavaScript as String.

#Region"[On] |2019/07/06 00h51:948| <01.00.32> <Property> <Columns> |.JavaScript()|String|"' (Set|Get) The JavaScript as String.
   Private _JavaScript As String
    '''    <Summary>
'''     (Set|Get) The JavaScript as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:032 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The JavaScript as String.") >
   Public Property JavaScript()As String
       Get
       Return _JavaScript
       End Get
       Set(ByVal Value As String)
       _JavaScript = Value
       End Set
   End Property
#End Region '(Set|Get) The JavaScript as String.

#Region"[On] |2019/07/06 00h51:960| <01.00.33> <Property> <Columns> |.RegionCategory()|Integer|"' (Set|Get) The RegionCategory as Integer.
   Private _RegionCategory As Integer
    '''    <Summary>
'''     (Set|Get) The RegionCategory as Integer.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:032 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The RegionCategory as Integer.") >
   Public Property RegionCategory()As Integer
       Get
       Return _RegionCategory
       End Get
       Set(ByVal Value As Integer)
       _RegionCategory = Value
       End Set
   End Property
#End Region '(Set|Get) The RegionCategory as Integer.

#Region"[On] |2019/07/06 00h51:971| <01.00.34> <Property> <Columns> |.RegionCode()|String|"' (Set|Get) The RegionCode as String.
   Private _RegionCode As String
    '''    <Summary>
'''     (Set|Get) The RegionCode as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:032 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The RegionCode as String.") >
   Public Property RegionCode()As String
       Get
       Return _RegionCode
       End Get
       Set(ByVal Value As String)
       _RegionCode = Value
       End Set
   End Property
#End Region '(Set|Get) The RegionCode as String.

#Region"[On] |2019/07/06 00h51:984| <01.00.35> <Property> <Columns> |.AuthorEmail()|String|"' (Set|Get) The AuthorEmail as String.
   Private _AuthorEmail As String
    '''    <Summary>
'''     (Set|Get) The AuthorEmail as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:033 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AuthorEmail as String.") >
   Public Property AuthorEmail()As String
       Get
       Return _AuthorEmail
       End Get
       Set(ByVal Value As String)
       _AuthorEmail = Value
       End Set
   End Property
#End Region '(Set|Get) The AuthorEmail as String.

#Region"[On] |2019/07/06 00h51:996| <01.00.36> <Property> <Columns> |.AuthorName()|String|"' (Set|Get) The AuthorName as String.
   Private _AuthorName As String
    '''    <Summary>
'''     (Set|Get) The AuthorName as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:033 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AuthorName as String.") >
   Public Property AuthorName()As String
       Get
       Return _AuthorName
       End Get
       Set(ByVal Value As String)
       _AuthorName = Value
       End Set
   End Property
#End Region '(Set|Get) The AuthorName as String.

#Region"[On] |2019/07/06 00h51:008| <01.00.37> <Property> <Columns> |.AuthorUri()|String|"' (Set|Get) The AuthorUri as String.
   Private _AuthorUri As String
    '''    <Summary>
'''     (Set|Get) The AuthorUri as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:033 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AuthorUri as String.") >
   Public Property AuthorUri()As String
       Get
       Return _AuthorUri
       End Get
       Set(ByVal Value As String)
       _AuthorUri = Value
       End Set
   End Property
#End Region '(Set|Get) The AuthorUri as String.

#Region"[On] |2019/07/06 00h51:021| <01.00.38> <Property> <Columns> |.ContributorEmail()|String|"' (Set|Get) The ContributorEmail as String.
   Private _ContributorEmail As String
    '''    <Summary>
'''     (Set|Get) The ContributorEmail as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:033 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ContributorEmail as String.") >
   Public Property ContributorEmail()As String
       Get
       Return _ContributorEmail
       End Get
       Set(ByVal Value As String)
       _ContributorEmail = Value
       End Set
   End Property
#End Region '(Set|Get) The ContributorEmail as String.

#Region"[On] |2019/07/06 00h51:032| <01.00.39> <Property> <Columns> |.ContributorName()|String|"' (Set|Get) The ContributorName as String.
   Private _ContributorName As String
    '''    <Summary>
'''     (Set|Get) The ContributorName as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:033 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ContributorName as String.") >
   Public Property ContributorName()As String
       Get
       Return _ContributorName
       End Get
       Set(ByVal Value As String)
       _ContributorName = Value
       End Set
   End Property
#End Region '(Set|Get) The ContributorName as String.

#Region"[On] |2019/07/06 00h51:043| <01.00.40> <Property> <Columns> |.ContributorUri()|String|"' (Set|Get) The ContributorUri as String.
   Private _ContributorUri As String
    '''    <Summary>
'''     (Set|Get) The ContributorUri as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:034 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ContributorUri as String.") >
   Public Property ContributorUri()As String
       Get
       Return _ContributorUri
       End Get
       Set(ByVal Value As String)
       _ContributorUri = Value
       End Set
   End Property
#End Region '(Set|Get) The ContributorUri as String.

#Region"[On] |2019/07/06 00h51:055| <01.00.41> <Property> <Columns> |.CustomProperty()|String|"' (Set|Get) The CustomProperty as String.
   Private _CustomProperty As String
    '''    <Summary>
'''     (Set|Get) The CustomProperty as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:034 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The CustomProperty as String.") >
   Public Property CustomProperty()As String
       Get
       Return _CustomProperty
       End Get
       Set(ByVal Value As String)
       _CustomProperty = Value
       End Set
   End Property
#End Region '(Set|Get) The CustomProperty as String.

#Region"[On] |2019/07/06 00h51:067| <01.00.42> <Property> <Columns> |.Published()|String|"' (Set|Get) The Published as String.
   Private _Published As String
    '''    <Summary>
'''     (Set|Get) The Published as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:034 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Published as String.") >
   Public Property Published()As String
       Get
       Return _Published
       End Get
       Set(ByVal Value As String)
       _Published = Value
       End Set
   End Property
#End Region '(Set|Get) The Published as String.

#Region"[On] |2019/07/06 00h51:081| <01.00.43> <Property> <Columns> |.Rights()|String|"' (Set|Get) The Rights as String.
   Private _Rights As String
    '''    <Summary>
'''     (Set|Get) The Rights as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:034 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Rights as String.") >
   Public Property Rights()As String
       Get
       Return _Rights
       End Get
       Set(ByVal Value As String)
       _Rights = Value
       End Set
   End Property
#End Region '(Set|Get) The Rights as String.

#Region"[On] |2019/07/06 00h51:095| <01.00.44> <Property> <Columns> |.Summary()|String|"' (Set|Get) The Summary as String.
   Private _Summary As String
    '''    <Summary>
'''     (Set|Get) The Summary as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:035 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Summary as String.") >
   Public Property Summary()As String
       Get
       Return _Summary
       End Get
       Set(ByVal Value As String)
       _Summary = Value
       End Set
   End Property
#End Region '(Set|Get) The Summary as String.

#Region"[On] |2019/07/06 00h51:108| <01.00.45> <Property> <Columns> |.Title()|String|"' (Set|Get) The Title as String.
   Private _Title As String
    '''    <Summary>
'''     (Set|Get) The Title as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:035 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Title as String.") >
   Public Property Title()As String
       Get
       Return _Title
       End Get
       Set(ByVal Value As String)
       _Title = Value
       End Set
   End Property
#End Region '(Set|Get) The Title as String.

#Region"[On] |2019/07/06 00h51:120| <01.00.46> <Property> <Columns> |.Updated()|String|"' (Set|Get) The Updated as String.
   Private _Updated As String
    '''    <Summary>
'''     (Set|Get) The Updated as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:035 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Updated as String.") >
   Public Property Updated()As String
       Get
       Return _Updated
       End Get
       Set(ByVal Value As String)
       _Updated = Value
       End Set
   End Property
#End Region '(Set|Get) The Updated as String.

#Region"[On] |2019/07/06 00h51:143| <01.00.47> <Property> <Columns> |.Usage()|String|"' (Set|Get) The Usage as String.
   Private _Usage As String
    '''    <Summary>
'''     (Set|Get) The Usage as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:035 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Usage as String.") >
   Public Property Usage()As String
       Get
       Return _Usage
       End Get
       Set(ByVal Value As String)
       _Usage = Value
       End Set
   End Property
#End Region '(Set|Get) The Usage as String.

#Region"[On] |2019/07/06 00h51:156| <01.00.48> <Property> <Columns> |.Remarks()|String|"' (Set|Get) The Remarks as String.
   Private _Remarks As String
    '''    <Summary>
'''     (Set|Get) The Remarks as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:035 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Remarks as String.") >
   Public Property Remarks()As String
       Get
       Return _Remarks
       End Get
       Set(ByVal Value As String)
       _Remarks = Value
       End Set
   End Property
#End Region '(Set|Get) The Remarks as String.

#Region"[On] |2019/07/06 00h51:171| <01.00.49> <Property> <Columns> |.Example()|String|"' (Set|Get) The Example as String.
   Private _Example As String
    '''    <Summary>
'''     (Set|Get) The Example as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:036 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Example as String.") >
   Public Property Example()As String
       Get
       Return _Example
       End Get
       Set(ByVal Value As String)
       _Example = Value
       End Set
   End Property
#End Region '(Set|Get) The Example as String.

#Region"[On] |2019/07/06 00h51:183| <01.00.50> <Property> <Columns> |.Note()|String|"' (Set|Get) The Note as String.
   Private _Note As String
    '''    <Summary>
'''     (Set|Get) The Note as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:036 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Note as String.") >
   Public Property Note()As String
       Get
       Return _Note
       End Get
       Set(ByVal Value As String)
       _Note = Value
       End Set
   End Property
#End Region '(Set|Get) The Note as String.

#Region"[On] |2019/07/06 00h51:196| <01.00.51> <Property> <Columns> |.CreationDate()|String|"' (Set|Get) The CreationDate as String.
   Private _CreationDate As String
    '''    <Summary>
'''     (Set|Get) The CreationDate as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:036 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The CreationDate as String.") >
   Public Property CreationDate()As String
       Get
       Return _CreationDate
       End Get
       Set(ByVal Value As String)
       _CreationDate = Value
       End Set
   End Property
#End Region '(Set|Get) The CreationDate as String.

#Region"[On] |2019/07/06 00h51:208| <01.00.52> <Property> <Columns> |.See()|String|"' (Set|Get) The See as String.
   Private _See As String
    '''    <Summary>
'''     (Set|Get) The See as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:036 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The See as String.") >
   Public Property See()As String
       Get
       Return _See
       End Get
       Set(ByVal Value As String)
       _See = Value
       End Set
   End Property
#End Region '(Set|Get) The See as String.

#Region"[On] |2019/07/06 00h51:221| <01.00.53> <Property> <Columns> |.SeeAlso()|String|"' (Set|Get) The SeeAlso as String.
   Private _SeeAlso As String
    '''    <Summary>
'''     (Set|Get) The SeeAlso as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:037 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The SeeAlso as String.") >
   Public Property SeeAlso()As String
       Get
       Return _SeeAlso
       End Get
       Set(ByVal Value As String)
       _SeeAlso = Value
       End Set
   End Property
#End Region '(Set|Get) The SeeAlso as String.

#Region"[On] |2019/07/06 00h51:235| <01.00.54> <Property> <Columns> |.Rules()|String|"' (Set|Get) The Rules as String.
   Private _Rules As String
    '''    <Summary>
'''     (Set|Get) The Rules as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:037 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Rules as String.") >
   Public Property Rules()As String
       Get
       Return _Rules
       End Get
       Set(ByVal Value As String)
       _Rules = Value
       End Set
   End Property
#End Region '(Set|Get) The Rules as String.

#Region"[On] |2019/07/06 00h51:249| <01.00.55> <Property> <Columns> |.Syntax()|String|"' (Set|Get) The Syntax as String.
   Private _Syntax As String
    '''    <Summary>
'''     (Set|Get) The Syntax as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:037 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Syntax as String.") >
   Public Property Syntax()As String
       Get
       Return _Syntax
       End Get
       Set(ByVal Value As String)
       _Syntax = Value
       End Set
   End Property
#End Region '(Set|Get) The Syntax as String.

#End Region 
#Region"<2> [Enumeration]{1}"
#Region"[On] |2019/07/06 00h51:264| <02.00.00> <Enumeration> <> |.Schema()|Enumeration{55}|"' (Set|Get) The enumeration of Schema.
    '''    <Summary>
'''     (Set|Get) The enumeration of Schema.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:038 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The enumeration of Schema.") >
   Enum Schema
''' <summary>(Set|Get) The ID as Integer.</summary>
   [ID] = 0
''' <summary>(Set|Get) The Name as String.</summary>
   [Name] = 1
''' <summary>(Set|Get) The ImageIndex as Integer.</summary>
   [ImageIndex] = 2
''' <summary>(Set|Get) The Text as String.</summary>
   [Text] = 3
''' <summary>(Set|Get) The ToolTip as String.</summary>
   [ToolTip] = 4
''' <summary>(Set|Get) The Enable as Boolean.</summary>
   [Enable] = 5
''' <summary>(Set|Get) The Status as String.</summary>
   [Status] = 6
''' <summary>(Set|Get) The Statement as String.</summary>
   [Statement] = 7
''' <summary>(Set|Get) The XMLFile as String.</summary>
   [XMLFile] = 8
''' <summary>(Set|Get) The Attributes as String.</summary>
   [Attributes] = 9
''' <summary>(Set|Get) The Browsable as Boolean.</summary>
   [Browsable] = 10
''' <summary>(Set|Get) The Category as String.</summary>
   [Category] = 11
''' <summary>(Set|Get) The Description as String.</summary>
   [Description] = 12
''' <summary>(Set|Get) The DefaultValue as String.</summary>
   [DefaultValue] = 13
''' <summary>(Set|Get) The Editor as String.</summary>
   [Editor] = 14
''' <summary>(Set|Get) The DllImport as String.</summary>
   [DllImport] = 15
''' <summary>(Set|Get) The Deserializable as Boolean.</summary>
   [Deserializable] = 16
''' <summary>(Set|Get) The NonSerialized as Boolean.</summary>
   [NonSerialized] = 17
''' <summary>(Set|Get) The Serializable as Boolean.</summary>
   [Serializable] = 18
''' <summary>(Set|Get) The XmlRoot as String.</summary>
   [XmlRoot] = 19
''' <summary>(Set|Get) The XmlIgnore as Boolean.</summary>
   [XmlIgnore] = 20
''' <summary>(Set|Get) The XmlInclude as Boolean.</summary>
   [XmlInclude] = 21
''' <summary>(Set|Get) The RelatedImageList as String.</summary>
   [RelatedImageList] = 22
''' <summary>(Set|Get) The Print_VB as String.</summary>
   [Print_VB] = 23
''' <summary>(Set|Get) The VB as String.</summary>
   [VB] = 24
''' <summary>(Set|Get) The Print_C as String.</summary>
   [Print_C] = 25
''' <summary>(Set|Get) The C as String.</summary>
   [C] = 26
''' <summary>(Set|Get) The Print_F as String.</summary>
   [Print_F] = 27
''' <summary>(Set|Get) The F as String.</summary>
   [F] = 28
''' <summary>(Set|Get) The Print_Python as String.</summary>
   [Print_Python] = 29
''' <summary>(Set|Get) The Python as String.</summary>
   [Python] = 30
''' <summary>(Set|Get) The Print_JavaScript as String.</summary>
   [Print_JavaScript] = 31
''' <summary>(Set|Get) The JavaScript as String.</summary>
   [JavaScript] = 32
''' <summary>(Set|Get) The RegionCategory as Integer.</summary>
   [RegionCategory] = 33
''' <summary>(Set|Get) The RegionCode as String.</summary>
   [RegionCode] = 34
''' <summary>(Set|Get) The AuthorEmail as String.</summary>
   [AuthorEmail] = 35
''' <summary>(Set|Get) The AuthorName as String.</summary>
   [AuthorName] = 36
''' <summary>(Set|Get) The AuthorUri as String.</summary>
   [AuthorUri] = 37
''' <summary>(Set|Get) The ContributorEmail as String.</summary>
   [ContributorEmail] = 38
''' <summary>(Set|Get) The ContributorName as String.</summary>
   [ContributorName] = 39
''' <summary>(Set|Get) The ContributorUri as String.</summary>
   [ContributorUri] = 40
''' <summary>(Set|Get) The CustomProperty as String.</summary>
   [CustomProperty] = 41
''' <summary>(Set|Get) The Published as String.</summary>
   [Published] = 42
''' <summary>(Set|Get) The Rights as String.</summary>
   [Rights] = 43
''' <summary>(Set|Get) The Summary as String.</summary>
   [Summary] = 44
''' <summary>(Set|Get) The Title as String.</summary>
   [Title] = 45
''' <summary>(Set|Get) The Updated as String.</summary>
   [Updated] = 46
''' <summary>(Set|Get) The Usage as String.</summary>
   [Usage] = 47
''' <summary>(Set|Get) The Remarks as String.</summary>
   [Remarks] = 48
''' <summary>(Set|Get) The Example as String.</summary>
   [Example] = 49
''' <summary>(Set|Get) The Note as String.</summary>
   [Note] = 50
''' <summary>(Set|Get) The CreationDate as String.</summary>
   [CreationDate] = 51
''' <summary>(Set|Get) The See as String.</summary>
   [See] = 52
''' <summary>(Set|Get) The SeeAlso as String.</summary>
   [SeeAlso] = 53
''' <summary>(Set|Get) The Rules as String.</summary>
   [Rules] = 54
''' <summary>(Set|Get) The Syntax as String.</summary>
   [Syntax] = 55
   End Enum
#End Region '(Set|Get) The enumeration of Schema.

#End Region 
#Region "<4> [Sub]{5}"
#Region"[On] |2019/07/06 00h51:291| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
    '''    <Summary>
'''     (Set|Get) This will reinitialize the class element.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:040 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) This will reinitialize the class element.") >
   Public Sub Clear()
  With Me
        .ID = 0
        .Name = Nothing
        .ImageIndex = 0
        .Text = Nothing
        .ToolTip = Nothing
        .Enable = False
        .Status = Nothing
        .Statement = Nothing
        .XMLFile = Nothing
        .Attributes = Nothing
        .Browsable = False
        .Category = Nothing
        .Description = Nothing
        .DefaultValue = Nothing
        .Editor = Nothing
        .DllImport = Nothing
        .Deserializable = False
        .NonSerialized = False
        .Serializable = False
        .XmlRoot = Nothing
        .XmlIgnore = False
        .XmlInclude = False
        .RelatedImageList = Nothing
        .Print_VB = Nothing
        .VB = Nothing
        .Print_C = Nothing
        .C = Nothing
        .Print_F = Nothing
        .F = Nothing
        .Print_Python = Nothing
        .Python = Nothing
        .Print_JavaScript = Nothing
        .JavaScript = Nothing
        .RegionCategory = 0
        .RegionCode = Nothing
        .AuthorEmail = Nothing
        .AuthorName = Nothing
        .AuthorUri = Nothing
        .ContributorEmail = Nothing
        .ContributorName = Nothing
        .ContributorUri = Nothing
        .CustomProperty = Nothing
        .Published = Nothing
        .Rights = Nothing
        .Summary = Nothing
        .Title = Nothing
        .Updated = Nothing
        .Usage = Nothing
        .Remarks = Nothing
        .Example = Nothing
        .Note = Nothing
        .CreationDate = Nothing
        .See = Nothing
        .SeeAlso = Nothing
        .Rules = Nothing
        .Syntax = Nothing
 End With
   End Sub
#End Region '(Set|Get) This will reinitialize the class element.

#Region"[On] |2019/07/06 00h51:304| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
    '''    <Summary>
'''     (Set|Get) This will reinitialize the variables of this class.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:041 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) This will reinitialize the variables of this class.") >
   Public Sub Reset(Optional ByVal Connector As LineInfo = Nothing)
If Not IsNothing(Connector) Then
   Me.Connector=Connector
   Me.FilePath=""
   Me.Password=""
   Me.Line=""
   If Connector.Status<>Status.Broken Then 
        FilePath = Connector.FilePath
        Password = Connector.Password
        Me.Connector=Connector
        TableName = "Statement"
        Line = Connector.Line
        UseSQL = False
   Else
        FilePath = My.Settings.Db_ProjectDatabase_FilePath
        Password = My.Settings.Db_ProjectDatabase_Password
        Me.Line = My.Settings.Db_ProjectDatabase_Line
        TableName = "Statement"
        UseSQL = False
   End If
Else
        If IsNothing(FilePath) Then 
             FilePath = My.Settings.Db_ProjectDatabase_FilePath
        End If 
        If FilePath.Length<1 Then 
             FilePath = My.Settings.Db_ProjectDatabase_FilePath
        End If 
        FilePath = My.Settings.Db_ProjectDatabase_FilePath
        Password = My.Settings.Db_ProjectDatabase_Password
        Me.Line = My.Settings.Db_ProjectDatabase_Line
        TableName = "Statement"
        UseSQL = False
End If

   End Sub
#End Region '(Set|Get) This will reinitialize the variables of this class.

#Region"[On] |2019/07/06 00h51:319| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
    '''    <Summary>
'''     (Set|Get) This will add a new row in the table.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:041 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) This will add a new row in the table.") >
   Public Sub Add()
 Try
   Dim Str As String = Nothing
   Str = "Insert Into [Statement] (
`ID`, 
`Name`, 
`ImageIndex`, 
`Text`, 
`ToolTip`, 
`Enable`, 
`Status`, 
`Statement`, 
`XMLFile`, 
`Attributes`, 
`Browsable`, 
`Category`, 
`Description`, 
`DefaultValue`, 
`Editor`, 
`DllImport`, 
`Deserializable`, 
`NonSerialized`, 
`Serializable`, 
`XmlRoot`, 
`XmlIgnore`, 
`XmlInclude`, 
`RelatedImageList`, 
`Print_VB`, 
`VB`, 
`Print_C`, 
`C`, 
`Print_F`, 
`F`, 
`Print_Python`, 
`Python`, 
`Print_JavaScript`, 
`JavaScript`, 
`RegionCategory`, 
`RegionCode`, 
`AuthorEmail`, 
`AuthorName`, 
`AuthorUri`, 
`ContributorEmail`, 
`ContributorName`, 
`ContributorUri`, 
`CustomProperty`, 
`Published`, 
`Rights`, 
`Summary`, 
`Title`, 
`Updated`, 
`Usage`, 
`Remarks`, 
`Example`, 
`Note`, 
`CreationDate`, 
`See`, 
`SeeAlso`, 
`Rules`, 
`Syntax`) Values (@0, @1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18, @19, @20, @21, @22, @23, @24, @25, @26, @27, @28, @29, @30, @31, @32, @33, @34, @35, @36, @37, @38, @39, @40, @41, @42, @43, @44, @45, @46, @47, @48, @49, @50, @51, @52, @53, @54, @55)"
Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
Cmd = New OleDb.OleDbCommand(Str,Con)
Con.Open()
            Cmd.Parameters.AddWithValue("@0", Me.ID)
            Cmd.Parameters.AddWithValue("@1", Me.Name)
            Cmd.Parameters.AddWithValue("@2", Me.ImageIndex)
            Cmd.Parameters.AddWithValue("@3", Me.Text)
            Cmd.Parameters.AddWithValue("@4", Me.ToolTip)
            Cmd.Parameters.AddWithValue("@5", Me.Enable)
            Cmd.Parameters.AddWithValue("@6", Me.Status)
            Cmd.Parameters.AddWithValue("@7", Me.Statement)
            Cmd.Parameters.AddWithValue("@8", Me.XMLFile)
            Cmd.Parameters.AddWithValue("@9", Me.Attributes)
            Cmd.Parameters.AddWithValue("@10", Me.Browsable)
            Cmd.Parameters.AddWithValue("@11", Me.Category)
            Cmd.Parameters.AddWithValue("@12", Me.Description)
            Cmd.Parameters.AddWithValue("@13", Me.DefaultValue)
            Cmd.Parameters.AddWithValue("@14", Me.Editor)
            Cmd.Parameters.AddWithValue("@15", Me.DllImport)
            Cmd.Parameters.AddWithValue("@16", Me.Deserializable)
            Cmd.Parameters.AddWithValue("@17", Me.NonSerialized)
            Cmd.Parameters.AddWithValue("@18", Me.Serializable)
            Cmd.Parameters.AddWithValue("@19", Me.XmlRoot)
            Cmd.Parameters.AddWithValue("@20", Me.XmlIgnore)
            Cmd.Parameters.AddWithValue("@21", Me.XmlInclude)
            Cmd.Parameters.AddWithValue("@22", Me.RelatedImageList)
            Cmd.Parameters.AddWithValue("@23", Me.Print_VB)
            Cmd.Parameters.AddWithValue("@24", Me.VB)
            Cmd.Parameters.AddWithValue("@25", Me.Print_C)
            Cmd.Parameters.AddWithValue("@26", Me.C)
            Cmd.Parameters.AddWithValue("@27", Me.Print_F)
            Cmd.Parameters.AddWithValue("@28", Me.F)
            Cmd.Parameters.AddWithValue("@29", Me.Print_Python)
            Cmd.Parameters.AddWithValue("@30", Me.Python)
            Cmd.Parameters.AddWithValue("@31", Me.Print_JavaScript)
            Cmd.Parameters.AddWithValue("@32", Me.JavaScript)
            Cmd.Parameters.AddWithValue("@33", Me.RegionCategory)
            Cmd.Parameters.AddWithValue("@34", Me.RegionCode)
            Cmd.Parameters.AddWithValue("@35", Me.AuthorEmail)
            Cmd.Parameters.AddWithValue("@36", Me.AuthorName)
            Cmd.Parameters.AddWithValue("@37", Me.AuthorUri)
            Cmd.Parameters.AddWithValue("@38", Me.ContributorEmail)
            Cmd.Parameters.AddWithValue("@39", Me.ContributorName)
            Cmd.Parameters.AddWithValue("@40", Me.ContributorUri)
            Cmd.Parameters.AddWithValue("@41", Me.CustomProperty)
            Cmd.Parameters.AddWithValue("@42", Me.Published)
            Cmd.Parameters.AddWithValue("@43", Me.Rights)
            Cmd.Parameters.AddWithValue("@44", Me.Summary)
            Cmd.Parameters.AddWithValue("@45", Me.Title)
            Cmd.Parameters.AddWithValue("@46", Me.Updated)
            Cmd.Parameters.AddWithValue("@47", Me.Usage)
            Cmd.Parameters.AddWithValue("@48", Me.Remarks)
            Cmd.Parameters.AddWithValue("@49", Me.Example)
            Cmd.Parameters.AddWithValue("@50", Me.Note)
            Cmd.Parameters.AddWithValue("@51", Me.CreationDate)
            Cmd.Parameters.AddWithValue("@52", Me.See)
            Cmd.Parameters.AddWithValue("@53", Me.SeeAlso)
            Cmd.Parameters.AddWithValue("@54", Me.Rules)
            Cmd.Parameters.AddWithValue("@55", Me.Syntax)
          If Cmd.ExecuteNonQuery>=0 Then
          Else
              Msgbox("Element not Addd")
          End If
 Catch ex As Exception 
 Finally 
   Close(True) 
 End Try 

   End Sub
#End Region '(Set|Get) This will add a new row in the table.

#Region"[On] |2019/07/06 00h51:333| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
    '''    <Summary>
'''     (Set|Get) This will update a row in the table.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:041 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) This will update a row in the table.") >
   Public Sub Save()
 Try
   Dim Str As String = Nothing
   Str = "UPDATE [Statement] SET Name = @Name, ImageIndex = @ImageIndex, Text = @Text, ToolTip = @ToolTip, Enable = @Enable, Status = @Status, Statement = @Statement, XMLFile = @XMLFile, Attributes = @Attributes, Browsable = @Browsable, Category = @Category, Description = @Description, DefaultValue = @DefaultValue, Editor = @Editor, DllImport = @DllImport, Deserializable = @Deserializable, NonSerialized = @NonSerialized, Serializable = @Serializable, XmlRoot = @XmlRoot, XmlIgnore = @XmlIgnore, XmlInclude = @XmlInclude, RelatedImageList = @RelatedImageList, Print_VB = @Print_VB, VB = @VB, Print_C = @Print_C, C = @C, Print_F = @Print_F, F = @F, Print_Python = @Print_Python, Python = @Python, Print_JavaScript = @Print_JavaScript, JavaScript = @JavaScript, RegionCategory = @RegionCategory, RegionCode = @RegionCode, AuthorEmail = @AuthorEmail, AuthorName = @AuthorName, AuthorUri = @AuthorUri, ContributorEmail = @ContributorEmail, ContributorName = @ContributorName, ContributorUri = @ContributorUri, CustomProperty = @CustomProperty, Published = @Published, Rights = @Rights, Summary = @Summary, Title = @Title, Updated = @Updated, Usage = @Usage, Remarks = @Remarks, Example = @Example, Note = @Note, CreationDate = @CreationDate, See = @See, SeeAlso = @SeeAlso, Rules = @Rules, Syntax = @Syntax WHERE ID = @ID"
Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
Cmd = New OleDb.OleDbCommand(Str,Con)
Con.Open()
      Cmd.Parameters.AddWithValue("@Name",Name)
      Cmd.Parameters.AddWithValue("@ImageIndex",ImageIndex)
      Cmd.Parameters.AddWithValue("@Text",Text)
      Cmd.Parameters.AddWithValue("@ToolTip",ToolTip)
      Cmd.Parameters.AddWithValue("@Enable",Enable)
      Cmd.Parameters.AddWithValue("@Status",Status)
      Cmd.Parameters.AddWithValue("@Statement",Statement)
      Cmd.Parameters.AddWithValue("@XMLFile",XMLFile)
      Cmd.Parameters.AddWithValue("@Attributes",Attributes)
      Cmd.Parameters.AddWithValue("@Browsable",Browsable)
      Cmd.Parameters.AddWithValue("@Category",Category)
      Cmd.Parameters.AddWithValue("@Description",Description)
      Cmd.Parameters.AddWithValue("@DefaultValue",DefaultValue)
      Cmd.Parameters.AddWithValue("@Editor",Editor)
      Cmd.Parameters.AddWithValue("@DllImport",DllImport)
      Cmd.Parameters.AddWithValue("@Deserializable",Deserializable)
      Cmd.Parameters.AddWithValue("@NonSerialized",NonSerialized)
      Cmd.Parameters.AddWithValue("@Serializable",Serializable)
      Cmd.Parameters.AddWithValue("@XmlRoot",XmlRoot)
      Cmd.Parameters.AddWithValue("@XmlIgnore",XmlIgnore)
      Cmd.Parameters.AddWithValue("@XmlInclude",XmlInclude)
      Cmd.Parameters.AddWithValue("@RelatedImageList",RelatedImageList)
      Cmd.Parameters.AddWithValue("@Print_VB",Print_VB)
      Cmd.Parameters.AddWithValue("@VB",VB)
      Cmd.Parameters.AddWithValue("@Print_C",Print_C)
      Cmd.Parameters.AddWithValue("@C",C)
      Cmd.Parameters.AddWithValue("@Print_F",Print_F)
      Cmd.Parameters.AddWithValue("@F",F)
      Cmd.Parameters.AddWithValue("@Print_Python",Print_Python)
      Cmd.Parameters.AddWithValue("@Python",Python)
      Cmd.Parameters.AddWithValue("@Print_JavaScript",Print_JavaScript)
      Cmd.Parameters.AddWithValue("@JavaScript",JavaScript)
      Cmd.Parameters.AddWithValue("@RegionCategory",RegionCategory)
      Cmd.Parameters.AddWithValue("@RegionCode",RegionCode)
      Cmd.Parameters.AddWithValue("@AuthorEmail",AuthorEmail)
      Cmd.Parameters.AddWithValue("@AuthorName",AuthorName)
      Cmd.Parameters.AddWithValue("@AuthorUri",AuthorUri)
      Cmd.Parameters.AddWithValue("@ContributorEmail",ContributorEmail)
      Cmd.Parameters.AddWithValue("@ContributorName",ContributorName)
      Cmd.Parameters.AddWithValue("@ContributorUri",ContributorUri)
      Cmd.Parameters.AddWithValue("@CustomProperty",CustomProperty)
      Cmd.Parameters.AddWithValue("@Published",Published)
      Cmd.Parameters.AddWithValue("@Rights",Rights)
      Cmd.Parameters.AddWithValue("@Summary",Summary)
      Cmd.Parameters.AddWithValue("@Title",Title)
      Cmd.Parameters.AddWithValue("@Updated",Updated)
      Cmd.Parameters.AddWithValue("@Usage",Usage)
      Cmd.Parameters.AddWithValue("@Remarks",Remarks)
      Cmd.Parameters.AddWithValue("@Example",Example)
      Cmd.Parameters.AddWithValue("@Note",Note)
      Cmd.Parameters.AddWithValue("@CreationDate",CreationDate)
      Cmd.Parameters.AddWithValue("@See",See)
      Cmd.Parameters.AddWithValue("@SeeAlso",SeeAlso)
      Cmd.Parameters.AddWithValue("@Rules",Rules)
      Cmd.Parameters.AddWithValue("@Syntax",Syntax)
      Cmd.Parameters.AddWithValue("@ID",ID)
          If Cmd.ExecuteNonQuery>=0 Then
          Else
              Msgbox("Element not Saved")
          End If
 Catch ex As Exception 
 Finally 
   Close(True) 
 End Try 

   End Sub
#End Region '(Set|Get) This will update a row in the table.

#Region"[On] |2019/07/06 00h51:349| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
    '''    <Summary>
'''     (Set|Get) This will Delete a row in the table.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:041 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) This will Delete a row in the table.") >
   Public Sub Delete()
 Try
   Dim Str As String = Nothing
   Str = "Delete From [Statement] WHERE ID =@ID"
Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
Cmd = New OleDb.OleDbCommand(Str,Con)
Con.Open()
Cmd.Parameters.AddWithValue("@ID", ID)
          If Cmd.ExecuteNonQuery>=0 Then
          Else
              Msgbox("Element not Deleted")
          End If
 Catch ex As Exception 
 Finally 
   Close(True) 
 End Try 

   End Sub
#End Region '(Set|Get) This will Delete a row in the table.

#End Region 
#Region "<5> [Function]{7}"
#Region"[On] |2019/07/06 00h51:363| <05.00.00> <Function> <> |.Open()|TestItem}|"' (Set|Get) This will initialise the connection and import the data.
    '''    <Summary>
'''     (Set|Get) This will initialise the connection and import the data.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:042 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) This will initialise the connection and import the data.") >
   Public Function Open(ByVal SqlCommand As String) As TestItem
 Dim Result As New TestItem("Open(SqlCommand)", " Openning the connection line to the database.")
 If CheckConnection()=True Then
                     Con = New OleDb.OleDbConnection(Me.Line)
                     Cmd = New OleDb.OleDbCommand(SqlCommand,Con)
                         If Con.State = ConnectionState.Open Then
                             Close(True)
                         Else
                             Try
                                 Con.Open()
                                 Result.Status = Status.Online
                             Catch ex As Exception
                                 Result.AddBug(ex,"Error while opening database","SqlCon.Open()")
                                 Result.Why+= ex.Message & vbNewLine
                                 Result.Status = Status.Broken
                             End Try
                         End If
     Else
         Result.Status = Status.Broken
         Result.Why += Log & VbNewLine 
     End If
 Return Result

   End Function
#End Region '(Set|Get) This will initialise the connection and import the data.

#Region"[On] |2019/07/06 00h51:377| <05.00.01> <Function> <> |.Close()|TestItem}|"' (Set|Get) This willClosing the connection
    '''    <Summary>
'''     (Set|Get) This willClosing the connection
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:042 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) This willClosing the connection") >
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
                                 Result.Why +="The connection will not close." & vbNewLine
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
                                 Result.Why +="The connection will not close." & vbNewLine
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
                                 Result.Why +="The connection will not close." & vbNewLine
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
                                 Result.Why +="The connection will not close." & vbNewLine
                             End If
                     End If
             End If
         End If
 Return Result

   End Function
#End Region '(Set|Get) This willClosing the connection

#Region"[On] |2019/07/06 00h51:394| <05.00.02> <Function> <> |.List()|List(Of Statement)}|"' (Set|Get) Return the entire table listed
    '''    <Summary>
'''     (Set|Get) Return the entire table listed
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:042 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) Return the entire table listed") >
   Public Function List() As List(Of Statement)
Dim Result As New List(Of Statement)
Me.Table = New Table(Me.TableName , Me.FilePath , Me.Password,False)
   For each Row As DataRow In Me.Table.DataTable.Rows
      Dim Element As New Statement(IIf(IsDBNull(Row.Item(0)),0,Row.Item(0)),
IIf(IsDBNull(Row.Item(1)),"",Row.Item(1)),
IIf(IsDBNull(Row.Item(2)),0,Row.Item(2)),
IIf(IsDBNull(Row.Item(3)),"",Row.Item(3)),
IIf(IsDBNull(Row.Item(4)),"",Row.Item(4)),
IIf(IsDBNull(Row.Item(5)),False,Row.Item(5)),
IIf(IsDBNull(Row.Item(6)),"",Row.Item(6)),
IIf(IsDBNull(Row.Item(7)),"",Row.Item(7)),
IIf(IsDBNull(Row.Item(8)),"",Row.Item(8)),
IIf(IsDBNull(Row.Item(9)),"",Row.Item(9)),
IIf(IsDBNull(Row.Item(10)),False,Row.Item(10)),
IIf(IsDBNull(Row.Item(11)),"",Row.Item(11)),
IIf(IsDBNull(Row.Item(12)),"",Row.Item(12)),
IIf(IsDBNull(Row.Item(13)),"",Row.Item(13)),
IIf(IsDBNull(Row.Item(14)),"",Row.Item(14)),
IIf(IsDBNull(Row.Item(15)),"",Row.Item(15)),
IIf(IsDBNull(Row.Item(16)),False,Row.Item(16)),
IIf(IsDBNull(Row.Item(17)),False,Row.Item(17)),
IIf(IsDBNull(Row.Item(18)),False,Row.Item(18)),
IIf(IsDBNull(Row.Item(19)),"",Row.Item(19)),
IIf(IsDBNull(Row.Item(20)),False,Row.Item(20)),
IIf(IsDBNull(Row.Item(21)),False,Row.Item(21)),
IIf(IsDBNull(Row.Item(22)),"",Row.Item(22)),
IIf(IsDBNull(Row.Item(23)),"",Row.Item(23)),
IIf(IsDBNull(Row.Item(24)),"",Row.Item(24)),
IIf(IsDBNull(Row.Item(25)),"",Row.Item(25)),
IIf(IsDBNull(Row.Item(26)),"",Row.Item(26)),
IIf(IsDBNull(Row.Item(27)),"",Row.Item(27)),
IIf(IsDBNull(Row.Item(28)),"",Row.Item(28)),
IIf(IsDBNull(Row.Item(29)),"",Row.Item(29)),
IIf(IsDBNull(Row.Item(30)),"",Row.Item(30)),
IIf(IsDBNull(Row.Item(31)),"",Row.Item(31)),
IIf(IsDBNull(Row.Item(32)),"",Row.Item(32)),
IIf(IsDBNull(Row.Item(33)),0,Row.Item(33)),
IIf(IsDBNull(Row.Item(34)),"",Row.Item(34)),
IIf(IsDBNull(Row.Item(35)),"",Row.Item(35)),
IIf(IsDBNull(Row.Item(36)),"",Row.Item(36)),
IIf(IsDBNull(Row.Item(37)),"",Row.Item(37)),
IIf(IsDBNull(Row.Item(38)),"",Row.Item(38)),
IIf(IsDBNull(Row.Item(39)),"",Row.Item(39)),
IIf(IsDBNull(Row.Item(40)),"",Row.Item(40)),
IIf(IsDBNull(Row.Item(41)),"",Row.Item(41)),
IIf(IsDBNull(Row.Item(42)),"",Row.Item(42)),
IIf(IsDBNull(Row.Item(43)),"",Row.Item(43)),
IIf(IsDBNull(Row.Item(44)),"",Row.Item(44)),
IIf(IsDBNull(Row.Item(45)),"",Row.Item(45)),
IIf(IsDBNull(Row.Item(46)),"",Row.Item(46)),
IIf(IsDBNull(Row.Item(47)),"",Row.Item(47)),
IIf(IsDBNull(Row.Item(48)),"",Row.Item(48)),
IIf(IsDBNull(Row.Item(49)),"",Row.Item(49)),
IIf(IsDBNull(Row.Item(50)),"",Row.Item(50)),
IIf(IsDBNull(Row.Item(51)),"",Row.Item(51)),
IIf(IsDBNull(Row.Item(52)),"",Row.Item(52)),
IIf(IsDBNull(Row.Item(53)),"",Row.Item(53)),
IIf(IsDBNull(Row.Item(54)),"",Row.Item(54)),
      IIf(IsDBNull(Row.Item(55)),"",Row.Item(55)))
      Element.Reset(Table.Line)
 Result.Add(Element)
 Next
 Return Result
   End Function
#End Region '(Set|Get) Return the entire table listed

#Region"[On] |2019/07/06 00h51:414| <05.00.03> <Function> <> |.SearchByName()|List(Of Statement)}|"' (Set|Get) Search for each property that match the Search String.
    '''    <Summary>
'''     (Set|Get) Search for each property that match the Search String.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:042 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) Search for each property that match the Search String.") >
   Public Shared Function SearchByName(ByVal Search As String) As List(Of Statement)
Dim Result As New List(Of Statement)
 Dim C As New Statement
 For Each Element As Statement In C.List
 If Element.Name.Tolower() = Search.Tolower() Or Element.Text.Tolower() = Search.Tolower()  Or Element.ToolTip.Tolower() = Search.Tolower()  Or Element.Status.Tolower() = Search.Tolower()  Or Element.Statement.Tolower() = Search.Tolower()  Or Element.XMLFile.Tolower() = Search.Tolower()  Or Element.Attributes.Tolower() = Search.Tolower()  Or Element.Category.Tolower() = Search.Tolower()  Or Element.Description.Tolower() = Search.Tolower()  Or Element.DefaultValue.Tolower() = Search.Tolower()  Or Element.Editor.Tolower() = Search.Tolower()  Or Element.DllImport.Tolower() = Search.Tolower()  Or Element.XmlRoot.Tolower() = Search.Tolower()  Or Element.RelatedImageList.Tolower() = Search.Tolower()  Or Element.Print_VB.Tolower() = Search.Tolower()  Or Element.VB.Tolower() = Search.Tolower()  Or Element.Print_C.Tolower() = Search.Tolower()  Or Element.C.Tolower() = Search.Tolower()  Or Element.Print_F.Tolower() = Search.Tolower()  Or Element.F.Tolower() = Search.Tolower()  Or Element.Print_Python.Tolower() = Search.Tolower()  Or Element.Python.Tolower() = Search.Tolower()  Or Element.Print_JavaScript.Tolower() = Search.Tolower()  Or Element.JavaScript.Tolower() = Search.Tolower()  Or Element.RegionCode.Tolower() = Search.Tolower()  Or Element.AuthorEmail.Tolower() = Search.Tolower()  Or Element.AuthorName.Tolower() = Search.Tolower()  Or Element.AuthorUri.Tolower() = Search.Tolower()  Or Element.ContributorEmail.Tolower() = Search.Tolower()  Or Element.ContributorName.Tolower() = Search.Tolower()  Or Element.ContributorUri.Tolower() = Search.Tolower()  Or Element.CustomProperty.Tolower() = Search.Tolower()  Or Element.Published.Tolower() = Search.Tolower()  Or Element.Rights.Tolower() = Search.Tolower()  Or Element.Summary.Tolower() = Search.Tolower()  Or Element.Title.Tolower() = Search.Tolower()  Or Element.Updated.Tolower() = Search.Tolower()  Or Element.Usage.Tolower() = Search.Tolower()  Or Element.Remarks.Tolower() = Search.Tolower()  Or Element.Example.Tolower() = Search.Tolower()  Or Element.Note.Tolower() = Search.Tolower()  Or Element.CreationDate.Tolower() = Search.Tolower()  Or Element.See.Tolower() = Search.Tolower()  Or Element.SeeAlso.Tolower() = Search.Tolower()  Or Element.Rules.Tolower() = Search.Tolower()  Or Element.Syntax.Tolower() = Search.Tolower() Then
      Result.Add(Element)
 End If
 Next
 Return Result
   End Function
#End Region '(Set|Get) Search for each property that match the Search String.

#Region"[On] |2019/07/06 00h51:429| <05.00.04> <Function> <> |.SearchByID()|List(Of Statement)}|"' (Set|Get) Search for each property that match the Search Id.
    '''    <Summary>
'''     (Set|Get) Search for each property that match the Search Id.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:042 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) Search for each property that match the Search Id.") >
   Public Shared Function SearchByID(ByVal Search As Double) As List(Of Statement)
Dim Result As New List(Of Statement)
 Dim C As New Statement
 For Each Element As Statement In C.List
 If Val(Element.ID) = Search Or Val(Element.ImageIndex) = Search  Or Val(Element.RegionCategory) = Search Then
      Result.Add(Element)
 End If
 Next
 Return Result
   End Function
#End Region '(Set|Get) Search for each property that match the Search Id.

#Region"[On] |2019/07/06 00h51:446| <05.00.05> <Function> <> |.ToString()|String}|"' (Set|Get) The function ToString.
    '''    <Summary>
'''     (Set|Get) The function ToString.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:043 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The function ToString.") >
   Public Overrides Function ToString() As String
    Return Me.ID
   End Function
#End Region '(Set|Get) The function ToString.

#Region"[On] |2019/07/06 00h51:465| <05.00.06> <Function> <> |.CheckConnection()|Boolean}|"' (Set|Get) Evaluate the connection to the DataBase
    '''    <Summary>
'''     (Set|Get) Evaluate the connection to the DataBase
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:043 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) Evaluate the connection to the DataBase") >
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
    Dim Message As String = Nothing' Stores the process logic.
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
        If D.IsReady  Then
            Test_4 = True
        Message += "Test 4 <Result> |OK| The Drive is Online."
        Else
            Test_4 = False
        Message += "Test 4 <Result> |PB| The Drive is Offline or Disconnected."
        End If
 #End Region 
 #Region "Test 5 | Evaluate if there is a Password."
        If Not IsDbNull(Password) Then
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
                    Me.Connector = New LineInfo(FilePath,Password)
                    Me.Line = Me.Connector.Line
        Message += "Test 6 <Result> |Initialize Connector|"
                End If
        End If
 #End Region 
 #Region "Test 7 | Evaluate if Connector Line is not empty."
        If Not IsDbNull(Me.Connector.Line) Then
            Test_7 = True
        Else 
            Test_7 = False
        End If
 #End Region 
 #Region "Test 8 | Evaluate if the Connection is valid."
        If Test_7 =True Then
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
 If Test_7=True And Test_8 = True Then
    General_Status=True
 Else 
    General_Status=False
 End If
 Log+=Message & VbNewLine
 Return General_Status

   End Function
#End Region '(Set|Get) Evaluate the connection to the DataBase

#End Region 
#Region "<6> [Runtime]{12}"
#Region"[On] |2019/07/06 00h51:482| <15.00.00> <Runtime> <> |.Table()|Table"' (Set|Get) The Table.
    '''    <Summary>
'''     (Set|Get) The Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:043 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The Table.") >
   Public  Table As Table
#End Region '(Set|Get) The Table.

#Region"[On] |2019/07/06 00h51:496| <15.00.01> <Runtime> <> |.Line()|String"' (Set|Get) The Connection String To the Table.
    '''    <Summary>
'''     (Set|Get) The Connection String To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:043 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The Connection String To the Table.") >
   Public  Line As String
#End Region '(Set|Get) The Connection String To the Table.

#Region"[On] |2019/07/06 00h51:510| <15.00.02> <Runtime> <> |.FilePath()|String"' (Set|Get) The FilePath To the Table.
    '''    <Summary>
'''     (Set|Get) The FilePath To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:043 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The FilePath To the Table.") >
   Public  FilePath As String
#End Region '(Set|Get) The FilePath To the Table.

#Region"[On] |2019/07/06 00h51:524| <15.00.03> <Runtime> <> |.Password()|String"' (Set|Get) The Password To the Table.
    '''    <Summary>
'''     (Set|Get) The Password To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:043 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The Password To the Table.") >
   Public  Password As String
#End Region '(Set|Get) The Password To the Table.

#Region"[On] |2019/07/06 00h51:539| <15.00.04> <Runtime> <> |.UseSQL()|Boolean"' (Set|Get) Determines if the Database Connection is of type SQL.
    '''    <Summary>
'''     (Set|Get) Determines if the Database Connection is of type SQL.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:044 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) Determines if the Database Connection is of type SQL.") >
   Public  UseSQL As Boolean
#End Region '(Set|Get) Determines if the Database Connection is of type SQL.

#Region"[On] |2019/07/06 00h51:553| <15.00.05> <Runtime> <> |.TableName()|String"' (Set|Get) The name of the Table.
    '''    <Summary>
'''     (Set|Get) The name of the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:044 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The name of the Table.") >
   Public  TableName As String
#End Region '(Set|Get) The name of the Table.

#Region"[On] |2019/07/06 00h51:567| <15.00.06> <Runtime> <> |.Con()|OleDb.OleDbConnection"' (Set|Get) The Con To the Table.
    '''    <Summary>
'''     (Set|Get) The Con To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:044 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The Con To the Table.") >
   Public  Con As OleDb.OleDbConnection
#End Region '(Set|Get) The Con To the Table.

#Region"[On] |2019/07/06 00h51:583| <15.00.07> <Runtime> <> |.Cmd()|OleDb.OleDbCommand"' (Set|Get) The Cmd To the Table.
    '''    <Summary>
'''     (Set|Get) The Cmd To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:044 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The Cmd To the Table.") >
   Public  Cmd As OleDb.OleDbCommand
#End Region '(Set|Get) The Cmd To the Table.

#Region"[On] |2019/07/06 00h51:598| <15.00.08> <Runtime> <> |.DataReader()|OleDb.OleDbDataReader"' (Set|Get) The DataReader To the Table.
    '''    <Summary>
'''     (Set|Get) The DataReader To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:044 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The DataReader To the Table.") >
   Public  DataReader As OleDb.OleDbDataReader
#End Region '(Set|Get) The DataReader To the Table.

#Region"[On] |2019/07/06 00h51:612| <15.00.09> <Runtime> <> |.DataAdapter()|OleDb.OleDbDataAdapter"' (Set|Get) The DataAdapter To the Table.
    '''    <Summary>
'''     (Set|Get) The DataAdapter To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:045 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The DataAdapter To the Table.") >
   Public  DataAdapter As OleDb.OleDbDataAdapter
#End Region '(Set|Get) The DataAdapter To the Table.

#Region"[On] |2019/07/06 00h51:627| <15.00.10> <Runtime> <> |.Connector()|LineInfo"' (Set|Get) The Connector To the Table.
    '''    <Summary>
'''     (Set|Get) The Connector To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:045 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The Connector To the Table.") >
   Public  Connector As LineInfo
#End Region '(Set|Get) The Connector To the Table.

#Region"[On] |2019/07/06 00h51:641| <15.00.11> <Runtime> <> |.Log()|String"' (Set|Get) The Log To the Table.
    '''    <Summary>
'''     (Set|Get) The Log To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:045 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The Log To the Table.") >
   Public  Log As String
#End Region '(Set|Get) The Log To the Table.

#End Region 
#Region "<7> [Loader]{2}"
#Region"[On] |2019/07/06 00h51:655| <06.00.00> <Loader> <> |.Empty()|Function}|"' (Set|Get) The sub Empty.
    '''    <Summary>
'''     (Set|Get) The sub Empty.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:045 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The sub Empty.") >
   Public Sub New ()
Reset
   End Sub
#End Region '(Set|Get) The sub Empty.

#Region"[On] |2019/07/06 00h51:658| <06.00.01> <Loader> <> |.Filled()|Function}|"' (Set|Get) The sub Filled.
    '''    <Summary>
'''     (Set|Get) The sub Filled.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:046 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>    ''' <param name="ID">(Set|Get) The ID as Integer.</param>
    ''' <param name="Name">(Set|Get) The Name as String.</param>
    ''' <param name="ImageIndex">(Set|Get) The ImageIndex as Integer.</param>
    ''' <param name="Text">(Set|Get) The Text as String.</param>
    ''' <param name="ToolTip">(Set|Get) The ToolTip as String.</param>
    ''' <param name="Enable">(Set|Get) The Enable as Boolean.</param>
    ''' <param name="Status">(Set|Get) The Status as String.</param>
    ''' <param name="Statement">(Set|Get) The Statement as String.</param>
    ''' <param name="XMLFile">(Set|Get) The XMLFile as String.</param>
    ''' <param name="Attributes">(Set|Get) The Attributes as String.</param>
    ''' <param name="Browsable">(Set|Get) The Browsable as Boolean.</param>
    ''' <param name="Category">(Set|Get) The Category as String.</param>
    ''' <param name="Description">(Set|Get) The Description as String.</param>
    ''' <param name="DefaultValue">(Set|Get) The DefaultValue as String.</param>
    ''' <param name="Editor">(Set|Get) The Editor as String.</param>
    ''' <param name="DllImport">(Set|Get) The DllImport as String.</param>
    ''' <param name="Deserializable">(Set|Get) The Deserializable as Boolean.</param>
    ''' <param name="NonSerialized">(Set|Get) The NonSerialized as Boolean.</param>
    ''' <param name="Serializable">(Set|Get) The Serializable as Boolean.</param>
    ''' <param name="XmlRoot">(Set|Get) The XmlRoot as String.</param>
    ''' <param name="XmlIgnore">(Set|Get) The XmlIgnore as Boolean.</param>
    ''' <param name="XmlInclude">(Set|Get) The XmlInclude as Boolean.</param>
    ''' <param name="RelatedImageList">(Set|Get) The RelatedImageList as String.</param>
    ''' <param name="Print_VB">(Set|Get) The Print_VB as String.</param>
    ''' <param name="VB">(Set|Get) The VB as String.</param>
    ''' <param name="Print_C">(Set|Get) The Print_C as String.</param>
    ''' <param name="C">(Set|Get) The C as String.</param>
    ''' <param name="Print_F">(Set|Get) The Print_F as String.</param>
    ''' <param name="F">(Set|Get) The F as String.</param>
    ''' <param name="Print_Python">(Set|Get) The Print_Python as String.</param>
    ''' <param name="Python">(Set|Get) The Python as String.</param>
    ''' <param name="Print_JavaScript">(Set|Get) The Print_JavaScript as String.</param>
    ''' <param name="JavaScript">(Set|Get) The JavaScript as String.</param>
    ''' <param name="RegionCategory">(Set|Get) The RegionCategory as Integer.</param>
    ''' <param name="RegionCode">(Set|Get) The RegionCode as String.</param>
    ''' <param name="AuthorEmail">(Set|Get) The AuthorEmail as String.</param>
    ''' <param name="AuthorName">(Set|Get) The AuthorName as String.</param>
    ''' <param name="AuthorUri">(Set|Get) The AuthorUri as String.</param>
    ''' <param name="ContributorEmail">(Set|Get) The ContributorEmail as String.</param>
    ''' <param name="ContributorName">(Set|Get) The ContributorName as String.</param>
    ''' <param name="ContributorUri">(Set|Get) The ContributorUri as String.</param>
    ''' <param name="CustomProperty">(Set|Get) The CustomProperty as String.</param>
    ''' <param name="Published">(Set|Get) The Published as String.</param>
    ''' <param name="Rights">(Set|Get) The Rights as String.</param>
    ''' <param name="Summary">(Set|Get) The Summary as String.</param>
    ''' <param name="Title">(Set|Get) The Title as String.</param>
    ''' <param name="Updated">(Set|Get) The Updated as String.</param>
    ''' <param name="Usage">(Set|Get) The Usage as String.</param>
    ''' <param name="Remarks">(Set|Get) The Remarks as String.</param>
    ''' <param name="Example">(Set|Get) The Example as String.</param>
    ''' <param name="Note">(Set|Get) The Note as String.</param>
    ''' <param name="CreationDate">(Set|Get) The CreationDate as String.</param>
    ''' <param name="See">(Set|Get) The See as String.</param>
    ''' <param name="SeeAlso">(Set|Get) The SeeAlso as String.</param>
    ''' <param name="Rules">(Set|Get) The Rules as String.</param>
    ''' <param name="Syntax">(Set|Get) The Syntax as String.</param>

    <Browsable(True) , Description("(Set|Get) The sub Filled.") >
   Public Sub New (ByVal ID As Integer, 
ByVal Name As String, 
ByVal ImageIndex As Integer, 
ByVal Text As String, 
ByVal ToolTip As String, 
ByVal Enable As Boolean, 
ByVal Status As String, 
ByVal Statement As String, 
ByVal XMLFile As String, 
ByVal Attributes As String, 
ByVal Browsable As Boolean, 
ByVal Category As String, 
ByVal Description As String, 
ByVal DefaultValue As String, 
ByVal Editor As String, 
ByVal DllImport As String, 
ByVal Deserializable As Boolean, 
ByVal NonSerialized As Boolean, 
ByVal Serializable As Boolean, 
ByVal XmlRoot As String, 
ByVal XmlIgnore As Boolean, 
ByVal XmlInclude As Boolean, 
ByVal RelatedImageList As String, 
ByVal Print_VB As String, 
ByVal VB As String, 
ByVal Print_C As String, 
ByVal C As String, 
ByVal Print_F As String, 
ByVal F As String, 
ByVal Print_Python As String, 
ByVal Python As String, 
ByVal Print_JavaScript As String, 
ByVal JavaScript As String, 
ByVal RegionCategory As Integer, 
ByVal RegionCode As String, 
ByVal AuthorEmail As String, 
ByVal AuthorName As String, 
ByVal AuthorUri As String, 
ByVal ContributorEmail As String, 
ByVal ContributorName As String, 
ByVal ContributorUri As String, 
ByVal CustomProperty As String, 
ByVal Published As String, 
ByVal Rights As String, 
ByVal Summary As String, 
ByVal Title As String, 
ByVal Updated As String, 
ByVal Usage As String, 
ByVal Remarks As String, 
ByVal Example As String, 
ByVal Note As String, 
ByVal CreationDate As String, 
ByVal See As String, 
ByVal SeeAlso As String, 
ByVal Rules As String, 
ByVal Syntax As String)
 With Me
 Clear()
 Reset()
     .ID = ID
     .Name = Name
     .ImageIndex = ImageIndex
     .Text = Text
     .ToolTip = ToolTip
     .Enable = Enable
     .Status = Status
     .Statement = Statement
     .XMLFile = XMLFile
     .Attributes = Attributes
     .Browsable = Browsable
     .Category = Category
     .Description = Description
     .DefaultValue = DefaultValue
     .Editor = Editor
     .DllImport = DllImport
     .Deserializable = Deserializable
     .NonSerialized = NonSerialized
     .Serializable = Serializable
     .XmlRoot = XmlRoot
     .XmlIgnore = XmlIgnore
     .XmlInclude = XmlInclude
     .RelatedImageList = RelatedImageList
     .Print_VB = Print_VB
     .VB = VB
     .Print_C = Print_C
     .C = C
     .Print_F = Print_F
     .F = F
     .Print_Python = Print_Python
     .Python = Python
     .Print_JavaScript = Print_JavaScript
     .JavaScript = JavaScript
     .RegionCategory = RegionCategory
     .RegionCode = RegionCode
     .AuthorEmail = AuthorEmail
     .AuthorName = AuthorName
     .AuthorUri = AuthorUri
     .ContributorEmail = ContributorEmail
     .ContributorName = ContributorName
     .ContributorUri = ContributorUri
     .CustomProperty = CustomProperty
     .Published = Published
     .Rights = Rights
     .Summary = Summary
     .Title = Title
     .Updated = Updated
     .Usage = Usage
     .Remarks = Remarks
     .Example = Example
     .Note = Note
     .CreationDate = CreationDate
     .See = See
     .SeeAlso = SeeAlso
     .Rules = Rules
     .Syntax = Syntax
 End With

   End Sub
#End Region '(Set|Get) The sub Filled.

#End Region 
 End Class
#End Region

#Region"[On] |2019/07/06 00h51:877| <08.00.00> <Class> <> |.Structure|Class|{89} |Production Cost : 138.1|Selling Price : 345.25|"' Class created automatically by SmartOffice (c)Copyright 2019.
'''    <Summary>
'''     Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Structure
'''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
'''    Contributor Information : ||
'''    Creation Date :           2019/07/06 00h51:877
'''    |Schema|
'''    |ID| |ObjectType |{Quantity}||UnitPrice||Total
'''    |00| |Importation|{0}||1| |0
'''    |01| |Properties |{62}||0.8| |49.6
'''    |02| |Enumeration|{1}||0.4| |0.4
'''    |03| |Structure  |{0}||0.4| |0
'''    |04| |Sub        |{5}||1.2| |6
'''    |05| |Function   |{7}||1.6| |11.2
'''    |06| |Runtime    |{12}||0.4| |4.8
'''    |07| |Loader     |{2}||0.8| |1.6
'''    |08| |Class      |{0}||2| |0
'''    |09| |Constante  |{0}||0.4| |0
'''    |10| |Event      |{0}||1.2| |0
'''    |11| |Members    |{62}||0.5| |31
'''    |12| |Parameter  |{67}||0.5| |33.5
'''    |Production Cost             |138.1
'''    |Selling Price without VAT   |345.25
'''    |Total TVA                   |26.58
'''    |Grand Total                 |371.83
'''    |/Schema|
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:077 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
Public  Class Structure
#Region "<1> [Property]{62}"
#Region"[On] |2019/07/06 00h51:878| <01.00.00> <Property> <Columns> |.ID()|Integer|"' (Set|Get) The ID as Integer.
   Private _ID As Integer
    '''    <Summary>
'''     (Set|Get) The ID as Integer.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:077 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ID as Integer.") >
   Public Property ID()As Integer
       Get
       Return _ID
       End Get
       Set(ByVal Value As Integer)
       _ID = Value
       End Set
   End Property
#End Region '(Set|Get) The ID as Integer.

#Region"[On] |2019/07/06 00h51:889| <01.00.01> <Property> <Columns> |.Name()|String|"' (Set|Get) The Name as String.
   Private _Name As String
    '''    <Summary>
'''     (Set|Get) The Name as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:077 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Name as String.") >
   Public Property Name()As String
       Get
       Return _Name
       End Get
       Set(ByVal Value As String)
       _Name = Value
       End Set
   End Property
#End Region '(Set|Get) The Name as String.

#Region"[On] |2019/07/06 00h51:900| <01.00.02> <Property> <Columns> |.ImageIndex()|Integer|"' (Set|Get) The ImageIndex as Integer.
   Private _ImageIndex As Integer
    '''    <Summary>
'''     (Set|Get) The ImageIndex as Integer.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:077 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ImageIndex as Integer.") >
   Public Property ImageIndex()As Integer
       Get
       Return _ImageIndex
       End Get
       Set(ByVal Value As Integer)
       _ImageIndex = Value
       End Set
   End Property
#End Region '(Set|Get) The ImageIndex as Integer.

#Region"[On] |2019/07/06 00h51:911| <01.00.03> <Property> <Columns> |.Text()|String|"' (Set|Get) The Text as String.
   Private _Text As String
    '''    <Summary>
'''     (Set|Get) The Text as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:078 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Text as String.") >
   Public Property Text()As String
       Get
       Return _Text
       End Get
       Set(ByVal Value As String)
       _Text = Value
       End Set
   End Property
#End Region '(Set|Get) The Text as String.

#Region"[On] |2019/07/06 00h51:922| <01.00.04> <Property> <Columns> |.ToolTip()|String|"' (Set|Get) The ToolTip as String.
   Private _ToolTip As String
    '''    <Summary>
'''     (Set|Get) The ToolTip as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:078 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ToolTip as String.") >
   Public Property ToolTip()As String
       Get
       Return _ToolTip
       End Get
       Set(ByVal Value As String)
       _ToolTip = Value
       End Set
   End Property
#End Region '(Set|Get) The ToolTip as String.

#Region"[On] |2019/07/06 00h51:932| <01.00.05> <Property> <Columns> |.Enable()|Boolean|"' (Set|Get) The Enable as Boolean.
   Private _Enable As Boolean
    '''    <Summary>
'''     (Set|Get) The Enable as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:078 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Enable as Boolean.") >
   Public Property Enable()As Boolean
       Get
       Return _Enable
       End Get
       Set(ByVal Value As Boolean)
       _Enable = Value
       End Set
   End Property
#End Region '(Set|Get) The Enable as Boolean.

#Region"[On] |2019/07/06 00h51:943| <01.00.06> <Property> <Columns> |.Status()|String|"' (Set|Get) The Status as String.
   Private _Status As String
    '''    <Summary>
'''     (Set|Get) The Status as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:078 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Status as String.") >
   Public Property Status()As String
       Get
       Return _Status
       End Get
       Set(ByVal Value As String)
       _Status = Value
       End Set
   End Property
#End Region '(Set|Get) The Status as String.

#Region"[On] |2019/07/06 00h51:959| <01.00.07> <Property> <Columns> |.Statement()|String|"' (Set|Get) The Statement as String.
   Private _Statement As String
    '''    <Summary>
'''     (Set|Get) The Statement as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:078 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Statement as String.") >
   Public Property Statement()As String
       Get
       Return _Statement
       End Get
       Set(ByVal Value As String)
       _Statement = Value
       End Set
   End Property
#End Region '(Set|Get) The Statement as String.

#Region"[On] |2019/07/06 00h51:970| <01.00.08> <Property> <Columns> |.XMLFile()|String|"' (Set|Get) The XMLFile as String.
   Private _XMLFile As String
    '''    <Summary>
'''     (Set|Get) The XMLFile as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:079 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XMLFile as String.") >
   Public Property XMLFile()As String
       Get
       Return _XMLFile
       End Get
       Set(ByVal Value As String)
       _XMLFile = Value
       End Set
   End Property
#End Region '(Set|Get) The XMLFile as String.

#Region"[On] |2019/07/06 00h51:980| <01.00.09> <Property> <Columns> |.Attributes()|String|"' (Set|Get) The Attributes as String.
   Private _Attributes As String
    '''    <Summary>
'''     (Set|Get) The Attributes as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:079 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Attributes as String.") >
   Public Property Attributes()As String
       Get
       Return _Attributes
       End Get
       Set(ByVal Value As String)
       _Attributes = Value
       End Set
   End Property
#End Region '(Set|Get) The Attributes as String.

#Region"[On] |2019/07/06 00h51:992| <01.00.10> <Property> <Columns> |.Browsable()|Boolean|"' (Set|Get) The Browsable as Boolean.
   Private _Browsable As Boolean
    '''    <Summary>
'''     (Set|Get) The Browsable as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:079 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Browsable as Boolean.") >
   Public Property Browsable()As Boolean
       Get
       Return _Browsable
       End Get
       Set(ByVal Value As Boolean)
       _Browsable = Value
       End Set
   End Property
#End Region '(Set|Get) The Browsable as Boolean.

#Region"[On] |2019/07/06 00h51:002| <01.00.11> <Property> <Columns> |.Category()|String|"' (Set|Get) The Category as String.
   Private _Category As String
    '''    <Summary>
'''     (Set|Get) The Category as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:079 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Category as String.") >
   Public Property Category()As String
       Get
       Return _Category
       End Get
       Set(ByVal Value As String)
       _Category = Value
       End Set
   End Property
#End Region '(Set|Get) The Category as String.

#Region"[On] |2019/07/06 00h51:013| <01.00.12> <Property> <Columns> |.Description()|String|"' (Set|Get) The Description as String.
   Private _Description As String
    '''    <Summary>
'''     (Set|Get) The Description as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:079 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Description as String.") >
   Public Property Description()As String
       Get
       Return _Description
       End Get
       Set(ByVal Value As String)
       _Description = Value
       End Set
   End Property
#End Region '(Set|Get) The Description as String.

#Region"[On] |2019/07/06 00h51:024| <01.00.13> <Property> <Columns> |.DefaultValue()|String|"' (Set|Get) The DefaultValue as String.
   Private _DefaultValue As String
    '''    <Summary>
'''     (Set|Get) The DefaultValue as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:080 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The DefaultValue as String.") >
   Public Property DefaultValue()As String
       Get
       Return _DefaultValue
       End Get
       Set(ByVal Value As String)
       _DefaultValue = Value
       End Set
   End Property
#End Region '(Set|Get) The DefaultValue as String.

#Region"[On] |2019/07/06 00h51:035| <01.00.14> <Property> <Columns> |.Editor()|String|"' (Set|Get) The Editor as String.
   Private _Editor As String
    '''    <Summary>
'''     (Set|Get) The Editor as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:081 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Editor as String.") >
   Public Property Editor()As String
       Get
       Return _Editor
       End Get
       Set(ByVal Value As String)
       _Editor = Value
       End Set
   End Property
#End Region '(Set|Get) The Editor as String.

#Region"[On] |2019/07/06 00h51:047| <01.00.15> <Property> <Columns> |.DllImport()|String|"' (Set|Get) The DllImport as String.
   Private _DllImport As String
    '''    <Summary>
'''     (Set|Get) The DllImport as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:081 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The DllImport as String.") >
   Public Property DllImport()As String
       Get
       Return _DllImport
       End Get
       Set(ByVal Value As String)
       _DllImport = Value
       End Set
   End Property
#End Region '(Set|Get) The DllImport as String.

#Region"[On] |2019/07/06 00h51:058| <01.00.16> <Property> <Columns> |.Deserializable()|Boolean|"' (Set|Get) The Deserializable as Boolean.
   Private _Deserializable As Boolean
    '''    <Summary>
'''     (Set|Get) The Deserializable as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:081 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Deserializable as Boolean.") >
   Public Property Deserializable()As Boolean
       Get
       Return _Deserializable
       End Get
       Set(ByVal Value As Boolean)
       _Deserializable = Value
       End Set
   End Property
#End Region '(Set|Get) The Deserializable as Boolean.

#Region"[On] |2019/07/06 00h51:069| <01.00.17> <Property> <Columns> |.NonSerialized()|Boolean|"' (Set|Get) The NonSerialized as Boolean.
   Private _NonSerialized As Boolean
    '''    <Summary>
'''     (Set|Get) The NonSerialized as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:081 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The NonSerialized as Boolean.") >
   Public Property NonSerialized()As Boolean
       Get
       Return _NonSerialized
       End Get
       Set(ByVal Value As Boolean)
       _NonSerialized = Value
       End Set
   End Property
#End Region '(Set|Get) The NonSerialized as Boolean.

#Region"[On] |2019/07/06 00h51:080| <01.00.18> <Property> <Columns> |.Serializable()|Boolean|"' (Set|Get) The Serializable as Boolean.
   Private _Serializable As Boolean
    '''    <Summary>
'''     (Set|Get) The Serializable as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:082 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Serializable as Boolean.") >
   Public Property Serializable()As Boolean
       Get
       Return _Serializable
       End Get
       Set(ByVal Value As Boolean)
       _Serializable = Value
       End Set
   End Property
#End Region '(Set|Get) The Serializable as Boolean.

#Region"[On] |2019/07/06 00h51:091| <01.00.19> <Property> <Columns> |.XmlRoot()|String|"' (Set|Get) The XmlRoot as String.
   Private _XmlRoot As String
    '''    <Summary>
'''     (Set|Get) The XmlRoot as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:082 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XmlRoot as String.") >
   Public Property XmlRoot()As String
       Get
       Return _XmlRoot
       End Get
       Set(ByVal Value As String)
       _XmlRoot = Value
       End Set
   End Property
#End Region '(Set|Get) The XmlRoot as String.

#Region"[On] |2019/07/06 00h51:101| <01.00.20> <Property> <Columns> |.XmlIgnore()|Boolean|"' (Set|Get) The XmlIgnore as Boolean.
   Private _XmlIgnore As Boolean
    '''    <Summary>
'''     (Set|Get) The XmlIgnore as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:082 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XmlIgnore as Boolean.") >
   Public Property XmlIgnore()As Boolean
       Get
       Return _XmlIgnore
       End Get
       Set(ByVal Value As Boolean)
       _XmlIgnore = Value
       End Set
   End Property
#End Region '(Set|Get) The XmlIgnore as Boolean.

#Region"[On] |2019/07/06 00h51:113| <01.00.21> <Property> <Columns> |.XmlInclude()|Boolean|"' (Set|Get) The XmlInclude as Boolean.
   Private _XmlInclude As Boolean
    '''    <Summary>
'''     (Set|Get) The XmlInclude as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:082 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XmlInclude as Boolean.") >
   Public Property XmlInclude()As Boolean
       Get
       Return _XmlInclude
       End Get
       Set(ByVal Value As Boolean)
       _XmlInclude = Value
       End Set
   End Property
#End Region '(Set|Get) The XmlInclude as Boolean.

#Region"[On] |2019/07/06 00h51:124| <01.00.22> <Property> <Columns> |.RelatedImageList()|String|"' (Set|Get) The RelatedImageList as String.
   Private _RelatedImageList As String
    '''    <Summary>
'''     (Set|Get) The RelatedImageList as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:082 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The RelatedImageList as String.") >
   Public Property RelatedImageList()As String
       Get
       Return _RelatedImageList
       End Get
       Set(ByVal Value As String)
       _RelatedImageList = Value
       End Set
   End Property
#End Region '(Set|Get) The RelatedImageList as String.

#Region"[On] |2019/07/06 00h51:135| <01.00.23> <Property> <Columns> |.Print_VB()|String|"' (Set|Get) The Print_VB as String.
   Private _Print_VB As String
    '''    <Summary>
'''     (Set|Get) The Print_VB as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:083 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_VB as String.") >
   Public Property Print_VB()As String
       Get
       Return _Print_VB
       End Get
       Set(ByVal Value As String)
       _Print_VB = Value
       End Set
   End Property
#End Region '(Set|Get) The Print_VB as String.

#Region"[On] |2019/07/06 00h51:147| <01.00.24> <Property> <Columns> |.VB()|String|"' (Set|Get) The VB as String.
   Private _VB As String
    '''    <Summary>
'''     (Set|Get) The VB as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:083 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The VB as String.") >
   Public Property VB()As String
       Get
       Return _VB
       End Get
       Set(ByVal Value As String)
       _VB = Value
       End Set
   End Property
#End Region '(Set|Get) The VB as String.

#Region"[On] |2019/07/06 00h51:158| <01.00.25> <Property> <Columns> |.Print_C()|String|"' (Set|Get) The Print_C as String.
   Private _Print_C As String
    '''    <Summary>
'''     (Set|Get) The Print_C as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:083 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_C as String.") >
   Public Property Print_C()As String
       Get
       Return _Print_C
       End Get
       Set(ByVal Value As String)
       _Print_C = Value
       End Set
   End Property
#End Region '(Set|Get) The Print_C as String.

#Region"[On] |2019/07/06 00h51:173| <01.00.26> <Property> <Columns> |.C()|String|"' (Set|Get) The C as String.
   Private _C As String
    '''    <Summary>
'''     (Set|Get) The C as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:083 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The C as String.") >
   Public Property C()As String
       Get
       Return _C
       End Get
       Set(ByVal Value As String)
       _C = Value
       End Set
   End Property
#End Region '(Set|Get) The C as String.

#Region"[On] |2019/07/06 00h51:184| <01.00.27> <Property> <Columns> |.Print_F()|String|"' (Set|Get) The Print_F as String.
   Private _Print_F As String
    '''    <Summary>
'''     (Set|Get) The Print_F as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:083 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_F as String.") >
   Public Property Print_F()As String
       Get
       Return _Print_F
       End Get
       Set(ByVal Value As String)
       _Print_F = Value
       End Set
   End Property
#End Region '(Set|Get) The Print_F as String.

#Region"[On] |2019/07/06 00h51:202| <01.00.28> <Property> <Columns> |.F()|String|"' (Set|Get) The F as String.
   Private _F As String
    '''    <Summary>
'''     (Set|Get) The F as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:084 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The F as String.") >
   Public Property F()As String
       Get
       Return _F
       End Get
       Set(ByVal Value As String)
       _F = Value
       End Set
   End Property
#End Region '(Set|Get) The F as String.

#Region"[On] |2019/07/06 00h51:214| <01.00.29> <Property> <Columns> |.Print_Python()|String|"' (Set|Get) The Print_Python as String.
   Private _Print_Python As String
    '''    <Summary>
'''     (Set|Get) The Print_Python as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:084 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_Python as String.") >
   Public Property Print_Python()As String
       Get
       Return _Print_Python
       End Get
       Set(ByVal Value As String)
       _Print_Python = Value
       End Set
   End Property
#End Region '(Set|Get) The Print_Python as String.

#Region"[On] |2019/07/06 00h51:227| <01.00.30> <Property> <Columns> |.Python()|String|"' (Set|Get) The Python as String.
   Private _Python As String
    '''    <Summary>
'''     (Set|Get) The Python as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:084 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Python as String.") >
   Public Property Python()As String
       Get
       Return _Python
       End Get
       Set(ByVal Value As String)
       _Python = Value
       End Set
   End Property
#End Region '(Set|Get) The Python as String.

#Region"[On] |2019/07/06 00h51:239| <01.00.31> <Property> <Columns> |.Print_JavaScript()|String|"' (Set|Get) The Print_JavaScript as String.
   Private _Print_JavaScript As String
    '''    <Summary>
'''     (Set|Get) The Print_JavaScript as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:084 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_JavaScript as String.") >
   Public Property Print_JavaScript()As String
       Get
       Return _Print_JavaScript
       End Get
       Set(ByVal Value As String)
       _Print_JavaScript = Value
       End Set
   End Property
#End Region '(Set|Get) The Print_JavaScript as String.

#Region"[On] |2019/07/06 00h51:251| <01.00.32> <Property> <Columns> |.JavaScript()|String|"' (Set|Get) The JavaScript as String.
   Private _JavaScript As String
    '''    <Summary>
'''     (Set|Get) The JavaScript as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:084 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The JavaScript as String.") >
   Public Property JavaScript()As String
       Get
       Return _JavaScript
       End Get
       Set(ByVal Value As String)
       _JavaScript = Value
       End Set
   End Property
#End Region '(Set|Get) The JavaScript as String.

#Region"[On] |2019/07/06 00h51:264| <01.00.33> <Property> <Columns> |.RegionCategory()|Integer|"' (Set|Get) The RegionCategory as Integer.
   Private _RegionCategory As Integer
    '''    <Summary>
'''     (Set|Get) The RegionCategory as Integer.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:085 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The RegionCategory as Integer.") >
   Public Property RegionCategory()As Integer
       Get
       Return _RegionCategory
       End Get
       Set(ByVal Value As Integer)
       _RegionCategory = Value
       End Set
   End Property
#End Region '(Set|Get) The RegionCategory as Integer.

#Region"[On] |2019/07/06 00h51:276| <01.00.34> <Property> <Columns> |.RegionCode()|String|"' (Set|Get) The RegionCode as String.
   Private _RegionCode As String
    '''    <Summary>
'''     (Set|Get) The RegionCode as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:085 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The RegionCode as String.") >
   Public Property RegionCode()As String
       Get
       Return _RegionCode
       End Get
       Set(ByVal Value As String)
       _RegionCode = Value
       End Set
   End Property
#End Region '(Set|Get) The RegionCode as String.

#Region"[On] |2019/07/06 00h51:289| <01.00.35> <Property> <Columns> |.AuthorEmail()|String|"' (Set|Get) The AuthorEmail as String.
   Private _AuthorEmail As String
    '''    <Summary>
'''     (Set|Get) The AuthorEmail as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:085 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AuthorEmail as String.") >
   Public Property AuthorEmail()As String
       Get
       Return _AuthorEmail
       End Get
       Set(ByVal Value As String)
       _AuthorEmail = Value
       End Set
   End Property
#End Region '(Set|Get) The AuthorEmail as String.

#Region"[On] |2019/07/06 00h51:300| <01.00.36> <Property> <Columns> |.AuthorName()|String|"' (Set|Get) The AuthorName as String.
   Private _AuthorName As String
    '''    <Summary>
'''     (Set|Get) The AuthorName as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:085 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AuthorName as String.") >
   Public Property AuthorName()As String
       Get
       Return _AuthorName
       End Get
       Set(ByVal Value As String)
       _AuthorName = Value
       End Set
   End Property
#End Region '(Set|Get) The AuthorName as String.

#Region"[On] |2019/07/06 00h51:311| <01.00.37> <Property> <Columns> |.AuthorUri()|String|"' (Set|Get) The AuthorUri as String.
   Private _AuthorUri As String
    '''    <Summary>
'''     (Set|Get) The AuthorUri as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:085 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AuthorUri as String.") >
   Public Property AuthorUri()As String
       Get
       Return _AuthorUri
       End Get
       Set(ByVal Value As String)
       _AuthorUri = Value
       End Set
   End Property
#End Region '(Set|Get) The AuthorUri as String.

#Region"[On] |2019/07/06 00h51:322| <01.00.38> <Property> <Columns> |.ContributorEmail()|String|"' (Set|Get) The ContributorEmail as String.
   Private _ContributorEmail As String
    '''    <Summary>
'''     (Set|Get) The ContributorEmail as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:086 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ContributorEmail as String.") >
   Public Property ContributorEmail()As String
       Get
       Return _ContributorEmail
       End Get
       Set(ByVal Value As String)
       _ContributorEmail = Value
       End Set
   End Property
#End Region '(Set|Get) The ContributorEmail as String.

#Region"[On] |2019/07/06 00h51:335| <01.00.39> <Property> <Columns> |.ContributorName()|String|"' (Set|Get) The ContributorName as String.
   Private _ContributorName As String
    '''    <Summary>
'''     (Set|Get) The ContributorName as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:086 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ContributorName as String.") >
   Public Property ContributorName()As String
       Get
       Return _ContributorName
       End Get
       Set(ByVal Value As String)
       _ContributorName = Value
       End Set
   End Property
#End Region '(Set|Get) The ContributorName as String.

#Region"[On] |2019/07/06 00h51:347| <01.00.40> <Property> <Columns> |.ContributorUri()|String|"' (Set|Get) The ContributorUri as String.
   Private _ContributorUri As String
    '''    <Summary>
'''     (Set|Get) The ContributorUri as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:086 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ContributorUri as String.") >
   Public Property ContributorUri()As String
       Get
       Return _ContributorUri
       End Get
       Set(ByVal Value As String)
       _ContributorUri = Value
       End Set
   End Property
#End Region '(Set|Get) The ContributorUri as String.

#Region"[On] |2019/07/06 00h51:361| <01.00.41> <Property> <Columns> |.CustomProperty()|String|"' (Set|Get) The CustomProperty as String.
   Private _CustomProperty As String
    '''    <Summary>
'''     (Set|Get) The CustomProperty as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:086 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The CustomProperty as String.") >
   Public Property CustomProperty()As String
       Get
       Return _CustomProperty
       End Get
       Set(ByVal Value As String)
       _CustomProperty = Value
       End Set
   End Property
#End Region '(Set|Get) The CustomProperty as String.

#Region"[On] |2019/07/06 00h51:374| <01.00.42> <Property> <Columns> |.Published()|String|"' (Set|Get) The Published as String.
   Private _Published As String
    '''    <Summary>
'''     (Set|Get) The Published as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:086 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Published as String.") >
   Public Property Published()As String
       Get
       Return _Published
       End Get
       Set(ByVal Value As String)
       _Published = Value
       End Set
   End Property
#End Region '(Set|Get) The Published as String.

#Region"[On] |2019/07/06 00h51:386| <01.00.43> <Property> <Columns> |.Rights()|String|"' (Set|Get) The Rights as String.
   Private _Rights As String
    '''    <Summary>
'''     (Set|Get) The Rights as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:087 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Rights as String.") >
   Public Property Rights()As String
       Get
       Return _Rights
       End Get
       Set(ByVal Value As String)
       _Rights = Value
       End Set
   End Property
#End Region '(Set|Get) The Rights as String.

#Region"[On] |2019/07/06 00h51:399| <01.00.44> <Property> <Columns> |.Summary()|String|"' (Set|Get) The Summary as String.
   Private _Summary As String
    '''    <Summary>
'''     (Set|Get) The Summary as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:087 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Summary as String.") >
   Public Property Summary()As String
       Get
       Return _Summary
       End Get
       Set(ByVal Value As String)
       _Summary = Value
       End Set
   End Property
#End Region '(Set|Get) The Summary as String.

#Region"[On] |2019/07/06 00h51:412| <01.00.45> <Property> <Columns> |.Title()|String|"' (Set|Get) The Title as String.
   Private _Title As String
    '''    <Summary>
'''     (Set|Get) The Title as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:087 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Title as String.") >
   Public Property Title()As String
       Get
       Return _Title
       End Get
       Set(ByVal Value As String)
       _Title = Value
       End Set
   End Property
#End Region '(Set|Get) The Title as String.

#Region"[On] |2019/07/06 00h51:424| <01.00.46> <Property> <Columns> |.Updated()|String|"' (Set|Get) The Updated as String.
   Private _Updated As String
    '''    <Summary>
'''     (Set|Get) The Updated as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:087 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Updated as String.") >
   Public Property Updated()As String
       Get
       Return _Updated
       End Get
       Set(ByVal Value As String)
       _Updated = Value
       End Set
   End Property
#End Region '(Set|Get) The Updated as String.

#Region"[On] |2019/07/06 00h51:436| <01.00.47> <Property> <Columns> |.Usage()|String|"' (Set|Get) The Usage as String.
   Private _Usage As String
    '''    <Summary>
'''     (Set|Get) The Usage as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:088 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Usage as String.") >
   Public Property Usage()As String
       Get
       Return _Usage
       End Get
       Set(ByVal Value As String)
       _Usage = Value
       End Set
   End Property
#End Region '(Set|Get) The Usage as String.

#Region"[On] |2019/07/06 00h51:457| <01.00.48> <Property> <Columns> |.Remarks()|String|"' (Set|Get) The Remarks as String.
   Private _Remarks As String
    '''    <Summary>
'''     (Set|Get) The Remarks as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:088 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Remarks as String.") >
   Public Property Remarks()As String
       Get
       Return _Remarks
       End Get
       Set(ByVal Value As String)
       _Remarks = Value
       End Set
   End Property
#End Region '(Set|Get) The Remarks as String.

#Region"[On] |2019/07/06 00h51:470| <01.00.49> <Property> <Columns> |.Example()|String|"' (Set|Get) The Example as String.
   Private _Example As String
    '''    <Summary>
'''     (Set|Get) The Example as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:088 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Example as String.") >
   Public Property Example()As String
       Get
       Return _Example
       End Get
       Set(ByVal Value As String)
       _Example = Value
       End Set
   End Property
#End Region '(Set|Get) The Example as String.

#Region"[On] |2019/07/06 00h51:486| <01.00.50> <Property> <Columns> |.Note()|String|"' (Set|Get) The Note as String.
   Private _Note As String
    '''    <Summary>
'''     (Set|Get) The Note as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:090 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Note as String.") >
   Public Property Note()As String
       Get
       Return _Note
       End Get
       Set(ByVal Value As String)
       _Note = Value
       End Set
   End Property
#End Region '(Set|Get) The Note as String.

#Region"[On] |2019/07/06 00h51:500| <01.00.51> <Property> <Columns> |.CreationDate()|String|"' (Set|Get) The CreationDate as String.
   Private _CreationDate As String
    '''    <Summary>
'''     (Set|Get) The CreationDate as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:090 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The CreationDate as String.") >
   Public Property CreationDate()As String
       Get
       Return _CreationDate
       End Get
       Set(ByVal Value As String)
       _CreationDate = Value
       End Set
   End Property
#End Region '(Set|Get) The CreationDate as String.

#Region"[On] |2019/07/06 00h51:515| <01.00.52> <Property> <Columns> |.See()|String|"' (Set|Get) The See as String.
   Private _See As String
    '''    <Summary>
'''     (Set|Get) The See as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:091 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The See as String.") >
   Public Property See()As String
       Get
       Return _See
       End Get
       Set(ByVal Value As String)
       _See = Value
       End Set
   End Property
#End Region '(Set|Get) The See as String.

#Region"[On] |2019/07/06 00h51:529| <01.00.53> <Property> <Columns> |.SeeAlso()|String|"' (Set|Get) The SeeAlso as String.
   Private _SeeAlso As String
    '''    <Summary>
'''     (Set|Get) The SeeAlso as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:091 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The SeeAlso as String.") >
   Public Property SeeAlso()As String
       Get
       Return _SeeAlso
       End Get
       Set(ByVal Value As String)
       _SeeAlso = Value
       End Set
   End Property
#End Region '(Set|Get) The SeeAlso as String.

#Region"[On] |2019/07/06 00h51:543| <01.00.54> <Property> <Columns> |.Rules()|String|"' (Set|Get) The Rules as String.
   Private _Rules As String
    '''    <Summary>
'''     (Set|Get) The Rules as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:091 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Rules as String.") >
   Public Property Rules()As String
       Get
       Return _Rules
       End Get
       Set(ByVal Value As String)
       _Rules = Value
       End Set
   End Property
#End Region '(Set|Get) The Rules as String.

#Region"[On] |2019/07/06 00h51:556| <01.00.55> <Property> <Columns> |.Syntax()|String|"' (Set|Get) The Syntax as String.
   Private _Syntax As String
    '''    <Summary>
'''     (Set|Get) The Syntax as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:091 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Syntax as String.") >
   Public Property Syntax()As String
       Get
       Return _Syntax
       End Get
       Set(ByVal Value As String)
       _Syntax = Value
       End Set
   End Property
#End Region '(Set|Get) The Syntax as String.

#Region"[On] |2019/07/06 00h51:570| <01.00.56> <Property> <Columns> |.AccessModifier()|String|"' (Set|Get) The AccessModifier as String.
   Private _AccessModifier As String
    '''    <Summary>
'''     (Set|Get) The AccessModifier as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:092 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AccessModifier as String.") >
   Public Property AccessModifier()As String
       Get
       Return _AccessModifier
       End Get
       Set(ByVal Value As String)
       _AccessModifier = Value
       End Set
   End Property
#End Region '(Set|Get) The AccessModifier as String.

#Region"[On] |2019/07/06 00h51:584| <01.00.57> <Property> <Columns> |.Shadows()|Boolean|"' (Set|Get) The Shadows as Boolean.
   Private _Shadows As Boolean
    '''    <Summary>
'''     (Set|Get) The Shadows as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:092 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Shadows as Boolean.") >
   Public Property Shadows()As Boolean
       Get
       Return _Shadows
       End Get
       Set(ByVal Value As Boolean)
       _Shadows = Value
       End Set
   End Property
#End Region '(Set|Get) The Shadows as Boolean.

#Region"[On] |2019/07/06 00h51:598| <01.00.58> <Property> <Columns> |.Partial()|Boolean|"' (Set|Get) The Partial as Boolean.
   Private _Partial As Boolean
    '''    <Summary>
'''     (Set|Get) The Partial as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:092 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Partial as Boolean.") >
   Public Property Partial()As Boolean
       Get
       Return _Partial
       End Get
       Set(ByVal Value As Boolean)
       _Partial = Value
       End Set
   End Property
#End Region '(Set|Get) The Partial as Boolean.

#Region"[On] |2019/07/06 00h51:612| <01.00.59> <Property> <Columns> |.Typelist()|String|"' (Set|Get) The Typelist as String.
   Private _Typelist As String
    '''    <Summary>
'''     (Set|Get) The Typelist as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:092 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Typelist as String.") >
   Public Property Typelist()As String
       Get
       Return _Typelist
       End Get
       Set(ByVal Value As String)
       _Typelist = Value
       End Set
   End Property
#End Region '(Set|Get) The Typelist as String.

#Region"[On] |2019/07/06 00h51:641| <01.00.60> <Property> <Columns> |.StructureName()|String|"' (Set|Get) The StructureName as String.
   Private _StructureName As String
    '''    <Summary>
'''     (Set|Get) The StructureName as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:093 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The StructureName as String.") >
   Public Property StructureName()As String
       Get
       Return _StructureName
       End Get
       Set(ByVal Value As String)
       _StructureName = Value
       End Set
   End Property
#End Region '(Set|Get) The StructureName as String.

#Region"[On] |2019/07/06 00h51:655| <01.00.61> <Property> <Columns> |.Implements()|String|"' (Set|Get) The Implements as String.
   Private _Implements As String
    '''    <Summary>
'''     (Set|Get) The Implements as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:093 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Implements as String.") >
   Public Property Implements()As String
       Get
       Return _Implements
       End Get
       Set(ByVal Value As String)
       _Implements = Value
       End Set
   End Property
#End Region '(Set|Get) The Implements as String.

#End Region 
#Region"<2> [Enumeration]{1}"
#Region"[On] |2019/07/06 00h51:670| <02.00.00> <Enumeration> <> |.Schema()|Enumeration{61}|"' (Set|Get) The enumeration of Schema.
    '''    <Summary>
'''     (Set|Get) The enumeration of Schema.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:093 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The enumeration of Schema.") >
   Enum Schema
''' <summary>(Set|Get) The ID as Integer.</summary>
   [ID] = 0
''' <summary>(Set|Get) The Name as String.</summary>
   [Name] = 1
''' <summary>(Set|Get) The ImageIndex as Integer.</summary>
   [ImageIndex] = 2
''' <summary>(Set|Get) The Text as String.</summary>
   [Text] = 3
''' <summary>(Set|Get) The ToolTip as String.</summary>
   [ToolTip] = 4
''' <summary>(Set|Get) The Enable as Boolean.</summary>
   [Enable] = 5
''' <summary>(Set|Get) The Status as String.</summary>
   [Status] = 6
''' <summary>(Set|Get) The Statement as String.</summary>
   [Statement] = 7
''' <summary>(Set|Get) The XMLFile as String.</summary>
   [XMLFile] = 8
''' <summary>(Set|Get) The Attributes as String.</summary>
   [Attributes] = 9
''' <summary>(Set|Get) The Browsable as Boolean.</summary>
   [Browsable] = 10
''' <summary>(Set|Get) The Category as String.</summary>
   [Category] = 11
''' <summary>(Set|Get) The Description as String.</summary>
   [Description] = 12
''' <summary>(Set|Get) The DefaultValue as String.</summary>
   [DefaultValue] = 13
''' <summary>(Set|Get) The Editor as String.</summary>
   [Editor] = 14
''' <summary>(Set|Get) The DllImport as String.</summary>
   [DllImport] = 15
''' <summary>(Set|Get) The Deserializable as Boolean.</summary>
   [Deserializable] = 16
''' <summary>(Set|Get) The NonSerialized as Boolean.</summary>
   [NonSerialized] = 17
''' <summary>(Set|Get) The Serializable as Boolean.</summary>
   [Serializable] = 18
''' <summary>(Set|Get) The XmlRoot as String.</summary>
   [XmlRoot] = 19
''' <summary>(Set|Get) The XmlIgnore as Boolean.</summary>
   [XmlIgnore] = 20
''' <summary>(Set|Get) The XmlInclude as Boolean.</summary>
   [XmlInclude] = 21
''' <summary>(Set|Get) The RelatedImageList as String.</summary>
   [RelatedImageList] = 22
''' <summary>(Set|Get) The Print_VB as String.</summary>
   [Print_VB] = 23
''' <summary>(Set|Get) The VB as String.</summary>
   [VB] = 24
''' <summary>(Set|Get) The Print_C as String.</summary>
   [Print_C] = 25
''' <summary>(Set|Get) The C as String.</summary>
   [C] = 26
''' <summary>(Set|Get) The Print_F as String.</summary>
   [Print_F] = 27
''' <summary>(Set|Get) The F as String.</summary>
   [F] = 28
''' <summary>(Set|Get) The Print_Python as String.</summary>
   [Print_Python] = 29
''' <summary>(Set|Get) The Python as String.</summary>
   [Python] = 30
''' <summary>(Set|Get) The Print_JavaScript as String.</summary>
   [Print_JavaScript] = 31
''' <summary>(Set|Get) The JavaScript as String.</summary>
   [JavaScript] = 32
''' <summary>(Set|Get) The RegionCategory as Integer.</summary>
   [RegionCategory] = 33
''' <summary>(Set|Get) The RegionCode as String.</summary>
   [RegionCode] = 34
''' <summary>(Set|Get) The AuthorEmail as String.</summary>
   [AuthorEmail] = 35
''' <summary>(Set|Get) The AuthorName as String.</summary>
   [AuthorName] = 36
''' <summary>(Set|Get) The AuthorUri as String.</summary>
   [AuthorUri] = 37
''' <summary>(Set|Get) The ContributorEmail as String.</summary>
   [ContributorEmail] = 38
''' <summary>(Set|Get) The ContributorName as String.</summary>
   [ContributorName] = 39
''' <summary>(Set|Get) The ContributorUri as String.</summary>
   [ContributorUri] = 40
''' <summary>(Set|Get) The CustomProperty as String.</summary>
   [CustomProperty] = 41
''' <summary>(Set|Get) The Published as String.</summary>
   [Published] = 42
''' <summary>(Set|Get) The Rights as String.</summary>
   [Rights] = 43
''' <summary>(Set|Get) The Summary as String.</summary>
   [Summary] = 44
''' <summary>(Set|Get) The Title as String.</summary>
   [Title] = 45
''' <summary>(Set|Get) The Updated as String.</summary>
   [Updated] = 46
''' <summary>(Set|Get) The Usage as String.</summary>
   [Usage] = 47
''' <summary>(Set|Get) The Remarks as String.</summary>
   [Remarks] = 48
''' <summary>(Set|Get) The Example as String.</summary>
   [Example] = 49
''' <summary>(Set|Get) The Note as String.</summary>
   [Note] = 50
''' <summary>(Set|Get) The CreationDate as String.</summary>
   [CreationDate] = 51
''' <summary>(Set|Get) The See as String.</summary>
   [See] = 52
''' <summary>(Set|Get) The SeeAlso as String.</summary>
   [SeeAlso] = 53
''' <summary>(Set|Get) The Rules as String.</summary>
   [Rules] = 54
''' <summary>(Set|Get) The Syntax as String.</summary>
   [Syntax] = 55
''' <summary>(Set|Get) The AccessModifier as String.</summary>
   [AccessModifier] = 56
''' <summary>(Set|Get) The Shadows as Boolean.</summary>
   [Shadows] = 57
''' <summary>(Set|Get) The Partial as Boolean.</summary>
   [Partial] = 58
''' <summary>(Set|Get) The Typelist as String.</summary>
   [Typelist] = 59
''' <summary>(Set|Get) The StructureName as String.</summary>
   [StructureName] = 60
''' <summary>(Set|Get) The Implements as String.</summary>
   [Implements] = 61
   End Enum
#End Region '(Set|Get) The enumeration of Schema.

#End Region 
#Region "<4> [Sub]{5}"
#Region"[On] |2019/07/06 00h51:691| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
    '''    <Summary>
'''     (Set|Get) This will reinitialize the class element.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:094 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) This will reinitialize the class element.") >
   Public Sub Clear()
  With Me
        .ID = 0
        .Name = Nothing
        .ImageIndex = 0
        .Text = Nothing
        .ToolTip = Nothing
        .Enable = False
        .Status = Nothing
        .Statement = Nothing
        .XMLFile = Nothing
        .Attributes = Nothing
        .Browsable = False
        .Category = Nothing
        .Description = Nothing
        .DefaultValue = Nothing
        .Editor = Nothing
        .DllImport = Nothing
        .Deserializable = False
        .NonSerialized = False
        .Serializable = False
        .XmlRoot = Nothing
        .XmlIgnore = False
        .XmlInclude = False
        .RelatedImageList = Nothing
        .Print_VB = Nothing
        .VB = Nothing
        .Print_C = Nothing
        .C = Nothing
        .Print_F = Nothing
        .F = Nothing
        .Print_Python = Nothing
        .Python = Nothing
        .Print_JavaScript = Nothing
        .JavaScript = Nothing
        .RegionCategory = 0
        .RegionCode = Nothing
        .AuthorEmail = Nothing
        .AuthorName = Nothing
        .AuthorUri = Nothing
        .ContributorEmail = Nothing
        .ContributorName = Nothing
        .ContributorUri = Nothing
        .CustomProperty = Nothing
        .Published = Nothing
        .Rights = Nothing
        .Summary = Nothing
        .Title = Nothing
        .Updated = Nothing
        .Usage = Nothing
        .Remarks = Nothing
        .Example = Nothing
        .Note = Nothing
        .CreationDate = Nothing
        .See = Nothing
        .SeeAlso = Nothing
        .Rules = Nothing
        .Syntax = Nothing
        .AccessModifier = Nothing
        .Shadows = False
        .Partial = False
        .Typelist = Nothing
        .StructureName = Nothing
        .Implements = Nothing
 End With
   End Sub
#End Region '(Set|Get) This will reinitialize the class element.

#Region"[On] |2019/07/06 00h51:707| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
    '''    <Summary>
'''     (Set|Get) This will reinitialize the variables of this class.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:094 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) This will reinitialize the variables of this class.") >
   Public Sub Reset(Optional ByVal Connector As LineInfo = Nothing)
If Not IsNothing(Connector) Then
   Me.Connector=Connector
   Me.FilePath=""
   Me.Password=""
   Me.Line=""
   If Connector.Status<>Status.Broken Then 
        FilePath = Connector.FilePath
        Password = Connector.Password
        Me.Connector=Connector
        TableName = "Structure"
        Line = Connector.Line
        UseSQL = False
   Else
        FilePath = My.Settings.Db_ProjectDatabase_FilePath
        Password = My.Settings.Db_ProjectDatabase_Password
        Me.Line = My.Settings.Db_ProjectDatabase_Line
        TableName = "Structure"
        UseSQL = False
   End If
Else
        If IsNothing(FilePath) Then 
             FilePath = My.Settings.Db_ProjectDatabase_FilePath
        End If 
        If FilePath.Length<1 Then 
             FilePath = My.Settings.Db_ProjectDatabase_FilePath
        End If 
        FilePath = My.Settings.Db_ProjectDatabase_FilePath
        Password = My.Settings.Db_ProjectDatabase_Password
        Me.Line = My.Settings.Db_ProjectDatabase_Line
        TableName = "Structure"
        UseSQL = False
End If

   End Sub
#End Region '(Set|Get) This will reinitialize the variables of this class.

#Region"[On] |2019/07/06 00h51:721| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
    '''    <Summary>
'''     (Set|Get) This will add a new row in the table.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:095 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) This will add a new row in the table.") >
   Public Sub Add()
 Try
   Dim Str As String = Nothing
   Str = "Insert Into [Structure] (
`ID`, 
`Name`, 
`ImageIndex`, 
`Text`, 
`ToolTip`, 
`Enable`, 
`Status`, 
`Statement`, 
`XMLFile`, 
`Attributes`, 
`Browsable`, 
`Category`, 
`Description`, 
`DefaultValue`, 
`Editor`, 
`DllImport`, 
`Deserializable`, 
`NonSerialized`, 
`Serializable`, 
`XmlRoot`, 
`XmlIgnore`, 
`XmlInclude`, 
`RelatedImageList`, 
`Print_VB`, 
`VB`, 
`Print_C`, 
`C`, 
`Print_F`, 
`F`, 
`Print_Python`, 
`Python`, 
`Print_JavaScript`, 
`JavaScript`, 
`RegionCategory`, 
`RegionCode`, 
`AuthorEmail`, 
`AuthorName`, 
`AuthorUri`, 
`ContributorEmail`, 
`ContributorName`, 
`ContributorUri`, 
`CustomProperty`, 
`Published`, 
`Rights`, 
`Summary`, 
`Title`, 
`Updated`, 
`Usage`, 
`Remarks`, 
`Example`, 
`Note`, 
`CreationDate`, 
`See`, 
`SeeAlso`, 
`Rules`, 
`Syntax`, 
`AccessModifier`, 
`Shadows`, 
`Partial`, 
`Typelist`, 
`StructureName`, 
`Implements`) Values (@0, @1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18, @19, @20, @21, @22, @23, @24, @25, @26, @27, @28, @29, @30, @31, @32, @33, @34, @35, @36, @37, @38, @39, @40, @41, @42, @43, @44, @45, @46, @47, @48, @49, @50, @51, @52, @53, @54, @55, @56, @57, @58, @59, @60, @61)"
Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
Cmd = New OleDb.OleDbCommand(Str,Con)
Con.Open()
            Cmd.Parameters.AddWithValue("@0", Me.ID)
            Cmd.Parameters.AddWithValue("@1", Me.Name)
            Cmd.Parameters.AddWithValue("@2", Me.ImageIndex)
            Cmd.Parameters.AddWithValue("@3", Me.Text)
            Cmd.Parameters.AddWithValue("@4", Me.ToolTip)
            Cmd.Parameters.AddWithValue("@5", Me.Enable)
            Cmd.Parameters.AddWithValue("@6", Me.Status)
            Cmd.Parameters.AddWithValue("@7", Me.Statement)
            Cmd.Parameters.AddWithValue("@8", Me.XMLFile)
            Cmd.Parameters.AddWithValue("@9", Me.Attributes)
            Cmd.Parameters.AddWithValue("@10", Me.Browsable)
            Cmd.Parameters.AddWithValue("@11", Me.Category)
            Cmd.Parameters.AddWithValue("@12", Me.Description)
            Cmd.Parameters.AddWithValue("@13", Me.DefaultValue)
            Cmd.Parameters.AddWithValue("@14", Me.Editor)
            Cmd.Parameters.AddWithValue("@15", Me.DllImport)
            Cmd.Parameters.AddWithValue("@16", Me.Deserializable)
            Cmd.Parameters.AddWithValue("@17", Me.NonSerialized)
            Cmd.Parameters.AddWithValue("@18", Me.Serializable)
            Cmd.Parameters.AddWithValue("@19", Me.XmlRoot)
            Cmd.Parameters.AddWithValue("@20", Me.XmlIgnore)
            Cmd.Parameters.AddWithValue("@21", Me.XmlInclude)
            Cmd.Parameters.AddWithValue("@22", Me.RelatedImageList)
            Cmd.Parameters.AddWithValue("@23", Me.Print_VB)
            Cmd.Parameters.AddWithValue("@24", Me.VB)
            Cmd.Parameters.AddWithValue("@25", Me.Print_C)
            Cmd.Parameters.AddWithValue("@26", Me.C)
            Cmd.Parameters.AddWithValue("@27", Me.Print_F)
            Cmd.Parameters.AddWithValue("@28", Me.F)
            Cmd.Parameters.AddWithValue("@29", Me.Print_Python)
            Cmd.Parameters.AddWithValue("@30", Me.Python)
            Cmd.Parameters.AddWithValue("@31", Me.Print_JavaScript)
            Cmd.Parameters.AddWithValue("@32", Me.JavaScript)
            Cmd.Parameters.AddWithValue("@33", Me.RegionCategory)
            Cmd.Parameters.AddWithValue("@34", Me.RegionCode)
            Cmd.Parameters.AddWithValue("@35", Me.AuthorEmail)
            Cmd.Parameters.AddWithValue("@36", Me.AuthorName)
            Cmd.Parameters.AddWithValue("@37", Me.AuthorUri)
            Cmd.Parameters.AddWithValue("@38", Me.ContributorEmail)
            Cmd.Parameters.AddWithValue("@39", Me.ContributorName)
            Cmd.Parameters.AddWithValue("@40", Me.ContributorUri)
            Cmd.Parameters.AddWithValue("@41", Me.CustomProperty)
            Cmd.Parameters.AddWithValue("@42", Me.Published)
            Cmd.Parameters.AddWithValue("@43", Me.Rights)
            Cmd.Parameters.AddWithValue("@44", Me.Summary)
            Cmd.Parameters.AddWithValue("@45", Me.Title)
            Cmd.Parameters.AddWithValue("@46", Me.Updated)
            Cmd.Parameters.AddWithValue("@47", Me.Usage)
            Cmd.Parameters.AddWithValue("@48", Me.Remarks)
            Cmd.Parameters.AddWithValue("@49", Me.Example)
            Cmd.Parameters.AddWithValue("@50", Me.Note)
            Cmd.Parameters.AddWithValue("@51", Me.CreationDate)
            Cmd.Parameters.AddWithValue("@52", Me.See)
            Cmd.Parameters.AddWithValue("@53", Me.SeeAlso)
            Cmd.Parameters.AddWithValue("@54", Me.Rules)
            Cmd.Parameters.AddWithValue("@55", Me.Syntax)
            Cmd.Parameters.AddWithValue("@56", Me.AccessModifier)
            Cmd.Parameters.AddWithValue("@57", Me.Shadows)
            Cmd.Parameters.AddWithValue("@58", Me.Partial)
            Cmd.Parameters.AddWithValue("@59", Me.Typelist)
            Cmd.Parameters.AddWithValue("@60", Me.StructureName)
            Cmd.Parameters.AddWithValue("@61", Me.Implements)
          If Cmd.ExecuteNonQuery>=0 Then
          Else
              Msgbox("Element not Addd")
          End If
 Catch ex As Exception 
 Finally 
   Close(True) 
 End Try 

   End Sub
#End Region '(Set|Get) This will add a new row in the table.

#Region"[On] |2019/07/06 00h51:736| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
    '''    <Summary>
'''     (Set|Get) This will update a row in the table.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:095 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) This will update a row in the table.") >
   Public Sub Save()
 Try
   Dim Str As String = Nothing
   Str = "UPDATE [Structure] SET Name = @Name, ImageIndex = @ImageIndex, Text = @Text, ToolTip = @ToolTip, Enable = @Enable, Status = @Status, Statement = @Statement, XMLFile = @XMLFile, Attributes = @Attributes, Browsable = @Browsable, Category = @Category, Description = @Description, DefaultValue = @DefaultValue, Editor = @Editor, DllImport = @DllImport, Deserializable = @Deserializable, NonSerialized = @NonSerialized, Serializable = @Serializable, XmlRoot = @XmlRoot, XmlIgnore = @XmlIgnore, XmlInclude = @XmlInclude, RelatedImageList = @RelatedImageList, Print_VB = @Print_VB, VB = @VB, Print_C = @Print_C, C = @C, Print_F = @Print_F, F = @F, Print_Python = @Print_Python, Python = @Python, Print_JavaScript = @Print_JavaScript, JavaScript = @JavaScript, RegionCategory = @RegionCategory, RegionCode = @RegionCode, AuthorEmail = @AuthorEmail, AuthorName = @AuthorName, AuthorUri = @AuthorUri, ContributorEmail = @ContributorEmail, ContributorName = @ContributorName, ContributorUri = @ContributorUri, CustomProperty = @CustomProperty, Published = @Published, Rights = @Rights, Summary = @Summary, Title = @Title, Updated = @Updated, Usage = @Usage, Remarks = @Remarks, Example = @Example, Note = @Note, CreationDate = @CreationDate, See = @See, SeeAlso = @SeeAlso, Rules = @Rules, Syntax = @Syntax, AccessModifier = @AccessModifier, Shadows = @Shadows, Partial = @Partial, Typelist = @Typelist, StructureName = @StructureName, Implements = @Implements WHERE ID = @ID"
Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
Cmd = New OleDb.OleDbCommand(Str,Con)
Con.Open()
      Cmd.Parameters.AddWithValue("@Name",Name)
      Cmd.Parameters.AddWithValue("@ImageIndex",ImageIndex)
      Cmd.Parameters.AddWithValue("@Text",Text)
      Cmd.Parameters.AddWithValue("@ToolTip",ToolTip)
      Cmd.Parameters.AddWithValue("@Enable",Enable)
      Cmd.Parameters.AddWithValue("@Status",Status)
      Cmd.Parameters.AddWithValue("@Statement",Statement)
      Cmd.Parameters.AddWithValue("@XMLFile",XMLFile)
      Cmd.Parameters.AddWithValue("@Attributes",Attributes)
      Cmd.Parameters.AddWithValue("@Browsable",Browsable)
      Cmd.Parameters.AddWithValue("@Category",Category)
      Cmd.Parameters.AddWithValue("@Description",Description)
      Cmd.Parameters.AddWithValue("@DefaultValue",DefaultValue)
      Cmd.Parameters.AddWithValue("@Editor",Editor)
      Cmd.Parameters.AddWithValue("@DllImport",DllImport)
      Cmd.Parameters.AddWithValue("@Deserializable",Deserializable)
      Cmd.Parameters.AddWithValue("@NonSerialized",NonSerialized)
      Cmd.Parameters.AddWithValue("@Serializable",Serializable)
      Cmd.Parameters.AddWithValue("@XmlRoot",XmlRoot)
      Cmd.Parameters.AddWithValue("@XmlIgnore",XmlIgnore)
      Cmd.Parameters.AddWithValue("@XmlInclude",XmlInclude)
      Cmd.Parameters.AddWithValue("@RelatedImageList",RelatedImageList)
      Cmd.Parameters.AddWithValue("@Print_VB",Print_VB)
      Cmd.Parameters.AddWithValue("@VB",VB)
      Cmd.Parameters.AddWithValue("@Print_C",Print_C)
      Cmd.Parameters.AddWithValue("@C",C)
      Cmd.Parameters.AddWithValue("@Print_F",Print_F)
      Cmd.Parameters.AddWithValue("@F",F)
      Cmd.Parameters.AddWithValue("@Print_Python",Print_Python)
      Cmd.Parameters.AddWithValue("@Python",Python)
      Cmd.Parameters.AddWithValue("@Print_JavaScript",Print_JavaScript)
      Cmd.Parameters.AddWithValue("@JavaScript",JavaScript)
      Cmd.Parameters.AddWithValue("@RegionCategory",RegionCategory)
      Cmd.Parameters.AddWithValue("@RegionCode",RegionCode)
      Cmd.Parameters.AddWithValue("@AuthorEmail",AuthorEmail)
      Cmd.Parameters.AddWithValue("@AuthorName",AuthorName)
      Cmd.Parameters.AddWithValue("@AuthorUri",AuthorUri)
      Cmd.Parameters.AddWithValue("@ContributorEmail",ContributorEmail)
      Cmd.Parameters.AddWithValue("@ContributorName",ContributorName)
      Cmd.Parameters.AddWithValue("@ContributorUri",ContributorUri)
      Cmd.Parameters.AddWithValue("@CustomProperty",CustomProperty)
      Cmd.Parameters.AddWithValue("@Published",Published)
      Cmd.Parameters.AddWithValue("@Rights",Rights)
      Cmd.Parameters.AddWithValue("@Summary",Summary)
      Cmd.Parameters.AddWithValue("@Title",Title)
      Cmd.Parameters.AddWithValue("@Updated",Updated)
      Cmd.Parameters.AddWithValue("@Usage",Usage)
      Cmd.Parameters.AddWithValue("@Remarks",Remarks)
      Cmd.Parameters.AddWithValue("@Example",Example)
      Cmd.Parameters.AddWithValue("@Note",Note)
      Cmd.Parameters.AddWithValue("@CreationDate",CreationDate)
      Cmd.Parameters.AddWithValue("@See",See)
      Cmd.Parameters.AddWithValue("@SeeAlso",SeeAlso)
      Cmd.Parameters.AddWithValue("@Rules",Rules)
      Cmd.Parameters.AddWithValue("@Syntax",Syntax)
      Cmd.Parameters.AddWithValue("@AccessModifier",AccessModifier)
      Cmd.Parameters.AddWithValue("@Shadows",Shadows)
      Cmd.Parameters.AddWithValue("@Partial",Partial)
      Cmd.Parameters.AddWithValue("@Typelist",Typelist)
      Cmd.Parameters.AddWithValue("@StructureName",StructureName)
      Cmd.Parameters.AddWithValue("@Implements",Implements)
      Cmd.Parameters.AddWithValue("@ID",ID)
          If Cmd.ExecuteNonQuery>=0 Then
          Else
              Msgbox("Element not Saved")
          End If
 Catch ex As Exception 
 Finally 
   Close(True) 
 End Try 

   End Sub
#End Region '(Set|Get) This will update a row in the table.

#Region"[On] |2019/07/06 00h51:753| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
    '''    <Summary>
'''     (Set|Get) This will Delete a row in the table.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:095 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) This will Delete a row in the table.") >
   Public Sub Delete()
 Try
   Dim Str As String = Nothing
   Str = "Delete From [Structure] WHERE ID =@ID"
Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
Cmd = New OleDb.OleDbCommand(Str,Con)
Con.Open()
Cmd.Parameters.AddWithValue("@ID", ID)
          If Cmd.ExecuteNonQuery>=0 Then
          Else
              Msgbox("Element not Deleted")
          End If
 Catch ex As Exception 
 Finally 
   Close(True) 
 End Try 

   End Sub
#End Region '(Set|Get) This will Delete a row in the table.

#End Region 
#Region "<5> [Function]{7}"
#Region"[On] |2019/07/06 00h51:767| <05.00.00> <Function> <> |.Open()|TestItem}|"' (Set|Get) This will initialise the connection and import the data.
    '''    <Summary>
'''     (Set|Get) This will initialise the connection and import the data.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:095 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) This will initialise the connection and import the data.") >
   Public Function Open(ByVal SqlCommand As String) As TestItem
 Dim Result As New TestItem("Open(SqlCommand)", " Openning the connection line to the database.")
 If CheckConnection()=True Then
                     Con = New OleDb.OleDbConnection(Me.Line)
                     Cmd = New OleDb.OleDbCommand(SqlCommand,Con)
                         If Con.State = ConnectionState.Open Then
                             Close(True)
                         Else
                             Try
                                 Con.Open()
                                 Result.Status = Status.Online
                             Catch ex As Exception
                                 Result.AddBug(ex,"Error while opening database","SqlCon.Open()")
                                 Result.Why+= ex.Message & vbNewLine
                                 Result.Status = Status.Broken
                             End Try
                         End If
     Else
         Result.Status = Status.Broken
         Result.Why += Log & VbNewLine 
     End If
 Return Result

   End Function
#End Region '(Set|Get) This will initialise the connection and import the data.

#Region"[On] |2019/07/06 00h51:782| <05.00.01> <Function> <> |.Close()|TestItem}|"' (Set|Get) This willClosing the connection
    '''    <Summary>
'''     (Set|Get) This willClosing the connection
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:096 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) This willClosing the connection") >
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
                                 Result.Why +="The connection will not close." & vbNewLine
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
                                 Result.Why +="The connection will not close." & vbNewLine
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
                                 Result.Why +="The connection will not close." & vbNewLine
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
                                 Result.Why +="The connection will not close." & vbNewLine
                             End If
                     End If
             End If
         End If
 Return Result

   End Function
#End Region '(Set|Get) This willClosing the connection

#Region"[On] |2019/07/06 00h51:799| <05.00.02> <Function> <> |.List()|List(Of Structure)}|"' (Set|Get) Return the entire table listed
    '''    <Summary>
'''     (Set|Get) Return the entire table listed
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:096 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) Return the entire table listed") >
   Public Function List() As List(Of Structure)
Dim Result As New List(Of Structure)
Me.Table = New Table(Me.TableName , Me.FilePath , Me.Password,False)
   For each Row As DataRow In Me.Table.DataTable.Rows
      Dim Element As New Structure(IIf(IsDBNull(Row.Item(0)),0,Row.Item(0)),
IIf(IsDBNull(Row.Item(1)),"",Row.Item(1)),
IIf(IsDBNull(Row.Item(2)),0,Row.Item(2)),
IIf(IsDBNull(Row.Item(3)),"",Row.Item(3)),
IIf(IsDBNull(Row.Item(4)),"",Row.Item(4)),
IIf(IsDBNull(Row.Item(5)),False,Row.Item(5)),
IIf(IsDBNull(Row.Item(6)),"",Row.Item(6)),
IIf(IsDBNull(Row.Item(7)),"",Row.Item(7)),
IIf(IsDBNull(Row.Item(8)),"",Row.Item(8)),
IIf(IsDBNull(Row.Item(9)),"",Row.Item(9)),
IIf(IsDBNull(Row.Item(10)),False,Row.Item(10)),
IIf(IsDBNull(Row.Item(11)),"",Row.Item(11)),
IIf(IsDBNull(Row.Item(12)),"",Row.Item(12)),
IIf(IsDBNull(Row.Item(13)),"",Row.Item(13)),
IIf(IsDBNull(Row.Item(14)),"",Row.Item(14)),
IIf(IsDBNull(Row.Item(15)),"",Row.Item(15)),
IIf(IsDBNull(Row.Item(16)),False,Row.Item(16)),
IIf(IsDBNull(Row.Item(17)),False,Row.Item(17)),
IIf(IsDBNull(Row.Item(18)),False,Row.Item(18)),
IIf(IsDBNull(Row.Item(19)),"",Row.Item(19)),
IIf(IsDBNull(Row.Item(20)),False,Row.Item(20)),
IIf(IsDBNull(Row.Item(21)),False,Row.Item(21)),
IIf(IsDBNull(Row.Item(22)),"",Row.Item(22)),
IIf(IsDBNull(Row.Item(23)),"",Row.Item(23)),
IIf(IsDBNull(Row.Item(24)),"",Row.Item(24)),
IIf(IsDBNull(Row.Item(25)),"",Row.Item(25)),
IIf(IsDBNull(Row.Item(26)),"",Row.Item(26)),
IIf(IsDBNull(Row.Item(27)),"",Row.Item(27)),
IIf(IsDBNull(Row.Item(28)),"",Row.Item(28)),
IIf(IsDBNull(Row.Item(29)),"",Row.Item(29)),
IIf(IsDBNull(Row.Item(30)),"",Row.Item(30)),
IIf(IsDBNull(Row.Item(31)),"",Row.Item(31)),
IIf(IsDBNull(Row.Item(32)),"",Row.Item(32)),
IIf(IsDBNull(Row.Item(33)),0,Row.Item(33)),
IIf(IsDBNull(Row.Item(34)),"",Row.Item(34)),
IIf(IsDBNull(Row.Item(35)),"",Row.Item(35)),
IIf(IsDBNull(Row.Item(36)),"",Row.Item(36)),
IIf(IsDBNull(Row.Item(37)),"",Row.Item(37)),
IIf(IsDBNull(Row.Item(38)),"",Row.Item(38)),
IIf(IsDBNull(Row.Item(39)),"",Row.Item(39)),
IIf(IsDBNull(Row.Item(40)),"",Row.Item(40)),
IIf(IsDBNull(Row.Item(41)),"",Row.Item(41)),
IIf(IsDBNull(Row.Item(42)),"",Row.Item(42)),
IIf(IsDBNull(Row.Item(43)),"",Row.Item(43)),
IIf(IsDBNull(Row.Item(44)),"",Row.Item(44)),
IIf(IsDBNull(Row.Item(45)),"",Row.Item(45)),
IIf(IsDBNull(Row.Item(46)),"",Row.Item(46)),
IIf(IsDBNull(Row.Item(47)),"",Row.Item(47)),
IIf(IsDBNull(Row.Item(48)),"",Row.Item(48)),
IIf(IsDBNull(Row.Item(49)),"",Row.Item(49)),
IIf(IsDBNull(Row.Item(50)),"",Row.Item(50)),
IIf(IsDBNull(Row.Item(51)),"",Row.Item(51)),
IIf(IsDBNull(Row.Item(52)),"",Row.Item(52)),
IIf(IsDBNull(Row.Item(53)),"",Row.Item(53)),
IIf(IsDBNull(Row.Item(54)),"",Row.Item(54)),
IIf(IsDBNull(Row.Item(55)),"",Row.Item(55)),
IIf(IsDBNull(Row.Item(56)),"",Row.Item(56)),
IIf(IsDBNull(Row.Item(57)),False,Row.Item(57)),
IIf(IsDBNull(Row.Item(58)),False,Row.Item(58)),
IIf(IsDBNull(Row.Item(59)),"",Row.Item(59)),
IIf(IsDBNull(Row.Item(60)),"",Row.Item(60)),
      IIf(IsDBNull(Row.Item(61)),"",Row.Item(61)))
      Element.Reset(Table.Line)
 Result.Add(Element)
 Next
 Return Result
   End Function
#End Region '(Set|Get) Return the entire table listed

#Region"[On] |2019/07/06 00h51:814| <05.00.03> <Function> <> |.SearchByName()|List(Of Structure)}|"' (Set|Get) Search for each property that match the Search String.
    '''    <Summary>
'''     (Set|Get) Search for each property that match the Search String.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:098 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) Search for each property that match the Search String.") >
   Public Shared Function SearchByName(ByVal Search As String) As List(Of Structure)
Dim Result As New List(Of Structure)
 Dim C As New Structure
 For Each Element As Structure In C.List
 If Element.Name.Tolower() = Search.Tolower() Or Element.Text.Tolower() = Search.Tolower()  Or Element.ToolTip.Tolower() = Search.Tolower()  Or Element.Status.Tolower() = Search.Tolower()  Or Element.Statement.Tolower() = Search.Tolower()  Or Element.XMLFile.Tolower() = Search.Tolower()  Or Element.Attributes.Tolower() = Search.Tolower()  Or Element.Category.Tolower() = Search.Tolower()  Or Element.Description.Tolower() = Search.Tolower()  Or Element.DefaultValue.Tolower() = Search.Tolower()  Or Element.Editor.Tolower() = Search.Tolower()  Or Element.DllImport.Tolower() = Search.Tolower()  Or Element.XmlRoot.Tolower() = Search.Tolower()  Or Element.RelatedImageList.Tolower() = Search.Tolower()  Or Element.Print_VB.Tolower() = Search.Tolower()  Or Element.VB.Tolower() = Search.Tolower()  Or Element.Print_C.Tolower() = Search.Tolower()  Or Element.C.Tolower() = Search.Tolower()  Or Element.Print_F.Tolower() = Search.Tolower()  Or Element.F.Tolower() = Search.Tolower()  Or Element.Print_Python.Tolower() = Search.Tolower()  Or Element.Python.Tolower() = Search.Tolower()  Or Element.Print_JavaScript.Tolower() = Search.Tolower()  Or Element.JavaScript.Tolower() = Search.Tolower()  Or Element.RegionCode.Tolower() = Search.Tolower()  Or Element.AuthorEmail.Tolower() = Search.Tolower()  Or Element.AuthorName.Tolower() = Search.Tolower()  Or Element.AuthorUri.Tolower() = Search.Tolower()  Or Element.ContributorEmail.Tolower() = Search.Tolower()  Or Element.ContributorName.Tolower() = Search.Tolower()  Or Element.ContributorUri.Tolower() = Search.Tolower()  Or Element.CustomProperty.Tolower() = Search.Tolower()  Or Element.Published.Tolower() = Search.Tolower()  Or Element.Rights.Tolower() = Search.Tolower()  Or Element.Summary.Tolower() = Search.Tolower()  Or Element.Title.Tolower() = Search.Tolower()  Or Element.Updated.Tolower() = Search.Tolower()  Or Element.Usage.Tolower() = Search.Tolower()  Or Element.Remarks.Tolower() = Search.Tolower()  Or Element.Example.Tolower() = Search.Tolower()  Or Element.Note.Tolower() = Search.Tolower()  Or Element.CreationDate.Tolower() = Search.Tolower()  Or Element.See.Tolower() = Search.Tolower()  Or Element.SeeAlso.Tolower() = Search.Tolower()  Or Element.Rules.Tolower() = Search.Tolower()  Or Element.Syntax.Tolower() = Search.Tolower()  Or Element.AccessModifier.Tolower() = Search.Tolower()  Or Element.Typelist.Tolower() = Search.Tolower()  Or Element.StructureName.Tolower() = Search.Tolower()  Or Element.Implements.Tolower() = Search.Tolower() Then
      Result.Add(Element)
 End If
 Next
 Return Result
   End Function
#End Region '(Set|Get) Search for each property that match the Search String.

#Region"[On] |2019/07/06 00h51:831| <05.00.04> <Function> <> |.SearchByID()|List(Of Structure)}|"' (Set|Get) Search for each property that match the Search Id.
    '''    <Summary>
'''     (Set|Get) Search for each property that match the Search Id.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:098 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) Search for each property that match the Search Id.") >
   Public Shared Function SearchByID(ByVal Search As Double) As List(Of Structure)
Dim Result As New List(Of Structure)
 Dim C As New Structure
 For Each Element As Structure In C.List
 If Val(Element.ID) = Search Or Val(Element.ImageIndex) = Search  Or Val(Element.RegionCategory) = Search Then
      Result.Add(Element)
 End If
 Next
 Return Result
   End Function
#End Region '(Set|Get) Search for each property that match the Search Id.

#Region"[On] |2019/07/06 00h51:846| <05.00.05> <Function> <> |.ToString()|String}|"' (Set|Get) The function ToString.
    '''    <Summary>
'''     (Set|Get) The function ToString.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:099 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The function ToString.") >
   Public Overrides Function ToString() As String
    Return Me.ID
   End Function
#End Region '(Set|Get) The function ToString.

#Region"[On] |2019/07/06 00h51:862| <05.00.06> <Function> <> |.CheckConnection()|Boolean}|"' (Set|Get) Evaluate the connection to the DataBase
    '''    <Summary>
'''     (Set|Get) Evaluate the connection to the DataBase
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:099 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) Evaluate the connection to the DataBase") >
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
    Dim Message As String = Nothing' Stores the process logic.
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
        If D.IsReady  Then
            Test_4 = True
        Message += "Test 4 <Result> |OK| The Drive is Online."
        Else
            Test_4 = False
        Message += "Test 4 <Result> |PB| The Drive is Offline or Disconnected."
        End If
 #End Region 
 #Region "Test 5 | Evaluate if there is a Password."
        If Not IsDbNull(Password) Then
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
                    Me.Connector = New LineInfo(FilePath,Password)
                    Me.Line = Me.Connector.Line
        Message += "Test 6 <Result> |Initialize Connector|"
                End If
        End If
 #End Region 
 #Region "Test 7 | Evaluate if Connector Line is not empty."
        If Not IsDbNull(Me.Connector.Line) Then
            Test_7 = True
        Else 
            Test_7 = False
        End If
 #End Region 
 #Region "Test 8 | Evaluate if the Connection is valid."
        If Test_7 =True Then
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
 If Test_7=True And Test_8 = True Then
    General_Status=True
 Else 
    General_Status=False
 End If
 Log+=Message & VbNewLine
 Return General_Status

   End Function
#End Region '(Set|Get) Evaluate the connection to the DataBase

#End Region 
#Region "<6> [Runtime]{12}"
#Region"[On] |2019/07/06 00h51:878| <15.00.00> <Runtime> <> |.Table()|Table"' (Set|Get) The Table.
    '''    <Summary>
'''     (Set|Get) The Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:099 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The Table.") >
   Public  Table As Table
#End Region '(Set|Get) The Table.

#Region"[On] |2019/07/06 00h51:893| <15.00.01> <Runtime> <> |.Line()|String"' (Set|Get) The Connection String To the Table.
    '''    <Summary>
'''     (Set|Get) The Connection String To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:100 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The Connection String To the Table.") >
   Public  Line As String
#End Region '(Set|Get) The Connection String To the Table.

#Region"[On] |2019/07/06 00h51:917| <15.00.02> <Runtime> <> |.FilePath()|String"' (Set|Get) The FilePath To the Table.
    '''    <Summary>
'''     (Set|Get) The FilePath To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:100 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The FilePath To the Table.") >
   Public  FilePath As String
#End Region '(Set|Get) The FilePath To the Table.

#Region"[On] |2019/07/06 00h51:932| <15.00.03> <Runtime> <> |.Password()|String"' (Set|Get) The Password To the Table.
    '''    <Summary>
'''     (Set|Get) The Password To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:100 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The Password To the Table.") >
   Public  Password As String
#End Region '(Set|Get) The Password To the Table.

#Region"[On] |2019/07/06 00h51:946| <15.00.04> <Runtime> <> |.UseSQL()|Boolean"' (Set|Get) Determines if the Database Connection is of type SQL.
    '''    <Summary>
'''     (Set|Get) Determines if the Database Connection is of type SQL.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:101 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) Determines if the Database Connection is of type SQL.") >
   Public  UseSQL As Boolean
#End Region '(Set|Get) Determines if the Database Connection is of type SQL.

#Region"[On] |2019/07/06 00h51:959| <15.00.05> <Runtime> <> |.TableName()|String"' (Set|Get) The name of the Table.
    '''    <Summary>
'''     (Set|Get) The name of the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:101 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The name of the Table.") >
   Public  TableName As String
#End Region '(Set|Get) The name of the Table.

#Region"[On] |2019/07/06 00h51:975| <15.00.06> <Runtime> <> |.Con()|OleDb.OleDbConnection"' (Set|Get) The Con To the Table.
    '''    <Summary>
'''     (Set|Get) The Con To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:101 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The Con To the Table.") >
   Public  Con As OleDb.OleDbConnection
#End Region '(Set|Get) The Con To the Table.

#Region"[On] |2019/07/06 00h51:981| <15.00.07> <Runtime> <> |.Cmd()|OleDb.OleDbCommand"' (Set|Get) The Cmd To the Table.
    '''    <Summary>
'''     (Set|Get) The Cmd To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:101 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The Cmd To the Table.") >
   Public  Cmd As OleDb.OleDbCommand
#End Region '(Set|Get) The Cmd To the Table.

#Region"[On] |2019/07/06 00h51:995| <15.00.08> <Runtime> <> |.DataReader()|OleDb.OleDbDataReader"' (Set|Get) The DataReader To the Table.
    '''    <Summary>
'''     (Set|Get) The DataReader To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:101 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The DataReader To the Table.") >
   Public  DataReader As OleDb.OleDbDataReader
#End Region '(Set|Get) The DataReader To the Table.

#Region"[On] |2019/07/06 00h51:009| <15.00.09> <Runtime> <> |.DataAdapter()|OleDb.OleDbDataAdapter"' (Set|Get) The DataAdapter To the Table.
    '''    <Summary>
'''     (Set|Get) The DataAdapter To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:102 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The DataAdapter To the Table.") >
   Public  DataAdapter As OleDb.OleDbDataAdapter
#End Region '(Set|Get) The DataAdapter To the Table.

#Region"[On] |2019/07/06 00h51:023| <15.00.10> <Runtime> <> |.Connector()|LineInfo"' (Set|Get) The Connector To the Table.
    '''    <Summary>
'''     (Set|Get) The Connector To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:102 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The Connector To the Table.") >
   Public  Connector As LineInfo
#End Region '(Set|Get) The Connector To the Table.

#Region"[On] |2019/07/06 00h51:037| <15.00.11> <Runtime> <> |.Log()|String"' (Set|Get) The Log To the Table.
    '''    <Summary>
'''     (Set|Get) The Log To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:102 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The Log To the Table.") >
   Public  Log As String
#End Region '(Set|Get) The Log To the Table.

#End Region 
#Region "<7> [Loader]{2}"
#Region"[On] |2019/07/06 00h51:052| <06.00.00> <Loader> <> |.Empty()|Function}|"' (Set|Get) The sub Empty.
    '''    <Summary>
'''     (Set|Get) The sub Empty.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:103 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The sub Empty.") >
   Public Sub New ()
Reset
   End Sub
#End Region '(Set|Get) The sub Empty.

#Region"[On] |2019/07/06 00h51:063| <06.00.01> <Loader> <> |.Filled()|Function}|"' (Set|Get) The sub Filled.
    '''    <Summary>
'''     (Set|Get) The sub Filled.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:103 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>    ''' <param name="ID">(Set|Get) The ID as Integer.</param>
    ''' <param name="Name">(Set|Get) The Name as String.</param>
    ''' <param name="ImageIndex">(Set|Get) The ImageIndex as Integer.</param>
    ''' <param name="Text">(Set|Get) The Text as String.</param>
    ''' <param name="ToolTip">(Set|Get) The ToolTip as String.</param>
    ''' <param name="Enable">(Set|Get) The Enable as Boolean.</param>
    ''' <param name="Status">(Set|Get) The Status as String.</param>
    ''' <param name="Statement">(Set|Get) The Statement as String.</param>
    ''' <param name="XMLFile">(Set|Get) The XMLFile as String.</param>
    ''' <param name="Attributes">(Set|Get) The Attributes as String.</param>
    ''' <param name="Browsable">(Set|Get) The Browsable as Boolean.</param>
    ''' <param name="Category">(Set|Get) The Category as String.</param>
    ''' <param name="Description">(Set|Get) The Description as String.</param>
    ''' <param name="DefaultValue">(Set|Get) The DefaultValue as String.</param>
    ''' <param name="Editor">(Set|Get) The Editor as String.</param>
    ''' <param name="DllImport">(Set|Get) The DllImport as String.</param>
    ''' <param name="Deserializable">(Set|Get) The Deserializable as Boolean.</param>
    ''' <param name="NonSerialized">(Set|Get) The NonSerialized as Boolean.</param>
    ''' <param name="Serializable">(Set|Get) The Serializable as Boolean.</param>
    ''' <param name="XmlRoot">(Set|Get) The XmlRoot as String.</param>
    ''' <param name="XmlIgnore">(Set|Get) The XmlIgnore as Boolean.</param>
    ''' <param name="XmlInclude">(Set|Get) The XmlInclude as Boolean.</param>
    ''' <param name="RelatedImageList">(Set|Get) The RelatedImageList as String.</param>
    ''' <param name="Print_VB">(Set|Get) The Print_VB as String.</param>
    ''' <param name="VB">(Set|Get) The VB as String.</param>
    ''' <param name="Print_C">(Set|Get) The Print_C as String.</param>
    ''' <param name="C">(Set|Get) The C as String.</param>
    ''' <param name="Print_F">(Set|Get) The Print_F as String.</param>
    ''' <param name="F">(Set|Get) The F as String.</param>
    ''' <param name="Print_Python">(Set|Get) The Print_Python as String.</param>
    ''' <param name="Python">(Set|Get) The Python as String.</param>
    ''' <param name="Print_JavaScript">(Set|Get) The Print_JavaScript as String.</param>
    ''' <param name="JavaScript">(Set|Get) The JavaScript as String.</param>
    ''' <param name="RegionCategory">(Set|Get) The RegionCategory as Integer.</param>
    ''' <param name="RegionCode">(Set|Get) The RegionCode as String.</param>
    ''' <param name="AuthorEmail">(Set|Get) The AuthorEmail as String.</param>
    ''' <param name="AuthorName">(Set|Get) The AuthorName as String.</param>
    ''' <param name="AuthorUri">(Set|Get) The AuthorUri as String.</param>
    ''' <param name="ContributorEmail">(Set|Get) The ContributorEmail as String.</param>
    ''' <param name="ContributorName">(Set|Get) The ContributorName as String.</param>
    ''' <param name="ContributorUri">(Set|Get) The ContributorUri as String.</param>
    ''' <param name="CustomProperty">(Set|Get) The CustomProperty as String.</param>
    ''' <param name="Published">(Set|Get) The Published as String.</param>
    ''' <param name="Rights">(Set|Get) The Rights as String.</param>
    ''' <param name="Summary">(Set|Get) The Summary as String.</param>
    ''' <param name="Title">(Set|Get) The Title as String.</param>
    ''' <param name="Updated">(Set|Get) The Updated as String.</param>
    ''' <param name="Usage">(Set|Get) The Usage as String.</param>
    ''' <param name="Remarks">(Set|Get) The Remarks as String.</param>
    ''' <param name="Example">(Set|Get) The Example as String.</param>
    ''' <param name="Note">(Set|Get) The Note as String.</param>
    ''' <param name="CreationDate">(Set|Get) The CreationDate as String.</param>
    ''' <param name="See">(Set|Get) The See as String.</param>
    ''' <param name="SeeAlso">(Set|Get) The SeeAlso as String.</param>
    ''' <param name="Rules">(Set|Get) The Rules as String.</param>
    ''' <param name="Syntax">(Set|Get) The Syntax as String.</param>
    ''' <param name="AccessModifier">(Set|Get) The AccessModifier as String.</param>
    ''' <param name="Shadows">(Set|Get) The Shadows as Boolean.</param>
    ''' <param name="Partial">(Set|Get) The Partial as Boolean.</param>
    ''' <param name="Typelist">(Set|Get) The Typelist as String.</param>
    ''' <param name="StructureName">(Set|Get) The StructureName as String.</param>
    ''' <param name="Implements">(Set|Get) The Implements as String.</param>

    <Browsable(True) , Description("(Set|Get) The sub Filled.") >
   Public Sub New (ByVal ID As Integer, 
ByVal Name As String, 
ByVal ImageIndex As Integer, 
ByVal Text As String, 
ByVal ToolTip As String, 
ByVal Enable As Boolean, 
ByVal Status As String, 
ByVal Statement As String, 
ByVal XMLFile As String, 
ByVal Attributes As String, 
ByVal Browsable As Boolean, 
ByVal Category As String, 
ByVal Description As String, 
ByVal DefaultValue As String, 
ByVal Editor As String, 
ByVal DllImport As String, 
ByVal Deserializable As Boolean, 
ByVal NonSerialized As Boolean, 
ByVal Serializable As Boolean, 
ByVal XmlRoot As String, 
ByVal XmlIgnore As Boolean, 
ByVal XmlInclude As Boolean, 
ByVal RelatedImageList As String, 
ByVal Print_VB As String, 
ByVal VB As String, 
ByVal Print_C As String, 
ByVal C As String, 
ByVal Print_F As String, 
ByVal F As String, 
ByVal Print_Python As String, 
ByVal Python As String, 
ByVal Print_JavaScript As String, 
ByVal JavaScript As String, 
ByVal RegionCategory As Integer, 
ByVal RegionCode As String, 
ByVal AuthorEmail As String, 
ByVal AuthorName As String, 
ByVal AuthorUri As String, 
ByVal ContributorEmail As String, 
ByVal ContributorName As String, 
ByVal ContributorUri As String, 
ByVal CustomProperty As String, 
ByVal Published As String, 
ByVal Rights As String, 
ByVal Summary As String, 
ByVal Title As String, 
ByVal Updated As String, 
ByVal Usage As String, 
ByVal Remarks As String, 
ByVal Example As String, 
ByVal Note As String, 
ByVal CreationDate As String, 
ByVal See As String, 
ByVal SeeAlso As String, 
ByVal Rules As String, 
ByVal Syntax As String, 
ByVal AccessModifier As String, 
ByVal Shadows As Boolean, 
ByVal Partial As Boolean, 
ByVal Typelist As String, 
ByVal StructureName As String, 
ByVal Implements As String)
 With Me
 Clear()
 Reset()
     .ID = ID
     .Name = Name
     .ImageIndex = ImageIndex
     .Text = Text
     .ToolTip = ToolTip
     .Enable = Enable
     .Status = Status
     .Statement = Statement
     .XMLFile = XMLFile
     .Attributes = Attributes
     .Browsable = Browsable
     .Category = Category
     .Description = Description
     .DefaultValue = DefaultValue
     .Editor = Editor
     .DllImport = DllImport
     .Deserializable = Deserializable
     .NonSerialized = NonSerialized
     .Serializable = Serializable
     .XmlRoot = XmlRoot
     .XmlIgnore = XmlIgnore
     .XmlInclude = XmlInclude
     .RelatedImageList = RelatedImageList
     .Print_VB = Print_VB
     .VB = VB
     .Print_C = Print_C
     .C = C
     .Print_F = Print_F
     .F = F
     .Print_Python = Print_Python
     .Python = Python
     .Print_JavaScript = Print_JavaScript
     .JavaScript = JavaScript
     .RegionCategory = RegionCategory
     .RegionCode = RegionCode
     .AuthorEmail = AuthorEmail
     .AuthorName = AuthorName
     .AuthorUri = AuthorUri
     .ContributorEmail = ContributorEmail
     .ContributorName = ContributorName
     .ContributorUri = ContributorUri
     .CustomProperty = CustomProperty
     .Published = Published
     .Rights = Rights
     .Summary = Summary
     .Title = Title
     .Updated = Updated
     .Usage = Usage
     .Remarks = Remarks
     .Example = Example
     .Note = Note
     .CreationDate = CreationDate
     .See = See
     .SeeAlso = SeeAlso
     .Rules = Rules
     .Syntax = Syntax
     .AccessModifier = AccessModifier
     .Shadows = Shadows
     .Partial = Partial
     .Typelist = Typelist
     .StructureName = StructureName
     .Implements = Implements
 End With

   End Sub
#End Region '(Set|Get) The sub Filled.

#End Region 
 End Class
#End Region

#Region"[On] |2019/07/06 00h51:307| <08.00.00> <Class> <> |.Sub|Class|{92} |Production Cost : 143.5|Selling Price : 358.75|"' Class created automatically by SmartOffice (c)Copyright 2019.
'''    <Summary>
'''     Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Sub
'''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
'''    Contributor Information : ||
'''    Creation Date :           2019/07/06 00h51:307
'''    |Schema|
'''    |ID| |ObjectType |{Quantity}||UnitPrice||Total
'''    |00| |Importation|{0}||1| |0
'''    |01| |Properties |{65}||0.8| |52
'''    |02| |Enumeration|{1}||0.4| |0.4
'''    |03| |Structure  |{0}||0.4| |0
'''    |04| |Sub        |{5}||1.2| |6
'''    |05| |Function   |{7}||1.6| |11.2
'''    |06| |Runtime    |{12}||0.4| |4.8
'''    |07| |Loader     |{2}||0.8| |1.6
'''    |08| |Class      |{0}||2| |0
'''    |09| |Constante  |{0}||0.4| |0
'''    |10| |Event      |{0}||1.2| |0
'''    |11| |Members    |{65}||0.5| |32.5
'''    |12| |Parameter  |{70}||0.5| |35
'''    |Production Cost             |143.5
'''    |Selling Price without VAT   |358.75
'''    |Total TVA                   |27.62
'''    |Grand Total                 |386.37
'''    |/Schema|
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:151 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
Public  Class Sub
#Region "<1> [Property]{65}"
#Region"[On] |2019/07/06 00h51:308| <01.00.00> <Property> <Columns> |.ID()|Integer|"' (Set|Get) The ID as Integer.
   Private _ID As Integer
    '''    <Summary>
'''     (Set|Get) The ID as Integer.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:154 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ID as Integer.") >
   Public Property ID()As Integer
       Get
       Return _ID
       End Get
       Set(ByVal Value As Integer)
       _ID = Value
       End Set
   End Property
#End Region '(Set|Get) The ID as Integer.

#Region"[On] |2019/07/06 00h51:319| <01.00.01> <Property> <Columns> |.Name()|String|"' (Set|Get) The Name as String.
   Private _Name As String
    '''    <Summary>
'''     (Set|Get) The Name as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:154 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Name as String.") >
   Public Property Name()As String
       Get
       Return _Name
       End Get
       Set(ByVal Value As String)
       _Name = Value
       End Set
   End Property
#End Region '(Set|Get) The Name as String.

#Region"[On] |2019/07/06 00h51:329| <01.00.02> <Property> <Columns> |.ImageIndex()|Integer|"' (Set|Get) The ImageIndex as Integer.
   Private _ImageIndex As Integer
    '''    <Summary>
'''     (Set|Get) The ImageIndex as Integer.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:154 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ImageIndex as Integer.") >
   Public Property ImageIndex()As Integer
       Get
       Return _ImageIndex
       End Get
       Set(ByVal Value As Integer)
       _ImageIndex = Value
       End Set
   End Property
#End Region '(Set|Get) The ImageIndex as Integer.

#Region"[On] |2019/07/06 00h51:340| <01.00.03> <Property> <Columns> |.Text()|String|"' (Set|Get) The Text as String.
   Private _Text As String
    '''    <Summary>
'''     (Set|Get) The Text as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:157 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Text as String.") >
   Public Property Text()As String
       Get
       Return _Text
       End Get
       Set(ByVal Value As String)
       _Text = Value
       End Set
   End Property
#End Region '(Set|Get) The Text as String.

#Region"[On] |2019/07/06 00h51:352| <01.00.04> <Property> <Columns> |.ToolTip()|String|"' (Set|Get) The ToolTip as String.
   Private _ToolTip As String
    '''    <Summary>
'''     (Set|Get) The ToolTip as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:157 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ToolTip as String.") >
   Public Property ToolTip()As String
       Get
       Return _ToolTip
       End Get
       Set(ByVal Value As String)
       _ToolTip = Value
       End Set
   End Property
#End Region '(Set|Get) The ToolTip as String.

#Region"[On] |2019/07/06 00h51:362| <01.00.05> <Property> <Columns> |.Enable()|Boolean|"' (Set|Get) The Enable as Boolean.
   Private _Enable As Boolean
    '''    <Summary>
'''     (Set|Get) The Enable as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:157 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Enable as Boolean.") >
   Public Property Enable()As Boolean
       Get
       Return _Enable
       End Get
       Set(ByVal Value As Boolean)
       _Enable = Value
       End Set
   End Property
#End Region '(Set|Get) The Enable as Boolean.

#Region"[On] |2019/07/06 00h51:372| <01.00.06> <Property> <Columns> |.Status()|String|"' (Set|Get) The Status as String.
   Private _Status As String
    '''    <Summary>
'''     (Set|Get) The Status as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:157 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Status as String.") >
   Public Property Status()As String
       Get
       Return _Status
       End Get
       Set(ByVal Value As String)
       _Status = Value
       End Set
   End Property
#End Region '(Set|Get) The Status as String.

#Region"[On] |2019/07/06 00h51:383| <01.00.07> <Property> <Columns> |.Statement()|String|"' (Set|Get) The Statement as String.
   Private _Statement As String
    '''    <Summary>
'''     (Set|Get) The Statement as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:158 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Statement as String.") >
   Public Property Statement()As String
       Get
       Return _Statement
       End Get
       Set(ByVal Value As String)
       _Statement = Value
       End Set
   End Property
#End Region '(Set|Get) The Statement as String.

#Region"[On] |2019/07/06 00h51:394| <01.00.08> <Property> <Columns> |.XMLFile()|String|"' (Set|Get) The XMLFile as String.
   Private _XMLFile As String
    '''    <Summary>
'''     (Set|Get) The XMLFile as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:158 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XMLFile as String.") >
   Public Property XMLFile()As String
       Get
       Return _XMLFile
       End Get
       Set(ByVal Value As String)
       _XMLFile = Value
       End Set
   End Property
#End Region '(Set|Get) The XMLFile as String.

#Region"[On] |2019/07/06 00h51:404| <01.00.09> <Property> <Columns> |.Attributes()|String|"' (Set|Get) The Attributes as String.
   Private _Attributes As String
    '''    <Summary>
'''     (Set|Get) The Attributes as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:161 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Attributes as String.") >
   Public Property Attributes()As String
       Get
       Return _Attributes
       End Get
       Set(ByVal Value As String)
       _Attributes = Value
       End Set
   End Property
#End Region '(Set|Get) The Attributes as String.

#Region"[On] |2019/07/06 00h51:416| <01.00.10> <Property> <Columns> |.Browsable()|Boolean|"' (Set|Get) The Browsable as Boolean.
   Private _Browsable As Boolean
    '''    <Summary>
'''     (Set|Get) The Browsable as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:161 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Browsable as Boolean.") >
   Public Property Browsable()As Boolean
       Get
       Return _Browsable
       End Get
       Set(ByVal Value As Boolean)
       _Browsable = Value
       End Set
   End Property
#End Region '(Set|Get) The Browsable as Boolean.

#Region"[On] |2019/07/06 00h51:426| <01.00.11> <Property> <Columns> |.Category()|String|"' (Set|Get) The Category as String.
   Private _Category As String
    '''    <Summary>
'''     (Set|Get) The Category as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:161 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Category as String.") >
   Public Property Category()As String
       Get
       Return _Category
       End Get
       Set(ByVal Value As String)
       _Category = Value
       End Set
   End Property
#End Region '(Set|Get) The Category as String.

#Region"[On] |2019/07/06 00h51:437| <01.00.12> <Property> <Columns> |.Description()|String|"' (Set|Get) The Description as String.
   Private _Description As String
    '''    <Summary>
'''     (Set|Get) The Description as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:161 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Description as String.") >
   Public Property Description()As String
       Get
       Return _Description
       End Get
       Set(ByVal Value As String)
       _Description = Value
       End Set
   End Property
#End Region '(Set|Get) The Description as String.

#Region"[On] |2019/07/06 00h51:448| <01.00.13> <Property> <Columns> |.DefaultValue()|String|"' (Set|Get) The DefaultValue as String.
   Private _DefaultValue As String
    '''    <Summary>
'''     (Set|Get) The DefaultValue as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:162 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The DefaultValue as String.") >
   Public Property DefaultValue()As String
       Get
       Return _DefaultValue
       End Get
       Set(ByVal Value As String)
       _DefaultValue = Value
       End Set
   End Property
#End Region '(Set|Get) The DefaultValue as String.

#Region"[On] |2019/07/06 00h51:460| <01.00.14> <Property> <Columns> |.Editor()|String|"' (Set|Get) The Editor as String.
   Private _Editor As String
    '''    <Summary>
'''     (Set|Get) The Editor as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:162 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Editor as String.") >
   Public Property Editor()As String
       Get
       Return _Editor
       End Get
       Set(ByVal Value As String)
       _Editor = Value
       End Set
   End Property
#End Region '(Set|Get) The Editor as String.

#Region"[On] |2019/07/06 00h51:471| <01.00.15> <Property> <Columns> |.DllImport()|String|"' (Set|Get) The DllImport as String.
   Private _DllImport As String
    '''    <Summary>
'''     (Set|Get) The DllImport as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:162 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The DllImport as String.") >
   Public Property DllImport()As String
       Get
       Return _DllImport
       End Get
       Set(ByVal Value As String)
       _DllImport = Value
       End Set
   End Property
#End Region '(Set|Get) The DllImport as String.

#Region"[On] |2019/07/06 00h51:490| <01.00.16> <Property> <Columns> |.Deserializable()|Boolean|"' (Set|Get) The Deserializable as Boolean.
   Private _Deserializable As Boolean
    '''    <Summary>
'''     (Set|Get) The Deserializable as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:162 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Deserializable as Boolean.") >
   Public Property Deserializable()As Boolean
       Get
       Return _Deserializable
       End Get
       Set(ByVal Value As Boolean)
       _Deserializable = Value
       End Set
   End Property
#End Region '(Set|Get) The Deserializable as Boolean.

#Region"[On] |2019/07/06 00h51:501| <01.00.17> <Property> <Columns> |.NonSerialized()|Boolean|"' (Set|Get) The NonSerialized as Boolean.
   Private _NonSerialized As Boolean
    '''    <Summary>
'''     (Set|Get) The NonSerialized as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:165 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The NonSerialized as Boolean.") >
   Public Property NonSerialized()As Boolean
       Get
       Return _NonSerialized
       End Get
       Set(ByVal Value As Boolean)
       _NonSerialized = Value
       End Set
   End Property
#End Region '(Set|Get) The NonSerialized as Boolean.

#Region"[On] |2019/07/06 00h51:513| <01.00.18> <Property> <Columns> |.Serializable()|Boolean|"' (Set|Get) The Serializable as Boolean.
   Private _Serializable As Boolean
    '''    <Summary>
'''     (Set|Get) The Serializable as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:165 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Serializable as Boolean.") >
   Public Property Serializable()As Boolean
       Get
       Return _Serializable
       End Get
       Set(ByVal Value As Boolean)
       _Serializable = Value
       End Set
   End Property
#End Region '(Set|Get) The Serializable as Boolean.

#Region"[On] |2019/07/06 00h51:524| <01.00.19> <Property> <Columns> |.XmlRoot()|String|"' (Set|Get) The XmlRoot as String.
   Private _XmlRoot As String
    '''    <Summary>
'''     (Set|Get) The XmlRoot as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:165 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XmlRoot as String.") >
   Public Property XmlRoot()As String
       Get
       Return _XmlRoot
       End Get
       Set(ByVal Value As String)
       _XmlRoot = Value
       End Set
   End Property
#End Region '(Set|Get) The XmlRoot as String.

#Region"[On] |2019/07/06 00h51:535| <01.00.20> <Property> <Columns> |.XmlIgnore()|Boolean|"' (Set|Get) The XmlIgnore as Boolean.
   Private _XmlIgnore As Boolean
    '''    <Summary>
'''     (Set|Get) The XmlIgnore as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:166 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XmlIgnore as Boolean.") >
   Public Property XmlIgnore()As Boolean
       Get
       Return _XmlIgnore
       End Get
       Set(ByVal Value As Boolean)
       _XmlIgnore = Value
       End Set
   End Property
#End Region '(Set|Get) The XmlIgnore as Boolean.

#Region"[On] |2019/07/06 00h51:548| <01.00.21> <Property> <Columns> |.XmlInclude()|Boolean|"' (Set|Get) The XmlInclude as Boolean.
   Private _XmlInclude As Boolean
    '''    <Summary>
'''     (Set|Get) The XmlInclude as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:166 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XmlInclude as Boolean.") >
   Public Property XmlInclude()As Boolean
       Get
       Return _XmlInclude
       End Get
       Set(ByVal Value As Boolean)
       _XmlInclude = Value
       End Set
   End Property
#End Region '(Set|Get) The XmlInclude as Boolean.

#Region"[On] |2019/07/06 00h51:559| <01.00.22> <Property> <Columns> |.RelatedImageList()|String|"' (Set|Get) The RelatedImageList as String.
   Private _RelatedImageList As String
    '''    <Summary>
'''     (Set|Get) The RelatedImageList as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:166 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The RelatedImageList as String.") >
   Public Property RelatedImageList()As String
       Get
       Return _RelatedImageList
       End Get
       Set(ByVal Value As String)
       _RelatedImageList = Value
       End Set
   End Property
#End Region '(Set|Get) The RelatedImageList as String.

#Region"[On] |2019/07/06 00h51:571| <01.00.23> <Property> <Columns> |.Print_VB()|String|"' (Set|Get) The Print_VB as String.
   Private _Print_VB As String
    '''    <Summary>
'''     (Set|Get) The Print_VB as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:166 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_VB as String.") >
   Public Property Print_VB()As String
       Get
       Return _Print_VB
       End Get
       Set(ByVal Value As String)
       _Print_VB = Value
       End Set
   End Property
#End Region '(Set|Get) The Print_VB as String.

#Region"[On] |2019/07/06 00h51:582| <01.00.24> <Property> <Columns> |.VB()|String|"' (Set|Get) The VB as String.
   Private _VB As String
    '''    <Summary>
'''     (Set|Get) The VB as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:166 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The VB as String.") >
   Public Property VB()As String
       Get
       Return _VB
       End Get
       Set(ByVal Value As String)
       _VB = Value
       End Set
   End Property
#End Region '(Set|Get) The VB as String.

#Region"[On] |2019/07/06 00h51:594| <01.00.25> <Property> <Columns> |.Print_C()|String|"' (Set|Get) The Print_C as String.
   Private _Print_C As String
    '''    <Summary>
'''     (Set|Get) The Print_C as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:167 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_C as String.") >
   Public Property Print_C()As String
       Get
       Return _Print_C
       End Get
       Set(ByVal Value As String)
       _Print_C = Value
       End Set
   End Property
#End Region '(Set|Get) The Print_C as String.

#Region"[On] |2019/07/06 00h51:605| <01.00.26> <Property> <Columns> |.C()|String|"' (Set|Get) The C as String.
   Private _C As String
    '''    <Summary>
'''     (Set|Get) The C as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:170 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The C as String.") >
   Public Property C()As String
       Get
       Return _C
       End Get
       Set(ByVal Value As String)
       _C = Value
       End Set
   End Property
#End Region '(Set|Get) The C as String.

#Region"[On] |2019/07/06 00h51:617| <01.00.27> <Property> <Columns> |.Print_F()|String|"' (Set|Get) The Print_F as String.
   Private _Print_F As String
    '''    <Summary>
'''     (Set|Get) The Print_F as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:170 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_F as String.") >
   Public Property Print_F()As String
       Get
       Return _Print_F
       End Get
       Set(ByVal Value As String)
       _Print_F = Value
       End Set
   End Property
#End Region '(Set|Get) The Print_F as String.

#Region"[On] |2019/07/06 00h51:629| <01.00.28> <Property> <Columns> |.F()|String|"' (Set|Get) The F as String.
   Private _F As String
    '''    <Summary>
'''     (Set|Get) The F as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:170 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The F as String.") >
   Public Property F()As String
       Get
       Return _F
       End Get
       Set(ByVal Value As String)
       _F = Value
       End Set
   End Property
#End Region '(Set|Get) The F as String.

#Region"[On] |2019/07/06 00h51:640| <01.00.29> <Property> <Columns> |.Print_Python()|String|"' (Set|Get) The Print_Python as String.
   Private _Print_Python As String
    '''    <Summary>
'''     (Set|Get) The Print_Python as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:170 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_Python as String.") >
   Public Property Print_Python()As String
       Get
       Return _Print_Python
       End Get
       Set(ByVal Value As String)
       _Print_Python = Value
       End Set
   End Property
#End Region '(Set|Get) The Print_Python as String.

#Region"[On] |2019/07/06 00h51:652| <01.00.30> <Property> <Columns> |.Python()|String|"' (Set|Get) The Python as String.
   Private _Python As String
    '''    <Summary>
'''     (Set|Get) The Python as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:172 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Python as String.") >
   Public Property Python()As String
       Get
       Return _Python
       End Get
       Set(ByVal Value As String)
       _Python = Value
       End Set
   End Property
#End Region '(Set|Get) The Python as String.

#Region"[On] |2019/07/06 00h51:664| <01.00.31> <Property> <Columns> |.Print_JavaScript()|String|"' (Set|Get) The Print_JavaScript as String.
   Private _Print_JavaScript As String
    '''    <Summary>
'''     (Set|Get) The Print_JavaScript as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:172 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_JavaScript as String.") >
   Public Property Print_JavaScript()As String
       Get
       Return _Print_JavaScript
       End Get
       Set(ByVal Value As String)
       _Print_JavaScript = Value
       End Set
   End Property
#End Region '(Set|Get) The Print_JavaScript as String.

#Region"[On] |2019/07/06 00h51:676| <01.00.32> <Property> <Columns> |.JavaScript()|String|"' (Set|Get) The JavaScript as String.
   Private _JavaScript As String
    '''    <Summary>
'''     (Set|Get) The JavaScript as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:173 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The JavaScript as String.") >
   Public Property JavaScript()As String
       Get
       Return _JavaScript
       End Get
       Set(ByVal Value As String)
       _JavaScript = Value
       End Set
   End Property
#End Region '(Set|Get) The JavaScript as String.

#Region"[On] |2019/07/06 00h51:689| <01.00.33> <Property> <Columns> |.RegionCategory()|Integer|"' (Set|Get) The RegionCategory as Integer.
   Private _RegionCategory As Integer
    '''    <Summary>
'''     (Set|Get) The RegionCategory as Integer.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:173 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The RegionCategory as Integer.") >
   Public Property RegionCategory()As Integer
       Get
       Return _RegionCategory
       End Get
       Set(ByVal Value As Integer)
       _RegionCategory = Value
       End Set
   End Property
#End Region '(Set|Get) The RegionCategory as Integer.

#Region"[On] |2019/07/06 00h51:701| <01.00.34> <Property> <Columns> |.RegionCode()|String|"' (Set|Get) The RegionCode as String.
   Private _RegionCode As String
    '''    <Summary>
'''     (Set|Get) The RegionCode as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:176 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The RegionCode as String.") >
   Public Property RegionCode()As String
       Get
       Return _RegionCode
       End Get
       Set(ByVal Value As String)
       _RegionCode = Value
       End Set
   End Property
#End Region '(Set|Get) The RegionCode as String.

#Region"[On] |2019/07/06 00h51:713| <01.00.35> <Property> <Columns> |.AuthorEmail()|String|"' (Set|Get) The AuthorEmail as String.
   Private _AuthorEmail As String
    '''    <Summary>
'''     (Set|Get) The AuthorEmail as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:176 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AuthorEmail as String.") >
   Public Property AuthorEmail()As String
       Get
       Return _AuthorEmail
       End Get
       Set(ByVal Value As String)
       _AuthorEmail = Value
       End Set
   End Property
#End Region '(Set|Get) The AuthorEmail as String.

#Region"[On] |2019/07/06 00h51:725| <01.00.36> <Property> <Columns> |.AuthorName()|String|"' (Set|Get) The AuthorName as String.
   Private _AuthorName As String
    '''    <Summary>
'''     (Set|Get) The AuthorName as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:176 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AuthorName as String.") >
   Public Property AuthorName()As String
       Get
       Return _AuthorName
       End Get
       Set(ByVal Value As String)
       _AuthorName = Value
       End Set
   End Property
#End Region '(Set|Get) The AuthorName as String.

#Region"[On] |2019/07/06 00h51:747| <01.00.37> <Property> <Columns> |.AuthorUri()|String|"' (Set|Get) The AuthorUri as String.
   Private _AuthorUri As String
    '''    <Summary>
'''     (Set|Get) The AuthorUri as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:177 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AuthorUri as String.") >
   Public Property AuthorUri()As String
       Get
       Return _AuthorUri
       End Get
       Set(ByVal Value As String)
       _AuthorUri = Value
       End Set
   End Property
#End Region '(Set|Get) The AuthorUri as String.

#Region"[On] |2019/07/06 00h51:759| <01.00.38> <Property> <Columns> |.ContributorEmail()|String|"' (Set|Get) The ContributorEmail as String.
   Private _ContributorEmail As String
    '''    <Summary>
'''     (Set|Get) The ContributorEmail as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:177 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ContributorEmail as String.") >
   Public Property ContributorEmail()As String
       Get
       Return _ContributorEmail
       End Get
       Set(ByVal Value As String)
       _ContributorEmail = Value
       End Set
   End Property
#End Region '(Set|Get) The ContributorEmail as String.

#Region"[On] |2019/07/06 00h51:771| <01.00.39> <Property> <Columns> |.ContributorName()|String|"' (Set|Get) The ContributorName as String.
   Private _ContributorName As String
    '''    <Summary>
'''     (Set|Get) The ContributorName as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:177 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ContributorName as String.") >
   Public Property ContributorName()As String
       Get
       Return _ContributorName
       End Get
       Set(ByVal Value As String)
       _ContributorName = Value
       End Set
   End Property
#End Region '(Set|Get) The ContributorName as String.

#Region"[On] |2019/07/06 00h51:783| <01.00.40> <Property> <Columns> |.ContributorUri()|String|"' (Set|Get) The ContributorUri as String.
   Private _ContributorUri As String
    '''    <Summary>
'''     (Set|Get) The ContributorUri as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:177 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ContributorUri as String.") >
   Public Property ContributorUri()As String
       Get
       Return _ContributorUri
       End Get
       Set(ByVal Value As String)
       _ContributorUri = Value
       End Set
   End Property
#End Region '(Set|Get) The ContributorUri as String.

#Region"[On] |2019/07/06 00h51:797| <01.00.41> <Property> <Columns> |.CustomProperty()|String|"' (Set|Get) The CustomProperty as String.
   Private _CustomProperty As String
    '''    <Summary>
'''     (Set|Get) The CustomProperty as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:178 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The CustomProperty as String.") >
   Public Property CustomProperty()As String
       Get
       Return _CustomProperty
       End Get
       Set(ByVal Value As String)
       _CustomProperty = Value
       End Set
   End Property
#End Region '(Set|Get) The CustomProperty as String.

#Region"[On] |2019/07/06 00h51:809| <01.00.42> <Property> <Columns> |.Published()|String|"' (Set|Get) The Published as String.
   Private _Published As String
    '''    <Summary>
'''     (Set|Get) The Published as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:178 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Published as String.") >
   Public Property Published()As String
       Get
       Return _Published
       End Get
       Set(ByVal Value As String)
       _Published = Value
       End Set
   End Property
#End Region '(Set|Get) The Published as String.

#Region"[On] |2019/07/06 00h51:822| <01.00.43> <Property> <Columns> |.Rights()|String|"' (Set|Get) The Rights as String.
   Private _Rights As String
    '''    <Summary>
'''     (Set|Get) The Rights as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:181 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Rights as String.") >
   Public Property Rights()As String
       Get
       Return _Rights
       End Get
       Set(ByVal Value As String)
       _Rights = Value
       End Set
   End Property
#End Region '(Set|Get) The Rights as String.

#Region"[On] |2019/07/06 00h51:834| <01.00.44> <Property> <Columns> |.Summary()|String|"' (Set|Get) The Summary as String.
   Private _Summary As String
    '''    <Summary>
'''     (Set|Get) The Summary as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:182 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Summary as String.") >
   Public Property Summary()As String
       Get
       Return _Summary
       End Get
       Set(ByVal Value As String)
       _Summary = Value
       End Set
   End Property
#End Region '(Set|Get) The Summary as String.

#Region"[On] |2019/07/06 00h51:846| <01.00.45> <Property> <Columns> |.Title()|String|"' (Set|Get) The Title as String.
   Private _Title As String
    '''    <Summary>
'''     (Set|Get) The Title as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:182 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Title as String.") >
   Public Property Title()As String
       Get
       Return _Title
       End Get
       Set(ByVal Value As String)
       _Title = Value
       End Set
   End Property
#End Region '(Set|Get) The Title as String.

#Region"[On] |2019/07/06 00h51:860| <01.00.46> <Property> <Columns> |.Updated()|String|"' (Set|Get) The Updated as String.
   Private _Updated As String
    '''    <Summary>
'''     (Set|Get) The Updated as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:183 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Updated as String.") >
   Public Property Updated()As String
       Get
       Return _Updated
       End Get
       Set(ByVal Value As String)
       _Updated = Value
       End Set
   End Property
#End Region '(Set|Get) The Updated as String.

#Region"[On] |2019/07/06 00h51:873| <01.00.47> <Property> <Columns> |.Usage()|String|"' (Set|Get) The Usage as String.
   Private _Usage As String
    '''    <Summary>
'''     (Set|Get) The Usage as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:183 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Usage as String.") >
   Public Property Usage()As String
       Get
       Return _Usage
       End Get
       Set(ByVal Value As String)
       _Usage = Value
       End Set
   End Property
#End Region '(Set|Get) The Usage as String.

#Region"[On] |2019/07/06 00h51:886| <01.00.48> <Property> <Columns> |.Remarks()|String|"' (Set|Get) The Remarks as String.
   Private _Remarks As String
    '''    <Summary>
'''     (Set|Get) The Remarks as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:183 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Remarks as String.") >
   Public Property Remarks()As String
       Get
       Return _Remarks
       End Get
       Set(ByVal Value As String)
       _Remarks = Value
       End Set
   End Property
#End Region '(Set|Get) The Remarks as String.

#Region"[On] |2019/07/06 00h51:899| <01.00.49> <Property> <Columns> |.Example()|String|"' (Set|Get) The Example as String.
   Private _Example As String
    '''    <Summary>
'''     (Set|Get) The Example as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:184 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Example as String.") >
   Public Property Example()As String
       Get
       Return _Example
       End Get
       Set(ByVal Value As String)
       _Example = Value
       End Set
   End Property
#End Region '(Set|Get) The Example as String.

#Region"[On] |2019/07/06 00h51:911| <01.00.50> <Property> <Columns> |.Note()|String|"' (Set|Get) The Note as String.
   Private _Note As String
    '''    <Summary>
'''     (Set|Get) The Note as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:184 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Note as String.") >
   Public Property Note()As String
       Get
       Return _Note
       End Get
       Set(ByVal Value As String)
       _Note = Value
       End Set
   End Property
#End Region '(Set|Get) The Note as String.

#Region"[On] |2019/07/06 00h51:924| <01.00.51> <Property> <Columns> |.CreationDate()|String|"' (Set|Get) The CreationDate as String.
   Private _CreationDate As String
    '''    <Summary>
'''     (Set|Get) The CreationDate as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:185 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The CreationDate as String.") >
   Public Property CreationDate()As String
       Get
       Return _CreationDate
       End Get
       Set(ByVal Value As String)
       _CreationDate = Value
       End Set
   End Property
#End Region '(Set|Get) The CreationDate as String.

#Region"[On] |2019/07/06 00h51:936| <01.00.52> <Property> <Columns> |.See()|String|"' (Set|Get) The See as String.
   Private _See As String
    '''    <Summary>
'''     (Set|Get) The See as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:185 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The See as String.") >
   Public Property See()As String
       Get
       Return _See
       End Get
       Set(ByVal Value As String)
       _See = Value
       End Set
   End Property
#End Region '(Set|Get) The See as String.

#Region"[On] |2019/07/06 00h51:949| <01.00.53> <Property> <Columns> |.SeeAlso()|String|"' (Set|Get) The SeeAlso as String.
   Private _SeeAlso As String
    '''    <Summary>
'''     (Set|Get) The SeeAlso as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:185 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The SeeAlso as String.") >
   Public Property SeeAlso()As String
       Get
       Return _SeeAlso
       End Get
       Set(ByVal Value As String)
       _SeeAlso = Value
       End Set
   End Property
#End Region '(Set|Get) The SeeAlso as String.

#Region"[On] |2019/07/06 00h51:962| <01.00.54> <Property> <Columns> |.Rules()|String|"' (Set|Get) The Rules as String.
   Private _Rules As String
    '''    <Summary>
'''     (Set|Get) The Rules as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:186 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Rules as String.") >
   Public Property Rules()As String
       Get
       Return _Rules
       End Get
       Set(ByVal Value As String)
       _Rules = Value
       End Set
   End Property
#End Region '(Set|Get) The Rules as String.

#Region"[On] |2019/07/06 00h51:985| <01.00.55> <Property> <Columns> |.Syntax()|String|"' (Set|Get) The Syntax as String.
   Private _Syntax As String
    '''    <Summary>
'''     (Set|Get) The Syntax as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:186 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Syntax as String.") >
   Public Property Syntax()As String
       Get
       Return _Syntax
       End Get
       Set(ByVal Value As String)
       _Syntax = Value
       End Set
   End Property
#End Region '(Set|Get) The Syntax as String.

#Region"[On] |2019/07/06 00h51:999| <01.00.56> <Property> <Columns> |.AccessModifier()|String|"' (Set|Get) The AccessModifier as String.
   Private _AccessModifier As String
    '''    <Summary>
'''     (Set|Get) The AccessModifier as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:187 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AccessModifier as String.") >
   Public Property AccessModifier()As String
       Get
       Return _AccessModifier
       End Get
       Set(ByVal Value As String)
       _AccessModifier = Value
       End Set
   End Property
#End Region '(Set|Get) The AccessModifier as String.

#Region"[On] |2019/07/06 00h51:011| <01.00.57> <Property> <Columns> |.ProcedureModifier()|String|"' (Set|Get) The ProcedureModifier as String.
   Private _ProcedureModifier As String
    '''    <Summary>
'''     (Set|Get) The ProcedureModifier as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:187 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ProcedureModifier as String.") >
   Public Property ProcedureModifier()As String
       Get
       Return _ProcedureModifier
       End Get
       Set(ByVal Value As String)
       _ProcedureModifier = Value
       End Set
   End Property
#End Region '(Set|Get) The ProcedureModifier as String.

#Region"[On] |2019/07/06 00h51:024| <01.00.58> <Property> <Columns> |.Partial()|Boolean|"' (Set|Get) The Partial as Boolean.
   Private _Partial As Boolean
    '''    <Summary>
'''     (Set|Get) The Partial as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:188 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Partial as Boolean.") >
   Public Property Partial()As Boolean
       Get
       Return _Partial
       End Get
       Set(ByVal Value As Boolean)
       _Partial = Value
       End Set
   End Property
#End Region '(Set|Get) The Partial as Boolean.

#Region"[On] |2019/07/06 00h51:037| <01.00.59> <Property> <Columns> |.Shared()|Boolean|"' (Set|Get) The Shared as Boolean.
   Private _Shared As Boolean
    '''    <Summary>
'''     (Set|Get) The Shared as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:188 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Shared as Boolean.") >
   Public Property Shared()As Boolean
       Get
       Return _Shared
       End Get
       Set(ByVal Value As Boolean)
       _Shared = Value
       End Set
   End Property
#End Region '(Set|Get) The Shared as Boolean.

#Region"[On] |2019/07/06 00h51:050| <01.00.60> <Property> <Columns> |.Shadows()|Boolean|"' (Set|Get) The Shadows as Boolean.
   Private _Shadows As Boolean
    '''    <Summary>
'''     (Set|Get) The Shadows as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:189 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Shadows as Boolean.") >
   Public Property Shadows()As Boolean
       Get
       Return _Shadows
       End Get
       Set(ByVal Value As Boolean)
       _Shadows = Value
       End Set
   End Property
#End Region '(Set|Get) The Shadows as Boolean.

#Region"[On] |2019/07/06 00h51:065| <01.00.61> <Property> <Columns> |.Async()|Boolean|"' (Set|Get) The Async as Boolean.
   Private _Async As Boolean
    '''    <Summary>
'''     (Set|Get) The Async as Boolean.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:189 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Async as Boolean.") >
   Public Property Async()As Boolean
       Get
       Return _Async
       End Get
       Set(ByVal Value As Boolean)
       _Async = Value
       End Set
   End Property
#End Region '(Set|Get) The Async as Boolean.

#Region"[On] |2019/07/06 00h51:077| <01.00.62> <Property> <Columns> |.SubName()|String|"' (Set|Get) The SubName as String.
   Private _SubName As String
    '''    <Summary>
'''     (Set|Get) The SubName as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:190 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The SubName as String.") >
   Public Property SubName()As String
       Get
       Return _SubName
       End Get
       Set(ByVal Value As String)
       _SubName = Value
       End Set
   End Property
#End Region '(Set|Get) The SubName as String.

#Region"[On] |2019/07/06 00h51:091| <01.00.63> <Property> <Columns> |.Handles()|String|"' (Set|Get) The Handles as String.
   Private _Handles As String
    '''    <Summary>
'''     (Set|Get) The Handles as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:190 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Handles as String.") >
   Public Property Handles()As String
       Get
       Return _Handles
       End Get
       Set(ByVal Value As String)
       _Handles = Value
       End Set
   End Property
#End Region '(Set|Get) The Handles as String.

#Region"[On] |2019/07/06 00h51:104| <01.00.64> <Property> <Columns> |.Implements()|String|"' (Set|Get) The Implements as String.
   Private _Implements As String
    '''    <Summary>
'''     (Set|Get) The Implements as String.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:190 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Implements as String.") >
   Public Property Implements()As String
       Get
       Return _Implements
       End Get
       Set(ByVal Value As String)
       _Implements = Value
       End Set
   End Property
#End Region '(Set|Get) The Implements as String.

#End Region 
#Region"<2> [Enumeration]{1}"
#Region"[On] |2019/07/06 00h51:118| <02.00.00> <Enumeration> <> |.Schema()|Enumeration{64}|"' (Set|Get) The enumeration of Schema.
    '''    <Summary>
'''     (Set|Get) The enumeration of Schema.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:191 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The enumeration of Schema.") >
   Enum Schema
''' <summary>(Set|Get) The ID as Integer.</summary>
   [ID] = 0
''' <summary>(Set|Get) The Name as String.</summary>
   [Name] = 1
''' <summary>(Set|Get) The ImageIndex as Integer.</summary>
   [ImageIndex] = 2
''' <summary>(Set|Get) The Text as String.</summary>
   [Text] = 3
''' <summary>(Set|Get) The ToolTip as String.</summary>
   [ToolTip] = 4
''' <summary>(Set|Get) The Enable as Boolean.</summary>
   [Enable] = 5
''' <summary>(Set|Get) The Status as String.</summary>
   [Status] = 6
''' <summary>(Set|Get) The Statement as String.</summary>
   [Statement] = 7
''' <summary>(Set|Get) The XMLFile as String.</summary>
   [XMLFile] = 8
''' <summary>(Set|Get) The Attributes as String.</summary>
   [Attributes] = 9
''' <summary>(Set|Get) The Browsable as Boolean.</summary>
   [Browsable] = 10
''' <summary>(Set|Get) The Category as String.</summary>
   [Category] = 11
''' <summary>(Set|Get) The Description as String.</summary>
   [Description] = 12
''' <summary>(Set|Get) The DefaultValue as String.</summary>
   [DefaultValue] = 13
''' <summary>(Set|Get) The Editor as String.</summary>
   [Editor] = 14
''' <summary>(Set|Get) The DllImport as String.</summary>
   [DllImport] = 15
''' <summary>(Set|Get) The Deserializable as Boolean.</summary>
   [Deserializable] = 16
''' <summary>(Set|Get) The NonSerialized as Boolean.</summary>
   [NonSerialized] = 17
''' <summary>(Set|Get) The Serializable as Boolean.</summary>
   [Serializable] = 18
''' <summary>(Set|Get) The XmlRoot as String.</summary>
   [XmlRoot] = 19
''' <summary>(Set|Get) The XmlIgnore as Boolean.</summary>
   [XmlIgnore] = 20
''' <summary>(Set|Get) The XmlInclude as Boolean.</summary>
   [XmlInclude] = 21
''' <summary>(Set|Get) The RelatedImageList as String.</summary>
   [RelatedImageList] = 22
''' <summary>(Set|Get) The Print_VB as String.</summary>
   [Print_VB] = 23
''' <summary>(Set|Get) The VB as String.</summary>
   [VB] = 24
''' <summary>(Set|Get) The Print_C as String.</summary>
   [Print_C] = 25
''' <summary>(Set|Get) The C as String.</summary>
   [C] = 26
''' <summary>(Set|Get) The Print_F as String.</summary>
   [Print_F] = 27
''' <summary>(Set|Get) The F as String.</summary>
   [F] = 28
''' <summary>(Set|Get) The Print_Python as String.</summary>
   [Print_Python] = 29
''' <summary>(Set|Get) The Python as String.</summary>
   [Python] = 30
''' <summary>(Set|Get) The Print_JavaScript as String.</summary>
   [Print_JavaScript] = 31
''' <summary>(Set|Get) The JavaScript as String.</summary>
   [JavaScript] = 32
''' <summary>(Set|Get) The RegionCategory as Integer.</summary>
   [RegionCategory] = 33
''' <summary>(Set|Get) The RegionCode as String.</summary>
   [RegionCode] = 34
''' <summary>(Set|Get) The AuthorEmail as String.</summary>
   [AuthorEmail] = 35
''' <summary>(Set|Get) The AuthorName as String.</summary>
   [AuthorName] = 36
''' <summary>(Set|Get) The AuthorUri as String.</summary>
   [AuthorUri] = 37
''' <summary>(Set|Get) The ContributorEmail as String.</summary>
   [ContributorEmail] = 38
''' <summary>(Set|Get) The ContributorName as String.</summary>
   [ContributorName] = 39
''' <summary>(Set|Get) The ContributorUri as String.</summary>
   [ContributorUri] = 40
''' <summary>(Set|Get) The CustomProperty as String.</summary>
   [CustomProperty] = 41
''' <summary>(Set|Get) The Published as String.</summary>
   [Published] = 42
''' <summary>(Set|Get) The Rights as String.</summary>
   [Rights] = 43
''' <summary>(Set|Get) The Summary as String.</summary>
   [Summary] = 44
''' <summary>(Set|Get) The Title as String.</summary>
   [Title] = 45
''' <summary>(Set|Get) The Updated as String.</summary>
   [Updated] = 46
''' <summary>(Set|Get) The Usage as String.</summary>
   [Usage] = 47
''' <summary>(Set|Get) The Remarks as String.</summary>
   [Remarks] = 48
''' <summary>(Set|Get) The Example as String.</summary>
   [Example] = 49
''' <summary>(Set|Get) The Note as String.</summary>
   [Note] = 50
''' <summary>(Set|Get) The CreationDate as String.</summary>
   [CreationDate] = 51
''' <summary>(Set|Get) The See as String.</summary>
   [See] = 52
''' <summary>(Set|Get) The SeeAlso as String.</summary>
   [SeeAlso] = 53
''' <summary>(Set|Get) The Rules as String.</summary>
   [Rules] = 54
''' <summary>(Set|Get) The Syntax as String.</summary>
   [Syntax] = 55
''' <summary>(Set|Get) The AccessModifier as String.</summary>
   [AccessModifier] = 56
''' <summary>(Set|Get) The ProcedureModifier as String.</summary>
   [ProcedureModifier] = 57
''' <summary>(Set|Get) The Partial as Boolean.</summary>
   [Partial] = 58
''' <summary>(Set|Get) The Shared as Boolean.</summary>
   [Shared] = 59
''' <summary>(Set|Get) The Shadows as Boolean.</summary>
   [Shadows] = 60
''' <summary>(Set|Get) The Async as Boolean.</summary>
   [Async] = 61
''' <summary>(Set|Get) The SubName as String.</summary>
   [SubName] = 62
''' <summary>(Set|Get) The Handles as String.</summary>
   [Handles] = 63
''' <summary>(Set|Get) The Implements as String.</summary>
   [Implements] = 64
   End Enum
#End Region '(Set|Get) The enumeration of Schema.

#End Region 
#Region "<4> [Sub]{5}"
#Region"[On] |2019/07/06 00h51:143| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
    '''    <Summary>
'''     (Set|Get) This will reinitialize the class element.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:195 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) This will reinitialize the class element.") >
   Public Sub Clear()
  With Me
        .ID = 0
        .Name = Nothing
        .ImageIndex = 0
        .Text = Nothing
        .ToolTip = Nothing
        .Enable = False
        .Status = Nothing
        .Statement = Nothing
        .XMLFile = Nothing
        .Attributes = Nothing
        .Browsable = False
        .Category = Nothing
        .Description = Nothing
        .DefaultValue = Nothing
        .Editor = Nothing
        .DllImport = Nothing
        .Deserializable = False
        .NonSerialized = False
        .Serializable = False
        .XmlRoot = Nothing
        .XmlIgnore = False
        .XmlInclude = False
        .RelatedImageList = Nothing
        .Print_VB = Nothing
        .VB = Nothing
        .Print_C = Nothing
        .C = Nothing
        .Print_F = Nothing
        .F = Nothing
        .Print_Python = Nothing
        .Python = Nothing
        .Print_JavaScript = Nothing
        .JavaScript = Nothing
        .RegionCategory = 0
        .RegionCode = Nothing
        .AuthorEmail = Nothing
        .AuthorName = Nothing
        .AuthorUri = Nothing
        .ContributorEmail = Nothing
        .ContributorName = Nothing
        .ContributorUri = Nothing
        .CustomProperty = Nothing
        .Published = Nothing
        .Rights = Nothing
        .Summary = Nothing
        .Title = Nothing
        .Updated = Nothing
        .Usage = Nothing
        .Remarks = Nothing
        .Example = Nothing
        .Note = Nothing
        .CreationDate = Nothing
        .See = Nothing
        .SeeAlso = Nothing
        .Rules = Nothing
        .Syntax = Nothing
        .AccessModifier = Nothing
        .ProcedureModifier = Nothing
        .Partial = False
        .Shared = False
        .Shadows = False
        .Async = False
        .SubName = Nothing
        .Handles = Nothing
        .Implements = Nothing
 End With
   End Sub
#End Region '(Set|Get) This will reinitialize the class element.

#Region"[On] |2019/07/06 00h51:157| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
    '''    <Summary>
'''     (Set|Get) This will reinitialize the variables of this class.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:195 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) This will reinitialize the variables of this class.") >
   Public Sub Reset(Optional ByVal Connector As LineInfo = Nothing)
If Not IsNothing(Connector) Then
   Me.Connector=Connector
   Me.FilePath=""
   Me.Password=""
   Me.Line=""
   If Connector.Status<>Status.Broken Then 
        FilePath = Connector.FilePath
        Password = Connector.Password
        Me.Connector=Connector
        TableName = "Sub"
        Line = Connector.Line
        UseSQL = False
   Else
        FilePath = My.Settings.Db_ProjectDatabase_FilePath
        Password = My.Settings.Db_ProjectDatabase_Password
        Me.Line = My.Settings.Db_ProjectDatabase_Line
        TableName = "Sub"
        UseSQL = False
   End If
Else
        If IsNothing(FilePath) Then 
             FilePath = My.Settings.Db_ProjectDatabase_FilePath
        End If 
        If FilePath.Length<1 Then 
             FilePath = My.Settings.Db_ProjectDatabase_FilePath
        End If 
        FilePath = My.Settings.Db_ProjectDatabase_FilePath
        Password = My.Settings.Db_ProjectDatabase_Password
        Me.Line = My.Settings.Db_ProjectDatabase_Line
        TableName = "Sub"
        UseSQL = False
End If

   End Sub
#End Region '(Set|Get) This will reinitialize the variables of this class.

#Region"[On] |2019/07/06 00h51:173| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
    '''    <Summary>
'''     (Set|Get) This will add a new row in the table.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:195 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) This will add a new row in the table.") >
   Public Sub Add()
 Try
   Dim Str As String = Nothing
   Str = "Insert Into [Sub] (
`ID`, 
`Name`, 
`ImageIndex`, 
`Text`, 
`ToolTip`, 
`Enable`, 
`Status`, 
`Statement`, 
`XMLFile`, 
`Attributes`, 
`Browsable`, 
`Category`, 
`Description`, 
`DefaultValue`, 
`Editor`, 
`DllImport`, 
`Deserializable`, 
`NonSerialized`, 
`Serializable`, 
`XmlRoot`, 
`XmlIgnore`, 
`XmlInclude`, 
`RelatedImageList`, 
`Print_VB`, 
`VB`, 
`Print_C`, 
`C`, 
`Print_F`, 
`F`, 
`Print_Python`, 
`Python`, 
`Print_JavaScript`, 
`JavaScript`, 
`RegionCategory`, 
`RegionCode`, 
`AuthorEmail`, 
`AuthorName`, 
`AuthorUri`, 
`ContributorEmail`, 
`ContributorName`, 
`ContributorUri`, 
`CustomProperty`, 
`Published`, 
`Rights`, 
`Summary`, 
`Title`, 
`Updated`, 
`Usage`, 
`Remarks`, 
`Example`, 
`Note`, 
`CreationDate`, 
`See`, 
`SeeAlso`, 
`Rules`, 
`Syntax`, 
`AccessModifier`, 
`ProcedureModifier`, 
`Partial`, 
`Shared`, 
`Shadows`, 
`Async`, 
`SubName`, 
`Handles`, 
`Implements`) Values (@0, @1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18, @19, @20, @21, @22, @23, @24, @25, @26, @27, @28, @29, @30, @31, @32, @33, @34, @35, @36, @37, @38, @39, @40, @41, @42, @43, @44, @45, @46, @47, @48, @49, @50, @51, @52, @53, @54, @55, @56, @57, @58, @59, @60, @61, @62, @63, @64)"
Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
Cmd = New OleDb.OleDbCommand(Str,Con)
Con.Open()
            Cmd.Parameters.AddWithValue("@0", Me.ID)
            Cmd.Parameters.AddWithValue("@1", Me.Name)
            Cmd.Parameters.AddWithValue("@2", Me.ImageIndex)
            Cmd.Parameters.AddWithValue("@3", Me.Text)
            Cmd.Parameters.AddWithValue("@4", Me.ToolTip)
            Cmd.Parameters.AddWithValue("@5", Me.Enable)
            Cmd.Parameters.AddWithValue("@6", Me.Status)
            Cmd.Parameters.AddWithValue("@7", Me.Statement)
            Cmd.Parameters.AddWithValue("@8", Me.XMLFile)
            Cmd.Parameters.AddWithValue("@9", Me.Attributes)
            Cmd.Parameters.AddWithValue("@10", Me.Browsable)
            Cmd.Parameters.AddWithValue("@11", Me.Category)
            Cmd.Parameters.AddWithValue("@12", Me.Description)
            Cmd.Parameters.AddWithValue("@13", Me.DefaultValue)
            Cmd.Parameters.AddWithValue("@14", Me.Editor)
            Cmd.Parameters.AddWithValue("@15", Me.DllImport)
            Cmd.Parameters.AddWithValue("@16", Me.Deserializable)
            Cmd.Parameters.AddWithValue("@17", Me.NonSerialized)
            Cmd.Parameters.AddWithValue("@18", Me.Serializable)
            Cmd.Parameters.AddWithValue("@19", Me.XmlRoot)
            Cmd.Parameters.AddWithValue("@20", Me.XmlIgnore)
            Cmd.Parameters.AddWithValue("@21", Me.XmlInclude)
            Cmd.Parameters.AddWithValue("@22", Me.RelatedImageList)
            Cmd.Parameters.AddWithValue("@23", Me.Print_VB)
            Cmd.Parameters.AddWithValue("@24", Me.VB)
            Cmd.Parameters.AddWithValue("@25", Me.Print_C)
            Cmd.Parameters.AddWithValue("@26", Me.C)
            Cmd.Parameters.AddWithValue("@27", Me.Print_F)
            Cmd.Parameters.AddWithValue("@28", Me.F)
            Cmd.Parameters.AddWithValue("@29", Me.Print_Python)
            Cmd.Parameters.AddWithValue("@30", Me.Python)
            Cmd.Parameters.AddWithValue("@31", Me.Print_JavaScript)
            Cmd.Parameters.AddWithValue("@32", Me.JavaScript)
            Cmd.Parameters.AddWithValue("@33", Me.RegionCategory)
            Cmd.Parameters.AddWithValue("@34", Me.RegionCode)
            Cmd.Parameters.AddWithValue("@35", Me.AuthorEmail)
            Cmd.Parameters.AddWithValue("@36", Me.AuthorName)
            Cmd.Parameters.AddWithValue("@37", Me.AuthorUri)
            Cmd.Parameters.AddWithValue("@38", Me.ContributorEmail)
            Cmd.Parameters.AddWithValue("@39", Me.ContributorName)
            Cmd.Parameters.AddWithValue("@40", Me.ContributorUri)
            Cmd.Parameters.AddWithValue("@41", Me.CustomProperty)
            Cmd.Parameters.AddWithValue("@42", Me.Published)
            Cmd.Parameters.AddWithValue("@43", Me.Rights)
            Cmd.Parameters.AddWithValue("@44", Me.Summary)
            Cmd.Parameters.AddWithValue("@45", Me.Title)
            Cmd.Parameters.AddWithValue("@46", Me.Updated)
            Cmd.Parameters.AddWithValue("@47", Me.Usage)
            Cmd.Parameters.AddWithValue("@48", Me.Remarks)
            Cmd.Parameters.AddWithValue("@49", Me.Example)
            Cmd.Parameters.AddWithValue("@50", Me.Note)
            Cmd.Parameters.AddWithValue("@51", Me.CreationDate)
            Cmd.Parameters.AddWithValue("@52", Me.See)
            Cmd.Parameters.AddWithValue("@53", Me.SeeAlso)
            Cmd.Parameters.AddWithValue("@54", Me.Rules)
            Cmd.Parameters.AddWithValue("@55", Me.Syntax)
            Cmd.Parameters.AddWithValue("@56", Me.AccessModifier)
            Cmd.Parameters.AddWithValue("@57", Me.ProcedureModifier)
            Cmd.Parameters.AddWithValue("@58", Me.Partial)
            Cmd.Parameters.AddWithValue("@59", Me.Shared)
            Cmd.Parameters.AddWithValue("@60", Me.Shadows)
            Cmd.Parameters.AddWithValue("@61", Me.Async)
            Cmd.Parameters.AddWithValue("@62", Me.SubName)
            Cmd.Parameters.AddWithValue("@63", Me.Handles)
            Cmd.Parameters.AddWithValue("@64", Me.Implements)
          If Cmd.ExecuteNonQuery>=0 Then
          Else
              Msgbox("Element not Addd")
          End If
 Catch ex As Exception 
 Finally 
   Close(True) 
 End Try 

   End Sub
#End Region '(Set|Get) This will add a new row in the table.

#Region"[On] |2019/07/06 00h51:188| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
    '''    <Summary>
'''     (Set|Get) This will update a row in the table.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:195 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) This will update a row in the table.") >
   Public Sub Save()
 Try
   Dim Str As String = Nothing
   Str = "UPDATE [Sub] SET Name = @Name, ImageIndex = @ImageIndex, Text = @Text, ToolTip = @ToolTip, Enable = @Enable, Status = @Status, Statement = @Statement, XMLFile = @XMLFile, Attributes = @Attributes, Browsable = @Browsable, Category = @Category, Description = @Description, DefaultValue = @DefaultValue, Editor = @Editor, DllImport = @DllImport, Deserializable = @Deserializable, NonSerialized = @NonSerialized, Serializable = @Serializable, XmlRoot = @XmlRoot, XmlIgnore = @XmlIgnore, XmlInclude = @XmlInclude, RelatedImageList = @RelatedImageList, Print_VB = @Print_VB, VB = @VB, Print_C = @Print_C, C = @C, Print_F = @Print_F, F = @F, Print_Python = @Print_Python, Python = @Python, Print_JavaScript = @Print_JavaScript, JavaScript = @JavaScript, RegionCategory = @RegionCategory, RegionCode = @RegionCode, AuthorEmail = @AuthorEmail, AuthorName = @AuthorName, AuthorUri = @AuthorUri, ContributorEmail = @ContributorEmail, ContributorName = @ContributorName, ContributorUri = @ContributorUri, CustomProperty = @CustomProperty, Published = @Published, Rights = @Rights, Summary = @Summary, Title = @Title, Updated = @Updated, Usage = @Usage, Remarks = @Remarks, Example = @Example, Note = @Note, CreationDate = @CreationDate, See = @See, SeeAlso = @SeeAlso, Rules = @Rules, Syntax = @Syntax, AccessModifier = @AccessModifier, ProcedureModifier = @ProcedureModifier, Partial = @Partial, Shared = @Shared, Shadows = @Shadows, Async = @Async, SubName = @SubName, Handles = @Handles, Implements = @Implements WHERE ID = @ID"
Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
Cmd = New OleDb.OleDbCommand(Str,Con)
Con.Open()
      Cmd.Parameters.AddWithValue("@Name",Name)
      Cmd.Parameters.AddWithValue("@ImageIndex",ImageIndex)
      Cmd.Parameters.AddWithValue("@Text",Text)
      Cmd.Parameters.AddWithValue("@ToolTip",ToolTip)
      Cmd.Parameters.AddWithValue("@Enable",Enable)
      Cmd.Parameters.AddWithValue("@Status",Status)
      Cmd.Parameters.AddWithValue("@Statement",Statement)
      Cmd.Parameters.AddWithValue("@XMLFile",XMLFile)
      Cmd.Parameters.AddWithValue("@Attributes",Attributes)
      Cmd.Parameters.AddWithValue("@Browsable",Browsable)
      Cmd.Parameters.AddWithValue("@Category",Category)
      Cmd.Parameters.AddWithValue("@Description",Description)
      Cmd.Parameters.AddWithValue("@DefaultValue",DefaultValue)
      Cmd.Parameters.AddWithValue("@Editor",Editor)
      Cmd.Parameters.AddWithValue("@DllImport",DllImport)
      Cmd.Parameters.AddWithValue("@Deserializable",Deserializable)
      Cmd.Parameters.AddWithValue("@NonSerialized",NonSerialized)
      Cmd.Parameters.AddWithValue("@Serializable",Serializable)
      Cmd.Parameters.AddWithValue("@XmlRoot",XmlRoot)
      Cmd.Parameters.AddWithValue("@XmlIgnore",XmlIgnore)
      Cmd.Parameters.AddWithValue("@XmlInclude",XmlInclude)
      Cmd.Parameters.AddWithValue("@RelatedImageList",RelatedImageList)
      Cmd.Parameters.AddWithValue("@Print_VB",Print_VB)
      Cmd.Parameters.AddWithValue("@VB",VB)
      Cmd.Parameters.AddWithValue("@Print_C",Print_C)
      Cmd.Parameters.AddWithValue("@C",C)
      Cmd.Parameters.AddWithValue("@Print_F",Print_F)
      Cmd.Parameters.AddWithValue("@F",F)
      Cmd.Parameters.AddWithValue("@Print_Python",Print_Python)
      Cmd.Parameters.AddWithValue("@Python",Python)
      Cmd.Parameters.AddWithValue("@Print_JavaScript",Print_JavaScript)
      Cmd.Parameters.AddWithValue("@JavaScript",JavaScript)
      Cmd.Parameters.AddWithValue("@RegionCategory",RegionCategory)
      Cmd.Parameters.AddWithValue("@RegionCode",RegionCode)
      Cmd.Parameters.AddWithValue("@AuthorEmail",AuthorEmail)
      Cmd.Parameters.AddWithValue("@AuthorName",AuthorName)
      Cmd.Parameters.AddWithValue("@AuthorUri",AuthorUri)
      Cmd.Parameters.AddWithValue("@ContributorEmail",ContributorEmail)
      Cmd.Parameters.AddWithValue("@ContributorName",ContributorName)
      Cmd.Parameters.AddWithValue("@ContributorUri",ContributorUri)
      Cmd.Parameters.AddWithValue("@CustomProperty",CustomProperty)
      Cmd.Parameters.AddWithValue("@Published",Published)
      Cmd.Parameters.AddWithValue("@Rights",Rights)
      Cmd.Parameters.AddWithValue("@Summary",Summary)
      Cmd.Parameters.AddWithValue("@Title",Title)
      Cmd.Parameters.AddWithValue("@Updated",Updated)
      Cmd.Parameters.AddWithValue("@Usage",Usage)
      Cmd.Parameters.AddWithValue("@Remarks",Remarks)
      Cmd.Parameters.AddWithValue("@Example",Example)
      Cmd.Parameters.AddWithValue("@Note",Note)
      Cmd.Parameters.AddWithValue("@CreationDate",CreationDate)
      Cmd.Parameters.AddWithValue("@See",See)
      Cmd.Parameters.AddWithValue("@SeeAlso",SeeAlso)
      Cmd.Parameters.AddWithValue("@Rules",Rules)
      Cmd.Parameters.AddWithValue("@Syntax",Syntax)
      Cmd.Parameters.AddWithValue("@AccessModifier",AccessModifier)
      Cmd.Parameters.AddWithValue("@ProcedureModifier",ProcedureModifier)
      Cmd.Parameters.AddWithValue("@Partial",Partial)
      Cmd.Parameters.AddWithValue("@Shared",Shared)
      Cmd.Parameters.AddWithValue("@Shadows",Shadows)
      Cmd.Parameters.AddWithValue("@Async",Async)
      Cmd.Parameters.AddWithValue("@SubName",SubName)
      Cmd.Parameters.AddWithValue("@Handles",Handles)
      Cmd.Parameters.AddWithValue("@Implements",Implements)
      Cmd.Parameters.AddWithValue("@ID",ID)
          If Cmd.ExecuteNonQuery>=0 Then
          Else
              Msgbox("Element not Saved")
          End If
 Catch ex As Exception 
 Finally 
   Close(True) 
 End Try 

   End Sub
#End Region '(Set|Get) This will update a row in the table.

#Region"[On] |2019/07/06 00h51:202| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
    '''    <Summary>
'''     (Set|Get) This will Delete a row in the table.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:195 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) This will Delete a row in the table.") >
   Public Sub Delete()
 Try
   Dim Str As String = Nothing
   Str = "Delete From [Sub] WHERE ID =@ID"
Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
Cmd = New OleDb.OleDbCommand(Str,Con)
Con.Open()
Cmd.Parameters.AddWithValue("@ID", ID)
          If Cmd.ExecuteNonQuery>=0 Then
          Else
              Msgbox("Element not Deleted")
          End If
 Catch ex As Exception 
 Finally 
   Close(True) 
 End Try 

   End Sub
#End Region '(Set|Get) This will Delete a row in the table.

#End Region 
#Region "<5> [Function]{7}"
#Region"[On] |2019/07/06 00h51:216| <05.00.00> <Function> <> |.Open()|TestItem}|"' (Set|Get) This will initialise the connection and import the data.
    '''    <Summary>
'''     (Set|Get) This will initialise the connection and import the data.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:196 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) This will initialise the connection and import the data.") >
   Public Function Open(ByVal SqlCommand As String) As TestItem
 Dim Result As New TestItem("Open(SqlCommand)", " Openning the connection line to the database.")
 If CheckConnection()=True Then
                     Con = New OleDb.OleDbConnection(Me.Line)
                     Cmd = New OleDb.OleDbCommand(SqlCommand,Con)
                         If Con.State = ConnectionState.Open Then
                             Close(True)
                         Else
                             Try
                                 Con.Open()
                                 Result.Status = Status.Online
                             Catch ex As Exception
                                 Result.AddBug(ex,"Error while opening database","SqlCon.Open()")
                                 Result.Why+= ex.Message & vbNewLine
                                 Result.Status = Status.Broken
                             End Try
                         End If
     Else
         Result.Status = Status.Broken
         Result.Why += Log & VbNewLine 
     End If
 Return Result

   End Function
#End Region '(Set|Get) This will initialise the connection and import the data.

#Region"[On] |2019/07/06 00h51:237| <05.00.01> <Function> <> |.Close()|TestItem}|"' (Set|Get) This willClosing the connection
    '''    <Summary>
'''     (Set|Get) This willClosing the connection
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:196 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) This willClosing the connection") >
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
                                 Result.Why +="The connection will not close." & vbNewLine
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
                                 Result.Why +="The connection will not close." & vbNewLine
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
                                 Result.Why +="The connection will not close." & vbNewLine
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
                                 Result.Why +="The connection will not close." & vbNewLine
                             End If
                     End If
             End If
         End If
 Return Result

   End Function
#End Region '(Set|Get) This willClosing the connection

#Region"[On] |2019/07/06 00h51:252| <05.00.02> <Function> <> |.List()|List(Of Sub)}|"' (Set|Get) Return the entire table listed
    '''    <Summary>
'''     (Set|Get) Return the entire table listed
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:196 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) Return the entire table listed") >
   Public Function List() As List(Of Sub)
Dim Result As New List(Of Sub)
Me.Table = New Table(Me.TableName , Me.FilePath , Me.Password,False)
   For each Row As DataRow In Me.Table.DataTable.Rows
      Dim Element As New Sub(IIf(IsDBNull(Row.Item(0)),0,Row.Item(0)),
IIf(IsDBNull(Row.Item(1)),"",Row.Item(1)),
IIf(IsDBNull(Row.Item(2)),0,Row.Item(2)),
IIf(IsDBNull(Row.Item(3)),"",Row.Item(3)),
IIf(IsDBNull(Row.Item(4)),"",Row.Item(4)),
IIf(IsDBNull(Row.Item(5)),False,Row.Item(5)),
IIf(IsDBNull(Row.Item(6)),"",Row.Item(6)),
IIf(IsDBNull(Row.Item(7)),"",Row.Item(7)),
IIf(IsDBNull(Row.Item(8)),"",Row.Item(8)),
IIf(IsDBNull(Row.Item(9)),"",Row.Item(9)),
IIf(IsDBNull(Row.Item(10)),False,Row.Item(10)),
IIf(IsDBNull(Row.Item(11)),"",Row.Item(11)),
IIf(IsDBNull(Row.Item(12)),"",Row.Item(12)),
IIf(IsDBNull(Row.Item(13)),"",Row.Item(13)),
IIf(IsDBNull(Row.Item(14)),"",Row.Item(14)),
IIf(IsDBNull(Row.Item(15)),"",Row.Item(15)),
IIf(IsDBNull(Row.Item(16)),False,Row.Item(16)),
IIf(IsDBNull(Row.Item(17)),False,Row.Item(17)),
IIf(IsDBNull(Row.Item(18)),False,Row.Item(18)),
IIf(IsDBNull(Row.Item(19)),"",Row.Item(19)),
IIf(IsDBNull(Row.Item(20)),False,Row.Item(20)),
IIf(IsDBNull(Row.Item(21)),False,Row.Item(21)),
IIf(IsDBNull(Row.Item(22)),"",Row.Item(22)),
IIf(IsDBNull(Row.Item(23)),"",Row.Item(23)),
IIf(IsDBNull(Row.Item(24)),"",Row.Item(24)),
IIf(IsDBNull(Row.Item(25)),"",Row.Item(25)),
IIf(IsDBNull(Row.Item(26)),"",Row.Item(26)),
IIf(IsDBNull(Row.Item(27)),"",Row.Item(27)),
IIf(IsDBNull(Row.Item(28)),"",Row.Item(28)),
IIf(IsDBNull(Row.Item(29)),"",Row.Item(29)),
IIf(IsDBNull(Row.Item(30)),"",Row.Item(30)),
IIf(IsDBNull(Row.Item(31)),"",Row.Item(31)),
IIf(IsDBNull(Row.Item(32)),"",Row.Item(32)),
IIf(IsDBNull(Row.Item(33)),0,Row.Item(33)),
IIf(IsDBNull(Row.Item(34)),"",Row.Item(34)),
IIf(IsDBNull(Row.Item(35)),"",Row.Item(35)),
IIf(IsDBNull(Row.Item(36)),"",Row.Item(36)),
IIf(IsDBNull(Row.Item(37)),"",Row.Item(37)),
IIf(IsDBNull(Row.Item(38)),"",Row.Item(38)),
IIf(IsDBNull(Row.Item(39)),"",Row.Item(39)),
IIf(IsDBNull(Row.Item(40)),"",Row.Item(40)),
IIf(IsDBNull(Row.Item(41)),"",Row.Item(41)),
IIf(IsDBNull(Row.Item(42)),"",Row.Item(42)),
IIf(IsDBNull(Row.Item(43)),"",Row.Item(43)),
IIf(IsDBNull(Row.Item(44)),"",Row.Item(44)),
IIf(IsDBNull(Row.Item(45)),"",Row.Item(45)),
IIf(IsDBNull(Row.Item(46)),"",Row.Item(46)),
IIf(IsDBNull(Row.Item(47)),"",Row.Item(47)),
IIf(IsDBNull(Row.Item(48)),"",Row.Item(48)),
IIf(IsDBNull(Row.Item(49)),"",Row.Item(49)),
IIf(IsDBNull(Row.Item(50)),"",Row.Item(50)),
IIf(IsDBNull(Row.Item(51)),"",Row.Item(51)),
IIf(IsDBNull(Row.Item(52)),"",Row.Item(52)),
IIf(IsDBNull(Row.Item(53)),"",Row.Item(53)),
IIf(IsDBNull(Row.Item(54)),"",Row.Item(54)),
IIf(IsDBNull(Row.Item(55)),"",Row.Item(55)),
IIf(IsDBNull(Row.Item(56)),"",Row.Item(56)),
IIf(IsDBNull(Row.Item(57)),"",Row.Item(57)),
IIf(IsDBNull(Row.Item(58)),False,Row.Item(58)),
IIf(IsDBNull(Row.Item(59)),False,Row.Item(59)),
IIf(IsDBNull(Row.Item(60)),False,Row.Item(60)),
IIf(IsDBNull(Row.Item(61)),False,Row.Item(61)),
IIf(IsDBNull(Row.Item(62)),"",Row.Item(62)),
IIf(IsDBNull(Row.Item(63)),"",Row.Item(63)),
      IIf(IsDBNull(Row.Item(64)),"",Row.Item(64)))
      Element.Reset(Table.Line)
 Result.Add(Element)
 Next
 Return Result
   End Function
#End Region '(Set|Get) Return the entire table listed

#Region"[On] |2019/07/06 00h51:270| <05.00.03> <Function> <> |.SearchByName()|List(Of Sub)}|"' (Set|Get) Search for each property that match the Search String.
    '''    <Summary>
'''     (Set|Get) Search for each property that match the Search String.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:196 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) Search for each property that match the Search String.") >
   Public Shared Function SearchByName(ByVal Search As String) As List(Of Sub)
Dim Result As New List(Of Sub)
 Dim C As New Sub
 For Each Element As Sub In C.List
 If Element.Name.Tolower() = Search.Tolower() Or Element.Text.Tolower() = Search.Tolower()  Or Element.ToolTip.Tolower() = Search.Tolower()  Or Element.Status.Tolower() = Search.Tolower()  Or Element.Statement.Tolower() = Search.Tolower()  Or Element.XMLFile.Tolower() = Search.Tolower()  Or Element.Attributes.Tolower() = Search.Tolower()  Or Element.Category.Tolower() = Search.Tolower()  Or Element.Description.Tolower() = Search.Tolower()  Or Element.DefaultValue.Tolower() = Search.Tolower()  Or Element.Editor.Tolower() = Search.Tolower()  Or Element.DllImport.Tolower() = Search.Tolower()  Or Element.XmlRoot.Tolower() = Search.Tolower()  Or Element.RelatedImageList.Tolower() = Search.Tolower()  Or Element.Print_VB.Tolower() = Search.Tolower()  Or Element.VB.Tolower() = Search.Tolower()  Or Element.Print_C.Tolower() = Search.Tolower()  Or Element.C.Tolower() = Search.Tolower()  Or Element.Print_F.Tolower() = Search.Tolower()  Or Element.F.Tolower() = Search.Tolower()  Or Element.Print_Python.Tolower() = Search.Tolower()  Or Element.Python.Tolower() = Search.Tolower()  Or Element.Print_JavaScript.Tolower() = Search.Tolower()  Or Element.JavaScript.Tolower() = Search.Tolower()  Or Element.RegionCode.Tolower() = Search.Tolower()  Or Element.AuthorEmail.Tolower() = Search.Tolower()  Or Element.AuthorName.Tolower() = Search.Tolower()  Or Element.AuthorUri.Tolower() = Search.Tolower()  Or Element.ContributorEmail.Tolower() = Search.Tolower()  Or Element.ContributorName.Tolower() = Search.Tolower()  Or Element.ContributorUri.Tolower() = Search.Tolower()  Or Element.CustomProperty.Tolower() = Search.Tolower()  Or Element.Published.Tolower() = Search.Tolower()  Or Element.Rights.Tolower() = Search.Tolower()  Or Element.Summary.Tolower() = Search.Tolower()  Or Element.Title.Tolower() = Search.Tolower()  Or Element.Updated.Tolower() = Search.Tolower()  Or Element.Usage.Tolower() = Search.Tolower()  Or Element.Remarks.Tolower() = Search.Tolower()  Or Element.Example.Tolower() = Search.Tolower()  Or Element.Note.Tolower() = Search.Tolower()  Or Element.CreationDate.Tolower() = Search.Tolower()  Or Element.See.Tolower() = Search.Tolower()  Or Element.SeeAlso.Tolower() = Search.Tolower()  Or Element.Rules.Tolower() = Search.Tolower()  Or Element.Syntax.Tolower() = Search.Tolower()  Or Element.AccessModifier.Tolower() = Search.Tolower()  Or Element.ProcedureModifier.Tolower() = Search.Tolower()  Or Element.SubName.Tolower() = Search.Tolower()  Or Element.Handles.Tolower() = Search.Tolower()  Or Element.Implements.Tolower() = Search.Tolower() Then
      Result.Add(Element)
 End If
 Next
 Return Result
   End Function
#End Region '(Set|Get) Search for each property that match the Search String.

#Region"[On] |2019/07/06 00h51:285| <05.00.04> <Function> <> |.SearchByID()|List(Of Sub)}|"' (Set|Get) Search for each property that match the Search Id.
    '''    <Summary>
'''     (Set|Get) Search for each property that match the Search Id.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:197 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) Search for each property that match the Search Id.") >
   Public Shared Function SearchByID(ByVal Search As Double) As List(Of Sub)
Dim Result As New List(Of Sub)
 Dim C As New Sub
 For Each Element As Sub In C.List
 If Val(Element.ID) = Search Or Val(Element.ImageIndex) = Search  Or Val(Element.RegionCategory) = Search Then
      Result.Add(Element)
 End If
 Next
 Return Result
   End Function
#End Region '(Set|Get) Search for each property that match the Search Id.

#Region"[On] |2019/07/06 00h51:300| <05.00.05> <Function> <> |.ToString()|String}|"' (Set|Get) The function ToString.
    '''    <Summary>
'''     (Set|Get) The function ToString.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:197 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The function ToString.") >
   Public Overrides Function ToString() As String
    Return Me.ID
   End Function
#End Region '(Set|Get) The function ToString.

#Region"[On] |2019/07/06 00h51:316| <05.00.06> <Function> <> |.CheckConnection()|Boolean}|"' (Set|Get) Evaluate the connection to the DataBase
    '''    <Summary>
'''     (Set|Get) Evaluate the connection to the DataBase
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:197 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) Evaluate the connection to the DataBase") >
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
    Dim Message As String = Nothing' Stores the process logic.
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
        If D.IsReady  Then
            Test_4 = True
        Message += "Test 4 <Result> |OK| The Drive is Online."
        Else
            Test_4 = False
        Message += "Test 4 <Result> |PB| The Drive is Offline or Disconnected."
        End If
 #End Region 
 #Region "Test 5 | Evaluate if there is a Password."
        If Not IsDbNull(Password) Then
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
                    Me.Connector = New LineInfo(FilePath,Password)
                    Me.Line = Me.Connector.Line
        Message += "Test 6 <Result> |Initialize Connector|"
                End If
        End If
 #End Region 
 #Region "Test 7 | Evaluate if Connector Line is not empty."
        If Not IsDbNull(Me.Connector.Line) Then
            Test_7 = True
        Else 
            Test_7 = False
        End If
 #End Region 
 #Region "Test 8 | Evaluate if the Connection is valid."
        If Test_7 =True Then
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
 If Test_7=True And Test_8 = True Then
    General_Status=True
 Else 
    General_Status=False
 End If
 Log+=Message & VbNewLine
 Return General_Status

   End Function
#End Region '(Set|Get) Evaluate the connection to the DataBase

#End Region 
#Region "<6> [Runtime]{12}"
#Region"[On] |2019/07/06 00h51:331| <15.00.00> <Runtime> <> |.Table()|Table"' (Set|Get) The Table.
    '''    <Summary>
'''     (Set|Get) The Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:197 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The Table.") >
   Public  Table As Table
#End Region '(Set|Get) The Table.

#Region"[On] |2019/07/06 00h51:347| <15.00.01> <Runtime> <> |.Line()|String"' (Set|Get) The Connection String To the Table.
    '''    <Summary>
'''     (Set|Get) The Connection String To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:198 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The Connection String To the Table.") >
   Public  Line As String
#End Region '(Set|Get) The Connection String To the Table.

#Region"[On] |2019/07/06 00h51:362| <15.00.02> <Runtime> <> |.FilePath()|String"' (Set|Get) The FilePath To the Table.
    '''    <Summary>
'''     (Set|Get) The FilePath To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:198 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The FilePath To the Table.") >
   Public  FilePath As String
#End Region '(Set|Get) The FilePath To the Table.

#Region"[On] |2019/07/06 00h51:376| <15.00.03> <Runtime> <> |.Password()|String"' (Set|Get) The Password To the Table.
    '''    <Summary>
'''     (Set|Get) The Password To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:198 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The Password To the Table.") >
   Public  Password As String
#End Region '(Set|Get) The Password To the Table.

#Region"[On] |2019/07/06 00h51:398| <15.00.04> <Runtime> <> |.UseSQL()|Boolean"' (Set|Get) Determines if the Database Connection is of type SQL.
    '''    <Summary>
'''     (Set|Get) Determines if the Database Connection is of type SQL.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:198 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) Determines if the Database Connection is of type SQL.") >
   Public  UseSQL As Boolean
#End Region '(Set|Get) Determines if the Database Connection is of type SQL.

#Region"[On] |2019/07/06 00h51:413| <15.00.05> <Runtime> <> |.TableName()|String"' (Set|Get) The name of the Table.
    '''    <Summary>
'''     (Set|Get) The name of the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:198 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The name of the Table.") >
   Public  TableName As String
#End Region '(Set|Get) The name of the Table.

#Region"[On] |2019/07/06 00h51:427| <15.00.06> <Runtime> <> |.Con()|OleDb.OleDbConnection"' (Set|Get) The Con To the Table.
    '''    <Summary>
'''     (Set|Get) The Con To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:199 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The Con To the Table.") >
   Public  Con As OleDb.OleDbConnection
#End Region '(Set|Get) The Con To the Table.

#Region"[On] |2019/07/06 00h51:433| <15.00.07> <Runtime> <> |.Cmd()|OleDb.OleDbCommand"' (Set|Get) The Cmd To the Table.
    '''    <Summary>
'''     (Set|Get) The Cmd To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:199 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The Cmd To the Table.") >
   Public  Cmd As OleDb.OleDbCommand
#End Region '(Set|Get) The Cmd To the Table.

#Region"[On] |2019/07/06 00h51:447| <15.00.08> <Runtime> <> |.DataReader()|OleDb.OleDbDataReader"' (Set|Get) The DataReader To the Table.
    '''    <Summary>
'''     (Set|Get) The DataReader To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:199 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The DataReader To the Table.") >
   Public  DataReader As OleDb.OleDbDataReader
#End Region '(Set|Get) The DataReader To the Table.

#Region"[On] |2019/07/06 00h51:461| <15.00.09> <Runtime> <> |.DataAdapter()|OleDb.OleDbDataAdapter"' (Set|Get) The DataAdapter To the Table.
    '''    <Summary>
'''     (Set|Get) The DataAdapter To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:199 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The DataAdapter To the Table.") >
   Public  DataAdapter As OleDb.OleDbDataAdapter
#End Region '(Set|Get) The DataAdapter To the Table.

#Region"[On] |2019/07/06 00h51:476| <15.00.10> <Runtime> <> |.Connector()|LineInfo"' (Set|Get) The Connector To the Table.
    '''    <Summary>
'''     (Set|Get) The Connector To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:200 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The Connector To the Table.") >
   Public  Connector As LineInfo
#End Region '(Set|Get) The Connector To the Table.

#Region"[On] |2019/07/06 00h51:491| <15.00.11> <Runtime> <> |.Log()|String"' (Set|Get) The Log To the Table.
    '''    <Summary>
'''     (Set|Get) The Log To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:200 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The Log To the Table.") >
   Public  Log As String
#End Region '(Set|Get) The Log To the Table.

#End Region 
#Region "<7> [Loader]{2}"
#Region"[On] |2019/07/06 00h51:505| <06.00.00> <Loader> <> |.Empty()|Function}|"' (Set|Get) The sub Empty.
    '''    <Summary>
'''     (Set|Get) The sub Empty.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:200 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The sub Empty.") >
   Public Sub New ()
Reset
   End Sub
#End Region '(Set|Get) The sub Empty.

#Region"[On] |2019/07/06 00h51:509| <06.00.01> <Loader> <> |.Filled()|Function}|"' (Set|Get) The sub Filled.
    '''    <Summary>
'''     (Set|Get) The sub Filled.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:200 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>    ''' <param name="ID">(Set|Get) The ID as Integer.</param>
    ''' <param name="Name">(Set|Get) The Name as String.</param>
    ''' <param name="ImageIndex">(Set|Get) The ImageIndex as Integer.</param>
    ''' <param name="Text">(Set|Get) The Text as String.</param>
    ''' <param name="ToolTip">(Set|Get) The ToolTip as String.</param>
    ''' <param name="Enable">(Set|Get) The Enable as Boolean.</param>
    ''' <param name="Status">(Set|Get) The Status as String.</param>
    ''' <param name="Statement">(Set|Get) The Statement as String.</param>
    ''' <param name="XMLFile">(Set|Get) The XMLFile as String.</param>
    ''' <param name="Attributes">(Set|Get) The Attributes as String.</param>
    ''' <param name="Browsable">(Set|Get) The Browsable as Boolean.</param>
    ''' <param name="Category">(Set|Get) The Category as String.</param>
    ''' <param name="Description">(Set|Get) The Description as String.</param>
    ''' <param name="DefaultValue">(Set|Get) The DefaultValue as String.</param>
    ''' <param name="Editor">(Set|Get) The Editor as String.</param>
    ''' <param name="DllImport">(Set|Get) The DllImport as String.</param>
    ''' <param name="Deserializable">(Set|Get) The Deserializable as Boolean.</param>
    ''' <param name="NonSerialized">(Set|Get) The NonSerialized as Boolean.</param>
    ''' <param name="Serializable">(Set|Get) The Serializable as Boolean.</param>
    ''' <param name="XmlRoot">(Set|Get) The XmlRoot as String.</param>
    ''' <param name="XmlIgnore">(Set|Get) The XmlIgnore as Boolean.</param>
    ''' <param name="XmlInclude">(Set|Get) The XmlInclude as Boolean.</param>
    ''' <param name="RelatedImageList">(Set|Get) The RelatedImageList as String.</param>
    ''' <param name="Print_VB">(Set|Get) The Print_VB as String.</param>
    ''' <param name="VB">(Set|Get) The VB as String.</param>
    ''' <param name="Print_C">(Set|Get) The Print_C as String.</param>
    ''' <param name="C">(Set|Get) The C as String.</param>
    ''' <param name="Print_F">(Set|Get) The Print_F as String.</param>
    ''' <param name="F">(Set|Get) The F as String.</param>
    ''' <param name="Print_Python">(Set|Get) The Print_Python as String.</param>
    ''' <param name="Python">(Set|Get) The Python as String.</param>
    ''' <param name="Print_JavaScript">(Set|Get) The Print_JavaScript as String.</param>
    ''' <param name="JavaScript">(Set|Get) The JavaScript as String.</param>
    ''' <param name="RegionCategory">(Set|Get) The RegionCategory as Integer.</param>
    ''' <param name="RegionCode">(Set|Get) The RegionCode as String.</param>
    ''' <param name="AuthorEmail">(Set|Get) The AuthorEmail as String.</param>
    ''' <param name="AuthorName">(Set|Get) The AuthorName as String.</param>
    ''' <param name="AuthorUri">(Set|Get) The AuthorUri as String.</param>
    ''' <param name="ContributorEmail">(Set|Get) The ContributorEmail as String.</param>
    ''' <param name="ContributorName">(Set|Get) The ContributorName as String.</param>
    ''' <param name="ContributorUri">(Set|Get) The ContributorUri as String.</param>
    ''' <param name="CustomProperty">(Set|Get) The CustomProperty as String.</param>
    ''' <param name="Published">(Set|Get) The Published as String.</param>
    ''' <param name="Rights">(Set|Get) The Rights as String.</param>
    ''' <param name="Summary">(Set|Get) The Summary as String.</param>
    ''' <param name="Title">(Set|Get) The Title as String.</param>
    ''' <param name="Updated">(Set|Get) The Updated as String.</param>
    ''' <param name="Usage">(Set|Get) The Usage as String.</param>
    ''' <param name="Remarks">(Set|Get) The Remarks as String.</param>
    ''' <param name="Example">(Set|Get) The Example as String.</param>
    ''' <param name="Note">(Set|Get) The Note as String.</param>
    ''' <param name="CreationDate">(Set|Get) The CreationDate as String.</param>
    ''' <param name="See">(Set|Get) The See as String.</param>
    ''' <param name="SeeAlso">(Set|Get) The SeeAlso as String.</param>
    ''' <param name="Rules">(Set|Get) The Rules as String.</param>
    ''' <param name="Syntax">(Set|Get) The Syntax as String.</param>
    ''' <param name="AccessModifier">(Set|Get) The AccessModifier as String.</param>
    ''' <param name="ProcedureModifier">(Set|Get) The ProcedureModifier as String.</param>
    ''' <param name="Partial">(Set|Get) The Partial as Boolean.</param>
    ''' <param name="Shared">(Set|Get) The Shared as Boolean.</param>
    ''' <param name="Shadows">(Set|Get) The Shadows as Boolean.</param>
    ''' <param name="Async">(Set|Get) The Async as Boolean.</param>
    ''' <param name="SubName">(Set|Get) The SubName as String.</param>
    ''' <param name="Handles">(Set|Get) The Handles as String.</param>
    ''' <param name="Implements">(Set|Get) The Implements as String.</param>

    <Browsable(True) , Description("(Set|Get) The sub Filled.") >
   Public Sub New (ByVal ID As Integer, 
ByVal Name As String, 
ByVal ImageIndex As Integer, 
ByVal Text As String, 
ByVal ToolTip As String, 
ByVal Enable As Boolean, 
ByVal Status As String, 
ByVal Statement As String, 
ByVal XMLFile As String, 
ByVal Attributes As String, 
ByVal Browsable As Boolean, 
ByVal Category As String, 
ByVal Description As String, 
ByVal DefaultValue As String, 
ByVal Editor As String, 
ByVal DllImport As String, 
ByVal Deserializable As Boolean, 
ByVal NonSerialized As Boolean, 
ByVal Serializable As Boolean, 
ByVal XmlRoot As String, 
ByVal XmlIgnore As Boolean, 
ByVal XmlInclude As Boolean, 
ByVal RelatedImageList As String, 
ByVal Print_VB As String, 
ByVal VB As String, 
ByVal Print_C As String, 
ByVal C As String, 
ByVal Print_F As String, 
ByVal F As String, 
ByVal Print_Python As String, 
ByVal Python As String, 
ByVal Print_JavaScript As String, 
ByVal JavaScript As String, 
ByVal RegionCategory As Integer, 
ByVal RegionCode As String, 
ByVal AuthorEmail As String, 
ByVal AuthorName As String, 
ByVal AuthorUri As String, 
ByVal ContributorEmail As String, 
ByVal ContributorName As String, 
ByVal ContributorUri As String, 
ByVal CustomProperty As String, 
ByVal Published As String, 
ByVal Rights As String, 
ByVal Summary As String, 
ByVal Title As String, 
ByVal Updated As String, 
ByVal Usage As String, 
ByVal Remarks As String, 
ByVal Example As String, 
ByVal Note As String, 
ByVal CreationDate As String, 
ByVal See As String, 
ByVal SeeAlso As String, 
ByVal Rules As String, 
ByVal Syntax As String, 
ByVal AccessModifier As String, 
ByVal ProcedureModifier As String, 
ByVal Partial As Boolean, 
ByVal Shared As Boolean, 
ByVal Shadows As Boolean, 
ByVal Async As Boolean, 
ByVal SubName As String, 
ByVal Handles As String, 
ByVal Implements As String)
 With Me
 Clear()
 Reset()
     .ID = ID
     .Name = Name
     .ImageIndex = ImageIndex
     .Text = Text
     .ToolTip = ToolTip
     .Enable = Enable
     .Status = Status
     .Statement = Statement
     .XMLFile = XMLFile
     .Attributes = Attributes
     .Browsable = Browsable
     .Category = Category
     .Description = Description
     .DefaultValue = DefaultValue
     .Editor = Editor
     .DllImport = DllImport
     .Deserializable = Deserializable
     .NonSerialized = NonSerialized
     .Serializable = Serializable
     .XmlRoot = XmlRoot
     .XmlIgnore = XmlIgnore
     .XmlInclude = XmlInclude
     .RelatedImageList = RelatedImageList
     .Print_VB = Print_VB
     .VB = VB
     .Print_C = Print_C
     .C = C
     .Print_F = Print_F
     .F = F
     .Print_Python = Print_Python
     .Python = Python
     .Print_JavaScript = Print_JavaScript
     .JavaScript = JavaScript
     .RegionCategory = RegionCategory
     .RegionCode = RegionCode
     .AuthorEmail = AuthorEmail
     .AuthorName = AuthorName
     .AuthorUri = AuthorUri
     .ContributorEmail = ContributorEmail
     .ContributorName = ContributorName
     .ContributorUri = ContributorUri
     .CustomProperty = CustomProperty
     .Published = Published
     .Rights = Rights
     .Summary = Summary
     .Title = Title
     .Updated = Updated
     .Usage = Usage
     .Remarks = Remarks
     .Example = Example
     .Note = Note
     .CreationDate = CreationDate
     .See = See
     .SeeAlso = SeeAlso
     .Rules = Rules
     .Syntax = Syntax
     .AccessModifier = AccessModifier
     .ProcedureModifier = ProcedureModifier
     .Partial = Partial
     .Shared = Shared
     .Shadows = Shadows
     .Async = Async
     .SubName = SubName
     .Handles = Handles
     .Implements = Implements
 End With

   End Sub
#End Region '(Set|Get) The sub Filled.

#End Region 
 End Class
#End Region

#Region"[On] |2019/07/06 00h51:733| <08.00.00> <Class> <> |.Initializor_ProjectDatabase|Class|{22} |Production Cost : 18.2|Selling Price : 45.5|"' 
'''    <Summary>
'''     '''    Object Name :             Public  Class Initializor_ProjectDatabase
'''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
'''    Contributor Information : ||
'''    Creation Date :           2019/07/06 00h51:733
'''    |Schema|
'''    |ID| |ObjectType |{Quantity}||UnitPrice||Total
'''    |00| |Importation|{0}||1| |0
'''    |01| |Properties |{14}||0.8| |11.2
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
'''    |Production Cost             |18.2
'''    |Selling Price without VAT   |45.5
'''    |Total TVA                   |3.5
'''    |Grand Total                 |49
'''    |/Schema|
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:250 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
Public  Class Initializor_ProjectDatabase
#Region "<1> [Property]{14}"
#Region"[On] |2019/07/06 00h51:734| <01.00.00> <Property> <Virtualized Properties> |.Enumeration()|Enumeration|"' (Set|Get) 
   Private _Enumeration As Enumeration
    '''    <Summary>
'''     (Set|Get) 
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:251 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Virtualized Properties") , Description("(Set|Get) ") >
   Public Property Enumeration()As Enumeration
       Get
       Return _Enumeration
       End Get
       Set(ByVal Value As Enumeration)
       _Enumeration = Value
       End Set
   End Property
#End Region '(Set|Get) 

#Region"[On] |2019/07/06 00h51:745| <01.00.01> <Property> <List> |.List_Enumeration()|List(Of Enumeration)|"' (Set|Get) 
   Private _List_Enumeration As List(Of Enumeration)
    '''    <Summary>
'''     (Set|Get) 
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:251 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("List") , Description("(Set|Get) ") >
   Public Property List_Enumeration()As List(Of Enumeration)
       Get
       Return _List_Enumeration
       End Get
       Set(ByVal Value As List(Of Enumeration))
       _List_Enumeration = Value
       End Set
   End Property
#End Region '(Set|Get) 

#Region"[On] |2019/07/06 00h51:755| <01.00.02> <Property> <Virtualized Properties> |.Function()|Function|"' (Set|Get) 
   Private _Function As Function
    '''    <Summary>
'''     (Set|Get) 
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:251 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Virtualized Properties") , Description("(Set|Get) ") >
   Public Property Function()As Function
       Get
       Return _Function
       End Get
       Set(ByVal Value As Function)
       _Function = Value
       End Set
   End Property
#End Region '(Set|Get) 

#Region"[On] |2019/07/06 00h51:766| <01.00.03> <Property> <List> |.List_Function()|List(Of Function)|"' (Set|Get) 
   Private _List_Function As List(Of Function)
    '''    <Summary>
'''     (Set|Get) 
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:252 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("List") , Description("(Set|Get) ") >
   Public Property List_Function()As List(Of Function)
       Get
       Return _List_Function
       End Get
       Set(ByVal Value As List(Of Function))
       _List_Function = Value
       End Set
   End Property
#End Region '(Set|Get) 

#Region"[On] |2019/07/06 00h51:779| <01.00.04> <Property> <Virtualized Properties> |.Property()|Property|"' (Set|Get) 
   Private _Property As Property
    '''    <Summary>
'''     (Set|Get) 
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:252 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Virtualized Properties") , Description("(Set|Get) ") >
   Public Property Property()As Property
       Get
       Return _Property
       End Get
       Set(ByVal Value As Property)
       _Property = Value
       End Set
   End Property
#End Region '(Set|Get) 

#Region"[On] |2019/07/06 00h51:789| <01.00.05> <Property> <List> |.List_Property()|List(Of Property)|"' (Set|Get) 
   Private _List_Property As List(Of Property)
    '''    <Summary>
'''     (Set|Get) 
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:256 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("List") , Description("(Set|Get) ") >
   Public Property List_Property()As List(Of Property)
       Get
       Return _List_Property
       End Get
       Set(ByVal Value As List(Of Property))
       _List_Property = Value
       End Set
   End Property
#End Region '(Set|Get) 

#Region"[On] |2019/07/06 00h51:801| <01.00.06> <Property> <Virtualized Properties> |.Statement()|Statement|"' (Set|Get) 
   Private _Statement As Statement
    '''    <Summary>
'''     (Set|Get) 
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:256 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Virtualized Properties") , Description("(Set|Get) ") >
   Public Property Statement()As Statement
       Get
       Return _Statement
       End Get
       Set(ByVal Value As Statement)
       _Statement = Value
       End Set
   End Property
#End Region '(Set|Get) 

#Region"[On] |2019/07/06 00h51:812| <01.00.07> <Property> <List> |.List_Statement()|List(Of Statement)|"' (Set|Get) 
   Private _List_Statement As List(Of Statement)
    '''    <Summary>
'''     (Set|Get) 
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:256 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("List") , Description("(Set|Get) ") >
   Public Property List_Statement()As List(Of Statement)
       Get
       Return _List_Statement
       End Get
       Set(ByVal Value As List(Of Statement))
       _List_Statement = Value
       End Set
   End Property
#End Region '(Set|Get) 

#Region"[On] |2019/07/06 00h51:823| <01.00.08> <Property> <Virtualized Properties> |.Structure()|Structure|"' (Set|Get) 
   Private _Structure As Structure
    '''    <Summary>
'''     (Set|Get) 
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:256 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Virtualized Properties") , Description("(Set|Get) ") >
   Public Property Structure()As Structure
       Get
       Return _Structure
       End Get
       Set(ByVal Value As Structure)
       _Structure = Value
       End Set
   End Property
#End Region '(Set|Get) 

#Region"[On] |2019/07/06 00h51:834| <01.00.09> <Property> <List> |.List_Structure()|List(Of Structure)|"' (Set|Get) 
   Private _List_Structure As List(Of Structure)
    '''    <Summary>
'''     (Set|Get) 
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:257 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("List") , Description("(Set|Get) ") >
   Public Property List_Structure()As List(Of Structure)
       Get
       Return _List_Structure
       End Get
       Set(ByVal Value As List(Of Structure))
       _List_Structure = Value
       End Set
   End Property
#End Region '(Set|Get) 

#Region"[On] |2019/07/06 00h51:846| <01.00.10> <Property> <Virtualized Properties> |.Sub()|Sub|"' (Set|Get) 
   Private _Sub As Sub
    '''    <Summary>
'''     (Set|Get) 
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:257 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Virtualized Properties") , Description("(Set|Get) ") >
   Public Property Sub()As Sub
       Get
       Return _Sub
       End Get
       Set(ByVal Value As Sub)
       _Sub = Value
       End Set
   End Property
#End Region '(Set|Get) 

#Region"[On] |2019/07/06 00h51:856| <01.00.11> <Property> <List> |.List_Sub()|List(Of Sub)|"' (Set|Get) 
   Private _List_Sub As List(Of Sub)
    '''    <Summary>
'''     (Set|Get) 
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:257 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("List") , Description("(Set|Get) ") >
   Public Property List_Sub()As List(Of Sub)
       Get
       Return _List_Sub
       End Get
       Set(ByVal Value As List(Of Sub))
       _List_Sub = Value
       End Set
   End Property
#End Region '(Set|Get) 

#Region"[On] |2019/07/06 00h51:867| <01.00.12> <Property> <Portfolio> |.Portfolio()|List(Of Object)|"' (Set|Get) 
   Private Shared _Portfolio As List(Of Object)
    '''    <Summary>
'''     (Set|Get) 
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:257 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("Portfolio") , Description("(Set|Get) ") >
   Public Shared Property Portfolio()As List(Of Object)
       Get
       Return _Portfolio
       End Get
       Set(ByVal Value As List(Of Object))
       _Portfolio = Value
       End Set
   End Property
#End Region '(Set|Get) 

#Region"[On] |2019/07/06 00h51:879| <01.00.13> <Property> <DataBase> |.DataBase()|SmartCoder.M_FileManager.DataBase|"' (Set|Get) 
   Private Shared _DataBase As SmartCoder.M_FileManager.DataBase
    '''    <Summary>
'''     (Set|Get) 
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:257 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , CategoryAttribute("DataBase") , Description("(Set|Get) ") >
   Public Shared Property DataBase()As SmartCoder.M_FileManager.DataBase
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
#Region"[On] |2019/07/06 00h51:890| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class properties element.
    '''    <Summary>
'''     (Set|Get) This will reinitialize the class properties element.
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:260 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) This will reinitialize the class properties element.") >
   Public Sub Clear()
  With Me
         .Enumeration = New Enumeration
        .List_Enumeration = New List(Of Enumeration)
         .Function = New Function
        .List_Function = New List(Of Function)
         .Property = New Property
        .List_Property = New List(Of Property)
         .Statement = New Statement
        .List_Statement = New List(Of Statement)
         .Structure = New Structure
        .List_Structure = New List(Of Structure)
         .Sub = New Sub
        .List_Sub = New List(Of Sub)
        Portfolio = New List(Of Object)
         DataBase = New SmartCoder.M_FileManager.DataBase
 End With
   End Sub
#End Region '(Set|Get) This will reinitialize the class properties element.

#End Region 
#Region "<5> [Function]{1}"
#Region"[On] |2019/07/06 00h51:908| <05.00.00> <Function> <> |.CheckConnection()|Boolean}|"' (Set|Get) Evaluate the connection to the DataBase
    '''    <Summary>
'''     (Set|Get) Evaluate the connection to the DataBase
'''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
'''    <AuthorName>Saadry Dunkel</AuthorName>
'''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:260 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) Evaluate the connection to the DataBase") >
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
    Dim Message As String = Nothing' Stores the process logic.
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
        If D.IsReady  Then
            Test_4 = True
        Message += "Test 4 <Result> |OK| The Drive is Online."
        Else
            Test_4 = False
        Message += "Test 4 <Result> |PB| The Drive is Offline or Disconnected."
        End If
 #End Region 
 #Region "Test 5 | Evaluate if there is a Password."
        If Not IsDbNull(Password) Then
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
                    Me.Connector = New LineInfo(FilePath,Password)
                    Me.Line = Me.Connector.Line
        Message += "Test 6 <Result> |Initialize Connector|"
                End If
        End If
 #End Region 
 #Region "Test 7 | Evaluate if Connector Line is not empty."
        If Not IsDbNull(Me.Connector.Line) Then
            Test_7 = True
        Else 
            Test_7 = False
        End If
 #End Region 
 #Region "Test 8 | Evaluate if the Connection is valid."
        If Test_7 =True Then
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
 If Test_7=True And Test_8 = True Then
    General_Status=True
 Else 
    General_Status=False
 End If
 Return General_Status

   End Function
#End Region '(Set|Get) Evaluate the connection to the DataBase

#End Region 
#Region "<6> [Runtime]{4}"
#Region"[On] |2019/07/06 00h51:922| <15.00.00> <Runtime> <> |.Line()|String"' (Set|Get) The Connection String To the Table.
    '''    <Summary>
'''     (Set|Get) The Connection String To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:260 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The Connection String To the Table.") >
   Public  Line As String
#End Region '(Set|Get) The Connection String To the Table.

#Region"[On] |2019/07/06 00h51:934| <15.00.01> <Runtime> <> |.FilePath()|String"' (Set|Get) The FilePath To the Table.
    '''    <Summary>
'''     (Set|Get) The FilePath To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:260 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The FilePath To the Table.") >
   Public  FilePath As String
#End Region '(Set|Get) The FilePath To the Table.

#Region"[On] |2019/07/06 00h51:945| <15.00.02> <Runtime> <> |.Password()|String"' (Set|Get) The Password To the Table.
    '''    <Summary>
'''     (Set|Get) The Password To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:260 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The Password To the Table.") >
   Public  Password As String
#End Region '(Set|Get) The Password To the Table.

#Region"[On] |2019/07/06 00h51:957| <15.00.03> <Runtime> <> |.Connector()|LineInfo"' (Set|Get) The Connector To the Table.
    '''    <Summary>
'''     (Set|Get) The Connector To the Table.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:260 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The Connector To the Table.") >
   Public  Connector As LineInfo
#End Region '(Set|Get) The Connector To the Table.

#End Region 
#Region "<7> [Loader]{2}"
#Region"[On] |2019/07/06 00h51:968| <06.00.00> <Loader> <> |.Empty()|Function}|"' (Set|Get) The sub Empty.
    '''    <Summary>
'''     (Set|Get) The sub Empty.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:261 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>
    <Browsable(True) , Description("(Set|Get) The sub Empty.") >
   Public Sub New ()
Clear
   End Sub
#End Region '(Set|Get) The sub Empty.

#Region"[On] |2019/07/06 00h51:970| <06.00.01> <Loader> <> |.Filled()|Function}|"' (Set|Get) The sub Filled.
    '''    <Summary>
'''     (Set|Get) The sub Filled.
'''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
'''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
'''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
'''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:261 </Published>
'''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
'''    </Summary>    ''' <param name="FilePath">The initial File Path</param>
    ''' <param name="Password">The password</param>

    <Browsable(True) , Description("(Set|Get) The sub Filled.") >
   Public Sub New (ByVal FilePath As String, 
Optional ByVal Password As String = """")
 With Me
 Clear()
     .Enumeration = New Enumeration
     .List_Enumeration = New List(Of Enumeration)
     .Function = New Function
     .List_Function = New List(Of Function)
     .Property = New Property
     .List_Property = New List(Of Property)
     .Statement = New Statement
     .List_Statement = New List(Of Statement)
     .Structure = New Structure
     .List_Structure = New List(Of Structure)
     .Sub = New Sub
     .List_Sub = New List(Of Sub)
     Portfolio = New List(Of Object)
     DataBase = New SmartCoder.M_FileManager.DataBase
 End With
     Portfolio= New List(Of Object)
     FilePath = FilePath
     Password= Password
     Line= Line
     Dim M As New LineInfo(FilePath,Password)
     My.Settings.Db_ProjectDatabase_FilePath = FilePath
     My.Settings.Db_ProjectDatabase_Password = Password
     My.Settings.Db_ProjectDatabase_Line = Line 
     My.Settings.Save
      With Enumeration
          .Reset(M)
      End With
      List_Enumeration = New List(Of Enumeration)
      List_Enumeration = Enumeration.List()
      With Function
          .Reset(M)
      End With
      List_Function = New List(Of Function)
      List_Function = Function.List()
      With Property
          .Reset(M)
      End With
      List_Property = New List(Of Property)
      List_Property = Property.List()
      With Statement
          .Reset(M)
      End With
      List_Statement = New List(Of Statement)
      List_Statement = Statement.List()
      With Structure
          .Reset(M)
      End With
      List_Structure = New List(Of Structure)
      List_Structure = Structure.List()
      With Sub
          .Reset(M)
      End With
      List_Sub = New List(Of Sub)
      List_Sub = Sub.List()

   End Sub
#End Region '(Set|Get) The sub Filled.

#End Region 
 End Class
#End Region

#End Region 
 End Class
#End Region
