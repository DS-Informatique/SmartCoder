 ///     <Summary>
 ///    '''    Object Name :             Public  Class VbNET
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
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:799 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
public  class VbNET{
#region <8> [Class]{7}
 ///     <Summary>
 ///    Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Enumeration
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
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:799 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
public  class Enumeration{
#region <1> [Property]{60}
#region |2019/07/06 00h51:738| <01.00.00> <Property> <Columns> |.ID()|Integer|  (Set|Get) The ID as Integer.
 ///     <Summary>
 ///    (Set|Get) The ID as Integer.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:799 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ID as Integer.") ]
    member this.ID()
       with get() = _ID
       and set(value) = _ID <- value
#endregion (Set|Get) The ID as Integer.

#region |2019/07/06 00h51:860| <01.00.01> <Property> <Columns> |.Name()|String|  (Set|Get) The Name as String.
 ///     <Summary>
 ///    (Set|Get) The Name as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:799 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Name as String.") ]
    member this.Name()
       with get() = _Name
       and set(value) = _Name <- value
#endregion (Set|Get) The Name as String.

#region |2019/07/06 00h51:875| <01.00.02> <Property> <Columns> |.ImageIndex()|Integer|  (Set|Get) The ImageIndex as Integer.
 ///     <Summary>
 ///    (Set|Get) The ImageIndex as Integer.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:800 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ImageIndex as Integer.") ]
    member this.ImageIndex()
       with get() = _ImageIndex
       and set(value) = _ImageIndex <- value
#endregion (Set|Get) The ImageIndex as Integer.

#region |2019/07/06 00h51:885| <01.00.03> <Property> <Columns> |.Text()|String|  (Set|Get) The Text as String.
 ///     <Summary>
 ///    (Set|Get) The Text as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:800 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Text as String.") ]
    member this.Text()
       with get() = _Text
       and set(value) = _Text <- value
#endregion (Set|Get) The Text as String.

#region |2019/07/06 00h51:895| <01.00.04> <Property> <Columns> |.ToolTip()|String|  (Set|Get) The ToolTip as String.
 ///     <Summary>
 ///    (Set|Get) The ToolTip as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:800 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ToolTip as String.") ]
    member this.ToolTip()
       with get() = _ToolTip
       and set(value) = _ToolTip <- value
#endregion (Set|Get) The ToolTip as String.

#region |2019/07/06 00h51:906| <01.00.05> <Property> <Columns> |.Enable()|Boolean|  (Set|Get) The Enable as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Enable as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:800 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Enable as Boolean.") ]
    member this.Enable()
       with get() = _Enable
       and set(value) = _Enable <- value
#endregion (Set|Get) The Enable as Boolean.

#region |2019/07/06 00h51:917| <01.00.06> <Property> <Columns> |.Status()|String|  (Set|Get) The Status as String.
 ///     <Summary>
 ///    (Set|Get) The Status as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:800 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Status as String.") ]
    member this.Status()
       with get() = _Status
       and set(value) = _Status <- value
#endregion (Set|Get) The Status as String.

#region |2019/07/06 00h51:928| <01.00.07> <Property> <Columns> |.Statement()|String|  (Set|Get) The Statement as String.
 ///     <Summary>
 ///    (Set|Get) The Statement as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:801 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Statement as String.") ]
    member this.Statement()
       with get() = _Statement
       and set(value) = _Statement <- value
#endregion (Set|Get) The Statement as String.

#region |2019/07/06 00h51:938| <01.00.08> <Property> <Columns> |.XMLFile()|String|  (Set|Get) The XMLFile as String.
 ///     <Summary>
 ///    (Set|Get) The XMLFile as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:801 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XMLFile as String.") ]
    member this.XMLFile()
       with get() = _XMLFile
       and set(value) = _XMLFile <- value
#endregion (Set|Get) The XMLFile as String.

#region |2019/07/06 00h51:950| <01.00.09> <Property> <Columns> |.Attributes()|String|  (Set|Get) The Attributes as String.
 ///     <Summary>
 ///    (Set|Get) The Attributes as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:801 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Attributes as String.") ]
    member this.Attributes()
       with get() = _Attributes
       and set(value) = _Attributes <- value
#endregion (Set|Get) The Attributes as String.

#region |2019/07/06 00h51:960| <01.00.10> <Property> <Columns> |.Browsable()|Boolean|  (Set|Get) The Browsable as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Browsable as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:801 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Browsable as Boolean.") ]
    member this.Browsable()
       with get() = _Browsable
       and set(value) = _Browsable <- value
#endregion (Set|Get) The Browsable as Boolean.

#region |2019/07/06 00h51:970| <01.00.11> <Property> <Columns> |.Category()|String|  (Set|Get) The Category as String.
 ///     <Summary>
 ///    (Set|Get) The Category as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:801 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Category as String.") ]
    member this.Category()
       with get() = _Category
       and set(value) = _Category <- value
#endregion (Set|Get) The Category as String.

#region |2019/07/06 00h51:984| <01.00.12> <Property> <Columns> |.Description()|String|  (Set|Get) The Description as String.
 ///     <Summary>
 ///    (Set|Get) The Description as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:801 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Description as String.") ]
    member this.Description()
       with get() = _Description
       and set(value) = _Description <- value
#endregion (Set|Get) The Description as String.

#region |2019/07/06 00h51:995| <01.00.13> <Property> <Columns> |.DefaultValue()|String|  (Set|Get) The DefaultValue as String.
 ///     <Summary>
 ///    (Set|Get) The DefaultValue as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:802 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The DefaultValue as String.") ]
    member this.DefaultValue()
       with get() = _DefaultValue
       and set(value) = _DefaultValue <- value
#endregion (Set|Get) The DefaultValue as String.

#region |2019/07/06 00h51:006| <01.00.14> <Property> <Columns> |.Editor()|String|  (Set|Get) The Editor as String.
 ///     <Summary>
 ///    (Set|Get) The Editor as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:802 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Editor as String.") ]
    member this.Editor()
       with get() = _Editor
       and set(value) = _Editor <- value
#endregion (Set|Get) The Editor as String.

#region |2019/07/06 00h51:017| <01.00.15> <Property> <Columns> |.DllImport()|String|  (Set|Get) The DllImport as String.
 ///     <Summary>
 ///    (Set|Get) The DllImport as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:802 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The DllImport as String.") ]
    member this.DllImport()
       with get() = _DllImport
       and set(value) = _DllImport <- value
#endregion (Set|Get) The DllImport as String.

#region |2019/07/06 00h51:028| <01.00.16> <Property> <Columns> |.Deserializable()|Boolean|  (Set|Get) The Deserializable as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Deserializable as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:804 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Deserializable as Boolean.") ]
    member this.Deserializable()
       with get() = _Deserializable
       and set(value) = _Deserializable <- value
#endregion (Set|Get) The Deserializable as Boolean.

#region |2019/07/06 00h51:040| <01.00.17> <Property> <Columns> |.NonSerialized()|Boolean|  (Set|Get) The NonSerialized as Boolean.
 ///     <Summary>
 ///    (Set|Get) The NonSerialized as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:804 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The NonSerialized as Boolean.") ]
    member this.NonSerialized()
       with get() = _NonSerialized
       and set(value) = _NonSerialized <- value
#endregion (Set|Get) The NonSerialized as Boolean.

#region |2019/07/06 00h51:051| <01.00.18> <Property> <Columns> |.Serializable()|Boolean|  (Set|Get) The Serializable as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Serializable as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:804 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Serializable as Boolean.") ]
    member this.Serializable()
       with get() = _Serializable
       and set(value) = _Serializable <- value
#endregion (Set|Get) The Serializable as Boolean.

#region |2019/07/06 00h51:063| <01.00.19> <Property> <Columns> |.XmlRoot()|String|  (Set|Get) The XmlRoot as String.
 ///     <Summary>
 ///    (Set|Get) The XmlRoot as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:804 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XmlRoot as String.") ]
    member this.XmlRoot()
       with get() = _XmlRoot
       and set(value) = _XmlRoot <- value
#endregion (Set|Get) The XmlRoot as String.

#region |2019/07/06 00h51:074| <01.00.20> <Property> <Columns> |.XmlIgnore()|Boolean|  (Set|Get) The XmlIgnore as Boolean.
 ///     <Summary>
 ///    (Set|Get) The XmlIgnore as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:805 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XmlIgnore as Boolean.") ]
    member this.XmlIgnore()
       with get() = _XmlIgnore
       and set(value) = _XmlIgnore <- value
#endregion (Set|Get) The XmlIgnore as Boolean.

#region |2019/07/06 00h51:085| <01.00.21> <Property> <Columns> |.XmlInclude()|Boolean|  (Set|Get) The XmlInclude as Boolean.
 ///     <Summary>
 ///    (Set|Get) The XmlInclude as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:805 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XmlInclude as Boolean.") ]
    member this.XmlInclude()
       with get() = _XmlInclude
       and set(value) = _XmlInclude <- value
#endregion (Set|Get) The XmlInclude as Boolean.

#region |2019/07/06 00h51:097| <01.00.22> <Property> <Columns> |.RelatedImageList()|String|  (Set|Get) The RelatedImageList as String.
 ///     <Summary>
 ///    (Set|Get) The RelatedImageList as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:805 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The RelatedImageList as String.") ]
    member this.RelatedImageList()
       with get() = _RelatedImageList
       and set(value) = _RelatedImageList <- value
#endregion (Set|Get) The RelatedImageList as String.

#region |2019/07/06 00h51:109| <01.00.23> <Property> <Columns> |.Print_VB()|String|  (Set|Get) The Print_VB as String.
 ///     <Summary>
 ///    (Set|Get) The Print_VB as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:805 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_VB as String.") ]
    member this.Print_VB()
       with get() = _Print_VB
       and set(value) = _Print_VB <- value
#endregion (Set|Get) The Print_VB as String.

#region |2019/07/06 00h51:126| <01.00.24> <Property> <Columns> |.VB()|String|  (Set|Get) The VB as String.
 ///     <Summary>
 ///    (Set|Get) The VB as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:805 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The VB as String.") ]
    member this.VB()
       with get() = _VB
       and set(value) = _VB <- value
#endregion (Set|Get) The VB as String.

#region |2019/07/06 00h51:137| <01.00.25> <Property> <Columns> |.Print_C()|String|  (Set|Get) The Print_C as String.
 ///     <Summary>
 ///    (Set|Get) The Print_C as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:806 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_C as String.") ]
    member this.Print_C()
       with get() = _Print_C
       and set(value) = _Print_C <- value
#endregion (Set|Get) The Print_C as String.

#region |2019/07/06 00h51:149| <01.00.26> <Property> <Columns> |.C()|String|  (Set|Get) The C as String.
 ///     <Summary>
 ///    (Set|Get) The C as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:806 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The C as String.") ]
    member this.C()
       with get() = _C
       and set(value) = _C <- value
#endregion (Set|Get) The C as String.

#region |2019/07/06 00h51:160| <01.00.27> <Property> <Columns> |.Print_F()|String|  (Set|Get) The Print_F as String.
 ///     <Summary>
 ///    (Set|Get) The Print_F as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:806 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_F as String.") ]
    member this.Print_F()
       with get() = _Print_F
       and set(value) = _Print_F <- value
#endregion (Set|Get) The Print_F as String.

#region |2019/07/06 00h51:171| <01.00.28> <Property> <Columns> |.F()|String|  (Set|Get) The F as String.
 ///     <Summary>
 ///    (Set|Get) The F as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:806 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The F as String.") ]
    member this.F()
       with get() = _F
       and set(value) = _F <- value
#endregion (Set|Get) The F as String.

#region |2019/07/06 00h51:183| <01.00.29> <Property> <Columns> |.Print_Python()|String|  (Set|Get) The Print_Python as String.
 ///     <Summary>
 ///    (Set|Get) The Print_Python as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:806 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_Python as String.") ]
    member this.Print_Python()
       with get() = _Print_Python
       and set(value) = _Print_Python <- value
#endregion (Set|Get) The Print_Python as String.

#region |2019/07/06 00h51:195| <01.00.30> <Property> <Columns> |.Python()|String|  (Set|Get) The Python as String.
 ///     <Summary>
 ///    (Set|Get) The Python as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:807 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Python as String.") ]
    member this.Python()
       with get() = _Python
       and set(value) = _Python <- value
#endregion (Set|Get) The Python as String.

#region |2019/07/06 00h51:207| <01.00.31> <Property> <Columns> |.Print_JavaScript()|String|  (Set|Get) The Print_JavaScript as String.
 ///     <Summary>
 ///    (Set|Get) The Print_JavaScript as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:807 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_JavaScript as String.") ]
    member this.Print_JavaScript()
       with get() = _Print_JavaScript
       and set(value) = _Print_JavaScript <- value
#endregion (Set|Get) The Print_JavaScript as String.

#region |2019/07/06 00h51:220| <01.00.32> <Property> <Columns> |.JavaScript()|String|  (Set|Get) The JavaScript as String.
 ///     <Summary>
 ///    (Set|Get) The JavaScript as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:807 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The JavaScript as String.") ]
    member this.JavaScript()
       with get() = _JavaScript
       and set(value) = _JavaScript <- value
#endregion (Set|Get) The JavaScript as String.

#region |2019/07/06 00h51:232| <01.00.33> <Property> <Columns> |.RegionCategory()|Integer|  (Set|Get) The RegionCategory as Integer.
 ///     <Summary>
 ///    (Set|Get) The RegionCategory as Integer.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:807 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The RegionCategory as Integer.") ]
    member this.RegionCategory()
       with get() = _RegionCategory
       and set(value) = _RegionCategory <- value
#endregion (Set|Get) The RegionCategory as Integer.

#region |2019/07/06 00h51:244| <01.00.34> <Property> <Columns> |.RegionCode()|String|  (Set|Get) The RegionCode as String.
 ///     <Summary>
 ///    (Set|Get) The RegionCode as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:807 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The RegionCode as String.") ]
    member this.RegionCode()
       with get() = _RegionCode
       and set(value) = _RegionCode <- value
#endregion (Set|Get) The RegionCode as String.

#region |2019/07/06 00h51:255| <01.00.35> <Property> <Columns> |.AuthorEmail()|String|  (Set|Get) The AuthorEmail as String.
 ///     <Summary>
 ///    (Set|Get) The AuthorEmail as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:808 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AuthorEmail as String.") ]
    member this.AuthorEmail()
       with get() = _AuthorEmail
       and set(value) = _AuthorEmail <- value
#endregion (Set|Get) The AuthorEmail as String.

#region |2019/07/06 00h51:267| <01.00.36> <Property> <Columns> |.AuthorName()|String|  (Set|Get) The AuthorName as String.
 ///     <Summary>
 ///    (Set|Get) The AuthorName as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:808 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AuthorName as String.") ]
    member this.AuthorName()
       with get() = _AuthorName
       and set(value) = _AuthorName <- value
#endregion (Set|Get) The AuthorName as String.

#region |2019/07/06 00h51:279| <01.00.37> <Property> <Columns> |.AuthorUri()|String|  (Set|Get) The AuthorUri as String.
 ///     <Summary>
 ///    (Set|Get) The AuthorUri as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:808 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AuthorUri as String.") ]
    member this.AuthorUri()
       with get() = _AuthorUri
       and set(value) = _AuthorUri <- value
#endregion (Set|Get) The AuthorUri as String.

#region |2019/07/06 00h51:303| <01.00.38> <Property> <Columns> |.ContributorEmail()|String|  (Set|Get) The ContributorEmail as String.
 ///     <Summary>
 ///    (Set|Get) The ContributorEmail as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:808 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ContributorEmail as String.") ]
    member this.ContributorEmail()
       with get() = _ContributorEmail
       and set(value) = _ContributorEmail <- value
#endregion (Set|Get) The ContributorEmail as String.

#region |2019/07/06 00h51:315| <01.00.39> <Property> <Columns> |.ContributorName()|String|  (Set|Get) The ContributorName as String.
 ///     <Summary>
 ///    (Set|Get) The ContributorName as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:808 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ContributorName as String.") ]
    member this.ContributorName()
       with get() = _ContributorName
       and set(value) = _ContributorName <- value
#endregion (Set|Get) The ContributorName as String.

#region |2019/07/06 00h51:327| <01.00.40> <Property> <Columns> |.ContributorUri()|String|  (Set|Get) The ContributorUri as String.
 ///     <Summary>
 ///    (Set|Get) The ContributorUri as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:809 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ContributorUri as String.") ]
    member this.ContributorUri()
       with get() = _ContributorUri
       and set(value) = _ContributorUri <- value
#endregion (Set|Get) The ContributorUri as String.

#region |2019/07/06 00h51:340| <01.00.41> <Property> <Columns> |.CustomProperty()|String|  (Set|Get) The CustomProperty as String.
 ///     <Summary>
 ///    (Set|Get) The CustomProperty as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:809 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The CustomProperty as String.") ]
    member this.CustomProperty()
       with get() = _CustomProperty
       and set(value) = _CustomProperty <- value
#endregion (Set|Get) The CustomProperty as String.

#region |2019/07/06 00h51:353| <01.00.42> <Property> <Columns> |.Published()|String|  (Set|Get) The Published as String.
 ///     <Summary>
 ///    (Set|Get) The Published as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:809 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Published as String.") ]
    member this.Published()
       with get() = _Published
       and set(value) = _Published <- value
#endregion (Set|Get) The Published as String.

#region |2019/07/06 00h51:366| <01.00.43> <Property> <Columns> |.Rights()|String|  (Set|Get) The Rights as String.
 ///     <Summary>
 ///    (Set|Get) The Rights as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:810 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Rights as String.") ]
    member this.Rights()
       with get() = _Rights
       and set(value) = _Rights <- value
#endregion (Set|Get) The Rights as String.

#region |2019/07/06 00h51:378| <01.00.44> <Property> <Columns> |.Summary()|String|  (Set|Get) The Summary as String.
 ///     <Summary>
 ///    (Set|Get) The Summary as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:810 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Summary as String.") ]
    member this.Summary()
       with get() = _Summary
       and set(value) = _Summary <- value
#endregion (Set|Get) The Summary as String.

#region |2019/07/06 00h51:391| <01.00.45> <Property> <Columns> |.Title()|String|  (Set|Get) The Title as String.
 ///     <Summary>
 ///    (Set|Get) The Title as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:810 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Title as String.") ]
    member this.Title()
       with get() = _Title
       and set(value) = _Title <- value
#endregion (Set|Get) The Title as String.

#region |2019/07/06 00h51:404| <01.00.46> <Property> <Columns> |.Updated()|String|  (Set|Get) The Updated as String.
 ///     <Summary>
 ///    (Set|Get) The Updated as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:810 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Updated as String.") ]
    member this.Updated()
       with get() = _Updated
       and set(value) = _Updated <- value
#endregion (Set|Get) The Updated as String.

#region |2019/07/06 00h51:417| <01.00.47> <Property> <Columns> |.Usage()|String|  (Set|Get) The Usage as String.
 ///     <Summary>
 ///    (Set|Get) The Usage as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:811 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Usage as String.") ]
    member this.Usage()
       with get() = _Usage
       and set(value) = _Usage <- value
#endregion (Set|Get) The Usage as String.

#region |2019/07/06 00h51:430| <01.00.48> <Property> <Columns> |.Remarks()|String|  (Set|Get) The Remarks as String.
 ///     <Summary>
 ///    (Set|Get) The Remarks as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:811 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Remarks as String.") ]
    member this.Remarks()
       with get() = _Remarks
       and set(value) = _Remarks <- value
#endregion (Set|Get) The Remarks as String.

#region |2019/07/06 00h51:444| <01.00.49> <Property> <Columns> |.Example()|String|  (Set|Get) The Example as String.
 ///     <Summary>
 ///    (Set|Get) The Example as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:811 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Example as String.") ]
    member this.Example()
       with get() = _Example
       and set(value) = _Example <- value
#endregion (Set|Get) The Example as String.

#region |2019/07/06 00h51:461| <01.00.50> <Property> <Columns> |.Note()|String|  (Set|Get) The Note as String.
 ///     <Summary>
 ///    (Set|Get) The Note as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:812 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Note as String.") ]
    member this.Note()
       with get() = _Note
       and set(value) = _Note <- value
#endregion (Set|Get) The Note as String.

#region |2019/07/06 00h51:476| <01.00.51> <Property> <Columns> |.CreationDate()|String|  (Set|Get) The CreationDate as String.
 ///     <Summary>
 ///    (Set|Get) The CreationDate as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:812 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The CreationDate as String.") ]
    member this.CreationDate()
       with get() = _CreationDate
       and set(value) = _CreationDate <- value
#endregion (Set|Get) The CreationDate as String.

#region |2019/07/06 00h51:489| <01.00.52> <Property> <Columns> |.See()|String|  (Set|Get) The See as String.
 ///     <Summary>
 ///    (Set|Get) The See as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:812 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The See as String.") ]
    member this.See()
       with get() = _See
       and set(value) = _See <- value
#endregion (Set|Get) The See as String.

#region |2019/07/06 00h51:502| <01.00.53> <Property> <Columns> |.SeeAlso()|String|  (Set|Get) The SeeAlso as String.
 ///     <Summary>
 ///    (Set|Get) The SeeAlso as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:813 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The SeeAlso as String.") ]
    member this.SeeAlso()
       with get() = _SeeAlso
       and set(value) = _SeeAlso <- value
#endregion (Set|Get) The SeeAlso as String.

#region |2019/07/06 00h51:516| <01.00.54> <Property> <Columns> |.Rules()|String|  (Set|Get) The Rules as String.
 ///     <Summary>
 ///    (Set|Get) The Rules as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:815 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Rules as String.") ]
    member this.Rules()
       with get() = _Rules
       and set(value) = _Rules <- value
#endregion (Set|Get) The Rules as String.

#region |2019/07/06 00h51:528| <01.00.55> <Property> <Columns> |.Syntax()|String|  (Set|Get) The Syntax as String.
 ///     <Summary>
 ///    (Set|Get) The Syntax as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:816 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Syntax as String.") ]
    member this.Syntax()
       with get() = _Syntax
       and set(value) = _Syntax <- value
#endregion (Set|Get) The Syntax as String.

#region |2019/07/06 00h51:541| <01.00.56> <Property> <Columns> |.AccessModifier()|String|  (Set|Get) The AccessModifier as String.
 ///     <Summary>
 ///    (Set|Get) The AccessModifier as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:816 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AccessModifier as String.") ]
    member this.AccessModifier()
       with get() = _AccessModifier
       and set(value) = _AccessModifier <- value
#endregion (Set|Get) The AccessModifier as String.

#region |2019/07/06 00h51:555| <01.00.57> <Property> <Columns> |.Shadows()|Boolean|  (Set|Get) The Shadows as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Shadows as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:816 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Shadows as Boolean.") ]
    member this.Shadows()
       with get() = _Shadows
       and set(value) = _Shadows <- value
#endregion (Set|Get) The Shadows as Boolean.

#region |2019/07/06 00h51:568| <01.00.58> <Property> <Columns> |.DataType()|String|  (Set|Get) The DataType as String.
 ///     <Summary>
 ///    (Set|Get) The DataType as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:816 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The DataType as String.") ]
    member this.DataType()
       with get() = _DataType
       and set(value) = _DataType <- value
#endregion (Set|Get) The DataType as String.

#region |2019/07/06 00h51:581| <01.00.59> <Property> <Columns> |.EnumerationName()|String|  (Set|Get) The EnumerationName as String.
 ///     <Summary>
 ///    (Set|Get) The EnumerationName as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:817 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The EnumerationName as String.") ]
    member this.EnumerationName()
       with get() = _EnumerationName
       and set(value) = _EnumerationName <- value
#endregion (Set|Get) The EnumerationName as String.

#end region 
#region <2> [Enumeration]{1}
#region |2019/07/06 00h51:595| <02.00.00> <Property> <> |.Schema()|Enumeration{59}|"' (Set|Get) The enumeration of Schema.
     ///     <Summary>
 ///    (Set|Get) The enumeration of Schema.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:817 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The enumeration of Schema.") ]
    Type Schema = 
/// <summary>(Set|Get) The ID as Integer.</summary>
|   [ID] = 0
/// <summary>(Set|Get) The Name as String.</summary>
|   [Name] = 1
/// <summary>(Set|Get) The ImageIndex as Integer.</summary>
|   [ImageIndex] = 2
/// <summary>(Set|Get) The Text as String.</summary>
|   [Text] = 3
/// <summary>(Set|Get) The ToolTip as String.</summary>
|   [ToolTip] = 4
/// <summary>(Set|Get) The Enable as Boolean.</summary>
|   [Enable] = 5
/// <summary>(Set|Get) The Status as String.</summary>
|   [Status] = 6
/// <summary>(Set|Get) The Statement as String.</summary>
|   [Statement] = 7
/// <summary>(Set|Get) The XMLFile as String.</summary>
|   [XMLFile] = 8
/// <summary>(Set|Get) The Attributes as String.</summary>
|   [Attributes] = 9
/// <summary>(Set|Get) The Browsable as Boolean.</summary>
|   [Browsable] = 10
/// <summary>(Set|Get) The Category as String.</summary>
|   [Category] = 11
/// <summary>(Set|Get) The Description as String.</summary>
|   [Description] = 12
/// <summary>(Set|Get) The DefaultValue as String.</summary>
|   [DefaultValue] = 13
/// <summary>(Set|Get) The Editor as String.</summary>
|   [Editor] = 14
/// <summary>(Set|Get) The DllImport as String.</summary>
|   [DllImport] = 15
/// <summary>(Set|Get) The Deserializable as Boolean.</summary>
|   [Deserializable] = 16
/// <summary>(Set|Get) The NonSerialized as Boolean.</summary>
|   [NonSerialized] = 17
/// <summary>(Set|Get) The Serializable as Boolean.</summary>
|   [Serializable] = 18
/// <summary>(Set|Get) The XmlRoot as String.</summary>
|   [XmlRoot] = 19
/// <summary>(Set|Get) The XmlIgnore as Boolean.</summary>
|   [XmlIgnore] = 20
/// <summary>(Set|Get) The XmlInclude as Boolean.</summary>
|   [XmlInclude] = 21
/// <summary>(Set|Get) The RelatedImageList as String.</summary>
|   [RelatedImageList] = 22
/// <summary>(Set|Get) The Print_VB as String.</summary>
|   [Print_VB] = 23
/// <summary>(Set|Get) The VB as String.</summary>
|   [VB] = 24
/// <summary>(Set|Get) The Print_C as String.</summary>
|   [Print_C] = 25
/// <summary>(Set|Get) The C as String.</summary>
|   [C] = 26
/// <summary>(Set|Get) The Print_F as String.</summary>
|   [Print_F] = 27
/// <summary>(Set|Get) The F as String.</summary>
|   [F] = 28
/// <summary>(Set|Get) The Print_Python as String.</summary>
|   [Print_Python] = 29
/// <summary>(Set|Get) The Python as String.</summary>
|   [Python] = 30
/// <summary>(Set|Get) The Print_JavaScript as String.</summary>
|   [Print_JavaScript] = 31
/// <summary>(Set|Get) The JavaScript as String.</summary>
|   [JavaScript] = 32
/// <summary>(Set|Get) The RegionCategory as Integer.</summary>
|   [RegionCategory] = 33
/// <summary>(Set|Get) The RegionCode as String.</summary>
|   [RegionCode] = 34
/// <summary>(Set|Get) The AuthorEmail as String.</summary>
|   [AuthorEmail] = 35
/// <summary>(Set|Get) The AuthorName as String.</summary>
|   [AuthorName] = 36
/// <summary>(Set|Get) The AuthorUri as String.</summary>
|   [AuthorUri] = 37
/// <summary>(Set|Get) The ContributorEmail as String.</summary>
|   [ContributorEmail] = 38
/// <summary>(Set|Get) The ContributorName as String.</summary>
|   [ContributorName] = 39
/// <summary>(Set|Get) The ContributorUri as String.</summary>
|   [ContributorUri] = 40
/// <summary>(Set|Get) The CustomProperty as String.</summary>
|   [CustomProperty] = 41
/// <summary>(Set|Get) The Published as String.</summary>
|   [Published] = 42
/// <summary>(Set|Get) The Rights as String.</summary>
|   [Rights] = 43
/// <summary>(Set|Get) The Summary as String.</summary>
|   [Summary] = 44
/// <summary>(Set|Get) The Title as String.</summary>
|   [Title] = 45
/// <summary>(Set|Get) The Updated as String.</summary>
|   [Updated] = 46
/// <summary>(Set|Get) The Usage as String.</summary>
|   [Usage] = 47
/// <summary>(Set|Get) The Remarks as String.</summary>
|   [Remarks] = 48
/// <summary>(Set|Get) The Example as String.</summary>
|   [Example] = 49
/// <summary>(Set|Get) The Note as String.</summary>
|   [Note] = 50
/// <summary>(Set|Get) The CreationDate as String.</summary>
|   [CreationDate] = 51
/// <summary>(Set|Get) The See as String.</summary>
|   [See] = 52
/// <summary>(Set|Get) The SeeAlso as String.</summary>
|   [SeeAlso] = 53
/// <summary>(Set|Get) The Rules as String.</summary>
|   [Rules] = 54
/// <summary>(Set|Get) The Syntax as String.</summary>
|   [Syntax] = 55
/// <summary>(Set|Get) The AccessModifier as String.</summary>
|   [AccessModifier] = 56
/// <summary>(Set|Get) The Shadows as Boolean.</summary>
|   [Shadows] = 57
/// <summary>(Set|Get) The DataType as String.</summary>
|   [DataType] = 58
/// <summary>(Set|Get) The EnumerationName as String.</summary>
|   [EnumerationName] = 59
#endregion (Set|Get) The enumeration of Schema.

#end region 
#region <4> [Sub]{5}
#region |2019/07/06 00h51:736| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
     ///     <Summary>
 ///    (Set|Get) This will reinitialize the class element.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:818 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will reinitialize the class element.") ]
    Let Clear = 
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
#endregion (Set|Get) This will reinitialize the class element.

#region |2019/07/06 00h51:858| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
     ///     <Summary>
 ///    (Set|Get) This will reinitialize the variables of this class.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:818 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will reinitialize the variables of this class.") ]
    Let Reset = 
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

#endregion (Set|Get) This will reinitialize the variables of this class.

#region |2019/07/06 00h51:880| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
     ///     <Summary>
 ///    (Set|Get) This will add a new row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:818 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will add a new row in the table.") ]
    Let Add = 
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

#endregion (Set|Get) This will add a new row in the table.

#region |2019/07/06 00h51:899| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
     ///     <Summary>
 ///    (Set|Get) This will update a row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:819 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will update a row in the table.") ]
    Let Save = 
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

#endregion (Set|Get) This will update a row in the table.

#region |2019/07/06 00h51:915| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
     ///     <Summary>
 ///    (Set|Get) This will Delete a row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:819 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will Delete a row in the table.") ]
    Let Delete = 
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

#endregion (Set|Get) This will Delete a row in the table.

#end region 
#region <5> [Function]{7}
#region |2019/07/06 00h51:930| <05.00.00> <Sub> <> |.Open()|Sub}|"' (Set|Get) This will initialise the connection and import the data.
     ///     <Summary>
 ///    (Set|Get) This will initialise the connection and import the data.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:819 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will initialise the connection and import the data.") ]
    Let Open = 
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

#endregion (Set|Get) This will initialise the connection and import the data.

#region |2019/07/06 00h51:062| <05.00.01> <Sub> <> |.Close()|Sub}|"' (Set|Get) This willClosing the connection
     ///     <Summary>
 ///    (Set|Get) This willClosing the connection
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:819 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This willClosing the connection") ]
    Let Close = 
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

#endregion (Set|Get) This willClosing the connection

#region |2019/07/06 00h51:080| <05.00.02> <Sub> <> |.List()|Sub}|"' (Set|Get) Return the entire table listed
     ///     <Summary>
 ///    (Set|Get) Return the entire table listed
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:820 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Return the entire table listed") ]
    Let List = 
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
#endregion (Set|Get) Return the entire table listed

#region |2019/07/06 00h51:094| <05.00.03> <Sub> <> |.SearchByName()|Sub}|"' (Set|Get) Search for each property that match the Search String.
     ///     <Summary>
 ///    (Set|Get) Search for each property that match the Search String.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:820 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Search for each property that match the Search String.") ]
    Let SearchByName = 
    Dim Result As New List(Of Enumeration)
 Dim C As New Enumeration
 For Each Element As Enumeration In C.List
 If Element.Name.Tolower() = Search.Tolower() Or Element.Text.Tolower() = Search.Tolower()  Or Element.ToolTip.Tolower() = Search.Tolower()  Or Element.Status.Tolower() = Search.Tolower()  Or Element.Statement.Tolower() = Search.Tolower()  Or Element.XMLFile.Tolower() = Search.Tolower()  Or Element.Attributes.Tolower() = Search.Tolower()  Or Element.Category.Tolower() = Search.Tolower()  Or Element.Description.Tolower() = Search.Tolower()  Or Element.DefaultValue.Tolower() = Search.Tolower()  Or Element.Editor.Tolower() = Search.Tolower()  Or Element.DllImport.Tolower() = Search.Tolower()  Or Element.XmlRoot.Tolower() = Search.Tolower()  Or Element.RelatedImageList.Tolower() = Search.Tolower()  Or Element.Print_VB.Tolower() = Search.Tolower()  Or Element.VB.Tolower() = Search.Tolower()  Or Element.Print_C.Tolower() = Search.Tolower()  Or Element.C.Tolower() = Search.Tolower()  Or Element.Print_F.Tolower() = Search.Tolower()  Or Element.F.Tolower() = Search.Tolower()  Or Element.Print_Python.Tolower() = Search.Tolower()  Or Element.Python.Tolower() = Search.Tolower()  Or Element.Print_JavaScript.Tolower() = Search.Tolower()  Or Element.JavaScript.Tolower() = Search.Tolower()  Or Element.RegionCode.Tolower() = Search.Tolower()  Or Element.AuthorEmail.Tolower() = Search.Tolower()  Or Element.AuthorName.Tolower() = Search.Tolower()  Or Element.AuthorUri.Tolower() = Search.Tolower()  Or Element.ContributorEmail.Tolower() = Search.Tolower()  Or Element.ContributorName.Tolower() = Search.Tolower()  Or Element.ContributorUri.Tolower() = Search.Tolower()  Or Element.CustomProperty.Tolower() = Search.Tolower()  Or Element.Published.Tolower() = Search.Tolower()  Or Element.Rights.Tolower() = Search.Tolower()  Or Element.Summary.Tolower() = Search.Tolower()  Or Element.Title.Tolower() = Search.Tolower()  Or Element.Updated.Tolower() = Search.Tolower()  Or Element.Usage.Tolower() = Search.Tolower()  Or Element.Remarks.Tolower() = Search.Tolower()  Or Element.Example.Tolower() = Search.Tolower()  Or Element.Note.Tolower() = Search.Tolower()  Or Element.CreationDate.Tolower() = Search.Tolower()  Or Element.See.Tolower() = Search.Tolower()  Or Element.SeeAlso.Tolower() = Search.Tolower()  Or Element.Rules.Tolower() = Search.Tolower()  Or Element.Syntax.Tolower() = Search.Tolower()  Or Element.AccessModifier.Tolower() = Search.Tolower()  Or Element.DataType.Tolower() = Search.Tolower()  Or Element.EnumerationName.Tolower() = Search.Tolower() Then
      Result.Add(Element)
 End If
 Next
 Return Result
#endregion (Set|Get) Search for each property that match the Search String.

#region |2019/07/06 00h51:111| <05.00.04> <Sub> <> |.SearchByID()|Sub}|"' (Set|Get) Search for each property that match the Search Id.
     ///     <Summary>
 ///    (Set|Get) Search for each property that match the Search Id.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:820 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Search for each property that match the Search Id.") ]
    Let SearchByID = 
    Dim Result As New List(Of Enumeration)
 Dim C As New Enumeration
 For Each Element As Enumeration In C.List
 If Val(Element.ID) = Search Or Val(Element.ImageIndex) = Search  Or Val(Element.RegionCategory) = Search Then
      Result.Add(Element)
 End If
 Next
 Return Result
#endregion (Set|Get) Search for each property that match the Search Id.

#region |2019/07/06 00h51:127| <05.00.05> <Sub> <> |.ToString()|Sub}|"' (Set|Get) The function ToString.
     ///     <Summary>
 ///    (Set|Get) The function ToString.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:820 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The function ToString.") ]
    Let ToString = 
        Return Me.ID
#endregion (Set|Get) The function ToString.

#region |2019/07/06 00h51:144| <05.00.06> <Sub> <> |.CheckConnection()|Sub}|"' (Set|Get) Evaluate the connection to the DataBase
     ///     <Summary>
 ///    (Set|Get) Evaluate the connection to the DataBase
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:820 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Evaluate the connection to the DataBase") ]
    Let CheckConnection = 
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

#endregion (Set|Get) Evaluate the connection to the DataBase

#end region 
#region <6> [Runtime]{12}
#region |2019/07/06 00h51:160| <15.00.00> <Runtime> <> |.Table()|Runtime|  (Set|Get) The Table.
 ///     <Summary>
 ///    (Set|Get) The Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:821 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Table.") ]
   Public Table Table;
#endregion (Set|Get) The Table.

#region |2019/07/06 00h51:275| <15.00.01> <Runtime> <> |.Line()|Runtime|  (Set|Get) The Connection String To the Table.
 ///     <Summary>
 ///    (Set|Get) The Connection String To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:821 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Connection String To the Table.") ]
   Public String Line;
#endregion (Set|Get) The Connection String To the Table.

#region |2019/07/06 00h51:290| <15.00.02> <Runtime> <> |.FilePath()|Runtime|  (Set|Get) The FilePath To the Table.
 ///     <Summary>
 ///    (Set|Get) The FilePath To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:821 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The FilePath To the Table.") ]
   Public String FilePath;
#endregion (Set|Get) The FilePath To the Table.

#region |2019/07/06 00h51:304| <15.00.03> <Runtime> <> |.Password()|Runtime|  (Set|Get) The Password To the Table.
 ///     <Summary>
 ///    (Set|Get) The Password To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:822 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Password To the Table.") ]
   Public String Password;
#endregion (Set|Get) The Password To the Table.

#region |2019/07/06 00h51:318| <15.00.04> <Runtime> <> |.UseSQL()|Runtime|  (Set|Get) Determines if the Database Connection is of type SQL.
 ///     <Summary>
 ///    (Set|Get) Determines if the Database Connection is of type SQL.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:822 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Determines if the Database Connection is of type SQL.") ]
   Public Boolean UseSQL;
#endregion (Set|Get) Determines if the Database Connection is of type SQL.

#region |2019/07/06 00h51:333| <15.00.05> <Runtime> <> |.TableName()|Runtime|  (Set|Get) The name of the Table.
 ///     <Summary>
 ///    (Set|Get) The name of the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:822 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The name of the Table.") ]
   Public String TableName;
#endregion (Set|Get) The name of the Table.

#region |2019/07/06 00h51:349| <15.00.06> <Runtime> <> |.Con()|Runtime|  (Set|Get) The Con To the Table.
 ///     <Summary>
 ///    (Set|Get) The Con To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:822 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Con To the Table.") ]
   Public OleDb.OleDbConnection Con;
#endregion (Set|Get) The Con To the Table.

#region |2019/07/06 00h51:368| <15.00.07> <Runtime> <> |.Cmd()|Runtime|  (Set|Get) The Cmd To the Table.
 ///     <Summary>
 ///    (Set|Get) The Cmd To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:822 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Cmd To the Table.") ]
   Public OleDb.OleDbCommand Cmd;
#endregion (Set|Get) The Cmd To the Table.

#region |2019/07/06 00h51:383| <15.00.08> <Runtime> <> |.DataReader()|Runtime|  (Set|Get) The DataReader To the Table.
 ///     <Summary>
 ///    (Set|Get) The DataReader To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:825 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The DataReader To the Table.") ]
   Public OleDb.OleDbDataReader DataReader;
#endregion (Set|Get) The DataReader To the Table.

#region |2019/07/06 00h51:397| <15.00.09> <Runtime> <> |.DataAdapter()|Runtime|  (Set|Get) The DataAdapter To the Table.
 ///     <Summary>
 ///    (Set|Get) The DataAdapter To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:825 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The DataAdapter To the Table.") ]
   Public OleDb.OleDbDataAdapter DataAdapter;
#endregion (Set|Get) The DataAdapter To the Table.

#region |2019/07/06 00h51:412| <15.00.10> <Runtime> <> |.Connector()|Runtime|  (Set|Get) The Connector To the Table.
 ///     <Summary>
 ///    (Set|Get) The Connector To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:825 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Connector To the Table.") ]
   Public LineInfo Connector;
#endregion (Set|Get) The Connector To the Table.

#region |2019/07/06 00h51:428| <15.00.11> <Runtime> <> |.Log()|Runtime|  (Set|Get) The Log To the Table.
 ///     <Summary>
 ///    (Set|Get) The Log To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:825 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Log To the Table.") ]
   Public String Log;
#endregion (Set|Get) The Log To the Table.

#end region 
#region <7> [Loader]{2}
#region |2019/07/06 00h51:451| <06.00.00> <Sub> <> |.Empty()|Sub}|"' (Set|Get) The sub Empty.
     ///     <Summary>
 ///    (Set|Get) The sub Empty.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:826 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The sub Empty.") ]
    Let Empty = 
    Reset
#endregion (Set|Get) The sub Empty.

#region |2019/07/06 00h51:462| <06.00.01> <Sub> <> |.Filled()|Sub}|"' (Set|Get) The sub Filled.
     ///     <Summary>
 ///    (Set|Get) The sub Filled.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:826 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The sub Filled.") ]
    Let Filled = 
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

#endregion (Set|Get) The sub Filled.

#end region 
}

 ///     <Summary>
 ///    Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Function
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
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:861 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
public  class Function{
#region <1> [Property]{66}
#region |2019/07/06 00h51:677| <01.00.00> <Property> <Columns> |.ID()|Integer|  (Set|Get) The ID as Integer.
 ///     <Summary>
 ///    (Set|Get) The ID as Integer.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:861 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ID as Integer.") ]
    member this.ID()
       with get() = _ID
       and set(value) = _ID <- value
#endregion (Set|Get) The ID as Integer.

#region |2019/07/06 00h51:689| <01.00.01> <Property> <Columns> |.Name()|String|  (Set|Get) The Name as String.
 ///     <Summary>
 ///    (Set|Get) The Name as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:861 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Name as String.") ]
    member this.Name()
       with get() = _Name
       and set(value) = _Name <- value
#endregion (Set|Get) The Name as String.

#region |2019/07/06 00h51:700| <01.00.02> <Property> <Columns> |.ImageIndex()|Integer|  (Set|Get) The ImageIndex as Integer.
 ///     <Summary>
 ///    (Set|Get) The ImageIndex as Integer.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:864 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ImageIndex as Integer.") ]
    member this.ImageIndex()
       with get() = _ImageIndex
       and set(value) = _ImageIndex <- value
#endregion (Set|Get) The ImageIndex as Integer.

#region |2019/07/06 00h51:711| <01.00.03> <Property> <Columns> |.Text()|String|  (Set|Get) The Text as String.
 ///     <Summary>
 ///    (Set|Get) The Text as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:864 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Text as String.") ]
    member this.Text()
       with get() = _Text
       and set(value) = _Text <- value
#endregion (Set|Get) The Text as String.

#region |2019/07/06 00h51:721| <01.00.04> <Property> <Columns> |.ToolTip()|String|  (Set|Get) The ToolTip as String.
 ///     <Summary>
 ///    (Set|Get) The ToolTip as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:864 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ToolTip as String.") ]
    member this.ToolTip()
       with get() = _ToolTip
       and set(value) = _ToolTip <- value
#endregion (Set|Get) The ToolTip as String.

#region |2019/07/06 00h51:732| <01.00.05> <Property> <Columns> |.Enable()|Boolean|  (Set|Get) The Enable as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Enable as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:864 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Enable as Boolean.") ]
    member this.Enable()
       with get() = _Enable
       and set(value) = _Enable <- value
#endregion (Set|Get) The Enable as Boolean.

#region |2019/07/06 00h51:743| <01.00.06> <Property> <Columns> |.Status()|String|  (Set|Get) The Status as String.
 ///     <Summary>
 ///    (Set|Get) The Status as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:865 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Status as String.") ]
    member this.Status()
       with get() = _Status
       and set(value) = _Status <- value
#endregion (Set|Get) The Status as String.

#region |2019/07/06 00h51:754| <01.00.07> <Property> <Columns> |.Statement()|String|  (Set|Get) The Statement as String.
 ///     <Summary>
 ///    (Set|Get) The Statement as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:865 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Statement as String.") ]
    member this.Statement()
       with get() = _Statement
       and set(value) = _Statement <- value
#endregion (Set|Get) The Statement as String.

#region |2019/07/06 00h51:765| <01.00.08> <Property> <Columns> |.XMLFile()|String|  (Set|Get) The XMLFile as String.
 ///     <Summary>
 ///    (Set|Get) The XMLFile as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:865 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XMLFile as String.") ]
    member this.XMLFile()
       with get() = _XMLFile
       and set(value) = _XMLFile <- value
#endregion (Set|Get) The XMLFile as String.

#region |2019/07/06 00h51:776| <01.00.09> <Property> <Columns> |.Attributes()|String|  (Set|Get) The Attributes as String.
 ///     <Summary>
 ///    (Set|Get) The Attributes as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:865 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Attributes as String.") ]
    member this.Attributes()
       with get() = _Attributes
       and set(value) = _Attributes <- value
#endregion (Set|Get) The Attributes as String.

#region |2019/07/06 00h51:790| <01.00.10> <Property> <Columns> |.Browsable()|Boolean|  (Set|Get) The Browsable as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Browsable as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:868 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Browsable as Boolean.") ]
    member this.Browsable()
       with get() = _Browsable
       and set(value) = _Browsable <- value
#endregion (Set|Get) The Browsable as Boolean.

#region |2019/07/06 00h51:801| <01.00.11> <Property> <Columns> |.Category()|String|  (Set|Get) The Category as String.
 ///     <Summary>
 ///    (Set|Get) The Category as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:870 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Category as String.") ]
    member this.Category()
       with get() = _Category
       and set(value) = _Category <- value
#endregion (Set|Get) The Category as String.

#region |2019/07/06 00h51:811| <01.00.12> <Property> <Columns> |.Description()|String|  (Set|Get) The Description as String.
 ///     <Summary>
 ///    (Set|Get) The Description as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:870 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Description as String.") ]
    member this.Description()
       with get() = _Description
       and set(value) = _Description <- value
#endregion (Set|Get) The Description as String.

#region |2019/07/06 00h51:823| <01.00.13> <Property> <Columns> |.DefaultValue()|String|  (Set|Get) The DefaultValue as String.
 ///     <Summary>
 ///    (Set|Get) The DefaultValue as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:870 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The DefaultValue as String.") ]
    member this.DefaultValue()
       with get() = _DefaultValue
       and set(value) = _DefaultValue <- value
#endregion (Set|Get) The DefaultValue as String.

#region |2019/07/06 00h51:834| <01.00.14> <Property> <Columns> |.Editor()|String|  (Set|Get) The Editor as String.
 ///     <Summary>
 ///    (Set|Get) The Editor as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:871 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Editor as String.") ]
    member this.Editor()
       with get() = _Editor
       and set(value) = _Editor <- value
#endregion (Set|Get) The Editor as String.

#region |2019/07/06 00h51:845| <01.00.15> <Property> <Columns> |.DllImport()|String|  (Set|Get) The DllImport as String.
 ///     <Summary>
 ///    (Set|Get) The DllImport as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:871 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The DllImport as String.") ]
    member this.DllImport()
       with get() = _DllImport
       and set(value) = _DllImport <- value
#endregion (Set|Get) The DllImport as String.

#region |2019/07/06 00h51:857| <01.00.16> <Property> <Columns> |.Deserializable()|Boolean|  (Set|Get) The Deserializable as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Deserializable as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:871 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Deserializable as Boolean.") ]
    member this.Deserializable()
       with get() = _Deserializable
       and set(value) = _Deserializable <- value
#endregion (Set|Get) The Deserializable as Boolean.

#region |2019/07/06 00h51:868| <01.00.17> <Property> <Columns> |.NonSerialized()|Boolean|  (Set|Get) The NonSerialized as Boolean.
 ///     <Summary>
 ///    (Set|Get) The NonSerialized as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:874 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The NonSerialized as Boolean.") ]
    member this.NonSerialized()
       with get() = _NonSerialized
       and set(value) = _NonSerialized <- value
#endregion (Set|Get) The NonSerialized as Boolean.

#region |2019/07/06 00h51:879| <01.00.18> <Property> <Columns> |.Serializable()|Boolean|  (Set|Get) The Serializable as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Serializable as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:874 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Serializable as Boolean.") ]
    member this.Serializable()
       with get() = _Serializable
       and set(value) = _Serializable <- value
#endregion (Set|Get) The Serializable as Boolean.

#region |2019/07/06 00h51:893| <01.00.19> <Property> <Columns> |.XmlRoot()|String|  (Set|Get) The XmlRoot as String.
 ///     <Summary>
 ///    (Set|Get) The XmlRoot as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:874 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XmlRoot as String.") ]
    member this.XmlRoot()
       with get() = _XmlRoot
       and set(value) = _XmlRoot <- value
#endregion (Set|Get) The XmlRoot as String.

#region |2019/07/06 00h51:904| <01.00.20> <Property> <Columns> |.XmlIgnore()|Boolean|  (Set|Get) The XmlIgnore as Boolean.
 ///     <Summary>
 ///    (Set|Get) The XmlIgnore as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:874 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XmlIgnore as Boolean.") ]
    member this.XmlIgnore()
       with get() = _XmlIgnore
       and set(value) = _XmlIgnore <- value
#endregion (Set|Get) The XmlIgnore as Boolean.

#region |2019/07/06 00h51:915| <01.00.21> <Property> <Columns> |.XmlInclude()|Boolean|  (Set|Get) The XmlInclude as Boolean.
 ///     <Summary>
 ///    (Set|Get) The XmlInclude as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:875 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XmlInclude as Boolean.") ]
    member this.XmlInclude()
       with get() = _XmlInclude
       and set(value) = _XmlInclude <- value
#endregion (Set|Get) The XmlInclude as Boolean.

#region |2019/07/06 00h51:926| <01.00.22> <Property> <Columns> |.RelatedImageList()|String|  (Set|Get) The RelatedImageList as String.
 ///     <Summary>
 ///    (Set|Get) The RelatedImageList as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:875 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The RelatedImageList as String.") ]
    member this.RelatedImageList()
       with get() = _RelatedImageList
       and set(value) = _RelatedImageList <- value
#endregion (Set|Get) The RelatedImageList as String.

#region |2019/07/06 00h51:937| <01.00.23> <Property> <Columns> |.Print_VB()|String|  (Set|Get) The Print_VB as String.
 ///     <Summary>
 ///    (Set|Get) The Print_VB as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:876 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_VB as String.") ]
    member this.Print_VB()
       with get() = _Print_VB
       and set(value) = _Print_VB <- value
#endregion (Set|Get) The Print_VB as String.

#region |2019/07/06 00h51:948| <01.00.24> <Property> <Columns> |.VB()|String|  (Set|Get) The VB as String.
 ///     <Summary>
 ///    (Set|Get) The VB as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:877 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The VB as String.") ]
    member this.VB()
       with get() = _VB
       and set(value) = _VB <- value
#endregion (Set|Get) The VB as String.

#region |2019/07/06 00h51:960| <01.00.25> <Property> <Columns> |.Print_C()|String|  (Set|Get) The Print_C as String.
 ///     <Summary>
 ///    (Set|Get) The Print_C as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:877 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_C as String.") ]
    member this.Print_C()
       with get() = _Print_C
       and set(value) = _Print_C <- value
#endregion (Set|Get) The Print_C as String.

#region |2019/07/06 00h51:971| <01.00.26> <Property> <Columns> |.C()|String|  (Set|Get) The C as String.
 ///     <Summary>
 ///    (Set|Get) The C as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:880 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The C as String.") ]
    member this.C()
       with get() = _C
       and set(value) = _C <- value
#endregion (Set|Get) The C as String.

#region |2019/07/06 00h51:984| <01.00.27> <Property> <Columns> |.Print_F()|String|  (Set|Get) The Print_F as String.
 ///     <Summary>
 ///    (Set|Get) The Print_F as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:880 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_F as String.") ]
    member this.Print_F()
       with get() = _Print_F
       and set(value) = _Print_F <- value
#endregion (Set|Get) The Print_F as String.

#region |2019/07/06 00h51:996| <01.00.28> <Property> <Columns> |.F()|String|  (Set|Get) The F as String.
 ///     <Summary>
 ///    (Set|Get) The F as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:880 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The F as String.") ]
    member this.F()
       with get() = _F
       and set(value) = _F <- value
#endregion (Set|Get) The F as String.

#region |2019/07/06 00h51:007| <01.00.29> <Property> <Columns> |.Print_Python()|String|  (Set|Get) The Print_Python as String.
 ///     <Summary>
 ///    (Set|Get) The Print_Python as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:880 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_Python as String.") ]
    member this.Print_Python()
       with get() = _Print_Python
       and set(value) = _Print_Python <- value
#endregion (Set|Get) The Print_Python as String.

#region |2019/07/06 00h51:019| <01.00.30> <Property> <Columns> |.Python()|String|  (Set|Get) The Python as String.
 ///     <Summary>
 ///    (Set|Get) The Python as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:881 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Python as String.") ]
    member this.Python()
       with get() = _Python
       and set(value) = _Python <- value
#endregion (Set|Get) The Python as String.

#region |2019/07/06 00h51:040| <01.00.31> <Property> <Columns> |.Print_JavaScript()|String|  (Set|Get) The Print_JavaScript as String.
 ///     <Summary>
 ///    (Set|Get) The Print_JavaScript as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:881 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_JavaScript as String.") ]
    member this.Print_JavaScript()
       with get() = _Print_JavaScript
       and set(value) = _Print_JavaScript <- value
#endregion (Set|Get) The Print_JavaScript as String.

#region |2019/07/06 00h51:053| <01.00.32> <Property> <Columns> |.JavaScript()|String|  (Set|Get) The JavaScript as String.
 ///     <Summary>
 ///    (Set|Get) The JavaScript as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:881 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The JavaScript as String.") ]
    member this.JavaScript()
       with get() = _JavaScript
       and set(value) = _JavaScript <- value
#endregion (Set|Get) The JavaScript as String.

#region |2019/07/06 00h51:065| <01.00.33> <Property> <Columns> |.RegionCategory()|Integer|  (Set|Get) The RegionCategory as Integer.
 ///     <Summary>
 ///    (Set|Get) The RegionCategory as Integer.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:881 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The RegionCategory as Integer.") ]
    member this.RegionCategory()
       with get() = _RegionCategory
       and set(value) = _RegionCategory <- value
#endregion (Set|Get) The RegionCategory as Integer.

#region |2019/07/06 00h51:078| <01.00.34> <Property> <Columns> |.RegionCode()|String|  (Set|Get) The RegionCode as String.
 ///     <Summary>
 ///    (Set|Get) The RegionCode as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:884 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The RegionCode as String.") ]
    member this.RegionCode()
       with get() = _RegionCode
       and set(value) = _RegionCode <- value
#endregion (Set|Get) The RegionCode as String.

#region |2019/07/06 00h51:090| <01.00.35> <Property> <Columns> |.AuthorEmail()|String|  (Set|Get) The AuthorEmail as String.
 ///     <Summary>
 ///    (Set|Get) The AuthorEmail as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:884 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AuthorEmail as String.") ]
    member this.AuthorEmail()
       with get() = _AuthorEmail
       and set(value) = _AuthorEmail <- value
#endregion (Set|Get) The AuthorEmail as String.

#region |2019/07/06 00h51:101| <01.00.36> <Property> <Columns> |.AuthorName()|String|  (Set|Get) The AuthorName as String.
 ///     <Summary>
 ///    (Set|Get) The AuthorName as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:884 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AuthorName as String.") ]
    member this.AuthorName()
       with get() = _AuthorName
       and set(value) = _AuthorName <- value
#endregion (Set|Get) The AuthorName as String.

#region |2019/07/06 00h51:114| <01.00.37> <Property> <Columns> |.AuthorUri()|String|  (Set|Get) The AuthorUri as String.
 ///     <Summary>
 ///    (Set|Get) The AuthorUri as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:884 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AuthorUri as String.") ]
    member this.AuthorUri()
       with get() = _AuthorUri
       and set(value) = _AuthorUri <- value
#endregion (Set|Get) The AuthorUri as String.

#region |2019/07/06 00h51:126| <01.00.38> <Property> <Columns> |.ContributorEmail()|String|  (Set|Get) The ContributorEmail as String.
 ///     <Summary>
 ///    (Set|Get) The ContributorEmail as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:885 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ContributorEmail as String.") ]
    member this.ContributorEmail()
       with get() = _ContributorEmail
       and set(value) = _ContributorEmail <- value
#endregion (Set|Get) The ContributorEmail as String.

#region |2019/07/06 00h51:138| <01.00.39> <Property> <Columns> |.ContributorName()|String|  (Set|Get) The ContributorName as String.
 ///     <Summary>
 ///    (Set|Get) The ContributorName as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:885 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ContributorName as String.") ]
    member this.ContributorName()
       with get() = _ContributorName
       and set(value) = _ContributorName <- value
#endregion (Set|Get) The ContributorName as String.

#region |2019/07/06 00h51:150| <01.00.40> <Property> <Columns> |.ContributorUri()|String|  (Set|Get) The ContributorUri as String.
 ///     <Summary>
 ///    (Set|Get) The ContributorUri as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:885 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ContributorUri as String.") ]
    member this.ContributorUri()
       with get() = _ContributorUri
       and set(value) = _ContributorUri <- value
#endregion (Set|Get) The ContributorUri as String.

#region |2019/07/06 00h51:163| <01.00.41> <Property> <Columns> |.CustomProperty()|String|  (Set|Get) The CustomProperty as String.
 ///     <Summary>
 ///    (Set|Get) The CustomProperty as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:885 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The CustomProperty as String.") ]
    member this.CustomProperty()
       with get() = _CustomProperty
       and set(value) = _CustomProperty <- value
#endregion (Set|Get) The CustomProperty as String.

#region |2019/07/06 00h51:177| <01.00.42> <Property> <Columns> |.Published()|String|  (Set|Get) The Published as String.
 ///     <Summary>
 ///    (Set|Get) The Published as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:885 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Published as String.") ]
    member this.Published()
       with get() = _Published
       and set(value) = _Published <- value
#endregion (Set|Get) The Published as String.

#region |2019/07/06 00h51:188| <01.00.43> <Property> <Columns> |.Rights()|String|  (Set|Get) The Rights as String.
 ///     <Summary>
 ///    (Set|Get) The Rights as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:888 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Rights as String.") ]
    member this.Rights()
       with get() = _Rights
       and set(value) = _Rights <- value
#endregion (Set|Get) The Rights as String.

#region |2019/07/06 00h51:200| <01.00.44> <Property> <Columns> |.Summary()|String|  (Set|Get) The Summary as String.
 ///     <Summary>
 ///    (Set|Get) The Summary as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:888 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Summary as String.") ]
    member this.Summary()
       with get() = _Summary
       and set(value) = _Summary <- value
#endregion (Set|Get) The Summary as String.

#region |2019/07/06 00h51:214| <01.00.45> <Property> <Columns> |.Title()|String|  (Set|Get) The Title as String.
 ///     <Summary>
 ///    (Set|Get) The Title as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:888 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Title as String.") ]
    member this.Title()
       with get() = _Title
       and set(value) = _Title <- value
#endregion (Set|Get) The Title as String.

#region |2019/07/06 00h51:226| <01.00.46> <Property> <Columns> |.Updated()|String|  (Set|Get) The Updated as String.
 ///     <Summary>
 ///    (Set|Get) The Updated as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:889 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Updated as String.") ]
    member this.Updated()
       with get() = _Updated
       and set(value) = _Updated <- value
#endregion (Set|Get) The Updated as String.

#region |2019/07/06 00h51:238| <01.00.47> <Property> <Columns> |.Usage()|String|  (Set|Get) The Usage as String.
 ///     <Summary>
 ///    (Set|Get) The Usage as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:889 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Usage as String.") ]
    member this.Usage()
       with get() = _Usage
       and set(value) = _Usage <- value
#endregion (Set|Get) The Usage as String.

#region |2019/07/06 00h51:251| <01.00.48> <Property> <Columns> |.Remarks()|String|  (Set|Get) The Remarks as String.
 ///     <Summary>
 ///    (Set|Get) The Remarks as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:889 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Remarks as String.") ]
    member this.Remarks()
       with get() = _Remarks
       and set(value) = _Remarks <- value
#endregion (Set|Get) The Remarks as String.

#region |2019/07/06 00h51:265| <01.00.49> <Property> <Columns> |.Example()|String|  (Set|Get) The Example as String.
 ///     <Summary>
 ///    (Set|Get) The Example as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:889 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Example as String.") ]
    member this.Example()
       with get() = _Example
       and set(value) = _Example <- value
#endregion (Set|Get) The Example as String.

#region |2019/07/06 00h51:279| <01.00.50> <Property> <Columns> |.Note()|String|  (Set|Get) The Note as String.
 ///     <Summary>
 ///    (Set|Get) The Note as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:890 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Note as String.") ]
    member this.Note()
       with get() = _Note
       and set(value) = _Note <- value
#endregion (Set|Get) The Note as String.

#region |2019/07/06 00h51:301| <01.00.51> <Property> <Columns> |.CreationDate()|String|  (Set|Get) The CreationDate as String.
 ///     <Summary>
 ///    (Set|Get) The CreationDate as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:890 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The CreationDate as String.") ]
    member this.CreationDate()
       with get() = _CreationDate
       and set(value) = _CreationDate <- value
#endregion (Set|Get) The CreationDate as String.

#region |2019/07/06 00h51:315| <01.00.52> <Property> <Columns> |.See()|String|  (Set|Get) The See as String.
 ///     <Summary>
 ///    (Set|Get) The See as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:893 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The See as String.") ]
    member this.See()
       with get() = _See
       and set(value) = _See <- value
#endregion (Set|Get) The See as String.

#region |2019/07/06 00h51:327| <01.00.53> <Property> <Columns> |.SeeAlso()|String|  (Set|Get) The SeeAlso as String.
 ///     <Summary>
 ///    (Set|Get) The SeeAlso as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:893 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The SeeAlso as String.") ]
    member this.SeeAlso()
       with get() = _SeeAlso
       and set(value) = _SeeAlso <- value
#endregion (Set|Get) The SeeAlso as String.

#region |2019/07/06 00h51:340| <01.00.54> <Property> <Columns> |.Rules()|String|  (Set|Get) The Rules as String.
 ///     <Summary>
 ///    (Set|Get) The Rules as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:893 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Rules as String.") ]
    member this.Rules()
       with get() = _Rules
       and set(value) = _Rules <- value
#endregion (Set|Get) The Rules as String.

#region |2019/07/06 00h51:353| <01.00.55> <Property> <Columns> |.Syntax()|String|  (Set|Get) The Syntax as String.
 ///     <Summary>
 ///    (Set|Get) The Syntax as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:894 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Syntax as String.") ]
    member this.Syntax()
       with get() = _Syntax
       and set(value) = _Syntax <- value
#endregion (Set|Get) The Syntax as String.

#region |2019/07/06 00h51:365| <01.00.56> <Property> <Columns> |.AccessModifier()|String|  (Set|Get) The AccessModifier as String.
 ///     <Summary>
 ///    (Set|Get) The AccessModifier as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:894 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AccessModifier as String.") ]
    member this.AccessModifier()
       with get() = _AccessModifier
       and set(value) = _AccessModifier <- value
#endregion (Set|Get) The AccessModifier as String.

#region |2019/07/06 00h51:378| <01.00.57> <Property> <Columns> |.ProcedureModifier()|String|  (Set|Get) The ProcedureModifier as String.
 ///     <Summary>
 ///    (Set|Get) The ProcedureModifier as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:894 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ProcedureModifier as String.") ]
    member this.ProcedureModifier()
       with get() = _ProcedureModifier
       and set(value) = _ProcedureModifier <- value
#endregion (Set|Get) The ProcedureModifier as String.

#region |2019/07/06 00h51:391| <01.00.58> <Property> <Columns> |.Partial()|Boolean|  (Set|Get) The Partial as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Partial as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:894 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Partial as Boolean.") ]
    member this.Partial()
       with get() = _Partial
       and set(value) = _Partial <- value
#endregion (Set|Get) The Partial as Boolean.

#region |2019/07/06 00h51:406| <01.00.59> <Property> <Columns> |.Shared()|Boolean|  (Set|Get) The Shared as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Shared as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:895 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Shared as Boolean.") ]
    member this.Shared()
       with get() = _Shared
       and set(value) = _Shared <- value
#endregion (Set|Get) The Shared as Boolean.

#region |2019/07/06 00h51:419| <01.00.60> <Property> <Columns> |.Shadows()|Boolean|  (Set|Get) The Shadows as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Shadows as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:895 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Shadows as Boolean.") ]
    member this.Shadows()
       with get() = _Shadows
       and set(value) = _Shadows <- value
#endregion (Set|Get) The Shadows as Boolean.

#region |2019/07/06 00h51:432| <01.00.61> <Property> <Columns> |.Async()|Boolean|  (Set|Get) The Async as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Async as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:898 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Async as Boolean.") ]
    member this.Async()
       with get() = _Async
       and set(value) = _Async <- value
#endregion (Set|Get) The Async as Boolean.

#region |2019/07/06 00h51:446| <01.00.62> <Property> <Columns> |.FunctionName()|String|  (Set|Get) The FunctionName as String.
 ///     <Summary>
 ///    (Set|Get) The FunctionName as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:898 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The FunctionName as String.") ]
    member this.FunctionName()
       with get() = _FunctionName
       and set(value) = _FunctionName <- value
#endregion (Set|Get) The FunctionName as String.

#region |2019/07/06 00h51:460| <01.00.63> <Property> <Columns> |.Handles()|String|  (Set|Get) The Handles as String.
 ///     <Summary>
 ///    (Set|Get) The Handles as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:898 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Handles as String.") ]
    member this.Handles()
       with get() = _Handles
       and set(value) = _Handles <- value
#endregion (Set|Get) The Handles as String.

#region |2019/07/06 00h51:475| <01.00.64> <Property> <Columns> |.Implements()|String|  (Set|Get) The Implements as String.
 ///     <Summary>
 ///    (Set|Get) The Implements as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:900 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Implements as String.") ]
    member this.Implements()
       with get() = _Implements
       and set(value) = _Implements <- value
#endregion (Set|Get) The Implements as String.

#region |2019/07/06 00h51:489| <01.00.65> <Property> <Columns> |.ReturnType()|String|  (Set|Get) The ReturnType as String.
 ///     <Summary>
 ///    (Set|Get) The ReturnType as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:901 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ReturnType as String.") ]
    member this.ReturnType()
       with get() = _ReturnType
       and set(value) = _ReturnType <- value
#endregion (Set|Get) The ReturnType as String.

#end region 
#region <2> [Enumeration]{1}
#region |2019/07/06 00h51:502| <02.00.00> <Property> <> |.Schema()|Enumeration{65}|"' (Set|Get) The enumeration of Schema.
     ///     <Summary>
 ///    (Set|Get) The enumeration of Schema.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:901 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The enumeration of Schema.") ]
    Type Schema = 
/// <summary>(Set|Get) The ID as Integer.</summary>
|   [ID] = 0
/// <summary>(Set|Get) The Name as String.</summary>
|   [Name] = 1
/// <summary>(Set|Get) The ImageIndex as Integer.</summary>
|   [ImageIndex] = 2
/// <summary>(Set|Get) The Text as String.</summary>
|   [Text] = 3
/// <summary>(Set|Get) The ToolTip as String.</summary>
|   [ToolTip] = 4
/// <summary>(Set|Get) The Enable as Boolean.</summary>
|   [Enable] = 5
/// <summary>(Set|Get) The Status as String.</summary>
|   [Status] = 6
/// <summary>(Set|Get) The Statement as String.</summary>
|   [Statement] = 7
/// <summary>(Set|Get) The XMLFile as String.</summary>
|   [XMLFile] = 8
/// <summary>(Set|Get) The Attributes as String.</summary>
|   [Attributes] = 9
/// <summary>(Set|Get) The Browsable as Boolean.</summary>
|   [Browsable] = 10
/// <summary>(Set|Get) The Category as String.</summary>
|   [Category] = 11
/// <summary>(Set|Get) The Description as String.</summary>
|   [Description] = 12
/// <summary>(Set|Get) The DefaultValue as String.</summary>
|   [DefaultValue] = 13
/// <summary>(Set|Get) The Editor as String.</summary>
|   [Editor] = 14
/// <summary>(Set|Get) The DllImport as String.</summary>
|   [DllImport] = 15
/// <summary>(Set|Get) The Deserializable as Boolean.</summary>
|   [Deserializable] = 16
/// <summary>(Set|Get) The NonSerialized as Boolean.</summary>
|   [NonSerialized] = 17
/// <summary>(Set|Get) The Serializable as Boolean.</summary>
|   [Serializable] = 18
/// <summary>(Set|Get) The XmlRoot as String.</summary>
|   [XmlRoot] = 19
/// <summary>(Set|Get) The XmlIgnore as Boolean.</summary>
|   [XmlIgnore] = 20
/// <summary>(Set|Get) The XmlInclude as Boolean.</summary>
|   [XmlInclude] = 21
/// <summary>(Set|Get) The RelatedImageList as String.</summary>
|   [RelatedImageList] = 22
/// <summary>(Set|Get) The Print_VB as String.</summary>
|   [Print_VB] = 23
/// <summary>(Set|Get) The VB as String.</summary>
|   [VB] = 24
/// <summary>(Set|Get) The Print_C as String.</summary>
|   [Print_C] = 25
/// <summary>(Set|Get) The C as String.</summary>
|   [C] = 26
/// <summary>(Set|Get) The Print_F as String.</summary>
|   [Print_F] = 27
/// <summary>(Set|Get) The F as String.</summary>
|   [F] = 28
/// <summary>(Set|Get) The Print_Python as String.</summary>
|   [Print_Python] = 29
/// <summary>(Set|Get) The Python as String.</summary>
|   [Python] = 30
/// <summary>(Set|Get) The Print_JavaScript as String.</summary>
|   [Print_JavaScript] = 31
/// <summary>(Set|Get) The JavaScript as String.</summary>
|   [JavaScript] = 32
/// <summary>(Set|Get) The RegionCategory as Integer.</summary>
|   [RegionCategory] = 33
/// <summary>(Set|Get) The RegionCode as String.</summary>
|   [RegionCode] = 34
/// <summary>(Set|Get) The AuthorEmail as String.</summary>
|   [AuthorEmail] = 35
/// <summary>(Set|Get) The AuthorName as String.</summary>
|   [AuthorName] = 36
/// <summary>(Set|Get) The AuthorUri as String.</summary>
|   [AuthorUri] = 37
/// <summary>(Set|Get) The ContributorEmail as String.</summary>
|   [ContributorEmail] = 38
/// <summary>(Set|Get) The ContributorName as String.</summary>
|   [ContributorName] = 39
/// <summary>(Set|Get) The ContributorUri as String.</summary>
|   [ContributorUri] = 40
/// <summary>(Set|Get) The CustomProperty as String.</summary>
|   [CustomProperty] = 41
/// <summary>(Set|Get) The Published as String.</summary>
|   [Published] = 42
/// <summary>(Set|Get) The Rights as String.</summary>
|   [Rights] = 43
/// <summary>(Set|Get) The Summary as String.</summary>
|   [Summary] = 44
/// <summary>(Set|Get) The Title as String.</summary>
|   [Title] = 45
/// <summary>(Set|Get) The Updated as String.</summary>
|   [Updated] = 46
/// <summary>(Set|Get) The Usage as String.</summary>
|   [Usage] = 47
/// <summary>(Set|Get) The Remarks as String.</summary>
|   [Remarks] = 48
/// <summary>(Set|Get) The Example as String.</summary>
|   [Example] = 49
/// <summary>(Set|Get) The Note as String.</summary>
|   [Note] = 50
/// <summary>(Set|Get) The CreationDate as String.</summary>
|   [CreationDate] = 51
/// <summary>(Set|Get) The See as String.</summary>
|   [See] = 52
/// <summary>(Set|Get) The SeeAlso as String.</summary>
|   [SeeAlso] = 53
/// <summary>(Set|Get) The Rules as String.</summary>
|   [Rules] = 54
/// <summary>(Set|Get) The Syntax as String.</summary>
|   [Syntax] = 55
/// <summary>(Set|Get) The AccessModifier as String.</summary>
|   [AccessModifier] = 56
/// <summary>(Set|Get) The ProcedureModifier as String.</summary>
|   [ProcedureModifier] = 57
/// <summary>(Set|Get) The Partial as Boolean.</summary>
|   [Partial] = 58
/// <summary>(Set|Get) The Shared as Boolean.</summary>
|   [Shared] = 59
/// <summary>(Set|Get) The Shadows as Boolean.</summary>
|   [Shadows] = 60
/// <summary>(Set|Get) The Async as Boolean.</summary>
|   [Async] = 61
/// <summary>(Set|Get) The FunctionName as String.</summary>
|   [FunctionName] = 62
/// <summary>(Set|Get) The Handles as String.</summary>
|   [Handles] = 63
/// <summary>(Set|Get) The Implements as String.</summary>
|   [Implements] = 64
/// <summary>(Set|Get) The ReturnType as String.</summary>
|   [ReturnType] = 65
#endregion (Set|Get) The enumeration of Schema.

#end region 
#region <4> [Sub]{5}
#region |2019/07/06 00h51:531| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
     ///     <Summary>
 ///    (Set|Get) This will reinitialize the class element.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:902 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will reinitialize the class element.") ]
    Let Clear = 
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
#endregion (Set|Get) This will reinitialize the class element.

#region |2019/07/06 00h51:548| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
     ///     <Summary>
 ///    (Set|Get) This will reinitialize the variables of this class.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:902 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will reinitialize the variables of this class.") ]
    Let Reset = 
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

#endregion (Set|Get) This will reinitialize the variables of this class.

#region |2019/07/06 00h51:562| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
     ///     <Summary>
 ///    (Set|Get) This will add a new row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:902 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will add a new row in the table.") ]
    Let Add = 
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

#endregion (Set|Get) This will add a new row in the table.

#region |2019/07/06 00h51:584| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
     ///     <Summary>
 ///    (Set|Get) This will update a row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:903 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will update a row in the table.") ]
    Let Save = 
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

#endregion (Set|Get) This will update a row in the table.

#region |2019/07/06 00h51:599| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
     ///     <Summary>
 ///    (Set|Get) This will Delete a row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:903 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will Delete a row in the table.") ]
    Let Delete = 
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

#endregion (Set|Get) This will Delete a row in the table.

#end region 
#region <5> [Function]{7}
#region |2019/07/06 00h51:614| <05.00.00> <Sub> <> |.Open()|Sub}|"' (Set|Get) This will initialise the connection and import the data.
     ///     <Summary>
 ///    (Set|Get) This will initialise the connection and import the data.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:903 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will initialise the connection and import the data.") ]
    Let Open = 
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

#endregion (Set|Get) This will initialise the connection and import the data.

#region |2019/07/06 00h51:629| <05.00.01> <Sub> <> |.Close()|Sub}|"' (Set|Get) This willClosing the connection
     ///     <Summary>
 ///    (Set|Get) This willClosing the connection
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:903 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This willClosing the connection") ]
    Let Close = 
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

#endregion (Set|Get) This willClosing the connection

#region |2019/07/06 00h51:644| <05.00.02> <Sub> <> |.List()|Sub}|"' (Set|Get) Return the entire table listed
     ///     <Summary>
 ///    (Set|Get) Return the entire table listed
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:904 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Return the entire table listed") ]
    Let List = 
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
#endregion (Set|Get) Return the entire table listed

#region |2019/07/06 00h51:660| <05.00.03> <Sub> <> |.SearchByName()|Sub}|"' (Set|Get) Search for each property that match the Search String.
     ///     <Summary>
 ///    (Set|Get) Search for each property that match the Search String.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:904 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Search for each property that match the Search String.") ]
    Let SearchByName = 
    Dim Result As New List(Of Function)
 Dim C As New Function
 For Each Element As Function In C.List
 If Element.Name.Tolower() = Search.Tolower() Or Element.Text.Tolower() = Search.Tolower()  Or Element.ToolTip.Tolower() = Search.Tolower()  Or Element.Status.Tolower() = Search.Tolower()  Or Element.Statement.Tolower() = Search.Tolower()  Or Element.XMLFile.Tolower() = Search.Tolower()  Or Element.Attributes.Tolower() = Search.Tolower()  Or Element.Category.Tolower() = Search.Tolower()  Or Element.Description.Tolower() = Search.Tolower()  Or Element.DefaultValue.Tolower() = Search.Tolower()  Or Element.Editor.Tolower() = Search.Tolower()  Or Element.DllImport.Tolower() = Search.Tolower()  Or Element.XmlRoot.Tolower() = Search.Tolower()  Or Element.RelatedImageList.Tolower() = Search.Tolower()  Or Element.Print_VB.Tolower() = Search.Tolower()  Or Element.VB.Tolower() = Search.Tolower()  Or Element.Print_C.Tolower() = Search.Tolower()  Or Element.C.Tolower() = Search.Tolower()  Or Element.Print_F.Tolower() = Search.Tolower()  Or Element.F.Tolower() = Search.Tolower()  Or Element.Print_Python.Tolower() = Search.Tolower()  Or Element.Python.Tolower() = Search.Tolower()  Or Element.Print_JavaScript.Tolower() = Search.Tolower()  Or Element.JavaScript.Tolower() = Search.Tolower()  Or Element.RegionCode.Tolower() = Search.Tolower()  Or Element.AuthorEmail.Tolower() = Search.Tolower()  Or Element.AuthorName.Tolower() = Search.Tolower()  Or Element.AuthorUri.Tolower() = Search.Tolower()  Or Element.ContributorEmail.Tolower() = Search.Tolower()  Or Element.ContributorName.Tolower() = Search.Tolower()  Or Element.ContributorUri.Tolower() = Search.Tolower()  Or Element.CustomProperty.Tolower() = Search.Tolower()  Or Element.Published.Tolower() = Search.Tolower()  Or Element.Rights.Tolower() = Search.Tolower()  Or Element.Summary.Tolower() = Search.Tolower()  Or Element.Title.Tolower() = Search.Tolower()  Or Element.Updated.Tolower() = Search.Tolower()  Or Element.Usage.Tolower() = Search.Tolower()  Or Element.Remarks.Tolower() = Search.Tolower()  Or Element.Example.Tolower() = Search.Tolower()  Or Element.Note.Tolower() = Search.Tolower()  Or Element.CreationDate.Tolower() = Search.Tolower()  Or Element.See.Tolower() = Search.Tolower()  Or Element.SeeAlso.Tolower() = Search.Tolower()  Or Element.Rules.Tolower() = Search.Tolower()  Or Element.Syntax.Tolower() = Search.Tolower()  Or Element.AccessModifier.Tolower() = Search.Tolower()  Or Element.ProcedureModifier.Tolower() = Search.Tolower()  Or Element.FunctionName.Tolower() = Search.Tolower()  Or Element.Handles.Tolower() = Search.Tolower()  Or Element.Implements.Tolower() = Search.Tolower()  Or Element.ReturnType.Tolower() = Search.Tolower() Then
      Result.Add(Element)
 End If
 Next
 Return Result
#endregion (Set|Get) Search for each property that match the Search String.

#region |2019/07/06 00h51:677| <05.00.04> <Sub> <> |.SearchByID()|Sub}|"' (Set|Get) Search for each property that match the Search Id.
     ///     <Summary>
 ///    (Set|Get) Search for each property that match the Search Id.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:904 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Search for each property that match the Search Id.") ]
    Let SearchByID = 
    Dim Result As New List(Of Function)
 Dim C As New Function
 For Each Element As Function In C.List
 If Val(Element.ID) = Search Or Val(Element.ImageIndex) = Search  Or Val(Element.RegionCategory) = Search Then
      Result.Add(Element)
 End If
 Next
 Return Result
#endregion (Set|Get) Search for each property that match the Search Id.

#region |2019/07/06 00h51:692| <05.00.05> <Sub> <> |.ToString()|Sub}|"' (Set|Get) The function ToString.
     ///     <Summary>
 ///    (Set|Get) The function ToString.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:904 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The function ToString.") ]
    Let ToString = 
        Return Me.ID
#endregion (Set|Get) The function ToString.

#region |2019/07/06 00h51:708| <05.00.06> <Sub> <> |.CheckConnection()|Sub}|"' (Set|Get) Evaluate the connection to the DataBase
     ///     <Summary>
 ///    (Set|Get) Evaluate the connection to the DataBase
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:904 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Evaluate the connection to the DataBase") ]
    Let CheckConnection = 
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

#endregion (Set|Get) Evaluate the connection to the DataBase

#end region 
#region <6> [Runtime]{12}
#region |2019/07/06 00h51:728| <15.00.00> <Runtime> <> |.Table()|Runtime|  (Set|Get) The Table.
 ///     <Summary>
 ///    (Set|Get) The Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:905 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Table.") ]
   Public Table Table;
#endregion (Set|Get) The Table.

#region |2019/07/06 00h51:743| <15.00.01> <Runtime> <> |.Line()|Runtime|  (Set|Get) The Connection String To the Table.
 ///     <Summary>
 ///    (Set|Get) The Connection String To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:905 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Connection String To the Table.") ]
   Public String Line;
#endregion (Set|Get) The Connection String To the Table.

#region |2019/07/06 00h51:757| <15.00.02> <Runtime> <> |.FilePath()|Runtime|  (Set|Get) The FilePath To the Table.
 ///     <Summary>
 ///    (Set|Get) The FilePath To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:905 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The FilePath To the Table.") ]
   Public String FilePath;
#endregion (Set|Get) The FilePath To the Table.

#region |2019/07/06 00h51:772| <15.00.03> <Runtime> <> |.Password()|Runtime|  (Set|Get) The Password To the Table.
 ///     <Summary>
 ///    (Set|Get) The Password To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:906 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Password To the Table.") ]
   Public String Password;
#endregion (Set|Get) The Password To the Table.

#region |2019/07/06 00h51:787| <15.00.04> <Runtime> <> |.UseSQL()|Runtime|  (Set|Get) Determines if the Database Connection is of type SQL.
 ///     <Summary>
 ///    (Set|Get) Determines if the Database Connection is of type SQL.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:906 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Determines if the Database Connection is of type SQL.") ]
   Public Boolean UseSQL;
#endregion (Set|Get) Determines if the Database Connection is of type SQL.

#region |2019/07/06 00h51:802| <15.00.05> <Runtime> <> |.TableName()|Runtime|  (Set|Get) The name of the Table.
 ///     <Summary>
 ///    (Set|Get) The name of the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:908 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The name of the Table.") ]
   Public String TableName;
#endregion (Set|Get) The name of the Table.

#region |2019/07/06 00h51:817| <15.00.06> <Runtime> <> |.Con()|Runtime|  (Set|Get) The Con To the Table.
 ///     <Summary>
 ///    (Set|Get) The Con To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:908 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Con To the Table.") ]
   Public OleDb.OleDbConnection Con;
#endregion (Set|Get) The Con To the Table.

#region |2019/07/06 00h51:823| <15.00.07> <Runtime> <> |.Cmd()|Runtime|  (Set|Get) The Cmd To the Table.
 ///     <Summary>
 ///    (Set|Get) The Cmd To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:908 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Cmd To the Table.") ]
   Public OleDb.OleDbCommand Cmd;
#endregion (Set|Get) The Cmd To the Table.

#region |2019/07/06 00h51:838| <15.00.08> <Runtime> <> |.DataReader()|Runtime|  (Set|Get) The DataReader To the Table.
 ///     <Summary>
 ///    (Set|Get) The DataReader To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:909 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The DataReader To the Table.") ]
   Public OleDb.OleDbDataReader DataReader;
#endregion (Set|Get) The DataReader To the Table.

#region |2019/07/06 00h51:852| <15.00.09> <Runtime> <> |.DataAdapter()|Runtime|  (Set|Get) The DataAdapter To the Table.
 ///     <Summary>
 ///    (Set|Get) The DataAdapter To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:909 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The DataAdapter To the Table.") ]
   Public OleDb.OleDbDataAdapter DataAdapter;
#endregion (Set|Get) The DataAdapter To the Table.

#region |2019/07/06 00h51:877| <15.00.10> <Runtime> <> |.Connector()|Runtime|  (Set|Get) The Connector To the Table.
 ///     <Summary>
 ///    (Set|Get) The Connector To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:909 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Connector To the Table.") ]
   Public LineInfo Connector;
#endregion (Set|Get) The Connector To the Table.

#region |2019/07/06 00h51:892| <15.00.11> <Runtime> <> |.Log()|Runtime|  (Set|Get) The Log To the Table.
 ///     <Summary>
 ///    (Set|Get) The Log To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:909 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Log To the Table.") ]
   Public String Log;
#endregion (Set|Get) The Log To the Table.

#end region 
#region <7> [Loader]{2}
#region |2019/07/06 00h51:907| <06.00.00> <Sub> <> |.Empty()|Sub}|"' (Set|Get) The sub Empty.
     ///     <Summary>
 ///    (Set|Get) The sub Empty.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:910 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The sub Empty.") ]
    Let Empty = 
    Reset
#endregion (Set|Get) The sub Empty.

#region |2019/07/06 00h51:911| <06.00.01> <Sub> <> |.Filled()|Sub}|"' (Set|Get) The sub Filled.
     ///     <Summary>
 ///    (Set|Get) The sub Filled.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:910 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The sub Filled.") ]
    Let Filled = 
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

#endregion (Set|Get) The sub Filled.

#end region 
}

 ///     <Summary>
 ///    Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Property
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
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:956 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
public  class Property{
#region <1> [Property]{71}
#region |2019/07/06 00h51:068| <01.00.00> <Property> <Columns> |.ID()|Integer|  (Set|Get) The ID as Integer.
 ///     <Summary>
 ///    (Set|Get) The ID as Integer.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:956 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ID as Integer.") ]
    member this.ID()
       with get() = _ID
       and set(value) = _ID <- value
#endregion (Set|Get) The ID as Integer.

#region |2019/07/06 00h51:077| <01.00.01> <Property> <Columns> |.Name()|String|  (Set|Get) The Name as String.
 ///     <Summary>
 ///    (Set|Get) The Name as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:956 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Name as String.") ]
    member this.Name()
       with get() = _Name
       and set(value) = _Name <- value
#endregion (Set|Get) The Name as String.

#region |2019/07/06 00h51:092| <01.00.02> <Property> <Columns> |.ImageIndex()|Integer|  (Set|Get) The ImageIndex as Integer.
 ///     <Summary>
 ///    (Set|Get) The ImageIndex as Integer.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:956 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ImageIndex as Integer.") ]
    member this.ImageIndex()
       with get() = _ImageIndex
       and set(value) = _ImageIndex <- value
#endregion (Set|Get) The ImageIndex as Integer.

#region |2019/07/06 00h51:105| <01.00.03> <Property> <Columns> |.Text()|String|  (Set|Get) The Text as String.
 ///     <Summary>
 ///    (Set|Get) The Text as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:957 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Text as String.") ]
    member this.Text()
       with get() = _Text
       and set(value) = _Text <- value
#endregion (Set|Get) The Text as String.

#region |2019/07/06 00h51:120| <01.00.04> <Property> <Columns> |.ToolTip()|String|  (Set|Get) The ToolTip as String.
 ///     <Summary>
 ///    (Set|Get) The ToolTip as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:960 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ToolTip as String.") ]
    member this.ToolTip()
       with get() = _ToolTip
       and set(value) = _ToolTip <- value
#endregion (Set|Get) The ToolTip as String.

#region |2019/07/06 00h51:131| <01.00.05> <Property> <Columns> |.Enable()|Boolean|  (Set|Get) The Enable as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Enable as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:960 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Enable as Boolean.") ]
    member this.Enable()
       with get() = _Enable
       and set(value) = _Enable <- value
#endregion (Set|Get) The Enable as Boolean.

#region |2019/07/06 00h51:143| <01.00.06> <Property> <Columns> |.Status()|String|  (Set|Get) The Status as String.
 ///     <Summary>
 ///    (Set|Get) The Status as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:960 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Status as String.") ]
    member this.Status()
       with get() = _Status
       and set(value) = _Status <- value
#endregion (Set|Get) The Status as String.

#region |2019/07/06 00h51:150| <01.00.07> <Property> <Columns> |.Statement()|String|  (Set|Get) The Statement as String.
 ///     <Summary>
 ///    (Set|Get) The Statement as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:960 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Statement as String.") ]
    member this.Statement()
       with get() = _Statement
       and set(value) = _Statement <- value
#endregion (Set|Get) The Statement as String.

#region |2019/07/06 00h51:161| <01.00.08> <Property> <Columns> |.XMLFile()|String|  (Set|Get) The XMLFile as String.
 ///     <Summary>
 ///    (Set|Get) The XMLFile as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:960 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XMLFile as String.") ]
    member this.XMLFile()
       with get() = _XMLFile
       and set(value) = _XMLFile <- value
#endregion (Set|Get) The XMLFile as String.

#region |2019/07/06 00h51:173| <01.00.09> <Property> <Columns> |.Attributes()|String|  (Set|Get) The Attributes as String.
 ///     <Summary>
 ///    (Set|Get) The Attributes as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:961 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Attributes as String.") ]
    member this.Attributes()
       with get() = _Attributes
       and set(value) = _Attributes <- value
#endregion (Set|Get) The Attributes as String.

#region |2019/07/06 00h51:184| <01.00.10> <Property> <Columns> |.Browsable()|Boolean|  (Set|Get) The Browsable as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Browsable as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:961 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Browsable as Boolean.") ]
    member this.Browsable()
       with get() = _Browsable
       and set(value) = _Browsable <- value
#endregion (Set|Get) The Browsable as Boolean.

#region |2019/07/06 00h51:195| <01.00.11> <Property> <Columns> |.Category()|String|  (Set|Get) The Category as String.
 ///     <Summary>
 ///    (Set|Get) The Category as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:961 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Category as String.") ]
    member this.Category()
       with get() = _Category
       and set(value) = _Category <- value
#endregion (Set|Get) The Category as String.

#region |2019/07/06 00h51:207| <01.00.12> <Property> <Columns> |.Description()|String|  (Set|Get) The Description as String.
 ///     <Summary>
 ///    (Set|Get) The Description as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:961 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Description as String.") ]
    member this.Description()
       with get() = _Description
       and set(value) = _Description <- value
#endregion (Set|Get) The Description as String.

#region |2019/07/06 00h51:218| <01.00.13> <Property> <Columns> |.DefaultValue()|String|  (Set|Get) The DefaultValue as String.
 ///     <Summary>
 ///    (Set|Get) The DefaultValue as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:964 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The DefaultValue as String.") ]
    member this.DefaultValue()
       with get() = _DefaultValue
       and set(value) = _DefaultValue <- value
#endregion (Set|Get) The DefaultValue as String.

#region |2019/07/06 00h51:231| <01.00.14> <Property> <Columns> |.Editor()|String|  (Set|Get) The Editor as String.
 ///     <Summary>
 ///    (Set|Get) The Editor as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:964 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Editor as String.") ]
    member this.Editor()
       with get() = _Editor
       and set(value) = _Editor <- value
#endregion (Set|Get) The Editor as String.

#region |2019/07/06 00h51:247| <01.00.15> <Property> <Columns> |.DllImport()|String|  (Set|Get) The DllImport as String.
 ///     <Summary>
 ///    (Set|Get) The DllImport as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:964 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The DllImport as String.") ]
    member this.DllImport()
       with get() = _DllImport
       and set(value) = _DllImport <- value
#endregion (Set|Get) The DllImport as String.

#region |2019/07/06 00h51:260| <01.00.16> <Property> <Columns> |.Deserializable()|Boolean|  (Set|Get) The Deserializable as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Deserializable as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:964 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Deserializable as Boolean.") ]
    member this.Deserializable()
       with get() = _Deserializable
       and set(value) = _Deserializable <- value
#endregion (Set|Get) The Deserializable as Boolean.

#region |2019/07/06 00h51:272| <01.00.17> <Property> <Columns> |.NonSerialized()|Boolean|  (Set|Get) The NonSerialized as Boolean.
 ///     <Summary>
 ///    (Set|Get) The NonSerialized as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:965 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The NonSerialized as Boolean.") ]
    member this.NonSerialized()
       with get() = _NonSerialized
       and set(value) = _NonSerialized <- value
#endregion (Set|Get) The NonSerialized as Boolean.

#region |2019/07/06 00h51:284| <01.00.18> <Property> <Columns> |.Serializable()|Boolean|  (Set|Get) The Serializable as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Serializable as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:965 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Serializable as Boolean.") ]
    member this.Serializable()
       with get() = _Serializable
       and set(value) = _Serializable <- value
#endregion (Set|Get) The Serializable as Boolean.

#region |2019/07/06 00h51:296| <01.00.19> <Property> <Columns> |.XmlRoot()|String|  (Set|Get) The XmlRoot as String.
 ///     <Summary>
 ///    (Set|Get) The XmlRoot as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:965 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XmlRoot as String.") ]
    member this.XmlRoot()
       with get() = _XmlRoot
       and set(value) = _XmlRoot <- value
#endregion (Set|Get) The XmlRoot as String.

#region |2019/07/06 00h51:308| <01.00.20> <Property> <Columns> |.XmlIgnore()|Boolean|  (Set|Get) The XmlIgnore as Boolean.
 ///     <Summary>
 ///    (Set|Get) The XmlIgnore as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:965 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XmlIgnore as Boolean.") ]
    member this.XmlIgnore()
       with get() = _XmlIgnore
       and set(value) = _XmlIgnore <- value
#endregion (Set|Get) The XmlIgnore as Boolean.

#region |2019/07/06 00h51:320| <01.00.21> <Property> <Columns> |.XmlInclude()|Boolean|  (Set|Get) The XmlInclude as Boolean.
 ///     <Summary>
 ///    (Set|Get) The XmlInclude as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:965 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XmlInclude as Boolean.") ]
    member this.XmlInclude()
       with get() = _XmlInclude
       and set(value) = _XmlInclude <- value
#endregion (Set|Get) The XmlInclude as Boolean.

#region |2019/07/06 00h51:331| <01.00.22> <Property> <Columns> |.RelatedImageList()|String|  (Set|Get) The RelatedImageList as String.
 ///     <Summary>
 ///    (Set|Get) The RelatedImageList as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:967 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The RelatedImageList as String.") ]
    member this.RelatedImageList()
       with get() = _RelatedImageList
       and set(value) = _RelatedImageList <- value
#endregion (Set|Get) The RelatedImageList as String.

#region |2019/07/06 00h51:343| <01.00.23> <Property> <Columns> |.Print_VB()|String|  (Set|Get) The Print_VB as String.
 ///     <Summary>
 ///    (Set|Get) The Print_VB as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:967 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_VB as String.") ]
    member this.Print_VB()
       with get() = _Print_VB
       and set(value) = _Print_VB <- value
#endregion (Set|Get) The Print_VB as String.

#region |2019/07/06 00h51:355| <01.00.24> <Property> <Columns> |.VB()|String|  (Set|Get) The VB as String.
 ///     <Summary>
 ///    (Set|Get) The VB as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:967 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The VB as String.") ]
    member this.VB()
       with get() = _VB
       and set(value) = _VB <- value
#endregion (Set|Get) The VB as String.

#region |2019/07/06 00h51:366| <01.00.25> <Property> <Columns> |.Print_C()|String|  (Set|Get) The Print_C as String.
 ///     <Summary>
 ///    (Set|Get) The Print_C as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:967 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_C as String.") ]
    member this.Print_C()
       with get() = _Print_C
       and set(value) = _Print_C <- value
#endregion (Set|Get) The Print_C as String.

#region |2019/07/06 00h51:379| <01.00.26> <Property> <Columns> |.C()|String|  (Set|Get) The C as String.
 ///     <Summary>
 ///    (Set|Get) The C as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:967 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The C as String.") ]
    member this.C()
       with get() = _C
       and set(value) = _C <- value
#endregion (Set|Get) The C as String.

#region |2019/07/06 00h51:390| <01.00.27> <Property> <Columns> |.Print_F()|String|  (Set|Get) The Print_F as String.
 ///     <Summary>
 ///    (Set|Get) The Print_F as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:968 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_F as String.") ]
    member this.Print_F()
       with get() = _Print_F
       and set(value) = _Print_F <- value
#endregion (Set|Get) The Print_F as String.

#region |2019/07/06 00h51:401| <01.00.28> <Property> <Columns> |.F()|String|  (Set|Get) The F as String.
 ///     <Summary>
 ///    (Set|Get) The F as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:968 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The F as String.") ]
    member this.F()
       with get() = _F
       and set(value) = _F <- value
#endregion (Set|Get) The F as String.

#region |2019/07/06 00h51:413| <01.00.29> <Property> <Columns> |.Print_Python()|String|  (Set|Get) The Print_Python as String.
 ///     <Summary>
 ///    (Set|Get) The Print_Python as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:968 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_Python as String.") ]
    member this.Print_Python()
       with get() = _Print_Python
       and set(value) = _Print_Python <- value
#endregion (Set|Get) The Print_Python as String.

#region |2019/07/06 00h51:425| <01.00.30> <Property> <Columns> |.Python()|String|  (Set|Get) The Python as String.
 ///     <Summary>
 ///    (Set|Get) The Python as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:968 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Python as String.") ]
    member this.Python()
       with get() = _Python
       and set(value) = _Python <- value
#endregion (Set|Get) The Python as String.

#region |2019/07/06 00h51:437| <01.00.31> <Property> <Columns> |.Print_JavaScript()|String|  (Set|Get) The Print_JavaScript as String.
 ///     <Summary>
 ///    (Set|Get) The Print_JavaScript as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:969 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_JavaScript as String.") ]
    member this.Print_JavaScript()
       with get() = _Print_JavaScript
       and set(value) = _Print_JavaScript <- value
#endregion (Set|Get) The Print_JavaScript as String.

#region |2019/07/06 00h51:449| <01.00.32> <Property> <Columns> |.JavaScript()|String|  (Set|Get) The JavaScript as String.
 ///     <Summary>
 ///    (Set|Get) The JavaScript as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:969 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The JavaScript as String.") ]
    member this.JavaScript()
       with get() = _JavaScript
       and set(value) = _JavaScript <- value
#endregion (Set|Get) The JavaScript as String.

#region |2019/07/06 00h51:461| <01.00.33> <Property> <Columns> |.RegionCategory()|Integer|  (Set|Get) The RegionCategory as Integer.
 ///     <Summary>
 ///    (Set|Get) The RegionCategory as Integer.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:969 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The RegionCategory as Integer.") ]
    member this.RegionCategory()
       with get() = _RegionCategory
       and set(value) = _RegionCategory <- value
#endregion (Set|Get) The RegionCategory as Integer.

#region |2019/07/06 00h51:474| <01.00.34> <Property> <Columns> |.RegionCode()|String|  (Set|Get) The RegionCode as String.
 ///     <Summary>
 ///    (Set|Get) The RegionCode as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:969 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The RegionCode as String.") ]
    member this.RegionCode()
       with get() = _RegionCode
       and set(value) = _RegionCode <- value
#endregion (Set|Get) The RegionCode as String.

#region |2019/07/06 00h51:493| <01.00.35> <Property> <Columns> |.AuthorEmail()|String|  (Set|Get) The AuthorEmail as String.
 ///     <Summary>
 ///    (Set|Get) The AuthorEmail as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:969 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AuthorEmail as String.") ]
    member this.AuthorEmail()
       with get() = _AuthorEmail
       and set(value) = _AuthorEmail <- value
#endregion (Set|Get) The AuthorEmail as String.

#region |2019/07/06 00h51:505| <01.00.36> <Property> <Columns> |.AuthorName()|String|  (Set|Get) The AuthorName as String.
 ///     <Summary>
 ///    (Set|Get) The AuthorName as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:970 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AuthorName as String.") ]
    member this.AuthorName()
       with get() = _AuthorName
       and set(value) = _AuthorName <- value
#endregion (Set|Get) The AuthorName as String.

#region |2019/07/06 00h51:517| <01.00.37> <Property> <Columns> |.AuthorUri()|String|  (Set|Get) The AuthorUri as String.
 ///     <Summary>
 ///    (Set|Get) The AuthorUri as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:970 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AuthorUri as String.") ]
    member this.AuthorUri()
       with get() = _AuthorUri
       and set(value) = _AuthorUri <- value
#endregion (Set|Get) The AuthorUri as String.

#region |2019/07/06 00h51:528| <01.00.38> <Property> <Columns> |.ContributorEmail()|String|  (Set|Get) The ContributorEmail as String.
 ///     <Summary>
 ///    (Set|Get) The ContributorEmail as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:970 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ContributorEmail as String.") ]
    member this.ContributorEmail()
       with get() = _ContributorEmail
       and set(value) = _ContributorEmail <- value
#endregion (Set|Get) The ContributorEmail as String.

#region |2019/07/06 00h51:540| <01.00.39> <Property> <Columns> |.ContributorName()|String|  (Set|Get) The ContributorName as String.
 ///     <Summary>
 ///    (Set|Get) The ContributorName as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:970 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ContributorName as String.") ]
    member this.ContributorName()
       with get() = _ContributorName
       and set(value) = _ContributorName <- value
#endregion (Set|Get) The ContributorName as String.

#region |2019/07/06 00h51:552| <01.00.40> <Property> <Columns> |.ContributorUri()|String|  (Set|Get) The ContributorUri as String.
 ///     <Summary>
 ///    (Set|Get) The ContributorUri as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:970 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ContributorUri as String.") ]
    member this.ContributorUri()
       with get() = _ContributorUri
       and set(value) = _ContributorUri <- value
#endregion (Set|Get) The ContributorUri as String.

#region |2019/07/06 00h51:565| <01.00.41> <Property> <Columns> |.CustomProperty()|String|  (Set|Get) The CustomProperty as String.
 ///     <Summary>
 ///    (Set|Get) The CustomProperty as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:971 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The CustomProperty as String.") ]
    member this.CustomProperty()
       with get() = _CustomProperty
       and set(value) = _CustomProperty <- value
#endregion (Set|Get) The CustomProperty as String.

#region |2019/07/06 00h51:577| <01.00.42> <Property> <Columns> |.Published()|String|  (Set|Get) The Published as String.
 ///     <Summary>
 ///    (Set|Get) The Published as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:971 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Published as String.") ]
    member this.Published()
       with get() = _Published
       and set(value) = _Published <- value
#endregion (Set|Get) The Published as String.

#region |2019/07/06 00h51:589| <01.00.43> <Property> <Columns> |.Rights()|String|  (Set|Get) The Rights as String.
 ///     <Summary>
 ///    (Set|Get) The Rights as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:971 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Rights as String.") ]
    member this.Rights()
       with get() = _Rights
       and set(value) = _Rights <- value
#endregion (Set|Get) The Rights as String.

#region |2019/07/06 00h51:601| <01.00.44> <Property> <Columns> |.Summary()|String|  (Set|Get) The Summary as String.
 ///     <Summary>
 ///    (Set|Get) The Summary as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:971 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Summary as String.") ]
    member this.Summary()
       with get() = _Summary
       and set(value) = _Summary <- value
#endregion (Set|Get) The Summary as String.

#region |2019/07/06 00h51:614| <01.00.45> <Property> <Columns> |.Title()|String|  (Set|Get) The Title as String.
 ///     <Summary>
 ///    (Set|Get) The Title as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:972 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Title as String.") ]
    member this.Title()
       with get() = _Title
       and set(value) = _Title <- value
#endregion (Set|Get) The Title as String.

#region |2019/07/06 00h51:626| <01.00.46> <Property> <Columns> |.Updated()|String|  (Set|Get) The Updated as String.
 ///     <Summary>
 ///    (Set|Get) The Updated as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:972 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Updated as String.") ]
    member this.Updated()
       with get() = _Updated
       and set(value) = _Updated <- value
#endregion (Set|Get) The Updated as String.

#region |2019/07/06 00h51:638| <01.00.47> <Property> <Columns> |.Usage()|String|  (Set|Get) The Usage as String.
 ///     <Summary>
 ///    (Set|Get) The Usage as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:972 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Usage as String.") ]
    member this.Usage()
       with get() = _Usage
       and set(value) = _Usage <- value
#endregion (Set|Get) The Usage as String.

#region |2019/07/06 00h51:650| <01.00.48> <Property> <Columns> |.Remarks()|String|  (Set|Get) The Remarks as String.
 ///     <Summary>
 ///    (Set|Get) The Remarks as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:972 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Remarks as String.") ]
    member this.Remarks()
       with get() = _Remarks
       and set(value) = _Remarks <- value
#endregion (Set|Get) The Remarks as String.

#region |2019/07/06 00h51:663| <01.00.49> <Property> <Columns> |.Example()|String|  (Set|Get) The Example as String.
 ///     <Summary>
 ///    (Set|Get) The Example as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:973 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Example as String.") ]
    member this.Example()
       with get() = _Example
       and set(value) = _Example <- value
#endregion (Set|Get) The Example as String.

#region |2019/07/06 00h51:677| <01.00.50> <Property> <Columns> |.Note()|String|  (Set|Get) The Note as String.
 ///     <Summary>
 ///    (Set|Get) The Note as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:973 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Note as String.") ]
    member this.Note()
       with get() = _Note
       and set(value) = _Note <- value
#endregion (Set|Get) The Note as String.

#region |2019/07/06 00h51:689| <01.00.51> <Property> <Columns> |.CreationDate()|String|  (Set|Get) The CreationDate as String.
 ///     <Summary>
 ///    (Set|Get) The CreationDate as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:973 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The CreationDate as String.") ]
    member this.CreationDate()
       with get() = _CreationDate
       and set(value) = _CreationDate <- value
#endregion (Set|Get) The CreationDate as String.

#region |2019/07/06 00h51:702| <01.00.52> <Property> <Columns> |.See()|String|  (Set|Get) The See as String.
 ///     <Summary>
 ///    (Set|Get) The See as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:973 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The See as String.") ]
    member this.See()
       with get() = _See
       and set(value) = _See <- value
#endregion (Set|Get) The See as String.

#region |2019/07/06 00h51:715| <01.00.53> <Property> <Columns> |.SeeAlso()|String|  (Set|Get) The SeeAlso as String.
 ///     <Summary>
 ///    (Set|Get) The SeeAlso as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:974 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The SeeAlso as String.") ]
    member this.SeeAlso()
       with get() = _SeeAlso
       and set(value) = _SeeAlso <- value
#endregion (Set|Get) The SeeAlso as String.

#region |2019/07/06 00h51:737| <01.00.54> <Property> <Columns> |.Rules()|String|  (Set|Get) The Rules as String.
 ///     <Summary>
 ///    (Set|Get) The Rules as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:974 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Rules as String.") ]
    member this.Rules()
       with get() = _Rules
       and set(value) = _Rules <- value
#endregion (Set|Get) The Rules as String.

#region |2019/07/06 00h51:749| <01.00.55> <Property> <Columns> |.Syntax()|String|  (Set|Get) The Syntax as String.
 ///     <Summary>
 ///    (Set|Get) The Syntax as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:974 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Syntax as String.") ]
    member this.Syntax()
       with get() = _Syntax
       and set(value) = _Syntax <- value
#endregion (Set|Get) The Syntax as String.

#region |2019/07/06 00h51:763| <01.00.56> <Property> <Columns> |.Default()|Boolean|  (Set|Get) The Default as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Default as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:974 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Default as Boolean.") ]
    member this.Default()
       with get() = _Default
       and set(value) = _Default <- value
#endregion (Set|Get) The Default as Boolean.

#region |2019/07/06 00h51:776| <01.00.57> <Property> <Columns> |.AccessModifier()|String|  (Set|Get) The AccessModifier as String.
 ///     <Summary>
 ///    (Set|Get) The AccessModifier as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:974 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AccessModifier as String.") ]
    member this.AccessModifier()
       with get() = _AccessModifier
       and set(value) = _AccessModifier <- value
#endregion (Set|Get) The AccessModifier as String.

#region |2019/07/06 00h51:788| <01.00.58> <Property> <Columns> |.Shared()|Boolean|  (Set|Get) The Shared as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Shared as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:975 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Shared as Boolean.") ]
    member this.Shared()
       with get() = _Shared
       and set(value) = _Shared <- value
#endregion (Set|Get) The Shared as Boolean.

#region |2019/07/06 00h51:800| <01.00.59> <Property> <Columns> |.Shadows()|Boolean|  (Set|Get) The Shadows as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Shadows as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:975 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Shadows as Boolean.") ]
    member this.Shadows()
       with get() = _Shadows
       and set(value) = _Shadows <- value
#endregion (Set|Get) The Shadows as Boolean.

#region |2019/07/06 00h51:813| <01.00.60> <Property> <Columns> |.ReadOnly()|Boolean|  (Set|Get) The ReadOnly as Boolean.
 ///     <Summary>
 ///    (Set|Get) The ReadOnly as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:975 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ReadOnly as Boolean.") ]
    member this.ReadOnly()
       with get() = _ReadOnly
       and set(value) = _ReadOnly <- value
#endregion (Set|Get) The ReadOnly as Boolean.

#region |2019/07/06 00h51:826| <01.00.61> <Property> <Columns> |.WriteOnly()|Boolean|  (Set|Get) The WriteOnly as Boolean.
 ///     <Summary>
 ///    (Set|Get) The WriteOnly as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:976 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The WriteOnly as Boolean.") ]
    member this.WriteOnly()
       with get() = _WriteOnly
       and set(value) = _WriteOnly <- value
#endregion (Set|Get) The WriteOnly as Boolean.

#region |2019/07/06 00h51:839| <01.00.62> <Property> <Columns> |.PropertyModifier()|String|  (Set|Get) The PropertyModifier as String.
 ///     <Summary>
 ///    (Set|Get) The PropertyModifier as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:978 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The PropertyModifier as String.") ]
    member this.PropertyModifier()
       with get() = _PropertyModifier
       and set(value) = _PropertyModifier <- value
#endregion (Set|Get) The PropertyModifier as String.

#region |2019/07/06 00h51:852| <01.00.63> <Property> <Columns> |.ReturnType()|String|  (Set|Get) The ReturnType as String.
 ///     <Summary>
 ///    (Set|Get) The ReturnType as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:978 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ReturnType as String.") ]
    member this.ReturnType()
       with get() = _ReturnType
       and set(value) = _ReturnType <- value
#endregion (Set|Get) The ReturnType as String.

#region |2019/07/06 00h51:866| <01.00.64> <Property> <Columns> |.Required()|Boolean|  (Set|Get) The Required as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Required as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:978 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Required as Boolean.") ]
    member this.Required()
       with get() = _Required
       and set(value) = _Required <- value
#endregion (Set|Get) The Required as Boolean.

#region |2019/07/06 00h51:880| <01.00.65> <Property> <Columns> |.Variable_Name()|String|  (Set|Get) The Variable_Name as String.
 ///     <Summary>
 ///    (Set|Get) The Variable_Name as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:979 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Variable_Name as String.") ]
    member this.Variable_Name()
       with get() = _Variable_Name
       and set(value) = _Variable_Name <- value
#endregion (Set|Get) The Variable_Name as String.

#region |2019/07/06 00h51:893| <01.00.66> <Property> <Columns> |.Variable_AccessModifier()|String|  (Set|Get) The Variable_AccessModifier as String.
 ///     <Summary>
 ///    (Set|Get) The Variable_AccessModifier as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:979 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Variable_AccessModifier as String.") ]
    member this.Variable_AccessModifier()
       with get() = _Variable_AccessModifier
       and set(value) = _Variable_AccessModifier <- value
#endregion (Set|Get) The Variable_AccessModifier as String.

#region |2019/07/06 00h51:906| <01.00.67> <Property> <Columns> |.Variable_ReturnType()|String|  (Set|Get) The Variable_ReturnType as String.
 ///     <Summary>
 ///    (Set|Get) The Variable_ReturnType as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:979 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Variable_ReturnType as String.") ]
    member this.Variable_ReturnType()
       with get() = _Variable_ReturnType
       and set(value) = _Variable_ReturnType <- value
#endregion (Set|Get) The Variable_ReturnType as String.

#region |2019/07/06 00h51:922| <01.00.68> <Property> <Columns> |.SetStatement()|String|  (Set|Get) The SetStatement as String.
 ///     <Summary>
 ///    (Set|Get) The SetStatement as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:979 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The SetStatement as String.") ]
    member this.SetStatement()
       with get() = _SetStatement
       and set(value) = _SetStatement <- value
#endregion (Set|Get) The SetStatement as String.

#region |2019/07/06 00h51:935| <01.00.69> <Property> <Columns> |.GetStatement()|String|  (Set|Get) The GetStatement as String.
 ///     <Summary>
 ///    (Set|Get) The GetStatement as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:980 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The GetStatement as String.") ]
    member this.GetStatement()
       with get() = _GetStatement
       and set(value) = _GetStatement <- value
#endregion (Set|Get) The GetStatement as String.

#region |2019/07/06 00h51:948| <01.00.70> <Property> <Columns> |.ParentName()|String|  (Set|Get) The ParentName as String.
 ///     <Summary>
 ///    (Set|Get) The ParentName as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:980 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ParentName as String.") ]
    member this.ParentName()
       with get() = _ParentName
       and set(value) = _ParentName <- value
#endregion (Set|Get) The ParentName as String.

#end region 
#region <2> [Enumeration]{1}
#region |2019/07/06 00h51:973| <02.00.00> <Property> <> |.Schema()|Enumeration{70}|"' (Set|Get) The enumeration of Schema.
     ///     <Summary>
 ///    (Set|Get) The enumeration of Schema.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:980 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The enumeration of Schema.") ]
    Type Schema = 
/// <summary>(Set|Get) The ID as Integer.</summary>
|   [ID] = 0
/// <summary>(Set|Get) The Name as String.</summary>
|   [Name] = 1
/// <summary>(Set|Get) The ImageIndex as Integer.</summary>
|   [ImageIndex] = 2
/// <summary>(Set|Get) The Text as String.</summary>
|   [Text] = 3
/// <summary>(Set|Get) The ToolTip as String.</summary>
|   [ToolTip] = 4
/// <summary>(Set|Get) The Enable as Boolean.</summary>
|   [Enable] = 5
/// <summary>(Set|Get) The Status as String.</summary>
|   [Status] = 6
/// <summary>(Set|Get) The Statement as String.</summary>
|   [Statement] = 7
/// <summary>(Set|Get) The XMLFile as String.</summary>
|   [XMLFile] = 8
/// <summary>(Set|Get) The Attributes as String.</summary>
|   [Attributes] = 9
/// <summary>(Set|Get) The Browsable as Boolean.</summary>
|   [Browsable] = 10
/// <summary>(Set|Get) The Category as String.</summary>
|   [Category] = 11
/// <summary>(Set|Get) The Description as String.</summary>
|   [Description] = 12
/// <summary>(Set|Get) The DefaultValue as String.</summary>
|   [DefaultValue] = 13
/// <summary>(Set|Get) The Editor as String.</summary>
|   [Editor] = 14
/// <summary>(Set|Get) The DllImport as String.</summary>
|   [DllImport] = 15
/// <summary>(Set|Get) The Deserializable as Boolean.</summary>
|   [Deserializable] = 16
/// <summary>(Set|Get) The NonSerialized as Boolean.</summary>
|   [NonSerialized] = 17
/// <summary>(Set|Get) The Serializable as Boolean.</summary>
|   [Serializable] = 18
/// <summary>(Set|Get) The XmlRoot as String.</summary>
|   [XmlRoot] = 19
/// <summary>(Set|Get) The XmlIgnore as Boolean.</summary>
|   [XmlIgnore] = 20
/// <summary>(Set|Get) The XmlInclude as Boolean.</summary>
|   [XmlInclude] = 21
/// <summary>(Set|Get) The RelatedImageList as String.</summary>
|   [RelatedImageList] = 22
/// <summary>(Set|Get) The Print_VB as String.</summary>
|   [Print_VB] = 23
/// <summary>(Set|Get) The VB as String.</summary>
|   [VB] = 24
/// <summary>(Set|Get) The Print_C as String.</summary>
|   [Print_C] = 25
/// <summary>(Set|Get) The C as String.</summary>
|   [C] = 26
/// <summary>(Set|Get) The Print_F as String.</summary>
|   [Print_F] = 27
/// <summary>(Set|Get) The F as String.</summary>
|   [F] = 28
/// <summary>(Set|Get) The Print_Python as String.</summary>
|   [Print_Python] = 29
/// <summary>(Set|Get) The Python as String.</summary>
|   [Python] = 30
/// <summary>(Set|Get) The Print_JavaScript as String.</summary>
|   [Print_JavaScript] = 31
/// <summary>(Set|Get) The JavaScript as String.</summary>
|   [JavaScript] = 32
/// <summary>(Set|Get) The RegionCategory as Integer.</summary>
|   [RegionCategory] = 33
/// <summary>(Set|Get) The RegionCode as String.</summary>
|   [RegionCode] = 34
/// <summary>(Set|Get) The AuthorEmail as String.</summary>
|   [AuthorEmail] = 35
/// <summary>(Set|Get) The AuthorName as String.</summary>
|   [AuthorName] = 36
/// <summary>(Set|Get) The AuthorUri as String.</summary>
|   [AuthorUri] = 37
/// <summary>(Set|Get) The ContributorEmail as String.</summary>
|   [ContributorEmail] = 38
/// <summary>(Set|Get) The ContributorName as String.</summary>
|   [ContributorName] = 39
/// <summary>(Set|Get) The ContributorUri as String.</summary>
|   [ContributorUri] = 40
/// <summary>(Set|Get) The CustomProperty as String.</summary>
|   [CustomProperty] = 41
/// <summary>(Set|Get) The Published as String.</summary>
|   [Published] = 42
/// <summary>(Set|Get) The Rights as String.</summary>
|   [Rights] = 43
/// <summary>(Set|Get) The Summary as String.</summary>
|   [Summary] = 44
/// <summary>(Set|Get) The Title as String.</summary>
|   [Title] = 45
/// <summary>(Set|Get) The Updated as String.</summary>
|   [Updated] = 46
/// <summary>(Set|Get) The Usage as String.</summary>
|   [Usage] = 47
/// <summary>(Set|Get) The Remarks as String.</summary>
|   [Remarks] = 48
/// <summary>(Set|Get) The Example as String.</summary>
|   [Example] = 49
/// <summary>(Set|Get) The Note as String.</summary>
|   [Note] = 50
/// <summary>(Set|Get) The CreationDate as String.</summary>
|   [CreationDate] = 51
/// <summary>(Set|Get) The See as String.</summary>
|   [See] = 52
/// <summary>(Set|Get) The SeeAlso as String.</summary>
|   [SeeAlso] = 53
/// <summary>(Set|Get) The Rules as String.</summary>
|   [Rules] = 54
/// <summary>(Set|Get) The Syntax as String.</summary>
|   [Syntax] = 55
/// <summary>(Set|Get) The Default as Boolean.</summary>
|   [Default] = 56
/// <summary>(Set|Get) The AccessModifier as String.</summary>
|   [AccessModifier] = 57
/// <summary>(Set|Get) The Shared as Boolean.</summary>
|   [Shared] = 58
/// <summary>(Set|Get) The Shadows as Boolean.</summary>
|   [Shadows] = 59
/// <summary>(Set|Get) The ReadOnly as Boolean.</summary>
|   [ReadOnly] = 60
/// <summary>(Set|Get) The WriteOnly as Boolean.</summary>
|   [WriteOnly] = 61
/// <summary>(Set|Get) The PropertyModifier as String.</summary>
|   [PropertyModifier] = 62
/// <summary>(Set|Get) The ReturnType as String.</summary>
|   [ReturnType] = 63
/// <summary>(Set|Get) The Required as Boolean.</summary>
|   [Required] = 64
/// <summary>(Set|Get) The Variable_Name as String.</summary>
|   [Variable_Name] = 65
/// <summary>(Set|Get) The Variable_AccessModifier as String.</summary>
|   [Variable_AccessModifier] = 66
/// <summary>(Set|Get) The Variable_ReturnType as String.</summary>
|   [Variable_ReturnType] = 67
/// <summary>(Set|Get) The SetStatement as String.</summary>
|   [SetStatement] = 68
/// <summary>(Set|Get) The GetStatement as String.</summary>
|   [GetStatement] = 69
/// <summary>(Set|Get) The ParentName as String.</summary>
|   [ParentName] = 70
#endregion (Set|Get) The enumeration of Schema.

#end region 
#region <4> [Sub]{5}
#region |2019/07/06 00h51:995| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
     ///     <Summary>
 ///    (Set|Get) This will reinitialize the class element.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:982 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will reinitialize the class element.") ]
    Let Clear = 
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
#endregion (Set|Get) This will reinitialize the class element.

#region |2019/07/06 00h51:010| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
     ///     <Summary>
 ///    (Set|Get) This will reinitialize the variables of this class.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:983 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will reinitialize the variables of this class.") ]
    Let Reset = 
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

#endregion (Set|Get) This will reinitialize the variables of this class.

#region |2019/07/06 00h51:032| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
     ///     <Summary>
 ///    (Set|Get) This will add a new row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:983 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will add a new row in the table.") ]
    Let Add = 
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

#endregion (Set|Get) This will add a new row in the table.

#region |2019/07/06 00h51:049| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
     ///     <Summary>
 ///    (Set|Get) This will update a row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:983 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will update a row in the table.") ]
    Let Save = 
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

#endregion (Set|Get) This will update a row in the table.

#region |2019/07/06 00h51:064| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
     ///     <Summary>
 ///    (Set|Get) This will Delete a row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:985 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will Delete a row in the table.") ]
    Let Delete = 
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

#endregion (Set|Get) This will Delete a row in the table.

#end region 
#region <5> [Function]{7}
#region |2019/07/06 00h51:078| <05.00.00> <Sub> <> |.Open()|Sub}|"' (Set|Get) This will initialise the connection and import the data.
     ///     <Summary>
 ///    (Set|Get) This will initialise the connection and import the data.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:986 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will initialise the connection and import the data.") ]
    Let Open = 
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

#endregion (Set|Get) This will initialise the connection and import the data.

#region |2019/07/06 00h51:095| <05.00.01> <Sub> <> |.Close()|Sub}|"' (Set|Get) This willClosing the connection
     ///     <Summary>
 ///    (Set|Get) This willClosing the connection
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:986 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This willClosing the connection") ]
    Let Close = 
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

#endregion (Set|Get) This willClosing the connection

#region |2019/07/06 00h51:111| <05.00.02> <Sub> <> |.List()|Sub}|"' (Set|Get) Return the entire table listed
     ///     <Summary>
 ///    (Set|Get) Return the entire table listed
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:986 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Return the entire table listed") ]
    Let List = 
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
#endregion (Set|Get) Return the entire table listed

#region |2019/07/06 00h51:127| <05.00.03> <Sub> <> |.SearchByName()|Sub}|"' (Set|Get) Search for each property that match the Search String.
     ///     <Summary>
 ///    (Set|Get) Search for each property that match the Search String.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:986 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Search for each property that match the Search String.") ]
    Let SearchByName = 
    Dim Result As New List(Of Property)
 Dim C As New Property
 For Each Element As Property In C.List
 If Element.Name.Tolower() = Search.Tolower() Or Element.Text.Tolower() = Search.Tolower()  Or Element.ToolTip.Tolower() = Search.Tolower()  Or Element.Status.Tolower() = Search.Tolower()  Or Element.Statement.Tolower() = Search.Tolower()  Or Element.XMLFile.Tolower() = Search.Tolower()  Or Element.Attributes.Tolower() = Search.Tolower()  Or Element.Category.Tolower() = Search.Tolower()  Or Element.Description.Tolower() = Search.Tolower()  Or Element.DefaultValue.Tolower() = Search.Tolower()  Or Element.Editor.Tolower() = Search.Tolower()  Or Element.DllImport.Tolower() = Search.Tolower()  Or Element.XmlRoot.Tolower() = Search.Tolower()  Or Element.RelatedImageList.Tolower() = Search.Tolower()  Or Element.Print_VB.Tolower() = Search.Tolower()  Or Element.VB.Tolower() = Search.Tolower()  Or Element.Print_C.Tolower() = Search.Tolower()  Or Element.C.Tolower() = Search.Tolower()  Or Element.Print_F.Tolower() = Search.Tolower()  Or Element.F.Tolower() = Search.Tolower()  Or Element.Print_Python.Tolower() = Search.Tolower()  Or Element.Python.Tolower() = Search.Tolower()  Or Element.Print_JavaScript.Tolower() = Search.Tolower()  Or Element.JavaScript.Tolower() = Search.Tolower()  Or Element.RegionCode.Tolower() = Search.Tolower()  Or Element.AuthorEmail.Tolower() = Search.Tolower()  Or Element.AuthorName.Tolower() = Search.Tolower()  Or Element.AuthorUri.Tolower() = Search.Tolower()  Or Element.ContributorEmail.Tolower() = Search.Tolower()  Or Element.ContributorName.Tolower() = Search.Tolower()  Or Element.ContributorUri.Tolower() = Search.Tolower()  Or Element.CustomProperty.Tolower() = Search.Tolower()  Or Element.Published.Tolower() = Search.Tolower()  Or Element.Rights.Tolower() = Search.Tolower()  Or Element.Summary.Tolower() = Search.Tolower()  Or Element.Title.Tolower() = Search.Tolower()  Or Element.Updated.Tolower() = Search.Tolower()  Or Element.Usage.Tolower() = Search.Tolower()  Or Element.Remarks.Tolower() = Search.Tolower()  Or Element.Example.Tolower() = Search.Tolower()  Or Element.Note.Tolower() = Search.Tolower()  Or Element.CreationDate.Tolower() = Search.Tolower()  Or Element.See.Tolower() = Search.Tolower()  Or Element.SeeAlso.Tolower() = Search.Tolower()  Or Element.Rules.Tolower() = Search.Tolower()  Or Element.Syntax.Tolower() = Search.Tolower()  Or Element.AccessModifier.Tolower() = Search.Tolower()  Or Element.PropertyModifier.Tolower() = Search.Tolower()  Or Element.ReturnType.Tolower() = Search.Tolower()  Or Element.Variable_Name.Tolower() = Search.Tolower()  Or Element.Variable_AccessModifier.Tolower() = Search.Tolower()  Or Element.Variable_ReturnType.Tolower() = Search.Tolower()  Or Element.SetStatement.Tolower() = Search.Tolower()  Or Element.GetStatement.Tolower() = Search.Tolower()  Or Element.ParentName.Tolower() = Search.Tolower() Then
      Result.Add(Element)
 End If
 Next
 Return Result
#endregion (Set|Get) Search for each property that match the Search String.

#region |2019/07/06 00h51:145| <05.00.04> <Sub> <> |.SearchByID()|Sub}|"' (Set|Get) Search for each property that match the Search Id.
     ///     <Summary>
 ///    (Set|Get) Search for each property that match the Search Id.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:986 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Search for each property that match the Search Id.") ]
    Let SearchByID = 
    Dim Result As New List(Of Property)
 Dim C As New Property
 For Each Element As Property In C.List
 If Val(Element.ID) = Search Or Val(Element.ImageIndex) = Search  Or Val(Element.RegionCategory) = Search Then
      Result.Add(Element)
 End If
 Next
 Return Result
#endregion (Set|Get) Search for each property that match the Search Id.

#region |2019/07/06 00h51:161| <05.00.05> <Sub> <> |.ToString()|Sub}|"' (Set|Get) The function ToString.
     ///     <Summary>
 ///    (Set|Get) The function ToString.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:987 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The function ToString.") ]
    Let ToString = 
        Return Me.ID
#endregion (Set|Get) The function ToString.

#region |2019/07/06 00h51:177| <05.00.06> <Sub> <> |.CheckConnection()|Sub}|"' (Set|Get) Evaluate the connection to the DataBase
     ///     <Summary>
 ///    (Set|Get) Evaluate the connection to the DataBase
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:987 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Evaluate the connection to the DataBase") ]
    Let CheckConnection = 
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

#endregion (Set|Get) Evaluate the connection to the DataBase

#end region 
#region <6> [Runtime]{12}
#region |2019/07/06 00h51:193| <15.00.00> <Runtime> <> |.Table()|Runtime|  (Set|Get) The Table.
 ///     <Summary>
 ///    (Set|Get) The Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:987 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Table.") ]
   Public Table Table;
#endregion (Set|Get) The Table.

#region |2019/07/06 00h51:207| <15.00.01> <Runtime> <> |.Line()|Runtime|  (Set|Get) The Connection String To the Table.
 ///     <Summary>
 ///    (Set|Get) The Connection String To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:988 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Connection String To the Table.") ]
   Public String Line;
#endregion (Set|Get) The Connection String To the Table.

#region |2019/07/06 00h51:223| <15.00.02> <Runtime> <> |.FilePath()|Runtime|  (Set|Get) The FilePath To the Table.
 ///     <Summary>
 ///    (Set|Get) The FilePath To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:988 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The FilePath To the Table.") ]
   Public String FilePath;
#endregion (Set|Get) The FilePath To the Table.

#region |2019/07/06 00h51:238| <15.00.03> <Runtime> <> |.Password()|Runtime|  (Set|Get) The Password To the Table.
 ///     <Summary>
 ///    (Set|Get) The Password To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:988 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Password To the Table.") ]
   Public String Password;
#endregion (Set|Get) The Password To the Table.

#region |2019/07/06 00h51:252| <15.00.04> <Runtime> <> |.UseSQL()|Runtime|  (Set|Get) Determines if the Database Connection is of type SQL.
 ///     <Summary>
 ///    (Set|Get) Determines if the Database Connection is of type SQL.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:988 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Determines if the Database Connection is of type SQL.") ]
   Public Boolean UseSQL;
#endregion (Set|Get) Determines if the Database Connection is of type SQL.

#region |2019/07/06 00h51:267| <15.00.05> <Runtime> <> |.TableName()|Runtime|  (Set|Get) The name of the Table.
 ///     <Summary>
 ///    (Set|Get) The name of the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:989 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The name of the Table.") ]
   Public String TableName;
#endregion (Set|Get) The name of the Table.

#region |2019/07/06 00h51:284| <15.00.06> <Runtime> <> |.Con()|Runtime|  (Set|Get) The Con To the Table.
 ///     <Summary>
 ///    (Set|Get) The Con To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:989 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Con To the Table.") ]
   Public OleDb.OleDbConnection Con;
#endregion (Set|Get) The Con To the Table.

#region |2019/07/06 00h51:290| <15.00.07> <Runtime> <> |.Cmd()|Runtime|  (Set|Get) The Cmd To the Table.
 ///     <Summary>
 ///    (Set|Get) The Cmd To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:989 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Cmd To the Table.") ]
   Public OleDb.OleDbCommand Cmd;
#endregion (Set|Get) The Cmd To the Table.

#region |2019/07/06 00h51:315| <15.00.08> <Runtime> <> |.DataReader()|Runtime|  (Set|Get) The DataReader To the Table.
 ///     <Summary>
 ///    (Set|Get) The DataReader To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:989 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The DataReader To the Table.") ]
   Public OleDb.OleDbDataReader DataReader;
#endregion (Set|Get) The DataReader To the Table.

#region |2019/07/06 00h51:330| <15.00.09> <Runtime> <> |.DataAdapter()|Runtime|  (Set|Get) The DataAdapter To the Table.
 ///     <Summary>
 ///    (Set|Get) The DataAdapter To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:990 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The DataAdapter To the Table.") ]
   Public OleDb.OleDbDataAdapter DataAdapter;
#endregion (Set|Get) The DataAdapter To the Table.

#region |2019/07/06 00h51:345| <15.00.10> <Runtime> <> |.Connector()|Runtime|  (Set|Get) The Connector To the Table.
 ///     <Summary>
 ///    (Set|Get) The Connector To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:990 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Connector To the Table.") ]
   Public LineInfo Connector;
#endregion (Set|Get) The Connector To the Table.

#region |2019/07/06 00h51:362| <15.00.11> <Runtime> <> |.Log()|Runtime|  (Set|Get) The Log To the Table.
 ///     <Summary>
 ///    (Set|Get) The Log To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:990 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Log To the Table.") ]
   Public String Log;
#endregion (Set|Get) The Log To the Table.

#end region 
#region <7> [Loader]{2}
#region |2019/07/06 00h51:378| <06.00.00> <Sub> <> |.Empty()|Sub}|"' (Set|Get) The sub Empty.
     ///     <Summary>
 ///    (Set|Get) The sub Empty.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:991 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The sub Empty.") ]
    Let Empty = 
    Reset
#endregion (Set|Get) The sub Empty.

#region |2019/07/06 00h51:382| <06.00.01> <Sub> <> |.Filled()|Sub}|"' (Set|Get) The sub Filled.
     ///     <Summary>
 ///    (Set|Get) The sub Filled.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:991 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The sub Filled.") ]
    Let Filled = 
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

#endregion (Set|Get) The sub Filled.

#end region 
}

 ///     <Summary>
 ///    Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Statement
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
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:024 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
public  class Statement{
#region <1> [Property]{56}
#region |2019/07/06 00h51:567| <01.00.00> <Property> <Columns> |.ID()|Integer|  (Set|Get) The ID as Integer.
 ///     <Summary>
 ///    (Set|Get) The ID as Integer.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:024 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ID as Integer.") ]
    member this.ID()
       with get() = _ID
       and set(value) = _ID <- value
#endregion (Set|Get) The ID as Integer.

#region |2019/07/06 00h51:580| <01.00.01> <Property> <Columns> |.Name()|String|  (Set|Get) The Name as String.
 ///     <Summary>
 ///    (Set|Get) The Name as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:024 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Name as String.") ]
    member this.Name()
       with get() = _Name
       and set(value) = _Name <- value
#endregion (Set|Get) The Name as String.

#region |2019/07/06 00h51:592| <01.00.02> <Property> <Columns> |.ImageIndex()|Integer|  (Set|Get) The ImageIndex as Integer.
 ///     <Summary>
 ///    (Set|Get) The ImageIndex as Integer.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:025 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ImageIndex as Integer.") ]
    member this.ImageIndex()
       with get() = _ImageIndex
       and set(value) = _ImageIndex <- value
#endregion (Set|Get) The ImageIndex as Integer.

#region |2019/07/06 00h51:603| <01.00.03> <Property> <Columns> |.Text()|String|  (Set|Get) The Text as String.
 ///     <Summary>
 ///    (Set|Get) The Text as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:025 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Text as String.") ]
    member this.Text()
       with get() = _Text
       and set(value) = _Text <- value
#endregion (Set|Get) The Text as String.

#region |2019/07/06 00h51:614| <01.00.04> <Property> <Columns> |.ToolTip()|String|  (Set|Get) The ToolTip as String.
 ///     <Summary>
 ///    (Set|Get) The ToolTip as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:025 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ToolTip as String.") ]
    member this.ToolTip()
       with get() = _ToolTip
       and set(value) = _ToolTip <- value
#endregion (Set|Get) The ToolTip as String.

#region |2019/07/06 00h51:626| <01.00.05> <Property> <Columns> |.Enable()|Boolean|  (Set|Get) The Enable as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Enable as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:025 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Enable as Boolean.") ]
    member this.Enable()
       with get() = _Enable
       and set(value) = _Enable <- value
#endregion (Set|Get) The Enable as Boolean.

#region |2019/07/06 00h51:642| <01.00.06> <Property> <Columns> |.Status()|String|  (Set|Get) The Status as String.
 ///     <Summary>
 ///    (Set|Get) The Status as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:025 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Status as String.") ]
    member this.Status()
       with get() = _Status
       and set(value) = _Status <- value
#endregion (Set|Get) The Status as String.

#region |2019/07/06 00h51:653| <01.00.07> <Property> <Columns> |.Statement()|String|  (Set|Get) The Statement as String.
 ///     <Summary>
 ///    (Set|Get) The Statement as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:026 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Statement as String.") ]
    member this.Statement()
       with get() = _Statement
       and set(value) = _Statement <- value
#endregion (Set|Get) The Statement as String.

#region |2019/07/06 00h51:665| <01.00.08> <Property> <Columns> |.XMLFile()|String|  (Set|Get) The XMLFile as String.
 ///     <Summary>
 ///    (Set|Get) The XMLFile as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:026 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XMLFile as String.") ]
    member this.XMLFile()
       with get() = _XMLFile
       and set(value) = _XMLFile <- value
#endregion (Set|Get) The XMLFile as String.

#region |2019/07/06 00h51:676| <01.00.09> <Property> <Columns> |.Attributes()|String|  (Set|Get) The Attributes as String.
 ///     <Summary>
 ///    (Set|Get) The Attributes as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:026 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Attributes as String.") ]
    member this.Attributes()
       with get() = _Attributes
       and set(value) = _Attributes <- value
#endregion (Set|Get) The Attributes as String.

#region |2019/07/06 00h51:689| <01.00.10> <Property> <Columns> |.Browsable()|Boolean|  (Set|Get) The Browsable as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Browsable as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:026 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Browsable as Boolean.") ]
    member this.Browsable()
       with get() = _Browsable
       and set(value) = _Browsable <- value
#endregion (Set|Get) The Browsable as Boolean.

#region |2019/07/06 00h51:700| <01.00.11> <Property> <Columns> |.Category()|String|  (Set|Get) The Category as String.
 ///     <Summary>
 ///    (Set|Get) The Category as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:026 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Category as String.") ]
    member this.Category()
       with get() = _Category
       and set(value) = _Category <- value
#endregion (Set|Get) The Category as String.

#region |2019/07/06 00h51:712| <01.00.12> <Property> <Columns> |.Description()|String|  (Set|Get) The Description as String.
 ///     <Summary>
 ///    (Set|Get) The Description as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:027 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Description as String.") ]
    member this.Description()
       with get() = _Description
       and set(value) = _Description <- value
#endregion (Set|Get) The Description as String.

#region |2019/07/06 00h51:723| <01.00.13> <Property> <Columns> |.DefaultValue()|String|  (Set|Get) The DefaultValue as String.
 ///     <Summary>
 ///    (Set|Get) The DefaultValue as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:027 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The DefaultValue as String.") ]
    member this.DefaultValue()
       with get() = _DefaultValue
       and set(value) = _DefaultValue <- value
#endregion (Set|Get) The DefaultValue as String.

#region |2019/07/06 00h51:734| <01.00.14> <Property> <Columns> |.Editor()|String|  (Set|Get) The Editor as String.
 ///     <Summary>
 ///    (Set|Get) The Editor as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:027 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Editor as String.") ]
    member this.Editor()
       with get() = _Editor
       and set(value) = _Editor <- value
#endregion (Set|Get) The Editor as String.

#region |2019/07/06 00h51:746| <01.00.15> <Property> <Columns> |.DllImport()|String|  (Set|Get) The DllImport as String.
 ///     <Summary>
 ///    (Set|Get) The DllImport as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:028 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The DllImport as String.") ]
    member this.DllImport()
       with get() = _DllImport
       and set(value) = _DllImport <- value
#endregion (Set|Get) The DllImport as String.

#region |2019/07/06 00h51:757| <01.00.16> <Property> <Columns> |.Deserializable()|Boolean|  (Set|Get) The Deserializable as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Deserializable as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:028 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Deserializable as Boolean.") ]
    member this.Deserializable()
       with get() = _Deserializable
       and set(value) = _Deserializable <- value
#endregion (Set|Get) The Deserializable as Boolean.

#region |2019/07/06 00h51:768| <01.00.17> <Property> <Columns> |.NonSerialized()|Boolean|  (Set|Get) The NonSerialized as Boolean.
 ///     <Summary>
 ///    (Set|Get) The NonSerialized as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:028 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The NonSerialized as Boolean.") ]
    member this.NonSerialized()
       with get() = _NonSerialized
       and set(value) = _NonSerialized <- value
#endregion (Set|Get) The NonSerialized as Boolean.

#region |2019/07/06 00h51:780| <01.00.18> <Property> <Columns> |.Serializable()|Boolean|  (Set|Get) The Serializable as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Serializable as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:028 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Serializable as Boolean.") ]
    member this.Serializable()
       with get() = _Serializable
       and set(value) = _Serializable <- value
#endregion (Set|Get) The Serializable as Boolean.

#region |2019/07/06 00h51:790| <01.00.19> <Property> <Columns> |.XmlRoot()|String|  (Set|Get) The XmlRoot as String.
 ///     <Summary>
 ///    (Set|Get) The XmlRoot as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:028 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XmlRoot as String.") ]
    member this.XmlRoot()
       with get() = _XmlRoot
       and set(value) = _XmlRoot <- value
#endregion (Set|Get) The XmlRoot as String.

#region |2019/07/06 00h51:801| <01.00.20> <Property> <Columns> |.XmlIgnore()|Boolean|  (Set|Get) The XmlIgnore as Boolean.
 ///     <Summary>
 ///    (Set|Get) The XmlIgnore as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:029 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XmlIgnore as Boolean.") ]
    member this.XmlIgnore()
       with get() = _XmlIgnore
       and set(value) = _XmlIgnore <- value
#endregion (Set|Get) The XmlIgnore as Boolean.

#region |2019/07/06 00h51:811| <01.00.21> <Property> <Columns> |.XmlInclude()|Boolean|  (Set|Get) The XmlInclude as Boolean.
 ///     <Summary>
 ///    (Set|Get) The XmlInclude as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:029 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XmlInclude as Boolean.") ]
    member this.XmlInclude()
       with get() = _XmlInclude
       and set(value) = _XmlInclude <- value
#endregion (Set|Get) The XmlInclude as Boolean.

#region |2019/07/06 00h51:823| <01.00.22> <Property> <Columns> |.RelatedImageList()|String|  (Set|Get) The RelatedImageList as String.
 ///     <Summary>
 ///    (Set|Get) The RelatedImageList as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:029 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The RelatedImageList as String.") ]
    member this.RelatedImageList()
       with get() = _RelatedImageList
       and set(value) = _RelatedImageList <- value
#endregion (Set|Get) The RelatedImageList as String.

#region |2019/07/06 00h51:834| <01.00.23> <Property> <Columns> |.Print_VB()|String|  (Set|Get) The Print_VB as String.
 ///     <Summary>
 ///    (Set|Get) The Print_VB as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:029 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_VB as String.") ]
    member this.Print_VB()
       with get() = _Print_VB
       and set(value) = _Print_VB <- value
#endregion (Set|Get) The Print_VB as String.

#region |2019/07/06 00h51:846| <01.00.24> <Property> <Columns> |.VB()|String|  (Set|Get) The VB as String.
 ///     <Summary>
 ///    (Set|Get) The VB as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:029 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The VB as String.") ]
    member this.VB()
       with get() = _VB
       and set(value) = _VB <- value
#endregion (Set|Get) The VB as String.

#region |2019/07/06 00h51:860| <01.00.25> <Property> <Columns> |.Print_C()|String|  (Set|Get) The Print_C as String.
 ///     <Summary>
 ///    (Set|Get) The Print_C as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:031 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_C as String.") ]
    member this.Print_C()
       with get() = _Print_C
       and set(value) = _Print_C <- value
#endregion (Set|Get) The Print_C as String.

#region |2019/07/06 00h51:871| <01.00.26> <Property> <Columns> |.C()|String|  (Set|Get) The C as String.
 ///     <Summary>
 ///    (Set|Get) The C as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:031 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The C as String.") ]
    member this.C()
       with get() = _C
       and set(value) = _C <- value
#endregion (Set|Get) The C as String.

#region |2019/07/06 00h51:890| <01.00.27> <Property> <Columns> |.Print_F()|String|  (Set|Get) The Print_F as String.
 ///     <Summary>
 ///    (Set|Get) The Print_F as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:031 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_F as String.") ]
    member this.Print_F()
       with get() = _Print_F
       and set(value) = _Print_F <- value
#endregion (Set|Get) The Print_F as String.

#region |2019/07/06 00h51:901| <01.00.28> <Property> <Columns> |.F()|String|  (Set|Get) The F as String.
 ///     <Summary>
 ///    (Set|Get) The F as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:031 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The F as String.") ]
    member this.F()
       with get() = _F
       and set(value) = _F <- value
#endregion (Set|Get) The F as String.

#region |2019/07/06 00h51:913| <01.00.29> <Property> <Columns> |.Print_Python()|String|  (Set|Get) The Print_Python as String.
 ///     <Summary>
 ///    (Set|Get) The Print_Python as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:031 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_Python as String.") ]
    member this.Print_Python()
       with get() = _Print_Python
       and set(value) = _Print_Python <- value
#endregion (Set|Get) The Print_Python as String.

#region |2019/07/06 00h51:925| <01.00.30> <Property> <Columns> |.Python()|String|  (Set|Get) The Python as String.
 ///     <Summary>
 ///    (Set|Get) The Python as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:032 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Python as String.") ]
    member this.Python()
       with get() = _Python
       and set(value) = _Python <- value
#endregion (Set|Get) The Python as String.

#region |2019/07/06 00h51:936| <01.00.31> <Property> <Columns> |.Print_JavaScript()|String|  (Set|Get) The Print_JavaScript as String.
 ///     <Summary>
 ///    (Set|Get) The Print_JavaScript as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:032 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_JavaScript as String.") ]
    member this.Print_JavaScript()
       with get() = _Print_JavaScript
       and set(value) = _Print_JavaScript <- value
#endregion (Set|Get) The Print_JavaScript as String.

#region |2019/07/06 00h51:948| <01.00.32> <Property> <Columns> |.JavaScript()|String|  (Set|Get) The JavaScript as String.
 ///     <Summary>
 ///    (Set|Get) The JavaScript as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:032 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The JavaScript as String.") ]
    member this.JavaScript()
       with get() = _JavaScript
       and set(value) = _JavaScript <- value
#endregion (Set|Get) The JavaScript as String.

#region |2019/07/06 00h51:960| <01.00.33> <Property> <Columns> |.RegionCategory()|Integer|  (Set|Get) The RegionCategory as Integer.
 ///     <Summary>
 ///    (Set|Get) The RegionCategory as Integer.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:032 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The RegionCategory as Integer.") ]
    member this.RegionCategory()
       with get() = _RegionCategory
       and set(value) = _RegionCategory <- value
#endregion (Set|Get) The RegionCategory as Integer.

#region |2019/07/06 00h51:971| <01.00.34> <Property> <Columns> |.RegionCode()|String|  (Set|Get) The RegionCode as String.
 ///     <Summary>
 ///    (Set|Get) The RegionCode as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:032 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The RegionCode as String.") ]
    member this.RegionCode()
       with get() = _RegionCode
       and set(value) = _RegionCode <- value
#endregion (Set|Get) The RegionCode as String.

#region |2019/07/06 00h51:984| <01.00.35> <Property> <Columns> |.AuthorEmail()|String|  (Set|Get) The AuthorEmail as String.
 ///     <Summary>
 ///    (Set|Get) The AuthorEmail as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:033 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AuthorEmail as String.") ]
    member this.AuthorEmail()
       with get() = _AuthorEmail
       and set(value) = _AuthorEmail <- value
#endregion (Set|Get) The AuthorEmail as String.

#region |2019/07/06 00h51:996| <01.00.36> <Property> <Columns> |.AuthorName()|String|  (Set|Get) The AuthorName as String.
 ///     <Summary>
 ///    (Set|Get) The AuthorName as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:033 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AuthorName as String.") ]
    member this.AuthorName()
       with get() = _AuthorName
       and set(value) = _AuthorName <- value
#endregion (Set|Get) The AuthorName as String.

#region |2019/07/06 00h51:008| <01.00.37> <Property> <Columns> |.AuthorUri()|String|  (Set|Get) The AuthorUri as String.
 ///     <Summary>
 ///    (Set|Get) The AuthorUri as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:033 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AuthorUri as String.") ]
    member this.AuthorUri()
       with get() = _AuthorUri
       and set(value) = _AuthorUri <- value
#endregion (Set|Get) The AuthorUri as String.

#region |2019/07/06 00h51:021| <01.00.38> <Property> <Columns> |.ContributorEmail()|String|  (Set|Get) The ContributorEmail as String.
 ///     <Summary>
 ///    (Set|Get) The ContributorEmail as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:033 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ContributorEmail as String.") ]
    member this.ContributorEmail()
       with get() = _ContributorEmail
       and set(value) = _ContributorEmail <- value
#endregion (Set|Get) The ContributorEmail as String.

#region |2019/07/06 00h51:032| <01.00.39> <Property> <Columns> |.ContributorName()|String|  (Set|Get) The ContributorName as String.
 ///     <Summary>
 ///    (Set|Get) The ContributorName as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:033 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ContributorName as String.") ]
    member this.ContributorName()
       with get() = _ContributorName
       and set(value) = _ContributorName <- value
#endregion (Set|Get) The ContributorName as String.

#region |2019/07/06 00h51:043| <01.00.40> <Property> <Columns> |.ContributorUri()|String|  (Set|Get) The ContributorUri as String.
 ///     <Summary>
 ///    (Set|Get) The ContributorUri as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:034 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ContributorUri as String.") ]
    member this.ContributorUri()
       with get() = _ContributorUri
       and set(value) = _ContributorUri <- value
#endregion (Set|Get) The ContributorUri as String.

#region |2019/07/06 00h51:055| <01.00.41> <Property> <Columns> |.CustomProperty()|String|  (Set|Get) The CustomProperty as String.
 ///     <Summary>
 ///    (Set|Get) The CustomProperty as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:034 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The CustomProperty as String.") ]
    member this.CustomProperty()
       with get() = _CustomProperty
       and set(value) = _CustomProperty <- value
#endregion (Set|Get) The CustomProperty as String.

#region |2019/07/06 00h51:067| <01.00.42> <Property> <Columns> |.Published()|String|  (Set|Get) The Published as String.
 ///     <Summary>
 ///    (Set|Get) The Published as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:034 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Published as String.") ]
    member this.Published()
       with get() = _Published
       and set(value) = _Published <- value
#endregion (Set|Get) The Published as String.

#region |2019/07/06 00h51:081| <01.00.43> <Property> <Columns> |.Rights()|String|  (Set|Get) The Rights as String.
 ///     <Summary>
 ///    (Set|Get) The Rights as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:034 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Rights as String.") ]
    member this.Rights()
       with get() = _Rights
       and set(value) = _Rights <- value
#endregion (Set|Get) The Rights as String.

#region |2019/07/06 00h51:095| <01.00.44> <Property> <Columns> |.Summary()|String|  (Set|Get) The Summary as String.
 ///     <Summary>
 ///    (Set|Get) The Summary as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:035 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Summary as String.") ]
    member this.Summary()
       with get() = _Summary
       and set(value) = _Summary <- value
#endregion (Set|Get) The Summary as String.

#region |2019/07/06 00h51:108| <01.00.45> <Property> <Columns> |.Title()|String|  (Set|Get) The Title as String.
 ///     <Summary>
 ///    (Set|Get) The Title as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:035 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Title as String.") ]
    member this.Title()
       with get() = _Title
       and set(value) = _Title <- value
#endregion (Set|Get) The Title as String.

#region |2019/07/06 00h51:120| <01.00.46> <Property> <Columns> |.Updated()|String|  (Set|Get) The Updated as String.
 ///     <Summary>
 ///    (Set|Get) The Updated as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:035 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Updated as String.") ]
    member this.Updated()
       with get() = _Updated
       and set(value) = _Updated <- value
#endregion (Set|Get) The Updated as String.

#region |2019/07/06 00h51:143| <01.00.47> <Property> <Columns> |.Usage()|String|  (Set|Get) The Usage as String.
 ///     <Summary>
 ///    (Set|Get) The Usage as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:035 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Usage as String.") ]
    member this.Usage()
       with get() = _Usage
       and set(value) = _Usage <- value
#endregion (Set|Get) The Usage as String.

#region |2019/07/06 00h51:156| <01.00.48> <Property> <Columns> |.Remarks()|String|  (Set|Get) The Remarks as String.
 ///     <Summary>
 ///    (Set|Get) The Remarks as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:035 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Remarks as String.") ]
    member this.Remarks()
       with get() = _Remarks
       and set(value) = _Remarks <- value
#endregion (Set|Get) The Remarks as String.

#region |2019/07/06 00h51:171| <01.00.49> <Property> <Columns> |.Example()|String|  (Set|Get) The Example as String.
 ///     <Summary>
 ///    (Set|Get) The Example as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:036 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Example as String.") ]
    member this.Example()
       with get() = _Example
       and set(value) = _Example <- value
#endregion (Set|Get) The Example as String.

#region |2019/07/06 00h51:183| <01.00.50> <Property> <Columns> |.Note()|String|  (Set|Get) The Note as String.
 ///     <Summary>
 ///    (Set|Get) The Note as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:036 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Note as String.") ]
    member this.Note()
       with get() = _Note
       and set(value) = _Note <- value
#endregion (Set|Get) The Note as String.

#region |2019/07/06 00h51:196| <01.00.51> <Property> <Columns> |.CreationDate()|String|  (Set|Get) The CreationDate as String.
 ///     <Summary>
 ///    (Set|Get) The CreationDate as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:036 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The CreationDate as String.") ]
    member this.CreationDate()
       with get() = _CreationDate
       and set(value) = _CreationDate <- value
#endregion (Set|Get) The CreationDate as String.

#region |2019/07/06 00h51:208| <01.00.52> <Property> <Columns> |.See()|String|  (Set|Get) The See as String.
 ///     <Summary>
 ///    (Set|Get) The See as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:037 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The See as String.") ]
    member this.See()
       with get() = _See
       and set(value) = _See <- value
#endregion (Set|Get) The See as String.

#region |2019/07/06 00h51:221| <01.00.53> <Property> <Columns> |.SeeAlso()|String|  (Set|Get) The SeeAlso as String.
 ///     <Summary>
 ///    (Set|Get) The SeeAlso as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:037 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The SeeAlso as String.") ]
    member this.SeeAlso()
       with get() = _SeeAlso
       and set(value) = _SeeAlso <- value
#endregion (Set|Get) The SeeAlso as String.

#region |2019/07/06 00h51:235| <01.00.54> <Property> <Columns> |.Rules()|String|  (Set|Get) The Rules as String.
 ///     <Summary>
 ///    (Set|Get) The Rules as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:037 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Rules as String.") ]
    member this.Rules()
       with get() = _Rules
       and set(value) = _Rules <- value
#endregion (Set|Get) The Rules as String.

#region |2019/07/06 00h51:249| <01.00.55> <Property> <Columns> |.Syntax()|String|  (Set|Get) The Syntax as String.
 ///     <Summary>
 ///    (Set|Get) The Syntax as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:037 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Syntax as String.") ]
    member this.Syntax()
       with get() = _Syntax
       and set(value) = _Syntax <- value
#endregion (Set|Get) The Syntax as String.

#end region 
#region <2> [Enumeration]{1}
#region |2019/07/06 00h51:264| <02.00.00> <Property> <> |.Schema()|Enumeration{55}|"' (Set|Get) The enumeration of Schema.
     ///     <Summary>
 ///    (Set|Get) The enumeration of Schema.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:038 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The enumeration of Schema.") ]
    Type Schema = 
/// <summary>(Set|Get) The ID as Integer.</summary>
|   [ID] = 0
/// <summary>(Set|Get) The Name as String.</summary>
|   [Name] = 1
/// <summary>(Set|Get) The ImageIndex as Integer.</summary>
|   [ImageIndex] = 2
/// <summary>(Set|Get) The Text as String.</summary>
|   [Text] = 3
/// <summary>(Set|Get) The ToolTip as String.</summary>
|   [ToolTip] = 4
/// <summary>(Set|Get) The Enable as Boolean.</summary>
|   [Enable] = 5
/// <summary>(Set|Get) The Status as String.</summary>
|   [Status] = 6
/// <summary>(Set|Get) The Statement as String.</summary>
|   [Statement] = 7
/// <summary>(Set|Get) The XMLFile as String.</summary>
|   [XMLFile] = 8
/// <summary>(Set|Get) The Attributes as String.</summary>
|   [Attributes] = 9
/// <summary>(Set|Get) The Browsable as Boolean.</summary>
|   [Browsable] = 10
/// <summary>(Set|Get) The Category as String.</summary>
|   [Category] = 11
/// <summary>(Set|Get) The Description as String.</summary>
|   [Description] = 12
/// <summary>(Set|Get) The DefaultValue as String.</summary>
|   [DefaultValue] = 13
/// <summary>(Set|Get) The Editor as String.</summary>
|   [Editor] = 14
/// <summary>(Set|Get) The DllImport as String.</summary>
|   [DllImport] = 15
/// <summary>(Set|Get) The Deserializable as Boolean.</summary>
|   [Deserializable] = 16
/// <summary>(Set|Get) The NonSerialized as Boolean.</summary>
|   [NonSerialized] = 17
/// <summary>(Set|Get) The Serializable as Boolean.</summary>
|   [Serializable] = 18
/// <summary>(Set|Get) The XmlRoot as String.</summary>
|   [XmlRoot] = 19
/// <summary>(Set|Get) The XmlIgnore as Boolean.</summary>
|   [XmlIgnore] = 20
/// <summary>(Set|Get) The XmlInclude as Boolean.</summary>
|   [XmlInclude] = 21
/// <summary>(Set|Get) The RelatedImageList as String.</summary>
|   [RelatedImageList] = 22
/// <summary>(Set|Get) The Print_VB as String.</summary>
|   [Print_VB] = 23
/// <summary>(Set|Get) The VB as String.</summary>
|   [VB] = 24
/// <summary>(Set|Get) The Print_C as String.</summary>
|   [Print_C] = 25
/// <summary>(Set|Get) The C as String.</summary>
|   [C] = 26
/// <summary>(Set|Get) The Print_F as String.</summary>
|   [Print_F] = 27
/// <summary>(Set|Get) The F as String.</summary>
|   [F] = 28
/// <summary>(Set|Get) The Print_Python as String.</summary>
|   [Print_Python] = 29
/// <summary>(Set|Get) The Python as String.</summary>
|   [Python] = 30
/// <summary>(Set|Get) The Print_JavaScript as String.</summary>
|   [Print_JavaScript] = 31
/// <summary>(Set|Get) The JavaScript as String.</summary>
|   [JavaScript] = 32
/// <summary>(Set|Get) The RegionCategory as Integer.</summary>
|   [RegionCategory] = 33
/// <summary>(Set|Get) The RegionCode as String.</summary>
|   [RegionCode] = 34
/// <summary>(Set|Get) The AuthorEmail as String.</summary>
|   [AuthorEmail] = 35
/// <summary>(Set|Get) The AuthorName as String.</summary>
|   [AuthorName] = 36
/// <summary>(Set|Get) The AuthorUri as String.</summary>
|   [AuthorUri] = 37
/// <summary>(Set|Get) The ContributorEmail as String.</summary>
|   [ContributorEmail] = 38
/// <summary>(Set|Get) The ContributorName as String.</summary>
|   [ContributorName] = 39
/// <summary>(Set|Get) The ContributorUri as String.</summary>
|   [ContributorUri] = 40
/// <summary>(Set|Get) The CustomProperty as String.</summary>
|   [CustomProperty] = 41
/// <summary>(Set|Get) The Published as String.</summary>
|   [Published] = 42
/// <summary>(Set|Get) The Rights as String.</summary>
|   [Rights] = 43
/// <summary>(Set|Get) The Summary as String.</summary>
|   [Summary] = 44
/// <summary>(Set|Get) The Title as String.</summary>
|   [Title] = 45
/// <summary>(Set|Get) The Updated as String.</summary>
|   [Updated] = 46
/// <summary>(Set|Get) The Usage as String.</summary>
|   [Usage] = 47
/// <summary>(Set|Get) The Remarks as String.</summary>
|   [Remarks] = 48
/// <summary>(Set|Get) The Example as String.</summary>
|   [Example] = 49
/// <summary>(Set|Get) The Note as String.</summary>
|   [Note] = 50
/// <summary>(Set|Get) The CreationDate as String.</summary>
|   [CreationDate] = 51
/// <summary>(Set|Get) The See as String.</summary>
|   [See] = 52
/// <summary>(Set|Get) The SeeAlso as String.</summary>
|   [SeeAlso] = 53
/// <summary>(Set|Get) The Rules as String.</summary>
|   [Rules] = 54
/// <summary>(Set|Get) The Syntax as String.</summary>
|   [Syntax] = 55
#endregion (Set|Get) The enumeration of Schema.

#end region 
#region <4> [Sub]{5}
#region |2019/07/06 00h51:291| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
     ///     <Summary>
 ///    (Set|Get) This will reinitialize the class element.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:040 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will reinitialize the class element.") ]
    Let Clear = 
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
#endregion (Set|Get) This will reinitialize the class element.

#region |2019/07/06 00h51:304| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
     ///     <Summary>
 ///    (Set|Get) This will reinitialize the variables of this class.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:041 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will reinitialize the variables of this class.") ]
    Let Reset = 
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

#endregion (Set|Get) This will reinitialize the variables of this class.

#region |2019/07/06 00h51:319| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
     ///     <Summary>
 ///    (Set|Get) This will add a new row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:041 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will add a new row in the table.") ]
    Let Add = 
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

#endregion (Set|Get) This will add a new row in the table.

#region |2019/07/06 00h51:333| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
     ///     <Summary>
 ///    (Set|Get) This will update a row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:041 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will update a row in the table.") ]
    Let Save = 
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

#endregion (Set|Get) This will update a row in the table.

#region |2019/07/06 00h51:349| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
     ///     <Summary>
 ///    (Set|Get) This will Delete a row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:041 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will Delete a row in the table.") ]
    Let Delete = 
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

#endregion (Set|Get) This will Delete a row in the table.

#end region 
#region <5> [Function]{7}
#region |2019/07/06 00h51:363| <05.00.00> <Sub> <> |.Open()|Sub}|"' (Set|Get) This will initialise the connection and import the data.
     ///     <Summary>
 ///    (Set|Get) This will initialise the connection and import the data.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:042 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will initialise the connection and import the data.") ]
    Let Open = 
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

#endregion (Set|Get) This will initialise the connection and import the data.

#region |2019/07/06 00h51:377| <05.00.01> <Sub> <> |.Close()|Sub}|"' (Set|Get) This willClosing the connection
     ///     <Summary>
 ///    (Set|Get) This willClosing the connection
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:042 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This willClosing the connection") ]
    Let Close = 
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

#endregion (Set|Get) This willClosing the connection

#region |2019/07/06 00h51:394| <05.00.02> <Sub> <> |.List()|Sub}|"' (Set|Get) Return the entire table listed
     ///     <Summary>
 ///    (Set|Get) Return the entire table listed
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:042 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Return the entire table listed") ]
    Let List = 
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
#endregion (Set|Get) Return the entire table listed

#region |2019/07/06 00h51:414| <05.00.03> <Sub> <> |.SearchByName()|Sub}|"' (Set|Get) Search for each property that match the Search String.
     ///     <Summary>
 ///    (Set|Get) Search for each property that match the Search String.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:042 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Search for each property that match the Search String.") ]
    Let SearchByName = 
    Dim Result As New List(Of Statement)
 Dim C As New Statement
 For Each Element As Statement In C.List
 If Element.Name.Tolower() = Search.Tolower() Or Element.Text.Tolower() = Search.Tolower()  Or Element.ToolTip.Tolower() = Search.Tolower()  Or Element.Status.Tolower() = Search.Tolower()  Or Element.Statement.Tolower() = Search.Tolower()  Or Element.XMLFile.Tolower() = Search.Tolower()  Or Element.Attributes.Tolower() = Search.Tolower()  Or Element.Category.Tolower() = Search.Tolower()  Or Element.Description.Tolower() = Search.Tolower()  Or Element.DefaultValue.Tolower() = Search.Tolower()  Or Element.Editor.Tolower() = Search.Tolower()  Or Element.DllImport.Tolower() = Search.Tolower()  Or Element.XmlRoot.Tolower() = Search.Tolower()  Or Element.RelatedImageList.Tolower() = Search.Tolower()  Or Element.Print_VB.Tolower() = Search.Tolower()  Or Element.VB.Tolower() = Search.Tolower()  Or Element.Print_C.Tolower() = Search.Tolower()  Or Element.C.Tolower() = Search.Tolower()  Or Element.Print_F.Tolower() = Search.Tolower()  Or Element.F.Tolower() = Search.Tolower()  Or Element.Print_Python.Tolower() = Search.Tolower()  Or Element.Python.Tolower() = Search.Tolower()  Or Element.Print_JavaScript.Tolower() = Search.Tolower()  Or Element.JavaScript.Tolower() = Search.Tolower()  Or Element.RegionCode.Tolower() = Search.Tolower()  Or Element.AuthorEmail.Tolower() = Search.Tolower()  Or Element.AuthorName.Tolower() = Search.Tolower()  Or Element.AuthorUri.Tolower() = Search.Tolower()  Or Element.ContributorEmail.Tolower() = Search.Tolower()  Or Element.ContributorName.Tolower() = Search.Tolower()  Or Element.ContributorUri.Tolower() = Search.Tolower()  Or Element.CustomProperty.Tolower() = Search.Tolower()  Or Element.Published.Tolower() = Search.Tolower()  Or Element.Rights.Tolower() = Search.Tolower()  Or Element.Summary.Tolower() = Search.Tolower()  Or Element.Title.Tolower() = Search.Tolower()  Or Element.Updated.Tolower() = Search.Tolower()  Or Element.Usage.Tolower() = Search.Tolower()  Or Element.Remarks.Tolower() = Search.Tolower()  Or Element.Example.Tolower() = Search.Tolower()  Or Element.Note.Tolower() = Search.Tolower()  Or Element.CreationDate.Tolower() = Search.Tolower()  Or Element.See.Tolower() = Search.Tolower()  Or Element.SeeAlso.Tolower() = Search.Tolower()  Or Element.Rules.Tolower() = Search.Tolower()  Or Element.Syntax.Tolower() = Search.Tolower() Then
      Result.Add(Element)
 End If
 Next
 Return Result
#endregion (Set|Get) Search for each property that match the Search String.

#region |2019/07/06 00h51:429| <05.00.04> <Sub> <> |.SearchByID()|Sub}|"' (Set|Get) Search for each property that match the Search Id.
     ///     <Summary>
 ///    (Set|Get) Search for each property that match the Search Id.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:042 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Search for each property that match the Search Id.") ]
    Let SearchByID = 
    Dim Result As New List(Of Statement)
 Dim C As New Statement
 For Each Element As Statement In C.List
 If Val(Element.ID) = Search Or Val(Element.ImageIndex) = Search  Or Val(Element.RegionCategory) = Search Then
      Result.Add(Element)
 End If
 Next
 Return Result
#endregion (Set|Get) Search for each property that match the Search Id.

#region |2019/07/06 00h51:446| <05.00.05> <Sub> <> |.ToString()|Sub}|"' (Set|Get) The function ToString.
     ///     <Summary>
 ///    (Set|Get) The function ToString.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:043 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The function ToString.") ]
    Let ToString = 
        Return Me.ID
#endregion (Set|Get) The function ToString.

#region |2019/07/06 00h51:465| <05.00.06> <Sub> <> |.CheckConnection()|Sub}|"' (Set|Get) Evaluate the connection to the DataBase
     ///     <Summary>
 ///    (Set|Get) Evaluate the connection to the DataBase
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:043 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Evaluate the connection to the DataBase") ]
    Let CheckConnection = 
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

#endregion (Set|Get) Evaluate the connection to the DataBase

#end region 
#region <6> [Runtime]{12}
#region |2019/07/06 00h51:482| <15.00.00> <Runtime> <> |.Table()|Runtime|  (Set|Get) The Table.
 ///     <Summary>
 ///    (Set|Get) The Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:043 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Table.") ]
   Public Table Table;
#endregion (Set|Get) The Table.

#region |2019/07/06 00h51:496| <15.00.01> <Runtime> <> |.Line()|Runtime|  (Set|Get) The Connection String To the Table.
 ///     <Summary>
 ///    (Set|Get) The Connection String To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:043 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Connection String To the Table.") ]
   Public String Line;
#endregion (Set|Get) The Connection String To the Table.

#region |2019/07/06 00h51:510| <15.00.02> <Runtime> <> |.FilePath()|Runtime|  (Set|Get) The FilePath To the Table.
 ///     <Summary>
 ///    (Set|Get) The FilePath To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:043 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The FilePath To the Table.") ]
   Public String FilePath;
#endregion (Set|Get) The FilePath To the Table.

#region |2019/07/06 00h51:524| <15.00.03> <Runtime> <> |.Password()|Runtime|  (Set|Get) The Password To the Table.
 ///     <Summary>
 ///    (Set|Get) The Password To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:043 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Password To the Table.") ]
   Public String Password;
#endregion (Set|Get) The Password To the Table.

#region |2019/07/06 00h51:539| <15.00.04> <Runtime> <> |.UseSQL()|Runtime|  (Set|Get) Determines if the Database Connection is of type SQL.
 ///     <Summary>
 ///    (Set|Get) Determines if the Database Connection is of type SQL.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:044 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Determines if the Database Connection is of type SQL.") ]
   Public Boolean UseSQL;
#endregion (Set|Get) Determines if the Database Connection is of type SQL.

#region |2019/07/06 00h51:553| <15.00.05> <Runtime> <> |.TableName()|Runtime|  (Set|Get) The name of the Table.
 ///     <Summary>
 ///    (Set|Get) The name of the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:044 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The name of the Table.") ]
   Public String TableName;
#endregion (Set|Get) The name of the Table.

#region |2019/07/06 00h51:567| <15.00.06> <Runtime> <> |.Con()|Runtime|  (Set|Get) The Con To the Table.
 ///     <Summary>
 ///    (Set|Get) The Con To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:044 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Con To the Table.") ]
   Public OleDb.OleDbConnection Con;
#endregion (Set|Get) The Con To the Table.

#region |2019/07/06 00h51:583| <15.00.07> <Runtime> <> |.Cmd()|Runtime|  (Set|Get) The Cmd To the Table.
 ///     <Summary>
 ///    (Set|Get) The Cmd To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:044 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Cmd To the Table.") ]
   Public OleDb.OleDbCommand Cmd;
#endregion (Set|Get) The Cmd To the Table.

#region |2019/07/06 00h51:598| <15.00.08> <Runtime> <> |.DataReader()|Runtime|  (Set|Get) The DataReader To the Table.
 ///     <Summary>
 ///    (Set|Get) The DataReader To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:044 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The DataReader To the Table.") ]
   Public OleDb.OleDbDataReader DataReader;
#endregion (Set|Get) The DataReader To the Table.

#region |2019/07/06 00h51:612| <15.00.09> <Runtime> <> |.DataAdapter()|Runtime|  (Set|Get) The DataAdapter To the Table.
 ///     <Summary>
 ///    (Set|Get) The DataAdapter To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:045 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The DataAdapter To the Table.") ]
   Public OleDb.OleDbDataAdapter DataAdapter;
#endregion (Set|Get) The DataAdapter To the Table.

#region |2019/07/06 00h51:627| <15.00.10> <Runtime> <> |.Connector()|Runtime|  (Set|Get) The Connector To the Table.
 ///     <Summary>
 ///    (Set|Get) The Connector To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:045 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Connector To the Table.") ]
   Public LineInfo Connector;
#endregion (Set|Get) The Connector To the Table.

#region |2019/07/06 00h51:641| <15.00.11> <Runtime> <> |.Log()|Runtime|  (Set|Get) The Log To the Table.
 ///     <Summary>
 ///    (Set|Get) The Log To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:045 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Log To the Table.") ]
   Public String Log;
#endregion (Set|Get) The Log To the Table.

#end region 
#region <7> [Loader]{2}
#region |2019/07/06 00h51:655| <06.00.00> <Sub> <> |.Empty()|Sub}|"' (Set|Get) The sub Empty.
     ///     <Summary>
 ///    (Set|Get) The sub Empty.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:045 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The sub Empty.") ]
    Let Empty = 
    Reset
#endregion (Set|Get) The sub Empty.

#region |2019/07/06 00h51:658| <06.00.01> <Sub> <> |.Filled()|Sub}|"' (Set|Get) The sub Filled.
     ///     <Summary>
 ///    (Set|Get) The sub Filled.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:046 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The sub Filled.") ]
    Let Filled = 
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

#endregion (Set|Get) The sub Filled.

#end region 
}

 ///     <Summary>
 ///    Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Structure
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
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:077 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
public  class Structure{
#region <1> [Property]{62}
#region |2019/07/06 00h51:878| <01.00.00> <Property> <Columns> |.ID()|Integer|  (Set|Get) The ID as Integer.
 ///     <Summary>
 ///    (Set|Get) The ID as Integer.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:077 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ID as Integer.") ]
    member this.ID()
       with get() = _ID
       and set(value) = _ID <- value
#endregion (Set|Get) The ID as Integer.

#region |2019/07/06 00h51:889| <01.00.01> <Property> <Columns> |.Name()|String|  (Set|Get) The Name as String.
 ///     <Summary>
 ///    (Set|Get) The Name as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:077 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Name as String.") ]
    member this.Name()
       with get() = _Name
       and set(value) = _Name <- value
#endregion (Set|Get) The Name as String.

#region |2019/07/06 00h51:900| <01.00.02> <Property> <Columns> |.ImageIndex()|Integer|  (Set|Get) The ImageIndex as Integer.
 ///     <Summary>
 ///    (Set|Get) The ImageIndex as Integer.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:077 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ImageIndex as Integer.") ]
    member this.ImageIndex()
       with get() = _ImageIndex
       and set(value) = _ImageIndex <- value
#endregion (Set|Get) The ImageIndex as Integer.

#region |2019/07/06 00h51:911| <01.00.03> <Property> <Columns> |.Text()|String|  (Set|Get) The Text as String.
 ///     <Summary>
 ///    (Set|Get) The Text as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:078 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Text as String.") ]
    member this.Text()
       with get() = _Text
       and set(value) = _Text <- value
#endregion (Set|Get) The Text as String.

#region |2019/07/06 00h51:922| <01.00.04> <Property> <Columns> |.ToolTip()|String|  (Set|Get) The ToolTip as String.
 ///     <Summary>
 ///    (Set|Get) The ToolTip as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:078 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ToolTip as String.") ]
    member this.ToolTip()
       with get() = _ToolTip
       and set(value) = _ToolTip <- value
#endregion (Set|Get) The ToolTip as String.

#region |2019/07/06 00h51:932| <01.00.05> <Property> <Columns> |.Enable()|Boolean|  (Set|Get) The Enable as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Enable as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:078 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Enable as Boolean.") ]
    member this.Enable()
       with get() = _Enable
       and set(value) = _Enable <- value
#endregion (Set|Get) The Enable as Boolean.

#region |2019/07/06 00h51:943| <01.00.06> <Property> <Columns> |.Status()|String|  (Set|Get) The Status as String.
 ///     <Summary>
 ///    (Set|Get) The Status as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:078 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Status as String.") ]
    member this.Status()
       with get() = _Status
       and set(value) = _Status <- value
#endregion (Set|Get) The Status as String.

#region |2019/07/06 00h51:959| <01.00.07> <Property> <Columns> |.Statement()|String|  (Set|Get) The Statement as String.
 ///     <Summary>
 ///    (Set|Get) The Statement as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:078 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Statement as String.") ]
    member this.Statement()
       with get() = _Statement
       and set(value) = _Statement <- value
#endregion (Set|Get) The Statement as String.

#region |2019/07/06 00h51:970| <01.00.08> <Property> <Columns> |.XMLFile()|String|  (Set|Get) The XMLFile as String.
 ///     <Summary>
 ///    (Set|Get) The XMLFile as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:079 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XMLFile as String.") ]
    member this.XMLFile()
       with get() = _XMLFile
       and set(value) = _XMLFile <- value
#endregion (Set|Get) The XMLFile as String.

#region |2019/07/06 00h51:980| <01.00.09> <Property> <Columns> |.Attributes()|String|  (Set|Get) The Attributes as String.
 ///     <Summary>
 ///    (Set|Get) The Attributes as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:079 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Attributes as String.") ]
    member this.Attributes()
       with get() = _Attributes
       and set(value) = _Attributes <- value
#endregion (Set|Get) The Attributes as String.

#region |2019/07/06 00h51:992| <01.00.10> <Property> <Columns> |.Browsable()|Boolean|  (Set|Get) The Browsable as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Browsable as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:079 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Browsable as Boolean.") ]
    member this.Browsable()
       with get() = _Browsable
       and set(value) = _Browsable <- value
#endregion (Set|Get) The Browsable as Boolean.

#region |2019/07/06 00h51:002| <01.00.11> <Property> <Columns> |.Category()|String|  (Set|Get) The Category as String.
 ///     <Summary>
 ///    (Set|Get) The Category as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:079 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Category as String.") ]
    member this.Category()
       with get() = _Category
       and set(value) = _Category <- value
#endregion (Set|Get) The Category as String.

#region |2019/07/06 00h51:013| <01.00.12> <Property> <Columns> |.Description()|String|  (Set|Get) The Description as String.
 ///     <Summary>
 ///    (Set|Get) The Description as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:079 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Description as String.") ]
    member this.Description()
       with get() = _Description
       and set(value) = _Description <- value
#endregion (Set|Get) The Description as String.

#region |2019/07/06 00h51:024| <01.00.13> <Property> <Columns> |.DefaultValue()|String|  (Set|Get) The DefaultValue as String.
 ///     <Summary>
 ///    (Set|Get) The DefaultValue as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:080 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The DefaultValue as String.") ]
    member this.DefaultValue()
       with get() = _DefaultValue
       and set(value) = _DefaultValue <- value
#endregion (Set|Get) The DefaultValue as String.

#region |2019/07/06 00h51:035| <01.00.14> <Property> <Columns> |.Editor()|String|  (Set|Get) The Editor as String.
 ///     <Summary>
 ///    (Set|Get) The Editor as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:081 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Editor as String.") ]
    member this.Editor()
       with get() = _Editor
       and set(value) = _Editor <- value
#endregion (Set|Get) The Editor as String.

#region |2019/07/06 00h51:047| <01.00.15> <Property> <Columns> |.DllImport()|String|  (Set|Get) The DllImport as String.
 ///     <Summary>
 ///    (Set|Get) The DllImport as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:081 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The DllImport as String.") ]
    member this.DllImport()
       with get() = _DllImport
       and set(value) = _DllImport <- value
#endregion (Set|Get) The DllImport as String.

#region |2019/07/06 00h51:058| <01.00.16> <Property> <Columns> |.Deserializable()|Boolean|  (Set|Get) The Deserializable as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Deserializable as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:081 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Deserializable as Boolean.") ]
    member this.Deserializable()
       with get() = _Deserializable
       and set(value) = _Deserializable <- value
#endregion (Set|Get) The Deserializable as Boolean.

#region |2019/07/06 00h51:069| <01.00.17> <Property> <Columns> |.NonSerialized()|Boolean|  (Set|Get) The NonSerialized as Boolean.
 ///     <Summary>
 ///    (Set|Get) The NonSerialized as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:081 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The NonSerialized as Boolean.") ]
    member this.NonSerialized()
       with get() = _NonSerialized
       and set(value) = _NonSerialized <- value
#endregion (Set|Get) The NonSerialized as Boolean.

#region |2019/07/06 00h51:080| <01.00.18> <Property> <Columns> |.Serializable()|Boolean|  (Set|Get) The Serializable as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Serializable as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:082 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Serializable as Boolean.") ]
    member this.Serializable()
       with get() = _Serializable
       and set(value) = _Serializable <- value
#endregion (Set|Get) The Serializable as Boolean.

#region |2019/07/06 00h51:091| <01.00.19> <Property> <Columns> |.XmlRoot()|String|  (Set|Get) The XmlRoot as String.
 ///     <Summary>
 ///    (Set|Get) The XmlRoot as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:082 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XmlRoot as String.") ]
    member this.XmlRoot()
       with get() = _XmlRoot
       and set(value) = _XmlRoot <- value
#endregion (Set|Get) The XmlRoot as String.

#region |2019/07/06 00h51:101| <01.00.20> <Property> <Columns> |.XmlIgnore()|Boolean|  (Set|Get) The XmlIgnore as Boolean.
 ///     <Summary>
 ///    (Set|Get) The XmlIgnore as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:082 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XmlIgnore as Boolean.") ]
    member this.XmlIgnore()
       with get() = _XmlIgnore
       and set(value) = _XmlIgnore <- value
#endregion (Set|Get) The XmlIgnore as Boolean.

#region |2019/07/06 00h51:113| <01.00.21> <Property> <Columns> |.XmlInclude()|Boolean|  (Set|Get) The XmlInclude as Boolean.
 ///     <Summary>
 ///    (Set|Get) The XmlInclude as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:082 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XmlInclude as Boolean.") ]
    member this.XmlInclude()
       with get() = _XmlInclude
       and set(value) = _XmlInclude <- value
#endregion (Set|Get) The XmlInclude as Boolean.

#region |2019/07/06 00h51:124| <01.00.22> <Property> <Columns> |.RelatedImageList()|String|  (Set|Get) The RelatedImageList as String.
 ///     <Summary>
 ///    (Set|Get) The RelatedImageList as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:082 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The RelatedImageList as String.") ]
    member this.RelatedImageList()
       with get() = _RelatedImageList
       and set(value) = _RelatedImageList <- value
#endregion (Set|Get) The RelatedImageList as String.

#region |2019/07/06 00h51:135| <01.00.23> <Property> <Columns> |.Print_VB()|String|  (Set|Get) The Print_VB as String.
 ///     <Summary>
 ///    (Set|Get) The Print_VB as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:083 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_VB as String.") ]
    member this.Print_VB()
       with get() = _Print_VB
       and set(value) = _Print_VB <- value
#endregion (Set|Get) The Print_VB as String.

#region |2019/07/06 00h51:147| <01.00.24> <Property> <Columns> |.VB()|String|  (Set|Get) The VB as String.
 ///     <Summary>
 ///    (Set|Get) The VB as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:083 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The VB as String.") ]
    member this.VB()
       with get() = _VB
       and set(value) = _VB <- value
#endregion (Set|Get) The VB as String.

#region |2019/07/06 00h51:158| <01.00.25> <Property> <Columns> |.Print_C()|String|  (Set|Get) The Print_C as String.
 ///     <Summary>
 ///    (Set|Get) The Print_C as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:083 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_C as String.") ]
    member this.Print_C()
       with get() = _Print_C
       and set(value) = _Print_C <- value
#endregion (Set|Get) The Print_C as String.

#region |2019/07/06 00h51:173| <01.00.26> <Property> <Columns> |.C()|String|  (Set|Get) The C as String.
 ///     <Summary>
 ///    (Set|Get) The C as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:083 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The C as String.") ]
    member this.C()
       with get() = _C
       and set(value) = _C <- value
#endregion (Set|Get) The C as String.

#region |2019/07/06 00h51:184| <01.00.27> <Property> <Columns> |.Print_F()|String|  (Set|Get) The Print_F as String.
 ///     <Summary>
 ///    (Set|Get) The Print_F as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:083 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_F as String.") ]
    member this.Print_F()
       with get() = _Print_F
       and set(value) = _Print_F <- value
#endregion (Set|Get) The Print_F as String.

#region |2019/07/06 00h51:202| <01.00.28> <Property> <Columns> |.F()|String|  (Set|Get) The F as String.
 ///     <Summary>
 ///    (Set|Get) The F as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:084 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The F as String.") ]
    member this.F()
       with get() = _F
       and set(value) = _F <- value
#endregion (Set|Get) The F as String.

#region |2019/07/06 00h51:214| <01.00.29> <Property> <Columns> |.Print_Python()|String|  (Set|Get) The Print_Python as String.
 ///     <Summary>
 ///    (Set|Get) The Print_Python as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:084 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_Python as String.") ]
    member this.Print_Python()
       with get() = _Print_Python
       and set(value) = _Print_Python <- value
#endregion (Set|Get) The Print_Python as String.

#region |2019/07/06 00h51:227| <01.00.30> <Property> <Columns> |.Python()|String|  (Set|Get) The Python as String.
 ///     <Summary>
 ///    (Set|Get) The Python as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:084 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Python as String.") ]
    member this.Python()
       with get() = _Python
       and set(value) = _Python <- value
#endregion (Set|Get) The Python as String.

#region |2019/07/06 00h51:239| <01.00.31> <Property> <Columns> |.Print_JavaScript()|String|  (Set|Get) The Print_JavaScript as String.
 ///     <Summary>
 ///    (Set|Get) The Print_JavaScript as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:084 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_JavaScript as String.") ]
    member this.Print_JavaScript()
       with get() = _Print_JavaScript
       and set(value) = _Print_JavaScript <- value
#endregion (Set|Get) The Print_JavaScript as String.

#region |2019/07/06 00h51:251| <01.00.32> <Property> <Columns> |.JavaScript()|String|  (Set|Get) The JavaScript as String.
 ///     <Summary>
 ///    (Set|Get) The JavaScript as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:084 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The JavaScript as String.") ]
    member this.JavaScript()
       with get() = _JavaScript
       and set(value) = _JavaScript <- value
#endregion (Set|Get) The JavaScript as String.

#region |2019/07/06 00h51:264| <01.00.33> <Property> <Columns> |.RegionCategory()|Integer|  (Set|Get) The RegionCategory as Integer.
 ///     <Summary>
 ///    (Set|Get) The RegionCategory as Integer.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:085 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The RegionCategory as Integer.") ]
    member this.RegionCategory()
       with get() = _RegionCategory
       and set(value) = _RegionCategory <- value
#endregion (Set|Get) The RegionCategory as Integer.

#region |2019/07/06 00h51:276| <01.00.34> <Property> <Columns> |.RegionCode()|String|  (Set|Get) The RegionCode as String.
 ///     <Summary>
 ///    (Set|Get) The RegionCode as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:085 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The RegionCode as String.") ]
    member this.RegionCode()
       with get() = _RegionCode
       and set(value) = _RegionCode <- value
#endregion (Set|Get) The RegionCode as String.

#region |2019/07/06 00h51:289| <01.00.35> <Property> <Columns> |.AuthorEmail()|String|  (Set|Get) The AuthorEmail as String.
 ///     <Summary>
 ///    (Set|Get) The AuthorEmail as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:085 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AuthorEmail as String.") ]
    member this.AuthorEmail()
       with get() = _AuthorEmail
       and set(value) = _AuthorEmail <- value
#endregion (Set|Get) The AuthorEmail as String.

#region |2019/07/06 00h51:300| <01.00.36> <Property> <Columns> |.AuthorName()|String|  (Set|Get) The AuthorName as String.
 ///     <Summary>
 ///    (Set|Get) The AuthorName as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:085 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AuthorName as String.") ]
    member this.AuthorName()
       with get() = _AuthorName
       and set(value) = _AuthorName <- value
#endregion (Set|Get) The AuthorName as String.

#region |2019/07/06 00h51:311| <01.00.37> <Property> <Columns> |.AuthorUri()|String|  (Set|Get) The AuthorUri as String.
 ///     <Summary>
 ///    (Set|Get) The AuthorUri as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:085 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AuthorUri as String.") ]
    member this.AuthorUri()
       with get() = _AuthorUri
       and set(value) = _AuthorUri <- value
#endregion (Set|Get) The AuthorUri as String.

#region |2019/07/06 00h51:322| <01.00.38> <Property> <Columns> |.ContributorEmail()|String|  (Set|Get) The ContributorEmail as String.
 ///     <Summary>
 ///    (Set|Get) The ContributorEmail as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:086 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ContributorEmail as String.") ]
    member this.ContributorEmail()
       with get() = _ContributorEmail
       and set(value) = _ContributorEmail <- value
#endregion (Set|Get) The ContributorEmail as String.

#region |2019/07/06 00h51:335| <01.00.39> <Property> <Columns> |.ContributorName()|String|  (Set|Get) The ContributorName as String.
 ///     <Summary>
 ///    (Set|Get) The ContributorName as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:086 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ContributorName as String.") ]
    member this.ContributorName()
       with get() = _ContributorName
       and set(value) = _ContributorName <- value
#endregion (Set|Get) The ContributorName as String.

#region |2019/07/06 00h51:347| <01.00.40> <Property> <Columns> |.ContributorUri()|String|  (Set|Get) The ContributorUri as String.
 ///     <Summary>
 ///    (Set|Get) The ContributorUri as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:086 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ContributorUri as String.") ]
    member this.ContributorUri()
       with get() = _ContributorUri
       and set(value) = _ContributorUri <- value
#endregion (Set|Get) The ContributorUri as String.

#region |2019/07/06 00h51:361| <01.00.41> <Property> <Columns> |.CustomProperty()|String|  (Set|Get) The CustomProperty as String.
 ///     <Summary>
 ///    (Set|Get) The CustomProperty as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:086 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The CustomProperty as String.") ]
    member this.CustomProperty()
       with get() = _CustomProperty
       and set(value) = _CustomProperty <- value
#endregion (Set|Get) The CustomProperty as String.

#region |2019/07/06 00h51:374| <01.00.42> <Property> <Columns> |.Published()|String|  (Set|Get) The Published as String.
 ///     <Summary>
 ///    (Set|Get) The Published as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:086 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Published as String.") ]
    member this.Published()
       with get() = _Published
       and set(value) = _Published <- value
#endregion (Set|Get) The Published as String.

#region |2019/07/06 00h51:386| <01.00.43> <Property> <Columns> |.Rights()|String|  (Set|Get) The Rights as String.
 ///     <Summary>
 ///    (Set|Get) The Rights as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:087 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Rights as String.") ]
    member this.Rights()
       with get() = _Rights
       and set(value) = _Rights <- value
#endregion (Set|Get) The Rights as String.

#region |2019/07/06 00h51:399| <01.00.44> <Property> <Columns> |.Summary()|String|  (Set|Get) The Summary as String.
 ///     <Summary>
 ///    (Set|Get) The Summary as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:087 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Summary as String.") ]
    member this.Summary()
       with get() = _Summary
       and set(value) = _Summary <- value
#endregion (Set|Get) The Summary as String.

#region |2019/07/06 00h51:412| <01.00.45> <Property> <Columns> |.Title()|String|  (Set|Get) The Title as String.
 ///     <Summary>
 ///    (Set|Get) The Title as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:087 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Title as String.") ]
    member this.Title()
       with get() = _Title
       and set(value) = _Title <- value
#endregion (Set|Get) The Title as String.

#region |2019/07/06 00h51:424| <01.00.46> <Property> <Columns> |.Updated()|String|  (Set|Get) The Updated as String.
 ///     <Summary>
 ///    (Set|Get) The Updated as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:087 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Updated as String.") ]
    member this.Updated()
       with get() = _Updated
       and set(value) = _Updated <- value
#endregion (Set|Get) The Updated as String.

#region |2019/07/06 00h51:436| <01.00.47> <Property> <Columns> |.Usage()|String|  (Set|Get) The Usage as String.
 ///     <Summary>
 ///    (Set|Get) The Usage as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:088 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Usage as String.") ]
    member this.Usage()
       with get() = _Usage
       and set(value) = _Usage <- value
#endregion (Set|Get) The Usage as String.

#region |2019/07/06 00h51:457| <01.00.48> <Property> <Columns> |.Remarks()|String|  (Set|Get) The Remarks as String.
 ///     <Summary>
 ///    (Set|Get) The Remarks as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:088 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Remarks as String.") ]
    member this.Remarks()
       with get() = _Remarks
       and set(value) = _Remarks <- value
#endregion (Set|Get) The Remarks as String.

#region |2019/07/06 00h51:470| <01.00.49> <Property> <Columns> |.Example()|String|  (Set|Get) The Example as String.
 ///     <Summary>
 ///    (Set|Get) The Example as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:088 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Example as String.") ]
    member this.Example()
       with get() = _Example
       and set(value) = _Example <- value
#endregion (Set|Get) The Example as String.

#region |2019/07/06 00h51:486| <01.00.50> <Property> <Columns> |.Note()|String|  (Set|Get) The Note as String.
 ///     <Summary>
 ///    (Set|Get) The Note as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:090 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Note as String.") ]
    member this.Note()
       with get() = _Note
       and set(value) = _Note <- value
#endregion (Set|Get) The Note as String.

#region |2019/07/06 00h51:500| <01.00.51> <Property> <Columns> |.CreationDate()|String|  (Set|Get) The CreationDate as String.
 ///     <Summary>
 ///    (Set|Get) The CreationDate as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:090 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The CreationDate as String.") ]
    member this.CreationDate()
       with get() = _CreationDate
       and set(value) = _CreationDate <- value
#endregion (Set|Get) The CreationDate as String.

#region |2019/07/06 00h51:515| <01.00.52> <Property> <Columns> |.See()|String|  (Set|Get) The See as String.
 ///     <Summary>
 ///    (Set|Get) The See as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:091 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The See as String.") ]
    member this.See()
       with get() = _See
       and set(value) = _See <- value
#endregion (Set|Get) The See as String.

#region |2019/07/06 00h51:529| <01.00.53> <Property> <Columns> |.SeeAlso()|String|  (Set|Get) The SeeAlso as String.
 ///     <Summary>
 ///    (Set|Get) The SeeAlso as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:091 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The SeeAlso as String.") ]
    member this.SeeAlso()
       with get() = _SeeAlso
       and set(value) = _SeeAlso <- value
#endregion (Set|Get) The SeeAlso as String.

#region |2019/07/06 00h51:543| <01.00.54> <Property> <Columns> |.Rules()|String|  (Set|Get) The Rules as String.
 ///     <Summary>
 ///    (Set|Get) The Rules as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:091 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Rules as String.") ]
    member this.Rules()
       with get() = _Rules
       and set(value) = _Rules <- value
#endregion (Set|Get) The Rules as String.

#region |2019/07/06 00h51:556| <01.00.55> <Property> <Columns> |.Syntax()|String|  (Set|Get) The Syntax as String.
 ///     <Summary>
 ///    (Set|Get) The Syntax as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:091 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Syntax as String.") ]
    member this.Syntax()
       with get() = _Syntax
       and set(value) = _Syntax <- value
#endregion (Set|Get) The Syntax as String.

#region |2019/07/06 00h51:570| <01.00.56> <Property> <Columns> |.AccessModifier()|String|  (Set|Get) The AccessModifier as String.
 ///     <Summary>
 ///    (Set|Get) The AccessModifier as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:092 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AccessModifier as String.") ]
    member this.AccessModifier()
       with get() = _AccessModifier
       and set(value) = _AccessModifier <- value
#endregion (Set|Get) The AccessModifier as String.

#region |2019/07/06 00h51:584| <01.00.57> <Property> <Columns> |.Shadows()|Boolean|  (Set|Get) The Shadows as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Shadows as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:092 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Shadows as Boolean.") ]
    member this.Shadows()
       with get() = _Shadows
       and set(value) = _Shadows <- value
#endregion (Set|Get) The Shadows as Boolean.

#region |2019/07/06 00h51:598| <01.00.58> <Property> <Columns> |.Partial()|Boolean|  (Set|Get) The Partial as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Partial as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:092 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Partial as Boolean.") ]
    member this.Partial()
       with get() = _Partial
       and set(value) = _Partial <- value
#endregion (Set|Get) The Partial as Boolean.

#region |2019/07/06 00h51:612| <01.00.59> <Property> <Columns> |.Typelist()|String|  (Set|Get) The Typelist as String.
 ///     <Summary>
 ///    (Set|Get) The Typelist as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:092 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Typelist as String.") ]
    member this.Typelist()
       with get() = _Typelist
       and set(value) = _Typelist <- value
#endregion (Set|Get) The Typelist as String.

#region |2019/07/06 00h51:641| <01.00.60> <Property> <Columns> |.StructureName()|String|  (Set|Get) The StructureName as String.
 ///     <Summary>
 ///    (Set|Get) The StructureName as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:093 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The StructureName as String.") ]
    member this.StructureName()
       with get() = _StructureName
       and set(value) = _StructureName <- value
#endregion (Set|Get) The StructureName as String.

#region |2019/07/06 00h51:655| <01.00.61> <Property> <Columns> |.Implements()|String|  (Set|Get) The Implements as String.
 ///     <Summary>
 ///    (Set|Get) The Implements as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:093 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Implements as String.") ]
    member this.Implements()
       with get() = _Implements
       and set(value) = _Implements <- value
#endregion (Set|Get) The Implements as String.

#end region 
#region <2> [Enumeration]{1}
#region |2019/07/06 00h51:670| <02.00.00> <Property> <> |.Schema()|Enumeration{61}|"' (Set|Get) The enumeration of Schema.
     ///     <Summary>
 ///    (Set|Get) The enumeration of Schema.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:093 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The enumeration of Schema.") ]
    Type Schema = 
/// <summary>(Set|Get) The ID as Integer.</summary>
|   [ID] = 0
/// <summary>(Set|Get) The Name as String.</summary>
|   [Name] = 1
/// <summary>(Set|Get) The ImageIndex as Integer.</summary>
|   [ImageIndex] = 2
/// <summary>(Set|Get) The Text as String.</summary>
|   [Text] = 3
/// <summary>(Set|Get) The ToolTip as String.</summary>
|   [ToolTip] = 4
/// <summary>(Set|Get) The Enable as Boolean.</summary>
|   [Enable] = 5
/// <summary>(Set|Get) The Status as String.</summary>
|   [Status] = 6
/// <summary>(Set|Get) The Statement as String.</summary>
|   [Statement] = 7
/// <summary>(Set|Get) The XMLFile as String.</summary>
|   [XMLFile] = 8
/// <summary>(Set|Get) The Attributes as String.</summary>
|   [Attributes] = 9
/// <summary>(Set|Get) The Browsable as Boolean.</summary>
|   [Browsable] = 10
/// <summary>(Set|Get) The Category as String.</summary>
|   [Category] = 11
/// <summary>(Set|Get) The Description as String.</summary>
|   [Description] = 12
/// <summary>(Set|Get) The DefaultValue as String.</summary>
|   [DefaultValue] = 13
/// <summary>(Set|Get) The Editor as String.</summary>
|   [Editor] = 14
/// <summary>(Set|Get) The DllImport as String.</summary>
|   [DllImport] = 15
/// <summary>(Set|Get) The Deserializable as Boolean.</summary>
|   [Deserializable] = 16
/// <summary>(Set|Get) The NonSerialized as Boolean.</summary>
|   [NonSerialized] = 17
/// <summary>(Set|Get) The Serializable as Boolean.</summary>
|   [Serializable] = 18
/// <summary>(Set|Get) The XmlRoot as String.</summary>
|   [XmlRoot] = 19
/// <summary>(Set|Get) The XmlIgnore as Boolean.</summary>
|   [XmlIgnore] = 20
/// <summary>(Set|Get) The XmlInclude as Boolean.</summary>
|   [XmlInclude] = 21
/// <summary>(Set|Get) The RelatedImageList as String.</summary>
|   [RelatedImageList] = 22
/// <summary>(Set|Get) The Print_VB as String.</summary>
|   [Print_VB] = 23
/// <summary>(Set|Get) The VB as String.</summary>
|   [VB] = 24
/// <summary>(Set|Get) The Print_C as String.</summary>
|   [Print_C] = 25
/// <summary>(Set|Get) The C as String.</summary>
|   [C] = 26
/// <summary>(Set|Get) The Print_F as String.</summary>
|   [Print_F] = 27
/// <summary>(Set|Get) The F as String.</summary>
|   [F] = 28
/// <summary>(Set|Get) The Print_Python as String.</summary>
|   [Print_Python] = 29
/// <summary>(Set|Get) The Python as String.</summary>
|   [Python] = 30
/// <summary>(Set|Get) The Print_JavaScript as String.</summary>
|   [Print_JavaScript] = 31
/// <summary>(Set|Get) The JavaScript as String.</summary>
|   [JavaScript] = 32
/// <summary>(Set|Get) The RegionCategory as Integer.</summary>
|   [RegionCategory] = 33
/// <summary>(Set|Get) The RegionCode as String.</summary>
|   [RegionCode] = 34
/// <summary>(Set|Get) The AuthorEmail as String.</summary>
|   [AuthorEmail] = 35
/// <summary>(Set|Get) The AuthorName as String.</summary>
|   [AuthorName] = 36
/// <summary>(Set|Get) The AuthorUri as String.</summary>
|   [AuthorUri] = 37
/// <summary>(Set|Get) The ContributorEmail as String.</summary>
|   [ContributorEmail] = 38
/// <summary>(Set|Get) The ContributorName as String.</summary>
|   [ContributorName] = 39
/// <summary>(Set|Get) The ContributorUri as String.</summary>
|   [ContributorUri] = 40
/// <summary>(Set|Get) The CustomProperty as String.</summary>
|   [CustomProperty] = 41
/// <summary>(Set|Get) The Published as String.</summary>
|   [Published] = 42
/// <summary>(Set|Get) The Rights as String.</summary>
|   [Rights] = 43
/// <summary>(Set|Get) The Summary as String.</summary>
|   [Summary] = 44
/// <summary>(Set|Get) The Title as String.</summary>
|   [Title] = 45
/// <summary>(Set|Get) The Updated as String.</summary>
|   [Updated] = 46
/// <summary>(Set|Get) The Usage as String.</summary>
|   [Usage] = 47
/// <summary>(Set|Get) The Remarks as String.</summary>
|   [Remarks] = 48
/// <summary>(Set|Get) The Example as String.</summary>
|   [Example] = 49
/// <summary>(Set|Get) The Note as String.</summary>
|   [Note] = 50
/// <summary>(Set|Get) The CreationDate as String.</summary>
|   [CreationDate] = 51
/// <summary>(Set|Get) The See as String.</summary>
|   [See] = 52
/// <summary>(Set|Get) The SeeAlso as String.</summary>
|   [SeeAlso] = 53
/// <summary>(Set|Get) The Rules as String.</summary>
|   [Rules] = 54
/// <summary>(Set|Get) The Syntax as String.</summary>
|   [Syntax] = 55
/// <summary>(Set|Get) The AccessModifier as String.</summary>
|   [AccessModifier] = 56
/// <summary>(Set|Get) The Shadows as Boolean.</summary>
|   [Shadows] = 57
/// <summary>(Set|Get) The Partial as Boolean.</summary>
|   [Partial] = 58
/// <summary>(Set|Get) The Typelist as String.</summary>
|   [Typelist] = 59
/// <summary>(Set|Get) The StructureName as String.</summary>
|   [StructureName] = 60
/// <summary>(Set|Get) The Implements as String.</summary>
|   [Implements] = 61
#endregion (Set|Get) The enumeration of Schema.

#end region 
#region <4> [Sub]{5}
#region |2019/07/06 00h51:691| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
     ///     <Summary>
 ///    (Set|Get) This will reinitialize the class element.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:094 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will reinitialize the class element.") ]
    Let Clear = 
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
#endregion (Set|Get) This will reinitialize the class element.

#region |2019/07/06 00h51:707| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
     ///     <Summary>
 ///    (Set|Get) This will reinitialize the variables of this class.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:094 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will reinitialize the variables of this class.") ]
    Let Reset = 
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

#endregion (Set|Get) This will reinitialize the variables of this class.

#region |2019/07/06 00h51:721| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
     ///     <Summary>
 ///    (Set|Get) This will add a new row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:095 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will add a new row in the table.") ]
    Let Add = 
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

#endregion (Set|Get) This will add a new row in the table.

#region |2019/07/06 00h51:736| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
     ///     <Summary>
 ///    (Set|Get) This will update a row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:095 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will update a row in the table.") ]
    Let Save = 
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

#endregion (Set|Get) This will update a row in the table.

#region |2019/07/06 00h51:753| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
     ///     <Summary>
 ///    (Set|Get) This will Delete a row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:095 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will Delete a row in the table.") ]
    Let Delete = 
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

#endregion (Set|Get) This will Delete a row in the table.

#end region 
#region <5> [Function]{7}
#region |2019/07/06 00h51:767| <05.00.00> <Sub> <> |.Open()|Sub}|"' (Set|Get) This will initialise the connection and import the data.
     ///     <Summary>
 ///    (Set|Get) This will initialise the connection and import the data.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:095 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will initialise the connection and import the data.") ]
    Let Open = 
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

#endregion (Set|Get) This will initialise the connection and import the data.

#region |2019/07/06 00h51:782| <05.00.01> <Sub> <> |.Close()|Sub}|"' (Set|Get) This willClosing the connection
     ///     <Summary>
 ///    (Set|Get) This willClosing the connection
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:096 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This willClosing the connection") ]
    Let Close = 
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

#endregion (Set|Get) This willClosing the connection

#region |2019/07/06 00h51:799| <05.00.02> <Sub> <> |.List()|Sub}|"' (Set|Get) Return the entire table listed
     ///     <Summary>
 ///    (Set|Get) Return the entire table listed
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:096 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Return the entire table listed") ]
    Let List = 
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
#endregion (Set|Get) Return the entire table listed

#region |2019/07/06 00h51:814| <05.00.03> <Sub> <> |.SearchByName()|Sub}|"' (Set|Get) Search for each property that match the Search String.
     ///     <Summary>
 ///    (Set|Get) Search for each property that match the Search String.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:098 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Search for each property that match the Search String.") ]
    Let SearchByName = 
    Dim Result As New List(Of Structure)
 Dim C As New Structure
 For Each Element As Structure In C.List
 If Element.Name.Tolower() = Search.Tolower() Or Element.Text.Tolower() = Search.Tolower()  Or Element.ToolTip.Tolower() = Search.Tolower()  Or Element.Status.Tolower() = Search.Tolower()  Or Element.Statement.Tolower() = Search.Tolower()  Or Element.XMLFile.Tolower() = Search.Tolower()  Or Element.Attributes.Tolower() = Search.Tolower()  Or Element.Category.Tolower() = Search.Tolower()  Or Element.Description.Tolower() = Search.Tolower()  Or Element.DefaultValue.Tolower() = Search.Tolower()  Or Element.Editor.Tolower() = Search.Tolower()  Or Element.DllImport.Tolower() = Search.Tolower()  Or Element.XmlRoot.Tolower() = Search.Tolower()  Or Element.RelatedImageList.Tolower() = Search.Tolower()  Or Element.Print_VB.Tolower() = Search.Tolower()  Or Element.VB.Tolower() = Search.Tolower()  Or Element.Print_C.Tolower() = Search.Tolower()  Or Element.C.Tolower() = Search.Tolower()  Or Element.Print_F.Tolower() = Search.Tolower()  Or Element.F.Tolower() = Search.Tolower()  Or Element.Print_Python.Tolower() = Search.Tolower()  Or Element.Python.Tolower() = Search.Tolower()  Or Element.Print_JavaScript.Tolower() = Search.Tolower()  Or Element.JavaScript.Tolower() = Search.Tolower()  Or Element.RegionCode.Tolower() = Search.Tolower()  Or Element.AuthorEmail.Tolower() = Search.Tolower()  Or Element.AuthorName.Tolower() = Search.Tolower()  Or Element.AuthorUri.Tolower() = Search.Tolower()  Or Element.ContributorEmail.Tolower() = Search.Tolower()  Or Element.ContributorName.Tolower() = Search.Tolower()  Or Element.ContributorUri.Tolower() = Search.Tolower()  Or Element.CustomProperty.Tolower() = Search.Tolower()  Or Element.Published.Tolower() = Search.Tolower()  Or Element.Rights.Tolower() = Search.Tolower()  Or Element.Summary.Tolower() = Search.Tolower()  Or Element.Title.Tolower() = Search.Tolower()  Or Element.Updated.Tolower() = Search.Tolower()  Or Element.Usage.Tolower() = Search.Tolower()  Or Element.Remarks.Tolower() = Search.Tolower()  Or Element.Example.Tolower() = Search.Tolower()  Or Element.Note.Tolower() = Search.Tolower()  Or Element.CreationDate.Tolower() = Search.Tolower()  Or Element.See.Tolower() = Search.Tolower()  Or Element.SeeAlso.Tolower() = Search.Tolower()  Or Element.Rules.Tolower() = Search.Tolower()  Or Element.Syntax.Tolower() = Search.Tolower()  Or Element.AccessModifier.Tolower() = Search.Tolower()  Or Element.Typelist.Tolower() = Search.Tolower()  Or Element.StructureName.Tolower() = Search.Tolower()  Or Element.Implements.Tolower() = Search.Tolower() Then
      Result.Add(Element)
 End If
 Next
 Return Result
#endregion (Set|Get) Search for each property that match the Search String.

#region |2019/07/06 00h51:831| <05.00.04> <Sub> <> |.SearchByID()|Sub}|"' (Set|Get) Search for each property that match the Search Id.
     ///     <Summary>
 ///    (Set|Get) Search for each property that match the Search Id.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:098 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Search for each property that match the Search Id.") ]
    Let SearchByID = 
    Dim Result As New List(Of Structure)
 Dim C As New Structure
 For Each Element As Structure In C.List
 If Val(Element.ID) = Search Or Val(Element.ImageIndex) = Search  Or Val(Element.RegionCategory) = Search Then
      Result.Add(Element)
 End If
 Next
 Return Result
#endregion (Set|Get) Search for each property that match the Search Id.

#region |2019/07/06 00h51:846| <05.00.05> <Sub> <> |.ToString()|Sub}|"' (Set|Get) The function ToString.
     ///     <Summary>
 ///    (Set|Get) The function ToString.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:099 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The function ToString.") ]
    Let ToString = 
        Return Me.ID
#endregion (Set|Get) The function ToString.

#region |2019/07/06 00h51:862| <05.00.06> <Sub> <> |.CheckConnection()|Sub}|"' (Set|Get) Evaluate the connection to the DataBase
     ///     <Summary>
 ///    (Set|Get) Evaluate the connection to the DataBase
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:099 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Evaluate the connection to the DataBase") ]
    Let CheckConnection = 
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

#endregion (Set|Get) Evaluate the connection to the DataBase

#end region 
#region <6> [Runtime]{12}
#region |2019/07/06 00h51:878| <15.00.00> <Runtime> <> |.Table()|Runtime|  (Set|Get) The Table.
 ///     <Summary>
 ///    (Set|Get) The Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:099 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Table.") ]
   Public Table Table;
#endregion (Set|Get) The Table.

#region |2019/07/06 00h51:893| <15.00.01> <Runtime> <> |.Line()|Runtime|  (Set|Get) The Connection String To the Table.
 ///     <Summary>
 ///    (Set|Get) The Connection String To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:100 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Connection String To the Table.") ]
   Public String Line;
#endregion (Set|Get) The Connection String To the Table.

#region |2019/07/06 00h51:917| <15.00.02> <Runtime> <> |.FilePath()|Runtime|  (Set|Get) The FilePath To the Table.
 ///     <Summary>
 ///    (Set|Get) The FilePath To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:100 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The FilePath To the Table.") ]
   Public String FilePath;
#endregion (Set|Get) The FilePath To the Table.

#region |2019/07/06 00h51:932| <15.00.03> <Runtime> <> |.Password()|Runtime|  (Set|Get) The Password To the Table.
 ///     <Summary>
 ///    (Set|Get) The Password To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:100 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Password To the Table.") ]
   Public String Password;
#endregion (Set|Get) The Password To the Table.

#region |2019/07/06 00h51:946| <15.00.04> <Runtime> <> |.UseSQL()|Runtime|  (Set|Get) Determines if the Database Connection is of type SQL.
 ///     <Summary>
 ///    (Set|Get) Determines if the Database Connection is of type SQL.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:101 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Determines if the Database Connection is of type SQL.") ]
   Public Boolean UseSQL;
#endregion (Set|Get) Determines if the Database Connection is of type SQL.

#region |2019/07/06 00h51:959| <15.00.05> <Runtime> <> |.TableName()|Runtime|  (Set|Get) The name of the Table.
 ///     <Summary>
 ///    (Set|Get) The name of the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:101 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The name of the Table.") ]
   Public String TableName;
#endregion (Set|Get) The name of the Table.

#region |2019/07/06 00h51:975| <15.00.06> <Runtime> <> |.Con()|Runtime|  (Set|Get) The Con To the Table.
 ///     <Summary>
 ///    (Set|Get) The Con To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:101 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Con To the Table.") ]
   Public OleDb.OleDbConnection Con;
#endregion (Set|Get) The Con To the Table.

#region |2019/07/06 00h51:981| <15.00.07> <Runtime> <> |.Cmd()|Runtime|  (Set|Get) The Cmd To the Table.
 ///     <Summary>
 ///    (Set|Get) The Cmd To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:101 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Cmd To the Table.") ]
   Public OleDb.OleDbCommand Cmd;
#endregion (Set|Get) The Cmd To the Table.

#region |2019/07/06 00h51:995| <15.00.08> <Runtime> <> |.DataReader()|Runtime|  (Set|Get) The DataReader To the Table.
 ///     <Summary>
 ///    (Set|Get) The DataReader To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:101 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The DataReader To the Table.") ]
   Public OleDb.OleDbDataReader DataReader;
#endregion (Set|Get) The DataReader To the Table.

#region |2019/07/06 00h51:009| <15.00.09> <Runtime> <> |.DataAdapter()|Runtime|  (Set|Get) The DataAdapter To the Table.
 ///     <Summary>
 ///    (Set|Get) The DataAdapter To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:102 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The DataAdapter To the Table.") ]
   Public OleDb.OleDbDataAdapter DataAdapter;
#endregion (Set|Get) The DataAdapter To the Table.

#region |2019/07/06 00h51:023| <15.00.10> <Runtime> <> |.Connector()|Runtime|  (Set|Get) The Connector To the Table.
 ///     <Summary>
 ///    (Set|Get) The Connector To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:102 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Connector To the Table.") ]
   Public LineInfo Connector;
#endregion (Set|Get) The Connector To the Table.

#region |2019/07/06 00h51:037| <15.00.11> <Runtime> <> |.Log()|Runtime|  (Set|Get) The Log To the Table.
 ///     <Summary>
 ///    (Set|Get) The Log To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:102 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Log To the Table.") ]
   Public String Log;
#endregion (Set|Get) The Log To the Table.

#end region 
#region <7> [Loader]{2}
#region |2019/07/06 00h51:052| <06.00.00> <Sub> <> |.Empty()|Sub}|"' (Set|Get) The sub Empty.
     ///     <Summary>
 ///    (Set|Get) The sub Empty.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:103 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The sub Empty.") ]
    Let Empty = 
    Reset
#endregion (Set|Get) The sub Empty.

#region |2019/07/06 00h51:063| <06.00.01> <Sub> <> |.Filled()|Sub}|"' (Set|Get) The sub Filled.
     ///     <Summary>
 ///    (Set|Get) The sub Filled.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:103 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The sub Filled.") ]
    Let Filled = 
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

#endregion (Set|Get) The sub Filled.

#end region 
}

 ///     <Summary>
 ///    Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Sub
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
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:154 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
public  class Sub{
#region <1> [Property]{65}
#region |2019/07/06 00h51:308| <01.00.00> <Property> <Columns> |.ID()|Integer|  (Set|Get) The ID as Integer.
 ///     <Summary>
 ///    (Set|Get) The ID as Integer.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:154 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ID as Integer.") ]
    member this.ID()
       with get() = _ID
       and set(value) = _ID <- value
#endregion (Set|Get) The ID as Integer.

#region |2019/07/06 00h51:319| <01.00.01> <Property> <Columns> |.Name()|String|  (Set|Get) The Name as String.
 ///     <Summary>
 ///    (Set|Get) The Name as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:154 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Name as String.") ]
    member this.Name()
       with get() = _Name
       and set(value) = _Name <- value
#endregion (Set|Get) The Name as String.

#region |2019/07/06 00h51:329| <01.00.02> <Property> <Columns> |.ImageIndex()|Integer|  (Set|Get) The ImageIndex as Integer.
 ///     <Summary>
 ///    (Set|Get) The ImageIndex as Integer.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:154 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ImageIndex as Integer.") ]
    member this.ImageIndex()
       with get() = _ImageIndex
       and set(value) = _ImageIndex <- value
#endregion (Set|Get) The ImageIndex as Integer.

#region |2019/07/06 00h51:340| <01.00.03> <Property> <Columns> |.Text()|String|  (Set|Get) The Text as String.
 ///     <Summary>
 ///    (Set|Get) The Text as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:157 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Text as String.") ]
    member this.Text()
       with get() = _Text
       and set(value) = _Text <- value
#endregion (Set|Get) The Text as String.

#region |2019/07/06 00h51:352| <01.00.04> <Property> <Columns> |.ToolTip()|String|  (Set|Get) The ToolTip as String.
 ///     <Summary>
 ///    (Set|Get) The ToolTip as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:157 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ToolTip as String.") ]
    member this.ToolTip()
       with get() = _ToolTip
       and set(value) = _ToolTip <- value
#endregion (Set|Get) The ToolTip as String.

#region |2019/07/06 00h51:362| <01.00.05> <Property> <Columns> |.Enable()|Boolean|  (Set|Get) The Enable as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Enable as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:157 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Enable as Boolean.") ]
    member this.Enable()
       with get() = _Enable
       and set(value) = _Enable <- value
#endregion (Set|Get) The Enable as Boolean.

#region |2019/07/06 00h51:372| <01.00.06> <Property> <Columns> |.Status()|String|  (Set|Get) The Status as String.
 ///     <Summary>
 ///    (Set|Get) The Status as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:157 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Status as String.") ]
    member this.Status()
       with get() = _Status
       and set(value) = _Status <- value
#endregion (Set|Get) The Status as String.

#region |2019/07/06 00h51:383| <01.00.07> <Property> <Columns> |.Statement()|String|  (Set|Get) The Statement as String.
 ///     <Summary>
 ///    (Set|Get) The Statement as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:158 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Statement as String.") ]
    member this.Statement()
       with get() = _Statement
       and set(value) = _Statement <- value
#endregion (Set|Get) The Statement as String.

#region |2019/07/06 00h51:394| <01.00.08> <Property> <Columns> |.XMLFile()|String|  (Set|Get) The XMLFile as String.
 ///     <Summary>
 ///    (Set|Get) The XMLFile as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:158 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XMLFile as String.") ]
    member this.XMLFile()
       with get() = _XMLFile
       and set(value) = _XMLFile <- value
#endregion (Set|Get) The XMLFile as String.

#region |2019/07/06 00h51:404| <01.00.09> <Property> <Columns> |.Attributes()|String|  (Set|Get) The Attributes as String.
 ///     <Summary>
 ///    (Set|Get) The Attributes as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:161 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Attributes as String.") ]
    member this.Attributes()
       with get() = _Attributes
       and set(value) = _Attributes <- value
#endregion (Set|Get) The Attributes as String.

#region |2019/07/06 00h51:416| <01.00.10> <Property> <Columns> |.Browsable()|Boolean|  (Set|Get) The Browsable as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Browsable as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:161 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Browsable as Boolean.") ]
    member this.Browsable()
       with get() = _Browsable
       and set(value) = _Browsable <- value
#endregion (Set|Get) The Browsable as Boolean.

#region |2019/07/06 00h51:426| <01.00.11> <Property> <Columns> |.Category()|String|  (Set|Get) The Category as String.
 ///     <Summary>
 ///    (Set|Get) The Category as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:161 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Category as String.") ]
    member this.Category()
       with get() = _Category
       and set(value) = _Category <- value
#endregion (Set|Get) The Category as String.

#region |2019/07/06 00h51:437| <01.00.12> <Property> <Columns> |.Description()|String|  (Set|Get) The Description as String.
 ///     <Summary>
 ///    (Set|Get) The Description as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:161 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Description as String.") ]
    member this.Description()
       with get() = _Description
       and set(value) = _Description <- value
#endregion (Set|Get) The Description as String.

#region |2019/07/06 00h51:448| <01.00.13> <Property> <Columns> |.DefaultValue()|String|  (Set|Get) The DefaultValue as String.
 ///     <Summary>
 ///    (Set|Get) The DefaultValue as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:162 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The DefaultValue as String.") ]
    member this.DefaultValue()
       with get() = _DefaultValue
       and set(value) = _DefaultValue <- value
#endregion (Set|Get) The DefaultValue as String.

#region |2019/07/06 00h51:460| <01.00.14> <Property> <Columns> |.Editor()|String|  (Set|Get) The Editor as String.
 ///     <Summary>
 ///    (Set|Get) The Editor as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:162 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Editor as String.") ]
    member this.Editor()
       with get() = _Editor
       and set(value) = _Editor <- value
#endregion (Set|Get) The Editor as String.

#region |2019/07/06 00h51:471| <01.00.15> <Property> <Columns> |.DllImport()|String|  (Set|Get) The DllImport as String.
 ///     <Summary>
 ///    (Set|Get) The DllImport as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:162 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The DllImport as String.") ]
    member this.DllImport()
       with get() = _DllImport
       and set(value) = _DllImport <- value
#endregion (Set|Get) The DllImport as String.

#region |2019/07/06 00h51:490| <01.00.16> <Property> <Columns> |.Deserializable()|Boolean|  (Set|Get) The Deserializable as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Deserializable as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:162 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Deserializable as Boolean.") ]
    member this.Deserializable()
       with get() = _Deserializable
       and set(value) = _Deserializable <- value
#endregion (Set|Get) The Deserializable as Boolean.

#region |2019/07/06 00h51:501| <01.00.17> <Property> <Columns> |.NonSerialized()|Boolean|  (Set|Get) The NonSerialized as Boolean.
 ///     <Summary>
 ///    (Set|Get) The NonSerialized as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:165 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The NonSerialized as Boolean.") ]
    member this.NonSerialized()
       with get() = _NonSerialized
       and set(value) = _NonSerialized <- value
#endregion (Set|Get) The NonSerialized as Boolean.

#region |2019/07/06 00h51:513| <01.00.18> <Property> <Columns> |.Serializable()|Boolean|  (Set|Get) The Serializable as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Serializable as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:165 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Serializable as Boolean.") ]
    member this.Serializable()
       with get() = _Serializable
       and set(value) = _Serializable <- value
#endregion (Set|Get) The Serializable as Boolean.

#region |2019/07/06 00h51:524| <01.00.19> <Property> <Columns> |.XmlRoot()|String|  (Set|Get) The XmlRoot as String.
 ///     <Summary>
 ///    (Set|Get) The XmlRoot as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:165 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XmlRoot as String.") ]
    member this.XmlRoot()
       with get() = _XmlRoot
       and set(value) = _XmlRoot <- value
#endregion (Set|Get) The XmlRoot as String.

#region |2019/07/06 00h51:535| <01.00.20> <Property> <Columns> |.XmlIgnore()|Boolean|  (Set|Get) The XmlIgnore as Boolean.
 ///     <Summary>
 ///    (Set|Get) The XmlIgnore as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:166 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XmlIgnore as Boolean.") ]
    member this.XmlIgnore()
       with get() = _XmlIgnore
       and set(value) = _XmlIgnore <- value
#endregion (Set|Get) The XmlIgnore as Boolean.

#region |2019/07/06 00h51:548| <01.00.21> <Property> <Columns> |.XmlInclude()|Boolean|  (Set|Get) The XmlInclude as Boolean.
 ///     <Summary>
 ///    (Set|Get) The XmlInclude as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:166 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The XmlInclude as Boolean.") ]
    member this.XmlInclude()
       with get() = _XmlInclude
       and set(value) = _XmlInclude <- value
#endregion (Set|Get) The XmlInclude as Boolean.

#region |2019/07/06 00h51:559| <01.00.22> <Property> <Columns> |.RelatedImageList()|String|  (Set|Get) The RelatedImageList as String.
 ///     <Summary>
 ///    (Set|Get) The RelatedImageList as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:166 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The RelatedImageList as String.") ]
    member this.RelatedImageList()
       with get() = _RelatedImageList
       and set(value) = _RelatedImageList <- value
#endregion (Set|Get) The RelatedImageList as String.

#region |2019/07/06 00h51:571| <01.00.23> <Property> <Columns> |.Print_VB()|String|  (Set|Get) The Print_VB as String.
 ///     <Summary>
 ///    (Set|Get) The Print_VB as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:166 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_VB as String.") ]
    member this.Print_VB()
       with get() = _Print_VB
       and set(value) = _Print_VB <- value
#endregion (Set|Get) The Print_VB as String.

#region |2019/07/06 00h51:582| <01.00.24> <Property> <Columns> |.VB()|String|  (Set|Get) The VB as String.
 ///     <Summary>
 ///    (Set|Get) The VB as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:166 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The VB as String.") ]
    member this.VB()
       with get() = _VB
       and set(value) = _VB <- value
#endregion (Set|Get) The VB as String.

#region |2019/07/06 00h51:594| <01.00.25> <Property> <Columns> |.Print_C()|String|  (Set|Get) The Print_C as String.
 ///     <Summary>
 ///    (Set|Get) The Print_C as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:167 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_C as String.") ]
    member this.Print_C()
       with get() = _Print_C
       and set(value) = _Print_C <- value
#endregion (Set|Get) The Print_C as String.

#region |2019/07/06 00h51:605| <01.00.26> <Property> <Columns> |.C()|String|  (Set|Get) The C as String.
 ///     <Summary>
 ///    (Set|Get) The C as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:170 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The C as String.") ]
    member this.C()
       with get() = _C
       and set(value) = _C <- value
#endregion (Set|Get) The C as String.

#region |2019/07/06 00h51:617| <01.00.27> <Property> <Columns> |.Print_F()|String|  (Set|Get) The Print_F as String.
 ///     <Summary>
 ///    (Set|Get) The Print_F as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:170 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_F as String.") ]
    member this.Print_F()
       with get() = _Print_F
       and set(value) = _Print_F <- value
#endregion (Set|Get) The Print_F as String.

#region |2019/07/06 00h51:629| <01.00.28> <Property> <Columns> |.F()|String|  (Set|Get) The F as String.
 ///     <Summary>
 ///    (Set|Get) The F as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:170 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The F as String.") ]
    member this.F()
       with get() = _F
       and set(value) = _F <- value
#endregion (Set|Get) The F as String.

#region |2019/07/06 00h51:640| <01.00.29> <Property> <Columns> |.Print_Python()|String|  (Set|Get) The Print_Python as String.
 ///     <Summary>
 ///    (Set|Get) The Print_Python as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:170 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_Python as String.") ]
    member this.Print_Python()
       with get() = _Print_Python
       and set(value) = _Print_Python <- value
#endregion (Set|Get) The Print_Python as String.

#region |2019/07/06 00h51:652| <01.00.30> <Property> <Columns> |.Python()|String|  (Set|Get) The Python as String.
 ///     <Summary>
 ///    (Set|Get) The Python as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:172 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Python as String.") ]
    member this.Python()
       with get() = _Python
       and set(value) = _Python <- value
#endregion (Set|Get) The Python as String.

#region |2019/07/06 00h51:664| <01.00.31> <Property> <Columns> |.Print_JavaScript()|String|  (Set|Get) The Print_JavaScript as String.
 ///     <Summary>
 ///    (Set|Get) The Print_JavaScript as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:172 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Print_JavaScript as String.") ]
    member this.Print_JavaScript()
       with get() = _Print_JavaScript
       and set(value) = _Print_JavaScript <- value
#endregion (Set|Get) The Print_JavaScript as String.

#region |2019/07/06 00h51:676| <01.00.32> <Property> <Columns> |.JavaScript()|String|  (Set|Get) The JavaScript as String.
 ///     <Summary>
 ///    (Set|Get) The JavaScript as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:173 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The JavaScript as String.") ]
    member this.JavaScript()
       with get() = _JavaScript
       and set(value) = _JavaScript <- value
#endregion (Set|Get) The JavaScript as String.

#region |2019/07/06 00h51:689| <01.00.33> <Property> <Columns> |.RegionCategory()|Integer|  (Set|Get) The RegionCategory as Integer.
 ///     <Summary>
 ///    (Set|Get) The RegionCategory as Integer.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:173 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The RegionCategory as Integer.") ]
    member this.RegionCategory()
       with get() = _RegionCategory
       and set(value) = _RegionCategory <- value
#endregion (Set|Get) The RegionCategory as Integer.

#region |2019/07/06 00h51:701| <01.00.34> <Property> <Columns> |.RegionCode()|String|  (Set|Get) The RegionCode as String.
 ///     <Summary>
 ///    (Set|Get) The RegionCode as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:176 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The RegionCode as String.") ]
    member this.RegionCode()
       with get() = _RegionCode
       and set(value) = _RegionCode <- value
#endregion (Set|Get) The RegionCode as String.

#region |2019/07/06 00h51:713| <01.00.35> <Property> <Columns> |.AuthorEmail()|String|  (Set|Get) The AuthorEmail as String.
 ///     <Summary>
 ///    (Set|Get) The AuthorEmail as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:176 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AuthorEmail as String.") ]
    member this.AuthorEmail()
       with get() = _AuthorEmail
       and set(value) = _AuthorEmail <- value
#endregion (Set|Get) The AuthorEmail as String.

#region |2019/07/06 00h51:725| <01.00.36> <Property> <Columns> |.AuthorName()|String|  (Set|Get) The AuthorName as String.
 ///     <Summary>
 ///    (Set|Get) The AuthorName as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:176 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AuthorName as String.") ]
    member this.AuthorName()
       with get() = _AuthorName
       and set(value) = _AuthorName <- value
#endregion (Set|Get) The AuthorName as String.

#region |2019/07/06 00h51:747| <01.00.37> <Property> <Columns> |.AuthorUri()|String|  (Set|Get) The AuthorUri as String.
 ///     <Summary>
 ///    (Set|Get) The AuthorUri as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:177 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AuthorUri as String.") ]
    member this.AuthorUri()
       with get() = _AuthorUri
       and set(value) = _AuthorUri <- value
#endregion (Set|Get) The AuthorUri as String.

#region |2019/07/06 00h51:759| <01.00.38> <Property> <Columns> |.ContributorEmail()|String|  (Set|Get) The ContributorEmail as String.
 ///     <Summary>
 ///    (Set|Get) The ContributorEmail as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:177 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ContributorEmail as String.") ]
    member this.ContributorEmail()
       with get() = _ContributorEmail
       and set(value) = _ContributorEmail <- value
#endregion (Set|Get) The ContributorEmail as String.

#region |2019/07/06 00h51:771| <01.00.39> <Property> <Columns> |.ContributorName()|String|  (Set|Get) The ContributorName as String.
 ///     <Summary>
 ///    (Set|Get) The ContributorName as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:177 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ContributorName as String.") ]
    member this.ContributorName()
       with get() = _ContributorName
       and set(value) = _ContributorName <- value
#endregion (Set|Get) The ContributorName as String.

#region |2019/07/06 00h51:783| <01.00.40> <Property> <Columns> |.ContributorUri()|String|  (Set|Get) The ContributorUri as String.
 ///     <Summary>
 ///    (Set|Get) The ContributorUri as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:177 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ContributorUri as String.") ]
    member this.ContributorUri()
       with get() = _ContributorUri
       and set(value) = _ContributorUri <- value
#endregion (Set|Get) The ContributorUri as String.

#region |2019/07/06 00h51:797| <01.00.41> <Property> <Columns> |.CustomProperty()|String|  (Set|Get) The CustomProperty as String.
 ///     <Summary>
 ///    (Set|Get) The CustomProperty as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:178 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The CustomProperty as String.") ]
    member this.CustomProperty()
       with get() = _CustomProperty
       and set(value) = _CustomProperty <- value
#endregion (Set|Get) The CustomProperty as String.

#region |2019/07/06 00h51:809| <01.00.42> <Property> <Columns> |.Published()|String|  (Set|Get) The Published as String.
 ///     <Summary>
 ///    (Set|Get) The Published as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:178 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Published as String.") ]
    member this.Published()
       with get() = _Published
       and set(value) = _Published <- value
#endregion (Set|Get) The Published as String.

#region |2019/07/06 00h51:822| <01.00.43> <Property> <Columns> |.Rights()|String|  (Set|Get) The Rights as String.
 ///     <Summary>
 ///    (Set|Get) The Rights as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:181 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Rights as String.") ]
    member this.Rights()
       with get() = _Rights
       and set(value) = _Rights <- value
#endregion (Set|Get) The Rights as String.

#region |2019/07/06 00h51:834| <01.00.44> <Property> <Columns> |.Summary()|String|  (Set|Get) The Summary as String.
 ///     <Summary>
 ///    (Set|Get) The Summary as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:182 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Summary as String.") ]
    member this.Summary()
       with get() = _Summary
       and set(value) = _Summary <- value
#endregion (Set|Get) The Summary as String.

#region |2019/07/06 00h51:846| <01.00.45> <Property> <Columns> |.Title()|String|  (Set|Get) The Title as String.
 ///     <Summary>
 ///    (Set|Get) The Title as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:182 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Title as String.") ]
    member this.Title()
       with get() = _Title
       and set(value) = _Title <- value
#endregion (Set|Get) The Title as String.

#region |2019/07/06 00h51:860| <01.00.46> <Property> <Columns> |.Updated()|String|  (Set|Get) The Updated as String.
 ///     <Summary>
 ///    (Set|Get) The Updated as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:183 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Updated as String.") ]
    member this.Updated()
       with get() = _Updated
       and set(value) = _Updated <- value
#endregion (Set|Get) The Updated as String.

#region |2019/07/06 00h51:873| <01.00.47> <Property> <Columns> |.Usage()|String|  (Set|Get) The Usage as String.
 ///     <Summary>
 ///    (Set|Get) The Usage as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:183 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Usage as String.") ]
    member this.Usage()
       with get() = _Usage
       and set(value) = _Usage <- value
#endregion (Set|Get) The Usage as String.

#region |2019/07/06 00h51:886| <01.00.48> <Property> <Columns> |.Remarks()|String|  (Set|Get) The Remarks as String.
 ///     <Summary>
 ///    (Set|Get) The Remarks as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:183 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Remarks as String.") ]
    member this.Remarks()
       with get() = _Remarks
       and set(value) = _Remarks <- value
#endregion (Set|Get) The Remarks as String.

#region |2019/07/06 00h51:899| <01.00.49> <Property> <Columns> |.Example()|String|  (Set|Get) The Example as String.
 ///     <Summary>
 ///    (Set|Get) The Example as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:184 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Example as String.") ]
    member this.Example()
       with get() = _Example
       and set(value) = _Example <- value
#endregion (Set|Get) The Example as String.

#region |2019/07/06 00h51:911| <01.00.50> <Property> <Columns> |.Note()|String|  (Set|Get) The Note as String.
 ///     <Summary>
 ///    (Set|Get) The Note as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:184 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Note as String.") ]
    member this.Note()
       with get() = _Note
       and set(value) = _Note <- value
#endregion (Set|Get) The Note as String.

#region |2019/07/06 00h51:924| <01.00.51> <Property> <Columns> |.CreationDate()|String|  (Set|Get) The CreationDate as String.
 ///     <Summary>
 ///    (Set|Get) The CreationDate as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:185 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The CreationDate as String.") ]
    member this.CreationDate()
       with get() = _CreationDate
       and set(value) = _CreationDate <- value
#endregion (Set|Get) The CreationDate as String.

#region |2019/07/06 00h51:936| <01.00.52> <Property> <Columns> |.See()|String|  (Set|Get) The See as String.
 ///     <Summary>
 ///    (Set|Get) The See as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:185 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The See as String.") ]
    member this.See()
       with get() = _See
       and set(value) = _See <- value
#endregion (Set|Get) The See as String.

#region |2019/07/06 00h51:949| <01.00.53> <Property> <Columns> |.SeeAlso()|String|  (Set|Get) The SeeAlso as String.
 ///     <Summary>
 ///    (Set|Get) The SeeAlso as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:186 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The SeeAlso as String.") ]
    member this.SeeAlso()
       with get() = _SeeAlso
       and set(value) = _SeeAlso <- value
#endregion (Set|Get) The SeeAlso as String.

#region |2019/07/06 00h51:962| <01.00.54> <Property> <Columns> |.Rules()|String|  (Set|Get) The Rules as String.
 ///     <Summary>
 ///    (Set|Get) The Rules as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:186 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Rules as String.") ]
    member this.Rules()
       with get() = _Rules
       and set(value) = _Rules <- value
#endregion (Set|Get) The Rules as String.

#region |2019/07/06 00h51:985| <01.00.55> <Property> <Columns> |.Syntax()|String|  (Set|Get) The Syntax as String.
 ///     <Summary>
 ///    (Set|Get) The Syntax as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:186 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Syntax as String.") ]
    member this.Syntax()
       with get() = _Syntax
       and set(value) = _Syntax <- value
#endregion (Set|Get) The Syntax as String.

#region |2019/07/06 00h51:999| <01.00.56> <Property> <Columns> |.AccessModifier()|String|  (Set|Get) The AccessModifier as String.
 ///     <Summary>
 ///    (Set|Get) The AccessModifier as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:187 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The AccessModifier as String.") ]
    member this.AccessModifier()
       with get() = _AccessModifier
       and set(value) = _AccessModifier <- value
#endregion (Set|Get) The AccessModifier as String.

#region |2019/07/06 00h51:011| <01.00.57> <Property> <Columns> |.ProcedureModifier()|String|  (Set|Get) The ProcedureModifier as String.
 ///     <Summary>
 ///    (Set|Get) The ProcedureModifier as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:187 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ProcedureModifier as String.") ]
    member this.ProcedureModifier()
       with get() = _ProcedureModifier
       and set(value) = _ProcedureModifier <- value
#endregion (Set|Get) The ProcedureModifier as String.

#region |2019/07/06 00h51:024| <01.00.58> <Property> <Columns> |.Partial()|Boolean|  (Set|Get) The Partial as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Partial as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:188 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Partial as Boolean.") ]
    member this.Partial()
       with get() = _Partial
       and set(value) = _Partial <- value
#endregion (Set|Get) The Partial as Boolean.

#region |2019/07/06 00h51:037| <01.00.59> <Property> <Columns> |.Shared()|Boolean|  (Set|Get) The Shared as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Shared as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:188 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Shared as Boolean.") ]
    member this.Shared()
       with get() = _Shared
       and set(value) = _Shared <- value
#endregion (Set|Get) The Shared as Boolean.

#region |2019/07/06 00h51:050| <01.00.60> <Property> <Columns> |.Shadows()|Boolean|  (Set|Get) The Shadows as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Shadows as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:189 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Shadows as Boolean.") ]
    member this.Shadows()
       with get() = _Shadows
       and set(value) = _Shadows <- value
#endregion (Set|Get) The Shadows as Boolean.

#region |2019/07/06 00h51:065| <01.00.61> <Property> <Columns> |.Async()|Boolean|  (Set|Get) The Async as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Async as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:189 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Async as Boolean.") ]
    member this.Async()
       with get() = _Async
       and set(value) = _Async <- value
#endregion (Set|Get) The Async as Boolean.

#region |2019/07/06 00h51:077| <01.00.62> <Property> <Columns> |.SubName()|String|  (Set|Get) The SubName as String.
 ///     <Summary>
 ///    (Set|Get) The SubName as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:190 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The SubName as String.") ]
    member this.SubName()
       with get() = _SubName
       and set(value) = _SubName <- value
#endregion (Set|Get) The SubName as String.

#region |2019/07/06 00h51:091| <01.00.63> <Property> <Columns> |.Handles()|String|  (Set|Get) The Handles as String.
 ///     <Summary>
 ///    (Set|Get) The Handles as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:190 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Handles as String.") ]
    member this.Handles()
       with get() = _Handles
       and set(value) = _Handles <- value
#endregion (Set|Get) The Handles as String.

#region |2019/07/06 00h51:104| <01.00.64> <Property> <Columns> |.Implements()|String|  (Set|Get) The Implements as String.
 ///     <Summary>
 ///    (Set|Get) The Implements as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:191 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Implements as String.") ]
    member this.Implements()
       with get() = _Implements
       and set(value) = _Implements <- value
#endregion (Set|Get) The Implements as String.

#end region 
#region <2> [Enumeration]{1}
#region |2019/07/06 00h51:118| <02.00.00> <Property> <> |.Schema()|Enumeration{64}|"' (Set|Get) The enumeration of Schema.
     ///     <Summary>
 ///    (Set|Get) The enumeration of Schema.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:191 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The enumeration of Schema.") ]
    Type Schema = 
/// <summary>(Set|Get) The ID as Integer.</summary>
|   [ID] = 0
/// <summary>(Set|Get) The Name as String.</summary>
|   [Name] = 1
/// <summary>(Set|Get) The ImageIndex as Integer.</summary>
|   [ImageIndex] = 2
/// <summary>(Set|Get) The Text as String.</summary>
|   [Text] = 3
/// <summary>(Set|Get) The ToolTip as String.</summary>
|   [ToolTip] = 4
/// <summary>(Set|Get) The Enable as Boolean.</summary>
|   [Enable] = 5
/// <summary>(Set|Get) The Status as String.</summary>
|   [Status] = 6
/// <summary>(Set|Get) The Statement as String.</summary>
|   [Statement] = 7
/// <summary>(Set|Get) The XMLFile as String.</summary>
|   [XMLFile] = 8
/// <summary>(Set|Get) The Attributes as String.</summary>
|   [Attributes] = 9
/// <summary>(Set|Get) The Browsable as Boolean.</summary>
|   [Browsable] = 10
/// <summary>(Set|Get) The Category as String.</summary>
|   [Category] = 11
/// <summary>(Set|Get) The Description as String.</summary>
|   [Description] = 12
/// <summary>(Set|Get) The DefaultValue as String.</summary>
|   [DefaultValue] = 13
/// <summary>(Set|Get) The Editor as String.</summary>
|   [Editor] = 14
/// <summary>(Set|Get) The DllImport as String.</summary>
|   [DllImport] = 15
/// <summary>(Set|Get) The Deserializable as Boolean.</summary>
|   [Deserializable] = 16
/// <summary>(Set|Get) The NonSerialized as Boolean.</summary>
|   [NonSerialized] = 17
/// <summary>(Set|Get) The Serializable as Boolean.</summary>
|   [Serializable] = 18
/// <summary>(Set|Get) The XmlRoot as String.</summary>
|   [XmlRoot] = 19
/// <summary>(Set|Get) The XmlIgnore as Boolean.</summary>
|   [XmlIgnore] = 20
/// <summary>(Set|Get) The XmlInclude as Boolean.</summary>
|   [XmlInclude] = 21
/// <summary>(Set|Get) The RelatedImageList as String.</summary>
|   [RelatedImageList] = 22
/// <summary>(Set|Get) The Print_VB as String.</summary>
|   [Print_VB] = 23
/// <summary>(Set|Get) The VB as String.</summary>
|   [VB] = 24
/// <summary>(Set|Get) The Print_C as String.</summary>
|   [Print_C] = 25
/// <summary>(Set|Get) The C as String.</summary>
|   [C] = 26
/// <summary>(Set|Get) The Print_F as String.</summary>
|   [Print_F] = 27
/// <summary>(Set|Get) The F as String.</summary>
|   [F] = 28
/// <summary>(Set|Get) The Print_Python as String.</summary>
|   [Print_Python] = 29
/// <summary>(Set|Get) The Python as String.</summary>
|   [Python] = 30
/// <summary>(Set|Get) The Print_JavaScript as String.</summary>
|   [Print_JavaScript] = 31
/// <summary>(Set|Get) The JavaScript as String.</summary>
|   [JavaScript] = 32
/// <summary>(Set|Get) The RegionCategory as Integer.</summary>
|   [RegionCategory] = 33
/// <summary>(Set|Get) The RegionCode as String.</summary>
|   [RegionCode] = 34
/// <summary>(Set|Get) The AuthorEmail as String.</summary>
|   [AuthorEmail] = 35
/// <summary>(Set|Get) The AuthorName as String.</summary>
|   [AuthorName] = 36
/// <summary>(Set|Get) The AuthorUri as String.</summary>
|   [AuthorUri] = 37
/// <summary>(Set|Get) The ContributorEmail as String.</summary>
|   [ContributorEmail] = 38
/// <summary>(Set|Get) The ContributorName as String.</summary>
|   [ContributorName] = 39
/// <summary>(Set|Get) The ContributorUri as String.</summary>
|   [ContributorUri] = 40
/// <summary>(Set|Get) The CustomProperty as String.</summary>
|   [CustomProperty] = 41
/// <summary>(Set|Get) The Published as String.</summary>
|   [Published] = 42
/// <summary>(Set|Get) The Rights as String.</summary>
|   [Rights] = 43
/// <summary>(Set|Get) The Summary as String.</summary>
|   [Summary] = 44
/// <summary>(Set|Get) The Title as String.</summary>
|   [Title] = 45
/// <summary>(Set|Get) The Updated as String.</summary>
|   [Updated] = 46
/// <summary>(Set|Get) The Usage as String.</summary>
|   [Usage] = 47
/// <summary>(Set|Get) The Remarks as String.</summary>
|   [Remarks] = 48
/// <summary>(Set|Get) The Example as String.</summary>
|   [Example] = 49
/// <summary>(Set|Get) The Note as String.</summary>
|   [Note] = 50
/// <summary>(Set|Get) The CreationDate as String.</summary>
|   [CreationDate] = 51
/// <summary>(Set|Get) The See as String.</summary>
|   [See] = 52
/// <summary>(Set|Get) The SeeAlso as String.</summary>
|   [SeeAlso] = 53
/// <summary>(Set|Get) The Rules as String.</summary>
|   [Rules] = 54
/// <summary>(Set|Get) The Syntax as String.</summary>
|   [Syntax] = 55
/// <summary>(Set|Get) The AccessModifier as String.</summary>
|   [AccessModifier] = 56
/// <summary>(Set|Get) The ProcedureModifier as String.</summary>
|   [ProcedureModifier] = 57
/// <summary>(Set|Get) The Partial as Boolean.</summary>
|   [Partial] = 58
/// <summary>(Set|Get) The Shared as Boolean.</summary>
|   [Shared] = 59
/// <summary>(Set|Get) The Shadows as Boolean.</summary>
|   [Shadows] = 60
/// <summary>(Set|Get) The Async as Boolean.</summary>
|   [Async] = 61
/// <summary>(Set|Get) The SubName as String.</summary>
|   [SubName] = 62
/// <summary>(Set|Get) The Handles as String.</summary>
|   [Handles] = 63
/// <summary>(Set|Get) The Implements as String.</summary>
|   [Implements] = 64
#endregion (Set|Get) The enumeration of Schema.

#end region 
#region <4> [Sub]{5}
#region |2019/07/06 00h51:143| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
     ///     <Summary>
 ///    (Set|Get) This will reinitialize the class element.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:195 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will reinitialize the class element.") ]
    Let Clear = 
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
#endregion (Set|Get) This will reinitialize the class element.

#region |2019/07/06 00h51:157| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
     ///     <Summary>
 ///    (Set|Get) This will reinitialize the variables of this class.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:195 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will reinitialize the variables of this class.") ]
    Let Reset = 
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

#endregion (Set|Get) This will reinitialize the variables of this class.

#region |2019/07/06 00h51:173| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
     ///     <Summary>
 ///    (Set|Get) This will add a new row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:195 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will add a new row in the table.") ]
    Let Add = 
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

#endregion (Set|Get) This will add a new row in the table.

#region |2019/07/06 00h51:188| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
     ///     <Summary>
 ///    (Set|Get) This will update a row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:195 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will update a row in the table.") ]
    Let Save = 
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

#endregion (Set|Get) This will update a row in the table.

#region |2019/07/06 00h51:202| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
     ///     <Summary>
 ///    (Set|Get) This will Delete a row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:195 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will Delete a row in the table.") ]
    Let Delete = 
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

#endregion (Set|Get) This will Delete a row in the table.

#end region 
#region <5> [Function]{7}
#region |2019/07/06 00h51:216| <05.00.00> <Sub> <> |.Open()|Sub}|"' (Set|Get) This will initialise the connection and import the data.
     ///     <Summary>
 ///    (Set|Get) This will initialise the connection and import the data.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:196 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will initialise the connection and import the data.") ]
    Let Open = 
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

#endregion (Set|Get) This will initialise the connection and import the data.

#region |2019/07/06 00h51:237| <05.00.01> <Sub> <> |.Close()|Sub}|"' (Set|Get) This willClosing the connection
     ///     <Summary>
 ///    (Set|Get) This willClosing the connection
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:196 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This willClosing the connection") ]
    Let Close = 
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

#endregion (Set|Get) This willClosing the connection

#region |2019/07/06 00h51:252| <05.00.02> <Sub> <> |.List()|Sub}|"' (Set|Get) Return the entire table listed
     ///     <Summary>
 ///    (Set|Get) Return the entire table listed
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:196 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Return the entire table listed") ]
    Let List = 
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
#endregion (Set|Get) Return the entire table listed

#region |2019/07/06 00h51:270| <05.00.03> <Sub> <> |.SearchByName()|Sub}|"' (Set|Get) Search for each property that match the Search String.
     ///     <Summary>
 ///    (Set|Get) Search for each property that match the Search String.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:196 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Search for each property that match the Search String.") ]
    Let SearchByName = 
    Dim Result As New List(Of Sub)
 Dim C As New Sub
 For Each Element As Sub In C.List
 If Element.Name.Tolower() = Search.Tolower() Or Element.Text.Tolower() = Search.Tolower()  Or Element.ToolTip.Tolower() = Search.Tolower()  Or Element.Status.Tolower() = Search.Tolower()  Or Element.Statement.Tolower() = Search.Tolower()  Or Element.XMLFile.Tolower() = Search.Tolower()  Or Element.Attributes.Tolower() = Search.Tolower()  Or Element.Category.Tolower() = Search.Tolower()  Or Element.Description.Tolower() = Search.Tolower()  Or Element.DefaultValue.Tolower() = Search.Tolower()  Or Element.Editor.Tolower() = Search.Tolower()  Or Element.DllImport.Tolower() = Search.Tolower()  Or Element.XmlRoot.Tolower() = Search.Tolower()  Or Element.RelatedImageList.Tolower() = Search.Tolower()  Or Element.Print_VB.Tolower() = Search.Tolower()  Or Element.VB.Tolower() = Search.Tolower()  Or Element.Print_C.Tolower() = Search.Tolower()  Or Element.C.Tolower() = Search.Tolower()  Or Element.Print_F.Tolower() = Search.Tolower()  Or Element.F.Tolower() = Search.Tolower()  Or Element.Print_Python.Tolower() = Search.Tolower()  Or Element.Python.Tolower() = Search.Tolower()  Or Element.Print_JavaScript.Tolower() = Search.Tolower()  Or Element.JavaScript.Tolower() = Search.Tolower()  Or Element.RegionCode.Tolower() = Search.Tolower()  Or Element.AuthorEmail.Tolower() = Search.Tolower()  Or Element.AuthorName.Tolower() = Search.Tolower()  Or Element.AuthorUri.Tolower() = Search.Tolower()  Or Element.ContributorEmail.Tolower() = Search.Tolower()  Or Element.ContributorName.Tolower() = Search.Tolower()  Or Element.ContributorUri.Tolower() = Search.Tolower()  Or Element.CustomProperty.Tolower() = Search.Tolower()  Or Element.Published.Tolower() = Search.Tolower()  Or Element.Rights.Tolower() = Search.Tolower()  Or Element.Summary.Tolower() = Search.Tolower()  Or Element.Title.Tolower() = Search.Tolower()  Or Element.Updated.Tolower() = Search.Tolower()  Or Element.Usage.Tolower() = Search.Tolower()  Or Element.Remarks.Tolower() = Search.Tolower()  Or Element.Example.Tolower() = Search.Tolower()  Or Element.Note.Tolower() = Search.Tolower()  Or Element.CreationDate.Tolower() = Search.Tolower()  Or Element.See.Tolower() = Search.Tolower()  Or Element.SeeAlso.Tolower() = Search.Tolower()  Or Element.Rules.Tolower() = Search.Tolower()  Or Element.Syntax.Tolower() = Search.Tolower()  Or Element.AccessModifier.Tolower() = Search.Tolower()  Or Element.ProcedureModifier.Tolower() = Search.Tolower()  Or Element.SubName.Tolower() = Search.Tolower()  Or Element.Handles.Tolower() = Search.Tolower()  Or Element.Implements.Tolower() = Search.Tolower() Then
      Result.Add(Element)
 End If
 Next
 Return Result
#endregion (Set|Get) Search for each property that match the Search String.

#region |2019/07/06 00h51:285| <05.00.04> <Sub> <> |.SearchByID()|Sub}|"' (Set|Get) Search for each property that match the Search Id.
     ///     <Summary>
 ///    (Set|Get) Search for each property that match the Search Id.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:197 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Search for each property that match the Search Id.") ]
    Let SearchByID = 
    Dim Result As New List(Of Sub)
 Dim C As New Sub
 For Each Element As Sub In C.List
 If Val(Element.ID) = Search Or Val(Element.ImageIndex) = Search  Or Val(Element.RegionCategory) = Search Then
      Result.Add(Element)
 End If
 Next
 Return Result
#endregion (Set|Get) Search for each property that match the Search Id.

#region |2019/07/06 00h51:300| <05.00.05> <Sub> <> |.ToString()|Sub}|"' (Set|Get) The function ToString.
     ///     <Summary>
 ///    (Set|Get) The function ToString.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:197 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The function ToString.") ]
    Let ToString = 
        Return Me.ID
#endregion (Set|Get) The function ToString.

#region |2019/07/06 00h51:316| <05.00.06> <Sub> <> |.CheckConnection()|Sub}|"' (Set|Get) Evaluate the connection to the DataBase
     ///     <Summary>
 ///    (Set|Get) Evaluate the connection to the DataBase
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:197 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Evaluate the connection to the DataBase") ]
    Let CheckConnection = 
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

#endregion (Set|Get) Evaluate the connection to the DataBase

#end region 
#region <6> [Runtime]{12}
#region |2019/07/06 00h51:331| <15.00.00> <Runtime> <> |.Table()|Runtime|  (Set|Get) The Table.
 ///     <Summary>
 ///    (Set|Get) The Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:197 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Table.") ]
   Public Table Table;
#endregion (Set|Get) The Table.

#region |2019/07/06 00h51:347| <15.00.01> <Runtime> <> |.Line()|Runtime|  (Set|Get) The Connection String To the Table.
 ///     <Summary>
 ///    (Set|Get) The Connection String To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:198 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Connection String To the Table.") ]
   Public String Line;
#endregion (Set|Get) The Connection String To the Table.

#region |2019/07/06 00h51:362| <15.00.02> <Runtime> <> |.FilePath()|Runtime|  (Set|Get) The FilePath To the Table.
 ///     <Summary>
 ///    (Set|Get) The FilePath To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:198 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The FilePath To the Table.") ]
   Public String FilePath;
#endregion (Set|Get) The FilePath To the Table.

#region |2019/07/06 00h51:376| <15.00.03> <Runtime> <> |.Password()|Runtime|  (Set|Get) The Password To the Table.
 ///     <Summary>
 ///    (Set|Get) The Password To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:198 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Password To the Table.") ]
   Public String Password;
#endregion (Set|Get) The Password To the Table.

#region |2019/07/06 00h51:398| <15.00.04> <Runtime> <> |.UseSQL()|Runtime|  (Set|Get) Determines if the Database Connection is of type SQL.
 ///     <Summary>
 ///    (Set|Get) Determines if the Database Connection is of type SQL.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:198 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Determines if the Database Connection is of type SQL.") ]
   Public Boolean UseSQL;
#endregion (Set|Get) Determines if the Database Connection is of type SQL.

#region |2019/07/06 00h51:413| <15.00.05> <Runtime> <> |.TableName()|Runtime|  (Set|Get) The name of the Table.
 ///     <Summary>
 ///    (Set|Get) The name of the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:198 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The name of the Table.") ]
   Public String TableName;
#endregion (Set|Get) The name of the Table.

#region |2019/07/06 00h51:427| <15.00.06> <Runtime> <> |.Con()|Runtime|  (Set|Get) The Con To the Table.
 ///     <Summary>
 ///    (Set|Get) The Con To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:199 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Con To the Table.") ]
   Public OleDb.OleDbConnection Con;
#endregion (Set|Get) The Con To the Table.

#region |2019/07/06 00h51:433| <15.00.07> <Runtime> <> |.Cmd()|Runtime|  (Set|Get) The Cmd To the Table.
 ///     <Summary>
 ///    (Set|Get) The Cmd To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:199 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Cmd To the Table.") ]
   Public OleDb.OleDbCommand Cmd;
#endregion (Set|Get) The Cmd To the Table.

#region |2019/07/06 00h51:447| <15.00.08> <Runtime> <> |.DataReader()|Runtime|  (Set|Get) The DataReader To the Table.
 ///     <Summary>
 ///    (Set|Get) The DataReader To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:199 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The DataReader To the Table.") ]
   Public OleDb.OleDbDataReader DataReader;
#endregion (Set|Get) The DataReader To the Table.

#region |2019/07/06 00h51:461| <15.00.09> <Runtime> <> |.DataAdapter()|Runtime|  (Set|Get) The DataAdapter To the Table.
 ///     <Summary>
 ///    (Set|Get) The DataAdapter To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:199 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The DataAdapter To the Table.") ]
   Public OleDb.OleDbDataAdapter DataAdapter;
#endregion (Set|Get) The DataAdapter To the Table.

#region |2019/07/06 00h51:476| <15.00.10> <Runtime> <> |.Connector()|Runtime|  (Set|Get) The Connector To the Table.
 ///     <Summary>
 ///    (Set|Get) The Connector To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:200 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Connector To the Table.") ]
   Public LineInfo Connector;
#endregion (Set|Get) The Connector To the Table.

#region |2019/07/06 00h51:491| <15.00.11> <Runtime> <> |.Log()|Runtime|  (Set|Get) The Log To the Table.
 ///     <Summary>
 ///    (Set|Get) The Log To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:200 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Log To the Table.") ]
   Public String Log;
#endregion (Set|Get) The Log To the Table.

#end region 
#region <7> [Loader]{2}
#region |2019/07/06 00h51:505| <06.00.00> <Sub> <> |.Empty()|Sub}|"' (Set|Get) The sub Empty.
     ///     <Summary>
 ///    (Set|Get) The sub Empty.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:200 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The sub Empty.") ]
    Let Empty = 
    Reset
#endregion (Set|Get) The sub Empty.

#region |2019/07/06 00h51:509| <06.00.01> <Sub> <> |.Filled()|Sub}|"' (Set|Get) The sub Filled.
     ///     <Summary>
 ///    (Set|Get) The sub Filled.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:200 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The sub Filled.") ]
    Let Filled = 
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

#endregion (Set|Get) The sub Filled.

#end region 
}

 ///     <Summary>
 ///    '''    Object Name :             Public  Class Initializor_ProjectDatabase
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
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:250 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
public  class Initializor_ProjectDatabase{
#region <1> [Property]{14}
#region |2019/07/06 00h51:734| <01.00.00> <Property> <Virtualized Properties> |.Enumeration()|Enumeration|  (Set|Get) 
 ///     <Summary>
 ///    (Set|Get) 
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:251 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Virtualized Properties") , Description("(Set|Get) ") ]
    member this.Enumeration()
       with get() = _Enumeration
       and set(value) = _Enumeration <- value
#endregion (Set|Get) 

#region |2019/07/06 00h51:745| <01.00.01> <Property> <List> |.List_Enumeration()|List(Of Enumeration)|  (Set|Get) 
 ///     <Summary>
 ///    (Set|Get) 
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:251 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("List") , Description("(Set|Get) ") ]
    member this.List_Enumeration()
       with get() = _List_Enumeration
       and set(value) = _List_Enumeration <- value
#endregion (Set|Get) 

#region |2019/07/06 00h51:755| <01.00.02> <Property> <Virtualized Properties> |.Function()|Function|  (Set|Get) 
 ///     <Summary>
 ///    (Set|Get) 
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:251 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Virtualized Properties") , Description("(Set|Get) ") ]
    member this.Function()
       with get() = _Function
       and set(value) = _Function <- value
#endregion (Set|Get) 

#region |2019/07/06 00h51:766| <01.00.03> <Property> <List> |.List_Function()|List(Of Function)|  (Set|Get) 
 ///     <Summary>
 ///    (Set|Get) 
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:252 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("List") , Description("(Set|Get) ") ]
    member this.List_Function()
       with get() = _List_Function
       and set(value) = _List_Function <- value
#endregion (Set|Get) 

#region |2019/07/06 00h51:779| <01.00.04> <Property> <Virtualized Properties> |.Property()|Property|  (Set|Get) 
 ///     <Summary>
 ///    (Set|Get) 
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:253 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Virtualized Properties") , Description("(Set|Get) ") ]
    member this.Property()
       with get() = _Property
       and set(value) = _Property <- value
#endregion (Set|Get) 

#region |2019/07/06 00h51:789| <01.00.05> <Property> <List> |.List_Property()|List(Of Property)|  (Set|Get) 
 ///     <Summary>
 ///    (Set|Get) 
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:256 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("List") , Description("(Set|Get) ") ]
    member this.List_Property()
       with get() = _List_Property
       and set(value) = _List_Property <- value
#endregion (Set|Get) 

#region |2019/07/06 00h51:801| <01.00.06> <Property> <Virtualized Properties> |.Statement()|Statement|  (Set|Get) 
 ///     <Summary>
 ///    (Set|Get) 
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:256 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Virtualized Properties") , Description("(Set|Get) ") ]
    member this.Statement()
       with get() = _Statement
       and set(value) = _Statement <- value
#endregion (Set|Get) 

#region |2019/07/06 00h51:812| <01.00.07> <Property> <List> |.List_Statement()|List(Of Statement)|  (Set|Get) 
 ///     <Summary>
 ///    (Set|Get) 
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:256 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("List") , Description("(Set|Get) ") ]
    member this.List_Statement()
       with get() = _List_Statement
       and set(value) = _List_Statement <- value
#endregion (Set|Get) 

#region |2019/07/06 00h51:823| <01.00.08> <Property> <Virtualized Properties> |.Structure()|Structure|  (Set|Get) 
 ///     <Summary>
 ///    (Set|Get) 
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:256 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Virtualized Properties") , Description("(Set|Get) ") ]
    member this.Structure()
       with get() = _Structure
       and set(value) = _Structure <- value
#endregion (Set|Get) 

#region |2019/07/06 00h51:834| <01.00.09> <Property> <List> |.List_Structure()|List(Of Structure)|  (Set|Get) 
 ///     <Summary>
 ///    (Set|Get) 
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:257 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("List") , Description("(Set|Get) ") ]
    member this.List_Structure()
       with get() = _List_Structure
       and set(value) = _List_Structure <- value
#endregion (Set|Get) 

#region |2019/07/06 00h51:846| <01.00.10> <Property> <Virtualized Properties> |.Sub()|Sub|  (Set|Get) 
 ///     <Summary>
 ///    (Set|Get) 
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:257 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Virtualized Properties") , Description("(Set|Get) ") ]
    member this.Sub()
       with get() = _Sub
       and set(value) = _Sub <- value
#endregion (Set|Get) 

#region |2019/07/06 00h51:856| <01.00.11> <Property> <List> |.List_Sub()|List(Of Sub)|  (Set|Get) 
 ///     <Summary>
 ///    (Set|Get) 
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:257 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("List") , Description("(Set|Get) ") ]
    member this.List_Sub()
       with get() = _List_Sub
       and set(value) = _List_Sub <- value
#endregion (Set|Get) 

#region |2019/07/06 00h51:867| <01.00.12> <Property> <Portfolio> |.Portfolio()|List(Of Object)|  (Set|Get) 
 ///     <Summary>
 ///    (Set|Get) 
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:257 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Portfolio") , Description("(Set|Get) ") ]
    member this.Portfolio()
       with get() = _Portfolio
       and set(value) = _Portfolio <- value
#endregion (Set|Get) 

#region |2019/07/06 00h51:879| <01.00.13> <Property> <DataBase> |.DataBase()|SmartCoder.M_FileManager.DataBase|  (Set|Get) 
 ///     <Summary>
 ///    (Set|Get) 
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:257 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("DataBase") , Description("(Set|Get) ") ]
    member this.DataBase()
       with get() = _DataBase
       and set(value) = _DataBase <- value
#endregion (Set|Get) 

#end region 
#region <4> [Sub]{1}
#region |2019/07/06 00h51:890| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class properties element.
     ///     <Summary>
 ///    (Set|Get) This will reinitialize the class properties element.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:260 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will reinitialize the class properties element.") ]
    Let Clear = 
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
#endregion (Set|Get) This will reinitialize the class properties element.

#end region 
#region <5> [Function]{1}
#region |2019/07/06 00h51:908| <05.00.00> <Sub> <> |.CheckConnection()|Sub}|"' (Set|Get) Evaluate the connection to the DataBase
     ///     <Summary>
 ///    (Set|Get) Evaluate the connection to the DataBase
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:260 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Evaluate the connection to the DataBase") ]
    Let CheckConnection = 
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

#endregion (Set|Get) Evaluate the connection to the DataBase

#end region 
#region <6> [Runtime]{4}
#region |2019/07/06 00h51:922| <15.00.00> <Runtime> <> |.Line()|Runtime|  (Set|Get) The Connection String To the Table.
 ///     <Summary>
 ///    (Set|Get) The Connection String To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:260 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Connection String To the Table.") ]
   Public String Line;
#endregion (Set|Get) The Connection String To the Table.

#region |2019/07/06 00h51:934| <15.00.01> <Runtime> <> |.FilePath()|Runtime|  (Set|Get) The FilePath To the Table.
 ///     <Summary>
 ///    (Set|Get) The FilePath To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:260 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The FilePath To the Table.") ]
   Public String FilePath;
#endregion (Set|Get) The FilePath To the Table.

#region |2019/07/06 00h51:945| <15.00.02> <Runtime> <> |.Password()|Runtime|  (Set|Get) The Password To the Table.
 ///     <Summary>
 ///    (Set|Get) The Password To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:260 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Password To the Table.") ]
   Public String Password;
#endregion (Set|Get) The Password To the Table.

#region |2019/07/06 00h51:957| <15.00.03> <Runtime> <> |.Connector()|Runtime|  (Set|Get) The Connector To the Table.
 ///     <Summary>
 ///    (Set|Get) The Connector To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:260 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Connector To the Table.") ]
   Public LineInfo Connector;
#endregion (Set|Get) The Connector To the Table.

#end region 
#region <7> [Loader]{2}
#region |2019/07/06 00h51:968| <06.00.00> <Sub> <> |.Empty()|Sub}|"' (Set|Get) The sub Empty.
     ///     <Summary>
 ///    (Set|Get) The sub Empty.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:261 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The sub Empty.") ]
    Let Empty = 
    Clear
#endregion (Set|Get) The sub Empty.

#region |2019/07/06 00h51:970| <06.00.01> <Sub> <> |.Filled()|Sub}|"' (Set|Get) The sub Filled.
     ///     <Summary>
 ///    (Set|Get) The sub Filled.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/06 00h53:261 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The sub Filled.") ]
    Let Filled = 
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

#endregion (Set|Get) The sub Filled.

#end region 
}

#end region 
}
