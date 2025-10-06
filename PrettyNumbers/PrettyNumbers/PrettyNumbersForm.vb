Imports System.CodeDom.Compiler

Public Class PrettyNumbersForm


    Private Function EngineeringNotation(value As Decimal, fix As Integer) As String
        Dim valueString$
        Dim valueSplit() As String
        Dim mantissa@, exponent%

        'valueString = value.ToString("0.0000000000000E+00")
        valueString = value.ToString("E")
        valueSplit = Split(valueString, "E")

        mantissa = CDec(valueSplit(0))
        exponent = CInt(valueSplit(1))

        Do Until exponent Mod 3 = 0
            mantissa *= 10
            exponent -= 1
        Loop

        'valueString.PadLeft(5)

        Return $"{mantissa.ToString.Remove(fix + 1)}E{exponent}"
    End Function

    ''' <summary>
    ''' Convert Engineering Notation into pretty numbers with metric prefix
    ''' </summary>
    ''' <returns></returns>
    Private Function Pretty(engineeringNotation As String) As String
        Dim temp() As String

        temp = Split(engineeringNotation, "E")
        Select Case temp(1)
            Case "9"
                temp(1) = "G"
            Case "6"
                temp(1) = "M"
            Case "3"
                temp(1) = "k"
            Case "0"
                temp(1) = ""
            Case "-3"
                temp(1) = "m"
            Case "-6"
                temp(1) = ChrW(&HB5)
            Case "-9"
                temp(1) = "n"
            Case "-12"
                temp(1) = "p"
            Case Else
                'pass
                MsgBox("BUG: Edge Case")
        End Select
        Return $"{temp(0)}{temp(1)}"
    End Function

    Sub Display(displayValue As String)
        DisplayStatusLabel.Text = displayValue
    End Sub
    'Event Handlers -----------------------------------------------------------
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        If InputTextBox.Text <> "" And IsNumeric(InputTextBox.Text) Then
            'get text from textbox1 and format in scientific notation using ToString method
            'Display(CDec(InputTextBox.Text).ToString("0.0000E+00"))
            Display(Pretty(EngineeringNotation(InputTextBox.Text, 6)))


        End If
    End Sub


End Class
