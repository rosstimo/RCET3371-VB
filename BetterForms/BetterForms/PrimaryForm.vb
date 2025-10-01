Public Class PrimaryForm
    Private Sub PrimaryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TrackBar1.TickFrequency = 5
    End Sub

    Private Sub TrackBar1_ValueChanged(sender As Object, e As EventArgs) Handles TrackBar1.ValueChanged
        ToolStripStatusLabel1.Text = TrackBar1.Value.ToString
        ProgressBar1.Value = TrackBar1.Value
    End Sub
End Class
