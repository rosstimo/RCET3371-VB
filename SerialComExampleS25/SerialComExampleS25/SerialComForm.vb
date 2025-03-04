Public Class SerialComForm
    Private Sub SerialComForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComSetup()
    End Sub

    Sub ComSetup()
        SerialPort.PortName = "COM4"
        SerialPort.Open()
        Dim bytes(0) As Byte
        bytes(0) = &B11110000
        SerialPort.Write(bytes, 0, 1)
    End Sub

    Private Sub SerialPort_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort.DataReceived
        Console.WriteLine(SerialPort.BytesToRead)
        Dim numberOfBytes = SerialPort.BytesToRead
        Dim bytes(numberOfBytes) As Byte

        SerialPort.Read(bytes, 0, numberOfBytes)

        For Each thingy In bytes
            Console.WriteLine($"D: {thingy.ToString.PadLeft(3)}  0x{Replace(Hex(thingy).ToString.PadRight(2), " ", "0")}  ASCII: {Chr(thingy)}")

        Next

    End Sub
End Class
