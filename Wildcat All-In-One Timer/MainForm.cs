using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using UTimer.Org.Mentalis.Utilities;

namespace UTimer
{
    public partial class MainForm // 
    {
        public MainForm()
        {
            Tmras = new Timer() { Interval = 30 };
            Tmr = new Timer();
            InitializeComponent();
            _BreakNowButtonBt.Name = "BreakNowButtonBt";
            _StartButtonBT.Name = "StartButtonBT";
            _btnResume.Name = "btnResume";
            _btnStop.Name = "btnStop";
            _PauseButtonBT.Name = "PauseButtonBT";
            _nudTimeHour.Name = "nudTimeHour";
            _nudTimeMin.Name = "nudTimeMin";
            _nudTimeBreakSec.Name = "nudTimeBreakSec";
            _nudTimeSec.Name = "nudTimeSec";
            _nudTimeBreakMin.Name = "nudTimeBreakMin";
            _nudTimeBreakHour.Name = "nudTimeBreakHour";
            _B1HourNudBT.Name = "B1HourNudBT";
            _nudb1sec.Name = "nudb1sec";
            _nudb1min.Name = "nudb1min";
            _TimeRBBt.Name = "TimeRBBt";
            _BreakRBBt.Name = "BreakRBBt";
            _CancelAlarmButton.Name = "CancelAlarmButton";
            _SetAlarmButton.Name = "SetAlarmButton";
            _StartTimeButton.Name = "StartTimeButton";
            _StopTimeButton.Name = "StopTimeButton";
            _PauseButtonT.Name = "PauseButtonT";
            _ResumeTimeButton.Name = "ResumeTimeButton";
            _LapButtonSW.Name = "LapButtonSW";
            _PauseButtonSW.Name = "PauseButtonSW";
            _StartButtonSW.Name = "StartButtonSW";
            _StopButtonSW.Name = "StopButtonSW";
            _ResumeButtonSW.Name = "ResumeButtonSW";
            _ShutdownCbSh.Name = "ShutdownCbSh";
            _PauseButtonSh.Name = "PauseButtonSh";
            _StartButtonSh.Name = "StartButtonSh";
            _StopButtonSh.Name = "StopButtonSh";
            _ResumeButtonSh.Name = "ResumeButtonSh";
            _AtRadioButtonSh.Name = "AtRadioButtonSh";
            _InRadioButtonSh.Name = "InRadioButtonSh";
            _SettingsButton.Name = "SettingsButton";
            _OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            _ChangeSettingsToolStripMenuItem.Name = "ChangeSettingsToolStripMenuItem";
            _ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
        }

        private Timer _Tmras;

        private Timer Tmras
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Tmras;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Tmras != null)
                {
                    _Tmras.Tick -= Tmras_Tick;
                }

                _Tmras = value;
                if (_Tmras != null)
                {
                    _Tmras.Tick += Tmras_Tick;
                }
            }
        }

        private Size ShowSize;
        private double wstep, hstep;
        private double ww, hh;
        private readonly DateTime time;
        private readonly int CurrHour;
        private readonly int CurrMinute;
        private readonly bool PopHide = false;
        private bool Notify = false;
        public int sethours, setmins, setsecs;
        public int hour, min, sec;
        public int hours, min1, sec1;
        public int sethours1, setmins1, setsecs1;
        public int hoursh, minsh, secsh;
        public int sethoursh, setminsh, setsecsh;
        private readonly Stopwatch SW = new Stopwatch();
        private Timer _Tmr;

        private Timer Tmr
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Tmr;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Tmr != null)
                {
                    _Tmr.Tick -= Tmr_Tick;
                }

                _Tmr = value;
                if (_Tmr != null)
                {
                    _Tmr.Tick += Tmr_Tick;
                }
            }
        }

        private readonly object timeList = new List<int>();

        [DllImport("winmm.dll", CharSet = CharSet.Auto)]
        private static extern int PlaySound(string SoundName, int hModule, int dwFlags);

        private void PlayNow()
        {
            switch (My.MySettingsProperty.Settings.Sound2)
            {
                case 0:
                    {
                        string fileName = string.Concat(Application.StartupPath + @"\minwarn4.wav");
                        const int SND_FILENAME = 0x20000;
                        MainForm.PlaySound(fileName, 0, SND_FILENAME);
                        break;
                    }

                case 1 | 2 | 3:
                    {
                        string fileName = string.Concat(My.MySettingsProperty.Settings.Sound2Location);
                        const int SND_FILENAME = 0x20000;
                        MainForm.PlaySound(fileName, 0, SND_FILENAME);
                        break;
                    }
            }
        }

        private void Pausebutton_Click(object sender, EventArgs e)
        {
            BreakTimer.Stop();
            BreakTimer.Enabled = false;
            btnResume.Show();
            PauseButtonBT.Hide();
            btnStop.Show();
            BreakNowButtonBt.Hide();
        }

        private void RbSet_CheckedChanged(object sender, EventArgs e)
        {
            if (TimeRBBt.Checked == true)
            {
                BreakGBBt.Hide();
                TimerGBBt.Show();
                B1HourNudBT.Value = 0;
                nudb1min.Value = 0;
                nudb1sec.Value = 0;
            }
            else if (BreakRBBt.Checked == true)
            {
                BreakGBBt.Show();
                TimerGBBt.Hide();
                nudTimeBreakMin.Value = 0;
                nudTimeBreakHour.Value = 0;
                nudTimeBreakSec.Value = 0;
                nudTimeHour.Value = 0;
                nudTimeMin.Value = 0;
                nudTimeSec.Value = 0;
                MinWarnNudBt.Value = 1;
                AudioRbBt.Checked = false;
                VisualRbBt.Checked = false;
            }
        }

        private void RbBreak_CheckedChanged(object sender, EventArgs e)
        {
            if (TimeRBBt.Checked == true)
            {
                BreakGBBt.Hide();
                TimerGBBt.Show();
                B1HourNudBT.Value = 0;
                nudb1min.Value = 0;
                nudb1sec.Value = 0;
            }
            else if (BreakRBBt.Checked == true)
            {
                BreakGBBt.Show();
                TimerGBBt.Hide();
                nudTimeBreakMin.Value = 0;
                nudTimeBreakHour.Value = 0;
                nudTimeBreakSec.Value = 0;
                nudTimeHour.Value = 0;
                nudTimeMin.Value = 0;
                nudTimeSec.Value = 0;
                MinWarnNudBt.Value = 1;
                AudioRbBt.Checked = false;
                VisualRbBt.Checked = false;
            }
        }

        private void FrmLAG_Load(object sender, EventArgs e)
        {
            TitlePanel.BackColor = ColorTranslator.FromHtml(My.MySettingsProperty.Settings.BackColor.ToArgb().ToString());
            TitlePanel.ForeColor = ColorTranslator.FromHtml(My.MySettingsProperty.Settings.ForeColor.ToArgb().ToString());
            ShutdownTabPage.BackColor = ColorTranslator.FromHtml(My.MySettingsProperty.Settings.BackColor.ToArgb().ToString());
            ShutdownTabPage.ForeColor = ColorTranslator.FromHtml(My.MySettingsProperty.Settings.ForeColor.ToArgb().ToString());
            TimerTab.BackColor = ColorTranslator.FromHtml(My.MySettingsProperty.Settings.BackColor.ToArgb().ToString());
            TimerTab.ForeColor = ColorTranslator.FromHtml(My.MySettingsProperty.Settings.ForeColor.ToArgb().ToString());
            BreakTimerTab.BackColor = ColorTranslator.FromHtml(My.MySettingsProperty.Settings.BackColor.ToArgb().ToString());
            BreakTimerTab.ForeColor = ColorTranslator.FromHtml(My.MySettingsProperty.Settings.ForeColor.ToArgb().ToString());
            StopWatchTab.BackColor = ColorTranslator.FromHtml(My.MySettingsProperty.Settings.BackColor.ToArgb().ToString());
            StopWatchTab.ForeColor = ColorTranslator.FromHtml(My.MySettingsProperty.Settings.ForeColor.ToArgb().ToString());
            AlarmClockTab.BackColor = ColorTranslator.FromHtml(My.MySettingsProperty.Settings.BackColor.ToArgb().ToString());
            AlarmClockTab.ForeColor = ColorTranslator.FromHtml(My.MySettingsProperty.Settings.ForeColor.ToArgb().ToString());
            Opacity = 0.0; // Set to 0.0 so the form cant be seen
            ShowSize = Size; // Save the current size in a class scoped variable
            ForeColor = ColorTranslator.FromHtml(My.MySettingsProperty.Settings.ForeColor.ToArgb().ToString());
            BackColor = ColorTranslator.FromHtml(My.MySettingsProperty.Settings.BackColor.ToArgb().ToString());
            TimerControl.ForeColor = ColorTranslator.FromHtml(My.MySettingsProperty.Settings.ForeColor.ToArgb().ToString());
            TimerControl.BackColor = ColorTranslator.FromHtml(My.MySettingsProperty.Settings.BackColor.ToArgb().ToString());
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(ShutdownCbSh.SelectedItem, null, false)))
            {
                AtRadioButtonSh.Hide();
                InRadioButtonSh.Hide();
                InSettingsGBSH.Hide();
                AtSettingsGBSH.Hide();
            }
            else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(ShutdownCbSh.SelectedItem, null, false)))
            {
                AtRadioButtonSh.Show();
                InRadioButtonSh.Show();
                InSettingsGBSH.Show();
                AtSettingsGBSH.Show();
            }

            DateTimeTillShutdownLabelSh.Hide();
            InSettingsGBSH.Hide();
            AtSettingsGBSH.Hide();
            switch (My.MySettingsProperty.Settings.Startup)
            {
                case 0:
                    {
                        BreakTimerTab.Show();
                        break;
                    }

                case 1:
                    {
                        TimerTab.Show();
                        break;
                    }

                case 2:
                    {
                        AlarmClockTab.Show();
                        break;
                    }

                case 3:
                    {
                        StopWatchTab.Show();
                        break;
                    }

                case 4:
                    {
                        ShutdownTabPage.Show();
                        break;
                    }
            }

            ShutdownCbSh.SelectedIndex = Conversions.ToInteger(My.MySettingsProperty.Settings.AutoTimeSh);
            Tmr.Interval = 100;
            BreakGBBt.Hide();
            TimerGBBt.Hide();
            LapListBoxSw.Items.Clear();
            YDTimer.Start();
            nudTimeBreakHour.Value = Conversions.ToDecimal(My.MySettingsProperty.Settings.AutoTimeBTBHour);
            nudTimeBreakMin.Value = Conversions.ToDecimal(My.MySettingsProperty.Settings.AutoTimeBTBMin);
            nudTimeBreakSec.Value = Conversions.ToDecimal(My.MySettingsProperty.Settings.AutoTimeBTBSec);
            nudTimeHour.Value = Conversions.ToDecimal(My.MySettingsProperty.Settings.AutoTimeBTTHour);
            nudTimeMin.Value = Conversions.ToDecimal(My.MySettingsProperty.Settings.AutoTimeBTTMin);
            nudTimeSec.Value = Conversions.ToDecimal(My.MySettingsProperty.Settings.AutoTimeBTTSec);
            B1HourNudBT.Value = Conversions.ToDecimal(My.MySettingsProperty.Settings.AutoTimeBTB1Hour);
            nudb1min.Value = Conversions.ToDecimal(My.MySettingsProperty.Settings.AutoTimeBTB1Min);
            nudb1sec.Value = Conversions.ToDecimal(My.MySettingsProperty.Settings.AutoTimeBTB1Sec);
            MinWarnNudBt.Value = Conversions.ToDecimal(My.MySettingsProperty.Settings.MWAutoTime);
            if (My.MySettingsProperty.Settings.AudioOrVisual == true)
            {
                AudioRbBt.Checked = true;
                VisualRbBt.Checked = false;
            }
            else if (My.MySettingsProperty.Settings.AudioOrVisual == false)
            {
                AudioRbBt.Checked = false;
                VisualRbBt.Checked = true;
            }

            if (My.MySettingsProperty.Settings.SetTimeOrBreak == true)
            {
                TimeRBBt.Checked = true;
                BreakRBBt.Checked = false;
            }
            else if (My.MySettingsProperty.Settings.SetTimeOrBreak == false)
            {
                TimeRBBt.Checked = false;
                BreakRBBt.Checked = true;
            }

            nudHour.Value = Conversions.ToDecimal(My.MySettingsProperty.Settings.AutoTimeTTHour);
            nudMin.Value = Conversions.ToDecimal(My.MySettingsProperty.Settings.AutoTimeTTMin);
            nudSec.Value = Conversions.ToDecimal(My.MySettingsProperty.Settings.AutoTimeTTSec);
            HourNudSh.Value = Conversions.ToDecimal(My.MySettingsProperty.Settings.AutoTimeShHour);
            MinuteNudSh.Value = Conversions.ToDecimal(My.MySettingsProperty.Settings.AutoTimeShMin);
            SecondNudSh.Value = Conversions.ToDecimal(My.MySettingsProperty.Settings.AutoTimeShSec);
            ShutdownCbSh.SelectedIndex = Conversions.ToInteger(My.MySettingsProperty.Settings.AutoTimeSh);
            if (AudioRadioButtonSh.Checked == true && VisualRadioButtonSh.Checked == false)
            {
                My.MySettingsProperty.Settings.AudOrVis = true;
            }
            else if (AudioRadioButtonSh.Checked == false && VisualRadioButtonSh.Checked == true)
            {
                My.MySettingsProperty.Settings.AudOrVis = false;
            }

            lblwelcome.Text = "welcome, " + SystemInformation.UserName;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            BreakTimerTab.Enabled = false;
            TimerTab.Enabled = false;
            AlarmClockTab.Enabled = false;
            ShutdownTabPage.Enabled = false;
            SW.Start();
            Tmr.Start();
            PauseButtonSW.Show();
            StartButtonSW.Hide();
            StopButtonSW.Show();
            ResumeButtonSW.Hide();
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            StopwatchLabelSW.Text = SW.Elapsed.ToString();
        }

        private void LapButton_Click(object sender, EventArgs e)
        {
            LapListBoxSw.Items.Add(SW.ElapsedMilliseconds);
            LapListBoxSw.Show();
            var tim = new TimeSpan(SW.ElapsedMilliseconds);
            LapListBoxSw.Items.Add(tim.ToString("T"));
        }

        private void PauseButton_Click_1(object sender, EventArgs e)
        {
            SW.Stop();
            Tmr.Stop();
            ResumeButtonSW.Show();
            PauseButtonSW.Hide();
            StopButtonSW.Hide();
            StartButtonSW.Hide();
        }

        private void BtnResume_Click(object sender, EventArgs e)
        {
            BreakTimer.Start();
            PauseButtonBT.Show();
            btnResume.Hide();
            btnStop.Show();
            StartButtonBT.Hide();
            BreakNowButtonBt.Show();
        }

        private void StopTimeButton_Click(object sender, EventArgs e)
        {
            TimerTimer.Stop();
            PauseButtonT.Hide();
            ResumeTimeButton.Hide();
            StopTimeButton.Hide();
            StartTimeButton.Show();
            sec1 = 0;
            min1 = 0;
            hours = 0;
            nudHour.Show();
            nudMin.Show();
            nudSec.Show();
            BreakTimerTab.Enabled = true;
            StopWatchTab.Enabled = true;
            ShutdownTabPage.Enabled = true;
            AlarmClockTab.Enabled = true;
            StopWatchTab.Enabled = true;
            ShutdownTabPage.Enabled = true;
        }

        private void CancelAlarmButton_Click(object sender, EventArgs e)
        {
            AlarmTimer.Enabled = false;
            SetOrNotSetLabel.Text = "Not Set";
            HourNudAC.Enabled = true;
            MinNudAC.Enabled = true;
            SecNudAC.Enabled = true;
            SetAlarmButton.Enabled = true;
            SetAlarmButton.Show();
            CancelAlarmButton.Enabled = false;
            CancelAlarmButton.Hide();
            AlarmClockTab.Enabled = true;
            StopWatchTab.Enabled = true;
            ShutdownTabPage.Enabled = true;
        }

        private void StartAlarmButton_Click(object sender, EventArgs e)
        {
            TimerTab.Enabled = false;
            StopWatchTab.Enabled = false;
            ShutdownTabPage.Enabled = false;
            AlarmTimer.Enabled = true;
            SetOrNotSetLabel.Text = "Set";
            HourNudAC.Enabled = false;
            MinNudAC.Enabled = false;
            SecNudAC.Enabled = false;
            SetAlarmButton.Enabled = false;
            SetAlarmButton.Hide();
            CancelAlarmButton.Enabled = true;
            CancelAlarmButton.Show();
        }

        private void AlarmTimer_Tick(object sender, EventArgs e)
        {
            if (DateAndTime.Now.Hour == HourNudAC.Value && DateAndTime.Now.Minute == MinNudAC.Value && DateAndTime.Now.Second == SecNudAC.Value)
            {
                AlarmTimer.Enabled = false;
                tBeep.Enabled = true;
                if ((int)Interaction.MsgBox("It is " + DateAndTime.Now.ToShortTimeString() + ".", MsgBoxStyle.Information, "Alarm") == (int)DialogResult.OK)
                {
                    tBeep.Enabled = false;
                    HourNudAC.Enabled = true;
                    MinNudAC.Enabled = true;
                    SecNudAC.Enabled = true;
                    SetAlarmButton.Enabled = true;
                    SetAlarmButton.Show();
                    CancelAlarmButton.Enabled = false;
                    CancelAlarmButton.Hide();
                    SetOrNotSetLabel.Text = "Not Set";
                    ShutdownTabPage.Enabled = true;
                    StopWatchTab.Enabled = true;
                    TimerTab.Enabled = true;
                }
            }
            else
            {
            }
        }

        private void PauseTimeButton_Click(object sender, EventArgs e)
        {
            TimerTimer.Stop();
            PauseButtonT.Hide();
            ResumeTimeButton.Show();
            StopTimeButton.Hide();
            StartTimeButton.Hide();
        }

        private void TBeep_Tick(object sender, EventArgs e)
        {
            My.MyProject.Computer.Audio.Play(Application.StartupPath + @"\timesup4.wav");
            System.Threading.Thread.Sleep(3000);
        }

        private void ShowWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Show();
            }
            else if (WindowState == FormWindowState.Normal)
            {
                Hide();
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            AlarmClockTab.Enabled = false;
            StopWatchTab.Enabled = false;
            ShutdownTabPage.Enabled = false;
            sethours1 = Conversions.ToInteger(nudHour.Value);
            hours = sethours1;
            setmins1 = Conversions.ToInteger(nudMin.Value);
            min1 = setmins1;
            setsecs1 = Conversions.ToInteger(nudSec.Value);
            sec1 = setsecs1;
            TimerTimer.Enabled = true;
            PauseButtonT.Show();
            ResumeTimeButton.Hide();
            StopTimeButton.Show();
            StartTimeButton.Hide();
            nudSec.Hide();
            nudMin.Hide();
            nudHour.Hide();
        }

        private void StartButtonSh_Click(object sender, EventArgs e)
        {
            if (HourNudSh.Value == 0 && MinuteNudSh.Value == 0 && SecondNudSh.Value == 0 && HourAtNudSh.Value == 0 && MinuteAtNudSh.Value == 0)
            {
                return;
            }
            else
            {
            }

            if (string.Compare(DateAndTime.Now.ToString("HH"), HourAtNudSh.Value.ToString()) > 0)
            {
                if (string.Compare(DateAndTime.Now.ToString("mm"), HourAtNudSh.Value.ToString()) > 0)
                {
                    MessageBox.Show("The time right now is past the time you have selected.", "Past Time", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ShutdownTimer.Stop();
                    return;
                }
            }

            TimerTab.Enabled = false;
            StopWatchTab.Enabled = false;
            AlarmClockTab.Enabled = false;
            BreakTimerTab.Enabled = false;
            InSettingsGBSH.Hide();
            AtSettingsGBSH.Hide();
            InRadioButtonSh.Hide();
            AtRadioButtonSh.Hide();
            ShutdownCbSh.Hide();
            WindowState = FormWindowState.Minimized;
            ShutdownTimer.Enabled = true;
            ShutdownTimer.Start();
            sethoursh = Conversions.ToInteger(HourNudSh.Value);
            setminsh = Conversions.ToInteger(MinuteNudSh.Value);
            setsecsh = Conversions.ToInteger(SecondNudSh.Value);
            hoursh = sethoursh;
            minsh = setminsh;
            secsh = setsecsh;
            StartButtonSh.Hide();
            PauseButtonSh.Show();
            ResumeButtonSh.Hide();
            StopButtonSh.Show();
            Notify = false;
        }

        private void PauseButtonSh_Click(object sender, EventArgs e)
        {
            ShutdownTimer.Stop();
            PauseButtonSW.Hide();
            StopButtonSh.Show();
            ResumeButtonSh.Show();
            StartButtonSW.Hide();
        }

        private string FormatTo2Digits(int Val)
        {
            string newVal;
            int len = Val.ToString().Length;
            if (len == 1)
            {
                newVal = "0" + Val.ToString();
                return newVal;
            }
            else
            {
                return Val.ToString();
            }
        }

        private void ShutdownAt()
        {
            DateTimeTillShutdownLabelSh.Show();
            DateTimeTillShutdownLabelSh.Text = FormatTo2Digits(Conversions.ToInteger(HourAtNudSh.Value)) + ":" + FormatTo2Digits(Conversions.ToInteger(MinuteAtNudSh.Value)) + ":" + FormatTo2Digits(0);
            // special case of set min = 0 and one less is 59
            int warningTime;
            if (MinuteAtNudSh.Value == 0)
            {
                warningTime = 59;
            }
            else
            {
                warningTime = (int)(MinuteAtNudSh.Value - 1);
            }

            if (string.Compare(DateAndTime.Now.Hour.ToString(), HourAtNudSh.Value.ToString()) == 0)
            {
                if (string.Compare(DateAndTime.Now.Minute.ToString(), warningTime.ToString()) == 0)
                {
                    if (Notify == false)
                    {
                        int remain = 60 - DateAndTime.Now.Second;
                        if (PopHide == false)
                        {
                            ShutdownTimer.Stop();
                            if (MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(ShutdownCbSh.SelectedItem, " in "), remain), " seconds. Do you want to "), ShutdownCbSh.SelectedItem), " now?")), "Minwarn", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                            {
                                Show();
                                ShutdownTimer.Stop();
                                switch (ShutdownCbSh.SelectedIndex)
                                {
                                    case 0:
                                        {
                                            Close();
                                            WindowsController.ExitWindows(RestartOptions.LogOff, true);
                                            break;
                                        }

                                    case 1:
                                        {
                                            Close();
                                            WindowsController.ExitWindows(RestartOptions.PowerOff, true);
                                            break;
                                        }

                                    case 2:
                                        {
                                            Close();
                                            WindowsController.ExitWindows(RestartOptions.Reboot, true);
                                            break;
                                        }

                                    case 3:
                                        {
                                            Close();
                                            WindowsController.ExitWindows(RestartOptions.ShutDown, true);
                                            break;
                                        }

                                    case 4:
                                        {
                                            Close();
                                            WindowsController.ExitWindows(RestartOptions.Suspend, true);
                                            break;
                                        }

                                    case 5:
                                        {
                                            Close();
                                            WindowsController.ExitWindows(RestartOptions.Hibernate, true);
                                            break;
                                        }
                                }
                            }
                            else if (Conversions.ToBoolean(DialogResult.No))
                            {
                                ShutdownTimer.Start();
                            }

                            if (Notify == false)
                            {
                                PlayNow();
                                Notify = true;
                            }
                        }
                    }
                }
            }

            if (string.Compare(DateAndTime.Now.Hour.ToString(), HourAtNudSh.Value.ToString()) == 0)
            {
                if (string.Compare(DateAndTime.Now.Minute.ToString(), MinuteAtNudSh.Value.ToString()) == 0)
                {
                    Show();
                    ShutdownTimer.Stop();
                    switch (ShutdownCbSh.SelectedIndex)
                    {
                        case 0:
                            {
                                Close();
                                WindowsController.ExitWindows(RestartOptions.LogOff, true);
                                break;
                            }

                        case 1:
                            {
                                Close();
                                WindowsController.ExitWindows(RestartOptions.PowerOff, true);
                                break;
                            }

                        case 2:
                            {
                                Close();
                                WindowsController.ExitWindows(RestartOptions.Reboot, true);
                                break;
                            }

                        case 3:
                            {
                                Close();
                                WindowsController.ExitWindows(RestartOptions.ShutDown, true);
                                break;
                            }

                        case 4:
                            {
                                Close();
                                WindowsController.ExitWindows(RestartOptions.Suspend, true);
                                break;
                            }

                        case 5:
                            {
                                Close();
                                WindowsController.ExitWindows(RestartOptions.Hibernate, true);
                                break;
                            }
                    }
                }
            }
        }

        private void YDTimer_Tick(object sender, EventArgs e)
        {
            switch (My.MySettingsProperty.Settings.TimeFormat)
            {
                case 0:
                    {
                        DateTime hourtime = Conversions.ToDate(DateAndTime.Now.ToString("HH:mm:ss tt", CultureInfo.InvariantCulture));
                        TimeLabelYD.Text = "the time is " + hourtime;
                        break;
                    }

                case 1:
                    {
                        TimeLabelYD.Text = "the time is " + DateAndTime.Now.ToString("HH:mm:ss");
                        break;
                    }

                case 2:
                    {
                        TimeLabelYD.Text = "the time is " + DateAndTime.Now.ToShortTimeString();
                        break;
                    }

                case 3:
                    {
                        TimeLabelYD.Text = "the time is " + DateAndTime.Now.ToString("HH:mm");
                        break;
                    }
            }

            switch (My.MySettingsProperty.Settings.DateFormat)
            {
                case 0:
                    {
                        DateLabelYD.Text = "the date is " + DateAndTime.Now.ToString("yyMMdd");
                        break;
                    }

                case 1:
                    {
                        DateLabelYD.Text = "the date is " + DateAndTime.Now.ToString("yyyyMMdd");
                        break;
                    }

                case 2:
                    {
                        var myCulture = CultureInfo.CurrentCulture;
                        var dayOfWeek = myCulture.Calendar.GetDayOfWeek(DateTime.Today);
                        string dayName = myCulture.DateTimeFormat.GetDayName(dayOfWeek);
                        var datetime = DateTime.Now;
                        DateLabelYD.Text = "the date is " + dayName + " " + DateAndTime.MonthName(DateAndTime.Now.Month, false) + " " + DateAndTime.Now.Day + " " + DateAndTime.Now.Year;
                        break;
                    }

                case 3:
                    {
                        DateLabelYD.Text = "the date is " + DateAndTime.MonthName(DateAndTime.Now.Month, false) + " " + DateAndTime.Now.Day + " " + DateAndTime.Now.Year;
                        break;
                    }

                case 4:
                    {
                        var dt = new DateTimeFormatInfo();
                        DateLabelYD.Text = "the date is " + dt.GetAbbreviatedMonthName(DateAndTime.Now.Month) + " " + DateAndTime.Now.Day + " " + DateAndTime.Now.ToString("yy");
                        break;
                    }

                case 5:
                    {
                        var dt = new DateTimeFormatInfo();
                        DateLabelYD.Text = "the date is " + dt.GetAbbreviatedMonthName(DateAndTime.Now.Month) + " " + DateAndTime.Now.Day + " " + DateAndTime.Now.Year;
                        break;
                    }

                case 6:
                    {
                        DateLabelYD.Text = "the date is " + DateAndTime.Now.ToString("MM/dd/yy");
                        break;
                    }

                case 7:
                    {
                        DateLabelYD.Text = "the date is " + DateAndTime.Now.ToString("dd/MM/yy");
                        break;
                    }
            }
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.SettingsForm.Show();
            Close();
        }

        private void BreakNowButtonBt_Click(object sender, EventArgs e)
        {
            if (Notify == true)
            {
                MessageBox.Show("You cannot start a break with less than " + MinWarnNudBt.Value + " minutes left.", "Error 1244", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Notify == false)
            {
                BreakTimer.Stop();
                My.MyProject.Forms.BreakForm.sethours = Conversions.ToInteger(nudTimeBreakHour.Value);
                My.MyProject.Forms.BreakForm.hours = My.MyProject.Forms.BreakForm.sethours;
                My.MyProject.Forms.BreakForm.setminutes = Conversions.ToInteger(nudTimeBreakMin.Value);
                My.MyProject.Forms.BreakForm.minutes = My.MyProject.Forms.BreakForm.setminutes;
                My.MyProject.Forms.BreakForm.setsecs = Conversions.ToInteger(nudTimeBreakSec.Value);
                My.MyProject.Forms.BreakForm.seconds = My.MyProject.Forms.BreakForm.setsecs;
                My.MyProject.Forms.BreakForm.Show();
                Hide();
            }
        }

        private void AtRadioButtonSh_CheckedChanged(object sender, EventArgs e)
        {
            if (AtRadioButtonSh.Checked == true)
            {
                AtSettingsGBSH.Show();
                InSettingsGBSH.Hide();
            }
            else if (InRadioButtonSh.Checked == true)
            {
                AtSettingsGBSH.Hide();
                InSettingsGBSH.Show();
            }
        }

        private void InRadioButtonSh_CheckedChanged(object sender, EventArgs e)
        {
            if (AtRadioButtonSh.Checked == true)
            {
                AtSettingsGBSH.Show();
                InSettingsGBSH.Hide();
            }
            else if (InRadioButtonSh.Checked == true)
            {
                AtSettingsGBSH.Hide();
                InSettingsGBSH.Show();
            }
        }

        private void ShutdownCbSh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(ShutdownCbSh.SelectedItem, null, false)))
            {
                AtRadioButtonSh.Hide();
                InRadioButtonSh.Hide();
            }
            else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(ShutdownCbSh.SelectedItem, null, false)))
            {
                AtRadioButtonSh.Show();
                InRadioButtonSh.Show();
            }
        }

        private void Nudb1hour_ValueChanged(object sender, EventArgs e)
        {
            BreakTimeLabelBT.Text = B1HourNudBT.Value.ToString("0#") + ":" + nudb1min.Value.ToString("0#") + ":" + nudb1sec.Value.ToString("0#");
        }

        private void Nudb1min_ValueChanged(object sender, EventArgs e)
        {
            BreakTimeLabelBT.Text = B1HourNudBT.Value.ToString("0#") + ":" + nudb1min.Value.ToString("0#") + ":" + nudb1sec.Value.ToString("0#");
        }

        private void Nudb1sec_ValueChanged(object sender, EventArgs e)
        {
            BreakTimeLabelBT.Text = B1HourNudBT.Value.ToString("0#") + ":" + nudb1min.Value.ToString("0#") + ":" + nudb1sec.Value.ToString("0#");
        }

        private void NudTimeMin_ValueChanged(object sender, EventArgs e)
        {
            TimeSelectIndicatorLabelBT.Text = nudTimeHour.Value.ToString("0#") + ":" + nudTimeMin.Value.ToString("0#") + ":" + nudTimeSec.Value.ToString("0#");
        }

        private void NudTimeSec_ValueChanged(object sender, EventArgs e)
        {
            TimeSelectIndicatorLabelBT.Text = nudTimeHour.Value.ToString("0#") + ":" + nudTimeMin.Value.ToString("0#") + ":" + nudTimeSec.Value.ToString("0#");
        }

        private void NudTimeBreakHour_ValueChanged(object sender, EventArgs e)
        {
            BreakTimeIndicatorALabelBT.Text = nudTimeBreakHour.Value.ToString("0#") + ":" + nudTimeBreakMin.Value.ToString("0#") + ":" + nudTimeBreakSec.Value.ToString("0#");
        }

        private void NudTimeBreakMin_ValueChanged(object sender, EventArgs e)
        {
            BreakTimeIndicatorALabelBT.Text = nudTimeBreakHour.Value.ToString("0#") + ":" + nudTimeBreakMin.Value.ToString("0#") + ":" + nudTimeBreakSec.Value.ToString("0#");
        }

        private void NudTimeBreakSec_ValueChanged(object sender, EventArgs e)
        {
            BreakTimeIndicatorALabelBT.Text = nudTimeBreakHour.Value.ToString("0#") + ":" + nudTimeBreakMin.Value.ToString("0#") + ":" + nudTimeBreakSec.Value.ToString("0#");
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void ChangeSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.SettingsForm.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NudTimeHour_ValueChanged(object sender, EventArgs e)
        {
            TimeSelectIndicatorLabelBT.Text = nudTimeHour.Value.ToString("0#") + ":" + nudTimeMin.Value.ToString("0#") + ":" + nudTimeSec.Value.ToString("0#");
        }

        private void ShutdownTimer_Tick(object sender, EventArgs e)
        {
            if (InRadioButtonSh.Checked == true)
            {
                ShutdownIn();
            }
            else if (AtRadioButtonSh.Checked == true)
            {
                ShutdownAt();
            }
            else
            {
                Interaction.MsgBox("You must select either to shutdown at a specified time or in a number of minutes in order to start your time.", MsgBoxStyle.Critical, "Selection Error");
                return;
            }
        }

        private void ShutdownIn()
        {
            if (secsh > 0)
            {
                secsh -= 1;
                SecondsIndicatorLabelSh.Show();
                SecondsLabelSh.Show();
                SecondLabelSh.Hide();
            }
            else if (minsh > 0)
            {
                secsh = 59;
                minsh -= 1;
                MinuteIndicatorLabelSh.Show();
                MinutesAndLabelSh.Show();
                MinuteAndLabelSh.Hide();
            }
            else if (hoursh > 0)
            {
                secsh = 59;
                minsh = 59;
                hoursh -= 1;
                HourIndicatorLabelSh.Show();
                HoursAndLabelSh.Show();
                HourAndLabelSh.Hide();
            }
            else
            {
                Show();
                ShutdownTimer.Stop();
                switch (ShutdownCbSh.SelectedIndex)
                {
                    case 0:
                        {
                            Close();
                            WindowsController.ExitWindows(RestartOptions.LogOff, true);
                            break;
                        }

                    case 1:
                        {
                            Close();
                            WindowsController.ExitWindows(RestartOptions.PowerOff, true);
                            break;
                        }

                    case 2:
                        {
                            Close();
                            WindowsController.ExitWindows(RestartOptions.Reboot, true);
                            break;
                        }

                    case 3:
                        {
                            Close();
                            WindowsController.ExitWindows(RestartOptions.ShutDown, true);
                            break;
                        }

                    case 4:
                        {
                            Close();
                            WindowsController.ExitWindows(RestartOptions.Suspend, true);
                            break;
                        }

                    case 5:
                        {
                            Close();
                            WindowsController.ExitWindows(RestartOptions.Hibernate, true);
                            break;
                        }
                }
            }

            switch (MinWarnNudBt.Value)
            {
                case 1:
                    {
                        if (hoursh == 0 && minsh == 0 && secsh < 60)
                        {
                            int remain = secsh;
                            if (Notify == false)
                            {
                                WindowState = FormWindowState.Normal;
                                if (AudioRadioButtonSh.Checked == true && VisualRadioButtonSh.Checked == false)
                                {
                                    PlayNow();
                                }
                                else if (AudioRadioButtonSh.Checked == false && VisualRadioButtonSh.Checked == true)
                                {
                                    PlayNow();
                                    BreakTimer.Stop();
                                    string mes = ((int)MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(ShutdownCbSh.SelectedItem, " will start in "), remain), " seconds. Click OK to start breaktime now. Otherwise, click Cancel to continue the timer.")), "MinWarn Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)).ToString();
                                    if (Conversions.ToDouble(mes) == (double)DialogResult.OK)
                                    {
                                        Show();
                                        ShutdownTimer.Stop();
                                        switch (ShutdownCbSh.SelectedIndex)
                                        {
                                            case 0:
                                                {
                                                    Close();
                                                    WindowsController.ExitWindows(RestartOptions.LogOff, true);
                                                    break;
                                                }

                                            case 1:
                                                {
                                                    Close();
                                                    WindowsController.ExitWindows(RestartOptions.PowerOff, true);
                                                    break;
                                                }

                                            case 2:
                                                {
                                                    Close();
                                                    WindowsController.ExitWindows(RestartOptions.Reboot, true);
                                                    break;
                                                }

                                            case 3:
                                                {
                                                    Close();
                                                    WindowsController.ExitWindows(RestartOptions.ShutDown, true);
                                                    break;
                                                }

                                            case 4:
                                                {
                                                    Close();
                                                    WindowsController.ExitWindows(RestartOptions.Suspend, true);
                                                    break;
                                                }

                                            case 5:
                                                {
                                                    Close();
                                                    WindowsController.ExitWindows(RestartOptions.Hibernate, true);
                                                    break;
                                                }
                                        }
                                    }
                                    else if (Conversions.ToDouble(mes) == (double)DialogResult.Cancel)
                                    {
                                        ShutdownTimer.Start();
                                        Notify = true;
                                    }
                                }

                                Notify = true;
                            }
                        }

                        break;
                    }

                case 2:
                    {
                        if (hoursh == 0 && minsh == 1 && secsh < 60)
                        {
                            int remain = secsh;
                            if (Notify == false)
                            {
                                WindowState = FormWindowState.Normal;
                                if (AudioRadioButtonSh.Checked == true && VisualRadioButtonSh.Checked == false)
                                {
                                    PlayNow();
                                }
                                else if (AudioRadioButtonSh.Checked == false && VisualRadioButtonSh.Checked == true)
                                {
                                    PlayNow();
                                    BreakTimer.Stop();
                                    string mes = ((int)MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(ShutdownCbSh.SelectedItem, " will start in "), minsh), " minutes and "), remain), " seconds. Click OK to start breaktime now. Otherwise, click Cancel to continue the timer.")), "MinWarn Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)).ToString();
                                    if (Conversions.ToDouble(mes) == (double)DialogResult.OK)
                                    {
                                        Show();
                                        ShutdownTimer.Stop();
                                        switch (ShutdownCbSh.SelectedIndex)
                                        {
                                            case 0:
                                                {
                                                    Close();
                                                    WindowsController.ExitWindows(RestartOptions.LogOff, true);
                                                    break;
                                                }

                                            case 1:
                                                {
                                                    Close();
                                                    WindowsController.ExitWindows(RestartOptions.PowerOff, true);
                                                    break;
                                                }

                                            case 2:
                                                {
                                                    Close();
                                                    WindowsController.ExitWindows(RestartOptions.Reboot, true);
                                                    break;
                                                }

                                            case 3:
                                                {
                                                    Close();
                                                    WindowsController.ExitWindows(RestartOptions.ShutDown, true);
                                                    break;
                                                }

                                            case 4:
                                                {
                                                    Close();
                                                    WindowsController.ExitWindows(RestartOptions.Suspend, true);
                                                    break;
                                                }

                                            case 5:
                                                {
                                                    Close();
                                                    WindowsController.ExitWindows(RestartOptions.Hibernate, true);
                                                    break;
                                                }
                                        }
                                    }
                                    else if (Conversions.ToDouble(mes) == (double)DialogResult.Cancel)
                                    {
                                        ShutdownTimer.Start();
                                        Notify = true;
                                    }
                                }
                            }
                        }

                        break;
                    }

                case 3:
                    {
                        if (hoursh == 0 && minsh == 2 && secsh < 60)
                        {
                            int remain = secsh;
                            if (Notify == false)
                            {
                                WindowState = FormWindowState.Normal;
                                if (AudioRadioButtonSh.Checked == true && VisualRadioButtonSh.Checked == false)
                                {
                                    PlayNow();
                                }
                                else if (AudioRadioButtonSh.Checked == false && VisualRadioButtonSh.Checked == true)
                                {
                                    PlayNow();
                                    ShutdownTimer.Stop();
                                    string mes = ((int)MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(ShutdownCbSh.SelectedItem, " will start in "), minsh), " minutes and "), remain), " seconds. Click OK to start breaktime now. Otherwise, click Cancel to continue the timer.")), "MinWarn Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)).ToString();
                                    if (Conversions.ToDouble(mes) == (double)DialogResult.OK)
                                    {
                                        Show();
                                        ShutdownTimer.Stop();
                                        switch (ShutdownCbSh.SelectedIndex)
                                        {
                                            case 0:
                                                {
                                                    Close();
                                                    WindowsController.ExitWindows(RestartOptions.LogOff, true);
                                                    break;
                                                }

                                            case 1:
                                                {
                                                    Close();
                                                    WindowsController.ExitWindows(RestartOptions.PowerOff, true);
                                                    break;
                                                }

                                            case 2:
                                                {
                                                    Close();
                                                    WindowsController.ExitWindows(RestartOptions.Reboot, true);
                                                    break;
                                                }

                                            case 3:
                                                {
                                                    Close();
                                                    WindowsController.ExitWindows(RestartOptions.ShutDown, true);
                                                    break;
                                                }

                                            case 4:
                                                {
                                                    Close();
                                                    WindowsController.ExitWindows(RestartOptions.Suspend, true);
                                                    break;
                                                }

                                            case 5:
                                                {
                                                    Close();
                                                    WindowsController.ExitWindows(RestartOptions.Hibernate, true);
                                                    break;
                                                }
                                        }
                                    }
                                    else if (Conversions.ToDouble(mes) == (double)DialogResult.Cancel)
                                    {
                                        ShutdownTimer.Start();
                                        Notify = true;
                                    }
                                }
                            }
                        }

                        break;
                    }

                case 4:
                    {
                        if (hoursh == 0 && minsh == 3 && secsh < 60)
                        {
                            int remain = secsh;
                            if (Notify == false)
                            {
                                WindowState = FormWindowState.Normal;
                                if (AudioRadioButtonSh.Checked == true && VisualRadioButtonSh.Checked == false)
                                {
                                    PlayNow();
                                }
                                else if (AudioRadioButtonSh.Checked == false && VisualRadioButtonSh.Checked == true)
                                {
                                    PlayNow();
                                    ShutdownTimer.Stop();
                                    string mes = ((int)MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(ShutdownCbSh.SelectedItem, " will start in "), minsh), " minutes and "), remain), " seconds. Click OK to start breaktime now. Otherwise, click Cancel to continue the timer.")), "MinWarn Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)).ToString();
                                    if (Conversions.ToDouble(mes) == (double)DialogResult.OK)
                                    {
                                        Show();
                                        ShutdownTimer.Stop();
                                        switch (ShutdownCbSh.SelectedIndex)
                                        {
                                            case 0:
                                                {
                                                    Close();
                                                    WindowsController.ExitWindows(RestartOptions.LogOff, true);
                                                    break;
                                                }

                                            case 1:
                                                {
                                                    Close();
                                                    WindowsController.ExitWindows(RestartOptions.PowerOff, true);
                                                    break;
                                                }

                                            case 2:
                                                {
                                                    Close();
                                                    WindowsController.ExitWindows(RestartOptions.Reboot, true);
                                                    break;
                                                }

                                            case 3:
                                                {
                                                    Close();
                                                    WindowsController.ExitWindows(RestartOptions.ShutDown, true);
                                                    break;
                                                }

                                            case 4:
                                                {
                                                    Close();
                                                    WindowsController.ExitWindows(RestartOptions.Suspend, true);
                                                    break;
                                                }

                                            case 5:
                                                {
                                                    Close();
                                                    WindowsController.ExitWindows(RestartOptions.Hibernate, true);
                                                    break;
                                                }
                                        }
                                    }
                                    else if (Conversions.ToDouble(mes) == (double)DialogResult.Cancel)
                                    {
                                        ShutdownTimer.Start();
                                        Notify = true;
                                    }
                                }
                            }
                        }

                        break;
                    }

                case 5:
                    {
                        if (hoursh == 0 && minsh == 4 && secsh < 60)
                        {
                            int remain = secsh;
                            if (Notify == false)
                            {
                                WindowState = FormWindowState.Normal;
                                if (AudioRadioButtonSh.Checked == true && VisualRadioButtonSh.Checked == false)
                                {
                                    PlayNow();
                                }
                                else if (AudioRadioButtonSh.Checked == false && VisualRadioButtonSh.Checked == true)
                                {
                                    PlayNow();
                                    BreakTimer.Stop();
                                    string mes = ((int)MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(ShutdownCbSh.SelectedItem, " will start in "), minsh), " minutes and "), remain), " seconds. Click OK to start breaktime now. Otherwise, click Cancel to continue the timer.")), "MinWarn Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)).ToString();
                                    if (Conversions.ToDouble(mes) == (double)DialogResult.OK)
                                    {
                                        Show();
                                        ShutdownTimer.Stop();
                                        switch (ShutdownCbSh.SelectedIndex)
                                        {
                                            case 0:
                                                {
                                                    Close();
                                                    WindowsController.ExitWindows(RestartOptions.LogOff, true);
                                                    break;
                                                }

                                            case 1:
                                                {
                                                    Close();
                                                    WindowsController.ExitWindows(RestartOptions.PowerOff, true);
                                                    break;
                                                }

                                            case 2:
                                                {
                                                    Close();
                                                    WindowsController.ExitWindows(RestartOptions.Reboot, true);
                                                    break;
                                                }

                                            case 3:
                                                {
                                                    Close();
                                                    WindowsController.ExitWindows(RestartOptions.ShutDown, true);
                                                    break;
                                                }

                                            case 4:
                                                {
                                                    Close();
                                                    WindowsController.ExitWindows(RestartOptions.Suspend, true);
                                                    break;
                                                }

                                            case 5:
                                                {
                                                    Close();
                                                    WindowsController.ExitWindows(RestartOptions.Hibernate, true);
                                                    break;
                                                }
                                        }
                                    }
                                    else if (Conversions.ToDouble(mes) == (double)DialogResult.Cancel)
                                    {
                                        ShutdownTimer.Start();
                                        Notify = true;
                                    }
                                }
                            }
                        }

                        break;
                    }
            }

            SecondsIndicatorLabelSh.Text = Strings.Format(secsh, "0#");
            HourIndicatorLabelSh.Text = Strings.Format(hoursh, "0#");
            MinuteIndicatorLabelSh.Text = Strings.Format(minsh, "0#");
            if (hoursh == 1)
            {
                HoursAndLabelSh.Hide();
                HourAndLabelSh.Show();
            }

            if (minsh == 1)
            {
                MinutesAndLabelSh.Hide();
                MinuteAndLabelSh.Show();
            }

            if (secsh == 1)
            {
                SecondsLabelSh.Hide();
                SecondLabelSh.Show();
            }

            if (hoursh == 0)
            {
                HourIndicatorLabelSh.Hide();
                HoursAndLabelSh.Hide();
                HourAndLabelSh.Hide();
            }

            if (minsh == 0)
            {
                MinuteIndicatorLabelSh.Hide();
                MinutesAndLabelSh.Hide();
                MinuteAndLabelSh.Hide();
            }
        }

        private void TimerTimer_Tick(object sender, EventArgs e)
        {
            if (sec1 > 0)
            {
                sec1 -= 1;
                lblsectime.Show();
                lblsectime.Show();
                lblsecondtime.Hide();
            }
            else if (min1 > 0)
            {
                sec1 = 59;
                min1 -= 1;
                lblmintime.Show();
                lblminutesandtime.Show();
                lblminuteandtime.Hide();
            }
            else if (hours > 0)
            {
                sec1 = 59;
                min1 = 59;
                hours -= 1;
                lblhourtime.Show();
                lblhoursandtime.Show();
                lblhourandtime.Hide();
            }
            else
            {
                TimerTimer.Enabled = false;
                tBeep.Enabled = true;
                if ((int)Interaction.MsgBox("Times up!", MsgBoxStyle.Information, "Time is up") == (int)DialogResult.OK)
                {
                    tBeep.Stop();
                    PauseButtonT.Hide();
                    ResumeTimeButton.Hide();
                    StopTimeButton.Hide();
                    StartTimeButton.Show();
                    sec1 = 0;
                    min1 = 0;
                    hours = 0;
                    nudHour.Show();
                    nudMin.Show();
                    nudSec.Show();
                    StopWatchTab.Enabled = true;
                    BreakTimerTab.Enabled = true;
                    ShutdownTabPage.Enabled = true;
                    AlarmClockTab.Enabled = true;
                }
            }

            lblhourtime.Text = Strings.Format(hours, "0#");
            lblmintime.Text = Strings.Format(min1, "0#");
            lblsectime.Text = Strings.Format(sec1, "0#");
            if (hours == 1)
            {
                lblhoursandtime.Hide();
                lblhourandtime.Show();
            }

            if (min1 == 1)
            {
                lblminutesandtime.Hide();
                lblminuteandtime.Show();
            }

            if (sec1 == 1)
            {
                lblsectime.Hide();
                lblsecondtime.Show();
            }

            if (hours == 0)
            {
                lblhourtime.Hide();
                lblhoursandtime.Hide();
                lblhourandtime.Hide();
            }

            if (min1 == 0)
            {
                lblmintime.Hide();
                lblminutesandtime.Hide();
                lblminuteandtime.Hide();
            }
        }

        private void Stopbutton_Click(object sender, EventArgs e)
        {
            BreakTimer.Stop();
            TSFHourIndicatorLabelBT.Text = "--";
            TSFMinIndicatorLabelBT.Text = "--";
            TSFSecondIndicatorLabelBT.Text = "--";
            BSTHourIndicatorLabelBT.Text = "--";
            BSTMinIndicatorLabelBT.Text = "--";
            BSTSecondIndicatorLabelBT.Text = "--";
            HourLabelBT.Text = "--";
            lblminute.Text = "--";
            lblsec.Text = "--";
            B1HourNudBT.Value = Conversions.ToDecimal("0");
            nudb1min.Value = Conversions.ToDecimal("0");
            nudb1sec.Value = Conversions.ToDecimal("0");
        }

        private void Resumetimebutton_Click(object sender, EventArgs e)
        {
            TimerTimer.Start();
            TimerTimer.Enabled = true;
            ResumeTimeButton.Hide();
            StopTimeButton.Show();
            PauseButtonT.Show();
            StartTimeButton.Hide();
        }

        private void BreakTimer_Tick(object sender, EventArgs e)
        {
            if (sec > 0)
            {
                sec -= 1;
                lblsec.Show();
                lblsecondsbreak.Show();
                lblsecondbreak.Hide();
            }
            else if (min > 0)
            {
                sec = 59;
                min -= 1;
                lblminute.Show();
                lblminutesandbreak.Show();
                lblminuteandbreak.Hide();
            }
            else if (hour > 0)
            {
                sec = 59;
                min = 59;
                hour -= 1;
                HourLabelBT.Show();
                lblhoursandbreak.Show();
                HourAndBreakLabelBT.Hide();
            }
            else
            {
                BreakTimer.Stop();
                BreakTimer.Enabled = false;
                switch (My.MySettingsProperty.Settings.Sound1)
                {
                    case 0:
                        {
                            My.MyProject.Computer.Audio.Play(Application.StartupPath + @"\timesup4.wav");
                            break;
                        }

                    case 1 | 2:
                        {
                            My.MyProject.Computer.Audio.Play(My.MySettingsProperty.Settings.Sound1Location);
                            break;
                        }
                }

                My.MyProject.Forms.BreakForm.sethours = Conversions.ToInteger(nudTimeBreakHour.Value);
                My.MyProject.Forms.BreakForm.hours = My.MyProject.Forms.BreakForm.sethours;
                My.MyProject.Forms.BreakForm.setminutes = Conversions.ToInteger(nudTimeBreakMin.Value);
                My.MyProject.Forms.BreakForm.minutes = My.MyProject.Forms.BreakForm.setminutes;
                My.MyProject.Forms.BreakForm.setsecs = Conversions.ToInteger(nudTimeBreakSec.Value);
                My.MyProject.Forms.BreakForm.seconds = My.MyProject.Forms.BreakForm.setsecs;
                My.MyProject.Forms.BreakForm.Show();
                Hide();
            }

            switch (MinWarnNudBt.Value)
            {
                case 1:
                    {
                        if (hour == 0 && min == 0 && sec < 60)
                        {
                            int remain = sec;
                            if (Notify == false)
                            {
                                WindowState = FormWindowState.Normal;
                                if (AudioRbBt.Checked == true && VisualRbBt.Checked == false)
                                {
                                    PlayNow();
                                }
                                else if (AudioRbBt.Checked == false && VisualRbBt.Checked == true)
                                {
                                    PlayNow();
                                    BreakTimer.Stop();
                                    string mes = ((int)MessageBox.Show("Breaktime will start in " + remain + " seconds. Click OK to start breaktime now. Otherwise, click Cancel to continue the timer.", "MinWarn Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)).ToString();
                                    if (Conversions.ToDouble(mes) == (double)DialogResult.OK)
                                    {
                                        BreakTimer.Stop();
                                        BreakTimer.Enabled = false;
                                        switch (My.MySettingsProperty.Settings.Sound1)
                                        {
                                            case 0:
                                                {
                                                    My.MyProject.Computer.Audio.Play(Application.StartupPath + @"\timesup4.wav");
                                                    break;
                                                }

                                            case 1 | 2:
                                                {
                                                    My.MyProject.Computer.Audio.Play(My.MySettingsProperty.Settings.Sound1Location);
                                                    break;
                                                }
                                        }

                                        My.MyProject.Forms.BreakForm.sethours = Conversions.ToInteger(nudTimeBreakHour.Value);
                                        My.MyProject.Forms.BreakForm.hours = My.MyProject.Forms.BreakForm.sethours;
                                        My.MyProject.Forms.BreakForm.setminutes = Conversions.ToInteger(nudTimeBreakMin.Value);
                                        My.MyProject.Forms.BreakForm.minutes = My.MyProject.Forms.BreakForm.setminutes;
                                        My.MyProject.Forms.BreakForm.setsecs = Conversions.ToInteger(nudTimeBreakSec.Value);
                                        My.MyProject.Forms.BreakForm.seconds = My.MyProject.Forms.BreakForm.setsecs;
                                        My.MyProject.Forms.BreakForm.Show();
                                        Hide();
                                    }
                                    else if (Conversions.ToDouble(mes) == (double)DialogResult.Cancel)
                                    {
                                        BreakTimer.Start();
                                    }
                                }

                                Notify = true;
                            }
                        }

                        break;
                    }

                case 2:
                    {
                        if (hour == 0 && min == 1 && sec < 60)
                        {
                            int remain = sec;
                            if (Notify == false)
                            {
                                WindowState = FormWindowState.Normal;
                                if (AudioRbBt.Checked == true && VisualRbBt.Checked == false)
                                {
                                    PlayNow();
                                }
                                else if (AudioRbBt.Checked == false && VisualRbBt.Checked == true)
                                {
                                    PlayNow();
                                    BreakTimer.Stop();
                                    string mes = ((int)MessageBox.Show("Breaktime will start in " + min + " minutes and " + remain + " seconds. Click OK to start breaktime now. Otherwise, click Cancel to continue the timer.", "MinWarn Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)).ToString();
                                    if (Conversions.ToDouble(mes) == (double)DialogResult.OK)
                                    {
                                        BreakTimer.Stop();
                                        BreakTimer.Enabled = false;
                                        switch (My.MySettingsProperty.Settings.Sound1)
                                        {
                                            case 0:
                                                {
                                                    My.MyProject.Computer.Audio.Play(Application.StartupPath + @"\timesup4.wav");
                                                    break;
                                                }

                                            case 1 | 2:
                                                {
                                                    My.MyProject.Computer.Audio.Play(My.MySettingsProperty.Settings.Sound1Location);
                                                    break;
                                                }
                                        }

                                        My.MyProject.Forms.BreakForm.sethours = Conversions.ToInteger(nudTimeBreakHour.Value);
                                        My.MyProject.Forms.BreakForm.hours = My.MyProject.Forms.BreakForm.sethours;
                                        My.MyProject.Forms.BreakForm.setminutes = Conversions.ToInteger(nudTimeBreakMin.Value);
                                        My.MyProject.Forms.BreakForm.minutes = My.MyProject.Forms.BreakForm.setminutes;
                                        My.MyProject.Forms.BreakForm.setsecs = Conversions.ToInteger(nudTimeBreakSec.Value);
                                        My.MyProject.Forms.BreakForm.seconds = My.MyProject.Forms.BreakForm.setsecs;
                                        My.MyProject.Forms.BreakForm.Show();
                                        Hide();
                                    }
                                    else if (Conversions.ToDouble(mes) == (double)DialogResult.Cancel)
                                    {
                                        BreakTimer.Start();
                                        Notify = true;
                                    }
                                }
                            }
                        }

                        break;
                    }

                case 3:
                    {
                        if (hour == 0 && min == 2 && sec < 60)
                        {
                            int remain = sec;
                            if (Notify == false)
                            {
                                WindowState = FormWindowState.Normal;
                                if (AudioRbBt.Checked == true && VisualRbBt.Checked == false)
                                {
                                    PlayNow();
                                }
                                else if (AudioRbBt.Checked == false && VisualRbBt.Checked == true)
                                {
                                    PlayNow();
                                    BreakTimer.Stop();
                                    string mes = ((int)MessageBox.Show("Breaktime will start in " + min + " minutes and " + remain + " seconds. Click OK to start breaktime now. Otherwise, click Cancel to continue the timer.", "MinWarn Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)).ToString();
                                    if (Conversions.ToDouble(mes) == (double)DialogResult.OK)
                                    {
                                        BreakTimer.Stop();
                                        BreakTimer.Enabled = false;
                                        switch (My.MySettingsProperty.Settings.Sound1)
                                        {
                                            case 0:
                                                {
                                                    My.MyProject.Computer.Audio.Play(Application.StartupPath + @"\timesup4.wav");
                                                    break;
                                                }

                                            case 1 | 2:
                                                {
                                                    My.MyProject.Computer.Audio.Play(My.MySettingsProperty.Settings.Sound1Location);
                                                    break;
                                                }
                                        }

                                        My.MyProject.Forms.BreakForm.sethours = Conversions.ToInteger(nudTimeBreakHour.Value);
                                        My.MyProject.Forms.BreakForm.hours = My.MyProject.Forms.BreakForm.sethours;
                                        My.MyProject.Forms.BreakForm.setminutes = Conversions.ToInteger(nudTimeBreakMin.Value);
                                        My.MyProject.Forms.BreakForm.minutes = My.MyProject.Forms.BreakForm.setminutes;
                                        My.MyProject.Forms.BreakForm.setsecs = Conversions.ToInteger(nudTimeBreakSec.Value);
                                        My.MyProject.Forms.BreakForm.seconds = My.MyProject.Forms.BreakForm.setsecs;
                                        My.MyProject.Forms.BreakForm.Show();
                                        Hide();
                                    }
                                    else if (Conversions.ToDouble(mes) == (double)DialogResult.Cancel)
                                    {
                                        BreakTimer.Start();
                                        Notify = true;
                                    }
                                }
                            }
                        }

                        break;
                    }

                case 4:
                    {
                        if (hour == 0 && min == 3 && sec < 60)
                        {
                            int remain = sec;
                            if (Notify == false)
                            {
                                WindowState = FormWindowState.Normal;
                                if (AudioRbBt.Checked == true && VisualRbBt.Checked == false)
                                {
                                    PlayNow();
                                }
                                else if (AudioRbBt.Checked == false && VisualRbBt.Checked == true)
                                {
                                    PlayNow();
                                    BreakTimer.Stop();
                                    string mes = ((int)MessageBox.Show("Breaktime will start in " + min + " minutes and " + remain + " seconds. Click OK to start breaktime now. Otherwise, click Cancel to continue the timer.", "MinWarn Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)).ToString();
                                    if (Conversions.ToDouble(mes) == (double)DialogResult.OK)
                                    {
                                        BreakTimer.Stop();
                                        BreakTimer.Enabled = false;
                                        switch (My.MySettingsProperty.Settings.Sound1)
                                        {
                                            case 0:
                                                {
                                                    My.MyProject.Computer.Audio.Play(Application.StartupPath + @"\timesup4.wav");
                                                    break;
                                                }

                                            case 1 | 2:
                                                {
                                                    My.MyProject.Computer.Audio.Play(My.MySettingsProperty.Settings.Sound1Location);
                                                    break;
                                                }
                                        }

                                        My.MyProject.Forms.BreakForm.sethours = Conversions.ToInteger(nudTimeBreakHour.Value);
                                        My.MyProject.Forms.BreakForm.hours = My.MyProject.Forms.BreakForm.sethours;
                                        My.MyProject.Forms.BreakForm.setminutes = Conversions.ToInteger(nudTimeBreakMin.Value);
                                        My.MyProject.Forms.BreakForm.minutes = My.MyProject.Forms.BreakForm.setminutes;
                                        My.MyProject.Forms.BreakForm.setsecs = Conversions.ToInteger(nudTimeBreakSec.Value);
                                        My.MyProject.Forms.BreakForm.seconds = My.MyProject.Forms.BreakForm.setsecs;
                                        My.MyProject.Forms.BreakForm.Show();
                                        Hide();
                                    }
                                    else if (Conversions.ToDouble(mes) == (double)DialogResult.Cancel)
                                    {
                                        BreakTimer.Start();
                                        Notify = true;
                                    }
                                }
                            }
                        }

                        break;
                    }

                case 5:
                    {
                        if (hour == 0 && min == 4 && sec < 60)
                        {
                            int remain = sec;
                            if (Notify == false)
                            {
                                WindowState = FormWindowState.Normal;
                                if (AudioRbBt.Checked == true && VisualRbBt.Checked == false)
                                {
                                    PlayNow();
                                }
                                else if (AudioRbBt.Checked == false && VisualRbBt.Checked == true)
                                {
                                    PlayNow();
                                    BreakTimer.Stop();
                                    string mes = ((int)MessageBox.Show("Breaktime will start in " + min + " minutes and " + remain + " seconds. Click OK to start breaktime now. Otherwise, click Cancel to continue the timer.", "MinWarn Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)).ToString();
                                    if (Conversions.ToDouble(mes) == (double)DialogResult.OK)
                                    {
                                        BreakTimer.Stop();
                                        BreakTimer.Enabled = false;
                                        switch (My.MySettingsProperty.Settings.Sound1)
                                        {
                                            case 0:
                                                {
                                                    My.MyProject.Computer.Audio.Play(Application.StartupPath + @"\timesup4.wav");
                                                    break;
                                                }

                                            case 1 | 2:
                                                {
                                                    My.MyProject.Computer.Audio.Play(My.MySettingsProperty.Settings.Sound1Location);
                                                    break;
                                                }
                                        }

                                        My.MyProject.Forms.BreakForm.sethours = Conversions.ToInteger(nudTimeBreakHour.Value);
                                        My.MyProject.Forms.BreakForm.hours = My.MyProject.Forms.BreakForm.sethours;
                                        My.MyProject.Forms.BreakForm.setminutes = Conversions.ToInteger(nudTimeBreakMin.Value);
                                        My.MyProject.Forms.BreakForm.minutes = My.MyProject.Forms.BreakForm.setminutes;
                                        My.MyProject.Forms.BreakForm.setsecs = Conversions.ToInteger(nudTimeBreakSec.Value);
                                        My.MyProject.Forms.BreakForm.seconds = My.MyProject.Forms.BreakForm.setsecs;
                                        My.MyProject.Forms.BreakForm.Show();
                                        Hide();
                                    }
                                    else if (Conversions.ToDouble(mes) == (double)DialogResult.Cancel)
                                    {
                                        BreakTimer.Start();
                                        Notify = true;
                                    }
                                }
                            }
                        }

                        break;
                    }
            }

            lblsec.Text = Strings.Format(sec, "0#");
            HourLabelBT.Text = Strings.Format(hour, "0#");
            lblminute.Text = Strings.Format(min, "0#");
            if (hour == 1)
            {
                lblhoursandbreak.Hide();
                HourAndBreakLabelBT.Show();
            }

            if (min == 1)
            {
                lblminutesandbreak.Hide();
                lblminuteandbreak.Show();
            }

            if (sec == 1)
            {
                lblsecondsbreak.Hide();
                lblsecondbreak.Show();
            }

            if (hour == 0 && min <= 59)
            {
                HourLabelBT.Hide();
                lblhoursandbreak.Hide();
                HourAndBreakLabelBT.Hide();
            }

            if (min == 0)
            {
                lblminute.Hide();
                lblminutesandbreak.Hide();
                lblminuteandbreak.Hide();
            }
        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            if (TimeRBBt.Checked == true && BreakRBBt.Checked == false)
            {
                if (nudTimeHour.Value == 0 && nudTimeMin.Value == 0 && nudTimeSec.Value == 0 && nudTimeBreakHour.Value == 0 && nudTimeBreakMin.Value == 0 && nudTimeBreakSec.Value == 0)
                {
                    return;
                }
                else
                {
                }

                TSFHourIndicatorLabelBT.Text = nudTimeHour.Value.ToString();
                TSFMinIndicatorLabelBT.Text = nudTimeMin.Value.ToString();
                TSFSecondIndicatorLabelBT.Text = nudTimeSec.Value.ToString();
                BSTHourIndicatorLabelBT.Text = nudTimeBreakHour.Value.ToString();
                BSTMinIndicatorLabelBT.Text = nudTimeBreakMin.Value.ToString();
                BSTSecondIndicatorLabelBT.Text = nudTimeBreakSec.Value.ToString();
                TimerTab.Enabled = false;
                StopWatchTab.Enabled = false;
                ShutdownTabPage.Enabled = false;
                AlarmClockTab.Enabled = false;
                BreakGBBt.Hide();
                TimerGBBt.Hide();
                TimeRBBt.Hide();
                BreakRBBt.Hide();
                BreakNowButtonBt.Show();
                WindowState = FormWindowState.Minimized;
                BreakTimer.Enabled = true;
                BreakTimer.Start();
                sethours = Conversions.ToInteger(nudTimeHour.Value);
                setmins = Conversions.ToInteger(nudTimeMin.Value);
                setsecs = Conversions.ToInteger(nudTimeSec.Value);
                hour = sethours;
                min = setmins;
                sec = setsecs;
                StartButtonBT.Hide();
                PauseButtonBT.Show();
                btnResume.Hide();
                btnStop.Show();
                Notify = false;
            }
            else if (BreakRBBt.Checked == true && TimeRBBt.Checked == false)
            {
                if (nudb1min.Value == 0 && B1HourNudBT.Value == 0 && nudb1sec.Value == 0)
                {
                    return;
                }
                else
                {
                }

                My.MyProject.Forms.BreakForm.sethours = Conversions.ToInteger(B1HourNudBT.Value);
                My.MyProject.Forms.BreakForm.hours = My.MyProject.Forms.BreakForm.sethours;
                My.MyProject.Forms.BreakForm.setminutes = Conversions.ToInteger(nudb1min.Value);
                My.MyProject.Forms.BreakForm.minutes = My.MyProject.Forms.BreakForm.setminutes;
                My.MyProject.Forms.BreakForm.setsecs = Conversions.ToInteger(nudb1sec.Value);
                My.MyProject.Forms.BreakForm.seconds = My.MyProject.Forms.BreakForm.setsecs;
                My.MyProject.Forms.BreakForm.Show();
                Hide();
            }
            else if (TimeRBBt.Checked == false && BreakRBBt.Checked == false)
            {
                Interaction.MsgBox("You must select either to set a break or to set a time in order to start your time.", MsgBoxStyle.Critical, "Selection Error");
                return;
            }
        }

        private void ResumeStopWButton_Click(object sender, EventArgs e)
        {
            SW.Start();
            Tmr.Start();
            PauseButtonSW.Show();
            ResumeButtonSW.Hide();
            StopButtonSW.Show();
            StartButtonSW.Hide();
        }

        private void StopStopWButton_Click(object sender, EventArgs e)
        {
            SW.Stop();
            Tmr.Stop();
            PauseButtonSW.Hide();
            ResumeButtonSW.Hide();
            StopButtonSW.Hide();
            StartButtonSW.Show();
            ShutdownTabPage.Enabled = true;
            BreakTimerTab.Enabled = true;
            TimerTab.Enabled = true;
            AlarmClockTab.Enabled = true;
            StopwatchLabelSW.Text = "--:--:--";
            LapListBoxSw.Items.Clear();
            LapListBoxSw.Hide();
            TimerControl.Enabled = true;
        }

        private void ResumeButtonSh_Click(object sender, EventArgs e)
        {
            ShutdownTimer.Start();
            StopButtonSh.Show();
            StartButtonSh.Hide();
            PauseButtonSh.Show();
            ResumeButtonSh.Hide();
        }

        private void StopButtonSh_Click(object sender, EventArgs e)
        {
            ShutdownTimer.Stop();
            Application.Restart();
        }

        private void MainFormLAG_Shown(object sender, EventArgs e)
        {
            // Calculate the amount the width and height will grow at each timer tick
            wstep = ShowSize.Width / (double)14;
            hstep = ShowSize.Height / (double)14;

            // Reset the location to the center of where the form is now
            Location = new Point(Left + (int)(Width / (double)2), Top + (int)(Height / (double)2));
            Size = new Size(0, 0); // Set the forms size to 0,0
            Opacity = 1.0; // Now that the form is 0,0 in size set the opacity back to 1.0
            Tmras.Start(); // Start the timer to relocate and resize the form a step at a time
        }

        private void Tmras_Tick(object sender, EventArgs e)
        {
            Width += Conversions.ToInteger(wstep);
            Height += Conversions.ToInteger(hstep);
            Left -= (int)(wstep / 2);
            Top -= (int)(hstep / 2);
            if (Width >= ShowSize.Width - 1 & Height >= ShowSize.Height - 1)
            {
                Tmras.Stop();
            }
        }
    }
}