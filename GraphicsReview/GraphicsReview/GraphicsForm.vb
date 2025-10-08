Public Class GraphicsForm
    Sub SetDefaults()

    End Sub

    Sub DrawLineOnForm()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.Black)

        g.DrawLine(pen, 0, 0, 100, 100)
        pen.Width = 5
        g.DrawLine(pen, 100, 100, 150, 100)

        pen.Dispose()
        g.Dispose()

    End Sub

    'Event Handlers -----------------------------------------------------------
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SetDefaults()
    End Sub

    Private Sub GraphicsForm_Click(sender As Object, e As EventArgs) Handles Me.Click
        DrawLineOnForm()
    End Sub


End Class
