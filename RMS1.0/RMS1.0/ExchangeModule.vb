Module ExchangeModule
    Public Function usdToCrc(dolares As Integer) As Decimal
        Dim change = 606.07
        Dim colones As Decimal = dolares * change
        Return colones
    End Function

    Public Function crcToUsd(colones As Integer) As Decimal
        Dim change = 606.07
        Dim dolares As Decimal = colones / change
        Return dolares
    End Function

    Public Function euroToCrc(euros As Integer) As Decimal
        Dim change = 686.93
        Dim colones As Decimal = euros * change
        Return colones
    End Function

    Public Function crcToEuro(colones As Integer) As Decimal
        Dim change = 686.93
        Dim euros As Decimal = colones / change
        Return euros
    End Function



End Module
