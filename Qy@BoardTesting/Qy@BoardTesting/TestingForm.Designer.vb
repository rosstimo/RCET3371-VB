<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestingForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TestingForm))
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ComPortStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.PortComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.CheckComButton = New System.Windows.Forms.ToolStripButton()
        Me.ConnectButton = New System.Windows.Forms.ToolStripButton()
        Me.TopMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGroupBox = New System.Windows.Forms.GroupBox()
        Me.SendListBox = New System.Windows.Forms.ListBox()
        Me.ReceiveListBox = New System.Windows.Forms.ListBox()
        Me.StatusStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.TopMenuStrip.SuspendLayout()
        Me.DataGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'SerialPort
        '
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1008, 558)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(174, 95)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComPortStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 660)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(2, 0, 21, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(1200, 32)
        Me.StatusStrip.TabIndex = 1
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'ComPortStatusLabel
        '
        Me.ComPortStatusLabel.Name = "ComPortStatusLabel"
        Me.ComPortStatusLabel.Size = New System.Drawing.Size(180, 25)
        Me.ComPortStatusLabel.Text = "ToolStripStatusLabel1"
        '
        'ToolStrip
        '
        Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PortComboBox, Me.CheckComButton, Me.ConnectButton})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 35)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.ToolStrip.Size = New System.Drawing.Size(1200, 33)
        Me.ToolStrip.TabIndex = 2
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'PortComboBox
        '
        Me.PortComboBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PortComboBox.Name = "PortComboBox"
        Me.PortComboBox.Size = New System.Drawing.Size(180, 33)
        '
        'CheckComButton
        '
        Me.CheckComButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CheckComButton.Image = CType(resources.GetObject("CheckComButton.Image"), System.Drawing.Image)
        Me.CheckComButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CheckComButton.Name = "CheckComButton"
        Me.CheckComButton.Size = New System.Drawing.Size(34, 28)
        Me.CheckComButton.Text = "Check COM"
        '
        'ConnectButton
        '
        Me.ConnectButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ConnectButton.Image = CType(resources.GetObject("ConnectButton.Image"), System.Drawing.Image)
        Me.ConnectButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ConnectButton.Name = "ConnectButton"
        Me.ConnectButton.Size = New System.Drawing.Size(34, 28)
        Me.ConnectButton.Text = "Connect"
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.TopMenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Size = New System.Drawing.Size(1200, 35)
        Me.TopMenuStrip.TabIndex = 3
        Me.TopMenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 29)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'DataGroupBox
        '
        Me.DataGroupBox.Controls.Add(Me.ReceiveListBox)
        Me.DataGroupBox.Controls.Add(Me.SendListBox)
        Me.DataGroupBox.Location = New System.Drawing.Point(27, 107)
        Me.DataGroupBox.Name = "DataGroupBox"
        Me.DataGroupBox.Size = New System.Drawing.Size(1043, 408)
        Me.DataGroupBox.TabIndex = 4
        Me.DataGroupBox.TabStop = False
        '
        'SendListBox
        '
        Me.SendListBox.FormattingEnabled = True
        Me.SendListBox.ItemHeight = 20
        Me.SendListBox.Location = New System.Drawing.Point(6, 25)
        Me.SendListBox.Name = "SendListBox"
        Me.SendListBox.Size = New System.Drawing.Size(510, 364)
        Me.SendListBox.TabIndex = 0
        Me.SendListBox.TabStop = False
        '
        'ReceiveListBox
        '
        Me.ReceiveListBox.FormattingEnabled = True
        Me.ReceiveListBox.ItemHeight = 20
        Me.ReceiveListBox.Location = New System.Drawing.Point(522, 25)
        Me.ReceiveListBox.Name = "ReceiveListBox"
        Me.ReceiveListBox.Size = New System.Drawing.Size(510, 364)
        Me.ReceiveListBox.TabIndex = 1
        Me.ReceiveListBox.TabStop = False
        '
        'TestingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.DataGroupBox)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.TopMenuStrip)
        Me.Controls.Add(Me.Button1)
        Me.MainMenuStrip = Me.TopMenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "TestingForm"
        Me.Text = "Form1"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.TopMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.PerformLayout()
        Me.DataGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPort As IO.Ports.SerialPort
    Friend WithEvents Button1 As Button
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents ComPortStatusLabel As ToolStripStatusLabel
    Friend WithEvents ToolStrip As ToolStrip
    Friend WithEvents PortComboBox As ToolStripComboBox
    Friend WithEvents TopMenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckComButton As ToolStripButton
    Friend WithEvents ConnectButton As ToolStripButton
    Friend WithEvents DataGroupBox As GroupBox
    Friend WithEvents ReceiveListBox As ListBox
    Friend WithEvents SendListBox As ListBox
End Class
