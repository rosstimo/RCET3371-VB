Imports System.Runtime.InteropServices

Public Class Qy_Board


    Public ReadOnly Property status As Byte()
        Get
            Return Qy_ReadStatus()
        End Get
    End Property

    'Qy_ Board Command List
    'Command Number | Command Name              | Argument Used | Required Data Bytes   | Received Data Bytes
    '             0 | Null                      | No            | 0                     | 0
    '             1 | Read Status               | No            | 0                     | 1
    '             2 | Write to Digital Outputs  | No            | 1                     | 0
    '             3 | Read Digital Inputs       | No            | 0                     | 1
    '             4 | Write to Analog Output    | Yes           | 2                     | 0
    '             5 | Read Analog Inputs        | Yes           | 0                     | 2-8
    '             6 | Write to USART 1          | Yes           | 1-15                  | 0
    '             7 | Read USART 1 Buffer       | Yes           | 0                     | 1-15
    '             8 | Write to USART 2          | Yes           | 1-15                  | 0
    '             9 | Read USART 2 Buffer       | Yes           | 0                     | 1-15
    '            10 | Write to SPI Port         | Yes           | 1-15                  | 0
    '            11 | Read SPI Port Buffer      | Yes           | 0                     | 1-15
    '            12 | I²C Transaction           | Yes           | 1-16                  | 1-16
    '            13 | SD Card Transaction       | Yes           | X                     | X
    '            14 | Write to Settings         | Yes           | 1-4                   | 0
    '            15 | Read Settings             | No            | 0                     | 6

    'Qy_ Board Command Functions ----------------------------------------------|

    ''' <summary>
    ''' Null command. Signals End of packet USB, i2c, SPI, USART. (Optional) 
    ''' B0000xxxx
    ''' </summary>
    ''' <returns>Command Byte</returns>
    Function Qy_Null() As Byte()
        Dim data(0) As Byte
        data(0) = &B0
        Return data
    End Function

    ''' <summary>
    ''' Read the status of the Qy_ board. 
    ''' B0001xxxx
    ''' </summary>
    ''' <returns>Command Byte</returns>
    Function Qy_ReadStatus() As Byte()
        Dim data(0) As Byte
        data(0) = &B1
        Return data
    End Function

    ''' <summary>
    ''' Write to the digital outputs of the Qy_ board. 
    ''' B0010xxxx
    ''' </summary>
    ''' <param name="outputByte">Data Byte</param>
    ''' <returns>Command Byte</returns>
    Function Qy_WriteDigitalOutputs(outputByte As Byte) As Byte()
        Dim data(1) As Byte
        data(0) = &H20
        data(1) = outputByte
        Return data
    End Function

    ''' <summary>
    ''' Read the digital inputs of the Qy_ board. 
    ''' B0011xxxx
    ''' </summary>
    ''' <returns>Command Byte</returns>
    Function Qy_ReadDigitalInputs() As Byte()
        Dim data(0) As Byte
        data(0) = &B11
        Return data
    End Function

    ''' <summary>
    ''' Write 10 bit value to an analog output of the Qy_ board.
    ''' B01000001
    ''' <br/><br/>
    ''' The first byte is the command byte. 
    ''' <br/>
    ''' Command:  A01 = 01000001 
    ''' <br/><br/>
    ''' The second byte is the high byte. The upper MSB bits (9-2) of the analog output. 
    ''' <br/>
    ''' highByte bits: 98765432 
    ''' <br/><br/>
    ''' The third byte is the low byte. Bits 7 and 8 of the low byte are the LSB bits of the analog output. 
    ''' <br/>
    ''' lowByte bits: 10xxxxxx
    ''' <br/>
    ''' </summary>
    ''' <returns>Byte Array</returns>
    Function Qy_WriteAnalogOutputA1(Optional highByte As Byte = 0, Optional lowByte As Byte = 0) As Byte()
        Dim data(2) As Byte
        data(0) = &B1000001
        data(1) = highByte
        data(2) = lowByte
        Return data
    End Function

    ''' <summary>
    ''' Write 10 bit value to an analog output of the Qy_ board.
    ''' B01000010
    ''' <br/><br/>
    ''' The first byte is the command byte. 
    ''' <br/>
    ''' Command:  A02 = 01000010 
    ''' <br/><br/>
    ''' The second byte is the high byte. The upper MSB bits (9-2) of the analog output. 
    ''' <br/>
    ''' highByte bits: 98765432 
    ''' <br/><br/>
    ''' The third byte is the low byte. Bits 7 and 8 of the low byte are the LSB bits of the analog output. 
    ''' <br/>
    ''' lowByte bits: 10xxxxxx
    ''' <br/>
    ''' </summary>
    ''' <returns>Byte Array</returns>
    Function Qy_WriteAnalogOutputA2(Optional highByte As Byte = 0, Optional lowByte As Byte = 0) As Byte()
        Dim data(2) As Byte
        data(0) = &B1000010
        data(1) = highByte
        data(2) = lowByte
        Return data
    End Function

    ''' <summary>
    ''' Read the analog input A1 of the Qy_ board. 
    ''' <br/>
    ''' A01 = 01010001
    ''' </summary>
    ''' <returns>Byte Array</returns>'
    Function Qy_ReadAnalogInPutA1() As Byte()
        Dim data(0) As Byte
        data(0) = &B1010001
        Return data
    End Function

    ''' <summary>
    ''' Read the analog input A2 of the Qy_ board. 
    ''' <br/>
    ''' A02 = 01010010
    ''' </summary>
    ''' <returns>Byte Array</returns>'
    Function Qy_ReadAnalogInPutA2() As Byte()
        Dim data(0) As Byte
        data(0) = &B1010010
        Return data
    End Function

    ''' <summary>
    ''' Read the analog input A3 of the Qy_ board. 
    ''' <br/>
    ''' A01 = 01010011
    ''' </summary>
    ''' <returns>Byte Array</returns>'
    Function Qy_ReadAnalogInPutA3() As Byte()
        Dim data(0) As Byte
        data(0) = &B1010011
        Return data
    End Function

    ''' <summary>
    ''' Read the analog input A4 of the Qy_ board. 
    ''' <br/>
    ''' A01 = 01010100
    ''' </summary>
    ''' <returns>Byte Array</returns>'
    Function Qy_ReadAnalogInPutA4() As Byte()
        Dim data(0) As Byte
        data(0) = &B1010100
        Return data
    End Function

    ''' <summary>
    ''' Write to the USART1 of the Qy_ board. 
    ''' 0110nnnn
    ''' <br/>
    ''' <br/>
    ''' Where the lower 4 bits are the number of bytes to write to the USART1. 
    ''' <br/>
    ''' The next n bytes are the data to write to the USART1. Maximum of 15
    ''' <br/>
    ''' </summary>
    ''' <returns>Byte Array</returns>'
    Function Qy_WriteToUSART1(USARTData() As Byte) As Byte()
        Dim data(UBound(USARTData) + 1) As Byte

        'copy USART data bytes to data array
        For i = 0 To UBound(USARTData)
            data(i + 1) = USARTData(i)
            'artificially limit to 16 bytes
            Select Case i
                Case > 15
                    ReDim Preserve data(16)
                    Exit For
            End Select
        Next

        data(0) = Combine(CByte(&H60), CByte(UBound(data)))
        Return data
    End Function

    ''' <summary>
    ''' Read from the USART1 of the Qy_ board. 
    ''' 0111xxxx
    ''' <br/>
    ''' <br/>
    ''' Where the lower 4 bits are the number of bytes to read from the USART1. 
    ''' <br/>
    ''' </summary>
    ''' <returns>Byte Array</returns>'
    Function Qy_ReadFromUSART1() As Byte()
        Dim data(0) As Byte
        data(0) = &H70
        Return data
    End Function

    ''' <summary>
    ''' Write to the USART2 of the Qy_ board. 
    ''' B1000nnnn
    ''' <br/>
    ''' <br/>
    ''' Where the lower 4 bits are the number of bytes to write to the USART2. 
    ''' <br/>
    ''' The next n bytes are the data to write to the USART2. Maximum of 15
    ''' <br/>
    ''' </summary>
    ''' <returns>Byte Array</returns>
    Function Qy_WriteToUSART2(USARTData() As Byte) As Byte()
        Dim data(UBound(USARTData) + 1) As Byte
        Dim argumentBits(0) As Byte

        'prepare argument nibble
        argumentBits(0) = CByte(UBound(USARTData)) Or CByte(&B11110000)

        'combine command nibble with argument nibble
        data(0) = CByte(&B10001111) And argumentBits(0)

        'copy USART data bytes to data array
        For i = 0 To UBound(USARTData)
            data(i + 1) = USARTData(i)
            'artificially limit to 16 bytes
            Select Case i
                Case > 15
                    ReDim Preserve data(16)
            End Select
        Next

        Return data
    End Function

    ''' <summary>
    ''' Read from the USART2 of the Qy_ board. 
    ''' B1001xxxx
    ''' <br/>
    ''' <br/>
    ''' Where the lower 4 bits are the number of bytes to read from the USART2. 
    ''' <br/>
    ''' </summary>
    ''' <returns>Byte Array</returns>'
    Function Qy_ReadFromUSART2() As Byte()
        Dim data(0) As Byte
        data(0) = &H90
        Return data
    End Function

    ''' <summary>
    ''' Write to the SPI buffer of the Qy_ board
    ''' B1010nnnn
    ''' <br/><br/>
    ''' Where the lower 4 bits are the number of bytes to write to the SPI buffer. 
    ''' <br/>
    ''' The next n bytes are the data to write to the SPI buffer. Maximum of 15
    ''' <br/>
    ''' </summary>
    ''' <returns>Byte Array</returns>
    Function Qy_WriteSPIBuffer(SPIData() As Byte) As Byte()
        Dim data(UBound(SPIData) + 1) As Byte

        'copy SPI data bytes to data array
        For i = 0 To UBound(SPIData)
            data(i + 1) = SPIData(i)
            'artificially limit to 16 bytes
            Select Case i
                Case > 15
                    ReDim Preserve data(16)
            End Select
        Next

        data(0) = Combine(CByte(&HA0), CByte(UBound(data)))
        Return data
    End Function

    ''' <summary>
    ''' Read from the SPI buffer of the Qy_ board
    ''' B1011xxxx
    ''' <br/><br/>
    ''' Where the lower 4 bits are the number of bytes to read from the SPI buffer. 
    ''' <br/>
    ''' </summary>
    ''' <returns>Byte Array</returns>
    Function Qy_ReadSPIBuffer() As Byte()
        Dim data(0) As Byte
        data(0) = &HA1
        Return data
    End Function

    ''' <summary>
    ''' I²C Transaction
    ''' B1100nnnn
    ''' <br/><br/>
    ''' Where the lower 4 bits are the number of bytes to write to the I²C buffer. 
    ''' <br/>
    ''' The next n bytes are the data to write to the I²C buffer. Maximum of 15
    ''' <br/><br/>
    ''' The command byte must be followed by the address byte. |A6|A5|A4|A3|A2|A1|A0|RW|
    ''' <br/><br/>
    ''' The I²C data bytes are sent after the address byte. 
    ''' <br/>
    ''' </summary>
    ''' <returns>Byte Array</returns>
    Function Qy_I2CTransaction(I2CData() As Byte, I2CAddress As Byte) As Byte()
        Dim data(UBound(I2CData) + 2) As Byte

        'copy I2C data bytes to data array
        For i = 0 To UBound(I2CData)
            data(i + 2) = I2CData(i)
            'artificially limit to 16 bytes
            Select Case i
                Case > 15
                    ReDim Preserve data(16)
            End Select
        Next


        'combine command nibble with argument nibble
        'data(0) = CByte(&B11001111) And argumentBits(0)

        'add I2C address byte
        data(1) = I2CAddress

        Return data
    End Function

    ''' <summary>
    ''' SD Card Transaction
    ''' B1101nnnn
    ''' <br/><br/>
    ''' Where the lower 4 bits are the number of bytes to write to the SD card buffer. 
    ''' <br/>
    ''' The next n bytes are the data to write to the SD card buffer. Maximum of 15
    ''' <br/>
    ''' </summary>
    ''' <returns>Byte Array</returns>


    'Helper functions ---------------------------------------------------------|

    ''' <summary>
    ''' combine the high nibble of one byte with the low nibble of the other byte
    ''' </summary>
    ''' <param name="highNibbleOfThis"></param>
    ''' <param name="lowNibbleOfThis"></param>
    ''' <returns>byte</returns>
    Private Function Combine(highNibbleOfThis As Byte, lowNibbleOfThis As Byte) As Byte
        'keep high nibble 0 out lower nibble
        highNibbleOfThis = CByte(highNibbleOfThis) And CByte(&HF0)
        'keep low nibble 0 out high nibble
        lowNibbleOfThis = CByte(lowNibbleOfThis) And CByte(&HF)
        'Combine nibbles and return
        Return highNibbleOfThis Or lowNibbleOfThis
    End Function

    Sub testing()
        'TestingForm.SerialPort.BytesToRead
    End Sub

End Class
