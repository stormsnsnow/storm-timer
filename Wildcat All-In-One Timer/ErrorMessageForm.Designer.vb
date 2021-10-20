<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ErrorMessageForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ErrorMessageForm))
        Me.StopWDLCTImage = New System.Windows.Forms.PictureBox()
        Me.ConciseErrorLabel = New System.Windows.Forms.Label()
        Me.DetailedErrorLabel = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.StopWDLCTImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StopWDLCTImage
        '
        Me.StopWDLCTImage.Image = CType(resources.GetObject("StopWDLCTImage.Image"), System.Drawing.Image)
        Me.StopWDLCTImage.Location = New System.Drawing.Point(12, 11)
        Me.StopWDLCTImage.Name = "StopWDLCTImage"
        Me.StopWDLCTImage.Size = New System.Drawing.Size(64, 59)
        Me.StopWDLCTImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.StopWDLCTImage.TabIndex = 0
        Me.StopWDLCTImage.TabStop = False
        '
        'ConciseErrorLabel
        '
        Me.ConciseErrorLabel.AutoSize = True
        Me.ConciseErrorLabel.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConciseErrorLabel.Location = New System.Drawing.Point(83, 12)
        Me.ConciseErrorLabel.Name = "ConciseErrorLabel"
        Me.ConciseErrorLabel.Size = New System.Drawing.Size(174, 22)
        Me.ConciseErrorLabel.TabIndex = 1
        Me.ConciseErrorLabel.Text = "An Error Occured!"
        '
        'DetailedErrorLabel
        '
        Me.DetailedErrorLabel.AutoSize = True
        Me.DetailedErrorLabel.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailedErrorLabel.Location = New System.Drawing.Point(85, 31)
        Me.DetailedErrorLabel.Name = "DetailedErrorLabel"
        Me.DetailedErrorLabel.Size = New System.Drawing.Size(205, 28)
        Me.DetailedErrorLabel.TabIndex = 2
        Me.DetailedErrorLabel.Text = "Text exception" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please click Exit to exit the program."
        '
        'ExitButton
        '
        Me.ExitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExitButton.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(412, 39)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 49)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(331, 39)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 49)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "See Details"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ErrorMessageForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 100)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.DetailedErrorLabel)
        Me.Controls.Add(Me.ConciseErrorLabel)
        Me.Controls.Add(Me.StopWDLCTImage)
        Me.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ErrorMessageForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BreakTime - Error Message"
        CType(Me.StopWDLCTImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StopWDLCTImage As PictureBox
    Friend WithEvents ConciseErrorLabel As Label
    Friend WithEvents DetailedErrorLabel As Label
    Friend WithEvents ExitButton As Button
    Friend WithEvents Button1 As Button
End Class
