Imports System.Runtime.InteropServices
Imports System.Runtime.InteropServices.WindowsRuntime

Public Class ACCircuitForm
    Private Sub ACCircuitForm_Click(sender As Object, e As EventArgs) Handles Me.Click
        'SeriesResistance()
        ' MsgBox(EngineeringNotationOf(222222))
        For i = -15 To 12 Step 3
            Console.WriteLine($"{i} is prefix: {ExponentToMetricPrefix(CStr(i))}")
        Next
    End Sub


    ''' <summary>
    ''' returns the sum of two series resistances
    ''' </summary>
    ''' <param name="r1"></param>
    ''' <param name="r2"></param>
    ''' <returns></returns>
    Function SeriesResistance(r1 As Decimal, r2 As Decimal) As Decimal
        Return r1 + r2
    End Function

    Function ParallelResistance(r1 As Decimal, r2 As Decimal) As Decimal
        Return CDec((r1 ^ -1 + r2 ^ -1) ^ -1)
    End Function

    Function EngineeringNotationOf(value#) As String
        Dim temp() As String
        Dim mantissa#, exponent#

        temp = Split(value.ToString("e"), "e")
        mantissa = CDbl(temp(0))
        exponent = CDbl(temp(1))

        Do While exponent Mod 3 <> 0

            Console.WriteLine($"The Mantissa is: {mantissa}")
            Console.WriteLine($"The Exponent isL {exponent}")
            Console.WriteLine()

            Console.WriteLine($"exponent modulus 3 is :{exponent Mod 3}")
            Console.WriteLine()
            exponent -= 1
            mantissa *= 10

        Loop

        Console.WriteLine($"{mantissa}x10^{exponent}")

        Return $"{mantissa}e{exponent}"
    End Function


    Function ExponentToMetricPrefix(exponent$) As String
        Dim prefix$
        Select Case exponent
            Case "9"
                prefix = "G"
            Case "6"
                prefix = "M"
            Case "3"
                prefix = "k"
            Case "0"
                prefix = ""
            Case "-3"
                prefix = "m"
            Case "-6"
                prefix = "u"
            Case "-9"
                prefix = "n"
            Case "-12"
                prefix = "p"
            Case Else
                prefix = $"e{exponent}"
        End Select
        Return prefix
    End Function

End Class
