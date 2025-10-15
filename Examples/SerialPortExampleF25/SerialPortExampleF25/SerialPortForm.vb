Imports System.IO.Ports

Public Class SerialPortForm

    Sub Connect()

        SerialPort1.Close()
        SerialPort1.BaudRate = 115200 'Q@ Board Default
        SerialPort1.Parity = Parity.None
        SerialPort1.StopBits = StopBits.One
        SerialPort1.DataBits = 8
        SerialPort1.PortName = "COM4"

        SerialPort1.Open()
        'SerialPort1.Open()
        'SerialPort1.Close()

    End Sub



    Private Sub SerialPortForm_Click(sender As Object, e As EventArgs) Handles Me.Click
        Connect()
    End Sub

    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Me.Text = SerialPort1.BytesToRead.ToString
    End Sub
End Class
