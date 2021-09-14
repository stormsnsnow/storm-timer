Imports System.Globalization
Imports System
Imports System.IO
Imports System.Text
Imports System.Net

Imports BreakTime.Org.Mentalis.Utilities

Imports System.Media


Public Class MainForm
    Dim sound As New SoundPlayer
    Private WithEvents Tmras As New Timer With {.Interval = 30}
    Private ShowSize As Size
    Private wstep, hstep As Double
    Private ww, hh As Double
    ReadOnly time As Date
    ReadOnly CurrHour As Integer
    ReadOnly CurrMinute As Integer

    Private ReadOnly PopHide As Boolean = False
    Dim Notify As Boolean = False
    Public sethours, setmins, setsecs As Integer
    Public hour, min, sec As Integer
    Public hours, min1, sec1 As Integer
    Public sethours1, setmins1, setsecs1 As Integer
    Public hoursh, minsh, secsh As Integer
    Public sethoursh, setminsh, setsecsh As Integer

    Private ReadOnly SW As New Stopwatch
    Private WithEvents Tmr As New System.Windows.Forms.Timer
    Private ReadOnly timeList As New List(Of Integer)


    Private Sub PlayNow()
        Select Case My.Settings.Sound2
            Case 0
                sound.Stream = My.Resources.minwarn4
                sound.Play()
            Case 1 Or 2 Or 3
                sound.SoundLocation = My.Settings.Sound2Location
                sound.Play()
        End Select

    End Sub
    Private Sub Pausebutton_Click(sender As Object, e As EventArgs) Handles PauseButtonBT.Click
        BreakTimer.Stop()
        BreakTimer.Enabled = False
        btnResume.Show()
        PauseButtonBT.Hide()
        btnStop.Show()
        BreakNowButtonBt.Hide()
    End Sub
    Private Sub FrmLAG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimeBomb.Start()
        TitlePanel.BackColor = System.Drawing.ColorTranslator.FromHtml(CStr(CStr(My.Settings.BackColor.ToArgb)))
        TitlePanel.ForeColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.ForeColor.ToArgb))
        ShutdownTabPage.BackColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.BackColor.ToArgb))
        ShutdownTabPage.ForeColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.ForeColor.ToArgb))
        TimerTab.BackColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.BackColor.ToArgb))
        TimerTab.ForeColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.ForeColor.ToArgb))
        BreakTimerTab.BackColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.BackColor.ToArgb))
        BreakTimerTab.ForeColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.ForeColor.ToArgb))
        StopWatchTab.BackColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.BackColor.ToArgb))
        StopWatchTab.ForeColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.ForeColor.ToArgb))
        AlarmClockTab.BackColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.BackColor.ToArgb))
        AlarmClockTab.ForeColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.ForeColor.ToArgb))

        Me.ForeColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.ForeColor.ToArgb))
        Me.BackColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.BackColor.ToArgb))
        TimerControl.ForeColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.ForeColor.ToArgb))
        TimerControl.BackColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.BackColor.ToArgb))



        Select Case My.Settings.Startup
            Case 0
                BreakTimerTab.Show()
            Case 1
                TimerTab.Show()
            Case 2
                AlarmClockTab.Show()
            Case 3
                StopWatchTab.Show()
            Case 4
                ShutdownTabPage.Show()

        End Select

        Tmr.Interval = 100

        LapListBoxSw.Items.Clear()
        YDTimer.Start()

        nudTimeHour.Value = CDec(My.Settings.AutoTimeBTTHour)
        nudTimeMin.Value = CDec(My.Settings.AutoTimeBTTMin)
        nudTimeSec.Value = CDec(My.Settings.AutoTimeBTTSec)
        B1HourNudBT.Value = CDec(My.Settings.AutoTimeBTB1Hour)
        nudb1min.Value = CDec(My.Settings.AutoTimeBTB1Min)
        nudb1sec.Value = CDec(My.Settings.AutoTimeBTB1Sec)
        MinWarnNudBt.Value = CDec(My.Settings.MWAutoTime)
        If My.Settings.AudioOrVisual = True Then
            AudioRbBt.Checked = True
            VisualRbBt.Checked = False
        ElseIf My.Settings.AudioOrVisual = False Then
            AudioRbBt.Checked = False
            VisualRbBt.Checked = True
        End If


        B1HourNudBT.Value = 0
            nudb1min.Value = 0
            nudb1sec.Value = 0


        nudTimeBreakMin.Value = 0
            nudTimeBreakHour.Value = 0
            nudTimeBreakSec.Value = 0
            nudTimeHour.Value = 0
            nudTimeMin.Value = 0
            nudTimeSec.Value = 0
            MinWarnNudBt.Value = 1
            AudioRbBt.Checked = False
            VisualRbBt.Checked = False

        nudHour.Value = CDec(My.Settings.AutoTimeTTHour)
        nudMin.Value = CDec(My.Settings.AutoTimeTTMin)
        nudSec.Value = CDec(My.Settings.AutoTimeTTSec)
        lblwelcome.Text = "welcome, " & SystemInformation.UserName

    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButtonSW.Click
        BreakTimerTab.Enabled = False
        TimerTab.Enabled = False
        AlarmClockTab.Enabled = False
        ShutdownTabPage.Enabled = False
        SW.Start()
        Tmr.Start()
        PauseButtonSW.Show()
        StartButtonSW.Hide()
        StopButtonSW.Show()
        ResumeButtonSW.Hide()
    End Sub
    Private Sub Tmr_Tick(sender As Object, e As System.EventArgs) Handles Tmr.Tick
        StopwatchLabelSW.Text = SW.Elapsed.ToString
    End Sub
    Private Sub LapButton_Click(sender As Object, e As EventArgs) Handles LapButtonSW.Click

        timeList.Add(CInt(SW.ElapsedMilliseconds))
        LapListBoxSw.Show()
        Dim tim As TimeSpan = New TimeSpan(SW.ElapsedMilliseconds)
        LapListBoxSw.Items.Add(tim.ToString("T"))
    End Sub



    Private Sub PauseButton_Click_1(sender As Object, e As EventArgs) Handles PauseButtonSW.Click
        SW.Stop()
        Tmr.Stop()
        ResumeButtonSW.Show()
        PauseButtonSW.Hide()
        StopButtonSW.Hide()
        StartButtonSW.Hide()
    End Sub



    Private Sub BtnResume_Click(sender As Object, e As EventArgs) Handles btnResume.Click
        BreakTimer.Start()
        PauseButtonBT.Show()
        btnResume.Hide()
        btnStop.Show()
        StartButtonBT.Hide()
        BreakNowButtonBt.Show()
    End Sub

    Private Sub StopTimeButton_Click(sender As Object, e As EventArgs) Handles StopTimeButton.Click
        TimerTimer.Stop()
        PauseButtonT.Hide()
        ResumeTimeButton.Hide()
        StopTimeButton.Hide()
        StartTimeButton.Show()
        sec1 = 0
        min1 = 0
        hours = 0
        nudHour.Show()
        nudMin.Show()
        nudSec.Show()
        BreakTimerTab.Enabled = True
        StopWatchTab.Enabled = True
        ShutdownTabPage.Enabled = True
        AlarmClockTab.Enabled = True
        StopWatchTab.Enabled = True
        ShutdownTabPage.Enabled = True
    End Sub
    Private Sub CancelAlarmButton_Click(sender As Object, e As EventArgs) Handles CancelAlarmButton.Click
        AlarmTimer.Enabled = False
        SetOrNotSetLabel.Text = "Please set alarm."
        HourNudAC.Enabled = True
        MinNudAC.Enabled = True
        SecNudAC.Enabled = True
        SetAlarmButton.Enabled = True
        SetAlarmButton.Show()
        CancelAlarmButton.Enabled = False
        CancelAlarmButton.Hide()
        AlarmClockTab.Enabled = True
        StopWatchTab.Enabled = True
        ShutdownTabPage.Enabled = True
    End Sub
    Private Sub StartAlarmButton_Click(sender As Object, e As EventArgs) Handles SetAlarmButton.Click
        TimerTab.Enabled = False

        StopWatchTab.Enabled = False
        ShutdownTabPage.Enabled = False
        AlarmTimer.Enabled = True
        SetOrNotSetLabel.Text = "Set"
        HourNudAC.Enabled = False
        MinNudAC.Enabled = False
        SecNudAC.Enabled = False

        SetAlarmButton.Enabled = False
        SetAlarmButton.Hide()
        CancelAlarmButton.Enabled = True
        CancelAlarmButton.Show()
    End Sub


    Private Sub AlarmTimer_Tick(sender As Object, e As EventArgs) Handles AlarmTimer.Tick

        If Now.Hour = HourNudAC.Value AndAlso Now.Minute = MinNudAC.Value AndAlso Now.Second = SecNudAC.Value Then
            AlarmTimer.Enabled = False
            tBeep.Enabled = True

            If MsgBox("It is " + Now.ToShortTimeString + ".", MsgBoxStyle.Information, "Alarm") = System.Windows.Forms.DialogResult.OK Then
                tBeep.Enabled = False
                HourNudAC.Enabled = True
                MinNudAC.Enabled = True
                SecNudAC.Enabled = True
                SetAlarmButton.Enabled = True
                SetAlarmButton.Show()
                CancelAlarmButton.Enabled = False
                CancelAlarmButton.Hide()
                SetOrNotSetLabel.Text = "Not Set"
                ShutdownTabPage.Enabled = True
                StopWatchTab.Enabled = True
                TimerTab.Enabled = True
            End If
        Else
        End If
    End Sub


    Private Sub PauseTimeButton_Click(sender As Object, e As EventArgs) Handles PauseButtonT.Click
        TimerTimer.Stop()
        PauseButtonT.Hide()
        ResumeTimeButton.Show()
        StopTimeButton.Hide()
        StartTimeButton.Hide()
    End Sub

    Private Sub TBeep_Tick(sender As Object, e As EventArgs) Handles tBeep.Tick

        sound.Stream = My.Resources.timesup4
        sound.Play()

        System.Threading.Thread.Sleep(3000)
    End Sub

    Private Sub ShowWindowToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Show()
        ElseIf Me.WindowState = FormWindowState.Normal Then
            Me.Hide()
        End If
    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles StartTimeButton.Click
        AlarmClockTab.Enabled = False
        StopWatchTab.Enabled = False
        ShutdownTabPage.Enabled = False
        sethours1 = CInt(nudHour.Value)
        hours = sethours1
        setmins1 = CInt(nudMin.Value)
        min1 = setmins1
        setsecs1 = CInt(nudSec.Value)
        sec1 = setsecs1
        TimerTimer.Enabled = True
        PauseButtonT.Show()
        ResumeTimeButton.Hide()
        StopTimeButton.Show()
        StartTimeButton.Hide()
        nudSec.Hide()
        nudMin.Hide()
        nudHour.Hide()

    End Sub

    Private Sub StartButtonSh_Click(sender As Object, e As EventArgs) Handles StartButtonSh.Click
        If HourNudSh.Value = 0 AndAlso MinuteNudSh.Value = 0 AndAlso SecondNudSh.Value = 0 Then
            Exit Sub
        Else

        End If


        TimerTab.Enabled = False
        StopWatchTab.Enabled = False
        AlarmClockTab.Enabled = False
        BreakTimerTab.Enabled = False
        InSettingsGBSH.Hide()

        Me.WindowState = FormWindowState.Minimized
        ShutdownTimer.Enabled = True
        ShutdownTimer.Start()
        sethoursh = CInt(HourNudSh.Value)
        setminsh = CInt(MinuteNudSh.Value)
        setsecsh = CInt(SecondNudSh.Value)
        hoursh = sethoursh
        minsh = setminsh
        secsh = setsecsh
        StartButtonSh.Hide()
        PauseButtonSh.Show()
        ResumeButtonSh.Hide()
        StopButtonSh.Show()
        Notify = False




    End Sub

    Private Sub PauseButtonSh_Click(sender As Object, e As EventArgs) Handles PauseButtonSh.Click
        ShutdownTimer.Stop()
        PauseButtonSW.Hide()
        StopButtonSh.Show()
        ResumeButtonSh.Show()
        StartButtonSW.Hide()
    End Sub

    Private Function FormatTo2Digits(ByVal Val As Integer) As String
        Dim newVal As String
        Dim len As Integer = Val.ToString.Length

        If len = 1 Then
            newVal = "0" + Val.ToString
            Return newVal
        Else
            Return Val.ToString
        End If
    End Function



    Private Sub YDTimer_Tick(sender As Object, e As EventArgs) Handles YDTimer.Tick
        Select Case My.Settings.TimeFormat

            Case 0

                Dim hourtime As DateTime = CDate(Now.ToString("HH:mm:ss tt", CultureInfo.InvariantCulture))
                TimeLabelYD.Text = "the time is " & hourtime

            Case 1
                TimeLabelYD.Text = "the time is " & Now.ToString("HH:mm:ss")
            Case 2
                TimeLabelYD.Text = "the time is " & Now.ToShortTimeString
            Case 3

                TimeLabelYD.Text = "the time is " & Now.ToString("HH:mm")
        End Select
        Select Case My.Settings.DateFormat
            Case 0
                DateLabelYD.Text = "the date is " & Now.ToString("yyMMdd")
            Case 1
                DateLabelYD.Text = "the date is " & Now.ToString("yyyyMMdd")
            Case 2
                Dim myCulture As System.Globalization.CultureInfo = Globalization.CultureInfo.CurrentCulture
                Dim dayOfWeek As DayOfWeek = myCulture.Calendar.GetDayOfWeek(Date.Today)
                Dim dayName As String = myCulture.DateTimeFormat.GetDayName(dayOfWeek)
                Dim datetime As DateTime = Date.Now
                DateLabelYD.Text = "the date is " & dayName & " " & MonthName(Now.Month, False) & " " & Now.Day & " " & Now.Year
            Case 3
                DateLabelYD.Text = "the date is " & MonthName(Now.Month, False) & " " & Now.Day & " " & Now.Year
            Case 4
                Dim dt As New DateTimeFormatInfo
                DateLabelYD.Text = "the date is " & dt.GetAbbreviatedMonthName(Now.Month) & " " & Now.Day & " " & Now.ToString("yy")
            Case 5
                Dim dt As New DateTimeFormatInfo
                DateLabelYD.Text = "the date is " & dt.GetAbbreviatedMonthName(Now.Month) & " " & Now.Day & " " & Now.Year
            Case 6
                DateLabelYD.Text = "the date is " & Now.ToString("MM/dd/yy")
            Case 7
                DateLabelYD.Text = "the date is " & Now.ToString("dd/MM/yy")
        End Select




    End Sub

    Private Sub SettingsButton_Click(sender As Object, e As EventArgs) Handles SettingsButton.Click
        SettingsForm.Show()
        Me.Close()
    End Sub




    Private Sub Nudb1hour_ValueChanged(sender As Object, e As EventArgs) Handles B1HourNudBT.ValueChanged

        BreakTimeLabelBT.Text = B1HourNudBT.Value.ToString("0#") & ":" & nudb1min.Value.ToString("0#") & ":" & nudb1sec.Value.ToString("0#")
    End Sub

    Private Sub Nudb1min_ValueChanged(sender As Object, e As EventArgs) Handles nudb1min.ValueChanged


        BreakTimeLabelBT.Text = B1HourNudBT.Value.ToString("0#") & ":" & nudb1min.Value.ToString("0#") & ":" & nudb1sec.Value.ToString("0#")
    End Sub

    Private Sub Nudb1sec_ValueChanged(sender As Object, e As EventArgs) Handles nudb1sec.ValueChanged
        BreakTimeLabelBT.Text = B1HourNudBT.Value.ToString("0#") & ":" & nudb1min.Value.ToString("0#") & ":" & nudb1sec.Value.ToString("0#")
    End Sub

    Private Sub NudTimeMin_ValueChanged(sender As Object, e As EventArgs) Handles nudTimeMin.ValueChanged

        TimeSelectIndicatorLabelBT.Text = nudTimeHour.Value.ToString("0#") & ":" & nudTimeMin.Value.ToString("0#") & ":" & nudTimeSec.Value.ToString("0#")
    End Sub

    Private Sub NudTimeSec_ValueChanged(sender As Object, e As EventArgs) Handles nudTimeSec.ValueChanged

        TimeSelectIndicatorLabelBT.Text = nudTimeHour.Value.ToString("0#") & ":" & nudTimeMin.Value.ToString("0#") & ":" & nudTimeSec.Value.ToString("0#")
    End Sub

    Private Sub NudTimeBreakHour_ValueChanged(sender As Object, e As EventArgs) Handles nudTimeBreakHour.ValueChanged

        BreakTimeIndicatorALabelBT.Text = nudTimeBreakHour.Value.ToString("0#") & ":" & nudTimeBreakMin.Value.ToString("0#") & ":" & nudTimeBreakSec.Value.ToString("0#")
    End Sub

    Private Sub NudTimeBreakMin_ValueChanged(sender As Object, e As EventArgs) Handles nudTimeBreakMin.ValueChanged

        BreakTimeIndicatorALabelBT.Text = nudTimeBreakHour.Value.ToString("0#") & ":" & nudTimeBreakMin.Value.ToString("0#") & ":" & nudTimeBreakSec.Value.ToString("0#")
    End Sub

    Private Sub NudTimeBreakSec_ValueChanged(sender As Object, e As EventArgs) Handles nudTimeBreakSec.ValueChanged

        BreakTimeIndicatorALabelBT.Text = nudTimeBreakHour.Value.ToString("0#") & ":" & nudTimeBreakMin.Value.ToString("0#") & ":" & nudTimeBreakSec.Value.ToString("0#")
    End Sub
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub ChangeSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeSettingsToolStripMenuItem.Click
        SettingsForm.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub BreakTimerTab_Click(sender As Object, e As EventArgs) Handles BreakTimerTab.Click

    End Sub

    Private Sub NudTimeHour_ValueChanged(sender As Object, e As EventArgs) Handles nudTimeHour.ValueChanged

        TimeSelectIndicatorLabelBT.Text = nudTimeHour.Value.ToString("0#") & ":" & nudTimeMin.Value.ToString("0#") & ":" & nudTimeSec.Value.ToString("0#")
    End Sub

    Private Sub BreakNowButtonBt_Click_1(sender As Object, e As EventArgs) Handles BreakNowButtonBt.Click
        Dim s As DateTime = Date.Now

        Dim a As TimeSpan = New TimeSpan(CInt(nudTimeBreakHour.Value), CInt(nudTimeBreakMin.Value), CInt(nudTimeBreakSec.Value))
        Dim dt As DateTime = DateTime.Now + a



        If s.Month = 11 AndAlso s.Day = 7 AndAlso s.Hour = 2 AndAlso s.Minute = 0 AndAlso s.Second = 0 Then
            If dt.Day = 0 AndAlso dt.Minute = 0 AndAlso dt.Second = 0 AndAlso dt.Hour = 0 Then
                Dim sas As String
                sas = CStr(MessageBox.Show("The time zone is currently in Non DST. Are you sure you want an extra hour? WARNING! This will
run into an exception if YOU DON'T PRESS YES!", "Time Change Acknowlegement", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning))
                If CDbl(sas) = DialogResult.Yes Then
                    If Notify = True Then
                        MessageBox.Show("You cannot start a break with less than " & MinWarnNudBt.Value & " minutes left.", "Error 1244", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    ElseIf Notify = False Then
                        BreakTimer.Stop()
                        BreakForm.sethours = CInt(B1HourNudBT.Value)
                        BreakForm.hours = BreakForm.sethours
                        BreakForm.setminutes = CInt(nudb1min.Value)
                        BreakForm.minutes = BreakForm.setminutes
                        BreakForm.setsecs = CInt(nudb1sec.Value)
                        BreakForm.seconds = BreakForm.setsecs
                        BreakForm.Show()
                        Me.Hide()
                    End If
                ElseIf CDbl(sas) = DialogResult.No Then
                    Throw New ArgumentOutOfRangeException
                ElseIf CDbl(sas) = DialogResult.Cancel Then
                    Exit Sub
                End If

            End If
        Else
            If Notify = True Then
                MessageBox.Show("You cannot start a break With less than " & MinWarnNudBt.Value & " minutes left.", "Error 1244", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            ElseIf Notify = False Then
                BreakTimer.Stop()
                BreakForm.sethours = CInt(B1HourNudBT.Value)
                BreakForm.hours = BreakForm.sethours
                BreakForm.setminutes = CInt(nudb1min.Value)
                BreakForm.minutes = BreakForm.setminutes
                BreakForm.setsecs = CInt(nudb1sec.Value)
                BreakForm.seconds = BreakForm.setsecs
                BreakForm.Show()
                Me.Hide()
            End If
        End If

    End Sub

    Private Sub BreakGBBt_Enter(sender As Object, e As EventArgs) Handles BreakGBBt.Enter

    End Sub

    Private Sub btnLM_Click(sender As Object, e As EventArgs) Handles btnLM.Click
        MessageBox.Show(CStr("After 8 years Of maintaining, this feature will be permanently removed beginning October 3, 2021, the date of when 
when BreakTime will be released. You can still use this feature, but be wary of broken or outdated components. You can learn more on our GitHub issue."), CStr("Feature Discontinuation Notice"), MessageBoxButtons.OK, MessageBoxIcon.Warning)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show(CStr("After 3 years of maintaining, this feature has required a script that no longer supports the latest Windows 11 release, scheduled for later this year, and will be permanently removed beginning October 3, 2021, the date of when 
when BreakTime will be released. You can still use this feature, but PLEASE DO NOT USE THIS ON WINDOWS 10 20H1 OR LATER! YOUR COMPUTER WILL CRASH AND WILL NOT START UP! You can learn more on our GitHub issue."), CStr("Feature Discontinuation Notice"), MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub


    Private Sub ShutdownTimer_Tick(sender As Object, e As EventArgs) Handles ShutdownTimer.Tick

        ShutdownIn()

    End Sub
    Private Sub ShutdownIn()
        If secsh > 0 Then
            secsh -= 1
            SecondsIndicatorLabelSh.Show()
            SecondsLabelSh.Show()
            SecondLabelSh.Hide()

        ElseIf minsh > 0 Then
            secsh = 59
            minsh -= 1
            MinuteIndicatorLabelSh.Show()
            MinutesAndLabelSh.Show()
            MinuteAndLabelSh.Hide()

        ElseIf hoursh > 0 Then
            secsh = 59
            minsh = 59
            hoursh -= 1
            HourIndicatorLabelSh.Show()

            HoursAndLabelSh.Show()
            HourAndLabelSh.Hide()
        Else
            Me.Show()
            ShutdownTimer.Stop()

            Me.Close()
                WindowsController.ExitWindows(RestartOptions.ShutDown, True)

        End If
        Select Case MinWarnNudBt.Value
            Case 1
                If hoursh = 0 AndAlso minsh = 0 AndAlso secsh < 60 Then
                    Dim remain As Integer = secsh
                    If Notify = False Then
                        Me.WindowState = FormWindowState.Normal
                        If AudioRadioButtonSh.Checked = True AndAlso VisualRadioButtonSh.Checked = False Then
                            PlayNow()
                        ElseIf AudioRadioButtonSh.Checked = False AndAlso VisualRadioButtonSh.Checked = True Then
                            PlayNow()
                            BreakTimer.Stop()

                            If MessageBox.Show(CStr(CDbl("Shutdown") + CDbl(" will start in ") + remain + CDbl(" seconds. Click OK to start breaktime now. Otherwise, click Cancel to continue the timer.")), CStr("MinWarn Alert"), MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                                Me.Show()
                                ShutdownTimer.Stop()

                                Me.Close()
                                        WindowsController.ExitWindows(RestartOptions.ShutDown, True)


                            ElseIf CBool(DialogResult.Cancel) Then
                                ShutdownTimer.Start()
                                Notify = True
                            End If
                        End If

                        Notify = True
                    End If

                End If
            Case 2
                If hoursh = 0 AndAlso minsh = 1 AndAlso secsh < 60 Then
                    Dim remain As Integer = secsh
                    If Notify = False Then
                        Me.WindowState = FormWindowState.Normal
                        If AudioRadioButtonSh.Checked = True AndAlso VisualRadioButtonSh.Checked = False Then
                            PlayNow()
                        ElseIf AudioRadioButtonSh.Checked = False AndAlso VisualRadioButtonSh.Checked = True Then
                            PlayNow()
                            BreakTimer.Stop()
                            Dim mes As String = CStr(MessageBox.Show("The computer WILL Shut down in " & minsh & " minutes and " & remain & " seconds. Click OK to start breaktime now. Otherwise, click Cancel to continue the timer.", "MinWarn Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation))
                            If CDbl(mes) = DialogResult.OK Then
                                Me.Show()
                                ShutdownTimer.Stop()

                                Me.Close()
                                        WindowsController.ExitWindows(RestartOptions.ShutDown, True)

                            ElseIf CDbl(mes) = DialogResult.Cancel Then
                                ShutdownTimer.Start()
                                Notify = True
                            End If
                        End If
                    End If
                End If
            Case 3
                If hoursh = 0 AndAlso minsh = 2 AndAlso secsh < 60 Then
                    Dim remain As Integer = secsh
                    If Notify = False Then
                        Me.WindowState = FormWindowState.Normal
                        If AudioRadioButtonSh.Checked = True AndAlso VisualRadioButtonSh.Checked = False Then
                            PlayNow()
                        ElseIf AudioRadioButtonSh.Checked = False AndAlso VisualRadioButtonSh.Checked = True Then
                            PlayNow()
                            ShutdownTimer.Stop()
                            Dim mes As String = CStr(MessageBox.Show("The computer WILL shut down In " & minsh & " minutes And " & remain & " seconds. Click OK To start breaktime now. Otherwise, Click Cancel To Continue the timer.", "MinWarn Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation))
                            If CDbl(mes) = DialogResult.OK Then
                                Me.Show()
                                ShutdownTimer.Stop()

                                Me.Close()
                                        WindowsController.ExitWindows(RestartOptions.ShutDown, True)

                            ElseIf CDbl(mes) = DialogResult.Cancel Then
                                ShutdownTimer.Start()
                                Notify = True
                            End If
                        End If
                    End If
                End If
            Case 4
                If hoursh = 0 AndAlso minsh = 3 AndAlso secsh < 60 Then
                    Dim remain As Integer = secsh
                    If Notify = False Then
                        Me.WindowState = FormWindowState.Normal
                        If AudioRadioButtonSh.Checked = True AndAlso VisualRadioButtonSh.Checked = False Then
                            PlayNow()
                        ElseIf AudioRadioButtonSh.Checked = False AndAlso VisualRadioButtonSh.Checked = True Then
                            PlayNow()
                            ShutdownTimer.Stop()
                            Dim mes As String = CStr(MessageBox.Show("The computer WILL shutdown in " & minsh & " minutes And " & remain & " seconds. Click OK To start breaktime now. Otherwise, Click Cancel To Continue the timer.", "MinWarn Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation))
                            If CDbl(mes) = DialogResult.OK Then
                                Me.Show()
                                ShutdownTimer.Stop()


                                Me.Close()
                                        WindowsController.ExitWindows(RestartOptions.ShutDown, True)

                            ElseIf CDbl(mes) = DialogResult.Cancel Then
                                ShutdownTimer.Start()
                                Notify = True
                            End If
                        End If
                    End If
                End If
            Case 5
                If hoursh = 0 AndAlso minsh = 4 AndAlso secsh < 60 Then
                    Dim remain As Integer = secsh
                    If Notify = False Then
                        Me.WindowState = FormWindowState.Normal
                        If AudioRadioButtonSh.Checked = True AndAlso VisualRadioButtonSh.Checked = False Then
                            PlayNow()
                        ElseIf AudioRadioButtonSh.Checked = False AndAlso VisualRadioButtonSh.Checked = True Then
                            PlayNow()
                            BreakTimer.Stop()
                            Dim mes As String = CStr(MessageBox.Show("The computer WILL shutdown in " & minsh & " minutes And " & remain & " seconds. Click OK To start breaktime now. Otherwise, Click Cancel To Continue the timer.", "MinWarn Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation))
                            If CDbl(mes) = DialogResult.OK Then
                                Me.Show()
                                ShutdownTimer.Stop()

                                Me.Close()
                                        WindowsController.ExitWindows(RestartOptions.ShutDown, True)

                            ElseIf CDbl(mes) = DialogResult.Cancel Then
                                ShutdownTimer.Start()
                                Notify = True
                            End If
                        End If
                    End If
                End If
        End Select
        SecondsIndicatorLabelSh.Text = Format(secsh, "0#")
        HourIndicatorLabelSh.Text = Format(hoursh, "0#")
        MinuteIndicatorLabelSh.Text = Format(minsh, "0#")
        If hoursh = 1 Then
            HoursAndLabelSh.Hide()
            HourAndLabelSh.Show()
        End If
        If minsh = 1 Then
            MinutesAndLabelSh.Hide()
            MinuteAndLabelSh.Show()
        End If
        If secsh = 1 Then
            SecondsLabelSh.Hide()
            SecondLabelSh.Show()
        End If
        If hoursh = 0 Then
            HourIndicatorLabelSh.Hide()
            HoursAndLabelSh.Hide()
            HourAndLabelSh.Hide()
        End If
        If minsh = 0 Then
            MinuteIndicatorLabelSh.Hide()
            MinutesAndLabelSh.Hide()
            MinuteAndLabelSh.Hide()
        End If




    End Sub

    Private Sub TimerTimer_Tick(sender As Object, e As EventArgs) Handles TimerTimer.Tick
        If sec1 > 0 Then
            sec1 -= 1
            lblsectime.Show()
            lblsectime.Show()
            lblsecondtime.Hide()

        ElseIf min1 > 0 Then
            sec1 = 59
            min1 -= 1
            lblmintime.Show()
            lblminutesandtime.Show()
            lblminuteandtime.Hide()

        ElseIf hours > 0 Then
            sec1 = 59
            min1 = 59
            hours -= 1
            lblhourtime.Show()

            lblhoursandtime.Show()
            lblhourandtime.Hide()

        Else
            TimerTimer.Enabled = False
            tBeep.Enabled = True
            If MsgBox("Times up!", MsgBoxStyle.Information, "Time Is up") = System.Windows.Forms.DialogResult.OK Then
                tBeep.Stop()
                PauseButtonT.Hide()
                ResumeTimeButton.Hide()
                StopTimeButton.Hide()
                StartTimeButton.Show()
                sec1 = 0
                min1 = 0
                hours = 0

                nudHour.Show()
                nudMin.Show()
                nudSec.Show()
                StopWatchTab.Enabled = True
                BreakTimerTab.Enabled = True
                ShutdownTabPage.Enabled = True
                AlarmClockTab.Enabled = True

            End If
        End If
        lblhourtime.Text = Format(hours, "0#")
        lblmintime.Text = Format(min1, "0#")
        lblsectime.Text = Format(sec1, "0#")
        If hours = 1 Then
            lblhoursandtime.Hide()
            lblhourandtime.Show()
        End If
        If min1 = 1 Then
            lblminutesandtime.Hide()
            lblminuteandtime.Show()
        End If
        If sec1 = 1 Then
            lblsectime.Hide()
            lblsecondtime.Show()
        End If
        If hours = 0 Then
            lblhourtime.Hide()
            lblhoursandtime.Hide()
            lblhourandtime.Hide()
        End If
        If min1 = 0 Then
            lblmintime.Hide()
            lblminutesandtime.Hide()
            lblminuteandtime.Hide()
        End If
    End Sub

    Private Sub Stopbutton_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        BreakTimer.Stop()
        TSFHourIndicatorLabelBT.Text = "--"
        TSFMinIndicatorLabelBT.Text = "--"
        TSFSecondIndicatorLabelBT.Text = "--"
        BSTHourIndicatorLabelBT.Text = "--"
        BSTMinIndicatorLabelBT.Text = "--"
        BSTSecondIndicatorLabelBT.Text = "--"
        HourLabelBT.Text = "--"
        lblminute.Text = "--"
        lblsec.Text = "--"
        B1HourNudBT.Value = CDec("0")
        nudb1min.Value = CDec("0")
        nudb1sec.Value = CDec("0")
        sec = 0
        min = 0


    End Sub

    Private Sub Resumetimebutton_Click(sender As Object, e As EventArgs) Handles ResumeTimeButton.Click
        TimerTimer.Start()
        TimerTimer.Enabled = True
        ResumeTimeButton.Hide()
        StopTimeButton.Show()
        PauseButtonT.Show()
        StartTimeButton.Hide()
    End Sub


    Private Sub BreakTimer_Tick(sender As Object, e As EventArgs) Handles BreakTimer.Tick
        If sec > 0 Then
            sec -= 1
            lblsec.Show()
            lblsecondsbreak.Show()
            lblsecondbreak.Hide()

        ElseIf min > 0 Then
            sec = 59
            min -= 1
            lblminute.Show()
            lblminutesandbreak.Show()
            lblminuteandbreak.Hide()

        ElseIf hour > 0 Then
            sec = 59
            min = 59
            hour -= 1
            HourLabelBT.Show()

            lblhoursandbreak.Show()
            HourAndBreakLabelBT.Hide()
        Else
            BreakTimer.Stop()
            BreakTimer.Enabled = False
            Select Case My.Settings.Sound1
                Case 0
                    sound.Stream = My.Resources.timesup4
                    sound.Play()

                Case 1 Or 2
                    sound.SoundLocation = My.Settings.Sound1Location
                    sound.Play()

            End Select
            BreakForm.sethours = CInt(nudTimeBreakHour.Value)
            BreakForm.hours = BreakForm.sethours
            BreakForm.setminutes = CInt(nudTimeBreakMin.Value)
            BreakForm.minutes = BreakForm.setminutes
            BreakForm.setsecs = CInt(nudTimeBreakSec.Value)
            BreakForm.seconds = BreakForm.setsecs
            BreakForm.Show()
            Me.Hide()
        End If
        Select Case MinWarnNudBt.Value
            Case 1
                If hour = 0 AndAlso min = 0 AndAlso sec < 60 Then
                    Dim remain As Integer = sec
                    If Notify = False Then
                        Me.WindowState = FormWindowState.Normal
                        If AudioRbBt.Checked = True AndAlso VisualRbBt.Checked = False Then
                            PlayNow()
                        ElseIf AudioRbBt.Checked = False AndAlso VisualRbBt.Checked = True Then
                            PlayNow()
                            BreakTimer.Stop()

                            If MessageBox.Show("Breaktime will start In " & remain & " seconds. Click OK To start breaktime now. Otherwise, Click Cancel To Continue the timer.", "MinWarn Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                                BreakTimer.Stop()
                                BreakTimer.Enabled = False
                                Select Case My.Settings.Sound1
                                    Case 0
                                        sound.Stream = My.Resources.timesup4
                                        sound.Play()


                                    Case 1 Or 2
                                        sound.SoundLocation = My.Settings.Sound1Location
                                        sound.Play()
                                End Select
                                BreakForm.sethours = CInt(nudTimeBreakHour.Value)
                                BreakForm.hours = BreakForm.sethours
                                BreakForm.setminutes = CInt(nudTimeBreakMin.Value)
                                BreakForm.minutes = BreakForm.setminutes
                                BreakForm.setsecs = CInt(nudTimeBreakSec.Value)
                                BreakForm.seconds = BreakForm.setsecs
                                BreakForm.Show()
                                Me.Hide()
                            ElseIf CBool(DialogResult.Cancel) Then
                                BreakTimer.Start()
                            End If
                        End If

                        Notify = True
                    End If

                End If
            Case 2
                If hour = 0 AndAlso min = 1 AndAlso sec < 60 Then
                    Dim remain As Integer = sec
                    If Notify = False Then
                        Me.WindowState = FormWindowState.Normal
                        If AudioRbBt.Checked = True AndAlso VisualRbBt.Checked = False Then
                            PlayNow()
                        ElseIf AudioRbBt.Checked = False AndAlso VisualRbBt.Checked = True Then
                            PlayNow()
                            BreakTimer.Stop()

                            If MessageBox.Show("Breaktime will start In " & min & " minutes And " & remain & " seconds. Click OK To start breaktime now. Otherwise, Click Cancel To Continue the timer.", "MinWarn Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                                BreakTimer.Stop()
                                BreakTimer.Enabled = False
                                Select Case My.Settings.Sound1
                                    Case 0
                                        sound.Stream = My.Resources.timesup4
                                        sound.Play()
                                    Case 1 Or 2
                                        sound.SoundLocation = My.Settings.Sound1Location
                                        sound.Play()
                                End Select

                                BreakForm.sethours = CInt(nudTimeBreakHour.Value)
                                BreakForm.hours = BreakForm.sethours
                                BreakForm.setminutes = CInt(nudTimeBreakMin.Value)
                                BreakForm.minutes = BreakForm.setminutes
                                BreakForm.setsecs = CInt(nudTimeBreakSec.Value)
                                BreakForm.seconds = BreakForm.setsecs
                                BreakForm.Show()
                                Me.Hide()
                            ElseIf CBool(DialogResult.Cancel) Then
                                BreakTimer.Start()
                                Notify = True
                            End If
                        End If
                    End If
                End If
            Case 3
                If hour = 0 AndAlso min = 2 AndAlso sec < 60 Then
                    Dim remain As Integer = sec
                    If Notify = False Then
                        Me.WindowState = FormWindowState.Normal
                        If AudioRbBt.Checked = True AndAlso VisualRbBt.Checked = False Then
                            PlayNow()
                        ElseIf AudioRbBt.Checked = False AndAlso VisualRbBt.Checked = True Then
                            PlayNow()
                            BreakTimer.Stop()

                            If MessageBox.Show("Breaktime will start In " & min & " minutes And " & remain & " seconds. Click OK To start breaktime now. Otherwise, Click Cancel To Continue the timer.", "MinWarn Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                                BreakTimer.Stop()
                                BreakTimer.Enabled = False
                                Select Case My.Settings.Sound1
                                    Case 0
                                        sound.Stream = My.Resources.timesup4
                                        sound.Play()
                                    Case 1 Or 2
                                        sound.SoundLocation = My.Settings.Sound1Location
                                        sound.Play()
                                End Select


                                BreakForm.sethours = CInt(nudTimeBreakHour.Value)
                                BreakForm.hours = BreakForm.sethours
                                BreakForm.setminutes = CInt(nudTimeBreakMin.Value)
                                BreakForm.minutes = BreakForm.setminutes
                                BreakForm.setsecs = CInt(nudTimeBreakSec.Value)
                                BreakForm.seconds = BreakForm.setsecs
                                BreakForm.Show()
                                Me.Hide()
                            ElseIf CBool(DialogResult.Cancel) Then
                                BreakTimer.Start()
                                Notify = True
                            End If
                        End If
                    End If
                End If
            Case 4
                If hour = 0 AndAlso min = 3 AndAlso sec < 60 Then
                    Dim remain As Integer = sec
                    If Notify = False Then
                        Me.WindowState = FormWindowState.Normal
                        If AudioRbBt.Checked = True AndAlso VisualRbBt.Checked = False Then
                            PlayNow()
                        ElseIf AudioRbBt.Checked = False AndAlso VisualRbBt.Checked = True Then
                            PlayNow()
                            BreakTimer.Stop()

                            If MessageBox.Show("Breaktime will start In " & min & " minutes And " & remain & " seconds. Click OK To start breaktime now. Otherwise, Click Cancel To Continue the timer.", "MinWarn Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                                BreakTimer.Stop()
                                BreakTimer.Enabled = False
                                Select Case My.Settings.Sound1
                                    Case 0
                                        sound.Stream = My.Resources.timesup4
                                        sound.Play()
                                    Case 1 Or 2
                                        sound.SoundLocation = My.Settings.Sound1Location
                                        sound.Play()
                                End Select




                                BreakForm.sethours = CInt(nudTimeBreakHour.Value)
                                BreakForm.hours = BreakForm.sethours
                                BreakForm.setminutes = CInt(nudTimeBreakMin.Value)
                                BreakForm.minutes = BreakForm.setminutes
                                BreakForm.setsecs = CInt(nudTimeBreakSec.Value)
                                BreakForm.seconds = BreakForm.setsecs
                                BreakForm.Show()
                                Me.Hide()
                            ElseIf CBool(DialogResult.Cancel) Then
                                BreakTimer.Start()
                                Notify = True
                            End If
                        End If
                    End If
                End If
            Case 5
                If hour = 0 AndAlso min = 4 AndAlso sec < 60 Then
                    Dim remain As Integer = sec
                    If Notify = False Then
                        Me.WindowState = FormWindowState.Normal
                        If AudioRbBt.Checked = True AndAlso VisualRbBt.Checked = False Then
                            PlayNow()
                        ElseIf AudioRbBt.Checked = False AndAlso VisualRbBt.Checked = True Then
                            PlayNow()
                            BreakTimer.Stop()

                            If MessageBox.Show("Breaktime will start In " & min & " minutes And " & remain & " seconds. Click OK To start breaktime now. Otherwise, Click Cancel to continue the timer.", "MinWarn Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                                BreakTimer.Stop()
                                BreakTimer.Enabled = False
                                Select Case My.Settings.Sound1
                                    Case 0
                                        sound.Stream = My.Resources.timesup4
                                        sound.Play()
                                    Case 1 Or 2
                                        sound.SoundLocation = My.Settings.Sound1Location
                                        sound.Play()
                                End Select


                                BreakForm.sethours = CInt(nudTimeBreakHour.Value)
                                BreakForm.hours = BreakForm.sethours
                                BreakForm.setminutes = CInt(nudTimeBreakMin.Value)
                                BreakForm.minutes = BreakForm.setminutes
                                BreakForm.setsecs = CInt(nudTimeBreakSec.Value)
                                BreakForm.seconds = BreakForm.setsecs
                                BreakForm.Show()
                                Me.Hide()
                            ElseIf CBool(DialogResult.Cancel) Then
                                BreakTimer.Start()
                                Notify = True
                            End If
                        End If
                    End If
                End If
        End Select
        lblsec.Text = Format(sec, "0#")
        HourLabelBT.Text = Format(hour, "0#")
        lblminute.Text = Format(min, "0#")
        If hour = 1 Then
            lblhoursandbreak.Hide()
            HourAndBreakLabelBT.Show()
        End If
        If min = 1 Then
            lblminutesandbreak.Hide()
            lblminuteandbreak.Show()
        End If
        If sec = 1 Then
            lblsecondsbreak.Hide()
            lblsecondbreak.Show()
        End If
        If hour = 0 AndAlso min <= 59 Then
            HourLabelBT.Hide()
            lblhoursandbreak.Hide()
            HourAndBreakLabelBT.Hide()
        End If
        If min = 0 Then
            lblminute.Hide()
            lblminutesandbreak.Hide()
            lblminuteandbreak.Hide()
        End If
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles StartButtonBT.Click

        If nudTimeHour.Value = 0 AndAlso nudTimeMin.Value = 0 AndAlso nudTimeSec.Value = 0 AndAlso nudTimeBreakHour.Value = 0 AndAlso nudTimeBreakMin.Value = 0 AndAlso nudTimeBreakSec.Value = 0 Then
                Exit Sub
            Else

            End If
            TSFHourIndicatorLabelBT.Text = CStr(nudTimeHour.Value)
            TSFMinIndicatorLabelBT.Text = CStr(nudTimeMin.Value)
            TSFSecondIndicatorLabelBT.Text = CStr(nudTimeSec.Value)
            BSTHourIndicatorLabelBT.Text = CStr(nudTimeBreakHour.Value)
            BSTMinIndicatorLabelBT.Text = CStr(nudTimeBreakMin.Value)
            BSTSecondIndicatorLabelBT.Text = CStr(nudTimeBreakSec.Value)
            TimerTab.Enabled = False
            StopWatchTab.Enabled = False
            ShutdownTabPage.Enabled = False
            AlarmClockTab.Enabled = False
            BreakGBBt.Hide()
            TimerGBBt.Hide()


            Me.WindowState = FormWindowState.Minimized
            BreakTimer.Enabled = True
            BreakTimer.Start()
            sethours = CInt(nudTimeHour.Value)
            setmins = CInt(nudTimeMin.Value)
            setsecs = CInt(nudTimeSec.Value)
            hour = sethours
            min = setmins
            sec = setsecs
            StartButtonBT.Hide()
            PauseButtonBT.Show()
            btnResume.Hide()
            btnStop.Show()
            Notify = False


    End Sub

    Private Sub ResumeStopWButton_Click(sender As Object, e As EventArgs) Handles ResumeButtonSW.Click
        SW.Start()
        Tmr.Start()
        PauseButtonSW.Show()
        ResumeButtonSW.Hide()
        StopButtonSW.Show()
        StartButtonSW.Hide()
    End Sub

    Private Sub StopStopWButton_Click(sender As Object, e As EventArgs) Handles StopButtonSW.Click
        SW.Stop()
        Tmr.Stop()
        PauseButtonSW.Hide()
        ResumeButtonSW.Hide()
        StopButtonSW.Hide()
        StartButtonSW.Show()
        ShutdownTabPage.Enabled = True
        BreakTimerTab.Enabled = True
        TimerTab.Enabled = True
        AlarmClockTab.Enabled = True
        StopwatchLabelSW.Text = "--: --:--"
        LapListBoxSw.Items.Clear()
        LapListBoxSw.Hide()
        TimerControl.Enabled = True
    End Sub

    Private Sub ResumeButtonSh_Click(sender As Object, e As EventArgs) Handles ResumeButtonSh.Click
        ShutdownTimer.Start()
        StopButtonSh.Show()
        StartButtonSh.Hide()
        PauseButtonSh.Show()
        ResumeButtonSh.Hide()
    End Sub

    Private Sub StopButtonSh_Click(sender As Object, e As EventArgs) Handles StopButtonSh.Click
        ShutdownTimer.Stop()
        Application.Restart()

    End Sub

    Private Sub TimeBomb_Tick(sender As Object, e As EventArgs) Handles TimeBomb.Tick
        If Now.Month >= 10 AndAlso Now.Day >= 9 AndAlso Now.Year >= 2021 AndAlso Now.Hour >= 0 AndAlso Now.Minute >= 0 AndAlso Now.Second >= 0 Then
            TimeBomb.Stop()
            MessageBox.Show("Please note that this unreleased software is no longer supported. Please download the main program's release at https://github.com/brmonaghan/BreakTime. The program will now exit.", "NOT Supported", MessageBoxButtons.OK, MessageBoxIcon.Hand)


            Application.Exit()
        End If
    End Sub
End Class