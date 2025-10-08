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
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ExitButton)
        Me.GroupBox1.Controls.Add(Me.ClearButton)
        Me.GroupBox1.Location = New System.Drawing.Point(475, 310)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(313, 128)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
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
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(157, 28)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(145, 79)
        Me.ExitButton.TabIndex = 1
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'GraphicsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "GraphicsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Graphics!"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents ClearButton As Button
End Class
