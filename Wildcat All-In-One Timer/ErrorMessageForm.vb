Option Strict Off
Public Class ErrorMessageForm
    Public exce
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub UnhandledExceptionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.BackColor.ToArgb))
        Me.ForeColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.ForeColor.ToArgb))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(exce.Message.ToString, "Kill Code " & exce.hresult.ToString, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
End Class