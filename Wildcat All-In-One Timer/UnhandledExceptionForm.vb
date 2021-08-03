Option Strict Off
Public Class UnhandledExceptionForm
    Public exce
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub UnhandledExceptionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ExceptionLabel.Text = "Click to see exception details."
        Me.BackColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.BackColor.ToArgb))
        Me.ForeColor = System.Drawing.ColorTranslator.FromHtml(CStr(My.Settings.ForeColor.ToArgb))
    End Sub

    Private Sub ExceptionLabel_Click(sender As Object, e As EventArgs) Handles ExceptionLabel.Click
        MessageBox.Show(exce.Message.ToString, "Kill Code " & exce.hresult.ToString, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
End Class