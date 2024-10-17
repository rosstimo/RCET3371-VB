Imports System.Runtime.InteropServices
Imports System.Threading.Thread
Imports System.Windows.Forms.ComponentModel.Com2Interop
Public Class SerialComExampleForm

    Sub GetComPorts()
        For Each portName In SerialPort.GetPortNames()
            'Console.WriteLine(portName)
            SerialConnect(portName)
            GetSettings()
            Sleep(5)
            ' Console.WriteLine(SerialPort.BytesToRead)
            Dim data(SerialPort.BytesToRead) As Byte
            SerialPort.Read(data, 0, SerialPort.BytesToRead)

            'For i = LBound(data) To UBound(data)
            'Console.WriteLine($"Byte: {i} | HEX: {Hex(data(i))} | DEC: {data(i)} | ASCII: {Chr(data(i))}")

            'Next
            'Byte :  58 | HEX: 51 | DEC: 81 | ASCII: Q
            'Byte :  59 | HEX: 79 | DEC: 121 | ASCII: y
            'Byte :  60 | HEX: 40 | DEC: 64 | ASCII: @
            If data.Length >= 64 Then
                If data(58) = 81 And data(59) = 121 And data(60) = 64 Then
                    MsgBox($"Qy@ Board COM Confirmed on port: {SerialPort.PortName}")
                End If
            Else
                MsgBox($"{SerialPort.PortName} is not a Qy@ Board.... : (")

            End If
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


    ''' <summary>
    ''' Read the analog input A1 of the Qy_ board. 
    ''' <br/>
    ''' A01 = 01010001
    ''' </summary>
    ''' <returns>Byte Array</returns>'
    Function Qy_ReadAnalogInPutA1() As Byte()
        Dim data(0) As Byte
        data(0) = &B1010001
        SerialPort.Write(data, 0, 1)
        Return data
    End Function

    Function GetSettings() As Byte()
        Dim data(0) As Byte
        data(0) = &B11110000
        SerialPort.Write(data, 0, 1)
        Return data
    End Function

    Sub SerialConnect(portName As String)
        SerialPort.Close()
        SerialPort.PortName = portName
        SerialPort.BaudRate = 9600
        SerialPort.Open()

    End Sub

    ' Event Handlers ----------------------------------------------------------------------------
    Private Sub SerialComExampleForm_Load(sender As Object, e As EventArgs) Handles Me.Load


    End Sub

    Private Sub SerialPort_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) 'Handles SerialPort.DataReceived
        Dim data(SerialPort.BytesToRead) As Byte
        SerialPort.Read(data, 0, SerialPort.BytesToRead)
        For i = 0 To UBound(data)
            Console.Write($"{Hex(data(i))}: ")
            Console.WriteLine(Chr(data(i)))

        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'WriteDigital()

        'SerialPort.Write(Qy_ReadAnalogInPutA1(), 0, 1)
        ' SerialPort.Write(GetSettings(), 0, 1)
        'GetSettings()
        ' Console.WriteLine(SerialPort.ReadExisting())
        Qy_ReadAnalogInPutA1()

        Sleep(5)
        Console.WriteLine(SerialPort.BytesToRead)
        Dim data(SerialPort.BytesToRead) As Byte
        SerialPort.Read(data, 0, SerialPort.BytesToRead)

        Console.WriteLine($"High: {Hex(data(0))} | Jelly Beans: {data(0)}")
        Console.WriteLine($"Low: {Hex(data(1))}")

        'GetPorts()
    End Sub
    Sub GetPorts()
        'add all available ports to the port combobox
        PortComboBox.Items.Clear()
        For Each s As String In SerialPort.GetPortNames()
            PortComboBox.Items.Add($"{s}")
        Next

        PortComboBox.SelectedIndex = 0
    End Sub

    Private Sub ComButton_Click(sender As Object, e As EventArgs) Handles ComButton.Click
        GetComPorts()
    End Sub
End Class
