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
        Dim _suit$, _rank$

        For suit = 1 To 4

            Select Case suit
                Case 1
                    _suit = "s"
                Case 2
                    _suit = "h"
                Case 3
                    _suit = "c"
                Case 4
                    _suit = "d"
            End Select

            For rank = 1 To 13
                Select Case rank
                    Case 1
                        _rank = "a"
                    Case 1 To 10
                        _rank = rank.ToString
                    Case 11
                        _rank = "j"
                    Case 12
                        _rank = "q"
                    Case 13
                        _rank = "k"
                End Select

                Dim newCard As New Card(_rank, _suit)

                If Not (Me._deck.Contains(newCard)) Then
                    Me._deck.Push(newCard)
                End If

            Next
        Next


    End Sub

    ''' <summary>
    ''' Deals on card off the top of the deck
    ''' </summary>
    ''' <returns>Card</returns>
    Function DealCard() As Card
        Try
            Return _deck.Pop
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Returns the number of cards remaining in the deck
    ''' </summary>
    ''' <returns>Integer</returns>
    Function CardsRemaining() As Integer
        Return _deck.Count
    End Function

    Sub New()
        'test()
        Shuffle()
    End Sub

End Class
