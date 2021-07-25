<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UnhandledExceptionForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UnhandledExceptionForm))
        Me.StopWDLCTImage = New System.Windows.Forms.PictureBox()
        Me.ConciseErrorLabel = New System.Windows.Forms.Label()
        Me.DetailedErrorLabel = New System.Windows.Forms.Label()
        Me.ExceptionLabel = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        CType(Me.StopWDLCTImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StopWDLCTImage
        '
        Me.StopWDLCTImage.Image = CType(resources.GetObject("StopWDLCTImage.Image"), System.Drawing.Image)
        Me.StopWDLCTImage.Location = New System.Drawing.Point(12, 12)
        Me.StopWDLCTImage.Name = "StopWDLCTImage"
        Me.StopWDLCTImage.Size = New System.Drawing.Size(64, 64)
        Me.StopWDLCTImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.StopWDLCTImage.TabIndex = 0
        Me.StopWDLCTImage.TabStop = False
        '
        'ConciseErrorLabel
        '
        Me.ConciseErrorLabel.AutoSize = True
        Me.ConciseErrorLabel.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConciseErrorLabel.ForeColor = System.Drawing.Color.Gold
        Me.ConciseErrorLabel.Location = New System.Drawing.Point(83, 13)
        Me.ConciseErrorLabel.Name = "ConciseErrorLabel"
        Me.ConciseErrorLabel.Size = New System.Drawing.Size(356, 19)
        Me.ConciseErrorLabel.TabIndex = 1
        Me.ConciseErrorLabel.Text = "Unfortunately, BreakTime must close"
        '
        'DetailedErrorLabel
        '
        Me.DetailedErrorLabel.AutoSize = True
        Me.DetailedErrorLabel.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailedErrorLabel.ForeColor = System.Drawing.Color.Gold
        Me.DetailedErrorLabel.Location = New System.Drawing.Point(82, 39)
        Me.DetailedErrorLabel.Name = "DetailedErrorLabel"
        Me.DetailedErrorLabel.Size = New System.Drawing.Size(465, 24)
        Me.DetailedErrorLabel.TabIndex = 2
        Me.DetailedErrorLabel.Text = "An unhandled exception has occured that causes the application to close. We are s" &
    "orry for the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "inconvience."
        '
        'ExceptionLabel
        '
        Me.ExceptionLabel.AutoSize = True
        Me.ExceptionLabel.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExceptionLabel.ForeColor = System.Drawing.Color.Gold
        Me.ExceptionLabel.Location = New System.Drawing.Point(81, 63)
        Me.ExceptionLabel.Name = "ExceptionLabel"
        Me.ExceptionLabel.Size = New System.Drawing.Size(183, 12)
        Me.ExceptionLabel.TabIndex = 4
        Me.ExceptionLabel.Text = "Please click to see exception details."
        '
        'ExitButton
        '
        Me.ExitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExitButton.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.ForeColor = System.Drawing.Color.Gold
        Me.ExitButton.Location = New System.Drawing.Point(480, 70)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'UnhandledExceptionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(567, 105)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ExceptionLabel)
        Me.Controls.Add(Me.DetailedErrorLabel)
        Me.Controls.Add(Me.ConciseErrorLabel)
        Me.Controls.Add(Me.StopWDLCTImage)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UnhandledExceptionForm"
        Me.Text = "An Error Ocurred"
        CType(Me.StopWDLCTImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StopWDLCTImage As PictureBox
    Friend WithEvents ConciseErrorLabel As Label
    Friend WithEvents DetailedErrorLabel As Label
    Friend WithEvents ExceptionLabel As Label
    Friend WithEvents ExitButton As Button
End Class
