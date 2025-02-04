Module Spring2025

    Sub Main()

        'Arrays are cool

        Dim pigeons(5, 1) As Integer

        'pigeon sighting 1
        pigeons(0, 0) = 32 'x coordinate
        pigeons(0, 1) = 75 'y coordinate

        'pigeon sighting 2
        pigeons(1, 0) = 37 'x coordinate
        pigeons(1, 1) = 64 'y coordinate

        'pigeon sighting 3
        pigeons(2, 0) = 28 'x coordinate
        pigeons(2, 1) = 78 'y coordinate

        'pigeon sighting 4
        pigeons(3, 0) = 38 'x coordinate
        pigeons(3, 1) = 82 'y coordinate

        'pigeon sighting 5
        pigeons(4, 0) = 33 'x coordinate
        pigeons(4, 1) = 81 'y coordinate

        'pigeon sighting 6
        pigeons(5, 0) = 31 'x coor76nate
        pigeons(5, 1) = 75 'y coordinate

        ''prints number of the first dimension
        'For i = LBound(pigeons) To UBound(pigeons)
        '    Console.WriteLine(i)
        'Next

        'pigeons.GetLowerBound(0)
        'Console.WriteLine(pigeons.GetUpperBound(0))
        'pigeons.GetLowerBound(1)
        'Console.WriteLine(pigeons.GetUpperBound(1))

        For row = pigeons.GetLowerBound(0) To pigeons.GetUpperBound(0)
            For column = pigeons.GetLowerBound(1) To pigeons.GetUpperBound(1)
                Console.Write(CStr(pigeons(row, column)).PadRight(4))
            Next
            Console.WriteLine()
        Next

        Console.WriteLine()

        For Each coordinate In pigeons
            Console.WriteLine(coordinate)
        Next

        Console.Read()
    End Sub

End Module
