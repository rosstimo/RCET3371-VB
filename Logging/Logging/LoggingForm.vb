Option Strict On
Option Explicit On

Public Class LoggingForm

    Dim dataQ As New Queue
    Dim xMax% = 1000, yMax% = 255
    Dim sx! = 1, sy! = 1

    Function GetBackColor(Optional newBackColor As Color = Nothing) As Color
        Static _backColor As Color
        If newBackColor <> Nothing Then
            _backColor = newBackColor
        End If
        Return _backColor
    End Function
    Function GetForeColor(Optional newForeColor As Color = Nothing) As Color
        Static _foreColor As Color
        If newForeColor <> Nothing Then
            _foreColor = newForeColor
        End If
        Return _foreColor
    End Function

    Sub SetDefaults()
        LogPictureBox.BackColor = GetBackColor(Color.Black)
        GetForeColor(Color.Lime)
        sx = CSng(LogPictureBox.Width / xMax)
        sy = CSng(LogPictureBox.Height / yMax)
    End Sub

    Sub Updategraph()
        Dim plotdata(xMax) As Integer
        ' LogPictureBox.Refresh()
        dataQ.CopyTo(plotdata, 0)
        Plot(plotdata)

    End Sub
    Sub Plot(plotData() As Integer)
        Dim g As Graphics = LogPictureBox.CreateGraphics
        Dim pen As New Pen(GetForeColor())
        Dim oldX%, oldY%
        'g.ScaleTransform(CSng(LogPictureBox.Width / Me.xMax), CSng(LogPictureBox.Height / Me.yMax))
        g.ScaleTransform(Me.sx, Me.sy)
        g.TranslateTransform(0, Me.yMax)
        'pen.Width = 2
        oldY = plotData(0)
        For x = 0 To UBound(plotData) - 1
            pen.Color = GetBackColor()
            ' g.DrawLine(pen, oldX, 0, oldX, -Me.yMax)
            g.DrawLine(pen, x, 0, x, -Me.yMax)
            pen.Color = GetForeColor()
            g.DrawLine(pen, oldX, oldY, x, plotData(x) * -1)
            oldX = x
            oldY = plotData(x) * -1
        Next

    End Sub
    Sub GetNewData()
        Dim newData As Integer = RandomNumberFrom()
        Dim coinToss As Integer = RandomNumberFrom()
        Static lastData As Integer
        Dim data(1) As Byte

        'new data may be posative or negative
        If coinToss >= 5 Then
            newData = newData * -1
        End If

        lastData += newData
        If lastData > 255 Then
            lastData = 255
        ElseIf lastData < 0 Then
            lastData = 0
        End If

        Me.dataQ.Enqueue(lastData)
        data(0) = CByte(lastData)

        StoreData("RND", data)

        'this keeps the queue limited to size of xMax
        If Me.dataQ.Count > Me.xMax Then
            Me.dataQ.Dequeue()
        End If

    End Sub

    Sub StoreData(prefix As String, data As Byte())
        Dim filename As String = $"log_{DateTime.Now.ToString("yyMMddhh")}.log"

        FileOpen(1, filename, OpenMode.Append)
        Write(1, $"$${prefix}")
        Write(1, data(0))
        Write(1, data(1))
        WriteLine(1, $"{DateTime.Now.ToString("yyMMddhhmmss")}{DateTime.Now.Millisecond}")

        FileClose(1)

    End Sub

    ''' <summary>
    ''' returns an integer from min to max inclusive.
    ''' <br/>
    ''' defaults:
    ''' <br/>
    ''' min = 0
    ''' <br/>
    ''' max = 10
    ''' </summary>
    ''' <param name="min%"></param>
    ''' <param name="max%"></param>
    ''' <returns></returns>
    Function RandomNumberFrom(Optional min% = 0, Optional max% = 10) As Integer
        Dim _random%
        Randomize(DateTime.Now.Millisecond)
        _random = CInt(Math.Floor(Rnd() * (max + 1 - min))) + min
        Return _random
    End Function

    ' Events below here ---------------------------------------------------------------
    Private Sub LoggingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDefaults()
        For i = 0 To xMax
            GetNewData()
        Next
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        'filter only for .log files with all files optional
        OpenFileDialog.Filter = "Log Files (*.log)|*.log|All Files (*.*)|*.*"
        OpenFileDialog.FileName = ""
        OpenFileDialog.ShowDialog()
        FileStatusLabel.Text = OpenFileDialog.FileName 'TODO log file function
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        'filter only for .log files with all files optional
        SaveFileDialog.Filter = "Log Files (*.log)|*.log|All Files (*.*)|*.*"
        SaveFileDialog.FileName = $"data_{DateTime.Now.ToString("yyMMddhh")}.log"
        SaveFileDialog.ShowDialog()
    End Sub

    Private Sub LogButton_Click(sender As Object, e As EventArgs) Handles LogButton.Click
        'test
        'Dim plotdata() As Integer = {0, 100, 100, 100, 50, 25, 0, 0, 0, 0, 0, 0, 0}

        'Plot(plotdata)
        If Timer.Enabled Then
            Timer.Enabled = False
        Else
            Timer.Enabled = True
        End If
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        GetNewData()
        Updategraph()

    End Sub

    Private Sub LogPictureBox_Resize(sender As Object, e As EventArgs) Handles LogPictureBox.Resize
        'XScale()
        'YScale()
        sx = CSng(LogPictureBox.Width / xMax)
        sy = CSng(LogPictureBox.Height / yMax)
        LogPictureBox.Refresh()
    End Sub
End Class
