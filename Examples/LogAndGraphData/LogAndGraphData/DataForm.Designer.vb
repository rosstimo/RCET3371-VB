﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataForm
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
        Me.GraphPictureBox = New System.Windows.Forms.PictureBox()
        Me.ButtonGroupBox = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.TopMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileTopStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.FilePathStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.GraphPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ButtonGroupBox.SuspendLayout()
        Me.TopMenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'GraphPictureBox
        '
        Me.GraphPictureBox.BackColor = System.Drawing.Color.Black
        Me.GraphPictureBox.Location = New System.Drawing.Point(12, 52)
        Me.GraphPictureBox.Name = "GraphPictureBox"
        Me.GraphPictureBox.Size = New System.Drawing.Size(1225, 345)
        Me.GraphPictureBox.TabIndex = 0
        Me.GraphPictureBox.TabStop = False
        '
        'ButtonGroupBox
        '
        Me.ButtonGroupBox.Controls.Add(Me.ExitButton)
        Me.ButtonGroupBox.Controls.Add(Me.Button2)
        Me.ButtonGroupBox.Controls.Add(Me.Button1)
        Me.ButtonGroupBox.Location = New System.Drawing.Point(769, 541)
        Me.ButtonGroupBox.Name = "ButtonGroupBox"
        Me.ButtonGroupBox.Size = New System.Drawing.Size(468, 113)
        Me.ButtonGroupBox.TabIndex = 1
        Me.ButtonGroupBox.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(9, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 61)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(162, 28)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(147, 61)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(315, 28)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(147, 61)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.TopMenuStrip.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileTopStripMenuItem})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Size = New System.Drawing.Size(1249, 38)
        Me.TopMenuStrip.TabIndex = 2
        Me.TopMenuStrip.Text = "MenuStrip1"
        '
        'FileTopStripMenuItem
        '
        Me.FileTopStripMenuItem.Name = "FileTopStripMenuItem"
        Me.FileTopStripMenuItem.Size = New System.Drawing.Size(62, 34)
        Me.FileTopStripMenuItem.Text = "&File"
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilePathStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 640)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1249, 39)
        Me.StatusStrip.TabIndex = 3
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'FilePathStatusLabel
        '
        Me.FilePathStatusLabel.Name = "FilePathStatusLabel"
        Me.FilePathStatusLabel.Size = New System.Drawing.Size(208, 30)
        Me.FilePathStatusLabel.Text = "ToolStripStatusLabel1"
        '
        'DataForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1249, 679)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.ButtonGroupBox)
        Me.Controls.Add(Me.GraphPictureBox)
        Me.Controls.Add(Me.TopMenuStrip)
        Me.MainMenuStrip = Me.TopMenuStrip
        Me.Name = "DataForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Graph That Data"
        CType(Me.GraphPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ButtonGroupBox.ResumeLayout(False)
        Me.TopMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GraphPictureBox As PictureBox
    Friend WithEvents ButtonGroupBox As GroupBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TopMenuStrip As MenuStrip
    Friend WithEvents FileTopStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents FilePathStatusLabel As ToolStripStatusLabel
End Class
