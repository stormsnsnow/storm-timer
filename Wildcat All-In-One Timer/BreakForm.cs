using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace UTimer
{
    public partial class BreakForm
    {
        public BreakForm()
        {
            InitializeComponent();
            _UnlockButton.Name = "UnlockButton";
            _PauseButton.Name = "PauseButton";
        }

        public int hours, minutes, seconds;
        public int setminutes, sethours, setsecs;

        private void FrmBreak_Load(object sender, EventArgs e)
        {
            // Me.BackgroundImage = Image.FromFile(GetCurrentWallpaper())
            Breaktime();
            BreakTimer.Start();
            BackColor = ColorTranslator.FromHtml(My.MySettingsProperty.Settings.BackColor.ToArgb().ToString());
            ForeColor = ColorTranslator.FromHtml(My.MySettingsProperty.Settings.ForeColor.ToArgb().ToString());
            Panel1.BackColor = ColorTranslator.FromHtml(My.MySettingsProperty.Settings.BackColor.ToArgb().ToString());
            Panel1.ForeColor = ColorTranslator.FromHtml(My.MySettingsProperty.Settings.ForeColor.ToArgb().ToString());
            BreakPanel.BackColor = ColorTranslator.FromHtml(My.MySettingsProperty.Settings.BackColor.ToArgb().ToString());
            BreakPanel.ForeColor = ColorTranslator.FromHtml(My.MySettingsProperty.Settings.ForeColor.ToArgb().ToString());
            Label1.Text = SystemInformation.UserName + ", it's time to take a break.";
        }

        public void Breaktime()
        {
            switch (My.MySettingsProperty.Settings.TimeFormat)
            {
                case 0:
                    {
                        var datetime = DateTime.Now;
                        DateTime hourtime = Conversions.ToDate(datetime.Add(new TimeSpan(hours, minutes, seconds)).ToString("HH:mm:ss tt", CultureInfo.InvariantCulture));
                        lbltime.Text = "at " + hourtime;
                        break;
                    }

                case 1:
                    {
                        var datetime = DateTime.Now;
                        lbltime.Text = "at " + DateAndTime.Now.Add(new TimeSpan(hours, minutes, seconds)).ToString("HH:mm:ss");
                        break;
                    }

                case 2:
                    {
                        DateTime hourtime1 = Conversions.ToDate(DateAndTime.Now.ToString("HH:mm tt", CultureInfo.InvariantCulture));
                        lbltime.Text = "at " + hourtime1.Add(new TimeSpan(hours, minutes, seconds));
                        break;
                    }

                case 3:
                    {
                        lbltime.Text = "at " + DateAndTime.Now.Add(new TimeSpan(hours, minutes, seconds)).ToString("HH:mm");
                        break;
                    }
            }

            switch (My.MySettingsProperty.Settings.DateFormat4Break)
            {
                case 0:
                    {
                        lbldate.Text = DateAndTime.Now.Add(new TimeSpan(hours, minutes, seconds)).ToString("yyMMdd");
                        break;
                    }

                case 1:
                    {
                        lbldate.Text = DateAndTime.Now.Add(new TimeSpan(hours, minutes, seconds)).ToString("yyyyMMdd");
                        break;
                    }

                case 2:
                    {
                        lbldate.Text = DateAndTime.Now.Add(new TimeSpan(hours, minutes, seconds)).ToString("MM/dd/yy");
                        break;
                    }

                case 3:
                    {
                        lbldate.Text = DateAndTime.Now.Add(new TimeSpan(hours, minutes, seconds)).ToString("dd/MM/yy");
                        break;
                    }

                case 4:
                    {
                        lbldate.Text = DateAndTime.Now.Add(new TimeSpan(hours, minutes, seconds)).ToString("MM/dd/yyyy");
                        break;
                    }
            }
        }

        private void UnlockButton_Click_1(object sender, EventArgs e)
        {
            My.MyProject.Computer.Audio.Play(Application.StartupPath + @"\breakover4.wav");
            Application.Restart();
        }

        private void UnlockButton_Click(object sender, EventArgs e)
        {
            BreakTimer.Stop();
            var synthesizer = new SpeechSynthesizer();
            synthesizer.SetOutputToDefaultAudioDevice();
            sapi.Speak("Breaktime Paused. Click on the break dialog to resume break.");
            My.MyProject.Forms.BreakPausedForm.Show();
            Hide();
        }

        private string GetCurrentWallpaper()
        {
            // The current wallpaper path is stored in the registry at HKCU\Control Panel\Desktop\WallPaper
            var rkWallPaper = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", false);
            string WallpaperPath = rkWallPaper.GetValue("WallPaper").ToString();
            rkWallPaper.Close();
            // Return the current wallpaper path
            return WallpaperPath;
        }

        private void TTab_Tick(object sender, EventArgs e)
        {
            if (seconds > 0)
            {
                seconds -= 1;
                lblsec.Show();
                lblsecondsbreak.Show();
                lblsecondbreak.Hide();
            }
            else if (minutes > 0)
            {
                seconds = 59;
                minutes -= 1;
                lblminute.Show();
                lblminutesandbreak.Show();
                lblminuteandbreak.Hide();
            }
            else if (hours > 0)
            {
                seconds = 59;
                minutes = 59;
                hours -= 1;
                lblhour.Show();
                lblhoursandbreak.Show();
                lblhourandbreak.Hide();
            }
            else
            {
                BreakTimer.Stop();
                My.MyProject.Computer.Audio.Play(Application.StartupPath + @"\breakover4.wav");
                Application.Restart();
            }

            lblhour.Text = Strings.Format(hours, "0#");
            lblminute.Text = Strings.Format(minutes, "0#");
            lblsec.Text = Strings.Format(seconds, "0#");
            if (hours == 1)
            {
                lblhoursandbreak.Hide();
                lblhourandbreak.Show();
            }

            if (minutes == 1)
            {
                lblminutesandbreak.Hide();
                lblminuteandbreak.Show();
            }

            if (seconds == 1)
            {
                lblsecondsbreak.Hide();
                lblsecondbreak.Show();
            }

            if (hours == 0)
            {
                lblhour.Hide();
                lblhoursandbreak.Hide();
                lblhourandbreak.Hide();
            }

            if (minutes == 0)
            {
                lblminute.Hide();
                lblminutesandbreak.Hide();
                lblminuteandbreak.Hide();
            }
        }
    }
}