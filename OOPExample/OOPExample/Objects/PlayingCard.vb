Option Strict On
Option Explicit On

Namespace CardGame
    Public Class PlayingCard

        Private _suit As Integer
        Public ReadOnly Property Suit As Integer
            Get
                Return _suit
            End Get
        End Property

        Private _value As Integer
        Public ReadOnly Property Value As Integer
            Get
                Return _value
            End Get
        End Property

        Sub New(suit As Integer, value As Integer)

            Me._suit = suit
            Me._value = value

        End Sub

    End Class

End Namespace
