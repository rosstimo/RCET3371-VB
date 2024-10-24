Option Strict On
Option Explicit On
Public Class LoggingForm

    Sub SetDefaults()
        LogPictureBox.BackColor = Color.Black

    End Sub

    Sub Updategraph()

    End Sub

    Sub GetNewData()

    End Sub


    ' Events below here ---------------------------------------------------------------
    Private Sub LoggingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDefaults()
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
End Class
