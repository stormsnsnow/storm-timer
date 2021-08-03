Imports System.Globalization

Public Class BreakPausedForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sapi As New SpeechLib.Synthesis.SpeechSynthesis

        sapi.Speak("Breaktime Resumed.")
        My.Computer.Audio.Play(Application.StartupPath & "\timesup4.wav")
        BreakForm.Show()
        Dim myCulture As System.Globalization.CultureInfo = Globalization.CultureInfo.CurrentCulture
        Dim dayOfWeek As DayOfWeek = myCulture.Calendar.GetDayOfWeek(Date.Today)
        Dim dayName As String = myCulture.DateTimeFormat.GetDayName(dayOfWeek)
        Dim datetime As DateTime = Date.Now
        Dim datew As DateTime = Date.Now
        Dim hourtime As DateTime = CDate(datetime.Add(New TimeSpan(BreakForm.hours, BreakForm.minutes, BreakForm.seconds)).ToString("HH:mm:ss tt", CultureInfo.InvariantCulture))
        Dim newdatetime As DateTime = datew.Add(New TimeSpan(BreakForm.hours, BreakForm.minutes, BreakForm.seconds))
        BreakForm.Breaktime()
        BreakForm.BreakTimer.Start()
        Me.Close()
    End Sub

    Private Sub BreakDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.BackColor.ToArgb))
        Me.ForeColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.ForeColor.ToArgb))
    End Sub
End Class