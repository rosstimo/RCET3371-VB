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
        Me.ComNameStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ComDropDownButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ComPortComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.ComStatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'SerialPort
        '
        '
        'ComStatusStrip
        '
        Me.ComStatusStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ComStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComNameStatusLabel, Me.ComDropDownButton})
        Me.ComStatusStrip.Location = New System.Drawing.Point(0, 418)
        Me.ComStatusStrip.Name = "ComStatusStrip"
        Me.ComStatusStrip.Size = New System.Drawing.Size(800, 32)
        Me.ComStatusStrip.TabIndex = 0
        Me.ComStatusStrip.Text = "StatusStrip"
        '
        'ComNameStatusLabel
        '
        Me.ComNameStatusLabel.Name = "ComNameStatusLabel"
        Me.ComNameStatusLabel.Size = New System.Drawing.Size(48, 25)
        Me.ComNameStatusLabel.Text = "Port:"
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
    Friend WithEvents ComNameStatusLabel As ToolStripStatusLabel
    Friend WithEvents ComDropDownButton As ToolStripDropDownButton
    Friend WithEvents ComPortComboBox As ToolStripComboBox
End Class
