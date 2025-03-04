<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SerialComForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SerialComForm))
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.ComStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.PortLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ComDropDownButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ComPortComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.PortNameStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PortStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BufferLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BufferStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ComStatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'SerialPort
        '
        '
        'ComStatusStrip
        '
        Me.ComStatusStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ComStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComDropDownButton, Me.PortLabel, Me.PortNameStatusLabel, Me.PortStatusLabel, Me.BufferLabel, Me.BufferStatusLabel})
        Me.ComStatusStrip.Location = New System.Drawing.Point(0, 418)
        Me.ComStatusStrip.Name = "ComStatusStrip"
        Me.ComStatusStrip.Size = New System.Drawing.Size(800, 32)
        Me.ComStatusStrip.TabIndex = 0
        Me.ComStatusStrip.Text = "StatusStrip"
        '
        'PortLabel
        '
        Me.PortLabel.Name = "PortLabel"
        Me.PortLabel.Size = New System.Drawing.Size(48, 25)
        Me.PortLabel.Text = "Port:"
        '
        'ComDropDownButton
        '
        Me.ComDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ComDropDownButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComPortComboBox})
        Me.ComDropDownButton.Image = CType(resources.GetObject("ComDropDownButton.Image"), System.Drawing.Image)
        Me.ComDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ComDropDownButton.Name = "ComDropDownButton"
        Me.ComDropDownButton.Size = New System.Drawing.Size(42, 29)
        Me.ComDropDownButton.Text = "ToolStripDropDownButton1"
        '
        'ComPortComboBox
        '
        Me.ComPortComboBox.Name = "ComPortComboBox"
        Me.ComPortComboBox.Size = New System.Drawing.Size(121, 33)
        '
        'PortNameStatusLabel
        '
        Me.PortNameStatusLabel.Name = "PortNameStatusLabel"
        Me.PortNameStatusLabel.Size = New System.Drawing.Size(55, 25)
        Me.PortNameStatusLabel.Text = "None"
        '
        'PortStatusLabel
        '
        Me.PortStatusLabel.Name = "PortStatusLabel"
        Me.PortStatusLabel.Size = New System.Drawing.Size(36, 25)
        Me.PortStatusLabel.Text = "???"
        '
        'BufferLabel
        '
        Me.BufferLabel.Name = "BufferLabel"
        Me.BufferLabel.Size = New System.Drawing.Size(63, 25)
        Me.BufferLabel.Text = "Buffer:"
        '
        'BufferStatusLabel
        '
        Me.BufferStatusLabel.Name = "BufferStatusLabel"
        Me.BufferStatusLabel.Size = New System.Drawing.Size(36, 25)
        Me.BufferStatusLabel.Text = "???"
        '
        'SerialComForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ComStatusStrip)
        Me.Name = "SerialComForm"
        Me.Text = "Form1"
        Me.ComStatusStrip.ResumeLayout(False)
        Me.ComStatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPort As IO.Ports.SerialPort
    Friend WithEvents ComStatusStrip As StatusStrip
    Friend WithEvents PortLabel As ToolStripStatusLabel
    Friend WithEvents ComDropDownButton As ToolStripDropDownButton
    Friend WithEvents ComPortComboBox As ToolStripComboBox
    Friend WithEvents PortNameStatusLabel As ToolStripStatusLabel
    Friend WithEvents PortStatusLabel As ToolStripStatusLabel
    Friend WithEvents BufferLabel As ToolStripStatusLabel
    Friend WithEvents BufferStatusLabel As ToolStripStatusLabel
End Class
