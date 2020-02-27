Imports System.Security.Cryptography
Imports System
Imports System.IO
Imports System.Security
Imports System.Text

Public Class API_Form

    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        My.Settings.API_KEY = API_KEY.Text
        My.Settings.Save()
    End Sub

    Private Sub forget_btn_Click(sender As Object, e As EventArgs) Handles forget_btn.Click
        My.Settings.API_KEY = ""
        My.Settings.Save()
    End Sub
End Class