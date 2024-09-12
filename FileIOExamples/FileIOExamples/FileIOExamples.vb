Module FileIOExamples

    Sub Main()
        Dim firstNumber As Integer = 5
        Dim secondNumber As Integer = 5

        ' NumberThing(firstNumber, SecondNumber)

        'WriteToFile()
        ' AppendToFile()

        'ReadFromFile()

        DotNetExample()
        ReadFromFile()
        Console.Read()
    End Sub

    Sub WriteToFile()

        FileOpen(1, "myCrazyFile.txt", OpenMode.Output)
        Write(1, "Wake Up Neo...")
        FileClose(1)

    End Sub

    Sub AppendToFile()
        FileOpen(1, "myCrazyFile.txt", OpenMode.Append)
        Write(1, "Wake Up Neo...")
        WriteLine(1)
        WriteLine(1, "Knock Knock")
        WriteLine(1, "Follow The White Rabbit...")
        FileClose(1)

    End Sub

    Sub ReadFromFile()
        Dim currentRecord As String

        FileOpen(1, "..\..\TestFile.txt", OpenMode.Input)

        'For i = 1 To 50
        '    Input(1, currentRecord)
        '    Console.WriteLine(currentRecord)
        'Next
        Do Until EOF(1)
            Input(1, currentRecord)
            Console.WriteLine(currentRecord)
        Loop

        FileClose(1)

    End Sub


    Sub NumberThing(ByVal firstNumber As Integer, ByVal secondNumber As Integer)

        secondNumber += firstNumber

    End Sub

    Sub DotNetExample()
        'see: https://learn.microsoft.com/en-us/dotnet/api/microsoft.visualbasic.filesystem.write?view=netframework-4.7.2
        ' Open file for output.
        FileOpen(1, "..\..\TestFile.txt", OpenMode.Output)
        ' Print text to the file. The quotation marks will be in the display.
        Write(1, "This is a test.")
        ' Go to the next line.
        WriteLine(1)
        ' Skip a line.
        WriteLine(1)
        ' Print in two print zones. You will see commas and quotation marks
        ' in the output file.
        WriteLine(1, "Zone 1", SPC(10), "Zone 2")
        ' Build a longer string before calling WriteLine.
        WriteLine(1, "Hello" & "  " & "World")
        ' Include five leading spaces.
        WriteLine(1, SPC(5), "Leading spaces")
        ' Print a word starting at column 10.
        WriteLine(1, TAB(10), "Hello")

        ' Assign Boolean and Date values.
        Dim aBool As Boolean
        Dim aDate As DateTime
        aBool = False
        aDate = DateTime.Parse("February 12, 1969")

        ' Dates and Booleans are translated using locale settings of 
        ' your system.
        WriteLine(1, aBool & " is a Boolean value.")
        WriteLine(1, aDate & " is a date.")
        WriteLine(1, aBool)
        WriteLine(1, aDate)
        WriteLine(1, 77)
        WriteLine(1)
        Write(1, 1)
        Write(1, 2)
        Write(1, 3.456)
        ' Close the file.
        FileClose(1)

        ' Contents of TestFile.txt
        '"This is a test.",
        '
        '"Zone 1",          "Zone 2"
        '"Hello  World"
        '     "Leading spaces"
        '         ,"Hello"
        '"False is a Boolean value."
        '"2/12/1969 is a date."
    End Sub
End Module
