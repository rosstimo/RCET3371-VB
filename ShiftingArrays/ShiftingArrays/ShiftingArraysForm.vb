Public Class ShiftingArraysForm
    Private Sub ShiftingArraysForm_Click(sender As Object, e As EventArgs) Handles Me.Click
        Dim temp() As Integer
        temp = ShiftArray(RandomNumberFrom(50, 100))
        PlotPictureBox.Refresh()
        Plot(temp)

        ' Console.Read()
    End Sub

    Function ShiftArray(newData As Integer) As Integer()
        Static data(99) As Integer

        For i = LBound(data) To UBound(data) - 1
            data(i) = data(i + 1)
        Next

        data(UBound(data)) = newData

        Return data
    End Function

    Sub Plot(plotData() As Integer)
        Dim g As Graphics = PlotPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Black)
        Dim oldX%, oldY%
        g.ScaleTransform(CSng(PlotPictureBox.Width / 100), 1)
        For x = 0 To UBound(plotData)
            g.DrawLine(pen, oldX, oldY, x, plotData(x))
            oldX = x
            oldY = plotData(x)
        Next

    End Sub

    Sub TestRandomness()
        Dim randomness(10) As Integer

        For i = 1 To 100000
            randomness(RandomNumberFrom(0, 10)) += 1
        Next

        'Console.Clear()

        For i = LBound(randomness) To UBound(randomness)
            Console.Write(CStr(randomness(i)).PadLeft(6) & " |")
        Next

        Console.WriteLine()

    End Sub

    ''' <summary>
    ''' returns an integer from min to max inclusive.
    ''' <br/>
    ''' defaults:
    ''' <br/>
    ''' min = 0
    ''' <br/>
    ''' max = 10
    ''' </summary>
    ''' <param name="min%"></param>
    ''' <param name="max%"></param>
    ''' <returns></returns>
    Function RandomNumberFrom(Optional min% = 0, Optional max% = 10) As Integer
        Dim _random%
        Randomize(DateTime.Now.Millisecond)
        _random = CInt(Math.Floor(Rnd() * (max + 1 - min))) + min
        Return _random
    End Function

End Class
