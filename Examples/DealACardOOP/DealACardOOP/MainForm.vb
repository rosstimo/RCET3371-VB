Public Class MainForm
    Dim theDeck As New Deck 'put this in GameLogic Class


    Private Sub MainForm_Click(sender As Object, e As EventArgs) Handles Me.Click

        Dim g As Graphics = Me.CreateGraphics
        Dim rectangle As New Rectangle(0, 0, 150, 250)

        'g.ScaleTransform

        Dim offset% = 50

        'For row = 1 To 4
        'For column = 1 To 13
        'g.DrawImage(theDeck.DealCard.frontImage, column * offset, row * offset * 2)
        'draw the back of the card then the front of the card the same specific height of 300 pixels 

        Dim dealtCard As Card = theDeck.DealCard()
                g.Transform = New Drawing2D.Matrix()
        'g.TranslateTransform(column * offset, row * offset * 2)
        ' g.PageUnit = GraphicsUnit.Inch
        g.DrawImage(dealtCard.backImage, rectangle)
        g.TranslateTransform(offset, offset)
        g.DrawImage(dealtCard.frontImage, rectangle)


        Me.Text = theDeck.CardsRemaining

        '   Next
        ' Next

        g.Dispose()
    End Sub

    Private Sub ShuffleButton_Click(sender As Object, e As EventArgs) Handles ShuffleButton.Click
        Me.theDeck.Shuffle()
    End Sub
End Class
