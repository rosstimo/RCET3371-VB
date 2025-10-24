<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ShuffleButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ShuffleButton
        '
        Me.ShuffleButton.Location = New System.Drawing.Point(1114, 588)
        Me.ShuffleButton.Name = "ShuffleButton"
        Me.ShuffleButton.Size = New System.Drawing.Size(168, 97)
        Me.ShuffleButton.TabIndex = 0
        Me.ShuffleButton.Text = "&Shuffle"
        Me.ShuffleButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1317, 697)
        Me.Controls.Add(Me.ShuffleButton)
        Me.Name = "MainForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ShuffleButton As Button
End Class
