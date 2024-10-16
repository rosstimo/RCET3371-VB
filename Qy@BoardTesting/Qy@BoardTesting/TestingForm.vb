Option Strict On
Option Explicit On

Imports System.Threading.Thread
Public Class TestingForm

    Sub ReadStatus()
        Dim q As New Qy_Board

        SerialPort.Write(q.Qy_ReadAnalogInPutA1, 0, q.Qy_ReadAnalogInPutA1.Length)

        SendListBox.Items.Clear()

        For Each thing In q.Qy_ReadAnalogInPutA1
            SendListBox.Items.Add($"0x{Hex(thing)}")
        Next

        'give some time for the serial data to come in
        Sleep(5)
        'MsgBox(SerialPort.BytesToRead)





    End Sub

    Sub GetCommands()
        'get a list of all the command methods in the Qy_Board class
        'and add them to the combobox
        Dim q As New Qy_Board
        Dim methods() As Reflection.MethodInfo = q.GetType.GetMethods

        For Each method In methods
            If InStr(method.Name, "Qy_") > 0 Then
                CommandComboBox.Items.Add(method.Name)
                Console.WriteLine(method.Name)
            End If
        Next
        'set the default command to the first item in the combobox
        CommandComboBox.SelectedIndex = 0

    End Sub

    Sub SendCommand(Optional argument As Byte = 0, Optional RequiredDataBytes() As Byte = Nothing)
        'send the selected command to the Qy_ board
        Dim q As New Qy_Board
        Dim command As String = CommandComboBox.SelectedItem.ToString
        Dim data() As Byte
        'get the data based on the selected command
        Select Case command
            Case "Qy_Null"
                data = q.Qy_Null
            Case "Qy_ReadStatus"
                data = q.Qy_ReadStatus
            Case "Qy_WriteDigitalOutputs"
                data = q.Qy_WriteDigitalOutputs(RequiredDataBytes(0))
            Case "Qy_ReadDigitalInputs"
                data = q.Qy_ReadDigitalInputs
            Case "Qy_WriteAnalogOutputA1"
                data = q.Qy_WriteAnalogOutputA1(RequiredDataBytes(0))
            Case "Qy_WriteAnalogOutputA2"
                data = q.Qy_WriteAnalogOutputA2(RequiredDataBytes(0))
            Case "Qy_ReadAnalogInPutA1"
                data = q.Qy_ReadAnalogInPutA1
            Case "Qy_ReadAnalogInPutA2"
                data = q.Qy_ReadAnalogInPutA2
            Case "Qy_ReadAnalogInPutA3"
                data = q.Qy_ReadAnalogInPutA3
            Case "Qy_ReadAnalogInPutA4"
                data = q.Qy_ReadAnalogInPutA4
            Case "Qy_WriteToUSART1"
                data = q.Qy_WriteToUSART1(RequiredDataBytes)
            Case "Qy_ReadFromUSART1"
                data = q.Qy_ReadFromUSART1
            Case "Qy_WriteToUSART2"
                data = q.Qy_WriteToUSART2(RequiredDataBytes)
            Case "Qy_ReadFromUSART2"
                data = q.Qy_ReadFromUSART2
            Case "Qy_WriteSPIBuffer"
                data = q.Qy_WriteSPIBuffer(RequiredDataBytes)
            Case "Qy_ReadSPIBuffer"
                data = q.Qy_ReadSPIBuffer
            Case "Qy_I2CTransaction"
                ' data = q.Qy_I2CTransaction(RequiredDataBytes)
            Case "Qy_ReadSettings"
                data = q.Qy_ReadSettings
        End Select

        SerialPort.Write(data, 0, data.Length)

        'print the bytes to the console
        WriteBytesToListBox(data)
    End Sub

    'Testing and Debugging ----------------------------------------------------
    Sub TestCom()
        'create an array of bytes called data
        Dim data(15) As Byte ' 16 bytes
        data(0) = &B11110000 'this byte tell the Qy_ board to send all settings

        'send the byte to the serial port
        SerialPort.Write(data, 0, 1) 'send 1 byte from data starting at 0
    End Sub

    'COM Port Subs and Functions -------------------------------------------------------
    Sub UpdateStatus()
        'add all current serial port info to the status label
        ComPortStatusLabel.Text = $"Port: {SerialPort.PortName} Baud: {SerialPort.BaudRate} Status: {SerialPort.IsOpen} Input Buffer: {SerialPort.BytesToRead}"
    End Sub

    Sub Connect()
        'open/refresh the serial port
        Try
            SerialPort.Close()
            SerialPort.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        UpdateStatus()
    End Sub

    Sub GetPorts()
        'add all available ports to the port combobox
        PortComboBox.Items.Clear()
        For Each s As String In SerialPort.GetPortNames()
            PortComboBox.Items.Add($"{s}")
        Next

        PortComboBox.SelectedIndex = 0
    End Sub

    Sub PortStatus()
        'store all serial port properties
        Dim portName As String = SerialPort.PortName
        Dim baudRate As Integer = SerialPort.BaudRate
        Dim isOpen As Boolean = SerialPort.IsOpen
        Dim parity As IO.Ports.Parity = SerialPort.Parity
        Dim stopBits As IO.Ports.StopBits = SerialPort.StopBits
        Dim dataBits As Integer = SerialPort.DataBits
        Dim handshake As IO.Ports.Handshake = SerialPort.Handshake
        Dim readTimeout As Integer = SerialPort.ReadTimeout
        Dim writeTimeout As Integer = SerialPort.WriteTimeout
        Dim receivedBytesThreshold As Integer = SerialPort.ReceivedBytesThreshold
        Dim rtsEnable As Boolean = SerialPort.RtsEnable

        'print all serialport properties to the console
        Console.WriteLine($"Port Name: {portName}")
        Console.WriteLine($"Baud Rate: {baudRate}")
        Console.WriteLine($"Is Open: {isOpen}")
        Console.WriteLine($"Parity: {parity}")
        Console.WriteLine($"Stop Bits: {stopBits}")
        Console.WriteLine($"Data Bits: {dataBits}")
        Console.WriteLine($"Handshake: {handshake}")
        Console.WriteLine($"Read Timeout: {readTimeout}")
        Console.WriteLine($"Write Timeout: {writeTimeout}")
        Console.WriteLine($"Received Bytes Threshold: {receivedBytesThreshold}")
        Console.WriteLine($"RTS Enable: {rtsEnable}")

    End Sub

    Sub WriteBytesToConsole(dataBytes() As Byte)
        'print the bytes to the console
        For i = 0 To UBound(dataBytes)
            'print the ascii character of the byte if it is a printable character otherwise print a dot
            Console.Write($"Byte {CStr(i).PadLeft(2)} is: {If(dataBytes(i) >= 32 And dataBytes(i) <= 126, Chr(dataBytes(i)), ".")}")
            'print all the bytes in binary
            Console.Write($" &B{Convert.ToString(dataBytes(i), 2).PadLeft(8, Chr(48))}")
            'print all the bytes in hex
            Console.WriteLine($" 0x{Hex(dataBytes(i))}")
        Next


    End Sub
    Sub WriteBytesToListBox(dataBytes() As Byte)
        'print the bytes to the console
        For i = 0 To UBound(dataBytes)
            'print the ascii character of the byte if it is a printable character otherwise print a dot
            Console.Write($"Byte {CStr(i).PadLeft(2)} is: {If(dataBytes(i) >= 32 And dataBytes(i) <= 126, Chr(dataBytes(i)), ".")}")
            'print all the bytes in binary
            Console.Write($" &B{Convert.ToString(dataBytes(i), 2).PadLeft(8, Chr(48))}")
            'print all the bytes in hex
            Console.WriteLine($" 0x{Hex(dataBytes(i))}")
        Next

    End Sub


    'Event Handlers -----------------------------------------------------------

    Private Sub TestingForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        GetPorts()
        UpdateStatus()
        GetCommands()
    End Sub

    Private Sub SerialPort_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort.DataReceived
        'read all the bytes from the serial port inputbuffer
        ' Dim receivedBytes(SerialPort.BytesToRead) As Byte
        ' SerialPort.Read(receivedBytes, 0, SerialPort.BytesToRead)

        'for debug print the bytes to the console
        'WriteBytesToConsole(receivedBytes)
        UpdateStatus()
    End Sub

    Private Sub SendButton_Click(sender As Object, e As EventArgs) Handles SendButton.Click
        'TestCom()
        ReadStatus()
        GetCommands()
    End Sub

    Private Sub CheckComButton_Click(sender As Object, e As EventArgs) Handles CheckComButton.Click
        GetPorts()
    End Sub

    Private Sub ConnectButton_Click(sender As Object, e As EventArgs) Handles ConnectButton.Click
        Connect()
    End Sub

    Private Sub PortComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PortComboBox.SelectedIndexChanged
        SerialPort.Close()
        SerialPort.PortName = PortComboBox.SelectedItem.ToString
        Connect()
    End Sub

    Private Sub LoadButton_Click(sender As Object, e As EventArgs) Handles LoadButton.Click


    End Sub
End Class
