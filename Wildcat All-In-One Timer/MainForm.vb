Imports System.Globalization
Imports System.Media
Public Class MainForm
    Dim sound As New SoundPlayer
    Dim Notify As Boolean = False
    Public sethours, setmins, setsecs As Integer
    Public hour, min, sec As Integer
    Public hours, min1, sec1 As Integer
    Public sethours1, setmins1, setsecs1 As Integer
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
    Private Sub FrmLAG_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TitlePanel.BackColor = System.Drawing.ColorTranslator.FromHtml(CStr(CStr(My.Settings.BackColor.ToArgb)))
        TitlePanel.ForeColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.ForeColor.ToArgb))

        TimerTab.BackColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.BackColor.ToArgb))
        TimerTab.ForeColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.ForeColor.ToArgb))
        BreakTimerTab.BackColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.BackColor.ToArgb))
        BreakTimerTab.ForeColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.ForeColor.ToArgb))


        Me.ForeColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.ForeColor.ToArgb))
        Me.BackColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.BackColor.ToArgb))
        TimerControl.ForeColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.ForeColor.ToArgb))
        TimerControl.BackColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.BackColor.ToArgb))



        Select Case My.Settings.Startup
            Case 0
                BreakTimerTab.Show()
            Case 1
                TimerTab.Show()


        End Select




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



    Private Sub YDTimer_Tick(sender As Object, e As EventArgs) Handles YDTimer.Tick
        Select Case My.Settings.TimeFormat

            Case 0

                Dim hourtime As DateTime = CDate(Now.ToString("HH:mm:ss tt", CultureInfo.InvariantCulture))
                TimeLabelYD.Text = hourtime

            Case 1
                TimeLabelYD.Text = Now.ToString("HH:mm:ss")
            Case 2
                TimeLabelYD.Text = Now.ToShortTimeString
            Case 3

                TimeLabelYD.Text = Now.ToString("HH:mm")
        End Select
        Select Case My.Settings.DateFormat
            Case 0
                DateLabelYD.Text = Now.ToString("yyMMdd")
            Case 1
                DateLabelYD.Text = Now.ToString("yyyyMMdd")
            Case 2
                Dim myCulture As System.Globalization.CultureInfo = Globalization.CultureInfo.CurrentCulture
                Dim dayOfWeek As DayOfWeek = myCulture.Calendar.GetDayOfWeek(Date.Today)
                Dim dayName As String = myCulture.DateTimeFormat.GetDayName(dayOfWeek)
                Dim datetime As DateTime = Date.Now
                DateLabelYD.Text = dayName & " " & MonthName(Now.Month, False) & " " & Now.Day & " " & Now.Year
            Case 3
                DateLabelYD.Text = MonthName(Now.Month, False) & " " & Now.Day & " " & Now.Year
            Case 4
                Dim dt As New DateTimeFormatInfo
                DateLabelYD.Text = dt.GetAbbreviatedMonthName(Now.Month) & " " & Now.Day & " " & Now.ToString("yy")
            Case 5
                Dim dt As New DateTimeFormatInfo
                DateLabelYD.Text = dt.GetAbbreviatedMonthName(Now.Month) & " " & Now.Day & " " & Now.Year
            Case 6
                DateLabelYD.Text = Now.ToString("MM/dd/yy")
            Case 7
                DateLabelYD.Text = Now.ToString("dd/MM/yy")
        End Select




    End Sub

    Private Sub SettingsButton_Click(sender As Object, e As EventArgs) Handles SettingsButton.Click
        SettingsForm.Show()
        Me.Close()
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
                        ErrorMessageForm.Show()
                        ErrorMessageForm.ConciseErrorLabel.Text = "Cannot Start Break"
                        ErrorMessageForm.DetailedErrorLabel.Text = "Not able to set break with MinWarn already gone off."

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
                ErrorMessageForm.Show()
                ErrorMessageForm.ConciseErrorLabel.Text = "Cannot Start Break"
                ErrorMessageForm.DetailedErrorLabel.Text = "Not able to set break with MinWarn already gone off."
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

            BreakTimerTab.Enabled = True


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

    Private Sub Stopbutton_Click(sender As Object, e As EventArgs)
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

                            MessageForm.Show()
                            MessageForm.Label1.Text = "Breaktime Alert!"
                            MessageForm.Label2.Text = "Breaktime will start In " & remain & " seconds."


                            BreakTimer.Start()

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


                            MessageForm.Show()
                            MessageForm.Label1.Text = "Breaktime Alert!"
                            MessageForm.Label2.Text = "Breaktime will start In " & min & " minutes And " & remain & " seconds."


                            BreakTimer.Start()
                            Notify = True
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


                            MessageForm.Show()
                            MessageForm.Label1.Text = "Breaktime Alert!"
                            MessageForm.Label2.Text = "Breaktime will start In " & min & " minutes And " & remain & " seconds."


                            BreakTimer.Start()
                            Notify = True
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


                            MessageForm.Show()
                            MessageForm.Label1.Text = "Breaktime Alert!"
                            MessageForm.Label2.Text = "Breaktime will start In " & min & " minutes And " & remain & " seconds."


                            BreakTimer.Start()
                            Notify = True
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


                            MessageForm.Show()
                            MessageForm.Label1.Text = "Breaktime Alert!"
                            MessageForm.Label2.Text = "Breaktime will start In " & min & " minutes And " & remain & " seconds."


                            BreakTimer.Start()
                            Notify = True
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

    Private Sub Button1_Click_2(sender As Object, e As EventArgs)

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
End Class