Option Strict On
Public Class ReminderForm
    Private Sub ReminderForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Visible = True
        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width
        y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height

        Do Until x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
            x = x - 1
            Me.Location = New Point(x, y)
        Loop

        Dim myRand As New Random
        Dim num As Integer

        num = myRand.Next(1, 4)

        Select Case num
            Case 1
                lblPrompt.Text = "Ping!"
            Case 2
                lblPrompt.Text = "Don't forget..."
            Case 3
                lblPrompt.Text = "Remember to..."
            Case Else
                MsgBox("Oops")
        End Select

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        ' MainForm.OPCode("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\rmd.mdb", "UPDATE `rmd1` SET `isActive` = FALSE")
        MainForm.tmrrmd.Start()

    End Sub

    Private Sub ReminderForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        For MoveLeft = Me.Location.X To 30 Step 1
            Me.Left = MoveLeft
            Me.Refresh()
            Threading.Thread.Sleep(0)
        Next
    End Sub


End Class