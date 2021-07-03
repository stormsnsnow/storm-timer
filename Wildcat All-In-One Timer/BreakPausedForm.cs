using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace UTimer
{
    public partial class BreakPausedForm
    {
        public BreakPausedForm()
        {
            InitializeComponent();
            _Button1.Name = "Button1";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            object sapi;
            sapi = Interaction.CreateObject("Sapi.spvoice");
            sapi.speak("Breaktime Resumed.");
            My.MyProject.Computer.Audio.Play(Application.StartupPath + @"\timesup4.wav");
            My.MyProject.Forms.BreakForm.Show();
            var myCulture = CultureInfo.CurrentCulture;
            var dayOfWeek = myCulture.Calendar.GetDayOfWeek(DateTime.Today);
            string dayName = myCulture.DateTimeFormat.GetDayName(dayOfWeek);
            var datetime = DateTime.Now;
            var datew = DateTime.Now;
            DateTime hourtime = Conversions.ToDate(datetime.Add(new TimeSpan(My.MyProject.Forms.BreakForm.hours, My.MyProject.Forms.BreakForm.minutes, My.MyProject.Forms.BreakForm.seconds)).ToString("HH:mm:ss tt", CultureInfo.InvariantCulture));
            var newdatetime = datew.Add(new TimeSpan(My.MyProject.Forms.BreakForm.hours, My.MyProject.Forms.BreakForm.minutes, My.MyProject.Forms.BreakForm.seconds));
            My.MyProject.Forms.BreakForm.Breaktime();
            My.MyProject.Forms.BreakForm.BreakTimer.Start();
            Close();
        }

        private void BreakDialog_Load(object sender, EventArgs e)
        {
            BackColor = ColorTranslator.FromHtml(My.MySettingsProperty.Settings.BackColor.ToArgb().ToString());
            ForeColor = ColorTranslator.FromHtml(My.MySettingsProperty.Settings.ForeColor.ToArgb().ToString());
        }
    }
}