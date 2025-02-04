Public Class GraphicsForm
    Sub SetDefaults()
        'TODO
    End Sub

    Sub DrawLine()
        Dim g As Graphics = DrawPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Black)
        Dim scaleX!, scaleY!, deltaX!, deltaY!

        scaleX = CSng(DrawPictureBox.Width / 100)
        scaleY = CSng(DrawPictureBox.Height / 100) * -1

        deltaX = 0
        deltaY = CSng(DrawPictureBox.Height() / 2)

        g.TranslateTransform(deltaX, deltaY)
        g.ScaleTransform(scaleX, scaleY)


        g.DrawLine(pen, 5, 0, 95, 95)


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
        DrawLine()
    End Sub


End Class
