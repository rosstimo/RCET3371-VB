Public Class MainForm
    Private Sub MainForm_Click(sender As Object, e As EventArgs) Handles Me.Click
        Dim ah As New Card("W", "H")
        'Dim cardName As String = "_AS"
        'Dim cardImage As Image = My.Resources.ResourceManager.GetObject(cardName) ' My.Resources._AS
        Dim g As Graphics = Me.CreateGraphics



        g.DrawImage(ah.backImage, 10, 10)
        g.DrawImage(ah.frontImage, 100, 100)

        g.Dispose()
    End Sub

End Class
