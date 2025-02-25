Option Strict On
Option Explicit On
Imports System.Net.NetworkInformation
Imports System.Runtime.InteropServices

Namespace CardGame

    Public Class DeckOfCards
        'properties
        Private _name As String
        ''' <summary>
        ''' A friendly name for your deck of cards.
        ''' </summary>
        ''' <returns>Bill</returns>
        Public Property Name() As String
            Get
                Return _name
            End Get
            Set(ByVal value As String)
                _name = value
            End Set
        End Property


        'fields (variables/Constants)

        Private _deck As New Stack(Of PlayingCard)

        Sub New(name As String)
            Me.Name = name
            Shuffle()
        End Sub

        'other methods

        ''' <summary>
        ''' Get the number of cards not yet dealt in the deck.
        ''' </summary>
        ''' <returns>Cards Remaining</returns>
        Public Function GetRemaining() As Integer
            Return Me._deck.Count
        End Function

        Public Sub Shuffle()
            'Dim count As Integer
            Dim suit%, value%
            Dim card As PlayingCard ' Object

            Me._deck.Clear()

            Do
                suit = RandomNumber(4)
                value = RandomNumber(13)
                card = New PlayingCard(suit, value)
                'Console.WriteLine(card.GetHashCode)
                'If Me._deck.Contains(card) = False Then
                If CardExists(card) = False Then
                    Me._deck.Push(card)
                    'count += 1
                    'Console.WriteLine(Me._deck.Count)
                End If

            Loop Until Me._deck.count >= 52

            Console.WriteLine()
        End Sub

        Private Function CardExists(newCard As PlayingCard) As Boolean

            For Each card In Me._deck
                If newCard.Suit = card.Suit And newCard.Value = card.Value Then
                    Return True
                End If
            Next

            Return False
        End Function

        ''' <summary>
        ''' Deal the next card
        ''' </summary>
        ''' <returns>
        ''' Returns next card or Nothing if there are no card remaining
        ''' </returns>
        Public Function Deal() As PlayingCard
            If Me._deck.Count > 0 Then
                Return Me._deck.Pop
            Else
                Return Nothing
            End If
        End Function

        Public Sub testDeal()
            Dim card As PlayingCard
            Dim count As Integer

            Do
                count += 1
                card = Me._deck.Pop()
                Console.WriteLine($"The {count} card is suit:{card.Suit} value:{card.Value}")
            Loop Until Me._deck.Count = 0
        End Sub

        Private Function RandomNumber(max As Integer) As Integer
            Randomize()
            Return CInt(Math.Floor(Rnd() * max)) + 1
        End Function

    End Class

End Namespace
