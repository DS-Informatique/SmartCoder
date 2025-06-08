Imports System.Collections.Specialized
Imports System.ComponentModel
Imports System.IO
Imports System.Management
Imports System.Windows.Forms
''' <summary>
''' Information about your computer
''' </summary>
Public Module M_Computer


#Region "|08.00| [MyComputer]"
    Public NotInheritable Class MyComputer
#Region "|1| [Property]"
#Region "|01.00| <Property> [Info]{3}"
#Region "[On] |2019/05/20 20h08:497| <01.00.00> <Property> <Info> |.Name()|String|"' (Set|Get) The Name as String.
        Private _Name As String
        '''    <Summary>
        '''     (Set|Get) The Name as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From  | Time : 2019/05/20 20h08:504 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''    
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>

        <Browsable(True), CategoryAttribute("Info"), Description("(Set|Get) The Name as String.")>
        Public Property Name() As String
            Get
                Return _Name
            End Get
            Set(ByVal Value As String)
                _Name = Value
            End Set
        End Property
#End Region '(Set|Get) The Name as String.
#Region "[On] |2019/05/20 20h09:724| <01.00.01> <Property> <Info> |.DomainName()|String|"' (Set|Get) The DomainName as String.
        Private _DomainName As String
        '''    <Summary>
        '''     (Set|Get) The DomainName as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From  | Time : 2019/05/20 20h09:729 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''    
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>

        <Browsable(True), CategoryAttribute("Info"), Description("(Set|Get) The DomainName as String.")>
        Public Property DomainName() As String
            Get
                Return _DomainName
            End Get
            Set(ByVal Value As String)
                _DomainName = Value
            End Set
        End Property
#End Region '(Set|Get) The DomainName as String.
#Region "[On] |2019/05/20 20h10:743| <01.00.02> <Property> <Info> |.IP()|String|"' (Set|Get) The IP as String.
        Private _IP As String
        '''    <Summary>
        '''     (Set|Get) The IP as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From  | Time : 2019/05/20 20h10:749 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''    
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>

        <Browsable(True), CategoryAttribute("Info"), Description("(Set|Get) The IP as String.")>
        Public Property IP() As String
            Get
                Return _IP
            End Get
            Set(ByVal Value As String)
                _IP = Value
            End Set
        End Property
#End Region '(Set|Get) The IP as String.
#End Region
#Region "|01.01| <Property> [System]{5}"
#Region "[On] |2019/05/20 20h11:061| <01.01.00> <Property> <System> |.Processor()|String|"' (Set|Get) The Processor as String.
        Private _Processor As String
        '''    <Summary>
        '''     (Set|Get) The Processor as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From  | Time : 2019/05/20 20h11:068 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''    
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>

        <Browsable(True), CategoryAttribute("System"), Description("(Set|Get) The Processor as String.")>
        Public Property Processor() As String
            Get
                Return _Processor
            End Get
            Set(ByVal Value As String)
                _Processor = Value
            End Set
        End Property
#End Region '(Set|Get) The Processor as String.
#Region "[On] |2019/05/20 20h12:722| <01.01.01> <Property> <System> |.Ram()|String|"' (Set|Get) The Ram as String.
        Private _Ram As String
        '''    <Summary>
        '''     (Set|Get) The Ram as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From  | Time : 2019/05/20 20h12:727 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''    
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>

        <Browsable(True), CategoryAttribute("System"), Description("(Set|Get) The Ram as String.")>
        Public Property Ram() As String
            Get
                Return _Ram
            End Get
            Set(ByVal Value As String)
                _Ram = Value
            End Set
        End Property
#End Region '(Set|Get) The Ram as String.
#Region "[On] |2019/05/20 20h12:351| <01.01.02> <Property> <System> |.System_Type()|String|"' (Set|Get) The System_Type as String.
        Private _System_Type As String
        '''    <Summary>
        '''     (Set|Get) The System_Type as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From  | Time : 2019/05/20 20h12:357 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''    
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>

        <Browsable(True), CategoryAttribute("System"), Description("(Set|Get) The System_Type as String.")>
        Public Property System_Type() As String
            Get
                Return _System_Type
            End Get
            Set(ByVal Value As String)
                _System_Type = Value
            End Set
        End Property
#End Region '(Set|Get) The System_Type as String.
#Region "[On] |2019/05/20 20h13:984| <01.01.03> <Property> <System> |.Base_Processor()|String|"' (Set|Get) The Base_Processor as String.
        Private _Base_Processor As String
        '''    <Summary>
        '''     (Set|Get) The Base_Processor as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From  | Time : 2019/05/20 20h13:991 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''    
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>

        <Browsable(True), CategoryAttribute("System"), Description("(Set|Get) The Base_Processor as String.")>
        Public Property Base_Processor() As String
            Get
                Return _Base_Processor
            End Get
            Set(ByVal Value As String)
                _Base_Processor = Value
            End Set
        End Property
#End Region '(Set|Get) The Base_Processor as String.
#Region "[On] |2019/05/20 20h14:772| <01.01.04> <Property> <System> |.OperatingSystem()|String|"' (Set|Get) The OperatingSystem as String.
        Private _OperatingSystem As String
        '''    <Summary>
        '''     (Set|Get) The OperatingSystem as String.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From  | Time : 2019/05/20 20h14:777 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''    
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>

        <Browsable(True), CategoryAttribute("System"), Description("(Set|Get) The OperatingSystem as String.")>
        Public Property OperatingSystem() As String
            Get
                Return _OperatingSystem
            End Get
            Set(ByVal Value As String)
                _OperatingSystem = Value
            End Set
        End Property
#End Region '(Set|Get) The OperatingSystem as String.
#End Region
#Region "|01.02| <Property> [Hardware]{13}"
#Region "[On] |2019/05/20 20h16:085| <01.02.00> <Property> <Hardware> |.Printers()|List(Of Printer)|"' (Set|Get) The Printers as List(Of Printer).
        Private _Printers As List(Of Printer)
        '''    <Summary>
        '''     (Set|Get) The Printers as List(Of Printer).
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From  | Time : 2019/05/20 20h16:091 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''    
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>

        <Browsable(True), CategoryAttribute("Hardware"), Description("(Set|Get) The Printers as List(Of Printer).")>
        Public Property Printers() As List(Of Printer)
            Get
                Return _Printers
            End Get
            Set(ByVal Value As List(Of Printer))
                _Printers = Value
            End Set
        End Property
#End Region '(Set|Get) The Printers as List(Of Printer).
#Region "|01.02.01| <Property> <Hardware> [Drives]{9}"
#Region "[On] |2019/05/21 00h12:818| <01.02.00> <Property> <Drives> |.LocalDrivesCount()|Integer|"' (Get) The LocalDrivesCount as Integer.
        Private _LocalDrivesCount As Integer
        '''    <Summary>
        '''     (Get) The LocalDrivesCount as Integer.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From  | Time : 2019/05/21 00h12:824 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''    
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>

        <Browsable(True), CategoryAttribute("Drives"), Description("(Get) The LocalDrivesCount as Integer.")>
        Public ReadOnly Property LocalDrivesCount() As Integer
            Get
                Return _LocalDrivesCount
            End Get
        End Property
#End Region '(Get) The LocalDrivesCount as Integer.
#Region "[On] |2019/05/21 00h13:184| <01.02.01> <Property> <Drives> |.TotalSize()|SizeInfo|"' (Get) The TotalSize as SizeInfo.
        Private _TotalSize As SizeInfo
        '''    <Summary>
        '''     (Get) The TotalSize as SizeInfo.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From  | Time : 2019/05/21 00h13:191 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''    
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>

        <Browsable(True), CategoryAttribute("Drives"), Description("(Get) The TotalSize as SizeInfo.")>
        Public ReadOnly Property TotalSize() As SizeInfo
            Get
                Return _TotalSize
            End Get
        End Property
#End Region '(Get) The TotalSize as SizeInfo.
#Region "[On] |2019/05/21 00h15:852| <01.02.02> <Property> <Drives> |.AvailableSize()|SizeInfo|"' (Get) The AvailableSize as SizeInfo.
        Private _AvailableSize As SizeInfo
        '''    <Summary>
        '''     (Get) The AvailableSize as SizeInfo.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From  | Time : 2019/05/21 00h15:860 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''    
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>

        <Browsable(True), CategoryAttribute("Drives"), Description("(Get) The AvailableSize as SizeInfo.")>
        Public ReadOnly Property AvailableSize() As SizeInfo
            Get
                Return _AvailableSize
            End Get
        End Property
#End Region '(Get) The AvailableSize as SizeInfo.
#Region "[On] |2019/05/21 00h15:194| <01.02.03> <Property> <Drives> |.UsedSize()|SizeInfo|"' (Get) The UsedSize as SizeInfo.
        Private _UsedSize As SizeInfo
        '''    <Summary>
        '''     (Get) The UsedSize as SizeInfo.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From  | Time : 2019/05/21 00h15:200 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''    
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>

        <Browsable(True), CategoryAttribute("Drives"), Description("(Get) The UsedSize as SizeInfo.")>
        Public ReadOnly Property UsedSize() As SizeInfo
            Get
                Return _UsedSize
            End Get
        End Property
#End Region '(Get) The UsedSize as SizeInfo.
#Region "[On] |2019/05/21 00h17:099| <01.02.04> <Property> <Drives> |.LocalDrive()|List(Of Drive)|"' (Set|Get) The LocalDrive as List(Of Drive).
        Private _LocalDrive As List(Of Drive)
        '''    <Summary>
        '''     (Set|Get) The LocalDrive as List(Of Drive).
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From  | Time : 2019/05/21 00h17:105 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''    
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>

        <Browsable(True), CategoryAttribute("Drives"), Description("(Set|Get) The LocalDrive as List(Of Drive).")>
        Public Property LocalDrive() As List(Of Drive)
            Get
                Return _LocalDrive
            End Get
            Set(ByVal Value As List(Of Drive))
                _LocalDrive = Value
            End Set
        End Property
#End Region '(Set|Get) The LocalDrive as List(Of Drive).
#Region "[On] |2019/05/21 00h18:699| <01.02.05> <Property> <Drives> |.NetworkDrive()|List(Of Drive)|"' (Set|Get) The NetworkDrive as List(Of Drive).
        Private _NetworkDrive As List(Of Drive)
        '''    <Summary>
        '''     (Set|Get) The NetworkDrive as List(Of Drive).
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From  | Time : 2019/05/21 00h18:707 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''    
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>

        <Browsable(True), CategoryAttribute("Drives"), Description("(Set|Get) The NetworkDrive as List(Of Drive).")>
        Public Property NetworkDrive() As List(Of Drive)
            Get
                Return _NetworkDrive
            End Get
            Set(ByVal Value As List(Of Drive))
                _NetworkDrive = Value
            End Set
        End Property
#End Region '(Set|Get) The NetworkDrive as List(Of Drive).
#Region "[On] |2019/05/21 00h19:070| <01.02.06> <Property> <Drives> |.DVDDrive()|List(Of Drive)|"' (Set|Get) The DVDDrive as List(Of Drive).
        Private _DVDDrive As List(Of Drive)
        '''    <Summary>
        '''     (Set|Get) The DVDDrive as List(Of Drive).
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From  | Time : 2019/05/21 00h19:078 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''    
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>

        <Browsable(True), CategoryAttribute("Drives"), Description("(Set|Get) The DVDDrive as List(Of Drive).")>
        Public Property DVDDrive() As List(Of Drive)
            Get
                Return _DVDDrive
            End Get
            Set(ByVal Value As List(Of Drive))
                _DVDDrive = Value
            End Set
        End Property
#End Region '(Set|Get) The DVDDrive as List(Of Drive).
#Region "[On] |2019/05/21 00h19:977| <01.02.07> <Property> <Drives> |.USBDrive()|List(Of Drive)|"' (Set|Get) The USBDrive as List(Of Drive).
        Private _USBDrive As List(Of Drive)
        '''    <Summary>
        '''     (Set|Get) The USBDrive as List(Of Drive).
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From  | Time : 2019/05/21 00h19:982 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''    
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>

        <Browsable(True), CategoryAttribute("Drives"), Description("(Set|Get) The USBDrive as List(Of Drive).")>
        Public Property USBDrive() As List(Of Drive)
            Get
                Return _USBDrive
            End Get
            Set(ByVal Value As List(Of Drive))
                _USBDrive = Value
            End Set
        End Property
#End Region '(Set|Get) The USBDrive as List(Of Drive).
#Region "[On] |2019/05/21 00h21:590| <01.02.08> <Property> <Drives> |.Drives()|List(Of Drive)|"' (Set|Get) The Drives as Lecteur.
        Private _Drives As List(Of Drive)
        '''    <Summary>
        '''     (Set|Get) The Drives as Lecteur.
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From  | Time : 2019/05/21 00h21:597 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''    
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>

        <Browsable(True), CategoryAttribute("Drives"), Description("(Set|Get) The Drives as Lecteur.")>
        Public Property Drives() As List(Of Drive)
            Get
                Return _Drives
            End Get
            Set(ByVal Value As List(Of Drive))
                _Drives = Value
            End Set
        End Property
#End Region '(Set|Get) The Drives as Lecteur.
#End Region
#Region "|01.02.02| <Property> <Hardware> [Devices][2]"
#Region "[On] |2019/05/21 00h23:743| <01.02.02.00> <Property> <Hardware> <Devices> |.WorkingDevices()|List(Of Device)|"' (Set|Get) The WorkingDevices as List(Of Device).
        Private _WorkingDevices As List(Of Device)
        '''    <Summary>
        '''     (Set|Get) The WorkingDevices as List(Of Device).
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From  | Time : 2019/05/21 00h23:749 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''    
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>

        <Browsable(True), CategoryAttribute("Devices"), Description("(Set|Get) The WorkingDevices as List(Of Device).")>
        Public Property WorkingDevices() As List(Of Device)
            Get
                Return _WorkingDevices
            End Get
            Set(ByVal Value As List(Of Device))
                _WorkingDevices = Value
            End Set
        End Property
#End Region '(Set|Get) The WorkingDevices as List(Of Device).
#Region "[On] |2019/05/21 00h24:518| <01.02.02.01> <Property> <Hardware> <Devices> |.NonWorkingDevices()|List(Of Device)|"' (Set|Get) The NonWorkingDevices as List(Of Device).
        Private _NonWorkingDevices As List(Of Device)
        '''    <Summary>
        '''     (Set|Get) The NonWorkingDevices as List(Of Device).
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From  | Time : 2019/05/21 00h24:523 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''    
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>

        <Browsable(True), CategoryAttribute("Device"), Description("(Set|Get) The NonWorkingDevices as List(Of Device).")>
        Public Property NonWorkingDevices() As List(Of Device)
            Get
                Return _NonWorkingDevices
            End Get
            Set(ByVal Value As List(Of Device))
                _NonWorkingDevices = Value
            End Set
        End Property
#End Region '(Set|Get) The NonWorkingDevices as List(Of Device).
#End Region
#End Region
#Region "|01.03| <Property> [Software]{1}"
#Region "[On] |2019/05/21 00h28:711| <01.03.00> <Property> <Software> |.MyPrograms()|List(Of Software)|"' (Set|Get) The MyPrograms as List(Of Software).
        Private _MyPrograms As List(Of Software)
        '''    <Summary>
        '''     (Set|Get) The MyPrograms as List(Of Software).
        '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
        '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
        '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
        '''    <Published>MASTER From  | Time : 2019/05/21 00h28:717 </Published>
        '''      <Rights>
        '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
        '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
        '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
        '''    taken out of the classroom.
        '''    
        '''       </Rights>
        ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
        '''    </Summary>

        <Browsable(True), CategoryAttribute("Software"), Description("(Set|Get) The MyPrograms as List(Of Software).")>
        Public Property MyPrograms() As List(Of Software)
            Get
                Return _MyPrograms
            End Get
            Set(ByVal Value As List(Of Software))
                _MyPrograms = Value
            End Set
        End Property
#End Region '(Set|Get) The MyPrograms as List(Of Software).

#End Region
#End Region
#Region "|5| [Funtion]"
#Region "|05.00| <Function> [DetectOS()|String]"
        Public Function DetectOS() As String
            Dim Result As String = ""
            Dim iPC As String = My.Computer.Info.OSFullName
            If iPC.Contains(WIndows_OS.OS_W7.ToString) Then
                'Windows 7
                Result = WIndows_OS.OS_W7.ToString
            ElseIf iPC.Contains(WIndows_OS.OS_WVi.ToString) Then
                'Windows Vista
                Result = WIndows_OS.OS_WVi.ToString
            ElseIf iPC.Contains(WIndows_OS.OS_WXP.ToString) Then
                'Windows XP
                Result = WIndows_OS.OS_WXP.ToString
            ElseIf iPC.Contains(WIndows_OS.OS_W8.ToString) Then
                'Windows 8
                Result = WIndows_OS.OS_W8.ToString
            ElseIf iPC.Contains(WIndows_OS.OS_W10.ToString) Then
                'Windows 10
                Result = WIndows_OS.OS_W10.ToString
            ElseIf iPC.Contains(WIndows_OS.OS_S3.ToString) Then
                'Windows Server 2003
                Result = WIndows_OS.OS_S3.ToString
            ElseIf iPC.Contains(WIndows_OS.OS_S8.ToString) Then
                'Windows Server 2008
                Result = WIndows_OS.OS_S8.ToString
            ElseIf iPC.Contains(WIndows_OS.OS_S12.ToString) Then
                'Windows Server 2012
                Result = WIndows_OS.OS_S12.ToString
            ElseIf iPC.Contains(WIndows_OS.OS_S16.ToString) Then
                'Windows Server 2016
                Result = WIndows_OS.OS_S16.ToString
            End If

            Return Result
        End Function
#End Region
#End Region
#Region "|7| [Loader]"
#Region "|07.00| <Loader> [Empty]"
        Public Sub New()
            With Me
                .Base_Processor = IIf(Environment.Is64BitProcess = True, "x64-base-processor", "x32-base-processor")
                .DomainName = System.Net.Dns.GetHostName
                .Drives = New List(Of Drive)
                .DVDDrive = New List(Of Drive)
                .IP = ""
                .LocalDrive = New List(Of Drive)
                .MyPrograms = New List(Of Software)
                .Name = My.Computer.Name
                .NetworkDrive = New List(Of Drive)
                .NonWorkingDevices = New List(Of Device)
                .OperatingSystem = DetectOS()
                .Printers = New List(Of Printer)
                .Processor = IIf(Environment.Is64BitOperatingSystem = True, "64 Bits", "32 Bits")
                .Ram = New SizeInfo(My.Computer.Info.TotalPhysicalMemory).Display
                .System_Type = .Processor & " " & .Base_Processor
                .USBDrive = New List(Of Drive)
                .WorkingDevices = New List(Of Device)
                Dim Lecture As New Lecteur

                With Lecture
                    .Clear()
                    Me.Drives = .Drives
                    Me.LocalDrive = .Local
                    _LocalDrivesCount = Me.LocalDrive.Count - 1
                    Dim T0 As Double = 0
                    Dim TA As Double = 0
                    Dim TU As Double = 0
                    For Each D As Drive In Me.LocalDrive
                        T0 += D.TotalSize.Raw
                        TA += D.AvailableFreeSpace.Raw
                        TU += D.UsedSize.Raw
                    Next
                    Me._UsedSize = New SizeInfo(TU)
                    Me._AvailableSize = New SizeInfo(TA)
                    Me._TotalSize = New SizeInfo(T0)
                    Me.NetworkDrive = .Network
                    Me.USBDrive = .USB
                    Me.DVDDrive = .DVD
                End With
                .MyPrograms = Software.ListSoftwares
                .Printers = Printer.ListPrinters
                .WorkingDevices = Device.GetAllDevices
                .NonWorkingDevices = Device.GetNonWorkingDevices
            End With
        End Sub
#End Region
#End Region
#Region "|8| [Class]"
#Region "|08.00| <Class> [Hardware]"
#Region "|08.00.00| <Class> <Hardware> [External]"
#Region "|08.00.00.00| <Class> <Hardware> <External> [Printer]"
        Public Class Printer
#Region "|1| [Property]"
#Region "|01.00| <Property> [Index]"
#Region "[On] |2019/05/20 19h43:783| <01.00.00> <Property> <Index> |.Name()|String|"' (Set|Get) The Name as String.
            Private _Name As String
            '''    <Summary>
            '''     (Set|Get) The Name as String.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 19h43:790 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Index"), Description("(Set|Get) The Name as String.")>
            Public Property Name() As String
                Get
                    Return _Name
                End Get
                Set(ByVal Value As String)
                    _Name = Value
                End Set
            End Property
#End Region '(Set|Get) The Name as String.
#Region "[On] |2019/05/20 19h45:933| <01.00.01> <Property> <Index> |.Status()|String|"' (Set|Get) The Status as String.
            Private _Status As String
            '''    <Summary>
            '''     (Set|Get) The Status as String.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 19h45:942 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Index"), Description("(Set|Get) The Status as String.")>
            Public Property Status() As String
                Get
                    Return _Status
                End Get
                Set(ByVal Value As String)
                    _Status = Value
                End Set
            End Property
#End Region '(Set|Get) The Status as String.
#Region "[On] |2019/05/20 19h45:974| <01.00.02> <Property> <Index> |.ByDefault()|String|"' (Set|Get) The ByDefault as String.
            Private _ByDefault As String
            '''    <Summary>
            '''     (Set|Get) The ByDefault as String.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 19h45:981 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Index"), Description("(Set|Get) The ByDefault as String.")>
            Public Property ByDefault() As String
                Get
                    Return _ByDefault
                End Get
                Set(ByVal Value As String)
                    _ByDefault = Value
                End Set
            End Property
#End Region '(Set|Get) The ByDefault as String.
#Region "[On] |2019/05/20 19h46:490| <01.00.03> <Property> <Index> |.Network()|String|"' (Set|Get) The Network as String.
            Private _Network As String
            '''    <Summary>
            '''     (Set|Get) The Network as String.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 19h46:497 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Index"), Description("(Set|Get) The Network as String.")>
            Public Property Network() As String
                Get
                    Return _Network
                End Get
                Set(ByVal Value As String)
                    _Network = Value
                End Set
            End Property
#End Region '(Set|Get) The Network as String.
#End Region
#End Region
#Region "|5| [Function]"
#Region "|05.00| <Function> [ListPrinters()|List(Of Printer)]"
            Public Shared Function ListPrinters() As List(Of Printer)
                Dim Result As New List(Of Printer)
                Dim Query = New ManagementObjectSearcher("Select * From Win32_Printer")
                For Each Item In Query.Get()
                    Dim P As New Printer(Item.GetPropertyValue("Name").ToString, Item.GetPropertyValue("Status").ToString, Item.GetPropertyValue("Default"), Item.GetPropertyValue("Network").ToString)
                    Result.Add(P)
                Next
                Return Result
            End Function
#End Region
#End Region
#Region "|7| [Loader]"
#Region "|07.00| <Loader> [Empty]"
            Public Sub New()
                With Me
                    .ByDefault = ""
                    .Name = ""
                    .Network = ""
                    .Status = ""
                End With
            End Sub
#End Region
#Region "|07.01| <Loader> [Filled]"
            Public Sub New(ByVal Name As String,
                     Optional ByVal Status As String = "",
                     Optional ByVal ByDefault As String = "",
                     Optional ByVal Network As String = "")
                With Me
                    .Name = Name
                    .Status = Status
                    .ByDefault = ByDefault
                    .Network = Network
                End With
            End Sub
#End Region
#End Region
        End Class
#End Region
#End Region
#Region "|08.00.01| <Class> <Hardware> [Internal]"
#Region "|08.00.01.00| <Class> <Hardware> <Internal> [Device]"
        Public Class Device
#Region "|1| [Property]"
#Region "|01.00| <Property> [Info]"
#Region "[On] |2019/05/20 20h20:584| <01.00.00> <Property> <Info> |.Name()|String|"' (Set|Get) The Name as String.
            Private _Name As String
            '''    <Summary>
            '''     (Set|Get) The Name as String.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 20h20:592 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Info"), Description("(Set|Get) The Name as String.")>
            Public Property Name() As String
                Get
                    Return _Name
                End Get
                Set(ByVal Value As String)
                    _Name = Value
                End Set
            End Property
#End Region '(Set|Get) The Name as String.
#Region "[On] |2019/05/20 20h20:518| <01.00.01> <Property> <Info> |.ClassGuid()|String|"' (Set|Get) The ClassGuid as String.
            Private _ClassGuid As String
            '''    <Summary>
            '''     (Set|Get) The ClassGuid as String.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 20h20:524 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Info"), Description("(Set|Get) The ClassGuid as String.")>
            Public Property ClassGuid() As String
                Get
                    Return _ClassGuid
                End Get
                Set(ByVal Value As String)
                    _ClassGuid = Value
                End Set
            End Property
#End Region '(Set|Get) The ClassGuid as String.
#Region "[On] |2019/05/20 20h20:307| <01.00.02> <Property> <Info> |.Service()|String|"' (Set|Get) The Service as String.
            Private _Service As String
            '''    <Summary>
            '''     (Set|Get) The Service as String.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 20h20:312 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Info"), Description("(Set|Get) The Service as String.")>
            Public Property Service() As String
                Get
                    Return _Service
                End Get
                Set(ByVal Value As String)
                    _Service = Value
                End Set
            End Property
#End Region '(Set|Get) The Service as String.
#Region "[On] |2019/05/20 20h26:679| <01.00.04> <Property> <Info> |.Manufacturer()|String|"' (Set|Get) The Manufacturer as String.
            Private _Manufacturer As String
            '''    <Summary>
            '''     (Set|Get) The Manufacturer as String.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 20h26:685 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Info"), Description("(Set|Get) The Manufacturer as String.")>
            Public Property Manufacturer() As String
                Get
                    Return _Manufacturer
                End Get
                Set(ByVal Value As String)
                    _Manufacturer = Value
                End Set
            End Property
#End Region '(Set|Get) The Manufacturer as String.
#Region "[On] |2019/05/20 20h27:891| <01.00.05> <Property> <Info> |.DeviceID()|String|"' (Set|Get) The DeviceID as String.
            Private _DeviceID As String
            '''    <Summary>
            '''     (Set|Get) The DeviceID as String.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 20h27:898 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Info"), Description("(Set|Get) The DeviceID as String.")>
            Public Property DeviceID() As String
                Get
                    Return _DeviceID
                End Get
                Set(ByVal Value As String)
                    _DeviceID = Value
                End Set
            End Property
#End Region '(Set|Get) The DeviceID as String.
#Region "[On] |2019/05/20 20h22:302| <01.00.06> <Property> <Info> |.PNPDeviceID()|String|"' (Set|Get) The PNPDeviceID as String.
            Private _PNPDeviceID As String
            '''    <Summary>
            '''     (Set|Get) The PNPDeviceID as String.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 20h22:307 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Info"), Description("(Set|Get) The PNPDeviceID as String.")>
            Public Property PNPDeviceID() As String
                Get
                    Return _PNPDeviceID
                End Get
                Set(ByVal Value As String)
                    _PNPDeviceID = Value
                End Set
            End Property
#End Region '(Set|Get) The PNPDeviceID as String.
#Region "[On] |2019/05/20 20h31:970| <01.00.07> <Property> <Info> |.Description()|String|"' (Set|Get) The Description as String.
            Private _Description As String
            '''    <Summary>
            '''     (Set|Get) The Description as String.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 20h31:976 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Info"), Description("(Set|Get) The Description as String.")>
            Public Property Description() As String
                Get
                    Return _Description
                End Get
                Set(ByVal Value As String)
                    _Description = Value
                End Set
            End Property
#End Region '(Set|Get) The Description as String.
#End Region
#End Region
#Region "|5| [Function]"
#Region "|05.00| <Function> [GetallDevices()|List(Of Device)]"
            Public Shared Function GetAllDevices() As List(Of Device)
                Dim pc As String = "." 'local
                Dim wmi As Object = GetObject("winmgmts:\\" & pc & "\root\cimv2")
                Dim allDevices As New List(Of Device)
                Dim devices As Object = wmi.ExecQuery("Select * from Win32_PnPEntity")
                Dim device As Device
                For Each d As Object In devices
                    device = New Device
                    With device
                        .ClassGuid = IIf(IsDBNull(d.ClassGuid), 0, d.ClassGuid)
                        .Description = IIf(IsDBNull(d.Description), 0, d.Description)
                        .DeviceID = IIf(IsDBNull(d.DeviceID), 0, d.DeviceID)
                        .Manufacturer = IIf(IsDBNull(d.Manufacturer), 0, d.Manufacturer)
                        .Name = IIf(IsDBNull(d.Name), 0, d.Name)
                        .PNPDeviceID = IIf(IsDBNull(d.PNPDeviceID), 0, d.PNPDeviceID)
                        .Service = IIf(IsDBNull(d.Service), 0, d.Service)
                    End With
                    allDevices.Add(device)
                Next
                Return allDevices
            End Function
#End Region
#Region "|05.01| <Function> <GetNonWorkingDevices()|List(Of Device]"
            Public Shared Function GetNonWorkingDevices() As List(Of Device)
                Dim pc As String = "." 'local
                Dim wmi As Object = GetObject("winmgmts:\\" & pc & "\root\cimv2")
                Dim notWorking As New List(Of Device)
                Dim devices As Object = wmi.ExecQuery("Select * from " &
              "Win32_PnPEntity WHERE ConfigManagerErrorCode &lt;> 0")
                Dim device As Device
                For Each d As Object In devices
                    device = New Device
                    With device
                        .ClassGuid = IIf(IsDBNull(d.ClassGuid), 0, d.ClassGuid)
                        .Description = IIf(IsDBNull(d.Description), 0, d.Description)
                        .DeviceID = IIf(IsDBNull(d.DeviceID), 0, d.DeviceID)
                        .Manufacturer = IIf(IsDBNull(d.Manufacturer), 0, d.Manufacturer)
                        .Name = IIf(IsDBNull(d.Name), 0, d.Name)
                        '.Icon = NativeMethods.GetShellIcon(IIf(IsDBNull(d.fullname), 0, d.Fullname))
                        .PNPDeviceID = IIf(IsDBNull(d.PNPDeviceID), 0, d.PNPDeviceID)
                        .Service = IIf(IsDBNull(d.Service), 0, d.Service)
                    End With
                    notWorking.Add(device)
                Next
                Return notWorking
            End Function
#End Region
#End Region
#Region "|7| [Loader]"
#Region "|07.00| <Loader> [Empty]"
            Public Sub New()
                With Me
                    .ClassGuid = ""
                    .DeviceID = ""
                    .Manufacturer = ""
                    .Name = ""
                    .PNPDeviceID = ""
                    .Service = ""
                End With
            End Sub
#End Region
#Region "|07.00| <Loader> [Filled]"
            Public Sub New(ByVal Name As String,
                           Optional ByVal ClassGuid As String = "",
                           Optional ByVal DeviceID As String = "",
                           Optional ByVal ID As String = "",
                           Optional ByVal Manufacturer As String = "",
                           Optional ByVal PNPDeviceID As String = "",
                           Optional ByVal Service As String = "",
                           Optional ByVal Description As String = "")
                With Me
                    .ClassGuid = ClassGuid
                    .DeviceID = DeviceID
                    .Manufacturer = Manufacturer
                    .Name = Name
                    .PNPDeviceID = PNPDeviceID
                    .Service = Service
                    .Description = Description
                End With
            End Sub
#End Region
#End Region
        End Class
#End Region
#Region "|08.00.01.01| <Class> <Hardware> <Internal> [Drive]"
        Public Class Drive
#Region "|1| [Property]"
#Region "|01.00| <Property> [Info]{5}"
#Region "[On] |2019/05/20 20h43:953| <01.00.00> <Property> <Info> |.Name()| String|"' (Set|Get) The Name as  String.
            Private _Name As String
            '''    <Summary>
            '''     (Set|Get) The Name as  String.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 20h58:514 </Published>
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

            <Browsable(True), CategoryAttribute("Info"), Description("(Set|Get) The Name as  String.")>
            Property Name() As String
                Get
                    Return _Name
                End Get
                Set(ByVal Value As String)
                    _Name = Value
                End Set
            End Property
#End Region '(Set|Get) The Name as  String.
#Region "[On] |2019/05/20 20h45:507| <01.00.01> <Property> <Info> |.Letter()|String|"' (Set|Get) The Letter as String.
            Private _Letter As String
            '''    <Summary>
            '''     (Set|Get) The Letter as String.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 20h58:515 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''   <Example>
            '''    Example would be C:\ 
            '''    </Example>
            ''' '''    </Summary>

            <Browsable(True), CategoryAttribute("Info"), Description("(Set|Get) The Letter as String.")>
            Public Property Letter() As String
                Get
                    Return _Letter
                End Get
                Set(ByVal Value As String)
                    _Letter = Value
                End Set
            End Property
#End Region '(Set|Get) The Letter as String.
#Region "[On] |2019/05/20 20h45:754| <01.00.02> <Property> <Info> |.Type()|DriveType|"' (Set|Get) The Type as DriveType.
            Private _Type As DriveType
            '''    <Summary>
            '''     (Set|Get) The Type as DriveType.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 20h58:515 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Info"), Description("(Set|Get) The Type as DriveType.")>
            Public Property Type() As DriveType
                Get
                    Return _Type
                End Get
                Set(ByVal Value As DriveType)
                    _Type = Value
                End Set
            End Property
#End Region '(Set|Get) The Type as DriveType.
#Region "[On] |2019/05/20 20h47:362| <01.00.03> <Property> <Info> |.SerialNumber()| String|"' (Set|Get) The SerialNumber as  String.
            Private _SerialNumber As String
            '''    <Summary>
            '''     (Set|Get) The SerialNumber as  String.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 20h58:516 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Info"), Description("(Set|Get) The SerialNumber as  String.")>
            Public Property SerialNumber() As String
                Get
                    Return _SerialNumber
                End Get
                Set(ByVal Value As String)
                    _SerialNumber = Value
                End Set
            End Property
#End Region '(Set|Get) The SerialNumber as  String.
#Region "[On] |2019/05/20 20h48:292| <01.00.04> <Property> <Info> |.Target()|String|"' (Set|Get) The Target as String.
            Private _Target As String
            '''    <Summary>
            '''     (Set|Get) The Target as String.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 20h58:516 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Info"), Description("(Set|Get) The Target as String.")>
            Public Property Target() As String
                Get
                    Return _Target
                End Get
                Set(ByVal Value As String)
                    _Target = Value
                End Set
            End Property
#End Region '(Set|Get) The Target as String.
#Region "[On] |2019/05/20 22h53:313| <01.00.05> <Property> <Info> |.ImageIndex()|Integer|"' (Set|Get) The ImageIndex as Integer.
            Private _ImageIndex As Integer
            '''    <Summary>
            '''     (Set|Get) The ImageIndex as Integer.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 22h53:319 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Info"), Description("(Set|Get) The ImageIndex as Integer.")>
            Public Property ImageIndex() As Integer
                Get
                    Return _ImageIndex
                End Get
                Set(ByVal Value As Integer)
                    _ImageIndex = Value
                End Set
            End Property
#End Region '(Set|Get) The ImageIndex as Integer.
#End Region
#Region "|01.01| <Property> [Size]{5}"
#Region "[On] |2019/05/20 20h49:022| <01.01.00> <Property> <Size> |.AvailableFreeSpace()|SizeInfo|"' (Set|Get) The AvailableFreeSpace as SizeInfo.
            Private _AvailableFreeSpace As SizeInfo
            '''    <Summary>
            '''     (Set|Get) The AvailableFreeSpace as SizeInfo.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 20h58:518 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Size"), Description("(Set|Get) The AvailableFreeSpace as SizeInfo.")>
            Public Property AvailableFreeSpace() As SizeInfo
                Get
                    Return _AvailableFreeSpace
                End Get
                Set(ByVal Value As SizeInfo)
                    _AvailableFreeSpace = Value
                End Set
            End Property
#End Region '(Set|Get) The AvailableFreeSpace as SizeInfo.
#Region "[On] |2019/05/20 20h49:539| <01.01.01> <Property> <Size> |.TotalFreeSpace()|SizeInfo|"' (Set|Get) The TotalFreeSpace as SizeInfo.
            Private _TotalFreeSpace As SizeInfo
            '''    <Summary>
            '''     (Set|Get) The TotalFreeSpace as SizeInfo.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 20h58:519 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Size"), Description("(Set|Get) The TotalFreeSpace as SizeInfo.")>
            Public Property TotalFreeSpace() As SizeInfo
                Get
                    Return _TotalFreeSpace
                End Get
                Set(ByVal Value As SizeInfo)
                    _TotalFreeSpace = Value
                End Set
            End Property
#End Region '(Set|Get) The TotalFreeSpace as SizeInfo.
#Region "[On] |2019/05/20 20h50:221| <01.01.02> <Property> <Size> |.TotalSize()|SizeInfo|"' (Set|Get) The TotalSize as SizeInfo.
            Private _TotalSize As SizeInfo
            '''    <Summary>
            '''     (Set|Get) The TotalSize as SizeInfo.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 20h58:519 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Size"), Description("(Set|Get) The TotalSize as SizeInfo.")>
            Public Property TotalSize() As SizeInfo
                Get
                    Return _TotalSize
                End Get
                Set(ByVal Value As SizeInfo)
                    _TotalSize = Value
                End Set
            End Property
#End Region '(Set|Get) The TotalSize as SizeInfo.
#Region "[On] |2019/05/20 20h50:850| <01.01.03> <Property> <Size> |.UsedSize()|SizeInfo|"' (Set|Get) The UsedSize as SizeInfo.
            Private _UsedSize As SizeInfo
            '''    <Summary>
            '''     (Set|Get) The UsedSize as SizeInfo.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 20h58:520 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Size"), Description("(Set|Get) The UsedSize as SizeInfo.")>
            Public Property UsedSize() As SizeInfo
                Get
                    Return _UsedSize
                End Get
                Set(ByVal Value As SizeInfo)
                    _UsedSize = Value
                End Set
            End Property
#End Region '(Set|Get) The UsedSize as SizeInfo.
#Region "[On] |2019/05/20 20h51:426| <01.01.04> <Property> <Size> |.PercentageUsed()|Double|"' (Set|Get) The PercentageUsed as Double.
            Private _PercentageUsed As Double
            '''    <Summary>
            '''     (Set|Get) The PercentageUsed as Double.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 20h58:520 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Size"), Description("(Set|Get) The PercentageUsed as Double.")>
            Public Property PercentageUsed() As Double
                Get
                    Return _PercentageUsed
                End Get
                Set(ByVal Value As Double)
                    _PercentageUsed = Value
                End Set
            End Property
#End Region '(Set|Get) The PercentageUsed as Double.
#Region "[On] |2019/05/20 20h51:614| <01.01.05> <Property> <Size> |.PercentageFree()|Double|"' (Set|Get) The PercentageFree as Double.
            Private _PercentageFree As Double
            '''    <Summary>
            '''     (Set|Get) The PercentageFree as Double.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 20h58:520 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Size"), Description("(Set|Get) The PercentageFree as Double.")>
            Public Property PercentageFree() As Double
                Get
                    Return _PercentageFree
                End Get
                Set(ByVal Value As Double)
                    _PercentageFree = Value
                End Set
            End Property
#End Region '(Set|Get) The PercentageFree as Double.
#End Region
#Region "|01.02| <Property> [Credentials]{3}"
#Region "[On] |2019/05/20 22h14:507| <01.02.00> <Property> <Credentials> |.UserName()|String|"' (Set|Get) The UserName as String.
            Private _UserName As String
            '''    <Summary>
            '''     (Set|Get) The UserName as String.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 22h14:514 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Credentials"), Description("(Set|Get) The UserName as String.")>
            Public Property UserName() As String
                Get
                    Return _UserName
                End Get
                Set(ByVal Value As String)
                    _UserName = Value
                End Set
            End Property
#End Region '(Set|Get) The UserName as String.
#Region "[On] |2019/05/20 22h15:299| <01.02.01> <Property> <Credentials> |.Password()|String|"' (Set|Get) The Password as String.
            Private _Password As String
            '''    <Summary>
            '''     (Set|Get) The Password as String.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 22h15:304 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Credentials"), Description("(Set|Get) The Password as String.")>
            Public Property Password() As String
                Get
                    Return _Password
                End Get
                Set(ByVal Value As String)
                    _Password = Value
                End Set
            End Property
#End Region '(Set|Get) The Password as String.
#Region "[On] |2019/05/20 20h46:683| <01.02.02> <Property> <Credentials> |.UNCPath()| String|"' (Set|Get) The UNCPath as  String.
            Private _UNCPath As String
            '''    <Summary>
            '''     (Set|Get) The UNCPath as  String.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 20h58:515 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Credentials"), Description("(Set|Get) The UNCPath as  String.")>
            Public Property UNCPath() As String
                Get
                    Return _UNCPath
                End Get
                Set(ByVal Value As String)
                    _UNCPath = Value
                End Set
            End Property
#End Region '(Set|Get) The UNCPath as  String.
#End Region
#Region "|01.03| <Property> [Alert]{3}"
#Region "[On] |2019/05/20 22h18:618| <01.03.00> <Property> <Alert> |.Alert()|String|"' (Set|Get) The Alert as String.
            Private _Alert As String
            '''    <Summary>
            '''     (Set|Get) The Alert as String.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 22h18:623 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Alert"), Description("(Set|Get) The Alert as String.")>
            Public Property Alert() As String
                Get
                    Return _Alert
                End Get
                Set(ByVal Value As String)
                    _Alert = Value
                End Set
            End Property
#End Region '(Set|Get) The Alert as String.
#Region "[On] |2019/05/20 22h18:252| <01.03.01> <Property> <Alert> |.IsConnected()|Boolean|"' (Set|Get) The IsConnected as Boolean.
            Private _IsConnected As Boolean
            '''    <Summary>
            '''     (Set|Get) The IsConnected as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 22h18:257 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Alert"), Description("(Set|Get) The IsConnected as Boolean."), DefaultValue(False)>
            Public Property IsConnected() As Boolean
                Get
                    Return _IsConnected
                End Get
                Set(ByVal Value As Boolean)
                    _IsConnected = Value
                End Set
            End Property
#End Region '(Set|Get) The IsConnected as Boolean.
#Region "[On] |2019/05/20 22h20:748| <01.03.02> <Property> <Alert> |.MemoryCritical()|Boolean|"' (Set|Get) The MemoryCritical as Boolean.
            Private _MemoryCritical As Boolean
            '''    <Summary>
            '''     (Set|Get) The MemoryCritical as Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 22h20:755 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Alert"), Description("(Set|Get) The MemoryCritical as Boolean."), DefaultValue(False)>
            Public Property MemoryCritical() As Boolean
                Get
                    Return _MemoryCritical
                End Get
                Set(ByVal Value As Boolean)
                    _MemoryCritical = Value
                End Set
            End Property
#End Region '(Set|Get) The MemoryCritical as Boolean.
#End Region
#Region "|01.04| <Property> [Command]{2}"
#Region "[On] |2019/05/20 22h21:505| <01.04.00> <Property> <Command> |.ShellCommandLine()| String|"' (Set|Get) The ShellCommandLine as  String.
            Private _ShellCommandLine As String
            '''    <Summary>
            '''     (Set|Get) The ShellCommandLine as  String.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 22h21:511 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Command"), Description("(Set|Get) The ShellCommandLine as  String.")>
            Public Property ShellCommandLine() As String
                Get
                    Return _ShellCommandLine
                End Get
                Set(ByVal Value As String)
                    _ShellCommandLine = Value
                End Set
            End Property
#End Region '(Set|Get) The ShellCommandLine as  String.
#Region "[On] |2019/05/20 22h22:602| <01.00.00> <Property> <Command> |.UseAdminRights()| Boolean|"' (Set|Get) The UseAdminRights as  Boolean.
            Private _UseAdminRights As Boolean
            '''    <Summary>
            '''     (Set|Get) The UseAdminRights as  Boolean.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 22h22:608 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Command"), Description("(Set|Get) The UseAdminRights as  Boolean."), DefaultValue(False)>
            Public Property UseAdminRights() As Boolean
                Get
                    Return _UseAdminRights
                End Get
                Set(ByVal Value As Boolean)
                    _UseAdminRights = Value
                End Set
            End Property
#End Region '(Set|Get) The UseAdminRights as  Boolean.
#End Region
#End Region

#Region "|5| [Function]"
#Region "|05.00| <Function> [Get]"
#Region "|05.00.00| <Function> <Get> [GetSerial()|String]"
            Public Function GetSerial() As String
                Dim Result As String = "Not Found"
                Dim Fso As Object = CreateObject("Scripting.FileSystemObject")
                Try
                    Dim Dir As Object = Fso.GetDrive(Fso.GerDriveName(Me.Letter))
                    With Dir
                        If .IsReady Then
                            Result = .SerialNumber
                        End If
                    End With
                Catch ex As Exception
                    Result = ex.Message
                End Try
                Return Result
            End Function
#End Region
#Region "|05.00.00| <Function> <Get> [GetAllDrives()|List(Of Drive)]"
            Public Function GetAllDrive() As List(Of Drive)
                Dim Result As New List(Of Drive)
                Dim alphabet As New StringCollection()
                Dim lowerBound As Integer = Convert.ToInt16("A"c)
                Dim upperBound As Integer = Convert.ToInt16("Z"c)

                Return Result
            End Function
#End Region

#End Region
            Public Overrides Function ToString() As String
                Return Me.Letter
            End Function
#End Region
#Region "|7| [Loader]"
#Region "|07.00| <Loader> [Empty]"
            Public Sub New()
                With Me
                    .AvailableFreeSpace = New SizeInfo
                    .Letter = ""
                    .Name = ""
                    .PercentageFree = New Double
                    .PercentageUsed = New Double
                    .SerialNumber = ""
                    .Target = ""
                    .TotalFreeSpace = New SizeInfo
                    .TotalSize = New SizeInfo
                    .Type = DriveType.Unknown
                    .UNCPath = ""
                    .UsedSize = New SizeInfo
                    .IsConnected = False
                    .Alert = ""
                    .MemoryCritical = False
                    .ShellCommandLine = ""
                    .UseAdminRights = False
                    .UserName = ""
                    .Password = ""
                End With
            End Sub
#End Region
#Region "|07.01| <Loader> [Filled]"
            Public Sub New(ByVal Letter As String)
                If Letter <> "" Then
                    With Me
                        .Letter = Letter
                        Dim Dir As New IO.DriveInfo(Letter)
                        Try
                            If Dir.IsReady Then
                                .AvailableFreeSpace = New SizeInfo(Dir.AvailableFreeSpace, SizeInfo.Scales.Gigabyte)
                                .TotalFreeSpace = New SizeInfo(Dir.TotalFreeSpace, SizeInfo.Scales.Gigabyte)
                                .TotalSize = New SizeInfo(Dir.TotalSize, SizeInfo.Scales.Gigabyte)
                                .Name = Mid(Letter, 1)
                                .Type = Dir.DriveType
                                .UsedSize = New SizeInfo(Dir.TotalSize - Dir.TotalFreeSpace, SizeInfo.Scales.Gigabyte)
                                .PercentageUsed = Math.Round(New SizeInfo((.UsedSize.Raw / .TotalSize.Raw) * 100).Raw, 2)
                                .PercentageFree = Math.Round(New SizeInfo((.AvailableFreeSpace.Raw / .TotalSize.Raw) * 100).Raw, 2)
                                .UNCPath = ""
                                .IsConnected = True
                                If .PercentageFree < 20 Then
                                    .Alert = "The Disk space is almost full. The amount of space left is " & .PercentageFree & "%."
                                ElseIf .PercentageFree <= 5 Then
                                    .Alert = "The disk is at critical capacity!"
                                Else
                                    .Alert = ""
                                End If
                            End If
                        Catch ex As Exception

                        End Try
                        .Target = Letter
                        Try
                            .SerialNumber = GetSerial()
                        Catch ex As Exception

                        End Try
                    End With
                End If

            End Sub
#End Region
#End Region


        End Class
#End Region
#Region "|08.00.01.02| <Class> <Hardware> <Internal> [Lecteur]"
        Public Class Lecteur
#Region "|1| [Property]"
#Region "|01.00| <Property> [Drives]{26}"
#Region "[On] |2019/05/20 22h24:628| <01.00.00> <Property> <Drives> |.A()| Drive|"' (Set|Get) The A as  Drive.
            Private _A As Drive
            '''    <Summary>
            '''     (Set|Get) The A as  Drive.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 22h24:633 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Drives"), Description("(Set|Get) The A as  Drive.")>
            Public Property A() As Drive
                Get
                    Return _A
                End Get
                Set(ByVal Value As Drive)
                    _A = Value
                End Set
            End Property
#End Region '(Set|Get) The A as  Drive.
#Region "[On] |2019/05/20 22h25:833| <01.00.01> <Property> <Drives> |.B()| Drive|"' (Set|Get) The B as  Drive.
            Private _B As Drive
            '''    <Summary>
            '''     (Set|Get) The B as  Drive.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 22h25:839 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Drives"), Description("(Set|Get) The B as  Drive.")>
            Public Property B() As Drive
                Get
                    Return _B
                End Get
                Set(ByVal Value As Drive)
                    _B = Value
                End Set
            End Property
#End Region '(Set|Get) The B as  Drive.
#Region "[On] |2019/05/20 22h25:112| <01.00.02> <Property> <Drives> |.C()| Drive|"' (Set|Get) The C as  Drive.
            Private _C As Drive
            '''    <Summary>
            '''     (Set|Get) The C as  Drive.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 22h25:118 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Drives"), Description("(Set|Get) The C as  Drive.")>
            Public Property C() As Drive
                Get
                    Return _C
                End Get
                Set(ByVal Value As Drive)
                    _C = Value
                End Set
            End Property
#End Region '(Set|Get) The C as  Drive.
#Region "[On] |2019/05/20 22h25:591| <01.00.03> <Property> <Drives> |.D()| Drive|"' (Set|Get) The D as  Drive.
            Private _D As Drive
            '''    <Summary>
            '''     (Set|Get) The D as  Drive.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 22h25:599 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Drives"), Description("(Set|Get) The D as  Drive.")>
            Public Property D() As Drive
                Get
                    Return _D
                End Get
                Set(ByVal Value As Drive)
                    _D = Value
                End Set
            End Property
#End Region '(Set|Get) The D as  Drive.
#Region "[On] |2019/05/20 22h25:164| <01.00.04> <Property> <Drives> |.E()| Drive|"' (Set|Get) The E as  Drive.
            Private _E As Drive
            '''    <Summary>
            '''     (Set|Get) The E as  Drive.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 22h25:174 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Drives"), Description("(Set|Get) The E as  Drive.")>
            Public Property E() As Drive
                Get
                    Return _E
                End Get
                Set(ByVal Value As Drive)
                    _E = Value
                End Set
            End Property
#End Region '(Set|Get) The E as  Drive.
#Region "[On] |2019/05/20 22h25:095| <01.00.05> <Property> <Drives> |.F()| Drive|"' (Set|Get) The F as  Drive.
            Private _F As Drive
            '''    <Summary>
            '''     (Set|Get) The F as  Drive.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 22h25:100 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Drives"), Description("(Set|Get) The F as  Drive.")>
            Public Property F() As Drive
                Get
                    Return _F
                End Get
                Set(ByVal Value As Drive)
                    _F = Value
                End Set
            End Property
#End Region '(Set|Get) The F as  Drive.
#Region "[On] |2019/05/20 22h26:011| <01.00.06> <Property> <Drives> |.G()| Drive|"' (Set|Get) The G as  Drive.
            Private _G As Drive
            '''    <Summary>
            '''     (Set|Get) The G as  Drive.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 22h26:020 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Drives"), Description("(Set|Get) The G as  Drive.")>
            Public Property G() As Drive
                Get
                    Return _G
                End Get
                Set(ByVal Value As Drive)
                    _G = Value
                End Set
            End Property
#End Region '(Set|Get) The G as  Drive.
#Region "[On] |2019/05/20 22h26:014| <01.00.07> <Property> <Drives> |.H()| Drive|"' (Set|Get) The H as  Drive.
            Private _H As Drive
            '''    <Summary>
            '''     (Set|Get) The H as  Drive.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 22h26:020 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Drives"), Description("(Set|Get) The H as  Drive.")>
            Public Property H() As Drive
                Get
                    Return _H
                End Get
                Set(ByVal Value As Drive)
                    _H = Value
                End Set
            End Property
#End Region '(Set|Get) The H as  Drive.
#Region "[On] |2019/05/20 22h26:014| <01.00.08> <Property> <Drives> |.I()| Drive|"' (Set|Get) The I as  Drive.
            Private _I As Drive
            '''    <Summary>
            '''     (Set|Get) The I as  Drive.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 22h26:023 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Drives"), Description("(Set|Get) The I as  Drive.")>
            Public Property I() As Drive
                Get
                    Return _I
                End Get
                Set(ByVal Value As Drive)
                    _I = Value
                End Set
            End Property
#End Region '(Set|Get) The I as  Drive.
#Region "[On] |2019/05/20 22h26:263| <01.00.09> <Property> <Drives> |.J()| Drive|"' (Set|Get) The J as  Drive.
            Private _J As Drive
            '''    <Summary>
            '''     (Set|Get) The J as  Drive.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 22h26:272 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Drives"), Description("(Set|Get) The J as  Drive.")>
            Public Property J() As Drive
                Get
                    Return _J
                End Get
                Set(ByVal Value As Drive)
                    _J = Value
                End Set
            End Property
#End Region '(Set|Get) The J as  Drive.
#Region "[On] |2019/05/20 22h26:967| <01.00.10> <Property> <Drives> |.K()| Drive|"' (Set|Get) The K as  Drive.
            Private _K As Drive
            '''    <Summary>
            '''     (Set|Get) The K as  Drive.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 22h26:974 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Drives"), Description("(Set|Get) The K as  Drive.")>
            Public Property K() As Drive
                Get
                    Return _K
                End Get
                Set(ByVal Value As Drive)
                    _K = Value
                End Set
            End Property
#End Region '(Set|Get) The K as  Drive.
#Region "[On] |2019/05/20 22h27:792| <01.00.11> <Property> <Drives> |.L()| Drive|"' (Set|Get) The L as  Drive.
            Private _L As Drive
            '''    <Summary>
            '''     (Set|Get) The L as  Drive.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 22h27:797 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Drives"), Description("(Set|Get) The L as  Drive.")>
            Public Property L() As Drive
                Get
                    Return _L
                End Get
                Set(ByVal Value As Drive)
                    _L = Value
                End Set
            End Property
#End Region '(Set|Get) The L as  Drive.
#Region "[On] |2019/05/20 22h27:325| <01.00.12> <Property> <Drives> |.M()| Drive|"' (Set|Get) The M as  Drive.
            Private _M As Drive
            '''    <Summary>
            '''     (Set|Get) The M as  Drive.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 22h27:333 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Drives"), Description("(Set|Get) The M as  Drive.")>
            Public Property M() As Drive
                Get
                    Return _M
                End Get
                Set(ByVal Value As Drive)
                    _M = Value
                End Set
            End Property
#End Region '(Set|Get) The M as  Drive.
#Region "[On] |2019/05/20 22h27:985| <01.00.13> <Property> <Drives> |.N()| Drive|"' (Set|Get) The N as  Drive.
            Private _N As Drive
            '''    <Summary>
            '''     (Set|Get) The N as  Drive.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 22h27:991 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Drives"), Description("(Set|Get) The N as  Drive.")>
            Public Property N() As Drive
                Get
                    Return _N
                End Get
                Set(ByVal Value As Drive)
                    _N = Value
                End Set
            End Property
#End Region '(Set|Get) The N as  Drive.
#Region "[On] |2019/05/20 22h27:783| <01.00.14> <Property> <Drives> |.O()| Drive|"' (Set|Get) The O as  Drive.
            Private _O As Drive
            '''    <Summary>
            '''     (Set|Get) The O as  Drive.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 22h27:792 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Drives"), Description("(Set|Get) The O as  Drive.")>
            Public Property O() As Drive
                Get
                    Return _O
                End Get
                Set(ByVal Value As Drive)
                    _O = Value
                End Set
            End Property
#End Region '(Set|Get) The O as  Drive.
#Region "[On] |2019/05/20 22h27:751| <01.00.15> <Property> <Drives> |.P()| Drive|"' (Set|Get) The P as  Drive.
            Private _P As Drive
            '''    <Summary>
            '''     (Set|Get) The P as  Drive.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 22h27:759 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Drives"), Description("(Set|Get) The P as  Drive.")>
            Public Property P() As Drive
                Get
                    Return _P
                End Get
                Set(ByVal Value As Drive)
                    _P = Value
                End Set
            End Property
#End Region '(Set|Get) The P as  Drive.
#Region "[On] |2019/05/20 22h28:697| <01.00.16> <Property> <Drives> |.Q()| Drive|"' (Set|Get) The Q as  Drive.
            Private _Q As Drive
            '''    <Summary>
            '''     (Set|Get) The Q as  Drive.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 22h28:703 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Drives"), Description("(Set|Get) The Q as  Drive.")>
            Public Property Q() As Drive
                Get
                    Return _Q
                End Get
                Set(ByVal Value As Drive)
                    _Q = Value
                End Set
            End Property
#End Region '(Set|Get) The Q as  Drive.
#Region "[On] |2019/05/20 22h28:396| <01.00.17> <Property> <Drives> |.R()| Drive|"' (Set|Get) The R as  Drive.
            Private _R As Drive
            '''    <Summary>
            '''     (Set|Get) The R as  Drive.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 22h28:402 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Drives"), Description("(Set|Get) The R as  Drive.")>
            Public Property R() As Drive
                Get
                    Return _R
                End Get
                Set(ByVal Value As Drive)
                    _R = Value
                End Set
            End Property
#End Region '(Set|Get) The R as  Drive.
#Region "[On] |2019/05/20 22h28:598| <01.00.18> <Property> <Drives> |.S()| Drive|"' (Set|Get) The S as  Drive.
            Private _S As Drive
            '''    <Summary>
            '''     (Set|Get) The S as  Drive.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 22h28:606 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Drives"), Description("(Set|Get) The S as  Drive.")>
            Public Property S() As Drive
                Get
                    Return _S
                End Get
                Set(ByVal Value As Drive)
                    _S = Value
                End Set
            End Property
#End Region '(Set|Get) The S as  Drive.
#Region "[On] |2019/05/20 22h28:586| <01.00.19> <Property> <Drives> |.T()| Drive|"' (Set|Get) The T as  Drive.
            Private _T As Drive
            '''    <Summary>
            '''     (Set|Get) The T as  Drive.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 22h28:592 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Drives"), Description("(Set|Get) The T as  Drive.")>
            Public Property T() As Drive
                Get
                    Return _T
                End Get
                Set(ByVal Value As Drive)
                    _T = Value
                End Set
            End Property
#End Region '(Set|Get) The T as  Drive.
#Region "[On] |2019/05/20 22h28:909| <01.00.20> <Property> <Drives> |.U()| Drive|"' (Set|Get) The U as  Drive.
            Private _U As Drive
            '''    <Summary>
            '''     (Set|Get) The U as  Drive.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 22h28:914 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Drives"), Description("(Set|Get) The U as  Drive.")>
            Public Property U() As Drive
                Get
                    Return _U
                End Get
                Set(ByVal Value As Drive)
                    _U = Value
                End Set
            End Property
#End Region '(Set|Get) The U as  Drive.
#Region "[On] |2019/05/20 22h29:988| <01.00.21> <Property> <Drives> |.V()| Drive|"' (Set|Get) The V as  Drive.
            Private _V As Drive
            '''    <Summary>
            '''     (Set|Get) The V as  Drive.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 22h29:994 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Drives"), Description("(Set|Get) The V as  Drive.")>
            Public Property V() As Drive
                Get
                    Return _V
                End Get
                Set(ByVal Value As Drive)
                    _V = Value
                End Set
            End Property
#End Region '(Set|Get) The V as  Drive.
#Region "[On] |2019/05/20 22h29:477| <01.00.22> <Property> <Drives> |.W()| Drive|"' (Set|Get) The W as  Drive.
            Private _W As Drive
            '''    <Summary>
            '''     (Set|Get) The W as  Drive.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 22h29:482 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Drives"), Description("(Set|Get) The W as  Drive.")>
            Public Property W() As Drive
                Get
                    Return _W
                End Get
                Set(ByVal Value As Drive)
                    _W = Value
                End Set
            End Property
#End Region '(Set|Get) The W as  Drive.
#Region "[On] |2019/05/20 22h29:399| <01.00.23> <Property> <Drives> |.X()| Drive|"' (Set|Get) The X as  Drive.
            Private _X As Drive
            '''    <Summary>
            '''     (Set|Get) The X as  Drive.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 22h29:407 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Drives"), Description("(Set|Get) The X as  Drive.")>
            Public Property X() As Drive
                Get
                    Return _X
                End Get
                Set(ByVal Value As Drive)
                    _X = Value
                End Set
            End Property
#End Region '(Set|Get) The X as  Drive.
#Region "[On] |2019/05/20 22h29:187| <01.00.24> <Property> <Drives> |.Y()| Drive|"' (Set|Get) The Y as  Drive.
            Private _Y As Drive
            '''    <Summary>
            '''     (Set|Get) The Y as  Drive.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 22h29:196 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Drives"), Description("(Set|Get) The Y as  Drive.")>
            Public Property Y() As Drive
                Get
                    Return _Y
                End Get
                Set(ByVal Value As Drive)
                    _Y = Value
                End Set
            End Property
#End Region '(Set|Get) The Y as  Drive.
#Region "[On] |2019/05/20 22h29:062| <01.00.25> <Property> <Drives> |.Z()| Drive|"' (Set|Get) The Z as  Drive.
            Private _Z As Drive
            '''    <Summary>
            '''     (Set|Get) The Z as  Drive.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 22h29:067 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Drives"), Description("(Set|Get) The Z as  Drive.")>
            Public Property Z() As Drive
                Get
                    Return _Z
                End Get
                Set(ByVal Value As Drive)
                    _Z = Value
                End Set
            End Property
#End Region '(Set|Get) The Z as  Drive.
#End Region
#Region "|01.01| <Property> [List]{7}"
#Region "[On] |2019/05/20 22h37:690| <01.01.00> <Property> <List> |.Local()| List(Of Drive)|"' (Set|Get) The Local as  List(Of Drive).
            Private _Local As List(Of Drive)
            '''    <Summary>
            '''     (Set|Get) The Local as  List(Of Drive).
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 22h37:696 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("List"), Description("(Set|Get) The Local as  List(Of Drive).")>
            Public Property Local() As List(Of Drive)
                Get
                    Return _Local
                End Get
                Set(ByVal Value As List(Of Drive))
                    _Local = Value
                End Set
            End Property
#End Region '(Set|Get) The Local as  List(Of Drive).
#Region "[On] |2019/05/20 22h38:710| <01.01.01> <Property> <List> |.Network()| List(Of Drive)|"' (Set|Get) The Network as  List(Of Drive).
            Private _Network As List(Of Drive)
            '''    <Summary>
            '''     (Set|Get) The Network as  List(Of Drive).
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 22h38:717 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("List"), Description("(Set|Get) The Network as  List(Of Drive).")>
            Public Property Network() As List(Of Drive)
                Get
                    Return _Network
                End Get
                Set(ByVal Value As List(Of Drive))
                    _Network = Value
                End Set
            End Property
#End Region '(Set|Get) The Network as  List(Of Drive).
#Region "[On] |2019/05/20 22h38:884| <01.01.02> <Property> <List> |.USB()| List(Of Drive)|"' (Set|Get) The USB as  List(Of Drive).
            Private _USB As List(Of Drive)
            '''    <Summary>
            '''     (Set|Get) The USB as  List(Of Drive).
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 22h38:890 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("List"), Description("(Set|Get) The USB as  List(Of Drive).")>
            Public Property USB() As List(Of Drive)
                Get
                    Return _USB
                End Get
                Set(ByVal Value As List(Of Drive))
                    _USB = Value
                End Set
            End Property
#End Region '(Set|Get) The USB as  List(Of Drive).
#Region "[On] |2019/05/20 22h38:296| <01.01.03> <Property> <List> |.DVD()| List(Of Drive)|"' (Set|Get) The DVD as  List(Of Drive).
            Private _DVD As List(Of Drive)
            '''    <Summary>
            '''     (Set|Get) The DVD as  List(Of Drive).
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 22h38:302 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("List"), Description("(Set|Get) The DVD as  List(Of Drive).")>
            Public Property DVD() As List(Of Drive)
                Get
                    Return _DVD
                End Get
                Set(ByVal Value As List(Of Drive))
                    _DVD = Value
                End Set
            End Property
#End Region '(Set|Get) The DVD as  List(Of Drive).
#Region "[On] |2019/05/20 22h39:603| <01.01.04> <Property> <List> |.Offline()| List(Of Drive)|"' (Set|Get) The Offline as  List(Of Drive).
            Private _Offline As List(Of Drive)
            '''    <Summary>
            '''     (Set|Get) The Offline as  List(Of Drive).
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 22h39:609 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("List"), Description("(Set|Get) The Offline as  List(Of Drive).")>
            Public Property Offline() As List(Of Drive)
                Get
                    Return _Offline
                End Get
                Set(ByVal Value As List(Of Drive))
                    _Offline = Value
                End Set
            End Property
#End Region '(Set|Get) The Offline as  List(Of Drive).
#Region "[On] |2019/05/20 22h41:398| <01.01.05> <Property> <List> |.Drives()| List(Of Drive)|"' (Set|Get) The Drives as  List(Of Drive).
            Private _Drives As List(Of Drive)
            '''    <Summary>
            '''     (Set|Get) The Drives as  List(Of Drive).
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 22h41:403 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("List"), Description("(Set|Get) The Drives as  List(Of Drive).")>
            Public Property Drives() As List(Of Drive)
                Get
                    Return _Drives
                End Get
                Set(ByVal Value As List(Of Drive))
                    _Drives = Value
                End Set
            End Property
#End Region '(Set|Get) The Drives as  List(Of Drive).
#Region "[On] |2019/05/20 22h52:616| <01.01.06> <Property> <List> |.Ram()| List(Of Drive)|"' (Set|Get) The Ram as  List(Of Drive).
            Private _Ram As List(Of Drive)
            '''    <Summary>
            '''     (Set|Get) The Ram as  List(Of Drive).
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 22h52:621 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("List"), Description("(Set|Get) The Ram as  List(Of Drive).")>
            Public Property Ram() As List(Of Drive)
                Get
                    Return _Ram
                End Get
                Set(ByVal Value As List(Of Drive))
                    _Ram = Value
                End Set
            End Property
#End Region '(Set|Get) The Ram as  List(Of Drive).
#End Region
#Region "|01.02| <Property> [ImageList]"
#Region "[On] |2019/05/20 23h41:243| <01.02.00> <Property> <List> |.ImageList()|ImageList|"' (Set|Get) The ImageList as ImageList.
            Private Shared _ImageList As ImageList
            '''    <Summary>
            '''     (Set|Get) The ImageList as ImageList.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 23h41:249 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("List"), Description("(Set|Get) The ImageList as ImageList.")>
            Public Property ImageList() As ImageList
                Get
                    Return _ImageList
                End Get
                Set(ByVal Value As ImageList)
                    _ImageList = Value
                End Set
            End Property
#End Region '(Set|Get) The ImageList as ImageList.

#End Region
#Region "|01.03| <Property> [Node]"
#Region "[On] |2019/05/21 00h32:972| <01.03.00> <Property> <Software> |.Explorer()|DevComponents.AdvTree.Node|"' (Set|Get) The Explorer as DevComponents.AdvTree.Node.
            Private _Explorer As DevComponents.AdvTree.Node
            '''    <Summary>
            '''     (Set|Get) The Explorer as DevComponents.AdvTree.Node.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/21 00h32:978 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Software"), Description("(Set|Get) The Explorer as DevComponents.AdvTree.Node.")>
            Public Property Explorer() As DevComponents.AdvTree.Node
                Get
                    Return _Explorer
                End Get
                Set(ByVal Value As DevComponents.AdvTree.Node)
                    _Explorer = Value
                End Set
            End Property
#End Region '(Set|Get) The Explorer as DevComponents.AdvTree.Node.

#End Region

#Region "|4| [Sub]"
#Region "|04.00| <Sub> [Clear]"
            Public Sub Clear()
                With Me
                    ImageList = New ImageList()
                    With ImageList
                        .ColorDepth = ColorDepth.Depth32Bit
                        .ImageSize = New Drawing.Size(24, 24)
                        '0  Network Online
                        .Images.Add(My.Resources.backup_server)
                        '1  Network Online
                        .Images.Add(My.Resources.backup_server_check)
                        '2  Network Info
                        .Images.Add(My.Resources.backup_server_info__1_)
                        '3  Network Close
                        .Images.Add(My.Resources.backup_server_close__1_)
                        '4  Network Delete
                        .Images.Add(My.Resources.backup_server_delete)

                        '5  Computer Online
                        .Images.Add(My.Resources.desktop_computer)
                        '6  Computer Online
                        .Images.Add(My.Resources.desktop_computer_check)
                        '7  Computer Close
                        .Images.Add(My.Resources.desktop_computer_close)

                        '8  Dvd Online
                        .Images.Add(My.Resources.dvd_disc)
                        '9  Dvd Online
                        .Images.Add(My.Resources.dvd_disc_check)
                        '10 Dvd Info
                        .Images.Add(My.Resources.dvd_disc_info)
                        '11 Dvd Close
                        .Images.Add(My.Resources.dvd_disc_close)
                        '12 Dvd Delete
                        .Images.Add(My.Resources.dvd_disc_delete)

                        '13 Ram Online
                        .Images.Add(My.Resources.ram__1_)
                        '14 Ram Online
                        .Images.Add(My.Resources.ram_check__1_)
                        '15 Ram Info
                        .Images.Add(My.Resources.ram_info)
                        '16 Ram Close
                        .Images.Add(My.Resources.ram_close)
                        '17 Ram Check
                        .Images.Add(My.Resources.storage_1_check)

                        '18 Drive Online
                        .Images.Add(My.Resources.storage_1)
                        '19 Drive Info
                        .Images.Add(My.Resources.storage_1_info)
                        '20 Drive Close
                        .Images.Add(My.Resources.storage_1_close)
                        '21 Drive Delete
                        .Images.Add(My.Resources.storage_1_delete)

                        '22 USB
                        .Images.Add(My.Resources.pen_drive)

                        '23 Folder
                        .Images.Add(My.Resources.folder1)




                    End With
                    .Drives = New List(Of Drive)
                    .A = New Drive("A:\")
                    .B = New Drive("B:\")
                    .C = New Drive("C:\")
                    .D = New Drive("D:\")
                    .E = New Drive("E:\")
                    .F = New Drive("F:\")
                    .G = New Drive("G:\")
                    .H = New Drive("H:\")
                    .I = New Drive("I:\")
                    .J = New Drive("J:\")
                    .K = New Drive("K:\")
                    .L = New Drive("L:\")
                    .M = New Drive("M:\")
                    .N = New Drive("N:\")
                    .O = New Drive("O:\")
                    .P = New Drive("P:\")
                    .Q = New Drive("Q:\")
                    .R = New Drive("R:\")
                    .S = New Drive("S:\")
                    .T = New Drive("T:\")
                    .U = New Drive("U:\")
                    .V = New Drive("V:\")
                    .W = New Drive("W:\")
                    .X = New Drive("X:\")
                    .Y = New Drive("Y:\")
                    .Z = New Drive("Z:\")
                    .Drives.Add(.A)
                    .Drives.Add(.B)
                    .Drives.Add(.C)
                    .Drives.Add(.D)
                    .Drives.Add(.E)
                    .Drives.Add(.F)
                    .Drives.Add(.G)
                    .Drives.Add(.H)
                    .Drives.Add(.I)
                    .Drives.Add(.J)
                    .Drives.Add(.K)
                    .Drives.Add(.L)
                    .Drives.Add(.M)
                    .Drives.Add(.N)
                    .Drives.Add(.O)
                    .Drives.Add(.P)
                    .Drives.Add(.Q)
                    .Drives.Add(.R)
                    .Drives.Add(.S)
                    .Drives.Add(.T)
                    .Drives.Add(.U)
                    .Drives.Add(.V)
                    .Drives.Add(.W)
                    .Drives.Add(.X)
                    .Drives.Add(.Y)
                    .Drives.Add(.Z)
                    .Local = New List(Of Drive)
                    .Network = New List(Of Drive)
                    .DVD = New List(Of Drive)
                    .USB = New List(Of Drive)
                    .Ram = New List(Of Drive)
                    .Offline = New List(Of Drive)
                    .Explorer = New DevComponents.AdvTree.Node("This PC")
                    .Explorer.ImageIndex = 5
                    Dim NDVD As New DevComponents.AdvTree.Node("DVD")
                    NDVD.ImageIndex = 8
                    Dim NLocal As New DevComponents.AdvTree.Node("Local")
                    NLocal.ImageIndex = 18
                    Dim NNetwork As New DevComponents.AdvTree.Node("Network")
                    NNetwork.ImageIndex = 0
                    Dim NUSB As New DevComponents.AdvTree.Node("USB")
                    NUSB.ImageIndex = 22
                    Dim NRam As New DevComponents.AdvTree.Node("Ram")
                    NRam.ImageIndex = 13
                    For Each Letter As Drive In Drives
                        If Letter.IsConnected = True Then
                            If Letter.Type = DriveType.CDRom Then
                                Dim L As New Drive(Letter.Letter)
                                If L.PercentageFree > 20 Then
                                    L.ImageIndex = 8
                                ElseIf L.PercentageFree <= 20 Then
                                    L.ImageIndex = 10
                                End If
                                Dim TN As New DevComponents.AdvTree.Node(L.Letter)
                                TN.ImageIndex = L.ImageIndex
                                TN.Tag = L.Target
                                TN.TagString = L.Target
                                NDVD.Nodes.Add(TN)
                                .DVD.Add(L)
                            ElseIf Letter.Type = DriveType.Fixed Then
                                Dim L As New Drive(Letter.Letter)
                                If L.PercentageFree > 20 Then
                                    L.ImageIndex = 18
                                ElseIf L.PercentageFree <= 20 Then
                                    L.ImageIndex = 19
                                End If
                                Dim TN As New DevComponents.AdvTree.Node(L.Letter)
                                TN.ImageIndex = L.ImageIndex
                                TN.Tag = L.Target
                                TN.TagString = L.Target
                                NLocal.Nodes.Add(TN)
                                .Local.Add(L)
                            ElseIf Letter.Type = DriveType.Network Then
                                Dim L As New Drive(Letter.Letter)
                                If L.PercentageFree > 20 Then
                                    L.ImageIndex = 0
                                ElseIf L.PercentageFree <= 20 Then
                                    L.ImageIndex = 1
                                End If
                                Dim TN As New DevComponents.AdvTree.Node(L.Letter)
                                TN.ImageIndex = L.ImageIndex
                                TN.Tag = L.Target
                                TN.TagString = L.Target
                                NNetwork.Nodes.Add(TN)
                                .Network.Add(L)
                            ElseIf Letter.Type = DriveType.Removable Then
                                Dim L As New Drive(Letter.Letter)
                                If L.PercentageFree > 20 Then
                                    L.ImageIndex = 22
                                ElseIf L.PercentageFree <= 20 Then
                                    L.ImageIndex = 22
                                End If
                                Dim TN As New DevComponents.AdvTree.Node(L.Letter)
                                TN.ImageIndex = L.ImageIndex
                                TN.Tag = L.Target
                                TN.TagString = L.Target
                                NUSB.Nodes.Add(TN)
                                .USB.Add(L)
                            ElseIf Letter.Type = DriveType.Ram Then
                                Dim L As New Drive(Letter.Letter)
                                If L.PercentageFree > 20 Then
                                    L.ImageIndex = 13
                                ElseIf L.PercentageFree <= 20 Then
                                    L.ImageIndex = 14
                                End If
                                Dim TN As New DevComponents.AdvTree.Node(L.Letter)
                                TN.ImageIndex = L.ImageIndex
                                TN.Tag = L.Target
                                TN.TagString = L.Target
                                NRam.Nodes.Add(TN)
                                .Ram.Add(L)
                            End If
                        Else
                            Dim L As New Drive(Letter.Letter)
                            .Offline.Add(L)
                        End If
                    Next
                    Explorer.Nodes.Add(NLocal)
                    Explorer.Nodes.Add(NNetwork)
                    Explorer.Nodes.Add(NDVD)
                    Explorer.Nodes.Add(NUSB)
                    Explorer.Nodes.Add(NRam)
                End With
            End Sub
#End Region
#End Region
#Region "|7| [Loader]"
#Region "|07.00| <Loader> [Empty]"
            Public Sub New()
                Clear()
            End Sub
#End Region
#End Region
        End Class
#End Region

#End Region
#End Region
#Region "|08.01| <Class> [Software]"
        Public Class Software
#Region "|1| [Property]"
#Region "|01.00| <Property> [Info]"
#Region "[On] |2019/05/20 19h59:170| <01.00.00> <Property> <Info> |.Name()|String|"' (Set|Get) The Name as String.
            Private _Name As String
            '''    <Summary>
            '''     (Set|Get) The Name as String.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 19h59:177 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Info"), Description("(Set|Get) The Name as String.")>
            Public Property Name() As String
                Get
                    Return _Name
                End Get
                Set(ByVal Value As String)
                    _Name = Value
                End Set
            End Property
#End Region '(Set|Get) The Name as String.
#Region "[On] |2019/05/20 19h59:462| <01.00.01> <Property> <Info> |.Origine()|String|"' (Set|Get) The Origine as String.
            Private _Origine As String
            '''    <Summary>
            '''     (Set|Get) The Origine as String.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 19h59:468 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Info"), Description("(Set|Get) The Origine as String.")>
            Public Property Origine() As String
                Get
                    Return _Origine
                End Get
                Set(ByVal Value As String)
                    _Origine = Value
                End Set
            End Property
#End Region '(Set|Get) The Origine as String.
#Region "[On] |2019/05/20 20h00:154| <01.00.02> <Property> <Info> |.UrlUpdateInfo()|String|"' (Set|Get) The UrlUpdateInfo as String.
            Private _UrlUpdateInfo As String
            '''    <Summary>
            '''     (Set|Get) The UrlUpdateInfo as String.
            '''    <AuthorEmail>saadry.dunkel@ds-informatique.ch</AuthorEmail>
            '''    <AuthorName>David Shaw Informatique Sàrl</AuthorName>
            '''    <AuthorUri>https://www.ds-informatique.ch</AuthorUri>
            '''    <Published>MASTER From  | Time : 2019/05/20 20h00:163 </Published>
            '''      <Rights>
            '''         Copyright on SmartOffice programming tools.All rights, including those for reproduction, reprinting and translation of training materials are the property of David Shaw Informatique Sàrl or the specified supplier. The
            '''    training materials may not be reproduced in any form, used for academic purposes, or used for public
            '''    without the prior written permission of David Shaw Informatique Sàrl.The software, components and data used in the course are protected by copyright and should not be copied on any media or
            '''    taken out of the classroom.
            '''    
            '''       </Rights>
            ''' '''    <Updated>[Created=][Status=NotTested][Tested On]1/01/01 00h00:000[/Tested On]</Updated>
            '''    </Summary>

            <Browsable(True), CategoryAttribute("Info"), Description("(Set|Get) The UrlUpdateInfo as String.")>
            Public Property UrlUpdateInfo() As String
                Get
                    Return _UrlUpdateInfo
                End Get
                Set(ByVal Value As String)
                    _UrlUpdateInfo = Value
                End Set
            End Property
#End Region '(Set|Get) The UrlUpdateInfo as String.

#End Region
#End Region
#Region "|5| [Function]"
#Region "|05.00| <Function> [ListSoftwares()|List(Of Software)]"
            Public Shared Function ListSoftwares() As List(Of Software)
                Dim Result As New List(Of Software)
                Dim Mo_Return As Management.ManagementObjectCollection = Nothing
                Dim Mo_Search As Management.ManagementObjectSearcher = Nothing
                Dim Mo As ManagementObject = Nothing
                Mo_Search = New ManagementObjectSearcher("Select * From Win32_Product")
                Mo_Return = Mo_Search.Get()
                For Each Mo In Mo_Return
                    Try
                        Dim S As New Software(Mo("Name").ToString, Mo("InstallSource").ToString, Mo("UrlUpdateInfo").ToString)
                        Result.Add(S)
                    Catch ex As Exception

                    End Try
                Next
                Return Result
            End Function
#End Region
#End Region
#Region "|7| [Loader]"
#Region "|07.00| <Loader> [Empty]"
            Public Sub New()
                With Me
                    .Name = ""
                    .Origine = ""
                    .UrlUpdateInfo = ""
                End With
            End Sub
#End Region
#Region "|07.01| <Loader> [Filled]"
            Public Sub New(ByVal Name As String,
                    Optional ByVal Origine As String = "",
                           Optional ByVal Url As String = "")
                With Me
                    .Name = Name
                    .Origine = Origine
                    .UrlUpdateInfo = Url
                End With
            End Sub
#End Region
#End Region
        End Class
#End Region
#End Region
#Region "|08.01| <Class> [Windows]"
        Public Class WIndows_OS
            Private item As String
            Public Shared ReadOnly OS_W7 As WIndows_OS = New WIndows_OS("Windows 7")
            Public Shared ReadOnly OS_WVi As WIndows_OS = New WIndows_OS("Windows Vista")
            Public Shared ReadOnly OS_WXP As WIndows_OS = New WIndows_OS("Windows XP")
            Public Shared ReadOnly OS_W8 As WIndows_OS = New WIndows_OS("Windows 8")
            Public Shared ReadOnly OS_W10 As WIndows_OS = New WIndows_OS("Windows 10")
            Public Shared ReadOnly OS_S3 As WIndows_OS = New WIndows_OS("Windows Server 2003")
            Public Shared ReadOnly OS_S8 As WIndows_OS = New WIndows_OS("Windows Server 2008")
            Public Shared ReadOnly OS_S12 As WIndows_OS = New WIndows_OS("Windows Server 2012")
            Public Shared ReadOnly OS_S16 As WIndows_OS = New WIndows_OS("Windows Server 2016")
            Public Shared ReadOnly OS_S19 As WIndows_OS = New WIndows_OS("Windows Server 2019")
            Private Sub New(item As String)
                Me.item = item
            End Sub
            Public Overrides Function ToString() As String
                'Return MyBase.ToString()
                Return Me.item
            End Function
        End Class
#End Region
#End Region

    End Class
#End Region





End Module
