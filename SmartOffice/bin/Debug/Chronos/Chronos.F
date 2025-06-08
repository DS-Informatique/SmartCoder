 ///     <Summary>
 ///    '''    Object Name :             Public  Class Chronos
'''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
'''    Contributor Information : ||
'''    Creation Date :           2019/07/16 23h58:295
'''    |Schema|
'''    |ID| |ObjectType |{Quantity}||UnitPrice||Total
'''    |00| |Importation|{0}||1| |0
'''    |01| |Properties |{107}||0.8| |85.6
'''    |02| |Enumeration|{10}||0.4| |4
'''    |03| |Structure  |{0}||0.4| |0
'''    |04| |Sub        |{51}||1.2| |61.2
'''    |05| |Function   |{73}||1.6| |116.8
'''    |06| |Runtime    |{124}||0.4| |49.6
'''    |07| |Loader     |{22}||0.8| |17.6
'''    |08| |Class      |{11}||2| |22
'''    |09| |Constante  |{0}||0.4| |0
'''    |10| |Event      |{0}||1.2| |0
'''    |11| |Members    |{83}||0.5| |41.5
'''    |12| |Parameter  |{138}||0.5| |69
'''    |Production Cost             |467.3
'''    |Selling Price without VAT   |1168.25
'''    |Total TVA                   |89.96
'''    |Grand Total                 |1258.21
'''    |/Schema|
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:763 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
public  class Chronos{
#region <8> [Class]{11}
 ///     <Summary>
 ///    Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Clients
'''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
'''    Contributor Information : ||
'''    Creation Date :           2019/07/17 00h01:763
'''    |Schema|
'''    |ID| |ObjectType |{Quantity}||UnitPrice||Total
'''    |00| |Importation|{0}||1| |0
'''    |01| |Properties |{23}||0.8| |18.4
'''    |02| |Enumeration|{1}||0.4| |0.4
'''    |03| |Structure  |{0}||0.4| |0
'''    |04| |Sub        |{5}||1.2| |6
'''    |05| |Function   |{7}||1.6| |11.2
'''    |06| |Runtime    |{12}||0.4| |4.8
'''    |07| |Loader     |{2}||0.8| |1.6
'''    |08| |Class      |{0}||2| |0
'''    |09| |Constante  |{0}||0.4| |0
'''    |10| |Event      |{0}||1.2| |0
'''    |11| |Members    |{23}||0.5| |11.5
'''    |12| |Parameter  |{28}||0.5| |14
'''    |Production Cost             |67.9
'''    |Selling Price without VAT   |169.75
'''    |Total TVA                   |13.07
'''    |Grand Total                 |182.82
'''    |/Schema|
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:764 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
public  class Clients{
#region <1> [Property]{23}
#region |2019/07/17 00h01:765| <01.00.00> <Property> <Columns> |.Ref()|String|  (Set|Get) The Ref as String.
 ///     <Summary>
 ///    (Set|Get) The Ref as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:764 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Ref as String.") ]
    member this.Ref()
       with get() = _Ref
       and set(value) = _Ref <- value
#endregion (Set|Get) The Ref as String.

#region |2019/07/17 00h01:000| <01.00.01> <Property> <Columns> |.Active()|Boolean|  (Set|Get) The Active as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Active as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:764 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Active as Boolean.") ]
    member this.Active()
       with get() = _Active
       and set(value) = _Active <- value
#endregion (Set|Get) The Active as Boolean.

#region |2019/07/17 00h01:007| <01.00.02> <Property> <Columns> |.RaisonSociale()|String|  (Set|Get) The RaisonSociale as String.
 ///     <Summary>
 ///    (Set|Get) The RaisonSociale as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:764 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The RaisonSociale as String.") ]
    member this.RaisonSociale()
       with get() = _RaisonSociale
       and set(value) = _RaisonSociale <- value
#endregion (Set|Get) The RaisonSociale as String.

#region |2019/07/17 00h01:014| <01.00.03> <Property> <Columns> |.NomClient()|String|  (Set|Get) The NomClient as String.
 ///     <Summary>
 ///    (Set|Get) The NomClient as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:764 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The NomClient as String.") ]
    member this.NomClient()
       with get() = _NomClient
       and set(value) = _NomClient <- value
#endregion (Set|Get) The NomClient as String.

#region |2019/07/17 00h01:021| <01.00.04> <Property> <Columns> |.Address1()|String|  (Set|Get) The Address1 as String.
 ///     <Summary>
 ///    (Set|Get) The Address1 as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:765 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Address1 as String.") ]
    member this.Address1()
       with get() = _Address1
       and set(value) = _Address1 <- value
#endregion (Set|Get) The Address1 as String.

#region |2019/07/17 00h01:028| <01.00.05> <Property> <Columns> |.Address2()|String|  (Set|Get) The Address2 as String.
 ///     <Summary>
 ///    (Set|Get) The Address2 as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:765 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Address2 as String.") ]
    member this.Address2()
       with get() = _Address2
       and set(value) = _Address2 <- value
#endregion (Set|Get) The Address2 as String.

#region |2019/07/17 00h01:034| <01.00.06> <Property> <Columns> |.PostalCode()|String|  (Set|Get) The PostalCode as String.
 ///     <Summary>
 ///    (Set|Get) The PostalCode as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:765 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The PostalCode as String.") ]
    member this.PostalCode()
       with get() = _PostalCode
       and set(value) = _PostalCode <- value
#endregion (Set|Get) The PostalCode as String.

#region |2019/07/17 00h01:039| <01.00.07> <Property> <Columns> |.Region()|String|  (Set|Get) The Region as String.
 ///     <Summary>
 ///    (Set|Get) The Region as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:765 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Region as String.") ]
    member this.Region()
       with get() = _Region
       and set(value) = _Region <- value
#endregion (Set|Get) The Region as String.

#region |2019/07/17 00h01:045| <01.00.08> <Property> <Columns> |.City()|String|  (Set|Get) The City as String.
 ///     <Summary>
 ///    (Set|Get) The City as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:765 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The City as String.") ]
    member this.City()
       with get() = _City
       and set(value) = _City <- value
#endregion (Set|Get) The City as String.

#region |2019/07/17 00h01:052| <01.00.09> <Property> <Columns> |.Country()|String|  (Set|Get) The Country as String.
 ///     <Summary>
 ///    (Set|Get) The Country as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:766 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Country as String.") ]
    member this.Country()
       with get() = _Country
       and set(value) = _Country <- value
#endregion (Set|Get) The Country as String.

#region |2019/07/17 00h01:058| <01.00.10> <Property> <Columns> |.Landline()|String|  (Set|Get) The Landline as String.
 ///     <Summary>
 ///    (Set|Get) The Landline as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:766 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Landline as String.") ]
    member this.Landline()
       with get() = _Landline
       and set(value) = _Landline <- value
#endregion (Set|Get) The Landline as String.

#region |2019/07/17 00h01:064| <01.00.11> <Property> <Columns> |.Fax()|String|  (Set|Get) The Fax as String.
 ///     <Summary>
 ///    (Set|Get) The Fax as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:770 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Fax as String.") ]
    member this.Fax()
       with get() = _Fax
       and set(value) = _Fax <- value
#endregion (Set|Get) The Fax as String.

#region |2019/07/17 00h01:071| <01.00.12> <Property> <Columns> |.Cell()|String|  (Set|Get) The Cell as String.
 ///     <Summary>
 ///    (Set|Get) The Cell as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:770 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Cell as String.") ]
    member this.Cell()
       with get() = _Cell
       and set(value) = _Cell <- value
#endregion (Set|Get) The Cell as String.

#region |2019/07/17 00h01:077| <01.00.13> <Property> <Columns> |.Email()|String|  (Set|Get) The Email as String.
 ///     <Summary>
 ///    (Set|Get) The Email as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:770 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Email as String.") ]
    member this.Email()
       with get() = _Email
       and set(value) = _Email <- value
#endregion (Set|Get) The Email as String.

#region |2019/07/17 00h01:084| <01.00.14> <Property> <Columns> |.Website()|String|  (Set|Get) The Website as String.
 ///     <Summary>
 ///    (Set|Get) The Website as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:771 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Website as String.") ]
    member this.Website()
       with get() = _Website
       and set(value) = _Website <- value
#endregion (Set|Get) The Website as String.

#region |2019/07/17 00h01:090| <01.00.15> <Property> <Columns> |.Pcompta()|String|  (Set|Get) The Pcompta as String.
 ///     <Summary>
 ///    (Set|Get) The Pcompta as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:771 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Pcompta as String.") ]
    member this.Pcompta()
       with get() = _Pcompta
       and set(value) = _Pcompta <- value
#endregion (Set|Get) The Pcompta as String.

#region |2019/07/17 00h01:096| <01.00.16> <Property> <Columns> |.Other()|String|  (Set|Get) The Other as String.
 ///     <Summary>
 ///    (Set|Get) The Other as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:771 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Other as String.") ]
    member this.Other()
       with get() = _Other
       and set(value) = _Other <- value
#endregion (Set|Get) The Other as String.

#region |2019/07/17 00h01:102| <01.00.17> <Property> <Columns> |.Répertoire()|String|  (Set|Get) The Répertoire as String.
 ///     <Summary>
 ///    (Set|Get) The Répertoire as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:771 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Répertoire as String.") ]
    member this.Répertoire()
       with get() = _Répertoire
       and set(value) = _Répertoire <- value
#endregion (Set|Get) The Répertoire as String.

#region |2019/07/17 00h01:108| <01.00.18> <Property> <Columns> |.Forfait()|Boolean|  (Set|Get) The Forfait as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Forfait as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:771 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Forfait as Boolean.") ]
    member this.Forfait()
       with get() = _Forfait
       and set(value) = _Forfait <- value
#endregion (Set|Get) The Forfait as Boolean.

#region |2019/07/17 00h01:115| <01.00.19> <Property> <Columns> |.ForfaitValue()|Double|  (Set|Get) The ForfaitValue as Double.
 ///     <Summary>
 ///    (Set|Get) The ForfaitValue as Double.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:772 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ForfaitValue as Double.") ]
    member this.ForfaitValue()
       with get() = _ForfaitValue
       and set(value) = _ForfaitValue <- value
#endregion (Set|Get) The ForfaitValue as Double.

#region |2019/07/17 00h01:123| <01.00.20> <Property> <Columns> |.CHE()|String|  (Set|Get) The CHE as String.
 ///     <Summary>
 ///    (Set|Get) The CHE as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:772 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The CHE as String.") ]
    member this.CHE()
       with get() = _CHE
       and set(value) = _CHE <- value
#endregion (Set|Get) The CHE as String.

#region |2019/07/17 00h01:146| <01.00.21> <Property> <Columns> |.IDE()|String|  (Set|Get) The IDE as String.
 ///     <Summary>
 ///    (Set|Get) The IDE as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:772 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The IDE as String.") ]
    member this.IDE()
       with get() = _IDE
       and set(value) = _IDE <- value
#endregion (Set|Get) The IDE as String.

#region |2019/07/17 00h01:154| <01.00.22> <Property> <Columns> |.Zefix()|String|  (Set|Get) The Zefix as String.
 ///     <Summary>
 ///    (Set|Get) The Zefix as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:772 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Zefix as String.") ]
    member this.Zefix()
       with get() = _Zefix
       and set(value) = _Zefix <- value
#endregion (Set|Get) The Zefix as String.

#end region 
#region <2> [Enumeration]{1}
#region |2019/07/17 00h01:163| <02.00.00> <Property> <> |.Schema()|Enumeration{22}|"' (Set|Get) The enumeration of Schema.
     ///     <Summary>
 ///    (Set|Get) The enumeration of Schema.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:772 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The enumeration of Schema.") ]
    Type Schema = 
/// <summary>(Set|Get) The Ref as String.</summary>
|   [Ref] = 0
/// <summary>(Set|Get) The Active as Boolean.</summary>
|   [Active] = 1
/// <summary>(Set|Get) The RaisonSociale as String.</summary>
|   [RaisonSociale] = 2
/// <summary>(Set|Get) The NomClient as String.</summary>
|   [NomClient] = 3
/// <summary>(Set|Get) The Address1 as String.</summary>
|   [Address1] = 4
/// <summary>(Set|Get) The Address2 as String.</summary>
|   [Address2] = 5
/// <summary>(Set|Get) The PostalCode as String.</summary>
|   [PostalCode] = 6
/// <summary>(Set|Get) The Region as String.</summary>
|   [Region] = 7
/// <summary>(Set|Get) The City as String.</summary>
|   [City] = 8
/// <summary>(Set|Get) The Country as String.</summary>
|   [Country] = 9
/// <summary>(Set|Get) The Landline as String.</summary>
|   [Landline] = 10
/// <summary>(Set|Get) The Fax as String.</summary>
|   [Fax] = 11
/// <summary>(Set|Get) The Cell as String.</summary>
|   [Cell] = 12
/// <summary>(Set|Get) The Email as String.</summary>
|   [Email] = 13
/// <summary>(Set|Get) The Website as String.</summary>
|   [Website] = 14
/// <summary>(Set|Get) The Pcompta as String.</summary>
|   [Pcompta] = 15
/// <summary>(Set|Get) The Other as String.</summary>
|   [Other] = 16
/// <summary>(Set|Get) The Répertoire as String.</summary>
|   [Répertoire] = 17
/// <summary>(Set|Get) The Forfait as Boolean.</summary>
|   [Forfait] = 18
/// <summary>(Set|Get) The ForfaitValue as Double.</summary>
|   [ForfaitValue] = 19
/// <summary>(Set|Get) The CHE as String.</summary>
|   [CHE] = 20
/// <summary>(Set|Get) The IDE as String.</summary>
|   [IDE] = 21
/// <summary>(Set|Get) The Zefix as String.</summary>
|   [Zefix] = 22
#endregion (Set|Get) The enumeration of Schema.

#end region 
#region <4> [Sub]{5}
#region |2019/07/17 00h01:264| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
     ///     <Summary>
 ///    (Set|Get) This will reinitialize the class element.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:773 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will reinitialize the class element.") ]
    Let Clear = 
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
#endregion (Set|Get) This will reinitialize the class element.

#region |2019/07/17 00h01:400| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
     ///     <Summary>
 ///    (Set|Get) This will reinitialize the variables of this class.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:773 </Published>
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
        TableName = "Clients"
        Line = Connector.Line
        UseSQL = False
   Else
        FilePath = My.Settings.Db_Chronos_FilePath
        Password = My.Settings.Db_Chronos_Password
        Me.Line = My.Settings.Db_Chronos_Line
        TableName = "Clients"
        UseSQL = False
   End If
Else
        If IsNothing(FilePath) Then 
             FilePath = My.Settings.Db_Chronos_FilePath
        End If 
        If FilePath.Length<1 Then 
             FilePath = My.Settings.Db_Chronos_FilePath
        End If 
        FilePath = My.Settings.Db_Chronos_FilePath
        Password = My.Settings.Db_Chronos_Password
        Me.Line = My.Settings.Db_Chronos_Line
        TableName = "Clients"
        UseSQL = False
End If

#endregion (Set|Get) This will reinitialize the variables of this class.

#region |2019/07/17 00h01:425| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
     ///     <Summary>
 ///    (Set|Get) This will add a new row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:773 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will add a new row in the table.") ]
    Let Add = 
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
Cmd = New OleDb.OleDbCommand(Str,Con)
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
          If Cmd.ExecuteNonQuery>=0 Then
          Else
              Msgbox("Element not Addd")
          End If
 Catch ex As Exception 
 Finally 
   Close(True) 
 End Try 

#endregion (Set|Get) This will add a new row in the table.

#region |2019/07/17 00h01:436| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
     ///     <Summary>
 ///    (Set|Get) This will update a row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:773 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will update a row in the table.") ]
    Let Save = 
     Try
   Dim Str As String = Nothing
   Str = "UPDATE [Clients] SET Active = @Active, RaisonSociale = @RaisonSociale, NomClient = @NomClient, Address1 = @Address1, Address2 = @Address2, PostalCode = @PostalCode, Region = @Region, City = @City, Country = @Country, Landline = @Landline, Fax = @Fax, Cell = @Cell, Email = @Email, Website = @Website, Pcompta = @Pcompta, Other = @Other, Répertoire = @Répertoire, Forfait = @Forfait, ForfaitValue = @ForfaitValue, CHE = @CHE, IDE = @IDE, Zefix = @Zefix WHERE Ref = @Ref"
Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
Cmd = New OleDb.OleDbCommand(Str,Con)
Con.Open()
      Cmd.Parameters.AddWithValue("@Active",Active)
      Cmd.Parameters.AddWithValue("@RaisonSociale",RaisonSociale)
      Cmd.Parameters.AddWithValue("@NomClient",NomClient)
      Cmd.Parameters.AddWithValue("@Address1",Address1)
      Cmd.Parameters.AddWithValue("@Address2",Address2)
      Cmd.Parameters.AddWithValue("@PostalCode",PostalCode)
      Cmd.Parameters.AddWithValue("@Region",Region)
      Cmd.Parameters.AddWithValue("@City",City)
      Cmd.Parameters.AddWithValue("@Country",Country)
      Cmd.Parameters.AddWithValue("@Landline",Landline)
      Cmd.Parameters.AddWithValue("@Fax",Fax)
      Cmd.Parameters.AddWithValue("@Cell",Cell)
      Cmd.Parameters.AddWithValue("@Email",Email)
      Cmd.Parameters.AddWithValue("@Website",Website)
      Cmd.Parameters.AddWithValue("@Pcompta",Pcompta)
      Cmd.Parameters.AddWithValue("@Other",Other)
      Cmd.Parameters.AddWithValue("@Répertoire",Répertoire)
      Cmd.Parameters.AddWithValue("@Forfait",Forfait)
      Cmd.Parameters.AddWithValue("@ForfaitValue",ForfaitValue)
      Cmd.Parameters.AddWithValue("@CHE",CHE)
      Cmd.Parameters.AddWithValue("@IDE",IDE)
      Cmd.Parameters.AddWithValue("@Zefix",Zefix)
      Cmd.Parameters.AddWithValue("@Ref",Ref)
          If Cmd.ExecuteNonQuery>=0 Then
          Else
              Msgbox("Element not Saved")
          End If
 Catch ex As Exception 
 Finally 
   Close(True) 
 End Try 

#endregion (Set|Get) This will update a row in the table.

#region |2019/07/17 00h01:447| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
     ///     <Summary>
 ///    (Set|Get) This will Delete a row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:773 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will Delete a row in the table.") ]
    Let Delete = 
     Try
   Dim Str As String = Nothing
   Str = "Delete From [Clients] WHERE Ref =@Ref"
Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
Cmd = New OleDb.OleDbCommand(Str,Con)
Con.Open()
Cmd.Parameters.AddWithValue("@Ref", Ref)
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
#region |2019/07/17 00h01:458| <05.00.00> <Sub> <> |.Open()|Sub}|"' (Set|Get) This will initialise the connection and import the data.
     ///     <Summary>
 ///    (Set|Get) This will initialise the connection and import the data.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:773 </Published>
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

#region |2019/07/17 00h01:601| <05.00.01> <Sub> <> |.Close()|Sub}|"' (Set|Get) This willClosing the connection
     ///     <Summary>
 ///    (Set|Get) This willClosing the connection
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:773 </Published>
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

#region |2019/07/17 00h01:610| <05.00.02> <Sub> <> |.List()|Sub}|"' (Set|Get) Return the entire table listed
     ///     <Summary>
 ///    (Set|Get) Return the entire table listed
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:774 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Return the entire table listed") ]
    Let List = 
    Dim Result As New List(Of Clients)
Me.Table = New Table(Me.TableName , Me.FilePath , Me.Password,False)
   For each Row As DataRow In Me.Table.DataTable.Rows
      Dim Element As New Clients(IIf(IsDBNull(Row.Item(0)),"",Row.Item(0)),
IIf(IsDBNull(Row.Item(1)),False,Row.Item(1)),
IIf(IsDBNull(Row.Item(2)),"",Row.Item(2)),
IIf(IsDBNull(Row.Item(3)),"",Row.Item(3)),
IIf(IsDBNull(Row.Item(4)),"",Row.Item(4)),
IIf(IsDBNull(Row.Item(5)),"",Row.Item(5)),
IIf(IsDBNull(Row.Item(6)),"",Row.Item(6)),
IIf(IsDBNull(Row.Item(7)),"",Row.Item(7)),
IIf(IsDBNull(Row.Item(8)),"",Row.Item(8)),
IIf(IsDBNull(Row.Item(9)),"",Row.Item(9)),
IIf(IsDBNull(Row.Item(10)),"",Row.Item(10)),
IIf(IsDBNull(Row.Item(11)),"",Row.Item(11)),
IIf(IsDBNull(Row.Item(12)),"",Row.Item(12)),
IIf(IsDBNull(Row.Item(13)),"",Row.Item(13)),
IIf(IsDBNull(Row.Item(14)),"",Row.Item(14)),
IIf(IsDBNull(Row.Item(15)),"",Row.Item(15)),
IIf(IsDBNull(Row.Item(16)),"",Row.Item(16)),
IIf(IsDBNull(Row.Item(17)),"",Row.Item(17)),
IIf(IsDBNull(Row.Item(18)),False,Row.Item(18)),
IIf(IsDBNull(Row.Item(19)),0,Row.Item(19)),
IIf(IsDBNull(Row.Item(20)),"",Row.Item(20)),
IIf(IsDBNull(Row.Item(21)),"",Row.Item(21)),
      IIf(IsDBNull(Row.Item(22)),"",Row.Item(22)))
      Element.Reset(Table.Line)
 Result.Add(Element)
 Next
 Return Result
#endregion (Set|Get) Return the entire table listed

#region |2019/07/17 00h01:618| <05.00.03> <Sub> <> |.SearchByName()|Sub}|"' (Set|Get) Search for each property that match the Search String.
     ///     <Summary>
 ///    (Set|Get) Search for each property that match the Search String.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:774 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Search for each property that match the Search String.") ]
    Let SearchByName = 
    Dim Result As New List(Of Clients)
 Dim C As New Clients
 For Each Element As Clients In C.List
 If Element.Ref.Tolower() = Search.Tolower() Or Element.RaisonSociale.Tolower() = Search.Tolower()  Or Element.NomClient.Tolower() = Search.Tolower()  Or Element.Address1.Tolower() = Search.Tolower()  Or Element.Address2.Tolower() = Search.Tolower()  Or Element.PostalCode.Tolower() = Search.Tolower()  Or Element.Region.Tolower() = Search.Tolower()  Or Element.City.Tolower() = Search.Tolower()  Or Element.Country.Tolower() = Search.Tolower()  Or Element.Landline.Tolower() = Search.Tolower()  Or Element.Fax.Tolower() = Search.Tolower()  Or Element.Cell.Tolower() = Search.Tolower()  Or Element.Email.Tolower() = Search.Tolower()  Or Element.Website.Tolower() = Search.Tolower()  Or Element.Pcompta.Tolower() = Search.Tolower()  Or Element.Other.Tolower() = Search.Tolower()  Or Element.Répertoire.Tolower() = Search.Tolower()  Or Element.CHE.Tolower() = Search.Tolower()  Or Element.IDE.Tolower() = Search.Tolower()  Or Element.Zefix.Tolower() = Search.Tolower() Then
      Result.Add(Element)
 End If
 Next
 Return Result
#endregion (Set|Get) Search for each property that match the Search String.

#region |2019/07/17 00h01:625| <05.00.04> <Sub> <> |.SearchByID()|Sub}|"' (Set|Get) Search for each property that match the Search Id.
     ///     <Summary>
 ///    (Set|Get) Search for each property that match the Search Id.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:774 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Search for each property that match the Search Id.") ]
    Let SearchByID = 
    Dim Result As New List(Of Clients)
 Dim C As New Clients
 For Each Element As Clients In C.List
 If Val(Element.Ref) = Search Then
      Result.Add(Element)
 End If
 Next
 Return Result
#endregion (Set|Get) Search for each property that match the Search Id.

#region |2019/07/17 00h01:633| <05.00.05> <Sub> <> |.ToString()|Sub}|"' (Set|Get) The function ToString.
     ///     <Summary>
 ///    (Set|Get) The function ToString.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:774 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The function ToString.") ]
    Let ToString = 
        Return Me.Ref
#endregion (Set|Get) The function ToString.

#region |2019/07/17 00h01:641| <05.00.06> <Sub> <> |.CheckConnection()|Sub}|"' (Set|Get) Evaluate the connection to the DataBase
     ///     <Summary>
 ///    (Set|Get) Evaluate the connection to the DataBase
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:774 </Published>
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
#region |2019/07/17 00h01:650| <15.00.00> <Runtime> <> |.Table()|Runtime|  (Set|Get) The Table.
 ///     <Summary>
 ///    (Set|Get) The Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:775 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Table.") ]
   Public Table Table;
#endregion (Set|Get) The Table.

#region |2019/07/17 00h01:773| <15.00.01> <Runtime> <> |.Line()|Runtime|  (Set|Get) The Connection String To the Table.
 ///     <Summary>
 ///    (Set|Get) The Connection String To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:775 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Connection String To the Table.") ]
   Public String Line;
#endregion (Set|Get) The Connection String To the Table.

#region |2019/07/17 00h01:780| <15.00.02> <Runtime> <> |.FilePath()|Runtime|  (Set|Get) The FilePath To the Table.
 ///     <Summary>
 ///    (Set|Get) The FilePath To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:775 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The FilePath To the Table.") ]
   Public String FilePath;
#endregion (Set|Get) The FilePath To the Table.

#region |2019/07/17 00h01:786| <15.00.03> <Runtime> <> |.Password()|Runtime|  (Set|Get) The Password To the Table.
 ///     <Summary>
 ///    (Set|Get) The Password To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:775 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Password To the Table.") ]
   Public String Password;
#endregion (Set|Get) The Password To the Table.

#region |2019/07/17 00h01:794| <15.00.04> <Runtime> <> |.UseSQL()|Runtime|  (Set|Get) Determines if the Database Connection is of type SQL.
 ///     <Summary>
 ///    (Set|Get) Determines if the Database Connection is of type SQL.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:775 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Determines if the Database Connection is of type SQL.") ]
   Public Boolean UseSQL;
#endregion (Set|Get) Determines if the Database Connection is of type SQL.

#region |2019/07/17 00h01:801| <15.00.05> <Runtime> <> |.TableName()|Runtime|  (Set|Get) The name of the Table.
 ///     <Summary>
 ///    (Set|Get) The name of the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:775 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The name of the Table.") ]
   Public String TableName;
#endregion (Set|Get) The name of the Table.

#region |2019/07/17 00h01:807| <15.00.06> <Runtime> <> |.Con()|Runtime|  (Set|Get) The Con To the Table.
 ///     <Summary>
 ///    (Set|Get) The Con To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:776 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Con To the Table.") ]
   Public OleDb.OleDbConnection Con;
#endregion (Set|Get) The Con To the Table.

#region |2019/07/17 00h01:812| <15.00.07> <Runtime> <> |.Cmd()|Runtime|  (Set|Get) The Cmd To the Table.
 ///     <Summary>
 ///    (Set|Get) The Cmd To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:776 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Cmd To the Table.") ]
   Public OleDb.OleDbCommand Cmd;
#endregion (Set|Get) The Cmd To the Table.

#region |2019/07/17 00h01:820| <15.00.08> <Runtime> <> |.DataReader()|Runtime|  (Set|Get) The DataReader To the Table.
 ///     <Summary>
 ///    (Set|Get) The DataReader To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:776 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The DataReader To the Table.") ]
   Public OleDb.OleDbDataReader DataReader;
#endregion (Set|Get) The DataReader To the Table.

#region |2019/07/17 00h01:833| <15.00.09> <Runtime> <> |.DataAdapter()|Runtime|  (Set|Get) The DataAdapter To the Table.
 ///     <Summary>
 ///    (Set|Get) The DataAdapter To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:776 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The DataAdapter To the Table.") ]
   Public OleDb.OleDbDataAdapter DataAdapter;
#endregion (Set|Get) The DataAdapter To the Table.

#region |2019/07/17 00h01:849| <15.00.10> <Runtime> <> |.Connector()|Runtime|  (Set|Get) The Connector To the Table.
 ///     <Summary>
 ///    (Set|Get) The Connector To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:776 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Connector To the Table.") ]
   Public LineInfo Connector;
#endregion (Set|Get) The Connector To the Table.

#region |2019/07/17 00h01:856| <15.00.11> <Runtime> <> |.Log()|Runtime|  (Set|Get) The Log To the Table.
 ///     <Summary>
 ///    (Set|Get) The Log To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:777 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Log To the Table.") ]
   Public String Log;
#endregion (Set|Get) The Log To the Table.

#end region 
#region <7> [Loader]{2}
#region |2019/07/17 00h01:865| <06.00.00> <Sub> <> |.Empty()|Sub}|"' (Set|Get) The sub Empty.
     ///     <Summary>
 ///    (Set|Get) The sub Empty.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:777 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The sub Empty.") ]
    Let Empty = 
    Reset
#endregion (Set|Get) The sub Empty.

#region |2019/07/17 00h01:877| <06.00.01> <Sub> <> |.Filled()|Sub}|"' (Set|Get) The sub Filled.
     ///     <Summary>
 ///    (Set|Get) The sub Filled.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:777 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The sub Filled.") ]
    Let Filled = 
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

#endregion (Set|Get) The sub Filled.

#end region 
}

 ///     <Summary>
 ///    Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Collaborateur
'''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
'''    Contributor Information : ||
'''    Creation Date :           2019/07/17 00h01:081
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
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:788 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
public  class Collaborateur{
#region <1> [Property]{6}
#region |2019/07/17 00h01:083| <01.00.00> <Property> <Columns> |.Ref()|String|  (Set|Get) The Ref as String.
 ///     <Summary>
 ///    (Set|Get) The Ref as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:789 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Ref as String.") ]
    member this.Ref()
       with get() = _Ref
       and set(value) = _Ref <- value
#endregion (Set|Get) The Ref as String.

#region |2019/07/17 00h01:094| <01.00.01> <Property> <Columns> |.FirstName()|String|  (Set|Get) The FirstName as String.
 ///     <Summary>
 ///    (Set|Get) The FirstName as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:789 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The FirstName as String.") ]
    member this.FirstName()
       with get() = _FirstName
       and set(value) = _FirstName <- value
#endregion (Set|Get) The FirstName as String.

#region |2019/07/17 00h01:103| <01.00.02> <Property> <Columns> |.LastName()|String|  (Set|Get) The LastName as String.
 ///     <Summary>
 ///    (Set|Get) The LastName as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:789 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The LastName as String.") ]
    member this.LastName()
       with get() = _LastName
       and set(value) = _LastName <- value
#endregion (Set|Get) The LastName as String.

#region |2019/07/17 00h01:112| <01.00.03> <Property> <Columns> |.Active()|Boolean|  (Set|Get) The Active as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Active as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:789 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Active as Boolean.") ]
    member this.Active()
       with get() = _Active
       and set(value) = _Active <- value
#endregion (Set|Get) The Active as Boolean.

#region |2019/07/17 00h01:118| <01.00.04> <Property> <Columns> |.Tarif_Min()|Double|  (Set|Get) The Tarif_Min as Double.
 ///     <Summary>
 ///    (Set|Get) The Tarif_Min as Double.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:789 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Tarif_Min as Double.") ]
    member this.Tarif_Min()
       with get() = _Tarif_Min
       and set(value) = _Tarif_Min <- value
#endregion (Set|Get) The Tarif_Min as Double.

#region |2019/07/17 00h01:124| <01.00.05> <Property> <Columns> |.Tarif_Max()|Double|  (Set|Get) The Tarif_Max as Double.
 ///     <Summary>
 ///    (Set|Get) The Tarif_Max as Double.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:790 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Tarif_Max as Double.") ]
    member this.Tarif_Max()
       with get() = _Tarif_Max
       and set(value) = _Tarif_Max <- value
#endregion (Set|Get) The Tarif_Max as Double.

#end region 
#region <2> [Enumeration]{1}
#region |2019/07/17 00h01:130| <02.00.00> <Property> <> |.Schema()|Enumeration{5}|"' (Set|Get) The enumeration of Schema.
     ///     <Summary>
 ///    (Set|Get) The enumeration of Schema.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:790 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The enumeration of Schema.") ]
    Type Schema = 
/// <summary>(Set|Get) The Ref as String.</summary>
|   [Ref] = 0
/// <summary>(Set|Get) The FirstName as String.</summary>
|   [FirstName] = 1
/// <summary>(Set|Get) The LastName as String.</summary>
|   [LastName] = 2
/// <summary>(Set|Get) The Active as Boolean.</summary>
|   [Active] = 3
/// <summary>(Set|Get) The Tarif_Min as Double.</summary>
|   [Tarif_Min] = 4
/// <summary>(Set|Get) The Tarif_Max as Double.</summary>
|   [Tarif_Max] = 5
#endregion (Set|Get) The enumeration of Schema.

#end region 
#region <4> [Sub]{5}
#region |2019/07/17 00h01:135| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
     ///     <Summary>
 ///    (Set|Get) This will reinitialize the class element.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:790 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will reinitialize the class element.") ]
    Let Clear = 
      With Me
        .Ref = Nothing
        .FirstName = Nothing
        .LastName = Nothing
        .Active = False
        .Tarif_Min = 0
        .Tarif_Max = 0
 End With
#endregion (Set|Get) This will reinitialize the class element.

#region |2019/07/17 00h01:142| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
     ///     <Summary>
 ///    (Set|Get) This will reinitialize the variables of this class.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:790 </Published>
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
        TableName = "Collaborateur"
        Line = Connector.Line
        UseSQL = False
   Else
        FilePath = My.Settings.Db_Chronos_FilePath
        Password = My.Settings.Db_Chronos_Password
        Me.Line = My.Settings.Db_Chronos_Line
        TableName = "Collaborateur"
        UseSQL = False
   End If
Else
        If IsNothing(FilePath) Then 
             FilePath = My.Settings.Db_Chronos_FilePath
        End If 
        If FilePath.Length<1 Then 
             FilePath = My.Settings.Db_Chronos_FilePath
        End If 
        FilePath = My.Settings.Db_Chronos_FilePath
        Password = My.Settings.Db_Chronos_Password
        Me.Line = My.Settings.Db_Chronos_Line
        TableName = "Collaborateur"
        UseSQL = False
End If

#endregion (Set|Get) This will reinitialize the variables of this class.

#region |2019/07/17 00h01:147| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
     ///     <Summary>
 ///    (Set|Get) This will add a new row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:790 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will add a new row in the table.") ]
    Let Add = 
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
Cmd = New OleDb.OleDbCommand(Str,Con)
Con.Open()
            Cmd.Parameters.AddWithValue("@0", Me.Ref)
            Cmd.Parameters.AddWithValue("@1", Me.FirstName)
            Cmd.Parameters.AddWithValue("@2", Me.LastName)
            Cmd.Parameters.AddWithValue("@3", Me.Active)
            Cmd.Parameters.AddWithValue("@4", Me.Tarif_Min)
            Cmd.Parameters.AddWithValue("@5", Me.Tarif_Max)
          If Cmd.ExecuteNonQuery>=0 Then
          Else
              Msgbox("Element not Addd")
          End If
 Catch ex As Exception 
 Finally 
   Close(True) 
 End Try 

#endregion (Set|Get) This will add a new row in the table.

#region |2019/07/17 00h01:151| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
     ///     <Summary>
 ///    (Set|Get) This will update a row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:790 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will update a row in the table.") ]
    Let Save = 
     Try
   Dim Str As String = Nothing
   Str = "UPDATE [Collaborateur] SET FirstName = @FirstName, LastName = @LastName, Active = @Active, Tarif_Min = @Tarif_Min, Tarif_Max = @Tarif_Max WHERE Ref = @Ref"
Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
Cmd = New OleDb.OleDbCommand(Str,Con)
Con.Open()
      Cmd.Parameters.AddWithValue("@FirstName",FirstName)
      Cmd.Parameters.AddWithValue("@LastName",LastName)
      Cmd.Parameters.AddWithValue("@Active",Active)
      Cmd.Parameters.AddWithValue("@Tarif_Min",Tarif_Min)
      Cmd.Parameters.AddWithValue("@Tarif_Max",Tarif_Max)
      Cmd.Parameters.AddWithValue("@Ref",Ref)
          If Cmd.ExecuteNonQuery>=0 Then
          Else
              Msgbox("Element not Saved")
          End If
 Catch ex As Exception 
 Finally 
   Close(True) 
 End Try 

#endregion (Set|Get) This will update a row in the table.

#region |2019/07/17 00h01:156| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
     ///     <Summary>
 ///    (Set|Get) This will Delete a row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:790 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will Delete a row in the table.") ]
    Let Delete = 
     Try
   Dim Str As String = Nothing
   Str = "Delete From [Collaborateur] WHERE Ref =@Ref"
Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
Cmd = New OleDb.OleDbCommand(Str,Con)
Con.Open()
Cmd.Parameters.AddWithValue("@Ref", Ref)
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
#region |2019/07/17 00h01:161| <05.00.00> <Sub> <> |.Open()|Sub}|"' (Set|Get) This will initialise the connection and import the data.
     ///     <Summary>
 ///    (Set|Get) This will initialise the connection and import the data.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:791 </Published>
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

#region |2019/07/17 00h01:166| <05.00.01> <Sub> <> |.Close()|Sub}|"' (Set|Get) This willClosing the connection
     ///     <Summary>
 ///    (Set|Get) This willClosing the connection
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:791 </Published>
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

#region |2019/07/17 00h01:192| <05.00.02> <Sub> <> |.List()|Sub}|"' (Set|Get) Return the entire table listed
     ///     <Summary>
 ///    (Set|Get) Return the entire table listed
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:791 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Return the entire table listed") ]
    Let List = 
    Dim Result As New List(Of Collaborateur)
Me.Table = New Table(Me.TableName , Me.FilePath , Me.Password,False)
   For each Row As DataRow In Me.Table.DataTable.Rows
      Dim Element As New Collaborateur(IIf(IsDBNull(Row.Item(0)),"",Row.Item(0)),
IIf(IsDBNull(Row.Item(1)),"",Row.Item(1)),
IIf(IsDBNull(Row.Item(2)),"",Row.Item(2)),
IIf(IsDBNull(Row.Item(3)),False,Row.Item(3)),
IIf(IsDBNull(Row.Item(4)),0,Row.Item(4)),
      IIf(IsDBNull(Row.Item(5)),0,Row.Item(5)))
      Element.Reset(Table.Line)
 Result.Add(Element)
 Next
 Return Result
#endregion (Set|Get) Return the entire table listed

#region |2019/07/17 00h01:197| <05.00.03> <Sub> <> |.SearchByName()|Sub}|"' (Set|Get) Search for each property that match the Search String.
     ///     <Summary>
 ///    (Set|Get) Search for each property that match the Search String.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:791 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Search for each property that match the Search String.") ]
    Let SearchByName = 
    Dim Result As New List(Of Collaborateur)
 Dim C As New Collaborateur
 For Each Element As Collaborateur In C.List
 If Element.Ref.Tolower() = Search.Tolower() Or Element.FirstName.Tolower() = Search.Tolower()  Or Element.LastName.Tolower() = Search.Tolower() Then
      Result.Add(Element)
 End If
 Next
 Return Result
#endregion (Set|Get) Search for each property that match the Search String.

#region |2019/07/17 00h01:202| <05.00.04> <Sub> <> |.SearchByID()|Sub}|"' (Set|Get) Search for each property that match the Search Id.
     ///     <Summary>
 ///    (Set|Get) Search for each property that match the Search Id.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:792 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Search for each property that match the Search Id.") ]
    Let SearchByID = 
    Dim Result As New List(Of Collaborateur)
 Dim C As New Collaborateur
 For Each Element As Collaborateur In C.List
 If Val(Element.Tarif_Min) = Search Or Val(Element.Tarif_Max) = Search Then
      Result.Add(Element)
 End If
 Next
 Return Result
#endregion (Set|Get) Search for each property that match the Search Id.

#region |2019/07/17 00h01:208| <05.00.05> <Sub> <> |.ToString()|Sub}|"' (Set|Get) The function ToString.
     ///     <Summary>
 ///    (Set|Get) The function ToString.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:792 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The function ToString.") ]
    Let ToString = 
        Return Me.Ref
#endregion (Set|Get) The function ToString.

#region |2019/07/17 00h01:213| <05.00.06> <Sub> <> |.CheckConnection()|Sub}|"' (Set|Get) Evaluate the connection to the DataBase
     ///     <Summary>
 ///    (Set|Get) Evaluate the connection to the DataBase
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:792 </Published>
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
#region |2019/07/17 00h01:218| <15.00.00> <Runtime> <> |.Table()|Runtime|  (Set|Get) The Table.
 ///     <Summary>
 ///    (Set|Get) The Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:792 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Table.") ]
   Public Table Table;
#endregion (Set|Get) The Table.

#region |2019/07/17 00h01:224| <15.00.01> <Runtime> <> |.Line()|Runtime|  (Set|Get) The Connection String To the Table.
 ///     <Summary>
 ///    (Set|Get) The Connection String To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:792 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Connection String To the Table.") ]
   Public String Line;
#endregion (Set|Get) The Connection String To the Table.

#region |2019/07/17 00h01:230| <15.00.02> <Runtime> <> |.FilePath()|Runtime|  (Set|Get) The FilePath To the Table.
 ///     <Summary>
 ///    (Set|Get) The FilePath To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:793 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The FilePath To the Table.") ]
   Public String FilePath;
#endregion (Set|Get) The FilePath To the Table.

#region |2019/07/17 00h01:235| <15.00.03> <Runtime> <> |.Password()|Runtime|  (Set|Get) The Password To the Table.
 ///     <Summary>
 ///    (Set|Get) The Password To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:793 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Password To the Table.") ]
   Public String Password;
#endregion (Set|Get) The Password To the Table.

#region |2019/07/17 00h01:241| <15.00.04> <Runtime> <> |.UseSQL()|Runtime|  (Set|Get) Determines if the Database Connection is of type SQL.
 ///     <Summary>
 ///    (Set|Get) Determines if the Database Connection is of type SQL.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:794 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Determines if the Database Connection is of type SQL.") ]
   Public Boolean UseSQL;
#endregion (Set|Get) Determines if the Database Connection is of type SQL.

#region |2019/07/17 00h01:247| <15.00.05> <Runtime> <> |.TableName()|Runtime|  (Set|Get) The name of the Table.
 ///     <Summary>
 ///    (Set|Get) The name of the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:794 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The name of the Table.") ]
   Public String TableName;
#endregion (Set|Get) The name of the Table.

#region |2019/07/17 00h01:255| <15.00.06> <Runtime> <> |.Con()|Runtime|  (Set|Get) The Con To the Table.
 ///     <Summary>
 ///    (Set|Get) The Con To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:794 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Con To the Table.") ]
   Public OleDb.OleDbConnection Con;
#endregion (Set|Get) The Con To the Table.

#region |2019/07/17 00h01:262| <15.00.07> <Runtime> <> |.Cmd()|Runtime|  (Set|Get) The Cmd To the Table.
 ///     <Summary>
 ///    (Set|Get) The Cmd To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:794 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Cmd To the Table.") ]
   Public OleDb.OleDbCommand Cmd;
#endregion (Set|Get) The Cmd To the Table.

#region |2019/07/17 00h01:269| <15.00.08> <Runtime> <> |.DataReader()|Runtime|  (Set|Get) The DataReader To the Table.
 ///     <Summary>
 ///    (Set|Get) The DataReader To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:795 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The DataReader To the Table.") ]
   Public OleDb.OleDbDataReader DataReader;
#endregion (Set|Get) The DataReader To the Table.

#region |2019/07/17 00h01:284| <15.00.09> <Runtime> <> |.DataAdapter()|Runtime|  (Set|Get) The DataAdapter To the Table.
 ///     <Summary>
 ///    (Set|Get) The DataAdapter To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:795 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The DataAdapter To the Table.") ]
   Public OleDb.OleDbDataAdapter DataAdapter;
#endregion (Set|Get) The DataAdapter To the Table.

#region |2019/07/17 00h01:291| <15.00.10> <Runtime> <> |.Connector()|Runtime|  (Set|Get) The Connector To the Table.
 ///     <Summary>
 ///    (Set|Get) The Connector To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:795 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Connector To the Table.") ]
   Public LineInfo Connector;
#endregion (Set|Get) The Connector To the Table.

#region |2019/07/17 00h01:297| <15.00.11> <Runtime> <> |.Log()|Runtime|  (Set|Get) The Log To the Table.
 ///     <Summary>
 ///    (Set|Get) The Log To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:795 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Log To the Table.") ]
   Public String Log;
#endregion (Set|Get) The Log To the Table.

#end region 
#region <7> [Loader]{2}
#region |2019/07/17 00h01:307| <06.00.00> <Sub> <> |.Empty()|Sub}|"' (Set|Get) The sub Empty.
     ///     <Summary>
 ///    (Set|Get) The sub Empty.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:795 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The sub Empty.") ]
    Let Empty = 
    Reset
#endregion (Set|Get) The sub Empty.

#region |2019/07/17 00h01:310| <06.00.01> <Sub> <> |.Filled()|Sub}|"' (Set|Get) The sub Filled.
     ///     <Summary>
 ///    (Set|Get) The sub Filled.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:795 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The sub Filled.") ]
    Let Filled = 
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

#endregion (Set|Get) The sub Filled.

#end region 
}

 ///     <Summary>
 ///    Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Factures
'''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
'''    Contributor Information : ||
'''    Creation Date :           2019/07/17 00h01:387
'''    |Schema|
'''    |ID| |ObjectType |{Quantity}||UnitPrice||Total
'''    |00| |Importation|{0}||1| |0
'''    |01| |Properties |{17}||0.8| |13.6
'''    |02| |Enumeration|{1}||0.4| |0.4
'''    |03| |Structure  |{0}||0.4| |0
'''    |04| |Sub        |{5}||1.2| |6
'''    |05| |Function   |{9}||1.6| |14.4
'''    |06| |Runtime    |{13}||0.4| |5.2
'''    |07| |Loader     |{2}||0.8| |1.6
'''    |08| |Class      |{0}||2| |0
'''    |09| |Constante  |{0}||0.4| |0
'''    |10| |Event      |{0}||1.2| |0
'''    |11| |Members    |{17}||0.5| |8.5
'''    |12| |Parameter  |{25}||0.5| |12.5
'''    |Production Cost             |62.2
'''    |Selling Price without VAT   |155.5
'''    |Total TVA                   |11.97
'''    |Grand Total                 |167.47
'''    |/Schema|
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:801 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
public  class Factures{
#region <1> [Property]{17}
#region |2019/07/17 00h01:388| <01.00.00> <Property> <Columns> |.Code()|String|  (Set|Get) The Code as String.
 ///     <Summary>
 ///    (Set|Get) The Code as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:801 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Code as String.") ]
    member this.Code()
       with get() = _Code
       and set(value) = _Code <- value
#endregion (Set|Get) The Code as String.

#region |2019/07/17 00h01:395| <01.00.01> <Property> <Columns> |.Emise_Par()|String|  (Set|Get) The Emise_Par as String.
 ///     <Summary>
 ///    (Set|Get) The Emise_Par as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:802 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Emise_Par as String.") ]
    member this.Emise_Par()
       with get() = _Emise_Par
       and set(value) = _Emise_Par <- value
#endregion (Set|Get) The Emise_Par as String.

#region |2019/07/17 00h01:400| <01.00.02> <Property> <Columns> |.Année()|Integer|  (Set|Get) The Année as Integer.
 ///     <Summary>
 ///    (Set|Get) The Année as Integer.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:802 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Année as Integer.") ]
    member this.Année()
       with get() = _Année
       and set(value) = _Année <- value
#endregion (Set|Get) The Année as Integer.

#region |2019/07/17 00h01:428| <01.00.03> <Property> <Columns> |.Mois()|Integer|  (Set|Get) The Mois as Integer.
 ///     <Summary>
 ///    (Set|Get) The Mois as Integer.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:802 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Mois as Integer.") ]
    member this.Mois()
       with get() = _Mois
       and set(value) = _Mois <- value
#endregion (Set|Get) The Mois as Integer.

#region |2019/07/17 00h01:436| <01.00.04> <Property> <Columns> |.N()|Integer|  (Set|Get) The N as Integer.
 ///     <Summary>
 ///    (Set|Get) The N as Integer.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:802 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The N as Integer.") ]
    member this.N()
       with get() = _N
       and set(value) = _N <- value
#endregion (Set|Get) The N as Integer.

#region |2019/07/17 00h01:446| <01.00.05> <Property> <Columns> |.Client()|String|  (Set|Get) The Client as String.
 ///     <Summary>
 ///    (Set|Get) The Client as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:802 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Client as String.") ]
    member this.Client()
       with get() = _Client
       and set(value) = _Client <- value
#endregion (Set|Get) The Client as String.

#region |2019/07/17 00h01:455| <01.00.06> <Property> <Columns> |.Adresse()|String|  (Set|Get) The Adresse as String.
 ///     <Summary>
 ///    (Set|Get) The Adresse as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:802 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Adresse as String.") ]
    member this.Adresse()
       with get() = _Adresse
       and set(value) = _Adresse <- value
#endregion (Set|Get) The Adresse as String.

#region |2019/07/17 00h01:464| <01.00.07> <Property> <Columns> |.DateEnvoi()|DateTime|  (Set|Get) The DateEnvoi as DateTime.
 ///     <Summary>
 ///    (Set|Get) The DateEnvoi as DateTime.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:803 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The DateEnvoi as DateTime.") ]
    member this.DateEnvoi()
       with get() = _DateEnvoi
       and set(value) = _DateEnvoi <- value
#endregion (Set|Get) The DateEnvoi as DateTime.

#region |2019/07/17 00h01:473| <01.00.08> <Property> <Columns> |.PériodeIN()|DateTime|  (Set|Get) The PériodeIN as DateTime.
 ///     <Summary>
 ///    (Set|Get) The PériodeIN as DateTime.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:803 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The PériodeIN as DateTime.") ]
    member this.PériodeIN()
       with get() = _PériodeIN
       and set(value) = _PériodeIN <- value
#endregion (Set|Get) The PériodeIN as DateTime.

#region |2019/07/17 00h01:483| <01.00.09> <Property> <Columns> |.PériodeFIN()|DateTime|  (Set|Get) The PériodeFIN as DateTime.
 ///     <Summary>
 ///    (Set|Get) The PériodeFIN as DateTime.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:803 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The PériodeFIN as DateTime.") ]
    member this.PériodeFIN()
       with get() = _PériodeFIN
       and set(value) = _PériodeFIN <- value
#endregion (Set|Get) The PériodeFIN as DateTime.

#region |2019/07/17 00h01:491| <01.00.10> <Property> <Columns> |.Concerne()|String|  (Set|Get) The Concerne as String.
 ///     <Summary>
 ///    (Set|Get) The Concerne as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:803 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Concerne as String.") ]
    member this.Concerne()
       with get() = _Concerne
       and set(value) = _Concerne <- value
#endregion (Set|Get) The Concerne as String.

#region |2019/07/17 00h01:499| <01.00.11> <Property> <Columns> |.Quantité()|Double|  (Set|Get) The Quantité as Double.
 ///     <Summary>
 ///    (Set|Get) The Quantité as Double.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:804 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Quantité as Double.") ]
    member this.Quantité()
       with get() = _Quantité
       and set(value) = _Quantité <- value
#endregion (Set|Get) The Quantité as Double.

#region |2019/07/17 00h01:508| <01.00.12> <Property> <Columns> |.TotalHTVA()|Double|  (Set|Get) The TotalHTVA as Double.
 ///     <Summary>
 ///    (Set|Get) The TotalHTVA as Double.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:804 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The TotalHTVA as Double.") ]
    member this.TotalHTVA()
       with get() = _TotalHTVA
       and set(value) = _TotalHTVA <- value
#endregion (Set|Get) The TotalHTVA as Double.

#region |2019/07/17 00h01:518| <01.00.13> <Property> <Columns> |.TotalFrais()|Double|  (Set|Get) The TotalFrais as Double.
 ///     <Summary>
 ///    (Set|Get) The TotalFrais as Double.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:804 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The TotalFrais as Double.") ]
    member this.TotalFrais()
       with get() = _TotalFrais
       and set(value) = _TotalFrais <- value
#endregion (Set|Get) The TotalFrais as Double.

#region |2019/07/17 00h01:527| <01.00.14> <Property> <Columns> |.TotalTVA()|Double|  (Set|Get) The TotalTVA as Double.
 ///     <Summary>
 ///    (Set|Get) The TotalTVA as Double.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:804 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The TotalTVA as Double.") ]
    member this.TotalTVA()
       with get() = _TotalTVA
       and set(value) = _TotalTVA <- value
#endregion (Set|Get) The TotalTVA as Double.

#region |2019/07/17 00h01:537| <01.00.15> <Property> <Columns> |.Total()|Double|  (Set|Get) The Total as Double.
 ///     <Summary>
 ///    (Set|Get) The Total as Double.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:804 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Total as Double.") ]
    member this.Total()
       with get() = _Total
       and set(value) = _Total <- value
#endregion (Set|Get) The Total as Double.

#region |2019/07/17 00h01:546| <01.00.16> <Property> <Columns> |.Libellé()|String|  (Set|Get) The Libellé as String.
 ///     <Summary>
 ///    (Set|Get) The Libellé as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:805 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Libellé as String.") ]
    member this.Libellé()
       with get() = _Libellé
       and set(value) = _Libellé <- value
#endregion (Set|Get) The Libellé as String.

#end region 
#region <2> [Enumeration]{1}
#region |2019/07/17 00h01:556| <02.00.00> <Property> <> |.Schema()|Enumeration{16}|"' (Set|Get) The enumeration of Schema.
     ///     <Summary>
 ///    (Set|Get) The enumeration of Schema.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:805 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The enumeration of Schema.") ]
    Type Schema = 
/// <summary>(Set|Get) The Code as String.</summary>
|   [Code] = 0
/// <summary>(Set|Get) The Emise_Par as String.</summary>
|   [Emise_Par] = 1
/// <summary>(Set|Get) The Année as Integer.</summary>
|   [Année] = 2
/// <summary>(Set|Get) The Mois as Integer.</summary>
|   [Mois] = 3
/// <summary>(Set|Get) The N as Integer.</summary>
|   [N] = 4
/// <summary>(Set|Get) The Client as String.</summary>
|   [Client] = 5
/// <summary>(Set|Get) The Adresse as String.</summary>
|   [Adresse] = 6
/// <summary>(Set|Get) The DateEnvoi as DateTime.</summary>
|   [DateEnvoi] = 7
/// <summary>(Set|Get) The PériodeIN as DateTime.</summary>
|   [PériodeIN] = 8
/// <summary>(Set|Get) The PériodeFIN as DateTime.</summary>
|   [PériodeFIN] = 9
/// <summary>(Set|Get) The Concerne as String.</summary>
|   [Concerne] = 10
/// <summary>(Set|Get) The Quantité as Double.</summary>
|   [Quantité] = 11
/// <summary>(Set|Get) The TotalHTVA as Double.</summary>
|   [TotalHTVA] = 12
/// <summary>(Set|Get) The TotalFrais as Double.</summary>
|   [TotalFrais] = 13
/// <summary>(Set|Get) The TotalTVA as Double.</summary>
|   [TotalTVA] = 14
/// <summary>(Set|Get) The Total as Double.</summary>
|   [Total] = 15
/// <summary>(Set|Get) The Libellé as String.</summary>
|   [Libellé] = 16
#endregion (Set|Get) The enumeration of Schema.

#end region 
#region <4> [Sub]{5}
#region |2019/07/17 00h01:564| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
     ///     <Summary>
 ///    (Set|Get) This will reinitialize the class element.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:805 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will reinitialize the class element.") ]
    Let Clear = 
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
#endregion (Set|Get) This will reinitialize the class element.

#region |2019/07/17 00h01:571| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
     ///     <Summary>
 ///    (Set|Get) This will reinitialize the variables of this class.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:805 </Published>
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
        TableName = "Factures"
        Line = Connector.Line
        UseSQL = False
   Else
        FilePath = My.Settings.Db_Chronos_FilePath
        Password = My.Settings.Db_Chronos_Password
        Me.Line = My.Settings.Db_Chronos_Line
        TableName = "Factures"
        UseSQL = False
   End If
Else
        If IsNothing(FilePath) Then 
             FilePath = My.Settings.Db_Chronos_FilePath
        End If 
        If FilePath.Length<1 Then 
             FilePath = My.Settings.Db_Chronos_FilePath
        End If 
        FilePath = My.Settings.Db_Chronos_FilePath
        Password = My.Settings.Db_Chronos_Password
        Me.Line = My.Settings.Db_Chronos_Line
        TableName = "Factures"
        UseSQL = False
End If

#endregion (Set|Get) This will reinitialize the variables of this class.

#region |2019/07/17 00h01:588| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
     ///     <Summary>
 ///    (Set|Get) This will add a new row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:806 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will add a new row in the table.") ]
    Let Add = 
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
Cmd = New OleDb.OleDbCommand(Str,Con)
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
          If Cmd.ExecuteNonQuery>=0 Then
          Else
              Msgbox("Element not Addd")
          End If
 Catch ex As Exception 
 Finally 
   Close(True) 
 End Try 

#endregion (Set|Get) This will add a new row in the table.

#region |2019/07/17 00h01:598| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
     ///     <Summary>
 ///    (Set|Get) This will update a row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:807 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will update a row in the table.") ]
    Let Save = 
     Try
   Dim Str As String = Nothing
   Str = "UPDATE [Factures] SET Emise_Par = @Emise_Par, Année = @Année, Mois = @Mois, N = @N, Client = @Client, Adresse = @Adresse, DateEnvoi = @DateEnvoi, PériodeIN = @PériodeIN, PériodeFIN = @PériodeFIN, Concerne = @Concerne, Quantité = @Quantité, TotalHTVA = @TotalHTVA, TotalFrais = @TotalFrais, TotalTVA = @TotalTVA, Total = @Total, Libellé = @Libellé WHERE Code = @Code"
Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
Cmd = New OleDb.OleDbCommand(Str,Con)
Con.Open()
      Cmd.Parameters.AddWithValue("@Emise_Par",Emise_Par)
      Cmd.Parameters.AddWithValue("@Année",Année)
      Cmd.Parameters.AddWithValue("@Mois",Mois)
      Cmd.Parameters.AddWithValue("@N",N)
      Cmd.Parameters.AddWithValue("@Client",Client)
      Cmd.Parameters.AddWithValue("@Adresse",Adresse)
      Cmd.Parameters.AddWithValue("@DateEnvoi",DateEnvoi)
      Cmd.Parameters.AddWithValue("@PériodeIN",PériodeIN)
      Cmd.Parameters.AddWithValue("@PériodeFIN",PériodeFIN)
      Cmd.Parameters.AddWithValue("@Concerne",Concerne)
      Cmd.Parameters.AddWithValue("@Quantité",Quantité)
      Cmd.Parameters.AddWithValue("@TotalHTVA",TotalHTVA)
      Cmd.Parameters.AddWithValue("@TotalFrais",TotalFrais)
      Cmd.Parameters.AddWithValue("@TotalTVA",TotalTVA)
      Cmd.Parameters.AddWithValue("@Total",Total)
      Cmd.Parameters.AddWithValue("@Libellé",Libellé)
      Cmd.Parameters.AddWithValue("@Code",Code)
          If Cmd.ExecuteNonQuery>=0 Then
          Else
              Msgbox("Element not Saved")
          End If
 Catch ex As Exception 
 Finally 
   Close(True) 
 End Try 

#endregion (Set|Get) This will update a row in the table.

#region |2019/07/17 00h01:606| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
     ///     <Summary>
 ///    (Set|Get) This will Delete a row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:807 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will Delete a row in the table.") ]
    Let Delete = 
     Try
   Dim Str As String = Nothing
   Str = "Delete From [Factures] WHERE Code =@Code"
Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
Cmd = New OleDb.OleDbCommand(Str,Con)
Con.Open()
Cmd.Parameters.AddWithValue("@Code", Code)
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
#region <5> [Function]{9}
#region |2019/07/17 00h01:612| <05.00.00> <Sub> <> |.Open()|Sub}|"' (Set|Get) This will initialise the connection and import the data.
     ///     <Summary>
 ///    (Set|Get) This will initialise the connection and import the data.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:807 </Published>
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

#region |2019/07/17 00h01:619| <05.00.01> <Sub> <> |.Close()|Sub}|"' (Set|Get) This willClosing the connection
     ///     <Summary>
 ///    (Set|Get) This willClosing the connection
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:807 </Published>
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

#region |2019/07/17 00h01:624| <05.00.02> <Sub> <> |.List()|Sub}|"' (Set|Get) Return the entire table listed
     ///     <Summary>
 ///    (Set|Get) Return the entire table listed
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:807 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Return the entire table listed") ]
    Let List = 
    Dim Result As New List(Of Factures)
Me.Table = New Table(Me.TableName , Me.FilePath , Me.Password,False)
   For each Row As DataRow In Me.Table.DataTable.Rows
      Dim Element As New Factures(IIf(IsDBNull(Row.Item(0)),"",Row.Item(0)),
IIf(IsDBNull(Row.Item(1)),"",Row.Item(1)),
IIf(IsDBNull(Row.Item(2)),0,Row.Item(2)),
IIf(IsDBNull(Row.Item(3)),0,Row.Item(3)),
IIf(IsDBNull(Row.Item(4)),0,Row.Item(4)),
IIf(IsDBNull(Row.Item(5)),"",Row.Item(5)),
IIf(IsDBNull(Row.Item(6)),"",Row.Item(6)),
IIf(IsDBNull(Row.Item(7)),New DateTime(1970,1,1),Row.Item(7)),
IIf(IsDBNull(Row.Item(8)),New DateTime(1970,1,1),Row.Item(8)),
IIf(IsDBNull(Row.Item(9)),New DateTime(1970,1,1),Row.Item(9)),
IIf(IsDBNull(Row.Item(10)),"",Row.Item(10)),
IIf(IsDBNull(Row.Item(11)),0,Row.Item(11)),
IIf(IsDBNull(Row.Item(12)),0,Row.Item(12)),
IIf(IsDBNull(Row.Item(13)),0,Row.Item(13)),
IIf(IsDBNull(Row.Item(14)),0,Row.Item(14)),
IIf(IsDBNull(Row.Item(15)),0,Row.Item(15)),
      IIf(IsDBNull(Row.Item(16)),"",Row.Item(16)))
      Element.Reset(Table.Line)
 Result.Add(Element)
 Next
 Return Result
#endregion (Set|Get) Return the entire table listed

#region |2019/07/17 00h01:630| <05.00.03> <Sub> <> |.SearchByName()|Sub}|"' (Set|Get) Search for each property that match the Search String.
     ///     <Summary>
 ///    (Set|Get) Search for each property that match the Search String.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:807 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Search for each property that match the Search String.") ]
    Let SearchByName = 
    Dim Result As New List(Of Factures)
 Dim C As New Factures
 For Each Element As Factures In C.List
 If Element.Code.Tolower() = Search.Tolower() Or Element.Emise_Par.Tolower() = Search.Tolower()  Or Element.Client.Tolower() = Search.Tolower()  Or Element.Adresse.Tolower() = Search.Tolower()  Or Element.Concerne.Tolower() = Search.Tolower()  Or Element.Libellé.Tolower() = Search.Tolower() Then
      Result.Add(Element)
 End If
 Next
 Return Result
#endregion (Set|Get) Search for each property that match the Search String.

#region |2019/07/17 00h01:635| <05.00.04> <Sub> <> |.SearchByID()|Sub}|"' (Set|Get) Search for each property that match the Search Id.
     ///     <Summary>
 ///    (Set|Get) Search for each property that match the Search Id.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:807 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Search for each property that match the Search Id.") ]
    Let SearchByID = 
    Dim Result As New List(Of Factures)
 Dim C As New Factures
 For Each Element As Factures In C.List
 If Val(Element.Année) = Search Or Val(Element.Mois) = Search  Or Val(Element.N) = Search  Or Val(Element.Quantité) = Search  Or Val(Element.TotalHTVA) = Search  Or Val(Element.TotalFrais) = Search  Or Val(Element.TotalTVA) = Search  Or Val(Element.Total) = Search Then
      Result.Add(Element)
 End If
 Next
 Return Result
#endregion (Set|Get) Search for each property that match the Search Id.

#region |2019/07/17 00h01:641| <05.00.05> <Sub> <> |.SearchByDate()|Sub}|"' (Set|Get) Search for each property that match the Search Id.
     ///     <Summary>
 ///    (Set|Get) Search for each property that match the Search Id.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:807 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Search for each property that match the Search Id.") ]
    Let SearchByDate = 
    Dim Result As New List(Of Factures)
 Dim C As New Factures
 For Each Element As Factures In C.List
 If Element.DateEnvoi = Search Then
      Result.Add(Element)
 End If
 Next
 Return Result
#endregion (Set|Get) Search for each property that match the Search Id.

#region |2019/07/17 00h01:646| <05.00.06> <Sub> <> |.SearchByDateRange()|Sub}|"' (Set|Get) Search for each property that match the Search Id.
     ///     <Summary>
 ///    (Set|Get) Search for each property that match the Search Id.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:808 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Search for each property that match the Search Id.") ]
    Let SearchByDateRange = 
    Dim Result As New List(Of Factures)
 Dim C As New Factures
 For Each Element As Factures In C.List
 If (Element.DateEnvoi) => From_Date And (Element.DateEnvoi) <= Until_Date Then
      Result.Add(Element)
 End If
 Next
 Return Result
#endregion (Set|Get) Search for each property that match the Search Id.

#region |2019/07/17 00h01:652| <05.00.07> <Sub> <> |.ToString()|Sub}|"' (Set|Get) The function ToString.
     ///     <Summary>
 ///    (Set|Get) The function ToString.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:808 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The function ToString.") ]
    Let ToString = 
        Return Me.Code
#endregion (Set|Get) The function ToString.

#region |2019/07/17 00h01:658| <05.00.08> <Sub> <> |.CheckConnection()|Sub}|"' (Set|Get) Evaluate the connection to the DataBase
     ///     <Summary>
 ///    (Set|Get) Evaluate the connection to the DataBase
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:808 </Published>
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
#region <6> [Runtime]{13}
#region |2019/07/17 00h01:668| <15.00.00> <Runtime> <> |.Table()|Runtime|  (Set|Get) The Table.
 ///     <Summary>
 ///    (Set|Get) The Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:808 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Table.") ]
   Public Table Table;
#endregion (Set|Get) The Table.

#region |2019/07/17 00h01:691| <15.00.01> <Runtime> <> |.Line()|Runtime|  (Set|Get) The Connection String To the Table.
 ///     <Summary>
 ///    (Set|Get) The Connection String To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:808 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Connection String To the Table.") ]
   Public String Line;
#endregion (Set|Get) The Connection String To the Table.

#region |2019/07/17 00h01:697| <15.00.02> <Runtime> <> |.FilePath()|Runtime|  (Set|Get) The FilePath To the Table.
 ///     <Summary>
 ///    (Set|Get) The FilePath To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:809 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The FilePath To the Table.") ]
   Public String FilePath;
#endregion (Set|Get) The FilePath To the Table.

#region |2019/07/17 00h01:703| <15.00.03> <Runtime> <> |.Password()|Runtime|  (Set|Get) The Password To the Table.
 ///     <Summary>
 ///    (Set|Get) The Password To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:809 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Password To the Table.") ]
   Public String Password;
#endregion (Set|Get) The Password To the Table.

#region |2019/07/17 00h01:708| <15.00.04> <Runtime> <> |.UseSQL()|Runtime|  (Set|Get) Determines if the Database Connection is of type SQL.
 ///     <Summary>
 ///    (Set|Get) Determines if the Database Connection is of type SQL.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:809 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Determines if the Database Connection is of type SQL.") ]
   Public Boolean UseSQL;
#endregion (Set|Get) Determines if the Database Connection is of type SQL.

#region |2019/07/17 00h01:713| <15.00.05> <Runtime> <> |.TableName()|Runtime|  (Set|Get) The name of the Table.
 ///     <Summary>
 ///    (Set|Get) The name of the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:809 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The name of the Table.") ]
   Public String TableName;
#endregion (Set|Get) The name of the Table.

#region |2019/07/17 00h01:718| <15.00.06> <Runtime> <> |.Con()|Runtime|  (Set|Get) The Con To the Table.
 ///     <Summary>
 ///    (Set|Get) The Con To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:809 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Con To the Table.") ]
   Public OleDb.OleDbConnection Con;
#endregion (Set|Get) The Con To the Table.

#region |2019/07/17 00h01:723| <15.00.07> <Runtime> <> |.Cmd()|Runtime|  (Set|Get) The Cmd To the Table.
 ///     <Summary>
 ///    (Set|Get) The Cmd To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:810 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Cmd To the Table.") ]
   Public OleDb.OleDbCommand Cmd;
#endregion (Set|Get) The Cmd To the Table.

#region |2019/07/17 00h01:729| <15.00.08> <Runtime> <> |.DataReader()|Runtime|  (Set|Get) The DataReader To the Table.
 ///     <Summary>
 ///    (Set|Get) The DataReader To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:810 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The DataReader To the Table.") ]
   Public OleDb.OleDbDataReader DataReader;
#endregion (Set|Get) The DataReader To the Table.

#region |2019/07/17 00h01:734| <15.00.09> <Runtime> <> |.DataAdapter()|Runtime|  (Set|Get) The DataAdapter To the Table.
 ///     <Summary>
 ///    (Set|Get) The DataAdapter To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:810 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The DataAdapter To the Table.") ]
   Public OleDb.OleDbDataAdapter DataAdapter;
#endregion (Set|Get) The DataAdapter To the Table.

#region |2019/07/17 00h01:742| <15.00.10> <Runtime> <> |.Connector()|Runtime|  (Set|Get) The Connector To the Table.
 ///     <Summary>
 ///    (Set|Get) The Connector To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:810 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Connector To the Table.") ]
   Public LineInfo Connector;
#endregion (Set|Get) The Connector To the Table.

#region |2019/07/17 00h01:747| <15.00.11> <Runtime> <> |.Log()|Runtime|  (Set|Get) The Log To the Table.
 ///     <Summary>
 ///    (Set|Get) The Log To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:810 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Log To the Table.") ]
   Public String Log;
#endregion (Set|Get) The Log To the Table.

#region |2019/07/17 00h04:497| <15.00.13> <Runtime> <> |.Prestations()|Runtime|  (Set|Get) The list of Entries from the Invoices set as Factures_Entries Class object.
 ///     <Summary>
 ///    (Set|Get) The list of Entries from the Invoices set as Factures_Entries Class object.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:810 </Published>
'''      <Rights>
'''         Copyright on SmartOffice programming tools.
'''    All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
'''    training materials may not be reproduced in any form, used for academic purposes, or used for public
'''    without the prior written permission of David Shaw Informatique Sàrl.
'''    The software, components and data used in the course are protected by copyright and should not be copied on any media or
'''    taken out of the classroom.
'''       </Rights>
'''  ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The list of Entries from the Invoices set as Factures_Entries Class object.") ]
   Public List(Of Factures_Entries) Prestations;
#endregion (Set|Get) The list of Entries from the Invoices set as Factures_Entries Class object.

#end region 
#region <7> [Loader]{2}
#region |2019/07/17 00h01:754| <06.00.00> <Sub> <> |.Empty()|Sub}|"' (Set|Get) The sub Empty.
     ///     <Summary>
 ///    (Set|Get) The sub Empty.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:811 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The sub Empty.") ]
    Let Empty = 
    Reset
#endregion (Set|Get) The sub Empty.

#region |2019/07/17 00h01:761| <06.00.01> <Sub> <> |.Filled()|Sub}|"' (Set|Get) The sub Filled.
     ///     <Summary>
 ///    (Set|Get) The sub Filled.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:811 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The sub Filled.") ]
    Let Filled = 
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

#endregion (Set|Get) The sub Filled.

#end region 
}

 ///     <Summary>
 ///    Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Factures_Entries
'''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
'''    Contributor Information : ||
'''    Creation Date :           2019/07/17 00h01:022
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
'''    |Selling Price without VAT   |115.75
'''    |Total TVA                   |8.91
'''    |Grand Total                 |124.66
'''    |/Schema|
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:823 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
public  class Factures_Entries{
#region <1> [Property]{11}
#region |2019/07/17 00h01:023| <01.00.00> <Property> <Columns> |.ID()|Integer|  (Set|Get) The ID as Integer.
 ///     <Summary>
 ///    (Set|Get) The ID as Integer.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:823 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ID as Integer.") ]
    member this.ID()
       with get() = _ID
       and set(value) = _ID <- value
#endregion (Set|Get) The ID as Integer.

#region |2019/07/17 00h01:035| <01.00.01> <Property> <Columns> |.Facture()|String|  (Set|Get) The Facture as String.
 ///     <Summary>
 ///    (Set|Get) The Facture as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:823 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Facture as String.") ]
    member this.Facture()
       with get() = _Facture
       and set(value) = _Facture <- value
#endregion (Set|Get) The Facture as String.

#region |2019/07/17 00h01:042| <01.00.02> <Property> <Columns> |.Active()|Boolean|  (Set|Get) The Active as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Active as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:824 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Active as Boolean.") ]
    member this.Active()
       with get() = _Active
       and set(value) = _Active <- value
#endregion (Set|Get) The Active as Boolean.

#region |2019/07/17 00h01:050| <01.00.03> <Property> <Columns> |.DateEntry()|DateTime|  (Set|Get) The DateEntry as DateTime.
 ///     <Summary>
 ///    (Set|Get) The DateEntry as DateTime.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:824 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The DateEntry as DateTime.") ]
    member this.DateEntry()
       with get() = _DateEntry
       and set(value) = _DateEntry <- value
#endregion (Set|Get) The DateEntry as DateTime.

#region |2019/07/17 00h01:058| <01.00.04> <Property> <Columns> |.Collaborateur()|String|  (Set|Get) The Collaborateur as String.
 ///     <Summary>
 ///    (Set|Get) The Collaborateur as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:824 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Collaborateur as String.") ]
    member this.Collaborateur()
       with get() = _Collaborateur
       and set(value) = _Collaborateur <- value
#endregion (Set|Get) The Collaborateur as String.

#region |2019/07/17 00h01:064| <01.00.05> <Property> <Columns> |.Mandat()|String|  (Set|Get) The Mandat as String.
 ///     <Summary>
 ///    (Set|Get) The Mandat as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:824 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Mandat as String.") ]
    member this.Mandat()
       with get() = _Mandat
       and set(value) = _Mandat <- value
#endregion (Set|Get) The Mandat as String.

#region |2019/07/17 00h01:071| <01.00.06> <Property> <Columns> |.UnitPrice()|Double|  (Set|Get) The UnitPrice as Double.
 ///     <Summary>
 ///    (Set|Get) The UnitPrice as Double.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:825 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The UnitPrice as Double.") ]
    member this.UnitPrice()
       with get() = _UnitPrice
       and set(value) = _UnitPrice <- value
#endregion (Set|Get) The UnitPrice as Double.

#region |2019/07/17 00h01:077| <01.00.07> <Property> <Columns> |.Description()|String|  (Set|Get) The Description as String.
 ///     <Summary>
 ///    (Set|Get) The Description as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:825 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Description as String.") ]
    member this.Description()
       with get() = _Description
       and set(value) = _Description <- value
#endregion (Set|Get) The Description as String.

#region |2019/07/17 00h01:084| <01.00.08> <Property> <Columns> |.Facturable()|Boolean|  (Set|Get) The Facturable as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Facturable as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:825 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Facturable as Boolean.") ]
    member this.Facturable()
       with get() = _Facturable
       and set(value) = _Facturable <- value
#endregion (Set|Get) The Facturable as Boolean.

#region |2019/07/17 00h01:091| <01.00.09> <Property> <Columns> |.TotalHTVA()|Double|  (Set|Get) The TotalHTVA as Double.
 ///     <Summary>
 ///    (Set|Get) The TotalHTVA as Double.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:825 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The TotalHTVA as Double.") ]
    member this.TotalHTVA()
       with get() = _TotalHTVA
       and set(value) = _TotalHTVA <- value
#endregion (Set|Get) The TotalHTVA as Double.

#region |2019/07/17 00h01:098| <01.00.10> <Property> <Columns> |.Quantity()|Double|  (Set|Get) The Quantity as Double.
 ///     <Summary>
 ///    (Set|Get) The Quantity as Double.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:825 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Quantity as Double.") ]
    member this.Quantity()
       with get() = _Quantity
       and set(value) = _Quantity <- value
#endregion (Set|Get) The Quantity as Double.

#end region 
#region <2> [Enumeration]{1}
#region |2019/07/17 00h01:104| <02.00.00> <Property> <> |.Schema()|Enumeration{10}|"' (Set|Get) The enumeration of Schema.
     ///     <Summary>
 ///    (Set|Get) The enumeration of Schema.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:826 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The enumeration of Schema.") ]
    Type Schema = 
/// <summary>(Set|Get) The ID as Integer.</summary>
|   [ID] = 0
/// <summary>(Set|Get) The Facture as String.</summary>
|   [Facture] = 1
/// <summary>(Set|Get) The Active as Boolean.</summary>
|   [Active] = 2
/// <summary>(Set|Get) The DateEntry as DateTime.</summary>
|   [DateEntry] = 3
/// <summary>(Set|Get) The Collaborateur as String.</summary>
|   [Collaborateur] = 4
/// <summary>(Set|Get) The Mandat as String.</summary>
|   [Mandat] = 5
/// <summary>(Set|Get) The UnitPrice as Double.</summary>
|   [UnitPrice] = 6
/// <summary>(Set|Get) The Description as String.</summary>
|   [Description] = 7
/// <summary>(Set|Get) The Facturable as Boolean.</summary>
|   [Facturable] = 8
/// <summary>(Set|Get) The TotalHTVA as Double.</summary>
|   [TotalHTVA] = 9
/// <summary>(Set|Get) The Quantity as Double.</summary>
|   [Quantity] = 10
#endregion (Set|Get) The enumeration of Schema.

#end region 
#region <4> [Sub]{5}
#region |2019/07/17 00h01:127| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
     ///     <Summary>
 ///    (Set|Get) This will reinitialize the class element.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:826 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will reinitialize the class element.") ]
    Let Clear = 
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
#endregion (Set|Get) This will reinitialize the class element.

#region |2019/07/17 00h01:132| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
     ///     <Summary>
 ///    (Set|Get) This will reinitialize the variables of this class.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:826 </Published>
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
        TableName = "Factures_Entries"
        Line = Connector.Line
        UseSQL = False
   Else
        FilePath = My.Settings.Db_Chronos_FilePath
        Password = My.Settings.Db_Chronos_Password
        Me.Line = My.Settings.Db_Chronos_Line
        TableName = "Factures_Entries"
        UseSQL = False
   End If
Else
        If IsNothing(FilePath) Then 
             FilePath = My.Settings.Db_Chronos_FilePath
        End If 
        If FilePath.Length<1 Then 
             FilePath = My.Settings.Db_Chronos_FilePath
        End If 
        FilePath = My.Settings.Db_Chronos_FilePath
        Password = My.Settings.Db_Chronos_Password
        Me.Line = My.Settings.Db_Chronos_Line
        TableName = "Factures_Entries"
        UseSQL = False
End If

#endregion (Set|Get) This will reinitialize the variables of this class.

#region |2019/07/17 00h01:136| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
     ///     <Summary>
 ///    (Set|Get) This will add a new row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:826 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will add a new row in the table.") ]
    Let Add = 
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
Cmd = New OleDb.OleDbCommand(Str,Con)
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
          If Cmd.ExecuteNonQuery>=0 Then
          Else
              Msgbox("Element not Addd")
          End If
 Catch ex As Exception 
 Finally 
   Close(True) 
 End Try 

#endregion (Set|Get) This will add a new row in the table.

#region |2019/07/17 00h01:141| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
     ///     <Summary>
 ///    (Set|Get) This will update a row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:828 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will update a row in the table.") ]
    Let Save = 
     Try
   Dim Str As String = Nothing
   Str = "UPDATE [Factures_Entries] SET Facture = @Facture, Active = @Active, DateEntry = @DateEntry, Collaborateur = @Collaborateur, Mandat = @Mandat, UnitPrice = @UnitPrice, Description = @Description, Facturable = @Facturable, TotalHTVA = @TotalHTVA, Quantity = @Quantity WHERE ID = @ID"
Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
Cmd = New OleDb.OleDbCommand(Str,Con)
Con.Open()
      Cmd.Parameters.AddWithValue("@Facture",Facture)
      Cmd.Parameters.AddWithValue("@Active",Active)
      Cmd.Parameters.AddWithValue("@DateEntry",DateEntry)
      Cmd.Parameters.AddWithValue("@Collaborateur",Collaborateur)
      Cmd.Parameters.AddWithValue("@Mandat",Mandat)
      Cmd.Parameters.AddWithValue("@UnitPrice",UnitPrice)
      Cmd.Parameters.AddWithValue("@Description",Description)
      Cmd.Parameters.AddWithValue("@Facturable",Facturable)
      Cmd.Parameters.AddWithValue("@TotalHTVA",TotalHTVA)
      Cmd.Parameters.AddWithValue("@Quantity",Quantity)
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

#region |2019/07/17 00h01:146| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
     ///     <Summary>
 ///    (Set|Get) This will Delete a row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:828 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will Delete a row in the table.") ]
    Let Delete = 
     Try
   Dim Str As String = Nothing
   Str = "Delete From [Factures_Entries] WHERE ID =@ID"
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
#region |2019/07/17 00h01:150| <05.00.00> <Sub> <> |.Open()|Sub}|"' (Set|Get) This will initialise the connection and import the data.
     ///     <Summary>
 ///    (Set|Get) This will initialise the connection and import the data.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:829 </Published>
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

#region |2019/07/17 00h01:155| <05.00.01> <Sub> <> |.Close()|Sub}|"' (Set|Get) This willClosing the connection
     ///     <Summary>
 ///    (Set|Get) This willClosing the connection
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:829 </Published>
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

#region |2019/07/17 00h01:160| <05.00.02> <Sub> <> |.List()|Sub}|"' (Set|Get) Return the entire table listed
     ///     <Summary>
 ///    (Set|Get) Return the entire table listed
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:829 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Return the entire table listed") ]
    Let List = 
    Dim Result As New List(Of Factures_Entries)
Me.Table = New Table(Me.TableName , Me.FilePath , Me.Password,False)
   For each Row As DataRow In Me.Table.DataTable.Rows
      Dim Element As New Factures_Entries(IIf(IsDBNull(Row.Item(0)),0,Row.Item(0)),
IIf(IsDBNull(Row.Item(1)),"",Row.Item(1)),
IIf(IsDBNull(Row.Item(2)),False,Row.Item(2)),
IIf(IsDBNull(Row.Item(3)),New DateTime(1970,1,1),Row.Item(3)),
IIf(IsDBNull(Row.Item(4)),"",Row.Item(4)),
IIf(IsDBNull(Row.Item(5)),"",Row.Item(5)),
IIf(IsDBNull(Row.Item(6)),0,Row.Item(6)),
IIf(IsDBNull(Row.Item(7)),"",Row.Item(7)),
IIf(IsDBNull(Row.Item(8)),False,Row.Item(8)),
IIf(IsDBNull(Row.Item(9)),0,Row.Item(9)),
      IIf(IsDBNull(Row.Item(10)),0,Row.Item(10)))
      Element.Reset(Table.Line)
 Result.Add(Element)
 Next
 Return Result
#endregion (Set|Get) Return the entire table listed

#region |2019/07/17 00h01:164| <05.00.03> <Sub> <> |.SearchByName()|Sub}|"' (Set|Get) Search for each property that match the Search String.
     ///     <Summary>
 ///    (Set|Get) Search for each property that match the Search String.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:829 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Search for each property that match the Search String.") ]
    Let SearchByName = 
    Dim Result As New List(Of Factures_Entries)
 Dim C As New Factures_Entries
 For Each Element As Factures_Entries In C.List
 If Element.Facture.Tolower() = Search.Tolower() Or Element.Collaborateur.Tolower() = Search.Tolower()  Or Element.Mandat.Tolower() = Search.Tolower()  Or Element.Description.Tolower() = Search.Tolower() Then
      Result.Add(Element)
 End If
 Next
 Return Result
#endregion (Set|Get) Search for each property that match the Search String.

#region |2019/07/17 00h01:169| <05.00.04> <Sub> <> |.SearchByID()|Sub}|"' (Set|Get) Search for each property that match the Search Id.
     ///     <Summary>
 ///    (Set|Get) Search for each property that match the Search Id.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:829 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Search for each property that match the Search Id.") ]
    Let SearchByID = 
    Dim Result As New List(Of Factures_Entries)
 Dim C As New Factures_Entries
 For Each Element As Factures_Entries In C.List
 If Val(Element.ID) = Search Or Val(Element.UnitPrice) = Search  Or Val(Element.TotalHTVA) = Search  Or Val(Element.Quantity) = Search Then
      Result.Add(Element)
 End If
 Next
 Return Result
#endregion (Set|Get) Search for each property that match the Search Id.

#region |2019/07/17 00h01:174| <05.00.05> <Sub> <> |.ToString()|Sub}|"' (Set|Get) The function ToString.
     ///     <Summary>
 ///    (Set|Get) The function ToString.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:829 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The function ToString.") ]
    Let ToString = 
        Return Me.ID
#endregion (Set|Get) The function ToString.

#region |2019/07/17 00h01:178| <05.00.06> <Sub> <> |.CheckConnection()|Sub}|"' (Set|Get) Evaluate the connection to the DataBase
     ///     <Summary>
 ///    (Set|Get) Evaluate the connection to the DataBase
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:829 </Published>
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
#region |2019/07/17 00h01:190| <15.00.00> <Runtime> <> |.Table()|Runtime|  (Set|Get) The Table.
 ///     <Summary>
 ///    (Set|Get) The Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:829 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Table.") ]
   Public Table Table;
#endregion (Set|Get) The Table.

#region |2019/07/17 00h01:207| <15.00.01> <Runtime> <> |.Line()|Runtime|  (Set|Get) The Connection String To the Table.
 ///     <Summary>
 ///    (Set|Get) The Connection String To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:830 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Connection String To the Table.") ]
   Public String Line;
#endregion (Set|Get) The Connection String To the Table.

#region |2019/07/17 00h01:215| <15.00.02> <Runtime> <> |.FilePath()|Runtime|  (Set|Get) The FilePath To the Table.
 ///     <Summary>
 ///    (Set|Get) The FilePath To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:830 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The FilePath To the Table.") ]
   Public String FilePath;
#endregion (Set|Get) The FilePath To the Table.

#region |2019/07/17 00h01:220| <15.00.03> <Runtime> <> |.Password()|Runtime|  (Set|Get) The Password To the Table.
 ///     <Summary>
 ///    (Set|Get) The Password To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:830 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Password To the Table.") ]
   Public String Password;
#endregion (Set|Get) The Password To the Table.

#region |2019/07/17 00h01:225| <15.00.04> <Runtime> <> |.UseSQL()|Runtime|  (Set|Get) Determines if the Database Connection is of type SQL.
 ///     <Summary>
 ///    (Set|Get) Determines if the Database Connection is of type SQL.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:830 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Determines if the Database Connection is of type SQL.") ]
   Public Boolean UseSQL;
#endregion (Set|Get) Determines if the Database Connection is of type SQL.

#region |2019/07/17 00h01:230| <15.00.05> <Runtime> <> |.TableName()|Runtime|  (Set|Get) The name of the Table.
 ///     <Summary>
 ///    (Set|Get) The name of the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:831 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The name of the Table.") ]
   Public String TableName;
#endregion (Set|Get) The name of the Table.

#region |2019/07/17 00h01:235| <15.00.06> <Runtime> <> |.Con()|Runtime|  (Set|Get) The Con To the Table.
 ///     <Summary>
 ///    (Set|Get) The Con To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:831 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Con To the Table.") ]
   Public OleDb.OleDbConnection Con;
#endregion (Set|Get) The Con To the Table.

#region |2019/07/17 00h01:241| <15.00.07> <Runtime> <> |.Cmd()|Runtime|  (Set|Get) The Cmd To the Table.
 ///     <Summary>
 ///    (Set|Get) The Cmd To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:831 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Cmd To the Table.") ]
   Public OleDb.OleDbCommand Cmd;
#endregion (Set|Get) The Cmd To the Table.

#region |2019/07/17 00h01:246| <15.00.08> <Runtime> <> |.DataReader()|Runtime|  (Set|Get) The DataReader To the Table.
 ///     <Summary>
 ///    (Set|Get) The DataReader To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:831 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The DataReader To the Table.") ]
   Public OleDb.OleDbDataReader DataReader;
#endregion (Set|Get) The DataReader To the Table.

#region |2019/07/17 00h01:252| <15.00.09> <Runtime> <> |.DataAdapter()|Runtime|  (Set|Get) The DataAdapter To the Table.
 ///     <Summary>
 ///    (Set|Get) The DataAdapter To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:831 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The DataAdapter To the Table.") ]
   Public OleDb.OleDbDataAdapter DataAdapter;
#endregion (Set|Get) The DataAdapter To the Table.

#region |2019/07/17 00h01:257| <15.00.10> <Runtime> <> |.Connector()|Runtime|  (Set|Get) The Connector To the Table.
 ///     <Summary>
 ///    (Set|Get) The Connector To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:832 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Connector To the Table.") ]
   Public LineInfo Connector;
#endregion (Set|Get) The Connector To the Table.

#region |2019/07/17 00h01:263| <15.00.11> <Runtime> <> |.Log()|Runtime|  (Set|Get) The Log To the Table.
 ///     <Summary>
 ///    (Set|Get) The Log To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:832 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Log To the Table.") ]
   Public String Log;
#endregion (Set|Get) The Log To the Table.

#end region 
#region <7> [Loader]{2}
#region |2019/07/17 00h01:272| <06.00.00> <Sub> <> |.Empty()|Sub}|"' (Set|Get) The sub Empty.
     ///     <Summary>
 ///    (Set|Get) The sub Empty.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:832 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The sub Empty.") ]
    Let Empty = 
    Reset
#endregion (Set|Get) The sub Empty.

#region |2019/07/17 00h01:274| <06.00.01> <Sub> <> |.Filled()|Sub}|"' (Set|Get) The sub Filled.
     ///     <Summary>
 ///    (Set|Get) The sub Filled.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:832 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The sub Filled.") ]
    Let Filled = 
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

#endregion (Set|Get) The sub Filled.

#end region 
}

 ///     <Summary>
 ///    Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Prestation_Category
'''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
'''    Contributor Information : ||
'''    Creation Date :           2019/07/17 00h01:371
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
'''    |Selling Price without VAT   |70.75
'''    |Total TVA                   |5.45
'''    |Grand Total                 |76.2
'''    |/Schema|
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:840 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
public  class Prestation_Category{
#region <1> [Property]{1}
#region |2019/07/17 00h01:372| <01.00.00> <Property> <Columns> |.Ref()|String|  (Set|Get) The Ref as String.
 ///     <Summary>
 ///    (Set|Get) The Ref as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:841 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Ref as String.") ]
    member this.Ref()
       with get() = _Ref
       and set(value) = _Ref <- value
#endregion (Set|Get) The Ref as String.

#end region 
#region <2> [Enumeration]{1}
#region |2019/07/17 00h01:395| <02.00.00> <Property> <> |.Schema()|Enumeration{0}|"' (Set|Get) The enumeration of Schema.
     ///     <Summary>
 ///    (Set|Get) The enumeration of Schema.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:841 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The enumeration of Schema.") ]
    Type Schema = 
/// <summary>(Set|Get) The Ref as String.</summary>
|   [Ref] = 0
#endregion (Set|Get) The enumeration of Schema.

#end region 
#region <4> [Sub]{5}
#region |2019/07/17 00h01:401| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
     ///     <Summary>
 ///    (Set|Get) This will reinitialize the class element.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:841 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will reinitialize the class element.") ]
    Let Clear = 
      With Me
        .Ref = Nothing
 End With
#endregion (Set|Get) This will reinitialize the class element.

#region |2019/07/17 00h01:404| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
     ///     <Summary>
 ///    (Set|Get) This will reinitialize the variables of this class.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:841 </Published>
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
        TableName = "Prestation_Category"
        Line = Connector.Line
        UseSQL = False
   Else
        FilePath = My.Settings.Db_Chronos_FilePath
        Password = My.Settings.Db_Chronos_Password
        Me.Line = My.Settings.Db_Chronos_Line
        TableName = "Prestation_Category"
        UseSQL = False
   End If
Else
        If IsNothing(FilePath) Then 
             FilePath = My.Settings.Db_Chronos_FilePath
        End If 
        If FilePath.Length<1 Then 
             FilePath = My.Settings.Db_Chronos_FilePath
        End If 
        FilePath = My.Settings.Db_Chronos_FilePath
        Password = My.Settings.Db_Chronos_Password
        Me.Line = My.Settings.Db_Chronos_Line
        TableName = "Prestation_Category"
        UseSQL = False
End If

#endregion (Set|Get) This will reinitialize the variables of this class.

#region |2019/07/17 00h01:410| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
     ///     <Summary>
 ///    (Set|Get) This will add a new row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:841 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will add a new row in the table.") ]
    Let Add = 
     Try
   Dim Str As String = Nothing
   Str = "Insert Into [Prestation_Category] (
`Ref`) Values (@0)"
Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
Cmd = New OleDb.OleDbCommand(Str,Con)
Con.Open()
            Cmd.Parameters.AddWithValue("@0", Me.Ref)
          If Cmd.ExecuteNonQuery>=0 Then
          Else
              Msgbox("Element not Addd")
          End If
 Catch ex As Exception 
 Finally 
   Close(True) 
 End Try 

#endregion (Set|Get) This will add a new row in the table.

#region |2019/07/17 00h01:414| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
     ///     <Summary>
 ///    (Set|Get) This will update a row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:841 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will update a row in the table.") ]
    Let Save = 
     Try
   Dim Str As String = Nothing
   Str = "UPDATE [Prestation_Category] SET Ref = @Ref WHERE Ref = @Ref"
Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
Cmd = New OleDb.OleDbCommand(Str,Con)
Con.Open()
      Cmd.Parameters.AddWithValue("@Ref",Ref)
      Cmd.Parameters.AddWithValue("@Ref",Ref)
          If Cmd.ExecuteNonQuery>=0 Then
          Else
              Msgbox("Element not Saved")
          End If
 Catch ex As Exception 
 Finally 
   Close(True) 
 End Try 

#endregion (Set|Get) This will update a row in the table.

#region |2019/07/17 00h01:419| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
     ///     <Summary>
 ///    (Set|Get) This will Delete a row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:841 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will Delete a row in the table.") ]
    Let Delete = 
     Try
   Dim Str As String = Nothing
   Str = "Delete From [Prestation_Category] WHERE Ref =@Ref"
Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
Cmd = New OleDb.OleDbCommand(Str,Con)
Con.Open()
Cmd.Parameters.AddWithValue("@Ref", Ref)
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
#region |2019/07/17 00h01:425| <05.00.00> <Sub> <> |.Open()|Sub}|"' (Set|Get) This will initialise the connection and import the data.
     ///     <Summary>
 ///    (Set|Get) This will initialise the connection and import the data.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:842 </Published>
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

#region |2019/07/17 00h01:430| <05.00.01> <Sub> <> |.Close()|Sub}|"' (Set|Get) This willClosing the connection
     ///     <Summary>
 ///    (Set|Get) This willClosing the connection
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:842 </Published>
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

#region |2019/07/17 00h01:456| <05.00.02> <Sub> <> |.List()|Sub}|"' (Set|Get) Return the entire table listed
     ///     <Summary>
 ///    (Set|Get) Return the entire table listed
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:842 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Return the entire table listed") ]
    Let List = 
    Dim Result As New List(Of Prestation_Category)
Me.Table = New Table(Me.TableName , Me.FilePath , Me.Password,False)
   For each Row As DataRow In Me.Table.DataTable.Rows
      Dim Element As New Prestation_Category(IIF(IsDBNull(Row.Item(0)),"",Row.Item(0)))
      Element.Reset(Table.Line)
 Result.Add(Element)
 Next
 Return Result
#endregion (Set|Get) Return the entire table listed

#region |2019/07/17 00h01:464| <05.00.03> <Sub> <> |.SearchByName()|Sub}|"' (Set|Get) Search for each property that match the Search String.
     ///     <Summary>
 ///    (Set|Get) Search for each property that match the Search String.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:842 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Search for each property that match the Search String.") ]
    Let SearchByName = 
    Dim Result As New List(Of Prestation_Category)
 Dim C As New Prestation_Category
 For Each Element As Prestation_Category In C.List
 If Element.Ref.Tolower() = Search.Tolower() Then
      Result.Add(Element)
 End If
 Next
 Return Result
#endregion (Set|Get) Search for each property that match the Search String.

#region |2019/07/17 00h01:472| <05.00.04> <Sub> <> |.SearchByID()|Sub}|"' (Set|Get) Search for each property that match the Search Id.
     ///     <Summary>
 ///    (Set|Get) Search for each property that match the Search Id.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:842 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Search for each property that match the Search Id.") ]
    Let SearchByID = 
    Dim Result As New List(Of Prestation_Category)
 Dim C As New Prestation_Category
 For Each Element As Prestation_Category In C.List
 Next
 Return Result
#endregion (Set|Get) Search for each property that match the Search Id.

#region |2019/07/17 00h01:482| <05.00.05> <Sub> <> |.ToString()|Sub}|"' (Set|Get) The function ToString.
     ///     <Summary>
 ///    (Set|Get) The function ToString.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:842 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The function ToString.") ]
    Let ToString = 
        Return Me.Ref
#endregion (Set|Get) The function ToString.

#region |2019/07/17 00h01:490| <05.00.06> <Sub> <> |.CheckConnection()|Sub}|"' (Set|Get) Evaluate the connection to the DataBase
     ///     <Summary>
 ///    (Set|Get) Evaluate the connection to the DataBase
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:842 </Published>
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
#region |2019/07/17 00h01:499| <15.00.00> <Runtime> <> |.Table()|Runtime|  (Set|Get) The Table.
 ///     <Summary>
 ///    (Set|Get) The Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:845 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Table.") ]
   Public Table Table;
#endregion (Set|Get) The Table.

#region |2019/07/17 00h01:509| <15.00.01> <Runtime> <> |.Line()|Runtime|  (Set|Get) The Connection String To the Table.
 ///     <Summary>
 ///    (Set|Get) The Connection String To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:845 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Connection String To the Table.") ]
   Public String Line;
#endregion (Set|Get) The Connection String To the Table.

#region |2019/07/17 00h01:518| <15.00.02> <Runtime> <> |.FilePath()|Runtime|  (Set|Get) The FilePath To the Table.
 ///     <Summary>
 ///    (Set|Get) The FilePath To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:845 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The FilePath To the Table.") ]
   Public String FilePath;
#endregion (Set|Get) The FilePath To the Table.

#region |2019/07/17 00h01:527| <15.00.03> <Runtime> <> |.Password()|Runtime|  (Set|Get) The Password To the Table.
 ///     <Summary>
 ///    (Set|Get) The Password To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:845 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Password To the Table.") ]
   Public String Password;
#endregion (Set|Get) The Password To the Table.

#region |2019/07/17 00h01:534| <15.00.04> <Runtime> <> |.UseSQL()|Runtime|  (Set|Get) Determines if the Database Connection is of type SQL.
 ///     <Summary>
 ///    (Set|Get) Determines if the Database Connection is of type SQL.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:845 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Determines if the Database Connection is of type SQL.") ]
   Public Boolean UseSQL;
#endregion (Set|Get) Determines if the Database Connection is of type SQL.

#region |2019/07/17 00h01:542| <15.00.05> <Runtime> <> |.TableName()|Runtime|  (Set|Get) The name of the Table.
 ///     <Summary>
 ///    (Set|Get) The name of the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:845 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The name of the Table.") ]
   Public String TableName;
#endregion (Set|Get) The name of the Table.

#region |2019/07/17 00h01:551| <15.00.06> <Runtime> <> |.Con()|Runtime|  (Set|Get) The Con To the Table.
 ///     <Summary>
 ///    (Set|Get) The Con To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:845 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Con To the Table.") ]
   Public OleDb.OleDbConnection Con;
#endregion (Set|Get) The Con To the Table.

#region |2019/07/17 00h01:556| <15.00.07> <Runtime> <> |.Cmd()|Runtime|  (Set|Get) The Cmd To the Table.
 ///     <Summary>
 ///    (Set|Get) The Cmd To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:845 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Cmd To the Table.") ]
   Public OleDb.OleDbCommand Cmd;
#endregion (Set|Get) The Cmd To the Table.

#region |2019/07/17 00h01:564| <15.00.08> <Runtime> <> |.DataReader()|Runtime|  (Set|Get) The DataReader To the Table.
 ///     <Summary>
 ///    (Set|Get) The DataReader To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:846 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The DataReader To the Table.") ]
   Public OleDb.OleDbDataReader DataReader;
#endregion (Set|Get) The DataReader To the Table.

#region |2019/07/17 00h01:581| <15.00.09> <Runtime> <> |.DataAdapter()|Runtime|  (Set|Get) The DataAdapter To the Table.
 ///     <Summary>
 ///    (Set|Get) The DataAdapter To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:846 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The DataAdapter To the Table.") ]
   Public OleDb.OleDbDataAdapter DataAdapter;
#endregion (Set|Get) The DataAdapter To the Table.

#region |2019/07/17 00h01:588| <15.00.10> <Runtime> <> |.Connector()|Runtime|  (Set|Get) The Connector To the Table.
 ///     <Summary>
 ///    (Set|Get) The Connector To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:846 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Connector To the Table.") ]
   Public LineInfo Connector;
#endregion (Set|Get) The Connector To the Table.

#region |2019/07/17 00h01:594| <15.00.11> <Runtime> <> |.Log()|Runtime|  (Set|Get) The Log To the Table.
 ///     <Summary>
 ///    (Set|Get) The Log To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:846 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Log To the Table.") ]
   Public String Log;
#endregion (Set|Get) The Log To the Table.

#end region 
#region <7> [Loader]{2}
#region |2019/07/17 00h01:601| <06.00.00> <Sub> <> |.Empty()|Sub}|"' (Set|Get) The sub Empty.
     ///     <Summary>
 ///    (Set|Get) The sub Empty.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:846 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The sub Empty.") ]
    Let Empty = 
    Reset
#endregion (Set|Get) The sub Empty.

#region |2019/07/17 00h01:603| <06.00.01> <Sub> <> |.Filled()|Sub}|"' (Set|Get) The sub Filled.
     ///     <Summary>
 ///    (Set|Get) The sub Filled.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:846 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The sub Filled.") ]
    Let Filled = 
     With Me
 Clear()
 Reset()
     .Ref = Ref
 End With

#endregion (Set|Get) The sub Filled.

#end region 
}

 ///     <Summary>
 ///    Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Prestations
'''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
'''    Contributor Information : ||
'''    Creation Date :           2019/07/17 00h01:729
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
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:850 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
public  class Prestations{
#region <1> [Property]{4}
#region |2019/07/17 00h01:730| <01.00.00> <Property> <Columns> |.ID()|Integer|  (Set|Get) The ID as Integer.
 ///     <Summary>
 ///    (Set|Get) The ID as Integer.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:850 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ID as Integer.") ]
    member this.ID()
       with get() = _ID
       and set(value) = _ID <- value
#endregion (Set|Get) The ID as Integer.

#region |2019/07/17 00h01:737| <01.00.01> <Property> <Columns> |.Description()|String|  (Set|Get) The Description as String.
 ///     <Summary>
 ///    (Set|Get) The Description as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:850 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Description as String.") ]
    member this.Description()
       with get() = _Description
       and set(value) = _Description <- value
#endregion (Set|Get) The Description as String.

#region |2019/07/17 00h01:744| <01.00.02> <Property> <Columns> |.Service()|String|  (Set|Get) The Service as String.
 ///     <Summary>
 ///    (Set|Get) The Service as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:851 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Service as String.") ]
    member this.Service()
       with get() = _Service
       and set(value) = _Service <- value
#endregion (Set|Get) The Service as String.

#region |2019/07/17 00h01:751| <01.00.03> <Property> <Columns> |.Type()|String|  (Set|Get) The Type as String.
 ///     <Summary>
 ///    (Set|Get) The Type as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:851 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Type as String.") ]
    member this.Type()
       with get() = _Type
       and set(value) = _Type <- value
#endregion (Set|Get) The Type as String.

#end region 
#region <2> [Enumeration]{1}
#region |2019/07/17 00h01:757| <02.00.00> <Property> <> |.Schema()|Enumeration{3}|"' (Set|Get) The enumeration of Schema.
     ///     <Summary>
 ///    (Set|Get) The enumeration of Schema.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:851 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The enumeration of Schema.") ]
    Type Schema = 
/// <summary>(Set|Get) The ID as Integer.</summary>
|   [ID] = 0
/// <summary>(Set|Get) The Description as String.</summary>
|   [Description] = 1
/// <summary>(Set|Get) The Service as String.</summary>
|   [Service] = 2
/// <summary>(Set|Get) The Type as String.</summary>
|   [Type] = 3
#endregion (Set|Get) The enumeration of Schema.

#end region 
#region <4> [Sub]{5}
#region |2019/07/17 00h01:762| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
     ///     <Summary>
 ///    (Set|Get) This will reinitialize the class element.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:851 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will reinitialize the class element.") ]
    Let Clear = 
      With Me
        .ID = 0
        .Description = Nothing
        .Service = Nothing
        .Type = Nothing
 End With
#endregion (Set|Get) This will reinitialize the class element.

#region |2019/07/17 00h01:767| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
     ///     <Summary>
 ///    (Set|Get) This will reinitialize the variables of this class.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:851 </Published>
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
        TableName = "Prestations"
        Line = Connector.Line
        UseSQL = False
   Else
        FilePath = My.Settings.Db_Chronos_FilePath
        Password = My.Settings.Db_Chronos_Password
        Me.Line = My.Settings.Db_Chronos_Line
        TableName = "Prestations"
        UseSQL = False
   End If
Else
        If IsNothing(FilePath) Then 
             FilePath = My.Settings.Db_Chronos_FilePath
        End If 
        If FilePath.Length<1 Then 
             FilePath = My.Settings.Db_Chronos_FilePath
        End If 
        FilePath = My.Settings.Db_Chronos_FilePath
        Password = My.Settings.Db_Chronos_Password
        Me.Line = My.Settings.Db_Chronos_Line
        TableName = "Prestations"
        UseSQL = False
End If

#endregion (Set|Get) This will reinitialize the variables of this class.

#region |2019/07/17 00h01:772| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
     ///     <Summary>
 ///    (Set|Get) This will add a new row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:851 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will add a new row in the table.") ]
    Let Add = 
     Try
   Dim Str As String = Nothing
   Str = "Insert Into [Prestations] (
`ID`, 
`Description`, 
`Service`, 
`Type`) Values (@0, @1, @2, @3)"
Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
Cmd = New OleDb.OleDbCommand(Str,Con)
Con.Open()
            Cmd.Parameters.AddWithValue("@0", Me.ID)
            Cmd.Parameters.AddWithValue("@1", Me.Description)
            Cmd.Parameters.AddWithValue("@2", Me.Service)
            Cmd.Parameters.AddWithValue("@3", Me.Type)
          If Cmd.ExecuteNonQuery>=0 Then
          Else
              Msgbox("Element not Addd")
          End If
 Catch ex As Exception 
 Finally 
   Close(True) 
 End Try 

#endregion (Set|Get) This will add a new row in the table.

#region |2019/07/17 00h01:780| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
     ///     <Summary>
 ///    (Set|Get) This will update a row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:852 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will update a row in the table.") ]
    Let Save = 
     Try
   Dim Str As String = Nothing
   Str = "UPDATE [Prestations] SET Description = @Description, Service = @Service, Type = @Type WHERE ID = @ID"
Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
Cmd = New OleDb.OleDbCommand(Str,Con)
Con.Open()
      Cmd.Parameters.AddWithValue("@Description",Description)
      Cmd.Parameters.AddWithValue("@Service",Service)
      Cmd.Parameters.AddWithValue("@Type",Type)
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

#region |2019/07/17 00h01:788| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
     ///     <Summary>
 ///    (Set|Get) This will Delete a row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:852 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will Delete a row in the table.") ]
    Let Delete = 
     Try
   Dim Str As String = Nothing
   Str = "Delete From [Prestations] WHERE ID =@ID"
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
#region |2019/07/17 00h01:793| <05.00.00> <Sub> <> |.Open()|Sub}|"' (Set|Get) This will initialise the connection and import the data.
     ///     <Summary>
 ///    (Set|Get) This will initialise the connection and import the data.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:852 </Published>
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

#region |2019/07/17 00h01:798| <05.00.01> <Sub> <> |.Close()|Sub}|"' (Set|Get) This willClosing the connection
     ///     <Summary>
 ///    (Set|Get) This willClosing the connection
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:853 </Published>
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

#region |2019/07/17 00h01:803| <05.00.02> <Sub> <> |.List()|Sub}|"' (Set|Get) Return the entire table listed
     ///     <Summary>
 ///    (Set|Get) Return the entire table listed
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:853 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Return the entire table listed") ]
    Let List = 
    Dim Result As New List(Of Prestations)
Me.Table = New Table(Me.TableName , Me.FilePath , Me.Password,False)
   For each Row As DataRow In Me.Table.DataTable.Rows
      Dim Element As New Prestations(IIf(IsDBNull(Row.Item(0)),0,Row.Item(0)),
IIf(IsDBNull(Row.Item(1)),"",Row.Item(1)),
IIf(IsDBNull(Row.Item(2)),"",Row.Item(2)),
      IIf(IsDBNull(Row.Item(3)),"",Row.Item(3)))
      Element.Reset(Table.Line)
 Result.Add(Element)
 Next
 Return Result
#endregion (Set|Get) Return the entire table listed

#region |2019/07/17 00h01:808| <05.00.03> <Sub> <> |.SearchByName()|Sub}|"' (Set|Get) Search for each property that match the Search String.
     ///     <Summary>
 ///    (Set|Get) Search for each property that match the Search String.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:853 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Search for each property that match the Search String.") ]
    Let SearchByName = 
    Dim Result As New List(Of Prestations)
 Dim C As New Prestations
 For Each Element As Prestations In C.List
 If Element.Description.Tolower() = Search.Tolower() Or Element.Service.Tolower() = Search.Tolower()  Or Element.Type.Tolower() = Search.Tolower() Then
      Result.Add(Element)
 End If
 Next
 Return Result
#endregion (Set|Get) Search for each property that match the Search String.

#region |2019/07/17 00h01:831| <05.00.04> <Sub> <> |.SearchByID()|Sub}|"' (Set|Get) Search for each property that match the Search Id.
     ///     <Summary>
 ///    (Set|Get) Search for each property that match the Search Id.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:853 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Search for each property that match the Search Id.") ]
    Let SearchByID = 
    Dim Result As New List(Of Prestations)
 Dim C As New Prestations
 For Each Element As Prestations In C.List
 If Val(Element.Description) = Search Then
      Result.Add(Element)
 End If
 Next
 Return Result
#endregion (Set|Get) Search for each property that match the Search Id.

#region |2019/07/17 00h01:838| <05.00.05> <Sub> <> |.ToString()|Sub}|"' (Set|Get) The function ToString.
     ///     <Summary>
 ///    (Set|Get) The function ToString.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:853 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The function ToString.") ]
    Let ToString = 
        Return Me.ID
#endregion (Set|Get) The function ToString.

#region |2019/07/17 00h01:844| <05.00.06> <Sub> <> |.CheckConnection()|Sub}|"' (Set|Get) Evaluate the connection to the DataBase
     ///     <Summary>
 ///    (Set|Get) Evaluate the connection to the DataBase
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:854 </Published>
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
#region |2019/07/17 00h01:850| <15.00.00> <Runtime> <> |.Table()|Runtime|  (Set|Get) The Table.
 ///     <Summary>
 ///    (Set|Get) The Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:854 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Table.") ]
   Public Table Table;
#endregion (Set|Get) The Table.

#region |2019/07/17 00h01:858| <15.00.01> <Runtime> <> |.Line()|Runtime|  (Set|Get) The Connection String To the Table.
 ///     <Summary>
 ///    (Set|Get) The Connection String To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:854 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Connection String To the Table.") ]
   Public String Line;
#endregion (Set|Get) The Connection String To the Table.

#region |2019/07/17 00h01:863| <15.00.02> <Runtime> <> |.FilePath()|Runtime|  (Set|Get) The FilePath To the Table.
 ///     <Summary>
 ///    (Set|Get) The FilePath To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:854 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The FilePath To the Table.") ]
   Public String FilePath;
#endregion (Set|Get) The FilePath To the Table.

#region |2019/07/17 00h01:870| <15.00.03> <Runtime> <> |.Password()|Runtime|  (Set|Get) The Password To the Table.
 ///     <Summary>
 ///    (Set|Get) The Password To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:854 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Password To the Table.") ]
   Public String Password;
#endregion (Set|Get) The Password To the Table.

#region |2019/07/17 00h01:879| <15.00.04> <Runtime> <> |.UseSQL()|Runtime|  (Set|Get) Determines if the Database Connection is of type SQL.
 ///     <Summary>
 ///    (Set|Get) Determines if the Database Connection is of type SQL.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:854 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Determines if the Database Connection is of type SQL.") ]
   Public Boolean UseSQL;
#endregion (Set|Get) Determines if the Database Connection is of type SQL.

#region |2019/07/17 00h01:885| <15.00.05> <Runtime> <> |.TableName()|Runtime|  (Set|Get) The name of the Table.
 ///     <Summary>
 ///    (Set|Get) The name of the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:854 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The name of the Table.") ]
   Public String TableName;
#endregion (Set|Get) The name of the Table.

#region |2019/07/17 00h01:890| <15.00.06> <Runtime> <> |.Con()|Runtime|  (Set|Get) The Con To the Table.
 ///     <Summary>
 ///    (Set|Get) The Con To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:854 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Con To the Table.") ]
   Public OleDb.OleDbConnection Con;
#endregion (Set|Get) The Con To the Table.

#region |2019/07/17 00h01:894| <15.00.07> <Runtime> <> |.Cmd()|Runtime|  (Set|Get) The Cmd To the Table.
 ///     <Summary>
 ///    (Set|Get) The Cmd To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:854 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Cmd To the Table.") ]
   Public OleDb.OleDbCommand Cmd;
#endregion (Set|Get) The Cmd To the Table.

#region |2019/07/17 00h01:900| <15.00.08> <Runtime> <> |.DataReader()|Runtime|  (Set|Get) The DataReader To the Table.
 ///     <Summary>
 ///    (Set|Get) The DataReader To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:855 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The DataReader To the Table.") ]
   Public OleDb.OleDbDataReader DataReader;
#endregion (Set|Get) The DataReader To the Table.

#region |2019/07/17 00h01:906| <15.00.09> <Runtime> <> |.DataAdapter()|Runtime|  (Set|Get) The DataAdapter To the Table.
 ///     <Summary>
 ///    (Set|Get) The DataAdapter To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:855 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The DataAdapter To the Table.") ]
   Public OleDb.OleDbDataAdapter DataAdapter;
#endregion (Set|Get) The DataAdapter To the Table.

#region |2019/07/17 00h01:940| <15.00.10> <Runtime> <> |.Connector()|Runtime|  (Set|Get) The Connector To the Table.
 ///     <Summary>
 ///    (Set|Get) The Connector To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:855 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Connector To the Table.") ]
   Public LineInfo Connector;
#endregion (Set|Get) The Connector To the Table.

#region |2019/07/17 00h01:945| <15.00.11> <Runtime> <> |.Log()|Runtime|  (Set|Get) The Log To the Table.
 ///     <Summary>
 ///    (Set|Get) The Log To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:855 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Log To the Table.") ]
   Public String Log;
#endregion (Set|Get) The Log To the Table.

#end region 
#region <7> [Loader]{2}
#region |2019/07/17 00h01:950| <06.00.00> <Sub> <> |.Empty()|Sub}|"' (Set|Get) The sub Empty.
     ///     <Summary>
 ///    (Set|Get) The sub Empty.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:855 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The sub Empty.") ]
    Let Empty = 
    Reset
#endregion (Set|Get) The sub Empty.

#region |2019/07/17 00h01:951| <06.00.01> <Sub> <> |.Filled()|Sub}|"' (Set|Get) The sub Filled.
     ///     <Summary>
 ///    (Set|Get) The sub Filled.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:855 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The sub Filled.") ]
    Let Filled = 
     With Me
 Clear()
 Reset()
     .ID = ID
     .Description = Description
     .Service = Service
     .Type = Type
 End With

#endregion (Set|Get) The sub Filled.

#end region 
}

 ///     <Summary>
 ///    Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Services
'''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
'''    Contributor Information : ||
'''    Creation Date :           2019/07/17 00h01:098
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
'''    |Selling Price without VAT   |70.75
'''    |Total TVA                   |5.45
'''    |Grand Total                 |76.2
'''    |/Schema|
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:862 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
public  class Services{
#region <1> [Property]{1}
#region |2019/07/17 00h01:099| <01.00.00> <Property> <Columns> |.Service()|String|  (Set|Get) The Service as String.
 ///     <Summary>
 ///    (Set|Get) The Service as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:862 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Service as String.") ]
    member this.Service()
       with get() = _Service
       and set(value) = _Service <- value
#endregion (Set|Get) The Service as String.

#end region 
#region <2> [Enumeration]{1}
#region |2019/07/17 00h01:108| <02.00.00> <Property> <> |.Schema()|Enumeration{0}|"' (Set|Get) The enumeration of Schema.
     ///     <Summary>
 ///    (Set|Get) The enumeration of Schema.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:862 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The enumeration of Schema.") ]
    Type Schema = 
/// <summary>(Set|Get) The Service as String.</summary>
|   [Service] = 0
#endregion (Set|Get) The enumeration of Schema.

#end region 
#region <4> [Sub]{5}
#region |2019/07/17 00h01:114| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
     ///     <Summary>
 ///    (Set|Get) This will reinitialize the class element.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:863 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will reinitialize the class element.") ]
    Let Clear = 
      With Me
        .Service = Nothing
 End With
#endregion (Set|Get) This will reinitialize the class element.

#region |2019/07/17 00h01:119| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
     ///     <Summary>
 ///    (Set|Get) This will reinitialize the variables of this class.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:863 </Published>
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
        TableName = "Services"
        Line = Connector.Line
        UseSQL = False
   Else
        FilePath = My.Settings.Db_Chronos_FilePath
        Password = My.Settings.Db_Chronos_Password
        Me.Line = My.Settings.Db_Chronos_Line
        TableName = "Services"
        UseSQL = False
   End If
Else
        If IsNothing(FilePath) Then 
             FilePath = My.Settings.Db_Chronos_FilePath
        End If 
        If FilePath.Length<1 Then 
             FilePath = My.Settings.Db_Chronos_FilePath
        End If 
        FilePath = My.Settings.Db_Chronos_FilePath
        Password = My.Settings.Db_Chronos_Password
        Me.Line = My.Settings.Db_Chronos_Line
        TableName = "Services"
        UseSQL = False
End If

#endregion (Set|Get) This will reinitialize the variables of this class.

#region |2019/07/17 00h01:143| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
     ///     <Summary>
 ///    (Set|Get) This will add a new row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:863 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will add a new row in the table.") ]
    Let Add = 
     Try
   Dim Str As String = Nothing
   Str = "Insert Into [Services] (
`Service`) Values (@0)"
Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
Cmd = New OleDb.OleDbCommand(Str,Con)
Con.Open()
            Cmd.Parameters.AddWithValue("@0", Me.Service)
          If Cmd.ExecuteNonQuery>=0 Then
          Else
              Msgbox("Element not Addd")
          End If
 Catch ex As Exception 
 Finally 
   Close(True) 
 End Try 

#endregion (Set|Get) This will add a new row in the table.

#region |2019/07/17 00h01:148| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
     ///     <Summary>
 ///    (Set|Get) This will update a row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:863 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will update a row in the table.") ]
    Let Save = 
     Try
   Dim Str As String = Nothing
   Str = "UPDATE [Services] SET Service = @Service WHERE Service = @Service"
Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
Cmd = New OleDb.OleDbCommand(Str,Con)
Con.Open()
      Cmd.Parameters.AddWithValue("@Service",Service)
      Cmd.Parameters.AddWithValue("@Service",Service)
          If Cmd.ExecuteNonQuery>=0 Then
          Else
              Msgbox("Element not Saved")
          End If
 Catch ex As Exception 
 Finally 
   Close(True) 
 End Try 

#endregion (Set|Get) This will update a row in the table.

#region |2019/07/17 00h01:153| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
     ///     <Summary>
 ///    (Set|Get) This will Delete a row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:863 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will Delete a row in the table.") ]
    Let Delete = 
     Try
   Dim Str As String = Nothing
   Str = "Delete From [Services] WHERE Service =@Service"
Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
Cmd = New OleDb.OleDbCommand(Str,Con)
Con.Open()
Cmd.Parameters.AddWithValue("@Service", Service)
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
#region |2019/07/17 00h01:160| <05.00.00> <Sub> <> |.Open()|Sub}|"' (Set|Get) This will initialise the connection and import the data.
     ///     <Summary>
 ///    (Set|Get) This will initialise the connection and import the data.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:863 </Published>
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

#region |2019/07/17 00h01:165| <05.00.01> <Sub> <> |.Close()|Sub}|"' (Set|Get) This willClosing the connection
     ///     <Summary>
 ///    (Set|Get) This willClosing the connection
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:863 </Published>
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

#region |2019/07/17 00h01:171| <05.00.02> <Sub> <> |.List()|Sub}|"' (Set|Get) Return the entire table listed
     ///     <Summary>
 ///    (Set|Get) Return the entire table listed
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:864 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Return the entire table listed") ]
    Let List = 
    Dim Result As New List(Of Services)
Me.Table = New Table(Me.TableName , Me.FilePath , Me.Password,False)
   For each Row As DataRow In Me.Table.DataTable.Rows
      Dim Element As New Services(IIF(IsDBNull(Row.Item(0)),"",Row.Item(0)))
      Element.Reset(Table.Line)
 Result.Add(Element)
 Next
 Return Result
#endregion (Set|Get) Return the entire table listed

#region |2019/07/17 00h01:177| <05.00.03> <Sub> <> |.SearchByName()|Sub}|"' (Set|Get) Search for each property that match the Search String.
     ///     <Summary>
 ///    (Set|Get) Search for each property that match the Search String.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:864 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Search for each property that match the Search String.") ]
    Let SearchByName = 
    Dim Result As New List(Of Services)
 Dim C As New Services
 For Each Element As Services In C.List
 If Element.Service.Tolower() = Search.Tolower() Then
      Result.Add(Element)
 End If
 Next
 Return Result
#endregion (Set|Get) Search for each property that match the Search String.

#region |2019/07/17 00h01:181| <05.00.04> <Sub> <> |.SearchByID()|Sub}|"' (Set|Get) Search for each property that match the Search Id.
     ///     <Summary>
 ///    (Set|Get) Search for each property that match the Search Id.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:864 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Search for each property that match the Search Id.") ]
    Let SearchByID = 
    Dim Result As New List(Of Services)
 Dim C As New Services
 For Each Element As Services In C.List
 Next
 Return Result
#endregion (Set|Get) Search for each property that match the Search Id.

#region |2019/07/17 00h01:186| <05.00.05> <Sub> <> |.ToString()|Sub}|"' (Set|Get) The function ToString.
     ///     <Summary>
 ///    (Set|Get) The function ToString.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:864 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The function ToString.") ]
    Let ToString = 
        Return Me.Service
#endregion (Set|Get) The function ToString.

#region |2019/07/17 00h01:191| <05.00.06> <Sub> <> |.CheckConnection()|Sub}|"' (Set|Get) Evaluate the connection to the DataBase
     ///     <Summary>
 ///    (Set|Get) Evaluate the connection to the DataBase
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:864 </Published>
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
#region |2019/07/17 00h01:196| <15.00.00> <Runtime> <> |.Table()|Runtime|  (Set|Get) The Table.
 ///     <Summary>
 ///    (Set|Get) The Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:864 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Table.") ]
   Public Table Table;
#endregion (Set|Get) The Table.

#region |2019/07/17 00h01:201| <15.00.01> <Runtime> <> |.Line()|Runtime|  (Set|Get) The Connection String To the Table.
 ///     <Summary>
 ///    (Set|Get) The Connection String To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:864 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Connection String To the Table.") ]
   Public String Line;
#endregion (Set|Get) The Connection String To the Table.

#region |2019/07/17 00h01:207| <15.00.02> <Runtime> <> |.FilePath()|Runtime|  (Set|Get) The FilePath To the Table.
 ///     <Summary>
 ///    (Set|Get) The FilePath To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:864 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The FilePath To the Table.") ]
   Public String FilePath;
#endregion (Set|Get) The FilePath To the Table.

#region |2019/07/17 00h01:212| <15.00.03> <Runtime> <> |.Password()|Runtime|  (Set|Get) The Password To the Table.
 ///     <Summary>
 ///    (Set|Get) The Password To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:865 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Password To the Table.") ]
   Public String Password;
#endregion (Set|Get) The Password To the Table.

#region |2019/07/17 00h01:236| <15.00.04> <Runtime> <> |.UseSQL()|Runtime|  (Set|Get) Determines if the Database Connection is of type SQL.
 ///     <Summary>
 ///    (Set|Get) Determines if the Database Connection is of type SQL.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:865 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Determines if the Database Connection is of type SQL.") ]
   Public Boolean UseSQL;
#endregion (Set|Get) Determines if the Database Connection is of type SQL.

#region |2019/07/17 00h01:241| <15.00.05> <Runtime> <> |.TableName()|Runtime|  (Set|Get) The name of the Table.
 ///     <Summary>
 ///    (Set|Get) The name of the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:865 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The name of the Table.") ]
   Public String TableName;
#endregion (Set|Get) The name of the Table.

#region |2019/07/17 00h01:247| <15.00.06> <Runtime> <> |.Con()|Runtime|  (Set|Get) The Con To the Table.
 ///     <Summary>
 ///    (Set|Get) The Con To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:865 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Con To the Table.") ]
   Public OleDb.OleDbConnection Con;
#endregion (Set|Get) The Con To the Table.

#region |2019/07/17 00h01:251| <15.00.07> <Runtime> <> |.Cmd()|Runtime|  (Set|Get) The Cmd To the Table.
 ///     <Summary>
 ///    (Set|Get) The Cmd To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:865 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Cmd To the Table.") ]
   Public OleDb.OleDbCommand Cmd;
#endregion (Set|Get) The Cmd To the Table.

#region |2019/07/17 00h01:257| <15.00.08> <Runtime> <> |.DataReader()|Runtime|  (Set|Get) The DataReader To the Table.
 ///     <Summary>
 ///    (Set|Get) The DataReader To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:865 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The DataReader To the Table.") ]
   Public OleDb.OleDbDataReader DataReader;
#endregion (Set|Get) The DataReader To the Table.

#region |2019/07/17 00h01:262| <15.00.09> <Runtime> <> |.DataAdapter()|Runtime|  (Set|Get) The DataAdapter To the Table.
 ///     <Summary>
 ///    (Set|Get) The DataAdapter To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:865 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The DataAdapter To the Table.") ]
   Public OleDb.OleDbDataAdapter DataAdapter;
#endregion (Set|Get) The DataAdapter To the Table.

#region |2019/07/17 00h01:268| <15.00.10> <Runtime> <> |.Connector()|Runtime|  (Set|Get) The Connector To the Table.
 ///     <Summary>
 ///    (Set|Get) The Connector To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:865 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Connector To the Table.") ]
   Public LineInfo Connector;
#endregion (Set|Get) The Connector To the Table.

#region |2019/07/17 00h01:275| <15.00.11> <Runtime> <> |.Log()|Runtime|  (Set|Get) The Log To the Table.
 ///     <Summary>
 ///    (Set|Get) The Log To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:866 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Log To the Table.") ]
   Public String Log;
#endregion (Set|Get) The Log To the Table.

#end region 
#region <7> [Loader]{2}
#region |2019/07/17 00h01:280| <06.00.00> <Sub> <> |.Empty()|Sub}|"' (Set|Get) The sub Empty.
     ///     <Summary>
 ///    (Set|Get) The sub Empty.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:866 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The sub Empty.") ]
    Let Empty = 
    Reset
#endregion (Set|Get) The sub Empty.

#region |2019/07/17 00h01:281| <06.00.01> <Sub> <> |.Filled()|Sub}|"' (Set|Get) The sub Filled.
     ///     <Summary>
 ///    (Set|Get) The sub Filled.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:866 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The sub Filled.") ]
    Let Filled = 
     With Me
 Clear()
 Reset()
     .Service = Service
 End With

#endregion (Set|Get) The sub Filled.

#end region 
}

 ///     <Summary>
 ///    Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Sociétés
'''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
'''    Contributor Information : ||
'''    Creation Date :           2019/07/17 00h01:392
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
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:871 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
public  class Sociétés{
#region <1> [Property]{4}
#region |2019/07/17 00h01:393| <01.00.00> <Property> <Columns> |.Ref()|String|  (Set|Get) The Ref as String.
 ///     <Summary>
 ///    (Set|Get) The Ref as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:871 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Ref as String.") ]
    member this.Ref()
       with get() = _Ref
       and set(value) = _Ref <- value
#endregion (Set|Get) The Ref as String.

#region |2019/07/17 00h01:399| <01.00.01> <Property> <Columns> |.RaisonSocial()|String|  (Set|Get) The RaisonSocial as String.
 ///     <Summary>
 ///    (Set|Get) The RaisonSocial as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:871 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The RaisonSocial as String.") ]
    member this.RaisonSocial()
       with get() = _RaisonSocial
       and set(value) = _RaisonSocial <- value
#endregion (Set|Get) The RaisonSocial as String.

#region |2019/07/17 00h01:405| <01.00.02> <Property> <Columns> |.NuméroTVA()|String|  (Set|Get) The NuméroTVA as String.
 ///     <Summary>
 ///    (Set|Get) The NuméroTVA as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:872 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The NuméroTVA as String.") ]
    member this.NuméroTVA()
       with get() = _NuméroTVA
       and set(value) = _NuméroTVA <- value
#endregion (Set|Get) The NuméroTVA as String.

#region |2019/07/17 00h01:410| <01.00.03> <Property> <Columns> |.Index()|Integer|  (Set|Get) The Index as Integer.
 ///     <Summary>
 ///    (Set|Get) The Index as Integer.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:872 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Index as Integer.") ]
    member this.Index()
       with get() = _Index
       and set(value) = _Index <- value
#endregion (Set|Get) The Index as Integer.

#end region 
#region <2> [Enumeration]{1}
#region |2019/07/17 00h01:418| <02.00.00> <Property> <> |.Schema()|Enumeration{3}|"' (Set|Get) The enumeration of Schema.
     ///     <Summary>
 ///    (Set|Get) The enumeration of Schema.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:872 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The enumeration of Schema.") ]
    Type Schema = 
/// <summary>(Set|Get) The Ref as String.</summary>
|   [Ref] = 0
/// <summary>(Set|Get) The RaisonSocial as String.</summary>
|   [RaisonSocial] = 1
/// <summary>(Set|Get) The NuméroTVA as String.</summary>
|   [NuméroTVA] = 2
/// <summary>(Set|Get) The Index as Integer.</summary>
|   [Index] = 3
#endregion (Set|Get) The enumeration of Schema.

#end region 
#region <4> [Sub]{5}
#region |2019/07/17 00h01:422| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
     ///     <Summary>
 ///    (Set|Get) This will reinitialize the class element.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:872 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will reinitialize the class element.") ]
    Let Clear = 
      With Me
        .Ref = Nothing
        .RaisonSocial = Nothing
        .NuméroTVA = Nothing
        .Index = 0
 End With
#endregion (Set|Get) This will reinitialize the class element.

#region |2019/07/17 00h01:427| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
     ///     <Summary>
 ///    (Set|Get) This will reinitialize the variables of this class.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:872 </Published>
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
        TableName = "Sociétés"
        Line = Connector.Line
        UseSQL = False
   Else
        FilePath = My.Settings.Db_Chronos_FilePath
        Password = My.Settings.Db_Chronos_Password
        Me.Line = My.Settings.Db_Chronos_Line
        TableName = "Sociétés"
        UseSQL = False
   End If
Else
        If IsNothing(FilePath) Then 
             FilePath = My.Settings.Db_Chronos_FilePath
        End If 
        If FilePath.Length<1 Then 
             FilePath = My.Settings.Db_Chronos_FilePath
        End If 
        FilePath = My.Settings.Db_Chronos_FilePath
        Password = My.Settings.Db_Chronos_Password
        Me.Line = My.Settings.Db_Chronos_Line
        TableName = "Sociétés"
        UseSQL = False
End If

#endregion (Set|Get) This will reinitialize the variables of this class.

#region |2019/07/17 00h01:438| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
     ///     <Summary>
 ///    (Set|Get) This will add a new row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:872 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will add a new row in the table.") ]
    Let Add = 
     Try
   Dim Str As String = Nothing
   Str = "Insert Into [Sociétés] (
`Ref`, 
`RaisonSocial`, 
`NuméroTVA`, 
`Index`) Values (@0, @1, @2, @3)"
Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
Cmd = New OleDb.OleDbCommand(Str,Con)
Con.Open()
            Cmd.Parameters.AddWithValue("@0", Me.Ref)
            Cmd.Parameters.AddWithValue("@1", Me.RaisonSocial)
            Cmd.Parameters.AddWithValue("@2", Me.NuméroTVA)
            Cmd.Parameters.AddWithValue("@3", Me.Index)
          If Cmd.ExecuteNonQuery>=0 Then
          Else
              Msgbox("Element not Addd")
          End If
 Catch ex As Exception 
 Finally 
   Close(True) 
 End Try 

#endregion (Set|Get) This will add a new row in the table.

#region |2019/07/17 00h01:455| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
     ///     <Summary>
 ///    (Set|Get) This will update a row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:873 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will update a row in the table.") ]
    Let Save = 
     Try
   Dim Str As String = Nothing
   Str = "UPDATE [Sociétés] SET RaisonSocial = @RaisonSocial, NuméroTVA = @NuméroTVA, Index = @Index WHERE Ref = @Ref"
Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
Cmd = New OleDb.OleDbCommand(Str,Con)
Con.Open()
      Cmd.Parameters.AddWithValue("@RaisonSocial",RaisonSocial)
      Cmd.Parameters.AddWithValue("@NuméroTVA",NuméroTVA)
      Cmd.Parameters.AddWithValue("@Index",Index)
      Cmd.Parameters.AddWithValue("@Ref",Ref)
          If Cmd.ExecuteNonQuery>=0 Then
          Else
              Msgbox("Element not Saved")
          End If
 Catch ex As Exception 
 Finally 
   Close(True) 
 End Try 

#endregion (Set|Get) This will update a row in the table.

#region |2019/07/17 00h01:460| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
     ///     <Summary>
 ///    (Set|Get) This will Delete a row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:873 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will Delete a row in the table.") ]
    Let Delete = 
     Try
   Dim Str As String = Nothing
   Str = "Delete From [Sociétés] WHERE Ref =@Ref"
Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
Cmd = New OleDb.OleDbCommand(Str,Con)
Con.Open()
Cmd.Parameters.AddWithValue("@Ref", Ref)
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
#region |2019/07/17 00h01:464| <05.00.00> <Sub> <> |.Open()|Sub}|"' (Set|Get) This will initialise the connection and import the data.
     ///     <Summary>
 ///    (Set|Get) This will initialise the connection and import the data.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:873 </Published>
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

#region |2019/07/17 00h01:474| <05.00.01> <Sub> <> |.Close()|Sub}|"' (Set|Get) This willClosing the connection
     ///     <Summary>
 ///    (Set|Get) This willClosing the connection
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:873 </Published>
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

#region |2019/07/17 00h01:485| <05.00.02> <Sub> <> |.List()|Sub}|"' (Set|Get) Return the entire table listed
     ///     <Summary>
 ///    (Set|Get) Return the entire table listed
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:873 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Return the entire table listed") ]
    Let List = 
    Dim Result As New List(Of Sociétés)
Me.Table = New Table(Me.TableName , Me.FilePath , Me.Password,False)
   For each Row As DataRow In Me.Table.DataTable.Rows
      Dim Element As New Sociétés(IIf(IsDBNull(Row.Item(0)),"",Row.Item(0)),
IIf(IsDBNull(Row.Item(1)),"",Row.Item(1)),
IIf(IsDBNull(Row.Item(2)),"",Row.Item(2)),
      IIf(IsDBNull(Row.Item(3)),0,Row.Item(3)))
      Element.Reset(Table.Line)
 Result.Add(Element)
 Next
 Return Result
#endregion (Set|Get) Return the entire table listed

#region |2019/07/17 00h01:492| <05.00.03> <Sub> <> |.SearchByName()|Sub}|"' (Set|Get) Search for each property that match the Search String.
     ///     <Summary>
 ///    (Set|Get) Search for each property that match the Search String.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:873 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Search for each property that match the Search String.") ]
    Let SearchByName = 
    Dim Result As New List(Of Sociétés)
 Dim C As New Sociétés
 For Each Element As Sociétés In C.List
 If Element.Ref.Tolower() = Search.Tolower() Or Element.RaisonSocial.Tolower() = Search.Tolower()  Or Element.NuméroTVA.Tolower() = Search.Tolower() Then
      Result.Add(Element)
 End If
 Next
 Return Result
#endregion (Set|Get) Search for each property that match the Search String.

#region |2019/07/17 00h01:501| <05.00.04> <Sub> <> |.SearchByID()|Sub}|"' (Set|Get) Search for each property that match the Search Id.
     ///     <Summary>
 ///    (Set|Get) Search for each property that match the Search Id.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:873 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Search for each property that match the Search Id.") ]
    Let SearchByID = 
    Dim Result As New List(Of Sociétés)
 Dim C As New Sociétés
 For Each Element As Sociétés In C.List
 If Val(Element.Ref) = Search Then
      Result.Add(Element)
 End If
 Next
 Return Result
#endregion (Set|Get) Search for each property that match the Search Id.

#region |2019/07/17 00h01:511| <05.00.05> <Sub> <> |.ToString()|Sub}|"' (Set|Get) The function ToString.
     ///     <Summary>
 ///    (Set|Get) The function ToString.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:873 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The function ToString.") ]
    Let ToString = 
        Return Me.Ref
#endregion (Set|Get) The function ToString.

#region |2019/07/17 00h01:519| <05.00.06> <Sub> <> |.CheckConnection()|Sub}|"' (Set|Get) Evaluate the connection to the DataBase
     ///     <Summary>
 ///    (Set|Get) Evaluate the connection to the DataBase
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:874 </Published>
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
#region |2019/07/17 00h01:529| <15.00.00> <Runtime> <> |.Table()|Runtime|  (Set|Get) The Table.
 ///     <Summary>
 ///    (Set|Get) The Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:874 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Table.") ]
   Public Table Table;
#endregion (Set|Get) The Table.

#region |2019/07/17 00h01:538| <15.00.01> <Runtime> <> |.Line()|Runtime|  (Set|Get) The Connection String To the Table.
 ///     <Summary>
 ///    (Set|Get) The Connection String To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:874 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Connection String To the Table.") ]
   Public String Line;
#endregion (Set|Get) The Connection String To the Table.

#region |2019/07/17 00h01:547| <15.00.02> <Runtime> <> |.FilePath()|Runtime|  (Set|Get) The FilePath To the Table.
 ///     <Summary>
 ///    (Set|Get) The FilePath To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:874 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The FilePath To the Table.") ]
   Public String FilePath;
#endregion (Set|Get) The FilePath To the Table.

#region |2019/07/17 00h01:555| <15.00.03> <Runtime> <> |.Password()|Runtime|  (Set|Get) The Password To the Table.
 ///     <Summary>
 ///    (Set|Get) The Password To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:874 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Password To the Table.") ]
   Public String Password;
#endregion (Set|Get) The Password To the Table.

#region |2019/07/17 00h01:581| <15.00.04> <Runtime> <> |.UseSQL()|Runtime|  (Set|Get) Determines if the Database Connection is of type SQL.
 ///     <Summary>
 ///    (Set|Get) Determines if the Database Connection is of type SQL.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:874 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Determines if the Database Connection is of type SQL.") ]
   Public Boolean UseSQL;
#endregion (Set|Get) Determines if the Database Connection is of type SQL.

#region |2019/07/17 00h01:589| <15.00.05> <Runtime> <> |.TableName()|Runtime|  (Set|Get) The name of the Table.
 ///     <Summary>
 ///    (Set|Get) The name of the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:874 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The name of the Table.") ]
   Public String TableName;
#endregion (Set|Get) The name of the Table.

#region |2019/07/17 00h01:596| <15.00.06> <Runtime> <> |.Con()|Runtime|  (Set|Get) The Con To the Table.
 ///     <Summary>
 ///    (Set|Get) The Con To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:874 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Con To the Table.") ]
   Public OleDb.OleDbConnection Con;
#endregion (Set|Get) The Con To the Table.

#region |2019/07/17 00h01:600| <15.00.07> <Runtime> <> |.Cmd()|Runtime|  (Set|Get) The Cmd To the Table.
 ///     <Summary>
 ///    (Set|Get) The Cmd To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:874 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Cmd To the Table.") ]
   Public OleDb.OleDbCommand Cmd;
#endregion (Set|Get) The Cmd To the Table.

#region |2019/07/17 00h01:606| <15.00.08> <Runtime> <> |.DataReader()|Runtime|  (Set|Get) The DataReader To the Table.
 ///     <Summary>
 ///    (Set|Get) The DataReader To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:875 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The DataReader To the Table.") ]
   Public OleDb.OleDbDataReader DataReader;
#endregion (Set|Get) The DataReader To the Table.

#region |2019/07/17 00h01:613| <15.00.09> <Runtime> <> |.DataAdapter()|Runtime|  (Set|Get) The DataAdapter To the Table.
 ///     <Summary>
 ///    (Set|Get) The DataAdapter To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:875 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The DataAdapter To the Table.") ]
   Public OleDb.OleDbDataAdapter DataAdapter;
#endregion (Set|Get) The DataAdapter To the Table.

#region |2019/07/17 00h01:619| <15.00.10> <Runtime> <> |.Connector()|Runtime|  (Set|Get) The Connector To the Table.
 ///     <Summary>
 ///    (Set|Get) The Connector To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:875 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Connector To the Table.") ]
   Public LineInfo Connector;
#endregion (Set|Get) The Connector To the Table.

#region |2019/07/17 00h01:625| <15.00.11> <Runtime> <> |.Log()|Runtime|  (Set|Get) The Log To the Table.
 ///     <Summary>
 ///    (Set|Get) The Log To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:875 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Log To the Table.") ]
   Public String Log;
#endregion (Set|Get) The Log To the Table.

#end region 
#region <7> [Loader]{2}
#region |2019/07/17 00h01:632| <06.00.00> <Sub> <> |.Empty()|Sub}|"' (Set|Get) The sub Empty.
     ///     <Summary>
 ///    (Set|Get) The sub Empty.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:875 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The sub Empty.") ]
    Let Empty = 
    Reset
#endregion (Set|Get) The sub Empty.

#region |2019/07/17 00h01:633| <06.00.01> <Sub> <> |.Filled()|Sub}|"' (Set|Get) The sub Filled.
     ///     <Summary>
 ///    (Set|Get) The sub Filled.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:875 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The sub Filled.") ]
    Let Filled = 
     With Me
 Clear()
 Reset()
     .Ref = Ref
     .RaisonSocial = RaisonSocial
     .NuméroTVA = NuméroTVA
     .Index = Index
 End With

#endregion (Set|Get) The sub Filled.

#end region 
}

 ///     <Summary>
 ///    Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Tarif
'''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
'''    Contributor Information : ||
'''    Creation Date :           2019/07/17 00h01:731
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
'''    |Selling Price without VAT   |88.75
'''    |Total TVA                   |6.83
'''    |Grand Total                 |95.58
'''    |/Schema|
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:881 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
public  class Tarif{
#region <1> [Property]{5}
#region |2019/07/17 00h01:735| <01.00.00> <Property> <Columns> |.ID()|Integer|  (Set|Get) The ID as Integer.
 ///     <Summary>
 ///    (Set|Get) The ID as Integer.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:881 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ID as Integer.") ]
    member this.ID()
       with get() = _ID
       and set(value) = _ID <- value
#endregion (Set|Get) The ID as Integer.

#region |2019/07/17 00h01:753| <01.00.01> <Property> <Columns> |.Code()|String|  (Set|Get) The Code as String.
 ///     <Summary>
 ///    (Set|Get) The Code as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:882 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Code as String.") ]
    member this.Code()
       with get() = _Code
       and set(value) = _Code <- value
#endregion (Set|Get) The Code as String.

#region |2019/07/17 00h01:758| <01.00.02> <Property> <Columns> |.Collaborateur()|String|  (Set|Get) The Collaborateur as String.
 ///     <Summary>
 ///    (Set|Get) The Collaborateur as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:882 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Collaborateur as String.") ]
    member this.Collaborateur()
       with get() = _Collaborateur
       and set(value) = _Collaborateur <- value
#endregion (Set|Get) The Collaborateur as String.

#region |2019/07/17 00h01:763| <01.00.03> <Property> <Columns> |.DateIN()|DateTime|  (Set|Get) The DateIN as DateTime.
 ///     <Summary>
 ///    (Set|Get) The DateIN as DateTime.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:882 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The DateIN as DateTime.") ]
    member this.DateIN()
       with get() = _DateIN
       and set(value) = _DateIN <- value
#endregion (Set|Get) The DateIN as DateTime.

#region |2019/07/17 00h01:769| <01.00.04> <Property> <Columns> |.Price()|Double|  (Set|Get) The Price as Double.
 ///     <Summary>
 ///    (Set|Get) The Price as Double.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:882 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Price as Double.") ]
    member this.Price()
       with get() = _Price
       and set(value) = _Price <- value
#endregion (Set|Get) The Price as Double.

#end region 
#region <2> [Enumeration]{1}
#region |2019/07/17 00h01:774| <02.00.00> <Property> <> |.Schema()|Enumeration{4}|"' (Set|Get) The enumeration of Schema.
     ///     <Summary>
 ///    (Set|Get) The enumeration of Schema.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:883 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The enumeration of Schema.") ]
    Type Schema = 
/// <summary>(Set|Get) The ID as Integer.</summary>
|   [ID] = 0
/// <summary>(Set|Get) The Code as String.</summary>
|   [Code] = 1
/// <summary>(Set|Get) The Collaborateur as String.</summary>
|   [Collaborateur] = 2
/// <summary>(Set|Get) The DateIN as DateTime.</summary>
|   [DateIN] = 3
/// <summary>(Set|Get) The Price as Double.</summary>
|   [Price] = 4
#endregion (Set|Get) The enumeration of Schema.

#end region 
#region <4> [Sub]{5}
#region |2019/07/17 00h01:778| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
     ///     <Summary>
 ///    (Set|Get) This will reinitialize the class element.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:883 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will reinitialize the class element.") ]
    Let Clear = 
      With Me
        .ID = 0
        .Code = Nothing
        .Collaborateur = Nothing
         .DateIN = New DateTime
        .Price = 0
 End With
#endregion (Set|Get) This will reinitialize the class element.

#region |2019/07/17 00h01:782| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
     ///     <Summary>
 ///    (Set|Get) This will reinitialize the variables of this class.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:883 </Published>
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
        TableName = "Tarif"
        Line = Connector.Line
        UseSQL = False
   Else
        FilePath = My.Settings.Db_Chronos_FilePath
        Password = My.Settings.Db_Chronos_Password
        Me.Line = My.Settings.Db_Chronos_Line
        TableName = "Tarif"
        UseSQL = False
   End If
Else
        If IsNothing(FilePath) Then 
             FilePath = My.Settings.Db_Chronos_FilePath
        End If 
        If FilePath.Length<1 Then 
             FilePath = My.Settings.Db_Chronos_FilePath
        End If 
        FilePath = My.Settings.Db_Chronos_FilePath
        Password = My.Settings.Db_Chronos_Password
        Me.Line = My.Settings.Db_Chronos_Line
        TableName = "Tarif"
        UseSQL = False
End If

#endregion (Set|Get) This will reinitialize the variables of this class.

#region |2019/07/17 00h01:788| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
     ///     <Summary>
 ///    (Set|Get) This will add a new row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:883 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will add a new row in the table.") ]
    Let Add = 
     Try
   Dim Str As String = Nothing
   Str = "Insert Into [Tarif] (
`ID`, 
`Code`, 
`Collaborateur`, 
`DateIN`, 
`Price`) Values (@0, @1, @2, @3, @4)"
Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
Cmd = New OleDb.OleDbCommand(Str,Con)
Con.Open()
            Cmd.Parameters.AddWithValue("@0", Me.ID)
            Cmd.Parameters.AddWithValue("@1", Me.Code)
            Cmd.Parameters.AddWithValue("@2", Me.Collaborateur)
            Cmd.Parameters.AddWithValue("@3", Me.DateIN)
            Cmd.Parameters.AddWithValue("@4", Me.Price)
          If Cmd.ExecuteNonQuery>=0 Then
          Else
              Msgbox("Element not Addd")
          End If
 Catch ex As Exception 
 Finally 
   Close(True) 
 End Try 

#endregion (Set|Get) This will add a new row in the table.

#region |2019/07/17 00h01:792| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
     ///     <Summary>
 ///    (Set|Get) This will update a row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:883 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will update a row in the table.") ]
    Let Save = 
     Try
   Dim Str As String = Nothing
   Str = "UPDATE [Tarif] SET Code = @Code, Collaborateur = @Collaborateur, DateIN = @DateIN, Price = @Price WHERE ID = @ID"
Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
Cmd = New OleDb.OleDbCommand(Str,Con)
Con.Open()
      Cmd.Parameters.AddWithValue("@Code",Code)
      Cmd.Parameters.AddWithValue("@Collaborateur",Collaborateur)
      Cmd.Parameters.AddWithValue("@DateIN",DateIN)
      Cmd.Parameters.AddWithValue("@Price",Price)
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

#region |2019/07/17 00h01:796| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
     ///     <Summary>
 ///    (Set|Get) This will Delete a row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:883 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will Delete a row in the table.") ]
    Let Delete = 
     Try
   Dim Str As String = Nothing
   Str = "Delete From [Tarif] WHERE ID =@ID"
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
#region |2019/07/17 00h01:800| <05.00.00> <Sub> <> |.Open()|Sub}|"' (Set|Get) This will initialise the connection and import the data.
     ///     <Summary>
 ///    (Set|Get) This will initialise the connection and import the data.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:883 </Published>
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

#region |2019/07/17 00h01:805| <05.00.01> <Sub> <> |.Close()|Sub}|"' (Set|Get) This willClosing the connection
     ///     <Summary>
 ///    (Set|Get) This willClosing the connection
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:883 </Published>
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

#region |2019/07/17 00h01:810| <05.00.02> <Sub> <> |.List()|Sub}|"' (Set|Get) Return the entire table listed
     ///     <Summary>
 ///    (Set|Get) Return the entire table listed
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:884 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Return the entire table listed") ]
    Let List = 
    Dim Result As New List(Of Tarif)
Me.Table = New Table(Me.TableName , Me.FilePath , Me.Password,False)
   For each Row As DataRow In Me.Table.DataTable.Rows
      Dim Element As New Tarif(IIf(IsDBNull(Row.Item(0)),0,Row.Item(0)),
IIf(IsDBNull(Row.Item(1)),"",Row.Item(1)),
IIf(IsDBNull(Row.Item(2)),"",Row.Item(2)),
IIf(IsDBNull(Row.Item(3)),New DateTime(1970,1,1),Row.Item(3)),
      IIf(IsDBNull(Row.Item(4)),0,Row.Item(4)))
      Element.Reset(Table.Line)
 Result.Add(Element)
 Next
 Return Result
#endregion (Set|Get) Return the entire table listed

#region |2019/07/17 00h01:814| <05.00.03> <Sub> <> |.SearchByName()|Sub}|"' (Set|Get) Search for each property that match the Search String.
     ///     <Summary>
 ///    (Set|Get) Search for each property that match the Search String.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:884 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Search for each property that match the Search String.") ]
    Let SearchByName = 
    Dim Result As New List(Of Tarif)
 Dim C As New Tarif
 For Each Element As Tarif In C.List
 If Element.Code.Tolower() = Search.Tolower() Or Element.Collaborateur.Tolower() = Search.Tolower() Then
      Result.Add(Element)
 End If
 Next
 Return Result
#endregion (Set|Get) Search for each property that match the Search String.

#region |2019/07/17 00h01:820| <05.00.04> <Sub> <> |.SearchByID()|Sub}|"' (Set|Get) Search for each property that match the Search Id.
     ///     <Summary>
 ///    (Set|Get) Search for each property that match the Search Id.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:884 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Search for each property that match the Search Id.") ]
    Let SearchByID = 
    Dim Result As New List(Of Tarif)
 Dim C As New Tarif
 For Each Element As Tarif In C.List
 If Val(Element.ID) = Search Or Val(Element.Price) = Search Then
      Result.Add(Element)
 End If
 Next
 Return Result
#endregion (Set|Get) Search for each property that match the Search Id.

#region |2019/07/17 00h01:845| <05.00.05> <Sub> <> |.ToString()|Sub}|"' (Set|Get) The function ToString.
     ///     <Summary>
 ///    (Set|Get) The function ToString.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:884 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The function ToString.") ]
    Let ToString = 
        Return Me.ID
#endregion (Set|Get) The function ToString.

#region |2019/07/17 00h01:850| <05.00.06> <Sub> <> |.CheckConnection()|Sub}|"' (Set|Get) Evaluate the connection to the DataBase
     ///     <Summary>
 ///    (Set|Get) Evaluate the connection to the DataBase
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:884 </Published>
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
#region |2019/07/17 00h01:855| <15.00.00> <Runtime> <> |.Table()|Runtime|  (Set|Get) The Table.
 ///     <Summary>
 ///    (Set|Get) The Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:885 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Table.") ]
   Public Table Table;
#endregion (Set|Get) The Table.

#region |2019/07/17 00h01:860| <15.00.01> <Runtime> <> |.Line()|Runtime|  (Set|Get) The Connection String To the Table.
 ///     <Summary>
 ///    (Set|Get) The Connection String To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:886 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Connection String To the Table.") ]
   Public String Line;
#endregion (Set|Get) The Connection String To the Table.

#region |2019/07/17 00h01:864| <15.00.02> <Runtime> <> |.FilePath()|Runtime|  (Set|Get) The FilePath To the Table.
 ///     <Summary>
 ///    (Set|Get) The FilePath To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:886 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The FilePath To the Table.") ]
   Public String FilePath;
#endregion (Set|Get) The FilePath To the Table.

#region |2019/07/17 00h01:870| <15.00.03> <Runtime> <> |.Password()|Runtime|  (Set|Get) The Password To the Table.
 ///     <Summary>
 ///    (Set|Get) The Password To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:886 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Password To the Table.") ]
   Public String Password;
#endregion (Set|Get) The Password To the Table.

#region |2019/07/17 00h01:876| <15.00.04> <Runtime> <> |.UseSQL()|Runtime|  (Set|Get) Determines if the Database Connection is of type SQL.
 ///     <Summary>
 ///    (Set|Get) Determines if the Database Connection is of type SQL.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:886 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Determines if the Database Connection is of type SQL.") ]
   Public Boolean UseSQL;
#endregion (Set|Get) Determines if the Database Connection is of type SQL.

#region |2019/07/17 00h01:881| <15.00.05> <Runtime> <> |.TableName()|Runtime|  (Set|Get) The name of the Table.
 ///     <Summary>
 ///    (Set|Get) The name of the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:886 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The name of the Table.") ]
   Public String TableName;
#endregion (Set|Get) The name of the Table.

#region |2019/07/17 00h01:885| <15.00.06> <Runtime> <> |.Con()|Runtime|  (Set|Get) The Con To the Table.
 ///     <Summary>
 ///    (Set|Get) The Con To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:886 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Con To the Table.") ]
   Public OleDb.OleDbConnection Con;
#endregion (Set|Get) The Con To the Table.

#region |2019/07/17 00h01:888| <15.00.07> <Runtime> <> |.Cmd()|Runtime|  (Set|Get) The Cmd To the Table.
 ///     <Summary>
 ///    (Set|Get) The Cmd To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:886 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Cmd To the Table.") ]
   Public OleDb.OleDbCommand Cmd;
#endregion (Set|Get) The Cmd To the Table.

#region |2019/07/17 00h01:894| <15.00.08> <Runtime> <> |.DataReader()|Runtime|  (Set|Get) The DataReader To the Table.
 ///     <Summary>
 ///    (Set|Get) The DataReader To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:887 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The DataReader To the Table.") ]
   Public OleDb.OleDbDataReader DataReader;
#endregion (Set|Get) The DataReader To the Table.

#region |2019/07/17 00h01:899| <15.00.09> <Runtime> <> |.DataAdapter()|Runtime|  (Set|Get) The DataAdapter To the Table.
 ///     <Summary>
 ///    (Set|Get) The DataAdapter To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:887 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The DataAdapter To the Table.") ]
   Public OleDb.OleDbDataAdapter DataAdapter;
#endregion (Set|Get) The DataAdapter To the Table.

#region |2019/07/17 00h01:903| <15.00.10> <Runtime> <> |.Connector()|Runtime|  (Set|Get) The Connector To the Table.
 ///     <Summary>
 ///    (Set|Get) The Connector To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:887 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Connector To the Table.") ]
   Public LineInfo Connector;
#endregion (Set|Get) The Connector To the Table.

#region |2019/07/17 00h01:913| <15.00.11> <Runtime> <> |.Log()|Runtime|  (Set|Get) The Log To the Table.
 ///     <Summary>
 ///    (Set|Get) The Log To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:887 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Log To the Table.") ]
   Public String Log;
#endregion (Set|Get) The Log To the Table.

#end region 
#region <7> [Loader]{2}
#region |2019/07/17 00h01:925| <06.00.00> <Sub> <> |.Empty()|Sub}|"' (Set|Get) The sub Empty.
     ///     <Summary>
 ///    (Set|Get) The sub Empty.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:887 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The sub Empty.") ]
    Let Empty = 
    Reset
#endregion (Set|Get) The sub Empty.

#region |2019/07/17 00h01:928| <06.00.01> <Sub> <> |.Filled()|Sub}|"' (Set|Get) The sub Filled.
     ///     <Summary>
 ///    (Set|Get) The sub Filled.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:887 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The sub Filled.") ]
    Let Filled = 
     With Me
 Clear()
 Reset()
     .ID = ID
     .Code = Code
     .Collaborateur = Collaborateur
     .DateIN = DateIN
     .Price = Price
 End With

#endregion (Set|Get) The sub Filled.

#end region 
}

 ///     <Summary>
 ///    Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class TimeSheet
'''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
'''    Contributor Information : ||
'''    Creation Date :           2019/07/17 00h01:104
'''    |Schema|
'''    |ID| |ObjectType |{Quantity}||UnitPrice||Total
'''    |00| |Importation|{0}||1| |0
'''    |01| |Properties |{11}||0.8| |8.8
'''    |02| |Enumeration|{1}||0.4| |0.4
'''    |03| |Structure  |{0}||0.4| |0
'''    |04| |Sub        |{5}||1.2| |6
'''    |05| |Function   |{8}||1.6| |12.8
'''    |06| |Runtime    |{12}||0.4| |4.8
'''    |07| |Loader     |{2}||0.8| |1.6
'''    |08| |Class      |{0}||2| |0
'''    |09| |Constante  |{0}||0.4| |0
'''    |10| |Event      |{0}||1.2| |0
'''    |11| |Members    |{11}||0.5| |5.5
'''    |12| |Parameter  |{16}||0.5| |8
'''    |Production Cost             |47.9
'''    |Selling Price without VAT   |119.75
'''    |Total TVA                   |9.22
'''    |Grand Total                 |128.97
'''    |/Schema|
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:892 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
public  class TimeSheet{
#region <1> [Property]{11}
#region |2019/07/17 00h01:104| <01.00.00> <Property> <Columns> |.ID()|Integer|  (Set|Get) The ID as Integer.
 ///     <Summary>
 ///    (Set|Get) The ID as Integer.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:892 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The ID as Integer.") ]
    member this.ID()
       with get() = _ID
       and set(value) = _ID <- value
#endregion (Set|Get) The ID as Integer.

#region |2019/07/17 00h01:113| <01.00.01> <Property> <Columns> |.Active()|Boolean|  (Set|Get) The Active as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Active as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:893 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Active as Boolean.") ]
    member this.Active()
       with get() = _Active
       and set(value) = _Active <- value
#endregion (Set|Get) The Active as Boolean.

#region |2019/07/17 00h01:120| <01.00.02> <Property> <Columns> |.TimeIn()|DateTime|  (Set|Get) The TimeIn as DateTime.
 ///     <Summary>
 ///    (Set|Get) The TimeIn as DateTime.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:893 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The TimeIn as DateTime.") ]
    member this.TimeIn()
       with get() = _TimeIn
       and set(value) = _TimeIn <- value
#endregion (Set|Get) The TimeIn as DateTime.

#region |2019/07/17 00h01:144| <01.00.03> <Property> <Columns> |.Collaborateur()|String|  (Set|Get) The Collaborateur as String.
 ///     <Summary>
 ///    (Set|Get) The Collaborateur as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:893 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Collaborateur as String.") ]
    member this.Collaborateur()
       with get() = _Collaborateur
       and set(value) = _Collaborateur <- value
#endregion (Set|Get) The Collaborateur as String.

#region |2019/07/17 00h01:150| <01.00.04> <Property> <Columns> |.Mandat()|String|  (Set|Get) The Mandat as String.
 ///     <Summary>
 ///    (Set|Get) The Mandat as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:893 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Mandat as String.") ]
    member this.Mandat()
       with get() = _Mandat
       and set(value) = _Mandat <- value
#endregion (Set|Get) The Mandat as String.

#region |2019/07/17 00h01:156| <01.00.05> <Property> <Columns> |.Quantity()|Double|  (Set|Get) The Quantity as Double.
 ///     <Summary>
 ///    (Set|Get) The Quantity as Double.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:893 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Quantity as Double.") ]
    member this.Quantity()
       with get() = _Quantity
       and set(value) = _Quantity <- value
#endregion (Set|Get) The Quantity as Double.

#region |2019/07/17 00h01:162| <01.00.06> <Property> <Columns> |.UnitPrice()|Double|  (Set|Get) The UnitPrice as Double.
 ///     <Summary>
 ///    (Set|Get) The UnitPrice as Double.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:893 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The UnitPrice as Double.") ]
    member this.UnitPrice()
       with get() = _UnitPrice
       and set(value) = _UnitPrice <- value
#endregion (Set|Get) The UnitPrice as Double.

#region |2019/07/17 00h01:168| <01.00.07> <Property> <Columns> |.Description()|String|  (Set|Get) The Description as String.
 ///     <Summary>
 ///    (Set|Get) The Description as String.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:894 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Description as String.") ]
    member this.Description()
       with get() = _Description
       and set(value) = _Description <- value
#endregion (Set|Get) The Description as String.

#region |2019/07/17 00h01:174| <01.00.08> <Property> <Columns> |.Facturable()|Boolean|  (Set|Get) The Facturable as Boolean.
 ///     <Summary>
 ///    (Set|Get) The Facturable as Boolean.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:894 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Facturable as Boolean.") ]
    member this.Facturable()
       with get() = _Facturable
       and set(value) = _Facturable <- value
#endregion (Set|Get) The Facturable as Boolean.

#region |2019/07/17 00h01:181| <01.00.09> <Property> <Columns> |.TotalHTVA()|Double|  (Set|Get) The TotalHTVA as Double.
 ///     <Summary>
 ///    (Set|Get) The TotalHTVA as Double.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:894 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The TotalHTVA as Double.") ]
    member this.TotalHTVA()
       with get() = _TotalHTVA
       and set(value) = _TotalHTVA <- value
#endregion (Set|Get) The TotalHTVA as Double.

#region |2019/07/17 00h01:187| <01.00.10> <Property> <Columns> |.Total()|Double|  (Set|Get) The Total as Double.
 ///     <Summary>
 ///    (Set|Get) The Total as Double.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:894 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Columns") , Description("(Set|Get) The Total as Double.") ]
    member this.Total()
       with get() = _Total
       and set(value) = _Total <- value
#endregion (Set|Get) The Total as Double.

#end region 
#region <2> [Enumeration]{1}
#region |2019/07/17 00h01:194| <02.00.00> <Property> <> |.Schema()|Enumeration{10}|"' (Set|Get) The enumeration of Schema.
     ///     <Summary>
 ///    (Set|Get) The enumeration of Schema.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:894 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The enumeration of Schema.") ]
    Type Schema = 
/// <summary>(Set|Get) The ID as Integer.</summary>
|   [ID] = 0
/// <summary>(Set|Get) The Active as Boolean.</summary>
|   [Active] = 1
/// <summary>(Set|Get) The TimeIn as DateTime.</summary>
|   [TimeIn] = 2
/// <summary>(Set|Get) The Collaborateur as String.</summary>
|   [Collaborateur] = 3
/// <summary>(Set|Get) The Mandat as String.</summary>
|   [Mandat] = 4
/// <summary>(Set|Get) The Quantity as Double.</summary>
|   [Quantity] = 5
/// <summary>(Set|Get) The UnitPrice as Double.</summary>
|   [UnitPrice] = 6
/// <summary>(Set|Get) The Description as String.</summary>
|   [Description] = 7
/// <summary>(Set|Get) The Facturable as Boolean.</summary>
|   [Facturable] = 8
/// <summary>(Set|Get) The TotalHTVA as Double.</summary>
|   [TotalHTVA] = 9
/// <summary>(Set|Get) The Total as Double.</summary>
|   [Total] = 10
#endregion (Set|Get) The enumeration of Schema.

#end region 
#region <4> [Sub]{5}
#region |2019/07/17 00h01:199| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
     ///     <Summary>
 ///    (Set|Get) This will reinitialize the class element.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:895 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will reinitialize the class element.") ]
    Let Clear = 
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
#endregion (Set|Get) This will reinitialize the class element.

#region |2019/07/17 00h01:203| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
     ///     <Summary>
 ///    (Set|Get) This will reinitialize the variables of this class.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:895 </Published>
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
        TableName = "TimeSheet"
        Line = Connector.Line
        UseSQL = False
   Else
        FilePath = My.Settings.Db_Chronos_FilePath
        Password = My.Settings.Db_Chronos_Password
        Me.Line = My.Settings.Db_Chronos_Line
        TableName = "TimeSheet"
        UseSQL = False
   End If
Else
        If IsNothing(FilePath) Then 
             FilePath = My.Settings.Db_Chronos_FilePath
        End If 
        If FilePath.Length<1 Then 
             FilePath = My.Settings.Db_Chronos_FilePath
        End If 
        FilePath = My.Settings.Db_Chronos_FilePath
        Password = My.Settings.Db_Chronos_Password
        Me.Line = My.Settings.Db_Chronos_Line
        TableName = "TimeSheet"
        UseSQL = False
End If

#endregion (Set|Get) This will reinitialize the variables of this class.

#region |2019/07/17 00h01:209| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
     ///     <Summary>
 ///    (Set|Get) This will add a new row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:895 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will add a new row in the table.") ]
    Let Add = 
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
Cmd = New OleDb.OleDbCommand(Str,Con)
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
          If Cmd.ExecuteNonQuery>=0 Then
          Else
              Msgbox("Element not Addd")
          End If
 Catch ex As Exception 
 Finally 
   Close(True) 
 End Try 

#endregion (Set|Get) This will add a new row in the table.

#region |2019/07/17 00h01:214| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
     ///     <Summary>
 ///    (Set|Get) This will update a row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:895 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will update a row in the table.") ]
    Let Save = 
     Try
   Dim Str As String = Nothing
   Str = "UPDATE [TimeSheet] SET Active = @Active, TimeIn = @TimeIn, Collaborateur = @Collaborateur, Mandat = @Mandat, Quantity = @Quantity, UnitPrice = @UnitPrice, Description = @Description, Facturable = @Facturable, TotalHTVA = @TotalHTVA, Total = @Total WHERE ID = @ID"
Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
Cmd = New OleDb.OleDbCommand(Str,Con)
Con.Open()
      Cmd.Parameters.AddWithValue("@Active",Active)
      Cmd.Parameters.AddWithValue("@TimeIn",TimeIn)
      Cmd.Parameters.AddWithValue("@Collaborateur",Collaborateur)
      Cmd.Parameters.AddWithValue("@Mandat",Mandat)
      Cmd.Parameters.AddWithValue("@Quantity",Quantity)
      Cmd.Parameters.AddWithValue("@UnitPrice",UnitPrice)
      Cmd.Parameters.AddWithValue("@Description",Description)
      Cmd.Parameters.AddWithValue("@Facturable",Facturable)
      Cmd.Parameters.AddWithValue("@TotalHTVA",TotalHTVA)
      Cmd.Parameters.AddWithValue("@Total",Total)
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

#region |2019/07/17 00h01:219| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
     ///     <Summary>
 ///    (Set|Get) This will Delete a row in the table.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:895 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will Delete a row in the table.") ]
    Let Delete = 
     Try
   Dim Str As String = Nothing
   Str = "Delete From [TimeSheet] WHERE ID =@ID"
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
#region <5> [Function]{8}
#region |2019/07/17 00h01:224| <05.00.00> <Sub> <> |.Open()|Sub}|"' (Set|Get) This will initialise the connection and import the data.
     ///     <Summary>
 ///    (Set|Get) This will initialise the connection and import the data.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:895 </Published>
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

#region |2019/07/17 00h01:229| <05.00.01> <Sub> <> |.Close()|Sub}|"' (Set|Get) This willClosing the connection
     ///     <Summary>
 ///    (Set|Get) This willClosing the connection
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:895 </Published>
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

#region |2019/07/17 00h01:253| <05.00.02> <Sub> <> |.List()|Sub}|"' (Set|Get) Return the entire table listed
     ///     <Summary>
 ///    (Set|Get) Return the entire table listed
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:896 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Return the entire table listed") ]
    Let List = 
    Dim Result As New List(Of TimeSheet)
Me.Table = New Table(Me.TableName , Me.FilePath , Me.Password,False)
   For each Row As DataRow In Me.Table.DataTable.Rows
      Dim Element As New TimeSheet(IIf(IsDBNull(Row.Item(0)),0,Row.Item(0)),
IIf(IsDBNull(Row.Item(1)),False,Row.Item(1)),
IIf(IsDBNull(Row.Item(2)),New DateTime(1970,1,1),Row.Item(2)),
IIf(IsDBNull(Row.Item(3)),"",Row.Item(3)),
IIf(IsDBNull(Row.Item(4)),"",Row.Item(4)),
IIf(IsDBNull(Row.Item(5)),0,Row.Item(5)),
IIf(IsDBNull(Row.Item(6)),0,Row.Item(6)),
IIf(IsDBNull(Row.Item(7)),"",Row.Item(7)),
IIf(IsDBNull(Row.Item(8)),False,Row.Item(8)),
IIf(IsDBNull(Row.Item(9)),0,Row.Item(9)),
      IIf(IsDBNull(Row.Item(10)),0,Row.Item(10)))
      Element.Reset(Table.Line)
 Result.Add(Element)
 Next
 Return Result
#endregion (Set|Get) Return the entire table listed

#region |2019/07/17 00h01:259| <05.00.03> <Sub> <> |.SearchByName()|Sub}|"' (Set|Get) Search for each property that match the Search String.
     ///     <Summary>
 ///    (Set|Get) Search for each property that match the Search String.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:896 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Search for each property that match the Search String.") ]
    Let SearchByName = 
    Dim Result As New List(Of TimeSheet)
 Dim C As New TimeSheet
 For Each Element As TimeSheet In C.List
 If Element.Collaborateur.Tolower() = Search.Tolower() Or Element.Mandat.Tolower() = Search.Tolower()  Or Element.Description.Tolower() = Search.Tolower() Then
      Result.Add(Element)
 End If
 Next
 Return Result
#endregion (Set|Get) Search for each property that match the Search String.

#region |2019/07/17 00h01:265| <05.00.04> <Sub> <> |.SearchByID()|Sub}|"' (Set|Get) Search for each property that match the Search Id.
     ///     <Summary>
 ///    (Set|Get) Search for each property that match the Search Id.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:896 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Search for each property that match the Search Id.") ]
    Let SearchByID = 
    Dim Result As New List(Of TimeSheet)
 Dim C As New TimeSheet
 For Each Element As TimeSheet In C.List
 If Val(Element.ID) = Search Or Val(Element.Quantity) = Search  Or Val(Element.UnitPrice) = Search  Or Val(Element.TotalHTVA) = Search  Or Val(Element.Total) = Search Then
      Result.Add(Element)
 End If
 Next
 Return Result
#endregion (Set|Get) Search for each property that match the Search Id.

#region |2019/07/17 00h01:271| <05.00.05> <Sub> <> |.ToString()|Sub}|"' (Set|Get) The function ToString.
     ///     <Summary>
 ///    (Set|Get) The function ToString.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:896 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The function ToString.") ]
    Let ToString = 
        Return Me.ID
#endregion (Set|Get) The function ToString.

#region |2019/07/17 00h01:278| <05.00.06> <Sub> <> |.CheckConnection()|Sub}|"' (Set|Get) Evaluate the connection to the DataBase
     ///     <Summary>
 ///    (Set|Get) Evaluate the connection to the DataBase
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:896 </Published>
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

#region |2019/07/17 00h08:138| <05.00.08> <Sub> <> |.GetunitPrice()|Sub}|"' (Set|Get) The GetunitPrice as Tarif.
     ///     <Summary>
 ///    (Set|Get) The GetunitPrice as Tarif.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:896 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The GetunitPrice as Tarif.") ]
    Let GetunitPrice = 
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
#endregion (Set|Get) The GetunitPrice as Tarif.

#end region 
#region <6> [Runtime]{12}
#region |2019/07/17 00h01:284| <15.00.00> <Runtime> <> |.Table()|Runtime|  (Set|Get) The Table.
 ///     <Summary>
 ///    (Set|Get) The Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:896 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Table.") ]
   Public Table Table;
#endregion (Set|Get) The Table.

#region |2019/07/17 00h01:293| <15.00.01> <Runtime> <> |.Line()|Runtime|  (Set|Get) The Connection String To the Table.
 ///     <Summary>
 ///    (Set|Get) The Connection String To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:897 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Connection String To the Table.") ]
   Public String Line;
#endregion (Set|Get) The Connection String To the Table.

#region |2019/07/17 00h01:300| <15.00.02> <Runtime> <> |.FilePath()|Runtime|  (Set|Get) The FilePath To the Table.
 ///     <Summary>
 ///    (Set|Get) The FilePath To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:898 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The FilePath To the Table.") ]
   Public String FilePath;
#endregion (Set|Get) The FilePath To the Table.

#region |2019/07/17 00h01:306| <15.00.03> <Runtime> <> |.Password()|Runtime|  (Set|Get) The Password To the Table.
 ///     <Summary>
 ///    (Set|Get) The Password To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:898 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Password To the Table.") ]
   Public String Password;
#endregion (Set|Get) The Password To the Table.

#region |2019/07/17 00h01:312| <15.00.04> <Runtime> <> |.UseSQL()|Runtime|  (Set|Get) Determines if the Database Connection is of type SQL.
 ///     <Summary>
 ///    (Set|Get) Determines if the Database Connection is of type SQL.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:898 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) Determines if the Database Connection is of type SQL.") ]
   Public Boolean UseSQL;
#endregion (Set|Get) Determines if the Database Connection is of type SQL.

#region |2019/07/17 00h01:319| <15.00.05> <Runtime> <> |.TableName()|Runtime|  (Set|Get) The name of the Table.
 ///     <Summary>
 ///    (Set|Get) The name of the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:898 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The name of the Table.") ]
   Public String TableName;
#endregion (Set|Get) The name of the Table.

#region |2019/07/17 00h01:325| <15.00.06> <Runtime> <> |.Con()|Runtime|  (Set|Get) The Con To the Table.
 ///     <Summary>
 ///    (Set|Get) The Con To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:898 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Con To the Table.") ]
   Public OleDb.OleDbConnection Con;
#endregion (Set|Get) The Con To the Table.

#region |2019/07/17 00h01:330| <15.00.07> <Runtime> <> |.Cmd()|Runtime|  (Set|Get) The Cmd To the Table.
 ///     <Summary>
 ///    (Set|Get) The Cmd To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:899 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Cmd To the Table.") ]
   Public OleDb.OleDbCommand Cmd;
#endregion (Set|Get) The Cmd To the Table.

#region |2019/07/17 00h01:346| <15.00.08> <Runtime> <> |.DataReader()|Runtime|  (Set|Get) The DataReader To the Table.
 ///     <Summary>
 ///    (Set|Get) The DataReader To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:899 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The DataReader To the Table.") ]
   Public OleDb.OleDbDataReader DataReader;
#endregion (Set|Get) The DataReader To the Table.

#region |2019/07/17 00h01:354| <15.00.09> <Runtime> <> |.DataAdapter()|Runtime|  (Set|Get) The DataAdapter To the Table.
 ///     <Summary>
 ///    (Set|Get) The DataAdapter To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:899 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The DataAdapter To the Table.") ]
   Public OleDb.OleDbDataAdapter DataAdapter;
#endregion (Set|Get) The DataAdapter To the Table.

#region |2019/07/17 00h01:359| <15.00.10> <Runtime> <> |.Connector()|Runtime|  (Set|Get) The Connector To the Table.
 ///     <Summary>
 ///    (Set|Get) The Connector To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:899 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Connector To the Table.") ]
   Public LineInfo Connector;
#endregion (Set|Get) The Connector To the Table.

#region |2019/07/17 00h01:364| <15.00.11> <Runtime> <> |.Log()|Runtime|  (Set|Get) The Log To the Table.
 ///     <Summary>
 ///    (Set|Get) The Log To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:899 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Log To the Table.") ]
   Public String Log;
#endregion (Set|Get) The Log To the Table.

#end region 
#region <7> [Loader]{2}
#region |2019/07/17 00h01:370| <06.00.00> <Sub> <> |.Empty()|Sub}|"' (Set|Get) The sub Empty.
     ///     <Summary>
 ///    (Set|Get) The sub Empty.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:900 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The sub Empty.") ]
    Let Empty = 
    Reset
#endregion (Set|Get) The sub Empty.

#region |2019/07/17 00h01:371| <06.00.01> <Sub> <> |.Filled()|Sub}|"' (Set|Get) The sub Filled.
     ///     <Summary>
 ///    (Set|Get) The sub Filled.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:900 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The sub Filled.") ]
    Let Filled = 
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

#endregion (Set|Get) The sub Filled.

#end region 
}

 ///     <Summary>
 ///    '''    Object Name :             Public  Class Initializor_Chronos
'''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
'''    Contributor Information : ||
'''    Creation Date :           2019/07/17 00h01:533
'''    |Schema|
'''    |ID| |ObjectType |{Quantity}||UnitPrice||Total
'''    |00| |Importation|{0}||1| |0
'''    |01| |Properties |{24}||0.8| |19.2
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
'''    |Production Cost             |26.2
'''    |Selling Price without VAT   |65.5
'''    |Total TVA                   |5.04
'''    |Grand Total                 |70.54
'''    |/Schema|
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:908 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
public  class Initializor_Chronos{
#region <1> [Property]{24}
#region |2019/07/17 00h01:535| <01.00.00> <Property> <Virtualized Properties> |.Clients()|Clients|  (Set|Get) 
 ///     <Summary>
 ///    (Set|Get) 
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:909 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Virtualized Properties") , Description("(Set|Get) ") ]
    member this.Clients()
       with get() = _Clients
       and set(value) = _Clients <- value
#endregion (Set|Get) 

#region |2019/07/17 00h01:549| <01.00.01> <Property> <List> |.List_Clients()|List(Of Clients)|  (Set|Get) 
 ///     <Summary>
 ///    (Set|Get) 
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:909 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("List") , Description("(Set|Get) ") ]
    member this.List_Clients()
       with get() = _List_Clients
       and set(value) = _List_Clients <- value
#endregion (Set|Get) 

#region |2019/07/17 00h01:557| <01.00.02> <Property> <Virtualized Properties> |.Collaborateur()|Collaborateur|  (Set|Get) 
 ///     <Summary>
 ///    (Set|Get) 
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:910 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Virtualized Properties") , Description("(Set|Get) ") ]
    member this.Collaborateur()
       with get() = _Collaborateur
       and set(value) = _Collaborateur <- value
#endregion (Set|Get) 

#region |2019/07/17 00h01:566| <01.00.03> <Property> <List> |.List_Collaborateur()|List(Of Collaborateur)|  (Set|Get) 
 ///     <Summary>
 ///    (Set|Get) 
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:910 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("List") , Description("(Set|Get) ") ]
    member this.List_Collaborateur()
       with get() = _List_Collaborateur
       and set(value) = _List_Collaborateur <- value
#endregion (Set|Get) 

#region |2019/07/17 00h01:576| <01.00.04> <Property> <Virtualized Properties> |.Factures()|Factures|  (Set|Get) 
 ///     <Summary>
 ///    (Set|Get) 
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:910 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Virtualized Properties") , Description("(Set|Get) ") ]
    member this.Factures()
       with get() = _Factures
       and set(value) = _Factures <- value
#endregion (Set|Get) 

#region |2019/07/17 00h01:600| <01.00.05> <Property> <List> |.List_Factures()|List(Of Factures)|  (Set|Get) 
 ///     <Summary>
 ///    (Set|Get) 
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:910 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("List") , Description("(Set|Get) ") ]
    member this.List_Factures()
       with get() = _List_Factures
       and set(value) = _List_Factures <- value
#endregion (Set|Get) 

#region |2019/07/17 00h01:610| <01.00.06> <Property> <Virtualized Properties> |.Factures_Entries()|Factures_Entries|  (Set|Get) 
 ///     <Summary>
 ///    (Set|Get) 
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:910 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Virtualized Properties") , Description("(Set|Get) ") ]
    member this.Factures_Entries()
       with get() = _Factures_Entries
       and set(value) = _Factures_Entries <- value
#endregion (Set|Get) 

#region |2019/07/17 00h01:618| <01.00.07> <Property> <List> |.List_Factures_Entries()|List(Of Factures_Entries)|  (Set|Get) 
 ///     <Summary>
 ///    (Set|Get) 
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:912 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("List") , Description("(Set|Get) ") ]
    member this.List_Factures_Entries()
       with get() = _List_Factures_Entries
       and set(value) = _List_Factures_Entries <- value
#endregion (Set|Get) 

#region |2019/07/17 00h01:627| <01.00.08> <Property> <Virtualized Properties> |.Paste Errors()|Paste Errors|  (Set|Get) 
 ///     <Summary>
 ///    (Set|Get) 
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:912 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Virtualized Properties") , Description("(Set|Get) ") ]
    member this.Paste Errors()
       with get() = _Paste Errors
       and set(value) = _Paste Errors <- value
#endregion (Set|Get) 

#region |2019/07/17 00h01:634| <01.00.09> <Property> <List> |.List_Paste Errors()|List(Of Paste Errors)|  (Set|Get) 
 ///     <Summary>
 ///    (Set|Get) 
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:912 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("List") , Description("(Set|Get) ") ]
    member this.List_Paste Errors()
       with get() = _List_Paste Errors
       and set(value) = _List_Paste Errors <- value
#endregion (Set|Get) 

#region |2019/07/17 00h01:641| <01.00.10> <Property> <Virtualized Properties> |.Prestation_Category()|Prestation_Category|  (Set|Get) 
 ///     <Summary>
 ///    (Set|Get) 
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:912 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Virtualized Properties") , Description("(Set|Get) ") ]
    member this.Prestation_Category()
       with get() = _Prestation_Category
       and set(value) = _Prestation_Category <- value
#endregion (Set|Get) 

#region |2019/07/17 00h01:649| <01.00.11> <Property> <List> |.List_Prestation_Category()|List(Of Prestation_Category)|  (Set|Get) 
 ///     <Summary>
 ///    (Set|Get) 
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:912 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("List") , Description("(Set|Get) ") ]
    member this.List_Prestation_Category()
       with get() = _List_Prestation_Category
       and set(value) = _List_Prestation_Category <- value
#endregion (Set|Get) 

#region |2019/07/17 00h01:656| <01.00.12> <Property> <Virtualized Properties> |.Prestations()|Prestations|  (Set|Get) 
 ///     <Summary>
 ///    (Set|Get) 
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:913 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Virtualized Properties") , Description("(Set|Get) ") ]
    member this.Prestations()
       with get() = _Prestations
       and set(value) = _Prestations <- value
#endregion (Set|Get) 

#region |2019/07/17 00h01:664| <01.00.13> <Property> <List> |.List_Prestations()|List(Of Prestations)|  (Set|Get) 
 ///     <Summary>
 ///    (Set|Get) 
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:913 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("List") , Description("(Set|Get) ") ]
    member this.List_Prestations()
       with get() = _List_Prestations
       and set(value) = _List_Prestations <- value
#endregion (Set|Get) 

#region |2019/07/17 00h01:671| <01.00.14> <Property> <Virtualized Properties> |.Services()|Services|  (Set|Get) 
 ///     <Summary>
 ///    (Set|Get) 
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:913 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Virtualized Properties") , Description("(Set|Get) ") ]
    member this.Services()
       with get() = _Services
       and set(value) = _Services <- value
#endregion (Set|Get) 

#region |2019/07/17 00h01:678| <01.00.15> <Property> <List> |.List_Services()|List(Of Services)|  (Set|Get) 
 ///     <Summary>
 ///    (Set|Get) 
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:913 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("List") , Description("(Set|Get) ") ]
    member this.List_Services()
       with get() = _List_Services
       and set(value) = _List_Services <- value
#endregion (Set|Get) 

#region |2019/07/17 00h01:685| <01.00.16> <Property> <Virtualized Properties> |.Sociétés()|Sociétés|  (Set|Get) 
 ///     <Summary>
 ///    (Set|Get) 
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:914 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Virtualized Properties") , Description("(Set|Get) ") ]
    member this.Sociétés()
       with get() = _Sociétés
       and set(value) = _Sociétés <- value
#endregion (Set|Get) 

#region |2019/07/17 00h01:693| <01.00.17> <Property> <List> |.List_Sociétés()|List(Of Sociétés)|  (Set|Get) 
 ///     <Summary>
 ///    (Set|Get) 
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:915 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("List") , Description("(Set|Get) ") ]
    member this.List_Sociétés()
       with get() = _List_Sociétés
       and set(value) = _List_Sociétés <- value
#endregion (Set|Get) 

#region |2019/07/17 00h01:701| <01.00.18> <Property> <Virtualized Properties> |.Tarif()|Tarif|  (Set|Get) 
 ///     <Summary>
 ///    (Set|Get) 
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:915 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Virtualized Properties") , Description("(Set|Get) ") ]
    member this.Tarif()
       with get() = _Tarif
       and set(value) = _Tarif <- value
#endregion (Set|Get) 

#region |2019/07/17 00h01:709| <01.00.19> <Property> <List> |.List_Tarif()|List(Of Tarif)|  (Set|Get) 
 ///     <Summary>
 ///    (Set|Get) 
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:915 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("List") , Description("(Set|Get) ") ]
    member this.List_Tarif()
       with get() = _List_Tarif
       and set(value) = _List_Tarif <- value
#endregion (Set|Get) 

#region |2019/07/17 00h01:717| <01.00.20> <Property> <Virtualized Properties> |.TimeSheet()|TimeSheet|  (Set|Get) 
 ///     <Summary>
 ///    (Set|Get) 
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:915 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Virtualized Properties") , Description("(Set|Get) ") ]
    member this.TimeSheet()
       with get() = _TimeSheet
       and set(value) = _TimeSheet <- value
#endregion (Set|Get) 

#region |2019/07/17 00h01:725| <01.00.21> <Property> <List> |.List_TimeSheet()|List(Of TimeSheet)|  (Set|Get) 
 ///     <Summary>
 ///    (Set|Get) 
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:915 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("List") , Description("(Set|Get) ") ]
    member this.List_TimeSheet()
       with get() = _List_TimeSheet
       and set(value) = _List_TimeSheet <- value
#endregion (Set|Get) 

#region |2019/07/17 00h01:734| <01.00.22> <Property> <Portfolio> |.Portfolio()|List(Of Object)|  (Set|Get) 
 ///     <Summary>
 ///    (Set|Get) 
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:916 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("Portfolio") , Description("(Set|Get) ") ]
    member this.Portfolio()
       with get() = _Portfolio
       and set(value) = _Portfolio <- value
#endregion (Set|Get) 

#region |2019/07/17 00h01:745| <01.00.23> <Property> <DataBase> |.DataBase()|SmartCoder.M_FileManager.DataBase|  (Set|Get) 
 ///     <Summary>
 ///    (Set|Get) 
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:916 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , CategoryAttribute("DataBase") , Description("(Set|Get) ") ]
    member this.DataBase()
       with get() = _DataBase
       and set(value) = _DataBase <- value
#endregion (Set|Get) 

#end region 
#region <4> [Sub]{1}
#region |2019/07/17 00h01:752| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class properties element.
     ///     <Summary>
 ///    (Set|Get) This will reinitialize the class properties element.
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:916 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) This will reinitialize the class properties element.") ]
    Let Clear = 
      With Me
         .Clients = New Clients
        .List_Clients = New List(Of Clients)
         .Collaborateur = New Collaborateur
        .List_Collaborateur = New List(Of Collaborateur)
         .Factures = New Factures
        .List_Factures = New List(Of Factures)
         .Factures_Entries = New Factures_Entries
        .List_Factures_Entries = New List(Of Factures_Entries)
         .Paste Errors = New Paste Errors
        .List_Paste Errors = New List(Of Paste Errors)
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
#endregion (Set|Get) This will reinitialize the class properties element.

#end region 
#region <5> [Function]{1}
#region |2019/07/17 00h01:757| <05.00.00> <Sub> <> |.CheckConnection()|Sub}|"' (Set|Get) Evaluate the connection to the DataBase
     ///     <Summary>
 ///    (Set|Get) Evaluate the connection to the DataBase
 ///     <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
 ///     <AuthorName>Saadry Dunkel</AuthorName>
 ///     <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:916 </Published>
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
#region |2019/07/17 00h01:785| <15.00.00> <Runtime> <> |.Line()|Runtime|  (Set|Get) The Connection String To the Table.
 ///     <Summary>
 ///    (Set|Get) The Connection String To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:916 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Connection String To the Table.") ]
   Public String Line;
#endregion (Set|Get) The Connection String To the Table.

#region |2019/07/17 00h01:793| <15.00.01> <Runtime> <> |.FilePath()|Runtime|  (Set|Get) The FilePath To the Table.
 ///     <Summary>
 ///    (Set|Get) The FilePath To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:916 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The FilePath To the Table.") ]
   Public String FilePath;
#endregion (Set|Get) The FilePath To the Table.

#region |2019/07/17 00h01:800| <15.00.02> <Runtime> <> |.Password()|Runtime|  (Set|Get) The Password To the Table.
 ///     <Summary>
 ///    (Set|Get) The Password To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:916 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Password To the Table.") ]
   Public String Password;
#endregion (Set|Get) The Password To the Table.

#region |2019/07/17 00h01:807| <15.00.03> <Runtime> <> |.Connector()|Runtime|  (Set|Get) The Connector To the Table.
 ///     <Summary>
 ///    (Set|Get) The Connector To the Table.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:917 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The Connector To the Table.") ]
   Public LineInfo Connector;
#endregion (Set|Get) The Connector To the Table.

#end region 
#region <7> [Loader]{2}
#region |2019/07/17 00h01:814| <06.00.00> <Sub> <> |.Empty()|Sub}|"' (Set|Get) The sub Empty.
     ///     <Summary>
 ///    (Set|Get) The sub Empty.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:917 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The sub Empty.") ]
    Let Empty = 
    Clear
#endregion (Set|Get) The sub Empty.

#region |2019/07/17 00h01:816| <06.00.01> <Sub> <> |.Filled()|Sub}|"' (Set|Get) The sub Filled.
     ///     <Summary>
 ///    (Set|Get) The sub Filled.
 ///     <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
 ///     <AuthorName>David Shaw Informatique Sàrl</AuthorName>
 ///     <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
 ///     <Published>MASTER From MASTER\Saadry | Time : 2019/07/17 00h11:917 </Published>
 ///     <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
 ///     </Summary>
    [Browsable(True) , Description("(Set|Get) The sub Filled.") ]
    Let Filled = 
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
     .Paste Errors = New Paste Errors
     .List_Paste Errors = New List(Of Paste Errors)
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
     Portfolio= New List(Of Object)
     FilePath = FilePath
     Password= Password
     Line= Line
     Dim M As New LineInfo(FilePath,Password)
     My.Settings.Db_Chronos_FilePath = FilePath
     My.Settings.Db_Chronos_Password = Password
     My.Settings.Db_Chronos_Line = Line 
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
      With Paste Errors
          .Reset(M)
      End With
      List_Paste Errors = New List(Of Paste Errors)
      List_Paste Errors = Paste Errors.List()
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

#endregion (Set|Get) The sub Filled.

#end region 
}

#end region 
}
