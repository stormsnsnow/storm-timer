<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BreakForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BreakForm))
        Me.BreakTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lbldate = New System.Windows.Forms.Label()
        Me.lblbackon = New System.Windows.Forms.Label()
        Me.lblhour = New System.Windows.Forms.Label()
        Me.lblwait = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BreakPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.lblsecondsbreak = New System.Windows.Forms.Label()
        Me.lblsecondbreak = New System.Windows.Forms.Label()
        Me.lblminutesandbreak = New System.Windows.Forms.Label()
        Me.lblhoursandbreak = New System.Windows.Forms.Label()
        Me.lblsec = New System.Windows.Forms.Label()
        Me.lblminute = New System.Windows.Forms.Label()
        Me.lblhourandbreak = New System.Windows.Forms.Label()
        Me.lblminuteandbreak = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UnlockButton = New System.Windows.Forms.Button()
        Me.PauseButton = New System.Windows.Forms.Button()
        Me.BreakPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BreakTimer
        '
        Me.BreakTimer.Interval = 1000
        '
        'lbldate
        '
        Me.lbldate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbldate.AutoSize = True
        Me.lbldate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbldate.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(34, 67)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(217, 22)
        Me.lbldate.TabIndex = 58
        Me.lbldate.Text = "Monday January 1 2022"
        Me.lbldate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblbackon
        '
        Me.lblbackon.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblbackon.AutoSize = True
        Me.lblbackon.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblbackon.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbackon.Location = New System.Drawing.Point(218, 46)
        Me.lblbackon.Name = "lblbackon"
        Me.lblbackon.Size = New System.Drawing.Size(50, 22)
        Me.lblbackon.TabIndex = 57
        Me.lblbackon.Text = "until"
        '
        'lblhour
        '
        Me.lblhour.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblhour.AutoSize = True
        Me.lblhour.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblhour.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhour.Location = New System.Drawing.Point(75, 25)
        Me.lblhour.Name = "lblhour"
        Me.lblhour.Size = New System.Drawing.Size(22, 22)
        Me.lblhour.TabIndex = 56
        Me.lblhour.Text = "--"
        '
        'lblwait
        '
        Me.lblwait.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblwait.AutoSize = True
        Me.lblwait.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblwait.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwait.Location = New System.Drawing.Point(14, 25)
        Me.lblwait.Name = "lblwait"
        Me.lblwait.Size = New System.Drawing.Size(51, 22)
        Me.lblwait.TabIndex = 55
        Me.lblwait.Text = "Wait"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "pause.ico")
        Me.ImageList1.Images.SetKeyName(1, "stop.ico")
        '
        'BreakPanel
        '
        Me.BreakPanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BreakPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BreakPanel.Controls.Add(Me.Label1)
        Me.BreakPanel.Controls.Add(Me.lbltime)
        Me.BreakPanel.Controls.Add(Me.lblsecondsbreak)
        Me.BreakPanel.Controls.Add(Me.lblsecondbreak)
        Me.BreakPanel.Controls.Add(Me.lblminutesandbreak)
        Me.BreakPanel.Controls.Add(Me.lblhoursandbreak)
        Me.BreakPanel.Controls.Add(Me.lblsec)
        Me.BreakPanel.Controls.Add(Me.lblminute)
        Me.BreakPanel.Controls.Add(Me.lblwait)
        Me.BreakPanel.Controls.Add(Me.lblhour)
        Me.BreakPanel.Controls.Add(Me.lblbackon)
        Me.BreakPanel.Controls.Add(Me.lbldate)
        Me.BreakPanel.Controls.Add(Me.lblhourandbreak)
        Me.BreakPanel.Controls.Add(Me.lblminuteandbreak)
        Me.BreakPanel.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BreakPanel.Location = New System.Drawing.Point(177, 220)
        Me.BreakPanel.Name = "BreakPanel"
        Me.BreakPanel.Size = New System.Drawing.Size(524, 93)
        Me.BreakPanel.TabIndex = 63
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(176, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 22)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Take a break!"
        '
        'lbltime
        '
        Me.lbltime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbltime.AutoSize = True
        Me.lbltime.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbltime.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.Location = New System.Drawing.Point(278, 67)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(137, 22)
        Me.lbltime.TabIndex = 75
        Me.lbltime.Text = "at 12:00:00 AM"
        Me.lbltime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblsecondsbreak
        '
        Me.lblsecondsbreak.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblsecondsbreak.AutoSize = True
        Me.lblsecondsbreak.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblsecondsbreak.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsecondsbreak.Location = New System.Drawing.Point(415, 25)
        Me.lblsecondsbreak.Name = "lblsecondsbreak"
        Me.lblsecondsbreak.Size = New System.Drawing.Size(90, 22)
        Me.lblsecondsbreak.TabIndex = 73
        Me.lblsecondsbreak.Text = "seconds"
        '
        'lblsecondbreak
        '
        Me.lblsecondbreak.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblsecondbreak.AutoSize = True
        Me.lblsecondbreak.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblsecondbreak.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsecondbreak.Location = New System.Drawing.Point(415, 25)
        Me.lblsecondbreak.Name = "lblsecondbreak"
        Me.lblsecondbreak.Size = New System.Drawing.Size(79, 22)
        Me.lblsecondbreak.TabIndex = 72
        Me.lblsecondbreak.Text = "second"
        '
        'lblminutesandbreak
        '
        Me.lblminutesandbreak.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblminutesandbreak.AutoSize = True
        Me.lblminutesandbreak.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblminutesandbreak.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblminutesandbreak.Location = New System.Drawing.Point(250, 25)
        Me.lblminutesandbreak.Name = "lblminutesandbreak"
        Me.lblminutesandbreak.Size = New System.Drawing.Size(124, 22)
        Me.lblminutesandbreak.TabIndex = 70
        Me.lblminutesandbreak.Text = "minutes and"
        '
        'lblhoursandbreak
        '
        Me.lblhoursandbreak.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblhoursandbreak.AutoSize = True
        Me.lblhoursandbreak.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblhoursandbreak.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhoursandbreak.Location = New System.Drawing.Point(107, 25)
        Me.lblhoursandbreak.Name = "lblhoursandbreak"
        Me.lblhoursandbreak.Size = New System.Drawing.Size(101, 22)
        Me.lblhoursandbreak.TabIndex = 68
        Me.lblhoursandbreak.Text = "hours and"
        '
        'lblsec
        '
        Me.lblsec.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblsec.AutoSize = True
        Me.lblsec.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblsec.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsec.Location = New System.Drawing.Point(384, 25)
        Me.lblsec.Name = "lblsec"
        Me.lblsec.Size = New System.Drawing.Size(22, 22)
        Me.lblsec.TabIndex = 67
        Me.lblsec.Text = "--"
        '
        'lblminute
        '
        Me.lblminute.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblminute.AutoSize = True
        Me.lblminute.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblminute.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblminute.Location = New System.Drawing.Point(218, 25)
        Me.lblminute.Name = "lblminute"
        Me.lblminute.Size = New System.Drawing.Size(22, 22)
        Me.lblminute.TabIndex = 66
        Me.lblminute.Text = "--"
        '
        'lblhourandbreak
        '
        Me.lblhourandbreak.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblhourandbreak.AutoSize = True
        Me.lblhourandbreak.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblhourandbreak.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhourandbreak.Location = New System.Drawing.Point(107, 25)
        Me.lblhourandbreak.Name = "lblhourandbreak"
        Me.lblhourandbreak.Size = New System.Drawing.Size(90, 22)
        Me.lblhourandbreak.TabIndex = 69
        Me.lblhourandbreak.Text = "hour and"
        '
        'lblminuteandbreak
        '
        Me.lblminuteandbreak.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblminuteandbreak.AutoSize = True
        Me.lblminuteandbreak.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblminuteandbreak.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblminuteandbreak.Location = New System.Drawing.Point(250, 25)
        Me.lblminuteandbreak.Name = "lblminuteandbreak"
        Me.lblminuteandbreak.Size = New System.Drawing.Size(113, 22)
        Me.lblminuteandbreak.TabIndex = 71
        Me.lblminuteandbreak.Text = "minute and"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.UnlockButton)
        Me.Panel1.Controls.Add(Me.PauseButton)
        Me.Panel1.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(283, 319)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(269, 64)
        Me.Panel1.TabIndex = 77
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(66, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 22)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Break Options"
        '
        'UnlockButton
        '
        Me.UnlockButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.UnlockButton.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnlockButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UnlockButton.ImageKey = "stop.ico"
        Me.UnlockButton.ImageList = Me.ImageList1
        Me.UnlockButton.Location = New System.Drawing.Point(162, 29)
        Me.UnlockButton.Name = "UnlockButton"
        Me.UnlockButton.Size = New System.Drawing.Size(102, 30)
        Me.UnlockButton.TabIndex = 76
        Me.UnlockButton.Text = "Unlock Break"
        Me.UnlockButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UnlockButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.UnlockButton.UseVisualStyleBackColor = True
        '
        'PauseButton
        '
        Me.PauseButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PauseButton.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PauseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PauseButton.ImageKey = "pause.ico"
        Me.PauseButton.ImageList = Me.ImageList1
        Me.PauseButton.Location = New System.Drawing.Point(3, 29)
        Me.PauseButton.Name = "PauseButton"
        Me.PauseButton.Size = New System.Drawing.Size(105, 30)
        Me.PauseButton.TabIndex = 75
        Me.PauseButton.Text = "Pause Break"
        Me.PauseButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PauseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.PauseButton.UseVisualStyleBackColor = True
        '
        'BreakForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(853, 572)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BreakPanel)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BreakForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Breaktime in Progress"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.BreakPanel.ResumeLayout(False)
        Me.BreakPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BreakTimer As Timer
    Friend WithEvents lbldate As Label
    Friend WithEvents lblbackon As Label
    Friend WithEvents lblhour As Label
    Friend WithEvents lblwait As Label
    Friend WithEvents BreakPanel As Panel
    Friend WithEvents lblsecondsbreak As Label
    Friend WithEvents lblsecondbreak As Label
    Friend WithEvents lblminuteandbreak As Label
    Friend WithEvents lblminutesandbreak As Label
    Friend WithEvents lblhourandbreak As Label
    Friend WithEvents lblhoursandbreak As Label
    Friend WithEvents lblsec As Label
    Friend WithEvents lblminute As Label
    Friend WithEvents lbltime As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents UnlockButton As Button
    Friend WithEvents PauseButton As Button
End Class