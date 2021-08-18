<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SettingsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsForm))
        Me.SaveButtonSettings = New System.Windows.Forms.Button()
        Me.CancelButtonSettings = New System.Windows.Forms.Button()
        Me.OFDS = New System.Windows.Forms.OpenFileDialog()
        Me.About = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnLicense = New System.Windows.Forms.Button()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Sounds = New System.Windows.Forms.TabPage()
        Me.BTBrowse = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BTComboBoxSounds = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MWComboBoxS = New System.Windows.Forms.ComboBox()
        Me.MWLabelS = New System.Windows.Forms.Label()
        Me.TDLabelS = New System.Windows.Forms.Label()
        Me.TDComboBoxS = New System.Windows.Forms.ComboBox()
        Me.SoundsPromptLabel = New System.Windows.Forms.Label()
        Me.AutoTime = New System.Windows.Forms.TabPage()
        Me.TimerControl = New System.Windows.Forms.TabControl()
        Me.BreakTimerTab = New System.Windows.Forms.TabPage()
        Me.TimerGBBt = New System.Windows.Forms.GroupBox()
        Me.VisualRbBt = New System.Windows.Forms.RadioButton()
        Me.nudTimeHour = New System.Windows.Forms.NumericUpDown()
        Me.AudioRbBt = New System.Windows.Forms.RadioButton()
        Me.TimeLabelBt = New System.Windows.Forms.Label()
        Me.MWLabelBt = New System.Windows.Forms.Label()
        Me.MinWarnNudBt = New System.Windows.Forms.NumericUpDown()
        Me.BreakTimerLabelBt = New System.Windows.Forms.Label()
        Me.nudTimeMin = New System.Windows.Forms.NumericUpDown()
        Me.nudTimeBreakSec = New System.Windows.Forms.NumericUpDown()
        Me.nudTimeSec = New System.Windows.Forms.NumericUpDown()
        Me.nudTimeBreakMin = New System.Windows.Forms.NumericUpDown()
        Me.nudTimeBreakHour = New System.Windows.Forms.NumericUpDown()
        Me.BreakGBBt = New System.Windows.Forms.GroupBox()
        Me.lblbreak2 = New System.Windows.Forms.Label()
        Me.nudb1hour = New System.Windows.Forms.NumericUpDown()
        Me.nudb1sec = New System.Windows.Forms.NumericUpDown()
        Me.nudb1min = New System.Windows.Forms.NumericUpDown()
        Me.TimeRBBt = New System.Windows.Forms.RadioButton()
        Me.BreakRBBt = New System.Windows.Forms.RadioButton()
        Me.TimerTab = New System.Windows.Forms.TabPage()
        Me.nudSec = New System.Windows.Forms.NumericUpDown()
        Me.nudMin = New System.Windows.Forms.NumericUpDown()
        Me.nudHour = New System.Windows.Forms.NumericUpDown()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.AutoTimeInstructionsLabelAt = New System.Windows.Forms.Label()
        Me.General = New System.Windows.Forms.TabPage()
        Me.GeneralTabControl = New System.Windows.Forms.TabControl()
        Me.DateTimeTabPage = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTLabelDTGen2 = New System.Windows.Forms.Label()
        Me.DTLabelDTGen = New System.Windows.Forms.Label()
        Me.TimeFormatLabelDTGen = New System.Windows.Forms.Label()
        Me.DateFormatLabelDTGen = New System.Windows.Forms.Label()
        Me.TimeFormatCbDTGen = New System.Windows.Forms.ComboBox()
        Me.DateFormatCbDTGen = New System.Windows.Forms.ComboBox()
        Me.StartupTabPage = New System.Windows.Forms.TabPage()
        Me.WDLCTSUCbSUGen = New System.Windows.Forms.ComboBox()
        Me.WhenIStartupLabelSUGen = New System.Windows.Forms.Label()
        Me.ResetTabPage = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ResetButtonReGen = New System.Windows.Forms.Button()
        Me.ResetPromptLabelReGen = New System.Windows.Forms.Label()
        Me.SettingsTC = New System.Windows.Forms.TabControl()
        Me.Personalization = New System.Windows.Forms.TabPage()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ColorWheel2 = New Cyotek.Windows.Forms.ColorWheel()
        Me.HexTextBox = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTextBox = New System.Windows.Forms.TextBox()
        Me.ColorLabel = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.HexLabel = New System.Windows.Forms.Label()
        Me.GTextBox = New System.Windows.Forms.TextBox()
        Me.RTextBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ColorWheel1 = New Cyotek.Windows.Forms.ColorWheel()
        Me.HexTextBoxFC = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.KnownColorLabel = New System.Windows.Forms.Label()
        Me.BTextBoxFC = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GTextBoxFC = New System.Windows.Forms.TextBox()
        Me.RTextBoxFC = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.About.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Sounds.SuspendLayout()
        Me.AutoTime.SuspendLayout()
        Me.TimerControl.SuspendLayout()
        Me.BreakTimerTab.SuspendLayout()
        Me.TimerGBBt.SuspendLayout()
        CType(Me.nudTimeHour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinWarnNudBt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTimeMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTimeBreakSec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTimeSec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTimeBreakMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTimeBreakHour, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BreakGBBt.SuspendLayout()
        CType(Me.nudb1hour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudb1sec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudb1min, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TimerTab.SuspendLayout()
        CType(Me.nudSec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHour, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.General.SuspendLayout()
        Me.GeneralTabControl.SuspendLayout()
        Me.DateTimeTabPage.SuspendLayout()
        Me.StartupTabPage.SuspendLayout()
        Me.ResetTabPage.SuspendLayout()
        Me.SettingsTC.SuspendLayout()
        Me.Personalization.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SaveButtonSettings
        '
        Me.SaveButtonSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButtonSettings.Location = New System.Drawing.Point(347, 318)
        Me.SaveButtonSettings.Name = "SaveButtonSettings"
        Me.SaveButtonSettings.Size = New System.Drawing.Size(75, 23)
        Me.SaveButtonSettings.TabIndex = 1
        Me.SaveButtonSettings.Text = "&Save"
        Me.SaveButtonSettings.UseVisualStyleBackColor = True
        '
        'CancelButtonSettings
        '
        Me.CancelButtonSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelButtonSettings.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelButtonSettings.Location = New System.Drawing.Point(428, 318)
        Me.CancelButtonSettings.Name = "CancelButtonSettings"
        Me.CancelButtonSettings.Size = New System.Drawing.Size(75, 23)
        Me.CancelButtonSettings.TabIndex = 2
        Me.CancelButtonSettings.Text = "&Cancel"
        Me.CancelButtonSettings.UseVisualStyleBackColor = True
        '
        'OFDS
        '
        Me.OFDS.Filter = "Wave file (*.wav)|*.wav|All files (*.*)|*.*"
        Me.OFDS.RestoreDirectory = True
        Me.OFDS.Title = "Browse for a sound file"
        '
        'About
        '
        Me.About.BackColor = System.Drawing.Color.DarkRed
        Me.About.Controls.Add(Me.PictureBox1)
        Me.About.Controls.Add(Me.BtnLicense)
        Me.About.Controls.Add(Me.lblVersion)
        Me.About.Controls.Add(Me.lblName)
        Me.About.ForeColor = System.Drawing.Color.Red
        Me.About.ImageKey = "2139.png"
        Me.About.Location = New System.Drawing.Point(4, 23)
        Me.About.Name = "About"
        Me.About.Size = New System.Drawing.Size(496, 267)
        Me.About.TabIndex = 3
        Me.About.Text = "About"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(110, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'BtnLicense
        '
        Me.BtnLicense.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLicense.Location = New System.Drawing.Point(184, 71)
        Me.BtnLicense.Name = "BtnLicense"
        Me.BtnLicense.Size = New System.Drawing.Size(75, 23)
        Me.BtnLicense.TabIndex = 3
        Me.BtnLicense.Text = "&License"
        Me.BtnLicense.UseVisualStyleBackColor = True
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(182, 32)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(132, 36)
        Me.lblVersion.TabIndex = 29
        Me.lblVersion.Text = "v21H2 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Alpha One" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Released August 18, 2021"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(181, 11)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(109, 19)
        Me.lblName.TabIndex = 28
        Me.lblName.Text = "BreakTime"
        '
        'Sounds
        '
        Me.Sounds.BackColor = System.Drawing.Color.Red
        Me.Sounds.Controls.Add(Me.BTBrowse)
        Me.Sounds.Controls.Add(Me.Label10)
        Me.Sounds.Controls.Add(Me.BTComboBoxSounds)
        Me.Sounds.Controls.Add(Me.Button2)
        Me.Sounds.Controls.Add(Me.Button1)
        Me.Sounds.Controls.Add(Me.MWComboBoxS)
        Me.Sounds.Controls.Add(Me.MWLabelS)
        Me.Sounds.Controls.Add(Me.TDLabelS)
        Me.Sounds.Controls.Add(Me.TDComboBoxS)
        Me.Sounds.Controls.Add(Me.SoundsPromptLabel)
        Me.Sounds.ImageKey = "1F50A.png"
        Me.Sounds.Location = New System.Drawing.Point(4, 23)
        Me.Sounds.Name = "Sounds"
        Me.Sounds.Size = New System.Drawing.Size(496, 267)
        Me.Sounds.TabIndex = 2
        Me.Sounds.Text = "Sounds"
        '
        'BTBrowse
        '
        Me.BTBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTBrowse.Location = New System.Drawing.Point(224, 144)
        Me.BTBrowse.Name = "BTBrowse"
        Me.BTBrowse.Size = New System.Drawing.Size(75, 23)
        Me.BTBrowse.TabIndex = 15
        Me.BTBrowse.Text = "Browse"
        Me.BTBrowse.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(26, 144)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 12)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Break Over:"
        '
        'BTComboBoxSounds
        '
        Me.BTComboBoxSounds.FormattingEnabled = True
        Me.BTComboBoxSounds.Items.AddRange(New Object() {"Default Sound", "Browse for sound file..."})
        Me.BTComboBoxSounds.Location = New System.Drawing.Point(97, 141)
        Me.BTComboBoxSounds.Name = "BTComboBoxSounds"
        Me.BTComboBoxSounds.Size = New System.Drawing.Size(121, 20)
        Me.BTComboBoxSounds.TabIndex = 12
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(224, 114)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Browse"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(224, 83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MWComboBoxS
        '
        Me.MWComboBoxS.FormattingEnabled = True
        Me.MWComboBoxS.Items.AddRange(New Object() {"Default Sound", "Twinkle", "Bubbles 1", "Airbus", "Bubbles 2", "211 Default", "Pop", "Browse For sound"})
        Me.MWComboBoxS.Location = New System.Drawing.Point(97, 116)
        Me.MWComboBoxS.Name = "MWComboBoxS"
        Me.MWComboBoxS.Size = New System.Drawing.Size(121, 20)
        Me.MWComboBoxS.TabIndex = 5
        '
        'MWLabelS
        '
        Me.MWLabelS.AutoSize = True
        Me.MWLabelS.Location = New System.Drawing.Point(38, 119)
        Me.MWLabelS.Name = "MWLabelS"
        Me.MWLabelS.Size = New System.Drawing.Size(51, 12)
        Me.MWLabelS.TabIndex = 4
        Me.MWLabelS.Text = "MinWarn:"
        '
        'TDLabelS
        '
        Me.TDLabelS.AutoSize = True
        Me.TDLabelS.Location = New System.Drawing.Point(26, 88)
        Me.TDLabelS.Name = "TDLabelS"
        Me.TDLabelS.Size = New System.Drawing.Size(65, 12)
        Me.TDLabelS.TabIndex = 3
        Me.TDLabelS.Text = "Timer Done:"
        '
        'TDComboBoxS
        '
        Me.TDComboBoxS.FormattingEnabled = True
        Me.TDComboBoxS.Items.AddRange(New Object() {"Default Sound", "Aquatics Nearby", "Fast and Furious", "Foghorn Leghorn", "211 Default", "Speed Demon", "Browse for sound"})
        Me.TDComboBoxS.Location = New System.Drawing.Point(97, 85)
        Me.TDComboBoxS.Name = "TDComboBoxS"
        Me.TDComboBoxS.Size = New System.Drawing.Size(121, 20)
        Me.TDComboBoxS.TabIndex = 2
        '
        'SoundsPromptLabel
        '
        Me.SoundsPromptLabel.AutoSize = True
        Me.SoundsPromptLabel.Location = New System.Drawing.Point(8, 10)
        Me.SoundsPromptLabel.Name = "SoundsPromptLabel"
        Me.SoundsPromptLabel.Size = New System.Drawing.Size(240, 48)
        Me.SoundsPromptLabel.TabIndex = 1
        Me.SoundsPromptLabel.Text = "With sounds, the program can alert you of when " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "your timer is done, your timer h" &
    "as an exact" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "number of minutes left, or when your break is " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "over."
        '
        'AutoTime
        '
        Me.AutoTime.BackColor = System.Drawing.Color.DarkRed
        Me.AutoTime.Controls.Add(Me.TimerControl)
        Me.AutoTime.Controls.Add(Me.AutoTimeInstructionsLabelAt)
        Me.AutoTime.ImageKey = "favicon (6).ico"
        Me.AutoTime.Location = New System.Drawing.Point(4, 23)
        Me.AutoTime.Name = "AutoTime"
        Me.AutoTime.Padding = New System.Windows.Forms.Padding(3)
        Me.AutoTime.Size = New System.Drawing.Size(496, 267)
        Me.AutoTime.TabIndex = 1
        Me.AutoTime.Text = "AutoTime"
        '
        'TimerControl
        '
        Me.TimerControl.Controls.Add(Me.BreakTimerTab)
        Me.TimerControl.Controls.Add(Me.TimerTab)
        Me.TimerControl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TimerControl.ImageList = Me.ImageList1
        Me.TimerControl.Location = New System.Drawing.Point(3, 66)
        Me.TimerControl.Multiline = True
        Me.TimerControl.Name = "TimerControl"
        Me.TimerControl.SelectedIndex = 0
        Me.TimerControl.Size = New System.Drawing.Size(490, 198)
        Me.TimerControl.TabIndex = 25
        '
        'BreakTimerTab
        '
        Me.BreakTimerTab.BackColor = System.Drawing.Color.White
        Me.BreakTimerTab.Controls.Add(Me.TimerGBBt)
        Me.BreakTimerTab.Controls.Add(Me.BreakGBBt)
        Me.BreakTimerTab.Controls.Add(Me.TimeRBBt)
        Me.BreakTimerTab.Controls.Add(Me.BreakRBBt)
        Me.BreakTimerTab.ImageKey = "favicon (5).ico"
        Me.BreakTimerTab.Location = New System.Drawing.Point(4, 23)
        Me.BreakTimerTab.Name = "BreakTimerTab"
        Me.BreakTimerTab.Padding = New System.Windows.Forms.Padding(3)
        Me.BreakTimerTab.Size = New System.Drawing.Size(482, 171)
        Me.BreakTimerTab.TabIndex = 0
        Me.BreakTimerTab.Text = "Break Timer"
        '
        'TimerGBBt
        '
        Me.TimerGBBt.Controls.Add(Me.VisualRbBt)
        Me.TimerGBBt.Controls.Add(Me.nudTimeHour)
        Me.TimerGBBt.Controls.Add(Me.AudioRbBt)
        Me.TimerGBBt.Controls.Add(Me.TimeLabelBt)
        Me.TimerGBBt.Controls.Add(Me.MWLabelBt)
        Me.TimerGBBt.Controls.Add(Me.MinWarnNudBt)
        Me.TimerGBBt.Controls.Add(Me.BreakTimerLabelBt)
        Me.TimerGBBt.Controls.Add(Me.nudTimeMin)
        Me.TimerGBBt.Controls.Add(Me.nudTimeBreakSec)
        Me.TimerGBBt.Controls.Add(Me.nudTimeSec)
        Me.TimerGBBt.Controls.Add(Me.nudTimeBreakMin)
        Me.TimerGBBt.Controls.Add(Me.nudTimeBreakHour)
        Me.TimerGBBt.Location = New System.Drawing.Point(256, 6)
        Me.TimerGBBt.Name = "TimerGBBt"
        Me.TimerGBBt.Size = New System.Drawing.Size(218, 106)
        Me.TimerGBBt.TabIndex = 49
        Me.TimerGBBt.TabStop = False
        Me.TimerGBBt.Text = "Timer Settings"
        '
        'VisualRbBt
        '
        Me.VisualRbBt.AutoSize = True
        Me.VisualRbBt.Location = New System.Drawing.Point(118, 86)
        Me.VisualRbBt.Name = "VisualRbBt"
        Me.VisualRbBt.Size = New System.Drawing.Size(52, 16)
        Me.VisualRbBt.TabIndex = 62
        Me.VisualRbBt.TabStop = True
        Me.VisualRbBt.Text = "Visual"
        Me.VisualRbBt.UseVisualStyleBackColor = True
        '
        'nudTimeHour
        '
        Me.nudTimeHour.ForeColor = System.Drawing.SystemColors.ControlText
        Me.nudTimeHour.Location = New System.Drawing.Point(72, 18)
        Me.nudTimeHour.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudTimeHour.Name = "nudTimeHour"
        Me.nudTimeHour.Size = New System.Drawing.Size(42, 20)
        Me.nudTimeHour.TabIndex = 34
        '
        'AudioRbBt
        '
        Me.AudioRbBt.AutoSize = True
        Me.AudioRbBt.Location = New System.Drawing.Point(118, 70)
        Me.AudioRbBt.Name = "AudioRbBt"
        Me.AudioRbBt.Size = New System.Drawing.Size(50, 16)
        Me.AudioRbBt.TabIndex = 61
        Me.AudioRbBt.TabStop = True
        Me.AudioRbBt.Text = "Audio"
        Me.AudioRbBt.UseVisualStyleBackColor = True
        '
        'TimeLabelBt
        '
        Me.TimeLabelBt.AutoSize = True
        Me.TimeLabelBt.Location = New System.Drawing.Point(24, 18)
        Me.TimeLabelBt.Name = "TimeLabelBt"
        Me.TimeLabelBt.Size = New System.Drawing.Size(32, 12)
        Me.TimeLabelBt.TabIndex = 29
        Me.TimeLabelBt.Text = "Time:"
        '
        'MWLabelBt
        '
        Me.MWLabelBt.AutoSize = True
        Me.MWLabelBt.Location = New System.Drawing.Point(6, 78)
        Me.MWLabelBt.Name = "MWLabelBt"
        Me.MWLabelBt.Size = New System.Drawing.Size(51, 12)
        Me.MWLabelBt.TabIndex = 43
        Me.MWLabelBt.Text = "MinWarn:"
        '
        'MinWarnNudBt
        '
        Me.MinWarnNudBt.Location = New System.Drawing.Point(72, 76)
        Me.MinWarnNudBt.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.MinWarnNudBt.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MinWarnNudBt.Name = "MinWarnNudBt"
        Me.MinWarnNudBt.Size = New System.Drawing.Size(40, 20)
        Me.MinWarnNudBt.TabIndex = 60
        Me.MinWarnNudBt.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'BreakTimerLabelBt
        '
        Me.BreakTimerLabelBt.AutoSize = True
        Me.BreakTimerLabelBt.Location = New System.Drawing.Point(19, 50)
        Me.BreakTimerLabelBt.Name = "BreakTimerLabelBt"
        Me.BreakTimerLabelBt.Size = New System.Drawing.Size(37, 12)
        Me.BreakTimerLabelBt.TabIndex = 31
        Me.BreakTimerLabelBt.Text = "Break:"
        '
        'nudTimeMin
        '
        Me.nudTimeMin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.nudTimeMin.Location = New System.Drawing.Point(120, 18)
        Me.nudTimeMin.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudTimeMin.Name = "nudTimeMin"
        Me.nudTimeMin.Size = New System.Drawing.Size(41, 20)
        Me.nudTimeMin.TabIndex = 35
        '
        'nudTimeBreakSec
        '
        Me.nudTimeBreakSec.ForeColor = System.Drawing.SystemColors.ControlText
        Me.nudTimeBreakSec.Location = New System.Drawing.Point(167, 48)
        Me.nudTimeBreakSec.Name = "nudTimeBreakSec"
        Me.nudTimeBreakSec.Size = New System.Drawing.Size(40, 20)
        Me.nudTimeBreakSec.TabIndex = 39
        '
        'nudTimeSec
        '
        Me.nudTimeSec.ForeColor = System.Drawing.SystemColors.ControlText
        Me.nudTimeSec.Location = New System.Drawing.Point(167, 18)
        Me.nudTimeSec.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudTimeSec.Name = "nudTimeSec"
        Me.nudTimeSec.Size = New System.Drawing.Size(40, 20)
        Me.nudTimeSec.TabIndex = 36
        '
        'nudTimeBreakMin
        '
        Me.nudTimeBreakMin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.nudTimeBreakMin.Location = New System.Drawing.Point(120, 48)
        Me.nudTimeBreakMin.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudTimeBreakMin.Name = "nudTimeBreakMin"
        Me.nudTimeBreakMin.Size = New System.Drawing.Size(41, 20)
        Me.nudTimeBreakMin.TabIndex = 38
        '
        'nudTimeBreakHour
        '
        Me.nudTimeBreakHour.ForeColor = System.Drawing.SystemColors.ControlText
        Me.nudTimeBreakHour.Location = New System.Drawing.Point(72, 48)
        Me.nudTimeBreakHour.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudTimeBreakHour.Name = "nudTimeBreakHour"
        Me.nudTimeBreakHour.Size = New System.Drawing.Size(42, 20)
        Me.nudTimeBreakHour.TabIndex = 37
        '
        'BreakGBBt
        '
        Me.BreakGBBt.Controls.Add(Me.lblbreak2)
        Me.BreakGBBt.Controls.Add(Me.nudb1hour)
        Me.BreakGBBt.Controls.Add(Me.nudb1sec)
        Me.BreakGBBt.Controls.Add(Me.nudb1min)
        Me.BreakGBBt.Location = New System.Drawing.Point(32, 43)
        Me.BreakGBBt.Name = "BreakGBBt"
        Me.BreakGBBt.Size = New System.Drawing.Size(218, 50)
        Me.BreakGBBt.TabIndex = 52
        Me.BreakGBBt.TabStop = False
        Me.BreakGBBt.Text = "Break Settings"
        '
        'lblbreak2
        '
        Me.lblbreak2.AutoSize = True
        Me.lblbreak2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblbreak2.Location = New System.Drawing.Point(11, 16)
        Me.lblbreak2.Name = "lblbreak2"
        Me.lblbreak2.Size = New System.Drawing.Size(37, 12)
        Me.lblbreak2.TabIndex = 33
        Me.lblbreak2.Text = "Break:"
        '
        'nudb1hour
        '
        Me.nudb1hour.ForeColor = System.Drawing.SystemColors.ControlText
        Me.nudb1hour.Location = New System.Drawing.Point(61, 14)
        Me.nudb1hour.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudb1hour.Name = "nudb1hour"
        Me.nudb1hour.Size = New System.Drawing.Size(37, 20)
        Me.nudb1hour.TabIndex = 40
        '
        'nudb1sec
        '
        Me.nudb1sec.ForeColor = System.Drawing.SystemColors.ControlText
        Me.nudb1sec.Location = New System.Drawing.Point(149, 14)
        Me.nudb1sec.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudb1sec.Name = "nudb1sec"
        Me.nudb1sec.Size = New System.Drawing.Size(42, 20)
        Me.nudb1sec.TabIndex = 42
        '
        'nudb1min
        '
        Me.nudb1min.ForeColor = System.Drawing.SystemColors.ControlText
        Me.nudb1min.Location = New System.Drawing.Point(104, 14)
        Me.nudb1min.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudb1min.Name = "nudb1min"
        Me.nudb1min.Size = New System.Drawing.Size(39, 20)
        Me.nudb1min.TabIndex = 41
        '
        'TimeRBBt
        '
        Me.TimeRBBt.AutoSize = True
        Me.TimeRBBt.Location = New System.Drawing.Point(46, 21)
        Me.TimeRBBt.Name = "TimeRBBt"
        Me.TimeRBBt.Size = New System.Drawing.Size(66, 16)
        Me.TimeRBBt.TabIndex = 45
        Me.TimeRBBt.Text = "Set Time"
        Me.TimeRBBt.UseVisualStyleBackColor = False
        '
        'BreakRBBt
        '
        Me.BreakRBBt.AutoSize = True
        Me.BreakRBBt.Location = New System.Drawing.Point(140, 21)
        Me.BreakRBBt.Name = "BreakRBBt"
        Me.BreakRBBt.Size = New System.Drawing.Size(71, 16)
        Me.BreakRBBt.TabIndex = 48
        Me.BreakRBBt.Text = "Set Break"
        Me.BreakRBBt.UseVisualStyleBackColor = False
        '
        'TimerTab
        '
        Me.TimerTab.BackColor = System.Drawing.Color.White
        Me.TimerTab.Controls.Add(Me.nudSec)
        Me.TimerTab.Controls.Add(Me.nudMin)
        Me.TimerTab.Controls.Add(Me.nudHour)
        Me.TimerTab.ImageKey = "favicon (6).ico"
        Me.TimerTab.Location = New System.Drawing.Point(4, 23)
        Me.TimerTab.Name = "TimerTab"
        Me.TimerTab.Padding = New System.Windows.Forms.Padding(3)
        Me.TimerTab.Size = New System.Drawing.Size(482, 171)
        Me.TimerTab.TabIndex = 1
        Me.TimerTab.Text = "Timer"
        '
        'nudSec
        '
        Me.nudSec.Location = New System.Drawing.Point(253, 28)
        Me.nudSec.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudSec.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudSec.Name = "nudSec"
        Me.nudSec.Size = New System.Drawing.Size(50, 20)
        Me.nudSec.TabIndex = 10
        Me.nudSec.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudMin
        '
        Me.nudMin.Location = New System.Drawing.Point(197, 28)
        Me.nudMin.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudMin.Name = "nudMin"
        Me.nudMin.Size = New System.Drawing.Size(50, 20)
        Me.nudMin.TabIndex = 9
        '
        'nudHour
        '
        Me.nudHour.Location = New System.Drawing.Point(141, 28)
        Me.nudHour.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudHour.Name = "nudHour"
        Me.nudHour.Size = New System.Drawing.Size(50, 20)
        Me.nudHour.TabIndex = 8
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "favicon (5).ico")
        Me.ImageList1.Images.SetKeyName(1, "1F50A.png")
        Me.ImageList1.Images.SetKeyName(2, "2139.png")
        Me.ImageList1.Images.SetKeyName(3, "2699.png")
        Me.ImageList1.Images.SetKeyName(4, "favicon (6).ico")
        Me.ImageList1.Images.SetKeyName(5, "1F50C.png")
        Me.ImageList1.Images.SetKeyName(6, "favicon (4).ico")
        '
        'AutoTimeInstructionsLabelAt
        '
        Me.AutoTimeInstructionsLabelAt.AutoSize = True
        Me.AutoTimeInstructionsLabelAt.Location = New System.Drawing.Point(4, 3)
        Me.AutoTimeInstructionsLabelAt.Name = "AutoTimeInstructionsLabelAt"
        Me.AutoTimeInstructionsLabelAt.Size = New System.Drawing.Size(257, 60)
        Me.AutoTimeInstructionsLabelAt.TabIndex = 0
        Me.AutoTimeInstructionsLabelAt.Text = resources.GetString("AutoTimeInstructionsLabelAt.Text")
        '
        'General
        '
        Me.General.BackColor = System.Drawing.Color.White
        Me.General.Controls.Add(Me.GeneralTabControl)
        Me.General.ImageIndex = 3
        Me.General.Location = New System.Drawing.Point(4, 23)
        Me.General.Name = "General"
        Me.General.Padding = New System.Windows.Forms.Padding(3)
        Me.General.Size = New System.Drawing.Size(496, 267)
        Me.General.TabIndex = 0
        Me.General.Text = "General"
        '
        'GeneralTabControl
        '
        Me.GeneralTabControl.Controls.Add(Me.DateTimeTabPage)
        Me.GeneralTabControl.Controls.Add(Me.StartupTabPage)
        Me.GeneralTabControl.Controls.Add(Me.ResetTabPage)
        Me.GeneralTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GeneralTabControl.Location = New System.Drawing.Point(3, 3)
        Me.GeneralTabControl.Name = "GeneralTabControl"
        Me.GeneralTabControl.SelectedIndex = 0
        Me.GeneralTabControl.Size = New System.Drawing.Size(490, 261)
        Me.GeneralTabControl.TabIndex = 8
        '
        'DateTimeTabPage
        '
        Me.DateTimeTabPage.Controls.Add(Me.Label8)
        Me.DateTimeTabPage.Controls.Add(Me.Label7)
        Me.DateTimeTabPage.Controls.Add(Me.Label6)
        Me.DateTimeTabPage.Controls.Add(Me.ComboBox1)
        Me.DateTimeTabPage.Controls.Add(Me.Label1)
        Me.DateTimeTabPage.Controls.Add(Me.DTLabelDTGen2)
        Me.DateTimeTabPage.Controls.Add(Me.DTLabelDTGen)
        Me.DateTimeTabPage.Controls.Add(Me.TimeFormatLabelDTGen)
        Me.DateTimeTabPage.Controls.Add(Me.DateFormatLabelDTGen)
        Me.DateTimeTabPage.Controls.Add(Me.TimeFormatCbDTGen)
        Me.DateTimeTabPage.Controls.Add(Me.DateFormatCbDTGen)
        Me.DateTimeTabPage.Location = New System.Drawing.Point(4, 21)
        Me.DateTimeTabPage.Name = "DateTimeTabPage"
        Me.DateTimeTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.DateTimeTabPage.Size = New System.Drawing.Size(482, 236)
        Me.DateTimeTabPage.TabIndex = 0
        Me.DateTimeTabPage.Text = "Date/Time"
        Me.DateTimeTabPage.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(209, 130)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 12)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Date/Time Format:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(188, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 12)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Date Format for Break:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(126, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 12)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Date Format for Break:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"220101", "20220101", "01/01/22", "21/01/22", "01/01/2022", "1577836800"})
        Me.ComboBox1.Location = New System.Drawing.Point(250, 78)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 20)
        Me.ComboBox1.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(179, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 12)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Wednesday, January 1, 2022"
        '
        'DTLabelDTGen2
        '
        Me.DTLabelDTGen2.AutoSize = True
        Me.DTLabelDTGen2.Location = New System.Drawing.Point(215, 154)
        Me.DTLabelDTGen2.Name = "DTLabelDTGen2"
        Me.DTLabelDTGen2.Size = New System.Drawing.Size(66, 12)
        Me.DTLabelDTGen2.TabIndex = 26
        Me.DTLabelDTGen2.Text = "12:08:00 PM"
        '
        'DTLabelDTGen
        '
        Me.DTLabelDTGen.AutoSize = True
        Me.DTLabelDTGen.Location = New System.Drawing.Point(182, 142)
        Me.DTLabelDTGen.Name = "DTLabelDTGen"
        Me.DTLabelDTGen.Size = New System.Drawing.Size(147, 12)
        Me.DTLabelDTGen.TabIndex = 25
        Me.DTLabelDTGen.Text = "Wednesday, January 1, 2022"
        '
        'TimeFormatLabelDTGen
        '
        Me.TimeFormatLabelDTGen.AutoSize = True
        Me.TimeFormatLabelDTGen.Location = New System.Drawing.Point(126, 55)
        Me.TimeFormatLabelDTGen.Name = "TimeFormatLabelDTGen"
        Me.TimeFormatLabelDTGen.Size = New System.Drawing.Size(70, 12)
        Me.TimeFormatLabelDTGen.TabIndex = 24
        Me.TimeFormatLabelDTGen.Text = "Time Format:"
        '
        'DateFormatLabelDTGen
        '
        Me.DateFormatLabelDTGen.AutoSize = True
        Me.DateFormatLabelDTGen.Location = New System.Drawing.Point(128, 31)
        Me.DateFormatLabelDTGen.Name = "DateFormatLabelDTGen"
        Me.DateFormatLabelDTGen.Size = New System.Drawing.Size(69, 12)
        Me.DateFormatLabelDTGen.TabIndex = 23
        Me.DateFormatLabelDTGen.Text = "Date Format:"
        '
        'TimeFormatCbDTGen
        '
        Me.TimeFormatCbDTGen.FormattingEnabled = True
        Me.TimeFormatCbDTGen.Items.AddRange(New Object() {"12:08:00 PM", "12:08:00", "12:08 PM", "12:08", "1577836800", "04:08 PM UTC"})
        Me.TimeFormatCbDTGen.Location = New System.Drawing.Point(200, 53)
        Me.TimeFormatCbDTGen.Name = "TimeFormatCbDTGen"
        Me.TimeFormatCbDTGen.Size = New System.Drawing.Size(150, 20)
        Me.TimeFormatCbDTGen.TabIndex = 22
        '
        'DateFormatCbDTGen
        '
        Me.DateFormatCbDTGen.FormattingEnabled = True
        Me.DateFormatCbDTGen.Items.AddRange(New Object() {"220101", "20220101", "Tuesday, January 1, 2022", "January 1, 2022", "Jan 1, 22", "Jan 1, 2022", "01/01/22", "21/01/22", "1577836800"})
        Me.DateFormatCbDTGen.Location = New System.Drawing.Point(201, 28)
        Me.DateFormatCbDTGen.Name = "DateFormatCbDTGen"
        Me.DateFormatCbDTGen.Size = New System.Drawing.Size(150, 20)
        Me.DateFormatCbDTGen.TabIndex = 21
        '
        'StartupTabPage
        '
        Me.StartupTabPage.Controls.Add(Me.WDLCTSUCbSUGen)
        Me.StartupTabPage.Controls.Add(Me.WhenIStartupLabelSUGen)
        Me.StartupTabPage.Location = New System.Drawing.Point(4, 21)
        Me.StartupTabPage.Name = "StartupTabPage"
        Me.StartupTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.StartupTabPage.Size = New System.Drawing.Size(482, 236)
        Me.StartupTabPage.TabIndex = 3
        Me.StartupTabPage.Text = "Startup"
        Me.StartupTabPage.UseVisualStyleBackColor = True
        '
        'WDLCTSUCbSUGen
        '
        Me.WDLCTSUCbSUGen.FormattingEnabled = True
        Me.WDLCTSUCbSUGen.Items.AddRange(New Object() {"Go to the break timer tab", "Go to the timer tab"})
        Me.WDLCTSUCbSUGen.Location = New System.Drawing.Point(9, 19)
        Me.WDLCTSUCbSUGen.Name = "WDLCTSUCbSUGen"
        Me.WDLCTSUCbSUGen.Size = New System.Drawing.Size(227, 20)
        Me.WDLCTSUCbSUGen.TabIndex = 8
        '
        'WhenIStartupLabelSUGen
        '
        Me.WhenIStartupLabelSUGen.AutoSize = True
        Me.WhenIStartupLabelSUGen.Location = New System.Drawing.Point(6, 3)
        Me.WhenIStartupLabelSUGen.Name = "WhenIStartupLabelSUGen"
        Me.WhenIStartupLabelSUGen.Size = New System.Drawing.Size(129, 12)
        Me.WhenIStartupLabelSUGen.TabIndex = 7
        Me.WhenIStartupLabelSUGen.Text = "When I start BreakTime..."
        '
        'ResetTabPage
        '
        Me.ResetTabPage.BackColor = System.Drawing.Color.DarkRed
        Me.ResetTabPage.Controls.Add(Me.Label3)
        Me.ResetTabPage.Controls.Add(Me.ResetButtonReGen)
        Me.ResetTabPage.Controls.Add(Me.ResetPromptLabelReGen)
        Me.ResetTabPage.ForeColor = System.Drawing.Color.Red
        Me.ResetTabPage.Location = New System.Drawing.Point(4, 21)
        Me.ResetTabPage.Name = "ResetTabPage"
        Me.ResetTabPage.Size = New System.Drawing.Size(482, 236)
        Me.ResetTabPage.TabIndex = 2
        Me.ResetTabPage.Text = "Danger Zone!"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 23)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "WARNING!"
        '
        'ResetButtonReGen
        '
        Me.ResetButtonReGen.Location = New System.Drawing.Point(17, 61)
        Me.ResetButtonReGen.Name = "ResetButtonReGen"
        Me.ResetButtonReGen.Size = New System.Drawing.Size(186, 48)
        Me.ResetButtonReGen.TabIndex = 14
        Me.ResetButtonReGen.Text = "Reset BreakTime " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DO NOT PRESS UNLESS DOING ON PURPOSE!!"
        Me.ResetButtonReGen.UseVisualStyleBackColor = True
        '
        'ResetPromptLabelReGen
        '
        Me.ResetPromptLabelReGen.AutoSize = True
        Me.ResetPromptLabelReGen.Location = New System.Drawing.Point(14, 34)
        Me.ResetPromptLabelReGen.Name = "ResetPromptLabelReGen"
        Me.ResetPromptLabelReGen.Size = New System.Drawing.Size(210, 24)
        Me.ResetPromptLabelReGen.TabIndex = 13
        Me.ResetPromptLabelReGen.Text = "Any actions that you do on this page are " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "IRREVERSABLE AND IRRECOVERABLE!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'SettingsTC
        '
        Me.SettingsTC.Controls.Add(Me.General)
        Me.SettingsTC.Controls.Add(Me.AutoTime)
        Me.SettingsTC.Controls.Add(Me.Personalization)
        Me.SettingsTC.Controls.Add(Me.Sounds)
        Me.SettingsTC.Controls.Add(Me.About)
        Me.SettingsTC.Dock = System.Windows.Forms.DockStyle.Top
        Me.SettingsTC.ImageList = Me.ImageList1
        Me.SettingsTC.Location = New System.Drawing.Point(0, 0)
        Me.SettingsTC.Name = "SettingsTC"
        Me.SettingsTC.SelectedIndex = 0
        Me.SettingsTC.Size = New System.Drawing.Size(504, 294)
        Me.SettingsTC.TabIndex = 0
        '
        'Personalization
        '
        Me.Personalization.BackColor = System.Drawing.Color.DarkRed
        Me.Personalization.Controls.Add(Me.TabControl1)
        Me.Personalization.Controls.Add(Me.Label9)
        Me.Personalization.ImageIndex = 6
        Me.Personalization.Location = New System.Drawing.Point(4, 23)
        Me.Personalization.Name = "Personalization"
        Me.Personalization.Padding = New System.Windows.Forms.Padding(3)
        Me.Personalization.Size = New System.Drawing.Size(496, 267)
        Me.Personalization.TabIndex = 7
        Me.Personalization.Text = "Personalization"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(6, 34)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(487, 234)
        Me.TabControl1.TabIndex = 14
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ColorWheel2)
        Me.TabPage1.Controls.Add(Me.HexTextBox)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.BTextBox)
        Me.TabPage1.Controls.Add(Me.ColorLabel)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.HexLabel)
        Me.TabPage1.Controls.Add(Me.GTextBox)
        Me.TabPage1.Controls.Add(Me.RTextBox)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Location = New System.Drawing.Point(4, 21)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(479, 209)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Fore Color"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ColorWheel2
        '
        Me.ColorWheel2.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ColorWheel2.Location = New System.Drawing.Point(8, 28)
        Me.ColorWheel2.Name = "ColorWheel2"
        Me.ColorWheel2.Size = New System.Drawing.Size(179, 151)
        Me.ColorWheel2.TabIndex = 14
        '
        'HexTextBox
        '
        Me.HexTextBox.Location = New System.Drawing.Point(255, 65)
        Me.HexTextBox.Name = "HexTextBox"
        Me.HexTextBox.Size = New System.Drawing.Size(56, 20)
        Me.HexTextBox.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(324, 117)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(15, 12)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "B:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(258, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Color"
        '
        'BTextBox
        '
        Me.BTextBox.Location = New System.Drawing.Point(360, 114)
        Me.BTextBox.Name = "BTextBox"
        Me.BTextBox.Size = New System.Drawing.Size(56, 20)
        Me.BTextBox.TabIndex = 12
        '
        'ColorLabel
        '
        Me.ColorLabel.AutoSize = True
        Me.ColorLabel.Location = New System.Drawing.Point(216, 87)
        Me.ColorLabel.Name = "ColorLabel"
        Me.ColorLabel.Size = New System.Drawing.Size(34, 12)
        Me.ColorLabel.TabIndex = 5
        Me.ColorLabel.Text = "Color:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(324, 92)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(17, 12)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "G:"
        '
        'HexLabel
        '
        Me.HexLabel.AutoSize = True
        Me.HexLabel.Location = New System.Drawing.Point(219, 67)
        Me.HexLabel.Name = "HexLabel"
        Me.HexLabel.Size = New System.Drawing.Size(28, 12)
        Me.HexLabel.TabIndex = 7
        Me.HexLabel.Text = "Hex:"
        '
        'GTextBox
        '
        Me.GTextBox.Location = New System.Drawing.Point(360, 90)
        Me.GTextBox.Name = "GTextBox"
        Me.GTextBox.Size = New System.Drawing.Size(56, 20)
        Me.GTextBox.TabIndex = 10
        '
        'RTextBox
        '
        Me.RTextBox.Location = New System.Drawing.Point(360, 65)
        Me.RTextBox.Name = "RTextBox"
        Me.RTextBox.Size = New System.Drawing.Size(56, 20)
        Me.RTextBox.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(324, 67)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(16, 12)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "R:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ColorWheel1)
        Me.TabPage2.Controls.Add(Me.HexTextBoxFC)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.KnownColorLabel)
        Me.TabPage2.Controls.Add(Me.BTextBoxFC)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.GTextBoxFC)
        Me.TabPage2.Controls.Add(Me.RTextBoxFC)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Location = New System.Drawing.Point(4, 21)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(479, 209)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Back Color"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ColorWheel1
        '
        Me.ColorWheel1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ColorWheel1.Location = New System.Drawing.Point(35, 30)
        Me.ColorWheel1.Name = "ColorWheel1"
        Me.ColorWheel1.Size = New System.Drawing.Size(179, 151)
        Me.ColorWheel1.TabIndex = 25
        '
        'HexTextBoxFC
        '
        Me.HexTextBoxFC.Location = New System.Drawing.Point(282, 66)
        Me.HexTextBoxFC.Name = "HexTextBoxFC"
        Me.HexTextBoxFC.Size = New System.Drawing.Size(56, 20)
        Me.HexTextBoxFC.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(351, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 12)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "B:"
        '
        'KnownColorLabel
        '
        Me.KnownColorLabel.AutoSize = True
        Me.KnownColorLabel.Location = New System.Drawing.Point(285, 89)
        Me.KnownColorLabel.Name = "KnownColorLabel"
        Me.KnownColorLabel.Size = New System.Drawing.Size(31, 12)
        Me.KnownColorLabel.TabIndex = 15
        Me.KnownColorLabel.Text = "Color"
        '
        'BTextBoxFC
        '
        Me.BTextBoxFC.Location = New System.Drawing.Point(387, 116)
        Me.BTextBoxFC.Name = "BTextBoxFC"
        Me.BTextBoxFC.Size = New System.Drawing.Size(56, 20)
        Me.BTextBoxFC.TabIndex = 23
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(243, 89)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 12)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Color:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(351, 94)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(17, 12)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "G:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(246, 69)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(28, 12)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "Hex:"
        '
        'GTextBoxFC
        '
        Me.GTextBoxFC.Location = New System.Drawing.Point(387, 91)
        Me.GTextBoxFC.Name = "GTextBoxFC"
        Me.GTextBoxFC.Size = New System.Drawing.Size(56, 20)
        Me.GTextBoxFC.TabIndex = 21
        '
        'RTextBoxFC
        '
        Me.RTextBoxFC.Location = New System.Drawing.Point(387, 66)
        Me.RTextBoxFC.Name = "RTextBoxFC"
        Me.RTextBoxFC.Size = New System.Drawing.Size(56, 20)
        Me.RTextBoxFC.TabIndex = 19
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(351, 69)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(16, 12)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "R:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 12)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Pick your colors!"
        '
        'SettingsForm
        '
        Me.AcceptButton = Me.SaveButtonSettings
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.CancelButton = Me.CancelButtonSettings
        Me.ClientSize = New System.Drawing.Size(504, 350)
        Me.Controls.Add(Me.CancelButtonSettings)
        Me.Controls.Add(Me.SaveButtonSettings)
        Me.Controls.Add(Me.SettingsTC)
        Me.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "SettingsForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.About.ResumeLayout(False)
        Me.About.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Sounds.ResumeLayout(False)
        Me.Sounds.PerformLayout()
        Me.AutoTime.ResumeLayout(False)
        Me.AutoTime.PerformLayout()
        Me.TimerControl.ResumeLayout(False)
        Me.BreakTimerTab.ResumeLayout(False)
        Me.BreakTimerTab.PerformLayout()
        Me.TimerGBBt.ResumeLayout(False)
        Me.TimerGBBt.PerformLayout()
        CType(Me.nudTimeHour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinWarnNudBt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTimeMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTimeBreakSec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTimeSec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTimeBreakMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTimeBreakHour, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BreakGBBt.ResumeLayout(False)
        Me.BreakGBBt.PerformLayout()
        CType(Me.nudb1hour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudb1sec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudb1min, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TimerTab.ResumeLayout(False)
        CType(Me.nudSec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHour, System.ComponentModel.ISupportInitialize).EndInit()
        Me.General.ResumeLayout(False)
        Me.GeneralTabControl.ResumeLayout(False)
        Me.DateTimeTabPage.ResumeLayout(False)
        Me.DateTimeTabPage.PerformLayout()
        Me.StartupTabPage.ResumeLayout(False)
        Me.StartupTabPage.PerformLayout()
        Me.ResetTabPage.ResumeLayout(False)
        Me.ResetTabPage.PerformLayout()
        Me.SettingsTC.ResumeLayout(False)
        Me.Personalization.ResumeLayout(False)
        Me.Personalization.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SaveButtonSettings As Button
    Friend WithEvents CancelButtonSettings As Button
    Friend WithEvents OFDS As OpenFileDialog
    Friend WithEvents About As TabPage
    Friend WithEvents lblVersion As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Sounds As TabPage
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents MWComboBoxS As ComboBox
    Friend WithEvents MWLabelS As Label
    Friend WithEvents TDLabelS As Label
    Friend WithEvents TDComboBoxS As ComboBox
    Friend WithEvents SoundsPromptLabel As Label
    Friend WithEvents AutoTime As TabPage
    Friend WithEvents TimerControl As TabControl
    Friend WithEvents BreakTimerTab As TabPage
    Friend WithEvents TimerGBBt As GroupBox
    Friend WithEvents VisualRbBt As RadioButton
    Friend WithEvents nudTimeHour As NumericUpDown
    Friend WithEvents AudioRbBt As RadioButton
    Friend WithEvents TimeLabelBt As Label
    Friend WithEvents MWLabelBt As Label
    Friend WithEvents MinWarnNudBt As NumericUpDown
    Friend WithEvents BreakTimerLabelBt As Label
    Friend WithEvents nudTimeMin As NumericUpDown
    Friend WithEvents nudTimeBreakSec As NumericUpDown
    Friend WithEvents nudTimeSec As NumericUpDown
    Friend WithEvents nudTimeBreakMin As NumericUpDown
    Friend WithEvents nudTimeBreakHour As NumericUpDown
    Friend WithEvents AutoTimeInstructionsLabelAt As Label
    Friend WithEvents BreakGBBt As GroupBox
    Friend WithEvents lblbreak2 As Label
    Friend WithEvents nudb1hour As NumericUpDown
    Friend WithEvents nudb1sec As NumericUpDown
    Friend WithEvents nudb1min As NumericUpDown
    Friend WithEvents TimeRBBt As RadioButton
    Friend WithEvents BreakRBBt As RadioButton
    Friend WithEvents TimerTab As TabPage
    Friend WithEvents nudSec As NumericUpDown
    Friend WithEvents nudMin As NumericUpDown
    Friend WithEvents nudHour As NumericUpDown
    Friend WithEvents General As TabPage
    Friend WithEvents SettingsTC As TabControl
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Personalization As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents GeneralTabControl As TabControl
    Friend WithEvents DateTimeTabPage As TabPage
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DTLabelDTGen2 As Label
    Friend WithEvents DTLabelDTGen As Label
    Friend WithEvents TimeFormatLabelDTGen As Label
    Friend WithEvents DateFormatLabelDTGen As Label
    Friend WithEvents TimeFormatCbDTGen As ComboBox
    Friend WithEvents DateFormatCbDTGen As ComboBox
    Friend WithEvents StartupTabPage As TabPage
    Friend WithEvents WDLCTSUCbSUGen As ComboBox
    Friend WithEvents WhenIStartupLabelSUGen As Label
    Friend WithEvents ResetTabPage As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents ResetButtonReGen As Button
    Friend WithEvents ResetPromptLabelReGen As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnLicense As Button
    Friend WithEvents BTBrowse As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents BTComboBoxSounds As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents BTextBox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents GTextBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents RTextBox As TextBox
    Friend WithEvents HexLabel As Label
    Friend WithEvents HexTextBox As TextBox
    Friend WithEvents ColorLabel As Label
    Friend WithEvents Panel1 As Cyotek.Windows.Forms.ColorWheel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ColorWheel2 As Cyotek.Windows.Forms.ColorWheel
    Friend WithEvents ColorWheel1 As Cyotek.Windows.Forms.ColorWheel
    Friend WithEvents HexTextBoxFC As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents KnownColorLabel As Label
    Friend WithEvents BTextBoxFC As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents GTextBoxFC As TextBox
    Friend WithEvents RTextBoxFC As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class