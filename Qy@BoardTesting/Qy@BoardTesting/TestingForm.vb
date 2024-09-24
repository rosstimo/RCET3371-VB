Public Class TestingForm
    Private Sub TestingForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        UpdateStatus()
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

    Private Sub CheckComButton_Click(sender As Object, e As EventArgs) Handles CheckComButton.Click
        GetPorts()
    End Sub

    Sub UpdateStatus()
        'add all current serialport info to the status label
        ComPortStatusLabel.Text = $"Port: {SerialPort.PortName} Baud: {SerialPort.BaudRate} Status: {SerialPort.IsOpen}"
    End Sub

    Sub Connect()
        Try
            SerialPort.Close()
            SerialPort.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        UpdateStatus()
    End Sub

    Sub GetPorts()
        PortComboBox.Items.Clear()
        For Each s As String In SerialPort.GetPortNames()
            PortComboBox.Items.Add($"{s}")
        Next
        PortComboBox.SelectedIndex = 0
    End Sub


    Private Sub ConnectButton_Click(sender As Object, e As EventArgs) Handles ConnectButton.Click
        Connect()
    End Sub

    Private Sub PortComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PortComboBox.SelectedIndexChanged
        SerialPort.Close()
        SerialPort.PortName = PortComboBox.SelectedItem.ToString
        Connect()
    End Sub
End Class
