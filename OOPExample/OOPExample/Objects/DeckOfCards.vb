Option Strict On
Option Explicit On
Imports System.Net.NetworkInformation
Imports System.Runtime.InteropServices

Namespace CardGame

    Public Class DeckOfCards
        'properties
        Private _name As String
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

        Public Sub Shuffle()
            Dim count As Integer
            Dim suit%, value%
            Dim card As PlayingCard ' Object

            Me._deck.Clear()

            Do
                suit = RandomNumber(4)
                value = RandomNumber(13)
                card = New PlayingCard(suit, value)

                If Me._deck.Contains(card) = False Then
                    Me._deck.Push(card)
                    count += 1
                End If

            Loop Until count >= 52

            Console.WriteLine()
        End Sub

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
