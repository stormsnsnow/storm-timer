using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace UTimer
{
    public partial class SettingsForm
    {
        public SettingsForm()
        {
            InitializeComponent();
            _SaveButtonSettings.Name = "SaveButtonSettings";
            _CancelButtonSettings.Name = "CancelButtonSettings";
            _BtnLicense.Name = "BtnLicense";
            _BTStop.Name = "BTStop";
            _BTBrowse.Name = "BTBrowse";
            _BTPlay.Name = "BTPlay";
            _Button2.Name = "Button2";
            _Button1.Name = "Button1";
            _MWPlayButtonS.Name = "MWPlayButtonS";
            _TDPlayButtonS.Name = "TDPlayButtonS";
            _TDComboBoxS.Name = "TDComboBoxS";
            _TDStopButtonS.Name = "TDStopButtonS";
            _MWStopButtonS.Name = "MWStopButtonS";
            _ComboBox1.Name = "ComboBox1";
            _TimeFormatCbDTGen.Name = "TimeFormatCbDTGen";
            _DateFormatCbDTGen.Name = "DateFormatCbDTGen";
            _ResetButtonReGen.Name = "ResetButtonReGen";
            _ColorWheel2.Name = "ColorWheel2";
            _ColorWheel1.Name = "ColorWheel1";
        }

        public static string Downuri;

        private void Settings_Load(object sender, EventArgs e)
        {
            BackColor = ColorTranslator.FromHtml(My.MySettingsProperty.Settings.BackColor.ToArgb().ToString());
            ForeColor = ColorTranslator.FromHtml(My.MySettingsProperty.Settings.ForeColor.ToArgb().ToString());
            Personalization.BackColor = ColorTranslator.FromHtml(My.MySettingsProperty.Settings.BackColor.ToArgb().ToString());
            Personalization.ForeColor = ColorTranslator.FromHtml(My.MySettingsProperty.Settings.ForeColor.ToArgb().ToString());
            AutoTime.BackColor = ColorTranslator.FromHtml(My.MySettingsProperty.Settings.BackColor.ToArgb().ToString());
            AutoTime.ForeColor = ColorTranslator.FromHtml(My.MySettingsProperty.Settings.ForeColor.ToArgb().ToString());
            Sounds.BackColor = ColorTranslator.FromHtml(My.MySettingsProperty.Settings.BackColor.ToArgb().ToString());
            Sounds.ForeColor = ColorTranslator.FromHtml(My.MySettingsProperty.Settings.ForeColor.ToArgb().ToString());
            About.BackColor = ColorTranslator.FromHtml(My.MySettingsProperty.Settings.BackColor.ToArgb().ToString());
            About.ForeColor = ColorTranslator.FromHtml(My.MySettingsProperty.Settings.ForeColor.ToArgb().ToString());
            General.BackColor = ColorTranslator.FromHtml(My.MySettingsProperty.Settings.BackColor.ToArgb().ToString());
            General.ForeColor = ColorTranslator.FromHtml(My.MySettingsProperty.Settings.ForeColor.ToArgb().ToString());
            WDLCTSUCbSUGen.SelectedIndex = My.MySettingsProperty.Settings.Startup;
            TDComboBoxS.SelectedIndex = My.MySettingsProperty.Settings.Sound1;
            MWComboBoxS.SelectedIndex = My.MySettingsProperty.Settings.Sound2;
            DateFormatCbDTGen.SelectedIndex = My.MySettingsProperty.Settings.DateFormat;
            TimeFormatCbDTGen.SelectedIndex = My.MySettingsProperty.Settings.TimeFormat;
            ComboBox1.SelectedIndex = My.MySettingsProperty.Settings.DateFormat4Break;
            ColorWheel1.Color = ColorTranslator.FromHtml(My.MySettingsProperty.Settings.BackColor.ToArgb().ToString());
            ColorWheel2.Color = ColorTranslator.FromHtml(My.MySettingsProperty.Settings.ForeColor.ToArgb().ToString());
            if (File.Exists(Application.StartupPath + @"\sounds\"))
            {
                Sounds.Show();
            }
            else
            {
                Sounds.Hide();
            }
        }

        private void SaveButtonSettings_Click(object sender, EventArgs e)
        {
            My.MySettingsProperty.Settings.Startup = WDLCTSUCbSUGen.SelectedIndex;
            My.MySettingsProperty.Settings.DateFormat = DateFormatCbDTGen.SelectedIndex;
            My.MySettingsProperty.Settings.TimeFormat = TimeFormatCbDTGen.SelectedIndex;
            My.MySettingsProperty.Settings.Sound1 = TDComboBoxS.SelectedIndex;
            My.MySettingsProperty.Settings.AutoTimeBTBHour = nudTimeBreakHour.Value.ToString();
            My.MySettingsProperty.Settings.AutoTimeBTBMin = nudTimeBreakMin.Value.ToString();
            My.MySettingsProperty.Settings.AutoTimeBTBSec = nudTimeBreakSec.Value.ToString();
            My.MySettingsProperty.Settings.AutoTimeBTTHour = nudTimeHour.Value.ToString();
            My.MySettingsProperty.Settings.AutoTimeBTTMin = nudTimeMin.Value.ToString();
            My.MySettingsProperty.Settings.AutoTimeBTTSec = nudTimeSec.Value.ToString();
            My.MySettingsProperty.Settings.AutoTimeBTB1Hour = nudb1hour.Value.ToString();
            My.MySettingsProperty.Settings.AutoTimeBTB1Min = nudb1min.Value.ToString();
            My.MySettingsProperty.Settings.AutoTimeBTB1Sec = nudb1sec.Value.ToString();
            My.MySettingsProperty.Settings.MWAutoTime = MinWarnNudBt.Value.ToString();
            if (AudioRbBt.Checked == true && VisualRbBt.Checked == false)
            {
                My.MySettingsProperty.Settings.AudioOrVisual = true;
            }
            else if (AudioRbBt.Checked == false && VisualRbBt.Checked == true)
            {
                My.MySettingsProperty.Settings.AudioOrVisual = false;
            }

            if (TimeRBBt.Checked == true && BreakRBBt.Checked == false)
            {
                My.MySettingsProperty.Settings.SetTimeOrBreak = true;
            }
            else if (TimeRBBt.Checked == false && BreakRBBt.Checked == true)
            {
                My.MySettingsProperty.Settings.SetTimeOrBreak = false;
            }

            My.MySettingsProperty.Settings.AutoTimeTTHour = nudHour.Value.ToString();
            My.MySettingsProperty.Settings.AutoTimeTTMin = nudMin.Value.ToString();
            My.MySettingsProperty.Settings.AutoTimeTTSec = nudSec.Value.ToString();
            My.MySettingsProperty.Settings.AutoTimeShHour = HourNudSh.Value.ToString();
            My.MySettingsProperty.Settings.AutoTimeShMin = MinuteNudSh.Value.ToString();
            My.MySettingsProperty.Settings.AutoTimeShSec = SecondNudSh.Value.ToString();
            My.MySettingsProperty.Settings.AutoTimeSh = ShutdownCbSh.SelectedIndex.ToString();
            if (AudioRadioButtonSh.Checked == true && VisualRadioButtonSh.Checked == false)
            {
                My.MySettingsProperty.Settings.AudOrVis = true;
            }
            else if (AudioRadioButtonSh.Checked == false && VisualRadioButtonSh.Checked == true)
            {
                My.MySettingsProperty.Settings.AudOrVis = false;
            }

            switch (TDComboBoxS.SelectedIndex)
            {
                case 0:
                    {
                        My.MySettingsProperty.Settings.Sound1Location = Application.StartupPath + @"\timeup.wav";
                        break;
                    }

                case 1:
                    {
                        My.MySettingsProperty.Settings.Sound1Location = Application.StartupPath + @"\sounds\bt\aquanear.wav";
                        break;
                    }

                case 2:
                    {
                        My.MySettingsProperty.Settings.Sound1Location = Application.StartupPath + @"\sounds\bt\ff.wav";
                        break;
                    }

                case 3:
                    {
                        My.MySettingsProperty.Settings.Sound1Location = Application.StartupPath + @"\sounds\bt\foghorn.wav";
                        break;
                    }

                case 4:
                    {
                        My.MySettingsProperty.Settings.Sound1Location = Application.StartupPath + @"\sounds\bt\td211.wav";
                        break;
                    }

                case 5:
                    {
                        My.MySettingsProperty.Settings.Sound1Location = Application.StartupPath + @"\sounds\bt\speedeam.wav";
                        break;
                    }
            }

            My.MySettingsProperty.Settings.Sound2 = MWComboBoxS.SelectedIndex;
            switch (MWComboBoxS.SelectedIndex)
            {
                case 0:
                    {
                        My.MySettingsProperty.Settings.Sound2Location = Application.StartupPath + @"\shutdown.wav";
                        break;
                    }

                case 1:
                    {
                        My.MySettingsProperty.Settings.Sound2Location = Application.StartupPath + @"\sounds\mw\tw.wav";
                        break;
                    }

                case 2:
                    {
                        My.MySettingsProperty.Settings.Sound2Location = Application.StartupPath + @"\sounds\mw\bub.wav";
                        break;
                    }

                case 3:
                    {
                        My.MySettingsProperty.Settings.Sound2Location = Application.StartupPath + @"\sounds\mw\ab.wav";
                        break;
                    }

                case 4:
                    {
                        My.MySettingsProperty.Settings.Sound2Location = Application.StartupPath + @"\sounds\mw\bub2.wav";
                        break;
                    }

                case 5:
                    {
                        My.MySettingsProperty.Settings.Sound2Location = Application.StartupPath + @"\sounds\mw\mw211.wav";
                        break;
                    }

                case 6:
                    {
                        My.MySettingsProperty.Settings.Sound2Location = Application.StartupPath + @"\sounds\mw\pop.wav";
                        break;
                    }
            }

            My.MySettingsProperty.Settings.ForeColor = ColorWheel2.Color;
            My.MySettingsProperty.Settings.BackColor = ColorWheel1.Color;
            My.MySettingsProperty.Settings.DateFormat4Break = ComboBox1.SelectedIndex;
            My.MySettingsProperty.Settings.Save();
            DialogResult = DialogResult.OK;
            My.MyProject.Forms.MainForm.Show();
            Close();
        }

        private void CancelButtonSettings_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            My.MyProject.Forms.MainForm.Show();
            Close();
        }

        private void TDPlayButtonS_Click(object sender, EventArgs e)
        {
            switch (TDComboBoxS.SelectedIndex)
            {
                case 0:
                    {
                        TDPlayButtonS.Hide();
                        TDStopButtonS.Show();
                        My.MyProject.Computer.Audio.Play(Application.StartupPath + @"\timesup4.wav", AudioPlayMode.BackgroundLoop);
                        break;
                    }

                case 1:
                    {
                        TDPlayButtonS.Hide();
                        TDStopButtonS.Show();
                        My.MyProject.Computer.Audio.Play(Application.StartupPath + @"\sounds\bt\aquanear.wav", AudioPlayMode.BackgroundLoop);
                        break;
                    }

                case 2:
                    {
                        TDPlayButtonS.Hide();
                        TDStopButtonS.Show();
                        My.MyProject.Computer.Audio.Play(Application.StartupPath + @"\sounds\bt\ff.wav", AudioPlayMode.BackgroundLoop);
                        break;
                    }

                case 3:
                    {
                        TDPlayButtonS.Hide();
                        TDStopButtonS.Show();
                        My.MyProject.Computer.Audio.Play(Application.StartupPath + @"\sounds\bt\foghorn.wav", AudioPlayMode.BackgroundLoop);
                        break;
                    }

                case 4:
                    {
                        TDPlayButtonS.Hide();
                        TDStopButtonS.Show();
                        My.MyProject.Computer.Audio.Play(Application.StartupPath + @"\sounds\bt\td211.wav", AudioPlayMode.BackgroundLoop);
                        break;
                    }

                case 5:
                    {
                        TDPlayButtonS.Hide();
                        TDStopButtonS.Show();
                        My.MyProject.Computer.Audio.Play(Application.StartupPath + @"\sounds\bt\speedeam.wav", AudioPlayMode.BackgroundLoop);
                        break;
                    }

                case 6:
                    {
                        TDPlayButtonS.Hide();
                        TDStopButtonS.Show();
                        My.MyProject.Computer.Audio.Play(My.MySettingsProperty.Settings.Sound1Location, AudioPlayMode.BackgroundLoop);
                        break;
                    }
            }
        }

        private void TDStopButtonS_Click(object sender, EventArgs e)
        {
            TDPlayButtonS.Show();
            TDStopButtonS.Hide();
            My.MyProject.Computer.Audio.Stop();
        }

        private void MWStopButtonS_Click(object sender, EventArgs e)
        {
            MWPlayButtonS.Show();
            MWStopButtonS.Hide();
            My.MyProject.Computer.Audio.Stop();
        }

        private void MWPlayButtonS_Click(object sender, EventArgs e)
        {
            switch (MWComboBoxS.SelectedIndex)
            {
                case 0:
                    {
                        MWPlayButtonS.Hide();
                        MWStopButtonS.Show();
                        My.MyProject.Computer.Audio.Play(Application.StartupPath + @"\minwarn4.wav", AudioPlayMode.BackgroundLoop);
                        break;
                    }

                case 1:
                    {
                        MWPlayButtonS.Hide();
                        MWStopButtonS.Show();
                        My.MyProject.Computer.Audio.Play(Application.StartupPath + @"\sounds\mw\tw.wav", AudioPlayMode.BackgroundLoop);
                        break;
                    }

                case 2:
                    {
                        MWPlayButtonS.Hide();
                        MWStopButtonS.Show();
                        My.MyProject.Computer.Audio.Play(Application.StartupPath + @"\sounds\mw\bub.wav", AudioPlayMode.BackgroundLoop);
                        break;
                    }

                case 3:
                    {
                        MWPlayButtonS.Hide();
                        MWStopButtonS.Show();
                        My.MyProject.Computer.Audio.Play(Application.StartupPath + @"\sounds\mw\ab.wav", AudioPlayMode.BackgroundLoop);
                        break;
                    }

                case 4:
                    {
                        MWPlayButtonS.Hide();
                        MWStopButtonS.Show();
                        My.MyProject.Computer.Audio.Play(Application.StartupPath + @"\sounds\mw\bub2.wav", AudioPlayMode.BackgroundLoop);
                        break;
                    }

                case 5:
                    {
                        MWPlayButtonS.Hide();
                        MWStopButtonS.Show();
                        My.MyProject.Computer.Audio.Play(Application.StartupPath + @"\sounds\mw\mw211.wav", AudioPlayMode.BackgroundLoop);
                        break;
                    }

                case 6:
                    {
                        MWPlayButtonS.Hide();
                        MWStopButtonS.Show();
                        My.MyProject.Computer.Audio.Play(Application.StartupPath + @"\sounds\mw\pop.wav", AudioPlayMode.BackgroundLoop);
                        break;
                    }

                case 7:
                    {
                        try
                        {
                            MWPlayButtonS.Hide();
                            MWStopButtonS.Show();
                            My.MyProject.Computer.Audio.Play(My.MySettingsProperty.Settings.Sound2Location, AudioPlayMode.BackgroundLoop);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Either you did not specify an audio file or the audio file is broken. Please go back and select a new audio file. Error 1602", "Error 1602 - No sound", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                        break;
                    }
            }
        }

        private void DateFormatCbDTGen_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (DateFormatCbDTGen.SelectedIndex)
            {
                case 0:
                    {
                        DTLabelDTGen.Text = DateAndTime.Now.ToString("yyMMdd");
                        break;
                    }

                case 1:
                    {
                        DTLabelDTGen.Text = DateAndTime.Now.ToString("yyyyMMdd");
                        break;
                    }

                case 2:
                    {
                        Interaction.MsgBox("Please note that the date format you picked is for YourDay ONLY. For breaktime, use the other combo box.", MsgBoxStyle.Critical, "YourDay Only");
                        var myCulture = CultureInfo.CurrentCulture;
                        var dayOfWeek = myCulture.Calendar.GetDayOfWeek(DateTime.Today);
                        string dayName = myCulture.DateTimeFormat.GetDayName(dayOfWeek);
                        var datetime = DateTime.Now;
                        DTLabelDTGen.Text = dayName + " " + DateAndTime.MonthName(DateAndTime.Now.Month, false) + " " + DateAndTime.Now.Day + " " + DateAndTime.Now.Year;
                        break;
                    }

                case 3:
                    {
                        Interaction.MsgBox("Please note that the date format you picked is for YourDay ONLY. For breaktime, use the other combo box.", MsgBoxStyle.Critical, "YourDay Only");
                        var myCulture = CultureInfo.CurrentCulture;
                        var datetime = DateTime.Now;
                        DTLabelDTGen.Text = DateAndTime.MonthName(DateAndTime.Now.Month, false) + " " + DateAndTime.Now.Day + " " + DateAndTime.Now.Year;
                        break;
                    }

                case 4:
                    {
                        Interaction.MsgBox("Please note that this the date format you picked is for YourDay ONLY. For breaktime, use the other combo box.", MsgBoxStyle.Critical, "YourDay Only");
                        var myCulture = CultureInfo.CurrentCulture;
                        var datetime = DateTime.Now;
                        var dt = new DateTimeFormatInfo();
                        DTLabelDTGen.Text = dt.GetAbbreviatedMonthName(DateAndTime.Now.Month) + " " + DateAndTime.Now.Day + " " + DateAndTime.Now.ToString("yy");
                        break;
                    }

                case 5:
                    {
                        Interaction.MsgBox("Please note that the date format you picked is for YourDay ONLY. For breaktime, use the other combo box.", MsgBoxStyle.Critical, "YourDay Only");
                        var myCulture = CultureInfo.CurrentCulture;
                        var datetime = DateTime.Now;
                        var dt = new DateTimeFormatInfo();
                        DTLabelDTGen.Text = dt.GetAbbreviatedMonthName(DateAndTime.Now.Month) + " " + DateAndTime.Now.Day + " " + DateAndTime.Now.Year;
                        break;
                    }

                case 6:
                    {
                        DTLabelDTGen.Text = DateAndTime.Now.ToString("MM/dd/yy");
                        break;
                    }

                case 7:
                    {
                        DTLabelDTGen.Text = DateAndTime.Now.ToString("dd/MM/yy");
                        break;
                    }

                case 8:
                    {
                        DTLabelDTGen.Text = null;
                        break;
                    }
            }
        }

        private void TimeFormatCbDTGen_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TimeFormatCbDTGen.SelectedIndex)
            {
                case 0:
                    {
                        DateTime hourtime = Conversions.ToDate(DateAndTime.Now.ToString("HH:mm:ss tt", CultureInfo.InvariantCulture));
                        DTLabelDTGen2.Text = Conversions.ToString(hourtime);
                        break;
                    }

                case 1:
                    {
                        DTLabelDTGen2.Text = DateAndTime.Now.ToString("HH:mm:ss");
                        break;
                    }

                case 2:
                    {
                        DTLabelDTGen2.Text = DateAndTime.Now.ToShortTimeString();
                        break;
                    }

                case 3:
                    {
                        DTLabelDTGen2.Text = DateAndTime.Now.ToString("HH:mm");
                        break;
                    }

                case 4:
                    {
                        double uTime;
                        uTime = (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;
                        DTLabelDTGen2.Text = uTime.ToString();
                        break;
                    }

                case 5:
                    {
                        DTLabelDTGen2.Text = DateTime.UtcNow.TimeOfDay.ToString();
                        break;
                    }
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ComboBox1.SelectedIndex)
            {
                case 0:
                    {
                        Label1.Text = DateAndTime.Now.ToString("yyMMdd");
                        break;
                    }

                case 1:
                    {
                        Label1.Text = DateAndTime.Now.ToString("yyyyMMdd");
                        break;
                    }

                case 2:
                    {
                        Label1.Text = DateAndTime.Now.ToString("MM/dd/yy");
                        break;
                    }

                case 3:
                    {
                        Label1.Text = DateAndTime.Now.ToString("dd/MM/yy");
                        break;
                    }

                case 4:
                    {
                        Label1.Text = DateAndTime.Now.ToString("MM/dd/yyyy");
                        break;
                    }

                case 5:
                    {
                        double uTime;
                        uTime = (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;
                        Label1.Text = uTime.ToString();
                        break;
                    }
            }
        }

        private void ResetButtonReGen_Click(object sender, EventArgs e)
        {
            string ms;
            ms = ((int)MessageBox.Show("Are you sure? This will RESET ALL SETTINGS! Use caution if you have personalized settings!", "Confirm Reset", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)).ToString();
            if (Conversions.ToDouble(ms) == (double)DialogResult.Yes)
            {
                My.MySettingsProperty.Settings.Reset();
                Interaction.MsgBox("Reset successful. Program will now restart when you press OK.", MsgBoxStyle.Information, "Reset Success");
                Application.Restart();
            }
            else if (Conversions.ToDouble(ms) == (double)DialogResult.No)
            {
            }
            else if (Conversions.ToDouble(ms) == (double)DialogResult.Cancel)
            {
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (OFDS.ShowDialog() == DialogResult.OK)
            {
                My.MySettingsProperty.Settings.Sound1Location = OFDS.FileName;
                My.MySettingsProperty.Settings.Save();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (OFDS.ShowDialog() == DialogResult.OK)
            {
                My.MySettingsProperty.Settings.Sound2Location = OFDS.FileName;
                My.MySettingsProperty.Settings.Save();
            }
        }

        private void BtnLicense_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program is free software: you can redistribute it and/or modify" + Constants.vbCrLf + @"
    it under the terms of the GNU General Public License as published by" + Constants.vbCrLf + @"
    the Free Software Foundation, either version 3 of the License, or" + Constants.vbCrLf + @"
    (at your option) any later version." + Constants.vbCrLf + Constants.vbCrLf + @"

    This program is distributed in the hope that it will be useful," + Constants.vbCrLf + @"
    but WITHOUT ANY WARRANTY; without even the implied warranty of" + Constants.vbCrLf + @"
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the" + Constants.vbCrLf + @"
    GNU General Public License for more details." + Constants.vbCrLf + Constants.vbCrLf + @"
    You should have received a copy of the GNU General Public License" + Constants.vbCrLf + @"
    along with this program.  If not, see https://www.gnu.org/licenses/", "License Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            switch (MWComboBoxS.SelectedIndex)
            {
                case 0:
                    {
                        BTPlay.Hide();
                        BTStop.Show();
                        My.MyProject.Computer.Audio.Play(Application.StartupPath + @"\sounds\bd\breakover4.wav", AudioPlayMode.BackgroundLoop);
                        break;
                    }

                case 1:
                    {
                        BTPlay.Hide();
                        BTStop.Show();
                        if (OFDS.ShowDialog() == DialogResult.OK)
                        {
                            My.MyProject.Computer.Audio.Play(My.MySettingsProperty.Settings.BTSoundLocation, AudioPlayMode.BackgroundLoop);
                        }

                        break;
                    }
            }
        }

        private void BTBrowse_Click(object sender, EventArgs e)
        {
            if (OFDS.ShowDialog() == DialogResult.OK)
            {
                My.MySettingsProperty.Settings.BTSoundLocation = OFDS.FileName;
                My.MySettingsProperty.Settings.BTSoundIsDiff = true;
                My.MySettingsProperty.Settings.Save();
            }
            else
            {
                My.MySettingsProperty.Settings.BTSoundLocation = null;
                My.MySettingsProperty.Settings.BTSoundIsDiff = false;
                My.MySettingsProperty.Settings.Save();
            }
        }

        private void BTStop_Click(object sender, EventArgs e)
        {
            BTPlay.Show();
            BTStop.Hide();
            My.MyProject.Computer.Audio.Stop();
        }

        private void colorwheel2_ColorChanged(object sender, EventArgs e)
        {
            Label2.ForeColor = ColorWheel2.Color;
            RTextBox.Text = ColorWheel2.Color.R.ToString();
            GTextBox.Text = ColorWheel2.Color.G.ToString();
            BTextBox.Text = ColorWheel2.Color.B.ToString();
            HexTextBox.Text = ColorWheel2.Color.Name;
            Label2.Text = "Color";
        }

        private void ColorWheel1_ColorChanged(object sender, EventArgs e)
        {
            KnownColorLabel.ForeColor = ColorWheel1.Color;
            RTextBoxFC.Text = ColorWheel1.Color.R.ToString();
            GTextBoxFC.Text = ColorWheel1.Color.G.ToString();
            BTextBoxFC.Text = ColorWheel1.Color.B.ToString();
            HexTextBoxFC.Text = ColorWheel1.Color.Name;
            KnownColorLabel.Text = "Color";
        }

        private void TDComboBoxS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TDComboBoxS.SelectedIndex == 6)
            {
                if (OFDS.ShowDialog() == DialogResult.OK)
                {
                    My.MySettingsProperty.Settings.Sound1Location = OFDS.FileName;
                    My.MySettingsProperty.Settings.Save();
                }
            }
        }
    }
}