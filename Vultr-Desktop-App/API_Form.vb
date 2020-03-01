Imports System.Security.Cryptography
Imports System
Imports System.IO
Imports System.Security
Imports System.Text
Imports System.Security.AccessControl

Public Class API_Form



    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click

        File.Decrypt("api.key")

        Dim objwriter As New System.IO.StreamWriter("api.key")

        objwriter.Write(API_KEY.Text)
        objwriter.Close()
        Me.Close()
        File.Encrypt("api.key")

    End Sub

    Private Sub forget_btn_Click(sender As Object, e As EventArgs) Handles forget_btn.Click
        'My.Settings.API_KEY = ""
        'My.Settings.Save()

        File.Decrypt("api.key")
        Dim objwriter As New System.IO.StreamWriter("api.key")
        objwriter.Write("[No Key]")
        objwriter.Close()
        Me.Close()
        File.Encrypt("api.key")

    End Sub

End Class