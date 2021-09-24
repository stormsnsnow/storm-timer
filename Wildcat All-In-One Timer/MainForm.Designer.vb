<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.BreakTimer = New System.Windows.Forms.Timer(Me.components)
        Me.IconsIL = New System.Windows.Forms.ImageList(Me.components)
        Me.TimerTimer = New System.Windows.Forms.Timer(Me.components)
        Me.tBeep = New System.Windows.Forms.Timer(Me.components)
        Me.TitlePanel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TimeLabelYD = New System.Windows.Forms.Label()
        Me.SettingsButton = New System.Windows.Forms.Button()
        Me.DateLabelYD = New System.Windows.Forms.Label()
        Me.lblwelcome = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.YDTimer = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIconWDLCT = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimeBomb = New System.Windows.Forms.Timer(Me.components)
        Me.TimerTab = New System.Windows.Forms.TabPage()
        Me.TSFGroupBoxT = New System.Windows.Forms.GroupBox()
        Me.lblsfsecondstime = New System.Windows.Forms.Label()
        Me.TSFSecondLabelT = New System.Windows.Forms.Label()
        Me.SFMinAndLabelT = New System.Windows.Forms.Label()
        Me.TSFMinsAndLabelT = New System.Windows.Forms.Label()
        Me.TSFSecondIndicatorLabelT = New System.Windows.Forms.Label()
        Me.TSFMinIndicatorLabelT = New System.Windows.Forms.Label()
        Me.TSFHourIndicatorLabelT = New System.Windows.Forms.Label()
        Me.lblsfhoursandtime = New System.Windows.Forms.Label()
        Me.TSFHoursAndLabelT = New System.Windows.Forms.Label()
        Me.StatusGroupBoxT = New System.Windows.Forms.GroupBox()
        Me.SecondsLabelT = New System.Windows.Forms.Label()
        Me.lblsecondtime = New System.Windows.Forms.Label()
        Me.lblminuteandtime = New System.Windows.Forms.Label()
        Me.lblminutesandtime = New System.Windows.Forms.Label()
        Me.lblsectime = New System.Windows.Forms.Label()
        Me.lblmintime = New System.Windows.Forms.Label()
        Me.lblhourtime = New System.Windows.Forms.Label()
        Me.lblhourandtime = New System.Windows.Forms.Label()
        Me.lblhoursandtime = New System.Windows.Forms.Label()
        Me.StartTimeButton = New System.Windows.Forms.Button()
        Me.StopTimeButton = New System.Windows.Forms.Button()
        Me.PauseButtonT = New System.Windows.Forms.Button()
        Me.nudSec = New System.Windows.Forms.NumericUpDown()
        Me.nudMin = New System.Windows.Forms.NumericUpDown()
        Me.nudHour = New System.Windows.Forms.NumericUpDown()
        Me.ResumeTimeButton = New System.Windows.Forms.Button()
        Me.BTime = New System.Windows.Forms.TabPage()
        Me.nudb1sec = New System.Windows.Forms.NumericUpDown()
        Me.BreakNowButtonBt = New System.Windows.Forms.Button()
        Me.BreakLabelBT = New System.Windows.Forms.Label()
        Me.B1HourNudBT = New System.Windows.Forms.NumericUpDown()
        Me.nudb1min = New System.Windows.Forms.NumericUpDown()
        Me.BreakTimerTab = New System.Windows.Forms.TabPage()
        Me.StartButtonBT = New System.Windows.Forms.Button()
        Me.btnResume = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.PauseButtonBT = New System.Windows.Forms.Button()
        Me.BSTGroupBoxBT = New System.Windows.Forms.GroupBox()
        Me.BSTSecondsLabelBT = New System.Windows.Forms.Label()
        Me.BSTSecondLabelBT = New System.Windows.Forms.Label()
        Me.BSTMinAndLabelBT = New System.Windows.Forms.Label()
        Me.BSTMinsAndLabelBT = New System.Windows.Forms.Label()
        Me.BSTSecondIndicatorLabelBT = New System.Windows.Forms.Label()
        Me.BSTMinIndicatorLabelBT = New System.Windows.Forms.Label()
        Me.BSTHourIndicatorLabelBT = New System.Windows.Forms.Label()
        Me.BSTHourAndLabelBT = New System.Windows.Forms.Label()
        Me.BSTHoursAndLabelBT = New System.Windows.Forms.Label()
        Me.TSFGroupBoxBT = New System.Windows.Forms.GroupBox()
        Me.TSFSecondsLabelBT = New System.Windows.Forms.Label()
        Me.TSFSecondLabelBT = New System.Windows.Forms.Label()
        Me.TSFMinAndLabelBT = New System.Windows.Forms.Label()
        Me.TSFMinsAndLabelBT = New System.Windows.Forms.Label()
        Me.TSFSecondIndicatorLabelBT = New System.Windows.Forms.Label()
        Me.TSFMinIndicatorLabelBT = New System.Windows.Forms.Label()
        Me.TSFHourIndicatorLabelBT = New System.Windows.Forms.Label()
        Me.TSFHourAndLabelBT = New System.Windows.Forms.Label()
        Me.TSFHoursAndLabelBT = New System.Windows.Forms.Label()
        Me.VisualRbBt = New System.Windows.Forms.RadioButton()
        Me.nudTimeHour = New System.Windows.Forms.NumericUpDown()
        Me.StatusGroupBoxBT = New System.Windows.Forms.GroupBox()
        Me.lblsecondsbreak = New System.Windows.Forms.Label()
        Me.lblsecondbreak = New System.Windows.Forms.Label()
        Me.lblminuteandbreak = New System.Windows.Forms.Label()
        Me.lblminutesandbreak = New System.Windows.Forms.Label()
        Me.lblsec = New System.Windows.Forms.Label()
        Me.lblminute = New System.Windows.Forms.Label()
        Me.HourLabelBT = New System.Windows.Forms.Label()
        Me.HourAndBreakLabelBT = New System.Windows.Forms.Label()
        Me.lblhoursandbreak = New System.Windows.Forms.Label()
        Me.AudioRbBt = New System.Windows.Forms.RadioButton()
        Me.nudTimeBreakHour = New System.Windows.Forms.NumericUpDown()
        Me.TimeLabelBt = New System.Windows.Forms.Label()
        Me.nudTimeBreakMin = New System.Windows.Forms.NumericUpDown()
        Me.MWLabelBt = New System.Windows.Forms.Label()
        Me.nudTimeSec = New System.Windows.Forms.NumericUpDown()
        Me.MinWarnNudBt = New System.Windows.Forms.NumericUpDown()
        Me.nudTimeBreakSec = New System.Windows.Forms.NumericUpDown()
        Me.BreakTimerALabelBT = New System.Windows.Forms.Label()
        Me.nudTimeMin = New System.Windows.Forms.NumericUpDown()
        Me.TimerControl = New System.Windows.Forms.TabControl()
        Me.TitlePanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TimerTab.SuspendLayout()
        Me.TSFGroupBoxT.SuspendLayout()
        Me.StatusGroupBoxT.SuspendLayout()
        CType(Me.nudSec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHour, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BTime.SuspendLayout()
        CType(Me.nudb1sec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.B1HourNudBT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudb1min, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BreakTimerTab.SuspendLayout()
        Me.BSTGroupBoxBT.SuspendLayout()
        Me.TSFGroupBoxBT.SuspendLayout()
        CType(Me.nudTimeHour, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusGroupBoxBT.SuspendLayout()
        CType(Me.nudTimeBreakHour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTimeBreakMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTimeSec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinWarnNudBt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTimeBreakSec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTimeMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TimerControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'BreakTimer
        '
        Me.BreakTimer.Interval = 1000
        '
        'IconsIL
        '
        Me.IconsIL.ImageStream = CType(resources.GetObject("IconsIL.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IconsIL.TransparentColor = System.Drawing.Color.Transparent
        Me.IconsIL.Images.SetKeyName(0, "btimelogo.png")
        Me.IconsIL.Images.SetKeyName(1, "break.ico")
        Me.IconsIL.Images.SetKeyName(2, "time.ico")
        Me.IconsIL.Images.SetKeyName(3, "stop.ico")
        Me.IconsIL.Images.SetKeyName(4, "pause.ico")
        Me.IconsIL.Images.SetKeyName(5, "play.ico")
        Me.IconsIL.Images.SetKeyName(6, "settings.ico")
        '
        'TimerTimer
        '
        Me.TimerTimer.Interval = 1000
        '
        'tBeep
        '
        Me.tBeep.Interval = 1000
        '
        'TitlePanel
        '
        Me.TitlePanel.BackColor = System.Drawing.Color.Transparent
        Me.TitlePanel.BackgroundImage = CType(resources.GetObject("TitlePanel.BackgroundImage"), System.Drawing.Image)
        Me.TitlePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TitlePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TitlePanel.Controls.Add(Me.PictureBox1)
        Me.TitlePanel.Controls.Add(Me.TimeLabelYD)
        Me.TitlePanel.Controls.Add(Me.SettingsButton)
        Me.TitlePanel.Controls.Add(Me.DateLabelYD)
        Me.TitlePanel.Controls.Add(Me.lblwelcome)
        Me.TitlePanel.Controls.Add(Me.lblVersion)
        Me.TitlePanel.Controls.Add(Me.lblName)
        Me.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitlePanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitlePanel.Location = New System.Drawing.Point(0, 0)
        Me.TitlePanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TitlePanel.Name = "TitlePanel"
        Me.TitlePanel.Size = New System.Drawing.Size(637, 99)
        Me.TitlePanel.TabIndex = 25
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(11, 22)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 85
        Me.PictureBox1.TabStop = False
        '
        'TimeLabelYD
        '
        Me.TimeLabelYD.AutoSize = True
        Me.TimeLabelYD.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLabelYD.Location = New System.Drawing.Point(351, 46)
        Me.TimeLabelYD.Name = "TimeLabelYD"
        Me.TimeLabelYD.Size = New System.Drawing.Size(71, 14)
        Me.TimeLabelYD.TabIndex = 84
        Me.TimeLabelYD.Text = "12:00:00 AM"
        '
        'SettingsButton
        '
        Me.SettingsButton.BackColor = System.Drawing.Color.Transparent
        Me.SettingsButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.SettingsButton.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SettingsButton.ImageKey = "settings.ico"
        Me.SettingsButton.ImageList = Me.IconsIL
        Me.SettingsButton.Location = New System.Drawing.Point(505, 0)
        Me.SettingsButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SettingsButton.Name = "SettingsButton"
        Me.SettingsButton.Size = New System.Drawing.Size(130, 97)
        Me.SettingsButton.TabIndex = 83
        Me.SettingsButton.Text = "Settings"
        Me.SettingsButton.UseVisualStyleBackColor = False
        '
        'DateLabelYD
        '
        Me.DateLabelYD.AutoSize = True
        Me.DateLabelYD.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLabelYD.Location = New System.Drawing.Point(261, 34)
        Me.DateLabelYD.Name = "DateLabelYD"
        Me.DateLabelYD.Size = New System.Drawing.Size(84, 14)
        Me.DateLabelYD.TabIndex = 28
        Me.DateLabelYD.Text = "january 1, 2022"
        '
        'lblwelcome
        '
        Me.lblwelcome.AutoSize = True
        Me.lblwelcome.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwelcome.Location = New System.Drawing.Point(263, 9)
        Me.lblwelcome.Name = "lblwelcome"
        Me.lblwelcome.Size = New System.Drawing.Size(159, 25)
        Me.lblwelcome.TabIndex = 27
        Me.lblwelcome.Text = "welcome, user"
        Me.lblwelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(76, 32)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(169, 42)
        Me.lblVersion.TabIndex = 26
        Me.lblVersion.Text = "v21H2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Beta 3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Released September 24, 2021"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Helvetica", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(90, 8)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(121, 25)
        Me.lblName.TabIndex = 25
        Me.lblName.Text = "BreakTime"
        '
        'YDTimer
        '
        Me.YDTimer.Interval = 1000
        '
        'NotifyIconWDLCT
        '
        Me.NotifyIconWDLCT.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIconWDLCT.Icon = CType(resources.GetObject("NotifyIconWDLCT.Icon"), System.Drawing.Icon)
        Me.NotifyIconWDLCT.Text = "BreakTime is currently running"
        Me.NotifyIconWDLCT.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ChangeSettingsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(166, 70)
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'ChangeSettingsToolStripMenuItem
        '
        Me.ChangeSettingsToolStripMenuItem.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangeSettingsToolStripMenuItem.Name = "ChangeSettingsToolStripMenuItem"
        Me.ChangeSettingsToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ChangeSettingsToolStripMenuItem.Text = "Change Settings"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'TimeBomb
        '
        Me.TimeBomb.Interval = 1000
        '
        'TimerTab
        '
        Me.TimerTab.Controls.Add(Me.TSFGroupBoxT)
        Me.TimerTab.Controls.Add(Me.StatusGroupBoxT)
        Me.TimerTab.Controls.Add(Me.StartTimeButton)
        Me.TimerTab.Controls.Add(Me.StopTimeButton)
        Me.TimerTab.Controls.Add(Me.PauseButtonT)
        Me.TimerTab.Controls.Add(Me.nudSec)
        Me.TimerTab.Controls.Add(Me.nudMin)
        Me.TimerTab.Controls.Add(Me.nudHour)
        Me.TimerTab.Controls.Add(Me.ResumeTimeButton)
        Me.TimerTab.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimerTab.ImageIndex = 2
        Me.TimerTab.Location = New System.Drawing.Point(4, 23)
        Me.TimerTab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TimerTab.Name = "TimerTab"
        Me.TimerTab.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TimerTab.Size = New System.Drawing.Size(629, 259)
        Me.TimerTab.TabIndex = 1
        Me.TimerTab.Text = "Timer"
        '
        'TSFGroupBoxT
        '
        Me.TSFGroupBoxT.Controls.Add(Me.lblsfsecondstime)
        Me.TSFGroupBoxT.Controls.Add(Me.TSFSecondLabelT)
        Me.TSFGroupBoxT.Controls.Add(Me.SFMinAndLabelT)
        Me.TSFGroupBoxT.Controls.Add(Me.TSFMinsAndLabelT)
        Me.TSFGroupBoxT.Controls.Add(Me.TSFSecondIndicatorLabelT)
        Me.TSFGroupBoxT.Controls.Add(Me.TSFMinIndicatorLabelT)
        Me.TSFGroupBoxT.Controls.Add(Me.TSFHourIndicatorLabelT)
        Me.TSFGroupBoxT.Controls.Add(Me.lblsfhoursandtime)
        Me.TSFGroupBoxT.Controls.Add(Me.TSFHoursAndLabelT)
        Me.TSFGroupBoxT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TSFGroupBoxT.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSFGroupBoxT.Location = New System.Drawing.Point(262, 101)
        Me.TSFGroupBoxT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TSFGroupBoxT.Name = "TSFGroupBoxT"
        Me.TSFGroupBoxT.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TSFGroupBoxT.Size = New System.Drawing.Size(131, 53)
        Me.TSFGroupBoxT.TabIndex = 92
        Me.TSFGroupBoxT.TabStop = False
        Me.TSFGroupBoxT.Text = "Set For"
        '
        'lblsfsecondstime
        '
        Me.lblsfsecondstime.AutoSize = True
        Me.lblsfsecondstime.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsfsecondstime.Location = New System.Drawing.Point(36, 36)
        Me.lblsfsecondstime.Name = "lblsfsecondstime"
        Me.lblsfsecondstime.Size = New System.Drawing.Size(52, 14)
        Me.lblsfsecondstime.TabIndex = 91
        Me.lblsfsecondstime.Text = "seconds"
        '
        'TSFSecondLabelT
        '
        Me.TSFSecondLabelT.AutoSize = True
        Me.TSFSecondLabelT.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSFSecondLabelT.Location = New System.Drawing.Point(47, 36)
        Me.TSFSecondLabelT.Name = "TSFSecondLabelT"
        Me.TSFSecondLabelT.Size = New System.Drawing.Size(46, 14)
        Me.TSFSecondLabelT.TabIndex = 90
        Me.TSFSecondLabelT.Text = "second"
        '
        'SFMinAndLabelT
        '
        Me.SFMinAndLabelT.AutoSize = True
        Me.SFMinAndLabelT.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SFMinAndLabelT.Location = New System.Drawing.Point(36, 24)
        Me.SFMinAndLabelT.Name = "SFMinAndLabelT"
        Me.SFMinAndLabelT.Size = New System.Drawing.Size(65, 14)
        Me.SFMinAndLabelT.TabIndex = 89
        Me.SFMinAndLabelT.Text = "minute and"
        Me.SFMinAndLabelT.Visible = False
        '
        'TSFMinsAndLabelT
        '
        Me.TSFMinsAndLabelT.AutoSize = True
        Me.TSFMinsAndLabelT.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSFMinsAndLabelT.Location = New System.Drawing.Point(36, 24)
        Me.TSFMinsAndLabelT.Name = "TSFMinsAndLabelT"
        Me.TSFMinsAndLabelT.Size = New System.Drawing.Size(71, 14)
        Me.TSFMinsAndLabelT.TabIndex = 88
        Me.TSFMinsAndLabelT.Text = "minutes and"
        '
        'TSFSecondIndicatorLabelT
        '
        Me.TSFSecondIndicatorLabelT.AutoSize = True
        Me.TSFSecondIndicatorLabelT.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSFSecondIndicatorLabelT.Location = New System.Drawing.Point(14, 36)
        Me.TSFSecondIndicatorLabelT.Name = "TSFSecondIndicatorLabelT"
        Me.TSFSecondIndicatorLabelT.Size = New System.Drawing.Size(13, 14)
        Me.TSFSecondIndicatorLabelT.TabIndex = 85
        Me.TSFSecondIndicatorLabelT.Text = "--"
        '
        'TSFMinIndicatorLabelT
        '
        Me.TSFMinIndicatorLabelT.AutoSize = True
        Me.TSFMinIndicatorLabelT.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSFMinIndicatorLabelT.Location = New System.Drawing.Point(14, 25)
        Me.TSFMinIndicatorLabelT.Name = "TSFMinIndicatorLabelT"
        Me.TSFMinIndicatorLabelT.Size = New System.Drawing.Size(13, 14)
        Me.TSFMinIndicatorLabelT.TabIndex = 84
        Me.TSFMinIndicatorLabelT.Text = "--"
        '
        'TSFHourIndicatorLabelT
        '
        Me.TSFHourIndicatorLabelT.AutoSize = True
        Me.TSFHourIndicatorLabelT.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSFHourIndicatorLabelT.Location = New System.Drawing.Point(14, 13)
        Me.TSFHourIndicatorLabelT.Name = "TSFHourIndicatorLabelT"
        Me.TSFHourIndicatorLabelT.Size = New System.Drawing.Size(13, 14)
        Me.TSFHourIndicatorLabelT.TabIndex = 83
        Me.TSFHourIndicatorLabelT.Text = "--"
        '
        'lblsfhoursandtime
        '
        Me.lblsfhoursandtime.AutoSize = True
        Me.lblsfhoursandtime.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsfhoursandtime.Location = New System.Drawing.Point(36, 13)
        Me.lblsfhoursandtime.Name = "lblsfhoursandtime"
        Me.lblsfhoursandtime.Size = New System.Drawing.Size(52, 14)
        Me.lblsfhoursandtime.TabIndex = 87
        Me.lblsfhoursandtime.Text = "hour and"
        Me.lblsfhoursandtime.Visible = False
        '
        'TSFHoursAndLabelT
        '
        Me.TSFHoursAndLabelT.AutoSize = True
        Me.TSFHoursAndLabelT.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSFHoursAndLabelT.Location = New System.Drawing.Point(36, 13)
        Me.TSFHoursAndLabelT.Name = "TSFHoursAndLabelT"
        Me.TSFHoursAndLabelT.Size = New System.Drawing.Size(58, 14)
        Me.TSFHoursAndLabelT.TabIndex = 86
        Me.TSFHoursAndLabelT.Text = "hours and"
        '
        'StatusGroupBoxT
        '
        Me.StatusGroupBoxT.Controls.Add(Me.SecondsLabelT)
        Me.StatusGroupBoxT.Controls.Add(Me.lblsecondtime)
        Me.StatusGroupBoxT.Controls.Add(Me.lblminuteandtime)
        Me.StatusGroupBoxT.Controls.Add(Me.lblminutesandtime)
        Me.StatusGroupBoxT.Controls.Add(Me.lblsectime)
        Me.StatusGroupBoxT.Controls.Add(Me.lblmintime)
        Me.StatusGroupBoxT.Controls.Add(Me.lblhourtime)
        Me.StatusGroupBoxT.Controls.Add(Me.lblhourandtime)
        Me.StatusGroupBoxT.Controls.Add(Me.lblhoursandtime)
        Me.StatusGroupBoxT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StatusGroupBoxT.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusGroupBoxT.Location = New System.Drawing.Point(124, 101)
        Me.StatusGroupBoxT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StatusGroupBoxT.Name = "StatusGroupBoxT"
        Me.StatusGroupBoxT.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StatusGroupBoxT.Size = New System.Drawing.Size(131, 53)
        Me.StatusGroupBoxT.TabIndex = 85
        Me.StatusGroupBoxT.TabStop = False
        Me.StatusGroupBoxT.Text = "Status"
        '
        'SecondsLabelT
        '
        Me.SecondsLabelT.AutoSize = True
        Me.SecondsLabelT.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecondsLabelT.Location = New System.Drawing.Point(36, 36)
        Me.SecondsLabelT.Name = "SecondsLabelT"
        Me.SecondsLabelT.Size = New System.Drawing.Size(52, 14)
        Me.SecondsLabelT.TabIndex = 91
        Me.SecondsLabelT.Text = "seconds"
        '
        'lblsecondtime
        '
        Me.lblsecondtime.AutoSize = True
        Me.lblsecondtime.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsecondtime.Location = New System.Drawing.Point(47, 36)
        Me.lblsecondtime.Name = "lblsecondtime"
        Me.lblsecondtime.Size = New System.Drawing.Size(46, 14)
        Me.lblsecondtime.TabIndex = 90
        Me.lblsecondtime.Text = "second"
        '
        'lblminuteandtime
        '
        Me.lblminuteandtime.AutoSize = True
        Me.lblminuteandtime.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblminuteandtime.Location = New System.Drawing.Point(36, 24)
        Me.lblminuteandtime.Name = "lblminuteandtime"
        Me.lblminuteandtime.Size = New System.Drawing.Size(65, 14)
        Me.lblminuteandtime.TabIndex = 89
        Me.lblminuteandtime.Text = "minute and"
        Me.lblminuteandtime.Visible = False
        '
        'lblminutesandtime
        '
        Me.lblminutesandtime.AutoSize = True
        Me.lblminutesandtime.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblminutesandtime.Location = New System.Drawing.Point(36, 24)
        Me.lblminutesandtime.Name = "lblminutesandtime"
        Me.lblminutesandtime.Size = New System.Drawing.Size(71, 14)
        Me.lblminutesandtime.TabIndex = 88
        Me.lblminutesandtime.Text = "minutes and"
        '
        'lblsectime
        '
        Me.lblsectime.AutoSize = True
        Me.lblsectime.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsectime.Location = New System.Drawing.Point(14, 36)
        Me.lblsectime.Name = "lblsectime"
        Me.lblsectime.Size = New System.Drawing.Size(13, 14)
        Me.lblsectime.TabIndex = 85
        Me.lblsectime.Text = "--"
        '
        'lblmintime
        '
        Me.lblmintime.AutoSize = True
        Me.lblmintime.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmintime.Location = New System.Drawing.Point(14, 25)
        Me.lblmintime.Name = "lblmintime"
        Me.lblmintime.Size = New System.Drawing.Size(13, 14)
        Me.lblmintime.TabIndex = 84
        Me.lblmintime.Text = "--"
        '
        'lblhourtime
        '
        Me.lblhourtime.AutoSize = True
        Me.lblhourtime.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhourtime.Location = New System.Drawing.Point(14, 13)
        Me.lblhourtime.Name = "lblhourtime"
        Me.lblhourtime.Size = New System.Drawing.Size(13, 14)
        Me.lblhourtime.TabIndex = 83
        Me.lblhourtime.Text = "--"
        '
        'lblhourandtime
        '
        Me.lblhourandtime.AutoSize = True
        Me.lblhourandtime.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhourandtime.Location = New System.Drawing.Point(36, 13)
        Me.lblhourandtime.Name = "lblhourandtime"
        Me.lblhourandtime.Size = New System.Drawing.Size(52, 14)
        Me.lblhourandtime.TabIndex = 87
        Me.lblhourandtime.Text = "hour and"
        Me.lblhourandtime.Visible = False
        '
        'lblhoursandtime
        '
        Me.lblhoursandtime.AutoSize = True
        Me.lblhoursandtime.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhoursandtime.Location = New System.Drawing.Point(36, 13)
        Me.lblhoursandtime.Name = "lblhoursandtime"
        Me.lblhoursandtime.Size = New System.Drawing.Size(58, 14)
        Me.lblhoursandtime.TabIndex = 86
        Me.lblhoursandtime.Text = "hours and"
        '
        'StartTimeButton
        '
        Me.StartTimeButton.BackColor = System.Drawing.Color.Transparent
        Me.StartTimeButton.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartTimeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.StartTimeButton.ImageKey = "play.ico"
        Me.StartTimeButton.ImageList = Me.IconsIL
        Me.StartTimeButton.Location = New System.Drawing.Point(135, 64)
        Me.StartTimeButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StartTimeButton.Name = "StartTimeButton"
        Me.StartTimeButton.Size = New System.Drawing.Size(72, 33)
        Me.StartTimeButton.TabIndex = 60
        Me.StartTimeButton.Text = "Start"
        Me.StartTimeButton.UseVisualStyleBackColor = False
        '
        'StopTimeButton
        '
        Me.StopTimeButton.BackColor = System.Drawing.Color.Transparent
        Me.StopTimeButton.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopTimeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.StopTimeButton.ImageKey = "stop.ico"
        Me.StopTimeButton.ImageList = Me.IconsIL
        Me.StopTimeButton.Location = New System.Drawing.Point(210, 64)
        Me.StopTimeButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StopTimeButton.Name = "StopTimeButton"
        Me.StopTimeButton.Size = New System.Drawing.Size(72, 33)
        Me.StopTimeButton.TabIndex = 63
        Me.StopTimeButton.Text = "Stop"
        Me.StopTimeButton.UseVisualStyleBackColor = False
        Me.StopTimeButton.Visible = False
        '
        'PauseButtonT
        '
        Me.PauseButtonT.BackColor = System.Drawing.Color.Transparent
        Me.PauseButtonT.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PauseButtonT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PauseButtonT.ImageKey = "pause.ico"
        Me.PauseButtonT.ImageList = Me.IconsIL
        Me.PauseButtonT.Location = New System.Drawing.Point(293, 64)
        Me.PauseButtonT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PauseButtonT.Name = "PauseButtonT"
        Me.PauseButtonT.Size = New System.Drawing.Size(76, 33)
        Me.PauseButtonT.TabIndex = 61
        Me.PauseButtonT.Text = "Pause"
        Me.PauseButtonT.UseVisualStyleBackColor = False
        Me.PauseButtonT.Visible = False
        '
        'nudSec
        '
        Me.nudSec.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSec.Location = New System.Drawing.Point(328, 24)
        Me.nudSec.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nudSec.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudSec.Name = "nudSec"
        Me.nudSec.Size = New System.Drawing.Size(58, 21)
        Me.nudSec.TabIndex = 10
        '
        'nudMin
        '
        Me.nudMin.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudMin.Location = New System.Drawing.Point(262, 24)
        Me.nudMin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nudMin.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudMin.Name = "nudMin"
        Me.nudMin.Size = New System.Drawing.Size(58, 21)
        Me.nudMin.TabIndex = 9
        '
        'nudHour
        '
        Me.nudHour.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudHour.Location = New System.Drawing.Point(197, 24)
        Me.nudHour.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nudHour.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudHour.Name = "nudHour"
        Me.nudHour.Size = New System.Drawing.Size(58, 21)
        Me.nudHour.TabIndex = 8
        '
        'ResumeTimeButton
        '
        Me.ResumeTimeButton.BackColor = System.Drawing.Color.Transparent
        Me.ResumeTimeButton.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResumeTimeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ResumeTimeButton.ImageKey = "play.ico"
        Me.ResumeTimeButton.ImageList = Me.IconsIL
        Me.ResumeTimeButton.Location = New System.Drawing.Point(375, 64)
        Me.ResumeTimeButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ResumeTimeButton.Name = "ResumeTimeButton"
        Me.ResumeTimeButton.Size = New System.Drawing.Size(97, 33)
        Me.ResumeTimeButton.TabIndex = 62
        Me.ResumeTimeButton.Text = "Resume"
        Me.ResumeTimeButton.UseVisualStyleBackColor = False
        Me.ResumeTimeButton.Visible = False
        '
        'BTime
        '
        Me.BTime.Controls.Add(Me.nudb1sec)
        Me.BTime.Controls.Add(Me.BreakNowButtonBt)
        Me.BTime.Controls.Add(Me.BreakLabelBT)
        Me.BTime.Controls.Add(Me.B1HourNudBT)
        Me.BTime.Controls.Add(Me.nudb1min)
        Me.BTime.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTime.ImageIndex = 1
        Me.BTime.Location = New System.Drawing.Point(4, 23)
        Me.BTime.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTime.Name = "BTime"
        Me.BTime.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTime.Size = New System.Drawing.Size(629, 259)
        Me.BTime.TabIndex = 5
        Me.BTime.Text = "Break"
        '
        'nudb1sec
        '
        Me.nudb1sec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudb1sec.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudb1sec.Location = New System.Drawing.Point(370, 41)
        Me.nudb1sec.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nudb1sec.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudb1sec.Name = "nudb1sec"
        Me.nudb1sec.Size = New System.Drawing.Size(49, 21)
        Me.nudb1sec.TabIndex = 42
        '
        'BreakNowButtonBt
        '
        Me.BreakNowButtonBt.BackColor = System.Drawing.Color.Transparent
        Me.BreakNowButtonBt.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BreakNowButtonBt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BreakNowButtonBt.ImageKey = "play.ico"
        Me.BreakNowButtonBt.ImageList = Me.IconsIL
        Me.BreakNowButtonBt.Location = New System.Drawing.Point(261, 66)
        Me.BreakNowButtonBt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BreakNowButtonBt.Name = "BreakNowButtonBt"
        Me.BreakNowButtonBt.Size = New System.Drawing.Size(95, 27)
        Me.BreakNowButtonBt.TabIndex = 85
        Me.BreakNowButtonBt.Text = "Start"
        Me.BreakNowButtonBt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BreakNowButtonBt.UseVisualStyleBackColor = False
        '
        'BreakLabelBT
        '
        Me.BreakLabelBT.AutoSize = True
        Me.BreakLabelBT.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BreakLabelBT.Location = New System.Drawing.Point(211, 42)
        Me.BreakLabelBT.Name = "BreakLabelBT"
        Me.BreakLabelBT.Size = New System.Drawing.Size(42, 14)
        Me.BreakLabelBT.TabIndex = 33
        Me.BreakLabelBT.Text = "Break:"
        '
        'B1HourNudBT
        '
        Me.B1HourNudBT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.B1HourNudBT.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B1HourNudBT.Location = New System.Drawing.Point(269, 41)
        Me.B1HourNudBT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.B1HourNudBT.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.B1HourNudBT.Name = "B1HourNudBT"
        Me.B1HourNudBT.Size = New System.Drawing.Size(43, 21)
        Me.B1HourNudBT.TabIndex = 40
        '
        'nudb1min
        '
        Me.nudb1min.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudb1min.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudb1min.Location = New System.Drawing.Point(319, 41)
        Me.nudb1min.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nudb1min.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudb1min.Name = "nudb1min"
        Me.nudb1min.Size = New System.Drawing.Size(45, 21)
        Me.nudb1min.TabIndex = 41
        '
        'BreakTimerTab
        '
        Me.BreakTimerTab.Controls.Add(Me.StartButtonBT)
        Me.BreakTimerTab.Controls.Add(Me.btnResume)
        Me.BreakTimerTab.Controls.Add(Me.btnStop)
        Me.BreakTimerTab.Controls.Add(Me.PauseButtonBT)
        Me.BreakTimerTab.Controls.Add(Me.BSTGroupBoxBT)
        Me.BreakTimerTab.Controls.Add(Me.TSFGroupBoxBT)
        Me.BreakTimerTab.Controls.Add(Me.VisualRbBt)
        Me.BreakTimerTab.Controls.Add(Me.nudTimeHour)
        Me.BreakTimerTab.Controls.Add(Me.StatusGroupBoxBT)
        Me.BreakTimerTab.Controls.Add(Me.AudioRbBt)
        Me.BreakTimerTab.Controls.Add(Me.nudTimeBreakHour)
        Me.BreakTimerTab.Controls.Add(Me.TimeLabelBt)
        Me.BreakTimerTab.Controls.Add(Me.nudTimeBreakMin)
        Me.BreakTimerTab.Controls.Add(Me.MWLabelBt)
        Me.BreakTimerTab.Controls.Add(Me.nudTimeSec)
        Me.BreakTimerTab.Controls.Add(Me.MinWarnNudBt)
        Me.BreakTimerTab.Controls.Add(Me.nudTimeBreakSec)
        Me.BreakTimerTab.Controls.Add(Me.BreakTimerALabelBT)
        Me.BreakTimerTab.Controls.Add(Me.nudTimeMin)
        Me.BreakTimerTab.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BreakTimerTab.ImageKey = "btimelogo.png"
        Me.BreakTimerTab.Location = New System.Drawing.Point(4, 23)
        Me.BreakTimerTab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BreakTimerTab.Name = "BreakTimerTab"
        Me.BreakTimerTab.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BreakTimerTab.Size = New System.Drawing.Size(629, 259)
        Me.BreakTimerTab.TabIndex = 0
        Me.BreakTimerTab.Text = "Break Timer"
        '
        'StartButtonBT
        '
        Me.StartButtonBT.BackColor = System.Drawing.Color.Transparent
        Me.StartButtonBT.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartButtonBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.StartButtonBT.ImageKey = "play.ico"
        Me.StartButtonBT.ImageList = Me.IconsIL
        Me.StartButtonBT.Location = New System.Drawing.Point(40, 116)
        Me.StartButtonBT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StartButtonBT.Name = "StartButtonBT"
        Me.StartButtonBT.Size = New System.Drawing.Size(108, 45)
        Me.StartButtonBT.TabIndex = 95
        Me.StartButtonBT.Text = "Start"
        Me.StartButtonBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.StartButtonBT.UseVisualStyleBackColor = False
        '
        'btnResume
        '
        Me.btnResume.BackColor = System.Drawing.Color.Transparent
        Me.btnResume.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResume.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnResume.ImageIndex = 5
        Me.btnResume.ImageList = Me.IconsIL
        Me.btnResume.Location = New System.Drawing.Point(296, 117)
        Me.btnResume.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnResume.Name = "btnResume"
        Me.btnResume.Size = New System.Drawing.Size(127, 44)
        Me.btnResume.TabIndex = 97
        Me.btnResume.Text = "Resume"
        Me.btnResume.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnResume.UseVisualStyleBackColor = False
        Me.btnResume.Visible = False
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.Transparent
        Me.btnStop.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStop.ImageIndex = 3
        Me.btnStop.ImageList = Me.IconsIL
        Me.btnStop.Location = New System.Drawing.Point(154, 116)
        Me.btnStop.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(127, 45)
        Me.btnStop.TabIndex = 98
        Me.btnStop.Text = "Stop"
        Me.btnStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStop.UseVisualStyleBackColor = False
        Me.btnStop.Visible = False
        '
        'PauseButtonBT
        '
        Me.PauseButtonBT.BackColor = System.Drawing.Color.Transparent
        Me.PauseButtonBT.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PauseButtonBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PauseButtonBT.ImageIndex = 4
        Me.PauseButtonBT.ImageList = Me.IconsIL
        Me.PauseButtonBT.Location = New System.Drawing.Point(429, 118)
        Me.PauseButtonBT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PauseButtonBT.Name = "PauseButtonBT"
        Me.PauseButtonBT.Size = New System.Drawing.Size(108, 43)
        Me.PauseButtonBT.TabIndex = 96
        Me.PauseButtonBT.Text = "Pause"
        Me.PauseButtonBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PauseButtonBT.UseVisualStyleBackColor = False
        Me.PauseButtonBT.Visible = False
        '
        'BSTGroupBoxBT
        '
        Me.BSTGroupBoxBT.Controls.Add(Me.BSTSecondsLabelBT)
        Me.BSTGroupBoxBT.Controls.Add(Me.BSTSecondLabelBT)
        Me.BSTGroupBoxBT.Controls.Add(Me.BSTMinAndLabelBT)
        Me.BSTGroupBoxBT.Controls.Add(Me.BSTMinsAndLabelBT)
        Me.BSTGroupBoxBT.Controls.Add(Me.BSTSecondIndicatorLabelBT)
        Me.BSTGroupBoxBT.Controls.Add(Me.BSTMinIndicatorLabelBT)
        Me.BSTGroupBoxBT.Controls.Add(Me.BSTHourIndicatorLabelBT)
        Me.BSTGroupBoxBT.Controls.Add(Me.BSTHourAndLabelBT)
        Me.BSTGroupBoxBT.Controls.Add(Me.BSTHoursAndLabelBT)
        Me.BSTGroupBoxBT.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSTGroupBoxBT.Location = New System.Drawing.Point(146, 165)
        Me.BSTGroupBoxBT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BSTGroupBoxBT.Name = "BSTGroupBoxBT"
        Me.BSTGroupBoxBT.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BSTGroupBoxBT.Size = New System.Drawing.Size(140, 53)
        Me.BSTGroupBoxBT.TabIndex = 94
        Me.BSTGroupBoxBT.TabStop = False
        Me.BSTGroupBoxBT.Text = "Breaktime Set For"
        '
        'BSTSecondsLabelBT
        '
        Me.BSTSecondsLabelBT.AutoSize = True
        Me.BSTSecondsLabelBT.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSTSecondsLabelBT.Location = New System.Drawing.Point(26, 36)
        Me.BSTSecondsLabelBT.Name = "BSTSecondsLabelBT"
        Me.BSTSecondsLabelBT.Size = New System.Drawing.Size(52, 14)
        Me.BSTSecondsLabelBT.TabIndex = 91
        Me.BSTSecondsLabelBT.Text = "seconds"
        '
        'BSTSecondLabelBT
        '
        Me.BSTSecondLabelBT.AutoSize = True
        Me.BSTSecondLabelBT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSTSecondLabelBT.Location = New System.Drawing.Point(26, 36)
        Me.BSTSecondLabelBT.Name = "BSTSecondLabelBT"
        Me.BSTSecondLabelBT.Size = New System.Drawing.Size(43, 14)
        Me.BSTSecondLabelBT.TabIndex = 90
        Me.BSTSecondLabelBT.Text = "second"
        '
        'BSTMinAndLabelBT
        '
        Me.BSTMinAndLabelBT.AutoSize = True
        Me.BSTMinAndLabelBT.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSTMinAndLabelBT.Location = New System.Drawing.Point(26, 25)
        Me.BSTMinAndLabelBT.Name = "BSTMinAndLabelBT"
        Me.BSTMinAndLabelBT.Size = New System.Drawing.Size(65, 14)
        Me.BSTMinAndLabelBT.TabIndex = 89
        Me.BSTMinAndLabelBT.Text = "minute and"
        Me.BSTMinAndLabelBT.Visible = False
        '
        'BSTMinsAndLabelBT
        '
        Me.BSTMinsAndLabelBT.AutoSize = True
        Me.BSTMinsAndLabelBT.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSTMinsAndLabelBT.Location = New System.Drawing.Point(26, 25)
        Me.BSTMinsAndLabelBT.Name = "BSTMinsAndLabelBT"
        Me.BSTMinsAndLabelBT.Size = New System.Drawing.Size(63, 12)
        Me.BSTMinsAndLabelBT.TabIndex = 88
        Me.BSTMinsAndLabelBT.Text = "minutes and"
        '
        'BSTSecondIndicatorLabelBT
        '
        Me.BSTSecondIndicatorLabelBT.AutoSize = True
        Me.BSTSecondIndicatorLabelBT.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSTSecondIndicatorLabelBT.Location = New System.Drawing.Point(3, 36)
        Me.BSTSecondIndicatorLabelBT.Name = "BSTSecondIndicatorLabelBT"
        Me.BSTSecondIndicatorLabelBT.Size = New System.Drawing.Size(13, 13)
        Me.BSTSecondIndicatorLabelBT.TabIndex = 85
        Me.BSTSecondIndicatorLabelBT.Text = "--"
        '
        'BSTMinIndicatorLabelBT
        '
        Me.BSTMinIndicatorLabelBT.AutoSize = True
        Me.BSTMinIndicatorLabelBT.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSTMinIndicatorLabelBT.Location = New System.Drawing.Point(3, 26)
        Me.BSTMinIndicatorLabelBT.Name = "BSTMinIndicatorLabelBT"
        Me.BSTMinIndicatorLabelBT.Size = New System.Drawing.Size(13, 12)
        Me.BSTMinIndicatorLabelBT.TabIndex = 84
        Me.BSTMinIndicatorLabelBT.Text = "--"
        '
        'BSTHourIndicatorLabelBT
        '
        Me.BSTHourIndicatorLabelBT.AutoSize = True
        Me.BSTHourIndicatorLabelBT.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSTHourIndicatorLabelBT.Location = New System.Drawing.Point(3, 14)
        Me.BSTHourIndicatorLabelBT.Name = "BSTHourIndicatorLabelBT"
        Me.BSTHourIndicatorLabelBT.Size = New System.Drawing.Size(13, 13)
        Me.BSTHourIndicatorLabelBT.TabIndex = 83
        Me.BSTHourIndicatorLabelBT.Text = "--"
        '
        'BSTHourAndLabelBT
        '
        Me.BSTHourAndLabelBT.AutoSize = True
        Me.BSTHourAndLabelBT.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSTHourAndLabelBT.Location = New System.Drawing.Point(26, 14)
        Me.BSTHourAndLabelBT.Name = "BSTHourAndLabelBT"
        Me.BSTHourAndLabelBT.Size = New System.Drawing.Size(52, 14)
        Me.BSTHourAndLabelBT.TabIndex = 87
        Me.BSTHourAndLabelBT.Text = "hour and"
        Me.BSTHourAndLabelBT.Visible = False
        '
        'BSTHoursAndLabelBT
        '
        Me.BSTHoursAndLabelBT.AutoSize = True
        Me.BSTHoursAndLabelBT.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSTHoursAndLabelBT.Location = New System.Drawing.Point(26, 14)
        Me.BSTHoursAndLabelBT.Name = "BSTHoursAndLabelBT"
        Me.BSTHoursAndLabelBT.Size = New System.Drawing.Size(53, 12)
        Me.BSTHoursAndLabelBT.TabIndex = 86
        Me.BSTHoursAndLabelBT.Text = "hours and"
        '
        'TSFGroupBoxBT
        '
        Me.TSFGroupBoxBT.Controls.Add(Me.TSFSecondsLabelBT)
        Me.TSFGroupBoxBT.Controls.Add(Me.TSFSecondLabelBT)
        Me.TSFGroupBoxBT.Controls.Add(Me.TSFMinAndLabelBT)
        Me.TSFGroupBoxBT.Controls.Add(Me.TSFMinsAndLabelBT)
        Me.TSFGroupBoxBT.Controls.Add(Me.TSFSecondIndicatorLabelBT)
        Me.TSFGroupBoxBT.Controls.Add(Me.TSFMinIndicatorLabelBT)
        Me.TSFGroupBoxBT.Controls.Add(Me.TSFHourIndicatorLabelBT)
        Me.TSFGroupBoxBT.Controls.Add(Me.TSFHourAndLabelBT)
        Me.TSFGroupBoxBT.Controls.Add(Me.TSFHoursAndLabelBT)
        Me.TSFGroupBoxBT.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSFGroupBoxBT.Location = New System.Drawing.Point(35, 166)
        Me.TSFGroupBoxBT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TSFGroupBoxBT.Name = "TSFGroupBoxBT"
        Me.TSFGroupBoxBT.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TSFGroupBoxBT.Size = New System.Drawing.Size(105, 52)
        Me.TSFGroupBoxBT.TabIndex = 93
        Me.TSFGroupBoxBT.TabStop = False
        Me.TSFGroupBoxBT.Text = "Timer Set For"
        '
        'TSFSecondsLabelBT
        '
        Me.TSFSecondsLabelBT.AutoSize = True
        Me.TSFSecondsLabelBT.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSFSecondsLabelBT.Location = New System.Drawing.Point(25, 38)
        Me.TSFSecondsLabelBT.Name = "TSFSecondsLabelBT"
        Me.TSFSecondsLabelBT.Size = New System.Drawing.Size(52, 14)
        Me.TSFSecondsLabelBT.TabIndex = 91
        Me.TSFSecondsLabelBT.Text = "seconds"
        '
        'TSFSecondLabelBT
        '
        Me.TSFSecondLabelBT.AutoSize = True
        Me.TSFSecondLabelBT.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSFSecondLabelBT.Location = New System.Drawing.Point(25, 36)
        Me.TSFSecondLabelBT.Name = "TSFSecondLabelBT"
        Me.TSFSecondLabelBT.Size = New System.Drawing.Size(46, 14)
        Me.TSFSecondLabelBT.TabIndex = 90
        Me.TSFSecondLabelBT.Text = "second"
        '
        'TSFMinAndLabelBT
        '
        Me.TSFMinAndLabelBT.AutoSize = True
        Me.TSFMinAndLabelBT.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSFMinAndLabelBT.Location = New System.Drawing.Point(24, 24)
        Me.TSFMinAndLabelBT.Name = "TSFMinAndLabelBT"
        Me.TSFMinAndLabelBT.Size = New System.Drawing.Size(65, 14)
        Me.TSFMinAndLabelBT.TabIndex = 89
        Me.TSFMinAndLabelBT.Text = "minute and"
        Me.TSFMinAndLabelBT.Visible = False
        '
        'TSFMinsAndLabelBT
        '
        Me.TSFMinsAndLabelBT.AutoSize = True
        Me.TSFMinsAndLabelBT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSFMinsAndLabelBT.Location = New System.Drawing.Point(24, 24)
        Me.TSFMinsAndLabelBT.Name = "TSFMinsAndLabelBT"
        Me.TSFMinsAndLabelBT.Size = New System.Drawing.Size(65, 14)
        Me.TSFMinsAndLabelBT.TabIndex = 88
        Me.TSFMinsAndLabelBT.Text = "minutes and"
        '
        'TSFSecondIndicatorLabelBT
        '
        Me.TSFSecondIndicatorLabelBT.AutoSize = True
        Me.TSFSecondIndicatorLabelBT.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSFSecondIndicatorLabelBT.Location = New System.Drawing.Point(2, 34)
        Me.TSFSecondIndicatorLabelBT.Name = "TSFSecondIndicatorLabelBT"
        Me.TSFSecondIndicatorLabelBT.Size = New System.Drawing.Size(13, 14)
        Me.TSFSecondIndicatorLabelBT.TabIndex = 85
        Me.TSFSecondIndicatorLabelBT.Text = "--"
        '
        'TSFMinIndicatorLabelBT
        '
        Me.TSFMinIndicatorLabelBT.AutoSize = True
        Me.TSFMinIndicatorLabelBT.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSFMinIndicatorLabelBT.Location = New System.Drawing.Point(2, 25)
        Me.TSFMinIndicatorLabelBT.Name = "TSFMinIndicatorLabelBT"
        Me.TSFMinIndicatorLabelBT.Size = New System.Drawing.Size(13, 12)
        Me.TSFMinIndicatorLabelBT.TabIndex = 84
        Me.TSFMinIndicatorLabelBT.Text = "--"
        '
        'TSFHourIndicatorLabelBT
        '
        Me.TSFHourIndicatorLabelBT.AutoSize = True
        Me.TSFHourIndicatorLabelBT.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSFHourIndicatorLabelBT.Location = New System.Drawing.Point(1, 14)
        Me.TSFHourIndicatorLabelBT.Name = "TSFHourIndicatorLabelBT"
        Me.TSFHourIndicatorLabelBT.Size = New System.Drawing.Size(13, 14)
        Me.TSFHourIndicatorLabelBT.TabIndex = 83
        Me.TSFHourIndicatorLabelBT.Text = "--"
        '
        'TSFHourAndLabelBT
        '
        Me.TSFHourAndLabelBT.AutoSize = True
        Me.TSFHourAndLabelBT.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSFHourAndLabelBT.Location = New System.Drawing.Point(23, 13)
        Me.TSFHourAndLabelBT.Name = "TSFHourAndLabelBT"
        Me.TSFHourAndLabelBT.Size = New System.Drawing.Size(52, 14)
        Me.TSFHourAndLabelBT.TabIndex = 87
        Me.TSFHourAndLabelBT.Text = "hour and"
        Me.TSFHourAndLabelBT.Visible = False
        '
        'TSFHoursAndLabelBT
        '
        Me.TSFHoursAndLabelBT.AutoSize = True
        Me.TSFHoursAndLabelBT.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSFHoursAndLabelBT.Location = New System.Drawing.Point(23, 14)
        Me.TSFHoursAndLabelBT.Name = "TSFHoursAndLabelBT"
        Me.TSFHoursAndLabelBT.Size = New System.Drawing.Size(53, 12)
        Me.TSFHoursAndLabelBT.TabIndex = 86
        Me.TSFHoursAndLabelBT.Text = "hours and"
        '
        'VisualRbBt
        '
        Me.VisualRbBt.AutoSize = True
        Me.VisualRbBt.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VisualRbBt.Location = New System.Drawing.Point(203, 81)
        Me.VisualRbBt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.VisualRbBt.Name = "VisualRbBt"
        Me.VisualRbBt.Size = New System.Drawing.Size(55, 18)
        Me.VisualRbBt.TabIndex = 62
        Me.VisualRbBt.TabStop = True
        Me.VisualRbBt.Text = "Visual"
        Me.VisualRbBt.UseVisualStyleBackColor = False
        '
        'nudTimeHour
        '
        Me.nudTimeHour.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudTimeHour.Location = New System.Drawing.Point(93, 44)
        Me.nudTimeHour.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nudTimeHour.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudTimeHour.Name = "nudTimeHour"
        Me.nudTimeHour.Size = New System.Drawing.Size(49, 21)
        Me.nudTimeHour.TabIndex = 34
        '
        'StatusGroupBoxBT
        '
        Me.StatusGroupBoxBT.Controls.Add(Me.lblsecondsbreak)
        Me.StatusGroupBoxBT.Controls.Add(Me.lblsecondbreak)
        Me.StatusGroupBoxBT.Controls.Add(Me.lblminuteandbreak)
        Me.StatusGroupBoxBT.Controls.Add(Me.lblminutesandbreak)
        Me.StatusGroupBoxBT.Controls.Add(Me.lblsec)
        Me.StatusGroupBoxBT.Controls.Add(Me.lblminute)
        Me.StatusGroupBoxBT.Controls.Add(Me.HourLabelBT)
        Me.StatusGroupBoxBT.Controls.Add(Me.HourAndBreakLabelBT)
        Me.StatusGroupBoxBT.Controls.Add(Me.lblhoursandbreak)
        Me.StatusGroupBoxBT.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusGroupBoxBT.Location = New System.Drawing.Point(292, 165)
        Me.StatusGroupBoxBT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StatusGroupBoxBT.Name = "StatusGroupBoxBT"
        Me.StatusGroupBoxBT.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StatusGroupBoxBT.Size = New System.Drawing.Size(131, 53)
        Me.StatusGroupBoxBT.TabIndex = 84
        Me.StatusGroupBoxBT.TabStop = False
        Me.StatusGroupBoxBT.Text = "Time Left"
        '
        'lblsecondsbreak
        '
        Me.lblsecondsbreak.AutoSize = True
        Me.lblsecondsbreak.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsecondsbreak.Location = New System.Drawing.Point(36, 34)
        Me.lblsecondsbreak.Name = "lblsecondsbreak"
        Me.lblsecondsbreak.Size = New System.Drawing.Size(52, 14)
        Me.lblsecondsbreak.TabIndex = 91
        Me.lblsecondsbreak.Text = "seconds"
        '
        'lblsecondbreak
        '
        Me.lblsecondbreak.AutoSize = True
        Me.lblsecondbreak.Location = New System.Drawing.Point(47, 36)
        Me.lblsecondbreak.Name = "lblsecondbreak"
        Me.lblsecondbreak.Size = New System.Drawing.Size(46, 14)
        Me.lblsecondbreak.TabIndex = 90
        Me.lblsecondbreak.Text = "second"
        '
        'lblminuteandbreak
        '
        Me.lblminuteandbreak.AutoSize = True
        Me.lblminuteandbreak.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblminuteandbreak.Location = New System.Drawing.Point(35, 24)
        Me.lblminuteandbreak.Name = "lblminuteandbreak"
        Me.lblminuteandbreak.Size = New System.Drawing.Size(65, 14)
        Me.lblminuteandbreak.TabIndex = 89
        Me.lblminuteandbreak.Text = "minute and"
        Me.lblminuteandbreak.Visible = False
        '
        'lblminutesandbreak
        '
        Me.lblminutesandbreak.AutoSize = True
        Me.lblminutesandbreak.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblminutesandbreak.Location = New System.Drawing.Point(36, 24)
        Me.lblminutesandbreak.Name = "lblminutesandbreak"
        Me.lblminutesandbreak.Size = New System.Drawing.Size(71, 14)
        Me.lblminutesandbreak.TabIndex = 88
        Me.lblminutesandbreak.Text = "minutes and"
        '
        'lblsec
        '
        Me.lblsec.AutoSize = True
        Me.lblsec.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsec.Location = New System.Drawing.Point(14, 36)
        Me.lblsec.Name = "lblsec"
        Me.lblsec.Size = New System.Drawing.Size(13, 12)
        Me.lblsec.TabIndex = 85
        Me.lblsec.Text = "--"
        '
        'lblminute
        '
        Me.lblminute.AutoSize = True
        Me.lblminute.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblminute.Location = New System.Drawing.Point(14, 25)
        Me.lblminute.Name = "lblminute"
        Me.lblminute.Size = New System.Drawing.Size(13, 12)
        Me.lblminute.TabIndex = 84
        Me.lblminute.Text = "--"
        '
        'HourLabelBT
        '
        Me.HourLabelBT.AutoSize = True
        Me.HourLabelBT.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HourLabelBT.Location = New System.Drawing.Point(14, 13)
        Me.HourLabelBT.Name = "HourLabelBT"
        Me.HourLabelBT.Size = New System.Drawing.Size(13, 12)
        Me.HourLabelBT.TabIndex = 83
        Me.HourLabelBT.Text = "--"
        '
        'HourAndBreakLabelBT
        '
        Me.HourAndBreakLabelBT.AutoSize = True
        Me.HourAndBreakLabelBT.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HourAndBreakLabelBT.Location = New System.Drawing.Point(36, 10)
        Me.HourAndBreakLabelBT.Name = "HourAndBreakLabelBT"
        Me.HourAndBreakLabelBT.Size = New System.Drawing.Size(52, 14)
        Me.HourAndBreakLabelBT.TabIndex = 87
        Me.HourAndBreakLabelBT.Text = "hour and"
        Me.HourAndBreakLabelBT.Visible = False
        '
        'lblhoursandbreak
        '
        Me.lblhoursandbreak.AutoSize = True
        Me.lblhoursandbreak.Location = New System.Drawing.Point(36, 13)
        Me.lblhoursandbreak.Name = "lblhoursandbreak"
        Me.lblhoursandbreak.Size = New System.Drawing.Size(58, 14)
        Me.lblhoursandbreak.TabIndex = 86
        Me.lblhoursandbreak.Text = "hours and"
        '
        'AudioRbBt
        '
        Me.AudioRbBt.AutoSize = True
        Me.AudioRbBt.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AudioRbBt.Location = New System.Drawing.Point(148, 81)
        Me.AudioRbBt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AudioRbBt.Name = "AudioRbBt"
        Me.AudioRbBt.Size = New System.Drawing.Size(56, 18)
        Me.AudioRbBt.TabIndex = 61
        Me.AudioRbBt.TabStop = True
        Me.AudioRbBt.Text = "Audio"
        Me.AudioRbBt.UseVisualStyleBackColor = False
        '
        'nudTimeBreakHour
        '
        Me.nudTimeBreakHour.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudTimeBreakHour.Location = New System.Drawing.Point(325, 44)
        Me.nudTimeBreakHour.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nudTimeBreakHour.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudTimeBreakHour.Name = "nudTimeBreakHour"
        Me.nudTimeBreakHour.Size = New System.Drawing.Size(49, 21)
        Me.nudTimeBreakHour.TabIndex = 37
        '
        'TimeLabelBt
        '
        Me.TimeLabelBt.AutoSize = True
        Me.TimeLabelBt.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLabelBt.Location = New System.Drawing.Point(37, 44)
        Me.TimeLabelBt.Name = "TimeLabelBt"
        Me.TimeLabelBt.Size = New System.Drawing.Size(36, 14)
        Me.TimeLabelBt.TabIndex = 29
        Me.TimeLabelBt.Text = "Time:"
        '
        'nudTimeBreakMin
        '
        Me.nudTimeBreakMin.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudTimeBreakMin.Location = New System.Drawing.Point(381, 44)
        Me.nudTimeBreakMin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nudTimeBreakMin.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudTimeBreakMin.Name = "nudTimeBreakMin"
        Me.nudTimeBreakMin.Size = New System.Drawing.Size(48, 21)
        Me.nudTimeBreakMin.TabIndex = 38
        '
        'MWLabelBt
        '
        Me.MWLabelBt.AutoSize = True
        Me.MWLabelBt.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MWLabelBt.Location = New System.Drawing.Point(18, 77)
        Me.MWLabelBt.Name = "MWLabelBt"
        Me.MWLabelBt.Size = New System.Drawing.Size(55, 14)
        Me.MWLabelBt.TabIndex = 43
        Me.MWLabelBt.Text = "MinWarn:"
        '
        'nudTimeSec
        '
        Me.nudTimeSec.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudTimeSec.Location = New System.Drawing.Point(204, 44)
        Me.nudTimeSec.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nudTimeSec.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudTimeSec.Name = "nudTimeSec"
        Me.nudTimeSec.Size = New System.Drawing.Size(47, 21)
        Me.nudTimeSec.TabIndex = 36
        '
        'MinWarnNudBt
        '
        Me.MinWarnNudBt.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinWarnNudBt.Location = New System.Drawing.Point(95, 77)
        Me.MinWarnNudBt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinWarnNudBt.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.MinWarnNudBt.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MinWarnNudBt.Name = "MinWarnNudBt"
        Me.MinWarnNudBt.Size = New System.Drawing.Size(47, 21)
        Me.MinWarnNudBt.TabIndex = 60
        Me.MinWarnNudBt.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudTimeBreakSec
        '
        Me.nudTimeBreakSec.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudTimeBreakSec.Location = New System.Drawing.Point(436, 44)
        Me.nudTimeBreakSec.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nudTimeBreakSec.Name = "nudTimeBreakSec"
        Me.nudTimeBreakSec.Size = New System.Drawing.Size(47, 21)
        Me.nudTimeBreakSec.TabIndex = 39
        '
        'BreakTimerALabelBT
        '
        Me.BreakTimerALabelBT.AutoSize = True
        Me.BreakTimerALabelBT.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BreakTimerALabelBT.Location = New System.Drawing.Point(263, 45)
        Me.BreakTimerALabelBT.Name = "BreakTimerALabelBT"
        Me.BreakTimerALabelBT.Size = New System.Drawing.Size(42, 14)
        Me.BreakTimerALabelBT.TabIndex = 31
        Me.BreakTimerALabelBT.Text = "Break:"
        '
        'nudTimeMin
        '
        Me.nudTimeMin.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudTimeMin.Location = New System.Drawing.Point(149, 44)
        Me.nudTimeMin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nudTimeMin.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudTimeMin.Name = "nudTimeMin"
        Me.nudTimeMin.Size = New System.Drawing.Size(48, 21)
        Me.nudTimeMin.TabIndex = 35
        '
        'TimerControl
        '
        Me.TimerControl.Controls.Add(Me.BreakTimerTab)
        Me.TimerControl.Controls.Add(Me.BTime)
        Me.TimerControl.Controls.Add(Me.TimerTab)
        Me.TimerControl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TimerControl.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimerControl.ImageList = Me.IconsIL
        Me.TimerControl.Location = New System.Drawing.Point(0, 102)
        Me.TimerControl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TimerControl.Multiline = True
        Me.TimerControl.Name = "TimerControl"
        Me.TimerControl.SelectedIndex = 0
        Me.TimerControl.Size = New System.Drawing.Size(637, 286)
        Me.TimerControl.TabIndex = 24
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 388)
        Me.Controls.Add(Me.TitlePanel)
        Me.Controls.Add(Me.TimerControl)
        Me.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BreakTime - v21H2B3- Released on September 24, 2021"
        Me.TitlePanel.ResumeLayout(False)
        Me.TitlePanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TimerTab.ResumeLayout(False)
        Me.TSFGroupBoxT.ResumeLayout(False)
        Me.TSFGroupBoxT.PerformLayout()
        Me.StatusGroupBoxT.ResumeLayout(False)
        Me.StatusGroupBoxT.PerformLayout()
        CType(Me.nudSec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHour, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BTime.ResumeLayout(False)
        Me.BTime.PerformLayout()
        CType(Me.nudb1sec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.B1HourNudBT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudb1min, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BreakTimerTab.ResumeLayout(False)
        Me.BreakTimerTab.PerformLayout()
        Me.BSTGroupBoxBT.ResumeLayout(False)
        Me.BSTGroupBoxBT.PerformLayout()
        Me.TSFGroupBoxBT.ResumeLayout(False)
        Me.TSFGroupBoxBT.PerformLayout()
        CType(Me.nudTimeHour, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusGroupBoxBT.ResumeLayout(False)
        Me.StatusGroupBoxBT.PerformLayout()
        CType(Me.nudTimeBreakHour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTimeBreakMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTimeSec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinWarnNudBt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTimeBreakSec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTimeMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TimerControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents BreakTimer As Timer
    Public WithEvents lblTimeRemaining As Label
    Friend WithEvents TimerTimer As Timer
    Friend WithEvents tBeep As Timer
    Friend WithEvents TitlePanel As Panel
    Friend WithEvents lblVersion As Label
    Friend WithEvents lblName As Label
    Friend WithEvents DateLabelYD As Label
    Friend WithEvents lblwelcome As Label
    Friend WithEvents YDTimer As Timer
    Public WithEvents SettingsButton As Button
    Friend WithEvents NotifyIconWDLCT As NotifyIcon
    Friend WithEvents TimeLabelYD As Label
    Friend WithEvents IconsIL As ImageList
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimeBomb As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TimerControl As TabControl
    Friend WithEvents BreakTimerTab As TabPage
    Friend WithEvents BSTGroupBoxBT As GroupBox
    Friend WithEvents BSTSecondsLabelBT As Label
    Friend WithEvents BSTSecondLabelBT As Label
    Friend WithEvents BSTMinAndLabelBT As Label
    Friend WithEvents BSTMinsAndLabelBT As Label
    Friend WithEvents BSTSecondIndicatorLabelBT As Label
    Friend WithEvents BSTMinIndicatorLabelBT As Label
    Friend WithEvents BSTHourIndicatorLabelBT As Label
    Friend WithEvents BSTHourAndLabelBT As Label
    Friend WithEvents BSTHoursAndLabelBT As Label
    Friend WithEvents TSFGroupBoxBT As GroupBox
    Friend WithEvents TSFSecondsLabelBT As Label
    Friend WithEvents TSFSecondLabelBT As Label
    Friend WithEvents TSFMinAndLabelBT As Label
    Friend WithEvents TSFMinsAndLabelBT As Label
    Friend WithEvents TSFSecondIndicatorLabelBT As Label
    Friend WithEvents TSFMinIndicatorLabelBT As Label
    Friend WithEvents TSFHourIndicatorLabelBT As Label
    Friend WithEvents TSFHourAndLabelBT As Label
    Friend WithEvents TSFHoursAndLabelBT As Label
    Friend WithEvents VisualRbBt As RadioButton
    Friend WithEvents nudTimeHour As NumericUpDown
    Friend WithEvents AudioRbBt As RadioButton
    Friend WithEvents TimeLabelBt As Label
    Friend WithEvents MWLabelBt As Label
    Friend WithEvents MinWarnNudBt As NumericUpDown
    Friend WithEvents BreakTimerALabelBT As Label
    Friend WithEvents nudTimeMin As NumericUpDown
    Friend WithEvents nudTimeBreakSec As NumericUpDown
    Friend WithEvents nudTimeSec As NumericUpDown
    Friend WithEvents nudTimeBreakMin As NumericUpDown
    Friend WithEvents nudTimeBreakHour As NumericUpDown
    Friend WithEvents StatusGroupBoxBT As GroupBox
    Friend WithEvents lblsecondsbreak As Label
    Friend WithEvents lblsecondbreak As Label
    Friend WithEvents lblminuteandbreak As Label
    Friend WithEvents lblminutesandbreak As Label
    Friend WithEvents lblsec As Label
    Friend WithEvents lblminute As Label
    Friend WithEvents HourLabelBT As Label
    Friend WithEvents HourAndBreakLabelBT As Label
    Friend WithEvents lblhoursandbreak As Label
    Friend WithEvents BTime As TabPage
    Public WithEvents BreakNowButtonBt As Button
    Friend WithEvents BreakLabelBT As Label
    Friend WithEvents B1HourNudBT As NumericUpDown
    Friend WithEvents nudb1sec As NumericUpDown
    Friend WithEvents nudb1min As NumericUpDown
    Friend WithEvents TimerTab As TabPage
    Friend WithEvents TSFGroupBoxT As GroupBox
    Friend WithEvents lblsfsecondstime As Label
    Friend WithEvents TSFSecondLabelT As Label
    Friend WithEvents SFMinAndLabelT As Label
    Friend WithEvents TSFMinsAndLabelT As Label
    Friend WithEvents TSFSecondIndicatorLabelT As Label
    Friend WithEvents TSFMinIndicatorLabelT As Label
    Friend WithEvents TSFHourIndicatorLabelT As Label
    Friend WithEvents lblsfhoursandtime As Label
    Friend WithEvents TSFHoursAndLabelT As Label
    Friend WithEvents StatusGroupBoxT As GroupBox
    Friend WithEvents SecondsLabelT As Label
    Friend WithEvents lblsecondtime As Label
    Friend WithEvents lblminuteandtime As Label
    Friend WithEvents lblminutesandtime As Label
    Friend WithEvents lblsectime As Label
    Friend WithEvents lblmintime As Label
    Friend WithEvents lblhourtime As Label
    Friend WithEvents lblhourandtime As Label
    Friend WithEvents lblhoursandtime As Label
    Public WithEvents StartTimeButton As Button
    Public WithEvents StopTimeButton As Button
    Public WithEvents PauseButtonT As Button
    Friend WithEvents nudSec As NumericUpDown
    Friend WithEvents nudMin As NumericUpDown
    Friend WithEvents nudHour As NumericUpDown
    Public WithEvents ResumeTimeButton As Button
    Public WithEvents StartButtonBT As Button
    Public WithEvents btnResume As Button
    Public WithEvents btnStop As Button
    Public WithEvents PauseButtonBT As Button
End Class