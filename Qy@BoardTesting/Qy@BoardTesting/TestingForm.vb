Public Class TestingForm
    Private Sub TestingForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SerialPort.PortName = "COM5"
        SerialPort.BaudRate = 9600
        SerialPort.Open()
    End Sub

    Sub TestCom()
        'create an array of bytes called data
        Dim data(15) As Byte ' 16 bytes
        data(0) = &B11110000

        'send the byte to the serial port
        SerialPort.Write(data, 0, 1) 'send 1 byte from data starting at 0


    End Sub

    Private Sub SerialPort_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort.DataReceived
        'read the data from the serial port
        Dim receivedBytes(64) As Byte
        SerialPort.Read(receivedBytes, 0, 64)

        For i = 0 To UBound(receivedBytes)
            'print the ascii character of the byte if it is a printable character otherwise print a dot
            Console.Write($" {If(receivedBytes(i) >= 32 And receivedBytes(i) <= 126, Chr(receivedBytes(i)), ".")}")
            'print all the bytes in binary
            Console.Write($" &B{Convert.ToString(receivedBytes(i), 2).PadLeft(8, Chr(48))}")
            'print all the bytes in hex
            Console.WriteLine($"Byte {i} is: 0x{Hex(receivedBytes(i))}")
        Next


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TestCom()
    End Sub

End Class
