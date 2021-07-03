using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace UTimer
{
    [DesignerGenerated()]
    public partial class SettingsForm : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            _SaveButtonSettings = new Button();
            _SaveButtonSettings.Click += new EventHandler(SaveButtonSettings_Click);
            _CancelButtonSettings = new Button();
            _CancelButtonSettings.Click += new EventHandler(CancelButtonSettings_Click);
            OFDS = new OpenFileDialog();
            About = new TabPage();
            PictureBox1 = new PictureBox();
            _BtnLicense = new Button();
            _BtnLicense.Click += new EventHandler(BtnLicense_Click);
            lblVersion = new Label();
            lblName = new Label();
            Sounds = new TabPage();
            _BTStop = new Button();
            _BTStop.Click += new EventHandler(BTStop_Click);
            _BTBrowse = new Button();
            _BTBrowse.Click += new EventHandler(BTBrowse_Click);
            _BTPlay = new Button();
            _BTPlay.Click += new EventHandler(Button5_Click);
            Label10 = new Label();
            BTComboBoxSounds = new ComboBox();
            _Button2 = new Button();
            _Button2.Click += new EventHandler(Button2_Click);
            _Button1 = new Button();
            _Button1.Click += new EventHandler(Button1_Click);
            _MWPlayButtonS = new Button();
            _MWPlayButtonS.Click += new EventHandler(MWPlayButtonS_Click);
            _TDPlayButtonS = new Button();
            _TDPlayButtonS.Click += new EventHandler(TDPlayButtonS_Click);
            MWComboBoxS = new ComboBox();
            MWLabelS = new Label();
            TDLabelS = new Label();
            _TDComboBoxS = new ComboBox();
            _TDComboBoxS.SelectedIndexChanged += new EventHandler(TDComboBoxS_SelectedIndexChanged);
            SoundsPromptLabel = new Label();
            _TDStopButtonS = new Button();
            _TDStopButtonS.Click += new EventHandler(TDStopButtonS_Click);
            _MWStopButtonS = new Button();
            _MWStopButtonS.Click += new EventHandler(MWStopButtonS_Click);
            AutoTime = new TabPage();
            TimerControl = new TabControl();
            BreakTimerTab = new TabPage();
            TimerGBBt = new GroupBox();
            VisualRbBt = new RadioButton();
            nudTimeHour = new NumericUpDown();
            AudioRbBt = new RadioButton();
            TimeLabelBt = new Label();
            MWLabelBt = new Label();
            MinWarnNudBt = new NumericUpDown();
            BreakTimerLabelBt = new Label();
            nudTimeMin = new NumericUpDown();
            nudTimeBreakSec = new NumericUpDown();
            nudTimeSec = new NumericUpDown();
            nudTimeBreakMin = new NumericUpDown();
            nudTimeBreakHour = new NumericUpDown();
            BreakGBBt = new GroupBox();
            lblbreak2 = new Label();
            nudb1hour = new NumericUpDown();
            nudb1sec = new NumericUpDown();
            nudb1min = new NumericUpDown();
            TimeRBBt = new RadioButton();
            BreakRBBt = new RadioButton();
            TimerTab = new TabPage();
            nudSec = new NumericUpDown();
            nudMin = new NumericUpDown();
            nudHour = new NumericUpDown();
            ShutdownTabPage = new TabPage();
            ShutdownCbSh = new ComboBox();
            GroupBox1 = new GroupBox();
            VisualRadioButtonSh = new RadioButton();
            HourNudSh = new NumericUpDown();
            AudioRadioButtonSh = new RadioButton();
            TimeLabelSh = new Label();
            MinWarnLabelSh = new Label();
            MinWarnNudSh = new NumericUpDown();
            MinuteNudSh = new NumericUpDown();
            SecondNudSh = new NumericUpDown();
            ImageList1 = new ImageList(components);
            AutoTimeInstructionsLabelAt = new Label();
            General = new TabPage();
            GeneralTabControl = new TabControl();
            DateTimeTabPage = new TabPage();
            Label8 = new Label();
            Label7 = new Label();
            Label6 = new Label();
            _ComboBox1 = new ComboBox();
            _ComboBox1.SelectedIndexChanged += new EventHandler(ComboBox1_SelectedIndexChanged);
            Label1 = new Label();
            DTLabelDTGen2 = new Label();
            DTLabelDTGen = new Label();
            TimeFormatLabelDTGen = new Label();
            DateFormatLabelDTGen = new Label();
            _TimeFormatCbDTGen = new ComboBox();
            _TimeFormatCbDTGen.SelectedIndexChanged += new EventHandler(TimeFormatCbDTGen_SelectedIndexChanged);
            _DateFormatCbDTGen = new ComboBox();
            _DateFormatCbDTGen.SelectedIndexChanged += new EventHandler(DateFormatCbDTGen_SelectedIndexChanged);
            StartupTabPage = new TabPage();
            WDLCTSUCbSUGen = new ComboBox();
            WhenIStartupLabelSUGen = new Label();
            ResetTabPage = new TabPage();
            Label3 = new Label();
            _ResetButtonReGen = new Button();
            _ResetButtonReGen.Click += new EventHandler(ResetButtonReGen_Click);
            ResetPromptLabelReGen = new Label();
            SettingsTC = new TabControl();
            Personalization = new TabPage();
            TabControl1 = new TabControl();
            TabPage1 = new TabPage();
            _ColorWheel2 = new Cyotek.Windows.Forms.ColorWheel();
            _ColorWheel2.ColorChanged += new EventHandler(colorwheel2_ColorChanged);
            HexTextBox = new TextBox();
            Label13 = new Label();
            Label2 = new Label();
            BTextBox = new TextBox();
            ColorLabel = new Label();
            Label12 = new Label();
            HexLabel = new Label();
            GTextBox = new TextBox();
            RTextBox = new TextBox();
            Label11 = new Label();
            TabPage2 = new TabPage();
            _ColorWheel1 = new Cyotek.Windows.Forms.ColorWheel();
            _ColorWheel1.ColorChanged += new EventHandler(ColorWheel1_ColorChanged);
            HexTextBoxFC = new TextBox();
            Label4 = new Label();
            KnownColorLabel = new Label();
            BTextBoxFC = new TextBox();
            Label14 = new Label();
            Label15 = new Label();
            Label16 = new Label();
            GTextBoxFC = new TextBox();
            RTextBoxFC = new TextBox();
            Label17 = new Label();
            Label9 = new Label();
            About.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            Sounds.SuspendLayout();
            AutoTime.SuspendLayout();
            TimerControl.SuspendLayout();
            BreakTimerTab.SuspendLayout();
            TimerGBBt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTimeHour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinWarnNudBt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTimeMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTimeBreakSec).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTimeSec).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTimeBreakMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTimeBreakHour).BeginInit();
            BreakGBBt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudb1hour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudb1sec).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudb1min).BeginInit();
            TimerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSec).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHour).BeginInit();
            ShutdownTabPage.SuspendLayout();
            GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HourNudSh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinWarnNudSh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinuteNudSh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SecondNudSh).BeginInit();
            General.SuspendLayout();
            GeneralTabControl.SuspendLayout();
            DateTimeTabPage.SuspendLayout();
            StartupTabPage.SuspendLayout();
            ResetTabPage.SuspendLayout();
            SettingsTC.SuspendLayout();
            Personalization.SuspendLayout();
            TabControl1.SuspendLayout();
            TabPage1.SuspendLayout();
            TabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // SaveButtonSettings
            // 
            _SaveButtonSettings.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _SaveButtonSettings.Location = new Point(347, 324);
            _SaveButtonSettings.Name = "_SaveButtonSettings";
            _SaveButtonSettings.Size = new Size(75, 25);
            _SaveButtonSettings.TabIndex = 1;
            _SaveButtonSettings.Text = "&Save";
            _SaveButtonSettings.UseVisualStyleBackColor = true;
            // 
            // CancelButtonSettings
            // 
            _CancelButtonSettings.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _CancelButtonSettings.DialogResult = DialogResult.Cancel;
            _CancelButtonSettings.Location = new Point(428, 324);
            _CancelButtonSettings.Name = "_CancelButtonSettings";
            _CancelButtonSettings.Size = new Size(75, 25);
            _CancelButtonSettings.TabIndex = 2;
            _CancelButtonSettings.Text = "&Cancel";
            _CancelButtonSettings.UseVisualStyleBackColor = true;
            // 
            // OFDS
            // 
            OFDS.Filter = "Wave file (*.wav)|*.wav|All files (*.*)|*.*";
            OFDS.RestoreDirectory = true;
            OFDS.Title = "Browse for a sound file";
            // 
            // About
            // 
            About.BackColor = Color.White;
            About.Controls.Add(PictureBox1);
            About.Controls.Add(_BtnLicense);
            About.Controls.Add(lblVersion);
            About.Controls.Add(lblName);
            About.ForeColor = Color.Black;
            About.ImageKey = "2139.png";
            About.Location = new Point(4, 23);
            About.Name = "About";
            About.Size = new Size(496, 291);
            About.TabIndex = 3;
            About.Text = "About";
            // 
            // PictureBox1
            // 
            PictureBox1.Image = (Image)resources.GetObject("PictureBox1.Image");
            PictureBox1.Location = new Point(110, 12);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(69, 67);
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox1.TabIndex = 30;
            PictureBox1.TabStop = false;
            // 
            // BtnLicense
            // 
            _BtnLicense.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _BtnLicense.FlatStyle = FlatStyle.Flat;
            _BtnLicense.Location = new Point(185, 64);
            _BtnLicense.Name = "_BtnLicense";
            _BtnLicense.Size = new Size(75, 25);
            _BtnLicense.TabIndex = 3;
            _BtnLicense.Text = "&License";
            _BtnLicense.UseVisualStyleBackColor = true;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new Point(182, 35);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(144, 26);
            lblVersion.TabIndex = 29;
            lblVersion.Text = "v21.1" + '\r' + '\n' + "Released February 15, 2021";
            lblVersion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblName.Location = new Point(181, 12);
            lblName.Name = "lblName";
            lblName.Size = new Size(153, 23);
            lblName.TabIndex = 28;
            lblName.Text = "Ultimate Timer";
            // 
            // Sounds
            // 
            Sounds.BackColor = Color.White;
            Sounds.Controls.Add(_BTStop);
            Sounds.Controls.Add(_BTBrowse);
            Sounds.Controls.Add(_BTPlay);
            Sounds.Controls.Add(Label10);
            Sounds.Controls.Add(BTComboBoxSounds);
            Sounds.Controls.Add(_Button2);
            Sounds.Controls.Add(_Button1);
            Sounds.Controls.Add(_MWPlayButtonS);
            Sounds.Controls.Add(_TDPlayButtonS);
            Sounds.Controls.Add(MWComboBoxS);
            Sounds.Controls.Add(MWLabelS);
            Sounds.Controls.Add(TDLabelS);
            Sounds.Controls.Add(_TDComboBoxS);
            Sounds.Controls.Add(SoundsPromptLabel);
            Sounds.Controls.Add(_TDStopButtonS);
            Sounds.Controls.Add(_MWStopButtonS);
            Sounds.ImageKey = "1F50A.png";
            Sounds.Location = new Point(4, 23);
            Sounds.Name = "Sounds";
            Sounds.Size = new Size(496, 291);
            Sounds.TabIndex = 2;
            Sounds.Text = "Sounds";
            // 
            // BTStop
            // 
            _BTStop.Location = new Point(225, 153);
            _BTStop.Name = "_BTStop";
            _BTStop.Size = new Size(75, 25);
            _BTStop.TabIndex = 16;
            _BTStop.Text = "Stop";
            _BTStop.UseVisualStyleBackColor = true;
            // 
            // BTBrowse
            // 
            _BTBrowse.Location = new Point(306, 153);
            _BTBrowse.Name = "_BTBrowse";
            _BTBrowse.Size = new Size(75, 25);
            _BTBrowse.TabIndex = 15;
            _BTBrowse.Text = "Browse";
            _BTBrowse.UseVisualStyleBackColor = true;
            // 
            // BTPlay
            // 
            _BTPlay.Location = new Point(225, 153);
            _BTPlay.Name = "_BTPlay";
            _BTPlay.Size = new Size(75, 25);
            _BTPlay.TabIndex = 14;
            _BTPlay.Text = "Play";
            _BTPlay.UseVisualStyleBackColor = true;
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Location = new Point(26, 156);
            Label10.Name = "Label10";
            Label10.Size = new Size(65, 13);
            Label10.TabIndex = 13;
            Label10.Text = "Break Over:";
            // 
            // BTComboBoxSounds
            // 
            BTComboBoxSounds.FormattingEnabled = true;
            BTComboBoxSounds.Items.AddRange(new object[] { "Default Sound", "Browse for sound file..." });
            BTComboBoxSounds.Location = new Point(97, 153);
            BTComboBoxSounds.Name = "BTComboBoxSounds";
            BTComboBoxSounds.Size = new Size(121, 21);
            BTComboBoxSounds.TabIndex = 12;
            // 
            // Button2
            // 
            _Button2.Location = new Point(306, 126);
            _Button2.Name = "_Button2";
            _Button2.Size = new Size(75, 25);
            _Button2.TabIndex = 11;
            _Button2.Text = "Browse";
            _Button2.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            _Button1.Location = new Point(306, 92);
            _Button1.Name = "_Button1";
            _Button1.Size = new Size(75, 25);
            _Button1.TabIndex = 10;
            _Button1.Text = "Browse";
            _Button1.UseVisualStyleBackColor = true;
            // 
            // MWPlayButtonS
            // 
            _MWPlayButtonS.Location = new Point(225, 126);
            _MWPlayButtonS.Name = "_MWPlayButtonS";
            _MWPlayButtonS.Size = new Size(75, 25);
            _MWPlayButtonS.TabIndex = 7;
            _MWPlayButtonS.Text = "Play";
            _MWPlayButtonS.UseVisualStyleBackColor = true;
            // 
            // TDPlayButtonS
            // 
            _TDPlayButtonS.Location = new Point(225, 92);
            _TDPlayButtonS.Name = "_TDPlayButtonS";
            _TDPlayButtonS.Size = new Size(75, 25);
            _TDPlayButtonS.TabIndex = 6;
            _TDPlayButtonS.Text = "Play";
            _TDPlayButtonS.UseVisualStyleBackColor = true;
            // 
            // MWComboBoxS
            // 
            MWComboBoxS.FormattingEnabled = true;
            MWComboBoxS.Items.AddRange(new object[] { "Default Sound", "Twinkle", "Bubbles 1", "Airbus", "Bubbles 2", "211 Default", "Pop", "Browse For sound" });
            MWComboBoxS.Location = new Point(97, 126);
            MWComboBoxS.Name = "MWComboBoxS";
            MWComboBoxS.Size = new Size(121, 21);
            MWComboBoxS.TabIndex = 5;
            // 
            // MWLabelS
            // 
            MWLabelS.AutoSize = true;
            MWLabelS.Location = new Point(38, 129);
            MWLabelS.Name = "MWLabelS";
            MWLabelS.Size = new Size(53, 13);
            MWLabelS.TabIndex = 4;
            MWLabelS.Text = "MinWarn:";
            // 
            // TDLabelS
            // 
            TDLabelS.AutoSize = true;
            TDLabelS.Location = new Point(26, 95);
            TDLabelS.Name = "TDLabelS";
            TDLabelS.Size = new Size(65, 13);
            TDLabelS.TabIndex = 3;
            TDLabelS.Text = "Timer Done:";
            // 
            // TDComboBoxS
            // 
            _TDComboBoxS.FormattingEnabled = true;
            _TDComboBoxS.Items.AddRange(new object[] { "Default Sound", "Aquatics Nearby", "Fast and Furious", "Foghorn Leghorn", "211 Default", "Speed Demon", "Browse for sound" });
            _TDComboBoxS.Location = new Point(97, 92);
            _TDComboBoxS.Name = "_TDComboBoxS";
            _TDComboBoxS.Size = new Size(121, 21);
            _TDComboBoxS.TabIndex = 2;
            // 
            // SoundsPromptLabel
            // 
            SoundsPromptLabel.AutoSize = true;
            SoundsPromptLabel.Location = new Point(8, 11);
            SoundsPromptLabel.Name = "SoundsPromptLabel";
            SoundsPromptLabel.Size = new Size(243, 52);
            SoundsPromptLabel.TabIndex = 1;
            SoundsPromptLabel.Text = "With sounds, the program can alert you of when " + '\r' + '\n' + "your timer is done, your timer h" + "as an exact" + '\r' + '\n' + "number of minutes left, or when your break is " + '\r' + '\n' + "over.";
            // 
            // TDStopButtonS
            // 
            _TDStopButtonS.Location = new Point(225, 92);
            _TDStopButtonS.Name = "_TDStopButtonS";
            _TDStopButtonS.Size = new Size(75, 25);
            _TDStopButtonS.TabIndex = 8;
            _TDStopButtonS.Text = "Stop";
            _TDStopButtonS.UseVisualStyleBackColor = true;
            // 
            // MWStopButtonS
            // 
            _MWStopButtonS.Location = new Point(224, 126);
            _MWStopButtonS.Name = "_MWStopButtonS";
            _MWStopButtonS.Size = new Size(75, 25);
            _MWStopButtonS.TabIndex = 9;
            _MWStopButtonS.Text = "Stop";
            _MWStopButtonS.UseVisualStyleBackColor = true;
            // 
            // AutoTime
            // 
            AutoTime.BackColor = Color.White;
            AutoTime.Controls.Add(TimerControl);
            AutoTime.Controls.Add(AutoTimeInstructionsLabelAt);
            AutoTime.ImageKey = "favicon (6).ico";
            AutoTime.Location = new Point(4, 23);
            AutoTime.Name = "AutoTime";
            AutoTime.Padding = new Padding(3);
            AutoTime.Size = new Size(496, 291);
            AutoTime.TabIndex = 1;
            AutoTime.Text = "AutoTime";
            // 
            // TimerControl
            // 
            TimerControl.Controls.Add(BreakTimerTab);
            TimerControl.Controls.Add(TimerTab);
            TimerControl.Controls.Add(ShutdownTabPage);
            TimerControl.Dock = DockStyle.Bottom;
            TimerControl.ImageList = ImageList1;
            TimerControl.Location = new Point(3, 59);
            TimerControl.Multiline = true;
            TimerControl.Name = "TimerControl";
            TimerControl.SelectedIndex = 0;
            TimerControl.Size = new Size(490, 229);
            TimerControl.TabIndex = 25;
            // 
            // BreakTimerTab
            // 
            BreakTimerTab.BackColor = Color.White;
            BreakTimerTab.Controls.Add(TimerGBBt);
            BreakTimerTab.Controls.Add(BreakGBBt);
            BreakTimerTab.Controls.Add(TimeRBBt);
            BreakTimerTab.Controls.Add(BreakRBBt);
            BreakTimerTab.ImageKey = "favicon (5).ico";
            BreakTimerTab.Location = new Point(4, 23);
            BreakTimerTab.Name = "BreakTimerTab";
            BreakTimerTab.Padding = new Padding(3);
            BreakTimerTab.Size = new Size(482, 202);
            BreakTimerTab.TabIndex = 0;
            BreakTimerTab.Text = "Break Timer";
            // 
            // TimerGBBt
            // 
            TimerGBBt.Controls.Add(VisualRbBt);
            TimerGBBt.Controls.Add(nudTimeHour);
            TimerGBBt.Controls.Add(AudioRbBt);
            TimerGBBt.Controls.Add(TimeLabelBt);
            TimerGBBt.Controls.Add(MWLabelBt);
            TimerGBBt.Controls.Add(MinWarnNudBt);
            TimerGBBt.Controls.Add(BreakTimerLabelBt);
            TimerGBBt.Controls.Add(nudTimeMin);
            TimerGBBt.Controls.Add(nudTimeBreakSec);
            TimerGBBt.Controls.Add(nudTimeSec);
            TimerGBBt.Controls.Add(nudTimeBreakMin);
            TimerGBBt.Controls.Add(nudTimeBreakHour);
            TimerGBBt.Location = new Point(256, 6);
            TimerGBBt.Name = "TimerGBBt";
            TimerGBBt.Size = new Size(218, 115);
            TimerGBBt.TabIndex = 49;
            TimerGBBt.TabStop = false;
            TimerGBBt.Text = "Timer Settings";
            // 
            // VisualRbBt
            // 
            VisualRbBt.AutoSize = true;
            VisualRbBt.Location = new Point(118, 93);
            VisualRbBt.Name = "VisualRbBt";
            VisualRbBt.Size = new Size(52, 17);
            VisualRbBt.TabIndex = 62;
            VisualRbBt.TabStop = true;
            VisualRbBt.Text = "Visual";
            VisualRbBt.UseVisualStyleBackColor = true;
            // 
            // nudTimeHour
            // 
            nudTimeHour.ForeColor = SystemColors.ControlText;
            nudTimeHour.Location = new Point(72, 20);
            nudTimeHour.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            nudTimeHour.Name = "nudTimeHour";
            nudTimeHour.Size = new Size(42, 21);
            nudTimeHour.TabIndex = 34;
            // 
            // AudioRbBt
            // 
            AudioRbBt.AutoSize = true;
            AudioRbBt.Location = new Point(118, 76);
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
            TimeLabelBt.Location = new Point(24, 20);
            TimeLabelBt.Name = "TimeLabelBt";
            TimeLabelBt.Size = new Size(33, 13);
            TimeLabelBt.TabIndex = 29;
            TimeLabelBt.Text = "Time:";
            // 
            // MWLabelBt
            // 
            MWLabelBt.AutoSize = true;
            MWLabelBt.Location = new Point(6, 84);
            MWLabelBt.Name = "MWLabelBt";
            MWLabelBt.Size = new Size(53, 13);
            MWLabelBt.TabIndex = 43;
            MWLabelBt.Text = "MinWarn:";
            // 
            // MinWarnNudBt
            // 
            MinWarnNudBt.Location = new Point(72, 82);
            MinWarnNudBt.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            MinWarnNudBt.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            MinWarnNudBt.Name = "MinWarnNudBt";
            MinWarnNudBt.Size = new Size(40, 21);
            MinWarnNudBt.TabIndex = 60;
            MinWarnNudBt.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // BreakTimerLabelBt
            // 
            BreakTimerLabelBt.AutoSize = true;
            BreakTimerLabelBt.Location = new Point(19, 54);
            BreakTimerLabelBt.Name = "BreakTimerLabelBt";
            BreakTimerLabelBt.Size = new Size(38, 13);
            BreakTimerLabelBt.TabIndex = 31;
            BreakTimerLabelBt.Text = "Break:";
            // 
            // nudTimeMin
            // 
            nudTimeMin.ForeColor = SystemColors.ControlText;
            nudTimeMin.Location = new Point(120, 20);
            nudTimeMin.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            nudTimeMin.Name = "nudTimeMin";
            nudTimeMin.Size = new Size(41, 21);
            nudTimeMin.TabIndex = 35;
            // 
            // nudTimeBreakSec
            // 
            nudTimeBreakSec.ForeColor = SystemColors.ControlText;
            nudTimeBreakSec.Location = new Point(167, 52);
            nudTimeBreakSec.Name = "nudTimeBreakSec";
            nudTimeBreakSec.Size = new Size(40, 21);
            nudTimeBreakSec.TabIndex = 39;
            // 
            // nudTimeSec
            // 
            nudTimeSec.ForeColor = SystemColors.ControlText;
            nudTimeSec.Location = new Point(167, 20);
            nudTimeSec.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            nudTimeSec.Name = "nudTimeSec";
            nudTimeSec.Size = new Size(40, 21);
            nudTimeSec.TabIndex = 36;
            // 
            // nudTimeBreakMin
            // 
            nudTimeBreakMin.ForeColor = SystemColors.ControlText;
            nudTimeBreakMin.Location = new Point(120, 52);
            nudTimeBreakMin.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            nudTimeBreakMin.Name = "nudTimeBreakMin";
            nudTimeBreakMin.Size = new Size(41, 21);
            nudTimeBreakMin.TabIndex = 38;
            // 
            // nudTimeBreakHour
            // 
            nudTimeBreakHour.ForeColor = SystemColors.ControlText;
            nudTimeBreakHour.Location = new Point(72, 52);
            nudTimeBreakHour.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            nudTimeBreakHour.Name = "nudTimeBreakHour";
            nudTimeBreakHour.Size = new Size(42, 21);
            nudTimeBreakHour.TabIndex = 37;
            // 
            // BreakGBBt
            // 
            BreakGBBt.Controls.Add(lblbreak2);
            BreakGBBt.Controls.Add(nudb1hour);
            BreakGBBt.Controls.Add(nudb1sec);
            BreakGBBt.Controls.Add(nudb1min);
            BreakGBBt.Location = new Point(32, 47);
            BreakGBBt.Name = "BreakGBBt";
            BreakGBBt.Size = new Size(218, 54);
            BreakGBBt.TabIndex = 52;
            BreakGBBt.TabStop = false;
            BreakGBBt.Text = "Break Settings";
            // 
            // lblbreak2
            // 
            lblbreak2.AutoSize = true;
            lblbreak2.ForeColor = SystemColors.ControlText;
            lblbreak2.Location = new Point(11, 17);
            lblbreak2.Name = "lblbreak2";
            lblbreak2.Size = new Size(38, 13);
            lblbreak2.TabIndex = 33;
            lblbreak2.Text = "Break:";
            // 
            // nudb1hour
            // 
            nudb1hour.ForeColor = SystemColors.ControlText;
            nudb1hour.Location = new Point(61, 15);
            nudb1hour.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            nudb1hour.Name = "nudb1hour";
            nudb1hour.Size = new Size(37, 21);
            nudb1hour.TabIndex = 40;
            // 
            // nudb1sec
            // 
            nudb1sec.ForeColor = SystemColors.ControlText;
            nudb1sec.Location = new Point(149, 15);
            nudb1sec.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            nudb1sec.Name = "nudb1sec";
            nudb1sec.Size = new Size(42, 21);
            nudb1sec.TabIndex = 42;
            // 
            // nudb1min
            // 
            nudb1min.ForeColor = SystemColors.ControlText;
            nudb1min.Location = new Point(104, 15);
            nudb1min.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            nudb1min.Name = "nudb1min";
            nudb1min.Size = new Size(39, 21);
            nudb1min.TabIndex = 41;
            // 
            // TimeRBBt
            // 
            TimeRBBt.AutoSize = true;
            TimeRBBt.Location = new Point(46, 23);
            TimeRBBt.Name = "TimeRBBt";
            TimeRBBt.Size = new Size(66, 17);
            TimeRBBt.TabIndex = 45;
            TimeRBBt.Text = "Set Time";
            TimeRBBt.UseVisualStyleBackColor = false;
            // 
            // BreakRBBt
            // 
            BreakRBBt.AutoSize = true;
            BreakRBBt.Location = new Point(140, 23);
            BreakRBBt.Name = "BreakRBBt";
            BreakRBBt.Size = new Size(71, 17);
            BreakRBBt.TabIndex = 48;
            BreakRBBt.Text = "Set Break";
            BreakRBBt.UseVisualStyleBackColor = false;
            // 
            // TimerTab
            // 
            TimerTab.BackColor = Color.White;
            TimerTab.Controls.Add(nudSec);
            TimerTab.Controls.Add(nudMin);
            TimerTab.Controls.Add(nudHour);
            TimerTab.ImageKey = "favicon (6).ico";
            TimerTab.Location = new Point(4, 23);
            TimerTab.Name = "TimerTab";
            TimerTab.Padding = new Padding(3);
            TimerTab.Size = new Size(482, 202);
            TimerTab.TabIndex = 1;
            TimerTab.Text = "Timer";
            // 
            // nudSec
            // 
            nudSec.Location = new Point(253, 30);
            nudSec.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            nudSec.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSec.Name = "nudSec";
            nudSec.Size = new Size(50, 21);
            nudSec.TabIndex = 10;
            nudSec.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudMin
            // 
            nudMin.Location = new Point(197, 30);
            nudMin.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            nudMin.Name = "nudMin";
            nudMin.Size = new Size(50, 21);
            nudMin.TabIndex = 9;
            // 
            // nudHour
            // 
            nudHour.Location = new Point(141, 30);
            nudHour.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            nudHour.Name = "nudHour";
            nudHour.Size = new Size(50, 21);
            nudHour.TabIndex = 8;
            // 
            // ShutdownTabPage
            // 
            ShutdownTabPage.BackColor = Color.White;
            ShutdownTabPage.Controls.Add(ShutdownCbSh);
            ShutdownTabPage.Controls.Add(GroupBox1);
            ShutdownTabPage.ImageKey = "1F50C.png";
            ShutdownTabPage.Location = new Point(4, 23);
            ShutdownTabPage.Name = "ShutdownTabPage";
            ShutdownTabPage.Padding = new Padding(3);
            ShutdownTabPage.Size = new Size(482, 202);
            ShutdownTabPage.TabIndex = 4;
            ShutdownTabPage.Text = "Shutdown";
            // 
            // ShutdownCbSh
            // 
            ShutdownCbSh.FormattingEnabled = true;
            ShutdownCbSh.Items.AddRange(new object[] { "Log off", "Power Off", "Reboot", "Shutdown", "Suspend", "Hibernate" });
            ShutdownCbSh.Location = new Point(47, 27);
            ShutdownCbSh.Name = "ShutdownCbSh";
            ShutdownCbSh.Size = new Size(218, 21);
            ShutdownCbSh.TabIndex = 100;
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(VisualRadioButtonSh);
            GroupBox1.Controls.Add(HourNudSh);
            GroupBox1.Controls.Add(AudioRadioButtonSh);
            GroupBox1.Controls.Add(TimeLabelSh);
            GroupBox1.Controls.Add(MinWarnLabelSh);
            GroupBox1.Controls.Add(MinWarnNudSh);
            GroupBox1.Controls.Add(MinuteNudSh);
            GroupBox1.Controls.Add(SecondNudSh);
            GroupBox1.Location = new Point(47, 56);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(218, 93);
            GroupBox1.TabIndex = 85;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "In Settings";
            // 
            // VisualRadioButtonSh
            // 
            VisualRadioButtonSh.AutoSize = true;
            VisualRadioButtonSh.Location = new Point(136, 70);
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
            HourNudSh.Location = new Point(72, 20);
            HourNudSh.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            HourNudSh.Name = "HourNudSh";
            HourNudSh.Size = new Size(42, 21);
            HourNudSh.TabIndex = 34;
            // 
            // AudioRadioButtonSh
            // 
            AudioRadioButtonSh.AutoSize = true;
            AudioRadioButtonSh.Location = new Point(136, 54);
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
            TimeLabelSh.Location = new Point(24, 20);
            TimeLabelSh.Name = "TimeLabelSh";
            TimeLabelSh.Size = new Size(33, 13);
            TimeLabelSh.TabIndex = 29;
            TimeLabelSh.Text = "Time:";
            // 
            // MinWarnLabelSh
            // 
            MinWarnLabelSh.AutoSize = true;
            MinWarnLabelSh.Location = new Point(24, 61);
            MinWarnLabelSh.Name = "MinWarnLabelSh";
            MinWarnLabelSh.Size = new Size(53, 13);
            MinWarnLabelSh.TabIndex = 43;
            MinWarnLabelSh.Text = "MinWarn:";
            // 
            // MinWarnNudSh
            // 
            MinWarnNudSh.Location = new Point(90, 59);
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
            MinuteNudSh.Location = new Point(120, 20);
            MinuteNudSh.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            MinuteNudSh.Name = "MinuteNudSh";
            MinuteNudSh.Size = new Size(41, 21);
            MinuteNudSh.TabIndex = 35;
            // 
            // SecondNudSh
            // 
            SecondNudSh.ForeColor = SystemColors.ControlText;
            SecondNudSh.Location = new Point(167, 20);
            SecondNudSh.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            SecondNudSh.Name = "SecondNudSh";
            SecondNudSh.Size = new Size(40, 21);
            SecondNudSh.TabIndex = 36;
            // 
            // ImageList1
            // 
            ImageList1.ImageStream = (ImageListStreamer)resources.GetObject("ImageList1.ImageStream");
            ImageList1.TransparentColor = Color.Transparent;
            ImageList1.Images.SetKeyName(0, "favicon (5).ico");
            ImageList1.Images.SetKeyName(1, "1F50A.png");
            ImageList1.Images.SetKeyName(2, "2139.png");
            ImageList1.Images.SetKeyName(3, "2699.png");
            ImageList1.Images.SetKeyName(4, "favicon (6).ico");
            ImageList1.Images.SetKeyName(5, "1F50C.png");
            ImageList1.Images.SetKeyName(6, "favicon (4).ico");
            // 
            // AutoTimeInstructionsLabelAt
            // 
            AutoTimeInstructionsLabelAt.AutoSize = true;
            AutoTimeInstructionsLabelAt.Location = new Point(4, 3);
            AutoTimeInstructionsLabelAt.Name = "AutoTimeInstructionsLabelAt";
            AutoTimeInstructionsLabelAt.Size = new Size(404, 52);
            AutoTimeInstructionsLabelAt.TabIndex = 0;
            AutoTimeInstructionsLabelAt.Text = resources.GetString("AutoTimeInstructionsLabelAt.Text");
            // 
            // General
            // 
            General.BackColor = Color.White;
            General.Controls.Add(GeneralTabControl);
            General.ImageIndex = 3;
            General.Location = new Point(4, 23);
            General.Name = "General";
            General.Padding = new Padding(3);
            General.Size = new Size(496, 291);
            General.TabIndex = 0;
            General.Text = "General";
            // 
            // GeneralTabControl
            // 
            GeneralTabControl.Controls.Add(DateTimeTabPage);
            GeneralTabControl.Controls.Add(StartupTabPage);
            GeneralTabControl.Controls.Add(ResetTabPage);
            GeneralTabControl.Dock = DockStyle.Fill;
            GeneralTabControl.Location = new Point(3, 3);
            GeneralTabControl.Name = "GeneralTabControl";
            GeneralTabControl.SelectedIndex = 0;
            GeneralTabControl.Size = new Size(490, 285);
            GeneralTabControl.TabIndex = 8;
            // 
            // DateTimeTabPage
            // 
            DateTimeTabPage.Controls.Add(Label8);
            DateTimeTabPage.Controls.Add(Label7);
            DateTimeTabPage.Controls.Add(Label6);
            DateTimeTabPage.Controls.Add(_ComboBox1);
            DateTimeTabPage.Controls.Add(Label1);
            DateTimeTabPage.Controls.Add(DTLabelDTGen2);
            DateTimeTabPage.Controls.Add(DTLabelDTGen);
            DateTimeTabPage.Controls.Add(TimeFormatLabelDTGen);
            DateTimeTabPage.Controls.Add(DateFormatLabelDTGen);
            DateTimeTabPage.Controls.Add(_TimeFormatCbDTGen);
            DateTimeTabPage.Controls.Add(_DateFormatCbDTGen);
            DateTimeTabPage.Location = new Point(4, 22);
            DateTimeTabPage.Name = "DateTimeTabPage";
            DateTimeTabPage.Padding = new Padding(3);
            DateTimeTabPage.Size = new Size(482, 259);
            DateTimeTabPage.TabIndex = 0;
            DateTimeTabPage.Text = "Date/Time";
            DateTimeTabPage.UseVisualStyleBackColor = true;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Location = new Point(209, 141);
            Label8.Name = "Label8";
            Label8.Size = new Size(97, 13);
            Label8.TabIndex = 31;
            Label8.Text = "Date/Time Format:";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Location = new Point(188, 191);
            Label7.Name = "Label7";
            Label7.Size = new Size(118, 13);
            Label7.TabIndex = 30;
            Label7.Text = "Date Format for Break:";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Location = new Point(126, 87);
            Label6.Name = "Label6";
            Label6.Size = new Size(118, 13);
            Label6.TabIndex = 29;
            Label6.Text = "Date Format for Break:";
            // 
            // ComboBox1
            // 
            _ComboBox1.FormattingEnabled = true;
            _ComboBox1.Items.AddRange(new object[] { "200101", "20200101", "01/01/20", "21/01/20", "01/01/2020", "1577836800" });
            _ComboBox1.Location = new Point(250, 84);
            _ComboBox1.Name = "_ComboBox1";
            _ComboBox1.Size = new Size(100, 21);
            _ComboBox1.TabIndex = 27;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(179, 204);
            Label1.Name = "Label1";
            Label1.Size = new Size(150, 13);
            Label1.TabIndex = 28;
            Label1.Text = "Wednesday, January 1, 2022";
            // 
            // DTLabelDTGen2
            // 
            DTLabelDTGen2.AutoSize = true;
            DTLabelDTGen2.Location = new Point(215, 167);
            DTLabelDTGen2.Name = "DTLabelDTGen2";
            DTLabelDTGen2.Size = new Size(68, 13);
            DTLabelDTGen2.TabIndex = 26;
            DTLabelDTGen2.Text = "12:08:00 PM";
            // 
            // DTLabelDTGen
            // 
            DTLabelDTGen.AutoSize = true;
            DTLabelDTGen.Location = new Point(182, 154);
            DTLabelDTGen.Name = "DTLabelDTGen";
            DTLabelDTGen.Size = new Size(150, 13);
            DTLabelDTGen.TabIndex = 25;
            DTLabelDTGen.Text = "Wednesday, January 1, 2022";
            // 
            // TimeFormatLabelDTGen
            // 
            TimeFormatLabelDTGen.AutoSize = true;
            TimeFormatLabelDTGen.Location = new Point(126, 60);
            TimeFormatLabelDTGen.Name = "TimeFormatLabelDTGen";
            TimeFormatLabelDTGen.Size = new Size(70, 13);
            TimeFormatLabelDTGen.TabIndex = 24;
            TimeFormatLabelDTGen.Text = "Time Format:";
            // 
            // DateFormatLabelDTGen
            // 
            DateFormatLabelDTGen.AutoSize = true;
            DateFormatLabelDTGen.Location = new Point(128, 34);
            DateFormatLabelDTGen.Name = "DateFormatLabelDTGen";
            DateFormatLabelDTGen.Size = new Size(71, 13);
            DateFormatLabelDTGen.TabIndex = 23;
            DateFormatLabelDTGen.Text = "Date Format:";
            // 
            // TimeFormatCbDTGen
            // 
            _TimeFormatCbDTGen.FormattingEnabled = true;
            _TimeFormatCbDTGen.Items.AddRange(new object[] { "12:08:00 PM", "12:08:00", "12:08 PM", "12:08", "1577836800", "12:08 PM UTC" });
            _TimeFormatCbDTGen.Location = new Point(200, 57);
            _TimeFormatCbDTGen.Name = "_TimeFormatCbDTGen";
            _TimeFormatCbDTGen.Size = new Size(150, 21);
            _TimeFormatCbDTGen.TabIndex = 22;
            // 
            // DateFormatCbDTGen
            // 
            _DateFormatCbDTGen.FormattingEnabled = true;
            _DateFormatCbDTGen.Items.AddRange(new object[] { "200101", "20200101", "Tuesday, January 1, 2020", "January 1, 2020", "Jan 1, 20", "Jan 1, 2020", "01/01/20", "21/01/20", "1577836800" });
            _DateFormatCbDTGen.Location = new Point(201, 30);
            _DateFormatCbDTGen.Name = "_DateFormatCbDTGen";
            _DateFormatCbDTGen.Size = new Size(150, 21);
            _DateFormatCbDTGen.TabIndex = 21;
            // 
            // StartupTabPage
            // 
            StartupTabPage.Controls.Add(WDLCTSUCbSUGen);
            StartupTabPage.Controls.Add(WhenIStartupLabelSUGen);
            StartupTabPage.Location = new Point(4, 22);
            StartupTabPage.Name = "StartupTabPage";
            StartupTabPage.Padding = new Padding(3);
            StartupTabPage.Size = new Size(482, 259);
            StartupTabPage.TabIndex = 3;
            StartupTabPage.Text = "Startup";
            StartupTabPage.UseVisualStyleBackColor = true;
            // 
            // WDLCTSUCbSUGen
            // 
            WDLCTSUCbSUGen.FormattingEnabled = true;
            WDLCTSUCbSUGen.Items.AddRange(new object[] { "Go to the break timer tab", "Go to the timer tab", "Go to the alarm tab", "Go to the stopwatch tab", "Go to the shutdown timer tab" });
            WDLCTSUCbSUGen.Location = new Point(9, 21);
            WDLCTSUCbSUGen.Name = "WDLCTSUCbSUGen";
            WDLCTSUCbSUGen.Size = new Size(227, 21);
            WDLCTSUCbSUGen.TabIndex = 8;
            // 
            // WhenIStartupLabelSUGen
            // 
            WhenIStartupLabelSUGen.AutoSize = true;
            WhenIStartupLabelSUGen.Location = new Point(6, 3);
            WhenIStartupLabelSUGen.Name = "WhenIStartupLabelSUGen";
            WhenIStartupLabelSUGen.Size = new Size(151, 13);
            WhenIStartupLabelSUGen.TabIndex = 7;
            WhenIStartupLabelSUGen.Text = "When I start Ultimate Timer...";
            // 
            // ResetTabPage
            // 
            ResetTabPage.BackColor = Color.DarkRed;
            ResetTabPage.Controls.Add(Label3);
            ResetTabPage.Controls.Add(_ResetButtonReGen);
            ResetTabPage.Controls.Add(ResetPromptLabelReGen);
            ResetTabPage.ForeColor = Color.Red;
            ResetTabPage.Location = new Point(4, 22);
            ResetTabPage.Name = "ResetTabPage";
            ResetTabPage.Size = new Size(482, 259);
            ResetTabPage.TabIndex = 2;
            ResetTabPage.Text = "Danger Zone!";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.Location = new Point(13, 14);
            Label3.Name = "Label3";
            Label3.Size = new Size(117, 23);
            Label3.TabIndex = 15;
            Label3.Text = "WARNING!";
            // 
            // ResetButtonReGen
            // 
            _ResetButtonReGen.Location = new Point(17, 66);
            _ResetButtonReGen.Name = "_ResetButtonReGen";
            _ResetButtonReGen.Size = new Size(186, 52);
            _ResetButtonReGen.TabIndex = 14;
            _ResetButtonReGen.Text = "Reset Ultimate Timer" + '\r' + '\n' + "DO NOT PRESS UNLESS DOING ON PURPOSE!!";
            _ResetButtonReGen.UseVisualStyleBackColor = true;
            // 
            // ResetPromptLabelReGen
            // 
            ResetPromptLabelReGen.AutoSize = true;
            ResetPromptLabelReGen.Location = new Point(14, 37);
            ResetPromptLabelReGen.Name = "ResetPromptLabelReGen";
            ResetPromptLabelReGen.Size = new Size(206, 26);
            ResetPromptLabelReGen.TabIndex = 13;
            ResetPromptLabelReGen.Text = "Any actions that you do on this page are " + '\r' + '\n' + "IRREVERSABLE AND IRRECOVERABLE!" + '\r' + '\n';
            // 
            // SettingsTC
            // 
            SettingsTC.Controls.Add(General);
            SettingsTC.Controls.Add(AutoTime);
            SettingsTC.Controls.Add(Personalization);
            SettingsTC.Controls.Add(Sounds);
            SettingsTC.Controls.Add(About);
            SettingsTC.Dock = DockStyle.Top;
            SettingsTC.ImageList = ImageList1;
            SettingsTC.Location = new Point(0, 0);
            SettingsTC.Name = "SettingsTC";
            SettingsTC.SelectedIndex = 0;
            SettingsTC.Size = new Size(504, 318);
            SettingsTC.TabIndex = 0;
            // 
            // Personalization
            // 
            Personalization.Controls.Add(TabControl1);
            Personalization.Controls.Add(Label9);
            Personalization.ImageIndex = 6;
            Personalization.Location = new Point(4, 23);
            Personalization.Name = "Personalization";
            Personalization.Padding = new Padding(3);
            Personalization.Size = new Size(496, 291);
            Personalization.TabIndex = 7;
            Personalization.Text = "Personalization";
            Personalization.UseVisualStyleBackColor = true;
            // 
            // TabControl1
            // 
            TabControl1.Controls.Add(TabPage1);
            TabControl1.Controls.Add(TabPage2);
            TabControl1.Location = new Point(6, 37);
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new Size(487, 254);
            TabControl1.TabIndex = 14;
            // 
            // TabPage1
            // 
            TabPage1.Controls.Add(_ColorWheel2);
            TabPage1.Controls.Add(HexTextBox);
            TabPage1.Controls.Add(Label13);
            TabPage1.Controls.Add(Label2);
            TabPage1.Controls.Add(BTextBox);
            TabPage1.Controls.Add(ColorLabel);
            TabPage1.Controls.Add(Label12);
            TabPage1.Controls.Add(HexLabel);
            TabPage1.Controls.Add(GTextBox);
            TabPage1.Controls.Add(RTextBox);
            TabPage1.Controls.Add(Label11);
            TabPage1.Location = new Point(4, 22);
            TabPage1.Name = "TabPage1";
            TabPage1.Padding = new Padding(3);
            TabPage1.Size = new Size(479, 228);
            TabPage1.TabIndex = 0;
            TabPage1.Text = "Fore Color";
            TabPage1.UseVisualStyleBackColor = true;
            // 
            // ColorWheel2
            // 
            _ColorWheel2.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _ColorWheel2.Location = new Point(8, 30);
            _ColorWheel2.Name = "_ColorWheel2";
            _ColorWheel2.Size = new Size(179, 164);
            _ColorWheel2.TabIndex = 14;
            // 
            // HexTextBox
            // 
            HexTextBox.Location = new Point(255, 70);
            HexTextBox.Name = "HexTextBox";
            HexTextBox.Size = new Size(56, 21);
            HexTextBox.TabIndex = 6;
            // 
            // Label13
            // 
            Label13.AutoSize = true;
            Label13.Location = new Point(324, 127);
            Label13.Name = "Label13";
            Label13.Size = new Size(17, 13);
            Label13.TabIndex = 13;
            Label13.Text = "B:";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(258, 94);
            Label2.Name = "Label2";
            Label2.Size = new Size(32, 13);
            Label2.TabIndex = 2;
            Label2.Text = "Color";
            // 
            // BTextBox
            // 
            BTextBox.Location = new Point(360, 124);
            BTextBox.Name = "BTextBox";
            BTextBox.Size = new Size(56, 21);
            BTextBox.TabIndex = 12;
            // 
            // ColorLabel
            // 
            ColorLabel.AutoSize = true;
            ColorLabel.Location = new Point(216, 94);
            ColorLabel.Name = "ColorLabel";
            ColorLabel.Size = new Size(36, 13);
            ColorLabel.TabIndex = 5;
            ColorLabel.Text = "Color:";
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.Location = new Point(324, 100);
            Label12.Name = "Label12";
            Label12.Size = new Size(18, 13);
            Label12.TabIndex = 11;
            Label12.Text = "G:";
            // 
            // HexLabel
            // 
            HexLabel.AutoSize = true;
            HexLabel.Location = new Point(219, 73);
            HexLabel.Name = "HexLabel";
            HexLabel.Size = new Size(30, 13);
            HexLabel.TabIndex = 7;
            HexLabel.Text = "Hex:";
            // 
            // GTextBox
            // 
            GTextBox.Location = new Point(360, 97);
            GTextBox.Name = "GTextBox";
            GTextBox.Size = new Size(56, 21);
            GTextBox.TabIndex = 10;
            // 
            // RTextBox
            // 
            RTextBox.Location = new Point(360, 70);
            RTextBox.Name = "RTextBox";
            RTextBox.Size = new Size(56, 21);
            RTextBox.TabIndex = 8;
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.Location = new Point(324, 73);
            Label11.Name = "Label11";
            Label11.Size = new Size(18, 13);
            Label11.TabIndex = 9;
            Label11.Text = "R:";
            // 
            // TabPage2
            // 
            TabPage2.Controls.Add(_ColorWheel1);
            TabPage2.Controls.Add(HexTextBoxFC);
            TabPage2.Controls.Add(Label4);
            TabPage2.Controls.Add(KnownColorLabel);
            TabPage2.Controls.Add(BTextBoxFC);
            TabPage2.Controls.Add(Label14);
            TabPage2.Controls.Add(Label15);
            TabPage2.Controls.Add(Label16);
            TabPage2.Controls.Add(GTextBoxFC);
            TabPage2.Controls.Add(RTextBoxFC);
            TabPage2.Controls.Add(Label17);
            TabPage2.Location = new Point(4, 22);
            TabPage2.Name = "TabPage2";
            TabPage2.Padding = new Padding(3);
            TabPage2.Size = new Size(479, 228);
            TabPage2.TabIndex = 1;
            TabPage2.Text = "Back Color";
            TabPage2.UseVisualStyleBackColor = true;
            // 
            // ColorWheel1
            // 
            _ColorWheel1.Color = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _ColorWheel1.Location = new Point(35, 32);
            _ColorWheel1.Name = "_ColorWheel1";
            _ColorWheel1.Size = new Size(179, 164);
            _ColorWheel1.TabIndex = 25;
            // 
            // HexTextBoxFC
            // 
            HexTextBoxFC.Location = new Point(282, 72);
            HexTextBoxFC.Name = "HexTextBoxFC";
            HexTextBoxFC.Size = new Size(56, 21);
            HexTextBoxFC.TabIndex = 17;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(351, 129);
            Label4.Name = "Label4";
            Label4.Size = new Size(17, 13);
            Label4.TabIndex = 24;
            Label4.Text = "B:";
            // 
            // KnownColorLabel
            // 
            KnownColorLabel.AutoSize = true;
            KnownColorLabel.Location = new Point(285, 96);
            KnownColorLabel.Name = "KnownColorLabel";
            KnownColorLabel.Size = new Size(32, 13);
            KnownColorLabel.TabIndex = 15;
            KnownColorLabel.Text = "Color";
            // 
            // BTextBoxFC
            // 
            BTextBoxFC.Location = new Point(387, 126);
            BTextBoxFC.Name = "BTextBoxFC";
            BTextBoxFC.Size = new Size(56, 21);
            BTextBoxFC.TabIndex = 23;
            // 
            // Label14
            // 
            Label14.AutoSize = true;
            Label14.Location = new Point(243, 96);
            Label14.Name = "Label14";
            Label14.Size = new Size(36, 13);
            Label14.TabIndex = 16;
            Label14.Text = "Color:";
            // 
            // Label15
            // 
            Label15.AutoSize = true;
            Label15.Location = new Point(351, 102);
            Label15.Name = "Label15";
            Label15.Size = new Size(18, 13);
            Label15.TabIndex = 22;
            Label15.Text = "G:";
            // 
            // Label16
            // 
            Label16.AutoSize = true;
            Label16.Location = new Point(246, 75);
            Label16.Name = "Label16";
            Label16.Size = new Size(30, 13);
            Label16.TabIndex = 18;
            Label16.Text = "Hex:";
            // 
            // GTextBoxFC
            // 
            GTextBoxFC.Location = new Point(387, 99);
            GTextBoxFC.Name = "GTextBoxFC";
            GTextBoxFC.Size = new Size(56, 21);
            GTextBoxFC.TabIndex = 21;
            // 
            // RTextBoxFC
            // 
            RTextBoxFC.Location = new Point(387, 72);
            RTextBoxFC.Name = "RTextBoxFC";
            RTextBoxFC.Size = new Size(56, 21);
            RTextBoxFC.TabIndex = 19;
            // 
            // Label17
            // 
            Label17.AutoSize = true;
            Label17.Location = new Point(351, 75);
            Label17.Name = "Label17";
            Label17.Size = new Size(18, 13);
            Label17.TabIndex = 20;
            Label17.Text = "R:";
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Location = new Point(8, 12);
            Label9.Name = "Label9";
            Label9.Size = new Size(85, 13);
            Label9.TabIndex = 3;
            Label9.Text = "Pick your colors!";
            // 
            // SettingsForm
            // 
            AcceptButton = _SaveButtonSettings;
            AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = _CancelButtonSettings;
            ClientSize = new Size(504, 359);
            Controls.Add(_CancelButtonSettings);
            Controls.Add(_SaveButtonSettings);
            Controls.Add(SettingsTC);
            Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SettingsForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            About.ResumeLayout(false);
            About.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Sounds.ResumeLayout(false);
            Sounds.PerformLayout();
            AutoTime.ResumeLayout(false);
            AutoTime.PerformLayout();
            TimerControl.ResumeLayout(false);
            BreakTimerTab.ResumeLayout(false);
            BreakTimerTab.PerformLayout();
            TimerGBBt.ResumeLayout(false);
            TimerGBBt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTimeHour).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinWarnNudBt).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTimeMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTimeBreakSec).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTimeSec).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTimeBreakMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTimeBreakHour).EndInit();
            BreakGBBt.ResumeLayout(false);
            BreakGBBt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudb1hour).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudb1sec).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudb1min).EndInit();
            TimerTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudSec).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHour).EndInit();
            ShutdownTabPage.ResumeLayout(false);
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HourNudSh).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinWarnNudSh).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinuteNudSh).EndInit();
            ((System.ComponentModel.ISupportInitialize)SecondNudSh).EndInit();
            General.ResumeLayout(false);
            GeneralTabControl.ResumeLayout(false);
            DateTimeTabPage.ResumeLayout(false);
            DateTimeTabPage.PerformLayout();
            StartupTabPage.ResumeLayout(false);
            StartupTabPage.PerformLayout();
            ResetTabPage.ResumeLayout(false);
            ResetTabPage.PerformLayout();
            SettingsTC.ResumeLayout(false);
            Personalization.ResumeLayout(false);
            Personalization.PerformLayout();
            TabControl1.ResumeLayout(false);
            TabPage1.ResumeLayout(false);
            TabPage1.PerformLayout();
            TabPage2.ResumeLayout(false);
            TabPage2.PerformLayout();
            Load += new EventHandler(Settings_Load);
            ResumeLayout(false);
        }

        private Button _SaveButtonSettings;

        internal Button SaveButtonSettings
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SaveButtonSettings;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SaveButtonSettings != null)
                {
                    _SaveButtonSettings.Click -= SaveButtonSettings_Click;
                }

                _SaveButtonSettings = value;
                if (_SaveButtonSettings != null)
                {
                    _SaveButtonSettings.Click += SaveButtonSettings_Click;
                }
            }
        }

        private Button _CancelButtonSettings;

        internal Button CancelButtonSettings
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CancelButtonSettings;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CancelButtonSettings != null)
                {
                    _CancelButtonSettings.Click -= CancelButtonSettings_Click;
                }

                _CancelButtonSettings = value;
                if (_CancelButtonSettings != null)
                {
                    _CancelButtonSettings.Click += CancelButtonSettings_Click;
                }
            }
        }

        private OpenFileDialog OFDS;
        private TabPage About;
        private Label lblVersion;
        private Label lblName;
        private TabPage Sounds;
        private Button _Button2;

        internal Button Button2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Button2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Button2 != null)
                {
                    _Button2.Click -= Button2_Click;
                }

                _Button2 = value;
                if (_Button2 != null)
                {
                    _Button2.Click += Button2_Click;
                }
            }
        }

        private Button _Button1;

        internal Button Button1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Button1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Button1 != null)
                {
                    _Button1.Click -= Button1_Click;
                }

                _Button1 = value;
                if (_Button1 != null)
                {
                    _Button1.Click += Button1_Click;
                }
            }
        }

        private Button _MWPlayButtonS;

        internal Button MWPlayButtonS
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _MWPlayButtonS;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_MWPlayButtonS != null)
                {
                    _MWPlayButtonS.Click -= MWPlayButtonS_Click;
                }

                _MWPlayButtonS = value;
                if (_MWPlayButtonS != null)
                {
                    _MWPlayButtonS.Click += MWPlayButtonS_Click;
                }
            }
        }

        private Button _TDPlayButtonS;

        internal Button TDPlayButtonS
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TDPlayButtonS;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TDPlayButtonS != null)
                {
                    _TDPlayButtonS.Click -= TDPlayButtonS_Click;
                }

                _TDPlayButtonS = value;
                if (_TDPlayButtonS != null)
                {
                    _TDPlayButtonS.Click += TDPlayButtonS_Click;
                }
            }
        }

        private ComboBox MWComboBoxS;
        private Label MWLabelS;
        private Label TDLabelS;
        private ComboBox _TDComboBoxS;

        internal ComboBox TDComboBoxS
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TDComboBoxS;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TDComboBoxS != null)
                {
                    _TDComboBoxS.SelectedIndexChanged -= TDComboBoxS_SelectedIndexChanged;
                }

                _TDComboBoxS = value;
                if (_TDComboBoxS != null)
                {
                    _TDComboBoxS.SelectedIndexChanged += TDComboBoxS_SelectedIndexChanged;
                }
            }
        }

        private Label SoundsPromptLabel;
        private Button _TDStopButtonS;

        internal Button TDStopButtonS
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TDStopButtonS;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TDStopButtonS != null)
                {
                    _TDStopButtonS.Click -= TDStopButtonS_Click;
                }

                _TDStopButtonS = value;
                if (_TDStopButtonS != null)
                {
                    _TDStopButtonS.Click += TDStopButtonS_Click;
                }
            }
        }

        private Button _MWStopButtonS;

        internal Button MWStopButtonS
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _MWStopButtonS;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_MWStopButtonS != null)
                {
                    _MWStopButtonS.Click -= MWStopButtonS_Click;
                }

                _MWStopButtonS = value;
                if (_MWStopButtonS != null)
                {
                    _MWStopButtonS.Click += MWStopButtonS_Click;
                }
            }
        }

        private TabPage AutoTime;
        private TabControl TimerControl;
        private TabPage BreakTimerTab;
        private GroupBox TimerGBBt;
        private RadioButton VisualRbBt;
        private NumericUpDown nudTimeHour;
        private RadioButton AudioRbBt;
        private Label TimeLabelBt;
        private Label MWLabelBt;
        private NumericUpDown MinWarnNudBt;
        private Label BreakTimerLabelBt;
        private NumericUpDown nudTimeMin;
        private NumericUpDown nudTimeBreakSec;
        private NumericUpDown nudTimeSec;
        private NumericUpDown nudTimeBreakMin;
        private NumericUpDown nudTimeBreakHour;
        private Label AutoTimeInstructionsLabelAt;
        private GroupBox BreakGBBt;
        private Label lblbreak2;
        private NumericUpDown nudb1hour;
        private NumericUpDown nudb1sec;
        private NumericUpDown nudb1min;
        private RadioButton TimeRBBt;
        private RadioButton BreakRBBt;
        private TabPage TimerTab;
        private NumericUpDown nudSec;
        private NumericUpDown nudMin;
        private NumericUpDown nudHour;
        private TabPage ShutdownTabPage;
        private ComboBox ShutdownCbSh;
        private GroupBox GroupBox1;
        private RadioButton VisualRadioButtonSh;
        private NumericUpDown HourNudSh;
        private RadioButton AudioRadioButtonSh;
        private Label TimeLabelSh;
        private Label MinWarnLabelSh;
        private NumericUpDown MinWarnNudSh;
        private NumericUpDown MinuteNudSh;
        private NumericUpDown SecondNudSh;
        private TabPage General;
        private TabControl SettingsTC;
        private ImageList ImageList1;
        private TabPage Personalization;
        private Label Label2;
        private TabControl GeneralTabControl;
        private TabPage DateTimeTabPage;
        private Label Label8;
        private Label Label7;
        private Label Label6;
        private ComboBox _ComboBox1;

        internal ComboBox ComboBox1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboBox1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboBox1 != null)
                {
                    _ComboBox1.SelectedIndexChanged -= ComboBox1_SelectedIndexChanged;
                }

                _ComboBox1 = value;
                if (_ComboBox1 != null)
                {
                    _ComboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
                }
            }
        }

        private Label Label1;
        private Label DTLabelDTGen2;
        private Label DTLabelDTGen;
        private Label TimeFormatLabelDTGen;
        private Label DateFormatLabelDTGen;
        private ComboBox _TimeFormatCbDTGen;

        internal ComboBox TimeFormatCbDTGen
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TimeFormatCbDTGen;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TimeFormatCbDTGen != null)
                {
                    _TimeFormatCbDTGen.SelectedIndexChanged -= TimeFormatCbDTGen_SelectedIndexChanged;
                }

                _TimeFormatCbDTGen = value;
                if (_TimeFormatCbDTGen != null)
                {
                    _TimeFormatCbDTGen.SelectedIndexChanged += TimeFormatCbDTGen_SelectedIndexChanged;
                }
            }
        }

        private ComboBox _DateFormatCbDTGen;

        internal ComboBox DateFormatCbDTGen
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _DateFormatCbDTGen;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_DateFormatCbDTGen != null)
                {
                    _DateFormatCbDTGen.SelectedIndexChanged -= DateFormatCbDTGen_SelectedIndexChanged;
                }

                _DateFormatCbDTGen = value;
                if (_DateFormatCbDTGen != null)
                {
                    _DateFormatCbDTGen.SelectedIndexChanged += DateFormatCbDTGen_SelectedIndexChanged;
                }
            }
        }

        private TabPage StartupTabPage;
        private ComboBox WDLCTSUCbSUGen;
        private Label WhenIStartupLabelSUGen;
        private TabPage ResetTabPage;
        private Label Label3;
        private Button _ResetButtonReGen;

        internal Button ResetButtonReGen
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ResetButtonReGen;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ResetButtonReGen != null)
                {
                    _ResetButtonReGen.Click -= ResetButtonReGen_Click;
                }

                _ResetButtonReGen = value;
                if (_ResetButtonReGen != null)
                {
                    _ResetButtonReGen.Click += ResetButtonReGen_Click;
                }
            }
        }

        private Label ResetPromptLabelReGen;
        private Label Label9;
        private Button _BtnLicense;

        internal Button BtnLicense
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BtnLicense;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BtnLicense != null)
                {
                    _BtnLicense.Click -= BtnLicense_Click;
                }

                _BtnLicense = value;
                if (_BtnLicense != null)
                {
                    _BtnLicense.Click += BtnLicense_Click;
                }
            }
        }

        private Button _BTBrowse;

        internal Button BTBrowse
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BTBrowse;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BTBrowse != null)
                {
                    _BTBrowse.Click -= BTBrowse_Click;
                }

                _BTBrowse = value;
                if (_BTBrowse != null)
                {
                    _BTBrowse.Click += BTBrowse_Click;
                }
            }
        }

        private Button _BTPlay;

        internal Button BTPlay
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BTPlay;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BTPlay != null)
                {
                    _BTPlay.Click -= Button5_Click;
                }

                _BTPlay = value;
                if (_BTPlay != null)
                {
                    _BTPlay.Click += Button5_Click;
                }
            }
        }

        private Label Label10;
        private ComboBox BTComboBoxSounds;
        private Button _BTStop;

        internal Button BTStop
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BTStop;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BTStop != null)
                {
                    _BTStop.Click -= BTStop_Click;
                }

                _BTStop = value;
                if (_BTStop != null)
                {
                    _BTStop.Click += BTStop_Click;
                }
            }
        }

        private Label Label13;
        private TextBox BTextBox;
        private Label Label12;
        private TextBox GTextBox;
        private Label Label11;
        private TextBox RTextBox;
        private Label HexLabel;
        private TextBox HexTextBox;
        private Label ColorLabel;
        private Cyotek.Windows.Forms.ColorWheel Panel1;
        private TabControl TabControl1;
        private TabPage TabPage1;
        private TabPage TabPage2;
        private Cyotek.Windows.Forms.ColorWheel _ColorWheel2;

        internal Cyotek.Windows.Forms.ColorWheel ColorWheel2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ColorWheel2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ColorWheel2 != null)
                {
                    _ColorWheel2.ColorChanged -= colorwheel2_ColorChanged;
                }

                _ColorWheel2 = value;
                if (_ColorWheel2 != null)
                {
                    _ColorWheel2.ColorChanged += colorwheel2_ColorChanged;
                }
            }
        }

        private Cyotek.Windows.Forms.ColorWheel _ColorWheel1;

        internal Cyotek.Windows.Forms.ColorWheel ColorWheel1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ColorWheel1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ColorWheel1 != null)
                {
                    _ColorWheel1.ColorChanged -= ColorWheel1_ColorChanged;
                }

                _ColorWheel1 = value;
                if (_ColorWheel1 != null)
                {
                    _ColorWheel1.ColorChanged += ColorWheel1_ColorChanged;
                }
            }
        }

        private TextBox HexTextBoxFC;
        private Label Label4;
        private Label KnownColorLabel;
        private TextBox BTextBoxFC;
        private Label Label14;
        private Label Label15;
        private Label Label16;
        private TextBox GTextBoxFC;
        private TextBox RTextBoxFC;
        private Label Label17;
        private PictureBox PictureBox1;
    }
}