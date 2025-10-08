<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GraphicsForm
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
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.DrawingPictureBox = New System.Windows.Forms.PictureBox()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.CoordsStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ExitButton)
        Me.GroupBox1.Controls.Add(Me.ClearButton)
        Me.GroupBox1.Location = New System.Drawing.Point(475, 375)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(313, 128)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(157, 28)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(145, 79)
        Me.ExitButton.TabIndex = 1
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(6, 28)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(145, 79)
        Me.ClearButton.TabIndex = 0
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'DrawingPictureBox
        '
        Me.DrawingPictureBox.Location = New System.Drawing.Point(12, 12)
        Me.DrawingPictureBox.Name = "DrawingPictureBox"
        Me.DrawingPictureBox.Size = New System.Drawing.Size(776, 357)
        Me.DrawingPictureBox.TabIndex = 1
        Me.DrawingPictureBox.TabStop = False
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CoordsStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 506)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(800, 39)
        Me.StatusStrip.TabIndex = 2
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'CoordsStatusLabel
        '
        Me.CoordsStatusLabel.Name = "CoordsStatusLabel"
        Me.CoordsStatusLabel.Size = New System.Drawing.Size(141, 30)
        Me.CoordsStatusLabel.Text = "MouseCoords"
        '
        'GraphicsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 545)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.DrawingPictureBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "GraphicsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Graphics!"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents DrawingPictureBox As PictureBox
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents CoordsStatusLabel As ToolStripStatusLabel
End Class
