<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrettyNumbersForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.InputTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.DisplayStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.InputTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 14)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(567, 269)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'InputTextBox
        '
        Me.InputTextBox.Location = New System.Drawing.Point(7, 30)
        Me.InputTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.InputTextBox.Name = "InputTextBox"
        Me.InputTextBox.Size = New System.Drawing.Size(379, 29)
        Me.InputTextBox.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CalculateButton)
        Me.GroupBox2.Controls.Add(Me.ExitButton)
        Me.GroupBox2.Location = New System.Drawing.Point(164, 290)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(418, 160)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(7, 30)
        Me.CalculateButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(192, 110)
        Me.CalculateButton.TabIndex = 0
        Me.CalculateButton.Text = "&Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(207, 30)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(192, 110)
        Me.ExitButton.TabIndex = 1
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisplayStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 451)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(599, 39)
        Me.StatusStrip.TabIndex = 2
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'DisplayStatusLabel
        '
        Me.DisplayStatusLabel.Name = "DisplayStatusLabel"
        Me.DisplayStatusLabel.Size = New System.Drawing.Size(62, 30)
        Me.DisplayStatusLabel.Text = "value"
        '
        'PrettyNumbersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 490)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PrettyNumbersForm"
        Me.Text = "Pretty Numbers"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents InputTextBox As TextBox
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents DisplayStatusLabel As ToolStripStatusLabel
End Class
