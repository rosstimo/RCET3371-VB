Imports System.IO.Ports
Imports System.Net.Configuration

Public Class SerialPortForm

    Sub SetDefaults()
        ConnectionStatusLabel.Text = "No Connection"
        GetPorts()
    End Sub

    Sub GetPorts()
        Dim ports() = SerialPort.GetPortNames()

        For Each port In ports
            PortsComboBox.Items.Add(port)
        Next

        Try
            PortsComboBox.SelectedIndex = 0
        Catch ex As Exception
            ' no com ports :(
        End Try

    End Sub

    Sub Connect()

        'TODO: try catch to avoid crashing
        SerialPort1.Close()
        Try
            SerialPort1.BaudRate = 115200 'Qy@ Board Default
            SerialPort1.Parity = Parity.None
            SerialPort1.StopBits = StopBits.One
            SerialPort1.DataBits = 8
            SerialPort1.PortName = "COM4" 'TODO iterate through com ports check for Qy@
            SerialPort1.Open()
            ConnectionStatusLabel.Text = SerialPort1.PortName
        Catch ex As Exception

        End Try


    End Sub

    Sub Write()
        Dim data(0) As Byte 'put bytes into array
        data(0) = &B11110000 'actual data as a byte
        SerialPort1.Write(data, 0, 1) 'send bytes as array, start at index 0, send 1 byte
    End Sub

    Sub Read()
        Dim data(SerialPort1.BytesToRead) As Byte

        SerialPort1.Read(data, 0, SerialPort1.BytesToRead)

        For i = 0 To UBound(data)
            Console.WriteLine($"Byte {i}: {Chr(data(i))}")
        Next

        Console.WriteLine($"Is this Qy@ Board: {IsQuietBoard(data)}")
        Console.WriteLine(UBound(data))

    End Sub

    Function IsQuietBoard(data() As Byte) As Boolean

        If UBound(data) = 64 And Chr(data(60)) = "@" Then
            Return True
        Else
            Return False
        End If

    End Function


    Private Sub SerialPortForm_Click(sender As Object, e As EventArgs) Handles Me.Click
        Connect()
        Write()
    End Sub

    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Try
            Console.WriteLine(SerialPort1.BytesToRead)
        Catch ex As Exception
            Console.WriteLine("oops!")
        End Try

        Read()

    End Sub

    Private Sub SerialPortForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        SetDefaults()

    End Sub

    Private Sub ConnectButton_Click(sender As Object, e As EventArgs) Handles ConnectButton.Click
        Connect()
    End Sub
End Class
