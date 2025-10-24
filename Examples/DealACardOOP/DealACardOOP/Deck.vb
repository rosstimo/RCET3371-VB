Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar

Public Class Deck
    Private _deck As New Stack(Of Card) 'TODO try queue to see if a more efficient shuffle is possible with insert

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
        Dim counter%
        Dim tracker As New List(Of String)

        Do Until Me.CardsRemaining >= 52
            _rank = GetRank(GetRandomInRange(13))
            _suit = GetSuit(GetRandomInRange(4))

            If Not (tracker.Contains(_rank & _suit)) Then
                Dim newCard As New Card(_rank, _suit)
                Me._deck.Push(newCard)
                tracker.Add(_rank & _suit)
            End If
            counter += 1
        Loop
        ' MsgBox(counter)
    End Sub

    ''' <summary>
    ''' Determines suit string from integer range 1 - 4. <br></br>
    ''' 1 = spade <br></br>
    ''' 2 = hearts <br></br>
    ''' 3 = clubs <br></br>
    ''' 4 = diamonds <br></br>
    ''' all others invalid will return x
    ''' </summary>
    ''' <param name="suit"></param>
    ''' <returns>String</returns>
    Private Function GetSuit(suit As Integer) As String
        Dim _suit$
        Select Case suit
            Case 1
                _suit = "s"
            Case 2
                _suit = "h"
            Case 3
                _suit = "c"
            Case 4
                _suit = "d"
            Case Else
                _suit = "x"
        End Select
        Return _suit
    End Function

    ''' <summary>
    ''' Determines rank string from integer range 1 - 13. <br></br>
    ''' 1 = ace <br></br>
    ''' 2 - 10 = numeric value <br></br>
    ''' 11 = jack <br></br>
    ''' 12 = queen <br></br>
    ''' 13 = king <br></br>
    ''' all others invalid will return x
    ''' </summary>
    ''' <param name="rank"></param>
    ''' <returns>String</returns>
    Private Function GetRank(rank As Integer) As String
        Dim _rank$
        Select Case rank
            Case 1
                _rank = "a"
            Case 2 To 10
                _rank = rank.ToString
            Case 11
                _rank = "j"
            Case 12
                _rank = "q"
            Case 13
                _rank = "k"
            Case Else
                _rank = "x"
        End Select
        Return _rank
    End Function



    Private Function GetRandomInRange(max As Integer, Optional min As Integer = 1)
        Randomize()
        Return System.Math.Floor(Rnd() * max) + min
    End Function

    Sub CardsInOrder()
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
