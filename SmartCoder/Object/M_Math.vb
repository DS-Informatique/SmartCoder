Public Module M_Math

    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function
    Public Enum UnitCategory
        Area
        Data_Transfert_Rate
        Digital_Storage
        Energy
        Frequency
        Fuel_Economy
        Length
        Mass
        Plane_Angle
        Pressure
        Speed
        Temperature
        Time
        Volume
    End Enum
    Public Enum AreaScale
        Square_Kilometre
        Square_Metre
        Square_Mile
        Square_Yard
        Square_Foot
        Square_Inch
        Hectare
        Acre
    End Enum
    Public Enum Data_Transfert_RateScale
        Bit_per_Second
        Kilobit_per_Second
        Kilbyte_per_Second
        Kibibit_per_Second
        Megabit_per_Second
        Megabyte_per_Second
        Mebibit_per_Second
        Gigabit_per_second
        Gigabyte_per_Second
        Gibibit_per_Second
        Terabit_per_Second
        Terabyte_per_Second
        Tebibit_per_Second
    End Enum
    Public Enum Digital_StorageScale
        Bit
        Kilobit
        Kibibit
        Megabit
        Mebibit
        Gigabit
        Gibibit
        Terabit
        Tebibit
        Petabit
        Pebibit
        Bytes
        Kilobyte
        Kibibbyte
        Megabyte
        Mebibyte
        Gigabyte
        Gibibyte
        Terabyte
        Tebibyte
        Petabyte
        Pebibyte
    End Enum
    Public Enum EnergyScale
        Joule
        Kilojoule
        Gram_calorie
        Kilocalorie
        Watt_Hour
        Kilowatt_Hour
        Electonvolt
        British_Therminal_Unit
        US_Therm
        Foot_Pound
    End Enum
    Public Enum FrequencyScale
        Hertz
        Kilohertz
        Megahertz
        Gigahertz
    End Enum
    Public Enum FuelEconomyScale
        US_Miles_per_Gallon
        Imperial_Miles_per_Gallon
        Kilometer_per_Litre
        Litre_per_100_kilometres
    End Enum
    Public Enum LengthScale
        Kilometre
        Metre
        Centimetre
        Millimetre
        Micrometre
        Nanometre
        Mile
        Yard
        Foot
        Inch
        Nautical_Mile
    End Enum
    Public Enum MassScale
        Tonne
        Kilogram
        Gram
        Milligram
        Microgram
        Imperial_Ton
        US_Ton
        Stone
        Pound
        Ounce
    End Enum
    Public Enum Plane_AngleScale
        Degree
        Gradian
        Radian
        Milliradian
        Minute_of_Arc
        Second_of_Arc
    End Enum
    Public Enum PressureScale
        Atmosphere
        Bar
        Pascal
        Pound_Force_per_Square_inch
        Torr
    End Enum
    Public Enum SpeedScale
        Miles_per_Hour
        Foot_per_Second
        Metre_per_Second
        Kilometre_per_Hour
        Knot
    End Enum
    Public Enum TemperatureScale
        Celsuis
        Fahrenheit
        Kelvin
    End Enum
    Public Enum TimeScale
        Nanosecond
        Microsecond
        Millisecond
        Second
        Minute
        Hour
        Day
        Week
        Month
        Year
        Decade
        Century
    End Enum
    Public Enum VolumeScale
        US_Liquid_Gallon
        US_Liquid_Quart
        US_Liquid_Pint
        US_Legal_Cup
        US_Fluid_Ounce
        US_Tablespoon
        US_Teaspoon
        Cubic_Metre
        Litre
        Mililitre
        Imperial_Gallon
        Imperial_Quart
        Imperial_Pint
        Imperial_Cup
        Imperial_Fluid_Ounce
        Imperial_Tablespoon
        Imperial_Teaspoon
        Cubic_Foot
        Cubit_Inch
    End Enum
    Public Class Calulate

        Public Class Area
#Region "<Property>"

            Private _Square_Kilometre As ULong
            Public Property Square_Kilometre() As ULong
                Get
                    Return _Square_Kilometre
                End Get
                Set(ByVal value As ULong)
                    _Square_Kilometre = value
                End Set
            End Property
            Private _Square_Metre As ULong
            Public Property Square_Metre() As ULong
                Get
                    Return _Square_Metre
                End Get
                Set(ByVal value As ULong)
                    _Square_Metre = value
                End Set
            End Property
            Private _Square_Mile As ULong
            Public Property Square_Mile() As ULong
                Get
                    Return _Square_Mile
                End Get
                Set(ByVal value As ULong)
                    _Square_Mile = value
                End Set
            End Property
            Private _Square_Yard As ULong
            Public Property Square_Yard() As ULong
                Get
                    Return _Square_Yard
                End Get
                Set(ByVal value As ULong)
                    _Square_Yard = value
                End Set
            End Property
            Private _Square_Foot As ULong
            Public Property Square_Foot() As ULong
                Get
                    Return _Square_Foot
                End Get
                Set(ByVal value As ULong)
                    _Square_Foot = value
                End Set
            End Property
            Private _Square_Inch As ULong
            Public Property Square_Inch() As ULong
                Get
                    Return _Square_Inch
                End Get
                Set(ByVal value As ULong)
                    _Square_Inch = value
                End Set
            End Property
            Private _Hectare As ULong
            Public Property Hectare() As ULong
                Get
                    Return _Hectare
                End Get
                Set(ByVal value As ULong)
                    _Hectare = value
                End Set
            End Property
            Private _Acre As ULong
            Public Property Acre() As ULong
                Get
                    Return _Acre
                End Get
                Set(ByVal value As ULong)
                    _Acre = value
                End Set
            End Property

            Public Property Scale As AreaScale
#End Region

            Public Sub New(ByVal value As ULong, ByVal valueScale As AreaScale)
                If valueScale = AreaScale.Acre Then
                    Acre = value
                    Square_Kilometre = value * 0.00404686
                    Square_Metre = value * 4046.86
                    Square_Mile = value * 0.0015625
                    Square_Yard = value * 4840
                    Square_Foot = value * 43560
                    Square_Inch = value * 6273000
                    Hectare = value * 0.404686


                ElseIf valueScale = AreaScale.Hectare Then
                    Hectare = value

                    Square_Kilometre = value * 0.01
                    Square_Metre = value * 10000
                    Square_Mile = value * 0.00386102
                    Square_Yard = value * 11959.9
                    Square_Foot = value * 107639
                    Square_Inch = value * 15500000
                    Acre = value * 2.47105

                ElseIf valueScale = AreaScale.Square_Foot Then
                    Square_Foot = value

                    Square_Kilometre = value * 0.000000092903
                    Square_Metre = value * 0.092903
                    Square_Mile = value * 0.00000003587
                    Square_Yard = value * 0.111111
                    Hectare = value * 0.0000092903
                    Square_Inch = value * 144
                    Acre = value * 0.000022957


                ElseIf valueScale = AreaScale.Square_Inch Then

                    Square_Kilometre = value * 0.00000000064516
                    Square_Metre = value * 0.00064516
                    Square_Mile = value * 0.0000000002491
                    Square_Yard = value * 0.000771605
                    Hectare = value * 0.000000064516
                    Square_Foot = value * 0.00694444
                    Acre = value * 0.00000015942
                    Square_Inch = value

                ElseIf valueScale = AreaScale.Square_Kilometre Then
                    Square_Inch = value * 1550000000
                    Square_Metre = value * 1000000
                    Square_Mile = value * 0.386102
                    Square_Yard = value * 1196000
                    Hectare = value * 100
                    Square_Foot = value * 10760000
                    Acre = value * 247.105
                    Square_Kilometre = value

                ElseIf valueScale = AreaScale.Square_Metre Then
                    Square_Inch = value * 1550
                    Square_Kilometre = value * 0.000001
                    Square_Mile = value * 0.0000003861
                    Square_Yard = value * 1.19599
                    Hectare = value * 0.0001
                    Square_Foot = value * 10.7639
                    Acre = value * 0.000247105
                    Square_Metre = value

                ElseIf valueScale = AreaScale.Square_Mile Then
                    Square_Inch = value * 4014000000
                    Square_Kilometre = value * 2.58999
                    Square_Metre = value * 2590000
                    Square_Yard = value * 3098000
                    Hectare = value * 258.999
                    Square_Foot = value * 27880000
                    Acre = value * 640
                    Square_Mile = value

                ElseIf valueScale = AreaScale.Square_Yard Then
                    Square_Inch = value * 1296
                    Square_Kilometre = value * 0.00000083613
                    Square_Metre = value * 0.836127
                    Square_Mile = value * 0.00000032283
                    Hectare = value * 0.000083613
                    Square_Foot = value * 9
                    Acre = value * 0.000206612
                    Square_Yard = value

                End If


            End Sub


#Region "<Function>"

#End Region
        End Class

        Public Class DataTransfert
#Region "<Property>"

            Private _Bit_per_Second As ULong
            Public Property Bit_per_Second() As ULong
                Get
                    Return _Bit_per_Second
                End Get
                Set(ByVal value As ULong)
                    _Bit_per_Second = value
                End Set
            End Property

            Private _Kilobit_per_Second As ULong
            Public Property Kilobit_per_Second() As ULong
                Get
                    Return _Kilobit_per_Second
                End Get
                Set(ByVal value As ULong)
                    _Kilobit_per_Second = value
                End Set
            End Property
            Private _Kilobyte_per_Second As ULong
            Public Property Kilobyte_per_Second() As ULong
                Get
                    Return _Kilobyte_per_Second
                End Get
                Set(ByVal value As ULong)
                    _Kilobyte_per_Second = value
                End Set
            End Property

            Private _Kibibit_per_Second As ULong
            Public Property Kibibit_per_Second() As ULong
                Get
                    Return _Kibibit_per_Second
                End Get
                Set(ByVal value As ULong)
                    _Kibibit_per_Second = value
                End Set
            End Property

            Private _MegaBit_per_Second As ULong
            Public Property MegaBit_per_Second() As ULong
                Get
                    Return _MegaBit_per_Second
                End Get
                Set(ByVal value As ULong)
                    _MegaBit_per_Second = value
                End Set
            End Property
            Private _MegaByte_per_Second As ULong
            Public Property MegaByte_per_Second() As ULong
                Get
                    Return _MegaByte_per_Second
                End Get
                Set(ByVal value As ULong)
                    _MegaByte_per_Second = value
                End Set
            End Property

            Private _Mebibit_per_Second As ULong
            Public Property Mebibit_per_Second() As ULong
                Get
                    Return _Mebibit_per_Second
                End Get
                Set(ByVal value As ULong)
                    _Mebibit_per_Second = value
                End Set
            End Property

            Private _Gigabit_per_Second As ULong
            Public Property Gigabit_per_Second() As ULong
                Get
                    Return _Gigabit_per_Second
                End Get
                Set(ByVal value As ULong)
                    _Gigabit_per_Second = value
                End Set
            End Property
            Private _GigaByte_per_Second As ULong
            Public Property GigaByte_per_Second() As ULong
                Get
                    Return _GigaByte_per_Second
                End Get
                Set(ByVal value As ULong)
                    _GigaByte_per_Second = value
                End Set
            End Property
            Private _Gibibit_per_Second As ULong
            Public Property Gibibit_per_Second() As ULong
                Get
                    Return _Gibibit_per_Second
                End Get
                Set(ByVal value As ULong)
                    _Gibibit_per_Second = value
                End Set
            End Property

            Private _Terabit_per_Second As ULong
            Public Property Terabit_per_Second() As ULong
                Get
                    Return _Terabit_per_Second
                End Get
                Set(ByVal value As ULong)
                    _Terabit_per_Second = value
                End Set
            End Property
            Private _TeraByte_per_Second As ULong
            Public Property TeraByte_per_Second() As ULong
                Get
                    Return _TeraByte_per_Second
                End Get
                Set(ByVal value As ULong)
                    _TeraByte_per_Second = value
                End Set
            End Property
            Private _Tebibit_per_Second As ULong
            Public Property Tebibit_per_Second() As ULong
                Get
                    Return _Tebibit_per_Second
                End Get
                Set(ByVal value As ULong)
                    _Tebibit_per_Second = value
                End Set
            End Property
#End Region
            Public Sub New(ByVal value As ULong, ByVal valueScale As Data_Transfert_RateScale)
                Bit_per_Second = 0
                Kilobit_per_Second = 0
                Kilobyte_per_Second = 0
                Kibibit_per_Second = 0
                MegaBit_per_Second = 0
                MegaByte_per_Second = 0
                Mebibit_per_Second = 0
                Gigabit_per_Second = 0
                GigaByte_per_Second = 0
                Gibibit_per_Second = 0
                Terabit_per_Second = 0
                TeraByte_per_Second = 0
                Tebibit_per_Second = 0

                If valueScale = Data_Transfert_RateScale.Bit_per_Second Then
                    Kilobit_per_Second = value * 0.001
                    Kilobyte_per_Second = value * 0.000125
                    Kibibit_per_Second = value * 0.000976563
                    MegaBit_per_Second = value * 0.000001
                    MegaByte_per_Second = value * 0.000000125
                    Mebibit_per_Second = value * 0.00000095367
                    Gigabit_per_Second = value * 0.000000001
                    GigaByte_per_Second = value * 0.000000000125
                    Gibibit_per_Second = value * 0.00000000093132
                    Terabit_per_Second = value * 0.000000000001
                    TeraByte_per_Second = value * 0.000000000000125
                    Tebibit_per_Second = value * 0.00000000000090949
                    Bit_per_Second = value
                ElseIf valueScale = Data_Transfert_RateScale.Gibibit_per_Second Then
                    Kilobit_per_Second = value * 1074000
                    Kilobyte_per_Second = value * 134218
                    Kibibit_per_Second = value * 1049000
                    MegaBit_per_Second = value * 1073.74
                    MegaByte_per_Second = value * 134.218
                    Mebibit_per_Second = value * 1024
                    Bit_per_Second = value * 1074000000
                    Gigabit_per_Second = value * 1.07374
                    GigaByte_per_Second = value * 0.134218
                    Terabit_per_Second = value * 0.00107374
                    TeraByte_per_Second = value * 0.000134218
                    Tebibit_per_Second = value * 0.000976563
                    Gibibit_per_Second = value
                ElseIf valueScale = Data_Transfert_RateScale.Gigabit_per_second Then
                    Kilobit_per_Second = value * 1000000
                    Kilobyte_per_Second = value * 125000
                    Kibibit_per_Second = value * 976563
                    MegaBit_per_Second = value * 1000
                    MegaByte_per_Second = value * 125
                    Mebibit_per_Second = value * 953.674
                    GigaByte_per_Second = value * 0.125
                    Bit_per_Second = value * 1000000000.0
                    Terabit_per_Second = value * 0.001
                    TeraByte_per_Second = value * 0.000125
                    Tebibit_per_Second = value * 0.000909495
                    Gigabit_per_Second = value
                ElseIf valueScale = Data_Transfert_RateScale.Gigabyte_per_Second Then
                    Kilobit_per_Second = value * 8000000
                    Kilobyte_per_Second = value * 1000000
                    Kibibit_per_Second = value * 7813000
                    MegaBit_per_Second = value * 8000
                    MegaByte_per_Second = value * 1000
                    Mebibit_per_Second = value * 7629.39
                    Bit_per_Second = value * 8000000000
                    Gigabit_per_Second = value * 8
                    Gibibit_per_Second = value * 7.45058
                    Terabit_per_Second = value * 0.008
                    TeraByte_per_Second = value * 0.001
                    Tebibit_per_Second = value * 0.00727596
                    GigaByte_per_Second = value
                ElseIf valueScale = Data_Transfert_RateScale.Kibibit_per_Second Then
                    Kilobit_per_Second = value * 1.024
                    Kilobyte_per_Second = value * 0.128
                    Gibibit_per_Second = value * 0.00000095367
                    MegaBit_per_Second = value * 0.001024
                    MegaByte_per_Second = value * 0.000128
                    Mebibit_per_Second = value * 0.000976563
                    Bit_per_Second = value * 1024
                    Gigabit_per_Second = value * 0.000001024
                    GigaByte_per_Second = value * 0.000000128
                    Terabit_per_Second = value * 0.000000001024
                    TeraByte_per_Second = value * 0.000000000128
                    Tebibit_per_Second = value * 0.00000000093132
                    Kibibit_per_Second = value
                ElseIf valueScale = Data_Transfert_RateScale.Kilbyte_per_Second Then
                    Kilobit_per_Second = value * 8
                    Kibibit_per_Second = value * 7.8125
                    Gibibit_per_Second = value * 0.0000074506
                    MegaBit_per_Second = value * 0.008
                    MegaByte_per_Second = value * 0.001
                    Mebibit_per_Second = value * 0.00762939
                    Bit_per_Second = value * 8000
                    Gigabit_per_Second = value * 0.000008
                    GigaByte_per_Second = value * 0.000001
                    Terabit_per_Second = value * 0.000000008
                    TeraByte_per_Second = value * 0.000000001
                    Tebibit_per_Second = value * 0.000000007276
                    Kilobyte_per_Second = value
                ElseIf valueScale = Data_Transfert_RateScale.Kilobit_per_Second Then
                    Kilobyte_per_Second = value * 0.125
                    Kibibit_per_Second = value * 0.976563
                    Gibibit_per_Second = value * 0.00000093132
                    MegaBit_per_Second = value * 0.001
                    MegaByte_per_Second = value * 0.000125
                    Mebibit_per_Second = value * 0.000953674
                    Bit_per_Second = value * 1000
                    Gigabit_per_Second = value * 0.000001
                    GigaByte_per_Second = value * 0.000000125
                    Terabit_per_Second = value * 0.00000000090949
                    TeraByte_per_Second = value * 0.000000000125
                    Tebibit_per_Second = value * 0.00000000090949
                    Kilobit_per_Second = value



                ElseIf valueScale = Data_Transfert_RateScale.Mebibit_per_Second Then
                    Kilobyte_per_Second = value * 131.072
                    Kibibit_per_Second = value * 1024
                    Gibibit_per_Second = value * 0.000976563
                    MegaBit_per_Second = value * 1.04858
                    MegaByte_per_Second = value * 0.131072
                    Kilobit_per_Second = value * 1048.58
                    Bit_per_Second = value * 1049000
                    Gigabit_per_Second = value * 0.00104858
                    GigaByte_per_Second = value * 0.000131072
                    Terabit_per_Second = value * 0.0000010486
                    TeraByte_per_Second = value * 0.00000013107
                    Tebibit_per_Second = value * 0.00000095367
                    Mebibit_per_Second = value
                ElseIf valueScale = Data_Transfert_RateScale.Megabit_per_Second Then
                    Kilobyte_per_Second = value * 125
                    Kibibit_per_Second = value * 976.563
                    Gibibit_per_Second = value * 0.000931323
                    MegaByte_per_Second = value * 0.125
                    Mebibit_per_Second = value * 0.953674
                    Kilobit_per_Second = value * 1000
                    Bit_per_Second = value * 1000000
                    Gigabit_per_Second = value * 0.001
                    GigaByte_per_Second = value * 0.000125
                    Terabit_per_Second = value * 0.000001
                    TeraByte_per_Second = value * 0.000000125
                    Tebibit_per_Second = value * 0.00000090949
                    MegaBit_per_Second = value
                ElseIf valueScale = Data_Transfert_RateScale.Megabyte_per_Second Then
                    Kilobyte_per_Second = value * 1000
                    Kibibit_per_Second = value * 7812.5
                    Gibibit_per_Second = value * 0.00745058
                    MegaBit_per_Second = value * 8
                    Mebibit_per_Second = value * 7.62939
                    Kilobit_per_Second = value * 8000
                    Bit_per_Second = value * 8000000
                    Gigabit_per_Second = value * 0.008
                    GigaByte_per_Second = value * 0.001
                    Terabit_per_Second = value * 0.000007276
                    TeraByte_per_Second = value * 0.000001
                    Tebibit_per_Second = value * 0.000007276
                    MegaByte_per_Second = value
                ElseIf valueScale = Data_Transfert_RateScale.Tebibit_per_Second Then
                    Kilobyte_per_Second = value * 137400000
                    Kibibit_per_Second = value * 1074000000
                    Gibibit_per_Second = value * 1024
                    MegaByte_per_Second = value * 137439
                    Mebibit_per_Second = value * 1049000
                    Kilobit_per_Second = value * 1100000000
                    Bit_per_Second = value * 1100000000000
                    Gigabit_per_Second = value * 1099.51
                    GigaByte_per_Second = value * 137.439
                    Terabit_per_Second = value * 1.09951
                    TeraByte_per_Second = value * 0.137439
                    MegaBit_per_Second = value * 1100000
                    Tebibit_per_Second = value


                ElseIf valueScale = Data_Transfert_RateScale.Terabit_per_Second Then
                    Kilobyte_per_Second = value * 125000000
                    Kibibit_per_Second = value * 976600000
                    Gibibit_per_Second = value * 931.323
                    MegaByte_per_Second = value * 125000
                    Mebibit_per_Second = value * 953674
                    Kilobit_per_Second = value * 1000000000
                    Bit_per_Second = value * 1000000000000
                    Gigabit_per_Second = value * 1000
                    GigaByte_per_Second = value * 125
                    Tebibit_per_Second = value * 0.909495
                    TeraByte_per_Second = value * 0.125
                    MegaBit_per_Second = value * 1000000
                    Terabit_per_Second = value


                ElseIf valueScale = Data_Transfert_RateScale.Terabyte_per_Second Then
                    Kilobyte_per_Second = value * 1000000000
                    Kibibit_per_Second = value * 7813000000
                    Gibibit_per_Second = value * 7450.58
                    MegaByte_per_Second = value * 1000000
                    Mebibit_per_Second = value * 7629000
                    Kilobit_per_Second = value * 8000000000
                    Bit_per_Second = value * 8000000000000
                    Gigabit_per_Second = value * 8000
                    GigaByte_per_Second = value * 1000
                    Tebibit_per_Second = value * 7.27596
                    Terabit_per_Second = value * 8
                    MegaBit_per_Second = value * 8000000
                    TeraByte_per_Second = value

                End If


            End Sub

        End Class

        Public Class Time
#Region "<Property>"
            Private _NanoSecond As ULong
            Public Property NanoSecond() As ULong
                Get
                    Return _NanoSecond
                End Get
                Set(ByVal value As ULong)
                    _NanoSecond = value
                End Set
            End Property
            Private _MicroSecond As ULong
            Public Property MicroSecond() As ULong
                Get
                    Return _MicroSecond
                End Get
                Set(ByVal value As ULong)
                    _MicroSecond = value
                End Set
            End Property
            Private _MilliSecond As ULong
            Public Property MilliSecond() As ULong
                Get
                    Return _MilliSecond
                End Get
                Set(ByVal value As ULong)
                    _MilliSecond = value
                End Set
            End Property
            Private _Second As ULong
            Public Property Second() As ULong
                Get
                    Return _Second
                End Get
                Set(ByVal value As ULong)
                    _Second = value
                End Set
            End Property
            Private _Minute As ULong
            Public Property Minute() As ULong
                Get
                    Return _Minute
                End Get
                Set(ByVal value As ULong)
                    _Minute = value
                End Set
            End Property
            Private _Hour As ULong
            Public Property Hour() As ULong
                Get
                    Return _Hour
                End Get
                Set(ByVal value As ULong)
                    _Hour = value
                End Set
            End Property
            Private _Day As ULong
            Public Property Day() As ULong
                Get
                    Return _Day
                End Get
                Set(ByVal value As ULong)
                    _Day = value
                End Set
            End Property
            Private _Week As ULong
            Public Property Week() As ULong
                Get
                    Return _Week
                End Get
                Set(ByVal value As ULong)
                    _Week = value
                End Set
            End Property
            Private _Month As ULong
            Public Property Month() As ULong
                Get
                    Return _Month
                End Get
                Set(ByVal value As ULong)
                    _Month = value
                End Set
            End Property
            Private _Year As ULong
            Public Property Year() As ULong
                Get
                    Return _Year
                End Get
                Set(ByVal value As ULong)
                    _Year = value
                End Set
            End Property
            Private _Decade As ULong
            Public Property Decade() As ULong
                Get
                    Return _Decade
                End Get
                Set(ByVal value As ULong)
                    _Decade = value
                End Set
            End Property
            Private _Century As ULong
            Public Property Century() As ULong
                Get
                    Return _Century
                End Get
                Set(ByVal value As ULong)
                    _Century = value
                End Set
            End Property
#End Region
            Public Property Scale As TimeScale

            Public Sub New(ByVal value As ULong, ByVal valueScale As TimeScale)
                NanoSecond = 0
                MicroSecond = 0
                MilliSecond = 0
                Second = 0
                Minute = 0
                Hour = 0
                Day = 0
                Week = 0
                Month = 0
                Year = 0
                Decade = 0
                Century = 0
                Scale = valueScale
                If valueScale = TimeScale.Century Then
                    NanoSecond = value * 3154000000000000000
                    MicroSecond = value * 3154000000000000
                    MilliSecond = value * 3154000000000
                    Second = value * 3154000000
                    Minute = value * 52560000
                    Hour = value * 876000
                    Day = value * 36500
                    Week = value * 5214.29
                    Month = value * 1200
                    Year = value * 100
                    Decade = value * 10
                    Century = value
                ElseIf valueScale = TimeScale.Day Then
                    NanoSecond = value * 86400000000000
                    MicroSecond = value * 86400000000
                    MilliSecond = value * 86400000
                    Second = value * 86400
                    Minute = value * 1440
                    Hour = value * 24
                    Week = value * 0.142857
                    Month = value * 0.0328767
                    Year = value * 0.00273973
                    Decade = value * 0.000273973
                    Century = value * 0.000273973
                    Day = value
                ElseIf valueScale = TimeScale.Decade Then
                    NanoSecond = value * 315400000000000000
                    MicroSecond = value * 315400000000000
                    MilliSecond = value * 315400000000
                    Second = value * 315400000
                    Minute = value * 5256000
                    Hour = value * 87600
                    Day = value * 3650
                    Week = value * 521.429
                    Month = value * 120
                    Year = value * 10
                    Century = value * 0.1
                    Decade = value
                ElseIf valueScale = TimeScale.Hour Then
                    NanoSecond = value * 3600000000000
                    MicroSecond = value * 3600000000
                    MilliSecond = value * 3600000
                    Second = value * 3600
                    Minute = value * 60
                    Day = value * 0.0416667
                    Week = value * 0.00595238
                    Month = value * 0.00136986
                    Year = value * 0.000114155
                    Decade = value * 0.000011416
                    Century = value * 0.000011416
                    Hour = value
                ElseIf valueScale = TimeScale.Microsecond Then
                    NanoSecond = value * 1000
                    MilliSecond = value * 0.001
                    Second = value * 0.000001
                    Minute = value * 0.000000016667
                    Hour = value * 0.00000000027778
                    Day = value * 0.000000000011574
                    Week = value * 0.0000000000016534
                    Month = value * 0.00000000000038052
                    Year = value * 0.00000000000003171
                    Decade = value * 0.000000000000003171
                    Century = value * 0.000000000000003171
                    MicroSecond = value
                ElseIf valueScale = TimeScale.Millisecond Then

                    Dim Ts As TimeSpan = TimeSpan.FromMilliseconds(value)
                    Dim mydate As DateTime = New DateTime(Ts.Ticks)
                    MilliSecond = mydate.Millisecond
                    'NanoSecond = MilliSecond * 1000000
                    'MicroSecond = MilliSecond * 1000
                    Dim Ts2 As TimeSpan = TimeSpan.FromSeconds(value)
                    Dim Sec As DateTime = New Date(Ts2.Ticks)
                    Second = Sec.Second

                    NanoSecond = Second * 1000000000
                    MicroSecond = Second * 1000000
                    ' MilliSecond = Second * 1000
                    ' Minute = Second * 0.0166667
                    'Hour = Second * 0.000277778
                    Hour = Sec.Hour
                    Day = Second * 0.000011574
                    Week = Second * 0.0000016534
                    Month = Second * 0.00000038052
                    Year = Second * 0.00000003171
                    Decade = Second * 0.000000003171
                    Century = Second * 0.000000003171
                    Minute = Sec.Minute
                    ' Day = mydate.Day
                    ' Week = value * 0.0000000016534
                    'Second = value * 0.001
                    'Minute = value * 0.000016667
                    'Hour = value * 0.00000027778
                    'Day = value * 0.000000011574
                    'Week = value * 0.0000000016534
                    'Month = value * 0.00000000038052
                    'Year = value * 0.00000000003171
                    'Decade = value * 0.000000000003171
                    'Century = value * 0.000000000003171
                    'MilliSecond = value
                ElseIf valueScale = TimeScale.Minute Then
                    NanoSecond = value * 60000000000
                    MicroSecond = value * 60000000
                    MilliSecond = value * 60000
                    Second = value * 60
                    Hour = value * 0.0166667
                    Day = value * 0.000694444
                    Week = value * 0.000099206
                    Month = value * 0.000022831
                    Year = value * 0.0000019026
                    Decade = value * 0.00000019026
                    Century = value * 0.00000019026
                    Minute = value
                ElseIf valueScale = TimeScale.Month Then
                    NanoSecond = value * 2628000000000000
                    MicroSecond = value * 2628000000000
                    MilliSecond = value * 2628000000
                    Second = value * 2628000
                    Minute = value * 43800
                    Hour = value * 730.001
                    Day = value * 30.4167
                    Week = value * 4.34524
                    Year = value * 0.0833334
                    Decade = value * 0.00833334
                    Century = value * 0.00833334
                    Month = value
                ElseIf valueScale = TimeScale.Nanosecond Then
                    MicroSecond = value * 0.001
                    MilliSecond = value * 0.000001
                    Second = value * 0.000000001
                    Minute = value * 0.000000000016667
                    Hour = value * 0.00000000000027778
                    Day = value * 0.000000000000011574
                    Week = value * 0.0000000000000016534
                    Month = value * 0.00000000000000038052
                    Year = value * 3.171E-17
                    Decade = value * 3.171E-18
                    Century = value * 3.171E-18
                    NanoSecond = value
                ElseIf valueScale = TimeScale.Second Then
                    NanoSecond = value * 1000000000
                    MicroSecond = value * 1000000
                    MilliSecond = value * 1000
                    Minute = value * 0.0166667
                    Hour = value * 0.000277778
                    Day = value * 0.000011574
                    Week = value * 0.0000016534
                    Month = value * 0.00000038052
                    Year = value * 0.00000003171
                    Decade = value * 0.000000003171
                    Century = value * 0.000000003171
                    Second = value
                ElseIf valueScale = TimeScale.Week Then
                    NanoSecond = value * 604800000000000
                    MicroSecond = value * 604800000000
                    MilliSecond = value * 604800000
                    Second = value * 604800
                    Minute = value * 10080
                    Hour = value * 168
                    Day = value * 7
                    Month = value * 0.230137
                    Year = value * 0.0191781
                    Decade = value * 0.00191781
                    Century = value * 0.00191781
                    Week = value
                ElseIf valueScale = TimeScale.Year Then
                    NanoSecond = value * 31540000000000000
                    MicroSecond = value * 31540000000000
                    MilliSecond = value * 31540000000
                    Second = value * 31540000
                    Minute = value * 525600
                    Hour = value * 8760
                    Day = value * 365
                    Week = value * 52.1429
                    Month = value * 12
                    Decade = value * 0.1
                    Century = value * 0.1
                    Year = value
                End If
            End Sub


#Region "<Function>"
            Public Overrides Function ToString() As String
                'ToString(("HH:mm:ss"))
                If IsNothing(Scale) Then
                    Scale = TimeScale.Hour
                End If
                If Scale = Nothing Then
                    Scale = TimeScale.Hour
                End If
                Dim Result As String = ""
                If Scale = TimeScale.Century Then
                    Result = String.Format("{0}Century {1}Decade {2}Years - {3}Months -{4}Weeks -{5}Days [{6}:{7}:{8}:{9} {10}:{11}]", Century, Decade, Year, Month, Week, Day, Hour, Minute, Second, MilliSecond, MicroSecond, NanoSecond)
                ElseIf Scale = TimeScale.Day Then
                    Result = String.Format("{0}Days [{1}:{2}:{3}:{4} {5}:{6}]", Day, Hour, Minute, Second, MilliSecond, MicroSecond, NanoSecond)

                ElseIf Scale = TimeScale.Decade Then
                    Result = String.Format("{0}Decade {1}Years - {2}Months -{3}Weeks -{4}Days [{5}:{6}:{7}:{8} {9}:{10}]", Decade, Year, Month, Week, Day, Hour, Minute, Second, MilliSecond, MicroSecond, NanoSecond)


                ElseIf Scale = TimeScale.Hour Then
                    Result = String.Format("{0}:{1}:{2}:{3}", Hour, Minute, Second, MilliSecond)

                ElseIf Scale = TimeScale.Microsecond Then
                    Result = String.Format("{0}:{1}:{2}:{3} {4}:{5}", Hour, Minute, Second, MilliSecond, MicroSecond, NanoSecond)

                ElseIf Scale = TimeScale.Millisecond Then
                    Result = String.Format("{0}:{1}:{2}:{3}", Hour, Minute, Second, MilliSecond)

                ElseIf Scale = TimeScale.Minute Then
                    Result = String.Format("{0}:{1}:{2}:{3}", Hour, Minute, Second, MilliSecond)

                ElseIf Scale = TimeScale.Month Then
                    Result = String.Format("{0}Years - {1}Months -{2}Weeks -{3}Days [{4}:{5}:{6}:{7} {8}:{9}]", Year, Month, Week, Day, Hour, Minute, Second, MilliSecond, MicroSecond, NanoSecond)

                ElseIf Scale = TimeScale.Nanosecond Then
                    Result = String.Format("{0}:{1} {2}:{3} }", Second, MilliSecond, MicroSecond, NanoSecond)

                ElseIf Scale = TimeScale.Second Then
                    Result = String.Format("{0}:{1}:{2}:{3}", Hour, Minute, Second, MilliSecond)

                ElseIf Scale = TimeScale.Week Then
                    Result = String.Format("{0}Weeks -{1}Days [{2}:{3}:{4}:{5} {6}:{7}]", Week, Day, Hour, Minute, Second, MilliSecond, MicroSecond, NanoSecond)

                ElseIf Scale = TimeScale.Year Then
                    Result = String.Format("{0}Years - {1}Months -{2}Weeks -{3}Days [{4}:{5}:{6}:{7} {8}:{9}]", Year, Month, Week, Day, Hour, Minute, Second, MilliSecond, MicroSecond, NanoSecond)

                End If
                Return Result
            End Function
#End Region
        End Class

        Public Class Energy
#Region "<0> [Property]"
            Private _Joule As Double
            Public Property Joule() As Double
                Get
                    Return _Joule
                End Get
                Set(ByVal value As Double)
                    _Joule = value
                End Set
            End Property
            Private _KiloJoule As Double
            Public Property KiloJoule() As Double
                Get
                    Return _KiloJoule
                End Get
                Set(ByVal value As Double)
                    _KiloJoule = value
                End Set
            End Property
            Private _Gram_Calorie As Double
            Public Property Gram_Calorie() As Double
                Get
                    Return _Gram_Calorie
                End Get
                Set(ByVal value As Double)
                    _Gram_Calorie = value
                End Set
            End Property
            Private _Watt_Hour As Double
            Public Property Watt_Hour() As Double
                Get
                    Return _Watt_Hour
                End Get
                Set(ByVal value As Double)
                    _Watt_Hour = value
                End Set
            End Property

            Private _KiloWatt_Hour As Double
            Public Property KiloWatt_Hour() As Double
                Get
                    Return _KiloWatt_Hour
                End Get
                Set(ByVal value As Double)
                    _KiloWatt_Hour = value
                End Set
            End Property
            Private _Electonvolt As Double
            Public Property Electonvolt() As Double
                Get
                    Return _Electonvolt
                End Get
                Set(ByVal value As Double)
                    _Electonvolt = value
                End Set
            End Property

            Private _British_Therminal_Unit As Double
            Public Property British_Therminal_Unit() As Double
                Get
                    Return _British_Therminal_Unit
                End Get
                Set(ByVal value As Double)
                    _British_Therminal_Unit = value
                End Set
            End Property
            Private _US_Therm As Double
            Public Property US_Therm() As Double
                Get
                    Return _US_Therm
                End Get
                Set(ByVal value As Double)
                    _US_Therm = value
                End Set
            End Property

            Private _Foot_Pound As Double
            Public Property Foot_Pound() As Double
                Get
                    Return _Foot_Pound
                End Get
                Set(ByVal value As Double)
                    _Foot_Pound = value
                End Set
            End Property
            Private _Kilocalorie As Double
            Public Property Kilocalorie() As Double
                Get
                    Return _Kilocalorie
                End Get
                Set(ByVal value As Double)
                    _Kilocalorie = value
                End Set
            End Property

#End Region
            Public Sub New(ByVal value As ULong, ByVal valueScale As EnergyScale)
                If valueScale = EnergyScale.British_Therminal_Unit Then
                    Joule = value * 1055.06
                    KiloJoule = value * 1.05506
                    Gram_Calorie = value * 252.164
                    Kilocalorie = value * 0.252164
                    Watt_Hour = value * 0.293071
                    KiloWatt_Hour = value * 0.000293071
                    Electonvolt = value * 6.585E+21
                    US_Therm = value * 0.000010002
                    Foot_Pound = value * 778.169
                    British_Therminal_Unit = value
                ElseIf valueScale = EnergyScale.Electonvolt Then
                    Joule = value * 1.6022E-19
                    KiloJoule = value * 1.6022E-22
                    Gram_Calorie = value * 3.8293E-20
                    Kilocalorie = value * 3.8293E-23
                    Watt_Hour = value * 4.4505E-23
                    KiloWatt_Hour = value * 4.4505E-26
                    British_Therminal_Unit = value * 1.5186E-22
                    US_Therm = value * 1.5189E-27
                    Foot_Pound = value * 1.1817E-19
                    Electonvolt = value
                ElseIf valueScale = EnergyScale.Foot_Pound Then
                    Joule = value * 1.35582
                    KiloJoule = value * 0.00135582
                    Gram_Calorie = value * 0.324048
                    Kilocalorie = value * 0.000324048
                    Watt_Hour = value * 0.000376616
                    KiloWatt_Hour = value * 0.00000037662
                    Electonvolt = value * 8462000000000000000
                    British_Therminal_Unit = value * 0.00128507
                    US_Therm = value * 0.000000012854
                    Foot_Pound = value
                ElseIf valueScale = EnergyScale.Gram_calorie Then
                    Joule = value * 4.184
                    KiloJoule = value * 0.004184
                    Kilocalorie = value * 0.001
                    Watt_Hour = value * 0.00116222
                    KiloWatt_Hour = value * 0.0000011622
                    Electonvolt = value * 26110000000000000 * 1000
                    British_Therminal_Unit = value * 0.00396567
                    US_Therm = value * 0.000000039666
                    Foot_Pound = value * 3.08596
                    Gram_Calorie = value

                ElseIf valueScale = EnergyScale.Joule Then
                    KiloJoule = value * 0.001
                    Gram_Calorie = value * 0.239006
                    Kilocalorie = value * 0.000239006
                    Watt_Hour = value * 0.000277778
                    KiloWatt_Hour = value * 0.00000027778
                    Electonvolt = value * 6242000000000000000
                    British_Therminal_Unit = value * 0.000947817
                    US_Therm = value * 0.0000000094804
                    Foot_Pound = value * 0.737562
                    Joule = value

                ElseIf valueScale = EnergyScale.Kilocalorie Then
                    Joule = value * 4184
                    Gram_Calorie = value * 1000
                    KiloJoule = value * 4.184
                    Watt_Hour = value * 1.16222
                    KiloWatt_Hour = value * 0.00116222
                    Electonvolt = value * 2.611E+22
                    British_Therminal_Unit = value * 3.96567
                    US_Therm = value * 0.000039666
                    Foot_Pound = value * 3085.96
                    Kilocalorie = value

                ElseIf valueScale = EnergyScale.Kilojoule Then
                    Joule = value * 1000
                    Gram_Calorie = value * 239.006
                    Kilocalorie = value * 0.239006
                    Watt_Hour = value * 0.277778
                    KiloWatt_Hour = value * 0.000277778
                    Electonvolt = value * 6.242E+21
                    British_Therminal_Unit = value * 0.947817
                    US_Therm = value * 0.0000094804
                    Foot_Pound = value * 737.562
                    KiloJoule = value

                ElseIf valueScale = EnergyScale.Kilowatt_Hour Then
                    Joule = value * 3600000
                    KiloJoule = value * 3600
                    Gram_Calorie = value * 860421
                    Kilocalorie = value * 860.421
                    Watt_Hour = value * 1000
                    Electonvolt = value * 2.247E+25
                    British_Therminal_Unit = value * 3412.14
                    US_Therm = value * 0.0341296
                    Foot_Pound = value * 2655000
                    KiloWatt_Hour = value

                ElseIf valueScale = EnergyScale.US_Therm Then
                    Joule = value * 105500000
                    KiloJoule = value * 105480
                    Gram_Calorie = value * 25210000
                    Kilocalorie = value * 25210.4
                    Watt_Hour = value * 29300.1
                    KiloWatt_Hour = value * 29.3001
                    Electonvolt = value * 6.584E+26
                    British_Therminal_Unit = value * 99976.1
                    Foot_Pound = value * 77800000
                    US_Therm = value

                ElseIf valueScale = EnergyScale.Watt_Hour Then
                    Joule = value * 3600
                    KiloJoule = value * 3.6
                    Gram_Calorie = value * 860.421
                    Kilocalorie = value * 0.860421
                    KiloWatt_Hour = value * 0.001
                    Electonvolt = value * 2.247E+22
                    British_Therminal_Unit = value * 3.41214
                    US_Therm = value * 0.00003413
                    Foot_Pound = value * 2655.22
                    Watt_Hour = value

                End If
            End Sub

        End Class

    End Class
    Public Class Frequency
#Region "<0> [Property]"
        Private _Hertz As Double
        Public Property Hertz() As Double
            Get
                Return _Hertz
            End Get
            Set(ByVal value As Double)
                _Hertz = value
            End Set
        End Property
        Private _Kilohertz As Double
        Public Property Kilohertz() As Double
            Get
                Return _Kilohertz
            End Get
            Set(ByVal value As Double)
                _Kilohertz = value
            End Set
        End Property
        Private _Megahertz As Double
        Public Property Megahertz() As Double
            Get
                Return _Megahertz
            End Get
            Set(ByVal value As Double)
                _Megahertz = value
            End Set
        End Property
        Private _Gigahertz As Double
        Public Property Gigahertz() As Double
            Get
                Return _Gigahertz
            End Get
            Set(ByVal value As Double)
                _Gigahertz = value
            End Set
        End Property
#End Region
        Public Sub New(ByVal value As ULong, ByVal valueScale As FrequencyScale)
            If valueScale = FrequencyScale.Gigahertz Then
                Hertz = value * 1000000000
                Kilohertz = value * 1000000
                Megahertz = value * 1000
                Gigahertz = value
            ElseIf valueScale = FrequencyScale.Megahertz Then
                Hertz = value * 1000000
                Kilohertz = value * 1000
                Gigahertz = value * 0.001
                Megahertz = value

            ElseIf valueScale = FrequencyScale.Kilohertz Then
                Hertz = value * 1000
                Megahertz = value * 0.001
                Gigahertz = value * 0.000001
                Kilohertz = value

            ElseIf valueScale = FrequencyScale.Hertz Then
                Kilohertz = value * 0.001
                Megahertz = value * 0.000001
                Gigahertz = value * 0.000000001
                Hertz = value


            End If
        End Sub

    End Class
    Public Class Fuel_Economy
#Region "<0> [Property]"
        Private _US_Miles_per_Gallon As Double
        Public Property US_Miles_per_Gallon() As Double
            Get
                Return _US_Miles_per_Gallon
            End Get
            Set(ByVal value As Double)
                _US_Miles_per_Gallon = value
            End Set
        End Property

        Private _Imperial_Miles_per_Gallon As Double
        Public Property Imperial_Miles_per_Gallon() As Double
            Get
                Return _Imperial_Miles_per_Gallon
            End Get
            Set(ByVal value As Double)
                _Imperial_Miles_per_Gallon = value
            End Set
        End Property

        Private _Kilometer_per_Litre As Double
        Public Property Kilometer_per_Litre() As Double
            Get
                Return _Kilometer_per_Litre
            End Get
            Set(ByVal value As Double)
                _Kilometer_per_Litre = value
            End Set
        End Property
        Private _Litre_per_100_kilometres As Double
        Public Property Litre_per_100_kilometres() As Double
            Get
                Return _Litre_per_100_kilometres
            End Get
            Set(ByVal value As Double)
                _Litre_per_100_kilometres = value
            End Set
        End Property
#End Region
        Public Sub New(ByVal value As ULong, ByVal valueScale As FuelEconomyScale)
            If valueScale = FuelEconomyScale.US_Miles_per_Gallon Then
                Imperial_Miles_per_Gallon = value * 1.20095
                Kilometer_per_Litre = value * 0.425144
                Litre_per_100_kilometres = value * 235.215
                US_Miles_per_Gallon = value

            ElseIf valueScale = FuelEconomyScale.Litre_per_100_kilometres Then
                US_Miles_per_Gallon = value * 235.215
                Imperial_Miles_per_Gallon = value * 282.481
                Kilometer_per_Litre = value * 100
                Litre_per_100_kilometres = value

            ElseIf valueScale = FuelEconomyScale.Imperial_Miles_per_Gallon Then
                US_Miles_per_Gallon = value * 0.832674
                Kilometer_per_Litre = value * 0.354006
                Litre_per_100_kilometres = value * 282.481
                Imperial_Miles_per_Gallon = value

            ElseIf valueScale = FuelEconomyScale.Kilometer_per_Litre Then
                US_Miles_per_Gallon = value * 2.35215
                Imperial_Miles_per_Gallon = value * 2.82481
                Litre_per_100_kilometres = value * 100
                Kilometer_per_Litre = value

            End If
        End Sub

    End Class
    Public Class Mass
#Region "<0> [Property]"
        Private _Tonne As Double
        Public Property Tonne() As Double
            Get
                Return _Tonne
            End Get
            Set(ByVal value As Double)
                _Tonne = value
            End Set
        End Property

        Private _Kilogram As Double
        Public Property Kilogram() As Double
            Get
                Return _Kilogram
            End Get
            Set(ByVal value As Double)
                _Kilogram = value
            End Set
        End Property

        Private _Gram As Double
        Public Property Gram() As Double
            Get
                Return _Gram
            End Get
            Set(ByVal value As Double)
                _Gram = value
            End Set
        End Property

        Private _Milligram As Double
        Public Property Milligram() As Double
            Get
                Return _Milligram
            End Get
            Set(ByVal value As Double)
                _Milligram = value
            End Set
        End Property
        Private _Microgram As Double
        Public Property Microgram() As Double
            Get
                Return _Microgram
            End Get
            Set(ByVal value As Double)
                _Microgram = value
            End Set
        End Property

        Private _Imperial_Ton As Double
        Public Property Imperial_Ton() As Double
            Get
                Return _Imperial_Ton
            End Get
            Set(ByVal value As Double)
                _Imperial_Ton = value
            End Set
        End Property

        Private _US_Ton As Double
        Public Property US_Ton() As Double
            Get
                Return _US_Ton
            End Get
            Set(ByVal value As Double)
                _US_Ton = value
            End Set
        End Property

        Private _Stone As Double
        Public Property Stone() As Double
            Get
                Return _Stone
            End Get
            Set(ByVal value As Double)
                _Stone = value
            End Set
        End Property

        Private _Pound As Double
        Public Property Pound() As Double
            Get
                Return _Pound
            End Get
            Set(ByVal value As Double)
                _Pound = value
            End Set
        End Property
        Private _Ounce As Double
        Public Property Ounce() As Double
            Get
                Return _Ounce
            End Get
            Set(ByVal value As Double)
                _Ounce = value
            End Set
        End Property
#End Region
        Public Sub New(ByVal value As Double, ByVal valueScale As MassScale)
            If valueScale = MassScale.Gram Then
                Tonne = value * 0.000001
                Kilogram = value * 0.001
                Milligram = value * 1000000
                Microgram = value * 1000000
                Imperial_Ton = value * 0.00000098421
                US_Ton = value * 0.0000011023
                Stone = value * 0.000157473
                Pound = value * 0.00220462
                Ounce = value * 0.035274
                Gram = value

            ElseIf valueScale = MassScale.Imperial_Ton Then
                Tonne = value * 1.01605
                Kilogram = value * 1016.05
                Gram = value * 1016000
                Milligram = value * 1016000000
                Microgram = value * 1016000000000
                US_Ton = value * 1.12
                Stone = value * 160
                Pound = value * 2240
                Ounce = value * 35840
                Imperial_Ton = value

            ElseIf valueScale = MassScale.Kilogram Then
                Tonne = value * 0.001
                Gram = value * 1000
                Milligram = value * 1000000
                Microgram = value * 1000000000
                Imperial_Ton = value * 0.000984207
                US_Ton = value * 0.00110231
                Stone = value * 0.157473
                Pound = value * 2.20462
                Ounce = value * 35.274
                Kilogram = value

            ElseIf valueScale = MassScale.Microgram Then
                Tonne = value * 0.000000000001
                Kilogram = value * 0.000000001
                Gram = value * 0.000001
                Milligram = value * 0.001
                Imperial_Ton = value * 0.00000000000098421
                US_Ton = value * 0.0000000000011023
                Stone = value * 0.00000000015747
                Pound = value * 0.0000000022046
                Ounce = value * 0.000000035274
                Microgram = value

            ElseIf valueScale = MassScale.Milligram Then
                Tonne = value * 0.000000001
                Kilogram = value * 0.000001
                Gram = value * 0.001
                Microgram = value * 1000
                Imperial_Ton = value * 0.00000000098421
                US_Ton = value * 0.0000000011023
                Stone = value * 0.00000015747
                Pound = value * 0.0000022046
                Ounce = value * 0.000035274
                Milligram = value

            ElseIf valueScale = MassScale.Ounce Then
                Tonne = value * 0.00002835
                Kilogram = value * 0.0283495
                Gram = value * 28.3495
                Milligram = value * 28349.5
                Microgram = value * 28350000
                Imperial_Ton = value * 0.000027902
                US_Ton = value * 0.00003125
                Stone = value * 0.00446429
                Pound = value * 0.0625
                Ounce = value

            ElseIf valueScale = MassScale.Pound Then
                Tonne = value * 0.000453592
                Kilogram = value * 0.453592
                Gram = value * 453.592
                Milligram = value * 453592
                Microgram = value * 453600000
                Imperial_Ton = value * 0.000446429
                US_Ton = value * 0.0005
                Stone = value * 0.0714286
                Ounce = value * 16
                Pound = value

            ElseIf valueScale = MassScale.Stone Then
                Tonne = value * 0.00635029
                Kilogram = value * 6.35029
                Gram = value * 6350.29
                Milligram = value * 6350000
                Microgram = value * 6350000000
                Imperial_Ton = value * 0.00625
                US_Ton = value * 0.007
                Pound = value * 14
                Ounce = value * 224
                Stone = value

            ElseIf valueScale = MassScale.US_Ton Then
                Tonne = value * 0.907185
                Kilogram = value * 907.185
                Gram = value * 907185
                Milligram = value * 907200000
                Microgram = value * 907200000000
                Imperial_Ton = value * 0.892857
                Stone = value * 142.857
                Pound = value * 2000
                Ounce = value * 32000
                US_Ton = value

            ElseIf valueScale = MassScale.Tonne Then
                Kilogram = value * 1000
                Gram = value * 1000
                Milligram = value * 1000000
                Microgram = value * 1000000000
                Imperial_Ton = value * 0.000984207
                US_Ton = value * 1.10231
                Stone = value * 157.472999999348
                Pound = value * 2204.61999989109
                Ounce = value * 35274.00004546
                Tonne = value
            End If
        End Sub
    End Class
    Public Class Length
#Region "<0> [Property]"
        Private _Kilometre As Double
        Public Property Kilometre() As Double
            Get
                Return _Kilometre
            End Get
            Set(ByVal value As Double)
                _Kilometre = value
            End Set
        End Property
        Private _Metre As Double
        Public Property Metre() As Double
            Get
                Return _Metre
            End Get
            Set(ByVal value As Double)
                _Metre = value
            End Set
        End Property
        Private _Centimetre As Double
        Public Property Centimetre() As Double
            Get
                Return _Centimetre
            End Get
            Set(ByVal value As Double)
                _Centimetre = value
            End Set
        End Property
        Private _Millimetre As Double
        Public Property Millimetre() As Double
            Get
                Return _Millimetre
            End Get
            Set(ByVal value As Double)
                _Millimetre = value
            End Set
        End Property

        Private _Micrometre As Double
        Public Property Micrometre() As Double
            Get
                Return _Micrometre
            End Get
            Set(ByVal value As Double)
                _Micrometre = value
            End Set
        End Property

        Private _Nanometre As Double
        Public Property Nanometre() As Double
            Get
                Return _Nanometre
            End Get
            Set(ByVal value As Double)
                _Nanometre = value
            End Set
        End Property

        Private _Mile As Double
        Public Property Mile() As Double
            Get
                Return _Mile
            End Get
            Set(ByVal value As Double)
                _Mile = value
            End Set
        End Property

        Private _Yard As Double
        Public Property Yard() As Double
            Get
                Return _Yard
            End Get
            Set(ByVal value As Double)
                _Yard = value
            End Set
        End Property
        Private _Foot As Double
        Public Property Foot() As Double
            Get
                Return _Foot
            End Get
            Set(ByVal value As Double)
                _Foot = value
            End Set
        End Property

        Private _Inch As Double
        Public Property Inch() As Double
            Get
                Return _Inch
            End Get
            Set(ByVal value As Double)
                _Inch = value
            End Set
        End Property
        Private _Nautical_Mile As Double
        Public Property Nautical_Mile() As Double
            Get
                Return _Nautical_Mile
            End Get
            Set(ByVal value As Double)
                _Nautical_Mile = value
            End Set
        End Property
#End Region

        Public Sub New(ByVal Value As ULong, ByVal valueScale As LengthScale)
            If valueScale = LengthScale.Centimetre Then
                Kilometre = Value * 0.00001
                Metre = Value * 0.01
                Millimetre = Value * 10
                Micrometre = Value * 10000
                Nanometre = Value * 10000000
                Mile = Value * 0.0000062137
                Yard = Value * 0.0109361
                Foot = Value * 0.0328084
                Inch = Value * 0.393701
                Nautical_Mile = Value * 0.0000053996
                Centimetre = Value

            ElseIf valueScale = LengthScale.Foot Then
                Kilometre = Value * 0.0003048
                Metre = Value * 0.0003048
                Centimetre = Value * 30.48
                Micrometre = Value * 304800
                Millimetre = Value * 304.8
                Nanometre = Value * 304800000
                Mile = Value * 0.000189394
                Yard = Value * 0.333333
                Inch = Value * 12
                Nautical_Mile = Value * 0.000164579
                Foot = Value

            ElseIf valueScale = LengthScale.Inch Then
                Kilometre = Value * 0.0000254
                Metre = Value * 0.0254
                Centimetre = Value * 2.54
                Micrometre = Value * 25400
                Millimetre = Value * 25.4
                Nanometre = Value * 25400000
                Mile = Value * 0.000015783
                Yard = Value * 0.0277778
                Foot = Value * 0.0833333
                Nautical_Mile = Value * 0.000013715
                Inch = Value

            ElseIf valueScale = LengthScale.Kilometre Then
                Metre = Value * 1000
                Centimetre = Value * 100000
                Millimetre = Value * 1000000
                Micrometre = Value * 1000000000
                Nanometre = Value * 1000000000000
                Mile = Value * 0.621371
                Yard = Value * 1093.61
                Foot = Value * 3280.84
                Inch = Value * 39370.1
                Nautical_Mile = Value * 0.539957
                Kilometre = Value

            ElseIf valueScale = LengthScale.Metre Then
                Kilometre = Value * 0.001
                Centimetre = Value * 100
                Millimetre = Value * 1000
                Micrometre = Value * 1000000
                Nanometre = Value * 1000000000
                Mile = Value * 0.000621371
                Yard = Value * 1.09361
                Foot = Value * 3.28084
                Inch = Value * 39.3701
                Nautical_Mile = Value * 0.000539957
                Metre = Value

            ElseIf valueScale = LengthScale.Micrometre Then
                Kilometre = Value * 0.000000001
                Metre = Value * 0.000001
                Centimetre = Value * 0.0001
                Millimetre = Value * 25400
                Nanometre = Value * 1000
                Mile = Value * 0.00000000062137
                Yard = Value * 0.0000010936
                Foot = Value * 0.0000032808
                Inch = Value * 0.00003937
                Nautical_Mile = Value * 0.00000000053996
                Micrometre = Value

            ElseIf valueScale = LengthScale.Mile Then
                Kilometre = Value * 1.60934
                Metre = Value * 1609.34
                Centimetre = Value * 160934
                Micrometre = Value * 1609000000
                Millimetre = Value * 1609000
                Nanometre = Value * 1609000000000
                Yard = Value * 1760
                Foot = Value * 5280
                Inch = Value * 63360
                Nautical_Mile = Value * 0.868976
                Mile = Value

            ElseIf valueScale = LengthScale.Millimetre Then
                Kilometre = Value * 0.000001
                Metre = Value * 0.001
                Centimetre = Value * 0.1
                Micrometre = Value * 1000
                Nanometre = Value * 1000000
                Mile = Value * 0.00000062137
                Yard = Value * 0.00109361
                Foot = Value * 0.00328084
                Inch = Value * 0.0393701
                Nautical_Mile = Value * 0.00000053996
                Millimetre = Value

            ElseIf valueScale = LengthScale.Nanometre Then
                Kilometre = Value * 0.000000000001
                Metre = Value * 0.000000001
                Centimetre = Value * 0.0000001
                Micrometre = Value * 0.001
                Millimetre = Value * 0.000001
                Mile = Value * 0.00000000000062137
                Yard = Value * 0.0000000010936
                Foot = Value * 0.0000000032808
                Inch = Value * 0.00000003937
                Nautical_Mile = Value * 0.00000000000053996
                Nanometre = Value

            ElseIf valueScale = LengthScale.Nautical_Mile Then
                Kilometre = Value * 1.852
                Metre = Value * 1852
                Centimetre = Value * 185200
                Micrometre = Value * 1852000000
                Millimetre = Value * 1852000
                Nanometre = Value * 1852000000000
                Mile = Value * 1.15078
                Yard = Value * 2025.37
                Foot = Value * 6076.12
                Inch = Value * 72913.4
                Nautical_Mile = Value

            ElseIf valueScale = LengthScale.Yard Then
                Kilometre = Value * 0.0009144
                Metre = Value * 0.9144
                Centimetre = Value * 91.44
                Micrometre = Value * 914400
                Millimetre = Value * 914.4
                Nanometre = Value * 914400000
                Mile = Value * 0.000568182
                Foot = Value * 3
                Inch = Value * 36
                Nautical_Mile = Value * 0.000493737
                Yard = Value

            End If
        End Sub
    End Class
    Public Class Plane_Angle
#Region "<0> [Property]"
        Private _Degree As Double
        Public Property Degree() As Double
            Get
                Return _Degree
            End Get
            Set(ByVal value As Double)
                _Degree = value
            End Set
        End Property

        Private _Radian As Double
        Public Property Radian() As Double
            Get
                Return _Radian
            End Get
            Set(ByVal value As Double)
                _Radian = value
            End Set
        End Property

        Private _Milliradian As Double
        Public Property Milliradian() As Double
            Get
                Return _Milliradian
            End Get
            Set(ByVal value As Double)
                _Milliradian = value
            End Set
        End Property
        Private _Minute_of_Arc As Double
        Public Property Minute_of_Arc() As Double
            Get
                Return _Minute_of_Arc
            End Get
            Set(ByVal value As Double)
                _Minute_of_Arc = value
            End Set
        End Property

        Private _Second_of_Arc As Double
        Public Property Second_of_Arc() As Double
            Get
                Return _Second_of_Arc
            End Get
            Set(ByVal value As Double)
                _Second_of_Arc = value
            End Set
        End Property
        Private _Gradian As Double
        Public Property Gradian() As Double
            Get
                Return _Gradian
            End Get
            Set(ByVal value As Double)
                _Gradian = value
            End Set
        End Property
#End Region
        Public Sub New(ByVal Value As ULong, ByVal valueScale As Plane_AngleScale)
            If valueScale = Plane_AngleScale.Degree Then
                Radian = Value * 0.0174533
                Milliradian = Value * 17.4533
                Minute_of_Arc = Value * 60
                Second_of_Arc = Value * 3600
                Gradian = Value * 1.11111
                Degree = Value

            ElseIf valueScale = Plane_AngleScale.Gradian Then
                Degree = Value * 0.9
                Radian = Value * 0.015708
                Milliradian = Value * 15.708
                Minute_of_Arc = Value * 54
                Second_of_Arc = Value * 3240
                Gradian = Value

            ElseIf valueScale = Plane_AngleScale.Milliradian Then
                Degree = Value * 0.0572958
                Radian = Value * 0.001
                Minute_of_Arc = Value * 3.43775
                Second_of_Arc = Value * 206.265
                Gradian = Value * 0.063662
                Milliradian = Value

            ElseIf valueScale = Plane_AngleScale.Minute_of_Arc Then
                Degree = Value * 0.0166667
                Radian = Value * 0.000290888
                Milliradian = Value * 0.290888
                Second_of_Arc = Value * 60
                Gradian = Value * 0.0185185
                Minute_of_Arc = Value

            ElseIf valueScale = Plane_AngleScale.Radian Then
                Degree = Value * 57.2958
                Milliradian = Value * 1000
                Minute_of_Arc = Value * 3437.75
                Second_of_Arc = Value * 206265
                Gradian = Value * 63.662
                Radian = Value

            ElseIf valueScale = Plane_AngleScale.Second_of_Arc Then
                Degree = Value * 0.000277778
                Radian = Value * 0.0000048481
                Milliradian = Value * 0.00484814
                Minute_of_Arc = Value * 0.0166667
                Gradian = Value * 0.000308642
                Second_of_Arc = Value

            End If
        End Sub
    End Class
    Public Class Pressure
#Region "<0> [Property]"
        Private _Atmosphere As Double
        Public Property Atmosphere() As Double
            Get
                Return _Atmosphere
            End Get
            Set(ByVal value As Double)
                _Atmosphere = value
            End Set
        End Property

        Private _Bar As Double
        Public Property Bar() As Double
            Get
                Return _Bar
            End Get
            Set(ByVal value As Double)
                _Bar = value
            End Set
        End Property
        Private _Pascal As Double
        Public Property Pascal() As Double
            Get
                Return _Pascal
            End Get
            Set(ByVal value As Double)
                _Pascal = value
            End Set
        End Property
        Private _Pound_Force_per_Square_inch As Double
        Public Property Pound_Force_per_Square_inch() As Double
            Get
                Return _Pound_Force_per_Square_inch
            End Get
            Set(ByVal value As Double)
                _Pound_Force_per_Square_inch = value
            End Set
        End Property
        Private _Torr As Double
        Public Property Torr() As Double
            Get
                Return _Torr
            End Get
            Set(ByVal value As Double)
                _Torr = value
            End Set
        End Property
#End Region
        Public Sub New(ByVal Value As ULong, ByVal valueScale As PressureScale)
            If valueScale = PressureScale.Atmosphere Then
                Bar = Value * 1.01325
                Pascal = Value * 101325
                Pound_Force_per_Square_inch = Value * 14.6959
                Torr = Value * 760
                Atmosphere = Value

            ElseIf valueScale = PressureScale.Bar Then
                Atmosphere = Value * 0.986923
                Pascal = Value * 100000
                Pound_Force_per_Square_inch = Value * 14.5038
                Torr = Value * 750.062
                Bar = Value

            ElseIf valueScale = PressureScale.Pascal Then
                Atmosphere = Value * 0.0000098692
                Bar = Value * 0.00001
                Pound_Force_per_Square_inch = Value * 0.000145038
                Torr = Value * 0.00750062
                Pascal = Value

            ElseIf valueScale = PressureScale.Torr Then
                Atmosphere = Value * 0.00131579
                Bar = Value * 0.00133322
                Pascal = Value * 133.322
                Pound_Force_per_Square_inch = Value * 0.0193368
                Torr = Value
            ElseIf valueScale = PressureScale.Pound_Force_per_Square_inch Then
                Atmosphere = Value * 0.068046
                Bar = Value * 0.0689476
                Pascal = Value * 6894.76
                Torr = Value * 51.7149
                Pound_Force_per_Square_inch = Value

            End If
        End Sub

    End Class
    Public Class Speed

#Region "<0> [Property]"
        Private _Miles_per_Hour As Double
        Public Property Miles_per_Hour() As Double
            Get
                Return _Miles_per_Hour
            End Get
            Set(ByVal value As Double)
                _Miles_per_Hour = value
            End Set
        End Property

        Private _Foot_per_Second As Double
        Public Property Foot_per_Second() As Double
            Get
                Return _Foot_per_Second
            End Get
            Set(ByVal value As Double)
                _Foot_per_Second = value
            End Set
        End Property

        Private _Metre_per_Second As Double
        Public Property Metre_per_Second() As Double
            Get
                Return _Metre_per_Second
            End Get
            Set(ByVal value As Double)
                _Metre_per_Second = value
            End Set
        End Property

        Private _Kilometre_per_Hour As Double
        Public Property Kilometre_per_Hour() As Double
            Get
                Return _Kilometre_per_Hour
            End Get
            Set(ByVal value As Double)
                _Kilometre_per_Hour = value
            End Set
        End Property
        Private _Knot As Double
        Public Property Knot() As Double
            Get
                Return _Knot
            End Get
            Set(ByVal value As Double)
                _Knot = value
            End Set
        End Property
#End Region
        Public Sub New(ByVal Value As ULong, ByVal valueScale As SpeedScale)
            If valueScale = SpeedScale.Foot_per_Second Then
                Miles_per_Hour = Value * 0.681818
                Metre_per_Second = Value * 0.3048
                Kilometre_per_Hour = Value * 1.09728
                Knot = Value * 0.592484
                Foot_per_Second = Value
            ElseIf valueScale = SpeedScale.Kilometre_per_Hour Then
                Miles_per_Hour = Value * 0.621371
                Metre_per_Second = Value * 0.277778
                Foot_per_Second = Value * 0.911344
                Knot = Value * 0.539957
                Kilometre_per_Hour = Value
            ElseIf valueScale = SpeedScale.Knot Then
                Miles_per_Hour = Value * 1.15078
                Metre_per_Second = Value * 0.514444
                Foot_per_Second = Value * 1.68781
                Kilometre_per_Hour = Value * 1.852
                Knot = Value
            ElseIf valueScale = SpeedScale.Metre_per_Second Then
                Foot_per_Second = Value * 3.28084
                Miles_per_Hour = Value * 2.23694
                Kilometre_per_Hour = Value * 3.6
                Knot = Value * 1.94384
                Metre_per_Second = Value
            ElseIf valueScale = SpeedScale.Miles_per_Hour Then
                Foot_per_Second = Value * 1.46667
                Metre_per_Second = Value * 0.44704
                Kilometre_per_Hour = Value * 1.60934
                Knot = Value * 0.868976
                Miles_per_Hour = Value
            End If
        End Sub

    End Class
    Public Class Temperature
#Region "<0> [Property]"
        Private _Celsuis As Double
        Public Property Celsuis() As Double
            Get
                Return _Celsuis
            End Get
            Set(ByVal value As Double)
                _Celsuis = value
            End Set
        End Property
        Private _Fahrenheit As Double
        Public Property Fahrenheit() As Double
            Get
                Return _Fahrenheit
            End Get
            Set(ByVal value As Double)
                _Fahrenheit = value
            End Set
        End Property
        Private _Kelvin As Double
        Public Property Kelvin() As Double
            Get
                Return _Kelvin
            End Get
            Set(ByVal value As Double)
                _Kelvin = value
            End Set
        End Property
#End Region
        Public Sub New(ByVal Value As ULong, ByVal valueScale As TemperatureScale)
            If valueScale = TemperatureScale.Celsuis Then
                Fahrenheit = Value * 33.8
                Kelvin = Value * 273.15
                Celsuis = Value

            ElseIf valueScale = TemperatureScale.Fahrenheit Then
                Celsuis = Value * -17.2222
                Kelvin = Value * 255.928
                Fahrenheit = Value

            ElseIf valueScale = TemperatureScale.Kelvin Then
                Fahrenheit = Value * -457.87
                Celsuis = Value * -273.15
                Kelvin = Value

            End If
        End Sub
    End Class
    Public Class Volume
#Region "<0> [Property]"
        Private _US_Liquid_Gallon As Double
        Public Property US_Liquid_Gallon() As Double
            Get
                Return _US_Liquid_Gallon
            End Get
            Set(ByVal value As Double)
                _US_Liquid_Gallon = value
            End Set
        End Property
        Private _US_Liquid_Quart As Double
        Public Property US_Liquid_Quart() As Double
            Get
                Return _US_Liquid_Quart
            End Get
            Set(ByVal value As Double)
                _US_Liquid_Quart = value
            End Set
        End Property
        Private _US_Liquid_Pint As Double
        Public Property US_Liquid_Pint() As Double
            Get
                Return _US_Liquid_Pint
            End Get
            Set(ByVal value As Double)
                _US_Liquid_Pint = value
            End Set
        End Property
        Private _US_Legal_Cup As Double
        Public Property US_Legal_Cup() As Double
            Get
                Return _US_Legal_Cup
            End Get
            Set(ByVal value As Double)
                _US_Legal_Cup = value
            End Set
        End Property
        Private _US_Fluid_Ounce As Double
        Public Property US_Fluid_Ounce() As Double
            Get
                Return _US_Fluid_Ounce
            End Get
            Set(ByVal value As Double)
                _US_Fluid_Ounce = value
            End Set
        End Property
        Private _US_Tablespoon As Double
        Public Property US_Tablespoon() As Double
            Get
                Return _US_Tablespoon
            End Get
            Set(ByVal value As Double)
                _US_Tablespoon = value
            End Set
        End Property
        Private _US_Teaspoon As Double
        Public Property US_Teaspoon() As Double
            Get
                Return _US_Teaspoon
            End Get
            Set(ByVal value As Double)
                _US_Teaspoon = value
            End Set
        End Property
        Private _Cubic_Metre As Double
        Public Property Cubic_Metre() As Double
            Get
                Return _Cubic_Metre
            End Get
            Set(ByVal value As Double)
                _Cubic_Metre = value
            End Set
        End Property
        Private _Litre As Double
        Public Property Litre() As Double
            Get
                Return _Litre
            End Get
            Set(ByVal value As Double)
                _Litre = value
            End Set
        End Property
        Private _Mililitre As Double
        Public Property Mililitre() As Double
            Get
                Return _Mililitre
            End Get
            Set(ByVal value As Double)
                _Mililitre = value
            End Set
        End Property
        Private _Imperial_Quart As Double
        Public Property Imperial_Quart() As Double
            Get
                Return _Imperial_Quart
            End Get
            Set(ByVal value As Double)
                _Imperial_Quart = value
            End Set
        End Property
        Private _Imperial_Pint As Double
        Public Property Imperial_Pint() As Double
            Get
                Return _Imperial_Pint
            End Get
            Set(ByVal value As Double)
                _Imperial_Pint = value
            End Set
        End Property
        Private _Imperial_Cup As Double
        Public Property Imperial_Cup() As Double
            Get
                Return _Imperial_Cup
            End Get
            Set(ByVal value As Double)
                _Imperial_Cup = value
            End Set
        End Property
        Private _Imperial_Fluid_Ounce As Double
        Public Property Imperial_Fluid_Ounce() As Double
            Get
                Return _Imperial_Fluid_Ounce
            End Get
            Set(ByVal value As Double)
                _Imperial_Fluid_Ounce = value
            End Set
        End Property
        Private _Imperial_Tablespoon As Double
        Public Property Imperial_Tablespoon() As Double
            Get
                Return _Imperial_Tablespoon
            End Get
            Set(ByVal value As Double)
                _Imperial_Tablespoon = value
            End Set
        End Property
        Private _Imperial_Teaspoon As Double
        Public Property Imperial_Teaspoon() As Double
            Get
                Return _Imperial_Teaspoon
            End Get
            Set(ByVal value As Double)
                _Imperial_Teaspoon = value
            End Set
        End Property
        Private _Cubic_Foot As Double
        Public Property Cubic_Foot() As Double
            Get
                Return _Cubic_Foot
            End Get
            Set(ByVal value As Double)
                _Cubic_Foot = value
            End Set
        End Property
        Private _Cubit_Inch As Double
        Public Property Cubit_Inch() As Double
            Get
                Return _Cubit_Inch
            End Get
            Set(ByVal value As Double)
                _Cubit_Inch = value
            End Set
        End Property
        Private _Imperial_Gallon As Double
        Public Property Imperial_Gallon() As Double
            Get
                Return _Imperial_Gallon
            End Get
            Set(ByVal value As Double)
                _Imperial_Gallon = value
            End Set
        End Property
#End Region
        Public Sub New(ByVal value As ULong, ByVal ValueScale As VolumeScale)
            If ValueScale = VolumeScale.Cubic_Foot Then
                US_Liquid_Gallon = value * 7.48052
                US_Liquid_Quart = value * 29.9221
                US_Liquid_Pint = value * 59.8442
                US_Legal_Cup = value * 117.987
                US_Fluid_Ounce = value * 957.506
                US_Tablespoon = value * 1915.01
                US_Teaspoon = value * 5745.04
                Cubic_Metre = value * 0.0283168
                Litre = value * 28.3168
                Mililitre = value * 28316.8
                Imperial_Gallon = value * 6.22884
                Imperial_Quart = value * 24.9153
                Imperial_Pint = value * 56.6337
                Imperial_Cup = value * 99.6614
                Imperial_Fluid_Ounce = value * 996.614
                Imperial_Tablespoon = value * 1594.58
                Imperial_Teaspoon = value * 4783.74
                Cubit_Inch = value * 1728
                Cubic_Foot = value

            ElseIf ValueScale = VolumeScale.Cubic_Metre Then
                US_Liquid_Gallon = value * 264.172
                US_Liquid_Quart = value * 1056.69
                US_Liquid_Pint = value * 2113.38
                US_Legal_Cup = value * 4166.67
                US_Fluid_Ounce = value * 33814
                US_Tablespoon = value * 67628
                US_Teaspoon = value * 202884
                Cubit_Inch = value * 61023.7
                Litre = value * 1000
                Mililitre = value * 1000000
                Imperial_Gallon = value * 219.969
                Imperial_Quart = value * 879.877
                Imperial_Pint = value * 2000
                Imperial_Cup = value * 3519.51
                Imperial_Fluid_Ounce = value * 35195.1
                Imperial_Tablespoon = value * 56312.1
                Imperial_Teaspoon = value * 168936
                Cubic_Foot = value * 35.3147
                Cubic_Metre = value

            ElseIf ValueScale = VolumeScale.Cubit_Inch Then
                US_Liquid_Gallon = value * 0.004329
                US_Liquid_Quart = value * 0.017316
                US_Liquid_Pint = value * 0.034632
                US_Legal_Cup = value * 0.0682794
                US_Fluid_Ounce = value * 0.554113
                US_Tablespoon = value * 1.10823
                US_Teaspoon = value * 3.32468
                Cubic_Metre = value * 0.000016387
                Litre = value * 0.0163871
                Mililitre = value * 16.3871
                Imperial_Gallon = value * 0.00360465
                Imperial_Quart = value * 0.0144186
                Imperial_Pint = value * 0.0327741
                Imperial_Cup = value * 0.0576744
                Imperial_Fluid_Ounce = value * 0.576744
                Imperial_Tablespoon = value * 0.92279
                Imperial_Teaspoon = value * 2.76837
                Cubic_Foot = value * 0.000578704
                Cubit_Inch = value

            ElseIf ValueScale = VolumeScale.Imperial_Cup Then
                US_Liquid_Gallon = value * 0.0750594
                US_Liquid_Quart = value * 0.300237
                US_Liquid_Pint = value * 0.600475
                US_Legal_Cup = value * 1.18388
                US_Fluid_Ounce = value * 9.6076
                US_Tablespoon = value * 19.2152
                US_Teaspoon = value * 57.6456
                Cubic_Metre = value * 0.000284131
                Litre = value * 0.284131
                Mililitre = value * 284.131
                Imperial_Gallon = value * 0.0625
                Imperial_Quart = value * 0.25
                Imperial_Pint = value * 0.568261
                Imperial_Fluid_Ounce = value * 10
                Imperial_Tablespoon = value * 16
                Imperial_Teaspoon = value * 48
                Cubic_Foot = value * 0.010034
                Cubit_Inch = value * 17.3387
                Imperial_Cup = value

            ElseIf ValueScale = VolumeScale.Imperial_Fluid_Ounce Then
                US_Liquid_Gallon = value * 0.00750594
                US_Liquid_Quart = value * 0.0300237
                US_Liquid_Pint = value * 0.0600475
                US_Legal_Cup = value * 0.118388
                US_Fluid_Ounce = value * 0.96076
                US_Tablespoon = value * 1.92152
                US_Teaspoon = value * 5.76456
                Cubic_Metre = value * 0.000028413
                Litre = value * 0.0284131
                Mililitre = value * 28.4131
                Imperial_Gallon = value * 0.00625
                Imperial_Quart = value * 0.025
                Imperial_Pint = value * 0.0568261
                Imperial_Cup = value * 0.1
                Imperial_Tablespoon = value * 1.6
                Imperial_Teaspoon = value * 4.8
                Cubic_Foot = value * 0.0010034
                Cubit_Inch = value * 1.73387
                Imperial_Fluid_Ounce = value

            ElseIf ValueScale = VolumeScale.Imperial_Gallon Then
                US_Liquid_Gallon = value * 1.20095
                US_Liquid_Quart = value * 4.8038
                US_Liquid_Pint = value * 9.6076
                US_Legal_Cup = value * 18.942
                US_Fluid_Ounce = value * 153.722
                US_Tablespoon = value * 307.443
                US_Teaspoon = value * 922.33
                Cubic_Metre = value * 0.00454609
                Litre = value * 4.54609
                Mililitre = value * 4546.09
                Imperial_Quart = value * 4
                Imperial_Pint = value * 9.09218
                Imperial_Cup = value * 16
                Imperial_Fluid_Ounce = value * 160
                Imperial_Tablespoon = value * 256
                Imperial_Teaspoon = value * 768
                Cubic_Foot = value * 0.160544
                Cubit_Inch = value * 277.419
                Imperial_Gallon = value

            ElseIf ValueScale = VolumeScale.Imperial_Pint Then
                US_Liquid_Gallon = value * 0.132086
                US_Liquid_Quart = value * 0.528344
                US_Liquid_Pint = value * 1.05669
                US_Legal_Cup = value * 2.08333
                US_Fluid_Ounce = value * 16.907
                US_Tablespoon = value * 33.814
                US_Teaspoon = value * 101.442
                Cubic_Metre = value * 0.0005
                Litre = value * 0.5
                Mililitre = value * 500
                Imperial_Gallon = value * 0.109985
                Imperial_Quart = value * 0.439938
                Imperial_Cup = value * 1.75975
                Imperial_Fluid_Ounce = value * 17.5975
                Imperial_Tablespoon = value * 28.1561
                Imperial_Teaspoon = value * 84.4682
                Cubic_Foot = value * 0.0176573
                Cubit_Inch = value * 30.5119
                Imperial_Pint = value

            ElseIf ValueScale = VolumeScale.Imperial_Quart Then
                US_Liquid_Gallon = value * 0.300237
                US_Liquid_Quart = value * 1.20095
                US_Liquid_Pint = value * 2.4019
                US_Legal_Cup = value * 4.73551
                US_Fluid_Ounce = value * 38.4304
                US_Tablespoon = value * 76.8608
                US_Teaspoon = value * 230.582
                Cubic_Metre = value * 0.00113652
                Litre = value * 1.13652
                Mililitre = value * 1136.52
                Imperial_Gallon = value * 0.25
                Imperial_Pint = value * 2.27304
                Imperial_Cup = value * 4
                Imperial_Fluid_Ounce = value * 40
                Imperial_Tablespoon = value * 64
                Imperial_Teaspoon = value * 192
                Cubic_Foot = value * 0.0401359
                Cubit_Inch = value * 69.3549
                Imperial_Quart = value

            ElseIf ValueScale = VolumeScale.Imperial_Tablespoon Then
                US_Liquid_Gallon = value * 0.00469121
                US_Liquid_Quart = value * 0.0187649
                US_Liquid_Pint = value * 0.0375297
                US_Legal_Cup = value * 0.0739924
                US_Fluid_Ounce = value * 0.600475
                US_Tablespoon = value * 1.20095
                US_Teaspoon = value * 3.60285
                Cubic_Metre = value * 0.000017758
                Litre = value * 0.0177582
                Mililitre = value * 17.7582
                Imperial_Gallon = value * 0.00390625
                Imperial_Quart = value * 0.015625
                Imperial_Pint = value * 0.0355163
                Imperial_Cup = value * 0.0625
                Imperial_Fluid_Ounce = value * 0.625
                Imperial_Teaspoon = value * 3
                Cubic_Foot = value * 0.000627124
                Cubit_Inch = value * 1.08367
                Imperial_Tablespoon = value

            ElseIf ValueScale = VolumeScale.Imperial_Teaspoon Then
                US_Liquid_Gallon = value * 0.00156374
                US_Liquid_Quart = value * 0.00625495
                US_Liquid_Pint = value * 0.0125099
                US_Legal_Cup = value * 0.0246641
                US_Fluid_Ounce = value * 0.200158
                US_Tablespoon = value * 0.400317
                US_Teaspoon = value * 1.20095
                Cubic_Metre = value * 0.0000059194
                Litre = value * 0.00591939
                Mililitre = value * 5.91939
                Imperial_Gallon = value * 0.00130208
                Imperial_Quart = value * 0.00520834
                Imperial_Pint = value * 0.0118388
                Imperial_Cup = value * 0.0208333
                Imperial_Fluid_Ounce = value * 0.208333
                Imperial_Tablespoon = value * 0.333333
                Cubic_Foot = value * 0.000209041
                Cubit_Inch = value * 0.361223
                Imperial_Teaspoon = value

            ElseIf ValueScale = VolumeScale.Litre Then
                US_Liquid_Gallon = value * 0.264172
                US_Liquid_Quart = value * 1.05669
                US_Liquid_Pint = value * 2.11338
                US_Legal_Cup = value * 4.16667
                US_Fluid_Ounce = value * 33.814
                US_Tablespoon = value * 67.628
                US_Teaspoon = value * 202.884
                Cubit_Inch = value * 61.0237
                Mililitre = value * 1000
                Imperial_Gallon = value * 0.219969
                Imperial_Quart = value * 0.879877
                Imperial_Pint = value * 2
                Imperial_Cup = value * 3.51951
                Imperial_Fluid_Ounce = value * 35.1951
                Imperial_Tablespoon = value * 56.3121
                Imperial_Teaspoon = value * 168.936
                Cubic_Foot = value * 0.0353147
                Cubit_Inch = value * 61.0237
                Litre = value

            ElseIf ValueScale = VolumeScale.Mililitre Then
                US_Liquid_Gallon = value * 0.000264172
                US_Liquid_Quart = value * 0.00105669
                US_Liquid_Pint = value * 0.00211338
                US_Legal_Cup = value * 0.00416667
                US_Fluid_Ounce = value * 0.033814
                US_Tablespoon = value * 0.067628
                US_Teaspoon = value * 0.202884
                Cubic_Metre = value * 0.000001
                Litre = value * 0.001
                Imperial_Gallon = value * 0.000219969
                Imperial_Quart = value * 0.000879877
                Imperial_Pint = value * 0.002
                Imperial_Cup = value * 0.00351951
                Imperial_Fluid_Ounce = value * 0.0351951
                Imperial_Tablespoon = value * 0.0563121
                Imperial_Teaspoon = value * 0.168936
                Cubic_Foot = value * 0.000035315
                Cubit_Inch = value * 0.0610237
                Mililitre = value

            ElseIf ValueScale = VolumeScale.US_Fluid_Ounce Then
                US_Liquid_Gallon = value * 0.0078125
                US_Liquid_Quart = value * 0.03125
                US_Liquid_Pint = value * 0.0625
                US_Legal_Cup = value * 0.123223
                US_Tablespoon = value * 2
                US_Teaspoon = value * 6
                Cubic_Metre = value * 0.000029574
                Litre = value * 0.0295735
                Mililitre = value * 29.5735
                Imperial_Gallon = value * 0.00650527
                Imperial_Quart = value * 0.0260211
                Imperial_Pint = value * 0.0591471
                Imperial_Cup = value * 0.104084
                Imperial_Fluid_Ounce = value * 1.04084
                Imperial_Tablespoon = value * 1.66535
                Imperial_Teaspoon = value * 4.99604
                Cubic_Foot = value * 0.00104438
                Cubit_Inch = value * 1.80469
                US_Fluid_Ounce = value

            ElseIf ValueScale = VolumeScale.US_Legal_Cup Then
                US_Liquid_Gallon = value * 0.0634013
                US_Liquid_Quart = value * 0.253605
                US_Liquid_Pint = value * 0.50721
                US_Fluid_Ounce = value * 8.11537
                US_Tablespoon = value * 16.2307
                US_Teaspoon = value * 48.6922
                Cubic_Metre = value * 0.00024
                Litre = value * 0.24
                Mililitre = value * 240
                Imperial_Quart = value * 0.21117
                Imperial_Gallon = value * 0.0527926
                Imperial_Pint = value * 0.48
                Imperial_Cup = value * 0.844682
                Imperial_Fluid_Ounce = value * 8.44682
                Imperial_Tablespoon = value * 13.5149
                Imperial_Teaspoon = value * 40.5447
                Cubic_Foot = value * 0.00847552
                Cubit_Inch = value * 14.6457
                US_Legal_Cup = value

            ElseIf ValueScale = VolumeScale.US_Liquid_Gallon Then
                US_Liquid_Quart = value * 4
                US_Liquid_Pint = value * 8
                US_Legal_Cup = value * 15.7725
                US_Fluid_Ounce = value * 128
                US_Tablespoon = value * 256
                US_Teaspoon = value * 768
                Cubic_Metre = value * 0.00378541
                Litre = value * 3.78541
                Mililitre = value * 3785.41
                Imperial_Quart = value * 3.3307
                Imperial_Gallon = value * 0.832674
                Imperial_Pint = value * 7.57082
                Imperial_Cup = value * 13.3228
                Imperial_Fluid_Ounce = value * 133.228
                Imperial_Tablespoon = value * 213.165
                Imperial_Teaspoon = value * 639.494
                Cubic_Foot = value * 0.133681
                Cubit_Inch = value * 231
                US_Liquid_Gallon = value

            ElseIf ValueScale = VolumeScale.US_Liquid_Pint Then
                US_Liquid_Gallon = value * 0.125
                US_Liquid_Quart = value * 0.5
                US_Legal_Cup = value * 1.97157
                US_Fluid_Ounce = value * 16
                US_Tablespoon = value * 32
                US_Teaspoon = value * 96
                Cubic_Metre = value * 0.000473176
                Litre = value * 0.473176
                Mililitre = value * 473.176
                Imperial_Quart = value * 0.416337
                Imperial_Gallon = value * 0.104084
                Imperial_Pint = value * 0.946353
                Imperial_Cup = value * 1.66535
                Imperial_Fluid_Ounce = value * 16.6535
                Imperial_Tablespoon = value * 26.6456
                Imperial_Teaspoon = value * 79.9367
                Cubic_Foot = value * 0.0167101
                Cubit_Inch = value * 28.875
                US_Liquid_Pint = value

            ElseIf ValueScale = VolumeScale.US_Liquid_Quart Then
                US_Liquid_Gallon = value * 0.25
                US_Liquid_Pint = value * 2
                US_Legal_Cup = value * 3.94314
                US_Fluid_Ounce = value * 32
                US_Tablespoon = value * 64
                US_Teaspoon = value * 192
                Cubic_Metre = value * 0.000946353
                Litre = value * 0.946353
                Mililitre = value * 946.353
                Imperial_Quart = value * 0.832674
                Imperial_Gallon = value * 0.208169
                Imperial_Pint = value * 1.89271
                Imperial_Cup = value * 3.3307
                Imperial_Fluid_Ounce = value * 33.307
                Imperial_Tablespoon = value * 53.2911
                Imperial_Teaspoon = value * 159.873
                Cubic_Foot = value * 0.0334201
                Cubit_Inch = value * 57.75
                US_Liquid_Quart = value

            ElseIf ValueScale = VolumeScale.US_Tablespoon Then
                US_Liquid_Gallon = value * 0.00390625
                US_Liquid_Quart = value * 0.015625
                US_Liquid_Pint = value * 0.03125
                US_Legal_Cup = value * 0.0616115
                US_Fluid_Ounce = value * 0.5
                US_Teaspoon = value * 3
                Cubic_Metre = value * 0.000014787
                Litre = value * 0.0147868
                Mililitre = value * 14.7868
                Imperial_Gallon = value * 0.00325263
                Imperial_Quart = value * 0.0130105
                Imperial_Pint = value * 0.0295735
                Imperial_Cup = value * 0.0520421
                Imperial_Fluid_Ounce = value * 0.520421
                Imperial_Tablespoon = value * 0.832674
                Imperial_Teaspoon = value * 2.49802
                Cubic_Foot = value * 0.00052219
                Cubit_Inch = value * 0.902344
                US_Tablespoon = value

            ElseIf ValueScale = VolumeScale.US_Teaspoon Then
                US_Liquid_Gallon = value * 0.00130208
                US_Liquid_Quart = value * 0.00520833
                US_Liquid_Pint = value * 0.0104167
                US_Legal_Cup = value * 0.0205372
                US_Fluid_Ounce = value * 0.166667
                US_Tablespoon = value * 3
                Cubic_Metre = value * 0.000014787
                Litre = value * 0.0147868
                Mililitre = value * 14.7868
                Imperial_Gallon = value * 0.00325263
                Imperial_Quart = value * 0.0130105
                Imperial_Pint = value * 0.0295735
                Imperial_Cup = value * 0.0520421
                Imperial_Fluid_Ounce = value * 0.520421
                Imperial_Tablespoon = value * 0.832674
                Imperial_Teaspoon = value * 2.49802
                Cubic_Foot = value * 0.00052219
                Cubit_Inch = value
                US_Teaspoon = value

            End If
        End Sub
    End Class
    Public Const YearToMs As Double = 31556952000
    Public Const MonthToMs As Double = 2629746000
    Public Const WeekToMs As Double = 604800000
    Public Const DayToMs As Double = 86400000
    Public Const HourToMs As Double = 3600000
    Public Const MinuteToMs As Double = 60000
    Public Const SeconsToMs As Double = 60

    Public SpeedLight As New Physical_Constant("c", "speed of light in a vacuum", 299792458, "m/s")
    Public GravitonalContant As New Physical_Constant("G", "gravitational constant", 6.67408 * 10 ^ -11, "Nm2/kg2")
    Public PlanckConstant As New Physical_Constant("h", "planck constant", 6.2607015 * 10 ^ -34, "JS")
    Public PlanckConstant1 As New Physical_Constant("h", "planck constant", 4.1356677 * 10 ^ -15, "eVs")

    Public BackBodyRadiation As New Physical_Constant("hc", "Back Body Radiation", 1.98644586 * 10 ^ -25, "Jm")
    Public BackBodyRadiation1 As New Physical_Constant("hc", "Back Body Radiation", 1239.841984, "eVnm")

    Public EarthGravity As New Physical_Constant("G", "gravitational constant", 9.80665, "m2/s")


#Region "<PHYSICS CONSTANTS>"
    Public Class Physical_Constant
        Public Symbol As String
        Public Name As String
        Public Value As Double
        Public Unit As String
        Public Sub New(ByVal Symb As String,
                       ByVal Nom As String,
                       ByVal Value As Double,
                       ByVal Unit As String)

        End Sub
    End Class
#End Region
End Module
