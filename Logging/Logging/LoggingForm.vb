Option Strict On
Option Explicit On

Public Class LoggingForm

    Dim dataQ As New Queue


    Sub SetDefaults()
        LogPictureBox.BackColor = Color.Black

    End Sub

    Sub Updategraph()
        Dim plotdata(100) As Integer
        LogPictureBox.Refresh()
        dataQ.CopyTo(plotdata, 0)
        Plot(plotdata)


    End Sub
    Sub Plot(plotData() As Integer)
        Dim g As Graphics = LogPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Lime)
        Dim oldX%, oldY%
        g.ScaleTransform(CSng(LogPictureBox.Width / 100), CSng(LogPictureBox.Height / 255))
        g.TranslateTransform(0, 255)
        For x = 0 To UBound(plotData)
            g.DrawLine(pen, oldX, oldY, x, plotData(x) * -1)
            oldX = x
            oldY = plotData(x) * -1
        Next

    End Sub
    Sub GetNewData()
        Dim newData As Integer = RandomNumberFrom()
        Static lastData As Integer

        If newData + lastData > 255 Then
            Me.dataQ.Enqueue(lastData - newData)
            lastData -= newData
        Else
            Me.dataQ.Enqueue(lastData + newData)
            lastData += newData
        End If

        'this keeps the queue limited to size of 100
        If Me.dataQ.Count > 100 Then
            Me.dataQ.Dequeue()
        End If


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
        For i = 0 To 100
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
        Updategraph()
        GetNewData()
    End Sub
End Class
