
Public Class ShiftingArraysForm

    Function MouseY(Optional currentY As Integer = -1) As Integer
        Static _mouseY As Integer

        If currentY <> -1 Then
            _mouseY = currentY
        End If

        Return _mouseY

    End Function
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


    'Event Handlers Below -----------------------------------------------------------
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Dim temp() As Integer
        'temp = ShiftArray(RandomNumberFrom(50, 100))
        temp = ShiftArray(MouseY())
        PlotPictureBox.Refresh()
        'PlotPictureBox.Image = Nothing
        Plot(temp)
    End Sub

    Private Sub PlotPictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles PlotPictureBox.MouseMove
        MouseY(e.Y)
    End Sub
End Class
