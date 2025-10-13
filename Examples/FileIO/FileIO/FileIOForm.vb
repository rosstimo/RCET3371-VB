Public Class FileIOForm

    Sub DotNetExample()
        'see: https://learn.microsoft.com/en-us/dotnet/api/microsoft.visualbasic.filesystem.write?view=netframework-4.7.2#microsoft-visualbasic-filesystem-write(system-int32-system-object())
        ' Open file for output.
        FileOpen(1, "TestFile.txt", OpenMode.Output)
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
        Write(1, aBool)
        Write(1, aDate)
        Write(1, 55)
        Write(1, 0.0007268346)
        WriteLine(1, aBool & " is a Boolean value.")
        WriteLine(1, aDate & " is a date.")
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
    Sub WriteToFile()
        Dim path As String = "TestFile.txt"

        FileOpen(1, path, OpenMode.Output)
        Write(1, "Wake Up Neo....")
        'WriteLine(1, "Wake Up Neo....")
        FileClose(1)

    End Sub
    Sub AppendToFile()
        Dim path As String = "TestFile.txt"

        FileOpen(1, path, OpenMode.Append)
        Write(1, "Follow The White Rabbit....")
        'WriteLine(1, "Follow The White Rabbit....")
        FileClose(1)

    End Sub
    Sub ReadRecordsFromFile()
        Dim path As String = "TestFile.txt"
        Dim currentRecord As String

        FileOpen(1, path, OpenMode.Input)

        'assign record date to ByRef arg
        'Input(1, currentRecord)
        'Console.WriteLine(currentRecord)

        'For i = 1 To 11
        '    Input(1, currentRecord)
        '    Console.WriteLine($"Record Number {i} is {currentRecord}")
        'Next

        Do Until EOF(1)
            Input(1, currentRecord)
            Console.WriteLine(currentRecord)
        Loop



        FileClose(1)

    End Sub

    Sub LogEvent(firstNumber%, secondNumber%)
        Dim path As String = "event.log"

        FileOpen(1, path, OpenMode.Append)
        Write(1, firstNumber)
        Write(1, secondNumber)
        WriteLine(1, DateTime.Now)
        FileClose(1)

    End Sub

    Sub ReadEvent()
        Dim path As String = "event.log"
        Dim firstNumber%, secondNumber
        Dim timeStamp As Date


        FileOpen(1, path, OpenMode.Input)

        Do Until EOF(1)
            Input(1, firstNumber)
            Input(1, secondNumber)
            Input(1, timeStamp)
            Console.WriteLine($"X:{firstNumber} Y:{secondNumber} at {timeStamp.ToString("yyMMddHH")}")
        Loop
        FileClose(1)
    End Sub

    'Event Handlers -----------------------------------------------------------
    Private Sub FileIOForm_Click(sender As Object, e As EventArgs) Handles Me.Click
        'WriteToFile()
        'For i = 0 To 10
        '    AppendToFile()
        'Next
        'DotNetExample()
        'ReadRecordsFromFile()

        'LogEvent(453, 334)
        ReadEvent()

        Me.Close()

    End Sub

    Private Sub FileIOForm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        LogEvent(e.X, e.Y)
    End Sub
End Class
