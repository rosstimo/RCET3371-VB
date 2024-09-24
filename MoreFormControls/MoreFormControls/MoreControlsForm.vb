Public Class MoreControlsForm
    Private Sub MoreControlsForm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        PositionStatusLabel.Text = $"({e.X},{e.Y})"
    End Sub

    Private Sub MoreControlsForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Text = "Very Proffesional Title"
    End Sub
End Class
