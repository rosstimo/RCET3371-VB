Public Class GraphicsForm
    Sub SetDefaults()
        'TODO
    End Sub

    Sub DrawLine(oldX%, oldY%, x%, y%)
        Dim g As Graphics = DrawPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Black)

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
        End If

        oldX = e.X
        oldY = e.Y

    End Sub
End Class
