Imports System.Runtime.InteropServices

Public Class Qy_Board
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

    'Qy_ Board Command Functions
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
        data(0) = &B10
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
    ''' Read the analog input A22of the Qy_ board. 
    ''' <br/>
    ''' A01 = 01010010
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
    ''' <br/>
    ''' Command: 0110nnnn
    ''' <br/>
    ''' Where the lower 4 bits are the number of bytes to write to the USART1. 
    ''' <br/>
    ''' The next n bytes are the data to write to the USART1. Maximum of 15
    ''' <br/>
    ''' </summary>
    ''' <returns>Byte Array</returns>'
    Function WriteToUSART1(USARTData() As Byte) As Byte()
        Dim data(UBound(USARTData) + 1) As Byte
        Dim argumentBits(0) As Byte

        'prepare argument nybble
        argumentBits(0) = CByte(UBound(USARTData)) Or CByte(&B11110000)

        'combine comand nybble with argument nybble
        data(0) = CByte(&B1101111) And argumentBits(0)

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

        Return data
    End Function

    ''' <summary>
    ''' Read from the USART1 of the Qy_ board. 
    ''' <br/>
    ''' Command: 0111xxxx
    ''' <br/>
    ''' Where the lower 4 bits are the number of bytes to read from the USART1. 
    ''' <br/>
    ''' </summary>
    ''' <returns>Byte Array</returns>'
    Function ReadFromUSART1() As Byte()
        Dim data(0) As Byte
        data(0) = &B111
        Return data
    End Function

    ''' <summary>
    ''' Write to the USART2 of the Qy_ board. 
    ''' <br/>
    ''' Command: 1000nnnn
    ''' <br/>
    ''' Where the lower 4 bits are the number of bytes to write to the USART2. 
    ''' <br/>
    ''' The next n bytes are the data to write to the USART2. Maximum of 15
    ''' <br/>
    ''' </summary>
    ''' <returns>Byte Array</returns>

    Function WriteToUSART2(USARTData() As Byte) As Byte()
        Dim data(UBound(USARTData) + 1) As Byte
        Dim argumentBits(0) As Byte

        'prepare argument nybble
        argumentBits(0) = CByte(UBound(USARTData)) Or CByte(&B11110000)

        'combine comand nybble with argument nybble
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
    ''' <br/>
    ''' Command: 1001xxxx
    ''' <br/>
    ''' Where the lower 4 bits are the number of bytes to read from the USART2. 
    ''' <br/>
    ''' </summary>
    ''' <returns>Byte Array</returns>'
    Function ReadFromUSART2() As Byte()
        Dim data(0) As Byte
        data(0) = &B1001

        Return data
    End Function
End Class
