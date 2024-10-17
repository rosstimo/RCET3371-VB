<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SerialComExampleForm
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
        Me.components = New System.ComponentModel.Container()
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PortComboBox = New System.Windows.Forms.ComboBox()
        Me.ComButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SerialPort
        '
        Me.SerialPort.Parity = System.IO.Ports.Parity.Odd
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(257, 289)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 86)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PortComboBox
        '
        Me.PortComboBox.FormattingEnabled = True
        Me.PortComboBox.Location = New System.Drawing.Point(327, 27)
        Me.PortComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PortComboBox.Name = "PortComboBox"
        Me.PortComboBox.Size = New System.Drawing.Size(161, 21)
        Me.PortComboBox.TabIndex = 1
        '
        'ComButton
        '
        Me.ComButton.Location = New System.Drawing.Point(637, 289)
        Me.ComButton.Name = "ComButton"
        Me.ComButton.Size = New System.Drawing.Size(151, 86)
        Me.ComButton.TabIndex = 2
        Me.ComButton.Text = "&COM"
        Me.ComButton.UseVisualStyleBackColor = True
        '
        'SerialComExampleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ComButton)
        Me.Controls.Add(Me.PortComboBox)
        Me.Controls.Add(Me.Button1)
        Me.Name = "SerialComExampleForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SerialPort As IO.Ports.SerialPort
    Friend WithEvents Button1 As Button
    Friend WithEvents PortComboBox As ComboBox
    Friend WithEvents ComButton As Button
End Class
