﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.Button3 = New System.Windows.Forms.Button()
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
        Me.ColorWheel2 = New Cyotek.Windows.Forms.ColorPickerDialog
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
        Me.ColorWheel1 = New Cyotek.Windows.Forms.ColorPickerDialog
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
        Me.Security = New System.Windows.Forms.TabPage()
        Me.OffRB = New System.Windows.Forms.RadioButton()
        Me.HardcoreLabel = New System.Windows.Forms.Label()
        Me.HardCoreRadioButton = New System.Windows.Forms.RadioButton()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
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
        Me.Security.SuspendLayout()
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
        Me.About.Controls.Add(Me.Button3)
        Me.About.Controls.Add(Me.PictureBox1)
        Me.About.Controls.Add(Me.BtnLicense)
        Me.About.Controls.Add(Me.lblVersion)
        Me.About.Controls.Add(Me.lblName)
        Me.About.ImageKey = "2139.png"
        Me.About.Location = New System.Drawing.Point(4, 23)
        Me.About.Name = "About"
        Me.About.Size = New System.Drawing.Size(496, 267)
        Me.About.TabIndex = 3
        Me.About.Text = "About"
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(184, 77)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 40)
        Me.Button3.TabIndex = 31
        Me.Button3.Text = "&What's New?"
        Me.Button3.UseVisualStyleBackColor = True
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
        Me.BtnLicense.Location = New System.Drawing.Point(265, 77)
        Me.BtnLicense.Name = "BtnLicense"
        Me.BtnLicense.Size = New System.Drawing.Size(75, 40)
        Me.BtnLicense.TabIndex = 3
        Me.BtnLicense.Text = "&License"
        Me.BtnLicense.UseVisualStyleBackColor = True
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(182, 32)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(154, 42)
        Me.lblVersion.TabIndex = 29
        Me.lblVersion.Text = "v21H2 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Beta Four" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Released October 19, 2021"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(181, 11)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(108, 22)
        Me.lblName.TabIndex = 28
        Me.lblName.Text = "BreakTime"
        '
        'Sounds
        '
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
        Me.Sounds.ImageKey = "soundplay.ico"
        Me.Sounds.Location = New System.Drawing.Point(4, 23)
        Me.Sounds.Name = "Sounds"
        Me.Sounds.Size = New System.Drawing.Size(496, 267)
        Me.Sounds.TabIndex = 2
        Me.Sounds.Text = "Sounds"
        '
        'BTBrowse
        '
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
        Me.Label10.Location = New System.Drawing.Point(19, 148)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 14)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Break Over:"
        '
        'BTComboBoxSounds
        '
        Me.BTComboBoxSounds.FormattingEnabled = True
        Me.BTComboBoxSounds.Items.AddRange(New Object() {"Default Sound", "Browse for sound file..."})
        Me.BTComboBoxSounds.Location = New System.Drawing.Point(97, 145)
        Me.BTComboBoxSounds.Name = "BTComboBoxSounds"
        Me.BTComboBoxSounds.Size = New System.Drawing.Size(121, 22)
        Me.BTComboBoxSounds.TabIndex = 12
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(224, 114)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Browse"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
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
        Me.MWComboBoxS.Size = New System.Drawing.Size(121, 22)
        Me.MWComboBoxS.TabIndex = 5
        '
        'MWLabelS
        '
        Me.MWLabelS.AutoSize = True
        Me.MWLabelS.Location = New System.Drawing.Point(33, 119)
        Me.MWLabelS.Name = "MWLabelS"
        Me.MWLabelS.Size = New System.Drawing.Size(55, 14)
        Me.MWLabelS.TabIndex = 4
        Me.MWLabelS.Text = "MinWarn:"
        '
        'TDLabelS
        '
        Me.TDLabelS.AutoSize = True
        Me.TDLabelS.Location = New System.Drawing.Point(19, 88)
        Me.TDLabelS.Name = "TDLabelS"
        Me.TDLabelS.Size = New System.Drawing.Size(72, 14)
        Me.TDLabelS.TabIndex = 3
        Me.TDLabelS.Text = "Timer Done:"
        '
        'TDComboBoxS
        '
        Me.TDComboBoxS.FormattingEnabled = True
        Me.TDComboBoxS.Items.AddRange(New Object() {"Default Sound", "Aquatics Nearby", "Fast and Furious", "Foghorn Leghorn", "211 Default", "Speed Demon", "Browse for sound"})
        Me.TDComboBoxS.Location = New System.Drawing.Point(97, 85)
        Me.TDComboBoxS.Name = "TDComboBoxS"
        Me.TDComboBoxS.Size = New System.Drawing.Size(121, 22)
        Me.TDComboBoxS.TabIndex = 2
        '
        'SoundsPromptLabel
        '
        Me.SoundsPromptLabel.AutoSize = True
        Me.SoundsPromptLabel.Location = New System.Drawing.Point(8, 10)
        Me.SoundsPromptLabel.Name = "SoundsPromptLabel"
        Me.SoundsPromptLabel.Size = New System.Drawing.Size(263, 56)
        Me.SoundsPromptLabel.TabIndex = 1
        Me.SoundsPromptLabel.Text = "With sounds, the program can alert you of when " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "your timer is done, your timer h" &
    "as an exact" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "number of minutes left, or when your break is " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "over."
        '
        'AutoTime
        '
        Me.AutoTime.Controls.Add(Me.TimerControl)
        Me.AutoTime.Controls.Add(Me.AutoTimeInstructionsLabelAt)
        Me.AutoTime.ImageKey = "time.ico"
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
        Me.TimerControl.Location = New System.Drawing.Point(3, 48)
        Me.TimerControl.Multiline = True
        Me.TimerControl.Name = "TimerControl"
        Me.TimerControl.SelectedIndex = 0
        Me.TimerControl.Size = New System.Drawing.Size(490, 216)
        Me.TimerControl.TabIndex = 25
        '
        'BreakTimerTab
        '
        Me.BreakTimerTab.BackColor = System.Drawing.Color.White
        Me.BreakTimerTab.Controls.Add(Me.TimerGBBt)
        Me.BreakTimerTab.ImageKey = "favicon (5).ico"
        Me.BreakTimerTab.Location = New System.Drawing.Point(4, 23)
        Me.BreakTimerTab.Name = "BreakTimerTab"
        Me.BreakTimerTab.Padding = New System.Windows.Forms.Padding(3)
        Me.BreakTimerTab.Size = New System.Drawing.Size(482, 189)
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
        Me.TimerGBBt.Location = New System.Drawing.Point(6, 6)
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
        Me.VisualRbBt.Size = New System.Drawing.Size(55, 18)
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
        Me.nudTimeHour.Size = New System.Drawing.Size(42, 21)
        Me.nudTimeHour.TabIndex = 34
        '
        'AudioRbBt
        '
        Me.AudioRbBt.AutoSize = True
        Me.AudioRbBt.Location = New System.Drawing.Point(118, 70)
        Me.AudioRbBt.Name = "AudioRbBt"
        Me.AudioRbBt.Size = New System.Drawing.Size(56, 18)
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
        Me.TimeLabelBt.Size = New System.Drawing.Size(36, 14)
        Me.TimeLabelBt.TabIndex = 29
        Me.TimeLabelBt.Text = "Time:"
        '
        'MWLabelBt
        '
        Me.MWLabelBt.AutoSize = True
        Me.MWLabelBt.Location = New System.Drawing.Point(6, 78)
        Me.MWLabelBt.Name = "MWLabelBt"
        Me.MWLabelBt.Size = New System.Drawing.Size(55, 14)
        Me.MWLabelBt.TabIndex = 43
        Me.MWLabelBt.Text = "MinWarn:"
        '
        'MinWarnNudBt
        '
        Me.MinWarnNudBt.Location = New System.Drawing.Point(72, 76)
        Me.MinWarnNudBt.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.MinWarnNudBt.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MinWarnNudBt.Name = "MinWarnNudBt"
        Me.MinWarnNudBt.Size = New System.Drawing.Size(40, 21)
        Me.MinWarnNudBt.TabIndex = 60
        Me.MinWarnNudBt.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'BreakTimerLabelBt
        '
        Me.BreakTimerLabelBt.AutoSize = True
        Me.BreakTimerLabelBt.Location = New System.Drawing.Point(19, 50)
        Me.BreakTimerLabelBt.Name = "BreakTimerLabelBt"
        Me.BreakTimerLabelBt.Size = New System.Drawing.Size(42, 14)
        Me.BreakTimerLabelBt.TabIndex = 31
        Me.BreakTimerLabelBt.Text = "Break:"
        '
        'nudTimeMin
        '
        Me.nudTimeMin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.nudTimeMin.Location = New System.Drawing.Point(120, 18)
        Me.nudTimeMin.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudTimeMin.Name = "nudTimeMin"
        Me.nudTimeMin.Size = New System.Drawing.Size(41, 21)
        Me.nudTimeMin.TabIndex = 35
        '
        'nudTimeBreakSec
        '
        Me.nudTimeBreakSec.ForeColor = System.Drawing.SystemColors.ControlText
        Me.nudTimeBreakSec.Location = New System.Drawing.Point(167, 48)
        Me.nudTimeBreakSec.Name = "nudTimeBreakSec"
        Me.nudTimeBreakSec.Size = New System.Drawing.Size(40, 21)
        Me.nudTimeBreakSec.TabIndex = 39
        '
        'nudTimeSec
        '
        Me.nudTimeSec.ForeColor = System.Drawing.SystemColors.ControlText
        Me.nudTimeSec.Location = New System.Drawing.Point(167, 18)
        Me.nudTimeSec.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudTimeSec.Name = "nudTimeSec"
        Me.nudTimeSec.Size = New System.Drawing.Size(40, 21)
        Me.nudTimeSec.TabIndex = 36
        '
        'nudTimeBreakMin
        '
        Me.nudTimeBreakMin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.nudTimeBreakMin.Location = New System.Drawing.Point(120, 48)
        Me.nudTimeBreakMin.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudTimeBreakMin.Name = "nudTimeBreakMin"
        Me.nudTimeBreakMin.Size = New System.Drawing.Size(41, 21)
        Me.nudTimeBreakMin.TabIndex = 38
        '
        'nudTimeBreakHour
        '
        Me.nudTimeBreakHour.ForeColor = System.Drawing.SystemColors.ControlText
        Me.nudTimeBreakHour.Location = New System.Drawing.Point(72, 48)
        Me.nudTimeBreakHour.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudTimeBreakHour.Name = "nudTimeBreakHour"
        Me.nudTimeBreakHour.Size = New System.Drawing.Size(42, 21)
        Me.nudTimeBreakHour.TabIndex = 37
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
        Me.TimerTab.Size = New System.Drawing.Size(482, 189)
        Me.TimerTab.TabIndex = 1
        Me.TimerTab.Text = "Timer"
        '
        'nudSec
        '
        Me.nudSec.Location = New System.Drawing.Point(253, 28)
        Me.nudSec.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudSec.Name = "nudSec"
        Me.nudSec.Size = New System.Drawing.Size(50, 21)
        Me.nudSec.TabIndex = 10
        '
        'nudMin
        '
        Me.nudMin.Location = New System.Drawing.Point(197, 28)
        Me.nudMin.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudMin.Name = "nudMin"
        Me.nudMin.Size = New System.Drawing.Size(50, 21)
        Me.nudMin.TabIndex = 9
        '
        'nudHour
        '
        Me.nudHour.Location = New System.Drawing.Point(141, 28)
        Me.nudHour.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudHour.Name = "nudHour"
        Me.nudHour.Size = New System.Drawing.Size(50, 21)
        Me.nudHour.TabIndex = 8
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "break.ico")
        Me.ImageList1.Images.SetKeyName(1, "soundplay.ico")
        Me.ImageList1.Images.SetKeyName(2, "info.ico")
        Me.ImageList1.Images.SetKeyName(3, "settings.ico")
        Me.ImageList1.Images.SetKeyName(4, "time.ico")
        Me.ImageList1.Images.SetKeyName(5, "1f50c.ico")
        Me.ImageList1.Images.SetKeyName(6, "pbrush.ico")
        '
        'AutoTimeInstructionsLabelAt
        '
        Me.AutoTimeInstructionsLabelAt.AutoSize = True
        Me.AutoTimeInstructionsLabelAt.Location = New System.Drawing.Point(4, 3)
        Me.AutoTimeInstructionsLabelAt.Name = "AutoTimeInstructionsLabelAt"
        Me.AutoTimeInstructionsLabelAt.Size = New System.Drawing.Size(290, 42)
        Me.AutoTimeInstructionsLabelAt.TabIndex = 0
        Me.AutoTimeInstructionsLabelAt.Text = "AutoTime enables you to set your time more faster!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "With this feature, the progra" &
    "m starts as is, but starts" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the timer you want automatically."
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
        Me.DateTimeTabPage.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeTabPage.Location = New System.Drawing.Point(4, 23)
        Me.DateTimeTabPage.Name = "DateTimeTabPage"
        Me.DateTimeTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.DateTimeTabPage.Size = New System.Drawing.Size(482, 234)
        Me.DateTimeTabPage.TabIndex = 0
        Me.DateTimeTabPage.Text = "Date/Time"
        Me.DateTimeTabPage.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(209, 130)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 14)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Date/Time Format:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(188, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 14)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Date Format for Break:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(105, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 14)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Date Format for Break:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"220101", "20220101", "01/01/22", "21/01/22", "01/01/2022", "1577836800"})
        Me.ComboBox1.Location = New System.Drawing.Point(250, 78)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 22)
        Me.ComboBox1.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(179, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 14)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Wednesday, January 1, 2023"
        '
        'DTLabelDTGen2
        '
        Me.DTLabelDTGen2.AutoSize = True
        Me.DTLabelDTGen2.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTLabelDTGen2.Location = New System.Drawing.Point(215, 154)
        Me.DTLabelDTGen2.Name = "DTLabelDTGen2"
        Me.DTLabelDTGen2.Size = New System.Drawing.Size(71, 14)
        Me.DTLabelDTGen2.TabIndex = 26
        Me.DTLabelDTGen2.Text = "12:08:00 PM"
        '
        'DTLabelDTGen
        '
        Me.DTLabelDTGen.AutoSize = True
        Me.DTLabelDTGen.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTLabelDTGen.Location = New System.Drawing.Point(182, 142)
        Me.DTLabelDTGen.Name = "DTLabelDTGen"
        Me.DTLabelDTGen.Size = New System.Drawing.Size(155, 14)
        Me.DTLabelDTGen.TabIndex = 25
        Me.DTLabelDTGen.Text = "Wednesday, January 1, 2023"
        '
        'TimeFormatLabelDTGen
        '
        Me.TimeFormatLabelDTGen.AutoSize = True
        Me.TimeFormatLabelDTGen.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeFormatLabelDTGen.Location = New System.Drawing.Point(114, 56)
        Me.TimeFormatLabelDTGen.Name = "TimeFormatLabelDTGen"
        Me.TimeFormatLabelDTGen.Size = New System.Drawing.Size(77, 14)
        Me.TimeFormatLabelDTGen.TabIndex = 24
        Me.TimeFormatLabelDTGen.Text = "Time Format:"
        '
        'DateFormatLabelDTGen
        '
        Me.DateFormatLabelDTGen.AutoSize = True
        Me.DateFormatLabelDTGen.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFormatLabelDTGen.Location = New System.Drawing.Point(114, 31)
        Me.DateFormatLabelDTGen.Name = "DateFormatLabelDTGen"
        Me.DateFormatLabelDTGen.Size = New System.Drawing.Size(79, 14)
        Me.DateFormatLabelDTGen.TabIndex = 23
        Me.DateFormatLabelDTGen.Text = "Date Format:"
        '
        'TimeFormatCbDTGen
        '
        Me.TimeFormatCbDTGen.FormattingEnabled = True
        Me.TimeFormatCbDTGen.Items.AddRange(New Object() {"12:08:00 PM", "12:08:00", "12:08 PM", "12:08", "1577836800", "04:08 PM UTC"})
        Me.TimeFormatCbDTGen.Location = New System.Drawing.Point(200, 53)
        Me.TimeFormatCbDTGen.Name = "TimeFormatCbDTGen"
        Me.TimeFormatCbDTGen.Size = New System.Drawing.Size(150, 22)
        Me.TimeFormatCbDTGen.TabIndex = 22
        '
        'DateFormatCbDTGen
        '
        Me.DateFormatCbDTGen.FormattingEnabled = True
        Me.DateFormatCbDTGen.Items.AddRange(New Object() {"220101", "20220101", "Tuesday, January 1, 2022", "January 1, 2022", "Jan 1, 22", "Jan 1, 2022", "01/01/22", "21/01/22", "1577836800"})
        Me.DateFormatCbDTGen.Location = New System.Drawing.Point(201, 28)
        Me.DateFormatCbDTGen.Name = "DateFormatCbDTGen"
        Me.DateFormatCbDTGen.Size = New System.Drawing.Size(150, 22)
        Me.DateFormatCbDTGen.TabIndex = 21
        '
        'StartupTabPage
        '
        Me.StartupTabPage.Controls.Add(Me.WDLCTSUCbSUGen)
        Me.StartupTabPage.Controls.Add(Me.WhenIStartupLabelSUGen)
        Me.StartupTabPage.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartupTabPage.Location = New System.Drawing.Point(4, 23)
        Me.StartupTabPage.Name = "StartupTabPage"
        Me.StartupTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.StartupTabPage.Size = New System.Drawing.Size(482, 234)
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
        Me.WDLCTSUCbSUGen.Size = New System.Drawing.Size(227, 22)
        Me.WDLCTSUCbSUGen.TabIndex = 8
        '
        'WhenIStartupLabelSUGen
        '
        Me.WhenIStartupLabelSUGen.AutoSize = True
        Me.WhenIStartupLabelSUGen.Location = New System.Drawing.Point(6, 3)
        Me.WhenIStartupLabelSUGen.Name = "WhenIStartupLabelSUGen"
        Me.WhenIStartupLabelSUGen.Size = New System.Drawing.Size(143, 14)
        Me.WhenIStartupLabelSUGen.TabIndex = 7
        Me.WhenIStartupLabelSUGen.Text = "When I start BreakTime..."
        '
        'ResetTabPage
        '
        Me.ResetTabPage.BackColor = System.Drawing.Color.DarkRed
        Me.ResetTabPage.Controls.Add(Me.Label3)
        Me.ResetTabPage.Controls.Add(Me.ResetButtonReGen)
        Me.ResetTabPage.Controls.Add(Me.ResetPromptLabelReGen)
        Me.ResetTabPage.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetTabPage.ForeColor = System.Drawing.Color.Red
        Me.ResetTabPage.Location = New System.Drawing.Point(4, 23)
        Me.ResetTabPage.Name = "ResetTabPage"
        Me.ResetTabPage.Size = New System.Drawing.Size(482, 234)
        Me.ResetTabPage.TabIndex = 2
        Me.ResetTabPage.Text = "Danger Zone!"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Helvetica", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 22)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "WARNING!"
        '
        'ResetButtonReGen
        '
        Me.ResetButtonReGen.Location = New System.Drawing.Point(17, 61)
        Me.ResetButtonReGen.Name = "ResetButtonReGen"
        Me.ResetButtonReGen.Size = New System.Drawing.Size(186, 66)
        Me.ResetButtonReGen.TabIndex = 14
        Me.ResetButtonReGen.Text = "Reset BreakTime " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DO NOT PRESS UNLESS DOING ON PURPOSE!!"
        Me.ResetButtonReGen.UseVisualStyleBackColor = True
        '
        'ResetPromptLabelReGen
        '
        Me.ResetPromptLabelReGen.AutoSize = True
        Me.ResetPromptLabelReGen.Location = New System.Drawing.Point(14, 34)
        Me.ResetPromptLabelReGen.Name = "ResetPromptLabelReGen"
        Me.ResetPromptLabelReGen.Size = New System.Drawing.Size(232, 28)
        Me.ResetPromptLabelReGen.TabIndex = 13
        Me.ResetPromptLabelReGen.Text = "Any actions that you do on this page are " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "IRREVERSABLE AND IRRECOVERABLE!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'SettingsTC
        '
        Me.SettingsTC.Controls.Add(Me.General)
        Me.SettingsTC.Controls.Add(Me.AutoTime)
        Me.SettingsTC.Controls.Add(Me.Personalization)
        Me.SettingsTC.Controls.Add(Me.Sounds)
        Me.SettingsTC.Controls.Add(Me.Security)
        Me.SettingsTC.Controls.Add(Me.About)
        Me.SettingsTC.Dock = System.Windows.Forms.DockStyle.Top
        Me.SettingsTC.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingsTC.ImageList = Me.ImageList1
        Me.SettingsTC.Location = New System.Drawing.Point(0, 0)
        Me.SettingsTC.Name = "SettingsTC"
        Me.SettingsTC.SelectedIndex = 0
        Me.SettingsTC.Size = New System.Drawing.Size(504, 294)
        Me.SettingsTC.TabIndex = 0
        '
        'Personalization
        '
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
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(479, 207)
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
        Me.HexTextBox.Size = New System.Drawing.Size(56, 21)
        Me.HexTextBox.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(324, 117)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(20, 14)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "B:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(258, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Color"
        '
        'BTextBox
        '
        Me.BTextBox.Location = New System.Drawing.Point(360, 114)
        Me.BTextBox.Name = "BTextBox"
        Me.BTextBox.Size = New System.Drawing.Size(56, 21)
        Me.BTextBox.TabIndex = 12
        '
        'ColorLabel
        '
        Me.ColorLabel.AutoSize = True
        Me.ColorLabel.Location = New System.Drawing.Point(216, 87)
        Me.ColorLabel.Name = "ColorLabel"
        Me.ColorLabel.Size = New System.Drawing.Size(40, 14)
        Me.ColorLabel.TabIndex = 5
        Me.ColorLabel.Text = "Color:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(324, 92)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(19, 14)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "G:"
        '
        'HexLabel
        '
        Me.HexLabel.AutoSize = True
        Me.HexLabel.Location = New System.Drawing.Point(219, 67)
        Me.HexLabel.Name = "HexLabel"
        Me.HexLabel.Size = New System.Drawing.Size(32, 14)
        Me.HexLabel.TabIndex = 7
        Me.HexLabel.Text = "Hex:"
        '
        'GTextBox
        '
        Me.GTextBox.Location = New System.Drawing.Point(360, 90)
        Me.GTextBox.Name = "GTextBox"
        Me.GTextBox.Size = New System.Drawing.Size(56, 21)
        Me.GTextBox.TabIndex = 10
        '
        'RTextBox
        '
        Me.RTextBox.Location = New System.Drawing.Point(360, 65)
        Me.RTextBox.Name = "RTextBox"
        Me.RTextBox.Size = New System.Drawing.Size(56, 21)
        Me.RTextBox.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(324, 67)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(20, 14)
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
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(479, 207)
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
        Me.HexTextBoxFC.Size = New System.Drawing.Size(56, 21)
        Me.HexTextBoxFC.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(351, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 14)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "B:"
        '
        'KnownColorLabel
        '
        Me.KnownColorLabel.AutoSize = True
        Me.KnownColorLabel.Location = New System.Drawing.Point(285, 89)
        Me.KnownColorLabel.Name = "KnownColorLabel"
        Me.KnownColorLabel.Size = New System.Drawing.Size(36, 14)
        Me.KnownColorLabel.TabIndex = 15
        Me.KnownColorLabel.Text = "Color"
        '
        'BTextBoxFC
        '
        Me.BTextBoxFC.Location = New System.Drawing.Point(387, 116)
        Me.BTextBoxFC.Name = "BTextBoxFC"
        Me.BTextBoxFC.Size = New System.Drawing.Size(56, 21)
        Me.BTextBoxFC.TabIndex = 23
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(243, 89)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 14)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Color:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(351, 94)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(19, 14)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "G:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(246, 69)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(32, 14)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "Hex:"
        '
        'GTextBoxFC
        '
        Me.GTextBoxFC.Location = New System.Drawing.Point(387, 91)
        Me.GTextBoxFC.Name = "GTextBoxFC"
        Me.GTextBoxFC.Size = New System.Drawing.Size(56, 21)
        Me.GTextBoxFC.TabIndex = 21
        '
        'RTextBoxFC
        '
        Me.RTextBoxFC.Location = New System.Drawing.Point(387, 66)
        Me.RTextBoxFC.Name = "RTextBoxFC"
        Me.RTextBoxFC.Size = New System.Drawing.Size(56, 21)
        Me.RTextBoxFC.TabIndex = 19
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(351, 69)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(20, 14)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "R:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 14)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Pick your colors!"
        '
        'Security
        '
        Me.Security.BackColor = System.Drawing.SystemColors.Control
        Me.Security.Controls.Add(Me.OffRB)
        Me.Security.Controls.Add(Me.HardcoreLabel)
        Me.Security.Controls.Add(Me.HardCoreRadioButton)
        Me.Security.ImageKey = "break.ico"
        Me.Security.Location = New System.Drawing.Point(4, 23)
        Me.Security.Name = "Security"
        Me.Security.Padding = New System.Windows.Forms.Padding(3)
        Me.Security.Size = New System.Drawing.Size(496, 267)
        Me.Security.TabIndex = 8
        Me.Security.Text = "Security"
        '
        'OffRB
        '
        Me.OffRB.AutoSize = True
        Me.OffRB.Location = New System.Drawing.Point(57, 100)
        Me.OffRB.Name = "OffRB"
        Me.OffRB.Size = New System.Drawing.Size(43, 18)
        Me.OffRB.TabIndex = 2
        Me.OffRB.TabStop = True
        Me.OffRB.Text = "Off"
        Me.OffRB.UseVisualStyleBackColor = True
        '
        'HardcoreLabel
        '
        Me.HardcoreLabel.AutoSize = True
        Me.HardcoreLabel.Location = New System.Drawing.Point(4, 4)
        Me.HardcoreLabel.Name = "HardcoreLabel"
        Me.HardcoreLabel.Size = New System.Drawing.Size(223, 84)
        Me.HardcoreLabel.TabIndex = 1
        Me.HardcoreLabel.Text = "Hardcore Mode" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hardcore Mode turns the application" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "into a lockdown browser disab" &
    "ling ALL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "key input and preventing unlock or pause" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "functions." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You can also pro" &
    "vide a captcha to solve!"
        '
        'HardCoreRadioButton
        '
        Me.HardCoreRadioButton.AutoSize = True
        Me.HardCoreRadioButton.Location = New System.Drawing.Point(8, 100)
        Me.HardCoreRadioButton.Name = "HardCoreRadioButton"
        Me.HardCoreRadioButton.Size = New System.Drawing.Size(41, 18)
        Me.HardCoreRadioButton.TabIndex = 0
        Me.HardCoreRadioButton.TabStop = True
        Me.HardCoreRadioButton.Text = "On"
        Me.HardCoreRadioButton.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'SettingsForm
        '
        Me.AcceptButton = Me.SaveButtonSettings
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CancelButtonSettings
        Me.ClientSize = New System.Drawing.Size(504, 350)
        Me.Controls.Add(Me.CancelButtonSettings)
        Me.Controls.Add(Me.SaveButtonSettings)
        Me.Controls.Add(Me.SettingsTC)
        Me.Font = New System.Drawing.Font("Helvetica", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.TimerGBBt.ResumeLayout(False)
        Me.TimerGBBt.PerformLayout()
        CType(Me.nudTimeHour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinWarnNudBt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTimeMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTimeBreakSec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTimeSec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTimeBreakMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTimeBreakHour, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.Security.ResumeLayout(False)
        Me.Security.PerformLayout()
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
    Friend WithEvents TimerTab As TabPage
    Friend WithEvents nudSec As NumericUpDown
    Friend WithEvents nudMin As NumericUpDown
    Friend WithEvents nudHour As NumericUpDown
    Friend WithEvents General As TabPage
    Friend WithEvents SettingsTC As TabControl
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Personalization As TabPage
    Friend WithEvents Label2 As Label
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
    Friend WithEvents Panel1 As Cyotek.Windows.Forms.ColorPickerDialog
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ColorWheel2 As Cyotek.Windows.Forms.ColorPickerDialog
    Friend WithEvents ColorWheel1 As Cyotek.Windows.Forms.ColorPickerDialog
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
    Friend WithEvents Button3 As Button
    Friend WithEvents Security As TabPage
    Friend WithEvents OffRB As RadioButton
    Friend WithEvents HardcoreLabel As Label
    Friend WithEvents HardCoreRadioButton As RadioButton
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
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class