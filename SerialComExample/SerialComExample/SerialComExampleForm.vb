Imports System.Threading.Thread
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
        WriteDigital()
    End Sub

    Private Sub SerialPort_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort.DataReceived
        Dim data(SerialPort.BytesToRead) As Byte
        SerialPort.Read(data, 0, SerialPort.BytesToRead)
        For i = 0 To UBound(data)
            Console.Write($"{Hex(data(i))}: ")
            Console.WriteLine(Chr(data(i)))

        Next
    End Sub
    Sub WriteDigital()
        Dim Data(1) As Byte
        Data(0) = &H20 '&B101111
        Data(1) = &B1

        Do
            SerialPort.Write(Data, 0, 2)
            If Data(1) = &H80 Then
                Data(1) = &H1
            Else
                Data(1) <<= 1
            End If
            Sleep(500)
        Loop
    End Sub



End Class
