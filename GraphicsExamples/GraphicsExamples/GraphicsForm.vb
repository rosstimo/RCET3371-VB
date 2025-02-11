Option Explicit On
Option Strict On
Imports System.CodeDom.Compiler

Public Class GraphicsForm
    Sub SetDefaults()
        'TODO
    End Sub

    'TODO
    '[ ] log each drawing segment to a sequential file
    '[ ] make file records look like:
    ' <startX>, <startY>, <endX>, <endY>, <color>, <time stamp to millisecond>
    ' 0,104,236,205,"Black", "20250203094534123"
    ' 0,104,236,205,"Black", "20250203094534123"

    Sub LogToFile(startX%, startY%, endX%, endY%)

        FileOpen(1, $"lines-{ DateTime.Now.ToString("yyMMddhh")}.log", OpenMode.Append)

        Write(1, DateTime.Now.ToString("yy:MM:dd:hh:mm:ss:fff"))
        Write(1, startX)
        Write(1, startY)
        Write(1, endX)
        Write(1, endY)
        Write(1, Color.Black.ToString) 'TODO: get actual color here
        WriteLine(1)

        FileClose(1)
    End Sub

    Function ShiftArray(y%, Optional shift As Boolean = False) As Integer()
        Static graphY(DrawPictureBox.Width) As Integer

        If shift Then
            For x = LBound(graphY) To UBound(graphY) - 1
                graphY(x) = graphY(x + 1)
            Next

            graphY(UBound(graphY)) = y
        End If

        Return graphY
    End Function

    Sub PlotArray()
        Dim temp() = ShiftArray(0)
        DrawPictureBox.Refresh()

        For x = LBound(temp) To UBound(temp) - 1
            'in back color drawline x+1 from top to bottom
            DrawLine(x, temp(x), x + 1, temp(x + 1))
        Next

    End Sub

    Sub DrawLine(oldX%, oldY%, x%, y%)
        Dim g As Graphics = DrawPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Lime)

        'Dim scaleX!, scaleY!, deltaX!, deltaY!

        'scaleX = CSng(DrawPictureBox.Width / 100)
        'scaleY = CSng(DrawPictureBox.Height / 100) * -1

        'deltaX = 0
        'deltaY = CSng(DrawPictureBox.Height() / 2)

        'g.TranslateTransform(deltaX, deltaY)
        'g.ScaleTransform(scaleX, scaleY)


        g.DrawLine(pen, oldX, oldY, x, y)



        g.Dispose()
        pen.Dispose()

    End Sub

    ' Event Handlers Below Here ***********************************************
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SetDefaults()
    End Sub

    Private Sub DrawButton_Click(sender As Object, e As EventArgs) Handles DrawButton.Click

    End Sub

    Private Sub DrawPictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawPictureBox.MouseMove
        Static oldX%, oldY%
        CoordinatesStatusLabel.Text = $"({e.X.ToString.PadLeft(5)},{e.Y.ToString.PadLeft(5)})"

        If e.Button = MouseButtons.Left Then
            DrawLine(oldX, oldY, e.X, e.Y)
            'log to file
            LogToFile(oldX, oldY, e.X, e.Y)
        End If
        'send new data to array
        ShiftArray(e.Y, True)


        oldX = e.X
        oldY = e.Y

    End Sub

    Private Sub PlotTimer_Tick(sender As Object, e As EventArgs) Handles PlotTimer.Tick
        PlotArray()
    End Sub
End Class
