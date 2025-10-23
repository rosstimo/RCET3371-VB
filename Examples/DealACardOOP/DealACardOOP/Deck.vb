Public Class Deck
    Private _deck As New Stack(Of Card)

    Sub test()
        Dim ah As New Card("a", "h")
        Dim ac As New Card("a", "c")
        Dim ad As New Card("a", "d")
        Dim asp As New Card("a", "s")
        Me._deck.Push(ah)
        Me._deck.Push(ac)
        Me._deck.Push(ad)
        Me._deck.Push(asp)

    End Sub

    Sub Shuffle()

    End Sub

    ''' <summary>
    ''' Deals on card off the top of the deck
    ''' </summary>
    ''' <returns>Card</returns>
    Function DealCard() As Card
        Return _deck.Pop
    End Function

    ''' <summary>
    ''' Returns the number of cards remaining in the deck
    ''' </summary>
    ''' <returns>Integer</returns>
    Function CardsRemaining() As Integer
        Return _deck.Count
    End Function

    Sub New()
        test()
    End Sub

End Class
