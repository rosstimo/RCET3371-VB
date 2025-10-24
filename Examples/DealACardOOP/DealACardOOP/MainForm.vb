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
        Dim offset% = 50

        For row = 1 To 4
            For column = 1 To 13
                g.DrawImage(theDeck.DealCard.frontImage, column * offset, row * offset * 2)
                Me.Text = theDeck.CardsRemaining

            Next
        Next

        g.Dispose()
    End Sub

    Private Sub ShuffleButton_Click(sender As Object, e As EventArgs) Handles ShuffleButton.Click
        Me.theDeck.Shuffle()
    End Sub
End Class
