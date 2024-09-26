Public Class SerialComExampleForm
    Private Sub SerialComExampleForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SerialPort.PortName = "COM4"
        SerialPort.BaudRate = 9600
        SerialPort.Open()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim data(0) As Byte
        data(0) = &B11110000
        SerialPort.Write(data, 0, 1)
    End Sub

    Private Sub SerialPort_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort.DataReceived
        Dim data(SerialPort.BytesToRead) As Byte
        SerialPort.Read(data, 0, SerialPort.BytesToRead)
        For i = 0 To UBound(data)
            Console.Write($"{Hex(data(i))}: ")
            Console.WriteLine(Chr(data(i)))

        Next
    End Sub
End Class
