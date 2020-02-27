Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json
Imports System.Windows.Forms
Imports System.Diagnostics
Imports System.Security.Cryptography



Public Class MainApp

    Private Sub MainApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            API_Form.API_KEY.Text = My.Settings.API_KEY
        Catch ex As Exception

        End Try

    End Sub
    Private Sub Refresh_Btn_Click(sender As Object, e As EventArgs) Handles Refresh_Btn.Click

        ' Sets the API list strings

        Dim balance, pending_charges, last_payment_date, last_payment_amount As String
        Dim output As String

        Dim process As System.Diagnostics.Process = New System.Diagnostics.Process()
        Dim startInfo As System.Diagnostics.ProcessStartInfo = New System.Diagnostics.ProcessStartInfo With {
            .CreateNoWindow = True,
            .UseShellExecute = False,
            .RedirectStandardOutput = True,
            .FileName = "CMD.exe",
            .Arguments = "/c curl.exe --url https://api.vultr.com/v1/account/info -H ""API-Key:" & API_Form.API_KEY.Text & """"
        }
        process.StartInfo = startInfo
        process.Start()
        output = process.StandardOutput.ReadToEnd()
        process.WaitForExit()

        Try
            Dim rawresp As String
            rawresp = output
            Dim jResults As Object = JObject.Parse(rawresp)

            balance = If(jResults("balance") Is Nothing, "", jResults("balance").ToString())
            balance_txt.Text = balance

            pending_charges = If(jResults("pending_charges") Is Nothing, "", jResults("pending_charges").ToString())
            charges_txt.Text = pending_charges

            last_payment_date = If(jResults("last_payment_date") Is Nothing, "", jResults("last_payment_date").ToString())
            LastPDate.Text = last_payment_date

            last_payment_amount = If(jResults("last_payment_amount") Is Nothing, "", jResults("last_payment_amount").ToString())
            LastPA.Text = last_payment_amount


        Catch ex As Exception
            MessageBox.Show(output)
        End Try

    End Sub

    Private Sub LogIn_Btn_Click(sender As Object, e As EventArgs) Handles LogIn_Btn.Click
        API_Form.ShowDialog()
    End Sub

End Class