Public Class MainForm
    Dim theDeck As New Deck 'put this in GameLogic Class

    Private Sub MainForm_Click(sender As Object, e As EventArgs) Handles Me.Click
        'Dim ah As New Card("a", "h")
        'Dim twoS As New Card("q", "h")
        'Dim cardName As String = "_AS"
        'Dim cardImage As Image = My.Resources.ResourceManager.GetObject(cardName) ' My.Resources._AS
        'Dim theDeck As New Deck
        'Dim currentCard As New Card
        Dim g As Graphics = Me.CreateGraphics



        ' g.DrawImage(, 10, 10)
        g.DrawImage(theDeck.DealCard.frontImage, 100, 100)
        'g.DrawImage(theDeck.DealCard.frontImage, 125, 125)
        'g.DrawImage(theDeck.DealCard.frontImage, 150, 150)
        'g.DrawImage(theDeck.DealCard.frontImage, 175, 175)
        'g.DrawImage(twoS.frontImage, 150, 150)
        Me.Text = theDeck.CardsRemaining

        g.Dispose()
    End Sub

End Class
