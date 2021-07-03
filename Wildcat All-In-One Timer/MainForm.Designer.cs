using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace UTimer
{
    [DesignerGenerated()]
    public partial class MainForm : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            _BreakTimer = new Timer(components);
            _BreakTimer.Tick += new EventHandler(BreakTimer_Tick);
            TimerControl = new TabControl();
            BreakTimerTab = new TabPage();
            BSTGroupBoxBT = new GroupBox();
            BSTSecondsLabelBT = new Label();
            BSTSecondLabelBT = new Label();
            BSTMinAndLabelBT = new Label();
            BSTMinsAndLabelBT = new Label();
            BSTSecondIndicatorLabelBT = new Label();
            BSTMinIndicatorLabelBT = new Label();
            BSTHourIndicatorLabelBT = new Label();
            BSTHourAndLabelBT = new Label();
            BSTHoursAndLabelBT = new Label();
            TSFGroupBoxBT = new GroupBox();
            TSFSecondsLabelBT = new Label();
            TSFSecondLabelBT = new Label();
            TSFMinAndLabelBT = new Label();
            TSFMinsAndLabelBT = new Label();
            TSFSecondIndicatorLabelBT = new Label();
            TSFMinIndicatorLabelBT = new Label();
            TSFHourIndicatorLabelBT = new Label();
            TSFHourAndLabelBT = new Label();
            TSFHoursAndLabelBT = new Label();
            ControlsGroupBoxBT = new GroupBox();
            _BreakNowButtonBt = new Button();
            _BreakNowButtonBt.Click += new EventHandler(BreakNowButtonBt_Click);
            IconsIL = new ImageList(components);
            _StartButtonBT = new Button();
            _StartButtonBT.Click += new EventHandler(Button1_Click_2);
            _btnResume = new Button();
            _btnResume.Click += new EventHandler(BtnResume_Click);
            _btnStop = new Button();
            _btnStop.Click += new EventHandler(Stopbutton_Click);
            _PauseButtonBT = new Button();
            _PauseButtonBT.Click += new EventHandler(Pausebutton_Click);
            TimerGBBt = new GroupBox();
            TimeSelectIndicatorLabelBT = new Label();
            TimeSelectLabelBT = new Label();
            BreakTimeIndicatorALabelBT = new Label();
            VisualRbBt = new RadioButton();
            BreakTimeSelectALabelBT = new Label();
            _nudTimeHour = new NumericUpDown();
            _nudTimeHour.ValueChanged += new EventHandler(NudTimeHour_ValueChanged);
            AudioRbBt = new RadioButton();
            TimeLabelBt = new Label();
            MWLabelBt = new Label();
            MinWarnNudBt = new NumericUpDown();
            BreakTimerALabelBT = new Label();
            _nudTimeMin = new NumericUpDown();
            _nudTimeMin.ValueChanged += new EventHandler(NudTimeMin_ValueChanged);
            _nudTimeBreakSec = new NumericUpDown();
            _nudTimeBreakSec.ValueChanged += new EventHandler(NudTimeBreakSec_ValueChanged);
            _nudTimeSec = new NumericUpDown();
            _nudTimeSec.ValueChanged += new EventHandler(NudTimeSec_ValueChanged);
            _nudTimeBreakMin = new NumericUpDown();
            _nudTimeBreakMin.ValueChanged += new EventHandler(NudTimeBreakMin_ValueChanged);
            _nudTimeBreakHour = new NumericUpDown();
            _nudTimeBreakHour.ValueChanged += new EventHandler(NudTimeBreakHour_ValueChanged);
            BreakGBBt = new GroupBox();
            BreakTimeLabelBT = new Label();
            BreakTimeSelectLabelBT = new Label();
            BreakLabelBT = new Label();
            _B1HourNudBT = new NumericUpDown();
            _B1HourNudBT.ValueChanged += new EventHandler(Nudb1hour_ValueChanged);
            _nudb1sec = new NumericUpDown();
            _nudb1sec.ValueChanged += new EventHandler(Nudb1sec_ValueChanged);
            _nudb1min = new NumericUpDown();
            _nudb1min.ValueChanged += new EventHandler(Nudb1min_ValueChanged);
            _TimeRBBt = new RadioButton();
            _TimeRBBt.CheckedChanged += new EventHandler(RbSet_CheckedChanged);
            _BreakRBBt = new RadioButton();
            _BreakRBBt.CheckedChanged += new EventHandler(RbBreak_CheckedChanged);
            StatusGroupBoxBT = new GroupBox();
            lblsecondsbreak = new Label();
            lblsecondbreak = new Label();
            lblminuteandbreak = new Label();
            lblminutesandbreak = new Label();
            lblsec = new Label();
            lblminute = new Label();
            HourLabelBT = new Label();
            HourAndBreakLabelBT = new Label();
            lblhoursandbreak = new Label();
            AlarmClockTab = new TabPage();
            HourNudAC = new NumericUpDown();
            MinNudAC = new NumericUpDown();
            SecNudAC = new NumericUpDown();
            AlarmStatusLabel = new Label();
            _CancelAlarmButton = new Button();
            _CancelAlarmButton.Click += new EventHandler(CancelAlarmButton_Click);
            _SetAlarmButton = new Button();
            _SetAlarmButton.Click += new EventHandler(StartAlarmButton_Click);
            SetOrNotSetLabel = new Label();
            TimerTab = new TabPage();
            TSFGroupBoxT = new GroupBox();
            lblsfsecondstime = new Label();
            TSFSecondLabelT = new Label();
            SFMinAndLabelT = new Label();
            TSFMinsAndLabelT = new Label();
            TSFSecondIndicatorLabelT = new Label();
            TSFMinIndicatorLabelT = new Label();
            TSFHourIndicatorLabelT = new Label();
            lblsfhoursandtime = new Label();
            TSFHoursAndLabelT = new Label();
            StatusGroupBoxT = new GroupBox();
            SecondsLabelT = new Label();
            lblsecondtime = new Label();
            lblminuteandtime = new Label();
            lblminutesandtime = new Label();
            lblsectime = new Label();
            lblmintime = new Label();
            lblhourtime = new Label();
            lblhourandtime = new Label();
            lblhoursandtime = new Label();
            _StartTimeButton = new Button();
            _StartTimeButton.Click += new EventHandler(BtnStart_Click);
            _StopTimeButton = new Button();
            _StopTimeButton.Click += new EventHandler(StopTimeButton_Click);
            _PauseButtonT = new Button();
            _PauseButtonT.Click += new EventHandler(PauseTimeButton_Click);
            nudSec = new NumericUpDown();
            nudMin = new NumericUpDown();
            nudHour = new NumericUpDown();
            _ResumeTimeButton = new Button();
            _ResumeTimeButton.Click += new EventHandler(Resumetimebutton_Click);
            StopWatchTab = new TabPage();
            LapListBoxSw = new ListBox();
            _LapButtonSW = new Button();
            _LapButtonSW.Click += new EventHandler(LapButton_Click);
            _PauseButtonSW = new Button();
            _PauseButtonSW.Click += new EventHandler(PauseButton_Click_1);
            StopwatchLabelSW = new Label();
            _StartButtonSW = new Button();
            _StartButtonSW.Click += new EventHandler(StartButton_Click);
            _StopButtonSW = new Button();
            _StopButtonSW.Click += new EventHandler(StopStopWButton_Click);
            _ResumeButtonSW = new Button();
            _ResumeButtonSW.Click += new EventHandler(ResumeStopWButton_Click);
            ShutdownTabPage = new TabPage();
            StatusGroupBoxSH = new GroupBox();
            MinuteAndLabelSh = new Label();
            DateTimeTillShutdownLabelSh = new Label();
            HoursAndLabelSh = new Label();
            HourAndLabelSh = new Label();
            SecondsLabelSh = new Label();
            HourIndicatorLabelSh = new Label();
            SecondLabelSh = new Label();
            MinuteIndicatorLabelSh = new Label();
            MinutesAndLabelSh = new Label();
            SecondsIndicatorLabelSh = new Label();
            _ShutdownCbSh = new ComboBox();
            _ShutdownCbSh.SelectedIndexChanged += new EventHandler(ShutdownCbSh_SelectedIndexChanged);
            _PauseButtonSh = new Button();
            _PauseButtonSh.Click += new EventHandler(PauseButtonSh_Click);
            _StartButtonSh = new Button();
            _StartButtonSh.Click += new EventHandler(StartButtonSh_Click);
            _StopButtonSh = new Button();
            _StopButtonSh.Click += new EventHandler(StopButtonSh_Click);
            _ResumeButtonSh = new Button();
            _ResumeButtonSh.Click += new EventHandler(ResumeButtonSh_Click);
            InSettingsGBSH = new GroupBox();
            VisualRadioButtonSh = new RadioButton();
            HourNudSh = new NumericUpDown();
            AudioRadioButtonSh = new RadioButton();
            TimeLabelSh = new Label();
            MinWarnLabelSh = new Label();
            MinWarnNudSh = new NumericUpDown();
            MinuteNudSh = new NumericUpDown();
            SecondNudSh = new NumericUpDown();
            AtSettingsGBSH = new GroupBox();
            HourAtNudSh = new NumericUpDown();
            MinuteAtNudSh = new NumericUpDown();
            TimeAtLabelSh = new Label();
            _AtRadioButtonSh = new RadioButton();
            _AtRadioButtonSh.CheckedChanged += new EventHandler(AtRadioButtonSh_CheckedChanged);
            _InRadioButtonSh = new RadioButton();
            _InRadioButtonSh.CheckedChanged += new EventHandler(InRadioButtonSh_CheckedChanged);
            _TimerTimer = new Timer(components);
            _TimerTimer.Tick += new EventHandler(TimerTimer_Tick);
            _tBeep = new Timer(components);
            _tBeep.Tick += new EventHandler(TBeep_Tick);
            DTPErhAc = new ErrorProvider(components);
            TitlePanel = new Panel();
            PictureBox1 = new PictureBox();
            TimeLabelYD = new Label();
            _SettingsButton = new Button();
            _SettingsButton.Click += new EventHandler(SettingsButton_Click);
            DateLabelYD = new Label();
            lblwelcome = new Label();
            lblVersion = new Label();
            lblName = new Label();
            _AlarmTimer = new Timer(components);
            _AlarmTimer.Tick += new EventHandler(AlarmTimer_Tick);
            _ShutdownTimer = new Timer(components);
            _ShutdownTimer.Tick += new EventHandler(ShutdownTimer_Tick);
            _YDTimer = new Timer(components);
            _YDTimer.Tick += new EventHandler(YDTimer_Tick);
            NotifyIconWDLCT = new NotifyIcon(components);
            ContextMenuStrip1 = new ContextMenuStrip(components);
            _OpenToolStripMenuItem = new ToolStripMenuItem();
            _OpenToolStripMenuItem.Click += new EventHandler(OpenToolStripMenuItem_Click);
            _ChangeSettingsToolStripMenuItem = new ToolStripMenuItem();
            _ChangeSettingsToolStripMenuItem.Click += new EventHandler(ChangeSettingsToolStripMenuItem_Click);
            _ExitToolStripMenuItem = new ToolStripMenuItem();
            _ExitToolStripMenuItem.Click += new EventHandler(ExitToolStripMenuItem_Click);
            TimeBomb = new Timer(components);
            TimerControl.SuspendLayout();
            BreakTimerTab.SuspendLayout();
            BSTGroupBoxBT.SuspendLayout();
            TSFGroupBoxBT.SuspendLayout();
            ControlsGroupBoxBT.SuspendLayout();
            TimerGBBt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_nudTimeHour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinWarnNudBt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_nudTimeMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_nudTimeBreakSec).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_nudTimeSec).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_nudTimeBreakMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_nudTimeBreakHour).BeginInit();
            BreakGBBt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_B1HourNudBT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_nudb1sec).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_nudb1min).BeginInit();
            StatusGroupBoxBT.SuspendLayout();
            AlarmClockTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HourNudAC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinNudAC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SecNudAC).BeginInit();
            TimerTab.SuspendLayout();
            TSFGroupBoxT.SuspendLayout();
            StatusGroupBoxT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSec).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHour).BeginInit();
            StopWatchTab.SuspendLayout();
            ShutdownTabPage.SuspendLayout();
            StatusGroupBoxSH.SuspendLayout();
            InSettingsGBSH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HourNudSh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinWarnNudSh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinuteNudSh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SecondNudSh).BeginInit();
            AtSettingsGBSH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HourAtNudSh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinuteAtNudSh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DTPErhAc).BeginInit();
            TitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            ContextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // BreakTimer
            // 
            _BreakTimer.Interval = 1000;
            // 
            // TimerControl
            // 
            TimerControl.Controls.Add(BreakTimerTab);
            TimerControl.Controls.Add(AlarmClockTab);
            TimerControl.Controls.Add(TimerTab);
            TimerControl.Controls.Add(StopWatchTab);
            TimerControl.Controls.Add(ShutdownTabPage);
            TimerControl.Dock = DockStyle.Bottom;
            TimerControl.ImageList = IconsIL;
            TimerControl.Location = new Point(0, 115);
            TimerControl.Multiline = true;
            TimerControl.Name = "TimerControl";
            TimerControl.SelectedIndex = 0;
            TimerControl.Size = new Size(544, 282);
            TimerControl.TabIndex = 24;
            // 
            // BreakTimerTab
            // 
            BreakTimerTab.Controls.Add(BSTGroupBoxBT);
            BreakTimerTab.Controls.Add(TSFGroupBoxBT);
            BreakTimerTab.Controls.Add(ControlsGroupBoxBT);
            BreakTimerTab.Controls.Add(TimerGBBt);
            BreakTimerTab.Controls.Add(BreakGBBt);
            BreakTimerTab.Controls.Add(_TimeRBBt);
            BreakTimerTab.Controls.Add(_BreakRBBt);
            BreakTimerTab.Controls.Add(StatusGroupBoxBT);
            BreakTimerTab.ImageKey = "1F512.png";
            BreakTimerTab.Location = new Point(4, 23);
            BreakTimerTab.Name = "BreakTimerTab";
            BreakTimerTab.Padding = new Padding(3);
            BreakTimerTab.Size = new Size(536, 255);
            BreakTimerTab.TabIndex = 0;
            BreakTimerTab.Text = "Break Timer";
            // 
            // BSTGroupBoxBT
            // 
            BSTGroupBoxBT.Controls.Add(BSTSecondsLabelBT);
            BSTGroupBoxBT.Controls.Add(BSTSecondLabelBT);
            BSTGroupBoxBT.Controls.Add(BSTMinAndLabelBT);
            BSTGroupBoxBT.Controls.Add(BSTMinsAndLabelBT);
            BSTGroupBoxBT.Controls.Add(BSTSecondIndicatorLabelBT);
            BSTGroupBoxBT.Controls.Add(BSTMinIndicatorLabelBT);
            BSTGroupBoxBT.Controls.Add(BSTHourIndicatorLabelBT);
            BSTGroupBoxBT.Controls.Add(BSTHourAndLabelBT);
            BSTGroupBoxBT.Controls.Add(BSTHoursAndLabelBT);
            BSTGroupBoxBT.ForeColor = Color.Black;
            BSTGroupBoxBT.Location = new Point(130, 166);
            BSTGroupBoxBT.Name = "BSTGroupBoxBT";
            BSTGroupBoxBT.Size = new Size(120, 62);
            BSTGroupBoxBT.TabIndex = 94;
            BSTGroupBoxBT.TabStop = false;
            BSTGroupBoxBT.Text = "Breaktime Set For";
            // 
            // BSTSecondsLabelBT
            // 
            BSTSecondsLabelBT.AutoSize = true;
            BSTSecondsLabelBT.Location = new Point(22, 43);
            BSTSecondsLabelBT.Name = "BSTSecondsLabelBT";
            BSTSecondsLabelBT.Size = new Size(46, 13);
            BSTSecondsLabelBT.TabIndex = 91;
            BSTSecondsLabelBT.Text = "seconds";
            // 
            // BSTSecondLabelBT
            // 
            BSTSecondLabelBT.AutoSize = true;
            BSTSecondLabelBT.Location = new Point(22, 43);
            BSTSecondLabelBT.Name = "BSTSecondLabelBT";
            BSTSecondLabelBT.Size = new Size(41, 13);
            BSTSecondLabelBT.TabIndex = 90;
            BSTSecondLabelBT.Text = "second";
            // 
            // BSTMinAndLabelBT
            // 
            BSTMinAndLabelBT.AutoSize = true;
            BSTMinAndLabelBT.Location = new Point(22, 30);
            BSTMinAndLabelBT.Name = "BSTMinAndLabelBT";
            BSTMinAndLabelBT.Size = new Size(60, 13);
            BSTMinAndLabelBT.TabIndex = 89;
            BSTMinAndLabelBT.Text = "minute and";
            BSTMinAndLabelBT.Visible = false;
            // 
            // BSTMinsAndLabelBT
            // 
            BSTMinsAndLabelBT.AutoSize = true;
            BSTMinsAndLabelBT.Location = new Point(22, 30);
            BSTMinsAndLabelBT.Name = "BSTMinsAndLabelBT";
            BSTMinsAndLabelBT.Size = new Size(65, 13);
            BSTMinsAndLabelBT.TabIndex = 88;
            BSTMinsAndLabelBT.Text = "minutes and";
            // 
            // BSTSecondIndicatorLabelBT
            // 
            BSTSecondIndicatorLabelBT.AutoSize = true;
            BSTSecondIndicatorLabelBT.Location = new Point(3, 43);
            BSTSecondIndicatorLabelBT.Name = "BSTSecondIndicatorLabelBT";
            BSTSecondIndicatorLabelBT.Size = new Size(15, 13);
            BSTSecondIndicatorLabelBT.TabIndex = 85;
            BSTSecondIndicatorLabelBT.Text = "--";
            // 
            // BSTMinIndicatorLabelBT
            // 
            BSTMinIndicatorLabelBT.AutoSize = true;
            BSTMinIndicatorLabelBT.Location = new Point(3, 31);
            BSTMinIndicatorLabelBT.Name = "BSTMinIndicatorLabelBT";
            BSTMinIndicatorLabelBT.Size = new Size(15, 13);
            BSTMinIndicatorLabelBT.TabIndex = 84;
            BSTMinIndicatorLabelBT.Text = "--";
            // 
            // BSTHourIndicatorLabelBT
            // 
            BSTHourIndicatorLabelBT.AutoSize = true;
            BSTHourIndicatorLabelBT.Location = new Point(3, 17);
            BSTHourIndicatorLabelBT.Name = "BSTHourIndicatorLabelBT";
            BSTHourIndicatorLabelBT.Size = new Size(15, 13);
            BSTHourIndicatorLabelBT.TabIndex = 83;
            BSTHourIndicatorLabelBT.Text = "--";
            // 
            // BSTHourAndLabelBT
            // 
            BSTHourAndLabelBT.AutoSize = true;
            BSTHourAndLabelBT.Location = new Point(22, 17);
            BSTHourAndLabelBT.Name = "BSTHourAndLabelBT";
            BSTHourAndLabelBT.Size = new Size(50, 13);
            BSTHourAndLabelBT.TabIndex = 87;
            BSTHourAndLabelBT.Text = "hour and";
            BSTHourAndLabelBT.Visible = false;
            // 
            // BSTHoursAndLabelBT
            // 
            BSTHoursAndLabelBT.AutoSize = true;
            BSTHoursAndLabelBT.Location = new Point(22, 17);
            BSTHoursAndLabelBT.Name = "BSTHoursAndLabelBT";
            BSTHoursAndLabelBT.Size = new Size(55, 13);
            BSTHoursAndLabelBT.TabIndex = 86;
            BSTHoursAndLabelBT.Text = "hours and";
            // 
            // TSFGroupBoxBT
            // 
            TSFGroupBoxBT.Controls.Add(TSFSecondsLabelBT);
            TSFGroupBoxBT.Controls.Add(TSFSecondLabelBT);
            TSFGroupBoxBT.Controls.Add(TSFMinAndLabelBT);
            TSFGroupBoxBT.Controls.Add(TSFMinsAndLabelBT);
            TSFGroupBoxBT.Controls.Add(TSFSecondIndicatorLabelBT);
            TSFGroupBoxBT.Controls.Add(TSFMinIndicatorLabelBT);
            TSFGroupBoxBT.Controls.Add(TSFHourIndicatorLabelBT);
            TSFGroupBoxBT.Controls.Add(TSFHourAndLabelBT);
            TSFGroupBoxBT.Controls.Add(TSFHoursAndLabelBT);
            TSFGroupBoxBT.ForeColor = Color.Black;
            TSFGroupBoxBT.Location = new Point(34, 166);
            TSFGroupBoxBT.Name = "TSFGroupBoxBT";
            TSFGroupBoxBT.Size = new Size(90, 61);
            TSFGroupBoxBT.TabIndex = 93;
            TSFGroupBoxBT.TabStop = false;
            TSFGroupBoxBT.Text = "Timer Set For";
            // 
            // TSFSecondsLabelBT
            // 
            TSFSecondsLabelBT.AutoSize = true;
            TSFSecondsLabelBT.Location = new Point(21, 42);
            TSFSecondsLabelBT.Name = "TSFSecondsLabelBT";
            TSFSecondsLabelBT.Size = new Size(46, 13);
            TSFSecondsLabelBT.TabIndex = 91;
            TSFSecondsLabelBT.Text = "seconds";
            // 
            // TSFSecondLabelBT
            // 
            TSFSecondLabelBT.AutoSize = true;
            TSFSecondLabelBT.Location = new Point(30, 42);
            TSFSecondLabelBT.Name = "TSFSecondLabelBT";
            TSFSecondLabelBT.Size = new Size(41, 13);
            TSFSecondLabelBT.TabIndex = 90;
            TSFSecondLabelBT.Text = "second";
            // 
            // TSFMinAndLabelBT
            // 
            TSFMinAndLabelBT.AutoSize = true;
            TSFMinAndLabelBT.Location = new Point(21, 29);
            TSFMinAndLabelBT.Name = "TSFMinAndLabelBT";
            TSFMinAndLabelBT.Size = new Size(60, 13);
            TSFMinAndLabelBT.TabIndex = 89;
            TSFMinAndLabelBT.Text = "minute and";
            TSFMinAndLabelBT.Visible = false;
            // 
            // TSFMinsAndLabelBT
            // 
            TSFMinsAndLabelBT.AutoSize = true;
            TSFMinsAndLabelBT.Location = new Point(21, 29);
            TSFMinsAndLabelBT.Name = "TSFMinsAndLabelBT";
            TSFMinsAndLabelBT.Size = new Size(65, 13);
            TSFMinsAndLabelBT.TabIndex = 88;
            TSFMinsAndLabelBT.Text = "minutes and";
            // 
            // TSFSecondIndicatorLabelBT
            // 
            TSFSecondIndicatorLabelBT.AutoSize = true;
            TSFSecondIndicatorLabelBT.Location = new Point(2, 42);
            TSFSecondIndicatorLabelBT.Name = "TSFSecondIndicatorLabelBT";
            TSFSecondIndicatorLabelBT.Size = new Size(15, 13);
            TSFSecondIndicatorLabelBT.TabIndex = 85;
            TSFSecondIndicatorLabelBT.Text = "--";
            // 
            // TSFMinIndicatorLabelBT
            // 
            TSFMinIndicatorLabelBT.AutoSize = true;
            TSFMinIndicatorLabelBT.Location = new Point(2, 30);
            TSFMinIndicatorLabelBT.Name = "TSFMinIndicatorLabelBT";
            TSFMinIndicatorLabelBT.Size = new Size(15, 13);
            TSFMinIndicatorLabelBT.TabIndex = 84;
            TSFMinIndicatorLabelBT.Text = "--";
            // 
            // TSFHourIndicatorLabelBT
            // 
            TSFHourIndicatorLabelBT.AutoSize = true;
            TSFHourIndicatorLabelBT.Location = new Point(1, 17);
            TSFHourIndicatorLabelBT.Name = "TSFHourIndicatorLabelBT";
            TSFHourIndicatorLabelBT.Size = new Size(15, 13);
            TSFHourIndicatorLabelBT.TabIndex = 83;
            TSFHourIndicatorLabelBT.Text = "--";
            // 
            // TSFHourAndLabelBT
            // 
            TSFHourAndLabelBT.AutoSize = true;
            TSFHourAndLabelBT.Location = new Point(20, 17);
            TSFHourAndLabelBT.Name = "TSFHourAndLabelBT";
            TSFHourAndLabelBT.Size = new Size(50, 13);
            TSFHourAndLabelBT.TabIndex = 87;
            TSFHourAndLabelBT.Text = "hour and";
            TSFHourAndLabelBT.Visible = false;
            // 
            // TSFHoursAndLabelBT
            // 
            TSFHoursAndLabelBT.AutoSize = true;
            TSFHoursAndLabelBT.Location = new Point(20, 17);
            TSFHoursAndLabelBT.Name = "TSFHoursAndLabelBT";
            TSFHoursAndLabelBT.Size = new Size(55, 13);
            TSFHoursAndLabelBT.TabIndex = 86;
            TSFHoursAndLabelBT.Text = "hours and";
            // 
            // ControlsGroupBoxBT
            // 
            ControlsGroupBoxBT.Controls.Add(_BreakNowButtonBt);
            ControlsGroupBoxBT.Controls.Add(_StartButtonBT);
            ControlsGroupBoxBT.Controls.Add(_btnResume);
            ControlsGroupBoxBT.Controls.Add(_btnStop);
            ControlsGroupBoxBT.Controls.Add(_PauseButtonBT);
            ControlsGroupBoxBT.ForeColor = Color.Black;
            ControlsGroupBoxBT.Location = new Point(32, 92);
            ControlsGroupBoxBT.Name = "ControlsGroupBoxBT";
            ControlsGroupBoxBT.Size = new Size(218, 68);
            ControlsGroupBoxBT.TabIndex = 53;
            ControlsGroupBoxBT.TabStop = false;
            ControlsGroupBoxBT.Text = "Controls";
            // 
            // BreakNowButtonBt
            // 
            _BreakNowButtonBt.BackColor = Color.Transparent;
            _BreakNowButtonBt.FlatStyle = FlatStyle.Flat;
            _BreakNowButtonBt.ImageAlign = ContentAlignment.MiddleLeft;
            _BreakNowButtonBt.ImageKey = "1F512.png";
            _BreakNowButtonBt.ImageList = IconsIL;
            _BreakNowButtonBt.Location = new Point(77, 16);
            _BreakNowButtonBt.Name = "_BreakNowButtonBt";
            _BreakNowButtonBt.Size = new Size(84, 23);
            _BreakNowButtonBt.TabIndex = 83;
            _BreakNowButtonBt.Text = "BreakNow";
            _BreakNowButtonBt.TextImageRelation = TextImageRelation.ImageBeforeText;
            _BreakNowButtonBt.UseVisualStyleBackColor = false;
            _BreakNowButtonBt.Visible = false;
            // 
            // IconsIL
            // 
            IconsIL.ImageStream = (ImageListStreamer)resources.GetObject("IconsIL.ImageStream");
            IconsIL.TransparentColor = Color.Transparent;
            IconsIL.Images.SetKeyName(0, "1F512.png");
            IconsIL.Images.SetKeyName(1, "1F552.png");
            IconsIL.Images.SetKeyName(2, "23F0.png");
            IconsIL.Images.SetKeyName(3, "1F50C.png");
            IconsIL.Images.SetKeyName(4, "sw.png");
            IconsIL.Images.SetKeyName(5, "23F9.png");
            IconsIL.Images.SetKeyName(6, "23F8.png");
            IconsIL.Images.SetKeyName(7, "25B6.png");
            IconsIL.Images.SetKeyName(8, "favicon.ico");
            // 
            // StartButtonBT
            // 
            _StartButtonBT.BackColor = Color.Transparent;
            _StartButtonBT.FlatStyle = FlatStyle.Flat;
            _StartButtonBT.ImageAlign = ContentAlignment.MiddleLeft;
            _StartButtonBT.ImageKey = "25B6.png";
            _StartButtonBT.ImageList = IconsIL;
            _StartButtonBT.Location = new Point(6, 16);
            _StartButtonBT.Name = "_StartButtonBT";
            _StartButtonBT.Size = new Size(71, 23);
            _StartButtonBT.TabIndex = 55;
            _StartButtonBT.Text = "Start";
            _StartButtonBT.UseVisualStyleBackColor = false;
            // 
            // btnResume
            // 
            _btnResume.BackColor = Color.Transparent;
            _btnResume.FlatStyle = FlatStyle.Flat;
            _btnResume.ImageAlign = ContentAlignment.MiddleLeft;
            _btnResume.ImageIndex = 7;
            _btnResume.ImageList = IconsIL;
            _btnResume.Location = new Point(77, 39);
            _btnResume.Name = "_btnResume";
            _btnResume.Size = new Size(63, 23);
            _btnResume.TabIndex = 57;
            _btnResume.Text = "Resume";
            _btnResume.UseVisualStyleBackColor = false;
            _btnResume.Visible = false;
            // 
            // btnStop
            // 
            _btnStop.BackColor = Color.Transparent;
            _btnStop.FlatStyle = FlatStyle.Flat;
            _btnStop.ImageAlign = ContentAlignment.MiddleLeft;
            _btnStop.ImageIndex = 5;
            _btnStop.ImageList = IconsIL;
            _btnStop.Location = new Point(6, 39);
            _btnStop.Name = "_btnStop";
            _btnStop.Size = new Size(71, 23);
            _btnStop.TabIndex = 58;
            _btnStop.Text = "Stop";
            _btnStop.UseVisualStyleBackColor = false;
            _btnStop.Visible = false;
            // 
            // PauseButtonBT
            // 
            _PauseButtonBT.BackColor = Color.Transparent;
            _PauseButtonBT.FlatStyle = FlatStyle.Flat;
            _PauseButtonBT.ImageAlign = ContentAlignment.MiddleLeft;
            _PauseButtonBT.ImageIndex = 6;
            _PauseButtonBT.ImageList = IconsIL;
            _PauseButtonBT.Location = new Point(140, 39);
            _PauseButtonBT.Name = "_PauseButtonBT";
            _PauseButtonBT.Size = new Size(71, 23);
            _PauseButtonBT.TabIndex = 56;
            _PauseButtonBT.Text = "Pause";
            _PauseButtonBT.UseVisualStyleBackColor = false;
            _PauseButtonBT.Visible = false;
            // 
            // TimerGBBt
            // 
            TimerGBBt.Controls.Add(TimeSelectIndicatorLabelBT);
            TimerGBBt.Controls.Add(TimeSelectLabelBT);
            TimerGBBt.Controls.Add(BreakTimeIndicatorALabelBT);
            TimerGBBt.Controls.Add(VisualRbBt);
            TimerGBBt.Controls.Add(BreakTimeSelectALabelBT);
            TimerGBBt.Controls.Add(_nudTimeHour);
            TimerGBBt.Controls.Add(AudioRbBt);
            TimerGBBt.Controls.Add(TimeLabelBt);
            TimerGBBt.Controls.Add(MWLabelBt);
            TimerGBBt.Controls.Add(MinWarnNudBt);
            TimerGBBt.Controls.Add(BreakTimerALabelBT);
            TimerGBBt.Controls.Add(_nudTimeMin);
            TimerGBBt.Controls.Add(_nudTimeBreakSec);
            TimerGBBt.Controls.Add(_nudTimeSec);
            TimerGBBt.Controls.Add(_nudTimeBreakMin);
            TimerGBBt.Controls.Add(_nudTimeBreakHour);
            TimerGBBt.ForeColor = Color.Black;
            TimerGBBt.Location = new Point(256, 16);
            TimerGBBt.Name = "TimerGBBt";
            TimerGBBt.Size = new Size(223, 144);
            TimerGBBt.TabIndex = 49;
            TimerGBBt.TabStop = false;
            TimerGBBt.Text = "Timer Settings";
            // 
            // TimeSelectIndicatorLabelBT
            // 
            TimeSelectIndicatorLabelBT.AutoSize = true;
            TimeSelectIndicatorLabelBT.ForeColor = Color.Black;
            TimeSelectIndicatorLabelBT.Location = new Point(111, 110);
            TimeSelectIndicatorLabelBT.Name = "TimeSelectIndicatorLabelBT";
            TimeSelectIndicatorLabelBT.Size = new Size(51, 13);
            TimeSelectIndicatorLabelBT.TabIndex = 64;
            TimeSelectIndicatorLabelBT.Text = "00:00:00";
            // 
            // TimeSelectLabelBT
            // 
            TimeSelectLabelBT.AutoSize = true;
            TimeSelectLabelBT.ForeColor = Color.Black;
            TimeSelectLabelBT.Location = new Point(69, 110);
            TimeSelectLabelBT.Name = "TimeSelectLabelBT";
            TimeSelectLabelBT.Size = new Size(33, 13);
            TimeSelectLabelBT.TabIndex = 63;
            TimeSelectLabelBT.Text = "Time:";
            // 
            // BreakTimeIndicatorALabelBT
            // 
            BreakTimeIndicatorALabelBT.AutoSize = true;
            BreakTimeIndicatorALabelBT.ForeColor = Color.Black;
            BreakTimeIndicatorALabelBT.Location = new Point(111, 124);
            BreakTimeIndicatorALabelBT.Name = "BreakTimeIndicatorALabelBT";
            BreakTimeIndicatorALabelBT.Size = new Size(51, 13);
            BreakTimeIndicatorALabelBT.TabIndex = 46;
            BreakTimeIndicatorALabelBT.Text = "00:00:00";
            // 
            // VisualRbBt
            // 
            VisualRbBt.AutoSize = true;
            VisualRbBt.ForeColor = Color.Black;
            VisualRbBt.Location = new Point(118, 86);
            VisualRbBt.Name = "VisualRbBt";
            VisualRbBt.Size = new Size(52, 17);
            VisualRbBt.TabIndex = 62;
            VisualRbBt.TabStop = true;
            VisualRbBt.Text = "Visual";
            VisualRbBt.UseVisualStyleBackColor = true;
            // 
            // BreakTimeSelectALabelBT
            // 
            BreakTimeSelectALabelBT.AutoSize = true;
            BreakTimeSelectALabelBT.ForeColor = Color.Black;
            BreakTimeSelectALabelBT.Location = new Point(37, 124);
            BreakTimeSelectALabelBT.Name = "BreakTimeSelectALabelBT";
            BreakTimeSelectALabelBT.Size = new Size(63, 13);
            BreakTimeSelectALabelBT.TabIndex = 45;
            BreakTimeSelectALabelBT.Text = "Break Time:";
            // 
            // nudTimeHour
            // 
            _nudTimeHour.ForeColor = SystemColors.ControlText;
            _nudTimeHour.Location = new Point(72, 19);
            _nudTimeHour.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            _nudTimeHour.Name = "_nudTimeHour";
            _nudTimeHour.Size = new Size(42, 21);
            _nudTimeHour.TabIndex = 34;
            // 
            // AudioRbBt
            // 
            AudioRbBt.AutoSize = true;
            AudioRbBt.Location = new Point(118, 71);
            AudioRbBt.Name = "AudioRbBt";
            AudioRbBt.Size = new Size(52, 17);
            AudioRbBt.TabIndex = 61;
            AudioRbBt.TabStop = true;
            AudioRbBt.Text = "Audio";
            AudioRbBt.UseVisualStyleBackColor = true;
            // 
            // TimeLabelBt
            // 
            TimeLabelBt.AutoSize = true;
            TimeLabelBt.Location = new Point(24, 19);
            TimeLabelBt.Name = "TimeLabelBt";
            TimeLabelBt.Size = new Size(33, 13);
            TimeLabelBt.TabIndex = 29;
            TimeLabelBt.Text = "Time:";
            // 
            // MWLabelBt
            // 
            MWLabelBt.AutoSize = true;
            MWLabelBt.Location = new Point(6, 76);
            MWLabelBt.Name = "MWLabelBt";
            MWLabelBt.Size = new Size(53, 13);
            MWLabelBt.TabIndex = 43;
            MWLabelBt.Text = "MinWarn:";
            // 
            // MinWarnNudBt
            // 
            MinWarnNudBt.Location = new Point(72, 76);
            MinWarnNudBt.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            MinWarnNudBt.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            MinWarnNudBt.Name = "MinWarnNudBt";
            MinWarnNudBt.Size = new Size(40, 21);
            MinWarnNudBt.TabIndex = 60;
            MinWarnNudBt.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // BreakTimerALabelBT
            // 
            BreakTimerALabelBT.AutoSize = true;
            BreakTimerALabelBT.Location = new Point(19, 50);
            BreakTimerALabelBT.Name = "BreakTimerALabelBT";
            BreakTimerALabelBT.Size = new Size(38, 13);
            BreakTimerALabelBT.TabIndex = 31;
            BreakTimerALabelBT.Text = "Break:";
            // 
            // nudTimeMin
            // 
            _nudTimeMin.ForeColor = SystemColors.ControlText;
            _nudTimeMin.Location = new Point(120, 19);
            _nudTimeMin.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            _nudTimeMin.Name = "_nudTimeMin";
            _nudTimeMin.Size = new Size(41, 21);
            _nudTimeMin.TabIndex = 35;
            // 
            // nudTimeBreakSec
            // 
            _nudTimeBreakSec.ForeColor = SystemColors.ControlText;
            _nudTimeBreakSec.Location = new Point(167, 48);
            _nudTimeBreakSec.Name = "_nudTimeBreakSec";
            _nudTimeBreakSec.Size = new Size(40, 21);
            _nudTimeBreakSec.TabIndex = 39;
            // 
            // nudTimeSec
            // 
            _nudTimeSec.ForeColor = SystemColors.ControlText;
            _nudTimeSec.Location = new Point(167, 19);
            _nudTimeSec.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            _nudTimeSec.Name = "_nudTimeSec";
            _nudTimeSec.Size = new Size(40, 21);
            _nudTimeSec.TabIndex = 36;
            // 
            // nudTimeBreakMin
            // 
            _nudTimeBreakMin.ForeColor = SystemColors.ControlText;
            _nudTimeBreakMin.Location = new Point(120, 48);
            _nudTimeBreakMin.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            _nudTimeBreakMin.Name = "_nudTimeBreakMin";
            _nudTimeBreakMin.Size = new Size(41, 21);
            _nudTimeBreakMin.TabIndex = 38;
            // 
            // nudTimeBreakHour
            // 
            _nudTimeBreakHour.ForeColor = SystemColors.ControlText;
            _nudTimeBreakHour.Location = new Point(72, 48);
            _nudTimeBreakHour.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            _nudTimeBreakHour.Name = "_nudTimeBreakHour";
            _nudTimeBreakHour.Size = new Size(42, 21);
            _nudTimeBreakHour.TabIndex = 37;
            // 
            // BreakGBBt
            // 
            BreakGBBt.Controls.Add(BreakTimeLabelBT);
            BreakGBBt.Controls.Add(BreakTimeSelectLabelBT);
            BreakGBBt.Controls.Add(BreakLabelBT);
            BreakGBBt.Controls.Add(_B1HourNudBT);
            BreakGBBt.Controls.Add(_nudb1sec);
            BreakGBBt.Controls.Add(_nudb1min);
            BreakGBBt.Location = new Point(34, 25);
            BreakGBBt.Name = "BreakGBBt";
            BreakGBBt.Size = new Size(218, 66);
            BreakGBBt.TabIndex = 52;
            BreakGBBt.TabStop = false;
            BreakGBBt.Text = "Break Settings";
            // 
            // BreakTimeLabelBT
            // 
            BreakTimeLabelBT.AutoSize = true;
            BreakTimeLabelBT.Location = new Point(79, 45);
            BreakTimeLabelBT.Name = "BreakTimeLabelBT";
            BreakTimeLabelBT.Size = new Size(51, 13);
            BreakTimeLabelBT.TabIndex = 44;
            BreakTimeLabelBT.Text = "00:00:00";
            // 
            // BreakTimeSelectLabelBT
            // 
            BreakTimeSelectLabelBT.AutoSize = true;
            BreakTimeSelectLabelBT.Location = new Point(11, 45);
            BreakTimeSelectLabelBT.Name = "BreakTimeSelectLabelBT";
            BreakTimeSelectLabelBT.Size = new Size(63, 13);
            BreakTimeSelectLabelBT.TabIndex = 43;
            BreakTimeSelectLabelBT.Text = "Break Time:";
            // 
            // BreakLabelBT
            // 
            BreakLabelBT.AutoSize = true;
            BreakLabelBT.Location = new Point(11, 16);
            BreakLabelBT.Name = "BreakLabelBT";
            BreakLabelBT.Size = new Size(38, 13);
            BreakLabelBT.TabIndex = 33;
            BreakLabelBT.Text = "Break:";
            // 
            // B1HourNudBT
            // 
            _B1HourNudBT.Location = new Point(61, 14);
            _B1HourNudBT.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            _B1HourNudBT.Name = "_B1HourNudBT";
            _B1HourNudBT.Size = new Size(37, 21);
            _B1HourNudBT.TabIndex = 40;
            // 
            // nudb1sec
            // 
            _nudb1sec.ForeColor = Color.Black;
            _nudb1sec.Location = new Point(149, 14);
            _nudb1sec.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            _nudb1sec.Name = "_nudb1sec";
            _nudb1sec.Size = new Size(42, 21);
            _nudb1sec.TabIndex = 42;
            // 
            // nudb1min
            // 
            _nudb1min.Location = new Point(104, 14);
            _nudb1min.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            _nudb1min.Name = "_nudb1min";
            _nudb1min.Size = new Size(39, 21);
            _nudb1min.TabIndex = 41;
            // 
            // TimeRBBt
            // 
            _TimeRBBt.AutoSize = true;
            _TimeRBBt.FlatAppearance.BorderSize = 0;
            _TimeRBBt.FlatStyle = FlatStyle.Flat;
            _TimeRBBt.ForeColor = Color.Black;
            _TimeRBBt.ImageAlign = ContentAlignment.TopLeft;
            _TimeRBBt.ImageIndex = 1;
            _TimeRBBt.ImageList = IconsIL;
            _TimeRBBt.Location = new Point(39, 6);
            _TimeRBBt.Name = "_TimeRBBt";
            _TimeRBBt.Size = new Size(81, 17);
            _TimeRBBt.TabIndex = 45;
            _TimeRBBt.Text = "Set Time";
            _TimeRBBt.TextAlign = ContentAlignment.MiddleRight;
            _TimeRBBt.TextImageRelation = TextImageRelation.ImageBeforeText;
            _TimeRBBt.UseVisualStyleBackColor = false;
            // 
            // BreakRBBt
            // 
            _BreakRBBt.AutoSize = true;
            _BreakRBBt.FlatStyle = FlatStyle.Flat;
            _BreakRBBt.ForeColor = Color.Black;
            _BreakRBBt.ImageAlign = ContentAlignment.MiddleLeft;
            _BreakRBBt.ImageIndex = 0;
            _BreakRBBt.ImageList = IconsIL;
            _BreakRBBt.Location = new Point(131, 6);
            _BreakRBBt.Name = "_BreakRBBt";
            _BreakRBBt.Size = new Size(86, 17);
            _BreakRBBt.TabIndex = 48;
            _BreakRBBt.Text = "Set Break";
            _BreakRBBt.TextImageRelation = TextImageRelation.ImageBeforeText;
            _BreakRBBt.UseVisualStyleBackColor = false;
            // 
            // StatusGroupBoxBT
            // 
            StatusGroupBoxBT.Controls.Add(lblsecondsbreak);
            StatusGroupBoxBT.Controls.Add(lblsecondbreak);
            StatusGroupBoxBT.Controls.Add(lblminuteandbreak);
            StatusGroupBoxBT.Controls.Add(lblminutesandbreak);
            StatusGroupBoxBT.Controls.Add(lblsec);
            StatusGroupBoxBT.Controls.Add(lblminute);
            StatusGroupBoxBT.Controls.Add(HourLabelBT);
            StatusGroupBoxBT.Controls.Add(HourAndBreakLabelBT);
            StatusGroupBoxBT.Controls.Add(lblhoursandbreak);
            StatusGroupBoxBT.ForeColor = Color.Black;
            StatusGroupBoxBT.Location = new Point(258, 166);
            StatusGroupBoxBT.Name = "StatusGroupBoxBT";
            StatusGroupBoxBT.Size = new Size(112, 62);
            StatusGroupBoxBT.TabIndex = 84;
            StatusGroupBoxBT.TabStop = false;
            StatusGroupBoxBT.Text = "Status";
            // 
            // lblsecondsbreak
            // 
            lblsecondsbreak.AutoSize = true;
            lblsecondsbreak.Location = new Point(31, 43);
            lblsecondsbreak.Name = "lblsecondsbreak";
            lblsecondsbreak.Size = new Size(46, 13);
            lblsecondsbreak.TabIndex = 91;
            lblsecondsbreak.Text = "seconds";
            // 
            // lblsecondbreak
            // 
            lblsecondbreak.AutoSize = true;
            lblsecondbreak.Location = new Point(40, 43);
            lblsecondbreak.Name = "lblsecondbreak";
            lblsecondbreak.Size = new Size(41, 13);
            lblsecondbreak.TabIndex = 90;
            lblsecondbreak.Text = "second";
            // 
            // lblminuteandbreak
            // 
            lblminuteandbreak.AutoSize = true;
            lblminuteandbreak.Location = new Point(31, 29);
            lblminuteandbreak.Name = "lblminuteandbreak";
            lblminuteandbreak.Size = new Size(60, 13);
            lblminuteandbreak.TabIndex = 89;
            lblminuteandbreak.Text = "minute and";
            lblminuteandbreak.Visible = false;
            // 
            // lblminutesandbreak
            // 
            lblminutesandbreak.AutoSize = true;
            lblminutesandbreak.Location = new Point(31, 29);
            lblminutesandbreak.Name = "lblminutesandbreak";
            lblminutesandbreak.Size = new Size(65, 13);
            lblminutesandbreak.TabIndex = 88;
            lblminutesandbreak.Text = "minutes and";
            // 
            // lblsec
            // 
            lblsec.AutoSize = true;
            lblsec.Location = new Point(12, 43);
            lblsec.Name = "lblsec";
            lblsec.Size = new Size(15, 13);
            lblsec.TabIndex = 85;
            lblsec.Text = "--";
            // 
            // lblminute
            // 
            lblminute.AutoSize = true;
            lblminute.Location = new Point(12, 30);
            lblminute.Name = "lblminute";
            lblminute.Size = new Size(15, 13);
            lblminute.TabIndex = 84;
            lblminute.Text = "--";
            // 
            // HourLabelBT
            // 
            HourLabelBT.AutoSize = true;
            HourLabelBT.Location = new Point(12, 16);
            HourLabelBT.Name = "HourLabelBT";
            HourLabelBT.Size = new Size(15, 13);
            HourLabelBT.TabIndex = 83;
            HourLabelBT.Text = "--";
            // 
            // HourAndBreakLabelBT
            // 
            HourAndBreakLabelBT.AutoSize = true;
            HourAndBreakLabelBT.Location = new Point(31, 16);
            HourAndBreakLabelBT.Name = "HourAndBreakLabelBT";
            HourAndBreakLabelBT.Size = new Size(50, 13);
            HourAndBreakLabelBT.TabIndex = 87;
            HourAndBreakLabelBT.Text = "hour and";
            HourAndBreakLabelBT.Visible = false;
            // 
            // lblhoursandbreak
            // 
            lblhoursandbreak.AutoSize = true;
            lblhoursandbreak.Location = new Point(31, 16);
            lblhoursandbreak.Name = "lblhoursandbreak";
            lblhoursandbreak.Size = new Size(55, 13);
            lblhoursandbreak.TabIndex = 86;
            lblhoursandbreak.Text = "hours and";
            // 
            // AlarmClockTab
            // 
            AlarmClockTab.Controls.Add(HourNudAC);
            AlarmClockTab.Controls.Add(MinNudAC);
            AlarmClockTab.Controls.Add(SecNudAC);
            AlarmClockTab.Controls.Add(AlarmStatusLabel);
            AlarmClockTab.Controls.Add(_CancelAlarmButton);
            AlarmClockTab.Controls.Add(_SetAlarmButton);
            AlarmClockTab.Controls.Add(SetOrNotSetLabel);
            AlarmClockTab.ImageIndex = 2;
            AlarmClockTab.Location = new Point(4, 23);
            AlarmClockTab.Name = "AlarmClockTab";
            AlarmClockTab.Size = new Size(536, 255);
            AlarmClockTab.TabIndex = 2;
            AlarmClockTab.Text = "Alarm Clock";
            // 
            // HourNudAC
            // 
            HourNudAC.ForeColor = SystemColors.ControlText;
            HourNudAC.Location = new Point(180, 38);
            HourNudAC.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            HourNudAC.Name = "HourNudAC";
            HourNudAC.Size = new Size(42, 21);
            HourNudAC.TabIndex = 37;
            // 
            // MinNudAC
            // 
            MinNudAC.ForeColor = SystemColors.ControlText;
            MinNudAC.Location = new Point(228, 38);
            MinNudAC.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            MinNudAC.Name = "MinNudAC";
            MinNudAC.Size = new Size(41, 21);
            MinNudAC.TabIndex = 38;
            // 
            // SecNudAC
            // 
            SecNudAC.ForeColor = SystemColors.ControlText;
            SecNudAC.Location = new Point(275, 38);
            SecNudAC.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            SecNudAC.Name = "SecNudAC";
            SecNudAC.Size = new Size(40, 21);
            SecNudAC.TabIndex = 39;
            // 
            // AlarmStatusLabel
            // 
            AlarmStatusLabel.AutoSize = true;
            AlarmStatusLabel.FlatStyle = FlatStyle.System;
            AlarmStatusLabel.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            AlarmStatusLabel.Location = new Point(110, 91);
            AlarmStatusLabel.Name = "AlarmStatusLabel";
            AlarmStatusLabel.Size = new Size(140, 23);
            AlarmStatusLabel.TabIndex = 15;
            AlarmStatusLabel.Text = "Alarm Status:";
            // 
            // CancelAlarmButton
            // 
            _CancelAlarmButton.BackColor = Color.Transparent;
            _CancelAlarmButton.FlatStyle = FlatStyle.Flat;
            _CancelAlarmButton.Location = new Point(251, 65);
            _CancelAlarmButton.Name = "_CancelAlarmButton";
            _CancelAlarmButton.Size = new Size(75, 23);
            _CancelAlarmButton.TabIndex = 12;
            _CancelAlarmButton.Text = "Cancel";
            _CancelAlarmButton.UseVisualStyleBackColor = false;
            _CancelAlarmButton.Visible = false;
            // 
            // SetAlarmButton
            // 
            _SetAlarmButton.BackColor = Color.Transparent;
            _SetAlarmButton.FlatStyle = FlatStyle.Flat;
            _SetAlarmButton.Location = new Point(170, 65);
            _SetAlarmButton.Name = "_SetAlarmButton";
            _SetAlarmButton.Size = new Size(75, 23);
            _SetAlarmButton.TabIndex = 11;
            _SetAlarmButton.Text = "Set";
            _SetAlarmButton.UseVisualStyleBackColor = false;
            // 
            // SetOrNotSetLabel
            // 
            SetOrNotSetLabel.AutoSize = true;
            SetOrNotSetLabel.FlatStyle = FlatStyle.System;
            SetOrNotSetLabel.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            SetOrNotSetLabel.Location = new Point(251, 91);
            SetOrNotSetLabel.Name = "SetOrNotSetLabel";
            SetOrNotSetLabel.Size = new Size(82, 23);
            SetOrNotSetLabel.TabIndex = 10;
            SetOrNotSetLabel.Text = "Not Set";
            // 
            // TimerTab
            // 
            TimerTab.Controls.Add(TSFGroupBoxT);
            TimerTab.Controls.Add(StatusGroupBoxT);
            TimerTab.Controls.Add(_StartTimeButton);
            TimerTab.Controls.Add(_StopTimeButton);
            TimerTab.Controls.Add(_PauseButtonT);
            TimerTab.Controls.Add(nudSec);
            TimerTab.Controls.Add(nudMin);
            TimerTab.Controls.Add(nudHour);
            TimerTab.Controls.Add(_ResumeTimeButton);
            TimerTab.ForeColor = Color.Black;
            TimerTab.ImageIndex = 1;
            TimerTab.Location = new Point(4, 23);
            TimerTab.Name = "TimerTab";
            TimerTab.Padding = new Padding(3);
            TimerTab.Size = new Size(536, 255);
            TimerTab.TabIndex = 1;
            TimerTab.Text = "Timer";
            // 
            // TSFGroupBoxT
            // 
            TSFGroupBoxT.Controls.Add(lblsfsecondstime);
            TSFGroupBoxT.Controls.Add(TSFSecondLabelT);
            TSFGroupBoxT.Controls.Add(SFMinAndLabelT);
            TSFGroupBoxT.Controls.Add(TSFMinsAndLabelT);
            TSFGroupBoxT.Controls.Add(TSFSecondIndicatorLabelT);
            TSFGroupBoxT.Controls.Add(TSFMinIndicatorLabelT);
            TSFGroupBoxT.Controls.Add(TSFHourIndicatorLabelT);
            TSFGroupBoxT.Controls.Add(lblsfhoursandtime);
            TSFGroupBoxT.Controls.Add(TSFHoursAndLabelT);
            TSFGroupBoxT.ForeColor = Color.Black;
            TSFGroupBoxT.Location = new Point(272, 104);
            TSFGroupBoxT.Name = "TSFGroupBoxT";
            TSFGroupBoxT.Size = new Size(112, 62);
            TSFGroupBoxT.TabIndex = 92;
            TSFGroupBoxT.TabStop = false;
            TSFGroupBoxT.Text = "Set For";
            // 
            // lblsfsecondstime
            // 
            lblsfsecondstime.AutoSize = true;
            lblsfsecondstime.Location = new Point(31, 43);
            lblsfsecondstime.Name = "lblsfsecondstime";
            lblsfsecondstime.Size = new Size(46, 13);
            lblsfsecondstime.TabIndex = 91;
            lblsfsecondstime.Text = "seconds";
            // 
            // TSFSecondLabelT
            // 
            TSFSecondLabelT.AutoSize = true;
            TSFSecondLabelT.Location = new Point(40, 43);
            TSFSecondLabelT.Name = "TSFSecondLabelT";
            TSFSecondLabelT.Size = new Size(41, 13);
            TSFSecondLabelT.TabIndex = 90;
            TSFSecondLabelT.Text = "second";
            // 
            // SFMinAndLabelT
            // 
            SFMinAndLabelT.AutoSize = true;
            SFMinAndLabelT.Location = new Point(31, 29);
            SFMinAndLabelT.Name = "SFMinAndLabelT";
            SFMinAndLabelT.Size = new Size(60, 13);
            SFMinAndLabelT.TabIndex = 89;
            SFMinAndLabelT.Text = "minute and";
            SFMinAndLabelT.Visible = false;
            // 
            // TSFMinsAndLabelT
            // 
            TSFMinsAndLabelT.AutoSize = true;
            TSFMinsAndLabelT.Location = new Point(31, 29);
            TSFMinsAndLabelT.Name = "TSFMinsAndLabelT";
            TSFMinsAndLabelT.Size = new Size(65, 13);
            TSFMinsAndLabelT.TabIndex = 88;
            TSFMinsAndLabelT.Text = "minutes and";
            // 
            // TSFSecondIndicatorLabelT
            // 
            TSFSecondIndicatorLabelT.AutoSize = true;
            TSFSecondIndicatorLabelT.Location = new Point(12, 43);
            TSFSecondIndicatorLabelT.Name = "TSFSecondIndicatorLabelT";
            TSFSecondIndicatorLabelT.Size = new Size(15, 13);
            TSFSecondIndicatorLabelT.TabIndex = 85;
            TSFSecondIndicatorLabelT.Text = "--";
            // 
            // TSFMinIndicatorLabelT
            // 
            TSFMinIndicatorLabelT.AutoSize = true;
            TSFMinIndicatorLabelT.Location = new Point(12, 30);
            TSFMinIndicatorLabelT.Name = "TSFMinIndicatorLabelT";
            TSFMinIndicatorLabelT.Size = new Size(15, 13);
            TSFMinIndicatorLabelT.TabIndex = 84;
            TSFMinIndicatorLabelT.Text = "--";
            // 
            // TSFHourIndicatorLabelT
            // 
            TSFHourIndicatorLabelT.AutoSize = true;
            TSFHourIndicatorLabelT.Location = new Point(12, 16);
            TSFHourIndicatorLabelT.Name = "TSFHourIndicatorLabelT";
            TSFHourIndicatorLabelT.Size = new Size(15, 13);
            TSFHourIndicatorLabelT.TabIndex = 83;
            TSFHourIndicatorLabelT.Text = "--";
            // 
            // lblsfhoursandtime
            // 
            lblsfhoursandtime.AutoSize = true;
            lblsfhoursandtime.Location = new Point(31, 16);
            lblsfhoursandtime.Name = "lblsfhoursandtime";
            lblsfhoursandtime.Size = new Size(50, 13);
            lblsfhoursandtime.TabIndex = 87;
            lblsfhoursandtime.Text = "hour and";
            lblsfhoursandtime.Visible = false;
            // 
            // TSFHoursAndLabelT
            // 
            TSFHoursAndLabelT.AutoSize = true;
            TSFHoursAndLabelT.Location = new Point(31, 16);
            TSFHoursAndLabelT.Name = "TSFHoursAndLabelT";
            TSFHoursAndLabelT.Size = new Size(55, 13);
            TSFHoursAndLabelT.TabIndex = 86;
            TSFHoursAndLabelT.Text = "hours and";
            // 
            // StatusGroupBoxT
            // 
            StatusGroupBoxT.Controls.Add(SecondsLabelT);
            StatusGroupBoxT.Controls.Add(lblsecondtime);
            StatusGroupBoxT.Controls.Add(lblminuteandtime);
            StatusGroupBoxT.Controls.Add(lblminutesandtime);
            StatusGroupBoxT.Controls.Add(lblsectime);
            StatusGroupBoxT.Controls.Add(lblmintime);
            StatusGroupBoxT.Controls.Add(lblhourtime);
            StatusGroupBoxT.Controls.Add(lblhourandtime);
            StatusGroupBoxT.Controls.Add(lblhoursandtime);
            StatusGroupBoxT.ForeColor = Color.Black;
            StatusGroupBoxT.Location = new Point(114, 104);
            StatusGroupBoxT.Name = "StatusGroupBoxT";
            StatusGroupBoxT.Size = new Size(112, 62);
            StatusGroupBoxT.TabIndex = 85;
            StatusGroupBoxT.TabStop = false;
            StatusGroupBoxT.Text = "Status";
            // 
            // SecondsLabelT
            // 
            SecondsLabelT.AutoSize = true;
            SecondsLabelT.Location = new Point(31, 43);
            SecondsLabelT.Name = "SecondsLabelT";
            SecondsLabelT.Size = new Size(46, 13);
            SecondsLabelT.TabIndex = 91;
            SecondsLabelT.Text = "seconds";
            // 
            // lblsecondtime
            // 
            lblsecondtime.AutoSize = true;
            lblsecondtime.Location = new Point(40, 43);
            lblsecondtime.Name = "lblsecondtime";
            lblsecondtime.Size = new Size(41, 13);
            lblsecondtime.TabIndex = 90;
            lblsecondtime.Text = "second";
            // 
            // lblminuteandtime
            // 
            lblminuteandtime.AutoSize = true;
            lblminuteandtime.Location = new Point(31, 29);
            lblminuteandtime.Name = "lblminuteandtime";
            lblminuteandtime.Size = new Size(60, 13);
            lblminuteandtime.TabIndex = 89;
            lblminuteandtime.Text = "minute and";
            lblminuteandtime.Visible = false;
            // 
            // lblminutesandtime
            // 
            lblminutesandtime.AutoSize = true;
            lblminutesandtime.Location = new Point(31, 29);
            lblminutesandtime.Name = "lblminutesandtime";
            lblminutesandtime.Size = new Size(65, 13);
            lblminutesandtime.TabIndex = 88;
            lblminutesandtime.Text = "minutes and";
            // 
            // lblsectime
            // 
            lblsectime.AutoSize = true;
            lblsectime.Location = new Point(12, 43);
            lblsectime.Name = "lblsectime";
            lblsectime.Size = new Size(15, 13);
            lblsectime.TabIndex = 85;
            lblsectime.Text = "--";
            // 
            // lblmintime
            // 
            lblmintime.AutoSize = true;
            lblmintime.Location = new Point(12, 30);
            lblmintime.Name = "lblmintime";
            lblmintime.Size = new Size(15, 13);
            lblmintime.TabIndex = 84;
            lblmintime.Text = "--";
            // 
            // lblhourtime
            // 
            lblhourtime.AutoSize = true;
            lblhourtime.Location = new Point(12, 16);
            lblhourtime.Name = "lblhourtime";
            lblhourtime.Size = new Size(15, 13);
            lblhourtime.TabIndex = 83;
            lblhourtime.Text = "--";
            // 
            // lblhourandtime
            // 
            lblhourandtime.AutoSize = true;
            lblhourandtime.Location = new Point(31, 16);
            lblhourandtime.Name = "lblhourandtime";
            lblhourandtime.Size = new Size(50, 13);
            lblhourandtime.TabIndex = 87;
            lblhourandtime.Text = "hour and";
            lblhourandtime.Visible = false;
            // 
            // lblhoursandtime
            // 
            lblhoursandtime.AutoSize = true;
            lblhoursandtime.Location = new Point(31, 16);
            lblhoursandtime.Name = "lblhoursandtime";
            lblhoursandtime.Size = new Size(55, 13);
            lblhoursandtime.TabIndex = 86;
            lblhoursandtime.Text = "hours and";
            // 
            // StartTimeButton
            // 
            _StartTimeButton.BackColor = Color.Transparent;
            _StartTimeButton.FlatStyle = FlatStyle.Flat;
            _StartTimeButton.Location = new Point(116, 75);
            _StartTimeButton.Name = "_StartTimeButton";
            _StartTimeButton.Size = new Size(62, 23);
            _StartTimeButton.TabIndex = 60;
            _StartTimeButton.Text = "Start";
            _StartTimeButton.UseVisualStyleBackColor = false;
            // 
            // StopTimeButton
            // 
            _StopTimeButton.BackColor = Color.Transparent;
            _StopTimeButton.FlatStyle = FlatStyle.Flat;
            _StopTimeButton.Location = new Point(180, 75);
            _StopTimeButton.Name = "_StopTimeButton";
            _StopTimeButton.Size = new Size(62, 23);
            _StopTimeButton.TabIndex = 63;
            _StopTimeButton.Text = "Stop";
            _StopTimeButton.UseVisualStyleBackColor = false;
            _StopTimeButton.Visible = false;
            // 
            // PauseButtonT
            // 
            _PauseButtonT.BackColor = Color.Transparent;
            _PauseButtonT.FlatStyle = FlatStyle.Flat;
            _PauseButtonT.Location = new Point(319, 75);
            _PauseButtonT.Name = "_PauseButtonT";
            _PauseButtonT.Size = new Size(65, 23);
            _PauseButtonT.TabIndex = 61;
            _PauseButtonT.Text = "Pause";
            _PauseButtonT.UseVisualStyleBackColor = false;
            _PauseButtonT.Visible = false;
            // 
            // nudSec
            // 
            nudSec.Location = new Point(281, 29);
            nudSec.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            nudSec.Name = "nudSec";
            nudSec.Size = new Size(50, 21);
            nudSec.TabIndex = 10;
            // 
            // nudMin
            // 
            nudMin.Location = new Point(225, 29);
            nudMin.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            nudMin.Name = "nudMin";
            nudMin.Size = new Size(50, 21);
            nudMin.TabIndex = 9;
            // 
            // nudHour
            // 
            nudHour.Location = new Point(169, 29);
            nudHour.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            nudHour.Name = "nudHour";
            nudHour.Size = new Size(50, 21);
            nudHour.TabIndex = 8;
            // 
            // ResumeTimeButton
            // 
            _ResumeTimeButton.BackColor = Color.Transparent;
            _ResumeTimeButton.FlatStyle = FlatStyle.Flat;
            _ResumeTimeButton.Location = new Point(248, 75);
            _ResumeTimeButton.Name = "_ResumeTimeButton";
            _ResumeTimeButton.Size = new Size(65, 23);
            _ResumeTimeButton.TabIndex = 62;
            _ResumeTimeButton.Text = "Resume";
            _ResumeTimeButton.UseVisualStyleBackColor = false;
            _ResumeTimeButton.Visible = false;
            // 
            // StopWatchTab
            // 
            StopWatchTab.Controls.Add(LapListBoxSw);
            StopWatchTab.Controls.Add(_LapButtonSW);
            StopWatchTab.Controls.Add(_PauseButtonSW);
            StopWatchTab.Controls.Add(StopwatchLabelSW);
            StopWatchTab.Controls.Add(_StartButtonSW);
            StopWatchTab.Controls.Add(_StopButtonSW);
            StopWatchTab.Controls.Add(_ResumeButtonSW);
            StopWatchTab.ImageIndex = 4;
            StopWatchTab.Location = new Point(4, 23);
            StopWatchTab.Name = "StopWatchTab";
            StopWatchTab.Size = new Size(536, 255);
            StopWatchTab.TabIndex = 3;
            StopWatchTab.Text = "Stopwatch";
            // 
            // LapListBoxSw
            // 
            LapListBoxSw.FormattingEnabled = true;
            LapListBoxSw.Location = new Point(142, 89);
            LapListBoxSw.Name = "LapListBoxSw";
            LapListBoxSw.Size = new Size(207, 82);
            LapListBoxSw.TabIndex = 65;
            LapListBoxSw.Visible = false;
            // 
            // LapButtonSW
            // 
            _LapButtonSW.BackColor = Color.Transparent;
            _LapButtonSW.FlatStyle = FlatStyle.Flat;
            _LapButtonSW.Location = new Point(355, 60);
            _LapButtonSW.Name = "_LapButtonSW";
            _LapButtonSW.Size = new Size(75, 23);
            _LapButtonSW.TabIndex = 64;
            _LapButtonSW.Text = "Lap";
            _LapButtonSW.UseVisualStyleBackColor = false;
            // 
            // PauseButtonSW
            // 
            _PauseButtonSW.BackColor = Color.Transparent;
            _PauseButtonSW.FlatStyle = FlatStyle.Flat;
            _PauseButtonSW.Location = new Point(213, 60);
            _PauseButtonSW.Name = "_PauseButtonSW";
            _PauseButtonSW.Size = new Size(65, 23);
            _PauseButtonSW.TabIndex = 61;
            _PauseButtonSW.Text = "Pause";
            _PauseButtonSW.UseVisualStyleBackColor = false;
            _PauseButtonSW.Visible = false;
            // 
            // StopwatchLabelSW
            // 
            StopwatchLabelSW.AutoSize = true;
            StopwatchLabelSW.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            StopwatchLabelSW.Location = new Point(209, 19);
            StopwatchLabelSW.Margin = new Padding(2, 0, 2, 0);
            StopwatchLabelSW.Name = "StopwatchLabelSW";
            StopwatchLabelSW.Size = new Size(66, 23);
            StopwatchLabelSW.TabIndex = 59;
            StopwatchLabelSW.Text = "--:--:--";
            StopwatchLabelSW.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StartButtonSW
            // 
            _StartButtonSW.BackColor = Color.Transparent;
            _StartButtonSW.FlatStyle = FlatStyle.Flat;
            _StartButtonSW.Location = new Point(71, 60);
            _StartButtonSW.Name = "_StartButtonSW";
            _StartButtonSW.Size = new Size(65, 23);
            _StartButtonSW.TabIndex = 60;
            _StartButtonSW.Text = "Start";
            _StartButtonSW.UseVisualStyleBackColor = false;
            // 
            // StopButtonSW
            // 
            _StopButtonSW.BackColor = Color.Transparent;
            _StopButtonSW.FlatStyle = FlatStyle.Flat;
            _StopButtonSW.Location = new Point(142, 60);
            _StopButtonSW.Name = "_StopButtonSW";
            _StopButtonSW.Size = new Size(65, 23);
            _StopButtonSW.TabIndex = 67;
            _StopButtonSW.Text = "Stop";
            _StopButtonSW.UseVisualStyleBackColor = false;
            _StopButtonSW.Visible = false;
            // 
            // ResumeButtonSW
            // 
            _ResumeButtonSW.BackColor = Color.Transparent;
            _ResumeButtonSW.FlatStyle = FlatStyle.Flat;
            _ResumeButtonSW.Location = new Point(284, 60);
            _ResumeButtonSW.Name = "_ResumeButtonSW";
            _ResumeButtonSW.Size = new Size(65, 23);
            _ResumeButtonSW.TabIndex = 66;
            _ResumeButtonSW.Text = "Resume";
            _ResumeButtonSW.UseVisualStyleBackColor = false;
            _ResumeButtonSW.Visible = false;
            // 
            // ShutdownTabPage
            // 
            ShutdownTabPage.Controls.Add(StatusGroupBoxSH);
            ShutdownTabPage.Controls.Add(_ShutdownCbSh);
            ShutdownTabPage.Controls.Add(_PauseButtonSh);
            ShutdownTabPage.Controls.Add(_StartButtonSh);
            ShutdownTabPage.Controls.Add(_StopButtonSh);
            ShutdownTabPage.Controls.Add(_ResumeButtonSh);
            ShutdownTabPage.Controls.Add(InSettingsGBSH);
            ShutdownTabPage.Controls.Add(AtSettingsGBSH);
            ShutdownTabPage.Controls.Add(_AtRadioButtonSh);
            ShutdownTabPage.Controls.Add(_InRadioButtonSh);
            ShutdownTabPage.ImageIndex = 3;
            ShutdownTabPage.Location = new Point(4, 23);
            ShutdownTabPage.Name = "ShutdownTabPage";
            ShutdownTabPage.Padding = new Padding(3);
            ShutdownTabPage.Size = new Size(536, 255);
            ShutdownTabPage.TabIndex = 4;
            ShutdownTabPage.Text = "Shutdown";
            // 
            // StatusGroupBoxSH
            // 
            StatusGroupBoxSH.Controls.Add(MinuteAndLabelSh);
            StatusGroupBoxSH.Controls.Add(DateTimeTillShutdownLabelSh);
            StatusGroupBoxSH.Controls.Add(HoursAndLabelSh);
            StatusGroupBoxSH.Controls.Add(HourAndLabelSh);
            StatusGroupBoxSH.Controls.Add(SecondsLabelSh);
            StatusGroupBoxSH.Controls.Add(HourIndicatorLabelSh);
            StatusGroupBoxSH.Controls.Add(SecondLabelSh);
            StatusGroupBoxSH.Controls.Add(MinuteIndicatorLabelSh);
            StatusGroupBoxSH.Controls.Add(MinutesAndLabelSh);
            StatusGroupBoxSH.Controls.Add(SecondsIndicatorLabelSh);
            StatusGroupBoxSH.ForeColor = Color.Black;
            StatusGroupBoxSH.Location = new Point(201, 129);
            StatusGroupBoxSH.Name = "StatusGroupBoxSH";
            StatusGroupBoxSH.Size = new Size(184, 63);
            StatusGroupBoxSH.TabIndex = 102;
            StatusGroupBoxSH.TabStop = false;
            StatusGroupBoxSH.Text = "Status";
            // 
            // MinuteAndLabelSh
            // 
            MinuteAndLabelSh.AutoSize = true;
            MinuteAndLabelSh.Location = new Point(44, 31);
            MinuteAndLabelSh.Name = "MinuteAndLabelSh";
            MinuteAndLabelSh.Size = new Size(60, 13);
            MinuteAndLabelSh.TabIndex = 97;
            MinuteAndLabelSh.Text = "minute and";
            MinuteAndLabelSh.Visible = false;
            // 
            // DateTimeTillShutdownLabelSh
            // 
            DateTimeTillShutdownLabelSh.AutoSize = true;
            DateTimeTillShutdownLabelSh.Location = new Point(127, 19);
            DateTimeTillShutdownLabelSh.Name = "DateTimeTillShutdownLabelSh";
            DateTimeTillShutdownLabelSh.Size = new Size(51, 13);
            DateTimeTillShutdownLabelSh.TabIndex = 101;
            DateTimeTillShutdownLabelSh.Text = "12:00:00";
            // 
            // HoursAndLabelSh
            // 
            HoursAndLabelSh.AutoSize = true;
            HoursAndLabelSh.Location = new Point(44, 19);
            HoursAndLabelSh.Name = "HoursAndLabelSh";
            HoursAndLabelSh.Size = new Size(55, 13);
            HoursAndLabelSh.TabIndex = 94;
            HoursAndLabelSh.Text = "hours and";
            // 
            // HourAndLabelSh
            // 
            HourAndLabelSh.AutoSize = true;
            HourAndLabelSh.Location = new Point(44, 19);
            HourAndLabelSh.Name = "HourAndLabelSh";
            HourAndLabelSh.Size = new Size(50, 13);
            HourAndLabelSh.TabIndex = 95;
            HourAndLabelSh.Text = "hour and";
            HourAndLabelSh.Visible = false;
            // 
            // SecondsLabelSh
            // 
            SecondsLabelSh.AutoSize = true;
            SecondsLabelSh.Location = new Point(44, 45);
            SecondsLabelSh.Name = "SecondsLabelSh";
            SecondsLabelSh.Size = new Size(46, 13);
            SecondsLabelSh.TabIndex = 99;
            SecondsLabelSh.Text = "seconds";
            // 
            // HourIndicatorLabelSh
            // 
            HourIndicatorLabelSh.AutoSize = true;
            HourIndicatorLabelSh.Location = new Point(25, 19);
            HourIndicatorLabelSh.Name = "HourIndicatorLabelSh";
            HourIndicatorLabelSh.Size = new Size(15, 13);
            HourIndicatorLabelSh.TabIndex = 91;
            HourIndicatorLabelSh.Text = "--";
            // 
            // SecondLabelSh
            // 
            SecondLabelSh.AutoSize = true;
            SecondLabelSh.Location = new Point(49, 45);
            SecondLabelSh.Name = "SecondLabelSh";
            SecondLabelSh.Size = new Size(41, 13);
            SecondLabelSh.TabIndex = 98;
            SecondLabelSh.Text = "second";
            // 
            // MinuteIndicatorLabelSh
            // 
            MinuteIndicatorLabelSh.AutoSize = true;
            MinuteIndicatorLabelSh.Location = new Point(25, 31);
            MinuteIndicatorLabelSh.Name = "MinuteIndicatorLabelSh";
            MinuteIndicatorLabelSh.Size = new Size(15, 13);
            MinuteIndicatorLabelSh.TabIndex = 92;
            MinuteIndicatorLabelSh.Text = "--";
            // 
            // MinutesAndLabelSh
            // 
            MinutesAndLabelSh.AutoSize = true;
            MinutesAndLabelSh.Location = new Point(44, 31);
            MinutesAndLabelSh.Name = "MinutesAndLabelSh";
            MinutesAndLabelSh.Size = new Size(65, 13);
            MinutesAndLabelSh.TabIndex = 96;
            MinutesAndLabelSh.Text = "minutes and";
            // 
            // SecondsIndicatorLabelSh
            // 
            SecondsIndicatorLabelSh.AutoSize = true;
            SecondsIndicatorLabelSh.Location = new Point(25, 45);
            SecondsIndicatorLabelSh.Name = "SecondsIndicatorLabelSh";
            SecondsIndicatorLabelSh.Size = new Size(15, 13);
            SecondsIndicatorLabelSh.TabIndex = 93;
            SecondsIndicatorLabelSh.Text = "--";
            // 
            // ShutdownCbSh
            // 
            _ShutdownCbSh.FormattingEnabled = true;
            _ShutdownCbSh.Items.AddRange(new object[] { "Log off", "Power Off", "Reboot", "Shutdown", "Suspend", "Hibernate" });
            _ShutdownCbSh.Location = new Point(52, 6);
            _ShutdownCbSh.Name = "_ShutdownCbSh";
            _ShutdownCbSh.Size = new Size(213, 21);
            _ShutdownCbSh.TabIndex = 100;
            // 
            // PauseButtonSh
            // 
            _PauseButtonSh.BackColor = Color.Transparent;
            _PauseButtonSh.FlatStyle = FlatStyle.Flat;
            _PauseButtonSh.ImageAlign = ContentAlignment.MiddleLeft;
            _PauseButtonSh.ImageIndex = 6;
            _PauseButtonSh.ImageList = IconsIL;
            _PauseButtonSh.Location = new Point(41, 129);
            _PauseButtonSh.Name = "_PauseButtonSh";
            _PauseButtonSh.Size = new Size(62, 23);
            _PauseButtonSh.TabIndex = 88;
            _PauseButtonSh.Text = "Pause";
            _PauseButtonSh.UseVisualStyleBackColor = false;
            _PauseButtonSh.Visible = false;
            // 
            // StartButtonSh
            // 
            _StartButtonSh.BackColor = Color.Transparent;
            _StartButtonSh.FlatStyle = FlatStyle.Flat;
            _StartButtonSh.ImageAlign = ContentAlignment.MiddleLeft;
            _StartButtonSh.ImageKey = "25B6.png";
            _StartButtonSh.ImageList = IconsIL;
            _StartButtonSh.Location = new Point(41, 103);
            _StartButtonSh.Name = "_StartButtonSh";
            _StartButtonSh.Size = new Size(62, 23);
            _StartButtonSh.TabIndex = 87;
            _StartButtonSh.Text = "Start";
            _StartButtonSh.UseVisualStyleBackColor = false;
            // 
            // StopButtonSh
            // 
            _StopButtonSh.BackColor = Color.Transparent;
            _StopButtonSh.FlatStyle = FlatStyle.Flat;
            _StopButtonSh.ImageAlign = ContentAlignment.MiddleLeft;
            _StopButtonSh.ImageKey = "23F9.png";
            _StopButtonSh.ImageList = IconsIL;
            _StopButtonSh.Location = new Point(109, 103);
            _StopButtonSh.Name = "_StopButtonSh";
            _StopButtonSh.Size = new Size(62, 23);
            _StopButtonSh.TabIndex = 90;
            _StopButtonSh.Text = "Stop";
            _StopButtonSh.UseVisualStyleBackColor = false;
            _StopButtonSh.Visible = false;
            // 
            // ResumeButtonSh
            // 
            _ResumeButtonSh.BackColor = Color.Transparent;
            _ResumeButtonSh.FlatStyle = FlatStyle.Flat;
            _ResumeButtonSh.ImageAlign = ContentAlignment.MiddleLeft;
            _ResumeButtonSh.ImageKey = "black-right-pointing-triangle_25b6.png";
            _ResumeButtonSh.ImageList = IconsIL;
            _ResumeButtonSh.Location = new Point(109, 129);
            _ResumeButtonSh.Name = "_ResumeButtonSh";
            _ResumeButtonSh.Size = new Size(62, 23);
            _ResumeButtonSh.TabIndex = 89;
            _ResumeButtonSh.Text = "Resume";
            _ResumeButtonSh.UseVisualStyleBackColor = false;
            _ResumeButtonSh.Visible = false;
            // 
            // InSettingsGBSH
            // 
            InSettingsGBSH.Controls.Add(VisualRadioButtonSh);
            InSettingsGBSH.Controls.Add(HourNudSh);
            InSettingsGBSH.Controls.Add(AudioRadioButtonSh);
            InSettingsGBSH.Controls.Add(TimeLabelSh);
            InSettingsGBSH.Controls.Add(MinWarnLabelSh);
            InSettingsGBSH.Controls.Add(MinWarnNudSh);
            InSettingsGBSH.Controls.Add(MinuteNudSh);
            InSettingsGBSH.Controls.Add(SecondNudSh);
            InSettingsGBSH.ForeColor = Color.Black;
            InSettingsGBSH.Location = new Point(192, 41);
            InSettingsGBSH.Name = "InSettingsGBSH";
            InSettingsGBSH.Size = new Size(218, 86);
            InSettingsGBSH.TabIndex = 85;
            InSettingsGBSH.TabStop = false;
            InSettingsGBSH.Text = "In Settings";
            // 
            // VisualRadioButtonSh
            // 
            VisualRadioButtonSh.AutoSize = true;
            VisualRadioButtonSh.Location = new Point(159, 58);
            VisualRadioButtonSh.Name = "VisualRadioButtonSh";
            VisualRadioButtonSh.Size = new Size(52, 17);
            VisualRadioButtonSh.TabIndex = 62;
            VisualRadioButtonSh.TabStop = true;
            VisualRadioButtonSh.Text = "Visual";
            VisualRadioButtonSh.UseVisualStyleBackColor = true;
            // 
            // HourNudSh
            // 
            HourNudSh.ForeColor = SystemColors.ControlText;
            HourNudSh.Location = new Point(72, 19);
            HourNudSh.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            HourNudSh.Name = "HourNudSh";
            HourNudSh.Size = new Size(42, 21);
            HourNudSh.TabIndex = 34;
            // 
            // AudioRadioButtonSh
            // 
            AudioRadioButtonSh.AutoSize = true;
            AudioRadioButtonSh.Location = new Point(109, 58);
            AudioRadioButtonSh.Name = "AudioRadioButtonSh";
            AudioRadioButtonSh.Size = new Size(52, 17);
            AudioRadioButtonSh.TabIndex = 61;
            AudioRadioButtonSh.TabStop = true;
            AudioRadioButtonSh.Text = "Audio";
            AudioRadioButtonSh.UseVisualStyleBackColor = true;
            // 
            // TimeLabelSh
            // 
            TimeLabelSh.AutoSize = true;
            TimeLabelSh.Location = new Point(24, 19);
            TimeLabelSh.Name = "TimeLabelSh";
            TimeLabelSh.Size = new Size(33, 13);
            TimeLabelSh.TabIndex = 29;
            TimeLabelSh.Text = "Time:";
            // 
            // MinWarnLabelSh
            // 
            MinWarnLabelSh.AutoSize = true;
            MinWarnLabelSh.Location = new Point(6, 57);
            MinWarnLabelSh.Name = "MinWarnLabelSh";
            MinWarnLabelSh.Size = new Size(53, 13);
            MinWarnLabelSh.TabIndex = 43;
            MinWarnLabelSh.Text = "MinWarn:";
            // 
            // MinWarnNudSh
            // 
            MinWarnNudSh.Location = new Point(65, 55);
            MinWarnNudSh.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            MinWarnNudSh.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            MinWarnNudSh.Name = "MinWarnNudSh";
            MinWarnNudSh.Size = new Size(40, 21);
            MinWarnNudSh.TabIndex = 60;
            MinWarnNudSh.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // MinuteNudSh
            // 
            MinuteNudSh.ForeColor = SystemColors.ControlText;
            MinuteNudSh.Location = new Point(120, 19);
            MinuteNudSh.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            MinuteNudSh.Name = "MinuteNudSh";
            MinuteNudSh.Size = new Size(41, 21);
            MinuteNudSh.TabIndex = 35;
            // 
            // SecondNudSh
            // 
            SecondNudSh.ForeColor = SystemColors.ControlText;
            SecondNudSh.Location = new Point(167, 19);
            SecondNudSh.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            SecondNudSh.Name = "SecondNudSh";
            SecondNudSh.Size = new Size(40, 21);
            SecondNudSh.TabIndex = 36;
            // 
            // AtSettingsGBSH
            // 
            AtSettingsGBSH.Controls.Add(HourAtNudSh);
            AtSettingsGBSH.Controls.Add(MinuteAtNudSh);
            AtSettingsGBSH.Controls.Add(TimeAtLabelSh);
            AtSettingsGBSH.ForeColor = Color.Black;
            AtSettingsGBSH.Location = new Point(41, 41);
            AtSettingsGBSH.Name = "AtSettingsGBSH";
            AtSettingsGBSH.Size = new Size(145, 50);
            AtSettingsGBSH.TabIndex = 86;
            AtSettingsGBSH.TabStop = false;
            AtSettingsGBSH.Text = "At Settings";
            // 
            // HourAtNudSh
            // 
            HourAtNudSh.ForeColor = SystemColors.ControlText;
            HourAtNudSh.Location = new Point(45, 15);
            HourAtNudSh.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            HourAtNudSh.Name = "HourAtNudSh";
            HourAtNudSh.Size = new Size(42, 21);
            HourAtNudSh.TabIndex = 37;
            // 
            // MinuteAtNudSh
            // 
            MinuteAtNudSh.ForeColor = SystemColors.ControlText;
            MinuteAtNudSh.Location = new Point(93, 15);
            MinuteAtNudSh.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            MinuteAtNudSh.Name = "MinuteAtNudSh";
            MinuteAtNudSh.Size = new Size(41, 21);
            MinuteAtNudSh.TabIndex = 38;
            // 
            // TimeAtLabelSh
            // 
            TimeAtLabelSh.AutoSize = true;
            TimeAtLabelSh.ForeColor = Color.Black;
            TimeAtLabelSh.Location = new Point(8, 19);
            TimeAtLabelSh.Name = "TimeAtLabelSh";
            TimeAtLabelSh.Size = new Size(33, 13);
            TimeAtLabelSh.TabIndex = 33;
            TimeAtLabelSh.Text = "Time:";
            // 
            // AtRadioButtonSh
            // 
            _AtRadioButtonSh.AutoSize = true;
            _AtRadioButtonSh.Location = new Point(270, 7);
            _AtRadioButtonSh.Name = "_AtRadioButtonSh";
            _AtRadioButtonSh.Size = new Size(36, 17);
            _AtRadioButtonSh.TabIndex = 83;
            _AtRadioButtonSh.Text = "At";
            _AtRadioButtonSh.UseVisualStyleBackColor = false;
            // 
            // InRadioButtonSh
            // 
            _InRadioButtonSh.AutoSize = true;
            _InRadioButtonSh.Location = new Point(311, 7);
            _InRadioButtonSh.Name = "_InRadioButtonSh";
            _InRadioButtonSh.Size = new Size(35, 17);
            _InRadioButtonSh.TabIndex = 84;
            _InRadioButtonSh.Text = "In";
            _InRadioButtonSh.UseVisualStyleBackColor = false;
            // 
            // TimerTimer
            // 
            _TimerTimer.Interval = 1000;
            // 
            // tBeep
            // 
            // 
            // DTPErhAc
            // 
            DTPErhAc.ContainerControl = this;
            // 
            // TitlePanel
            // 
            TitlePanel.BackgroundImageLayout = ImageLayout.Stretch;
            TitlePanel.BorderStyle = BorderStyle.FixedSingle;
            TitlePanel.Controls.Add(PictureBox1);
            TitlePanel.Controls.Add(TimeLabelYD);
            TitlePanel.Controls.Add(_SettingsButton);
            TitlePanel.Controls.Add(DateLabelYD);
            TitlePanel.Controls.Add(lblwelcome);
            TitlePanel.Controls.Add(lblVersion);
            TitlePanel.Controls.Add(lblName);
            TitlePanel.Dock = DockStyle.Fill;
            TitlePanel.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TitlePanel.Location = new Point(0, 0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(544, 115);
            TitlePanel.TabIndex = 25;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = (Image)resources.GetObject("PictureBox1.Image");
            PictureBox1.Location = new Point(313, 3);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(76, 73);
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox1.TabIndex = 85;
            PictureBox1.TabStop = false;
            // 
            // TimeLabelYD
            // 
            TimeLabelYD.AutoSize = true;
            TimeLabelYD.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            TimeLabelYD.ForeColor = Color.Black;
            TimeLabelYD.Location = new Point(250, 97);
            TimeLabelYD.Name = "TimeLabelYD";
            TimeLabelYD.Size = new Size(139, 13);
            TimeLabelYD.TabIndex = 84;
            TimeLabelYD.Text = "the time is 12:00:00 AM";
            // 
            // SettingsButton
            // 
            _SettingsButton.BackColor = Color.Transparent;
            _SettingsButton.FlatStyle = FlatStyle.Flat;
            _SettingsButton.ForeColor = Color.Black;
            _SettingsButton.Location = new Point(477, 87);
            _SettingsButton.Name = "_SettingsButton";
            _SettingsButton.Size = new Size(62, 23);
            _SettingsButton.TabIndex = 83;
            _SettingsButton.Text = "Settings";
            _SettingsButton.UseVisualStyleBackColor = false;
            // 
            // DateLabelYD
            // 
            DateLabelYD.AutoSize = true;
            DateLabelYD.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            DateLabelYD.ForeColor = Color.Black;
            DateLabelYD.Location = new Point(86, 97);
            DateLabelYD.Name = "DateLabelYD";
            DateLabelYD.Size = new Size(158, 13);
            DateLabelYD.TabIndex = 28;
            DateLabelYD.Text = "the date is january 1, 2022";
            // 
            // lblwelcome
            // 
            lblwelcome.AutoSize = true;
            lblwelcome.Font = new Font("Tahoma", 12.0F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, Conversions.ToByte(0));
            lblwelcome.ForeColor = Color.Black;
            lblwelcome.Location = new Point(190, 78);
            lblwelcome.Name = "lblwelcome";
            lblwelcome.Size = new Size(126, 19);
            lblwelcome.TabIndex = 27;
            lblwelcome.Text = "welcome, user";
            lblwelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblVersion.ForeColor = Color.Black;
            lblVersion.Location = new Point(155, 33);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(148, 26);
            lblVersion.TabIndex = 26;
            lblVersion.Text = "v21H1" + '\r' + '\n' + "Released December 13, 2020";
            lblVersion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(154, 10);
            lblName.Name = "lblName";
            lblName.Size = new Size(153, 23);
            lblName.TabIndex = 25;
            lblName.Text = "Ultimate Timer";
            // 
            // AlarmTimer
            // 
            _AlarmTimer.Interval = 1000;
            // 
            // ShutdownTimer
            // 
            _ShutdownTimer.Interval = 1000;
            // 
            // YDTimer
            // 
            _YDTimer.Interval = 1000;
            // 
            // NotifyIconWDLCT
            // 
            NotifyIconWDLCT.ContextMenuStrip = ContextMenuStrip1;
            NotifyIconWDLCT.Icon = (Icon)resources.GetObject("NotifyIconWDLCT.Icon");
            NotifyIconWDLCT.Text = "WCT Timer is running.";
            NotifyIconWDLCT.Visible = true;
            // 
            // ContextMenuStrip1
            // 
            ContextMenuStrip1.Items.AddRange(new ToolStripItem[] { _OpenToolStripMenuItem, _ChangeSettingsToolStripMenuItem, _ExitToolStripMenuItem });
            ContextMenuStrip1.Name = "ContextMenuStrip1";
            ContextMenuStrip1.Size = new Size(161, 70);
            // 
            // OpenToolStripMenuItem
            // 
            _OpenToolStripMenuItem.Name = "_OpenToolStripMenuItem";
            _OpenToolStripMenuItem.Size = new Size(160, 22);
            _OpenToolStripMenuItem.Text = "Open";
            // 
            // ChangeSettingsToolStripMenuItem
            // 
            _ChangeSettingsToolStripMenuItem.Name = "_ChangeSettingsToolStripMenuItem";
            _ChangeSettingsToolStripMenuItem.Size = new Size(160, 22);
            _ChangeSettingsToolStripMenuItem.Text = "Change Settings";
            // 
            // ExitToolStripMenuItem
            // 
            _ExitToolStripMenuItem.Name = "_ExitToolStripMenuItem";
            _ExitToolStripMenuItem.Size = new Size(160, 22);
            _ExitToolStripMenuItem.Text = "Exit";
            // 
            // TimeBomb
            // 
            TimeBomb.Interval = 1000;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(544, 397);
            Controls.Add(TitlePanel);
            Controls.Add(TimerControl);
            Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ultimate Timer - v21H1 - Released on December 13 2020";
            TimerControl.ResumeLayout(false);
            BreakTimerTab.ResumeLayout(false);
            BreakTimerTab.PerformLayout();
            BSTGroupBoxBT.ResumeLayout(false);
            BSTGroupBoxBT.PerformLayout();
            TSFGroupBoxBT.ResumeLayout(false);
            TSFGroupBoxBT.PerformLayout();
            ControlsGroupBoxBT.ResumeLayout(false);
            TimerGBBt.ResumeLayout(false);
            TimerGBBt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_nudTimeHour).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinWarnNudBt).EndInit();
            ((System.ComponentModel.ISupportInitialize)_nudTimeMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)_nudTimeBreakSec).EndInit();
            ((System.ComponentModel.ISupportInitialize)_nudTimeSec).EndInit();
            ((System.ComponentModel.ISupportInitialize)_nudTimeBreakMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)_nudTimeBreakHour).EndInit();
            BreakGBBt.ResumeLayout(false);
            BreakGBBt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_B1HourNudBT).EndInit();
            ((System.ComponentModel.ISupportInitialize)_nudb1sec).EndInit();
            ((System.ComponentModel.ISupportInitialize)_nudb1min).EndInit();
            StatusGroupBoxBT.ResumeLayout(false);
            StatusGroupBoxBT.PerformLayout();
            AlarmClockTab.ResumeLayout(false);
            AlarmClockTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HourNudAC).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinNudAC).EndInit();
            ((System.ComponentModel.ISupportInitialize)SecNudAC).EndInit();
            TimerTab.ResumeLayout(false);
            TSFGroupBoxT.ResumeLayout(false);
            TSFGroupBoxT.PerformLayout();
            StatusGroupBoxT.ResumeLayout(false);
            StatusGroupBoxT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSec).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHour).EndInit();
            StopWatchTab.ResumeLayout(false);
            StopWatchTab.PerformLayout();
            ShutdownTabPage.ResumeLayout(false);
            ShutdownTabPage.PerformLayout();
            StatusGroupBoxSH.ResumeLayout(false);
            StatusGroupBoxSH.PerformLayout();
            InSettingsGBSH.ResumeLayout(false);
            InSettingsGBSH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HourNudSh).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinWarnNudSh).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinuteNudSh).EndInit();
            ((System.ComponentModel.ISupportInitialize)SecondNudSh).EndInit();
            AtSettingsGBSH.ResumeLayout(false);
            AtSettingsGBSH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HourAtNudSh).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinuteAtNudSh).EndInit();
            ((System.ComponentModel.ISupportInitialize)DTPErhAc).EndInit();
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ContextMenuStrip1.ResumeLayout(false);
            Load += new EventHandler(FrmLAG_Load);
            Shown += new EventHandler(MainFormLAG_Shown);
            ResumeLayout(false);
        }

        private Timer _BreakTimer;

        public Timer BreakTimer
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BreakTimer;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BreakTimer != null)
                {
                    _BreakTimer.Tick -= BreakTimer_Tick;
                }

                _BreakTimer = value;
                if (_BreakTimer != null)
                {
                    _BreakTimer.Tick += BreakTimer_Tick;
                }
            }
        }

        private TabControl TimerControl;
        private TabPage BreakTimerTab;
        private GroupBox TimerGBBt;
        private NumericUpDown _nudTimeHour;

        internal NumericUpDown nudTimeHour
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _nudTimeHour;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudTimeHour != null)
                {
                    _nudTimeHour.ValueChanged -= NudTimeHour_ValueChanged;
                }

                _nudTimeHour = value;
                if (_nudTimeHour != null)
                {
                    _nudTimeHour.ValueChanged += NudTimeHour_ValueChanged;
                }
            }
        }

        private Label TimeLabelBt;
        private Label BreakTimerALabelBT;
        private NumericUpDown _nudTimeMin;

        internal NumericUpDown nudTimeMin
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _nudTimeMin;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudTimeMin != null)
                {
                    _nudTimeMin.ValueChanged -= NudTimeMin_ValueChanged;
                }

                _nudTimeMin = value;
                if (_nudTimeMin != null)
                {
                    _nudTimeMin.ValueChanged += NudTimeMin_ValueChanged;
                }
            }
        }

        private NumericUpDown _nudTimeBreakSec;

        internal NumericUpDown nudTimeBreakSec
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _nudTimeBreakSec;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudTimeBreakSec != null)
                {
                    _nudTimeBreakSec.ValueChanged -= NudTimeBreakSec_ValueChanged;
                }

                _nudTimeBreakSec = value;
                if (_nudTimeBreakSec != null)
                {
                    _nudTimeBreakSec.ValueChanged += NudTimeBreakSec_ValueChanged;
                }
            }
        }

        private NumericUpDown _nudTimeSec;

        internal NumericUpDown nudTimeSec
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _nudTimeSec;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudTimeSec != null)
                {
                    _nudTimeSec.ValueChanged -= NudTimeSec_ValueChanged;
                }

                _nudTimeSec = value;
                if (_nudTimeSec != null)
                {
                    _nudTimeSec.ValueChanged += NudTimeSec_ValueChanged;
                }
            }
        }

        private NumericUpDown _nudTimeBreakMin;

        internal NumericUpDown nudTimeBreakMin
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _nudTimeBreakMin;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudTimeBreakMin != null)
                {
                    _nudTimeBreakMin.ValueChanged -= NudTimeBreakMin_ValueChanged;
                }

                _nudTimeBreakMin = value;
                if (_nudTimeBreakMin != null)
                {
                    _nudTimeBreakMin.ValueChanged += NudTimeBreakMin_ValueChanged;
                }
            }
        }

        private NumericUpDown _nudTimeBreakHour;

        internal NumericUpDown nudTimeBreakHour
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _nudTimeBreakHour;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudTimeBreakHour != null)
                {
                    _nudTimeBreakHour.ValueChanged -= NudTimeBreakHour_ValueChanged;
                }

                _nudTimeBreakHour = value;
                if (_nudTimeBreakHour != null)
                {
                    _nudTimeBreakHour.ValueChanged += NudTimeBreakHour_ValueChanged;
                }
            }
        }

        private GroupBox BreakGBBt;
        private Label BreakLabelBT;
        private NumericUpDown _B1HourNudBT;

        internal NumericUpDown B1HourNudBT
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _B1HourNudBT;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_B1HourNudBT != null)
                {
                    _B1HourNudBT.ValueChanged -= Nudb1hour_ValueChanged;
                }

                _B1HourNudBT = value;
                if (_B1HourNudBT != null)
                {
                    _B1HourNudBT.ValueChanged += Nudb1hour_ValueChanged;
                }
            }
        }

        private NumericUpDown _nudb1sec;

        internal NumericUpDown nudb1sec
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _nudb1sec;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudb1sec != null)
                {
                    _nudb1sec.ValueChanged -= Nudb1sec_ValueChanged;
                }

                _nudb1sec = value;
                if (_nudb1sec != null)
                {
                    _nudb1sec.ValueChanged += Nudb1sec_ValueChanged;
                }
            }
        }

        private NumericUpDown _nudb1min;

        internal NumericUpDown nudb1min
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _nudb1min;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudb1min != null)
                {
                    _nudb1min.ValueChanged -= Nudb1min_ValueChanged;
                }

                _nudb1min = value;
                if (_nudb1min != null)
                {
                    _nudb1min.ValueChanged += Nudb1min_ValueChanged;
                }
            }
        }

        private RadioButton _TimeRBBt;

        internal RadioButton TimeRBBt
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TimeRBBt;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TimeRBBt != null)
                {
                    _TimeRBBt.CheckedChanged -= RbSet_CheckedChanged;
                }

                _TimeRBBt = value;
                if (_TimeRBBt != null)
                {
                    _TimeRBBt.CheckedChanged += RbSet_CheckedChanged;
                }
            }
        }

        private RadioButton _BreakRBBt;

        internal RadioButton BreakRBBt
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BreakRBBt;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BreakRBBt != null)
                {
                    _BreakRBBt.CheckedChanged -= RbBreak_CheckedChanged;
                }

                _BreakRBBt = value;
                if (_BreakRBBt != null)
                {
                    _BreakRBBt.CheckedChanged += RbBreak_CheckedChanged;
                }
            }
        }

        private TabPage TimerTab;
        private TabPage AlarmClockTab;
        private TabPage StopWatchTab;
        private NumericUpDown nudSec;
        private NumericUpDown nudMin;
        private NumericUpDown nudHour;
        private Button _btnStop;

        public Button btnStop
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnStop;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnStop != null)
                {
                    _btnStop.Click -= Stopbutton_Click;
                }

                _btnStop = value;
                if (_btnStop != null)
                {
                    _btnStop.Click += Stopbutton_Click;
                }
            }
        }

        private Button _btnResume;

        public Button btnResume
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnResume;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnResume != null)
                {
                    _btnResume.Click -= BtnResume_Click;
                }

                _btnResume = value;
                if (_btnResume != null)
                {
                    _btnResume.Click += BtnResume_Click;
                }
            }
        }

        private Button _PauseButtonBT;

        public Button PauseButtonBT
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PauseButtonBT;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PauseButtonBT != null)
                {
                    _PauseButtonBT.Click -= Pausebutton_Click;
                }

                _PauseButtonBT = value;
                if (_PauseButtonBT != null)
                {
                    _PauseButtonBT.Click += Pausebutton_Click;
                }
            }
        }

        private Button _StartButtonBT;

        public Button StartButtonBT
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _StartButtonBT;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_StartButtonBT != null)
                {
                    _StartButtonBT.Click -= Button1_Click_2;
                }

                _StartButtonBT = value;
                if (_StartButtonBT != null)
                {
                    _StartButtonBT.Click += Button1_Click_2;
                }
            }
        }

        private Label lblTimeRemaining;
        private Label AlarmStatusLabel;
        private Button _CancelAlarmButton;

        internal Button CancelAlarmButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CancelAlarmButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CancelAlarmButton != null)
                {
                    _CancelAlarmButton.Click -= CancelAlarmButton_Click;
                }

                _CancelAlarmButton = value;
                if (_CancelAlarmButton != null)
                {
                    _CancelAlarmButton.Click += CancelAlarmButton_Click;
                }
            }
        }

        private Button _SetAlarmButton;

        internal Button SetAlarmButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SetAlarmButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SetAlarmButton != null)
                {
                    _SetAlarmButton.Click -= StartAlarmButton_Click;
                }

                _SetAlarmButton = value;
                if (_SetAlarmButton != null)
                {
                    _SetAlarmButton.Click += StartAlarmButton_Click;
                }
            }
        }

        private Label SetOrNotSetLabel;
        private Button _StopTimeButton;

        public Button StopTimeButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _StopTimeButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_StopTimeButton != null)
                {
                    _StopTimeButton.Click -= StopTimeButton_Click;
                }

                _StopTimeButton = value;
                if (_StopTimeButton != null)
                {
                    _StopTimeButton.Click += StopTimeButton_Click;
                }
            }
        }

        private Button _ResumeTimeButton;

        public Button ResumeTimeButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ResumeTimeButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ResumeTimeButton != null)
                {
                    _ResumeTimeButton.Click -= Resumetimebutton_Click;
                }

                _ResumeTimeButton = value;
                if (_ResumeTimeButton != null)
                {
                    _ResumeTimeButton.Click += Resumetimebutton_Click;
                }
            }
        }

        private Button _PauseButtonT;

        public Button PauseButtonT
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PauseButtonT;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PauseButtonT != null)
                {
                    _PauseButtonT.Click -= PauseTimeButton_Click;
                }

                _PauseButtonT = value;
                if (_PauseButtonT != null)
                {
                    _PauseButtonT.Click += PauseTimeButton_Click;
                }
            }
        }

        private Button _StartTimeButton;

        public Button StartTimeButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _StartTimeButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_StartTimeButton != null)
                {
                    _StartTimeButton.Click -= BtnStart_Click;
                }

                _StartTimeButton = value;
                if (_StartTimeButton != null)
                {
                    _StartTimeButton.Click += BtnStart_Click;
                }
            }
        }

        private ListBox LapListBoxSw;
        private Button _LapButtonSW;

        internal Button LapButtonSW
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LapButtonSW;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LapButtonSW != null)
                {
                    _LapButtonSW.Click -= LapButton_Click;
                }

                _LapButtonSW = value;
                if (_LapButtonSW != null)
                {
                    _LapButtonSW.Click += LapButton_Click;
                }
            }
        }

        private Button _PauseButtonSW;

        public Button PauseButtonSW
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PauseButtonSW;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PauseButtonSW != null)
                {
                    _PauseButtonSW.Click -= PauseButton_Click_1;
                }

                _PauseButtonSW = value;
                if (_PauseButtonSW != null)
                {
                    _PauseButtonSW.Click += PauseButton_Click_1;
                }
            }
        }

        private Label StopwatchLabelSW;
        private Button _StartButtonSW;

        public Button StartButtonSW
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _StartButtonSW;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_StartButtonSW != null)
                {
                    _StartButtonSW.Click -= StartButton_Click;
                }

                _StartButtonSW = value;
                if (_StartButtonSW != null)
                {
                    _StartButtonSW.Click += StartButton_Click;
                }
            }
        }

        private Timer _TimerTimer;

        internal Timer TimerTimer
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TimerTimer;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TimerTimer != null)
                {
                    _TimerTimer.Tick -= TimerTimer_Tick;
                }

                _TimerTimer = value;
                if (_TimerTimer != null)
                {
                    _TimerTimer.Tick += TimerTimer_Tick;
                }
            }
        }

        private Timer _tBeep;

        internal Timer tBeep
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tBeep;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tBeep != null)
                {
                    _tBeep.Tick -= TBeep_Tick;
                }

                _tBeep = value;
                if (_tBeep != null)
                {
                    _tBeep.Tick += TBeep_Tick;
                }
            }
        }

        private ErrorProvider DTPErhAc;
        private Panel TitlePanel;
        private Label lblVersion;
        private Label lblName;
        private Timer _AlarmTimer;

        public Timer AlarmTimer
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _AlarmTimer;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_AlarmTimer != null)
                {
                    _AlarmTimer.Tick -= AlarmTimer_Tick;
                }

                _AlarmTimer = value;
                if (_AlarmTimer != null)
                {
                    _AlarmTimer.Tick += AlarmTimer_Tick;
                }
            }
        }

        private Button _StopButtonSW;

        public Button StopButtonSW
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _StopButtonSW;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_StopButtonSW != null)
                {
                    _StopButtonSW.Click -= StopStopWButton_Click;
                }

                _StopButtonSW = value;
                if (_StopButtonSW != null)
                {
                    _StopButtonSW.Click += StopStopWButton_Click;
                }
            }
        }

        private Button _ResumeButtonSW;

        public Button ResumeButtonSW
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ResumeButtonSW;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ResumeButtonSW != null)
                {
                    _ResumeButtonSW.Click -= ResumeStopWButton_Click;
                }

                _ResumeButtonSW = value;
                if (_ResumeButtonSW != null)
                {
                    _ResumeButtonSW.Click += ResumeStopWButton_Click;
                }
            }
        }

        private RadioButton VisualRbBt;
        private RadioButton AudioRbBt;
        private Label MWLabelBt;
        private NumericUpDown MinWarnNudBt;
        private TabPage ShutdownTabPage;
        private Label DateTimeTillShutdownLabelSh;
        private ComboBox _ShutdownCbSh;

        internal ComboBox ShutdownCbSh
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ShutdownCbSh;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ShutdownCbSh != null)
                {
                    _ShutdownCbSh.SelectedIndexChanged -= ShutdownCbSh_SelectedIndexChanged;
                }

                _ShutdownCbSh = value;
                if (_ShutdownCbSh != null)
                {
                    _ShutdownCbSh.SelectedIndexChanged += ShutdownCbSh_SelectedIndexChanged;
                }
            }
        }

        private Label SecondsLabelSh;
        private Label SecondLabelSh;
        private Label MinuteAndLabelSh;
        private Label MinutesAndLabelSh;
        private Label SecondsIndicatorLabelSh;
        private Label MinuteIndicatorLabelSh;
        private Label HourIndicatorLabelSh;
        private Button _PauseButtonSh;

        public Button PauseButtonSh
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PauseButtonSh;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PauseButtonSh != null)
                {
                    _PauseButtonSh.Click -= PauseButtonSh_Click;
                }

                _PauseButtonSh = value;
                if (_PauseButtonSh != null)
                {
                    _PauseButtonSh.Click += PauseButtonSh_Click;
                }
            }
        }

        private Button _StartButtonSh;

        public Button StartButtonSh
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _StartButtonSh;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_StartButtonSh != null)
                {
                    _StartButtonSh.Click -= StartButtonSh_Click;
                }

                _StartButtonSh = value;
                if (_StartButtonSh != null)
                {
                    _StartButtonSh.Click += StartButtonSh_Click;
                }
            }
        }

        private Button _StopButtonSh;

        public Button StopButtonSh
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _StopButtonSh;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_StopButtonSh != null)
                {
                    _StopButtonSh.Click -= StopButtonSh_Click;
                }

                _StopButtonSh = value;
                if (_StopButtonSh != null)
                {
                    _StopButtonSh.Click += StopButtonSh_Click;
                }
            }
        }

        private Button _ResumeButtonSh;

        public Button ResumeButtonSh
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ResumeButtonSh;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ResumeButtonSh != null)
                {
                    _ResumeButtonSh.Click -= ResumeButtonSh_Click;
                }

                _ResumeButtonSh = value;
                if (_ResumeButtonSh != null)
                {
                    _ResumeButtonSh.Click += ResumeButtonSh_Click;
                }
            }
        }

        private GroupBox InSettingsGBSH;
        private RadioButton VisualRadioButtonSh;
        private NumericUpDown HourNudSh;
        private RadioButton AudioRadioButtonSh;
        private Label TimeLabelSh;
        private Label MinWarnLabelSh;
        private NumericUpDown MinWarnNudSh;
        private NumericUpDown MinuteNudSh;
        private NumericUpDown SecondNudSh;
        private GroupBox AtSettingsGBSH;
        private Label TimeAtLabelSh;
        private RadioButton _AtRadioButtonSh;

        internal RadioButton AtRadioButtonSh
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _AtRadioButtonSh;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_AtRadioButtonSh != null)
                {
                    _AtRadioButtonSh.CheckedChanged -= AtRadioButtonSh_CheckedChanged;
                }

                _AtRadioButtonSh = value;
                if (_AtRadioButtonSh != null)
                {
                    _AtRadioButtonSh.CheckedChanged += AtRadioButtonSh_CheckedChanged;
                }
            }
        }

        private RadioButton _InRadioButtonSh;

        internal RadioButton InRadioButtonSh
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _InRadioButtonSh;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_InRadioButtonSh != null)
                {
                    _InRadioButtonSh.CheckedChanged -= InRadioButtonSh_CheckedChanged;
                }

                _InRadioButtonSh = value;
                if (_InRadioButtonSh != null)
                {
                    _InRadioButtonSh.CheckedChanged += InRadioButtonSh_CheckedChanged;
                }
            }
        }

        private Label HourAndLabelSh;
        private Label HoursAndLabelSh;
        private Timer _ShutdownTimer;

        internal Timer ShutdownTimer
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ShutdownTimer;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ShutdownTimer != null)
                {
                    _ShutdownTimer.Tick -= ShutdownTimer_Tick;
                }

                _ShutdownTimer = value;
                if (_ShutdownTimer != null)
                {
                    _ShutdownTimer.Tick += ShutdownTimer_Tick;
                }
            }
        }

        private NumericUpDown HourAtNudSh;
        private NumericUpDown MinuteAtNudSh;
        private Label DateLabelYD;
        private Label lblwelcome;
        private Timer _YDTimer;

        internal Timer YDTimer
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _YDTimer;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_YDTimer != null)
                {
                    _YDTimer.Tick -= YDTimer_Tick;
                }

                _YDTimer = value;
                if (_YDTimer != null)
                {
                    _YDTimer.Tick += YDTimer_Tick;
                }
            }
        }

        private Button _SettingsButton;

        public Button SettingsButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SettingsButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SettingsButton != null)
                {
                    _SettingsButton.Click -= SettingsButton_Click;
                }

                _SettingsButton = value;
                if (_SettingsButton != null)
                {
                    _SettingsButton.Click += SettingsButton_Click;
                }
            }
        }

        private NotifyIcon NotifyIconWDLCT;
        private Button _BreakNowButtonBt;

        public Button BreakNowButtonBt
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BreakNowButtonBt;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BreakNowButtonBt != null)
                {
                    _BreakNowButtonBt.Click -= BreakNowButtonBt_Click;
                }

                _BreakNowButtonBt = value;
                if (_BreakNowButtonBt != null)
                {
                    _BreakNowButtonBt.Click += BreakNowButtonBt_Click;
                }
            }
        }

        private Label TimeLabelYD;
        private GroupBox ControlsGroupBoxBT;
        private ImageList IconsIL;
        private Label BreakTimeLabelBT;
        private Label BreakTimeSelectLabelBT;
        private GroupBox StatusGroupBoxBT;
        private Label lblsecondsbreak;
        private Label lblsecondbreak;
        private Label lblminuteandbreak;
        private Label lblminutesandbreak;
        private Label lblsec;
        private Label lblminute;
        private Label HourLabelBT;
        private Label HourAndBreakLabelBT;
        private Label lblhoursandbreak;
        private GroupBox StatusGroupBoxSH;
        private ContextMenuStrip ContextMenuStrip1;
        private ToolStripMenuItem _OpenToolStripMenuItem;

        internal ToolStripMenuItem OpenToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _OpenToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_OpenToolStripMenuItem != null)
                {
                    _OpenToolStripMenuItem.Click -= OpenToolStripMenuItem_Click;
                }

                _OpenToolStripMenuItem = value;
                if (_OpenToolStripMenuItem != null)
                {
                    _OpenToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _ChangeSettingsToolStripMenuItem;

        internal ToolStripMenuItem ChangeSettingsToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ChangeSettingsToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ChangeSettingsToolStripMenuItem != null)
                {
                    _ChangeSettingsToolStripMenuItem.Click -= ChangeSettingsToolStripMenuItem_Click;
                }

                _ChangeSettingsToolStripMenuItem = value;
                if (_ChangeSettingsToolStripMenuItem != null)
                {
                    _ChangeSettingsToolStripMenuItem.Click += ChangeSettingsToolStripMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _ExitToolStripMenuItem;

        internal ToolStripMenuItem ExitToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ExitToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ExitToolStripMenuItem != null)
                {
                    _ExitToolStripMenuItem.Click -= ExitToolStripMenuItem_Click;
                }

                _ExitToolStripMenuItem = value;
                if (_ExitToolStripMenuItem != null)
                {
                    _ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
                }
            }
        }

        private Timer TimeBomb;
        private GroupBox BSTGroupBoxBT;
        private Label BSTSecondsLabelBT;
        private Label BSTSecondLabelBT;
        private Label BSTMinAndLabelBT;
        private Label BSTMinsAndLabelBT;
        private Label BSTSecondIndicatorLabelBT;
        private Label BSTMinIndicatorLabelBT;
        private Label BSTHourIndicatorLabelBT;
        private Label BSTHourAndLabelBT;
        private Label BSTHoursAndLabelBT;
        private GroupBox TSFGroupBoxBT;
        private Label TSFSecondsLabelBT;
        private Label TSFSecondLabelBT;
        private Label TSFMinAndLabelBT;
        private Label TSFMinsAndLabelBT;
        private Label TSFSecondIndicatorLabelBT;
        private Label TSFMinIndicatorLabelBT;
        private Label TSFHourIndicatorLabelBT;
        private Label TSFHourAndLabelBT;
        private Label TSFHoursAndLabelBT;
        private Label TimeSelectIndicatorLabelBT;
        private Label TimeSelectLabelBT;
        private Label BreakTimeIndicatorALabelBT;
        private Label BreakTimeSelectALabelBT;
        private GroupBox TSFGroupBoxT;
        private Label lblsfsecondstime;
        private Label TSFSecondLabelT;
        private Label SFMinAndLabelT;
        private Label TSFMinsAndLabelT;
        private Label TSFSecondIndicatorLabelT;
        private Label TSFMinIndicatorLabelT;
        private Label TSFHourIndicatorLabelT;
        private Label lblsfhoursandtime;
        private Label TSFHoursAndLabelT;
        private GroupBox StatusGroupBoxT;
        private Label SecondsLabelT;
        private Label lblsecondtime;
        private Label lblminuteandtime;
        private Label lblminutesandtime;
        private Label lblsectime;
        private Label lblmintime;
        private Label lblhourtime;
        private Label lblhourandtime;
        private Label lblhoursandtime;
        private PictureBox PictureBox1;
        private NumericUpDown HourNudAC;
        private NumericUpDown MinNudAC;
        private NumericUpDown SecNudAC;
    }
}