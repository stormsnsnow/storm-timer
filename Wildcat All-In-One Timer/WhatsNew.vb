Imports System.IO
Imports System.Net

Public Class WhatsNew
    Private Sub WhatsNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim address As String = "https://empointco.consulting/btime/new.txt"
            Dim client As WebClient = New WebClient()
            Dim reader As StreamReader = New StreamReader(client.OpenRead(address))
            Label3.Text = reader.ReadToEnd
        Catch ex As Exception
            Label3.Text = ex.Message
        End Try
        Try
            Dim address As String = "https://empointco.consulting/btime/chg.txt"
            Dim client As WebClient = New WebClient()
            Dim reader As StreamReader = New StreamReader(client.OpenRead(address))
            Label4.Text = reader.ReadToEnd
        Catch ex As Exception
            Label4.Text = ex.Message
        End Try
        Try
            Dim address As String = "https://empointco.consulting/btime/rem.txt"
            Dim client As WebClient = New WebClient()
            Dim reader As StreamReader = New StreamReader(client.OpenRead(address))
            Label6.Text = reader.ReadToEnd
        Catch ex As Exception
            Label6.Text = ex.Message
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class