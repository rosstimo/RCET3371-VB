Option Strict On
Option Explicit On

Namespace CardGame
    Public Class PlayingCard

        Private _suit As Integer
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
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

        Public Function PrettyName() As String
            Return $"{PrettyValue()} of {PrettySuit()}"
        End Function

        Public Function PrettySuit() As String
            Dim _suit As String

            Select Case Me.Suit
                Case 1
                    _suit = "Spades"
                Case 2
                    _suit = "Diamonds"
                Case 3
                    _suit = "Clubs"
                Case 4
                    _suit = "Hearts"
            End Select

            Return _suit
        End Function

        Public Function PrettyValue() As String
            Dim _value As String

            Select Case Me.Value
                Case 1
                    _value = "Ace"
                Case 11
                    _value = "Jack"
                Case 12
                    _value = "Queen"
                Case 13
                    _value = "King"
                Case Else
                    _value = CStr(Me.Value)
            End Select

            Return _value
        End Function

    End Class

End Namespace
