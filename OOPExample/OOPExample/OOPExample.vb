Option Strict On
Option Explicit On
Imports System.Windows.Forms
Imports OOPExample.CardGame

Module OOPExample

    Sub Main()
        'TestingClass.SomeSub()
        Tim.TestingClass.SomeSub()
        CircuitSolver.SeriesCircuit.SolveSeriesCircuit()
        CircuitSolver.ParallelSolver.SolveParallelCircuit()

        Console.WriteLine(Libs.UsefullStuffLib.LuckyNumber)

        Dim Deck As New CardGame.DeckOfCards("Bill")
        Dim DeckTwo As New CardGame.DeckOfCards("Frank")
        Dim OtherDeck As New CardGame.DeckOfCards("Mary")
        Dim currentCard As PlayingCard

        Console.WriteLine(Deck.Name)
        Console.WriteLine(DeckTwo.Name)
        Console.WriteLine(OtherDeck.Name)

        '
        'Deck.testDeal()

        Deck.Shuffle()

        For i = 1 To 53
            'Console.WriteLine(Deck.GetRemaining())
            'Console.WriteLine($"")
            currentCard = Deck.Deal()
            If currentCard IsNot Nothing Then
                Console.WriteLine(currentCard.PrettyName)
            End If
        Next


        'If currentCard IsNot Nothing Then

        '    Console.WriteLine(Deck.Deal())
        '    Console.WriteLine(Deck.Deal().PrettyName)
        'End If




    End Sub

End Module
