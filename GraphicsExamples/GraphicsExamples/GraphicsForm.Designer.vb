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
        Me.components = New System.ComponentModel.Container()
        Me.DrawPictureBox = New System.Windows.Forms.PictureBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.DrawButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.CoordinatesStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PlotTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DrawPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'DrawPictureBox
        '
        Me.DrawPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DrawPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DrawPictureBox.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.DrawPictureBox.Location = New System.Drawing.Point(31, 24)
        Me.DrawPictureBox.Name = "DrawPictureBox"
        Me.DrawPictureBox.Size = New System.Drawing.Size(735, 431)
        Me.DrawPictureBox.TabIndex = 0
        Me.DrawPictureBox.TabStop = False
        Me.DrawPictureBox.UseWaitCursor = True
        '
        'ExitButton
        '
        Me.ExitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExitButton.Location = New System.Drawing.Point(629, 461)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(137, 75)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'DrawButton
        '
        Me.DrawButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DrawButton.Location = New System.Drawing.Point(343, 461)
        Me.DrawButton.Name = "DrawButton"
        Me.DrawButton.Size = New System.Drawing.Size(137, 75)
        Me.DrawButton.TabIndex = 0
        Me.DrawButton.Text = "D&raw"
        Me.DrawButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClearButton.Location = New System.Drawing.Point(486, 461)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(137, 75)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "C&lear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CoordinatesStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 549)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(794, 32)
        Me.StatusStrip.TabIndex = 3
        Me.StatusStrip.Text = "StatusStrip"
        '
        'CoordinatesStatusLabel
        '
        Me.CoordinatesStatusLabel.Name = "CoordinatesStatusLabel"
        Me.CoordinatesStatusLabel.Size = New System.Drawing.Size(43, 25)
        Me.CoordinatesStatusLabel.Text = "(x,y)"
        '
        'PlotTimer
        '
        Me.PlotTimer.Enabled = True
        Me.PlotTimer.Interval = 250
        '
        'GraphicsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 581)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.DrawButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.DrawPictureBox)
        Me.MinimumSize = New System.Drawing.Size(500, 500)
        Me.Name = "GraphicsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Graphics!"
        CType(Me.DrawPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DrawPictureBox As PictureBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents DrawButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents CoordinatesStatusLabel As ToolStripStatusLabel
    Friend WithEvents PlotTimer As Timer
End Class
