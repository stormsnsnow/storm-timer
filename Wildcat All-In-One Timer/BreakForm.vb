
Imports System.Runtime.InteropServices
Imports Microsoft.Win32
Imports System.Globalization
Imports System.Media

Public Class BreakForm
    Public hours, minutes, seconds As Integer
    Public setminutes, sethours, setsecs As Integer
    Dim sound As New SoundPlayer

    <DllImport("user32.dll", EntryPoint:="BlockInput")>
    Private Shared Function BlockInput(<MarshalAs(UnmanagedType.Bool)> ByVal fBlockIt As Boolean) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    Private Sub FrmBreak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = Image.FromFile(GetCurrentWallpaper())
        Breaktime()
        BreakTimer.Start()
        Me.BackColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.BackColor.ToArgb))
        Me.ForeColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.ForeColor.ToArgb))
        Panel1.BackColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.BackColor.ToArgb))
        Panel1.ForeColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.ForeColor.ToArgb))
        BreakPanel.BackColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.BackColor.ToArgb))
        BreakPanel.ForeColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.ForeColor.ToArgb))
        'Label1.Text = SystemInformation.UserName + ", it's time to take a break."
        If My.Settings.HardCoreMode = True Then
            BlockInput(True)
            Panel1.Hide()
        ElseIf My.Settings.HardCoreMode = False Then
            Panel1.Show()
        End If

    End Sub
    Public Sub Breaktime()
        Select Case My.Settings.TimeFormat
            Case 0
                Dim datetime As DateTime = Date.Now

                Dim hourtime As DateTime = CDate(datetime.Add(New TimeSpan(hours, minutes, seconds)).ToString("HH:mm:ss tt", CultureInfo.InvariantCulture))
                lbltime.Text = "at " & hourtime

            Case 1
                Dim datetime As DateTime = Date.Now


                lbltime.Text = "at " & Now.Add(New TimeSpan(hours, minutes, seconds)).ToString("HH:mm:ss")
            Case 2
                Dim hourtime1 As DateTime = CDate(Now.ToString("HH:mm tt", CultureInfo.InvariantCulture))
                lbltime.Text = "at " & hourtime1.Add(New TimeSpan(hours, minutes, seconds))
            Case 3

                lbltime.Text = "at " & Now.Add(New TimeSpan(hours, minutes, seconds)).ToString("HH:mm")
        End Select
        Select Case My.Settings.DateFormat4Break
            Case 0
                lbldate.Text = Now.Add(New TimeSpan(hours, minutes, seconds)).ToString("yyMMdd")
            Case 1
                lbldate.Text = Now.Add(New TimeSpan(hours, minutes, seconds)).ToString("yyyyMMdd")
            Case 2
                lbldate.Text = Now.Add(New TimeSpan(hours, minutes, seconds)).ToString("MM/dd/yy")
            Case 3
                lbldate.Text = Now.Add(New TimeSpan(hours, minutes, seconds)).ToString("dd/MM/yy")
            Case 4
                lbldate.Text = Now.Add(New TimeSpan(hours, minutes, seconds)).ToString("MM/dd/yyyy")
        End Select
    End Sub

    Private Sub UnlockButton_Click_1(sender As Object, e As EventArgs) Handles UnlockButton.Click
        BreakTimer.Stop()

        sound.Stream = My.Resources.breaktimedone
        sound.Play()
        System.Threading.Thread.Sleep(5000)
        Application.Restart()



    End Sub

    Private Sub UnlockButton_Click(sender As Object, e As EventArgs) Handles PauseButton.Click
        BreakTimer.Stop()
        Dim speech As New System.Speech.Synthesis.SpeechSynthesizer
        speech.Speak("Breaktime Paused. Click On the Ok button To Resume break.")

        MessageForm.Show()
        Me.Hide()



    End Sub


    Private Function GetCurrentWallpaper() As String
        ' The current wallpaper path is stored in the registry at HKCU\Control Panel\Desktop\WallPaper
        Dim rkWallPaper As RegistryKey = Registry.CurrentUser.OpenSubKey("Control Panel\Desktop", False)
        Dim WallpaperPath As String = rkWallPaper.GetValue("WallPaper").ToString()
        rkWallPaper.Close()
        ' Return the current wallpaper path
        Return WallpaperPath
    End Function

    Private Sub TTab_Tick(sender As Object, e As EventArgs) Handles BreakTimer.Tick
        If seconds > 0 Then
            seconds -= 1
            lblsec.Show()
            lblsecondsbreak.Show()
            lblsecondbreak.Hide()

        ElseIf minutes > 0 Then
            seconds = 59
            minutes -= 1
            lblminute.Show()
            lblminutesandbreak.Show()
            lblminuteandbreak.Hide()

        ElseIf hours > 0 Then
            seconds = 59
            minutes = 59
            hours -= 1
            lblhour.Show()
            lblhoursandbreak.Show()
            lblhourandbreak.Hide()
        Else
            BreakTimer.Stop()

            sound.Stream = My.Resources.breaktimedone
            sound.Play()

            System.Threading.Thread.Sleep(3000)
            BlockInput(False)
            Application.Restart()
        End If

        lblhour.Text = Format(hours, "0#")

        lblminute.Text = Format(minutes, "0#")

        lblsec.Text = Format(seconds, "0#")

        If hours = 1 Then
            lblhoursandbreak.Hide()
            lblhourandbreak.Show()
        End If
        If minutes = 1 Then
            lblminutesandbreak.Hide()
            lblminuteandbreak.Show()
        End If
        If seconds = 1 Then
            lblsecondsbreak.Hide()
            lblsecondbreak.Show()
        End If
        If hours = 0 Then
            lblhour.Hide()
            lblhoursandbreak.Hide()
            lblhourandbreak.Hide()
        End If
        If minutes = 0 Then
            lblminute.Hide()
            lblminutesandbreak.Hide()
            lblminuteandbreak.Hide()
        End If



    End Sub
End Class