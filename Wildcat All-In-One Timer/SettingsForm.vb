Imports System.Globalization
Imports System.IO
Imports System.Net
Imports System.Text

Public Class SettingsForm

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.BackColor.ToArgb))
        Me.ForeColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.ForeColor.ToArgb))
        Personalization.BackColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.BackColor.ToArgb))
        Personalization.ForeColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.ForeColor.ToArgb))
        AutoTime.BackColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.BackColor.ToArgb))
        AutoTime.ForeColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.ForeColor.ToArgb))
        Sounds.BackColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.BackColor.ToArgb))
        Sounds.ForeColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.ForeColor.ToArgb))
        About.BackColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.BackColor.ToArgb))
        About.ForeColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.ForeColor.ToArgb))
        General.BackColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.BackColor.ToArgb))
        General.ForeColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.ForeColor.ToArgb))
        WDLCTSUCbSUGen.SelectedIndex = My.Settings.Startup

        TDComboBoxS.SelectedIndex = My.Settings.Sound1
        MWComboBoxS.SelectedIndex = My.Settings.Sound2

        DateFormatCbDTGen.SelectedIndex = My.Settings.DateFormat
        TimeFormatCbDTGen.SelectedIndex = My.Settings.TimeFormat
        ComboBox1.SelectedIndex = My.Settings.DateFormat4Break
        ColorWheel1.Color = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.BackColor.ToArgb))
        ColorWheel2.Color = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.ForeColor.ToArgb))
        If File.Exists(Application.StartupPath & "\sounds\") Then
            Sounds.Show()
        Else
            Sounds.Hide()
        End If
    End Sub

    Private Sub SaveButtonSettings_Click(sender As Object, e As EventArgs) Handles SaveButtonSettings.Click

        My.Settings.Startup = WDLCTSUCbSUGen.SelectedIndex
        My.Settings.DateFormat = DateFormatCbDTGen.SelectedIndex
        My.Settings.TimeFormat = TimeFormatCbDTGen.SelectedIndex
        My.Settings.Sound1 = TDComboBoxS.SelectedIndex

        My.Settings.AutoTimeBTTHour = CStr(nudTimeHour.Value)
        My.Settings.AutoTimeBTTMin = CStr(nudTimeMin.Value)
        My.Settings.AutoTimeBTTSec = CStr(nudTimeSec.Value)

        My.Settings.MWAutoTime = CStr(MinWarnNudBt.Value)
        If AudioRbBt.Checked = True AndAlso VisualRbBt.Checked = False Then
            My.Settings.AudioOrVisual = True
        ElseIf AudioRbBt.Checked = False AndAlso VisualRbBt.Checked = True Then
            My.Settings.AudioOrVisual = False
        End If

        My.Settings.AutoTimeTTHour = CStr(nudHour.Value)
        My.Settings.AutoTimeTTMin = CStr(nudMin.Value)
        My.Settings.AutoTimeTTSec = CStr(nudSec.Value)



        Select Case TDComboBoxS.SelectedIndex
            Case 0
                My.Settings.Sound1Location = My.Resources.timeup.ToString
            Case 1
                My.Settings.Sound1Location = My.Resources.aquanear.tostring
            Case 2
                My.Settings.Sound1Location = my.resources.ff.tostring
            Case 3
                My.Settings.Sound1Location = My.Resources.foghorn.tostring
            Case 4
                My.Settings.Sound1Location = my.resources.td211.tostring
            Case 5
                My.Settings.Sound1Location = My.Resources.speedeam.tostring
        End Select
        My.Settings.Sound2 = MWComboBoxS.SelectedIndex
        Select Case MWComboBoxS.SelectedIndex
            Case 0
                My.Settings.Sound2Location = my.resources.shutdown.tostring
            Case 1
                My.Settings.Sound2Location = my.resources.tw.tostring
            Case 2
                My.Settings.Sound2Location = my.resources.bub.tostring
            Case 3
                My.Settings.Sound2Location = my.resources.ab.tostring
            Case 4
                My.Settings.Sound2Location = my.resources.bub2.tostring
            Case 5
                My.Settings.Sound2Location = my.resources.mw211.tostring
            Case 6
                My.Settings.Sound2Location = my.resources.pop.tostring
        End Select
        My.Settings.ForeColor = ColorWheel2.Color
        My.Settings.BackColor = ColorWheel1.Color
        My.Settings.DateFormat4Break = ComboBox1.SelectedIndex
        My.Settings.Save()

        Me.DialogResult = DialogResult.OK
        MainForm.Show()
        Me.Close()
    End Sub

    Private Sub CancelButtonSettings_Click(sender As Object, e As EventArgs) Handles CancelButtonSettings.Click
        Me.DialogResult = DialogResult.Cancel
        MainForm.Show()
        Me.Close()
    End Sub




    Private Sub DateFormatCbDTGen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DateFormatCbDTGen.SelectedIndexChanged
        Select Case DateFormatCbDTGen.SelectedIndex
            Case 0
                DTLabelDTGen.Text = Now.ToString("yyMMdd")
            Case 1
                DTLabelDTGen.Text = Now.ToString("yyyyMMdd")
            Case 2
                MsgBox("Please note that the date format you picked is for YourDay ONLY. For breaktime, use the other combo box.", MsgBoxStyle.Critical, "YourDay Only")
                Dim myCulture As System.Globalization.CultureInfo = Globalization.CultureInfo.CurrentCulture
                Dim dayOfWeek As DayOfWeek = myCulture.Calendar.GetDayOfWeek(Date.Today)
                Dim dayName As String = myCulture.DateTimeFormat.GetDayName(dayOfWeek)
                Dim datetime As DateTime = Date.Now


                DTLabelDTGen.Text = dayName & " " & MonthName(Now.Month, False) & " " & Now.Day & " " & Now.Year
            Case 3
                MsgBox("Please note that the date format you picked is for YourDay ONLY. For breaktime, use the other combo box.", MsgBoxStyle.Critical, "YourDay Only")
                Dim myCulture As System.Globalization.CultureInfo = Globalization.CultureInfo.CurrentCulture

                Dim datetime As DateTime = Date.Now


                DTLabelDTGen.Text = MonthName(Now.Month, False) & " " & Now.Day & " " & Now.Year
            Case 4
                MsgBox("Please note that this the date format you picked is for YourDay ONLY. For breaktime, use the other combo box.", MsgBoxStyle.Critical, "YourDay Only")
                Dim myCulture As System.Globalization.CultureInfo = Globalization.CultureInfo.CurrentCulture

                Dim datetime As DateTime = Date.Now
                Dim dt As New DateTimeFormatInfo

                DTLabelDTGen.Text = dt.GetAbbreviatedMonthName(Now.Month) & " " & Now.Day & " " & Now.ToString("yy")
            Case 5
                MsgBox("Please note that the date format you picked is for YourDay ONLY. For breaktime, use the other combo box.", MsgBoxStyle.Critical, "YourDay Only")
                Dim myCulture As System.Globalization.CultureInfo = Globalization.CultureInfo.CurrentCulture

                Dim datetime As DateTime = Date.Now
                Dim dt As New DateTimeFormatInfo

                DTLabelDTGen.Text = dt.GetAbbreviatedMonthName(Now.Month) & " " & Now.Day & " " & Now.Year
            Case 6
                DTLabelDTGen.Text = Now.ToString("MM/dd/yy")
            Case 7
                DTLabelDTGen.Text = Now.ToString("dd/MM/yy")
            Case 8
                DTLabelDTGen.Text = Nothing
        End Select
    End Sub


    Private Sub TimeFormatCbDTGen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TimeFormatCbDTGen.SelectedIndexChanged
        Select Case TimeFormatCbDTGen.SelectedIndex
            Case 0
                Dim hourtime As DateTime = CDate(Now.ToString("HH:mm:ss tt", CultureInfo.InvariantCulture))
                DTLabelDTGen2.Text = CStr(hourtime)
            Case 1
                DTLabelDTGen2.Text = Now.ToString("HH:mm:ss")
            Case 2

                DTLabelDTGen2.Text = Now.ToShortTimeString
            Case 3
                DTLabelDTGen2.Text = Now.ToString("HH:mm")
            Case 4
                Dim uTime As Double
                uTime = (DateTime.UtcNow - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds
                DTLabelDTGen2.Text = CStr(uTime)
            Case 5
                DTLabelDTGen2.Text = DateTime.UtcNow.TimeOfDay.ToString
        End Select


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedIndex
            Case 0
                Label1.Text = Now.ToString("yyMMdd")
            Case 1
                Label1.Text = Now.ToString("yyyyMMdd")
            Case 2
                Label1.Text = Now.ToString("MM/dd/yy")
            Case 3
                Label1.Text = Now.ToString("dd/MM/yy")
            Case 4
                Label1.Text = Now.ToString("MM/dd/yyyy")
            Case 5
                Dim uTime As Double
                uTime = (DateTime.UtcNow - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds
                Label1.Text = CStr(uTime)
        End Select
    End Sub

    Private Sub ResetButtonReGen_Click(sender As Object, e As EventArgs) Handles ResetButtonReGen.Click
        Dim ms As String
        ms = CStr(MessageBox.Show("Are you sure? This will RESET ALL SETTINGS! Use caution if you have personalized settings!", "Confirm Reset", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
        If CDbl(ms) = DialogResult.Yes Then
            My.Settings.Reset()
            MsgBox("Reset successful. Program will now restart when you press OK.", MsgBoxStyle.Information, "Reset Success")
            Application.Restart()
        ElseIf CDbl(ms) = DialogResult.No Then
            Exit Sub
        ElseIf CDbl(ms) = DialogResult.Cancel Then
            Exit Sub
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If OFDS.ShowDialog = DialogResult.OK Then
            My.Settings.Sound1Location = OFDS.FileName
            My.Settings.Save()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If OFDS.ShowDialog = DialogResult.OK Then
            My.Settings.Sound2Location = OFDS.FileName
            My.Settings.Save()
        End If
    End Sub
    Private Sub BtnLicense_Click(sender As Object, e As EventArgs) Handles BtnLicense.Click
        MessageBox.Show("This program is free software: you can redistribute it and/or modify" & vbCrLf & "
    it under the terms of the GNU General Public License as published by" & vbCrLf & "
    the Free Software Foundation, either version 3 of the License, or" & vbCrLf & "
    (at your option) any later version." & vbCrLf & vbCrLf & "

    This program is distributed in the hope that it will be useful," & vbCrLf & "
    but WITHOUT ANY WARRANTY; without even the implied warranty of" & vbCrLf & "
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the" & vbCrLf & "
    GNU General Public License for more details." & vbCrLf & vbCrLf & "
    You should have received a copy of the GNU General Public License" & vbCrLf & "
    along with this program.  If not, see https://www.gnu.org/licenses/", "License Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub



    Private Sub BTBrowse_Click(sender As Object, e As EventArgs) Handles BTBrowse.Click
        If OFDS.ShowDialog = DialogResult.OK Then
            My.Settings.BTSoundLocation = OFDS.FileName
            My.Settings.BTSoundIsDiff = True
            My.Settings.Save()
        Else
            My.Settings.BTSoundLocation = Nothing
            My.Settings.BTSoundIsDiff = False
            My.Settings.Save()
        End If
    End Sub



    Private Sub colorwheel2_ColorChanged(sender As Object, e As EventArgs) Handles ColorWheel2.ColorChanged
        Label2.ForeColor = ColorWheel2.Color
        RTextBox.Text = ColorWheel2.Color.R.ToString
        GTextBox.Text = ColorWheel2.Color.G.ToString
        BTextBox.Text = ColorWheel2.Color.B.ToString
        HexTextBox.Text = ColorWheel2.Color.Name
        Label2.Text = "Color"
    End Sub

    Private Sub ColorWheel1_ColorChanged(sender As Object, e As EventArgs) Handles ColorWheel1.ColorChanged
        KnownColorLabel.ForeColor = ColorWheel1.Color
        RTextBoxFC.Text = ColorWheel1.Color.R.ToString
        GTextBoxFC.Text = ColorWheel1.Color.G.ToString
        BTextBoxFC.Text = ColorWheel1.Color.B.ToString
        HexTextBoxFC.Text = ColorWheel1.Color.Name
        KnownColorLabel.Text = "Color"
    End Sub

    Private Sub TDComboBoxS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TDComboBoxS.SelectedIndexChanged
        If TDComboBoxS.SelectedIndex = 6 Then
            If OFDS.ShowDialog() = DialogResult.OK Then
                My.Settings.Sound1Location = OFDS.FileName
                My.Settings.Save()
            End If

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Throw New NotImplementedException

    End Sub
End Class