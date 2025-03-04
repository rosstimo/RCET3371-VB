Public Class SerialComForm
    Private Sub SerialComForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ComSetup()
        ComResolve()
    End Sub

    Sub ComSetup()
        SerialPort.PortName = "COM4"
        Dim bytes(0) As Byte
        bytes(0) = &B11110000
        SerialPort.Write(bytes, 0, 1)
    End Sub

    Sub ComResolve()
        Dim getSettings(0) As Byte
        getSettings(0) = &B11110000
        For port = 1 To 10
            SerialPort.PortName = $"COM{port}"
            Try
                SerialPort.Open()
                ComPortComboBox.Items.Add(SerialPort.PortName)
                SerialPort.Close()
            Catch ex As Exception
                Console.WriteLine($"{SerialPort.PortName} does not exist")
            End Try

        Next

    End Sub

    Sub ComConnect()

        If SerialPort.IsOpen Then
            SerialPort.Close()
        End If

        SerialPort.PortName = ComPortComboBox.SelectedItem.ToString
        SerialPort.Open()


    End Sub

    Sub SendCommand(bytes() As Byte)

        Try
            SerialPort.Write(bytes, 0, bytes.Length)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function CheckIfQuietBoard() As Boolean
        Dim bytes(0) As Byte
        bytes(0) = &B11110000
        SerialPort.Write(bytes, 0, 1)
        Return True
    End Function

    Private Sub SerialPort_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort.DataReceived
        'Console.WriteLine(SerialPort.BytesToRead)
        'Dim numberOfBytes = SerialPort.BytesToRead
        'Dim bytes(numberOfBytes) As Byte

        'SerialPort.Read(bytes, 0, numberOfBytes)

        'For Each thingy In bytes
        '    Console.WriteLine($"D: {thingy.ToString.PadLeft(3)}  0x{Replace(Hex(thingy).ToString.PadRight(2), " ", "0")}  ASCII: {Chr(thingy)}")

        'Next
        BufferStatusLabel.Text = CStr(SerialPort.BytesToRead)

    End Sub

    Private Sub ComPortComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComPortComboBox.SelectedIndexChanged
        PortNameStatusLabel.Text = ComPortComboBox.SelectedItem.ToString
        ComConnect()
        CheckIfQuietBoard()
    End Sub
End Class
