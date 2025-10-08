Public Class GraphicsForm
    Sub SetDefaults()
        DrawingPictureBox.BackColor = Color.BlanchedAlmond
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

    Sub DrawLineOnPictureBox()
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
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
        'DrawLineOnForm()
        DrawLineOnPictureBox()
    End Sub

    Private Sub GraphicsForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetDefaults()
    End Sub

    Private Sub DrawingPictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseMove
        CoordsStatusLabel.Text = $"({e.X},{e.Y})"
    End Sub
End Class
