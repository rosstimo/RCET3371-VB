Option Strict On
Option Explicit On

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

        Console.WriteLine(Deck.Name)
        Console.WriteLine(DeckTwo.Name)
        Console.WriteLine(OtherDeck.Name)

        '
        'Deck.testDeal()

        Deck.Shuffle()

        For i = 1 To 52
            'Console.WriteLine(Deck.GetRemaining())
            'Console.WriteLine($"")
            Console.WriteLine(Deck.Deal().PrettyName)
        Next


    End Sub

End Module
