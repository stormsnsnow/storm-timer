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
        Me.TimerControl = New System.Windows.Forms.TabControl()
        Me.BreakTimerTab = New System.Windows.Forms.TabPage()
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
        Me.ControlsGroupBoxBT = New System.Windows.Forms.GroupBox()
        Me.StartButtonBT = New System.Windows.Forms.Button()
        Me.IconsIL = New System.Windows.Forms.ImageList(Me.components)
        Me.btnResume = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.PauseButtonBT = New System.Windows.Forms.Button()
        Me.TimerGBBt = New System.Windows.Forms.GroupBox()
        Me.TimeSelectIndicatorLabelBT = New System.Windows.Forms.Label()
        Me.TimeSelectLabelBT = New System.Windows.Forms.Label()
        Me.BreakTimeIndicatorALabelBT = New System.Windows.Forms.Label()
        Me.VisualRbBt = New System.Windows.Forms.RadioButton()
        Me.BreakTimeSelectALabelBT = New System.Windows.Forms.Label()
        Me.nudTimeHour = New System.Windows.Forms.NumericUpDown()
        Me.AudioRbBt = New System.Windows.Forms.RadioButton()
        Me.TimeLabelBt = New System.Windows.Forms.Label()
        Me.MWLabelBt = New System.Windows.Forms.Label()
        Me.MinWarnNudBt = New System.Windows.Forms.NumericUpDown()
        Me.BreakTimerALabelBT = New System.Windows.Forms.Label()
        Me.nudTimeMin = New System.Windows.Forms.NumericUpDown()
        Me.nudTimeBreakSec = New System.Windows.Forms.NumericUpDown()
        Me.nudTimeSec = New System.Windows.Forms.NumericUpDown()
        Me.nudTimeBreakMin = New System.Windows.Forms.NumericUpDown()
        Me.nudTimeBreakHour = New System.Windows.Forms.NumericUpDown()
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
        Me.BTime = New System.Windows.Forms.TabPage()
        Me.BreakNowButtonBt = New System.Windows.Forms.Button()
        Me.BreakGBBt = New System.Windows.Forms.GroupBox()
        Me.BreakTimeLabelBT = New System.Windows.Forms.Label()
        Me.BreakTimeSelectLabelBT = New System.Windows.Forms.Label()
        Me.BreakLabelBT = New System.Windows.Forms.Label()
        Me.B1HourNudBT = New System.Windows.Forms.NumericUpDown()
        Me.nudb1sec = New System.Windows.Forms.NumericUpDown()
        Me.nudb1min = New System.Windows.Forms.NumericUpDown()
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
        Me.AlarmClockTab = New System.Windows.Forms.TabPage()
        Me.panelalert = New System.Windows.Forms.Panel()
        Me.btnLM = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.HourNudAC = New System.Windows.Forms.NumericUpDown()
        Me.MinNudAC = New System.Windows.Forms.NumericUpDown()
        Me.SecNudAC = New System.Windows.Forms.NumericUpDown()
        Me.AlarmStatusLabel = New System.Windows.Forms.Label()
        Me.CancelAlarmButton = New System.Windows.Forms.Button()
        Me.SetAlarmButton = New System.Windows.Forms.Button()
        Me.SetOrNotSetLabel = New System.Windows.Forms.Label()
        Me.StopWatchTab = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.LapListBoxSw = New System.Windows.Forms.ListBox()
        Me.LapButtonSW = New System.Windows.Forms.Button()
        Me.PauseButtonSW = New System.Windows.Forms.Button()
        Me.StopwatchLabelSW = New System.Windows.Forms.Label()
        Me.StartButtonSW = New System.Windows.Forms.Button()
        Me.StopButtonSW = New System.Windows.Forms.Button()
        Me.ResumeButtonSW = New System.Windows.Forms.Button()
        Me.ShutdownTabPage = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.StatusGroupBoxSH = New System.Windows.Forms.GroupBox()
        Me.MinuteAndLabelSh = New System.Windows.Forms.Label()
        Me.DateTimeTillShutdownLabelSh = New System.Windows.Forms.Label()
        Me.HoursAndLabelSh = New System.Windows.Forms.Label()
        Me.HourAndLabelSh = New System.Windows.Forms.Label()
        Me.SecondsLabelSh = New System.Windows.Forms.Label()
        Me.HourIndicatorLabelSh = New System.Windows.Forms.Label()
        Me.SecondLabelSh = New System.Windows.Forms.Label()
        Me.MinuteIndicatorLabelSh = New System.Windows.Forms.Label()
        Me.MinutesAndLabelSh = New System.Windows.Forms.Label()
        Me.SecondsIndicatorLabelSh = New System.Windows.Forms.Label()
        Me.PauseButtonSh = New System.Windows.Forms.Button()
        Me.StartButtonSh = New System.Windows.Forms.Button()
        Me.StopButtonSh = New System.Windows.Forms.Button()
        Me.ResumeButtonSh = New System.Windows.Forms.Button()
        Me.InSettingsGBSH = New System.Windows.Forms.GroupBox()
        Me.VisualRadioButtonSh = New System.Windows.Forms.RadioButton()
        Me.HourNudSh = New System.Windows.Forms.NumericUpDown()
        Me.AudioRadioButtonSh = New System.Windows.Forms.RadioButton()
        Me.TimeLabelSh = New System.Windows.Forms.Label()
        Me.MinWarnLabelSh = New System.Windows.Forms.Label()
        Me.MinWarnNudSh = New System.Windows.Forms.NumericUpDown()
        Me.MinuteNudSh = New System.Windows.Forms.NumericUpDown()
        Me.SecondNudSh = New System.Windows.Forms.NumericUpDown()
        Me.TimerTimer = New System.Windows.Forms.Timer(Me.components)
        Me.tBeep = New System.Windows.Forms.Timer(Me.components)
        Me.DTPErhAc = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TitlePanel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TimeLabelYD = New System.Windows.Forms.Label()
        Me.SettingsButton = New System.Windows.Forms.Button()
        Me.DateLabelYD = New System.Windows.Forms.Label()
        Me.lblwelcome = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.AlarmTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ShutdownTimer = New System.Windows.Forms.Timer(Me.components)
        Me.YDTimer = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIconWDLCT = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimeBomb = New System.Windows.Forms.Timer(Me.components)
        Me.TimerControl.SuspendLayout()
        Me.BreakTimerTab.SuspendLayout()
        Me.BSTGroupBoxBT.SuspendLayout()
        Me.TSFGroupBoxBT.SuspendLayout()
        Me.ControlsGroupBoxBT.SuspendLayout()
        Me.TimerGBBt.SuspendLayout()
        CType(Me.nudTimeHour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinWarnNudBt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTimeMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTimeBreakSec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTimeSec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTimeBreakMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTimeBreakHour, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusGroupBoxBT.SuspendLayout()
        Me.BTime.SuspendLayout()
        Me.BreakGBBt.SuspendLayout()
        CType(Me.B1HourNudBT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudb1sec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudb1min, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TimerTab.SuspendLayout()
        Me.TSFGroupBoxT.SuspendLayout()
        Me.StatusGroupBoxT.SuspendLayout()
        CType(Me.nudSec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHour, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AlarmClockTab.SuspendLayout()
        Me.panelalert.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HourNudAC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinNudAC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SecNudAC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StopWatchTab.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ShutdownTabPage.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusGroupBoxSH.SuspendLayout()
        Me.InSettingsGBSH.SuspendLayout()
        CType(Me.HourNudSh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinWarnNudSh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinuteNudSh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SecondNudSh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTPErhAc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TitlePanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BreakTimer
        '
        Me.BreakTimer.Interval = 1000
        '
        'TimerControl
        '
        Me.TimerControl.Controls.Add(Me.BreakTimerTab)
        Me.TimerControl.Controls.Add(Me.BTime)
        Me.TimerControl.Controls.Add(Me.TimerTab)
        Me.TimerControl.Controls.Add(Me.AlarmClockTab)
        Me.TimerControl.Controls.Add(Me.StopWatchTab)
        Me.TimerControl.Controls.Add(Me.ShutdownTabPage)
        Me.TimerControl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TimerControl.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimerControl.ImageList = Me.IconsIL
        Me.TimerControl.Location = New System.Drawing.Point(0, 71)
        Me.TimerControl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TimerControl.Multiline = True
        Me.TimerControl.Name = "TimerControl"
        Me.TimerControl.SelectedIndex = 0
        Me.TimerControl.Size = New System.Drawing.Size(726, 289)
        Me.TimerControl.TabIndex = 24
        '
        'BreakTimerTab
        '
        Me.BreakTimerTab.Controls.Add(Me.BSTGroupBoxBT)
        Me.BreakTimerTab.Controls.Add(Me.TSFGroupBoxBT)
        Me.BreakTimerTab.Controls.Add(Me.ControlsGroupBoxBT)
        Me.BreakTimerTab.Controls.Add(Me.TimerGBBt)
        Me.BreakTimerTab.Controls.Add(Me.StatusGroupBoxBT)
        Me.BreakTimerTab.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BreakTimerTab.ImageKey = "btimelogo.png"
        Me.BreakTimerTab.Location = New System.Drawing.Point(4, 23)
        Me.BreakTimerTab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BreakTimerTab.Name = "BreakTimerTab"
        Me.BreakTimerTab.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BreakTimerTab.Size = New System.Drawing.Size(718, 262)
        Me.BreakTimerTab.TabIndex = 0
        Me.BreakTimerTab.Text = "Break Timer"
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
        Me.BSTGroupBoxBT.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSTGroupBoxBT.Location = New System.Drawing.Point(174, 131)
        Me.BSTGroupBoxBT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BSTGroupBoxBT.Name = "BSTGroupBoxBT"
        Me.BSTGroupBoxBT.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BSTGroupBoxBT.Size = New System.Drawing.Size(160, 49)
        Me.BSTGroupBoxBT.TabIndex = 94
        Me.BSTGroupBoxBT.TabStop = False
        Me.BSTGroupBoxBT.Text = "Breaktime Set For"
        '
        'BSTSecondsLabelBT
        '
        Me.BSTSecondsLabelBT.AutoSize = True
        Me.BSTSecondsLabelBT.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSTSecondsLabelBT.Location = New System.Drawing.Point(30, 33)
        Me.BSTSecondsLabelBT.Name = "BSTSecondsLabelBT"
        Me.BSTSecondsLabelBT.Size = New System.Drawing.Size(50, 13)
        Me.BSTSecondsLabelBT.TabIndex = 91
        Me.BSTSecondsLabelBT.Text = "seconds"
        '
        'BSTSecondLabelBT
        '
        Me.BSTSecondLabelBT.AutoSize = True
        Me.BSTSecondLabelBT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSTSecondLabelBT.Location = New System.Drawing.Point(30, 33)
        Me.BSTSecondLabelBT.Name = "BSTSecondLabelBT"
        Me.BSTSecondLabelBT.Size = New System.Drawing.Size(43, 14)
        Me.BSTSecondLabelBT.TabIndex = 90
        Me.BSTSecondLabelBT.Text = "second"
        '
        'BSTMinAndLabelBT
        '
        Me.BSTMinAndLabelBT.AutoSize = True
        Me.BSTMinAndLabelBT.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSTMinAndLabelBT.Location = New System.Drawing.Point(30, 23)
        Me.BSTMinAndLabelBT.Name = "BSTMinAndLabelBT"
        Me.BSTMinAndLabelBT.Size = New System.Drawing.Size(71, 13)
        Me.BSTMinAndLabelBT.TabIndex = 89
        Me.BSTMinAndLabelBT.Text = "minute and"
        Me.BSTMinAndLabelBT.Visible = False
        '
        'BSTMinsAndLabelBT
        '
        Me.BSTMinsAndLabelBT.AutoSize = True
        Me.BSTMinsAndLabelBT.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSTMinsAndLabelBT.Location = New System.Drawing.Point(30, 23)
        Me.BSTMinsAndLabelBT.Name = "BSTMinsAndLabelBT"
        Me.BSTMinsAndLabelBT.Size = New System.Drawing.Size(63, 12)
        Me.BSTMinsAndLabelBT.TabIndex = 88
        Me.BSTMinsAndLabelBT.Text = "minutes and"
        '
        'BSTSecondIndicatorLabelBT
        '
        Me.BSTSecondIndicatorLabelBT.AutoSize = True
        Me.BSTSecondIndicatorLabelBT.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSTSecondIndicatorLabelBT.Location = New System.Drawing.Point(3, 33)
        Me.BSTSecondIndicatorLabelBT.Name = "BSTSecondIndicatorLabelBT"
        Me.BSTSecondIndicatorLabelBT.Size = New System.Drawing.Size(13, 13)
        Me.BSTSecondIndicatorLabelBT.TabIndex = 85
        Me.BSTSecondIndicatorLabelBT.Text = "--"
        '
        'BSTMinIndicatorLabelBT
        '
        Me.BSTMinIndicatorLabelBT.AutoSize = True
        Me.BSTMinIndicatorLabelBT.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSTMinIndicatorLabelBT.Location = New System.Drawing.Point(3, 24)
        Me.BSTMinIndicatorLabelBT.Name = "BSTMinIndicatorLabelBT"
        Me.BSTMinIndicatorLabelBT.Size = New System.Drawing.Size(13, 12)
        Me.BSTMinIndicatorLabelBT.TabIndex = 84
        Me.BSTMinIndicatorLabelBT.Text = "--"
        '
        'BSTHourIndicatorLabelBT
        '
        Me.BSTHourIndicatorLabelBT.AutoSize = True
        Me.BSTHourIndicatorLabelBT.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSTHourIndicatorLabelBT.Location = New System.Drawing.Point(3, 13)
        Me.BSTHourIndicatorLabelBT.Name = "BSTHourIndicatorLabelBT"
        Me.BSTHourIndicatorLabelBT.Size = New System.Drawing.Size(13, 13)
        Me.BSTHourIndicatorLabelBT.TabIndex = 83
        Me.BSTHourIndicatorLabelBT.Text = "--"
        '
        'BSTHourAndLabelBT
        '
        Me.BSTHourAndLabelBT.AutoSize = True
        Me.BSTHourAndLabelBT.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSTHourAndLabelBT.Location = New System.Drawing.Point(30, 13)
        Me.BSTHourAndLabelBT.Name = "BSTHourAndLabelBT"
        Me.BSTHourAndLabelBT.Size = New System.Drawing.Size(57, 13)
        Me.BSTHourAndLabelBT.TabIndex = 87
        Me.BSTHourAndLabelBT.Text = "hour and"
        Me.BSTHourAndLabelBT.Visible = False
        '
        'BSTHoursAndLabelBT
        '
        Me.BSTHoursAndLabelBT.AutoSize = True
        Me.BSTHoursAndLabelBT.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSTHoursAndLabelBT.Location = New System.Drawing.Point(30, 13)
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
        Me.TSFGroupBoxBT.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSFGroupBoxBT.Location = New System.Drawing.Point(46, 131)
        Me.TSFGroupBoxBT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TSFGroupBoxBT.Name = "TSFGroupBoxBT"
        Me.TSFGroupBoxBT.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TSFGroupBoxBT.Size = New System.Drawing.Size(120, 48)
        Me.TSFGroupBoxBT.TabIndex = 93
        Me.TSFGroupBoxBT.TabStop = False
        Me.TSFGroupBoxBT.Text = "Timer Set For"
        '
        'TSFSecondsLabelBT
        '
        Me.TSFSecondsLabelBT.AutoSize = True
        Me.TSFSecondsLabelBT.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSFSecondsLabelBT.Location = New System.Drawing.Point(27, 32)
        Me.TSFSecondsLabelBT.Name = "TSFSecondsLabelBT"
        Me.TSFSecondsLabelBT.Size = New System.Drawing.Size(50, 13)
        Me.TSFSecondsLabelBT.TabIndex = 91
        Me.TSFSecondsLabelBT.Text = "seconds"
        '
        'TSFSecondLabelBT
        '
        Me.TSFSecondLabelBT.AutoSize = True
        Me.TSFSecondLabelBT.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSFSecondLabelBT.Location = New System.Drawing.Point(40, 32)
        Me.TSFSecondLabelBT.Name = "TSFSecondLabelBT"
        Me.TSFSecondLabelBT.Size = New System.Drawing.Size(40, 12)
        Me.TSFSecondLabelBT.TabIndex = 90
        Me.TSFSecondLabelBT.Text = "second"
        '
        'TSFMinAndLabelBT
        '
        Me.TSFMinAndLabelBT.AutoSize = True
        Me.TSFMinAndLabelBT.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSFMinAndLabelBT.Location = New System.Drawing.Point(27, 22)
        Me.TSFMinAndLabelBT.Name = "TSFMinAndLabelBT"
        Me.TSFMinAndLabelBT.Size = New System.Drawing.Size(71, 13)
        Me.TSFMinAndLabelBT.TabIndex = 89
        Me.TSFMinAndLabelBT.Text = "minute and"
        Me.TSFMinAndLabelBT.Visible = False
        '
        'TSFMinsAndLabelBT
        '
        Me.TSFMinsAndLabelBT.AutoSize = True
        Me.TSFMinsAndLabelBT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSFMinsAndLabelBT.Location = New System.Drawing.Point(27, 22)
        Me.TSFMinsAndLabelBT.Name = "TSFMinsAndLabelBT"
        Me.TSFMinsAndLabelBT.Size = New System.Drawing.Size(65, 14)
        Me.TSFMinsAndLabelBT.TabIndex = 88
        Me.TSFMinsAndLabelBT.Text = "minutes and"
        '
        'TSFSecondIndicatorLabelBT
        '
        Me.TSFSecondIndicatorLabelBT.AutoSize = True
        Me.TSFSecondIndicatorLabelBT.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSFSecondIndicatorLabelBT.Location = New System.Drawing.Point(2, 32)
        Me.TSFSecondIndicatorLabelBT.Name = "TSFSecondIndicatorLabelBT"
        Me.TSFSecondIndicatorLabelBT.Size = New System.Drawing.Size(13, 13)
        Me.TSFSecondIndicatorLabelBT.TabIndex = 85
        Me.TSFSecondIndicatorLabelBT.Text = "--"
        '
        'TSFMinIndicatorLabelBT
        '
        Me.TSFMinIndicatorLabelBT.AutoSize = True
        Me.TSFMinIndicatorLabelBT.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSFMinIndicatorLabelBT.Location = New System.Drawing.Point(2, 23)
        Me.TSFMinIndicatorLabelBT.Name = "TSFMinIndicatorLabelBT"
        Me.TSFMinIndicatorLabelBT.Size = New System.Drawing.Size(13, 12)
        Me.TSFMinIndicatorLabelBT.TabIndex = 84
        Me.TSFMinIndicatorLabelBT.Text = "--"
        '
        'TSFHourIndicatorLabelBT
        '
        Me.TSFHourIndicatorLabelBT.AutoSize = True
        Me.TSFHourIndicatorLabelBT.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSFHourIndicatorLabelBT.Location = New System.Drawing.Point(1, 13)
        Me.TSFHourIndicatorLabelBT.Name = "TSFHourIndicatorLabelBT"
        Me.TSFHourIndicatorLabelBT.Size = New System.Drawing.Size(13, 13)
        Me.TSFHourIndicatorLabelBT.TabIndex = 83
        Me.TSFHourIndicatorLabelBT.Text = "--"
        '
        'TSFHourAndLabelBT
        '
        Me.TSFHourAndLabelBT.AutoSize = True
        Me.TSFHourAndLabelBT.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSFHourAndLabelBT.Location = New System.Drawing.Point(26, 12)
        Me.TSFHourAndLabelBT.Name = "TSFHourAndLabelBT"
        Me.TSFHourAndLabelBT.Size = New System.Drawing.Size(57, 13)
        Me.TSFHourAndLabelBT.TabIndex = 87
        Me.TSFHourAndLabelBT.Text = "hour and"
        Me.TSFHourAndLabelBT.Visible = False
        '
        'TSFHoursAndLabelBT
        '
        Me.TSFHoursAndLabelBT.AutoSize = True
        Me.TSFHoursAndLabelBT.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSFHoursAndLabelBT.Location = New System.Drawing.Point(26, 13)
        Me.TSFHoursAndLabelBT.Name = "TSFHoursAndLabelBT"
        Me.TSFHoursAndLabelBT.Size = New System.Drawing.Size(53, 12)
        Me.TSFHoursAndLabelBT.TabIndex = 86
        Me.TSFHoursAndLabelBT.Text = "hours and"
        '
        'ControlsGroupBoxBT
        '
        Me.ControlsGroupBoxBT.Controls.Add(Me.StartButtonBT)
        Me.ControlsGroupBoxBT.Controls.Add(Me.btnResume)
        Me.ControlsGroupBoxBT.Controls.Add(Me.btnStop)
        Me.ControlsGroupBoxBT.Controls.Add(Me.PauseButtonBT)
        Me.ControlsGroupBoxBT.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControlsGroupBoxBT.Location = New System.Drawing.Point(42, 22)
        Me.ControlsGroupBoxBT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ControlsGroupBoxBT.Name = "ControlsGroupBoxBT"
        Me.ControlsGroupBoxBT.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ControlsGroupBoxBT.Size = New System.Drawing.Size(290, 104)
        Me.ControlsGroupBoxBT.TabIndex = 53
        Me.ControlsGroupBoxBT.TabStop = False
        Me.ControlsGroupBoxBT.Text = "Controls"
        '
        'StartButtonBT
        '
        Me.StartButtonBT.BackColor = System.Drawing.Color.Transparent
        Me.StartButtonBT.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartButtonBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.StartButtonBT.ImageKey = "play.ico"
        Me.StartButtonBT.ImageList = Me.IconsIL
        Me.StartButtonBT.Location = New System.Drawing.Point(8, 12)
        Me.StartButtonBT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StartButtonBT.Name = "StartButtonBT"
        Me.StartButtonBT.Size = New System.Drawing.Size(123, 42)
        Me.StartButtonBT.TabIndex = 55
        Me.StartButtonBT.Text = "Start"
        Me.StartButtonBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.StartButtonBT.UseVisualStyleBackColor = False
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
        '
        'btnResume
        '
        Me.btnResume.BackColor = System.Drawing.Color.Transparent
        Me.btnResume.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResume.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnResume.ImageIndex = 5
        Me.btnResume.ImageList = Me.IconsIL
        Me.btnResume.Location = New System.Drawing.Point(138, 58)
        Me.btnResume.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnResume.Name = "btnResume"
        Me.btnResume.Size = New System.Drawing.Size(145, 41)
        Me.btnResume.TabIndex = 57
        Me.btnResume.Text = "Resume"
        Me.btnResume.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnResume.UseVisualStyleBackColor = False
        Me.btnResume.Visible = False
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.Transparent
        Me.btnStop.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStop.ImageIndex = 3
        Me.btnStop.ImageList = Me.IconsIL
        Me.btnStop.Location = New System.Drawing.Point(138, 12)
        Me.btnStop.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(145, 42)
        Me.btnStop.TabIndex = 58
        Me.btnStop.Text = "Stop"
        Me.btnStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStop.UseVisualStyleBackColor = False
        Me.btnStop.Visible = False
        '
        'PauseButtonBT
        '
        Me.PauseButtonBT.BackColor = System.Drawing.Color.Transparent
        Me.PauseButtonBT.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PauseButtonBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PauseButtonBT.ImageIndex = 3
        Me.PauseButtonBT.ImageList = Me.IconsIL
        Me.PauseButtonBT.Location = New System.Drawing.Point(8, 58)
        Me.PauseButtonBT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PauseButtonBT.Name = "PauseButtonBT"
        Me.PauseButtonBT.Size = New System.Drawing.Size(123, 40)
        Me.PauseButtonBT.TabIndex = 56
        Me.PauseButtonBT.Text = "Pause"
        Me.PauseButtonBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PauseButtonBT.UseVisualStyleBackColor = False
        Me.PauseButtonBT.Visible = False
        '
        'TimerGBBt
        '
        Me.TimerGBBt.Controls.Add(Me.TimeSelectIndicatorLabelBT)
        Me.TimerGBBt.Controls.Add(Me.TimeSelectLabelBT)
        Me.TimerGBBt.Controls.Add(Me.BreakTimeIndicatorALabelBT)
        Me.TimerGBBt.Controls.Add(Me.VisualRbBt)
        Me.TimerGBBt.Controls.Add(Me.BreakTimeSelectALabelBT)
        Me.TimerGBBt.Controls.Add(Me.nudTimeHour)
        Me.TimerGBBt.Controls.Add(Me.AudioRbBt)
        Me.TimerGBBt.Controls.Add(Me.TimeLabelBt)
        Me.TimerGBBt.Controls.Add(Me.MWLabelBt)
        Me.TimerGBBt.Controls.Add(Me.MinWarnNudBt)
        Me.TimerGBBt.Controls.Add(Me.BreakTimerALabelBT)
        Me.TimerGBBt.Controls.Add(Me.nudTimeMin)
        Me.TimerGBBt.Controls.Add(Me.nudTimeBreakSec)
        Me.TimerGBBt.Controls.Add(Me.nudTimeSec)
        Me.TimerGBBt.Controls.Add(Me.nudTimeBreakMin)
        Me.TimerGBBt.Controls.Add(Me.nudTimeBreakHour)
        Me.TimerGBBt.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimerGBBt.Location = New System.Drawing.Point(342, 12)
        Me.TimerGBBt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TimerGBBt.Name = "TimerGBBt"
        Me.TimerGBBt.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TimerGBBt.Size = New System.Drawing.Size(297, 113)
        Me.TimerGBBt.TabIndex = 49
        Me.TimerGBBt.TabStop = False
        Me.TimerGBBt.Text = "Timer Settings"
        '
        'TimeSelectIndicatorLabelBT
        '
        Me.TimeSelectIndicatorLabelBT.AutoSize = True
        Me.TimeSelectIndicatorLabelBT.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeSelectIndicatorLabelBT.Location = New System.Drawing.Point(147, 86)
        Me.TimeSelectIndicatorLabelBT.Name = "TimeSelectIndicatorLabelBT"
        Me.TimeSelectIndicatorLabelBT.Size = New System.Drawing.Size(55, 13)
        Me.TimeSelectIndicatorLabelBT.TabIndex = 64
        Me.TimeSelectIndicatorLabelBT.Text = "00:00:00"
        '
        'TimeSelectLabelBT
        '
        Me.TimeSelectLabelBT.AutoSize = True
        Me.TimeSelectLabelBT.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeSelectLabelBT.Location = New System.Drawing.Point(91, 86)
        Me.TimeSelectLabelBT.Name = "TimeSelectLabelBT"
        Me.TimeSelectLabelBT.Size = New System.Drawing.Size(40, 13)
        Me.TimeSelectLabelBT.TabIndex = 63
        Me.TimeSelectLabelBT.Text = "Time:"
        '
        'BreakTimeIndicatorALabelBT
        '
        Me.BreakTimeIndicatorALabelBT.AutoSize = True
        Me.BreakTimeIndicatorALabelBT.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BreakTimeIndicatorALabelBT.Location = New System.Drawing.Point(147, 97)
        Me.BreakTimeIndicatorALabelBT.Name = "BreakTimeIndicatorALabelBT"
        Me.BreakTimeIndicatorALabelBT.Size = New System.Drawing.Size(55, 13)
        Me.BreakTimeIndicatorALabelBT.TabIndex = 46
        Me.BreakTimeIndicatorALabelBT.Text = "00:00:00"
        '
        'VisualRbBt
        '
        Me.VisualRbBt.AutoSize = True
        Me.VisualRbBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VisualRbBt.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VisualRbBt.Location = New System.Drawing.Point(219, 63)
        Me.VisualRbBt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.VisualRbBt.Name = "VisualRbBt"
        Me.VisualRbBt.Size = New System.Drawing.Size(61, 17)
        Me.VisualRbBt.TabIndex = 62
        Me.VisualRbBt.TabStop = True
        Me.VisualRbBt.Text = "Visual"
        Me.VisualRbBt.UseVisualStyleBackColor = False
        '
        'BreakTimeSelectALabelBT
        '
        Me.BreakTimeSelectALabelBT.AutoSize = True
        Me.BreakTimeSelectALabelBT.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BreakTimeSelectALabelBT.Location = New System.Drawing.Point(54, 95)
        Me.BreakTimeSelectALabelBT.Name = "BreakTimeSelectALabelBT"
        Me.BreakTimeSelectALabelBT.Size = New System.Drawing.Size(77, 13)
        Me.BreakTimeSelectALabelBT.TabIndex = 45
        Me.BreakTimeSelectALabelBT.Text = "Break Time:"
        '
        'nudTimeHour
        '
        Me.nudTimeHour.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudTimeHour.Location = New System.Drawing.Point(96, 15)
        Me.nudTimeHour.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nudTimeHour.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudTimeHour.Name = "nudTimeHour"
        Me.nudTimeHour.Size = New System.Drawing.Size(56, 20)
        Me.nudTimeHour.TabIndex = 34
        '
        'AudioRbBt
        '
        Me.AudioRbBt.AutoSize = True
        Me.AudioRbBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AudioRbBt.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AudioRbBt.Location = New System.Drawing.Point(157, 63)
        Me.AudioRbBt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AudioRbBt.Name = "AudioRbBt"
        Me.AudioRbBt.Size = New System.Drawing.Size(59, 17)
        Me.AudioRbBt.TabIndex = 61
        Me.AudioRbBt.TabStop = True
        Me.AudioRbBt.Text = "Audio"
        Me.AudioRbBt.UseVisualStyleBackColor = False
        '
        'TimeLabelBt
        '
        Me.TimeLabelBt.AutoSize = True
        Me.TimeLabelBt.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLabelBt.Location = New System.Drawing.Point(32, 15)
        Me.TimeLabelBt.Name = "TimeLabelBt"
        Me.TimeLabelBt.Size = New System.Drawing.Size(40, 13)
        Me.TimeLabelBt.TabIndex = 29
        Me.TimeLabelBt.Text = "Time:"
        '
        'MWLabelBt
        '
        Me.MWLabelBt.AutoSize = True
        Me.MWLabelBt.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MWLabelBt.Location = New System.Drawing.Point(8, 59)
        Me.MWLabelBt.Name = "MWLabelBt"
        Me.MWLabelBt.Size = New System.Drawing.Size(62, 13)
        Me.MWLabelBt.TabIndex = 43
        Me.MWLabelBt.Text = "MinWarn:"
        '
        'MinWarnNudBt
        '
        Me.MinWarnNudBt.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinWarnNudBt.Location = New System.Drawing.Point(96, 59)
        Me.MinWarnNudBt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinWarnNudBt.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.MinWarnNudBt.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MinWarnNudBt.Name = "MinWarnNudBt"
        Me.MinWarnNudBt.Size = New System.Drawing.Size(54, 20)
        Me.MinWarnNudBt.TabIndex = 60
        Me.MinWarnNudBt.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'BreakTimerALabelBT
        '
        Me.BreakTimerALabelBT.AutoSize = True
        Me.BreakTimerALabelBT.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BreakTimerALabelBT.Location = New System.Drawing.Point(25, 39)
        Me.BreakTimerALabelBT.Name = "BreakTimerALabelBT"
        Me.BreakTimerALabelBT.Size = New System.Drawing.Size(44, 13)
        Me.BreakTimerALabelBT.TabIndex = 31
        Me.BreakTimerALabelBT.Text = "Break:"
        '
        'nudTimeMin
        '
        Me.nudTimeMin.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudTimeMin.Location = New System.Drawing.Point(160, 15)
        Me.nudTimeMin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nudTimeMin.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudTimeMin.Name = "nudTimeMin"
        Me.nudTimeMin.Size = New System.Drawing.Size(55, 20)
        Me.nudTimeMin.TabIndex = 35
        '
        'nudTimeBreakSec
        '
        Me.nudTimeBreakSec.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudTimeBreakSec.Location = New System.Drawing.Point(223, 38)
        Me.nudTimeBreakSec.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nudTimeBreakSec.Name = "nudTimeBreakSec"
        Me.nudTimeBreakSec.Size = New System.Drawing.Size(54, 20)
        Me.nudTimeBreakSec.TabIndex = 39
        '
        'nudTimeSec
        '
        Me.nudTimeSec.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudTimeSec.Location = New System.Drawing.Point(223, 15)
        Me.nudTimeSec.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nudTimeSec.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudTimeSec.Name = "nudTimeSec"
        Me.nudTimeSec.Size = New System.Drawing.Size(54, 20)
        Me.nudTimeSec.TabIndex = 36
        '
        'nudTimeBreakMin
        '
        Me.nudTimeBreakMin.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudTimeBreakMin.Location = New System.Drawing.Point(160, 38)
        Me.nudTimeBreakMin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nudTimeBreakMin.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudTimeBreakMin.Name = "nudTimeBreakMin"
        Me.nudTimeBreakMin.Size = New System.Drawing.Size(55, 20)
        Me.nudTimeBreakMin.TabIndex = 38
        '
        'nudTimeBreakHour
        '
        Me.nudTimeBreakHour.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudTimeBreakHour.Location = New System.Drawing.Point(96, 38)
        Me.nudTimeBreakHour.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nudTimeBreakHour.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudTimeBreakHour.Name = "nudTimeBreakHour"
        Me.nudTimeBreakHour.Size = New System.Drawing.Size(56, 20)
        Me.nudTimeBreakHour.TabIndex = 37
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
        Me.StatusGroupBoxBT.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusGroupBoxBT.Location = New System.Drawing.Point(344, 131)
        Me.StatusGroupBoxBT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StatusGroupBoxBT.Name = "StatusGroupBoxBT"
        Me.StatusGroupBoxBT.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StatusGroupBoxBT.Size = New System.Drawing.Size(150, 49)
        Me.StatusGroupBoxBT.TabIndex = 84
        Me.StatusGroupBoxBT.TabStop = False
        Me.StatusGroupBoxBT.Text = "Status"
        '
        'lblsecondsbreak
        '
        Me.lblsecondsbreak.AutoSize = True
        Me.lblsecondsbreak.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsecondsbreak.Location = New System.Drawing.Point(41, 32)
        Me.lblsecondsbreak.Name = "lblsecondsbreak"
        Me.lblsecondsbreak.Size = New System.Drawing.Size(50, 13)
        Me.lblsecondsbreak.TabIndex = 91
        Me.lblsecondsbreak.Text = "seconds"
        '
        'lblsecondbreak
        '
        Me.lblsecondbreak.AutoSize = True
        Me.lblsecondbreak.Location = New System.Drawing.Point(54, 33)
        Me.lblsecondbreak.Name = "lblsecondbreak"
        Me.lblsecondbreak.Size = New System.Drawing.Size(45, 13)
        Me.lblsecondbreak.TabIndex = 90
        Me.lblsecondbreak.Text = "second"
        '
        'lblminuteandbreak
        '
        Me.lblminuteandbreak.AutoSize = True
        Me.lblminuteandbreak.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblminuteandbreak.Location = New System.Drawing.Point(40, 22)
        Me.lblminuteandbreak.Name = "lblminuteandbreak"
        Me.lblminuteandbreak.Size = New System.Drawing.Size(71, 13)
        Me.lblminuteandbreak.TabIndex = 89
        Me.lblminuteandbreak.Text = "minute and"
        Me.lblminuteandbreak.Visible = False
        '
        'lblminutesandbreak
        '
        Me.lblminutesandbreak.AutoSize = True
        Me.lblminutesandbreak.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblminutesandbreak.Location = New System.Drawing.Point(41, 22)
        Me.lblminutesandbreak.Name = "lblminutesandbreak"
        Me.lblminutesandbreak.Size = New System.Drawing.Size(76, 13)
        Me.lblminutesandbreak.TabIndex = 88
        Me.lblminutesandbreak.Text = "minutes and"
        '
        'lblsec
        '
        Me.lblsec.AutoSize = True
        Me.lblsec.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsec.Location = New System.Drawing.Point(16, 33)
        Me.lblsec.Name = "lblsec"
        Me.lblsec.Size = New System.Drawing.Size(13, 12)
        Me.lblsec.TabIndex = 85
        Me.lblsec.Text = "--"
        '
        'lblminute
        '
        Me.lblminute.AutoSize = True
        Me.lblminute.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblminute.Location = New System.Drawing.Point(16, 23)
        Me.lblminute.Name = "lblminute"
        Me.lblminute.Size = New System.Drawing.Size(13, 12)
        Me.lblminute.TabIndex = 84
        Me.lblminute.Text = "--"
        '
        'HourLabelBT
        '
        Me.HourLabelBT.AutoSize = True
        Me.HourLabelBT.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HourLabelBT.Location = New System.Drawing.Point(16, 12)
        Me.HourLabelBT.Name = "HourLabelBT"
        Me.HourLabelBT.Size = New System.Drawing.Size(13, 12)
        Me.HourLabelBT.TabIndex = 83
        Me.HourLabelBT.Text = "--"
        '
        'HourAndBreakLabelBT
        '
        Me.HourAndBreakLabelBT.AutoSize = True
        Me.HourAndBreakLabelBT.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HourAndBreakLabelBT.Location = New System.Drawing.Point(41, 9)
        Me.HourAndBreakLabelBT.Name = "HourAndBreakLabelBT"
        Me.HourAndBreakLabelBT.Size = New System.Drawing.Size(57, 13)
        Me.HourAndBreakLabelBT.TabIndex = 87
        Me.HourAndBreakLabelBT.Text = "hour and"
        Me.HourAndBreakLabelBT.Visible = False
        '
        'lblhoursandbreak
        '
        Me.lblhoursandbreak.AutoSize = True
        Me.lblhoursandbreak.Location = New System.Drawing.Point(41, 12)
        Me.lblhoursandbreak.Name = "lblhoursandbreak"
        Me.lblhoursandbreak.Size = New System.Drawing.Size(62, 13)
        Me.lblhoursandbreak.TabIndex = 86
        Me.lblhoursandbreak.Text = "hours and"
        '
        'BTime
        '
        Me.BTime.Controls.Add(Me.BreakNowButtonBt)
        Me.BTime.Controls.Add(Me.BreakGBBt)
        Me.BTime.ImageIndex = 1
        Me.BTime.Location = New System.Drawing.Point(4, 23)
        Me.BTime.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTime.Name = "BTime"
        Me.BTime.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTime.Size = New System.Drawing.Size(718, 262)
        Me.BTime.TabIndex = 5
        Me.BTime.Text = "Break"
        '
        'BreakNowButtonBt
        '
        Me.BreakNowButtonBt.BackColor = System.Drawing.Color.Transparent
        Me.BreakNowButtonBt.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BreakNowButtonBt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BreakNowButtonBt.ImageKey = "play.ico"
        Me.BreakNowButtonBt.ImageList = Me.IconsIL
        Me.BreakNowButtonBt.Location = New System.Drawing.Point(288, 86)
        Me.BreakNowButtonBt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BreakNowButtonBt.Name = "BreakNowButtonBt"
        Me.BreakNowButtonBt.Size = New System.Drawing.Size(109, 25)
        Me.BreakNowButtonBt.TabIndex = 85
        Me.BreakNowButtonBt.Text = "Start"
        Me.BreakNowButtonBt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BreakNowButtonBt.UseVisualStyleBackColor = False
        '
        'BreakGBBt
        '
        Me.BreakGBBt.Controls.Add(Me.BreakTimeLabelBT)
        Me.BreakGBBt.Controls.Add(Me.BreakTimeSelectLabelBT)
        Me.BreakGBBt.Controls.Add(Me.BreakLabelBT)
        Me.BreakGBBt.Controls.Add(Me.B1HourNudBT)
        Me.BreakGBBt.Controls.Add(Me.nudb1sec)
        Me.BreakGBBt.Controls.Add(Me.nudb1min)
        Me.BreakGBBt.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BreakGBBt.Location = New System.Drawing.Point(207, 15)
        Me.BreakGBBt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BreakGBBt.Name = "BreakGBBt"
        Me.BreakGBBt.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BreakGBBt.Size = New System.Drawing.Size(290, 52)
        Me.BreakGBBt.TabIndex = 84
        Me.BreakGBBt.TabStop = False
        Me.BreakGBBt.Text = "Break Settings"
        '
        'BreakTimeLabelBT
        '
        Me.BreakTimeLabelBT.AutoSize = True
        Me.BreakTimeLabelBT.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BreakTimeLabelBT.Location = New System.Drawing.Point(105, 35)
        Me.BreakTimeLabelBT.Name = "BreakTimeLabelBT"
        Me.BreakTimeLabelBT.Size = New System.Drawing.Size(55, 13)
        Me.BreakTimeLabelBT.TabIndex = 44
        Me.BreakTimeLabelBT.Text = "00:00:00"
        '
        'BreakTimeSelectLabelBT
        '
        Me.BreakTimeSelectLabelBT.AutoSize = True
        Me.BreakTimeSelectLabelBT.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BreakTimeSelectLabelBT.Location = New System.Drawing.Point(15, 35)
        Me.BreakTimeSelectLabelBT.Name = "BreakTimeSelectLabelBT"
        Me.BreakTimeSelectLabelBT.Size = New System.Drawing.Size(77, 13)
        Me.BreakTimeSelectLabelBT.TabIndex = 43
        Me.BreakTimeSelectLabelBT.Text = "Break Time:"
        '
        'BreakLabelBT
        '
        Me.BreakLabelBT.AutoSize = True
        Me.BreakLabelBT.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BreakLabelBT.Location = New System.Drawing.Point(15, 12)
        Me.BreakLabelBT.Name = "BreakLabelBT"
        Me.BreakLabelBT.Size = New System.Drawing.Size(44, 13)
        Me.BreakLabelBT.TabIndex = 33
        Me.BreakLabelBT.Text = "Break:"
        '
        'B1HourNudBT
        '
        Me.B1HourNudBT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.B1HourNudBT.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B1HourNudBT.Location = New System.Drawing.Point(81, 11)
        Me.B1HourNudBT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.B1HourNudBT.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.B1HourNudBT.Name = "B1HourNudBT"
        Me.B1HourNudBT.Size = New System.Drawing.Size(49, 20)
        Me.B1HourNudBT.TabIndex = 40
        '
        'nudb1sec
        '
        Me.nudb1sec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudb1sec.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudb1sec.Location = New System.Drawing.Point(199, 11)
        Me.nudb1sec.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nudb1sec.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudb1sec.Name = "nudb1sec"
        Me.nudb1sec.Size = New System.Drawing.Size(56, 20)
        Me.nudb1sec.TabIndex = 42
        '
        'nudb1min
        '
        Me.nudb1min.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudb1min.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudb1min.Location = New System.Drawing.Point(138, 11)
        Me.nudb1min.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nudb1min.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudb1min.Name = "nudb1min"
        Me.nudb1min.Size = New System.Drawing.Size(51, 20)
        Me.nudb1min.TabIndex = 41
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
        Me.TimerTab.Size = New System.Drawing.Size(718, 262)
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
        Me.TSFGroupBoxT.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSFGroupBoxT.Location = New System.Drawing.Point(299, 94)
        Me.TSFGroupBoxT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TSFGroupBoxT.Name = "TSFGroupBoxT"
        Me.TSFGroupBoxT.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TSFGroupBoxT.Size = New System.Drawing.Size(150, 49)
        Me.TSFGroupBoxT.TabIndex = 92
        Me.TSFGroupBoxT.TabStop = False
        Me.TSFGroupBoxT.Text = "Set For"
        '
        'lblsfsecondstime
        '
        Me.lblsfsecondstime.AutoSize = True
        Me.lblsfsecondstime.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsfsecondstime.Location = New System.Drawing.Point(41, 33)
        Me.lblsfsecondstime.Name = "lblsfsecondstime"
        Me.lblsfsecondstime.Size = New System.Drawing.Size(50, 13)
        Me.lblsfsecondstime.TabIndex = 91
        Me.lblsfsecondstime.Text = "seconds"
        '
        'TSFSecondLabelT
        '
        Me.TSFSecondLabelT.AutoSize = True
        Me.TSFSecondLabelT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSFSecondLabelT.Location = New System.Drawing.Point(54, 33)
        Me.TSFSecondLabelT.Name = "TSFSecondLabelT"
        Me.TSFSecondLabelT.Size = New System.Drawing.Size(48, 14)
        Me.TSFSecondLabelT.TabIndex = 90
        Me.TSFSecondLabelT.Text = "second"
        '
        'SFMinAndLabelT
        '
        Me.SFMinAndLabelT.AutoSize = True
        Me.SFMinAndLabelT.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SFMinAndLabelT.Location = New System.Drawing.Point(41, 22)
        Me.SFMinAndLabelT.Name = "SFMinAndLabelT"
        Me.SFMinAndLabelT.Size = New System.Drawing.Size(71, 13)
        Me.SFMinAndLabelT.TabIndex = 89
        Me.SFMinAndLabelT.Text = "minute and"
        Me.SFMinAndLabelT.Visible = False
        '
        'TSFMinsAndLabelT
        '
        Me.TSFMinsAndLabelT.AutoSize = True
        Me.TSFMinsAndLabelT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSFMinsAndLabelT.Location = New System.Drawing.Point(41, 22)
        Me.TSFMinsAndLabelT.Name = "TSFMinsAndLabelT"
        Me.TSFMinsAndLabelT.Size = New System.Drawing.Size(76, 14)
        Me.TSFMinsAndLabelT.TabIndex = 88
        Me.TSFMinsAndLabelT.Text = "minutes and"
        '
        'TSFSecondIndicatorLabelT
        '
        Me.TSFSecondIndicatorLabelT.AutoSize = True
        Me.TSFSecondIndicatorLabelT.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSFSecondIndicatorLabelT.Location = New System.Drawing.Point(16, 33)
        Me.TSFSecondIndicatorLabelT.Name = "TSFSecondIndicatorLabelT"
        Me.TSFSecondIndicatorLabelT.Size = New System.Drawing.Size(13, 13)
        Me.TSFSecondIndicatorLabelT.TabIndex = 85
        Me.TSFSecondIndicatorLabelT.Text = "--"
        '
        'TSFMinIndicatorLabelT
        '
        Me.TSFMinIndicatorLabelT.AutoSize = True
        Me.TSFMinIndicatorLabelT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSFMinIndicatorLabelT.Location = New System.Drawing.Point(16, 23)
        Me.TSFMinIndicatorLabelT.Name = "TSFMinIndicatorLabelT"
        Me.TSFMinIndicatorLabelT.Size = New System.Drawing.Size(15, 14)
        Me.TSFMinIndicatorLabelT.TabIndex = 84
        Me.TSFMinIndicatorLabelT.Text = "--"
        '
        'TSFHourIndicatorLabelT
        '
        Me.TSFHourIndicatorLabelT.AutoSize = True
        Me.TSFHourIndicatorLabelT.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSFHourIndicatorLabelT.Location = New System.Drawing.Point(16, 12)
        Me.TSFHourIndicatorLabelT.Name = "TSFHourIndicatorLabelT"
        Me.TSFHourIndicatorLabelT.Size = New System.Drawing.Size(13, 13)
        Me.TSFHourIndicatorLabelT.TabIndex = 83
        Me.TSFHourIndicatorLabelT.Text = "--"
        '
        'lblsfhoursandtime
        '
        Me.lblsfhoursandtime.AutoSize = True
        Me.lblsfhoursandtime.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsfhoursandtime.Location = New System.Drawing.Point(41, 12)
        Me.lblsfhoursandtime.Name = "lblsfhoursandtime"
        Me.lblsfhoursandtime.Size = New System.Drawing.Size(57, 13)
        Me.lblsfhoursandtime.TabIndex = 87
        Me.lblsfhoursandtime.Text = "hour and"
        Me.lblsfhoursandtime.Visible = False
        '
        'TSFHoursAndLabelT
        '
        Me.TSFHoursAndLabelT.AutoSize = True
        Me.TSFHoursAndLabelT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSFHoursAndLabelT.Location = New System.Drawing.Point(41, 12)
        Me.TSFHoursAndLabelT.Name = "TSFHoursAndLabelT"
        Me.TSFHoursAndLabelT.Size = New System.Drawing.Size(63, 14)
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
        Me.StatusGroupBoxT.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusGroupBoxT.Location = New System.Drawing.Point(142, 94)
        Me.StatusGroupBoxT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StatusGroupBoxT.Name = "StatusGroupBoxT"
        Me.StatusGroupBoxT.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StatusGroupBoxT.Size = New System.Drawing.Size(150, 49)
        Me.StatusGroupBoxT.TabIndex = 85
        Me.StatusGroupBoxT.TabStop = False
        Me.StatusGroupBoxT.Text = "Status"
        '
        'SecondsLabelT
        '
        Me.SecondsLabelT.AutoSize = True
        Me.SecondsLabelT.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecondsLabelT.Location = New System.Drawing.Point(41, 33)
        Me.SecondsLabelT.Name = "SecondsLabelT"
        Me.SecondsLabelT.Size = New System.Drawing.Size(50, 13)
        Me.SecondsLabelT.TabIndex = 91
        Me.SecondsLabelT.Text = "seconds"
        '
        'lblsecondtime
        '
        Me.lblsecondtime.AutoSize = True
        Me.lblsecondtime.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsecondtime.Location = New System.Drawing.Point(54, 33)
        Me.lblsecondtime.Name = "lblsecondtime"
        Me.lblsecondtime.Size = New System.Drawing.Size(48, 14)
        Me.lblsecondtime.TabIndex = 90
        Me.lblsecondtime.Text = "second"
        '
        'lblminuteandtime
        '
        Me.lblminuteandtime.AutoSize = True
        Me.lblminuteandtime.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblminuteandtime.Location = New System.Drawing.Point(41, 22)
        Me.lblminuteandtime.Name = "lblminuteandtime"
        Me.lblminuteandtime.Size = New System.Drawing.Size(71, 13)
        Me.lblminuteandtime.TabIndex = 89
        Me.lblminuteandtime.Text = "minute and"
        Me.lblminuteandtime.Visible = False
        '
        'lblminutesandtime
        '
        Me.lblminutesandtime.AutoSize = True
        Me.lblminutesandtime.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblminutesandtime.Location = New System.Drawing.Point(41, 22)
        Me.lblminutesandtime.Name = "lblminutesandtime"
        Me.lblminutesandtime.Size = New System.Drawing.Size(76, 13)
        Me.lblminutesandtime.TabIndex = 88
        Me.lblminutesandtime.Text = "minutes and"
        '
        'lblsectime
        '
        Me.lblsectime.AutoSize = True
        Me.lblsectime.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsectime.Location = New System.Drawing.Point(16, 33)
        Me.lblsectime.Name = "lblsectime"
        Me.lblsectime.Size = New System.Drawing.Size(13, 13)
        Me.lblsectime.TabIndex = 85
        Me.lblsectime.Text = "--"
        '
        'lblmintime
        '
        Me.lblmintime.AutoSize = True
        Me.lblmintime.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmintime.Location = New System.Drawing.Point(16, 23)
        Me.lblmintime.Name = "lblmintime"
        Me.lblmintime.Size = New System.Drawing.Size(13, 13)
        Me.lblmintime.TabIndex = 84
        Me.lblmintime.Text = "--"
        '
        'lblhourtime
        '
        Me.lblhourtime.AutoSize = True
        Me.lblhourtime.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhourtime.Location = New System.Drawing.Point(16, 12)
        Me.lblhourtime.Name = "lblhourtime"
        Me.lblhourtime.Size = New System.Drawing.Size(13, 13)
        Me.lblhourtime.TabIndex = 83
        Me.lblhourtime.Text = "--"
        '
        'lblhourandtime
        '
        Me.lblhourandtime.AutoSize = True
        Me.lblhourandtime.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhourandtime.Location = New System.Drawing.Point(41, 12)
        Me.lblhourandtime.Name = "lblhourandtime"
        Me.lblhourandtime.Size = New System.Drawing.Size(57, 13)
        Me.lblhourandtime.TabIndex = 87
        Me.lblhourandtime.Text = "hour and"
        Me.lblhourandtime.Visible = False
        '
        'lblhoursandtime
        '
        Me.lblhoursandtime.AutoSize = True
        Me.lblhoursandtime.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhoursandtime.Location = New System.Drawing.Point(41, 12)
        Me.lblhoursandtime.Name = "lblhoursandtime"
        Me.lblhoursandtime.Size = New System.Drawing.Size(63, 14)
        Me.lblhoursandtime.TabIndex = 86
        Me.lblhoursandtime.Text = "hours and"
        '
        'StartTimeButton
        '
        Me.StartTimeButton.BackColor = System.Drawing.Color.Transparent
        Me.StartTimeButton.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartTimeButton.Location = New System.Drawing.Point(154, 59)
        Me.StartTimeButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StartTimeButton.Name = "StartTimeButton"
        Me.StartTimeButton.Size = New System.Drawing.Size(82, 31)
        Me.StartTimeButton.TabIndex = 60
        Me.StartTimeButton.Text = "Start"
        Me.StartTimeButton.UseVisualStyleBackColor = False
        '
        'StopTimeButton
        '
        Me.StopTimeButton.BackColor = System.Drawing.Color.Transparent
        Me.StopTimeButton.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopTimeButton.Location = New System.Drawing.Point(240, 59)
        Me.StopTimeButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StopTimeButton.Name = "StopTimeButton"
        Me.StopTimeButton.Size = New System.Drawing.Size(82, 31)
        Me.StopTimeButton.TabIndex = 63
        Me.StopTimeButton.Text = "Stop"
        Me.StopTimeButton.UseVisualStyleBackColor = False
        Me.StopTimeButton.Visible = False
        '
        'PauseButtonT
        '
        Me.PauseButtonT.BackColor = System.Drawing.Color.Transparent
        Me.PauseButtonT.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PauseButtonT.Location = New System.Drawing.Point(425, 59)
        Me.PauseButtonT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PauseButtonT.Name = "PauseButtonT"
        Me.PauseButtonT.Size = New System.Drawing.Size(87, 31)
        Me.PauseButtonT.TabIndex = 61
        Me.PauseButtonT.Text = "Pause"
        Me.PauseButtonT.UseVisualStyleBackColor = False
        Me.PauseButtonT.Visible = False
        '
        'nudSec
        '
        Me.nudSec.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSec.Location = New System.Drawing.Point(375, 22)
        Me.nudSec.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nudSec.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudSec.Name = "nudSec"
        Me.nudSec.Size = New System.Drawing.Size(66, 20)
        Me.nudSec.TabIndex = 10
        '
        'nudMin
        '
        Me.nudMin.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudMin.Location = New System.Drawing.Point(299, 22)
        Me.nudMin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nudMin.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudMin.Name = "nudMin"
        Me.nudMin.Size = New System.Drawing.Size(66, 20)
        Me.nudMin.TabIndex = 9
        '
        'nudHour
        '
        Me.nudHour.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudHour.Location = New System.Drawing.Point(225, 22)
        Me.nudHour.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nudHour.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudHour.Name = "nudHour"
        Me.nudHour.Size = New System.Drawing.Size(66, 20)
        Me.nudHour.TabIndex = 8
        '
        'ResumeTimeButton
        '
        Me.ResumeTimeButton.BackColor = System.Drawing.Color.Transparent
        Me.ResumeTimeButton.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResumeTimeButton.Location = New System.Drawing.Point(330, 59)
        Me.ResumeTimeButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ResumeTimeButton.Name = "ResumeTimeButton"
        Me.ResumeTimeButton.Size = New System.Drawing.Size(87, 31)
        Me.ResumeTimeButton.TabIndex = 62
        Me.ResumeTimeButton.Text = "Resume"
        Me.ResumeTimeButton.UseVisualStyleBackColor = False
        Me.ResumeTimeButton.Visible = False
        '
        'AlarmClockTab
        '
        Me.AlarmClockTab.BackColor = System.Drawing.Color.DarkRed
        Me.AlarmClockTab.Controls.Add(Me.panelalert)
        Me.AlarmClockTab.Controls.Add(Me.HourNudAC)
        Me.AlarmClockTab.Controls.Add(Me.MinNudAC)
        Me.AlarmClockTab.Controls.Add(Me.SecNudAC)
        Me.AlarmClockTab.Controls.Add(Me.AlarmStatusLabel)
        Me.AlarmClockTab.Controls.Add(Me.CancelAlarmButton)
        Me.AlarmClockTab.Controls.Add(Me.SetAlarmButton)
        Me.AlarmClockTab.Controls.Add(Me.SetOrNotSetLabel)
        Me.AlarmClockTab.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlarmClockTab.Location = New System.Drawing.Point(4, 23)
        Me.AlarmClockTab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AlarmClockTab.Name = "AlarmClockTab"
        Me.AlarmClockTab.Size = New System.Drawing.Size(718, 262)
        Me.AlarmClockTab.TabIndex = 2
        Me.AlarmClockTab.Text = "Alarm Clock (DEPRECIATED)"
        '
        'panelalert
        '
        Me.panelalert.BackColor = System.Drawing.Color.Red
        Me.panelalert.Controls.Add(Me.btnLM)
        Me.panelalert.Controls.Add(Me.Label2)
        Me.panelalert.Controls.Add(Me.Label1)
        Me.panelalert.Controls.Add(Me.PictureBox2)
        Me.panelalert.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelalert.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelalert.ForeColor = System.Drawing.Color.DarkRed
        Me.panelalert.Location = New System.Drawing.Point(0, 0)
        Me.panelalert.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panelalert.Name = "panelalert"
        Me.panelalert.Size = New System.Drawing.Size(718, 60)
        Me.panelalert.TabIndex = 40
        '
        'btnLM
        '
        Me.btnLM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLM.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLM.ForeColor = System.Drawing.Color.Yellow
        Me.btnLM.Location = New System.Drawing.Point(553, 3)
        Me.btnLM.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLM.Name = "btnLM"
        Me.btnLM.Size = New System.Drawing.Size(151, 54)
        Me.btnLM.TabIndex = 88
        Me.btnLM.Text = "Click me to learn more"
        Me.btnLM.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(256, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(290, 42)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "This feature will be discontinued" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "on September 15 2021. Please click on the butt" &
    "on for" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "more information."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(83, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 22)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "Last Warning!"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(11, 3)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(51, 39)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'HourNudAC
        '
        Me.HourNudAC.BackColor = System.Drawing.Color.DarkRed
        Me.HourNudAC.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HourNudAC.ForeColor = System.Drawing.Color.Red
        Me.HourNudAC.Location = New System.Drawing.Point(259, 71)
        Me.HourNudAC.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.HourNudAC.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.HourNudAC.Name = "HourNudAC"
        Me.HourNudAC.Size = New System.Drawing.Size(56, 21)
        Me.HourNudAC.TabIndex = 37
        '
        'MinNudAC
        '
        Me.MinNudAC.BackColor = System.Drawing.Color.DarkRed
        Me.MinNudAC.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinNudAC.ForeColor = System.Drawing.Color.Red
        Me.MinNudAC.Location = New System.Drawing.Point(323, 71)
        Me.MinNudAC.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinNudAC.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.MinNudAC.Name = "MinNudAC"
        Me.MinNudAC.Size = New System.Drawing.Size(55, 21)
        Me.MinNudAC.TabIndex = 38
        '
        'SecNudAC
        '
        Me.SecNudAC.BackColor = System.Drawing.Color.DarkRed
        Me.SecNudAC.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecNudAC.ForeColor = System.Drawing.Color.Red
        Me.SecNudAC.Location = New System.Drawing.Point(386, 71)
        Me.SecNudAC.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SecNudAC.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.SecNudAC.Name = "SecNudAC"
        Me.SecNudAC.Size = New System.Drawing.Size(54, 21)
        Me.SecNudAC.TabIndex = 39
        '
        'AlarmStatusLabel
        '
        Me.AlarmStatusLabel.AutoSize = True
        Me.AlarmStatusLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.AlarmStatusLabel.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlarmStatusLabel.Location = New System.Drawing.Point(241, 113)
        Me.AlarmStatusLabel.Name = "AlarmStatusLabel"
        Me.AlarmStatusLabel.Size = New System.Drawing.Size(80, 14)
        Me.AlarmStatusLabel.TabIndex = 15
        Me.AlarmStatusLabel.Text = "Alarm Status:"
        '
        'CancelAlarmButton
        '
        Me.CancelAlarmButton.BackColor = System.Drawing.Color.Transparent
        Me.CancelAlarmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelAlarmButton.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelAlarmButton.Location = New System.Drawing.Point(354, 93)
        Me.CancelAlarmButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CancelAlarmButton.Name = "CancelAlarmButton"
        Me.CancelAlarmButton.Size = New System.Drawing.Size(99, 19)
        Me.CancelAlarmButton.TabIndex = 12
        Me.CancelAlarmButton.Text = "Cancel"
        Me.CancelAlarmButton.UseVisualStyleBackColor = False
        Me.CancelAlarmButton.Visible = False
        '
        'SetAlarmButton
        '
        Me.SetAlarmButton.BackColor = System.Drawing.Color.Transparent
        Me.SetAlarmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetAlarmButton.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetAlarmButton.Location = New System.Drawing.Point(247, 93)
        Me.SetAlarmButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SetAlarmButton.Name = "SetAlarmButton"
        Me.SetAlarmButton.Size = New System.Drawing.Size(99, 19)
        Me.SetAlarmButton.TabIndex = 11
        Me.SetAlarmButton.Text = "Set"
        Me.SetAlarmButton.UseVisualStyleBackColor = False
        '
        'SetOrNotSetLabel
        '
        Me.SetOrNotSetLabel.AutoSize = True
        Me.SetOrNotSetLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.SetOrNotSetLabel.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetOrNotSetLabel.Location = New System.Drawing.Point(354, 113)
        Me.SetOrNotSetLabel.Name = "SetOrNotSetLabel"
        Me.SetOrNotSetLabel.Size = New System.Drawing.Size(98, 14)
        Me.SetOrNotSetLabel.TabIndex = 10
        Me.SetOrNotSetLabel.Text = "Please set Alarm"
        '
        'StopWatchTab
        '
        Me.StopWatchTab.BackColor = System.Drawing.Color.DarkRed
        Me.StopWatchTab.Controls.Add(Me.Panel1)
        Me.StopWatchTab.Controls.Add(Me.LapListBoxSw)
        Me.StopWatchTab.Controls.Add(Me.LapButtonSW)
        Me.StopWatchTab.Controls.Add(Me.PauseButtonSW)
        Me.StopWatchTab.Controls.Add(Me.StopwatchLabelSW)
        Me.StopWatchTab.Controls.Add(Me.StartButtonSW)
        Me.StopWatchTab.Controls.Add(Me.StopButtonSW)
        Me.StopWatchTab.Controls.Add(Me.ResumeButtonSW)
        Me.StopWatchTab.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopWatchTab.Location = New System.Drawing.Point(4, 23)
        Me.StopWatchTab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StopWatchTab.Name = "StopWatchTab"
        Me.StopWatchTab.Size = New System.Drawing.Size(718, 262)
        Me.StopWatchTab.TabIndex = 3
        Me.StopWatchTab.Text = "Stopwatch (DEPRECIATED)"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Red
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(718, 62)
        Me.Panel1.TabIndex = 68
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(553, 3)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 54)
        Me.Button1.TabIndex = 88
        Me.Button1.Text = "Click me to learn more"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(253, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 28)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "This feature will be discontinued" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "on September 15, 2021."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(90, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 22)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "Last Warning!"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(9, 14)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(51, 39)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'LapListBoxSw
        '
        Me.LapListBoxSw.BackColor = System.Drawing.Color.DarkRed
        Me.LapListBoxSw.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LapListBoxSw.ForeColor = System.Drawing.Color.Red
        Me.LapListBoxSw.FormattingEnabled = True
        Me.LapListBoxSw.ItemHeight = 14
        Me.LapListBoxSw.Location = New System.Drawing.Point(215, 107)
        Me.LapListBoxSw.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LapListBoxSw.Name = "LapListBoxSw"
        Me.LapListBoxSw.Size = New System.Drawing.Size(275, 32)
        Me.LapListBoxSw.TabIndex = 65
        Me.LapListBoxSw.Visible = False
        '
        'LapButtonSW
        '
        Me.LapButtonSW.BackColor = System.Drawing.Color.DarkRed
        Me.LapButtonSW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LapButtonSW.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LapButtonSW.ForeColor = System.Drawing.Color.Red
        Me.LapButtonSW.Location = New System.Drawing.Point(498, 84)
        Me.LapButtonSW.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LapButtonSW.Name = "LapButtonSW"
        Me.LapButtonSW.Size = New System.Drawing.Size(99, 19)
        Me.LapButtonSW.TabIndex = 64
        Me.LapButtonSW.Text = "Lap"
        Me.LapButtonSW.UseVisualStyleBackColor = False
        '
        'PauseButtonSW
        '
        Me.PauseButtonSW.BackColor = System.Drawing.Color.DarkRed
        Me.PauseButtonSW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PauseButtonSW.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PauseButtonSW.ForeColor = System.Drawing.Color.Red
        Me.PauseButtonSW.Location = New System.Drawing.Point(310, 84)
        Me.PauseButtonSW.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PauseButtonSW.Name = "PauseButtonSW"
        Me.PauseButtonSW.Size = New System.Drawing.Size(87, 19)
        Me.PauseButtonSW.TabIndex = 61
        Me.PauseButtonSW.Text = "Pause"
        Me.PauseButtonSW.UseVisualStyleBackColor = False
        Me.PauseButtonSW.Visible = False
        '
        'StopwatchLabelSW
        '
        Me.StopwatchLabelSW.AutoSize = True
        Me.StopwatchLabelSW.BackColor = System.Drawing.Color.DarkRed
        Me.StopwatchLabelSW.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopwatchLabelSW.ForeColor = System.Drawing.Color.Red
        Me.StopwatchLabelSW.Location = New System.Drawing.Point(322, 73)
        Me.StopwatchLabelSW.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.StopwatchLabelSW.Name = "StopwatchLabelSW"
        Me.StopwatchLabelSW.Size = New System.Drawing.Size(33, 14)
        Me.StopwatchLabelSW.TabIndex = 59
        Me.StopwatchLabelSW.Text = "--:--:--"
        Me.StopwatchLabelSW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StartButtonSW
        '
        Me.StartButtonSW.BackColor = System.Drawing.Color.DarkRed
        Me.StartButtonSW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartButtonSW.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartButtonSW.ForeColor = System.Drawing.Color.Red
        Me.StartButtonSW.Location = New System.Drawing.Point(120, 84)
        Me.StartButtonSW.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StartButtonSW.Name = "StartButtonSW"
        Me.StartButtonSW.Size = New System.Drawing.Size(87, 19)
        Me.StartButtonSW.TabIndex = 60
        Me.StartButtonSW.Text = "Start"
        Me.StartButtonSW.UseVisualStyleBackColor = False
        '
        'StopButtonSW
        '
        Me.StopButtonSW.BackColor = System.Drawing.Color.DarkRed
        Me.StopButtonSW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StopButtonSW.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopButtonSW.ForeColor = System.Drawing.Color.Red
        Me.StopButtonSW.Location = New System.Drawing.Point(215, 84)
        Me.StopButtonSW.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StopButtonSW.Name = "StopButtonSW"
        Me.StopButtonSW.Size = New System.Drawing.Size(87, 19)
        Me.StopButtonSW.TabIndex = 67
        Me.StopButtonSW.Text = "Stop"
        Me.StopButtonSW.UseVisualStyleBackColor = False
        Me.StopButtonSW.Visible = False
        '
        'ResumeButtonSW
        '
        Me.ResumeButtonSW.BackColor = System.Drawing.Color.DarkRed
        Me.ResumeButtonSW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResumeButtonSW.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResumeButtonSW.ForeColor = System.Drawing.Color.Red
        Me.ResumeButtonSW.Location = New System.Drawing.Point(403, 84)
        Me.ResumeButtonSW.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ResumeButtonSW.Name = "ResumeButtonSW"
        Me.ResumeButtonSW.Size = New System.Drawing.Size(87, 19)
        Me.ResumeButtonSW.TabIndex = 66
        Me.ResumeButtonSW.Text = "Resume"
        Me.ResumeButtonSW.UseVisualStyleBackColor = False
        Me.ResumeButtonSW.Visible = False
        '
        'ShutdownTabPage
        '
        Me.ShutdownTabPage.BackColor = System.Drawing.Color.DarkRed
        Me.ShutdownTabPage.Controls.Add(Me.Panel2)
        Me.ShutdownTabPage.Controls.Add(Me.StatusGroupBoxSH)
        Me.ShutdownTabPage.Controls.Add(Me.PauseButtonSh)
        Me.ShutdownTabPage.Controls.Add(Me.StartButtonSh)
        Me.ShutdownTabPage.Controls.Add(Me.StopButtonSh)
        Me.ShutdownTabPage.Controls.Add(Me.ResumeButtonSh)
        Me.ShutdownTabPage.Controls.Add(Me.InSettingsGBSH)
        Me.ShutdownTabPage.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShutdownTabPage.Location = New System.Drawing.Point(4, 23)
        Me.ShutdownTabPage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ShutdownTabPage.Name = "ShutdownTabPage"
        Me.ShutdownTabPage.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ShutdownTabPage.Size = New System.Drawing.Size(718, 262)
        Me.ShutdownTabPage.TabIndex = 4
        Me.ShutdownTabPage.Text = "Shutdown"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Red
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.PictureBox4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel2.Location = New System.Drawing.Point(3, 2)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(712, 50)
        Me.Panel2.TabIndex = 103
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Yellow
        Me.Button2.Location = New System.Drawing.Point(579, 3)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 46)
        Me.Button2.TabIndex = 88
        Me.Button2.Text = "Click me to learn more"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(245, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(294, 42)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "This feature will be discontinued" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "on September 15, 2021. Please click on the but" &
    "ton for" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "more information."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(70, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 24)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Last Warning!"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(11, 3)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(40, 39)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'StatusGroupBoxSH
        '
        Me.StatusGroupBoxSH.Controls.Add(Me.MinuteAndLabelSh)
        Me.StatusGroupBoxSH.Controls.Add(Me.DateTimeTillShutdownLabelSh)
        Me.StatusGroupBoxSH.Controls.Add(Me.HoursAndLabelSh)
        Me.StatusGroupBoxSH.Controls.Add(Me.HourAndLabelSh)
        Me.StatusGroupBoxSH.Controls.Add(Me.SecondsLabelSh)
        Me.StatusGroupBoxSH.Controls.Add(Me.HourIndicatorLabelSh)
        Me.StatusGroupBoxSH.Controls.Add(Me.SecondLabelSh)
        Me.StatusGroupBoxSH.Controls.Add(Me.MinuteIndicatorLabelSh)
        Me.StatusGroupBoxSH.Controls.Add(Me.MinutesAndLabelSh)
        Me.StatusGroupBoxSH.Controls.Add(Me.SecondsIndicatorLabelSh)
        Me.StatusGroupBoxSH.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusGroupBoxSH.Location = New System.Drawing.Point(365, 64)
        Me.StatusGroupBoxSH.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StatusGroupBoxSH.Name = "StatusGroupBoxSH"
        Me.StatusGroupBoxSH.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StatusGroupBoxSH.Size = New System.Drawing.Size(246, 60)
        Me.StatusGroupBoxSH.TabIndex = 102
        Me.StatusGroupBoxSH.TabStop = False
        Me.StatusGroupBoxSH.Text = "Status"
        '
        'MinuteAndLabelSh
        '
        Me.MinuteAndLabelSh.AutoSize = True
        Me.MinuteAndLabelSh.BackColor = System.Drawing.Color.DarkRed
        Me.MinuteAndLabelSh.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinuteAndLabelSh.ForeColor = System.Drawing.Color.Red
        Me.MinuteAndLabelSh.Location = New System.Drawing.Point(58, 24)
        Me.MinuteAndLabelSh.Name = "MinuteAndLabelSh"
        Me.MinuteAndLabelSh.Size = New System.Drawing.Size(69, 14)
        Me.MinuteAndLabelSh.TabIndex = 97
        Me.MinuteAndLabelSh.Text = "minute and"
        Me.MinuteAndLabelSh.Visible = False
        '
        'DateTimeTillShutdownLabelSh
        '
        Me.DateTimeTillShutdownLabelSh.AutoSize = True
        Me.DateTimeTillShutdownLabelSh.BackColor = System.Drawing.Color.DarkRed
        Me.DateTimeTillShutdownLabelSh.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeTillShutdownLabelSh.ForeColor = System.Drawing.Color.Red
        Me.DateTimeTillShutdownLabelSh.Location = New System.Drawing.Point(169, 15)
        Me.DateTimeTillShutdownLabelSh.Name = "DateTimeTillShutdownLabelSh"
        Me.DateTimeTillShutdownLabelSh.Size = New System.Drawing.Size(49, 14)
        Me.DateTimeTillShutdownLabelSh.TabIndex = 101
        Me.DateTimeTillShutdownLabelSh.Text = "12:00:00"
        '
        'HoursAndLabelSh
        '
        Me.HoursAndLabelSh.AutoSize = True
        Me.HoursAndLabelSh.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HoursAndLabelSh.Location = New System.Drawing.Point(58, 15)
        Me.HoursAndLabelSh.Name = "HoursAndLabelSh"
        Me.HoursAndLabelSh.Size = New System.Drawing.Size(63, 14)
        Me.HoursAndLabelSh.TabIndex = 94
        Me.HoursAndLabelSh.Text = "hours and"
        '
        'HourAndLabelSh
        '
        Me.HourAndLabelSh.AutoSize = True
        Me.HourAndLabelSh.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HourAndLabelSh.Location = New System.Drawing.Point(58, 15)
        Me.HourAndLabelSh.Name = "HourAndLabelSh"
        Me.HourAndLabelSh.Size = New System.Drawing.Size(56, 14)
        Me.HourAndLabelSh.TabIndex = 95
        Me.HourAndLabelSh.Text = "hour and"
        Me.HourAndLabelSh.Visible = False
        '
        'SecondsLabelSh
        '
        Me.SecondsLabelSh.AutoSize = True
        Me.SecondsLabelSh.BackColor = System.Drawing.Color.DarkRed
        Me.SecondsLabelSh.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecondsLabelSh.ForeColor = System.Drawing.Color.Red
        Me.SecondsLabelSh.Location = New System.Drawing.Point(58, 35)
        Me.SecondsLabelSh.Name = "SecondsLabelSh"
        Me.SecondsLabelSh.Size = New System.Drawing.Size(55, 14)
        Me.SecondsLabelSh.TabIndex = 99
        Me.SecondsLabelSh.Text = "seconds"
        '
        'HourIndicatorLabelSh
        '
        Me.HourIndicatorLabelSh.AutoSize = True
        Me.HourIndicatorLabelSh.BackColor = System.Drawing.Color.DarkRed
        Me.HourIndicatorLabelSh.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HourIndicatorLabelSh.ForeColor = System.Drawing.Color.Red
        Me.HourIndicatorLabelSh.Location = New System.Drawing.Point(33, 15)
        Me.HourIndicatorLabelSh.Name = "HourIndicatorLabelSh"
        Me.HourIndicatorLabelSh.Size = New System.Drawing.Size(15, 14)
        Me.HourIndicatorLabelSh.TabIndex = 91
        Me.HourIndicatorLabelSh.Text = "--"
        '
        'SecondLabelSh
        '
        Me.SecondLabelSh.AutoSize = True
        Me.SecondLabelSh.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecondLabelSh.Location = New System.Drawing.Point(65, 35)
        Me.SecondLabelSh.Name = "SecondLabelSh"
        Me.SecondLabelSh.Size = New System.Drawing.Size(48, 14)
        Me.SecondLabelSh.TabIndex = 98
        Me.SecondLabelSh.Text = "second"
        '
        'MinuteIndicatorLabelSh
        '
        Me.MinuteIndicatorLabelSh.AutoSize = True
        Me.MinuteIndicatorLabelSh.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinuteIndicatorLabelSh.Location = New System.Drawing.Point(33, 24)
        Me.MinuteIndicatorLabelSh.Name = "MinuteIndicatorLabelSh"
        Me.MinuteIndicatorLabelSh.Size = New System.Drawing.Size(15, 14)
        Me.MinuteIndicatorLabelSh.TabIndex = 92
        Me.MinuteIndicatorLabelSh.Text = "--"
        '
        'MinutesAndLabelSh
        '
        Me.MinutesAndLabelSh.AutoSize = True
        Me.MinutesAndLabelSh.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinutesAndLabelSh.Location = New System.Drawing.Point(58, 24)
        Me.MinutesAndLabelSh.Name = "MinutesAndLabelSh"
        Me.MinutesAndLabelSh.Size = New System.Drawing.Size(76, 14)
        Me.MinutesAndLabelSh.TabIndex = 96
        Me.MinutesAndLabelSh.Text = "minutes and"
        '
        'SecondsIndicatorLabelSh
        '
        Me.SecondsIndicatorLabelSh.AutoSize = True
        Me.SecondsIndicatorLabelSh.BackColor = System.Drawing.Color.DarkRed
        Me.SecondsIndicatorLabelSh.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecondsIndicatorLabelSh.ForeColor = System.Drawing.Color.Red
        Me.SecondsIndicatorLabelSh.Location = New System.Drawing.Point(33, 35)
        Me.SecondsIndicatorLabelSh.Name = "SecondsIndicatorLabelSh"
        Me.SecondsIndicatorLabelSh.Size = New System.Drawing.Size(15, 14)
        Me.SecondsIndicatorLabelSh.TabIndex = 93
        Me.SecondsIndicatorLabelSh.Text = "--"
        '
        'PauseButtonSh
        '
        Me.PauseButtonSh.BackColor = System.Drawing.Color.Transparent
        Me.PauseButtonSh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PauseButtonSh.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PauseButtonSh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PauseButtonSh.ImageIndex = 3
        Me.PauseButtonSh.ImageList = Me.IconsIL
        Me.PauseButtonSh.Location = New System.Drawing.Point(329, 194)
        Me.PauseButtonSh.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PauseButtonSh.Name = "PauseButtonSh"
        Me.PauseButtonSh.Size = New System.Drawing.Size(98, 33)
        Me.PauseButtonSh.TabIndex = 88
        Me.PauseButtonSh.Text = "Pause"
        Me.PauseButtonSh.UseVisualStyleBackColor = False
        Me.PauseButtonSh.Visible = False
        '
        'StartButtonSh
        '
        Me.StartButtonSh.BackColor = System.Drawing.Color.Transparent
        Me.StartButtonSh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartButtonSh.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartButtonSh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.StartButtonSh.ImageKey = "play.ico"
        Me.StartButtonSh.ImageList = Me.IconsIL
        Me.StartButtonSh.Location = New System.Drawing.Point(329, 158)
        Me.StartButtonSh.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StartButtonSh.Name = "StartButtonSh"
        Me.StartButtonSh.Size = New System.Drawing.Size(98, 32)
        Me.StartButtonSh.TabIndex = 87
        Me.StartButtonSh.Text = "Start"
        Me.StartButtonSh.UseVisualStyleBackColor = False
        '
        'StopButtonSh
        '
        Me.StopButtonSh.BackColor = System.Drawing.Color.Transparent
        Me.StopButtonSh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StopButtonSh.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopButtonSh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.StopButtonSh.ImageKey = "stop.ico"
        Me.StopButtonSh.ImageList = Me.IconsIL
        Me.StopButtonSh.Location = New System.Drawing.Point(433, 158)
        Me.StopButtonSh.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StopButtonSh.Name = "StopButtonSh"
        Me.StopButtonSh.Size = New System.Drawing.Size(82, 32)
        Me.StopButtonSh.TabIndex = 90
        Me.StopButtonSh.Text = "Stop"
        Me.StopButtonSh.UseVisualStyleBackColor = False
        Me.StopButtonSh.Visible = False
        '
        'ResumeButtonSh
        '
        Me.ResumeButtonSh.BackColor = System.Drawing.Color.Transparent
        Me.ResumeButtonSh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResumeButtonSh.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResumeButtonSh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ResumeButtonSh.ImageKey = "play.ico"
        Me.ResumeButtonSh.ImageList = Me.IconsIL
        Me.ResumeButtonSh.Location = New System.Drawing.Point(433, 194)
        Me.ResumeButtonSh.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ResumeButtonSh.Name = "ResumeButtonSh"
        Me.ResumeButtonSh.Size = New System.Drawing.Size(82, 33)
        Me.ResumeButtonSh.TabIndex = 89
        Me.ResumeButtonSh.Text = "Resume"
        Me.ResumeButtonSh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ResumeButtonSh.UseVisualStyleBackColor = False
        Me.ResumeButtonSh.Visible = False
        '
        'InSettingsGBSH
        '
        Me.InSettingsGBSH.Controls.Add(Me.VisualRadioButtonSh)
        Me.InSettingsGBSH.Controls.Add(Me.HourNudSh)
        Me.InSettingsGBSH.Controls.Add(Me.AudioRadioButtonSh)
        Me.InSettingsGBSH.Controls.Add(Me.TimeLabelSh)
        Me.InSettingsGBSH.Controls.Add(Me.MinWarnLabelSh)
        Me.InSettingsGBSH.Controls.Add(Me.MinWarnNudSh)
        Me.InSettingsGBSH.Controls.Add(Me.MinuteNudSh)
        Me.InSettingsGBSH.Controls.Add(Me.SecondNudSh)
        Me.InSettingsGBSH.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InSettingsGBSH.Location = New System.Drawing.Point(51, 56)
        Me.InSettingsGBSH.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.InSettingsGBSH.Name = "InSettingsGBSH"
        Me.InSettingsGBSH.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.InSettingsGBSH.Size = New System.Drawing.Size(290, 68)
        Me.InSettingsGBSH.TabIndex = 85
        Me.InSettingsGBSH.TabStop = False
        Me.InSettingsGBSH.Text = "In Settings"
        '
        'VisualRadioButtonSh
        '
        Me.VisualRadioButtonSh.AutoSize = True
        Me.VisualRadioButtonSh.BackColor = System.Drawing.Color.DarkRed
        Me.VisualRadioButtonSh.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VisualRadioButtonSh.ForeColor = System.Drawing.Color.Red
        Me.VisualRadioButtonSh.Location = New System.Drawing.Point(209, 40)
        Me.VisualRadioButtonSh.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.VisualRadioButtonSh.Name = "VisualRadioButtonSh"
        Me.VisualRadioButtonSh.Size = New System.Drawing.Size(59, 18)
        Me.VisualRadioButtonSh.TabIndex = 62
        Me.VisualRadioButtonSh.TabStop = True
        Me.VisualRadioButtonSh.Text = "Visual"
        Me.VisualRadioButtonSh.UseVisualStyleBackColor = False
        '
        'HourNudSh
        '
        Me.HourNudSh.BackColor = System.Drawing.Color.DarkRed
        Me.HourNudSh.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HourNudSh.ForeColor = System.Drawing.Color.Red
        Me.HourNudSh.Location = New System.Drawing.Point(96, 15)
        Me.HourNudSh.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.HourNudSh.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.HourNudSh.Name = "HourNudSh"
        Me.HourNudSh.Size = New System.Drawing.Size(56, 21)
        Me.HourNudSh.TabIndex = 34
        '
        'AudioRadioButtonSh
        '
        Me.AudioRadioButtonSh.AutoSize = True
        Me.AudioRadioButtonSh.BackColor = System.Drawing.Color.DarkRed
        Me.AudioRadioButtonSh.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AudioRadioButtonSh.ForeColor = System.Drawing.Color.Red
        Me.AudioRadioButtonSh.Location = New System.Drawing.Point(147, 42)
        Me.AudioRadioButtonSh.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AudioRadioButtonSh.Name = "AudioRadioButtonSh"
        Me.AudioRadioButtonSh.Size = New System.Drawing.Size(57, 18)
        Me.AudioRadioButtonSh.TabIndex = 61
        Me.AudioRadioButtonSh.TabStop = True
        Me.AudioRadioButtonSh.Text = "Audio"
        Me.AudioRadioButtonSh.UseVisualStyleBackColor = False
        '
        'TimeLabelSh
        '
        Me.TimeLabelSh.AutoSize = True
        Me.TimeLabelSh.BackColor = System.Drawing.Color.DarkRed
        Me.TimeLabelSh.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLabelSh.ForeColor = System.Drawing.Color.Red
        Me.TimeLabelSh.Location = New System.Drawing.Point(32, 15)
        Me.TimeLabelSh.Name = "TimeLabelSh"
        Me.TimeLabelSh.Size = New System.Drawing.Size(38, 14)
        Me.TimeLabelSh.TabIndex = 29
        Me.TimeLabelSh.Text = "Time:"
        '
        'MinWarnLabelSh
        '
        Me.MinWarnLabelSh.AutoSize = True
        Me.MinWarnLabelSh.BackColor = System.Drawing.Color.DarkRed
        Me.MinWarnLabelSh.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinWarnLabelSh.ForeColor = System.Drawing.Color.Red
        Me.MinWarnLabelSh.Location = New System.Drawing.Point(8, 45)
        Me.MinWarnLabelSh.Name = "MinWarnLabelSh"
        Me.MinWarnLabelSh.Size = New System.Drawing.Size(58, 14)
        Me.MinWarnLabelSh.TabIndex = 43
        Me.MinWarnLabelSh.Text = "MinWarn:"
        '
        'MinWarnNudSh
        '
        Me.MinWarnNudSh.BackColor = System.Drawing.Color.DarkRed
        Me.MinWarnNudSh.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinWarnNudSh.ForeColor = System.Drawing.Color.Red
        Me.MinWarnNudSh.Location = New System.Drawing.Point(87, 43)
        Me.MinWarnNudSh.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinWarnNudSh.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.MinWarnNudSh.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MinWarnNudSh.Name = "MinWarnNudSh"
        Me.MinWarnNudSh.Size = New System.Drawing.Size(54, 21)
        Me.MinWarnNudSh.TabIndex = 60
        Me.MinWarnNudSh.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'MinuteNudSh
        '
        Me.MinuteNudSh.BackColor = System.Drawing.Color.DarkRed
        Me.MinuteNudSh.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinuteNudSh.ForeColor = System.Drawing.Color.Red
        Me.MinuteNudSh.Location = New System.Drawing.Point(160, 15)
        Me.MinuteNudSh.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinuteNudSh.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.MinuteNudSh.Name = "MinuteNudSh"
        Me.MinuteNudSh.Size = New System.Drawing.Size(55, 21)
        Me.MinuteNudSh.TabIndex = 35
        '
        'SecondNudSh
        '
        Me.SecondNudSh.BackColor = System.Drawing.Color.DarkRed
        Me.SecondNudSh.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecondNudSh.ForeColor = System.Drawing.Color.Red
        Me.SecondNudSh.Location = New System.Drawing.Point(223, 15)
        Me.SecondNudSh.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SecondNudSh.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.SecondNudSh.Name = "SecondNudSh"
        Me.SecondNudSh.Size = New System.Drawing.Size(54, 21)
        Me.SecondNudSh.TabIndex = 36
        '
        'TimerTimer
        '
        Me.TimerTimer.Interval = 1000
        '
        'tBeep
        '
        Me.tBeep.Interval = 1000
        '
        'DTPErhAc
        '
        Me.DTPErhAc.ContainerControl = Me
        '
        'TitlePanel
        '
        Me.TitlePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TitlePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TitlePanel.Controls.Add(Me.PictureBox1)
        Me.TitlePanel.Controls.Add(Me.TimeLabelYD)
        Me.TitlePanel.Controls.Add(Me.SettingsButton)
        Me.TitlePanel.Controls.Add(Me.DateLabelYD)
        Me.TitlePanel.Controls.Add(Me.lblwelcome)
        Me.TitlePanel.Controls.Add(Me.lblVersion)
        Me.TitlePanel.Controls.Add(Me.lblName)
        Me.TitlePanel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitlePanel.Location = New System.Drawing.Point(0, 0)
        Me.TitlePanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TitlePanel.Name = "TitlePanel"
        Me.TitlePanel.Size = New System.Drawing.Size(725, 72)
        Me.TitlePanel.TabIndex = 25
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, 7)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(73, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 85
        Me.PictureBox1.TabStop = False
        '
        'TimeLabelYD
        '
        Me.TimeLabelYD.AutoSize = True
        Me.TimeLabelYD.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLabelYD.Location = New System.Drawing.Point(274, 45)
        Me.TimeLabelYD.Name = "TimeLabelYD"
        Me.TimeLabelYD.Size = New System.Drawing.Size(141, 13)
        Me.TimeLabelYD.TabIndex = 84
        Me.TimeLabelYD.Text = "the time is 12:00:00 AM"
        '
        'SettingsButton
        '
        Me.SettingsButton.BackColor = System.Drawing.Color.Transparent
        Me.SettingsButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.SettingsButton.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingsButton.Location = New System.Drawing.Point(574, 0)
        Me.SettingsButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SettingsButton.Name = "SettingsButton"
        Me.SettingsButton.Size = New System.Drawing.Size(149, 70)
        Me.SettingsButton.TabIndex = 83
        Me.SettingsButton.Text = "Settings"
        Me.SettingsButton.UseVisualStyleBackColor = False
        '
        'DateLabelYD
        '
        Me.DateLabelYD.AutoSize = True
        Me.DateLabelYD.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLabelYD.Location = New System.Drawing.Point(274, 30)
        Me.DateLabelYD.Name = "DateLabelYD"
        Me.DateLabelYD.Size = New System.Drawing.Size(156, 13)
        Me.DateLabelYD.TabIndex = 28
        Me.DateLabelYD.Text = "the date is january 1, 2022"
        '
        'lblwelcome
        '
        Me.lblwelcome.AutoSize = True
        Me.lblwelcome.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwelcome.Location = New System.Drawing.Point(275, 7)
        Me.lblwelcome.Name = "lblwelcome"
        Me.lblwelcome.Size = New System.Drawing.Size(161, 24)
        Me.lblwelcome.TabIndex = 27
        Me.lblwelcome.Text = "welcome, user"
        Me.lblwelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(87, 30)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(172, 39)
        Me.lblVersion.TabIndex = 26
        Me.lblVersion.Text = "v21H2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Alpha Release" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Released September 14, 2021"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(103, 7)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(127, 24)
        Me.lblName.TabIndex = 25
        Me.lblName.Text = "BreakTime"
        '
        'AlarmTimer
        '
        Me.AlarmTimer.Interval = 1000
        '
        'ShutdownTimer
        '
        Me.ShutdownTimer.Interval = 1000
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
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 360)
        Me.Controls.Add(Me.TitlePanel)
        Me.Controls.Add(Me.TimerControl)
        Me.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BreakTime - v21H2A5- Released on September 14, 2021"
        Me.TimerControl.ResumeLayout(False)
        Me.BreakTimerTab.ResumeLayout(False)
        Me.BSTGroupBoxBT.ResumeLayout(False)
        Me.BSTGroupBoxBT.PerformLayout()
        Me.TSFGroupBoxBT.ResumeLayout(False)
        Me.TSFGroupBoxBT.PerformLayout()
        Me.ControlsGroupBoxBT.ResumeLayout(False)
        Me.TimerGBBt.ResumeLayout(False)
        Me.TimerGBBt.PerformLayout()
        CType(Me.nudTimeHour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinWarnNudBt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTimeMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTimeBreakSec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTimeSec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTimeBreakMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTimeBreakHour, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusGroupBoxBT.ResumeLayout(False)
        Me.StatusGroupBoxBT.PerformLayout()
        Me.BTime.ResumeLayout(False)
        Me.BreakGBBt.ResumeLayout(False)
        Me.BreakGBBt.PerformLayout()
        CType(Me.B1HourNudBT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudb1sec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudb1min, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TimerTab.ResumeLayout(False)
        Me.TSFGroupBoxT.ResumeLayout(False)
        Me.TSFGroupBoxT.PerformLayout()
        Me.StatusGroupBoxT.ResumeLayout(False)
        Me.StatusGroupBoxT.PerformLayout()
        CType(Me.nudSec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHour, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AlarmClockTab.ResumeLayout(False)
        Me.AlarmClockTab.PerformLayout()
        Me.panelalert.ResumeLayout(False)
        Me.panelalert.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HourNudAC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinNudAC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SecNudAC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StopWatchTab.ResumeLayout(False)
        Me.StopWatchTab.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ShutdownTabPage.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusGroupBoxSH.ResumeLayout(False)
        Me.StatusGroupBoxSH.PerformLayout()
        Me.InSettingsGBSH.ResumeLayout(False)
        Me.InSettingsGBSH.PerformLayout()
        CType(Me.HourNudSh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinWarnNudSh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinuteNudSh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SecondNudSh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTPErhAc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TitlePanel.ResumeLayout(False)
        Me.TitlePanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents BreakTimer As Timer
    Friend WithEvents TimerControl As TabControl
    Friend WithEvents BreakTimerTab As TabPage
    Friend WithEvents TimerGBBt As GroupBox
    Friend WithEvents nudTimeHour As NumericUpDown
    Friend WithEvents TimeLabelBt As Label
    Friend WithEvents BreakTimerALabelBT As Label
    Friend WithEvents nudTimeMin As NumericUpDown
    Friend WithEvents nudTimeBreakSec As NumericUpDown
    Friend WithEvents nudTimeSec As NumericUpDown
    Friend WithEvents nudTimeBreakMin As NumericUpDown
    Friend WithEvents nudTimeBreakHour As NumericUpDown
    Friend WithEvents TimerTab As TabPage
    Friend WithEvents AlarmClockTab As TabPage
    Friend WithEvents StopWatchTab As TabPage
    Friend WithEvents nudSec As NumericUpDown
    Friend WithEvents nudMin As NumericUpDown
    Friend WithEvents nudHour As NumericUpDown
    Public WithEvents btnStop As Button
    Public WithEvents btnResume As Button
    Public WithEvents PauseButtonBT As Button
    Public WithEvents StartButtonBT As Button
    Public WithEvents lblTimeRemaining As Label
    Friend WithEvents AlarmStatusLabel As Label
    Friend WithEvents CancelAlarmButton As Button
    Friend WithEvents SetAlarmButton As Button
    Friend WithEvents SetOrNotSetLabel As Label
    Public WithEvents StopTimeButton As Button
    Public WithEvents ResumeTimeButton As Button
    Public WithEvents PauseButtonT As Button
    Public WithEvents StartTimeButton As Button
    Friend WithEvents LapListBoxSw As ListBox
    Friend WithEvents LapButtonSW As Button
    Public WithEvents PauseButtonSW As Button
    Public WithEvents StopwatchLabelSW As Label
    Public WithEvents StartButtonSW As Button
    Friend WithEvents TimerTimer As Timer
    Friend WithEvents tBeep As Timer
    Friend WithEvents DTPErhAc As ErrorProvider
    Friend WithEvents TitlePanel As Panel
    Friend WithEvents lblVersion As Label
    Friend WithEvents lblName As Label
    Public WithEvents AlarmTimer As Timer
    Public WithEvents StopButtonSW As Button
    Public WithEvents ResumeButtonSW As Button
    Friend WithEvents VisualRbBt As RadioButton
    Friend WithEvents AudioRbBt As RadioButton
    Friend WithEvents MWLabelBt As Label
    Friend WithEvents MinWarnNudBt As NumericUpDown
    Friend WithEvents ShutdownTabPage As TabPage
    Friend WithEvents DateTimeTillShutdownLabelSh As Label
    Friend WithEvents SecondsLabelSh As Label
    Friend WithEvents SecondLabelSh As Label
    Friend WithEvents MinuteAndLabelSh As Label
    Friend WithEvents MinutesAndLabelSh As Label
    Friend WithEvents SecondsIndicatorLabelSh As Label
    Friend WithEvents MinuteIndicatorLabelSh As Label
    Friend WithEvents HourIndicatorLabelSh As Label
    Public WithEvents PauseButtonSh As Button
    Public WithEvents StartButtonSh As Button
    Public WithEvents StopButtonSh As Button
    Public WithEvents ResumeButtonSh As Button
    Friend WithEvents InSettingsGBSH As GroupBox
    Friend WithEvents VisualRadioButtonSh As RadioButton
    Friend WithEvents HourNudSh As NumericUpDown
    Friend WithEvents AudioRadioButtonSh As RadioButton
    Friend WithEvents TimeLabelSh As Label
    Friend WithEvents MinWarnLabelSh As Label
    Friend WithEvents MinWarnNudSh As NumericUpDown
    Friend WithEvents MinuteNudSh As NumericUpDown
    Friend WithEvents SecondNudSh As NumericUpDown
    Friend WithEvents HourAndLabelSh As Label
    Friend WithEvents HoursAndLabelSh As Label
    Friend WithEvents ShutdownTimer As Timer
    Friend WithEvents DateLabelYD As Label
    Friend WithEvents lblwelcome As Label
    Friend WithEvents YDTimer As Timer
    Public WithEvents SettingsButton As Button
    Friend WithEvents NotifyIconWDLCT As NotifyIcon
    Friend WithEvents TimeLabelYD As Label
    Friend WithEvents ControlsGroupBoxBT As GroupBox
    Friend WithEvents IconsIL As ImageList
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
    Friend WithEvents StatusGroupBoxSH As GroupBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimeBomb As Timer
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
    Friend WithEvents TimeSelectIndicatorLabelBT As Label
    Friend WithEvents TimeSelectLabelBT As Label
    Friend WithEvents BreakTimeIndicatorALabelBT As Label
    Friend WithEvents BreakTimeSelectALabelBT As Label
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents HourNudAC As NumericUpDown
    Friend WithEvents MinNudAC As NumericUpDown
    Friend WithEvents SecNudAC As NumericUpDown
    Friend WithEvents panelalert As Panel
    Friend WithEvents btnLM As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents BTime As TabPage
    Public WithEvents BreakNowButtonBt As Button
    Friend WithEvents BreakGBBt As GroupBox
    Friend WithEvents BreakTimeLabelBT As Label
    Friend WithEvents BreakTimeSelectLabelBT As Label
    Friend WithEvents BreakLabelBT As Label
    Friend WithEvents B1HourNudBT As NumericUpDown
    Friend WithEvents nudb1sec As NumericUpDown
    Friend WithEvents nudb1min As NumericUpDown
End Class