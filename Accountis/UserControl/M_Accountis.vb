Imports System.ComponentModel
Imports System.IO
Imports SmartCoder

Public Module M_Accountis

#Region "[On] |2019/07/08 11h39:310| <08.00.00> <Class> <> |.Comptabilité|Class|{34} |Production Cost : 1202.6|Selling Price : 3006.5|"' 
    '''    <Summary>
    '''     '''    Object Name :             Public  Class Comptabilité
    '''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
    '''    Contributor Information : ||
    '''    Creation Date :           2019/07/08 11h39:310
    '''    |Schema|
    '''    |ID| |ObjectType |{Quantity}||UnitPrice||Total
    '''    |00| |Importation|{0}||1| |0
    '''    |01| |Properties |{360}||0.8| |288
    '''    |02| |Enumeration|{20}||0.4| |8
    '''    |03| |Structure  |{0}||0.4| |0
    '''    |04| |Sub        |{103}||1.2| |123.6
    '''    |05| |Function   |{154}||1.6| |246.4
    '''    |06| |Runtime    |{249}||0.4| |99.6
    '''    |07| |Loader     |{45}||0.8| |36
    '''    |08| |Class      |{22}||2| |44
    '''    |09| |Constante  |{0}||0.4| |0
    '''    |10| |Event      |{0}||1.2| |0
    '''    |11| |Members    |{296}||0.5| |148
    '''    |12| |Parameter  |{418}||0.5| |209
    '''    |Production Cost             |1202.6
    '''    |Selling Price without VAT   |3006.5
    '''    |Total TVA                   |231.5
    '''    |Grand Total                 |3238
    '''    |/Schema|
    '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
    '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
    '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
    '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h10:294 </Published>
    '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
    '''    </Summary>
    Public Class Comptabilité
#Region "<1> [Property]{20}"
#Region "[On] |2019/07/08 11h41:147| <01.00.00> <Property> <Index> |.RegroupmentAccount()|Tbl_CodeRegroupement|"' (Set|Get) The RegroupmentAccount as Tbl_CodeRegroupement.
        Private _RegroupmentAccount As Tbl_CodeRegroupement
        '''    <Summary>
        '''     (Set|Get) The RegroupmentAccount as Tbl_CodeRegroupement.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h10:294 </Published>
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
        <Browsable(True), CategoryAttribute("Index"), Description("(Set|Get) The RegroupmentAccount as Tbl_CodeRegroupement.")>
        Property RegroupmentAccount() As Tbl_CodeRegroupement
            Get
                Return _RegroupmentAccount
            End Get
            Set(ByVal Value As Tbl_CodeRegroupement)
                _RegroupmentAccount = Value
            End Set
        End Property
#End Region '(Set|Get) The RegroupmentAccount as Tbl_CodeRegroupement.

#Region "[On] |2019/07/08 11h41:515| <01.00.01> <Property> <Index> |.Currency()|Tbl_CurrencyRatio|"' (Set|Get) The Currency as Tbl_CurrencyRatio.
        Private _Currency As Tbl_CurrencyRatio
        '''    <Summary>
        '''     (Set|Get) The Currency as Tbl_CurrencyRatio.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h10:296 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Index"), Description("(Set|Get) The Currency as Tbl_CurrencyRatio.")>
        Public Property Currency() As Tbl_CurrencyRatio
            Get
                Return _Currency
            End Get
            Set(ByVal Value As Tbl_CurrencyRatio)
                _Currency = Value
            End Set
        End Property
#End Region '(Set|Get) The Currency as Tbl_CurrencyRatio.

#Region "[On] |2019/07/08 11h42:068| <01.00.02> <Property> <Index> |.Entry()|Tbl_Entries|"' (Set|Get) The Entry as Tbl_Entries.
        Private _Entry As Tbl_Entries
        '''    <Summary>
        '''     (Set|Get) The Entry as Tbl_Entries.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h10:296 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Index"), Description("(Set|Get) The Entry as Tbl_Entries.")>
        Property Entry() As Tbl_Entries
            Get
                Return _Entry
            End Get
            Set(ByVal Value As Tbl_Entries)
                _Entry = Value
            End Set
        End Property
#End Region '(Set|Get) The Entry as Tbl_Entries.

#Region "[On] |2019/07/08 11h42:527| <01.00.03> <Property> <Index> |.Entry_Line()|Tbl_Entries_Line|"' (Set|Get) The Entry_Line as Tbl_Entries_Line.
        Private _Entry_Line As Tbl_Entries_Line
        '''    <Summary>
        '''     (Set|Get) The Entry_Line as Tbl_Entries_Line.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h10:297 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Index"), Description("(Set|Get) The Entry_Line as Tbl_Entries_Line.")>
        Public Property Entry_Line() As Tbl_Entries_Line
            Get
                Return _Entry_Line
            End Get
            Set(ByVal Value As Tbl_Entries_Line)
                _Entry_Line = Value
            End Set
        End Property
#End Region '(Set|Get) The Entry_Line as Tbl_Entries_Line.

#Region "[On] |2019/07/08 11h42:443| <01.00.04> <Property> <Index> |.Group()|Tbl_Group|"' (Set|Get) The Group as Tbl_Group.
        Private _Group As Tbl_Group
        '''    <Summary>
        '''     (Set|Get) The Group as Tbl_Group.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h10:297 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Index"), Description("(Set|Get) The Group as Tbl_Group.")>
        Public Property Group() As Tbl_Group
            Get
                Return _Group
            End Get
            Set(ByVal Value As Tbl_Group)
                _Group = Value
            End Set
        End Property
#End Region '(Set|Get) The Group as Tbl_Group.

#Region "[On] |2019/07/08 11h42:235| <01.00.05> <Property> <Index> |.GroupTotal()|Tbl_GroupTotaux|"' (Set|Get) The GroupTotal as Tbl_GroupTotaux.
        Private _GroupTotal As Tbl_GroupTotaux
        '''    <Summary>
        '''     (Set|Get) The GroupTotal as Tbl_GroupTotaux.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h10:297 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Index"), Description("(Set|Get) The GroupTotal as Tbl_GroupTotaux.")>
        Public Property GroupTotal() As Tbl_GroupTotaux
            Get
                Return _GroupTotal
            End Get
            Set(ByVal Value As Tbl_GroupTotaux)
                _GroupTotal = Value
            End Set
        End Property
#End Region '(Set|Get) The GroupTotal as Tbl_GroupTotaux.

#Region "[On] |2019/07/08 11h43:791| <01.00.06> <Property> <Index> |.Periode()|Tbl_Periode|"' (Set|Get) The Periode as Tbl_Periode.
        Private _Periode As Tbl_Periode
        '''    <Summary>
        '''     (Set|Get) The Periode as Tbl_Periode.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h10:298 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Index"), Description("(Set|Get) The Periode as Tbl_Periode.")>
        Public Property Periode() As Tbl_Periode
            Get
                Return _Periode
            End Get
            Set(ByVal Value As Tbl_Periode)
                _Periode = Value
            End Set
        End Property
#End Region '(Set|Get) The Periode as Tbl_Periode.

#Region "[On] |2019/07/08 11h43:931| <01.00.07> <Property> <Index> |.PieceType()|Tbl_PieceType|"' (Set|Get) The PieceType as Tbl_PieceType.
        Private _PieceType As Tbl_PieceType
        '''    <Summary>
        '''     (Set|Get) The PieceType as Tbl_PieceType.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h10:299 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Index"), Description("(Set|Get) The PieceType as Tbl_PieceType.")>
        Public Property PieceType() As Tbl_PieceType
            Get
                Return _PieceType
            End Get
            Set(ByVal Value As Tbl_PieceType)
                _PieceType = Value
            End Set
        End Property
#End Region '(Set|Get) The PieceType as Tbl_PieceType.

#Region "[On] |2019/07/08 11h43:027| <01.00.08> <Property> <Index> |.PlanComptable()|Tbl_Plan_Comptable|"' (Set|Get) The PlanComptable as Tbl_Plan_Comptable.
        Private _PlanComptable As Tbl_Plan_Comptable
        '''    <Summary>
        '''     (Set|Get) The PlanComptable as Tbl_Plan_Comptable.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h10:299 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Index"), Description("(Set|Get) The PlanComptable as Tbl_Plan_Comptable.")>
        Public Property PlanComptable() As Tbl_Plan_Comptable
            Get
                Return _PlanComptable
            End Get
            Set(ByVal Value As Tbl_Plan_Comptable)
                _PlanComptable = Value
            End Set
        End Property
#End Region '(Set|Get) The PlanComptable as Tbl_Plan_Comptable.

#Region "[On] |2019/07/08 11h44:287| <01.00.09> <Property> <Index> |.TotalAccount()|Tbl_Totaux|"' (Set|Get) The TotalAccount as Tbl_Totaux.
        Private _TotalAccount As Tbl_Totaux
        '''    <Summary>
        '''     (Set|Get) The TotalAccount as Tbl_Totaux.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h10:300 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Index"), Description("(Set|Get) The TotalAccount as Tbl_Totaux.")>
        Public Property TotalAccount() As Tbl_Totaux
            Get
                Return _TotalAccount
            End Get
            Set(ByVal Value As Tbl_Totaux)
                _TotalAccount = Value
            End Set
        End Property
#End Region '(Set|Get) The TotalAccount as Tbl_Totaux.

#Region "[On] |2019/07/08 11h44:331| <01.00.10> <Property> <Index> |.List_Regroupement()|List(Of Tbl_CodeRegroupement)|"' (Set|Get) The List_Regroupement as List(Of Tbl_CodeRegroupement).
        Private _List_Regroupement As List(Of Tbl_CodeRegroupement)
        '''    <Summary>
        '''     (Set|Get) The List_Regroupement as List(Of Tbl_CodeRegroupement).
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h10:300 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Index"), Description("(Set|Get) The List_Regroupement as List(Of Tbl_CodeRegroupement).")>
        Public Property List_Regroupement() As List(Of Tbl_CodeRegroupement)
            Get
                Return _List_Regroupement
            End Get
            Set(ByVal Value As List(Of Tbl_CodeRegroupement))
                _List_Regroupement = Value
            End Set
        End Property
#End Region '(Set|Get) The List_Regroupement as List(Of Tbl_CodeRegroupement).

#Region "[On] |2019/07/08 11h45:536| <01.00.11> <Property> <Index> |.List_Currency()|List(Of Tbl_CurrencyRatio)|"' (Set|Get) The List_Currency as List(Of Tbl_CurrencyRatio).
        Private _List_Currency As List(Of Tbl_CurrencyRatio)
        '''    <Summary>
        '''     (Set|Get) The List_Currency as List(Of Tbl_CurrencyRatio).
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h10:300 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Index"), Description("(Set|Get) The List_Currency as List(Of Tbl_CurrencyRatio).")>
        Public Property List_Currency() As List(Of Tbl_CurrencyRatio)
            Get
                Return _List_Currency
            End Get
            Set(ByVal Value As List(Of Tbl_CurrencyRatio))
                _List_Currency = Value
            End Set
        End Property
#End Region '(Set|Get) The List_Currency as List(Of Tbl_CurrencyRatio).

#Region "[On] |2019/07/08 11h45:052| <01.00.12> <Property> <Index> |.List_Entries()|List(Of Tbl_Entries)|"' (Set|Get) The List_Entries as List(Of Tbl_Entries).
        Private _List_Entries As List(Of Tbl_Entries)
        '''    <Summary>
        '''     (Set|Get) The List_Entries as List(Of Tbl_Entries).
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h10:301 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Index"), Description("(Set|Get) The List_Entries as List(Of Tbl_Entries).")>
        Property List_Entries() As List(Of Tbl_Entries)
            Get
                Return _List_Entries
            End Get
            Set(ByVal Value As List(Of Tbl_Entries))
                _List_Entries = Value
            End Set
        End Property
#End Region '(Set|Get) The List_Entries as List(Of Tbl_Entries).

#Region "[On] |2019/07/08 11h46:111| <01.00.13> <Property> <Index> |.List_Group()|List(Of Tbl_Group)|"' (Set|Get) The List_Group as List(Of Tbl_Group).
        Private _List_Group As List(Of Tbl_Group)
        '''    <Summary>
        '''     (Set|Get) The List_Group as List(Of Tbl_Group).
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h10:301 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Index"), Description("(Set|Get) The List_Group as List(Of Tbl_Group).")>
        Public Property List_Group() As List(Of Tbl_Group)
            Get
                Return _List_Group
            End Get
            Set(ByVal Value As List(Of Tbl_Group))
                _List_Group = Value
            End Set
        End Property
#End Region '(Set|Get) The List_Group as List(Of Tbl_Group).

#Region "[On] |2019/07/08 11h46:634| <01.00.14> <Property> <Index> |.List_GroupTotaux()|List(Of Tbl_GroupTotaux)|"' (Set|Get) The List_GroupTotaux as List(Of Tbl_GroupTotaux).
        Private _List_GroupTotaux As List(Of Tbl_GroupTotaux)
        '''    <Summary>
        '''     (Set|Get) The List_GroupTotaux as List(Of Tbl_GroupTotaux).
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h10:302 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Index"), Description("(Set|Get) The List_GroupTotaux as List(Of Tbl_GroupTotaux).")>
        Public Property List_GroupTotaux() As List(Of Tbl_GroupTotaux)
            Get
                Return _List_GroupTotaux
            End Get
            Set(ByVal Value As List(Of Tbl_GroupTotaux))
                _List_GroupTotaux = Value
            End Set
        End Property
#End Region '(Set|Get) The List_GroupTotaux as List(Of Tbl_GroupTotaux).

#Region "[On] |2019/07/08 11h46:223| <01.00.15> <Property> <Index> |.List_Periode()|List(Of Tbl_Periode)|"' (Set|Get) The List_Periode as List(Of Tbl_Periode).
        Private _List_Periode As List(Of Tbl_Periode)
        '''    <Summary>
        '''     (Set|Get) The List_Periode as List(Of Tbl_Periode).
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h10:302 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Index"), Description("(Set|Get) The List_Periode as List(Of Tbl_Periode).")>
        Public Property List_Periode() As List(Of Tbl_Periode)
            Get
                Return _List_Periode
            End Get
            Set(ByVal Value As List(Of Tbl_Periode))
                _List_Periode = Value
            End Set
        End Property
#End Region '(Set|Get) The List_Periode as List(Of Tbl_Periode).

#Region "[On] |2019/07/08 11h47:375| <01.00.16> <Property> <Index> |.List_PieceType()|List(Of Tbl_PieceType)|"' (Set|Get) The List_PieceType as List(Of PieceType).
        Private _List_PieceType As List(Of Tbl_PieceType)
        '''    <Summary>
        '''     (Set|Get) The List_PieceType as List(Of PieceType).
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h10:303 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Index"), Description("(Set|Get) The List_PieceType as List(Of PieceType).")>
        Public Property List_PieceType() As List(Of Tbl_PieceType)
            Get
                Return _List_PieceType
            End Get
            Set(ByVal Value As List(Of Tbl_PieceType))
                _List_PieceType = Value
            End Set
        End Property
#End Region '(Set|Get) The List_PieceType as List(Of PieceType).

#Region "[On] |2019/07/08 11h47:820| <01.00.17> <Property> <Index> |.List_PlanComptable()|List(Of Tbl_Plan_Comptable)|"' (Set|Get) The List_PlanComptable as List(Of Tbl_Plan_Comptable).
        Private _List_PlanComptable As List(Of Tbl_Plan_Comptable)
        '''    <Summary>
        '''     (Set|Get) The List_PlanComptable as List(Of Tbl_Plan_Comptable).
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h10:303 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Index"), Description("(Set|Get) The List_PlanComptable as List(Of Tbl_Plan_Comptable).")>
        Public Property List_PlanComptable() As List(Of Tbl_Plan_Comptable)
            Get
                Return _List_PlanComptable
            End Get
            Set(ByVal Value As List(Of Tbl_Plan_Comptable))
                _List_PlanComptable = Value
            End Set
        End Property
#End Region '(Set|Get) The List_PlanComptable as List(Of Tbl_Plan_Comptable).

#Region "[On] |2019/07/08 11h47:011| <01.00.18> <Property> <Index> |.List_Totaux()|List(Of Tbl_Totaux)|"' (Set|Get) The List_Totaux as List(Of Tbl_Totaux).
        Private _List_Totaux As List(Of Tbl_Totaux)
        '''    <Summary>
        '''     (Set|Get) The List_Totaux as List(Of Tbl_Totaux).
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h10:306 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Index"), Description("(Set|Get) The List_Totaux as List(Of Tbl_Totaux).")>
        Public Property List_Totaux() As List(Of Tbl_Totaux)
            Get
                Return _List_Totaux
            End Get
            Set(ByVal Value As List(Of Tbl_Totaux))
                _List_Totaux = Value
            End Set
        End Property
#End Region '(Set|Get) The List_Totaux as List(Of Tbl_Totaux).

#Region "[On] |2019/07/08 17h47:335| <01.00.19> <Property> <Index> |.List_Entries_Lines()|List(Of Tbl_Entries_Line)|"' (Set|Get) The List_Entries_Lines as List(Of Tbl_Entries_Line).
        Private _List_Entries_Lines As List(Of Tbl_Entries_Line)
        '''    <Summary>
        '''     (Set|Get) The List_Entries_Lines as List(Of Tbl_Entries_Line).
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h10:307 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Index"), Description("(Set|Get) The List_Entries_Lines as List(Of Tbl_Entries_Line).")>
        Public Property List_Entries_Lines() As List(Of Tbl_Entries_Line)
            Get
                Return _List_Entries_Lines
            End Get
            Set(ByVal Value As List(Of Tbl_Entries_Line))
                _List_Entries_Lines = Value
            End Set
        End Property
#End Region '(Set|Get) The List_Entries_Lines as List(Of Tbl_Entries_Line).

#End Region
#Region "<4> [Sub]{1}"
#Region "[On] |2019/07/08 11h38:843| <04.00.00> <Sub> <> |.Reset()|Sub}|"' (Set|Get) The sub Reset.
        '''    <Summary>
        '''     (Set|Get) The sub Reset.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h10:307 </Published>
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
        <Browsable(True), Description("(Set|Get) The sub Reset.")>
        Public Sub Reset()
            If IsNothing(Me.Password) Then
                Me.Password = ""
            End If
            If IsNothing(Me.FilePath) Then
                Me.FilePath = ""
            End If
            If Me.Password.Length < 1 Then
                My.Settings.Db_Accountis_Password = Me.Password
                My.Settings.Save()
            End If
            If Me.FilePath.Length < 1 Then
                My.Settings.Db_Accountis_FilePath = Me.FilePath
                My.Settings.Save()
            End If

            'Test Consistency
            If IO.File.Exists(My.Settings.Db_Accountis_FilePath) Then
                Dim Line As New SmartCoder.LineInfo(My.Settings.Db_Accountis_FilePath, My.Settings.Db_Accountis_Password)
                My.Settings.Db_Accountis_Line = Line.Line
                My.Settings.Save()

                'Implement Connection Settings
                With Me
                    .RegroupmentAccount = New Tbl_CodeRegroupement
                    .Currency = New Tbl_CurrencyRatio
                    .Entry = New Tbl_Entries
                    .Entry_Line = New Tbl_Entries_Line
                    .Group = New Tbl_Group
                    .GroupTotal = New Tbl_GroupTotaux
                    .Periode = New Tbl_Periode
                    .PieceType = New Tbl_PieceType
                    .PlanComptable = New Tbl_Plan_Comptable
                    .TotalAccount = New Tbl_Totaux
                    'Creating List
                    .List_Regroupement = New List(Of Tbl_CodeRegroupement)
                    .List_Currency = New List(Of Tbl_CurrencyRatio)
                    .List_Entries = New List(Of Tbl_Entries)
                    .List_Entries_Lines = New List(Of Tbl_Entries_Line)
                    .List_Group = New List(Of Tbl_Group)
                    .List_GroupTotaux = New List(Of Tbl_GroupTotaux)
                    .List_Periode = New List(Of Tbl_Periode)
                    .List_PieceType = New List(Of Tbl_PieceType)
                    .List_PlanComptable = New List(Of Tbl_Plan_Comptable)
                    .List_Totaux = New List(Of Tbl_Totaux)
                    'Resetting the elements
                    .RegroupmentAccount.Reset(New LineInfo(My.Settings.Db_Accountis_FilePath, My.Settings.Db_Accountis_Password))
                    .Currency.Reset(New LineInfo(My.Settings.Db_Accountis_FilePath, My.Settings.Db_Accountis_Password))
                    .Entry.Reset(New LineInfo(My.Settings.Db_Accountis_FilePath, My.Settings.Db_Accountis_Password))
                    .Entry_Line.Reset(New LineInfo(My.Settings.Db_Accountis_FilePath, My.Settings.Db_Accountis_Password))
                    .Group.Reset(New LineInfo(My.Settings.Db_Accountis_FilePath, My.Settings.Db_Accountis_Password))
                    .GroupTotal.Reset(New LineInfo(My.Settings.Db_Accountis_FilePath, My.Settings.Db_Accountis_Password))
                    .Periode.Reset(New LineInfo(My.Settings.Db_Accountis_FilePath, My.Settings.Db_Accountis_Password))
                    .PieceType.Reset(New LineInfo(My.Settings.Db_Accountis_FilePath, My.Settings.Db_Accountis_Password))
                    .PlanComptable.Reset(New LineInfo(My.Settings.Db_Accountis_FilePath, My.Settings.Db_Accountis_Password))
                    .TotalAccount.Reset(New LineInfo(My.Settings.Db_Accountis_FilePath, My.Settings.Db_Accountis_Password))

                    'Filling the elements
                    .List_Regroupement = .RegroupmentAccount.List()
                    .List_Currency = .Currency.List()
                    .List_Entries = .Entry.List()
                    .List_Entries_Lines = .Entry_Line.List()
                    .List_Group = .Group.List()
                    .List_GroupTotaux = .GroupTotal.List()
                    .List_Periode = .Periode.List()
                    .List_PieceType = .PieceType.List()
                    .List_PlanComptable = .PlanComptable.List()
                    .List_Totaux = .TotalAccount.List()
                    On Error Resume Next
                    ' For Each Account As Tbl_Plan_Comptable In .List_PlanComptable
                    '    For Each Entry As Tbl_Entries In .List_Entries
                    '   Entry.List_Lines()
                    'Entry.Save()

                    '  Next
                    '     Next
                    '  For Each Code As Tbl_CodeRegroupement In .List_Regroupement
                    '  Code.List_Accounts()
                    '  Code.Save()
                    '  Next
                    '  For Each Total As Tbl_Totaux In .List_Totaux
                    '  For Each Code As Tbl_CodeRegroupement In .List_Regroupement
                    '
                    '                   Next
                    '                  Next

                End With
            End If
        End Sub
#End Region '(Set|Get) The sub Reset.

#End Region
#Region "<6> [Runtime]{2}"
#Region "[On] |2019/07/08 18h04:045| <15.00.01> <Runtime> <> |.Password()|String"' (Set|Get) Variable FilePath as String.
        '''    <Summary>
        '''     (Set|Get) Variable FilePath as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h10:307 </Published>
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
        <Browsable(True), Description("(Set|Get) Variable FilePath as String.")>
        Public Password As String
#End Region '(Set|Get) Variable FilePath as String.
#Region "[On] |2019/07/08 18h04:045| <15.00.00> <Runtime> <> |.FilePath()|String"' (Set|Get) Variable FilePath as String.
        '''    <Summary>
        '''     (Set|Get) Variable FilePath as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h10:307 </Published>
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
        <Browsable(True), Description("(Set|Get) Variable FilePath as String.")>
        Public FilePath As String
#End Region '(Set|Get) Variable FilePath as String.

#End Region
    End Class

#Region "[On] |2019/07/08 18h11:396| <08.00.00> <Class> <> |.Tbl_CodeRegroupement|Class|{42} |Production Cost : 53.5|Selling Price : 133.75|"' Class created automatically by SmartOffice (c)Copyright 2019.
    '''    <Summary>
    '''     Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Tbl_CodeRegroupement
    '''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
    '''    Contributor Information : ||
    '''    Creation Date :           2019/07/08 18h11:396
    '''    |Schema|
    '''    |ID| |ObjectType |{Quantity}||UnitPrice||Total
    '''    |00| |Importation|{0}||1| |0
    '''    |01| |Properties |{16}||0.8| |20
    '''    |02| |Enumeration|{1}||0.4| |0.4
    '''    |03| |Structure  |{0}||0.4| |0
    '''    |04| |Sub        |{5}||1.2| |6
    '''    |05| |Function   |{7}||1.6| |11.2
    '''    |06| |Runtime    |{12}||0.4| |4.8
    '''    |07| |Loader     |{2}||0.8| |1.6
    '''    |08| |Class      |{0}||2| |0
    '''    |09| |Constante  |{0}||0.4| |0
    '''    |10| |Event      |{0}||1.2| |0
    '''    |11| |Members    |{15}||0.5| |7.5
    '''    |12| |Parameter  |{20}||0.5| |10
    '''    |Production Cost             |54.1
    '''    |Selling Price without VAT   |133.75
    '''    |Total TVA                   |10.3
    '''    |Grand Total                 |144.05
    '''    |/Schema|
    '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
    '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
    '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
    '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:924 </Published>
    '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
    '''    </Summary>
    Public Class Tbl_CodeRegroupement
#Region "<1> [Property]{15}"
#Region "[On] |2019/07/08 18h11:397| <01.00.00> <Property> <Columns> |.N()|Integer|"' (Set|Get) The N as Integer.
        Private _N As Integer
        '''    <Summary>
        '''     (Set|Get) The N as Integer.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:924 </Published>
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
#Region "[On] |2019/07/08 18h11:405| <01.00.01> <Property> <Columns> |.RefTotal()|Integer|"' (Set|Get) The RefTotal as Integer.
        Private _RefTotal As Integer
        '''    <Summary>
        '''     (Set|Get) The RefTotal as Integer.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:924 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The RefTotal as Integer.")>
        Public Property RefTotal() As Integer
            Get
                Return _RefTotal
            End Get
            Set(ByVal Value As Integer)
                _RefTotal = Value
            End Set
        End Property
#End Region '(Set|Get) The RefTotal as Integer.
#Region "[On] |2019/07/08 18h11:423| <01.00.02> <Property> <Columns> |.Opening()|Double|"' (Set|Get) The Opening as Double.
        Private _Opening As Double
        '''    <Summary>
        '''     (Set|Get) The Opening as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:924 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Opening as Double.")>
        Public Property Opening() As Double
            Get
                Return _Opening
            End Get
            Set(ByVal Value As Double)
                _Opening = Value
            End Set
        End Property
#End Region '(Set|Get) The Opening as Double.
#Region "[On] |2019/07/08 18h11:436| <01.00.03> <Property> <Columns> |.Debit()|Double|"' (Set|Get) The Debit as Double.
        Private _Debit As Double
        '''    <Summary>
        '''     (Set|Get) The Debit as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:924 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Debit as Double.")>
        Public Property Debit() As Double
            Get
                Return _Debit
            End Get
            Set(ByVal Value As Double)
                _Debit = Value
            End Set
        End Property
#End Region '(Set|Get) The Debit as Double.
#Region "[On] |2019/07/08 18h11:442| <01.00.04> <Property> <Columns> |.Credit()|Double|"' (Set|Get) The Credit as Double.
        Private _Credit As Double
        '''    <Summary>
        '''     (Set|Get) The Credit as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:925 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Credit as Double.")>
        Public Property Credit() As Double
            Get
                Return _Credit
            End Get
            Set(ByVal Value As Double)
                _Credit = Value
            End Set
        End Property
#End Region '(Set|Get) The Credit as Double.
#Region "[On] |2019/07/08 18h11:448| <01.00.05> <Property> <Columns> |.Balance()|Double|"' (Set|Get) The Balance as Double.
        Private _Balance As Double
        '''    <Summary>
        '''     (Set|Get) The Balance as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:925 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Balance as Double.")>
        Public Property Balance() As Double
            Get
                Return _Balance
            End Get
            Set(ByVal Value As Double)
                _Balance = Value
            End Set
        End Property
#End Region '(Set|Get) The Balance as Double.
#Region "[On] |2019/07/08 18h11:454| <01.00.06> <Property> <Columns> |.Closing()|Double|"' (Set|Get) The Closing as Double.
        Private _Closing As Double
        '''    <Summary>
        '''     (Set|Get) The Closing as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:925 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Closing as Double.")>
        Public Property Closing() As Double
            Get
                Return _Closing
            End Get
            Set(ByVal Value As Double)
                _Closing = Value
            End Set
        End Property
#End Region '(Set|Get) The Closing as Double.
#Region "[On] |2019/07/08 18h11:460| <01.00.07> <Property> <Columns> |.Variation()|Double|"' (Set|Get) The Variation as Double.
        Private _Variation As Double
        '''    <Summary>
        '''     (Set|Get) The Variation as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:925 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Variation as Double.")>
        Public Property Variation() As Double
            Get
                Return _Variation
            End Get
            Set(ByVal Value As Double)
                _Variation = Value
            End Set
        End Property
#End Region '(Set|Get) The Variation as Double.
#Region "[On] |2019/07/08 18h11:467| <01.00.08> <Property> <Columns> |.Français()|String|"' (Set|Get) The Français as String.
        Private _Français As String
        '''    <Summary>
        '''     (Set|Get) The Français as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:925 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Français as String.")>
        Public Property Français() As String
            Get
                Return _Français
            End Get
            Set(ByVal Value As String)
                _Français = Value
            End Set
        End Property
#End Region '(Set|Get) The Français as String.
#Region "[On] |2019/07/08 18h11:473| <01.00.09> <Property> <Columns> |.English()|String|"' (Set|Get) The English as String.
        Private _English As String
        '''    <Summary>
        '''     (Set|Get) The English as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:925 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The English as String.")>
        Public Property English() As String
            Get
                Return _English
            End Get
            Set(ByVal Value As String)
                _English = Value
            End Set
        End Property
#End Region '(Set|Get) The English as String.
#Region "[On] |2019/07/08 18h11:479| <01.00.10> <Property> <Columns> |.Italian()|String|"' (Set|Get) The Italian as String.
        Private _Italian As String
        '''    <Summary>
        '''     (Set|Get) The Italian as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:926 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Italian as String.")>
        Public Property Italian() As String
            Get
                Return _Italian
            End Get
            Set(ByVal Value As String)
                _Italian = Value
            End Set
        End Property
#End Region '(Set|Get) The Italian as String.
#Region "[On] |2019/07/08 18h11:490| <01.00.11> <Property> <Columns> |.German()|String|"' (Set|Get) The German as String.
        Private _German As String
        '''    <Summary>
        '''     (Set|Get) The German as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:926 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The German as String.")>
        Public Property German() As String
            Get
                Return _German
            End Get
            Set(ByVal Value As String)
                _German = Value
            End Set
        End Property
#End Region '(Set|Get) The German as String.
#Region "[On] |2019/07/08 18h11:497| <01.00.12> <Property> <Columns> |.Spanish()|String|"' (Set|Get) The Spanish as String.
        Private _Spanish As String
        '''    <Summary>
        '''     (Set|Get) The Spanish as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:926 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Spanish as String.")>
        Public Property Spanish() As String
            Get
                Return _Spanish
            End Get
            Set(ByVal Value As String)
                _Spanish = Value
            End Set
        End Property
#End Region '(Set|Get) The Spanish as String.
#Region "[On] |2019/07/08 18h11:504| <01.00.13> <Property> <Columns> |.Portuguese()|String|"' (Set|Get) The Portuguese as String.
        Private _Portuguese As String
        '''    <Summary>
        '''     (Set|Get) The Portuguese as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:926 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Portuguese as String.")>
        Public Property Portuguese() As String
            Get
                Return _Portuguese
            End Get
            Set(ByVal Value As String)
                _Portuguese = Value
            End Set
        End Property
#End Region '(Set|Get) The Portuguese as String.
#Region "[On] |2019/07/08 18h11:510| <01.00.14> <Property> <Columns> |.Russian()|String|"' (Set|Get) The Russian as String.
        Private _Russian As String
        '''    <Summary>
        '''     (Set|Get) The Russian as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:926 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Russian as String.")>
        Public Property Russian() As String
            Get
                Return _Russian
            End Get
            Set(ByVal Value As String)
                _Russian = Value
            End Set
        End Property
#End Region '(Set|Get) The Russian as String.
#Region "[On] |2019/07/08 19h50:924| <01.00.01> <Property> <List> |.Accounts()|List(Of Tbl_Plan_Comptable)|"' (Set|Get) The Accounts as List(Of Tbl_Plan_Comptable).
        Private _Accounts As List(Of Tbl_Plan_Comptable)
        '''    <Summary>
        '''     (Set|Get) The Accounts as List(Of Tbl_Plan_Comptable).
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 19h50:941 </Published>
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
        <Browsable(True), CategoryAttribute("List"), Description("(Set|Get) The Accounts as List(Of Tbl_Plan_Comptable).")>
        Property Accounts() As List(Of Tbl_Plan_Comptable)
            Get
                Return _Accounts
            End Get
            Set(ByVal Value As List(Of Tbl_Plan_Comptable))
                _Accounts = Value
            End Set
        End Property
#End Region '(Set|Get) The Accounts as List(Of Tbl_Plan_Comptable).
#End Region
#Region "<2> [Enumeration]{1}"
#Region "[On] |2019/07/08 18h11:516| <02.00.00> <Enumeration> <> |.Schema()|Enumeration{14}|"' (Set|Get) The enumeration of Schema.
        '''    <Summary>
        '''     (Set|Get) The enumeration of Schema.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:927 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The enumeration of Schema.")>
        Enum Schema
            ''' <summary>(Set|Get) The N as Integer.</summary>
            [N] = 0
            ''' <summary>(Set|Get) The RefTotal as Integer.</summary>
            [RefTotal] = 1
            ''' <summary>(Set|Get) The Opening as Double.</summary>
            [Opening] = 2
            ''' <summary>(Set|Get) The Debit as Double.</summary>
            [Debit] = 3
            ''' <summary>(Set|Get) The Credit as Double.</summary>
            [Credit] = 4
            ''' <summary>(Set|Get) The Balance as Double.</summary>
            [Balance] = 5
            ''' <summary>(Set|Get) The Closing as Double.</summary>
            [Closing] = 6
            ''' <summary>(Set|Get) The Variation as Double.</summary>
            [Variation] = 7
            ''' <summary>(Set|Get) The Français as String.</summary>
            [Français] = 8
            ''' <summary>(Set|Get) The English as String.</summary>
            [English] = 9
            ''' <summary>(Set|Get) The Italian as String.</summary>
            [Italian] = 10
            ''' <summary>(Set|Get) The German as String.</summary>
            [German] = 11
            ''' <summary>(Set|Get) The Spanish as String.</summary>
            [Spanish] = 12
            ''' <summary>(Set|Get) The Portuguese as String.</summary>
            [Portuguese] = 13
            ''' <summary>(Set|Get) The Russian as String.</summary>
            [Russian] = 14
        End Enum
#End Region '(Set|Get) The enumeration of Schema.

#End Region
#Region "<4> [Sub]{5}"
#Region "[On] |2019/07/08 18h11:524| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
        '''    <Summary>
        '''     (Set|Get) This will reinitialize the class element.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:927 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will reinitialize the class element.")>
        Public Sub Clear()
            With Me
                .N = 0
                .RefTotal = 0
                .Opening = 0
                .Debit = 0
                .Credit = 0
                .Balance = 0
                .Closing = 0
                .Variation = 0
                .Français = Nothing
                .English = Nothing
                .Italian = Nothing
                .German = Nothing
                .Spanish = Nothing
                .Portuguese = Nothing
                .Russian = Nothing
                .Accounts = New List(Of Tbl_Plan_Comptable)
            End With
        End Sub
#End Region '(Set|Get) This will reinitialize the class element.
#Region "[On] |2019/07/08 18h11:531| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
        '''    <Summary>
        '''     (Set|Get) This will reinitialize the variables of this class.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:927 </Published>
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
                    TableName = "Tbl_CodeRegroupement"
                    Line = Connector.Line
                    UseSQL = False
                Else
                    FilePath = My.Settings.Db_Accountis_FilePath
                    Password = My.Settings.Db_Accountis_Password
                    Me.Line = My.Settings.Db_Accountis_Line
                    TableName = "Tbl_CodeRegroupement"
                    UseSQL = False
                End If
            Else
                If IsNothing(FilePath) Then
                    FilePath = My.Settings.Db_Accountis_FilePath
                End If
                If FilePath.Length < 1 Then
                    FilePath = My.Settings.Db_Accountis_FilePath
                End If
                FilePath = My.Settings.Db_Accountis_FilePath
                Password = My.Settings.Db_Accountis_Password
                Me.Line = My.Settings.Db_Accountis_Line
                TableName = "Tbl_CodeRegroupement"
                UseSQL = False
            End If

        End Sub
#End Region '(Set|Get) This will reinitialize the variables of this class.
#Region "[On] |2019/07/08 18h11:538| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
        '''    <Summary>
        '''     (Set|Get) This will add a new row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:927 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will add a new row in the table.")>
        Public Sub Add()
            Try
                Dim Str As String = Nothing
                Str = "Insert Into [Tbl_CodeRegroupement] (
`N`, 
`RefTotal`, 
`Opening`, 
`Debit`, 
`Credit`, 
`Balance`, 
`Closing`, 
`Variation`, 
`Français`, 
`English`, 
`Italian`, 
`German`, 
`Spanish`, 
`Portuguese`, 
`Russian`) Values (@0, @1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14)"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@0", Me.N)
                Cmd.Parameters.AddWithValue("@1", Me.RefTotal)
                Cmd.Parameters.AddWithValue("@2", Me.Opening)
                Cmd.Parameters.AddWithValue("@3", Me.Debit)
                Cmd.Parameters.AddWithValue("@4", Me.Credit)
                Cmd.Parameters.AddWithValue("@5", Me.Balance)
                Cmd.Parameters.AddWithValue("@6", Me.Closing)
                Cmd.Parameters.AddWithValue("@7", Me.Variation)
                Cmd.Parameters.AddWithValue("@8", Me.Français)
                Cmd.Parameters.AddWithValue("@9", Me.English)
                Cmd.Parameters.AddWithValue("@10", Me.Italian)
                Cmd.Parameters.AddWithValue("@11", Me.German)
                Cmd.Parameters.AddWithValue("@12", Me.Spanish)
                Cmd.Parameters.AddWithValue("@13", Me.Portuguese)
                Cmd.Parameters.AddWithValue("@14", Me.Russian)
                If Cmd.ExecuteNonQuery >= 0 Then
                Else
                    Msgbox("Element not Addd")
                End If
            Catch ex As Exception
            Finally
                Close(True)
            End Try

        End Sub
#End Region '(Set|Get) This will add a new row in the table.
#Region "[On] |2019/07/08 18h11:545| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
        '''    <Summary>
        '''     (Set|Get) This will update a row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:927 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will update a row in the table.")>
        Public Sub Save()
            Try
                Dim Str As String = Nothing
                Str = "UPDATE [Tbl_CodeRegroupement] SET RefTotal = @RefTotal, Opening = @Opening, Debit = @Debit, Credit = @Credit, Balance = @Balance, Closing = @Closing, Variation = @Variation, Français = @Français, English = @English, Italian = @Italian, German = @German, Spanish = @Spanish, Portuguese = @Portuguese, Russian = @Russian WHERE N = @N"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@RefTotal", RefTotal)
                Cmd.Parameters.AddWithValue("@Opening", Opening)
                Cmd.Parameters.AddWithValue("@Debit", Debit)
                Cmd.Parameters.AddWithValue("@Credit", Credit)
                Cmd.Parameters.AddWithValue("@Balance", Balance)
                Cmd.Parameters.AddWithValue("@Closing", Closing)
                Cmd.Parameters.AddWithValue("@Variation", Variation)
                Cmd.Parameters.AddWithValue("@Français", Français)
                Cmd.Parameters.AddWithValue("@English", English)
                Cmd.Parameters.AddWithValue("@Italian", Italian)
                Cmd.Parameters.AddWithValue("@German", German)
                Cmd.Parameters.AddWithValue("@Spanish", Spanish)
                Cmd.Parameters.AddWithValue("@Portuguese", Portuguese)
                Cmd.Parameters.AddWithValue("@Russian", Russian)
                Cmd.Parameters.AddWithValue("@N", N)
                If Cmd.ExecuteNonQuery >= 0 Then
                Else
                    Msgbox("Element not Saved")
                End If
            Catch ex As Exception
            Finally
                Close(True)
            End Try

        End Sub
#End Region '(Set|Get) This will update a row in the table.
#Region "[On] |2019/07/08 18h11:552| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
        '''    <Summary>
        '''     (Set|Get) This will Delete a row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:927 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will Delete a row in the table.")>
        Public Sub Delete()
            Try
                Dim Str As String = Nothing
                Str = "Delete From [Tbl_CodeRegroupement] WHERE N =@N"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@N", N)
                If Cmd.ExecuteNonQuery >= 0 Then
                Else
                    Msgbox("Element not Deleted")
                End If
            Catch ex As Exception
            Finally
                Close(True)
            End Try

        End Sub
#End Region '(Set|Get) This will Delete a row in the table.
#Region "[On] |2019/07/08 19h44:836| <04.00.05> <Sub> <> |.List_Accounts()|Sub}|"' (Set|Get) The sub List_Accounts.
        '''    <Summary>
        '''     (Set|Get) The sub List_Accounts.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 19h59:456 </Published>
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
        <Browsable(True), Description("(Set|Get) The sub List_Accounts.")>
        Public Sub List_Accounts()
            Dim M As New Tbl_Plan_Comptable
            M.Reset()
            With Me
                .Opening = 0
                .Debit = 0
                .Credit = 0
                .Balance = 0
                .Closing = 0
                .Accounts = New List(Of Tbl_Plan_Comptable)
            End With
            For Each Account As Tbl_Plan_Comptable In M.List()
                If Account.Group_Negatif = Me.N Then
                    Me.Opening += Account.Opening
                    Me.Credit += Account.Credit
                    Me.Accounts.Add(Account)
                ElseIf Account.Group_Positif = Me.N Then
                    Me.Opening += Account.Opening
                    Me.Debit += Account.Debit
                    Me.Accounts.Add(Account)
                End If
                Me.Balance = Me.Credit + Me.Debit
            Next
            Me.Closing = Me.Opening + Me.Balance

        End Sub
#End Region '(Set|Get) The sub List_Accounts.
#End Region
#Region "<5> [Function]{7}"
#Region "[On] |2019/07/08 18h11:559| <05.00.00> <Function> <> |.Open()|TestItem}|"' (Set|Get) This will initialise the connection and import the data.
        '''    <Summary>
        '''     (Set|Get) This will initialise the connection and import the data.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:927 </Published>
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
                Result.Why += Log & VbNewLine
            End If
            Return Result

        End Function
#End Region '(Set|Get) This will initialise the connection and import the data.

#Region "[On] |2019/07/08 18h11:566| <05.00.01> <Function> <> |.Close()|TestItem}|"' (Set|Get) This willClosing the connection
        '''    <Summary>
        '''     (Set|Get) This willClosing the connection
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:928 </Published>
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

#Region "[On] |2019/07/08 18h11:574| <05.00.02> <Function> <> |.List()|List(Of Tbl_CodeRegroupement)}|"' (Set|Get) Return the entire table listed
        '''    <Summary>
        '''     (Set|Get) Return the entire table listed
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:928 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Return the entire table listed")>
        Public Function List() As List(Of Tbl_CodeRegroupement)
            Dim Result As New List(Of Tbl_CodeRegroupement)
            Me.Table = New Table(Me.TableName, Me.FilePath, Me.Password, False)
            For Each Row As DataRow In Me.Table.DataTable.Rows
                Dim Element As New Tbl_CodeRegroupement(IIf(IsDBNull(Row.Item(0)), 0, Row.Item(0)),
IIf(IsDBNull(Row.Item(1)), 0, Row.Item(1)),
IIf(IsDBNull(Row.Item(2)), 0, Row.Item(2)),
IIf(IsDBNull(Row.Item(3)), 0, Row.Item(3)),
IIf(IsDBNull(Row.Item(4)), 0, Row.Item(4)),
IIf(IsDBNull(Row.Item(5)), 0, Row.Item(5)),
IIf(IsDBNull(Row.Item(6)), 0, Row.Item(6)),
IIf(IsDBNull(Row.Item(7)), 0, Row.Item(7)),
IIf(IsDBNull(Row.Item(8)), "", Row.Item(8)),
IIf(IsDBNull(Row.Item(9)), "", Row.Item(9)),
IIf(IsDBNull(Row.Item(10)), "", Row.Item(10)),
IIf(IsDBNull(Row.Item(11)), "", Row.Item(11)),
IIf(IsDBNull(Row.Item(12)), "", Row.Item(12)),
IIf(IsDBNull(Row.Item(13)), "", Row.Item(13)),
      IIf(IsDBNull(Row.Item(14)), "", Row.Item(14)))
                Element.Reset(Table.Line)
                Result.Add(Element)
            Next
            Return Result
        End Function
#End Region '(Set|Get) Return the entire table listed

#Region "[On] |2019/07/08 18h11:581| <05.00.03> <Function> <> |.SearchByName()|List(Of Tbl_CodeRegroupement)}|"' (Set|Get) Search for each property that match the Search String.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search String.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:928 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Search for each property that match the Search String.")>
        Public Shared Function SearchByName(ByVal Search As String) As List(Of Tbl_CodeRegroupement)
            Dim Result As New List(Of Tbl_CodeRegroupement)
            Dim C As New Tbl_CodeRegroupement
            For Each Element As Tbl_CodeRegroupement In C.List
                If Element.Français.Tolower() = Search.Tolower() Or Element.English.Tolower() = Search.Tolower() Or Element.Italian.Tolower() = Search.Tolower() Or Element.German.Tolower() = Search.Tolower() Or Element.Spanish.Tolower() = Search.Tolower() Or Element.Portuguese.Tolower() = Search.Tolower() Or Element.Russian.Tolower() = Search.Tolower() Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search String.

#Region "[On] |2019/07/08 18h11:594| <05.00.04> <Function> <> |.SearchByID()|List(Of Tbl_CodeRegroupement)}|"' (Set|Get) Search for each property that match the Search Id.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search Id.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:928 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Search for each property that match the Search Id.")>
        Public Shared Function SearchByID(ByVal Search As Double) As List(Of Tbl_CodeRegroupement)
            Dim Result As New List(Of Tbl_CodeRegroupement)
            Dim C As New Tbl_CodeRegroupement
            For Each Element As Tbl_CodeRegroupement In C.List
                If Val(Element.N) = Search Or Val(Element.RefTotal) = Search Or Val(Element.Opening) = Search Or Val(Element.Debit) = Search Or Val(Element.Credit) = Search Or Val(Element.Balance) = Search Or Val(Element.Closing) = Search Or Val(Element.Variation) = Search Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search Id.

#Region "[On] |2019/07/08 18h11:601| <05.00.05> <Function> <> |.ToString()|String}|"' (Set|Get) The function ToString.
        '''    <Summary>
        '''     (Set|Get) The function ToString.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:928 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The function ToString.")>
        Public Overrides Function ToString() As String
            Return Me.N
        End Function
#End Region '(Set|Get) The function ToString.

#Region "[On] |2019/07/08 18h11:609| <05.00.06> <Function> <> |.CheckConnection()|Boolean}|"' (Set|Get) Evaluate the connection to the DataBase
        '''    <Summary>
        '''     (Set|Get) Evaluate the connection to the DataBase
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:928 </Published>
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
                    Me.Connector = New LineInfo(FilePath, Password)
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
            Log += Message & VbNewLine
            Return General_Status

        End Function
#End Region '(Set|Get) Evaluate the connection to the DataBase

#End Region
#Region "<6> [Runtime]{12}"
#Region "[On] |2019/07/08 18h11:617| <15.00.00> <Runtime> <> |.Table()|Table"' (Set|Get) The Table.
        '''    <Summary>
        '''     (Set|Get) The Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:929 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Table.")>
        Public Table As Table
#End Region '(Set|Get) The Table.

#Region "[On] |2019/07/08 18h11:624| <15.00.01> <Runtime> <> |.Line()|String"' (Set|Get) The Connection String To the Table.
        '''    <Summary>
        '''     (Set|Get) The Connection String To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:929 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Connection String To the Table.")>
        Public Line As String
#End Region '(Set|Get) The Connection String To the Table.

#Region "[On] |2019/07/08 18h11:634| <15.00.02> <Runtime> <> |.FilePath()|String"' (Set|Get) The FilePath To the Table.
        '''    <Summary>
        '''     (Set|Get) The FilePath To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:929 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The FilePath To the Table.")>
        Public FilePath As String
#End Region '(Set|Get) The FilePath To the Table.

#Region "[On] |2019/07/08 18h11:641| <15.00.03> <Runtime> <> |.Password()|String"' (Set|Get) The Password To the Table.
        '''    <Summary>
        '''     (Set|Get) The Password To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:929 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Password To the Table.")>
        Public Password As String
#End Region '(Set|Get) The Password To the Table.

#Region "[On] |2019/07/08 18h11:649| <15.00.04> <Runtime> <> |.UseSQL()|Boolean"' (Set|Get) Determines if the Database Connection is of type SQL.
        '''    <Summary>
        '''     (Set|Get) Determines if the Database Connection is of type SQL.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:929 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Determines if the Database Connection is of type SQL.")>
        Public UseSQL As Boolean
#End Region '(Set|Get) Determines if the Database Connection is of type SQL.

#Region "[On] |2019/07/08 18h11:658| <15.00.05> <Runtime> <> |.TableName()|String"' (Set|Get) The name of the Table.
        '''    <Summary>
        '''     (Set|Get) The name of the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:930 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The name of the Table.")>
        Public TableName As String
#End Region '(Set|Get) The name of the Table.

#Region "[On] |2019/07/08 18h11:665| <15.00.06> <Runtime> <> |.Con()|OleDb.OleDbConnection"' (Set|Get) The Con To the Table.
        '''    <Summary>
        '''     (Set|Get) The Con To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:930 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Con To the Table.")>
        Public Con As OleDb.OleDbConnection
#End Region '(Set|Get) The Con To the Table.

#Region "[On] |2019/07/08 18h11:669| <15.00.07> <Runtime> <> |.Cmd()|OleDb.OleDbCommand"' (Set|Get) The Cmd To the Table.
        '''    <Summary>
        '''     (Set|Get) The Cmd To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:930 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Cmd To the Table.")>
        Public Cmd As OleDb.OleDbCommand
#End Region '(Set|Get) The Cmd To the Table.

#Region "[On] |2019/07/08 18h11:677| <15.00.08> <Runtime> <> |.DataReader()|OleDb.OleDbDataReader"' (Set|Get) The DataReader To the Table.
        '''    <Summary>
        '''     (Set|Get) The DataReader To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:930 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The DataReader To the Table.")>
        Public DataReader As OleDb.OleDbDataReader
#End Region '(Set|Get) The DataReader To the Table.

#Region "[On] |2019/07/08 18h11:684| <15.00.09> <Runtime> <> |.DataAdapter()|OleDb.OleDbDataAdapter"' (Set|Get) The DataAdapter To the Table.
        '''    <Summary>
        '''     (Set|Get) The DataAdapter To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:930 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The DataAdapter To the Table.")>
        Public DataAdapter As OleDb.OleDbDataAdapter
#End Region '(Set|Get) The DataAdapter To the Table.

#Region "[On] |2019/07/08 18h11:701| <15.00.10> <Runtime> <> |.Connector()|LineInfo"' (Set|Get) The Connector To the Table.
        '''    <Summary>
        '''     (Set|Get) The Connector To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:931 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Connector To the Table.")>
        Public Connector As LineInfo
#End Region '(Set|Get) The Connector To the Table.

#Region "[On] |2019/07/08 18h11:709| <15.00.11> <Runtime> <> |.Log()|String"' (Set|Get) The Log To the Table.
        '''    <Summary>
        '''     (Set|Get) The Log To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:933 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Log To the Table.")>
        Public Log As String
#End Region '(Set|Get) The Log To the Table.

#End Region
#Region "<7> [Loader]{2}"
#Region "[On] |2019/07/08 18h11:717| <06.00.00> <Loader> <> |.Empty()|Function}|"' (Set|Get) The sub Empty.
        '''    <Summary>
        '''     (Set|Get) The sub Empty.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:933 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The sub Empty.")>
        Public Sub New()
            Reset
        End Sub
#End Region '(Set|Get) The sub Empty.

#Region "[On] |2019/07/08 18h11:719| <06.00.01> <Loader> <> |.Filled()|Function}|"' (Set|Get) The sub Filled.
        '''    <Summary>
        '''     (Set|Get) The sub Filled.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:933 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>    ''' <param name="N">(Set|Get) The N as Integer.</param>
        ''' <param name="RefTotal">(Set|Get) The RefTotal as Integer.</param>
        ''' <param name="Opening">(Set|Get) The Opening as Double.</param>
        ''' <param name="Debit">(Set|Get) The Debit as Double.</param>
        ''' <param name="Credit">(Set|Get) The Credit as Double.</param>
        ''' <param name="Balance">(Set|Get) The Balance as Double.</param>
        ''' <param name="Closing">(Set|Get) The Closing as Double.</param>
        ''' <param name="Variation">(Set|Get) The Variation as Double.</param>
        ''' <param name="Français">(Set|Get) The Français as String.</param>
        ''' <param name="English">(Set|Get) The English as String.</param>
        ''' <param name="Italian">(Set|Get) The Italian as String.</param>
        ''' <param name="German">(Set|Get) The German as String.</param>
        ''' <param name="Spanish">(Set|Get) The Spanish as String.</param>
        ''' <param name="Portuguese">(Set|Get) The Portuguese as String.</param>
        ''' <param name="Russian">(Set|Get) The Russian as String.</param>

        <Browsable(True), Description("(Set|Get) The sub Filled.")>
        Public Sub New(ByVal N As Integer,
ByVal RefTotal As Integer,
ByVal Opening As Double,
ByVal Debit As Double,
ByVal Credit As Double,
ByVal Balance As Double,
ByVal Closing As Double,
ByVal Variation As Double,
ByVal Français As String,
ByVal English As String,
ByVal Italian As String,
ByVal German As String,
ByVal Spanish As String,
ByVal Portuguese As String,
ByVal Russian As String)
            With Me
                Clear()
                Reset()
                .N = N
                .RefTotal = RefTotal
                .Opening = Opening
                .Debit = Debit
                .Credit = Credit
                .Balance = Balance
                .Closing = Closing
                .Variation = Variation
                .Français = Français
                .English = English
                .Italian = Italian
                .German = German
                .Spanish = Spanish
                .Portuguese = Portuguese
                .Russian = Russian
            End With

        End Sub
#End Region '(Set|Get) The sub Filled.

#End Region
    End Class
#End Region

#Region "[On] |2019/07/08 18h11:795| <08.00.00> <Class> <> |.Tbl_CurrencyRatio|Class|{43} |Production Cost : 55.3|Selling Price : 138.25|"' Class created automatically by SmartOffice (c)Copyright 2019.
    '''    <Summary>
    '''     Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Tbl_CurrencyRatio
    '''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
    '''    Contributor Information : ||
    '''    Creation Date :           2019/07/08 18h11:795
    '''    |Schema|
    '''    |ID| |ObjectType |{Quantity}||UnitPrice||Total
    '''    |00| |Importation|{0}||1| |0
    '''    |01| |Properties |{16}||0.8| |12.8
    '''    |02| |Enumeration|{1}||0.4| |0.4
    '''    |03| |Structure  |{0}||0.4| |0
    '''    |04| |Sub        |{5}||1.2| |6
    '''    |05| |Function   |{7}||1.6| |11.2
    '''    |06| |Runtime    |{12}||0.4| |4.8
    '''    |07| |Loader     |{2}||0.8| |1.6
    '''    |08| |Class      |{0}||2| |0
    '''    |09| |Constante  |{0}||0.4| |0
    '''    |10| |Event      |{0}||1.2| |0
    '''    |11| |Members    |{16}||0.5| |8
    '''    |12| |Parameter  |{21}||0.5| |10.5
    '''    |Production Cost             |55.3
    '''    |Selling Price without VAT   |138.25
    '''    |Total TVA                   |10.65
    '''    |Grand Total                 |148.9
    '''    |/Schema|
    '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
    '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
    '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
    '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:942 </Published>
    '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
    '''    </Summary>
    Public Class Tbl_CurrencyRatio
#Region "<1> [Property]{16}"
#Region "[On] |2019/07/08 18h11:796| <01.00.00> <Property> <Columns> |.ID()|Integer|"' (Set|Get) The ID as Integer.
        Private _ID As Integer
        '''    <Summary>
        '''     (Set|Get) The ID as Integer.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:942 </Published>
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

#Region "[On] |2019/07/08 18h11:802| <01.00.01> <Property> <Columns> |.Symbol()|String|"' (Set|Get) The Symbol as String.
        Private _Symbol As String
        '''    <Summary>
        '''     (Set|Get) The Symbol as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:942 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Symbol as String.")>
        Public Property Symbol() As String
            Get
                Return _Symbol
            End Get
            Set(ByVal Value As String)
                _Symbol = Value
            End Set
        End Property
#End Region '(Set|Get) The Symbol as String.

#Region "[On] |2019/07/08 18h11:809| <01.00.02> <Property> <Columns> |.OPE()|Double|"' (Set|Get) The OPE as Double.
        Private _OPE As Double
        '''    <Summary>
        '''     (Set|Get) The OPE as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:942 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The OPE as Double.")>
        Public Property OPE() As Double
            Get
                Return _OPE
            End Get
            Set(ByVal Value As Double)
                _OPE = Value
            End Set
        End Property
#End Region '(Set|Get) The OPE as Double.

#Region "[On] |2019/07/08 18h11:816| <01.00.03> <Property> <Columns> |.JAN()|Double|"' (Set|Get) The JAN as Double.
        Private _JAN As Double
        '''    <Summary>
        '''     (Set|Get) The JAN as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:942 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The JAN as Double.")>
        Public Property JAN() As Double
            Get
                Return _JAN
            End Get
            Set(ByVal Value As Double)
                _JAN = Value
            End Set
        End Property
#End Region '(Set|Get) The JAN as Double.

#Region "[On] |2019/07/08 18h11:822| <01.00.04> <Property> <Columns> |.FEB()|Double|"' (Set|Get) The FEB as Double.
        Private _FEB As Double
        '''    <Summary>
        '''     (Set|Get) The FEB as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:943 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The FEB as Double.")>
        Public Property FEB() As Double
            Get
                Return _FEB
            End Get
            Set(ByVal Value As Double)
                _FEB = Value
            End Set
        End Property
#End Region '(Set|Get) The FEB as Double.

#Region "[On] |2019/07/08 18h11:829| <01.00.05> <Property> <Columns> |.MAR()|Double|"' (Set|Get) The MAR as Double.
        Private _MAR As Double
        '''    <Summary>
        '''     (Set|Get) The MAR as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:943 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The MAR as Double.")>
        Public Property MAR() As Double
            Get
                Return _MAR
            End Get
            Set(ByVal Value As Double)
                _MAR = Value
            End Set
        End Property
#End Region '(Set|Get) The MAR as Double.

#Region "[On] |2019/07/08 18h11:835| <01.00.06> <Property> <Columns> |.APR()|Double|"' (Set|Get) The APR as Double.
        Private _APR As Double
        '''    <Summary>
        '''     (Set|Get) The APR as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:943 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The APR as Double.")>
        Public Property APR() As Double
            Get
                Return _APR
            End Get
            Set(ByVal Value As Double)
                _APR = Value
            End Set
        End Property
#End Region '(Set|Get) The APR as Double.

#Region "[On] |2019/07/08 18h11:842| <01.00.07> <Property> <Columns> |.MAY()|Double|"' (Set|Get) The MAY as Double.
        Private _MAY As Double
        '''    <Summary>
        '''     (Set|Get) The MAY as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:943 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The MAY as Double.")>
        Public Property MAY() As Double
            Get
                Return _MAY
            End Get
            Set(ByVal Value As Double)
                _MAY = Value
            End Set
        End Property
#End Region '(Set|Get) The MAY as Double.

#Region "[On] |2019/07/08 18h11:849| <01.00.08> <Property> <Columns> |.JUN()|Double|"' (Set|Get) The JUN as Double.
        Private _JUN As Double
        '''    <Summary>
        '''     (Set|Get) The JUN as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:943 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The JUN as Double.")>
        Public Property JUN() As Double
            Get
                Return _JUN
            End Get
            Set(ByVal Value As Double)
                _JUN = Value
            End Set
        End Property
#End Region '(Set|Get) The JUN as Double.

#Region "[On] |2019/07/08 18h11:860| <01.00.09> <Property> <Columns> |.JUL()|Double|"' (Set|Get) The JUL as Double.
        Private _JUL As Double
        '''    <Summary>
        '''     (Set|Get) The JUL as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:943 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The JUL as Double.")>
        Public Property JUL() As Double
            Get
                Return _JUL
            End Get
            Set(ByVal Value As Double)
                _JUL = Value
            End Set
        End Property
#End Region '(Set|Get) The JUL as Double.

#Region "[On] |2019/07/08 18h11:867| <01.00.10> <Property> <Columns> |.AUG()|Double|"' (Set|Get) The AUG as Double.
        Private _AUG As Double
        '''    <Summary>
        '''     (Set|Get) The AUG as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:944 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The AUG as Double.")>
        Public Property AUG() As Double
            Get
                Return _AUG
            End Get
            Set(ByVal Value As Double)
                _AUG = Value
            End Set
        End Property
#End Region '(Set|Get) The AUG as Double.

#Region "[On] |2019/07/08 18h11:873| <01.00.11> <Property> <Columns> |.SEP()|Double|"' (Set|Get) The SEP as Double.
        Private _SEP As Double
        '''    <Summary>
        '''     (Set|Get) The SEP as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:944 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The SEP as Double.")>
        Public Property SEP() As Double
            Get
                Return _SEP
            End Get
            Set(ByVal Value As Double)
                _SEP = Value
            End Set
        End Property
#End Region '(Set|Get) The SEP as Double.

#Region "[On] |2019/07/08 18h11:880| <01.00.12> <Property> <Columns> |.OCT()|Double|"' (Set|Get) The OCT as Double.
        Private _OCT As Double
        '''    <Summary>
        '''     (Set|Get) The OCT as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:944 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The OCT as Double.")>
        Public Property OCT() As Double
            Get
                Return _OCT
            End Get
            Set(ByVal Value As Double)
                _OCT = Value
            End Set
        End Property
#End Region '(Set|Get) The OCT as Double.

#Region "[On] |2019/07/08 18h11:887| <01.00.13> <Property> <Columns> |.NOV()|Double|"' (Set|Get) The NOV as Double.
        Private _NOV As Double
        '''    <Summary>
        '''     (Set|Get) The NOV as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:944 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The NOV as Double.")>
        Public Property NOV() As Double
            Get
                Return _NOV
            End Get
            Set(ByVal Value As Double)
                _NOV = Value
            End Set
        End Property
#End Region '(Set|Get) The NOV as Double.

#Region "[On] |2019/07/08 18h11:893| <01.00.14> <Property> <Columns> |.DEC()|Double|"' (Set|Get) The DEC as Double.
        Private _DEC As Double
        '''    <Summary>
        '''     (Set|Get) The DEC as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:944 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The DEC as Double.")>
        Public Property DEC() As Double
            Get
                Return _DEC
            End Get
            Set(ByVal Value As Double)
                _DEC = Value
            End Set
        End Property
#End Region '(Set|Get) The DEC as Double.

#Region "[On] |2019/07/08 18h11:899| <01.00.15> <Property> <Columns> |.CLO()|Double|"' (Set|Get) The CLO as Double.
        Private _CLO As Double
        '''    <Summary>
        '''     (Set|Get) The CLO as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:945 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The CLO as Double.")>
        Public Property CLO() As Double
            Get
                Return _CLO
            End Get
            Set(ByVal Value As Double)
                _CLO = Value
            End Set
        End Property
#End Region '(Set|Get) The CLO as Double.

#End Region
#Region "<2> [Enumeration]{1}"
#Region "[On] |2019/07/08 18h11:905| <02.00.00> <Enumeration> <> |.Schema()|Enumeration{15}|"' (Set|Get) The enumeration of Schema.
        '''    <Summary>
        '''     (Set|Get) The enumeration of Schema.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:945 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The enumeration of Schema.")>
        Enum Schema
            ''' <summary>(Set|Get) The ID as Integer.</summary>
            [ID] = 0
            ''' <summary>(Set|Get) The Symbol as String.</summary>
            [Symbol] = 1
            ''' <summary>(Set|Get) The OPE as Double.</summary>
            [OPE] = 2
            ''' <summary>(Set|Get) The JAN as Double.</summary>
            [JAN] = 3
            ''' <summary>(Set|Get) The FEB as Double.</summary>
            [FEB] = 4
            ''' <summary>(Set|Get) The MAR as Double.</summary>
            [MAR] = 5
            ''' <summary>(Set|Get) The APR as Double.</summary>
            [APR] = 6
            ''' <summary>(Set|Get) The MAY as Double.</summary>
            [MAY] = 7
            ''' <summary>(Set|Get) The JUN as Double.</summary>
            [JUN] = 8
            ''' <summary>(Set|Get) The JUL as Double.</summary>
            [JUL] = 9
            ''' <summary>(Set|Get) The AUG as Double.</summary>
            [AUG] = 10
            ''' <summary>(Set|Get) The SEP as Double.</summary>
            [SEP] = 11
            ''' <summary>(Set|Get) The OCT as Double.</summary>
            [OCT] = 12
            ''' <summary>(Set|Get) The NOV as Double.</summary>
            [NOV] = 13
            ''' <summary>(Set|Get) The DEC as Double.</summary>
            [DEC] = 14
            ''' <summary>(Set|Get) The CLO as Double.</summary>
            [CLO] = 15
        End Enum
#End Region '(Set|Get) The enumeration of Schema.

#End Region
#Region "<4> [Sub]{5}"
#Region "[On] |2019/07/08 18h11:912| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
        '''    <Summary>
        '''     (Set|Get) This will reinitialize the class element.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:945 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will reinitialize the class element.")>
        Public Sub Clear()
            With Me
                .ID = 0
                .Symbol = Nothing
                .OPE = 0
                .JAN = 0
                .FEB = 0
                .MAR = 0
                .APR = 0
                .MAY = 0
                .JUN = 0
                .JUL = 0
                .AUG = 0
                .SEP = 0
                .OCT = 0
                .NOV = 0
                .DEC = 0
                .CLO = 0
            End With
        End Sub
#End Region '(Set|Get) This will reinitialize the class element.

#Region "[On] |2019/07/08 18h11:919| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
        '''    <Summary>
        '''     (Set|Get) This will reinitialize the variables of this class.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:945 </Published>
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
                    TableName = "Tbl_CurrencyRatio"
                    Line = Connector.Line
                    UseSQL = False
                Else
                    FilePath = My.Settings.Db_Accountis_FilePath
                    Password = My.Settings.Db_Accountis_Password
                    Me.Line = My.Settings.Db_Accountis_Line
                    TableName = "Tbl_CurrencyRatio"
                    UseSQL = False
                End If
            Else
                If IsNothing(FilePath) Then
                    FilePath = My.Settings.Db_Accountis_FilePath
                End If
                If FilePath.Length < 1 Then
                    FilePath = My.Settings.Db_Accountis_FilePath
                End If
                FilePath = My.Settings.Db_Accountis_FilePath
                Password = My.Settings.Db_Accountis_Password
                Me.Line = My.Settings.Db_Accountis_Line
                TableName = "Tbl_CurrencyRatio"
                UseSQL = False
            End If

        End Sub
#End Region '(Set|Get) This will reinitialize the variables of this class.

#Region "[On] |2019/07/08 18h11:926| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
        '''    <Summary>
        '''     (Set|Get) This will add a new row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:945 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will add a new row in the table.")>
        Public Sub Add()
            Try
                Dim Str As String = Nothing
                Str = "Insert Into [Tbl_CurrencyRatio] (
`ID`, 
`Symbol`, 
`OPE`, 
`JAN`, 
`FEB`, 
`MAR`, 
`APR`, 
`MAY`, 
`JUN`, 
`JUL`, 
`AUG`, 
`SEP`, 
`OCT`, 
`NOV`, 
`DEC`, 
`CLO`) Values (@0, @1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15)"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@0", Me.ID)
                Cmd.Parameters.AddWithValue("@1", Me.Symbol)
                Cmd.Parameters.AddWithValue("@2", Me.OPE)
                Cmd.Parameters.AddWithValue("@3", Me.JAN)
                Cmd.Parameters.AddWithValue("@4", Me.FEB)
                Cmd.Parameters.AddWithValue("@5", Me.MAR)
                Cmd.Parameters.AddWithValue("@6", Me.APR)
                Cmd.Parameters.AddWithValue("@7", Me.MAY)
                Cmd.Parameters.AddWithValue("@8", Me.JUN)
                Cmd.Parameters.AddWithValue("@9", Me.JUL)
                Cmd.Parameters.AddWithValue("@10", Me.AUG)
                Cmd.Parameters.AddWithValue("@11", Me.SEP)
                Cmd.Parameters.AddWithValue("@12", Me.OCT)
                Cmd.Parameters.AddWithValue("@13", Me.NOV)
                Cmd.Parameters.AddWithValue("@14", Me.DEC)
                Cmd.Parameters.AddWithValue("@15", Me.CLO)
                If Cmd.ExecuteNonQuery >= 0 Then
                Else
                    Msgbox("Element not Addd")
                End If
            Catch ex As Exception
            Finally
                Close(True)
            End Try

        End Sub
#End Region '(Set|Get) This will add a new row in the table.

#Region "[On] |2019/07/08 18h11:934| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
        '''    <Summary>
        '''     (Set|Get) This will update a row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:945 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will update a row in the table.")>
        Public Sub Save()
            Try
                Dim Str As String = Nothing
                Str = "UPDATE [Tbl_CurrencyRatio] SET Symbol = @Symbol, OPE = @OPE, JAN = @JAN, FEB = @FEB, MAR = @MAR, APR = @APR, MAY = @MAY, JUN = @JUN, JUL = @JUL, AUG = @AUG, SEP = @SEP, OCT = @OCT, NOV = @NOV, DEC = @DEC, CLO = @CLO WHERE ID = @ID"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@Symbol", Symbol)
                Cmd.Parameters.AddWithValue("@OPE", OPE)
                Cmd.Parameters.AddWithValue("@JAN", JAN)
                Cmd.Parameters.AddWithValue("@FEB", FEB)
                Cmd.Parameters.AddWithValue("@MAR", MAR)
                Cmd.Parameters.AddWithValue("@APR", APR)
                Cmd.Parameters.AddWithValue("@MAY", MAY)
                Cmd.Parameters.AddWithValue("@JUN", JUN)
                Cmd.Parameters.AddWithValue("@JUL", JUL)
                Cmd.Parameters.AddWithValue("@AUG", AUG)
                Cmd.Parameters.AddWithValue("@SEP", SEP)
                Cmd.Parameters.AddWithValue("@OCT", OCT)
                Cmd.Parameters.AddWithValue("@NOV", NOV)
                Cmd.Parameters.AddWithValue("@DEC", DEC)
                Cmd.Parameters.AddWithValue("@CLO", CLO)
                Cmd.Parameters.AddWithValue("@ID", ID)
                If Cmd.ExecuteNonQuery >= 0 Then
                Else
                    Msgbox("Element not Saved")
                End If
            Catch ex As Exception
            Finally
                Close(True)
            End Try

        End Sub
#End Region '(Set|Get) This will update a row in the table.

#Region "[On] |2019/07/08 18h11:941| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
        '''    <Summary>
        '''     (Set|Get) This will Delete a row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:946 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will Delete a row in the table.")>
        Public Sub Delete()
            Try
                Dim Str As String = Nothing
                Str = "Delete From [Tbl_CurrencyRatio] WHERE ID =@ID"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@ID", ID)
                If Cmd.ExecuteNonQuery >= 0 Then
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
#Region "[On] |2019/07/08 18h11:948| <05.00.00> <Function> <> |.Open()|TestItem}|"' (Set|Get) This will initialise the connection and import the data.
        '''    <Summary>
        '''     (Set|Get) This will initialise the connection and import the data.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:946 </Published>
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
                Result.Why += Log & VbNewLine
            End If
            Return Result

        End Function
#End Region '(Set|Get) This will initialise the connection and import the data.

#Region "[On] |2019/07/08 18h11:955| <05.00.01> <Function> <> |.Close()|TestItem}|"' (Set|Get) This willClosing the connection
        '''    <Summary>
        '''     (Set|Get) This willClosing the connection
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:946 </Published>
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

#Region "[On] |2019/07/08 18h11:967| <05.00.02> <Function> <> |.List()|List(Of Tbl_CurrencyRatio)}|"' (Set|Get) Return the entire table listed
        '''    <Summary>
        '''     (Set|Get) Return the entire table listed
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:949 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Return the entire table listed")>
        Public Function List() As List(Of Tbl_CurrencyRatio)
            Dim Result As New List(Of Tbl_CurrencyRatio)
            Me.Table = New Table(Me.TableName, Me.FilePath, Me.Password, False)
            For Each Row As DataRow In Me.Table.DataTable.Rows
                Dim Element As New Tbl_CurrencyRatio(IIf(IsDBNull(Row.Item(0)), 0, Row.Item(0)),
IIf(IsDBNull(Row.Item(1)), "", Row.Item(1)),
IIf(IsDBNull(Row.Item(2)), 0, Row.Item(2)),
IIf(IsDBNull(Row.Item(3)), 0, Row.Item(3)),
IIf(IsDBNull(Row.Item(4)), 0, Row.Item(4)),
IIf(IsDBNull(Row.Item(5)), 0, Row.Item(5)),
IIf(IsDBNull(Row.Item(6)), 0, Row.Item(6)),
IIf(IsDBNull(Row.Item(7)), 0, Row.Item(7)),
IIf(IsDBNull(Row.Item(8)), 0, Row.Item(8)),
IIf(IsDBNull(Row.Item(9)), 0, Row.Item(9)),
IIf(IsDBNull(Row.Item(10)), 0, Row.Item(10)),
IIf(IsDBNull(Row.Item(11)), 0, Row.Item(11)),
IIf(IsDBNull(Row.Item(12)), 0, Row.Item(12)),
IIf(IsDBNull(Row.Item(13)), 0, Row.Item(13)),
IIf(IsDBNull(Row.Item(14)), 0, Row.Item(14)),
      IIf(IsDBNull(Row.Item(15)), 0, Row.Item(15)))
                Element.Reset(Table.Line)
                Result.Add(Element)
            Next
            Return Result
        End Function
#End Region '(Set|Get) Return the entire table listed

#Region "[On] |2019/07/08 18h11:975| <05.00.03> <Function> <> |.SearchByName()|List(Of Tbl_CurrencyRatio)}|"' (Set|Get) Search for each property that match the Search String.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search String.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:949 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Search for each property that match the Search String.")>
        Public Shared Function SearchByName(ByVal Search As String) As List(Of Tbl_CurrencyRatio)
            Dim Result As New List(Of Tbl_CurrencyRatio)
            Dim C As New Tbl_CurrencyRatio
            For Each Element As Tbl_CurrencyRatio In C.List
                If Element.Symbol.Tolower() = Search.Tolower() Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search String.

#Region "[On] |2019/07/08 18h11:982| <05.00.04> <Function> <> |.SearchByID()|List(Of Tbl_CurrencyRatio)}|"' (Set|Get) Search for each property that match the Search Id.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search Id.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:950 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Search for each property that match the Search Id.")>
        Public Shared Function SearchByID(ByVal Search As Double) As List(Of Tbl_CurrencyRatio)
            Dim Result As New List(Of Tbl_CurrencyRatio)
            Dim C As New Tbl_CurrencyRatio
            For Each Element As Tbl_CurrencyRatio In C.List
                If Val(Element.ID) = Search Or Val(Element.OPE) = Search Or Val(Element.JAN) = Search Or Val(Element.FEB) = Search Or Val(Element.MAR) = Search Or Val(Element.APR) = Search Or Val(Element.MAY) = Search Or Val(Element.JUN) = Search Or Val(Element.JUL) = Search Or Val(Element.AUG) = Search Or Val(Element.SEP) = Search Or Val(Element.OCT) = Search Or Val(Element.NOV) = Search Or Val(Element.DEC) = Search Or Val(Element.CLO) = Search Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search Id.

#Region "[On] |2019/07/08 18h11:989| <05.00.05> <Function> <> |.ToString()|String}|"' (Set|Get) The function ToString.
        '''    <Summary>
        '''     (Set|Get) The function ToString.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:950 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The function ToString.")>
        Public Overrides Function ToString() As String
            Return Me.Symbol
        End Function
#End Region '(Set|Get) The function ToString.

#Region "[On] |2019/07/08 18h11:996| <05.00.06> <Function> <> |.CheckConnection()|Boolean}|"' (Set|Get) Evaluate the connection to the DataBase
        '''    <Summary>
        '''     (Set|Get) Evaluate the connection to the DataBase
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:950 </Published>
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
                    Me.Connector = New LineInfo(FilePath, Password)
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
            Log += Message & VbNewLine
            Return General_Status

        End Function
#End Region '(Set|Get) Evaluate the connection to the DataBase

#End Region
#Region "<6> [Runtime]{12}"
#Region "[On] |2019/07/08 18h11:004| <15.00.00> <Runtime> <> |.Table()|Table"' (Set|Get) The Table.
        '''    <Summary>
        '''     (Set|Get) The Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:950 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Table.")>
        Public Table As Table
#End Region '(Set|Get) The Table.

#Region "[On] |2019/07/08 18h11:011| <15.00.01> <Runtime> <> |.Line()|String"' (Set|Get) The Connection String To the Table.
        '''    <Summary>
        '''     (Set|Get) The Connection String To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:950 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Connection String To the Table.")>
        Public Line As String
#End Region '(Set|Get) The Connection String To the Table.

#Region "[On] |2019/07/08 18h11:018| <15.00.02> <Runtime> <> |.FilePath()|String"' (Set|Get) The FilePath To the Table.
        '''    <Summary>
        '''     (Set|Get) The FilePath To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:951 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The FilePath To the Table.")>
        Public FilePath As String
#End Region '(Set|Get) The FilePath To the Table.

#Region "[On] |2019/07/08 18h11:026| <15.00.03> <Runtime> <> |.Password()|String"' (Set|Get) The Password To the Table.
        '''    <Summary>
        '''     (Set|Get) The Password To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:951 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Password To the Table.")>
        Public Password As String
#End Region '(Set|Get) The Password To the Table.

#Region "[On] |2019/07/08 18h11:033| <15.00.04> <Runtime> <> |.UseSQL()|Boolean"' (Set|Get) Determines if the Database Connection is of type SQL.
        '''    <Summary>
        '''     (Set|Get) Determines if the Database Connection is of type SQL.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:951 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Determines if the Database Connection is of type SQL.")>
        Public UseSQL As Boolean
#End Region '(Set|Get) Determines if the Database Connection is of type SQL.

#Region "[On] |2019/07/08 18h11:040| <15.00.05> <Runtime> <> |.TableName()|String"' (Set|Get) The name of the Table.
        '''    <Summary>
        '''     (Set|Get) The name of the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:951 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The name of the Table.")>
        Public TableName As String
#End Region '(Set|Get) The name of the Table.

#Region "[On] |2019/07/08 18h11:048| <15.00.06> <Runtime> <> |.Con()|OleDb.OleDbConnection"' (Set|Get) The Con To the Table.
        '''    <Summary>
        '''     (Set|Get) The Con To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:951 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Con To the Table.")>
        Public Con As OleDb.OleDbConnection
#End Region '(Set|Get) The Con To the Table.

#Region "[On] |2019/07/08 18h11:052| <15.00.07> <Runtime> <> |.Cmd()|OleDb.OleDbCommand"' (Set|Get) The Cmd To the Table.
        '''    <Summary>
        '''     (Set|Get) The Cmd To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:952 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Cmd To the Table.")>
        Public Cmd As OleDb.OleDbCommand
#End Region '(Set|Get) The Cmd To the Table.

#Region "[On] |2019/07/08 18h11:069| <15.00.08> <Runtime> <> |.DataReader()|OleDb.OleDbDataReader"' (Set|Get) The DataReader To the Table.
        '''    <Summary>
        '''     (Set|Get) The DataReader To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:952 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The DataReader To the Table.")>
        Public DataReader As OleDb.OleDbDataReader
#End Region '(Set|Get) The DataReader To the Table.

#Region "[On] |2019/07/08 18h11:077| <15.00.09> <Runtime> <> |.DataAdapter()|OleDb.OleDbDataAdapter"' (Set|Get) The DataAdapter To the Table.
        '''    <Summary>
        '''     (Set|Get) The DataAdapter To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:952 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The DataAdapter To the Table.")>
        Public DataAdapter As OleDb.OleDbDataAdapter
#End Region '(Set|Get) The DataAdapter To the Table.

#Region "[On] |2019/07/08 18h11:084| <15.00.10> <Runtime> <> |.Connector()|LineInfo"' (Set|Get) The Connector To the Table.
        '''    <Summary>
        '''     (Set|Get) The Connector To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:952 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Connector To the Table.")>
        Public Connector As LineInfo
#End Region '(Set|Get) The Connector To the Table.

#Region "[On] |2019/07/08 18h11:092| <15.00.11> <Runtime> <> |.Log()|String"' (Set|Get) The Log To the Table.
        '''    <Summary>
        '''     (Set|Get) The Log To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:952 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Log To the Table.")>
        Public Log As String
#End Region '(Set|Get) The Log To the Table.

#End Region
#Region "<7> [Loader]{2}"
#Region "[On] |2019/07/08 18h11:099| <06.00.00> <Loader> <> |.Empty()|Function}|"' (Set|Get) The sub Empty.
        '''    <Summary>
        '''     (Set|Get) The sub Empty.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:953 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The sub Empty.")>
        Public Sub New()
            Reset
        End Sub
#End Region '(Set|Get) The sub Empty.

#Region "[On] |2019/07/08 18h11:101| <06.00.01> <Loader> <> |.Filled()|Function}|"' (Set|Get) The sub Filled.
        '''    <Summary>
        '''     (Set|Get) The sub Filled.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:953 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>    ''' <param name="ID">(Set|Get) The ID as Integer.</param>
        ''' <param name="Symbol">(Set|Get) The Symbol as String.</param>
        ''' <param name="OPE">(Set|Get) The OPE as Double.</param>
        ''' <param name="JAN">(Set|Get) The JAN as Double.</param>
        ''' <param name="FEB">(Set|Get) The FEB as Double.</param>
        ''' <param name="MAR">(Set|Get) The MAR as Double.</param>
        ''' <param name="APR">(Set|Get) The APR as Double.</param>
        ''' <param name="MAY">(Set|Get) The MAY as Double.</param>
        ''' <param name="JUN">(Set|Get) The JUN as Double.</param>
        ''' <param name="JUL">(Set|Get) The JUL as Double.</param>
        ''' <param name="AUG">(Set|Get) The AUG as Double.</param>
        ''' <param name="SEP">(Set|Get) The SEP as Double.</param>
        ''' <param name="OCT">(Set|Get) The OCT as Double.</param>
        ''' <param name="NOV">(Set|Get) The NOV as Double.</param>
        ''' <param name="DEC">(Set|Get) The DEC as Double.</param>
        ''' <param name="CLO">(Set|Get) The CLO as Double.</param>

        <Browsable(True), Description("(Set|Get) The sub Filled.")>
        Public Sub New(ByVal ID As Integer,
ByVal Symbol As String,
ByVal OPE As Double,
ByVal JAN As Double,
ByVal FEB As Double,
ByVal MAR As Double,
ByVal APR As Double,
ByVal MAY As Double,
ByVal JUN As Double,
ByVal JUL As Double,
ByVal AUG As Double,
ByVal SEP As Double,
ByVal OCT As Double,
ByVal NOV As Double,
ByVal DEC As Double,
ByVal CLO As Double)
            With Me
                Clear()
                Reset()
                .ID = ID
                .Symbol = Symbol
                .OPE = OPE
                .JAN = JAN
                .FEB = FEB
                .MAR = MAR
                .APR = APR
                .MAY = MAY
                .JUN = JUN
                .JUL = JUL
                .AUG = AUG
                .SEP = SEP
                .OCT = OCT
                .NOV = NOV
                .DEC = DEC
                .CLO = CLO
            End With

        End Sub
#End Region '(Set|Get) The sub Filled.

#End Region
    End Class
#End Region

#Region "[On] |2019/07/08 18h11:192| <08.00.00> <Class> <> |.Tbl_Entries|Class|{45} |Production Cost : 60|Selling Price : 150|"' Class created automatically by SmartOffice (c)Copyright 2019.
    '''    <Summary>
    '''     Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Tbl_Entries
    '''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
    '''    Contributor Information : ||
    '''    Creation Date :           2019/07/08 18h11:192
    '''    |Schema|
    '''    |ID| |ObjectType |{Quantity}||UnitPrice||Total
    '''    |00| |Importation|{0}||1| |0
    '''    |01| |Properties |{16}||0.8| |12.8
    '''    |02| |Enumeration|{1}||0.4| |0.4
    '''    |03| |Structure  |{0}||0.4| |0
    '''    |04| |Sub        |{5}||1.2| |6
    '''    |05| |Function   |{9}||1.6| |14.4
    '''    |06| |Runtime    |{12}||0.4| |4.8
    '''    |07| |Loader     |{2}||0.8| |1.6
    '''    |08| |Class      |{0}||2| |0
    '''    |09| |Constante  |{0}||0.4| |0
    '''    |10| |Event      |{0}||1.2| |0
    '''    |11| |Members    |{16}||0.5| |8
    '''    |12| |Parameter  |{24}||0.5| |12
    '''    |Production Cost             |60
    '''    |Selling Price without VAT   |150
    '''    |Total TVA                   |11.55
    '''    |Grand Total                 |161.55
    '''    |/Schema|
    '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
    '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
    '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
    '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:963 </Published>
    '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
    '''    </Summary>
    Public Class Tbl_Entries
#Region "<1> [Property]{16}"
#Region "[On] |2019/07/08 18h11:193| <01.00.00> <Property> <Columns> |.N()|Integer|"' (Set|Get) The N as Integer.
        Private _N As Integer
        '''    <Summary>
        '''     (Set|Get) The N as Integer.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:963 </Published>
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
#Region "[On] |2019/07/08 18h11:199| <01.00.01> <Property> <Columns> |.Extourne()|Boolean|"' (Set|Get) The Extourne as Boolean.
        Private _Extourne As Boolean
        '''    <Summary>
        '''     (Set|Get) The Extourne as Boolean.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:963 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Extourne as Boolean.")>
        Public Property Extourne() As Boolean
            Get
                Return _Extourne
            End Get
            Set(ByVal Value As Boolean)
                _Extourne = Value
            End Set
        End Property
#End Region '(Set|Get) The Extourne as Boolean.
#Region "[On] |2019/07/08 18h11:208| <01.00.02> <Property> <Columns> |.Periode()|String|"' (Set|Get) The Periode as String.
        Private _Periode As String
        '''    <Summary>
        '''     (Set|Get) The Periode as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:963 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Periode as String.")>
        Public Property Periode() As String
            Get
                Return _Periode
            End Get
            Set(ByVal Value As String)
                _Periode = Value
            End Set
        End Property
#End Region '(Set|Get) The Periode as String.
#Region "[On] |2019/07/08 18h11:216| <01.00.03> <Property> <Columns> |.PeriodeID()|Integer|"' (Set|Get) The PeriodeID as Integer.
        Private _PeriodeID As Integer
        '''    <Summary>
        '''     (Set|Get) The PeriodeID as Integer.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:964 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The PeriodeID as Integer.")>
        Public Property PeriodeID() As Integer
            Get
                Return _PeriodeID
            End Get
            Set(ByVal Value As Integer)
                _PeriodeID = Value
            End Set
        End Property
#End Region '(Set|Get) The PeriodeID as Integer.
#Region "[On] |2019/07/08 18h11:223| <01.00.04> <Property> <Columns> |.PCode()|String|"' (Set|Get) The PCode as String.
        Private _PCode As String
        '''    <Summary>
        '''     (Set|Get) The PCode as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:964 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The PCode as String.")>
        Public Property PCode() As String
            Get
                Return _PCode
            End Get
            Set(ByVal Value As String)
                _PCode = Value
            End Set
        End Property
#End Region '(Set|Get) The PCode as String.
#Region "[On] |2019/07/08 18h11:229| <01.00.05> <Property> <Columns> |.EntryType()|String|"' (Set|Get) The EntryType as String.
        Private _EntryType As String
        '''    <Summary>
        '''     (Set|Get) The EntryType as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:964 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The EntryType as String.")>
        Public Property EntryType() As String
            Get
                Return _EntryType
            End Get
            Set(ByVal Value As String)
                _EntryType = Value
            End Set
        End Property
#End Region '(Set|Get) The EntryType as String.
#Region "[On] |2019/07/08 18h11:236| <01.00.06> <Property> <Columns> |.EntryTypeID()|Integer|"' (Set|Get) The EntryTypeID as Integer.
        Private _EntryTypeID As Integer
        '''    <Summary>
        '''     (Set|Get) The EntryTypeID as Integer.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:964 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The EntryTypeID as Integer.")>
        Public Property EntryTypeID() As Integer
            Get
                Return _EntryTypeID
            End Get
            Set(ByVal Value As Integer)
                _EntryTypeID = Value
            End Set
        End Property
#End Region '(Set|Get) The EntryTypeID as Integer.
#Region "[On] |2019/07/08 18h11:242| <01.00.07> <Property> <Columns> |.EntryTypeCode()|String|"' (Set|Get) The EntryTypeCode as String.
        Private _EntryTypeCode As String
        '''    <Summary>
        '''     (Set|Get) The EntryTypeCode as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:964 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The EntryTypeCode as String.")>
        Public Property EntryTypeCode() As String
            Get
                Return _EntryTypeCode
            End Get
            Set(ByVal Value As String)
                _EntryTypeCode = Value
            End Set
        End Property
#End Region '(Set|Get) The EntryTypeCode as String.
#Region "[On] |2019/07/08 18h11:248| <01.00.08> <Property> <Columns> |.Date_Valeur()|DateTime|"' (Set|Get) The Date_Valeur as DateTime.
        Private _Date_Valeur As DateTime
        '''    <Summary>
        '''     (Set|Get) The Date_Valeur as DateTime.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:964 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Date_Valeur as DateTime.")>
        Public Property Date_Valeur() As DateTime
            Get
                Return _Date_Valeur
            End Get
            Set(ByVal Value As DateTime)
                _Date_Valeur = Value
            End Set
        End Property
#End Region '(Set|Get) The Date_Valeur as DateTime.
#Region "[On] |2019/07/08 18h11:254| <01.00.09> <Property> <Columns> |.Date_Echeance()|DateTime|"' (Set|Get) The Date_Echeance as DateTime.
        Private _Date_Echeance As DateTime
        '''    <Summary>
        '''     (Set|Get) The Date_Echeance as DateTime.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:965 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Date_Echeance as DateTime.")>
        Public Property Date_Echeance() As DateTime
            Get
                Return _Date_Echeance
            End Get
            Set(ByVal Value As DateTime)
                _Date_Echeance = Value
            End Set
        End Property
#End Region '(Set|Get) The Date_Echeance as DateTime.
#Region "[On] |2019/07/08 18h11:261| <01.00.10> <Property> <Columns> |.Date_Entry()|DateTime|"' (Set|Get) The Date_Entry as DateTime.
        Private _Date_Entry As DateTime
        '''    <Summary>
        '''     (Set|Get) The Date_Entry as DateTime.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:965 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Date_Entry as DateTime.")>
        Public Property Date_Entry() As DateTime
            Get
                Return _Date_Entry
            End Get
            Set(ByVal Value As DateTime)
                _Date_Entry = Value
            End Set
        End Property
#End Region '(Set|Get) The Date_Entry as DateTime.
#Region "[On] |2019/07/08 18h11:267| <01.00.11> <Property> <Columns> |.Description()|String|"' (Set|Get) The Description as String.
        Private _Description As String
        '''    <Summary>
        '''     (Set|Get) The Description as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:965 </Published>
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
#Region "[On] |2019/07/08 18h11:274| <01.00.12> <Property> <Columns> |.Note()|String|"' (Set|Get) The Note as String.
        Private _Note As String
        '''    <Summary>
        '''     (Set|Get) The Note as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:965 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Note as String.")>
        Public Property Note() As String
            Get
                Return _Note
            End Get
            Set(ByVal Value As String)
                _Note = Value
            End Set
        End Property
#End Region '(Set|Get) The Note as String.
#Region "[On] |2019/07/08 18h11:280| <01.00.13> <Property> <Columns> |.Debit()|Double|"' (Set|Get) The Debit as Double.
        Private _Debit As Double
        '''    <Summary>
        '''     (Set|Get) The Debit as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:965 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Debit as Double.")>
        Public Property Debit() As Double
            Get
                Return _Debit
            End Get
            Set(ByVal Value As Double)
                _Debit = Value
            End Set
        End Property
#End Region '(Set|Get) The Debit as Double.
#Region "[On] |2019/07/08 18h11:286| <01.00.14> <Property> <Columns> |.Credit()|Double|"' (Set|Get) The Credit as Double.
        Private _Credit As Double
        '''    <Summary>
        '''     (Set|Get) The Credit as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:966 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Credit as Double.")>
        Public Property Credit() As Double
            Get
                Return _Credit
            End Get
            Set(ByVal Value As Double)
                _Credit = Value
            End Set
        End Property
#End Region '(Set|Get) The Credit as Double.
#Region "[On] |2019/07/08 18h11:293| <01.00.15> <Property> <Columns> |.Balance()|Double|"' (Set|Get) The Balance as Double.
        Private _Balance As Double
        '''    <Summary>
        '''     (Set|Get) The Balance as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:966 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Balance as Double.")>
        Public Property Balance() As Double
            Get
                Return _Balance
            End Get
            Set(ByVal Value As Double)
                _Balance = Value
            End Set
        End Property
#End Region '(Set|Get) The Balance as Double.
#Region "[On] |2019/07/08 20h11:169| <01.01.00> <Property> <List> |.Lines()|List(Of Tbl_Entries_Line)|"' (Set|Get) The List as List(Of Tbl_Entries_Line).
        Private _Lines As List(Of Tbl_Entries_Line)
        '''    <Summary>
        '''     (Set|Get) The List as List(Of Tbl_Entries_Line).
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 20h11:175 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("List"), Description("(Set|Get) The List as List(Of Tbl_Entries_Line).")>
        Public Property Lines() As List(Of Tbl_Entries_Line)
            Get
                Return _Lines
            End Get
            Set(ByVal Value As List(Of Tbl_Entries_Line))
                _Lines = Value
            End Set
        End Property
#End Region '(Set|Get) The List as List(Of Tbl_Entries_Line).

#End Region
#Region "<2> [Enumeration]{1}"
#Region "[On] |2019/07/08 18h11:300| <02.00.00> <Enumeration> <> |.Schema()|Enumeration{15}|"' (Set|Get) The enumeration of Schema.
        '''    <Summary>
        '''     (Set|Get) The enumeration of Schema.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:966 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The enumeration of Schema.")>
        Enum Schema
            ''' <summary>(Set|Get) The N as Integer.</summary>
            [N] = 0
            ''' <summary>(Set|Get) The Extourne as Boolean.</summary>
            [Extourne] = 1
            ''' <summary>(Set|Get) The Periode as String.</summary>
            [Periode] = 2
            ''' <summary>(Set|Get) The PeriodeID as Integer.</summary>
            [PeriodeID] = 3
            ''' <summary>(Set|Get) The PCode as String.</summary>
            [PCode] = 4
            ''' <summary>(Set|Get) The EntryType as String.</summary>
            [EntryType] = 5
            ''' <summary>(Set|Get) The EntryTypeID as Integer.</summary>
            [EntryTypeID] = 6
            ''' <summary>(Set|Get) The EntryTypeCode as String.</summary>
            [EntryTypeCode] = 7
            ''' <summary>(Set|Get) The Date_Valeur as DateTime.</summary>
            [Date_Valeur] = 8
            ''' <summary>(Set|Get) The Date_Echeance as DateTime.</summary>
            [Date_Echeance] = 9
            ''' <summary>(Set|Get) The Date_Entry as DateTime.</summary>
            [Date_Entry] = 10
            ''' <summary>(Set|Get) The Description as String.</summary>
            [Description] = 11
            ''' <summary>(Set|Get) The Note as String.</summary>
            [Note] = 12
            ''' <summary>(Set|Get) The Debit as Double.</summary>
            [Debit] = 13
            ''' <summary>(Set|Get) The Credit as Double.</summary>
            [Credit] = 14
            ''' <summary>(Set|Get) The Balance as Double.</summary>
            [Balance] = 15
        End Enum
#End Region '(Set|Get) The enumeration of Schema.

#End Region
#Region "<4> [Sub]{5}"
#Region "[On] |2019/07/08 18h11:312| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
        '''    <Summary>
        '''     (Set|Get) This will reinitialize the class element.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:966 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will reinitialize the class element.")>
        Public Sub Clear()
            With Me
                .N = 0
                .Extourne = False
                .Periode = Nothing
                .PeriodeID = 0
                .PCode = Nothing
                .EntryType = Nothing
                .EntryTypeID = 0
                .EntryTypeCode = Nothing
                .Date_Valeur = New DateTime
                .Date_Echeance = New DateTime
                .Date_Entry = New DateTime
                .Description = Nothing
                .Note = Nothing
                .Debit = 0
                .Credit = 0
                .Balance = 0
            End With
        End Sub
#End Region '(Set|Get) This will reinitialize the class element.
#Region "[On] |2019/07/08 18h11:318| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
        '''    <Summary>
        '''     (Set|Get) This will reinitialize the variables of this class.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:966 </Published>
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
                    TableName = "Tbl_Entries"
                    Line = Connector.Line
                    UseSQL = False
                Else
                    FilePath = My.Settings.Db_Accountis_FilePath
                    Password = My.Settings.Db_Accountis_Password
                    Me.Line = My.Settings.Db_Accountis_Line
                    TableName = "Tbl_Entries"
                    UseSQL = False
                End If
            Else
                If IsNothing(FilePath) Then
                    FilePath = My.Settings.Db_Accountis_FilePath
                End If
                If FilePath.Length < 1 Then
                    FilePath = My.Settings.Db_Accountis_FilePath
                End If
                FilePath = My.Settings.Db_Accountis_FilePath
                Password = My.Settings.Db_Accountis_Password
                Me.Line = My.Settings.Db_Accountis_Line
                TableName = "Tbl_Entries"
                UseSQL = False
            End If

        End Sub
#End Region '(Set|Get) This will reinitialize the variables of this class.
#Region "[On] |2019/07/08 18h11:326| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
        '''    <Summary>
        '''     (Set|Get) This will add a new row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:967 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will add a new row in the table.")>
        Public Sub Add()
            Try
                Dim Str As String = Nothing
                Str = "Insert Into [Tbl_Entries] (
`N`, 
`Extourne`, 
`Periode`, 
`PeriodeID`, 
`PCode`, 
`EntryType`, 
`EntryTypeID`, 
`EntryTypeCode`, 
`Date_Valeur`, 
`Date_Echeance`, 
`Date_Entry`, 
`Description`, 
`Note`, 
`Debit`, 
`Credit`, 
`Balance`) Values (@0, @1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15)"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@0", Me.N)
                Cmd.Parameters.AddWithValue("@1", Me.Extourne)
                Cmd.Parameters.AddWithValue("@2", Me.Periode)
                Cmd.Parameters.AddWithValue("@3", Me.PeriodeID)
                Cmd.Parameters.AddWithValue("@4", Me.PCode)
                Cmd.Parameters.AddWithValue("@5", Me.EntryType)
                Cmd.Parameters.AddWithValue("@6", Me.EntryTypeID)
                Cmd.Parameters.AddWithValue("@7", Me.EntryTypeCode)
                Cmd.Parameters.AddWithValue("@8", Me.Date_Valeur)
                Cmd.Parameters.AddWithValue("@9", Me.Date_Echeance)
                Cmd.Parameters.AddWithValue("@10", Me.Date_Entry)
                Cmd.Parameters.AddWithValue("@11", Me.Description)
                Cmd.Parameters.AddWithValue("@12", Me.Note)
                Cmd.Parameters.AddWithValue("@13", Me.Debit)
                Cmd.Parameters.AddWithValue("@14", Me.Credit)
                Cmd.Parameters.AddWithValue("@15", Me.Balance)
                If Cmd.ExecuteNonQuery >= 0 Then
                Else
                    Msgbox("Element not Addd")
                End If
            Catch ex As Exception
            Finally
                Close(True)
            End Try

        End Sub
#End Region '(Set|Get) This will add a new row in the table.
#Region "[On] |2019/07/08 18h11:334| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
        '''    <Summary>
        '''     (Set|Get) This will update a row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:967 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will update a row in the table.")>
        Public Sub Save()
            Try
                Dim Str As String = Nothing
                Str = "UPDATE [Tbl_Entries] SET Extourne = @Extourne, Periode = @Periode, PeriodeID = @PeriodeID, PCode = @PCode, EntryType = @EntryType, EntryTypeID = @EntryTypeID, EntryTypeCode = @EntryTypeCode, Date_Valeur = @Date_Valeur, Date_Echeance = @Date_Echeance, Date_Entry = @Date_Entry, Description = @Description, Note = @Note, Debit = @Debit, Credit = @Credit, Balance = @Balance WHERE N = @N"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@Extourne", Extourne)
                Cmd.Parameters.AddWithValue("@Periode", Periode)
                Cmd.Parameters.AddWithValue("@PeriodeID", PeriodeID)
                Cmd.Parameters.AddWithValue("@PCode", PCode)
                Cmd.Parameters.AddWithValue("@EntryType", EntryType)
                Cmd.Parameters.AddWithValue("@EntryTypeID", EntryTypeID)
                Cmd.Parameters.AddWithValue("@EntryTypeCode", EntryTypeCode)
                Cmd.Parameters.AddWithValue("@Date_Valeur", Date_Valeur)
                Cmd.Parameters.AddWithValue("@Date_Echeance", Date_Echeance)
                Cmd.Parameters.AddWithValue("@Date_Entry", Date_Entry)
                Cmd.Parameters.AddWithValue("@Description", Description)
                Cmd.Parameters.AddWithValue("@Note", Note)
                Cmd.Parameters.AddWithValue("@Debit", Debit)
                Cmd.Parameters.AddWithValue("@Credit", Credit)
                Cmd.Parameters.AddWithValue("@Balance", Balance)
                Cmd.Parameters.AddWithValue("@N", N)
                If Cmd.ExecuteNonQuery >= 0 Then
                Else
                    Msgbox("Element not Saved")
                End If
            Catch ex As Exception
            Finally
                Close(True)
            End Try

        End Sub
#End Region '(Set|Get) This will update a row in the table.
#Region "[On] |2019/07/08 18h11:341| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
        '''    <Summary>
        '''     (Set|Get) This will Delete a row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:967 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will Delete a row in the table.")>
        Public Sub Delete()
            Try
                Dim Str As String = Nothing
                Str = "Delete From [Tbl_Entries] WHERE N =@N"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@N", N)
                If Cmd.ExecuteNonQuery >= 0 Then
                Else
                    Msgbox("Element not Deleted")
                End If
            Catch ex As Exception
            Finally
                Close(True)
            End Try

        End Sub
#End Region '(Set|Get) This will Delete a row in the table.
#Region "[On] |2019/07/08 20h04:945| <04.00.05> <Sub> <> |.List_Lines()|Sub}|"' (Set|Get) The sub Lines.
        '''    <Summary>
        '''     (Set|Get) The sub Lines.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 20h10:108 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The sub Lines.")>
        Public Sub List_Lines()
            Dim M As New Tbl_Entries_Line
            M.Reset()
            With Me
                .Debit = 0
                .Credit = 0
                .Balance = 0
                .Lines = New List(Of Tbl_Entries_Line)
            End With
            For Each Line As Tbl_Entries_Line In M.List()
                If Line.Extourne = False Then
                    If Line.N_Compte = Me.N Then
                        Me.Credit += Line.Credit
                        Me.Debit += Line.Debit
                        Me.Lines.Add(Line)
                    End If
                End If
                Me.Balance = Me.Credit + Me.Debit
            Next

        End Sub
#End Region '(Set|Get) The sub Lines.

#End Region
#Region "<5> [Function]{9}"
#Region "[On] |2019/07/08 18h11:348| <05.00.00> <Function> <> |.Open()|TestItem}|"' (Set|Get) This will initialise the connection and import the data.
        '''    <Summary>
        '''     (Set|Get) This will initialise the connection and import the data.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:967 </Published>
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
                Result.Why += Log & VbNewLine
            End If
            Return Result

        End Function
#End Region '(Set|Get) This will initialise the connection and import the data.

#Region "[On] |2019/07/08 18h11:355| <05.00.01> <Function> <> |.Close()|TestItem}|"' (Set|Get) This willClosing the connection
        '''    <Summary>
        '''     (Set|Get) This willClosing the connection
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:967 </Published>
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

#Region "[On] |2019/07/08 18h11:363| <05.00.02> <Function> <> |.List()|List(Of Tbl_Entries)}|"' (Set|Get) Return the entire table listed
        '''    <Summary>
        '''     (Set|Get) Return the entire table listed
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:969 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Return the entire table listed")>
        Public Function List() As List(Of Tbl_Entries)
            Dim Result As New List(Of Tbl_Entries)
            Me.Table = New Table(Me.TableName, Me.FilePath, Me.Password, False)
            For Each Row As DataRow In Me.Table.DataTable.Rows
                Dim Element As New Tbl_Entries(IIf(IsDBNull(Row.Item(0)), 0, Row.Item(0)),
IIf(IsDBNull(Row.Item(1)), False, Row.Item(1)),
IIf(IsDBNull(Row.Item(2)), "", Row.Item(2)),
IIf(IsDBNull(Row.Item(3)), 0, Row.Item(3)),
IIf(IsDBNull(Row.Item(4)), "", Row.Item(4)),
IIf(IsDBNull(Row.Item(5)), "", Row.Item(5)),
IIf(IsDBNull(Row.Item(6)), 0, Row.Item(6)),
IIf(IsDBNull(Row.Item(7)), "", Row.Item(7)),
IIf(IsDBNull(Row.Item(8)), New DateTime(1970, 1, 1), Row.Item(8)),
IIf(IsDBNull(Row.Item(9)), New DateTime(1970, 1, 1), Row.Item(9)),
IIf(IsDBNull(Row.Item(10)), New DateTime(1970, 1, 1), Row.Item(10)),
IIf(IsDBNull(Row.Item(11)), "", Row.Item(11)),
IIf(IsDBNull(Row.Item(12)), "", Row.Item(12)),
IIf(IsDBNull(Row.Item(13)), 0, Row.Item(13)),
IIf(IsDBNull(Row.Item(14)), 0, Row.Item(14)),
      IIf(IsDBNull(Row.Item(15)), 0, Row.Item(15)))
                Element.Reset(Table.Line)
                Result.Add(Element)
            Next
            Return Result
        End Function
#End Region '(Set|Get) Return the entire table listed

#Region "[On] |2019/07/08 18h11:370| <05.00.03> <Function> <> |.SearchByName()|List(Of Tbl_Entries)}|"' (Set|Get) Search for each property that match the Search String.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search String.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:969 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Search for each property that match the Search String.")>
        Public Shared Function SearchByName(ByVal Search As String) As List(Of Tbl_Entries)
            Dim Result As New List(Of Tbl_Entries)
            Dim C As New Tbl_Entries
            For Each Element As Tbl_Entries In C.List
                If Element.Periode.Tolower() = Search.Tolower() Or Element.PCode.Tolower() = Search.Tolower() Or Element.EntryType.Tolower() = Search.Tolower() Or Element.EntryTypeCode.Tolower() = Search.Tolower() Or Element.Description.Tolower() = Search.Tolower() Or Element.Note.Tolower() = Search.Tolower() Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search String.

#Region "[On] |2019/07/08 18h11:385| <05.00.04> <Function> <> |.SearchByID()|List(Of Tbl_Entries)}|"' (Set|Get) Search for each property that match the Search Id.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search Id.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:969 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Search for each property that match the Search Id.")>
        Public Shared Function SearchByID(ByVal Search As Double) As List(Of Tbl_Entries)
            Dim Result As New List(Of Tbl_Entries)
            Dim C As New Tbl_Entries
            For Each Element As Tbl_Entries In C.List
                If Val(Element.N) = Search Or Val(Element.PeriodeID) = Search Or Val(Element.EntryTypeID) = Search Or Val(Element.Debit) = Search Or Val(Element.Credit) = Search Or Val(Element.Balance) = Search Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search Id.

#Region "[On] |2019/07/08 18h11:392| <05.00.05> <Function> <> |.SearchByDate()|List(Of Tbl_Entries)}|"' (Set|Get) Search for each property that match the Search Id.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search Id.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:969 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Search for each property that match the Search Id.")>
        Public Shared Function SearchByDate(ByVal Search As DateTime) As List(Of Tbl_Entries)
            Dim Result As New List(Of Tbl_Entries)
            Dim C As New Tbl_Entries
            For Each Element As Tbl_Entries In C.List
                If Element.Date_Valeur = Search Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search Id.

#Region "[On] |2019/07/08 18h11:400| <05.00.06> <Function> <> |.SearchByDateRange()|List(Of Tbl_Entries)}|"' (Set|Get) Search for each property that match the Search Id.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search Id.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:970 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>    ''' <param name="From_Date">All element from this date and this date included.</param>
        ''' <param name="Until_Date">All element before and including this date.</param>

        <Browsable(True), Description("(Set|Get) Search for each property that match the Search Id.")>
        Public Shared Function SearchByDateRange(ByVal From_Date As DateTime,
ByVal Until_Date As DateTime) As List(Of Tbl_Entries)
            Dim Result As New List(Of Tbl_Entries)
            Dim C As New Tbl_Entries
            For Each Element As Tbl_Entries In C.List
                If (Element.Date_Valeur) >= From_Date And (Element.Date_Valeur) <= Until_Date Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search Id.

#Region "[On] |2019/07/08 18h11:408| <05.00.07> <Function> <> |.ToString()|String}|"' (Set|Get) The function ToString.
        '''    <Summary>
        '''     (Set|Get) The function ToString.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:970 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The function ToString.")>
        Public Overrides Function ToString() As String
            Return Me.N
        End Function
#End Region '(Set|Get) The function ToString.

#Region "[On] |2019/07/08 18h11:415| <05.00.08> <Function> <> |.CheckConnection()|Boolean}|"' (Set|Get) Evaluate the connection to the DataBase
        '''    <Summary>
        '''     (Set|Get) Evaluate the connection to the DataBase
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:970 </Published>
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
                    Me.Connector = New LineInfo(FilePath, Password)
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
            Log += Message & VbNewLine
            Return General_Status

        End Function
#End Region '(Set|Get) Evaluate the connection to the DataBase

#End Region
#Region "<6> [Runtime]{12}"
#Region "[On] |2019/07/08 18h11:424| <15.00.00> <Runtime> <> |.Table()|Table"' (Set|Get) The Table.
        '''    <Summary>
        '''     (Set|Get) The Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:970 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Table.")>
        Public Table As Table
#End Region '(Set|Get) The Table.

#Region "[On] |2019/07/08 18h11:433| <15.00.01> <Runtime> <> |.Line()|String"' (Set|Get) The Connection String To the Table.
        '''    <Summary>
        '''     (Set|Get) The Connection String To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:975 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Connection String To the Table.")>
        Public Line As String
#End Region '(Set|Get) The Connection String To the Table.

#Region "[On] |2019/07/08 18h11:440| <15.00.02> <Runtime> <> |.FilePath()|String"' (Set|Get) The FilePath To the Table.
        '''    <Summary>
        '''     (Set|Get) The FilePath To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:976 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The FilePath To the Table.")>
        Public FilePath As String
#End Region '(Set|Get) The FilePath To the Table.

#Region "[On] |2019/07/08 18h11:448| <15.00.03> <Runtime> <> |.Password()|String"' (Set|Get) The Password To the Table.
        '''    <Summary>
        '''     (Set|Get) The Password To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:976 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Password To the Table.")>
        Public Password As String
#End Region '(Set|Get) The Password To the Table.

#Region "[On] |2019/07/08 18h11:456| <15.00.04> <Runtime> <> |.UseSQL()|Boolean"' (Set|Get) Determines if the Database Connection is of type SQL.
        '''    <Summary>
        '''     (Set|Get) Determines if the Database Connection is of type SQL.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:976 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Determines if the Database Connection is of type SQL.")>
        Public UseSQL As Boolean
#End Region '(Set|Get) Determines if the Database Connection is of type SQL.

#Region "[On] |2019/07/08 18h11:464| <15.00.05> <Runtime> <> |.TableName()|String"' (Set|Get) The name of the Table.
        '''    <Summary>
        '''     (Set|Get) The name of the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:976 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The name of the Table.")>
        Public TableName As String
#End Region '(Set|Get) The name of the Table.

#Region "[On] |2019/07/08 18h11:471| <15.00.06> <Runtime> <> |.Con()|OleDb.OleDbConnection"' (Set|Get) The Con To the Table.
        '''    <Summary>
        '''     (Set|Get) The Con To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:976 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Con To the Table.")>
        Public Con As OleDb.OleDbConnection
#End Region '(Set|Get) The Con To the Table.

#Region "[On] |2019/07/08 18h11:475| <15.00.07> <Runtime> <> |.Cmd()|OleDb.OleDbCommand"' (Set|Get) The Cmd To the Table.
        '''    <Summary>
        '''     (Set|Get) The Cmd To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:977 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Cmd To the Table.")>
        Public Cmd As OleDb.OleDbCommand
#End Region '(Set|Get) The Cmd To the Table.

#Region "[On] |2019/07/08 18h11:488| <15.00.08> <Runtime> <> |.DataReader()|OleDb.OleDbDataReader"' (Set|Get) The DataReader To the Table.
        '''    <Summary>
        '''     (Set|Get) The DataReader To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:977 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The DataReader To the Table.")>
        Public DataReader As OleDb.OleDbDataReader
#End Region '(Set|Get) The DataReader To the Table.

#Region "[On] |2019/07/08 18h11:496| <15.00.09> <Runtime> <> |.DataAdapter()|OleDb.OleDbDataAdapter"' (Set|Get) The DataAdapter To the Table.
        '''    <Summary>
        '''     (Set|Get) The DataAdapter To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:977 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The DataAdapter To the Table.")>
        Public DataAdapter As OleDb.OleDbDataAdapter
#End Region '(Set|Get) The DataAdapter To the Table.

#Region "[On] |2019/07/08 18h11:504| <15.00.10> <Runtime> <> |.Connector()|LineInfo"' (Set|Get) The Connector To the Table.
        '''    <Summary>
        '''     (Set|Get) The Connector To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:977 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Connector To the Table.")>
        Public Connector As LineInfo
#End Region '(Set|Get) The Connector To the Table.

#Region "[On] |2019/07/08 18h11:512| <15.00.11> <Runtime> <> |.Log()|String"' (Set|Get) The Log To the Table.
        '''    <Summary>
        '''     (Set|Get) The Log To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:977 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Log To the Table.")>
        Public Log As String
#End Region '(Set|Get) The Log To the Table.

#End Region
#Region "<7> [Loader]{2}"
#Region "[On] |2019/07/08 18h11:519| <06.00.00> <Loader> <> |.Empty()|Function}|"' (Set|Get) The sub Empty.
        '''    <Summary>
        '''     (Set|Get) The sub Empty.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:977 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The sub Empty.")>
        Public Sub New()
            Reset
        End Sub
#End Region '(Set|Get) The sub Empty.

#Region "[On] |2019/07/08 18h11:521| <06.00.01> <Loader> <> |.Filled()|Function}|"' (Set|Get) The sub Filled.
        '''    <Summary>
        '''     (Set|Get) The sub Filled.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:982 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>    ''' <param name="N">(Set|Get) The N as Integer.</param>
        ''' <param name="Extourne">(Set|Get) The Extourne as Boolean.</param>
        ''' <param name="Periode">(Set|Get) The Periode as String.</param>
        ''' <param name="PeriodeID">(Set|Get) The PeriodeID as Integer.</param>
        ''' <param name="PCode">(Set|Get) The PCode as String.</param>
        ''' <param name="EntryType">(Set|Get) The EntryType as String.</param>
        ''' <param name="EntryTypeID">(Set|Get) The EntryTypeID as Integer.</param>
        ''' <param name="EntryTypeCode">(Set|Get) The EntryTypeCode as String.</param>
        ''' <param name="Date_Valeur">(Set|Get) The Date_Valeur as DateTime.</param>
        ''' <param name="Date_Echeance">(Set|Get) The Date_Echeance as DateTime.</param>
        ''' <param name="Date_Entry">(Set|Get) The Date_Entry as DateTime.</param>
        ''' <param name="Description">(Set|Get) The Description as String.</param>
        ''' <param name="Note">(Set|Get) The Note as String.</param>
        ''' <param name="Debit">(Set|Get) The Debit as Double.</param>
        ''' <param name="Credit">(Set|Get) The Credit as Double.</param>
        ''' <param name="Balance">(Set|Get) The Balance as Double.</param>

        <Browsable(True), Description("(Set|Get) The sub Filled.")>
        Public Sub New(ByVal N As Integer,
ByVal Extourne As Boolean,
ByVal Periode As String,
ByVal PeriodeID As Integer,
ByVal PCode As String,
ByVal EntryType As String,
ByVal EntryTypeID As Integer,
ByVal EntryTypeCode As String,
ByVal Date_Valeur As DateTime,
ByVal Date_Echeance As DateTime,
ByVal Date_Entry As DateTime,
ByVal Description As String,
ByVal Note As String,
ByVal Debit As Double,
ByVal Credit As Double,
ByVal Balance As Double)
            With Me
                Clear()
                Reset()
                .N = N
                .Extourne = Extourne
                .Periode = Periode
                .PeriodeID = PeriodeID
                .PCode = PCode
                .EntryType = EntryType
                .EntryTypeID = EntryTypeID
                .EntryTypeCode = EntryTypeCode
                .Date_Valeur = Date_Valeur
                .Date_Echeance = Date_Echeance
                .Date_Entry = Date_Entry
                .Description = Description
                .Note = Note
                .Debit = Debit
                .Credit = Credit
                .Balance = Balance
            End With

        End Sub
#End Region '(Set|Get) The sub Filled.

#End Region
    End Class
#End Region

#Region "[On] |2019/07/08 18h11:620| <08.00.00> <Class> <> |.Tbl_Entries_Line|Class|{46} |Production Cost : 61.8|Selling Price : 154.5|"' Class created automatically by SmartOffice (c)Copyright 2019.
    '''    <Summary>
    '''     Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Tbl_Entries_Line
    '''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
    '''    Contributor Information : ||
    '''    Creation Date :           2019/07/08 18h11:620
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
    '''    |Selling Price without VAT   |154.5
    '''    |Total TVA                   |11.9
    '''    |Grand Total                 |166.4
    '''    |/Schema|
    '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
    '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
    '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
    '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:000 </Published>
    '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
    '''    </Summary>
    Public Class Tbl_Entries_Line
#Region "<1> [Property]{17}"
#Region "[On] |2019/07/08 18h11:620| <01.00.00> <Property> <Columns> |.ID()|Integer|"' (Set|Get) The ID as Integer.
        Private _ID As Integer
        '''    <Summary>
        '''     (Set|Get) The ID as Integer.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:000 </Published>
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

#Region "[On] |2019/07/08 18h11:627| <01.00.01> <Property> <Columns> |.EntryID()|Integer|"' (Set|Get) The EntryID as Integer.
        Private _EntryID As Integer
        '''    <Summary>
        '''     (Set|Get) The EntryID as Integer.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:000 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The EntryID as Integer.")>
        Public Property EntryID() As Integer
            Get
                Return _EntryID
            End Get
            Set(ByVal Value As Integer)
                _EntryID = Value
            End Set
        End Property
#End Region '(Set|Get) The EntryID as Integer.

#Region "[On] |2019/07/08 18h11:632| <01.00.02> <Property> <Columns> |.Extourne()|Boolean|"' (Set|Get) The Extourne as Boolean.
        Private _Extourne As Boolean
        '''    <Summary>
        '''     (Set|Get) The Extourne as Boolean.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:001 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Extourne as Boolean.")>
        Public Property Extourne() As Boolean
            Get
                Return _Extourne
            End Get
            Set(ByVal Value As Boolean)
                _Extourne = Value
            End Set
        End Property
#End Region '(Set|Get) The Extourne as Boolean.

#Region "[On] |2019/07/08 18h11:639| <01.00.03> <Property> <Columns> |.PeriodeCode()|String|"' (Set|Get) The PeriodeCode as String.
        Private _PeriodeCode As String
        '''    <Summary>
        '''     (Set|Get) The PeriodeCode as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:001 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The PeriodeCode as String.")>
        Public Property PeriodeCode() As String
            Get
                Return _PeriodeCode
            End Get
            Set(ByVal Value As String)
                _PeriodeCode = Value
            End Set
        End Property
#End Region '(Set|Get) The PeriodeCode as String.

#Region "[On] |2019/07/08 18h11:644| <01.00.04> <Property> <Columns> |.EntryTypeCode()|String|"' (Set|Get) The EntryTypeCode as String.
        Private _EntryTypeCode As String
        '''    <Summary>
        '''     (Set|Get) The EntryTypeCode as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:001 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The EntryTypeCode as String.")>
        Public Property EntryTypeCode() As String
            Get
                Return _EntryTypeCode
            End Get
            Set(ByVal Value As String)
                _EntryTypeCode = Value
            End Set
        End Property
#End Region '(Set|Get) The EntryTypeCode as String.

#Region "[On] |2019/07/08 18h11:650| <01.00.05> <Property> <Columns> |.Date_Valeur()|DateTime|"' (Set|Get) The Date_Valeur as DateTime.
        Private _Date_Valeur As DateTime
        '''    <Summary>
        '''     (Set|Get) The Date_Valeur as DateTime.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:001 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Date_Valeur as DateTime.")>
        Public Property Date_Valeur() As DateTime
            Get
                Return _Date_Valeur
            End Get
            Set(ByVal Value As DateTime)
                _Date_Valeur = Value
            End Set
        End Property
#End Region '(Set|Get) The Date_Valeur as DateTime.

#Region "[On] |2019/07/08 18h11:658| <01.00.06> <Property> <Columns> |.Date_Echeance()|DateTime|"' (Set|Get) The Date_Echeance as DateTime.
        Private _Date_Echeance As DateTime
        '''    <Summary>
        '''     (Set|Get) The Date_Echeance as DateTime.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:001 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Date_Echeance as DateTime.")>
        Public Property Date_Echeance() As DateTime
            Get
                Return _Date_Echeance
            End Get
            Set(ByVal Value As DateTime)
                _Date_Echeance = Value
            End Set
        End Property
#End Region '(Set|Get) The Date_Echeance as DateTime.

#Region "[On] |2019/07/08 18h11:664| <01.00.07> <Property> <Columns> |.Date_Entry()|DateTime|"' (Set|Get) The Date_Entry as DateTime.
        Private _Date_Entry As DateTime
        '''    <Summary>
        '''     (Set|Get) The Date_Entry as DateTime.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:004 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Date_Entry as DateTime.")>
        Public Property Date_Entry() As DateTime
            Get
                Return _Date_Entry
            End Get
            Set(ByVal Value As DateTime)
                _Date_Entry = Value
            End Set
        End Property
#End Region '(Set|Get) The Date_Entry as DateTime.

#Region "[On] |2019/07/08 18h11:670| <01.00.08> <Property> <Columns> |.Description()|String|"' (Set|Get) The Description as String.
        Private _Description As String
        '''    <Summary>
        '''     (Set|Get) The Description as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:004 </Published>
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

#Region "[On] |2019/07/08 18h11:677| <01.00.09> <Property> <Columns> |.N_Compte()|Integer|"' (Set|Get) The N_Compte as Integer.
        Private _N_Compte As Integer
        '''    <Summary>
        '''     (Set|Get) The N_Compte as Integer.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:004 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The N_Compte as Integer.")>
        Public Property N_Compte() As Integer
            Get
                Return _N_Compte
            End Get
            Set(ByVal Value As Integer)
                _N_Compte = Value
            End Set
        End Property
#End Region '(Set|Get) The N_Compte as Integer.

#Region "[On] |2019/07/08 18h11:682| <01.00.10> <Property> <Columns> |.Debit_Raw()|Double|"' (Set|Get) The Debit_Raw as Double.
        Private _Debit_Raw As Double
        '''    <Summary>
        '''     (Set|Get) The Debit_Raw as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:004 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Debit_Raw as Double.")>
        Public Property Debit_Raw() As Double
            Get
                Return _Debit_Raw
            End Get
            Set(ByVal Value As Double)
                _Debit_Raw = Value
            End Set
        End Property
#End Region '(Set|Get) The Debit_Raw as Double.

#Region "[On] |2019/07/08 18h11:692| <01.00.11> <Property> <Columns> |.Credit_Raw()|Double|"' (Set|Get) The Credit_Raw as Double.
        Private _Credit_Raw As Double
        '''    <Summary>
        '''     (Set|Get) The Credit_Raw as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:005 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Credit_Raw as Double.")>
        Public Property Credit_Raw() As Double
            Get
                Return _Credit_Raw
            End Get
            Set(ByVal Value As Double)
                _Credit_Raw = Value
            End Set
        End Property
#End Region '(Set|Get) The Credit_Raw as Double.

#Region "[On] |2019/07/08 18h11:698| <01.00.12> <Property> <Columns> |.Currency()|String|"' (Set|Get) The Currency as String.
        Private _Currency As String
        '''    <Summary>
        '''     (Set|Get) The Currency as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:005 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Currency as String.")>
        Public Property Currency() As String
            Get
                Return _Currency
            End Get
            Set(ByVal Value As String)
                _Currency = Value
            End Set
        End Property
#End Region '(Set|Get) The Currency as String.

#Region "[On] |2019/07/08 18h11:705| <01.00.13> <Property> <Columns> |.Currency_Ratio()|Double|"' (Set|Get) The Currency_Ratio as Double.
        Private _Currency_Ratio As Double
        '''    <Summary>
        '''     (Set|Get) The Currency_Ratio as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:005 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Currency_Ratio as Double.")>
        Public Property Currency_Ratio() As Double
            Get
                Return _Currency_Ratio
            End Get
            Set(ByVal Value As Double)
                _Currency_Ratio = Value
            End Set
        End Property
#End Region '(Set|Get) The Currency_Ratio as Double.

#Region "[On] |2019/07/08 18h11:711| <01.00.14> <Property> <Columns> |.Account()|String|"' (Set|Get) The Account as String.
        Private _Account As String
        '''    <Summary>
        '''     (Set|Get) The Account as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:005 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Account as String.")>
        Public Property Account() As String
            Get
                Return _Account
            End Get
            Set(ByVal Value As String)
                _Account = Value
            End Set
        End Property
#End Region '(Set|Get) The Account as String.

#Region "[On] |2019/07/08 18h11:717| <01.00.15> <Property> <Columns> |.Debit()|Double|"' (Set|Get) The Debit as Double.
        Private _Debit As Double
        '''    <Summary>
        '''     (Set|Get) The Debit as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:008 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Debit as Double.")>
        Public Property Debit() As Double
            Get
                Return _Debit
            End Get
            Set(ByVal Value As Double)
                _Debit = Value
            End Set
        End Property
#End Region '(Set|Get) The Debit as Double.

#Region "[On] |2019/07/08 18h11:724| <01.00.16> <Property> <Columns> |.Credit()|Double|"' (Set|Get) The Credit as Double.
        Private _Credit As Double
        '''    <Summary>
        '''     (Set|Get) The Credit as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:008 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Credit as Double.")>
        Public Property Credit() As Double
            Get
                Return _Credit
            End Get
            Set(ByVal Value As Double)
                _Credit = Value
            End Set
        End Property
#End Region '(Set|Get) The Credit as Double.

#End Region
#Region "<2> [Enumeration]{1}"
#Region "[On] |2019/07/08 18h11:730| <02.00.00> <Enumeration> <> |.Schema()|Enumeration{16}|"' (Set|Get) The enumeration of Schema.
        '''    <Summary>
        '''     (Set|Get) The enumeration of Schema.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:008 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The enumeration of Schema.")>
        Enum Schema
            ''' <summary>(Set|Get) The ID as Integer.</summary>
            [ID] = 0
            ''' <summary>(Set|Get) The EntryID as Integer.</summary>
            [EntryID] = 1
            ''' <summary>(Set|Get) The Extourne as Boolean.</summary>
            [Extourne] = 2
            ''' <summary>(Set|Get) The PeriodeCode as String.</summary>
            [PeriodeCode] = 3
            ''' <summary>(Set|Get) The EntryTypeCode as String.</summary>
            [EntryTypeCode] = 4
            ''' <summary>(Set|Get) The Date_Valeur as DateTime.</summary>
            [Date_Valeur] = 5
            ''' <summary>(Set|Get) The Date_Echeance as DateTime.</summary>
            [Date_Echeance] = 6
            ''' <summary>(Set|Get) The Date_Entry as DateTime.</summary>
            [Date_Entry] = 7
            ''' <summary>(Set|Get) The Description as String.</summary>
            [Description] = 8
            ''' <summary>(Set|Get) The N_Compte as Integer.</summary>
            [N_Compte] = 9
            ''' <summary>(Set|Get) The Debit_Raw as Double.</summary>
            [Debit_Raw] = 10
            ''' <summary>(Set|Get) The Credit_Raw as Double.</summary>
            [Credit_Raw] = 11
            ''' <summary>(Set|Get) The Currency as String.</summary>
            [Currency] = 12
            ''' <summary>(Set|Get) The Currency_Ratio as Double.</summary>
            [Currency_Ratio] = 13
            ''' <summary>(Set|Get) The Account as String.</summary>
            [Account] = 14
            ''' <summary>(Set|Get) The Debit as Double.</summary>
            [Debit] = 15
            ''' <summary>(Set|Get) The Credit as Double.</summary>
            [Credit] = 16
        End Enum
#End Region '(Set|Get) The enumeration of Schema.

#End Region
#Region "<4> [Sub]{5}"
#Region "[On] |2019/07/08 18h11:738| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
        '''    <Summary>
        '''     (Set|Get) This will reinitialize the class element.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:008 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will reinitialize the class element.")>
        Public Sub Clear()
            With Me
                .ID = 0
                .EntryID = 0
                .Extourne = False
                .PeriodeCode = Nothing
                .EntryTypeCode = Nothing
                .Date_Valeur = New DateTime
                .Date_Echeance = New DateTime
                .Date_Entry = New DateTime
                .Description = Nothing
                .N_Compte = 0
                .Debit_Raw = 0
                .Credit_Raw = 0
                .Currency = Nothing
                .Currency_Ratio = 0
                .Account = Nothing
                .Debit = 0
                .Credit = 0
            End With
        End Sub
#End Region '(Set|Get) This will reinitialize the class element.

#Region "[On] |2019/07/08 18h11:745| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
        '''    <Summary>
        '''     (Set|Get) This will reinitialize the variables of this class.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:009 </Published>
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
                    TableName = "Tbl_Entries_Line"
                    Line = Connector.Line
                    UseSQL = False
                Else
                    FilePath = My.Settings.Db_Accountis_FilePath
                    Password = My.Settings.Db_Accountis_Password
                    Me.Line = My.Settings.Db_Accountis_Line
                    TableName = "Tbl_Entries_Line"
                    UseSQL = False
                End If
            Else
                If IsNothing(FilePath) Then
                    FilePath = My.Settings.Db_Accountis_FilePath
                End If
                If FilePath.Length < 1 Then
                    FilePath = My.Settings.Db_Accountis_FilePath
                End If
                FilePath = My.Settings.Db_Accountis_FilePath
                Password = My.Settings.Db_Accountis_Password
                Me.Line = My.Settings.Db_Accountis_Line
                TableName = "Tbl_Entries_Line"
                UseSQL = False
            End If

        End Sub
#End Region '(Set|Get) This will reinitialize the variables of this class.

#Region "[On] |2019/07/08 18h11:751| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
        '''    <Summary>
        '''     (Set|Get) This will add a new row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:014 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will add a new row in the table.")>
        Public Sub Add()
            Try
                Dim Str As String = Nothing
                Str = "Insert Into [Tbl_Entries_Line] (
`ID`, 
`EntryID`, 
`Extourne`, 
`PeriodeCode`, 
`EntryTypeCode`, 
`Date_Valeur`, 
`Date_Echeance`, 
`Date_Entry`, 
`Description`, 
`N_Compte`, 
`Debit_Raw`, 
`Credit_Raw`, 
`Currency`, 
`Currency_Ratio`, 
`Account`, 
`Debit`, 
`Credit`) Values (@0, @1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16)"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@0", Me.ID)
                Cmd.Parameters.AddWithValue("@1", Me.EntryID)
                Cmd.Parameters.AddWithValue("@2", Me.Extourne)
                Cmd.Parameters.AddWithValue("@3", Me.PeriodeCode)
                Cmd.Parameters.AddWithValue("@4", Me.EntryTypeCode)
                Cmd.Parameters.AddWithValue("@5", Me.Date_Valeur)
                Cmd.Parameters.AddWithValue("@6", Me.Date_Echeance)
                Cmd.Parameters.AddWithValue("@7", Me.Date_Entry)
                Cmd.Parameters.AddWithValue("@8", Me.Description)
                Cmd.Parameters.AddWithValue("@9", Me.N_Compte)
                Cmd.Parameters.AddWithValue("@10", Me.Debit_Raw)
                Cmd.Parameters.AddWithValue("@11", Me.Credit_Raw)
                Cmd.Parameters.AddWithValue("@12", Me.Currency)
                Cmd.Parameters.AddWithValue("@13", Me.Currency_Ratio)
                Cmd.Parameters.AddWithValue("@14", Me.Account)
                Cmd.Parameters.AddWithValue("@15", Me.Debit)
                Cmd.Parameters.AddWithValue("@16", Me.Credit)
                If Cmd.ExecuteNonQuery >= 0 Then
                Else
                    Msgbox("Element not Addd")
                End If
            Catch ex As Exception
            Finally
                Close(True)
            End Try

        End Sub
#End Region '(Set|Get) This will add a new row in the table.

#Region "[On] |2019/07/08 18h11:758| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
        '''    <Summary>
        '''     (Set|Get) This will update a row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:017 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will update a row in the table.")>
        Public Sub Save()
            Try
                Dim Str As String = Nothing
                Str = "UPDATE [Tbl_Entries_Line] SET EntryID = @EntryID, Extourne = @Extourne, PeriodeCode = @PeriodeCode, EntryTypeCode = @EntryTypeCode, Date_Valeur = @Date_Valeur, Date_Echeance = @Date_Echeance, Date_Entry = @Date_Entry, Description = @Description, N_Compte = @N_Compte, Debit_Raw = @Debit_Raw, Credit_Raw = @Credit_Raw, Currency = @Currency, Currency_Ratio = @Currency_Ratio, Account = @Account, Debit = @Debit, Credit = @Credit WHERE ID = @ID"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@EntryID", EntryID)
                Cmd.Parameters.AddWithValue("@Extourne", Extourne)
                Cmd.Parameters.AddWithValue("@PeriodeCode", PeriodeCode)
                Cmd.Parameters.AddWithValue("@EntryTypeCode", EntryTypeCode)
                Cmd.Parameters.AddWithValue("@Date_Valeur", Date_Valeur)
                Cmd.Parameters.AddWithValue("@Date_Echeance", Date_Echeance)
                Cmd.Parameters.AddWithValue("@Date_Entry", Date_Entry)
                Cmd.Parameters.AddWithValue("@Description", Description)
                Cmd.Parameters.AddWithValue("@N_Compte", N_Compte)
                Cmd.Parameters.AddWithValue("@Debit_Raw", Debit_Raw)
                Cmd.Parameters.AddWithValue("@Credit_Raw", Credit_Raw)
                Cmd.Parameters.AddWithValue("@Currency", Currency)
                Cmd.Parameters.AddWithValue("@Currency_Ratio", Currency_Ratio)
                Cmd.Parameters.AddWithValue("@Account", Account)
                Cmd.Parameters.AddWithValue("@Debit", Debit)
                Cmd.Parameters.AddWithValue("@Credit", Credit)
                Cmd.Parameters.AddWithValue("@ID", ID)
                If Cmd.ExecuteNonQuery >= 0 Then
                Else
                    Msgbox("Element not Saved")
                End If
            Catch ex As Exception
            Finally
                Close(True)
            End Try

        End Sub
#End Region '(Set|Get) This will update a row in the table.

#Region "[On] |2019/07/08 18h11:765| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
        '''    <Summary>
        '''     (Set|Get) This will Delete a row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:017 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will Delete a row in the table.")>
        Public Sub Delete()
            Try
                Dim Str As String = Nothing
                Str = "Delete From [Tbl_Entries_Line] WHERE ID =@ID"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@ID", ID)
                If Cmd.ExecuteNonQuery >= 0 Then
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
#Region "<5> [Function]{9}"
#Region "[On] |2019/07/08 18h11:772| <05.00.00> <Function> <> |.Open()|TestItem}|"' (Set|Get) This will initialise the connection and import the data.
        '''    <Summary>
        '''     (Set|Get) This will initialise the connection and import the data.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:017 </Published>
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
                Result.Why += Log & VbNewLine
            End If
            Return Result

        End Function
#End Region '(Set|Get) This will initialise the connection and import the data.

#Region "[On] |2019/07/08 18h11:779| <05.00.01> <Function> <> |.Close()|TestItem}|"' (Set|Get) This willClosing the connection
        '''    <Summary>
        '''     (Set|Get) This willClosing the connection
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:017 </Published>
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

#Region "[On] |2019/07/08 18h11:787| <05.00.02> <Function> <> |.List()|List(Of Tbl_Entries_Line)}|"' (Set|Get) Return the entire table listed
        '''    <Summary>
        '''     (Set|Get) Return the entire table listed
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:017 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Return the entire table listed")>
        Public Function List() As List(Of Tbl_Entries_Line)
            Dim Result As New List(Of Tbl_Entries_Line)
            Me.Table = New Table(Me.TableName, Me.FilePath, Me.Password, False)
            For Each Row As DataRow In Me.Table.DataTable.Rows
                Dim Element As New Tbl_Entries_Line(IIf(IsDBNull(Row.Item(0)), 0, Row.Item(0)),
IIf(IsDBNull(Row.Item(1)), 0, Row.Item(1)),
IIf(IsDBNull(Row.Item(2)), False, Row.Item(2)),
IIf(IsDBNull(Row.Item(3)), "", Row.Item(3)),
IIf(IsDBNull(Row.Item(4)), "", Row.Item(4)),
IIf(IsDBNull(Row.Item(5)), New DateTime(1970, 1, 1), Row.Item(5)),
IIf(IsDBNull(Row.Item(6)), New DateTime(1970, 1, 1), Row.Item(6)),
IIf(IsDBNull(Row.Item(7)), New DateTime(1970, 1, 1), Row.Item(7)),
IIf(IsDBNull(Row.Item(8)), "", Row.Item(8)),
IIf(IsDBNull(Row.Item(9)), 0, Row.Item(9)),
IIf(IsDBNull(Row.Item(10)), 0, Row.Item(10)),
IIf(IsDBNull(Row.Item(11)), 0, Row.Item(11)),
IIf(IsDBNull(Row.Item(12)), "", Row.Item(12)),
IIf(IsDBNull(Row.Item(13)), 0, Row.Item(13)),
IIf(IsDBNull(Row.Item(14)), "", Row.Item(14)),
IIf(IsDBNull(Row.Item(15)), 0, Row.Item(15)),
      IIf(IsDBNull(Row.Item(16)), 0, Row.Item(16)))
                Element.Reset(Table.Line)
                Result.Add(Element)
            Next
            Return Result
        End Function
#End Region '(Set|Get) Return the entire table listed

#Region "[On] |2019/07/08 18h11:800| <05.00.03> <Function> <> |.SearchByName()|List(Of Tbl_Entries_Line)}|"' (Set|Get) Search for each property that match the Search String.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search String.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:017 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Search for each property that match the Search String.")>
        Public Shared Function SearchByName(ByVal Search As String) As List(Of Tbl_Entries_Line)
            Dim Result As New List(Of Tbl_Entries_Line)
            Dim C As New Tbl_Entries_Line
            For Each Element As Tbl_Entries_Line In C.List
                If Element.PeriodeCode.Tolower() = Search.Tolower() Or Element.EntryTypeCode.Tolower() = Search.Tolower() Or Element.Description.Tolower() = Search.Tolower() Or Element.Currency.Tolower() = Search.Tolower() Or Element.Account.Tolower() = Search.Tolower() Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search String.

#Region "[On] |2019/07/08 18h11:807| <05.00.04> <Function> <> |.SearchByID()|List(Of Tbl_Entries_Line)}|"' (Set|Get) Search for each property that match the Search Id.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search Id.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:018 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Search for each property that match the Search Id.")>
        Public Shared Function SearchByID(ByVal Search As Double) As List(Of Tbl_Entries_Line)
            Dim Result As New List(Of Tbl_Entries_Line)
            Dim C As New Tbl_Entries_Line
            For Each Element As Tbl_Entries_Line In C.List
                If Val(Element.ID) = Search Or Val(Element.EntryID) = Search Or Val(Element.N_Compte) = Search Or Val(Element.Debit_Raw) = Search Or Val(Element.Credit_Raw) = Search Or Val(Element.Currency_Ratio) = Search Or Val(Element.Debit) = Search Or Val(Element.Credit) = Search Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search Id.

#Region "[On] |2019/07/08 18h11:814| <05.00.05> <Function> <> |.SearchByDate()|List(Of Tbl_Entries_Line)}|"' (Set|Get) Search for each property that match the Search Id.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search Id.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:018 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Search for each property that match the Search Id.")>
        Public Shared Function SearchByDate(ByVal Search As DateTime) As List(Of Tbl_Entries_Line)
            Dim Result As New List(Of Tbl_Entries_Line)
            Dim C As New Tbl_Entries_Line
            For Each Element As Tbl_Entries_Line In C.List
                If Element.Date_Valeur = Search Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search Id.

#Region "[On] |2019/07/08 18h11:822| <05.00.06> <Function> <> |.SearchByDateRange()|List(Of Tbl_Entries_Line)}|"' (Set|Get) Search for each property that match the Search Id.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search Id.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:018 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>    ''' <param name="From_Date">All element from this date and this date included.</param>
        ''' <param name="Until_Date">All element before and including this date.</param>

        <Browsable(True), Description("(Set|Get) Search for each property that match the Search Id.")>
        Public Shared Function SearchByDateRange(ByVal From_Date As DateTime,
ByVal Until_Date As DateTime) As List(Of Tbl_Entries_Line)
            Dim Result As New List(Of Tbl_Entries_Line)
            Dim C As New Tbl_Entries_Line
            For Each Element As Tbl_Entries_Line In C.List
                If (Element.Date_Valeur) >= From_Date And (Element.Date_Valeur) <= Until_Date Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search Id.

#Region "[On] |2019/07/08 18h11:829| <05.00.07> <Function> <> |.ToString()|String}|"' (Set|Get) The function ToString.
        '''    <Summary>
        '''     (Set|Get) The function ToString.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:018 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The function ToString.")>
        Public Overrides Function ToString() As String
            Return Me.ID
        End Function
#End Region '(Set|Get) The function ToString.

#Region "[On] |2019/07/08 18h11:837| <05.00.08> <Function> <> |.CheckConnection()|Boolean}|"' (Set|Get) Evaluate the connection to the DataBase
        '''    <Summary>
        '''     (Set|Get) Evaluate the connection to the DataBase
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:021 </Published>
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
                    Me.Connector = New LineInfo(FilePath, Password)
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
            Log += Message & VbNewLine
            Return General_Status

        End Function
#End Region '(Set|Get) Evaluate the connection to the DataBase

#End Region
#Region "<6> [Runtime]{12}"
#Region "[On] |2019/07/08 18h11:844| <15.00.00> <Runtime> <> |.Table()|Table"' (Set|Get) The Table.
        '''    <Summary>
        '''     (Set|Get) The Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:021 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Table.")>
        Public Table As Table
#End Region '(Set|Get) The Table.

#Region "[On] |2019/07/08 18h11:852| <15.00.01> <Runtime> <> |.Line()|String"' (Set|Get) The Connection String To the Table.
        '''    <Summary>
        '''     (Set|Get) The Connection String To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:021 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Connection String To the Table.")>
        Public Line As String
#End Region '(Set|Get) The Connection String To the Table.

#Region "[On] |2019/07/08 18h11:860| <15.00.02> <Runtime> <> |.FilePath()|String"' (Set|Get) The FilePath To the Table.
        '''    <Summary>
        '''     (Set|Get) The FilePath To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:021 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The FilePath To the Table.")>
        Public FilePath As String
#End Region '(Set|Get) The FilePath To the Table.

#Region "[On] |2019/07/08 18h11:867| <15.00.03> <Runtime> <> |.Password()|String"' (Set|Get) The Password To the Table.
        '''    <Summary>
        '''     (Set|Get) The Password To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:022 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Password To the Table.")>
        Public Password As String
#End Region '(Set|Get) The Password To the Table.

#Region "[On] |2019/07/08 18h11:875| <15.00.04> <Runtime> <> |.UseSQL()|Boolean"' (Set|Get) Determines if the Database Connection is of type SQL.
        '''    <Summary>
        '''     (Set|Get) Determines if the Database Connection is of type SQL.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:022 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Determines if the Database Connection is of type SQL.")>
        Public UseSQL As Boolean
#End Region '(Set|Get) Determines if the Database Connection is of type SQL.

#Region "[On] |2019/07/08 18h11:882| <15.00.05> <Runtime> <> |.TableName()|String"' (Set|Get) The name of the Table.
        '''    <Summary>
        '''     (Set|Get) The name of the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:022 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The name of the Table.")>
        Public TableName As String
#End Region '(Set|Get) The name of the Table.

#Region "[On] |2019/07/08 18h11:890| <15.00.06> <Runtime> <> |.Con()|OleDb.OleDbConnection"' (Set|Get) The Con To the Table.
        '''    <Summary>
        '''     (Set|Get) The Con To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:022 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Con To the Table.")>
        Public Con As OleDb.OleDbConnection
#End Region '(Set|Get) The Con To the Table.

#Region "[On] |2019/07/08 18h11:904| <15.00.07> <Runtime> <> |.Cmd()|OleDb.OleDbCommand"' (Set|Get) The Cmd To the Table.
        '''    <Summary>
        '''     (Set|Get) The Cmd To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:022 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Cmd To the Table.")>
        Public Cmd As OleDb.OleDbCommand
#End Region '(Set|Get) The Cmd To the Table.

#Region "[On] |2019/07/08 18h11:912| <15.00.08> <Runtime> <> |.DataReader()|OleDb.OleDbDataReader"' (Set|Get) The DataReader To the Table.
        '''    <Summary>
        '''     (Set|Get) The DataReader To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:022 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The DataReader To the Table.")>
        Public DataReader As OleDb.OleDbDataReader
#End Region '(Set|Get) The DataReader To the Table.

#Region "[On] |2019/07/08 18h11:919| <15.00.09> <Runtime> <> |.DataAdapter()|OleDb.OleDbDataAdapter"' (Set|Get) The DataAdapter To the Table.
        '''    <Summary>
        '''     (Set|Get) The DataAdapter To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:023 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The DataAdapter To the Table.")>
        Public DataAdapter As OleDb.OleDbDataAdapter
#End Region '(Set|Get) The DataAdapter To the Table.

#Region "[On] |2019/07/08 18h11:927| <15.00.10> <Runtime> <> |.Connector()|LineInfo"' (Set|Get) The Connector To the Table.
        '''    <Summary>
        '''     (Set|Get) The Connector To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:023 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Connector To the Table.")>
        Public Connector As LineInfo
#End Region '(Set|Get) The Connector To the Table.

#Region "[On] |2019/07/08 18h11:935| <15.00.11> <Runtime> <> |.Log()|String"' (Set|Get) The Log To the Table.
        '''    <Summary>
        '''     (Set|Get) The Log To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:023 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Log To the Table.")>
        Public Log As String
#End Region '(Set|Get) The Log To the Table.

#End Region
#Region "<7> [Loader]{2}"
#Region "[On] |2019/07/08 18h11:943| <06.00.00> <Loader> <> |.Empty()|Function}|"' (Set|Get) The sub Empty.
        '''    <Summary>
        '''     (Set|Get) The sub Empty.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:023 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The sub Empty.")>
        Public Sub New()
            Reset
        End Sub
#End Region '(Set|Get) The sub Empty.

#Region "[On] |2019/07/08 18h11:944| <06.00.01> <Loader> <> |.Filled()|Function}|"' (Set|Get) The sub Filled.
        '''    <Summary>
        '''     (Set|Get) The sub Filled.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:023 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>    ''' <param name="ID">(Set|Get) The ID as Integer.</param>
        ''' <param name="EntryID">(Set|Get) The EntryID as Integer.</param>
        ''' <param name="Extourne">(Set|Get) The Extourne as Boolean.</param>
        ''' <param name="PeriodeCode">(Set|Get) The PeriodeCode as String.</param>
        ''' <param name="EntryTypeCode">(Set|Get) The EntryTypeCode as String.</param>
        ''' <param name="Date_Valeur">(Set|Get) The Date_Valeur as DateTime.</param>
        ''' <param name="Date_Echeance">(Set|Get) The Date_Echeance as DateTime.</param>
        ''' <param name="Date_Entry">(Set|Get) The Date_Entry as DateTime.</param>
        ''' <param name="Description">(Set|Get) The Description as String.</param>
        ''' <param name="N_Compte">(Set|Get) The N_Compte as Integer.</param>
        ''' <param name="Debit_Raw">(Set|Get) The Debit_Raw as Double.</param>
        ''' <param name="Credit_Raw">(Set|Get) The Credit_Raw as Double.</param>
        ''' <param name="Currency">(Set|Get) The Currency as String.</param>
        ''' <param name="Currency_Ratio">(Set|Get) The Currency_Ratio as Double.</param>
        ''' <param name="Account">(Set|Get) The Account as String.</param>
        ''' <param name="Debit">(Set|Get) The Debit as Double.</param>
        ''' <param name="Credit">(Set|Get) The Credit as Double.</param>

        <Browsable(True), Description("(Set|Get) The sub Filled.")>
        Public Sub New(ByVal ID As Integer,
ByVal EntryID As Integer,
ByVal Extourne As Boolean,
ByVal PeriodeCode As String,
ByVal EntryTypeCode As String,
ByVal Date_Valeur As DateTime,
ByVal Date_Echeance As DateTime,
ByVal Date_Entry As DateTime,
ByVal Description As String,
ByVal N_Compte As Integer,
ByVal Debit_Raw As Double,
ByVal Credit_Raw As Double,
ByVal Currency As String,
ByVal Currency_Ratio As Double,
ByVal Account As String,
ByVal Debit As Double,
ByVal Credit As Double)
            With Me
                Clear()
                Reset()
                .ID = ID
                .EntryID = EntryID
                .Extourne = Extourne
                .PeriodeCode = PeriodeCode
                .EntryTypeCode = EntryTypeCode
                .Date_Valeur = Date_Valeur
                .Date_Echeance = Date_Echeance
                .Date_Entry = Date_Entry
                .Description = Description
                .N_Compte = N_Compte
                .Debit_Raw = Debit_Raw
                .Credit_Raw = Credit_Raw
                .Currency = Currency
                .Currency_Ratio = Currency_Ratio
                .Account = Account
                .Debit = Debit
                .Credit = Credit
            End With

        End Sub
#End Region '(Set|Get) The sub Filled.

#End Region
    End Class
#End Region

#Region "[On] |2019/07/08 18h11:075| <08.00.00> <Class> <> |.Tbl_Group|Class|{42} |Production Cost : 53.5|Selling Price : 133.75|"' Class created automatically by SmartOffice (c)Copyright 2019.
    '''    <Summary>
    '''     Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Tbl_Group
    '''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
    '''    Contributor Information : ||
    '''    Creation Date :           2019/07/08 18h11:075
    '''    |Schema|
    '''    |ID| |ObjectType |{Quantity}||UnitPrice||Total
    '''    |00| |Importation|{0}||1| |0
    '''    |01| |Properties |{15}||0.8| |12
    '''    |02| |Enumeration|{1}||0.4| |0.4
    '''    |03| |Structure  |{0}||0.4| |0
    '''    |04| |Sub        |{5}||1.2| |6
    '''    |05| |Function   |{7}||1.6| |11.2
    '''    |06| |Runtime    |{12}||0.4| |4.8
    '''    |07| |Loader     |{2}||0.8| |1.6
    '''    |08| |Class      |{0}||2| |0
    '''    |09| |Constante  |{0}||0.4| |0
    '''    |10| |Event      |{0}||1.2| |0
    '''    |11| |Members    |{15}||0.5| |7.5
    '''    |12| |Parameter  |{20}||0.5| |10
    '''    |Production Cost             |53.5
    '''    |Selling Price without VAT   |133.75
    '''    |Total TVA                   |10.3
    '''    |Grand Total                 |144.05
    '''    |/Schema|
    '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
    '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
    '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
    '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:047 </Published>
    '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
    '''    </Summary>
    Public Class Tbl_Group
#Region "<1> [Property]{15}"
#Region "[On] |2019/07/08 18h11:076| <01.00.00> <Property> <Columns> |.ID()|Integer|"' (Set|Get) The ID as Integer.
        Private _ID As Integer
        '''    <Summary>
        '''     (Set|Get) The ID as Integer.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:047 </Published>
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

#Region "[On] |2019/07/08 18h11:082| <01.00.01> <Property> <Columns> |.Name()|String|"' (Set|Get) The Name as String.
        Private _Name As String
        '''    <Summary>
        '''     (Set|Get) The Name as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:047 </Published>
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

#Region "[On] |2019/07/08 18h11:089| <01.00.02> <Property> <Columns> |.Opening()|Double|"' (Set|Get) The Opening as Double.
        Private _Opening As Double
        '''    <Summary>
        '''     (Set|Get) The Opening as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:047 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Opening as Double.")>
        Public Property Opening() As Double
            Get
                Return _Opening
            End Get
            Set(ByVal Value As Double)
                _Opening = Value
            End Set
        End Property
#End Region '(Set|Get) The Opening as Double.

#Region "[On] |2019/07/08 18h11:098| <01.00.03> <Property> <Columns> |.Debit()|Double|"' (Set|Get) The Debit as Double.
        Private _Debit As Double
        '''    <Summary>
        '''     (Set|Get) The Debit as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:048 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Debit as Double.")>
        Public Property Debit() As Double
            Get
                Return _Debit
            End Get
            Set(ByVal Value As Double)
                _Debit = Value
            End Set
        End Property
#End Region '(Set|Get) The Debit as Double.

#Region "[On] |2019/07/08 18h11:104| <01.00.04> <Property> <Columns> |.Credit()|Double|"' (Set|Get) The Credit as Double.
        Private _Credit As Double
        '''    <Summary>
        '''     (Set|Get) The Credit as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:048 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Credit as Double.")>
        Public Property Credit() As Double
            Get
                Return _Credit
            End Get
            Set(ByVal Value As Double)
                _Credit = Value
            End Set
        End Property
#End Region '(Set|Get) The Credit as Double.

#Region "[On] |2019/07/08 18h11:110| <01.00.05> <Property> <Columns> |.Balance()|Double|"' (Set|Get) The Balance as Double.
        Private _Balance As Double
        '''    <Summary>
        '''     (Set|Get) The Balance as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:051 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Balance as Double.")>
        Public Property Balance() As Double
            Get
                Return _Balance
            End Get
            Set(ByVal Value As Double)
                _Balance = Value
            End Set
        End Property
#End Region '(Set|Get) The Balance as Double.

#Region "[On] |2019/07/08 18h11:118| <01.00.06> <Property> <Columns> |.Closing()|Integer|"' (Set|Get) The Closing as Integer.
        Private _Closing As Integer
        '''    <Summary>
        '''     (Set|Get) The Closing as Integer.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:051 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Closing as Integer.")>
        Public Property Closing() As Integer
            Get
                Return _Closing
            End Get
            Set(ByVal Value As Integer)
                _Closing = Value
            End Set
        End Property
#End Region '(Set|Get) The Closing as Integer.

#Region "[On] |2019/07/08 18h11:131| <01.00.07> <Property> <Columns> |.Variation()|Double|"' (Set|Get) The Variation as Double.
        Private _Variation As Double
        '''    <Summary>
        '''     (Set|Get) The Variation as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:051 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Variation as Double.")>
        Public Property Variation() As Double
            Get
                Return _Variation
            End Get
            Set(ByVal Value As Double)
                _Variation = Value
            End Set
        End Property
#End Region '(Set|Get) The Variation as Double.

#Region "[On] |2019/07/08 18h11:147| <01.00.08> <Property> <Columns> |.Français()|String|"' (Set|Get) The Français as String.
        Private _Français As String
        '''    <Summary>
        '''     (Set|Get) The Français as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:051 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Français as String.")>
        Public Property Français() As String
            Get
                Return _Français
            End Get
            Set(ByVal Value As String)
                _Français = Value
            End Set
        End Property
#End Region '(Set|Get) The Français as String.

#Region "[On] |2019/07/08 18h11:153| <01.00.09> <Property> <Columns> |.English()|String|"' (Set|Get) The English as String.
        Private _English As String
        '''    <Summary>
        '''     (Set|Get) The English as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:051 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The English as String.")>
        Public Property English() As String
            Get
                Return _English
            End Get
            Set(ByVal Value As String)
                _English = Value
            End Set
        End Property
#End Region '(Set|Get) The English as String.

#Region "[On] |2019/07/08 18h11:159| <01.00.10> <Property> <Columns> |.Italian()|String|"' (Set|Get) The Italian as String.
        Private _Italian As String
        '''    <Summary>
        '''     (Set|Get) The Italian as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:052 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Italian as String.")>
        Public Property Italian() As String
            Get
                Return _Italian
            End Get
            Set(ByVal Value As String)
                _Italian = Value
            End Set
        End Property
#End Region '(Set|Get) The Italian as String.

#Region "[On] |2019/07/08 18h11:166| <01.00.11> <Property> <Columns> |.German()|String|"' (Set|Get) The German as String.
        Private _German As String
        '''    <Summary>
        '''     (Set|Get) The German as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:052 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The German as String.")>
        Public Property German() As String
            Get
                Return _German
            End Get
            Set(ByVal Value As String)
                _German = Value
            End Set
        End Property
#End Region '(Set|Get) The German as String.

#Region "[On] |2019/07/08 18h11:173| <01.00.12> <Property> <Columns> |.Spanish()|String|"' (Set|Get) The Spanish as String.
        Private _Spanish As String
        '''    <Summary>
        '''     (Set|Get) The Spanish as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:052 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Spanish as String.")>
        Public Property Spanish() As String
            Get
                Return _Spanish
            End Get
            Set(ByVal Value As String)
                _Spanish = Value
            End Set
        End Property
#End Region '(Set|Get) The Spanish as String.

#Region "[On] |2019/07/08 18h11:182| <01.00.13> <Property> <Columns> |.Portuguese()|String|"' (Set|Get) The Portuguese as String.
        Private _Portuguese As String
        '''    <Summary>
        '''     (Set|Get) The Portuguese as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:052 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Portuguese as String.")>
        Public Property Portuguese() As String
            Get
                Return _Portuguese
            End Get
            Set(ByVal Value As String)
                _Portuguese = Value
            End Set
        End Property
#End Region '(Set|Get) The Portuguese as String.

#Region "[On] |2019/07/08 18h11:190| <01.00.14> <Property> <Columns> |.Russian()|String|"' (Set|Get) The Russian as String.
        Private _Russian As String
        '''    <Summary>
        '''     (Set|Get) The Russian as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:055 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Russian as String.")>
        Public Property Russian() As String
            Get
                Return _Russian
            End Get
            Set(ByVal Value As String)
                _Russian = Value
            End Set
        End Property
#End Region '(Set|Get) The Russian as String.

#End Region
#Region "<2> [Enumeration]{1}"
#Region "[On] |2019/07/08 18h11:196| <02.00.00> <Enumeration> <> |.Schema()|Enumeration{14}|"' (Set|Get) The enumeration of Schema.
        '''    <Summary>
        '''     (Set|Get) The enumeration of Schema.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:055 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The enumeration of Schema.")>
        Enum Schema
            ''' <summary>(Set|Get) The ID as Integer.</summary>
            [ID] = 0
            ''' <summary>(Set|Get) The Name as String.</summary>
            [Name] = 1
            ''' <summary>(Set|Get) The Opening as Double.</summary>
            [Opening] = 2
            ''' <summary>(Set|Get) The Debit as Double.</summary>
            [Debit] = 3
            ''' <summary>(Set|Get) The Credit as Double.</summary>
            [Credit] = 4
            ''' <summary>(Set|Get) The Balance as Double.</summary>
            [Balance] = 5
            ''' <summary>(Set|Get) The Closing as Integer.</summary>
            [Closing] = 6
            ''' <summary>(Set|Get) The Variation as Double.</summary>
            [Variation] = 7
            ''' <summary>(Set|Get) The Français as String.</summary>
            [Français] = 8
            ''' <summary>(Set|Get) The English as String.</summary>
            [English] = 9
            ''' <summary>(Set|Get) The Italian as String.</summary>
            [Italian] = 10
            ''' <summary>(Set|Get) The German as String.</summary>
            [German] = 11
            ''' <summary>(Set|Get) The Spanish as String.</summary>
            [Spanish] = 12
            ''' <summary>(Set|Get) The Portuguese as String.</summary>
            [Portuguese] = 13
            ''' <summary>(Set|Get) The Russian as String.</summary>
            [Russian] = 14
        End Enum
#End Region '(Set|Get) The enumeration of Schema.

#End Region
#Region "<4> [Sub]{5}"
#Region "[On] |2019/07/08 18h11:203| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
        '''    <Summary>
        '''     (Set|Get) This will reinitialize the class element.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:056 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will reinitialize the class element.")>
        Public Sub Clear()
            With Me
                .ID = 0
                .Name = Nothing
                .Opening = 0
                .Debit = 0
                .Credit = 0
                .Balance = 0
                .Closing = 0
                .Variation = 0
                .Français = Nothing
                .English = Nothing
                .Italian = Nothing
                .German = Nothing
                .Spanish = Nothing
                .Portuguese = Nothing
                .Russian = Nothing
            End With
        End Sub
#End Region '(Set|Get) This will reinitialize the class element.

#Region "[On] |2019/07/08 18h11:211| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
        '''    <Summary>
        '''     (Set|Get) This will reinitialize the variables of this class.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:057 </Published>
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
                    TableName = "Tbl_Group"
                    Line = Connector.Line
                    UseSQL = False
                Else
                    FilePath = My.Settings.Db_Accountis_FilePath
                    Password = My.Settings.Db_Accountis_Password
                    Me.Line = My.Settings.Db_Accountis_Line
                    TableName = "Tbl_Group"
                    UseSQL = False
                End If
            Else
                If IsNothing(FilePath) Then
                    FilePath = My.Settings.Db_Accountis_FilePath
                End If
                If FilePath.Length < 1 Then
                    FilePath = My.Settings.Db_Accountis_FilePath
                End If
                FilePath = My.Settings.Db_Accountis_FilePath
                Password = My.Settings.Db_Accountis_Password
                Me.Line = My.Settings.Db_Accountis_Line
                TableName = "Tbl_Group"
                UseSQL = False
            End If

        End Sub
#End Region '(Set|Get) This will reinitialize the variables of this class.

#Region "[On] |2019/07/08 18h11:217| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
        '''    <Summary>
        '''     (Set|Get) This will add a new row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:057 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will add a new row in the table.")>
        Public Sub Add()
            Try
                Dim Str As String = Nothing
                Str = "Insert Into [Tbl_Group] (
`ID`, 
`Name`, 
`Opening`, 
`Debit`, 
`Credit`, 
`Balance`, 
`Closing`, 
`Variation`, 
`Français`, 
`English`, 
`Italian`, 
`German`, 
`Spanish`, 
`Portuguese`, 
`Russian`) Values (@0, @1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14)"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@0", Me.ID)
                Cmd.Parameters.AddWithValue("@1", Me.Name)
                Cmd.Parameters.AddWithValue("@2", Me.Opening)
                Cmd.Parameters.AddWithValue("@3", Me.Debit)
                Cmd.Parameters.AddWithValue("@4", Me.Credit)
                Cmd.Parameters.AddWithValue("@5", Me.Balance)
                Cmd.Parameters.AddWithValue("@6", Me.Closing)
                Cmd.Parameters.AddWithValue("@7", Me.Variation)
                Cmd.Parameters.AddWithValue("@8", Me.Français)
                Cmd.Parameters.AddWithValue("@9", Me.English)
                Cmd.Parameters.AddWithValue("@10", Me.Italian)
                Cmd.Parameters.AddWithValue("@11", Me.German)
                Cmd.Parameters.AddWithValue("@12", Me.Spanish)
                Cmd.Parameters.AddWithValue("@13", Me.Portuguese)
                Cmd.Parameters.AddWithValue("@14", Me.Russian)
                If Cmd.ExecuteNonQuery >= 0 Then
                Else
                    Msgbox("Element not Addd")
                End If
            Catch ex As Exception
            Finally
                Close(True)
            End Try

        End Sub
#End Region '(Set|Get) This will add a new row in the table.

#Region "[On] |2019/07/08 18h11:225| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
        '''    <Summary>
        '''     (Set|Get) This will update a row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:057 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will update a row in the table.")>
        Public Sub Save()
            Try
                Dim Str As String = Nothing
                Str = "UPDATE [Tbl_Group] SET Name = @Name, Opening = @Opening, Debit = @Debit, Credit = @Credit, Balance = @Balance, Closing = @Closing, Variation = @Variation, Français = @Français, English = @English, Italian = @Italian, German = @German, Spanish = @Spanish, Portuguese = @Portuguese, Russian = @Russian WHERE ID = @ID"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@Name", Name)
                Cmd.Parameters.AddWithValue("@Opening", Opening)
                Cmd.Parameters.AddWithValue("@Debit", Debit)
                Cmd.Parameters.AddWithValue("@Credit", Credit)
                Cmd.Parameters.AddWithValue("@Balance", Balance)
                Cmd.Parameters.AddWithValue("@Closing", Closing)
                Cmd.Parameters.AddWithValue("@Variation", Variation)
                Cmd.Parameters.AddWithValue("@Français", Français)
                Cmd.Parameters.AddWithValue("@English", English)
                Cmd.Parameters.AddWithValue("@Italian", Italian)
                Cmd.Parameters.AddWithValue("@German", German)
                Cmd.Parameters.AddWithValue("@Spanish", Spanish)
                Cmd.Parameters.AddWithValue("@Portuguese", Portuguese)
                Cmd.Parameters.AddWithValue("@Russian", Russian)
                Cmd.Parameters.AddWithValue("@ID", ID)
                If Cmd.ExecuteNonQuery >= 0 Then
                Else
                    Msgbox("Element not Saved")
                End If
            Catch ex As Exception
            Finally
                Close(True)
            End Try

        End Sub
#End Region '(Set|Get) This will update a row in the table.

#Region "[On] |2019/07/08 18h11:232| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
        '''    <Summary>
        '''     (Set|Get) This will Delete a row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:057 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will Delete a row in the table.")>
        Public Sub Delete()
            Try
                Dim Str As String = Nothing
                Str = "Delete From [Tbl_Group] WHERE ID =@ID"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@ID", ID)
                If Cmd.ExecuteNonQuery >= 0 Then
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
#Region "[On] |2019/07/08 18h11:240| <05.00.00> <Function> <> |.Open()|TestItem}|"' (Set|Get) This will initialise the connection and import the data.
        '''    <Summary>
        '''     (Set|Get) This will initialise the connection and import the data.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:060 </Published>
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
                Result.Why += Log & VbNewLine
            End If
            Return Result

        End Function
#End Region '(Set|Get) This will initialise the connection and import the data.

#Region "[On] |2019/07/08 18h11:247| <05.00.01> <Function> <> |.Close()|TestItem}|"' (Set|Get) This willClosing the connection
        '''    <Summary>
        '''     (Set|Get) This willClosing the connection
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:060 </Published>
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

#Region "[On] |2019/07/08 18h11:254| <05.00.02> <Function> <> |.List()|List(Of Tbl_Group)}|"' (Set|Get) Return the entire table listed
        '''    <Summary>
        '''     (Set|Get) Return the entire table listed
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:060 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Return the entire table listed")>
        Public Function List() As List(Of Tbl_Group)
            Dim Result As New List(Of Tbl_Group)
            Me.Table = New Table(Me.TableName, Me.FilePath, Me.Password, False)
            For Each Row As DataRow In Me.Table.DataTable.Rows
                Dim Element As New Tbl_Group(IIf(IsDBNull(Row.Item(0)), 0, Row.Item(0)),
IIf(IsDBNull(Row.Item(1)), "", Row.Item(1)),
IIf(IsDBNull(Row.Item(2)), 0, Row.Item(2)),
IIf(IsDBNull(Row.Item(3)), 0, Row.Item(3)),
IIf(IsDBNull(Row.Item(4)), 0, Row.Item(4)),
IIf(IsDBNull(Row.Item(5)), 0, Row.Item(5)),
IIf(IsDBNull(Row.Item(6)), 0, Row.Item(6)),
IIf(IsDBNull(Row.Item(7)), 0, Row.Item(7)),
IIf(IsDBNull(Row.Item(8)), "", Row.Item(8)),
IIf(IsDBNull(Row.Item(9)), "", Row.Item(9)),
IIf(IsDBNull(Row.Item(10)), "", Row.Item(10)),
IIf(IsDBNull(Row.Item(11)), "", Row.Item(11)),
IIf(IsDBNull(Row.Item(12)), "", Row.Item(12)),
IIf(IsDBNull(Row.Item(13)), "", Row.Item(13)),
      IIf(IsDBNull(Row.Item(14)), "", Row.Item(14)))
                Element.Reset(Table.Line)
                Result.Add(Element)
            Next
            Return Result
        End Function
#End Region '(Set|Get) Return the entire table listed

#Region "[On] |2019/07/08 18h11:267| <05.00.03> <Function> <> |.SearchByName()|List(Of Tbl_Group)}|"' (Set|Get) Search for each property that match the Search String.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search String.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:060 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Search for each property that match the Search String.")>
        Public Shared Function SearchByName(ByVal Search As String) As List(Of Tbl_Group)
            Dim Result As New List(Of Tbl_Group)
            Dim C As New Tbl_Group
            For Each Element As Tbl_Group In C.List
                If Element.Name.Tolower() = Search.Tolower() Or Element.Français.Tolower() = Search.Tolower() Or Element.English.Tolower() = Search.Tolower() Or Element.Italian.Tolower() = Search.Tolower() Or Element.German.Tolower() = Search.Tolower() Or Element.Spanish.Tolower() = Search.Tolower() Or Element.Portuguese.Tolower() = Search.Tolower() Or Element.Russian.Tolower() = Search.Tolower() Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search String.

#Region "[On] |2019/07/08 18h11:274| <05.00.04> <Function> <> |.SearchByID()|List(Of Tbl_Group)}|"' (Set|Get) Search for each property that match the Search Id.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search Id.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:060 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Search for each property that match the Search Id.")>
        Public Shared Function SearchByID(ByVal Search As Double) As List(Of Tbl_Group)
            Dim Result As New List(Of Tbl_Group)
            Dim C As New Tbl_Group
            For Each Element As Tbl_Group In C.List
                If Val(Element.ID) = Search Or Val(Element.Opening) = Search Or Val(Element.Debit) = Search Or Val(Element.Credit) = Search Or Val(Element.Balance) = Search Or Val(Element.Closing) = Search Or Val(Element.Variation) = Search Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search Id.

#Region "[On] |2019/07/08 18h11:281| <05.00.05> <Function> <> |.ToString()|String}|"' (Set|Get) The function ToString.
        '''    <Summary>
        '''     (Set|Get) The function ToString.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:060 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The function ToString.")>
        Public Overrides Function ToString() As String
            Return Me.ID
        End Function
#End Region '(Set|Get) The function ToString.

#Region "[On] |2019/07/08 18h11:288| <05.00.06> <Function> <> |.CheckConnection()|Boolean}|"' (Set|Get) Evaluate the connection to the DataBase
        '''    <Summary>
        '''     (Set|Get) Evaluate the connection to the DataBase
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:060 </Published>
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
                    Me.Connector = New LineInfo(FilePath, Password)
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
            Log += Message & VbNewLine
            Return General_Status

        End Function
#End Region '(Set|Get) Evaluate the connection to the DataBase

#End Region
#Region "<6> [Runtime]{12}"
#Region "[On] |2019/07/08 18h11:296| <15.00.00> <Runtime> <> |.Table()|Table"' (Set|Get) The Table.
        '''    <Summary>
        '''     (Set|Get) The Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:061 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Table.")>
        Public Table As Table
#End Region '(Set|Get) The Table.

#Region "[On] |2019/07/08 18h11:303| <15.00.01> <Runtime> <> |.Line()|String"' (Set|Get) The Connection String To the Table.
        '''    <Summary>
        '''     (Set|Get) The Connection String To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:061 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Connection String To the Table.")>
        Public Line As String
#End Region '(Set|Get) The Connection String To the Table.

#Region "[On] |2019/07/08 18h11:310| <15.00.02> <Runtime> <> |.FilePath()|String"' (Set|Get) The FilePath To the Table.
        '''    <Summary>
        '''     (Set|Get) The FilePath To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:061 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The FilePath To the Table.")>
        Public FilePath As String
#End Region '(Set|Get) The FilePath To the Table.

#Region "[On] |2019/07/08 18h11:318| <15.00.03> <Runtime> <> |.Password()|String"' (Set|Get) The Password To the Table.
        '''    <Summary>
        '''     (Set|Get) The Password To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:061 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Password To the Table.")>
        Public Password As String
#End Region '(Set|Get) The Password To the Table.

#Region "[On] |2019/07/08 18h11:325| <15.00.04> <Runtime> <> |.UseSQL()|Boolean"' (Set|Get) Determines if the Database Connection is of type SQL.
        '''    <Summary>
        '''     (Set|Get) Determines if the Database Connection is of type SQL.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:064 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Determines if the Database Connection is of type SQL.")>
        Public UseSQL As Boolean
#End Region '(Set|Get) Determines if the Database Connection is of type SQL.

#Region "[On] |2019/07/08 18h11:333| <15.00.05> <Runtime> <> |.TableName()|String"' (Set|Get) The name of the Table.
        '''    <Summary>
        '''     (Set|Get) The name of the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:064 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The name of the Table.")>
        Public TableName As String
#End Region '(Set|Get) The name of the Table.

#Region "[On] |2019/07/08 18h11:341| <15.00.06> <Runtime> <> |.Con()|OleDb.OleDbConnection"' (Set|Get) The Con To the Table.
        '''    <Summary>
        '''     (Set|Get) The Con To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:064 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Con To the Table.")>
        Public Con As OleDb.OleDbConnection
#End Region '(Set|Get) The Con To the Table.

#Region "[On] |2019/07/08 18h11:344| <15.00.07> <Runtime> <> |.Cmd()|OleDb.OleDbCommand"' (Set|Get) The Cmd To the Table.
        '''    <Summary>
        '''     (Set|Get) The Cmd To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:064 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Cmd To the Table.")>
        Public Cmd As OleDb.OleDbCommand
#End Region '(Set|Get) The Cmd To the Table.

#Region "[On] |2019/07/08 18h11:353| <15.00.08> <Runtime> <> |.DataReader()|OleDb.OleDbDataReader"' (Set|Get) The DataReader To the Table.
        '''    <Summary>
        '''     (Set|Get) The DataReader To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:064 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The DataReader To the Table.")>
        Public DataReader As OleDb.OleDbDataReader
#End Region '(Set|Get) The DataReader To the Table.

#Region "[On] |2019/07/08 18h11:370| <15.00.09> <Runtime> <> |.DataAdapter()|OleDb.OleDbDataAdapter"' (Set|Get) The DataAdapter To the Table.
        '''    <Summary>
        '''     (Set|Get) The DataAdapter To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:065 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The DataAdapter To the Table.")>
        Public DataAdapter As OleDb.OleDbDataAdapter
#End Region '(Set|Get) The DataAdapter To the Table.

#Region "[On] |2019/07/08 18h11:378| <15.00.10> <Runtime> <> |.Connector()|LineInfo"' (Set|Get) The Connector To the Table.
        '''    <Summary>
        '''     (Set|Get) The Connector To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:065 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Connector To the Table.")>
        Public Connector As LineInfo
#End Region '(Set|Get) The Connector To the Table.

#Region "[On] |2019/07/08 18h11:385| <15.00.11> <Runtime> <> |.Log()|String"' (Set|Get) The Log To the Table.
        '''    <Summary>
        '''     (Set|Get) The Log To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:065 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Log To the Table.")>
        Public Log As String
#End Region '(Set|Get) The Log To the Table.

#End Region
#Region "<7> [Loader]{2}"
#Region "[On] |2019/07/08 18h11:393| <06.00.00> <Loader> <> |.Empty()|Function}|"' (Set|Get) The sub Empty.
        '''    <Summary>
        '''     (Set|Get) The sub Empty.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:065 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The sub Empty.")>
        Public Sub New()
            Reset
        End Sub
#End Region '(Set|Get) The sub Empty.

#Region "[On] |2019/07/08 18h11:394| <06.00.01> <Loader> <> |.Filled()|Function}|"' (Set|Get) The sub Filled.
        '''    <Summary>
        '''     (Set|Get) The sub Filled.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:065 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>    ''' <param name="ID">(Set|Get) The ID as Integer.</param>
        ''' <param name="Name">(Set|Get) The Name as String.</param>
        ''' <param name="Opening">(Set|Get) The Opening as Double.</param>
        ''' <param name="Debit">(Set|Get) The Debit as Double.</param>
        ''' <param name="Credit">(Set|Get) The Credit as Double.</param>
        ''' <param name="Balance">(Set|Get) The Balance as Double.</param>
        ''' <param name="Closing">(Set|Get) The Closing as Integer.</param>
        ''' <param name="Variation">(Set|Get) The Variation as Double.</param>
        ''' <param name="Français">(Set|Get) The Français as String.</param>
        ''' <param name="English">(Set|Get) The English as String.</param>
        ''' <param name="Italian">(Set|Get) The Italian as String.</param>
        ''' <param name="German">(Set|Get) The German as String.</param>
        ''' <param name="Spanish">(Set|Get) The Spanish as String.</param>
        ''' <param name="Portuguese">(Set|Get) The Portuguese as String.</param>
        ''' <param name="Russian">(Set|Get) The Russian as String.</param>

        <Browsable(True), Description("(Set|Get) The sub Filled.")>
        Public Sub New(ByVal ID As Integer,
ByVal Name As String,
ByVal Opening As Double,
ByVal Debit As Double,
ByVal Credit As Double,
ByVal Balance As Double,
ByVal Closing As Integer,
ByVal Variation As Double,
ByVal Français As String,
ByVal English As String,
ByVal Italian As String,
ByVal German As String,
ByVal Spanish As String,
ByVal Portuguese As String,
ByVal Russian As String)
            With Me
                Clear()
                Reset()
                .ID = ID
                .Name = Name
                .Opening = Opening
                .Debit = Debit
                .Credit = Credit
                .Balance = Balance
                .Closing = Closing
                .Variation = Variation
                .Français = Français
                .English = English
                .Italian = Italian
                .German = German
                .Spanish = Spanish
                .Portuguese = Portuguese
                .Russian = Russian
            End With

        End Sub
#End Region '(Set|Get) The sub Filled.

#End Region
    End Class
#End Region

#Region "[On] |2019/07/08 18h11:493| <08.00.00> <Class> <> |.Tbl_GroupTotaux|Class|{41} |Production Cost : 51.7|Selling Price : 129.25|"' Class created automatically by SmartOffice (c)Copyright 2019.
    '''    <Summary>
    '''     Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Tbl_GroupTotaux
    '''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
    '''    Contributor Information : ||
    '''    Creation Date :           2019/07/08 18h11:493
    '''    |Schema|
    '''    |ID| |ObjectType |{Quantity}||UnitPrice||Total
    '''    |00| |Importation|{0}||1| |0
    '''    |01| |Properties |{14}||0.8| |11.2
    '''    |02| |Enumeration|{1}||0.4| |0.4
    '''    |03| |Structure  |{0}||0.4| |0
    '''    |04| |Sub        |{5}||1.2| |6
    '''    |05| |Function   |{7}||1.6| |11.2
    '''    |06| |Runtime    |{12}||0.4| |4.8
    '''    |07| |Loader     |{2}||0.8| |1.6
    '''    |08| |Class      |{0}||2| |0
    '''    |09| |Constante  |{0}||0.4| |0
    '''    |10| |Event      |{0}||1.2| |0
    '''    |11| |Members    |{14}||0.5| |7
    '''    |12| |Parameter  |{19}||0.5| |9.5
    '''    |Production Cost             |51.7
    '''    |Selling Price without VAT   |129.25
    '''    |Total TVA                   |9.95
    '''    |Grand Total                 |139.2
    '''    |/Schema|
    '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
    '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
    '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
    '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:085 </Published>
    '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
    '''    </Summary>
    Public Class Tbl_GroupTotaux
#Region "<1> [Property]{14}"
#Region "[On] |2019/07/08 18h11:494| <01.00.00> <Property> <Columns> |.N()|Integer|"' (Set|Get) The N as Integer.
        Private _N As Integer
        '''    <Summary>
        '''     (Set|Get) The N as Integer.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:085 </Published>
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
#Region "[On] |2019/07/08 18h11:500| <01.00.01> <Property> <Columns> |.Opening()|Double|"' (Set|Get) The Opening as Double.
        Private _Opening As Double
        '''    <Summary>
        '''     (Set|Get) The Opening as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:085 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Opening as Double.")>
        Public Property Opening() As Double
            Get
                Return _Opening
            End Get
            Set(ByVal Value As Double)
                _Opening = Value
            End Set
        End Property
#End Region '(Set|Get) The Opening as Double.
#Region "[On] |2019/07/08 18h11:507| <01.00.02> <Property> <Columns> |.Debit()|Double|"' (Set|Get) The Debit as Double.
        Private _Debit As Double
        '''    <Summary>
        '''     (Set|Get) The Debit as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:085 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Debit as Double.")>
        Public Property Debit() As Double
            Get
                Return _Debit
            End Get
            Set(ByVal Value As Double)
                _Debit = Value
            End Set
        End Property
#End Region '(Set|Get) The Debit as Double.
#Region "[On] |2019/07/08 18h11:513| <01.00.03> <Property> <Columns> |.Credit()|Double|"' (Set|Get) The Credit as Double.
        Private _Credit As Double
        '''    <Summary>
        '''     (Set|Get) The Credit as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:085 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Credit as Double.")>
        Public Property Credit() As Double
            Get
                Return _Credit
            End Get
            Set(ByVal Value As Double)
                _Credit = Value
            End Set
        End Property
#End Region '(Set|Get) The Credit as Double.
#Region "[On] |2019/07/08 18h11:519| <01.00.04> <Property> <Columns> |.Balance()|Double|"' (Set|Get) The Balance as Double.
        Private _Balance As Double
        '''    <Summary>
        '''     (Set|Get) The Balance as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:086 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Balance as Double.")>
        Public Property Balance() As Double
            Get
                Return _Balance
            End Get
            Set(ByVal Value As Double)
                _Balance = Value
            End Set
        End Property
#End Region '(Set|Get) The Balance as Double.
#Region "[On] |2019/07/08 18h11:525| <01.00.05> <Property> <Columns> |.Closing()|Double|"' (Set|Get) The Closing as Double.
        Private _Closing As Double
        '''    <Summary>
        '''     (Set|Get) The Closing as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:086 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Closing as Double.")>
        Public Property Closing() As Double
            Get
                Return _Closing
            End Get
            Set(ByVal Value As Double)
                _Closing = Value
            End Set
        End Property
#End Region '(Set|Get) The Closing as Double.
#Region "[On] |2019/07/08 18h11:531| <01.00.06> <Property> <Columns> |.Variation()|Double|"' (Set|Get) The Variation as Double.
        Private _Variation As Double
        '''    <Summary>
        '''     (Set|Get) The Variation as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:086 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Variation as Double.")>
        Public Property Variation() As Double
            Get
                Return _Variation
            End Get
            Set(ByVal Value As Double)
                _Variation = Value
            End Set
        End Property
#End Region '(Set|Get) The Variation as Double.
#Region "[On] |2019/07/08 18h11:536| <01.00.07> <Property> <Columns> |.Français()|String|"' (Set|Get) The Français as String.
        Private _Français As String
        '''    <Summary>
        '''     (Set|Get) The Français as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:086 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Français as String.")>
        Public Property Français() As String
            Get
                Return _Français
            End Get
            Set(ByVal Value As String)
                _Français = Value
            End Set
        End Property
#End Region '(Set|Get) The Français as String.
#Region "[On] |2019/07/08 18h11:543| <01.00.08> <Property> <Columns> |.English()|String|"' (Set|Get) The English as String.
        Private _English As String
        '''    <Summary>
        '''     (Set|Get) The English as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:086 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The English as String.")>
        Public Property English() As String
            Get
                Return _English
            End Get
            Set(ByVal Value As String)
                _English = Value
            End Set
        End Property
#End Region '(Set|Get) The English as String.
#Region "[On] |2019/07/08 18h11:549| <01.00.09> <Property> <Columns> |.Italian()|String|"' (Set|Get) The Italian as String.
        Private _Italian As String
        '''    <Summary>
        '''     (Set|Get) The Italian as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:089 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Italian as String.")>
        Public Property Italian() As String
            Get
                Return _Italian
            End Get
            Set(ByVal Value As String)
                _Italian = Value
            End Set
        End Property
#End Region '(Set|Get) The Italian as String.
#Region "[On] |2019/07/08 18h11:555| <01.00.10> <Property> <Columns> |.German()|String|"' (Set|Get) The German as String.
        Private _German As String
        '''    <Summary>
        '''     (Set|Get) The German as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:089 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The German as String.")>
        Public Property German() As String
            Get
                Return _German
            End Get
            Set(ByVal Value As String)
                _German = Value
            End Set
        End Property
#End Region '(Set|Get) The German as String.
#Region "[On] |2019/07/08 18h11:561| <01.00.11> <Property> <Columns> |.Spanish()|String|"' (Set|Get) The Spanish as String.
        Private _Spanish As String
        '''    <Summary>
        '''     (Set|Get) The Spanish as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:089 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Spanish as String.")>
        Public Property Spanish() As String
            Get
                Return _Spanish
            End Get
            Set(ByVal Value As String)
                _Spanish = Value
            End Set
        End Property
#End Region '(Set|Get) The Spanish as String.
#Region "[On] |2019/07/08 18h11:567| <01.00.12> <Property> <Columns> |.Portuguese()|String|"' (Set|Get) The Portuguese as String.
        Private _Portuguese As String
        '''    <Summary>
        '''     (Set|Get) The Portuguese as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:089 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Portuguese as String.")>
        Public Property Portuguese() As String
            Get
                Return _Portuguese
            End Get
            Set(ByVal Value As String)
                _Portuguese = Value
            End Set
        End Property
#End Region '(Set|Get) The Portuguese as String.
#Region "[On] |2019/07/08 18h11:574| <01.00.13> <Property> <Columns> |.Russian()|String|"' (Set|Get) The Russian as String.
        Private _Russian As String
        '''    <Summary>
        '''     (Set|Get) The Russian as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:090 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Russian as String.")>
        Public Property Russian() As String
            Get
                Return _Russian
            End Get
            Set(ByVal Value As String)
                _Russian = Value
            End Set
        End Property
#End Region '(Set|Get) The Russian as String.
#End Region
#Region "<2> [Enumeration]{1}"
#Region "[On] |2019/07/08 18h11:581| <02.00.00> <Enumeration> <> |.Schema()|Enumeration{13}|"' (Set|Get) The enumeration of Schema.
        '''    <Summary>
        '''     (Set|Get) The enumeration of Schema.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:090 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The enumeration of Schema.")>
        Enum Schema
            ''' <summary>(Set|Get) The N as Integer.</summary>
            [N] = 0
            ''' <summary>(Set|Get) The Opening as Double.</summary>
            [Opening] = 1
            ''' <summary>(Set|Get) The Debit as Double.</summary>
            [Debit] = 2
            ''' <summary>(Set|Get) The Credit as Double.</summary>
            [Credit] = 3
            ''' <summary>(Set|Get) The Balance as Double.</summary>
            [Balance] = 4
            ''' <summary>(Set|Get) The Closing as Double.</summary>
            [Closing] = 5
            ''' <summary>(Set|Get) The Variation as Double.</summary>
            [Variation] = 6
            ''' <summary>(Set|Get) The Français as String.</summary>
            [Français] = 7
            ''' <summary>(Set|Get) The English as String.</summary>
            [English] = 8
            ''' <summary>(Set|Get) The Italian as String.</summary>
            [Italian] = 9
            ''' <summary>(Set|Get) The German as String.</summary>
            [German] = 10
            ''' <summary>(Set|Get) The Spanish as String.</summary>
            [Spanish] = 11
            ''' <summary>(Set|Get) The Portuguese as String.</summary>
            [Portuguese] = 12
            ''' <summary>(Set|Get) The Russian as String.</summary>
            [Russian] = 13
        End Enum
#End Region '(Set|Get) The enumeration of Schema.

#End Region
#Region "<4> [Sub]{5}"
#Region "[On] |2019/07/08 18h11:592| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
        '''    <Summary>
        '''     (Set|Get) This will reinitialize the class element.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:093 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will reinitialize the class element.")>
        Public Sub Clear()
            With Me
                .N = 0
                .Opening = 0
                .Debit = 0
                .Credit = 0
                .Balance = 0
                .Closing = 0
                .Variation = 0
                .Français = Nothing
                .English = Nothing
                .Italian = Nothing
                .German = Nothing
                .Spanish = Nothing
                .Portuguese = Nothing
                .Russian = Nothing
            End With
        End Sub
#End Region '(Set|Get) This will reinitialize the class element.

#Region "[On] |2019/07/08 18h11:601| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
        '''    <Summary>
        '''     (Set|Get) This will reinitialize the variables of this class.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:093 </Published>
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
                    TableName = "Tbl_GroupTotaux"
                    Line = Connector.Line
                    UseSQL = False
                Else
                    FilePath = My.Settings.Db_Accountis_FilePath
                    Password = My.Settings.Db_Accountis_Password
                    Me.Line = My.Settings.Db_Accountis_Line
                    TableName = "Tbl_GroupTotaux"
                    UseSQL = False
                End If
            Else
                If IsNothing(FilePath) Then
                    FilePath = My.Settings.Db_Accountis_FilePath
                End If
                If FilePath.Length < 1 Then
                    FilePath = My.Settings.Db_Accountis_FilePath
                End If
                FilePath = My.Settings.Db_Accountis_FilePath
                Password = My.Settings.Db_Accountis_Password
                Me.Line = My.Settings.Db_Accountis_Line
                TableName = "Tbl_GroupTotaux"
                UseSQL = False
            End If

        End Sub
#End Region '(Set|Get) This will reinitialize the variables of this class.

#Region "[On] |2019/07/08 18h11:608| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
        '''    <Summary>
        '''     (Set|Get) This will add a new row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:093 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will add a new row in the table.")>
        Public Sub Add()
            Try
                Dim Str As String = Nothing
                Str = "Insert Into [Tbl_GroupTotaux] (
`N`, 
`Opening`, 
`Debit`, 
`Credit`, 
`Balance`, 
`Closing`, 
`Variation`, 
`Français`, 
`English`, 
`Italian`, 
`German`, 
`Spanish`, 
`Portuguese`, 
`Russian`) Values (@0, @1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13)"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@0", Me.N)
                Cmd.Parameters.AddWithValue("@1", Me.Opening)
                Cmd.Parameters.AddWithValue("@2", Me.Debit)
                Cmd.Parameters.AddWithValue("@3", Me.Credit)
                Cmd.Parameters.AddWithValue("@4", Me.Balance)
                Cmd.Parameters.AddWithValue("@5", Me.Closing)
                Cmd.Parameters.AddWithValue("@6", Me.Variation)
                Cmd.Parameters.AddWithValue("@7", Me.Français)
                Cmd.Parameters.AddWithValue("@8", Me.English)
                Cmd.Parameters.AddWithValue("@9", Me.Italian)
                Cmd.Parameters.AddWithValue("@10", Me.German)
                Cmd.Parameters.AddWithValue("@11", Me.Spanish)
                Cmd.Parameters.AddWithValue("@12", Me.Portuguese)
                Cmd.Parameters.AddWithValue("@13", Me.Russian)
                If Cmd.ExecuteNonQuery >= 0 Then
                Else
                    Msgbox("Element not Addd")
                End If
            Catch ex As Exception
            Finally
                Close(True)
            End Try

        End Sub
#End Region '(Set|Get) This will add a new row in the table.

#Region "[On] |2019/07/08 18h11:615| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
        '''    <Summary>
        '''     (Set|Get) This will update a row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:093 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will update a row in the table.")>
        Public Sub Save()
            Try
                Dim Str As String = Nothing
                Str = "UPDATE [Tbl_GroupTotaux] SET Opening = @Opening, Debit = @Debit, Credit = @Credit, Balance = @Balance, Closing = @Closing, Variation = @Variation, Français = @Français, English = @English, Italian = @Italian, German = @German, Spanish = @Spanish, Portuguese = @Portuguese, Russian = @Russian WHERE N = @N"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@Opening", Opening)
                Cmd.Parameters.AddWithValue("@Debit", Debit)
                Cmd.Parameters.AddWithValue("@Credit", Credit)
                Cmd.Parameters.AddWithValue("@Balance", Balance)
                Cmd.Parameters.AddWithValue("@Closing", Closing)
                Cmd.Parameters.AddWithValue("@Variation", Variation)
                Cmd.Parameters.AddWithValue("@Français", Français)
                Cmd.Parameters.AddWithValue("@English", English)
                Cmd.Parameters.AddWithValue("@Italian", Italian)
                Cmd.Parameters.AddWithValue("@German", German)
                Cmd.Parameters.AddWithValue("@Spanish", Spanish)
                Cmd.Parameters.AddWithValue("@Portuguese", Portuguese)
                Cmd.Parameters.AddWithValue("@Russian", Russian)
                Cmd.Parameters.AddWithValue("@N", N)
                If Cmd.ExecuteNonQuery >= 0 Then
                Else
                    Msgbox("Element not Saved")
                End If
            Catch ex As Exception
            Finally
                Close(True)
            End Try

        End Sub
#End Region '(Set|Get) This will update a row in the table.

#Region "[On] |2019/07/08 18h11:622| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
        '''    <Summary>
        '''     (Set|Get) This will Delete a row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:093 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will Delete a row in the table.")>
        Public Sub Delete()
            Try
                Dim Str As String = Nothing
                Str = "Delete From [Tbl_GroupTotaux] WHERE N =@N"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@N", N)
                If Cmd.ExecuteNonQuery >= 0 Then
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
#Region "[On] |2019/07/08 18h11:629| <05.00.00> <Function> <> |.Open()|TestItem}|"' (Set|Get) This will initialise the connection and import the data.
        '''    <Summary>
        '''     (Set|Get) This will initialise the connection and import the data.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:095 </Published>
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
                Result.Why += Log & VbNewLine
            End If
            Return Result

        End Function
#End Region '(Set|Get) This will initialise the connection and import the data.

#Region "[On] |2019/07/08 18h11:635| <05.00.01> <Function> <> |.Close()|TestItem}|"' (Set|Get) This willClosing the connection
        '''    <Summary>
        '''     (Set|Get) This willClosing the connection
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:095 </Published>
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

#Region "[On] |2019/07/08 18h11:644| <05.00.02> <Function> <> |.List()|List(Of Tbl_GroupTotaux)}|"' (Set|Get) Return the entire table listed
        '''    <Summary>
        '''     (Set|Get) Return the entire table listed
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:095 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Return the entire table listed")>
        Public Function List() As List(Of Tbl_GroupTotaux)
            Dim Result As New List(Of Tbl_GroupTotaux)
            Me.Table = New Table(Me.TableName, Me.FilePath, Me.Password, False)
            For Each Row As DataRow In Me.Table.DataTable.Rows
                Dim Element As New Tbl_GroupTotaux(IIf(IsDBNull(Row.Item(0)), 0, Row.Item(0)),
IIf(IsDBNull(Row.Item(1)), 0, Row.Item(1)),
IIf(IsDBNull(Row.Item(2)), 0, Row.Item(2)),
IIf(IsDBNull(Row.Item(3)), 0, Row.Item(3)),
IIf(IsDBNull(Row.Item(4)), 0, Row.Item(4)),
IIf(IsDBNull(Row.Item(5)), 0, Row.Item(5)),
IIf(IsDBNull(Row.Item(6)), 0, Row.Item(6)),
IIf(IsDBNull(Row.Item(7)), "", Row.Item(7)),
IIf(IsDBNull(Row.Item(8)), "", Row.Item(8)),
IIf(IsDBNull(Row.Item(9)), "", Row.Item(9)),
IIf(IsDBNull(Row.Item(10)), "", Row.Item(10)),
IIf(IsDBNull(Row.Item(11)), "", Row.Item(11)),
IIf(IsDBNull(Row.Item(12)), "", Row.Item(12)),
      IIf(IsDBNull(Row.Item(13)), "", Row.Item(13)))
                Element.Reset(Table.Line)
                Result.Add(Element)
            Next
            Return Result
        End Function
#End Region '(Set|Get) Return the entire table listed

#Region "[On] |2019/07/08 18h11:652| <05.00.03> <Function> <> |.SearchByName()|List(Of Tbl_GroupTotaux)}|"' (Set|Get) Search for each property that match the Search String.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search String.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:095 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Search for each property that match the Search String.")>
        Public Shared Function SearchByName(ByVal Search As String) As List(Of Tbl_GroupTotaux)
            Dim Result As New List(Of Tbl_GroupTotaux)
            Dim C As New Tbl_GroupTotaux
            For Each Element As Tbl_GroupTotaux In C.List
                If Element.Français.Tolower() = Search.Tolower() Or Element.English.Tolower() = Search.Tolower() Or Element.Italian.Tolower() = Search.Tolower() Or Element.German.Tolower() = Search.Tolower() Or Element.Spanish.Tolower() = Search.Tolower() Or Element.Portuguese.Tolower() = Search.Tolower() Or Element.Russian.Tolower() = Search.Tolower() Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search String.

#Region "[On] |2019/07/08 18h11:660| <05.00.04> <Function> <> |.SearchByID()|List(Of Tbl_GroupTotaux)}|"' (Set|Get) Search for each property that match the Search Id.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search Id.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:098 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Search for each property that match the Search Id.")>
        Public Shared Function SearchByID(ByVal Search As Double) As List(Of Tbl_GroupTotaux)
            Dim Result As New List(Of Tbl_GroupTotaux)
            Dim C As New Tbl_GroupTotaux
            For Each Element As Tbl_GroupTotaux In C.List
                If Val(Element.N) = Search Or Val(Element.Opening) = Search Or Val(Element.Debit) = Search Or Val(Element.Credit) = Search Or Val(Element.Balance) = Search Or Val(Element.Closing) = Search Or Val(Element.Variation) = Search Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search Id.

#Region "[On] |2019/07/08 18h11:668| <05.00.05> <Function> <> |.ToString()|String}|"' (Set|Get) The function ToString.
        '''    <Summary>
        '''     (Set|Get) The function ToString.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:098 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The function ToString.")>
        Public Overrides Function ToString() As String
            Return Me.N
        End Function
#End Region '(Set|Get) The function ToString.

#Region "[On] |2019/07/08 18h11:675| <05.00.06> <Function> <> |.CheckConnection()|Boolean}|"' (Set|Get) Evaluate the connection to the DataBase
        '''    <Summary>
        '''     (Set|Get) Evaluate the connection to the DataBase
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:098 </Published>
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
                    Me.Connector = New LineInfo(FilePath, Password)
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
            Log += Message & VbNewLine
            Return General_Status

        End Function
#End Region '(Set|Get) Evaluate the connection to the DataBase

#End Region
#Region "<6> [Runtime]{12}"
#Region "[On] |2019/07/08 18h11:684| <15.00.00> <Runtime> <> |.Table()|Table"' (Set|Get) The Table.
        '''    <Summary>
        '''     (Set|Get) The Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:098 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Table.")>
        Public Table As Table
#End Region '(Set|Get) The Table.

#Region "[On] |2019/07/08 18h11:692| <15.00.01> <Runtime> <> |.Line()|String"' (Set|Get) The Connection String To the Table.
        '''    <Summary>
        '''     (Set|Get) The Connection String To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:098 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Connection String To the Table.")>
        Public Line As String
#End Region '(Set|Get) The Connection String To the Table.

#Region "[On] |2019/07/08 18h11:710| <15.00.02> <Runtime> <> |.FilePath()|String"' (Set|Get) The FilePath To the Table.
        '''    <Summary>
        '''     (Set|Get) The FilePath To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:098 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The FilePath To the Table.")>
        Public FilePath As String
#End Region '(Set|Get) The FilePath To the Table.

#Region "[On] |2019/07/08 18h11:719| <15.00.03> <Runtime> <> |.Password()|String"' (Set|Get) The Password To the Table.
        '''    <Summary>
        '''     (Set|Get) The Password To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:099 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Password To the Table.")>
        Public Password As String
#End Region '(Set|Get) The Password To the Table.

#Region "[On] |2019/07/08 18h11:727| <15.00.04> <Runtime> <> |.UseSQL()|Boolean"' (Set|Get) Determines if the Database Connection is of type SQL.
        '''    <Summary>
        '''     (Set|Get) Determines if the Database Connection is of type SQL.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:099 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Determines if the Database Connection is of type SQL.")>
        Public UseSQL As Boolean
#End Region '(Set|Get) Determines if the Database Connection is of type SQL.

#Region "[On] |2019/07/08 18h11:735| <15.00.05> <Runtime> <> |.TableName()|String"' (Set|Get) The name of the Table.
        '''    <Summary>
        '''     (Set|Get) The name of the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:099 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The name of the Table.")>
        Public TableName As String
#End Region '(Set|Get) The name of the Table.

#Region "[On] |2019/07/08 18h11:743| <15.00.06> <Runtime> <> |.Con()|OleDb.OleDbConnection"' (Set|Get) The Con To the Table.
        '''    <Summary>
        '''     (Set|Get) The Con To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:099 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Con To the Table.")>
        Public Con As OleDb.OleDbConnection
#End Region '(Set|Get) The Con To the Table.

#Region "[On] |2019/07/08 18h11:747| <15.00.07> <Runtime> <> |.Cmd()|OleDb.OleDbCommand"' (Set|Get) The Cmd To the Table.
        '''    <Summary>
        '''     (Set|Get) The Cmd To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:099 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Cmd To the Table.")>
        Public Cmd As OleDb.OleDbCommand
#End Region '(Set|Get) The Cmd To the Table.

#Region "[On] |2019/07/08 18h11:756| <15.00.08> <Runtime> <> |.DataReader()|OleDb.OleDbDataReader"' (Set|Get) The DataReader To the Table.
        '''    <Summary>
        '''     (Set|Get) The DataReader To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:100 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The DataReader To the Table.")>
        Public DataReader As OleDb.OleDbDataReader
#End Region '(Set|Get) The DataReader To the Table.

#Region "[On] |2019/07/08 18h11:764| <15.00.09> <Runtime> <> |.DataAdapter()|OleDb.OleDbDataAdapter"' (Set|Get) The DataAdapter To the Table.
        '''    <Summary>
        '''     (Set|Get) The DataAdapter To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:100 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The DataAdapter To the Table.")>
        Public DataAdapter As OleDb.OleDbDataAdapter
#End Region '(Set|Get) The DataAdapter To the Table.

#Region "[On] |2019/07/08 18h11:773| <15.00.10> <Runtime> <> |.Connector()|LineInfo"' (Set|Get) The Connector To the Table.
        '''    <Summary>
        '''     (Set|Get) The Connector To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:100 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Connector To the Table.")>
        Public Connector As LineInfo
#End Region '(Set|Get) The Connector To the Table.

#Region "[On] |2019/07/08 18h11:781| <15.00.11> <Runtime> <> |.Log()|String"' (Set|Get) The Log To the Table.
        '''    <Summary>
        '''     (Set|Get) The Log To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:100 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Log To the Table.")>
        Public Log As String
#End Region '(Set|Get) The Log To the Table.

#End Region
#Region "<7> [Loader]{2}"
#Region "[On] |2019/07/08 18h11:789| <06.00.00> <Loader> <> |.Empty()|Function}|"' (Set|Get) The sub Empty.
        '''    <Summary>
        '''     (Set|Get) The sub Empty.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:100 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The sub Empty.")>
        Public Sub New()
            Reset
        End Sub
#End Region '(Set|Get) The sub Empty.

#Region "[On] |2019/07/08 18h11:791| <06.00.01> <Loader> <> |.Filled()|Function}|"' (Set|Get) The sub Filled.
        '''    <Summary>
        '''     (Set|Get) The sub Filled.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:103 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>    ''' <param name="N">(Set|Get) The N as Integer.</param>
        ''' <param name="Opening">(Set|Get) The Opening as Double.</param>
        ''' <param name="Debit">(Set|Get) The Debit as Double.</param>
        ''' <param name="Credit">(Set|Get) The Credit as Double.</param>
        ''' <param name="Balance">(Set|Get) The Balance as Double.</param>
        ''' <param name="Closing">(Set|Get) The Closing as Double.</param>
        ''' <param name="Variation">(Set|Get) The Variation as Double.</param>
        ''' <param name="Français">(Set|Get) The Français as String.</param>
        ''' <param name="English">(Set|Get) The English as String.</param>
        ''' <param name="Italian">(Set|Get) The Italian as String.</param>
        ''' <param name="German">(Set|Get) The German as String.</param>
        ''' <param name="Spanish">(Set|Get) The Spanish as String.</param>
        ''' <param name="Portuguese">(Set|Get) The Portuguese as String.</param>
        ''' <param name="Russian">(Set|Get) The Russian as String.</param>

        <Browsable(True), Description("(Set|Get) The sub Filled.")>
        Public Sub New(ByVal N As Integer,
ByVal Opening As Double,
ByVal Debit As Double,
ByVal Credit As Double,
ByVal Balance As Double,
ByVal Closing As Double,
ByVal Variation As Double,
ByVal Français As String,
ByVal English As String,
ByVal Italian As String,
ByVal German As String,
ByVal Spanish As String,
ByVal Portuguese As String,
ByVal Russian As String)
            With Me
                Clear()
                Reset()
                .N = N
                .Opening = Opening
                .Debit = Debit
                .Credit = Credit
                .Balance = Balance
                .Closing = Closing
                .Variation = Variation
                .Français = Français
                .English = English
                .Italian = Italian
                .German = German
                .Spanish = Spanish
                .Portuguese = Portuguese
                .Russian = Russian
            End With

        End Sub
#End Region '(Set|Get) The sub Filled.

#End Region
    End Class
#End Region

#Region "[On] |2019/07/08 18h11:913| <08.00.00> <Class> <> |.Tbl_Periode|Class|{41} |Production Cost : 52.8|Selling Price : 132|"' Class created automatically by SmartOffice (c)Copyright 2019.
    '''    <Summary>
    '''     Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Tbl_Periode
    '''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
    '''    Contributor Information : ||
    '''    Creation Date :           2019/07/08 18h11:913
    '''    |Schema|
    '''    |ID| |ObjectType |{Quantity}||UnitPrice||Total
    '''    |00| |Importation|{0}||1| |0
    '''    |01| |Properties |{12}||0.8| |9.6
    '''    |02| |Enumeration|{1}||0.4| |0.4
    '''    |03| |Structure  |{0}||0.4| |0
    '''    |04| |Sub        |{5}||1.2| |6
    '''    |05| |Function   |{9}||1.6| |14.4
    '''    |06| |Runtime    |{12}||0.4| |4.8
    '''    |07| |Loader     |{2}||0.8| |1.6
    '''    |08| |Class      |{0}||2| |0
    '''    |09| |Constante  |{0}||0.4| |0
    '''    |10| |Event      |{0}||1.2| |0
    '''    |11| |Members    |{12}||0.5| |6
    '''    |12| |Parameter  |{20}||0.5| |10
    '''    |Production Cost             |52.8
    '''    |Selling Price without VAT   |132
    '''    |Total TVA                   |10.16
    '''    |Grand Total                 |142.16
    '''    |/Schema|
    '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
    '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
    '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
    '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:116 </Published>
    '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
    '''    </Summary>
    Public Class Tbl_Periode
#Region "<1> [Property]{12}"
#Region "[On] |2019/07/08 18h11:914| <01.00.00> <Property> <Columns> |.ID()|Integer|"' (Set|Get) The ID as Integer.
        Private _ID As Integer
        '''    <Summary>
        '''     (Set|Get) The ID as Integer.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:116 </Published>
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

#Region "[On] |2019/07/08 18h11:920| <01.00.01> <Property> <Columns> |.Code()|String|"' (Set|Get) The Code as String.
        Private _Code As String
        '''    <Summary>
        '''     (Set|Get) The Code as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:116 </Published>
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

#Region "[On] |2019/07/08 18h11:926| <01.00.02> <Property> <Columns> |.Start()|DateTime|"' (Set|Get) The Start as DateTime.
        Private _Start As DateTime
        '''    <Summary>
        '''     (Set|Get) The Start as DateTime.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:116 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Start as DateTime.")>
        Public Property Start() As DateTime
            Get
                Return _Start
            End Get
            Set(ByVal Value As DateTime)
                _Start = Value
            End Set
        End Property
#End Region '(Set|Get) The Start as DateTime.

#Region "[On] |2019/07/08 18h11:933| <01.00.03> <Property> <Columns> |.End()|DateTime|"' (Set|Get) The End as DateTime.
        Private _End As DateTime
        '''    <Summary>
        '''     (Set|Get) The End as DateTime.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:116 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The End as DateTime.")>
        Public Property [End]() As DateTime
            Get
                Return _End
            End Get
            Set(ByVal Value As DateTime)
                _End = Value
            End Set
        End Property
#End Region '(Set|Get) The End as DateTime.

#Region "[On] |2019/07/08 18h11:939| <01.00.04> <Property> <Columns> |.N_Entries()|Integer|"' (Set|Get) The N_Entries as Integer.
        Private _N_Entries As Integer
        '''    <Summary>
        '''     (Set|Get) The N_Entries as Integer.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:120 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The N_Entries as Integer.")>
        Public Property N_Entries() As Integer
            Get
                Return _N_Entries
            End Get
            Set(ByVal Value As Integer)
                _N_Entries = Value
            End Set
        End Property
#End Region '(Set|Get) The N_Entries as Integer.

#Region "[On] |2019/07/08 18h11:944| <01.00.05> <Property> <Columns> |.Français()|String|"' (Set|Get) The Français as String.
        Private _Français As String
        '''    <Summary>
        '''     (Set|Get) The Français as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:120 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Français as String.")>
        Public Property Français() As String
            Get
                Return _Français
            End Get
            Set(ByVal Value As String)
                _Français = Value
            End Set
        End Property
#End Region '(Set|Get) The Français as String.

#Region "[On] |2019/07/08 18h11:950| <01.00.06> <Property> <Columns> |.English()|String|"' (Set|Get) The English as String.
        Private _English As String
        '''    <Summary>
        '''     (Set|Get) The English as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:120 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The English as String.")>
        Public Property English() As String
            Get
                Return _English
            End Get
            Set(ByVal Value As String)
                _English = Value
            End Set
        End Property
#End Region '(Set|Get) The English as String.

#Region "[On] |2019/07/08 18h11:956| <01.00.07> <Property> <Columns> |.Italian()|String|"' (Set|Get) The Italian as String.
        Private _Italian As String
        '''    <Summary>
        '''     (Set|Get) The Italian as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:120 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Italian as String.")>
        Public Property Italian() As String
            Get
                Return _Italian
            End Get
            Set(ByVal Value As String)
                _Italian = Value
            End Set
        End Property
#End Region '(Set|Get) The Italian as String.

#Region "[On] |2019/07/08 18h11:962| <01.00.08> <Property> <Columns> |.German()|String|"' (Set|Get) The German as String.
        Private _German As String
        '''    <Summary>
        '''     (Set|Get) The German as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:120 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The German as String.")>
        Public Property German() As String
            Get
                Return _German
            End Get
            Set(ByVal Value As String)
                _German = Value
            End Set
        End Property
#End Region '(Set|Get) The German as String.

#Region "[On] |2019/07/08 18h11:969| <01.00.09> <Property> <Columns> |.Spanish()|String|"' (Set|Get) The Spanish as String.
        Private _Spanish As String
        '''    <Summary>
        '''     (Set|Get) The Spanish as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:121 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Spanish as String.")>
        Public Property Spanish() As String
            Get
                Return _Spanish
            End Get
            Set(ByVal Value As String)
                _Spanish = Value
            End Set
        End Property
#End Region '(Set|Get) The Spanish as String.

#Region "[On] |2019/07/08 18h11:975| <01.00.10> <Property> <Columns> |.Portuguese()|String|"' (Set|Get) The Portuguese as String.
        Private _Portuguese As String
        '''    <Summary>
        '''     (Set|Get) The Portuguese as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:121 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Portuguese as String.")>
        Public Property Portuguese() As String
            Get
                Return _Portuguese
            End Get
            Set(ByVal Value As String)
                _Portuguese = Value
            End Set
        End Property
#End Region '(Set|Get) The Portuguese as String.

#Region "[On] |2019/07/08 18h11:981| <01.00.11> <Property> <Columns> |.Russian()|String|"' (Set|Get) The Russian as String.
        Private _Russian As String
        '''    <Summary>
        '''     (Set|Get) The Russian as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:121 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Russian as String.")>
        Public Property Russian() As String
            Get
                Return _Russian
            End Get
            Set(ByVal Value As String)
                _Russian = Value
            End Set
        End Property
#End Region '(Set|Get) The Russian as String.

#End Region
#Region "<2> [Enumeration]{1}"
#Region "[On] |2019/07/08 18h11:988| <02.00.00> <Enumeration> <> |.Schema()|Enumeration{11}|"' (Set|Get) The enumeration of Schema.
        '''    <Summary>
        '''     (Set|Get) The enumeration of Schema.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:121 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The enumeration of Schema.")>
        Enum Schema
            ''' <summary>(Set|Get) The ID as Integer.</summary>
            [ID] = 0
            ''' <summary>(Set|Get) The Code as String.</summary>
            [Code] = 1
            ''' <summary>(Set|Get) The Start as DateTime.</summary>
            [Start] = 2
            ''' <summary>(Set|Get) The End as DateTime.</summary>
            [End] = 3
            ''' <summary>(Set|Get) The N_Entries as Integer.</summary>
            [N_Entries] = 4
            ''' <summary>(Set|Get) The Français as String.</summary>
            [Français] = 5
            ''' <summary>(Set|Get) The English as String.</summary>
            [English] = 6
            ''' <summary>(Set|Get) The Italian as String.</summary>
            [Italian] = 7
            ''' <summary>(Set|Get) The German as String.</summary>
            [German] = 8
            ''' <summary>(Set|Get) The Spanish as String.</summary>
            [Spanish] = 9
            ''' <summary>(Set|Get) The Portuguese as String.</summary>
            [Portuguese] = 10
            ''' <summary>(Set|Get) The Russian as String.</summary>
            [Russian] = 11
        End Enum
#End Region '(Set|Get) The enumeration of Schema.

#End Region
#Region "<4> [Sub]{5}"
#Region "[On] |2019/07/08 18h11:996| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
        '''    <Summary>
        '''     (Set|Get) This will reinitialize the class element.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:124 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will reinitialize the class element.")>
        Public Sub Clear()
            With Me
                .ID = 0
                .Code = Nothing
                .Start = New DateTime
                .End = New DateTime
                .N_Entries = 0
                .Français = Nothing
                .English = Nothing
                .Italian = Nothing
                .German = Nothing
                .Spanish = Nothing
                .Portuguese = Nothing
                .Russian = Nothing
            End With
        End Sub
#End Region '(Set|Get) This will reinitialize the class element.

#Region "[On] |2019/07/08 18h11:007| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
        '''    <Summary>
        '''     (Set|Get) This will reinitialize the variables of this class.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:124 </Published>
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
                    TableName = "Tbl_Periode"
                    Line = Connector.Line
                    UseSQL = False
                Else
                    FilePath = My.Settings.Db_Accountis_FilePath
                    Password = My.Settings.Db_Accountis_Password
                    Me.Line = My.Settings.Db_Accountis_Line
                    TableName = "Tbl_Periode"
                    UseSQL = False
                End If
            Else
                If IsNothing(FilePath) Then
                    FilePath = My.Settings.Db_Accountis_FilePath
                End If
                If FilePath.Length < 1 Then
                    FilePath = My.Settings.Db_Accountis_FilePath
                End If
                FilePath = My.Settings.Db_Accountis_FilePath
                Password = My.Settings.Db_Accountis_Password
                Me.Line = My.Settings.Db_Accountis_Line
                TableName = "Tbl_Periode"
                UseSQL = False
            End If

        End Sub
#End Region '(Set|Get) This will reinitialize the variables of this class.

#Region "[On] |2019/07/08 18h11:014| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
        '''    <Summary>
        '''     (Set|Get) This will add a new row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:124 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will add a new row in the table.")>
        Public Sub Add()
            Try
                Dim Str As String = Nothing
                Str = "Insert Into [Tbl_Periode] (
`ID`, 
`Code`, 
`Start`, 
`End`, 
`N_Entries`, 
`Français`, 
`English`, 
`Italian`, 
`German`, 
`Spanish`, 
`Portuguese`, 
`Russian`) Values (@0, @1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11)"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@0", Me.ID)
                Cmd.Parameters.AddWithValue("@1", Me.Code)
                Cmd.Parameters.AddWithValue("@2", Me.Start)
                Cmd.Parameters.AddWithValue("@3", Me.End)
                Cmd.Parameters.AddWithValue("@4", Me.N_Entries)
                Cmd.Parameters.AddWithValue("@5", Me.Français)
                Cmd.Parameters.AddWithValue("@6", Me.English)
                Cmd.Parameters.AddWithValue("@7", Me.Italian)
                Cmd.Parameters.AddWithValue("@8", Me.German)
                Cmd.Parameters.AddWithValue("@9", Me.Spanish)
                Cmd.Parameters.AddWithValue("@10", Me.Portuguese)
                Cmd.Parameters.AddWithValue("@11", Me.Russian)
                If Cmd.ExecuteNonQuery >= 0 Then
                Else
                    Msgbox("Element not Addd")
                End If
            Catch ex As Exception
            Finally
                Close(True)
            End Try

        End Sub
#End Region '(Set|Get) This will add a new row in the table.

#Region "[On] |2019/07/08 18h11:021| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
        '''    <Summary>
        '''     (Set|Get) This will update a row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:124 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will update a row in the table.")>
        Public Sub Save()
            Try
                Dim Str As String = Nothing
                Str = "UPDATE [Tbl_Periode] SET Code = @Code, Start = @Start, End = @End, N_Entries = @N_Entries, Français = @Français, English = @English, Italian = @Italian, German = @German, Spanish = @Spanish, Portuguese = @Portuguese, Russian = @Russian WHERE ID = @ID"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@Code", Code)
                Cmd.Parameters.AddWithValue("@Start", Start)
                Cmd.Parameters.AddWithValue("@End", [End])
                Cmd.Parameters.AddWithValue("@N_Entries", N_Entries)
                Cmd.Parameters.AddWithValue("@Français", Français)
                Cmd.Parameters.AddWithValue("@English", English)
                Cmd.Parameters.AddWithValue("@Italian", Italian)
                Cmd.Parameters.AddWithValue("@German", German)
                Cmd.Parameters.AddWithValue("@Spanish", Spanish)
                Cmd.Parameters.AddWithValue("@Portuguese", Portuguese)
                Cmd.Parameters.AddWithValue("@Russian", Russian)
                Cmd.Parameters.AddWithValue("@ID", ID)
                If Cmd.ExecuteNonQuery >= 0 Then
                Else
                    Msgbox("Element not Saved")
                End If
            Catch ex As Exception
            Finally
                Close(True)
            End Try

        End Sub
#End Region '(Set|Get) This will update a row in the table.

#Region "[On] |2019/07/08 18h11:028| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
        '''    <Summary>
        '''     (Set|Get) This will Delete a row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:124 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will Delete a row in the table.")>
        Public Sub Delete()
            Try
                Dim Str As String = Nothing
                Str = "Delete From [Tbl_Periode] WHERE ID =@ID"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@ID", ID)
                If Cmd.ExecuteNonQuery >= 0 Then
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
#Region "<5> [Function]{9}"
#Region "[On] |2019/07/08 18h11:035| <05.00.00> <Function> <> |.Open()|TestItem}|"' (Set|Get) This will initialise the connection and import the data.
        '''    <Summary>
        '''     (Set|Get) This will initialise the connection and import the data.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:124 </Published>
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
                Result.Why += Log & VbNewLine
            End If
            Return Result

        End Function
#End Region '(Set|Get) This will initialise the connection and import the data.

#Region "[On] |2019/07/08 18h11:042| <05.00.01> <Function> <> |.Close()|TestItem}|"' (Set|Get) This willClosing the connection
        '''    <Summary>
        '''     (Set|Get) This willClosing the connection
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:124 </Published>
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

#Region "[On] |2019/07/08 18h11:052| <05.00.02> <Function> <> |.List()|List(Of Tbl_Periode)}|"' (Set|Get) Return the entire table listed
        '''    <Summary>
        '''     (Set|Get) Return the entire table listed
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:128 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Return the entire table listed")>
        Public Function List() As List(Of Tbl_Periode)
            Dim Result As New List(Of Tbl_Periode)
            Me.Table = New Table(Me.TableName, Me.FilePath, Me.Password, False)
            For Each Row As DataRow In Me.Table.DataTable.Rows
                Dim Element As New Tbl_Periode(IIf(IsDBNull(Row.Item(0)), 0, Row.Item(0)),
IIf(IsDBNull(Row.Item(1)), "", Row.Item(1)),
IIf(IsDBNull(Row.Item(2)), New DateTime(1970, 1, 1), Row.Item(2)),
IIf(IsDBNull(Row.Item(3)), New DateTime(1970, 1, 1), Row.Item(3)),
IIf(IsDBNull(Row.Item(4)), 0, Row.Item(4)),
IIf(IsDBNull(Row.Item(5)), "", Row.Item(5)),
IIf(IsDBNull(Row.Item(6)), "", Row.Item(6)),
IIf(IsDBNull(Row.Item(7)), "", Row.Item(7)),
IIf(IsDBNull(Row.Item(8)), "", Row.Item(8)),
IIf(IsDBNull(Row.Item(9)), "", Row.Item(9)),
IIf(IsDBNull(Row.Item(10)), "", Row.Item(10)),
      IIf(IsDBNull(Row.Item(11)), "", Row.Item(11)))
                Element.Reset(Table.Line)
                Result.Add(Element)
            Next
            Return Result
        End Function
#End Region '(Set|Get) Return the entire table listed

#Region "[On] |2019/07/08 18h11:059| <05.00.03> <Function> <> |.SearchByName()|List(Of Tbl_Periode)}|"' (Set|Get) Search for each property that match the Search String.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search String.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:128 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Search for each property that match the Search String.")>
        Public Shared Function SearchByName(ByVal Search As String) As List(Of Tbl_Periode)
            Dim Result As New List(Of Tbl_Periode)
            Dim C As New Tbl_Periode
            For Each Element As Tbl_Periode In C.List
                If Element.Code.Tolower() = Search.Tolower() Or Element.Français.Tolower() = Search.Tolower() Or Element.English.Tolower() = Search.Tolower() Or Element.Italian.Tolower() = Search.Tolower() Or Element.German.Tolower() = Search.Tolower() Or Element.Spanish.Tolower() = Search.Tolower() Or Element.Portuguese.Tolower() = Search.Tolower() Or Element.Russian.Tolower() = Search.Tolower() Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search String.

#Region "[On] |2019/07/08 18h11:066| <05.00.04> <Function> <> |.SearchByID()|List(Of Tbl_Periode)}|"' (Set|Get) Search for each property that match the Search Id.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search Id.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:128 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Search for each property that match the Search Id.")>
        Public Shared Function SearchByID(ByVal Search As Double) As List(Of Tbl_Periode)
            Dim Result As New List(Of Tbl_Periode)
            Dim C As New Tbl_Periode
            For Each Element As Tbl_Periode In C.List
                If Val(Element.ID) = Search Or Val(Element.N_Entries) = Search Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search Id.

#Region "[On] |2019/07/08 18h11:073| <05.00.05> <Function> <> |.SearchByDate()|List(Of Tbl_Periode)}|"' (Set|Get) Search for each property that match the Search Id.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search Id.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:130 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Search for each property that match the Search Id.")>
        Public Shared Function SearchByDate(ByVal Search As DateTime) As List(Of Tbl_Periode)
            Dim Result As New List(Of Tbl_Periode)
            Dim C As New Tbl_Periode
            For Each Element As Tbl_Periode In C.List
                If Element.Start = Search Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search Id.

#Region "[On] |2019/07/08 18h11:080| <05.00.06> <Function> <> |.SearchByDateRange()|List(Of Tbl_Periode)}|"' (Set|Get) Search for each property that match the Search Id.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search Id.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:130 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>    ''' <param name="From_Date">All element from this date and this date included.</param>
        ''' <param name="Until_Date">All element before and including this date.</param>

        <Browsable(True), Description("(Set|Get) Search for each property that match the Search Id.")>
        Public Shared Function SearchByDateRange(ByVal From_Date As DateTime,
ByVal Until_Date As DateTime) As List(Of Tbl_Periode)
            Dim Result As New List(Of Tbl_Periode)
            Dim C As New Tbl_Periode
            For Each Element As Tbl_Periode In C.List
                If (Element.Start) >= From_Date And (Element.Start) <= Until_Date Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search Id.

#Region "[On] |2019/07/08 18h11:087| <05.00.07> <Function> <> |.ToString()|String}|"' (Set|Get) The function ToString.
        '''    <Summary>
        '''     (Set|Get) The function ToString.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:130 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The function ToString.")>
        Public Overrides Function ToString() As String
            Return Me.ID
        End Function
#End Region '(Set|Get) The function ToString.

#Region "[On] |2019/07/08 18h11:104| <05.00.08> <Function> <> |.CheckConnection()|Boolean}|"' (Set|Get) Evaluate the connection to the DataBase
        '''    <Summary>
        '''     (Set|Get) Evaluate the connection to the DataBase
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:130 </Published>
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
                    Me.Connector = New LineInfo(FilePath, Password)
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
            Log += Message & VbNewLine
            Return General_Status

        End Function
#End Region '(Set|Get) Evaluate the connection to the DataBase

#End Region
#Region "<6> [Runtime]{12}"
#Region "[On] |2019/07/08 18h11:112| <15.00.00> <Runtime> <> |.Table()|Table"' (Set|Get) The Table.
        '''    <Summary>
        '''     (Set|Get) The Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:130 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Table.")>
        Public Table As Table
#End Region '(Set|Get) The Table.

#Region "[On] |2019/07/08 18h11:119| <15.00.01> <Runtime> <> |.Line()|String"' (Set|Get) The Connection String To the Table.
        '''    <Summary>
        '''     (Set|Get) The Connection String To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:130 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Connection String To the Table.")>
        Public Line As String
#End Region '(Set|Get) The Connection String To the Table.

#Region "[On] |2019/07/08 18h11:126| <15.00.02> <Runtime> <> |.FilePath()|String"' (Set|Get) The FilePath To the Table.
        '''    <Summary>
        '''     (Set|Get) The FilePath To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:131 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The FilePath To the Table.")>
        Public FilePath As String
#End Region '(Set|Get) The FilePath To the Table.

#Region "[On] |2019/07/08 18h11:134| <15.00.03> <Runtime> <> |.Password()|String"' (Set|Get) The Password To the Table.
        '''    <Summary>
        '''     (Set|Get) The Password To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:131 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Password To the Table.")>
        Public Password As String
#End Region '(Set|Get) The Password To the Table.

#Region "[On] |2019/07/08 18h11:141| <15.00.04> <Runtime> <> |.UseSQL()|Boolean"' (Set|Get) Determines if the Database Connection is of type SQL.
        '''    <Summary>
        '''     (Set|Get) Determines if the Database Connection is of type SQL.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:131 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Determines if the Database Connection is of type SQL.")>
        Public UseSQL As Boolean
#End Region '(Set|Get) Determines if the Database Connection is of type SQL.

#Region "[On] |2019/07/08 18h11:149| <15.00.05> <Runtime> <> |.TableName()|String"' (Set|Get) The name of the Table.
        '''    <Summary>
        '''     (Set|Get) The name of the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:131 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The name of the Table.")>
        Public TableName As String
#End Region '(Set|Get) The name of the Table.

#Region "[On] |2019/07/08 18h11:156| <15.00.06> <Runtime> <> |.Con()|OleDb.OleDbConnection"' (Set|Get) The Con To the Table.
        '''    <Summary>
        '''     (Set|Get) The Con To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:131 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Con To the Table.")>
        Public Con As OleDb.OleDbConnection
#End Region '(Set|Get) The Con To the Table.

#Region "[On] |2019/07/08 18h11:160| <15.00.07> <Runtime> <> |.Cmd()|OleDb.OleDbCommand"' (Set|Get) The Cmd To the Table.
        '''    <Summary>
        '''     (Set|Get) The Cmd To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:131 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Cmd To the Table.")>
        Public Cmd As OleDb.OleDbCommand
#End Region '(Set|Get) The Cmd To the Table.

#Region "[On] |2019/07/08 18h11:167| <15.00.08> <Runtime> <> |.DataReader()|OleDb.OleDbDataReader"' (Set|Get) The DataReader To the Table.
        '''    <Summary>
        '''     (Set|Get) The DataReader To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:132 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The DataReader To the Table.")>
        Public DataReader As OleDb.OleDbDataReader
#End Region '(Set|Get) The DataReader To the Table.

#Region "[On] |2019/07/08 18h11:176| <15.00.09> <Runtime> <> |.DataAdapter()|OleDb.OleDbDataAdapter"' (Set|Get) The DataAdapter To the Table.
        '''    <Summary>
        '''     (Set|Get) The DataAdapter To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:132 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The DataAdapter To the Table.")>
        Public DataAdapter As OleDb.OleDbDataAdapter
#End Region '(Set|Get) The DataAdapter To the Table.

#Region "[On] |2019/07/08 18h11:184| <15.00.10> <Runtime> <> |.Connector()|LineInfo"' (Set|Get) The Connector To the Table.
        '''    <Summary>
        '''     (Set|Get) The Connector To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:132 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Connector To the Table.")>
        Public Connector As LineInfo
#End Region '(Set|Get) The Connector To the Table.

#Region "[On] |2019/07/08 18h11:191| <15.00.11> <Runtime> <> |.Log()|String"' (Set|Get) The Log To the Table.
        '''    <Summary>
        '''     (Set|Get) The Log To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:132 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Log To the Table.")>
        Public Log As String
#End Region '(Set|Get) The Log To the Table.

#End Region
#Region "<7> [Loader]{2}"
#Region "[On] |2019/07/08 18h11:204| <06.00.00> <Loader> <> |.Empty()|Function}|"' (Set|Get) The sub Empty.
        '''    <Summary>
        '''     (Set|Get) The sub Empty.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:132 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The sub Empty.")>
        Public Sub New()
            Reset
        End Sub
#End Region '(Set|Get) The sub Empty.

#Region "[On] |2019/07/08 18h11:206| <06.00.01> <Loader> <> |.Filled()|Function}|"' (Set|Get) The sub Filled.
        '''    <Summary>
        '''     (Set|Get) The sub Filled.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:132 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>    ''' <param name="ID">(Set|Get) The ID as Integer.</param>
        ''' <param name="Code">(Set|Get) The Code as String.</param>
        ''' <param name="Start">(Set|Get) The Start as DateTime.</param>
        ''' <param name="End">(Set|Get) The End as DateTime.</param>
        ''' <param name="N_Entries">(Set|Get) The N_Entries as Integer.</param>
        ''' <param name="Français">(Set|Get) The Français as String.</param>
        ''' <param name="English">(Set|Get) The English as String.</param>
        ''' <param name="Italian">(Set|Get) The Italian as String.</param>
        ''' <param name="German">(Set|Get) The German as String.</param>
        ''' <param name="Spanish">(Set|Get) The Spanish as String.</param>
        ''' <param name="Portuguese">(Set|Get) The Portuguese as String.</param>
        ''' <param name="Russian">(Set|Get) The Russian as String.</param>

        <Browsable(True), Description("(Set|Get) The sub Filled.")>
        Public Sub New(ByVal ID As Integer,
ByVal Code As String,
ByVal Start As DateTime,
ByVal [End] As DateTime,
ByVal N_Entries As Integer,
ByVal Français As String,
ByVal English As String,
ByVal Italian As String,
ByVal German As String,
ByVal Spanish As String,
ByVal Portuguese As String,
ByVal Russian As String)
            With Me
                Clear()
                Reset()
                .ID = ID
                .Code = Code
                .Start = Start
                .[End] = [End]
                .N_Entries = N_Entries
                .Français = Français
                .English = English
                .Italian = Italian
                .German = German
                .Spanish = Spanish
                .Portuguese = Portuguese
                .Russian = Russian
            End With

        End Sub
#End Region '(Set|Get) The sub Filled.

#End Region
    End Class
#End Region

#Region "[On] |2019/07/08 18h11:311| <08.00.00> <Class> <> |.Tbl_PieceType|Class|{37} |Production Cost : 44.5|Selling Price : 111.25|"' Class created automatically by SmartOffice (c)Copyright 2019.
    '''    <Summary>
    '''     Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Tbl_PieceType
    '''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
    '''    Contributor Information : ||
    '''    Creation Date :           2019/07/08 18h11:311
    '''    |Schema|
    '''    |ID| |ObjectType |{Quantity}||UnitPrice||Total
    '''    |00| |Importation|{0}||1| |0
    '''    |01| |Properties |{10}||0.8| |8
    '''    |02| |Enumeration|{1}||0.4| |0.4
    '''    |03| |Structure  |{0}||0.4| |0
    '''    |04| |Sub        |{5}||1.2| |6
    '''    |05| |Function   |{7}||1.6| |11.2
    '''    |06| |Runtime    |{12}||0.4| |4.8
    '''    |07| |Loader     |{2}||0.8| |1.6
    '''    |08| |Class      |{0}||2| |0
    '''    |09| |Constante  |{0}||0.4| |0
    '''    |10| |Event      |{0}||1.2| |0
    '''    |11| |Members    |{10}||0.5| |5
    '''    |12| |Parameter  |{15}||0.5| |7.5
    '''    |Production Cost             |44.5
    '''    |Selling Price without VAT   |111.25
    '''    |Total TVA                   |8.57
    '''    |Grand Total                 |119.82
    '''    |/Schema|
    '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
    '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
    '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
    '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:143 </Published>
    '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
    '''    </Summary>
    Public Class Tbl_PieceType
#Region "<1> [Property]{10}"
#Region "[On] |2019/07/08 18h11:311| <01.00.00> <Property> <Columns> |.Code()|String|"' (Set|Get) The Code as String.
        Private _Code As String
        '''    <Summary>
        '''     (Set|Get) The Code as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:143 </Published>
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

#Region "[On] |2019/07/08 18h11:318| <01.00.01> <Property> <Columns> |.N_Entries()|Integer|"' (Set|Get) The N_Entries as Integer.
        Private _N_Entries As Integer
        '''    <Summary>
        '''     (Set|Get) The N_Entries as Integer.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:144 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The N_Entries as Integer.")>
        Public Property N_Entries() As Integer
            Get
                Return _N_Entries
            End Get
            Set(ByVal Value As Integer)
                _N_Entries = Value
            End Set
        End Property
#End Region '(Set|Get) The N_Entries as Integer.

#Region "[On] |2019/07/08 18h11:324| <01.00.02> <Property> <Columns> |.ID()|Integer|"' (Set|Get) The ID as Integer.
        Private _ID As Integer
        '''    <Summary>
        '''     (Set|Get) The ID as Integer.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:144 </Published>
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

#Region "[On] |2019/07/08 18h11:331| <01.00.03> <Property> <Columns> |.Français()|String|"' (Set|Get) The Français as String.
        Private _Français As String
        '''    <Summary>
        '''     (Set|Get) The Français as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:144 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Français as String.")>
        Public Property Français() As String
            Get
                Return _Français
            End Get
            Set(ByVal Value As String)
                _Français = Value
            End Set
        End Property
#End Region '(Set|Get) The Français as String.

#Region "[On] |2019/07/08 18h11:338| <01.00.04> <Property> <Columns> |.English()|String|"' (Set|Get) The English as String.
        Private _English As String
        '''    <Summary>
        '''     (Set|Get) The English as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:144 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The English as String.")>
        Public Property English() As String
            Get
                Return _English
            End Get
            Set(ByVal Value As String)
                _English = Value
            End Set
        End Property
#End Region '(Set|Get) The English as String.

#Region "[On] |2019/07/08 18h11:344| <01.00.05> <Property> <Columns> |.Italian()|String|"' (Set|Get) The Italian as String.
        Private _Italian As String
        '''    <Summary>
        '''     (Set|Get) The Italian as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:144 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Italian as String.")>
        Public Property Italian() As String
            Get
                Return _Italian
            End Get
            Set(ByVal Value As String)
                _Italian = Value
            End Set
        End Property
#End Region '(Set|Get) The Italian as String.

#Region "[On] |2019/07/08 18h11:350| <01.00.06> <Property> <Columns> |.German()|String|"' (Set|Get) The German as String.
        Private _German As String
        '''    <Summary>
        '''     (Set|Get) The German as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:145 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The German as String.")>
        Public Property German() As String
            Get
                Return _German
            End Get
            Set(ByVal Value As String)
                _German = Value
            End Set
        End Property
#End Region '(Set|Get) The German as String.

#Region "[On] |2019/07/08 18h11:355| <01.00.07> <Property> <Columns> |.Spanish()|String|"' (Set|Get) The Spanish as String.
        Private _Spanish As String
        '''    <Summary>
        '''     (Set|Get) The Spanish as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:145 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Spanish as String.")>
        Public Property Spanish() As String
            Get
                Return _Spanish
            End Get
            Set(ByVal Value As String)
                _Spanish = Value
            End Set
        End Property
#End Region '(Set|Get) The Spanish as String.

#Region "[On] |2019/07/08 18h11:361| <01.00.08> <Property> <Columns> |.Portuguese()|String|"' (Set|Get) The Portuguese as String.
        Private _Portuguese As String
        '''    <Summary>
        '''     (Set|Get) The Portuguese as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:145 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Portuguese as String.")>
        Public Property Portuguese() As String
            Get
                Return _Portuguese
            End Get
            Set(ByVal Value As String)
                _Portuguese = Value
            End Set
        End Property
#End Region '(Set|Get) The Portuguese as String.

#Region "[On] |2019/07/08 18h11:372| <01.00.09> <Property> <Columns> |.Russian()|String|"' (Set|Get) The Russian as String.
        Private _Russian As String
        '''    <Summary>
        '''     (Set|Get) The Russian as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:145 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Russian as String.")>
        Public Property Russian() As String
            Get
                Return _Russian
            End Get
            Set(ByVal Value As String)
                _Russian = Value
            End Set
        End Property
#End Region '(Set|Get) The Russian as String.

#End Region
#Region "<2> [Enumeration]{1}"
#Region "[On] |2019/07/08 18h11:378| <02.00.00> <Enumeration> <> |.Schema()|Enumeration{9}|"' (Set|Get) The enumeration of Schema.
        '''    <Summary>
        '''     (Set|Get) The enumeration of Schema.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:145 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The enumeration of Schema.")>
        Enum Schema
            ''' <summary>(Set|Get) The Code as String.</summary>
            [Code] = 0
            ''' <summary>(Set|Get) The N_Entries as Integer.</summary>
            [N_Entries] = 1
            ''' <summary>(Set|Get) The ID as Integer.</summary>
            [ID] = 2
            ''' <summary>(Set|Get) The Français as String.</summary>
            [Français] = 3
            ''' <summary>(Set|Get) The English as String.</summary>
            [English] = 4
            ''' <summary>(Set|Get) The Italian as String.</summary>
            [Italian] = 5
            ''' <summary>(Set|Get) The German as String.</summary>
            [German] = 6
            ''' <summary>(Set|Get) The Spanish as String.</summary>
            [Spanish] = 7
            ''' <summary>(Set|Get) The Portuguese as String.</summary>
            [Portuguese] = 8
            ''' <summary>(Set|Get) The Russian as String.</summary>
            [Russian] = 9
        End Enum
#End Region '(Set|Get) The enumeration of Schema.

#End Region
#Region "<4> [Sub]{5}"
#Region "[On] |2019/07/08 18h11:385| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
        '''    <Summary>
        '''     (Set|Get) This will reinitialize the class element.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:146 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will reinitialize the class element.")>
        Public Sub Clear()
            With Me
                .Code = Nothing
                .N_Entries = 0
                .ID = 0
                .Français = Nothing
                .English = Nothing
                .Italian = Nothing
                .German = Nothing
                .Spanish = Nothing
                .Portuguese = Nothing
                .Russian = Nothing
            End With
        End Sub
#End Region '(Set|Get) This will reinitialize the class element.

#Region "[On] |2019/07/08 18h11:392| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
        '''    <Summary>
        '''     (Set|Get) This will reinitialize the variables of this class.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:146 </Published>
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
                    TableName = "Tbl_PieceType"
                    Line = Connector.Line
                    UseSQL = False
                Else
                    FilePath = My.Settings.Db_Accountis_FilePath
                    Password = My.Settings.Db_Accountis_Password
                    Me.Line = My.Settings.Db_Accountis_Line
                    TableName = "Tbl_PieceType"
                    UseSQL = False
                End If
            Else
                If IsNothing(FilePath) Then
                    FilePath = My.Settings.Db_Accountis_FilePath
                End If
                If FilePath.Length < 1 Then
                    FilePath = My.Settings.Db_Accountis_FilePath
                End If
                FilePath = My.Settings.Db_Accountis_FilePath
                Password = My.Settings.Db_Accountis_Password
                Me.Line = My.Settings.Db_Accountis_Line
                TableName = "Tbl_PieceType"
                UseSQL = False
            End If

        End Sub
#End Region '(Set|Get) This will reinitialize the variables of this class.

#Region "[On] |2019/07/08 18h11:399| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
        '''    <Summary>
        '''     (Set|Get) This will add a new row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:146 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will add a new row in the table.")>
        Public Sub Add()
            Try
                Dim Str As String = Nothing
                Str = "Insert Into [Tbl_PieceType] (
`Code`, 
`N_Entries`, 
`ID`, 
`Français`, 
`English`, 
`Italian`, 
`German`, 
`Spanish`, 
`Portuguese`, 
`Russian`) Values (@0, @1, @2, @3, @4, @5, @6, @7, @8, @9)"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@0", Me.Code)
                Cmd.Parameters.AddWithValue("@1", Me.N_Entries)
                Cmd.Parameters.AddWithValue("@2", Me.ID)
                Cmd.Parameters.AddWithValue("@3", Me.Français)
                Cmd.Parameters.AddWithValue("@4", Me.English)
                Cmd.Parameters.AddWithValue("@5", Me.Italian)
                Cmd.Parameters.AddWithValue("@6", Me.German)
                Cmd.Parameters.AddWithValue("@7", Me.Spanish)
                Cmd.Parameters.AddWithValue("@8", Me.Portuguese)
                Cmd.Parameters.AddWithValue("@9", Me.Russian)
                If Cmd.ExecuteNonQuery >= 0 Then
                Else
                    Msgbox("Element not Addd")
                End If
            Catch ex As Exception
            Finally
                Close(True)
            End Try

        End Sub
#End Region '(Set|Get) This will add a new row in the table.

#Region "[On] |2019/07/08 18h11:406| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
        '''    <Summary>
        '''     (Set|Get) This will update a row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:146 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will update a row in the table.")>
        Public Sub Save()
            Try
                Dim Str As String = Nothing
                Str = "UPDATE [Tbl_PieceType] SET N_Entries = @N_Entries, ID = @ID, Français = @Français, English = @English, Italian = @Italian, German = @German, Spanish = @Spanish, Portuguese = @Portuguese, Russian = @Russian WHERE Code = @Code"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@N_Entries", N_Entries)
                Cmd.Parameters.AddWithValue("@ID", ID)
                Cmd.Parameters.AddWithValue("@Français", Français)
                Cmd.Parameters.AddWithValue("@English", English)
                Cmd.Parameters.AddWithValue("@Italian", Italian)
                Cmd.Parameters.AddWithValue("@German", German)
                Cmd.Parameters.AddWithValue("@Spanish", Spanish)
                Cmd.Parameters.AddWithValue("@Portuguese", Portuguese)
                Cmd.Parameters.AddWithValue("@Russian", Russian)
                Cmd.Parameters.AddWithValue("@Code", Code)
                If Cmd.ExecuteNonQuery >= 0 Then
                Else
                    Msgbox("Element not Saved")
                End If
            Catch ex As Exception
            Finally
                Close(True)
            End Try

        End Sub
#End Region '(Set|Get) This will update a row in the table.

#Region "[On] |2019/07/08 18h11:413| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
        '''    <Summary>
        '''     (Set|Get) This will Delete a row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:146 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will Delete a row in the table.")>
        Public Sub Delete()
            Try
                Dim Str As String = Nothing
                Str = "Delete From [Tbl_PieceType] WHERE Code =@Code"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@Code", Code)
                If Cmd.ExecuteNonQuery >= 0 Then
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
#Region "[On] |2019/07/08 18h11:419| <05.00.00> <Function> <> |.Open()|TestItem}|"' (Set|Get) This will initialise the connection and import the data.
        '''    <Summary>
        '''     (Set|Get) This will initialise the connection and import the data.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:146 </Published>
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
                Result.Why += Log & VbNewLine
            End If
            Return Result

        End Function
#End Region '(Set|Get) This will initialise the connection and import the data.

#Region "[On] |2019/07/08 18h11:426| <05.00.01> <Function> <> |.Close()|TestItem}|"' (Set|Get) This willClosing the connection
        '''    <Summary>
        '''     (Set|Get) This willClosing the connection
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:146 </Published>
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

#Region "[On] |2019/07/08 18h11:434| <05.00.02> <Function> <> |.List()|List(Of Tbl_PieceType)}|"' (Set|Get) Return the entire table listed
        '''    <Summary>
        '''     (Set|Get) Return the entire table listed
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:146 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Return the entire table listed")>
        Public Function List() As List(Of Tbl_PieceType)
            Dim Result As New List(Of Tbl_PieceType)
            Me.Table = New Table(Me.TableName, Me.FilePath, Me.Password, False)
            For Each Row As DataRow In Me.Table.DataTable.Rows
                Dim Element As New Tbl_PieceType(IIf(IsDBNull(Row.Item(0)), "", Row.Item(0)),
IIf(IsDBNull(Row.Item(1)), 0, Row.Item(1)),
IIf(IsDBNull(Row.Item(2)), 0, Row.Item(2)),
IIf(IsDBNull(Row.Item(3)), "", Row.Item(3)),
IIf(IsDBNull(Row.Item(4)), "", Row.Item(4)),
IIf(IsDBNull(Row.Item(5)), "", Row.Item(5)),
IIf(IsDBNull(Row.Item(6)), "", Row.Item(6)),
IIf(IsDBNull(Row.Item(7)), "", Row.Item(7)),
IIf(IsDBNull(Row.Item(8)), "", Row.Item(8)),
      IIf(IsDBNull(Row.Item(9)), "", Row.Item(9)))
                Element.Reset(Table.Line)
                Result.Add(Element)
            Next
            Return Result
        End Function
#End Region '(Set|Get) Return the entire table listed

#Region "[On] |2019/07/08 18h11:441| <05.00.03> <Function> <> |.SearchByName()|List(Of Tbl_PieceType)}|"' (Set|Get) Search for each property that match the Search String.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search String.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:147 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Search for each property that match the Search String.")>
        Public Shared Function SearchByName(ByVal Search As String) As List(Of Tbl_PieceType)
            Dim Result As New List(Of Tbl_PieceType)
            Dim C As New Tbl_PieceType
            For Each Element As Tbl_PieceType In C.List
                If Element.Code.Tolower() = Search.Tolower() Or Element.Français.Tolower() = Search.Tolower() Or Element.English.Tolower() = Search.Tolower() Or Element.Italian.Tolower() = Search.Tolower() Or Element.German.Tolower() = Search.Tolower() Or Element.Spanish.Tolower() = Search.Tolower() Or Element.Portuguese.Tolower() = Search.Tolower() Or Element.Russian.Tolower() = Search.Tolower() Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search String.

#Region "[On] |2019/07/08 18h11:447| <05.00.04> <Function> <> |.SearchByID()|List(Of Tbl_PieceType)}|"' (Set|Get) Search for each property that match the Search Id.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search Id.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:147 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Search for each property that match the Search Id.")>
        Public Shared Function SearchByID(ByVal Search As Double) As List(Of Tbl_PieceType)
            Dim Result As New List(Of Tbl_PieceType)
            Dim C As New Tbl_PieceType
            For Each Element As Tbl_PieceType In C.List
                If Val(Element.N_Entries) = Search Or Val(Element.ID) = Search Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search Id.

#Region "[On] |2019/07/08 18h11:454| <05.00.05> <Function> <> |.ToString()|String}|"' (Set|Get) The function ToString.
        '''    <Summary>
        '''     (Set|Get) The function ToString.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:147 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The function ToString.")>
        Public Overrides Function ToString() As String
            Return Me.Code
        End Function
#End Region '(Set|Get) The function ToString.

#Region "[On] |2019/07/08 18h11:461| <05.00.06> <Function> <> |.CheckConnection()|Boolean}|"' (Set|Get) Evaluate the connection to the DataBase
        '''    <Summary>
        '''     (Set|Get) Evaluate the connection to the DataBase
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:147 </Published>
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
                    Me.Connector = New LineInfo(FilePath, Password)
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
            Log += Message & VbNewLine
            Return General_Status

        End Function
#End Region '(Set|Get) Evaluate the connection to the DataBase

#End Region
#Region "<6> [Runtime]{12}"
#Region "[On] |2019/07/08 18h11:476| <15.00.00> <Runtime> <> |.Table()|Table"' (Set|Get) The Table.
        '''    <Summary>
        '''     (Set|Get) The Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:147 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Table.")>
        Public Table As Table
#End Region '(Set|Get) The Table.

#Region "[On] |2019/07/08 18h11:484| <15.00.01> <Runtime> <> |.Line()|String"' (Set|Get) The Connection String To the Table.
        '''    <Summary>
        '''     (Set|Get) The Connection String To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:147 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Connection String To the Table.")>
        Public Line As String
#End Region '(Set|Get) The Connection String To the Table.

#Region "[On] |2019/07/08 18h11:492| <15.00.02> <Runtime> <> |.FilePath()|String"' (Set|Get) The FilePath To the Table.
        '''    <Summary>
        '''     (Set|Get) The FilePath To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:149 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The FilePath To the Table.")>
        Public FilePath As String
#End Region '(Set|Get) The FilePath To the Table.

#Region "[On] |2019/07/08 18h11:499| <15.00.03> <Runtime> <> |.Password()|String"' (Set|Get) The Password To the Table.
        '''    <Summary>
        '''     (Set|Get) The Password To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:149 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Password To the Table.")>
        Public Password As String
#End Region '(Set|Get) The Password To the Table.

#Region "[On] |2019/07/08 18h11:506| <15.00.04> <Runtime> <> |.UseSQL()|Boolean"' (Set|Get) Determines if the Database Connection is of type SQL.
        '''    <Summary>
        '''     (Set|Get) Determines if the Database Connection is of type SQL.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:149 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Determines if the Database Connection is of type SQL.")>
        Public UseSQL As Boolean
#End Region '(Set|Get) Determines if the Database Connection is of type SQL.

#Region "[On] |2019/07/08 18h11:513| <15.00.05> <Runtime> <> |.TableName()|String"' (Set|Get) The name of the Table.
        '''    <Summary>
        '''     (Set|Get) The name of the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:149 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The name of the Table.")>
        Public TableName As String
#End Region '(Set|Get) The name of the Table.

#Region "[On] |2019/07/08 18h11:520| <15.00.06> <Runtime> <> |.Con()|OleDb.OleDbConnection"' (Set|Get) The Con To the Table.
        '''    <Summary>
        '''     (Set|Get) The Con To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:149 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Con To the Table.")>
        Public Con As OleDb.OleDbConnection
#End Region '(Set|Get) The Con To the Table.

#Region "[On] |2019/07/08 18h11:523| <15.00.07> <Runtime> <> |.Cmd()|OleDb.OleDbCommand"' (Set|Get) The Cmd To the Table.
        '''    <Summary>
        '''     (Set|Get) The Cmd To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:149 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Cmd To the Table.")>
        Public Cmd As OleDb.OleDbCommand
#End Region '(Set|Get) The Cmd To the Table.

#Region "[On] |2019/07/08 18h11:530| <15.00.08> <Runtime> <> |.DataReader()|OleDb.OleDbDataReader"' (Set|Get) The DataReader To the Table.
        '''    <Summary>
        '''     (Set|Get) The DataReader To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:149 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The DataReader To the Table.")>
        Public DataReader As OleDb.OleDbDataReader
#End Region '(Set|Get) The DataReader To the Table.

#Region "[On] |2019/07/08 18h11:537| <15.00.09> <Runtime> <> |.DataAdapter()|OleDb.OleDbDataAdapter"' (Set|Get) The DataAdapter To the Table.
        '''    <Summary>
        '''     (Set|Get) The DataAdapter To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:149 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The DataAdapter To the Table.")>
        Public DataAdapter As OleDb.OleDbDataAdapter
#End Region '(Set|Get) The DataAdapter To the Table.

#Region "[On] |2019/07/08 18h11:545| <15.00.10> <Runtime> <> |.Connector()|LineInfo"' (Set|Get) The Connector To the Table.
        '''    <Summary>
        '''     (Set|Get) The Connector To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:150 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Connector To the Table.")>
        Public Connector As LineInfo
#End Region '(Set|Get) The Connector To the Table.

#Region "[On] |2019/07/08 18h11:552| <15.00.11> <Runtime> <> |.Log()|String"' (Set|Get) The Log To the Table.
        '''    <Summary>
        '''     (Set|Get) The Log To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:150 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Log To the Table.")>
        Public Log As String
#End Region '(Set|Get) The Log To the Table.

#End Region
#Region "<7> [Loader]{2}"
#Region "[On] |2019/07/08 18h11:559| <06.00.00> <Loader> <> |.Empty()|Function}|"' (Set|Get) The sub Empty.
        '''    <Summary>
        '''     (Set|Get) The sub Empty.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:150 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The sub Empty.")>
        Public Sub New()
            Reset
        End Sub
#End Region '(Set|Get) The sub Empty.

#Region "[On] |2019/07/08 18h11:561| <06.00.01> <Loader> <> |.Filled()|Function}|"' (Set|Get) The sub Filled.
        '''    <Summary>
        '''     (Set|Get) The sub Filled.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:150 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>    ''' <param name="Code">(Set|Get) The Code as String.</param>
        ''' <param name="N_Entries">(Set|Get) The N_Entries as Integer.</param>
        ''' <param name="ID">(Set|Get) The ID as Integer.</param>
        ''' <param name="Français">(Set|Get) The Français as String.</param>
        ''' <param name="English">(Set|Get) The English as String.</param>
        ''' <param name="Italian">(Set|Get) The Italian as String.</param>
        ''' <param name="German">(Set|Get) The German as String.</param>
        ''' <param name="Spanish">(Set|Get) The Spanish as String.</param>
        ''' <param name="Portuguese">(Set|Get) The Portuguese as String.</param>
        ''' <param name="Russian">(Set|Get) The Russian as String.</param>

        <Browsable(True), Description("(Set|Get) The sub Filled.")>
        Public Sub New(ByVal Code As String,
ByVal N_Entries As Integer,
ByVal ID As Integer,
ByVal Français As String,
ByVal English As String,
ByVal Italian As String,
ByVal German As String,
ByVal Spanish As String,
ByVal Portuguese As String,
ByVal Russian As String)
            With Me
                Clear()
                Reset()
                .Code = Code
                .N_Entries = N_Entries
                .ID = ID
                .Français = Français
                .English = English
                .Italian = Italian
                .German = German
                .Spanish = Spanish
                .Portuguese = Portuguese
                .Russian = Russian
            End With

        End Sub
#End Region '(Set|Get) The sub Filled.

#End Region
    End Class
#End Region

#Region "[On] |2019/07/08 18h11:678| <08.00.00> <Class> <> |.Tbl_Plan_Comptable|Class|{45} |Production Cost : 58.9|Selling Price : 147.25|"' Class created automatically by SmartOffice (c)Copyright 2019.
    '''    <Summary>
    '''     Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Tbl_Plan_Comptable
    '''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
    '''    Contributor Information : ||
    '''    Creation Date :           2019/07/08 18h11:678
    '''    |Schema|
    '''    |ID| |ObjectType |{Quantity}||UnitPrice||Total
    '''    |00| |Importation|{0}||1| |0
    '''    |01| |Properties |{18}||0.8| |14.4
    '''    |02| |Enumeration|{1}||0.4| |0.4
    '''    |03| |Structure  |{0}||0.4| |0
    '''    |04| |Sub        |{5}||1.2| |6
    '''    |05| |Function   |{7}||1.6| |11.2
    '''    |06| |Runtime    |{12}||0.4| |4.8
    '''    |07| |Loader     |{2}||0.8| |1.6
    '''    |08| |Class      |{0}||2| |0
    '''    |09| |Constante  |{0}||0.4| |0
    '''    |10| |Event      |{0}||1.2| |0
    '''    |11| |Members    |{18}||0.5| |9
    '''    |12| |Parameter  |{23}||0.5| |11.5
    '''    |Production Cost             |58.9
    '''    |Selling Price without VAT   |147.25
    '''    |Total TVA                   |11.34
    '''    |Grand Total                 |158.59
    '''    |/Schema|
    '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
    '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
    '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
    '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:157 </Published>
    '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
    '''    </Summary>
    Public Class Tbl_Plan_Comptable
#Region "<1> [Property]{18}"
#Region "[On] |2019/07/08 18h11:679| <01.00.00> <Property> <Columns> |.N()|Integer|"' (Set|Get) The N as Integer.
        Private _N As Integer
        '''    <Summary>
        '''     (Set|Get) The N as Integer.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:157 </Published>
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

#Region "[On] |2019/07/08 18h11:685| <01.00.01> <Property> <Columns> |.Group_Positif()|Integer|"' (Set|Get) The Group_Positif as Integer.
        Private _Group_Positif As Integer
        '''    <Summary>
        '''     (Set|Get) The Group_Positif as Integer.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:157 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Group_Positif as Integer.")>
        Public Property Group_Positif() As Integer
            Get
                Return _Group_Positif
            End Get
            Set(ByVal Value As Integer)
                _Group_Positif = Value
            End Set
        End Property
#End Region '(Set|Get) The Group_Positif as Integer.

#Region "[On] |2019/07/08 18h11:691| <01.00.02> <Property> <Columns> |.Group_Negatif()|Integer|"' (Set|Get) The Group_Negatif as Integer.
        Private _Group_Negatif As Integer
        '''    <Summary>
        '''     (Set|Get) The Group_Negatif as Integer.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:157 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Group_Negatif as Integer.")>
        Public Property Group_Negatif() As Integer
            Get
                Return _Group_Negatif
            End Get
            Set(ByVal Value As Integer)
                _Group_Negatif = Value
            End Set
        End Property
#End Region '(Set|Get) The Group_Negatif as Integer.

#Region "[On] |2019/07/08 18h11:698| <01.00.03> <Property> <Columns> |.Currency()|String|"' (Set|Get) The Currency as String.
        Private _Currency As String
        '''    <Summary>
        '''     (Set|Get) The Currency as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:158 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Currency as String.")>
        Public Property Currency() As String
            Get
                Return _Currency
            End Get
            Set(ByVal Value As String)
                _Currency = Value
            End Set
        End Property
#End Region '(Set|Get) The Currency as String.

#Region "[On] |2019/07/08 18h11:704| <01.00.04> <Property> <Columns> |.Opening()|Double|"' (Set|Get) The Opening as Double.
        Private _Opening As Double
        '''    <Summary>
        '''     (Set|Get) The Opening as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:158 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Opening as Double.")>
        Public Property Opening() As Double
            Get
                Return _Opening
            End Get
            Set(ByVal Value As Double)
                _Opening = Value
            End Set
        End Property
#End Region '(Set|Get) The Opening as Double.

#Region "[On] |2019/07/08 18h11:710| <01.00.05> <Property> <Columns> |.Debit()|Double|"' (Set|Get) The Debit as Double.
        Private _Debit As Double
        '''    <Summary>
        '''     (Set|Get) The Debit as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:158 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Debit as Double.")>
        Public Property Debit() As Double
            Get
                Return _Debit
            End Get
            Set(ByVal Value As Double)
                _Debit = Value
            End Set
        End Property
#End Region '(Set|Get) The Debit as Double.

#Region "[On] |2019/07/08 18h11:716| <01.00.06> <Property> <Columns> |.Credit()|Double|"' (Set|Get) The Credit as Double.
        Private _Credit As Double
        '''    <Summary>
        '''     (Set|Get) The Credit as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:158 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Credit as Double.")>
        Public Property Credit() As Double
            Get
                Return _Credit
            End Get
            Set(ByVal Value As Double)
                _Credit = Value
            End Set
        End Property
#End Region '(Set|Get) The Credit as Double.

#Region "[On] |2019/07/08 18h11:723| <01.00.07> <Property> <Columns> |.Balance()|Double|"' (Set|Get) The Balance as Double.
        Private _Balance As Double
        '''    <Summary>
        '''     (Set|Get) The Balance as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:158 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Balance as Double.")>
        Public Property Balance() As Double
            Get
                Return _Balance
            End Get
            Set(ByVal Value As Double)
                _Balance = Value
            End Set
        End Property
#End Region '(Set|Get) The Balance as Double.

#Region "[On] |2019/07/08 18h11:730| <01.00.08> <Property> <Columns> |.Closing()|Integer|"' (Set|Get) The Closing as Integer.
        Private _Closing As Integer
        '''    <Summary>
        '''     (Set|Get) The Closing as Integer.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:159 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Closing as Integer.")>
        Public Property Closing() As Integer
            Get
                Return _Closing
            End Get
            Set(ByVal Value As Integer)
                _Closing = Value
            End Set
        End Property
#End Region '(Set|Get) The Closing as Integer.

#Region "[On] |2019/07/08 18h11:737| <01.00.09> <Property> <Columns> |.Variation()|Double|"' (Set|Get) The Variation as Double.
        Private _Variation As Double
        '''    <Summary>
        '''     (Set|Get) The Variation as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:159 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Variation as Double.")>
        Public Property Variation() As Double
            Get
                Return _Variation
            End Get
            Set(ByVal Value As Double)
                _Variation = Value
            End Set
        End Property
#End Region '(Set|Get) The Variation as Double.

#Region "[On] |2019/07/08 18h11:744| <01.00.10> <Property> <Columns> |.ID()|Integer|"' (Set|Get) The ID as Integer.
        Private _ID As Integer
        '''    <Summary>
        '''     (Set|Get) The ID as Integer.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:161 </Published>
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

#Region "[On] |2019/07/08 18h11:750| <01.00.11> <Property> <Columns> |.Français()|String|"' (Set|Get) The Français as String.
        Private _Français As String
        '''    <Summary>
        '''     (Set|Get) The Français as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:161 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Français as String.")>
        Public Property Français() As String
            Get
                Return _Français
            End Get
            Set(ByVal Value As String)
                _Français = Value
            End Set
        End Property
#End Region '(Set|Get) The Français as String.

#Region "[On] |2019/07/08 18h11:756| <01.00.12> <Property> <Columns> |.English()|String|"' (Set|Get) The English as String.
        Private _English As String
        '''    <Summary>
        '''     (Set|Get) The English as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:162 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The English as String.")>
        Public Property English() As String
            Get
                Return _English
            End Get
            Set(ByVal Value As String)
                _English = Value
            End Set
        End Property
#End Region '(Set|Get) The English as String.

#Region "[On] |2019/07/08 18h11:764| <01.00.13> <Property> <Columns> |.Italian()|String|"' (Set|Get) The Italian as String.
        Private _Italian As String
        '''    <Summary>
        '''     (Set|Get) The Italian as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:162 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Italian as String.")>
        Public Property Italian() As String
            Get
                Return _Italian
            End Get
            Set(ByVal Value As String)
                _Italian = Value
            End Set
        End Property
#End Region '(Set|Get) The Italian as String.

#Region "[On] |2019/07/08 18h11:778| <01.00.14> <Property> <Columns> |.German()|String|"' (Set|Get) The German as String.
        Private _German As String
        '''    <Summary>
        '''     (Set|Get) The German as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:162 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The German as String.")>
        Public Property German() As String
            Get
                Return _German
            End Get
            Set(ByVal Value As String)
                _German = Value
            End Set
        End Property
#End Region '(Set|Get) The German as String.

#Region "[On] |2019/07/08 18h11:784| <01.00.15> <Property> <Columns> |.Spanish()|String|"' (Set|Get) The Spanish as String.
        Private _Spanish As String
        '''    <Summary>
        '''     (Set|Get) The Spanish as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:162 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Spanish as String.")>
        Public Property Spanish() As String
            Get
                Return _Spanish
            End Get
            Set(ByVal Value As String)
                _Spanish = Value
            End Set
        End Property
#End Region '(Set|Get) The Spanish as String.

#Region "[On] |2019/07/08 18h11:791| <01.00.16> <Property> <Columns> |.Portuguese()|String|"' (Set|Get) The Portuguese as String.
        Private _Portuguese As String
        '''    <Summary>
        '''     (Set|Get) The Portuguese as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:162 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Portuguese as String.")>
        Public Property Portuguese() As String
            Get
                Return _Portuguese
            End Get
            Set(ByVal Value As String)
                _Portuguese = Value
            End Set
        End Property
#End Region '(Set|Get) The Portuguese as String.

#Region "[On] |2019/07/08 18h11:798| <01.00.17> <Property> <Columns> |.Russian()|String|"' (Set|Get) The Russian as String.
        Private _Russian As String
        '''    <Summary>
        '''     (Set|Get) The Russian as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:163 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Russian as String.")>
        Public Property Russian() As String
            Get
                Return _Russian
            End Get
            Set(ByVal Value As String)
                _Russian = Value
            End Set
        End Property
#End Region '(Set|Get) The Russian as String.

#End Region
#Region "<2> [Enumeration]{1}"
#Region "[On] |2019/07/08 18h11:805| <02.00.00> <Enumeration> <> |.Schema()|Enumeration{17}|"' (Set|Get) The enumeration of Schema.
        '''    <Summary>
        '''     (Set|Get) The enumeration of Schema.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:163 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The enumeration of Schema.")>
        Enum Schema
            ''' <summary>(Set|Get) The N as Integer.</summary>
            [N] = 0
            ''' <summary>(Set|Get) The Group_Positif as Integer.</summary>
            [Group_Positif] = 1
            ''' <summary>(Set|Get) The Group_Negatif as Integer.</summary>
            [Group_Negatif] = 2
            ''' <summary>(Set|Get) The Currency as String.</summary>
            [Currency] = 3
            ''' <summary>(Set|Get) The Opening as Double.</summary>
            [Opening] = 4
            ''' <summary>(Set|Get) The Debit as Double.</summary>
            [Debit] = 5
            ''' <summary>(Set|Get) The Credit as Double.</summary>
            [Credit] = 6
            ''' <summary>(Set|Get) The Balance as Double.</summary>
            [Balance] = 7
            ''' <summary>(Set|Get) The Closing as Integer.</summary>
            [Closing] = 8
            ''' <summary>(Set|Get) The Variation as Double.</summary>
            [Variation] = 9
            ''' <summary>(Set|Get) The ID as Integer.</summary>
            [ID] = 10
            ''' <summary>(Set|Get) The Français as String.</summary>
            [Français] = 11
            ''' <summary>(Set|Get) The English as String.</summary>
            [English] = 12
            ''' <summary>(Set|Get) The Italian as String.</summary>
            [Italian] = 13
            ''' <summary>(Set|Get) The German as String.</summary>
            [German] = 14
            ''' <summary>(Set|Get) The Spanish as String.</summary>
            [Spanish] = 15
            ''' <summary>(Set|Get) The Portuguese as String.</summary>
            [Portuguese] = 16
            ''' <summary>(Set|Get) The Russian as String.</summary>
            [Russian] = 17
        End Enum
#End Region '(Set|Get) The enumeration of Schema.

#End Region
#Region "<4> [Sub]{5}"
#Region "[On] |2019/07/08 18h11:812| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
        '''    <Summary>
        '''     (Set|Get) This will reinitialize the class element.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:163 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will reinitialize the class element.")>
        Public Sub Clear()
            With Me
                .N = 0
                .Group_Positif = 0
                .Group_Negatif = 0
                .Currency = Nothing
                .Opening = 0
                .Debit = 0
                .Credit = 0
                .Balance = 0
                .Closing = 0
                .Variation = 0
                .ID = 0
                .Français = Nothing
                .English = Nothing
                .Italian = Nothing
                .German = Nothing
                .Spanish = Nothing
                .Portuguese = Nothing
                .Russian = Nothing
            End With
        End Sub
#End Region '(Set|Get) This will reinitialize the class element.

#Region "[On] |2019/07/08 18h11:819| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
        '''    <Summary>
        '''     (Set|Get) This will reinitialize the variables of this class.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:163 </Published>
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
                    TableName = "Tbl_Plan_Comptable"
                    Line = Connector.Line
                    UseSQL = False
                Else
                    FilePath = My.Settings.Db_Accountis_FilePath
                    Password = My.Settings.Db_Accountis_Password
                    Me.Line = My.Settings.Db_Accountis_Line
                    TableName = "Tbl_Plan_Comptable"
                    UseSQL = False
                End If
            Else
                If IsNothing(FilePath) Then
                    FilePath = My.Settings.Db_Accountis_FilePath
                End If
                If FilePath.Length < 1 Then
                    FilePath = My.Settings.Db_Accountis_FilePath
                End If
                FilePath = My.Settings.Db_Accountis_FilePath
                Password = My.Settings.Db_Accountis_Password
                Me.Line = My.Settings.Db_Accountis_Line
                TableName = "Tbl_Plan_Comptable"
                UseSQL = False
            End If

        End Sub
#End Region '(Set|Get) This will reinitialize the variables of this class.

#Region "[On] |2019/07/08 18h11:826| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
        '''    <Summary>
        '''     (Set|Get) This will add a new row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:163 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will add a new row in the table.")>
        Public Sub Add()
            Try
                Dim Str As String = Nothing
                Str = "Insert Into [Tbl_Plan_Comptable] (
`N`, 
`Group_Positif`, 
`Group_Negatif`, 
`Currency`, 
`Opening`, 
`Debit`, 
`Credit`, 
`Balance`, 
`Closing`, 
`Variation`, 
`ID`, 
`Français`, 
`English`, 
`Italian`, 
`German`, 
`Spanish`, 
`Portuguese`, 
`Russian`) Values (@0, @1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17)"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@0", Me.N)
                Cmd.Parameters.AddWithValue("@1", Me.Group_Positif)
                Cmd.Parameters.AddWithValue("@2", Me.Group_Negatif)
                Cmd.Parameters.AddWithValue("@3", Me.Currency)
                Cmd.Parameters.AddWithValue("@4", Me.Opening)
                Cmd.Parameters.AddWithValue("@5", Me.Debit)
                Cmd.Parameters.AddWithValue("@6", Me.Credit)
                Cmd.Parameters.AddWithValue("@7", Me.Balance)
                Cmd.Parameters.AddWithValue("@8", Me.Closing)
                Cmd.Parameters.AddWithValue("@9", Me.Variation)
                Cmd.Parameters.AddWithValue("@10", Me.ID)
                Cmd.Parameters.AddWithValue("@11", Me.Français)
                Cmd.Parameters.AddWithValue("@12", Me.English)
                Cmd.Parameters.AddWithValue("@13", Me.Italian)
                Cmd.Parameters.AddWithValue("@14", Me.German)
                Cmd.Parameters.AddWithValue("@15", Me.Spanish)
                Cmd.Parameters.AddWithValue("@16", Me.Portuguese)
                Cmd.Parameters.AddWithValue("@17", Me.Russian)
                If Cmd.ExecuteNonQuery >= 0 Then
                Else
                    Msgbox("Element not Addd")
                End If
            Catch ex As Exception
            Finally
                Close(True)
            End Try

        End Sub
#End Region '(Set|Get) This will add a new row in the table.

#Region "[On] |2019/07/08 18h11:834| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
        '''    <Summary>
        '''     (Set|Get) This will update a row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:163 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will update a row in the table.")>
        Public Sub Save()
            Try
                Dim Str As String = Nothing
                Str = "UPDATE [Tbl_Plan_Comptable] SET Group_Positif = @Group_Positif, Group_Negatif = @Group_Negatif, Currency = @Currency, Opening = @Opening, Debit = @Debit, Credit = @Credit, Balance = @Balance, Closing = @Closing, Variation = @Variation, ID = @ID, Français = @Français, English = @English, Italian = @Italian, German = @German, Spanish = @Spanish, Portuguese = @Portuguese, Russian = @Russian WHERE N = @N"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@Group_Positif", Group_Positif)
                Cmd.Parameters.AddWithValue("@Group_Negatif", Group_Negatif)
                Cmd.Parameters.AddWithValue("@Currency", Currency)
                Cmd.Parameters.AddWithValue("@Opening", Opening)
                Cmd.Parameters.AddWithValue("@Debit", Debit)
                Cmd.Parameters.AddWithValue("@Credit", Credit)
                Cmd.Parameters.AddWithValue("@Balance", Balance)
                Cmd.Parameters.AddWithValue("@Closing", Closing)
                Cmd.Parameters.AddWithValue("@Variation", Variation)
                Cmd.Parameters.AddWithValue("@ID", ID)
                Cmd.Parameters.AddWithValue("@Français", Français)
                Cmd.Parameters.AddWithValue("@English", English)
                Cmd.Parameters.AddWithValue("@Italian", Italian)
                Cmd.Parameters.AddWithValue("@German", German)
                Cmd.Parameters.AddWithValue("@Spanish", Spanish)
                Cmd.Parameters.AddWithValue("@Portuguese", Portuguese)
                Cmd.Parameters.AddWithValue("@Russian", Russian)
                Cmd.Parameters.AddWithValue("@N", N)
                If Cmd.ExecuteNonQuery >= 0 Then
                Else
                    Msgbox("Element not Saved")
                End If
            Catch ex As Exception
            Finally
                Close(True)
            End Try

        End Sub
#End Region '(Set|Get) This will update a row in the table.

#Region "[On] |2019/07/08 18h11:841| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
        '''    <Summary>
        '''     (Set|Get) This will Delete a row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:164 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will Delete a row in the table.")>
        Public Sub Delete()
            Try
                Dim Str As String = Nothing
                Str = "Delete From [Tbl_Plan_Comptable] WHERE N =@N"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@N", N)
                If Cmd.ExecuteNonQuery >= 0 Then
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
#Region "[On] |2019/07/08 18h11:847| <05.00.00> <Function> <> |.Open()|TestItem}|"' (Set|Get) This will initialise the connection and import the data.
        '''    <Summary>
        '''     (Set|Get) This will initialise the connection and import the data.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:164 </Published>
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
                Result.Why += Log & VbNewLine
            End If
            Return Result

        End Function
#End Region '(Set|Get) This will initialise the connection and import the data.

#Region "[On] |2019/07/08 18h11:855| <05.00.01> <Function> <> |.Close()|TestItem}|"' (Set|Get) This willClosing the connection
        '''    <Summary>
        '''     (Set|Get) This willClosing the connection
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:164 </Published>
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

#Region "[On] |2019/07/08 18h11:863| <05.00.02> <Function> <> |.List()|List(Of Tbl_Plan_Comptable)}|"' (Set|Get) Return the entire table listed
        '''    <Summary>
        '''     (Set|Get) Return the entire table listed
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:164 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Return the entire table listed")>
        Public Function List() As List(Of Tbl_Plan_Comptable)
            Dim Result As New List(Of Tbl_Plan_Comptable)
            Me.Table = New Table(Me.TableName, Me.FilePath, Me.Password, False)
            For Each Row As DataRow In Me.Table.DataTable.Rows
                Dim Element As New Tbl_Plan_Comptable(IIf(IsDBNull(Row.Item(0)), 0, Row.Item(0)),
IIf(IsDBNull(Row.Item(1)), 0, Row.Item(1)),
IIf(IsDBNull(Row.Item(2)), 0, Row.Item(2)),
IIf(IsDBNull(Row.Item(3)), "", Row.Item(3)),
IIf(IsDBNull(Row.Item(4)), 0, Row.Item(4)),
IIf(IsDBNull(Row.Item(5)), 0, Row.Item(5)),
IIf(IsDBNull(Row.Item(6)), 0, Row.Item(6)),
IIf(IsDBNull(Row.Item(7)), 0, Row.Item(7)),
IIf(IsDBNull(Row.Item(8)), 0, Row.Item(8)),
IIf(IsDBNull(Row.Item(9)), 0, Row.Item(9)),
IIf(IsDBNull(Row.Item(10)), 0, Row.Item(10)),
IIf(IsDBNull(Row.Item(11)), "", Row.Item(11)),
IIf(IsDBNull(Row.Item(12)), "", Row.Item(12)),
IIf(IsDBNull(Row.Item(13)), "", Row.Item(13)),
IIf(IsDBNull(Row.Item(14)), "", Row.Item(14)),
IIf(IsDBNull(Row.Item(15)), "", Row.Item(15)),
IIf(IsDBNull(Row.Item(16)), "", Row.Item(16)),
      IIf(IsDBNull(Row.Item(17)), "", Row.Item(17)))
                Element.Reset(Table.Line)
                Result.Add(Element)
            Next
            Return Result
        End Function
#End Region '(Set|Get) Return the entire table listed

#Region "[On] |2019/07/08 18h11:870| <05.00.03> <Function> <> |.SearchByName()|List(Of Tbl_Plan_Comptable)}|"' (Set|Get) Search for each property that match the Search String.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search String.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:164 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Search for each property that match the Search String.")>
        Public Shared Function SearchByName(ByVal Search As String) As List(Of Tbl_Plan_Comptable)
            Dim Result As New List(Of Tbl_Plan_Comptable)
            Dim C As New Tbl_Plan_Comptable
            For Each Element As Tbl_Plan_Comptable In C.List
                If Element.Currency.Tolower() = Search.Tolower() Or Element.Français.Tolower() = Search.Tolower() Or Element.English.Tolower() = Search.Tolower() Or Element.Italian.Tolower() = Search.Tolower() Or Element.German.Tolower() = Search.Tolower() Or Element.Spanish.Tolower() = Search.Tolower() Or Element.Portuguese.Tolower() = Search.Tolower() Or Element.Russian.Tolower() = Search.Tolower() Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search String.

#Region "[On] |2019/07/08 18h11:885| <05.00.04> <Function> <> |.SearchByID()|List(Of Tbl_Plan_Comptable)}|"' (Set|Get) Search for each property that match the Search Id.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search Id.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:164 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Search for each property that match the Search Id.")>
        Public Shared Function SearchByID(ByVal Search As Double) As List(Of Tbl_Plan_Comptable)
            Dim Result As New List(Of Tbl_Plan_Comptable)
            Dim C As New Tbl_Plan_Comptable
            For Each Element As Tbl_Plan_Comptable In C.List
                If Val(Element.N) = Search Or Val(Element.Group_Positif) = Search Or Val(Element.Group_Negatif) = Search Or Val(Element.Opening) = Search Or Val(Element.Debit) = Search Or Val(Element.Credit) = Search Or Val(Element.Balance) = Search Or Val(Element.Closing) = Search Or Val(Element.Variation) = Search Or Val(Element.ID) = Search Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search Id.

#Region "[On] |2019/07/08 18h11:892| <05.00.05> <Function> <> |.ToString()|String}|"' (Set|Get) The function ToString.
        '''    <Summary>
        '''     (Set|Get) The function ToString.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:164 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The function ToString.")>
        Public Overrides Function ToString() As String
            Return Me.N
        End Function
#End Region '(Set|Get) The function ToString.

#Region "[On] |2019/07/08 18h11:899| <05.00.06> <Function> <> |.CheckConnection()|Boolean}|"' (Set|Get) Evaluate the connection to the DataBase
        '''    <Summary>
        '''     (Set|Get) Evaluate the connection to the DataBase
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:164 </Published>
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
                    Me.Connector = New LineInfo(FilePath, Password)
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
            Log += Message & VbNewLine
            Return General_Status

        End Function
#End Region '(Set|Get) Evaluate the connection to the DataBase

#End Region
#Region "<6> [Runtime]{12}"
#Region "[On] |2019/07/08 18h11:907| <15.00.00> <Runtime> <> |.Table()|Table"' (Set|Get) The Table.
        '''    <Summary>
        '''     (Set|Get) The Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:165 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Table.")>
        Public Table As Table
#End Region '(Set|Get) The Table.

#Region "[On] |2019/07/08 18h11:915| <15.00.01> <Runtime> <> |.Line()|String"' (Set|Get) The Connection String To the Table.
        '''    <Summary>
        '''     (Set|Get) The Connection String To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:165 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Connection String To the Table.")>
        Public Line As String
#End Region '(Set|Get) The Connection String To the Table.

#Region "[On] |2019/07/08 18h11:924| <15.00.02> <Runtime> <> |.FilePath()|String"' (Set|Get) The FilePath To the Table.
        '''    <Summary>
        '''     (Set|Get) The FilePath To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:165 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The FilePath To the Table.")>
        Public FilePath As String
#End Region '(Set|Get) The FilePath To the Table.

#Region "[On] |2019/07/08 18h11:931| <15.00.03> <Runtime> <> |.Password()|String"' (Set|Get) The Password To the Table.
        '''    <Summary>
        '''     (Set|Get) The Password To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:165 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Password To the Table.")>
        Public Password As String
#End Region '(Set|Get) The Password To the Table.

#Region "[On] |2019/07/08 18h11:938| <15.00.04> <Runtime> <> |.UseSQL()|Boolean"' (Set|Get) Determines if the Database Connection is of type SQL.
        '''    <Summary>
        '''     (Set|Get) Determines if the Database Connection is of type SQL.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:166 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Determines if the Database Connection is of type SQL.")>
        Public UseSQL As Boolean
#End Region '(Set|Get) Determines if the Database Connection is of type SQL.

#Region "[On] |2019/07/08 18h11:947| <15.00.05> <Runtime> <> |.TableName()|String"' (Set|Get) The name of the Table.
        '''    <Summary>
        '''     (Set|Get) The name of the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:167 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The name of the Table.")>
        Public TableName As String
#End Region '(Set|Get) The name of the Table.

#Region "[On] |2019/07/08 18h11:954| <15.00.06> <Runtime> <> |.Con()|OleDb.OleDbConnection"' (Set|Get) The Con To the Table.
        '''    <Summary>
        '''     (Set|Get) The Con To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:167 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Con To the Table.")>
        Public Con As OleDb.OleDbConnection
#End Region '(Set|Get) The Con To the Table.

#Region "[On] |2019/07/08 18h11:958| <15.00.07> <Runtime> <> |.Cmd()|OleDb.OleDbCommand"' (Set|Get) The Cmd To the Table.
        '''    <Summary>
        '''     (Set|Get) The Cmd To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:167 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Cmd To the Table.")>
        Public Cmd As OleDb.OleDbCommand
#End Region '(Set|Get) The Cmd To the Table.

#Region "[On] |2019/07/08 18h11:966| <15.00.08> <Runtime> <> |.DataReader()|OleDb.OleDbDataReader"' (Set|Get) The DataReader To the Table.
        '''    <Summary>
        '''     (Set|Get) The DataReader To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:167 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The DataReader To the Table.")>
        Public DataReader As OleDb.OleDbDataReader
#End Region '(Set|Get) The DataReader To the Table.

#Region "[On] |2019/07/08 18h11:974| <15.00.09> <Runtime> <> |.DataAdapter()|OleDb.OleDbDataAdapter"' (Set|Get) The DataAdapter To the Table.
        '''    <Summary>
        '''     (Set|Get) The DataAdapter To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:167 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The DataAdapter To the Table.")>
        Public DataAdapter As OleDb.OleDbDataAdapter
#End Region '(Set|Get) The DataAdapter To the Table.

#Region "[On] |2019/07/08 18h11:991| <15.00.10> <Runtime> <> |.Connector()|LineInfo"' (Set|Get) The Connector To the Table.
        '''    <Summary>
        '''     (Set|Get) The Connector To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:167 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Connector To the Table.")>
        Public Connector As LineInfo
#End Region '(Set|Get) The Connector To the Table.

#Region "[On] |2019/07/08 18h11:998| <15.00.11> <Runtime> <> |.Log()|String"' (Set|Get) The Log To the Table.
        '''    <Summary>
        '''     (Set|Get) The Log To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:168 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Log To the Table.")>
        Public Log As String
#End Region '(Set|Get) The Log To the Table.

#End Region
#Region "<7> [Loader]{2}"
#Region "[On] |2019/07/08 18h11:007| <06.00.00> <Loader> <> |.Empty()|Function}|"' (Set|Get) The sub Empty.
        '''    <Summary>
        '''     (Set|Get) The sub Empty.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:168 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The sub Empty.")>
        Public Sub New()
            Reset
        End Sub
#End Region '(Set|Get) The sub Empty.

#Region "[On] |2019/07/08 18h11:009| <06.00.01> <Loader> <> |.Filled()|Function}|"' (Set|Get) The sub Filled.
        '''    <Summary>
        '''     (Set|Get) The sub Filled.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:168 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>    ''' <param name="N">(Set|Get) The N as Integer.</param>
        ''' <param name="Group_Positif">(Set|Get) The Group_Positif as Integer.</param>
        ''' <param name="Group_Negatif">(Set|Get) The Group_Negatif as Integer.</param>
        ''' <param name="Currency">(Set|Get) The Currency as String.</param>
        ''' <param name="Opening">(Set|Get) The Opening as Double.</param>
        ''' <param name="Debit">(Set|Get) The Debit as Double.</param>
        ''' <param name="Credit">(Set|Get) The Credit as Double.</param>
        ''' <param name="Balance">(Set|Get) The Balance as Double.</param>
        ''' <param name="Closing">(Set|Get) The Closing as Integer.</param>
        ''' <param name="Variation">(Set|Get) The Variation as Double.</param>
        ''' <param name="ID">(Set|Get) The ID as Integer.</param>
        ''' <param name="Français">(Set|Get) The Français as String.</param>
        ''' <param name="English">(Set|Get) The English as String.</param>
        ''' <param name="Italian">(Set|Get) The Italian as String.</param>
        ''' <param name="German">(Set|Get) The German as String.</param>
        ''' <param name="Spanish">(Set|Get) The Spanish as String.</param>
        ''' <param name="Portuguese">(Set|Get) The Portuguese as String.</param>
        ''' <param name="Russian">(Set|Get) The Russian as String.</param>

        <Browsable(True), Description("(Set|Get) The sub Filled.")>
        Public Sub New(ByVal N As Integer,
ByVal Group_Positif As Integer,
ByVal Group_Negatif As Integer,
ByVal Currency As String,
ByVal Opening As Double,
ByVal Debit As Double,
ByVal Credit As Double,
ByVal Balance As Double,
ByVal Closing As Integer,
ByVal Variation As Double,
ByVal ID As Integer,
ByVal Français As String,
ByVal English As String,
ByVal Italian As String,
ByVal German As String,
ByVal Spanish As String,
ByVal Portuguese As String,
ByVal Russian As String)
            With Me
                Clear()
                Reset()
                .N = N
                .Group_Positif = Group_Positif
                .Group_Negatif = Group_Negatif
                .Currency = Currency
                .Opening = Opening
                .Debit = Debit
                .Credit = Credit
                .Balance = Balance
                .Closing = Closing
                .Variation = Variation
                .ID = ID
                .Français = Français
                .English = English
                .Italian = Italian
                .German = German
                .Spanish = Spanish
                .Portuguese = Portuguese
                .Russian = Russian
            End With

        End Sub
#End Region '(Set|Get) The sub Filled.

#End Region
    End Class
#End Region

#Region "[On] |2019/07/08 18h11:132| <08.00.00> <Class> <> |.Tbl_Totaux|Class|{42} |Production Cost : 53.5|Selling Price : 133.75|"' Class created automatically by SmartOffice (c)Copyright 2019.
    '''    <Summary>
    '''     Class created automatically by SmartOffice (c)Copyright 2019.'''    Object Name :             Public  Class Tbl_Totaux
    '''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
    '''    Contributor Information : ||
    '''    Creation Date :           2019/07/08 18h11:132
    '''    |Schema|
    '''    |ID| |ObjectType |{Quantity}||UnitPrice||Total
    '''    |00| |Importation|{0}||1| |0
    '''    |01| |Properties |{15}||0.8| |12
    '''    |02| |Enumeration|{1}||0.4| |0.4
    '''    |03| |Structure  |{0}||0.4| |0
    '''    |04| |Sub        |{5}||1.2| |6
    '''    |05| |Function   |{7}||1.6| |11.2
    '''    |06| |Runtime    |{12}||0.4| |4.8
    '''    |07| |Loader     |{2}||0.8| |1.6
    '''    |08| |Class      |{0}||2| |0
    '''    |09| |Constante  |{0}||0.4| |0
    '''    |10| |Event      |{0}||1.2| |0
    '''    |11| |Members    |{15}||0.5| |7.5
    '''    |12| |Parameter  |{20}||0.5| |10
    '''    |Production Cost             |53.5
    '''    |Selling Price without VAT   |133.75
    '''    |Total TVA                   |10.3
    '''    |Grand Total                 |144.05
    '''    |/Schema|
    '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
    '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
    '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
    '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:177 </Published>
    '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
    '''    </Summary>
    Public Class Tbl_Totaux
#Region "<1> [Property]{15}"
#Region "[On] |2019/07/08 18h11:133| <01.00.00> <Property> <Columns> |.N()|Integer|"' (Set|Get) The N as Integer.
        Private _N As Integer
        '''    <Summary>
        '''     (Set|Get) The N as Integer.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:177 </Published>
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

#Region "[On] |2019/07/08 18h11:139| <01.00.01> <Property> <Columns> |.Position()|Integer|"' (Set|Get) The Position as Integer.
        Private _Position As Integer
        '''    <Summary>
        '''     (Set|Get) The Position as Integer.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:178 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Position as Integer.")>
        Public Property Position() As Integer
            Get
                Return _Position
            End Get
            Set(ByVal Value As Integer)
                _Position = Value
            End Set
        End Property
#End Region '(Set|Get) The Position as Integer.

#Region "[On] |2019/07/08 18h11:146| <01.00.02> <Property> <Columns> |.Opening()|Double|"' (Set|Get) The Opening as Double.
        Private _Opening As Double
        '''    <Summary>
        '''     (Set|Get) The Opening as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:178 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Opening as Double.")>
        Public Property Opening() As Double
            Get
                Return _Opening
            End Get
            Set(ByVal Value As Double)
                _Opening = Value
            End Set
        End Property
#End Region '(Set|Get) The Opening as Double.

#Region "[On] |2019/07/08 18h11:152| <01.00.03> <Property> <Columns> |.Debit()|Double|"' (Set|Get) The Debit as Double.
        Private _Debit As Double
        '''    <Summary>
        '''     (Set|Get) The Debit as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:178 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Debit as Double.")>
        Public Property Debit() As Double
            Get
                Return _Debit
            End Get
            Set(ByVal Value As Double)
                _Debit = Value
            End Set
        End Property
#End Region '(Set|Get) The Debit as Double.

#Region "[On] |2019/07/08 18h11:158| <01.00.04> <Property> <Columns> |.Credit()|Double|"' (Set|Get) The Credit as Double.
        Private _Credit As Double
        '''    <Summary>
        '''     (Set|Get) The Credit as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:178 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Credit as Double.")>
        Public Property Credit() As Double
            Get
                Return _Credit
            End Get
            Set(ByVal Value As Double)
                _Credit = Value
            End Set
        End Property
#End Region '(Set|Get) The Credit as Double.

#Region "[On] |2019/07/08 18h11:164| <01.00.05> <Property> <Columns> |.Balance()|Double|"' (Set|Get) The Balance as Double.
        Private _Balance As Double
        '''    <Summary>
        '''     (Set|Get) The Balance as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:178 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Balance as Double.")>
        Public Property Balance() As Double
            Get
                Return _Balance
            End Get
            Set(ByVal Value As Double)
                _Balance = Value
            End Set
        End Property
#End Region '(Set|Get) The Balance as Double.

#Region "[On] |2019/07/08 18h11:170| <01.00.06> <Property> <Columns> |.Closing()|Double|"' (Set|Get) The Closing as Double.
        Private _Closing As Double
        '''    <Summary>
        '''     (Set|Get) The Closing as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:179 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Closing as Double.")>
        Public Property Closing() As Double
            Get
                Return _Closing
            End Get
            Set(ByVal Value As Double)
                _Closing = Value
            End Set
        End Property
#End Region '(Set|Get) The Closing as Double.

#Region "[On] |2019/07/08 18h11:176| <01.00.07> <Property> <Columns> |.Variation()|Double|"' (Set|Get) The Variation as Double.
        Private _Variation As Double
        '''    <Summary>
        '''     (Set|Get) The Variation as Double.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:179 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Variation as Double.")>
        Public Property Variation() As Double
            Get
                Return _Variation
            End Get
            Set(ByVal Value As Double)
                _Variation = Value
            End Set
        End Property
#End Region '(Set|Get) The Variation as Double.

#Region "[On] |2019/07/08 18h11:182| <01.00.08> <Property> <Columns> |.Français()|String|"' (Set|Get) The Français as String.
        Private _Français As String
        '''    <Summary>
        '''     (Set|Get) The Français as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:179 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Français as String.")>
        Public Property Français() As String
            Get
                Return _Français
            End Get
            Set(ByVal Value As String)
                _Français = Value
            End Set
        End Property
#End Region '(Set|Get) The Français as String.

#Region "[On] |2019/07/08 18h11:189| <01.00.09> <Property> <Columns> |.English()|String|"' (Set|Get) The English as String.
        Private _English As String
        '''    <Summary>
        '''     (Set|Get) The English as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:179 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The English as String.")>
        Public Property English() As String
            Get
                Return _English
            End Get
            Set(ByVal Value As String)
                _English = Value
            End Set
        End Property
#End Region '(Set|Get) The English as String.

#Region "[On] |2019/07/08 18h11:201| <01.00.10> <Property> <Columns> |.Italian()|String|"' (Set|Get) The Italian as String.
        Private _Italian As String
        '''    <Summary>
        '''     (Set|Get) The Italian as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:179 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Italian as String.")>
        Public Property Italian() As String
            Get
                Return _Italian
            End Get
            Set(ByVal Value As String)
                _Italian = Value
            End Set
        End Property
#End Region '(Set|Get) The Italian as String.

#Region "[On] |2019/07/08 18h11:207| <01.00.11> <Property> <Columns> |.German()|String|"' (Set|Get) The German as String.
        Private _German As String
        '''    <Summary>
        '''     (Set|Get) The German as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:180 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The German as String.")>
        Public Property German() As String
            Get
                Return _German
            End Get
            Set(ByVal Value As String)
                _German = Value
            End Set
        End Property
#End Region '(Set|Get) The German as String.

#Region "[On] |2019/07/08 18h11:214| <01.00.12> <Property> <Columns> |.Spanish()|String|"' (Set|Get) The Spanish as String.
        Private _Spanish As String
        '''    <Summary>
        '''     (Set|Get) The Spanish as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:180 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Spanish as String.")>
        Public Property Spanish() As String
            Get
                Return _Spanish
            End Get
            Set(ByVal Value As String)
                _Spanish = Value
            End Set
        End Property
#End Region '(Set|Get) The Spanish as String.

#Region "[On] |2019/07/08 18h11:220| <01.00.13> <Property> <Columns> |.Portuguese()|String|"' (Set|Get) The Portuguese as String.
        Private _Portuguese As String
        '''    <Summary>
        '''     (Set|Get) The Portuguese as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:180 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Portuguese as String.")>
        Public Property Portuguese() As String
            Get
                Return _Portuguese
            End Get
            Set(ByVal Value As String)
                _Portuguese = Value
            End Set
        End Property
#End Region '(Set|Get) The Portuguese as String.

#Region "[On] |2019/07/08 18h11:227| <01.00.14> <Property> <Columns> |.Russian()|String|"' (Set|Get) The Russian as String.
        Private _Russian As String
        '''    <Summary>
        '''     (Set|Get) The Russian as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:180 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Columns"), Description("(Set|Get) The Russian as String.")>
        Public Property Russian() As String
            Get
                Return _Russian
            End Get
            Set(ByVal Value As String)
                _Russian = Value
            End Set
        End Property
#End Region '(Set|Get) The Russian as String.

#End Region
#Region "<2> [Enumeration]{1}"
#Region "[On] |2019/07/08 18h11:234| <02.00.00> <Enumeration> <> |.Schema()|Enumeration{14}|"' (Set|Get) The enumeration of Schema.
        '''    <Summary>
        '''     (Set|Get) The enumeration of Schema.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:180 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The enumeration of Schema.")>
        Enum Schema
            ''' <summary>(Set|Get) The N as Integer.</summary>
            [N] = 0
            ''' <summary>(Set|Get) The Position as Integer.</summary>
            [Position] = 1
            ''' <summary>(Set|Get) The Opening as Double.</summary>
            [Opening] = 2
            ''' <summary>(Set|Get) The Debit as Double.</summary>
            [Debit] = 3
            ''' <summary>(Set|Get) The Credit as Double.</summary>
            [Credit] = 4
            ''' <summary>(Set|Get) The Balance as Double.</summary>
            [Balance] = 5
            ''' <summary>(Set|Get) The Closing as Double.</summary>
            [Closing] = 6
            ''' <summary>(Set|Get) The Variation as Double.</summary>
            [Variation] = 7
            ''' <summary>(Set|Get) The Français as String.</summary>
            [Français] = 8
            ''' <summary>(Set|Get) The English as String.</summary>
            [English] = 9
            ''' <summary>(Set|Get) The Italian as String.</summary>
            [Italian] = 10
            ''' <summary>(Set|Get) The German as String.</summary>
            [German] = 11
            ''' <summary>(Set|Get) The Spanish as String.</summary>
            [Spanish] = 12
            ''' <summary>(Set|Get) The Portuguese as String.</summary>
            [Portuguese] = 13
            ''' <summary>(Set|Get) The Russian as String.</summary>
            [Russian] = 14
        End Enum
#End Region '(Set|Get) The enumeration of Schema.

#End Region
#Region "<4> [Sub]{5}"
#Region "[On] |2019/07/08 18h11:241| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class element.
        '''    <Summary>
        '''     (Set|Get) This will reinitialize the class element.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:181 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will reinitialize the class element.")>
        Public Sub Clear()
            With Me
                .N = 0
                .Position = 0
                .Opening = 0
                .Debit = 0
                .Credit = 0
                .Balance = 0
                .Closing = 0
                .Variation = 0
                .Français = Nothing
                .English = Nothing
                .Italian = Nothing
                .German = Nothing
                .Spanish = Nothing
                .Portuguese = Nothing
                .Russian = Nothing
            End With
        End Sub
#End Region '(Set|Get) This will reinitialize the class element.

#Region "[On] |2019/07/08 18h11:247| <04.00.01> <Sub> <> |.Reset()|Sub}|"' (Set|Get) This will reinitialize the variables of this class.
        '''    <Summary>
        '''     (Set|Get) This will reinitialize the variables of this class.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:181 </Published>
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
                    TableName = "Tbl_Totaux"
                    Line = Connector.Line
                    UseSQL = False
                Else
                    FilePath = My.Settings.Db_Accountis_FilePath
                    Password = My.Settings.Db_Accountis_Password
                    Me.Line = My.Settings.Db_Accountis_Line
                    TableName = "Tbl_Totaux"
                    UseSQL = False
                End If
            Else
                If IsNothing(FilePath) Then
                    FilePath = My.Settings.Db_Accountis_FilePath
                End If
                If FilePath.Length < 1 Then
                    FilePath = My.Settings.Db_Accountis_FilePath
                End If
                FilePath = My.Settings.Db_Accountis_FilePath
                Password = My.Settings.Db_Accountis_Password
                Me.Line = My.Settings.Db_Accountis_Line
                TableName = "Tbl_Totaux"
                UseSQL = False
            End If

        End Sub
#End Region '(Set|Get) This will reinitialize the variables of this class.

#Region "[On] |2019/07/08 18h11:255| <04.00.02> <Sub> <> |.Add()|Sub}|"' (Set|Get) This will add a new row in the table.
        '''    <Summary>
        '''     (Set|Get) This will add a new row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:183 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will add a new row in the table.")>
        Public Sub Add()
            Try
                Dim Str As String = Nothing
                Str = "Insert Into [Tbl_Totaux] (
`N`, 
`Position`, 
`Opening`, 
`Debit`, 
`Credit`, 
`Balance`, 
`Closing`, 
`Variation`, 
`Français`, 
`English`, 
`Italian`, 
`German`, 
`Spanish`, 
`Portuguese`, 
`Russian`) Values (@0, @1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14)"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@0", Me.N)
                Cmd.Parameters.AddWithValue("@1", Me.Position)
                Cmd.Parameters.AddWithValue("@2", Me.Opening)
                Cmd.Parameters.AddWithValue("@3", Me.Debit)
                Cmd.Parameters.AddWithValue("@4", Me.Credit)
                Cmd.Parameters.AddWithValue("@5", Me.Balance)
                Cmd.Parameters.AddWithValue("@6", Me.Closing)
                Cmd.Parameters.AddWithValue("@7", Me.Variation)
                Cmd.Parameters.AddWithValue("@8", Me.Français)
                Cmd.Parameters.AddWithValue("@9", Me.English)
                Cmd.Parameters.AddWithValue("@10", Me.Italian)
                Cmd.Parameters.AddWithValue("@11", Me.German)
                Cmd.Parameters.AddWithValue("@12", Me.Spanish)
                Cmd.Parameters.AddWithValue("@13", Me.Portuguese)
                Cmd.Parameters.AddWithValue("@14", Me.Russian)
                If Cmd.ExecuteNonQuery >= 0 Then
                Else
                    Msgbox("Element not Addd")
                End If
            Catch ex As Exception
            Finally
                Close(True)
            End Try

        End Sub
#End Region '(Set|Get) This will add a new row in the table.

#Region "[On] |2019/07/08 18h11:262| <04.00.03> <Sub> <> |.Save()|Sub}|"' (Set|Get) This will update a row in the table.
        '''    <Summary>
        '''     (Set|Get) This will update a row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:183 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will update a row in the table.")>
        Public Sub Save()
            Try
                Dim Str As String = Nothing
                Str = "UPDATE [Tbl_Totaux] SET Position = @Position, Opening = @Opening, Debit = @Debit, Credit = @Credit, Balance = @Balance, Closing = @Closing, Variation = @Variation, Français = @Français, English = @English, Italian = @Italian, German = @German, Spanish = @Spanish, Portuguese = @Portuguese, Russian = @Russian WHERE N = @N"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@Position", Position)
                Cmd.Parameters.AddWithValue("@Opening", Opening)
                Cmd.Parameters.AddWithValue("@Debit", Debit)
                Cmd.Parameters.AddWithValue("@Credit", Credit)
                Cmd.Parameters.AddWithValue("@Balance", Balance)
                Cmd.Parameters.AddWithValue("@Closing", Closing)
                Cmd.Parameters.AddWithValue("@Variation", Variation)
                Cmd.Parameters.AddWithValue("@Français", Français)
                Cmd.Parameters.AddWithValue("@English", English)
                Cmd.Parameters.AddWithValue("@Italian", Italian)
                Cmd.Parameters.AddWithValue("@German", German)
                Cmd.Parameters.AddWithValue("@Spanish", Spanish)
                Cmd.Parameters.AddWithValue("@Portuguese", Portuguese)
                Cmd.Parameters.AddWithValue("@Russian", Russian)
                Cmd.Parameters.AddWithValue("@N", N)
                If Cmd.ExecuteNonQuery >= 0 Then
                Else
                    Msgbox("Element not Saved")
                End If
            Catch ex As Exception
            Finally
                Close(True)
            End Try

        End Sub
#End Region '(Set|Get) This will update a row in the table.

#Region "[On] |2019/07/08 18h11:268| <04.00.04> <Sub> <> |.Delete()|Sub}|"' (Set|Get) This will Delete a row in the table.
        '''    <Summary>
        '''     (Set|Get) This will Delete a row in the table.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:183 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will Delete a row in the table.")>
        Public Sub Delete()
            Try
                Dim Str As String = Nothing
                Str = "Delete From [Tbl_Totaux] WHERE N =@N"
                Con = New OleDb.OleDbConnection(New LineInfo(FilePath, Password).Line)
                Cmd = New OleDb.OleDbCommand(Str, Con)
                Con.Open()
                Cmd.Parameters.AddWithValue("@N", N)
                If Cmd.ExecuteNonQuery >= 0 Then
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
#Region "[On] |2019/07/08 18h11:276| <05.00.00> <Function> <> |.Open()|TestItem}|"' (Set|Get) This will initialise the connection and import the data.
        '''    <Summary>
        '''     (Set|Get) This will initialise the connection and import the data.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:183 </Published>
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
                Result.Why += Log & VbNewLine
            End If
            Return Result

        End Function
#End Region '(Set|Get) This will initialise the connection and import the data.

#Region "[On] |2019/07/08 18h11:283| <05.00.01> <Function> <> |.Close()|TestItem}|"' (Set|Get) This willClosing the connection
        '''    <Summary>
        '''     (Set|Get) This willClosing the connection
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:183 </Published>
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

#Region "[On] |2019/07/08 18h11:291| <05.00.02> <Function> <> |.List()|List(Of Tbl_Totaux)}|"' (Set|Get) Return the entire table listed
        '''    <Summary>
        '''     (Set|Get) Return the entire table listed
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:184 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Return the entire table listed")>
        Public Function List() As List(Of Tbl_Totaux)
            Dim Result As New List(Of Tbl_Totaux)
            Me.Table = New Table(Me.TableName, Me.FilePath, Me.Password, False)
            For Each Row As DataRow In Me.Table.DataTable.Rows
                Dim Element As New Tbl_Totaux(IIf(IsDBNull(Row.Item(0)), 0, Row.Item(0)),
IIf(IsDBNull(Row.Item(1)), 0, Row.Item(1)),
IIf(IsDBNull(Row.Item(2)), 0, Row.Item(2)),
IIf(IsDBNull(Row.Item(3)), 0, Row.Item(3)),
IIf(IsDBNull(Row.Item(4)), 0, Row.Item(4)),
IIf(IsDBNull(Row.Item(5)), 0, Row.Item(5)),
IIf(IsDBNull(Row.Item(6)), 0, Row.Item(6)),
IIf(IsDBNull(Row.Item(7)), 0, Row.Item(7)),
IIf(IsDBNull(Row.Item(8)), "", Row.Item(8)),
IIf(IsDBNull(Row.Item(9)), "", Row.Item(9)),
IIf(IsDBNull(Row.Item(10)), "", Row.Item(10)),
IIf(IsDBNull(Row.Item(11)), "", Row.Item(11)),
IIf(IsDBNull(Row.Item(12)), "", Row.Item(12)),
IIf(IsDBNull(Row.Item(13)), "", Row.Item(13)),
      IIf(IsDBNull(Row.Item(14)), "", Row.Item(14)))
                Element.Reset(Table.Line)
                Result.Add(Element)
            Next
            Return Result
        End Function
#End Region '(Set|Get) Return the entire table listed

#Region "[On] |2019/07/08 18h11:300| <05.00.03> <Function> <> |.SearchByName()|List(Of Tbl_Totaux)}|"' (Set|Get) Search for each property that match the Search String.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search String.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:184 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Search for each property that match the Search String.")>
        Public Shared Function SearchByName(ByVal Search As String) As List(Of Tbl_Totaux)
            Dim Result As New List(Of Tbl_Totaux)
            Dim C As New Tbl_Totaux
            For Each Element As Tbl_Totaux In C.List
                If Element.Français.Tolower() = Search.Tolower() Or Element.English.Tolower() = Search.Tolower() Or Element.Italian.Tolower() = Search.Tolower() Or Element.German.Tolower() = Search.Tolower() Or Element.Spanish.Tolower() = Search.Tolower() Or Element.Portuguese.Tolower() = Search.Tolower() Or Element.Russian.Tolower() = Search.Tolower() Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search String.

#Region "[On] |2019/07/08 18h11:317| <05.00.04> <Function> <> |.SearchByID()|List(Of Tbl_Totaux)}|"' (Set|Get) Search for each property that match the Search Id.
        '''    <Summary>
        '''     (Set|Get) Search for each property that match the Search Id.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:184 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Search for each property that match the Search Id.")>
        Public Shared Function SearchByID(ByVal Search As Double) As List(Of Tbl_Totaux)
            Dim Result As New List(Of Tbl_Totaux)
            Dim C As New Tbl_Totaux
            For Each Element As Tbl_Totaux In C.List
                If Val(Element.N) = Search Or Val(Element.Position) = Search Or Val(Element.Opening) = Search Or Val(Element.Debit) = Search Or Val(Element.Credit) = Search Or Val(Element.Balance) = Search Or Val(Element.Closing) = Search Or Val(Element.Variation) = Search Then
                    Result.Add(Element)
                End If
            Next
            Return Result
        End Function
#End Region '(Set|Get) Search for each property that match the Search Id.

#Region "[On] |2019/07/08 18h11:324| <05.00.05> <Function> <> |.ToString()|String}|"' (Set|Get) The function ToString.
        '''    <Summary>
        '''     (Set|Get) The function ToString.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:184 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The function ToString.")>
        Public Overrides Function ToString() As String
            Return Me.N
        End Function
#End Region '(Set|Get) The function ToString.

#Region "[On] |2019/07/08 18h11:333| <05.00.06> <Function> <> |.CheckConnection()|Boolean}|"' (Set|Get) Evaluate the connection to the DataBase
        '''    <Summary>
        '''     (Set|Get) Evaluate the connection to the DataBase
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:184 </Published>
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
                    Me.Connector = New LineInfo(FilePath, Password)
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
            Log += Message & VbNewLine
            Return General_Status

        End Function
#End Region '(Set|Get) Evaluate the connection to the DataBase

#End Region
#Region "<6> [Runtime]{12}"
#Region "[On] |2019/07/08 18h11:341| <15.00.00> <Runtime> <> |.Table()|Table"' (Set|Get) The Table.
        '''    <Summary>
        '''     (Set|Get) The Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:184 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Table.")>
        Public Table As Table
#End Region '(Set|Get) The Table.

#Region "[On] |2019/07/08 18h11:347| <15.00.01> <Runtime> <> |.Line()|String"' (Set|Get) The Connection String To the Table.
        '''    <Summary>
        '''     (Set|Get) The Connection String To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:185 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Connection String To the Table.")>
        Public Line As String
#End Region '(Set|Get) The Connection String To the Table.

#Region "[On] |2019/07/08 18h11:355| <15.00.02> <Runtime> <> |.FilePath()|String"' (Set|Get) The FilePath To the Table.
        '''    <Summary>
        '''     (Set|Get) The FilePath To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:185 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The FilePath To the Table.")>
        Public FilePath As String
#End Region '(Set|Get) The FilePath To the Table.

#Region "[On] |2019/07/08 18h11:363| <15.00.03> <Runtime> <> |.Password()|String"' (Set|Get) The Password To the Table.
        '''    <Summary>
        '''     (Set|Get) The Password To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:185 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Password To the Table.")>
        Public Password As String
#End Region '(Set|Get) The Password To the Table.

#Region "[On] |2019/07/08 18h11:370| <15.00.04> <Runtime> <> |.UseSQL()|Boolean"' (Set|Get) Determines if the Database Connection is of type SQL.
        '''    <Summary>
        '''     (Set|Get) Determines if the Database Connection is of type SQL.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:185 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) Determines if the Database Connection is of type SQL.")>
        Public UseSQL As Boolean
#End Region '(Set|Get) Determines if the Database Connection is of type SQL.

#Region "[On] |2019/07/08 18h11:378| <15.00.05> <Runtime> <> |.TableName()|String"' (Set|Get) The name of the Table.
        '''    <Summary>
        '''     (Set|Get) The name of the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:185 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The name of the Table.")>
        Public TableName As String
#End Region '(Set|Get) The name of the Table.

#Region "[On] |2019/07/08 18h11:385| <15.00.06> <Runtime> <> |.Con()|OleDb.OleDbConnection"' (Set|Get) The Con To the Table.
        '''    <Summary>
        '''     (Set|Get) The Con To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:185 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Con To the Table.")>
        Public Con As OleDb.OleDbConnection
#End Region '(Set|Get) The Con To the Table.

#Region "[On] |2019/07/08 18h11:388| <15.00.07> <Runtime> <> |.Cmd()|OleDb.OleDbCommand"' (Set|Get) The Cmd To the Table.
        '''    <Summary>
        '''     (Set|Get) The Cmd To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:186 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Cmd To the Table.")>
        Public Cmd As OleDb.OleDbCommand
#End Region '(Set|Get) The Cmd To the Table.

#Region "[On] |2019/07/08 18h11:396| <15.00.08> <Runtime> <> |.DataReader()|OleDb.OleDbDataReader"' (Set|Get) The DataReader To the Table.
        '''    <Summary>
        '''     (Set|Get) The DataReader To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:186 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The DataReader To the Table.")>
        Public DataReader As OleDb.OleDbDataReader
#End Region '(Set|Get) The DataReader To the Table.

#Region "[On] |2019/07/08 18h11:403| <15.00.09> <Runtime> <> |.DataAdapter()|OleDb.OleDbDataAdapter"' (Set|Get) The DataAdapter To the Table.
        '''    <Summary>
        '''     (Set|Get) The DataAdapter To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:186 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The DataAdapter To the Table.")>
        Public DataAdapter As OleDb.OleDbDataAdapter
#End Region '(Set|Get) The DataAdapter To the Table.

#Region "[On] |2019/07/08 18h11:410| <15.00.10> <Runtime> <> |.Connector()|LineInfo"' (Set|Get) The Connector To the Table.
        '''    <Summary>
        '''     (Set|Get) The Connector To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:186 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Connector To the Table.")>
        Public Connector As LineInfo
#End Region '(Set|Get) The Connector To the Table.

#Region "[On] |2019/07/08 18h11:425| <15.00.11> <Runtime> <> |.Log()|String"' (Set|Get) The Log To the Table.
        '''    <Summary>
        '''     (Set|Get) The Log To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:186 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Log To the Table.")>
        Public Log As String
#End Region '(Set|Get) The Log To the Table.

#End Region
#Region "<7> [Loader]{2}"
#Region "[On] |2019/07/08 18h11:432| <06.00.00> <Loader> <> |.Empty()|Function}|"' (Set|Get) The sub Empty.
        '''    <Summary>
        '''     (Set|Get) The sub Empty.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:186 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The sub Empty.")>
        Public Sub New()
            Reset
        End Sub
#End Region '(Set|Get) The sub Empty.

#Region "[On] |2019/07/08 18h11:434| <06.00.01> <Loader> <> |.Filled()|Function}|"' (Set|Get) The sub Filled.
        '''    <Summary>
        '''     (Set|Get) The sub Filled.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:187 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>    ''' <param name="N">(Set|Get) The N as Integer.</param>
        ''' <param name="Position">(Set|Get) The Position as Integer.</param>
        ''' <param name="Opening">(Set|Get) The Opening as Double.</param>
        ''' <param name="Debit">(Set|Get) The Debit as Double.</param>
        ''' <param name="Credit">(Set|Get) The Credit as Double.</param>
        ''' <param name="Balance">(Set|Get) The Balance as Double.</param>
        ''' <param name="Closing">(Set|Get) The Closing as Double.</param>
        ''' <param name="Variation">(Set|Get) The Variation as Double.</param>
        ''' <param name="Français">(Set|Get) The Français as String.</param>
        ''' <param name="English">(Set|Get) The English as String.</param>
        ''' <param name="Italian">(Set|Get) The Italian as String.</param>
        ''' <param name="German">(Set|Get) The German as String.</param>
        ''' <param name="Spanish">(Set|Get) The Spanish as String.</param>
        ''' <param name="Portuguese">(Set|Get) The Portuguese as String.</param>
        ''' <param name="Russian">(Set|Get) The Russian as String.</param>

        <Browsable(True), Description("(Set|Get) The sub Filled.")>
        Public Sub New(ByVal N As Integer,
ByVal Position As Integer,
ByVal Opening As Double,
ByVal Debit As Double,
ByVal Credit As Double,
ByVal Balance As Double,
ByVal Closing As Double,
ByVal Variation As Double,
ByVal Français As String,
ByVal English As String,
ByVal Italian As String,
ByVal German As String,
ByVal Spanish As String,
ByVal Portuguese As String,
ByVal Russian As String)
            With Me
                Clear()
                Reset()
                .N = N
                .Position = Position
                .Opening = Opening
                .Debit = Debit
                .Credit = Credit
                .Balance = Balance
                .Closing = Closing
                .Variation = Variation
                .Français = Français
                .English = English
                .Italian = Italian
                .German = German
                .Spanish = Spanish
                .Portuguese = Portuguese
                .Russian = Russian
            End With

        End Sub
#End Region '(Set|Get) The sub Filled.

#End Region
    End Class
#End Region

#Region "[On] |2019/07/08 18h11:549| <08.00.00> <Class> <> |.Initializor_Accountis|Class|{30} |Production Cost : 24.6|Selling Price : 61.5|"' 
    '''    <Summary>
    '''     '''    Object Name :             Public  Class Initializor_Accountis
    '''    Author Information :      David Shaw Informatique Sàrl|saadry.dunkel@ds-informatique.ch|https://www.ds-informatique.ch
    '''    Contributor Information : ||
    '''    Creation Date :           2019/07/08 18h11:549
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
    '''    |Selling Price without VAT   |61.5
    '''    |Total TVA                   |4.74
    '''    |Grand Total                 |66.24
    '''    |/Schema|
    '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
    '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
    '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
    '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:195 </Published>
    '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
    '''    </Summary>
    Public Class Initializor_Accountis
#Region "<1> [Property]{22}"
#Region "[On] |2019/07/08 18h11:550| <01.00.00> <Property> <Virtualized Properties> |.Tbl_CodeRegroupement()|Tbl_CodeRegroupement|"' (Set|Get) 
        Private _Tbl_CodeRegroupement As Tbl_CodeRegroupement
        '''    <Summary>
        '''     (Set|Get) 
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:195 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Virtualized Properties"), Description("(Set|Get) ")>
        Public Property Tbl_CodeRegroupement() As Tbl_CodeRegroupement
            Get
                Return _Tbl_CodeRegroupement
            End Get
            Set(ByVal Value As Tbl_CodeRegroupement)
                _Tbl_CodeRegroupement = Value
            End Set
        End Property
#End Region '(Set|Get) 

#Region "[On] |2019/07/08 18h11:557| <01.00.01> <Property> <List> |.List_Tbl_CodeRegroupement()|List(Of Tbl_CodeRegroupement)|"' (Set|Get) 
        Private _List_Tbl_CodeRegroupement As List(Of Tbl_CodeRegroupement)
        '''    <Summary>
        '''     (Set|Get) 
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:195 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("List"), Description("(Set|Get) ")>
        Public Property List_Tbl_CodeRegroupement() As List(Of Tbl_CodeRegroupement)
            Get
                Return _List_Tbl_CodeRegroupement
            End Get
            Set(ByVal Value As List(Of Tbl_CodeRegroupement))
                _List_Tbl_CodeRegroupement = Value
            End Set
        End Property
#End Region '(Set|Get) 

#Region "[On] |2019/07/08 18h11:562| <01.00.02> <Property> <Virtualized Properties> |.Tbl_CurrencyRatio()|Tbl_CurrencyRatio|"' (Set|Get) 
        Private _Tbl_CurrencyRatio As Tbl_CurrencyRatio
        '''    <Summary>
        '''     (Set|Get) 
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:196 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Virtualized Properties"), Description("(Set|Get) ")>
        Public Property Tbl_CurrencyRatio() As Tbl_CurrencyRatio
            Get
                Return _Tbl_CurrencyRatio
            End Get
            Set(ByVal Value As Tbl_CurrencyRatio)
                _Tbl_CurrencyRatio = Value
            End Set
        End Property
#End Region '(Set|Get) 

#Region "[On] |2019/07/08 18h11:568| <01.00.03> <Property> <List> |.List_Tbl_CurrencyRatio()|List(Of Tbl_CurrencyRatio)|"' (Set|Get) 
        Private _List_Tbl_CurrencyRatio As List(Of Tbl_CurrencyRatio)
        '''    <Summary>
        '''     (Set|Get) 
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:196 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("List"), Description("(Set|Get) ")>
        Public Property List_Tbl_CurrencyRatio() As List(Of Tbl_CurrencyRatio)
            Get
                Return _List_Tbl_CurrencyRatio
            End Get
            Set(ByVal Value As List(Of Tbl_CurrencyRatio))
                _List_Tbl_CurrencyRatio = Value
            End Set
        End Property
#End Region '(Set|Get) 

#Region "[On] |2019/07/08 18h11:573| <01.00.04> <Property> <Virtualized Properties> |.Tbl_Entries()|Tbl_Entries|"' (Set|Get) 
        Private _Tbl_Entries As Tbl_Entries
        '''    <Summary>
        '''     (Set|Get) 
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:196 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Virtualized Properties"), Description("(Set|Get) ")>
        Public Property Tbl_Entries() As Tbl_Entries
            Get
                Return _Tbl_Entries
            End Get
            Set(ByVal Value As Tbl_Entries)
                _Tbl_Entries = Value
            End Set
        End Property
#End Region '(Set|Get) 

#Region "[On] |2019/07/08 18h11:579| <01.00.05> <Property> <List> |.List_Tbl_Entries()|List(Of Tbl_Entries)|"' (Set|Get) 
        Private _List_Tbl_Entries As List(Of Tbl_Entries)
        '''    <Summary>
        '''     (Set|Get) 
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:196 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("List"), Description("(Set|Get) ")>
        Public Property List_Tbl_Entries() As List(Of Tbl_Entries)
            Get
                Return _List_Tbl_Entries
            End Get
            Set(ByVal Value As List(Of Tbl_Entries))
                _List_Tbl_Entries = Value
            End Set
        End Property
#End Region '(Set|Get) 

#Region "[On] |2019/07/08 18h11:584| <01.00.06> <Property> <Virtualized Properties> |.Tbl_Entries_Line()|Tbl_Entries_Line|"' (Set|Get) 
        Private _Tbl_Entries_Line As Tbl_Entries_Line
        '''    <Summary>
        '''     (Set|Get) 
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:196 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Virtualized Properties"), Description("(Set|Get) ")>
        Public Property Tbl_Entries_Line() As Tbl_Entries_Line
            Get
                Return _Tbl_Entries_Line
            End Get
            Set(ByVal Value As Tbl_Entries_Line)
                _Tbl_Entries_Line = Value
            End Set
        End Property
#End Region '(Set|Get) 

#Region "[On] |2019/07/08 18h11:590| <01.00.07> <Property> <List> |.List_Tbl_Entries_Line()|List(Of Tbl_Entries_Line)|"' (Set|Get) 
        Private _List_Tbl_Entries_Line As List(Of Tbl_Entries_Line)
        '''    <Summary>
        '''     (Set|Get) 
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:197 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("List"), Description("(Set|Get) ")>
        Public Property List_Tbl_Entries_Line() As List(Of Tbl_Entries_Line)
            Get
                Return _List_Tbl_Entries_Line
            End Get
            Set(ByVal Value As List(Of Tbl_Entries_Line))
                _List_Tbl_Entries_Line = Value
            End Set
        End Property
#End Region '(Set|Get) 

#Region "[On] |2019/07/08 18h11:596| <01.00.08> <Property> <Virtualized Properties> |.Tbl_Group()|Tbl_Group|"' (Set|Get) 
        Private _Tbl_Group As Tbl_Group
        '''    <Summary>
        '''     (Set|Get) 
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:197 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Virtualized Properties"), Description("(Set|Get) ")>
        Public Property Tbl_Group() As Tbl_Group
            Get
                Return _Tbl_Group
            End Get
            Set(ByVal Value As Tbl_Group)
                _Tbl_Group = Value
            End Set
        End Property
#End Region '(Set|Get) 

#Region "[On] |2019/07/08 18h11:602| <01.00.09> <Property> <List> |.List_Tbl_Group()|List(Of Tbl_Group)|"' (Set|Get) 
        Private _List_Tbl_Group As List(Of Tbl_Group)
        '''    <Summary>
        '''     (Set|Get) 
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:197 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("List"), Description("(Set|Get) ")>
        Public Property List_Tbl_Group() As List(Of Tbl_Group)
            Get
                Return _List_Tbl_Group
            End Get
            Set(ByVal Value As List(Of Tbl_Group))
                _List_Tbl_Group = Value
            End Set
        End Property
#End Region '(Set|Get) 

#Region "[On] |2019/07/08 18h11:607| <01.00.10> <Property> <Virtualized Properties> |.Tbl_GroupTotaux()|Tbl_GroupTotaux|"' (Set|Get) 
        Private _Tbl_GroupTotaux As Tbl_GroupTotaux
        '''    <Summary>
        '''     (Set|Get) 
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:197 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Virtualized Properties"), Description("(Set|Get) ")>
        Public Property Tbl_GroupTotaux() As Tbl_GroupTotaux
            Get
                Return _Tbl_GroupTotaux
            End Get
            Set(ByVal Value As Tbl_GroupTotaux)
                _Tbl_GroupTotaux = Value
            End Set
        End Property
#End Region '(Set|Get) 

#Region "[On] |2019/07/08 18h11:613| <01.00.11> <Property> <List> |.List_Tbl_GroupTotaux()|List(Of Tbl_GroupTotaux)|"' (Set|Get) 
        Private _List_Tbl_GroupTotaux As List(Of Tbl_GroupTotaux)
        '''    <Summary>
        '''     (Set|Get) 
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:197 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("List"), Description("(Set|Get) ")>
        Public Property List_Tbl_GroupTotaux() As List(Of Tbl_GroupTotaux)
            Get
                Return _List_Tbl_GroupTotaux
            End Get
            Set(ByVal Value As List(Of Tbl_GroupTotaux))
                _List_Tbl_GroupTotaux = Value
            End Set
        End Property
#End Region '(Set|Get) 

#Region "[On] |2019/07/08 18h11:620| <01.00.12> <Property> <Virtualized Properties> |.Tbl_Periode()|Tbl_Periode|"' (Set|Get) 
        Private _Tbl_Periode As Tbl_Periode
        '''    <Summary>
        '''     (Set|Get) 
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:198 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Virtualized Properties"), Description("(Set|Get) ")>
        Public Property Tbl_Periode() As Tbl_Periode
            Get
                Return _Tbl_Periode
            End Get
            Set(ByVal Value As Tbl_Periode)
                _Tbl_Periode = Value
            End Set
        End Property
#End Region '(Set|Get) 

#Region "[On] |2019/07/08 18h11:625| <01.00.13> <Property> <List> |.List_Tbl_Periode()|List(Of Tbl_Periode)|"' (Set|Get) 
        Private _List_Tbl_Periode As List(Of Tbl_Periode)
        '''    <Summary>
        '''     (Set|Get) 
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:198 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("List"), Description("(Set|Get) ")>
        Public Property List_Tbl_Periode() As List(Of Tbl_Periode)
            Get
                Return _List_Tbl_Periode
            End Get
            Set(ByVal Value As List(Of Tbl_Periode))
                _List_Tbl_Periode = Value
            End Set
        End Property
#End Region '(Set|Get) 

#Region "[On] |2019/07/08 18h11:631| <01.00.14> <Property> <Virtualized Properties> |.Tbl_PieceType()|Tbl_PieceType|"' (Set|Get) 
        Private _Tbl_PieceType As Tbl_PieceType
        '''    <Summary>
        '''     (Set|Get) 
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:198 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Virtualized Properties"), Description("(Set|Get) ")>
        Public Property Tbl_PieceType() As Tbl_PieceType
            Get
                Return _Tbl_PieceType
            End Get
            Set(ByVal Value As Tbl_PieceType)
                _Tbl_PieceType = Value
            End Set
        End Property
#End Region '(Set|Get) 

#Region "[On] |2019/07/08 18h11:646| <01.00.15> <Property> <List> |.List_Tbl_PieceType()|List(Of Tbl_PieceType)|"' (Set|Get) 
        Private _List_Tbl_PieceType As List(Of Tbl_PieceType)
        '''    <Summary>
        '''     (Set|Get) 
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:198 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("List"), Description("(Set|Get) ")>
        Public Property List_Tbl_PieceType() As List(Of Tbl_PieceType)
            Get
                Return _List_Tbl_PieceType
            End Get
            Set(ByVal Value As List(Of Tbl_PieceType))
                _List_Tbl_PieceType = Value
            End Set
        End Property
#End Region '(Set|Get) 

#Region "[On] |2019/07/08 18h11:652| <01.00.16> <Property> <Virtualized Properties> |.Tbl_Plan_Comptable()|Tbl_Plan_Comptable|"' (Set|Get) 
        Private _Tbl_Plan_Comptable As Tbl_Plan_Comptable
        '''    <Summary>
        '''     (Set|Get) 
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:198 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Virtualized Properties"), Description("(Set|Get) ")>
        Public Property Tbl_Plan_Comptable() As Tbl_Plan_Comptable
            Get
                Return _Tbl_Plan_Comptable
            End Get
            Set(ByVal Value As Tbl_Plan_Comptable)
                _Tbl_Plan_Comptable = Value
            End Set
        End Property
#End Region '(Set|Get) 

#Region "[On] |2019/07/08 18h11:658| <01.00.17> <Property> <List> |.List_Tbl_Plan_Comptable()|List(Of Tbl_Plan_Comptable)|"' (Set|Get) 
        Private _List_Tbl_Plan_Comptable As List(Of Tbl_Plan_Comptable)
        '''    <Summary>
        '''     (Set|Get) 
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:199 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("List"), Description("(Set|Get) ")>
        Public Property List_Tbl_Plan_Comptable() As List(Of Tbl_Plan_Comptable)
            Get
                Return _List_Tbl_Plan_Comptable
            End Get
            Set(ByVal Value As List(Of Tbl_Plan_Comptable))
                _List_Tbl_Plan_Comptable = Value
            End Set
        End Property
#End Region '(Set|Get) 

#Region "[On] |2019/07/08 18h11:664| <01.00.18> <Property> <Virtualized Properties> |.Tbl_Totaux()|Tbl_Totaux|"' (Set|Get) 
        Private _Tbl_Totaux As Tbl_Totaux
        '''    <Summary>
        '''     (Set|Get) 
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:199 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("Virtualized Properties"), Description("(Set|Get) ")>
        Public Property Tbl_Totaux() As Tbl_Totaux
            Get
                Return _Tbl_Totaux
            End Get
            Set(ByVal Value As Tbl_Totaux)
                _Tbl_Totaux = Value
            End Set
        End Property
#End Region '(Set|Get) 

#Region "[On] |2019/07/08 18h11:671| <01.00.19> <Property> <List> |.List_Tbl_Totaux()|List(Of Tbl_Totaux)|"' (Set|Get) 
        Private _List_Tbl_Totaux As List(Of Tbl_Totaux)
        '''    <Summary>
        '''     (Set|Get) 
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:199 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), CategoryAttribute("List"), Description("(Set|Get) ")>
        Public Property List_Tbl_Totaux() As List(Of Tbl_Totaux)
            Get
                Return _List_Tbl_Totaux
            End Get
            Set(ByVal Value As List(Of Tbl_Totaux))
                _List_Tbl_Totaux = Value
            End Set
        End Property
#End Region '(Set|Get) 

#Region "[On] |2019/07/08 18h11:679| <01.00.20> <Property> <Portfolio> |.Portfolio()|List(Of Object)|"' (Set|Get) 
        Private Shared _Portfolio As List(Of Object)
        '''    <Summary>
        '''     (Set|Get) 
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:199 </Published>
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

#Region "[On] |2019/07/08 18h11:685| <01.00.21> <Property> <DataBase> |.DataBase()|SmartCoder.M_FileManager.DataBase|"' (Set|Get) 
        Private Shared _DataBase As SmartCoder.M_FileManager.DataBase
        '''    <Summary>
        '''     (Set|Get) 
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:200 </Published>
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
#Region "[On] |2019/07/08 18h11:691| <04.00.00> <Sub> <> |.Clear()|Sub}|"' (Set|Get) This will reinitialize the class properties element.
        '''    <Summary>
        '''     (Set|Get) This will reinitialize the class properties element.
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:200 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) This will reinitialize the class properties element.")>
        Public Sub Clear()
            With Me
                .Tbl_CodeRegroupement = New Tbl_CodeRegroupement
                .List_Tbl_CodeRegroupement = New List(Of Tbl_CodeRegroupement)
                .Tbl_CurrencyRatio = New Tbl_CurrencyRatio
                .List_Tbl_CurrencyRatio = New List(Of Tbl_CurrencyRatio)
                .Tbl_Entries = New Tbl_Entries
                .List_Tbl_Entries = New List(Of Tbl_Entries)
                .Tbl_Entries_Line = New Tbl_Entries_Line
                .List_Tbl_Entries_Line = New List(Of Tbl_Entries_Line)
                .Tbl_Group = New Tbl_Group
                .List_Tbl_Group = New List(Of Tbl_Group)
                .Tbl_GroupTotaux = New Tbl_GroupTotaux
                .List_Tbl_GroupTotaux = New List(Of Tbl_GroupTotaux)
                .Tbl_Periode = New Tbl_Periode
                .List_Tbl_Periode = New List(Of Tbl_Periode)
                .Tbl_PieceType = New Tbl_PieceType
                .List_Tbl_PieceType = New List(Of Tbl_PieceType)
                .Tbl_Plan_Comptable = New Tbl_Plan_Comptable
                .List_Tbl_Plan_Comptable = New List(Of Tbl_Plan_Comptable)
                .Tbl_Totaux = New Tbl_Totaux
                .List_Tbl_Totaux = New List(Of Tbl_Totaux)
                Portfolio = New List(Of Object)
                DataBase = New SmartCoder.M_FileManager.DataBase
            End With
        End Sub
#End Region '(Set|Get) This will reinitialize the class properties element.

#End Region
#Region "<5> [Function]{1}"
#Region "[On] |2019/07/08 18h11:698| <05.00.00> <Function> <> |.CheckConnection()|Boolean}|"' (Set|Get) Evaluate the connection to the DataBase
        '''    <Summary>
        '''     (Set|Get) Evaluate the connection to the DataBase
        '''    <AuthorEmail>saadry.dunkel@outlook.com</AuthorEmail>
        '''    <AuthorName>Saadry Dunkel</AuthorName>
        '''    <AuthorUri>https://www.saadry-dunkel.com</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:201 </Published>
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
                    Me.Connector = New LineInfo(FilePath, Password)
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
#Region "[On] |2019/07/08 18h11:705| <15.00.00> <Runtime> <> |.Line()|String"' (Set|Get) The Connection String To the Table.
        '''    <Summary>
        '''     (Set|Get) The Connection String To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:201 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Connection String To the Table.")>
        Public Line As String
#End Region '(Set|Get) The Connection String To the Table.

#Region "[On] |2019/07/08 18h11:712| <15.00.01> <Runtime> <> |.FilePath()|String"' (Set|Get) The FilePath To the Table.
        '''    <Summary>
        '''     (Set|Get) The FilePath To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:201 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The FilePath To the Table.")>
        Public FilePath As String
#End Region '(Set|Get) The FilePath To the Table.

#Region "[On] |2019/07/08 18h11:719| <15.00.02> <Runtime> <> |.Password()|String"' (Set|Get) The Password To the Table.
        '''    <Summary>
        '''     (Set|Get) The Password To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:201 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Password To the Table.")>
        Public Password As String
#End Region '(Set|Get) The Password To the Table.

#Region "[On] |2019/07/08 18h11:727| <15.00.03> <Runtime> <> |.Connector()|LineInfo"' (Set|Get) The Connector To the Table.
        '''    <Summary>
        '''     (Set|Get) The Connector To the Table.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:201 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The Connector To the Table.")>
        Public Connector As LineInfo
#End Region '(Set|Get) The Connector To the Table.

#End Region
#Region "<7> [Loader]{2}"
#Region "[On] |2019/07/08 18h11:734| <06.00.00> <Loader> <> |.Empty()|Function}|"' (Set|Get) The sub Empty.
        '''    <Summary>
        '''     (Set|Get) The sub Empty.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:202 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>
        <Browsable(True), Description("(Set|Get) The sub Empty.")>
        Public Sub New()
            Clear
        End Sub
#End Region '(Set|Get) The sub Empty.

#Region "[On] |2019/07/08 18h11:736| <06.00.01> <Loader> <> |.Filled()|Function}|"' (Set|Get) The sub Filled.
        '''    <Summary>
        '''     (Set|Get) The sub Filled.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From MASTER\Saadry | Time : 2019/07/08 18h11:202 </Published>
        '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>    ''' <param name="FilePath">The initial File Path</param>
        ''' <param name="Password">The password</param>

        <Browsable(True), Description("(Set|Get) The sub Filled.")>
        Public Sub New(ByVal FilePath As String,
Optional ByVal Password As String = """")
            With Me
                Clear()
                .Tbl_CodeRegroupement = New Tbl_CodeRegroupement
                .List_Tbl_CodeRegroupement = New List(Of Tbl_CodeRegroupement)
                .Tbl_CurrencyRatio = New Tbl_CurrencyRatio
                .List_Tbl_CurrencyRatio = New List(Of Tbl_CurrencyRatio)
                .Tbl_Entries = New Tbl_Entries
                .List_Tbl_Entries = New List(Of Tbl_Entries)
                .Tbl_Entries_Line = New Tbl_Entries_Line
                .List_Tbl_Entries_Line = New List(Of Tbl_Entries_Line)
                .Tbl_Group = New Tbl_Group
                .List_Tbl_Group = New List(Of Tbl_Group)
                .Tbl_GroupTotaux = New Tbl_GroupTotaux
                .List_Tbl_GroupTotaux = New List(Of Tbl_GroupTotaux)
                .Tbl_Periode = New Tbl_Periode
                .List_Tbl_Periode = New List(Of Tbl_Periode)
                .Tbl_PieceType = New Tbl_PieceType
                .List_Tbl_PieceType = New List(Of Tbl_PieceType)
                .Tbl_Plan_Comptable = New Tbl_Plan_Comptable
                .List_Tbl_Plan_Comptable = New List(Of Tbl_Plan_Comptable)
                .Tbl_Totaux = New Tbl_Totaux
                .List_Tbl_Totaux = New List(Of Tbl_Totaux)
                Portfolio = New List(Of Object)
                DataBase = New SmartCoder.M_FileManager.DataBase
            End With
            Portfolio = New List(Of Object)
            FilePath = FilePath
            Password = Password
            Line = Line
            Dim M As New LineInfo(FilePath, Password)
            My.Settings.Db_Accountis_FilePath = FilePath
            My.Settings.Db_Accountis_Password = Password
            My.Settings.Db_Accountis_Line = Line
            My.Settings.Save
            With Tbl_CodeRegroupement
                .Reset(M)
            End With
            List_Tbl_CodeRegroupement = New List(Of Tbl_CodeRegroupement)
            List_Tbl_CodeRegroupement = Tbl_CodeRegroupement.List()
            With Tbl_CurrencyRatio
                .Reset(M)
            End With
            List_Tbl_CurrencyRatio = New List(Of Tbl_CurrencyRatio)
            List_Tbl_CurrencyRatio = Tbl_CurrencyRatio.List()
            With Tbl_Entries
                .Reset(M)
            End With
            List_Tbl_Entries = New List(Of Tbl_Entries)
            List_Tbl_Entries = Tbl_Entries.List()
            With Tbl_Entries_Line
                .Reset(M)
            End With
            List_Tbl_Entries_Line = New List(Of Tbl_Entries_Line)
            List_Tbl_Entries_Line = Tbl_Entries_Line.List()
            With Tbl_Group
                .Reset(M)
            End With
            List_Tbl_Group = New List(Of Tbl_Group)
            List_Tbl_Group = Tbl_Group.List()
            With Tbl_GroupTotaux
                .Reset(M)
            End With
            List_Tbl_GroupTotaux = New List(Of Tbl_GroupTotaux)
            List_Tbl_GroupTotaux = Tbl_GroupTotaux.List()
            With Tbl_Periode
                .Reset(M)
            End With
            List_Tbl_Periode = New List(Of Tbl_Periode)
            List_Tbl_Periode = Tbl_Periode.List()
            With Tbl_PieceType
                .Reset(M)
            End With
            List_Tbl_PieceType = New List(Of Tbl_PieceType)
            List_Tbl_PieceType = Tbl_PieceType.List()
            With Tbl_Plan_Comptable
                .Reset(M)
            End With
            List_Tbl_Plan_Comptable = New List(Of Tbl_Plan_Comptable)
            List_Tbl_Plan_Comptable = Tbl_Plan_Comptable.List()
            With Tbl_Totaux
                .Reset(M)
            End With
            List_Tbl_Totaux = New List(Of Tbl_Totaux)
            List_Tbl_Totaux = Tbl_Totaux.List()

        End Sub
#End Region '(Set|Get) The sub Filled.

#End Region
    End Class
#End Region
#End Region

End Module
