Option Strict On
Option Explicit On
Public Class DataForm

    'Program Logic ------------------------------------------------------------
    Function GetRandomNumberAround(thisNumber%, Optional within% = 10) As Integer
        Dim result%
        result = thisNumber - within
        result += GetRandomNumber(within) + GetRandomNumber(within)
        Return result
    End Function

    Function GetRandomNumber(max%) As Integer
        Randomize()
        Return CInt(System.Math.Floor((Rnd() * (max + 1))))
    End Function

    Function GetData() As Integer
        Return 5
    End Function

    Sub GraphData()
        Dim g As Graphics = GraphPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Lime)
        Dim scaleX As Single = CSng(GraphPictureBox.Width / 100)
        Dim scaleY As Single = CSng((GraphPictureBox.Height / 100) * -1)

        g.TranslateTransform(0, GraphPictureBox.Height)
        g.ScaleTransform(scaleX, scaleY)


        pen.Width = 0.25
        g.DrawLine(pen, 5, 50, 95, 50)

        g.Dispose()
        pen.Dispose()

    End Sub

    'Event Handlers -----------------------------------------------------------
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()

    End Sub

    Private Sub GraphButton_Click(sender As Object, e As EventArgs) Handles GraphButton.Click
        'GraphData()
        For i = 1 To 100
            Console.WriteLine(GetRandomNumberAround(50, 50))
        Next
    End Sub
End Class
